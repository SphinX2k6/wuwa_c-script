using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D14 RID: 3348
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KuroTextureFolderCheckConfig")]
	[UnrealStructLayout(672, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 672)]
	public class FKuroTextureFolderCheckConfig : FKuroBaseFolderCheckConfig, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B319 RID: 45849 RVA: 0x000FF24C File Offset: 0x000FD44C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroTextureFolderCheckConfig._ScriptStructPtr != 0) ? FKuroTextureFolderCheckConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroTextureFolderCheckConfig", ref FKuroTextureFolderCheckConfig._ScriptStructPtr);
		}

		// Token: 0x170028D4 RID: 10452
		// (get) Token: 0x0600B31A RID: 45850 RVA: 0x000FF270 File Offset: 0x000FD470
		// (set) Token: 0x0600B31B RID: 45851 RVA: 0x000FF280 File Offset: 0x000FD480
		public unsafe int SizeX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_SizeX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_SizeX) = value;
			}
		}

		// Token: 0x170028D5 RID: 10453
		// (get) Token: 0x0600B31C RID: 45852 RVA: 0x000FF291 File Offset: 0x000FD491
		// (set) Token: 0x0600B31D RID: 45853 RVA: 0x000FF2A1 File Offset: 0x000FD4A1
		public unsafe int SizeY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_SizeY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_SizeY) = value;
			}
		}

		// Token: 0x170028D6 RID: 10454
		// (get) Token: 0x0600B31E RID: 45854 RVA: 0x000FF2B2 File Offset: 0x000FD4B2
		// (set) Token: 0x0600B31F RID: 45855 RVA: 0x000FF2C2 File Offset: 0x000FD4C2
		public unsafe byte bVatTexCheck
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_bVatTexCheck);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_bVatTexCheck) = value;
			}
		}

		// Token: 0x170028D7 RID: 10455
		// (get) Token: 0x0600B320 RID: 45856 RVA: 0x000FF2D3 File Offset: 0x000FD4D3
		// (set) Token: 0x0600B321 RID: 45857 RVA: 0x000FF2E3 File Offset: 0x000FD4E3
		public unsafe int SetSizeX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_SetSizeX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_SetSizeX) = value;
			}
		}

		// Token: 0x170028D8 RID: 10456
		// (get) Token: 0x0600B322 RID: 45858 RVA: 0x000FF2F4 File Offset: 0x000FD4F4
		// (set) Token: 0x0600B323 RID: 45859 RVA: 0x000FF304 File Offset: 0x000FD504
		public unsafe int SetSizeY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_SetSizeY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_SetSizeY) = value;
			}
		}

		// Token: 0x170028D9 RID: 10457
		// (get) Token: 0x0600B324 RID: 45860 RVA: 0x000FF315 File Offset: 0x000FD515
		// (set) Token: 0x0600B325 RID: 45861 RVA: 0x000FF325 File Offset: 0x000FD525
		public unsafe int MinSizeX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_MinSizeX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_MinSizeX) = value;
			}
		}

		// Token: 0x170028DA RID: 10458
		// (get) Token: 0x0600B326 RID: 45862 RVA: 0x000FF338 File Offset: 0x000FD538
		// (set) Token: 0x0600B327 RID: 45863 RVA: 0x000FF37B File Offset: 0x000FD57B
		public TArray<string> Format
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Format) == null)
				{
					result = (this._Format = new TArray<string>(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_Format, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Format.CopyAssign(value);
			}
		}

		// Token: 0x170028DB RID: 10459
		// (get) Token: 0x0600B328 RID: 45864 RVA: 0x000FF389 File Offset: 0x000FD589
		// (set) Token: 0x0600B329 RID: 45865 RVA: 0x000FF39D File Offset: 0x000FD59D
		public unsafe string CompressionQuality
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_CompressionQuality)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_CompressionQuality)), value);
			}
		}

		// Token: 0x170028DC RID: 10460
		// (get) Token: 0x0600B32A RID: 45866 RVA: 0x000FF3B2 File Offset: 0x000FD5B2
		// (set) Token: 0x0600B32B RID: 45867 RVA: 0x000FF3C6 File Offset: 0x000FD5C6
		public unsafe string MinCompressionQuality
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_MinCompressionQuality)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_MinCompressionQuality)), value);
			}
		}

		// Token: 0x170028DD RID: 10461
		// (get) Token: 0x0600B32C RID: 45868 RVA: 0x000FF3DB File Offset: 0x000FD5DB
		// (set) Token: 0x0600B32D RID: 45869 RVA: 0x000FF3EF File Offset: 0x000FD5EF
		public unsafe string AddressingMode
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_AddressingMode)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_AddressingMode)), value);
			}
		}

		// Token: 0x170028DE RID: 10462
		// (get) Token: 0x0600B32E RID: 45870 RVA: 0x000FF404 File Offset: 0x000FD604
		// (set) Token: 0x0600B32F RID: 45871 RVA: 0x000FF418 File Offset: 0x000FD618
		public unsafe string MipLoadOptions
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_MipLoadOptions)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_MipLoadOptions)), value);
			}
		}

		// Token: 0x170028DF RID: 10463
		// (get) Token: 0x0600B330 RID: 45872 RVA: 0x000FF42D File Offset: 0x000FD62D
		// (set) Token: 0x0600B331 RID: 45873 RVA: 0x000FF441 File Offset: 0x000FD641
		public unsafe string TextureGroup
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_TextureGroup)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_TextureGroup)), value);
			}
		}

		// Token: 0x170028E0 RID: 10464
		// (get) Token: 0x0600B332 RID: 45874 RVA: 0x000FF458 File Offset: 0x000FD658
		// (set) Token: 0x0600B333 RID: 45875 RVA: 0x000FF49B File Offset: 0x000FD69B
		public TArray<string> TextureGroups
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._TextureGroups) == null)
				{
					result = (this._TextureGroups = new TArray<string>(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_TextureGroups, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TextureGroups.CopyAssign(value);
			}
		}

		// Token: 0x170028E1 RID: 10465
		// (get) Token: 0x0600B334 RID: 45876 RVA: 0x000FF4AC File Offset: 0x000FD6AC
		// (set) Token: 0x0600B335 RID: 45877 RVA: 0x000FF4EF File Offset: 0x000FD6EF
		public TArray<string> MipGenSetting
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._MipGenSetting) == null)
				{
					result = (this._MipGenSetting = new TArray<string>(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_MipGenSetting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MipGenSetting.CopyAssign(value);
			}
		}

		// Token: 0x170028E2 RID: 10466
		// (get) Token: 0x0600B336 RID: 45878 RVA: 0x000FF500 File Offset: 0x000FD700
		// (set) Token: 0x0600B337 RID: 45879 RVA: 0x000FF543 File Offset: 0x000FD743
		public TArray<float> AlphaCoverageThresholds
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._AlphaCoverageThresholds) == null)
				{
					result = (this._AlphaCoverageThresholds = new TArray<float>(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_AlphaCoverageThresholds, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AlphaCoverageThresholds.CopyAssign(value);
			}
		}

		// Token: 0x170028E3 RID: 10467
		// (get) Token: 0x0600B338 RID: 45880 RVA: 0x000FF554 File Offset: 0x000FD754
		// (set) Token: 0x0600B339 RID: 45881 RVA: 0x000FF597 File Offset: 0x000FD797
		public TArray<string> DownScalePlatform
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._DownScalePlatform) == null)
				{
					result = (this._DownScalePlatform = new TArray<string>(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_DownScalePlatform, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DownScalePlatform.CopyAssign(value);
			}
		}

		// Token: 0x170028E4 RID: 10468
		// (get) Token: 0x0600B33A RID: 45882 RVA: 0x000FF5A8 File Offset: 0x000FD7A8
		// (set) Token: 0x0600B33B RID: 45883 RVA: 0x000FF5EB File Offset: 0x000FD7EB
		public TArray<float> DownScaleValue
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._DownScaleValue) == null)
				{
					result = (this._DownScaleValue = new TArray<float>(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_DownScaleValue, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DownScaleValue.CopyAssign(value);
			}
		}

		// Token: 0x170028E5 RID: 10469
		// (get) Token: 0x0600B33C RID: 45884 RVA: 0x000FF5F9 File Offset: 0x000FD7F9
		// (set) Token: 0x0600B33D RID: 45885 RVA: 0x000FF609 File Offset: 0x000FD809
		public unsafe int StreamingBoostFactor_Default
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_StreamingBoostFactor_Default);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_StreamingBoostFactor_Default) = value;
			}
		}

		// Token: 0x170028E6 RID: 10470
		// (get) Token: 0x0600B33E RID: 45886 RVA: 0x000FF61C File Offset: 0x000FD81C
		// (set) Token: 0x0600B33F RID: 45887 RVA: 0x000FF65F File Offset: 0x000FD85F
		public TArray<string> StreamingBoostFactor_Platform
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._StreamingBoostFactor_Platform) == null)
				{
					result = (this._StreamingBoostFactor_Platform = new TArray<string>(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_StreamingBoostFactor_Platform, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StreamingBoostFactor_Platform.CopyAssign(value);
			}
		}

		// Token: 0x170028E7 RID: 10471
		// (get) Token: 0x0600B340 RID: 45888 RVA: 0x000FF670 File Offset: 0x000FD870
		// (set) Token: 0x0600B341 RID: 45889 RVA: 0x000FF6B3 File Offset: 0x000FD8B3
		public TArray<int> StreamingBoostFactor_PlatformValue
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._StreamingBoostFactor_PlatformValue) == null)
				{
					result = (this._StreamingBoostFactor_PlatformValue = new TArray<int>(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_StreamingBoostFactor_PlatformValue, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StreamingBoostFactor_PlatformValue.CopyAssign(value);
			}
		}

		// Token: 0x170028E8 RID: 10472
		// (get) Token: 0x0600B342 RID: 45890 RVA: 0x000FF6C4 File Offset: 0x000FD8C4
		// (set) Token: 0x0600B343 RID: 45891 RVA: 0x000FF707 File Offset: 0x000FD907
		public TArray<float> DownDefaultScaleValue
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._DownDefaultScaleValue) == null)
				{
					result = (this._DownDefaultScaleValue = new TArray<float>(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_DownDefaultScaleValue, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DownDefaultScaleValue.CopyAssign(value);
			}
		}

		// Token: 0x170028E9 RID: 10473
		// (get) Token: 0x0600B344 RID: 45892 RVA: 0x000FF718 File Offset: 0x000FD918
		// (set) Token: 0x0600B345 RID: 45893 RVA: 0x000FF75B File Offset: 0x000FD95B
		public TArray<string> DeviceLevelExtraLodBiasPlatform
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._DeviceLevelExtraLodBiasPlatform) == null)
				{
					result = (this._DeviceLevelExtraLodBiasPlatform = new TArray<string>(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_DeviceLevelExtraLodBiasPlatform, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DeviceLevelExtraLodBiasPlatform.CopyAssign(value);
			}
		}

		// Token: 0x170028EA RID: 10474
		// (get) Token: 0x0600B346 RID: 45894 RVA: 0x000FF76C File Offset: 0x000FD96C
		// (set) Token: 0x0600B347 RID: 45895 RVA: 0x000FF7AF File Offset: 0x000FD9AF
		public TArray<int> DeviceLevelExtraLodBias
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._DeviceLevelExtraLodBias) == null)
				{
					result = (this._DeviceLevelExtraLodBias = new TArray<int>(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_DeviceLevelExtraLodBias, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DeviceLevelExtraLodBias.CopyAssign(value);
			}
		}

		// Token: 0x170028EB RID: 10475
		// (get) Token: 0x0600B348 RID: 45896 RVA: 0x000FF7C0 File Offset: 0x000FD9C0
		// (set) Token: 0x0600B349 RID: 45897 RVA: 0x000FF803 File Offset: 0x000FDA03
		public TArray<int> DeviceLevelExtraLodBiasEffectedLevel
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._DeviceLevelExtraLodBiasEffectedLevel) == null)
				{
					result = (this._DeviceLevelExtraLodBiasEffectedLevel = new TArray<int>(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_DeviceLevelExtraLodBiasEffectedLevel, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DeviceLevelExtraLodBiasEffectedLevel.CopyAssign(value);
			}
		}

		// Token: 0x170028EC RID: 10476
		// (get) Token: 0x0600B34A RID: 45898 RVA: 0x000FF811 File Offset: 0x000FDA11
		// (set) Token: 0x0600B34B RID: 45899 RVA: 0x000FF821 File Offset: 0x000FDA21
		public unsafe int TexBiasStrictCheckSizeThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_TexBiasStrictCheckSizeThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_TexBiasStrictCheckSizeThreshold) = value;
			}
		}

		// Token: 0x170028ED RID: 10477
		// (get) Token: 0x0600B34C RID: 45900 RVA: 0x000FF834 File Offset: 0x000FDA34
		// (set) Token: 0x0600B34D RID: 45901 RVA: 0x000FF877 File Offset: 0x000FDA77
		public TArray<int> RuntimeLODBias
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._RuntimeLODBias) == null)
				{
					result = (this._RuntimeLODBias = new TArray<int>(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_RuntimeLODBias, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RuntimeLODBias.CopyAssign(value);
			}
		}

		// Token: 0x170028EE RID: 10478
		// (get) Token: 0x0600B34E RID: 45902 RVA: 0x000FF888 File Offset: 0x000FDA88
		// (set) Token: 0x0600B34F RID: 45903 RVA: 0x000FF8CB File Offset: 0x000FDACB
		public TArray<int> KuroRuntimeLODBias_OpenWorld
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._KuroRuntimeLODBias_OpenWorld) == null)
				{
					result = (this._KuroRuntimeLODBias_OpenWorld = new TArray<int>(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_KuroRuntimeLODBias_OpenWorld, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.KuroRuntimeLODBias_OpenWorld.CopyAssign(value);
			}
		}

		// Token: 0x170028EF RID: 10479
		// (get) Token: 0x0600B350 RID: 45904 RVA: 0x000FF8DC File Offset: 0x000FDADC
		// (set) Token: 0x0600B351 RID: 45905 RVA: 0x000FF91F File Offset: 0x000FDB1F
		public TArray<int> KuroRuntimeLODBias_OpenWorld_Plot
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._KuroRuntimeLODBias_OpenWorld_Plot) == null)
				{
					result = (this._KuroRuntimeLODBias_OpenWorld_Plot = new TArray<int>(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_KuroRuntimeLODBias_OpenWorld_Plot, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.KuroRuntimeLODBias_OpenWorld_Plot.CopyAssign(value);
			}
		}

		// Token: 0x170028F0 RID: 10480
		// (get) Token: 0x0600B352 RID: 45906 RVA: 0x000FF930 File Offset: 0x000FDB30
		// (set) Token: 0x0600B353 RID: 45907 RVA: 0x000FF973 File Offset: 0x000FDB73
		public TArray<int> KuroRuntimeLODBias_Dungeon
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._KuroRuntimeLODBias_Dungeon) == null)
				{
					result = (this._KuroRuntimeLODBias_Dungeon = new TArray<int>(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_KuroRuntimeLODBias_Dungeon, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.KuroRuntimeLODBias_Dungeon.CopyAssign(value);
			}
		}

		// Token: 0x170028F1 RID: 10481
		// (get) Token: 0x0600B354 RID: 45908 RVA: 0x000FF984 File Offset: 0x000FDB84
		// (set) Token: 0x0600B355 RID: 45909 RVA: 0x000FF9C7 File Offset: 0x000FDBC7
		public TArray<int> KuroRuntimeLODBias_Dungeon_Plot
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._KuroRuntimeLODBias_Dungeon_Plot) == null)
				{
					result = (this._KuroRuntimeLODBias_Dungeon_Plot = new TArray<int>(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_KuroRuntimeLODBias_Dungeon_Plot, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.KuroRuntimeLODBias_Dungeon_Plot.CopyAssign(value);
			}
		}

		// Token: 0x170028F2 RID: 10482
		// (get) Token: 0x0600B356 RID: 45910 RVA: 0x000FF9D8 File Offset: 0x000FDBD8
		// (set) Token: 0x0600B357 RID: 45911 RVA: 0x000FFA1B File Offset: 0x000FDC1B
		public TArray<int> Default_KuroRuntimeLODBias_OpenWorld
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._Default_KuroRuntimeLODBias_OpenWorld) == null)
				{
					result = (this._Default_KuroRuntimeLODBias_OpenWorld = new TArray<int>(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_Default_KuroRuntimeLODBias_OpenWorld, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Default_KuroRuntimeLODBias_OpenWorld.CopyAssign(value);
			}
		}

		// Token: 0x170028F3 RID: 10483
		// (get) Token: 0x0600B358 RID: 45912 RVA: 0x000FFA2C File Offset: 0x000FDC2C
		// (set) Token: 0x0600B359 RID: 45913 RVA: 0x000FFA6F File Offset: 0x000FDC6F
		public TArray<int> Default_KuroRuntimeLODBias_OpenWorld_Plot
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._Default_KuroRuntimeLODBias_OpenWorld_Plot) == null)
				{
					result = (this._Default_KuroRuntimeLODBias_OpenWorld_Plot = new TArray<int>(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_Default_KuroRuntimeLODBias_OpenWorld_Plot, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Default_KuroRuntimeLODBias_OpenWorld_Plot.CopyAssign(value);
			}
		}

		// Token: 0x170028F4 RID: 10484
		// (get) Token: 0x0600B35A RID: 45914 RVA: 0x000FFA80 File Offset: 0x000FDC80
		// (set) Token: 0x0600B35B RID: 45915 RVA: 0x000FFAC3 File Offset: 0x000FDCC3
		public TArray<int> Default_KuroRuntimeLODBias_Dungeon
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._Default_KuroRuntimeLODBias_Dungeon) == null)
				{
					result = (this._Default_KuroRuntimeLODBias_Dungeon = new TArray<int>(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_Default_KuroRuntimeLODBias_Dungeon, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Default_KuroRuntimeLODBias_Dungeon.CopyAssign(value);
			}
		}

		// Token: 0x170028F5 RID: 10485
		// (get) Token: 0x0600B35C RID: 45916 RVA: 0x000FFAD4 File Offset: 0x000FDCD4
		// (set) Token: 0x0600B35D RID: 45917 RVA: 0x000FFB17 File Offset: 0x000FDD17
		public TArray<int> Default_KuroRuntimeLODBias_Dungeon_Plot
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._Default_KuroRuntimeLODBias_Dungeon_Plot) == null)
				{
					result = (this._Default_KuroRuntimeLODBias_Dungeon_Plot = new TArray<int>(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_Default_KuroRuntimeLODBias_Dungeon_Plot, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Default_KuroRuntimeLODBias_Dungeon_Plot.CopyAssign(value);
			}
		}

		// Token: 0x170028F6 RID: 10486
		// (get) Token: 0x0600B35E RID: 45918 RVA: 0x000FFB25 File Offset: 0x000FDD25
		// (set) Token: 0x0600B35F RID: 45919 RVA: 0x000FFB3E File Offset: 0x000FDD3E
		public unsafe bool bTexBiasStrictCheck
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_bTexBiasStrictCheck) & FKuroTextureFolderCheckConfig.__PropertyMask_bTexBiasStrictCheck) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_bTexBiasStrictCheck) = ((*(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_bTexBiasStrictCheck) & ~FKuroTextureFolderCheckConfig.__PropertyMask_bTexBiasStrictCheck) | (value ? FKuroTextureFolderCheckConfig.__PropertyMask_bTexBiasStrictCheck : 0));
			}
		}

		// Token: 0x170028F7 RID: 10487
		// (get) Token: 0x0600B360 RID: 45920 RVA: 0x000FFB6E File Offset: 0x000FDD6E
		// (set) Token: 0x0600B361 RID: 45921 RVA: 0x000FFB87 File Offset: 0x000FDD87
		public unsafe bool bGuaranteedConfig
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_bGuaranteedConfig) & FKuroTextureFolderCheckConfig.__PropertyMask_bGuaranteedConfig) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_bGuaranteedConfig) = ((*(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_bGuaranteedConfig) & ~FKuroTextureFolderCheckConfig.__PropertyMask_bGuaranteedConfig) | (value ? FKuroTextureFolderCheckConfig.__PropertyMask_bGuaranteedConfig : 0));
			}
		}

		// Token: 0x170028F8 RID: 10488
		// (get) Token: 0x0600B362 RID: 45922 RVA: 0x000FFBB7 File Offset: 0x000FDDB7
		// (set) Token: 0x0600B363 RID: 45923 RVA: 0x000FFBD0 File Offset: 0x000FDDD0
		public unsafe bool IsOnlyCheckSize
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_IsOnlyCheckSize) & FKuroTextureFolderCheckConfig.__PropertyMask_IsOnlyCheckSize) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_IsOnlyCheckSize) = ((*(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_IsOnlyCheckSize) & ~FKuroTextureFolderCheckConfig.__PropertyMask_IsOnlyCheckSize) | (value ? FKuroTextureFolderCheckConfig.__PropertyMask_IsOnlyCheckSize : 0));
			}
		}

		// Token: 0x170028F9 RID: 10489
		// (get) Token: 0x0600B364 RID: 45924 RVA: 0x000FFC00 File Offset: 0x000FDE00
		// (set) Token: 0x0600B365 RID: 45925 RVA: 0x000FFC19 File Offset: 0x000FDE19
		public unsafe bool IsPowerOfTwo
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_IsPowerOfTwo) & FKuroTextureFolderCheckConfig.__PropertyMask_IsPowerOfTwo) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_IsPowerOfTwo) = ((*(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_IsPowerOfTwo) & ~FKuroTextureFolderCheckConfig.__PropertyMask_IsPowerOfTwo) | (value ? FKuroTextureFolderCheckConfig.__PropertyMask_IsPowerOfTwo : 0));
			}
		}

		// Token: 0x170028FA RID: 10490
		// (get) Token: 0x0600B366 RID: 45926 RVA: 0x000FFC49 File Offset: 0x000FDE49
		// (set) Token: 0x0600B367 RID: 45927 RVA: 0x000FFC62 File Offset: 0x000FDE62
		public unsafe bool NeverStreaming
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_NeverStreaming) & FKuroTextureFolderCheckConfig.__PropertyMask_NeverStreaming) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_NeverStreaming) = ((*(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_NeverStreaming) & ~FKuroTextureFolderCheckConfig.__PropertyMask_NeverStreaming) | (value ? FKuroTextureFolderCheckConfig.__PropertyMask_NeverStreaming : 0));
			}
		}

		// Token: 0x170028FB RID: 10491
		// (get) Token: 0x0600B368 RID: 45928 RVA: 0x000FFC92 File Offset: 0x000FDE92
		// (set) Token: 0x0600B369 RID: 45929 RVA: 0x000FFCAB File Offset: 0x000FDEAB
		public unsafe bool IsCheckAddressingMode
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_IsCheckAddressingMode) & FKuroTextureFolderCheckConfig.__PropertyMask_IsCheckAddressingMode) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_IsCheckAddressingMode) = ((*(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_IsCheckAddressingMode) & ~FKuroTextureFolderCheckConfig.__PropertyMask_IsCheckAddressingMode) | (value ? FKuroTextureFolderCheckConfig.__PropertyMask_IsCheckAddressingMode : 0));
			}
		}

		// Token: 0x170028FC RID: 10492
		// (get) Token: 0x0600B36A RID: 45930 RVA: 0x000FFCDB File Offset: 0x000FDEDB
		// (set) Token: 0x0600B36B RID: 45931 RVA: 0x000FFCF4 File Offset: 0x000FDEF4
		public unsafe bool IsSRGB
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_IsSRGB) & FKuroTextureFolderCheckConfig.__PropertyMask_IsSRGB) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_IsSRGB) = ((*(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_IsSRGB) & ~FKuroTextureFolderCheckConfig.__PropertyMask_IsSRGB) | (value ? FKuroTextureFolderCheckConfig.__PropertyMask_IsSRGB : 0));
			}
		}

		// Token: 0x170028FD RID: 10493
		// (get) Token: 0x0600B36C RID: 45932 RVA: 0x000FFD24 File Offset: 0x000FDF24
		// (set) Token: 0x0600B36D RID: 45933 RVA: 0x000FFD3D File Offset: 0x000FDF3D
		public unsafe bool AutoCheckForceModify
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_AutoCheckForceModify) & FKuroTextureFolderCheckConfig.__PropertyMask_AutoCheckForceModify) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_AutoCheckForceModify) = ((*(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_AutoCheckForceModify) & ~FKuroTextureFolderCheckConfig.__PropertyMask_AutoCheckForceModify) | (value ? FKuroTextureFolderCheckConfig.__PropertyMask_AutoCheckForceModify : 0));
			}
		}

		// Token: 0x170028FE RID: 10494
		// (get) Token: 0x0600B36E RID: 45934 RVA: 0x000FFD6D File Offset: 0x000FDF6D
		// (set) Token: 0x0600B36F RID: 45935 RVA: 0x000FFD86 File Offset: 0x000FDF86
		public unsafe bool IsForceKeepMipsData
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_IsForceKeepMipsData) & FKuroTextureFolderCheckConfig.__PropertyMask_IsForceKeepMipsData) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_IsForceKeepMipsData) = ((*(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_IsForceKeepMipsData) & ~FKuroTextureFolderCheckConfig.__PropertyMask_IsForceKeepMipsData) | (value ? FKuroTextureFolderCheckConfig.__PropertyMask_IsForceKeepMipsData : 0));
			}
		}

		// Token: 0x170028FF RID: 10495
		// (get) Token: 0x0600B370 RID: 45936 RVA: 0x000FFDB8 File Offset: 0x000FDFB8
		// (set) Token: 0x0600B371 RID: 45937 RVA: 0x000FFDFB File Offset: 0x000FDFFB
		public TMap<string, float> DownScale
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, float> result;
				if ((result = this._DownScale) == null)
				{
					result = (this._DownScale = new TMap<string, float>(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_DownScale, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DownScale.CopyAssign(value);
			}
		}

		// Token: 0x17002900 RID: 10496
		// (get) Token: 0x0600B372 RID: 45938 RVA: 0x000FFE09 File Offset: 0x000FE009
		// (set) Token: 0x0600B373 RID: 45939 RVA: 0x000FFE19 File Offset: 0x000FE019
		public unsafe int TextureUsageCheckMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_TextureUsageCheckMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_TextureUsageCheckMode) = value;
			}
		}

		// Token: 0x17002901 RID: 10497
		// (get) Token: 0x0600B374 RID: 45940 RVA: 0x000FFE2A File Offset: 0x000FE02A
		// (set) Token: 0x0600B375 RID: 45941 RVA: 0x000FFE3A File Offset: 0x000FE03A
		public unsafe float TextureUsageThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_TextureUsageThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_TextureUsageThreshold) = value;
			}
		}

		// Token: 0x17002902 RID: 10498
		// (get) Token: 0x0600B376 RID: 45942 RVA: 0x000FFE4C File Offset: 0x000FE04C
		// (set) Token: 0x0600B377 RID: 45943 RVA: 0x000FFE8F File Offset: 0x000FE08F
		public TArray<float> AdjustmentsMin
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._AdjustmentsMin) == null)
				{
					result = (this._AdjustmentsMin = new TArray<float>(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_AdjustmentsMin, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AdjustmentsMin.CopyAssign(value);
			}
		}

		// Token: 0x17002903 RID: 10499
		// (get) Token: 0x0600B378 RID: 45944 RVA: 0x000FFEA0 File Offset: 0x000FE0A0
		// (set) Token: 0x0600B379 RID: 45945 RVA: 0x000FFEE3 File Offset: 0x000FE0E3
		public TArray<float> AdjustmentsMax
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._AdjustmentsMax) == null)
				{
					result = (this._AdjustmentsMax = new TArray<float>(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_AdjustmentsMax, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AdjustmentsMax.CopyAssign(value);
			}
		}

		// Token: 0x17002904 RID: 10500
		// (get) Token: 0x0600B37A RID: 45946 RVA: 0x000FFEF1 File Offset: 0x000FE0F1
		// (set) Token: 0x0600B37B RID: 45947 RVA: 0x000FFF01 File Offset: 0x000FE101
		public unsafe int IsAutoFillUp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_IsAutoFillUp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_IsAutoFillUp) = value;
			}
		}

		// Token: 0x17002905 RID: 10501
		// (get) Token: 0x0600B37C RID: 45948 RVA: 0x000FFF14 File Offset: 0x000FE114
		// (set) Token: 0x0600B37D RID: 45949 RVA: 0x000FFF57 File Offset: 0x000FE157
		public TArray<string> TexturePowerOfTwoSetting
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._TexturePowerOfTwoSetting) == null)
				{
					result = (this._TexturePowerOfTwoSetting = new TArray<string>(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_TexturePowerOfTwoSetting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TexturePowerOfTwoSetting.CopyAssign(value);
			}
		}

		// Token: 0x17002906 RID: 10502
		// (get) Token: 0x0600B37E RID: 45950 RVA: 0x000FFF65 File Offset: 0x000FE165
		// (set) Token: 0x0600B37F RID: 45951 RVA: 0x000FFF75 File Offset: 0x000FE175
		public unsafe byte IsCheckFilterMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_IsCheckFilterMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_IsCheckFilterMode) = value;
			}
		}

		// Token: 0x17002907 RID: 10503
		// (get) Token: 0x0600B380 RID: 45952 RVA: 0x000FFF88 File Offset: 0x000FE188
		// (set) Token: 0x0600B381 RID: 45953 RVA: 0x000FFFCB File Offset: 0x000FE1CB
		public TArray<string> TextureFilterMode
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._TextureFilterMode) == null)
				{
					result = (this._TextureFilterMode = new TArray<string>(base.NativePtr + (IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_TextureFilterMode, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TextureFilterMode.CopyAssign(value);
			}
		}

		// Token: 0x17002908 RID: 10504
		// (get) Token: 0x0600B382 RID: 45954 RVA: 0x000FFFD9 File Offset: 0x000FE1D9
		// (set) Token: 0x0600B383 RID: 45955 RVA: 0x000FFFED File Offset: 0x000FE1ED
		public unsafe string TextureLossyCompressionAmount
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_TextureLossyCompressionAmount)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTextureFolderCheckConfig.__PropertyOffset_TextureLossyCompressionAmount)), value);
			}
		}

		// Token: 0x0600B384 RID: 45956 RVA: 0x00100002 File Offset: 0x000FE202
		public FKuroTextureFolderCheckConfig()
		{
		}

		// Token: 0x0600B385 RID: 45957 RVA: 0x0010000C File Offset: 0x000FE20C
		public FKuroTextureFolderCheckConfig(int SizeX, int SizeY, byte bVatTexCheck, int SetSizeX, int SetSizeY, int MinSizeX, TArray<string> Format, string CompressionQuality, string MinCompressionQuality, string AddressingMode, string MipLoadOptions, string TextureGroup, TArray<string> TextureGroups, TArray<string> MipGenSetting, TArray<float> AlphaCoverageThresholds, TArray<string> DownScalePlatform, TArray<float> DownScaleValue, int StreamingBoostFactor_Default, TArray<string> StreamingBoostFactor_Platform, TArray<int> StreamingBoostFactor_PlatformValue, TArray<float> DownDefaultScaleValue, TArray<string> DeviceLevelExtraLodBiasPlatform, TArray<int> DeviceLevelExtraLodBias, TArray<int> DeviceLevelExtraLodBiasEffectedLevel, int TexBiasStrictCheckSizeThreshold, TArray<int> RuntimeLODBias, TArray<int> KuroRuntimeLODBias_OpenWorld, TArray<int> KuroRuntimeLODBias_OpenWorld_Plot, TArray<int> KuroRuntimeLODBias_Dungeon, TArray<int> KuroRuntimeLODBias_Dungeon_Plot, TArray<int> Default_KuroRuntimeLODBias_OpenWorld, TArray<int> Default_KuroRuntimeLODBias_OpenWorld_Plot, TArray<int> Default_KuroRuntimeLODBias_Dungeon, TArray<int> Default_KuroRuntimeLODBias_Dungeon_Plot, bool bTexBiasStrictCheck, bool bGuaranteedConfig, bool IsOnlyCheckSize, bool IsPowerOfTwo, bool NeverStreaming, bool IsCheckAddressingMode, bool IsSRGB, bool AutoCheckForceModify, bool IsForceKeepMipsData, TMap<string, float> DownScale, int TextureUsageCheckMode, float TextureUsageThreshold, TArray<float> AdjustmentsMin, TArray<float> AdjustmentsMax, int IsAutoFillUp, TArray<string> TexturePowerOfTwoSetting, byte IsCheckFilterMode, TArray<string> TextureFilterMode, string TextureLossyCompressionAmount, string Regex, int MatchingPriority)
		{
			this.SizeX = SizeX;
			this.SizeY = SizeY;
			this.bVatTexCheck = bVatTexCheck;
			this.SetSizeX = SetSizeX;
			this.SetSizeY = SetSizeY;
			this.MinSizeX = MinSizeX;
			this.Format = Format;
			this.CompressionQuality = CompressionQuality;
			this.MinCompressionQuality = MinCompressionQuality;
			this.AddressingMode = AddressingMode;
			this.MipLoadOptions = MipLoadOptions;
			this.TextureGroup = TextureGroup;
			this.TextureGroups = TextureGroups;
			this.MipGenSetting = MipGenSetting;
			this.AlphaCoverageThresholds = AlphaCoverageThresholds;
			this.DownScalePlatform = DownScalePlatform;
			this.DownScaleValue = DownScaleValue;
			this.StreamingBoostFactor_Default = StreamingBoostFactor_Default;
			this.StreamingBoostFactor_Platform = StreamingBoostFactor_Platform;
			this.StreamingBoostFactor_PlatformValue = StreamingBoostFactor_PlatformValue;
			this.DownDefaultScaleValue = DownDefaultScaleValue;
			this.DeviceLevelExtraLodBiasPlatform = DeviceLevelExtraLodBiasPlatform;
			this.DeviceLevelExtraLodBias = DeviceLevelExtraLodBias;
			this.DeviceLevelExtraLodBiasEffectedLevel = DeviceLevelExtraLodBiasEffectedLevel;
			this.TexBiasStrictCheckSizeThreshold = TexBiasStrictCheckSizeThreshold;
			this.RuntimeLODBias = RuntimeLODBias;
			this.KuroRuntimeLODBias_OpenWorld = KuroRuntimeLODBias_OpenWorld;
			this.KuroRuntimeLODBias_OpenWorld_Plot = KuroRuntimeLODBias_OpenWorld_Plot;
			this.KuroRuntimeLODBias_Dungeon = KuroRuntimeLODBias_Dungeon;
			this.KuroRuntimeLODBias_Dungeon_Plot = KuroRuntimeLODBias_Dungeon_Plot;
			this.Default_KuroRuntimeLODBias_OpenWorld = Default_KuroRuntimeLODBias_OpenWorld;
			this.Default_KuroRuntimeLODBias_OpenWorld_Plot = Default_KuroRuntimeLODBias_OpenWorld_Plot;
			this.Default_KuroRuntimeLODBias_Dungeon = Default_KuroRuntimeLODBias_Dungeon;
			this.Default_KuroRuntimeLODBias_Dungeon_Plot = Default_KuroRuntimeLODBias_Dungeon_Plot;
			this.bTexBiasStrictCheck = bTexBiasStrictCheck;
			this.bGuaranteedConfig = bGuaranteedConfig;
			this.IsOnlyCheckSize = IsOnlyCheckSize;
			this.IsPowerOfTwo = IsPowerOfTwo;
			this.NeverStreaming = NeverStreaming;
			this.IsCheckAddressingMode = IsCheckAddressingMode;
			this.IsSRGB = IsSRGB;
			this.AutoCheckForceModify = AutoCheckForceModify;
			this.IsForceKeepMipsData = IsForceKeepMipsData;
			this.DownScale = DownScale;
			this.TextureUsageCheckMode = TextureUsageCheckMode;
			this.TextureUsageThreshold = TextureUsageThreshold;
			this.AdjustmentsMin = AdjustmentsMin;
			this.AdjustmentsMax = AdjustmentsMax;
			this.IsAutoFillUp = IsAutoFillUp;
			this.TexturePowerOfTwoSetting = TexturePowerOfTwoSetting;
			this.IsCheckFilterMode = IsCheckFilterMode;
			this.TextureFilterMode = TextureFilterMode;
			this.TextureLossyCompressionAmount = TextureLossyCompressionAmount;
			base.Regex = Regex;
			base.MatchingPriority = MatchingPriority;
		}

		// Token: 0x0600B386 RID: 45958 RVA: 0x001001D4 File Offset: 0x000FE3D4
		protected override IntPtr GetUStructPtr()
		{
			return FKuroTextureFolderCheckConfig.StaticStruct();
		}

		// Token: 0x0600B387 RID: 45959 RVA: 0x001001E0 File Offset: 0x000FE3E0
		[NullableContext(2)]
		public FKuroTextureFolderCheckConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B388 RID: 45960 RVA: 0x001001EA File Offset: 0x000FE3EA
		public FKuroTextureFolderCheckConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B389 RID: 45961 RVA: 0x001001F5 File Offset: 0x000FE3F5
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroTextureFolderCheckConfig(Pointer, false, true);
		}

		// Token: 0x0600B38A RID: 45962 RVA: 0x001001FF File Offset: 0x000FE3FF
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroTextureFolderCheckConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04005E0A RID: 24074
		public new const string __ObjectPath = "/Script/Engine.KuroTextureFolderCheckConfig";

		// Token: 0x04005E0B RID: 24075
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005E0C RID: 24076
		internal static int __PropertyOffset_SizeX;

		// Token: 0x04005E0D RID: 24077
		internal static int __PropertyOffset_SizeY;

		// Token: 0x04005E0E RID: 24078
		internal static int __PropertyOffset_bVatTexCheck;

		// Token: 0x04005E0F RID: 24079
		internal static int __PropertyOffset_SetSizeX;

		// Token: 0x04005E10 RID: 24080
		internal static int __PropertyOffset_SetSizeY;

		// Token: 0x04005E11 RID: 24081
		internal static int __PropertyOffset_MinSizeX;

		// Token: 0x04005E12 RID: 24082
		internal static int __PropertyOffset_Format;

		// Token: 0x04005E13 RID: 24083
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Format;

		// Token: 0x04005E14 RID: 24084
		internal static int __PropertyOffset_CompressionQuality;

		// Token: 0x04005E15 RID: 24085
		internal static int __PropertyOffset_MinCompressionQuality;

		// Token: 0x04005E16 RID: 24086
		internal static int __PropertyOffset_AddressingMode;

		// Token: 0x04005E17 RID: 24087
		internal static int __PropertyOffset_MipLoadOptions;

		// Token: 0x04005E18 RID: 24088
		internal static int __PropertyOffset_TextureGroup;

		// Token: 0x04005E19 RID: 24089
		internal static int __PropertyOffset_TextureGroups;

		// Token: 0x04005E1A RID: 24090
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _TextureGroups;

		// Token: 0x04005E1B RID: 24091
		internal static int __PropertyOffset_MipGenSetting;

		// Token: 0x04005E1C RID: 24092
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _MipGenSetting;

		// Token: 0x04005E1D RID: 24093
		internal static int __PropertyOffset_AlphaCoverageThresholds;

		// Token: 0x04005E1E RID: 24094
		[Nullable(2)]
		private TArray<float> _AlphaCoverageThresholds;

		// Token: 0x04005E1F RID: 24095
		internal static int __PropertyOffset_DownScalePlatform;

		// Token: 0x04005E20 RID: 24096
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _DownScalePlatform;

		// Token: 0x04005E21 RID: 24097
		internal static int __PropertyOffset_DownScaleValue;

		// Token: 0x04005E22 RID: 24098
		[Nullable(2)]
		private TArray<float> _DownScaleValue;

		// Token: 0x04005E23 RID: 24099
		internal static int __PropertyOffset_StreamingBoostFactor_Default;

		// Token: 0x04005E24 RID: 24100
		internal static int __PropertyOffset_StreamingBoostFactor_Platform;

		// Token: 0x04005E25 RID: 24101
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _StreamingBoostFactor_Platform;

		// Token: 0x04005E26 RID: 24102
		internal static int __PropertyOffset_StreamingBoostFactor_PlatformValue;

		// Token: 0x04005E27 RID: 24103
		[Nullable(2)]
		private TArray<int> _StreamingBoostFactor_PlatformValue;

		// Token: 0x04005E28 RID: 24104
		internal static int __PropertyOffset_DownDefaultScaleValue;

		// Token: 0x04005E29 RID: 24105
		[Nullable(2)]
		private TArray<float> _DownDefaultScaleValue;

		// Token: 0x04005E2A RID: 24106
		internal static int __PropertyOffset_DeviceLevelExtraLodBiasPlatform;

		// Token: 0x04005E2B RID: 24107
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _DeviceLevelExtraLodBiasPlatform;

		// Token: 0x04005E2C RID: 24108
		internal static int __PropertyOffset_DeviceLevelExtraLodBias;

		// Token: 0x04005E2D RID: 24109
		[Nullable(2)]
		private TArray<int> _DeviceLevelExtraLodBias;

		// Token: 0x04005E2E RID: 24110
		internal static int __PropertyOffset_DeviceLevelExtraLodBiasEffectedLevel;

		// Token: 0x04005E2F RID: 24111
		[Nullable(2)]
		private TArray<int> _DeviceLevelExtraLodBiasEffectedLevel;

		// Token: 0x04005E30 RID: 24112
		internal static int __PropertyOffset_TexBiasStrictCheckSizeThreshold;

		// Token: 0x04005E31 RID: 24113
		internal static int __PropertyOffset_RuntimeLODBias;

		// Token: 0x04005E32 RID: 24114
		[Nullable(2)]
		private TArray<int> _RuntimeLODBias;

		// Token: 0x04005E33 RID: 24115
		internal static int __PropertyOffset_KuroRuntimeLODBias_OpenWorld;

		// Token: 0x04005E34 RID: 24116
		[Nullable(2)]
		private TArray<int> _KuroRuntimeLODBias_OpenWorld;

		// Token: 0x04005E35 RID: 24117
		internal static int __PropertyOffset_KuroRuntimeLODBias_OpenWorld_Plot;

		// Token: 0x04005E36 RID: 24118
		[Nullable(2)]
		private TArray<int> _KuroRuntimeLODBias_OpenWorld_Plot;

		// Token: 0x04005E37 RID: 24119
		internal static int __PropertyOffset_KuroRuntimeLODBias_Dungeon;

		// Token: 0x04005E38 RID: 24120
		[Nullable(2)]
		private TArray<int> _KuroRuntimeLODBias_Dungeon;

		// Token: 0x04005E39 RID: 24121
		internal static int __PropertyOffset_KuroRuntimeLODBias_Dungeon_Plot;

		// Token: 0x04005E3A RID: 24122
		[Nullable(2)]
		private TArray<int> _KuroRuntimeLODBias_Dungeon_Plot;

		// Token: 0x04005E3B RID: 24123
		internal static int __PropertyOffset_Default_KuroRuntimeLODBias_OpenWorld;

		// Token: 0x04005E3C RID: 24124
		[Nullable(2)]
		private TArray<int> _Default_KuroRuntimeLODBias_OpenWorld;

		// Token: 0x04005E3D RID: 24125
		internal static int __PropertyOffset_Default_KuroRuntimeLODBias_OpenWorld_Plot;

		// Token: 0x04005E3E RID: 24126
		[Nullable(2)]
		private TArray<int> _Default_KuroRuntimeLODBias_OpenWorld_Plot;

		// Token: 0x04005E3F RID: 24127
		internal static int __PropertyOffset_Default_KuroRuntimeLODBias_Dungeon;

		// Token: 0x04005E40 RID: 24128
		[Nullable(2)]
		private TArray<int> _Default_KuroRuntimeLODBias_Dungeon;

		// Token: 0x04005E41 RID: 24129
		internal static int __PropertyOffset_Default_KuroRuntimeLODBias_Dungeon_Plot;

		// Token: 0x04005E42 RID: 24130
		[Nullable(2)]
		private TArray<int> _Default_KuroRuntimeLODBias_Dungeon_Plot;

		// Token: 0x04005E43 RID: 24131
		internal static int __PropertyOffset_bTexBiasStrictCheck;

		// Token: 0x04005E44 RID: 24132
		internal static byte __PropertyMask_bTexBiasStrictCheck;

		// Token: 0x04005E45 RID: 24133
		internal static int __PropertyOffset_bGuaranteedConfig;

		// Token: 0x04005E46 RID: 24134
		internal static byte __PropertyMask_bGuaranteedConfig;

		// Token: 0x04005E47 RID: 24135
		internal static int __PropertyOffset_IsOnlyCheckSize;

		// Token: 0x04005E48 RID: 24136
		internal static byte __PropertyMask_IsOnlyCheckSize;

		// Token: 0x04005E49 RID: 24137
		internal static int __PropertyOffset_IsPowerOfTwo;

		// Token: 0x04005E4A RID: 24138
		internal static byte __PropertyMask_IsPowerOfTwo;

		// Token: 0x04005E4B RID: 24139
		internal static int __PropertyOffset_NeverStreaming;

		// Token: 0x04005E4C RID: 24140
		internal static byte __PropertyMask_NeverStreaming;

		// Token: 0x04005E4D RID: 24141
		internal static int __PropertyOffset_IsCheckAddressingMode;

		// Token: 0x04005E4E RID: 24142
		internal static byte __PropertyMask_IsCheckAddressingMode;

		// Token: 0x04005E4F RID: 24143
		internal static int __PropertyOffset_IsSRGB;

		// Token: 0x04005E50 RID: 24144
		internal static byte __PropertyMask_IsSRGB;

		// Token: 0x04005E51 RID: 24145
		internal static int __PropertyOffset_AutoCheckForceModify;

		// Token: 0x04005E52 RID: 24146
		internal static byte __PropertyMask_AutoCheckForceModify;

		// Token: 0x04005E53 RID: 24147
		internal static int __PropertyOffset_IsForceKeepMipsData;

		// Token: 0x04005E54 RID: 24148
		internal static byte __PropertyMask_IsForceKeepMipsData;

		// Token: 0x04005E55 RID: 24149
		internal static int __PropertyOffset_DownScale;

		// Token: 0x04005E56 RID: 24150
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, float> _DownScale;

		// Token: 0x04005E57 RID: 24151
		internal static int __PropertyOffset_TextureUsageCheckMode;

		// Token: 0x04005E58 RID: 24152
		internal static int __PropertyOffset_TextureUsageThreshold;

		// Token: 0x04005E59 RID: 24153
		internal static int __PropertyOffset_AdjustmentsMin;

		// Token: 0x04005E5A RID: 24154
		[Nullable(2)]
		private TArray<float> _AdjustmentsMin;

		// Token: 0x04005E5B RID: 24155
		internal static int __PropertyOffset_AdjustmentsMax;

		// Token: 0x04005E5C RID: 24156
		[Nullable(2)]
		private TArray<float> _AdjustmentsMax;

		// Token: 0x04005E5D RID: 24157
		internal static int __PropertyOffset_IsAutoFillUp;

		// Token: 0x04005E5E RID: 24158
		internal static int __PropertyOffset_TexturePowerOfTwoSetting;

		// Token: 0x04005E5F RID: 24159
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _TexturePowerOfTwoSetting;

		// Token: 0x04005E60 RID: 24160
		internal static int __PropertyOffset_IsCheckFilterMode;

		// Token: 0x04005E61 RID: 24161
		internal static int __PropertyOffset_TextureFilterMode;

		// Token: 0x04005E62 RID: 24162
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _TextureFilterMode;

		// Token: 0x04005E63 RID: 24163
		internal static int __PropertyOffset_TextureLossyCompressionAmount;
	}
}
