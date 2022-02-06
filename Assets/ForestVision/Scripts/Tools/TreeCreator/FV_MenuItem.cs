using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
//============================================================================
//
//			Used for ForestVision Menu Items
//
//============================================================================
namespace ForestVision.FV_TreeEditor
{
    public static class MenuItems
    {

        #region Main Menu Tools
        [MenuItem("Tools/ForestVision/FV All Tools", false, 30)]//access to everything
        private static void ShowTools()
        {
            FV_Tools.ShowEditor();
        }

        [MenuItem("Tools/ForestVision/Tools/Switch Mesh", false, 30)]//access to everything
        private static void ShowToolSwitchMesh()
        {
            FV_SwitchMesh.ShowWindow();
        }

        [MenuItem("Tools/ForestVision/Tools/Swap Material", false, 30)]//access to everything
        private static void ShowToolSwapMaterial()
        {
            FV_SwapMat.ShowWindow();
        }

        [MenuItem("Tools/ForestVision/Tools/New Optimized", false, 30)]//access to everything
        private static void ShowToolNewOptimized()
        {
            FV_Collapse.ShowWindow();
        }

        [MenuItem("Tools/ForestVision/Tools/New Prefab", false, 30)]//access to everything
        private static void ShowToolNewPrefab()
        {
            FV_Prefabber.ShowWindow();
        }

        [MenuItem("Tools/ForestVision/Tools/Renamer", false, 30)]//access to everything
        private static void ShowToolRenamer()
        {
            FV_Renamer.ShowWindow();
        }



        [MenuItem("Tools/ForestVision/Tools/Screenshot", false, 30)]//access to everything
        private static void ShowToolScreenshot()
        {
            FV_Screenshots.ShowWindow();
        }



        [MenuItem("Tools/ForestVision/Deprecated/Browser", false, 30)]//access to everything
        private static void ShowEditor()
        {
            FV_Browser.ShowEditor();
        }


        [MenuItem("Tools/ForestVision/Deprecated/Tree Tools", false, 30)]//access to everything
        private static void ShowToolTreeTools()
        {
            FV_TreeTools.ShowWindow();
        }

        #endregion

        #region Assets

        [MenuItem("GameObject/3D Object/ForestVision/Assets/Trunk", false, 30)]
        private static void CreateStraightTrunkv1()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_trunk_01_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/ForestVision/Assets/Branch", false, 30)]
        private static void CreateBranchFoliageBasic1()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_basic_Branch_1_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }


        [MenuItem("GameObject/3D Object/ForestVision/Assets/Leaves", false, 30)]
        private static void CreateLeavesBasic()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_Leaves_1_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }


        [MenuItem("GameObject/3D Object/ForestVision/Assets/Card Leaves", false, 30)]
        private static void CreateLeavesCard1()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_Card_1_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/ForestVision/Assets/Hi Plant", false, 30)]
        private static void CreateHiPlant()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("HP_01", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/ForestVision/Assets/Grass", false, 30)]
        private static void CreateGrass()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("Grasses_01", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/ForestVision/Assets/Flower", false, 30)]
        private static void CreateFlowers()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("Flowers_01", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/ForestVision/Assets/Rock", false, 30)]
        private static void CreateRocks()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("Rocks_01_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/ForestVision/Assets/Scatter", false, 30)]
        private static void CreateScatter()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("Scatter_01_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/ForestVision/Assets/Woods Background", false, 30)]
        private static void CreateBG()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("ThickWoods", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }
        #endregion

    }

}
#endif