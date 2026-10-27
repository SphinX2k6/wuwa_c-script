using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000596 RID: 1430
	[UnrealObjectPath("/Script/ControlRig.RigUnit_DeltaFromPreviousTransform")]
	[UnrealStructLayout(208, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 208)]
	public class FRigUnit_DeltaFromPreviousTransform : FRigUnit_SimBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004CB1 RID: 19633 RVA: 0x000716BA File Offset: 0x0006F8BA
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_DeltaFromPreviousTransform._ScriptStructPtr != 0) ? FRigUnit_DeltaFromPreviousTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_DeltaFromPreviousTransform", ref FRigUnit_DeltaFromPreviousTransform._ScriptStructPtr);
		}

		// Token: 0x170012D6 RID: 4822
		// (get) Token: 0x06004CB2 RID: 19634 RVA: 0x000716DE File Offset: 0x0006F8DE
		// (set) Token: 0x06004CB3 RID: 19635 RVA: 0x000716F2 File Offset: 0x0006F8F2
		public unsafe FTransform Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DeltaFromPreviousTransform.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DeltaFromPreviousTransform.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x170012D7 RID: 4823
		// (get) Token: 0x06004CB4 RID: 19636 RVA: 0x00071707 File Offset: 0x0006F907
		// (set) Token: 0x06004CB5 RID: 19637 RVA: 0x0007171B File Offset: 0x0006F91B
		public unsafe FTransform Delta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DeltaFromPreviousTransform.__PropertyOffset_Delta);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DeltaFromPreviousTransform.__PropertyOffset_Delta) = value;
			}
		}

		// Token: 0x170012D8 RID: 4824
		// (get) Token: 0x06004CB6 RID: 19638 RVA: 0x00071730 File Offset: 0x0006F930
		// (set) Token: 0x06004CB7 RID: 19639 RVA: 0x00071744 File Offset: 0x0006F944
		public unsafe FTransform PreviousValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DeltaFromPreviousTransform.__PropertyOffset_PreviousValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DeltaFromPreviousTransform.__PropertyOffset_PreviousValue) = value;
			}
		}

		// Token: 0x170012D9 RID: 4825
		// (get) Token: 0x06004CB8 RID: 19640 RVA: 0x00071759 File Offset: 0x0006F959
		// (set) Token: 0x06004CB9 RID: 19641 RVA: 0x0007176D File Offset: 0x0006F96D
		public unsafe FTransform Cache
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DeltaFromPreviousTransform.__PropertyOffset_Cache);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DeltaFromPreviousTransform.__PropertyOffset_Cache) = value;
			}
		}

		// Token: 0x06004CBA RID: 19642 RVA: 0x00071782 File Offset: 0x0006F982
		public FRigUnit_DeltaFromPreviousTransform()
		{
		}

		// Token: 0x06004CBB RID: 19643 RVA: 0x0007178A File Offset: 0x0006F98A
		public FRigUnit_DeltaFromPreviousTransform(FTransform Value, FTransform Delta, FTransform PreviousValue, FTransform Cache)
		{
			this.Value = Value;
			this.Delta = Delta;
			this.PreviousValue = PreviousValue;
			this.Cache = Cache;
		}

		// Token: 0x06004CBC RID: 19644 RVA: 0x000717AF File Offset: 0x0006F9AF
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_DeltaFromPreviousTransform.StaticStruct();
		}

		// Token: 0x06004CBD RID: 19645 RVA: 0x000717BB File Offset: 0x0006F9BB
		[NullableContext(2)]
		public FRigUnit_DeltaFromPreviousTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004CBE RID: 19646 RVA: 0x000717C5 File Offset: 0x0006F9C5
		public FRigUnit_DeltaFromPreviousTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004CBF RID: 19647 RVA: 0x000717D0 File Offset: 0x0006F9D0
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_DeltaFromPreviousTransform(Pointer, false, true);
		}

		// Token: 0x06004CC0 RID: 19648 RVA: 0x000717DA File Offset: 0x0006F9DA
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_DeltaFromPreviousTransform(Pointer, MemoryOwner);
		}

		// Token: 0x04002517 RID: 9495
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_DeltaFromPreviousTransform";

		// Token: 0x04002518 RID: 9496
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002519 RID: 9497
		internal static int __PropertyOffset_Value;

		// Token: 0x0400251A RID: 9498
		internal static int __PropertyOffset_Delta;

		// Token: 0x0400251B RID: 9499
		internal static int __PropertyOffset_PreviousValue;

		// Token: 0x0400251C RID: 9500
		internal static int __PropertyOffset_Cache;
	}
}
