using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020026BA RID: 9914
	[UnrealObjectPath("/Script/RigVM.RigVMBinaryOp")]
	[UnrealStructLayout(14, 2, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 14)]
	public class FRigVMBinaryOp : FRigVMBaseOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024D34 RID: 150836 RVA: 0x00367CD1 File Offset: 0x00365ED1
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigVMBinaryOp._ScriptStructPtr != 0) ? FRigVMBinaryOp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/RigVM.RigVMBinaryOp", ref FRigVMBinaryOp._ScriptStructPtr);
		}

		// Token: 0x06024D35 RID: 150837 RVA: 0x00367CF5 File Offset: 0x00365EF5
		public FRigVMBinaryOp()
		{
		}

		// Token: 0x06024D36 RID: 150838 RVA: 0x00367CFD File Offset: 0x00365EFD
		protected override IntPtr GetUStructPtr()
		{
			return FRigVMBinaryOp.StaticStruct();
		}

		// Token: 0x06024D37 RID: 150839 RVA: 0x00367D09 File Offset: 0x00365F09
		[NullableContext(2)]
		public FRigVMBinaryOp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024D38 RID: 150840 RVA: 0x00367D13 File Offset: 0x00365F13
		public FRigVMBinaryOp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024D39 RID: 150841 RVA: 0x00367D1E File Offset: 0x00365F1E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigVMBinaryOp(Pointer, false, true);
		}

		// Token: 0x06024D3A RID: 150842 RVA: 0x00367D28 File Offset: 0x00365F28
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigVMBinaryOp(Pointer, MemoryOwner);
		}

		// Token: 0x04013D83 RID: 81283
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/RigVM.RigVMBinaryOp";

		// Token: 0x04013D84 RID: 81284
		private static IntPtr _ScriptStructPtr;
	}
}
