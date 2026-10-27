using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000595 RID: 1429
	[UnrealObjectPath("/Script/ControlRig.RigUnit_DeltaFromPreviousQuat")]
	[UnrealStructLayout(80, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FRigUnit_DeltaFromPreviousQuat : FRigUnit_SimBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004CA1 RID: 19617 RVA: 0x00071591 File Offset: 0x0006F791
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_DeltaFromPreviousQuat._ScriptStructPtr != 0) ? FRigUnit_DeltaFromPreviousQuat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_DeltaFromPreviousQuat", ref FRigUnit_DeltaFromPreviousQuat._ScriptStructPtr);
		}

		// Token: 0x170012D2 RID: 4818
		// (get) Token: 0x06004CA2 RID: 19618 RVA: 0x000715B5 File Offset: 0x0006F7B5
		// (set) Token: 0x06004CA3 RID: 19619 RVA: 0x000715C9 File Offset: 0x0006F7C9
		public unsafe FQuat Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DeltaFromPreviousQuat.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DeltaFromPreviousQuat.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x170012D3 RID: 4819
		// (get) Token: 0x06004CA4 RID: 19620 RVA: 0x000715DE File Offset: 0x0006F7DE
		// (set) Token: 0x06004CA5 RID: 19621 RVA: 0x000715F2 File Offset: 0x0006F7F2
		public unsafe FQuat Delta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DeltaFromPreviousQuat.__PropertyOffset_Delta);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DeltaFromPreviousQuat.__PropertyOffset_Delta) = value;
			}
		}

		// Token: 0x170012D4 RID: 4820
		// (get) Token: 0x06004CA6 RID: 19622 RVA: 0x00071607 File Offset: 0x0006F807
		// (set) Token: 0x06004CA7 RID: 19623 RVA: 0x0007161B File Offset: 0x0006F81B
		public unsafe FQuat PreviousValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DeltaFromPreviousQuat.__PropertyOffset_PreviousValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DeltaFromPreviousQuat.__PropertyOffset_PreviousValue) = value;
			}
		}

		// Token: 0x170012D5 RID: 4821
		// (get) Token: 0x06004CA8 RID: 19624 RVA: 0x00071630 File Offset: 0x0006F830
		// (set) Token: 0x06004CA9 RID: 19625 RVA: 0x00071644 File Offset: 0x0006F844
		public unsafe FQuat Cache
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DeltaFromPreviousQuat.__PropertyOffset_Cache);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DeltaFromPreviousQuat.__PropertyOffset_Cache) = value;
			}
		}

		// Token: 0x06004CAA RID: 19626 RVA: 0x00071659 File Offset: 0x0006F859
		public FRigUnit_DeltaFromPreviousQuat()
		{
		}

		// Token: 0x06004CAB RID: 19627 RVA: 0x00071661 File Offset: 0x0006F861
		public FRigUnit_DeltaFromPreviousQuat(FQuat Value, FQuat Delta, FQuat PreviousValue, FQuat Cache)
		{
			this.Value = Value;
			this.Delta = Delta;
			this.PreviousValue = PreviousValue;
			this.Cache = Cache;
		}

		// Token: 0x06004CAC RID: 19628 RVA: 0x00071686 File Offset: 0x0006F886
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_DeltaFromPreviousQuat.StaticStruct();
		}

		// Token: 0x06004CAD RID: 19629 RVA: 0x00071692 File Offset: 0x0006F892
		[NullableContext(2)]
		public FRigUnit_DeltaFromPreviousQuat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004CAE RID: 19630 RVA: 0x0007169C File Offset: 0x0006F89C
		public FRigUnit_DeltaFromPreviousQuat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004CAF RID: 19631 RVA: 0x000716A7 File Offset: 0x0006F8A7
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_DeltaFromPreviousQuat(Pointer, false, true);
		}

		// Token: 0x06004CB0 RID: 19632 RVA: 0x000716B1 File Offset: 0x0006F8B1
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_DeltaFromPreviousQuat(Pointer, MemoryOwner);
		}

		// Token: 0x04002511 RID: 9489
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_DeltaFromPreviousQuat";

		// Token: 0x04002512 RID: 9490
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002513 RID: 9491
		internal static int __PropertyOffset_Value;

		// Token: 0x04002514 RID: 9492
		internal static int __PropertyOffset_Delta;

		// Token: 0x04002515 RID: 9493
		internal static int __PropertyOffset_PreviousValue;

		// Token: 0x04002516 RID: 9494
		internal static int __PropertyOffset_Cache;
	}
}
