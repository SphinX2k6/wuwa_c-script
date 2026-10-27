using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020026C6 RID: 9926
	[UnrealObjectPath("/Script/RigVM.RigVMJumpOp")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FRigVMJumpOp : FRigVMBaseOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024D9E RID: 150942 RVA: 0x003683BC File Offset: 0x003665BC
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigVMJumpOp._ScriptStructPtr != 0) ? FRigVMJumpOp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/RigVM.RigVMJumpOp", ref FRigVMJumpOp._ScriptStructPtr);
		}

		// Token: 0x06024D9F RID: 150943 RVA: 0x003683E0 File Offset: 0x003665E0
		public FRigVMJumpOp()
		{
		}

		// Token: 0x06024DA0 RID: 150944 RVA: 0x003683E8 File Offset: 0x003665E8
		protected override IntPtr GetUStructPtr()
		{
			return FRigVMJumpOp.StaticStruct();
		}

		// Token: 0x06024DA1 RID: 150945 RVA: 0x003683F4 File Offset: 0x003665F4
		[NullableContext(2)]
		public FRigVMJumpOp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024DA2 RID: 150946 RVA: 0x003683FE File Offset: 0x003665FE
		public FRigVMJumpOp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024DA3 RID: 150947 RVA: 0x00368409 File Offset: 0x00366609
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigVMJumpOp(Pointer, false, true);
		}

		// Token: 0x06024DA4 RID: 150948 RVA: 0x00368413 File Offset: 0x00366613
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigVMJumpOp(Pointer, MemoryOwner);
		}

		// Token: 0x04013DA9 RID: 81321
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/RigVM.RigVMJumpOp";

		// Token: 0x04013DAA RID: 81322
		private static IntPtr _ScriptStructPtr;
	}
}
