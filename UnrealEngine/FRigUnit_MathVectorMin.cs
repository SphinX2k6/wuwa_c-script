using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200067C RID: 1660
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathVectorMin")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_MathVectorMin : FRigUnit_MathVectorBinaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600585F RID: 22623 RVA: 0x0007F5E4 File Offset: 0x0007D7E4
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathVectorMin._ScriptStructPtr != 0) ? FRigUnit_MathVectorMin._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathVectorMin", ref FRigUnit_MathVectorMin._ScriptStructPtr);
		}

		// Token: 0x06005860 RID: 22624 RVA: 0x0007F608 File Offset: 0x0007D808
		public FRigUnit_MathVectorMin()
		{
		}

		// Token: 0x06005861 RID: 22625 RVA: 0x0007F610 File Offset: 0x0007D810
		public FRigUnit_MathVectorMin(FVector A, FVector B, FVector Result)
		{
			base.A = A;
			base.B = B;
			base.Result = Result;
		}

		// Token: 0x06005862 RID: 22626 RVA: 0x0007F62D File Offset: 0x0007D82D
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathVectorMin.StaticStruct();
		}

		// Token: 0x06005863 RID: 22627 RVA: 0x0007F639 File Offset: 0x0007D839
		[NullableContext(2)]
		public FRigUnit_MathVectorMin(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005864 RID: 22628 RVA: 0x0007F643 File Offset: 0x0007D843
		public FRigUnit_MathVectorMin(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005865 RID: 22629 RVA: 0x0007F64E File Offset: 0x0007D84E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathVectorMin(Pointer, false, true);
		}

		// Token: 0x06005866 RID: 22630 RVA: 0x0007F658 File Offset: 0x0007D858
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathVectorMin(Pointer, MemoryOwner);
		}

		// Token: 0x0400298D RID: 10637
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathVectorMin";

		// Token: 0x0400298E RID: 10638
		private static IntPtr _ScriptStructPtr;
	}
}
