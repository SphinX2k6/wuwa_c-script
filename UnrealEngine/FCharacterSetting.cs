using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001A57 RID: 6743
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.CharacterSetting")]
	[UnrealStructLayout(140, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 140)]
	public class FCharacterSetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06018EED RID: 102125 RVA: 0x0024DAB8 File Offset: 0x0024BCB8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCharacterSetting._ScriptStructPtr != 0) ? FCharacterSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.CharacterSetting", ref FCharacterSetting._ScriptStructPtr);
		}

		// Token: 0x170062BC RID: 25276
		// (get) Token: 0x06018EEE RID: 102126 RVA: 0x0024DADC File Offset: 0x0024BCDC
		// (set) Token: 0x06018EEF RID: 102127 RVA: 0x0024DAF5 File Offset: 0x0024BCF5
		public unsafe bool bOverride_CustomCharacterLightingIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_CustomCharacterLightingIntensity) & FCharacterSetting.__PropertyMask_bOverride_CustomCharacterLightingIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_CustomCharacterLightingIntensity) = ((*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_CustomCharacterLightingIntensity) & ~FCharacterSetting.__PropertyMask_bOverride_CustomCharacterLightingIntensity) | (value ? FCharacterSetting.__PropertyMask_bOverride_CustomCharacterLightingIntensity : 0));
			}
		}

		// Token: 0x170062BD RID: 25277
		// (get) Token: 0x06018EF0 RID: 102128 RVA: 0x0024DB25 File Offset: 0x0024BD25
		// (set) Token: 0x06018EF1 RID: 102129 RVA: 0x0024DB3E File Offset: 0x0024BD3E
		public unsafe bool bOverride_LightHorizontalAngle
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_LightHorizontalAngle) & FCharacterSetting.__PropertyMask_bOverride_LightHorizontalAngle) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_LightHorizontalAngle) = ((*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_LightHorizontalAngle) & ~FCharacterSetting.__PropertyMask_bOverride_LightHorizontalAngle) | (value ? FCharacterSetting.__PropertyMask_bOverride_LightHorizontalAngle : 0));
			}
		}

		// Token: 0x170062BE RID: 25278
		// (get) Token: 0x06018EF2 RID: 102130 RVA: 0x0024DB6E File Offset: 0x0024BD6E
		// (set) Token: 0x06018EF3 RID: 102131 RVA: 0x0024DB87 File Offset: 0x0024BD87
		public unsafe bool bOverride_CharacterDirectionMixIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_CharacterDirectionMixIntensity) & FCharacterSetting.__PropertyMask_bOverride_CharacterDirectionMixIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_CharacterDirectionMixIntensity) = ((*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_CharacterDirectionMixIntensity) & ~FCharacterSetting.__PropertyMask_bOverride_CharacterDirectionMixIntensity) | (value ? FCharacterSetting.__PropertyMask_bOverride_CharacterDirectionMixIntensity : 0));
			}
		}

		// Token: 0x170062BF RID: 25279
		// (get) Token: 0x06018EF4 RID: 102132 RVA: 0x0024DBB7 File Offset: 0x0024BDB7
		// (set) Token: 0x06018EF5 RID: 102133 RVA: 0x0024DBD0 File Offset: 0x0024BDD0
		public unsafe bool bOverride_MixCharacterLightingIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_MixCharacterLightingIntensity) & FCharacterSetting.__PropertyMask_bOverride_MixCharacterLightingIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_MixCharacterLightingIntensity) = ((*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_MixCharacterLightingIntensity) & ~FCharacterSetting.__PropertyMask_bOverride_MixCharacterLightingIntensity) | (value ? FCharacterSetting.__PropertyMask_bOverride_MixCharacterLightingIntensity : 0));
			}
		}

		// Token: 0x170062C0 RID: 25280
		// (get) Token: 0x06018EF6 RID: 102134 RVA: 0x0024DC00 File Offset: 0x0024BE00
		// (set) Token: 0x06018EF7 RID: 102135 RVA: 0x0024DC19 File Offset: 0x0024BE19
		public unsafe bool bOverride_CharacterAmbientColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_CharacterAmbientColor) & FCharacterSetting.__PropertyMask_bOverride_CharacterAmbientColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_CharacterAmbientColor) = ((*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_CharacterAmbientColor) & ~FCharacterSetting.__PropertyMask_bOverride_CharacterAmbientColor) | (value ? FCharacterSetting.__PropertyMask_bOverride_CharacterAmbientColor : 0));
			}
		}

		// Token: 0x170062C1 RID: 25281
		// (get) Token: 0x06018EF8 RID: 102136 RVA: 0x0024DC49 File Offset: 0x0024BE49
		// (set) Token: 0x06018EF9 RID: 102137 RVA: 0x0024DC62 File Offset: 0x0024BE62
		public unsafe bool bOverride_CharacterMainLightColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_CharacterMainLightColor) & FCharacterSetting.__PropertyMask_bOverride_CharacterMainLightColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_CharacterMainLightColor) = ((*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_CharacterMainLightColor) & ~FCharacterSetting.__PropertyMask_bOverride_CharacterMainLightColor) | (value ? FCharacterSetting.__PropertyMask_bOverride_CharacterMainLightColor : 0));
			}
		}

		// Token: 0x170062C2 RID: 25282
		// (get) Token: 0x06018EFA RID: 102138 RVA: 0x0024DC92 File Offset: 0x0024BE92
		// (set) Token: 0x06018EFB RID: 102139 RVA: 0x0024DCAB File Offset: 0x0024BEAB
		public unsafe bool bOverride_CharacterSkinShadowColorIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_CharacterSkinShadowColorIntensity) & FCharacterSetting.__PropertyMask_bOverride_CharacterSkinShadowColorIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_CharacterSkinShadowColorIntensity) = ((*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_CharacterSkinShadowColorIntensity) & ~FCharacterSetting.__PropertyMask_bOverride_CharacterSkinShadowColorIntensity) | (value ? FCharacterSetting.__PropertyMask_bOverride_CharacterSkinShadowColorIntensity : 0));
			}
		}

		// Token: 0x170062C3 RID: 25283
		// (get) Token: 0x06018EFC RID: 102140 RVA: 0x0024DCDB File Offset: 0x0024BEDB
		// (set) Token: 0x06018EFD RID: 102141 RVA: 0x0024DCF4 File Offset: 0x0024BEF4
		public unsafe bool bOverride_CharacterSSSIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_CharacterSSSIntensity) & FCharacterSetting.__PropertyMask_bOverride_CharacterSSSIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_CharacterSSSIntensity) = ((*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_CharacterSSSIntensity) & ~FCharacterSetting.__PropertyMask_bOverride_CharacterSSSIntensity) | (value ? FCharacterSetting.__PropertyMask_bOverride_CharacterSSSIntensity : 0));
			}
		}

		// Token: 0x170062C4 RID: 25284
		// (get) Token: 0x06018EFE RID: 102142 RVA: 0x0024DD24 File Offset: 0x0024BF24
		// (set) Token: 0x06018EFF RID: 102143 RVA: 0x0024DD3D File Offset: 0x0024BF3D
		public unsafe bool bOverride_CharacterRimColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_CharacterRimColor) & FCharacterSetting.__PropertyMask_bOverride_CharacterRimColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_CharacterRimColor) = ((*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_CharacterRimColor) & ~FCharacterSetting.__PropertyMask_bOverride_CharacterRimColor) | (value ? FCharacterSetting.__PropertyMask_bOverride_CharacterRimColor : 0));
			}
		}

		// Token: 0x170062C5 RID: 25285
		// (get) Token: 0x06018F00 RID: 102144 RVA: 0x0024DD6D File Offset: 0x0024BF6D
		// (set) Token: 0x06018F01 RID: 102145 RVA: 0x0024DD86 File Offset: 0x0024BF86
		public unsafe bool bOverride_GlobalShadowIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_GlobalShadowIntensity) & FCharacterSetting.__PropertyMask_bOverride_GlobalShadowIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_GlobalShadowIntensity) = ((*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_GlobalShadowIntensity) & ~FCharacterSetting.__PropertyMask_bOverride_GlobalShadowIntensity) | (value ? FCharacterSetting.__PropertyMask_bOverride_GlobalShadowIntensity : 0));
			}
		}

		// Token: 0x170062C6 RID: 25286
		// (get) Token: 0x06018F02 RID: 102146 RVA: 0x0024DDB6 File Offset: 0x0024BFB6
		// (set) Token: 0x06018F03 RID: 102147 RVA: 0x0024DDCF File Offset: 0x0024BFCF
		public unsafe bool bOverride_UseNewCharacterRim
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_UseNewCharacterRim) & FCharacterSetting.__PropertyMask_bOverride_UseNewCharacterRim) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_UseNewCharacterRim) = ((*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_UseNewCharacterRim) & ~FCharacterSetting.__PropertyMask_bOverride_UseNewCharacterRim) | (value ? FCharacterSetting.__PropertyMask_bOverride_UseNewCharacterRim : 0));
			}
		}

		// Token: 0x170062C7 RID: 25287
		// (get) Token: 0x06018F04 RID: 102148 RVA: 0x0024DDFF File Offset: 0x0024BFFF
		// (set) Token: 0x06018F05 RID: 102149 RVA: 0x0024DE18 File Offset: 0x0024C018
		public unsafe bool bOverride_GlobalBossShadowIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_GlobalBossShadowIntensity) & FCharacterSetting.__PropertyMask_bOverride_GlobalBossShadowIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_GlobalBossShadowIntensity) = ((*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_GlobalBossShadowIntensity) & ~FCharacterSetting.__PropertyMask_bOverride_GlobalBossShadowIntensity) | (value ? FCharacterSetting.__PropertyMask_bOverride_GlobalBossShadowIntensity : 0));
			}
		}

		// Token: 0x170062C8 RID: 25288
		// (get) Token: 0x06018F06 RID: 102150 RVA: 0x0024DE48 File Offset: 0x0024C048
		// (set) Token: 0x06018F07 RID: 102151 RVA: 0x0024DE61 File Offset: 0x0024C061
		public unsafe bool bOverride_GlobalBossShadowRange
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_GlobalBossShadowRange) & FCharacterSetting.__PropertyMask_bOverride_GlobalBossShadowRange) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_GlobalBossShadowRange) = ((*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_GlobalBossShadowRange) & ~FCharacterSetting.__PropertyMask_bOverride_GlobalBossShadowRange) | (value ? FCharacterSetting.__PropertyMask_bOverride_GlobalBossShadowRange : 0));
			}
		}

		// Token: 0x170062C9 RID: 25289
		// (get) Token: 0x06018F08 RID: 102152 RVA: 0x0024DE91 File Offset: 0x0024C091
		// (set) Token: 0x06018F09 RID: 102153 RVA: 0x0024DEAA File Offset: 0x0024C0AA
		public unsafe bool bOverride_NearCharDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_NearCharDistance) & FCharacterSetting.__PropertyMask_bOverride_NearCharDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_NearCharDistance) = ((*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_NearCharDistance) & ~FCharacterSetting.__PropertyMask_bOverride_NearCharDistance) | (value ? FCharacterSetting.__PropertyMask_bOverride_NearCharDistance : 0));
			}
		}

		// Token: 0x170062CA RID: 25290
		// (get) Token: 0x06018F0A RID: 102154 RVA: 0x0024DEDA File Offset: 0x0024C0DA
		// (set) Token: 0x06018F0B RID: 102155 RVA: 0x0024DEF3 File Offset: 0x0024C0F3
		public unsafe bool bOverride_NearCharDistanceSoft
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_NearCharDistanceSoft) & FCharacterSetting.__PropertyMask_bOverride_NearCharDistanceSoft) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_NearCharDistanceSoft) = ((*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_NearCharDistanceSoft) & ~FCharacterSetting.__PropertyMask_bOverride_NearCharDistanceSoft) | (value ? FCharacterSetting.__PropertyMask_bOverride_NearCharDistanceSoft : 0));
			}
		}

		// Token: 0x170062CB RID: 25291
		// (get) Token: 0x06018F0C RID: 102156 RVA: 0x0024DF23 File Offset: 0x0024C123
		// (set) Token: 0x06018F0D RID: 102157 RVA: 0x0024DF3C File Offset: 0x0024C13C
		public unsafe bool bOverride_NearCharLightColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_NearCharLightColor) & FCharacterSetting.__PropertyMask_bOverride_NearCharLightColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_NearCharLightColor) = ((*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_NearCharLightColor) & ~FCharacterSetting.__PropertyMask_bOverride_NearCharLightColor) | (value ? FCharacterSetting.__PropertyMask_bOverride_NearCharLightColor : 0));
			}
		}

		// Token: 0x170062CC RID: 25292
		// (get) Token: 0x06018F0E RID: 102158 RVA: 0x0024DF6C File Offset: 0x0024C16C
		// (set) Token: 0x06018F0F RID: 102159 RVA: 0x0024DF85 File Offset: 0x0024C185
		public unsafe bool bOverride_NearCharShadowColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_NearCharShadowColor) & FCharacterSetting.__PropertyMask_bOverride_NearCharShadowColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_NearCharShadowColor) = ((*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_NearCharShadowColor) & ~FCharacterSetting.__PropertyMask_bOverride_NearCharShadowColor) | (value ? FCharacterSetting.__PropertyMask_bOverride_NearCharShadowColor : 0));
			}
		}

		// Token: 0x170062CD RID: 25293
		// (get) Token: 0x06018F10 RID: 102160 RVA: 0x0024DFB5 File Offset: 0x0024C1B5
		// (set) Token: 0x06018F11 RID: 102161 RVA: 0x0024DFCE File Offset: 0x0024C1CE
		public unsafe bool bOverride_CharWetReflectIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_CharWetReflectIntensity) & FCharacterSetting.__PropertyMask_bOverride_CharWetReflectIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_CharWetReflectIntensity) = ((*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_CharWetReflectIntensity) & ~FCharacterSetting.__PropertyMask_bOverride_CharWetReflectIntensity) | (value ? FCharacterSetting.__PropertyMask_bOverride_CharWetReflectIntensity : 0));
			}
		}

		// Token: 0x170062CE RID: 25294
		// (get) Token: 0x06018F12 RID: 102162 RVA: 0x0024DFFE File Offset: 0x0024C1FE
		// (set) Token: 0x06018F13 RID: 102163 RVA: 0x0024E017 File Offset: 0x0024C217
		public unsafe bool bOverride_CharWetDarkenIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_CharWetDarkenIntensity) & FCharacterSetting.__PropertyMask_bOverride_CharWetDarkenIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_CharWetDarkenIntensity) = ((*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_bOverride_CharWetDarkenIntensity) & ~FCharacterSetting.__PropertyMask_bOverride_CharWetDarkenIntensity) | (value ? FCharacterSetting.__PropertyMask_bOverride_CharWetDarkenIntensity : 0));
			}
		}

		// Token: 0x170062CF RID: 25295
		// (get) Token: 0x06018F14 RID: 102164 RVA: 0x0024E047 File Offset: 0x0024C247
		// (set) Token: 0x06018F15 RID: 102165 RVA: 0x0024E057 File Offset: 0x0024C257
		public unsafe float CustomCharacterLightingIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_CustomCharacterLightingIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_CustomCharacterLightingIntensity) = value;
			}
		}

		// Token: 0x170062D0 RID: 25296
		// (get) Token: 0x06018F16 RID: 102166 RVA: 0x0024E068 File Offset: 0x0024C268
		// (set) Token: 0x06018F17 RID: 102167 RVA: 0x0024E078 File Offset: 0x0024C278
		public unsafe float CharacterDirectionMixIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_CharacterDirectionMixIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_CharacterDirectionMixIntensity) = value;
			}
		}

		// Token: 0x170062D1 RID: 25297
		// (get) Token: 0x06018F18 RID: 102168 RVA: 0x0024E089 File Offset: 0x0024C289
		// (set) Token: 0x06018F19 RID: 102169 RVA: 0x0024E099 File Offset: 0x0024C299
		public unsafe float LightHorizontalAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_LightHorizontalAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_LightHorizontalAngle) = value;
			}
		}

		// Token: 0x170062D2 RID: 25298
		// (get) Token: 0x06018F1A RID: 102170 RVA: 0x0024E0AA File Offset: 0x0024C2AA
		// (set) Token: 0x06018F1B RID: 102171 RVA: 0x0024E0BA File Offset: 0x0024C2BA
		public unsafe float MixCharacterLightingIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_MixCharacterLightingIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_MixCharacterLightingIntensity) = value;
			}
		}

		// Token: 0x170062D3 RID: 25299
		// (get) Token: 0x06018F1C RID: 102172 RVA: 0x0024E0CB File Offset: 0x0024C2CB
		// (set) Token: 0x06018F1D RID: 102173 RVA: 0x0024E0DF File Offset: 0x0024C2DF
		public unsafe FLinearColor CharacterMainLightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_CharacterMainLightColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_CharacterMainLightColor) = value;
			}
		}

		// Token: 0x170062D4 RID: 25300
		// (get) Token: 0x06018F1E RID: 102174 RVA: 0x0024E0F4 File Offset: 0x0024C2F4
		// (set) Token: 0x06018F1F RID: 102175 RVA: 0x0024E108 File Offset: 0x0024C308
		public unsafe FLinearColor CharacterAmbientColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_CharacterAmbientColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_CharacterAmbientColor) = value;
			}
		}

		// Token: 0x170062D5 RID: 25301
		// (get) Token: 0x06018F20 RID: 102176 RVA: 0x0024E11D File Offset: 0x0024C31D
		// (set) Token: 0x06018F21 RID: 102177 RVA: 0x0024E12D File Offset: 0x0024C32D
		public unsafe float CharacterSSSIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_CharacterSSSIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_CharacterSSSIntensity) = value;
			}
		}

		// Token: 0x170062D6 RID: 25302
		// (get) Token: 0x06018F22 RID: 102178 RVA: 0x0024E13E File Offset: 0x0024C33E
		// (set) Token: 0x06018F23 RID: 102179 RVA: 0x0024E152 File Offset: 0x0024C352
		public unsafe FLinearColor CharacterRimColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_CharacterRimColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_CharacterRimColor) = value;
			}
		}

		// Token: 0x170062D7 RID: 25303
		// (get) Token: 0x06018F24 RID: 102180 RVA: 0x0024E167 File Offset: 0x0024C367
		// (set) Token: 0x06018F25 RID: 102181 RVA: 0x0024E177 File Offset: 0x0024C377
		public unsafe float GlobalShadowIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_GlobalShadowIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_GlobalShadowIntensity) = value;
			}
		}

		// Token: 0x170062D8 RID: 25304
		// (get) Token: 0x06018F26 RID: 102182 RVA: 0x0024E188 File Offset: 0x0024C388
		// (set) Token: 0x06018F27 RID: 102183 RVA: 0x0024E198 File Offset: 0x0024C398
		public unsafe float UseNewCharacterRim
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_UseNewCharacterRim);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_UseNewCharacterRim) = value;
			}
		}

		// Token: 0x170062D9 RID: 25305
		// (get) Token: 0x06018F28 RID: 102184 RVA: 0x0024E1A9 File Offset: 0x0024C3A9
		// (set) Token: 0x06018F29 RID: 102185 RVA: 0x0024E1B9 File Offset: 0x0024C3B9
		public unsafe float GlobalBossShadowIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_GlobalBossShadowIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_GlobalBossShadowIntensity) = value;
			}
		}

		// Token: 0x170062DA RID: 25306
		// (get) Token: 0x06018F2A RID: 102186 RVA: 0x0024E1CA File Offset: 0x0024C3CA
		// (set) Token: 0x06018F2B RID: 102187 RVA: 0x0024E1DE File Offset: 0x0024C3DE
		public unsafe FVector2D GlobalBossShadowRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_GlobalBossShadowRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_GlobalBossShadowRange) = value;
			}
		}

		// Token: 0x170062DB RID: 25307
		// (get) Token: 0x06018F2C RID: 102188 RVA: 0x0024E1F3 File Offset: 0x0024C3F3
		// (set) Token: 0x06018F2D RID: 102189 RVA: 0x0024E203 File Offset: 0x0024C403
		public unsafe float NearCharDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_NearCharDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_NearCharDistance) = value;
			}
		}

		// Token: 0x170062DC RID: 25308
		// (get) Token: 0x06018F2E RID: 102190 RVA: 0x0024E214 File Offset: 0x0024C414
		// (set) Token: 0x06018F2F RID: 102191 RVA: 0x0024E224 File Offset: 0x0024C424
		public unsafe float NearCharDistanceSoft
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_NearCharDistanceSoft);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_NearCharDistanceSoft) = value;
			}
		}

		// Token: 0x170062DD RID: 25309
		// (get) Token: 0x06018F30 RID: 102192 RVA: 0x0024E235 File Offset: 0x0024C435
		// (set) Token: 0x06018F31 RID: 102193 RVA: 0x0024E249 File Offset: 0x0024C449
		public unsafe FLinearColor NearCharLightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_NearCharLightColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_NearCharLightColor) = value;
			}
		}

		// Token: 0x170062DE RID: 25310
		// (get) Token: 0x06018F32 RID: 102194 RVA: 0x0024E25E File Offset: 0x0024C45E
		// (set) Token: 0x06018F33 RID: 102195 RVA: 0x0024E272 File Offset: 0x0024C472
		public unsafe FLinearColor NearCharShadowColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_NearCharShadowColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_NearCharShadowColor) = value;
			}
		}

		// Token: 0x170062DF RID: 25311
		// (get) Token: 0x06018F34 RID: 102196 RVA: 0x0024E287 File Offset: 0x0024C487
		// (set) Token: 0x06018F35 RID: 102197 RVA: 0x0024E297 File Offset: 0x0024C497
		public unsafe float CharWetReflectIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_CharWetReflectIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_CharWetReflectIntensity) = value;
			}
		}

		// Token: 0x170062E0 RID: 25312
		// (get) Token: 0x06018F36 RID: 102198 RVA: 0x0024E2A8 File Offset: 0x0024C4A8
		// (set) Token: 0x06018F37 RID: 102199 RVA: 0x0024E2B8 File Offset: 0x0024C4B8
		public unsafe float CharWetDarkenIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_CharWetDarkenIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCharacterSetting.__PropertyOffset_CharWetDarkenIntensity) = value;
			}
		}

		// Token: 0x06018F38 RID: 102200 RVA: 0x0024E2C9 File Offset: 0x0024C4C9
		public FCharacterSetting()
		{
		}

		// Token: 0x06018F39 RID: 102201 RVA: 0x0024E2D4 File Offset: 0x0024C4D4
		public FCharacterSetting(bool bOverride_CustomCharacterLightingIntensity, bool bOverride_LightHorizontalAngle, bool bOverride_CharacterDirectionMixIntensity, bool bOverride_MixCharacterLightingIntensity, bool bOverride_CharacterAmbientColor, bool bOverride_CharacterMainLightColor, bool bOverride_CharacterSkinShadowColorIntensity, bool bOverride_CharacterSSSIntensity, bool bOverride_CharacterRimColor, bool bOverride_GlobalShadowIntensity, bool bOverride_UseNewCharacterRim, bool bOverride_GlobalBossShadowIntensity, bool bOverride_GlobalBossShadowRange, bool bOverride_NearCharDistance, bool bOverride_NearCharDistanceSoft, bool bOverride_NearCharLightColor, bool bOverride_NearCharShadowColor, bool bOverride_CharWetReflectIntensity, bool bOverride_CharWetDarkenIntensity, float CustomCharacterLightingIntensity, float CharacterDirectionMixIntensity, float LightHorizontalAngle, float MixCharacterLightingIntensity, FLinearColor CharacterMainLightColor, FLinearColor CharacterAmbientColor, float CharacterSSSIntensity, FLinearColor CharacterRimColor, float GlobalShadowIntensity, float UseNewCharacterRim, float GlobalBossShadowIntensity, FVector2D GlobalBossShadowRange, float NearCharDistance, float NearCharDistanceSoft, FLinearColor NearCharLightColor, FLinearColor NearCharShadowColor, float CharWetReflectIntensity, float CharWetDarkenIntensity)
		{
			this.bOverride_CustomCharacterLightingIntensity = bOverride_CustomCharacterLightingIntensity;
			this.bOverride_LightHorizontalAngle = bOverride_LightHorizontalAngle;
			this.bOverride_CharacterDirectionMixIntensity = bOverride_CharacterDirectionMixIntensity;
			this.bOverride_MixCharacterLightingIntensity = bOverride_MixCharacterLightingIntensity;
			this.bOverride_CharacterAmbientColor = bOverride_CharacterAmbientColor;
			this.bOverride_CharacterMainLightColor = bOverride_CharacterMainLightColor;
			this.bOverride_CharacterSkinShadowColorIntensity = bOverride_CharacterSkinShadowColorIntensity;
			this.bOverride_CharacterSSSIntensity = bOverride_CharacterSSSIntensity;
			this.bOverride_CharacterRimColor = bOverride_CharacterRimColor;
			this.bOverride_GlobalShadowIntensity = bOverride_GlobalShadowIntensity;
			this.bOverride_UseNewCharacterRim = bOverride_UseNewCharacterRim;
			this.bOverride_GlobalBossShadowIntensity = bOverride_GlobalBossShadowIntensity;
			this.bOverride_GlobalBossShadowRange = bOverride_GlobalBossShadowRange;
			this.bOverride_NearCharDistance = bOverride_NearCharDistance;
			this.bOverride_NearCharDistanceSoft = bOverride_NearCharDistanceSoft;
			this.bOverride_NearCharLightColor = bOverride_NearCharLightColor;
			this.bOverride_NearCharShadowColor = bOverride_NearCharShadowColor;
			this.bOverride_CharWetReflectIntensity = bOverride_CharWetReflectIntensity;
			this.bOverride_CharWetDarkenIntensity = bOverride_CharWetDarkenIntensity;
			this.CustomCharacterLightingIntensity = CustomCharacterLightingIntensity;
			this.CharacterDirectionMixIntensity = CharacterDirectionMixIntensity;
			this.LightHorizontalAngle = LightHorizontalAngle;
			this.MixCharacterLightingIntensity = MixCharacterLightingIntensity;
			this.CharacterMainLightColor = CharacterMainLightColor;
			this.CharacterAmbientColor = CharacterAmbientColor;
			this.CharacterSSSIntensity = CharacterSSSIntensity;
			this.CharacterRimColor = CharacterRimColor;
			this.GlobalShadowIntensity = GlobalShadowIntensity;
			this.UseNewCharacterRim = UseNewCharacterRim;
			this.GlobalBossShadowIntensity = GlobalBossShadowIntensity;
			this.GlobalBossShadowRange = GlobalBossShadowRange;
			this.NearCharDistance = NearCharDistance;
			this.NearCharDistanceSoft = NearCharDistanceSoft;
			this.NearCharLightColor = NearCharLightColor;
			this.NearCharShadowColor = NearCharShadowColor;
			this.CharWetReflectIntensity = CharWetReflectIntensity;
			this.CharWetDarkenIntensity = CharWetDarkenIntensity;
		}

		// Token: 0x06018F3A RID: 102202 RVA: 0x0024E40C File Offset: 0x0024C60C
		protected override IntPtr GetUStructPtr()
		{
			return FCharacterSetting.StaticStruct();
		}

		// Token: 0x06018F3B RID: 102203 RVA: 0x0024E418 File Offset: 0x0024C618
		[NullableContext(2)]
		public FCharacterSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018F3C RID: 102204 RVA: 0x0024E422 File Offset: 0x0024C622
		public FCharacterSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018F3D RID: 102205 RVA: 0x0024E42D File Offset: 0x0024C62D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCharacterSetting(Pointer, false, true);
		}

		// Token: 0x06018F3E RID: 102206 RVA: 0x0024E437 File Offset: 0x0024C637
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCharacterSetting(Pointer, MemoryOwner);
		}

		// Token: 0x0400D7D4 RID: 55252
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.CharacterSetting";

		// Token: 0x0400D7D5 RID: 55253
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D7D6 RID: 55254
		internal static int __PropertyOffset_bOverride_CustomCharacterLightingIntensity;

		// Token: 0x0400D7D7 RID: 55255
		internal static byte __PropertyMask_bOverride_CustomCharacterLightingIntensity;

		// Token: 0x0400D7D8 RID: 55256
		internal static int __PropertyOffset_bOverride_LightHorizontalAngle;

		// Token: 0x0400D7D9 RID: 55257
		internal static byte __PropertyMask_bOverride_LightHorizontalAngle;

		// Token: 0x0400D7DA RID: 55258
		internal static int __PropertyOffset_bOverride_CharacterDirectionMixIntensity;

		// Token: 0x0400D7DB RID: 55259
		internal static byte __PropertyMask_bOverride_CharacterDirectionMixIntensity;

		// Token: 0x0400D7DC RID: 55260
		internal static int __PropertyOffset_bOverride_MixCharacterLightingIntensity;

		// Token: 0x0400D7DD RID: 55261
		internal static byte __PropertyMask_bOverride_MixCharacterLightingIntensity;

		// Token: 0x0400D7DE RID: 55262
		internal static int __PropertyOffset_bOverride_CharacterAmbientColor;

		// Token: 0x0400D7DF RID: 55263
		internal static byte __PropertyMask_bOverride_CharacterAmbientColor;

		// Token: 0x0400D7E0 RID: 55264
		internal static int __PropertyOffset_bOverride_CharacterMainLightColor;

		// Token: 0x0400D7E1 RID: 55265
		internal static byte __PropertyMask_bOverride_CharacterMainLightColor;

		// Token: 0x0400D7E2 RID: 55266
		internal static int __PropertyOffset_bOverride_CharacterSkinShadowColorIntensity;

		// Token: 0x0400D7E3 RID: 55267
		internal static byte __PropertyMask_bOverride_CharacterSkinShadowColorIntensity;

		// Token: 0x0400D7E4 RID: 55268
		internal static int __PropertyOffset_bOverride_CharacterSSSIntensity;

		// Token: 0x0400D7E5 RID: 55269
		internal static byte __PropertyMask_bOverride_CharacterSSSIntensity;

		// Token: 0x0400D7E6 RID: 55270
		internal static int __PropertyOffset_bOverride_CharacterRimColor;

		// Token: 0x0400D7E7 RID: 55271
		internal static byte __PropertyMask_bOverride_CharacterRimColor;

		// Token: 0x0400D7E8 RID: 55272
		internal static int __PropertyOffset_bOverride_GlobalShadowIntensity;

		// Token: 0x0400D7E9 RID: 55273
		internal static byte __PropertyMask_bOverride_GlobalShadowIntensity;

		// Token: 0x0400D7EA RID: 55274
		internal static int __PropertyOffset_bOverride_UseNewCharacterRim;

		// Token: 0x0400D7EB RID: 55275
		internal static byte __PropertyMask_bOverride_UseNewCharacterRim;

		// Token: 0x0400D7EC RID: 55276
		internal static int __PropertyOffset_bOverride_GlobalBossShadowIntensity;

		// Token: 0x0400D7ED RID: 55277
		internal static byte __PropertyMask_bOverride_GlobalBossShadowIntensity;

		// Token: 0x0400D7EE RID: 55278
		internal static int __PropertyOffset_bOverride_GlobalBossShadowRange;

		// Token: 0x0400D7EF RID: 55279
		internal static byte __PropertyMask_bOverride_GlobalBossShadowRange;

		// Token: 0x0400D7F0 RID: 55280
		internal static int __PropertyOffset_bOverride_NearCharDistance;

		// Token: 0x0400D7F1 RID: 55281
		internal static byte __PropertyMask_bOverride_NearCharDistance;

		// Token: 0x0400D7F2 RID: 55282
		internal static int __PropertyOffset_bOverride_NearCharDistanceSoft;

		// Token: 0x0400D7F3 RID: 55283
		internal static byte __PropertyMask_bOverride_NearCharDistanceSoft;

		// Token: 0x0400D7F4 RID: 55284
		internal static int __PropertyOffset_bOverride_NearCharLightColor;

		// Token: 0x0400D7F5 RID: 55285
		internal static byte __PropertyMask_bOverride_NearCharLightColor;

		// Token: 0x0400D7F6 RID: 55286
		internal static int __PropertyOffset_bOverride_NearCharShadowColor;

		// Token: 0x0400D7F7 RID: 55287
		internal static byte __PropertyMask_bOverride_NearCharShadowColor;

		// Token: 0x0400D7F8 RID: 55288
		internal static int __PropertyOffset_bOverride_CharWetReflectIntensity;

		// Token: 0x0400D7F9 RID: 55289
		internal static byte __PropertyMask_bOverride_CharWetReflectIntensity;

		// Token: 0x0400D7FA RID: 55290
		internal static int __PropertyOffset_bOverride_CharWetDarkenIntensity;

		// Token: 0x0400D7FB RID: 55291
		internal static byte __PropertyMask_bOverride_CharWetDarkenIntensity;

		// Token: 0x0400D7FC RID: 55292
		internal static int __PropertyOffset_CustomCharacterLightingIntensity;

		// Token: 0x0400D7FD RID: 55293
		internal static int __PropertyOffset_CharacterDirectionMixIntensity;

		// Token: 0x0400D7FE RID: 55294
		internal static int __PropertyOffset_LightHorizontalAngle;

		// Token: 0x0400D7FF RID: 55295
		internal static int __PropertyOffset_MixCharacterLightingIntensity;

		// Token: 0x0400D800 RID: 55296
		internal static int __PropertyOffset_CharacterMainLightColor;

		// Token: 0x0400D801 RID: 55297
		internal static int __PropertyOffset_CharacterAmbientColor;

		// Token: 0x0400D802 RID: 55298
		internal static int __PropertyOffset_CharacterSSSIntensity;

		// Token: 0x0400D803 RID: 55299
		internal static int __PropertyOffset_CharacterRimColor;

		// Token: 0x0400D804 RID: 55300
		internal static int __PropertyOffset_GlobalShadowIntensity;

		// Token: 0x0400D805 RID: 55301
		internal static int __PropertyOffset_UseNewCharacterRim;

		// Token: 0x0400D806 RID: 55302
		internal static int __PropertyOffset_GlobalBossShadowIntensity;

		// Token: 0x0400D807 RID: 55303
		internal static int __PropertyOffset_GlobalBossShadowRange;

		// Token: 0x0400D808 RID: 55304
		internal static int __PropertyOffset_NearCharDistance;

		// Token: 0x0400D809 RID: 55305
		internal static int __PropertyOffset_NearCharDistanceSoft;

		// Token: 0x0400D80A RID: 55306
		internal static int __PropertyOffset_NearCharLightColor;

		// Token: 0x0400D80B RID: 55307
		internal static int __PropertyOffset_NearCharShadowColor;

		// Token: 0x0400D80C RID: 55308
		internal static int __PropertyOffset_CharWetReflectIntensity;

		// Token: 0x0400D80D RID: 55309
		internal static int __PropertyOffset_CharWetDarkenIntensity;
	}
}
