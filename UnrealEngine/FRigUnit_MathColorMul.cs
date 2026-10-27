using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005E9 RID: 1513
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathColorMul")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FRigUnit_MathColorMul : FRigUnit_MathColorBinaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600518B RID: 20875 RVA: 0x00077F4B File Offset: 0x0007614B
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathColorMul._ScriptStructPtr != 0) ? FRigUnit_MathColorMul._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathColorMul", ref FRigUnit_MathColorMul._ScriptStructPtr);
		}

		// Token: 0x0600518C RID: 20876 RVA: 0x00077F6F File Offset: 0x0007616F
		public FRigUnit_MathColorMul()
		{
		}

		// Token: 0x0600518D RID: 20877 RVA: 0x00077F77 File Offset: 0x00076177
		public FRigUnit_MathColorMul(FLinearColor A, FLinearColor B, FLinearColor Result)
		{
			base.A = A;
			base.B = B;
			base.Result = Result;
		}

		// Token: 0x0600518E RID: 20878 RVA: 0x00077F94 File Offset: 0x00076194
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathColorMul.StaticStruct();
		}

		// Token: 0x0600518F RID: 20879 RVA: 0x00077FA0 File Offset: 0x000761A0
		[NullableContext(2)]
		public FRigUnit_MathColorMul(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005190 RID: 20880 RVA: 0x00077FAA File Offset: 0x000761AA
		public FRigUnit_MathColorMul(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005191 RID: 20881 RVA: 0x00077FB5 File Offset: 0x000761B5
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathColorMul(Pointer, false, true);
		}

		// Token: 0x06005192 RID: 20882 RVA: 0x00077FBF File Offset: 0x000761BF
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathColorMul(Pointer, MemoryOwner);
		}

		// Token: 0x04002734 RID: 10036
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathColorMul";

		// Token: 0x04002735 RID: 10037
		private static IntPtr _ScriptStructPtr;
	}
}
