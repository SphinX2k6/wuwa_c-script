using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000631 RID: 1585
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathQuaternionEquals")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FRigUnit_MathQuaternionEquals : FRigUnit_MathQuaternionBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060054A2 RID: 21666 RVA: 0x0007B03C File Offset: 0x0007923C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathQuaternionEquals._ScriptStructPtr != 0) ? FRigUnit_MathQuaternionEquals._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathQuaternionEquals", ref FRigUnit_MathQuaternionEquals._ScriptStructPtr);
		}

		// Token: 0x17001467 RID: 5223
		// (get) Token: 0x060054A3 RID: 21667 RVA: 0x0007B060 File Offset: 0x00079260
		// (set) Token: 0x060054A4 RID: 21668 RVA: 0x0007B074 File Offset: 0x00079274
		public unsafe FQuat A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionEquals.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionEquals.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x17001468 RID: 5224
		// (get) Token: 0x060054A5 RID: 21669 RVA: 0x0007B089 File Offset: 0x00079289
		// (set) Token: 0x060054A6 RID: 21670 RVA: 0x0007B09D File Offset: 0x0007929D
		public unsafe FQuat B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionEquals.__PropertyOffset_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionEquals.__PropertyOffset_B) = value;
			}
		}

		// Token: 0x17001469 RID: 5225
		// (get) Token: 0x060054A7 RID: 21671 RVA: 0x0007B0B2 File Offset: 0x000792B2
		// (set) Token: 0x060054A8 RID: 21672 RVA: 0x0007B0C2 File Offset: 0x000792C2
		public unsafe bool Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionEquals.__PropertyOffset_Result) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionEquals.__PropertyOffset_Result) = (value ? 1 : 0);
			}
		}

		// Token: 0x060054A9 RID: 21673 RVA: 0x0007B0D3 File Offset: 0x000792D3
		public FRigUnit_MathQuaternionEquals()
		{
		}

		// Token: 0x060054AA RID: 21674 RVA: 0x0007B0DB File Offset: 0x000792DB
		public FRigUnit_MathQuaternionEquals(FQuat A, FQuat B, bool Result)
		{
			this.A = A;
			this.B = B;
			this.Result = Result;
		}

		// Token: 0x060054AB RID: 21675 RVA: 0x0007B0F8 File Offset: 0x000792F8
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathQuaternionEquals.StaticStruct();
		}

		// Token: 0x060054AC RID: 21676 RVA: 0x0007B104 File Offset: 0x00079304
		[NullableContext(2)]
		public FRigUnit_MathQuaternionEquals(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060054AD RID: 21677 RVA: 0x0007B10E File Offset: 0x0007930E
		public FRigUnit_MathQuaternionEquals(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060054AE RID: 21678 RVA: 0x0007B119 File Offset: 0x00079319
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathQuaternionEquals(Pointer, false, true);
		}

		// Token: 0x060054AF RID: 21679 RVA: 0x0007B123 File Offset: 0x00079323
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathQuaternionEquals(Pointer, MemoryOwner);
		}

		// Token: 0x04002831 RID: 10289
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathQuaternionEquals";

		// Token: 0x04002832 RID: 10290
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002833 RID: 10291
		internal static int __PropertyOffset_A;

		// Token: 0x04002834 RID: 10292
		internal static int __PropertyOffset_B;

		// Token: 0x04002835 RID: 10293
		internal static int __PropertyOffset_Result;
	}
}
