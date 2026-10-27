using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005E0 RID: 1504
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathBoolNot")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_MathBoolNot : FRigUnit_MathBoolUnaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005128 RID: 20776 RVA: 0x0007790A File Offset: 0x00075B0A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathBoolNot._ScriptStructPtr != 0) ? FRigUnit_MathBoolNot._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathBoolNot", ref FRigUnit_MathBoolNot._ScriptStructPtr);
		}

		// Token: 0x06005129 RID: 20777 RVA: 0x0007792E File Offset: 0x00075B2E
		public FRigUnit_MathBoolNot()
		{
		}

		// Token: 0x0600512A RID: 20778 RVA: 0x00077936 File Offset: 0x00075B36
		public FRigUnit_MathBoolNot(bool Value, bool Result)
		{
			base.Value = Value;
			base.Result = Result;
		}

		// Token: 0x0600512B RID: 20779 RVA: 0x0007794C File Offset: 0x00075B4C
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathBoolNot.StaticStruct();
		}

		// Token: 0x0600512C RID: 20780 RVA: 0x00077958 File Offset: 0x00075B58
		[NullableContext(2)]
		public FRigUnit_MathBoolNot(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600512D RID: 20781 RVA: 0x00077962 File Offset: 0x00075B62
		public FRigUnit_MathBoolNot(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600512E RID: 20782 RVA: 0x0007796D File Offset: 0x00075B6D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathBoolNot(Pointer, false, true);
		}

		// Token: 0x0600512F RID: 20783 RVA: 0x00077977 File Offset: 0x00075B77
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathBoolNot(Pointer, MemoryOwner);
		}

		// Token: 0x04002714 RID: 10004
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathBoolNot";

		// Token: 0x04002715 RID: 10005
		private static IntPtr _ScriptStructPtr;
	}
}
