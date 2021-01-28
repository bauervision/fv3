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

        [MenuItem("GameObject/3D Object/FV/Trees/Prefabs/Basic", false, 30)]
        private static void CreateTreePrefabBasic()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__Tree_5Arms", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        #endregion

        // =============================================================================
        #region Optimized Trees

        [MenuItem("GameObject/3D Object/FV/Trees/Optimized/Basic", false, 30)]
        private static void CreateTreeOptimizedBasic()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__Tree_5Arms", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        #endregion

        // =============================================================================
        #region Foliage Branches

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Basic", false, 30)]
        private static void CreateBranchFoliageBasic()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__Tree_5Arms", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        #endregion

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


        // =============================================================================
        #region Foliage Branches(Basic)

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Basic/v1", false, 30)]
        private static void CreateBranchFoliageBasic1()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_basic_Branch_1_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Basic/v2", false, 30)]
        private static void CreateBranchFoliageBasic2()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_basic_Branch_2_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Basic/v3", false, 30)]
        private static void CreateBranchFoliageBasic3()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_basic_Branch_3_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Basic/v4", false, 30)]
        private static void CreateBranchFoliageBasic4()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_basic_Branch_4_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Basic/v5", false, 30)]
        private static void CreateBranchFoliageBasic5()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_basic_Branch_5_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Basic/v6", false, 30)]
        private static void CreateBranchFoliageBasic6()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_basic_Branch_6_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Basic/v7", false, 30)]
        private static void CreateBranchFoliageBasic7()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_basic_Branch_7_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Basic/v8", false, 30)]
        private static void CreateBranchFoliageBasic8()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_basic_Branch_8_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        #endregion

        // =============================================================================
        #region Foliage Branches(Droopy)

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Droopy/v1", false, 30)]
        private static void CreateBranchFoliageDroopy1()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_droopy_Branch_1_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Droopy/v2", false, 30)]
        private static void CreateBranchFoliageDroopy2()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_droopy_Branch_2_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Droopy/v3", false, 30)]
        private static void CreateBranchFoliageDroopy3()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_droopy_Branch_3_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Droopy/v4", false, 30)]
        private static void CreateBranchFoliageDroopy4()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_droopy_Branch_4_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Droopy/v5", false, 30)]
        private static void CreateBranchFoliageDroopy5()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_droopy_Branch_5_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Droopy/v6", false, 30)]
        private static void CreateBranchFoliageDroopy6()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_droopy_Branch_6_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Droopy/v7", false, 30)]
        private static void CreateBranchFoliageDroopy7()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_droopy_Branch_7_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Droopy/v8", false, 30)]
        private static void CreateBranchFoliageDroopy8()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_droopy_Branch_8_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        #endregion

        // =============================================================================
        #region Foliage Branches(Pine)

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Pine/v1", false, 30)]
        private static void CreateBranchFoliagePine1()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_pine_Branch_1_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Pine/v2", false, 30)]
        private static void CreateBranchFoliagePine2()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_pine_Branch_2_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Pine/v3", false, 30)]
        private static void CreateBranchFoliagePine3()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_pine_Branch_3_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Pine/v4", false, 30)]
        private static void CreateBranchFoliagePine4()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_pine_Branch_4_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Pine/v5", false, 30)]
        private static void CreateBranchFoliagePine5()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_pine_Branch_5_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Pine/v6", false, 30)]
        private static void CreateBranchFoliagePine6()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_pine_Branch_6_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Pine/v7", false, 30)]
        private static void CreateBranchFoliagePine7()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_pine_Branch_7_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Pine/v8", false, 30)]
        private static void CreateBranchFoliagePine8()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_pine_Branch_8_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        #endregion

        // =============================================================================
        #region Foliage Branches(Thin)

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Thin/v1", false, 30)]
        private static void CreateBranchFoliageThin1()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_thin_Branch_1_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Thin/v2", false, 30)]
        private static void CreateBranchFoliageThin2()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_thin_Branch_2_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Thin/v3", false, 30)]
        private static void CreateBranchFoliageThin3()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_thin_Branch_3_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Thin/v4", false, 30)]
        private static void CreateBranchFoliageThin4()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_thin_Branch_4_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Thin/v5", false, 30)]
        private static void CreateBranchFoliageThin5()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_thin_Branch_5_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Thin/v6", false, 30)]
        private static void CreateBranchFoliageThin6()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_thin_Branch_6_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Thin/v7", false, 30)]
        private static void CreateBranchFoliageThin7()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_thin_Branch_7_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Thin/v8", false, 30)]
        private static void CreateBranchFoliageThin8()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_thin_Branch_8_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        #endregion

        // =============================================================================
        #region Foliage Branches(Veiny)

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Veiny/v1", false, 30)]
        private static void CreateBranchFoliageVeiny1()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_veiny_Branch_1_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Veiny/v2", false, 30)]
        private static void CreateBranchFoliageVeiny2()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_veiny_Branch_2_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Veiny/v3", false, 30)]
        private static void CreateBranchFoliageVeiny3()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_veiny_Branch_3_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Veiny/v4", false, 30)]
        private static void CreateBranchFoliageVeiny4()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_veiny_Branch_4_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Veiny/v5", false, 30)]
        private static void CreateBranchFoliageVeiny5()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_veiny_Branch_5_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Veiny/v6", false, 30)]
        private static void CreateBranchFoliageVeiny6()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_veiny_Branch_6_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Veiny/v7", false, 30)]
        private static void CreateBranchFoliageVeiny7()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_veiny_Branch_7_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Veiny/v8", false, 30)]
        private static void CreateBranchFoliageVeiny8()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_veiny_Branch_8_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        #endregion

        // =============================================================================
        #region Foliage Branches(Wavy)

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Wavy/v1", false, 30)]
        private static void CreateBranchFoliageWavy1()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_wavy_Branch_1_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Wavy/v2", false, 30)]
        private static void CreateBranchFoliageWavy2()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_wavy_Branch_2_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Wavy/v3", false, 30)]
        private static void CreateBranchFoliageWavy3()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_wavy_Branch_3_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Wavy/v4", false, 30)]
        private static void CreateBranchFoliageWavy4()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_wavy_Branch_4_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Wavy/v5", false, 30)]
        private static void CreateBranchFoliageWavy5()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_wavy_Branch_5_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Wavy/v6", false, 30)]
        private static void CreateBranchFoliageWavy6()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_wavy_Branch_6_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Wavy/v7", false, 30)]
        private static void CreateBranchFoliageWavy7()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_wavy_Branch_7_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Branches/Foliage/Wavy/v8", false, 30)]
        private static void CreateBranchFoliageWavy8()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("foliage_wavy_Branch_8_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        #endregion



        // =============================================================================
        #region Trunks

        [MenuItem("GameObject/3D Object/FV/Trunks/v1", false, 30)]
        private static void CreateTrunkv1()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__Tree_5Arms", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        #endregion

        // =============================================================================
        #region Leaves

        [MenuItem("GameObject/3D Object/FV/Leaves/Basic", false, 30)]
        private static void CreateLeavesBasic()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_Leaves_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Leaves/Bundle 1", false, 30)]
        private static void CreateLeavesBundle1()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_LeavesBundle1_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Leaves/Bundle 2", false, 30)]
        private static void CreateLeavesBundle2()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_LeavesBundle2_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Leaves/Bundle 3", false, 30)]
        private static void CreateLeavesBundle3()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_LeavesBundle3_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }
        #endregion

        // =============================================================================
        #region Cards

        [MenuItem("GameObject/3D Object/FV/Leaves/Card v1", false, 30)]
        private static void CreateLeavesCard1()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_Card_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Leaves/Card v2", false, 30)]
        private static void CreateLeavesCard2()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_Card2_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Leaves/Card v3", false, 30)]
        private static void CreateLeavesCard3()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_Card3_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        [MenuItem("GameObject/3D Object/FV/Leaves/Card v4", false, 30)]
        private static void CreateLeavesCard4()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("_Card4_v1", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }
        #endregion

        // =============================================================================
        #region Ground Cover

        [MenuItem("GameObject/3D Object/FV/Ground Cover/Weeds/v1", false, 30)]
        private static void CreateWeeds1()
        {
            Selection.activeGameObject = PrefabUtility.InstantiatePrefab(Resources.Load("C1__Tree_5Arms", typeof(GameObject)), (Selection.activeGameObject != null) ? Selection.activeGameObject.transform : null) as GameObject;
        }

        #endregion
    }

}
#endif