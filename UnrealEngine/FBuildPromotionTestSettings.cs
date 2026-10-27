using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008FD RID: 2301
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BuildPromotionTestSettings")]
	[UnrealStructLayout(496, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 496)]
	public class FBuildPromotionTestSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007E54 RID: 32340 RVA: 0x000B5455 File Offset: 0x000B3655
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBuildPromotionTestSettings._ScriptStructPtr != 0) ? FBuildPromotionTestSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BuildPromotionTestSettings", ref FBuildPromotionTestSettings._ScriptStructPtr);
		}

		// Token: 0x17001DB5 RID: 7605
		// (get) Token: 0x06007E55 RID: 32341 RVA: 0x000B547C File Offset: 0x000B367C
		// (set) Token: 0x06007E56 RID: 32342 RVA: 0x000B54BF File Offset: 0x000B36BF
		public FFilePath DefaultStaticMeshAsset
		{
			get
			{
				base.FastCheckIsValid();
				FFilePath result;
				if ((result = this._DefaultStaticMeshAsset) == null)
				{
					result = (this._DefaultStaticMeshAsset = new FFilePath(base.NativePtr + (IntPtr)FBuildPromotionTestSettings.__PropertyOffset_DefaultStaticMeshAsset, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFilePath.StaticStruct(), base.NativePtr + (IntPtr)FBuildPromotionTestSettings.__PropertyOffset_DefaultStaticMeshAsset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001DB6 RID: 7606
		// (get) Token: 0x06007E57 RID: 32343 RVA: 0x000B54E0 File Offset: 0x000B36E0
		// (set) Token: 0x06007E58 RID: 32344 RVA: 0x000B5523 File Offset: 0x000B3723
		public FBuildPromotionImportWorkflowSettings ImportWorkflow
		{
			get
			{
				base.FastCheckIsValid();
				FBuildPromotionImportWorkflowSettings result;
				if ((result = this._ImportWorkflow) == null)
				{
					result = (this._ImportWorkflow = new FBuildPromotionImportWorkflowSettings(base.NativePtr + (IntPtr)FBuildPromotionTestSettings.__PropertyOffset_ImportWorkflow, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBuildPromotionImportWorkflowSettings.StaticStruct(), base.NativePtr + (IntPtr)FBuildPromotionTestSettings.__PropertyOffset_ImportWorkflow, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001DB7 RID: 7607
		// (get) Token: 0x06007E59 RID: 32345 RVA: 0x000B5544 File Offset: 0x000B3744
		// (set) Token: 0x06007E5A RID: 32346 RVA: 0x000B5587 File Offset: 0x000B3787
		public FBuildPromotionOpenAssetSettings OpenAssets
		{
			get
			{
				base.FastCheckIsValid();
				FBuildPromotionOpenAssetSettings result;
				if ((result = this._OpenAssets) == null)
				{
					result = (this._OpenAssets = new FBuildPromotionOpenAssetSettings(base.NativePtr + (IntPtr)FBuildPromotionTestSettings.__PropertyOffset_OpenAssets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBuildPromotionOpenAssetSettings.StaticStruct(), base.NativePtr + (IntPtr)FBuildPromotionTestSettings.__PropertyOffset_OpenAssets, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001DB8 RID: 7608
		// (get) Token: 0x06007E5B RID: 32347 RVA: 0x000B55A8 File Offset: 0x000B37A8
		// (set) Token: 0x06007E5C RID: 32348 RVA: 0x000B55EB File Offset: 0x000B37EB
		public FBuildPromotionNewProjectSettings NewProjectSettings
		{
			get
			{
				base.FastCheckIsValid();
				FBuildPromotionNewProjectSettings result;
				if ((result = this._NewProjectSettings) == null)
				{
					result = (this._NewProjectSettings = new FBuildPromotionNewProjectSettings(base.NativePtr + (IntPtr)FBuildPromotionTestSettings.__PropertyOffset_NewProjectSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBuildPromotionNewProjectSettings.StaticStruct(), base.NativePtr + (IntPtr)FBuildPromotionTestSettings.__PropertyOffset_NewProjectSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001DB9 RID: 7609
		// (get) Token: 0x06007E5D RID: 32349 RVA: 0x000B560C File Offset: 0x000B380C
		// (set) Token: 0x06007E5E RID: 32350 RVA: 0x000B564F File Offset: 0x000B384F
		public FFilePath SourceControlMaterial
		{
			get
			{
				base.FastCheckIsValid();
				FFilePath result;
				if ((result = this._SourceControlMaterial) == null)
				{
					result = (this._SourceControlMaterial = new FFilePath(base.NativePtr + (IntPtr)FBuildPromotionTestSettings.__PropertyOffset_SourceControlMaterial, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFilePath.StaticStruct(), base.NativePtr + (IntPtr)FBuildPromotionTestSettings.__PropertyOffset_SourceControlMaterial, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06007E5F RID: 32351 RVA: 0x000B5670 File Offset: 0x000B3870
		public FBuildPromotionTestSettings()
		{
		}

		// Token: 0x06007E60 RID: 32352 RVA: 0x000B5678 File Offset: 0x000B3878
		public FBuildPromotionTestSettings(FFilePath DefaultStaticMeshAsset, FBuildPromotionImportWorkflowSettings ImportWorkflow, FBuildPromotionOpenAssetSettings OpenAssets, FBuildPromotionNewProjectSettings NewProjectSettings, FFilePath SourceControlMaterial)
		{
			this.DefaultStaticMeshAsset = DefaultStaticMeshAsset;
			this.ImportWorkflow = ImportWorkflow;
			this.OpenAssets = OpenAssets;
			this.NewProjectSettings = NewProjectSettings;
			this.SourceControlMaterial = SourceControlMaterial;
		}

		// Token: 0x06007E61 RID: 32353 RVA: 0x000B56A5 File Offset: 0x000B38A5
		protected override IntPtr GetUStructPtr()
		{
			return FBuildPromotionTestSettings.StaticStruct();
		}

		// Token: 0x06007E62 RID: 32354 RVA: 0x000B56B1 File Offset: 0x000B38B1
		[NullableContext(2)]
		public FBuildPromotionTestSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007E63 RID: 32355 RVA: 0x000B56BB File Offset: 0x000B38BB
		public FBuildPromotionTestSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007E64 RID: 32356 RVA: 0x000B56C6 File Offset: 0x000B38C6
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBuildPromotionTestSettings(Pointer, false, true);
		}

		// Token: 0x06007E65 RID: 32357 RVA: 0x000B56D0 File Offset: 0x000B38D0
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBuildPromotionTestSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04003C9F RID: 15519
		public const string __ObjectPath = "/Script/Engine.BuildPromotionTestSettings";

		// Token: 0x04003CA0 RID: 15520
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003CA1 RID: 15521
		internal static int __PropertyOffset_DefaultStaticMeshAsset;

		// Token: 0x04003CA2 RID: 15522
		[Nullable(2)]
		private FFilePath _DefaultStaticMeshAsset;

		// Token: 0x04003CA3 RID: 15523
		internal static int __PropertyOffset_ImportWorkflow;

		// Token: 0x04003CA4 RID: 15524
		[Nullable(2)]
		private FBuildPromotionImportWorkflowSettings _ImportWorkflow;

		// Token: 0x04003CA5 RID: 15525
		internal static int __PropertyOffset_OpenAssets;

		// Token: 0x04003CA6 RID: 15526
		[Nullable(2)]
		private FBuildPromotionOpenAssetSettings _OpenAssets;

		// Token: 0x04003CA7 RID: 15527
		internal static int __PropertyOffset_NewProjectSettings;

		// Token: 0x04003CA8 RID: 15528
		[Nullable(2)]
		private FBuildPromotionNewProjectSettings _NewProjectSettings;

		// Token: 0x04003CA9 RID: 15529
		internal static int __PropertyOffset_SourceControlMaterial;

		// Token: 0x04003CAA RID: 15530
		[Nullable(2)]
		private FFilePath _SourceControlMaterial;
	}
}
