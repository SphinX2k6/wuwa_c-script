using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C04 RID: 3076
	[UnrealObjectPath("/Script/Engine.GameUserSettings")]
	[UnrealStructLayout(472, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class UGameUserSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009A00 RID: 39424 RVA: 0x000DB710 File Offset: 0x000D9910
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameUserSettings._ClassPtr;
		}

		// Token: 0x06009A01 RID: 39425 RVA: 0x000DB71C File Offset: 0x000D991C
		public UGameUserSettings() : this(BuiltinUtils.AllocNativeUObject(UGameUserSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009A02 RID: 39426 RVA: 0x000DB744 File Offset: 0x000D9944
		[NullableContext(1)]
		public UGameUserSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGameUserSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170024A5 RID: 9381
		// (get) Token: 0x06009A03 RID: 39427 RVA: 0x000DB777 File Offset: 0x000D9977
		// (set) Token: 0x06009A04 RID: 39428 RVA: 0x000DB787 File Offset: 0x000D9987
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

		// Token: 0x170024A6 RID: 9382
		// (get) Token: 0x06009A05 RID: 39429 RVA: 0x000DB798 File Offset: 0x000D9998
		// (set) Token: 0x06009A06 RID: 39430 RVA: 0x000DB7A8 File Offset: 0x000D99A8
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

		// Token: 0x170024A7 RID: 9383
		// (get) Token: 0x06009A07 RID: 39431 RVA: 0x000DB7B9 File Offset: 0x000D99B9
		// (set) Token: 0x06009A08 RID: 39432 RVA: 0x000DB7C9 File Offset: 0x000D99C9
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

		// Token: 0x170024A8 RID: 9384
		// (get) Token: 0x06009A09 RID: 39433 RVA: 0x000DB7DA File Offset: 0x000D99DA
		// (set) Token: 0x06009A0A RID: 39434 RVA: 0x000DB7EA File Offset: 0x000D99EA
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

		// Token: 0x170024A9 RID: 9385
		// (get) Token: 0x06009A0B RID: 39435 RVA: 0x000DB7FB File Offset: 0x000D99FB
		// (set) Token: 0x06009A0C RID: 39436 RVA: 0x000DB80B File Offset: 0x000D9A0B
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

		// Token: 0x170024AA RID: 9386
		// (get) Token: 0x06009A0D RID: 39437 RVA: 0x000DB81C File Offset: 0x000D9A1C
		// (set) Token: 0x06009A0E RID: 39438 RVA: 0x000DB82C File Offset: 0x000D9A2C
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

		// Token: 0x170024AB RID: 9387
		// (get) Token: 0x06009A0F RID: 39439 RVA: 0x000DB83D File Offset: 0x000D9A3D
		// (set) Token: 0x06009A10 RID: 39440 RVA: 0x000DB84D File Offset: 0x000D9A4D
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

		// Token: 0x170024AC RID: 9388
		// (get) Token: 0x06009A11 RID: 39441 RVA: 0x000DB85E File Offset: 0x000D9A5E
		// (set) Token: 0x06009A12 RID: 39442 RVA: 0x000DB86E File Offset: 0x000D9A6E
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

		// Token: 0x170024AD RID: 9389
		// (get) Token: 0x06009A13 RID: 39443 RVA: 0x000DB87F File Offset: 0x000D9A7F
		// (set) Token: 0x06009A14 RID: 39444 RVA: 0x000DB88F File Offset: 0x000D9A8F
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

		// Token: 0x170024AE RID: 9390
		// (get) Token: 0x06009A15 RID: 39445 RVA: 0x000DB8A0 File Offset: 0x000D9AA0
		// (set) Token: 0x06009A16 RID: 39446 RVA: 0x000DB8B0 File Offset: 0x000D9AB0
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

		// Token: 0x170024AF RID: 9391
		// (get) Token: 0x06009A17 RID: 39447 RVA: 0x000DB8C1 File Offset: 0x000D9AC1
		// (set) Token: 0x06009A18 RID: 39448 RVA: 0x000DB8D1 File Offset: 0x000D9AD1
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

		// Token: 0x170024B0 RID: 9392
		// (get) Token: 0x06009A19 RID: 39449 RVA: 0x000DB8E2 File Offset: 0x000D9AE2
		// (set) Token: 0x06009A1A RID: 39450 RVA: 0x000DB8F2 File Offset: 0x000D9AF2
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

		// Token: 0x170024B1 RID: 9393
		// (get) Token: 0x06009A1B RID: 39451 RVA: 0x000DB903 File Offset: 0x000D9B03
		// (set) Token: 0x06009A1C RID: 39452 RVA: 0x000DB913 File Offset: 0x000D9B13
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

		// Token: 0x170024B2 RID: 9394
		// (get) Token: 0x06009A1D RID: 39453 RVA: 0x000DB924 File Offset: 0x000D9B24
		// (set) Token: 0x06009A1E RID: 39454 RVA: 0x000DB934 File Offset: 0x000D9B34
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

		// Token: 0x170024B3 RID: 9395
		// (get) Token: 0x06009A1F RID: 39455 RVA: 0x000DB945 File Offset: 0x000D9B45
		// (set) Token: 0x06009A20 RID: 39456 RVA: 0x000DB955 File Offset: 0x000D9B55
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

		// Token: 0x170024B4 RID: 9396
		// (get) Token: 0x06009A21 RID: 39457 RVA: 0x000DB966 File Offset: 0x000D9B66
		// (set) Token: 0x06009A22 RID: 39458 RVA: 0x000DB976 File Offset: 0x000D9B76
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

		// Token: 0x170024B5 RID: 9397
		// (get) Token: 0x06009A23 RID: 39459 RVA: 0x000DB987 File Offset: 0x000D9B87
		// (set) Token: 0x06009A24 RID: 39460 RVA: 0x000DB997 File Offset: 0x000D9B97
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

		// Token: 0x170024B6 RID: 9398
		// (get) Token: 0x06009A25 RID: 39461 RVA: 0x000DB9A8 File Offset: 0x000D9BA8
		// (set) Token: 0x06009A26 RID: 39462 RVA: 0x000DB9B8 File Offset: 0x000D9BB8
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

		// Token: 0x170024B7 RID: 9399
		// (get) Token: 0x06009A27 RID: 39463 RVA: 0x000DB9C9 File Offset: 0x000D9BC9
		// (set) Token: 0x06009A28 RID: 39464 RVA: 0x000DB9D9 File Offset: 0x000D9BD9
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

		// Token: 0x170024B8 RID: 9400
		// (get) Token: 0x06009A29 RID: 39465 RVA: 0x000DB9EA File Offset: 0x000D9BEA
		// (set) Token: 0x06009A2A RID: 39466 RVA: 0x000DB9FA File Offset: 0x000D9BFA
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

		// Token: 0x170024B9 RID: 9401
		// (get) Token: 0x06009A2B RID: 39467 RVA: 0x000DBA0B File Offset: 0x000D9C0B
		// (set) Token: 0x06009A2C RID: 39468 RVA: 0x000DBA1B File Offset: 0x000D9C1B
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

		// Token: 0x170024BA RID: 9402
		// (get) Token: 0x06009A2D RID: 39469 RVA: 0x000DBA2C File Offset: 0x000D9C2C
		// (set) Token: 0x06009A2E RID: 39470 RVA: 0x000DBA3C File Offset: 0x000D9C3C
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

		// Token: 0x170024BB RID: 9403
		// (get) Token: 0x06009A2F RID: 39471 RVA: 0x000DBA4D File Offset: 0x000D9C4D
		// (set) Token: 0x06009A30 RID: 39472 RVA: 0x000DBA5D File Offset: 0x000D9C5D
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

		// Token: 0x170024BC RID: 9404
		// (get) Token: 0x06009A31 RID: 39473 RVA: 0x000DBA6E File Offset: 0x000D9C6E
		// (set) Token: 0x06009A32 RID: 39474 RVA: 0x000DBA7E File Offset: 0x000D9C7E
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

		// Token: 0x170024BD RID: 9405
		// (get) Token: 0x06009A33 RID: 39475 RVA: 0x000DBA8F File Offset: 0x000D9C8F
		// (set) Token: 0x06009A34 RID: 39476 RVA: 0x000DBA9F File Offset: 0x000D9C9F
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

		// Token: 0x170024BE RID: 9406
		// (get) Token: 0x06009A35 RID: 39477 RVA: 0x000DBAB0 File Offset: 0x000D9CB0
		// (set) Token: 0x06009A36 RID: 39478 RVA: 0x000DBAC0 File Offset: 0x000D9CC0
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

		// Token: 0x170024BF RID: 9407
		// (get) Token: 0x06009A37 RID: 39479 RVA: 0x000DBAD4 File Offset: 0x000D9CD4
		// (set) Token: 0x06009A38 RID: 39480 RVA: 0x000DBB0D File Offset: 0x000D9D0D
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

		// Token: 0x170024C0 RID: 9408
		// (get) Token: 0x06009A39 RID: 39481 RVA: 0x000DBB1C File Offset: 0x000D9D1C
		// (set) Token: 0x06009A3A RID: 39482 RVA: 0x000DBB55 File Offset: 0x000D9D55
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

		// Token: 0x170024C1 RID: 9409
		// (get) Token: 0x06009A3B RID: 39483 RVA: 0x000DBB63 File Offset: 0x000D9D63
		// (set) Token: 0x06009A3C RID: 39484 RVA: 0x000DBB73 File Offset: 0x000D9D73
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

		// Token: 0x170024C2 RID: 9410
		// (get) Token: 0x06009A3D RID: 39485 RVA: 0x000DBB84 File Offset: 0x000D9D84
		// (set) Token: 0x06009A3E RID: 39486 RVA: 0x000DBB94 File Offset: 0x000D9D94
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

		// Token: 0x170024C3 RID: 9411
		// (get) Token: 0x06009A3F RID: 39487 RVA: 0x000DBBA5 File Offset: 0x000D9DA5
		// (set) Token: 0x06009A40 RID: 39488 RVA: 0x000DBBB5 File Offset: 0x000D9DB5
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

		// Token: 0x170024C4 RID: 9412
		// (get) Token: 0x06009A41 RID: 39489 RVA: 0x000DBBC8 File Offset: 0x000D9DC8
		// (set) Token: 0x06009A42 RID: 39490 RVA: 0x000DBC01 File Offset: 0x000D9E01
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

		// Token: 0x06009A43 RID: 39491 RVA: 0x000DBC22 File Offset: 0x000D9E22
		public void ValidateSettings()
		{
			UGameUserSettings.__ValidateSettings_Internal(base.NativePtr);
		}

		// Token: 0x06009A44 RID: 39492 RVA: 0x000DBC2F File Offset: 0x000D9E2F
		public bool SupportsHDRDisplayOutput()
		{
			return UGameUserSettings.__SupportsHDRDisplayOutput_Internal(base.NativePtr);
		}

		// Token: 0x06009A45 RID: 39493 RVA: 0x000DBC3C File Offset: 0x000D9E3C
		public void SetVSyncEnabled(bool bEnable)
		{
			UGameUserSettings.__SetVSyncEnabled_Internal(base.NativePtr, bEnable);
		}

		// Token: 0x06009A46 RID: 39494 RVA: 0x000DBC4A File Offset: 0x000D9E4A
		public void SetVisualEffectQuality(int Value)
		{
			UGameUserSettings.__SetVisualEffectQuality_Internal(base.NativePtr, Value);
		}

		// Token: 0x06009A47 RID: 39495 RVA: 0x000DBC58 File Offset: 0x000D9E58
		public void SetViewDistanceQuality(int Value)
		{
			UGameUserSettings.__SetViewDistanceQuality_Internal(base.NativePtr, Value);
		}

		// Token: 0x06009A48 RID: 39496 RVA: 0x000DBC66 File Offset: 0x000D9E66
		public void SetToDefaults()
		{
			UGameUserSettings.__SetToDefaults_Internal(base.NativePtr);
		}

		// Token: 0x06009A49 RID: 39497 RVA: 0x000DBC73 File Offset: 0x000D9E73
		public void SetTextureQuality(int Value)
		{
			UGameUserSettings.__SetTextureQuality_Internal(base.NativePtr, Value);
		}

		// Token: 0x06009A4A RID: 39498 RVA: 0x000DBC81 File Offset: 0x000D9E81
		public void SetShadowQuality(int Value)
		{
			UGameUserSettings.__SetShadowQuality_Internal(base.NativePtr, Value);
		}

		// Token: 0x06009A4B RID: 39499 RVA: 0x000DBC8F File Offset: 0x000D9E8F
		public void SetShadingQuality(int Value)
		{
			UGameUserSettings.__SetShadingQuality_Internal(base.NativePtr, Value);
		}

		// Token: 0x06009A4C RID: 39500 RVA: 0x000DBC9D File Offset: 0x000D9E9D
		public void SetScreenResolution(FIntPoint Resolution)
		{
			UGameUserSettings.__SetScreenResolution_Internal(base.NativePtr, Resolution);
		}

		// Token: 0x06009A4D RID: 39501 RVA: 0x000DBCAB File Offset: 0x000D9EAB
		public void SetResolutionScaleValueEx(float NewScaleValue)
		{
			UGameUserSettings.__SetResolutionScaleValueEx_Internal(base.NativePtr, NewScaleValue);
		}

		// Token: 0x06009A4E RID: 39502 RVA: 0x000DBCB9 File Offset: 0x000D9EB9
		public void SetResolutionScaleValue(int NewScaleValue)
		{
			UGameUserSettings.__SetResolutionScaleValue_Internal(base.NativePtr, NewScaleValue);
		}

		// Token: 0x06009A4F RID: 39503 RVA: 0x000DBCC7 File Offset: 0x000D9EC7
		public void SetResolutionScaleNormalized(float NewScaleNormalized)
		{
			UGameUserSettings.__SetResolutionScaleNormalized_Internal(base.NativePtr, NewScaleNormalized);
		}

		// Token: 0x06009A50 RID: 39504 RVA: 0x000DBCD5 File Offset: 0x000D9ED5
		public void SetPostProcessingQuality(int Value)
		{
			UGameUserSettings.__SetPostProcessingQuality_Internal(base.NativePtr, Value);
		}

		// Token: 0x06009A51 RID: 39505 RVA: 0x000DBCE3 File Offset: 0x000D9EE3
		public void SetOverallScalabilityLevel(int Value)
		{
			UGameUserSettings.__SetOverallScalabilityLevel_Internal(base.NativePtr, Value);
		}

		// Token: 0x06009A52 RID: 39506 RVA: 0x000DBCF1 File Offset: 0x000D9EF1
		public void SetMobileGameQualitySettingLevel(float InGameQualitySettingLevel)
		{
			UGameUserSettings.__SetMobileGameQualitySettingLevel_Internal(base.NativePtr, InGameQualitySettingLevel);
		}

		// Token: 0x06009A53 RID: 39507 RVA: 0x000DBCFF File Offset: 0x000D9EFF
		public void SetGameQualitySettingLevel(float InGameQualitySettingLevel)
		{
			UGameUserSettings.__SetGameQualitySettingLevel_Internal(base.NativePtr, InGameQualitySettingLevel);
		}

		// Token: 0x06009A54 RID: 39508 RVA: 0x000DBD0D File Offset: 0x000D9F0D
		public void SetFullscreenMode(EWindowMode InFullscreenMode)
		{
			UGameUserSettings.__SetFullscreenMode_Internal(base.NativePtr, InFullscreenMode);
		}

		// Token: 0x06009A55 RID: 39509 RVA: 0x000DBD20 File Offset: 0x000D9F20
		public void SetFrameRateLimit(float NewLimit)
		{
			UGameUserSettings.__SetFrameRateLimit_Internal(base.NativePtr, NewLimit);
		}

		// Token: 0x06009A56 RID: 39510 RVA: 0x000DBD2E File Offset: 0x000D9F2E
		public void SetFramePace(int NewPace)
		{
			UGameUserSettings.__SetFramePace_Internal(base.NativePtr, NewPace);
		}

		// Token: 0x06009A57 RID: 39511 RVA: 0x000DBD3C File Offset: 0x000D9F3C
		public void SetFoliageQuality(int Value)
		{
			UGameUserSettings.__SetFoliageQuality_Internal(base.NativePtr, Value);
		}

		// Token: 0x06009A58 RID: 39512 RVA: 0x000DBD4A File Offset: 0x000D9F4A
		public void SetDynamicResolutionEnabled(bool bEnable)
		{
			UGameUserSettings.__SetDynamicResolutionEnabled_Internal(base.NativePtr, bEnable);
		}

		// Token: 0x06009A59 RID: 39513 RVA: 0x000DBD58 File Offset: 0x000D9F58
		public void SetBenchmarkFallbackValues()
		{
			UGameUserSettings.__SetBenchmarkFallbackValues_Internal(base.NativePtr);
		}

		// Token: 0x06009A5A RID: 39514 RVA: 0x000DBD65 File Offset: 0x000D9F65
		public void SetAudioQualityLevel(int QualityLevel)
		{
			UGameUserSettings.__SetAudioQualityLevel_Internal(base.NativePtr, QualityLevel);
		}

		// Token: 0x06009A5B RID: 39515 RVA: 0x000DBD73 File Offset: 0x000D9F73
		public void SetAntiAliasingQuality(int Value)
		{
			UGameUserSettings.__SetAntiAliasingQuality_Internal(base.NativePtr, Value);
		}

		// Token: 0x06009A5C RID: 39516 RVA: 0x000DBD81 File Offset: 0x000D9F81
		public void SaveSettings()
		{
			UGameUserSettings.__SaveSettings_Internal(base.NativePtr);
		}

		// Token: 0x06009A5D RID: 39517 RVA: 0x000DBD8E File Offset: 0x000D9F8E
		public void RunHardwareBenchmark(int WorkScale = 10, float CPUMultiplier = 1f, float GPUMultiplier = 1f)
		{
			UGameUserSettings.__RunHardwareBenchmark_Internal(base.NativePtr, WorkScale, CPUMultiplier, GPUMultiplier);
		}

		// Token: 0x06009A5E RID: 39518 RVA: 0x000DBD9E File Offset: 0x000D9F9E
		public void RevertVideoMode()
		{
			UGameUserSettings.__RevertVideoMode_Internal(base.NativePtr);
		}

		// Token: 0x06009A5F RID: 39519 RVA: 0x000DBDAB File Offset: 0x000D9FAB
		public void ResetToCurrentSettings()
		{
			UGameUserSettings.__ResetToCurrentSettings_Internal(base.NativePtr);
		}

		// Token: 0x06009A60 RID: 39520 RVA: 0x000DBDB8 File Offset: 0x000D9FB8
		public void LoadSettings(bool bForceReload = false)
		{
			UGameUserSettings.__LoadSettings_Internal(base.NativePtr, bForceReload);
		}

		// Token: 0x06009A61 RID: 39521 RVA: 0x000DBDC6 File Offset: 0x000D9FC6
		public bool IsVSyncEnabled()
		{
			return UGameUserSettings.__IsVSyncEnabled_Internal(base.NativePtr);
		}

		// Token: 0x06009A62 RID: 39522 RVA: 0x000DBDD3 File Offset: 0x000D9FD3
		public bool IsVSyncDirty()
		{
			return UGameUserSettings.__IsVSyncDirty_Internal(base.NativePtr);
		}

		// Token: 0x06009A63 RID: 39523 RVA: 0x000DBDE0 File Offset: 0x000D9FE0
		public bool IsScreenResolutionDirty()
		{
			return UGameUserSettings.__IsScreenResolutionDirty_Internal(base.NativePtr);
		}

		// Token: 0x06009A64 RID: 39524 RVA: 0x000DBDED File Offset: 0x000D9FED
		public bool IsHDREnabled()
		{
			return UGameUserSettings.__IsHDREnabled_Internal(base.NativePtr);
		}

		// Token: 0x06009A65 RID: 39525 RVA: 0x000DBDFA File Offset: 0x000D9FFA
		public bool IsFullscreenModeDirty()
		{
			return UGameUserSettings.__IsFullscreenModeDirty_Internal(base.NativePtr);
		}

		// Token: 0x06009A66 RID: 39526 RVA: 0x000DBE07 File Offset: 0x000DA007
		public bool IsDynamicResolutionEnabled()
		{
			return UGameUserSettings.__IsDynamicResolutionEnabled_Internal(base.NativePtr);
		}

		// Token: 0x06009A67 RID: 39527 RVA: 0x000DBE14 File Offset: 0x000DA014
		public bool IsDynamicResolutionDirty()
		{
			return UGameUserSettings.__IsDynamicResolutionDirty_Internal(base.NativePtr);
		}

		// Token: 0x06009A68 RID: 39528 RVA: 0x000DBE21 File Offset: 0x000DA021
		public bool IsDirty()
		{
			return UGameUserSettings.__IsDirty_Internal(base.NativePtr);
		}

		// Token: 0x06009A69 RID: 39529 RVA: 0x000DBE2E File Offset: 0x000DA02E
		public int GetVisualEffectQuality()
		{
			return UGameUserSettings.__GetVisualEffectQuality_Internal(base.NativePtr);
		}

		// Token: 0x06009A6A RID: 39530 RVA: 0x000DBE3B File Offset: 0x000DA03B
		public int GetViewDistanceQuality()
		{
			return UGameUserSettings.__GetViewDistanceQuality_Internal(base.NativePtr);
		}

		// Token: 0x06009A6B RID: 39531 RVA: 0x000DBE48 File Offset: 0x000DA048
		public int GetTextureQuality()
		{
			return UGameUserSettings.__GetTextureQuality_Internal(base.NativePtr);
		}

		// Token: 0x06009A6C RID: 39532
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetSyncInterval();

		// Token: 0x06009A6D RID: 39533 RVA: 0x000DBE55 File Offset: 0x000DA055
		public int GetShadowQuality()
		{
			return UGameUserSettings.__GetShadowQuality_Internal(base.NativePtr);
		}

		// Token: 0x06009A6E RID: 39534 RVA: 0x000DBE62 File Offset: 0x000DA062
		public int GetShadingQuality()
		{
			return UGameUserSettings.__GetShadingQuality_Internal(base.NativePtr);
		}

		// Token: 0x06009A6F RID: 39535 RVA: 0x000DBE6F File Offset: 0x000DA06F
		public FIntPoint GetScreenResolution()
		{
			return UGameUserSettings.__GetScreenResolution_Internal(base.NativePtr);
		}

		// Token: 0x06009A70 RID: 39536 RVA: 0x000DBE7C File Offset: 0x000DA07C
		public float GetResolutionScaleNormalized()
		{
			return UGameUserSettings.__GetResolutionScaleNormalized_Internal(base.NativePtr);
		}

		// Token: 0x06009A71 RID: 39537 RVA: 0x000DBE8C File Offset: 0x000DA08C
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

		// Token: 0x06009A72 RID: 39538 RVA: 0x000DBED8 File Offset: 0x000DA0D8
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

		// Token: 0x06009A73 RID: 39539 RVA: 0x000DBF22 File Offset: 0x000DA122
		public float GetRecommendedResolutionScale()
		{
			return UGameUserSettings.__GetRecommendedResolutionScale_Internal(base.NativePtr);
		}

		// Token: 0x06009A74 RID: 39540 RVA: 0x000DBF2F File Offset: 0x000DA12F
		public TEnumAsByte<EWindowMode> GetPreferredFullscreenMode()
		{
			return UGameUserSettings.__GetPreferredFullscreenMode_Internal(base.NativePtr);
		}

		// Token: 0x06009A75 RID: 39541 RVA: 0x000DBF3C File Offset: 0x000DA13C
		public int GetPostProcessingQuality()
		{
			return UGameUserSettings.__GetPostProcessingQuality_Internal(base.NativePtr);
		}

		// Token: 0x06009A76 RID: 39542 RVA: 0x000DBF49 File Offset: 0x000DA149
		public int GetOverallScalabilityLevel()
		{
			return UGameUserSettings.__GetOverallScalabilityLevel_Internal(base.NativePtr);
		}

		// Token: 0x06009A77 RID: 39543 RVA: 0x000DBF56 File Offset: 0x000DA156
		public int GetMobileGameQualitySettingLevel()
		{
			return UGameUserSettings.__GetMobileGameQualitySettingLevel_Internal(base.NativePtr);
		}

		// Token: 0x06009A78 RID: 39544 RVA: 0x000DBF63 File Offset: 0x000DA163
		public FIntPoint GetLastConfirmedScreenResolution()
		{
			return UGameUserSettings.__GetLastConfirmedScreenResolution_Internal(base.NativePtr);
		}

		// Token: 0x06009A79 RID: 39545 RVA: 0x000DBF70 File Offset: 0x000DA170
		public TEnumAsByte<EWindowMode> GetLastConfirmedFullscreenMode()
		{
			return UGameUserSettings.__GetLastConfirmedFullscreenMode_Internal(base.NativePtr);
		}

		// Token: 0x06009A7A RID: 39546 RVA: 0x000DBF7D File Offset: 0x000DA17D
		[NullableContext(2)]
		public static UGameUserSettings GetGameUserSettings()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UGameUserSettings>(UGameUserSettings.__GetGameUserSettings_Internal());
		}

		// Token: 0x06009A7B RID: 39547 RVA: 0x000DBF89 File Offset: 0x000DA189
		public int GetGameQualitySettingLevel()
		{
			return UGameUserSettings.__GetGameQualitySettingLevel_Internal(base.NativePtr);
		}

		// Token: 0x06009A7C RID: 39548 RVA: 0x000DBF96 File Offset: 0x000DA196
		public TEnumAsByte<EWindowMode> GetFullscreenMode()
		{
			return UGameUserSettings.__GetFullscreenMode_Internal(base.NativePtr);
		}

		// Token: 0x06009A7D RID: 39549 RVA: 0x000DBFA3 File Offset: 0x000DA1A3
		public float GetFrameRateLimit()
		{
			return UGameUserSettings.__GetFrameRateLimit_Internal(base.NativePtr);
		}

		// Token: 0x06009A7E RID: 39550
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetFramePace();

		// Token: 0x06009A7F RID: 39551 RVA: 0x000DBFB0 File Offset: 0x000DA1B0
		public int GetFoliageQuality()
		{
			return UGameUserSettings.__GetFoliageQuality_Internal(base.NativePtr);
		}

		// Token: 0x06009A80 RID: 39552 RVA: 0x000DBFBD File Offset: 0x000DA1BD
		public FIntPoint GetDesktopResolution()
		{
			return UGameUserSettings.__GetDesktopResolution_Internal(base.NativePtr);
		}

		// Token: 0x06009A81 RID: 39553
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FIntPoint GetDefaultWindowPosition();

		// Token: 0x06009A82 RID: 39554
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern TEnumAsByte<EWindowMode> GetDefaultWindowMode();

		// Token: 0x06009A83 RID: 39555 RVA: 0x000DBFCA File Offset: 0x000DA1CA
		public float GetDefaultResolutionScale()
		{
			return UGameUserSettings.__GetDefaultResolutionScale_Internal(base.NativePtr);
		}

		// Token: 0x06009A84 RID: 39556
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FIntPoint GetDefaultResolution();

		// Token: 0x06009A85 RID: 39557 RVA: 0x000DBFD7 File Offset: 0x000DA1D7
		public int GetCurrentHDRDisplayNits()
		{
			return UGameUserSettings.__GetCurrentHDRDisplayNits_Internal(base.NativePtr);
		}

		// Token: 0x06009A86 RID: 39558 RVA: 0x000DBFE4 File Offset: 0x000DA1E4
		public int GetAudioQualityLevel()
		{
			return UGameUserSettings.__GetAudioQualityLevel_Internal(base.NativePtr);
		}

		// Token: 0x06009A87 RID: 39559 RVA: 0x000DBFF1 File Offset: 0x000DA1F1
		public int GetAntiAliasingQuality()
		{
			return UGameUserSettings.__GetAntiAliasingQuality_Internal(base.NativePtr);
		}

		// Token: 0x06009A88 RID: 39560 RVA: 0x000DBFFE File Offset: 0x000DA1FE
		public void EnableHDRDisplayOutput(bool bEnable, int DisplayNits = 1000)
		{
			UGameUserSettings.__EnableHDRDisplayOutput_Internal(base.NativePtr, bEnable, DisplayNits);
		}

		// Token: 0x06009A89 RID: 39561 RVA: 0x000DC00D File Offset: 0x000DA20D
		public void ConfirmVideoMode()
		{
			UGameUserSettings.__ConfirmVideoMode_Internal(base.NativePtr);
		}

		// Token: 0x06009A8A RID: 39562 RVA: 0x000DC01A File Offset: 0x000DA21A
		public void ApplySettings(bool bCheckForCommandLineOverrides)
		{
			UGameUserSettings.__ApplySettings_Internal(base.NativePtr, bCheckForCommandLineOverrides);
		}

		// Token: 0x06009A8B RID: 39563 RVA: 0x000DC028 File Offset: 0x000DA228
		public void ApplyResolutionSettings(bool bCheckForCommandLineOverrides)
		{
			UGameUserSettings.__ApplyResolutionSettings_Internal(base.NativePtr, bCheckForCommandLineOverrides);
		}

		// Token: 0x06009A8C RID: 39564 RVA: 0x000DC036 File Offset: 0x000DA236
		public void ApplyNonResolutionSettings()
		{
			UGameUserSettings.__ApplyNonResolutionSettings_Internal(base.NativePtr);
		}

		// Token: 0x06009A8D RID: 39565 RVA: 0x000DC043 File Offset: 0x000DA243
		public void ApplyHardwareBenchmarkResults()
		{
			UGameUserSettings.__ApplyHardwareBenchmarkResults_Internal(base.NativePtr);
		}

		// Token: 0x06009A8E RID: 39566
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ValidateSettings_Internal(IntPtr @this);

		// Token: 0x06009A8F RID: 39567
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SupportsHDRDisplayOutput_Internal(IntPtr @this);

		// Token: 0x06009A90 RID: 39568
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVSyncEnabled_Internal(IntPtr @this, bool bEnable);

		// Token: 0x06009A91 RID: 39569
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVisualEffectQuality_Internal(IntPtr @this, int Value);

		// Token: 0x06009A92 RID: 39570
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetViewDistanceQuality_Internal(IntPtr @this, int Value);

		// Token: 0x06009A93 RID: 39571
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToDefaults_Internal(IntPtr @this);

		// Token: 0x06009A94 RID: 39572
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTextureQuality_Internal(IntPtr @this, int Value);

		// Token: 0x06009A95 RID: 39573
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShadowQuality_Internal(IntPtr @this, int Value);

		// Token: 0x06009A96 RID: 39574
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShadingQuality_Internal(IntPtr @this, int Value);

		// Token: 0x06009A97 RID: 39575
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetScreenResolution_Internal(IntPtr @this, FIntPoint Resolution);

		// Token: 0x06009A98 RID: 39576
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetResolutionScaleValueEx_Internal(IntPtr @this, float NewScaleValue);

		// Token: 0x06009A99 RID: 39577
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetResolutionScaleValue_Internal(IntPtr @this, int NewScaleValue);

		// Token: 0x06009A9A RID: 39578
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetResolutionScaleNormalized_Internal(IntPtr @this, float NewScaleNormalized);

		// Token: 0x06009A9B RID: 39579
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPostProcessingQuality_Internal(IntPtr @this, int Value);

		// Token: 0x06009A9C RID: 39580
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOverallScalabilityLevel_Internal(IntPtr @this, int Value);

		// Token: 0x06009A9D RID: 39581
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMobileGameQualitySettingLevel_Internal(IntPtr @this, float InGameQualitySettingLevel);

		// Token: 0x06009A9E RID: 39582
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGameQualitySettingLevel_Internal(IntPtr @this, float InGameQualitySettingLevel);

		// Token: 0x06009A9F RID: 39583
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFullscreenMode_Internal(IntPtr @this, TEnumAsByte<EWindowMode> InFullscreenMode);

		// Token: 0x06009AA0 RID: 39584
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFrameRateLimit_Internal(IntPtr @this, float NewLimit);

		// Token: 0x06009AA1 RID: 39585
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFramePace_Internal(IntPtr @this, int NewPace);

		// Token: 0x06009AA2 RID: 39586
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFoliageQuality_Internal(IntPtr @this, int Value);

		// Token: 0x06009AA3 RID: 39587
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDynamicResolutionEnabled_Internal(IntPtr @this, bool bEnable);

		// Token: 0x06009AA4 RID: 39588
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBenchmarkFallbackValues_Internal(IntPtr @this);

		// Token: 0x06009AA5 RID: 39589
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAudioQualityLevel_Internal(IntPtr @this, int QualityLevel);

		// Token: 0x06009AA6 RID: 39590
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAntiAliasingQuality_Internal(IntPtr @this, int Value);

		// Token: 0x06009AA7 RID: 39591
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SaveSettings_Internal(IntPtr @this);

		// Token: 0x06009AA8 RID: 39592
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RunHardwareBenchmark_Internal(IntPtr @this, int WorkScale, float CPUMultiplier, float GPUMultiplier);

		// Token: 0x06009AA9 RID: 39593
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RevertVideoMode_Internal(IntPtr @this);

		// Token: 0x06009AAA RID: 39594
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetToCurrentSettings_Internal(IntPtr @this);

		// Token: 0x06009AAB RID: 39595
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LoadSettings_Internal(IntPtr @this, bool bForceReload);

		// Token: 0x06009AAC RID: 39596
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsVSyncEnabled_Internal(IntPtr @this);

		// Token: 0x06009AAD RID: 39597
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsVSyncDirty_Internal(IntPtr @this);

		// Token: 0x06009AAE RID: 39598
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsScreenResolutionDirty_Internal(IntPtr @this);

		// Token: 0x06009AAF RID: 39599
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsHDREnabled_Internal(IntPtr @this);

		// Token: 0x06009AB0 RID: 39600
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsFullscreenModeDirty_Internal(IntPtr @this);

		// Token: 0x06009AB1 RID: 39601
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsDynamicResolutionEnabled_Internal(IntPtr @this);

		// Token: 0x06009AB2 RID: 39602
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsDynamicResolutionDirty_Internal(IntPtr @this);

		// Token: 0x06009AB3 RID: 39603
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsDirty_Internal(IntPtr @this);

		// Token: 0x06009AB4 RID: 39604
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetVisualEffectQuality_Internal(IntPtr @this);

		// Token: 0x06009AB5 RID: 39605
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetViewDistanceQuality_Internal(IntPtr @this);

		// Token: 0x06009AB6 RID: 39606
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetTextureQuality_Internal(IntPtr @this);

		// Token: 0x06009AB7 RID: 39607
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetShadowQuality_Internal(IntPtr @this);

		// Token: 0x06009AB8 RID: 39608
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetShadingQuality_Internal(IntPtr @this);

		// Token: 0x06009AB9 RID: 39609
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntPoint __GetScreenResolution_Internal(IntPtr @this);

		// Token: 0x06009ABA RID: 39610
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetResolutionScaleNormalized_Internal(IntPtr @this);

		// Token: 0x06009ABB RID: 39611
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetResolutionScaleInformationEx_Internal(IntPtr @this, ref float CurrentScaleNormalized, ref float CurrentScaleValue, ref float MinScaleValue, ref float MaxScaleValue);

		// Token: 0x06009ABC RID: 39612
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetResolutionScaleInformation_Internal(IntPtr @this, ref float CurrentScaleNormalized, ref int CurrentScaleValue, ref int MinScaleValue, ref int MaxScaleValue);

		// Token: 0x06009ABD RID: 39613
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRecommendedResolutionScale_Internal(IntPtr @this);

		// Token: 0x06009ABE RID: 39614
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<EWindowMode> __GetPreferredFullscreenMode_Internal(IntPtr @this);

		// Token: 0x06009ABF RID: 39615
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetPostProcessingQuality_Internal(IntPtr @this);

		// Token: 0x06009AC0 RID: 39616
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetOverallScalabilityLevel_Internal(IntPtr @this);

		// Token: 0x06009AC1 RID: 39617
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMobileGameQualitySettingLevel_Internal(IntPtr @this);

		// Token: 0x06009AC2 RID: 39618
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntPoint __GetLastConfirmedScreenResolution_Internal(IntPtr @this);

		// Token: 0x06009AC3 RID: 39619
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<EWindowMode> __GetLastConfirmedFullscreenMode_Internal(IntPtr @this);

		// Token: 0x06009AC4 RID: 39620
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGameUserSettings_Internal();

		// Token: 0x06009AC5 RID: 39621
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetGameQualitySettingLevel_Internal(IntPtr @this);

		// Token: 0x06009AC6 RID: 39622
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<EWindowMode> __GetFullscreenMode_Internal(IntPtr @this);

		// Token: 0x06009AC7 RID: 39623
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetFrameRateLimit_Internal(IntPtr @this);

		// Token: 0x06009AC8 RID: 39624
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetFoliageQuality_Internal(IntPtr @this);

		// Token: 0x06009AC9 RID: 39625
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntPoint __GetDesktopResolution_Internal(IntPtr @this);

		// Token: 0x06009ACA RID: 39626
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetDefaultResolutionScale_Internal(IntPtr @this);

		// Token: 0x06009ACB RID: 39627
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetCurrentHDRDisplayNits_Internal(IntPtr @this);

		// Token: 0x06009ACC RID: 39628
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetAudioQualityLevel_Internal(IntPtr @this);

		// Token: 0x06009ACD RID: 39629
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetAntiAliasingQuality_Internal(IntPtr @this);

		// Token: 0x06009ACE RID: 39630
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EnableHDRDisplayOutput_Internal(IntPtr @this, bool bEnable, int DisplayNits);

		// Token: 0x06009ACF RID: 39631
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ConfirmVideoMode_Internal(IntPtr @this);

		// Token: 0x06009AD0 RID: 39632
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplySettings_Internal(IntPtr @this, bool bCheckForCommandLineOverrides);

		// Token: 0x06009AD1 RID: 39633
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyResolutionSettings_Internal(IntPtr @this, bool bCheckForCommandLineOverrides);

		// Token: 0x06009AD2 RID: 39634
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyNonResolutionSettings_Internal(IntPtr @this);

		// Token: 0x06009AD3 RID: 39635
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyHardwareBenchmarkResults_Internal(IntPtr @this);

		// Token: 0x06009AD4 RID: 39636 RVA: 0x000DC050 File Offset: 0x000DA250
		static UGameUserSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.GameUserSettings");
		}

		// Token: 0x06009AD5 RID: 39637 RVA: 0x000DC05E File Offset: 0x000DA25E
		protected UGameUserSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005553 RID: 21843
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.GameUserSettings";

		// Token: 0x04005554 RID: 21844
		private static IntPtr _ClassPtr;

		// Token: 0x04005555 RID: 21845
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005556 RID: 21846
		internal static int __PropertyOffset_bUseVSync;

		// Token: 0x04005557 RID: 21847
		internal static int __PropertyOffset_bUseDynamicResolution;

		// Token: 0x04005558 RID: 21848
		internal static int __PropertyOffset_ResolutionSizeX;

		// Token: 0x04005559 RID: 21849
		internal static int __PropertyOffset_ResolutionSizeY;

		// Token: 0x0400555A RID: 21850
		internal static int __PropertyOffset_LastUserConfirmedResolutionSizeX;

		// Token: 0x0400555B RID: 21851
		internal static int __PropertyOffset_LastUserConfirmedResolutionSizeY;

		// Token: 0x0400555C RID: 21852
		internal static int __PropertyOffset_WindowPosX;

		// Token: 0x0400555D RID: 21853
		internal static int __PropertyOffset_WindowPosY;

		// Token: 0x0400555E RID: 21854
		internal static int __PropertyOffset_FullscreenMode;

		// Token: 0x0400555F RID: 21855
		internal static int __PropertyOffset_GameQualitySettingLevel;

		// Token: 0x04005560 RID: 21856
		internal static int __PropertyOffset_LastConfirmedFullscreenMode;

		// Token: 0x04005561 RID: 21857
		internal static int __PropertyOffset_PreferredFullscreenMode;

		// Token: 0x04005562 RID: 21858
		internal static int __PropertyOffset_Version;

		// Token: 0x04005563 RID: 21859
		internal static int __PropertyOffset_AudioQualityLevel;

		// Token: 0x04005564 RID: 21860
		internal static int __PropertyOffset_LastConfirmedAudioQualityLevel;

		// Token: 0x04005565 RID: 21861
		internal static int __PropertyOffset_FrameRateLimit;

		// Token: 0x04005566 RID: 21862
		internal static int __PropertyOffset_FramePace;

		// Token: 0x04005567 RID: 21863
		internal static int __PropertyOffset_DesiredScreenWidth;

		// Token: 0x04005568 RID: 21864
		internal static int __PropertyOffset_bUseDesiredScreenHeight;

		// Token: 0x04005569 RID: 21865
		internal static int __PropertyOffset_DesiredScreenHeight;

		// Token: 0x0400556A RID: 21866
		internal static int __PropertyOffset_LastUserConfirmedDesiredScreenWidth;

		// Token: 0x0400556B RID: 21867
		internal static int __PropertyOffset_LastUserConfirmedDesiredScreenHeight;

		// Token: 0x0400556C RID: 21868
		internal static int __PropertyOffset_LastRecommendedScreenWidth;

		// Token: 0x0400556D RID: 21869
		internal static int __PropertyOffset_LastRecommendedScreenHeight;

		// Token: 0x0400556E RID: 21870
		internal static int __PropertyOffset_LastCPUBenchmarkResult;

		// Token: 0x0400556F RID: 21871
		internal static int __PropertyOffset_LastGPUBenchmarkResult;

		// Token: 0x04005570 RID: 21872
		internal static int __PropertyOffset_LastCPUBenchmarkSteps;

		// Token: 0x04005571 RID: 21873
		[Nullable(2)]
		private TArray<float> _LastCPUBenchmarkSteps;

		// Token: 0x04005572 RID: 21874
		internal static int __PropertyOffset_LastGPUBenchmarkSteps;

		// Token: 0x04005573 RID: 21875
		[Nullable(2)]
		private TArray<float> _LastGPUBenchmarkSteps;

		// Token: 0x04005574 RID: 21876
		internal static int __PropertyOffset_LastGPUBenchmarkMultiplier;

		// Token: 0x04005575 RID: 21877
		internal static int __PropertyOffset_bUseHDRDisplayOutput;

		// Token: 0x04005576 RID: 21878
		internal static int __PropertyOffset_HDRDisplayOutputNits;

		// Token: 0x04005577 RID: 21879
		internal static int __PropertyOffset_OnGameUserSettingsUINeedsUpdate;

		// Token: 0x04005578 RID: 21880
		[Nullable(2)]
		private FOnGameUserSettingsUINeedsUpdate _OnGameUserSettingsUINeedsUpdate;
	}
}
