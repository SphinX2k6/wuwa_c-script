using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006D4 RID: 1748
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SimBaseMutable")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FRigUnit_SimBaseMutable : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005D9E RID: 23966 RVA: 0x0008662D File Offset: 0x0008482D
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SimBaseMutable._ScriptStructPtr != 0) ? FRigUnit_SimBaseMutable._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SimBaseMutable", ref FRigUnit_SimBaseMutable._ScriptStructPtr);
		}

		// Token: 0x06005D9F RID: 23967 RVA: 0x00086651 File Offset: 0x00084851
		public FRigUnit_SimBaseMutable()
		{
		}

		// Token: 0x06005DA0 RID: 23968 RVA: 0x00086659 File Offset: 0x00084859
		[NullableContext(1)]
		public FRigUnit_SimBaseMutable(FControlRigExecuteContext ExecuteContext)
		{
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005DA1 RID: 23969 RVA: 0x00086668 File Offset: 0x00084868
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SimBaseMutable.StaticStruct();
		}

		// Token: 0x06005DA2 RID: 23970 RVA: 0x00086674 File Offset: 0x00084874
		[NullableContext(2)]
		public FRigUnit_SimBaseMutable(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005DA3 RID: 23971 RVA: 0x0008667E File Offset: 0x0008487E
		public FRigUnit_SimBaseMutable(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005DA4 RID: 23972 RVA: 0x00086689 File Offset: 0x00084889
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SimBaseMutable(Pointer, false, true);
		}

		// Token: 0x06005DA5 RID: 23973 RVA: 0x00086693 File Offset: 0x00084893
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SimBaseMutable(Pointer, MemoryOwner);
		}

		// Token: 0x04002BCF RID: 11215
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_SimBaseMutable";

		// Token: 0x04002BD0 RID: 11216
		private static IntPtr _ScriptStructPtr;
	}
}
