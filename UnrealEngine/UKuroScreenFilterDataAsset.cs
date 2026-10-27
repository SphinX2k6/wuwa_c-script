using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BB1 RID: 7089
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroScreenFilterDataAsset")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UKuroScreenFilterDataAsset : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B1CC RID: 111052 RVA: 0x0027F3A3 File Offset: 0x0027D5A3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroScreenFilterDataAsset._ClassPtr;
		}

		// Token: 0x0601B1CD RID: 111053 RVA: 0x0027F3B0 File Offset: 0x0027D5B0
		public UKuroScreenFilterDataAsset() : this(BuiltinUtils.AllocNativeUObject(UKuroScreenFilterDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B1CE RID: 111054 RVA: 0x0027F3D8 File Offset: 0x0027D5D8
		[NullableContext(1)]
		public UKuroScreenFilterDataAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroScreenFilterDataAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006CAD RID: 27821
		// (get) Token: 0x0601B1CF RID: 111055 RVA: 0x0027F40B File Offset: 0x0027D60B
		// (set) Token: 0x0601B1D0 RID: 111056 RVA: 0x0027F41F File Offset: 0x0027D61F
		public unsafe UKuroScreenFilterParameter ParameterA
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroScreenFilterParameter>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroScreenFilterDataAsset.__PropertyOffset_ParameterA);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroScreenFilterDataAsset.__PropertyOffset_ParameterA, value);
			}
		}

		// Token: 0x17006CAE RID: 27822
		// (get) Token: 0x0601B1D1 RID: 111057 RVA: 0x0027F434 File Offset: 0x0027D634
		// (set) Token: 0x0601B1D2 RID: 111058 RVA: 0x0027F448 File Offset: 0x0027D648
		public unsafe UKuroScreenFilterParameter ParameterB
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroScreenFilterParameter>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroScreenFilterDataAsset.__PropertyOffset_ParameterB);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroScreenFilterDataAsset.__PropertyOffset_ParameterB, value);
			}
		}

		// Token: 0x17006CAF RID: 27823
		// (get) Token: 0x0601B1D3 RID: 111059 RVA: 0x0027F45D File Offset: 0x0027D65D
		// (set) Token: 0x0601B1D4 RID: 111060 RVA: 0x0027F471 File Offset: 0x0027D671
		public unsafe UKuroScreenFilterParameter ParameterC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroScreenFilterParameter>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroScreenFilterDataAsset.__PropertyOffset_ParameterC);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroScreenFilterDataAsset.__PropertyOffset_ParameterC, value);
			}
		}

		// Token: 0x17006CB0 RID: 27824
		// (get) Token: 0x0601B1D5 RID: 111061 RVA: 0x0027F486 File Offset: 0x0027D686
		// (set) Token: 0x0601B1D6 RID: 111062 RVA: 0x0027F49A File Offset: 0x0027D69A
		public unsafe UKuroScreenFilterParameter ParameterD
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroScreenFilterParameter>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroScreenFilterDataAsset.__PropertyOffset_ParameterD);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroScreenFilterDataAsset.__PropertyOffset_ParameterD, value);
			}
		}

		// Token: 0x17006CB1 RID: 27825
		// (get) Token: 0x0601B1D7 RID: 111063 RVA: 0x0027F4AF File Offset: 0x0027D6AF
		// (set) Token: 0x0601B1D8 RID: 111064 RVA: 0x0027F4C3 File Offset: 0x0027D6C3
		public unsafe UTexture ScreenLeakColorGradingLUT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroScreenFilterDataAsset.__PropertyOffset_ScreenLeakColorGradingLUT);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroScreenFilterDataAsset.__PropertyOffset_ScreenLeakColorGradingLUT, value);
			}
		}

		// Token: 0x17006CB2 RID: 27826
		// (get) Token: 0x0601B1D9 RID: 111065 RVA: 0x0027F4D8 File Offset: 0x0027D6D8
		// (set) Token: 0x0601B1DA RID: 111066 RVA: 0x0027F4E8 File Offset: 0x0027D6E8
		public unsafe float ColorGradingLUTIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroScreenFilterDataAsset.__PropertyOffset_ColorGradingLUTIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroScreenFilterDataAsset.__PropertyOffset_ColorGradingLUTIntensity) = value;
			}
		}

		// Token: 0x0601B1DB RID: 111067 RVA: 0x0027F4F9 File Offset: 0x0027D6F9
		static UKuroScreenFilterDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroScreenFilterDataAsset");
		}

		// Token: 0x0601B1DC RID: 111068 RVA: 0x0027F507 File Offset: 0x0027D707
		protected UKuroScreenFilterDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E996 RID: 59798
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroScreenFilterDataAsset";

		// Token: 0x0400E997 RID: 59799
		private static IntPtr _ClassPtr;

		// Token: 0x0400E998 RID: 59800
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E999 RID: 59801
		internal static int __PropertyOffset_ParameterA;

		// Token: 0x0400E99A RID: 59802
		internal static int __PropertyOffset_ParameterB;

		// Token: 0x0400E99B RID: 59803
		internal static int __PropertyOffset_ParameterC;

		// Token: 0x0400E99C RID: 59804
		internal static int __PropertyOffset_ParameterD;

		// Token: 0x0400E99D RID: 59805
		internal static int __PropertyOffset_ScreenLeakColorGradingLUT;

		// Token: 0x0400E99E RID: 59806
		internal static int __PropertyOffset_ColorGradingLUTIntensity;
	}
}
