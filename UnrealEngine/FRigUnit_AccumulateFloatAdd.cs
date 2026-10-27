using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000530 RID: 1328
	[UnrealObjectPath("/Script/ControlRig.RigUnit_AccumulateFloatAdd")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FRigUnit_AccumulateFloatAdd : FRigUnit_SimBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004590 RID: 17808 RVA: 0x0006782F File Offset: 0x00065A2F
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_AccumulateFloatAdd._ScriptStructPtr != 0) ? FRigUnit_AccumulateFloatAdd._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_AccumulateFloatAdd", ref FRigUnit_AccumulateFloatAdd._ScriptStructPtr);
		}

		// Token: 0x170010DC RID: 4316
		// (get) Token: 0x06004591 RID: 17809 RVA: 0x00067853 File Offset: 0x00065A53
		// (set) Token: 0x06004592 RID: 17810 RVA: 0x00067863 File Offset: 0x00065A63
		public unsafe float Increment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateFloatAdd.__PropertyOffset_Increment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateFloatAdd.__PropertyOffset_Increment) = value;
			}
		}

		// Token: 0x170010DD RID: 4317
		// (get) Token: 0x06004593 RID: 17811 RVA: 0x00067874 File Offset: 0x00065A74
		// (set) Token: 0x06004594 RID: 17812 RVA: 0x00067884 File Offset: 0x00065A84
		public unsafe float InitialValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateFloatAdd.__PropertyOffset_InitialValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateFloatAdd.__PropertyOffset_InitialValue) = value;
			}
		}

		// Token: 0x170010DE RID: 4318
		// (get) Token: 0x06004595 RID: 17813 RVA: 0x00067895 File Offset: 0x00065A95
		// (set) Token: 0x06004596 RID: 17814 RVA: 0x000678A5 File Offset: 0x00065AA5
		public unsafe bool bIntegrateDeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateFloatAdd.__PropertyOffset_bIntegrateDeltaTime) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateFloatAdd.__PropertyOffset_bIntegrateDeltaTime) = (value ? 1 : 0);
			}
		}

		// Token: 0x170010DF RID: 4319
		// (get) Token: 0x06004597 RID: 17815 RVA: 0x000678B6 File Offset: 0x00065AB6
		// (set) Token: 0x06004598 RID: 17816 RVA: 0x000678C6 File Offset: 0x00065AC6
		public unsafe float Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateFloatAdd.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateFloatAdd.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x170010E0 RID: 4320
		// (get) Token: 0x06004599 RID: 17817 RVA: 0x000678D7 File Offset: 0x00065AD7
		// (set) Token: 0x0600459A RID: 17818 RVA: 0x000678E7 File Offset: 0x00065AE7
		public unsafe float AccumulatedValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateFloatAdd.__PropertyOffset_AccumulatedValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateFloatAdd.__PropertyOffset_AccumulatedValue) = value;
			}
		}

		// Token: 0x0600459B RID: 17819 RVA: 0x000678F8 File Offset: 0x00065AF8
		public FRigUnit_AccumulateFloatAdd()
		{
		}

		// Token: 0x0600459C RID: 17820 RVA: 0x00067900 File Offset: 0x00065B00
		public FRigUnit_AccumulateFloatAdd(float Increment, float InitialValue, bool bIntegrateDeltaTime, float Result, float AccumulatedValue)
		{
			this.Increment = Increment;
			this.InitialValue = InitialValue;
			this.bIntegrateDeltaTime = bIntegrateDeltaTime;
			this.Result = Result;
			this.AccumulatedValue = AccumulatedValue;
		}

		// Token: 0x0600459D RID: 17821 RVA: 0x0006792D File Offset: 0x00065B2D
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_AccumulateFloatAdd.StaticStruct();
		}

		// Token: 0x0600459E RID: 17822 RVA: 0x00067939 File Offset: 0x00065B39
		[NullableContext(2)]
		public FRigUnit_AccumulateFloatAdd(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600459F RID: 17823 RVA: 0x00067943 File Offset: 0x00065B43
		public FRigUnit_AccumulateFloatAdd(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060045A0 RID: 17824 RVA: 0x0006794E File Offset: 0x00065B4E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_AccumulateFloatAdd(Pointer, false, true);
		}

		// Token: 0x060045A1 RID: 17825 RVA: 0x00067958 File Offset: 0x00065B58
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_AccumulateFloatAdd(Pointer, MemoryOwner);
		}

		// Token: 0x040021DD RID: 8669
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_AccumulateFloatAdd";

		// Token: 0x040021DE RID: 8670
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040021DF RID: 8671
		internal static int __PropertyOffset_Increment;

		// Token: 0x040021E0 RID: 8672
		internal static int __PropertyOffset_InitialValue;

		// Token: 0x040021E1 RID: 8673
		internal static int __PropertyOffset_bIntegrateDeltaTime;

		// Token: 0x040021E2 RID: 8674
		internal static int __PropertyOffset_Result;

		// Token: 0x040021E3 RID: 8675
		internal static int __PropertyOffset_AccumulatedValue;
	}
}
