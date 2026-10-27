using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200049C RID: 1180
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ColorCorrectRegions.ColorCorrectRegion")]
	[UnrealStructLayout(1424, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1424)]
	public class AColorCorrectRegion : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003F69 RID: 16233 RVA: 0x0005F442 File Offset: 0x0005D642
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AColorCorrectRegion._ClassPtr;
		}

		// Token: 0x06003F6A RID: 16234 RVA: 0x0005F450 File Offset: 0x0005D650
		public AColorCorrectRegion() : this(BuiltinUtils.AllocNativeUObject(AColorCorrectRegion.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003F6B RID: 16235 RVA: 0x0005F478 File Offset: 0x0005D678
		public AColorCorrectRegion(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AColorCorrectRegion.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000F7E RID: 3966
		// (get) Token: 0x06003F6C RID: 16236 RVA: 0x0005F4AB File Offset: 0x0005D6AB
		// (set) Token: 0x06003F6D RID: 16237 RVA: 0x0005F4BB File Offset: 0x0005D6BB
		public unsafe EColorCorrectRegionsType Type
		{
			get
			{
				return (EColorCorrectRegionsType)(*(base.NativePtr + (IntPtr)AColorCorrectRegion.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)AColorCorrectRegion.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x17000F7F RID: 3967
		// (get) Token: 0x06003F6E RID: 16238 RVA: 0x0005F4CC File Offset: 0x0005D6CC
		// (set) Token: 0x06003F6F RID: 16239 RVA: 0x0005F4DC File Offset: 0x0005D6DC
		public unsafe int Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AColorCorrectRegion.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AColorCorrectRegion.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x17000F80 RID: 3968
		// (get) Token: 0x06003F70 RID: 16240 RVA: 0x0005F4ED File Offset: 0x0005D6ED
		// (set) Token: 0x06003F71 RID: 16241 RVA: 0x0005F4FD File Offset: 0x0005D6FD
		public unsafe float Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AColorCorrectRegion.__PropertyOffset_Intensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AColorCorrectRegion.__PropertyOffset_Intensity) = value;
			}
		}

		// Token: 0x17000F81 RID: 3969
		// (get) Token: 0x06003F72 RID: 16242 RVA: 0x0005F50E File Offset: 0x0005D70E
		// (set) Token: 0x06003F73 RID: 16243 RVA: 0x0005F51E File Offset: 0x0005D71E
		public unsafe float Inner
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AColorCorrectRegion.__PropertyOffset_Inner);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AColorCorrectRegion.__PropertyOffset_Inner) = value;
			}
		}

		// Token: 0x17000F82 RID: 3970
		// (get) Token: 0x06003F74 RID: 16244 RVA: 0x0005F52F File Offset: 0x0005D72F
		// (set) Token: 0x06003F75 RID: 16245 RVA: 0x0005F53F File Offset: 0x0005D73F
		public unsafe float Outer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AColorCorrectRegion.__PropertyOffset_Outer);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AColorCorrectRegion.__PropertyOffset_Outer) = value;
			}
		}

		// Token: 0x17000F83 RID: 3971
		// (get) Token: 0x06003F76 RID: 16246 RVA: 0x0005F550 File Offset: 0x0005D750
		// (set) Token: 0x06003F77 RID: 16247 RVA: 0x0005F560 File Offset: 0x0005D760
		public unsafe float Falloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AColorCorrectRegion.__PropertyOffset_Falloff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AColorCorrectRegion.__PropertyOffset_Falloff) = value;
			}
		}

		// Token: 0x17000F84 RID: 3972
		// (get) Token: 0x06003F78 RID: 16248 RVA: 0x0005F571 File Offset: 0x0005D771
		// (set) Token: 0x06003F79 RID: 16249 RVA: 0x0005F581 File Offset: 0x0005D781
		public unsafe bool Invert
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AColorCorrectRegion.__PropertyOffset_Invert) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AColorCorrectRegion.__PropertyOffset_Invert) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000F85 RID: 3973
		// (get) Token: 0x06003F7A RID: 16250 RVA: 0x0005F592 File Offset: 0x0005D792
		// (set) Token: 0x06003F7B RID: 16251 RVA: 0x0005F5A2 File Offset: 0x0005D7A2
		public unsafe float Temperature
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AColorCorrectRegion.__PropertyOffset_Temperature);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AColorCorrectRegion.__PropertyOffset_Temperature) = value;
			}
		}

		// Token: 0x17000F86 RID: 3974
		// (get) Token: 0x06003F7C RID: 16252 RVA: 0x0005F5B4 File Offset: 0x0005D7B4
		// (set) Token: 0x06003F7D RID: 16253 RVA: 0x0005F5ED File Offset: 0x0005D7ED
		public FColorGradingSettings ColorGradingSettings
		{
			get
			{
				base.FastCheckIsValid();
				FColorGradingSettings result;
				if ((result = this._ColorGradingSettings) == null)
				{
					result = (this._ColorGradingSettings = new FColorGradingSettings(base.NativePtr + (IntPtr)AColorCorrectRegion.__PropertyOffset_ColorGradingSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FColorGradingSettings.StaticStruct(), base.NativePtr + (IntPtr)AColorCorrectRegion.__PropertyOffset_ColorGradingSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000F87 RID: 3975
		// (get) Token: 0x06003F7E RID: 16254 RVA: 0x0005F60E File Offset: 0x0005D80E
		// (set) Token: 0x06003F7F RID: 16255 RVA: 0x0005F61E File Offset: 0x0005D81E
		public unsafe bool Enabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AColorCorrectRegion.__PropertyOffset_Enabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AColorCorrectRegion.__PropertyOffset_Enabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000F88 RID: 3976
		// (get) Token: 0x06003F80 RID: 16256 RVA: 0x0005F62F File Offset: 0x0005D82F
		// (set) Token: 0x06003F81 RID: 16257 RVA: 0x0005F63F File Offset: 0x0005D83F
		public unsafe bool ExcludeStencil
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AColorCorrectRegion.__PropertyOffset_ExcludeStencil) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AColorCorrectRegion.__PropertyOffset_ExcludeStencil) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000F89 RID: 3977
		// (get) Token: 0x06003F82 RID: 16258 RVA: 0x0005F650 File Offset: 0x0005D850
		// (set) Token: 0x06003F83 RID: 16259 RVA: 0x0005F660 File Offset: 0x0005D860
		public unsafe bool DisableCharacter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AColorCorrectRegion.__PropertyOffset_DisableCharacter) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AColorCorrectRegion.__PropertyOffset_DisableCharacter) = (value ? 1 : 0);
			}
		}

		// Token: 0x06003F84 RID: 16260 RVA: 0x0005F671 File Offset: 0x0005D871
		static AColorCorrectRegion()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ColorCorrectRegions.ColorCorrectRegion");
		}

		// Token: 0x06003F85 RID: 16261 RVA: 0x0005F67F File Offset: 0x0005D87F
		protected AColorCorrectRegion(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001E00 RID: 7680
		public new const string __ObjectPath = "/Script/ColorCorrectRegions.ColorCorrectRegion";

		// Token: 0x04001E01 RID: 7681
		private static IntPtr _ClassPtr;

		// Token: 0x04001E02 RID: 7682
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001E03 RID: 7683
		internal static int __PropertyOffset_Type;

		// Token: 0x04001E04 RID: 7684
		internal static int __PropertyOffset_Priority;

		// Token: 0x04001E05 RID: 7685
		internal static int __PropertyOffset_Intensity;

		// Token: 0x04001E06 RID: 7686
		internal static int __PropertyOffset_Inner;

		// Token: 0x04001E07 RID: 7687
		internal static int __PropertyOffset_Outer;

		// Token: 0x04001E08 RID: 7688
		internal static int __PropertyOffset_Falloff;

		// Token: 0x04001E09 RID: 7689
		internal static int __PropertyOffset_Invert;

		// Token: 0x04001E0A RID: 7690
		internal static int __PropertyOffset_Temperature;

		// Token: 0x04001E0B RID: 7691
		internal static int __PropertyOffset_ColorGradingSettings;

		// Token: 0x04001E0C RID: 7692
		[Nullable(2)]
		private FColorGradingSettings _ColorGradingSettings;

		// Token: 0x04001E0D RID: 7693
		internal static int __PropertyOffset_Enabled;

		// Token: 0x04001E0E RID: 7694
		internal static int __PropertyOffset_ExcludeStencil;

		// Token: 0x04001E0F RID: 7695
		internal static int __PropertyOffset_DisableCharacter;
	}
}
