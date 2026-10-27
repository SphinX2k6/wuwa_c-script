using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001688 RID: 5768
	[UnrealObjectPath("/Script/KuroAnim.VehicleAxisData")]
	[UnrealStructLayout(6, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 6)]
	public class FVehicleAxisData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014EDF RID: 85727 RVA: 0x001EC45E File Offset: 0x001EA65E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVehicleAxisData._ScriptStructPtr != 0) ? FVehicleAxisData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.VehicleAxisData", ref FVehicleAxisData._ScriptStructPtr);
		}

		// Token: 0x170052EB RID: 21227
		// (get) Token: 0x06014EE0 RID: 85728 RVA: 0x001EC482 File Offset: 0x001EA682
		// (set) Token: 0x06014EE1 RID: 85729 RVA: 0x001EC496 File Offset: 0x001EA696
		public unsafe TEnumAsByte<EAxis> ForwardAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVehicleAxisData.__PropertyOffset_ForwardAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVehicleAxisData.__PropertyOffset_ForwardAxis) = value;
			}
		}

		// Token: 0x170052EC RID: 21228
		// (get) Token: 0x06014EE2 RID: 85730 RVA: 0x001EC4AB File Offset: 0x001EA6AB
		// (set) Token: 0x06014EE3 RID: 85731 RVA: 0x001EC4BB File Offset: 0x001EA6BB
		public unsafe bool bForwardAxisReverse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVehicleAxisData.__PropertyOffset_bForwardAxisReverse) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVehicleAxisData.__PropertyOffset_bForwardAxisReverse) = (value ? 1 : 0);
			}
		}

		// Token: 0x170052ED RID: 21229
		// (get) Token: 0x06014EE4 RID: 85732 RVA: 0x001EC4CC File Offset: 0x001EA6CC
		// (set) Token: 0x06014EE5 RID: 85733 RVA: 0x001EC4E0 File Offset: 0x001EA6E0
		public unsafe TEnumAsByte<EAxis> RightAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVehicleAxisData.__PropertyOffset_RightAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVehicleAxisData.__PropertyOffset_RightAxis) = value;
			}
		}

		// Token: 0x170052EE RID: 21230
		// (get) Token: 0x06014EE6 RID: 85734 RVA: 0x001EC4F5 File Offset: 0x001EA6F5
		// (set) Token: 0x06014EE7 RID: 85735 RVA: 0x001EC505 File Offset: 0x001EA705
		public unsafe bool bRightAxisReverse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVehicleAxisData.__PropertyOffset_bRightAxisReverse) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVehicleAxisData.__PropertyOffset_bRightAxisReverse) = (value ? 1 : 0);
			}
		}

		// Token: 0x170052EF RID: 21231
		// (get) Token: 0x06014EE8 RID: 85736 RVA: 0x001EC516 File Offset: 0x001EA716
		// (set) Token: 0x06014EE9 RID: 85737 RVA: 0x001EC52A File Offset: 0x001EA72A
		public unsafe TEnumAsByte<EAxis> UpAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVehicleAxisData.__PropertyOffset_UpAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVehicleAxisData.__PropertyOffset_UpAxis) = value;
			}
		}

		// Token: 0x170052F0 RID: 21232
		// (get) Token: 0x06014EEA RID: 85738 RVA: 0x001EC53F File Offset: 0x001EA73F
		// (set) Token: 0x06014EEB RID: 85739 RVA: 0x001EC54F File Offset: 0x001EA74F
		public unsafe bool bUpAxisReverse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVehicleAxisData.__PropertyOffset_bUpAxisReverse) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVehicleAxisData.__PropertyOffset_bUpAxisReverse) = (value ? 1 : 0);
			}
		}

		// Token: 0x06014EEC RID: 85740 RVA: 0x001EC560 File Offset: 0x001EA760
		public FVehicleAxisData()
		{
		}

		// Token: 0x06014EED RID: 85741 RVA: 0x001EC568 File Offset: 0x001EA768
		public FVehicleAxisData(TEnumAsByte<EAxis> ForwardAxis, bool bForwardAxisReverse, TEnumAsByte<EAxis> RightAxis, bool bRightAxisReverse, TEnumAsByte<EAxis> UpAxis, bool bUpAxisReverse)
		{
			this.ForwardAxis = ForwardAxis;
			this.bForwardAxisReverse = bForwardAxisReverse;
			this.RightAxis = RightAxis;
			this.bRightAxisReverse = bRightAxisReverse;
			this.UpAxis = UpAxis;
			this.bUpAxisReverse = bUpAxisReverse;
		}

		// Token: 0x06014EEE RID: 85742 RVA: 0x001EC59D File Offset: 0x001EA79D
		protected override IntPtr GetUStructPtr()
		{
			return FVehicleAxisData.StaticStruct();
		}

		// Token: 0x06014EEF RID: 85743 RVA: 0x001EC5A9 File Offset: 0x001EA7A9
		[NullableContext(2)]
		public FVehicleAxisData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014EF0 RID: 85744 RVA: 0x001EC5B3 File Offset: 0x001EA7B3
		public FVehicleAxisData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014EF1 RID: 85745 RVA: 0x001EC5BE File Offset: 0x001EA7BE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FVehicleAxisData(Pointer, false, true);
		}

		// Token: 0x06014EF2 RID: 85746 RVA: 0x001EC5C8 File Offset: 0x001EA7C8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FVehicleAxisData(Pointer, MemoryOwner);
		}

		// Token: 0x0400B66C RID: 46700
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroAnim.VehicleAxisData";

		// Token: 0x0400B66D RID: 46701
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B66E RID: 46702
		internal static int __PropertyOffset_ForwardAxis;

		// Token: 0x0400B66F RID: 46703
		internal static int __PropertyOffset_bForwardAxisReverse;

		// Token: 0x0400B670 RID: 46704
		internal static int __PropertyOffset_RightAxis;

		// Token: 0x0400B671 RID: 46705
		internal static int __PropertyOffset_bRightAxisReverse;

		// Token: 0x0400B672 RID: 46706
		internal static int __PropertyOffset_UpAxis;

		// Token: 0x0400B673 RID: 46707
		internal static int __PropertyOffset_bUpAxisReverse;
	}
}
