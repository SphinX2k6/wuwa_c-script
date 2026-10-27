using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020026C5 RID: 9925
	[UnrealObjectPath("/Script/RigVM.RigVMJumpIfOp")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigVMJumpIfOp : FRigVMUnaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024D97 RID: 150935 RVA: 0x0036835C File Offset: 0x0036655C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigVMJumpIfOp._ScriptStructPtr != 0) ? FRigVMJumpIfOp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/RigVM.RigVMJumpIfOp", ref FRigVMJumpIfOp._ScriptStructPtr);
		}

		// Token: 0x06024D98 RID: 150936 RVA: 0x00368380 File Offset: 0x00366580
		public FRigVMJumpIfOp()
		{
		}

		// Token: 0x06024D99 RID: 150937 RVA: 0x00368388 File Offset: 0x00366588
		protected override IntPtr GetUStructPtr()
		{
			return FRigVMJumpIfOp.StaticStruct();
		}

		// Token: 0x06024D9A RID: 150938 RVA: 0x00368394 File Offset: 0x00366594
		[NullableContext(2)]
		public FRigVMJumpIfOp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024D9B RID: 150939 RVA: 0x0036839E File Offset: 0x0036659E
		public FRigVMJumpIfOp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024D9C RID: 150940 RVA: 0x003683A9 File Offset: 0x003665A9
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigVMJumpIfOp(Pointer, false, true);
		}

		// Token: 0x06024D9D RID: 150941 RVA: 0x003683B3 File Offset: 0x003665B3
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigVMJumpIfOp(Pointer, MemoryOwner);
		}

		// Token: 0x04013DA7 RID: 81319
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/RigVM.RigVMJumpIfOp";

		// Token: 0x04013DA8 RID: 81320
		private static IntPtr _ScriptStructPtr;
	}
}
