using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000620 RID: 1568
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathIntGreaterEqual")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_MathIntGreaterEqual : FRigUnit_MathIntBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060053EF RID: 21487 RVA: 0x0007A52A File Offset: 0x0007872A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathIntGreaterEqual._ScriptStructPtr != 0) ? FRigUnit_MathIntGreaterEqual._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathIntGreaterEqual", ref FRigUnit_MathIntGreaterEqual._ScriptStructPtr);
		}

		// Token: 0x17001451 RID: 5201
		// (get) Token: 0x060053F0 RID: 21488 RVA: 0x0007A54E File Offset: 0x0007874E
		// (set) Token: 0x060053F1 RID: 21489 RVA: 0x0007A55E File Offset: 0x0007875E
		public unsafe int A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathIntGreaterEqual.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathIntGreaterEqual.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x17001452 RID: 5202
		// (get) Token: 0x060053F2 RID: 21490 RVA: 0x0007A56F File Offset: 0x0007876F
		// (set) Token: 0x060053F3 RID: 21491 RVA: 0x0007A57F File Offset: 0x0007877F
		public unsafe int B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathIntGreaterEqual.__PropertyOffset_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathIntGreaterEqual.__PropertyOffset_B) = value;
			}
		}

		// Token: 0x17001453 RID: 5203
		// (get) Token: 0x060053F4 RID: 21492 RVA: 0x0007A590 File Offset: 0x00078790
		// (set) Token: 0x060053F5 RID: 21493 RVA: 0x0007A5A0 File Offset: 0x000787A0
		public unsafe bool Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathIntGreaterEqual.__PropertyOffset_Result) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathIntGreaterEqual.__PropertyOffset_Result) = (value ? 1 : 0);
			}
		}

		// Token: 0x060053F6 RID: 21494 RVA: 0x0007A5B1 File Offset: 0x000787B1
		public FRigUnit_MathIntGreaterEqual()
		{
		}

		// Token: 0x060053F7 RID: 21495 RVA: 0x0007A5B9 File Offset: 0x000787B9
		public FRigUnit_MathIntGreaterEqual(int A, int B, bool Result)
		{
			this.A = A;
			this.B = B;
			this.Result = Result;
		}

		// Token: 0x060053F8 RID: 21496 RVA: 0x0007A5D6 File Offset: 0x000787D6
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathIntGreaterEqual.StaticStruct();
		}

		// Token: 0x060053F9 RID: 21497 RVA: 0x0007A5E2 File Offset: 0x000787E2
		[NullableContext(2)]
		public FRigUnit_MathIntGreaterEqual(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060053FA RID: 21498 RVA: 0x0007A5EC File Offset: 0x000787EC
		public FRigUnit_MathIntGreaterEqual(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060053FB RID: 21499 RVA: 0x0007A5F7 File Offset: 0x000787F7
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathIntGreaterEqual(Pointer, false, true);
		}

		// Token: 0x060053FC RID: 21500 RVA: 0x0007A601 File Offset: 0x00078801
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathIntGreaterEqual(Pointer, MemoryOwner);
		}

		// Token: 0x040027F9 RID: 10233
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathIntGreaterEqual";

		// Token: 0x040027FA RID: 10234
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040027FB RID: 10235
		internal static int __PropertyOffset_A;

		// Token: 0x040027FC RID: 10236
		internal static int __PropertyOffset_B;

		// Token: 0x040027FD RID: 10237
		internal static int __PropertyOffset_Result;
	}
}
