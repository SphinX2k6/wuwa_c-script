using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001619 RID: 5657
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.AnimNode_MountBuffer")]
	[UnrealStructLayout(592, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 592)]
	public class FAnimNode_MountBuffer : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014706 RID: 83718 RVA: 0x001E0E6C File Offset: 0x001DF06C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_MountBuffer._ScriptStructPtr != 0) ? FAnimNode_MountBuffer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.AnimNode_MountBuffer", ref FAnimNode_MountBuffer._ScriptStructPtr);
		}

		// Token: 0x17005061 RID: 20577
		// (get) Token: 0x06014707 RID: 83719 RVA: 0x001E0E90 File Offset: 0x001DF090
		// (set) Token: 0x06014708 RID: 83720 RVA: 0x001E0ED3 File Offset: 0x001DF0D3
		public FBoneReference MountBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._MountBone) == null)
				{
					result = (this._MountBone = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_MountBuffer.__PropertyOffset_MountBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_MountBuffer.__PropertyOffset_MountBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005062 RID: 20578
		// (get) Token: 0x06014709 RID: 83721 RVA: 0x001E0EF4 File Offset: 0x001DF0F4
		// (set) Token: 0x0601470A RID: 83722 RVA: 0x001E0F04 File Offset: 0x001DF104
		public unsafe float PowerIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_MountBuffer.__PropertyOffset_PowerIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_MountBuffer.__PropertyOffset_PowerIntensity) = value;
			}
		}

		// Token: 0x17005063 RID: 20579
		// (get) Token: 0x0601470B RID: 83723 RVA: 0x001E0F15 File Offset: 0x001DF115
		// (set) Token: 0x0601470C RID: 83724 RVA: 0x001E0F25 File Offset: 0x001DF125
		public unsafe float AirResistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_MountBuffer.__PropertyOffset_AirResistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_MountBuffer.__PropertyOffset_AirResistance) = value;
			}
		}

		// Token: 0x17005064 RID: 20580
		// (get) Token: 0x0601470D RID: 83725 RVA: 0x001E0F36 File Offset: 0x001DF136
		// (set) Token: 0x0601470E RID: 83726 RVA: 0x001E0F46 File Offset: 0x001DF146
		public unsafe float MetaDeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_MountBuffer.__PropertyOffset_MetaDeltaTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_MountBuffer.__PropertyOffset_MetaDeltaTime) = value;
			}
		}

		// Token: 0x17005065 RID: 20581
		// (get) Token: 0x0601470F RID: 83727 RVA: 0x001E0F57 File Offset: 0x001DF157
		// (set) Token: 0x06014710 RID: 83728 RVA: 0x001E0F67 File Offset: 0x001DF167
		public unsafe float InertanceIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_MountBuffer.__PropertyOffset_InertanceIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_MountBuffer.__PropertyOffset_InertanceIntensity) = value;
			}
		}

		// Token: 0x06014711 RID: 83729 RVA: 0x001E0F78 File Offset: 0x001DF178
		public FAnimNode_MountBuffer()
		{
		}

		// Token: 0x06014712 RID: 83730 RVA: 0x001E0F80 File Offset: 0x001DF180
		public FAnimNode_MountBuffer(FBoneReference MountBone, float PowerIntensity, float AirResistance, float MetaDeltaTime, float InertanceIntensity, FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.MountBone = MountBone;
			this.PowerIntensity = PowerIntensity;
			this.AirResistance = AirResistance;
			this.MetaDeltaTime = MetaDeltaTime;
			this.InertanceIntensity = InertanceIntensity;
			base.ComponentPose = ComponentPose;
			base.LODThreshold = LODThreshold;
			base.KuroLODMask = KuroLODMask;
			base.ActualAlpha = ActualAlpha;
			base.AlphaInputType = AlphaInputType;
			base.bAlphaBoolEnabled = bAlphaBoolEnabled;
			base.bParallelEvalEnabled = bParallelEvalEnabled;
			base.bEnableOnMobile = bEnableOnMobile;
			base.Alpha = Alpha;
			base.AlphaScaleBias = AlphaScaleBias;
			base.AlphaBoolBlend = AlphaBoolBlend;
			base.AlphaCurveName = AlphaCurveName;
			base.AlphaScaleBiasClamp = AlphaScaleBiasClamp;
		}

		// Token: 0x06014713 RID: 83731 RVA: 0x001E1020 File Offset: 0x001DF220
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_MountBuffer.StaticStruct();
		}

		// Token: 0x06014714 RID: 83732 RVA: 0x001E102C File Offset: 0x001DF22C
		[NullableContext(2)]
		public FAnimNode_MountBuffer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014715 RID: 83733 RVA: 0x001E1036 File Offset: 0x001DF236
		public FAnimNode_MountBuffer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014716 RID: 83734 RVA: 0x001E1041 File Offset: 0x001DF241
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_MountBuffer(Pointer, false, true);
		}

		// Token: 0x06014717 RID: 83735 RVA: 0x001E104B File Offset: 0x001DF24B
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_MountBuffer(Pointer, MemoryOwner);
		}

		// Token: 0x0400B1E9 RID: 45545
		public new const string __ObjectPath = "/Script/KuroAnim.AnimNode_MountBuffer";

		// Token: 0x0400B1EA RID: 45546
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B1EB RID: 45547
		internal static int __PropertyOffset_MountBone;

		// Token: 0x0400B1EC RID: 45548
		[Nullable(2)]
		private FBoneReference _MountBone;

		// Token: 0x0400B1ED RID: 45549
		internal static int __PropertyOffset_PowerIntensity;

		// Token: 0x0400B1EE RID: 45550
		internal static int __PropertyOffset_AirResistance;

		// Token: 0x0400B1EF RID: 45551
		internal static int __PropertyOffset_MetaDeltaTime;

		// Token: 0x0400B1F0 RID: 45552
		internal static int __PropertyOffset_InertanceIntensity;
	}
}
