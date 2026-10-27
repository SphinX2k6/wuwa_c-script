using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000662 RID: 1634
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathTransformUnaryOp")]
	[UnrealStructLayout(112, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FRigUnit_MathTransformUnaryOp : FRigUnit_MathTransformBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600571E RID: 22302 RVA: 0x0007E026 File Offset: 0x0007C226
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathTransformUnaryOp._ScriptStructPtr != 0) ? FRigUnit_MathTransformUnaryOp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathTransformUnaryOp", ref FRigUnit_MathTransformUnaryOp._ScriptStructPtr);
		}

		// Token: 0x170014E3 RID: 5347
		// (get) Token: 0x0600571F RID: 22303 RVA: 0x0007E04A File Offset: 0x0007C24A
		// (set) Token: 0x06005720 RID: 22304 RVA: 0x0007E05E File Offset: 0x0007C25E
		public unsafe FTransform Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathTransformUnaryOp.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathTransformUnaryOp.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x170014E4 RID: 5348
		// (get) Token: 0x06005721 RID: 22305 RVA: 0x0007E073 File Offset: 0x0007C273
		// (set) Token: 0x06005722 RID: 22306 RVA: 0x0007E087 File Offset: 0x0007C287
		public unsafe FTransform Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathTransformUnaryOp.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathTransformUnaryOp.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x06005723 RID: 22307 RVA: 0x0007E09C File Offset: 0x0007C29C
		public FRigUnit_MathTransformUnaryOp()
		{
		}

		// Token: 0x06005724 RID: 22308 RVA: 0x0007E0A4 File Offset: 0x0007C2A4
		public FRigUnit_MathTransformUnaryOp(FTransform Value, FTransform Result)
		{
			this.Value = Value;
			this.Result = Result;
		}

		// Token: 0x06005725 RID: 22309 RVA: 0x0007E0BA File Offset: 0x0007C2BA
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathTransformUnaryOp.StaticStruct();
		}

		// Token: 0x06005726 RID: 22310 RVA: 0x0007E0C6 File Offset: 0x0007C2C6
		[NullableContext(2)]
		public FRigUnit_MathTransformUnaryOp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005727 RID: 22311 RVA: 0x0007E0D0 File Offset: 0x0007C2D0
		public FRigUnit_MathTransformUnaryOp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005728 RID: 22312 RVA: 0x0007E0DB File Offset: 0x0007C2DB
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathTransformUnaryOp(Pointer, false, true);
		}

		// Token: 0x06005729 RID: 22313 RVA: 0x0007E0E5 File Offset: 0x0007C2E5
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathTransformUnaryOp(Pointer, MemoryOwner);
		}

		// Token: 0x0400291E RID: 10526
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathTransformUnaryOp";

		// Token: 0x0400291F RID: 10527
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002920 RID: 10528
		internal static int __PropertyOffset_Value;

		// Token: 0x04002921 RID: 10529
		internal static int __PropertyOffset_Result;
	}
}
