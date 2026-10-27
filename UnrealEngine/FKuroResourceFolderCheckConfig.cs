using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D0A RID: 3338
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KuroResourceFolderCheckConfig")]
	[UnrealStructLayout(624, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 624)]
	public class FKuroResourceFolderCheckConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B1E8 RID: 45544 RVA: 0x000FCAFC File Offset: 0x000FACFC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroResourceFolderCheckConfig._ScriptStructPtr != 0) ? FKuroResourceFolderCheckConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroResourceFolderCheckConfig", ref FKuroResourceFolderCheckConfig._ScriptStructPtr);
		}

		// Token: 0x17002863 RID: 10339
		// (get) Token: 0x0600B1E9 RID: 45545 RVA: 0x000FCB20 File Offset: 0x000FAD20
		// (set) Token: 0x0600B1EA RID: 45546 RVA: 0x000FCB34 File Offset: 0x000FAD34
		public unsafe string Regex
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_Regex)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_Regex)), value);
			}
		}

		// Token: 0x17002864 RID: 10340
		// (get) Token: 0x0600B1EB RID: 45547 RVA: 0x000FCB4C File Offset: 0x000FAD4C
		// (set) Token: 0x0600B1EC RID: 45548 RVA: 0x000FCB8F File Offset: 0x000FAD8F
		public TArray<FKuroStaticMeshFolderCheckConfig> StaticMeshConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroStaticMeshFolderCheckConfig> result;
				if ((result = this._StaticMeshConfig) == null)
				{
					result = (this._StaticMeshConfig = new TArray<FKuroStaticMeshFolderCheckConfig>(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_StaticMeshConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StaticMeshConfig.CopyAssign(value);
			}
		}

		// Token: 0x17002865 RID: 10341
		// (get) Token: 0x0600B1ED RID: 45549 RVA: 0x000FCBA0 File Offset: 0x000FADA0
		// (set) Token: 0x0600B1EE RID: 45550 RVA: 0x000FCBE3 File Offset: 0x000FADE3
		public TArray<FKuroTextureFolderCheckConfig> TextureConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroTextureFolderCheckConfig> result;
				if ((result = this._TextureConfig) == null)
				{
					result = (this._TextureConfig = new TArray<FKuroTextureFolderCheckConfig>(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_TextureConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TextureConfig.CopyAssign(value);
			}
		}

		// Token: 0x17002866 RID: 10342
		// (get) Token: 0x0600B1EF RID: 45551 RVA: 0x000FCBF4 File Offset: 0x000FADF4
		// (set) Token: 0x0600B1F0 RID: 45552 RVA: 0x000FCC37 File Offset: 0x000FAE37
		public TArray<FKuroSkeletalMeshFolderCheckConfig> SkeletalMeshConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroSkeletalMeshFolderCheckConfig> result;
				if ((result = this._SkeletalMeshConfig) == null)
				{
					result = (this._SkeletalMeshConfig = new TArray<FKuroSkeletalMeshFolderCheckConfig>(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_SkeletalMeshConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SkeletalMeshConfig.CopyAssign(value);
			}
		}

		// Token: 0x17002867 RID: 10343
		// (get) Token: 0x0600B1F1 RID: 45553 RVA: 0x000FCC48 File Offset: 0x000FAE48
		// (set) Token: 0x0600B1F2 RID: 45554 RVA: 0x000FCC8B File Offset: 0x000FAE8B
		public TArray<FKuroMaterialInstFolderCheckConfig> MaterialInstanceConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroMaterialInstFolderCheckConfig> result;
				if ((result = this._MaterialInstanceConfig) == null)
				{
					result = (this._MaterialInstanceConfig = new TArray<FKuroMaterialInstFolderCheckConfig>(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_MaterialInstanceConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MaterialInstanceConfig.CopyAssign(value);
			}
		}

		// Token: 0x17002868 RID: 10344
		// (get) Token: 0x0600B1F3 RID: 45555 RVA: 0x000FCC9C File Offset: 0x000FAE9C
		// (set) Token: 0x0600B1F4 RID: 45556 RVA: 0x000FCCDF File Offset: 0x000FAEDF
		public TArray<FKuroMaterialFolderCheckConfig> MaterialConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroMaterialFolderCheckConfig> result;
				if ((result = this._MaterialConfig) == null)
				{
					result = (this._MaterialConfig = new TArray<FKuroMaterialFolderCheckConfig>(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_MaterialConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MaterialConfig.CopyAssign(value);
			}
		}

		// Token: 0x17002869 RID: 10345
		// (get) Token: 0x0600B1F5 RID: 45557 RVA: 0x000FCCF0 File Offset: 0x000FAEF0
		// (set) Token: 0x0600B1F6 RID: 45558 RVA: 0x000FCD33 File Offset: 0x000FAF33
		public TArray<FKuroFoliageTypeFolderCheckConfig> FoliageTypeConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroFoliageTypeFolderCheckConfig> result;
				if ((result = this._FoliageTypeConfig) == null)
				{
					result = (this._FoliageTypeConfig = new TArray<FKuroFoliageTypeFolderCheckConfig>(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_FoliageTypeConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FoliageTypeConfig.CopyAssign(value);
			}
		}

		// Token: 0x1700286A RID: 10346
		// (get) Token: 0x0600B1F7 RID: 45559 RVA: 0x000FCD44 File Offset: 0x000FAF44
		// (set) Token: 0x0600B1F8 RID: 45560 RVA: 0x000FCD87 File Offset: 0x000FAF87
		public TArray<FKuroEffectModelNiagaraFolderCheckConfig> EffectModelNiagaraConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroEffectModelNiagaraFolderCheckConfig> result;
				if ((result = this._EffectModelNiagaraConfig) == null)
				{
					result = (this._EffectModelNiagaraConfig = new TArray<FKuroEffectModelNiagaraFolderCheckConfig>(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_EffectModelNiagaraConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EffectModelNiagaraConfig.CopyAssign(value);
			}
		}

		// Token: 0x1700286B RID: 10347
		// (get) Token: 0x0600B1F9 RID: 45561 RVA: 0x000FCD98 File Offset: 0x000FAF98
		// (set) Token: 0x0600B1FA RID: 45562 RVA: 0x000FCDDB File Offset: 0x000FAFDB
		public TArray<FKuroEffectModelBaseFolderCheckConfig> EffectModelBaseConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroEffectModelBaseFolderCheckConfig> result;
				if ((result = this._EffectModelBaseConfig) == null)
				{
					result = (this._EffectModelBaseConfig = new TArray<FKuroEffectModelBaseFolderCheckConfig>(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_EffectModelBaseConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EffectModelBaseConfig.CopyAssign(value);
			}
		}

		// Token: 0x1700286C RID: 10348
		// (get) Token: 0x0600B1FB RID: 45563 RVA: 0x000FCDEC File Offset: 0x000FAFEC
		// (set) Token: 0x0600B1FC RID: 45564 RVA: 0x000FCE2F File Offset: 0x000FB02F
		public TArray<FKuroEffectModelGroupFolderCheckConfig> EffectModelGroupConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroEffectModelGroupFolderCheckConfig> result;
				if ((result = this._EffectModelGroupConfig) == null)
				{
					result = (this._EffectModelGroupConfig = new TArray<FKuroEffectModelGroupFolderCheckConfig>(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_EffectModelGroupConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EffectModelGroupConfig.CopyAssign(value);
			}
		}

		// Token: 0x1700286D RID: 10349
		// (get) Token: 0x0600B1FD RID: 45565 RVA: 0x000FCE40 File Offset: 0x000FB040
		// (set) Token: 0x0600B1FE RID: 45566 RVA: 0x000FCE83 File Offset: 0x000FB083
		public TArray<FKuroNPCSetupDataFolderCheckConfig> NpcSetupDataConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroNPCSetupDataFolderCheckConfig> result;
				if ((result = this._NpcSetupDataConfig) == null)
				{
					result = (this._NpcSetupDataConfig = new TArray<FKuroNPCSetupDataFolderCheckConfig>(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_NpcSetupDataConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.NpcSetupDataConfig.CopyAssign(value);
			}
		}

		// Token: 0x1700286E RID: 10350
		// (get) Token: 0x0600B1FF RID: 45567 RVA: 0x000FCE94 File Offset: 0x000FB094
		// (set) Token: 0x0600B200 RID: 45568 RVA: 0x000FCED7 File Offset: 0x000FB0D7
		public TArray<FKuroSkeletonFolderCheckConfig> SkeletonConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroSkeletonFolderCheckConfig> result;
				if ((result = this._SkeletonConfig) == null)
				{
					result = (this._SkeletonConfig = new TArray<FKuroSkeletonFolderCheckConfig>(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_SkeletonConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SkeletonConfig.CopyAssign(value);
			}
		}

		// Token: 0x1700286F RID: 10351
		// (get) Token: 0x0600B201 RID: 45569 RVA: 0x000FCEE8 File Offset: 0x000FB0E8
		// (set) Token: 0x0600B202 RID: 45570 RVA: 0x000FCF2B File Offset: 0x000FB12B
		public TArray<FKuroNiagaraFolderCheckConfig> NiagaraConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroNiagaraFolderCheckConfig> result;
				if ((result = this._NiagaraConfig) == null)
				{
					result = (this._NiagaraConfig = new TArray<FKuroNiagaraFolderCheckConfig>(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_NiagaraConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.NiagaraConfig.CopyAssign(value);
			}
		}

		// Token: 0x17002870 RID: 10352
		// (get) Token: 0x0600B203 RID: 45571 RVA: 0x000FCF3C File Offset: 0x000FB13C
		// (set) Token: 0x0600B204 RID: 45572 RVA: 0x000FCF7F File Offset: 0x000FB17F
		public TArray<FKuroPoseAssetFolderCheckConfig> PoseAssetConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroPoseAssetFolderCheckConfig> result;
				if ((result = this._PoseAssetConfig) == null)
				{
					result = (this._PoseAssetConfig = new TArray<FKuroPoseAssetFolderCheckConfig>(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_PoseAssetConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PoseAssetConfig.CopyAssign(value);
			}
		}

		// Token: 0x17002871 RID: 10353
		// (get) Token: 0x0600B205 RID: 45573 RVA: 0x000FCF90 File Offset: 0x000FB190
		// (set) Token: 0x0600B206 RID: 45574 RVA: 0x000FCFD3 File Offset: 0x000FB1D3
		public TArray<FKuroAnimSequenceFolderCheckConfig> AnimSequenceConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroAnimSequenceFolderCheckConfig> result;
				if ((result = this._AnimSequenceConfig) == null)
				{
					result = (this._AnimSequenceConfig = new TArray<FKuroAnimSequenceFolderCheckConfig>(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_AnimSequenceConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AnimSequenceConfig.CopyAssign(value);
			}
		}

		// Token: 0x17002872 RID: 10354
		// (get) Token: 0x0600B207 RID: 45575 RVA: 0x000FCFE4 File Offset: 0x000FB1E4
		// (set) Token: 0x0600B208 RID: 45576 RVA: 0x000FD027 File Offset: 0x000FB227
		public TArray<FKuroLevelFolderCheckConfig> LevelConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroLevelFolderCheckConfig> result;
				if ((result = this._LevelConfig) == null)
				{
					result = (this._LevelConfig = new TArray<FKuroLevelFolderCheckConfig>(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_LevelConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LevelConfig.CopyAssign(value);
			}
		}

		// Token: 0x17002873 RID: 10355
		// (get) Token: 0x0600B209 RID: 45577 RVA: 0x000FD038 File Offset: 0x000FB238
		// (set) Token: 0x0600B20A RID: 45578 RVA: 0x000FD07B File Offset: 0x000FB27B
		public TArray<FKuroMediaPlayerFolderCheckConfig> MediaPlayerDAConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroMediaPlayerFolderCheckConfig> result;
				if ((result = this._MediaPlayerDAConfig) == null)
				{
					result = (this._MediaPlayerDAConfig = new TArray<FKuroMediaPlayerFolderCheckConfig>(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_MediaPlayerDAConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MediaPlayerDAConfig.CopyAssign(value);
			}
		}

		// Token: 0x17002874 RID: 10356
		// (get) Token: 0x0600B20B RID: 45579 RVA: 0x000FD08C File Offset: 0x000FB28C
		// (set) Token: 0x0600B20C RID: 45580 RVA: 0x000FD0CF File Offset: 0x000FB2CF
		public TArray<FSpineDataFolderCheckConfig> SpineDataConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSpineDataFolderCheckConfig> result;
				if ((result = this._SpineDataConfig) == null)
				{
					result = (this._SpineDataConfig = new TArray<FSpineDataFolderCheckConfig>(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_SpineDataConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SpineDataConfig.CopyAssign(value);
			}
		}

		// Token: 0x17002875 RID: 10357
		// (get) Token: 0x0600B20D RID: 45581 RVA: 0x000FD0E0 File Offset: 0x000FB2E0
		// (set) Token: 0x0600B20E RID: 45582 RVA: 0x000FD123 File Offset: 0x000FB323
		public TArray<FKuroRenderTarget2DFolderCheckConfig> RenderTarget2DConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroRenderTarget2DFolderCheckConfig> result;
				if ((result = this._RenderTarget2DConfig) == null)
				{
					result = (this._RenderTarget2DConfig = new TArray<FKuroRenderTarget2DFolderCheckConfig>(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_RenderTarget2DConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RenderTarget2DConfig.CopyAssign(value);
			}
		}

		// Token: 0x17002876 RID: 10358
		// (get) Token: 0x0600B20F RID: 45583 RVA: 0x000FD134 File Offset: 0x000FB334
		// (set) Token: 0x0600B210 RID: 45584 RVA: 0x000FD177 File Offset: 0x000FB377
		public TArray<FKuroStreamingGroupConfig> StreamingGroupConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroStreamingGroupConfig> result;
				if ((result = this._StreamingGroupConfig) == null)
				{
					result = (this._StreamingGroupConfig = new TArray<FKuroStreamingGroupConfig>(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_StreamingGroupConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StreamingGroupConfig.CopyAssign(value);
			}
		}

		// Token: 0x17002877 RID: 10359
		// (get) Token: 0x0600B211 RID: 45585 RVA: 0x000FD185 File Offset: 0x000FB385
		// (set) Token: 0x0600B212 RID: 45586 RVA: 0x000FD199 File Offset: 0x000FB399
		public unsafe string SpriteRegex
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_SpriteRegex)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_SpriteRegex)), value);
			}
		}

		// Token: 0x17002878 RID: 10360
		// (get) Token: 0x0600B213 RID: 45587 RVA: 0x000FD1AE File Offset: 0x000FB3AE
		// (set) Token: 0x0600B214 RID: 45588 RVA: 0x000FD1C2 File Offset: 0x000FB3C2
		public unsafe string LGUIPrefabRegex
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_LGUIPrefabRegex)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_LGUIPrefabRegex)), value);
			}
		}

		// Token: 0x17002879 RID: 10361
		// (get) Token: 0x0600B215 RID: 45589 RVA: 0x000FD1D7 File Offset: 0x000FB3D7
		// (set) Token: 0x0600B216 RID: 45590 RVA: 0x000FD1E7 File Offset: 0x000FB3E7
		public unsafe bool IsTexImportCheckFailDelete
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_IsTexImportCheckFailDelete) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_IsTexImportCheckFailDelete) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700287A RID: 10362
		// (get) Token: 0x0600B217 RID: 45591 RVA: 0x000FD1F8 File Offset: 0x000FB3F8
		// (set) Token: 0x0600B218 RID: 45592 RVA: 0x000FD208 File Offset: 0x000FB408
		public unsafe bool IsAutoCheckXls
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_IsAutoCheckXls) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_IsAutoCheckXls) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700287B RID: 10363
		// (get) Token: 0x0600B219 RID: 45593 RVA: 0x000FD219 File Offset: 0x000FB419
		// (set) Token: 0x0600B21A RID: 45594 RVA: 0x000FD229 File Offset: 0x000FB429
		public unsafe bool IsAutoCheckFolder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_IsAutoCheckFolder) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_IsAutoCheckFolder) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700287C RID: 10364
		// (get) Token: 0x0600B21B RID: 45595 RVA: 0x000FD23A File Offset: 0x000FB43A
		// (set) Token: 0x0600B21C RID: 45596 RVA: 0x000FD24A File Offset: 0x000FB44A
		public unsafe int ObsoleteDays
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_ObsoleteDays);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_ObsoleteDays) = value;
			}
		}

		// Token: 0x1700287D RID: 10365
		// (get) Token: 0x0600B21D RID: 45597 RVA: 0x000FD25C File Offset: 0x000FB45C
		// (set) Token: 0x0600B21E RID: 45598 RVA: 0x000FD29F File Offset: 0x000FB49F
		public TArray<FKuroCommonTypeFolderCheckConfig> CommonTypeConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCommonTypeFolderCheckConfig> result;
				if ((result = this._CommonTypeConfig) == null)
				{
					result = (this._CommonTypeConfig = new TArray<FKuroCommonTypeFolderCheckConfig>(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_CommonTypeConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CommonTypeConfig.CopyAssign(value);
			}
		}

		// Token: 0x1700287E RID: 10366
		// (get) Token: 0x0600B21F RID: 45599 RVA: 0x000FD2B0 File Offset: 0x000FB4B0
		// (set) Token: 0x0600B220 RID: 45600 RVA: 0x000FD2F3 File Offset: 0x000FB4F3
		public TArray<string> StaticMeshNameTagRegex
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._StaticMeshNameTagRegex) == null)
				{
					result = (this._StaticMeshNameTagRegex = new TArray<string>(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_StaticMeshNameTagRegex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StaticMeshNameTagRegex.CopyAssign(value);
			}
		}

		// Token: 0x1700287F RID: 10367
		// (get) Token: 0x0600B221 RID: 45601 RVA: 0x000FD304 File Offset: 0x000FB504
		// (set) Token: 0x0600B222 RID: 45602 RVA: 0x000FD347 File Offset: 0x000FB547
		public TArray<string> MatNameTagRegex
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._MatNameTagRegex) == null)
				{
					result = (this._MatNameTagRegex = new TArray<string>(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_MatNameTagRegex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MatNameTagRegex.CopyAssign(value);
			}
		}

		// Token: 0x17002880 RID: 10368
		// (get) Token: 0x0600B223 RID: 45603 RVA: 0x000FD358 File Offset: 0x000FB558
		// (set) Token: 0x0600B224 RID: 45604 RVA: 0x000FD39B File Offset: 0x000FB59B
		public TArray<string> TexNameTagRegex
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._TexNameTagRegex) == null)
				{
					result = (this._TexNameTagRegex = new TArray<string>(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_TexNameTagRegex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TexNameTagRegex.CopyAssign(value);
			}
		}

		// Token: 0x17002881 RID: 10369
		// (get) Token: 0x0600B225 RID: 45605 RVA: 0x000FD3AC File Offset: 0x000FB5AC
		// (set) Token: 0x0600B226 RID: 45606 RVA: 0x000FD3EF File Offset: 0x000FB5EF
		public TArray<string> MatInstAllowOverrideTwoSidedRegex
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._MatInstAllowOverrideTwoSidedRegex) == null)
				{
					result = (this._MatInstAllowOverrideTwoSidedRegex = new TArray<string>(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_MatInstAllowOverrideTwoSidedRegex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MatInstAllowOverrideTwoSidedRegex.CopyAssign(value);
			}
		}

		// Token: 0x17002882 RID: 10370
		// (get) Token: 0x0600B227 RID: 45607 RVA: 0x000FD400 File Offset: 0x000FB600
		// (set) Token: 0x0600B228 RID: 45608 RVA: 0x000FD443 File Offset: 0x000FB643
		public TArray<string> SkipFolder
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._SkipFolder) == null)
				{
					result = (this._SkipFolder = new TArray<string>(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_SkipFolder, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SkipFolder.CopyAssign(value);
			}
		}

		// Token: 0x17002883 RID: 10371
		// (get) Token: 0x0600B229 RID: 45609 RVA: 0x000FD454 File Offset: 0x000FB654
		// (set) Token: 0x0600B22A RID: 45610 RVA: 0x000FD497 File Offset: 0x000FB697
		public TArray<string> SkipCheckNameFolder
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._SkipCheckNameFolder) == null)
				{
					result = (this._SkipCheckNameFolder = new TArray<string>(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_SkipCheckNameFolder, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SkipCheckNameFolder.CopyAssign(value);
			}
		}

		// Token: 0x17002884 RID: 10372
		// (get) Token: 0x0600B22B RID: 45611 RVA: 0x000FD4A8 File Offset: 0x000FB6A8
		// (set) Token: 0x0600B22C RID: 45612 RVA: 0x000FD4EB File Offset: 0x000FB6EB
		public TArray<string> NeverUseVertexComporessMats
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._NeverUseVertexComporessMats) == null)
				{
					result = (this._NeverUseVertexComporessMats = new TArray<string>(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_NeverUseVertexComporessMats, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.NeverUseVertexComporessMats.CopyAssign(value);
			}
		}

		// Token: 0x17002885 RID: 10373
		// (get) Token: 0x0600B22D RID: 45613 RVA: 0x000FD4F9 File Offset: 0x000FB6F9
		// (set) Token: 0x0600B22E RID: 45614 RVA: 0x000FD509 File Offset: 0x000FB709
		public unsafe bool MeshAutoHandleNoCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_MeshAutoHandleNoCollision) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_MeshAutoHandleNoCollision) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002886 RID: 10374
		// (get) Token: 0x0600B22F RID: 45615 RVA: 0x000FD51C File Offset: 0x000FB71C
		// (set) Token: 0x0600B230 RID: 45616 RVA: 0x000FD55F File Offset: 0x000FB75F
		public TArray<string> MinInitRequestMipRegex
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._MinInitRequestMipRegex) == null)
				{
					result = (this._MinInitRequestMipRegex = new TArray<string>(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_MinInitRequestMipRegex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MinInitRequestMipRegex.CopyAssign(value);
			}
		}

		// Token: 0x17002887 RID: 10375
		// (get) Token: 0x0600B231 RID: 45617 RVA: 0x000FD56D File Offset: 0x000FB76D
		// (set) Token: 0x0600B232 RID: 45618 RVA: 0x000FD57D File Offset: 0x000FB77D
		public unsafe int MinInitRequestMipTextureSizeThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_MinInitRequestMipTextureSizeThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_MinInitRequestMipTextureSizeThreshold) = value;
			}
		}

		// Token: 0x17002888 RID: 10376
		// (get) Token: 0x0600B233 RID: 45619 RVA: 0x000FD590 File Offset: 0x000FB790
		// (set) Token: 0x0600B234 RID: 45620 RVA: 0x000FD5D3 File Offset: 0x000FB7D3
		public TArray<string> MinInitRequestMipSettingPlatform
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._MinInitRequestMipSettingPlatform) == null)
				{
					result = (this._MinInitRequestMipSettingPlatform = new TArray<string>(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_MinInitRequestMipSettingPlatform, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MinInitRequestMipSettingPlatform.CopyAssign(value);
			}
		}

		// Token: 0x17002889 RID: 10377
		// (get) Token: 0x0600B235 RID: 45621 RVA: 0x000FD5E4 File Offset: 0x000FB7E4
		// (set) Token: 0x0600B236 RID: 45622 RVA: 0x000FD627 File Offset: 0x000FB827
		public TArray<int> MinInitRequestMipSetting
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._MinInitRequestMipSetting) == null)
				{
					result = (this._MinInitRequestMipSetting = new TArray<int>(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_MinInitRequestMipSetting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MinInitRequestMipSetting.CopyAssign(value);
			}
		}

		// Token: 0x1700288A RID: 10378
		// (get) Token: 0x0600B237 RID: 45623 RVA: 0x000FD638 File Offset: 0x000FB838
		// (set) Token: 0x0600B238 RID: 45624 RVA: 0x000FD67B File Offset: 0x000FB87B
		public TArray<string> SpecificCompressionQualityRegex
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._SpecificCompressionQualityRegex) == null)
				{
					result = (this._SpecificCompressionQualityRegex = new TArray<string>(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_SpecificCompressionQualityRegex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SpecificCompressionQualityRegex.CopyAssign(value);
			}
		}

		// Token: 0x1700288B RID: 10379
		// (get) Token: 0x0600B239 RID: 45625 RVA: 0x000FD68C File Offset: 0x000FB88C
		// (set) Token: 0x0600B23A RID: 45626 RVA: 0x000FD6CF File Offset: 0x000FB8CF
		public TArray<string> SpecificCompressionQuality
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._SpecificCompressionQuality) == null)
				{
					result = (this._SpecificCompressionQuality = new TArray<string>(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_SpecificCompressionQuality, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SpecificCompressionQuality.CopyAssign(value);
			}
		}

		// Token: 0x1700288C RID: 10380
		// (get) Token: 0x0600B23B RID: 45627 RVA: 0x000FD6E0 File Offset: 0x000FB8E0
		// (set) Token: 0x0600B23C RID: 45628 RVA: 0x000FD723 File Offset: 0x000FB923
		public TArray<int> SpecificCompressionQualityMaxSize
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._SpecificCompressionQualityMaxSize) == null)
				{
					result = (this._SpecificCompressionQualityMaxSize = new TArray<int>(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_SpecificCompressionQualityMaxSize, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SpecificCompressionQualityMaxSize.CopyAssign(value);
			}
		}

		// Token: 0x1700288D RID: 10381
		// (get) Token: 0x0600B23D RID: 45629 RVA: 0x000FD731 File Offset: 0x000FB931
		// (set) Token: 0x0600B23E RID: 45630 RVA: 0x000FD741 File Offset: 0x000FB941
		public unsafe int StaticMeshNonStrictTrianglesThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_StaticMeshNonStrictTrianglesThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_StaticMeshNonStrictTrianglesThreshold) = value;
			}
		}

		// Token: 0x1700288E RID: 10382
		// (get) Token: 0x0600B23F RID: 45631 RVA: 0x000FD754 File Offset: 0x000FB954
		// (set) Token: 0x0600B240 RID: 45632 RVA: 0x000FD797 File Offset: 0x000FB997
		public TArray<string> NeverUseFlipGreenChannelRegex
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._NeverUseFlipGreenChannelRegex) == null)
				{
					result = (this._NeverUseFlipGreenChannelRegex = new TArray<string>(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfig.__PropertyOffset_NeverUseFlipGreenChannelRegex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.NeverUseFlipGreenChannelRegex.CopyAssign(value);
			}
		}

		// Token: 0x0600B241 RID: 45633 RVA: 0x000FD7A5 File Offset: 0x000FB9A5
		public FKuroResourceFolderCheckConfig()
		{
		}

		// Token: 0x0600B242 RID: 45634 RVA: 0x000FD7B0 File Offset: 0x000FB9B0
		public FKuroResourceFolderCheckConfig(string Regex, TArray<FKuroStaticMeshFolderCheckConfig> StaticMeshConfig, TArray<FKuroTextureFolderCheckConfig> TextureConfig, TArray<FKuroSkeletalMeshFolderCheckConfig> SkeletalMeshConfig, TArray<FKuroMaterialInstFolderCheckConfig> MaterialInstanceConfig, TArray<FKuroMaterialFolderCheckConfig> MaterialConfig, TArray<FKuroFoliageTypeFolderCheckConfig> FoliageTypeConfig, TArray<FKuroEffectModelNiagaraFolderCheckConfig> EffectModelNiagaraConfig, TArray<FKuroEffectModelBaseFolderCheckConfig> EffectModelBaseConfig, TArray<FKuroEffectModelGroupFolderCheckConfig> EffectModelGroupConfig, TArray<FKuroNPCSetupDataFolderCheckConfig> NpcSetupDataConfig, TArray<FKuroSkeletonFolderCheckConfig> SkeletonConfig, TArray<FKuroNiagaraFolderCheckConfig> NiagaraConfig, TArray<FKuroPoseAssetFolderCheckConfig> PoseAssetConfig, TArray<FKuroAnimSequenceFolderCheckConfig> AnimSequenceConfig, TArray<FKuroLevelFolderCheckConfig> LevelConfig, TArray<FKuroMediaPlayerFolderCheckConfig> MediaPlayerDAConfig, TArray<FSpineDataFolderCheckConfig> SpineDataConfig, TArray<FKuroRenderTarget2DFolderCheckConfig> RenderTarget2DConfig, TArray<FKuroStreamingGroupConfig> StreamingGroupConfig, string SpriteRegex, string LGUIPrefabRegex, bool IsTexImportCheckFailDelete, bool IsAutoCheckXls, bool IsAutoCheckFolder, int ObsoleteDays, TArray<FKuroCommonTypeFolderCheckConfig> CommonTypeConfig, TArray<string> StaticMeshNameTagRegex, TArray<string> MatNameTagRegex, TArray<string> TexNameTagRegex, TArray<string> MatInstAllowOverrideTwoSidedRegex, TArray<string> SkipFolder, TArray<string> SkipCheckNameFolder, TArray<string> NeverUseVertexComporessMats, bool MeshAutoHandleNoCollision, TArray<string> MinInitRequestMipRegex, int MinInitRequestMipTextureSizeThreshold, TArray<string> MinInitRequestMipSettingPlatform, TArray<int> MinInitRequestMipSetting, TArray<string> SpecificCompressionQualityRegex, TArray<string> SpecificCompressionQuality, TArray<int> SpecificCompressionQualityMaxSize, int StaticMeshNonStrictTrianglesThreshold, TArray<string> NeverUseFlipGreenChannelRegex)
		{
			this.Regex = Regex;
			this.StaticMeshConfig = StaticMeshConfig;
			this.TextureConfig = TextureConfig;
			this.SkeletalMeshConfig = SkeletalMeshConfig;
			this.MaterialInstanceConfig = MaterialInstanceConfig;
			this.MaterialConfig = MaterialConfig;
			this.FoliageTypeConfig = FoliageTypeConfig;
			this.EffectModelNiagaraConfig = EffectModelNiagaraConfig;
			this.EffectModelBaseConfig = EffectModelBaseConfig;
			this.EffectModelGroupConfig = EffectModelGroupConfig;
			this.NpcSetupDataConfig = NpcSetupDataConfig;
			this.SkeletonConfig = SkeletonConfig;
			this.NiagaraConfig = NiagaraConfig;
			this.PoseAssetConfig = PoseAssetConfig;
			this.AnimSequenceConfig = AnimSequenceConfig;
			this.LevelConfig = LevelConfig;
			this.MediaPlayerDAConfig = MediaPlayerDAConfig;
			this.SpineDataConfig = SpineDataConfig;
			this.RenderTarget2DConfig = RenderTarget2DConfig;
			this.StreamingGroupConfig = StreamingGroupConfig;
			this.SpriteRegex = SpriteRegex;
			this.LGUIPrefabRegex = LGUIPrefabRegex;
			this.IsTexImportCheckFailDelete = IsTexImportCheckFailDelete;
			this.IsAutoCheckXls = IsAutoCheckXls;
			this.IsAutoCheckFolder = IsAutoCheckFolder;
			this.ObsoleteDays = ObsoleteDays;
			this.CommonTypeConfig = CommonTypeConfig;
			this.StaticMeshNameTagRegex = StaticMeshNameTagRegex;
			this.MatNameTagRegex = MatNameTagRegex;
			this.TexNameTagRegex = TexNameTagRegex;
			this.MatInstAllowOverrideTwoSidedRegex = MatInstAllowOverrideTwoSidedRegex;
			this.SkipFolder = SkipFolder;
			this.SkipCheckNameFolder = SkipCheckNameFolder;
			this.NeverUseVertexComporessMats = NeverUseVertexComporessMats;
			this.MeshAutoHandleNoCollision = MeshAutoHandleNoCollision;
			this.MinInitRequestMipRegex = MinInitRequestMipRegex;
			this.MinInitRequestMipTextureSizeThreshold = MinInitRequestMipTextureSizeThreshold;
			this.MinInitRequestMipSettingPlatform = MinInitRequestMipSettingPlatform;
			this.MinInitRequestMipSetting = MinInitRequestMipSetting;
			this.SpecificCompressionQualityRegex = SpecificCompressionQualityRegex;
			this.SpecificCompressionQuality = SpecificCompressionQuality;
			this.SpecificCompressionQualityMaxSize = SpecificCompressionQualityMaxSize;
			this.StaticMeshNonStrictTrianglesThreshold = StaticMeshNonStrictTrianglesThreshold;
			this.NeverUseFlipGreenChannelRegex = NeverUseFlipGreenChannelRegex;
		}

		// Token: 0x0600B243 RID: 45635 RVA: 0x000FD920 File Offset: 0x000FBB20
		protected override IntPtr GetUStructPtr()
		{
			return FKuroResourceFolderCheckConfig.StaticStruct();
		}

		// Token: 0x0600B244 RID: 45636 RVA: 0x000FD92C File Offset: 0x000FBB2C
		[NullableContext(2)]
		public FKuroResourceFolderCheckConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B245 RID: 45637 RVA: 0x000FD936 File Offset: 0x000FBB36
		public FKuroResourceFolderCheckConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B246 RID: 45638 RVA: 0x000FD941 File Offset: 0x000FBB41
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroResourceFolderCheckConfig(Pointer, false, true);
		}

		// Token: 0x0600B247 RID: 45639 RVA: 0x000FD94B File Offset: 0x000FBB4B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroResourceFolderCheckConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04005D32 RID: 23858
		public const string __ObjectPath = "/Script/Engine.KuroResourceFolderCheckConfig";

		// Token: 0x04005D33 RID: 23859
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005D34 RID: 23860
		internal static int __PropertyOffset_Regex;

		// Token: 0x04005D35 RID: 23861
		internal static int __PropertyOffset_StaticMeshConfig;

		// Token: 0x04005D36 RID: 23862
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroStaticMeshFolderCheckConfig> _StaticMeshConfig;

		// Token: 0x04005D37 RID: 23863
		internal static int __PropertyOffset_TextureConfig;

		// Token: 0x04005D38 RID: 23864
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroTextureFolderCheckConfig> _TextureConfig;

		// Token: 0x04005D39 RID: 23865
		internal static int __PropertyOffset_SkeletalMeshConfig;

		// Token: 0x04005D3A RID: 23866
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroSkeletalMeshFolderCheckConfig> _SkeletalMeshConfig;

		// Token: 0x04005D3B RID: 23867
		internal static int __PropertyOffset_MaterialInstanceConfig;

		// Token: 0x04005D3C RID: 23868
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroMaterialInstFolderCheckConfig> _MaterialInstanceConfig;

		// Token: 0x04005D3D RID: 23869
		internal static int __PropertyOffset_MaterialConfig;

		// Token: 0x04005D3E RID: 23870
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroMaterialFolderCheckConfig> _MaterialConfig;

		// Token: 0x04005D3F RID: 23871
		internal static int __PropertyOffset_FoliageTypeConfig;

		// Token: 0x04005D40 RID: 23872
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroFoliageTypeFolderCheckConfig> _FoliageTypeConfig;

		// Token: 0x04005D41 RID: 23873
		internal static int __PropertyOffset_EffectModelNiagaraConfig;

		// Token: 0x04005D42 RID: 23874
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroEffectModelNiagaraFolderCheckConfig> _EffectModelNiagaraConfig;

		// Token: 0x04005D43 RID: 23875
		internal static int __PropertyOffset_EffectModelBaseConfig;

		// Token: 0x04005D44 RID: 23876
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroEffectModelBaseFolderCheckConfig> _EffectModelBaseConfig;

		// Token: 0x04005D45 RID: 23877
		internal static int __PropertyOffset_EffectModelGroupConfig;

		// Token: 0x04005D46 RID: 23878
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroEffectModelGroupFolderCheckConfig> _EffectModelGroupConfig;

		// Token: 0x04005D47 RID: 23879
		internal static int __PropertyOffset_NpcSetupDataConfig;

		// Token: 0x04005D48 RID: 23880
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroNPCSetupDataFolderCheckConfig> _NpcSetupDataConfig;

		// Token: 0x04005D49 RID: 23881
		internal static int __PropertyOffset_SkeletonConfig;

		// Token: 0x04005D4A RID: 23882
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroSkeletonFolderCheckConfig> _SkeletonConfig;

		// Token: 0x04005D4B RID: 23883
		internal static int __PropertyOffset_NiagaraConfig;

		// Token: 0x04005D4C RID: 23884
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroNiagaraFolderCheckConfig> _NiagaraConfig;

		// Token: 0x04005D4D RID: 23885
		internal static int __PropertyOffset_PoseAssetConfig;

		// Token: 0x04005D4E RID: 23886
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroPoseAssetFolderCheckConfig> _PoseAssetConfig;

		// Token: 0x04005D4F RID: 23887
		internal static int __PropertyOffset_AnimSequenceConfig;

		// Token: 0x04005D50 RID: 23888
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroAnimSequenceFolderCheckConfig> _AnimSequenceConfig;

		// Token: 0x04005D51 RID: 23889
		internal static int __PropertyOffset_LevelConfig;

		// Token: 0x04005D52 RID: 23890
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroLevelFolderCheckConfig> _LevelConfig;

		// Token: 0x04005D53 RID: 23891
		internal static int __PropertyOffset_MediaPlayerDAConfig;

		// Token: 0x04005D54 RID: 23892
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroMediaPlayerFolderCheckConfig> _MediaPlayerDAConfig;

		// Token: 0x04005D55 RID: 23893
		internal static int __PropertyOffset_SpineDataConfig;

		// Token: 0x04005D56 RID: 23894
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSpineDataFolderCheckConfig> _SpineDataConfig;

		// Token: 0x04005D57 RID: 23895
		internal static int __PropertyOffset_RenderTarget2DConfig;

		// Token: 0x04005D58 RID: 23896
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroRenderTarget2DFolderCheckConfig> _RenderTarget2DConfig;

		// Token: 0x04005D59 RID: 23897
		internal static int __PropertyOffset_StreamingGroupConfig;

		// Token: 0x04005D5A RID: 23898
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroStreamingGroupConfig> _StreamingGroupConfig;

		// Token: 0x04005D5B RID: 23899
		internal static int __PropertyOffset_SpriteRegex;

		// Token: 0x04005D5C RID: 23900
		internal static int __PropertyOffset_LGUIPrefabRegex;

		// Token: 0x04005D5D RID: 23901
		internal static int __PropertyOffset_IsTexImportCheckFailDelete;

		// Token: 0x04005D5E RID: 23902
		internal static int __PropertyOffset_IsAutoCheckXls;

		// Token: 0x04005D5F RID: 23903
		internal static int __PropertyOffset_IsAutoCheckFolder;

		// Token: 0x04005D60 RID: 23904
		internal static int __PropertyOffset_ObsoleteDays;

		// Token: 0x04005D61 RID: 23905
		internal static int __PropertyOffset_CommonTypeConfig;

		// Token: 0x04005D62 RID: 23906
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCommonTypeFolderCheckConfig> _CommonTypeConfig;

		// Token: 0x04005D63 RID: 23907
		internal static int __PropertyOffset_StaticMeshNameTagRegex;

		// Token: 0x04005D64 RID: 23908
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _StaticMeshNameTagRegex;

		// Token: 0x04005D65 RID: 23909
		internal static int __PropertyOffset_MatNameTagRegex;

		// Token: 0x04005D66 RID: 23910
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _MatNameTagRegex;

		// Token: 0x04005D67 RID: 23911
		internal static int __PropertyOffset_TexNameTagRegex;

		// Token: 0x04005D68 RID: 23912
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _TexNameTagRegex;

		// Token: 0x04005D69 RID: 23913
		internal static int __PropertyOffset_MatInstAllowOverrideTwoSidedRegex;

		// Token: 0x04005D6A RID: 23914
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _MatInstAllowOverrideTwoSidedRegex;

		// Token: 0x04005D6B RID: 23915
		internal static int __PropertyOffset_SkipFolder;

		// Token: 0x04005D6C RID: 23916
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _SkipFolder;

		// Token: 0x04005D6D RID: 23917
		internal static int __PropertyOffset_SkipCheckNameFolder;

		// Token: 0x04005D6E RID: 23918
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _SkipCheckNameFolder;

		// Token: 0x04005D6F RID: 23919
		internal static int __PropertyOffset_NeverUseVertexComporessMats;

		// Token: 0x04005D70 RID: 23920
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _NeverUseVertexComporessMats;

		// Token: 0x04005D71 RID: 23921
		internal static int __PropertyOffset_MeshAutoHandleNoCollision;

		// Token: 0x04005D72 RID: 23922
		internal static int __PropertyOffset_MinInitRequestMipRegex;

		// Token: 0x04005D73 RID: 23923
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _MinInitRequestMipRegex;

		// Token: 0x04005D74 RID: 23924
		internal static int __PropertyOffset_MinInitRequestMipTextureSizeThreshold;

		// Token: 0x04005D75 RID: 23925
		internal static int __PropertyOffset_MinInitRequestMipSettingPlatform;

		// Token: 0x04005D76 RID: 23926
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _MinInitRequestMipSettingPlatform;

		// Token: 0x04005D77 RID: 23927
		internal static int __PropertyOffset_MinInitRequestMipSetting;

		// Token: 0x04005D78 RID: 23928
		[Nullable(2)]
		private TArray<int> _MinInitRequestMipSetting;

		// Token: 0x04005D79 RID: 23929
		internal static int __PropertyOffset_SpecificCompressionQualityRegex;

		// Token: 0x04005D7A RID: 23930
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _SpecificCompressionQualityRegex;

		// Token: 0x04005D7B RID: 23931
		internal static int __PropertyOffset_SpecificCompressionQuality;

		// Token: 0x04005D7C RID: 23932
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _SpecificCompressionQuality;

		// Token: 0x04005D7D RID: 23933
		internal static int __PropertyOffset_SpecificCompressionQualityMaxSize;

		// Token: 0x04005D7E RID: 23934
		[Nullable(2)]
		private TArray<int> _SpecificCompressionQualityMaxSize;

		// Token: 0x04005D7F RID: 23935
		internal static int __PropertyOffset_StaticMeshNonStrictTrianglesThreshold;

		// Token: 0x04005D80 RID: 23936
		internal static int __PropertyOffset_NeverUseFlipGreenChannelRegex;

		// Token: 0x04005D81 RID: 23937
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _NeverUseFlipGreenChannelRegex;
	}
}
