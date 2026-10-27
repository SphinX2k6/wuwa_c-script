using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200061D RID: 1565
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathIntEquals")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_MathIntEquals : FRigUnit_MathIntBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060053BF RID: 21439 RVA: 0x0007A1E7 File Offset: 0x000783E7
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathIntEquals._ScriptStructPtr != 0) ? FRigUnit_MathIntEquals._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathIntEquals", ref FRigUnit_MathIntEquals._ScriptStructPtr);
		}

		// Token: 0x17001445 RID: 5189
		// (get) Token: 0x060053C0 RID: 21440 RVA: 0x0007A20B File Offset: 0x0007840B
		// (set) Token: 0x060053C1 RID: 21441 RVA: 0x0007A21B File Offset: 0x0007841B
		public unsafe int A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathIntEquals.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathIntEquals.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x17001446 RID: 5190
		// (get) Token: 0x060053C2 RID: 21442 RVA: 0x0007A22C File Offset: 0x0007842C
		// (set) Token: 0x060053C3 RID: 21443 RVA: 0x0007A23C File Offset: 0x0007843C
		public unsafe int B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathIntEquals.__PropertyOffset_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathIntEquals.__PropertyOffset_B) = value;
			}
		}

		// Token: 0x17001447 RID: 5191
		// (get) Token: 0x060053C4 RID: 21444 RVA: 0x0007A24D File Offset: 0x0007844D
		// (set) Token: 0x060053C5 RID: 21445 RVA: 0x0007A25D File Offset: 0x0007845D
		public unsafe bool Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathIntEquals.__PropertyOffset_Result) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathIntEquals.__PropertyOffset_Result) = (value ? 1 : 0);
			}
		}

		// Token: 0x060053C6 RID: 21446 RVA: 0x0007A26E File Offset: 0x0007846E
		public FRigUnit_MathIntEquals()
		{
		}

		// Token: 0x060053C7 RID: 21447 RVA: 0x0007A276 File Offset: 0x00078476
		public FRigUnit_MathIntEquals(int A, int B, bool Result)
		{
			this.A = A;
			this.B = B;
			this.Result = Result;
		}

		// Token: 0x060053C8 RID: 21448 RVA: 0x0007A293 File Offset: 0x00078493
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathIntEquals.StaticStruct();
		}

		// Token: 0x060053C9 RID: 21449 RVA: 0x0007A29F File Offset: 0x0007849F
		[NullableContext(2)]
		public FRigUnit_MathIntEquals(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060053CA RID: 21450 RVA: 0x0007A2A9 File Offset: 0x000784A9
		public FRigUnit_MathIntEquals(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060053CB RID: 21451 RVA: 0x0007A2B4 File Offset: 0x000784B4
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathIntEquals(Pointer, false, true);
		}

		// Token: 0x060053CC RID: 21452 RVA: 0x0007A2BE File Offset: 0x000784BE
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathIntEquals(Pointer, MemoryOwner);
		}

		// Token: 0x040027E7 RID: 10215
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathIntEquals";

		// Token: 0x040027E8 RID: 10216
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040027E9 RID: 10217
		internal static int __PropertyOffset_A;

		// Token: 0x040027EA RID: 10218
		internal static int __PropertyOffset_B;

		// Token: 0x040027EB RID: 10219
		internal static int __PropertyOffset_Result;
	}
}
