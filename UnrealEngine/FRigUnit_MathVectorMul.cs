using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200067F RID: 1663
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathVectorMul")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_MathVectorMul : FRigUnit_MathVectorBinaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600587D RID: 22653 RVA: 0x0007F7D6 File Offset: 0x0007D9D6
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathVectorMul._ScriptStructPtr != 0) ? FRigUnit_MathVectorMul._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathVectorMul", ref FRigUnit_MathVectorMul._ScriptStructPtr);
		}

		// Token: 0x0600587E RID: 22654 RVA: 0x0007F7FA File Offset: 0x0007D9FA
		public FRigUnit_MathVectorMul()
		{
		}

		// Token: 0x0600587F RID: 22655 RVA: 0x0007F802 File Offset: 0x0007DA02
		public FRigUnit_MathVectorMul(FVector A, FVector B, FVector Result)
		{
			base.A = A;
			base.B = B;
			base.Result = Result;
		}

		// Token: 0x06005880 RID: 22656 RVA: 0x0007F81F File Offset: 0x0007DA1F
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathVectorMul.StaticStruct();
		}

		// Token: 0x06005881 RID: 22657 RVA: 0x0007F82B File Offset: 0x0007DA2B
		[NullableContext(2)]
		public FRigUnit_MathVectorMul(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005882 RID: 22658 RVA: 0x0007F835 File Offset: 0x0007DA35
		public FRigUnit_MathVectorMul(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005883 RID: 22659 RVA: 0x0007F840 File Offset: 0x0007DA40
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathVectorMul(Pointer, false, true);
		}

		// Token: 0x06005884 RID: 22660 RVA: 0x0007F84A File Offset: 0x0007DA4A
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathVectorMul(Pointer, MemoryOwner);
		}

		// Token: 0x04002996 RID: 10646
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathVectorMul";

		// Token: 0x04002997 RID: 10647
		private static IntPtr _ScriptStructPtr;
	}
}
