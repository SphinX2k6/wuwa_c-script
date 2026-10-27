using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000638 RID: 1592
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathQuaternionMul")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FRigUnit_MathQuaternionMul : FRigUnit_MathQuaternionBinaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060054FC RID: 21756 RVA: 0x0007B63A File Offset: 0x0007983A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathQuaternionMul._ScriptStructPtr != 0) ? FRigUnit_MathQuaternionMul._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathQuaternionMul", ref FRigUnit_MathQuaternionMul._ScriptStructPtr);
		}

		// Token: 0x060054FD RID: 21757 RVA: 0x0007B65E File Offset: 0x0007985E
		public FRigUnit_MathQuaternionMul()
		{
		}

		// Token: 0x060054FE RID: 21758 RVA: 0x0007B666 File Offset: 0x00079866
		public FRigUnit_MathQuaternionMul(FQuat A, FQuat B, FQuat Result)
		{
			base.A = A;
			base.B = B;
			base.Result = Result;
		}

		// Token: 0x060054FF RID: 21759 RVA: 0x0007B683 File Offset: 0x00079883
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathQuaternionMul.StaticStruct();
		}

		// Token: 0x06005500 RID: 21760 RVA: 0x0007B68F File Offset: 0x0007988F
		[NullableContext(2)]
		public FRigUnit_MathQuaternionMul(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005501 RID: 21761 RVA: 0x0007B699 File Offset: 0x00079899
		public FRigUnit_MathQuaternionMul(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005502 RID: 21762 RVA: 0x0007B6A4 File Offset: 0x000798A4
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathQuaternionMul(Pointer, false, true);
		}

		// Token: 0x06005503 RID: 21763 RVA: 0x0007B6AE File Offset: 0x000798AE
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathQuaternionMul(Pointer, MemoryOwner);
		}

		// Token: 0x04002850 RID: 10320
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathQuaternionMul";

		// Token: 0x04002851 RID: 10321
		private static IntPtr _ScriptStructPtr;
	}
}
