using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000680 RID: 1664
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathVectorNegate")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FRigUnit_MathVectorNegate : FRigUnit_MathVectorUnaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005885 RID: 22661 RVA: 0x0007F853 File Offset: 0x0007DA53
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathVectorNegate._ScriptStructPtr != 0) ? FRigUnit_MathVectorNegate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathVectorNegate", ref FRigUnit_MathVectorNegate._ScriptStructPtr);
		}

		// Token: 0x06005886 RID: 22662 RVA: 0x0007F877 File Offset: 0x0007DA77
		public FRigUnit_MathVectorNegate()
		{
		}

		// Token: 0x06005887 RID: 22663 RVA: 0x0007F87F File Offset: 0x0007DA7F
		public FRigUnit_MathVectorNegate(FVector Value, FVector Result)
		{
			base.Value = Value;
			base.Result = Result;
		}

		// Token: 0x06005888 RID: 22664 RVA: 0x0007F895 File Offset: 0x0007DA95
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathVectorNegate.StaticStruct();
		}

		// Token: 0x06005889 RID: 22665 RVA: 0x0007F8A1 File Offset: 0x0007DAA1
		[NullableContext(2)]
		public FRigUnit_MathVectorNegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600588A RID: 22666 RVA: 0x0007F8AB File Offset: 0x0007DAAB
		public FRigUnit_MathVectorNegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600588B RID: 22667 RVA: 0x0007F8B6 File Offset: 0x0007DAB6
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathVectorNegate(Pointer, false, true);
		}

		// Token: 0x0600588C RID: 22668 RVA: 0x0007F8C0 File Offset: 0x0007DAC0
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathVectorNegate(Pointer, MemoryOwner);
		}

		// Token: 0x04002998 RID: 10648
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathVectorNegate";

		// Token: 0x04002999 RID: 10649
		private static IntPtr _ScriptStructPtr;
	}
}
