using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007A6 RID: 1958
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.Actor")]
	[UnrealStructLayout(1040, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1040)]
	public class AActor : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006607 RID: 26119 RVA: 0x00092394 File Offset: 0x00090594
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AActor._ClassPtr;
		}

		// Token: 0x06006608 RID: 26120 RVA: 0x000923A0 File Offset: 0x000905A0
		public AActor() : this(BuiltinUtils.AllocNativeUObject(AActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006609 RID: 26121 RVA: 0x000923C8 File Offset: 0x000905C8
		[NullableContext(1)]
		public AActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001844 RID: 6212
		// (get) Token: 0x0600660A RID: 26122 RVA: 0x000923FC File Offset: 0x000905FC
		// (set) Token: 0x0600660B RID: 26123 RVA: 0x00092435 File Offset: 0x00090635
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

		// Token: 0x17001845 RID: 6213
		// (get) Token: 0x0600660C RID: 26124 RVA: 0x00092456 File Offset: 0x00090656
		// (set) Token: 0x0600660D RID: 26125 RVA: 0x0009246F File Offset: 0x0009066F
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

		// Token: 0x17001846 RID: 6214
		// (get) Token: 0x0600660E RID: 26126 RVA: 0x0009249F File Offset: 0x0009069F
		// (set) Token: 0x0600660F RID: 26127 RVA: 0x000924B8 File Offset: 0x000906B8
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

		// Token: 0x17001847 RID: 6215
		// (get) Token: 0x06006610 RID: 26128 RVA: 0x000924E8 File Offset: 0x000906E8
		// (set) Token: 0x06006611 RID: 26129 RVA: 0x00092501 File Offset: 0x00090701
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

		// Token: 0x17001848 RID: 6216
		// (get) Token: 0x06006612 RID: 26130 RVA: 0x00092531 File Offset: 0x00090731
		// (set) Token: 0x06006613 RID: 26131 RVA: 0x0009254A File Offset: 0x0009074A
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

		// Token: 0x17001849 RID: 6217
		// (get) Token: 0x06006614 RID: 26132 RVA: 0x0009257A File Offset: 0x0009077A
		// (set) Token: 0x06006615 RID: 26133 RVA: 0x00092593 File Offset: 0x00090793
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

		// Token: 0x1700184A RID: 6218
		// (get) Token: 0x06006616 RID: 26134 RVA: 0x000925C3 File Offset: 0x000907C3
		// (set) Token: 0x06006617 RID: 26135 RVA: 0x000925DC File Offset: 0x000907DC
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

		// Token: 0x1700184B RID: 6219
		// (get) Token: 0x06006618 RID: 26136 RVA: 0x0009260C File Offset: 0x0009080C
		// (set) Token: 0x06006619 RID: 26137 RVA: 0x00092625 File Offset: 0x00090825
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

		// Token: 0x1700184C RID: 6220
		// (get) Token: 0x0600661A RID: 26138 RVA: 0x00092655 File Offset: 0x00090855
		// (set) Token: 0x0600661B RID: 26139 RVA: 0x0009266E File Offset: 0x0009086E
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

		// Token: 0x1700184D RID: 6221
		// (get) Token: 0x0600661C RID: 26140 RVA: 0x0009269E File Offset: 0x0009089E
		// (set) Token: 0x0600661D RID: 26141 RVA: 0x000926B7 File Offset: 0x000908B7
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

		// Token: 0x1700184E RID: 6222
		// (get) Token: 0x0600661E RID: 26142 RVA: 0x000926E7 File Offset: 0x000908E7
		// (set) Token: 0x0600661F RID: 26143 RVA: 0x000926F7 File Offset: 0x000908F7
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

		// Token: 0x1700184F RID: 6223
		// (get) Token: 0x06006620 RID: 26144 RVA: 0x00092708 File Offset: 0x00090908
		// (set) Token: 0x06006621 RID: 26145 RVA: 0x00092721 File Offset: 0x00090921
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

		// Token: 0x17001850 RID: 6224
		// (get) Token: 0x06006622 RID: 26146 RVA: 0x00092751 File Offset: 0x00090951
		// (set) Token: 0x06006623 RID: 26147 RVA: 0x0009276A File Offset: 0x0009096A
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

		// Token: 0x17001851 RID: 6225
		// (get) Token: 0x06006624 RID: 26148 RVA: 0x0009279A File Offset: 0x0009099A
		// (set) Token: 0x06006625 RID: 26149 RVA: 0x000927B3 File Offset: 0x000909B3
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

		// Token: 0x17001852 RID: 6226
		// (get) Token: 0x06006626 RID: 26150 RVA: 0x000927E3 File Offset: 0x000909E3
		// (set) Token: 0x06006627 RID: 26151 RVA: 0x000927FC File Offset: 0x000909FC
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

		// Token: 0x17001853 RID: 6227
		// (get) Token: 0x06006628 RID: 26152 RVA: 0x0009282C File Offset: 0x00090A2C
		// (set) Token: 0x06006629 RID: 26153 RVA: 0x00092845 File Offset: 0x00090A45
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

		// Token: 0x17001854 RID: 6228
		// (get) Token: 0x0600662A RID: 26154 RVA: 0x00092875 File Offset: 0x00090A75
		// (set) Token: 0x0600662B RID: 26155 RVA: 0x0009288E File Offset: 0x00090A8E
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

		// Token: 0x17001855 RID: 6229
		// (get) Token: 0x0600662C RID: 26156 RVA: 0x000928BE File Offset: 0x00090ABE
		// (set) Token: 0x0600662D RID: 26157 RVA: 0x000928D7 File Offset: 0x00090AD7
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

		// Token: 0x17001856 RID: 6230
		// (get) Token: 0x0600662E RID: 26158 RVA: 0x00092907 File Offset: 0x00090B07
		// (set) Token: 0x0600662F RID: 26159 RVA: 0x00092920 File Offset: 0x00090B20
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

		// Token: 0x17001857 RID: 6231
		// (get) Token: 0x06006630 RID: 26160 RVA: 0x00092950 File Offset: 0x00090B50
		// (set) Token: 0x06006631 RID: 26161 RVA: 0x00092969 File Offset: 0x00090B69
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

		// Token: 0x17001858 RID: 6232
		// (get) Token: 0x06006632 RID: 26162 RVA: 0x00092999 File Offset: 0x00090B99
		// (set) Token: 0x06006633 RID: 26163 RVA: 0x000929B2 File Offset: 0x00090BB2
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

		// Token: 0x17001859 RID: 6233
		// (get) Token: 0x06006634 RID: 26164 RVA: 0x000929E2 File Offset: 0x00090BE2
		// (set) Token: 0x06006635 RID: 26165 RVA: 0x000929FB File Offset: 0x00090BFB
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

		// Token: 0x1700185A RID: 6234
		// (get) Token: 0x06006636 RID: 26166 RVA: 0x00092A2B File Offset: 0x00090C2B
		// (set) Token: 0x06006637 RID: 26167 RVA: 0x00092A44 File Offset: 0x00090C44
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

		// Token: 0x1700185B RID: 6235
		// (get) Token: 0x06006638 RID: 26168 RVA: 0x00092A74 File Offset: 0x00090C74
		// (set) Token: 0x06006639 RID: 26169 RVA: 0x00092A8D File Offset: 0x00090C8D
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

		// Token: 0x1700185C RID: 6236
		// (get) Token: 0x0600663A RID: 26170 RVA: 0x00092ABD File Offset: 0x00090CBD
		// (set) Token: 0x0600663B RID: 26171 RVA: 0x00092AD6 File Offset: 0x00090CD6
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

		// Token: 0x1700185D RID: 6237
		// (get) Token: 0x0600663C RID: 26172 RVA: 0x00092B06 File Offset: 0x00090D06
		// (set) Token: 0x0600663D RID: 26173 RVA: 0x00092B1F File Offset: 0x00090D1F
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

		// Token: 0x1700185E RID: 6238
		// (get) Token: 0x0600663E RID: 26174 RVA: 0x00092B4F File Offset: 0x00090D4F
		// (set) Token: 0x0600663F RID: 26175 RVA: 0x00092B68 File Offset: 0x00090D68
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

		// Token: 0x1700185F RID: 6239
		// (get) Token: 0x06006640 RID: 26176 RVA: 0x00092B98 File Offset: 0x00090D98
		// (set) Token: 0x06006641 RID: 26177 RVA: 0x00092BB1 File Offset: 0x00090DB1
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

		// Token: 0x17001860 RID: 6240
		// (get) Token: 0x06006642 RID: 26178 RVA: 0x00092BE1 File Offset: 0x00090DE1
		// (set) Token: 0x06006643 RID: 26179 RVA: 0x00092BFA File Offset: 0x00090DFA
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

		// Token: 0x17001861 RID: 6241
		// (get) Token: 0x06006644 RID: 26180 RVA: 0x00092C2A File Offset: 0x00090E2A
		// (set) Token: 0x06006645 RID: 26181 RVA: 0x00092C43 File Offset: 0x00090E43
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

		// Token: 0x17001862 RID: 6242
		// (get) Token: 0x06006646 RID: 26182 RVA: 0x00092C73 File Offset: 0x00090E73
		// (set) Token: 0x06006647 RID: 26183 RVA: 0x00092C8C File Offset: 0x00090E8C
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

		// Token: 0x17001863 RID: 6243
		// (get) Token: 0x06006648 RID: 26184 RVA: 0x00092CBC File Offset: 0x00090EBC
		// (set) Token: 0x06006649 RID: 26185 RVA: 0x00092CD5 File Offset: 0x00090ED5
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

		// Token: 0x17001864 RID: 6244
		// (get) Token: 0x0600664A RID: 26186 RVA: 0x00092D05 File Offset: 0x00090F05
		// (set) Token: 0x0600664B RID: 26187 RVA: 0x00092D1E File Offset: 0x00090F1E
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

		// Token: 0x17001865 RID: 6245
		// (get) Token: 0x0600664C RID: 26188 RVA: 0x00092D4E File Offset: 0x00090F4E
		// (set) Token: 0x0600664D RID: 26189 RVA: 0x00092D67 File Offset: 0x00090F67
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

		// Token: 0x17001866 RID: 6246
		// (get) Token: 0x0600664E RID: 26190 RVA: 0x00092D97 File Offset: 0x00090F97
		// (set) Token: 0x0600664F RID: 26191 RVA: 0x00092DB0 File Offset: 0x00090FB0
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

		// Token: 0x17001867 RID: 6247
		// (get) Token: 0x06006650 RID: 26192 RVA: 0x00092DE0 File Offset: 0x00090FE0
		// (set) Token: 0x06006651 RID: 26193 RVA: 0x00092DF9 File Offset: 0x00090FF9
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

		// Token: 0x17001868 RID: 6248
		// (get) Token: 0x06006652 RID: 26194 RVA: 0x00092E29 File Offset: 0x00091029
		// (set) Token: 0x06006653 RID: 26195 RVA: 0x00092E42 File Offset: 0x00091042
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

		// Token: 0x17001869 RID: 6249
		// (get) Token: 0x06006654 RID: 26196 RVA: 0x00092E72 File Offset: 0x00091072
		// (set) Token: 0x06006655 RID: 26197 RVA: 0x00092E8B File Offset: 0x0009108B
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

		// Token: 0x1700186A RID: 6250
		// (get) Token: 0x06006656 RID: 26198 RVA: 0x00092EBB File Offset: 0x000910BB
		// (set) Token: 0x06006657 RID: 26199 RVA: 0x00092ED4 File Offset: 0x000910D4
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

		// Token: 0x1700186B RID: 6251
		// (get) Token: 0x06006658 RID: 26200 RVA: 0x00092F04 File Offset: 0x00091104
		// (set) Token: 0x06006659 RID: 26201 RVA: 0x00092F1D File Offset: 0x0009111D
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

		// Token: 0x1700186C RID: 6252
		// (get) Token: 0x0600665A RID: 26202 RVA: 0x00092F4D File Offset: 0x0009114D
		// (set) Token: 0x0600665B RID: 26203 RVA: 0x00092F66 File Offset: 0x00091166
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

		// Token: 0x1700186D RID: 6253
		// (get) Token: 0x0600665C RID: 26204 RVA: 0x00092F96 File Offset: 0x00091196
		// (set) Token: 0x0600665D RID: 26205 RVA: 0x00092FA6 File Offset: 0x000911A6
		public unsafe EActorUpdateOverlapsMethod UpdateOverlapsMethodDuringLevelStreaming
		{
			get
			{
				return (EActorUpdateOverlapsMethod)(*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_UpdateOverlapsMethodDuringLevelStreaming));
			}
			set
			{
				*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_UpdateOverlapsMethodDuringLevelStreaming) = (byte)value;
			}
		}

		// Token: 0x1700186E RID: 6254
		// (get) Token: 0x0600665E RID: 26206 RVA: 0x00092FB7 File Offset: 0x000911B7
		// (set) Token: 0x0600665F RID: 26207 RVA: 0x00092FC7 File Offset: 0x000911C7
		public unsafe EActorUpdateOverlapsMethod DefaultUpdateOverlapsMethodDuringLevelStreaming
		{
			get
			{
				return (EActorUpdateOverlapsMethod)(*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_DefaultUpdateOverlapsMethodDuringLevelStreaming));
			}
			set
			{
				*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_DefaultUpdateOverlapsMethodDuringLevelStreaming) = (byte)value;
			}
		}

		// Token: 0x1700186F RID: 6255
		// (get) Token: 0x06006660 RID: 26208 RVA: 0x00092FD8 File Offset: 0x000911D8
		// (set) Token: 0x06006661 RID: 26209 RVA: 0x00092FEC File Offset: 0x000911EC
		[Nullable(0)]
		public unsafe TEnumAsByte<ENetRole> RemoteRole
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)AActor.__PropertyOffset_RemoteRole);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_RemoteRole) = value;
			}
		}

		// Token: 0x17001870 RID: 6256
		// (get) Token: 0x06006662 RID: 26210 RVA: 0x00093004 File Offset: 0x00091204
		// (set) Token: 0x06006663 RID: 26211 RVA: 0x0009303D File Offset: 0x0009123D
		[Nullable(1)]
		public FRepMovement ReplicatedMovement
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FRepMovement result;
				if ((result = this._ReplicatedMovement) == null)
				{
					result = (this._ReplicatedMovement = new FRepMovement(base.NativePtr + (IntPtr)AActor.__PropertyOffset_ReplicatedMovement, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRepMovement.StaticStruct(), base.NativePtr + (IntPtr)AActor.__PropertyOffset_ReplicatedMovement, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001871 RID: 6257
		// (get) Token: 0x06006664 RID: 26212 RVA: 0x00093060 File Offset: 0x00091260
		// (set) Token: 0x06006665 RID: 26213 RVA: 0x00093099 File Offset: 0x00091299
		[Nullable(1)]
		public FKuroRepMovement Kuro_ReplicatedMovement
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroRepMovement result;
				if ((result = this._Kuro_ReplicatedMovement) == null)
				{
					result = (this._Kuro_ReplicatedMovement = new FKuroRepMovement(base.NativePtr + (IntPtr)AActor.__PropertyOffset_Kuro_ReplicatedMovement, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroRepMovement.StaticStruct(), base.NativePtr + (IntPtr)AActor.__PropertyOffset_Kuro_ReplicatedMovement, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001872 RID: 6258
		// (get) Token: 0x06006666 RID: 26214 RVA: 0x000930BA File Offset: 0x000912BA
		// (set) Token: 0x06006667 RID: 26215 RVA: 0x000930CA File Offset: 0x000912CA
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

		// Token: 0x17001873 RID: 6259
		// (get) Token: 0x06006668 RID: 26216 RVA: 0x000930DB File Offset: 0x000912DB
		// (set) Token: 0x06006669 RID: 26217 RVA: 0x000930EB File Offset: 0x000912EB
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

		// Token: 0x17001874 RID: 6260
		// (get) Token: 0x0600666A RID: 26218 RVA: 0x000930FC File Offset: 0x000912FC
		// (set) Token: 0x0600666B RID: 26219 RVA: 0x00093135 File Offset: 0x00091335
		[Nullable(1)]
		public FRepAttachment AttachmentReplication
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FRepAttachment result;
				if ((result = this._AttachmentReplication) == null)
				{
					result = (this._AttachmentReplication = new FRepAttachment(base.NativePtr + (IntPtr)AActor.__PropertyOffset_AttachmentReplication, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRepAttachment.StaticStruct(), base.NativePtr + (IntPtr)AActor.__PropertyOffset_AttachmentReplication, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001875 RID: 6261
		// (get) Token: 0x0600666C RID: 26220 RVA: 0x00093156 File Offset: 0x00091356
		// (set) Token: 0x0600666D RID: 26221 RVA: 0x0009316A File Offset: 0x0009136A
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

		// Token: 0x17001876 RID: 6262
		// (get) Token: 0x0600666E RID: 26222 RVA: 0x0009317F File Offset: 0x0009137F
		// (set) Token: 0x0600666F RID: 26223 RVA: 0x00093193 File Offset: 0x00091393
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

		// Token: 0x17001877 RID: 6263
		// (get) Token: 0x06006670 RID: 26224 RVA: 0x000931A8 File Offset: 0x000913A8
		// (set) Token: 0x06006671 RID: 26225 RVA: 0x000931BC File Offset: 0x000913BC
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

		// Token: 0x17001878 RID: 6264
		// (get) Token: 0x06006672 RID: 26226 RVA: 0x000931D1 File Offset: 0x000913D1
		// (set) Token: 0x06006673 RID: 26227 RVA: 0x000931E1 File Offset: 0x000913E1
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

		// Token: 0x17001879 RID: 6265
		// (get) Token: 0x06006674 RID: 26228 RVA: 0x000931F2 File Offset: 0x000913F2
		// (set) Token: 0x06006675 RID: 26229 RVA: 0x00093206 File Offset: 0x00091406
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

		// Token: 0x1700187A RID: 6266
		// (get) Token: 0x06006676 RID: 26230 RVA: 0x0009321B File Offset: 0x0009141B
		// (set) Token: 0x06006677 RID: 26231 RVA: 0x0009322F File Offset: 0x0009142F
		[Nullable(0)]
		public unsafe TEnumAsByte<ENetRole> Role
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)AActor.__PropertyOffset_Role);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_Role) = value;
			}
		}

		// Token: 0x1700187B RID: 6267
		// (get) Token: 0x06006678 RID: 26232 RVA: 0x00093244 File Offset: 0x00091444
		// (set) Token: 0x06006679 RID: 26233 RVA: 0x00093258 File Offset: 0x00091458
		[Nullable(0)]
		public unsafe TEnumAsByte<ENetDormancy> NetDormancy
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)AActor.__PropertyOffset_NetDormancy);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_NetDormancy) = value;
			}
		}

		// Token: 0x1700187C RID: 6268
		// (get) Token: 0x0600667A RID: 26234 RVA: 0x0009326D File Offset: 0x0009146D
		// (set) Token: 0x0600667B RID: 26235 RVA: 0x0009327D File Offset: 0x0009147D
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

		// Token: 0x1700187D RID: 6269
		// (get) Token: 0x0600667C RID: 26236 RVA: 0x0009328E File Offset: 0x0009148E
		// (set) Token: 0x0600667D RID: 26237 RVA: 0x000932A2 File Offset: 0x000914A2
		[Nullable(0)]
		public unsafe TEnumAsByte<EAutoReceiveInput> AutoReceiveInput
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)AActor.__PropertyOffset_AutoReceiveInput);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)AActor.__PropertyOffset_AutoReceiveInput) = value;
			}
		}

		// Token: 0x1700187E RID: 6270
		// (get) Token: 0x0600667E RID: 26238 RVA: 0x000932B7 File Offset: 0x000914B7
		// (set) Token: 0x0600667F RID: 26239 RVA: 0x000932C7 File Offset: 0x000914C7
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

		// Token: 0x1700187F RID: 6271
		// (get) Token: 0x06006680 RID: 26240 RVA: 0x000932D8 File Offset: 0x000914D8
		// (set) Token: 0x06006681 RID: 26241 RVA: 0x000932EC File Offset: 0x000914EC
		public unsafe UInputComponent InputComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInputComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AActor.__PropertyOffset_InputComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AActor.__PropertyOffset_InputComponent, value);
			}
		}

		// Token: 0x17001880 RID: 6272
		// (get) Token: 0x06006682 RID: 26242 RVA: 0x00093301 File Offset: 0x00091501
		// (set) Token: 0x06006683 RID: 26243 RVA: 0x00093311 File Offset: 0x00091511
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

		// Token: 0x17001881 RID: 6273
		// (get) Token: 0x06006684 RID: 26244 RVA: 0x00093322 File Offset: 0x00091522
		// (set) Token: 0x06006685 RID: 26245 RVA: 0x00093332 File Offset: 0x00091532
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

		// Token: 0x17001882 RID: 6274
		// (get) Token: 0x06006686 RID: 26246 RVA: 0x00093343 File Offset: 0x00091543
		// (set) Token: 0x06006687 RID: 26247 RVA: 0x00093353 File Offset: 0x00091553
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

		// Token: 0x17001883 RID: 6275
		// (get) Token: 0x06006688 RID: 26248 RVA: 0x00093364 File Offset: 0x00091564
		// (set) Token: 0x06006689 RID: 26249 RVA: 0x00093374 File Offset: 0x00091574
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

		// Token: 0x17001884 RID: 6276
		// (get) Token: 0x0600668A RID: 26250 RVA: 0x00093385 File Offset: 0x00091585
		// (set) Token: 0x0600668B RID: 26251 RVA: 0x00093395 File Offset: 0x00091595
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

		// Token: 0x17001885 RID: 6277
		// (get) Token: 0x0600668C RID: 26252 RVA: 0x000933A6 File Offset: 0x000915A6
		// (set) Token: 0x0600668D RID: 26253 RVA: 0x000933BA File Offset: 0x000915BA
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

		// Token: 0x17001886 RID: 6278
		// (get) Token: 0x0600668E RID: 26254 RVA: 0x000933D0 File Offset: 0x000915D0
		// (set) Token: 0x0600668F RID: 26255 RVA: 0x00093409 File Offset: 0x00091609
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

		// Token: 0x17001887 RID: 6279
		// (get) Token: 0x06006690 RID: 26256 RVA: 0x00093417 File Offset: 0x00091617
		// (set) Token: 0x06006691 RID: 26257 RVA: 0x0009342B File Offset: 0x0009162B
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

		// Token: 0x17001888 RID: 6280
		// (get) Token: 0x06006692 RID: 26258 RVA: 0x00093440 File Offset: 0x00091640
		// (set) Token: 0x06006693 RID: 26259 RVA: 0x00093479 File Offset: 0x00091679
		[Nullable(1)]
		public TArray<AMatineeActor> ControllingMatineeActors
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<AMatineeActor> result;
				if ((result = this._ControllingMatineeActors) == null)
				{
					result = (this._ControllingMatineeActors = new TArray<AMatineeActor>(base.NativePtr + (IntPtr)AActor.__PropertyOffset_ControllingMatineeActors, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ControllingMatineeActors.CopyAssign(value);
			}
		}

		// Token: 0x17001889 RID: 6281
		// (get) Token: 0x06006694 RID: 26260 RVA: 0x00093488 File Offset: 0x00091688
		// (set) Token: 0x06006695 RID: 26261 RVA: 0x000934C1 File Offset: 0x000916C1
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

		// Token: 0x1700188A RID: 6282
		// (get) Token: 0x06006696 RID: 26262 RVA: 0x000934CF File Offset: 0x000916CF
		// (set) Token: 0x06006697 RID: 26263 RVA: 0x000934E3 File Offset: 0x000916E3
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

		// Token: 0x1700188B RID: 6283
		// (get) Token: 0x06006698 RID: 26264 RVA: 0x000934F8 File Offset: 0x000916F8
		// (set) Token: 0x06006699 RID: 26265 RVA: 0x00093531 File Offset: 0x00091731
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

		// Token: 0x1700188C RID: 6284
		// (get) Token: 0x0600669A RID: 26266 RVA: 0x00093540 File Offset: 0x00091740
		// (set) Token: 0x0600669B RID: 26267 RVA: 0x00093579 File Offset: 0x00091779
		[Nullable(1)]
		public FTakeAnyDamageSignature OnTakeAnyDamage
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FTakeAnyDamageSignature result;
				if ((result = this._OnTakeAnyDamage) == null)
				{
					result = (this._OnTakeAnyDamage = new FTakeAnyDamageSignature(base.NativePtr + (IntPtr)AActor.__PropertyOffset_OnTakeAnyDamage, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AActor.__PropertyOffset_OnTakeAnyDamage, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700188D RID: 6285
		// (get) Token: 0x0600669C RID: 26268 RVA: 0x0009359C File Offset: 0x0009179C
		// (set) Token: 0x0600669D RID: 26269 RVA: 0x000935D5 File Offset: 0x000917D5
		[Nullable(1)]
		public FTakePointDamageSignature OnTakePointDamage
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FTakePointDamageSignature result;
				if ((result = this._OnTakePointDamage) == null)
				{
					result = (this._OnTakePointDamage = new FTakePointDamageSignature(base.NativePtr + (IntPtr)AActor.__PropertyOffset_OnTakePointDamage, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AActor.__PropertyOffset_OnTakePointDamage, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700188E RID: 6286
		// (get) Token: 0x0600669E RID: 26270 RVA: 0x000935F8 File Offset: 0x000917F8
		// (set) Token: 0x0600669F RID: 26271 RVA: 0x00093631 File Offset: 0x00091831
		[Nullable(1)]
		public FTakeRadialDamageSignature OnTakeRadialDamage
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FTakeRadialDamageSignature result;
				if ((result = this._OnTakeRadialDamage) == null)
				{
					result = (this._OnTakeRadialDamage = new FTakeRadialDamageSignature(base.NativePtr + (IntPtr)AActor.__PropertyOffset_OnTakeRadialDamage, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AActor.__PropertyOffset_OnTakeRadialDamage, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700188F RID: 6287
		// (get) Token: 0x060066A0 RID: 26272 RVA: 0x00093654 File Offset: 0x00091854
		// (set) Token: 0x060066A1 RID: 26273 RVA: 0x0009368D File Offset: 0x0009188D
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

		// Token: 0x17001890 RID: 6288
		// (get) Token: 0x060066A2 RID: 26274 RVA: 0x000936B0 File Offset: 0x000918B0
		// (set) Token: 0x060066A3 RID: 26275 RVA: 0x000936E9 File Offset: 0x000918E9
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

		// Token: 0x17001891 RID: 6289
		// (get) Token: 0x060066A4 RID: 26276 RVA: 0x0009370C File Offset: 0x0009190C
		// (set) Token: 0x060066A5 RID: 26277 RVA: 0x00093745 File Offset: 0x00091945
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

		// Token: 0x17001892 RID: 6290
		// (get) Token: 0x060066A6 RID: 26278 RVA: 0x00093768 File Offset: 0x00091968
		// (set) Token: 0x060066A7 RID: 26279 RVA: 0x000937A1 File Offset: 0x000919A1
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

		// Token: 0x17001893 RID: 6291
		// (get) Token: 0x060066A8 RID: 26280 RVA: 0x000937C4 File Offset: 0x000919C4
		// (set) Token: 0x060066A9 RID: 26281 RVA: 0x000937FD File Offset: 0x000919FD
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

		// Token: 0x17001894 RID: 6292
		// (get) Token: 0x060066AA RID: 26282 RVA: 0x00093820 File Offset: 0x00091A20
		// (set) Token: 0x060066AB RID: 26283 RVA: 0x00093859 File Offset: 0x00091A59
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

		// Token: 0x17001895 RID: 6293
		// (get) Token: 0x060066AC RID: 26284 RVA: 0x0009387C File Offset: 0x00091A7C
		// (set) Token: 0x060066AD RID: 26285 RVA: 0x000938B5 File Offset: 0x00091AB5
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

		// Token: 0x17001896 RID: 6294
		// (get) Token: 0x060066AE RID: 26286 RVA: 0x000938D8 File Offset: 0x00091AD8
		// (set) Token: 0x060066AF RID: 26287 RVA: 0x00093911 File Offset: 0x00091B11
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

		// Token: 0x17001897 RID: 6295
		// (get) Token: 0x060066B0 RID: 26288 RVA: 0x00093934 File Offset: 0x00091B34
		// (set) Token: 0x060066B1 RID: 26289 RVA: 0x0009396D File Offset: 0x00091B6D
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

		// Token: 0x17001898 RID: 6296
		// (get) Token: 0x060066B2 RID: 26290 RVA: 0x00093990 File Offset: 0x00091B90
		// (set) Token: 0x060066B3 RID: 26291 RVA: 0x000939C9 File Offset: 0x00091BC9
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

		// Token: 0x17001899 RID: 6297
		// (get) Token: 0x060066B4 RID: 26292 RVA: 0x000939EC File Offset: 0x00091BEC
		// (set) Token: 0x060066B5 RID: 26293 RVA: 0x00093A25 File Offset: 0x00091C25
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

		// Token: 0x1700189A RID: 6298
		// (get) Token: 0x060066B6 RID: 26294 RVA: 0x00093A48 File Offset: 0x00091C48
		// (set) Token: 0x060066B7 RID: 26295 RVA: 0x00093A81 File Offset: 0x00091C81
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

		// Token: 0x1700189B RID: 6299
		// (get) Token: 0x060066B8 RID: 26296 RVA: 0x00093AA4 File Offset: 0x00091CA4
		// (set) Token: 0x060066B9 RID: 26297 RVA: 0x00093ADD File Offset: 0x00091CDD
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

		// Token: 0x1700189C RID: 6300
		// (get) Token: 0x060066BA RID: 26298 RVA: 0x00093B00 File Offset: 0x00091D00
		// (set) Token: 0x060066BB RID: 26299 RVA: 0x00093B39 File Offset: 0x00091D39
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

		// Token: 0x1700189D RID: 6301
		// (get) Token: 0x060066BC RID: 26300 RVA: 0x00093B48 File Offset: 0x00091D48
		// (set) Token: 0x060066BD RID: 26301 RVA: 0x00093B81 File Offset: 0x00091D81
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

		// Token: 0x1700189E RID: 6302
		// (get) Token: 0x060066BE RID: 26302 RVA: 0x00093B90 File Offset: 0x00091D90
		// (set) Token: 0x060066BF RID: 26303 RVA: 0x00093BC9 File Offset: 0x00091DC9
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

		// Token: 0x060066C0 RID: 26304 RVA: 0x00093BD7 File Offset: 0x00091DD7
		public bool WasRecentlyRenderedOnScreen(float Tolerance = 0.2f)
		{
			return AActor.__WasRecentlyRenderedOnScreen_Internal(base.NativePtr, Tolerance);
		}

		// Token: 0x060066C1 RID: 26305 RVA: 0x00093BE5 File Offset: 0x00091DE5
		public bool WasRecentlyRendered(float Tolerance = 0.2f)
		{
			return AActor.__WasRecentlyRendered_Internal(base.NativePtr, Tolerance);
		}

		// Token: 0x060066C2 RID: 26306 RVA: 0x00093BF3 File Offset: 0x00091DF3
		public bool WasRecentlyPassVisibilityTest(float Tolerance = 0.2f)
		{
			return AActor.__WasRecentlyPassVisibilityTest_Internal(base.NativePtr, Tolerance);
		}

		// Token: 0x060066C3 RID: 26307 RVA: 0x00093C01 File Offset: 0x00091E01
		public virtual void UserConstructionScript()
		{
			AActor.__UserConstructionScript_Internal(base.NativePtr);
		}

		// Token: 0x060066C4 RID: 26308 RVA: 0x00093C0E File Offset: 0x00091E0E
		public void TearOff()
		{
			AActor.__TearOff_Internal(base.NativePtr);
		}

		// Token: 0x060066C5 RID: 26309 RVA: 0x00093C1B File Offset: 0x00091E1B
		public void SnapRootComponentTo(AActor InParentActor, FName InSocketName)
		{
			AActor.__SnapRootComponentTo_Internal(base.NativePtr, (InParentActor != null) ? InParentActor.NativePtr : IntPtr.Zero, InSocketName);
		}

		// Token: 0x060066C6 RID: 26310 RVA: 0x00093C39 File Offset: 0x00091E39
		public void SetTickGroup(ETickingGroup NewTickGroup)
		{
			AActor.__SetTickGroup_Internal(base.NativePtr, NewTickGroup);
		}

		// Token: 0x060066C7 RID: 26311 RVA: 0x00093C4C File Offset: 0x00091E4C
		public void SetTickableWhenPaused(bool bTickableWhenPaused)
		{
			AActor.__SetTickableWhenPaused_Internal(base.NativePtr, bTickableWhenPaused);
		}

		// Token: 0x060066C8 RID: 26312 RVA: 0x00093C5A File Offset: 0x00091E5A
		public void SetReplicates(bool bInReplicates)
		{
			AActor.__SetReplicates_Internal(base.NativePtr, bInReplicates);
		}

		// Token: 0x060066C9 RID: 26313 RVA: 0x00093C68 File Offset: 0x00091E68
		public void SetReplicateMovement(bool bInReplicateMovement)
		{
			AActor.__SetReplicateMovement_Internal(base.NativePtr, bInReplicateMovement);
		}

		// Token: 0x060066CA RID: 26314 RVA: 0x00093C76 File Offset: 0x00091E76
		public void SetPrimitiveEntityType(uint type)
		{
			AActor.__SetPrimitiveEntityType_Internal(base.NativePtr, type);
		}

		// Token: 0x060066CB RID: 26315 RVA: 0x00093C84 File Offset: 0x00091E84
		public void SetPrimitiveBlueprintTypeName(FName Name)
		{
			AActor.__SetPrimitiveBlueprintTypeName_Internal(base.NativePtr, Name);
		}

		// Token: 0x060066CC RID: 26316 RVA: 0x00093C92 File Offset: 0x00091E92
		public void SetOwner(AActor NewOwner)
		{
			AActor.__SetOwner_Internal(base.NativePtr, (NewOwner != null) ? NewOwner.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060066CD RID: 26317 RVA: 0x00093CAF File Offset: 0x00091EAF
		public void SetNetDormancy(ENetDormancy NewDormancy)
		{
			AActor.__SetNetDormancy_Internal(base.NativePtr, NewDormancy);
		}

		// Token: 0x060066CE RID: 26318 RVA: 0x00093CC2 File Offset: 0x00091EC2
		public void SetLifeSpan(float InLifespan)
		{
			AActor.__SetLifeSpan_Internal(base.NativePtr, InLifespan);
		}

		// Token: 0x060066CF RID: 26319 RVA: 0x00093CD0 File Offset: 0x00091ED0
		public void SetKuroOnlyTickOutside(bool OnlyTickOutside)
		{
			AActor.__SetKuroOnlyTickOutside_Internal(base.NativePtr, OnlyTickOutside);
		}

		// Token: 0x060066D0 RID: 26320
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetKuroNetMode(EKuroNetMode KNM);

		// Token: 0x060066D1 RID: 26321 RVA: 0x00093CDE File Offset: 0x00091EDE
		public void SetIsIgnoreUpdateOverlap(bool bShouldIgnoreUpdateOverlap)
		{
			AActor.__SetIsIgnoreUpdateOverlap_Internal(base.NativePtr, bShouldIgnoreUpdateOverlap);
		}

		// Token: 0x060066D2 RID: 26322 RVA: 0x00093CEC File Offset: 0x00091EEC
		public void SetForceHidden(bool bForce)
		{
			AActor.__SetForceHidden_Internal(base.NativePtr, bForce);
		}

		// Token: 0x060066D3 RID: 26323 RVA: 0x00093CFA File Offset: 0x00091EFA
		public void SetAutoDestroyWhenFinished(bool bVal)
		{
			AActor.__SetAutoDestroyWhenFinished_Internal(base.NativePtr, bVal);
		}

		// Token: 0x060066D4 RID: 26324 RVA: 0x00093D08 File Offset: 0x00091F08
		public void SetActorViewableInRender(bool bNewViewable)
		{
			AActor.__SetActorViewableInRender_Internal(base.NativePtr, bNewViewable);
		}

		// Token: 0x060066D5 RID: 26325 RVA: 0x00093D16 File Offset: 0x00091F16
		public void SetActorTickInterval(float TickInterval)
		{
			AActor.__SetActorTickInterval_Internal(base.NativePtr, TickInterval);
		}

		// Token: 0x060066D6 RID: 26326 RVA: 0x00093D24 File Offset: 0x00091F24
		public void SetActorTickEnabled(bool bEnabled)
		{
			AActor.__SetActorTickEnabled_Internal(base.NativePtr, bEnabled);
		}

		// Token: 0x060066D7 RID: 26327 RVA: 0x00093D32 File Offset: 0x00091F32
		public void SetActorScale3D(FVector NewScale3D)
		{
			AActor.__SetActorScale3D_Internal(base.NativePtr, NewScale3D);
		}

		// Token: 0x060066D8 RID: 26328 RVA: 0x00093D40 File Offset: 0x00091F40
		public void SetActorRelativeScale3D(FVector NewRelativeScale)
		{
			AActor.__SetActorRelativeScale3D_Internal(base.NativePtr, NewRelativeScale);
		}

		// Token: 0x060066D9 RID: 26329 RVA: 0x00093D4E File Offset: 0x00091F4E
		public void SetActorHiddenInGame(bool bNewHidden)
		{
			AActor.__SetActorHiddenInGame_Internal(base.NativePtr, bNewHidden);
		}

		// Token: 0x060066DA RID: 26330 RVA: 0x00093D5C File Offset: 0x00091F5C
		public void SetActorEnableCollision(bool bNewActorEnableCollision)
		{
			AActor.__SetActorEnableCollision_Internal(base.NativePtr, bNewActorEnableCollision);
		}

		// Token: 0x060066DB RID: 26331 RVA: 0x00093D6A File Offset: 0x00091F6A
		public void RemoveTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
		{
			AActor.__RemoveTickPrerequisiteComponent_Internal(base.NativePtr, (PrerequisiteComponent != null) ? PrerequisiteComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060066DC RID: 26332 RVA: 0x00093D87 File Offset: 0x00091F87
		public void RemoveTickPrerequisiteActor(AActor PrerequisiteActor)
		{
			AActor.__RemoveTickPrerequisiteActor_Internal(base.NativePtr, (PrerequisiteActor != null) ? PrerequisiteActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060066DD RID: 26333 RVA: 0x00093DA4 File Offset: 0x00091FA4
		public virtual void ReceiveTick(float DeltaSeconds)
		{
			AActor.__ReceiveTick_Internal(base.NativePtr, DeltaSeconds);
		}

		// Token: 0x060066DE RID: 26334 RVA: 0x00093DB4 File Offset: 0x00091FB4
		public virtual void ReceiveRadialDamage(float DamageReceived, UDamageType DamageType, FVector Origin, in FHitResult HitInfo, AController InstigatedBy, AActor DamageCauser)
		{
			AActor.__ReceiveRadialDamage_Internal(base.NativePtr, DamageReceived, (DamageType != null) ? DamageType.NativePtr : IntPtr.Zero, Origin, (HitInfo ?? new FHitResult()).NativePtr, (InstigatedBy != null) ? InstigatedBy.NativePtr : IntPtr.Zero, (DamageCauser != null) ? DamageCauser.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060066DF RID: 26335 RVA: 0x00093E14 File Offset: 0x00092014
		public virtual void ReceivePointDamage(float Damage, UDamageType DamageType, FVector HitLocation, FVector HitNormal, UPrimitiveComponent HitComponent, FName BoneName, FVector ShotFromDirection, AController InstigatedBy, AActor DamageCauser, in FHitResult HitInfo)
		{
			AActor.__ReceivePointDamage_Internal(base.NativePtr, Damage, (DamageType != null) ? DamageType.NativePtr : IntPtr.Zero, HitLocation, HitNormal, (HitComponent != null) ? HitComponent.NativePtr : IntPtr.Zero, BoneName, ShotFromDirection, (InstigatedBy != null) ? InstigatedBy.NativePtr : IntPtr.Zero, (DamageCauser != null) ? DamageCauser.NativePtr : IntPtr.Zero, (HitInfo ?? new FHitResult()).NativePtr);
		}

		// Token: 0x060066E0 RID: 26336 RVA: 0x00093E8C File Offset: 0x0009208C
		public virtual void ReceiveHit(UPrimitiveComponent MyComp, AActor Other, UPrimitiveComponent OtherComp, bool bSelfMoved, FVector HitLocation, FVector HitNormal, FVector NormalImpulse, in FHitResult Hit)
		{
			AActor.__ReceiveHit_Internal(base.NativePtr, (MyComp != null) ? MyComp.NativePtr : IntPtr.Zero, (Other != null) ? Other.NativePtr : IntPtr.Zero, (OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero, bSelfMoved, HitLocation, HitNormal, NormalImpulse, (Hit ?? new FHitResult()).NativePtr);
		}

		// Token: 0x060066E1 RID: 26337 RVA: 0x00093EED File Offset: 0x000920ED
		public virtual void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			AActor.__ReceiveEndPlay_Internal(base.NativePtr, EndPlayReason);
		}

		// Token: 0x060066E2 RID: 26338 RVA: 0x00093F00 File Offset: 0x00092100
		public virtual void ReceiveDestroyed()
		{
			AActor.__ReceiveDestroyed_Internal(base.NativePtr);
		}

		// Token: 0x060066E3 RID: 26339 RVA: 0x00093F0D File Offset: 0x0009210D
		public virtual void ReceiveBeginPlay()
		{
			AActor.__ReceiveBeginPlay_Internal(base.NativePtr);
		}

		// Token: 0x060066E4 RID: 26340 RVA: 0x00093F1A File Offset: 0x0009211A
		public virtual void ReceiveAnyDamage(float Damage, UDamageType DamageType, AController InstigatedBy, AActor DamageCauser)
		{
			AActor.__ReceiveAnyDamage_Internal(base.NativePtr, Damage, (DamageType != null) ? DamageType.NativePtr : IntPtr.Zero, (InstigatedBy != null) ? InstigatedBy.NativePtr : IntPtr.Zero, (DamageCauser != null) ? DamageCauser.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060066E5 RID: 26341 RVA: 0x00093F5A File Offset: 0x0009215A
		public virtual void ReceiveActorOnReleased(FKey ButtonReleased)
		{
			AActor.__ReceiveActorOnReleased_Internal(base.NativePtr, (ButtonReleased ?? new FKey()).NativePtr);
		}

		// Token: 0x060066E6 RID: 26342 RVA: 0x00093F76 File Offset: 0x00092176
		public virtual void ReceiveActorOnInputTouchLeave(ETouchIndex FingerIndex)
		{
			AActor.__ReceiveActorOnInputTouchLeave_Internal(base.NativePtr, FingerIndex);
		}

		// Token: 0x060066E7 RID: 26343 RVA: 0x00093F89 File Offset: 0x00092189
		public virtual void ReceiveActorOnInputTouchEnter(ETouchIndex FingerIndex)
		{
			AActor.__ReceiveActorOnInputTouchEnter_Internal(base.NativePtr, FingerIndex);
		}

		// Token: 0x060066E8 RID: 26344 RVA: 0x00093F9C File Offset: 0x0009219C
		public virtual void ReceiveActorOnInputTouchEnd(ETouchIndex FingerIndex)
		{
			AActor.__ReceiveActorOnInputTouchEnd_Internal(base.NativePtr, FingerIndex);
		}

		// Token: 0x060066E9 RID: 26345 RVA: 0x00093FAF File Offset: 0x000921AF
		public virtual void ReceiveActorOnInputTouchBegin(ETouchIndex FingerIndex)
		{
			AActor.__ReceiveActorOnInputTouchBegin_Internal(base.NativePtr, FingerIndex);
		}

		// Token: 0x060066EA RID: 26346 RVA: 0x00093FC2 File Offset: 0x000921C2
		public virtual void ReceiveActorOnClicked(FKey ButtonPressed)
		{
			AActor.__ReceiveActorOnClicked_Internal(base.NativePtr, (ButtonPressed ?? new FKey()).NativePtr);
		}

		// Token: 0x060066EB RID: 26347 RVA: 0x00093FDE File Offset: 0x000921DE
		public virtual void ReceiveActorEndOverlap(AActor OtherActor)
		{
			AActor.__ReceiveActorEndOverlap_Internal(base.NativePtr, (OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060066EC RID: 26348 RVA: 0x00093FFB File Offset: 0x000921FB
		public virtual void ReceiveActorEndCursorOver()
		{
			AActor.__ReceiveActorEndCursorOver_Internal(base.NativePtr);
		}

		// Token: 0x060066ED RID: 26349 RVA: 0x00094008 File Offset: 0x00092208
		public virtual void ReceiveActorBeginOverlap(AActor OtherActor)
		{
			AActor.__ReceiveActorBeginOverlap_Internal(base.NativePtr, (OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060066EE RID: 26350 RVA: 0x00094025 File Offset: 0x00092225
		public virtual void ReceiveActorBeginCursorOver()
		{
			AActor.__ReceiveActorBeginCursorOver_Internal(base.NativePtr);
		}

		// Token: 0x060066EF RID: 26351 RVA: 0x00094032 File Offset: 0x00092232
		public void PrestreamTextures(float Seconds, bool bEnableStreaming, int CinematicTextureGroups = 0)
		{
			AActor.__PrestreamTextures_Internal(base.NativePtr, Seconds, bEnableStreaming, CinematicTextureGroups);
		}

		// Token: 0x060066F0 RID: 26352 RVA: 0x00094042 File Offset: 0x00092242
		public void OnRep_ReplicateMovement()
		{
			AActor.__OnRep_ReplicateMovement_Internal(base.NativePtr);
		}

		// Token: 0x060066F1 RID: 26353 RVA: 0x0009404F File Offset: 0x0009224F
		public void OnRep_ReplicatedMovement()
		{
			AActor.__OnRep_ReplicatedMovement_Internal(base.NativePtr);
		}

		// Token: 0x060066F2 RID: 26354 RVA: 0x0009405C File Offset: 0x0009225C
		public void OnRep_Owner()
		{
			AActor.__OnRep_Owner_Internal(base.NativePtr);
		}

		// Token: 0x060066F3 RID: 26355 RVA: 0x00094069 File Offset: 0x00092269
		public void OnRep_Instigator()
		{
			AActor.__OnRep_Instigator_Internal(base.NativePtr);
		}

		// Token: 0x060066F4 RID: 26356 RVA: 0x00094076 File Offset: 0x00092276
		public void OnRep_AttachmentReplication()
		{
			AActor.__OnRep_AttachmentReplication_Internal(base.NativePtr);
		}

		// Token: 0x060066F5 RID: 26357 RVA: 0x00094083 File Offset: 0x00092283
		public void MakeNoise(float Loudness = 1f, APawn NoiseInstigator = null, FVector NoiseLocation = default(FVector), float MaxRange = 0f, FName Tag = default(FName))
		{
			AActor.__MakeNoise_Internal(base.NativePtr, Loudness, (NoiseInstigator != null) ? NoiseInstigator.NativePtr : IntPtr.Zero, NoiseLocation, MaxRange, Tag);
		}

		// Token: 0x060066F6 RID: 26358 RVA: 0x000940A6 File Offset: 0x000922A6
		public UMaterialInstanceDynamic MakeMIDForMaterial(UMaterialInterface Parent)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(AActor.__MakeMIDForMaterial_Internal(base.NativePtr, (Parent != null) ? Parent.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060066F7 RID: 26359 RVA: 0x000940C8 File Offset: 0x000922C8
		public void KuroTickActorOutside(float DeltaSeconds)
		{
			AActor.__KuroTickActorOutside_Internal(base.NativePtr, DeltaSeconds);
		}

		// Token: 0x060066F8 RID: 26360 RVA: 0x000940D6 File Offset: 0x000922D6
		public void Kuro_SetRole(EKuroNetRole InRole)
		{
			AActor.__Kuro_SetRole_Internal(base.NativePtr, InRole);
		}

		// Token: 0x060066F9 RID: 26361 RVA: 0x000940E9 File Offset: 0x000922E9
		public void Kuro_SetReplicatedMovement(in FKuroRepMovement InReplicatedMovement)
		{
			AActor.__Kuro_SetReplicatedMovement_Internal(base.NativePtr, (InReplicatedMovement ?? new FKuroRepMovement()).NativePtr);
		}

		// Token: 0x060066FA RID: 26362 RVA: 0x00094106 File Offset: 0x00092306
		public void Kuro_OnRep_ReplicatedMovement()
		{
			AActor.__Kuro_OnRep_ReplicatedMovement_Internal(base.NativePtr);
		}

		// Token: 0x060066FB RID: 26363 RVA: 0x00094113 File Offset: 0x00092313
		[NullableContext(1)]
		public FKuroRepMovement Kuro_GetReplicatedMovement()
		{
			return new FKuroRepMovement(AActor.__Kuro_GetReplicatedMovement_Internal(base.NativePtr), null);
		}

		// Token: 0x060066FC RID: 26364 RVA: 0x00094126 File Offset: 0x00092326
		[NullableContext(0)]
		public TEnumAsByte<EKuroNetRole> Kuro_GetLocalRole()
		{
			return AActor.__Kuro_GetLocalRole_Internal(base.NativePtr);
		}

		// Token: 0x060066FD RID: 26365 RVA: 0x00094133 File Offset: 0x00092333
		public bool K2_TeleportTo(FVector DestLocation, FRotator DestRotation)
		{
			return AActor.__K2_TeleportTo_Internal(base.NativePtr, DestLocation, DestRotation);
		}

		// Token: 0x060066FE RID: 26366 RVA: 0x00094142 File Offset: 0x00092342
		public void K2_SetDeferedConcurrentUpdateTransform(bool bEnable)
		{
			AActor.__K2_SetDeferedConcurrentUpdateTransform_Internal(base.NativePtr, bEnable);
		}

		// Token: 0x060066FF RID: 26367 RVA: 0x00094150 File Offset: 0x00092350
		public unsafe bool K2_SetActorTransformForce(in FTransform NewTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = NewTransform;
			return AActor.__K2_SetActorTransformForce_Internal(base.NativePtr, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06006700 RID: 26368 RVA: 0x00094198 File Offset: 0x00092398
		public unsafe bool K2_SetActorTransform(in FTransform NewTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = NewTransform;
			return AActor.__K2_SetActorTransform_Internal(base.NativePtr, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06006701 RID: 26369 RVA: 0x000941E0 File Offset: 0x000923E0
		public bool K2_SetActorRotation(FRotator NewRotation, bool bTeleportPhysics)
		{
			return AActor.__K2_SetActorRotation_Internal(base.NativePtr, NewRotation, bTeleportPhysics);
		}

		// Token: 0x06006702 RID: 26370 RVA: 0x000941F0 File Offset: 0x000923F0
		public unsafe void K2_SetActorRelativeTransform(in FTransform NewRelativeTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = NewRelativeTransform;
			AActor.__K2_SetActorRelativeTransform_Internal(base.NativePtr, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06006703 RID: 26371 RVA: 0x00094238 File Offset: 0x00092438
		public void K2_SetActorRelativeRotation(FRotator NewRelativeRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			AActor.__K2_SetActorRelativeRotation_Internal(base.NativePtr, NewRelativeRotation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06006704 RID: 26372 RVA: 0x00094259 File Offset: 0x00092459
		public void K2_SetActorRelativeLocation(FVector NewRelativeLocation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			AActor.__K2_SetActorRelativeLocation_Internal(base.NativePtr, NewRelativeLocation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06006705 RID: 26373 RVA: 0x0009427A File Offset: 0x0009247A
		public bool K2_SetActorLocationAndRotation(FVector NewLocation, FRotator NewRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			return AActor.__K2_SetActorLocationAndRotation_Internal(base.NativePtr, NewLocation, NewRotation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06006706 RID: 26374 RVA: 0x0009429D File Offset: 0x0009249D
		public bool K2_SetActorLocation(FVector NewLocation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			return AActor.__K2_SetActorLocation_Internal(base.NativePtr, NewLocation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06006707 RID: 26375 RVA: 0x000942BE File Offset: 0x000924BE
		public virtual void K2_OnReset()
		{
			AActor.__K2_OnReset_Internal(base.NativePtr);
		}

		// Token: 0x06006708 RID: 26376 RVA: 0x000942CB File Offset: 0x000924CB
		public virtual void K2_OnEndViewTarget(APlayerController PC)
		{
			AActor.__K2_OnEndViewTarget_Internal(base.NativePtr, (PC != null) ? PC.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006709 RID: 26377 RVA: 0x000942E8 File Offset: 0x000924E8
		public virtual void K2_OnBecomeViewTarget(APlayerController PC)
		{
			AActor.__K2_OnBecomeViewTarget_Internal(base.NativePtr, (PC != null) ? PC.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600670A RID: 26378 RVA: 0x00094305 File Offset: 0x00092505
		public bool K2_KuroTeleportTo(FVector DestLocation, FRotator DestRotation)
		{
			return AActor.__K2_KuroTeleportTo_Internal(base.NativePtr, DestLocation, DestRotation);
		}

		// Token: 0x0600670B RID: 26379 RVA: 0x00094314 File Offset: 0x00092514
		public bool K2_KuroSetActorRotation(FRotator NewRotation, bool bSweep, bool bTeleportPhysics, bool bIgnoreOverlap = false)
		{
			return AActor.__K2_KuroSetActorRotation_Internal(base.NativePtr, NewRotation, bSweep, bTeleportPhysics, bIgnoreOverlap);
		}

		// Token: 0x0600670C RID: 26380 RVA: 0x00094326 File Offset: 0x00092526
		public USceneComponent K2_GetRootComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USceneComponent>(AActor.__K2_GetRootComponent_Internal(base.NativePtr));
		}

		// Token: 0x0600670D RID: 26381 RVA: 0x00094338 File Offset: 0x00092538
		[NullableContext(1)]
		public TArray<UActorComponent> K2_GetComponentsByClass([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UActorComponent> ComponentClass)
		{
			return new TArray<UActorComponent>(AActor.__K2_GetComponentsByClass_Internal(base.NativePtr, ComponentClass._NativePtr), null);
		}

		// Token: 0x0600670E RID: 26382 RVA: 0x00094351 File Offset: 0x00092551
		public FRotator K2_GetActorRotation()
		{
			return AActor.__K2_GetActorRotation_Internal(base.NativePtr);
		}

		// Token: 0x0600670F RID: 26383 RVA: 0x0009435E File Offset: 0x0009255E
		public FQuat K2_GetActorQuaternion()
		{
			return AActor.__K2_GetActorQuaternion_Internal(base.NativePtr);
		}

		// Token: 0x06006710 RID: 26384 RVA: 0x0009436B File Offset: 0x0009256B
		public FVector K2_GetActorLocation()
		{
			return AActor.__K2_GetActorLocation_Internal(base.NativePtr);
		}

		// Token: 0x06006711 RID: 26385 RVA: 0x00094378 File Offset: 0x00092578
		public void K2_DetachFromActor(EDetachmentRule LocationRule = EDetachmentRule.KeepRelative, EDetachmentRule RotationRule = EDetachmentRule.KeepRelative, EDetachmentRule ScaleRule = EDetachmentRule.KeepRelative)
		{
			AActor.__K2_DetachFromActor_Internal(base.NativePtr, LocationRule, RotationRule, ScaleRule);
		}

		// Token: 0x06006712 RID: 26386 RVA: 0x00094388 File Offset: 0x00092588
		public void K2_DestroyComponent(UActorComponent Component)
		{
			AActor.__K2_DestroyComponent_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006713 RID: 26387 RVA: 0x000943A5 File Offset: 0x000925A5
		public void K2_DestroyActor()
		{
			AActor.__K2_DestroyActor_Internal(base.NativePtr);
		}

		// Token: 0x06006714 RID: 26388 RVA: 0x000943B2 File Offset: 0x000925B2
		public void K2_AttachToComponent(USceneComponent Parent, FName SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies, bool bCalcWorldOrigin = true)
		{
			AActor.__K2_AttachToComponent_Internal(base.NativePtr, (Parent != null) ? Parent.NativePtr : IntPtr.Zero, SocketName, LocationRule, RotationRule, ScaleRule, bWeldSimulatedBodies, bCalcWorldOrigin);
		}

		// Token: 0x06006715 RID: 26389 RVA: 0x000943D9 File Offset: 0x000925D9
		public void K2_AttachToActor(AActor ParentActor, FName SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies, bool bCalcWorldOrigin = true)
		{
			AActor.__K2_AttachToActor_Internal(base.NativePtr, (ParentActor != null) ? ParentActor.NativePtr : IntPtr.Zero, SocketName, LocationRule, RotationRule, ScaleRule, bWeldSimulatedBodies, bCalcWorldOrigin);
		}

		// Token: 0x06006716 RID: 26390 RVA: 0x00094400 File Offset: 0x00092600
		public void K2_AttachRootComponentToActor(AActor InParentActor, FName InSocketName = default(FName), EAttachLocation AttachLocationType = EAttachLocation.KeepRelativeOffset, bool bWeldSimulatedBodies = true)
		{
			AActor.__K2_AttachRootComponentToActor_Internal(base.NativePtr, (InParentActor != null) ? InParentActor.NativePtr : IntPtr.Zero, InSocketName, AttachLocationType, bWeldSimulatedBodies);
		}

		// Token: 0x06006717 RID: 26391 RVA: 0x00094426 File Offset: 0x00092626
		public void K2_AttachRootComponentTo(USceneComponent InParent, FName InSocketName = default(FName), EAttachLocation AttachLocationType = EAttachLocation.KeepRelativeOffset, bool bWeldSimulatedBodies = true)
		{
			AActor.__K2_AttachRootComponentTo_Internal(base.NativePtr, (InParent != null) ? InParent.NativePtr : IntPtr.Zero, InSocketName, AttachLocationType, bWeldSimulatedBodies);
		}

		// Token: 0x06006718 RID: 26392 RVA: 0x0009444C File Offset: 0x0009264C
		public unsafe void K2_AddActorWorldTransformKeepScale(in FTransform DeltaTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = DeltaTransform;
			AActor.__K2_AddActorWorldTransformKeepScale_Internal(base.NativePtr, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06006719 RID: 26393 RVA: 0x00094494 File Offset: 0x00092694
		public unsafe void K2_AddActorWorldTransform(in FTransform DeltaTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = DeltaTransform;
			AActor.__K2_AddActorWorldTransform_Internal(base.NativePtr, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x0600671A RID: 26394 RVA: 0x000944DC File Offset: 0x000926DC
		public void K2_AddActorWorldRotation(FRotator DeltaRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			AActor.__K2_AddActorWorldRotation_Internal(base.NativePtr, DeltaRotation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x0600671B RID: 26395 RVA: 0x000944FD File Offset: 0x000926FD
		public void K2_AddActorWorldOffset(FVector DeltaLocation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			AActor.__K2_AddActorWorldOffset_Internal(base.NativePtr, DeltaLocation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x0600671C RID: 26396 RVA: 0x00094520 File Offset: 0x00092720
		public unsafe void K2_AddActorLocalTransform(in FTransform NewTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = NewTransform;
			AActor.__K2_AddActorLocalTransform_Internal(base.NativePtr, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x0600671D RID: 26397 RVA: 0x00094568 File Offset: 0x00092768
		public void K2_AddActorLocalRotation(FRotator DeltaRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			AActor.__K2_AddActorLocalRotation_Internal(base.NativePtr, DeltaRotation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x0600671E RID: 26398 RVA: 0x00094589 File Offset: 0x00092789
		public void K2_AddActorLocalOffset(FVector DeltaLocation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			AActor.__K2_AddActorLocalOffset_Internal(base.NativePtr, DeltaLocation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x0600671F RID: 26399 RVA: 0x000945AA File Offset: 0x000927AA
		public bool IsUEOrignal()
		{
			return AActor.__IsUEOrignal_Internal(base.NativePtr);
		}

		// Token: 0x06006720 RID: 26400 RVA: 0x000945B7 File Offset: 0x000927B7
		public bool IsOverlappingActor(AActor Other)
		{
			return AActor.__IsOverlappingActor_Internal(base.NativePtr, (Other != null) ? Other.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006721 RID: 26401 RVA: 0x000945D4 File Offset: 0x000927D4
		public bool IsIgnoreUpdateOverlap()
		{
			return AActor.__IsIgnoreUpdateOverlap_Internal(base.NativePtr);
		}

		// Token: 0x06006722 RID: 26402 RVA: 0x000945E1 File Offset: 0x000927E1
		public bool IsChildActor()
		{
			return AActor.__IsChildActor_Internal(base.NativePtr);
		}

		// Token: 0x06006723 RID: 26403 RVA: 0x000945EE File Offset: 0x000927EE
		public bool IsAutonomousProxy()
		{
			return AActor.__IsAutonomousProxy_Internal(base.NativePtr);
		}

		// Token: 0x06006724 RID: 26404 RVA: 0x000945FB File Offset: 0x000927FB
		public bool IsActorTickEnabled()
		{
			return AActor.__IsActorTickEnabled_Internal(base.NativePtr);
		}

		// Token: 0x06006725 RID: 26405 RVA: 0x00094608 File Offset: 0x00092808
		public bool IsActorBeingDestroyed()
		{
			return AActor.__IsActorBeingDestroyed_Internal(base.NativePtr);
		}

		// Token: 0x06006726 RID: 26406 RVA: 0x00094615 File Offset: 0x00092815
		public void IgnoreActorWhenMoving(AActor Actor, bool bShouldIgnore, bool bBoth)
		{
			AActor.__IgnoreActorWhenMoving_Internal(base.NativePtr, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, bShouldIgnore, bBoth);
		}

		// Token: 0x06006727 RID: 26407 RVA: 0x00094634 File Offset: 0x00092834
		public bool HasAuthority()
		{
			return AActor.__HasAuthority_Internal(base.NativePtr);
		}

		// Token: 0x06006728 RID: 26408 RVA: 0x00094641 File Offset: 0x00092841
		public float GetVerticalDistanceTo(AActor OtherActor)
		{
			return AActor.__GetVerticalDistanceTo_Internal(base.NativePtr, (OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006729 RID: 26409 RVA: 0x0009465E File Offset: 0x0009285E
		public FVector GetVelocity()
		{
			return AActor.__GetVelocity_Internal(base.NativePtr);
		}

		// Token: 0x0600672A RID: 26410 RVA: 0x0009466B File Offset: 0x0009286B
		public FTransform GetTransformWithUpdate()
		{
			return AActor.__GetTransformWithUpdate_Internal(base.NativePtr);
		}

		// Token: 0x0600672B RID: 26411 RVA: 0x00094678 File Offset: 0x00092878
		public FTransform GetTransform()
		{
			return AActor.__GetTransform_Internal(base.NativePtr);
		}

		// Token: 0x0600672C RID: 26412 RVA: 0x00094685 File Offset: 0x00092885
		public bool GetTickableWhenPaused()
		{
			return AActor.__GetTickableWhenPaused_Internal(base.NativePtr);
		}

		// Token: 0x0600672D RID: 26413 RVA: 0x00094692 File Offset: 0x00092892
		public float GetSquaredHorizontalDistanceTo(AActor OtherActor)
		{
			return AActor.__GetSquaredHorizontalDistanceTo_Internal(base.NativePtr, (OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600672E RID: 26414 RVA: 0x000946AF File Offset: 0x000928AF
		public float GetSquaredDistanceTo(AActor OtherActor)
		{
			return AActor.__GetSquaredDistanceTo_Internal(base.NativePtr, (OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600672F RID: 26415 RVA: 0x000946CC File Offset: 0x000928CC
		[NullableContext(0)]
		public TEnumAsByte<ENetRole> GetRemoteRole()
		{
			return AActor.__GetRemoteRole_Internal(base.NativePtr);
		}

		// Token: 0x06006730 RID: 26416 RVA: 0x000946D9 File Offset: 0x000928D9
		public uint GetPrimitiveEntityType()
		{
			return AActor.__GetPrimitiveEntityType_Internal(base.NativePtr);
		}

		// Token: 0x06006731 RID: 26417 RVA: 0x000946E6 File Offset: 0x000928E6
		public FName GetPrimitiveBlueprintTypeName()
		{
			return AActor.__GetPrimitiveBlueprintTypeName_Internal(base.NativePtr);
		}

		// Token: 0x06006732 RID: 26418 RVA: 0x000946F3 File Offset: 0x000928F3
		public UChildActorComponent GetParentComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UChildActorComponent>(AActor.__GetParentComponent_Internal(base.NativePtr));
		}

		// Token: 0x06006733 RID: 26419 RVA: 0x00094705 File Offset: 0x00092905
		public AActor GetParentActor()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(AActor.__GetParentActor_Internal(base.NativePtr));
		}

		// Token: 0x06006734 RID: 26420 RVA: 0x00094717 File Offset: 0x00092917
		public AActor GetOwner()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(AActor.__GetOwner_Internal(base.NativePtr));
		}

		// Token: 0x06006735 RID: 26421 RVA: 0x00094729 File Offset: 0x00092929
		public void GetOverlappingComponents([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UPrimitiveComponent> OverlappingComponents)
		{
			AActor.__GetOverlappingComponents_Internal(base.NativePtr, (OverlappingComponents ?? new TArray<UPrimitiveComponent>()).NativePtr);
		}

		// Token: 0x06006736 RID: 26422 RVA: 0x00094746 File Offset: 0x00092946
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

		// Token: 0x06006737 RID: 26423 RVA: 0x00094769 File Offset: 0x00092969
		[NullableContext(0)]
		public TEnumAsByte<ENetRole> GetLocalRole()
		{
			return AActor.__GetLocalRole_Internal(base.NativePtr);
		}

		// Token: 0x06006738 RID: 26424 RVA: 0x00094776 File Offset: 0x00092976
		public float GetLifeSpan()
		{
			return AActor.__GetLifeSpan_Internal(base.NativePtr);
		}

		// Token: 0x06006739 RID: 26425 RVA: 0x00094783 File Offset: 0x00092983
		public FTransform GetLevelTransform()
		{
			return AActor.__GetLevelTransform_Internal(base.NativePtr);
		}

		// Token: 0x0600673A RID: 26426 RVA: 0x00094790 File Offset: 0x00092990
		public ULevel GetLevel()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevel>(AActor.__GetLevel_Internal(base.NativePtr));
		}

		// Token: 0x0600673B RID: 26427
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern TEnumAsByte<EKuroNetMode> GetKuroNetMode();

		// Token: 0x0600673C RID: 26428 RVA: 0x000947A2 File Offset: 0x000929A2
		public FTransform GetInverseTransform()
		{
			return AActor.__GetInverseTransform_Internal(base.NativePtr);
		}

		// Token: 0x0600673D RID: 26429 RVA: 0x000947AF File Offset: 0x000929AF
		public AController GetInstigatorController()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AController>(AActor.__GetInstigatorController_Internal(base.NativePtr));
		}

		// Token: 0x0600673E RID: 26430 RVA: 0x000947C1 File Offset: 0x000929C1
		public APawn GetInstigator()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(AActor.__GetInstigator_Internal(base.NativePtr));
		}

		// Token: 0x0600673F RID: 26431 RVA: 0x000947D3 File Offset: 0x000929D3
		public FVector GetInputVectorAxisValue(FKey InputAxisKey)
		{
			return AActor.__GetInputVectorAxisValue_Internal(base.NativePtr, (InputAxisKey ?? new FKey()).NativePtr);
		}

		// Token: 0x06006740 RID: 26432 RVA: 0x000947EF File Offset: 0x000929EF
		public float GetInputAxisValue(FName InputAxisName)
		{
			return AActor.__GetInputAxisValue_Internal(base.NativePtr, InputAxisName);
		}

		// Token: 0x06006741 RID: 26433 RVA: 0x000947FD File Offset: 0x000929FD
		public float GetInputAxisKeyValue(FKey InputAxisKey)
		{
			return AActor.__GetInputAxisKeyValue_Internal(base.NativePtr, (InputAxisKey ?? new FKey()).NativePtr);
		}

		// Token: 0x06006742 RID: 26434 RVA: 0x00094819 File Offset: 0x00092A19
		public float GetHorizontalDotProductTo(AActor OtherActor)
		{
			return AActor.__GetHorizontalDotProductTo_Internal(base.NativePtr, (OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006743 RID: 26435 RVA: 0x00094836 File Offset: 0x00092A36
		public float GetHorizontalDistanceTo(AActor OtherActor)
		{
			return AActor.__GetHorizontalDistanceTo_Internal(base.NativePtr, (OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006744 RID: 26436 RVA: 0x00094853 File Offset: 0x00092A53
		public float GetGameTimeSinceCreation()
		{
			return AActor.__GetGameTimeSinceCreation_Internal(base.NativePtr);
		}

		// Token: 0x06006745 RID: 26437 RVA: 0x00094860 File Offset: 0x00092A60
		public float GetDotProductTo(AActor OtherActor)
		{
			return AActor.__GetDotProductTo_Internal(base.NativePtr, (OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006746 RID: 26438 RVA: 0x0009487D File Offset: 0x00092A7D
		public float GetDistanceTo(AActor OtherActor)
		{
			return AActor.__GetDistanceTo_Internal(base.NativePtr, (OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006747 RID: 26439 RVA: 0x0009489A File Offset: 0x00092A9A
		[NullableContext(1)]
		public TArray<UActorComponent> GetComponentsByTag([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UActorComponent> ComponentClass, FName Tag)
		{
			return new TArray<UActorComponent>(AActor.__GetComponentsByTag_Internal(base.NativePtr, ComponentClass._NativePtr, Tag), null);
		}

		// Token: 0x06006748 RID: 26440 RVA: 0x000948B4 File Offset: 0x00092AB4
		[NullableContext(1)]
		public TArray<UActorComponent> GetComponentsByInterface(UClassStackOnlyPtr Interface)
		{
			return new TArray<UActorComponent>(AActor.__GetComponentsByInterface_Internal(base.NativePtr, Interface._NativePtr), null);
		}

		// Token: 0x06006749 RID: 26441 RVA: 0x000948CD File Offset: 0x00092ACD
		public UActorComponent GetComponentByClass([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UActorComponent> ComponentClass)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UActorComponent>(AActor.__GetComponentByClass_Internal(base.NativePtr, ComponentClass._NativePtr));
		}

		// Token: 0x0600674A RID: 26442 RVA: 0x000948E5 File Offset: 0x00092AE5
		public AActor GetAttachRootParentActor()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(AActor.__GetAttachRootParentActor_Internal(base.NativePtr));
		}

		// Token: 0x0600674B RID: 26443 RVA: 0x000948F7 File Offset: 0x00092AF7
		public FName GetAttachParentSocketName()
		{
			return AActor.__GetAttachParentSocketName_Internal(base.NativePtr);
		}

		// Token: 0x0600674C RID: 26444 RVA: 0x00094904 File Offset: 0x00092B04
		public AActor GetAttachParentActor()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(AActor.__GetAttachParentActor_Internal(base.NativePtr));
		}

		// Token: 0x0600674D RID: 26445 RVA: 0x00094916 File Offset: 0x00092B16
		public void GetAttachedActors([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<AActor> OutActors, bool bResetArray = true)
		{
			AActor.__GetAttachedActors_Internal(base.NativePtr, (OutActors ?? new TArray<AActor>()).NativePtr, bResetArray);
		}

		// Token: 0x0600674E RID: 26446 RVA: 0x00094934 File Offset: 0x00092B34
		public void GetAttachedActorDescendants([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<AActor> OutActors, bool bResetArray = true)
		{
			AActor.__GetAttachedActorDescendants_Internal(base.NativePtr, (OutActors ?? new TArray<AActor>()).NativePtr, bResetArray);
		}

		// Token: 0x0600674F RID: 26447 RVA: 0x00094952 File Offset: 0x00092B52
		public void GetAllChildActors([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<AActor> ChildActors, bool bIncludeDescendants = true)
		{
			AActor.__GetAllChildActors_Internal(base.NativePtr, (ChildActors ?? new TArray<AActor>()).NativePtr, bIncludeDescendants);
		}

		// Token: 0x06006750 RID: 26448 RVA: 0x00094970 File Offset: 0x00092B70
		public FVector GetActorUpVector()
		{
			return AActor.__GetActorUpVector_Internal(base.NativePtr);
		}

		// Token: 0x06006751 RID: 26449 RVA: 0x0009497D File Offset: 0x00092B7D
		public float GetActorTimeDilation()
		{
			return AActor.__GetActorTimeDilation_Internal(base.NativePtr);
		}

		// Token: 0x06006752 RID: 26450 RVA: 0x0009498A File Offset: 0x00092B8A
		public float GetActorTickInterval()
		{
			return AActor.__GetActorTickInterval_Internal(base.NativePtr);
		}

		// Token: 0x06006753 RID: 26451 RVA: 0x00094997 File Offset: 0x00092B97
		public FVector GetActorScale3D()
		{
			return AActor.__GetActorScale3D_Internal(base.NativePtr);
		}

		// Token: 0x06006754 RID: 26452 RVA: 0x000949A4 File Offset: 0x00092BA4
		public FVector GetActorRightVector()
		{
			return AActor.__GetActorRightVector_Internal(base.NativePtr);
		}

		// Token: 0x06006755 RID: 26453 RVA: 0x000949B1 File Offset: 0x00092BB1
		public FVector GetActorRelativeScale3D()
		{
			return AActor.__GetActorRelativeScale3D_Internal(base.NativePtr);
		}

		// Token: 0x06006756 RID: 26454 RVA: 0x000949BE File Offset: 0x00092BBE
		public FVector GetActorForwardVector()
		{
			return AActor.__GetActorForwardVector_Internal(base.NativePtr);
		}

		// Token: 0x06006757 RID: 26455 RVA: 0x000949CC File Offset: 0x00092BCC
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

		// Token: 0x06006758 RID: 26456 RVA: 0x000949F7 File Offset: 0x00092BF7
		public bool GetActorEnableCollision()
		{
			return AActor.__GetActorEnableCollision_Internal(base.NativePtr);
		}

		// Token: 0x06006759 RID: 26457 RVA: 0x00094A04 File Offset: 0x00092C04
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

		// Token: 0x0600675A RID: 26458 RVA: 0x00094A31 File Offset: 0x00092C31
		public void ForceNetUpdate()
		{
			AActor.__ForceNetUpdate_Internal(base.NativePtr);
		}

		// Token: 0x0600675B RID: 26459 RVA: 0x00094A3E File Offset: 0x00092C3E
		public void FlushNetDormancy()
		{
			AActor.__FlushNetDormancy_Internal(base.NativePtr);
		}

		// Token: 0x0600675C RID: 26460 RVA: 0x00094A4C File Offset: 0x00092C4C
		public unsafe void FinishAddComponent(UActorComponent Component, bool bManualAttachment, in FTransform RelativeTransform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = RelativeTransform;
			AActor.__FinishAddComponent_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero, bManualAttachment, ptr);
		}

		// Token: 0x0600675D RID: 26461 RVA: 0x00094A92 File Offset: 0x00092C92
		public void EnableInput(APlayerController PlayerController)
		{
			AActor.__EnableInput_Internal(base.NativePtr, (PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600675E RID: 26462 RVA: 0x00094AAF File Offset: 0x00092CAF
		public void DisableInput(APlayerController PlayerController)
		{
			AActor.__DisableInput_Internal(base.NativePtr, (PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600675F RID: 26463 RVA: 0x00094ACC File Offset: 0x00092CCC
		public void DetachRootComponentFromParent(bool bMaintainWorldPosition = true)
		{
			AActor.__DetachRootComponentFromParent_Internal(base.NativePtr, bMaintainWorldPosition);
		}

		// Token: 0x06006760 RID: 26464 RVA: 0x00094ADA File Offset: 0x00092CDA
		public void D_SetActorScale3D(FVectorDouble NewScale3D)
		{
			AActor.__D_SetActorScale3D_Internal(base.NativePtr, NewScale3D);
		}

		// Token: 0x06006761 RID: 26465 RVA: 0x00094AE8 File Offset: 0x00092CE8
		public bool D_K2_TeleportTo(FVectorDouble DestLocation, FRotator DestRotation)
		{
			return AActor.__D_K2_TeleportTo_Internal(base.NativePtr, DestLocation, DestRotation);
		}

		// Token: 0x06006762 RID: 26466 RVA: 0x00094AF8 File Offset: 0x00092CF8
		public unsafe bool D_K2_SetActorTransformForce(in FTransformDouble NewTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = NewTransform;
			return AActor.__D_K2_SetActorTransformForce_Internal(base.NativePtr, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06006763 RID: 26467 RVA: 0x00094B40 File Offset: 0x00092D40
		public unsafe bool D_K2_SetActorTransform(in FTransformDouble NewTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = NewTransform;
			return AActor.__D_K2_SetActorTransform_Internal(base.NativePtr, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06006764 RID: 26468 RVA: 0x00094B88 File Offset: 0x00092D88
		public unsafe void D_K2_SetActorRelativeTransform(in FTransformDouble NewRelativeTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = NewRelativeTransform;
			AActor.__D_K2_SetActorRelativeTransform_Internal(base.NativePtr, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06006765 RID: 26469 RVA: 0x00094BD0 File Offset: 0x00092DD0
		public void D_K2_SetActorRelativeLocation(FVectorDouble NewRelativeLocation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			AActor.__D_K2_SetActorRelativeLocation_Internal(base.NativePtr, NewRelativeLocation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06006766 RID: 26470 RVA: 0x00094BF1 File Offset: 0x00092DF1
		public bool D_K2_SetActorLocationAndRotation(FVectorDouble NewLocation, FRotator NewRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			return AActor.__D_K2_SetActorLocationAndRotation_Internal(base.NativePtr, NewLocation, NewRotation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06006767 RID: 26471 RVA: 0x00094C14 File Offset: 0x00092E14
		public bool D_K2_SetActorLocation(FVectorDouble NewLocation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			return AActor.__D_K2_SetActorLocation_Internal(base.NativePtr, NewLocation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x06006768 RID: 26472 RVA: 0x00094C35 File Offset: 0x00092E35
		public bool D_K2_KuroTeleportTo(FVectorDouble DestLocation, FRotator DestRotation)
		{
			return AActor.__D_K2_KuroTeleportTo_Internal(base.NativePtr, DestLocation, DestRotation);
		}

		// Token: 0x06006769 RID: 26473 RVA: 0x00094C44 File Offset: 0x00092E44
		public FVectorDouble D_K2_GetActorLocation()
		{
			return AActor.__D_K2_GetActorLocation_Internal(base.NativePtr);
		}

		// Token: 0x0600676A RID: 26474 RVA: 0x00094C54 File Offset: 0x00092E54
		public unsafe void D_K2_AddActorWorldTransform(in FTransformDouble DeltaTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = DeltaTransform;
			AActor.__D_K2_AddActorWorldTransform_Internal(base.NativePtr, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x0600676B RID: 26475 RVA: 0x00094C9C File Offset: 0x00092E9C
		public void D_K2_AddActorWorldOffset(FVectorDouble DeltaLocation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			AActor.__D_K2_AddActorWorldOffset_Internal(base.NativePtr, DeltaLocation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x0600676C RID: 26476 RVA: 0x00094CC0 File Offset: 0x00092EC0
		public unsafe void D_K2_AddActorLocalTransform(in FTransformDouble NewTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = NewTransform;
			AActor.__D_K2_AddActorLocalTransform_Internal(base.NativePtr, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x0600676D RID: 26477 RVA: 0x00094D08 File Offset: 0x00092F08
		public void D_K2_AddActorLocalOffset(FVectorDouble DeltaLocation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			AActor.__D_K2_AddActorLocalOffset_Internal(base.NativePtr, DeltaLocation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x0600676E RID: 26478 RVA: 0x00094D29 File Offset: 0x00092F29
		public FVectorDouble D_GetVelocity()
		{
			return AActor.__D_GetVelocity_Internal(base.NativePtr);
		}

		// Token: 0x0600676F RID: 26479 RVA: 0x00094D36 File Offset: 0x00092F36
		public FTransformDouble D_GetTransformWithUpdate()
		{
			return AActor.__D_GetTransformWithUpdate_Internal(base.NativePtr);
		}

		// Token: 0x06006770 RID: 26480 RVA: 0x00094D43 File Offset: 0x00092F43
		public FTransformDouble D_GetTransform()
		{
			return AActor.__D_GetTransform_Internal(base.NativePtr);
		}

		// Token: 0x06006771 RID: 26481 RVA: 0x00094D50 File Offset: 0x00092F50
		public FTransformDouble D_GetInverseTransform()
		{
			return AActor.__D_GetInverseTransform_Internal(base.NativePtr);
		}

		// Token: 0x06006772 RID: 26482 RVA: 0x00094D5D File Offset: 0x00092F5D
		public double D_GetGameTimeSinceCreation()
		{
			return AActor.__D_GetGameTimeSinceCreation_Internal(base.NativePtr);
		}

		// Token: 0x06006773 RID: 26483 RVA: 0x00094D6A File Offset: 0x00092F6A
		public double D_GetDistanceTo(AActor OtherActor)
		{
			return AActor.__D_GetDistanceTo_Internal(base.NativePtr, (OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006774 RID: 26484 RVA: 0x00094D87 File Offset: 0x00092F87
		public FVectorDouble D_GetActorUpVector()
		{
			return AActor.__D_GetActorUpVector_Internal(base.NativePtr);
		}

		// Token: 0x06006775 RID: 26485 RVA: 0x00094D94 File Offset: 0x00092F94
		public FVectorDouble D_GetActorScale3D()
		{
			return AActor.__D_GetActorScale3D_Internal(base.NativePtr);
		}

		// Token: 0x06006776 RID: 26486 RVA: 0x00094DA1 File Offset: 0x00092FA1
		public FVectorDouble D_GetActorRightVector()
		{
			return AActor.__D_GetActorRightVector_Internal(base.NativePtr);
		}

		// Token: 0x06006777 RID: 26487 RVA: 0x00094DAE File Offset: 0x00092FAE
		public FVectorDouble D_GetActorForwardVector()
		{
			return AActor.__D_GetActorForwardVector_Internal(base.NativePtr);
		}

		// Token: 0x06006778 RID: 26488 RVA: 0x00094DBC File Offset: 0x00092FBC
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

		// Token: 0x06006779 RID: 26489 RVA: 0x00094DEC File Offset: 0x00092FEC
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

		// Token: 0x0600677A RID: 26490 RVA: 0x00094E31 File Offset: 0x00093031
		public void ClearMoveIgnoreActors(bool bClearBoth)
		{
			AActor.__ClearMoveIgnoreActors_Internal(base.NativePtr, bClearBoth);
		}

		// Token: 0x0600677B RID: 26491 RVA: 0x00094E3F File Offset: 0x0009303F
		public void AddTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
		{
			AActor.__AddTickPrerequisiteComponent_Internal(base.NativePtr, (PrerequisiteComponent != null) ? PrerequisiteComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600677C RID: 26492 RVA: 0x00094E5C File Offset: 0x0009305C
		public void AddTickPrerequisiteActor(AActor PrerequisiteActor)
		{
			AActor.__AddTickPrerequisiteActor_Internal(base.NativePtr, (PrerequisiteActor != null) ? PrerequisiteActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600677D RID: 26493 RVA: 0x00094E7C File Offset: 0x0009307C
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

		// Token: 0x0600677E RID: 26494 RVA: 0x00094EC4 File Offset: 0x000930C4
		public unsafe UActorComponent AddComponent(FName TemplateName, bool bManualAttachment, in FTransform RelativeTransform, UObject ComponentTemplateContext, bool bDeferredFinish = false)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = RelativeTransform;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UActorComponent>(AActor.__AddComponent_Internal(base.NativePtr, TemplateName, bManualAttachment, ptr, (ComponentTemplateContext != null) ? ComponentTemplateContext.NativePtr : IntPtr.Zero, bDeferredFinish));
		}

		// Token: 0x0600677F RID: 26495 RVA: 0x00094F14 File Offset: 0x00093114
		public bool ActorHasTag(FName Tag)
		{
			return AActor.__ActorHasTag_Internal(base.NativePtr, Tag);
		}

		// Token: 0x06006780 RID: 26496
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __WasRecentlyRenderedOnScreen_Internal(IntPtr @this, float Tolerance);

		// Token: 0x06006781 RID: 26497
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __WasRecentlyRendered_Internal(IntPtr @this, float Tolerance);

		// Token: 0x06006782 RID: 26498
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __WasRecentlyPassVisibilityTest_Internal(IntPtr @this, float Tolerance);

		// Token: 0x06006783 RID: 26499
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UserConstructionScript_Internal(IntPtr @this);

		// Token: 0x06006784 RID: 26500
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TearOff_Internal(IntPtr @this);

		// Token: 0x06006785 RID: 26501
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SnapRootComponentTo_Internal(IntPtr @this, IntPtr InParentActor, FName InSocketName);

		// Token: 0x06006786 RID: 26502
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTickGroup_Internal(IntPtr @this, TEnumAsByte<ETickingGroup> NewTickGroup);

		// Token: 0x06006787 RID: 26503
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTickableWhenPaused_Internal(IntPtr @this, bool bTickableWhenPaused);

		// Token: 0x06006788 RID: 26504
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetReplicates_Internal(IntPtr @this, bool bInReplicates);

		// Token: 0x06006789 RID: 26505
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetReplicateMovement_Internal(IntPtr @this, bool bInReplicateMovement);

		// Token: 0x0600678A RID: 26506
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPrimitiveEntityType_Internal(IntPtr @this, uint type);

		// Token: 0x0600678B RID: 26507
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPrimitiveBlueprintTypeName_Internal(IntPtr @this, FName Name);

		// Token: 0x0600678C RID: 26508
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOwner_Internal(IntPtr @this, IntPtr NewOwner);

		// Token: 0x0600678D RID: 26509
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNetDormancy_Internal(IntPtr @this, TEnumAsByte<ENetDormancy> NewDormancy);

		// Token: 0x0600678E RID: 26510
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLifeSpan_Internal(IntPtr @this, float InLifespan);

		// Token: 0x0600678F RID: 26511
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroOnlyTickOutside_Internal(IntPtr @this, bool OnlyTickOutside);

		// Token: 0x06006790 RID: 26512
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsIgnoreUpdateOverlap_Internal(IntPtr @this, bool bShouldIgnoreUpdateOverlap);

		// Token: 0x06006791 RID: 26513
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetForceHidden_Internal(IntPtr @this, bool bForce);

		// Token: 0x06006792 RID: 26514
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAutoDestroyWhenFinished_Internal(IntPtr @this, bool bVal);

		// Token: 0x06006793 RID: 26515
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetActorViewableInRender_Internal(IntPtr @this, bool bNewViewable);

		// Token: 0x06006794 RID: 26516
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetActorTickInterval_Internal(IntPtr @this, float TickInterval);

		// Token: 0x06006795 RID: 26517
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetActorTickEnabled_Internal(IntPtr @this, bool bEnabled);

		// Token: 0x06006796 RID: 26518
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetActorScale3D_Internal(IntPtr @this, FVector NewScale3D);

		// Token: 0x06006797 RID: 26519
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetActorRelativeScale3D_Internal(IntPtr @this, FVector NewRelativeScale);

		// Token: 0x06006798 RID: 26520
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetActorHiddenInGame_Internal(IntPtr @this, bool bNewHidden);

		// Token: 0x06006799 RID: 26521
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetActorEnableCollision_Internal(IntPtr @this, bool bNewActorEnableCollision);

		// Token: 0x0600679A RID: 26522
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveTickPrerequisiteComponent_Internal(IntPtr @this, IntPtr PrerequisiteComponent);

		// Token: 0x0600679B RID: 26523
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveTickPrerequisiteActor_Internal(IntPtr @this, IntPtr PrerequisiteActor);

		// Token: 0x0600679C RID: 26524
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveTick_Internal(IntPtr @this, float DeltaSeconds);

		// Token: 0x0600679D RID: 26525
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveRadialDamage_Internal(IntPtr @this, float DamageReceived, IntPtr DamageType, FVector Origin, IntPtr HitInfo, IntPtr InstigatedBy, IntPtr DamageCauser);

		// Token: 0x0600679E RID: 26526
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceivePointDamage_Internal(IntPtr @this, float Damage, IntPtr DamageType, FVector HitLocation, FVector HitNormal, IntPtr HitComponent, FName BoneName, FVector ShotFromDirection, IntPtr InstigatedBy, IntPtr DamageCauser, IntPtr HitInfo);

		// Token: 0x0600679F RID: 26527
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveHit_Internal(IntPtr @this, IntPtr MyComp, IntPtr Other, IntPtr OtherComp, bool bSelfMoved, FVector HitLocation, FVector HitNormal, FVector NormalImpulse, IntPtr Hit);

		// Token: 0x060067A0 RID: 26528
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveEndPlay_Internal(IntPtr @this, TEnumAsByte<EEndPlayReason> EndPlayReason);

		// Token: 0x060067A1 RID: 26529
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveDestroyed_Internal(IntPtr @this);

		// Token: 0x060067A2 RID: 26530
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveBeginPlay_Internal(IntPtr @this);

		// Token: 0x060067A3 RID: 26531
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveAnyDamage_Internal(IntPtr @this, float Damage, IntPtr DamageType, IntPtr InstigatedBy, IntPtr DamageCauser);

		// Token: 0x060067A4 RID: 26532
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveActorOnReleased_Internal(IntPtr @this, IntPtr ButtonReleased);

		// Token: 0x060067A5 RID: 26533
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveActorOnInputTouchLeave_Internal(IntPtr @this, TEnumAsByte<ETouchIndex> FingerIndex);

		// Token: 0x060067A6 RID: 26534
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveActorOnInputTouchEnter_Internal(IntPtr @this, TEnumAsByte<ETouchIndex> FingerIndex);

		// Token: 0x060067A7 RID: 26535
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveActorOnInputTouchEnd_Internal(IntPtr @this, TEnumAsByte<ETouchIndex> FingerIndex);

		// Token: 0x060067A8 RID: 26536
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveActorOnInputTouchBegin_Internal(IntPtr @this, TEnumAsByte<ETouchIndex> FingerIndex);

		// Token: 0x060067A9 RID: 26537
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveActorOnClicked_Internal(IntPtr @this, IntPtr ButtonPressed);

		// Token: 0x060067AA RID: 26538
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveActorEndOverlap_Internal(IntPtr @this, IntPtr OtherActor);

		// Token: 0x060067AB RID: 26539
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveActorEndCursorOver_Internal(IntPtr @this);

		// Token: 0x060067AC RID: 26540
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveActorBeginOverlap_Internal(IntPtr @this, IntPtr OtherActor);

		// Token: 0x060067AD RID: 26541
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveActorBeginCursorOver_Internal(IntPtr @this);

		// Token: 0x060067AE RID: 26542
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PrestreamTextures_Internal(IntPtr @this, float Seconds, bool bEnableStreaming, int CinematicTextureGroups);

		// Token: 0x060067AF RID: 26543
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_ReplicateMovement_Internal(IntPtr @this);

		// Token: 0x060067B0 RID: 26544
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_ReplicatedMovement_Internal(IntPtr @this);

		// Token: 0x060067B1 RID: 26545
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_Owner_Internal(IntPtr @this);

		// Token: 0x060067B2 RID: 26546
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_Instigator_Internal(IntPtr @this);

		// Token: 0x060067B3 RID: 26547
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_AttachmentReplication_Internal(IntPtr @this);

		// Token: 0x060067B4 RID: 26548
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MakeNoise_Internal(IntPtr @this, float Loudness, IntPtr NoiseInstigator, FVector NoiseLocation, float MaxRange, FName Tag);

		// Token: 0x060067B5 RID: 26549
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeMIDForMaterial_Internal(IntPtr @this, IntPtr Parent);

		// Token: 0x060067B6 RID: 26550
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroTickActorOutside_Internal(IntPtr @this, float DeltaSeconds);

		// Token: 0x060067B7 RID: 26551
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Kuro_SetRole_Internal(IntPtr @this, TEnumAsByte<EKuroNetRole> InRole);

		// Token: 0x060067B8 RID: 26552
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Kuro_SetReplicatedMovement_Internal(IntPtr @this, IntPtr InReplicatedMovement);

		// Token: 0x060067B9 RID: 26553
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Kuro_OnRep_ReplicatedMovement_Internal(IntPtr @this);

		// Token: 0x060067BA RID: 26554
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Kuro_GetReplicatedMovement_Internal(IntPtr @this);

		// Token: 0x060067BB RID: 26555
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<EKuroNetRole> __Kuro_GetLocalRole_Internal(IntPtr @this);

		// Token: 0x060067BC RID: 26556
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_TeleportTo_Internal(IntPtr @this, FVector DestLocation, FRotator DestRotation);

		// Token: 0x060067BD RID: 26557
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_SetDeferedConcurrentUpdateTransform_Internal(IntPtr @this, bool bEnable);

		// Token: 0x060067BE RID: 26558
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_SetActorTransformForce_Internal(IntPtr @this, in FTransform NewTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060067BF RID: 26559
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_SetActorTransform_Internal(IntPtr @this, in FTransform NewTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060067C0 RID: 26560
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_SetActorRotation_Internal(IntPtr @this, FRotator NewRotation, bool bTeleportPhysics);

		// Token: 0x060067C1 RID: 26561
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_SetActorRelativeTransform_Internal(IntPtr @this, in FTransform NewRelativeTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060067C2 RID: 26562
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_SetActorRelativeRotation_Internal(IntPtr @this, FRotator NewRelativeRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060067C3 RID: 26563
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_SetActorRelativeLocation_Internal(IntPtr @this, FVector NewRelativeLocation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060067C4 RID: 26564
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_SetActorLocationAndRotation_Internal(IntPtr @this, FVector NewLocation, FRotator NewRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060067C5 RID: 26565
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_SetActorLocation_Internal(IntPtr @this, FVector NewLocation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060067C6 RID: 26566
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_OnReset_Internal(IntPtr @this);

		// Token: 0x060067C7 RID: 26567
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_OnEndViewTarget_Internal(IntPtr @this, IntPtr PC);

		// Token: 0x060067C8 RID: 26568
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_OnBecomeViewTarget_Internal(IntPtr @this, IntPtr PC);

		// Token: 0x060067C9 RID: 26569
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_KuroTeleportTo_Internal(IntPtr @this, FVector DestLocation, FRotator DestRotation);

		// Token: 0x060067CA RID: 26570
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_KuroSetActorRotation_Internal(IntPtr @this, FRotator NewRotation, bool bSweep, bool bTeleportPhysics, bool bIgnoreOverlap);

		// Token: 0x060067CB RID: 26571
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __K2_GetRootComponent_Internal(IntPtr @this);

		// Token: 0x060067CC RID: 26572
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __K2_GetComponentsByClass_Internal(IntPtr @this, IntPtr ComponentClass);

		// Token: 0x060067CD RID: 26573
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __K2_GetActorRotation_Internal(IntPtr @this);

		// Token: 0x060067CE RID: 26574
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat __K2_GetActorQuaternion_Internal(IntPtr @this);

		// Token: 0x060067CF RID: 26575
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __K2_GetActorLocation_Internal(IntPtr @this);

		// Token: 0x060067D0 RID: 26576
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_DetachFromActor_Internal(IntPtr @this, EDetachmentRule LocationRule, EDetachmentRule RotationRule, EDetachmentRule ScaleRule);

		// Token: 0x060067D1 RID: 26577
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_DestroyComponent_Internal(IntPtr @this, IntPtr Component);

		// Token: 0x060067D2 RID: 26578
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_DestroyActor_Internal(IntPtr @this);

		// Token: 0x060067D3 RID: 26579
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_AttachToComponent_Internal(IntPtr @this, IntPtr Parent, FName SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies, bool bCalcWorldOrigin);

		// Token: 0x060067D4 RID: 26580
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_AttachToActor_Internal(IntPtr @this, IntPtr ParentActor, FName SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies, bool bCalcWorldOrigin);

		// Token: 0x060067D5 RID: 26581
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_AttachRootComponentToActor_Internal(IntPtr @this, IntPtr InParentActor, FName InSocketName, TEnumAsByte<EAttachLocation> AttachLocationType, bool bWeldSimulatedBodies);

		// Token: 0x060067D6 RID: 26582
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_AttachRootComponentTo_Internal(IntPtr @this, IntPtr InParent, FName InSocketName, TEnumAsByte<EAttachLocation> AttachLocationType, bool bWeldSimulatedBodies);

		// Token: 0x060067D7 RID: 26583
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_AddActorWorldTransformKeepScale_Internal(IntPtr @this, in FTransform DeltaTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060067D8 RID: 26584
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_AddActorWorldTransform_Internal(IntPtr @this, in FTransform DeltaTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060067D9 RID: 26585
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_AddActorWorldRotation_Internal(IntPtr @this, FRotator DeltaRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060067DA RID: 26586
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_AddActorWorldOffset_Internal(IntPtr @this, FVector DeltaLocation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060067DB RID: 26587
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_AddActorLocalTransform_Internal(IntPtr @this, in FTransform NewTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060067DC RID: 26588
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_AddActorLocalRotation_Internal(IntPtr @this, FRotator DeltaRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060067DD RID: 26589
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_AddActorLocalOffset_Internal(IntPtr @this, FVector DeltaLocation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060067DE RID: 26590
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsUEOrignal_Internal(IntPtr @this);

		// Token: 0x060067DF RID: 26591
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsOverlappingActor_Internal(IntPtr @this, IntPtr Other);

		// Token: 0x060067E0 RID: 26592
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsIgnoreUpdateOverlap_Internal(IntPtr @this);

		// Token: 0x060067E1 RID: 26593
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsChildActor_Internal(IntPtr @this);

		// Token: 0x060067E2 RID: 26594
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsAutonomousProxy_Internal(IntPtr @this);

		// Token: 0x060067E3 RID: 26595
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsActorTickEnabled_Internal(IntPtr @this);

		// Token: 0x060067E4 RID: 26596
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsActorBeingDestroyed_Internal(IntPtr @this);

		// Token: 0x060067E5 RID: 26597
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __IgnoreActorWhenMoving_Internal(IntPtr @this, IntPtr Actor, bool bShouldIgnore, bool bBoth);

		// Token: 0x060067E6 RID: 26598
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasAuthority_Internal(IntPtr @this);

		// Token: 0x060067E7 RID: 26599
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetVerticalDistanceTo_Internal(IntPtr @this, IntPtr OtherActor);

		// Token: 0x060067E8 RID: 26600
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetVelocity_Internal(IntPtr @this);

		// Token: 0x060067E9 RID: 26601
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetTransformWithUpdate_Internal(IntPtr @this);

		// Token: 0x060067EA RID: 26602
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetTransform_Internal(IntPtr @this);

		// Token: 0x060067EB RID: 26603
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetTickableWhenPaused_Internal(IntPtr @this);

		// Token: 0x060067EC RID: 26604
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetSquaredHorizontalDistanceTo_Internal(IntPtr @this, IntPtr OtherActor);

		// Token: 0x060067ED RID: 26605
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetSquaredDistanceTo_Internal(IntPtr @this, IntPtr OtherActor);

		// Token: 0x060067EE RID: 26606
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<ENetRole> __GetRemoteRole_Internal(IntPtr @this);

		// Token: 0x060067EF RID: 26607
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern uint __GetPrimitiveEntityType_Internal(IntPtr @this);

		// Token: 0x060067F0 RID: 26608
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetPrimitiveBlueprintTypeName_Internal(IntPtr @this);

		// Token: 0x060067F1 RID: 26609
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetParentComponent_Internal(IntPtr @this);

		// Token: 0x060067F2 RID: 26610
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetParentActor_Internal(IntPtr @this);

		// Token: 0x060067F3 RID: 26611
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetOwner_Internal(IntPtr @this);

		// Token: 0x060067F4 RID: 26612
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetOverlappingComponents_Internal(IntPtr @this, IntPtr OverlappingComponents);

		// Token: 0x060067F5 RID: 26613
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetOverlappingActors_Internal(IntPtr @this, IntPtr OverlappingActors, IntPtr ClassFilter);

		// Token: 0x060067F6 RID: 26614
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<ENetRole> __GetLocalRole_Internal(IntPtr @this);

		// Token: 0x060067F7 RID: 26615
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetLifeSpan_Internal(IntPtr @this);

		// Token: 0x060067F8 RID: 26616
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetLevelTransform_Internal(IntPtr @this);

		// Token: 0x060067F9 RID: 26617
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLevel_Internal(IntPtr @this);

		// Token: 0x060067FA RID: 26618
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetInverseTransform_Internal(IntPtr @this);

		// Token: 0x060067FB RID: 26619
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetInstigatorController_Internal(IntPtr @this);

		// Token: 0x060067FC RID: 26620
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetInstigator_Internal(IntPtr @this);

		// Token: 0x060067FD RID: 26621
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetInputVectorAxisValue_Internal(IntPtr @this, IntPtr InputAxisKey);

		// Token: 0x060067FE RID: 26622
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetInputAxisValue_Internal(IntPtr @this, FName InputAxisName);

		// Token: 0x060067FF RID: 26623
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetInputAxisKeyValue_Internal(IntPtr @this, IntPtr InputAxisKey);

		// Token: 0x06006800 RID: 26624
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetHorizontalDotProductTo_Internal(IntPtr @this, IntPtr OtherActor);

		// Token: 0x06006801 RID: 26625
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetHorizontalDistanceTo_Internal(IntPtr @this, IntPtr OtherActor);

		// Token: 0x06006802 RID: 26626
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetGameTimeSinceCreation_Internal(IntPtr @this);

		// Token: 0x06006803 RID: 26627
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetDotProductTo_Internal(IntPtr @this, IntPtr OtherActor);

		// Token: 0x06006804 RID: 26628
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetDistanceTo_Internal(IntPtr @this, IntPtr OtherActor);

		// Token: 0x06006805 RID: 26629
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetComponentsByTag_Internal(IntPtr @this, IntPtr ComponentClass, FName Tag);

		// Token: 0x06006806 RID: 26630
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetComponentsByInterface_Internal(IntPtr @this, IntPtr Interface);

		// Token: 0x06006807 RID: 26631
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetComponentByClass_Internal(IntPtr @this, IntPtr ComponentClass);

		// Token: 0x06006808 RID: 26632
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAttachRootParentActor_Internal(IntPtr @this);

		// Token: 0x06006809 RID: 26633
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetAttachParentSocketName_Internal(IntPtr @this);

		// Token: 0x0600680A RID: 26634
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAttachParentActor_Internal(IntPtr @this);

		// Token: 0x0600680B RID: 26635
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAttachedActors_Internal(IntPtr @this, IntPtr OutActors, bool bResetArray);

		// Token: 0x0600680C RID: 26636
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAttachedActorDescendants_Internal(IntPtr @this, IntPtr OutActors, bool bResetArray);

		// Token: 0x0600680D RID: 26637
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAllChildActors_Internal(IntPtr @this, IntPtr ChildActors, bool bIncludeDescendants);

		// Token: 0x0600680E RID: 26638
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetActorUpVector_Internal(IntPtr @this);

		// Token: 0x0600680F RID: 26639
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetActorTimeDilation_Internal(IntPtr @this);

		// Token: 0x06006810 RID: 26640
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetActorTickInterval_Internal(IntPtr @this);

		// Token: 0x06006811 RID: 26641
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetActorScale3D_Internal(IntPtr @this);

		// Token: 0x06006812 RID: 26642
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetActorRightVector_Internal(IntPtr @this);

		// Token: 0x06006813 RID: 26643
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetActorRelativeScale3D_Internal(IntPtr @this);

		// Token: 0x06006814 RID: 26644
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetActorForwardVector_Internal(IntPtr @this);

		// Token: 0x06006815 RID: 26645
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetActorEyesViewPoint_Internal(IntPtr @this, ref FVector OutLocation, ref FRotator OutRotation, int CameraIndex);

		// Token: 0x06006816 RID: 26646
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetActorEnableCollision_Internal(IntPtr @this);

		// Token: 0x06006817 RID: 26647
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetActorBounds_Internal(IntPtr @this, bool bOnlyCollidingComponents, ref FVector Origin, ref FVector BoxExtent, bool bIncludeFromChildActors);

		// Token: 0x06006818 RID: 26648
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ForceNetUpdate_Internal(IntPtr @this);

		// Token: 0x06006819 RID: 26649
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FlushNetDormancy_Internal(IntPtr @this);

		// Token: 0x0600681A RID: 26650
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FinishAddComponent_Internal(IntPtr @this, IntPtr Component, bool bManualAttachment, in FTransform RelativeTransform);

		// Token: 0x0600681B RID: 26651
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EnableInput_Internal(IntPtr @this, IntPtr PlayerController);

		// Token: 0x0600681C RID: 26652
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DisableInput_Internal(IntPtr @this, IntPtr PlayerController);

		// Token: 0x0600681D RID: 26653
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DetachRootComponentFromParent_Internal(IntPtr @this, bool bMaintainWorldPosition);

		// Token: 0x0600681E RID: 26654
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_SetActorScale3D_Internal(IntPtr @this, FVectorDouble NewScale3D);

		// Token: 0x0600681F RID: 26655
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_K2_TeleportTo_Internal(IntPtr @this, FVectorDouble DestLocation, FRotator DestRotation);

		// Token: 0x06006820 RID: 26656
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_K2_SetActorTransformForce_Internal(IntPtr @this, in FTransformDouble NewTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x06006821 RID: 26657
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_K2_SetActorTransform_Internal(IntPtr @this, in FTransformDouble NewTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x06006822 RID: 26658
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_K2_SetActorRelativeTransform_Internal(IntPtr @this, in FTransformDouble NewRelativeTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x06006823 RID: 26659
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_K2_SetActorRelativeLocation_Internal(IntPtr @this, FVectorDouble NewRelativeLocation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x06006824 RID: 26660
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_K2_SetActorLocationAndRotation_Internal(IntPtr @this, FVectorDouble NewLocation, FRotator NewRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x06006825 RID: 26661
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_K2_SetActorLocation_Internal(IntPtr @this, FVectorDouble NewLocation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x06006826 RID: 26662
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_K2_KuroTeleportTo_Internal(IntPtr @this, FVectorDouble DestLocation, FRotator DestRotation);

		// Token: 0x06006827 RID: 26663
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_K2_GetActorLocation_Internal(IntPtr @this);

		// Token: 0x06006828 RID: 26664
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_K2_AddActorWorldTransform_Internal(IntPtr @this, in FTransformDouble DeltaTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x06006829 RID: 26665
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_K2_AddActorWorldOffset_Internal(IntPtr @this, FVectorDouble DeltaLocation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x0600682A RID: 26666
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_K2_AddActorLocalTransform_Internal(IntPtr @this, in FTransformDouble NewTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x0600682B RID: 26667
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_K2_AddActorLocalOffset_Internal(IntPtr @this, FVectorDouble DeltaLocation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x0600682C RID: 26668
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetVelocity_Internal(IntPtr @this);

		// Token: 0x0600682D RID: 26669
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble __D_GetTransformWithUpdate_Internal(IntPtr @this);

		// Token: 0x0600682E RID: 26670
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble __D_GetTransform_Internal(IntPtr @this);

		// Token: 0x0600682F RID: 26671
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble __D_GetInverseTransform_Internal(IntPtr @this);

		// Token: 0x06006830 RID: 26672
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double __D_GetGameTimeSinceCreation_Internal(IntPtr @this);

		// Token: 0x06006831 RID: 26673
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double __D_GetDistanceTo_Internal(IntPtr @this, IntPtr OtherActor);

		// Token: 0x06006832 RID: 26674
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetActorUpVector_Internal(IntPtr @this);

		// Token: 0x06006833 RID: 26675
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetActorScale3D_Internal(IntPtr @this);

		// Token: 0x06006834 RID: 26676
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetActorRightVector_Internal(IntPtr @this);

		// Token: 0x06006835 RID: 26677
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetActorForwardVector_Internal(IntPtr @this);

		// Token: 0x06006836 RID: 26678
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_GetActorBounds_Internal(IntPtr @this, bool bOnlyCollidingComponents, ref FVectorDouble Origin, ref FVector BoxExtent, bool bIncludeFromChildActors);

		// Token: 0x06006837 RID: 26679
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __D_AddComponentByClass_Internal(IntPtr @this, IntPtr Class, bool bManualAttachment, in FTransformDouble RelativeTransform, bool bDeferredFinish, FName ComponentName);

		// Token: 0x06006838 RID: 26680
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearMoveIgnoreActors_Internal(IntPtr @this, bool bClearBoth);

		// Token: 0x06006839 RID: 26681
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddTickPrerequisiteComponent_Internal(IntPtr @this, IntPtr PrerequisiteComponent);

		// Token: 0x0600683A RID: 26682
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddTickPrerequisiteActor_Internal(IntPtr @this, IntPtr PrerequisiteActor);

		// Token: 0x0600683B RID: 26683
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddComponentByClass_Internal(IntPtr @this, IntPtr Class, bool bManualAttachment, in FTransform RelativeTransform, bool bDeferredFinish, FName ComponentName);

		// Token: 0x0600683C RID: 26684
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddComponent_Internal(IntPtr @this, FName TemplateName, bool bManualAttachment, in FTransform RelativeTransform, IntPtr ComponentTemplateContext, bool bDeferredFinish);

		// Token: 0x0600683D RID: 26685
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ActorHasTag_Internal(IntPtr @this, FName Tag);

		// Token: 0x0600683E RID: 26686 RVA: 0x00094F22 File Offset: 0x00093122
		static AActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Actor");
		}

		// Token: 0x0600683F RID: 26687 RVA: 0x00094F30 File Offset: 0x00093130
		protected AActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003183 RID: 12675
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.Actor";

		// Token: 0x04003184 RID: 12676
		private static IntPtr _ClassPtr;

		// Token: 0x04003185 RID: 12677
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003186 RID: 12678
		internal static int __PropertyOffset_PrimaryActorTick;

		// Token: 0x04003187 RID: 12679
		private FActorTickFunction _PrimaryActorTick;

		// Token: 0x04003188 RID: 12680
		internal static int __PropertyOffset_bNetTemporary;

		// Token: 0x04003189 RID: 12681
		internal static byte __PropertyMask_bNetTemporary;

		// Token: 0x0400318A RID: 12682
		internal static int __PropertyOffset_bNetStartup;

		// Token: 0x0400318B RID: 12683
		internal static byte __PropertyMask_bNetStartup;

		// Token: 0x0400318C RID: 12684
		internal static int __PropertyOffset_bOnlyRelevantToOwner;

		// Token: 0x0400318D RID: 12685
		internal static byte __PropertyMask_bOnlyRelevantToOwner;

		// Token: 0x0400318E RID: 12686
		internal static int __PropertyOffset_bAlwaysRelevant;

		// Token: 0x0400318F RID: 12687
		internal static byte __PropertyMask_bAlwaysRelevant;

		// Token: 0x04003190 RID: 12688
		internal static int __PropertyOffset_bReplicateMovement;

		// Token: 0x04003191 RID: 12689
		internal static byte __PropertyMask_bReplicateMovement;

		// Token: 0x04003192 RID: 12690
		internal static int __PropertyOffset_bHidden;

		// Token: 0x04003193 RID: 12691
		internal static byte __PropertyMask_bHidden;

		// Token: 0x04003194 RID: 12692
		internal static int __PropertyOffset_bViewableInRender;

		// Token: 0x04003195 RID: 12693
		internal static byte __PropertyMask_bViewableInRender;

		// Token: 0x04003196 RID: 12694
		internal static int __PropertyOffset_bTearOff;

		// Token: 0x04003197 RID: 12695
		internal static byte __PropertyMask_bTearOff;

		// Token: 0x04003198 RID: 12696
		internal static int __PropertyOffset_bForceHidden;

		// Token: 0x04003199 RID: 12697
		internal static byte __PropertyMask_bForceHidden;

		// Token: 0x0400319A RID: 12698
		internal static int __PropertyOffset_bIsAliveSpawnableAfterSequenceClean;

		// Token: 0x0400319B RID: 12699
		internal static int __PropertyOffset_bExchangedRoles;

		// Token: 0x0400319C RID: 12700
		internal static byte __PropertyMask_bExchangedRoles;

		// Token: 0x0400319D RID: 12701
		internal static int __PropertyOffset_bNetLoadOnClient;

		// Token: 0x0400319E RID: 12702
		internal static byte __PropertyMask_bNetLoadOnClient;

		// Token: 0x0400319F RID: 12703
		internal static int __PropertyOffset_bNetUseOwnerRelevancy;

		// Token: 0x040031A0 RID: 12704
		internal static byte __PropertyMask_bNetUseOwnerRelevancy;

		// Token: 0x040031A1 RID: 12705
		internal static int __PropertyOffset_bRelevantForNetworkReplays;

		// Token: 0x040031A2 RID: 12706
		internal static byte __PropertyMask_bRelevantForNetworkReplays;

		// Token: 0x040031A3 RID: 12707
		internal static int __PropertyOffset_bRelevantForLevelBounds;

		// Token: 0x040031A4 RID: 12708
		internal static byte __PropertyMask_bRelevantForLevelBounds;

		// Token: 0x040031A5 RID: 12709
		internal static int __PropertyOffset_bReplayRewindable;

		// Token: 0x040031A6 RID: 12710
		internal static byte __PropertyMask_bReplayRewindable;

		// Token: 0x040031A7 RID: 12711
		internal static int __PropertyOffset_bAllowTickBeforeBeginPlay;

		// Token: 0x040031A8 RID: 12712
		internal static byte __PropertyMask_bAllowTickBeforeBeginPlay;

		// Token: 0x040031A9 RID: 12713
		internal static int __PropertyOffset_bAutoDestroyWhenFinished;

		// Token: 0x040031AA RID: 12714
		internal static byte __PropertyMask_bAutoDestroyWhenFinished;

		// Token: 0x040031AB RID: 12715
		internal static int __PropertyOffset_bCanBeDamaged;

		// Token: 0x040031AC RID: 12716
		internal static byte __PropertyMask_bCanBeDamaged;

		// Token: 0x040031AD RID: 12717
		internal static int __PropertyOffset_bBlockInput;

		// Token: 0x040031AE RID: 12718
		internal static byte __PropertyMask_bBlockInput;

		// Token: 0x040031AF RID: 12719
		internal static int __PropertyOffset_bCollideWhenPlacing;

		// Token: 0x040031B0 RID: 12720
		internal static byte __PropertyMask_bCollideWhenPlacing;

		// Token: 0x040031B1 RID: 12721
		internal static int __PropertyOffset_bFindCameraComponentWhenViewTarget;

		// Token: 0x040031B2 RID: 12722
		internal static byte __PropertyMask_bFindCameraComponentWhenViewTarget;

		// Token: 0x040031B3 RID: 12723
		internal static int __PropertyOffset_bGenerateOverlapEventsDuringLevelStreaming;

		// Token: 0x040031B4 RID: 12724
		internal static byte __PropertyMask_bGenerateOverlapEventsDuringLevelStreaming;

		// Token: 0x040031B5 RID: 12725
		internal static int __PropertyOffset_bIgnoresOriginShifting;

		// Token: 0x040031B6 RID: 12726
		internal static byte __PropertyMask_bIgnoresOriginShifting;

		// Token: 0x040031B7 RID: 12727
		internal static int __PropertyOffset_bEnableAutoLODGeneration;

		// Token: 0x040031B8 RID: 12728
		internal static byte __PropertyMask_bEnableAutoLODGeneration;

		// Token: 0x040031B9 RID: 12729
		internal static int __PropertyOffset_bIsEditorOnlyActor;

		// Token: 0x040031BA RID: 12730
		internal static byte __PropertyMask_bIsEditorOnlyActor;

		// Token: 0x040031BB RID: 12731
		internal static int __PropertyOffset_bPlatformMobile;

		// Token: 0x040031BC RID: 12732
		internal static byte __PropertyMask_bPlatformMobile;

		// Token: 0x040031BD RID: 12733
		internal static int __PropertyOffset_bPlatformDeskTop;

		// Token: 0x040031BE RID: 12734
		internal static byte __PropertyMask_bPlatformDeskTop;

		// Token: 0x040031BF RID: 12735
		internal static int __PropertyOffset_bPlatformMac;

		// Token: 0x040031C0 RID: 12736
		internal static byte __PropertyMask_bPlatformMac;

		// Token: 0x040031C1 RID: 12737
		internal static int __PropertyOffset_bInvolveCook;

		// Token: 0x040031C2 RID: 12738
		internal static byte __PropertyMask_bInvolveCook;

		// Token: 0x040031C3 RID: 12739
		internal static int __PropertyOffset_bActorSeamlessTraveled;

		// Token: 0x040031C4 RID: 12740
		internal static byte __PropertyMask_bActorSeamlessTraveled;

		// Token: 0x040031C5 RID: 12741
		internal static int __PropertyOffset_bIsPermanentActor;

		// Token: 0x040031C6 RID: 12742
		internal static byte __PropertyMask_bIsPermanentActor;

		// Token: 0x040031C7 RID: 12743
		internal static int __PropertyOffset_bEnableBeginAndEndPlayDebugLog;

		// Token: 0x040031C8 RID: 12744
		internal static byte __PropertyMask_bEnableBeginAndEndPlayDebugLog;

		// Token: 0x040031C9 RID: 12745
		internal static int __PropertyOffset_bKuroHiddenDebugLog;

		// Token: 0x040031CA RID: 12746
		internal static byte __PropertyMask_bKuroHiddenDebugLog;

		// Token: 0x040031CB RID: 12747
		internal static int __PropertyOffset_bSpawnInUIScene;

		// Token: 0x040031CC RID: 12748
		internal static byte __PropertyMask_bSpawnInUIScene;

		// Token: 0x040031CD RID: 12749
		internal static int __PropertyOffset_bReplicates;

		// Token: 0x040031CE RID: 12750
		internal static byte __PropertyMask_bReplicates;

		// Token: 0x040031CF RID: 12751
		internal static int __PropertyOffset_bCanBeInCluster;

		// Token: 0x040031D0 RID: 12752
		internal static byte __PropertyMask_bCanBeInCluster;

		// Token: 0x040031D1 RID: 12753
		internal static int __PropertyOffset_bAllowReceiveTickEventOnDedicatedServer;

		// Token: 0x040031D2 RID: 12754
		internal static byte __PropertyMask_bAllowReceiveTickEventOnDedicatedServer;

		// Token: 0x040031D3 RID: 12755
		internal static int __PropertyOffset_bActorEnableCollision;

		// Token: 0x040031D4 RID: 12756
		internal static byte __PropertyMask_bActorEnableCollision;

		// Token: 0x040031D5 RID: 12757
		internal static int __PropertyOffset_bActorIsBeingDestroyed;

		// Token: 0x040031D6 RID: 12758
		internal static byte __PropertyMask_bActorIsBeingDestroyed;

		// Token: 0x040031D7 RID: 12759
		internal static int __PropertyOffset_UpdateOverlapsMethodDuringLevelStreaming;

		// Token: 0x040031D8 RID: 12760
		internal static int __PropertyOffset_DefaultUpdateOverlapsMethodDuringLevelStreaming;

		// Token: 0x040031D9 RID: 12761
		internal static int __PropertyOffset_RemoteRole;

		// Token: 0x040031DA RID: 12762
		internal static int __PropertyOffset_ReplicatedMovement;

		// Token: 0x040031DB RID: 12763
		private FRepMovement _ReplicatedMovement;

		// Token: 0x040031DC RID: 12764
		internal static int __PropertyOffset_Kuro_ReplicatedMovement;

		// Token: 0x040031DD RID: 12765
		private FKuroRepMovement _Kuro_ReplicatedMovement;

		// Token: 0x040031DE RID: 12766
		internal static int __PropertyOffset_InitialLifeSpan;

		// Token: 0x040031DF RID: 12767
		internal static int __PropertyOffset_CustomTimeDilation;

		// Token: 0x040031E0 RID: 12768
		internal static int __PropertyOffset_AttachmentReplication;

		// Token: 0x040031E1 RID: 12769
		private FRepAttachment _AttachmentReplication;

		// Token: 0x040031E2 RID: 12770
		internal static int __PropertyOffset_Owner;

		// Token: 0x040031E3 RID: 12771
		internal static int __PropertyOffset_NetDriverName;

		// Token: 0x040031E4 RID: 12772
		internal static int __PropertyOffset_BlueprintTypeName;

		// Token: 0x040031E5 RID: 12773
		internal static int __PropertyOffset_KuroEntityType;

		// Token: 0x040031E6 RID: 12774
		internal static int __PropertyOffset_RuntimeGrid;

		// Token: 0x040031E7 RID: 12775
		internal static int __PropertyOffset_Role;

		// Token: 0x040031E8 RID: 12776
		internal static int __PropertyOffset_NetDormancy;

		// Token: 0x040031E9 RID: 12777
		internal static int __PropertyOffset_SpawnCollisionHandlingMethod;

		// Token: 0x040031EA RID: 12778
		internal static int __PropertyOffset_AutoReceiveInput;

		// Token: 0x040031EB RID: 12779
		internal static int __PropertyOffset_InputPriority;

		// Token: 0x040031EC RID: 12780
		internal static int __PropertyOffset_InputComponent;

		// Token: 0x040031ED RID: 12781
		internal static int __PropertyOffset_NetCullDistanceSquared;

		// Token: 0x040031EE RID: 12782
		internal static int __PropertyOffset_NetTag;

		// Token: 0x040031EF RID: 12783
		internal static int __PropertyOffset_NetUpdateFrequency;

		// Token: 0x040031F0 RID: 12784
		internal static int __PropertyOffset_MinNetUpdateFrequency;

		// Token: 0x040031F1 RID: 12785
		internal static int __PropertyOffset_NetPriority;

		// Token: 0x040031F2 RID: 12786
		internal static int __PropertyOffset_Instigator;

		// Token: 0x040031F3 RID: 12787
		internal static int __PropertyOffset_Children;

		// Token: 0x040031F4 RID: 12788
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _Children;

		// Token: 0x040031F5 RID: 12789
		internal static int __PropertyOffset_RootComponent;

		// Token: 0x040031F6 RID: 12790
		internal static int __PropertyOffset_ControllingMatineeActors;

		// Token: 0x040031F7 RID: 12791
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AMatineeActor> _ControllingMatineeActors;

		// Token: 0x040031F8 RID: 12792
		internal static int __PropertyOffset_Layers;

		// Token: 0x040031F9 RID: 12793
		private TArray<FName> _Layers;

		// Token: 0x040031FA RID: 12794
		internal static int __PropertyOffset_ParentComponent;

		// Token: 0x040031FB RID: 12795
		internal static int __PropertyOffset_Tags;

		// Token: 0x040031FC RID: 12796
		private TArray<FName> _Tags;

		// Token: 0x040031FD RID: 12797
		internal static int __PropertyOffset_OnTakeAnyDamage;

		// Token: 0x040031FE RID: 12798
		private FTakeAnyDamageSignature _OnTakeAnyDamage;

		// Token: 0x040031FF RID: 12799
		internal static int __PropertyOffset_OnTakePointDamage;

		// Token: 0x04003200 RID: 12800
		private FTakePointDamageSignature _OnTakePointDamage;

		// Token: 0x04003201 RID: 12801
		internal static int __PropertyOffset_OnTakeRadialDamage;

		// Token: 0x04003202 RID: 12802
		private FTakeRadialDamageSignature _OnTakeRadialDamage;

		// Token: 0x04003203 RID: 12803
		internal static int __PropertyOffset_OnActorBeginOverlap;

		// Token: 0x04003204 RID: 12804
		private FActorBeginOverlapSignature _OnActorBeginOverlap;

		// Token: 0x04003205 RID: 12805
		internal static int __PropertyOffset_OnActorEndOverlap;

		// Token: 0x04003206 RID: 12806
		private FActorEndOverlapSignature _OnActorEndOverlap;

		// Token: 0x04003207 RID: 12807
		internal static int __PropertyOffset_OnBeginCursorOver;

		// Token: 0x04003208 RID: 12808
		private FActorBeginCursorOverSignature _OnBeginCursorOver;

		// Token: 0x04003209 RID: 12809
		internal static int __PropertyOffset_OnEndCursorOver;

		// Token: 0x0400320A RID: 12810
		private FActorEndCursorOverSignature _OnEndCursorOver;

		// Token: 0x0400320B RID: 12811
		internal static int __PropertyOffset_OnClicked;

		// Token: 0x0400320C RID: 12812
		private FActorOnClickedSignature _OnClicked;

		// Token: 0x0400320D RID: 12813
		internal static int __PropertyOffset_OnReleased;

		// Token: 0x0400320E RID: 12814
		private FActorOnReleasedSignature _OnReleased;

		// Token: 0x0400320F RID: 12815
		internal static int __PropertyOffset_OnInputTouchBegin;

		// Token: 0x04003210 RID: 12816
		private FActorOnInputTouchBeginSignature _OnInputTouchBegin;

		// Token: 0x04003211 RID: 12817
		internal static int __PropertyOffset_OnInputTouchEnd;

		// Token: 0x04003212 RID: 12818
		private FActorOnInputTouchEndSignature _OnInputTouchEnd;

		// Token: 0x04003213 RID: 12819
		internal static int __PropertyOffset_OnInputTouchEnter;

		// Token: 0x04003214 RID: 12820
		private FActorBeginTouchOverSignature _OnInputTouchEnter;

		// Token: 0x04003215 RID: 12821
		internal static int __PropertyOffset_OnInputTouchLeave;

		// Token: 0x04003216 RID: 12822
		private FActorEndTouchOverSignature _OnInputTouchLeave;

		// Token: 0x04003217 RID: 12823
		internal static int __PropertyOffset_OnActorHit;

		// Token: 0x04003218 RID: 12824
		private FActorHitSignature _OnActorHit;

		// Token: 0x04003219 RID: 12825
		internal static int __PropertyOffset_OnDestroyed;

		// Token: 0x0400321A RID: 12826
		private FActorDestroyedSignature _OnDestroyed;

		// Token: 0x0400321B RID: 12827
		internal static int __PropertyOffset_OnEndPlay;

		// Token: 0x0400321C RID: 12828
		private FActorEndPlaySignature _OnEndPlay;

		// Token: 0x0400321D RID: 12829
		internal static int __PropertyOffset_InstanceComponents;

		// Token: 0x0400321E RID: 12830
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UActorComponent> _InstanceComponents;

		// Token: 0x0400321F RID: 12831
		internal static int __PropertyOffset_BlueprintCreatedComponents;

		// Token: 0x04003220 RID: 12832
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UActorComponent> _BlueprintCreatedComponents;

		// Token: 0x04003221 RID: 12833
		internal static int __PropertyOffset_MoveIgnoreActors;

		// Token: 0x04003222 RID: 12834
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _MoveIgnoreActors;

		// Token: 0x02002C51 RID: 11345
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04016565 RID: 91493
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02002C52 RID: 11346
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 192)]
		protected ref struct __ReceiveRadialDamage_FunctionParams
		{
			// Token: 0x04016566 RID: 91494
			[FieldOffset(0)]
			public float DamageReceived;

			// Token: 0x04016567 RID: 91495
			[FieldOffset(8)]
			public IntPtr DamageType;

			// Token: 0x04016568 RID: 91496
			[FieldOffset(16)]
			public FVector Origin;

			// Token: 0x04016569 RID: 91497
			[FieldOffset(28)]
			public byte HitInfo;

			// Token: 0x0401656A RID: 91498
			[FieldOffset(176)]
			public IntPtr InstigatedBy;

			// Token: 0x0401656B RID: 91499
			[FieldOffset(184)]
			public IntPtr DamageCauser;
		}

		// Token: 0x02002C53 RID: 11347
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 240)]
		protected ref struct __ReceivePointDamage_FunctionParams
		{
			// Token: 0x0401656C RID: 91500
			[FieldOffset(0)]
			public float Damage;

			// Token: 0x0401656D RID: 91501
			[FieldOffset(8)]
			public IntPtr DamageType;

			// Token: 0x0401656E RID: 91502
			[FieldOffset(16)]
			public FVector HitLocation;

			// Token: 0x0401656F RID: 91503
			[FieldOffset(28)]
			public FVector HitNormal;

			// Token: 0x04016570 RID: 91504
			[FieldOffset(40)]
			public IntPtr HitComponent;

			// Token: 0x04016571 RID: 91505
			[FieldOffset(48)]
			public FName BoneName;

			// Token: 0x04016572 RID: 91506
			[FieldOffset(60)]
			public FVector ShotFromDirection;

			// Token: 0x04016573 RID: 91507
			[FieldOffset(72)]
			public IntPtr InstigatedBy;

			// Token: 0x04016574 RID: 91508
			[FieldOffset(80)]
			public IntPtr DamageCauser;

			// Token: 0x04016575 RID: 91509
			[FieldOffset(88)]
			public byte HitInfo;
		}

		// Token: 0x02002C54 RID: 11348
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 216)]
		protected ref struct __ReceiveHit_FunctionParams
		{
			// Token: 0x04016576 RID: 91510
			[FieldOffset(0)]
			public IntPtr MyComp;

			// Token: 0x04016577 RID: 91511
			[FieldOffset(8)]
			public IntPtr Other;

			// Token: 0x04016578 RID: 91512
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04016579 RID: 91513
			[FieldOffset(24)]
			public bool bSelfMoved;

			// Token: 0x0401657A RID: 91514
			[FieldOffset(28)]
			public FVector HitLocation;

			// Token: 0x0401657B RID: 91515
			[FieldOffset(40)]
			public FVector HitNormal;

			// Token: 0x0401657C RID: 91516
			[FieldOffset(52)]
			public FVector NormalImpulse;

			// Token: 0x0401657D RID: 91517
			[FieldOffset(64)]
			public byte Hit;
		}

		// Token: 0x02002C55 RID: 11349
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x0401657E RID: 91518
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}

		// Token: 0x02002C56 RID: 11350
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __ReceiveAnyDamage_FunctionParams
		{
			// Token: 0x0401657F RID: 91519
			[FieldOffset(0)]
			public float Damage;

			// Token: 0x04016580 RID: 91520
			[FieldOffset(8)]
			public IntPtr DamageType;

			// Token: 0x04016581 RID: 91521
			[FieldOffset(16)]
			public IntPtr InstigatedBy;

			// Token: 0x04016582 RID: 91522
			[FieldOffset(24)]
			public IntPtr DamageCauser;
		}

		// Token: 0x02002C57 RID: 11351
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __ReceiveActorOnReleased_FunctionParams
		{
			// Token: 0x04016583 RID: 91523
			[FieldOffset(0)]
			public byte ButtonReleased;
		}

		// Token: 0x02002C58 RID: 11352
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ReceiveActorOnInputTouchLeave_FunctionParams
		{
			// Token: 0x04016584 RID: 91524
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> FingerIndex;
		}

		// Token: 0x02002C59 RID: 11353
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ReceiveActorOnInputTouchEnter_FunctionParams
		{
			// Token: 0x04016585 RID: 91525
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> FingerIndex;
		}

		// Token: 0x02002C5A RID: 11354
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ReceiveActorOnInputTouchEnd_FunctionParams
		{
			// Token: 0x04016586 RID: 91526
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> FingerIndex;
		}

		// Token: 0x02002C5B RID: 11355
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ReceiveActorOnInputTouchBegin_FunctionParams
		{
			// Token: 0x04016587 RID: 91527
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> FingerIndex;
		}

		// Token: 0x02002C5C RID: 11356
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __ReceiveActorOnClicked_FunctionParams
		{
			// Token: 0x04016588 RID: 91528
			[FieldOffset(0)]
			public byte ButtonPressed;
		}

		// Token: 0x02002C5D RID: 11357
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ReceiveActorEndOverlap_FunctionParams
		{
			// Token: 0x04016589 RID: 91529
			[FieldOffset(0)]
			public IntPtr OtherActor;
		}

		// Token: 0x02002C5E RID: 11358
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ReceiveActorBeginOverlap_FunctionParams
		{
			// Token: 0x0401658A RID: 91530
			[FieldOffset(0)]
			public IntPtr OtherActor;
		}

		// Token: 0x02002C5F RID: 11359
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __K2_OnEndViewTarget_FunctionParams
		{
			// Token: 0x0401658B RID: 91531
			[FieldOffset(0)]
			public IntPtr PC;
		}

		// Token: 0x02002C60 RID: 11360
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __K2_OnBecomeViewTarget_FunctionParams
		{
			// Token: 0x0401658C RID: 91532
			[FieldOffset(0)]
			public IntPtr PC;
		}
	}
}
