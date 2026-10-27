using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C2E RID: 7214
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.StarSetting")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FStarSetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601BED0 RID: 114384 RVA: 0x002917BE File Offset: 0x0028F9BE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStarSetting._ScriptStructPtr != 0) ? FStarSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.StarSetting", ref FStarSetting._ScriptStructPtr);
		}

		// Token: 0x170070B7 RID: 28855
		// (get) Token: 0x0601BED1 RID: 114385 RVA: 0x002917E2 File Offset: 0x0028F9E2
		// (set) Token: 0x0601BED2 RID: 114386 RVA: 0x002917FB File Offset: 0x0028F9FB
		public unsafe bool bOverride_StarFieldColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_bOverride_StarFieldColor) & FStarSetting.__PropertyMask_bOverride_StarFieldColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FStarSetting.__PropertyOffset_bOverride_StarFieldColor) = ((*(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_bOverride_StarFieldColor) & ~FStarSetting.__PropertyMask_bOverride_StarFieldColor) | (value ? FStarSetting.__PropertyMask_bOverride_StarFieldColor : 0));
			}
		}

		// Token: 0x170070B8 RID: 28856
		// (get) Token: 0x0601BED3 RID: 114387 RVA: 0x0029182B File Offset: 0x0028FA2B
		// (set) Token: 0x0601BED4 RID: 114388 RVA: 0x00291844 File Offset: 0x0028FA44
		public unsafe bool bOverride_StarSize
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_bOverride_StarSize) & FStarSetting.__PropertyMask_bOverride_StarSize) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FStarSetting.__PropertyOffset_bOverride_StarSize) = ((*(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_bOverride_StarSize) & ~FStarSetting.__PropertyMask_bOverride_StarSize) | (value ? FStarSetting.__PropertyMask_bOverride_StarSize : 0));
			}
		}

		// Token: 0x170070B9 RID: 28857
		// (get) Token: 0x0601BED5 RID: 114389 RVA: 0x00291874 File Offset: 0x0028FA74
		// (set) Token: 0x0601BED6 RID: 114390 RVA: 0x0029188D File Offset: 0x0028FA8D
		public unsafe bool bOverride_StarSpeed
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_bOverride_StarSpeed) & FStarSetting.__PropertyMask_bOverride_StarSpeed) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FStarSetting.__PropertyOffset_bOverride_StarSpeed) = ((*(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_bOverride_StarSpeed) & ~FStarSetting.__PropertyMask_bOverride_StarSpeed) | (value ? FStarSetting.__PropertyMask_bOverride_StarSpeed : 0));
			}
		}

		// Token: 0x170070BA RID: 28858
		// (get) Token: 0x0601BED7 RID: 114391 RVA: 0x002918BD File Offset: 0x0028FABD
		// (set) Token: 0x0601BED8 RID: 114392 RVA: 0x002918D6 File Offset: 0x0028FAD6
		public unsafe bool bOverride_StarSwitch
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_bOverride_StarSwitch) & FStarSetting.__PropertyMask_bOverride_StarSwitch) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FStarSetting.__PropertyOffset_bOverride_StarSwitch) = ((*(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_bOverride_StarSwitch) & ~FStarSetting.__PropertyMask_bOverride_StarSwitch) | (value ? FStarSetting.__PropertyMask_bOverride_StarSwitch : 0));
			}
		}

		// Token: 0x170070BB RID: 28859
		// (get) Token: 0x0601BED9 RID: 114393 RVA: 0x00291906 File Offset: 0x0028FB06
		// (set) Token: 0x0601BEDA RID: 114394 RVA: 0x0029191F File Offset: 0x0028FB1F
		public unsafe bool bOverride_NoiseTexture
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_bOverride_NoiseTexture) & FStarSetting.__PropertyMask_bOverride_NoiseTexture) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FStarSetting.__PropertyOffset_bOverride_NoiseTexture) = ((*(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_bOverride_NoiseTexture) & ~FStarSetting.__PropertyMask_bOverride_NoiseTexture) | (value ? FStarSetting.__PropertyMask_bOverride_NoiseTexture : 0));
			}
		}

		// Token: 0x170070BC RID: 28860
		// (get) Token: 0x0601BEDB RID: 114395 RVA: 0x0029194F File Offset: 0x0028FB4F
		// (set) Token: 0x0601BEDC RID: 114396 RVA: 0x00291968 File Offset: 0x0028FB68
		public unsafe bool bOverride_NoiseSwitch
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_bOverride_NoiseSwitch) & FStarSetting.__PropertyMask_bOverride_NoiseSwitch) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FStarSetting.__PropertyOffset_bOverride_NoiseSwitch) = ((*(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_bOverride_NoiseSwitch) & ~FStarSetting.__PropertyMask_bOverride_NoiseSwitch) | (value ? FStarSetting.__PropertyMask_bOverride_NoiseSwitch : 0));
			}
		}

		// Token: 0x170070BD RID: 28861
		// (get) Token: 0x0601BEDD RID: 114397 RVA: 0x00291998 File Offset: 0x0028FB98
		// (set) Token: 0x0601BEDE RID: 114398 RVA: 0x002919B1 File Offset: 0x0028FBB1
		public unsafe bool bOverride_UVTillingU
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_bOverride_UVTillingU) & FStarSetting.__PropertyMask_bOverride_UVTillingU) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FStarSetting.__PropertyOffset_bOverride_UVTillingU) = ((*(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_bOverride_UVTillingU) & ~FStarSetting.__PropertyMask_bOverride_UVTillingU) | (value ? FStarSetting.__PropertyMask_bOverride_UVTillingU : 0));
			}
		}

		// Token: 0x170070BE RID: 28862
		// (get) Token: 0x0601BEDF RID: 114399 RVA: 0x002919E1 File Offset: 0x0028FBE1
		// (set) Token: 0x0601BEE0 RID: 114400 RVA: 0x002919FA File Offset: 0x0028FBFA
		public unsafe bool bOverride_UVTillingV
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_bOverride_UVTillingV) & FStarSetting.__PropertyMask_bOverride_UVTillingV) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FStarSetting.__PropertyOffset_bOverride_UVTillingV) = ((*(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_bOverride_UVTillingV) & ~FStarSetting.__PropertyMask_bOverride_UVTillingV) | (value ? FStarSetting.__PropertyMask_bOverride_UVTillingV : 0));
			}
		}

		// Token: 0x170070BF RID: 28863
		// (get) Token: 0x0601BEE1 RID: 114401 RVA: 0x00291A2A File Offset: 0x0028FC2A
		// (set) Token: 0x0601BEE2 RID: 114402 RVA: 0x00291A43 File Offset: 0x0028FC43
		public unsafe bool bOverride_StarMap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_bOverride_StarMap) & FStarSetting.__PropertyMask_bOverride_StarMap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FStarSetting.__PropertyOffset_bOverride_StarMap) = ((*(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_bOverride_StarMap) & ~FStarSetting.__PropertyMask_bOverride_StarMap) | (value ? FStarSetting.__PropertyMask_bOverride_StarMap : 0));
			}
		}

		// Token: 0x170070C0 RID: 28864
		// (get) Token: 0x0601BEE3 RID: 114403 RVA: 0x00291A73 File Offset: 0x0028FC73
		// (set) Token: 0x0601BEE4 RID: 114404 RVA: 0x00291A8C File Offset: 0x0028FC8C
		public unsafe bool bOverride_StarMapPC
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_bOverride_StarMapPC) & FStarSetting.__PropertyMask_bOverride_StarMapPC) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FStarSetting.__PropertyOffset_bOverride_StarMapPC) = ((*(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_bOverride_StarMapPC) & ~FStarSetting.__PropertyMask_bOverride_StarMapPC) | (value ? FStarSetting.__PropertyMask_bOverride_StarMapPC : 0));
			}
		}

		// Token: 0x170070C1 RID: 28865
		// (get) Token: 0x0601BEE5 RID: 114405 RVA: 0x00291ABC File Offset: 0x0028FCBC
		// (set) Token: 0x0601BEE6 RID: 114406 RVA: 0x00291AD0 File Offset: 0x0028FCD0
		public unsafe FLinearColor StarFieldColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_StarFieldColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_StarFieldColor) = value;
			}
		}

		// Token: 0x170070C2 RID: 28866
		// (get) Token: 0x0601BEE7 RID: 114407 RVA: 0x00291AE5 File Offset: 0x0028FCE5
		// (set) Token: 0x0601BEE8 RID: 114408 RVA: 0x00291AFE File Offset: 0x0028FCFE
		public unsafe bool bOverride_UseStarV2
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_bOverride_UseStarV2) & FStarSetting.__PropertyMask_bOverride_UseStarV2) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FStarSetting.__PropertyOffset_bOverride_UseStarV2) = ((*(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_bOverride_UseStarV2) & ~FStarSetting.__PropertyMask_bOverride_UseStarV2) | (value ? FStarSetting.__PropertyMask_bOverride_UseStarV2 : 0));
			}
		}

		// Token: 0x170070C3 RID: 28867
		// (get) Token: 0x0601BEE9 RID: 114409 RVA: 0x00291B2E File Offset: 0x0028FD2E
		// (set) Token: 0x0601BEEA RID: 114410 RVA: 0x00291B47 File Offset: 0x0028FD47
		public unsafe bool bOverride_StarCloudFogColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_bOverride_StarCloudFogColor) & FStarSetting.__PropertyMask_bOverride_StarCloudFogColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FStarSetting.__PropertyOffset_bOverride_StarCloudFogColor) = ((*(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_bOverride_StarCloudFogColor) & ~FStarSetting.__PropertyMask_bOverride_StarCloudFogColor) | (value ? FStarSetting.__PropertyMask_bOverride_StarCloudFogColor : 0));
			}
		}

		// Token: 0x170070C4 RID: 28868
		// (get) Token: 0x0601BEEB RID: 114411 RVA: 0x00291B77 File Offset: 0x0028FD77
		// (set) Token: 0x0601BEEC RID: 114412 RVA: 0x00291B90 File Offset: 0x0028FD90
		public unsafe bool bOverride_StarTex_V2
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_bOverride_StarTex_V2) & FStarSetting.__PropertyMask_bOverride_StarTex_V2) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FStarSetting.__PropertyOffset_bOverride_StarTex_V2) = ((*(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_bOverride_StarTex_V2) & ~FStarSetting.__PropertyMask_bOverride_StarTex_V2) | (value ? FStarSetting.__PropertyMask_bOverride_StarTex_V2 : 0));
			}
		}

		// Token: 0x170070C5 RID: 28869
		// (get) Token: 0x0601BEED RID: 114413 RVA: 0x00291BC0 File Offset: 0x0028FDC0
		// (set) Token: 0x0601BEEE RID: 114414 RVA: 0x00291BD0 File Offset: 0x0028FDD0
		public unsafe float StarSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_StarSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_StarSize) = value;
			}
		}

		// Token: 0x170070C6 RID: 28870
		// (get) Token: 0x0601BEEF RID: 114415 RVA: 0x00291BE1 File Offset: 0x0028FDE1
		// (set) Token: 0x0601BEF0 RID: 114416 RVA: 0x00291BF1 File Offset: 0x0028FDF1
		public unsafe float StarSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_StarSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_StarSpeed) = value;
			}
		}

		// Token: 0x170070C7 RID: 28871
		// (get) Token: 0x0601BEF1 RID: 114417 RVA: 0x00291C02 File Offset: 0x0028FE02
		// (set) Token: 0x0601BEF2 RID: 114418 RVA: 0x00291C12 File Offset: 0x0028FE12
		public unsafe float StarSwitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_StarSwitch);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_StarSwitch) = value;
			}
		}

		// Token: 0x170070C8 RID: 28872
		// (get) Token: 0x0601BEF3 RID: 114419 RVA: 0x00291C23 File Offset: 0x0028FE23
		// (set) Token: 0x0601BEF4 RID: 114420 RVA: 0x00291C37 File Offset: 0x0028FE37
		public unsafe UTexture2D NoiseTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + FStarSetting.__PropertyOffset_NoiseTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FStarSetting.__PropertyOffset_NoiseTexture, value);
			}
		}

		// Token: 0x170070C9 RID: 28873
		// (get) Token: 0x0601BEF5 RID: 114421 RVA: 0x00291C4C File Offset: 0x0028FE4C
		// (set) Token: 0x0601BEF6 RID: 114422 RVA: 0x00291C5C File Offset: 0x0028FE5C
		public unsafe float NoiseSwitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_NoiseSwitch);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_NoiseSwitch) = value;
			}
		}

		// Token: 0x170070CA RID: 28874
		// (get) Token: 0x0601BEF7 RID: 114423 RVA: 0x00291C6D File Offset: 0x0028FE6D
		// (set) Token: 0x0601BEF8 RID: 114424 RVA: 0x00291C7D File Offset: 0x0028FE7D
		public unsafe float UVTillingU
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_UVTillingU);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_UVTillingU) = value;
			}
		}

		// Token: 0x170070CB RID: 28875
		// (get) Token: 0x0601BEF9 RID: 114425 RVA: 0x00291C8E File Offset: 0x0028FE8E
		// (set) Token: 0x0601BEFA RID: 114426 RVA: 0x00291C9E File Offset: 0x0028FE9E
		public unsafe float UVTillingV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_UVTillingV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_UVTillingV) = value;
			}
		}

		// Token: 0x170070CC RID: 28876
		// (get) Token: 0x0601BEFB RID: 114427 RVA: 0x00291CAF File Offset: 0x0028FEAF
		// (set) Token: 0x0601BEFC RID: 114428 RVA: 0x00291CC3 File Offset: 0x0028FEC3
		public unsafe UTexture StarMap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + FStarSetting.__PropertyOffset_StarMap);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FStarSetting.__PropertyOffset_StarMap, value);
			}
		}

		// Token: 0x170070CD RID: 28877
		// (get) Token: 0x0601BEFD RID: 114429 RVA: 0x00291CD8 File Offset: 0x0028FED8
		// (set) Token: 0x0601BEFE RID: 114430 RVA: 0x00291CEC File Offset: 0x0028FEEC
		public unsafe UTexture StarMap_PC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + FStarSetting.__PropertyOffset_StarMap_PC);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FStarSetting.__PropertyOffset_StarMap_PC, value);
			}
		}

		// Token: 0x170070CE RID: 28878
		// (get) Token: 0x0601BEFF RID: 114431 RVA: 0x00291D01 File Offset: 0x0028FF01
		// (set) Token: 0x0601BF00 RID: 114432 RVA: 0x00291D11 File Offset: 0x0028FF11
		public unsafe bool bUseStarV2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_bUseStarV2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_bUseStarV2) = (value ? 1 : 0);
			}
		}

		// Token: 0x170070CF RID: 28879
		// (get) Token: 0x0601BF01 RID: 114433 RVA: 0x00291D22 File Offset: 0x0028FF22
		// (set) Token: 0x0601BF02 RID: 114434 RVA: 0x00291D36 File Offset: 0x0028FF36
		public unsafe FLinearColor StarCloudFogColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_StarCloudFogColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStarSetting.__PropertyOffset_StarCloudFogColor) = value;
			}
		}

		// Token: 0x170070D0 RID: 28880
		// (get) Token: 0x0601BF03 RID: 114435 RVA: 0x00291D4B File Offset: 0x0028FF4B
		// (set) Token: 0x0601BF04 RID: 114436 RVA: 0x00291D5F File Offset: 0x0028FF5F
		public unsafe UTexture StarTex_V2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + FStarSetting.__PropertyOffset_StarTex_V2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FStarSetting.__PropertyOffset_StarTex_V2, value);
			}
		}

		// Token: 0x0601BF05 RID: 114437 RVA: 0x00291D74 File Offset: 0x0028FF74
		public FStarSetting()
		{
		}

		// Token: 0x0601BF06 RID: 114438 RVA: 0x00291D7C File Offset: 0x0028FF7C
		[NullableContext(1)]
		public FStarSetting(bool bOverride_StarFieldColor, bool bOverride_StarSize, bool bOverride_StarSpeed, bool bOverride_StarSwitch, bool bOverride_NoiseTexture, bool bOverride_NoiseSwitch, bool bOverride_UVTillingU, bool bOverride_UVTillingV, bool bOverride_StarMap, bool bOverride_StarMapPC, FLinearColor StarFieldColor, bool bOverride_UseStarV2, bool bOverride_StarCloudFogColor, bool bOverride_StarTex_V2, float StarSize, float StarSpeed, float StarSwitch, UTexture2D NoiseTexture, float NoiseSwitch, float UVTillingU, float UVTillingV, UTexture StarMap, UTexture StarMap_PC, bool bUseStarV2, FLinearColor StarCloudFogColor, UTexture StarTex_V2)
		{
			this.bOverride_StarFieldColor = bOverride_StarFieldColor;
			this.bOverride_StarSize = bOverride_StarSize;
			this.bOverride_StarSpeed = bOverride_StarSpeed;
			this.bOverride_StarSwitch = bOverride_StarSwitch;
			this.bOverride_NoiseTexture = bOverride_NoiseTexture;
			this.bOverride_NoiseSwitch = bOverride_NoiseSwitch;
			this.bOverride_UVTillingU = bOverride_UVTillingU;
			this.bOverride_UVTillingV = bOverride_UVTillingV;
			this.bOverride_StarMap = bOverride_StarMap;
			this.bOverride_StarMapPC = bOverride_StarMapPC;
			this.StarFieldColor = StarFieldColor;
			this.bOverride_UseStarV2 = bOverride_UseStarV2;
			this.bOverride_StarCloudFogColor = bOverride_StarCloudFogColor;
			this.bOverride_StarTex_V2 = bOverride_StarTex_V2;
			this.StarSize = StarSize;
			this.StarSpeed = StarSpeed;
			this.StarSwitch = StarSwitch;
			this.NoiseTexture = NoiseTexture;
			this.NoiseSwitch = NoiseSwitch;
			this.UVTillingU = UVTillingU;
			this.UVTillingV = UVTillingV;
			this.StarMap = StarMap;
			this.StarMap_PC = StarMap_PC;
			this.bUseStarV2 = bUseStarV2;
			this.StarCloudFogColor = StarCloudFogColor;
			this.StarTex_V2 = StarTex_V2;
		}

		// Token: 0x0601BF07 RID: 114439 RVA: 0x00291E5C File Offset: 0x0029005C
		protected override IntPtr GetUStructPtr()
		{
			return FStarSetting.StaticStruct();
		}

		// Token: 0x0601BF08 RID: 114440 RVA: 0x00291E68 File Offset: 0x00290068
		public FStarSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601BF09 RID: 114441 RVA: 0x00291E72 File Offset: 0x00290072
		public FStarSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601BF0A RID: 114442 RVA: 0x00291E7D File Offset: 0x0029007D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStarSetting(Pointer, false, true);
		}

		// Token: 0x0601BF0B RID: 114443 RVA: 0x00291E87 File Offset: 0x00290087
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStarSetting(Pointer, MemoryOwner);
		}

		// Token: 0x0400EFF4 RID: 61428
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.StarSetting";

		// Token: 0x0400EFF5 RID: 61429
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EFF6 RID: 61430
		internal static int __PropertyOffset_bOverride_StarFieldColor;

		// Token: 0x0400EFF7 RID: 61431
		internal static byte __PropertyMask_bOverride_StarFieldColor;

		// Token: 0x0400EFF8 RID: 61432
		internal static int __PropertyOffset_bOverride_StarSize;

		// Token: 0x0400EFF9 RID: 61433
		internal static byte __PropertyMask_bOverride_StarSize;

		// Token: 0x0400EFFA RID: 61434
		internal static int __PropertyOffset_bOverride_StarSpeed;

		// Token: 0x0400EFFB RID: 61435
		internal static byte __PropertyMask_bOverride_StarSpeed;

		// Token: 0x0400EFFC RID: 61436
		internal static int __PropertyOffset_bOverride_StarSwitch;

		// Token: 0x0400EFFD RID: 61437
		internal static byte __PropertyMask_bOverride_StarSwitch;

		// Token: 0x0400EFFE RID: 61438
		internal static int __PropertyOffset_bOverride_NoiseTexture;

		// Token: 0x0400EFFF RID: 61439
		internal static byte __PropertyMask_bOverride_NoiseTexture;

		// Token: 0x0400F000 RID: 61440
		internal static int __PropertyOffset_bOverride_NoiseSwitch;

		// Token: 0x0400F001 RID: 61441
		internal static byte __PropertyMask_bOverride_NoiseSwitch;

		// Token: 0x0400F002 RID: 61442
		internal static int __PropertyOffset_bOverride_UVTillingU;

		// Token: 0x0400F003 RID: 61443
		internal static byte __PropertyMask_bOverride_UVTillingU;

		// Token: 0x0400F004 RID: 61444
		internal static int __PropertyOffset_bOverride_UVTillingV;

		// Token: 0x0400F005 RID: 61445
		internal static byte __PropertyMask_bOverride_UVTillingV;

		// Token: 0x0400F006 RID: 61446
		internal static int __PropertyOffset_bOverride_StarMap;

		// Token: 0x0400F007 RID: 61447
		internal static byte __PropertyMask_bOverride_StarMap;

		// Token: 0x0400F008 RID: 61448
		internal static int __PropertyOffset_bOverride_StarMapPC;

		// Token: 0x0400F009 RID: 61449
		internal static byte __PropertyMask_bOverride_StarMapPC;

		// Token: 0x0400F00A RID: 61450
		internal static int __PropertyOffset_StarFieldColor;

		// Token: 0x0400F00B RID: 61451
		internal static int __PropertyOffset_bOverride_UseStarV2;

		// Token: 0x0400F00C RID: 61452
		internal static byte __PropertyMask_bOverride_UseStarV2;

		// Token: 0x0400F00D RID: 61453
		internal static int __PropertyOffset_bOverride_StarCloudFogColor;

		// Token: 0x0400F00E RID: 61454
		internal static byte __PropertyMask_bOverride_StarCloudFogColor;

		// Token: 0x0400F00F RID: 61455
		internal static int __PropertyOffset_bOverride_StarTex_V2;

		// Token: 0x0400F010 RID: 61456
		internal static byte __PropertyMask_bOverride_StarTex_V2;

		// Token: 0x0400F011 RID: 61457
		internal static int __PropertyOffset_StarSize;

		// Token: 0x0400F012 RID: 61458
		internal static int __PropertyOffset_StarSpeed;

		// Token: 0x0400F013 RID: 61459
		internal static int __PropertyOffset_StarSwitch;

		// Token: 0x0400F014 RID: 61460
		internal static int __PropertyOffset_NoiseTexture;

		// Token: 0x0400F015 RID: 61461
		internal static int __PropertyOffset_NoiseSwitch;

		// Token: 0x0400F016 RID: 61462
		internal static int __PropertyOffset_UVTillingU;

		// Token: 0x0400F017 RID: 61463
		internal static int __PropertyOffset_UVTillingV;

		// Token: 0x0400F018 RID: 61464
		internal static int __PropertyOffset_StarMap;

		// Token: 0x0400F019 RID: 61465
		internal static int __PropertyOffset_StarMap_PC;

		// Token: 0x0400F01A RID: 61466
		internal static int __PropertyOffset_bUseStarV2;

		// Token: 0x0400F01B RID: 61467
		internal static int __PropertyOffset_StarCloudFogColor;

		// Token: 0x0400F01C RID: 61468
		internal static int __PropertyOffset_StarTex_V2;
	}
}
