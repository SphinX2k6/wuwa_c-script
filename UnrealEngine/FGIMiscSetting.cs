using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A9B RID: 6811
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.GIMiscSetting")]
	[UnrealStructLayout(688, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 688)]
	public class FGIMiscSetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060191F6 RID: 102902 RVA: 0x0025209A File Offset: 0x0025029A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGIMiscSetting._ScriptStructPtr != 0) ? FGIMiscSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.GIMiscSetting", ref FGIMiscSetting._ScriptStructPtr);
		}

		// Token: 0x170063C7 RID: 25543
		// (get) Token: 0x060191F7 RID: 102903 RVA: 0x002520BE File Offset: 0x002502BE
		// (set) Token: 0x060191F8 RID: 102904 RVA: 0x002520D7 File Offset: 0x002502D7
		public unsafe bool bOverride_ThunderType
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_ThunderType) & FGIMiscSetting.__PropertyMask_bOverride_ThunderType) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_ThunderType) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_ThunderType) & ~FGIMiscSetting.__PropertyMask_bOverride_ThunderType) | (value ? FGIMiscSetting.__PropertyMask_bOverride_ThunderType : 0));
			}
		}

		// Token: 0x170063C8 RID: 25544
		// (get) Token: 0x060191F9 RID: 102905 RVA: 0x00252107 File Offset: 0x00250307
		// (set) Token: 0x060191FA RID: 102906 RVA: 0x00252120 File Offset: 0x00250320
		public unsafe bool bOverride_ThunderGenerateChanceScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_ThunderGenerateChanceScale) & FGIMiscSetting.__PropertyMask_bOverride_ThunderGenerateChanceScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_ThunderGenerateChanceScale) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_ThunderGenerateChanceScale) & ~FGIMiscSetting.__PropertyMask_bOverride_ThunderGenerateChanceScale) | (value ? FGIMiscSetting.__PropertyMask_bOverride_ThunderGenerateChanceScale : 0));
			}
		}

		// Token: 0x170063C9 RID: 25545
		// (get) Token: 0x060191FB RID: 102907 RVA: 0x00252150 File Offset: 0x00250350
		// (set) Token: 0x060191FC RID: 102908 RVA: 0x00252169 File Offset: 0x00250369
		public unsafe bool bOverride_ThunderAttackChance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_ThunderAttackChance) & FGIMiscSetting.__PropertyMask_bOverride_ThunderAttackChance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_ThunderAttackChance) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_ThunderAttackChance) & ~FGIMiscSetting.__PropertyMask_bOverride_ThunderAttackChance) | (value ? FGIMiscSetting.__PropertyMask_bOverride_ThunderAttackChance : 0));
			}
		}

		// Token: 0x170063CA RID: 25546
		// (get) Token: 0x060191FD RID: 102909 RVA: 0x00252199 File Offset: 0x00250399
		// (set) Token: 0x060191FE RID: 102910 RVA: 0x002521B2 File Offset: 0x002503B2
		public unsafe bool bOverride_ThunderColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_ThunderColor) & FGIMiscSetting.__PropertyMask_bOverride_ThunderColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_ThunderColor) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_ThunderColor) & ~FGIMiscSetting.__PropertyMask_bOverride_ThunderColor) | (value ? FGIMiscSetting.__PropertyMask_bOverride_ThunderColor : 0));
			}
		}

		// Token: 0x170063CB RID: 25547
		// (get) Token: 0x060191FF RID: 102911 RVA: 0x002521E2 File Offset: 0x002503E2
		// (set) Token: 0x06019200 RID: 102912 RVA: 0x002521FB File Offset: 0x002503FB
		public unsafe bool bOverride_ThunderLightBrightness
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_ThunderLightBrightness) & FGIMiscSetting.__PropertyMask_bOverride_ThunderLightBrightness) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_ThunderLightBrightness) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_ThunderLightBrightness) & ~FGIMiscSetting.__PropertyMask_bOverride_ThunderLightBrightness) | (value ? FGIMiscSetting.__PropertyMask_bOverride_ThunderLightBrightness : 0));
			}
		}

		// Token: 0x170063CC RID: 25548
		// (get) Token: 0x06019201 RID: 102913 RVA: 0x0025222B File Offset: 0x0025042B
		// (set) Token: 0x06019202 RID: 102914 RVA: 0x00252244 File Offset: 0x00250444
		public unsafe bool bOverride_ThunderLightColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_ThunderLightColor) & FGIMiscSetting.__PropertyMask_bOverride_ThunderLightColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_ThunderLightColor) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_ThunderLightColor) & ~FGIMiscSetting.__PropertyMask_bOverride_ThunderLightColor) | (value ? FGIMiscSetting.__PropertyMask_bOverride_ThunderLightColor : 0));
			}
		}

		// Token: 0x170063CD RID: 25549
		// (get) Token: 0x06019203 RID: 102915 RVA: 0x00252274 File Offset: 0x00250474
		// (set) Token: 0x06019204 RID: 102916 RVA: 0x0025228D File Offset: 0x0025048D
		public unsafe bool bOverride_ThunderCloudBrightness
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_ThunderCloudBrightness) & FGIMiscSetting.__PropertyMask_bOverride_ThunderCloudBrightness) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_ThunderCloudBrightness) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_ThunderCloudBrightness) & ~FGIMiscSetting.__PropertyMask_bOverride_ThunderCloudBrightness) | (value ? FGIMiscSetting.__PropertyMask_bOverride_ThunderCloudBrightness : 0));
			}
		}

		// Token: 0x170063CE RID: 25550
		// (get) Token: 0x06019205 RID: 102917 RVA: 0x002522BD File Offset: 0x002504BD
		// (set) Token: 0x06019206 RID: 102918 RVA: 0x002522D1 File Offset: 0x002504D1
		[Nullable(0)]
		public unsafe TEnumAsByte<EKuroThunderType> ThunderType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_ThunderType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_ThunderType) = value;
			}
		}

		// Token: 0x170063CF RID: 25551
		// (get) Token: 0x06019207 RID: 102919 RVA: 0x002522E6 File Offset: 0x002504E6
		// (set) Token: 0x06019208 RID: 102920 RVA: 0x002522F6 File Offset: 0x002504F6
		public unsafe float ThunderGenerateChanceScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_ThunderGenerateChanceScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_ThunderGenerateChanceScale) = value;
			}
		}

		// Token: 0x170063D0 RID: 25552
		// (get) Token: 0x06019209 RID: 102921 RVA: 0x00252307 File Offset: 0x00250507
		// (set) Token: 0x0601920A RID: 102922 RVA: 0x00252317 File Offset: 0x00250517
		public unsafe float ThunderAttackChance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_ThunderAttackChance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_ThunderAttackChance) = value;
			}
		}

		// Token: 0x170063D1 RID: 25553
		// (get) Token: 0x0601920B RID: 102923 RVA: 0x00252328 File Offset: 0x00250528
		// (set) Token: 0x0601920C RID: 102924 RVA: 0x0025233C File Offset: 0x0025053C
		public unsafe FLinearColor ThunderColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_ThunderColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_ThunderColor) = value;
			}
		}

		// Token: 0x170063D2 RID: 25554
		// (get) Token: 0x0601920D RID: 102925 RVA: 0x00252351 File Offset: 0x00250551
		// (set) Token: 0x0601920E RID: 102926 RVA: 0x00252361 File Offset: 0x00250561
		public unsafe float ThunderLightBrightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_ThunderLightBrightness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_ThunderLightBrightness) = value;
			}
		}

		// Token: 0x170063D3 RID: 25555
		// (get) Token: 0x0601920F RID: 102927 RVA: 0x00252372 File Offset: 0x00250572
		// (set) Token: 0x06019210 RID: 102928 RVA: 0x00252386 File Offset: 0x00250586
		public unsafe FLinearColor ThunderLightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_ThunderLightColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_ThunderLightColor) = value;
			}
		}

		// Token: 0x170063D4 RID: 25556
		// (get) Token: 0x06019211 RID: 102929 RVA: 0x0025239B File Offset: 0x0025059B
		// (set) Token: 0x06019212 RID: 102930 RVA: 0x002523AB File Offset: 0x002505AB
		public unsafe float ThunderCloudBrightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_ThunderCloudBrightness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_ThunderCloudBrightness) = value;
			}
		}

		// Token: 0x170063D5 RID: 25557
		// (get) Token: 0x06019213 RID: 102931 RVA: 0x002523BC File Offset: 0x002505BC
		// (set) Token: 0x06019214 RID: 102932 RVA: 0x002523D5 File Offset: 0x002505D5
		public unsafe bool bOverride_RainType
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainType) & FGIMiscSetting.__PropertyMask_bOverride_RainType) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainType) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainType) & ~FGIMiscSetting.__PropertyMask_bOverride_RainType) | (value ? FGIMiscSetting.__PropertyMask_bOverride_RainType : 0));
			}
		}

		// Token: 0x170063D6 RID: 25558
		// (get) Token: 0x06019215 RID: 102933 RVA: 0x00252405 File Offset: 0x00250605
		// (set) Token: 0x06019216 RID: 102934 RVA: 0x0025241E File Offset: 0x0025061E
		public unsafe bool bOverride_RainDensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainDensity) & FGIMiscSetting.__PropertyMask_bOverride_RainDensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainDensity) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainDensity) & ~FGIMiscSetting.__PropertyMask_bOverride_RainDensity) | (value ? FGIMiscSetting.__PropertyMask_bOverride_RainDensity : 0));
			}
		}

		// Token: 0x170063D7 RID: 25559
		// (get) Token: 0x06019217 RID: 102935 RVA: 0x0025244E File Offset: 0x0025064E
		// (set) Token: 0x06019218 RID: 102936 RVA: 0x00252467 File Offset: 0x00250667
		public unsafe bool bOverride_RainRippleIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainRippleIntensity) & FGIMiscSetting.__PropertyMask_bOverride_RainRippleIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainRippleIntensity) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainRippleIntensity) & ~FGIMiscSetting.__PropertyMask_bOverride_RainRippleIntensity) | (value ? FGIMiscSetting.__PropertyMask_bOverride_RainRippleIntensity : 0));
			}
		}

		// Token: 0x170063D8 RID: 25560
		// (get) Token: 0x06019219 RID: 102937 RVA: 0x00252497 File Offset: 0x00250697
		// (set) Token: 0x0601921A RID: 102938 RVA: 0x002524B0 File Offset: 0x002506B0
		public unsafe bool bOverride_RainLerpTime
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainLerpTime) & FGIMiscSetting.__PropertyMask_bOverride_RainLerpTime) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainLerpTime) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainLerpTime) & ~FGIMiscSetting.__PropertyMask_bOverride_RainLerpTime) | (value ? FGIMiscSetting.__PropertyMask_bOverride_RainLerpTime : 0));
			}
		}

		// Token: 0x170063D9 RID: 25561
		// (get) Token: 0x0601921B RID: 102939 RVA: 0x002524E0 File Offset: 0x002506E0
		// (set) Token: 0x0601921C RID: 102940 RVA: 0x002524F9 File Offset: 0x002506F9
		public unsafe bool bOverride_RainLerpData
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainLerpData) & FGIMiscSetting.__PropertyMask_bOverride_RainLerpData) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainLerpData) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainLerpData) & ~FGIMiscSetting.__PropertyMask_bOverride_RainLerpData) | (value ? FGIMiscSetting.__PropertyMask_bOverride_RainLerpData : 0));
			}
		}

		// Token: 0x170063DA RID: 25562
		// (get) Token: 0x0601921D RID: 102941 RVA: 0x00252529 File Offset: 0x00250729
		// (set) Token: 0x0601921E RID: 102942 RVA: 0x00252542 File Offset: 0x00250742
		public unsafe bool bOverride_RainHeightNoiseChannel
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainHeightNoiseChannel) & FGIMiscSetting.__PropertyMask_bOverride_RainHeightNoiseChannel) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainHeightNoiseChannel) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainHeightNoiseChannel) & ~FGIMiscSetting.__PropertyMask_bOverride_RainHeightNoiseChannel) | (value ? FGIMiscSetting.__PropertyMask_bOverride_RainHeightNoiseChannel : 0));
			}
		}

		// Token: 0x170063DB RID: 25563
		// (get) Token: 0x0601921F RID: 102943 RVA: 0x00252572 File Offset: 0x00250772
		// (set) Token: 0x06019220 RID: 102944 RVA: 0x0025258B File Offset: 0x0025078B
		public unsafe bool bOverride_RainFogDensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainFogDensity) & FGIMiscSetting.__PropertyMask_bOverride_RainFogDensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainFogDensity) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainFogDensity) & ~FGIMiscSetting.__PropertyMask_bOverride_RainFogDensity) | (value ? FGIMiscSetting.__PropertyMask_bOverride_RainFogDensity : 0));
			}
		}

		// Token: 0x170063DC RID: 25564
		// (get) Token: 0x06019221 RID: 102945 RVA: 0x002525BB File Offset: 0x002507BB
		// (set) Token: 0x06019222 RID: 102946 RVA: 0x002525D4 File Offset: 0x002507D4
		public unsafe bool bOverride_RainDensityChangeSpeed
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainDensityChangeSpeed) & FGIMiscSetting.__PropertyMask_bOverride_RainDensityChangeSpeed) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainDensityChangeSpeed) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainDensityChangeSpeed) & ~FGIMiscSetting.__PropertyMask_bOverride_RainDensityChangeSpeed) | (value ? FGIMiscSetting.__PropertyMask_bOverride_RainDensityChangeSpeed : 0));
			}
		}

		// Token: 0x170063DD RID: 25565
		// (get) Token: 0x06019223 RID: 102947 RVA: 0x00252604 File Offset: 0x00250804
		// (set) Token: 0x06019224 RID: 102948 RVA: 0x0025261D File Offset: 0x0025081D
		public unsafe bool bOverride_bRainAffactPointLight
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_bRainAffactPointLight) & FGIMiscSetting.__PropertyMask_bOverride_bRainAffactPointLight) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_bRainAffactPointLight) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_bRainAffactPointLight) & ~FGIMiscSetting.__PropertyMask_bOverride_bRainAffactPointLight) | (value ? FGIMiscSetting.__PropertyMask_bOverride_bRainAffactPointLight : 0));
			}
		}

		// Token: 0x170063DE RID: 25566
		// (get) Token: 0x06019225 RID: 102949 RVA: 0x0025264D File Offset: 0x0025084D
		// (set) Token: 0x06019226 RID: 102950 RVA: 0x00252661 File Offset: 0x00250861
		[Nullable(0)]
		public unsafe TEnumAsByte<EKuroRainType> RainType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_RainType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_RainType) = value;
			}
		}

		// Token: 0x170063DF RID: 25567
		// (get) Token: 0x06019227 RID: 102951 RVA: 0x00252676 File Offset: 0x00250876
		// (set) Token: 0x06019228 RID: 102952 RVA: 0x00252686 File Offset: 0x00250886
		public unsafe float RainDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_RainDensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_RainDensity) = value;
			}
		}

		// Token: 0x170063E0 RID: 25568
		// (get) Token: 0x06019229 RID: 102953 RVA: 0x00252697 File Offset: 0x00250897
		// (set) Token: 0x0601922A RID: 102954 RVA: 0x002526A7 File Offset: 0x002508A7
		public unsafe float RainRippleIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_RainRippleIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_RainRippleIntensity) = value;
			}
		}

		// Token: 0x170063E1 RID: 25569
		// (get) Token: 0x0601922B RID: 102955 RVA: 0x002526B8 File Offset: 0x002508B8
		// (set) Token: 0x0601922C RID: 102956 RVA: 0x002526C8 File Offset: 0x002508C8
		public unsafe float RainLerpTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_RainLerpTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_RainLerpTime) = value;
			}
		}

		// Token: 0x170063E2 RID: 25570
		// (get) Token: 0x0601922D RID: 102957 RVA: 0x002526D9 File Offset: 0x002508D9
		// (set) Token: 0x0601922E RID: 102958 RVA: 0x002526ED File Offset: 0x002508ED
		public unsafe FVector4 RainLerpData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_RainLerpData);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_RainLerpData) = value;
			}
		}

		// Token: 0x170063E3 RID: 25571
		// (get) Token: 0x0601922F RID: 102959 RVA: 0x00252702 File Offset: 0x00250902
		// (set) Token: 0x06019230 RID: 102960 RVA: 0x00252712 File Offset: 0x00250912
		public unsafe int RainHeightNoiseChannel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_RainHeightNoiseChannel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_RainHeightNoiseChannel) = value;
			}
		}

		// Token: 0x170063E4 RID: 25572
		// (get) Token: 0x06019231 RID: 102961 RVA: 0x00252723 File Offset: 0x00250923
		// (set) Token: 0x06019232 RID: 102962 RVA: 0x00252733 File Offset: 0x00250933
		public unsafe float RainFogDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_RainFogDensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_RainFogDensity) = value;
			}
		}

		// Token: 0x170063E5 RID: 25573
		// (get) Token: 0x06019233 RID: 102963 RVA: 0x00252744 File Offset: 0x00250944
		// (set) Token: 0x06019234 RID: 102964 RVA: 0x00252754 File Offset: 0x00250954
		public unsafe float RainDensityChangeSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_RainDensityChangeSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_RainDensityChangeSpeed) = value;
			}
		}

		// Token: 0x170063E6 RID: 25574
		// (get) Token: 0x06019235 RID: 102965 RVA: 0x00252765 File Offset: 0x00250965
		// (set) Token: 0x06019236 RID: 102966 RVA: 0x00252775 File Offset: 0x00250975
		public unsafe bool bRainAffectPointLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bRainAffectPointLight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bRainAffectPointLight) = (value ? 1 : 0);
			}
		}

		// Token: 0x170063E7 RID: 25575
		// (get) Token: 0x06019237 RID: 102967 RVA: 0x00252786 File Offset: 0x00250986
		// (set) Token: 0x06019238 RID: 102968 RVA: 0x0025279F File Offset: 0x0025099F
		public unsafe bool bOverride_SnowCoverIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_SnowCoverIntensity) & FGIMiscSetting.__PropertyMask_bOverride_SnowCoverIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_SnowCoverIntensity) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_SnowCoverIntensity) & ~FGIMiscSetting.__PropertyMask_bOverride_SnowCoverIntensity) | (value ? FGIMiscSetting.__PropertyMask_bOverride_SnowCoverIntensity : 0));
			}
		}

		// Token: 0x170063E8 RID: 25576
		// (get) Token: 0x06019239 RID: 102969 RVA: 0x002527CF File Offset: 0x002509CF
		// (set) Token: 0x0601923A RID: 102970 RVA: 0x002527DF File Offset: 0x002509DF
		public unsafe float SnowCoverIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_SnowCoverIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_SnowCoverIntensity) = value;
			}
		}

		// Token: 0x170063E9 RID: 25577
		// (get) Token: 0x0601923B RID: 102971 RVA: 0x002527F0 File Offset: 0x002509F0
		// (set) Token: 0x0601923C RID: 102972 RVA: 0x00252809 File Offset: 0x00250A09
		public unsafe bool bOverride_FrozenProgress
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_FrozenProgress) & FGIMiscSetting.__PropertyMask_bOverride_FrozenProgress) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_FrozenProgress) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_FrozenProgress) & ~FGIMiscSetting.__PropertyMask_bOverride_FrozenProgress) | (value ? FGIMiscSetting.__PropertyMask_bOverride_FrozenProgress : 0));
			}
		}

		// Token: 0x170063EA RID: 25578
		// (get) Token: 0x0601923D RID: 102973 RVA: 0x00252839 File Offset: 0x00250A39
		// (set) Token: 0x0601923E RID: 102974 RVA: 0x00252852 File Offset: 0x00250A52
		public unsafe bool bOverride_FrozenTime
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_FrozenTime) & FGIMiscSetting.__PropertyMask_bOverride_FrozenTime) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_FrozenTime) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_FrozenTime) & ~FGIMiscSetting.__PropertyMask_bOverride_FrozenTime) | (value ? FGIMiscSetting.__PropertyMask_bOverride_FrozenTime : 0));
			}
		}

		// Token: 0x170063EB RID: 25579
		// (get) Token: 0x0601923F RID: 102975 RVA: 0x00252882 File Offset: 0x00250A82
		// (set) Token: 0x06019240 RID: 102976 RVA: 0x0025289B File Offset: 0x00250A9B
		public unsafe bool bOverride_SnowSpecksNumber
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_SnowSpecksNumber) & FGIMiscSetting.__PropertyMask_bOverride_SnowSpecksNumber) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_SnowSpecksNumber) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_SnowSpecksNumber) & ~FGIMiscSetting.__PropertyMask_bOverride_SnowSpecksNumber) | (value ? FGIMiscSetting.__PropertyMask_bOverride_SnowSpecksNumber : 0));
			}
		}

		// Token: 0x170063EC RID: 25580
		// (get) Token: 0x06019241 RID: 102977 RVA: 0x002528CB File Offset: 0x00250ACB
		// (set) Token: 0x06019242 RID: 102978 RVA: 0x002528E4 File Offset: 0x00250AE4
		public unsafe bool bOverride_SnowSpecksStrength
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_SnowSpecksStrength) & FGIMiscSetting.__PropertyMask_bOverride_SnowSpecksStrength) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_SnowSpecksStrength) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_SnowSpecksStrength) & ~FGIMiscSetting.__PropertyMask_bOverride_SnowSpecksStrength) | (value ? FGIMiscSetting.__PropertyMask_bOverride_SnowSpecksStrength : 0));
			}
		}

		// Token: 0x170063ED RID: 25581
		// (get) Token: 0x06019243 RID: 102979 RVA: 0x00252914 File Offset: 0x00250B14
		// (set) Token: 0x06019244 RID: 102980 RVA: 0x00252924 File Offset: 0x00250B24
		public unsafe float FrozenProgress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_FrozenProgress);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_FrozenProgress) = value;
			}
		}

		// Token: 0x170063EE RID: 25582
		// (get) Token: 0x06019245 RID: 102981 RVA: 0x00252935 File Offset: 0x00250B35
		// (set) Token: 0x06019246 RID: 102982 RVA: 0x00252945 File Offset: 0x00250B45
		public unsafe float FrozenTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_FrozenTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_FrozenTime) = value;
			}
		}

		// Token: 0x170063EF RID: 25583
		// (get) Token: 0x06019247 RID: 102983 RVA: 0x00252956 File Offset: 0x00250B56
		// (set) Token: 0x06019248 RID: 102984 RVA: 0x00252966 File Offset: 0x00250B66
		public unsafe float SnowSpecksNumber
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_SnowSpecksNumber);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_SnowSpecksNumber) = value;
			}
		}

		// Token: 0x170063F0 RID: 25584
		// (get) Token: 0x06019249 RID: 102985 RVA: 0x00252977 File Offset: 0x00250B77
		// (set) Token: 0x0601924A RID: 102986 RVA: 0x00252987 File Offset: 0x00250B87
		public unsafe float SnowSpecksStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_SnowSpecksStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_SnowSpecksStrength) = value;
			}
		}

		// Token: 0x170063F1 RID: 25585
		// (get) Token: 0x0601924B RID: 102987 RVA: 0x00252998 File Offset: 0x00250B98
		// (set) Token: 0x0601924C RID: 102988 RVA: 0x002529B1 File Offset: 0x00250BB1
		public unsafe bool bOverride_RainWindSize
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainWindSize) & FGIMiscSetting.__PropertyMask_bOverride_RainWindSize) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainWindSize) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainWindSize) & ~FGIMiscSetting.__PropertyMask_bOverride_RainWindSize) | (value ? FGIMiscSetting.__PropertyMask_bOverride_RainWindSize : 0));
			}
		}

		// Token: 0x170063F2 RID: 25586
		// (get) Token: 0x0601924D RID: 102989 RVA: 0x002529E1 File Offset: 0x00250BE1
		// (set) Token: 0x0601924E RID: 102990 RVA: 0x002529FA File Offset: 0x00250BFA
		public unsafe bool bOverride_RainGravity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainGravity) & FGIMiscSetting.__PropertyMask_bOverride_RainGravity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainGravity) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainGravity) & ~FGIMiscSetting.__PropertyMask_bOverride_RainGravity) | (value ? FGIMiscSetting.__PropertyMask_bOverride_RainGravity : 0));
			}
		}

		// Token: 0x170063F3 RID: 25587
		// (get) Token: 0x0601924F RID: 102991 RVA: 0x00252A2A File Offset: 0x00250C2A
		// (set) Token: 0x06019250 RID: 102992 RVA: 0x00252A43 File Offset: 0x00250C43
		public unsafe bool bOverride_RainDrag
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainDrag) & FGIMiscSetting.__PropertyMask_bOverride_RainDrag) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainDrag) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainDrag) & ~FGIMiscSetting.__PropertyMask_bOverride_RainDrag) | (value ? FGIMiscSetting.__PropertyMask_bOverride_RainDrag : 0));
			}
		}

		// Token: 0x170063F4 RID: 25588
		// (get) Token: 0x06019251 RID: 102993 RVA: 0x00252A73 File Offset: 0x00250C73
		// (set) Token: 0x06019252 RID: 102994 RVA: 0x00252A8C File Offset: 0x00250C8C
		public unsafe bool bOverride_RainTimeDilation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainTimeDilation) & FGIMiscSetting.__PropertyMask_bOverride_RainTimeDilation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainTimeDilation) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainTimeDilation) & ~FGIMiscSetting.__PropertyMask_bOverride_RainTimeDilation) | (value ? FGIMiscSetting.__PropertyMask_bOverride_RainTimeDilation : 0));
			}
		}

		// Token: 0x170063F5 RID: 25589
		// (get) Token: 0x06019253 RID: 102995 RVA: 0x00252ABC File Offset: 0x00250CBC
		// (set) Token: 0x06019254 RID: 102996 RVA: 0x00252AD5 File Offset: 0x00250CD5
		public unsafe bool bOverride_RainTimeFreezeSpherize
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainTimeFreezeSpherize) & FGIMiscSetting.__PropertyMask_bOverride_RainTimeFreezeSpherize) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainTimeFreezeSpherize) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainTimeFreezeSpherize) & ~FGIMiscSetting.__PropertyMask_bOverride_RainTimeFreezeSpherize) | (value ? FGIMiscSetting.__PropertyMask_bOverride_RainTimeFreezeSpherize : 0));
			}
		}

		// Token: 0x170063F6 RID: 25590
		// (get) Token: 0x06019255 RID: 102997 RVA: 0x00252B05 File Offset: 0x00250D05
		// (set) Token: 0x06019256 RID: 102998 RVA: 0x00252B1E File Offset: 0x00250D1E
		public unsafe bool bOverride_RainSphereMask
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainSphereMask) & FGIMiscSetting.__PropertyMask_bOverride_RainSphereMask) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainSphereMask) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainSphereMask) & ~FGIMiscSetting.__PropertyMask_bOverride_RainSphereMask) | (value ? FGIMiscSetting.__PropertyMask_bOverride_RainSphereMask : 0));
			}
		}

		// Token: 0x170063F7 RID: 25591
		// (get) Token: 0x06019257 RID: 102999 RVA: 0x00252B4E File Offset: 0x00250D4E
		// (set) Token: 0x06019258 RID: 103000 RVA: 0x00252B67 File Offset: 0x00250D67
		public unsafe bool bOverride_RainSphereMaskOffset
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainSphereMaskOffset) & FGIMiscSetting.__PropertyMask_bOverride_RainSphereMaskOffset) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainSphereMaskOffset) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainSphereMaskOffset) & ~FGIMiscSetting.__PropertyMask_bOverride_RainSphereMaskOffset) | (value ? FGIMiscSetting.__PropertyMask_bOverride_RainSphereMaskOffset : 0));
			}
		}

		// Token: 0x170063F8 RID: 25592
		// (get) Token: 0x06019259 RID: 103001 RVA: 0x00252B97 File Offset: 0x00250D97
		// (set) Token: 0x0601925A RID: 103002 RVA: 0x00252BB0 File Offset: 0x00250DB0
		public unsafe bool bOverride_RainSphereMaskUseBone
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainSphereMaskUseBone) & FGIMiscSetting.__PropertyMask_bOverride_RainSphereMaskUseBone) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainSphereMaskUseBone) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RainSphereMaskUseBone) & ~FGIMiscSetting.__PropertyMask_bOverride_RainSphereMaskUseBone) | (value ? FGIMiscSetting.__PropertyMask_bOverride_RainSphereMaskUseBone : 0));
			}
		}

		// Token: 0x170063F9 RID: 25593
		// (get) Token: 0x0601925B RID: 103003 RVA: 0x00252BE0 File Offset: 0x00250DE0
		// (set) Token: 0x0601925C RID: 103004 RVA: 0x00252BF0 File Offset: 0x00250DF0
		public unsafe float RainWindSizeOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_RainWindSizeOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_RainWindSizeOverride) = value;
			}
		}

		// Token: 0x170063FA RID: 25594
		// (get) Token: 0x0601925D RID: 103005 RVA: 0x00252C01 File Offset: 0x00250E01
		// (set) Token: 0x0601925E RID: 103006 RVA: 0x00252C15 File Offset: 0x00250E15
		public unsafe FVector RainGravityOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_RainGravityOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_RainGravityOverride) = value;
			}
		}

		// Token: 0x170063FB RID: 25595
		// (get) Token: 0x0601925F RID: 103007 RVA: 0x00252C2A File Offset: 0x00250E2A
		// (set) Token: 0x06019260 RID: 103008 RVA: 0x00252C3A File Offset: 0x00250E3A
		public unsafe float RainDragOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_RainDragOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_RainDragOverride) = value;
			}
		}

		// Token: 0x170063FC RID: 25596
		// (get) Token: 0x06019261 RID: 103009 RVA: 0x00252C4B File Offset: 0x00250E4B
		// (set) Token: 0x06019262 RID: 103010 RVA: 0x00252C5B File Offset: 0x00250E5B
		public unsafe float RainTimeDilationOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_RainTimeDilationOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_RainTimeDilationOverride) = value;
			}
		}

		// Token: 0x170063FD RID: 25597
		// (get) Token: 0x06019263 RID: 103011 RVA: 0x00252C6C File Offset: 0x00250E6C
		// (set) Token: 0x06019264 RID: 103012 RVA: 0x00252C7C File Offset: 0x00250E7C
		public unsafe bool bRainTimeFreezeSpherize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bRainTimeFreezeSpherize) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bRainTimeFreezeSpherize) = (value ? 1 : 0);
			}
		}

		// Token: 0x170063FE RID: 25598
		// (get) Token: 0x06019265 RID: 103013 RVA: 0x00252C8D File Offset: 0x00250E8D
		// (set) Token: 0x06019266 RID: 103014 RVA: 0x00252C9D File Offset: 0x00250E9D
		public unsafe float RainToSphereTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_RainToSphereTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_RainToSphereTime) = value;
			}
		}

		// Token: 0x170063FF RID: 25599
		// (get) Token: 0x06019267 RID: 103015 RVA: 0x00252CAE File Offset: 0x00250EAE
		// (set) Token: 0x06019268 RID: 103016 RVA: 0x00252CBE File Offset: 0x00250EBE
		public unsafe float RainToRainTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_RainToRainTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_RainToRainTime) = value;
			}
		}

		// Token: 0x17006400 RID: 25600
		// (get) Token: 0x06019269 RID: 103017 RVA: 0x00252CCF File Offset: 0x00250ECF
		// (set) Token: 0x0601926A RID: 103018 RVA: 0x00252CDF File Offset: 0x00250EDF
		public unsafe float RainSphereMaskRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_RainSphereMaskRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_RainSphereMaskRadius) = value;
			}
		}

		// Token: 0x17006401 RID: 25601
		// (get) Token: 0x0601926B RID: 103019 RVA: 0x00252CF0 File Offset: 0x00250EF0
		// (set) Token: 0x0601926C RID: 103020 RVA: 0x00252D04 File Offset: 0x00250F04
		public unsafe FVector RainSphereMaskOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_RainSphereMaskOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_RainSphereMaskOffset) = value;
			}
		}

		// Token: 0x17006402 RID: 25602
		// (get) Token: 0x0601926D RID: 103021 RVA: 0x00252D19 File Offset: 0x00250F19
		// (set) Token: 0x0601926E RID: 103022 RVA: 0x00252D29 File Offset: 0x00250F29
		public unsafe bool bRainSphereMaskUseBone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bRainSphereMaskUseBone) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bRainSphereMaskUseBone) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006403 RID: 25603
		// (get) Token: 0x0601926F RID: 103023 RVA: 0x00252D3A File Offset: 0x00250F3A
		// (set) Token: 0x06019270 RID: 103024 RVA: 0x00252D4E File Offset: 0x00250F4E
		public unsafe FName RainSphereMaskBoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_RainSphereMaskBoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_RainSphereMaskBoneName) = value;
			}
		}

		// Token: 0x17006404 RID: 25604
		// (get) Token: 0x06019271 RID: 103025 RVA: 0x00252D63 File Offset: 0x00250F63
		// (set) Token: 0x06019272 RID: 103026 RVA: 0x00252D7C File Offset: 0x00250F7C
		public unsafe bool bOverride_RoughnessDensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RoughnessDensity) & FGIMiscSetting.__PropertyMask_bOverride_RoughnessDensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RoughnessDensity) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_RoughnessDensity) & ~FGIMiscSetting.__PropertyMask_bOverride_RoughnessDensity) | (value ? FGIMiscSetting.__PropertyMask_bOverride_RoughnessDensity : 0));
			}
		}

		// Token: 0x17006405 RID: 25605
		// (get) Token: 0x06019273 RID: 103027 RVA: 0x00252DAC File Offset: 0x00250FAC
		// (set) Token: 0x06019274 RID: 103028 RVA: 0x00252DC5 File Offset: 0x00250FC5
		public unsafe bool bOverride_MixRoughness
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_MixRoughness) & FGIMiscSetting.__PropertyMask_bOverride_MixRoughness) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_MixRoughness) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_MixRoughness) & ~FGIMiscSetting.__PropertyMask_bOverride_MixRoughness) | (value ? FGIMiscSetting.__PropertyMask_bOverride_MixRoughness : 0));
			}
		}

		// Token: 0x17006406 RID: 25606
		// (get) Token: 0x06019275 RID: 103029 RVA: 0x00252DF5 File Offset: 0x00250FF5
		// (set) Token: 0x06019276 RID: 103030 RVA: 0x00252E0E File Offset: 0x0025100E
		public unsafe bool bOverride_MixRoughness_Mobile
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_MixRoughness_Mobile) & FGIMiscSetting.__PropertyMask_bOverride_MixRoughness_Mobile) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_MixRoughness_Mobile) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_MixRoughness_Mobile) & ~FGIMiscSetting.__PropertyMask_bOverride_MixRoughness_Mobile) | (value ? FGIMiscSetting.__PropertyMask_bOverride_MixRoughness_Mobile : 0));
			}
		}

		// Token: 0x17006407 RID: 25607
		// (get) Token: 0x06019277 RID: 103031 RVA: 0x00252E3E File Offset: 0x0025103E
		// (set) Token: 0x06019278 RID: 103032 RVA: 0x00252E57 File Offset: 0x00251057
		public unsafe bool bOverride_EffectGravity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_EffectGravity) & FGIMiscSetting.__PropertyMask_bOverride_EffectGravity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_EffectGravity) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_EffectGravity) & ~FGIMiscSetting.__PropertyMask_bOverride_EffectGravity) | (value ? FGIMiscSetting.__PropertyMask_bOverride_EffectGravity : 0));
			}
		}

		// Token: 0x17006408 RID: 25608
		// (get) Token: 0x06019279 RID: 103033 RVA: 0x00252E87 File Offset: 0x00251087
		// (set) Token: 0x0601927A RID: 103034 RVA: 0x00252EA0 File Offset: 0x002510A0
		public unsafe bool bOverride_LightFunctionIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_LightFunctionIntensity) & FGIMiscSetting.__PropertyMask_bOverride_LightFunctionIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_LightFunctionIntensity) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_LightFunctionIntensity) & ~FGIMiscSetting.__PropertyMask_bOverride_LightFunctionIntensity) | (value ? FGIMiscSetting.__PropertyMask_bOverride_LightFunctionIntensity : 0));
			}
		}

		// Token: 0x17006409 RID: 25609
		// (get) Token: 0x0601927B RID: 103035 RVA: 0x00252ED0 File Offset: 0x002510D0
		// (set) Token: 0x0601927C RID: 103036 RVA: 0x00252EE9 File Offset: 0x002510E9
		public unsafe bool bOverride_LightFunctionMapUVScaleBias
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_LightFunctionMapUVScaleBias) & FGIMiscSetting.__PropertyMask_bOverride_LightFunctionMapUVScaleBias) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_LightFunctionMapUVScaleBias) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_LightFunctionMapUVScaleBias) & ~FGIMiscSetting.__PropertyMask_bOverride_LightFunctionMapUVScaleBias) | (value ? FGIMiscSetting.__PropertyMask_bOverride_LightFunctionMapUVScaleBias : 0));
			}
		}

		// Token: 0x1700640A RID: 25610
		// (get) Token: 0x0601927D RID: 103037 RVA: 0x00252F19 File Offset: 0x00251119
		// (set) Token: 0x0601927E RID: 103038 RVA: 0x00252F32 File Offset: 0x00251132
		public unsafe bool bOverride_LightFunctionSpeed
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_LightFunctionSpeed) & FGIMiscSetting.__PropertyMask_bOverride_LightFunctionSpeed) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_LightFunctionSpeed) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_LightFunctionSpeed) & ~FGIMiscSetting.__PropertyMask_bOverride_LightFunctionSpeed) | (value ? FGIMiscSetting.__PropertyMask_bOverride_LightFunctionSpeed : 0));
			}
		}

		// Token: 0x1700640B RID: 25611
		// (get) Token: 0x0601927F RID: 103039 RVA: 0x00252F62 File Offset: 0x00251162
		// (set) Token: 0x06019280 RID: 103040 RVA: 0x00252F7B File Offset: 0x0025117B
		public unsafe bool bOverride_LightFunctionAngle
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_LightFunctionAngle) & FGIMiscSetting.__PropertyMask_bOverride_LightFunctionAngle) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_LightFunctionAngle) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_LightFunctionAngle) & ~FGIMiscSetting.__PropertyMask_bOverride_LightFunctionAngle) | (value ? FGIMiscSetting.__PropertyMask_bOverride_LightFunctionAngle : 0));
			}
		}

		// Token: 0x1700640C RID: 25612
		// (get) Token: 0x06019281 RID: 103041 RVA: 0x00252FAB File Offset: 0x002511AB
		// (set) Token: 0x06019282 RID: 103042 RVA: 0x00252FC4 File Offset: 0x002511C4
		public unsafe bool bOverride_LightFunctionTexture
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_LightFunctionTexture) & FGIMiscSetting.__PropertyMask_bOverride_LightFunctionTexture) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_LightFunctionTexture) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_LightFunctionTexture) & ~FGIMiscSetting.__PropertyMask_bOverride_LightFunctionTexture) | (value ? FGIMiscSetting.__PropertyMask_bOverride_LightFunctionTexture : 0));
			}
		}

		// Token: 0x1700640D RID: 25613
		// (get) Token: 0x06019283 RID: 103043 RVA: 0x00252FF4 File Offset: 0x002511F4
		// (set) Token: 0x06019284 RID: 103044 RVA: 0x0025300D File Offset: 0x0025120D
		public unsafe bool bOverride_LightFunctionPerShadowTexture
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_LightFunctionPerShadowTexture) & FGIMiscSetting.__PropertyMask_bOverride_LightFunctionPerShadowTexture) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_LightFunctionPerShadowTexture) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_LightFunctionPerShadowTexture) & ~FGIMiscSetting.__PropertyMask_bOverride_LightFunctionPerShadowTexture) | (value ? FGIMiscSetting.__PropertyMask_bOverride_LightFunctionPerShadowTexture : 0));
			}
		}

		// Token: 0x1700640E RID: 25614
		// (get) Token: 0x06019285 RID: 103045 RVA: 0x0025303D File Offset: 0x0025123D
		// (set) Token: 0x06019286 RID: 103046 RVA: 0x00253056 File Offset: 0x00251256
		public unsafe bool bOverride_KuroDynamicCloudType
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_KuroDynamicCloudType) & FGIMiscSetting.__PropertyMask_bOverride_KuroDynamicCloudType) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_KuroDynamicCloudType) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_KuroDynamicCloudType) & ~FGIMiscSetting.__PropertyMask_bOverride_KuroDynamicCloudType) | (value ? FGIMiscSetting.__PropertyMask_bOverride_KuroDynamicCloudType : 0));
			}
		}

		// Token: 0x1700640F RID: 25615
		// (get) Token: 0x06019287 RID: 103047 RVA: 0x00253086 File Offset: 0x00251286
		// (set) Token: 0x06019288 RID: 103048 RVA: 0x0025309F File Offset: 0x0025129F
		public unsafe bool bOverride_SequenceCloudTimeControl
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_SequenceCloudTimeControl) & FGIMiscSetting.__PropertyMask_bOverride_SequenceCloudTimeControl) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_SequenceCloudTimeControl) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_SequenceCloudTimeControl) & ~FGIMiscSetting.__PropertyMask_bOverride_SequenceCloudTimeControl) | (value ? FGIMiscSetting.__PropertyMask_bOverride_SequenceCloudTimeControl : 0));
			}
		}

		// Token: 0x17006410 RID: 25616
		// (get) Token: 0x06019289 RID: 103049 RVA: 0x002530CF File Offset: 0x002512CF
		// (set) Token: 0x0601928A RID: 103050 RVA: 0x002530E8 File Offset: 0x002512E8
		public unsafe bool bOverride_SequenceCloudTimeOffset
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_SequenceCloudTimeOffset) & FGIMiscSetting.__PropertyMask_bOverride_SequenceCloudTimeOffset) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_SequenceCloudTimeOffset) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_SequenceCloudTimeOffset) & ~FGIMiscSetting.__PropertyMask_bOverride_SequenceCloudTimeOffset) | (value ? FGIMiscSetting.__PropertyMask_bOverride_SequenceCloudTimeOffset : 0));
			}
		}

		// Token: 0x17006411 RID: 25617
		// (get) Token: 0x0601928B RID: 103051 RVA: 0x00253118 File Offset: 0x00251318
		// (set) Token: 0x0601928C RID: 103052 RVA: 0x00253131 File Offset: 0x00251331
		public unsafe bool bOverride_OverrideCloudRotation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_OverrideCloudRotation) & FGIMiscSetting.__PropertyMask_bOverride_OverrideCloudRotation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_OverrideCloudRotation) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_OverrideCloudRotation) & ~FGIMiscSetting.__PropertyMask_bOverride_OverrideCloudRotation) | (value ? FGIMiscSetting.__PropertyMask_bOverride_OverrideCloudRotation : 0));
			}
		}

		// Token: 0x17006412 RID: 25618
		// (get) Token: 0x0601928D RID: 103053 RVA: 0x00253161 File Offset: 0x00251361
		// (set) Token: 0x0601928E RID: 103054 RVA: 0x0025317A File Offset: 0x0025137A
		public unsafe bool bOverride_InstantSwitchDynamicCloud
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_InstantSwitchDynamicCloud) & FGIMiscSetting.__PropertyMask_bOverride_InstantSwitchDynamicCloud) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_InstantSwitchDynamicCloud) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_InstantSwitchDynamicCloud) & ~FGIMiscSetting.__PropertyMask_bOverride_InstantSwitchDynamicCloud) | (value ? FGIMiscSetting.__PropertyMask_bOverride_InstantSwitchDynamicCloud : 0));
			}
		}

		// Token: 0x17006413 RID: 25619
		// (get) Token: 0x0601928F RID: 103055 RVA: 0x002531AA File Offset: 0x002513AA
		// (set) Token: 0x06019290 RID: 103056 RVA: 0x002531C3 File Offset: 0x002513C3
		public unsafe bool bOverride_SequenceGlobalTimeControl
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_SequenceGlobalTimeControl) & FGIMiscSetting.__PropertyMask_bOverride_SequenceGlobalTimeControl) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_SequenceGlobalTimeControl) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_SequenceGlobalTimeControl) & ~FGIMiscSetting.__PropertyMask_bOverride_SequenceGlobalTimeControl) | (value ? FGIMiscSetting.__PropertyMask_bOverride_SequenceGlobalTimeControl : 0));
			}
		}

		// Token: 0x17006414 RID: 25620
		// (get) Token: 0x06019291 RID: 103057 RVA: 0x002531F3 File Offset: 0x002513F3
		// (set) Token: 0x06019292 RID: 103058 RVA: 0x0025320C File Offset: 0x0025140C
		public unsafe bool bOverride_MaterialDynamicReflectionTexture
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_MaterialDynamicReflectionTexture) & FGIMiscSetting.__PropertyMask_bOverride_MaterialDynamicReflectionTexture) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_MaterialDynamicReflectionTexture) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_MaterialDynamicReflectionTexture) & ~FGIMiscSetting.__PropertyMask_bOverride_MaterialDynamicReflectionTexture) | (value ? FGIMiscSetting.__PropertyMask_bOverride_MaterialDynamicReflectionTexture : 0));
			}
		}

		// Token: 0x17006415 RID: 25621
		// (get) Token: 0x06019293 RID: 103059 RVA: 0x0025323C File Offset: 0x0025143C
		// (set) Token: 0x06019294 RID: 103060 RVA: 0x00253255 File Offset: 0x00251455
		public unsafe bool bOverride_FogVisibilityCulling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_FogVisibilityCulling) & FGIMiscSetting.__PropertyMask_bOverride_FogVisibilityCulling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_FogVisibilityCulling) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_FogVisibilityCulling) & ~FGIMiscSetting.__PropertyMask_bOverride_FogVisibilityCulling) | (value ? FGIMiscSetting.__PropertyMask_bOverride_FogVisibilityCulling : 0));
			}
		}

		// Token: 0x17006416 RID: 25622
		// (get) Token: 0x06019295 RID: 103061 RVA: 0x00253285 File Offset: 0x00251485
		// (set) Token: 0x06019296 RID: 103062 RVA: 0x00253295 File Offset: 0x00251495
		public unsafe float RoughnessDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_RoughnessDensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_RoughnessDensity) = value;
			}
		}

		// Token: 0x17006417 RID: 25623
		// (get) Token: 0x06019297 RID: 103063 RVA: 0x002532A6 File Offset: 0x002514A6
		// (set) Token: 0x06019298 RID: 103064 RVA: 0x002532B6 File Offset: 0x002514B6
		public unsafe float MixRoughness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_MixRoughness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_MixRoughness) = value;
			}
		}

		// Token: 0x17006418 RID: 25624
		// (get) Token: 0x06019299 RID: 103065 RVA: 0x002532C7 File Offset: 0x002514C7
		// (set) Token: 0x0601929A RID: 103066 RVA: 0x002532D7 File Offset: 0x002514D7
		public unsafe float MixRoughness_Mobile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_MixRoughness_Mobile);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_MixRoughness_Mobile) = value;
			}
		}

		// Token: 0x17006419 RID: 25625
		// (get) Token: 0x0601929B RID: 103067 RVA: 0x002532E8 File Offset: 0x002514E8
		// (set) Token: 0x0601929C RID: 103068 RVA: 0x002532F8 File Offset: 0x002514F8
		public unsafe float EffectGravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_EffectGravity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_EffectGravity) = value;
			}
		}

		// Token: 0x1700641A RID: 25626
		// (get) Token: 0x0601929D RID: 103069 RVA: 0x00253309 File Offset: 0x00251509
		// (set) Token: 0x0601929E RID: 103070 RVA: 0x00253319 File Offset: 0x00251519
		public unsafe float LightFunctionIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_LightFunctionIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_LightFunctionIntensity) = value;
			}
		}

		// Token: 0x1700641B RID: 25627
		// (get) Token: 0x0601929F RID: 103071 RVA: 0x0025332A File Offset: 0x0025152A
		// (set) Token: 0x060192A0 RID: 103072 RVA: 0x0025333E File Offset: 0x0025153E
		public unsafe FVector4 LightFunctionMapUVScaleBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_LightFunctionMapUVScaleBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_LightFunctionMapUVScaleBias) = value;
			}
		}

		// Token: 0x1700641C RID: 25628
		// (get) Token: 0x060192A1 RID: 103073 RVA: 0x00253353 File Offset: 0x00251553
		// (set) Token: 0x060192A2 RID: 103074 RVA: 0x00253363 File Offset: 0x00251563
		public unsafe float LightFunctionSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_LightFunctionSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_LightFunctionSpeed) = value;
			}
		}

		// Token: 0x1700641D RID: 25629
		// (get) Token: 0x060192A3 RID: 103075 RVA: 0x00253374 File Offset: 0x00251574
		// (set) Token: 0x060192A4 RID: 103076 RVA: 0x00253384 File Offset: 0x00251584
		public unsafe float LightFunctionAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_LightFunctionAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_LightFunctionAngle) = value;
			}
		}

		// Token: 0x1700641E RID: 25630
		// (get) Token: 0x060192A5 RID: 103077 RVA: 0x00253395 File Offset: 0x00251595
		// (set) Token: 0x060192A6 RID: 103078 RVA: 0x002533A9 File Offset: 0x002515A9
		public unsafe UTexture2D LightFunctionTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + FGIMiscSetting.__PropertyOffset_LightFunctionTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGIMiscSetting.__PropertyOffset_LightFunctionTexture, value);
			}
		}

		// Token: 0x1700641F RID: 25631
		// (get) Token: 0x060192A7 RID: 103079 RVA: 0x002533BE File Offset: 0x002515BE
		// (set) Token: 0x060192A8 RID: 103080 RVA: 0x002533D2 File Offset: 0x002515D2
		public unsafe UTexture2D LightFunctionPerShadowTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + FGIMiscSetting.__PropertyOffset_LightFunctionPerShadowTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGIMiscSetting.__PropertyOffset_LightFunctionPerShadowTexture, value);
			}
		}

		// Token: 0x17006420 RID: 25632
		// (get) Token: 0x060192A9 RID: 103081 RVA: 0x002533E7 File Offset: 0x002515E7
		// (set) Token: 0x060192AA RID: 103082 RVA: 0x002533FB File Offset: 0x002515FB
		[Nullable(0)]
		public unsafe TEnumAsByte<EKuroDynamicCloudType> KuroDynamicCloudType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_KuroDynamicCloudType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_KuroDynamicCloudType) = value;
			}
		}

		// Token: 0x17006421 RID: 25633
		// (get) Token: 0x060192AB RID: 103083 RVA: 0x00253410 File Offset: 0x00251610
		// (set) Token: 0x060192AC RID: 103084 RVA: 0x00253420 File Offset: 0x00251620
		public unsafe float SequenceCloudTimeControl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_SequenceCloudTimeControl);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_SequenceCloudTimeControl) = value;
			}
		}

		// Token: 0x17006422 RID: 25634
		// (get) Token: 0x060192AD RID: 103085 RVA: 0x00253431 File Offset: 0x00251631
		// (set) Token: 0x060192AE RID: 103086 RVA: 0x00253441 File Offset: 0x00251641
		public unsafe float SequenceCloudTimeOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_SequenceCloudTimeOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_SequenceCloudTimeOffset) = value;
			}
		}

		// Token: 0x17006423 RID: 25635
		// (get) Token: 0x060192AF RID: 103087 RVA: 0x00253452 File Offset: 0x00251652
		// (set) Token: 0x060192B0 RID: 103088 RVA: 0x00253462 File Offset: 0x00251662
		public unsafe bool bOverrideCloudRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverrideCloudRotation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverrideCloudRotation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006424 RID: 25636
		// (get) Token: 0x060192B1 RID: 103089 RVA: 0x00253473 File Offset: 0x00251673
		// (set) Token: 0x060192B2 RID: 103090 RVA: 0x00253483 File Offset: 0x00251683
		public unsafe bool bInstantSwitchDynamicCloud
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bInstantSwitchDynamicCloud) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bInstantSwitchDynamicCloud) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006425 RID: 25637
		// (get) Token: 0x060192B3 RID: 103091 RVA: 0x00253494 File Offset: 0x00251694
		// (set) Token: 0x060192B4 RID: 103092 RVA: 0x002534A4 File Offset: 0x002516A4
		public unsafe float SequenceGlobalTimeControl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_SequenceGlobalTimeControl);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_SequenceGlobalTimeControl) = value;
			}
		}

		// Token: 0x17006426 RID: 25638
		// (get) Token: 0x060192B5 RID: 103093 RVA: 0x002534B5 File Offset: 0x002516B5
		// (set) Token: 0x060192B6 RID: 103094 RVA: 0x002534C9 File Offset: 0x002516C9
		public unsafe UTextureCube MaterialDynamicReflectionTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureCube>(base.NativePtr / (IntPtr)sizeof(void*) + FGIMiscSetting.__PropertyOffset_MaterialDynamicReflectionTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGIMiscSetting.__PropertyOffset_MaterialDynamicReflectionTexture, value);
			}
		}

		// Token: 0x17006427 RID: 25639
		// (get) Token: 0x060192B7 RID: 103095 RVA: 0x002534DE File Offset: 0x002516DE
		// (set) Token: 0x060192B8 RID: 103096 RVA: 0x002534F7 File Offset: 0x002516F7
		public unsafe bool bEnableGlobalGIQualityLow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bEnableGlobalGIQualityLow) & FGIMiscSetting.__PropertyMask_bEnableGlobalGIQualityLow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bEnableGlobalGIQualityLow) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bEnableGlobalGIQualityLow) & ~FGIMiscSetting.__PropertyMask_bEnableGlobalGIQualityLow) | (value ? FGIMiscSetting.__PropertyMask_bEnableGlobalGIQualityLow : 0));
			}
		}

		// Token: 0x17006428 RID: 25640
		// (get) Token: 0x060192B9 RID: 103097 RVA: 0x00253527 File Offset: 0x00251727
		// (set) Token: 0x060192BA RID: 103098 RVA: 0x00253537 File Offset: 0x00251737
		public unsafe float FogVisibilityCulling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_FogVisibilityCulling);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_FogVisibilityCulling) = value;
			}
		}

		// Token: 0x17006429 RID: 25641
		// (get) Token: 0x060192BB RID: 103099 RVA: 0x00253548 File Offset: 0x00251748
		// (set) Token: 0x060192BC RID: 103100 RVA: 0x00253561 File Offset: 0x00251761
		public unsafe bool bOverride_PauseEffects
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_PauseEffects) & FGIMiscSetting.__PropertyMask_bOverride_PauseEffects) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_PauseEffects) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_PauseEffects) & ~FGIMiscSetting.__PropertyMask_bOverride_PauseEffects) | (value ? FGIMiscSetting.__PropertyMask_bOverride_PauseEffects : 0));
			}
		}

		// Token: 0x1700642A RID: 25642
		// (get) Token: 0x060192BD RID: 103101 RVA: 0x00253591 File Offset: 0x00251791
		// (set) Token: 0x060192BE RID: 103102 RVA: 0x002535A1 File Offset: 0x002517A1
		public unsafe bool bPauseEffects
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bPauseEffects) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bPauseEffects) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700642B RID: 25643
		// (get) Token: 0x060192BF RID: 103103 RVA: 0x002535B2 File Offset: 0x002517B2
		// (set) Token: 0x060192C0 RID: 103104 RVA: 0x002535CB File Offset: 0x002517CB
		public unsafe bool bOverride_BurstDissolveTexture
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_BurstDissolveTexture) & FGIMiscSetting.__PropertyMask_bOverride_BurstDissolveTexture) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_BurstDissolveTexture) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_BurstDissolveTexture) & ~FGIMiscSetting.__PropertyMask_bOverride_BurstDissolveTexture) | (value ? FGIMiscSetting.__PropertyMask_bOverride_BurstDissolveTexture : 0));
			}
		}

		// Token: 0x1700642C RID: 25644
		// (get) Token: 0x060192C1 RID: 103105 RVA: 0x002535FB File Offset: 0x002517FB
		// (set) Token: 0x060192C2 RID: 103106 RVA: 0x0025360F File Offset: 0x0025180F
		public unsafe UTexture2D BurstDissolveTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + FGIMiscSetting.__PropertyOffset_BurstDissolveTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGIMiscSetting.__PropertyOffset_BurstDissolveTexture, value);
			}
		}

		// Token: 0x1700642D RID: 25645
		// (get) Token: 0x060192C3 RID: 103107 RVA: 0x00253624 File Offset: 0x00251824
		// (set) Token: 0x060192C4 RID: 103108 RVA: 0x0025363D File Offset: 0x0025183D
		public unsafe bool bOverride_BurstDissolveThreshold
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_BurstDissolveThreshold) & FGIMiscSetting.__PropertyMask_bOverride_BurstDissolveThreshold) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_BurstDissolveThreshold) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_BurstDissolveThreshold) & ~FGIMiscSetting.__PropertyMask_bOverride_BurstDissolveThreshold) | (value ? FGIMiscSetting.__PropertyMask_bOverride_BurstDissolveThreshold : 0));
			}
		}

		// Token: 0x1700642E RID: 25646
		// (get) Token: 0x060192C5 RID: 103109 RVA: 0x0025366D File Offset: 0x0025186D
		// (set) Token: 0x060192C6 RID: 103110 RVA: 0x0025367D File Offset: 0x0025187D
		public unsafe float BurstDissolveThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_BurstDissolveThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_BurstDissolveThreshold) = value;
			}
		}

		// Token: 0x1700642F RID: 25647
		// (get) Token: 0x060192C7 RID: 103111 RVA: 0x0025368E File Offset: 0x0025188E
		// (set) Token: 0x060192C8 RID: 103112 RVA: 0x002536A7 File Offset: 0x002518A7
		public unsafe bool bOverride_BurstDissolveSmooth
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_BurstDissolveSmooth) & FGIMiscSetting.__PropertyMask_bOverride_BurstDissolveSmooth) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_BurstDissolveSmooth) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_BurstDissolveSmooth) & ~FGIMiscSetting.__PropertyMask_bOverride_BurstDissolveSmooth) | (value ? FGIMiscSetting.__PropertyMask_bOverride_BurstDissolveSmooth : 0));
			}
		}

		// Token: 0x17006430 RID: 25648
		// (get) Token: 0x060192C9 RID: 103113 RVA: 0x002536D7 File Offset: 0x002518D7
		// (set) Token: 0x060192CA RID: 103114 RVA: 0x002536E7 File Offset: 0x002518E7
		public unsafe float BurstDissolveSmooth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_BurstDissolveSmooth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_BurstDissolveSmooth) = value;
			}
		}

		// Token: 0x17006431 RID: 25649
		// (get) Token: 0x060192CB RID: 103115 RVA: 0x002536F8 File Offset: 0x002518F8
		// (set) Token: 0x060192CC RID: 103116 RVA: 0x00253711 File Offset: 0x00251911
		public unsafe bool bOverride_BurstClipThreshold
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_BurstClipThreshold) & FGIMiscSetting.__PropertyMask_bOverride_BurstClipThreshold) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_BurstClipThreshold) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_BurstClipThreshold) & ~FGIMiscSetting.__PropertyMask_bOverride_BurstClipThreshold) | (value ? FGIMiscSetting.__PropertyMask_bOverride_BurstClipThreshold : 0));
			}
		}

		// Token: 0x17006432 RID: 25650
		// (get) Token: 0x060192CD RID: 103117 RVA: 0x00253741 File Offset: 0x00251941
		// (set) Token: 0x060192CE RID: 103118 RVA: 0x00253751 File Offset: 0x00251951
		public unsafe float BurstClipThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_BurstClipThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_BurstClipThreshold) = value;
			}
		}

		// Token: 0x17006433 RID: 25651
		// (get) Token: 0x060192CF RID: 103119 RVA: 0x00253762 File Offset: 0x00251962
		// (set) Token: 0x060192D0 RID: 103120 RVA: 0x0025377B File Offset: 0x0025197B
		public unsafe bool bOverride_ForbidWeatherWhenTakeOver
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_ForbidWeatherWhenTakeOver) & FGIMiscSetting.__PropertyMask_bOverride_ForbidWeatherWhenTakeOver) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_ForbidWeatherWhenTakeOver) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_ForbidWeatherWhenTakeOver) & ~FGIMiscSetting.__PropertyMask_bOverride_ForbidWeatherWhenTakeOver) | (value ? FGIMiscSetting.__PropertyMask_bOverride_ForbidWeatherWhenTakeOver : 0));
			}
		}

		// Token: 0x17006434 RID: 25652
		// (get) Token: 0x060192D1 RID: 103121 RVA: 0x002537AB File Offset: 0x002519AB
		// (set) Token: 0x060192D2 RID: 103122 RVA: 0x002537BB File Offset: 0x002519BB
		public unsafe bool ForbidWeatherWhenTakeOver
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_ForbidWeatherWhenTakeOver) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_ForbidWeatherWhenTakeOver) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006435 RID: 25653
		// (get) Token: 0x060192D3 RID: 103123 RVA: 0x002537CC File Offset: 0x002519CC
		// (set) Token: 0x060192D4 RID: 103124 RVA: 0x002537E5 File Offset: 0x002519E5
		public unsafe bool bOverride_GlobalFootstepMaterial
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_GlobalFootstepMaterial) & FGIMiscSetting.__PropertyMask_bOverride_GlobalFootstepMaterial) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_GlobalFootstepMaterial) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_GlobalFootstepMaterial) & ~FGIMiscSetting.__PropertyMask_bOverride_GlobalFootstepMaterial) | (value ? FGIMiscSetting.__PropertyMask_bOverride_GlobalFootstepMaterial : 0));
			}
		}

		// Token: 0x17006436 RID: 25654
		// (get) Token: 0x060192D5 RID: 103125 RVA: 0x00253815 File Offset: 0x00251A15
		// (set) Token: 0x060192D6 RID: 103126 RVA: 0x00253829 File Offset: 0x00251A29
		public unsafe UPhysicalMaterial GlobalFootstepMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicalMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + FGIMiscSetting.__PropertyOffset_GlobalFootstepMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGIMiscSetting.__PropertyOffset_GlobalFootstepMaterial, value);
			}
		}

		// Token: 0x17006437 RID: 25655
		// (get) Token: 0x060192D7 RID: 103127 RVA: 0x0025383E File Offset: 0x00251A3E
		// (set) Token: 0x060192D8 RID: 103128 RVA: 0x00253857 File Offset: 0x00251A57
		public unsafe bool bOverride_WaveUsePolarPattern
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveUsePolarPattern) & FGIMiscSetting.__PropertyMask_bOverride_WaveUsePolarPattern) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveUsePolarPattern) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveUsePolarPattern) & ~FGIMiscSetting.__PropertyMask_bOverride_WaveUsePolarPattern) | (value ? FGIMiscSetting.__PropertyMask_bOverride_WaveUsePolarPattern : 0));
			}
		}

		// Token: 0x17006438 RID: 25656
		// (get) Token: 0x060192D9 RID: 103129 RVA: 0x00253887 File Offset: 0x00251A87
		// (set) Token: 0x060192DA RID: 103130 RVA: 0x00253897 File Offset: 0x00251A97
		public unsafe bool WaveUsePolarPattern
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_WaveUsePolarPattern) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_WaveUsePolarPattern) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006439 RID: 25657
		// (get) Token: 0x060192DB RID: 103131 RVA: 0x002538A8 File Offset: 0x00251AA8
		// (set) Token: 0x060192DC RID: 103132 RVA: 0x002538C1 File Offset: 0x00251AC1
		public unsafe bool bOverride_WavePatternTexture
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WavePatternTexture) & FGIMiscSetting.__PropertyMask_bOverride_WavePatternTexture) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WavePatternTexture) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WavePatternTexture) & ~FGIMiscSetting.__PropertyMask_bOverride_WavePatternTexture) | (value ? FGIMiscSetting.__PropertyMask_bOverride_WavePatternTexture : 0));
			}
		}

		// Token: 0x1700643A RID: 25658
		// (get) Token: 0x060192DD RID: 103133 RVA: 0x002538F1 File Offset: 0x00251AF1
		// (set) Token: 0x060192DE RID: 103134 RVA: 0x00253905 File Offset: 0x00251B05
		public unsafe UTexture2D WavePatternTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + FGIMiscSetting.__PropertyOffset_WavePatternTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGIMiscSetting.__PropertyOffset_WavePatternTexture, value);
			}
		}

		// Token: 0x1700643B RID: 25659
		// (get) Token: 0x060192DF RID: 103135 RVA: 0x0025391A File Offset: 0x00251B1A
		// (set) Token: 0x060192E0 RID: 103136 RVA: 0x00253933 File Offset: 0x00251B33
		public unsafe bool bOverride_WavePatternScaleBias
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WavePatternScaleBias) & FGIMiscSetting.__PropertyMask_bOverride_WavePatternScaleBias) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WavePatternScaleBias) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WavePatternScaleBias) & ~FGIMiscSetting.__PropertyMask_bOverride_WavePatternScaleBias) | (value ? FGIMiscSetting.__PropertyMask_bOverride_WavePatternScaleBias : 0));
			}
		}

		// Token: 0x1700643C RID: 25660
		// (get) Token: 0x060192E1 RID: 103137 RVA: 0x00253963 File Offset: 0x00251B63
		// (set) Token: 0x060192E2 RID: 103138 RVA: 0x00253977 File Offset: 0x00251B77
		public unsafe FVector4 WavePatternScaleBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_WavePatternScaleBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_WavePatternScaleBias) = value;
			}
		}

		// Token: 0x1700643D RID: 25661
		// (get) Token: 0x060192E3 RID: 103139 RVA: 0x0025398C File Offset: 0x00251B8C
		// (set) Token: 0x060192E4 RID: 103140 RVA: 0x002539A5 File Offset: 0x00251BA5
		public unsafe bool bOverride_WaveCenter
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveCenter) & FGIMiscSetting.__PropertyMask_bOverride_WaveCenter) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveCenter) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveCenter) & ~FGIMiscSetting.__PropertyMask_bOverride_WaveCenter) | (value ? FGIMiscSetting.__PropertyMask_bOverride_WaveCenter : 0));
			}
		}

		// Token: 0x1700643E RID: 25662
		// (get) Token: 0x060192E5 RID: 103141 RVA: 0x002539D5 File Offset: 0x00251BD5
		// (set) Token: 0x060192E6 RID: 103142 RVA: 0x002539E9 File Offset: 0x00251BE9
		public unsafe FVector WaveCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_WaveCenter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_WaveCenter) = value;
			}
		}

		// Token: 0x1700643F RID: 25663
		// (get) Token: 0x060192E7 RID: 103143 RVA: 0x002539FE File Offset: 0x00251BFE
		// (set) Token: 0x060192E8 RID: 103144 RVA: 0x00253A17 File Offset: 0x00251C17
		public unsafe bool bOverride_WaveFront
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveFront) & FGIMiscSetting.__PropertyMask_bOverride_WaveFront) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveFront) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveFront) & ~FGIMiscSetting.__PropertyMask_bOverride_WaveFront) | (value ? FGIMiscSetting.__PropertyMask_bOverride_WaveFront : 0));
			}
		}

		// Token: 0x17006440 RID: 25664
		// (get) Token: 0x060192E9 RID: 103145 RVA: 0x00253A47 File Offset: 0x00251C47
		// (set) Token: 0x060192EA RID: 103146 RVA: 0x00253A5B File Offset: 0x00251C5B
		public unsafe FVector2D WaveFront
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_WaveFront);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_WaveFront) = value;
			}
		}

		// Token: 0x17006441 RID: 25665
		// (get) Token: 0x060192EB RID: 103147 RVA: 0x00253A70 File Offset: 0x00251C70
		// (set) Token: 0x060192EC RID: 103148 RVA: 0x00253A89 File Offset: 0x00251C89
		public unsafe bool bOverride_WaveRadius
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveRadius) & FGIMiscSetting.__PropertyMask_bOverride_WaveRadius) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveRadius) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveRadius) & ~FGIMiscSetting.__PropertyMask_bOverride_WaveRadius) | (value ? FGIMiscSetting.__PropertyMask_bOverride_WaveRadius : 0));
			}
		}

		// Token: 0x17006442 RID: 25666
		// (get) Token: 0x060192ED RID: 103149 RVA: 0x00253AB9 File Offset: 0x00251CB9
		// (set) Token: 0x060192EE RID: 103150 RVA: 0x00253AC9 File Offset: 0x00251CC9
		public unsafe float WaveRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_WaveRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_WaveRadius) = value;
			}
		}

		// Token: 0x17006443 RID: 25667
		// (get) Token: 0x060192EF RID: 103151 RVA: 0x00253ADA File Offset: 0x00251CDA
		// (set) Token: 0x060192F0 RID: 103152 RVA: 0x00253AF3 File Offset: 0x00251CF3
		public unsafe bool bOverride_WaveRadiusSmooth
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveRadiusSmooth) & FGIMiscSetting.__PropertyMask_bOverride_WaveRadiusSmooth) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveRadiusSmooth) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveRadiusSmooth) & ~FGIMiscSetting.__PropertyMask_bOverride_WaveRadiusSmooth) | (value ? FGIMiscSetting.__PropertyMask_bOverride_WaveRadiusSmooth : 0));
			}
		}

		// Token: 0x17006444 RID: 25668
		// (get) Token: 0x060192F1 RID: 103153 RVA: 0x00253B23 File Offset: 0x00251D23
		// (set) Token: 0x060192F2 RID: 103154 RVA: 0x00253B33 File Offset: 0x00251D33
		public unsafe float WaveRadiusSmooth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_WaveRadiusSmooth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_WaveRadiusSmooth) = value;
			}
		}

		// Token: 0x17006445 RID: 25669
		// (get) Token: 0x060192F3 RID: 103155 RVA: 0x00253B44 File Offset: 0x00251D44
		// (set) Token: 0x060192F4 RID: 103156 RVA: 0x00253B5D File Offset: 0x00251D5D
		public unsafe bool bOverride_WaveHeight
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveHeight) & FGIMiscSetting.__PropertyMask_bOverride_WaveHeight) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveHeight) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveHeight) & ~FGIMiscSetting.__PropertyMask_bOverride_WaveHeight) | (value ? FGIMiscSetting.__PropertyMask_bOverride_WaveHeight : 0));
			}
		}

		// Token: 0x17006446 RID: 25670
		// (get) Token: 0x060192F5 RID: 103157 RVA: 0x00253B8D File Offset: 0x00251D8D
		// (set) Token: 0x060192F6 RID: 103158 RVA: 0x00253B9D File Offset: 0x00251D9D
		public unsafe float WaveHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_WaveHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_WaveHeight) = value;
			}
		}

		// Token: 0x17006447 RID: 25671
		// (get) Token: 0x060192F7 RID: 103159 RVA: 0x00253BAE File Offset: 0x00251DAE
		// (set) Token: 0x060192F8 RID: 103160 RVA: 0x00253BC7 File Offset: 0x00251DC7
		public unsafe bool bOverride_WaveHeightSmooth
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveHeightSmooth) & FGIMiscSetting.__PropertyMask_bOverride_WaveHeightSmooth) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveHeightSmooth) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveHeightSmooth) & ~FGIMiscSetting.__PropertyMask_bOverride_WaveHeightSmooth) | (value ? FGIMiscSetting.__PropertyMask_bOverride_WaveHeightSmooth : 0));
			}
		}

		// Token: 0x17006448 RID: 25672
		// (get) Token: 0x060192F9 RID: 103161 RVA: 0x00253BF7 File Offset: 0x00251DF7
		// (set) Token: 0x060192FA RID: 103162 RVA: 0x00253C07 File Offset: 0x00251E07
		public unsafe float WaveHeightSmooth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_WaveHeightSmooth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_WaveHeightSmooth) = value;
			}
		}

		// Token: 0x17006449 RID: 25673
		// (get) Token: 0x060192FB RID: 103163 RVA: 0x00253C18 File Offset: 0x00251E18
		// (set) Token: 0x060192FC RID: 103164 RVA: 0x00253C31 File Offset: 0x00251E31
		public unsafe bool bOverride_WaveNormalSize
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveNormalSize) & FGIMiscSetting.__PropertyMask_bOverride_WaveNormalSize) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveNormalSize) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveNormalSize) & ~FGIMiscSetting.__PropertyMask_bOverride_WaveNormalSize) | (value ? FGIMiscSetting.__PropertyMask_bOverride_WaveNormalSize : 0));
			}
		}

		// Token: 0x1700644A RID: 25674
		// (get) Token: 0x060192FD RID: 103165 RVA: 0x00253C61 File Offset: 0x00251E61
		// (set) Token: 0x060192FE RID: 103166 RVA: 0x00253C71 File Offset: 0x00251E71
		public unsafe float WaveNormalSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_WaveNormalSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_WaveNormalSize) = value;
			}
		}

		// Token: 0x1700644B RID: 25675
		// (get) Token: 0x060192FF RID: 103167 RVA: 0x00253C82 File Offset: 0x00251E82
		// (set) Token: 0x06019300 RID: 103168 RVA: 0x00253C9B File Offset: 0x00251E9B
		public unsafe bool bOverride_WaveRoughness
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveRoughness) & FGIMiscSetting.__PropertyMask_bOverride_WaveRoughness) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveRoughness) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveRoughness) & ~FGIMiscSetting.__PropertyMask_bOverride_WaveRoughness) | (value ? FGIMiscSetting.__PropertyMask_bOverride_WaveRoughness : 0));
			}
		}

		// Token: 0x1700644C RID: 25676
		// (get) Token: 0x06019301 RID: 103169 RVA: 0x00253CCB File Offset: 0x00251ECB
		// (set) Token: 0x06019302 RID: 103170 RVA: 0x00253CDB File Offset: 0x00251EDB
		public unsafe float WaveRoughness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_WaveRoughness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_WaveRoughness) = value;
			}
		}

		// Token: 0x1700644D RID: 25677
		// (get) Token: 0x06019303 RID: 103171 RVA: 0x00253CEC File Offset: 0x00251EEC
		// (set) Token: 0x06019304 RID: 103172 RVA: 0x00253D05 File Offset: 0x00251F05
		public unsafe bool bOverride_WaveDissolveTexture
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveDissolveTexture) & FGIMiscSetting.__PropertyMask_bOverride_WaveDissolveTexture) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveDissolveTexture) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveDissolveTexture) & ~FGIMiscSetting.__PropertyMask_bOverride_WaveDissolveTexture) | (value ? FGIMiscSetting.__PropertyMask_bOverride_WaveDissolveTexture : 0));
			}
		}

		// Token: 0x1700644E RID: 25678
		// (get) Token: 0x06019305 RID: 103173 RVA: 0x00253D35 File Offset: 0x00251F35
		// (set) Token: 0x06019306 RID: 103174 RVA: 0x00253D49 File Offset: 0x00251F49
		public unsafe UTexture2D WaveDissolveTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + FGIMiscSetting.__PropertyOffset_WaveDissolveTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGIMiscSetting.__PropertyOffset_WaveDissolveTexture, value);
			}
		}

		// Token: 0x1700644F RID: 25679
		// (get) Token: 0x06019307 RID: 103175 RVA: 0x00253D5E File Offset: 0x00251F5E
		// (set) Token: 0x06019308 RID: 103176 RVA: 0x00253D77 File Offset: 0x00251F77
		public unsafe bool bOverride_WaveDissolveScaleBias
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveDissolveScaleBias) & FGIMiscSetting.__PropertyMask_bOverride_WaveDissolveScaleBias) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveDissolveScaleBias) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveDissolveScaleBias) & ~FGIMiscSetting.__PropertyMask_bOverride_WaveDissolveScaleBias) | (value ? FGIMiscSetting.__PropertyMask_bOverride_WaveDissolveScaleBias : 0));
			}
		}

		// Token: 0x17006450 RID: 25680
		// (get) Token: 0x06019309 RID: 103177 RVA: 0x00253DA7 File Offset: 0x00251FA7
		// (set) Token: 0x0601930A RID: 103178 RVA: 0x00253DBB File Offset: 0x00251FBB
		public unsafe FVector4 WaveDissolveScaleBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_WaveDissolveScaleBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_WaveDissolveScaleBias) = value;
			}
		}

		// Token: 0x17006451 RID: 25681
		// (get) Token: 0x0601930B RID: 103179 RVA: 0x00253DD0 File Offset: 0x00251FD0
		// (set) Token: 0x0601930C RID: 103180 RVA: 0x00253DE9 File Offset: 0x00251FE9
		public unsafe bool bOverride_WaveDissolveProgress
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveDissolveProgress) & FGIMiscSetting.__PropertyMask_bOverride_WaveDissolveProgress) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveDissolveProgress) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveDissolveProgress) & ~FGIMiscSetting.__PropertyMask_bOverride_WaveDissolveProgress) | (value ? FGIMiscSetting.__PropertyMask_bOverride_WaveDissolveProgress : 0));
			}
		}

		// Token: 0x17006452 RID: 25682
		// (get) Token: 0x0601930D RID: 103181 RVA: 0x00253E19 File Offset: 0x00252019
		// (set) Token: 0x0601930E RID: 103182 RVA: 0x00253E29 File Offset: 0x00252029
		public unsafe float WaveDissolveProgress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_WaveDissolveProgress);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_WaveDissolveProgress) = value;
			}
		}

		// Token: 0x17006453 RID: 25683
		// (get) Token: 0x0601930F RID: 103183 RVA: 0x00253E3A File Offset: 0x0025203A
		// (set) Token: 0x06019310 RID: 103184 RVA: 0x00253E53 File Offset: 0x00252053
		public unsafe bool bOverride_WaveDissolveSmooth
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveDissolveSmooth) & FGIMiscSetting.__PropertyMask_bOverride_WaveDissolveSmooth) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveDissolveSmooth) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveDissolveSmooth) & ~FGIMiscSetting.__PropertyMask_bOverride_WaveDissolveSmooth) | (value ? FGIMiscSetting.__PropertyMask_bOverride_WaveDissolveSmooth : 0));
			}
		}

		// Token: 0x17006454 RID: 25684
		// (get) Token: 0x06019311 RID: 103185 RVA: 0x00253E83 File Offset: 0x00252083
		// (set) Token: 0x06019312 RID: 103186 RVA: 0x00253E93 File Offset: 0x00252093
		public unsafe float WaveDissolveSmooth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_WaveDissolveSmooth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_WaveDissolveSmooth) = value;
			}
		}

		// Token: 0x17006455 RID: 25685
		// (get) Token: 0x06019313 RID: 103187 RVA: 0x00253EA4 File Offset: 0x002520A4
		// (set) Token: 0x06019314 RID: 103188 RVA: 0x00253EBD File Offset: 0x002520BD
		public unsafe bool bOverride_WaveColorTexture
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveColorTexture) & FGIMiscSetting.__PropertyMask_bOverride_WaveColorTexture) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveColorTexture) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveColorTexture) & ~FGIMiscSetting.__PropertyMask_bOverride_WaveColorTexture) | (value ? FGIMiscSetting.__PropertyMask_bOverride_WaveColorTexture : 0));
			}
		}

		// Token: 0x17006456 RID: 25686
		// (get) Token: 0x06019315 RID: 103189 RVA: 0x00253EED File Offset: 0x002520ED
		// (set) Token: 0x06019316 RID: 103190 RVA: 0x00253F01 File Offset: 0x00252101
		public unsafe UTexture2D WaveColorTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + FGIMiscSetting.__PropertyOffset_WaveColorTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGIMiscSetting.__PropertyOffset_WaveColorTexture, value);
			}
		}

		// Token: 0x17006457 RID: 25687
		// (get) Token: 0x06019317 RID: 103191 RVA: 0x00253F16 File Offset: 0x00252116
		// (set) Token: 0x06019318 RID: 103192 RVA: 0x00253F2F File Offset: 0x0025212F
		public unsafe bool bOverride_WaveColorScaleBias
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveColorScaleBias) & FGIMiscSetting.__PropertyMask_bOverride_WaveColorScaleBias) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveColorScaleBias) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveColorScaleBias) & ~FGIMiscSetting.__PropertyMask_bOverride_WaveColorScaleBias) | (value ? FGIMiscSetting.__PropertyMask_bOverride_WaveColorScaleBias : 0));
			}
		}

		// Token: 0x17006458 RID: 25688
		// (get) Token: 0x06019319 RID: 103193 RVA: 0x00253F5F File Offset: 0x0025215F
		// (set) Token: 0x0601931A RID: 103194 RVA: 0x00253F73 File Offset: 0x00252173
		public unsafe FVector4 WaveColorScaleBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_WaveColorScaleBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_WaveColorScaleBias) = value;
			}
		}

		// Token: 0x17006459 RID: 25689
		// (get) Token: 0x0601931B RID: 103195 RVA: 0x00253F88 File Offset: 0x00252188
		// (set) Token: 0x0601931C RID: 103196 RVA: 0x00253FA1 File Offset: 0x002521A1
		public unsafe bool bOverride_WaveColorTextureTint
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveColorTextureTint) & FGIMiscSetting.__PropertyMask_bOverride_WaveColorTextureTint) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveColorTextureTint) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveColorTextureTint) & ~FGIMiscSetting.__PropertyMask_bOverride_WaveColorTextureTint) | (value ? FGIMiscSetting.__PropertyMask_bOverride_WaveColorTextureTint : 0));
			}
		}

		// Token: 0x1700645A RID: 25690
		// (get) Token: 0x0601931D RID: 103197 RVA: 0x00253FD1 File Offset: 0x002521D1
		// (set) Token: 0x0601931E RID: 103198 RVA: 0x00253FE5 File Offset: 0x002521E5
		public unsafe FLinearColor WaveColorTextureTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_WaveColorTextureTint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_WaveColorTextureTint) = value;
			}
		}

		// Token: 0x1700645B RID: 25691
		// (get) Token: 0x0601931F RID: 103199 RVA: 0x00253FFA File Offset: 0x002521FA
		// (set) Token: 0x06019320 RID: 103200 RVA: 0x00254013 File Offset: 0x00252213
		public unsafe bool bOverride_WaveWiggleAmplitude
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveWiggleAmplitude) & FGIMiscSetting.__PropertyMask_bOverride_WaveWiggleAmplitude) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveWiggleAmplitude) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveWiggleAmplitude) & ~FGIMiscSetting.__PropertyMask_bOverride_WaveWiggleAmplitude) | (value ? FGIMiscSetting.__PropertyMask_bOverride_WaveWiggleAmplitude : 0));
			}
		}

		// Token: 0x1700645C RID: 25692
		// (get) Token: 0x06019321 RID: 103201 RVA: 0x00254043 File Offset: 0x00252243
		// (set) Token: 0x06019322 RID: 103202 RVA: 0x00254053 File Offset: 0x00252253
		public unsafe float WaveWiggleAmplitude
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_WaveWiggleAmplitude);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_WaveWiggleAmplitude) = value;
			}
		}

		// Token: 0x1700645D RID: 25693
		// (get) Token: 0x06019323 RID: 103203 RVA: 0x00254064 File Offset: 0x00252264
		// (set) Token: 0x06019324 RID: 103204 RVA: 0x0025407D File Offset: 0x0025227D
		public unsafe bool bOverride_WaveColorTint
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveColorTint) & FGIMiscSetting.__PropertyMask_bOverride_WaveColorTint) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveColorTint) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveColorTint) & ~FGIMiscSetting.__PropertyMask_bOverride_WaveColorTint) | (value ? FGIMiscSetting.__PropertyMask_bOverride_WaveColorTint : 0));
			}
		}

		// Token: 0x1700645E RID: 25694
		// (get) Token: 0x06019325 RID: 103205 RVA: 0x002540AD File Offset: 0x002522AD
		// (set) Token: 0x06019326 RID: 103206 RVA: 0x002540C1 File Offset: 0x002522C1
		public unsafe FLinearColor WaveColorTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_WaveColorTint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_WaveColorTint) = value;
			}
		}

		// Token: 0x1700645F RID: 25695
		// (get) Token: 0x06019327 RID: 103207 RVA: 0x002540D6 File Offset: 0x002522D6
		// (set) Token: 0x06019328 RID: 103208 RVA: 0x002540EF File Offset: 0x002522EF
		public unsafe bool bOverride_WaveColorAdd
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveColorAdd) & FGIMiscSetting.__PropertyMask_bOverride_WaveColorAdd) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveColorAdd) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveColorAdd) & ~FGIMiscSetting.__PropertyMask_bOverride_WaveColorAdd) | (value ? FGIMiscSetting.__PropertyMask_bOverride_WaveColorAdd : 0));
			}
		}

		// Token: 0x17006460 RID: 25696
		// (get) Token: 0x06019329 RID: 103209 RVA: 0x0025411F File Offset: 0x0025231F
		// (set) Token: 0x0601932A RID: 103210 RVA: 0x00254133 File Offset: 0x00252333
		public unsafe FLinearColor WaveColorAdd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_WaveColorAdd);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_WaveColorAdd) = value;
			}
		}

		// Token: 0x17006461 RID: 25697
		// (get) Token: 0x0601932B RID: 103211 RVA: 0x00254148 File Offset: 0x00252348
		// (set) Token: 0x0601932C RID: 103212 RVA: 0x00254161 File Offset: 0x00252361
		public unsafe bool bOverride_WaveOverallDensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveOverallDensity) & FGIMiscSetting.__PropertyMask_bOverride_WaveOverallDensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveOverallDensity) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_WaveOverallDensity) & ~FGIMiscSetting.__PropertyMask_bOverride_WaveOverallDensity) | (value ? FGIMiscSetting.__PropertyMask_bOverride_WaveOverallDensity : 0));
			}
		}

		// Token: 0x17006462 RID: 25698
		// (get) Token: 0x0601932D RID: 103213 RVA: 0x00254191 File Offset: 0x00252391
		// (set) Token: 0x0601932E RID: 103214 RVA: 0x002541A1 File Offset: 0x002523A1
		public unsafe float WaveOverallDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_WaveOverallDensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_WaveOverallDensity) = value;
			}
		}

		// Token: 0x17006463 RID: 25699
		// (get) Token: 0x0601932F RID: 103215 RVA: 0x002541B2 File Offset: 0x002523B2
		// (set) Token: 0x06019330 RID: 103216 RVA: 0x002541CB File Offset: 0x002523CB
		public unsafe bool bOverride_OpenLightningFireBurnt
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_OpenLightningFireBurnt) & FGIMiscSetting.__PropertyMask_bOverride_OpenLightningFireBurnt) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_OpenLightningFireBurnt) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_OpenLightningFireBurnt) & ~FGIMiscSetting.__PropertyMask_bOverride_OpenLightningFireBurnt) | (value ? FGIMiscSetting.__PropertyMask_bOverride_OpenLightningFireBurnt : 0));
			}
		}

		// Token: 0x17006464 RID: 25700
		// (get) Token: 0x06019331 RID: 103217 RVA: 0x002541FB File Offset: 0x002523FB
		// (set) Token: 0x06019332 RID: 103218 RVA: 0x0025420B File Offset: 0x0025240B
		public unsafe bool OpenLightningFireBurnt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_OpenLightningFireBurnt) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_OpenLightningFireBurnt) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006465 RID: 25701
		// (get) Token: 0x06019333 RID: 103219 RVA: 0x0025421C File Offset: 0x0025241C
		// (set) Token: 0x06019334 RID: 103220 RVA: 0x00254235 File Offset: 0x00252435
		public unsafe bool bOverride_LightningFireProbability
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_LightningFireProbability) & FGIMiscSetting.__PropertyMask_bOverride_LightningFireProbability) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_LightningFireProbability) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_LightningFireProbability) & ~FGIMiscSetting.__PropertyMask_bOverride_LightningFireProbability) | (value ? FGIMiscSetting.__PropertyMask_bOverride_LightningFireProbability : 0));
			}
		}

		// Token: 0x17006466 RID: 25702
		// (get) Token: 0x06019335 RID: 103221 RVA: 0x00254265 File Offset: 0x00252465
		// (set) Token: 0x06019336 RID: 103222 RVA: 0x00254275 File Offset: 0x00252475
		public unsafe float LightningFireProbability
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_LightningFireProbability);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_LightningFireProbability) = value;
			}
		}

		// Token: 0x17006467 RID: 25703
		// (get) Token: 0x06019337 RID: 103223 RVA: 0x00254286 File Offset: 0x00252486
		// (set) Token: 0x06019338 RID: 103224 RVA: 0x0025429F File Offset: 0x0025249F
		public unsafe bool bOverride_OpenDynamicWaterFlow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_OpenDynamicWaterFlow) & FGIMiscSetting.__PropertyMask_bOverride_OpenDynamicWaterFlow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_OpenDynamicWaterFlow) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_OpenDynamicWaterFlow) & ~FGIMiscSetting.__PropertyMask_bOverride_OpenDynamicWaterFlow) | (value ? FGIMiscSetting.__PropertyMask_bOverride_OpenDynamicWaterFlow : 0));
			}
		}

		// Token: 0x17006468 RID: 25704
		// (get) Token: 0x06019339 RID: 103225 RVA: 0x002542CF File Offset: 0x002524CF
		// (set) Token: 0x0601933A RID: 103226 RVA: 0x002542DF File Offset: 0x002524DF
		public unsafe bool OpenDynamicWaterFlow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_OpenDynamicWaterFlow) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_OpenDynamicWaterFlow) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006469 RID: 25705
		// (get) Token: 0x0601933B RID: 103227 RVA: 0x002542F0 File Offset: 0x002524F0
		// (set) Token: 0x0601933C RID: 103228 RVA: 0x00254309 File Offset: 0x00252509
		public unsafe bool bOverride_MeshBlendIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_MeshBlendIntensity) & FGIMiscSetting.__PropertyMask_bOverride_MeshBlendIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_MeshBlendIntensity) = ((*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_bOverride_MeshBlendIntensity) & ~FGIMiscSetting.__PropertyMask_bOverride_MeshBlendIntensity) | (value ? FGIMiscSetting.__PropertyMask_bOverride_MeshBlendIntensity : 0));
			}
		}

		// Token: 0x1700646A RID: 25706
		// (get) Token: 0x0601933D RID: 103229 RVA: 0x00254339 File Offset: 0x00252539
		// (set) Token: 0x0601933E RID: 103230 RVA: 0x00254349 File Offset: 0x00252549
		public unsafe float MeshBlendIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_MeshBlendIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGIMiscSetting.__PropertyOffset_MeshBlendIntensity) = value;
			}
		}

		// Token: 0x0601933F RID: 103231 RVA: 0x0025435A File Offset: 0x0025255A
		public FGIMiscSetting()
		{
		}

		// Token: 0x06019340 RID: 103232 RVA: 0x00254364 File Offset: 0x00252564
		[NullableContext(1)]
		public FGIMiscSetting(bool bOverride_ThunderType, bool bOverride_ThunderGenerateChanceScale, bool bOverride_ThunderAttackChance, bool bOverride_ThunderColor, bool bOverride_ThunderLightBrightness, bool bOverride_ThunderLightColor, bool bOverride_ThunderCloudBrightness, [Nullable(0)] TEnumAsByte<EKuroThunderType> ThunderType, float ThunderGenerateChanceScale, float ThunderAttackChance, FLinearColor ThunderColor, float ThunderLightBrightness, FLinearColor ThunderLightColor, float ThunderCloudBrightness, bool bOverride_RainType, bool bOverride_RainDensity, bool bOverride_RainRippleIntensity, bool bOverride_RainLerpTime, bool bOverride_RainLerpData, bool bOverride_RainHeightNoiseChannel, bool bOverride_RainFogDensity, bool bOverride_RainDensityChangeSpeed, bool bOverride_bRainAffactPointLight, [Nullable(0)] TEnumAsByte<EKuroRainType> RainType, float RainDensity, float RainRippleIntensity, float RainLerpTime, FVector4 RainLerpData, int RainHeightNoiseChannel, float RainFogDensity, float RainDensityChangeSpeed, bool bRainAffectPointLight, bool bOverride_SnowCoverIntensity, float SnowCoverIntensity, bool bOverride_FrozenProgress, bool bOverride_FrozenTime, bool bOverride_SnowSpecksNumber, bool bOverride_SnowSpecksStrength, float FrozenProgress, float FrozenTime, float SnowSpecksNumber, float SnowSpecksStrength, bool bOverride_RainWindSize, bool bOverride_RainGravity, bool bOverride_RainDrag, bool bOverride_RainTimeDilation, bool bOverride_RainTimeFreezeSpherize, bool bOverride_RainSphereMask, bool bOverride_RainSphereMaskOffset, bool bOverride_RainSphereMaskUseBone, float RainWindSizeOverride, FVector RainGravityOverride, float RainDragOverride, float RainTimeDilationOverride, bool bRainTimeFreezeSpherize, float RainToSphereTime, float RainToRainTime, float RainSphereMaskRadius, FVector RainSphereMaskOffset, bool bRainSphereMaskUseBone, FName RainSphereMaskBoneName, bool bOverride_RoughnessDensity, bool bOverride_MixRoughness, bool bOverride_MixRoughness_Mobile, bool bOverride_EffectGravity, bool bOverride_LightFunctionIntensity, bool bOverride_LightFunctionMapUVScaleBias, bool bOverride_LightFunctionSpeed, bool bOverride_LightFunctionAngle, bool bOverride_LightFunctionTexture, bool bOverride_LightFunctionPerShadowTexture, bool bOverride_KuroDynamicCloudType, bool bOverride_SequenceCloudTimeControl, bool bOverride_SequenceCloudTimeOffset, bool bOverride_OverrideCloudRotation, bool bOverride_InstantSwitchDynamicCloud, bool bOverride_SequenceGlobalTimeControl, bool bOverride_MaterialDynamicReflectionTexture, bool bOverride_FogVisibilityCulling, float RoughnessDensity, float MixRoughness, float MixRoughness_Mobile, float EffectGravity, float LightFunctionIntensity, FVector4 LightFunctionMapUVScaleBias, float LightFunctionSpeed, float LightFunctionAngle, UTexture2D LightFunctionTexture, UTexture2D LightFunctionPerShadowTexture, [Nullable(0)] TEnumAsByte<EKuroDynamicCloudType> KuroDynamicCloudType, float SequenceCloudTimeControl, float SequenceCloudTimeOffset, bool bOverrideCloudRotation, bool bInstantSwitchDynamicCloud, float SequenceGlobalTimeControl, UTextureCube MaterialDynamicReflectionTexture, bool bEnableGlobalGIQualityLow, float FogVisibilityCulling, bool bOverride_PauseEffects, bool bPauseEffects, bool bOverride_BurstDissolveTexture, UTexture2D BurstDissolveTexture, bool bOverride_BurstDissolveThreshold, float BurstDissolveThreshold, bool bOverride_BurstDissolveSmooth, float BurstDissolveSmooth, bool bOverride_BurstClipThreshold, float BurstClipThreshold, bool bOverride_ForbidWeatherWhenTakeOver, bool ForbidWeatherWhenTakeOver, bool bOverride_GlobalFootstepMaterial, UPhysicalMaterial GlobalFootstepMaterial, bool bOverride_WaveUsePolarPattern, bool WaveUsePolarPattern, bool bOverride_WavePatternTexture, UTexture2D WavePatternTexture, bool bOverride_WavePatternScaleBias, FVector4 WavePatternScaleBias, bool bOverride_WaveCenter, FVector WaveCenter, bool bOverride_WaveFront, FVector2D WaveFront, bool bOverride_WaveRadius, float WaveRadius, bool bOverride_WaveRadiusSmooth, float WaveRadiusSmooth, bool bOverride_WaveHeight, float WaveHeight, bool bOverride_WaveHeightSmooth, float WaveHeightSmooth, bool bOverride_WaveNormalSize, float WaveNormalSize, bool bOverride_WaveRoughness, float WaveRoughness, bool bOverride_WaveDissolveTexture, UTexture2D WaveDissolveTexture, bool bOverride_WaveDissolveScaleBias, FVector4 WaveDissolveScaleBias, bool bOverride_WaveDissolveProgress, float WaveDissolveProgress, bool bOverride_WaveDissolveSmooth, float WaveDissolveSmooth, bool bOverride_WaveColorTexture, UTexture2D WaveColorTexture, bool bOverride_WaveColorScaleBias, FVector4 WaveColorScaleBias, bool bOverride_WaveColorTextureTint, FLinearColor WaveColorTextureTint, bool bOverride_WaveWiggleAmplitude, float WaveWiggleAmplitude, bool bOverride_WaveColorTint, FLinearColor WaveColorTint, bool bOverride_WaveColorAdd, FLinearColor WaveColorAdd, bool bOverride_WaveOverallDensity, float WaveOverallDensity, bool bOverride_OpenLightningFireBurnt, bool OpenLightningFireBurnt, bool bOverride_LightningFireProbability, float LightningFireProbability, bool bOverride_OpenDynamicWaterFlow, bool OpenDynamicWaterFlow, bool bOverride_MeshBlendIntensity, float MeshBlendIntensity)
		{
			this.bOverride_ThunderType = bOverride_ThunderType;
			this.bOverride_ThunderGenerateChanceScale = bOverride_ThunderGenerateChanceScale;
			this.bOverride_ThunderAttackChance = bOverride_ThunderAttackChance;
			this.bOverride_ThunderColor = bOverride_ThunderColor;
			this.bOverride_ThunderLightBrightness = bOverride_ThunderLightBrightness;
			this.bOverride_ThunderLightColor = bOverride_ThunderLightColor;
			this.bOverride_ThunderCloudBrightness = bOverride_ThunderCloudBrightness;
			this.ThunderType = ThunderType;
			this.ThunderGenerateChanceScale = ThunderGenerateChanceScale;
			this.ThunderAttackChance = ThunderAttackChance;
			this.ThunderColor = ThunderColor;
			this.ThunderLightBrightness = ThunderLightBrightness;
			this.ThunderLightColor = ThunderLightColor;
			this.ThunderCloudBrightness = ThunderCloudBrightness;
			this.bOverride_RainType = bOverride_RainType;
			this.bOverride_RainDensity = bOverride_RainDensity;
			this.bOverride_RainRippleIntensity = bOverride_RainRippleIntensity;
			this.bOverride_RainLerpTime = bOverride_RainLerpTime;
			this.bOverride_RainLerpData = bOverride_RainLerpData;
			this.bOverride_RainHeightNoiseChannel = bOverride_RainHeightNoiseChannel;
			this.bOverride_RainFogDensity = bOverride_RainFogDensity;
			this.bOverride_RainDensityChangeSpeed = bOverride_RainDensityChangeSpeed;
			this.bOverride_bRainAffactPointLight = bOverride_bRainAffactPointLight;
			this.RainType = RainType;
			this.RainDensity = RainDensity;
			this.RainRippleIntensity = RainRippleIntensity;
			this.RainLerpTime = RainLerpTime;
			this.RainLerpData = RainLerpData;
			this.RainHeightNoiseChannel = RainHeightNoiseChannel;
			this.RainFogDensity = RainFogDensity;
			this.RainDensityChangeSpeed = RainDensityChangeSpeed;
			this.bRainAffectPointLight = bRainAffectPointLight;
			this.bOverride_SnowCoverIntensity = bOverride_SnowCoverIntensity;
			this.SnowCoverIntensity = SnowCoverIntensity;
			this.bOverride_FrozenProgress = bOverride_FrozenProgress;
			this.bOverride_FrozenTime = bOverride_FrozenTime;
			this.bOverride_SnowSpecksNumber = bOverride_SnowSpecksNumber;
			this.bOverride_SnowSpecksStrength = bOverride_SnowSpecksStrength;
			this.FrozenProgress = FrozenProgress;
			this.FrozenTime = FrozenTime;
			this.SnowSpecksNumber = SnowSpecksNumber;
			this.SnowSpecksStrength = SnowSpecksStrength;
			this.bOverride_RainWindSize = bOverride_RainWindSize;
			this.bOverride_RainGravity = bOverride_RainGravity;
			this.bOverride_RainDrag = bOverride_RainDrag;
			this.bOverride_RainTimeDilation = bOverride_RainTimeDilation;
			this.bOverride_RainTimeFreezeSpherize = bOverride_RainTimeFreezeSpherize;
			this.bOverride_RainSphereMask = bOverride_RainSphereMask;
			this.bOverride_RainSphereMaskOffset = bOverride_RainSphereMaskOffset;
			this.bOverride_RainSphereMaskUseBone = bOverride_RainSphereMaskUseBone;
			this.RainWindSizeOverride = RainWindSizeOverride;
			this.RainGravityOverride = RainGravityOverride;
			this.RainDragOverride = RainDragOverride;
			this.RainTimeDilationOverride = RainTimeDilationOverride;
			this.bRainTimeFreezeSpherize = bRainTimeFreezeSpherize;
			this.RainToSphereTime = RainToSphereTime;
			this.RainToRainTime = RainToRainTime;
			this.RainSphereMaskRadius = RainSphereMaskRadius;
			this.RainSphereMaskOffset = RainSphereMaskOffset;
			this.bRainSphereMaskUseBone = bRainSphereMaskUseBone;
			this.RainSphereMaskBoneName = RainSphereMaskBoneName;
			this.bOverride_RoughnessDensity = bOverride_RoughnessDensity;
			this.bOverride_MixRoughness = bOverride_MixRoughness;
			this.bOverride_MixRoughness_Mobile = bOverride_MixRoughness_Mobile;
			this.bOverride_EffectGravity = bOverride_EffectGravity;
			this.bOverride_LightFunctionIntensity = bOverride_LightFunctionIntensity;
			this.bOverride_LightFunctionMapUVScaleBias = bOverride_LightFunctionMapUVScaleBias;
			this.bOverride_LightFunctionSpeed = bOverride_LightFunctionSpeed;
			this.bOverride_LightFunctionAngle = bOverride_LightFunctionAngle;
			this.bOverride_LightFunctionTexture = bOverride_LightFunctionTexture;
			this.bOverride_LightFunctionPerShadowTexture = bOverride_LightFunctionPerShadowTexture;
			this.bOverride_KuroDynamicCloudType = bOverride_KuroDynamicCloudType;
			this.bOverride_SequenceCloudTimeControl = bOverride_SequenceCloudTimeControl;
			this.bOverride_SequenceCloudTimeOffset = bOverride_SequenceCloudTimeOffset;
			this.bOverride_OverrideCloudRotation = bOverride_OverrideCloudRotation;
			this.bOverride_InstantSwitchDynamicCloud = bOverride_InstantSwitchDynamicCloud;
			this.bOverride_SequenceGlobalTimeControl = bOverride_SequenceGlobalTimeControl;
			this.bOverride_MaterialDynamicReflectionTexture = bOverride_MaterialDynamicReflectionTexture;
			this.bOverride_FogVisibilityCulling = bOverride_FogVisibilityCulling;
			this.RoughnessDensity = RoughnessDensity;
			this.MixRoughness = MixRoughness;
			this.MixRoughness_Mobile = MixRoughness_Mobile;
			this.EffectGravity = EffectGravity;
			this.LightFunctionIntensity = LightFunctionIntensity;
			this.LightFunctionMapUVScaleBias = LightFunctionMapUVScaleBias;
			this.LightFunctionSpeed = LightFunctionSpeed;
			this.LightFunctionAngle = LightFunctionAngle;
			this.LightFunctionTexture = LightFunctionTexture;
			this.LightFunctionPerShadowTexture = LightFunctionPerShadowTexture;
			this.KuroDynamicCloudType = KuroDynamicCloudType;
			this.SequenceCloudTimeControl = SequenceCloudTimeControl;
			this.SequenceCloudTimeOffset = SequenceCloudTimeOffset;
			this.bOverrideCloudRotation = bOverrideCloudRotation;
			this.bInstantSwitchDynamicCloud = bInstantSwitchDynamicCloud;
			this.SequenceGlobalTimeControl = SequenceGlobalTimeControl;
			this.MaterialDynamicReflectionTexture = MaterialDynamicReflectionTexture;
			this.bEnableGlobalGIQualityLow = bEnableGlobalGIQualityLow;
			this.FogVisibilityCulling = FogVisibilityCulling;
			this.bOverride_PauseEffects = bOverride_PauseEffects;
			this.bPauseEffects = bPauseEffects;
			this.bOverride_BurstDissolveTexture = bOverride_BurstDissolveTexture;
			this.BurstDissolveTexture = BurstDissolveTexture;
			this.bOverride_BurstDissolveThreshold = bOverride_BurstDissolveThreshold;
			this.BurstDissolveThreshold = BurstDissolveThreshold;
			this.bOverride_BurstDissolveSmooth = bOverride_BurstDissolveSmooth;
			this.BurstDissolveSmooth = BurstDissolveSmooth;
			this.bOverride_BurstClipThreshold = bOverride_BurstClipThreshold;
			this.BurstClipThreshold = BurstClipThreshold;
			this.bOverride_ForbidWeatherWhenTakeOver = bOverride_ForbidWeatherWhenTakeOver;
			this.ForbidWeatherWhenTakeOver = ForbidWeatherWhenTakeOver;
			this.bOverride_GlobalFootstepMaterial = bOverride_GlobalFootstepMaterial;
			this.GlobalFootstepMaterial = GlobalFootstepMaterial;
			this.bOverride_WaveUsePolarPattern = bOverride_WaveUsePolarPattern;
			this.WaveUsePolarPattern = WaveUsePolarPattern;
			this.bOverride_WavePatternTexture = bOverride_WavePatternTexture;
			this.WavePatternTexture = WavePatternTexture;
			this.bOverride_WavePatternScaleBias = bOverride_WavePatternScaleBias;
			this.WavePatternScaleBias = WavePatternScaleBias;
			this.bOverride_WaveCenter = bOverride_WaveCenter;
			this.WaveCenter = WaveCenter;
			this.bOverride_WaveFront = bOverride_WaveFront;
			this.WaveFront = WaveFront;
			this.bOverride_WaveRadius = bOverride_WaveRadius;
			this.WaveRadius = WaveRadius;
			this.bOverride_WaveRadiusSmooth = bOverride_WaveRadiusSmooth;
			this.WaveRadiusSmooth = WaveRadiusSmooth;
			this.bOverride_WaveHeight = bOverride_WaveHeight;
			this.WaveHeight = WaveHeight;
			this.bOverride_WaveHeightSmooth = bOverride_WaveHeightSmooth;
			this.WaveHeightSmooth = WaveHeightSmooth;
			this.bOverride_WaveNormalSize = bOverride_WaveNormalSize;
			this.WaveNormalSize = WaveNormalSize;
			this.bOverride_WaveRoughness = bOverride_WaveRoughness;
			this.WaveRoughness = WaveRoughness;
			this.bOverride_WaveDissolveTexture = bOverride_WaveDissolveTexture;
			this.WaveDissolveTexture = WaveDissolveTexture;
			this.bOverride_WaveDissolveScaleBias = bOverride_WaveDissolveScaleBias;
			this.WaveDissolveScaleBias = WaveDissolveScaleBias;
			this.bOverride_WaveDissolveProgress = bOverride_WaveDissolveProgress;
			this.WaveDissolveProgress = WaveDissolveProgress;
			this.bOverride_WaveDissolveSmooth = bOverride_WaveDissolveSmooth;
			this.WaveDissolveSmooth = WaveDissolveSmooth;
			this.bOverride_WaveColorTexture = bOverride_WaveColorTexture;
			this.WaveColorTexture = WaveColorTexture;
			this.bOverride_WaveColorScaleBias = bOverride_WaveColorScaleBias;
			this.WaveColorScaleBias = WaveColorScaleBias;
			this.bOverride_WaveColorTextureTint = bOverride_WaveColorTextureTint;
			this.WaveColorTextureTint = WaveColorTextureTint;
			this.bOverride_WaveWiggleAmplitude = bOverride_WaveWiggleAmplitude;
			this.WaveWiggleAmplitude = WaveWiggleAmplitude;
			this.bOverride_WaveColorTint = bOverride_WaveColorTint;
			this.WaveColorTint = WaveColorTint;
			this.bOverride_WaveColorAdd = bOverride_WaveColorAdd;
			this.WaveColorAdd = WaveColorAdd;
			this.bOverride_WaveOverallDensity = bOverride_WaveOverallDensity;
			this.WaveOverallDensity = WaveOverallDensity;
			this.bOverride_OpenLightningFireBurnt = bOverride_OpenLightningFireBurnt;
			this.OpenLightningFireBurnt = OpenLightningFireBurnt;
			this.bOverride_LightningFireProbability = bOverride_LightningFireProbability;
			this.LightningFireProbability = LightningFireProbability;
			this.bOverride_OpenDynamicWaterFlow = bOverride_OpenDynamicWaterFlow;
			this.OpenDynamicWaterFlow = OpenDynamicWaterFlow;
			this.bOverride_MeshBlendIntensity = bOverride_MeshBlendIntensity;
			this.MeshBlendIntensity = MeshBlendIntensity;
		}

		// Token: 0x06019341 RID: 103233 RVA: 0x00254894 File Offset: 0x00252A94
		protected override IntPtr GetUStructPtr()
		{
			return FGIMiscSetting.StaticStruct();
		}

		// Token: 0x06019342 RID: 103234 RVA: 0x002548A0 File Offset: 0x00252AA0
		public FGIMiscSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06019343 RID: 103235 RVA: 0x002548AA File Offset: 0x00252AAA
		public FGIMiscSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06019344 RID: 103236 RVA: 0x002548B5 File Offset: 0x00252AB5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGIMiscSetting(Pointer, false, true);
		}

		// Token: 0x06019345 RID: 103237 RVA: 0x002548BF File Offset: 0x00252ABF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGIMiscSetting(Pointer, MemoryOwner);
		}

		// Token: 0x0400DB06 RID: 56070
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.GIMiscSetting";

		// Token: 0x0400DB07 RID: 56071
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400DB08 RID: 56072
		internal static int __PropertyOffset_bOverride_ThunderType;

		// Token: 0x0400DB09 RID: 56073
		internal static byte __PropertyMask_bOverride_ThunderType;

		// Token: 0x0400DB0A RID: 56074
		internal static int __PropertyOffset_bOverride_ThunderGenerateChanceScale;

		// Token: 0x0400DB0B RID: 56075
		internal static byte __PropertyMask_bOverride_ThunderGenerateChanceScale;

		// Token: 0x0400DB0C RID: 56076
		internal static int __PropertyOffset_bOverride_ThunderAttackChance;

		// Token: 0x0400DB0D RID: 56077
		internal static byte __PropertyMask_bOverride_ThunderAttackChance;

		// Token: 0x0400DB0E RID: 56078
		internal static int __PropertyOffset_bOverride_ThunderColor;

		// Token: 0x0400DB0F RID: 56079
		internal static byte __PropertyMask_bOverride_ThunderColor;

		// Token: 0x0400DB10 RID: 56080
		internal static int __PropertyOffset_bOverride_ThunderLightBrightness;

		// Token: 0x0400DB11 RID: 56081
		internal static byte __PropertyMask_bOverride_ThunderLightBrightness;

		// Token: 0x0400DB12 RID: 56082
		internal static int __PropertyOffset_bOverride_ThunderLightColor;

		// Token: 0x0400DB13 RID: 56083
		internal static byte __PropertyMask_bOverride_ThunderLightColor;

		// Token: 0x0400DB14 RID: 56084
		internal static int __PropertyOffset_bOverride_ThunderCloudBrightness;

		// Token: 0x0400DB15 RID: 56085
		internal static byte __PropertyMask_bOverride_ThunderCloudBrightness;

		// Token: 0x0400DB16 RID: 56086
		internal static int __PropertyOffset_ThunderType;

		// Token: 0x0400DB17 RID: 56087
		internal static int __PropertyOffset_ThunderGenerateChanceScale;

		// Token: 0x0400DB18 RID: 56088
		internal static int __PropertyOffset_ThunderAttackChance;

		// Token: 0x0400DB19 RID: 56089
		internal static int __PropertyOffset_ThunderColor;

		// Token: 0x0400DB1A RID: 56090
		internal static int __PropertyOffset_ThunderLightBrightness;

		// Token: 0x0400DB1B RID: 56091
		internal static int __PropertyOffset_ThunderLightColor;

		// Token: 0x0400DB1C RID: 56092
		internal static int __PropertyOffset_ThunderCloudBrightness;

		// Token: 0x0400DB1D RID: 56093
		internal static int __PropertyOffset_bOverride_RainType;

		// Token: 0x0400DB1E RID: 56094
		internal static byte __PropertyMask_bOverride_RainType;

		// Token: 0x0400DB1F RID: 56095
		internal static int __PropertyOffset_bOverride_RainDensity;

		// Token: 0x0400DB20 RID: 56096
		internal static byte __PropertyMask_bOverride_RainDensity;

		// Token: 0x0400DB21 RID: 56097
		internal static int __PropertyOffset_bOverride_RainRippleIntensity;

		// Token: 0x0400DB22 RID: 56098
		internal static byte __PropertyMask_bOverride_RainRippleIntensity;

		// Token: 0x0400DB23 RID: 56099
		internal static int __PropertyOffset_bOverride_RainLerpTime;

		// Token: 0x0400DB24 RID: 56100
		internal static byte __PropertyMask_bOverride_RainLerpTime;

		// Token: 0x0400DB25 RID: 56101
		internal static int __PropertyOffset_bOverride_RainLerpData;

		// Token: 0x0400DB26 RID: 56102
		internal static byte __PropertyMask_bOverride_RainLerpData;

		// Token: 0x0400DB27 RID: 56103
		internal static int __PropertyOffset_bOverride_RainHeightNoiseChannel;

		// Token: 0x0400DB28 RID: 56104
		internal static byte __PropertyMask_bOverride_RainHeightNoiseChannel;

		// Token: 0x0400DB29 RID: 56105
		internal static int __PropertyOffset_bOverride_RainFogDensity;

		// Token: 0x0400DB2A RID: 56106
		internal static byte __PropertyMask_bOverride_RainFogDensity;

		// Token: 0x0400DB2B RID: 56107
		internal static int __PropertyOffset_bOverride_RainDensityChangeSpeed;

		// Token: 0x0400DB2C RID: 56108
		internal static byte __PropertyMask_bOverride_RainDensityChangeSpeed;

		// Token: 0x0400DB2D RID: 56109
		internal static int __PropertyOffset_bOverride_bRainAffactPointLight;

		// Token: 0x0400DB2E RID: 56110
		internal static byte __PropertyMask_bOverride_bRainAffactPointLight;

		// Token: 0x0400DB2F RID: 56111
		internal static int __PropertyOffset_RainType;

		// Token: 0x0400DB30 RID: 56112
		internal static int __PropertyOffset_RainDensity;

		// Token: 0x0400DB31 RID: 56113
		internal static int __PropertyOffset_RainRippleIntensity;

		// Token: 0x0400DB32 RID: 56114
		internal static int __PropertyOffset_RainLerpTime;

		// Token: 0x0400DB33 RID: 56115
		internal static int __PropertyOffset_RainLerpData;

		// Token: 0x0400DB34 RID: 56116
		internal static int __PropertyOffset_RainHeightNoiseChannel;

		// Token: 0x0400DB35 RID: 56117
		internal static int __PropertyOffset_RainFogDensity;

		// Token: 0x0400DB36 RID: 56118
		internal static int __PropertyOffset_RainDensityChangeSpeed;

		// Token: 0x0400DB37 RID: 56119
		internal static int __PropertyOffset_bRainAffectPointLight;

		// Token: 0x0400DB38 RID: 56120
		internal static int __PropertyOffset_bOverride_SnowCoverIntensity;

		// Token: 0x0400DB39 RID: 56121
		internal static byte __PropertyMask_bOverride_SnowCoverIntensity;

		// Token: 0x0400DB3A RID: 56122
		internal static int __PropertyOffset_SnowCoverIntensity;

		// Token: 0x0400DB3B RID: 56123
		internal static int __PropertyOffset_bOverride_FrozenProgress;

		// Token: 0x0400DB3C RID: 56124
		internal static byte __PropertyMask_bOverride_FrozenProgress;

		// Token: 0x0400DB3D RID: 56125
		internal static int __PropertyOffset_bOverride_FrozenTime;

		// Token: 0x0400DB3E RID: 56126
		internal static byte __PropertyMask_bOverride_FrozenTime;

		// Token: 0x0400DB3F RID: 56127
		internal static int __PropertyOffset_bOverride_SnowSpecksNumber;

		// Token: 0x0400DB40 RID: 56128
		internal static byte __PropertyMask_bOverride_SnowSpecksNumber;

		// Token: 0x0400DB41 RID: 56129
		internal static int __PropertyOffset_bOverride_SnowSpecksStrength;

		// Token: 0x0400DB42 RID: 56130
		internal static byte __PropertyMask_bOverride_SnowSpecksStrength;

		// Token: 0x0400DB43 RID: 56131
		internal static int __PropertyOffset_FrozenProgress;

		// Token: 0x0400DB44 RID: 56132
		internal static int __PropertyOffset_FrozenTime;

		// Token: 0x0400DB45 RID: 56133
		internal static int __PropertyOffset_SnowSpecksNumber;

		// Token: 0x0400DB46 RID: 56134
		internal static int __PropertyOffset_SnowSpecksStrength;

		// Token: 0x0400DB47 RID: 56135
		internal static int __PropertyOffset_bOverride_RainWindSize;

		// Token: 0x0400DB48 RID: 56136
		internal static byte __PropertyMask_bOverride_RainWindSize;

		// Token: 0x0400DB49 RID: 56137
		internal static int __PropertyOffset_bOverride_RainGravity;

		// Token: 0x0400DB4A RID: 56138
		internal static byte __PropertyMask_bOverride_RainGravity;

		// Token: 0x0400DB4B RID: 56139
		internal static int __PropertyOffset_bOverride_RainDrag;

		// Token: 0x0400DB4C RID: 56140
		internal static byte __PropertyMask_bOverride_RainDrag;

		// Token: 0x0400DB4D RID: 56141
		internal static int __PropertyOffset_bOverride_RainTimeDilation;

		// Token: 0x0400DB4E RID: 56142
		internal static byte __PropertyMask_bOverride_RainTimeDilation;

		// Token: 0x0400DB4F RID: 56143
		internal static int __PropertyOffset_bOverride_RainTimeFreezeSpherize;

		// Token: 0x0400DB50 RID: 56144
		internal static byte __PropertyMask_bOverride_RainTimeFreezeSpherize;

		// Token: 0x0400DB51 RID: 56145
		internal static int __PropertyOffset_bOverride_RainSphereMask;

		// Token: 0x0400DB52 RID: 56146
		internal static byte __PropertyMask_bOverride_RainSphereMask;

		// Token: 0x0400DB53 RID: 56147
		internal static int __PropertyOffset_bOverride_RainSphereMaskOffset;

		// Token: 0x0400DB54 RID: 56148
		internal static byte __PropertyMask_bOverride_RainSphereMaskOffset;

		// Token: 0x0400DB55 RID: 56149
		internal static int __PropertyOffset_bOverride_RainSphereMaskUseBone;

		// Token: 0x0400DB56 RID: 56150
		internal static byte __PropertyMask_bOverride_RainSphereMaskUseBone;

		// Token: 0x0400DB57 RID: 56151
		internal static int __PropertyOffset_RainWindSizeOverride;

		// Token: 0x0400DB58 RID: 56152
		internal static int __PropertyOffset_RainGravityOverride;

		// Token: 0x0400DB59 RID: 56153
		internal static int __PropertyOffset_RainDragOverride;

		// Token: 0x0400DB5A RID: 56154
		internal static int __PropertyOffset_RainTimeDilationOverride;

		// Token: 0x0400DB5B RID: 56155
		internal static int __PropertyOffset_bRainTimeFreezeSpherize;

		// Token: 0x0400DB5C RID: 56156
		internal static int __PropertyOffset_RainToSphereTime;

		// Token: 0x0400DB5D RID: 56157
		internal static int __PropertyOffset_RainToRainTime;

		// Token: 0x0400DB5E RID: 56158
		internal static int __PropertyOffset_RainSphereMaskRadius;

		// Token: 0x0400DB5F RID: 56159
		internal static int __PropertyOffset_RainSphereMaskOffset;

		// Token: 0x0400DB60 RID: 56160
		internal static int __PropertyOffset_bRainSphereMaskUseBone;

		// Token: 0x0400DB61 RID: 56161
		internal static int __PropertyOffset_RainSphereMaskBoneName;

		// Token: 0x0400DB62 RID: 56162
		internal static int __PropertyOffset_bOverride_RoughnessDensity;

		// Token: 0x0400DB63 RID: 56163
		internal static byte __PropertyMask_bOverride_RoughnessDensity;

		// Token: 0x0400DB64 RID: 56164
		internal static int __PropertyOffset_bOverride_MixRoughness;

		// Token: 0x0400DB65 RID: 56165
		internal static byte __PropertyMask_bOverride_MixRoughness;

		// Token: 0x0400DB66 RID: 56166
		internal static int __PropertyOffset_bOverride_MixRoughness_Mobile;

		// Token: 0x0400DB67 RID: 56167
		internal static byte __PropertyMask_bOverride_MixRoughness_Mobile;

		// Token: 0x0400DB68 RID: 56168
		internal static int __PropertyOffset_bOverride_EffectGravity;

		// Token: 0x0400DB69 RID: 56169
		internal static byte __PropertyMask_bOverride_EffectGravity;

		// Token: 0x0400DB6A RID: 56170
		internal static int __PropertyOffset_bOverride_LightFunctionIntensity;

		// Token: 0x0400DB6B RID: 56171
		internal static byte __PropertyMask_bOverride_LightFunctionIntensity;

		// Token: 0x0400DB6C RID: 56172
		internal static int __PropertyOffset_bOverride_LightFunctionMapUVScaleBias;

		// Token: 0x0400DB6D RID: 56173
		internal static byte __PropertyMask_bOverride_LightFunctionMapUVScaleBias;

		// Token: 0x0400DB6E RID: 56174
		internal static int __PropertyOffset_bOverride_LightFunctionSpeed;

		// Token: 0x0400DB6F RID: 56175
		internal static byte __PropertyMask_bOverride_LightFunctionSpeed;

		// Token: 0x0400DB70 RID: 56176
		internal static int __PropertyOffset_bOverride_LightFunctionAngle;

		// Token: 0x0400DB71 RID: 56177
		internal static byte __PropertyMask_bOverride_LightFunctionAngle;

		// Token: 0x0400DB72 RID: 56178
		internal static int __PropertyOffset_bOverride_LightFunctionTexture;

		// Token: 0x0400DB73 RID: 56179
		internal static byte __PropertyMask_bOverride_LightFunctionTexture;

		// Token: 0x0400DB74 RID: 56180
		internal static int __PropertyOffset_bOverride_LightFunctionPerShadowTexture;

		// Token: 0x0400DB75 RID: 56181
		internal static byte __PropertyMask_bOverride_LightFunctionPerShadowTexture;

		// Token: 0x0400DB76 RID: 56182
		internal static int __PropertyOffset_bOverride_KuroDynamicCloudType;

		// Token: 0x0400DB77 RID: 56183
		internal static byte __PropertyMask_bOverride_KuroDynamicCloudType;

		// Token: 0x0400DB78 RID: 56184
		internal static int __PropertyOffset_bOverride_SequenceCloudTimeControl;

		// Token: 0x0400DB79 RID: 56185
		internal static byte __PropertyMask_bOverride_SequenceCloudTimeControl;

		// Token: 0x0400DB7A RID: 56186
		internal static int __PropertyOffset_bOverride_SequenceCloudTimeOffset;

		// Token: 0x0400DB7B RID: 56187
		internal static byte __PropertyMask_bOverride_SequenceCloudTimeOffset;

		// Token: 0x0400DB7C RID: 56188
		internal static int __PropertyOffset_bOverride_OverrideCloudRotation;

		// Token: 0x0400DB7D RID: 56189
		internal static byte __PropertyMask_bOverride_OverrideCloudRotation;

		// Token: 0x0400DB7E RID: 56190
		internal static int __PropertyOffset_bOverride_InstantSwitchDynamicCloud;

		// Token: 0x0400DB7F RID: 56191
		internal static byte __PropertyMask_bOverride_InstantSwitchDynamicCloud;

		// Token: 0x0400DB80 RID: 56192
		internal static int __PropertyOffset_bOverride_SequenceGlobalTimeControl;

		// Token: 0x0400DB81 RID: 56193
		internal static byte __PropertyMask_bOverride_SequenceGlobalTimeControl;

		// Token: 0x0400DB82 RID: 56194
		internal static int __PropertyOffset_bOverride_MaterialDynamicReflectionTexture;

		// Token: 0x0400DB83 RID: 56195
		internal static byte __PropertyMask_bOverride_MaterialDynamicReflectionTexture;

		// Token: 0x0400DB84 RID: 56196
		internal static int __PropertyOffset_bOverride_FogVisibilityCulling;

		// Token: 0x0400DB85 RID: 56197
		internal static byte __PropertyMask_bOverride_FogVisibilityCulling;

		// Token: 0x0400DB86 RID: 56198
		internal static int __PropertyOffset_RoughnessDensity;

		// Token: 0x0400DB87 RID: 56199
		internal static int __PropertyOffset_MixRoughness;

		// Token: 0x0400DB88 RID: 56200
		internal static int __PropertyOffset_MixRoughness_Mobile;

		// Token: 0x0400DB89 RID: 56201
		internal static int __PropertyOffset_EffectGravity;

		// Token: 0x0400DB8A RID: 56202
		internal static int __PropertyOffset_LightFunctionIntensity;

		// Token: 0x0400DB8B RID: 56203
		internal static int __PropertyOffset_LightFunctionMapUVScaleBias;

		// Token: 0x0400DB8C RID: 56204
		internal static int __PropertyOffset_LightFunctionSpeed;

		// Token: 0x0400DB8D RID: 56205
		internal static int __PropertyOffset_LightFunctionAngle;

		// Token: 0x0400DB8E RID: 56206
		internal static int __PropertyOffset_LightFunctionTexture;

		// Token: 0x0400DB8F RID: 56207
		internal static int __PropertyOffset_LightFunctionPerShadowTexture;

		// Token: 0x0400DB90 RID: 56208
		internal static int __PropertyOffset_KuroDynamicCloudType;

		// Token: 0x0400DB91 RID: 56209
		internal static int __PropertyOffset_SequenceCloudTimeControl;

		// Token: 0x0400DB92 RID: 56210
		internal static int __PropertyOffset_SequenceCloudTimeOffset;

		// Token: 0x0400DB93 RID: 56211
		internal static int __PropertyOffset_bOverrideCloudRotation;

		// Token: 0x0400DB94 RID: 56212
		internal static int __PropertyOffset_bInstantSwitchDynamicCloud;

		// Token: 0x0400DB95 RID: 56213
		internal static int __PropertyOffset_SequenceGlobalTimeControl;

		// Token: 0x0400DB96 RID: 56214
		internal static int __PropertyOffset_MaterialDynamicReflectionTexture;

		// Token: 0x0400DB97 RID: 56215
		internal static int __PropertyOffset_bEnableGlobalGIQualityLow;

		// Token: 0x0400DB98 RID: 56216
		internal static byte __PropertyMask_bEnableGlobalGIQualityLow;

		// Token: 0x0400DB99 RID: 56217
		internal static int __PropertyOffset_FogVisibilityCulling;

		// Token: 0x0400DB9A RID: 56218
		internal static int __PropertyOffset_bOverride_PauseEffects;

		// Token: 0x0400DB9B RID: 56219
		internal static byte __PropertyMask_bOverride_PauseEffects;

		// Token: 0x0400DB9C RID: 56220
		internal static int __PropertyOffset_bPauseEffects;

		// Token: 0x0400DB9D RID: 56221
		internal static int __PropertyOffset_bOverride_BurstDissolveTexture;

		// Token: 0x0400DB9E RID: 56222
		internal static byte __PropertyMask_bOverride_BurstDissolveTexture;

		// Token: 0x0400DB9F RID: 56223
		internal static int __PropertyOffset_BurstDissolveTexture;

		// Token: 0x0400DBA0 RID: 56224
		internal static int __PropertyOffset_bOverride_BurstDissolveThreshold;

		// Token: 0x0400DBA1 RID: 56225
		internal static byte __PropertyMask_bOverride_BurstDissolveThreshold;

		// Token: 0x0400DBA2 RID: 56226
		internal static int __PropertyOffset_BurstDissolveThreshold;

		// Token: 0x0400DBA3 RID: 56227
		internal static int __PropertyOffset_bOverride_BurstDissolveSmooth;

		// Token: 0x0400DBA4 RID: 56228
		internal static byte __PropertyMask_bOverride_BurstDissolveSmooth;

		// Token: 0x0400DBA5 RID: 56229
		internal static int __PropertyOffset_BurstDissolveSmooth;

		// Token: 0x0400DBA6 RID: 56230
		internal static int __PropertyOffset_bOverride_BurstClipThreshold;

		// Token: 0x0400DBA7 RID: 56231
		internal static byte __PropertyMask_bOverride_BurstClipThreshold;

		// Token: 0x0400DBA8 RID: 56232
		internal static int __PropertyOffset_BurstClipThreshold;

		// Token: 0x0400DBA9 RID: 56233
		internal static int __PropertyOffset_bOverride_ForbidWeatherWhenTakeOver;

		// Token: 0x0400DBAA RID: 56234
		internal static byte __PropertyMask_bOverride_ForbidWeatherWhenTakeOver;

		// Token: 0x0400DBAB RID: 56235
		internal static int __PropertyOffset_ForbidWeatherWhenTakeOver;

		// Token: 0x0400DBAC RID: 56236
		internal static int __PropertyOffset_bOverride_GlobalFootstepMaterial;

		// Token: 0x0400DBAD RID: 56237
		internal static byte __PropertyMask_bOverride_GlobalFootstepMaterial;

		// Token: 0x0400DBAE RID: 56238
		internal static int __PropertyOffset_GlobalFootstepMaterial;

		// Token: 0x0400DBAF RID: 56239
		internal static int __PropertyOffset_bOverride_WaveUsePolarPattern;

		// Token: 0x0400DBB0 RID: 56240
		internal static byte __PropertyMask_bOverride_WaveUsePolarPattern;

		// Token: 0x0400DBB1 RID: 56241
		internal static int __PropertyOffset_WaveUsePolarPattern;

		// Token: 0x0400DBB2 RID: 56242
		internal static int __PropertyOffset_bOverride_WavePatternTexture;

		// Token: 0x0400DBB3 RID: 56243
		internal static byte __PropertyMask_bOverride_WavePatternTexture;

		// Token: 0x0400DBB4 RID: 56244
		internal static int __PropertyOffset_WavePatternTexture;

		// Token: 0x0400DBB5 RID: 56245
		internal static int __PropertyOffset_bOverride_WavePatternScaleBias;

		// Token: 0x0400DBB6 RID: 56246
		internal static byte __PropertyMask_bOverride_WavePatternScaleBias;

		// Token: 0x0400DBB7 RID: 56247
		internal static int __PropertyOffset_WavePatternScaleBias;

		// Token: 0x0400DBB8 RID: 56248
		internal static int __PropertyOffset_bOverride_WaveCenter;

		// Token: 0x0400DBB9 RID: 56249
		internal static byte __PropertyMask_bOverride_WaveCenter;

		// Token: 0x0400DBBA RID: 56250
		internal static int __PropertyOffset_WaveCenter;

		// Token: 0x0400DBBB RID: 56251
		internal static int __PropertyOffset_bOverride_WaveFront;

		// Token: 0x0400DBBC RID: 56252
		internal static byte __PropertyMask_bOverride_WaveFront;

		// Token: 0x0400DBBD RID: 56253
		internal static int __PropertyOffset_WaveFront;

		// Token: 0x0400DBBE RID: 56254
		internal static int __PropertyOffset_bOverride_WaveRadius;

		// Token: 0x0400DBBF RID: 56255
		internal static byte __PropertyMask_bOverride_WaveRadius;

		// Token: 0x0400DBC0 RID: 56256
		internal static int __PropertyOffset_WaveRadius;

		// Token: 0x0400DBC1 RID: 56257
		internal static int __PropertyOffset_bOverride_WaveRadiusSmooth;

		// Token: 0x0400DBC2 RID: 56258
		internal static byte __PropertyMask_bOverride_WaveRadiusSmooth;

		// Token: 0x0400DBC3 RID: 56259
		internal static int __PropertyOffset_WaveRadiusSmooth;

		// Token: 0x0400DBC4 RID: 56260
		internal static int __PropertyOffset_bOverride_WaveHeight;

		// Token: 0x0400DBC5 RID: 56261
		internal static byte __PropertyMask_bOverride_WaveHeight;

		// Token: 0x0400DBC6 RID: 56262
		internal static int __PropertyOffset_WaveHeight;

		// Token: 0x0400DBC7 RID: 56263
		internal static int __PropertyOffset_bOverride_WaveHeightSmooth;

		// Token: 0x0400DBC8 RID: 56264
		internal static byte __PropertyMask_bOverride_WaveHeightSmooth;

		// Token: 0x0400DBC9 RID: 56265
		internal static int __PropertyOffset_WaveHeightSmooth;

		// Token: 0x0400DBCA RID: 56266
		internal static int __PropertyOffset_bOverride_WaveNormalSize;

		// Token: 0x0400DBCB RID: 56267
		internal static byte __PropertyMask_bOverride_WaveNormalSize;

		// Token: 0x0400DBCC RID: 56268
		internal static int __PropertyOffset_WaveNormalSize;

		// Token: 0x0400DBCD RID: 56269
		internal static int __PropertyOffset_bOverride_WaveRoughness;

		// Token: 0x0400DBCE RID: 56270
		internal static byte __PropertyMask_bOverride_WaveRoughness;

		// Token: 0x0400DBCF RID: 56271
		internal static int __PropertyOffset_WaveRoughness;

		// Token: 0x0400DBD0 RID: 56272
		internal static int __PropertyOffset_bOverride_WaveDissolveTexture;

		// Token: 0x0400DBD1 RID: 56273
		internal static byte __PropertyMask_bOverride_WaveDissolveTexture;

		// Token: 0x0400DBD2 RID: 56274
		internal static int __PropertyOffset_WaveDissolveTexture;

		// Token: 0x0400DBD3 RID: 56275
		internal static int __PropertyOffset_bOverride_WaveDissolveScaleBias;

		// Token: 0x0400DBD4 RID: 56276
		internal static byte __PropertyMask_bOverride_WaveDissolveScaleBias;

		// Token: 0x0400DBD5 RID: 56277
		internal static int __PropertyOffset_WaveDissolveScaleBias;

		// Token: 0x0400DBD6 RID: 56278
		internal static int __PropertyOffset_bOverride_WaveDissolveProgress;

		// Token: 0x0400DBD7 RID: 56279
		internal static byte __PropertyMask_bOverride_WaveDissolveProgress;

		// Token: 0x0400DBD8 RID: 56280
		internal static int __PropertyOffset_WaveDissolveProgress;

		// Token: 0x0400DBD9 RID: 56281
		internal static int __PropertyOffset_bOverride_WaveDissolveSmooth;

		// Token: 0x0400DBDA RID: 56282
		internal static byte __PropertyMask_bOverride_WaveDissolveSmooth;

		// Token: 0x0400DBDB RID: 56283
		internal static int __PropertyOffset_WaveDissolveSmooth;

		// Token: 0x0400DBDC RID: 56284
		internal static int __PropertyOffset_bOverride_WaveColorTexture;

		// Token: 0x0400DBDD RID: 56285
		internal static byte __PropertyMask_bOverride_WaveColorTexture;

		// Token: 0x0400DBDE RID: 56286
		internal static int __PropertyOffset_WaveColorTexture;

		// Token: 0x0400DBDF RID: 56287
		internal static int __PropertyOffset_bOverride_WaveColorScaleBias;

		// Token: 0x0400DBE0 RID: 56288
		internal static byte __PropertyMask_bOverride_WaveColorScaleBias;

		// Token: 0x0400DBE1 RID: 56289
		internal static int __PropertyOffset_WaveColorScaleBias;

		// Token: 0x0400DBE2 RID: 56290
		internal static int __PropertyOffset_bOverride_WaveColorTextureTint;

		// Token: 0x0400DBE3 RID: 56291
		internal static byte __PropertyMask_bOverride_WaveColorTextureTint;

		// Token: 0x0400DBE4 RID: 56292
		internal static int __PropertyOffset_WaveColorTextureTint;

		// Token: 0x0400DBE5 RID: 56293
		internal static int __PropertyOffset_bOverride_WaveWiggleAmplitude;

		// Token: 0x0400DBE6 RID: 56294
		internal static byte __PropertyMask_bOverride_WaveWiggleAmplitude;

		// Token: 0x0400DBE7 RID: 56295
		internal static int __PropertyOffset_WaveWiggleAmplitude;

		// Token: 0x0400DBE8 RID: 56296
		internal static int __PropertyOffset_bOverride_WaveColorTint;

		// Token: 0x0400DBE9 RID: 56297
		internal static byte __PropertyMask_bOverride_WaveColorTint;

		// Token: 0x0400DBEA RID: 56298
		internal static int __PropertyOffset_WaveColorTint;

		// Token: 0x0400DBEB RID: 56299
		internal static int __PropertyOffset_bOverride_WaveColorAdd;

		// Token: 0x0400DBEC RID: 56300
		internal static byte __PropertyMask_bOverride_WaveColorAdd;

		// Token: 0x0400DBED RID: 56301
		internal static int __PropertyOffset_WaveColorAdd;

		// Token: 0x0400DBEE RID: 56302
		internal static int __PropertyOffset_bOverride_WaveOverallDensity;

		// Token: 0x0400DBEF RID: 56303
		internal static byte __PropertyMask_bOverride_WaveOverallDensity;

		// Token: 0x0400DBF0 RID: 56304
		internal static int __PropertyOffset_WaveOverallDensity;

		// Token: 0x0400DBF1 RID: 56305
		internal static int __PropertyOffset_bOverride_OpenLightningFireBurnt;

		// Token: 0x0400DBF2 RID: 56306
		internal static byte __PropertyMask_bOverride_OpenLightningFireBurnt;

		// Token: 0x0400DBF3 RID: 56307
		internal static int __PropertyOffset_OpenLightningFireBurnt;

		// Token: 0x0400DBF4 RID: 56308
		internal static int __PropertyOffset_bOverride_LightningFireProbability;

		// Token: 0x0400DBF5 RID: 56309
		internal static byte __PropertyMask_bOverride_LightningFireProbability;

		// Token: 0x0400DBF6 RID: 56310
		internal static int __PropertyOffset_LightningFireProbability;

		// Token: 0x0400DBF7 RID: 56311
		internal static int __PropertyOffset_bOverride_OpenDynamicWaterFlow;

		// Token: 0x0400DBF8 RID: 56312
		internal static byte __PropertyMask_bOverride_OpenDynamicWaterFlow;

		// Token: 0x0400DBF9 RID: 56313
		internal static int __PropertyOffset_OpenDynamicWaterFlow;

		// Token: 0x0400DBFA RID: 56314
		internal static int __PropertyOffset_bOverride_MeshBlendIntensity;

		// Token: 0x0400DBFB RID: 56315
		internal static byte __PropertyMask_bOverride_MeshBlendIntensity;

		// Token: 0x0400DBFC RID: 56316
		internal static int __PropertyOffset_MeshBlendIntensity;
	}
}
