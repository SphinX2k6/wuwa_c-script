using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005CF RID: 1487
	[UnrealObjectPath("/Script/ControlRig.RigUnit_ItemBaseMutable")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FRigUnit_ItemBaseMutable : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005046 RID: 20550 RVA: 0x00076827 File Offset: 0x00074A27
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_ItemBaseMutable._ScriptStructPtr != 0) ? FRigUnit_ItemBaseMutable._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_ItemBaseMutable", ref FRigUnit_ItemBaseMutable._ScriptStructPtr);
		}

		// Token: 0x06005047 RID: 20551 RVA: 0x0007684B File Offset: 0x00074A4B
		public FRigUnit_ItemBaseMutable()
		{
		}

		// Token: 0x06005048 RID: 20552 RVA: 0x00076853 File Offset: 0x00074A53
		[NullableContext(1)]
		public FRigUnit_ItemBaseMutable(FControlRigExecuteContext ExecuteContext)
		{
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005049 RID: 20553 RVA: 0x00076862 File Offset: 0x00074A62
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_ItemBaseMutable.StaticStruct();
		}

		// Token: 0x0600504A RID: 20554 RVA: 0x0007686E File Offset: 0x00074A6E
		[NullableContext(2)]
		public FRigUnit_ItemBaseMutable(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600504B RID: 20555 RVA: 0x00076878 File Offset: 0x00074A78
		public FRigUnit_ItemBaseMutable(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600504C RID: 20556 RVA: 0x00076883 File Offset: 0x00074A83
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_ItemBaseMutable(Pointer, false, true);
		}

		// Token: 0x0600504D RID: 20557 RVA: 0x0007688D File Offset: 0x00074A8D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_ItemBaseMutable(Pointer, MemoryOwner);
		}

		// Token: 0x040026BB RID: 9915
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_ItemBaseMutable";

		// Token: 0x040026BC RID: 9916
		private static IntPtr _ScriptStructPtr;
	}
}
