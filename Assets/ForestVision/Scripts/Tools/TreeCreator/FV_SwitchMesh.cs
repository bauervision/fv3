using UnityEngine;
using System.Collections.Generic;
using System.Linq;

#if UNITY_EDITOR
using UnityEditor;


[ExecuteInEditMode]

public class FV_SwitchMesh : EditorWindow
{

    int speciesVersion = 1;
    int meshVersion = 1;
    bool includeChildren = true;
    bool removeFoliageBranch = false;
    bool addFoliageBranch = false;
    bool boostFoliageBranch = false;
    bool dcreaseFoliageBranch = false;
    bool selectTrunkChildren = false;


    const int foliageOptionsCount = 8;
    const int leavesOptionsCount = 4;
    const int cardOptionsCount = 4;
    const int trunkOptionsCount = 32;
    string[] resourceString = new string[] { "_FoliageBranches", "_BaseFoliage", "_Trunks" };


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



        EditorGUILayout.Space();
        if (Selection.activeGameObject)
        {

            GUILayout.Label("Switch Species on Selected", EditorStyles.boldLabel);
            includeChildren = EditorGUILayout.Toggle("Include Children?", includeChildren);
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

            GUILayout.Label("Heirarchy Selctions", EditorStyles.boldLabel);
            // Handle Parent selection options
            bool hasParent = Selection.activeGameObject.transform.parent != null;
            if (hasParent)
            {
                EditorGUILayout.Space();
                if (GUILayout.Button("Select Parent?", GUILayout.ExpandHeight(true), GUILayout.ExpandWidth(true)))
                    Selection.activeGameObject = Selection.activeGameObject.transform.parent.gameObject;

                EditorGUILayout.Space();
            }

            // Handle Child Selection options
            bool hasChildren = Selection.activeGameObject.transform.childCount > 0;
            if (hasChildren)
            {
                EditorGUILayout.Space();
                if (GUILayout.Button("Select Children?", GUILayout.ExpandHeight(true), GUILayout.ExpandWidth(true)))
                {

                    List<GameObject> children = new List<GameObject>();
                    foreach (Transform child in Selection.activeGameObject.transform)
                        children.Add(child.gameObject);

                    GameObject[] gOs = children.ToArray();
                    Selection.objects = gOs;
                }
                EditorGUILayout.Space();
            }
            else
            {
                GUILayout.Label("No children exist for this object", EditorStyles.label);
                EditorGUILayout.Space();
            }

            GUILayout.Label("Options", EditorStyles.boldLabel);
            // if we are selected on foliage...
            if (GetFoliageType("foliage"))
            {
                EditorGUILayout.Space();
                if (Selection.activeGameObject.transform.GetChild(0).GetComponent<MeshRenderer>().enabled == true)
                {
                    removeFoliageBranch = EditorGUILayout.Toggle("Remove Foliage?", removeFoliageBranch);
                    boostFoliageBranch = EditorGUILayout.Toggle("Increase Foliage?", boostFoliageBranch);
                }
                else
                    addFoliageBranch = EditorGUILayout.Toggle("Add Foliage?", addFoliageBranch);

                EditorGUILayout.Space();
            }
            // else if (GetFoliageType("foliage2"))
            // {
            //     Debug.Log("Foliage 2 selected");
            //     EditorGUILayout.Space();
            //     removeFoliageBranch = EditorGUILayout.Toggle("Remove Foliage?", removeFoliageBranch);
            //     dcreaseFoliageBranch = EditorGUILayout.Toggle("Decrease Foliage?", dcreaseFoliageBranch);
            //     EditorGUILayout.Space();
            //     boostFoliageBranch = false;
            //     addFoliageBranch = false;
            // }
            else if (GetFoliageType("_leaves"))
            {
                EditorGUILayout.Space();

                GUILayout.Label("No Options for leaves...yet", EditorStyles.label);
                EditorGUILayout.Space();
            }
            else if (GetFoliageType("_trunk"))
            {
                bool TrunkHasChildren = Selection.activeGameObject.transform.childCount > 0;
                if (hasChildren)
                {
                    EditorGUILayout.Space();
                    GUILayout.Label("Warning: you have children attached to this trunk. Adjusting this mesh will result in the child branches no longer appearing to be attached.", EditorStyles.wordWrappedLabel);
                    EditorGUILayout.Space();
                }
            }

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



    ///<summary>Check to see if the passed string matches what the meshfilter mesh name starts with. </summary>
    private bool GetFoliageType(string nameCompare)
    {
        return Selection.activeGameObject.transform.GetComponent<MeshFilter>().sharedMesh.name.StartsWith(nameCompare);
    }

    private bool GetFoliageTypeOfParent(string nameCompare)
    {
        return Selection.activeGameObject.transform.parent.transform.GetComponent<MeshFilter>().sharedMesh.name.StartsWith(nameCompare);
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


            if (oldMeshName != newMeshName)
            {
                // as long as the swap mesh is different , swap it
                foreach (Mesh mesh in fbxMeshes)
                    // run through and find the source mesh we want to switch with
                    if (mesh.name == newMeshName)// if we find the name of what we want to swap with in the fbx file
                        mf.sharedMesh = mesh;// swap meshes
            }

        }
    }

