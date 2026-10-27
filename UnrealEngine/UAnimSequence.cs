using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000839 RID: 2105
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimSequence")]
	[UnrealStructLayout(1104, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1104)]
	public class UAnimSequence : UAnimSequenceBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007125 RID: 28965 RVA: 0x000A22D9 File Offset: 0x000A04D9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimSequence._ClassPtr;
		}

		// Token: 0x06007126 RID: 28966 RVA: 0x000A22E8 File Offset: 0x000A04E8
		public UAnimSequence() : this(BuiltinUtils.AllocNativeUObject(UAnimSequence.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007127 RID: 28967 RVA: 0x000A2310 File Offset: 0x000A0510
		public UAnimSequence(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimSequence.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001A9F RID: 6815
		// (get) Token: 0x06007128 RID: 28968 RVA: 0x000A2343 File Offset: 0x000A0543
		// (set) Token: 0x06007129 RID: 28969 RVA: 0x000A2353 File Offset: 0x000A0553
		public unsafe int NumFrames
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_NumFrames);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_NumFrames) = value;
			}
		}

		// Token: 0x17001AA0 RID: 6816
		// (get) Token: 0x0600712A RID: 28970 RVA: 0x000A2364 File Offset: 0x000A0564
		// (set) Token: 0x0600712B RID: 28971 RVA: 0x000A239D File Offset: 0x000A059D
		public TArray<FTrackToSkeletonMap> TrackToSkeletonMapTable
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTrackToSkeletonMap> result;
				if ((result = this._TrackToSkeletonMapTable) == null)
				{
					result = (this._TrackToSkeletonMapTable = new TArray<FTrackToSkeletonMap>(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_TrackToSkeletonMapTable, this));
				}
				return result;
			}
			set
			{
				this.TrackToSkeletonMapTable.CopyAssign(value);
			}
		}

		// Token: 0x17001AA1 RID: 6817
		// (get) Token: 0x0600712C RID: 28972 RVA: 0x000A23AB File Offset: 0x000A05AB
		// (set) Token: 0x0600712D RID: 28973 RVA: 0x000A23BF File Offset: 0x000A05BF
		[Nullable(2)]
		public unsafe UAnimBoneCompressionSettings BoneCompressionSettings
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimBoneCompressionSettings>(base.NativePtr / (IntPtr)sizeof(void*) + UAnimSequence.__PropertyOffset_BoneCompressionSettings);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAnimSequence.__PropertyOffset_BoneCompressionSettings, value);
			}
		}

		// Token: 0x17001AA2 RID: 6818
		// (get) Token: 0x0600712E RID: 28974 RVA: 0x000A23D4 File Offset: 0x000A05D4
		// (set) Token: 0x0600712F RID: 28975 RVA: 0x000A23E8 File Offset: 0x000A05E8
		[Nullable(2)]
		public unsafe UAnimCurveCompressionSettings CurveCompressionSettings
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimCurveCompressionSettings>(base.NativePtr / (IntPtr)sizeof(void*) + UAnimSequence.__PropertyOffset_CurveCompressionSettings);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAnimSequence.__PropertyOffset_CurveCompressionSettings, value);
			}
		}

		// Token: 0x17001AA3 RID: 6819
		// (get) Token: 0x06007130 RID: 28976 RVA: 0x000A23FD File Offset: 0x000A05FD
		// (set) Token: 0x06007131 RID: 28977 RVA: 0x000A2411 File Offset: 0x000A0611
		[Nullable(0)]
		public unsafe TEnumAsByte<EAdditiveAnimationType> AdditiveAnimType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_AdditiveAnimType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_AdditiveAnimType) = value;
			}
		}

		// Token: 0x17001AA4 RID: 6820
		// (get) Token: 0x06007132 RID: 28978 RVA: 0x000A2426 File Offset: 0x000A0626
		// (set) Token: 0x06007133 RID: 28979 RVA: 0x000A243A File Offset: 0x000A063A
		[Nullable(0)]
		public unsafe TEnumAsByte<EAdditiveBasePoseType> RefPoseType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_RefPoseType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_RefPoseType) = value;
			}
		}

		// Token: 0x17001AA5 RID: 6821
		// (get) Token: 0x06007134 RID: 28980 RVA: 0x000A244F File Offset: 0x000A064F
		// (set) Token: 0x06007135 RID: 28981 RVA: 0x000A2463 File Offset: 0x000A0663
		[Nullable(2)]
		public unsafe UAnimSequence RefPoseSeq
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimSequence>(base.NativePtr / (IntPtr)sizeof(void*) + UAnimSequence.__PropertyOffset_RefPoseSeq);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAnimSequence.__PropertyOffset_RefPoseSeq, value);
			}
		}

		// Token: 0x17001AA6 RID: 6822
		// (get) Token: 0x06007136 RID: 28982 RVA: 0x000A2478 File Offset: 0x000A0678
		// (set) Token: 0x06007137 RID: 28983 RVA: 0x000A2488 File Offset: 0x000A0688
		public unsafe int RefFrameIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_RefFrameIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_RefFrameIndex) = value;
			}
		}

		// Token: 0x17001AA7 RID: 6823
		// (get) Token: 0x06007138 RID: 28984 RVA: 0x000A2499 File Offset: 0x000A0699
		// (set) Token: 0x06007139 RID: 28985 RVA: 0x000A24AD File Offset: 0x000A06AD
		public unsafe FName RetargetSource
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_RetargetSource);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_RetargetSource) = value;
			}
		}

		// Token: 0x17001AA8 RID: 6824
		// (get) Token: 0x0600713A RID: 28986 RVA: 0x000A24C2 File Offset: 0x000A06C2
		// (set) Token: 0x0600713B RID: 28987 RVA: 0x000A24D2 File Offset: 0x000A06D2
		public unsafe EAnimInterpolationType Interpolation
		{
			get
			{
				return (EAnimInterpolationType)(*(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_Interpolation));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_Interpolation) = (byte)value;
			}
		}

		// Token: 0x17001AA9 RID: 6825
		// (get) Token: 0x0600713C RID: 28988 RVA: 0x000A24E3 File Offset: 0x000A06E3
		// (set) Token: 0x0600713D RID: 28989 RVA: 0x000A24F3 File Offset: 0x000A06F3
		public unsafe bool bHasNonUniformScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_bHasNonUniformScale) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_bHasNonUniformScale) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001AAA RID: 6826
		// (get) Token: 0x0600713E RID: 28990 RVA: 0x000A2504 File Offset: 0x000A0704
		// (set) Token: 0x0600713F RID: 28991 RVA: 0x000A2514 File Offset: 0x000A0714
		public unsafe bool bApplyRootOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_bApplyRootOffset) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_bApplyRootOffset) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001AAB RID: 6827
		// (get) Token: 0x06007140 RID: 28992 RVA: 0x000A2525 File Offset: 0x000A0725
		// (set) Token: 0x06007141 RID: 28993 RVA: 0x000A2539 File Offset: 0x000A0739
		public unsafe FTransform RootOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_RootOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_RootOffset) = value;
			}
		}

		// Token: 0x17001AAC RID: 6828
		// (get) Token: 0x06007142 RID: 28994 RVA: 0x000A254E File Offset: 0x000A074E
		// (set) Token: 0x06007143 RID: 28995 RVA: 0x000A255E File Offset: 0x000A075E
		public unsafe bool bEnableRootMotion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_bEnableRootMotion) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_bEnableRootMotion) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001AAD RID: 6829
		// (get) Token: 0x06007144 RID: 28996 RVA: 0x000A256F File Offset: 0x000A076F
		// (set) Token: 0x06007145 RID: 28997 RVA: 0x000A2583 File Offset: 0x000A0783
		[Nullable(0)]
		public unsafe TEnumAsByte<ERootMotionRootLock> RootMotionRootLock
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_RootMotionRootLock);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_RootMotionRootLock) = value;
			}
		}

		// Token: 0x17001AAE RID: 6830
		// (get) Token: 0x06007146 RID: 28998 RVA: 0x000A2598 File Offset: 0x000A0798
		// (set) Token: 0x06007147 RID: 28999 RVA: 0x000A25A8 File Offset: 0x000A07A8
		public unsafe bool bForceRootLock
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_bForceRootLock) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_bForceRootLock) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001AAF RID: 6831
		// (get) Token: 0x06007148 RID: 29000 RVA: 0x000A25B9 File Offset: 0x000A07B9
		// (set) Token: 0x06007149 RID: 29001 RVA: 0x000A25C9 File Offset: 0x000A07C9
		public unsafe bool bUseNormalizedRootMotionScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_bUseNormalizedRootMotionScale) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_bUseNormalizedRootMotionScale) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001AB0 RID: 6832
		// (get) Token: 0x0600714A RID: 29002 RVA: 0x000A25DA File Offset: 0x000A07DA
		// (set) Token: 0x0600714B RID: 29003 RVA: 0x000A25EA File Offset: 0x000A07EA
		public unsafe bool bRootMotionSettingsCopiedFromMontage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_bRootMotionSettingsCopiedFromMontage) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_bRootMotionSettingsCopiedFromMontage) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001AB1 RID: 6833
		// (get) Token: 0x0600714C RID: 29004 RVA: 0x000A25FC File Offset: 0x000A07FC
		// (set) Token: 0x0600714D RID: 29005 RVA: 0x000A2635 File Offset: 0x000A0835
		public TArray<FAnimSyncMarker> AuthoredSyncMarkers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAnimSyncMarker> result;
				if ((result = this._AuthoredSyncMarkers) == null)
				{
					result = (this._AuthoredSyncMarkers = new TArray<FAnimSyncMarker>(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_AuthoredSyncMarkers, this));
				}
				return result;
			}
			set
			{
				this.AuthoredSyncMarkers.CopyAssign(value);
			}
		}

		// Token: 0x17001AB2 RID: 6834
		// (get) Token: 0x0600714E RID: 29006 RVA: 0x000A2644 File Offset: 0x000A0844
		// (set) Token: 0x0600714F RID: 29007 RVA: 0x000A267D File Offset: 0x000A087D
		public TArray<FBakedCustomAttributePerBoneData> BakedPerBoneCustomAttributeData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBakedCustomAttributePerBoneData> result;
				if ((result = this._BakedPerBoneCustomAttributeData) == null)
				{
					result = (this._BakedPerBoneCustomAttributeData = new TArray<FBakedCustomAttributePerBoneData>(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_BakedPerBoneCustomAttributeData, this));
				}
				return result;
			}
			set
			{
				this.BakedPerBoneCustomAttributeData.CopyAssign(value);
			}
		}

		// Token: 0x17001AB3 RID: 6835
		// (get) Token: 0x06007150 RID: 29008 RVA: 0x000A268B File Offset: 0x000A088B
		// (set) Token: 0x06007151 RID: 29009 RVA: 0x000A269B File Offset: 0x000A089B
		public unsafe bool bForceFlyMotion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_bForceFlyMotion) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_bForceFlyMotion) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001AB4 RID: 6836
		// (get) Token: 0x06007152 RID: 29010 RVA: 0x000A26AC File Offset: 0x000A08AC
		// (set) Token: 0x06007153 RID: 29011 RVA: 0x000A26E5 File Offset: 0x000A08E5
		public TArray<float> ForceFlyMotionTimeArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._ForceFlyMotionTimeArray) == null)
				{
					result = (this._ForceFlyMotionTimeArray = new TArray<float>(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_ForceFlyMotionTimeArray, this));
				}
				return result;
			}
			set
			{
				this.ForceFlyMotionTimeArray.CopyAssign(value);
			}
		}

		// Token: 0x17001AB5 RID: 6837
		// (get) Token: 0x06007154 RID: 29012 RVA: 0x000A26F3 File Offset: 0x000A08F3
		// (set) Token: 0x06007155 RID: 29013 RVA: 0x000A2703 File Offset: 0x000A0903
		public unsafe byte RootMotionMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_RootMotionMask);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_RootMotionMask) = value;
			}
		}

		// Token: 0x06007156 RID: 29014 RVA: 0x000A2714 File Offset: 0x000A0914
		public void SetUseNormalizedRootMotionScale(bool bInbUseNormalizedRootMotionScale)
		{
			UAnimSequence.__SetUseNormalizedRootMotionScale_Internal(base.NativePtr, bInbUseNormalizedRootMotionScale);
		}

		// Token: 0x06007157 RID: 29015 RVA: 0x000A2722 File Offset: 0x000A0922
		public void SetRootMotionRootLock(ERootMotionRootLock InRootMotionRootLock)
		{
			UAnimSequence.__SetRootMotionRootLock_Internal(base.NativePtr, InRootMotionRootLock);
		}

		// Token: 0x06007158 RID: 29016 RVA: 0x000A2735 File Offset: 0x000A0935
		public void SetKuroRootMotionSettings(bool ForceFlyMotion)
		{
			UAnimSequence.__SetKuroRootMotionSettings_Internal(base.NativePtr, ForceFlyMotion);
		}

		// Token: 0x06007159 RID: 29017 RVA: 0x000A2743 File Offset: 0x000A0943
		public void SetForceRootLock(bool bInForceRootLock)
		{
			UAnimSequence.__SetForceRootLock_Internal(base.NativePtr, bInForceRootLock);
		}

		// Token: 0x0600715A RID: 29018 RVA: 0x000A2751 File Offset: 0x000A0951
		public void SetEnableRootMotion(bool bInEnableRootMotion)
		{
			UAnimSequence.__SetEnableRootMotion_Internal(base.NativePtr, bInEnableRootMotion);
		}

		// Token: 0x0600715B RID: 29019 RVA: 0x000A2760 File Offset: 0x000A0960
		public unsafe void GetKuroRootMotionSettings(ref bool ForceFlyMotion)
		{
			fixed (bool* ptr = &ForceFlyMotion)
			{
				void* ptr2 = (void*)ptr;
				UAnimSequence.__GetKuroRootMotionSettings_Internal(base.NativePtr, ref ForceFlyMotion);
			}
		}

		// Token: 0x0600715C RID: 29020
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUseNormalizedRootMotionScale_Internal(IntPtr @this, bool bInbUseNormalizedRootMotionScale);

		// Token: 0x0600715D RID: 29021
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRootMotionRootLock_Internal(IntPtr @this, TEnumAsByte<ERootMotionRootLock> InRootMotionRootLock);

		// Token: 0x0600715E RID: 29022
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroRootMotionSettings_Internal(IntPtr @this, bool ForceFlyMotion);

		// Token: 0x0600715F RID: 29023
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetForceRootLock_Internal(IntPtr @this, bool bInForceRootLock);

		// Token: 0x06007160 RID: 29024
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnableRootMotion_Internal(IntPtr @this, bool bInEnableRootMotion);

		// Token: 0x06007161 RID: 29025
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetKuroRootMotionSettings_Internal(IntPtr @this, ref bool ForceFlyMotion);

		// Token: 0x06007162 RID: 29026 RVA: 0x000A2781 File Offset: 0x000A0981
		static UAnimSequence()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimSequence");
		}

		// Token: 0x06007163 RID: 29027 RVA: 0x000A278F File Offset: 0x000A098F
		protected UAnimSequence(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400365B RID: 13915
		public new const string __ObjectPath = "/Script/Engine.AnimSequence";

		// Token: 0x0400365C RID: 13916
		private static IntPtr _ClassPtr;

		// Token: 0x0400365D RID: 13917
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400365E RID: 13918
		internal static int __PropertyOffset_NumFrames;

		// Token: 0x0400365F RID: 13919
		internal static int __PropertyOffset_TrackToSkeletonMapTable;

		// Token: 0x04003660 RID: 13920
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FTrackToSkeletonMap> _TrackToSkeletonMapTable;

		// Token: 0x04003661 RID: 13921
		internal static int __PropertyOffset_BoneCompressionSettings;

		// Token: 0x04003662 RID: 13922
		internal static int __PropertyOffset_CurveCompressionSettings;

		// Token: 0x04003663 RID: 13923
		internal static int __PropertyOffset_AdditiveAnimType;

		// Token: 0x04003664 RID: 13924
		internal static int __PropertyOffset_RefPoseType;

		// Token: 0x04003665 RID: 13925
		internal static int __PropertyOffset_RefPoseSeq;

		// Token: 0x04003666 RID: 13926
		internal static int __PropertyOffset_RefFrameIndex;

		// Token: 0x04003667 RID: 13927
		internal static int __PropertyOffset_RetargetSource;

		// Token: 0x04003668 RID: 13928
		internal static int __PropertyOffset_Interpolation;

		// Token: 0x04003669 RID: 13929
		internal static int __PropertyOffset_bHasNonUniformScale;

		// Token: 0x0400366A RID: 13930
		internal static int __PropertyOffset_bApplyRootOffset;

		// Token: 0x0400366B RID: 13931
		internal static int __PropertyOffset_RootOffset;

		// Token: 0x0400366C RID: 13932
		internal static int __PropertyOffset_bEnableRootMotion;

		// Token: 0x0400366D RID: 13933
		internal static int __PropertyOffset_RootMotionRootLock;

		// Token: 0x0400366E RID: 13934
		internal static int __PropertyOffset_bForceRootLock;

		// Token: 0x0400366F RID: 13935
		internal static int __PropertyOffset_bUseNormalizedRootMotionScale;

		// Token: 0x04003670 RID: 13936
		internal static int __PropertyOffset_bRootMotionSettingsCopiedFromMontage;

		// Token: 0x04003671 RID: 13937
		internal static int __PropertyOffset_AuthoredSyncMarkers;

		// Token: 0x04003672 RID: 13938
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAnimSyncMarker> _AuthoredSyncMarkers;

		// Token: 0x04003673 RID: 13939
		internal static int __PropertyOffset_BakedPerBoneCustomAttributeData;

		// Token: 0x04003674 RID: 13940
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBakedCustomAttributePerBoneData> _BakedPerBoneCustomAttributeData;

		// Token: 0x04003675 RID: 13941
		internal static int __PropertyOffset_bForceFlyMotion;

		// Token: 0x04003676 RID: 13942
		internal static int __PropertyOffset_ForceFlyMotionTimeArray;

		// Token: 0x04003677 RID: 13943
		[Nullable(2)]
		private TArray<float> _ForceFlyMotionTimeArray;

		// Token: 0x04003678 RID: 13944
		internal static int __PropertyOffset_RootMotionMask;
	}
}
