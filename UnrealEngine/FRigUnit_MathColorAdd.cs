using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005E4 RID: 1508
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathColorAdd")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FRigUnit_MathColorAdd : FRigUnit_MathColorBinaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005152 RID: 20818 RVA: 0x00077B95 File Offset: 0x00075D95
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathColorAdd._ScriptStructPtr != 0) ? FRigUnit_MathColorAdd._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathColorAdd", ref FRigUnit_MathColorAdd._ScriptStructPtr);
		}

		// Token: 0x06005153 RID: 20819 RVA: 0x00077BB9 File Offset: 0x00075DB9
		public FRigUnit_MathColorAdd()
		{
		}

		// Token: 0x06005154 RID: 20820 RVA: 0x00077BC1 File Offset: 0x00075DC1
		public FRigUnit_MathColorAdd(FLinearColor A, FLinearColor B, FLinearColor Result)
		{
			base.A = A;
			base.B = B;
			base.Result = Result;
		}

		// Token: 0x06005155 RID: 20821 RVA: 0x00077BDE File Offset: 0x00075DDE
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathColorAdd.StaticStruct();
		}

		// Token: 0x06005156 RID: 20822 RVA: 0x00077BEA File Offset: 0x00075DEA
		[NullableContext(2)]
		public FRigUnit_MathColorAdd(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005157 RID: 20823 RVA: 0x00077BF4 File Offset: 0x00075DF4
		public FRigUnit_MathColorAdd(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005158 RID: 20824 RVA: 0x00077BFF File Offset: 0x00075DFF
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathColorAdd(Pointer, false, true);
		}

		// Token: 0x06005159 RID: 20825 RVA: 0x00077C09 File Offset: 0x00075E09
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathColorAdd(Pointer, MemoryOwner);
		}

		// Token: 0x04002721 RID: 10017
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathColorAdd";

		// Token: 0x04002722 RID: 10018
		private static IntPtr _ScriptStructPtr;
	}
}
