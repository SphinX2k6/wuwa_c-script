using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000622 RID: 1570
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathIntLessEqual")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_MathIntLessEqual : FRigUnit_MathIntBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600540B RID: 21515 RVA: 0x0007A6EA File Offset: 0x000788EA
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathIntLessEqual._ScriptStructPtr != 0) ? FRigUnit_MathIntLessEqual._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathIntLessEqual", ref FRigUnit_MathIntLessEqual._ScriptStructPtr);
		}

		// Token: 0x17001457 RID: 5207
		// (get) Token: 0x0600540C RID: 21516 RVA: 0x0007A70E File Offset: 0x0007890E
		// (set) Token: 0x0600540D RID: 21517 RVA: 0x0007A71E File Offset: 0x0007891E
		public unsafe int A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathIntLessEqual.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathIntLessEqual.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x17001458 RID: 5208
		// (get) Token: 0x0600540E RID: 21518 RVA: 0x0007A72F File Offset: 0x0007892F
		// (set) Token: 0x0600540F RID: 21519 RVA: 0x0007A73F File Offset: 0x0007893F
		public unsafe int B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathIntLessEqual.__PropertyOffset_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathIntLessEqual.__PropertyOffset_B) = value;
			}
		}

		// Token: 0x17001459 RID: 5209
		// (get) Token: 0x06005410 RID: 21520 RVA: 0x0007A750 File Offset: 0x00078950
		// (set) Token: 0x06005411 RID: 21521 RVA: 0x0007A760 File Offset: 0x00078960
		public unsafe bool Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathIntLessEqual.__PropertyOffset_Result) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathIntLessEqual.__PropertyOffset_Result) = (value ? 1 : 0);
			}
		}

		// Token: 0x06005412 RID: 21522 RVA: 0x0007A771 File Offset: 0x00078971
		public FRigUnit_MathIntLessEqual()
		{
		}

		// Token: 0x06005413 RID: 21523 RVA: 0x0007A779 File Offset: 0x00078979
		public FRigUnit_MathIntLessEqual(int A, int B, bool Result)
		{
			this.A = A;
			this.B = B;
			this.Result = Result;
		}

		// Token: 0x06005414 RID: 21524 RVA: 0x0007A796 File Offset: 0x00078996
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathIntLessEqual.StaticStruct();
		}

		// Token: 0x06005415 RID: 21525 RVA: 0x0007A7A2 File Offset: 0x000789A2
		[NullableContext(2)]
		public FRigUnit_MathIntLessEqual(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005416 RID: 21526 RVA: 0x0007A7AC File Offset: 0x000789AC
		public FRigUnit_MathIntLessEqual(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005417 RID: 21527 RVA: 0x0007A7B7 File Offset: 0x000789B7
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathIntLessEqual(Pointer, false, true);
		}

		// Token: 0x06005418 RID: 21528 RVA: 0x0007A7C1 File Offset: 0x000789C1
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathIntLessEqual(Pointer, MemoryOwner);
		}

		// Token: 0x04002803 RID: 10243
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathIntLessEqual";

		// Token: 0x04002804 RID: 10244
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002805 RID: 10245
		internal static int __PropertyOffset_A;

		// Token: 0x04002806 RID: 10246
		internal static int __PropertyOffset_B;

		// Token: 0x04002807 RID: 10247
		internal static int __PropertyOffset_Result;
	}
}
