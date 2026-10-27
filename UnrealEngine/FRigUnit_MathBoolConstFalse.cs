using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005DC RID: 1500
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathBoolConstFalse")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_MathBoolConstFalse : FRigUnit_MathBoolConstant, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005102 RID: 20738 RVA: 0x000776CF File Offset: 0x000758CF
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathBoolConstFalse._ScriptStructPtr != 0) ? FRigUnit_MathBoolConstFalse._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathBoolConstFalse", ref FRigUnit_MathBoolConstFalse._ScriptStructPtr);
		}

		// Token: 0x06005103 RID: 20739 RVA: 0x000776F3 File Offset: 0x000758F3
		public FRigUnit_MathBoolConstFalse()
		{
		}

		// Token: 0x06005104 RID: 20740 RVA: 0x000776FB File Offset: 0x000758FB
		public FRigUnit_MathBoolConstFalse(bool Value)
		{
			base.Value = Value;
		}

		// Token: 0x06005105 RID: 20741 RVA: 0x0007770A File Offset: 0x0007590A
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathBoolConstFalse.StaticStruct();
		}

		// Token: 0x06005106 RID: 20742 RVA: 0x00077716 File Offset: 0x00075916
		[NullableContext(2)]
		public FRigUnit_MathBoolConstFalse(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005107 RID: 20743 RVA: 0x00077720 File Offset: 0x00075920
		public FRigUnit_MathBoolConstFalse(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005108 RID: 20744 RVA: 0x0007772B File Offset: 0x0007592B
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathBoolConstFalse(Pointer, false, true);
		}

		// Token: 0x06005109 RID: 20745 RVA: 0x00077735 File Offset: 0x00075935
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathBoolConstFalse(Pointer, MemoryOwner);
		}

		// Token: 0x04002709 RID: 9993
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathBoolConstFalse";

		// Token: 0x0400270A RID: 9994
		private static IntPtr _ScriptStructPtr;
	}
}
