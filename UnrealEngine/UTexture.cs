using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011CC RID: 4556
	[UnrealObjectPath("/Script/Engine.Texture")]
	[UnrealStructLayout(3920, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3920)]
	public abstract class UTexture : UStreamableRenderAsset, IUnrealUObject, IUnrealObject, IInterface_AssetUserData, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06010CAD RID: 68781 RVA: 0x0018A844 File Offset: 0x00188A44
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTexture._ClassPtr;
		}

		// Token: 0x06010CAE RID: 68782 RVA: 0x0018A850 File Offset: 0x00188A50
		int IInterface_AssetUserData.InterfaceOffset()
		{
			return UTexture.__InterfaceOffset_IInterface_AssetUserData;
		}

		// Token: 0x1700418B RID: 16779
		// (get) Token: 0x06010CAF RID: 68783 RVA: 0x0018A857 File Offset: 0x00188A57
		// (set) Token: 0x06010CB0 RID: 68784 RVA: 0x0018A86B File Offset: 0x00188A6B
		public unsafe FGuid LightingGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_LightingGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_LightingGuid) = value;
			}
		}

		// Token: 0x1700418C RID: 16780
		// (get) Token: 0x06010CB1 RID: 68785 RVA: 0x0018A880 File Offset: 0x00188A80
		// (set) Token: 0x06010CB2 RID: 68786 RVA: 0x0018A890 File Offset: 0x00188A90
		public unsafe int LODBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_LODBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_LODBias) = value;
			}
		}

		// Token: 0x1700418D RID: 16781
		// (get) Token: 0x06010CB3 RID: 68787 RVA: 0x0018A8A1 File Offset: 0x00188AA1
		// (set) Token: 0x06010CB4 RID: 68788 RVA: 0x0018A8B5 File Offset: 0x00188AB5
		public unsafe TEnumAsByte<TextureCompressionSettings> CompressionSettings
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_CompressionSettings);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_CompressionSettings) = value;
			}
		}

		// Token: 0x1700418E RID: 16782
		// (get) Token: 0x06010CB5 RID: 68789 RVA: 0x0018A8CA File Offset: 0x00188ACA
		// (set) Token: 0x06010CB6 RID: 68790 RVA: 0x0018A8DE File Offset: 0x00188ADE
		public unsafe TEnumAsByte<TextureFilter> Filter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_Filter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_Filter) = value;
			}
		}

		// Token: 0x1700418F RID: 16783
		// (get) Token: 0x06010CB7 RID: 68791 RVA: 0x0018A8F3 File Offset: 0x00188AF3
		// (set) Token: 0x06010CB8 RID: 68792 RVA: 0x0018A903 File Offset: 0x00188B03
		public unsafe bool IsCreateAsync
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_IsCreateAsync) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_IsCreateAsync) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004190 RID: 16784
		// (get) Token: 0x06010CB9 RID: 68793 RVA: 0x0018A914 File Offset: 0x00188B14
		// (set) Token: 0x06010CBA RID: 68794 RVA: 0x0018A924 File Offset: 0x00188B24
		public unsafe bool IsForceKeepMipsData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_IsForceKeepMipsData) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_IsForceKeepMipsData) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004191 RID: 16785
		// (get) Token: 0x06010CBB RID: 68795 RVA: 0x0018A935 File Offset: 0x00188B35
		// (set) Token: 0x06010CBC RID: 68796 RVA: 0x0018A945 File Offset: 0x00188B45
		public unsafe ETextureMipLoadOptions MipLoadOptions
		{
			get
			{
				return (ETextureMipLoadOptions)(*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_MipLoadOptions));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_MipLoadOptions) = (byte)value;
			}
		}

		// Token: 0x17004192 RID: 16786
		// (get) Token: 0x06010CBD RID: 68797 RVA: 0x0018A956 File Offset: 0x00188B56
		// (set) Token: 0x06010CBE RID: 68798 RVA: 0x0018A96A File Offset: 0x00188B6A
		public unsafe TEnumAsByte<TextureGroup> LODGroup
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_LODGroup);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_LODGroup) = value;
			}
		}

		// Token: 0x17004193 RID: 16787
		// (get) Token: 0x06010CBF RID: 68799 RVA: 0x0018A980 File Offset: 0x00188B80
		// (set) Token: 0x06010CC0 RID: 68800 RVA: 0x0018A9B9 File Offset: 0x00188BB9
		[Nullable(1)]
		public FPerPlatformFloat Downscale
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FPerPlatformFloat result;
				if ((result = this._Downscale) == null)
				{
					result = (this._Downscale = new FPerPlatformFloat(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_Downscale, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformFloat.StaticStruct(), base.NativePtr + (IntPtr)UTexture.__PropertyOffset_Downscale, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004194 RID: 16788
		// (get) Token: 0x06010CC1 RID: 68801 RVA: 0x0018A9DA File Offset: 0x00188BDA
		// (set) Token: 0x06010CC2 RID: 68802 RVA: 0x0018A9EA File Offset: 0x00188BEA
		public unsafe ETextureDownscaleOptions DownscaleOptions
		{
			get
			{
				return (ETextureDownscaleOptions)(*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_DownscaleOptions));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_DownscaleOptions) = (byte)value;
			}
		}

		// Token: 0x17004195 RID: 16789
		// (get) Token: 0x06010CC3 RID: 68803 RVA: 0x0018A9FC File Offset: 0x00188BFC
		// (set) Token: 0x06010CC4 RID: 68804 RVA: 0x0018AA35 File Offset: 0x00188C35
		[Nullable(1)]
		public FPerPlatformFloat KuroTextureSizeScale
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FPerPlatformFloat result;
				if ((result = this._KuroTextureSizeScale) == null)
				{
					result = (this._KuroTextureSizeScale = new FPerPlatformFloat(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_KuroTextureSizeScale, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformFloat.StaticStruct(), base.NativePtr + (IntPtr)UTexture.__PropertyOffset_KuroTextureSizeScale, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004196 RID: 16790
		// (get) Token: 0x06010CC5 RID: 68805 RVA: 0x0018AA56 File Offset: 0x00188C56
		// (set) Token: 0x06010CC6 RID: 68806 RVA: 0x0018AA66 File Offset: 0x00188C66
		public unsafe bool bKuroScaleSizeFitForCompression
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_bKuroScaleSizeFitForCompression) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_bKuroScaleSizeFitForCompression) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004197 RID: 16791
		// (get) Token: 0x06010CC7 RID: 68807 RVA: 0x0018AA78 File Offset: 0x00188C78
		// (set) Token: 0x06010CC8 RID: 68808 RVA: 0x0018AAB1 File Offset: 0x00188CB1
		[Nullable(1)]
		public FPerPlatformInt MinInitRequestMip
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FPerPlatformInt result;
				if ((result = this._MinInitRequestMip) == null)
				{
					result = (this._MinInitRequestMip = new FPerPlatformInt(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_MinInitRequestMip, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformInt.StaticStruct(), base.NativePtr + (IntPtr)UTexture.__PropertyOffset_MinInitRequestMip, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004198 RID: 16792
		// (get) Token: 0x06010CC9 RID: 68809 RVA: 0x0018AAD2 File Offset: 0x00188CD2
		// (set) Token: 0x06010CCA RID: 68810 RVA: 0x0018AAEB File Offset: 0x00188CEB
		public unsafe bool SRGB
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_SRGB) & UTexture.__PropertyMask_SRGB) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UTexture.__PropertyOffset_SRGB) = ((*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_SRGB) & ~UTexture.__PropertyMask_SRGB) | (value ? UTexture.__PropertyMask_SRGB : 0));
			}
		}

		// Token: 0x17004199 RID: 16793
		// (get) Token: 0x06010CCB RID: 68811 RVA: 0x0018AB1B File Offset: 0x00188D1B
		// (set) Token: 0x06010CCC RID: 68812 RVA: 0x0018AB34 File Offset: 0x00188D34
		public unsafe bool bNoTiling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_bNoTiling) & UTexture.__PropertyMask_bNoTiling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UTexture.__PropertyOffset_bNoTiling) = ((*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_bNoTiling) & ~UTexture.__PropertyMask_bNoTiling) | (value ? UTexture.__PropertyMask_bNoTiling : 0));
			}
		}

		// Token: 0x1700419A RID: 16794
		// (get) Token: 0x06010CCD RID: 68813 RVA: 0x0018AB64 File Offset: 0x00188D64
		// (set) Token: 0x06010CCE RID: 68814 RVA: 0x0018AB7D File Offset: 0x00188D7D
		public unsafe bool VirtualTextureStreaming
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_VirtualTextureStreaming) & UTexture.__PropertyMask_VirtualTextureStreaming) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UTexture.__PropertyOffset_VirtualTextureStreaming) = ((*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_VirtualTextureStreaming) & ~UTexture.__PropertyMask_VirtualTextureStreaming) | (value ? UTexture.__PropertyMask_VirtualTextureStreaming : 0));
			}
		}

		// Token: 0x1700419B RID: 16795
		// (get) Token: 0x06010CCF RID: 68815 RVA: 0x0018ABAD File Offset: 0x00188DAD
		// (set) Token: 0x06010CD0 RID: 68816 RVA: 0x0018ABC6 File Offset: 0x00188DC6
		public unsafe bool CompressionYCoCg
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_CompressionYCoCg) & UTexture.__PropertyMask_CompressionYCoCg) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UTexture.__PropertyOffset_CompressionYCoCg) = ((*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_CompressionYCoCg) & ~UTexture.__PropertyMask_CompressionYCoCg) | (value ? UTexture.__PropertyMask_CompressionYCoCg : 0));
			}
		}

		// Token: 0x1700419C RID: 16796
		// (get) Token: 0x06010CD1 RID: 68817 RVA: 0x0018ABF6 File Offset: 0x00188DF6
		// (set) Token: 0x06010CD2 RID: 68818 RVA: 0x0018AC0F File Offset: 0x00188E0F
		public unsafe bool bNotCreateResource
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_bNotCreateResource) & UTexture.__PropertyMask_bNotCreateResource) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UTexture.__PropertyOffset_bNotCreateResource) = ((*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_bNotCreateResource) & ~UTexture.__PropertyMask_bNotCreateResource) | (value ? UTexture.__PropertyMask_bNotCreateResource : 0));
			}
		}

		// Token: 0x1700419D RID: 16797
		// (get) Token: 0x06010CD3 RID: 68819 RVA: 0x0018AC3F File Offset: 0x00188E3F
		// (set) Token: 0x06010CD4 RID: 68820 RVA: 0x0018AC58 File Offset: 0x00188E58
		public unsafe bool bNotOfflineProcessed
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_bNotOfflineProcessed) & UTexture.__PropertyMask_bNotOfflineProcessed) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UTexture.__PropertyOffset_bNotOfflineProcessed) = ((*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_bNotOfflineProcessed) & ~UTexture.__PropertyMask_bNotOfflineProcessed) | (value ? UTexture.__PropertyMask_bNotOfflineProcessed : 0));
			}
		}

		// Token: 0x1700419E RID: 16798
		// (get) Token: 0x06010CD5 RID: 68821 RVA: 0x0018AC88 File Offset: 0x00188E88
		// (set) Token: 0x06010CD6 RID: 68822 RVA: 0x0018ACA1 File Offset: 0x00188EA1
		public unsafe bool bAsyncResourceReleaseHasBeenStarted
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_bAsyncResourceReleaseHasBeenStarted) & UTexture.__PropertyMask_bAsyncResourceReleaseHasBeenStarted) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UTexture.__PropertyOffset_bAsyncResourceReleaseHasBeenStarted) = ((*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_bAsyncResourceReleaseHasBeenStarted) & ~UTexture.__PropertyMask_bAsyncResourceReleaseHasBeenStarted) | (value ? UTexture.__PropertyMask_bAsyncResourceReleaseHasBeenStarted : 0));
			}
		}

		// Token: 0x1700419F RID: 16799
		// (get) Token: 0x06010CD7 RID: 68823 RVA: 0x0018ACD4 File Offset: 0x00188ED4
		// (set) Token: 0x06010CD8 RID: 68824 RVA: 0x0018AD0D File Offset: 0x00188F0D
		[Nullable(1)]
		public TArray<UAssetUserData> AssetUserData
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UAssetUserData> result;
				if ((result = this._AssetUserData) == null)
				{
					result = (this._AssetUserData = new TArray<UAssetUserData>(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_AssetUserData, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.AssetUserData.CopyAssign(value);
			}
		}

		// Token: 0x06010CD9 RID: 68825 RVA: 0x0018AD1B File Offset: 0x00188F1B
		static UTexture()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Texture");
		}

		// Token: 0x06010CDA RID: 68826 RVA: 0x0018AD2C File Offset: 0x00188F2C
		protected UTexture() : this(BuiltinUtils.AllocNativeUObject(UTexture.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010CDB RID: 68827 RVA: 0x0018AD54 File Offset: 0x00188F54
		protected UTexture(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008F88 RID: 36744
		internal static int __InterfaceOffset_IInterface_AssetUserData;

		// Token: 0x04008F89 RID: 36745
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.Texture";

		// Token: 0x04008F8A RID: 36746
		private static IntPtr _ClassPtr;

		// Token: 0x04008F8B RID: 36747
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008F8C RID: 36748
		internal static int __PropertyOffset_LightingGuid;

		// Token: 0x04008F8D RID: 36749
		internal static int __PropertyOffset_LODBias;

		// Token: 0x04008F8E RID: 36750
		internal static int __PropertyOffset_CompressionSettings;

		// Token: 0x04008F8F RID: 36751
		internal static int __PropertyOffset_Filter;

		// Token: 0x04008F90 RID: 36752
		internal static int __PropertyOffset_IsCreateAsync;

		// Token: 0x04008F91 RID: 36753
		internal static int __PropertyOffset_IsForceKeepMipsData;

		// Token: 0x04008F92 RID: 36754
		internal static int __PropertyOffset_MipLoadOptions;

		// Token: 0x04008F93 RID: 36755
		internal static int __PropertyOffset_LODGroup;

		// Token: 0x04008F94 RID: 36756
		internal static int __PropertyOffset_Downscale;

		// Token: 0x04008F95 RID: 36757
		[Nullable(2)]
		private FPerPlatformFloat _Downscale;

		// Token: 0x04008F96 RID: 36758
		internal static int __PropertyOffset_DownscaleOptions;

		// Token: 0x04008F97 RID: 36759
		internal static int __PropertyOffset_KuroTextureSizeScale;

		// Token: 0x04008F98 RID: 36760
		[Nullable(2)]
		private FPerPlatformFloat _KuroTextureSizeScale;

		// Token: 0x04008F99 RID: 36761
		internal static int __PropertyOffset_bKuroScaleSizeFitForCompression;

		// Token: 0x04008F9A RID: 36762
		internal static int __PropertyOffset_MinInitRequestMip;

		// Token: 0x04008F9B RID: 36763
		[Nullable(2)]
		private FPerPlatformInt _MinInitRequestMip;

		// Token: 0x04008F9C RID: 36764
		internal static int __PropertyOffset_SRGB;

		// Token: 0x04008F9D RID: 36765
		internal static byte __PropertyMask_SRGB;

		// Token: 0x04008F9E RID: 36766
		internal static int __PropertyOffset_bNoTiling;

		// Token: 0x04008F9F RID: 36767
		internal static byte __PropertyMask_bNoTiling;

		// Token: 0x04008FA0 RID: 36768
		internal static int __PropertyOffset_VirtualTextureStreaming;

		// Token: 0x04008FA1 RID: 36769
		internal static byte __PropertyMask_VirtualTextureStreaming;

		// Token: 0x04008FA2 RID: 36770
		internal static int __PropertyOffset_CompressionYCoCg;

		// Token: 0x04008FA3 RID: 36771
		internal static byte __PropertyMask_CompressionYCoCg;

		// Token: 0x04008FA4 RID: 36772
		internal static int __PropertyOffset_bNotCreateResource;

		// Token: 0x04008FA5 RID: 36773
		internal static byte __PropertyMask_bNotCreateResource;

		// Token: 0x04008FA6 RID: 36774
		internal static int __PropertyOffset_bNotOfflineProcessed;

		// Token: 0x04008FA7 RID: 36775
		internal static byte __PropertyMask_bNotOfflineProcessed;

		// Token: 0x04008FA8 RID: 36776
		internal static int __PropertyOffset_bAsyncResourceReleaseHasBeenStarted;

		// Token: 0x04008FA9 RID: 36777
		internal static byte __PropertyMask_bAsyncResourceReleaseHasBeenStarted;

		// Token: 0x04008FAA RID: 36778
		internal static int __PropertyOffset_AssetUserData;

		// Token: 0x04008FAB RID: 36779
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAssetUserData> _AssetUserData;
	}
}
