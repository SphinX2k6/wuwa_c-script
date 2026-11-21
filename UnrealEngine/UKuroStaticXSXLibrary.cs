using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005E9 RID: 1513
	[UnrealObjectPath("/Script/KuroUtility.KuroStaticXSXLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroStaticXSXLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060086A2 RID: 34466 RVA: 0x000C8ED9 File Offset: 0x000C70D9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroStaticXSXLibrary._ClassPtr;
		}

		// Token: 0x060086A3 RID: 34467 RVA: 0x000C8EE8 File Offset: 0x000C70E8
		public UKuroStaticXSXLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroStaticXSXLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060086A4 RID: 34468 RVA: 0x000C8F10 File Offset: 0x000C7110
		[NullableContext(1)]
		public UKuroStaticXSXLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroStaticXSXLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060086A5 RID: 34469 RVA: 0x000C8F44 File Offset: 0x000C7144
		[SkipLocalsInit]
		public unsafe static bool XboxMultiplayerManagerLobbyAddLocalUser(long UserHandle)
		{
			UKuroStaticXSXLibrary.__XboxMultiplayerManagerLobbyAddLocalUser_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__XboxMultiplayerManagerLobbyAddLocalUser_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__XboxMultiplayerManagerLobbyAddLocalUser_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__XboxMultiplayerManagerLobbyAddLocalUser_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__XboxMultiplayerManagerLobbyAddLocalUser_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060086A6 RID: 34470 RVA: 0x000C8F90 File Offset: 0x000C7190
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static bool XboxMultiplayerManagerJoinLobby(string InviteHandleId, long UserHandle)
		{
			UKuroStaticXSXLibrary.__XboxMultiplayerManagerJoinLobby_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__XboxMultiplayerManagerJoinLobby_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__XboxMultiplayerManagerJoinLobby_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__XboxMultiplayerManagerJoinLobby_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->InviteHandleId), InviteHandleId);
			ptr->UserHandle = UserHandle;
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__XboxMultiplayerManagerJoinLobby_NativeFunctionPtr, (void*)ptr);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__XboxMultiplayerManagerJoinLobby_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x060086A7 RID: 34471 RVA: 0x000C8FFC File Offset: 0x000C71FC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static bool XboxMultiplayerManagerJoinGameWithName(string SessionName, string SessionTemplateName, [Nullable(2)] in TArray<long> Xuids)
		{
			UKuroStaticXSXLibrary.__XboxMultiplayerManagerJoinGameWithName_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__XboxMultiplayerManagerJoinGameWithName_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__XboxMultiplayerManagerJoinGameWithName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__XboxMultiplayerManagerJoinGameWithName_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->SessionName), SessionName);
			FString.CopyFrom((void*)(&ptr->SessionTemplateName), SessionTemplateName);
			TArray<long> tarray = Xuids;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Xuids);
			}
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__XboxMultiplayerManagerJoinGameWithName_NativeFunctionPtr, (void*)ptr);
			TArray<long> tarray2 = Xuids;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Xuids);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__XboxMultiplayerManagerJoinGameWithName_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x060086A8 RID: 34472 RVA: 0x000C9094 File Offset: 0x000C7294
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static bool XboxMultiplayerManagerJoinGameFromLobby(string SessionTemplateName)
		{
			UKuroStaticXSXLibrary.__XboxMultiplayerManagerJoinGameFromLobby_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__XboxMultiplayerManagerJoinGameFromLobby_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__XboxMultiplayerManagerJoinGameFromLobby_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__XboxMultiplayerManagerJoinGameFromLobby_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->SessionTemplateName), SessionTemplateName);
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__XboxMultiplayerManagerJoinGameFromLobby_NativeFunctionPtr, (void*)ptr);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__XboxMultiplayerManagerJoinGameFromLobby_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x060086A9 RID: 34473 RVA: 0x000C90F8 File Offset: 0x000C72F8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void UpdateXboxMultiplayerActivityRecentPlayersAsync(long UserHandle, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FXboxRecentPlayerUpdate> Updates, FOnXboxCallResult Callback)
		{
			UKuroStaticXSXLibrary.__UpdateXboxMultiplayerActivityRecentPlayersAsync_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__UpdateXboxMultiplayerActivityRecentPlayersAsync_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__UpdateXboxMultiplayerActivityRecentPlayersAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__UpdateXboxMultiplayerActivityRecentPlayersAsync_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			TArray<FXboxRecentPlayerUpdate> tarray = Updates;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Updates);
			}
			FScriptDelegate.NativeCopy(&ptr->Callback, (Callback != null) ? Callback.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__UpdateXboxMultiplayerActivityRecentPlayersAsync_NativeFunctionPtr, (void*)ptr);
			TArray<FXboxRecentPlayerUpdate> tarray2 = Updates;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Updates);
			}
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__UpdateXboxMultiplayerActivityRecentPlayersAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060086AA RID: 34474 RVA: 0x000C9190 File Offset: 0x000C7390
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void UpdateXboxAchievementAsync(long UserHandle, long Xuid, string AchievementId, int PercentComplete)
		{
			UKuroStaticXSXLibrary.__UpdateXboxAchievementAsync_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__UpdateXboxAchievementAsync_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__UpdateXboxAchievementAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__UpdateXboxAchievementAsync_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			ptr->Xuid = Xuid;
			FString.CopyFrom((void*)(&ptr->AchievementId), AchievementId);
			ptr->PercentComplete = PercentComplete;
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__UpdateXboxAchievementAsync_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__UpdateXboxAchievementAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060086AB RID: 34475 RVA: 0x000C9201 File Offset: 0x000C7401
		[SkipLocalsInit]
		public static void UnregisterXboxAchievementUpdatedCallback()
		{
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__UnregisterXboxAchievementUpdatedCallback_NativeFunctionPtr, null);
		}

		// Token: 0x060086AC RID: 34476 RVA: 0x000C9214 File Offset: 0x000C7414
		[SkipLocalsInit]
		public static void UnregisterXboxAchievementsCallback()
		{
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__UnregisterXboxAchievementsCallback_NativeFunctionPtr, null);
		}

		// Token: 0x060086AD RID: 34477 RVA: 0x000C9227 File Offset: 0x000C7427
		[SkipLocalsInit]
		public static void UnregisterFromXboxGameInviteEvent()
		{
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__UnregisterFromXboxGameInviteEvent_NativeFunctionPtr, null);
		}

		// Token: 0x060086AE RID: 34478 RVA: 0x000C923C File Offset: 0x000C743C
		[SkipLocalsInit]
		public unsafe static bool ShowXboxPlayerProfileCard(long LocalUserHandle, long TargetXuid)
		{
			UKuroStaticXSXLibrary.__ShowXboxPlayerProfileCard_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__ShowXboxPlayerProfileCard_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__ShowXboxPlayerProfileCard_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__ShowXboxPlayerProfileCard_NativeFunctionPtr, (void*)ptr, 1);
			ptr->LocalUserHandle = LocalUserHandle;
			ptr->TargetXuid = TargetXuid;
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__ShowXboxPlayerProfileCard_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060086AF RID: 34479 RVA: 0x000C9290 File Offset: 0x000C7490
		[SkipLocalsInit]
		public unsafe static bool ShowXboxMultiplayerActivityGameInvite(long UserHandle)
		{
			UKuroStaticXSXLibrary.__ShowXboxMultiplayerActivityGameInvite_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__ShowXboxMultiplayerActivityGameInvite_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__ShowXboxMultiplayerActivityGameInvite_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__ShowXboxMultiplayerActivityGameInvite_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__ShowXboxMultiplayerActivityGameInvite_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060086B0 RID: 34480 RVA: 0x000C92DC File Offset: 0x000C74DC
		[SkipLocalsInit]
		public unsafe static bool ShowKeyBoard(bool State)
		{
			UKuroStaticXSXLibrary.__ShowKeyBoard_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__ShowKeyBoard_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__ShowKeyBoard_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__ShowKeyBoard_NativeFunctionPtr, (void*)ptr, 1);
			ptr->State = State;
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__ShowKeyBoard_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060086B1 RID: 34481 RVA: 0x000C9328 File Offset: 0x000C7528
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void SetXboxMultiplayerActivityAsync(long UserHandle, long xuid, string ConnectionString, int MaxPlayers, int CurrentPlayers, string GroupId, EXboxMultiplayerActivityJoinRestriction JoinRestriction, bool bAllowCrossPlatformJoin, [Nullable(2)] FOnXboxCallResult Callback)
		{
			UKuroStaticXSXLibrary.__SetXboxMultiplayerActivityAsync_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__SetXboxMultiplayerActivityAsync_FunctionParams[(UIntPtr)119] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__SetXboxMultiplayerActivityAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__SetXboxMultiplayerActivityAsync_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			ptr->xuid = xuid;
			FString.CopyFrom((void*)(&ptr->ConnectionString), ConnectionString);
			ptr->MaxPlayers = MaxPlayers;
			ptr->CurrentPlayers = CurrentPlayers;
			FString.CopyFrom((void*)(&ptr->GroupId), GroupId);
			ptr->JoinRestriction = JoinRestriction;
			ptr->bAllowCrossPlatformJoin = bAllowCrossPlatformJoin;
			FScriptDelegate.NativeCopy(&ptr->Callback, (Callback != null) ? Callback.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__SetXboxMultiplayerActivityAsync_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__SetXboxMultiplayerActivityAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060086B2 RID: 34482 RVA: 0x000C93DC File Offset: 0x000C75DC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static bool SendXboxMultiplayerActivityInvites(long UserHandle, [Nullable(2)] in TArray<long> TargetXuids, bool bCrossNetwork, string ConnectionString)
		{
			UKuroStaticXSXLibrary.__SendXboxMultiplayerActivityInvites_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__SendXboxMultiplayerActivityInvites_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__SendXboxMultiplayerActivityInvites_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__SendXboxMultiplayerActivityInvites_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			TArray<long> tarray = TargetXuids;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->TargetXuids);
			}
			ptr->bCrossNetwork = bCrossNetwork;
			FString.CopyFrom((void*)(&ptr->ConnectionString), ConnectionString);
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__SendXboxMultiplayerActivityInvites_NativeFunctionPtr, (void*)ptr);
			TArray<long> tarray2 = TargetXuids;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->TargetXuids);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__SendXboxMultiplayerActivityInvites_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x060086B3 RID: 34483 RVA: 0x000C9474 File Offset: 0x000C7674
		[SkipLocalsInit]
		public unsafe static bool ResolveXboxPrivilegeWithUi(long UserHandle, EXboxUserPrivilege Privilege, EXboxUserPrivilegeOptions Options)
		{
			UKuroStaticXSXLibrary.__ResolveXboxPrivilegeWithUi_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__ResolveXboxPrivilegeWithUi_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__ResolveXboxPrivilegeWithUi_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__ResolveXboxPrivilegeWithUi_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			ptr->Privilege = Privilege;
			ptr->Options = Options;
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__ResolveXboxPrivilegeWithUi_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060086B4 RID: 34484 RVA: 0x000C94D0 File Offset: 0x000C76D0
		[SkipLocalsInit]
		public unsafe static bool ResolveXboxMultiplayerPrivilegeWithUi(long UserHandle)
		{
			UKuroStaticXSXLibrary.__ResolveXboxMultiplayerPrivilegeWithUi_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__ResolveXboxMultiplayerPrivilegeWithUi_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__ResolveXboxMultiplayerPrivilegeWithUi_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__ResolveXboxMultiplayerPrivilegeWithUi_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__ResolveXboxMultiplayerPrivilegeWithUi_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060086B5 RID: 34485 RVA: 0x000C951C File Offset: 0x000C771C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void RegisterXboxAchievementUpdatedCallback(FOnXboxAchievementUpdated Callback)
		{
			UKuroStaticXSXLibrary.__RegisterXboxAchievementUpdatedCallback_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__RegisterXboxAchievementUpdatedCallback_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__RegisterXboxAchievementUpdatedCallback_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__RegisterXboxAchievementUpdatedCallback_NativeFunctionPtr, (void*)ptr, 1);
			FScriptDelegate.NativeCopy(&ptr->Callback, (Callback != null) ? Callback.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__RegisterXboxAchievementUpdatedCallback_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__RegisterXboxAchievementUpdatedCallback_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060086B6 RID: 34486 RVA: 0x000C9584 File Offset: 0x000C7784
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void RegisterXboxAchievementsCallback(FOnXboxAchievementsReceived Callback)
		{
			UKuroStaticXSXLibrary.__RegisterXboxAchievementsCallback_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__RegisterXboxAchievementsCallback_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__RegisterXboxAchievementsCallback_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__RegisterXboxAchievementsCallback_NativeFunctionPtr, (void*)ptr, 1);
			FScriptDelegate.NativeCopy(&ptr->Callback, (Callback != null) ? Callback.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__RegisterXboxAchievementsCallback_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__RegisterXboxAchievementsCallback_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060086B7 RID: 34487 RVA: 0x000C95EC File Offset: 0x000C77EC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static bool RegisterForXboxGameInviteEventWithCallback(FOnXboxInviteReceivedDynamic Callback)
		{
			UKuroStaticXSXLibrary.__RegisterForXboxGameInviteEventWithCallback_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__RegisterForXboxGameInviteEventWithCallback_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__RegisterForXboxGameInviteEventWithCallback_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__RegisterForXboxGameInviteEventWithCallback_NativeFunctionPtr, (void*)ptr, 1);
			FScriptDelegate.NativeCopy(&ptr->Callback, (Callback != null) ? Callback.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__RegisterForXboxGameInviteEventWithCallback_NativeFunctionPtr, (void*)ptr);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__RegisterForXboxGameInviteEventWithCallback_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x060086B8 RID: 34488 RVA: 0x000C965C File Offset: 0x000C785C
		[SkipLocalsInit]
		public unsafe static bool RegisterForXboxGameInviteEvent()
		{
			UKuroStaticXSXLibrary.__RegisterForXboxGameInviteEvent_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__RegisterForXboxGameInviteEvent_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__RegisterForXboxGameInviteEvent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__RegisterForXboxGameInviteEvent_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__RegisterForXboxGameInviteEvent_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060086B9 RID: 34489 RVA: 0x000C96A0 File Offset: 0x000C78A0
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static bool InitXboxMultiplayerManager(string LobbySessionTemplateName)
		{
			UKuroStaticXSXLibrary.__InitXboxMultiplayerManager_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__InitXboxMultiplayerManager_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__InitXboxMultiplayerManager_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__InitXboxMultiplayerManager_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->LobbySessionTemplateName), LobbySessionTemplateName);
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__InitXboxMultiplayerManager_NativeFunctionPtr, (void*)ptr);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__InitXboxMultiplayerManager_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x060086BA RID: 34490 RVA: 0x000C9704 File Offset: 0x000C7904
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void GetXboxUserPurchaseIdAsync(long UserHandle, string ServiceTicket, string PublisherUserId, [Nullable(2)] FOnXboxUserStoreIdResult Callback)
		{
			UKuroStaticXSXLibrary.__GetXboxUserPurchaseIdAsync_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__GetXboxUserPurchaseIdAsync_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__GetXboxUserPurchaseIdAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__GetXboxUserPurchaseIdAsync_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			FString.CopyFrom((void*)(&ptr->ServiceTicket), ServiceTicket);
			FString.CopyFrom((void*)(&ptr->PublisherUserId), PublisherUserId);
			FScriptDelegate.NativeCopy(&ptr->Callback, (Callback != null) ? Callback.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__GetXboxUserPurchaseIdAsync_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__GetXboxUserPurchaseIdAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060086BB RID: 34491 RVA: 0x000C9790 File Offset: 0x000C7990
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static FXboxUserIdResult GetXboxUserId(long UserHandle)
		{
			UKuroStaticXSXLibrary.__GetXboxUserId_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__GetXboxUserId_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__GetXboxUserId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__GetXboxUserId_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__GetXboxUserId_NativeFunctionPtr, (void*)ptr);
			return new FXboxUserIdResult(&ptr->__Result, true, true);
		}

		// Token: 0x060086BC RID: 34492 RVA: 0x000C97E4 File Offset: 0x000C79E4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void GetXboxUserCollectionsIdAsync(long UserHandle, string ServiceTicket, string PublisherUserId, [Nullable(2)] FOnXboxUserStoreIdResult Callback)
		{
			UKuroStaticXSXLibrary.__GetXboxUserCollectionsIdAsync_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__GetXboxUserCollectionsIdAsync_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__GetXboxUserCollectionsIdAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__GetXboxUserCollectionsIdAsync_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			FString.CopyFrom((void*)(&ptr->ServiceTicket), ServiceTicket);
			FString.CopyFrom((void*)(&ptr->PublisherUserId), PublisherUserId);
			FScriptDelegate.NativeCopy(&ptr->Callback, (Callback != null) ? Callback.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__GetXboxUserCollectionsIdAsync_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__GetXboxUserCollectionsIdAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060086BD RID: 34493 RVA: 0x000C9870 File Offset: 0x000C7A70
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static bool GetXboxUniqueModernGamertag(long UserHandle, ref string OutUniqueModernGamertag)
		{
			UKuroStaticXSXLibrary.__GetXboxUniqueModernGamertag_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__GetXboxUniqueModernGamertag_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__GetXboxUniqueModernGamertag_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__GetXboxUniqueModernGamertag_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			FString.CopyFrom((void*)(&ptr->OutUniqueModernGamertag), OutUniqueModernGamertag);
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__GetXboxUniqueModernGamertag_NativeFunctionPtr, (void*)ptr);
			OutUniqueModernGamertag = FString.ToString((void*)(&ptr->OutUniqueModernGamertag));
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__GetXboxUniqueModernGamertag_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x060086BE RID: 34494 RVA: 0x000C98E8 File Offset: 0x000C7AE8
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void GetXboxTokenAndSignatureAsync(long UserHandle, string Url, [Nullable(2)] FOnXboxTokenAndSignatureResult Callback)
		{
			UKuroStaticXSXLibrary.__GetXboxTokenAndSignatureAsync_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__GetXboxTokenAndSignatureAsync_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__GetXboxTokenAndSignatureAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__GetXboxTokenAndSignatureAsync_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			FString.CopyFrom((void*)(&ptr->Url), Url);
			FScriptDelegate.NativeCopy(&ptr->Callback, (Callback != null) ? Callback.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__GetXboxTokenAndSignatureAsync_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__GetXboxTokenAndSignatureAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060086BF RID: 34495 RVA: 0x000C9964 File Offset: 0x000C7B64
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static bool GetXboxMultiplayerActivity(long UserHandle, long TargetXuid, ref string OutConnectionString, ref int OutMaxPlayers, ref int OutCurrentPlayers, ref string OutGroupId)
		{
			UKuroStaticXSXLibrary.__GetXboxMultiplayerActivity_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__GetXboxMultiplayerActivity_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__GetXboxMultiplayerActivity_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__GetXboxMultiplayerActivity_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			ptr->TargetXuid = TargetXuid;
			FString.CopyFrom((void*)(&ptr->OutConnectionString), OutConnectionString);
			ptr->OutMaxPlayers = OutMaxPlayers;
			ptr->OutCurrentPlayers = OutCurrentPlayers;
			FString.CopyFrom((void*)(&ptr->OutGroupId), OutGroupId);
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__GetXboxMultiplayerActivity_NativeFunctionPtr, (void*)ptr);
			OutConnectionString = FString.ToString((void*)(&ptr->OutConnectionString));
			OutMaxPlayers = ptr->OutMaxPlayers;
			OutCurrentPlayers = ptr->OutCurrentPlayers;
			OutGroupId = FString.ToString((void*)(&ptr->OutGroupId));
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__GetXboxMultiplayerActivity_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x060086C0 RID: 34496 RVA: 0x000C9A24 File Offset: 0x000C7C24
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static bool GetXboxModernGamertagSuffix(long UserHandle, ref string OutSuffix)
		{
			UKuroStaticXSXLibrary.__GetXboxModernGamertagSuffix_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__GetXboxModernGamertagSuffix_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__GetXboxModernGamertagSuffix_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__GetXboxModernGamertagSuffix_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			FString.CopyFrom((void*)(&ptr->OutSuffix), OutSuffix);
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__GetXboxModernGamertagSuffix_NativeFunctionPtr, (void*)ptr);
			OutSuffix = FString.ToString((void*)(&ptr->OutSuffix));
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__GetXboxModernGamertagSuffix_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x060086C1 RID: 34497 RVA: 0x000C9A9C File Offset: 0x000C7C9C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static bool GetXboxModernGamertag(long UserHandle, ref string OutGamertag)
		{
			UKuroStaticXSXLibrary.__GetXboxModernGamertag_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__GetXboxModernGamertag_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__GetXboxModernGamertag_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__GetXboxModernGamertag_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			FString.CopyFrom((void*)(&ptr->OutGamertag), OutGamertag);
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__GetXboxModernGamertag_NativeFunctionPtr, (void*)ptr);
			OutGamertag = FString.ToString((void*)(&ptr->OutGamertag));
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__GetXboxModernGamertag_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x060086C2 RID: 34498 RVA: 0x000C9B14 File Offset: 0x000C7D14
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static FXboxGamertagResult GetXboxGamertagForDisplay(long UserHandle, EXboxGamertagComponent Component)
		{
			UKuroStaticXSXLibrary.__GetXboxGamertagForDisplay_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__GetXboxGamertagForDisplay_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__GetXboxGamertagForDisplay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__GetXboxGamertagForDisplay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			ptr->Component = Component;
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__GetXboxGamertagForDisplay_NativeFunctionPtr, (void*)ptr);
			FXboxGamertagResult result = new FXboxGamertagResult(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__GetXboxGamertagForDisplay_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060086C3 RID: 34499 RVA: 0x000C9B80 File Offset: 0x000C7D80
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static bool GetXboxGamertagByType(long UserHandle, EXboxGamertagComponent Component, ref string OutGamertag)
		{
			UKuroStaticXSXLibrary.__GetXboxGamertagByType_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__GetXboxGamertagByType_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__GetXboxGamertagByType_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__GetXboxGamertagByType_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			ptr->Component = Component;
			FString.CopyFrom((void*)(&ptr->OutGamertag), OutGamertag);
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__GetXboxGamertagByType_NativeFunctionPtr, (void*)ptr);
			OutGamertag = FString.ToString((void*)(&ptr->OutGamertag));
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__GetXboxGamertagByType_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x060086C4 RID: 34500 RVA: 0x000C9C00 File Offset: 0x000C7E00
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static bool GetXboxGamertagAllComponents(long UserHandle, ref string OutModernGamertag, ref string OutSuffix, ref string OutUniqueModernGamertag, ref string OutClassicGamertag)
		{
			UKuroStaticXSXLibrary.__GetXboxGamertagAllComponents_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__GetXboxGamertagAllComponents_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__GetXboxGamertagAllComponents_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__GetXboxGamertagAllComponents_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			FString.CopyFrom((void*)(&ptr->OutModernGamertag), OutModernGamertag);
			FString.CopyFrom((void*)(&ptr->OutSuffix), OutSuffix);
			FString.CopyFrom((void*)(&ptr->OutUniqueModernGamertag), OutUniqueModernGamertag);
			FString.CopyFrom((void*)(&ptr->OutClassicGamertag), OutClassicGamertag);
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__GetXboxGamertagAllComponents_NativeFunctionPtr, (void*)ptr);
			OutModernGamertag = FString.ToString((void*)(&ptr->OutModernGamertag));
			OutSuffix = FString.ToString((void*)(&ptr->OutSuffix));
			OutUniqueModernGamertag = FString.ToString((void*)(&ptr->OutUniqueModernGamertag));
			OutClassicGamertag = FString.ToString((void*)(&ptr->OutClassicGamertag));
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__GetXboxGamertagAllComponents_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x060086C5 RID: 34501 RVA: 0x000C9CD0 File Offset: 0x000C7ED0
		[SkipLocalsInit]
		public unsafe static bool GetXboxDefaultUserHandle(ref long OutUserHandle)
		{
			UKuroStaticXSXLibrary.__GetXboxDefaultUserHandle_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__GetXboxDefaultUserHandle_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__GetXboxDefaultUserHandle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__GetXboxDefaultUserHandle_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutUserHandle = OutUserHandle;
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__GetXboxDefaultUserHandle_NativeFunctionPtr, (void*)ptr);
			OutUserHandle = ptr->OutUserHandle;
			return ptr->__Result;
		}

		// Token: 0x060086C6 RID: 34502 RVA: 0x000C9D24 File Offset: 0x000C7F24
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static bool GetXboxClassicGamertag(long UserHandle, ref string OutGamertag)
		{
			UKuroStaticXSXLibrary.__GetXboxClassicGamertag_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__GetXboxClassicGamertag_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__GetXboxClassicGamertag_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__GetXboxClassicGamertag_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			FString.CopyFrom((void*)(&ptr->OutGamertag), OutGamertag);
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__GetXboxClassicGamertag_NativeFunctionPtr, (void*)ptr);
			OutGamertag = FString.ToString((void*)(&ptr->OutGamertag));
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__GetXboxClassicGamertag_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x060086C7 RID: 34503 RVA: 0x000C9D9C File Offset: 0x000C7F9C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void GetXboxAvoidListAsync(long UserHandle, FOnXboxAvoidListResult Callback)
		{
			UKuroStaticXSXLibrary.__GetXboxAvoidListAsync_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__GetXboxAvoidListAsync_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__GetXboxAvoidListAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__GetXboxAvoidListAsync_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			FScriptDelegate.NativeCopy(&ptr->Callback, (Callback != null) ? Callback.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__GetXboxAvoidListAsync_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__GetXboxAvoidListAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060086C8 RID: 34504 RVA: 0x000C9E0C File Offset: 0x000C800C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static FXboxAvoidListResult GetXboxAvoidList(long UserHandle)
		{
			UKuroStaticXSXLibrary.__GetXboxAvoidList_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__GetXboxAvoidList_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__GetXboxAvoidList_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__GetXboxAvoidList_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__GetXboxAvoidList_NativeFunctionPtr, (void*)ptr);
			FXboxAvoidListResult result = new FXboxAvoidListResult(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__GetXboxAvoidList_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060086C9 RID: 34505 RVA: 0x000C9E70 File Offset: 0x000C8070
		[SkipLocalsInit]
		public unsafe static void GetXboxAchievementsAsync(long UserHandle, long Xuid, EXboxAchievementType AchievementType, bool bUnlockedOnly, EXboxAchievementOrderBy OrderBy, int SkipItems, int MaxItems)
		{
			UKuroStaticXSXLibrary.__GetXboxAchievementsAsync_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__GetXboxAchievementsAsync_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__GetXboxAchievementsAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__GetXboxAchievementsAsync_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			ptr->Xuid = Xuid;
			ptr->AchievementType = AchievementType;
			ptr->bUnlockedOnly = bUnlockedOnly;
			ptr->OrderBy = OrderBy;
			ptr->SkipItems = SkipItems;
			ptr->MaxItems = MaxItems;
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__GetXboxAchievementsAsync_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060086CA RID: 34506 RVA: 0x000C9EE4 File Offset: 0x000C80E4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static FXboxInviteInfo GetLastXboxInviteInfo()
		{
			UKuroStaticXSXLibrary.__GetLastXboxInviteInfo_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__GetLastXboxInviteInfo_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__GetLastXboxInviteInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__GetLastXboxInviteInfo_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__GetLastXboxInviteInfo_NativeFunctionPtr, (void*)ptr);
			FXboxInviteInfo result = new FXboxInviteInfo(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__GetLastXboxInviteInfo_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060086CB RID: 34507 RVA: 0x000C9F44 File Offset: 0x000C8144
		[SkipLocalsInit]
		public unsafe static void FlushXboxMultiplayerActivityRecentPlayersAsync(long UserHandle)
		{
			UKuroStaticXSXLibrary.__FlushXboxMultiplayerActivityRecentPlayersAsync_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__FlushXboxMultiplayerActivityRecentPlayersAsync_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__FlushXboxMultiplayerActivityRecentPlayersAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__FlushXboxMultiplayerActivityRecentPlayersAsync_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__FlushXboxMultiplayerActivityRecentPlayersAsync_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060086CC RID: 34508 RVA: 0x000C9F8C File Offset: 0x000C818C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void DeleteXboxMultiplayerActivityAsync(long UserHandle, FOnXboxCallResult Callback)
		{
			UKuroStaticXSXLibrary.__DeleteXboxMultiplayerActivityAsync_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__DeleteXboxMultiplayerActivityAsync_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__DeleteXboxMultiplayerActivityAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__DeleteXboxMultiplayerActivityAsync_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			FScriptDelegate.NativeCopy(&ptr->Callback, (Callback != null) ? Callback.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__DeleteXboxMultiplayerActivityAsync_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__DeleteXboxMultiplayerActivityAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060086CD RID: 34509 RVA: 0x000C9FFC File Offset: 0x000C81FC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static FXboxMultiplayerPrivilegeResult CheckXboxPrivilege(long UserHandle, EXboxUserPrivilege Privilege, EXboxUserPrivilegeOptions Options)
		{
			UKuroStaticXSXLibrary.__CheckXboxPrivilege_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__CheckXboxPrivilege_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__CheckXboxPrivilege_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__CheckXboxPrivilege_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			ptr->Privilege = Privilege;
			ptr->Options = Options;
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__CheckXboxPrivilege_NativeFunctionPtr, (void*)ptr);
			return new FXboxMultiplayerPrivilegeResult(&ptr->__Result, true, true);
		}

		// Token: 0x060086CE RID: 34510 RVA: 0x000CA060 File Offset: 0x000C8260
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void CheckXboxPermissionAsync(long UserHandle, long TargetXuid, EXboxPermission Permission, FOnXboxPermissionCheckResult Callback)
		{
			UKuroStaticXSXLibrary.__CheckXboxPermissionAsync_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__CheckXboxPermissionAsync_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__CheckXboxPermissionAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__CheckXboxPermissionAsync_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			ptr->TargetXuid = TargetXuid;
			ptr->Permission = Permission;
			FScriptDelegate.NativeCopy(&ptr->Callback, (Callback != null) ? Callback.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__CheckXboxPermissionAsync_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__CheckXboxPermissionAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060086CF RID: 34511 RVA: 0x000CA0E0 File Offset: 0x000C82E0
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static FXboxMultiplayerPrivilegeResult CheckXboxMultiplayerPrivilege(long UserHandle)
		{
			UKuroStaticXSXLibrary.__CheckXboxMultiplayerPrivilege_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__CheckXboxMultiplayerPrivilege_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__CheckXboxMultiplayerPrivilege_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__CheckXboxMultiplayerPrivilege_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__CheckXboxMultiplayerPrivilege_NativeFunctionPtr, (void*)ptr);
			return new FXboxMultiplayerPrivilegeResult(&ptr->__Result, true, true);
		}

		// Token: 0x060086D0 RID: 34512 RVA: 0x000CA133 File Offset: 0x000C8333
		static UKuroStaticXSXLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroStaticXSXLibrary");
		}

		// Token: 0x060086D1 RID: 34513 RVA: 0x000CA141 File Offset: 0x000C8341
		protected UKuroStaticXSXLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003A84 RID: 14980
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroStaticXSXLibrary";

		// Token: 0x04003A85 RID: 14981
		private static IntPtr _ClassPtr;

		// Token: 0x04003A86 RID: 14982
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003A87 RID: 14983
		private static IntPtr __XboxMultiplayerManagerLobbyAddLocalUser_NativeFunctionPtr;

		// Token: 0x04003A88 RID: 14984
		private static IntPtr __XboxMultiplayerManagerJoinLobby_NativeFunctionPtr;

		// Token: 0x04003A89 RID: 14985
		private static IntPtr __XboxMultiplayerManagerJoinGameWithName_NativeFunctionPtr;

		// Token: 0x04003A8A RID: 14986
		private static IntPtr __XboxMultiplayerManagerJoinGameFromLobby_NativeFunctionPtr;

		// Token: 0x04003A8B RID: 14987
		private static IntPtr __UpdateXboxMultiplayerActivityRecentPlayersAsync_NativeFunctionPtr;

		// Token: 0x04003A8C RID: 14988
		private static IntPtr __UpdateXboxAchievementAsync_NativeFunctionPtr;

		// Token: 0x04003A8D RID: 14989
		private static IntPtr __UnregisterXboxAchievementUpdatedCallback_NativeFunctionPtr;

		// Token: 0x04003A8E RID: 14990
		private static IntPtr __UnregisterXboxAchievementsCallback_NativeFunctionPtr;

		// Token: 0x04003A8F RID: 14991
		private static IntPtr __UnregisterFromXboxGameInviteEvent_NativeFunctionPtr;

		// Token: 0x04003A90 RID: 14992
		private static IntPtr __ShowXboxPlayerProfileCard_NativeFunctionPtr;

		// Token: 0x04003A91 RID: 14993
		private static IntPtr __ShowXboxMultiplayerActivityGameInvite_NativeFunctionPtr;

		// Token: 0x04003A92 RID: 14994
		private static IntPtr __ShowKeyBoard_NativeFunctionPtr;

		// Token: 0x04003A93 RID: 14995
		private static IntPtr __SetXboxMultiplayerActivityAsync_NativeFunctionPtr;

		// Token: 0x04003A94 RID: 14996
		private static IntPtr __SendXboxMultiplayerActivityInvites_NativeFunctionPtr;

		// Token: 0x04003A95 RID: 14997
		private static IntPtr __ResolveXboxPrivilegeWithUi_NativeFunctionPtr;

		// Token: 0x04003A96 RID: 14998
		private static IntPtr __ResolveXboxMultiplayerPrivilegeWithUi_NativeFunctionPtr;

		// Token: 0x04003A97 RID: 14999
		private static IntPtr __RegisterXboxAchievementUpdatedCallback_NativeFunctionPtr;

		// Token: 0x04003A98 RID: 15000
		private static IntPtr __RegisterXboxAchievementsCallback_NativeFunctionPtr;

		// Token: 0x04003A99 RID: 15001
		private static IntPtr __RegisterForXboxGameInviteEventWithCallback_NativeFunctionPtr;

		// Token: 0x04003A9A RID: 15002
		private static IntPtr __RegisterForXboxGameInviteEvent_NativeFunctionPtr;

		// Token: 0x04003A9B RID: 15003
		private static IntPtr __InitXboxMultiplayerManager_NativeFunctionPtr;

		// Token: 0x04003A9C RID: 15004
		private static IntPtr __GetXboxUserPurchaseIdAsync_NativeFunctionPtr;

		// Token: 0x04003A9D RID: 15005
		private static IntPtr __GetXboxUserId_NativeFunctionPtr;

		// Token: 0x04003A9E RID: 15006
		private static IntPtr __GetXboxUserCollectionsIdAsync_NativeFunctionPtr;

		// Token: 0x04003A9F RID: 15007
		private static IntPtr __GetXboxUniqueModernGamertag_NativeFunctionPtr;

		// Token: 0x04003AA0 RID: 15008
		private static IntPtr __GetXboxTokenAndSignatureAsync_NativeFunctionPtr;

		// Token: 0x04003AA1 RID: 15009
		private static IntPtr __GetXboxMultiplayerActivity_NativeFunctionPtr;

		// Token: 0x04003AA2 RID: 15010
		private static IntPtr __GetXboxModernGamertagSuffix_NativeFunctionPtr;

		// Token: 0x04003AA3 RID: 15011
		private static IntPtr __GetXboxModernGamertag_NativeFunctionPtr;

		// Token: 0x04003AA4 RID: 15012
		private static IntPtr __GetXboxGamertagForDisplay_NativeFunctionPtr;

		// Token: 0x04003AA5 RID: 15013
		private static IntPtr __GetXboxGamertagByType_NativeFunctionPtr;

		// Token: 0x04003AA6 RID: 15014
		private static IntPtr __GetXboxGamertagAllComponents_NativeFunctionPtr;

		// Token: 0x04003AA7 RID: 15015
		private static IntPtr __GetXboxDefaultUserHandle_NativeFunctionPtr;

		// Token: 0x04003AA8 RID: 15016
		private static IntPtr __GetXboxClassicGamertag_NativeFunctionPtr;

		// Token: 0x04003AA9 RID: 15017
		private static IntPtr __GetXboxAvoidListAsync_NativeFunctionPtr;

		// Token: 0x04003AAA RID: 15018
		private static IntPtr __GetXboxAvoidList_NativeFunctionPtr;

		// Token: 0x04003AAB RID: 15019
		private static IntPtr __GetXboxAchievementsAsync_NativeFunctionPtr;

		// Token: 0x04003AAC RID: 15020
		private static IntPtr __GetLastXboxInviteInfo_NativeFunctionPtr;

		// Token: 0x04003AAD RID: 15021
		private static IntPtr __FlushXboxMultiplayerActivityRecentPlayersAsync_NativeFunctionPtr;

		// Token: 0x04003AAE RID: 15022
		private static IntPtr __DeleteXboxMultiplayerActivityAsync_NativeFunctionPtr;

		// Token: 0x04003AAF RID: 15023
		private static IntPtr __CheckXboxPrivilege_NativeFunctionPtr;

		// Token: 0x04003AB0 RID: 15024
		private static IntPtr __CheckXboxPermissionAsync_NativeFunctionPtr;

		// Token: 0x04003AB1 RID: 15025
		private static IntPtr __CheckXboxMultiplayerPrivilege_NativeFunctionPtr;

		// Token: 0x02000DC3 RID: 3523
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __XboxMultiplayerManagerLobbyAddLocalUser_FunctionParams
		{
			// Token: 0x040060F7 RID: 24823
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x040060F8 RID: 24824
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x02000DC4 RID: 3524
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __XboxMultiplayerManagerJoinLobby_FunctionParams
		{
			// Token: 0x040060F9 RID: 24825
			[FieldOffset(0)]
			public FString InviteHandleId;

			// Token: 0x040060FA RID: 24826
			[FieldOffset(16)]
			public long UserHandle;

			// Token: 0x040060FB RID: 24827
			[FieldOffset(24)]
			public bool __Result;
		}

		// Token: 0x02000DC5 RID: 3525
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __XboxMultiplayerManagerJoinGameWithName_FunctionParams
		{
			// Token: 0x040060FC RID: 24828
			[FieldOffset(0)]
			public FString SessionName;

			// Token: 0x040060FD RID: 24829
			[FieldOffset(16)]
			public FString SessionTemplateName;

			// Token: 0x040060FE RID: 24830
			[FieldOffset(32)]
			public byte Xuids;

			// Token: 0x040060FF RID: 24831
			[FieldOffset(48)]
			public bool __Result;
		}

		// Token: 0x02000DC6 RID: 3526
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __XboxMultiplayerManagerJoinGameFromLobby_FunctionParams
		{
			// Token: 0x04006100 RID: 24832
			[FieldOffset(0)]
			public FString SessionTemplateName;

			// Token: 0x04006101 RID: 24833
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02000DC7 RID: 3527
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __UpdateXboxMultiplayerActivityRecentPlayersAsync_FunctionParams
		{
			// Token: 0x04006102 RID: 24834
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x04006103 RID: 24835
			[FieldOffset(8)]
			public byte Updates;

			// Token: 0x04006104 RID: 24836
			[FieldOffset(24)]
			public byte Callback;
		}

		// Token: 0x02000DC8 RID: 3528
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __UpdateXboxAchievementAsync_FunctionParams
		{
			// Token: 0x04006105 RID: 24837
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x04006106 RID: 24838
			[FieldOffset(8)]
			public long Xuid;

			// Token: 0x04006107 RID: 24839
			[FieldOffset(16)]
			public FString AchievementId;

			// Token: 0x04006108 RID: 24840
			[FieldOffset(32)]
			public int PercentComplete;
		}

		// Token: 0x02000DC9 RID: 3529
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __ShowXboxPlayerProfileCard_FunctionParams
		{
			// Token: 0x04006109 RID: 24841
			[FieldOffset(0)]
			public long LocalUserHandle;

			// Token: 0x0400610A RID: 24842
			[FieldOffset(8)]
			public long TargetXuid;

			// Token: 0x0400610B RID: 24843
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02000DCA RID: 3530
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ShowXboxMultiplayerActivityGameInvite_FunctionParams
		{
			// Token: 0x0400610C RID: 24844
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x0400610D RID: 24845
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x02000DCB RID: 3531
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __ShowKeyBoard_FunctionParams
		{
			// Token: 0x0400610E RID: 24846
			[FieldOffset(0)]
			public bool State;

			// Token: 0x0400610F RID: 24847
			[FieldOffset(1)]
			public bool __Result;
		}

		// Token: 0x02000DCC RID: 3532
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 104)]
		protected ref struct __SetXboxMultiplayerActivityAsync_FunctionParams
		{
			// Token: 0x04006110 RID: 24848
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x04006111 RID: 24849
			[FieldOffset(8)]
			public long xuid;

			// Token: 0x04006112 RID: 24850
			[FieldOffset(16)]
			public FString ConnectionString;

			// Token: 0x04006113 RID: 24851
			[FieldOffset(32)]
			public int MaxPlayers;

			// Token: 0x04006114 RID: 24852
			[FieldOffset(36)]
			public int CurrentPlayers;

			// Token: 0x04006115 RID: 24853
			[FieldOffset(40)]
			public FString GroupId;

			// Token: 0x04006116 RID: 24854
			[FieldOffset(56)]
			public EXboxMultiplayerActivityJoinRestriction JoinRestriction;

			// Token: 0x04006117 RID: 24855
			[FieldOffset(57)]
			public bool bAllowCrossPlatformJoin;

			// Token: 0x04006118 RID: 24856
			[FieldOffset(64)]
			public byte Callback;
		}

		// Token: 0x02000DCD RID: 3533
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __SendXboxMultiplayerActivityInvites_FunctionParams
		{
			// Token: 0x04006119 RID: 24857
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x0400611A RID: 24858
			[FieldOffset(8)]
			public byte TargetXuids;

			// Token: 0x0400611B RID: 24859
			[FieldOffset(24)]
			public bool bCrossNetwork;

			// Token: 0x0400611C RID: 24860
			[FieldOffset(32)]
			public FString ConnectionString;

			// Token: 0x0400611D RID: 24861
			[FieldOffset(48)]
			public bool __Result;
		}

		// Token: 0x02000DCE RID: 3534
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ResolveXboxPrivilegeWithUi_FunctionParams
		{
			// Token: 0x0400611E RID: 24862
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x0400611F RID: 24863
			[FieldOffset(8)]
			public EXboxUserPrivilege Privilege;

			// Token: 0x04006120 RID: 24864
			[FieldOffset(9)]
			public EXboxUserPrivilegeOptions Options;

			// Token: 0x04006121 RID: 24865
			[FieldOffset(10)]
			public bool __Result;
		}

		// Token: 0x02000DCF RID: 3535
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ResolveXboxMultiplayerPrivilegeWithUi_FunctionParams
		{
			// Token: 0x04006122 RID: 24866
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x04006123 RID: 24867
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x02000DD0 RID: 3536
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __RegisterXboxAchievementUpdatedCallback_FunctionParams
		{
			// Token: 0x04006124 RID: 24868
			[FieldOffset(0)]
			public byte Callback;
		}

		// Token: 0x02000DD1 RID: 3537
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __RegisterXboxAchievementsCallback_FunctionParams
		{
			// Token: 0x04006125 RID: 24869
			[FieldOffset(0)]
			public byte Callback;
		}

		// Token: 0x02000DD2 RID: 3538
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __RegisterForXboxGameInviteEventWithCallback_FunctionParams
		{
			// Token: 0x04006126 RID: 24870
			[FieldOffset(0)]
			public byte Callback;

			// Token: 0x04006127 RID: 24871
			[FieldOffset(40)]
			public bool __Result;
		}

		// Token: 0x02000DD3 RID: 3539
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __RegisterForXboxGameInviteEvent_FunctionParams
		{
			// Token: 0x04006128 RID: 24872
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000DD4 RID: 3540
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __InitXboxMultiplayerManager_FunctionParams
		{
			// Token: 0x04006129 RID: 24873
			[FieldOffset(0)]
			public FString LobbySessionTemplateName;

			// Token: 0x0400612A RID: 24874
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02000DD5 RID: 3541
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetXboxUserPurchaseIdAsync_FunctionParams
		{
			// Token: 0x0400612B RID: 24875
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x0400612C RID: 24876
			[FieldOffset(8)]
			public FString ServiceTicket;

			// Token: 0x0400612D RID: 24877
			[FieldOffset(24)]
			public FString PublisherUserId;

			// Token: 0x0400612E RID: 24878
			[FieldOffset(40)]
			public byte Callback;
		}

		// Token: 0x02000DD6 RID: 3542
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetXboxUserId_FunctionParams
		{
			// Token: 0x0400612F RID: 24879
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x04006130 RID: 24880
			[FieldOffset(8)]
			public byte __Result;
		}

		// Token: 0x02000DD7 RID: 3543
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetXboxUserCollectionsIdAsync_FunctionParams
		{
			// Token: 0x04006131 RID: 24881
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x04006132 RID: 24882
			[FieldOffset(8)]
			public FString ServiceTicket;

			// Token: 0x04006133 RID: 24883
			[FieldOffset(24)]
			public FString PublisherUserId;

			// Token: 0x04006134 RID: 24884
			[FieldOffset(40)]
			public byte Callback;
		}

		// Token: 0x02000DD8 RID: 3544
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetXboxUniqueModernGamertag_FunctionParams
		{
			// Token: 0x04006135 RID: 24885
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x04006136 RID: 24886
			[FieldOffset(8)]
			public FString OutUniqueModernGamertag;

			// Token: 0x04006137 RID: 24887
			[FieldOffset(24)]
			public bool __Result;
		}

		// Token: 0x02000DD9 RID: 3545
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __GetXboxTokenAndSignatureAsync_FunctionParams
		{
			// Token: 0x04006138 RID: 24888
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x04006139 RID: 24889
			[FieldOffset(8)]
			public FString Url;

			// Token: 0x0400613A RID: 24890
			[FieldOffset(24)]
			public byte Callback;
		}

		// Token: 0x02000DDA RID: 3546
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __GetXboxMultiplayerActivity_FunctionParams
		{
			// Token: 0x0400613B RID: 24891
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x0400613C RID: 24892
			[FieldOffset(8)]
			public long TargetXuid;

			// Token: 0x0400613D RID: 24893
			[FieldOffset(16)]
			public FString OutConnectionString;

			// Token: 0x0400613E RID: 24894
			[FieldOffset(32)]
			public int OutMaxPlayers;

			// Token: 0x0400613F RID: 24895
			[FieldOffset(36)]
			public int OutCurrentPlayers;

			// Token: 0x04006140 RID: 24896
			[FieldOffset(40)]
			public FString OutGroupId;

			// Token: 0x04006141 RID: 24897
			[FieldOffset(56)]
			public bool __Result;
		}

		// Token: 0x02000DDB RID: 3547
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetXboxModernGamertagSuffix_FunctionParams
		{
			// Token: 0x04006142 RID: 24898
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x04006143 RID: 24899
			[FieldOffset(8)]
			public FString OutSuffix;

			// Token: 0x04006144 RID: 24900
			[FieldOffset(24)]
			public bool __Result;
		}

		// Token: 0x02000DDC RID: 3548
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetXboxModernGamertag_FunctionParams
		{
			// Token: 0x04006145 RID: 24901
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x04006146 RID: 24902
			[FieldOffset(8)]
			public FString OutGamertag;

			// Token: 0x04006147 RID: 24903
			[FieldOffset(24)]
			public bool __Result;
		}

		// Token: 0x02000DDD RID: 3549
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __GetXboxGamertagForDisplay_FunctionParams
		{
			// Token: 0x04006148 RID: 24904
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x04006149 RID: 24905
			[FieldOffset(8)]
			public EXboxGamertagComponent Component;

			// Token: 0x0400614A RID: 24906
			[FieldOffset(16)]
			public byte __Result;
		}

		// Token: 0x02000DDE RID: 3550
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __GetXboxGamertagByType_FunctionParams
		{
			// Token: 0x0400614B RID: 24907
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x0400614C RID: 24908
			[FieldOffset(8)]
			public EXboxGamertagComponent Component;

			// Token: 0x0400614D RID: 24909
			[FieldOffset(16)]
			public FString OutGamertag;

			// Token: 0x0400614E RID: 24910
			[FieldOffset(32)]
			public bool __Result;
		}

		// Token: 0x02000DDF RID: 3551
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetXboxGamertagAllComponents_FunctionParams
		{
			// Token: 0x0400614F RID: 24911
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x04006150 RID: 24912
			[FieldOffset(8)]
			public FString OutModernGamertag;

			// Token: 0x04006151 RID: 24913
			[FieldOffset(24)]
			public FString OutSuffix;

			// Token: 0x04006152 RID: 24914
			[FieldOffset(40)]
			public FString OutUniqueModernGamertag;

			// Token: 0x04006153 RID: 24915
			[FieldOffset(56)]
			public FString OutClassicGamertag;

			// Token: 0x04006154 RID: 24916
			[FieldOffset(72)]
			public bool __Result;
		}

		// Token: 0x02000DE0 RID: 3552
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetXboxDefaultUserHandle_FunctionParams
		{
			// Token: 0x04006155 RID: 24917
			[FieldOffset(0)]
			public long OutUserHandle;

			// Token: 0x04006156 RID: 24918
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x02000DE1 RID: 3553
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetXboxClassicGamertag_FunctionParams
		{
			// Token: 0x04006157 RID: 24919
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x04006158 RID: 24920
			[FieldOffset(8)]
			public FString OutGamertag;

			// Token: 0x04006159 RID: 24921
			[FieldOffset(24)]
			public bool __Result;
		}

		// Token: 0x02000DE2 RID: 3554
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __GetXboxAvoidListAsync_FunctionParams
		{
			// Token: 0x0400615A RID: 24922
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x0400615B RID: 24923
			[FieldOffset(8)]
			public byte Callback;
		}

		// Token: 0x02000DE3 RID: 3555
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetXboxAvoidList_FunctionParams
		{
			// Token: 0x0400615C RID: 24924
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x0400615D RID: 24925
			[FieldOffset(8)]
			public byte __Result;
		}

		// Token: 0x02000DE4 RID: 3556
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetXboxAchievementsAsync_FunctionParams
		{
			// Token: 0x0400615E RID: 24926
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x0400615F RID: 24927
			[FieldOffset(8)]
			public long Xuid;

			// Token: 0x04006160 RID: 24928
			[FieldOffset(16)]
			public EXboxAchievementType AchievementType;

			// Token: 0x04006161 RID: 24929
			[FieldOffset(17)]
			public bool bUnlockedOnly;

			// Token: 0x04006162 RID: 24930
			[FieldOffset(18)]
			public EXboxAchievementOrderBy OrderBy;

			// Token: 0x04006163 RID: 24931
			[FieldOffset(20)]
			public int SkipItems;

			// Token: 0x04006164 RID: 24932
			[FieldOffset(24)]
			public int MaxItems;
		}

		// Token: 0x02000DE5 RID: 3557
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __GetLastXboxInviteInfo_FunctionParams
		{
			// Token: 0x04006165 RID: 24933
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02000DE6 RID: 3558
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FlushXboxMultiplayerActivityRecentPlayersAsync_FunctionParams
		{
			// Token: 0x04006166 RID: 24934
			[FieldOffset(0)]
			public long UserHandle;
		}

		// Token: 0x02000DE7 RID: 3559
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __DeleteXboxMultiplayerActivityAsync_FunctionParams
		{
			// Token: 0x04006167 RID: 24935
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x04006168 RID: 24936
			[FieldOffset(8)]
			public byte Callback;
		}

		// Token: 0x02000DE8 RID: 3560
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __CheckXboxPrivilege_FunctionParams
		{
			// Token: 0x04006169 RID: 24937
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x0400616A RID: 24938
			[FieldOffset(8)]
			public EXboxUserPrivilege Privilege;

			// Token: 0x0400616B RID: 24939
			[FieldOffset(9)]
			public EXboxUserPrivilegeOptions Options;

			// Token: 0x0400616C RID: 24940
			[FieldOffset(12)]
			public byte __Result;
		}

		// Token: 0x02000DE9 RID: 3561
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __CheckXboxPermissionAsync_FunctionParams
		{
			// Token: 0x0400616D RID: 24941
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x0400616E RID: 24942
			[FieldOffset(8)]
			public long TargetXuid;

			// Token: 0x0400616F RID: 24943
			[FieldOffset(16)]
			public EXboxPermission Permission;

			// Token: 0x04006170 RID: 24944
			[FieldOffset(24)]
			public byte Callback;
		}

		// Token: 0x02000DEA RID: 3562
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __CheckXboxMultiplayerPrivilege_FunctionParams
		{
			// Token: 0x04006171 RID: 24945
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x04006172 RID: 24946
			[FieldOffset(8)]
			public byte __Result;
		}
	}
}
