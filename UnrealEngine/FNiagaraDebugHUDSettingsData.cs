using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002593 RID: 9619
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDebugHUDSettingsData")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 296)]
	public class FNiagaraDebugHUDSettingsData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023B1C RID: 146204 RVA: 0x0034C77F File Offset: 0x0034A97F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraDebugHUDSettingsData._ScriptStructPtr != 0) ? FNiagaraDebugHUDSettingsData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraDebugHUDSettingsData", ref FNiagaraDebugHUDSettingsData._ScriptStructPtr);
		}

		// Token: 0x1700890A RID: 35082
		// (get) Token: 0x06023B1D RID: 146205 RVA: 0x0034C7A3 File Offset: 0x0034A9A3
		// (set) Token: 0x06023B1E RID: 146206 RVA: 0x0034C7B3 File Offset: 0x0034A9B3
		public unsafe bool bHudEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_bHudEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_bHudEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700890B RID: 35083
		// (get) Token: 0x06023B1F RID: 146207 RVA: 0x0034C7C4 File Offset: 0x0034A9C4
		// (set) Token: 0x06023B20 RID: 146208 RVA: 0x0034C807 File Offset: 0x0034AA07
		public FNiagaraDebugHUDVariable ActorFilter
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraDebugHUDVariable result;
				if ((result = this._ActorFilter) == null)
				{
					result = (this._ActorFilter = new FNiagaraDebugHUDVariable(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_ActorFilter, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraDebugHUDVariable.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_ActorFilter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700890C RID: 35084
		// (get) Token: 0x06023B21 RID: 146209 RVA: 0x0034C828 File Offset: 0x0034AA28
		// (set) Token: 0x06023B22 RID: 146210 RVA: 0x0034C86B File Offset: 0x0034AA6B
		public FNiagaraDebugHUDVariable ComponentFilter
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraDebugHUDVariable result;
				if ((result = this._ComponentFilter) == null)
				{
					result = (this._ComponentFilter = new FNiagaraDebugHUDVariable(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_ComponentFilter, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraDebugHUDVariable.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_ComponentFilter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700890D RID: 35085
		// (get) Token: 0x06023B23 RID: 146211 RVA: 0x0034C88C File Offset: 0x0034AA8C
		// (set) Token: 0x06023B24 RID: 146212 RVA: 0x0034C8CF File Offset: 0x0034AACF
		public FNiagaraDebugHUDVariable SystemFilter
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraDebugHUDVariable result;
				if ((result = this._SystemFilter) == null)
				{
					result = (this._SystemFilter = new FNiagaraDebugHUDVariable(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_SystemFilter, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraDebugHUDVariable.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_SystemFilter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700890E RID: 35086
		// (get) Token: 0x06023B25 RID: 146213 RVA: 0x0034C8F0 File Offset: 0x0034AAF0
		// (set) Token: 0x06023B26 RID: 146214 RVA: 0x0034C900 File Offset: 0x0034AB00
		public unsafe float ComponentsShowDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_ComponentsShowDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_ComponentsShowDistance) = value;
			}
		}

		// Token: 0x1700890F RID: 35087
		// (get) Token: 0x06023B27 RID: 146215 RVA: 0x0034C911 File Offset: 0x0034AB11
		// (set) Token: 0x06023B28 RID: 146216 RVA: 0x0034C921 File Offset: 0x0034AB21
		public unsafe bool bShowOnlyActiveComponents
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_bShowOnlyActiveComponents) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_bShowOnlyActiveComponents) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008910 RID: 35088
		// (get) Token: 0x06023B29 RID: 146217 RVA: 0x0034C932 File Offset: 0x0034AB32
		// (set) Token: 0x06023B2A RID: 146218 RVA: 0x0034C942 File Offset: 0x0034AB42
		public unsafe bool bShowOnlyDownFrameComponents
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_bShowOnlyDownFrameComponents) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_bShowOnlyDownFrameComponents) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008911 RID: 35089
		// (get) Token: 0x06023B2B RID: 146219 RVA: 0x0034C953 File Offset: 0x0034AB53
		// (set) Token: 0x06023B2C RID: 146220 RVA: 0x0034C963 File Offset: 0x0034AB63
		public unsafe bool bShowOnlyIsNotPausedComponents
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_bShowOnlyIsNotPausedComponents) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_bShowOnlyIsNotPausedComponents) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008912 RID: 35090
		// (get) Token: 0x06023B2D RID: 146221 RVA: 0x0034C974 File Offset: 0x0034AB74
		// (set) Token: 0x06023B2E RID: 146222 RVA: 0x0034C984 File Offset: 0x0034AB84
		public unsafe bool bOverviewEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_bOverviewEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_bOverviewEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008913 RID: 35091
		// (get) Token: 0x06023B2F RID: 146223 RVA: 0x0034C995 File Offset: 0x0034AB95
		// (set) Token: 0x06023B30 RID: 146224 RVA: 0x0034C9A5 File Offset: 0x0034ABA5
		public unsafe ENiagaraDebugHUDOverviewMode OverviewMode
		{
			get
			{
				return (ENiagaraDebugHUDOverviewMode)(*(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_OverviewMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_OverviewMode) = (int)value;
			}
		}

		// Token: 0x17008914 RID: 35092
		// (get) Token: 0x06023B31 RID: 146225 RVA: 0x0034C9B6 File Offset: 0x0034ABB6
		// (set) Token: 0x06023B32 RID: 146226 RVA: 0x0034C9C6 File Offset: 0x0034ABC6
		public unsafe bool bShowRegisteredComponents
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_bShowRegisteredComponents) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_bShowRegisteredComponents) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008915 RID: 35093
		// (get) Token: 0x06023B33 RID: 146227 RVA: 0x0034C9D7 File Offset: 0x0034ABD7
		// (set) Token: 0x06023B34 RID: 146228 RVA: 0x0034C9E7 File Offset: 0x0034ABE7
		public unsafe int TolerantSecondsSinceAnyActive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_TolerantSecondsSinceAnyActive);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_TolerantSecondsSinceAnyActive) = value;
			}
		}

		// Token: 0x17008916 RID: 35094
		// (get) Token: 0x06023B35 RID: 146229 RVA: 0x0034C9F8 File Offset: 0x0034ABF8
		// (set) Token: 0x06023B36 RID: 146230 RVA: 0x0034CA08 File Offset: 0x0034AC08
		public unsafe bool bOverviewShowFilteredSystemOnly
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_bOverviewShowFilteredSystemOnly) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_bOverviewShowFilteredSystemOnly) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008917 RID: 35095
		// (get) Token: 0x06023B37 RID: 146231 RVA: 0x0034CA19 File Offset: 0x0034AC19
		// (set) Token: 0x06023B38 RID: 146232 RVA: 0x0034CA2D File Offset: 0x0034AC2D
		public unsafe FVector2D OverviewLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_OverviewLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_OverviewLocation) = value;
			}
		}

		// Token: 0x17008918 RID: 35096
		// (get) Token: 0x06023B39 RID: 146233 RVA: 0x0034CA42 File Offset: 0x0034AC42
		// (set) Token: 0x06023B3A RID: 146234 RVA: 0x0034CA52 File Offset: 0x0034AC52
		public unsafe bool bShowGPUParticleOnly
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_bShowGPUParticleOnly) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_bShowGPUParticleOnly) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008919 RID: 35097
		// (get) Token: 0x06023B3B RID: 146235 RVA: 0x0034CA63 File Offset: 0x0034AC63
		// (set) Token: 0x06023B3C RID: 146236 RVA: 0x0034CA73 File Offset: 0x0034AC73
		public unsafe bool bShowCPUParticleOnly
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_bShowCPUParticleOnly) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_bShowCPUParticleOnly) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700891A RID: 35098
		// (get) Token: 0x06023B3D RID: 146237 RVA: 0x0034CA84 File Offset: 0x0034AC84
		// (set) Token: 0x06023B3E RID: 146238 RVA: 0x0034CA94 File Offset: 0x0034AC94
		public unsafe bool bSortParticleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_bSortParticleCount) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_bSortParticleCount) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700891B RID: 35099
		// (get) Token: 0x06023B3F RID: 146239 RVA: 0x0034CAA5 File Offset: 0x0034ACA5
		// (set) Token: 0x06023B40 RID: 146240 RVA: 0x0034CAB5 File Offset: 0x0034ACB5
		public unsafe bool bSortEmitterCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_bSortEmitterCount) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_bSortEmitterCount) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700891C RID: 35100
		// (get) Token: 0x06023B41 RID: 146241 RVA: 0x0034CAC6 File Offset: 0x0034ACC6
		// (set) Token: 0x06023B42 RID: 146242 RVA: 0x0034CAD6 File Offset: 0x0034ACD6
		public unsafe bool bDebugComponentsEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_bDebugComponentsEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_bDebugComponentsEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700891D RID: 35101
		// (get) Token: 0x06023B43 RID: 146243 RVA: 0x0034CAE7 File Offset: 0x0034ACE7
		// (set) Token: 0x06023B44 RID: 146244 RVA: 0x0034CAF7 File Offset: 0x0034ACF7
		public unsafe ENiagaraDebugHudVerbosity SystemDebugVerbosity
		{
			get
			{
				return (ENiagaraDebugHudVerbosity)(*(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_SystemDebugVerbosity));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_SystemDebugVerbosity) = (int)value;
			}
		}

		// Token: 0x1700891E RID: 35102
		// (get) Token: 0x06023B45 RID: 146245 RVA: 0x0034CB08 File Offset: 0x0034AD08
		// (set) Token: 0x06023B46 RID: 146246 RVA: 0x0034CB18 File Offset: 0x0034AD18
		public unsafe ENiagaraDebugHudVerbosity SystemEmitterVerbosity
		{
			get
			{
				return (ENiagaraDebugHudVerbosity)(*(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_SystemEmitterVerbosity));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_SystemEmitterVerbosity) = (int)value;
			}
		}

		// Token: 0x1700891F RID: 35103
		// (get) Token: 0x06023B47 RID: 146247 RVA: 0x0034CB29 File Offset: 0x0034AD29
		// (set) Token: 0x06023B48 RID: 146248 RVA: 0x0034CB39 File Offset: 0x0034AD39
		public unsafe bool bSystemShowBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_bSystemShowBounds) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_bSystemShowBounds) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008920 RID: 35104
		// (get) Token: 0x06023B49 RID: 146249 RVA: 0x0034CB4A File Offset: 0x0034AD4A
		// (set) Token: 0x06023B4A RID: 146250 RVA: 0x0034CB5A File Offset: 0x0034AD5A
		public unsafe bool bDebugVariablesEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_bDebugVariablesEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_bDebugVariablesEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008921 RID: 35105
		// (get) Token: 0x06023B4B RID: 146251 RVA: 0x0034CB6C File Offset: 0x0034AD6C
		// (set) Token: 0x06023B4C RID: 146252 RVA: 0x0034CBAF File Offset: 0x0034ADAF
		public TArray<FNiagaraDebugHUDVariable> SystemVariablesFilter
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraDebugHUDVariable> result;
				if ((result = this._SystemVariablesFilter) == null)
				{
					result = (this._SystemVariablesFilter = new TArray<FNiagaraDebugHUDVariable>(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_SystemVariablesFilter, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SystemVariablesFilter.CopyAssign(value);
			}
		}

		// Token: 0x17008922 RID: 35106
		// (get) Token: 0x06023B4D RID: 146253 RVA: 0x0034CBC0 File Offset: 0x0034ADC0
		// (set) Token: 0x06023B4E RID: 146254 RVA: 0x0034CC03 File Offset: 0x0034AE03
		public TArray<FNiagaraDebugHUDVariable> ParticlesVariablesFilter
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraDebugHUDVariable> result;
				if ((result = this._ParticlesVariablesFilter) == null)
				{
					result = (this._ParticlesVariablesFilter = new TArray<FNiagaraDebugHUDVariable>(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_ParticlesVariablesFilter, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ParticlesVariablesFilter.CopyAssign(value);
			}
		}

		// Token: 0x17008923 RID: 35107
		// (get) Token: 0x06023B4F RID: 146255 RVA: 0x0034CC11 File Offset: 0x0034AE11
		// (set) Token: 0x06023B50 RID: 146256 RVA: 0x0034CC21 File Offset: 0x0034AE21
		public unsafe float ParticlesVariableClipDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_ParticlesVariableClipDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_ParticlesVariableClipDistance) = value;
			}
		}

		// Token: 0x17008924 RID: 35108
		// (get) Token: 0x06023B51 RID: 146257 RVA: 0x0034CC32 File Offset: 0x0034AE32
		// (set) Token: 0x06023B52 RID: 146258 RVA: 0x0034CC42 File Offset: 0x0034AE42
		public unsafe float ParticlesVariableClipScreenRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_ParticlesVariableClipScreenRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_ParticlesVariableClipScreenRatio) = value;
			}
		}

		// Token: 0x17008925 RID: 35109
		// (get) Token: 0x06023B53 RID: 146259 RVA: 0x0034CC53 File Offset: 0x0034AE53
		// (set) Token: 0x06023B54 RID: 146260 RVA: 0x0034CC63 File Offset: 0x0034AE63
		public unsafe int ParticlesVariablesMaxDisplay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_ParticlesVariablesMaxDisplay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_ParticlesVariablesMaxDisplay) = value;
			}
		}

		// Token: 0x17008926 RID: 35110
		// (get) Token: 0x06023B55 RID: 146261 RVA: 0x0034CC74 File Offset: 0x0034AE74
		// (set) Token: 0x06023B56 RID: 146262 RVA: 0x0034CC88 File Offset: 0x0034AE88
		public unsafe FColor BgColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_BgColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_BgColor) = value;
			}
		}

		// Token: 0x17008927 RID: 35111
		// (get) Token: 0x06023B57 RID: 146263 RVA: 0x0034CC9D File Offset: 0x0034AE9D
		// (set) Token: 0x06023B58 RID: 146264 RVA: 0x0034CCAD File Offset: 0x0034AEAD
		public unsafe ENiagaraDebugHudFont OverviewFont
		{
			get
			{
				return (ENiagaraDebugHudFont)(*(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_OverviewFont));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_OverviewFont) = (int)value;
			}
		}

		// Token: 0x17008928 RID: 35112
		// (get) Token: 0x06023B59 RID: 146265 RVA: 0x0034CCBE File Offset: 0x0034AEBE
		// (set) Token: 0x06023B5A RID: 146266 RVA: 0x0034CCD2 File Offset: 0x0034AED2
		public unsafe FLinearColor OverviewHeadingColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_OverviewHeadingColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_OverviewHeadingColor) = value;
			}
		}

		// Token: 0x17008929 RID: 35113
		// (get) Token: 0x06023B5B RID: 146267 RVA: 0x0034CCE7 File Offset: 0x0034AEE7
		// (set) Token: 0x06023B5C RID: 146268 RVA: 0x0034CCFB File Offset: 0x0034AEFB
		public unsafe FLinearColor OverviewDetailColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_OverviewDetailColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_OverviewDetailColor) = value;
			}
		}

		// Token: 0x1700892A RID: 35114
		// (get) Token: 0x06023B5D RID: 146269 RVA: 0x0034CD10 File Offset: 0x0034AF10
		// (set) Token: 0x06023B5E RID: 146270 RVA: 0x0034CD24 File Offset: 0x0034AF24
		public unsafe FLinearColor OverviewDetailHighlightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_OverviewDetailHighlightColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_OverviewDetailHighlightColor) = value;
			}
		}

		// Token: 0x1700892B RID: 35115
		// (get) Token: 0x06023B5F RID: 146271 RVA: 0x0034CD39 File Offset: 0x0034AF39
		// (set) Token: 0x06023B60 RID: 146272 RVA: 0x0034CD4D File Offset: 0x0034AF4D
		public unsafe FColor ComponentsTextColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_ComponentsTextColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_ComponentsTextColor) = value;
			}
		}

		// Token: 0x1700892C RID: 35116
		// (get) Token: 0x06023B61 RID: 146273 RVA: 0x0034CD62 File Offset: 0x0034AF62
		// (set) Token: 0x06023B62 RID: 146274 RVA: 0x0034CD72 File Offset: 0x0034AF72
		public unsafe float SystemColorTableOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_SystemColorTableOpacity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_SystemColorTableOpacity) = value;
			}
		}

		// Token: 0x1700892D RID: 35117
		// (get) Token: 0x06023B63 RID: 146275 RVA: 0x0034CD83 File Offset: 0x0034AF83
		// (set) Token: 0x06023B64 RID: 146276 RVA: 0x0034CD93 File Offset: 0x0034AF93
		public unsafe uint SystemColorSeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_SystemColorSeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_SystemColorSeed) = (int)value;
			}
		}

		// Token: 0x1700892E RID: 35118
		// (get) Token: 0x06023B65 RID: 146277 RVA: 0x0034CDA4 File Offset: 0x0034AFA4
		// (set) Token: 0x06023B66 RID: 146278 RVA: 0x0034CDB8 File Offset: 0x0034AFB8
		public unsafe FVector SystemColorHSVMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_SystemColorHSVMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_SystemColorHSVMin) = value;
			}
		}

		// Token: 0x1700892F RID: 35119
		// (get) Token: 0x06023B67 RID: 146279 RVA: 0x0034CDCD File Offset: 0x0034AFCD
		// (set) Token: 0x06023B68 RID: 146280 RVA: 0x0034CDE1 File Offset: 0x0034AFE1
		public unsafe FVector SystemColorHSVMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_SystemColorHSVMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_SystemColorHSVMax) = value;
			}
		}

		// Token: 0x17008930 RID: 35120
		// (get) Token: 0x06023B69 RID: 146281 RVA: 0x0034CDF8 File Offset: 0x0034AFF8
		// (set) Token: 0x06023B6A RID: 146282 RVA: 0x0034CE3B File Offset: 0x0034B03B
		public FNiagaraDebugHudTextOptions SystemTextOptions
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraDebugHudTextOptions result;
				if ((result = this._SystemTextOptions) == null)
				{
					result = (this._SystemTextOptions = new FNiagaraDebugHudTextOptions(base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_SystemTextOptions, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraDebugHudTextOptions.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraDebugHUDSettingsData.__PropertyOffset_SystemTextOptions, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06023B6B RID: 146283 RVA: 0x0034CE5C File Offset: 0x0034B05C
		public FNiagaraDebugHUDSettingsData()
		{
		}

		// Token: 0x06023B6C RID: 146284 RVA: 0x0034CE64 File Offset: 0x0034B064
		public FNiagaraDebugHUDSettingsData(bool bHudEnabled, FNiagaraDebugHUDVariable ActorFilter, FNiagaraDebugHUDVariable ComponentFilter, FNiagaraDebugHUDVariable SystemFilter, float ComponentsShowDistance, bool bShowOnlyActiveComponents, bool bShowOnlyDownFrameComponents, bool bShowOnlyIsNotPausedComponents, bool bOverviewEnabled, ENiagaraDebugHUDOverviewMode OverviewMode, bool bShowRegisteredComponents, int TolerantSecondsSinceAnyActive, bool bOverviewShowFilteredSystemOnly, FVector2D OverviewLocation, bool bShowGPUParticleOnly, bool bShowCPUParticleOnly, bool bSortParticleCount, bool bSortEmitterCount, bool bDebugComponentsEnabled, ENiagaraDebugHudVerbosity SystemDebugVerbosity, ENiagaraDebugHudVerbosity SystemEmitterVerbosity, bool bSystemShowBounds, bool bDebugVariablesEnabled, TArray<FNiagaraDebugHUDVariable> SystemVariablesFilter, TArray<FNiagaraDebugHUDVariable> ParticlesVariablesFilter, float ParticlesVariableClipDistance, float ParticlesVariableClipScreenRatio, int ParticlesVariablesMaxDisplay, FColor BgColor, ENiagaraDebugHudFont OverviewFont, FLinearColor OverviewHeadingColor, FLinearColor OverviewDetailColor, FLinearColor OverviewDetailHighlightColor, FColor ComponentsTextColor, float SystemColorTableOpacity, uint SystemColorSeed, FVector SystemColorHSVMin, FVector SystemColorHSVMax, FNiagaraDebugHudTextOptions SystemTextOptions)
		{
			this.bHudEnabled = bHudEnabled;
			this.ActorFilter = ActorFilter;
			this.ComponentFilter = ComponentFilter;
			this.SystemFilter = SystemFilter;
			this.ComponentsShowDistance = ComponentsShowDistance;
			this.bShowOnlyActiveComponents = bShowOnlyActiveComponents;
			this.bShowOnlyDownFrameComponents = bShowOnlyDownFrameComponents;
			this.bShowOnlyIsNotPausedComponents = bShowOnlyIsNotPausedComponents;
			this.bOverviewEnabled = bOverviewEnabled;
			this.OverviewMode = OverviewMode;
			this.bShowRegisteredComponents = bShowRegisteredComponents;
			this.TolerantSecondsSinceAnyActive = TolerantSecondsSinceAnyActive;
			this.bOverviewShowFilteredSystemOnly = bOverviewShowFilteredSystemOnly;
			this.OverviewLocation = OverviewLocation;
			this.bShowGPUParticleOnly = bShowGPUParticleOnly;
			this.bShowCPUParticleOnly = bShowCPUParticleOnly;
			this.bSortParticleCount = bSortParticleCount;
			this.bSortEmitterCount = bSortEmitterCount;
			this.bDebugComponentsEnabled = bDebugComponentsEnabled;
			this.SystemDebugVerbosity = SystemDebugVerbosity;
			this.SystemEmitterVerbosity = SystemEmitterVerbosity;
			this.bSystemShowBounds = bSystemShowBounds;
			this.bDebugVariablesEnabled = bDebugVariablesEnabled;
			this.SystemVariablesFilter = SystemVariablesFilter;
			this.ParticlesVariablesFilter = ParticlesVariablesFilter;
			this.ParticlesVariableClipDistance = ParticlesVariableClipDistance;
			this.ParticlesVariableClipScreenRatio = ParticlesVariableClipScreenRatio;
			this.ParticlesVariablesMaxDisplay = ParticlesVariablesMaxDisplay;
			this.BgColor = BgColor;
			this.OverviewFont = OverviewFont;
			this.OverviewHeadingColor = OverviewHeadingColor;
			this.OverviewDetailColor = OverviewDetailColor;
			this.OverviewDetailHighlightColor = OverviewDetailHighlightColor;
			this.ComponentsTextColor = ComponentsTextColor;
			this.SystemColorTableOpacity = SystemColorTableOpacity;
			this.SystemColorSeed = SystemColorSeed;
			this.SystemColorHSVMin = SystemColorHSVMin;
			this.SystemColorHSVMax = SystemColorHSVMax;
			this.SystemTextOptions = SystemTextOptions;
		}

		// Token: 0x06023B6D RID: 146285 RVA: 0x0034CFAC File Offset: 0x0034B1AC
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraDebugHUDSettingsData.StaticStruct();
		}

		// Token: 0x06023B6E RID: 146286 RVA: 0x0034CFB8 File Offset: 0x0034B1B8
		[NullableContext(2)]
		public FNiagaraDebugHUDSettingsData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023B6F RID: 146287 RVA: 0x0034CFC2 File Offset: 0x0034B1C2
		public FNiagaraDebugHUDSettingsData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023B70 RID: 146288 RVA: 0x0034CFCD File Offset: 0x0034B1CD
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraDebugHUDSettingsData(Pointer, false, true);
		}

		// Token: 0x06023B71 RID: 146289 RVA: 0x0034CFD7 File Offset: 0x0034B1D7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraDebugHUDSettingsData(Pointer, MemoryOwner);
		}

		// Token: 0x04013244 RID: 78404
		public const string __ObjectPath = "/Script/Niagara.NiagaraDebugHUDSettingsData";

		// Token: 0x04013245 RID: 78405
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013246 RID: 78406
		internal static int __PropertyOffset_bHudEnabled;

		// Token: 0x04013247 RID: 78407
		internal static int __PropertyOffset_ActorFilter;

		// Token: 0x04013248 RID: 78408
		[Nullable(2)]
		private FNiagaraDebugHUDVariable _ActorFilter;

		// Token: 0x04013249 RID: 78409
		internal static int __PropertyOffset_ComponentFilter;

		// Token: 0x0401324A RID: 78410
		[Nullable(2)]
		private FNiagaraDebugHUDVariable _ComponentFilter;

		// Token: 0x0401324B RID: 78411
		internal static int __PropertyOffset_SystemFilter;

		// Token: 0x0401324C RID: 78412
		[Nullable(2)]
		private FNiagaraDebugHUDVariable _SystemFilter;

		// Token: 0x0401324D RID: 78413
		internal static int __PropertyOffset_ComponentsShowDistance;

		// Token: 0x0401324E RID: 78414
		internal static int __PropertyOffset_bShowOnlyActiveComponents;

		// Token: 0x0401324F RID: 78415
		internal static int __PropertyOffset_bShowOnlyDownFrameComponents;

		// Token: 0x04013250 RID: 78416
		internal static int __PropertyOffset_bShowOnlyIsNotPausedComponents;

		// Token: 0x04013251 RID: 78417
		internal static int __PropertyOffset_bOverviewEnabled;

		// Token: 0x04013252 RID: 78418
		internal static int __PropertyOffset_OverviewMode;

		// Token: 0x04013253 RID: 78419
		internal static int __PropertyOffset_bShowRegisteredComponents;

		// Token: 0x04013254 RID: 78420
		internal static int __PropertyOffset_TolerantSecondsSinceAnyActive;

		// Token: 0x04013255 RID: 78421
		internal static int __PropertyOffset_bOverviewShowFilteredSystemOnly;

		// Token: 0x04013256 RID: 78422
		internal static int __PropertyOffset_OverviewLocation;

		// Token: 0x04013257 RID: 78423
		internal static int __PropertyOffset_bShowGPUParticleOnly;

		// Token: 0x04013258 RID: 78424
		internal static int __PropertyOffset_bShowCPUParticleOnly;

		// Token: 0x04013259 RID: 78425
		internal static int __PropertyOffset_bSortParticleCount;

		// Token: 0x0401325A RID: 78426
		internal static int __PropertyOffset_bSortEmitterCount;

		// Token: 0x0401325B RID: 78427
		internal static int __PropertyOffset_bDebugComponentsEnabled;

		// Token: 0x0401325C RID: 78428
		internal static int __PropertyOffset_SystemDebugVerbosity;

		// Token: 0x0401325D RID: 78429
		internal static int __PropertyOffset_SystemEmitterVerbosity;

		// Token: 0x0401325E RID: 78430
		internal static int __PropertyOffset_bSystemShowBounds;

		// Token: 0x0401325F RID: 78431
		internal static int __PropertyOffset_bDebugVariablesEnabled;

		// Token: 0x04013260 RID: 78432
		internal static int __PropertyOffset_SystemVariablesFilter;

		// Token: 0x04013261 RID: 78433
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraDebugHUDVariable> _SystemVariablesFilter;

		// Token: 0x04013262 RID: 78434
		internal static int __PropertyOffset_ParticlesVariablesFilter;

		// Token: 0x04013263 RID: 78435
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraDebugHUDVariable> _ParticlesVariablesFilter;

		// Token: 0x04013264 RID: 78436
		internal static int __PropertyOffset_ParticlesVariableClipDistance;

		// Token: 0x04013265 RID: 78437
		internal static int __PropertyOffset_ParticlesVariableClipScreenRatio;

		// Token: 0x04013266 RID: 78438
		internal static int __PropertyOffset_ParticlesVariablesMaxDisplay;

		// Token: 0x04013267 RID: 78439
		internal static int __PropertyOffset_BgColor;

		// Token: 0x04013268 RID: 78440
		internal static int __PropertyOffset_OverviewFont;

		// Token: 0x04013269 RID: 78441
		internal static int __PropertyOffset_OverviewHeadingColor;

		// Token: 0x0401326A RID: 78442
		internal static int __PropertyOffset_OverviewDetailColor;

		// Token: 0x0401326B RID: 78443
		internal static int __PropertyOffset_OverviewDetailHighlightColor;

		// Token: 0x0401326C RID: 78444
		internal static int __PropertyOffset_ComponentsTextColor;

		// Token: 0x0401326D RID: 78445
		internal static int __PropertyOffset_SystemColorTableOpacity;

		// Token: 0x0401326E RID: 78446
		internal static int __PropertyOffset_SystemColorSeed;

		// Token: 0x0401326F RID: 78447
		internal static int __PropertyOffset_SystemColorHSVMin;

		// Token: 0x04013270 RID: 78448
		internal static int __PropertyOffset_SystemColorHSVMax;

		// Token: 0x04013271 RID: 78449
		internal static int __PropertyOffset_SystemTextOptions;

		// Token: 0x04013272 RID: 78450
		[Nullable(2)]
		private FNiagaraDebugHudTextOptions _SystemTextOptions;
	}
}
