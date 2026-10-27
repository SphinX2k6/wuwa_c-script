using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000594 RID: 1428
	[UnrealObjectPath("/Script/ControlRig.RigUnit_DeltaFromPreviousFloat")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_DeltaFromPreviousFloat : FRigUnit_SimBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004C91 RID: 19601 RVA: 0x00071488 File Offset: 0x0006F688
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_DeltaFromPreviousFloat._ScriptStructPtr != 0) ? FRigUnit_DeltaFromPreviousFloat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_DeltaFromPreviousFloat", ref FRigUnit_DeltaFromPreviousFloat._ScriptStructPtr);
		}

		// Token: 0x170012CE RID: 4814
		// (get) Token: 0x06004C92 RID: 19602 RVA: 0x000714AC File Offset: 0x0006F6AC
		// (set) Token: 0x06004C93 RID: 19603 RVA: 0x000714BC File Offset: 0x0006F6BC
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DeltaFromPreviousFloat.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DeltaFromPreviousFloat.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x170012CF RID: 4815
		// (get) Token: 0x06004C94 RID: 19604 RVA: 0x000714CD File Offset: 0x0006F6CD
		// (set) Token: 0x06004C95 RID: 19605 RVA: 0x000714DD File Offset: 0x0006F6DD
		public unsafe float Delta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DeltaFromPreviousFloat.__PropertyOffset_Delta);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DeltaFromPreviousFloat.__PropertyOffset_Delta) = value;
			}
		}

		// Token: 0x170012D0 RID: 4816
		// (get) Token: 0x06004C96 RID: 19606 RVA: 0x000714EE File Offset: 0x0006F6EE
		// (set) Token: 0x06004C97 RID: 19607 RVA: 0x000714FE File Offset: 0x0006F6FE
		public unsafe float PreviousValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DeltaFromPreviousFloat.__PropertyOffset_PreviousValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DeltaFromPreviousFloat.__PropertyOffset_PreviousValue) = value;
			}
		}

		// Token: 0x170012D1 RID: 4817
		// (get) Token: 0x06004C98 RID: 19608 RVA: 0x0007150F File Offset: 0x0006F70F
		// (set) Token: 0x06004C99 RID: 19609 RVA: 0x0007151F File Offset: 0x0006F71F
		public unsafe float Cache
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DeltaFromPreviousFloat.__PropertyOffset_Cache);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DeltaFromPreviousFloat.__PropertyOffset_Cache) = value;
			}
		}

		// Token: 0x06004C9A RID: 19610 RVA: 0x00071530 File Offset: 0x0006F730
		public FRigUnit_DeltaFromPreviousFloat()
		{
		}

		// Token: 0x06004C9B RID: 19611 RVA: 0x00071538 File Offset: 0x0006F738
		public FRigUnit_DeltaFromPreviousFloat(float Value, float Delta, float PreviousValue, float Cache)
		{
			this.Value = Value;
			this.Delta = Delta;
			this.PreviousValue = PreviousValue;
			this.Cache = Cache;
		}

		// Token: 0x06004C9C RID: 19612 RVA: 0x0007155D File Offset: 0x0006F75D
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_DeltaFromPreviousFloat.StaticStruct();
		}

		// Token: 0x06004C9D RID: 19613 RVA: 0x00071569 File Offset: 0x0006F769
		[NullableContext(2)]
		public FRigUnit_DeltaFromPreviousFloat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004C9E RID: 19614 RVA: 0x00071573 File Offset: 0x0006F773
		public FRigUnit_DeltaFromPreviousFloat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004C9F RID: 19615 RVA: 0x0007157E File Offset: 0x0006F77E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_DeltaFromPreviousFloat(Pointer, false, true);
		}

		// Token: 0x06004CA0 RID: 19616 RVA: 0x00071588 File Offset: 0x0006F788
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_DeltaFromPreviousFloat(Pointer, MemoryOwner);
		}

		// Token: 0x0400250B RID: 9483
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_DeltaFromPreviousFloat";

		// Token: 0x0400250C RID: 9484
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400250D RID: 9485
		internal static int __PropertyOffset_Value;

		// Token: 0x0400250E RID: 9486
		internal static int __PropertyOffset_Delta;

		// Token: 0x0400250F RID: 9487
		internal static int __PropertyOffset_PreviousValue;

		// Token: 0x04002510 RID: 9488
		internal static int __PropertyOffset_Cache;
	}
}
