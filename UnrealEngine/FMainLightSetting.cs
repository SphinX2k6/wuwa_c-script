using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001BFC RID: 7164
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.MainLightSetting")]
	[UnrealStructLayout(140, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 140)]
	public class FMainLightSetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601BA21 RID: 113185 RVA: 0x0028A9BB File Offset: 0x00288BBB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMainLightSetting._ScriptStructPtr != 0) ? FMainLightSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.MainLightSetting", ref FMainLightSetting._ScriptStructPtr);
		}

		// Token: 0x17006F64 RID: 28516
		// (get) Token: 0x0601BA22 RID: 113186 RVA: 0x0028A9DF File Offset: 0x00288BDF
		// (set) Token: 0x0601BA23 RID: 113187 RVA: 0x0028A9F8 File Offset: 0x00288BF8
		public unsafe bool bOverride_MainLightIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_MainLightIntensity) & FMainLightSetting.__PropertyMask_bOverride_MainLightIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_MainLightIntensity) = ((*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_MainLightIntensity) & ~FMainLightSetting.__PropertyMask_bOverride_MainLightIntensity) | (value ? FMainLightSetting.__PropertyMask_bOverride_MainLightIntensity : 0));
			}
		}

		// Token: 0x17006F65 RID: 28517
		// (get) Token: 0x0601BA24 RID: 113188 RVA: 0x0028AA28 File Offset: 0x00288C28
		// (set) Token: 0x0601BA25 RID: 113189 RVA: 0x0028AA41 File Offset: 0x00288C41
		public unsafe bool bOverride_MainLightTint
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_MainLightTint) & FMainLightSetting.__PropertyMask_bOverride_MainLightTint) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_MainLightTint) = ((*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_MainLightTint) & ~FMainLightSetting.__PropertyMask_bOverride_MainLightTint) | (value ? FMainLightSetting.__PropertyMask_bOverride_MainLightTint : 0));
			}
		}

		// Token: 0x17006F66 RID: 28518
		// (get) Token: 0x0601BA26 RID: 113190 RVA: 0x0028AA71 File Offset: 0x00288C71
		// (set) Token: 0x0601BA27 RID: 113191 RVA: 0x0028AA8A File Offset: 0x00288C8A
		public unsafe bool bOverride_MobileMainLightTintSaturation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_MobileMainLightTintSaturation) & FMainLightSetting.__PropertyMask_bOverride_MobileMainLightTintSaturation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_MobileMainLightTintSaturation) = ((*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_MobileMainLightTintSaturation) & ~FMainLightSetting.__PropertyMask_bOverride_MobileMainLightTintSaturation) | (value ? FMainLightSetting.__PropertyMask_bOverride_MobileMainLightTintSaturation : 0));
			}
		}

		// Token: 0x17006F67 RID: 28519
		// (get) Token: 0x0601BA28 RID: 113192 RVA: 0x0028AABA File Offset: 0x00288CBA
		// (set) Token: 0x0601BA29 RID: 113193 RVA: 0x0028AAD3 File Offset: 0x00288CD3
		public unsafe bool bOverride_MobileMainLightTintValueMut
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_MobileMainLightTintValueMut) & FMainLightSetting.__PropertyMask_bOverride_MobileMainLightTintValueMut) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_MobileMainLightTintValueMut) = ((*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_MobileMainLightTintValueMut) & ~FMainLightSetting.__PropertyMask_bOverride_MobileMainLightTintValueMut) | (value ? FMainLightSetting.__PropertyMask_bOverride_MobileMainLightTintValueMut : 0));
			}
		}

		// Token: 0x17006F68 RID: 28520
		// (get) Token: 0x0601BA2A RID: 113194 RVA: 0x0028AB03 File Offset: 0x00288D03
		// (set) Token: 0x0601BA2B RID: 113195 RVA: 0x0028AB1C File Offset: 0x00288D1C
		public unsafe bool bOverride_MainLightTemperature
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_MainLightTemperature) & FMainLightSetting.__PropertyMask_bOverride_MainLightTemperature) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_MainLightTemperature) = ((*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_MainLightTemperature) & ~FMainLightSetting.__PropertyMask_bOverride_MainLightTemperature) | (value ? FMainLightSetting.__PropertyMask_bOverride_MainLightTemperature : 0));
			}
		}

		// Token: 0x17006F69 RID: 28521
		// (get) Token: 0x0601BA2C RID: 113196 RVA: 0x0028AB4C File Offset: 0x00288D4C
		// (set) Token: 0x0601BA2D RID: 113197 RVA: 0x0028AB65 File Offset: 0x00288D65
		public unsafe bool bOverride_MainLightSpecularIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_MainLightSpecularIntensity) & FMainLightSetting.__PropertyMask_bOverride_MainLightSpecularIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_MainLightSpecularIntensity) = ((*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_MainLightSpecularIntensity) & ~FMainLightSetting.__PropertyMask_bOverride_MainLightSpecularIntensity) | (value ? FMainLightSetting.__PropertyMask_bOverride_MainLightSpecularIntensity : 0));
			}
		}

		// Token: 0x17006F6A RID: 28522
		// (get) Token: 0x0601BA2E RID: 113198 RVA: 0x0028AB95 File Offset: 0x00288D95
		// (set) Token: 0x0601BA2F RID: 113199 RVA: 0x0028ABAE File Offset: 0x00288DAE
		public unsafe bool bOverride_DirLightSpecularIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_DirLightSpecularIntensity) & FMainLightSetting.__PropertyMask_bOverride_DirLightSpecularIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_DirLightSpecularIntensity) = ((*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_DirLightSpecularIntensity) & ~FMainLightSetting.__PropertyMask_bOverride_DirLightSpecularIntensity) | (value ? FMainLightSetting.__PropertyMask_bOverride_DirLightSpecularIntensity : 0));
			}
		}

		// Token: 0x17006F6B RID: 28523
		// (get) Token: 0x0601BA30 RID: 113200 RVA: 0x0028ABDE File Offset: 0x00288DDE
		// (set) Token: 0x0601BA31 RID: 113201 RVA: 0x0028ABF7 File Offset: 0x00288DF7
		public unsafe bool bOverride_ShadowTintIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_ShadowTintIntensity) & FMainLightSetting.__PropertyMask_bOverride_ShadowTintIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_ShadowTintIntensity) = ((*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_ShadowTintIntensity) & ~FMainLightSetting.__PropertyMask_bOverride_ShadowTintIntensity) | (value ? FMainLightSetting.__PropertyMask_bOverride_ShadowTintIntensity : 0));
			}
		}

		// Token: 0x17006F6C RID: 28524
		// (get) Token: 0x0601BA32 RID: 113202 RVA: 0x0028AC27 File Offset: 0x00288E27
		// (set) Token: 0x0601BA33 RID: 113203 RVA: 0x0028AC40 File Offset: 0x00288E40
		public unsafe bool bOverride_ShadowTintColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_ShadowTintColor) & FMainLightSetting.__PropertyMask_bOverride_ShadowTintColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_ShadowTintColor) = ((*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_ShadowTintColor) & ~FMainLightSetting.__PropertyMask_bOverride_ShadowTintColor) | (value ? FMainLightSetting.__PropertyMask_bOverride_ShadowTintColor : 0));
			}
		}

		// Token: 0x17006F6D RID: 28525
		// (get) Token: 0x0601BA34 RID: 113204 RVA: 0x0028AC70 File Offset: 0x00288E70
		// (set) Token: 0x0601BA35 RID: 113205 RVA: 0x0028AC89 File Offset: 0x00288E89
		public unsafe bool bOverride_NearMainLightColorPC
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_NearMainLightColorPC) & FMainLightSetting.__PropertyMask_bOverride_NearMainLightColorPC) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_NearMainLightColorPC) = ((*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_NearMainLightColorPC) & ~FMainLightSetting.__PropertyMask_bOverride_NearMainLightColorPC) | (value ? FMainLightSetting.__PropertyMask_bOverride_NearMainLightColorPC : 0));
			}
		}

		// Token: 0x17006F6E RID: 28526
		// (get) Token: 0x0601BA36 RID: 113206 RVA: 0x0028ACB9 File Offset: 0x00288EB9
		// (set) Token: 0x0601BA37 RID: 113207 RVA: 0x0028ACD2 File Offset: 0x00288ED2
		public unsafe bool bOverride_NearMainLightDistancePC
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_NearMainLightDistancePC) & FMainLightSetting.__PropertyMask_bOverride_NearMainLightDistancePC) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_NearMainLightDistancePC) = ((*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_NearMainLightDistancePC) & ~FMainLightSetting.__PropertyMask_bOverride_NearMainLightDistancePC) | (value ? FMainLightSetting.__PropertyMask_bOverride_NearMainLightDistancePC : 0));
			}
		}

		// Token: 0x17006F6F RID: 28527
		// (get) Token: 0x0601BA38 RID: 113208 RVA: 0x0028AD02 File Offset: 0x00288F02
		// (set) Token: 0x0601BA39 RID: 113209 RVA: 0x0028AD1B File Offset: 0x00288F1B
		public unsafe bool bOverride_UseSeperateMobileNearMainLight
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_UseSeperateMobileNearMainLight) & FMainLightSetting.__PropertyMask_bOverride_UseSeperateMobileNearMainLight) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_UseSeperateMobileNearMainLight) = ((*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_UseSeperateMobileNearMainLight) & ~FMainLightSetting.__PropertyMask_bOverride_UseSeperateMobileNearMainLight) | (value ? FMainLightSetting.__PropertyMask_bOverride_UseSeperateMobileNearMainLight : 0));
			}
		}

		// Token: 0x17006F70 RID: 28528
		// (get) Token: 0x0601BA3A RID: 113210 RVA: 0x0028AD4B File Offset: 0x00288F4B
		// (set) Token: 0x0601BA3B RID: 113211 RVA: 0x0028AD64 File Offset: 0x00288F64
		public unsafe bool bOverride_NearMainLightColorMobile
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_NearMainLightColorMobile) & FMainLightSetting.__PropertyMask_bOverride_NearMainLightColorMobile) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_NearMainLightColorMobile) = ((*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_NearMainLightColorMobile) & ~FMainLightSetting.__PropertyMask_bOverride_NearMainLightColorMobile) | (value ? FMainLightSetting.__PropertyMask_bOverride_NearMainLightColorMobile : 0));
			}
		}

		// Token: 0x17006F71 RID: 28529
		// (get) Token: 0x0601BA3C RID: 113212 RVA: 0x0028AD94 File Offset: 0x00288F94
		// (set) Token: 0x0601BA3D RID: 113213 RVA: 0x0028ADAD File Offset: 0x00288FAD
		public unsafe bool bOverride_NearMainLightDistanceMobile
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_NearMainLightDistanceMobile) & FMainLightSetting.__PropertyMask_bOverride_NearMainLightDistanceMobile) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_NearMainLightDistanceMobile) = ((*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_NearMainLightDistanceMobile) & ~FMainLightSetting.__PropertyMask_bOverride_NearMainLightDistanceMobile) | (value ? FMainLightSetting.__PropertyMask_bOverride_NearMainLightDistanceMobile : 0));
			}
		}

		// Token: 0x17006F72 RID: 28530
		// (get) Token: 0x0601BA3E RID: 113214 RVA: 0x0028ADDD File Offset: 0x00288FDD
		// (set) Token: 0x0601BA3F RID: 113215 RVA: 0x0028ADF6 File Offset: 0x00288FF6
		public unsafe bool bOverride_RoughnessPowIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_RoughnessPowIntensity) & FMainLightSetting.__PropertyMask_bOverride_RoughnessPowIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_RoughnessPowIntensity) = ((*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_RoughnessPowIntensity) & ~FMainLightSetting.__PropertyMask_bOverride_RoughnessPowIntensity) | (value ? FMainLightSetting.__PropertyMask_bOverride_RoughnessPowIntensity : 0));
			}
		}

		// Token: 0x17006F73 RID: 28531
		// (get) Token: 0x0601BA40 RID: 113216 RVA: 0x0028AE26 File Offset: 0x00289026
		// (set) Token: 0x0601BA41 RID: 113217 RVA: 0x0028AE3F File Offset: 0x0028903F
		public unsafe bool bOverride_RoughnessPowIntensityThreshold
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_RoughnessPowIntensityThreshold) & FMainLightSetting.__PropertyMask_bOverride_RoughnessPowIntensityThreshold) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_RoughnessPowIntensityThreshold) = ((*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_RoughnessPowIntensityThreshold) & ~FMainLightSetting.__PropertyMask_bOverride_RoughnessPowIntensityThreshold) | (value ? FMainLightSetting.__PropertyMask_bOverride_RoughnessPowIntensityThreshold : 0));
			}
		}

		// Token: 0x17006F74 RID: 28532
		// (get) Token: 0x0601BA42 RID: 113218 RVA: 0x0028AE6F File Offset: 0x0028906F
		// (set) Token: 0x0601BA43 RID: 113219 RVA: 0x0028AE88 File Offset: 0x00289088
		public unsafe bool bOverride_RoughnessIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_RoughnessIntensity) & FMainLightSetting.__PropertyMask_bOverride_RoughnessIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_RoughnessIntensity) = ((*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_RoughnessIntensity) & ~FMainLightSetting.__PropertyMask_bOverride_RoughnessIntensity) | (value ? FMainLightSetting.__PropertyMask_bOverride_RoughnessIntensity : 0));
			}
		}

		// Token: 0x17006F75 RID: 28533
		// (get) Token: 0x0601BA44 RID: 113220 RVA: 0x0028AEB8 File Offset: 0x002890B8
		// (set) Token: 0x0601BA45 RID: 113221 RVA: 0x0028AED1 File Offset: 0x002890D1
		public unsafe bool bOverride_MetallicIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_MetallicIntensity) & FMainLightSetting.__PropertyMask_bOverride_MetallicIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_MetallicIntensity) = ((*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_MetallicIntensity) & ~FMainLightSetting.__PropertyMask_bOverride_MetallicIntensity) | (value ? FMainLightSetting.__PropertyMask_bOverride_MetallicIntensity : 0));
			}
		}

		// Token: 0x17006F76 RID: 28534
		// (get) Token: 0x0601BA46 RID: 113222 RVA: 0x0028AF01 File Offset: 0x00289101
		// (set) Token: 0x0601BA47 RID: 113223 RVA: 0x0028AF1A File Offset: 0x0028911A
		public unsafe bool bOverride_MetallicIntensityThreshold
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_MetallicIntensityThreshold) & FMainLightSetting.__PropertyMask_bOverride_MetallicIntensityThreshold) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_MetallicIntensityThreshold) = ((*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_MetallicIntensityThreshold) & ~FMainLightSetting.__PropertyMask_bOverride_MetallicIntensityThreshold) | (value ? FMainLightSetting.__PropertyMask_bOverride_MetallicIntensityThreshold : 0));
			}
		}

		// Token: 0x17006F77 RID: 28535
		// (get) Token: 0x0601BA48 RID: 113224 RVA: 0x0028AF4A File Offset: 0x0028914A
		// (set) Token: 0x0601BA49 RID: 113225 RVA: 0x0028AF63 File Offset: 0x00289163
		public unsafe bool bOverride_SceneObjectSaturation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_SceneObjectSaturation) & FMainLightSetting.__PropertyMask_bOverride_SceneObjectSaturation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_SceneObjectSaturation) = ((*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_SceneObjectSaturation) & ~FMainLightSetting.__PropertyMask_bOverride_SceneObjectSaturation) | (value ? FMainLightSetting.__PropertyMask_bOverride_SceneObjectSaturation : 0));
			}
		}

		// Token: 0x17006F78 RID: 28536
		// (get) Token: 0x0601BA4A RID: 113226 RVA: 0x0028AF93 File Offset: 0x00289193
		// (set) Token: 0x0601BA4B RID: 113227 RVA: 0x0028AFAC File Offset: 0x002891AC
		public unsafe bool bOverride_LightFunctionFadeDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_LightFunctionFadeDistance) & FMainLightSetting.__PropertyMask_bOverride_LightFunctionFadeDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_LightFunctionFadeDistance) = ((*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bOverride_LightFunctionFadeDistance) & ~FMainLightSetting.__PropertyMask_bOverride_LightFunctionFadeDistance) | (value ? FMainLightSetting.__PropertyMask_bOverride_LightFunctionFadeDistance : 0));
			}
		}

		// Token: 0x17006F79 RID: 28537
		// (get) Token: 0x0601BA4C RID: 113228 RVA: 0x0028AFDC File Offset: 0x002891DC
		// (set) Token: 0x0601BA4D RID: 113229 RVA: 0x0028AFEC File Offset: 0x002891EC
		public unsafe float MainLightIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_MainLightIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_MainLightIntensity) = value;
			}
		}

		// Token: 0x17006F7A RID: 28538
		// (get) Token: 0x0601BA4E RID: 113230 RVA: 0x0028AFFD File Offset: 0x002891FD
		// (set) Token: 0x0601BA4F RID: 113231 RVA: 0x0028B016 File Offset: 0x00289216
		public unsafe bool bInCave
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bInCave) & FMainLightSetting.__PropertyMask_bInCave) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bInCave) = ((*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bInCave) & ~FMainLightSetting.__PropertyMask_bInCave) | (value ? FMainLightSetting.__PropertyMask_bInCave : 0));
			}
		}

		// Token: 0x17006F7B RID: 28539
		// (get) Token: 0x0601BA50 RID: 113232 RVA: 0x0028B046 File Offset: 0x00289246
		// (set) Token: 0x0601BA51 RID: 113233 RVA: 0x0028B05F File Offset: 0x0028925F
		public unsafe bool bPCInCave
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bPCInCave) & FMainLightSetting.__PropertyMask_bPCInCave) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bPCInCave) = ((*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_bPCInCave) & ~FMainLightSetting.__PropertyMask_bPCInCave) | (value ? FMainLightSetting.__PropertyMask_bPCInCave : 0));
			}
		}

		// Token: 0x17006F7C RID: 28540
		// (get) Token: 0x0601BA52 RID: 113234 RVA: 0x0028B08F File Offset: 0x0028928F
		// (set) Token: 0x0601BA53 RID: 113235 RVA: 0x0028B0A3 File Offset: 0x002892A3
		public unsafe FLinearColor MainLightTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_MainLightTint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_MainLightTint) = value;
			}
		}

		// Token: 0x17006F7D RID: 28541
		// (get) Token: 0x0601BA54 RID: 113236 RVA: 0x0028B0B8 File Offset: 0x002892B8
		// (set) Token: 0x0601BA55 RID: 113237 RVA: 0x0028B0C8 File Offset: 0x002892C8
		public unsafe float MobileMainLightTintSaturation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_MobileMainLightTintSaturation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_MobileMainLightTintSaturation) = value;
			}
		}

		// Token: 0x17006F7E RID: 28542
		// (get) Token: 0x0601BA56 RID: 113238 RVA: 0x0028B0D9 File Offset: 0x002892D9
		// (set) Token: 0x0601BA57 RID: 113239 RVA: 0x0028B0E9 File Offset: 0x002892E9
		public unsafe float MobileMainLightTintValueMut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_MobileMainLightTintValueMut);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_MobileMainLightTintValueMut) = value;
			}
		}

		// Token: 0x17006F7F RID: 28543
		// (get) Token: 0x0601BA58 RID: 113240 RVA: 0x0028B0FA File Offset: 0x002892FA
		// (set) Token: 0x0601BA59 RID: 113241 RVA: 0x0028B10A File Offset: 0x0028930A
		public unsafe float MainLightTemperature
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_MainLightTemperature);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_MainLightTemperature) = value;
			}
		}

		// Token: 0x17006F80 RID: 28544
		// (get) Token: 0x0601BA5A RID: 113242 RVA: 0x0028B11B File Offset: 0x0028931B
		// (set) Token: 0x0601BA5B RID: 113243 RVA: 0x0028B12B File Offset: 0x0028932B
		public unsafe float MainLightSpecularIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_MainLightSpecularIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_MainLightSpecularIntensity) = value;
			}
		}

		// Token: 0x17006F81 RID: 28545
		// (get) Token: 0x0601BA5C RID: 113244 RVA: 0x0028B13C File Offset: 0x0028933C
		// (set) Token: 0x0601BA5D RID: 113245 RVA: 0x0028B14C File Offset: 0x0028934C
		public unsafe float DirLightSpecularIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_DirLightSpecularIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_DirLightSpecularIntensity) = value;
			}
		}

		// Token: 0x17006F82 RID: 28546
		// (get) Token: 0x0601BA5E RID: 113246 RVA: 0x0028B15D File Offset: 0x0028935D
		// (set) Token: 0x0601BA5F RID: 113247 RVA: 0x0028B16D File Offset: 0x0028936D
		public unsafe float ShadowTintIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_ShadowTintIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_ShadowTintIntensity) = value;
			}
		}

		// Token: 0x17006F83 RID: 28547
		// (get) Token: 0x0601BA60 RID: 113248 RVA: 0x0028B17E File Offset: 0x0028937E
		// (set) Token: 0x0601BA61 RID: 113249 RVA: 0x0028B192 File Offset: 0x00289392
		public unsafe FLinearColor ShadowTintColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_ShadowTintColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_ShadowTintColor) = value;
			}
		}

		// Token: 0x17006F84 RID: 28548
		// (get) Token: 0x0601BA62 RID: 113250 RVA: 0x0028B1A7 File Offset: 0x002893A7
		// (set) Token: 0x0601BA63 RID: 113251 RVA: 0x0028B1BB File Offset: 0x002893BB
		public unsafe FLinearColor NearMainLightColorPC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_NearMainLightColorPC);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_NearMainLightColorPC) = value;
			}
		}

		// Token: 0x17006F85 RID: 28549
		// (get) Token: 0x0601BA64 RID: 113252 RVA: 0x0028B1D0 File Offset: 0x002893D0
		// (set) Token: 0x0601BA65 RID: 113253 RVA: 0x0028B1E0 File Offset: 0x002893E0
		public unsafe float NearMainLightDistancePC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_NearMainLightDistancePC);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_NearMainLightDistancePC) = value;
			}
		}

		// Token: 0x17006F86 RID: 28550
		// (get) Token: 0x0601BA66 RID: 113254 RVA: 0x0028B1F1 File Offset: 0x002893F1
		// (set) Token: 0x0601BA67 RID: 113255 RVA: 0x0028B201 File Offset: 0x00289401
		public unsafe bool UseSepMobileNearMainLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_UseSepMobileNearMainLight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_UseSepMobileNearMainLight) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006F87 RID: 28551
		// (get) Token: 0x0601BA68 RID: 113256 RVA: 0x0028B212 File Offset: 0x00289412
		// (set) Token: 0x0601BA69 RID: 113257 RVA: 0x0028B226 File Offset: 0x00289426
		public unsafe FLinearColor NearMainLightColorMobile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_NearMainLightColorMobile);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_NearMainLightColorMobile) = value;
			}
		}

		// Token: 0x17006F88 RID: 28552
		// (get) Token: 0x0601BA6A RID: 113258 RVA: 0x0028B23B File Offset: 0x0028943B
		// (set) Token: 0x0601BA6B RID: 113259 RVA: 0x0028B24B File Offset: 0x0028944B
		public unsafe float NearMainLightDistanceMobile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_NearMainLightDistanceMobile);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_NearMainLightDistanceMobile) = value;
			}
		}

		// Token: 0x17006F89 RID: 28553
		// (get) Token: 0x0601BA6C RID: 113260 RVA: 0x0028B25C File Offset: 0x0028945C
		// (set) Token: 0x0601BA6D RID: 113261 RVA: 0x0028B26C File Offset: 0x0028946C
		public unsafe float RoughnessPowIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_RoughnessPowIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_RoughnessPowIntensity) = value;
			}
		}

		// Token: 0x17006F8A RID: 28554
		// (get) Token: 0x0601BA6E RID: 113262 RVA: 0x0028B27D File Offset: 0x0028947D
		// (set) Token: 0x0601BA6F RID: 113263 RVA: 0x0028B28D File Offset: 0x0028948D
		public unsafe float RoughnessPowIntensityThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_RoughnessPowIntensityThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_RoughnessPowIntensityThreshold) = value;
			}
		}

		// Token: 0x17006F8B RID: 28555
		// (get) Token: 0x0601BA70 RID: 113264 RVA: 0x0028B29E File Offset: 0x0028949E
		// (set) Token: 0x0601BA71 RID: 113265 RVA: 0x0028B2AE File Offset: 0x002894AE
		public unsafe float RoughnessIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_RoughnessIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_RoughnessIntensity) = value;
			}
		}

		// Token: 0x17006F8C RID: 28556
		// (get) Token: 0x0601BA72 RID: 113266 RVA: 0x0028B2BF File Offset: 0x002894BF
		// (set) Token: 0x0601BA73 RID: 113267 RVA: 0x0028B2CF File Offset: 0x002894CF
		public unsafe float MetallicIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_MetallicIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_MetallicIntensity) = value;
			}
		}

		// Token: 0x17006F8D RID: 28557
		// (get) Token: 0x0601BA74 RID: 113268 RVA: 0x0028B2E0 File Offset: 0x002894E0
		// (set) Token: 0x0601BA75 RID: 113269 RVA: 0x0028B2F0 File Offset: 0x002894F0
		public unsafe float MetallicIntensityThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_MetallicIntensityThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_MetallicIntensityThreshold) = value;
			}
		}

		// Token: 0x17006F8E RID: 28558
		// (get) Token: 0x0601BA76 RID: 113270 RVA: 0x0028B301 File Offset: 0x00289501
		// (set) Token: 0x0601BA77 RID: 113271 RVA: 0x0028B311 File Offset: 0x00289511
		public unsafe float SceneObjectSaturation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_SceneObjectSaturation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_SceneObjectSaturation) = value;
			}
		}

		// Token: 0x17006F8F RID: 28559
		// (get) Token: 0x0601BA78 RID: 113272 RVA: 0x0028B322 File Offset: 0x00289522
		// (set) Token: 0x0601BA79 RID: 113273 RVA: 0x0028B332 File Offset: 0x00289532
		public unsafe float LightFunctionFadeDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_LightFunctionFadeDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMainLightSetting.__PropertyOffset_LightFunctionFadeDistance) = value;
			}
		}

		// Token: 0x0601BA7A RID: 113274 RVA: 0x0028B343 File Offset: 0x00289543
		public FMainLightSetting()
		{
		}

		// Token: 0x0601BA7B RID: 113275 RVA: 0x0028B34C File Offset: 0x0028954C
		public FMainLightSetting(bool bOverride_MainLightIntensity, bool bOverride_MainLightTint, bool bOverride_MobileMainLightTintSaturation, bool bOverride_MobileMainLightTintValueMut, bool bOverride_MainLightTemperature, bool bOverride_MainLightSpecularIntensity, bool bOverride_DirLightSpecularIntensity, bool bOverride_ShadowTintIntensity, bool bOverride_ShadowTintColor, bool bOverride_NearMainLightColorPC, bool bOverride_NearMainLightDistancePC, bool bOverride_UseSeperateMobileNearMainLight, bool bOverride_NearMainLightColorMobile, bool bOverride_NearMainLightDistanceMobile, bool bOverride_RoughnessPowIntensity, bool bOverride_RoughnessPowIntensityThreshold, bool bOverride_RoughnessIntensity, bool bOverride_MetallicIntensity, bool bOverride_MetallicIntensityThreshold, bool bOverride_SceneObjectSaturation, bool bOverride_LightFunctionFadeDistance, float MainLightIntensity, bool bInCave, bool bPCInCave, FLinearColor MainLightTint, float MobileMainLightTintSaturation, float MobileMainLightTintValueMut, float MainLightTemperature, float MainLightSpecularIntensity, float DirLightSpecularIntensity, float ShadowTintIntensity, FLinearColor ShadowTintColor, FLinearColor NearMainLightColorPC, float NearMainLightDistancePC, bool UseSepMobileNearMainLight, FLinearColor NearMainLightColorMobile, float NearMainLightDistanceMobile, float RoughnessPowIntensity, float RoughnessPowIntensityThreshold, float RoughnessIntensity, float MetallicIntensity, float MetallicIntensityThreshold, float SceneObjectSaturation, float LightFunctionFadeDistance)
		{
			this.bOverride_MainLightIntensity = bOverride_MainLightIntensity;
			this.bOverride_MainLightTint = bOverride_MainLightTint;
			this.bOverride_MobileMainLightTintSaturation = bOverride_MobileMainLightTintSaturation;
			this.bOverride_MobileMainLightTintValueMut = bOverride_MobileMainLightTintValueMut;
			this.bOverride_MainLightTemperature = bOverride_MainLightTemperature;
			this.bOverride_MainLightSpecularIntensity = bOverride_MainLightSpecularIntensity;
			this.bOverride_DirLightSpecularIntensity = bOverride_DirLightSpecularIntensity;
			this.bOverride_ShadowTintIntensity = bOverride_ShadowTintIntensity;
			this.bOverride_ShadowTintColor = bOverride_ShadowTintColor;
			this.bOverride_NearMainLightColorPC = bOverride_NearMainLightColorPC;
			this.bOverride_NearMainLightDistancePC = bOverride_NearMainLightDistancePC;
			this.bOverride_UseSeperateMobileNearMainLight = bOverride_UseSeperateMobileNearMainLight;
			this.bOverride_NearMainLightColorMobile = bOverride_NearMainLightColorMobile;
			this.bOverride_NearMainLightDistanceMobile = bOverride_NearMainLightDistanceMobile;
			this.bOverride_RoughnessPowIntensity = bOverride_RoughnessPowIntensity;
			this.bOverride_RoughnessPowIntensityThreshold = bOverride_RoughnessPowIntensityThreshold;
			this.bOverride_RoughnessIntensity = bOverride_RoughnessIntensity;
			this.bOverride_MetallicIntensity = bOverride_MetallicIntensity;
			this.bOverride_MetallicIntensityThreshold = bOverride_MetallicIntensityThreshold;
			this.bOverride_SceneObjectSaturation = bOverride_SceneObjectSaturation;
			this.bOverride_LightFunctionFadeDistance = bOverride_LightFunctionFadeDistance;
			this.MainLightIntensity = MainLightIntensity;
			this.bInCave = bInCave;
			this.bPCInCave = bPCInCave;
			this.MainLightTint = MainLightTint;
			this.MobileMainLightTintSaturation = MobileMainLightTintSaturation;
			this.MobileMainLightTintValueMut = MobileMainLightTintValueMut;
			this.MainLightTemperature = MainLightTemperature;
			this.MainLightSpecularIntensity = MainLightSpecularIntensity;
			this.DirLightSpecularIntensity = DirLightSpecularIntensity;
			this.ShadowTintIntensity = ShadowTintIntensity;
			this.ShadowTintColor = ShadowTintColor;
			this.NearMainLightColorPC = NearMainLightColorPC;
			this.NearMainLightDistancePC = NearMainLightDistancePC;
			this.UseSepMobileNearMainLight = UseSepMobileNearMainLight;
			this.NearMainLightColorMobile = NearMainLightColorMobile;
			this.NearMainLightDistanceMobile = NearMainLightDistanceMobile;
			this.RoughnessPowIntensity = RoughnessPowIntensity;
			this.RoughnessPowIntensityThreshold = RoughnessPowIntensityThreshold;
			this.RoughnessIntensity = RoughnessIntensity;
			this.MetallicIntensity = MetallicIntensity;
			this.MetallicIntensityThreshold = MetallicIntensityThreshold;
			this.SceneObjectSaturation = SceneObjectSaturation;
			this.LightFunctionFadeDistance = LightFunctionFadeDistance;
		}

		// Token: 0x0601BA7C RID: 113276 RVA: 0x0028B4BC File Offset: 0x002896BC
		protected override IntPtr GetUStructPtr()
		{
			return FMainLightSetting.StaticStruct();
		}

		// Token: 0x0601BA7D RID: 113277 RVA: 0x0028B4C8 File Offset: 0x002896C8
		[NullableContext(2)]
		public FMainLightSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601BA7E RID: 113278 RVA: 0x0028B4D2 File Offset: 0x002896D2
		public FMainLightSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601BA7F RID: 113279 RVA: 0x0028B4DD File Offset: 0x002896DD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMainLightSetting(Pointer, false, true);
		}

		// Token: 0x0601BA80 RID: 113280 RVA: 0x0028B4E7 File Offset: 0x002896E7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMainLightSetting(Pointer, MemoryOwner);
		}

		// Token: 0x0400EDBB RID: 60859
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.MainLightSetting";

		// Token: 0x0400EDBC RID: 60860
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EDBD RID: 60861
		internal static int __PropertyOffset_bOverride_MainLightIntensity;

		// Token: 0x0400EDBE RID: 60862
		internal static byte __PropertyMask_bOverride_MainLightIntensity;

		// Token: 0x0400EDBF RID: 60863
		internal static int __PropertyOffset_bOverride_MainLightTint;

		// Token: 0x0400EDC0 RID: 60864
		internal static byte __PropertyMask_bOverride_MainLightTint;

		// Token: 0x0400EDC1 RID: 60865
		internal static int __PropertyOffset_bOverride_MobileMainLightTintSaturation;

		// Token: 0x0400EDC2 RID: 60866
		internal static byte __PropertyMask_bOverride_MobileMainLightTintSaturation;

		// Token: 0x0400EDC3 RID: 60867
		internal static int __PropertyOffset_bOverride_MobileMainLightTintValueMut;

		// Token: 0x0400EDC4 RID: 60868
		internal static byte __PropertyMask_bOverride_MobileMainLightTintValueMut;

		// Token: 0x0400EDC5 RID: 60869
		internal static int __PropertyOffset_bOverride_MainLightTemperature;

		// Token: 0x0400EDC6 RID: 60870
		internal static byte __PropertyMask_bOverride_MainLightTemperature;

		// Token: 0x0400EDC7 RID: 60871
		internal static int __PropertyOffset_bOverride_MainLightSpecularIntensity;

		// Token: 0x0400EDC8 RID: 60872
		internal static byte __PropertyMask_bOverride_MainLightSpecularIntensity;

		// Token: 0x0400EDC9 RID: 60873
		internal static int __PropertyOffset_bOverride_DirLightSpecularIntensity;

		// Token: 0x0400EDCA RID: 60874
		internal static byte __PropertyMask_bOverride_DirLightSpecularIntensity;

		// Token: 0x0400EDCB RID: 60875
		internal static int __PropertyOffset_bOverride_ShadowTintIntensity;

		// Token: 0x0400EDCC RID: 60876
		internal static byte __PropertyMask_bOverride_ShadowTintIntensity;

		// Token: 0x0400EDCD RID: 60877
		internal static int __PropertyOffset_bOverride_ShadowTintColor;

		// Token: 0x0400EDCE RID: 60878
		internal static byte __PropertyMask_bOverride_ShadowTintColor;

		// Token: 0x0400EDCF RID: 60879
		internal static int __PropertyOffset_bOverride_NearMainLightColorPC;

		// Token: 0x0400EDD0 RID: 60880
		internal static byte __PropertyMask_bOverride_NearMainLightColorPC;

		// Token: 0x0400EDD1 RID: 60881
		internal static int __PropertyOffset_bOverride_NearMainLightDistancePC;

		// Token: 0x0400EDD2 RID: 60882
		internal static byte __PropertyMask_bOverride_NearMainLightDistancePC;

		// Token: 0x0400EDD3 RID: 60883
		internal static int __PropertyOffset_bOverride_UseSeperateMobileNearMainLight;

		// Token: 0x0400EDD4 RID: 60884
		internal static byte __PropertyMask_bOverride_UseSeperateMobileNearMainLight;

		// Token: 0x0400EDD5 RID: 60885
		internal static int __PropertyOffset_bOverride_NearMainLightColorMobile;

		// Token: 0x0400EDD6 RID: 60886
		internal static byte __PropertyMask_bOverride_NearMainLightColorMobile;

		// Token: 0x0400EDD7 RID: 60887
		internal static int __PropertyOffset_bOverride_NearMainLightDistanceMobile;

		// Token: 0x0400EDD8 RID: 60888
		internal static byte __PropertyMask_bOverride_NearMainLightDistanceMobile;

		// Token: 0x0400EDD9 RID: 60889
		internal static int __PropertyOffset_bOverride_RoughnessPowIntensity;

		// Token: 0x0400EDDA RID: 60890
		internal static byte __PropertyMask_bOverride_RoughnessPowIntensity;

		// Token: 0x0400EDDB RID: 60891
		internal static int __PropertyOffset_bOverride_RoughnessPowIntensityThreshold;

		// Token: 0x0400EDDC RID: 60892
		internal static byte __PropertyMask_bOverride_RoughnessPowIntensityThreshold;

		// Token: 0x0400EDDD RID: 60893
		internal static int __PropertyOffset_bOverride_RoughnessIntensity;

		// Token: 0x0400EDDE RID: 60894
		internal static byte __PropertyMask_bOverride_RoughnessIntensity;

		// Token: 0x0400EDDF RID: 60895
		internal static int __PropertyOffset_bOverride_MetallicIntensity;

		// Token: 0x0400EDE0 RID: 60896
		internal static byte __PropertyMask_bOverride_MetallicIntensity;

		// Token: 0x0400EDE1 RID: 60897
		internal static int __PropertyOffset_bOverride_MetallicIntensityThreshold;

		// Token: 0x0400EDE2 RID: 60898
		internal static byte __PropertyMask_bOverride_MetallicIntensityThreshold;

		// Token: 0x0400EDE3 RID: 60899
		internal static int __PropertyOffset_bOverride_SceneObjectSaturation;

		// Token: 0x0400EDE4 RID: 60900
		internal static byte __PropertyMask_bOverride_SceneObjectSaturation;

		// Token: 0x0400EDE5 RID: 60901
		internal static int __PropertyOffset_bOverride_LightFunctionFadeDistance;

		// Token: 0x0400EDE6 RID: 60902
		internal static byte __PropertyMask_bOverride_LightFunctionFadeDistance;

		// Token: 0x0400EDE7 RID: 60903
		internal static int __PropertyOffset_MainLightIntensity;

		// Token: 0x0400EDE8 RID: 60904
		internal static int __PropertyOffset_bInCave;

		// Token: 0x0400EDE9 RID: 60905
		internal static byte __PropertyMask_bInCave;

		// Token: 0x0400EDEA RID: 60906
		internal static int __PropertyOffset_bPCInCave;

		// Token: 0x0400EDEB RID: 60907
		internal static byte __PropertyMask_bPCInCave;

		// Token: 0x0400EDEC RID: 60908
		internal static int __PropertyOffset_MainLightTint;

		// Token: 0x0400EDED RID: 60909
		internal static int __PropertyOffset_MobileMainLightTintSaturation;

		// Token: 0x0400EDEE RID: 60910
		internal static int __PropertyOffset_MobileMainLightTintValueMut;

		// Token: 0x0400EDEF RID: 60911
		internal static int __PropertyOffset_MainLightTemperature;

		// Token: 0x0400EDF0 RID: 60912
		internal static int __PropertyOffset_MainLightSpecularIntensity;

		// Token: 0x0400EDF1 RID: 60913
		internal static int __PropertyOffset_DirLightSpecularIntensity;

		// Token: 0x0400EDF2 RID: 60914
		internal static int __PropertyOffset_ShadowTintIntensity;

		// Token: 0x0400EDF3 RID: 60915
		internal static int __PropertyOffset_ShadowTintColor;

		// Token: 0x0400EDF4 RID: 60916
		internal static int __PropertyOffset_NearMainLightColorPC;

		// Token: 0x0400EDF5 RID: 60917
		internal static int __PropertyOffset_NearMainLightDistancePC;

		// Token: 0x0400EDF6 RID: 60918
		internal static int __PropertyOffset_UseSepMobileNearMainLight;

		// Token: 0x0400EDF7 RID: 60919
		internal static int __PropertyOffset_NearMainLightColorMobile;

		// Token: 0x0400EDF8 RID: 60920
		internal static int __PropertyOffset_NearMainLightDistanceMobile;

		// Token: 0x0400EDF9 RID: 60921
		internal static int __PropertyOffset_RoughnessPowIntensity;

		// Token: 0x0400EDFA RID: 60922
		internal static int __PropertyOffset_RoughnessPowIntensityThreshold;

		// Token: 0x0400EDFB RID: 60923
		internal static int __PropertyOffset_RoughnessIntensity;

		// Token: 0x0400EDFC RID: 60924
		internal static int __PropertyOffset_MetallicIntensity;

		// Token: 0x0400EDFD RID: 60925
		internal static int __PropertyOffset_MetallicIntensityThreshold;

		// Token: 0x0400EDFE RID: 60926
		internal static int __PropertyOffset_SceneObjectSaturation;

		// Token: 0x0400EDFF RID: 60927
		internal static int __PropertyOffset_LightFunctionFadeDistance;
	}
}
