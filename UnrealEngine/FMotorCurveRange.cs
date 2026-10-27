using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F31 RID: 7985
	[UnrealObjectPath("/Script/KuroVehicle.MotorCurveRange")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FMotorCurveRange : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E604 RID: 124420 RVA: 0x002D243C File Offset: 0x002D063C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMotorCurveRange._ScriptStructPtr != 0) ? FMotorCurveRange._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroVehicle.MotorCurveRange", ref FMotorCurveRange._ScriptStructPtr);
		}

		// Token: 0x170078C5 RID: 30917
		// (get) Token: 0x0601E605 RID: 124421 RVA: 0x002D2460 File Offset: 0x002D0660
		// (set) Token: 0x0601E606 RID: 124422 RVA: 0x002D2470 File Offset: 0x002D0670
		public unsafe float FromMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorCurveRange.__PropertyOffset_FromMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorCurveRange.__PropertyOffset_FromMin) = value;
			}
		}

		// Token: 0x170078C6 RID: 30918
		// (get) Token: 0x0601E607 RID: 124423 RVA: 0x002D2481 File Offset: 0x002D0681
		// (set) Token: 0x0601E608 RID: 124424 RVA: 0x002D2491 File Offset: 0x002D0691
		public unsafe float FromMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorCurveRange.__PropertyOffset_FromMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorCurveRange.__PropertyOffset_FromMax) = value;
			}
		}

		// Token: 0x170078C7 RID: 30919
		// (get) Token: 0x0601E609 RID: 124425 RVA: 0x002D24A2 File Offset: 0x002D06A2
		// (set) Token: 0x0601E60A RID: 124426 RVA: 0x002D24B2 File Offset: 0x002D06B2
		public unsafe float ToMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorCurveRange.__PropertyOffset_ToMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorCurveRange.__PropertyOffset_ToMin) = value;
			}
		}

		// Token: 0x170078C8 RID: 30920
		// (get) Token: 0x0601E60B RID: 124427 RVA: 0x002D24C3 File Offset: 0x002D06C3
		// (set) Token: 0x0601E60C RID: 124428 RVA: 0x002D24D3 File Offset: 0x002D06D3
		public unsafe float ToMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorCurveRange.__PropertyOffset_ToMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorCurveRange.__PropertyOffset_ToMax) = value;
			}
		}

		// Token: 0x170078C9 RID: 30921
		// (get) Token: 0x0601E60D RID: 124429 RVA: 0x002D24E4 File Offset: 0x002D06E4
		// (set) Token: 0x0601E60E RID: 124430 RVA: 0x002D24F8 File Offset: 0x002D06F8
		[Nullable(2)]
		public unsafe UCurveFloat Curve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FMotorCurveRange.__PropertyOffset_Curve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMotorCurveRange.__PropertyOffset_Curve, value);
			}
		}

		// Token: 0x0601E60F RID: 124431 RVA: 0x002D250D File Offset: 0x002D070D
		public FMotorCurveRange()
		{
		}

		// Token: 0x0601E610 RID: 124432 RVA: 0x002D2515 File Offset: 0x002D0715
		[NullableContext(1)]
		public FMotorCurveRange(float FromMin, float FromMax, float ToMin, float ToMax, UCurveFloat Curve)
		{
			this.FromMin = FromMin;
			this.FromMax = FromMax;
			this.ToMin = ToMin;
			this.ToMax = ToMax;
			this.Curve = Curve;
		}

		// Token: 0x0601E611 RID: 124433 RVA: 0x002D2542 File Offset: 0x002D0742
		protected override IntPtr GetUStructPtr()
		{
			return FMotorCurveRange.StaticStruct();
		}

		// Token: 0x0601E612 RID: 124434 RVA: 0x002D254E File Offset: 0x002D074E
		[NullableContext(2)]
		public FMotorCurveRange(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E613 RID: 124435 RVA: 0x002D2558 File Offset: 0x002D0758
		public FMotorCurveRange(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E614 RID: 124436 RVA: 0x002D2563 File Offset: 0x002D0763
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMotorCurveRange(Pointer, false, true);
		}

		// Token: 0x0601E615 RID: 124437 RVA: 0x002D256D File Offset: 0x002D076D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMotorCurveRange(Pointer, MemoryOwner);
		}

		// Token: 0x04010621 RID: 67105
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroVehicle.MotorCurveRange";

		// Token: 0x04010622 RID: 67106
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010623 RID: 67107
		internal static int __PropertyOffset_FromMin;

		// Token: 0x04010624 RID: 67108
		internal static int __PropertyOffset_FromMax;

		// Token: 0x04010625 RID: 67109
		internal static int __PropertyOffset_ToMin;

		// Token: 0x04010626 RID: 67110
		internal static int __PropertyOffset_ToMax;

		// Token: 0x04010627 RID: 67111
		internal static int __PropertyOffset_Curve;
	}
}
