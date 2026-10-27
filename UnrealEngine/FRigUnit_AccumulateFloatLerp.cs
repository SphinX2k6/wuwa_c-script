using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000531 RID: 1329
	[UnrealObjectPath("/Script/ControlRig.RigUnit_AccumulateFloatLerp")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FRigUnit_AccumulateFloatLerp : FRigUnit_SimBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060045A2 RID: 17826 RVA: 0x00067961 File Offset: 0x00065B61
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_AccumulateFloatLerp._ScriptStructPtr != 0) ? FRigUnit_AccumulateFloatLerp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_AccumulateFloatLerp", ref FRigUnit_AccumulateFloatLerp._ScriptStructPtr);
		}

		// Token: 0x170010E1 RID: 4321
		// (get) Token: 0x060045A3 RID: 17827 RVA: 0x00067985 File Offset: 0x00065B85
		// (set) Token: 0x060045A4 RID: 17828 RVA: 0x00067995 File Offset: 0x00065B95
		public unsafe float TargetValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateFloatLerp.__PropertyOffset_TargetValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateFloatLerp.__PropertyOffset_TargetValue) = value;
			}
		}

		// Token: 0x170010E2 RID: 4322
		// (get) Token: 0x060045A5 RID: 17829 RVA: 0x000679A6 File Offset: 0x00065BA6
		// (set) Token: 0x060045A6 RID: 17830 RVA: 0x000679B6 File Offset: 0x00065BB6
		public unsafe float InitialValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateFloatLerp.__PropertyOffset_InitialValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateFloatLerp.__PropertyOffset_InitialValue) = value;
			}
		}

		// Token: 0x170010E3 RID: 4323
		// (get) Token: 0x060045A7 RID: 17831 RVA: 0x000679C7 File Offset: 0x00065BC7
		// (set) Token: 0x060045A8 RID: 17832 RVA: 0x000679D7 File Offset: 0x00065BD7
		public unsafe float Blend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateFloatLerp.__PropertyOffset_Blend);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateFloatLerp.__PropertyOffset_Blend) = value;
			}
		}

		// Token: 0x170010E4 RID: 4324
		// (get) Token: 0x060045A9 RID: 17833 RVA: 0x000679E8 File Offset: 0x00065BE8
		// (set) Token: 0x060045AA RID: 17834 RVA: 0x000679F8 File Offset: 0x00065BF8
		public unsafe bool bIntegrateDeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateFloatLerp.__PropertyOffset_bIntegrateDeltaTime) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateFloatLerp.__PropertyOffset_bIntegrateDeltaTime) = (value ? 1 : 0);
			}
		}

		// Token: 0x170010E5 RID: 4325
		// (get) Token: 0x060045AB RID: 17835 RVA: 0x00067A09 File Offset: 0x00065C09
		// (set) Token: 0x060045AC RID: 17836 RVA: 0x00067A19 File Offset: 0x00065C19
		public unsafe float Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateFloatLerp.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateFloatLerp.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x170010E6 RID: 4326
		// (get) Token: 0x060045AD RID: 17837 RVA: 0x00067A2A File Offset: 0x00065C2A
		// (set) Token: 0x060045AE RID: 17838 RVA: 0x00067A3A File Offset: 0x00065C3A
		public unsafe float AccumulatedValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateFloatLerp.__PropertyOffset_AccumulatedValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateFloatLerp.__PropertyOffset_AccumulatedValue) = value;
			}
		}

		// Token: 0x060045AF RID: 17839 RVA: 0x00067A4B File Offset: 0x00065C4B
		public FRigUnit_AccumulateFloatLerp()
		{
		}

		// Token: 0x060045B0 RID: 17840 RVA: 0x00067A53 File Offset: 0x00065C53
		public FRigUnit_AccumulateFloatLerp(float TargetValue, float InitialValue, float Blend, bool bIntegrateDeltaTime, float Result, float AccumulatedValue)
		{
			this.TargetValue = TargetValue;
			this.InitialValue = InitialValue;
			this.Blend = Blend;
			this.bIntegrateDeltaTime = bIntegrateDeltaTime;
			this.Result = Result;
			this.AccumulatedValue = AccumulatedValue;
		}

		// Token: 0x060045B1 RID: 17841 RVA: 0x00067A88 File Offset: 0x00065C88
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_AccumulateFloatLerp.StaticStruct();
		}

		// Token: 0x060045B2 RID: 17842 RVA: 0x00067A94 File Offset: 0x00065C94
		[NullableContext(2)]
		public FRigUnit_AccumulateFloatLerp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060045B3 RID: 17843 RVA: 0x00067A9E File Offset: 0x00065C9E
		public FRigUnit_AccumulateFloatLerp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060045B4 RID: 17844 RVA: 0x00067AA9 File Offset: 0x00065CA9
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_AccumulateFloatLerp(Pointer, false, true);
		}

		// Token: 0x060045B5 RID: 17845 RVA: 0x00067AB3 File Offset: 0x00065CB3
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_AccumulateFloatLerp(Pointer, MemoryOwner);
		}

		// Token: 0x040021E4 RID: 8676
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_AccumulateFloatLerp";

		// Token: 0x040021E5 RID: 8677
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040021E6 RID: 8678
		internal static int __PropertyOffset_TargetValue;

		// Token: 0x040021E7 RID: 8679
		internal static int __PropertyOffset_InitialValue;

		// Token: 0x040021E8 RID: 8680
		internal static int __PropertyOffset_Blend;

		// Token: 0x040021E9 RID: 8681
		internal static int __PropertyOffset_bIntegrateDeltaTime;

		// Token: 0x040021EA RID: 8682
		internal static int __PropertyOffset_Result;

		// Token: 0x040021EB RID: 8683
		internal static int __PropertyOffset_AccumulatedValue;
	}
}
