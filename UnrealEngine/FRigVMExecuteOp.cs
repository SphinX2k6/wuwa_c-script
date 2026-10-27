using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020026C2 RID: 9922
	[UnrealObjectPath("/Script/RigVM.RigVMExecuteOp")]
	[UnrealStructLayout(4, 2, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FRigVMExecuteOp : FRigVMBaseOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024D78 RID: 150904 RVA: 0x0036815C File Offset: 0x0036635C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigVMExecuteOp._ScriptStructPtr != 0) ? FRigVMExecuteOp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/RigVM.RigVMExecuteOp", ref FRigVMExecuteOp._ScriptStructPtr);
		}

		// Token: 0x06024D79 RID: 150905 RVA: 0x00368180 File Offset: 0x00366380
		public FRigVMExecuteOp()
		{
		}

		// Token: 0x06024D7A RID: 150906 RVA: 0x00368188 File Offset: 0x00366388
		protected override IntPtr GetUStructPtr()
		{
			return FRigVMExecuteOp.StaticStruct();
		}

		// Token: 0x06024D7B RID: 150907 RVA: 0x00368194 File Offset: 0x00366394
		[NullableContext(2)]
		public FRigVMExecuteOp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024D7C RID: 150908 RVA: 0x0036819E File Offset: 0x0036639E
		public FRigVMExecuteOp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024D7D RID: 150909 RVA: 0x003681A9 File Offset: 0x003663A9
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigVMExecuteOp(Pointer, false, true);
		}

		// Token: 0x06024D7E RID: 150910 RVA: 0x003681B3 File Offset: 0x003663B3
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigVMExecuteOp(Pointer, MemoryOwner);
		}

		// Token: 0x04013D9C RID: 81308
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/RigVM.RigVMExecuteOp";

		// Token: 0x04013D9D RID: 81309
		private static IntPtr _ScriptStructPtr;
	}
}
