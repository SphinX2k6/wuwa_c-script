using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018CD RID: 6349
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroEffectPostProcessSkyBoxSetting")]
	[UnrealStructLayout(8416, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8416)]
	public class FKuroEffectPostProcessSkyBoxSetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06017773 RID: 96115 RVA: 0x00225242 File Offset: 0x00223442
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroEffectPostProcessSkyBoxSetting._ScriptStructPtr != 0) ? FKuroEffectPostProcessSkyBoxSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.KuroEffectPostProcessSkyBoxSetting", ref FKuroEffectPostProcessSkyBoxSetting._ScriptStructPtr);
		}

		// Token: 0x17005EAC RID: 24236
		// (get) Token: 0x06017774 RID: 96116 RVA: 0x00225266 File Offset: 0x00223466
		// (set) Token: 0x06017775 RID: 96117 RVA: 0x0022527F File Offset: 0x0022347F
		public unsafe bool bOverride_ZenithColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_ZenithColor) & FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_ZenithColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_ZenithColor) = ((*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_ZenithColor) & ~FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_ZenithColor) | (value ? FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_ZenithColor : 0));
			}
		}

		// Token: 0x17005EAD RID: 24237
		// (get) Token: 0x06017776 RID: 96118 RVA: 0x002252AF File Offset: 0x002234AF
		// (set) Token: 0x06017777 RID: 96119 RVA: 0x002252C8 File Offset: 0x002234C8
		public unsafe bool bOverride_NadirColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_NadirColor) & FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_NadirColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_NadirColor) = ((*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_NadirColor) & ~FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_NadirColor) | (value ? FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_NadirColor : 0));
			}
		}

		// Token: 0x17005EAE RID: 24238
		// (get) Token: 0x06017778 RID: 96120 RVA: 0x002252F8 File Offset: 0x002234F8
		// (set) Token: 0x06017779 RID: 96121 RVA: 0x00225311 File Offset: 0x00223511
		public unsafe bool bOverride_NadirFalloff
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_NadirFalloff) & FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_NadirFalloff) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_NadirFalloff) = ((*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_NadirFalloff) & ~FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_NadirFalloff) | (value ? FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_NadirFalloff : 0));
			}
		}

		// Token: 0x17005EAF RID: 24239
		// (get) Token: 0x0601777A RID: 96122 RVA: 0x00225341 File Offset: 0x00223541
		// (set) Token: 0x0601777B RID: 96123 RVA: 0x0022535A File Offset: 0x0022355A
		public unsafe bool bOverride_NadirFalloff_Mobile
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_NadirFalloff_Mobile) & FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_NadirFalloff_Mobile) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_NadirFalloff_Mobile) = ((*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_NadirFalloff_Mobile) & ~FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_NadirFalloff_Mobile) | (value ? FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_NadirFalloff_Mobile : 0));
			}
		}

		// Token: 0x17005EB0 RID: 24240
		// (get) Token: 0x0601777C RID: 96124 RVA: 0x0022538A File Offset: 0x0022358A
		// (set) Token: 0x0601777D RID: 96125 RVA: 0x002253A3 File Offset: 0x002235A3
		public unsafe bool bOverride_HorizonColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_HorizonColor) & FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_HorizonColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_HorizonColor) = ((*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_HorizonColor) & ~FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_HorizonColor) | (value ? FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_HorizonColor : 0));
			}
		}

		// Token: 0x17005EB1 RID: 24241
		// (get) Token: 0x0601777E RID: 96126 RVA: 0x002253D3 File Offset: 0x002235D3
		// (set) Token: 0x0601777F RID: 96127 RVA: 0x002253EC File Offset: 0x002235EC
		public unsafe bool bOverride_HorizonFalloff
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_HorizonFalloff) & FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_HorizonFalloff) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_HorizonFalloff) = ((*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_HorizonFalloff) & ~FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_HorizonFalloff) | (value ? FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_HorizonFalloff : 0));
			}
		}

		// Token: 0x17005EB2 RID: 24242
		// (get) Token: 0x06017780 RID: 96128 RVA: 0x0022541C File Offset: 0x0022361C
		// (set) Token: 0x06017781 RID: 96129 RVA: 0x00225435 File Offset: 0x00223635
		public unsafe bool bOverride_TopColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_TopColor) & FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_TopColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_TopColor) = ((*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_TopColor) & ~FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_TopColor) | (value ? FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_TopColor : 0));
			}
		}

		// Token: 0x17005EB3 RID: 24243
		// (get) Token: 0x06017782 RID: 96130 RVA: 0x00225465 File Offset: 0x00223665
		// (set) Token: 0x06017783 RID: 96131 RVA: 0x0022547E File Offset: 0x0022367E
		public unsafe bool bOverride_TopFalloff
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_TopFalloff) & FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_TopFalloff) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_TopFalloff) = ((*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_TopFalloff) & ~FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_TopFalloff) | (value ? FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_TopFalloff : 0));
			}
		}

		// Token: 0x17005EB4 RID: 24244
		// (get) Token: 0x06017784 RID: 96132 RVA: 0x002254AE File Offset: 0x002236AE
		// (set) Token: 0x06017785 RID: 96133 RVA: 0x002254C7 File Offset: 0x002236C7
		public unsafe bool bOverride_TopColorMobile
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_TopColorMobile) & FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_TopColorMobile) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_TopColorMobile) = ((*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_TopColorMobile) & ~FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_TopColorMobile) | (value ? FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_TopColorMobile : 0));
			}
		}

		// Token: 0x17005EB5 RID: 24245
		// (get) Token: 0x06017786 RID: 96134 RVA: 0x002254F7 File Offset: 0x002236F7
		// (set) Token: 0x06017787 RID: 96135 RVA: 0x00225510 File Offset: 0x00223710
		public unsafe bool bOverride_TopFalloffMobile
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_TopFalloffMobile) & FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_TopFalloffMobile) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_TopFalloffMobile) = ((*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_TopFalloffMobile) & ~FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_TopFalloffMobile) | (value ? FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_TopFalloffMobile : 0));
			}
		}

		// Token: 0x17005EB6 RID: 24246
		// (get) Token: 0x06017788 RID: 96136 RVA: 0x00225540 File Offset: 0x00223740
		// (set) Token: 0x06017789 RID: 96137 RVA: 0x00225559 File Offset: 0x00223759
		public unsafe bool bOverride_SunDiscColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_SunDiscColor) & FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_SunDiscColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_SunDiscColor) = ((*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_SunDiscColor) & ~FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_SunDiscColor) | (value ? FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_SunDiscColor : 0));
			}
		}

		// Token: 0x17005EB7 RID: 24247
		// (get) Token: 0x0601778A RID: 96138 RVA: 0x00225589 File Offset: 0x00223789
		// (set) Token: 0x0601778B RID: 96139 RVA: 0x002255A2 File Offset: 0x002237A2
		public unsafe bool bOverride_SunScatterColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_SunScatterColor) & FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_SunScatterColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_SunScatterColor) = ((*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_SunScatterColor) & ~FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_SunScatterColor) | (value ? FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_SunScatterColor : 0));
			}
		}

		// Token: 0x17005EB8 RID: 24248
		// (get) Token: 0x0601778C RID: 96140 RVA: 0x002255D2 File Offset: 0x002237D2
		// (set) Token: 0x0601778D RID: 96141 RVA: 0x002255EB File Offset: 0x002237EB
		public unsafe bool bOverride_SunSize
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_SunSize) & FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_SunSize) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_SunSize) = ((*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_SunSize) & ~FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_SunSize) | (value ? FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_SunSize : 0));
			}
		}

		// Token: 0x17005EB9 RID: 24249
		// (get) Token: 0x0601778E RID: 96142 RVA: 0x0022561B File Offset: 0x0022381B
		// (set) Token: 0x0601778F RID: 96143 RVA: 0x00225634 File Offset: 0x00223834
		public unsafe bool bOverride_SunScatterSize
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_SunScatterSize) & FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_SunScatterSize) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_SunScatterSize) = ((*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_SunScatterSize) & ~FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_SunScatterSize) | (value ? FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_SunScatterSize : 0));
			}
		}

		// Token: 0x17005EBA RID: 24250
		// (get) Token: 0x06017790 RID: 96144 RVA: 0x00225664 File Offset: 0x00223864
		// (set) Token: 0x06017791 RID: 96145 RVA: 0x0022567D File Offset: 0x0022387D
		public unsafe bool bOverride_SunMeshScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_SunMeshScale) & FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_SunMeshScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_SunMeshScale) = ((*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_SunMeshScale) & ~FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_SunMeshScale) | (value ? FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_SunMeshScale : 0));
			}
		}

		// Token: 0x17005EBB RID: 24251
		// (get) Token: 0x06017792 RID: 96146 RVA: 0x002256AD File Offset: 0x002238AD
		// (set) Token: 0x06017793 RID: 96147 RVA: 0x002256C6 File Offset: 0x002238C6
		public unsafe bool bOverride_SunMeshColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_SunMeshColor) & FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_SunMeshColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_SunMeshColor) = ((*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_SunMeshColor) & ~FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_SunMeshColor) | (value ? FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_SunMeshColor : 0));
			}
		}

		// Token: 0x17005EBC RID: 24252
		// (get) Token: 0x06017794 RID: 96148 RVA: 0x002256F6 File Offset: 0x002238F6
		// (set) Token: 0x06017795 RID: 96149 RVA: 0x0022570F File Offset: 0x0022390F
		public unsafe bool bOverride_MoonTexture
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_MoonTexture) & FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_MoonTexture) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_MoonTexture) = ((*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_MoonTexture) & ~FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_MoonTexture) | (value ? FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_MoonTexture : 0));
			}
		}

		// Token: 0x17005EBD RID: 24253
		// (get) Token: 0x06017796 RID: 96150 RVA: 0x0022573F File Offset: 0x0022393F
		// (set) Token: 0x06017797 RID: 96151 RVA: 0x00225758 File Offset: 0x00223958
		public unsafe bool bOverride_MoonPhase
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_MoonPhase) & FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_MoonPhase) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_MoonPhase) = ((*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_MoonPhase) & ~FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_MoonPhase) | (value ? FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_MoonPhase : 0));
			}
		}

		// Token: 0x17005EBE RID: 24254
		// (get) Token: 0x06017798 RID: 96152 RVA: 0x00225788 File Offset: 0x00223988
		// (set) Token: 0x06017799 RID: 96153 RVA: 0x002257A1 File Offset: 0x002239A1
		public unsafe bool bOverride_MoonDiscColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_MoonDiscColor) & FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_MoonDiscColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_MoonDiscColor) = ((*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_MoonDiscColor) & ~FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_MoonDiscColor) | (value ? FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_MoonDiscColor : 0));
			}
		}

		// Token: 0x17005EBF RID: 24255
		// (get) Token: 0x0601779A RID: 96154 RVA: 0x002257D1 File Offset: 0x002239D1
		// (set) Token: 0x0601779B RID: 96155 RVA: 0x002257EA File Offset: 0x002239EA
		public unsafe bool bOverride_MoonScatterColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_MoonScatterColor) & FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_MoonScatterColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_MoonScatterColor) = ((*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_MoonScatterColor) & ~FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_MoonScatterColor) | (value ? FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_MoonScatterColor : 0));
			}
		}

		// Token: 0x17005EC0 RID: 24256
		// (get) Token: 0x0601779C RID: 96156 RVA: 0x0022581A File Offset: 0x00223A1A
		// (set) Token: 0x0601779D RID: 96157 RVA: 0x00225833 File Offset: 0x00223A33
		public unsafe bool bOverride_MoonSize
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_MoonSize) & FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_MoonSize) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_MoonSize) = ((*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_MoonSize) & ~FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_MoonSize) | (value ? FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_MoonSize : 0));
			}
		}

		// Token: 0x17005EC1 RID: 24257
		// (get) Token: 0x0601779E RID: 96158 RVA: 0x00225863 File Offset: 0x00223A63
		// (set) Token: 0x0601779F RID: 96159 RVA: 0x0022587C File Offset: 0x00223A7C
		public unsafe bool bOverride_MoonScatterSize
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_MoonScatterSize) & FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_MoonScatterSize) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_MoonScatterSize) = ((*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_MoonScatterSize) & ~FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_MoonScatterSize) | (value ? FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_MoonScatterSize : 0));
			}
		}

		// Token: 0x17005EC2 RID: 24258
		// (get) Token: 0x060177A0 RID: 96160 RVA: 0x002258AC File Offset: 0x00223AAC
		// (set) Token: 0x060177A1 RID: 96161 RVA: 0x002258C5 File Offset: 0x00223AC5
		public unsafe bool bOverride_ExtremeWeatherWeight
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_ExtremeWeatherWeight) & FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_ExtremeWeatherWeight) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_ExtremeWeatherWeight) = ((*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_ExtremeWeatherWeight) & ~FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_ExtremeWeatherWeight) | (value ? FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_ExtremeWeatherWeight : 0));
			}
		}

		// Token: 0x17005EC3 RID: 24259
		// (get) Token: 0x060177A2 RID: 96162 RVA: 0x002258F5 File Offset: 0x00223AF5
		// (set) Token: 0x060177A3 RID: 96163 RVA: 0x0022590E File Offset: 0x00223B0E
		public unsafe bool bOverride_ST_TopColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_ST_TopColor) & FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_ST_TopColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_ST_TopColor) = ((*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_ST_TopColor) & ~FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_ST_TopColor) | (value ? FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_ST_TopColor : 0));
			}
		}

		// Token: 0x17005EC4 RID: 24260
		// (get) Token: 0x060177A4 RID: 96164 RVA: 0x0022593E File Offset: 0x00223B3E
		// (set) Token: 0x060177A5 RID: 96165 RVA: 0x00225957 File Offset: 0x00223B57
		public unsafe bool bOverride_ST_DomeColorTint
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_ST_DomeColorTint) & FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_ST_DomeColorTint) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_ST_DomeColorTint) = ((*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_ST_DomeColorTint) & ~FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_ST_DomeColorTint) | (value ? FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_ST_DomeColorTint : 0));
			}
		}

		// Token: 0x17005EC5 RID: 24261
		// (get) Token: 0x060177A6 RID: 96166 RVA: 0x00225987 File Offset: 0x00223B87
		// (set) Token: 0x060177A7 RID: 96167 RVA: 0x002259A0 File Offset: 0x00223BA0
		public unsafe bool bOverride_ST_TopWidth
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_ST_TopWidth) & FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_ST_TopWidth) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_ST_TopWidth) = ((*(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_bOverride_ST_TopWidth) & ~FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_ST_TopWidth) | (value ? FKuroEffectPostProcessSkyBoxSetting.__PropertyMask_bOverride_ST_TopWidth : 0));
			}
		}

		// Token: 0x17005EC6 RID: 24262
		// (get) Token: 0x060177A8 RID: 96168 RVA: 0x002259D0 File Offset: 0x00223BD0
		// (set) Token: 0x060177A9 RID: 96169 RVA: 0x00225A13 File Offset: 0x00223C13
		public FKuroCurveLinearColor ZenithColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._ZenithColor) == null)
				{
					result = (this._ZenithColor = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_ZenithColor, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_ZenithColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005EC7 RID: 24263
		// (get) Token: 0x060177AA RID: 96170 RVA: 0x00225A34 File Offset: 0x00223C34
		// (set) Token: 0x060177AB RID: 96171 RVA: 0x00225A77 File Offset: 0x00223C77
		public FKuroCurveLinearColor NadirColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._NadirColor) == null)
				{
					result = (this._NadirColor = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_NadirColor, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_NadirColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005EC8 RID: 24264
		// (get) Token: 0x060177AC RID: 96172 RVA: 0x00225A98 File Offset: 0x00223C98
		// (set) Token: 0x060177AD RID: 96173 RVA: 0x00225ADB File Offset: 0x00223CDB
		public FKuroCurveFloat NadirFalloff
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._NadirFalloff) == null)
				{
					result = (this._NadirFalloff = new FKuroCurveFloat(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_NadirFalloff, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_NadirFalloff, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005EC9 RID: 24265
		// (get) Token: 0x060177AE RID: 96174 RVA: 0x00225AFC File Offset: 0x00223CFC
		// (set) Token: 0x060177AF RID: 96175 RVA: 0x00225B3F File Offset: 0x00223D3F
		public FKuroCurveFloat NadirFalloff_Mobile
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._NadirFalloff_Mobile) == null)
				{
					result = (this._NadirFalloff_Mobile = new FKuroCurveFloat(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_NadirFalloff_Mobile, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_NadirFalloff_Mobile, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005ECA RID: 24266
		// (get) Token: 0x060177B0 RID: 96176 RVA: 0x00225B60 File Offset: 0x00223D60
		// (set) Token: 0x060177B1 RID: 96177 RVA: 0x00225BA3 File Offset: 0x00223DA3
		public FKuroCurveLinearColor HorizonColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._HorizonColor) == null)
				{
					result = (this._HorizonColor = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_HorizonColor, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_HorizonColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005ECB RID: 24267
		// (get) Token: 0x060177B2 RID: 96178 RVA: 0x00225BC4 File Offset: 0x00223DC4
		// (set) Token: 0x060177B3 RID: 96179 RVA: 0x00225C07 File Offset: 0x00223E07
		public FKuroCurveFloat HorizonFalloff
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._HorizonFalloff) == null)
				{
					result = (this._HorizonFalloff = new FKuroCurveFloat(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_HorizonFalloff, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_HorizonFalloff, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005ECC RID: 24268
		// (get) Token: 0x060177B4 RID: 96180 RVA: 0x00225C28 File Offset: 0x00223E28
		// (set) Token: 0x060177B5 RID: 96181 RVA: 0x00225C6B File Offset: 0x00223E6B
		public FKuroCurveLinearColor TopColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._TopColor) == null)
				{
					result = (this._TopColor = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_TopColor, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_TopColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005ECD RID: 24269
		// (get) Token: 0x060177B6 RID: 96182 RVA: 0x00225C8C File Offset: 0x00223E8C
		// (set) Token: 0x060177B7 RID: 96183 RVA: 0x00225CCF File Offset: 0x00223ECF
		public FKuroCurveFloat TopFalloff
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._TopFalloff) == null)
				{
					result = (this._TopFalloff = new FKuroCurveFloat(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_TopFalloff, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_TopFalloff, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005ECE RID: 24270
		// (get) Token: 0x060177B8 RID: 96184 RVA: 0x00225CF0 File Offset: 0x00223EF0
		// (set) Token: 0x060177B9 RID: 96185 RVA: 0x00225D33 File Offset: 0x00223F33
		public FKuroCurveLinearColor TopColorMobile
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._TopColorMobile) == null)
				{
					result = (this._TopColorMobile = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_TopColorMobile, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_TopColorMobile, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005ECF RID: 24271
		// (get) Token: 0x060177BA RID: 96186 RVA: 0x00225D54 File Offset: 0x00223F54
		// (set) Token: 0x060177BB RID: 96187 RVA: 0x00225D97 File Offset: 0x00223F97
		public FKuroCurveFloat TopFalloffMobile
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._TopFalloffMobile) == null)
				{
					result = (this._TopFalloffMobile = new FKuroCurveFloat(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_TopFalloffMobile, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_TopFalloffMobile, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005ED0 RID: 24272
		// (get) Token: 0x060177BC RID: 96188 RVA: 0x00225DB8 File Offset: 0x00223FB8
		// (set) Token: 0x060177BD RID: 96189 RVA: 0x00225DFB File Offset: 0x00223FFB
		public FKuroCurveLinearColor SunDiscColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._SunDiscColor) == null)
				{
					result = (this._SunDiscColor = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_SunDiscColor, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_SunDiscColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005ED1 RID: 24273
		// (get) Token: 0x060177BE RID: 96190 RVA: 0x00225E1C File Offset: 0x0022401C
		// (set) Token: 0x060177BF RID: 96191 RVA: 0x00225E5F File Offset: 0x0022405F
		public FKuroCurveLinearColor SunScatterColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._SunScatterColor) == null)
				{
					result = (this._SunScatterColor = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_SunScatterColor, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_SunScatterColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005ED2 RID: 24274
		// (get) Token: 0x060177C0 RID: 96192 RVA: 0x00225E80 File Offset: 0x00224080
		// (set) Token: 0x060177C1 RID: 96193 RVA: 0x00225EC3 File Offset: 0x002240C3
		public FKuroCurveFloat SunSize
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._SunSize) == null)
				{
					result = (this._SunSize = new FKuroCurveFloat(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_SunSize, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_SunSize, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005ED3 RID: 24275
		// (get) Token: 0x060177C2 RID: 96194 RVA: 0x00225EE4 File Offset: 0x002240E4
		// (set) Token: 0x060177C3 RID: 96195 RVA: 0x00225F27 File Offset: 0x00224127
		public FKuroCurveFloat SunScatterSize
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._SunScatterSize) == null)
				{
					result = (this._SunScatterSize = new FKuroCurveFloat(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_SunScatterSize, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_SunScatterSize, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005ED4 RID: 24276
		// (get) Token: 0x060177C4 RID: 96196 RVA: 0x00225F48 File Offset: 0x00224148
		// (set) Token: 0x060177C5 RID: 96197 RVA: 0x00225F8B File Offset: 0x0022418B
		public FKuroCurveFloat SunMeshScale
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._SunMeshScale) == null)
				{
					result = (this._SunMeshScale = new FKuroCurveFloat(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_SunMeshScale, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_SunMeshScale, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005ED5 RID: 24277
		// (get) Token: 0x060177C6 RID: 96198 RVA: 0x00225FAC File Offset: 0x002241AC
		// (set) Token: 0x060177C7 RID: 96199 RVA: 0x00225FEF File Offset: 0x002241EF
		public FKuroCurveLinearColor SunMeshColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._SunMeshColor) == null)
				{
					result = (this._SunMeshColor = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_SunMeshColor, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_SunMeshColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005ED6 RID: 24278
		// (get) Token: 0x060177C8 RID: 96200 RVA: 0x00226010 File Offset: 0x00224210
		// (set) Token: 0x060177C9 RID: 96201 RVA: 0x00226053 File Offset: 0x00224253
		public FKuroCurveLinearColor MoonDiscColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._MoonDiscColor) == null)
				{
					result = (this._MoonDiscColor = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_MoonDiscColor, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_MoonDiscColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005ED7 RID: 24279
		// (get) Token: 0x060177CA RID: 96202 RVA: 0x00226074 File Offset: 0x00224274
		// (set) Token: 0x060177CB RID: 96203 RVA: 0x00226088 File Offset: 0x00224288
		[Nullable(2)]
		public unsafe UTexture2D MoonTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_MoonTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_MoonTexture, value);
			}
		}

		// Token: 0x17005ED8 RID: 24280
		// (get) Token: 0x060177CC RID: 96204 RVA: 0x002260A0 File Offset: 0x002242A0
		// (set) Token: 0x060177CD RID: 96205 RVA: 0x002260E3 File Offset: 0x002242E3
		public FKuroCurveFloat MoonPhase
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._MoonPhase) == null)
				{
					result = (this._MoonPhase = new FKuroCurveFloat(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_MoonPhase, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_MoonPhase, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005ED9 RID: 24281
		// (get) Token: 0x060177CE RID: 96206 RVA: 0x00226104 File Offset: 0x00224304
		// (set) Token: 0x060177CF RID: 96207 RVA: 0x00226147 File Offset: 0x00224347
		public FKuroCurveLinearColor MoonScatterColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._MoonScatterColor) == null)
				{
					result = (this._MoonScatterColor = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_MoonScatterColor, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_MoonScatterColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005EDA RID: 24282
		// (get) Token: 0x060177D0 RID: 96208 RVA: 0x00226168 File Offset: 0x00224368
		// (set) Token: 0x060177D1 RID: 96209 RVA: 0x002261AB File Offset: 0x002243AB
		public FKuroCurveFloat MoonSize
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._MoonSize) == null)
				{
					result = (this._MoonSize = new FKuroCurveFloat(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_MoonSize, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_MoonSize, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005EDB RID: 24283
		// (get) Token: 0x060177D2 RID: 96210 RVA: 0x002261CC File Offset: 0x002243CC
		// (set) Token: 0x060177D3 RID: 96211 RVA: 0x0022620F File Offset: 0x0022440F
		public FKuroCurveFloat MoonScatterSize
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._MoonScatterSize) == null)
				{
					result = (this._MoonScatterSize = new FKuroCurveFloat(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_MoonScatterSize, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_MoonScatterSize, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005EDC RID: 24284
		// (get) Token: 0x060177D4 RID: 96212 RVA: 0x00226230 File Offset: 0x00224430
		// (set) Token: 0x060177D5 RID: 96213 RVA: 0x00226273 File Offset: 0x00224473
		public FKuroCurveFloat ExtremeWeatherWeight
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._ExtremeWeatherWeight) == null)
				{
					result = (this._ExtremeWeatherWeight = new FKuroCurveFloat(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_ExtremeWeatherWeight, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_ExtremeWeatherWeight, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005EDD RID: 24285
		// (get) Token: 0x060177D6 RID: 96214 RVA: 0x00226294 File Offset: 0x00224494
		// (set) Token: 0x060177D7 RID: 96215 RVA: 0x002262D7 File Offset: 0x002244D7
		public FKuroCurveLinearColor ST_TopColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._ST_TopColor) == null)
				{
					result = (this._ST_TopColor = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_ST_TopColor, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_ST_TopColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005EDE RID: 24286
		// (get) Token: 0x060177D8 RID: 96216 RVA: 0x002262F8 File Offset: 0x002244F8
		// (set) Token: 0x060177D9 RID: 96217 RVA: 0x0022633B File Offset: 0x0022453B
		public FKuroCurveLinearColor ST_DomeColorTint
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._ST_DomeColorTint) == null)
				{
					result = (this._ST_DomeColorTint = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_ST_DomeColorTint, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_ST_DomeColorTint, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005EDF RID: 24287
		// (get) Token: 0x060177DA RID: 96218 RVA: 0x0022635C File Offset: 0x0022455C
		// (set) Token: 0x060177DB RID: 96219 RVA: 0x0022639F File Offset: 0x0022459F
		public FKuroCurveFloat ST_TopWidth
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._ST_TopWidth) == null)
				{
					result = (this._ST_TopWidth = new FKuroCurveFloat(base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_ST_TopWidth, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)FKuroEffectPostProcessSkyBoxSetting.__PropertyOffset_ST_TopWidth, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060177DC RID: 96220 RVA: 0x002263C0 File Offset: 0x002245C0
		public FKuroEffectPostProcessSkyBoxSetting()
		{
		}

		// Token: 0x060177DD RID: 96221 RVA: 0x002263C8 File Offset: 0x002245C8
		public FKuroEffectPostProcessSkyBoxSetting(bool bOverride_ZenithColor, bool bOverride_NadirColor, bool bOverride_NadirFalloff, bool bOverride_NadirFalloff_Mobile, bool bOverride_HorizonColor, bool bOverride_HorizonFalloff, bool bOverride_TopColor, bool bOverride_TopFalloff, bool bOverride_TopColorMobile, bool bOverride_TopFalloffMobile, bool bOverride_SunDiscColor, bool bOverride_SunScatterColor, bool bOverride_SunSize, bool bOverride_SunScatterSize, bool bOverride_SunMeshScale, bool bOverride_SunMeshColor, bool bOverride_MoonTexture, bool bOverride_MoonPhase, bool bOverride_MoonDiscColor, bool bOverride_MoonScatterColor, bool bOverride_MoonSize, bool bOverride_MoonScatterSize, bool bOverride_ExtremeWeatherWeight, bool bOverride_ST_TopColor, bool bOverride_ST_DomeColorTint, bool bOverride_ST_TopWidth, FKuroCurveLinearColor ZenithColor, FKuroCurveLinearColor NadirColor, FKuroCurveFloat NadirFalloff, FKuroCurveFloat NadirFalloff_Mobile, FKuroCurveLinearColor HorizonColor, FKuroCurveFloat HorizonFalloff, FKuroCurveLinearColor TopColor, FKuroCurveFloat TopFalloff, FKuroCurveLinearColor TopColorMobile, FKuroCurveFloat TopFalloffMobile, FKuroCurveLinearColor SunDiscColor, FKuroCurveLinearColor SunScatterColor, FKuroCurveFloat SunSize, FKuroCurveFloat SunScatterSize, FKuroCurveFloat SunMeshScale, FKuroCurveLinearColor SunMeshColor, FKuroCurveLinearColor MoonDiscColor, UTexture2D MoonTexture, FKuroCurveFloat MoonPhase, FKuroCurveLinearColor MoonScatterColor, FKuroCurveFloat MoonSize, FKuroCurveFloat MoonScatterSize, FKuroCurveFloat ExtremeWeatherWeight, FKuroCurveLinearColor ST_TopColor, FKuroCurveLinearColor ST_DomeColorTint, FKuroCurveFloat ST_TopWidth)
		{
			this.bOverride_ZenithColor = bOverride_ZenithColor;
			this.bOverride_NadirColor = bOverride_NadirColor;
			this.bOverride_NadirFalloff = bOverride_NadirFalloff;
			this.bOverride_NadirFalloff_Mobile = bOverride_NadirFalloff_Mobile;
			this.bOverride_HorizonColor = bOverride_HorizonColor;
			this.bOverride_HorizonFalloff = bOverride_HorizonFalloff;
			this.bOverride_TopColor = bOverride_TopColor;
			this.bOverride_TopFalloff = bOverride_TopFalloff;
			this.bOverride_TopColorMobile = bOverride_TopColorMobile;
			this.bOverride_TopFalloffMobile = bOverride_TopFalloffMobile;
			this.bOverride_SunDiscColor = bOverride_SunDiscColor;
			this.bOverride_SunScatterColor = bOverride_SunScatterColor;
			this.bOverride_SunSize = bOverride_SunSize;
			this.bOverride_SunScatterSize = bOverride_SunScatterSize;
			this.bOverride_SunMeshScale = bOverride_SunMeshScale;
			this.bOverride_SunMeshColor = bOverride_SunMeshColor;
			this.bOverride_MoonTexture = bOverride_MoonTexture;
			this.bOverride_MoonPhase = bOverride_MoonPhase;
			this.bOverride_MoonDiscColor = bOverride_MoonDiscColor;
			this.bOverride_MoonScatterColor = bOverride_MoonScatterColor;
			this.bOverride_MoonSize = bOverride_MoonSize;
			this.bOverride_MoonScatterSize = bOverride_MoonScatterSize;
			this.bOverride_ExtremeWeatherWeight = bOverride_ExtremeWeatherWeight;
			this.bOverride_ST_TopColor = bOverride_ST_TopColor;
			this.bOverride_ST_DomeColorTint = bOverride_ST_DomeColorTint;
			this.bOverride_ST_TopWidth = bOverride_ST_TopWidth;
			this.ZenithColor = ZenithColor;
			this.NadirColor = NadirColor;
			this.NadirFalloff = NadirFalloff;
			this.NadirFalloff_Mobile = NadirFalloff_Mobile;
			this.HorizonColor = HorizonColor;
			this.HorizonFalloff = HorizonFalloff;
			this.TopColor = TopColor;
			this.TopFalloff = TopFalloff;
			this.TopColorMobile = TopColorMobile;
			this.TopFalloffMobile = TopFalloffMobile;
			this.SunDiscColor = SunDiscColor;
			this.SunScatterColor = SunScatterColor;
			this.SunSize = SunSize;
			this.SunScatterSize = SunScatterSize;
			this.SunMeshScale = SunMeshScale;
			this.SunMeshColor = SunMeshColor;
			this.MoonDiscColor = MoonDiscColor;
			this.MoonTexture = MoonTexture;
			this.MoonPhase = MoonPhase;
			this.MoonScatterColor = MoonScatterColor;
			this.MoonSize = MoonSize;
			this.MoonScatterSize = MoonScatterSize;
			this.ExtremeWeatherWeight = ExtremeWeatherWeight;
			this.ST_TopColor = ST_TopColor;
			this.ST_DomeColorTint = ST_DomeColorTint;
			this.ST_TopWidth = ST_TopWidth;
		}

		// Token: 0x060177DE RID: 96222 RVA: 0x00226578 File Offset: 0x00224778
		protected override IntPtr GetUStructPtr()
		{
			return FKuroEffectPostProcessSkyBoxSetting.StaticStruct();
		}

		// Token: 0x060177DF RID: 96223 RVA: 0x00226584 File Offset: 0x00224784
		[NullableContext(2)]
		public FKuroEffectPostProcessSkyBoxSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060177E0 RID: 96224 RVA: 0x0022658E File Offset: 0x0022478E
		public FKuroEffectPostProcessSkyBoxSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060177E1 RID: 96225 RVA: 0x00226599 File Offset: 0x00224799
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroEffectPostProcessSkyBoxSetting(Pointer, false, true);
		}

		// Token: 0x060177E2 RID: 96226 RVA: 0x002265A3 File Offset: 0x002247A3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroEffectPostProcessSkyBoxSetting(Pointer, MemoryOwner);
		}

		// Token: 0x0400CC11 RID: 52241
		public const string __ObjectPath = "/Script/KuroGameplay.KuroEffectPostProcessSkyBoxSetting";

		// Token: 0x0400CC12 RID: 52242
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400CC13 RID: 52243
		internal static int __PropertyOffset_bOverride_ZenithColor;

		// Token: 0x0400CC14 RID: 52244
		internal static byte __PropertyMask_bOverride_ZenithColor;

		// Token: 0x0400CC15 RID: 52245
		internal static int __PropertyOffset_bOverride_NadirColor;

		// Token: 0x0400CC16 RID: 52246
		internal static byte __PropertyMask_bOverride_NadirColor;

		// Token: 0x0400CC17 RID: 52247
		internal static int __PropertyOffset_bOverride_NadirFalloff;

		// Token: 0x0400CC18 RID: 52248
		internal static byte __PropertyMask_bOverride_NadirFalloff;

		// Token: 0x0400CC19 RID: 52249
		internal static int __PropertyOffset_bOverride_NadirFalloff_Mobile;

		// Token: 0x0400CC1A RID: 52250
		internal static byte __PropertyMask_bOverride_NadirFalloff_Mobile;

		// Token: 0x0400CC1B RID: 52251
		internal static int __PropertyOffset_bOverride_HorizonColor;

		// Token: 0x0400CC1C RID: 52252
		internal static byte __PropertyMask_bOverride_HorizonColor;

		// Token: 0x0400CC1D RID: 52253
		internal static int __PropertyOffset_bOverride_HorizonFalloff;

		// Token: 0x0400CC1E RID: 52254
		internal static byte __PropertyMask_bOverride_HorizonFalloff;

		// Token: 0x0400CC1F RID: 52255
		internal static int __PropertyOffset_bOverride_TopColor;

		// Token: 0x0400CC20 RID: 52256
		internal static byte __PropertyMask_bOverride_TopColor;

		// Token: 0x0400CC21 RID: 52257
		internal static int __PropertyOffset_bOverride_TopFalloff;

		// Token: 0x0400CC22 RID: 52258
		internal static byte __PropertyMask_bOverride_TopFalloff;

		// Token: 0x0400CC23 RID: 52259
		internal static int __PropertyOffset_bOverride_TopColorMobile;

		// Token: 0x0400CC24 RID: 52260
		internal static byte __PropertyMask_bOverride_TopColorMobile;

		// Token: 0x0400CC25 RID: 52261
		internal static int __PropertyOffset_bOverride_TopFalloffMobile;

		// Token: 0x0400CC26 RID: 52262
		internal static byte __PropertyMask_bOverride_TopFalloffMobile;

		// Token: 0x0400CC27 RID: 52263
		internal static int __PropertyOffset_bOverride_SunDiscColor;

		// Token: 0x0400CC28 RID: 52264
		internal static byte __PropertyMask_bOverride_SunDiscColor;

		// Token: 0x0400CC29 RID: 52265
		internal static int __PropertyOffset_bOverride_SunScatterColor;

		// Token: 0x0400CC2A RID: 52266
		internal static byte __PropertyMask_bOverride_SunScatterColor;

		// Token: 0x0400CC2B RID: 52267
		internal static int __PropertyOffset_bOverride_SunSize;

		// Token: 0x0400CC2C RID: 52268
		internal static byte __PropertyMask_bOverride_SunSize;

		// Token: 0x0400CC2D RID: 52269
		internal static int __PropertyOffset_bOverride_SunScatterSize;

		// Token: 0x0400CC2E RID: 52270
		internal static byte __PropertyMask_bOverride_SunScatterSize;

		// Token: 0x0400CC2F RID: 52271
		internal static int __PropertyOffset_bOverride_SunMeshScale;

		// Token: 0x0400CC30 RID: 52272
		internal static byte __PropertyMask_bOverride_SunMeshScale;

		// Token: 0x0400CC31 RID: 52273
		internal static int __PropertyOffset_bOverride_SunMeshColor;

		// Token: 0x0400CC32 RID: 52274
		internal static byte __PropertyMask_bOverride_SunMeshColor;

		// Token: 0x0400CC33 RID: 52275
		internal static int __PropertyOffset_bOverride_MoonTexture;

		// Token: 0x0400CC34 RID: 52276
		internal static byte __PropertyMask_bOverride_MoonTexture;

		// Token: 0x0400CC35 RID: 52277
		internal static int __PropertyOffset_bOverride_MoonPhase;

		// Token: 0x0400CC36 RID: 52278
		internal static byte __PropertyMask_bOverride_MoonPhase;

		// Token: 0x0400CC37 RID: 52279
		internal static int __PropertyOffset_bOverride_MoonDiscColor;

		// Token: 0x0400CC38 RID: 52280
		internal static byte __PropertyMask_bOverride_MoonDiscColor;

		// Token: 0x0400CC39 RID: 52281
		internal static int __PropertyOffset_bOverride_MoonScatterColor;

		// Token: 0x0400CC3A RID: 52282
		internal static byte __PropertyMask_bOverride_MoonScatterColor;

		// Token: 0x0400CC3B RID: 52283
		internal static int __PropertyOffset_bOverride_MoonSize;

		// Token: 0x0400CC3C RID: 52284
		internal static byte __PropertyMask_bOverride_MoonSize;

		// Token: 0x0400CC3D RID: 52285
		internal static int __PropertyOffset_bOverride_MoonScatterSize;

		// Token: 0x0400CC3E RID: 52286
		internal static byte __PropertyMask_bOverride_MoonScatterSize;

		// Token: 0x0400CC3F RID: 52287
		internal static int __PropertyOffset_bOverride_ExtremeWeatherWeight;

		// Token: 0x0400CC40 RID: 52288
		internal static byte __PropertyMask_bOverride_ExtremeWeatherWeight;

		// Token: 0x0400CC41 RID: 52289
		internal static int __PropertyOffset_bOverride_ST_TopColor;

		// Token: 0x0400CC42 RID: 52290
		internal static byte __PropertyMask_bOverride_ST_TopColor;

		// Token: 0x0400CC43 RID: 52291
		internal static int __PropertyOffset_bOverride_ST_DomeColorTint;

		// Token: 0x0400CC44 RID: 52292
		internal static byte __PropertyMask_bOverride_ST_DomeColorTint;

		// Token: 0x0400CC45 RID: 52293
		internal static int __PropertyOffset_bOverride_ST_TopWidth;

		// Token: 0x0400CC46 RID: 52294
		internal static byte __PropertyMask_bOverride_ST_TopWidth;

		// Token: 0x0400CC47 RID: 52295
		internal static int __PropertyOffset_ZenithColor;

		// Token: 0x0400CC48 RID: 52296
		[Nullable(2)]
		private FKuroCurveLinearColor _ZenithColor;

		// Token: 0x0400CC49 RID: 52297
		internal static int __PropertyOffset_NadirColor;

		// Token: 0x0400CC4A RID: 52298
		[Nullable(2)]
		private FKuroCurveLinearColor _NadirColor;

		// Token: 0x0400CC4B RID: 52299
		internal static int __PropertyOffset_NadirFalloff;

		// Token: 0x0400CC4C RID: 52300
		[Nullable(2)]
		private FKuroCurveFloat _NadirFalloff;

		// Token: 0x0400CC4D RID: 52301
		internal static int __PropertyOffset_NadirFalloff_Mobile;

		// Token: 0x0400CC4E RID: 52302
		[Nullable(2)]
		private FKuroCurveFloat _NadirFalloff_Mobile;

		// Token: 0x0400CC4F RID: 52303
		internal static int __PropertyOffset_HorizonColor;

		// Token: 0x0400CC50 RID: 52304
		[Nullable(2)]
		private FKuroCurveLinearColor _HorizonColor;

		// Token: 0x0400CC51 RID: 52305
		internal static int __PropertyOffset_HorizonFalloff;

		// Token: 0x0400CC52 RID: 52306
		[Nullable(2)]
		private FKuroCurveFloat _HorizonFalloff;

		// Token: 0x0400CC53 RID: 52307
		internal static int __PropertyOffset_TopColor;

		// Token: 0x0400CC54 RID: 52308
		[Nullable(2)]
		private FKuroCurveLinearColor _TopColor;

		// Token: 0x0400CC55 RID: 52309
		internal static int __PropertyOffset_TopFalloff;

		// Token: 0x0400CC56 RID: 52310
		[Nullable(2)]
		private FKuroCurveFloat _TopFalloff;

		// Token: 0x0400CC57 RID: 52311
		internal static int __PropertyOffset_TopColorMobile;

		// Token: 0x0400CC58 RID: 52312
		[Nullable(2)]
		private FKuroCurveLinearColor _TopColorMobile;

		// Token: 0x0400CC59 RID: 52313
		internal static int __PropertyOffset_TopFalloffMobile;

		// Token: 0x0400CC5A RID: 52314
		[Nullable(2)]
		private FKuroCurveFloat _TopFalloffMobile;

		// Token: 0x0400CC5B RID: 52315
		internal static int __PropertyOffset_SunDiscColor;

		// Token: 0x0400CC5C RID: 52316
		[Nullable(2)]
		private FKuroCurveLinearColor _SunDiscColor;

		// Token: 0x0400CC5D RID: 52317
		internal static int __PropertyOffset_SunScatterColor;

		// Token: 0x0400CC5E RID: 52318
		[Nullable(2)]
		private FKuroCurveLinearColor _SunScatterColor;

		// Token: 0x0400CC5F RID: 52319
		internal static int __PropertyOffset_SunSize;

		// Token: 0x0400CC60 RID: 52320
		[Nullable(2)]
		private FKuroCurveFloat _SunSize;

		// Token: 0x0400CC61 RID: 52321
		internal static int __PropertyOffset_SunScatterSize;

		// Token: 0x0400CC62 RID: 52322
		[Nullable(2)]
		private FKuroCurveFloat _SunScatterSize;

		// Token: 0x0400CC63 RID: 52323
		internal static int __PropertyOffset_SunMeshScale;

		// Token: 0x0400CC64 RID: 52324
		[Nullable(2)]
		private FKuroCurveFloat _SunMeshScale;

		// Token: 0x0400CC65 RID: 52325
		internal static int __PropertyOffset_SunMeshColor;

		// Token: 0x0400CC66 RID: 52326
		[Nullable(2)]
		private FKuroCurveLinearColor _SunMeshColor;

		// Token: 0x0400CC67 RID: 52327
		internal static int __PropertyOffset_MoonDiscColor;

		// Token: 0x0400CC68 RID: 52328
		[Nullable(2)]
		private FKuroCurveLinearColor _MoonDiscColor;

		// Token: 0x0400CC69 RID: 52329
		internal static int __PropertyOffset_MoonTexture;

		// Token: 0x0400CC6A RID: 52330
		internal static int __PropertyOffset_MoonPhase;

		// Token: 0x0400CC6B RID: 52331
		[Nullable(2)]
		private FKuroCurveFloat _MoonPhase;

		// Token: 0x0400CC6C RID: 52332
		internal static int __PropertyOffset_MoonScatterColor;

		// Token: 0x0400CC6D RID: 52333
		[Nullable(2)]
		private FKuroCurveLinearColor _MoonScatterColor;

		// Token: 0x0400CC6E RID: 52334
		internal static int __PropertyOffset_MoonSize;

		// Token: 0x0400CC6F RID: 52335
		[Nullable(2)]
		private FKuroCurveFloat _MoonSize;

		// Token: 0x0400CC70 RID: 52336
		internal static int __PropertyOffset_MoonScatterSize;

		// Token: 0x0400CC71 RID: 52337
		[Nullable(2)]
		private FKuroCurveFloat _MoonScatterSize;

		// Token: 0x0400CC72 RID: 52338
		internal static int __PropertyOffset_ExtremeWeatherWeight;

		// Token: 0x0400CC73 RID: 52339
		[Nullable(2)]
		private FKuroCurveFloat _ExtremeWeatherWeight;

		// Token: 0x0400CC74 RID: 52340
		internal static int __PropertyOffset_ST_TopColor;

		// Token: 0x0400CC75 RID: 52341
		[Nullable(2)]
		private FKuroCurveLinearColor _ST_TopColor;

		// Token: 0x0400CC76 RID: 52342
		internal static int __PropertyOffset_ST_DomeColorTint;

		// Token: 0x0400CC77 RID: 52343
		[Nullable(2)]
		private FKuroCurveLinearColor _ST_DomeColorTint;

		// Token: 0x0400CC78 RID: 52344
		internal static int __PropertyOffset_ST_TopWidth;

		// Token: 0x0400CC79 RID: 52345
		[Nullable(2)]
		private FKuroCurveFloat _ST_TopWidth;
	}
}
