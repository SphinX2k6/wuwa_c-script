using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200061F RID: 1567
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathIntGreater")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_MathIntGreater : FRigUnit_MathIntBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060053E1 RID: 21473 RVA: 0x0007A44A File Offset: 0x0007864A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathIntGreater._ScriptStructPtr != 0) ? FRigUnit_MathIntGreater._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathIntGreater", ref FRigUnit_MathIntGreater._ScriptStructPtr);
		}

		// Token: 0x1700144E RID: 5198
		// (get) Token: 0x060053E2 RID: 21474 RVA: 0x0007A46E File Offset: 0x0007866E
		// (set) Token: 0x060053E3 RID: 21475 RVA: 0x0007A47E File Offset: 0x0007867E
		public unsafe int A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathIntGreater.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathIntGreater.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x1700144F RID: 5199
		// (get) Token: 0x060053E4 RID: 21476 RVA: 0x0007A48F File Offset: 0x0007868F
		// (set) Token: 0x060053E5 RID: 21477 RVA: 0x0007A49F File Offset: 0x0007869F
		public unsafe int B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathIntGreater.__PropertyOffset_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathIntGreater.__PropertyOffset_B) = value;
			}
		}

		// Token: 0x17001450 RID: 5200
		// (get) Token: 0x060053E6 RID: 21478 RVA: 0x0007A4B0 File Offset: 0x000786B0
		// (set) Token: 0x060053E7 RID: 21479 RVA: 0x0007A4C0 File Offset: 0x000786C0
		public unsafe bool Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathIntGreater.__PropertyOffset_Result) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathIntGreater.__PropertyOffset_Result) = (value ? 1 : 0);
			}
		}

		// Token: 0x060053E8 RID: 21480 RVA: 0x0007A4D1 File Offset: 0x000786D1
		public FRigUnit_MathIntGreater()
		{
		}

		// Token: 0x060053E9 RID: 21481 RVA: 0x0007A4D9 File Offset: 0x000786D9
		public FRigUnit_MathIntGreater(int A, int B, bool Result)
		{
			this.A = A;
			this.B = B;
			this.Result = Result;
		}

		// Token: 0x060053EA RID: 21482 RVA: 0x0007A4F6 File Offset: 0x000786F6
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathIntGreater.StaticStruct();
		}

		// Token: 0x060053EB RID: 21483 RVA: 0x0007A502 File Offset: 0x00078702
		[NullableContext(2)]
		public FRigUnit_MathIntGreater(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060053EC RID: 21484 RVA: 0x0007A50C File Offset: 0x0007870C
		public FRigUnit_MathIntGreater(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060053ED RID: 21485 RVA: 0x0007A517 File Offset: 0x00078717
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathIntGreater(Pointer, false, true);
		}

		// Token: 0x060053EE RID: 21486 RVA: 0x0007A521 File Offset: 0x00078721
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathIntGreater(Pointer, MemoryOwner);
		}

		// Token: 0x040027F4 RID: 10228
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathIntGreater";

		// Token: 0x040027F5 RID: 10229
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040027F6 RID: 10230
		internal static int __PropertyOffset_A;

		// Token: 0x040027F7 RID: 10231
		internal static int __PropertyOffset_B;

		// Token: 0x040027F8 RID: 10232
		internal static int __PropertyOffset_Result;
	}
}
