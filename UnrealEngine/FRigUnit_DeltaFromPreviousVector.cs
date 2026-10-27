using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000597 RID: 1431
	[UnrealObjectPath("/Script/ControlRig.RigUnit_DeltaFromPreviousVector")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FRigUnit_DeltaFromPreviousVector : FRigUnit_SimBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004CC1 RID: 19649 RVA: 0x000717E3 File Offset: 0x0006F9E3
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_DeltaFromPreviousVector._ScriptStructPtr != 0) ? FRigUnit_DeltaFromPreviousVector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_DeltaFromPreviousVector", ref FRigUnit_DeltaFromPreviousVector._ScriptStructPtr);
		}

		// Token: 0x170012DA RID: 4826
		// (get) Token: 0x06004CC2 RID: 19650 RVA: 0x00071807 File Offset: 0x0006FA07
		// (set) Token: 0x06004CC3 RID: 19651 RVA: 0x0007181B File Offset: 0x0006FA1B
		public unsafe FVector Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DeltaFromPreviousVector.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DeltaFromPreviousVector.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x170012DB RID: 4827
		// (get) Token: 0x06004CC4 RID: 19652 RVA: 0x00071830 File Offset: 0x0006FA30
		// (set) Token: 0x06004CC5 RID: 19653 RVA: 0x00071844 File Offset: 0x0006FA44
		public unsafe FVector Delta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DeltaFromPreviousVector.__PropertyOffset_Delta);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DeltaFromPreviousVector.__PropertyOffset_Delta) = value;
			}
		}

		// Token: 0x170012DC RID: 4828
		// (get) Token: 0x06004CC6 RID: 19654 RVA: 0x00071859 File Offset: 0x0006FA59
		// (set) Token: 0x06004CC7 RID: 19655 RVA: 0x0007186D File Offset: 0x0006FA6D
		public unsafe FVector PreviousValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DeltaFromPreviousVector.__PropertyOffset_PreviousValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DeltaFromPreviousVector.__PropertyOffset_PreviousValue) = value;
			}
		}

		// Token: 0x170012DD RID: 4829
		// (get) Token: 0x06004CC8 RID: 19656 RVA: 0x00071882 File Offset: 0x0006FA82
		// (set) Token: 0x06004CC9 RID: 19657 RVA: 0x00071896 File Offset: 0x0006FA96
		public unsafe FVector Cache
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DeltaFromPreviousVector.__PropertyOffset_Cache);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DeltaFromPreviousVector.__PropertyOffset_Cache) = value;
			}
		}

		// Token: 0x06004CCA RID: 19658 RVA: 0x000718AB File Offset: 0x0006FAAB
		public FRigUnit_DeltaFromPreviousVector()
		{
		}

		// Token: 0x06004CCB RID: 19659 RVA: 0x000718B3 File Offset: 0x0006FAB3
		public FRigUnit_DeltaFromPreviousVector(FVector Value, FVector Delta, FVector PreviousValue, FVector Cache)
		{
			this.Value = Value;
			this.Delta = Delta;
			this.PreviousValue = PreviousValue;
			this.Cache = Cache;
		}

		// Token: 0x06004CCC RID: 19660 RVA: 0x000718D8 File Offset: 0x0006FAD8
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_DeltaFromPreviousVector.StaticStruct();
		}

		// Token: 0x06004CCD RID: 19661 RVA: 0x000718E4 File Offset: 0x0006FAE4
		[NullableContext(2)]
		public FRigUnit_DeltaFromPreviousVector(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004CCE RID: 19662 RVA: 0x000718EE File Offset: 0x0006FAEE
		public FRigUnit_DeltaFromPreviousVector(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004CCF RID: 19663 RVA: 0x000718F9 File Offset: 0x0006FAF9
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_DeltaFromPreviousVector(Pointer, false, true);
		}

		// Token: 0x06004CD0 RID: 19664 RVA: 0x00071903 File Offset: 0x0006FB03
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_DeltaFromPreviousVector(Pointer, MemoryOwner);
		}

		// Token: 0x0400251D RID: 9501
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_DeltaFromPreviousVector";

		// Token: 0x0400251E RID: 9502
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400251F RID: 9503
		internal static int __PropertyOffset_Value;

		// Token: 0x04002520 RID: 9504
		internal static int __PropertyOffset_Delta;

		// Token: 0x04002521 RID: 9505
		internal static int __PropertyOffset_PreviousValue;

		// Token: 0x04002522 RID: 9506
		internal static int __PropertyOffset_Cache;
	}
}
