using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005E6 RID: 1510
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathColorBinaryOp")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FRigUnit_MathColorBinaryOp : FRigUnit_MathColorBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005161 RID: 20833 RVA: 0x00077C72 File Offset: 0x00075E72
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathColorBinaryOp._ScriptStructPtr != 0) ? FRigUnit_MathColorBinaryOp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathColorBinaryOp", ref FRigUnit_MathColorBinaryOp._ScriptStructPtr);
		}

		// Token: 0x170013F1 RID: 5105
		// (get) Token: 0x06005162 RID: 20834 RVA: 0x00077C96 File Offset: 0x00075E96
		// (set) Token: 0x06005163 RID: 20835 RVA: 0x00077CAA File Offset: 0x00075EAA
		public unsafe FLinearColor A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathColorBinaryOp.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathColorBinaryOp.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x170013F2 RID: 5106
		// (get) Token: 0x06005164 RID: 20836 RVA: 0x00077CBF File Offset: 0x00075EBF
		// (set) Token: 0x06005165 RID: 20837 RVA: 0x00077CD3 File Offset: 0x00075ED3
		public unsafe FLinearColor B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathColorBinaryOp.__PropertyOffset_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathColorBinaryOp.__PropertyOffset_B) = value;
			}
		}

		// Token: 0x170013F3 RID: 5107
		// (get) Token: 0x06005166 RID: 20838 RVA: 0x00077CE8 File Offset: 0x00075EE8
		// (set) Token: 0x06005167 RID: 20839 RVA: 0x00077CFC File Offset: 0x00075EFC
		public unsafe FLinearColor Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathColorBinaryOp.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathColorBinaryOp.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x06005168 RID: 20840 RVA: 0x00077D11 File Offset: 0x00075F11
		public FRigUnit_MathColorBinaryOp()
		{
		}

		// Token: 0x06005169 RID: 20841 RVA: 0x00077D19 File Offset: 0x00075F19
		public FRigUnit_MathColorBinaryOp(FLinearColor A, FLinearColor B, FLinearColor Result)
		{
			this.A = A;
			this.B = B;
			this.Result = Result;
		}

		// Token: 0x0600516A RID: 20842 RVA: 0x00077D36 File Offset: 0x00075F36
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathColorBinaryOp.StaticStruct();
		}

		// Token: 0x0600516B RID: 20843 RVA: 0x00077D42 File Offset: 0x00075F42
		[NullableContext(2)]
		public FRigUnit_MathColorBinaryOp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600516C RID: 20844 RVA: 0x00077D4C File Offset: 0x00075F4C
		public FRigUnit_MathColorBinaryOp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600516D RID: 20845 RVA: 0x00077D57 File Offset: 0x00075F57
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathColorBinaryOp(Pointer, false, true);
		}

		// Token: 0x0600516E RID: 20846 RVA: 0x00077D61 File Offset: 0x00075F61
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathColorBinaryOp(Pointer, MemoryOwner);
		}

		// Token: 0x04002725 RID: 10021
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathColorBinaryOp";

		// Token: 0x04002726 RID: 10022
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002727 RID: 10023
		internal static int __PropertyOffset_A;

		// Token: 0x04002728 RID: 10024
		internal static int __PropertyOffset_B;

		// Token: 0x04002729 RID: 10025
		internal static int __PropertyOffset_Result;
	}
}
