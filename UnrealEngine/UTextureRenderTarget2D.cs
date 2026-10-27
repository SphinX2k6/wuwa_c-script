using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011DF RID: 4575
	[UnrealObjectPath("/Script/Engine.TextureRenderTarget2D")]
	[UnrealStructLayout(4496, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4496)]
	public class UTextureRenderTarget2D : UTextureRenderTarget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010D7F RID: 68991 RVA: 0x0018BBB1 File Offset: 0x00189DB1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTextureRenderTarget2D._ClassPtr;
		}

		// Token: 0x06010D80 RID: 68992 RVA: 0x0018BBC0 File Offset: 0x00189DC0
		public UTextureRenderTarget2D() : this(BuiltinUtils.AllocNativeUObject(UTextureRenderTarget2D.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010D81 RID: 68993 RVA: 0x0018BBE8 File Offset: 0x00189DE8
		[NullableContext(1)]
		public UTextureRenderTarget2D(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTextureRenderTarget2D.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170041CC RID: 16844
		// (get) Token: 0x06010D82 RID: 68994 RVA: 0x0018BC1B File Offset: 0x00189E1B
		// (set) Token: 0x06010D83 RID: 68995 RVA: 0x0018BC2B File Offset: 0x00189E2B
		public unsafe int SizeX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_SizeX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_SizeX) = value;
			}
		}

		// Token: 0x170041CD RID: 16845
		// (get) Token: 0x06010D84 RID: 68996 RVA: 0x0018BC3C File Offset: 0x00189E3C
		// (set) Token: 0x06010D85 RID: 68997 RVA: 0x0018BC4C File Offset: 0x00189E4C
		public unsafe int SizeY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_SizeY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_SizeY) = value;
			}
		}

		// Token: 0x170041CE RID: 16846
		// (get) Token: 0x06010D86 RID: 68998 RVA: 0x0018BC60 File Offset: 0x00189E60
		// (set) Token: 0x06010D87 RID: 68999 RVA: 0x0018BC99 File Offset: 0x00189E99
		[Nullable(1)]
		public FPerPlatformInt KuroSizeX
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FPerPlatformInt result;
				if ((result = this._KuroSizeX) == null)
				{
					result = (this._KuroSizeX = new FPerPlatformInt(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_KuroSizeX, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformInt.StaticStruct(), base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_KuroSizeX, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170041CF RID: 16847
		// (get) Token: 0x06010D88 RID: 69000 RVA: 0x0018BCBC File Offset: 0x00189EBC
		// (set) Token: 0x06010D89 RID: 69001 RVA: 0x0018BCF5 File Offset: 0x00189EF5
		[Nullable(1)]
		public FPerPlatformInt KuroSizeY
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FPerPlatformInt result;
				if ((result = this._KuroSizeY) == null)
				{
					result = (this._KuroSizeY = new FPerPlatformInt(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_KuroSizeY, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformInt.StaticStruct(), base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_KuroSizeY, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170041D0 RID: 16848
		// (get) Token: 0x06010D8A RID: 69002 RVA: 0x0018BD18 File Offset: 0x00189F18
		// (set) Token: 0x06010D8B RID: 69003 RVA: 0x0018BD51 File Offset: 0x00189F51
		[Nullable(1)]
		public FPerPlatformInt KuroSizeDownScale_Level3
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FPerPlatformInt result;
				if ((result = this._KuroSizeDownScale_Level3) == null)
				{
					result = (this._KuroSizeDownScale_Level3 = new FPerPlatformInt(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_KuroSizeDownScale_Level3, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformInt.StaticStruct(), base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_KuroSizeDownScale_Level3, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170041D1 RID: 16849
		// (get) Token: 0x06010D8C RID: 69004 RVA: 0x0018BD74 File Offset: 0x00189F74
		// (set) Token: 0x06010D8D RID: 69005 RVA: 0x0018BDAD File Offset: 0x00189FAD
		[Nullable(1)]
		public FPerPlatformInt KuroSizeDownScale_Level2
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FPerPlatformInt result;
				if ((result = this._KuroSizeDownScale_Level2) == null)
				{
					result = (this._KuroSizeDownScale_Level2 = new FPerPlatformInt(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_KuroSizeDownScale_Level2, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformInt.StaticStruct(), base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_KuroSizeDownScale_Level2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170041D2 RID: 16850
		// (get) Token: 0x06010D8E RID: 69006 RVA: 0x0018BDD0 File Offset: 0x00189FD0
		// (set) Token: 0x06010D8F RID: 69007 RVA: 0x0018BE09 File Offset: 0x0018A009
		[Nullable(1)]
		public FPerPlatformInt KuroSizeDownScale_Level1
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FPerPlatformInt result;
				if ((result = this._KuroSizeDownScale_Level1) == null)
				{
					result = (this._KuroSizeDownScale_Level1 = new FPerPlatformInt(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_KuroSizeDownScale_Level1, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformInt.StaticStruct(), base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_KuroSizeDownScale_Level1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170041D3 RID: 16851
		// (get) Token: 0x06010D90 RID: 69008 RVA: 0x0018BE2C File Offset: 0x0018A02C
		// (set) Token: 0x06010D91 RID: 69009 RVA: 0x0018BE65 File Offset: 0x0018A065
		[Nullable(1)]
		public FPerPlatformInt KuroSizeDownScale_Level0
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FPerPlatformInt result;
				if ((result = this._KuroSizeDownScale_Level0) == null)
				{
					result = (this._KuroSizeDownScale_Level0 = new FPerPlatformInt(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_KuroSizeDownScale_Level0, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformInt.StaticStruct(), base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_KuroSizeDownScale_Level0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170041D4 RID: 16852
		// (get) Token: 0x06010D92 RID: 69010 RVA: 0x0018BE86 File Offset: 0x0018A086
		// (set) Token: 0x06010D93 RID: 69011 RVA: 0x0018BE9A File Offset: 0x0018A09A
		public unsafe FLinearColor ClearColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_ClearColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_ClearColor) = value;
			}
		}

		// Token: 0x170041D5 RID: 16853
		// (get) Token: 0x06010D94 RID: 69012 RVA: 0x0018BEAF File Offset: 0x0018A0AF
		// (set) Token: 0x06010D95 RID: 69013 RVA: 0x0018BEC3 File Offset: 0x0018A0C3
		public unsafe TEnumAsByte<TextureAddress> AddressX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_AddressX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_AddressX) = value;
			}
		}

		// Token: 0x170041D6 RID: 16854
		// (get) Token: 0x06010D96 RID: 69014 RVA: 0x0018BED8 File Offset: 0x0018A0D8
		// (set) Token: 0x06010D97 RID: 69015 RVA: 0x0018BEEC File Offset: 0x0018A0EC
		public unsafe TEnumAsByte<TextureAddress> AddressY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_AddressY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_AddressY) = value;
			}
		}

		// Token: 0x170041D7 RID: 16855
		// (get) Token: 0x06010D98 RID: 69016 RVA: 0x0018BF01 File Offset: 0x0018A101
		// (set) Token: 0x06010D99 RID: 69017 RVA: 0x0018BF1A File Offset: 0x0018A11A
		public unsafe bool bForceLinearGamma
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_bForceLinearGamma) & UTextureRenderTarget2D.__PropertyMask_bForceLinearGamma) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_bForceLinearGamma) = ((*(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_bForceLinearGamma) & ~UTextureRenderTarget2D.__PropertyMask_bForceLinearGamma) | (value ? UTextureRenderTarget2D.__PropertyMask_bForceLinearGamma : 0));
			}
		}

		// Token: 0x170041D8 RID: 16856
		// (get) Token: 0x06010D9A RID: 69018 RVA: 0x0018BF4A File Offset: 0x0018A14A
		// (set) Token: 0x06010D9B RID: 69019 RVA: 0x0018BF63 File Offset: 0x0018A163
		public unsafe bool bHDR_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_bHDR_DEPRECATED) & UTextureRenderTarget2D.__PropertyMask_bHDR_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_bHDR_DEPRECATED) = ((*(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_bHDR_DEPRECATED) & ~UTextureRenderTarget2D.__PropertyMask_bHDR_DEPRECATED) | (value ? UTextureRenderTarget2D.__PropertyMask_bHDR_DEPRECATED : 0));
			}
		}

		// Token: 0x170041D9 RID: 16857
		// (get) Token: 0x06010D9C RID: 69020 RVA: 0x0018BF93 File Offset: 0x0018A193
		// (set) Token: 0x06010D9D RID: 69021 RVA: 0x0018BFAC File Offset: 0x0018A1AC
		public unsafe bool bGPUSharedFlag
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_bGPUSharedFlag) & UTextureRenderTarget2D.__PropertyMask_bGPUSharedFlag) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_bGPUSharedFlag) = ((*(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_bGPUSharedFlag) & ~UTextureRenderTarget2D.__PropertyMask_bGPUSharedFlag) | (value ? UTextureRenderTarget2D.__PropertyMask_bGPUSharedFlag : 0));
			}
		}

		// Token: 0x170041DA RID: 16858
		// (get) Token: 0x06010D9E RID: 69022 RVA: 0x0018BFDC File Offset: 0x0018A1DC
		// (set) Token: 0x06010D9F RID: 69023 RVA: 0x0018BFF0 File Offset: 0x0018A1F0
		public unsafe TEnumAsByte<ETextureRenderTargetFormat> RenderTargetFormat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_RenderTargetFormat);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_RenderTargetFormat) = value;
			}
		}

		// Token: 0x170041DB RID: 16859
		// (get) Token: 0x06010DA0 RID: 69024 RVA: 0x0018C005 File Offset: 0x0018A205
		// (set) Token: 0x06010DA1 RID: 69025 RVA: 0x0018C01E File Offset: 0x0018A21E
		public unsafe bool bAutoGenerateMips
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_bAutoGenerateMips) & UTextureRenderTarget2D.__PropertyMask_bAutoGenerateMips) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_bAutoGenerateMips) = ((*(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_bAutoGenerateMips) & ~UTextureRenderTarget2D.__PropertyMask_bAutoGenerateMips) | (value ? UTextureRenderTarget2D.__PropertyMask_bAutoGenerateMips : 0));
			}
		}

		// Token: 0x170041DC RID: 16860
		// (get) Token: 0x06010DA2 RID: 69026 RVA: 0x0018C04E File Offset: 0x0018A24E
		// (set) Token: 0x06010DA3 RID: 69027 RVA: 0x0018C062 File Offset: 0x0018A262
		public unsafe TEnumAsByte<TextureFilter> MipsSamplerFilter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_MipsSamplerFilter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_MipsSamplerFilter) = value;
			}
		}

		// Token: 0x170041DD RID: 16861
		// (get) Token: 0x06010DA4 RID: 69028 RVA: 0x0018C077 File Offset: 0x0018A277
		// (set) Token: 0x06010DA5 RID: 69029 RVA: 0x0018C08B File Offset: 0x0018A28B
		public unsafe TEnumAsByte<TextureAddress> MipsAddressU
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_MipsAddressU);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_MipsAddressU) = value;
			}
		}

		// Token: 0x170041DE RID: 16862
		// (get) Token: 0x06010DA6 RID: 69030 RVA: 0x0018C0A0 File Offset: 0x0018A2A0
		// (set) Token: 0x06010DA7 RID: 69031 RVA: 0x0018C0B4 File Offset: 0x0018A2B4
		public unsafe TEnumAsByte<TextureAddress> MipsAddressV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_MipsAddressV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_MipsAddressV) = value;
			}
		}

		// Token: 0x170041DF RID: 16863
		// (get) Token: 0x06010DA8 RID: 69032 RVA: 0x0018C0C9 File Offset: 0x0018A2C9
		// (set) Token: 0x06010DA9 RID: 69033 RVA: 0x0018C0DD File Offset: 0x0018A2DD
		public unsafe TEnumAsByte<EPixelFormat> OverrideFormat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_OverrideFormat);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_OverrideFormat) = value;
			}
		}

		// Token: 0x06010DAA RID: 69034 RVA: 0x0018C0F2 File Offset: 0x0018A2F2
		static UTextureRenderTarget2D()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.TextureRenderTarget2D");
		}

		// Token: 0x06010DAB RID: 69035 RVA: 0x0018C100 File Offset: 0x0018A300
		protected UTextureRenderTarget2D(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400906B RID: 36971
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.TextureRenderTarget2D";

		// Token: 0x0400906C RID: 36972
		private static IntPtr _ClassPtr;

		// Token: 0x0400906D RID: 36973
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400906E RID: 36974
		internal static int __PropertyOffset_SizeX;

		// Token: 0x0400906F RID: 36975
		internal static int __PropertyOffset_SizeY;

		// Token: 0x04009070 RID: 36976
		internal static int __PropertyOffset_KuroSizeX;

		// Token: 0x04009071 RID: 36977
		[Nullable(2)]
		private FPerPlatformInt _KuroSizeX;

		// Token: 0x04009072 RID: 36978
		internal static int __PropertyOffset_KuroSizeY;

		// Token: 0x04009073 RID: 36979
		[Nullable(2)]
		private FPerPlatformInt _KuroSizeY;

		// Token: 0x04009074 RID: 36980
		internal static int __PropertyOffset_KuroSizeDownScale_Level3;

		// Token: 0x04009075 RID: 36981
		[Nullable(2)]
		private FPerPlatformInt _KuroSizeDownScale_Level3;

		// Token: 0x04009076 RID: 36982
		internal static int __PropertyOffset_KuroSizeDownScale_Level2;

		// Token: 0x04009077 RID: 36983
		[Nullable(2)]
		private FPerPlatformInt _KuroSizeDownScale_Level2;

		// Token: 0x04009078 RID: 36984
		internal static int __PropertyOffset_KuroSizeDownScale_Level1;

		// Token: 0x04009079 RID: 36985
		[Nullable(2)]
		private FPerPlatformInt _KuroSizeDownScale_Level1;

		// Token: 0x0400907A RID: 36986
		internal static int __PropertyOffset_KuroSizeDownScale_Level0;

		// Token: 0x0400907B RID: 36987
		[Nullable(2)]
		private FPerPlatformInt _KuroSizeDownScale_Level0;

		// Token: 0x0400907C RID: 36988
		internal static int __PropertyOffset_ClearColor;

		// Token: 0x0400907D RID: 36989
		internal static int __PropertyOffset_AddressX;

		// Token: 0x0400907E RID: 36990
		internal static int __PropertyOffset_AddressY;

		// Token: 0x0400907F RID: 36991
		internal static int __PropertyOffset_bForceLinearGamma;

		// Token: 0x04009080 RID: 36992
		internal static byte __PropertyMask_bForceLinearGamma;

		// Token: 0x04009081 RID: 36993
		internal static int __PropertyOffset_bHDR_DEPRECATED;

		// Token: 0x04009082 RID: 36994
		internal static byte __PropertyMask_bHDR_DEPRECATED;

		// Token: 0x04009083 RID: 36995
		internal static int __PropertyOffset_bGPUSharedFlag;

		// Token: 0x04009084 RID: 36996
		internal static byte __PropertyMask_bGPUSharedFlag;

		// Token: 0x04009085 RID: 36997
		internal static int __PropertyOffset_RenderTargetFormat;

		// Token: 0x04009086 RID: 36998
		internal static int __PropertyOffset_bAutoGenerateMips;

		// Token: 0x04009087 RID: 36999
		internal static byte __PropertyMask_bAutoGenerateMips;

		// Token: 0x04009088 RID: 37000
		internal static int __PropertyOffset_MipsSamplerFilter;

		// Token: 0x04009089 RID: 37001
		internal static int __PropertyOffset_MipsAddressU;

		// Token: 0x0400908A RID: 37002
		internal static int __PropertyOffset_MipsAddressV;

		// Token: 0x0400908B RID: 37003
		internal static int __PropertyOffset_OverrideFormat;
	}
}
