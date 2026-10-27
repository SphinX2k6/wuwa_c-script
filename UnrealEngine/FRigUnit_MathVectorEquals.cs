using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000672 RID: 1650
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathVectorEquals")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FRigUnit_MathVectorEquals : FRigUnit_MathVectorBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060057E5 RID: 22501 RVA: 0x0007EDCC File Offset: 0x0007CFCC
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathVectorEquals._ScriptStructPtr != 0) ? FRigUnit_MathVectorEquals._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathVectorEquals", ref FRigUnit_MathVectorEquals._ScriptStructPtr);
		}

		// Token: 0x17001507 RID: 5383
		// (get) Token: 0x060057E6 RID: 22502 RVA: 0x0007EDF0 File Offset: 0x0007CFF0
		// (set) Token: 0x060057E7 RID: 22503 RVA: 0x0007EE04 File Offset: 0x0007D004
		public unsafe FVector A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorEquals.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorEquals.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x17001508 RID: 5384
		// (get) Token: 0x060057E8 RID: 22504 RVA: 0x0007EE19 File Offset: 0x0007D019
		// (set) Token: 0x060057E9 RID: 22505 RVA: 0x0007EE2D File Offset: 0x0007D02D
		public unsafe FVector B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorEquals.__PropertyOffset_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorEquals.__PropertyOffset_B) = value;
			}
		}

		// Token: 0x17001509 RID: 5385
		// (get) Token: 0x060057EA RID: 22506 RVA: 0x0007EE42 File Offset: 0x0007D042
		// (set) Token: 0x060057EB RID: 22507 RVA: 0x0007EE52 File Offset: 0x0007D052
		public unsafe bool Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorEquals.__PropertyOffset_Result) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorEquals.__PropertyOffset_Result) = (value ? 1 : 0);
			}
		}

		// Token: 0x060057EC RID: 22508 RVA: 0x0007EE63 File Offset: 0x0007D063
		public FRigUnit_MathVectorEquals()
		{
		}

		// Token: 0x060057ED RID: 22509 RVA: 0x0007EE6B File Offset: 0x0007D06B
		public FRigUnit_MathVectorEquals(FVector A, FVector B, bool Result)
		{
			this.A = A;
			this.B = B;
			this.Result = Result;
		}

		// Token: 0x060057EE RID: 22510 RVA: 0x0007EE88 File Offset: 0x0007D088
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathVectorEquals.StaticStruct();
		}

		// Token: 0x060057EF RID: 22511 RVA: 0x0007EE94 File Offset: 0x0007D094
		[NullableContext(2)]
		public FRigUnit_MathVectorEquals(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060057F0 RID: 22512 RVA: 0x0007EE9E File Offset: 0x0007D09E
		public FRigUnit_MathVectorEquals(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060057F1 RID: 22513 RVA: 0x0007EEA9 File Offset: 0x0007D0A9
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathVectorEquals(Pointer, false, true);
		}

		// Token: 0x060057F2 RID: 22514 RVA: 0x0007EEB3 File Offset: 0x0007D0B3
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathVectorEquals(Pointer, MemoryOwner);
		}

		// Token: 0x04002963 RID: 10595
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathVectorEquals";

		// Token: 0x04002964 RID: 10596
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002965 RID: 10597
		internal static int __PropertyOffset_A;

		// Token: 0x04002966 RID: 10598
		internal static int __PropertyOffset_B;

		// Token: 0x04002967 RID: 10599
		internal static int __PropertyOffset_Result;
	}
}
