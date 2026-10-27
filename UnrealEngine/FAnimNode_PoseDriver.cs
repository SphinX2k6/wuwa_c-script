using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002F0 RID: 752
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_PoseDriver")]
	[UnrealStructLayout(416, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 416)]
	public class FAnimNode_PoseDriver : FAnimNode_PoseHandler, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002AD9 RID: 10969 RVA: 0x0004125C File Offset: 0x0003F45C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_PoseDriver._ScriptStructPtr != 0) ? FAnimNode_PoseDriver._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_PoseDriver", ref FAnimNode_PoseDriver._ScriptStructPtr);
		}

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x06002ADA RID: 10970 RVA: 0x00041280 File Offset: 0x0003F480
		// (set) Token: 0x06002ADB RID: 10971 RVA: 0x000412C3 File Offset: 0x0003F4C3
		public FPoseLink SourcePose
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._SourcePose) == null)
				{
					result = (this._SourcePose = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_PoseDriver.__PropertyOffset_SourcePose, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_PoseDriver.__PropertyOffset_SourcePose, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x06002ADC RID: 10972 RVA: 0x000412E4 File Offset: 0x0003F4E4
		// (set) Token: 0x06002ADD RID: 10973 RVA: 0x00041327 File Offset: 0x0003F527
		public TArray<FBoneReference> SourceBones
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBoneReference> result;
				if ((result = this._SourceBones) == null)
				{
					result = (this._SourceBones = new TArray<FBoneReference>(base.NativePtr + (IntPtr)FAnimNode_PoseDriver.__PropertyOffset_SourceBones, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SourceBones.CopyAssign(value);
			}
		}

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x06002ADE RID: 10974 RVA: 0x00041338 File Offset: 0x0003F538
		// (set) Token: 0x06002ADF RID: 10975 RVA: 0x0004137B File Offset: 0x0003F57B
		public TArray<FBoneReference> OnlyDriveBones
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBoneReference> result;
				if ((result = this._OnlyDriveBones) == null)
				{
					result = (this._OnlyDriveBones = new TArray<FBoneReference>(base.NativePtr + (IntPtr)FAnimNode_PoseDriver.__PropertyOffset_OnlyDriveBones, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.OnlyDriveBones.CopyAssign(value);
			}
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x06002AE0 RID: 10976 RVA: 0x0004138C File Offset: 0x0003F58C
		// (set) Token: 0x06002AE1 RID: 10977 RVA: 0x000413CF File Offset: 0x0003F5CF
		public TArray<FPoseDriverTarget> PoseTargets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPoseDriverTarget> result;
				if ((result = this._PoseTargets) == null)
				{
					result = (this._PoseTargets = new TArray<FPoseDriverTarget>(base.NativePtr + (IntPtr)FAnimNode_PoseDriver.__PropertyOffset_PoseTargets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PoseTargets.CopyAssign(value);
			}
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x06002AE2 RID: 10978 RVA: 0x000413DD File Offset: 0x0003F5DD
		// (set) Token: 0x06002AE3 RID: 10979 RVA: 0x000413ED File Offset: 0x0003F5ED
		public unsafe EPoseDriverOffsetType PoseDriverOffsetType
		{
			get
			{
				return (EPoseDriverOffsetType)(*(base.NativePtr + (IntPtr)FAnimNode_PoseDriver.__PropertyOffset_PoseDriverOffsetType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_PoseDriver.__PropertyOffset_PoseDriverOffsetType) = (byte)value;
			}
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x06002AE4 RID: 10980 RVA: 0x00041400 File Offset: 0x0003F600
		// (set) Token: 0x06002AE5 RID: 10981 RVA: 0x00041443 File Offset: 0x0003F643
		public FBoneReference EvalSpaceBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._EvalSpaceBone) == null)
				{
					result = (this._EvalSpaceBone = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_PoseDriver.__PropertyOffset_EvalSpaceBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_PoseDriver.__PropertyOffset_EvalSpaceBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x06002AE6 RID: 10982 RVA: 0x00041464 File Offset: 0x0003F664
		// (set) Token: 0x06002AE7 RID: 10983 RVA: 0x000414A7 File Offset: 0x0003F6A7
		public FRBFParams RBFParams
		{
			get
			{
				base.FastCheckIsValid();
				FRBFParams result;
				if ((result = this._RBFParams) == null)
				{
					result = (this._RBFParams = new FRBFParams(base.NativePtr + (IntPtr)FAnimNode_PoseDriver.__PropertyOffset_RBFParams, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRBFParams.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_PoseDriver.__PropertyOffset_RBFParams, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06002AE8 RID: 10984 RVA: 0x000414C8 File Offset: 0x0003F6C8
		// (set) Token: 0x06002AE9 RID: 10985 RVA: 0x000414D8 File Offset: 0x0003F6D8
		public unsafe EPoseDriverSource DriveSource
		{
			get
			{
				return (EPoseDriverSource)(*(base.NativePtr + (IntPtr)FAnimNode_PoseDriver.__PropertyOffset_DriveSource));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_PoseDriver.__PropertyOffset_DriveSource) = (byte)value;
			}
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06002AEA RID: 10986 RVA: 0x000414E9 File Offset: 0x0003F6E9
		// (set) Token: 0x06002AEB RID: 10987 RVA: 0x000414F9 File Offset: 0x0003F6F9
		public unsafe EPoseDriverOutput DriveOutput
		{
			get
			{
				return (EPoseDriverOutput)(*(base.NativePtr + (IntPtr)FAnimNode_PoseDriver.__PropertyOffset_DriveOutput));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_PoseDriver.__PropertyOffset_DriveOutput) = (byte)value;
			}
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06002AEC RID: 10988 RVA: 0x0004150A File Offset: 0x0003F70A
		// (set) Token: 0x06002AED RID: 10989 RVA: 0x00041523 File Offset: 0x0003F723
		public unsafe bool bOnlyDriveSelectedBones
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_PoseDriver.__PropertyOffset_bOnlyDriveSelectedBones) & FAnimNode_PoseDriver.__PropertyMask_bOnlyDriveSelectedBones) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_PoseDriver.__PropertyOffset_bOnlyDriveSelectedBones) = ((*(base.NativePtr + (IntPtr)FAnimNode_PoseDriver.__PropertyOffset_bOnlyDriveSelectedBones) & ~FAnimNode_PoseDriver.__PropertyMask_bOnlyDriveSelectedBones) | (value ? FAnimNode_PoseDriver.__PropertyMask_bOnlyDriveSelectedBones : 0));
			}
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06002AEE RID: 10990 RVA: 0x00041553 File Offset: 0x0003F753
		// (set) Token: 0x06002AEF RID: 10991 RVA: 0x00041563 File Offset: 0x0003F763
		public unsafe int LODThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_PoseDriver.__PropertyOffset_LODThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_PoseDriver.__PropertyOffset_LODThreshold) = value;
			}
		}

		// Token: 0x06002AF0 RID: 10992 RVA: 0x00041574 File Offset: 0x0003F774
		public FAnimNode_PoseDriver()
		{
		}

		// Token: 0x06002AF1 RID: 10993 RVA: 0x0004157C File Offset: 0x0003F77C
		public FAnimNode_PoseDriver(FPoseLink SourcePose, TArray<FBoneReference> SourceBones, TArray<FBoneReference> OnlyDriveBones, TArray<FPoseDriverTarget> PoseTargets, EPoseDriverOffsetType PoseDriverOffsetType, FBoneReference EvalSpaceBone, FRBFParams RBFParams, FBoneReference SourceBone_DEPRECATED, [Nullable(0)] TEnumAsByte<EBoneAxis> TwistAxis_DEPRECATED, EPoseDriverType Type_DEPRECATED, float RadialScaling_DEPRECATED, EPoseDriverSource DriveSource, EPoseDriverOutput DriveOutput, bool bOnlyDriveSelectedBones, bool bSoloDrivenOnly, int LODThreshold, UPoseAsset PoseAsset, FName GroupName, int GroupIndex_DEPRECATED, [Nullable(0)] TEnumAsByte<EAnimGroupRole> GroupRole, EAnimSyncGroupScope GroupScope, bool bIgnoreForRelevancyTest, float BlendWeight, float InternalTimeAccumulator, float CachedSequenceLength, float CachedRateScale, bool bUseSoftRef, string AnimationName)
		{
			this.SourcePose = SourcePose;
			this.SourceBones = SourceBones;
			this.OnlyDriveBones = OnlyDriveBones;
			this.PoseTargets = PoseTargets;
			this.PoseDriverOffsetType = PoseDriverOffsetType;
			this.EvalSpaceBone = EvalSpaceBone;
			this.RBFParams = RBFParams;
			this.DriveSource = DriveSource;
			this.DriveOutput = DriveOutput;
			this.bOnlyDriveSelectedBones = bOnlyDriveSelectedBones;
			this.LODThreshold = LODThreshold;
			base.PoseAsset = PoseAsset;
			base.GroupName = GroupName;
			base.GroupRole = GroupRole;
			base.GroupScope = GroupScope;
			base.bIgnoreForRelevancyTest = bIgnoreForRelevancyTest;
			base.BlendWeight = BlendWeight;
			base.InternalTimeAccumulator = InternalTimeAccumulator;
			base.CachedSequenceLength = CachedSequenceLength;
			base.CachedRateScale = CachedRateScale;
			base.bUseSoftRef = bUseSoftRef;
			base.AnimationName = AnimationName;
		}

		// Token: 0x06002AF2 RID: 10994 RVA: 0x0004163C File Offset: 0x0003F83C
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_PoseDriver.StaticStruct();
		}

		// Token: 0x06002AF3 RID: 10995 RVA: 0x00041648 File Offset: 0x0003F848
		[NullableContext(2)]
		public FAnimNode_PoseDriver(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002AF4 RID: 10996 RVA: 0x00041652 File Offset: 0x0003F852
		public FAnimNode_PoseDriver(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002AF5 RID: 10997 RVA: 0x0004165D File Offset: 0x0003F85D
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_PoseDriver(Pointer, false, true);
		}

		// Token: 0x06002AF6 RID: 10998 RVA: 0x00041667 File Offset: 0x0003F867
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_PoseDriver(Pointer, MemoryOwner);
		}

		// Token: 0x04001160 RID: 4448
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_PoseDriver";

		// Token: 0x04001161 RID: 4449
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001162 RID: 4450
		internal static int __PropertyOffset_SourcePose;

		// Token: 0x04001163 RID: 4451
		[Nullable(2)]
		private FPoseLink _SourcePose;

		// Token: 0x04001164 RID: 4452
		internal static int __PropertyOffset_SourceBones;

		// Token: 0x04001165 RID: 4453
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBoneReference> _SourceBones;

		// Token: 0x04001166 RID: 4454
		internal static int __PropertyOffset_OnlyDriveBones;

		// Token: 0x04001167 RID: 4455
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBoneReference> _OnlyDriveBones;

		// Token: 0x04001168 RID: 4456
		internal static int __PropertyOffset_PoseTargets;

		// Token: 0x04001169 RID: 4457
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPoseDriverTarget> _PoseTargets;

		// Token: 0x0400116A RID: 4458
		internal static int __PropertyOffset_PoseDriverOffsetType;

		// Token: 0x0400116B RID: 4459
		internal static int __PropertyOffset_EvalSpaceBone;

		// Token: 0x0400116C RID: 4460
		[Nullable(2)]
		private FBoneReference _EvalSpaceBone;

		// Token: 0x0400116D RID: 4461
		internal static int __PropertyOffset_RBFParams;

		// Token: 0x0400116E RID: 4462
		[Nullable(2)]
		private FRBFParams _RBFParams;

		// Token: 0x0400116F RID: 4463
		internal static int __PropertyOffset_DriveSource;

		// Token: 0x04001170 RID: 4464
		internal static int __PropertyOffset_DriveOutput;

		// Token: 0x04001171 RID: 4465
		internal static int __PropertyOffset_bOnlyDriveSelectedBones;

		// Token: 0x04001172 RID: 4466
		internal static byte __PropertyMask_bOnlyDriveSelectedBones;

		// Token: 0x04001173 RID: 4467
		internal static int __PropertyOffset_LODThreshold;
	}
}
