using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020C2 RID: 8386
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUISettings")]
	[UnrealStructLayout(544, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 544)]
	public class ULGUISettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F949 RID: 129353 RVA: 0x002EF43A File Offset: 0x002ED63A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUISettings._ClassPtr;
		}

		// Token: 0x0601F94A RID: 129354 RVA: 0x002EF448 File Offset: 0x002ED648
		public ULGUISettings() : this(BuiltinUtils.AllocNativeUObject(ULGUISettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F94B RID: 129355 RVA: 0x002EF470 File Offset: 0x002ED670
		public ULGUISettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUISettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007C7C RID: 31868
		// (get) Token: 0x0601F94C RID: 129356 RVA: 0x002EF4A4 File Offset: 0x002ED6A4
		// (set) Token: 0x0601F94D RID: 129357 RVA: 0x002EF4DD File Offset: 0x002ED6DD
		public FLGUIAtlasSettings defaultAtlasSetting
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIAtlasSettings result;
				if ((result = this._defaultAtlasSetting) == null)
				{
					result = (this._defaultAtlasSetting = new FLGUIAtlasSettings(base.NativePtr + (IntPtr)ULGUISettings.__PropertyOffset_defaultAtlasSetting, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIAtlasSettings.StaticStruct(), base.NativePtr + (IntPtr)ULGUISettings.__PropertyOffset_defaultAtlasSetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007C7D RID: 31869
		// (get) Token: 0x0601F94E RID: 129358 RVA: 0x002EF500 File Offset: 0x002ED700
		// (set) Token: 0x0601F94F RID: 129359 RVA: 0x002EF539 File Offset: 0x002ED739
		public TMap<FName, FLGUIAtlasSettings> atlasSettingForSpecificPackingTag
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLGUIAtlasSettings> result;
				if ((result = this._atlasSettingForSpecificPackingTag) == null)
				{
					result = (this._atlasSettingForSpecificPackingTag = new TMap<FName, FLGUIAtlasSettings>(base.NativePtr + (IntPtr)ULGUISettings.__PropertyOffset_atlasSettingForSpecificPackingTag, this));
				}
				return result;
			}
			set
			{
				this.atlasSettingForSpecificPackingTag.CopyAssign(value);
			}
		}

		// Token: 0x17007C7E RID: 31870
		// (get) Token: 0x0601F950 RID: 129360 RVA: 0x002EF547 File Offset: 0x002ED747
		// (set) Token: 0x0601F951 RID: 129361 RVA: 0x002EF55B File Offset: 0x002ED75B
		[Nullable(0)]
		public unsafe TEnumAsByte<ETraceTypeQuery> defaultTraceChannel
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUISettings.__PropertyOffset_defaultTraceChannel);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)ULGUISettings.__PropertyOffset_defaultTraceChannel) = value;
			}
		}

		// Token: 0x17007C7F RID: 31871
		// (get) Token: 0x0601F952 RID: 129362 RVA: 0x002EF570 File Offset: 0x002ED770
		// (set) Token: 0x0601F953 RID: 129363 RVA: 0x002EF580 File Offset: 0x002ED780
		public unsafe ELGUIScreenSpaceUIAntiAliasing antiAliasing
		{
			get
			{
				return (ELGUIScreenSpaceUIAntiAliasing)(*(base.NativePtr + (IntPtr)ULGUISettings.__PropertyOffset_antiAliasing));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUISettings.__PropertyOffset_antiAliasing) = (byte)value;
			}
		}

		// Token: 0x17007C80 RID: 31872
		// (get) Token: 0x0601F954 RID: 129364 RVA: 0x002EF594 File Offset: 0x002ED794
		// (set) Token: 0x0601F955 RID: 129365 RVA: 0x002EF5CD File Offset: 0x002ED7CD
		public FLGUIFixedInfo fixedInfo
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIFixedInfo result;
				if ((result = this._fixedInfo) == null)
				{
					result = (this._fixedInfo = new FLGUIFixedInfo(base.NativePtr + (IntPtr)ULGUISettings.__PropertyOffset_fixedInfo, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIFixedInfo.StaticStruct(), base.NativePtr + (IntPtr)ULGUISettings.__PropertyOffset_fixedInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007C81 RID: 31873
		// (get) Token: 0x0601F956 RID: 129366 RVA: 0x002EF5EE File Offset: 0x002ED7EE
		// (set) Token: 0x0601F957 RID: 129367 RVA: 0x002EF5FE File Offset: 0x002ED7FE
		public unsafe int niagaraSortOrderBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUISettings.__PropertyOffset_niagaraSortOrderBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUISettings.__PropertyOffset_niagaraSortOrderBias) = value;
			}
		}

		// Token: 0x17007C82 RID: 31874
		// (get) Token: 0x0601F958 RID: 129368 RVA: 0x002EF60F File Offset: 0x002ED80F
		// (set) Token: 0x0601F959 RID: 129369 RVA: 0x002EF61F File Offset: 0x002ED81F
		public unsafe float needTidyUpRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUISettings.__PropertyOffset_needTidyUpRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUISettings.__PropertyOffset_needTidyUpRatio) = value;
			}
		}

		// Token: 0x17007C83 RID: 31875
		// (get) Token: 0x0601F95A RID: 129370 RVA: 0x002EF630 File Offset: 0x002ED830
		// (set) Token: 0x0601F95B RID: 129371 RVA: 0x002EF644 File Offset: 0x002ED844
		public unsafe string DefaultWhiteTexturePath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)ULGUISettings.__PropertyOffset_DefaultWhiteTexturePath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)ULGUISettings.__PropertyOffset_DefaultWhiteTexturePath)), value);
			}
		}

		// Token: 0x17007C84 RID: 31876
		// (get) Token: 0x0601F95C RID: 129372 RVA: 0x002EF659 File Offset: 0x002ED859
		// (set) Token: 0x0601F95D RID: 129373 RVA: 0x002EF66D File Offset: 0x002ED86D
		public unsafe string DefaultWhiteSpritePath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)ULGUISettings.__PropertyOffset_DefaultWhiteSpritePath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)ULGUISettings.__PropertyOffset_DefaultWhiteSpritePath)), value);
			}
		}

		// Token: 0x17007C85 RID: 31877
		// (get) Token: 0x0601F95E RID: 129374 RVA: 0x002EF682 File Offset: 0x002ED882
		// (set) Token: 0x0601F95F RID: 129375 RVA: 0x002EF696 File Offset: 0x002ED896
		public unsafe string DefaultEventPrefabPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)ULGUISettings.__PropertyOffset_DefaultEventPrefabPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)ULGUISettings.__PropertyOffset_DefaultEventPrefabPath)), value);
			}
		}

		// Token: 0x17007C86 RID: 31878
		// (get) Token: 0x0601F960 RID: 129376 RVA: 0x002EF6AB File Offset: 0x002ED8AB
		// (set) Token: 0x0601F961 RID: 129377 RVA: 0x002EF6BF File Offset: 0x002ED8BF
		public unsafe string DefaultScreenRootPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)ULGUISettings.__PropertyOffset_DefaultScreenRootPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)ULGUISettings.__PropertyOffset_DefaultScreenRootPath)), value);
			}
		}

		// Token: 0x17007C87 RID: 31879
		// (get) Token: 0x0601F962 RID: 129378 RVA: 0x002EF6D4 File Offset: 0x002ED8D4
		// (set) Token: 0x0601F963 RID: 129379 RVA: 0x002EF6E8 File Offset: 0x002ED8E8
		public unsafe string DefaultWorldRootPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)ULGUISettings.__PropertyOffset_DefaultWorldRootPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)ULGUISettings.__PropertyOffset_DefaultWorldRootPath)), value);
			}
		}

		// Token: 0x17007C88 RID: 31880
		// (get) Token: 0x0601F964 RID: 129380 RVA: 0x002EF6FD File Offset: 0x002ED8FD
		// (set) Token: 0x0601F965 RID: 129381 RVA: 0x002EF711 File Offset: 0x002ED911
		public unsafe string DefaultChildPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)ULGUISettings.__PropertyOffset_DefaultChildPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)ULGUISettings.__PropertyOffset_DefaultChildPath)), value);
			}
		}

		// Token: 0x17007C89 RID: 31881
		// (get) Token: 0x0601F966 RID: 129382 RVA: 0x002EF726 File Offset: 0x002ED926
		// (set) Token: 0x0601F967 RID: 129383 RVA: 0x002EF73A File Offset: 0x002ED93A
		public unsafe string DefaultFontPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)ULGUISettings.__PropertyOffset_DefaultFontPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)ULGUISettings.__PropertyOffset_DefaultFontPath)), value);
			}
		}

		// Token: 0x17007C8A RID: 31882
		// (get) Token: 0x0601F968 RID: 129384 RVA: 0x002EF74F File Offset: 0x002ED94F
		// (set) Token: 0x0601F969 RID: 129385 RVA: 0x002EF75F File Offset: 0x002ED95F
		public unsafe uint MaxTextInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUISettings.__PropertyOffset_MaxTextInput);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUISettings.__PropertyOffset_MaxTextInput) = (int)value;
			}
		}

		// Token: 0x17007C8B RID: 31883
		// (get) Token: 0x0601F96A RID: 129386 RVA: 0x002EF770 File Offset: 0x002ED970
		// (set) Token: 0x0601F96B RID: 129387 RVA: 0x002EF784 File Offset: 0x002ED984
		public unsafe string ThDict
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)ULGUISettings.__PropertyOffset_ThDict)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)ULGUISettings.__PropertyOffset_ThDict)), value);
			}
		}

		// Token: 0x17007C8C RID: 31884
		// (get) Token: 0x0601F96C RID: 129388 RVA: 0x002EF799 File Offset: 0x002ED999
		// (set) Token: 0x0601F96D RID: 129389 RVA: 0x002EF7AD File Offset: 0x002ED9AD
		public unsafe string ThFontSetting
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)ULGUISettings.__PropertyOffset_ThFontSetting)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)ULGUISettings.__PropertyOffset_ThFontSetting)), value);
			}
		}

		// Token: 0x17007C8D RID: 31885
		// (get) Token: 0x0601F96E RID: 129390 RVA: 0x002EF7C2 File Offset: 0x002ED9C2
		// (set) Token: 0x0601F96F RID: 129391 RVA: 0x002EF7D6 File Offset: 0x002ED9D6
		public unsafe string PcPrefix
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)ULGUISettings.__PropertyOffset_PcPrefix)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)ULGUISettings.__PropertyOffset_PcPrefix)), value);
			}
		}

		// Token: 0x17007C8E RID: 31886
		// (get) Token: 0x0601F970 RID: 129392 RVA: 0x002EF7EB File Offset: 0x002ED9EB
		// (set) Token: 0x0601F971 RID: 129393 RVA: 0x002EF7FF File Offset: 0x002ED9FF
		public unsafe string MobilePrefix
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)ULGUISettings.__PropertyOffset_MobilePrefix)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)ULGUISettings.__PropertyOffset_MobilePrefix)), value);
			}
		}

		// Token: 0x17007C8F RID: 31887
		// (get) Token: 0x0601F972 RID: 129394 RVA: 0x002EF814 File Offset: 0x002EDA14
		// (set) Token: 0x0601F973 RID: 129395 RVA: 0x002EF828 File Offset: 0x002EDA28
		public unsafe string BasePrefabItemName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)ULGUISettings.__PropertyOffset_BasePrefabItemName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)ULGUISettings.__PropertyOffset_BasePrefabItemName)), value);
			}
		}

		// Token: 0x17007C90 RID: 31888
		// (get) Token: 0x0601F974 RID: 129396 RVA: 0x002EF83D File Offset: 0x002EDA3D
		// (set) Token: 0x0601F975 RID: 129397 RVA: 0x002EF851 File Offset: 0x002EDA51
		public unsafe string PlatformReplacePath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)ULGUISettings.__PropertyOffset_PlatformReplacePath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)ULGUISettings.__PropertyOffset_PlatformReplacePath)), value);
			}
		}

		// Token: 0x17007C91 RID: 31889
		// (get) Token: 0x0601F976 RID: 129398 RVA: 0x002EF866 File Offset: 0x002EDA66
		// (set) Token: 0x0601F977 RID: 129399 RVA: 0x002EF87A File Offset: 0x002EDA7A
		public unsafe string PlatformSequenceReplacePath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)ULGUISettings.__PropertyOffset_PlatformSequenceReplacePath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)ULGUISettings.__PropertyOffset_PlatformSequenceReplacePath)), value);
			}
		}

		// Token: 0x17007C92 RID: 31890
		// (get) Token: 0x0601F978 RID: 129400 RVA: 0x002EF88F File Offset: 0x002EDA8F
		// (set) Token: 0x0601F979 RID: 129401 RVA: 0x002EF8A3 File Offset: 0x002EDAA3
		public unsafe string PcDirectory
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)ULGUISettings.__PropertyOffset_PcDirectory)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)ULGUISettings.__PropertyOffset_PcDirectory)), value);
			}
		}

		// Token: 0x17007C93 RID: 31891
		// (get) Token: 0x0601F97A RID: 129402 RVA: 0x002EF8B8 File Offset: 0x002EDAB8
		// (set) Token: 0x0601F97B RID: 129403 RVA: 0x002EF8CC File Offset: 0x002EDACC
		public unsafe string PcSequenceDirectory
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)ULGUISettings.__PropertyOffset_PcSequenceDirectory)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)ULGUISettings.__PropertyOffset_PcSequenceDirectory)), value);
			}
		}

		// Token: 0x17007C94 RID: 31892
		// (get) Token: 0x0601F97C RID: 129404 RVA: 0x002EF8E4 File Offset: 0x002EDAE4
		// (set) Token: 0x0601F97D RID: 129405 RVA: 0x002EF91D File Offset: 0x002EDB1D
		public FSoftObjectPath PcSequenceTmpPath
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._PcSequenceTmpPath) == null)
				{
					result = (this._PcSequenceTmpPath = new FSoftObjectPath(base.NativePtr + (IntPtr)ULGUISettings.__PropertyOffset_PcSequenceTmpPath, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)ULGUISettings.__PropertyOffset_PcSequenceTmpPath, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007C95 RID: 31893
		// (get) Token: 0x0601F97E RID: 129406 RVA: 0x002EF93E File Offset: 0x002EDB3E
		// (set) Token: 0x0601F97F RID: 129407 RVA: 0x002EF952 File Offset: 0x002EDB52
		public unsafe string PcSequencePostfix
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)ULGUISettings.__PropertyOffset_PcSequencePostfix)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)ULGUISettings.__PropertyOffset_PcSequencePostfix)), value);
			}
		}

		// Token: 0x17007C96 RID: 31894
		// (get) Token: 0x0601F980 RID: 129408 RVA: 0x002EF967 File Offset: 0x002EDB67
		// (set) Token: 0x0601F981 RID: 129409 RVA: 0x002EF97B File Offset: 0x002EDB7B
		public unsafe string MobileDirectory
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)ULGUISettings.__PropertyOffset_MobileDirectory)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)ULGUISettings.__PropertyOffset_MobileDirectory)), value);
			}
		}

		// Token: 0x17007C97 RID: 31895
		// (get) Token: 0x0601F982 RID: 129410 RVA: 0x002EF990 File Offset: 0x002EDB90
		// (set) Token: 0x0601F983 RID: 129411 RVA: 0x002EF9A0 File Offset: 0x002EDBA0
		public unsafe int MaxSequenceActorTriggerCollect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUISettings.__PropertyOffset_MaxSequenceActorTriggerCollect);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUISettings.__PropertyOffset_MaxSequenceActorTriggerCollect) = value;
			}
		}

		// Token: 0x17007C98 RID: 31896
		// (get) Token: 0x0601F984 RID: 129412 RVA: 0x002EF9B1 File Offset: 0x002EDBB1
		// (set) Token: 0x0601F985 RID: 129413 RVA: 0x002EF9C1 File Offset: 0x002EDBC1
		public unsafe float SequenceActorTriggerCollectInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUISettings.__PropertyOffset_SequenceActorTriggerCollectInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUISettings.__PropertyOffset_SequenceActorTriggerCollectInterval) = value;
			}
		}

		// Token: 0x17007C99 RID: 31897
		// (get) Token: 0x0601F986 RID: 129414 RVA: 0x002EF9D2 File Offset: 0x002EDBD2
		// (set) Token: 0x0601F987 RID: 129415 RVA: 0x002EF9E6 File Offset: 0x002EDBE6
		public unsafe FVector2D MaxDiscreteTextureSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUISettings.__PropertyOffset_MaxDiscreteTextureSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUISettings.__PropertyOffset_MaxDiscreteTextureSize) = value;
			}
		}

		// Token: 0x17007C9A RID: 31898
		// (get) Token: 0x0601F988 RID: 129416 RVA: 0x002EF9FB File Offset: 0x002EDBFB
		// (set) Token: 0x0601F989 RID: 129417 RVA: 0x002EFA0B File Offset: 0x002EDC0B
		public unsafe float DynamicAtlasFailAttemptSecs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUISettings.__PropertyOffset_DynamicAtlasFailAttemptSecs);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUISettings.__PropertyOffset_DynamicAtlasFailAttemptSecs) = value;
			}
		}

		// Token: 0x17007C9B RID: 31899
		// (get) Token: 0x0601F98A RID: 129418 RVA: 0x002EFA1C File Offset: 0x002EDC1C
		// (set) Token: 0x0601F98B RID: 129419 RVA: 0x002EFA2C File Offset: 0x002EDC2C
		public unsafe uint DynamicAtlasNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUISettings.__PropertyOffset_DynamicAtlasNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUISettings.__PropertyOffset_DynamicAtlasNum) = (int)value;
			}
		}

		// Token: 0x17007C9C RID: 31900
		// (get) Token: 0x0601F98C RID: 129420 RVA: 0x002EFA3D File Offset: 0x002EDC3D
		// (set) Token: 0x0601F98D RID: 129421 RVA: 0x002EFA4D File Offset: 0x002EDC4D
		public unsafe uint MaxAttemptInsertTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUISettings.__PropertyOffset_MaxAttemptInsertTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUISettings.__PropertyOffset_MaxAttemptInsertTime) = (int)value;
			}
		}

		// Token: 0x17007C9D RID: 31901
		// (get) Token: 0x0601F98E RID: 129422 RVA: 0x002EFA5E File Offset: 0x002EDC5E
		// (set) Token: 0x0601F98F RID: 129423 RVA: 0x002EFA6E File Offset: 0x002EDC6E
		public unsafe bool bUseNewSequenceBinding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUISettings.__PropertyOffset_bUseNewSequenceBinding) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUISettings.__PropertyOffset_bUseNewSequenceBinding) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601F990 RID: 129424 RVA: 0x002EFA7F File Offset: 0x002EDC7F
		static ULGUISettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUISettings");
		}

		// Token: 0x0601F991 RID: 129425 RVA: 0x002EFA8D File Offset: 0x002EDC8D
		protected ULGUISettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040110BB RID: 69819
		public new const string __ObjectPath = "/Script/LGUI.LGUISettings";

		// Token: 0x040110BC RID: 69820
		private static IntPtr _ClassPtr;

		// Token: 0x040110BD RID: 69821
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040110BE RID: 69822
		internal static int __PropertyOffset_defaultAtlasSetting;

		// Token: 0x040110BF RID: 69823
		[Nullable(2)]
		private FLGUIAtlasSettings _defaultAtlasSetting;

		// Token: 0x040110C0 RID: 69824
		internal static int __PropertyOffset_atlasSettingForSpecificPackingTag;

		// Token: 0x040110C1 RID: 69825
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FLGUIAtlasSettings> _atlasSettingForSpecificPackingTag;

		// Token: 0x040110C2 RID: 69826
		internal static int __PropertyOffset_defaultTraceChannel;

		// Token: 0x040110C3 RID: 69827
		internal static int __PropertyOffset_antiAliasing;

		// Token: 0x040110C4 RID: 69828
		internal static int __PropertyOffset_fixedInfo;

		// Token: 0x040110C5 RID: 69829
		[Nullable(2)]
		private FLGUIFixedInfo _fixedInfo;

		// Token: 0x040110C6 RID: 69830
		internal static int __PropertyOffset_niagaraSortOrderBias;

		// Token: 0x040110C7 RID: 69831
		internal static int __PropertyOffset_needTidyUpRatio;

		// Token: 0x040110C8 RID: 69832
		internal static int __PropertyOffset_DefaultWhiteTexturePath;

		// Token: 0x040110C9 RID: 69833
		internal static int __PropertyOffset_DefaultWhiteSpritePath;

		// Token: 0x040110CA RID: 69834
		internal static int __PropertyOffset_DefaultEventPrefabPath;

		// Token: 0x040110CB RID: 69835
		internal static int __PropertyOffset_DefaultScreenRootPath;

		// Token: 0x040110CC RID: 69836
		internal static int __PropertyOffset_DefaultWorldRootPath;

		// Token: 0x040110CD RID: 69837
		internal static int __PropertyOffset_DefaultChildPath;

		// Token: 0x040110CE RID: 69838
		internal static int __PropertyOffset_DefaultFontPath;

		// Token: 0x040110CF RID: 69839
		internal static int __PropertyOffset_MaxTextInput;

		// Token: 0x040110D0 RID: 69840
		internal static int __PropertyOffset_ThDict;

		// Token: 0x040110D1 RID: 69841
		internal static int __PropertyOffset_ThFontSetting;

		// Token: 0x040110D2 RID: 69842
		internal static int __PropertyOffset_PcPrefix;

		// Token: 0x040110D3 RID: 69843
		internal static int __PropertyOffset_MobilePrefix;

		// Token: 0x040110D4 RID: 69844
		internal static int __PropertyOffset_BasePrefabItemName;

		// Token: 0x040110D5 RID: 69845
		internal static int __PropertyOffset_PlatformReplacePath;

		// Token: 0x040110D6 RID: 69846
		internal static int __PropertyOffset_PlatformSequenceReplacePath;

		// Token: 0x040110D7 RID: 69847
		internal static int __PropertyOffset_PcDirectory;

		// Token: 0x040110D8 RID: 69848
		internal static int __PropertyOffset_PcSequenceDirectory;

		// Token: 0x040110D9 RID: 69849
		internal static int __PropertyOffset_PcSequenceTmpPath;

		// Token: 0x040110DA RID: 69850
		[Nullable(2)]
		private FSoftObjectPath _PcSequenceTmpPath;

		// Token: 0x040110DB RID: 69851
		internal static int __PropertyOffset_PcSequencePostfix;

		// Token: 0x040110DC RID: 69852
		internal static int __PropertyOffset_MobileDirectory;

		// Token: 0x040110DD RID: 69853
		internal static int __PropertyOffset_MaxSequenceActorTriggerCollect;

		// Token: 0x040110DE RID: 69854
		internal static int __PropertyOffset_SequenceActorTriggerCollectInterval;

		// Token: 0x040110DF RID: 69855
		internal static int __PropertyOffset_MaxDiscreteTextureSize;

		// Token: 0x040110E0 RID: 69856
		internal static int __PropertyOffset_DynamicAtlasFailAttemptSecs;

		// Token: 0x040110E1 RID: 69857
		internal static int __PropertyOffset_DynamicAtlasNum;

		// Token: 0x040110E2 RID: 69858
		internal static int __PropertyOffset_MaxAttemptInsertTime;

		// Token: 0x040110E3 RID: 69859
		internal static int __PropertyOffset_bUseNewSequenceBinding;
	}
}
