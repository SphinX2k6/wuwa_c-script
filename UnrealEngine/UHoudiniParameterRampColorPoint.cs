using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014F6 RID: 5366
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniParameterRampColorPoint")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UHoudiniParameterRampColorPoint : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601372B RID: 79659 RVA: 0x001C97CE File Offset: 0x001C79CE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniParameterRampColorPoint._ClassPtr;
		}

		// Token: 0x0601372C RID: 79660 RVA: 0x001C97DC File Offset: 0x001C79DC
		public UHoudiniParameterRampColorPoint() : this(BuiltinUtils.AllocNativeUObject(UHoudiniParameterRampColorPoint.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601372D RID: 79661 RVA: 0x001C9804 File Offset: 0x001C7A04
		[NullableContext(1)]
		public UHoudiniParameterRampColorPoint(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniParameterRampColorPoint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004BFA RID: 19450
		// (get) Token: 0x0601372E RID: 79662 RVA: 0x001C9837 File Offset: 0x001C7A37
		// (set) Token: 0x0601372F RID: 79663 RVA: 0x001C9847 File Offset: 0x001C7A47
		public unsafe float Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterRampColorPoint.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterRampColorPoint.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x17004BFB RID: 19451
		// (get) Token: 0x06013730 RID: 79664 RVA: 0x001C9858 File Offset: 0x001C7A58
		// (set) Token: 0x06013731 RID: 79665 RVA: 0x001C986C File Offset: 0x001C7A6C
		public unsafe FLinearColor Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterRampColorPoint.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterRampColorPoint.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17004BFC RID: 19452
		// (get) Token: 0x06013732 RID: 79666 RVA: 0x001C9881 File Offset: 0x001C7A81
		// (set) Token: 0x06013733 RID: 79667 RVA: 0x001C9891 File Offset: 0x001C7A91
		public unsafe EHoudiniRampInterpolationType Interpolation
		{
			get
			{
				return (EHoudiniRampInterpolationType)(*(base.NativePtr + (IntPtr)UHoudiniParameterRampColorPoint.__PropertyOffset_Interpolation));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterRampColorPoint.__PropertyOffset_Interpolation) = (byte)value;
			}
		}

		// Token: 0x17004BFD RID: 19453
		// (get) Token: 0x06013734 RID: 79668 RVA: 0x001C98A2 File Offset: 0x001C7AA2
		// (set) Token: 0x06013735 RID: 79669 RVA: 0x001C98B2 File Offset: 0x001C7AB2
		public unsafe int InstanceIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterRampColorPoint.__PropertyOffset_InstanceIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterRampColorPoint.__PropertyOffset_InstanceIndex) = value;
			}
		}

		// Token: 0x17004BFE RID: 19454
		// (get) Token: 0x06013736 RID: 79670 RVA: 0x001C98C3 File Offset: 0x001C7AC3
		// (set) Token: 0x06013737 RID: 79671 RVA: 0x001C98D7 File Offset: 0x001C7AD7
		public unsafe UHoudiniParameterFloat PositionParentParm
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UHoudiniParameterFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UHoudiniParameterRampColorPoint.__PropertyOffset_PositionParentParm);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UHoudiniParameterRampColorPoint.__PropertyOffset_PositionParentParm, value);
			}
		}

		// Token: 0x17004BFF RID: 19455
		// (get) Token: 0x06013738 RID: 79672 RVA: 0x001C98EC File Offset: 0x001C7AEC
		// (set) Token: 0x06013739 RID: 79673 RVA: 0x001C9900 File Offset: 0x001C7B00
		public unsafe UHoudiniParameterColor ValueParentParm
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UHoudiniParameterColor>(base.NativePtr / (IntPtr)sizeof(void*) + UHoudiniParameterRampColorPoint.__PropertyOffset_ValueParentParm);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UHoudiniParameterRampColorPoint.__PropertyOffset_ValueParentParm, value);
			}
		}

		// Token: 0x17004C00 RID: 19456
		// (get) Token: 0x0601373A RID: 79674 RVA: 0x001C9915 File Offset: 0x001C7B15
		// (set) Token: 0x0601373B RID: 79675 RVA: 0x001C9929 File Offset: 0x001C7B29
		public unsafe UHoudiniParameterChoice InterpolationParentParm
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UHoudiniParameterChoice>(base.NativePtr / (IntPtr)sizeof(void*) + UHoudiniParameterRampColorPoint.__PropertyOffset_InterpolationParentParm);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UHoudiniParameterRampColorPoint.__PropertyOffset_InterpolationParentParm, value);
			}
		}

		// Token: 0x0601373C RID: 79676 RVA: 0x001C993E File Offset: 0x001C7B3E
		static UHoudiniParameterRampColorPoint()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniParameterRampColorPoint");
		}

		// Token: 0x0601373D RID: 79677 RVA: 0x001C994C File Offset: 0x001C7B4C
		protected UHoudiniParameterRampColorPoint(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A82F RID: 43055
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniParameterRampColorPoint";

		// Token: 0x0400A830 RID: 43056
		private static IntPtr _ClassPtr;

		// Token: 0x0400A831 RID: 43057
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A832 RID: 43058
		internal static int __PropertyOffset_Position;

		// Token: 0x0400A833 RID: 43059
		internal static int __PropertyOffset_Value;

		// Token: 0x0400A834 RID: 43060
		internal static int __PropertyOffset_Interpolation;

		// Token: 0x0400A835 RID: 43061
		internal static int __PropertyOffset_InstanceIndex;

		// Token: 0x0400A836 RID: 43062
		internal static int __PropertyOffset_PositionParentParm;

		// Token: 0x0400A837 RID: 43063
		internal static int __PropertyOffset_ValueParentParm;

		// Token: 0x0400A838 RID: 43064
		internal static int __PropertyOffset_InterpolationParentParm;
	}
}
