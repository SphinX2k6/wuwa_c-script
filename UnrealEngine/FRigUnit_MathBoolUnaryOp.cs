using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005E3 RID: 1507
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathBoolUnaryOp")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_MathBoolUnaryOp : FRigUnit_MathBoolBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005146 RID: 20806 RVA: 0x00077ADD File Offset: 0x00075CDD
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathBoolUnaryOp._ScriptStructPtr != 0) ? FRigUnit_MathBoolUnaryOp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathBoolUnaryOp", ref FRigUnit_MathBoolUnaryOp._ScriptStructPtr);
		}

		// Token: 0x170013EF RID: 5103
		// (get) Token: 0x06005147 RID: 20807 RVA: 0x00077B01 File Offset: 0x00075D01
		// (set) Token: 0x06005148 RID: 20808 RVA: 0x00077B11 File Offset: 0x00075D11
		public unsafe bool Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathBoolUnaryOp.__PropertyOffset_Value) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathBoolUnaryOp.__PropertyOffset_Value) = (value ? 1 : 0);
			}
		}

		// Token: 0x170013F0 RID: 5104
		// (get) Token: 0x06005149 RID: 20809 RVA: 0x00077B22 File Offset: 0x00075D22
		// (set) Token: 0x0600514A RID: 20810 RVA: 0x00077B32 File Offset: 0x00075D32
		public unsafe bool Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathBoolUnaryOp.__PropertyOffset_Result) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathBoolUnaryOp.__PropertyOffset_Result) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600514B RID: 20811 RVA: 0x00077B43 File Offset: 0x00075D43
		public FRigUnit_MathBoolUnaryOp()
		{
		}

		// Token: 0x0600514C RID: 20812 RVA: 0x00077B4B File Offset: 0x00075D4B
		public FRigUnit_MathBoolUnaryOp(bool Value, bool Result)
		{
			this.Value = Value;
			this.Result = Result;
		}

		// Token: 0x0600514D RID: 20813 RVA: 0x00077B61 File Offset: 0x00075D61
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathBoolUnaryOp.StaticStruct();
		}

		// Token: 0x0600514E RID: 20814 RVA: 0x00077B6D File Offset: 0x00075D6D
		[NullableContext(2)]
		public FRigUnit_MathBoolUnaryOp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600514F RID: 20815 RVA: 0x00077B77 File Offset: 0x00075D77
		public FRigUnit_MathBoolUnaryOp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005150 RID: 20816 RVA: 0x00077B82 File Offset: 0x00075D82
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathBoolUnaryOp(Pointer, false, true);
		}

		// Token: 0x06005151 RID: 20817 RVA: 0x00077B8C File Offset: 0x00075D8C
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathBoolUnaryOp(Pointer, MemoryOwner);
		}

		// Token: 0x0400271D RID: 10013
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathBoolUnaryOp";

		// Token: 0x0400271E RID: 10014
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400271F RID: 10015
		internal static int __PropertyOffset_Value;

		// Token: 0x04002720 RID: 10016
		internal static int __PropertyOffset_Result;
	}
}
