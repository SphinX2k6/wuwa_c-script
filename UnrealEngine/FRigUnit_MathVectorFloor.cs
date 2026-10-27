using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000673 RID: 1651
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathVectorFloor")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FRigUnit_MathVectorFloor : FRigUnit_MathVectorUnaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060057F3 RID: 22515 RVA: 0x0007EEBC File Offset: 0x0007D0BC
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathVectorFloor._ScriptStructPtr != 0) ? FRigUnit_MathVectorFloor._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathVectorFloor", ref FRigUnit_MathVectorFloor._ScriptStructPtr);
		}

		// Token: 0x060057F4 RID: 22516 RVA: 0x0007EEE0 File Offset: 0x0007D0E0
		public FRigUnit_MathVectorFloor()
		{
		}

		// Token: 0x060057F5 RID: 22517 RVA: 0x0007EEE8 File Offset: 0x0007D0E8
		public FRigUnit_MathVectorFloor(FVector Value, FVector Result)
		{
			base.Value = Value;
			base.Result = Result;
		}

		// Token: 0x060057F6 RID: 22518 RVA: 0x0007EEFE File Offset: 0x0007D0FE
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathVectorFloor.StaticStruct();
		}

		// Token: 0x060057F7 RID: 22519 RVA: 0x0007EF0A File Offset: 0x0007D10A
		[NullableContext(2)]
		public FRigUnit_MathVectorFloor(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060057F8 RID: 22520 RVA: 0x0007EF14 File Offset: 0x0007D114
		public FRigUnit_MathVectorFloor(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060057F9 RID: 22521 RVA: 0x0007EF1F File Offset: 0x0007D11F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathVectorFloor(Pointer, false, true);
		}

		// Token: 0x060057FA RID: 22522 RVA: 0x0007EF29 File Offset: 0x0007D129
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathVectorFloor(Pointer, MemoryOwner);
		}

		// Token: 0x04002968 RID: 10600
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathVectorFloor";

		// Token: 0x04002969 RID: 10601
		private static IntPtr _ScriptStructPtr;
	}
}
