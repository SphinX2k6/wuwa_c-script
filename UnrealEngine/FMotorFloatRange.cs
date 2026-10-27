using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F33 RID: 7987
	[UnrealObjectPath("/Script/KuroVehicle.MotorFloatRange")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FMotorFloatRange : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E63D RID: 124477 RVA: 0x002D2B2D File Offset: 0x002D0D2D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMotorFloatRange._ScriptStructPtr != 0) ? FMotorFloatRange._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroVehicle.MotorFloatRange", ref FMotorFloatRange._ScriptStructPtr);
		}

		// Token: 0x170078DB RID: 30939
		// (get) Token: 0x0601E63E RID: 124478 RVA: 0x002D2B51 File Offset: 0x002D0D51
		// (set) Token: 0x0601E63F RID: 124479 RVA: 0x002D2B61 File Offset: 0x002D0D61
		public unsafe float FromMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorFloatRange.__PropertyOffset_FromMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorFloatRange.__PropertyOffset_FromMin) = value;
			}
		}

		// Token: 0x170078DC RID: 30940
		// (get) Token: 0x0601E640 RID: 124480 RVA: 0x002D2B72 File Offset: 0x002D0D72
		// (set) Token: 0x0601E641 RID: 124481 RVA: 0x002D2B82 File Offset: 0x002D0D82
		public unsafe float FromMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorFloatRange.__PropertyOffset_FromMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorFloatRange.__PropertyOffset_FromMax) = value;
			}
		}

		// Token: 0x170078DD RID: 30941
		// (get) Token: 0x0601E642 RID: 124482 RVA: 0x002D2B93 File Offset: 0x002D0D93
		// (set) Token: 0x0601E643 RID: 124483 RVA: 0x002D2BA3 File Offset: 0x002D0DA3
		public unsafe float ToMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorFloatRange.__PropertyOffset_ToMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorFloatRange.__PropertyOffset_ToMin) = value;
			}
		}

		// Token: 0x170078DE RID: 30942
		// (get) Token: 0x0601E644 RID: 124484 RVA: 0x002D2BB4 File Offset: 0x002D0DB4
		// (set) Token: 0x0601E645 RID: 124485 RVA: 0x002D2BC4 File Offset: 0x002D0DC4
		public unsafe float ToMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorFloatRange.__PropertyOffset_ToMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorFloatRange.__PropertyOffset_ToMax) = value;
			}
		}

		// Token: 0x170078DF RID: 30943
		// (get) Token: 0x0601E646 RID: 124486 RVA: 0x002D2BD5 File Offset: 0x002D0DD5
		// (set) Token: 0x0601E647 RID: 124487 RVA: 0x002D2BE9 File Offset: 0x002D0DE9
		[Nullable(2)]
		public unsafe UCurveFloat Curve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FMotorFloatRange.__PropertyOffset_Curve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMotorFloatRange.__PropertyOffset_Curve, value);
			}
		}

		// Token: 0x0601E648 RID: 124488 RVA: 0x002D2BFE File Offset: 0x002D0DFE
		public FMotorFloatRange()
		{
		}

		// Token: 0x0601E649 RID: 124489 RVA: 0x002D2C06 File Offset: 0x002D0E06
		[NullableContext(1)]
		public FMotorFloatRange(float FromMin, float FromMax, float ToMin, float ToMax, UCurveFloat Curve)
		{
			this.FromMin = FromMin;
			this.FromMax = FromMax;
			this.ToMin = ToMin;
			this.ToMax = ToMax;
			this.Curve = Curve;
		}

		// Token: 0x0601E64A RID: 124490 RVA: 0x002D2C33 File Offset: 0x002D0E33
		protected override IntPtr GetUStructPtr()
		{
			return FMotorFloatRange.StaticStruct();
		}

		// Token: 0x0601E64B RID: 124491 RVA: 0x002D2C3F File Offset: 0x002D0E3F
		[NullableContext(2)]
		public FMotorFloatRange(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E64C RID: 124492 RVA: 0x002D2C49 File Offset: 0x002D0E49
		public FMotorFloatRange(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E64D RID: 124493 RVA: 0x002D2C54 File Offset: 0x002D0E54
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMotorFloatRange(Pointer, false, true);
		}

		// Token: 0x0601E64E RID: 124494 RVA: 0x002D2C5E File Offset: 0x002D0E5E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMotorFloatRange(Pointer, MemoryOwner);
		}

		// Token: 0x04010649 RID: 67145
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroVehicle.MotorFloatRange";

		// Token: 0x0401064A RID: 67146
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401064B RID: 67147
		internal static int __PropertyOffset_FromMin;

		// Token: 0x0401064C RID: 67148
		internal static int __PropertyOffset_FromMax;

		// Token: 0x0401064D RID: 67149
		internal static int __PropertyOffset_ToMin;

		// Token: 0x0401064E RID: 67150
		internal static int __PropertyOffset_ToMax;

		// Token: 0x0401064F RID: 67151
		internal static int __PropertyOffset_Curve;
	}
}
