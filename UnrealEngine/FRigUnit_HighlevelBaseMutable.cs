using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005C9 RID: 1481
	[UnrealObjectPath("/Script/ControlRig.RigUnit_HighlevelBaseMutable")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FRigUnit_HighlevelBaseMutable : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005011 RID: 20497 RVA: 0x000764A9 File Offset: 0x000746A9
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_HighlevelBaseMutable._ScriptStructPtr != 0) ? FRigUnit_HighlevelBaseMutable._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_HighlevelBaseMutable", ref FRigUnit_HighlevelBaseMutable._ScriptStructPtr);
		}

		// Token: 0x06005012 RID: 20498 RVA: 0x000764CD File Offset: 0x000746CD
		public FRigUnit_HighlevelBaseMutable()
		{
		}

		// Token: 0x06005013 RID: 20499 RVA: 0x000764D5 File Offset: 0x000746D5
		[NullableContext(1)]
		public FRigUnit_HighlevelBaseMutable(FControlRigExecuteContext ExecuteContext)
		{
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005014 RID: 20500 RVA: 0x000764E4 File Offset: 0x000746E4
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_HighlevelBaseMutable.StaticStruct();
		}

		// Token: 0x06005015 RID: 20501 RVA: 0x000764F0 File Offset: 0x000746F0
		[NullableContext(2)]
		public FRigUnit_HighlevelBaseMutable(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005016 RID: 20502 RVA: 0x000764FA File Offset: 0x000746FA
		public FRigUnit_HighlevelBaseMutable(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005017 RID: 20503 RVA: 0x00076505 File Offset: 0x00074705
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_HighlevelBaseMutable(Pointer, false, true);
		}

		// Token: 0x06005018 RID: 20504 RVA: 0x0007650F File Offset: 0x0007470F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_HighlevelBaseMutable(Pointer, MemoryOwner);
		}

		// Token: 0x040026AA RID: 9898
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_HighlevelBaseMutable";

		// Token: 0x040026AB RID: 9899
		private static IntPtr _ScriptStructPtr;
	}
}
