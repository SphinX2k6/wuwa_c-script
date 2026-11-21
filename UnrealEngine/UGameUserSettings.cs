using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000217 RID: 535
	[UnrealObjectPath("/Script/Engine.GameUserSettings")]
	[UnrealStructLayout(472, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class UGameUserSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002365 RID: 9061 RVA: 0x00033BA3 File Offset: 0x00031DA3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameUserSettings._ClassPtr;
		}

		// Token: 0x06002366 RID: 9062 RVA: 0x00033BB0 File Offset: 0x00031DB0
		public UGameUserSettings() : this(BuiltinUtils.AllocNativeUObject(UGameUserSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002367 RID: 9063 RVA: 0x00033BD8 File Offset: 0x00031DD8
		[NullableContext(1)]
		public UGameUserSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGameUserSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06002368 RID: 9064 RVA: 0x00033C0B File Offset: 0x00031E0B
		// (set) Token: 0x06002369 RID: 9065 RVA: 0x00033C1B File Offset: 0x00031E1B
		public unsafe bool bUseVSync
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_bUseVSync) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_bUseVSync) = (value ? 1 : 0);
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x0600236A RID: 9066 RVA: 0x00033C2C File Offset: 0x00031E2C
		// (set) Token: 0x0600236B RID: 9067 RVA: 0x00033C3C File Offset: 0x00031E3C
		public unsafe bool bUseDynamicResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_bUseDynamicResolution) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_bUseDynamicResolution) = (value ? 1 : 0);
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x0600236C RID: 9068 RVA: 0x00033C4D File Offset: 0x00031E4D
		// (set) Token: 0x0600236D RID: 9069 RVA: 0x00033C5D File Offset: 0x00031E5D
		public unsafe uint ResolutionSizeX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_ResolutionSizeX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_ResolutionSizeX) = (int)value;
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x0600236E RID: 9070 RVA: 0x00033C6E File Offset: 0x00031E6E
		// (set) Token: 0x0600236F RID: 9071 RVA: 0x00033C7E File Offset: 0x00031E7E
		public unsafe uint ResolutionSizeY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_ResolutionSizeY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_ResolutionSizeY) = (int)value;
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06002370 RID: 9072 RVA: 0x00033C8F File Offset: 0x00031E8F
		// (set) Token: 0x06002371 RID: 9073 RVA: 0x00033C9F File Offset: 0x00031E9F
		public unsafe uint LastUserConfirmedResolutionSizeX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_LastUserConfirmedResolutionSizeX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_LastUserConfirmedResolutionSizeX) = (int)value;
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06002372 RID: 9074 RVA: 0x00033CB0 File Offset: 0x00031EB0
		// (set) Token: 0x06002373 RID: 9075 RVA: 0x00033CC0 File Offset: 0x00031EC0
		public unsafe uint LastUserConfirmedResolutionSizeY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_LastUserConfirmedResolutionSizeY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_LastUserConfirmedResolutionSizeY) = (int)value;
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06002374 RID: 9076 RVA: 0x00033CD1 File Offset: 0x00031ED1
		// (set) Token: 0x06002375 RID: 9077 RVA: 0x00033CE1 File Offset: 0x00031EE1
		public unsafe int WindowPosX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_WindowPosX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_WindowPosX) = value;
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06002376 RID: 9078 RVA: 0x00033CF2 File Offset: 0x00031EF2
		// (set) Token: 0x06002377 RID: 9079 RVA: 0x00033D02 File Offset: 0x00031F02
		public unsafe int WindowPosY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_WindowPosY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_WindowPosY) = value;
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06002378 RID: 9080 RVA: 0x00033D13 File Offset: 0x00031F13
		// (set) Token: 0x06002379 RID: 9081 RVA: 0x00033D23 File Offset: 0x00031F23
		public unsafe int FullscreenMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_FullscreenMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_FullscreenMode) = value;
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x0600237A RID: 9082 RVA: 0x00033D34 File Offset: 0x00031F34
		// (set) Token: 0x0600237B RID: 9083 RVA: 0x00033D44 File Offset: 0x00031F44
		public unsafe int GameQualitySettingLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_GameQualitySettingLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_GameQualitySettingLevel) = value;
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x0600237C RID: 9084 RVA: 0x00033D55 File Offset: 0x00031F55
		// (set) Token: 0x0600237D RID: 9085 RVA: 0x00033D65 File Offset: 0x00031F65
		public unsafe int LastConfirmedFullscreenMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_LastConfirmedFullscreenMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_LastConfirmedFullscreenMode) = value;
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x0600237E RID: 9086 RVA: 0x00033D76 File Offset: 0x00031F76
		// (set) Token: 0x0600237F RID: 9087 RVA: 0x00033D86 File Offset: 0x00031F86
		public unsafe int PreferredFullscreenMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_PreferredFullscreenMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_PreferredFullscreenMode) = value;
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06002380 RID: 9088 RVA: 0x00033D97 File Offset: 0x00031F97
		// (set) Token: 0x06002381 RID: 9089 RVA: 0x00033DA7 File Offset: 0x00031FA7
		public unsafe uint Version
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_Version);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_Version) = (int)value;
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06002382 RID: 9090 RVA: 0x00033DB8 File Offset: 0x00031FB8
		// (set) Token: 0x06002383 RID: 9091 RVA: 0x00033DC8 File Offset: 0x00031FC8
		public unsafe int AudioQualityLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_AudioQualityLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_AudioQualityLevel) = value;
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06002384 RID: 9092 RVA: 0x00033DD9 File Offset: 0x00031FD9
		// (set) Token: 0x06002385 RID: 9093 RVA: 0x00033DE9 File Offset: 0x00031FE9
		public unsafe int LastConfirmedAudioQualityLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_LastConfirmedAudioQualityLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_LastConfirmedAudioQualityLevel) = value;
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06002386 RID: 9094 RVA: 0x00033DFA File Offset: 0x00031FFA
		// (set) Token: 0x06002387 RID: 9095 RVA: 0x00033E0A File Offset: 0x0003200A
		public unsafe float FrameRateLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_FrameRateLimit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_FrameRateLimit) = value;
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06002388 RID: 9096 RVA: 0x00033E1B File Offset: 0x0003201B
		// (set) Token: 0x06002389 RID: 9097 RVA: 0x00033E2B File Offset: 0x0003202B
		public unsafe int FramePace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_FramePace);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_FramePace) = value;
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x0600238A RID: 9098 RVA: 0x00033E3C File Offset: 0x0003203C
		// (set) Token: 0x0600238B RID: 9099 RVA: 0x00033E4C File Offset: 0x0003204C
		public unsafe int DesiredScreenWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_DesiredScreenWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_DesiredScreenWidth) = value;
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x0600238C RID: 9100 RVA: 0x00033E5D File Offset: 0x0003205D
		// (set) Token: 0x0600238D RID: 9101 RVA: 0x00033E6D File Offset: 0x0003206D
		public unsafe bool bUseDesiredScreenHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_bUseDesiredScreenHeight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_bUseDesiredScreenHeight) = (value ? 1 : 0);
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x0600238E RID: 9102 RVA: 0x00033E7E File Offset: 0x0003207E
		// (set) Token: 0x0600238F RID: 9103 RVA: 0x00033E8E File Offset: 0x0003208E
		public unsafe int DesiredScreenHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_DesiredScreenHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_DesiredScreenHeight) = value;
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06002390 RID: 9104 RVA: 0x00033E9F File Offset: 0x0003209F
		// (set) Token: 0x06002391 RID: 9105 RVA: 0x00033EAF File Offset: 0x000320AF
		public unsafe int LastUserConfirmedDesiredScreenWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_LastUserConfirmedDesiredScreenWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_LastUserConfirmedDesiredScreenWidth) = value;
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06002392 RID: 9106 RVA: 0x00033EC0 File Offset: 0x000320C0
		// (set) Token: 0x06002393 RID: 9107 RVA: 0x00033ED0 File Offset: 0x000320D0
		public unsafe int LastUserConfirmedDesiredScreenHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_LastUserConfirmedDesiredScreenHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_LastUserConfirmedDesiredScreenHeight) = value;
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06002394 RID: 9108 RVA: 0x00033EE1 File Offset: 0x000320E1
		// (set) Token: 0x06002395 RID: 9109 RVA: 0x00033EF1 File Offset: 0x000320F1
		public unsafe float LastRecommendedScreenWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_LastRecommendedScreenWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_LastRecommendedScreenWidth) = value;
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06002396 RID: 9110 RVA: 0x00033F02 File Offset: 0x00032102
		// (set) Token: 0x06002397 RID: 9111 RVA: 0x00033F12 File Offset: 0x00032112
		public unsafe float LastRecommendedScreenHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_LastRecommendedScreenHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_LastRecommendedScreenHeight) = value;
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06002398 RID: 9112 RVA: 0x00033F23 File Offset: 0x00032123
		// (set) Token: 0x06002399 RID: 9113 RVA: 0x00033F33 File Offset: 0x00032133
		public unsafe float LastCPUBenchmarkResult
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_LastCPUBenchmarkResult);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_LastCPUBenchmarkResult) = value;
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x0600239A RID: 9114 RVA: 0x00033F44 File Offset: 0x00032144
		// (set) Token: 0x0600239B RID: 9115 RVA: 0x00033F54 File Offset: 0x00032154
		public unsafe float LastGPUBenchmarkResult
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_LastGPUBenchmarkResult);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_LastGPUBenchmarkResult) = value;
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x0600239C RID: 9116 RVA: 0x00033F68 File Offset: 0x00032168
		// (set) Token: 0x0600239D RID: 9117 RVA: 0x00033FA1 File Offset: 0x000321A1
		[Nullable(1)]
		public TArray<float> LastCPUBenchmarkSteps
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._LastCPUBenchmarkSteps) == null)
				{
					result = (this._LastCPUBenchmarkSteps = new TArray<float>(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_LastCPUBenchmarkSteps, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LastCPUBenchmarkSteps.CopyAssign(value);
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x0600239E RID: 9118 RVA: 0x00033FB0 File Offset: 0x000321B0
		// (set) Token: 0x0600239F RID: 9119 RVA: 0x00033FE9 File Offset: 0x000321E9
		[Nullable(1)]
		public TArray<float> LastGPUBenchmarkSteps
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._LastGPUBenchmarkSteps) == null)
				{
					result = (this._LastGPUBenchmarkSteps = new TArray<float>(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_LastGPUBenchmarkSteps, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LastGPUBenchmarkSteps.CopyAssign(value);
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x060023A0 RID: 9120 RVA: 0x00033FF7 File Offset: 0x000321F7
		// (set) Token: 0x060023A1 RID: 9121 RVA: 0x00034007 File Offset: 0x00032207
		public unsafe float LastGPUBenchmarkMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_LastGPUBenchmarkMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_LastGPUBenchmarkMultiplier) = value;
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x060023A2 RID: 9122 RVA: 0x00034018 File Offset: 0x00032218
		// (set) Token: 0x060023A3 RID: 9123 RVA: 0x00034028 File Offset: 0x00032228
		public unsafe bool bUseHDRDisplayOutput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_bUseHDRDisplayOutput) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_bUseHDRDisplayOutput) = (value ? 1 : 0);
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x060023A4 RID: 9124 RVA: 0x00034039 File Offset: 0x00032239
		// (set) Token: 0x060023A5 RID: 9125 RVA: 0x00034049 File Offset: 0x00032249
		public unsafe int HDRDisplayOutputNits
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_HDRDisplayOutputNits);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_HDRDisplayOutputNits) = value;
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x060023A6 RID: 9126 RVA: 0x0003405C File Offset: 0x0003225C
		// (set) Token: 0x060023A7 RID: 9127 RVA: 0x00034095 File Offset: 0x00032295
		[Nullable(1)]
		public FOnGameUserSettingsUINeedsUpdate OnGameUserSettingsUINeedsUpdate
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnGameUserSettingsUINeedsUpdate result;
				if ((result = this._OnGameUserSettingsUINeedsUpdate) == null)
				{
					result = (this._OnGameUserSettingsUINeedsUpdate = new FOnGameUserSettingsUINeedsUpdate(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_OnGameUserSettingsUINeedsUpdate, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UGameUserSettings.__PropertyOffset_OnGameUserSettingsUINeedsUpdate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x060023A8 RID: 9128 RVA: 0x000340B6 File Offset: 0x000322B6
		public void ValidateSettings()
		{
			UGameUserSettings.__ValidateSettings_Internal(base.NativePtr);
		}

		// Token: 0x060023A9 RID: 9129 RVA: 0x000340C3 File Offset: 0x000322C3
		public bool SupportsHDRDisplayOutput()
		{
			return UGameUserSettings.__SupportsHDRDisplayOutput_Internal(base.NativePtr);
		}

		// Token: 0x060023AA RID: 9130 RVA: 0x000340D0 File Offset: 0x000322D0
		public void SetVSyncEnabled(bool bEnable)
		{
			UGameUserSettings.__SetVSyncEnabled_Internal(base.NativePtr, bEnable);
		}

		// Token: 0x060023AB RID: 9131 RVA: 0x000340DE File Offset: 0x000322DE
		public void SetVisualEffectQuality(int Value)
		{
			UGameUserSettings.__SetVisualEffectQuality_Internal(base.NativePtr, Value);
		}

		// Token: 0x060023AC RID: 9132 RVA: 0x000340EC File Offset: 0x000322EC
		public void SetViewDistanceQuality(int Value)
		{
			UGameUserSettings.__SetViewDistanceQuality_Internal(base.NativePtr, Value);
		}

		// Token: 0x060023AD RID: 9133 RVA: 0x000340FA File Offset: 0x000322FA
		public void SetToDefaults()
		{
			UGameUserSettings.__SetToDefaults_Internal(base.NativePtr);
		}

		// Token: 0x060023AE RID: 9134 RVA: 0x00034107 File Offset: 0x00032307
		public void SetTextureQuality(int Value)
		{
			UGameUserSettings.__SetTextureQuality_Internal(base.NativePtr, Value);
		}

		// Token: 0x060023AF RID: 9135 RVA: 0x00034115 File Offset: 0x00032315
		public void SetShadowQuality(int Value)
		{
			UGameUserSettings.__SetShadowQuality_Internal(base.NativePtr, Value);
		}

		// Token: 0x060023B0 RID: 9136 RVA: 0x00034123 File Offset: 0x00032323
		public void SetShadingQuality(int Value)
		{
			UGameUserSettings.__SetShadingQuality_Internal(base.NativePtr, Value);
		}

		// Token: 0x060023B1 RID: 9137 RVA: 0x00034131 File Offset: 0x00032331
		public void SetScreenResolution(FIntPoint Resolution)
		{
			UGameUserSettings.__SetScreenResolution_Internal(base.NativePtr, Resolution);
		}

		// Token: 0x060023B2 RID: 9138 RVA: 0x0003413F File Offset: 0x0003233F
		public void SetResolutionScaleValueEx(float NewScaleValue)
		{
			UGameUserSettings.__SetResolutionScaleValueEx_Internal(base.NativePtr, NewScaleValue);
		}

		// Token: 0x060023B3 RID: 9139 RVA: 0x0003414D File Offset: 0x0003234D
		public void SetResolutionScaleValue(int NewScaleValue)
		{
			UGameUserSettings.__SetResolutionScaleValue_Internal(base.NativePtr, NewScaleValue);
		}

		// Token: 0x060023B4 RID: 9140 RVA: 0x0003415B File Offset: 0x0003235B
		public void SetResolutionScaleNormalized(float NewScaleNormalized)
		{
			UGameUserSettings.__SetResolutionScaleNormalized_Internal(base.NativePtr, NewScaleNormalized);
		}

		// Token: 0x060023B5 RID: 9141 RVA: 0x00034169 File Offset: 0x00032369
		public void SetPostProcessingQuality(int Value)
		{
			UGameUserSettings.__SetPostProcessingQuality_Internal(base.NativePtr, Value);
		}

		// Token: 0x060023B6 RID: 9142 RVA: 0x00034177 File Offset: 0x00032377
		public void SetOverallScalabilityLevel(int Value)
		{
			UGameUserSettings.__SetOverallScalabilityLevel_Internal(base.NativePtr, Value);
		}

		// Token: 0x060023B7 RID: 9143 RVA: 0x00034185 File Offset: 0x00032385
		public void SetMobileGameQualitySettingLevel(float InGameQualitySettingLevel)
		{
			UGameUserSettings.__SetMobileGameQualitySettingLevel_Internal(base.NativePtr, InGameQualitySettingLevel);
		}

		// Token: 0x060023B8 RID: 9144 RVA: 0x00034193 File Offset: 0x00032393
		public void SetGameQualitySettingLevel(float InGameQualitySettingLevel)
		{
			UGameUserSettings.__SetGameQualitySettingLevel_Internal(base.NativePtr, InGameQualitySettingLevel);
		}

		// Token: 0x060023B9 RID: 9145 RVA: 0x000341A1 File Offset: 0x000323A1
		public void SetFullscreenMode(EWindowMode InFullscreenMode)
		{
			UGameUserSettings.__SetFullscreenMode_Internal(base.NativePtr, InFullscreenMode);
		}

		// Token: 0x060023BA RID: 9146 RVA: 0x000341B4 File Offset: 0x000323B4
		public void SetFrameRateLimit(float NewLimit)
		{
			UGameUserSettings.__SetFrameRateLimit_Internal(base.NativePtr, NewLimit);
		}

		// Token: 0x060023BB RID: 9147 RVA: 0x000341C2 File Offset: 0x000323C2
		public void SetFramePace(int NewPace)
		{
			UGameUserSettings.__SetFramePace_Internal(base.NativePtr, NewPace);
		}

		// Token: 0x060023BC RID: 9148 RVA: 0x000341D0 File Offset: 0x000323D0
		public void SetFoliageQuality(int Value)
		{
			UGameUserSettings.__SetFoliageQuality_Internal(base.NativePtr, Value);
		}

		// Token: 0x060023BD RID: 9149 RVA: 0x000341DE File Offset: 0x000323DE
		public void SetDynamicResolutionEnabled(bool bEnable)
		{
			UGameUserSettings.__SetDynamicResolutionEnabled_Internal(base.NativePtr, bEnable);
		}

		// Token: 0x060023BE RID: 9150 RVA: 0x000341EC File Offset: 0x000323EC
		public void SetBenchmarkFallbackValues()
		{
			UGameUserSettings.__SetBenchmarkFallbackValues_Internal(base.NativePtr);
		}

		// Token: 0x060023BF RID: 9151 RVA: 0x000341F9 File Offset: 0x000323F9
		public void SetAudioQualityLevel(int QualityLevel)
		{
			UGameUserSettings.__SetAudioQualityLevel_Internal(base.NativePtr, QualityLevel);
		}

		// Token: 0x060023C0 RID: 9152 RVA: 0x00034207 File Offset: 0x00032407
		public void SetAntiAliasingQuality(int Value)
		{
			UGameUserSettings.__SetAntiAliasingQuality_Internal(base.NativePtr, Value);
		}

		// Token: 0x060023C1 RID: 9153 RVA: 0x00034215 File Offset: 0x00032415
		public void SaveSettings()
		{
			UGameUserSettings.__SaveSettings_Internal(base.NativePtr);
		}

		// Token: 0x060023C2 RID: 9154 RVA: 0x00034222 File Offset: 0x00032422
		public void RunHardwareBenchmark(int WorkScale = 10, float CPUMultiplier = 1f, float GPUMultiplier = 1f)
		{
			UGameUserSettings.__RunHardwareBenchmark_Internal(base.NativePtr, WorkScale, CPUMultiplier, GPUMultiplier);
		}

		// Token: 0x060023C3 RID: 9155 RVA: 0x00034232 File Offset: 0x00032432
		public void RevertVideoMode()
		{
			UGameUserSettings.__RevertVideoMode_Internal(base.NativePtr);
		}

		// Token: 0x060023C4 RID: 9156 RVA: 0x0003423F File Offset: 0x0003243F
		public void ResetToCurrentSettings()
		{
			UGameUserSettings.__ResetToCurrentSettings_Internal(base.NativePtr);
		}

		// Token: 0x060023C5 RID: 9157 RVA: 0x0003424C File Offset: 0x0003244C
		public void LoadSettings(bool bForceReload = false)
		{
			UGameUserSettings.__LoadSettings_Internal(base.NativePtr, bForceReload);
		}

		// Token: 0x060023C6 RID: 9158 RVA: 0x0003425A File Offset: 0x0003245A
		public bool IsVSyncEnabled()
		{
			return UGameUserSettings.__IsVSyncEnabled_Internal(base.NativePtr);
		}

		// Token: 0x060023C7 RID: 9159 RVA: 0x00034267 File Offset: 0x00032467
		public bool IsVSyncDirty()
		{
			return UGameUserSettings.__IsVSyncDirty_Internal(base.NativePtr);
		}

		// Token: 0x060023C8 RID: 9160 RVA: 0x00034274 File Offset: 0x00032474
		public bool IsScreenResolutionDirty()
		{
			return UGameUserSettings.__IsScreenResolutionDirty_Internal(base.NativePtr);
		}

		// Token: 0x060023C9 RID: 9161 RVA: 0x00034281 File Offset: 0x00032481
		public bool IsHDREnabled()
		{
			return UGameUserSettings.__IsHDREnabled_Internal(base.NativePtr);
		}

		// Token: 0x060023CA RID: 9162 RVA: 0x0003428E File Offset: 0x0003248E
		public bool IsFullscreenModeDirty()
		{
			return UGameUserSettings.__IsFullscreenModeDirty_Internal(base.NativePtr);
		}

		// Token: 0x060023CB RID: 9163 RVA: 0x0003429B File Offset: 0x0003249B
		public bool IsDynamicResolutionEnabled()
		{
			return UGameUserSettings.__IsDynamicResolutionEnabled_Internal(base.NativePtr);
		}

		// Token: 0x060023CC RID: 9164 RVA: 0x000342A8 File Offset: 0x000324A8
		public bool IsDynamicResolutionDirty()
		{
			return UGameUserSettings.__IsDynamicResolutionDirty_Internal(base.NativePtr);
		}

		// Token: 0x060023CD RID: 9165 RVA: 0x000342B5 File Offset: 0x000324B5
		public bool IsDirty()
		{
			return UGameUserSettings.__IsDirty_Internal(base.NativePtr);
		}

		// Token: 0x060023CE RID: 9166 RVA: 0x000342C2 File Offset: 0x000324C2
		public int GetVisualEffectQuality()
		{
			return UGameUserSettings.__GetVisualEffectQuality_Internal(base.NativePtr);
		}

		// Token: 0x060023CF RID: 9167 RVA: 0x000342CF File Offset: 0x000324CF
		public int GetViewDistanceQuality()
		{
			return UGameUserSettings.__GetViewDistanceQuality_Internal(base.NativePtr);
		}

		// Token: 0x060023D0 RID: 9168 RVA: 0x000342DC File Offset: 0x000324DC
		public int GetTextureQuality()
		{
			return UGameUserSettings.__GetTextureQuality_Internal(base.NativePtr);
		}

		// Token: 0x060023D1 RID: 9169
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetSyncInterval();

		// Token: 0x060023D2 RID: 9170 RVA: 0x000342E9 File Offset: 0x000324E9
		public int GetShadowQuality()
		{
			return UGameUserSettings.__GetShadowQuality_Internal(base.NativePtr);
		}

		// Token: 0x060023D3 RID: 9171 RVA: 0x000342F6 File Offset: 0x000324F6
		public int GetShadingQuality()
		{
			return UGameUserSettings.__GetShadingQuality_Internal(base.NativePtr);
		}

		// Token: 0x060023D4 RID: 9172 RVA: 0x00034303 File Offset: 0x00032503
		public FIntPoint GetScreenResolution()
		{
			return UGameUserSettings.__GetScreenResolution_Internal(base.NativePtr);
		}

		// Token: 0x060023D5 RID: 9173 RVA: 0x00034310 File Offset: 0x00032510
		public float GetResolutionScaleNormalized()
		{
			return UGameUserSettings.__GetResolutionScaleNormalized_Internal(base.NativePtr);
		}

		// Token: 0x060023D6 RID: 9174 RVA: 0x00034320 File Offset: 0x00032520
		public unsafe void GetResolutionScaleInformationEx(ref float CurrentScaleNormalized, ref float CurrentScaleValue, ref float MinScaleValue, ref float MaxScaleValue)
		{
			fixed (float* ptr = &CurrentScaleNormalized)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &CurrentScaleValue)
				{
					void* ptr4 = (void*)ptr3;
					fixed (float* ptr5 = &MinScaleValue)
					{
						void* ptr6 = (void*)ptr5;
						fixed (float* ptr7 = &MaxScaleValue)
						{
							void* ptr8 = (void*)ptr7;
							UGameUserSettings.__GetResolutionScaleInformationEx_Internal(base.NativePtr, ref CurrentScaleNormalized, ref CurrentScaleValue, ref MinScaleValue, ref MaxScaleValue);
							ptr = null;
							ptr3 = null;
							ptr5 = null;
						}
					}
				}
			}
		}

		// Token: 0x060023D7 RID: 9175 RVA: 0x0003436C File Offset: 0x0003256C
		public unsafe void GetResolutionScaleInformation(ref float CurrentScaleNormalized, ref int CurrentScaleValue, ref int MinScaleValue, ref int MaxScaleValue)
		{
			fixed (float* ptr = &CurrentScaleNormalized)
			{
				void* ptr2 = (void*)ptr;
				fixed (int* ptr3 = &CurrentScaleValue)
				{
					void* ptr4 = (void*)ptr3;
					fixed (int* ptr5 = &MinScaleValue)
					{
						void* ptr6 = (void*)ptr5;
						fixed (int* ptr7 = &MaxScaleValue)
						{
							void* ptr8 = (void*)ptr7;
							UGameUserSettings.__GetResolutionScaleInformation_Internal(base.NativePtr, ref CurrentScaleNormalized, ref CurrentScaleValue, ref MinScaleValue, ref MaxScaleValue);
							ptr = null;
							ptr3 = null;
							ptr5 = null;
						}
					}
				}
			}
		}

		// Token: 0x060023D8 RID: 9176 RVA: 0x000343B6 File Offset: 0x000325B6
		public float GetRecommendedResolutionScale()
		{
			return UGameUserSettings.__GetRecommendedResolutionScale_Internal(base.NativePtr);
		}

		// Token: 0x060023D9 RID: 9177 RVA: 0x000343C3 File Offset: 0x000325C3
		public TEnumAsByte<EWindowMode> GetPreferredFullscreenMode()
		{
			return UGameUserSettings.__GetPreferredFullscreenMode_Internal(base.NativePtr);
		}

		// Token: 0x060023DA RID: 9178 RVA: 0x000343D0 File Offset: 0x000325D0
		public int GetPostProcessingQuality()
		{
			return UGameUserSettings.__GetPostProcessingQuality_Internal(base.NativePtr);
		}

		// Token: 0x060023DB RID: 9179 RVA: 0x000343DD File Offset: 0x000325DD
		public int GetOverallScalabilityLevel()
		{
			return UGameUserSettings.__GetOverallScalabilityLevel_Internal(base.NativePtr);
		}

		// Token: 0x060023DC RID: 9180 RVA: 0x000343EA File Offset: 0x000325EA
		public int GetMobileGameQualitySettingLevel()
		{
			return UGameUserSettings.__GetMobileGameQualitySettingLevel_Internal(base.NativePtr);
		}

		// Token: 0x060023DD RID: 9181 RVA: 0x000343F7 File Offset: 0x000325F7
		public FIntPoint GetLastConfirmedScreenResolution()
		{
			return UGameUserSettings.__GetLastConfirmedScreenResolution_Internal(base.NativePtr);
		}

		// Token: 0x060023DE RID: 9182 RVA: 0x00034404 File Offset: 0x00032604
		public TEnumAsByte<EWindowMode> GetLastConfirmedFullscreenMode()
		{
			return UGameUserSettings.__GetLastConfirmedFullscreenMode_Internal(base.NativePtr);
		}

		// Token: 0x060023DF RID: 9183 RVA: 0x00034411 File Offset: 0x00032611
		[NullableContext(2)]
		public static UGameUserSettings GetGameUserSettings()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UGameUserSettings>(UGameUserSettings.__GetGameUserSettings_Internal());
		}

		// Token: 0x060023E0 RID: 9184 RVA: 0x0003441D File Offset: 0x0003261D
		public int GetGameQualitySettingLevel()
		{
			return UGameUserSettings.__GetGameQualitySettingLevel_Internal(base.NativePtr);
		}

		// Token: 0x060023E1 RID: 9185 RVA: 0x0003442A File Offset: 0x0003262A
		public TEnumAsByte<EWindowMode> GetFullscreenMode()
		{
			return UGameUserSettings.__GetFullscreenMode_Internal(base.NativePtr);
		}

		// Token: 0x060023E2 RID: 9186 RVA: 0x00034437 File Offset: 0x00032637
		public float GetFrameRateLimit()
		{
			return UGameUserSettings.__GetFrameRateLimit_Internal(base.NativePtr);
		}

		// Token: 0x060023E3 RID: 9187
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetFramePace();

		// Token: 0x060023E4 RID: 9188 RVA: 0x00034444 File Offset: 0x00032644
		public int GetFoliageQuality()
		{
			return UGameUserSettings.__GetFoliageQuality_Internal(base.NativePtr);
		}

		// Token: 0x060023E5 RID: 9189 RVA: 0x00034451 File Offset: 0x00032651
		public FIntPoint GetDesktopResolution()
		{
			return UGameUserSettings.__GetDesktopResolution_Internal(base.NativePtr);
		}

		// Token: 0x060023E6 RID: 9190
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FIntPoint GetDefaultWindowPosition();

		// Token: 0x060023E7 RID: 9191
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern TEnumAsByte<EWindowMode> GetDefaultWindowMode();

		// Token: 0x060023E8 RID: 9192 RVA: 0x0003445E File Offset: 0x0003265E
		public float GetDefaultResolutionScale()
		{
			return UGameUserSettings.__GetDefaultResolutionScale_Internal(base.NativePtr);
		}

		// Token: 0x060023E9 RID: 9193
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FIntPoint GetDefaultResolution();

		// Token: 0x060023EA RID: 9194 RVA: 0x0003446B File Offset: 0x0003266B
		public int GetCurrentHDRDisplayNits()
		{
			return UGameUserSettings.__GetCurrentHDRDisplayNits_Internal(base.NativePtr);
		}

		// Token: 0x060023EB RID: 9195 RVA: 0x00034478 File Offset: 0x00032678
		public int GetAudioQualityLevel()
		{
			return UGameUserSettings.__GetAudioQualityLevel_Internal(base.NativePtr);
		}

		// Token: 0x060023EC RID: 9196 RVA: 0x00034485 File Offset: 0x00032685
		public int GetAntiAliasingQuality()
		{
			return UGameUserSettings.__GetAntiAliasingQuality_Internal(base.NativePtr);
		}

		// Token: 0x060023ED RID: 9197 RVA: 0x00034492 File Offset: 0x00032692
		public void EnableHDRDisplayOutput(bool bEnable, int DisplayNits = 1000)
		{
			UGameUserSettings.__EnableHDRDisplayOutput_Internal(base.NativePtr, bEnable, DisplayNits);
		}

		// Token: 0x060023EE RID: 9198 RVA: 0x000344A1 File Offset: 0x000326A1
		public void ConfirmVideoMode()
		{
			UGameUserSettings.__ConfirmVideoMode_Internal(base.NativePtr);
		}

		// Token: 0x060023EF RID: 9199 RVA: 0x000344AE File Offset: 0x000326AE
		public void ApplySettings(bool bCheckForCommandLineOverrides)
		{
			UGameUserSettings.__ApplySettings_Internal(base.NativePtr, bCheckForCommandLineOverrides);
		}

		// Token: 0x060023F0 RID: 9200 RVA: 0x000344BC File Offset: 0x000326BC
		public void ApplyResolutionSettings(bool bCheckForCommandLineOverrides)
		{
			UGameUserSettings.__ApplyResolutionSettings_Internal(base.NativePtr, bCheckForCommandLineOverrides);
		}

		// Token: 0x060023F1 RID: 9201 RVA: 0x000344CA File Offset: 0x000326CA
		public void ApplyNonResolutionSettings()
		{
			UGameUserSettings.__ApplyNonResolutionSettings_Internal(base.NativePtr);
		}

		// Token: 0x060023F2 RID: 9202 RVA: 0x000344D7 File Offset: 0x000326D7
		public void ApplyHardwareBenchmarkResults()
		{
			UGameUserSettings.__ApplyHardwareBenchmarkResults_Internal(base.NativePtr);
		}

		// Token: 0x060023F3 RID: 9203
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ValidateSettings_Internal(IntPtr @this);

		// Token: 0x060023F4 RID: 9204
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SupportsHDRDisplayOutput_Internal(IntPtr @this);

		// Token: 0x060023F5 RID: 9205
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVSyncEnabled_Internal(IntPtr @this, bool bEnable);

		// Token: 0x060023F6 RID: 9206
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVisualEffectQuality_Internal(IntPtr @this, int Value);

		// Token: 0x060023F7 RID: 9207
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetViewDistanceQuality_Internal(IntPtr @this, int Value);

		// Token: 0x060023F8 RID: 9208
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToDefaults_Internal(IntPtr @this);

		// Token: 0x060023F9 RID: 9209
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTextureQuality_Internal(IntPtr @this, int Value);

		// Token: 0x060023FA RID: 9210
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShadowQuality_Internal(IntPtr @this, int Value);

		// Token: 0x060023FB RID: 9211
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShadingQuality_Internal(IntPtr @this, int Value);

		// Token: 0x060023FC RID: 9212
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetScreenResolution_Internal(IntPtr @this, FIntPoint Resolution);

		// Token: 0x060023FD RID: 9213
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetResolutionScaleValueEx_Internal(IntPtr @this, float NewScaleValue);

		// Token: 0x060023FE RID: 9214
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetResolutionScaleValue_Internal(IntPtr @this, int NewScaleValue);

		// Token: 0x060023FF RID: 9215
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetResolutionScaleNormalized_Internal(IntPtr @this, float NewScaleNormalized);

		// Token: 0x06002400 RID: 9216
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPostProcessingQuality_Internal(IntPtr @this, int Value);

		// Token: 0x06002401 RID: 9217
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOverallScalabilityLevel_Internal(IntPtr @this, int Value);

		// Token: 0x06002402 RID: 9218
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMobileGameQualitySettingLevel_Internal(IntPtr @this, float InGameQualitySettingLevel);

		// Token: 0x06002403 RID: 9219
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGameQualitySettingLevel_Internal(IntPtr @this, float InGameQualitySettingLevel);

		// Token: 0x06002404 RID: 9220
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFullscreenMode_Internal(IntPtr @this, TEnumAsByte<EWindowMode> InFullscreenMode);

		// Token: 0x06002405 RID: 9221
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFrameRateLimit_Internal(IntPtr @this, float NewLimit);

		// Token: 0x06002406 RID: 9222
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFramePace_Internal(IntPtr @this, int NewPace);

		// Token: 0x06002407 RID: 9223
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFoliageQuality_Internal(IntPtr @this, int Value);

		// Token: 0x06002408 RID: 9224
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDynamicResolutionEnabled_Internal(IntPtr @this, bool bEnable);

		// Token: 0x06002409 RID: 9225
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBenchmarkFallbackValues_Internal(IntPtr @this);

		// Token: 0x0600240A RID: 9226
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAudioQualityLevel_Internal(IntPtr @this, int QualityLevel);

		// Token: 0x0600240B RID: 9227
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAntiAliasingQuality_Internal(IntPtr @this, int Value);

		// Token: 0x0600240C RID: 9228
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SaveSettings_Internal(IntPtr @this);

		// Token: 0x0600240D RID: 9229
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RunHardwareBenchmark_Internal(IntPtr @this, int WorkScale, float CPUMultiplier, float GPUMultiplier);

		// Token: 0x0600240E RID: 9230
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RevertVideoMode_Internal(IntPtr @this);

		// Token: 0x0600240F RID: 9231
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetToCurrentSettings_Internal(IntPtr @this);

		// Token: 0x06002410 RID: 9232
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LoadSettings_Internal(IntPtr @this, bool bForceReload);

		// Token: 0x06002411 RID: 9233
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsVSyncEnabled_Internal(IntPtr @this);

		// Token: 0x06002412 RID: 9234
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsVSyncDirty_Internal(IntPtr @this);

		// Token: 0x06002413 RID: 9235
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsScreenResolutionDirty_Internal(IntPtr @this);

		// Token: 0x06002414 RID: 9236
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsHDREnabled_Internal(IntPtr @this);

		// Token: 0x06002415 RID: 9237
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsFullscreenModeDirty_Internal(IntPtr @this);

		// Token: 0x06002416 RID: 9238
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsDynamicResolutionEnabled_Internal(IntPtr @this);

		// Token: 0x06002417 RID: 9239
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsDynamicResolutionDirty_Internal(IntPtr @this);

		// Token: 0x06002418 RID: 9240
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsDirty_Internal(IntPtr @this);

		// Token: 0x06002419 RID: 9241
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetVisualEffectQuality_Internal(IntPtr @this);

		// Token: 0x0600241A RID: 9242
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetViewDistanceQuality_Internal(IntPtr @this);

		// Token: 0x0600241B RID: 9243
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetTextureQuality_Internal(IntPtr @this);

		// Token: 0x0600241C RID: 9244
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetShadowQuality_Internal(IntPtr @this);

		// Token: 0x0600241D RID: 9245
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetShadingQuality_Internal(IntPtr @this);

		// Token: 0x0600241E RID: 9246
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntPoint __GetScreenResolution_Internal(IntPtr @this);

		// Token: 0x0600241F RID: 9247
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetResolutionScaleNormalized_Internal(IntPtr @this);

		// Token: 0x06002420 RID: 9248
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetResolutionScaleInformationEx_Internal(IntPtr @this, ref float CurrentScaleNormalized, ref float CurrentScaleValue, ref float MinScaleValue, ref float MaxScaleValue);

		// Token: 0x06002421 RID: 9249
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetResolutionScaleInformation_Internal(IntPtr @this, ref float CurrentScaleNormalized, ref int CurrentScaleValue, ref int MinScaleValue, ref int MaxScaleValue);

		// Token: 0x06002422 RID: 9250
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRecommendedResolutionScale_Internal(IntPtr @this);

		// Token: 0x06002423 RID: 9251
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<EWindowMode> __GetPreferredFullscreenMode_Internal(IntPtr @this);

		// Token: 0x06002424 RID: 9252
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetPostProcessingQuality_Internal(IntPtr @this);

		// Token: 0x06002425 RID: 9253
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetOverallScalabilityLevel_Internal(IntPtr @this);

		// Token: 0x06002426 RID: 9254
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMobileGameQualitySettingLevel_Internal(IntPtr @this);

		// Token: 0x06002427 RID: 9255
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntPoint __GetLastConfirmedScreenResolution_Internal(IntPtr @this);

		// Token: 0x06002428 RID: 9256
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<EWindowMode> __GetLastConfirmedFullscreenMode_Internal(IntPtr @this);

		// Token: 0x06002429 RID: 9257
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGameUserSettings_Internal();

		// Token: 0x0600242A RID: 9258
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetGameQualitySettingLevel_Internal(IntPtr @this);

		// Token: 0x0600242B RID: 9259
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<EWindowMode> __GetFullscreenMode_Internal(IntPtr @this);

		// Token: 0x0600242C RID: 9260
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetFrameRateLimit_Internal(IntPtr @this);

		// Token: 0x0600242D RID: 9261
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetFoliageQuality_Internal(IntPtr @this);

		// Token: 0x0600242E RID: 9262
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntPoint __GetDesktopResolution_Internal(IntPtr @this);

		// Token: 0x0600242F RID: 9263
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetDefaultResolutionScale_Internal(IntPtr @this);

		// Token: 0x06002430 RID: 9264
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetCurrentHDRDisplayNits_Internal(IntPtr @this);

		// Token: 0x06002431 RID: 9265
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetAudioQualityLevel_Internal(IntPtr @this);

		// Token: 0x06002432 RID: 9266
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetAntiAliasingQuality_Internal(IntPtr @this);

		// Token: 0x06002433 RID: 9267
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EnableHDRDisplayOutput_Internal(IntPtr @this, bool bEnable, int DisplayNits);

		// Token: 0x06002434 RID: 9268
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ConfirmVideoMode_Internal(IntPtr @this);

		// Token: 0x06002435 RID: 9269
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplySettings_Internal(IntPtr @this, bool bCheckForCommandLineOverrides);

		// Token: 0x06002436 RID: 9270
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyResolutionSettings_Internal(IntPtr @this, bool bCheckForCommandLineOverrides);

		// Token: 0x06002437 RID: 9271
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyNonResolutionSettings_Internal(IntPtr @this);

		// Token: 0x06002438 RID: 9272
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyHardwareBenchmarkResults_Internal(IntPtr @this);

		// Token: 0x06002439 RID: 9273 RVA: 0x000344E4 File Offset: 0x000326E4
		static UGameUserSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.GameUserSettings");
		}

		// Token: 0x0600243A RID: 9274 RVA: 0x000344F2 File Offset: 0x000326F2
		protected UGameUserSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000D70 RID: 3440
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.GameUserSettings";

		// Token: 0x04000D71 RID: 3441
		private static IntPtr _ClassPtr;

		// Token: 0x04000D72 RID: 3442
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000D73 RID: 3443
		internal static int __PropertyOffset_bUseVSync;

		// Token: 0x04000D74 RID: 3444
		internal static int __PropertyOffset_bUseDynamicResolution;

		// Token: 0x04000D75 RID: 3445
		internal static int __PropertyOffset_ResolutionSizeX;

		// Token: 0x04000D76 RID: 3446
		internal static int __PropertyOffset_ResolutionSizeY;

		// Token: 0x04000D77 RID: 3447
		internal static int __PropertyOffset_LastUserConfirmedResolutionSizeX;

		// Token: 0x04000D78 RID: 3448
		internal static int __PropertyOffset_LastUserConfirmedResolutionSizeY;

		// Token: 0x04000D79 RID: 3449
		internal static int __PropertyOffset_WindowPosX;

		// Token: 0x04000D7A RID: 3450
		internal static int __PropertyOffset_WindowPosY;

		// Token: 0x04000D7B RID: 3451
		internal static int __PropertyOffset_FullscreenMode;

		// Token: 0x04000D7C RID: 3452
		internal static int __PropertyOffset_GameQualitySettingLevel;

		// Token: 0x04000D7D RID: 3453
		internal static int __PropertyOffset_LastConfirmedFullscreenMode;

		// Token: 0x04000D7E RID: 3454
		internal static int __PropertyOffset_PreferredFullscreenMode;

		// Token: 0x04000D7F RID: 3455
		internal static int __PropertyOffset_Version;

		// Token: 0x04000D80 RID: 3456
		internal static int __PropertyOffset_AudioQualityLevel;

		// Token: 0x04000D81 RID: 3457
		internal static int __PropertyOffset_LastConfirmedAudioQualityLevel;

		// Token: 0x04000D82 RID: 3458
		internal static int __PropertyOffset_FrameRateLimit;

		// Token: 0x04000D83 RID: 3459
		internal static int __PropertyOffset_FramePace;

		// Token: 0x04000D84 RID: 3460
		internal static int __PropertyOffset_DesiredScreenWidth;

		// Token: 0x04000D85 RID: 3461
		internal static int __PropertyOffset_bUseDesiredScreenHeight;

		// Token: 0x04000D86 RID: 3462
		internal static int __PropertyOffset_DesiredScreenHeight;

		// Token: 0x04000D87 RID: 3463
		internal static int __PropertyOffset_LastUserConfirmedDesiredScreenWidth;

		// Token: 0x04000D88 RID: 3464
		internal static int __PropertyOffset_LastUserConfirmedDesiredScreenHeight;

		// Token: 0x04000D89 RID: 3465
		internal static int __PropertyOffset_LastRecommendedScreenWidth;

		// Token: 0x04000D8A RID: 3466
		internal static int __PropertyOffset_LastRecommendedScreenHeight;

		// Token: 0x04000D8B RID: 3467
		internal static int __PropertyOffset_LastCPUBenchmarkResult;

		// Token: 0x04000D8C RID: 3468
		internal static int __PropertyOffset_LastGPUBenchmarkResult;

		// Token: 0x04000D8D RID: 3469
		internal static int __PropertyOffset_LastCPUBenchmarkSteps;

		// Token: 0x04000D8E RID: 3470
		[Nullable(2)]
		private TArray<float> _LastCPUBenchmarkSteps;

		// Token: 0x04000D8F RID: 3471
		internal static int __PropertyOffset_LastGPUBenchmarkSteps;

		// Token: 0x04000D90 RID: 3472
		[Nullable(2)]
		private TArray<float> _LastGPUBenchmarkSteps;

		// Token: 0x04000D91 RID: 3473
		internal static int __PropertyOffset_LastGPUBenchmarkMultiplier;

		// Token: 0x04000D92 RID: 3474
		internal static int __PropertyOffset_bUseHDRDisplayOutput;

		// Token: 0x04000D93 RID: 3475
		internal static int __PropertyOffset_HDRDisplayOutputNits;

		// Token: 0x04000D94 RID: 3476
		internal static int __PropertyOffset_OnGameUserSettingsUINeedsUpdate;

		// Token: 0x04000D95 RID: 3477
		[Nullable(2)]
		private FOnGameUserSettingsUINeedsUpdate _OnGameUserSettingsUINeedsUpdate;
	}
}
