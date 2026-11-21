using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000635 RID: 1589
	[UnrealObjectPath("/Script/KuroVehicle.MotorFloatRange")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FMotorFloatRange : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008B84 RID: 35716 RVA: 0x000D1FC9 File Offset: 0x000D01C9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMotorFloatRange._ScriptStructPtr != 0) ? FMotorFloatRange._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroVehicle.MotorFloatRange", ref FMotorFloatRange._ScriptStructPtr);
		}

		// Token: 0x17001A46 RID: 6726
		// (get) Token: 0x06008B85 RID: 35717 RVA: 0x000D1FED File Offset: 0x000D01ED
		// (set) Token: 0x06008B86 RID: 35718 RVA: 0x000D1FFD File Offset: 0x000D01FD
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

		// Token: 0x17001A47 RID: 6727
		// (get) Token: 0x06008B87 RID: 35719 RVA: 0x000D200E File Offset: 0x000D020E
		// (set) Token: 0x06008B88 RID: 35720 RVA: 0x000D201E File Offset: 0x000D021E
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

		// Token: 0x17001A48 RID: 6728
		// (get) Token: 0x06008B89 RID: 35721 RVA: 0x000D202F File Offset: 0x000D022F
		// (set) Token: 0x06008B8A RID: 35722 RVA: 0x000D203F File Offset: 0x000D023F
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

		// Token: 0x17001A49 RID: 6729
		// (get) Token: 0x06008B8B RID: 35723 RVA: 0x000D2050 File Offset: 0x000D0250
		// (set) Token: 0x06008B8C RID: 35724 RVA: 0x000D2060 File Offset: 0x000D0260
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

		// Token: 0x17001A4A RID: 6730
		// (get) Token: 0x06008B8D RID: 35725 RVA: 0x000D2071 File Offset: 0x000D0271
		// (set) Token: 0x06008B8E RID: 35726 RVA: 0x000D2085 File Offset: 0x000D0285
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

		// Token: 0x06008B8F RID: 35727 RVA: 0x000D209A File Offset: 0x000D029A
		public FMotorFloatRange()
		{
		}

		// Token: 0x06008B90 RID: 35728 RVA: 0x000D20A2 File Offset: 0x000D02A2
		protected override IntPtr GetUStructPtr()
		{
			return FMotorFloatRange.StaticStruct();
		}

		// Token: 0x06008B91 RID: 35729 RVA: 0x000D20AE File Offset: 0x000D02AE
		[NullableContext(2)]
		public FMotorFloatRange(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008B92 RID: 35730 RVA: 0x000D20B8 File Offset: 0x000D02B8
		public FMotorFloatRange(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008B93 RID: 35731 RVA: 0x000D20C3 File Offset: 0x000D02C3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMotorFloatRange(Pointer, false, true);
		}

		// Token: 0x06008B94 RID: 35732 RVA: 0x000D20CD File Offset: 0x000D02CD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMotorFloatRange(Pointer, MemoryOwner);
		}

		// Token: 0x04003C9E RID: 15518
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroVehicle.MotorFloatRange";

		// Token: 0x04003C9F RID: 15519
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003CA0 RID: 15520
		internal static int __PropertyOffset_FromMin;

		// Token: 0x04003CA1 RID: 15521
		internal static int __PropertyOffset_FromMax;

		// Token: 0x04003CA2 RID: 15522
		internal static int __PropertyOffset_ToMin;

		// Token: 0x04003CA3 RID: 15523
		internal static int __PropertyOffset_ToMax;

		// Token: 0x04003CA4 RID: 15524
		internal static int __PropertyOffset_Curve;
	}
}
