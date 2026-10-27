using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001678 RID: 5752
	[UnrealObjectPath("/Script/KuroAnim.MotorWheelDisplayInfo")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FMotorWheelDisplayInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014DDD RID: 85469 RVA: 0x001EADC8 File Offset: 0x001E8FC8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMotorWheelDisplayInfo._ScriptStructPtr != 0) ? FMotorWheelDisplayInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.MotorWheelDisplayInfo", ref FMotorWheelDisplayInfo._ScriptStructPtr);
		}

		// Token: 0x170052A5 RID: 21157
		// (get) Token: 0x06014DDE RID: 85470 RVA: 0x001EADEC File Offset: 0x001E8FEC
		// (set) Token: 0x06014DDF RID: 85471 RVA: 0x001EAE00 File Offset: 0x001E9000
		public unsafe FVector WheelLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorWheelDisplayInfo.__PropertyOffset_WheelLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorWheelDisplayInfo.__PropertyOffset_WheelLocation) = value;
			}
		}

		// Token: 0x170052A6 RID: 21158
		// (get) Token: 0x06014DE0 RID: 85472 RVA: 0x001EAE15 File Offset: 0x001E9015
		// (set) Token: 0x06014DE1 RID: 85473 RVA: 0x001EAE25 File Offset: 0x001E9025
		public unsafe float WheelSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorWheelDisplayInfo.__PropertyOffset_WheelSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorWheelDisplayInfo.__PropertyOffset_WheelSpeed) = value;
			}
		}

		// Token: 0x170052A7 RID: 21159
		// (get) Token: 0x06014DE2 RID: 85474 RVA: 0x001EAE36 File Offset: 0x001E9036
		// (set) Token: 0x06014DE3 RID: 85475 RVA: 0x001EAE46 File Offset: 0x001E9046
		public unsafe float WheelAccel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorWheelDisplayInfo.__PropertyOffset_WheelAccel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorWheelDisplayInfo.__PropertyOffset_WheelAccel) = value;
			}
		}

		// Token: 0x06014DE4 RID: 85476 RVA: 0x001EAE57 File Offset: 0x001E9057
		public FMotorWheelDisplayInfo()
		{
		}

		// Token: 0x06014DE5 RID: 85477 RVA: 0x001EAE5F File Offset: 0x001E905F
		public FMotorWheelDisplayInfo(FVector WheelLocation, float WheelSpeed, float WheelAccel)
		{
			this.WheelLocation = WheelLocation;
			this.WheelSpeed = WheelSpeed;
			this.WheelAccel = WheelAccel;
		}

		// Token: 0x06014DE6 RID: 85478 RVA: 0x001EAE7C File Offset: 0x001E907C
		protected override IntPtr GetUStructPtr()
		{
			return FMotorWheelDisplayInfo.StaticStruct();
		}

		// Token: 0x06014DE7 RID: 85479 RVA: 0x001EAE88 File Offset: 0x001E9088
		[NullableContext(2)]
		public FMotorWheelDisplayInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014DE8 RID: 85480 RVA: 0x001EAE92 File Offset: 0x001E9092
		public FMotorWheelDisplayInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014DE9 RID: 85481 RVA: 0x001EAE9D File Offset: 0x001E909D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMotorWheelDisplayInfo(Pointer, false, true);
		}

		// Token: 0x06014DEA RID: 85482 RVA: 0x001EAEA7 File Offset: 0x001E90A7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMotorWheelDisplayInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400B5EF RID: 46575
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroAnim.MotorWheelDisplayInfo";

		// Token: 0x0400B5F0 RID: 46576
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B5F1 RID: 46577
		internal static int __PropertyOffset_WheelLocation;

		// Token: 0x0400B5F2 RID: 46578
		internal static int __PropertyOffset_WheelSpeed;

		// Token: 0x0400B5F3 RID: 46579
		internal static int __PropertyOffset_WheelAccel;
	}
}
