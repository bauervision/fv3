using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;


[ExecuteInEditMode]

public class FV_SwitchMesh : EditorWindow
{

    int speciesVersion = 1;
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

        GUILayout.Label("Switch Species on Selected", EditorStyles.boldLabel);
        includeChildren = EditorGUILayout.Toggle("Include Children?", includeChildren);

        EditorGUILayout.Space();
        if (Selection.activeGameObject)
        {

            speciesVersion = EditorGUILayout.IntSlider("Species Number", speciesVersion, 1, 8);



            if (GUILayout.Button("Change Species Variety", GUILayout.ExpandHeight(true), GUILayout.ExpandWidth(true)))
            {
                var go = Selection.activeGameObject;
                if (go == null)
                    if (EditorUtility.DisplayDialog("Heads Up", "Can't change without something selected", "OK"))
                        return;

                SwitchSpeciesVersion();
            }

            EditorGUILayout.Space();
            GUILayout.Label("Switch Mesh Option on Selected Only", EditorStyles.boldLabel);
            meshVersion = EditorGUILayout.IntSlider("Mesh Number", meshVersion, 1, GetFBXResourceMeshCount(Selection.activeGameObject));

            if (GUILayout.Button("Change Mesh Variety", GUILayout.ExpandHeight(true), GUILayout.ExpandWidth(true)))
            {
                var go = Selection.activeGameObject;
                if (go == null)
                    if (EditorUtility.DisplayDialog("Heads Up", "Can't change without something selected", "OK"))
                        return;

                SwitchMeshVersion();
            }
        }
        else
        {

            GUILayout.Label("Select something to see your options", EditorStyles.boldLabel);

        }

    }


    private void SwitchSpecies(GameObject thisGameObject)
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
            newMeshName = mf.sharedMesh.name.Remove(mf.sharedMesh.name.Length - 1) + speciesVersion.ToString();

            if (oldMeshName != newMeshName) // as long as the swap mesh is different, swap it
                foreach (Mesh mesh in fbxMeshes)// run through and find the source mesh we want to switch with
                    if (mesh.name == newMeshName)// if we find the name of what we want to swap with in the fbx file
                        mf.sharedMesh = mesh;// swap meshes
        }
    }

    private void SwitchMesh(GameObject thisGameObject)
    {
        Mesh[] fbxMeshes = GetFBXSource(thisGameObject);
        int resourceIndex = GetFBXResourceName(thisGameObject);

        // handle the current selection
        MeshFilter mf = thisGameObject.transform.GetComponent<MeshFilter>();
        string oldMeshName;
        string newMeshName;
        // if this gameobject has a mesh filter assigned, handle the swap
        if (mf != null)
        {
            // store the name of this current mesh
            oldMeshName = mf.sharedMesh.name;
            newMeshName = ProcessNewName(resourceIndex, mf);

            if (oldMeshName != newMeshName) // as long as the swap mesh is different, swap it
                foreach (Mesh mesh in fbxMeshes)// run through and find the source mesh we want to switch with
                    if (mesh.name == newMeshName)// if we find the name of what we want to swap with in the fbx file
                        mf.sharedMesh = mesh;// swap meshes
        }
    }

    private string ProcessNewName(int resourceIndex, MeshFilter meshFilter)
    {
        // get the current mesh name
        string MeshName = meshFilter.sharedMesh.name;
        // grab the species version currently being used
        char currentSpeciesVersion = MeshName[MeshName.Length - 1];

        string newName;
        switch (resourceIndex)
        {
            case 1:
                { // foliage_basic_Branch_8_v8
                    newName = meshFilter.sharedMesh.name.Remove(meshFilter.sharedMesh.name.Length - 4) + meshVersion.ToString() + "_v" + currentSpeciesVersion;
                    //TODO: Need to handle child as well...
                    Debug.Log(newName);
                    break;
                }
            case 2:
                { // _Card_v8, _Card2_v8  _Leaves_v2, _LeavesBundle1_v3 
                    newName = meshFilter.sharedMesh.name.Remove(meshFilter.sharedMesh.name.Length - 4) + meshVersion.ToString() + "_v" + currentSpeciesVersion;
                    Debug.Log(newName);
                    break;
                }
            case 3:
                {
                    string zeroedMeshVersion = meshVersion < 10 ? "0" + meshVersion.ToString() : meshVersion.ToString();
                    newName = meshFilter.sharedMesh.name.Remove(meshFilter.sharedMesh.name.Length - 11) + zeroedMeshVersion + "_trunk_v" + currentSpeciesVersion;
                    Debug.Log(newName);
                    break;
                }
            default:
                { // empty branches
                    newName = meshFilter.sharedMesh.name.Remove(meshFilter.sharedMesh.name.Length - 4) + meshVersion.ToString() + "_v" + currentSpeciesVersion;
                    Debug.Log(newName);
                    break;
                }
        }
        return newName;
    }
    private Mesh[] GetFBXSource(GameObject selObject)
    {
        string[] resourceString = new string[] { "_EmptyBranches", "_FoliageBranches", "_BaseFoliage", "_Trunks" };
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

        bool trunkMesh = selObject.transform.GetComponent<MeshFilter>().sharedMesh.name.StartsWith("_T_");
        if (trunkMesh)
            return 3;

        return 0;

    }

    private int GetFBXResourceMeshCount(GameObject selObject)
    {
        bool foliageMesh = selObject.transform.GetComponent<MeshFilter>().sharedMesh.name.StartsWith("foliage");
        if (foliageMesh)
            return 8;

        bool leavesMesh = selObject.transform.GetComponent<MeshFilter>().sharedMesh.name.StartsWith("_L");
        if (leavesMesh)
            return 4;

        bool cardMesh = selObject.transform.GetComponent<MeshFilter>().sharedMesh.name.StartsWith("_C");
        if (cardMesh)
            return 5;


        bool trunkMesh = selObject.transform.GetComponent<MeshFilter>().sharedMesh.name.StartsWith("_T_");
        if (trunkMesh)
            return 32;

        return 8;

    }

    public void SwitchSpeciesVersion()
    {
        // run through all of the children of the current selection
        foreach (GameObject g in Selection.gameObjects)
        {
            SwitchSpecies(g);

            // and now figure out if we need to switch out children of our selection
            if (g.transform.childCount > 0 && includeChildren)
                LoopThroughChildren(g);
        }
    }

    public void SwitchMeshVersion()
    {
        // run through all of the children of the current selection
        foreach (GameObject g in Selection.gameObjects)
            SwitchMesh(g);

    }

    public void LoopThroughChildren(GameObject currentGameObj)
    {
        // we know for certain we have children at this point, so loop through them
        // and decide if we need to switch out meshes
        for (int i = 0; i < currentGameObj.transform.childCount; i++)
        {
            SwitchSpecies(currentGameObj.transform.GetChild(i).gameObject);

            if (currentGameObj.transform.GetChild(i).transform.childCount > 0)
            {
                LoopThroughChildren(currentGameObj.transform.GetChild(i).gameObject);
            }
        }
    }

}
#endif