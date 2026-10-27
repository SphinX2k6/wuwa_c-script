using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002EA RID: 746
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_MorphTargetModifier")]
	[UnrealStructLayout(368, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 368)]
	public class FAnimNode_MorphTargetModifier : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002A6F RID: 10863 RVA: 0x000406F4 File Offset: 0x0003E8F4
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_MorphTargetModifier._ScriptStructPtr != 0) ? FAnimNode_MorphTargetModifier._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_MorphTargetModifier", ref FAnimNode_MorphTargetModifier._ScriptStructPtr);
		}

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x06002A70 RID: 10864 RVA: 0x00040718 File Offset: 0x0003E918
		// (set) Token: 0x06002A71 RID: 10865 RVA: 0x0004075B File Offset: 0x0003E95B
		public FComponentSpacePoseLink ComponentPose
		{
			get
			{
				base.FastCheckIsValid();
				FComponentSpacePoseLink result;
				if ((result = this._ComponentPose) == null)
				{
					result = (this._ComponentPose = new FComponentSpacePoseLink(base.NativePtr + (IntPtr)FAnimNode_MorphTargetModifier.__PropertyOffset_ComponentPose, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FComponentSpacePoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_MorphTargetModifier.__PropertyOffset_ComponentPose, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x06002A72 RID: 10866 RVA: 0x0004077C File Offset: 0x0003E97C
		// (set) Token: 0x06002A73 RID: 10867 RVA: 0x000407BF File Offset: 0x0003E9BF
		public FBoneReference DriverBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._DriverBone) == null)
				{
					result = (this._DriverBone = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_MorphTargetModifier.__PropertyOffset_DriverBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_MorphTargetModifier.__PropertyOffset_DriverBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06002A74 RID: 10868 RVA: 0x000407E0 File Offset: 0x0003E9E0
		// (set) Token: 0x06002A75 RID: 10869 RVA: 0x00040823 File Offset: 0x0003EA23
		public FPerPlatformInt MinModLOD
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformInt result;
				if ((result = this._MinModLOD) == null)
				{
					result = (this._MinModLOD = new FPerPlatformInt(base.NativePtr + (IntPtr)FAnimNode_MorphTargetModifier.__PropertyOffset_MinModLOD, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformInt.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_MorphTargetModifier.__PropertyOffset_MinModLOD, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06002A76 RID: 10870 RVA: 0x00040844 File Offset: 0x0003EA44
		// (set) Token: 0x06002A77 RID: 10871 RVA: 0x00040887 File Offset: 0x0003EA87
		public FPerPlatformInt MaxModLOD
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformInt result;
				if ((result = this._MaxModLOD) == null)
				{
					result = (this._MaxModLOD = new FPerPlatformInt(base.NativePtr + (IntPtr)FAnimNode_MorphTargetModifier.__PropertyOffset_MaxModLOD, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformInt.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_MorphTargetModifier.__PropertyOffset_MaxModLOD, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06002A78 RID: 10872 RVA: 0x000408A8 File Offset: 0x0003EAA8
		// (set) Token: 0x06002A79 RID: 10873 RVA: 0x000408B8 File Offset: 0x0003EAB8
		public unsafe float MaxDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_MorphTargetModifier.__PropertyOffset_MaxDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_MorphTargetModifier.__PropertyOffset_MaxDistance) = value;
			}
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x06002A7A RID: 10874 RVA: 0x000408CC File Offset: 0x0003EACC
		// (set) Token: 0x06002A7B RID: 10875 RVA: 0x0004090F File Offset: 0x0003EB0F
		public TArray<FMorphTargetModifierConfig> ModifierConfigs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMorphTargetModifierConfig> result;
				if ((result = this._ModifierConfigs) == null)
				{
					result = (this._ModifierConfigs = new TArray<FMorphTargetModifierConfig>(base.NativePtr + (IntPtr)FAnimNode_MorphTargetModifier.__PropertyOffset_ModifierConfigs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ModifierConfigs.CopyAssign(value);
			}
		}

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x06002A7C RID: 10876 RVA: 0x0004091D File Offset: 0x0003EB1D
		// (set) Token: 0x06002A7D RID: 10877 RVA: 0x00040931 File Offset: 0x0003EB31
		[Nullable(2)]
		public unsafe UWorld WorldContext
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UWorld>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_MorphTargetModifier.__PropertyOffset_WorldContext);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_MorphTargetModifier.__PropertyOffset_WorldContext, value);
			}
		}

		// Token: 0x06002A7E RID: 10878 RVA: 0x00040946 File Offset: 0x0003EB46
		public FAnimNode_MorphTargetModifier()
		{
		}

		// Token: 0x06002A7F RID: 10879 RVA: 0x0004094E File Offset: 0x0003EB4E
		public FAnimNode_MorphTargetModifier(FComponentSpacePoseLink ComponentPose, FBoneReference DriverBone, FPerPlatformInt MinModLOD, FPerPlatformInt MaxModLOD, bool bDrawDriverBoneWidget, bool bUsePreviewCamera, ACameraActor PreviewCamera, FVector PreviewCameraLocation, FTransform CachedDriverBoneTransform, float MaxDistance, TArray<FMorphTargetModifierConfig> ModifierConfigs, UWorld WorldContext)
		{
			this.ComponentPose = ComponentPose;
			this.DriverBone = DriverBone;
			this.MinModLOD = MinModLOD;
			this.MaxModLOD = MaxModLOD;
			this.MaxDistance = MaxDistance;
			this.ModifierConfigs = ModifierConfigs;
			this.WorldContext = WorldContext;
		}

		// Token: 0x06002A80 RID: 10880 RVA: 0x0004098B File Offset: 0x0003EB8B
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_MorphTargetModifier.StaticStruct();
		}

		// Token: 0x06002A81 RID: 10881 RVA: 0x00040997 File Offset: 0x0003EB97
		[NullableContext(2)]
		public FAnimNode_MorphTargetModifier(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002A82 RID: 10882 RVA: 0x000409A1 File Offset: 0x0003EBA1
		public FAnimNode_MorphTargetModifier(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002A83 RID: 10883 RVA: 0x000409AC File Offset: 0x0003EBAC
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_MorphTargetModifier(Pointer, false, true);
		}

		// Token: 0x06002A84 RID: 10884 RVA: 0x000409B6 File Offset: 0x0003EBB6
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_MorphTargetModifier(Pointer, MemoryOwner);
		}

		// Token: 0x0400112B RID: 4395
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_MorphTargetModifier";

		// Token: 0x0400112C RID: 4396
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400112D RID: 4397
		internal static int __PropertyOffset_ComponentPose;

		// Token: 0x0400112E RID: 4398
		[Nullable(2)]
		private FComponentSpacePoseLink _ComponentPose;

		// Token: 0x0400112F RID: 4399
		internal static int __PropertyOffset_DriverBone;

		// Token: 0x04001130 RID: 4400
		[Nullable(2)]
		private FBoneReference _DriverBone;

		// Token: 0x04001131 RID: 4401
		internal static int __PropertyOffset_MinModLOD;

		// Token: 0x04001132 RID: 4402
		[Nullable(2)]
		private FPerPlatformInt _MinModLOD;

		// Token: 0x04001133 RID: 4403
		internal static int __PropertyOffset_MaxModLOD;

		// Token: 0x04001134 RID: 4404
		[Nullable(2)]
		private FPerPlatformInt _MaxModLOD;

		// Token: 0x04001135 RID: 4405
		internal static int __PropertyOffset_MaxDistance;

		// Token: 0x04001136 RID: 4406
		internal static int __PropertyOffset_ModifierConfigs;

		// Token: 0x04001137 RID: 4407
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMorphTargetModifierConfig> _ModifierConfigs;

		// Token: 0x04001138 RID: 4408
		internal static int __PropertyOffset_WorldContext;
	}
}
