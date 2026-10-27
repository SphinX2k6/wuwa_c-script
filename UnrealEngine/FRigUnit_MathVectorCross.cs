using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200066D RID: 1645
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathVectorCross")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_MathVectorCross : FRigUnit_MathVectorBinaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060057B1 RID: 22449 RVA: 0x0007EA7C File Offset: 0x0007CC7C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathVectorCross._ScriptStructPtr != 0) ? FRigUnit_MathVectorCross._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathVectorCross", ref FRigUnit_MathVectorCross._ScriptStructPtr);
		}

		// Token: 0x060057B2 RID: 22450 RVA: 0x0007EAA0 File Offset: 0x0007CCA0
		public FRigUnit_MathVectorCross()
		{
		}

		// Token: 0x060057B3 RID: 22451 RVA: 0x0007EAA8 File Offset: 0x0007CCA8
		public FRigUnit_MathVectorCross(FVector A, FVector B, FVector Result)
		{
			base.A = A;
			base.B = B;
			base.Result = Result;
		}

		// Token: 0x060057B4 RID: 22452 RVA: 0x0007EAC5 File Offset: 0x0007CCC5
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathVectorCross.StaticStruct();
		}

		// Token: 0x060057B5 RID: 22453 RVA: 0x0007EAD1 File Offset: 0x0007CCD1
		[NullableContext(2)]
		public FRigUnit_MathVectorCross(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060057B6 RID: 22454 RVA: 0x0007EADB File Offset: 0x0007CCDB
		public FRigUnit_MathVectorCross(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060057B7 RID: 22455 RVA: 0x0007EAE6 File Offset: 0x0007CCE6
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathVectorCross(Pointer, false, true);
		}

		// Token: 0x060057B8 RID: 22456 RVA: 0x0007EAF0 File Offset: 0x0007CCF0
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathVectorCross(Pointer, MemoryOwner);
		}

		// Token: 0x04002953 RID: 10579
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathVectorCross";

		// Token: 0x04002954 RID: 10580
		private static IntPtr _ScriptStructPtr;
	}
}
