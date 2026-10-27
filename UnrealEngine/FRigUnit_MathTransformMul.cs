using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200065D RID: 1629
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathTransformMul")]
	[UnrealStructLayout(160, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FRigUnit_MathTransformMul : FRigUnit_MathTransformBinaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060056DE RID: 22238 RVA: 0x0007DB94 File Offset: 0x0007BD94
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathTransformMul._ScriptStructPtr != 0) ? FRigUnit_MathTransformMul._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathTransformMul", ref FRigUnit_MathTransformMul._ScriptStructPtr);
		}

		// Token: 0x060056DF RID: 22239 RVA: 0x0007DBB8 File Offset: 0x0007BDB8
		public FRigUnit_MathTransformMul()
		{
		}

		// Token: 0x060056E0 RID: 22240 RVA: 0x0007DBC0 File Offset: 0x0007BDC0
		public FRigUnit_MathTransformMul(FTransform A, FTransform B, FTransform Result)
		{
			base.A = A;
			base.B = B;
			base.Result = Result;
		}

		// Token: 0x060056E1 RID: 22241 RVA: 0x0007DBDD File Offset: 0x0007BDDD
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathTransformMul.StaticStruct();
		}

		// Token: 0x060056E2 RID: 22242 RVA: 0x0007DBE9 File Offset: 0x0007BDE9
		[NullableContext(2)]
		public FRigUnit_MathTransformMul(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060056E3 RID: 22243 RVA: 0x0007DBF3 File Offset: 0x0007BDF3
		public FRigUnit_MathTransformMul(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060056E4 RID: 22244 RVA: 0x0007DBFE File Offset: 0x0007BDFE
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathTransformMul(Pointer, false, true);
		}

		// Token: 0x060056E5 RID: 22245 RVA: 0x0007DC08 File Offset: 0x0007BE08
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathTransformMul(Pointer, MemoryOwner);
		}

		// Token: 0x04002907 RID: 10503
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathTransformMul";

		// Token: 0x04002908 RID: 10504
		private static IntPtr _ScriptStructPtr;
	}
}