    private void SwitchMesh(GameObject thisGameObject)
    {
        Mesh[] fbxMeshes = GetFBXSource(thisGameObject);
        int resourceIndex = GetFBXResourceID(thisGameObject);

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

        // now check to see if this is a foliage mesh, which means we also will need to update the leaves mesh child IF there is one
        if (resourceIndex == 0 && thisGameObject.transform.childCount > 0)
        {
            MeshFilter leavesMF = thisGameObject.transform.GetChild(0).transform.GetComponent<MeshFilter>();
            string oldLeavesMeshName;
            string newLeavesMeshName;
            // if this gameobject has a mesh filter assigned, handle the swap
            if (leavesMF != null)
            {
                // store the name of this current mesh
                oldLeavesMeshName = leavesMF.sharedMesh.name;
                char currentSpeciesVersion = oldLeavesMeshName[oldLeavesMeshName.Length - 1];
                newLeavesMeshName = leavesMF.sharedMesh.name.Remove(leavesMF.sharedMesh.name.Length - 4) + meshVersion.ToString() + "_v" + currentSpeciesVersion;

                // handle whether we add the boost foliage or remove it
                if (addFoliageBranch)
                {
                    thisGameObject.transform.GetChild(0).transform.GetComponent<MeshRenderer>().enabled = true;
                    removeFoliageBranch = false;
                    addFoliageBranch = false;
                }

                if (removeFoliageBranch)
                {
                    thisGameObject.transform.GetChild(0).transform.GetComponent<MeshRenderer>().enabled = false;
                    removeFoliageBranch = false;
                    addFoliageBranch = false;
                }


                if (boostFoliageBranch)
                {
                    // if we have already boosted it, just change the mesh
                    if (newLeavesMeshName.Contains("c2_") || newLeavesMeshName.Contains("y2_") || newLeavesMeshName.Contains("n2_") || newLeavesMeshName.Contains("e2_"))
                        newLeavesMeshName = newLeavesMeshName.Remove(newLeavesMeshName.Length - 6) + "2_" + meshVersion.ToString() + "_v" + currentSpeciesVersion;
                    else // boost it and change the mesh
                        newLeavesMeshName = newLeavesMeshName.Remove(newLeavesMeshName.Length - 5) + "2_" + meshVersion.ToString() + "_v" + currentSpeciesVersion;



                }
                else
                {
                    // we dont want to boost foliage so we need to set it back to its original state
                    // but first check to see if it HAS been boosted
                    if (newLeavesMeshName.Contains("c2_") || newLeavesMeshName.Contains("y2_") || newLeavesMeshName.Contains("n2_") || newLeavesMeshName.Contains("e2_"))
                        newLeavesMeshName = newLeavesMeshName.Remove(newLeavesMeshName.Length - 6) + "_" + meshVersion.ToString() + "_v" + currentSpeciesVersion;
                }
                Debug.Log(newLeavesMeshName);

                if (oldLeavesMeshName != newLeavesMeshName) // as long as the swap mesh is different, swap it
                    foreach (Mesh mesh in fbxMeshes)// run through and find the source mesh we want to switch with
                        if (mesh.name == newLeavesMeshName)// if we find the name of what we want to swap with in the fbx file
                            leavesMF.sharedMesh = mesh;// swap meshes
            }



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

            case 2:// trunk needs seperate handling due to amount of options
                {
                    string zeroedMeshVersion = meshVersion < 10 ? "0" + meshVersion.ToString() : meshVersion.ToString();
                    newName = meshFilter.sharedMesh.name.Remove(meshFilter.sharedMesh.name.Length - 5) + zeroedMeshVersion + "_v" + currentSpeciesVersion;
                    break;
                }
            default:
                {
                    newName = meshFilter.sharedMesh.name.Remove(meshFilter.sharedMesh.name.Length - 4) + meshVersion.ToString() + "_v" + currentSpeciesVersion;
                    break;
                }
        }
        return newName;
    }

    private Mesh[] GetFBXSource(GameObject selObject)
    {
        return Resources.LoadAll<Mesh>(resourceString[GetFBXResourceID(selObject)]);
    }

    private int GetFBXResourceID(GameObject selObject)
    {
        bool leavesMesh = selObject.transform.GetComponent<MeshFilter>().sharedMesh.name.StartsWith("_L");
        bool cardMesh = selObject.transform.GetComponent<MeshFilter>().sharedMesh.name.StartsWith("_C");
        if (leavesMesh || cardMesh)
            return 1;

        bool trunkMesh = selObject.transform.GetComponent<MeshFilter>().sharedMesh.name.StartsWith("_trunk");
        if (trunkMesh)
            return 2;

        return 0;// foliage
    }

    private int GetFBXResourceMeshCount(GameObject selObject)
    {
        bool leavesMesh = selObject.transform.GetComponent<MeshFilter>().sharedMesh.name.StartsWith("_L");
        if (leavesMesh)
            return leavesOptionsCount;

        bool cardMesh = selObject.transform.GetComponent<MeshFilter>().sharedMesh.name.StartsWith("_C");
        if (cardMesh)
            return cardOptionsCount;

        bool trunkMesh = selObject.transform.GetComponent<MeshFilter>().sharedMesh.name.StartsWith("_trunk");
        if (trunkMesh)
            return trunkOptionsCount;

        return foliageOptionsCount;

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