using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000669 RID: 1641
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathVectorCeil")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FRigUnit_MathVectorCeil : FRigUnit_MathVectorUnaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600576D RID: 22381 RVA: 0x0007E588 File Offset: 0x0007C788
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathVectorCeil._ScriptStructPtr != 0) ? FRigUnit_MathVectorCeil._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathVectorCeil", ref FRigUnit_MathVectorCeil._ScriptStructPtr);
		}

		// Token: 0x0600576E RID: 22382 RVA: 0x0007E5AC File Offset: 0x0007C7AC
		public FRigUnit_MathVectorCeil()
		{
		}

		// Token: 0x0600576F RID: 22383 RVA: 0x0007E5B4 File Offset: 0x0007C7B4
		public FRigUnit_MathVectorCeil(FVector Value, FVector Result)
		{
			base.Value = Value;
			base.Result = Result;
		}

		// Token: 0x06005770 RID: 22384 RVA: 0x0007E5CA File Offset: 0x0007C7CA
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathVectorCeil.StaticStruct();
		}

		// Token: 0x06005771 RID: 22385 RVA: 0x0007E5D6 File Offset: 0x0007C7D6
		[NullableContext(2)]
		public FRigUnit_MathVectorCeil(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005772 RID: 22386 RVA: 0x0007E5E0 File Offset: 0x0007C7E0
		public FRigUnit_MathVectorCeil(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005773 RID: 22387 RVA: 0x0007E5EB File Offset: 0x0007C7EB
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathVectorCeil(Pointer, false, true);
		}

		// Token: 0x06005774 RID: 22388 RVA: 0x0007E5F5 File Offset: 0x0007C7F5
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathVectorCeil(Pointer, MemoryOwner);
		}

		// Token: 0x04002939 RID: 10553
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathVectorCeil";

		// Token: 0x0400293A RID: 10554
		private static IntPtr _ScriptStructPtr;
	}
}
