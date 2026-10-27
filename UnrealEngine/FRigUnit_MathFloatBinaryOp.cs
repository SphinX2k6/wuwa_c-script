using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005F1 RID: 1521
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatBinaryOp")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_MathFloatBinaryOp : FRigUnit_MathFloatBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060051CA RID: 20938 RVA: 0x000782FA File Offset: 0x000764FA
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatBinaryOp._ScriptStructPtr != 0) ? FRigUnit_MathFloatBinaryOp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatBinaryOp", ref FRigUnit_MathFloatBinaryOp._ScriptStructPtr);
		}

		// Token: 0x170013FA RID: 5114
		// (get) Token: 0x060051CB RID: 20939 RVA: 0x0007831E File Offset: 0x0007651E
		// (set) Token: 0x060051CC RID: 20940 RVA: 0x0007832E File Offset: 0x0007652E
		public unsafe float A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatBinaryOp.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatBinaryOp.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x170013FB RID: 5115
		// (get) Token: 0x060051CD RID: 20941 RVA: 0x0007833F File Offset: 0x0007653F
		// (set) Token: 0x060051CE RID: 20942 RVA: 0x0007834F File Offset: 0x0007654F
		public unsafe float B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatBinaryOp.__PropertyOffset_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatBinaryOp.__PropertyOffset_B) = value;
			}
		}

		// Token: 0x170013FC RID: 5116
		// (get) Token: 0x060051CF RID: 20943 RVA: 0x00078360 File Offset: 0x00076560
		// (set) Token: 0x060051D0 RID: 20944 RVA: 0x00078370 File Offset: 0x00076570
		public unsafe float Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatBinaryOp.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatBinaryOp.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x060051D1 RID: 20945 RVA: 0x00078381 File Offset: 0x00076581
		public FRigUnit_MathFloatBinaryOp()
		{
		}

		// Token: 0x060051D2 RID: 20946 RVA: 0x00078389 File Offset: 0x00076589
		public FRigUnit_MathFloatBinaryOp(float A, float B, float Result)
		{
			this.A = A;
			this.B = B;
			this.Result = Result;
		}

		// Token: 0x060051D3 RID: 20947 RVA: 0x000783A6 File Offset: 0x000765A6
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatBinaryOp.StaticStruct();
		}

		// Token: 0x060051D4 RID: 20948 RVA: 0x000783B2 File Offset: 0x000765B2
		[NullableContext(2)]
		public FRigUnit_MathFloatBinaryOp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060051D5 RID: 20949 RVA: 0x000783BC File Offset: 0x000765BC
		public FRigUnit_MathFloatBinaryOp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060051D6 RID: 20950 RVA: 0x000783C7 File Offset: 0x000765C7
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatBinaryOp(Pointer, false, true);
		}

		// Token: 0x060051D7 RID: 20951 RVA: 0x000783D1 File Offset: 0x000765D1
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatBinaryOp(Pointer, MemoryOwner);
		}

		// Token: 0x04002744 RID: 10052
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatBinaryOp";

		// Token: 0x04002745 RID: 10053
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002746 RID: 10054
		internal static int __PropertyOffset_A;

		// Token: 0x04002747 RID: 10055
		internal static int __PropertyOffset_B;

		// Token: 0x04002748 RID: 10056
		internal static int __PropertyOffset_Result;
	}
}
