using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200062D RID: 1581
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathIntUnaryOp")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_MathIntUnaryOp : FRigUnit_MathIntBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005473 RID: 21619 RVA: 0x0007AD3C File Offset: 0x00078F3C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathIntUnaryOp._ScriptStructPtr != 0) ? FRigUnit_MathIntUnaryOp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathIntUnaryOp", ref FRigUnit_MathIntUnaryOp._ScriptStructPtr);
		}

		// Token: 0x1700145F RID: 5215
		// (get) Token: 0x06005474 RID: 21620 RVA: 0x0007AD60 File Offset: 0x00078F60
		// (set) Token: 0x06005475 RID: 21621 RVA: 0x0007AD70 File Offset: 0x00078F70
		public unsafe int Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathIntUnaryOp.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathIntUnaryOp.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17001460 RID: 5216
		// (get) Token: 0x06005476 RID: 21622 RVA: 0x0007AD81 File Offset: 0x00078F81
		// (set) Token: 0x06005477 RID: 21623 RVA: 0x0007AD91 File Offset: 0x00078F91
		public unsafe int Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathIntUnaryOp.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathIntUnaryOp.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x06005478 RID: 21624 RVA: 0x0007ADA2 File Offset: 0x00078FA2
		public FRigUnit_MathIntUnaryOp()
		{
		}

		// Token: 0x06005479 RID: 21625 RVA: 0x0007ADAA File Offset: 0x00078FAA
		public FRigUnit_MathIntUnaryOp(int Value, int Result)
		{
			this.Value = Value;
			this.Result = Result;
		}

		// Token: 0x0600547A RID: 21626 RVA: 0x0007ADC0 File Offset: 0x00078FC0
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathIntUnaryOp.StaticStruct();
		}

		// Token: 0x0600547B RID: 21627 RVA: 0x0007ADCC File Offset: 0x00078FCC
		[NullableContext(2)]
		public FRigUnit_MathIntUnaryOp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600547C RID: 21628 RVA: 0x0007ADD6 File Offset: 0x00078FD6
		public FRigUnit_MathIntUnaryOp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600547D RID: 21629 RVA: 0x0007ADE1 File Offset: 0x00078FE1
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathIntUnaryOp(Pointer, false, true);
		}

		// Token: 0x0600547E RID: 21630 RVA: 0x0007ADEB File Offset: 0x00078FEB
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathIntUnaryOp(Pointer, MemoryOwner);
		}

		// Token: 0x04002821 RID: 10273
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathIntUnaryOp";

		// Token: 0x04002822 RID: 10274
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002823 RID: 10275
		internal static int __PropertyOffset_Value;

		// Token: 0x04002824 RID: 10276
		internal static int __PropertyOffset_Result;
	}
}
