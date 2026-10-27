using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001686 RID: 5766
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.TrailerConnector")]
	[UnrealStructLayout(272, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 272)]
	public class FTrailerConnector : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014EBC RID: 85692 RVA: 0x001EC0B3 File Offset: 0x001EA2B3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTrailerConnector._ScriptStructPtr != 0) ? FTrailerConnector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.TrailerConnector", ref FTrailerConnector._ScriptStructPtr);
		}

		// Token: 0x170052E2 RID: 21218
		// (get) Token: 0x06014EBD RID: 85693 RVA: 0x001EC0D8 File Offset: 0x001EA2D8
		// (set) Token: 0x06014EBE RID: 85694 RVA: 0x001EC11B File Offset: 0x001EA31B
		public FBoneReference Bone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._Bone) == null)
				{
					result = (this._Bone = new FBoneReference(base.NativePtr + (IntPtr)FTrailerConnector.__PropertyOffset_Bone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FTrailerConnector.__PropertyOffset_Bone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170052E3 RID: 21219
		// (get) Token: 0x06014EBF RID: 85695 RVA: 0x001EC13C File Offset: 0x001EA33C
		// (set) Token: 0x06014EC0 RID: 85696 RVA: 0x001EC17F File Offset: 0x001EA37F
		public FVehicleAxisData Axis
		{
			get
			{
				base.FastCheckIsValid();
				FVehicleAxisData result;
				if ((result = this._Axis) == null)
				{
					result = (this._Axis = new FVehicleAxisData(base.NativePtr + (IntPtr)FTrailerConnector.__PropertyOffset_Axis, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FVehicleAxisData.StaticStruct(), base.NativePtr + (IntPtr)FTrailerConnector.__PropertyOffset_Axis, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170052E4 RID: 21220
		// (get) Token: 0x06014EC1 RID: 85697 RVA: 0x001EC1A0 File Offset: 0x001EA3A0
		// (set) Token: 0x06014EC2 RID: 85698 RVA: 0x001EC1B0 File Offset: 0x001EA3B0
		public unsafe bool bEnableYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTrailerConnector.__PropertyOffset_bEnableYaw) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTrailerConnector.__PropertyOffset_bEnableYaw) = (value ? 1 : 0);
			}
		}

		// Token: 0x170052E5 RID: 21221
		// (get) Token: 0x06014EC3 RID: 85699 RVA: 0x001EC1C1 File Offset: 0x001EA3C1
		// (set) Token: 0x06014EC4 RID: 85700 RVA: 0x001EC1D1 File Offset: 0x001EA3D1
		public unsafe bool bEnablePitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTrailerConnector.__PropertyOffset_bEnablePitch) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTrailerConnector.__PropertyOffset_bEnablePitch) = (value ? 1 : 0);
			}
		}

		// Token: 0x170052E6 RID: 21222
		// (get) Token: 0x06014EC5 RID: 85701 RVA: 0x001EC1E2 File Offset: 0x001EA3E2
		// (set) Token: 0x06014EC6 RID: 85702 RVA: 0x001EC1F2 File Offset: 0x001EA3F2
		public unsafe float YawLimitDeg
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTrailerConnector.__PropertyOffset_YawLimitDeg);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTrailerConnector.__PropertyOffset_YawLimitDeg) = value;
			}
		}

		// Token: 0x170052E7 RID: 21223
		// (get) Token: 0x06014EC7 RID: 85703 RVA: 0x001EC203 File Offset: 0x001EA403
		// (set) Token: 0x06014EC8 RID: 85704 RVA: 0x001EC213 File Offset: 0x001EA413
		public unsafe float PitchLimitDeg
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTrailerConnector.__PropertyOffset_PitchLimitDeg);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTrailerConnector.__PropertyOffset_PitchLimitDeg) = value;
			}
		}

		// Token: 0x170052E8 RID: 21224
		// (get) Token: 0x06014EC9 RID: 85705 RVA: 0x001EC224 File Offset: 0x001EA424
		// (set) Token: 0x06014ECA RID: 85706 RVA: 0x001EC234 File Offset: 0x001EA434
		public unsafe float TrailerYawMaxRateDegPerSec
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTrailerConnector.__PropertyOffset_TrailerYawMaxRateDegPerSec);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTrailerConnector.__PropertyOffset_TrailerYawMaxRateDegPerSec) = value;
			}
		}

		// Token: 0x170052E9 RID: 21225
		// (get) Token: 0x06014ECB RID: 85707 RVA: 0x001EC245 File Offset: 0x001EA445
		// (set) Token: 0x06014ECC RID: 85708 RVA: 0x001EC255 File Offset: 0x001EA455
		public unsafe float TrailerYawRateRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTrailerConnector.__PropertyOffset_TrailerYawRateRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTrailerConnector.__PropertyOffset_TrailerYawRateRatio) = value;
			}
		}

		// Token: 0x170052EA RID: 21226
		// (get) Token: 0x06014ECD RID: 85709 RVA: 0x001EC266 File Offset: 0x001EA466
		// (set) Token: 0x06014ECE RID: 85710 RVA: 0x001EC276 File Offset: 0x001EA476
		public unsafe float YawArmFallback
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTrailerConnector.__PropertyOffset_YawArmFallback);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTrailerConnector.__PropertyOffset_YawArmFallback) = value;
			}
		}

		// Token: 0x06014ECF RID: 85711 RVA: 0x001EC287 File Offset: 0x001EA487
		public FTrailerConnector()
		{
		}

		// Token: 0x06014ED0 RID: 85712 RVA: 0x001EC290 File Offset: 0x001EA490
		public FTrailerConnector(FBoneReference Bone, FVehicleAxisData Axis, bool bEnableYaw, bool bEnablePitch, float YawLimitDeg, float PitchLimitDeg, float TrailerYawMaxRateDegPerSec, float TrailerYawRateRatio, float YawArmFallback)
		{
			this.Bone = Bone;
			this.Axis = Axis;
			this.bEnableYaw = bEnableYaw;
			this.bEnablePitch = bEnablePitch;
			this.YawLimitDeg = YawLimitDeg;
			this.PitchLimitDeg = PitchLimitDeg;
			this.TrailerYawMaxRateDegPerSec = TrailerYawMaxRateDegPerSec;
			this.TrailerYawRateRatio = TrailerYawRateRatio;
			this.YawArmFallback = YawArmFallback;
		}

		// Token: 0x06014ED1 RID: 85713 RVA: 0x001EC2E8 File Offset: 0x001EA4E8
		protected override IntPtr GetUStructPtr()
		{
			return FTrailerConnector.StaticStruct();
		}

		// Token: 0x06014ED2 RID: 85714 RVA: 0x001EC2F4 File Offset: 0x001EA4F4
		[NullableContext(2)]
		public FTrailerConnector(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014ED3 RID: 85715 RVA: 0x001EC2FE File Offset: 0x001EA4FE
		public FTrailerConnector(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014ED4 RID: 85716 RVA: 0x001EC309 File Offset: 0x001EA509
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTrailerConnector(Pointer, false, true);
		}

		// Token: 0x06014ED5 RID: 85717 RVA: 0x001EC313 File Offset: 0x001EA513
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTrailerConnector(Pointer, MemoryOwner);
		}

		// Token: 0x0400B65C RID: 46684
		public const string __ObjectPath = "/Script/KuroAnim.TrailerConnector";

		// Token: 0x0400B65D RID: 46685
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B65E RID: 46686
		internal static int __PropertyOffset_Bone;

		// Token: 0x0400B65F RID: 46687
		[Nullable(2)]
		private FBoneReference _Bone;

		// Token: 0x0400B660 RID: 46688
		internal static int __PropertyOffset_Axis;

		// Token: 0x0400B661 RID: 46689
		[Nullable(2)]
		private FVehicleAxisData _Axis;

		// Token: 0x0400B662 RID: 46690
		internal static int __PropertyOffset_bEnableYaw;

		// Token: 0x0400B663 RID: 46691
		internal static int __PropertyOffset_bEnablePitch;

		// Token: 0x0400B664 RID: 46692
		internal static int __PropertyOffset_YawLimitDeg;

		// Token: 0x0400B665 RID: 46693
		internal static int __PropertyOffset_PitchLimitDeg;

		// Token: 0x0400B666 RID: 46694
		internal static int __PropertyOffset_TrailerYawMaxRateDegPerSec;

		// Token: 0x0400B667 RID: 46695
		internal static int __PropertyOffset_TrailerYawRateRatio;

		// Token: 0x0400B668 RID: 46696
		internal static int __PropertyOffset_YawArmFallback;
	}
}
