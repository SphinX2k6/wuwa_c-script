using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000668 RID: 1640
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathVectorBinaryOp")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_MathVectorBinaryOp : FRigUnit_MathVectorBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600575F RID: 22367 RVA: 0x0007E490 File Offset: 0x0007C690
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathVectorBinaryOp._ScriptStructPtr != 0) ? FRigUnit_MathVectorBinaryOp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathVectorBinaryOp", ref FRigUnit_MathVectorBinaryOp._ScriptStructPtr);
		}

		// Token: 0x170014EC RID: 5356
		// (get) Token: 0x06005760 RID: 22368 RVA: 0x0007E4B4 File Offset: 0x0007C6B4
		// (set) Token: 0x06005761 RID: 22369 RVA: 0x0007E4C8 File Offset: 0x0007C6C8
		public unsafe FVector A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorBinaryOp.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorBinaryOp.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x170014ED RID: 5357
		// (get) Token: 0x06005762 RID: 22370 RVA: 0x0007E4DD File Offset: 0x0007C6DD
		// (set) Token: 0x06005763 RID: 22371 RVA: 0x0007E4F1 File Offset: 0x0007C6F1
		public unsafe FVector B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorBinaryOp.__PropertyOffset_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorBinaryOp.__PropertyOffset_B) = value;
			}
		}

		// Token: 0x170014EE RID: 5358
		// (get) Token: 0x06005764 RID: 22372 RVA: 0x0007E506 File Offset: 0x0007C706
		// (set) Token: 0x06005765 RID: 22373 RVA: 0x0007E51A File Offset: 0x0007C71A
		public unsafe FVector Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorBinaryOp.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorBinaryOp.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x06005766 RID: 22374 RVA: 0x0007E52F File Offset: 0x0007C72F
		public FRigUnit_MathVectorBinaryOp()
		{
		}

		// Token: 0x06005767 RID: 22375 RVA: 0x0007E537 File Offset: 0x0007C737
		public FRigUnit_MathVectorBinaryOp(FVector A, FVector B, FVector Result)
		{
			this.A = A;
			this.B = B;
			this.Result = Result;
		}

		// Token: 0x06005768 RID: 22376 RVA: 0x0007E554 File Offset: 0x0007C754
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathVectorBinaryOp.StaticStruct();
		}

		// Token: 0x06005769 RID: 22377 RVA: 0x0007E560 File Offset: 0x0007C760
		[NullableContext(2)]
		public FRigUnit_MathVectorBinaryOp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600576A RID: 22378 RVA: 0x0007E56A File Offset: 0x0007C76A
		public FRigUnit_MathVectorBinaryOp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600576B RID: 22379 RVA: 0x0007E575 File Offset: 0x0007C775
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathVectorBinaryOp(Pointer, false, true);
		}

		// Token: 0x0600576C RID: 22380 RVA: 0x0007E57F File Offset: 0x0007C77F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathVectorBinaryOp(Pointer, MemoryOwner);
		}

		// Token: 0x04002934 RID: 10548
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathVectorBinaryOp";

		// Token: 0x04002935 RID: 10549
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002936 RID: 10550
		internal static int __PropertyOffset_A;

		// Token: 0x04002937 RID: 10551
		internal static int __PropertyOffset_B;

		// Token: 0x04002938 RID: 10552
		internal static int __PropertyOffset_Result;
	}
}
