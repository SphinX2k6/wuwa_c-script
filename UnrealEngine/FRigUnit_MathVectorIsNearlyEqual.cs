using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000675 RID: 1653
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathVectorIsNearlyEqual")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FRigUnit_MathVectorIsNearlyEqual : FRigUnit_MathVectorBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005807 RID: 22535 RVA: 0x0007EFF2 File Offset: 0x0007D1F2
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathVectorIsNearlyEqual._ScriptStructPtr != 0) ? FRigUnit_MathVectorIsNearlyEqual._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathVectorIsNearlyEqual", ref FRigUnit_MathVectorIsNearlyEqual._ScriptStructPtr);
		}

		// Token: 0x1700150C RID: 5388
		// (get) Token: 0x06005808 RID: 22536 RVA: 0x0007F016 File Offset: 0x0007D216
		// (set) Token: 0x06005809 RID: 22537 RVA: 0x0007F02A File Offset: 0x0007D22A
		public unsafe FVector A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorIsNearlyEqual.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorIsNearlyEqual.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x1700150D RID: 5389
		// (get) Token: 0x0600580A RID: 22538 RVA: 0x0007F03F File Offset: 0x0007D23F
		// (set) Token: 0x0600580B RID: 22539 RVA: 0x0007F053 File Offset: 0x0007D253
		public unsafe FVector B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorIsNearlyEqual.__PropertyOffset_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorIsNearlyEqual.__PropertyOffset_B) = value;
			}
		}

		// Token: 0x1700150E RID: 5390
		// (get) Token: 0x0600580C RID: 22540 RVA: 0x0007F068 File Offset: 0x0007D268
		// (set) Token: 0x0600580D RID: 22541 RVA: 0x0007F078 File Offset: 0x0007D278
		public unsafe float Tolerance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorIsNearlyEqual.__PropertyOffset_Tolerance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorIsNearlyEqual.__PropertyOffset_Tolerance) = value;
			}
		}

		// Token: 0x1700150F RID: 5391
		// (get) Token: 0x0600580E RID: 22542 RVA: 0x0007F089 File Offset: 0x0007D289
		// (set) Token: 0x0600580F RID: 22543 RVA: 0x0007F099 File Offset: 0x0007D299
		public unsafe bool Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorIsNearlyEqual.__PropertyOffset_Result) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorIsNearlyEqual.__PropertyOffset_Result) = (value ? 1 : 0);
			}
		}

		// Token: 0x06005810 RID: 22544 RVA: 0x0007F0AA File Offset: 0x0007D2AA
		public FRigUnit_MathVectorIsNearlyEqual()
		{
		}

		// Token: 0x06005811 RID: 22545 RVA: 0x0007F0B2 File Offset: 0x0007D2B2
		public FRigUnit_MathVectorIsNearlyEqual(FVector A, FVector B, float Tolerance, bool Result)
		{
			this.A = A;
			this.B = B;
			this.Tolerance = Tolerance;
			this.Result = Result;
		}

		// Token: 0x06005812 RID: 22546 RVA: 0x0007F0D7 File Offset: 0x0007D2D7
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathVectorIsNearlyEqual.StaticStruct();
		}

		// Token: 0x06005813 RID: 22547 RVA: 0x0007F0E3 File Offset: 0x0007D2E3
		[NullableContext(2)]
		public FRigUnit_MathVectorIsNearlyEqual(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005814 RID: 22548 RVA: 0x0007F0ED File Offset: 0x0007D2ED
		public FRigUnit_MathVectorIsNearlyEqual(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005815 RID: 22549 RVA: 0x0007F0F8 File Offset: 0x0007D2F8
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathVectorIsNearlyEqual(Pointer, false, true);
		}

		// Token: 0x06005816 RID: 22550 RVA: 0x0007F102 File Offset: 0x0007D302
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathVectorIsNearlyEqual(Pointer, MemoryOwner);
		}

		// Token: 0x0400296E RID: 10606
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathVectorIsNearlyEqual";

		// Token: 0x0400296F RID: 10607
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002970 RID: 10608
		internal static int __PropertyOffset_A;

		// Token: 0x04002971 RID: 10609
		internal static int __PropertyOffset_B;

		// Token: 0x04002972 RID: 10610
		internal static int __PropertyOffset_Tolerance;

		// Token: 0x04002973 RID: 10611
		internal static int __PropertyOffset_Result;
	}
}
