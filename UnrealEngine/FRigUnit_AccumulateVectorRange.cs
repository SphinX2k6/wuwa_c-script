using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200053B RID: 1339
	[UnrealObjectPath("/Script/ControlRig.RigUnit_AccumulateVectorRange")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FRigUnit_AccumulateVectorRange : FRigUnit_SimBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004662 RID: 18018 RVA: 0x0006872B File Offset: 0x0006692B
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_AccumulateVectorRange._ScriptStructPtr != 0) ? FRigUnit_AccumulateVectorRange._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_AccumulateVectorRange", ref FRigUnit_AccumulateVectorRange._ScriptStructPtr);
		}

		// Token: 0x17001119 RID: 4377
		// (get) Token: 0x06004663 RID: 18019 RVA: 0x0006874F File Offset: 0x0006694F
		// (set) Token: 0x06004664 RID: 18020 RVA: 0x00068763 File Offset: 0x00066963
		public unsafe FVector Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateVectorRange.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateVectorRange.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x1700111A RID: 4378
		// (get) Token: 0x06004665 RID: 18021 RVA: 0x00068778 File Offset: 0x00066978
		// (set) Token: 0x06004666 RID: 18022 RVA: 0x0006878C File Offset: 0x0006698C
		public unsafe FVector Minimum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateVectorRange.__PropertyOffset_Minimum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateVectorRange.__PropertyOffset_Minimum) = value;
			}
		}

		// Token: 0x1700111B RID: 4379
		// (get) Token: 0x06004667 RID: 18023 RVA: 0x000687A1 File Offset: 0x000669A1
		// (set) Token: 0x06004668 RID: 18024 RVA: 0x000687B5 File Offset: 0x000669B5
		public unsafe FVector Maximum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateVectorRange.__PropertyOffset_Maximum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateVectorRange.__PropertyOffset_Maximum) = value;
			}
		}

		// Token: 0x1700111C RID: 4380
		// (get) Token: 0x06004669 RID: 18025 RVA: 0x000687CA File Offset: 0x000669CA
		// (set) Token: 0x0600466A RID: 18026 RVA: 0x000687DE File Offset: 0x000669DE
		public unsafe FVector AccumulatedMinimum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateVectorRange.__PropertyOffset_AccumulatedMinimum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateVectorRange.__PropertyOffset_AccumulatedMinimum) = value;
			}
		}

		// Token: 0x1700111D RID: 4381
		// (get) Token: 0x0600466B RID: 18027 RVA: 0x000687F3 File Offset: 0x000669F3
		// (set) Token: 0x0600466C RID: 18028 RVA: 0x00068807 File Offset: 0x00066A07
		public unsafe FVector AccumulatedMaximum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateVectorRange.__PropertyOffset_AccumulatedMaximum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateVectorRange.__PropertyOffset_AccumulatedMaximum) = value;
			}
		}

		// Token: 0x0600466D RID: 18029 RVA: 0x0006881C File Offset: 0x00066A1C
		public FRigUnit_AccumulateVectorRange()
		{
		}

		// Token: 0x0600466E RID: 18030 RVA: 0x00068824 File Offset: 0x00066A24
		public FRigUnit_AccumulateVectorRange(FVector Value, FVector Minimum, FVector Maximum, FVector AccumulatedMinimum, FVector AccumulatedMaximum)
		{
			this.Value = Value;
			this.Minimum = Minimum;
			this.Maximum = Maximum;
			this.AccumulatedMinimum = AccumulatedMinimum;
			this.AccumulatedMaximum = AccumulatedMaximum;
		}

		// Token: 0x0600466F RID: 18031 RVA: 0x00068851 File Offset: 0x00066A51
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_AccumulateVectorRange.StaticStruct();
		}

		// Token: 0x06004670 RID: 18032 RVA: 0x0006885D File Offset: 0x00066A5D
		[NullableContext(2)]
		public FRigUnit_AccumulateVectorRange(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004671 RID: 18033 RVA: 0x00068867 File Offset: 0x00066A67
		public FRigUnit_AccumulateVectorRange(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004672 RID: 18034 RVA: 0x00068872 File Offset: 0x00066A72
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_AccumulateVectorRange(Pointer, false, true);
		}

		// Token: 0x06004673 RID: 18035 RVA: 0x0006887C File Offset: 0x00066A7C
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_AccumulateVectorRange(Pointer, MemoryOwner);
		}

		// Token: 0x04002230 RID: 8752
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_AccumulateVectorRange";

		// Token: 0x04002231 RID: 8753
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002232 RID: 8754
		internal static int __PropertyOffset_Value;

		// Token: 0x04002233 RID: 8755
		internal static int __PropertyOffset_Minimum;

		// Token: 0x04002234 RID: 8756
		internal static int __PropertyOffset_Maximum;

		// Token: 0x04002235 RID: 8757
		internal static int __PropertyOffset_AccumulatedMinimum;

		// Token: 0x04002236 RID: 8758
		internal static int __PropertyOffset_AccumulatedMaximum;
	}
}
