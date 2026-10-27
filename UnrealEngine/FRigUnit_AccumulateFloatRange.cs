using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000533 RID: 1331
	[UnrealObjectPath("/Script/ControlRig.RigUnit_AccumulateFloatRange")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FRigUnit_AccumulateFloatRange : FRigUnit_SimBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060045C8 RID: 17864 RVA: 0x00067BEE File Offset: 0x00065DEE
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_AccumulateFloatRange._ScriptStructPtr != 0) ? FRigUnit_AccumulateFloatRange._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_AccumulateFloatRange", ref FRigUnit_AccumulateFloatRange._ScriptStructPtr);
		}

		// Token: 0x170010EC RID: 4332
		// (get) Token: 0x060045C9 RID: 17865 RVA: 0x00067C12 File Offset: 0x00065E12
		// (set) Token: 0x060045CA RID: 17866 RVA: 0x00067C22 File Offset: 0x00065E22
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateFloatRange.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateFloatRange.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x170010ED RID: 4333
		// (get) Token: 0x060045CB RID: 17867 RVA: 0x00067C33 File Offset: 0x00065E33
		// (set) Token: 0x060045CC RID: 17868 RVA: 0x00067C43 File Offset: 0x00065E43
		public unsafe float Minimum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateFloatRange.__PropertyOffset_Minimum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateFloatRange.__PropertyOffset_Minimum) = value;
			}
		}

		// Token: 0x170010EE RID: 4334
		// (get) Token: 0x060045CD RID: 17869 RVA: 0x00067C54 File Offset: 0x00065E54
		// (set) Token: 0x060045CE RID: 17870 RVA: 0x00067C64 File Offset: 0x00065E64
		public unsafe float Maximum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateFloatRange.__PropertyOffset_Maximum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateFloatRange.__PropertyOffset_Maximum) = value;
			}
		}

		// Token: 0x170010EF RID: 4335
		// (get) Token: 0x060045CF RID: 17871 RVA: 0x00067C75 File Offset: 0x00065E75
		// (set) Token: 0x060045D0 RID: 17872 RVA: 0x00067C85 File Offset: 0x00065E85
		public unsafe float AccumulatedMinimum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateFloatRange.__PropertyOffset_AccumulatedMinimum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateFloatRange.__PropertyOffset_AccumulatedMinimum) = value;
			}
		}

		// Token: 0x170010F0 RID: 4336
		// (get) Token: 0x060045D1 RID: 17873 RVA: 0x00067C96 File Offset: 0x00065E96
		// (set) Token: 0x060045D2 RID: 17874 RVA: 0x00067CA6 File Offset: 0x00065EA6
		public unsafe float AccumulatedMaximum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateFloatRange.__PropertyOffset_AccumulatedMaximum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateFloatRange.__PropertyOffset_AccumulatedMaximum) = value;
			}
		}

		// Token: 0x060045D3 RID: 17875 RVA: 0x00067CB7 File Offset: 0x00065EB7
		public FRigUnit_AccumulateFloatRange()
		{
		}

		// Token: 0x060045D4 RID: 17876 RVA: 0x00067CBF File Offset: 0x00065EBF
		public FRigUnit_AccumulateFloatRange(float Value, float Minimum, float Maximum, float AccumulatedMinimum, float AccumulatedMaximum)
		{
			this.Value = Value;
			this.Minimum = Minimum;
			this.Maximum = Maximum;
			this.AccumulatedMinimum = AccumulatedMinimum;
			this.AccumulatedMaximum = AccumulatedMaximum;
		}

		// Token: 0x060045D5 RID: 17877 RVA: 0x00067CEC File Offset: 0x00065EEC
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_AccumulateFloatRange.StaticStruct();
		}

		// Token: 0x060045D6 RID: 17878 RVA: 0x00067CF8 File Offset: 0x00065EF8
		[NullableContext(2)]
		public FRigUnit_AccumulateFloatRange(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060045D7 RID: 17879 RVA: 0x00067D02 File Offset: 0x00065F02
		public FRigUnit_AccumulateFloatRange(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060045D8 RID: 17880 RVA: 0x00067D0D File Offset: 0x00065F0D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_AccumulateFloatRange(Pointer, false, true);
		}

		// Token: 0x060045D9 RID: 17881 RVA: 0x00067D17 File Offset: 0x00065F17
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_AccumulateFloatRange(Pointer, MemoryOwner);
		}

		// Token: 0x040021F3 RID: 8691
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_AccumulateFloatRange";

		// Token: 0x040021F4 RID: 8692
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040021F5 RID: 8693
		internal static int __PropertyOffset_Value;

		// Token: 0x040021F6 RID: 8694
		internal static int __PropertyOffset_Minimum;

		// Token: 0x040021F7 RID: 8695
		internal static int __PropertyOffset_Maximum;

		// Token: 0x040021F8 RID: 8696
		internal static int __PropertyOffset_AccumulatedMinimum;

		// Token: 0x040021F9 RID: 8697
		internal static int __PropertyOffset_AccumulatedMaximum;
	}
}
