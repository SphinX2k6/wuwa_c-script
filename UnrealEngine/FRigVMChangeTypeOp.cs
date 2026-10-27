using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020026BE RID: 9918
	[UnrealObjectPath("/Script/RigVM.RigVMChangeTypeOp")]
	[UnrealStructLayout(16, 2, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigVMChangeTypeOp : FRigVMUnaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024D5C RID: 150876 RVA: 0x00367FDC File Offset: 0x003661DC
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigVMChangeTypeOp._ScriptStructPtr != 0) ? FRigVMChangeTypeOp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/RigVM.RigVMChangeTypeOp", ref FRigVMChangeTypeOp._ScriptStructPtr);
		}

		// Token: 0x06024D5D RID: 150877 RVA: 0x00368000 File Offset: 0x00366200
		public FRigVMChangeTypeOp()
		{
		}

		// Token: 0x06024D5E RID: 150878 RVA: 0x00368008 File Offset: 0x00366208
		protected override IntPtr GetUStructPtr()
		{
			return FRigVMChangeTypeOp.StaticStruct();
		}

		// Token: 0x06024D5F RID: 150879 RVA: 0x00368014 File Offset: 0x00366214
		[NullableContext(2)]
		public FRigVMChangeTypeOp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024D60 RID: 150880 RVA: 0x0036801E File Offset: 0x0036621E
		public FRigVMChangeTypeOp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024D61 RID: 150881 RVA: 0x00368029 File Offset: 0x00366229
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigVMChangeTypeOp(Pointer, false, true);
		}

		// Token: 0x06024D62 RID: 150882 RVA: 0x00368033 File Offset: 0x00366233
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigVMChangeTypeOp(Pointer, MemoryOwner);
		}

		// Token: 0x04013D94 RID: 81300
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/RigVM.RigVMChangeTypeOp";

		// Token: 0x04013D95 RID: 81301
		private static IntPtr _ScriptStructPtr;
	}
}
