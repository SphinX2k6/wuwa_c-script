using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000583 RID: 1411
	[UnrealObjectPath("/Script/ControlRig.RigUnit_DebugBaseMutable")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FRigUnit_DebugBaseMutable : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004B27 RID: 19239 RVA: 0x0006F644 File Offset: 0x0006D844
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_DebugBaseMutable._ScriptStructPtr != 0) ? FRigUnit_DebugBaseMutable._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_DebugBaseMutable", ref FRigUnit_DebugBaseMutable._ScriptStructPtr);
		}

		// Token: 0x06004B28 RID: 19240 RVA: 0x0006F668 File Offset: 0x0006D868
		public FRigUnit_DebugBaseMutable()
		{
		}

		// Token: 0x06004B29 RID: 19241 RVA: 0x0006F670 File Offset: 0x0006D870
		[NullableContext(1)]
		public FRigUnit_DebugBaseMutable(FControlRigExecuteContext ExecuteContext)
		{
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06004B2A RID: 19242 RVA: 0x0006F67F File Offset: 0x0006D87F
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_DebugBaseMutable.StaticStruct();
		}

		// Token: 0x06004B2B RID: 19243 RVA: 0x0006F68B File Offset: 0x0006D88B
		[NullableContext(2)]
		public FRigUnit_DebugBaseMutable(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004B2C RID: 19244 RVA: 0x0006F695 File Offset: 0x0006D895
		public FRigUnit_DebugBaseMutable(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004B2D RID: 19245 RVA: 0x0006F6A0 File Offset: 0x0006D8A0
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_DebugBaseMutable(Pointer, false, true);
		}

		// Token: 0x06004B2E RID: 19246 RVA: 0x0006F6AA File Offset: 0x0006D8AA
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_DebugBaseMutable(Pointer, MemoryOwner);
		}

		// Token: 0x0400246C RID: 9324
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_DebugBaseMutable";

		// Token: 0x0400246D RID: 9325
		private static IntPtr _ScriptStructPtr;
	}
}
