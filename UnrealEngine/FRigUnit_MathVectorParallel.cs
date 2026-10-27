using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000683 RID: 1667
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathVectorParallel")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FRigUnit_MathVectorParallel : FRigUnit_MathVectorBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060058A9 RID: 22697 RVA: 0x0007FAA9 File Offset: 0x0007DCA9
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathVectorParallel._ScriptStructPtr != 0) ? FRigUnit_MathVectorParallel._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathVectorParallel", ref FRigUnit_MathVectorParallel._ScriptStructPtr);
		}

		// Token: 0x17001525 RID: 5413
		// (get) Token: 0x060058AA RID: 22698 RVA: 0x0007FACD File Offset: 0x0007DCCD
		// (set) Token: 0x060058AB RID: 22699 RVA: 0x0007FAE1 File Offset: 0x0007DCE1
		public unsafe FVector A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorParallel.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorParallel.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x17001526 RID: 5414
		// (get) Token: 0x060058AC RID: 22700 RVA: 0x0007FAF6 File Offset: 0x0007DCF6
		// (set) Token: 0x060058AD RID: 22701 RVA: 0x0007FB0A File Offset: 0x0007DD0A
		public unsafe FVector B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorParallel.__PropertyOffset_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorParallel.__PropertyOffset_B) = value;
			}
		}

		// Token: 0x17001527 RID: 5415
		// (get) Token: 0x060058AE RID: 22702 RVA: 0x0007FB1F File Offset: 0x0007DD1F
		// (set) Token: 0x060058AF RID: 22703 RVA: 0x0007FB2F File Offset: 0x0007DD2F
		public unsafe bool Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorParallel.__PropertyOffset_Result) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorParallel.__PropertyOffset_Result) = (value ? 1 : 0);
			}
		}

		// Token: 0x060058B0 RID: 22704 RVA: 0x0007FB40 File Offset: 0x0007DD40
		public FRigUnit_MathVectorParallel()
		{
		}

		// Token: 0x060058B1 RID: 22705 RVA: 0x0007FB48 File Offset: 0x0007DD48
		public FRigUnit_MathVectorParallel(FVector A, FVector B, bool Result)
		{
			this.A = A;
			this.B = B;
			this.Result = Result;
		}

		// Token: 0x060058B2 RID: 22706 RVA: 0x0007FB65 File Offset: 0x0007DD65
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathVectorParallel.StaticStruct();
		}

		// Token: 0x060058B3 RID: 22707 RVA: 0x0007FB71 File Offset: 0x0007DD71
		[NullableContext(2)]
		public FRigUnit_MathVectorParallel(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060058B4 RID: 22708 RVA: 0x0007FB7B File Offset: 0x0007DD7B
		public FRigUnit_MathVectorParallel(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060058B5 RID: 22709 RVA: 0x0007FB86 File Offset: 0x0007DD86
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathVectorParallel(Pointer, false, true);
		}

		// Token: 0x060058B6 RID: 22710 RVA: 0x0007FB90 File Offset: 0x0007DD90
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathVectorParallel(Pointer, MemoryOwner);
		}

		// Token: 0x040029A4 RID: 10660
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathVectorParallel";

		// Token: 0x040029A5 RID: 10661
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040029A6 RID: 10662
		internal static int __PropertyOffset_A;

		// Token: 0x040029A7 RID: 10663
		internal static int __PropertyOffset_B;

		// Token: 0x040029A8 RID: 10664
		internal static int __PropertyOffset_Result;
	}
}
