using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020026C0 RID: 9920
	[UnrealObjectPath("/Script/RigVM.RigVMCopyOp")]
	[UnrealStructLayout(14, 2, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 14)]
	public class FRigVMCopyOp : FRigVMBaseOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024D6A RID: 150890 RVA: 0x0036809C File Offset: 0x0036629C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigVMCopyOp._ScriptStructPtr != 0) ? FRigVMCopyOp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/RigVM.RigVMCopyOp", ref FRigVMCopyOp._ScriptStructPtr);
		}

		// Token: 0x06024D6B RID: 150891 RVA: 0x003680C0 File Offset: 0x003662C0
		public FRigVMCopyOp()
		{
		}

		// Token: 0x06024D6C RID: 150892 RVA: 0x003680C8 File Offset: 0x003662C8
		protected override IntPtr GetUStructPtr()
		{
			return FRigVMCopyOp.StaticStruct();
		}

		// Token: 0x06024D6D RID: 150893 RVA: 0x003680D4 File Offset: 0x003662D4
		[NullableContext(2)]
		public FRigVMCopyOp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024D6E RID: 150894 RVA: 0x003680DE File Offset: 0x003662DE
		public FRigVMCopyOp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024D6F RID: 150895 RVA: 0x003680E9 File Offset: 0x003662E9
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigVMCopyOp(Pointer, false, true);
		}

		// Token: 0x06024D70 RID: 150896 RVA: 0x003680F3 File Offset: 0x003662F3
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigVMCopyOp(Pointer, MemoryOwner);
		}

		// Token: 0x04013D98 RID: 81304
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/RigVM.RigVMCopyOp";

		// Token: 0x04013D99 RID: 81305
		private static IntPtr _ScriptStructPtr;
	}
}
