using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000538 RID: 1336
	[UnrealObjectPath("/Script/ControlRig.RigUnit_AccumulateVectorAdd")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FRigUnit_AccumulateVectorAdd : FRigUnit_SimBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600462A RID: 17962 RVA: 0x0006830C File Offset: 0x0006650C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_AccumulateVectorAdd._ScriptStructPtr != 0) ? FRigUnit_AccumulateVectorAdd._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_AccumulateVectorAdd", ref FRigUnit_AccumulateVectorAdd._ScriptStructPtr);
		}

		// Token: 0x17001109 RID: 4361
		// (get) Token: 0x0600462B RID: 17963 RVA: 0x00068330 File Offset: 0x00066530
		// (set) Token: 0x0600462C RID: 17964 RVA: 0x00068344 File Offset: 0x00066544
		public unsafe FVector Increment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateVectorAdd.__PropertyOffset_Increment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateVectorAdd.__PropertyOffset_Increment) = value;
			}
		}

		// Token: 0x1700110A RID: 4362
		// (get) Token: 0x0600462D RID: 17965 RVA: 0x00068359 File Offset: 0x00066559
		// (set) Token: 0x0600462E RID: 17966 RVA: 0x0006836D File Offset: 0x0006656D
		public unsafe FVector InitialValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateVectorAdd.__PropertyOffset_InitialValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateVectorAdd.__PropertyOffset_InitialValue) = value;
			}
		}

		// Token: 0x1700110B RID: 4363
		// (get) Token: 0x0600462F RID: 17967 RVA: 0x00068382 File Offset: 0x00066582
		// (set) Token: 0x06004630 RID: 17968 RVA: 0x00068392 File Offset: 0x00066592
		public unsafe bool bIntegrateDeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateVectorAdd.__PropertyOffset_bIntegrateDeltaTime) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateVectorAdd.__PropertyOffset_bIntegrateDeltaTime) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700110C RID: 4364
		// (get) Token: 0x06004631 RID: 17969 RVA: 0x000683A3 File Offset: 0x000665A3
		// (set) Token: 0x06004632 RID: 17970 RVA: 0x000683B7 File Offset: 0x000665B7
		public unsafe FVector Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateVectorAdd.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateVectorAdd.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x1700110D RID: 4365
		// (get) Token: 0x06004633 RID: 17971 RVA: 0x000683CC File Offset: 0x000665CC
		// (set) Token: 0x06004634 RID: 17972 RVA: 0x000683E0 File Offset: 0x000665E0
		public unsafe FVector AccumulatedValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateVectorAdd.__PropertyOffset_AccumulatedValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateVectorAdd.__PropertyOffset_AccumulatedValue) = value;
			}
		}

		// Token: 0x06004635 RID: 17973 RVA: 0x000683F5 File Offset: 0x000665F5
		public FRigUnit_AccumulateVectorAdd()
		{
		}

		// Token: 0x06004636 RID: 17974 RVA: 0x000683FD File Offset: 0x000665FD
		public FRigUnit_AccumulateVectorAdd(FVector Increment, FVector InitialValue, bool bIntegrateDeltaTime, FVector Result, FVector AccumulatedValue)
		{
			this.Increment = Increment;
			this.InitialValue = InitialValue;
			this.bIntegrateDeltaTime = bIntegrateDeltaTime;
			this.Result = Result;
			this.AccumulatedValue = AccumulatedValue;
		}

		// Token: 0x06004637 RID: 17975 RVA: 0x0006842A File Offset: 0x0006662A
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_AccumulateVectorAdd.StaticStruct();
		}

		// Token: 0x06004638 RID: 17976 RVA: 0x00068436 File Offset: 0x00066636
		[NullableContext(2)]
		public FRigUnit_AccumulateVectorAdd(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004639 RID: 17977 RVA: 0x00068440 File Offset: 0x00066640
		public FRigUnit_AccumulateVectorAdd(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600463A RID: 17978 RVA: 0x0006844B File Offset: 0x0006664B
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_AccumulateVectorAdd(Pointer, false, true);
		}

		// Token: 0x0600463B RID: 17979 RVA: 0x00068455 File Offset: 0x00066655
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_AccumulateVectorAdd(Pointer, MemoryOwner);
		}

		// Token: 0x0400221A RID: 8730
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_AccumulateVectorAdd";

		// Token: 0x0400221B RID: 8731
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400221C RID: 8732
		internal static int __PropertyOffset_Increment;

		// Token: 0x0400221D RID: 8733
		internal static int __PropertyOffset_InitialValue;

		// Token: 0x0400221E RID: 8734
		internal static int __PropertyOffset_bIntegrateDeltaTime;

		// Token: 0x0400221F RID: 8735
		internal static int __PropertyOffset_Result;

		// Token: 0x04002220 RID: 8736
		internal static int __PropertyOffset_AccumulatedValue;
	}
}
