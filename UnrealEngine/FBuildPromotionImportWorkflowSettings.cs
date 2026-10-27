using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008FA RID: 2298
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BuildPromotionImportWorkflowSettings")]
	[UnrealStructLayout(336, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 336)]
	public class FBuildPromotionImportWorkflowSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007E16 RID: 32278 RVA: 0x000B4B5D File Offset: 0x000B2D5D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBuildPromotionImportWorkflowSettings._ScriptStructPtr != 0) ? FBuildPromotionImportWorkflowSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BuildPromotionImportWorkflowSettings", ref FBuildPromotionImportWorkflowSettings._ScriptStructPtr);
		}

		// Token: 0x17001DA2 RID: 7586
		// (get) Token: 0x06007E17 RID: 32279 RVA: 0x000B4B84 File Offset: 0x000B2D84
		// (set) Token: 0x06007E18 RID: 32280 RVA: 0x000B4BC7 File Offset: 0x000B2DC7
		public FEditorImportWorkflowDefinition Diffuse
		{
			get
			{
				base.FastCheckIsValid();
				FEditorImportWorkflowDefinition result;
				if ((result = this._Diffuse) == null)
				{
					result = (this._Diffuse = new FEditorImportWorkflowDefinition(base.NativePtr + (IntPtr)FBuildPromotionImportWorkflowSettings.__PropertyOffset_Diffuse, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEditorImportWorkflowDefinition.StaticStruct(), base.NativePtr + (IntPtr)FBuildPromotionImportWorkflowSettings.__PropertyOffset_Diffuse, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001DA3 RID: 7587
		// (get) Token: 0x06007E19 RID: 32281 RVA: 0x000B4BE8 File Offset: 0x000B2DE8
		// (set) Token: 0x06007E1A RID: 32282 RVA: 0x000B4C2B File Offset: 0x000B2E2B
		public FEditorImportWorkflowDefinition Normal
		{
			get
			{
				base.FastCheckIsValid();
				FEditorImportWorkflowDefinition result;
				if ((result = this._Normal) == null)
				{
					result = (this._Normal = new FEditorImportWorkflowDefinition(base.NativePtr + (IntPtr)FBuildPromotionImportWorkflowSettings.__PropertyOffset_Normal, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEditorImportWorkflowDefinition.StaticStruct(), base.NativePtr + (IntPtr)FBuildPromotionImportWorkflowSettings.__PropertyOffset_Normal, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001DA4 RID: 7588
		// (get) Token: 0x06007E1B RID: 32283 RVA: 0x000B4C4C File Offset: 0x000B2E4C
		// (set) Token: 0x06007E1C RID: 32284 RVA: 0x000B4C8F File Offset: 0x000B2E8F
		public FEditorImportWorkflowDefinition StaticMesh
		{
			get
			{
				base.FastCheckIsValid();
				FEditorImportWorkflowDefinition result;
				if ((result = this._StaticMesh) == null)
				{
					result = (this._StaticMesh = new FEditorImportWorkflowDefinition(base.NativePtr + (IntPtr)FBuildPromotionImportWorkflowSettings.__PropertyOffset_StaticMesh, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEditorImportWorkflowDefinition.StaticStruct(), base.NativePtr + (IntPtr)FBuildPromotionImportWorkflowSettings.__PropertyOffset_StaticMesh, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001DA5 RID: 7589
		// (get) Token: 0x06007E1D RID: 32285 RVA: 0x000B4CB0 File Offset: 0x000B2EB0
		// (set) Token: 0x06007E1E RID: 32286 RVA: 0x000B4CF3 File Offset: 0x000B2EF3
		public FEditorImportWorkflowDefinition ReimportStaticMesh
		{
			get
			{
				base.FastCheckIsValid();
				FEditorImportWorkflowDefinition result;
				if ((result = this._ReimportStaticMesh) == null)
				{
					result = (this._ReimportStaticMesh = new FEditorImportWorkflowDefinition(base.NativePtr + (IntPtr)FBuildPromotionImportWorkflowSettings.__PropertyOffset_ReimportStaticMesh, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEditorImportWorkflowDefinition.StaticStruct(), base.NativePtr + (IntPtr)FBuildPromotionImportWorkflowSettings.__PropertyOffset_ReimportStaticMesh, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001DA6 RID: 7590
		// (get) Token: 0x06007E1F RID: 32287 RVA: 0x000B4D14 File Offset: 0x000B2F14
		// (set) Token: 0x06007E20 RID: 32288 RVA: 0x000B4D57 File Offset: 0x000B2F57
		public FEditorImportWorkflowDefinition BlendShapeMesh
		{
			get
			{
				base.FastCheckIsValid();
				FEditorImportWorkflowDefinition result;
				if ((result = this._BlendShapeMesh) == null)
				{
					result = (this._BlendShapeMesh = new FEditorImportWorkflowDefinition(base.NativePtr + (IntPtr)FBuildPromotionImportWorkflowSettings.__PropertyOffset_BlendShapeMesh, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEditorImportWorkflowDefinition.StaticStruct(), base.NativePtr + (IntPtr)FBuildPromotionImportWorkflowSettings.__PropertyOffset_BlendShapeMesh, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001DA7 RID: 7591
		// (get) Token: 0x06007E21 RID: 32289 RVA: 0x000B4D78 File Offset: 0x000B2F78
		// (set) Token: 0x06007E22 RID: 32290 RVA: 0x000B4DBB File Offset: 0x000B2FBB
		public FEditorImportWorkflowDefinition MorphMesh
		{
			get
			{
				base.FastCheckIsValid();
				FEditorImportWorkflowDefinition result;
				if ((result = this._MorphMesh) == null)
				{
					result = (this._MorphMesh = new FEditorImportWorkflowDefinition(base.NativePtr + (IntPtr)FBuildPromotionImportWorkflowSettings.__PropertyOffset_MorphMesh, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEditorImportWorkflowDefinition.StaticStruct(), base.NativePtr + (IntPtr)FBuildPromotionImportWorkflowSettings.__PropertyOffset_MorphMesh, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001DA8 RID: 7592
		// (get) Token: 0x06007E23 RID: 32291 RVA: 0x000B4DDC File Offset: 0x000B2FDC
		// (set) Token: 0x06007E24 RID: 32292 RVA: 0x000B4E1F File Offset: 0x000B301F
		public FEditorImportWorkflowDefinition SkeletalMesh
		{
			get
			{
				base.FastCheckIsValid();
				FEditorImportWorkflowDefinition result;
				if ((result = this._SkeletalMesh) == null)
				{
					result = (this._SkeletalMesh = new FEditorImportWorkflowDefinition(base.NativePtr + (IntPtr)FBuildPromotionImportWorkflowSettings.__PropertyOffset_SkeletalMesh, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEditorImportWorkflowDefinition.StaticStruct(), base.NativePtr + (IntPtr)FBuildPromotionImportWorkflowSettings.__PropertyOffset_SkeletalMesh, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001DA9 RID: 7593
		// (get) Token: 0x06007E25 RID: 32293 RVA: 0x000B4E40 File Offset: 0x000B3040
		// (set) Token: 0x06007E26 RID: 32294 RVA: 0x000B4E83 File Offset: 0x000B3083
		public FEditorImportWorkflowDefinition Animation
		{
			get
			{
				base.FastCheckIsValid();
				FEditorImportWorkflowDefinition result;
				if ((result = this._Animation) == null)
				{
					result = (this._Animation = new FEditorImportWorkflowDefinition(base.NativePtr + (IntPtr)FBuildPromotionImportWorkflowSettings.__PropertyOffset_Animation, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEditorImportWorkflowDefinition.StaticStruct(), base.NativePtr + (IntPtr)FBuildPromotionImportWorkflowSettings.__PropertyOffset_Animation, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001DAA RID: 7594
		// (get) Token: 0x06007E27 RID: 32295 RVA: 0x000B4EA4 File Offset: 0x000B30A4
		// (set) Token: 0x06007E28 RID: 32296 RVA: 0x000B4EE7 File Offset: 0x000B30E7
		public FEditorImportWorkflowDefinition Sound
		{
			get
			{
				base.FastCheckIsValid();
				FEditorImportWorkflowDefinition result;
				if ((result = this._Sound) == null)
				{
					result = (this._Sound = new FEditorImportWorkflowDefinition(base.NativePtr + (IntPtr)FBuildPromotionImportWorkflowSettings.__PropertyOffset_Sound, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEditorImportWorkflowDefinition.StaticStruct(), base.NativePtr + (IntPtr)FBuildPromotionImportWorkflowSettings.__PropertyOffset_Sound, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001DAB RID: 7595
		// (get) Token: 0x06007E29 RID: 32297 RVA: 0x000B4F08 File Offset: 0x000B3108
		// (set) Token: 0x06007E2A RID: 32298 RVA: 0x000B4F4B File Offset: 0x000B314B
		public FEditorImportWorkflowDefinition SurroundSound
		{
			get
			{
				base.FastCheckIsValid();
				FEditorImportWorkflowDefinition result;
				if ((result = this._SurroundSound) == null)
				{
					result = (this._SurroundSound = new FEditorImportWorkflowDefinition(base.NativePtr + (IntPtr)FBuildPromotionImportWorkflowSettings.__PropertyOffset_SurroundSound, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEditorImportWorkflowDefinition.StaticStruct(), base.NativePtr + (IntPtr)FBuildPromotionImportWorkflowSettings.__PropertyOffset_SurroundSound, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001DAC RID: 7596
		// (get) Token: 0x06007E2B RID: 32299 RVA: 0x000B4F6C File Offset: 0x000B316C
		// (set) Token: 0x06007E2C RID: 32300 RVA: 0x000B4FAF File Offset: 0x000B31AF
		public TArray<FEditorImportWorkflowDefinition> OtherAssetsToImport
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FEditorImportWorkflowDefinition> result;
				if ((result = this._OtherAssetsToImport) == null)
				{
					result = (this._OtherAssetsToImport = new TArray<FEditorImportWorkflowDefinition>(base.NativePtr + (IntPtr)FBuildPromotionImportWorkflowSettings.__PropertyOffset_OtherAssetsToImport, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.OtherAssetsToImport.CopyAssign(value);
			}
		}

		// Token: 0x06007E2D RID: 32301 RVA: 0x000B4FBD File Offset: 0x000B31BD
		public FBuildPromotionImportWorkflowSettings()
		{
		}

		// Token: 0x06007E2E RID: 32302 RVA: 0x000B4FC8 File Offset: 0x000B31C8
		public FBuildPromotionImportWorkflowSettings(FEditorImportWorkflowDefinition Diffuse, FEditorImportWorkflowDefinition Normal, FEditorImportWorkflowDefinition StaticMesh, FEditorImportWorkflowDefinition ReimportStaticMesh, FEditorImportWorkflowDefinition BlendShapeMesh, FEditorImportWorkflowDefinition MorphMesh, FEditorImportWorkflowDefinition SkeletalMesh, FEditorImportWorkflowDefinition Animation, FEditorImportWorkflowDefinition Sound, FEditorImportWorkflowDefinition SurroundSound, TArray<FEditorImportWorkflowDefinition> OtherAssetsToImport)
		{
			this.Diffuse = Diffuse;
			this.Normal = Normal;
			this.StaticMesh = StaticMesh;
			this.ReimportStaticMesh = ReimportStaticMesh;
			this.BlendShapeMesh = BlendShapeMesh;
			this.MorphMesh = MorphMesh;
			this.SkeletalMesh = SkeletalMesh;
			this.Animation = Animation;
			this.Sound = Sound;
			this.SurroundSound = SurroundSound;
			this.OtherAssetsToImport = OtherAssetsToImport;
		}

		// Token: 0x06007E2F RID: 32303 RVA: 0x000B5030 File Offset: 0x000B3230
		protected override IntPtr GetUStructPtr()
		{
			return FBuildPromotionImportWorkflowSettings.StaticStruct();
		}

		// Token: 0x06007E30 RID: 32304 RVA: 0x000B503C File Offset: 0x000B323C
		[NullableContext(2)]
		public FBuildPromotionImportWorkflowSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007E31 RID: 32305 RVA: 0x000B5046 File Offset: 0x000B3246
		public FBuildPromotionImportWorkflowSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007E32 RID: 32306 RVA: 0x000B5051 File Offset: 0x000B3251
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBuildPromotionImportWorkflowSettings(Pointer, false, true);
		}

		// Token: 0x06007E33 RID: 32307 RVA: 0x000B505B File Offset: 0x000B325B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBuildPromotionImportWorkflowSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04003C74 RID: 15476
		public const string __ObjectPath = "/Script/Engine.BuildPromotionImportWorkflowSettings";

		// Token: 0x04003C75 RID: 15477
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003C76 RID: 15478
		internal static int __PropertyOffset_Diffuse;

		// Token: 0x04003C77 RID: 15479
		[Nullable(2)]
		private FEditorImportWorkflowDefinition _Diffuse;

		// Token: 0x04003C78 RID: 15480
		internal static int __PropertyOffset_Normal;

		// Token: 0x04003C79 RID: 15481
		[Nullable(2)]
		private FEditorImportWorkflowDefinition _Normal;

		// Token: 0x04003C7A RID: 15482
		internal static int __PropertyOffset_StaticMesh;

		// Token: 0x04003C7B RID: 15483
		[Nullable(2)]
		private FEditorImportWorkflowDefinition _StaticMesh;

		// Token: 0x04003C7C RID: 15484
		internal static int __PropertyOffset_ReimportStaticMesh;

		// Token: 0x04003C7D RID: 15485
		[Nullable(2)]
		private FEditorImportWorkflowDefinition _ReimportStaticMesh;

		// Token: 0x04003C7E RID: 15486
		internal static int __PropertyOffset_BlendShapeMesh;

		// Token: 0x04003C7F RID: 15487
		[Nullable(2)]
		private FEditorImportWorkflowDefinition _BlendShapeMesh;

		// Token: 0x04003C80 RID: 15488
		internal static int __PropertyOffset_MorphMesh;

		// Token: 0x04003C81 RID: 15489
		[Nullable(2)]
		private FEditorImportWorkflowDefinition _MorphMesh;

		// Token: 0x04003C82 RID: 15490
		internal static int __PropertyOffset_SkeletalMesh;

		// Token: 0x04003C83 RID: 15491
		[Nullable(2)]
		private FEditorImportWorkflowDefinition _SkeletalMesh;

		// Token: 0x04003C84 RID: 15492
		internal static int __PropertyOffset_Animation;

		// Token: 0x04003C85 RID: 15493
		[Nullable(2)]
		private FEditorImportWorkflowDefinition _Animation;

		// Token: 0x04003C86 RID: 15494
		internal static int __PropertyOffset_Sound;

		// Token: 0x04003C87 RID: 15495
		[Nullable(2)]
		private FEditorImportWorkflowDefinition _Sound;

		// Token: 0x04003C88 RID: 15496
		internal static int __PropertyOffset_SurroundSound;

		// Token: 0x04003C89 RID: 15497
		[Nullable(2)]
		private FEditorImportWorkflowDefinition _SurroundSound;

		// Token: 0x04003C8A RID: 15498
		internal static int __PropertyOffset_OtherAssetsToImport;

		// Token: 0x04003C8B RID: 15499
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FEditorImportWorkflowDefinition> _OtherAssetsToImport;
	}
}
