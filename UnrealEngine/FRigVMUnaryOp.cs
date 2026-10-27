using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020026D0 RID: 9936
	[UnrealObjectPath("/Script/RigVM.RigVMUnaryOp")]
	[UnrealStructLayout(8, 2, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FRigVMUnaryOp : FRigVMBaseOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024E31 RID: 151089 RVA: 0x00369024 File Offset: 0x00367224
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigVMUnaryOp._ScriptStructPtr != 0) ? FRigVMUnaryOp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/RigVM.RigVMUnaryOp", ref FRigVMUnaryOp._ScriptStructPtr);
		}

		// Token: 0x06024E32 RID: 151090 RVA: 0x00369048 File Offset: 0x00367248
		public FRigVMUnaryOp()
		{
		}

		// Token: 0x06024E33 RID: 151091 RVA: 0x00369050 File Offset: 0x00367250
		protected override IntPtr GetUStructPtr()
		{
			return FRigVMUnaryOp.StaticStruct();
		}

		// Token: 0x06024E34 RID: 151092 RVA: 0x0036905C File Offset: 0x0036725C
		[NullableContext(2)]
		public FRigVMUnaryOp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024E35 RID: 151093 RVA: 0x00369066 File Offset: 0x00367266
		public FRigVMUnaryOp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024E36 RID: 151094 RVA: 0x00369071 File Offset: 0x00367271
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigVMUnaryOp(Pointer, false, true);
		}

		// Token: 0x06024E37 RID: 151095 RVA: 0x0036907B File Offset: 0x0036727B
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigVMUnaryOp(Pointer, MemoryOwner);
		}

		// Token: 0x04013DF0 RID: 81392
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/RigVM.RigVMUnaryOp";

		// Token: 0x04013DF1 RID: 81393
		private static IntPtr _ScriptStructPtr;
	}
}
