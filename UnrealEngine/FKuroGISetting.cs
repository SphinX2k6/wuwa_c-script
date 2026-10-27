using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B0A RID: 6922
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroGISetting")]
	[UnrealStructLayout(5136, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 5136)]
	public class FKuroGISetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06019EBA RID: 106170 RVA: 0x00264214 File Offset: 0x00262414
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroGISetting._ScriptStructPtr != 0) ? FKuroGISetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroGISetting", ref FKuroGISetting._ScriptStructPtr);
		}

		// Token: 0x170067DD RID: 26589
		// (get) Token: 0x06019EBB RID: 106171 RVA: 0x00264238 File Offset: 0x00262438
		// (set) Token: 0x06019EBC RID: 106172 RVA: 0x0026427B File Offset: 0x0026247B
		public FMainLightSetting MainLightSetting
		{
			get
			{
				base.FastCheckIsValid();
				FMainLightSetting result;
				if ((result = this._MainLightSetting) == null)
				{
					result = (this._MainLightSetting = new FMainLightSetting(base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_MainLightSetting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMainLightSetting.StaticStruct(), base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_MainLightSetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170067DE RID: 26590
		// (get) Token: 0x06019EBD RID: 106173 RVA: 0x0026429C File Offset: 0x0026249C
		// (set) Token: 0x06019EBE RID: 106174 RVA: 0x002642DF File Offset: 0x002624DF
		public FSkyLightSetting SkyLightSetting
		{
			get
			{
				base.FastCheckIsValid();
				FSkyLightSetting result;
				if ((result = this._SkyLightSetting) == null)
				{
					result = (this._SkyLightSetting = new FSkyLightSetting(base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_SkyLightSetting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSkyLightSetting.StaticStruct(), base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_SkyLightSetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170067DF RID: 26591
		// (get) Token: 0x06019EBF RID: 106175 RVA: 0x00264300 File Offset: 0x00262500
		// (set) Token: 0x06019EC0 RID: 106176 RVA: 0x00264343 File Offset: 0x00262543
		public FShadowTintSetting ShadowTintSetting
		{
			get
			{
				base.FastCheckIsValid();
				FShadowTintSetting result;
				if ((result = this._ShadowTintSetting) == null)
				{
					result = (this._ShadowTintSetting = new FShadowTintSetting(base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_ShadowTintSetting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FShadowTintSetting.StaticStruct(), base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_ShadowTintSetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170067E0 RID: 26592
		// (get) Token: 0x06019EC1 RID: 106177 RVA: 0x00264364 File Offset: 0x00262564
		// (set) Token: 0x06019EC2 RID: 106178 RVA: 0x002643A7 File Offset: 0x002625A7
		public FCharacterSetting CharacterSetting
		{
			get
			{
				base.FastCheckIsValid();
				FCharacterSetting result;
				if ((result = this._CharacterSetting) == null)
				{
					result = (this._CharacterSetting = new FCharacterSetting(base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_CharacterSetting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCharacterSetting.StaticStruct(), base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_CharacterSetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170067E1 RID: 26593
		// (get) Token: 0x06019EC3 RID: 106179 RVA: 0x002643C8 File Offset: 0x002625C8
		// (set) Token: 0x06019EC4 RID: 106180 RVA: 0x0026440B File Offset: 0x0026260B
		public FKuroHeightFogSetting KuroFogSetting
		{
			get
			{
				base.FastCheckIsValid();
				FKuroHeightFogSetting result;
				if ((result = this._KuroFogSetting) == null)
				{
					result = (this._KuroFogSetting = new FKuroHeightFogSetting(base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_KuroFogSetting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroHeightFogSetting.StaticStruct(), base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_KuroFogSetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170067E2 RID: 26594
		// (get) Token: 0x06019EC5 RID: 106181 RVA: 0x0026442C File Offset: 0x0026262C
		// (set) Token: 0x06019EC6 RID: 106182 RVA: 0x0026446F File Offset: 0x0026266F
		public FKuroEffectFogSetting KuroEffectFogSetting
		{
			get
			{
				base.FastCheckIsValid();
				FKuroEffectFogSetting result;
				if ((result = this._KuroEffectFogSetting) == null)
				{
					result = (this._KuroEffectFogSetting = new FKuroEffectFogSetting(base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_KuroEffectFogSetting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroEffectFogSetting.StaticStruct(), base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_KuroEffectFogSetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170067E3 RID: 26595
		// (get) Token: 0x06019EC7 RID: 106183 RVA: 0x00264490 File Offset: 0x00262690
		// (set) Token: 0x06019EC8 RID: 106184 RVA: 0x002644D3 File Offset: 0x002626D3
		public FKuroWpoFogCorrSetting KuroWpoFogCorrSetting
		{
			get
			{
				base.FastCheckIsValid();
				FKuroWpoFogCorrSetting result;
				if ((result = this._KuroWpoFogCorrSetting) == null)
				{
					result = (this._KuroWpoFogCorrSetting = new FKuroWpoFogCorrSetting(base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_KuroWpoFogCorrSetting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroWpoFogCorrSetting.StaticStruct(), base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_KuroWpoFogCorrSetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170067E4 RID: 26596
		// (get) Token: 0x06019EC9 RID: 106185 RVA: 0x002644F4 File Offset: 0x002626F4
		// (set) Token: 0x06019ECA RID: 106186 RVA: 0x00264537 File Offset: 0x00262737
		public FKuroTreeSetting KuroTreeSetting
		{
			get
			{
				base.FastCheckIsValid();
				FKuroTreeSetting result;
				if ((result = this._KuroTreeSetting) == null)
				{
					result = (this._KuroTreeSetting = new FKuroTreeSetting(base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_KuroTreeSetting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroTreeSetting.StaticStruct(), base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_KuroTreeSetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170067E5 RID: 26597
		// (get) Token: 0x06019ECB RID: 106187 RVA: 0x00264558 File Offset: 0x00262758
		// (set) Token: 0x06019ECC RID: 106188 RVA: 0x0026459B File Offset: 0x0026279B
		public FVolumetricFogSetting VolumetricFogSetting
		{
			get
			{
				base.FastCheckIsValid();
				FVolumetricFogSetting result;
				if ((result = this._VolumetricFogSetting) == null)
				{
					result = (this._VolumetricFogSetting = new FVolumetricFogSetting(base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_VolumetricFogSetting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FVolumetricFogSetting.StaticStruct(), base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_VolumetricFogSetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170067E6 RID: 26598
		// (get) Token: 0x06019ECD RID: 106189 RVA: 0x002645BC File Offset: 0x002627BC
		// (set) Token: 0x06019ECE RID: 106190 RVA: 0x002645FF File Offset: 0x002627FF
		public FOriginSkyAtmosphereSetting OriginSkyAtmosphereSetting
		{
			get
			{
				base.FastCheckIsValid();
				FOriginSkyAtmosphereSetting result;
				if ((result = this._OriginSkyAtmosphereSetting) == null)
				{
					result = (this._OriginSkyAtmosphereSetting = new FOriginSkyAtmosphereSetting(base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_OriginSkyAtmosphereSetting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FOriginSkyAtmosphereSetting.StaticStruct(), base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_OriginSkyAtmosphereSetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170067E7 RID: 26599
		// (get) Token: 0x06019ECF RID: 106191 RVA: 0x00264620 File Offset: 0x00262820
		// (set) Token: 0x06019ED0 RID: 106192 RVA: 0x00264663 File Offset: 0x00262863
		public FSkyAtmosphereSetting SkyAtmoSphereSetting
		{
			get
			{
				base.FastCheckIsValid();
				FSkyAtmosphereSetting result;
				if ((result = this._SkyAtmoSphereSetting) == null)
				{
					result = (this._SkyAtmoSphereSetting = new FSkyAtmosphereSetting(base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_SkyAtmoSphereSetting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSkyAtmosphereSetting.StaticStruct(), base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_SkyAtmoSphereSetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170067E8 RID: 26600
		// (get) Token: 0x06019ED1 RID: 106193 RVA: 0x00264684 File Offset: 0x00262884
		// (set) Token: 0x06019ED2 RID: 106194 RVA: 0x002646C7 File Offset: 0x002628C7
		public FKuroOceanSetting FKuroOceanSetting
		{
			get
			{
				base.FastCheckIsValid();
				FKuroOceanSetting result;
				if ((result = this._FKuroOceanSetting) == null)
				{
					result = (this._FKuroOceanSetting = new FKuroOceanSetting(base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_FKuroOceanSetting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroOceanSetting.StaticStruct(), base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_FKuroOceanSetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170067E9 RID: 26601
		// (get) Token: 0x06019ED3 RID: 106195 RVA: 0x002646E8 File Offset: 0x002628E8
		// (set) Token: 0x06019ED4 RID: 106196 RVA: 0x0026472B File Offset: 0x0026292B
		public FKuroSkyboxSetting KuroSkybox
		{
			get
			{
				base.FastCheckIsValid();
				FKuroSkyboxSetting result;
				if ((result = this._KuroSkybox) == null)
				{
					result = (this._KuroSkybox = new FKuroSkyboxSetting(base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_KuroSkybox, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroSkyboxSetting.StaticStruct(), base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_KuroSkybox, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170067EA RID: 26602
		// (get) Token: 0x06019ED5 RID: 106197 RVA: 0x0026474C File Offset: 0x0026294C
		// (set) Token: 0x06019ED6 RID: 106198 RVA: 0x0026478F File Offset: 0x0026298F
		public FKuroMountainSetting KuroMountainSetting
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMountainSetting result;
				if ((result = this._KuroMountainSetting) == null)
				{
					result = (this._KuroMountainSetting = new FKuroMountainSetting(base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_KuroMountainSetting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMountainSetting.StaticStruct(), base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_KuroMountainSetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170067EB RID: 26603
		// (get) Token: 0x06019ED7 RID: 106199 RVA: 0x002647B0 File Offset: 0x002629B0
		// (set) Token: 0x06019ED8 RID: 106200 RVA: 0x002647F3 File Offset: 0x002629F3
		public FKuroLensFlareSetting LensFlareSetting
		{
			get
			{
				base.FastCheckIsValid();
				FKuroLensFlareSetting result;
				if ((result = this._LensFlareSetting) == null)
				{
					result = (this._LensFlareSetting = new FKuroLensFlareSetting(base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_LensFlareSetting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroLensFlareSetting.StaticStruct(), base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_LensFlareSetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170067EC RID: 26604
		// (get) Token: 0x06019ED9 RID: 106201 RVA: 0x00264814 File Offset: 0x00262A14
		// (set) Token: 0x06019EDA RID: 106202 RVA: 0x00264857 File Offset: 0x00262A57
		public FWindSetting WindSetting
		{
			get
			{
				base.FastCheckIsValid();
				FWindSetting result;
				if ((result = this._WindSetting) == null)
				{
					result = (this._WindSetting = new FWindSetting(base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_WindSetting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FWindSetting.StaticStruct(), base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_WindSetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170067ED RID: 26605
		// (get) Token: 0x06019EDB RID: 106203 RVA: 0x00264878 File Offset: 0x00262A78
		// (set) Token: 0x06019EDC RID: 106204 RVA: 0x002648BB File Offset: 0x00262ABB
		public FStarSetting StarSetting
		{
			get
			{
				base.FastCheckIsValid();
				FStarSetting result;
				if ((result = this._StarSetting) == null)
				{
					result = (this._StarSetting = new FStarSetting(base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_StarSetting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FStarSetting.StaticStruct(), base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_StarSetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170067EE RID: 26606
		// (get) Token: 0x06019EDD RID: 106205 RVA: 0x002648DC File Offset: 0x00262ADC
		// (set) Token: 0x06019EDE RID: 106206 RVA: 0x0026491F File Offset: 0x00262B1F
		public FKuroCloudCardSetting CloudCardSetting
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCloudCardSetting result;
				if ((result = this._CloudCardSetting) == null)
				{
					result = (this._CloudCardSetting = new FKuroCloudCardSetting(base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_CloudCardSetting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCloudCardSetting.StaticStruct(), base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_CloudCardSetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170067EF RID: 26607
		// (get) Token: 0x06019EDF RID: 106207 RVA: 0x00264940 File Offset: 0x00262B40
		// (set) Token: 0x06019EE0 RID: 106208 RVA: 0x00264983 File Offset: 0x00262B83
		public FKuroSkyVolumetricCloudSetting SkyVolumetricCloudSetting
		{
			get
			{
				base.FastCheckIsValid();
				FKuroSkyVolumetricCloudSetting result;
				if ((result = this._SkyVolumetricCloudSetting) == null)
				{
					result = (this._SkyVolumetricCloudSetting = new FKuroSkyVolumetricCloudSetting(base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_SkyVolumetricCloudSetting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroSkyVolumetricCloudSetting.StaticStruct(), base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_SkyVolumetricCloudSetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170067F0 RID: 26608
		// (get) Token: 0x06019EE1 RID: 106209 RVA: 0x002649A4 File Offset: 0x00262BA4
		// (set) Token: 0x06019EE2 RID: 106210 RVA: 0x002649E7 File Offset: 0x00262BE7
		public FKuroMultipleLayerSkySetting MultipleLayerSkySetting
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMultipleLayerSkySetting result;
				if ((result = this._MultipleLayerSkySetting) == null)
				{
					result = (this._MultipleLayerSkySetting = new FKuroMultipleLayerSkySetting(base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_MultipleLayerSkySetting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMultipleLayerSkySetting.StaticStruct(), base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_MultipleLayerSkySetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170067F1 RID: 26609
		// (get) Token: 0x06019EE3 RID: 106211 RVA: 0x00264A08 File Offset: 0x00262C08
		// (set) Token: 0x06019EE4 RID: 106212 RVA: 0x00264A4B File Offset: 0x00262C4B
		public FKuroGodRaySetting GodRaySetting
		{
			get
			{
				base.FastCheckIsValid();
				FKuroGodRaySetting result;
				if ((result = this._GodRaySetting) == null)
				{
					result = (this._GodRaySetting = new FKuroGodRaySetting(base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_GodRaySetting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroGodRaySetting.StaticStruct(), base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_GodRaySetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170067F2 RID: 26610
		// (get) Token: 0x06019EE5 RID: 106213 RVA: 0x00264A6C File Offset: 0x00262C6C
		// (set) Token: 0x06019EE6 RID: 106214 RVA: 0x00264AAF File Offset: 0x00262CAF
		public FVolumeCloudGodRaySetting VolumeCloudGodRaySetting
		{
			get
			{
				base.FastCheckIsValid();
				FVolumeCloudGodRaySetting result;
				if ((result = this._VolumeCloudGodRaySetting) == null)
				{
					result = (this._VolumeCloudGodRaySetting = new FVolumeCloudGodRaySetting(base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_VolumeCloudGodRaySetting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FVolumeCloudGodRaySetting.StaticStruct(), base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_VolumeCloudGodRaySetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170067F3 RID: 26611
		// (get) Token: 0x06019EE7 RID: 106215 RVA: 0x00264AD0 File Offset: 0x00262CD0
		// (set) Token: 0x06019EE8 RID: 106216 RVA: 0x00264B13 File Offset: 0x00262D13
		public FKuroMilkyWaySetting MilkyWaySetting
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMilkyWaySetting result;
				if ((result = this._MilkyWaySetting) == null)
				{
					result = (this._MilkyWaySetting = new FKuroMilkyWaySetting(base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_MilkyWaySetting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMilkyWaySetting.StaticStruct(), base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_MilkyWaySetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170067F4 RID: 26612
		// (get) Token: 0x06019EE9 RID: 106217 RVA: 0x00264B34 File Offset: 0x00262D34
		// (set) Token: 0x06019EEA RID: 106218 RVA: 0x00264B77 File Offset: 0x00262D77
		public FGIMiscSetting MiscSetting
		{
			get
			{
				base.FastCheckIsValid();
				FGIMiscSetting result;
				if ((result = this._MiscSetting) == null)
				{
					result = (this._MiscSetting = new FGIMiscSetting(base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_MiscSetting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGIMiscSetting.StaticStruct(), base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_MiscSetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170067F5 RID: 26613
		// (get) Token: 0x06019EEB RID: 106219 RVA: 0x00264B98 File Offset: 0x00262D98
		// (set) Token: 0x06019EEC RID: 106220 RVA: 0x00264BDB File Offset: 0x00262DDB
		public FGIClusteredStuffSetting ClusteredStuffSetting
		{
			get
			{
				base.FastCheckIsValid();
				FGIClusteredStuffSetting result;
				if ((result = this._ClusteredStuffSetting) == null)
				{
					result = (this._ClusteredStuffSetting = new FGIClusteredStuffSetting(base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_ClusteredStuffSetting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGIClusteredStuffSetting.StaticStruct(), base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_ClusteredStuffSetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170067F6 RID: 26614
		// (get) Token: 0x06019EED RID: 106221 RVA: 0x00264BFC File Offset: 0x00262DFC
		// (set) Token: 0x06019EEE RID: 106222 RVA: 0x00264C3F File Offset: 0x00262E3F
		public FKuroGIMPCSetting GIMPCSetting
		{
			get
			{
				base.FastCheckIsValid();
				FKuroGIMPCSetting result;
				if ((result = this._GIMPCSetting) == null)
				{
					result = (this._GIMPCSetting = new FKuroGIMPCSetting(base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_GIMPCSetting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroGIMPCSetting.StaticStruct(), base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_GIMPCSetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170067F7 RID: 26615
		// (get) Token: 0x06019EEF RID: 106223 RVA: 0x00264C60 File Offset: 0x00262E60
		// (set) Token: 0x06019EF0 RID: 106224 RVA: 0x00264CA3 File Offset: 0x00262EA3
		public FKuroGIExtendedMPCSetting ExtendedMPCSetting
		{
			get
			{
				base.FastCheckIsValid();
				FKuroGIExtendedMPCSetting result;
				if ((result = this._ExtendedMPCSetting) == null)
				{
					result = (this._ExtendedMPCSetting = new FKuroGIExtendedMPCSetting(base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_ExtendedMPCSetting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroGIExtendedMPCSetting.StaticStruct(), base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_ExtendedMPCSetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170067F8 RID: 26616
		// (get) Token: 0x06019EF1 RID: 106225 RVA: 0x00264CC4 File Offset: 0x00262EC4
		// (set) Token: 0x06019EF2 RID: 106226 RVA: 0x00264D07 File Offset: 0x00262F07
		public FKuroPostProcessSetting KuroPostProcess
		{
			get
			{
				base.FastCheckIsValid();
				FKuroPostProcessSetting result;
				if ((result = this._KuroPostProcess) == null)
				{
					result = (this._KuroPostProcess = new FKuroPostProcessSetting(base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_KuroPostProcess, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroPostProcessSetting.StaticStruct(), base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_KuroPostProcess, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170067F9 RID: 26617
		// (get) Token: 0x06019EF3 RID: 106227 RVA: 0x00264D28 File Offset: 0x00262F28
		// (set) Token: 0x06019EF4 RID: 106228 RVA: 0x00264D6B File Offset: 0x00262F6B
		public FKuroScreenSoftSetting KuroScreenSoft
		{
			get
			{
				base.FastCheckIsValid();
				FKuroScreenSoftSetting result;
				if ((result = this._KuroScreenSoft) == null)
				{
					result = (this._KuroScreenSoft = new FKuroScreenSoftSetting(base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_KuroScreenSoft, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroScreenSoftSetting.StaticStruct(), base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_KuroScreenSoft, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170067FA RID: 26618
		// (get) Token: 0x06019EF5 RID: 106229 RVA: 0x00264D8C File Offset: 0x00262F8C
		// (set) Token: 0x06019EF6 RID: 106230 RVA: 0x00264DCF File Offset: 0x00262FCF
		public FKuroFFTBloomSetting FFTBloomSetting
		{
			get
			{
				base.FastCheckIsValid();
				FKuroFFTBloomSetting result;
				if ((result = this._FFTBloomSetting) == null)
				{
					result = (this._FFTBloomSetting = new FKuroFFTBloomSetting(base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_FFTBloomSetting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroFFTBloomSetting.StaticStruct(), base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_FFTBloomSetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170067FB RID: 26619
		// (get) Token: 0x06019EF7 RID: 106231 RVA: 0x00264DF0 File Offset: 0x00262FF0
		// (set) Token: 0x06019EF8 RID: 106232 RVA: 0x00264E33 File Offset: 0x00263033
		public FGlobalLightSetting GlobalLightSetting
		{
			get
			{
				base.FastCheckIsValid();
				FGlobalLightSetting result;
				if ((result = this._GlobalLightSetting) == null)
				{
					result = (this._GlobalLightSetting = new FGlobalLightSetting(base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_GlobalLightSetting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGlobalLightSetting.StaticStruct(), base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_GlobalLightSetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170067FC RID: 26620
		// (get) Token: 0x06019EF9 RID: 106233 RVA: 0x00264E54 File Offset: 0x00263054
		// (set) Token: 0x06019EFA RID: 106234 RVA: 0x00264E97 File Offset: 0x00263097
		public FRayTracingSettings RayTracingSettings
		{
			get
			{
				base.FastCheckIsValid();
				FRayTracingSettings result;
				if ((result = this._RayTracingSettings) == null)
				{
					result = (this._RayTracingSettings = new FRayTracingSettings(base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_RayTracingSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRayTracingSettings.StaticStruct(), base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_RayTracingSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170067FD RID: 26621
		// (get) Token: 0x06019EFB RID: 106235 RVA: 0x00264EB8 File Offset: 0x002630B8
		// (set) Token: 0x06019EFC RID: 106236 RVA: 0x00264EFB File Offset: 0x002630FB
		public FCascadeLightingVolumeSettings CascadeLightingVolumeSettings
		{
			get
			{
				base.FastCheckIsValid();
				FCascadeLightingVolumeSettings result;
				if ((result = this._CascadeLightingVolumeSettings) == null)
				{
					result = (this._CascadeLightingVolumeSettings = new FCascadeLightingVolumeSettings(base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_CascadeLightingVolumeSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCascadeLightingVolumeSettings.StaticStruct(), base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_CascadeLightingVolumeSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170067FE RID: 26622
		// (get) Token: 0x06019EFD RID: 106237 RVA: 0x00264F1C File Offset: 0x0026311C
		// (set) Token: 0x06019EFE RID: 106238 RVA: 0x00264F5F File Offset: 0x0026315F
		public FDistanceFieldSettings DistanceFieldSettings
		{
			get
			{
				base.FastCheckIsValid();
				FDistanceFieldSettings result;
				if ((result = this._DistanceFieldSettings) == null)
				{
					result = (this._DistanceFieldSettings = new FDistanceFieldSettings(base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_DistanceFieldSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDistanceFieldSettings.StaticStruct(), base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_DistanceFieldSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170067FF RID: 26623
		// (get) Token: 0x06019EFF RID: 106239 RVA: 0x00264F80 File Offset: 0x00263180
		// (set) Token: 0x06019F00 RID: 106240 RVA: 0x00264FC3 File Offset: 0x002631C3
		public FMainLightDistanceFieldShadowSetting MainLightDistanceFieldShadowSetting
		{
			get
			{
				base.FastCheckIsValid();
				FMainLightDistanceFieldShadowSetting result;
				if ((result = this._MainLightDistanceFieldShadowSetting) == null)
				{
					result = (this._MainLightDistanceFieldShadowSetting = new FMainLightDistanceFieldShadowSetting(base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_MainLightDistanceFieldShadowSetting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMainLightDistanceFieldShadowSetting.StaticStruct(), base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_MainLightDistanceFieldShadowSetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006800 RID: 26624
		// (get) Token: 0x06019F01 RID: 106241 RVA: 0x00264FE4 File Offset: 0x002631E4
		// (set) Token: 0x06019F02 RID: 106242 RVA: 0x00265027 File Offset: 0x00263227
		public FKuroEffectColorGradingSettings EffectColorGradingSettings
		{
			get
			{
				base.FastCheckIsValid();
				FKuroEffectColorGradingSettings result;
				if ((result = this._EffectColorGradingSettings) == null)
				{
					result = (this._EffectColorGradingSettings = new FKuroEffectColorGradingSettings(base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_EffectColorGradingSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroEffectColorGradingSettings.StaticStruct(), base.NativePtr + (IntPtr)FKuroGISetting.__PropertyOffset_EffectColorGradingSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06019F03 RID: 106243 RVA: 0x00265048 File Offset: 0x00263248
		public FKuroGISetting()
		{
		}

		// Token: 0x06019F04 RID: 106244 RVA: 0x00265050 File Offset: 0x00263250
		public FKuroGISetting(FMainLightSetting MainLightSetting, FSkyLightSetting SkyLightSetting, FShadowTintSetting ShadowTintSetting, FCharacterSetting CharacterSetting, FKuroHeightFogSetting KuroFogSetting, FKuroEffectFogSetting KuroEffectFogSetting, FKuroWpoFogCorrSetting KuroWpoFogCorrSetting, FKuroTreeSetting KuroTreeSetting, FVolumetricFogSetting VolumetricFogSetting, FOriginSkyAtmosphereSetting OriginSkyAtmosphereSetting, FSkyAtmosphereSetting SkyAtmoSphereSetting, FKuroOceanSetting FKuroOceanSetting, FKuroSkyboxSetting KuroSkybox, FKuroMountainSetting KuroMountainSetting, FKuroLensFlareSetting LensFlareSetting, FWindSetting WindSetting, FStarSetting StarSetting, FKuroCloudCardSetting CloudCardSetting, FKuroSkyVolumetricCloudSetting SkyVolumetricCloudSetting, FKuroMultipleLayerSkySetting MultipleLayerSkySetting, FKuroGodRaySetting GodRaySetting, FVolumeCloudGodRaySetting VolumeCloudGodRaySetting, FKuroMilkyWaySetting MilkyWaySetting, FGIMiscSetting MiscSetting, FGIClusteredStuffSetting ClusteredStuffSetting, FKuroGIMPCSetting GIMPCSetting, FKuroGIExtendedMPCSetting ExtendedMPCSetting, FKuroPostProcessSetting KuroPostProcess, FKuroScreenSoftSetting KuroScreenSoft, FKuroFFTBloomSetting FFTBloomSetting, FGlobalLightSetting GlobalLightSetting, FRayTracingSettings RayTracingSettings, FCascadeLightingVolumeSettings CascadeLightingVolumeSettings, FDistanceFieldSettings DistanceFieldSettings, FMainLightDistanceFieldShadowSetting MainLightDistanceFieldShadowSetting, FKuroEffectColorGradingSettings EffectColorGradingSettings)
		{
			this.MainLightSetting = MainLightSetting;
			this.SkyLightSetting = SkyLightSetting;
			this.ShadowTintSetting = ShadowTintSetting;
			this.CharacterSetting = CharacterSetting;
			this.KuroFogSetting = KuroFogSetting;
			this.KuroEffectFogSetting = KuroEffectFogSetting;
			this.KuroWpoFogCorrSetting = KuroWpoFogCorrSetting;
			this.KuroTreeSetting = KuroTreeSetting;
			this.VolumetricFogSetting = VolumetricFogSetting;
			this.OriginSkyAtmosphereSetting = OriginSkyAtmosphereSetting;
			this.SkyAtmoSphereSetting = SkyAtmoSphereSetting;
			this.FKuroOceanSetting = FKuroOceanSetting;
			this.KuroSkybox = KuroSkybox;
			this.KuroMountainSetting = KuroMountainSetting;
			this.LensFlareSetting = LensFlareSetting;
			this.WindSetting = WindSetting;
			this.StarSetting = StarSetting;
			this.CloudCardSetting = CloudCardSetting;
			this.SkyVolumetricCloudSetting = SkyVolumetricCloudSetting;
			this.MultipleLayerSkySetting = MultipleLayerSkySetting;
			this.GodRaySetting = GodRaySetting;
			this.VolumeCloudGodRaySetting = VolumeCloudGodRaySetting;
			this.MilkyWaySetting = MilkyWaySetting;
			this.MiscSetting = MiscSetting;
			this.ClusteredStuffSetting = ClusteredStuffSetting;
			this.GIMPCSetting = GIMPCSetting;
			this.ExtendedMPCSetting = ExtendedMPCSetting;
			this.KuroPostProcess = KuroPostProcess;
			this.KuroScreenSoft = KuroScreenSoft;
			this.FFTBloomSetting = FFTBloomSetting;
			this.GlobalLightSetting = GlobalLightSetting;
			this.RayTracingSettings = RayTracingSettings;
			this.CascadeLightingVolumeSettings = CascadeLightingVolumeSettings;
			this.DistanceFieldSettings = DistanceFieldSettings;
			this.MainLightDistanceFieldShadowSetting = MainLightDistanceFieldShadowSetting;
			this.EffectColorGradingSettings = EffectColorGradingSettings;
		}

		// Token: 0x06019F05 RID: 106245 RVA: 0x00265180 File Offset: 0x00263380
		protected override IntPtr GetUStructPtr()
		{
			return FKuroGISetting.StaticStruct();
		}

		// Token: 0x06019F06 RID: 106246 RVA: 0x0026518C File Offset: 0x0026338C
		[NullableContext(2)]
		public FKuroGISetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06019F07 RID: 106247 RVA: 0x00265196 File Offset: 0x00263396
		public FKuroGISetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06019F08 RID: 106248 RVA: 0x002651A1 File Offset: 0x002633A1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroGISetting(Pointer, false, true);
		}

		// Token: 0x06019F09 RID: 106249 RVA: 0x002651AB File Offset: 0x002633AB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroGISetting(Pointer, MemoryOwner);
		}

		// Token: 0x0400E168 RID: 57704
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroGISetting";

		// Token: 0x0400E169 RID: 57705
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E16A RID: 57706
		internal static int __PropertyOffset_MainLightSetting;

		// Token: 0x0400E16B RID: 57707
		[Nullable(2)]
		private FMainLightSetting _MainLightSetting;

		// Token: 0x0400E16C RID: 57708
		internal static int __PropertyOffset_SkyLightSetting;

		// Token: 0x0400E16D RID: 57709
		[Nullable(2)]
		private FSkyLightSetting _SkyLightSetting;

		// Token: 0x0400E16E RID: 57710
		internal static int __PropertyOffset_ShadowTintSetting;

		// Token: 0x0400E16F RID: 57711
		[Nullable(2)]
		private FShadowTintSetting _ShadowTintSetting;

		// Token: 0x0400E170 RID: 57712
		internal static int __PropertyOffset_CharacterSetting;

		// Token: 0x0400E171 RID: 57713
		[Nullable(2)]
		private FCharacterSetting _CharacterSetting;

		// Token: 0x0400E172 RID: 57714
		internal static int __PropertyOffset_KuroFogSetting;

		// Token: 0x0400E173 RID: 57715
		[Nullable(2)]
		private FKuroHeightFogSetting _KuroFogSetting;

		// Token: 0x0400E174 RID: 57716
		internal static int __PropertyOffset_KuroEffectFogSetting;

		// Token: 0x0400E175 RID: 57717
		[Nullable(2)]
		private FKuroEffectFogSetting _KuroEffectFogSetting;

		// Token: 0x0400E176 RID: 57718
		internal static int __PropertyOffset_KuroWpoFogCorrSetting;

		// Token: 0x0400E177 RID: 57719
		[Nullable(2)]
		private FKuroWpoFogCorrSetting _KuroWpoFogCorrSetting;

		// Token: 0x0400E178 RID: 57720
		internal static int __PropertyOffset_KuroTreeSetting;

		// Token: 0x0400E179 RID: 57721
		[Nullable(2)]
		private FKuroTreeSetting _KuroTreeSetting;

		// Token: 0x0400E17A RID: 57722
		internal static int __PropertyOffset_VolumetricFogSetting;

		// Token: 0x0400E17B RID: 57723
		[Nullable(2)]
		private FVolumetricFogSetting _VolumetricFogSetting;

		// Token: 0x0400E17C RID: 57724
		internal static int __PropertyOffset_OriginSkyAtmosphereSetting;

		// Token: 0x0400E17D RID: 57725
		[Nullable(2)]
		private FOriginSkyAtmosphereSetting _OriginSkyAtmosphereSetting;

		// Token: 0x0400E17E RID: 57726
		internal static int __PropertyOffset_SkyAtmoSphereSetting;

		// Token: 0x0400E17F RID: 57727
		[Nullable(2)]
		private FSkyAtmosphereSetting _SkyAtmoSphereSetting;

		// Token: 0x0400E180 RID: 57728
		internal static int __PropertyOffset_FKuroOceanSetting;

		// Token: 0x0400E181 RID: 57729
		[Nullable(2)]
		private FKuroOceanSetting _FKuroOceanSetting;

		// Token: 0x0400E182 RID: 57730
		internal static int __PropertyOffset_KuroSkybox;

		// Token: 0x0400E183 RID: 57731
		[Nullable(2)]
		private FKuroSkyboxSetting _KuroSkybox;

		// Token: 0x0400E184 RID: 57732
		internal static int __PropertyOffset_KuroMountainSetting;

		// Token: 0x0400E185 RID: 57733
		[Nullable(2)]
		private FKuroMountainSetting _KuroMountainSetting;

		// Token: 0x0400E186 RID: 57734
		internal static int __PropertyOffset_LensFlareSetting;

		// Token: 0x0400E187 RID: 57735
		[Nullable(2)]
		private FKuroLensFlareSetting _LensFlareSetting;

		// Token: 0x0400E188 RID: 57736
		internal static int __PropertyOffset_WindSetting;

		// Token: 0x0400E189 RID: 57737
		[Nullable(2)]
		private FWindSetting _WindSetting;

		// Token: 0x0400E18A RID: 57738
		internal static int __PropertyOffset_StarSetting;

		// Token: 0x0400E18B RID: 57739
		[Nullable(2)]
		private FStarSetting _StarSetting;

		// Token: 0x0400E18C RID: 57740
		internal static int __PropertyOffset_CloudCardSetting;

		// Token: 0x0400E18D RID: 57741
		[Nullable(2)]
		private FKuroCloudCardSetting _CloudCardSetting;

		// Token: 0x0400E18E RID: 57742
		internal static int __PropertyOffset_SkyVolumetricCloudSetting;

		// Token: 0x0400E18F RID: 57743
		[Nullable(2)]
		private FKuroSkyVolumetricCloudSetting _SkyVolumetricCloudSetting;

		// Token: 0x0400E190 RID: 57744
		internal static int __PropertyOffset_MultipleLayerSkySetting;

		// Token: 0x0400E191 RID: 57745
		[Nullable(2)]
		private FKuroMultipleLayerSkySetting _MultipleLayerSkySetting;

		// Token: 0x0400E192 RID: 57746
		internal static int __PropertyOffset_GodRaySetting;

		// Token: 0x0400E193 RID: 57747
		[Nullable(2)]
		private FKuroGodRaySetting _GodRaySetting;

		// Token: 0x0400E194 RID: 57748
		internal static int __PropertyOffset_VolumeCloudGodRaySetting;

		// Token: 0x0400E195 RID: 57749
		[Nullable(2)]
		private FVolumeCloudGodRaySetting _VolumeCloudGodRaySetting;

		// Token: 0x0400E196 RID: 57750
		internal static int __PropertyOffset_MilkyWaySetting;

		// Token: 0x0400E197 RID: 57751
		[Nullable(2)]
		private FKuroMilkyWaySetting _MilkyWaySetting;

		// Token: 0x0400E198 RID: 57752
		internal static int __PropertyOffset_MiscSetting;

		// Token: 0x0400E199 RID: 57753
		[Nullable(2)]
		private FGIMiscSetting _MiscSetting;

		// Token: 0x0400E19A RID: 57754
		internal static int __PropertyOffset_ClusteredStuffSetting;

		// Token: 0x0400E19B RID: 57755
		[Nullable(2)]
		private FGIClusteredStuffSetting _ClusteredStuffSetting;

		// Token: 0x0400E19C RID: 57756
		internal static int __PropertyOffset_GIMPCSetting;

		// Token: 0x0400E19D RID: 57757
		[Nullable(2)]
		private FKuroGIMPCSetting _GIMPCSetting;

		// Token: 0x0400E19E RID: 57758
		internal static int __PropertyOffset_ExtendedMPCSetting;

		// Token: 0x0400E19F RID: 57759
		[Nullable(2)]
		private FKuroGIExtendedMPCSetting _ExtendedMPCSetting;

		// Token: 0x0400E1A0 RID: 57760
		internal static int __PropertyOffset_KuroPostProcess;

		// Token: 0x0400E1A1 RID: 57761
		[Nullable(2)]
		private FKuroPostProcessSetting _KuroPostProcess;

		// Token: 0x0400E1A2 RID: 57762
		internal static int __PropertyOffset_KuroScreenSoft;

		// Token: 0x0400E1A3 RID: 57763
		[Nullable(2)]
		private FKuroScreenSoftSetting _KuroScreenSoft;

		// Token: 0x0400E1A4 RID: 57764
		internal static int __PropertyOffset_FFTBloomSetting;

		// Token: 0x0400E1A5 RID: 57765
		[Nullable(2)]
		private FKuroFFTBloomSetting _FFTBloomSetting;

		// Token: 0x0400E1A6 RID: 57766
		internal static int __PropertyOffset_GlobalLightSetting;

		// Token: 0x0400E1A7 RID: 57767
		[Nullable(2)]
		private FGlobalLightSetting _GlobalLightSetting;

		// Token: 0x0400E1A8 RID: 57768
		internal static int __PropertyOffset_RayTracingSettings;

		// Token: 0x0400E1A9 RID: 57769
		[Nullable(2)]
		private FRayTracingSettings _RayTracingSettings;

		// Token: 0x0400E1AA RID: 57770
		internal static int __PropertyOffset_CascadeLightingVolumeSettings;

		// Token: 0x0400E1AB RID: 57771
		[Nullable(2)]
		private FCascadeLightingVolumeSettings _CascadeLightingVolumeSettings;

		// Token: 0x0400E1AC RID: 57772
		internal static int __PropertyOffset_DistanceFieldSettings;

		// Token: 0x0400E1AD RID: 57773
		[Nullable(2)]
		private FDistanceFieldSettings _DistanceFieldSettings;

		// Token: 0x0400E1AE RID: 57774
		internal static int __PropertyOffset_MainLightDistanceFieldShadowSetting;

		// Token: 0x0400E1AF RID: 57775
		[Nullable(2)]
		private FMainLightDistanceFieldShadowSetting _MainLightDistanceFieldShadowSetting;

		// Token: 0x0400E1B0 RID: 57776
		internal static int __PropertyOffset_EffectColorGradingSettings;

		// Token: 0x0400E1B1 RID: 57777
		[Nullable(2)]
		private FKuroEffectColorGradingSettings _EffectColorGradingSettings;
	}
}
