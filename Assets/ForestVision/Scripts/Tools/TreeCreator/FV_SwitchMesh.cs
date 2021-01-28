using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;


[ExecuteInEditMode]

public class FV_SwitchMesh : EditorWindow
{

    int meshVersion = 1;
    bool includeChildren = false;

    public static void ShowWindow()
    {
        EditorWindow editorWindow = EditorWindow.GetWindow(typeof(FV_SwitchMesh));
        editorWindow.autoRepaintOnSceneChange = true;
        editorWindow.Show();
        editorWindow.titleContent = new GUIContent("Switch Mesh");

    }


    void OnGUI()
    {
        GUILayout.BeginVertical("box", GUILayout.ExpandHeight(true), GUILayout.ExpandWidth(true));

        GUILayout.Label("Switch Meshes on Selected", EditorStyles.boldLabel);
        includeChildren = EditorGUILayout.Toggle("Include Children?", includeChildren);

        EditorGUILayout.Space();

        meshVersion = EditorGUILayout.IntSlider("Variety Number", meshVersion, 1, 8);

        if (GUILayout.Button("Switch Mesh", GUILayout.ExpandHeight(true), GUILayout.ExpandWidth(true)))
        {
            var go = Selection.activeGameObject;
            if (go == null)
                if (EditorUtility.DisplayDialog("Heads Up", "Can't switch meshes without something selected", "OK"))
                    return;

            SwitchVersion();
        }

    }


    private void SwitchMesh(GameObject thisGameObject)
    {
        Mesh[] fbxMeshes = GetFBXSource(thisGameObject);

        // handle the current selection
        MeshFilter mf = thisGameObject.transform.GetComponent<MeshFilter>();
        string oldMeshName;
        string newMeshName;
        // if this gameobject has a mesh filter assigned, handle the swap
        if (mf != null)
        {
            // store the name of this current mesh
            oldMeshName = mf.sharedMesh.name;
            // remove the last character from the name, ie, the version number...add on the version number we want to switch to
            newMeshName = mf.sharedMesh.name.Remove(mf.sharedMesh.name.Length - 1) + meshVersion.ToString();

            if (oldMeshName != newMeshName) // as long as the swap mesh is different, swap it
                foreach (Mesh mesh in fbxMeshes)// run through and find the source mesh we want to switch with
                    if (mesh.name == newMeshName)// if we find the name of what we want to swap with in the fbx file
                        mf.sharedMesh = mesh;// swap meshes
        }
    }


    private Mesh[] GetFBXSource(GameObject selObject)
    {
        string[] resourceString = new string[] { "_EmptyBranches", "_FoliageBranches", "_BaseFoliage", };
        return Resources.LoadAll<Mesh>(resourceString[GetFBXResourceName(selObject)]);
    }

    private int GetFBXResourceName(GameObject selObject)
    {
        bool foliageMesh = selObject.transform.GetComponent<MeshFilter>().sharedMesh.name.StartsWith("foliage");
        if (foliageMesh)
            return 1;

        bool leavesMesh = selObject.transform.GetComponent<MeshFilter>().sharedMesh.name.StartsWith("_L");
        bool cardMesh = selObject.transform.GetComponent<MeshFilter>().sharedMesh.name.StartsWith("_C");

        if (leavesMesh || cardMesh)
            return 2;

        return 0;

    }
    public void SwitchVersion()
    {
        // run through all of the children of the current selection
        foreach (GameObject g in Selection.gameObjects)
        {
            SwitchMesh(g);

            // and now figure out if we need to switch out children of our selection
            if (g.transform.childCount > 0 && includeChildren)
                LoopThroughChildren(g);
        }
    }




    public void LoopThroughChildren(GameObject currentGameObj)
    {
        // we know for certain we have children at this point, so loop through them
        // and decide if we need to switch out meshes
        for (int i = 0; i < currentGameObj.transform.childCount; i++)
        {
            SwitchMesh(currentGameObj.transform.GetChild(i).gameObject);

            if (currentGameObj.transform.GetChild(i).transform.childCount > 0)
            {
                LoopThroughChildren(currentGameObj.transform.GetChild(i).gameObject);
            }
        }
    }



}
#endif