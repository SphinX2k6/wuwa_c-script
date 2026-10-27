using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000BFF RID: 3071
	[UnrealObjectPath("/Script/Engine.GameNetworkManager")]
	[UnrealStructLayout(1224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1224)]
	public class AGameNetworkManager : AInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600982D RID: 38957 RVA: 0x000D8B7C File Offset: 0x000D6D7C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AGameNetworkManager._ClassPtr;
		}

		// Token: 0x0600982E RID: 38958 RVA: 0x000D8B88 File Offset: 0x000D6D88
		public AGameNetworkManager() : this(BuiltinUtils.AllocNativeUObject(AGameNetworkManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600982F RID: 38959 RVA: 0x000D8BB0 File Offset: 0x000D6DB0
		[NullableContext(1)]
		public AGameNetworkManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AGameNetworkManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002468 RID: 9320
		// (get) Token: 0x06009830 RID: 38960 RVA: 0x000D8BE3 File Offset: 0x000D6DE3
		// (set) Token: 0x06009831 RID: 38961 RVA: 0x000D8BF3 File Offset: 0x000D6DF3
		public unsafe float BadPacketLossThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_BadPacketLossThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_BadPacketLossThreshold) = value;
			}
		}

		// Token: 0x17002469 RID: 9321
		// (get) Token: 0x06009832 RID: 38962 RVA: 0x000D8C04 File Offset: 0x000D6E04
		// (set) Token: 0x06009833 RID: 38963 RVA: 0x000D8C14 File Offset: 0x000D6E14
		public unsafe float SeverePacketLossThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_SeverePacketLossThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_SeverePacketLossThreshold) = value;
			}
		}

		// Token: 0x1700246A RID: 9322
		// (get) Token: 0x06009834 RID: 38964 RVA: 0x000D8C25 File Offset: 0x000D6E25
		// (set) Token: 0x06009835 RID: 38965 RVA: 0x000D8C35 File Offset: 0x000D6E35
		public unsafe int BadPingThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_BadPingThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_BadPingThreshold) = value;
			}
		}

		// Token: 0x1700246B RID: 9323
		// (get) Token: 0x06009836 RID: 38966 RVA: 0x000D8C46 File Offset: 0x000D6E46
		// (set) Token: 0x06009837 RID: 38967 RVA: 0x000D8C56 File Offset: 0x000D6E56
		public unsafe int SeverePingThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_SeverePingThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_SeverePingThreshold) = value;
			}
		}

		// Token: 0x1700246C RID: 9324
		// (get) Token: 0x06009838 RID: 38968 RVA: 0x000D8C67 File Offset: 0x000D6E67
		// (set) Token: 0x06009839 RID: 38969 RVA: 0x000D8C77 File Offset: 0x000D6E77
		public unsafe int AdjustedNetSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_AdjustedNetSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_AdjustedNetSpeed) = value;
			}
		}

		// Token: 0x1700246D RID: 9325
		// (get) Token: 0x0600983A RID: 38970 RVA: 0x000D8C88 File Offset: 0x000D6E88
		// (set) Token: 0x0600983B RID: 38971 RVA: 0x000D8C98 File Offset: 0x000D6E98
		public unsafe float LastNetSpeedUpdateTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_LastNetSpeedUpdateTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_LastNetSpeedUpdateTime) = value;
			}
		}

		// Token: 0x1700246E RID: 9326
		// (get) Token: 0x0600983C RID: 38972 RVA: 0x000D8CA9 File Offset: 0x000D6EA9
		// (set) Token: 0x0600983D RID: 38973 RVA: 0x000D8CB9 File Offset: 0x000D6EB9
		public unsafe int TotalNetBandwidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_TotalNetBandwidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_TotalNetBandwidth) = value;
			}
		}

		// Token: 0x1700246F RID: 9327
		// (get) Token: 0x0600983E RID: 38974 RVA: 0x000D8CCA File Offset: 0x000D6ECA
		// (set) Token: 0x0600983F RID: 38975 RVA: 0x000D8CDA File Offset: 0x000D6EDA
		public unsafe int MinDynamicBandwidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_MinDynamicBandwidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_MinDynamicBandwidth) = value;
			}
		}

		// Token: 0x17002470 RID: 9328
		// (get) Token: 0x06009840 RID: 38976 RVA: 0x000D8CEB File Offset: 0x000D6EEB
		// (set) Token: 0x06009841 RID: 38977 RVA: 0x000D8CFB File Offset: 0x000D6EFB
		public unsafe int MaxDynamicBandwidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_MaxDynamicBandwidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_MaxDynamicBandwidth) = value;
			}
		}

		// Token: 0x17002471 RID: 9329
		// (get) Token: 0x06009842 RID: 38978 RVA: 0x000D8D0C File Offset: 0x000D6F0C
		// (set) Token: 0x06009843 RID: 38979 RVA: 0x000D8D25 File Offset: 0x000D6F25
		public unsafe bool bIsStandbyCheckingEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_bIsStandbyCheckingEnabled) & AGameNetworkManager.__PropertyMask_bIsStandbyCheckingEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_bIsStandbyCheckingEnabled) = ((*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_bIsStandbyCheckingEnabled) & ~AGameNetworkManager.__PropertyMask_bIsStandbyCheckingEnabled) | (value ? AGameNetworkManager.__PropertyMask_bIsStandbyCheckingEnabled : 0));
			}
		}

		// Token: 0x17002472 RID: 9330
		// (get) Token: 0x06009844 RID: 38980 RVA: 0x000D8D55 File Offset: 0x000D6F55
		// (set) Token: 0x06009845 RID: 38981 RVA: 0x000D8D6E File Offset: 0x000D6F6E
		public unsafe bool bHasStandbyCheatTriggered
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_bHasStandbyCheatTriggered) & AGameNetworkManager.__PropertyMask_bHasStandbyCheatTriggered) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_bHasStandbyCheatTriggered) = ((*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_bHasStandbyCheatTriggered) & ~AGameNetworkManager.__PropertyMask_bHasStandbyCheatTriggered) | (value ? AGameNetworkManager.__PropertyMask_bHasStandbyCheatTriggered : 0));
			}
		}

		// Token: 0x17002473 RID: 9331
		// (get) Token: 0x06009846 RID: 38982 RVA: 0x000D8D9E File Offset: 0x000D6F9E
		// (set) Token: 0x06009847 RID: 38983 RVA: 0x000D8DAE File Offset: 0x000D6FAE
		public unsafe float StandbyRxCheatTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_StandbyRxCheatTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_StandbyRxCheatTime) = value;
			}
		}

		// Token: 0x17002474 RID: 9332
		// (get) Token: 0x06009848 RID: 38984 RVA: 0x000D8DBF File Offset: 0x000D6FBF
		// (set) Token: 0x06009849 RID: 38985 RVA: 0x000D8DCF File Offset: 0x000D6FCF
		public unsafe float StandbyTxCheatTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_StandbyTxCheatTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_StandbyTxCheatTime) = value;
			}
		}

		// Token: 0x17002475 RID: 9333
		// (get) Token: 0x0600984A RID: 38986 RVA: 0x000D8DE0 File Offset: 0x000D6FE0
		// (set) Token: 0x0600984B RID: 38987 RVA: 0x000D8DF0 File Offset: 0x000D6FF0
		public unsafe float PercentMissingForRxStandby
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_PercentMissingForRxStandby);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_PercentMissingForRxStandby) = value;
			}
		}

		// Token: 0x17002476 RID: 9334
		// (get) Token: 0x0600984C RID: 38988 RVA: 0x000D8E01 File Offset: 0x000D7001
		// (set) Token: 0x0600984D RID: 38989 RVA: 0x000D8E11 File Offset: 0x000D7011
		public unsafe float PercentMissingForTxStandby
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_PercentMissingForTxStandby);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_PercentMissingForTxStandby) = value;
			}
		}

		// Token: 0x17002477 RID: 9335
		// (get) Token: 0x0600984E RID: 38990 RVA: 0x000D8E22 File Offset: 0x000D7022
		// (set) Token: 0x0600984F RID: 38991 RVA: 0x000D8E32 File Offset: 0x000D7032
		public unsafe float PercentForBadPing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_PercentForBadPing);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_PercentForBadPing) = value;
			}
		}

		// Token: 0x17002478 RID: 9336
		// (get) Token: 0x06009850 RID: 38992 RVA: 0x000D8E43 File Offset: 0x000D7043
		// (set) Token: 0x06009851 RID: 38993 RVA: 0x000D8E53 File Offset: 0x000D7053
		public unsafe float JoinInProgressStandbyWaitTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_JoinInProgressStandbyWaitTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_JoinInProgressStandbyWaitTime) = value;
			}
		}

		// Token: 0x17002479 RID: 9337
		// (get) Token: 0x06009852 RID: 38994 RVA: 0x000D8E64 File Offset: 0x000D7064
		// (set) Token: 0x06009853 RID: 38995 RVA: 0x000D8E74 File Offset: 0x000D7074
		public unsafe float MoveRepSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_MoveRepSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_MoveRepSize) = value;
			}
		}

		// Token: 0x1700247A RID: 9338
		// (get) Token: 0x06009854 RID: 38996 RVA: 0x000D8E85 File Offset: 0x000D7085
		// (set) Token: 0x06009855 RID: 38997 RVA: 0x000D8E95 File Offset: 0x000D7095
		public unsafe float MAXPOSITIONERRORSQUARED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_MAXPOSITIONERRORSQUARED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_MAXPOSITIONERRORSQUARED) = value;
			}
		}

		// Token: 0x1700247B RID: 9339
		// (get) Token: 0x06009856 RID: 38998 RVA: 0x000D8EA6 File Offset: 0x000D70A6
		// (set) Token: 0x06009857 RID: 38999 RVA: 0x000D8EB6 File Offset: 0x000D70B6
		public unsafe float MAXNEARZEROVELOCITYSQUARED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_MAXNEARZEROVELOCITYSQUARED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_MAXNEARZEROVELOCITYSQUARED) = value;
			}
		}

		// Token: 0x1700247C RID: 9340
		// (get) Token: 0x06009858 RID: 39000 RVA: 0x000D8EC7 File Offset: 0x000D70C7
		// (set) Token: 0x06009859 RID: 39001 RVA: 0x000D8ED7 File Offset: 0x000D70D7
		public unsafe float CLIENTADJUSTUPDATECOST
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_CLIENTADJUSTUPDATECOST);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_CLIENTADJUSTUPDATECOST) = value;
			}
		}

		// Token: 0x1700247D RID: 9341
		// (get) Token: 0x0600985A RID: 39002 RVA: 0x000D8EE8 File Offset: 0x000D70E8
		// (set) Token: 0x0600985B RID: 39003 RVA: 0x000D8EF8 File Offset: 0x000D70F8
		public unsafe float MAXCLIENTUPDATEINTERVAL
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_MAXCLIENTUPDATEINTERVAL);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_MAXCLIENTUPDATEINTERVAL) = value;
			}
		}

		// Token: 0x1700247E RID: 9342
		// (get) Token: 0x0600985C RID: 39004 RVA: 0x000D8F09 File Offset: 0x000D7109
		// (set) Token: 0x0600985D RID: 39005 RVA: 0x000D8F19 File Offset: 0x000D7119
		public unsafe float MaxClientForcedUpdateDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_MaxClientForcedUpdateDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_MaxClientForcedUpdateDuration) = value;
			}
		}

		// Token: 0x1700247F RID: 9343
		// (get) Token: 0x0600985E RID: 39006 RVA: 0x000D8F2A File Offset: 0x000D712A
		// (set) Token: 0x0600985F RID: 39007 RVA: 0x000D8F3A File Offset: 0x000D713A
		public unsafe float ServerForcedUpdateHitchThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_ServerForcedUpdateHitchThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_ServerForcedUpdateHitchThreshold) = value;
			}
		}

		// Token: 0x17002480 RID: 9344
		// (get) Token: 0x06009860 RID: 39008 RVA: 0x000D8F4B File Offset: 0x000D714B
		// (set) Token: 0x06009861 RID: 39009 RVA: 0x000D8F5B File Offset: 0x000D715B
		public unsafe float ServerForcedUpdateHitchCooldown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_ServerForcedUpdateHitchCooldown);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_ServerForcedUpdateHitchCooldown) = value;
			}
		}

		// Token: 0x17002481 RID: 9345
		// (get) Token: 0x06009862 RID: 39010 RVA: 0x000D8F6C File Offset: 0x000D716C
		// (set) Token: 0x06009863 RID: 39011 RVA: 0x000D8F7C File Offset: 0x000D717C
		public unsafe float MaxMoveDeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_MaxMoveDeltaTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_MaxMoveDeltaTime) = value;
			}
		}

		// Token: 0x17002482 RID: 9346
		// (get) Token: 0x06009864 RID: 39012 RVA: 0x000D8F8D File Offset: 0x000D718D
		// (set) Token: 0x06009865 RID: 39013 RVA: 0x000D8F9D File Offset: 0x000D719D
		public unsafe float MaxClientSmoothingDeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_MaxClientSmoothingDeltaTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_MaxClientSmoothingDeltaTime) = value;
			}
		}

		// Token: 0x17002483 RID: 9347
		// (get) Token: 0x06009866 RID: 39014 RVA: 0x000D8FAE File Offset: 0x000D71AE
		// (set) Token: 0x06009867 RID: 39015 RVA: 0x000D8FBE File Offset: 0x000D71BE
		public unsafe float ClientNetSendMoveDeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_ClientNetSendMoveDeltaTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_ClientNetSendMoveDeltaTime) = value;
			}
		}

		// Token: 0x17002484 RID: 9348
		// (get) Token: 0x06009868 RID: 39016 RVA: 0x000D8FCF File Offset: 0x000D71CF
		// (set) Token: 0x06009869 RID: 39017 RVA: 0x000D8FDF File Offset: 0x000D71DF
		public unsafe float ClientNetSendMoveDeltaTimeThrottled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_ClientNetSendMoveDeltaTimeThrottled);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_ClientNetSendMoveDeltaTimeThrottled) = value;
			}
		}

		// Token: 0x17002485 RID: 9349
		// (get) Token: 0x0600986A RID: 39018 RVA: 0x000D8FF0 File Offset: 0x000D71F0
		// (set) Token: 0x0600986B RID: 39019 RVA: 0x000D9000 File Offset: 0x000D7200
		public unsafe float ClientNetSendMoveDeltaTimeStationary
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_ClientNetSendMoveDeltaTimeStationary);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_ClientNetSendMoveDeltaTimeStationary) = value;
			}
		}

		// Token: 0x17002486 RID: 9350
		// (get) Token: 0x0600986C RID: 39020 RVA: 0x000D9011 File Offset: 0x000D7211
		// (set) Token: 0x0600986D RID: 39021 RVA: 0x000D9021 File Offset: 0x000D7221
		public unsafe int ClientNetSendMoveThrottleAtNetSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_ClientNetSendMoveThrottleAtNetSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_ClientNetSendMoveThrottleAtNetSpeed) = value;
			}
		}

		// Token: 0x17002487 RID: 9351
		// (get) Token: 0x0600986E RID: 39022 RVA: 0x000D9032 File Offset: 0x000D7232
		// (set) Token: 0x0600986F RID: 39023 RVA: 0x000D9042 File Offset: 0x000D7242
		public unsafe int ClientNetSendMoveThrottleOverPlayerCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_ClientNetSendMoveThrottleOverPlayerCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_ClientNetSendMoveThrottleOverPlayerCount) = value;
			}
		}

		// Token: 0x17002488 RID: 9352
		// (get) Token: 0x06009870 RID: 39024 RVA: 0x000D9053 File Offset: 0x000D7253
		// (set) Token: 0x06009871 RID: 39025 RVA: 0x000D9063 File Offset: 0x000D7263
		public unsafe bool ClientAuthorativePosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_ClientAuthorativePosition) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_ClientAuthorativePosition) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002489 RID: 9353
		// (get) Token: 0x06009872 RID: 39026 RVA: 0x000D9074 File Offset: 0x000D7274
		// (set) Token: 0x06009873 RID: 39027 RVA: 0x000D9084 File Offset: 0x000D7284
		public unsafe float ClientErrorUpdateRateLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_ClientErrorUpdateRateLimit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_ClientErrorUpdateRateLimit) = value;
			}
		}

		// Token: 0x1700248A RID: 9354
		// (get) Token: 0x06009874 RID: 39028 RVA: 0x000D9095 File Offset: 0x000D7295
		// (set) Token: 0x06009875 RID: 39029 RVA: 0x000D90A5 File Offset: 0x000D72A5
		public unsafe float ClientNetCamUpdateDeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_ClientNetCamUpdateDeltaTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_ClientNetCamUpdateDeltaTime) = value;
			}
		}

		// Token: 0x1700248B RID: 9355
		// (get) Token: 0x06009876 RID: 39030 RVA: 0x000D90B6 File Offset: 0x000D72B6
		// (set) Token: 0x06009877 RID: 39031 RVA: 0x000D90C6 File Offset: 0x000D72C6
		public unsafe float ClientNetCamUpdatePositionLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_ClientNetCamUpdatePositionLimit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_ClientNetCamUpdatePositionLimit) = value;
			}
		}

		// Token: 0x1700248C RID: 9356
		// (get) Token: 0x06009878 RID: 39032 RVA: 0x000D90D7 File Offset: 0x000D72D7
		// (set) Token: 0x06009879 RID: 39033 RVA: 0x000D90E7 File Offset: 0x000D72E7
		public unsafe bool bMovementTimeDiscrepancyDetection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_bMovementTimeDiscrepancyDetection) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_bMovementTimeDiscrepancyDetection) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700248D RID: 9357
		// (get) Token: 0x0600987A RID: 39034 RVA: 0x000D90F8 File Offset: 0x000D72F8
		// (set) Token: 0x0600987B RID: 39035 RVA: 0x000D9108 File Offset: 0x000D7308
		public unsafe bool bMovementTimeDiscrepancyResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_bMovementTimeDiscrepancyResolution) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_bMovementTimeDiscrepancyResolution) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700248E RID: 9358
		// (get) Token: 0x0600987C RID: 39036 RVA: 0x000D9119 File Offset: 0x000D7319
		// (set) Token: 0x0600987D RID: 39037 RVA: 0x000D9129 File Offset: 0x000D7329
		public unsafe float MovementTimeDiscrepancyMaxTimeMargin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_MovementTimeDiscrepancyMaxTimeMargin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_MovementTimeDiscrepancyMaxTimeMargin) = value;
			}
		}

		// Token: 0x1700248F RID: 9359
		// (get) Token: 0x0600987E RID: 39038 RVA: 0x000D913A File Offset: 0x000D733A
		// (set) Token: 0x0600987F RID: 39039 RVA: 0x000D914A File Offset: 0x000D734A
		public unsafe float MovementTimeDiscrepancyMinTimeMargin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_MovementTimeDiscrepancyMinTimeMargin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_MovementTimeDiscrepancyMinTimeMargin) = value;
			}
		}

		// Token: 0x17002490 RID: 9360
		// (get) Token: 0x06009880 RID: 39040 RVA: 0x000D915B File Offset: 0x000D735B
		// (set) Token: 0x06009881 RID: 39041 RVA: 0x000D916B File Offset: 0x000D736B
		public unsafe float MovementTimeDiscrepancyResolutionRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_MovementTimeDiscrepancyResolutionRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_MovementTimeDiscrepancyResolutionRate) = value;
			}
		}

		// Token: 0x17002491 RID: 9361
		// (get) Token: 0x06009882 RID: 39042 RVA: 0x000D917C File Offset: 0x000D737C
		// (set) Token: 0x06009883 RID: 39043 RVA: 0x000D918C File Offset: 0x000D738C
		public unsafe float MovementTimeDiscrepancyDriftAllowance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_MovementTimeDiscrepancyDriftAllowance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_MovementTimeDiscrepancyDriftAllowance) = value;
			}
		}

		// Token: 0x17002492 RID: 9362
		// (get) Token: 0x06009884 RID: 39044 RVA: 0x000D919D File Offset: 0x000D739D
		// (set) Token: 0x06009885 RID: 39045 RVA: 0x000D91AD File Offset: 0x000D73AD
		public unsafe bool bMovementTimeDiscrepancyForceCorrectionsDuringResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_bMovementTimeDiscrepancyForceCorrectionsDuringResolution) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_bMovementTimeDiscrepancyForceCorrectionsDuringResolution) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002493 RID: 9363
		// (get) Token: 0x06009886 RID: 39046 RVA: 0x000D91BE File Offset: 0x000D73BE
		// (set) Token: 0x06009887 RID: 39047 RVA: 0x000D91CE File Offset: 0x000D73CE
		public unsafe bool bUseDistanceBasedRelevancy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_bUseDistanceBasedRelevancy) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameNetworkManager.__PropertyOffset_bUseDistanceBasedRelevancy) = (value ? 1 : 0);
			}
		}

		// Token: 0x06009888 RID: 39048 RVA: 0x000D91DF File Offset: 0x000D73DF
		static AGameNetworkManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.GameNetworkManager");
		}

		// Token: 0x06009889 RID: 39049 RVA: 0x000D91ED File Offset: 0x000D73ED
		protected AGameNetworkManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005504 RID: 21764
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.GameNetworkManager";

		// Token: 0x04005505 RID: 21765
		private static IntPtr _ClassPtr;

		// Token: 0x04005506 RID: 21766
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005507 RID: 21767
		internal static int __PropertyOffset_BadPacketLossThreshold;

		// Token: 0x04005508 RID: 21768
		internal static int __PropertyOffset_SeverePacketLossThreshold;

		// Token: 0x04005509 RID: 21769
		internal static int __PropertyOffset_BadPingThreshold;

		// Token: 0x0400550A RID: 21770
		internal static int __PropertyOffset_SeverePingThreshold;

		// Token: 0x0400550B RID: 21771
		internal static int __PropertyOffset_AdjustedNetSpeed;

		// Token: 0x0400550C RID: 21772
		internal static int __PropertyOffset_LastNetSpeedUpdateTime;

		// Token: 0x0400550D RID: 21773
		internal static int __PropertyOffset_TotalNetBandwidth;

		// Token: 0x0400550E RID: 21774
		internal static int __PropertyOffset_MinDynamicBandwidth;

		// Token: 0x0400550F RID: 21775
		internal static int __PropertyOffset_MaxDynamicBandwidth;

		// Token: 0x04005510 RID: 21776
		internal static int __PropertyOffset_bIsStandbyCheckingEnabled;

		// Token: 0x04005511 RID: 21777
		internal static byte __PropertyMask_bIsStandbyCheckingEnabled;

		// Token: 0x04005512 RID: 21778
		internal static int __PropertyOffset_bHasStandbyCheatTriggered;

		// Token: 0x04005513 RID: 21779
		internal static byte __PropertyMask_bHasStandbyCheatTriggered;

		// Token: 0x04005514 RID: 21780
		internal static int __PropertyOffset_StandbyRxCheatTime;

		// Token: 0x04005515 RID: 21781
		internal static int __PropertyOffset_StandbyTxCheatTime;

		// Token: 0x04005516 RID: 21782
		internal static int __PropertyOffset_PercentMissingForRxStandby;

		// Token: 0x04005517 RID: 21783
		internal static int __PropertyOffset_PercentMissingForTxStandby;

		// Token: 0x04005518 RID: 21784
		internal static int __PropertyOffset_PercentForBadPing;

		// Token: 0x04005519 RID: 21785
		internal static int __PropertyOffset_JoinInProgressStandbyWaitTime;

		// Token: 0x0400551A RID: 21786
		internal static int __PropertyOffset_MoveRepSize;

		// Token: 0x0400551B RID: 21787
		internal static int __PropertyOffset_MAXPOSITIONERRORSQUARED;

		// Token: 0x0400551C RID: 21788
		internal static int __PropertyOffset_MAXNEARZEROVELOCITYSQUARED;

		// Token: 0x0400551D RID: 21789
		internal static int __PropertyOffset_CLIENTADJUSTUPDATECOST;

		// Token: 0x0400551E RID: 21790
		internal static int __PropertyOffset_MAXCLIENTUPDATEINTERVAL;

		// Token: 0x0400551F RID: 21791
		internal static int __PropertyOffset_MaxClientForcedUpdateDuration;

		// Token: 0x04005520 RID: 21792
		internal static int __PropertyOffset_ServerForcedUpdateHitchThreshold;

		// Token: 0x04005521 RID: 21793
		internal static int __PropertyOffset_ServerForcedUpdateHitchCooldown;

		// Token: 0x04005522 RID: 21794
		internal static int __PropertyOffset_MaxMoveDeltaTime;

		// Token: 0x04005523 RID: 21795
		internal static int __PropertyOffset_MaxClientSmoothingDeltaTime;

		// Token: 0x04005524 RID: 21796
		internal static int __PropertyOffset_ClientNetSendMoveDeltaTime;

		// Token: 0x04005525 RID: 21797
		internal static int __PropertyOffset_ClientNetSendMoveDeltaTimeThrottled;

		// Token: 0x04005526 RID: 21798
		internal static int __PropertyOffset_ClientNetSendMoveDeltaTimeStationary;

		// Token: 0x04005527 RID: 21799
		internal static int __PropertyOffset_ClientNetSendMoveThrottleAtNetSpeed;

		// Token: 0x04005528 RID: 21800
		internal static int __PropertyOffset_ClientNetSendMoveThrottleOverPlayerCount;

		// Token: 0x04005529 RID: 21801
		internal static int __PropertyOffset_ClientAuthorativePosition;

		// Token: 0x0400552A RID: 21802
		internal static int __PropertyOffset_ClientErrorUpdateRateLimit;

		// Token: 0x0400552B RID: 21803
		internal static int __PropertyOffset_ClientNetCamUpdateDeltaTime;

		// Token: 0x0400552C RID: 21804
		internal static int __PropertyOffset_ClientNetCamUpdatePositionLimit;

		// Token: 0x0400552D RID: 21805
		internal static int __PropertyOffset_bMovementTimeDiscrepancyDetection;

		// Token: 0x0400552E RID: 21806
		internal static int __PropertyOffset_bMovementTimeDiscrepancyResolution;

		// Token: 0x0400552F RID: 21807
		internal static int __PropertyOffset_MovementTimeDiscrepancyMaxTimeMargin;

		// Token: 0x04005530 RID: 21808
		internal static int __PropertyOffset_MovementTimeDiscrepancyMinTimeMargin;

		// Token: 0x04005531 RID: 21809
		internal static int __PropertyOffset_MovementTimeDiscrepancyResolutionRate;

		// Token: 0x04005532 RID: 21810
		internal static int __PropertyOffset_MovementTimeDiscrepancyDriftAllowance;

		// Token: 0x04005533 RID: 21811
		internal static int __PropertyOffset_bMovementTimeDiscrepancyForceCorrectionsDuringResolution;

		// Token: 0x04005534 RID: 21812
		internal static int __PropertyOffset_bUseDistanceBasedRelevancy;
	}
}
