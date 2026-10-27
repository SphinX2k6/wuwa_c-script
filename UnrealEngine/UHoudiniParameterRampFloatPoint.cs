using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014F8 RID: 5368
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniParameterRampFloatPoint")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UHoudiniParameterRampFloatPoint : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013753 RID: 79699 RVA: 0x001C9BCA File Offset: 0x001C7DCA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniParameterRampFloatPoint._ClassPtr;
		}

		// Token: 0x06013754 RID: 79700 RVA: 0x001C9BD8 File Offset: 0x001C7DD8
		public UHoudiniParameterRampFloatPoint() : this(BuiltinUtils.AllocNativeUObject(UHoudiniParameterRampFloatPoint.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013755 RID: 79701 RVA: 0x001C9C00 File Offset: 0x001C7E00
		[NullableContext(1)]
		public UHoudiniParameterRampFloatPoint(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniParameterRampFloatPoint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004C09 RID: 19465
		// (get) Token: 0x06013756 RID: 79702 RVA: 0x001C9C33 File Offset: 0x001C7E33
		// (set) Token: 0x06013757 RID: 79703 RVA: 0x001C9C43 File Offset: 0x001C7E43
		public unsafe float Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterRampFloatPoint.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterRampFloatPoint.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x17004C0A RID: 19466
		// (get) Token: 0x06013758 RID: 79704 RVA: 0x001C9C54 File Offset: 0x001C7E54
		// (set) Token: 0x06013759 RID: 79705 RVA: 0x001C9C64 File Offset: 0x001C7E64
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterRampFloatPoint.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterRampFloatPoint.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17004C0B RID: 19467
		// (get) Token: 0x0601375A RID: 79706 RVA: 0x001C9C75 File Offset: 0x001C7E75
		// (set) Token: 0x0601375B RID: 79707 RVA: 0x001C9C85 File Offset: 0x001C7E85
		public unsafe EHoudiniRampInterpolationType Interpolation
		{
			get
			{
				return (EHoudiniRampInterpolationType)(*(base.NativePtr + (IntPtr)UHoudiniParameterRampFloatPoint.__PropertyOffset_Interpolation));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterRampFloatPoint.__PropertyOffset_Interpolation) = (byte)value;
			}
		}

		// Token: 0x17004C0C RID: 19468
		// (get) Token: 0x0601375C RID: 79708 RVA: 0x001C9C96 File Offset: 0x001C7E96
		// (set) Token: 0x0601375D RID: 79709 RVA: 0x001C9CA6 File Offset: 0x001C7EA6
		public unsafe int InstanceIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterRampFloatPoint.__PropertyOffset_InstanceIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterRampFloatPoint.__PropertyOffset_InstanceIndex) = value;
			}
		}

		// Token: 0x17004C0D RID: 19469
		// (get) Token: 0x0601375E RID: 79710 RVA: 0x001C9CB7 File Offset: 0x001C7EB7
		// (set) Token: 0x0601375F RID: 79711 RVA: 0x001C9CCB File Offset: 0x001C7ECB
		public unsafe UHoudiniParameterFloat PositionParentParm
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UHoudiniParameterFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UHoudiniParameterRampFloatPoint.__PropertyOffset_PositionParentParm);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UHoudiniParameterRampFloatPoint.__PropertyOffset_PositionParentParm, value);
			}
		}

		// Token: 0x17004C0E RID: 19470
		// (get) Token: 0x06013760 RID: 79712 RVA: 0x001C9CE0 File Offset: 0x001C7EE0
		// (set) Token: 0x06013761 RID: 79713 RVA: 0x001C9CF4 File Offset: 0x001C7EF4
		public unsafe UHoudiniParameterFloat ValueParentParm
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UHoudiniParameterFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UHoudiniParameterRampFloatPoint.__PropertyOffset_ValueParentParm);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UHoudiniParameterRampFloatPoint.__PropertyOffset_ValueParentParm, value);
			}
		}

		// Token: 0x17004C0F RID: 19471
		// (get) Token: 0x06013762 RID: 79714 RVA: 0x001C9D09 File Offset: 0x001C7F09
		// (set) Token: 0x06013763 RID: 79715 RVA: 0x001C9D1D File Offset: 0x001C7F1D
		public unsafe UHoudiniParameterChoice InterpolationParentParm
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UHoudiniParameterChoice>(base.NativePtr / (IntPtr)sizeof(void*) + UHoudiniParameterRampFloatPoint.__PropertyOffset_InterpolationParentParm);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UHoudiniParameterRampFloatPoint.__PropertyOffset_InterpolationParentParm, value);
			}
		}

		// Token: 0x06013764 RID: 79716 RVA: 0x001C9D32 File Offset: 0x001C7F32
		static UHoudiniParameterRampFloatPoint()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniParameterRampFloatPoint");
		}

		// Token: 0x06013765 RID: 79717 RVA: 0x001C9D40 File Offset: 0x001C7F40
		protected UHoudiniParameterRampFloatPoint(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A84A RID: 43082
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniParameterRampFloatPoint";

		// Token: 0x0400A84B RID: 43083
		private static IntPtr _ClassPtr;

		// Token: 0x0400A84C RID: 43084
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A84D RID: 43085
		internal static int __PropertyOffset_Position;

		// Token: 0x0400A84E RID: 43086
		internal static int __PropertyOffset_Value;

		// Token: 0x0400A84F RID: 43087
		internal static int __PropertyOffset_Interpolation;

		// Token: 0x0400A850 RID: 43088
		internal static int __PropertyOffset_InstanceIndex;

		// Token: 0x0400A851 RID: 43089
		internal static int __PropertyOffset_PositionParentParm;

		// Token: 0x0400A852 RID: 43090
		internal static int __PropertyOffset_ValueParentParm;

		// Token: 0x0400A853 RID: 43091
		internal static int __PropertyOffset_InterpolationParentParm;
	}
}
