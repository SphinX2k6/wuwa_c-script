using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005DA RID: 1498
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathBoolBinaryOp")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_MathBoolBinaryOp : FRigUnit_MathBoolBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060050EA RID: 20714 RVA: 0x0007755F File Offset: 0x0007575F
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathBoolBinaryOp._ScriptStructPtr != 0) ? FRigUnit_MathBoolBinaryOp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathBoolBinaryOp", ref FRigUnit_MathBoolBinaryOp._ScriptStructPtr);
		}

		// Token: 0x170013E5 RID: 5093
		// (get) Token: 0x060050EB RID: 20715 RVA: 0x00077583 File Offset: 0x00075783
		// (set) Token: 0x060050EC RID: 20716 RVA: 0x00077593 File Offset: 0x00075793
		public unsafe bool A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathBoolBinaryOp.__PropertyOffset_A) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathBoolBinaryOp.__PropertyOffset_A) = (value ? 1 : 0);
			}
		}

		// Token: 0x170013E6 RID: 5094
		// (get) Token: 0x060050ED RID: 20717 RVA: 0x000775A4 File Offset: 0x000757A4
		// (set) Token: 0x060050EE RID: 20718 RVA: 0x000775B4 File Offset: 0x000757B4
		public unsafe bool B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathBoolBinaryOp.__PropertyOffset_B) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathBoolBinaryOp.__PropertyOffset_B) = (value ? 1 : 0);
			}
		}

		// Token: 0x170013E7 RID: 5095
		// (get) Token: 0x060050EF RID: 20719 RVA: 0x000775C5 File Offset: 0x000757C5
		// (set) Token: 0x060050F0 RID: 20720 RVA: 0x000775D5 File Offset: 0x000757D5
		public unsafe bool Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathBoolBinaryOp.__PropertyOffset_Result) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathBoolBinaryOp.__PropertyOffset_Result) = (value ? 1 : 0);
			}
		}

		// Token: 0x060050F1 RID: 20721 RVA: 0x000775E6 File Offset: 0x000757E6
		public FRigUnit_MathBoolBinaryOp()
		{
		}

		// Token: 0x060050F2 RID: 20722 RVA: 0x000775EE File Offset: 0x000757EE
		public FRigUnit_MathBoolBinaryOp(bool A, bool B, bool Result)
		{
			this.A = A;
			this.B = B;
			this.Result = Result;
		}

		// Token: 0x060050F3 RID: 20723 RVA: 0x0007760B File Offset: 0x0007580B
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathBoolBinaryOp.StaticStruct();
		}

		// Token: 0x060050F4 RID: 20724 RVA: 0x00077617 File Offset: 0x00075817
		[NullableContext(2)]
		public FRigUnit_MathBoolBinaryOp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060050F5 RID: 20725 RVA: 0x00077621 File Offset: 0x00075821
		public FRigUnit_MathBoolBinaryOp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060050F6 RID: 20726 RVA: 0x0007762C File Offset: 0x0007582C
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathBoolBinaryOp(Pointer, false, true);
		}

		// Token: 0x060050F7 RID: 20727 RVA: 0x00077636 File Offset: 0x00075836
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathBoolBinaryOp(Pointer, MemoryOwner);
		}

		// Token: 0x04002701 RID: 9985
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathBoolBinaryOp";

		// Token: 0x04002702 RID: 9986
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002703 RID: 9987
		internal static int __PropertyOffset_A;

		// Token: 0x04002704 RID: 9988
		internal static int __PropertyOffset_B;

		// Token: 0x04002705 RID: 9989
		internal static int __PropertyOffset_Result;
	}
}
