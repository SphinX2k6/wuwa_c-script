using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020026B9 RID: 9913
	[UnrealObjectPath("/Script/RigVM.RigVMBaseOp")]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1)]
	public class FRigVMBaseOp : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024D2D RID: 150829 RVA: 0x00367C71 File Offset: 0x00365E71
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigVMBaseOp._ScriptStructPtr != 0) ? FRigVMBaseOp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/RigVM.RigVMBaseOp", ref FRigVMBaseOp._ScriptStructPtr);
		}

		// Token: 0x06024D2E RID: 150830 RVA: 0x00367C95 File Offset: 0x00365E95
		public FRigVMBaseOp()
		{
		}

		// Token: 0x06024D2F RID: 150831 RVA: 0x00367C9D File Offset: 0x00365E9D
		protected override IntPtr GetUStructPtr()
		{
			return FRigVMBaseOp.StaticStruct();
		}

		// Token: 0x06024D30 RID: 150832 RVA: 0x00367CA9 File Offset: 0x00365EA9
		[NullableContext(2)]
		public FRigVMBaseOp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024D31 RID: 150833 RVA: 0x00367CB3 File Offset: 0x00365EB3
		public FRigVMBaseOp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024D32 RID: 150834 RVA: 0x00367CBE File Offset: 0x00365EBE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigVMBaseOp(Pointer, false, true);
		}

		// Token: 0x06024D33 RID: 150835 RVA: 0x00367CC8 File Offset: 0x00365EC8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigVMBaseOp(Pointer, MemoryOwner);
		}

		// Token: 0x04013D81 RID: 81281
		[Nullable(1)]
		public const string __ObjectPath = "/Script/RigVM.RigVMBaseOp";

		// Token: 0x04013D82 RID: 81282
		private static IntPtr _ScriptStructPtr;
	}
}
