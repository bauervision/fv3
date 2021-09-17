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

        [MenuItem("Tools/ForestVision/Deprecated/Browser", false, 30)]//access to everything
        private static void ShowEditor()
        {
            FV_EditorWindow.ShowEditor();
        }

        [MenuItem("Tools/ForestVision/FV Tools", false, 30)]//access to everything
        private static void ShowTools()
        {
            FV_Tools.ShowEditor();
        }

        // =============================================================================
        #region Prefab Trees

        // [MenuItem("GameObject/3D Object/FV/Trees/Prefabs/Basic", false, 30)]
        // private static void CreateTreePrefabBasic()
        // {
        //     Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__Tree_5Arms", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        // }

        #endregion

        // =============================================================================
        #region Optimized Trees

        // [MenuItem("GameObject/3D Object/FV/Trees/Optimized/Basic", false, 30)]
        // private static void CreateTreeOptimizedBasic()
        // {
        //     Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__Tree_5Arms", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        // }

        #endregion


        /*
                // =============================================================================
                #region Empty Branches(Basic)

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Basic/v1", false, 30)]
                private static void CreateBranchBareBasic1()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_basic_Branch_1_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Basic/v2", false, 30)]
                private static void CreateBranchBareBasic2()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_basic_Branch_2_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Basic/v3", false, 30)]
                private static void CreateBranchBareBasic3()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_basic_Branch_3_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Basic/v4", false, 30)]
                private static void CreateBranchBareBasic4()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_basic_Branch_4_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Basic/v5", false, 30)]
                private static void CreateBranchBareBasic5()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_basic_Branch_5_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Basic/v6", false, 30)]
                private static void CreateBranchBareBasic6()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_basic_Branch_6_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Basic/v7", false, 30)]
                private static void CreateBranchBareBasic7()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_basic_Branch_7_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Basic/v8", false, 30)]
                private static void CreateBranchBareBasic8()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_basic_Branch_8_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                #endregion

                // =============================================================================
                #region Empty Branches(Droopy)

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Droopy/v1", false, 30)]
                private static void CreateBranchBareDroopy1()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_droopy_Branch_1_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Droopy/v2", false, 30)]
                private static void CreateBranchBareDroopy2()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_droopy_Branch_2_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Droopy/v3", false, 30)]
                private static void CreateBranchBareDroopy3()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_droopy_Branch_3_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Droopy/v4", false, 30)]
                private static void CreateBranchBareDroopy4()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_droopy_Branch_4_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Droopy/v5", false, 30)]
                private static void CreateBranchBareDroopy5()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_droopy_Branch_5_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Droopy/v6", false, 30)]
                private static void CreateBranchBareDroopy6()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_droopy_Branch_6_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Droopy/v7", false, 30)]
                private static void CreateBranchBareDroopy7()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_droopy_Branch_7_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Droopy/v8", false, 30)]
                private static void CreateBranchBareDroopy8()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_droopy_Branch_8_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                #endregion

                // =============================================================================
                #region Empty Branches(Pine)

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Pine/v1", false, 30)]
                private static void CreateBranchBarePine1()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_pine_Branch_1_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Pine/v2", false, 30)]
                private static void CreateBranchBarePine2()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_pine_Branch_2_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Pine/v3", false, 30)]
                private static void CreateBranchBarePine3()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_pine_Branch_3_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Pine/v4", false, 30)]
                private static void CreateBranchBarePine4()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_pine_Branch_4_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Pine/v5", false, 30)]
                private static void CreateBranchBarePine5()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_pine_Branch_5_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Pine/v6", false, 30)]
                private static void CreateBranchBarePine6()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_pine_Branch_6_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Pine/v7", false, 30)]
                private static void CreateBranchBarePine7()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_pine_Branch_7_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Pine/v8", false, 30)]
                private static void CreateBranchBarePine8()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_pine_Branch_8_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                #endregion

                // =============================================================================
                #region Empty Branches(Thin)

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Thin/v1", false, 30)]
                private static void CreateBranchBareThin1()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_thin_Branch_1_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Thin/v2", false, 30)]
                private static void CreateBranchBareThin2()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_thin_Branch_2_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Thin/v3", false, 30)]
                private static void CreateBranchBareThin3()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_thin_Branch_3_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Thin/v4", false, 30)]
                private static void CreateBranchBareThin4()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_thin_Branch_4_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Thin/v5", false, 30)]
                private static void CreateBranchBareThin5()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_thin_Branch_5_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Thin/v6", false, 30)]
                private static void CreateBranchBareThin6()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_thin_Branch_6_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Thin/v7", false, 30)]
                private static void CreateBranchBareThin7()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_thin_Branch_7_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Thin/v8", false, 30)]
                private static void CreateBranchBareThin8()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_thin_Branch_8_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                #endregion

                // =============================================================================
                #region Empty Branches(Veiny)

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Veiny/v1", false, 30)]
                private static void CreateBranchBareVeiny1()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_veiny_Branch_1_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Veiny/v2", false, 30)]
                private static void CreateBranchBareVeiny2()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_veiny_Branch_2_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Veiny/v3", false, 30)]
                private static void CreateBranchBareVeiny3()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_veiny_Branch_3_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Veiny/v4", false, 30)]
                private static void CreateBranchBareVeiny4()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_veiny_Branch_4_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Veiny/v5", false, 30)]
                private static void CreateBranchBareVeiny5()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_veiny_Branch_5_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Veiny/v6", false, 30)]
                private static void CreateBranchBareVeiny6()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_veiny_Branch_6_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Veiny/v7", false, 30)]
                private static void CreateBranchBareVeiny7()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_veiny_Branch_7_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Veiny/v8", false, 30)]
                private static void CreateBranchBareVeiny8()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_veiny_Branch_8_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                #endregion

                // =============================================================================
                #region Empty Branches(Wavy)

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Wavy/v1", false, 30)]
                private static void CreateBranchBareWavy1()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_wavy_Branch_1_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Wavy/v2", false, 30)]
                private static void CreateBranchBareWavy2()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_wavy_Branch_2_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Wavy/v3", false, 30)]
                private static void CreateBranchBareWavy3()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_wavy_Branch_3_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Wavy/v4", false, 30)]
                private static void CreateBranchBareWavy4()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_wavy_Branch_4_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Wavy/v5", false, 30)]
                private static void CreateBranchBareWavy5()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_wavy_Branch_5_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Wavy/v6", false, 30)]
                private static void CreateBranchBareWavy6()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_wavy_Branch_6_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Wavy/v7", false, 30)]
                private static void CreateBranchBareWavy7()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_wavy_Branch_7_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                [MenuItem("GameObject/3D Object/FV/Branches/Bare/Wavy/v8", false, 30)]
                private static void CreateBranchBareWavy8()
                {
                    Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_wavy_Branch_8_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
                }

                #endregion
        */



        [MenuItem("GameObject/3D Object/FV/Branch Mesh", false, 30)]
        private static void CreateBranchFoliageBasic1()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_basic_Branch_1_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Trunk Mesh", false, 30)]
        private static void CreateStraightTrunkv1()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_trunk_01_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }



        [MenuItem("GameObject/3D Object/FV/Leaves Mesh", false, 30)]
        private static void CreateLeavesBasic()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_Leaves_1_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }


        [MenuItem("GameObject/3D Object/FV/Card Leaves", false, 30)]
        private static void CreateLeavesCard1()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_Card_1_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }


        // =============================================================================
        #region Ground Cover

        // [MenuItem("GameObject/3D Object/FV/Ground Cover/Weeds/v1", false, 30)]
        // private static void CreateWeeds1()
        // {
        //     Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__Tree_5Arms", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        // }

        #endregion
    }

}
#endif