using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000160 RID: 352
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.Actor")]
	[UnrealStructLayout(1040, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1040)]
	public class AActor : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060013A0 RID: 5024 RVA: 0x0001EE7E File Offset: 0x0001D07E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AActor._ClassPtr;
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x0001EE8C File Offset: 0x0001D08C
		public AActor() : this(BuiltinUtils.AllocNativeUObject(AActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x0001EEB4 File Offset: 0x0001D0B4
		[NullableContext(1)]
		public AActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060013A3 RID: 5027 RVA: 0x0001EEE8 File Offset: 0x0001D0E8
		// (set) Token: 0x060013A4 RID: 5028 RVA: 0x0001EF21 File Offset: 0x0001D121
		[Nullable(1)]
		public FActorTickFunction PrimaryActorTick
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FActorTickFunction result;
				if ((result = this._PrimaryActorTick) == null)
				{
					result = (this._PrimaryActorTick = new FActorTickFunction(base.NativePtr + (IntPtr)AActor.__PropertyOffset_PrimaryActorTick, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FActorTickFunction.StaticStruct(), base.NativePtr + (IntPtr)AActor.__PropertyOffset_PrimaryActorTick, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060013A5 RID: 5029 RVA: 0x0001EF42 File Offset: 0x0001D142
		// (set) Token: 0x060013A6 RID: 5030 RVA: 0x0001EF5B File Offset: 0x0001D15B
		public unsafe bool bNetTemporary
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bNetTemporary) & AActor.__PropertyMask_bNetTemporary) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AActor.__PropertyOffset_bNetTemporary) = ((*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bNetTemporary) & ~AActor.__PropertyMask_bNetTemporary) | (value ? AActor.__PropertyMask_bNetTemporary : 0));
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060013A7 RID: 5031 RVA: 0x0001EF8B File Offset: 0x0001D18B
		// (set) Token: 0x060013A8 RID: 5032 RVA: 0x0001EFA4 File Offset: 0x0001D1A4
		public unsafe bool bNetStartup
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bNetStartup) & AActor.__PropertyMask_bNetStartup) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AActor.__PropertyOffset_bNetStartup) = ((*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bNetStartup) & ~AActor.__PropertyMask_bNetStartup) | (value ? AActor.__PropertyMask_bNetStartup : 0));
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060013A9 RID: 5033 RVA: 0x0001EFD4 File Offset: 0x0001D1D4
		// (set) Token: 0x060013AA RID: 5034 RVA: 0x0001EFED File Offset: 0x0001D1ED
		public unsafe bool bOnlyRelevantToOwner
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bOnlyRelevantToOwner) & AActor.__PropertyMask_bOnlyRelevantToOwner) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AActor.__PropertyOffset_bOnlyRelevantToOwner) = ((*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bOnlyRelevantToOwner) & ~AActor.__PropertyMask_bOnlyRelevantToOwner) | (value ? AActor.__PropertyMask_bOnlyRelevantToOwner : 0));
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060013AB RID: 5035 RVA: 0x0001F01D File Offset: 0x0001D21D
		// (set) Token: 0x060013AC RID: 5036 RVA: 0x0001F036 File Offset: 0x0001D236
		public unsafe bool bAlwaysRelevant
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bAlwaysRelevant) & AActor.__PropertyMask_bAlwaysRelevant) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AActor.__PropertyOffset_bAlwaysRelevant) = ((*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bAlwaysRelevant) & ~AActor.__PropertyMask_bAlwaysRelevant) | (value ? AActor.__PropertyMask_bAlwaysRelevant : 0));
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060013AD RID: 5037 RVA: 0x0001F066 File Offset: 0x0001D266
		// (set) Token: 0x060013AE RID: 5038 RVA: 0x0001F07F File Offset: 0x0001D27F
		public unsafe bool bReplicateMovement
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bReplicateMovement) & AActor.__PropertyMask_bReplicateMovement) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AActor.__PropertyOffset_bReplicateMovement) = ((*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bReplicateMovement) & ~AActor.__PropertyMask_bReplicateMovement) | (value ? AActor.__PropertyMask_bReplicateMovement : 0));
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060013AF RID: 5039 RVA: 0x0001F0AF File Offset: 0x0001D2AF
		// (set) Token: 0x060013B0 RID: 5040 RVA: 0x0001F0C8 File Offset: 0x0001D2C8
		public unsafe bool bHidden
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bHidden) & AActor.__PropertyMask_bHidden) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AActor.__PropertyOffset_bHidden) = ((*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bHidden) & ~AActor.__PropertyMask_bHidden) | (value ? AActor.__PropertyMask_bHidden : 0));
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060013B1 RID: 5041 RVA: 0x0001F0F8 File Offset: 0x0001D2F8
		// (set) Token: 0x060013B2 RID: 5042 RVA: 0x0001F111 File Offset: 0x0001D311
		public unsafe bool bViewableInRender
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bViewableInRender) & AActor.__PropertyMask_bViewableInRender) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AActor.__PropertyOffset_bViewableInRender) = ((*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bViewableInRender) & ~AActor.__PropertyMask_bViewableInRender) | (value ? AActor.__PropertyMask_bViewableInRender : 0));
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060013B3 RID: 5043 RVA: 0x0001F141 File Offset: 0x0001D341
		// (set) Token: 0x060013B4 RID: 5044 RVA: 0x0001F15A File Offset: 0x0001D35A
		public unsafe bool bTearOff
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bTearOff) & AActor.__PropertyMask_bTearOff) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AActor.__PropertyOffset_bTearOff) = ((*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bTearOff) & ~AActor.__PropertyMask_bTearOff) | (value ? AActor.__PropertyMask_bTearOff : 0));
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060013B5 RID: 5045 RVA: 0x0001F18A File Offset: 0x0001D38A
		// (set) Token: 0x060013B6 RID: 5046 RVA: 0x0001F1A3 File Offset: 0x0001D3A3
		public unsafe bool bForceHidden
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bForceHidden) & AActor.__PropertyMask_bForceHidden) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AActor.__PropertyOffset_bForceHidden) = ((*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bForceHidden) & ~AActor.__PropertyMask_bForceHidden) | (value ? AActor.__PropertyMask_bForceHidden : 0));
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x060013B7 RID: 5047 RVA: 0x0001F1D3 File Offset: 0x0001D3D3
		// (set) Token: 0x060013B8 RID: 5048 RVA: 0x0001F1E3 File Offset: 0x0001D3E3
		public unsafe bool bIsAliveSpawnableAfterSequenceClean
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bIsAliveSpawnableAfterSequenceClean) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bIsAliveSpawnableAfterSequenceClean) = (value ? 1 : 0);
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060013B9 RID: 5049 RVA: 0x0001F1F4 File Offset: 0x0001D3F4
		// (set) Token: 0x060013BA RID: 5050 RVA: 0x0001F20D File Offset: 0x0001D40D
		public unsafe bool bExchangedRoles
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bExchangedRoles) & AActor.__PropertyMask_bExchangedRoles) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AActor.__PropertyOffset_bExchangedRoles) = ((*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bExchangedRoles) & ~AActor.__PropertyMask_bExchangedRoles) | (value ? AActor.__PropertyMask_bExchangedRoles : 0));
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060013BB RID: 5051 RVA: 0x0001F23D File Offset: 0x0001D43D
		// (set) Token: 0x060013BC RID: 5052 RVA: 0x0001F256 File Offset: 0x0001D456
		public unsafe bool bNetLoadOnClient
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bNetLoadOnClient) & AActor.__PropertyMask_bNetLoadOnClient) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AActor.__PropertyOffset_bNetLoadOnClient) = ((*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bNetLoadOnClient) & ~AActor.__PropertyMask_bNetLoadOnClient) | (value ? AActor.__PropertyMask_bNetLoadOnClient : 0));
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060013BD RID: 5053 RVA: 0x0001F286 File Offset: 0x0001D486
		// (set) Token: 0x060013BE RID: 5054 RVA: 0x0001F29F File Offset: 0x0001D49F
		public unsafe bool bNetUseOwnerRelevancy
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bNetUseOwnerRelevancy) & AActor.__PropertyMask_bNetUseOwnerRelevancy) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AActor.__PropertyOffset_bNetUseOwnerRelevancy) = ((*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bNetUseOwnerRelevancy) & ~AActor.__PropertyMask_bNetUseOwnerRelevancy) | (value ? AActor.__PropertyMask_bNetUseOwnerRelevancy : 0));
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060013BF RID: 5055 RVA: 0x0001F2CF File Offset: 0x0001D4CF
		// (set) Token: 0x060013C0 RID: 5056 RVA: 0x0001F2E8 File Offset: 0x0001D4E8
		public unsafe bool bRelevantForNetworkReplays
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bRelevantForNetworkReplays) & AActor.__PropertyMask_bRelevantForNetworkReplays) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AActor.__PropertyOffset_bRelevantForNetworkReplays) = ((*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bRelevantForNetworkReplays) & ~AActor.__PropertyMask_bRelevantForNetworkReplays) | (value ? AActor.__PropertyMask_bRelevantForNetworkReplays : 0));
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060013C1 RID: 5057 RVA: 0x0001F318 File Offset: 0x0001D518
		// (set) Token: 0x060013C2 RID: 5058 RVA: 0x0001F331 File Offset: 0x0001D531
		public unsafe bool bRelevantForLevelBounds
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bRelevantForLevelBounds) & AActor.__PropertyMask_bRelevantForLevelBounds) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AActor.__PropertyOffset_bRelevantForLevelBounds) = ((*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bRelevantForLevelBounds) & ~AActor.__PropertyMask_bRelevantForLevelBounds) | (value ? AActor.__PropertyMask_bRelevantForLevelBounds : 0));
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060013C3 RID: 5059 RVA: 0x0001F361 File Offset: 0x0001D561
		// (set) Token: 0x060013C4 RID: 5060 RVA: 0x0001F37A File Offset: 0x0001D57A
		public unsafe bool bReplayRewindable
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bReplayRewindable) & AActor.__PropertyMask_bReplayRewindable) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AActor.__PropertyOffset_bReplayRewindable) = ((*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bReplayRewindable) & ~AActor.__PropertyMask_bReplayRewindable) | (value ? AActor.__PropertyMask_bReplayRewindable : 0));
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060013C5 RID: 5061 RVA: 0x0001F3AA File Offset: 0x0001D5AA
		// (set) Token: 0x060013C6 RID: 5062 RVA: 0x0001F3C3 File Offset: 0x0001D5C3
		public unsafe bool bAllowTickBeforeBeginPlay
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bAllowTickBeforeBeginPlay) & AActor.__PropertyMask_bAllowTickBeforeBeginPlay) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AActor.__PropertyOffset_bAllowTickBeforeBeginPlay) = ((*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bAllowTickBeforeBeginPlay) & ~AActor.__PropertyMask_bAllowTickBeforeBeginPlay) | (value ? AActor.__PropertyMask_bAllowTickBeforeBeginPlay : 0));
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060013C7 RID: 5063 RVA: 0x0001F3F3 File Offset: 0x0001D5F3
		// (set) Token: 0x060013C8 RID: 5064 RVA: 0x0001F40C File Offset: 0x0001D60C
		public unsafe bool bAutoDestroyWhenFinished
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bAutoDestroyWhenFinished) & AActor.__PropertyMask_bAutoDestroyWhenFinished) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AActor.__PropertyOffset_bAutoDestroyWhenFinished) = ((*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bAutoDestroyWhenFinished) & ~AActor.__PropertyMask_bAutoDestroyWhenFinished) | (value ? AActor.__PropertyMask_bAutoDestroyWhenFinished : 0));
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060013C9 RID: 5065 RVA: 0x0001F43C File Offset: 0x0001D63C
		// (set) Token: 0x060013CA RID: 5066 RVA: 0x0001F455 File Offset: 0x0001D655
		public unsafe bool bCanBeDamaged
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bCanBeDamaged) & AActor.__PropertyMask_bCanBeDamaged) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AActor.__PropertyOffset_bCanBeDamaged) = ((*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bCanBeDamaged) & ~AActor.__PropertyMask_bCanBeDamaged) | (value ? AActor.__PropertyMask_bCanBeDamaged : 0));
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060013CB RID: 5067 RVA: 0x0001F485 File Offset: 0x0001D685
		// (set) Token: 0x060013CC RID: 5068 RVA: 0x0001F49E File Offset: 0x0001D69E
		public unsafe bool bBlockInput
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bBlockInput) & AActor.__PropertyMask_bBlockInput) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AActor.__PropertyOffset_bBlockInput) = ((*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bBlockInput) & ~AActor.__PropertyMask_bBlockInput) | (value ? AActor.__PropertyMask_bBlockInput : 0));
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060013CD RID: 5069 RVA: 0x0001F4CE File Offset: 0x0001D6CE
		// (set) Token: 0x060013CE RID: 5070 RVA: 0x0001F4E7 File Offset: 0x0001D6E7
		public unsafe bool bCollideWhenPlacing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bCollideWhenPlacing) & AActor.__PropertyMask_bCollideWhenPlacing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AActor.__PropertyOffset_bCollideWhenPlacing) = ((*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bCollideWhenPlacing) & ~AActor.__PropertyMask_bCollideWhenPlacing) | (value ? AActor.__PropertyMask_bCollideWhenPlacing : 0));
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060013CF RID: 5071 RVA: 0x0001F517 File Offset: 0x0001D717
		// (set) Token: 0x060013D0 RID: 5072 RVA: 0x0001F530 File Offset: 0x0001D730
		public unsafe bool bFindCameraComponentWhenViewTarget
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bFindCameraComponentWhenViewTarget) & AActor.__PropertyMask_bFindCameraComponentWhenViewTarget) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AActor.__PropertyOffset_bFindCameraComponentWhenViewTarget) = ((*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bFindCameraComponentWhenViewTarget) & ~AActor.__PropertyMask_bFindCameraComponentWhenViewTarget) | (value ? AActor.__PropertyMask_bFindCameraComponentWhenViewTarget : 0));
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060013D1 RID: 5073 RVA: 0x0001F560 File Offset: 0x0001D760
		// (set) Token: 0x060013D2 RID: 5074 RVA: 0x0001F579 File Offset: 0x0001D779
		public unsafe bool bGenerateOverlapEventsDuringLevelStreaming
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bGenerateOverlapEventsDuringLevelStreaming) & AActor.__PropertyMask_bGenerateOverlapEventsDuringLevelStreaming) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AActor.__PropertyOffset_bGenerateOverlapEventsDuringLevelStreaming) = ((*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bGenerateOverlapEventsDuringLevelStreaming) & ~AActor.__PropertyMask_bGenerateOverlapEventsDuringLevelStreaming) | (value ? AActor.__PropertyMask_bGenerateOverlapEventsDuringLevelStreaming : 0));
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060013D3 RID: 5075 RVA: 0x0001F5A9 File Offset: 0x0001D7A9
		// (set) Token: 0x060013D4 RID: 5076 RVA: 0x0001F5C2 File Offset: 0x0001D7C2
		public unsafe bool bIgnoresOriginShifting
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bIgnoresOriginShifting) & AActor.__PropertyMask_bIgnoresOriginShifting) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AActor.__PropertyOffset_bIgnoresOriginShifting) = ((*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bIgnoresOriginShifting) & ~AActor.__PropertyMask_bIgnoresOriginShifting) | (value ? AActor.__PropertyMask_bIgnoresOriginShifting : 0));
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060013D5 RID: 5077 RVA: 0x0001F5F2 File Offset: 0x0001D7F2
		// (set) Token: 0x060013D6 RID: 5078 RVA: 0x0001F60B File Offset: 0x0001D80B
		public unsafe bool bEnableAutoLODGeneration
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bEnableAutoLODGeneration) & AActor.__PropertyMask_bEnableAutoLODGeneration) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AActor.__PropertyOffset_bEnableAutoLODGeneration) = ((*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bEnableAutoLODGeneration) & ~AActor.__PropertyMask_bEnableAutoLODGeneration) | (value ? AActor.__PropertyMask_bEnableAutoLODGeneration : 0));
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060013D7 RID: 5079 RVA: 0x0001F63B File Offset: 0x0001D83B
		// (set) Token: 0x060013D8 RID: 5080 RVA: 0x0001F654 File Offset: 0x0001D854
		public unsafe bool bIsEditorOnlyActor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bIsEditorOnlyActor) & AActor.__PropertyMask_bIsEditorOnlyActor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AActor.__PropertyOffset_bIsEditorOnlyActor) = ((*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bIsEditorOnlyActor) & ~AActor.__PropertyMask_bIsEditorOnlyActor) | (value ? AActor.__PropertyMask_bIsEditorOnlyActor : 0));
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060013D9 RID: 5081 RVA: 0x0001F684 File Offset: 0x0001D884
		// (set) Token: 0x060013DA RID: 5082 RVA: 0x0001F69D File Offset: 0x0001D89D
		public unsafe bool bPlatformMobile
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bPlatformMobile) & AActor.__PropertyMask_bPlatformMobile) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AActor.__PropertyOffset_bPlatformMobile) = ((*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bPlatformMobile) & ~AActor.__PropertyMask_bPlatformMobile) | (value ? AActor.__PropertyMask_bPlatformMobile : 0));
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060013DB RID: 5083 RVA: 0x0001F6CD File Offset: 0x0001D8CD
		// (set) Token: 0x060013DC RID: 5084 RVA: 0x0001F6E6 File Offset: 0x0001D8E6
		public unsafe bool bPlatformDeskTop
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bPlatformDeskTop) & AActor.__PropertyMask_bPlatformDeskTop) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AActor.__PropertyOffset_bPlatformDeskTop) = ((*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bPlatformDeskTop) & ~AActor.__PropertyMask_bPlatformDeskTop) | (value ? AActor.__PropertyMask_bPlatformDeskTop : 0));
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060013DD RID: 5085 RVA: 0x0001F716 File Offset: 0x0001D916
		// (set) Token: 0x060013DE RID: 5086 RVA: 0x0001F72F File Offset: 0x0001D92F
		public unsafe bool bPlatformMac
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bPlatformMac) & AActor.__PropertyMask_bPlatformMac) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AActor.__PropertyOffset_bPlatformMac) = ((*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bPlatformMac) & ~AActor.__PropertyMask_bPlatformMac) | (value ? AActor.__PropertyMask_bPlatformMac : 0));
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x060013DF RID: 5087 RVA: 0x0001F75F File Offset: 0x0001D95F
		// (set) Token: 0x060013E0 RID: 5088 RVA: 0x0001F778 File Offset: 0x0001D978
		public unsafe bool bInvolveCook
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bInvolveCook) & AActor.__PropertyMask_bInvolveCook) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AActor.__PropertyOffset_bInvolveCook) = ((*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bInvolveCook) & ~AActor.__PropertyMask_bInvolveCook) | (value ? AActor.__PropertyMask_bInvolveCook : 0));
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060013E1 RID: 5089 RVA: 0x0001F7A8 File Offset: 0x0001D9A8
		// (set) Token: 0x060013E2 RID: 5090 RVA: 0x0001F7C1 File Offset: 0x0001D9C1
		public unsafe bool bActorSeamlessTraveled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bActorSeamlessTraveled) & AActor.__PropertyMask_bActorSeamlessTraveled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AActor.__PropertyOffset_bActorSeamlessTraveled) = ((*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bActorSeamlessTraveled) & ~AActor.__PropertyMask_bActorSeamlessTraveled) | (value ? AActor.__PropertyMask_bActorSeamlessTraveled : 0));
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x060013E3 RID: 5091 RVA: 0x0001F7F1 File Offset: 0x0001D9F1
		// (set) Token: 0x060013E4 RID: 5092 RVA: 0x0001F80A File Offset: 0x0001DA0A
		public unsafe bool bIsPermanentActor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bIsPermanentActor) & AActor.__PropertyMask_bIsPermanentActor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AActor.__PropertyOffset_bIsPermanentActor) = ((*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bIsPermanentActor) & ~AActor.__PropertyMask_bIsPermanentActor) | (value ? AActor.__PropertyMask_bIsPermanentActor : 0));
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060013E5 RID: 5093 RVA: 0x0001F83A File Offset: 0x0001DA3A
		// (set) Token: 0x060013E6 RID: 5094 RVA: 0x0001F853 File Offset: 0x0001DA53
		public unsafe bool bEnableBeginAndEndPlayDebugLog
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bEnableBeginAndEndPlayDebugLog) & AActor.__PropertyMask_bEnableBeginAndEndPlayDebugLog) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AActor.__PropertyOffset_bEnableBeginAndEndPlayDebugLog) = ((*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bEnableBeginAndEndPlayDebugLog) & ~AActor.__PropertyMask_bEnableBeginAndEndPlayDebugLog) | (value ? AActor.__PropertyMask_bEnableBeginAndEndPlayDebugLog : 0));
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060013E7 RID: 5095 RVA: 0x0001F883 File Offset: 0x0001DA83
		// (set) Token: 0x060013E8 RID: 5096 RVA: 0x0001F89C File Offset: 0x0001DA9C
		public unsafe bool bKuroHiddenDebugLog
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bKuroHiddenDebugLog) & AActor.__PropertyMask_bKuroHiddenDebugLog) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AActor.__PropertyOffset_bKuroHiddenDebugLog) = ((*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bKuroHiddenDebugLog) & ~AActor.__PropertyMask_bKuroHiddenDebugLog) | (value ? AActor.__PropertyMask_bKuroHiddenDebugLog : 0));
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060013E9 RID: 5097 RVA: 0x0001F8CC File Offset: 0x0001DACC
		// (set) Token: 0x060013EA RID: 5098 RVA: 0x0001F8E5 File Offset: 0x0001DAE5
		public unsafe bool bSpawnInUIScene
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bSpawnInUIScene) & AActor.__PropertyMask_bSpawnInUIScene) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AActor.__PropertyOffset_bSpawnInUIScene) = ((*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bSpawnInUIScene) & ~AActor.__PropertyMask_bSpawnInUIScene) | (value ? AActor.__PropertyMask_bSpawnInUIScene : 0));
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060013EB RID: 5099 RVA: 0x0001F915 File Offset: 0x0001DB15
		// (set) Token: 0x060013EC RID: 5100 RVA: 0x0001F92E File Offset: 0x0001DB2E
		public unsafe bool bReplicates
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bReplicates) & AActor.__PropertyMask_bReplicates) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AActor.__PropertyOffset_bReplicates) = ((*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bReplicates) & ~AActor.__PropertyMask_bReplicates) | (value ? AActor.__PropertyMask_bReplicates : 0));
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x060013ED RID: 5101 RVA: 0x0001F95E File Offset: 0x0001DB5E
		// (set) Token: 0x060013EE RID: 5102 RVA: 0x0001F977 File Offset: 0x0001DB77
		public unsafe bool bCanBeInCluster
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bCanBeInCluster) & AActor.__PropertyMask_bCanBeInCluster) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AActor.__PropertyOffset_bCanBeInCluster) = ((*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bCanBeInCluster) & ~AActor.__PropertyMask_bCanBeInCluster) | (value ? AActor.__PropertyMask_bCanBeInCluster : 0));
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060013EF RID: 5103 RVA: 0x0001F9A7 File Offset: 0x0001DBA7
		// (set) Token: 0x060013F0 RID: 5104 RVA: 0x0001F9C0 File Offset: 0x0001DBC0
		public unsafe bool bAllowReceiveTickEventOnDedicatedServer
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bAllowReceiveTickEventOnDedicatedServer) & AActor.__PropertyMask_bAllowReceiveTickEventOnDedicatedServer) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AActor.__PropertyOffset_bAllowReceiveTickEventOnDedicatedServer) = ((*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bAllowReceiveTickEventOnDedicatedServer) & ~AActor.__PropertyMask_bAllowReceiveTickEventOnDedicatedServer) | (value ? AActor.__PropertyMask_bAllowReceiveTickEventOnDedicatedServer : 0));
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060013F1 RID: 5105 RVA: 0x0001F9F0 File Offset: 0x0001DBF0
		// (set) Token: 0x060013F2 RID: 5106 RVA: 0x0001FA09 File Offset: 0x0001DC09
		public unsafe bool bActorEnableCollision
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bActorEnableCollision) & AActor.__PropertyMask_bActorEnableCollision) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AActor.__PropertyOffset_bActorEnableCollision) = ((*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bActorEnableCollision) & ~AActor.__PropertyMask_bActorEnableCollision) | (value ? AActor.__PropertyMask_bActorEnableCollision : 0));
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060013F3 RID: 5107 RVA: 0x0001FA39 File Offset: 0x0001DC39
		// (set) Token: 0x060013F4 RID: 5108 RVA: 0x0001FA52 File Offset: 0x0001DC52
		public unsafe bool bActorIsBeingDestroyed
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bActorIsBeingDestroyed) & AActor.__PropertyMask_bActorIsBeingDestroyed) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AActor.__PropertyOffset_bActorIsBeingDestroyed) = ((*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_bActorIsBeingDestroyed) & ~AActor.__PropertyMask_bActorIsBeingDestroyed) | (value ? AActor.__PropertyMask_bActorIsBeingDestroyed : 0));
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060013F5 RID: 5109 RVA: 0x0001FA82 File Offset: 0x0001DC82
		// (set) Token: 0x060013F6 RID: 5110 RVA: 0x0001FA92 File Offset: 0x0001DC92
		public unsafe float InitialLifeSpan
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AActor.__PropertyOffset_InitialLifeSpan);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_InitialLifeSpan) = value;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060013F7 RID: 5111 RVA: 0x0001FAA3 File Offset: 0x0001DCA3
		// (set) Token: 0x060013F8 RID: 5112 RVA: 0x0001FAB3 File Offset: 0x0001DCB3
		public unsafe float CustomTimeDilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AActor.__PropertyOffset_CustomTimeDilation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_CustomTimeDilation) = value;
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060013F9 RID: 5113 RVA: 0x0001FAC4 File Offset: 0x0001DCC4
		// (set) Token: 0x060013FA RID: 5114 RVA: 0x0001FAD8 File Offset: 0x0001DCD8
		public unsafe AActor Owner
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + AActor.__PropertyOffset_Owner);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AActor.__PropertyOffset_Owner, value);
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060013FB RID: 5115 RVA: 0x0001FAED File Offset: 0x0001DCED
		// (set) Token: 0x060013FC RID: 5116 RVA: 0x0001FB01 File Offset: 0x0001DD01
		public unsafe FName NetDriverName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AActor.__PropertyOffset_NetDriverName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_NetDriverName) = value;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060013FD RID: 5117 RVA: 0x0001FB16 File Offset: 0x0001DD16
		// (set) Token: 0x060013FE RID: 5118 RVA: 0x0001FB2A File Offset: 0x0001DD2A
		public unsafe FName BlueprintTypeName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AActor.__PropertyOffset_BlueprintTypeName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_BlueprintTypeName) = value;
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060013FF RID: 5119 RVA: 0x0001FB3F File Offset: 0x0001DD3F
		// (set) Token: 0x06001400 RID: 5120 RVA: 0x0001FB4F File Offset: 0x0001DD4F
		public unsafe uint KuroEntityType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AActor.__PropertyOffset_KuroEntityType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_KuroEntityType) = (int)value;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06001401 RID: 5121 RVA: 0x0001FB60 File Offset: 0x0001DD60
		// (set) Token: 0x06001402 RID: 5122 RVA: 0x0001FB74 File Offset: 0x0001DD74
		public unsafe FName RuntimeGrid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AActor.__PropertyOffset_RuntimeGrid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_RuntimeGrid) = value;
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06001403 RID: 5123 RVA: 0x0001FB89 File Offset: 0x0001DD89
		// (set) Token: 0x06001404 RID: 5124 RVA: 0x0001FB99 File Offset: 0x0001DD99
		public unsafe ESpawnActorCollisionHandlingMethod SpawnCollisionHandlingMethod
		{
			get
			{
				return (ESpawnActorCollisionHandlingMethod)(*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_SpawnCollisionHandlingMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_SpawnCollisionHandlingMethod) = (byte)value;
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06001405 RID: 5125 RVA: 0x0001FBAA File Offset: 0x0001DDAA
		// (set) Token: 0x06001406 RID: 5126 RVA: 0x0001FBBA File Offset: 0x0001DDBA
		public unsafe int InputPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AActor.__PropertyOffset_InputPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_InputPriority) = value;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06001407 RID: 5127 RVA: 0x0001FBCB File Offset: 0x0001DDCB
		// (set) Token: 0x06001408 RID: 5128 RVA: 0x0001FBDB File Offset: 0x0001DDDB
		public unsafe float NetCullDistanceSquared
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AActor.__PropertyOffset_NetCullDistanceSquared);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_NetCullDistanceSquared) = value;
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06001409 RID: 5129 RVA: 0x0001FBEC File Offset: 0x0001DDEC
		// (set) Token: 0x0600140A RID: 5130 RVA: 0x0001FBFC File Offset: 0x0001DDFC
		public unsafe int NetTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AActor.__PropertyOffset_NetTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_NetTag) = value;
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x0600140B RID: 5131 RVA: 0x0001FC0D File Offset: 0x0001DE0D
		// (set) Token: 0x0600140C RID: 5132 RVA: 0x0001FC1D File Offset: 0x0001DE1D
		public unsafe float NetUpdateFrequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AActor.__PropertyOffset_NetUpdateFrequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_NetUpdateFrequency) = value;
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x0600140D RID: 5133 RVA: 0x0001FC2E File Offset: 0x0001DE2E
		// (set) Token: 0x0600140E RID: 5134 RVA: 0x0001FC3E File Offset: 0x0001DE3E
		public unsafe float MinNetUpdateFrequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AActor.__PropertyOffset_MinNetUpdateFrequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_MinNetUpdateFrequency) = value;
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x0600140F RID: 5135 RVA: 0x0001FC4F File Offset: 0x0001DE4F
		// (set) Token: 0x06001410 RID: 5136 RVA: 0x0001FC5F File Offset: 0x0001DE5F
		public unsafe float NetPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AActor.__PropertyOffset_NetPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_NetPriority) = value;
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06001411 RID: 5137 RVA: 0x0001FC70 File Offset: 0x0001DE70
		// (set) Token: 0x06001412 RID: 5138 RVA: 0x0001FC84 File Offset: 0x0001DE84
		public unsafe APawn Instigator
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<APawn>(base.NativePtr / (IntPtr)sizeof(void*) + AActor.__PropertyOffset_Instigator);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AActor.__PropertyOffset_Instigator, value);
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06001413 RID: 5139 RVA: 0x0001FC9C File Offset: 0x0001DE9C
		// (set) Token: 0x06001414 RID: 5140 RVA: 0x0001FCD5 File Offset: 0x0001DED5
		[Nullable(1)]
		public TArray<AActor> Children
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._Children) == null)
				{
					result = (this._Children = new TArray<AActor>(base.NativePtr + (IntPtr)AActor.__PropertyOffset_Children, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Children.CopyAssign(value);
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06001415 RID: 5141 RVA: 0x0001FCE3 File Offset: 0x0001DEE3
		// (set) Token: 0x06001416 RID: 5142 RVA: 0x0001FCF7 File Offset: 0x0001DEF7
		public unsafe USceneComponent RootComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AActor.__PropertyOffset_RootComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AActor.__PropertyOffset_RootComponent, value);
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06001417 RID: 5143 RVA: 0x0001FD0C File Offset: 0x0001DF0C
		// (set) Token: 0x06001418 RID: 5144 RVA: 0x0001FD45 File Offset: 0x0001DF45
		[Nullable(1)]
		public TArray<FName> Layers
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._Layers) == null)
				{
					result = (this._Layers = new TArray<FName>(base.NativePtr + (IntPtr)AActor.__PropertyOffset_Layers, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Layers.CopyAssign(value);
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06001419 RID: 5145 RVA: 0x0001FD53 File Offset: 0x0001DF53
		// (set) Token: 0x0600141A RID: 5146 RVA: 0x0001FD67 File Offset: 0x0001DF67
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UChildActorComponent> ParentComponent
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)AActor.__PropertyOffset_ParentComponent);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_ParentComponent) = value;
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x0600141B RID: 5147 RVA: 0x0001FD7C File Offset: 0x0001DF7C
		// (set) Token: 0x0600141C RID: 5148 RVA: 0x0001FDB5 File Offset: 0x0001DFB5
		[Nullable(1)]
		public TArray<FName> Tags
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._Tags) == null)
				{
					result = (this._Tags = new TArray<FName>(base.NativePtr + (IntPtr)AActor.__PropertyOffset_Tags, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Tags.CopyAssign(value);
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x0600141D RID: 5149 RVA: 0x0001FDC4 File Offset: 0x0001DFC4
		// (set) Token: 0x0600141E RID: 5150 RVA: 0x0001FDFD File Offset: 0x0001DFFD
		[Nullable(1)]
		public FActorBeginOverlapSignature OnActorBeginOverlap
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FActorBeginOverlapSignature result;
				if ((result = this._OnActorBeginOverlap) == null)
				{
					result = (this._OnActorBeginOverlap = new FActorBeginOverlapSignature(base.NativePtr + (IntPtr)AActor.__PropertyOffset_OnActorBeginOverlap, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AActor.__PropertyOffset_OnActorBeginOverlap, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x0600141F RID: 5151 RVA: 0x0001FE20 File Offset: 0x0001E020
		// (set) Token: 0x06001420 RID: 5152 RVA: 0x0001FE59 File Offset: 0x0001E059
		[Nullable(1)]
		public FActorEndOverlapSignature OnActorEndOverlap
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FActorEndOverlapSignature result;
				if ((result = this._OnActorEndOverlap) == null)
				{
					result = (this._OnActorEndOverlap = new FActorEndOverlapSignature(base.NativePtr + (IntPtr)AActor.__PropertyOffset_OnActorEndOverlap, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AActor.__PropertyOffset_OnActorEndOverlap, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06001421 RID: 5153 RVA: 0x0001FE7C File Offset: 0x0001E07C
		// (set) Token: 0x06001422 RID: 5154 RVA: 0x0001FEB5 File Offset: 0x0001E0B5
		[Nullable(1)]
		public FActorBeginCursorOverSignature OnBeginCursorOver
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FActorBeginCursorOverSignature result;
				if ((result = this._OnBeginCursorOver) == null)
				{
					result = (this._OnBeginCursorOver = new FActorBeginCursorOverSignature(base.NativePtr + (IntPtr)AActor.__PropertyOffset_OnBeginCursorOver, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AActor.__PropertyOffset_OnBeginCursorOver, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06001423 RID: 5155 RVA: 0x0001FED8 File Offset: 0x0001E0D8
		// (set) Token: 0x06001424 RID: 5156 RVA: 0x0001FF11 File Offset: 0x0001E111
		[Nullable(1)]
		public FActorEndCursorOverSignature OnEndCursorOver
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FActorEndCursorOverSignature result;
				if ((result = this._OnEndCursorOver) == null)
				{
					result = (this._OnEndCursorOver = new FActorEndCursorOverSignature(base.NativePtr + (IntPtr)AActor.__PropertyOffset_OnEndCursorOver, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AActor.__PropertyOffset_OnEndCursorOver, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06001425 RID: 5157 RVA: 0x0001FF34 File Offset: 0x0001E134
		// (set) Token: 0x06001426 RID: 5158 RVA: 0x0001FF6D File Offset: 0x0001E16D
		[Nullable(1)]
		public FActorOnClickedSignature OnClicked
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FActorOnClickedSignature result;
				if ((result = this._OnClicked) == null)
				{
					result = (this._OnClicked = new FActorOnClickedSignature(base.NativePtr + (IntPtr)AActor.__PropertyOffset_OnClicked, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AActor.__PropertyOffset_OnClicked, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06001427 RID: 5159 RVA: 0x0001FF90 File Offset: 0x0001E190
		// (set) Token: 0x06001428 RID: 5160 RVA: 0x0001FFC9 File Offset: 0x0001E1C9
		[Nullable(1)]
		public FActorOnReleasedSignature OnReleased
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FActorOnReleasedSignature result;
				if ((result = this._OnReleased) == null)
				{
					result = (this._OnReleased = new FActorOnReleasedSignature(base.NativePtr + (IntPtr)AActor.__PropertyOffset_OnReleased, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AActor.__PropertyOffset_OnReleased, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06001429 RID: 5161 RVA: 0x0001FFEC File Offset: 0x0001E1EC
		// (set) Token: 0x0600142A RID: 5162 RVA: 0x00020025 File Offset: 0x0001E225
		[Nullable(1)]
		public FActorOnInputTouchBeginSignature OnInputTouchBegin
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FActorOnInputTouchBeginSignature result;
				if ((result = this._OnInputTouchBegin) == null)
				{
					result = (this._OnInputTouchBegin = new FActorOnInputTouchBeginSignature(base.NativePtr + (IntPtr)AActor.__PropertyOffset_OnInputTouchBegin, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AActor.__PropertyOffset_OnInputTouchBegin, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x0600142B RID: 5163 RVA: 0x00020048 File Offset: 0x0001E248
		// (set) Token: 0x0600142C RID: 5164 RVA: 0x00020081 File Offset: 0x0001E281
		[Nullable(1)]
		public FActorOnInputTouchEndSignature OnInputTouchEnd
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FActorOnInputTouchEndSignature result;
				if ((result = this._OnInputTouchEnd) == null)
				{
					result = (this._OnInputTouchEnd = new FActorOnInputTouchEndSignature(base.NativePtr + (IntPtr)AActor.__PropertyOffset_OnInputTouchEnd, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AActor.__PropertyOffset_OnInputTouchEnd, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x0600142D RID: 5165 RVA: 0x000200A4 File Offset: 0x0001E2A4
		// (set) Token: 0x0600142E RID: 5166 RVA: 0x000200DD File Offset: 0x0001E2DD
		[Nullable(1)]
		public FActorBeginTouchOverSignature OnInputTouchEnter
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FActorBeginTouchOverSignature result;
				if ((result = this._OnInputTouchEnter) == null)
				{
					result = (this._OnInputTouchEnter = new FActorBeginTouchOverSignature(base.NativePtr + (IntPtr)AActor.__PropertyOffset_OnInputTouchEnter, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AActor.__PropertyOffset_OnInputTouchEnter, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x0600142F RID: 5167 RVA: 0x00020100 File Offset: 0x0001E300
		// (set) Token: 0x06001430 RID: 5168 RVA: 0x00020139 File Offset: 0x0001E339
		[Nullable(1)]
		public FActorEndTouchOverSignature OnInputTouchLeave
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FActorEndTouchOverSignature result;
				if ((result = this._OnInputTouchLeave) == null)
				{
					result = (this._OnInputTouchLeave = new FActorEndTouchOverSignature(base.NativePtr + (IntPtr)AActor.__PropertyOffset_OnInputTouchLeave, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AActor.__PropertyOffset_OnInputTouchLeave, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06001431 RID: 5169 RVA: 0x0002015C File Offset: 0x0001E35C
		// (set) Token: 0x06001432 RID: 5170 RVA: 0x00020195 File Offset: 0x0001E395
		[Nullable(1)]
		public FActorHitSignature OnActorHit
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FActorHitSignature result;
				if ((result = this._OnActorHit) == null)
				{
					result = (this._OnActorHit = new FActorHitSignature(base.NativePtr + (IntPtr)AActor.__PropertyOffset_OnActorHit, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AActor.__PropertyOffset_OnActorHit, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06001433 RID: 5171 RVA: 0x000201B8 File Offset: 0x0001E3B8
		// (set) Token: 0x06001434 RID: 5172 RVA: 0x000201F1 File Offset: 0x0001E3F1
		[Nullable(1)]
		public FActorDestroyedSignature OnDestroyed
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FActorDestroyedSignature result;
				if ((result = this._OnDestroyed) == null)
				{
					result = (this._OnDestroyed = new FActorDestroyedSignature(base.NativePtr + (IntPtr)AActor.__PropertyOffset_OnDestroyed, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AActor.__PropertyOffset_OnDestroyed, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06001435 RID: 5173 RVA: 0x00020214 File Offset: 0x0001E414
		// (set) Token: 0x06001436 RID: 5174 RVA: 0x0002024D File Offset: 0x0001E44D
		[Nullable(1)]
		public FActorEndPlaySignature OnEndPlay
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FActorEndPlaySignature result;
				if ((result = this._OnEndPlay) == null)
				{
					result = (this._OnEndPlay = new FActorEndPlaySignature(base.NativePtr + (IntPtr)AActor.__PropertyOffset_OnEndPlay, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AActor.__PropertyOffset_OnEndPlay, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06001437 RID: 5175 RVA: 0x00020270 File Offset: 0x0001E470
		// (set) Token: 0x06001438 RID: 5176 RVA: 0x000202A9 File Offset: 0x0001E4A9
		[Nullable(1)]
		public TArray<UActorComponent> InstanceComponents
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UActorComponent> result;
				if ((result = this._InstanceComponents) == null)
				{
					result = (this._InstanceComponents = new TArray<UActorComponent>(base.NativePtr + (IntPtr)AActor.__PropertyOffset_InstanceComponents, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.InstanceComponents.CopyAssign(value);
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06001439 RID: 5177 RVA: 0x000202B8 File Offset: 0x0001E4B8
		// (set) Token: 0x0600143A RID: 5178 RVA: 0x000202F1 File Offset: 0x0001E4F1
		[Nullable(1)]
		public TArray<UActorComponent> BlueprintCreatedComponents
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UActorComponent> result;
				if ((result = this._BlueprintCreatedComponents) == null)
				{
					result = (this._BlueprintCreatedComponents = new TArray<UActorComponent>(base.NativePtr + (IntPtr)AActor.__PropertyOffset_BlueprintCreatedComponents, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BlueprintCreatedComponents.CopyAssign(value);
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x0600143B RID: 5179 RVA: 0x00020300 File Offset: 0x0001E500
		// (set) Token: 0x0600143C RID: 5180 RVA: 0x00020339 File Offset: 0x0001E539
		[Nullable(1)]
		public TArray<AActor> MoveIgnoreActors
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._MoveIgnoreActors) == null)
				{
					result = (this._MoveIgnoreActors = new TArray<AActor>(base.NativePtr + (IntPtr)AActor.__PropertyOffset_MoveIgnoreActors, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MoveIgnoreActors.CopyAssign(value);
			}
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x00020347 File Offset: 0x0001E547
		public bool WasRecentlyRenderedOnScreen(float Tolerance = 0.2f)
		{
			return AActor.__WasRecentlyRenderedOnScreen_Internal(base.NativePtr, Tolerance);
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x00020355 File Offset: 0x0001E555
		public bool WasRecentlyRendered(float Tolerance = 0.2f)
		{
			return AActor.__WasRecentlyRendered_Internal(base.NativePtr, Tolerance);
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x00020363 File Offset: 0x0001E563
		public bool WasRecentlyPassVisibilityTest(float Tolerance = 0.2f)
		{
			return AActor.__WasRecentlyPassVisibilityTest_Internal(base.NativePtr, Tolerance);
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x00020371 File Offset: 0x0001E571
		public virtual void UserConstructionScript()
		{
			AActor.__UserConstructionScript_Internal(base.NativePtr);
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x0002037E File Offset: 0x0001E57E
		public void TearOff()
		{
			AActor.__TearOff_Internal(base.NativePtr);
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x0002038B File Offset: 0x0001E58B
		public void SnapRootComponentTo(AActor InParentActor, FName InSocketName)
		{
			AActor.__SnapRootComponentTo_Internal(base.NativePtr, (InParentActor != null) ? InParentActor.NativePtr : IntPtr.Zero, InSocketName);
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x000203A9 File Offset: 0x0001E5A9
		public void SetTickGroup(ETickingGroup NewTickGroup)
		{
			AActor.__SetTickGroup_Internal(base.NativePtr, NewTickGroup);
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x000203BC File Offset: 0x0001E5BC
		public void SetTickableWhenPaused(bool bTickableWhenPaused)
		{
			AActor.__SetTickableWhenPaused_Internal(base.NativePtr, bTickableWhenPaused);
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x000203CA File Offset: 0x0001E5CA
		public void SetReplicates(bool bInReplicates)
		{
			AActor.__SetReplicates_Internal(base.NativePtr, bInReplicates);
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x000203D8 File Offset: 0x0001E5D8
		public void SetReplicateMovement(bool bInReplicateMovement)
		{
			AActor.__SetReplicateMovement_Internal(base.NativePtr, bInReplicateMovement);
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x000203E6 File Offset: 0x0001E5E6
		public void SetPrimitiveEntityType(uint type)
		{
			AActor.__SetPrimitiveEntityType_Internal(base.NativePtr, type);
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x000203F4 File Offset: 0x0001E5F4
		public void SetPrimitiveBlueprintTypeName(FName Name)
		{
			AActor.__SetPrimitiveBlueprintTypeName_Internal(base.NativePtr, Name);
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x00020402 File Offset: 0x0001E602
		public void SetOwner(AActor NewOwner)
		{
			AActor.__SetOwner_Internal(base.NativePtr, (NewOwner != null) ? NewOwner.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x0002041F File Offset: 0x0001E61F
		public void SetLifeSpan(float InLifespan)
		{
			AActor.__SetLifeSpan_Internal(base.NativePtr, InLifespan);
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x0002042D File Offset: 0x0001E62D
		public void SetKuroOnlyTickOutside(bool OnlyTickOutside)
		{
			AActor.__SetKuroOnlyTickOutside_Internal(base.NativePtr, OnlyTickOutside);
		}

		// Token: 0x0600144C RID: 5196
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetKuroNetMode(EKuroNetMode KNM);

		// Token: 0x0600144D RID: 5197 RVA: 0x0002043B File Offset: 0x0001E63B
		public void SetKuroFadeGroup(int Group)
		{
			AActor.__SetKuroFadeGroup_Internal(base.NativePtr, Group);
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x00020449 File Offset: 0x0001E649
		public void SetIsIgnoreUpdateOverlap(bool bShouldIgnoreUpdateOverlap)
		{
			AActor.__SetIsIgnoreUpdateOverlap_Internal(base.NativePtr, bShouldIgnoreUpdateOverlap);
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x00020457 File Offset: 0x0001E657
		public void SetForceHidden(bool bForce)
		{
			AActor.__SetForceHidden_Internal(base.NativePtr, bForce);
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x00020465 File Offset: 0x0001E665
		public void SetAutoDestroyWhenFinished(bool bVal)
		{
			AActor.__SetAutoDestroyWhenFinished_Internal(base.NativePtr, bVal);
		}

		// Token: 0x06001451 RID: 5201 RVA: 0x00020473 File Offset: 0x0001E673
		public void SetActorViewableInRender(bool bNewViewable)
		{
			AActor.__SetActorViewableInRender_Internal(base.NativePtr, bNewViewable);
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x00020481 File Offset: 0x0001E681
		public void SetActorTickInterval(float TickInterval)
		{
			AActor.__SetActorTickInterval_Internal(base.NativePtr, TickInterval);
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x0002048F File Offset: 0x0001E68F
		public void SetActorTickEnabled(bool bEnabled)
		{
			AActor.__SetActorTickEnabled_Internal(base.NativePtr, bEnabled);
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x0002049D File Offset: 0x0001E69D
		public void SetActorScale3D(FVector NewScale3D)
		{
			AActor.__SetActorScale3D_Internal(base.NativePtr, NewScale3D);
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x000204AB File Offset: 0x0001E6AB
		public void SetActorRelativeScale3D(FVector NewRelativeScale)
		{
			AActor.__SetActorRelativeScale3D_Internal(base.NativePtr, NewRelativeScale);
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x000204B9 File Offset: 0x0001E6B9
		public void SetActorHiddenInGame(bool bNewHidden)
		{
			AActor.__SetActorHiddenInGame_Internal(base.NativePtr, bNewHidden);
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x000204C7 File Offset: 0x0001E6C7
		public void SetActorEnableCollision(bool bNewActorEnableCollision)
		{
			AActor.__SetActorEnableCollision_Internal(base.NativePtr, bNewActorEnableCollision);
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x000204D5 File Offset: 0x0001E6D5
		public void RemoveTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
		{
			AActor.__RemoveTickPrerequisiteComponent_Internal(base.NativePtr, (PrerequisiteComponent != null) ? PrerequisiteComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x000204F2 File Offset: 0x0001E6F2
		public void RemoveTickPrerequisiteActor(AActor PrerequisiteActor)
		{
			AActor.__RemoveTickPrerequisiteActor_Internal(base.NativePtr, (PrerequisiteActor != null) ? PrerequisiteActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x0002050F File Offset: 0x0001E70F
		public void RefreshKuroFadeGroup()
		{
			AActor.__RefreshKuroFadeGroup_Internal(base.NativePtr);
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x0002051C File Offset: 0x0001E71C
		public virtual void ReceiveTick(float DeltaSeconds)
		{
			AActor.__ReceiveTick_Internal(base.NativePtr, DeltaSeconds);
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x0002052C File Offset: 0x0001E72C
		public virtual void ReceiveHit(UPrimitiveComponent MyComp, AActor Other, UPrimitiveComponent OtherComp, bool bSelfMoved, FVector HitLocation, FVector HitNormal, FVector NormalImpulse, in FHitResult Hit)
		{
			AActor.__ReceiveHit_Internal(base.NativePtr, (MyComp != null) ? MyComp.NativePtr : IntPtr.Zero, (Other != null) ? Other.NativePtr : IntPtr.Zero, (OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero, bSelfMoved, HitLocation, HitNormal, NormalImpulse, (Hit ?? new FHitResult()).NativePtr);
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x0002058D File Offset: 0x0001E78D
		public virtual void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			AActor.__ReceiveEndPlay_Internal(base.NativePtr, EndPlayReason);
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x000205A0 File Offset: 0x0001E7A0
		public virtual void ReceiveDestroyed()
		{
			AActor.__ReceiveDestroyed_Internal(base.NativePtr);
		}

		// Token: 0x0600145F RID: 5215 RVA: 0x000205AD File Offset: 0x0001E7AD
		public virtual void ReceiveBeginPlay()
		{
			AActor.__ReceiveBeginPlay_Internal(base.NativePtr);
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x000205BA File Offset: 0x0001E7BA
		public virtual void ReceiveActorOnReleased(FKey ButtonReleased)
		{
			AActor.__ReceiveActorOnReleased_Internal(base.NativePtr, (ButtonReleased ?? new FKey()).NativePtr);
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x000205D6 File Offset: 0x0001E7D6
		public virtual void ReceiveActorOnInputTouchLeave(ETouchIndex FingerIndex)
		{
			AActor.__ReceiveActorOnInputTouchLeave_Internal(base.NativePtr, FingerIndex);
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x000205E9 File Offset: 0x0001E7E9
		public virtual void ReceiveActorOnInputTouchEnter(ETouchIndex FingerIndex)
		{
			AActor.__ReceiveActorOnInputTouchEnter_Internal(base.NativePtr, FingerIndex);
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x000205FC File Offset: 0x0001E7FC
		public virtual void ReceiveActorOnInputTouchEnd(ETouchIndex FingerIndex)
		{
			AActor.__ReceiveActorOnInputTouchEnd_Internal(base.NativePtr, FingerIndex);
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x0002060F File Offset: 0x0001E80F
		public virtual void ReceiveActorOnInputTouchBegin(ETouchIndex FingerIndex)
		{
			AActor.__ReceiveActorOnInputTouchBegin_Internal(base.NativePtr, FingerIndex);
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x00020622 File Offset: 0x0001E822
		public virtual void ReceiveActorOnClicked(FKey ButtonPressed)
		{
			AActor.__ReceiveActorOnClicked_Internal(base.NativePtr, (ButtonPressed ?? new FKey()).NativePtr);
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x0002063E File Offset: 0x0001E83E
		public virtual void ReceiveActorEndOverlap(AActor OtherActor)
		{
			AActor.__ReceiveActorEndOverlap_Internal(base.NativePtr, (OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x0002065B File Offset: 0x0001E85B
		public virtual void ReceiveActorEndCursorOver()
		{
			AActor.__ReceiveActorEndCursorOver_Internal(base.NativePtr);
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x00020668 File Offset: 0x0001E868
		public virtual void ReceiveActorBeginOverlap(AActor OtherActor)
		{
			AActor.__ReceiveActorBeginOverlap_Internal(base.NativePtr, (OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001469 RID: 5225 RVA: 0x00020685 File Offset: 0x0001E885
		public virtual void ReceiveActorBeginCursorOver()
		{
			AActor.__ReceiveActorBeginCursorOver_Internal(base.NativePtr);
		}

		// Token: 0x0600146A RID: 5226 RVA: 0x00020692 File Offset: 0x0001E892
		public void PrestreamTextures(float Seconds, bool bEnableStreaming, int CinematicTextureGroups = 0)
		{
			AActor.__PrestreamTextures_Internal(base.NativePtr, Seconds, bEnableStreaming, CinematicTextureGroups);
		}

		// Token: 0x0600146B RID: 5227 RVA: 0x000206A2 File Offset: 0x0001E8A2
		public void OnRep_ReplicateMovement()
		{
			AActor.__OnRep_ReplicateMovement_Internal(base.NativePtr);
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x000206AF File Offset: 0x0001E8AF
		public void OnRep_ReplicatedMovement()
		{
			AActor.__OnRep_ReplicatedMovement_Internal(base.NativePtr);
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x000206BC File Offset: 0x0001E8BC
		public void OnRep_Owner()
		{
			AActor.__OnRep_Owner_Internal(base.NativePtr);
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x000206C9 File Offset: 0x0001E8C9
		public void OnRep_Instigator()
		{
			AActor.__OnRep_Instigator_Internal(base.NativePtr);
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x000206D6 File Offset: 0x0001E8D6
		public void OnRep_AttachmentReplication()
		{
			AActor.__OnRep_AttachmentReplication_Internal(base.NativePtr);
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x000206E3 File Offset: 0x0001E8E3
		public void MakeNoise(float Loudness = 1f, APawn NoiseInstigator = null, FVector NoiseLocation = default(FVector), float MaxRange = 0f, FName Tag = default(FName))
		{
			AActor.__MakeNoise_Internal(base.NativePtr, Loudness, (NoiseInstigator != null) ? NoiseInstigator.NativePtr : IntPtr.Zero, NoiseLocation, MaxRange, Tag);
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x00020706 File Offset: 0x0001E906
		public UMaterialInstanceDynamic MakeMIDForMaterial(UMaterialInterface Parent)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(AActor.__MakeMIDForMaterial_Internal(base.NativePtr, (Parent != null) ? Parent.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x00020728 File Offset: 0x0001E928
		public void KuroTickActorOutside(float DeltaSeconds)
		{
			AActor.__KuroTickActorOutside_Internal(base.NativePtr, DeltaSeconds);
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x00020736 File Offset: 0x0001E936
		public void Kuro_SetRole(EKuroNetRole InRole)
		{
			AActor.__Kuro_SetRole_Internal(base.NativePtr, InRole);
		}

		// Token: 0x06001474 RID: 5236 RVA: 0x00020749 File Offset: 0x0001E949
		public void Kuro_OnRep_ReplicatedMovement()
		{
			AActor.__Kuro_OnRep_ReplicatedMovement_Internal(base.NativePtr);
		}

		// Token: 0x06001475 RID: 5237 RVA: 0x00020756 File Offset: 0x0001E956
		[NullableContext(0)]
		public TEnumAsByte<EKuroNetRole> Kuro_GetLocalRole()
		{
			return AActor.__Kuro_GetLocalRole_Internal(base.NativePtr);
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x00020763 File Offset: 0x0001E963
		public bool K2_TeleportTo(FVector DestLocation, FRotator DestRotation)
		{
			return AActor.__K2_TeleportTo_Internal(base.NativePtr, DestLocation, DestRotation);
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x00020772 File Offset: 0x0001E972
		public void K2_SetDeferedConcurrentUpdateTransform(bool bEnable)
		{
			AActor.__K2_SetDeferedConcurrentUpdateTransform_Internal(base.NativePtr, bEnable);
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x00020780 File Offset: 0x0001E980
		public unsafe bool K2_SetActorTransformForce(in FTransform NewTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = NewTransform;
			return AActor.__K2_SetActorTransformForce_Internal(base.NativePtr, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x000207C8 File Offset: 0x0001E9C8
		public unsafe bool K2_SetActorTransform(in FTransform NewTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = NewTransform;
			return AActor.__K2_SetActorTransform_Internal(base.NativePtr, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x0600147A RID: 5242 RVA: 0x00020810 File Offset: 0x0001EA10
		public bool K2_SetActorRotation(FRotator NewRotation, bool bTeleportPhysics)
		{
			return AActor.__K2_SetActorRotation_Internal(base.NativePtr, NewRotation, bTeleportPhysics);
		}

		// Token: 0x0600147B RID: 5243 RVA: 0x00020820 File Offset: 0x0001EA20
		public unsafe void K2_SetActorRelativeTransform(in FTransform NewRelativeTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = NewRelativeTransform;
			AActor.__K2_SetActorRelativeTransform_Internal(base.NativePtr, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x00020868 File Offset: 0x0001EA68
		public void K2_SetActorRelativeRotation(FRotator NewRelativeRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			AActor.__K2_SetActorRelativeRotation_Internal(base.NativePtr, NewRelativeRotation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x00020889 File Offset: 0x0001EA89
		public void K2_SetActorRelativeLocation(FVector NewRelativeLocation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			AActor.__K2_SetActorRelativeLocation_Internal(base.NativePtr, NewRelativeLocation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x0600147E RID: 5246 RVA: 0x000208AA File Offset: 0x0001EAAA
		public bool K2_SetActorLocationAndRotation(FVector NewLocation, FRotator NewRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			return AActor.__K2_SetActorLocationAndRotation_Internal(base.NativePtr, NewLocation, NewRotation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x0600147F RID: 5247 RVA: 0x000208CD File Offset: 0x0001EACD
		public bool K2_SetActorLocation(FVector NewLocation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			return AActor.__K2_SetActorLocation_Internal(base.NativePtr, NewLocation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x000208EE File Offset: 0x0001EAEE
		public virtual void K2_OnReset()
		{
			AActor.__K2_OnReset_Internal(base.NativePtr);
		}

		// Token: 0x06001481 RID: 5249 RVA: 0x000208FB File Offset: 0x0001EAFB
		public virtual void K2_OnEndViewTarget(APlayerController PC)
		{
			AActor.__K2_OnEndViewTarget_Internal(base.NativePtr, (PC != null) ? PC.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001482 RID: 5250 RVA: 0x00020918 File Offset: 0x0001EB18
		public virtual void K2_OnBecomeViewTarget(APlayerController PC)
		{
			AActor.__K2_OnBecomeViewTarget_Internal(base.NativePtr, (PC != null) ? PC.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001483 RID: 5251 RVA: 0x00020935 File Offset: 0x0001EB35
		public bool K2_KuroTeleportTo(FVector DestLocation, FRotator DestRotation)
		{
			return AActor.__K2_KuroTeleportTo_Internal(base.NativePtr, DestLocation, DestRotation);
		}

		// Token: 0x06001484 RID: 5252 RVA: 0x00020944 File Offset: 0x0001EB44
		public bool K2_KuroSetActorRotation(FRotator NewRotation, bool bSweep, bool bTeleportPhysics, bool bIgnoreOverlap = false)
		{
			return AActor.__K2_KuroSetActorRotation_Internal(base.NativePtr, NewRotation, bSweep, bTeleportPhysics, bIgnoreOverlap);
		}

		// Token: 0x06001485 RID: 5253 RVA: 0x00020956 File Offset: 0x0001EB56
		public USceneComponent K2_GetRootComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USceneComponent>(AActor.__K2_GetRootComponent_Internal(base.NativePtr));
		}

		// Token: 0x06001486 RID: 5254 RVA: 0x00020968 File Offset: 0x0001EB68
		[NullableContext(1)]
		public TArray<UActorComponent> K2_GetComponentsByClass([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UActorComponent> ComponentClass)
		{
			return new TArray<UActorComponent>(AActor.__K2_GetComponentsByClass_Internal(base.NativePtr, ComponentClass._NativePtr), null);
		}

		// Token: 0x06001487 RID: 5255 RVA: 0x00020981 File Offset: 0x0001EB81
		public FRotator K2_GetActorRotation()
		{
			return AActor.__K2_GetActorRotation_Internal(base.NativePtr);
		}

		// Token: 0x06001488 RID: 5256 RVA: 0x0002098E File Offset: 0x0001EB8E
		public FQuat K2_GetActorQuaternion()
		{
			return AActor.__K2_GetActorQuaternion_Internal(base.NativePtr);
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x0002099B File Offset: 0x0001EB9B
		public FVector K2_GetActorLocation()
		{
			return AActor.__K2_GetActorLocation_Internal(base.NativePtr);
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x000209A8 File Offset: 0x0001EBA8
		public void K2_DetachFromActor(EDetachmentRule LocationRule = EDetachmentRule.KeepRelative, EDetachmentRule RotationRule = EDetachmentRule.KeepRelative, EDetachmentRule ScaleRule = EDetachmentRule.KeepRelative)
		{
			AActor.__K2_DetachFromActor_Internal(base.NativePtr, LocationRule, RotationRule, ScaleRule);
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x000209B8 File Offset: 0x0001EBB8
		public void K2_DestroyComponent(UActorComponent Component)
		{
			AActor.__K2_DestroyComponent_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600148C RID: 5260 RVA: 0x000209D5 File Offset: 0x0001EBD5
		public void K2_DestroyActor()
		{
			AActor.__K2_DestroyActor_Internal(base.NativePtr);
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x000209E2 File Offset: 0x0001EBE2
		public void K2_AttachToComponent(USceneComponent Parent, FName SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies, bool bCalcWorldOrigin = true)
		{
			AActor.__K2_AttachToComponent_Internal(base.NativePtr, (Parent != null) ? Parent.NativePtr : IntPtr.Zero, SocketName, LocationRule, RotationRule, ScaleRule, bWeldSimulatedBodies, bCalcWorldOrigin);
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x00020A09 File Offset: 0x0001EC09
		public void K2_AttachToActor(AActor ParentActor, FName SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies, bool bCalcWorldOrigin = true)
		{
			AActor.__K2_AttachToActor_Internal(base.NativePtr, (ParentActor != null) ? ParentActor.NativePtr : IntPtr.Zero, SocketName, LocationRule, RotationRule, ScaleRule, bWeldSimulatedBodies, bCalcWorldOrigin);
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x00020A30 File Offset: 0x0001EC30
		public void K2_AttachRootComponentToActor(AActor InParentActor, FName InSocketName = default(FName), EAttachLocation AttachLocationType = EAttachLocation.KeepRelativeOffset, bool bWeldSimulatedBodies = true)
		{
			AActor.__K2_AttachRootComponentToActor_Internal(base.NativePtr, (InParentActor != null) ? InParentActor.NativePtr : IntPtr.Zero, InSocketName, AttachLocationType, bWeldSimulatedBodies);
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x00020A56 File Offset: 0x0001EC56
		public void K2_AttachRootComponentTo(USceneComponent InParent, FName InSocketName = default(FName), EAttachLocation AttachLocationType = EAttachLocation.KeepRelativeOffset, bool bWeldSimulatedBodies = true)
		{
			AActor.__K2_AttachRootComponentTo_Internal(base.NativePtr, (InParent != null) ? InParent.NativePtr : IntPtr.Zero, InSocketName, AttachLocationType, bWeldSimulatedBodies);
		}

		// Token: 0x06001491 RID: 5265 RVA: 0x00020A7C File Offset: 0x0001EC7C
		public unsafe void K2_AddActorWorldTransformKeepScale(in FTransform DeltaTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = DeltaTransform;
			AActor.__K2_AddActorWorldTransformKeepScale_Internal(base.NativePtr, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06001492 RID: 5266 RVA: 0x00020AC4 File Offset: 0x0001ECC4
		public unsafe void K2_AddActorWorldTransform(in FTransform DeltaTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = DeltaTransform;
			AActor.__K2_AddActorWorldTransform_Internal(base.NativePtr, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06001493 RID: 5267 RVA: 0x00020B0C File Offset: 0x0001ED0C
		public void K2_AddActorWorldRotation(FRotator DeltaRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			AActor.__K2_AddActorWorldRotation_Internal(base.NativePtr, DeltaRotation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x00020B2D File Offset: 0x0001ED2D
		public void K2_AddActorWorldOffset(FVector DeltaLocation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			AActor.__K2_AddActorWorldOffset_Internal(base.NativePtr, DeltaLocation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06001495 RID: 5269 RVA: 0x00020B50 File Offset: 0x0001ED50
		public unsafe void K2_AddActorLocalTransform(in FTransform NewTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = NewTransform;
			AActor.__K2_AddActorLocalTransform_Internal(base.NativePtr, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x00020B98 File Offset: 0x0001ED98
		public void K2_AddActorLocalRotation(FRotator DeltaRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			AActor.__K2_AddActorLocalRotation_Internal(base.NativePtr, DeltaRotation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x00020BB9 File Offset: 0x0001EDB9
		public void K2_AddActorLocalOffset(FVector DeltaLocation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			AActor.__K2_AddActorLocalOffset_Internal(base.NativePtr, DeltaLocation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x00020BDA File Offset: 0x0001EDDA
		public bool IsUEOrignal()
		{
			return AActor.__IsUEOrignal_Internal(base.NativePtr);
		}

		// Token: 0x06001499 RID: 5273 RVA: 0x00020BE7 File Offset: 0x0001EDE7
		public bool IsOverlappingActor(AActor Other)
		{
			return AActor.__IsOverlappingActor_Internal(base.NativePtr, (Other != null) ? Other.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600149A RID: 5274 RVA: 0x00020C04 File Offset: 0x0001EE04
		public bool IsIgnoreUpdateOverlap()
		{
			return AActor.__IsIgnoreUpdateOverlap_Internal(base.NativePtr);
		}

		// Token: 0x0600149B RID: 5275 RVA: 0x00020C11 File Offset: 0x0001EE11
		public bool IsChildActor()
		{
			return AActor.__IsChildActor_Internal(base.NativePtr);
		}

		// Token: 0x0600149C RID: 5276 RVA: 0x00020C1E File Offset: 0x0001EE1E
		public bool IsAutonomousProxy()
		{
			return AActor.__IsAutonomousProxy_Internal(base.NativePtr);
		}

		// Token: 0x0600149D RID: 5277 RVA: 0x00020C2B File Offset: 0x0001EE2B
		public bool IsActorTickEnabled()
		{
			return AActor.__IsActorTickEnabled_Internal(base.NativePtr);
		}

		// Token: 0x0600149E RID: 5278 RVA: 0x00020C38 File Offset: 0x0001EE38
		public bool IsActorBeingDestroyed()
		{
			return AActor.__IsActorBeingDestroyed_Internal(base.NativePtr);
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x00020C45 File Offset: 0x0001EE45
		public void IgnoreActorWhenMoving(AActor Actor, bool bShouldIgnore, bool bBoth)
		{
			AActor.__IgnoreActorWhenMoving_Internal(base.NativePtr, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, bShouldIgnore, bBoth);
		}

		// Token: 0x060014A0 RID: 5280 RVA: 0x00020C64 File Offset: 0x0001EE64
		public bool HasKuroFadeGroupOverride()
		{
			return AActor.__HasKuroFadeGroupOverride_Internal(base.NativePtr);
		}

		// Token: 0x060014A1 RID: 5281 RVA: 0x00020C71 File Offset: 0x0001EE71
		public bool HasAuthority()
		{
			return AActor.__HasAuthority_Internal(base.NativePtr);
		}

		// Token: 0x060014A2 RID: 5282 RVA: 0x00020C7E File Offset: 0x0001EE7E
		public float GetVerticalDistanceTo(AActor OtherActor)
		{
			return AActor.__GetVerticalDistanceTo_Internal(base.NativePtr, (OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060014A3 RID: 5283 RVA: 0x00020C9B File Offset: 0x0001EE9B
		public FVector GetVelocity()
		{
			return AActor.__GetVelocity_Internal(base.NativePtr);
		}

		// Token: 0x060014A4 RID: 5284 RVA: 0x00020CA8 File Offset: 0x0001EEA8
		public FTransform GetTransformWithUpdate()
		{
			return AActor.__GetTransformWithUpdate_Internal(base.NativePtr);
		}

		// Token: 0x060014A5 RID: 5285 RVA: 0x00020CB5 File Offset: 0x0001EEB5
		public FTransform GetTransform()
		{
			return AActor.__GetTransform_Internal(base.NativePtr);
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x00020CC2 File Offset: 0x0001EEC2
		public bool GetTickableWhenPaused()
		{
			return AActor.__GetTickableWhenPaused_Internal(base.NativePtr);
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x00020CCF File Offset: 0x0001EECF
		public float GetSquaredHorizontalDistanceTo(AActor OtherActor)
		{
			return AActor.__GetSquaredHorizontalDistanceTo_Internal(base.NativePtr, (OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x00020CEC File Offset: 0x0001EEEC
		public float GetSquaredDistanceTo(AActor OtherActor)
		{
			return AActor.__GetSquaredDistanceTo_Internal(base.NativePtr, (OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x00020D09 File Offset: 0x0001EF09
		public uint GetPrimitiveEntityType()
		{
			return AActor.__GetPrimitiveEntityType_Internal(base.NativePtr);
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x00020D16 File Offset: 0x0001EF16
		public FName GetPrimitiveBlueprintTypeName()
		{
			return AActor.__GetPrimitiveBlueprintTypeName_Internal(base.NativePtr);
		}

		// Token: 0x060014AB RID: 5291 RVA: 0x00020D23 File Offset: 0x0001EF23
		public UChildActorComponent GetParentComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UChildActorComponent>(AActor.__GetParentComponent_Internal(base.NativePtr));
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x00020D35 File Offset: 0x0001EF35
		public AActor GetParentActor()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(AActor.__GetParentActor_Internal(base.NativePtr));
		}

		// Token: 0x060014AD RID: 5293 RVA: 0x00020D47 File Offset: 0x0001EF47
		public AActor GetOwner()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(AActor.__GetOwner_Internal(base.NativePtr));
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x00020D59 File Offset: 0x0001EF59
		public void GetOverlappingComponents([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UPrimitiveComponent> OverlappingComponents)
		{
			AActor.__GetOverlappingComponents_Internal(base.NativePtr, (OverlappingComponents ?? new TArray<UPrimitiveComponent>()).NativePtr);
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x00020D76 File Offset: 0x0001EF76
		public void GetOverlappingActors([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<AActor> OverlappingActors, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> ClassFilter = default(TSubclassOf<AActor>))
		{
			AActor.__GetOverlappingActors_Internal(base.NativePtr, (OverlappingActors ?? new TArray<AActor>()).NativePtr, ClassFilter._NativePtr);
		}

		// Token: 0x060014B0 RID: 5296 RVA: 0x00020D99 File Offset: 0x0001EF99
		public float GetLifeSpan()
		{
			return AActor.__GetLifeSpan_Internal(base.NativePtr);
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x00020DA6 File Offset: 0x0001EFA6
		public FTransform GetLevelTransform()
		{
			return AActor.__GetLevelTransform_Internal(base.NativePtr);
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x00020DB3 File Offset: 0x0001EFB3
		public ULevel GetLevel()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevel>(AActor.__GetLevel_Internal(base.NativePtr));
		}

		// Token: 0x060014B3 RID: 5299
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern TEnumAsByte<EKuroNetMode> GetKuroNetMode();

		// Token: 0x060014B4 RID: 5300 RVA: 0x00020DC5 File Offset: 0x0001EFC5
		public int GetKuroFadeGroup()
		{
			return AActor.__GetKuroFadeGroup_Internal(base.NativePtr);
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x00020DD2 File Offset: 0x0001EFD2
		public FTransform GetInverseTransform()
		{
			return AActor.__GetInverseTransform_Internal(base.NativePtr);
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x00020DDF File Offset: 0x0001EFDF
		public AController GetInstigatorController()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AController>(AActor.__GetInstigatorController_Internal(base.NativePtr));
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x00020DF1 File Offset: 0x0001EFF1
		public APawn GetInstigator()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(AActor.__GetInstigator_Internal(base.NativePtr));
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x00020E03 File Offset: 0x0001F003
		public FVector GetInputVectorAxisValue(FKey InputAxisKey)
		{
			return AActor.__GetInputVectorAxisValue_Internal(base.NativePtr, (InputAxisKey ?? new FKey()).NativePtr);
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x00020E1F File Offset: 0x0001F01F
		public float GetInputAxisValue(FName InputAxisName)
		{
			return AActor.__GetInputAxisValue_Internal(base.NativePtr, InputAxisName);
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x00020E2D File Offset: 0x0001F02D
		public float GetInputAxisKeyValue(FKey InputAxisKey)
		{
			return AActor.__GetInputAxisKeyValue_Internal(base.NativePtr, (InputAxisKey ?? new FKey()).NativePtr);
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x00020E49 File Offset: 0x0001F049
		public float GetHorizontalDotProductTo(AActor OtherActor)
		{
			return AActor.__GetHorizontalDotProductTo_Internal(base.NativePtr, (OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x00020E66 File Offset: 0x0001F066
		public float GetHorizontalDistanceTo(AActor OtherActor)
		{
			return AActor.__GetHorizontalDistanceTo_Internal(base.NativePtr, (OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x00020E83 File Offset: 0x0001F083
		public float GetGameTimeSinceCreation()
		{
			return AActor.__GetGameTimeSinceCreation_Internal(base.NativePtr);
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x00020E90 File Offset: 0x0001F090
		public float GetDotProductTo(AActor OtherActor)
		{
			return AActor.__GetDotProductTo_Internal(base.NativePtr, (OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x00020EAD File Offset: 0x0001F0AD
		public float GetDistanceTo(AActor OtherActor)
		{
			return AActor.__GetDistanceTo_Internal(base.NativePtr, (OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x00020ECA File Offset: 0x0001F0CA
		[NullableContext(1)]
		public TArray<UActorComponent> GetComponentsByTag([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UActorComponent> ComponentClass, FName Tag)
		{
			return new TArray<UActorComponent>(AActor.__GetComponentsByTag_Internal(base.NativePtr, ComponentClass._NativePtr, Tag), null);
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x00020EE4 File Offset: 0x0001F0E4
		[NullableContext(1)]
		public TArray<UActorComponent> GetComponentsByInterface(UClassStackOnlyPtr Interface)
		{
			return new TArray<UActorComponent>(AActor.__GetComponentsByInterface_Internal(base.NativePtr, Interface._NativePtr), null);
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x00020EFD File Offset: 0x0001F0FD
		public UActorComponent GetComponentByClass([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UActorComponent> ComponentClass)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UActorComponent>(AActor.__GetComponentByClass_Internal(base.NativePtr, ComponentClass._NativePtr));
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x00020F15 File Offset: 0x0001F115
		public AActor GetAttachRootParentActor()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(AActor.__GetAttachRootParentActor_Internal(base.NativePtr));
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x00020F27 File Offset: 0x0001F127
		public FName GetAttachParentSocketName()
		{
			return AActor.__GetAttachParentSocketName_Internal(base.NativePtr);
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x00020F34 File Offset: 0x0001F134
		public AActor GetAttachParentActor()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(AActor.__GetAttachParentActor_Internal(base.NativePtr));
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x00020F46 File Offset: 0x0001F146
		public void GetAttachedActors([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<AActor> OutActors, bool bResetArray = true)
		{
			AActor.__GetAttachedActors_Internal(base.NativePtr, (OutActors ?? new TArray<AActor>()).NativePtr, bResetArray);
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x00020F64 File Offset: 0x0001F164
		public void GetAttachedActorDescendants([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<AActor> OutActors, bool bResetArray = true)
		{
			AActor.__GetAttachedActorDescendants_Internal(base.NativePtr, (OutActors ?? new TArray<AActor>()).NativePtr, bResetArray);
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x00020F82 File Offset: 0x0001F182
		public void GetAllChildActors([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<AActor> ChildActors, bool bIncludeDescendants = true)
		{
			AActor.__GetAllChildActors_Internal(base.NativePtr, (ChildActors ?? new TArray<AActor>()).NativePtr, bIncludeDescendants);
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x00020FA0 File Offset: 0x0001F1A0
		public FVector GetActorUpVector()
		{
			return AActor.__GetActorUpVector_Internal(base.NativePtr);
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x00020FAD File Offset: 0x0001F1AD
		public float GetActorTimeDilation()
		{
			return AActor.__GetActorTimeDilation_Internal(base.NativePtr);
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x00020FBA File Offset: 0x0001F1BA
		public float GetActorTickInterval()
		{
			return AActor.__GetActorTickInterval_Internal(base.NativePtr);
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x00020FC7 File Offset: 0x0001F1C7
		public FVector GetActorScale3D()
		{
			return AActor.__GetActorScale3D_Internal(base.NativePtr);
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x00020FD4 File Offset: 0x0001F1D4
		public FVector GetActorRightVector()
		{
			return AActor.__GetActorRightVector_Internal(base.NativePtr);
		}

		// Token: 0x060014CE RID: 5326 RVA: 0x00020FE1 File Offset: 0x0001F1E1
		public FVector GetActorRelativeScale3D()
		{
			return AActor.__GetActorRelativeScale3D_Internal(base.NativePtr);
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x00020FEE File Offset: 0x0001F1EE
		public FVector GetActorForwardVector()
		{
			return AActor.__GetActorForwardVector_Internal(base.NativePtr);
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x00020FFC File Offset: 0x0001F1FC
		public unsafe void GetActorEyesViewPoint(ref FVector OutLocation, ref FRotator OutRotation, int CameraIndex = 0)
		{
			fixed (FVector* ptr = &OutLocation)
			{
				void* ptr2 = (void*)ptr;
				fixed (FRotator* ptr3 = &OutRotation)
				{
					void* ptr4 = (void*)ptr3;
					AActor.__GetActorEyesViewPoint_Internal(base.NativePtr, ref OutLocation, ref OutRotation, CameraIndex);
					ptr = null;
				}
			}
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x00021027 File Offset: 0x0001F227
		public bool GetActorEnableCollision()
		{
			return AActor.__GetActorEnableCollision_Internal(base.NativePtr);
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x00021034 File Offset: 0x0001F234
		public unsafe void GetActorBounds(bool bOnlyCollidingComponents, ref FVector Origin, ref FVector BoxExtent, bool bIncludeFromChildActors = false)
		{
			fixed (FVector* ptr = &Origin)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &BoxExtent)
				{
					void* ptr4 = (void*)ptr3;
					AActor.__GetActorBounds_Internal(base.NativePtr, bOnlyCollidingComponents, ref Origin, ref BoxExtent, bIncludeFromChildActors);
					ptr = null;
				}
			}
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x00021061 File Offset: 0x0001F261
		public void ForceNetUpdate()
		{
			AActor.__ForceNetUpdate_Internal(base.NativePtr);
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x0002106E File Offset: 0x0001F26E
		public void FlushNetDormancy()
		{
			AActor.__FlushNetDormancy_Internal(base.NativePtr);
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x0002107C File Offset: 0x0001F27C
		public unsafe void FinishAddComponent(UActorComponent Component, bool bManualAttachment, in FTransform RelativeTransform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = RelativeTransform;
			AActor.__FinishAddComponent_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero, bManualAttachment, ptr);
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x000210C2 File Offset: 0x0001F2C2
		public void EnableInput(APlayerController PlayerController)
		{
			AActor.__EnableInput_Internal(base.NativePtr, (PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x000210DF File Offset: 0x0001F2DF
		public void DisableInput(APlayerController PlayerController)
		{
			AActor.__DisableInput_Internal(base.NativePtr, (PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x000210FC File Offset: 0x0001F2FC
		public void DetachRootComponentFromParent(bool bMaintainWorldPosition = true)
		{
			AActor.__DetachRootComponentFromParent_Internal(base.NativePtr, bMaintainWorldPosition);
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x0002110A File Offset: 0x0001F30A
		public void D_SetActorScale3D(FVectorDouble NewScale3D)
		{
			AActor.__D_SetActorScale3D_Internal(base.NativePtr, NewScale3D);
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x00021118 File Offset: 0x0001F318
		public bool D_K2_TeleportTo(FVectorDouble DestLocation, FRotator DestRotation)
		{
			return AActor.__D_K2_TeleportTo_Internal(base.NativePtr, DestLocation, DestRotation);
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x00021128 File Offset: 0x0001F328
		public unsafe bool D_K2_SetActorTransformForce(in FTransformDouble NewTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = NewTransform;
			return AActor.__D_K2_SetActorTransformForce_Internal(base.NativePtr, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x00021170 File Offset: 0x0001F370
		public unsafe bool D_K2_SetActorTransform(in FTransformDouble NewTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = NewTransform;
			return AActor.__D_K2_SetActorTransform_Internal(base.NativePtr, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x000211B8 File Offset: 0x0001F3B8
		public unsafe void D_K2_SetActorRelativeTransform(in FTransformDouble NewRelativeTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = NewRelativeTransform;
			AActor.__D_K2_SetActorRelativeTransform_Internal(base.NativePtr, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x00021200 File Offset: 0x0001F400
		public void D_K2_SetActorRelativeLocation(FVectorDouble NewRelativeLocation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			AActor.__D_K2_SetActorRelativeLocation_Internal(base.NativePtr, NewRelativeLocation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x00021221 File Offset: 0x0001F421
		public bool D_K2_SetActorLocationAndRotation(FVectorDouble NewLocation, FRotator NewRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			return AActor.__D_K2_SetActorLocationAndRotation_Internal(base.NativePtr, NewLocation, NewRotation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x00021244 File Offset: 0x0001F444
		public bool D_K2_SetActorLocation(FVectorDouble NewLocation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			return AActor.__D_K2_SetActorLocation_Internal(base.NativePtr, NewLocation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x00021265 File Offset: 0x0001F465
		public bool D_K2_KuroTeleportTo(FVectorDouble DestLocation, FRotator DestRotation)
		{
			return AActor.__D_K2_KuroTeleportTo_Internal(base.NativePtr, DestLocation, DestRotation);
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x00021274 File Offset: 0x0001F474
		public FVectorDouble D_K2_GetActorLocation()
		{
			return AActor.__D_K2_GetActorLocation_Internal(base.NativePtr);
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x00021284 File Offset: 0x0001F484
		public unsafe void D_K2_AddActorWorldTransform(in FTransformDouble DeltaTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = DeltaTransform;
			AActor.__D_K2_AddActorWorldTransform_Internal(base.NativePtr, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x000212CC File Offset: 0x0001F4CC
		public void D_K2_AddActorWorldOffset(FVectorDouble DeltaLocation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			AActor.__D_K2_AddActorWorldOffset_Internal(base.NativePtr, DeltaLocation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x000212F0 File Offset: 0x0001F4F0
		public unsafe void D_K2_AddActorLocalTransform(in FTransformDouble NewTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = NewTransform;
			AActor.__D_K2_AddActorLocalTransform_Internal(base.NativePtr, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x00021338 File Offset: 0x0001F538
		public void D_K2_AddActorLocalOffset(FVectorDouble DeltaLocation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			AActor.__D_K2_AddActorLocalOffset_Internal(base.NativePtr, DeltaLocation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x00021359 File Offset: 0x0001F559
		public FVectorDouble D_GetVelocity()
		{
			return AActor.__D_GetVelocity_Internal(base.NativePtr);
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x00021366 File Offset: 0x0001F566
		public FTransformDouble D_GetTransformWithUpdate()
		{
			return AActor.__D_GetTransformWithUpdate_Internal(base.NativePtr);
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x00021373 File Offset: 0x0001F573
		public FTransformDouble D_GetTransform()
		{
			return AActor.__D_GetTransform_Internal(base.NativePtr);
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x00021380 File Offset: 0x0001F580
		public FTransformDouble D_GetInverseTransform()
		{
			return AActor.__D_GetInverseTransform_Internal(base.NativePtr);
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x0002138D File Offset: 0x0001F58D
		public double D_GetGameTimeSinceCreation()
		{
			return AActor.__D_GetGameTimeSinceCreation_Internal(base.NativePtr);
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x0002139A File Offset: 0x0001F59A
		public double D_GetDistanceTo(AActor OtherActor)
		{
			return AActor.__D_GetDistanceTo_Internal(base.NativePtr, (OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x000213B7 File Offset: 0x0001F5B7
		public FVectorDouble D_GetActorUpVector()
		{
			return AActor.__D_GetActorUpVector_Internal(base.NativePtr);
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x000213C4 File Offset: 0x0001F5C4
		public FVectorDouble D_GetActorScale3D()
		{
			return AActor.__D_GetActorScale3D_Internal(base.NativePtr);
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x000213D1 File Offset: 0x0001F5D1
		public FVectorDouble D_GetActorRightVector()
		{
			return AActor.__D_GetActorRightVector_Internal(base.NativePtr);
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x000213DE File Offset: 0x0001F5DE
		public FVectorDouble D_GetActorForwardVector()
		{
			return AActor.__D_GetActorForwardVector_Internal(base.NativePtr);
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x000213EC File Offset: 0x0001F5EC
		public unsafe void D_GetActorBounds(bool bOnlyCollidingComponents, ref FVectorDouble Origin, ref FVector BoxExtent, bool bIncludeFromChildActors = false)
		{
			fixed (FVectorDouble* ptr = &Origin)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &BoxExtent)
				{
					void* ptr4 = (void*)ptr3;
					AActor.__D_GetActorBounds_Internal(base.NativePtr, bOnlyCollidingComponents, ref Origin, ref BoxExtent, bIncludeFromChildActors);
					ptr = null;
				}
			}
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x0002141C File Offset: 0x0001F61C
		public unsafe UActorComponent D_AddComponentByClass([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UActorComponent> Class, bool bManualAttachment, in FTransformDouble RelativeTransform, bool bDeferredFinish, FName ComponentName = default(FName))
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = RelativeTransform;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UActorComponent>(AActor.__D_AddComponentByClass_Internal(base.NativePtr, Class._NativePtr, bManualAttachment, ptr, bDeferredFinish, ComponentName));
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x00021461 File Offset: 0x0001F661
		public void ClearMoveIgnoreActors(bool bClearBoth)
		{
			AActor.__ClearMoveIgnoreActors_Internal(base.NativePtr, bClearBoth);
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x0002146F File Offset: 0x0001F66F
		public void ClearKuroFadeGroupOverride()
		{
			AActor.__ClearKuroFadeGroupOverride_Internal(base.NativePtr);
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x0002147C File Offset: 0x0001F67C
		public void AddTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
		{
			AActor.__AddTickPrerequisiteComponent_Internal(base.NativePtr, (PrerequisiteComponent != null) ? PrerequisiteComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x00021499 File Offset: 0x0001F699
		public void AddTickPrerequisiteActor(AActor PrerequisiteActor)
		{
			AActor.__AddTickPrerequisiteActor_Internal(base.NativePtr, (PrerequisiteActor != null) ? PrerequisiteActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x000214B8 File Offset: 0x0001F6B8
		public unsafe UActorComponent AddComponentByClass([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UActorComponent> Class, bool bManualAttachment, in FTransform RelativeTransform, bool bDeferredFinish, FName ComponentName = default(FName))
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = RelativeTransform;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UActorComponent>(AActor.__AddComponentByClass_Internal(base.NativePtr, Class._NativePtr, bManualAttachment, ptr, bDeferredFinish, ComponentName));
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x00021500 File Offset: 0x0001F700
		public unsafe UActorComponent AddComponent(FName TemplateName, bool bManualAttachment, in FTransform RelativeTransform, UObject ComponentTemplateContext, bool bDeferredFinish = false)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = RelativeTransform;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UActorComponent>(AActor.__AddComponent_Internal(base.NativePtr, TemplateName, bManualAttachment, ptr, (ComponentTemplateContext != null) ? ComponentTemplateContext.NativePtr : IntPtr.Zero, bDeferredFinish));
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x00021550 File Offset: 0x0001F750
		public bool ActorHasTag(FName Tag)
		{
			return AActor.__ActorHasTag_Internal(base.NativePtr, Tag);
		}

		// Token: 0x060014FA RID: 5370
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __WasRecentlyRenderedOnScreen_Internal(IntPtr @this, float Tolerance);

		// Token: 0x060014FB RID: 5371
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __WasRecentlyRendered_Internal(IntPtr @this, float Tolerance);

		// Token: 0x060014FC RID: 5372
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __WasRecentlyPassVisibilityTest_Internal(IntPtr @this, float Tolerance);

		// Token: 0x060014FD RID: 5373
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UserConstructionScript_Internal(IntPtr @this);

		// Token: 0x060014FE RID: 5374
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TearOff_Internal(IntPtr @this);

		// Token: 0x060014FF RID: 5375
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SnapRootComponentTo_Internal(IntPtr @this, IntPtr InParentActor, FName InSocketName);

		// Token: 0x06001500 RID: 5376
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTickGroup_Internal(IntPtr @this, TEnumAsByte<ETickingGroup> NewTickGroup);

		// Token: 0x06001501 RID: 5377
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTickableWhenPaused_Internal(IntPtr @this, bool bTickableWhenPaused);

		// Token: 0x06001502 RID: 5378
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetReplicates_Internal(IntPtr @this, bool bInReplicates);

		// Token: 0x06001503 RID: 5379
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetReplicateMovement_Internal(IntPtr @this, bool bInReplicateMovement);

		// Token: 0x06001504 RID: 5380
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPrimitiveEntityType_Internal(IntPtr @this, uint type);

		// Token: 0x06001505 RID: 5381
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPrimitiveBlueprintTypeName_Internal(IntPtr @this, FName Name);

		// Token: 0x06001506 RID: 5382
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOwner_Internal(IntPtr @this, IntPtr NewOwner);

		// Token: 0x06001507 RID: 5383
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLifeSpan_Internal(IntPtr @this, float InLifespan);

		// Token: 0x06001508 RID: 5384
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroOnlyTickOutside_Internal(IntPtr @this, bool OnlyTickOutside);

		// Token: 0x06001509 RID: 5385
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroFadeGroup_Internal(IntPtr @this, int Group);

		// Token: 0x0600150A RID: 5386
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsIgnoreUpdateOverlap_Internal(IntPtr @this, bool bShouldIgnoreUpdateOverlap);

		// Token: 0x0600150B RID: 5387
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetForceHidden_Internal(IntPtr @this, bool bForce);

		// Token: 0x0600150C RID: 5388
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAutoDestroyWhenFinished_Internal(IntPtr @this, bool bVal);

		// Token: 0x0600150D RID: 5389
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetActorViewableInRender_Internal(IntPtr @this, bool bNewViewable);

		// Token: 0x0600150E RID: 5390
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetActorTickInterval_Internal(IntPtr @this, float TickInterval);

		// Token: 0x0600150F RID: 5391
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetActorTickEnabled_Internal(IntPtr @this, bool bEnabled);

		// Token: 0x06001510 RID: 5392
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetActorScale3D_Internal(IntPtr @this, FVector NewScale3D);

		// Token: 0x06001511 RID: 5393
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetActorRelativeScale3D_Internal(IntPtr @this, FVector NewRelativeScale);

		// Token: 0x06001512 RID: 5394
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetActorHiddenInGame_Internal(IntPtr @this, bool bNewHidden);

		// Token: 0x06001513 RID: 5395
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetActorEnableCollision_Internal(IntPtr @this, bool bNewActorEnableCollision);

		// Token: 0x06001514 RID: 5396
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveTickPrerequisiteComponent_Internal(IntPtr @this, IntPtr PrerequisiteComponent);

		// Token: 0x06001515 RID: 5397
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveTickPrerequisiteActor_Internal(IntPtr @this, IntPtr PrerequisiteActor);

		// Token: 0x06001516 RID: 5398
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RefreshKuroFadeGroup_Internal(IntPtr @this);

		// Token: 0x06001517 RID: 5399
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveTick_Internal(IntPtr @this, float DeltaSeconds);

		// Token: 0x06001518 RID: 5400
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveHit_Internal(IntPtr @this, IntPtr MyComp, IntPtr Other, IntPtr OtherComp, bool bSelfMoved, FVector HitLocation, FVector HitNormal, FVector NormalImpulse, IntPtr Hit);

		// Token: 0x06001519 RID: 5401
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveEndPlay_Internal(IntPtr @this, TEnumAsByte<EEndPlayReason> EndPlayReason);

		// Token: 0x0600151A RID: 5402
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveDestroyed_Internal(IntPtr @this);

		// Token: 0x0600151B RID: 5403
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveBeginPlay_Internal(IntPtr @this);

		// Token: 0x0600151C RID: 5404
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveActorOnReleased_Internal(IntPtr @this, IntPtr ButtonReleased);

		// Token: 0x0600151D RID: 5405
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveActorOnInputTouchLeave_Internal(IntPtr @this, TEnumAsByte<ETouchIndex> FingerIndex);

		// Token: 0x0600151E RID: 5406
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveActorOnInputTouchEnter_Internal(IntPtr @this, TEnumAsByte<ETouchIndex> FingerIndex);

		// Token: 0x0600151F RID: 5407
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveActorOnInputTouchEnd_Internal(IntPtr @this, TEnumAsByte<ETouchIndex> FingerIndex);

		// Token: 0x06001520 RID: 5408
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveActorOnInputTouchBegin_Internal(IntPtr @this, TEnumAsByte<ETouchIndex> FingerIndex);

		// Token: 0x06001521 RID: 5409
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveActorOnClicked_Internal(IntPtr @this, IntPtr ButtonPressed);

		// Token: 0x06001522 RID: 5410
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveActorEndOverlap_Internal(IntPtr @this, IntPtr OtherActor);

		// Token: 0x06001523 RID: 5411
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveActorEndCursorOver_Internal(IntPtr @this);

		// Token: 0x06001524 RID: 5412
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveActorBeginOverlap_Internal(IntPtr @this, IntPtr OtherActor);

		// Token: 0x06001525 RID: 5413
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveActorBeginCursorOver_Internal(IntPtr @this);

		// Token: 0x06001526 RID: 5414
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PrestreamTextures_Internal(IntPtr @this, float Seconds, bool bEnableStreaming, int CinematicTextureGroups);

		// Token: 0x06001527 RID: 5415
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_ReplicateMovement_Internal(IntPtr @this);

		// Token: 0x06001528 RID: 5416
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_ReplicatedMovement_Internal(IntPtr @this);

		// Token: 0x06001529 RID: 5417
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_Owner_Internal(IntPtr @this);

		// Token: 0x0600152A RID: 5418
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_Instigator_Internal(IntPtr @this);

		// Token: 0x0600152B RID: 5419
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_AttachmentReplication_Internal(IntPtr @this);

		// Token: 0x0600152C RID: 5420
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MakeNoise_Internal(IntPtr @this, float Loudness, IntPtr NoiseInstigator, FVector NoiseLocation, float MaxRange, FName Tag);

		// Token: 0x0600152D RID: 5421
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeMIDForMaterial_Internal(IntPtr @this, IntPtr Parent);

		// Token: 0x0600152E RID: 5422
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroTickActorOutside_Internal(IntPtr @this, float DeltaSeconds);

		// Token: 0x0600152F RID: 5423
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Kuro_SetRole_Internal(IntPtr @this, TEnumAsByte<EKuroNetRole> InRole);

		// Token: 0x06001530 RID: 5424
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Kuro_OnRep_ReplicatedMovement_Internal(IntPtr @this);

		// Token: 0x06001531 RID: 5425
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<EKuroNetRole> __Kuro_GetLocalRole_Internal(IntPtr @this);

		// Token: 0x06001532 RID: 5426
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_TeleportTo_Internal(IntPtr @this, FVector DestLocation, FRotator DestRotation);

		// Token: 0x06001533 RID: 5427
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_SetDeferedConcurrentUpdateTransform_Internal(IntPtr @this, bool bEnable);

		// Token: 0x06001534 RID: 5428
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_SetActorTransformForce_Internal(IntPtr @this, in FTransform NewTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x06001535 RID: 5429
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_SetActorTransform_Internal(IntPtr @this, in FTransform NewTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x06001536 RID: 5430
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_SetActorRotation_Internal(IntPtr @this, FRotator NewRotation, bool bTeleportPhysics);

		// Token: 0x06001537 RID: 5431
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_SetActorRelativeTransform_Internal(IntPtr @this, in FTransform NewRelativeTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x06001538 RID: 5432
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_SetActorRelativeRotation_Internal(IntPtr @this, FRotator NewRelativeRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x06001539 RID: 5433
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_SetActorRelativeLocation_Internal(IntPtr @this, FVector NewRelativeLocation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x0600153A RID: 5434
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_SetActorLocationAndRotation_Internal(IntPtr @this, FVector NewLocation, FRotator NewRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x0600153B RID: 5435
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_SetActorLocation_Internal(IntPtr @this, FVector NewLocation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x0600153C RID: 5436
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_OnReset_Internal(IntPtr @this);

		// Token: 0x0600153D RID: 5437
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_OnEndViewTarget_Internal(IntPtr @this, IntPtr PC);

		// Token: 0x0600153E RID: 5438
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_OnBecomeViewTarget_Internal(IntPtr @this, IntPtr PC);

		// Token: 0x0600153F RID: 5439
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_KuroTeleportTo_Internal(IntPtr @this, FVector DestLocation, FRotator DestRotation);

		// Token: 0x06001540 RID: 5440
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_KuroSetActorRotation_Internal(IntPtr @this, FRotator NewRotation, bool bSweep, bool bTeleportPhysics, bool bIgnoreOverlap);

		// Token: 0x06001541 RID: 5441
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __K2_GetRootComponent_Internal(IntPtr @this);

		// Token: 0x06001542 RID: 5442
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __K2_GetComponentsByClass_Internal(IntPtr @this, IntPtr ComponentClass);

		// Token: 0x06001543 RID: 5443
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __K2_GetActorRotation_Internal(IntPtr @this);

		// Token: 0x06001544 RID: 5444
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat __K2_GetActorQuaternion_Internal(IntPtr @this);

		// Token: 0x06001545 RID: 5445
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __K2_GetActorLocation_Internal(IntPtr @this);

		// Token: 0x06001546 RID: 5446
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_DetachFromActor_Internal(IntPtr @this, EDetachmentRule LocationRule, EDetachmentRule RotationRule, EDetachmentRule ScaleRule);

		// Token: 0x06001547 RID: 5447
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_DestroyComponent_Internal(IntPtr @this, IntPtr Component);

		// Token: 0x06001548 RID: 5448
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_DestroyActor_Internal(IntPtr @this);

		// Token: 0x06001549 RID: 5449
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_AttachToComponent_Internal(IntPtr @this, IntPtr Parent, FName SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies, bool bCalcWorldOrigin);

		// Token: 0x0600154A RID: 5450
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_AttachToActor_Internal(IntPtr @this, IntPtr ParentActor, FName SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies, bool bCalcWorldOrigin);

		// Token: 0x0600154B RID: 5451
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_AttachRootComponentToActor_Internal(IntPtr @this, IntPtr InParentActor, FName InSocketName, TEnumAsByte<EAttachLocation> AttachLocationType, bool bWeldSimulatedBodies);

		// Token: 0x0600154C RID: 5452
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_AttachRootComponentTo_Internal(IntPtr @this, IntPtr InParent, FName InSocketName, TEnumAsByte<EAttachLocation> AttachLocationType, bool bWeldSimulatedBodies);

		// Token: 0x0600154D RID: 5453
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_AddActorWorldTransformKeepScale_Internal(IntPtr @this, in FTransform DeltaTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x0600154E RID: 5454
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_AddActorWorldTransform_Internal(IntPtr @this, in FTransform DeltaTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x0600154F RID: 5455
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_AddActorWorldRotation_Internal(IntPtr @this, FRotator DeltaRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x06001550 RID: 5456
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_AddActorWorldOffset_Internal(IntPtr @this, FVector DeltaLocation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x06001551 RID: 5457
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_AddActorLocalTransform_Internal(IntPtr @this, in FTransform NewTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x06001552 RID: 5458
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_AddActorLocalRotation_Internal(IntPtr @this, FRotator DeltaRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x06001553 RID: 5459
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_AddActorLocalOffset_Internal(IntPtr @this, FVector DeltaLocation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x06001554 RID: 5460
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsUEOrignal_Internal(IntPtr @this);

		// Token: 0x06001555 RID: 5461
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsOverlappingActor_Internal(IntPtr @this, IntPtr Other);

		// Token: 0x06001556 RID: 5462
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsIgnoreUpdateOverlap_Internal(IntPtr @this);

		// Token: 0x06001557 RID: 5463
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsChildActor_Internal(IntPtr @this);

		// Token: 0x06001558 RID: 5464
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsAutonomousProxy_Internal(IntPtr @this);

		// Token: 0x06001559 RID: 5465
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsActorTickEnabled_Internal(IntPtr @this);

		// Token: 0x0600155A RID: 5466
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsActorBeingDestroyed_Internal(IntPtr @this);

		// Token: 0x0600155B RID: 5467
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __IgnoreActorWhenMoving_Internal(IntPtr @this, IntPtr Actor, bool bShouldIgnore, bool bBoth);

		// Token: 0x0600155C RID: 5468
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasKuroFadeGroupOverride_Internal(IntPtr @this);

		// Token: 0x0600155D RID: 5469
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasAuthority_Internal(IntPtr @this);

		// Token: 0x0600155E RID: 5470
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetVerticalDistanceTo_Internal(IntPtr @this, IntPtr OtherActor);

		// Token: 0x0600155F RID: 5471
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetVelocity_Internal(IntPtr @this);

		// Token: 0x06001560 RID: 5472
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetTransformWithUpdate_Internal(IntPtr @this);

		// Token: 0x06001561 RID: 5473
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetTransform_Internal(IntPtr @this);

		// Token: 0x06001562 RID: 5474
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetTickableWhenPaused_Internal(IntPtr @this);

		// Token: 0x06001563 RID: 5475
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetSquaredHorizontalDistanceTo_Internal(IntPtr @this, IntPtr OtherActor);

		// Token: 0x06001564 RID: 5476
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetSquaredDistanceTo_Internal(IntPtr @this, IntPtr OtherActor);

		// Token: 0x06001565 RID: 5477
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern uint __GetPrimitiveEntityType_Internal(IntPtr @this);

		// Token: 0x06001566 RID: 5478
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetPrimitiveBlueprintTypeName_Internal(IntPtr @this);

		// Token: 0x06001567 RID: 5479
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetParentComponent_Internal(IntPtr @this);

		// Token: 0x06001568 RID: 5480
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetParentActor_Internal(IntPtr @this);

		// Token: 0x06001569 RID: 5481
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetOwner_Internal(IntPtr @this);

		// Token: 0x0600156A RID: 5482
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetOverlappingComponents_Internal(IntPtr @this, IntPtr OverlappingComponents);

		// Token: 0x0600156B RID: 5483
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetOverlappingActors_Internal(IntPtr @this, IntPtr OverlappingActors, IntPtr ClassFilter);

		// Token: 0x0600156C RID: 5484
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetLifeSpan_Internal(IntPtr @this);

		// Token: 0x0600156D RID: 5485
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetLevelTransform_Internal(IntPtr @this);

		// Token: 0x0600156E RID: 5486
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLevel_Internal(IntPtr @this);

		// Token: 0x0600156F RID: 5487
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetKuroFadeGroup_Internal(IntPtr @this);

		// Token: 0x06001570 RID: 5488
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetInverseTransform_Internal(IntPtr @this);

		// Token: 0x06001571 RID: 5489
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetInstigatorController_Internal(IntPtr @this);

		// Token: 0x06001572 RID: 5490
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetInstigator_Internal(IntPtr @this);

		// Token: 0x06001573 RID: 5491
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetInputVectorAxisValue_Internal(IntPtr @this, IntPtr InputAxisKey);

		// Token: 0x06001574 RID: 5492
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetInputAxisValue_Internal(IntPtr @this, FName InputAxisName);

		// Token: 0x06001575 RID: 5493
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetInputAxisKeyValue_Internal(IntPtr @this, IntPtr InputAxisKey);

		// Token: 0x06001576 RID: 5494
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetHorizontalDotProductTo_Internal(IntPtr @this, IntPtr OtherActor);

		// Token: 0x06001577 RID: 5495
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetHorizontalDistanceTo_Internal(IntPtr @this, IntPtr OtherActor);

		// Token: 0x06001578 RID: 5496
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetGameTimeSinceCreation_Internal(IntPtr @this);

		// Token: 0x06001579 RID: 5497
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetDotProductTo_Internal(IntPtr @this, IntPtr OtherActor);

		// Token: 0x0600157A RID: 5498
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetDistanceTo_Internal(IntPtr @this, IntPtr OtherActor);

		// Token: 0x0600157B RID: 5499
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetComponentsByTag_Internal(IntPtr @this, IntPtr ComponentClass, FName Tag);

		// Token: 0x0600157C RID: 5500
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetComponentsByInterface_Internal(IntPtr @this, IntPtr Interface);

		// Token: 0x0600157D RID: 5501
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetComponentByClass_Internal(IntPtr @this, IntPtr ComponentClass);

		// Token: 0x0600157E RID: 5502
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAttachRootParentActor_Internal(IntPtr @this);

		// Token: 0x0600157F RID: 5503
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetAttachParentSocketName_Internal(IntPtr @this);

		// Token: 0x06001580 RID: 5504
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAttachParentActor_Internal(IntPtr @this);

		// Token: 0x06001581 RID: 5505
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAttachedActors_Internal(IntPtr @this, IntPtr OutActors, bool bResetArray);

		// Token: 0x06001582 RID: 5506
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAttachedActorDescendants_Internal(IntPtr @this, IntPtr OutActors, bool bResetArray);

		// Token: 0x06001583 RID: 5507
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAllChildActors_Internal(IntPtr @this, IntPtr ChildActors, bool bIncludeDescendants);

		// Token: 0x06001584 RID: 5508
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetActorUpVector_Internal(IntPtr @this);

		// Token: 0x06001585 RID: 5509
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetActorTimeDilation_Internal(IntPtr @this);

		// Token: 0x06001586 RID: 5510
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetActorTickInterval_Internal(IntPtr @this);

		// Token: 0x06001587 RID: 5511
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetActorScale3D_Internal(IntPtr @this);

		// Token: 0x06001588 RID: 5512
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetActorRightVector_Internal(IntPtr @this);

		// Token: 0x06001589 RID: 5513
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetActorRelativeScale3D_Internal(IntPtr @this);

		// Token: 0x0600158A RID: 5514
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetActorForwardVector_Internal(IntPtr @this);

		// Token: 0x0600158B RID: 5515
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetActorEyesViewPoint_Internal(IntPtr @this, ref FVector OutLocation, ref FRotator OutRotation, int CameraIndex);

		// Token: 0x0600158C RID: 5516
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetActorEnableCollision_Internal(IntPtr @this);

		// Token: 0x0600158D RID: 5517
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetActorBounds_Internal(IntPtr @this, bool bOnlyCollidingComponents, ref FVector Origin, ref FVector BoxExtent, bool bIncludeFromChildActors);

		// Token: 0x0600158E RID: 5518
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ForceNetUpdate_Internal(IntPtr @this);

		// Token: 0x0600158F RID: 5519
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FlushNetDormancy_Internal(IntPtr @this);

		// Token: 0x06001590 RID: 5520
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FinishAddComponent_Internal(IntPtr @this, IntPtr Component, bool bManualAttachment, in FTransform RelativeTransform);

		// Token: 0x06001591 RID: 5521
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EnableInput_Internal(IntPtr @this, IntPtr PlayerController);

		// Token: 0x06001592 RID: 5522
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DisableInput_Internal(IntPtr @this, IntPtr PlayerController);

		// Token: 0x06001593 RID: 5523
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DetachRootComponentFromParent_Internal(IntPtr @this, bool bMaintainWorldPosition);

		// Token: 0x06001594 RID: 5524
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_SetActorScale3D_Internal(IntPtr @this, FVectorDouble NewScale3D);

		// Token: 0x06001595 RID: 5525
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_K2_TeleportTo_Internal(IntPtr @this, FVectorDouble DestLocation, FRotator DestRotation);

		// Token: 0x06001596 RID: 5526
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_K2_SetActorTransformForce_Internal(IntPtr @this, in FTransformDouble NewTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x06001597 RID: 5527
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_K2_SetActorTransform_Internal(IntPtr @this, in FTransformDouble NewTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x06001598 RID: 5528
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_K2_SetActorRelativeTransform_Internal(IntPtr @this, in FTransformDouble NewRelativeTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x06001599 RID: 5529
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_K2_SetActorRelativeLocation_Internal(IntPtr @this, FVectorDouble NewRelativeLocation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x0600159A RID: 5530
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_K2_SetActorLocationAndRotation_Internal(IntPtr @this, FVectorDouble NewLocation, FRotator NewRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x0600159B RID: 5531
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_K2_SetActorLocation_Internal(IntPtr @this, FVectorDouble NewLocation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x0600159C RID: 5532
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_K2_KuroTeleportTo_Internal(IntPtr @this, FVectorDouble DestLocation, FRotator DestRotation);

		// Token: 0x0600159D RID: 5533
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_K2_GetActorLocation_Internal(IntPtr @this);

		// Token: 0x0600159E RID: 5534
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_K2_AddActorWorldTransform_Internal(IntPtr @this, in FTransformDouble DeltaTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x0600159F RID: 5535
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_K2_AddActorWorldOffset_Internal(IntPtr @this, FVectorDouble DeltaLocation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060015A0 RID: 5536
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_K2_AddActorLocalTransform_Internal(IntPtr @this, in FTransformDouble NewTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060015A1 RID: 5537
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_K2_AddActorLocalOffset_Internal(IntPtr @this, FVectorDouble DeltaLocation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060015A2 RID: 5538
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetVelocity_Internal(IntPtr @this);

		// Token: 0x060015A3 RID: 5539
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble __D_GetTransformWithUpdate_Internal(IntPtr @this);

		// Token: 0x060015A4 RID: 5540
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble __D_GetTransform_Internal(IntPtr @this);

		// Token: 0x060015A5 RID: 5541
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble __D_GetInverseTransform_Internal(IntPtr @this);

		// Token: 0x060015A6 RID: 5542
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double __D_GetGameTimeSinceCreation_Internal(IntPtr @this);

		// Token: 0x060015A7 RID: 5543
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double __D_GetDistanceTo_Internal(IntPtr @this, IntPtr OtherActor);

		// Token: 0x060015A8 RID: 5544
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetActorUpVector_Internal(IntPtr @this);

		// Token: 0x060015A9 RID: 5545
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetActorScale3D_Internal(IntPtr @this);

		// Token: 0x060015AA RID: 5546
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetActorRightVector_Internal(IntPtr @this);

		// Token: 0x060015AB RID: 5547
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetActorForwardVector_Internal(IntPtr @this);

		// Token: 0x060015AC RID: 5548
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_GetActorBounds_Internal(IntPtr @this, bool bOnlyCollidingComponents, ref FVectorDouble Origin, ref FVector BoxExtent, bool bIncludeFromChildActors);

		// Token: 0x060015AD RID: 5549
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __D_AddComponentByClass_Internal(IntPtr @this, IntPtr Class, bool bManualAttachment, in FTransformDouble RelativeTransform, bool bDeferredFinish, FName ComponentName);

		// Token: 0x060015AE RID: 5550
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearMoveIgnoreActors_Internal(IntPtr @this, bool bClearBoth);

		// Token: 0x060015AF RID: 5551
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearKuroFadeGroupOverride_Internal(IntPtr @this);

		// Token: 0x060015B0 RID: 5552
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddTickPrerequisiteComponent_Internal(IntPtr @this, IntPtr PrerequisiteComponent);

		// Token: 0x060015B1 RID: 5553
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddTickPrerequisiteActor_Internal(IntPtr @this, IntPtr PrerequisiteActor);

		// Token: 0x060015B2 RID: 5554
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddComponentByClass_Internal(IntPtr @this, IntPtr Class, bool bManualAttachment, in FTransform RelativeTransform, bool bDeferredFinish, FName ComponentName);

		// Token: 0x060015B3 RID: 5555
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddComponent_Internal(IntPtr @this, FName TemplateName, bool bManualAttachment, in FTransform RelativeTransform, IntPtr ComponentTemplateContext, bool bDeferredFinish);

		// Token: 0x060015B4 RID: 5556
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ActorHasTag_Internal(IntPtr @this, FName Tag);

		// Token: 0x060015B5 RID: 5557 RVA: 0x0002155E File Offset: 0x0001F75E
		static AActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Actor");
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x0002156C File Offset: 0x0001F76C
		protected AActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400065B RID: 1627
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.Actor";

		// Token: 0x0400065C RID: 1628
		private static IntPtr _ClassPtr;

		// Token: 0x0400065D RID: 1629
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400065E RID: 1630
		internal static int __PropertyOffset_PrimaryActorTick;

		// Token: 0x0400065F RID: 1631
		private FActorTickFunction _PrimaryActorTick;

		// Token: 0x04000660 RID: 1632
		internal static int __PropertyOffset_bNetTemporary;

		// Token: 0x04000661 RID: 1633
		internal static byte __PropertyMask_bNetTemporary;

		// Token: 0x04000662 RID: 1634
		internal static int __PropertyOffset_bNetStartup;

		// Token: 0x04000663 RID: 1635
		internal static byte __PropertyMask_bNetStartup;

		// Token: 0x04000664 RID: 1636
		internal static int __PropertyOffset_bOnlyRelevantToOwner;

		// Token: 0x04000665 RID: 1637
		internal static byte __PropertyMask_bOnlyRelevantToOwner;

		// Token: 0x04000666 RID: 1638
		internal static int __PropertyOffset_bAlwaysRelevant;

		// Token: 0x04000667 RID: 1639
		internal static byte __PropertyMask_bAlwaysRelevant;

		// Token: 0x04000668 RID: 1640
		internal static int __PropertyOffset_bReplicateMovement;

		// Token: 0x04000669 RID: 1641
		internal static byte __PropertyMask_bReplicateMovement;

		// Token: 0x0400066A RID: 1642
		internal static int __PropertyOffset_bHidden;

		// Token: 0x0400066B RID: 1643
		internal static byte __PropertyMask_bHidden;

		// Token: 0x0400066C RID: 1644
		internal static int __PropertyOffset_bViewableInRender;

		// Token: 0x0400066D RID: 1645
		internal static byte __PropertyMask_bViewableInRender;

		// Token: 0x0400066E RID: 1646
		internal static int __PropertyOffset_bTearOff;

		// Token: 0x0400066F RID: 1647
		internal static byte __PropertyMask_bTearOff;

		// Token: 0x04000670 RID: 1648
		internal static int __PropertyOffset_bForceHidden;

		// Token: 0x04000671 RID: 1649
		internal static byte __PropertyMask_bForceHidden;

		// Token: 0x04000672 RID: 1650
		internal static int __PropertyOffset_bIsAliveSpawnableAfterSequenceClean;

		// Token: 0x04000673 RID: 1651
		internal static int __PropertyOffset_bExchangedRoles;

		// Token: 0x04000674 RID: 1652
		internal static byte __PropertyMask_bExchangedRoles;

		// Token: 0x04000675 RID: 1653
		internal static int __PropertyOffset_bNetLoadOnClient;

		// Token: 0x04000676 RID: 1654
		internal static byte __PropertyMask_bNetLoadOnClient;

		// Token: 0x04000677 RID: 1655
		internal static int __PropertyOffset_bNetUseOwnerRelevancy;

		// Token: 0x04000678 RID: 1656
		internal static byte __PropertyMask_bNetUseOwnerRelevancy;

		// Token: 0x04000679 RID: 1657
		internal static int __PropertyOffset_bRelevantForNetworkReplays;

		// Token: 0x0400067A RID: 1658
		internal static byte __PropertyMask_bRelevantForNetworkReplays;

		// Token: 0x0400067B RID: 1659
		internal static int __PropertyOffset_bRelevantForLevelBounds;

		// Token: 0x0400067C RID: 1660
		internal static byte __PropertyMask_bRelevantForLevelBounds;

		// Token: 0x0400067D RID: 1661
		internal static int __PropertyOffset_bReplayRewindable;

		// Token: 0x0400067E RID: 1662
		internal static byte __PropertyMask_bReplayRewindable;

		// Token: 0x0400067F RID: 1663
		internal static int __PropertyOffset_bAllowTickBeforeBeginPlay;

		// Token: 0x04000680 RID: 1664
		internal static byte __PropertyMask_bAllowTickBeforeBeginPlay;

		// Token: 0x04000681 RID: 1665
		internal static int __PropertyOffset_bAutoDestroyWhenFinished;

		// Token: 0x04000682 RID: 1666
		internal static byte __PropertyMask_bAutoDestroyWhenFinished;

		// Token: 0x04000683 RID: 1667
		internal static int __PropertyOffset_bCanBeDamaged;

		// Token: 0x04000684 RID: 1668
		internal static byte __PropertyMask_bCanBeDamaged;

		// Token: 0x04000685 RID: 1669
		internal static int __PropertyOffset_bBlockInput;

		// Token: 0x04000686 RID: 1670
		internal static byte __PropertyMask_bBlockInput;

		// Token: 0x04000687 RID: 1671
		internal static int __PropertyOffset_bCollideWhenPlacing;

		// Token: 0x04000688 RID: 1672
		internal static byte __PropertyMask_bCollideWhenPlacing;

		// Token: 0x04000689 RID: 1673
		internal static int __PropertyOffset_bFindCameraComponentWhenViewTarget;

		// Token: 0x0400068A RID: 1674
		internal static byte __PropertyMask_bFindCameraComponentWhenViewTarget;

		// Token: 0x0400068B RID: 1675
		internal static int __PropertyOffset_bGenerateOverlapEventsDuringLevelStreaming;

		// Token: 0x0400068C RID: 1676
		internal static byte __PropertyMask_bGenerateOverlapEventsDuringLevelStreaming;

		// Token: 0x0400068D RID: 1677
		internal static int __PropertyOffset_bIgnoresOriginShifting;

		// Token: 0x0400068E RID: 1678
		internal static byte __PropertyMask_bIgnoresOriginShifting;

		// Token: 0x0400068F RID: 1679
		internal static int __PropertyOffset_bEnableAutoLODGeneration;

		// Token: 0x04000690 RID: 1680
		internal static byte __PropertyMask_bEnableAutoLODGeneration;

		// Token: 0x04000691 RID: 1681
		internal static int __PropertyOffset_bIsEditorOnlyActor;

		// Token: 0x04000692 RID: 1682
		internal static byte __PropertyMask_bIsEditorOnlyActor;

		// Token: 0x04000693 RID: 1683
		internal static int __PropertyOffset_bPlatformMobile;

		// Token: 0x04000694 RID: 1684
		internal static byte __PropertyMask_bPlatformMobile;

		// Token: 0x04000695 RID: 1685
		internal static int __PropertyOffset_bPlatformDeskTop;

		// Token: 0x04000696 RID: 1686
		internal static byte __PropertyMask_bPlatformDeskTop;

		// Token: 0x04000697 RID: 1687
		internal static int __PropertyOffset_bPlatformMac;

		// Token: 0x04000698 RID: 1688
		internal static byte __PropertyMask_bPlatformMac;

		// Token: 0x04000699 RID: 1689
		internal static int __PropertyOffset_bInvolveCook;

		// Token: 0x0400069A RID: 1690
		internal static byte __PropertyMask_bInvolveCook;

		// Token: 0x0400069B RID: 1691
		internal static int __PropertyOffset_bActorSeamlessTraveled;

		// Token: 0x0400069C RID: 1692
		internal static byte __PropertyMask_bActorSeamlessTraveled;

		// Token: 0x0400069D RID: 1693
		internal static int __PropertyOffset_bIsPermanentActor;

		// Token: 0x0400069E RID: 1694
		internal static byte __PropertyMask_bIsPermanentActor;

		// Token: 0x0400069F RID: 1695
		internal static int __PropertyOffset_bEnableBeginAndEndPlayDebugLog;

		// Token: 0x040006A0 RID: 1696
		internal static byte __PropertyMask_bEnableBeginAndEndPlayDebugLog;

		// Token: 0x040006A1 RID: 1697
		internal static int __PropertyOffset_bKuroHiddenDebugLog;

		// Token: 0x040006A2 RID: 1698
		internal static byte __PropertyMask_bKuroHiddenDebugLog;

		// Token: 0x040006A3 RID: 1699
		internal static int __PropertyOffset_bSpawnInUIScene;

		// Token: 0x040006A4 RID: 1700
		internal static byte __PropertyMask_bSpawnInUIScene;

		// Token: 0x040006A5 RID: 1701
		internal static int __PropertyOffset_bReplicates;

		// Token: 0x040006A6 RID: 1702
		internal static byte __PropertyMask_bReplicates;

		// Token: 0x040006A7 RID: 1703
		internal static int __PropertyOffset_bCanBeInCluster;

		// Token: 0x040006A8 RID: 1704
		internal static byte __PropertyMask_bCanBeInCluster;

		// Token: 0x040006A9 RID: 1705
		internal static int __PropertyOffset_bAllowReceiveTickEventOnDedicatedServer;

		// Token: 0x040006AA RID: 1706
		internal static byte __PropertyMask_bAllowReceiveTickEventOnDedicatedServer;

		// Token: 0x040006AB RID: 1707
		internal static int __PropertyOffset_bActorEnableCollision;

		// Token: 0x040006AC RID: 1708
		internal static byte __PropertyMask_bActorEnableCollision;

		// Token: 0x040006AD RID: 1709
		internal static int __PropertyOffset_bActorIsBeingDestroyed;

		// Token: 0x040006AE RID: 1710
		internal static byte __PropertyMask_bActorIsBeingDestroyed;

		// Token: 0x040006AF RID: 1711
		internal static int __PropertyOffset_InitialLifeSpan;

		// Token: 0x040006B0 RID: 1712
		internal static int __PropertyOffset_CustomTimeDilation;

		// Token: 0x040006B1 RID: 1713
		internal static int __PropertyOffset_Owner;

		// Token: 0x040006B2 RID: 1714
		internal static int __PropertyOffset_NetDriverName;

		// Token: 0x040006B3 RID: 1715
		internal static int __PropertyOffset_BlueprintTypeName;

		// Token: 0x040006B4 RID: 1716
		internal static int __PropertyOffset_KuroEntityType;

		// Token: 0x040006B5 RID: 1717
		internal static int __PropertyOffset_RuntimeGrid;

		// Token: 0x040006B6 RID: 1718
		internal static int __PropertyOffset_SpawnCollisionHandlingMethod;

		// Token: 0x040006B7 RID: 1719
		internal static int __PropertyOffset_InputPriority;

		// Token: 0x040006B8 RID: 1720
		internal static int __PropertyOffset_NetCullDistanceSquared;

		// Token: 0x040006B9 RID: 1721
		internal static int __PropertyOffset_NetTag;

		// Token: 0x040006BA RID: 1722
		internal static int __PropertyOffset_NetUpdateFrequency;

		// Token: 0x040006BB RID: 1723
		internal static int __PropertyOffset_MinNetUpdateFrequency;

		// Token: 0x040006BC RID: 1724
		internal static int __PropertyOffset_NetPriority;

		// Token: 0x040006BD RID: 1725
		internal static int __PropertyOffset_Instigator;

		// Token: 0x040006BE RID: 1726
		internal static int __PropertyOffset_Children;

		// Token: 0x040006BF RID: 1727
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _Children;

		// Token: 0x040006C0 RID: 1728
		internal static int __PropertyOffset_RootComponent;

		// Token: 0x040006C1 RID: 1729
		internal static int __PropertyOffset_Layers;

		// Token: 0x040006C2 RID: 1730
		private TArray<FName> _Layers;

		// Token: 0x040006C3 RID: 1731
		internal static int __PropertyOffset_ParentComponent;

		// Token: 0x040006C4 RID: 1732
		internal static int __PropertyOffset_Tags;

		// Token: 0x040006C5 RID: 1733
		private TArray<FName> _Tags;

		// Token: 0x040006C6 RID: 1734
		internal static int __PropertyOffset_OnActorBeginOverlap;

		// Token: 0x040006C7 RID: 1735
		private FActorBeginOverlapSignature _OnActorBeginOverlap;

		// Token: 0x040006C8 RID: 1736
		internal static int __PropertyOffset_OnActorEndOverlap;

		// Token: 0x040006C9 RID: 1737
		private FActorEndOverlapSignature _OnActorEndOverlap;

		// Token: 0x040006CA RID: 1738
		internal static int __PropertyOffset_OnBeginCursorOver;

		// Token: 0x040006CB RID: 1739
		private FActorBeginCursorOverSignature _OnBeginCursorOver;

		// Token: 0x040006CC RID: 1740
		internal static int __PropertyOffset_OnEndCursorOver;

		// Token: 0x040006CD RID: 1741
		private FActorEndCursorOverSignature _OnEndCursorOver;

		// Token: 0x040006CE RID: 1742
		internal static int __PropertyOffset_OnClicked;

		// Token: 0x040006CF RID: 1743
		private FActorOnClickedSignature _OnClicked;

		// Token: 0x040006D0 RID: 1744
		internal static int __PropertyOffset_OnReleased;

		// Token: 0x040006D1 RID: 1745
		private FActorOnReleasedSignature _OnReleased;

		// Token: 0x040006D2 RID: 1746
		internal static int __PropertyOffset_OnInputTouchBegin;

		// Token: 0x040006D3 RID: 1747
		private FActorOnInputTouchBeginSignature _OnInputTouchBegin;

		// Token: 0x040006D4 RID: 1748
		internal static int __PropertyOffset_OnInputTouchEnd;

		// Token: 0x040006D5 RID: 1749
		private FActorOnInputTouchEndSignature _OnInputTouchEnd;

		// Token: 0x040006D6 RID: 1750
		internal static int __PropertyOffset_OnInputTouchEnter;

		// Token: 0x040006D7 RID: 1751
		private FActorBeginTouchOverSignature _OnInputTouchEnter;

		// Token: 0x040006D8 RID: 1752
		internal static int __PropertyOffset_OnInputTouchLeave;

		// Token: 0x040006D9 RID: 1753
		private FActorEndTouchOverSignature _OnInputTouchLeave;

		// Token: 0x040006DA RID: 1754
		internal static int __PropertyOffset_OnActorHit;

		// Token: 0x040006DB RID: 1755
		private FActorHitSignature _OnActorHit;

		// Token: 0x040006DC RID: 1756
		internal static int __PropertyOffset_OnDestroyed;

		// Token: 0x040006DD RID: 1757
		private FActorDestroyedSignature _OnDestroyed;

		// Token: 0x040006DE RID: 1758
		internal static int __PropertyOffset_OnEndPlay;

		// Token: 0x040006DF RID: 1759
		private FActorEndPlaySignature _OnEndPlay;

		// Token: 0x040006E0 RID: 1760
		internal static int __PropertyOffset_InstanceComponents;

		// Token: 0x040006E1 RID: 1761
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UActorComponent> _InstanceComponents;

		// Token: 0x040006E2 RID: 1762
		internal static int __PropertyOffset_BlueprintCreatedComponents;

		// Token: 0x040006E3 RID: 1763
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UActorComponent> _BlueprintCreatedComponents;

		// Token: 0x040006E4 RID: 1764
		internal static int __PropertyOffset_MoveIgnoreActors;

		// Token: 0x040006E5 RID: 1765
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _MoveIgnoreActors;

		// Token: 0x02000937 RID: 2359
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0400584F RID: 22607
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02000938 RID: 2360
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 216)]
		protected ref struct __ReceiveHit_FunctionParams
		{
			// Token: 0x04005850 RID: 22608
			[FieldOffset(0)]
			public IntPtr MyComp;

			// Token: 0x04005851 RID: 22609
			[FieldOffset(8)]
			public IntPtr Other;

			// Token: 0x04005852 RID: 22610
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04005853 RID: 22611
			[FieldOffset(24)]
			public bool bSelfMoved;

			// Token: 0x04005854 RID: 22612
			[FieldOffset(28)]
			public FVector HitLocation;

			// Token: 0x04005855 RID: 22613
			[FieldOffset(40)]
			public FVector HitNormal;

			// Token: 0x04005856 RID: 22614
			[FieldOffset(52)]
			public FVector NormalImpulse;

			// Token: 0x04005857 RID: 22615
			[FieldOffset(64)]
			public byte Hit;
		}

		// Token: 0x02000939 RID: 2361
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x04005858 RID: 22616
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}

		// Token: 0x0200093A RID: 2362
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __ReceiveActorOnReleased_FunctionParams
		{
			// Token: 0x04005859 RID: 22617
			[FieldOffset(0)]
			public byte ButtonReleased;
		}

		// Token: 0x0200093B RID: 2363
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ReceiveActorOnInputTouchLeave_FunctionParams
		{
			// Token: 0x0400585A RID: 22618
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> FingerIndex;
		}

		// Token: 0x0200093C RID: 2364
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ReceiveActorOnInputTouchEnter_FunctionParams
		{
			// Token: 0x0400585B RID: 22619
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> FingerIndex;
		}

		// Token: 0x0200093D RID: 2365
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ReceiveActorOnInputTouchEnd_FunctionParams
		{
			// Token: 0x0400585C RID: 22620
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> FingerIndex;
		}

		// Token: 0x0200093E RID: 2366
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ReceiveActorOnInputTouchBegin_FunctionParams
		{
			// Token: 0x0400585D RID: 22621
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> FingerIndex;
		}

		// Token: 0x0200093F RID: 2367
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __ReceiveActorOnClicked_FunctionParams
		{
			// Token: 0x0400585E RID: 22622
			[FieldOffset(0)]
			public byte ButtonPressed;
		}

		// Token: 0x02000940 RID: 2368
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ReceiveActorEndOverlap_FunctionParams
		{
			// Token: 0x0400585F RID: 22623
			[FieldOffset(0)]
			public IntPtr OtherActor;
		}

		// Token: 0x02000941 RID: 2369
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ReceiveActorBeginOverlap_FunctionParams
		{
			// Token: 0x04005860 RID: 22624
			[FieldOffset(0)]
			public IntPtr OtherActor;
		}

		// Token: 0x02000942 RID: 2370
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __K2_OnEndViewTarget_FunctionParams
		{
			// Token: 0x04005861 RID: 22625
			[FieldOffset(0)]
			public IntPtr PC;
		}

		// Token: 0x02000943 RID: 2371
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __K2_OnBecomeViewTarget_FunctionParams
		{
			// Token: 0x04005862 RID: 22626
			[FieldOffset(0)]
			public IntPtr PC;
		}
	}
}
