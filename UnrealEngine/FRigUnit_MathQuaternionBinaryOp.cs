using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200062F RID: 1583
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathQuaternionBinaryOp")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FRigUnit_MathQuaternionBinaryOp : FRigUnit_MathQuaternionBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005486 RID: 21638 RVA: 0x0007AE54 File Offset: 0x00079054
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathQuaternionBinaryOp._ScriptStructPtr != 0) ? FRigUnit_MathQuaternionBinaryOp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathQuaternionBinaryOp", ref FRigUnit_MathQuaternionBinaryOp._ScriptStructPtr);
		}

		// Token: 0x17001461 RID: 5217
		// (get) Token: 0x06005487 RID: 21639 RVA: 0x0007AE78 File Offset: 0x00079078
		// (set) Token: 0x06005488 RID: 21640 RVA: 0x0007AE8C File Offset: 0x0007908C
		public unsafe FQuat A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionBinaryOp.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionBinaryOp.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x17001462 RID: 5218
		// (get) Token: 0x06005489 RID: 21641 RVA: 0x0007AEA1 File Offset: 0x000790A1
		// (set) Token: 0x0600548A RID: 21642 RVA: 0x0007AEB5 File Offset: 0x000790B5
		public unsafe FQuat B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionBinaryOp.__PropertyOffset_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionBinaryOp.__PropertyOffset_B) = value;
			}
		}

		// Token: 0x17001463 RID: 5219
		// (get) Token: 0x0600548B RID: 21643 RVA: 0x0007AECA File Offset: 0x000790CA
		// (set) Token: 0x0600548C RID: 21644 RVA: 0x0007AEDE File Offset: 0x000790DE
		public unsafe FQuat Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionBinaryOp.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionBinaryOp.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x0600548D RID: 21645 RVA: 0x0007AEF3 File Offset: 0x000790F3
		public FRigUnit_MathQuaternionBinaryOp()
		{
		}

		// Token: 0x0600548E RID: 21646 RVA: 0x0007AEFB File Offset: 0x000790FB
		public FRigUnit_MathQuaternionBinaryOp(FQuat A, FQuat B, FQuat Result)
		{
			this.A = A;
			this.B = B;
			this.Result = Result;
		}

		// Token: 0x0600548F RID: 21647 RVA: 0x0007AF18 File Offset: 0x00079118
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathQuaternionBinaryOp.StaticStruct();
		}

		// Token: 0x06005490 RID: 21648 RVA: 0x0007AF24 File Offset: 0x00079124
		[NullableContext(2)]
		public FRigUnit_MathQuaternionBinaryOp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005491 RID: 21649 RVA: 0x0007AF2E File Offset: 0x0007912E
		public FRigUnit_MathQuaternionBinaryOp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005492 RID: 21650 RVA: 0x0007AF39 File Offset: 0x00079139
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathQuaternionBinaryOp(Pointer, false, true);
		}

		// Token: 0x06005493 RID: 21651 RVA: 0x0007AF43 File Offset: 0x00079143
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathQuaternionBinaryOp(Pointer, MemoryOwner);
		}

		// Token: 0x04002827 RID: 10279
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathQuaternionBinaryOp";

		// Token: 0x04002828 RID: 10280
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002829 RID: 10281
		internal static int __PropertyOffset_A;

		// Token: 0x0400282A RID: 10282
		internal static int __PropertyOffset_B;

		// Token: 0x0400282B RID: 10283
		internal static int __PropertyOffset_Result;
	}
}
