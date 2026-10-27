using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005E2 RID: 1506
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathBoolOr")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_MathBoolOr : FRigUnit_MathBoolBinaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600513E RID: 20798 RVA: 0x00077A60 File Offset: 0x00075C60
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathBoolOr._ScriptStructPtr != 0) ? FRigUnit_MathBoolOr._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathBoolOr", ref FRigUnit_MathBoolOr._ScriptStructPtr);
		}

		// Token: 0x0600513F RID: 20799 RVA: 0x00077A84 File Offset: 0x00075C84
		public FRigUnit_MathBoolOr()
		{
		}

		// Token: 0x06005140 RID: 20800 RVA: 0x00077A8C File Offset: 0x00075C8C
		public FRigUnit_MathBoolOr(bool A, bool B, bool Result)
		{
			base.A = A;
			base.B = B;
			base.Result = Result;
		}

		// Token: 0x06005141 RID: 20801 RVA: 0x00077AA9 File Offset: 0x00075CA9
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathBoolOr.StaticStruct();
		}

		// Token: 0x06005142 RID: 20802 RVA: 0x00077AB5 File Offset: 0x00075CB5
		[NullableContext(2)]
		public FRigUnit_MathBoolOr(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005143 RID: 20803 RVA: 0x00077ABF File Offset: 0x00075CBF
		public FRigUnit_MathBoolOr(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005144 RID: 20804 RVA: 0x00077ACA File Offset: 0x00075CCA
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathBoolOr(Pointer, false, true);
		}

		// Token: 0x06005145 RID: 20805 RVA: 0x00077AD4 File Offset: 0x00075CD4
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathBoolOr(Pointer, MemoryOwner);
		}

		// Token: 0x0400271B RID: 10011
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathBoolOr";

		// Token: 0x0400271C RID: 10012
		private static IntPtr _ScriptStructPtr;
	}
}
