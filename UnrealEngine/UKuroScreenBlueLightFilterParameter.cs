using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BB0 RID: 7088
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroScreenBlueLightFilterParameter")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UKuroScreenBlueLightFilterParameter : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B1BD RID: 111037 RVA: 0x0027F27D File Offset: 0x0027D47D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroScreenBlueLightFilterParameter._ClassPtr;
		}

		// Token: 0x0601B1BE RID: 111038 RVA: 0x0027F28C File Offset: 0x0027D48C
		public UKuroScreenBlueLightFilterParameter() : this(BuiltinUtils.AllocNativeUObject(UKuroScreenBlueLightFilterParameter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B1BF RID: 111039 RVA: 0x0027F2B4 File Offset: 0x0027D4B4
		[NullableContext(1)]
		public UKuroScreenBlueLightFilterParameter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroScreenBlueLightFilterParameter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006CA8 RID: 27816
		// (get) Token: 0x0601B1C0 RID: 111040 RVA: 0x0027F2E7 File Offset: 0x0027D4E7
		// (set) Token: 0x0601B1C1 RID: 111041 RVA: 0x0027F2F7 File Offset: 0x0027D4F7
		public unsafe float ScreenBlueLightFilterStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroScreenBlueLightFilterParameter.__PropertyOffset_ScreenBlueLightFilterStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroScreenBlueLightFilterParameter.__PropertyOffset_ScreenBlueLightFilterStrength) = value;
			}
		}

		// Token: 0x17006CA9 RID: 27817
		// (get) Token: 0x0601B1C2 RID: 111042 RVA: 0x0027F308 File Offset: 0x0027D508
		// (set) Token: 0x0601B1C3 RID: 111043 RVA: 0x0027F318 File Offset: 0x0027D518
		public unsafe float ScreenBlueLightFilterTemperature
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroScreenBlueLightFilterParameter.__PropertyOffset_ScreenBlueLightFilterTemperature);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroScreenBlueLightFilterParameter.__PropertyOffset_ScreenBlueLightFilterTemperature) = value;
			}
		}

		// Token: 0x17006CAA RID: 27818
		// (get) Token: 0x0601B1C4 RID: 111044 RVA: 0x0027F329 File Offset: 0x0027D529
		// (set) Token: 0x0601B1C5 RID: 111045 RVA: 0x0027F339 File Offset: 0x0027D539
		public unsafe float ScreenBrightnessClampMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroScreenBlueLightFilterParameter.__PropertyOffset_ScreenBrightnessClampMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroScreenBlueLightFilterParameter.__PropertyOffset_ScreenBrightnessClampMax) = value;
			}
		}

		// Token: 0x17006CAB RID: 27819
		// (get) Token: 0x0601B1C6 RID: 111046 RVA: 0x0027F34A File Offset: 0x0027D54A
		// (set) Token: 0x0601B1C7 RID: 111047 RVA: 0x0027F35A File Offset: 0x0027D55A
		public unsafe float ScreenBrightnessClampSoftness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroScreenBlueLightFilterParameter.__PropertyOffset_ScreenBrightnessClampSoftness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroScreenBlueLightFilterParameter.__PropertyOffset_ScreenBrightnessClampSoftness) = value;
			}
		}

		// Token: 0x17006CAC RID: 27820
		// (get) Token: 0x0601B1C8 RID: 111048 RVA: 0x0027F36B File Offset: 0x0027D56B
		// (set) Token: 0x0601B1C9 RID: 111049 RVA: 0x0027F37B File Offset: 0x0027D57B
		public unsafe float ScreenBlueLightFilterTextureIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroScreenBlueLightFilterParameter.__PropertyOffset_ScreenBlueLightFilterTextureIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroScreenBlueLightFilterParameter.__PropertyOffset_ScreenBlueLightFilterTextureIntensity) = value;
			}
		}

		// Token: 0x0601B1CA RID: 111050 RVA: 0x0027F38C File Offset: 0x0027D58C
		static UKuroScreenBlueLightFilterParameter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroScreenBlueLightFilterParameter");
		}

		// Token: 0x0601B1CB RID: 111051 RVA: 0x0027F39A File Offset: 0x0027D59A
		protected UKuroScreenBlueLightFilterParameter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E98E RID: 59790
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroScreenBlueLightFilterParameter";

		// Token: 0x0400E98F RID: 59791
		private static IntPtr _ClassPtr;

		// Token: 0x0400E990 RID: 59792
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E991 RID: 59793
		internal static int __PropertyOffset_ScreenBlueLightFilterStrength;

		// Token: 0x0400E992 RID: 59794
		internal static int __PropertyOffset_ScreenBlueLightFilterTemperature;

		// Token: 0x0400E993 RID: 59795
		internal static int __PropertyOffset_ScreenBrightnessClampMax;

		// Token: 0x0400E994 RID: 59796
		internal static int __PropertyOffset_ScreenBrightnessClampSoftness;

		// Token: 0x0400E995 RID: 59797
		internal static int __PropertyOffset_ScreenBlueLightFilterTextureIntensity;
	}
}
