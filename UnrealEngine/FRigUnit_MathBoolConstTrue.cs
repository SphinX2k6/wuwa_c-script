using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005DD RID: 1501
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathBoolConstTrue")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_MathBoolConstTrue : FRigUnit_MathBoolConstant, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600510A RID: 20746 RVA: 0x0007773E File Offset: 0x0007593E
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathBoolConstTrue._ScriptStructPtr != 0) ? FRigUnit_MathBoolConstTrue._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathBoolConstTrue", ref FRigUnit_MathBoolConstTrue._ScriptStructPtr);
		}

		// Token: 0x0600510B RID: 20747 RVA: 0x00077762 File Offset: 0x00075962
		public FRigUnit_MathBoolConstTrue()
		{
		}

		// Token: 0x0600510C RID: 20748 RVA: 0x0007776A File Offset: 0x0007596A
		public FRigUnit_MathBoolConstTrue(bool Value)
		{
			base.Value = Value;
		}

		// Token: 0x0600510D RID: 20749 RVA: 0x00077779 File Offset: 0x00075979
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathBoolConstTrue.StaticStruct();
		}

		// Token: 0x0600510E RID: 20750 RVA: 0x00077785 File Offset: 0x00075985
		[NullableContext(2)]
		public FRigUnit_MathBoolConstTrue(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600510F RID: 20751 RVA: 0x0007778F File Offset: 0x0007598F
		public FRigUnit_MathBoolConstTrue(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005110 RID: 20752 RVA: 0x0007779A File Offset: 0x0007599A
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathBoolConstTrue(Pointer, false, true);
		}

		// Token: 0x06005111 RID: 20753 RVA: 0x000777A4 File Offset: 0x000759A4
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathBoolConstTrue(Pointer, MemoryOwner);
		}

		// Token: 0x0400270B RID: 9995
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathBoolConstTrue";

		// Token: 0x0400270C RID: 9996
		private static IntPtr _ScriptStructPtr;
	}
}
