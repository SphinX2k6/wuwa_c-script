using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000641 RID: 1601
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathQuaternionToEuler")]
	[UnrealStructLayout(48, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_MathQuaternionToEuler : FRigUnit_MathQuaternionBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005574 RID: 21876 RVA: 0x0007BE4A File Offset: 0x0007A04A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathQuaternionToEuler._ScriptStructPtr != 0) ? FRigUnit_MathQuaternionToEuler._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathQuaternionToEuler", ref FRigUnit_MathQuaternionToEuler._ScriptStructPtr);
		}

		// Token: 0x17001490 RID: 5264
		// (get) Token: 0x06005575 RID: 21877 RVA: 0x0007BE6E File Offset: 0x0007A06E
		// (set) Token: 0x06005576 RID: 21878 RVA: 0x0007BE82 File Offset: 0x0007A082
		public unsafe FQuat Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionToEuler.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionToEuler.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17001491 RID: 5265
		// (get) Token: 0x06005577 RID: 21879 RVA: 0x0007BE97 File Offset: 0x0007A097
		// (set) Token: 0x06005578 RID: 21880 RVA: 0x0007BEA7 File Offset: 0x0007A0A7
		public unsafe EControlRigRotationOrder RotationOrder
		{
			get
			{
				return (EControlRigRotationOrder)(*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionToEuler.__PropertyOffset_RotationOrder));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionToEuler.__PropertyOffset_RotationOrder) = (byte)value;
			}
		}

		// Token: 0x17001492 RID: 5266
		// (get) Token: 0x06005579 RID: 21881 RVA: 0x0007BEB8 File Offset: 0x0007A0B8
		// (set) Token: 0x0600557A RID: 21882 RVA: 0x0007BECC File Offset: 0x0007A0CC
		public unsafe FVector Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionToEuler.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionToEuler.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x0600557B RID: 21883 RVA: 0x0007BEE1 File Offset: 0x0007A0E1
		public FRigUnit_MathQuaternionToEuler()
		{
		}

		// Token: 0x0600557C RID: 21884 RVA: 0x0007BEE9 File Offset: 0x0007A0E9
		public FRigUnit_MathQuaternionToEuler(FQuat Value, EControlRigRotationOrder RotationOrder, FVector Result)
		{
			this.Value = Value;
			this.RotationOrder = RotationOrder;
			this.Result = Result;
		}

		// Token: 0x0600557D RID: 21885 RVA: 0x0007BF06 File Offset: 0x0007A106
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathQuaternionToEuler.StaticStruct();
		}

		// Token: 0x0600557E RID: 21886 RVA: 0x0007BF12 File Offset: 0x0007A112
		[NullableContext(2)]
		public FRigUnit_MathQuaternionToEuler(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600557F RID: 21887 RVA: 0x0007BF1C File Offset: 0x0007A11C
		public FRigUnit_MathQuaternionToEuler(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005580 RID: 21888 RVA: 0x0007BF27 File Offset: 0x0007A127
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathQuaternionToEuler(Pointer, false, true);
		}

		// Token: 0x06005581 RID: 21889 RVA: 0x0007BF31 File Offset: 0x0007A131
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathQuaternionToEuler(Pointer, MemoryOwner);
		}

		// Token: 0x0400287A RID: 10362
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathQuaternionToEuler";

		// Token: 0x0400287B RID: 10363
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400287C RID: 10364
		internal static int __PropertyOffset_Value;

		// Token: 0x0400287D RID: 10365
		internal static int __PropertyOffset_RotationOrder;

		// Token: 0x0400287E RID: 10366
		internal static int __PropertyOffset_Result;
	}
}
