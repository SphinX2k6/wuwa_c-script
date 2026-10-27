using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BB2 RID: 7090
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroScreenFilterParameter")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UKuroScreenFilterParameter : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B1DD RID: 111069 RVA: 0x0027F510 File Offset: 0x0027D710
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroScreenFilterParameter._ClassPtr;
		}

		// Token: 0x0601B1DE RID: 111070 RVA: 0x0027F51C File Offset: 0x0027D71C
		public UKuroScreenFilterParameter() : this(BuiltinUtils.AllocNativeUObject(UKuroScreenFilterParameter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B1DF RID: 111071 RVA: 0x0027F544 File Offset: 0x0027D744
		[NullableContext(1)]
		public UKuroScreenFilterParameter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroScreenFilterParameter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006CB3 RID: 27827
		// (get) Token: 0x0601B1E0 RID: 111072 RVA: 0x0027F577 File Offset: 0x0027D777
		// (set) Token: 0x0601B1E1 RID: 111073 RVA: 0x0027F587 File Offset: 0x0027D787
		public unsafe float Contrast
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroScreenFilterParameter.__PropertyOffset_Contrast);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroScreenFilterParameter.__PropertyOffset_Contrast) = value;
			}
		}

		// Token: 0x17006CB4 RID: 27828
		// (get) Token: 0x0601B1E2 RID: 111074 RVA: 0x0027F598 File Offset: 0x0027D798
		// (set) Token: 0x0601B1E3 RID: 111075 RVA: 0x0027F5A8 File Offset: 0x0027D7A8
		public unsafe float Saturation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroScreenFilterParameter.__PropertyOffset_Saturation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroScreenFilterParameter.__PropertyOffset_Saturation) = value;
			}
		}

		// Token: 0x17006CB5 RID: 27829
		// (get) Token: 0x0601B1E4 RID: 111076 RVA: 0x0027F5B9 File Offset: 0x0027D7B9
		// (set) Token: 0x0601B1E5 RID: 111077 RVA: 0x0027F5C9 File Offset: 0x0027D7C9
		public unsafe float ColorTemperature
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroScreenFilterParameter.__PropertyOffset_ColorTemperature);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroScreenFilterParameter.__PropertyOffset_ColorTemperature) = value;
			}
		}

		// Token: 0x17006CB6 RID: 27830
		// (get) Token: 0x0601B1E6 RID: 111078 RVA: 0x0027F5DA File Offset: 0x0027D7DA
		// (set) Token: 0x0601B1E7 RID: 111079 RVA: 0x0027F5EA File Offset: 0x0027D7EA
		public unsafe float Hue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroScreenFilterParameter.__PropertyOffset_Hue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroScreenFilterParameter.__PropertyOffset_Hue) = value;
			}
		}

		// Token: 0x17006CB7 RID: 27831
		// (get) Token: 0x0601B1E8 RID: 111080 RVA: 0x0027F5FB File Offset: 0x0027D7FB
		// (set) Token: 0x0601B1E9 RID: 111081 RVA: 0x0027F60B File Offset: 0x0027D80B
		public unsafe float Vignette
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroScreenFilterParameter.__PropertyOffset_Vignette);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroScreenFilterParameter.__PropertyOffset_Vignette) = value;
			}
		}

		// Token: 0x17006CB8 RID: 27832
		// (get) Token: 0x0601B1EA RID: 111082 RVA: 0x0027F61C File Offset: 0x0027D81C
		// (set) Token: 0x0601B1EB RID: 111083 RVA: 0x0027F62C File Offset: 0x0027D82C
		public unsafe float Brightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroScreenFilterParameter.__PropertyOffset_Brightness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroScreenFilterParameter.__PropertyOffset_Brightness) = value;
			}
		}

		// Token: 0x17006CB9 RID: 27833
		// (get) Token: 0x0601B1EC RID: 111084 RVA: 0x0027F63D File Offset: 0x0027D83D
		// (set) Token: 0x0601B1ED RID: 111085 RVA: 0x0027F64D File Offset: 0x0027D84D
		public unsafe float Gamma
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroScreenFilterParameter.__PropertyOffset_Gamma);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroScreenFilterParameter.__PropertyOffset_Gamma) = value;
			}
		}

		// Token: 0x17006CBA RID: 27834
		// (get) Token: 0x0601B1EE RID: 111086 RVA: 0x0027F65E File Offset: 0x0027D85E
		// (set) Token: 0x0601B1EF RID: 111087 RVA: 0x0027F66E File Offset: 0x0027D86E
		public unsafe float ShadowIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroScreenFilterParameter.__PropertyOffset_ShadowIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroScreenFilterParameter.__PropertyOffset_ShadowIntensity) = value;
			}
		}

		// Token: 0x0601B1F0 RID: 111088 RVA: 0x0027F67F File Offset: 0x0027D87F
		static UKuroScreenFilterParameter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroScreenFilterParameter");
		}

		// Token: 0x0601B1F1 RID: 111089 RVA: 0x0027F68D File Offset: 0x0027D88D
		protected UKuroScreenFilterParameter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E99F RID: 59807
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroScreenFilterParameter";

		// Token: 0x0400E9A0 RID: 59808
		private static IntPtr _ClassPtr;

		// Token: 0x0400E9A1 RID: 59809
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E9A2 RID: 59810
		internal static int __PropertyOffset_Contrast;

		// Token: 0x0400E9A3 RID: 59811
		internal static int __PropertyOffset_Saturation;

		// Token: 0x0400E9A4 RID: 59812
		internal static int __PropertyOffset_ColorTemperature;

		// Token: 0x0400E9A5 RID: 59813
		internal static int __PropertyOffset_Hue;

		// Token: 0x0400E9A6 RID: 59814
		internal static int __PropertyOffset_Vignette;

		// Token: 0x0400E9A7 RID: 59815
		internal static int __PropertyOffset_Brightness;

		// Token: 0x0400E9A8 RID: 59816
		internal static int __PropertyOffset_Gamma;

		// Token: 0x0400E9A9 RID: 59817
		internal static int __PropertyOffset_ShadowIntensity;
	}
}
