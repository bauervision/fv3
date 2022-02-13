using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System;

#if UNITY_EDITOR
using UnityEditor;


[ExecuteInEditMode]

public class FV_Tweaker : EditorWindow
{
    private bool tweakScaling;
    private float scaleAmount = 1;
    private float oldScaleAmount = 1;
    private float rotationAmount = 1;
    private float oldRotationAmount = 1;
    private float positionAmount = 1;
    private float oldPositionAmount = 1;

    private bool tweakPosition;
    private bool tweakRotation;


    public static void ShowWindow()
    {
        EditorWindow editorWindow = EditorWindow.GetWindow(typeof(FV_Tweaker));
        editorWindow.autoRepaintOnSceneChange = true;
        editorWindow.Show();
        editorWindow.titleContent = new GUIContent("Tree Tweaker");

    }


    void OnGUI()
    {
        GUILayout.BeginVertical("box", GUILayout.ExpandHeight(true), GUILayout.ExpandWidth(true));

        EditorGUILayout.Space();
        if (Selection.activeGameObject)
        {

            // hi plants, grasses and flowers dont have species ...yet
            GUILayout.Label("Switch Species on Selected", EditorStyles.boldLabel);
            //includeChildren = EditorGUILayout.Toggle("Include Children?", includeChildren);




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

            GUILayout.Label("Tweak", EditorStyles.boldLabel);
            tweakPosition = EditorGUILayout.Toggle("Tweak Position?", tweakPosition);
            if (tweakPosition)
            {
                positionAmount = EditorGUILayout.Slider("Tweak Amount", positionAmount, -2, 2);
                if (positionAmount != oldPositionAmount)
                    RePosition(positionAmount);
                oldPositionAmount = positionAmount;

            }

            tweakRotation = EditorGUILayout.Toggle("Tweak Rotations?", tweakRotation);
            if (tweakRotation)
            {
                rotationAmount = EditorGUILayout.Slider("Tweak Amount", rotationAmount, 0, 1);
                if (rotationAmount != oldRotationAmount)
                    RotateSelected(rotationAmount);
                oldRotationAmount = rotationAmount;

            }

            tweakScaling = EditorGUILayout.Toggle("Tweak Scaling?", tweakScaling);
            if (tweakScaling)
            {
                scaleAmount = EditorGUILayout.Slider("Tweak Amount", scaleAmount, 0.5f, 2);
                if (scaleAmount != oldScaleAmount)
                    ScaleAll(scaleAmount);
                oldScaleAmount = scaleAmount;

            }

        }
        else
        {
            GUILayout.Label("Select something to see your options", EditorStyles.boldLabel);
        }

    }


    void RePosition(float offset)
    {
        Vector3 newPos;

        foreach (GameObject g in Selection.gameObjects)
        {
            float randomValue = UnityEngine.Random.Range(0.1f, 0.4f);
            newPos.x = offset * randomValue + UnityEngine.Random.Range(-0.5f, 0.5f);
            newPos.y = UnityEngine.Random.Range(-0.2f, 0.2f);
            newPos.z = offset * randomValue + UnityEngine.Random.Range(-0.5f, 0.5f);
            g.transform.position = g.transform.position + new Vector3(newPos.x, newPos.y, newPos.z);

        }

    }

    void RotateSelected(float rotationAmount)
    {
        Vector3 newRotation;

        foreach (GameObject g in Selection.gameObjects)
        {
            newRotation.x = UnityEngine.Random.Range(-7f, 7f) * rotationAmount;
            newRotation.y = UnityEngine.Random.Range(-90f, 90f) * rotationAmount;
            newRotation.z = UnityEngine.Random.Range(-7f, 7f) * rotationAmount;
            g.transform.localRotation = Quaternion.Euler(newRotation.x, newRotation.y, newRotation.z);

        }

    }

    void ScaleAll(float scaleAmount)
    {
        Vector3 newScale;

        foreach (GameObject g in Selection.gameObjects)
        {
            float randomValue = UnityEngine.Random.Range(0.93f, 1.7f);
            newScale.x = scaleAmount * randomValue;
            newScale.y = scaleAmount * randomValue;
            newScale.z = scaleAmount * randomValue;
            g.transform.localScale = new Vector3(newScale.x, newScale.y, newScale.z);

        }

    }

    /*
        private void RotateChildren(float deg, bool children, rotAxis axis, bool space)
        {
            if (children)
            {
                foreach (GameObject g in Selection.gameObjects)
                {
                    for (int i = 0; i < g.transform.childCount; i++)
                    {
                        if (g.transform.GetChild(i).name.EndsWith("FVbranch"))
                        {
                            switch ((int)axis)
                            {
                                case 0:
                                    if (space)
                                    {
                                        g.transform.GetChild(i).Rotate(deg, 0, 0, Space.Self);
                                    }
                                    else
                                    {
                                        g.transform.GetChild(i).Rotate(deg, 0, 0, Space.World);
                                    }
                                    break;
                                case 1:
                                    if (space)
                                    {
                                        g.transform.GetChild(i).Rotate(0, deg, 0, Space.Self);
                                    }
                                    else
                                    {
                                        g.transform.GetChild(i).Rotate(0, deg, 0, Space.World);
                                    }
                                    break;
                                case 2:
                                    if (space)
                                    {
                                        g.transform.GetChild(i).Rotate(0, 0, deg, Space.Self);
                                    }
                                    else
                                    {
                                        g.transform.GetChild(i).Rotate(0, 0, deg, Space.World);
                                    }
                                    break;

                            }
                        }
                    }

                }
            }
            else
            {
                switch ((int)axis)
                {
                    case 0:
                        if (space)
                        {
                            Selection.activeGameObject.transform.Rotate(deg, 0, 0, Space.Self);
                        }
                        else
                        {
                            Selection.activeGameObject.transform.Rotate(deg, 0, 0, Space.World);
                        }
                        break;
                    case 1:
                        if (space)
                        {
                            Selection.activeGameObject.transform.Rotate(0, deg, 0, Space.Self);
                        }
                        else
                        {
                            Selection.activeGameObject.transform.Rotate(0, deg, 0, Space.World);
                        }
                        break;
                    case 2:
                        if (space)
                        {
                            Selection.activeGameObject.transform.Rotate(0, 0, deg, Space.Self);
                        }
                        else
                        {
                            Selection.activeGameObject.transform.Rotate(0, 0, deg, Space.World);
                        }
                        break;

                }
                Selection.activeGameObject.transform.Rotate(0, deg, 0, Space.Self);
            }
        }

    */
    public void LoopThroughChildren(GameObject currentGameObj)
    {

        // we know for certain we have children at this point, so loop through them
        // and decide if we need to switch out meshes
        for (int i = 0; i < currentGameObj.transform.childCount; i++)
        {
            //SwitchSpecies(currentGameObj.transform.GetChild(i).gameObject);

            if (currentGameObj.transform.GetChild(i).transform.childCount > 0)
            {
                LoopThroughChildren(currentGameObj.transform.GetChild(i).gameObject);
            }
        }
    }

    public void LoopThroughChildren(GameObject currentGameObj, int newValue)
    {

        // we know for certain we have children at this point, so loop through them
        // and decide if we need to switch out meshes
        for (int i = 0; i < currentGameObj.transform.childCount; i++)
        {
            //do something

            if (currentGameObj.transform.GetChild(i).transform.childCount > 0)
            {
                LoopThroughChildren(currentGameObj.transform.GetChild(i).gameObject);
            }
        }
    }




}
#endif