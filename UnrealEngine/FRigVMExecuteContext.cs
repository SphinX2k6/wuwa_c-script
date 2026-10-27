using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020026C1 RID: 9921
	[UnrealObjectPath("/Script/RigVM.RigVMExecuteContext")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FRigVMExecuteContext : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024D71 RID: 150897 RVA: 0x003680FC File Offset: 0x003662FC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigVMExecuteContext._ScriptStructPtr != 0) ? FRigVMExecuteContext._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/RigVM.RigVMExecuteContext", ref FRigVMExecuteContext._ScriptStructPtr);
		}

		// Token: 0x06024D72 RID: 150898 RVA: 0x00368120 File Offset: 0x00366320
		public FRigVMExecuteContext()
		{
		}

		// Token: 0x06024D73 RID: 150899 RVA: 0x00368128 File Offset: 0x00366328
		protected override IntPtr GetUStructPtr()
		{
			return FRigVMExecuteContext.StaticStruct();
		}

		// Token: 0x06024D74 RID: 150900 RVA: 0x00368134 File Offset: 0x00366334
		[NullableContext(2)]
		public FRigVMExecuteContext(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024D75 RID: 150901 RVA: 0x0036813E File Offset: 0x0036633E
		public FRigVMExecuteContext(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024D76 RID: 150902 RVA: 0x00368149 File Offset: 0x00366349
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigVMExecuteContext(Pointer, false, true);
		}

		// Token: 0x06024D77 RID: 150903 RVA: 0x00368153 File Offset: 0x00366353
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigVMExecuteContext(Pointer, MemoryOwner);
		}

		// Token: 0x04013D9A RID: 81306
		[Nullable(1)]
		public const string __ObjectPath = "/Script/RigVM.RigVMExecuteContext";

		// Token: 0x04013D9B RID: 81307
		private static IntPtr _ScriptStructPtr;
	}
}
