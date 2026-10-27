using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020004C5 RID: 1221
	[UnrealObjectPath("/Script/ControlRig.ControlRigExecuteContext")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FControlRigExecuteContext : FRigVMExecuteContext, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600419B RID: 16795 RVA: 0x000623F0 File Offset: 0x000605F0
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FControlRigExecuteContext._ScriptStructPtr != 0) ? FControlRigExecuteContext._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.ControlRigExecuteContext", ref FControlRigExecuteContext._ScriptStructPtr);
		}

		// Token: 0x0600419C RID: 16796 RVA: 0x00062414 File Offset: 0x00060614
		public FControlRigExecuteContext()
		{
		}

		// Token: 0x0600419D RID: 16797 RVA: 0x0006241C File Offset: 0x0006061C
		protected override IntPtr GetUStructPtr()
		{
			return FControlRigExecuteContext.StaticStruct();
		}

		// Token: 0x0600419E RID: 16798 RVA: 0x00062428 File Offset: 0x00060628
		[NullableContext(2)]
		public FControlRigExecuteContext(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600419F RID: 16799 RVA: 0x00062432 File Offset: 0x00060632
		public FControlRigExecuteContext(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060041A0 RID: 16800 RVA: 0x0006243D File Offset: 0x0006063D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FControlRigExecuteContext(Pointer, false, true);
		}

		// Token: 0x060041A1 RID: 16801 RVA: 0x00062447 File Offset: 0x00060647
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FControlRigExecuteContext(Pointer, MemoryOwner);
		}

		// Token: 0x04001F36 RID: 7990
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.ControlRigExecuteContext";

		// Token: 0x04001F37 RID: 7991
		private static IntPtr _ScriptStructPtr;
	}
}
