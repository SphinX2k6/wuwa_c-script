using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000637 RID: 1591
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathQuaternionInverse")]
	[UnrealStructLayout(48, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_MathQuaternionInverse : FRigUnit_MathQuaternionUnaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060054F4 RID: 21748 RVA: 0x0007B5C4 File Offset: 0x000797C4
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathQuaternionInverse._ScriptStructPtr != 0) ? FRigUnit_MathQuaternionInverse._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathQuaternionInverse", ref FRigUnit_MathQuaternionInverse._ScriptStructPtr);
		}

		// Token: 0x060054F5 RID: 21749 RVA: 0x0007B5E8 File Offset: 0x000797E8
		public FRigUnit_MathQuaternionInverse()
		{
		}

		// Token: 0x060054F6 RID: 21750 RVA: 0x0007B5F0 File Offset: 0x000797F0
		public FRigUnit_MathQuaternionInverse(FQuat Value, FQuat Result)
		{
			base.Value = Value;
			base.Result = Result;
		}

		// Token: 0x060054F7 RID: 21751 RVA: 0x0007B606 File Offset: 0x00079806
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathQuaternionInverse.StaticStruct();
		}

		// Token: 0x060054F8 RID: 21752 RVA: 0x0007B612 File Offset: 0x00079812
		[NullableContext(2)]
		public FRigUnit_MathQuaternionInverse(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060054F9 RID: 21753 RVA: 0x0007B61C File Offset: 0x0007981C
		public FRigUnit_MathQuaternionInverse(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060054FA RID: 21754 RVA: 0x0007B627 File Offset: 0x00079827
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathQuaternionInverse(Pointer, false, true);
		}

		// Token: 0x060054FB RID: 21755 RVA: 0x0007B631 File Offset: 0x00079831
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathQuaternionInverse(Pointer, MemoryOwner);
		}

		// Token: 0x0400284E RID: 10318
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathQuaternionInverse";

		// Token: 0x0400284F RID: 10319
		private static IntPtr _ScriptStructPtr;
	}
}
