using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000682 RID: 1666
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathVectorOrthogonal")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FRigUnit_MathVectorOrthogonal : FRigUnit_MathVectorBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600589B RID: 22683 RVA: 0x0007F9B9 File Offset: 0x0007DBB9
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathVectorOrthogonal._ScriptStructPtr != 0) ? FRigUnit_MathVectorOrthogonal._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathVectorOrthogonal", ref FRigUnit_MathVectorOrthogonal._ScriptStructPtr);
		}

		// Token: 0x17001522 RID: 5410
		// (get) Token: 0x0600589C RID: 22684 RVA: 0x0007F9DD File Offset: 0x0007DBDD
		// (set) Token: 0x0600589D RID: 22685 RVA: 0x0007F9F1 File Offset: 0x0007DBF1
		public unsafe FVector A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorOrthogonal.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorOrthogonal.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x17001523 RID: 5411
		// (get) Token: 0x0600589E RID: 22686 RVA: 0x0007FA06 File Offset: 0x0007DC06
		// (set) Token: 0x0600589F RID: 22687 RVA: 0x0007FA1A File Offset: 0x0007DC1A
		public unsafe FVector B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorOrthogonal.__PropertyOffset_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorOrthogonal.__PropertyOffset_B) = value;
			}
		}

		// Token: 0x17001524 RID: 5412
		// (get) Token: 0x060058A0 RID: 22688 RVA: 0x0007FA2F File Offset: 0x0007DC2F
		// (set) Token: 0x060058A1 RID: 22689 RVA: 0x0007FA3F File Offset: 0x0007DC3F
		public unsafe bool Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorOrthogonal.__PropertyOffset_Result) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorOrthogonal.__PropertyOffset_Result) = (value ? 1 : 0);
			}
		}

		// Token: 0x060058A2 RID: 22690 RVA: 0x0007FA50 File Offset: 0x0007DC50
		public FRigUnit_MathVectorOrthogonal()
		{
		}

		// Token: 0x060058A3 RID: 22691 RVA: 0x0007FA58 File Offset: 0x0007DC58
		public FRigUnit_MathVectorOrthogonal(FVector A, FVector B, bool Result)
		{
			this.A = A;
			this.B = B;
			this.Result = Result;
		}

		// Token: 0x060058A4 RID: 22692 RVA: 0x0007FA75 File Offset: 0x0007DC75
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathVectorOrthogonal.StaticStruct();
		}

		// Token: 0x060058A5 RID: 22693 RVA: 0x0007FA81 File Offset: 0x0007DC81
		[NullableContext(2)]
		public FRigUnit_MathVectorOrthogonal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060058A6 RID: 22694 RVA: 0x0007FA8B File Offset: 0x0007DC8B
		public FRigUnit_MathVectorOrthogonal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060058A7 RID: 22695 RVA: 0x0007FA96 File Offset: 0x0007DC96
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathVectorOrthogonal(Pointer, false, true);
		}

		// Token: 0x060058A8 RID: 22696 RVA: 0x0007FAA0 File Offset: 0x0007DCA0
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathVectorOrthogonal(Pointer, MemoryOwner);
		}

		// Token: 0x0400299F RID: 10655
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathVectorOrthogonal";

		// Token: 0x040029A0 RID: 10656
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040029A1 RID: 10657
		internal static int __PropertyOffset_A;

		// Token: 0x040029A2 RID: 10658
		internal static int __PropertyOffset_B;

		// Token: 0x040029A3 RID: 10659
		internal static int __PropertyOffset_Result;
	}
}
