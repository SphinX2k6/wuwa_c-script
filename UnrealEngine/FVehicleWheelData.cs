using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001689 RID: 5769
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.VehicleWheelData")]
	[UnrealStructLayout(416, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 416)]
	public class FVehicleWheelData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014EF3 RID: 85747 RVA: 0x001EC5D1 File Offset: 0x001EA7D1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVehicleWheelData._ScriptStructPtr != 0) ? FVehicleWheelData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.VehicleWheelData", ref FVehicleWheelData._ScriptStructPtr);
		}

		// Token: 0x170052F1 RID: 21233
		// (get) Token: 0x06014EF4 RID: 85748 RVA: 0x001EC5F8 File Offset: 0x001EA7F8
		// (set) Token: 0x06014EF5 RID: 85749 RVA: 0x001EC63B File Offset: 0x001EA83B
		public FBoneReference Bone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._Bone) == null)
				{
					result = (this._Bone = new FBoneReference(base.NativePtr + (IntPtr)FVehicleWheelData.__PropertyOffset_Bone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FVehicleWheelData.__PropertyOffset_Bone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170052F2 RID: 21234
		// (get) Token: 0x06014EF6 RID: 85750 RVA: 0x001EC65C File Offset: 0x001EA85C
		// (set) Token: 0x06014EF7 RID: 85751 RVA: 0x001EC69F File Offset: 0x001EA89F
		public FVehicleAxisData WheelAxis
		{
			get
			{
				base.FastCheckIsValid();
				FVehicleAxisData result;
				if ((result = this._WheelAxis) == null)
				{
					result = (this._WheelAxis = new FVehicleAxisData(base.NativePtr + (IntPtr)FVehicleWheelData.__PropertyOffset_WheelAxis, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FVehicleAxisData.StaticStruct(), base.NativePtr + (IntPtr)FVehicleWheelData.__PropertyOffset_WheelAxis, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170052F3 RID: 21235
		// (get) Token: 0x06014EF8 RID: 85752 RVA: 0x001EC6C0 File Offset: 0x001EA8C0
		// (set) Token: 0x06014EF9 RID: 85753 RVA: 0x001EC6D0 File Offset: 0x001EA8D0
		public unsafe bool bWheelSteer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVehicleWheelData.__PropertyOffset_bWheelSteer) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVehicleWheelData.__PropertyOffset_bWheelSteer) = (value ? 1 : 0);
			}
		}

		// Token: 0x170052F4 RID: 21236
		// (get) Token: 0x06014EFA RID: 85754 RVA: 0x001EC6E1 File Offset: 0x001EA8E1
		// (set) Token: 0x06014EFB RID: 85755 RVA: 0x001EC6F1 File Offset: 0x001EA8F1
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVehicleWheelData.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVehicleWheelData.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x170052F5 RID: 21237
		// (get) Token: 0x06014EFC RID: 85756 RVA: 0x001EC702 File Offset: 0x001EA902
		// (set) Token: 0x06014EFD RID: 85757 RVA: 0x001EC712 File Offset: 0x001EA912
		public unsafe float MaxSpinDegPerTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVehicleWheelData.__PropertyOffset_MaxSpinDegPerTick);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVehicleWheelData.__PropertyOffset_MaxSpinDegPerTick) = value;
			}
		}

		// Token: 0x170052F6 RID: 21238
		// (get) Token: 0x06014EFE RID: 85758 RVA: 0x001EC723 File Offset: 0x001EA923
		// (set) Token: 0x06014EFF RID: 85759 RVA: 0x001EC733 File Offset: 0x001EA933
		public unsafe float MaxOffsetFromDefault
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVehicleWheelData.__PropertyOffset_MaxOffsetFromDefault);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVehicleWheelData.__PropertyOffset_MaxOffsetFromDefault) = value;
			}
		}

		// Token: 0x170052F7 RID: 21239
		// (get) Token: 0x06014F00 RID: 85760 RVA: 0x001EC744 File Offset: 0x001EA944
		// (set) Token: 0x06014F01 RID: 85761 RVA: 0x001EC787 File Offset: 0x001EA987
		public FBoneReference StrutBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._StrutBone) == null)
				{
					result = (this._StrutBone = new FBoneReference(base.NativePtr + (IntPtr)FVehicleWheelData.__PropertyOffset_StrutBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FVehicleWheelData.__PropertyOffset_StrutBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170052F8 RID: 21240
		// (get) Token: 0x06014F02 RID: 85762 RVA: 0x001EC7A8 File Offset: 0x001EA9A8
		// (set) Token: 0x06014F03 RID: 85763 RVA: 0x001EC7BC File Offset: 0x001EA9BC
		public unsafe FVector StrutRotateAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVehicleWheelData.__PropertyOffset_StrutRotateAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVehicleWheelData.__PropertyOffset_StrutRotateAxis) = value;
			}
		}

		// Token: 0x170052F9 RID: 21241
		// (get) Token: 0x06014F04 RID: 85764 RVA: 0x001EC7D1 File Offset: 0x001EA9D1
		// (set) Token: 0x06014F05 RID: 85765 RVA: 0x001EC7E1 File Offset: 0x001EA9E1
		public unsafe bool bStrutRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVehicleWheelData.__PropertyOffset_bStrutRotation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVehicleWheelData.__PropertyOffset_bStrutRotation) = (value ? 1 : 0);
			}
		}

		// Token: 0x170052FA RID: 21242
		// (get) Token: 0x06014F06 RID: 85766 RVA: 0x001EC7F2 File Offset: 0x001EA9F2
		// (set) Token: 0x06014F07 RID: 85767 RVA: 0x001EC802 File Offset: 0x001EAA02
		public unsafe bool bSuspension
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVehicleWheelData.__PropertyOffset_bSuspension) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVehicleWheelData.__PropertyOffset_bSuspension) = (value ? 1 : 0);
			}
		}

		// Token: 0x170052FB RID: 21243
		// (get) Token: 0x06014F08 RID: 85768 RVA: 0x001EC813 File Offset: 0x001EAA13
		// (set) Token: 0x06014F09 RID: 85769 RVA: 0x001EC823 File Offset: 0x001EAA23
		public unsafe float SuspensionMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVehicleWheelData.__PropertyOffset_SuspensionMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVehicleWheelData.__PropertyOffset_SuspensionMax) = value;
			}
		}

		// Token: 0x170052FC RID: 21244
		// (get) Token: 0x06014F0A RID: 85770 RVA: 0x001EC834 File Offset: 0x001EAA34
		// (set) Token: 0x06014F0B RID: 85771 RVA: 0x001EC844 File Offset: 0x001EAA44
		public unsafe float SuspensionMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVehicleWheelData.__PropertyOffset_SuspensionMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVehicleWheelData.__PropertyOffset_SuspensionMin) = value;
			}
		}

		// Token: 0x170052FD RID: 21245
		// (get) Token: 0x06014F0C RID: 85772 RVA: 0x001EC855 File Offset: 0x001EAA55
		// (set) Token: 0x06014F0D RID: 85773 RVA: 0x001EC865 File Offset: 0x001EAA65
		public unsafe float SuspensionStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVehicleWheelData.__PropertyOffset_SuspensionStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVehicleWheelData.__PropertyOffset_SuspensionStiffness) = value;
			}
		}

		// Token: 0x170052FE RID: 21246
		// (get) Token: 0x06014F0E RID: 85774 RVA: 0x001EC876 File Offset: 0x001EAA76
		// (set) Token: 0x06014F0F RID: 85775 RVA: 0x001EC886 File Offset: 0x001EAA86
		public unsafe float NoContactDropSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVehicleWheelData.__PropertyOffset_NoContactDropSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVehicleWheelData.__PropertyOffset_NoContactDropSpeed) = value;
			}
		}

		// Token: 0x170052FF RID: 21247
		// (get) Token: 0x06014F10 RID: 85776 RVA: 0x001EC897 File Offset: 0x001EAA97
		// (set) Token: 0x06014F11 RID: 85777 RVA: 0x001EC8A7 File Offset: 0x001EAAA7
		public unsafe float MaxSteerDeg
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVehicleWheelData.__PropertyOffset_MaxSteerDeg);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVehicleWheelData.__PropertyOffset_MaxSteerDeg) = value;
			}
		}

		// Token: 0x17005300 RID: 21248
		// (get) Token: 0x06014F12 RID: 85778 RVA: 0x001EC8B8 File Offset: 0x001EAAB8
		// (set) Token: 0x06014F13 RID: 85779 RVA: 0x001EC8C8 File Offset: 0x001EAAC8
		public unsafe float SteerInterpSpeedDegPerSec
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVehicleWheelData.__PropertyOffset_SteerInterpSpeedDegPerSec);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVehicleWheelData.__PropertyOffset_SteerInterpSpeedDegPerSec) = value;
			}
		}

		// Token: 0x06014F14 RID: 85780 RVA: 0x001EC8D9 File Offset: 0x001EAAD9
		public FVehicleWheelData()
		{
		}

		// Token: 0x06014F15 RID: 85781 RVA: 0x001EC8E4 File Offset: 0x001EAAE4
		public FVehicleWheelData(FBoneReference Bone, FVehicleAxisData WheelAxis, bool bWheelSteer, float Radius, float MaxSpinDegPerTick, float MaxOffsetFromDefault, FBoneReference StrutBone, FVector StrutRotateAxis, bool bStrutRotation, bool bSuspension, float SuspensionMax, float SuspensionMin, float SuspensionStiffness, float NoContactDropSpeed, float MaxSteerDeg, float SteerInterpSpeedDegPerSec)
		{
			this.Bone = Bone;
			this.WheelAxis = WheelAxis;
			this.bWheelSteer = bWheelSteer;
			this.Radius = Radius;
			this.MaxSpinDegPerTick = MaxSpinDegPerTick;
			this.MaxOffsetFromDefault = MaxOffsetFromDefault;
			this.StrutBone = StrutBone;
			this.StrutRotateAxis = StrutRotateAxis;
			this.bStrutRotation = bStrutRotation;
			this.bSuspension = bSuspension;
			this.SuspensionMax = SuspensionMax;
			this.SuspensionMin = SuspensionMin;
			this.SuspensionStiffness = SuspensionStiffness;
			this.NoContactDropSpeed = NoContactDropSpeed;
			this.MaxSteerDeg = MaxSteerDeg;
			this.SteerInterpSpeedDegPerSec = SteerInterpSpeedDegPerSec;
		}

		// Token: 0x06014F16 RID: 85782 RVA: 0x001EC974 File Offset: 0x001EAB74
		protected override IntPtr GetUStructPtr()
		{
			return FVehicleWheelData.StaticStruct();
		}

		// Token: 0x06014F17 RID: 85783 RVA: 0x001EC980 File Offset: 0x001EAB80
		[NullableContext(2)]
		public FVehicleWheelData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014F18 RID: 85784 RVA: 0x001EC98A File Offset: 0x001EAB8A
		public FVehicleWheelData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014F19 RID: 85785 RVA: 0x001EC995 File Offset: 0x001EAB95
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FVehicleWheelData(Pointer, false, true);
		}

		// Token: 0x06014F1A RID: 85786 RVA: 0x001EC99F File Offset: 0x001EAB9F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FVehicleWheelData(Pointer, MemoryOwner);
		}

		// Token: 0x0400B674 RID: 46708
		public const string __ObjectPath = "/Script/KuroAnim.VehicleWheelData";

		// Token: 0x0400B675 RID: 46709
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B676 RID: 46710
		internal static int __PropertyOffset_Bone;

		// Token: 0x0400B677 RID: 46711
		[Nullable(2)]
		private FBoneReference _Bone;

		// Token: 0x0400B678 RID: 46712
		internal static int __PropertyOffset_WheelAxis;

		// Token: 0x0400B679 RID: 46713
		[Nullable(2)]
		private FVehicleAxisData _WheelAxis;

		// Token: 0x0400B67A RID: 46714
		internal static int __PropertyOffset_bWheelSteer;

		// Token: 0x0400B67B RID: 46715
		internal static int __PropertyOffset_Radius;

		// Token: 0x0400B67C RID: 46716
		internal static int __PropertyOffset_MaxSpinDegPerTick;

		// Token: 0x0400B67D RID: 46717
		internal static int __PropertyOffset_MaxOffsetFromDefault;

		// Token: 0x0400B67E RID: 46718
		internal static int __PropertyOffset_StrutBone;

		// Token: 0x0400B67F RID: 46719
		[Nullable(2)]
		private FBoneReference _StrutBone;

		// Token: 0x0400B680 RID: 46720
		internal static int __PropertyOffset_StrutRotateAxis;

		// Token: 0x0400B681 RID: 46721
		internal static int __PropertyOffset_bStrutRotation;

		// Token: 0x0400B682 RID: 46722
		internal static int __PropertyOffset_bSuspension;

		// Token: 0x0400B683 RID: 46723
		internal static int __PropertyOffset_SuspensionMax;

		// Token: 0x0400B684 RID: 46724
		internal static int __PropertyOffset_SuspensionMin;

		// Token: 0x0400B685 RID: 46725
		internal static int __PropertyOffset_SuspensionStiffness;

		// Token: 0x0400B686 RID: 46726
		internal static int __PropertyOffset_NoContactDropSpeed;

		// Token: 0x0400B687 RID: 46727
		internal static int __PropertyOffset_MaxSteerDeg;

		// Token: 0x0400B688 RID: 46728
		internal static int __PropertyOffset_SteerInterpSpeedDegPerSec;
	}
}
