using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001ED5 RID: 7893
	[UnrealObjectPath("/Script/KuroUtility.KuroStaticXSXLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroStaticXSXLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E01D RID: 122909 RVA: 0x002C7686 File Offset: 0x002C5886
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroStaticXSXLibrary._ClassPtr;
		}

		// Token: 0x0601E01E RID: 122910 RVA: 0x002C7694 File Offset: 0x002C5894
		public UKuroStaticXSXLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroStaticXSXLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E01F RID: 122911 RVA: 0x002C76BC File Offset: 0x002C58BC
		[NullableContext(1)]
		public UKuroStaticXSXLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroStaticXSXLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601E020 RID: 122912 RVA: 0x002C76F0 File Offset: 0x002C58F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool XboxMultiplayerManagerLobbyAddLocalUser(long UserHandle)
		{
			UKuroStaticXSXLibrary.__XboxMultiplayerManagerLobbyAddLocalUser_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__XboxMultiplayerManagerLobbyAddLocalUser_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__XboxMultiplayerManagerLobbyAddLocalUser_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__XboxMultiplayerManagerLobbyAddLocalUser_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__XboxMultiplayerManagerLobbyAddLocalUser_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601E021 RID: 122913 RVA: 0x002C773C File Offset: 0x002C593C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool XboxMultiplayerManagerJoinLobby(string InviteHandleId, long UserHandle)
		{
			UKuroStaticXSXLibrary.__XboxMultiplayerManagerJoinLobby_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__XboxMultiplayerManagerJoinLobby_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__XboxMultiplayerManagerJoinLobby_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__XboxMultiplayerManagerJoinLobby_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->InviteHandleId), InviteHandleId);
			ptr->UserHandle = UserHandle;
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__XboxMultiplayerManagerJoinLobby_NativeFunctionPtr, (void*)ptr, 0);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__XboxMultiplayerManagerJoinLobby_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601E022 RID: 122914 RVA: 0x002C77A8 File Offset: 0x002C59A8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__XboxMultiplayerManagerJoinGameWithName_NativeFunctionPtr, (void*)ptr, 0);
			TArray<long> tarray2 = Xuids;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Xuids);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__XboxMultiplayerManagerJoinGameWithName_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601E023 RID: 122915 RVA: 0x002C7840 File Offset: 0x002C5A40
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool XboxMultiplayerManagerJoinGameFromLobby(string SessionTemplateName)
		{
			UKuroStaticXSXLibrary.__XboxMultiplayerManagerJoinGameFromLobby_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__XboxMultiplayerManagerJoinGameFromLobby_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__XboxMultiplayerManagerJoinGameFromLobby_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__XboxMultiplayerManagerJoinGameFromLobby_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->SessionTemplateName), SessionTemplateName);
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__XboxMultiplayerManagerJoinGameFromLobby_NativeFunctionPtr, (void*)ptr, 0);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__XboxMultiplayerManagerJoinGameFromLobby_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601E024 RID: 122916 RVA: 0x002C78A4 File Offset: 0x002C5AA4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static TArray<FXboxMultiplayerEvent> XboxMultiplayerManagerDoWork()
		{
			UKuroStaticXSXLibrary.__XboxMultiplayerManagerDoWork_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__XboxMultiplayerManagerDoWork_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__XboxMultiplayerManagerDoWork_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__XboxMultiplayerManagerDoWork_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__XboxMultiplayerManagerDoWork_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FXboxMultiplayerEvent> result = new TArray<FXboxMultiplayerEvent>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__XboxMultiplayerManagerDoWork_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601E025 RID: 122917 RVA: 0x002C7904 File Offset: 0x002C5B04
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__UpdateXboxMultiplayerActivityRecentPlayersAsync_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FXboxRecentPlayerUpdate> tarray2 = Updates;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Updates);
			}
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__UpdateXboxMultiplayerActivityRecentPlayersAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601E026 RID: 122918 RVA: 0x002C799C File Offset: 0x002C5B9C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void UpdateXboxAchievementAsync(long UserHandle, long Xuid, string AchievementId, int PercentComplete)
		{
			UKuroStaticXSXLibrary.__UpdateXboxAchievementAsync_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__UpdateXboxAchievementAsync_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__UpdateXboxAchievementAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__UpdateXboxAchievementAsync_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			ptr->Xuid = Xuid;
			FString.CopyFrom((void*)(&ptr->AchievementId), AchievementId);
			ptr->PercentComplete = PercentComplete;
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__UpdateXboxAchievementAsync_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__UpdateXboxAchievementAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601E027 RID: 122919 RVA: 0x002C7A0E File Offset: 0x002C5C0E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void UnregisterXboxAchievementUpdatedCallback()
		{
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__UnregisterXboxAchievementUpdatedCallback_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601E028 RID: 122920 RVA: 0x002C7A22 File Offset: 0x002C5C22
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void UnregisterXboxAchievementsCallback()
		{
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__UnregisterXboxAchievementsCallback_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601E029 RID: 122921 RVA: 0x002C7A36 File Offset: 0x002C5C36
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void UnregisterFromXboxGameInviteEvent()
		{
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__UnregisterFromXboxGameInviteEvent_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601E02A RID: 122922 RVA: 0x002C7A4C File Offset: 0x002C5C4C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool ShowXboxPlayerProfileCard(long LocalUserHandle, long TargetXuid)
		{
			UKuroStaticXSXLibrary.__ShowXboxPlayerProfileCard_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__ShowXboxPlayerProfileCard_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__ShowXboxPlayerProfileCard_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__ShowXboxPlayerProfileCard_NativeFunctionPtr, (void*)ptr, 1);
			ptr->LocalUserHandle = LocalUserHandle;
			ptr->TargetXuid = TargetXuid;
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__ShowXboxPlayerProfileCard_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601E02B RID: 122923 RVA: 0x002C7AA0 File Offset: 0x002C5CA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool ShowXboxMultiplayerActivityGameInvite(long UserHandle)
		{
			UKuroStaticXSXLibrary.__ShowXboxMultiplayerActivityGameInvite_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__ShowXboxMultiplayerActivityGameInvite_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__ShowXboxMultiplayerActivityGameInvite_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__ShowXboxMultiplayerActivityGameInvite_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__ShowXboxMultiplayerActivityGameInvite_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601E02C RID: 122924 RVA: 0x002C7AEC File Offset: 0x002C5CEC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool ShowKeyBoard(bool State)
		{
			UKuroStaticXSXLibrary.__ShowKeyBoard_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__ShowKeyBoard_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__ShowKeyBoard_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__ShowKeyBoard_NativeFunctionPtr, (void*)ptr, 1);
			ptr->State = State;
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__ShowKeyBoard_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601E02D RID: 122925 RVA: 0x002C7B38 File Offset: 0x002C5D38
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__SetXboxMultiplayerActivityAsync_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__SetXboxMultiplayerActivityAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601E02E RID: 122926 RVA: 0x002C7BEC File Offset: 0x002C5DEC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__SendXboxMultiplayerActivityInvites_NativeFunctionPtr, (void*)ptr, 0);
			TArray<long> tarray2 = TargetXuids;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->TargetXuids);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__SendXboxMultiplayerActivityInvites_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601E02F RID: 122927 RVA: 0x002C7C88 File Offset: 0x002C5E88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool ResolveXboxPrivilegeWithUi(long UserHandle, EXboxUserPrivilege Privilege, EXboxUserPrivilegeOptions Options)
		{
			UKuroStaticXSXLibrary.__ResolveXboxPrivilegeWithUi_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__ResolveXboxPrivilegeWithUi_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__ResolveXboxPrivilegeWithUi_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__ResolveXboxPrivilegeWithUi_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			ptr->Privilege = Privilege;
			ptr->Options = Options;
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__ResolveXboxPrivilegeWithUi_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601E030 RID: 122928 RVA: 0x002C7CE4 File Offset: 0x002C5EE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool ResolveXboxMultiplayerPrivilegeWithUi(long UserHandle)
		{
			UKuroStaticXSXLibrary.__ResolveXboxMultiplayerPrivilegeWithUi_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__ResolveXboxMultiplayerPrivilegeWithUi_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__ResolveXboxMultiplayerPrivilegeWithUi_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__ResolveXboxMultiplayerPrivilegeWithUi_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__ResolveXboxMultiplayerPrivilegeWithUi_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601E031 RID: 122929 RVA: 0x002C7D30 File Offset: 0x002C5F30
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RegisterXboxAchievementUpdatedCallback(FOnXboxAchievementUpdated Callback)
		{
			UKuroStaticXSXLibrary.__RegisterXboxAchievementUpdatedCallback_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__RegisterXboxAchievementUpdatedCallback_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__RegisterXboxAchievementUpdatedCallback_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__RegisterXboxAchievementUpdatedCallback_NativeFunctionPtr, (void*)ptr, 1);
			FScriptDelegate.NativeCopy(&ptr->Callback, (Callback != null) ? Callback.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__RegisterXboxAchievementUpdatedCallback_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__RegisterXboxAchievementUpdatedCallback_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601E032 RID: 122930 RVA: 0x002C7D9C File Offset: 0x002C5F9C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RegisterXboxAchievementsCallback(FOnXboxAchievementsReceived Callback)
		{
			UKuroStaticXSXLibrary.__RegisterXboxAchievementsCallback_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__RegisterXboxAchievementsCallback_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__RegisterXboxAchievementsCallback_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__RegisterXboxAchievementsCallback_NativeFunctionPtr, (void*)ptr, 1);
			FScriptDelegate.NativeCopy(&ptr->Callback, (Callback != null) ? Callback.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__RegisterXboxAchievementsCallback_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__RegisterXboxAchievementsCallback_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601E033 RID: 122931 RVA: 0x002C7E08 File Offset: 0x002C6008
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool RegisterForXboxGameInviteEventWithCallback(FOnXboxInviteReceivedDynamic Callback)
		{
			UKuroStaticXSXLibrary.__RegisterForXboxGameInviteEventWithCallback_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__RegisterForXboxGameInviteEventWithCallback_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__RegisterForXboxGameInviteEventWithCallback_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__RegisterForXboxGameInviteEventWithCallback_NativeFunctionPtr, (void*)ptr, 1);
			FScriptDelegate.NativeCopy(&ptr->Callback, (Callback != null) ? Callback.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__RegisterForXboxGameInviteEventWithCallback_NativeFunctionPtr, (void*)ptr, 0);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__RegisterForXboxGameInviteEventWithCallback_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601E034 RID: 122932 RVA: 0x002C7E78 File Offset: 0x002C6078
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool RegisterForXboxGameInviteEvent()
		{
			UKuroStaticXSXLibrary.__RegisterForXboxGameInviteEvent_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__RegisterForXboxGameInviteEvent_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__RegisterForXboxGameInviteEvent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__RegisterForXboxGameInviteEvent_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__RegisterForXboxGameInviteEvent_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601E035 RID: 122933 RVA: 0x002C7EC0 File Offset: 0x002C60C0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool InitXboxMultiplayerManager(string LobbySessionTemplateName)
		{
			UKuroStaticXSXLibrary.__InitXboxMultiplayerManager_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__InitXboxMultiplayerManager_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__InitXboxMultiplayerManager_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__InitXboxMultiplayerManager_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->LobbySessionTemplateName), LobbySessionTemplateName);
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__InitXboxMultiplayerManager_NativeFunctionPtr, (void*)ptr, 0);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__InitXboxMultiplayerManager_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601E036 RID: 122934 RVA: 0x002C7F24 File Offset: 0x002C6124
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void GetXboxUserPurchaseIdAsync(long UserHandle, string ServiceTicket, string PublisherUserId, [Nullable(2)] FOnXboxUserStoreIdResult Callback)
		{
			UKuroStaticXSXLibrary.__GetXboxUserPurchaseIdAsync_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__GetXboxUserPurchaseIdAsync_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__GetXboxUserPurchaseIdAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__GetXboxUserPurchaseIdAsync_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			FString.CopyFrom((void*)(&ptr->ServiceTicket), ServiceTicket);
			FString.CopyFrom((void*)(&ptr->PublisherUserId), PublisherUserId);
			FScriptDelegate.NativeCopy(&ptr->Callback, (Callback != null) ? Callback.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__GetXboxUserPurchaseIdAsync_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__GetXboxUserPurchaseIdAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601E037 RID: 122935 RVA: 0x002C7FB0 File Offset: 0x002C61B0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static FXboxUserIdResult GetXboxUserId(long UserHandle)
		{
			UKuroStaticXSXLibrary.__GetXboxUserId_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__GetXboxUserId_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__GetXboxUserId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__GetXboxUserId_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__GetXboxUserId_NativeFunctionPtr, (void*)ptr, 0);
			return new FXboxUserIdResult(&ptr->__Result, true, true);
		}

		// Token: 0x0601E038 RID: 122936 RVA: 0x002C8004 File Offset: 0x002C6204
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void GetXboxUserCollectionsIdAsync(long UserHandle, string ServiceTicket, string PublisherUserId, [Nullable(2)] FOnXboxUserStoreIdResult Callback)
		{
			UKuroStaticXSXLibrary.__GetXboxUserCollectionsIdAsync_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__GetXboxUserCollectionsIdAsync_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__GetXboxUserCollectionsIdAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__GetXboxUserCollectionsIdAsync_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			FString.CopyFrom((void*)(&ptr->ServiceTicket), ServiceTicket);
			FString.CopyFrom((void*)(&ptr->PublisherUserId), PublisherUserId);
			FScriptDelegate.NativeCopy(&ptr->Callback, (Callback != null) ? Callback.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__GetXboxUserCollectionsIdAsync_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__GetXboxUserCollectionsIdAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601E039 RID: 122937 RVA: 0x002C8090 File Offset: 0x002C6290
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool GetXboxUniqueModernGamertag(long UserHandle, ref string OutUniqueModernGamertag)
		{
			UKuroStaticXSXLibrary.__GetXboxUniqueModernGamertag_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__GetXboxUniqueModernGamertag_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__GetXboxUniqueModernGamertag_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__GetXboxUniqueModernGamertag_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			FString.CopyFrom((void*)(&ptr->OutUniqueModernGamertag), OutUniqueModernGamertag);
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__GetXboxUniqueModernGamertag_NativeFunctionPtr, (void*)ptr, 0);
			OutUniqueModernGamertag = FString.ToString((void*)(&ptr->OutUniqueModernGamertag));
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__GetXboxUniqueModernGamertag_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601E03A RID: 122938 RVA: 0x002C810C File Offset: 0x002C630C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void GetXboxTokenAndSignatureAsync(long UserHandle, string Url, [Nullable(2)] FOnXboxTokenAndSignatureResult Callback)
		{
			UKuroStaticXSXLibrary.__GetXboxTokenAndSignatureAsync_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__GetXboxTokenAndSignatureAsync_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__GetXboxTokenAndSignatureAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__GetXboxTokenAndSignatureAsync_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			FString.CopyFrom((void*)(&ptr->Url), Url);
			FScriptDelegate.NativeCopy(&ptr->Callback, (Callback != null) ? Callback.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__GetXboxTokenAndSignatureAsync_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__GetXboxTokenAndSignatureAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601E03B RID: 122939 RVA: 0x002C818C File Offset: 0x002C638C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__GetXboxMultiplayerActivity_NativeFunctionPtr, (void*)ptr, 0);
			OutConnectionString = FString.ToString((void*)(&ptr->OutConnectionString));
			OutMaxPlayers = ptr->OutMaxPlayers;
			OutCurrentPlayers = ptr->OutCurrentPlayers;
			OutGroupId = FString.ToString((void*)(&ptr->OutGroupId));
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__GetXboxMultiplayerActivity_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601E03C RID: 122940 RVA: 0x002C824C File Offset: 0x002C644C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool GetXboxModernGamertagSuffix(long UserHandle, ref string OutSuffix)
		{
			UKuroStaticXSXLibrary.__GetXboxModernGamertagSuffix_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__GetXboxModernGamertagSuffix_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__GetXboxModernGamertagSuffix_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__GetXboxModernGamertagSuffix_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			FString.CopyFrom((void*)(&ptr->OutSuffix), OutSuffix);
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__GetXboxModernGamertagSuffix_NativeFunctionPtr, (void*)ptr, 0);
			OutSuffix = FString.ToString((void*)(&ptr->OutSuffix));
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__GetXboxModernGamertagSuffix_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601E03D RID: 122941 RVA: 0x002C82C8 File Offset: 0x002C64C8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool GetXboxModernGamertag(long UserHandle, ref string OutGamertag)
		{
			UKuroStaticXSXLibrary.__GetXboxModernGamertag_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__GetXboxModernGamertag_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__GetXboxModernGamertag_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__GetXboxModernGamertag_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			FString.CopyFrom((void*)(&ptr->OutGamertag), OutGamertag);
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__GetXboxModernGamertag_NativeFunctionPtr, (void*)ptr, 0);
			OutGamertag = FString.ToString((void*)(&ptr->OutGamertag));
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__GetXboxModernGamertag_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601E03E RID: 122942 RVA: 0x002C8344 File Offset: 0x002C6544
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static FXboxGamertagResult GetXboxGamertagForDisplay(long UserHandle, EXboxGamertagComponent Component)
		{
			UKuroStaticXSXLibrary.__GetXboxGamertagForDisplay_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__GetXboxGamertagForDisplay_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__GetXboxGamertagForDisplay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__GetXboxGamertagForDisplay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			ptr->Component = Component;
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__GetXboxGamertagForDisplay_NativeFunctionPtr, (void*)ptr, 0);
			FXboxGamertagResult result = new FXboxGamertagResult(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__GetXboxGamertagForDisplay_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601E03F RID: 122943 RVA: 0x002C83B0 File Offset: 0x002C65B0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool GetXboxGamertagByType(long UserHandle, EXboxGamertagComponent Component, ref string OutGamertag)
		{
			UKuroStaticXSXLibrary.__GetXboxGamertagByType_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__GetXboxGamertagByType_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__GetXboxGamertagByType_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__GetXboxGamertagByType_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			ptr->Component = Component;
			FString.CopyFrom((void*)(&ptr->OutGamertag), OutGamertag);
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__GetXboxGamertagByType_NativeFunctionPtr, (void*)ptr, 0);
			OutGamertag = FString.ToString((void*)(&ptr->OutGamertag));
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__GetXboxGamertagByType_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601E040 RID: 122944 RVA: 0x002C8430 File Offset: 0x002C6630
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool GetXboxGamertagAllComponents(long UserHandle, ref string OutModernGamertag, ref string OutSuffix, ref string OutUniqueModernGamertag, ref string OutClassicGamertag)
		{
			UKuroStaticXSXLibrary.__GetXboxGamertagAllComponents_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__GetXboxGamertagAllComponents_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__GetXboxGamertagAllComponents_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__GetXboxGamertagAllComponents_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			FString.CopyFrom((void*)(&ptr->OutModernGamertag), OutModernGamertag);
			FString.CopyFrom((void*)(&ptr->OutSuffix), OutSuffix);
			FString.CopyFrom((void*)(&ptr->OutUniqueModernGamertag), OutUniqueModernGamertag);
			FString.CopyFrom((void*)(&ptr->OutClassicGamertag), OutClassicGamertag);
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__GetXboxGamertagAllComponents_NativeFunctionPtr, (void*)ptr, 0);
			OutModernGamertag = FString.ToString((void*)(&ptr->OutModernGamertag));
			OutSuffix = FString.ToString((void*)(&ptr->OutSuffix));
			OutUniqueModernGamertag = FString.ToString((void*)(&ptr->OutUniqueModernGamertag));
			OutClassicGamertag = FString.ToString((void*)(&ptr->OutClassicGamertag));
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__GetXboxGamertagAllComponents_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601E041 RID: 122945 RVA: 0x002C8500 File Offset: 0x002C6700
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static FXboxUserHandleResult GetXboxDefaultUserHandleStruct()
		{
			UKuroStaticXSXLibrary.__GetXboxDefaultUserHandleStruct_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__GetXboxDefaultUserHandleStruct_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__GetXboxDefaultUserHandleStruct_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__GetXboxDefaultUserHandleStruct_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__GetXboxDefaultUserHandleStruct_NativeFunctionPtr, (void*)ptr, 0);
			return new FXboxUserHandleResult(&ptr->__Result, true, true);
		}

		// Token: 0x0601E042 RID: 122946 RVA: 0x002C8550 File Offset: 0x002C6750
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool GetXboxDefaultUserHandle(ref long OutUserHandle)
		{
			UKuroStaticXSXLibrary.__GetXboxDefaultUserHandle_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__GetXboxDefaultUserHandle_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__GetXboxDefaultUserHandle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__GetXboxDefaultUserHandle_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutUserHandle = OutUserHandle;
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__GetXboxDefaultUserHandle_NativeFunctionPtr, (void*)ptr, 0);
			OutUserHandle = ptr->OutUserHandle;
			return ptr->__Result;
		}

		// Token: 0x0601E043 RID: 122947 RVA: 0x002C85A8 File Offset: 0x002C67A8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool GetXboxClassicGamertag(long UserHandle, ref string OutGamertag)
		{
			UKuroStaticXSXLibrary.__GetXboxClassicGamertag_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__GetXboxClassicGamertag_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__GetXboxClassicGamertag_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__GetXboxClassicGamertag_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			FString.CopyFrom((void*)(&ptr->OutGamertag), OutGamertag);
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__GetXboxClassicGamertag_NativeFunctionPtr, (void*)ptr, 0);
			OutGamertag = FString.ToString((void*)(&ptr->OutGamertag));
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__GetXboxClassicGamertag_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601E044 RID: 122948 RVA: 0x002C8624 File Offset: 0x002C6824
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void GetXboxAvoidListAsync(long UserHandle, FOnXboxAvoidListResult Callback)
		{
			UKuroStaticXSXLibrary.__GetXboxAvoidListAsync_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__GetXboxAvoidListAsync_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__GetXboxAvoidListAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__GetXboxAvoidListAsync_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			FScriptDelegate.NativeCopy(&ptr->Callback, (Callback != null) ? Callback.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__GetXboxAvoidListAsync_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__GetXboxAvoidListAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601E045 RID: 122949 RVA: 0x002C8694 File Offset: 0x002C6894
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static FXboxAvoidListResult GetXboxAvoidList(long UserHandle)
		{
			UKuroStaticXSXLibrary.__GetXboxAvoidList_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__GetXboxAvoidList_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__GetXboxAvoidList_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__GetXboxAvoidList_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__GetXboxAvoidList_NativeFunctionPtr, (void*)ptr, 0);
			FXboxAvoidListResult result = new FXboxAvoidListResult(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__GetXboxAvoidList_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601E046 RID: 122950 RVA: 0x002C86FC File Offset: 0x002C68FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__GetXboxAchievementsAsync_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601E047 RID: 122951 RVA: 0x002C8770 File Offset: 0x002C6970
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static FXboxInviteInfo GetLastXboxInviteInfo()
		{
			UKuroStaticXSXLibrary.__GetLastXboxInviteInfo_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__GetLastXboxInviteInfo_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__GetLastXboxInviteInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__GetLastXboxInviteInfo_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__GetLastXboxInviteInfo_NativeFunctionPtr, (void*)ptr, 0);
			FXboxInviteInfo result = new FXboxInviteInfo(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__GetLastXboxInviteInfo_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601E048 RID: 122952 RVA: 0x002C87D0 File Offset: 0x002C69D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void FlushXboxMultiplayerActivityRecentPlayersAsync(long UserHandle)
		{
			UKuroStaticXSXLibrary.__FlushXboxMultiplayerActivityRecentPlayersAsync_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__FlushXboxMultiplayerActivityRecentPlayersAsync_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__FlushXboxMultiplayerActivityRecentPlayersAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__FlushXboxMultiplayerActivityRecentPlayersAsync_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__FlushXboxMultiplayerActivityRecentPlayersAsync_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601E049 RID: 122953 RVA: 0x002C8818 File Offset: 0x002C6A18
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void DeleteXboxMultiplayerActivityAsync(long UserHandle, FOnXboxCallResult Callback)
		{
			UKuroStaticXSXLibrary.__DeleteXboxMultiplayerActivityAsync_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__DeleteXboxMultiplayerActivityAsync_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__DeleteXboxMultiplayerActivityAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__DeleteXboxMultiplayerActivityAsync_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			FScriptDelegate.NativeCopy(&ptr->Callback, (Callback != null) ? Callback.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__DeleteXboxMultiplayerActivityAsync_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__DeleteXboxMultiplayerActivityAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601E04A RID: 122954 RVA: 0x002C8888 File Offset: 0x002C6A88
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static FXboxMultiplayerPrivilegeResult CheckXboxPrivilege(long UserHandle, EXboxUserPrivilege Privilege, EXboxUserPrivilegeOptions Options)
		{
			UKuroStaticXSXLibrary.__CheckXboxPrivilege_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__CheckXboxPrivilege_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__CheckXboxPrivilege_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__CheckXboxPrivilege_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			ptr->Privilege = Privilege;
			ptr->Options = Options;
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__CheckXboxPrivilege_NativeFunctionPtr, (void*)ptr, 0);
			return new FXboxMultiplayerPrivilegeResult(&ptr->__Result, true, true);
		}

		// Token: 0x0601E04B RID: 122955 RVA: 0x002C88EC File Offset: 0x002C6AEC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void CheckXboxPermissionAsync(long UserHandle, long TargetXuid, EXboxPermission Permission, FOnXboxPermissionCheckResult Callback)
		{
			UKuroStaticXSXLibrary.__CheckXboxPermissionAsync_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__CheckXboxPermissionAsync_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__CheckXboxPermissionAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__CheckXboxPermissionAsync_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			ptr->TargetXuid = TargetXuid;
			ptr->Permission = Permission;
			FScriptDelegate.NativeCopy(&ptr->Callback, (Callback != null) ? Callback.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__CheckXboxPermissionAsync_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticXSXLibrary.__CheckXboxPermissionAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601E04C RID: 122956 RVA: 0x002C896C File Offset: 0x002C6B6C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static FXboxMultiplayerPrivilegeResult CheckXboxMultiplayerPrivilege(long UserHandle)
		{
			UKuroStaticXSXLibrary.__CheckXboxMultiplayerPrivilege_FunctionParams* ptr = stackalloc UKuroStaticXSXLibrary.__CheckXboxMultiplayerPrivilege_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroStaticXSXLibrary.__CheckXboxMultiplayerPrivilege_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticXSXLibrary.__CheckXboxMultiplayerPrivilege_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UserHandle = UserHandle;
			UnrealReflectionUtils.CallUFunction(UKuroStaticXSXLibrary._ClassDefaultObjectPtr, UKuroStaticXSXLibrary.__CheckXboxMultiplayerPrivilege_NativeFunctionPtr, (void*)ptr, 0);
			return new FXboxMultiplayerPrivilegeResult(&ptr->__Result, true, true);
		}

		// Token: 0x0601E04D RID: 122957 RVA: 0x002C89C0 File Offset: 0x002C6BC0
		static UKuroStaticXSXLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroStaticXSXLibrary");
		}

		// Token: 0x0601E04E RID: 122958 RVA: 0x002C89CE File Offset: 0x002C6BCE
		protected UKuroStaticXSXLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010394 RID: 66452
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroStaticXSXLibrary";

		// Token: 0x04010395 RID: 66453
		private static IntPtr _ClassPtr;

		// Token: 0x04010396 RID: 66454
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010397 RID: 66455
		private static IntPtr __XboxMultiplayerManagerLobbyAddLocalUser_NativeFunctionPtr;

		// Token: 0x04010398 RID: 66456
		private static IntPtr __XboxMultiplayerManagerJoinLobby_NativeFunctionPtr;

		// Token: 0x04010399 RID: 66457
		private static IntPtr __XboxMultiplayerManagerJoinGameWithName_NativeFunctionPtr;

		// Token: 0x0401039A RID: 66458
		private static IntPtr __XboxMultiplayerManagerJoinGameFromLobby_NativeFunctionPtr;

		// Token: 0x0401039B RID: 66459
		private static IntPtr __XboxMultiplayerManagerDoWork_NativeFunctionPtr;

		// Token: 0x0401039C RID: 66460
		private static IntPtr __UpdateXboxMultiplayerActivityRecentPlayersAsync_NativeFunctionPtr;

		// Token: 0x0401039D RID: 66461
		private static IntPtr __UpdateXboxAchievementAsync_NativeFunctionPtr;

		// Token: 0x0401039E RID: 66462
		private static IntPtr __UnregisterXboxAchievementUpdatedCallback_NativeFunctionPtr;

		// Token: 0x0401039F RID: 66463
		private static IntPtr __UnregisterXboxAchievementsCallback_NativeFunctionPtr;

		// Token: 0x040103A0 RID: 66464
		private static IntPtr __UnregisterFromXboxGameInviteEvent_NativeFunctionPtr;

		// Token: 0x040103A1 RID: 66465
		private static IntPtr __ShowXboxPlayerProfileCard_NativeFunctionPtr;

		// Token: 0x040103A2 RID: 66466
		private static IntPtr __ShowXboxMultiplayerActivityGameInvite_NativeFunctionPtr;

		// Token: 0x040103A3 RID: 66467
		private static IntPtr __ShowKeyBoard_NativeFunctionPtr;

		// Token: 0x040103A4 RID: 66468
		private static IntPtr __SetXboxMultiplayerActivityAsync_NativeFunctionPtr;

		// Token: 0x040103A5 RID: 66469
		private static IntPtr __SendXboxMultiplayerActivityInvites_NativeFunctionPtr;

		// Token: 0x040103A6 RID: 66470
		private static IntPtr __ResolveXboxPrivilegeWithUi_NativeFunctionPtr;

		// Token: 0x040103A7 RID: 66471
		private static IntPtr __ResolveXboxMultiplayerPrivilegeWithUi_NativeFunctionPtr;

		// Token: 0x040103A8 RID: 66472
		private static IntPtr __RegisterXboxAchievementUpdatedCallback_NativeFunctionPtr;

		// Token: 0x040103A9 RID: 66473
		private static IntPtr __RegisterXboxAchievementsCallback_NativeFunctionPtr;

		// Token: 0x040103AA RID: 66474
		private static IntPtr __RegisterForXboxGameInviteEventWithCallback_NativeFunctionPtr;

		// Token: 0x040103AB RID: 66475
		private static IntPtr __RegisterForXboxGameInviteEvent_NativeFunctionPtr;

		// Token: 0x040103AC RID: 66476
		private static IntPtr __InitXboxMultiplayerManager_NativeFunctionPtr;

		// Token: 0x040103AD RID: 66477
		private static IntPtr __GetXboxUserPurchaseIdAsync_NativeFunctionPtr;

		// Token: 0x040103AE RID: 66478
		private static IntPtr __GetXboxUserId_NativeFunctionPtr;

		// Token: 0x040103AF RID: 66479
		private static IntPtr __GetXboxUserCollectionsIdAsync_NativeFunctionPtr;

		// Token: 0x040103B0 RID: 66480
		private static IntPtr __GetXboxUniqueModernGamertag_NativeFunctionPtr;

		// Token: 0x040103B1 RID: 66481
		private static IntPtr __GetXboxTokenAndSignatureAsync_NativeFunctionPtr;

		// Token: 0x040103B2 RID: 66482
		private static IntPtr __GetXboxMultiplayerActivity_NativeFunctionPtr;

		// Token: 0x040103B3 RID: 66483
		private static IntPtr __GetXboxModernGamertagSuffix_NativeFunctionPtr;

		// Token: 0x040103B4 RID: 66484
		private static IntPtr __GetXboxModernGamertag_NativeFunctionPtr;

		// Token: 0x040103B5 RID: 66485
		private static IntPtr __GetXboxGamertagForDisplay_NativeFunctionPtr;

		// Token: 0x040103B6 RID: 66486
		private static IntPtr __GetXboxGamertagByType_NativeFunctionPtr;

		// Token: 0x040103B7 RID: 66487
		private static IntPtr __GetXboxGamertagAllComponents_NativeFunctionPtr;

		// Token: 0x040103B8 RID: 66488
		private static IntPtr __GetXboxDefaultUserHandleStruct_NativeFunctionPtr;

		// Token: 0x040103B9 RID: 66489
		private static IntPtr __GetXboxDefaultUserHandle_NativeFunctionPtr;

		// Token: 0x040103BA RID: 66490
		private static IntPtr __GetXboxClassicGamertag_NativeFunctionPtr;

		// Token: 0x040103BB RID: 66491
		private static IntPtr __GetXboxAvoidListAsync_NativeFunctionPtr;

		// Token: 0x040103BC RID: 66492
		private static IntPtr __GetXboxAvoidList_NativeFunctionPtr;

		// Token: 0x040103BD RID: 66493
		private static IntPtr __GetXboxAchievementsAsync_NativeFunctionPtr;

		// Token: 0x040103BE RID: 66494
		private static IntPtr __GetLastXboxInviteInfo_NativeFunctionPtr;

		// Token: 0x040103BF RID: 66495
		private static IntPtr __FlushXboxMultiplayerActivityRecentPlayersAsync_NativeFunctionPtr;

		// Token: 0x040103C0 RID: 66496
		private static IntPtr __DeleteXboxMultiplayerActivityAsync_NativeFunctionPtr;

		// Token: 0x040103C1 RID: 66497
		private static IntPtr __CheckXboxPrivilege_NativeFunctionPtr;

		// Token: 0x040103C2 RID: 66498
		private static IntPtr __CheckXboxPermissionAsync_NativeFunctionPtr;

		// Token: 0x040103C3 RID: 66499
		private static IntPtr __CheckXboxMultiplayerPrivilege_NativeFunctionPtr;

		// Token: 0x0200336C RID: 13164
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __XboxMultiplayerManagerLobbyAddLocalUser_FunctionParams
		{
			// Token: 0x040172C0 RID: 94912
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x040172C1 RID: 94913
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x0200336D RID: 13165
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __XboxMultiplayerManagerJoinLobby_FunctionParams
		{
			// Token: 0x040172C2 RID: 94914
			[FieldOffset(0)]
			public FString InviteHandleId;

			// Token: 0x040172C3 RID: 94915
			[FieldOffset(16)]
			public long UserHandle;

			// Token: 0x040172C4 RID: 94916
			[FieldOffset(24)]
			public bool __Result;
		}

		// Token: 0x0200336E RID: 13166
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __XboxMultiplayerManagerJoinGameWithName_FunctionParams
		{
			// Token: 0x040172C5 RID: 94917
			[FieldOffset(0)]
			public FString SessionName;

			// Token: 0x040172C6 RID: 94918
			[FieldOffset(16)]
			public FString SessionTemplateName;

			// Token: 0x040172C7 RID: 94919
			[FieldOffset(32)]
			public byte Xuids;

			// Token: 0x040172C8 RID: 94920
			[FieldOffset(48)]
			public bool __Result;
		}

		// Token: 0x0200336F RID: 13167
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __XboxMultiplayerManagerJoinGameFromLobby_FunctionParams
		{
			// Token: 0x040172C9 RID: 94921
			[FieldOffset(0)]
			public FString SessionTemplateName;

			// Token: 0x040172CA RID: 94922
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02003370 RID: 13168
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __XboxMultiplayerManagerDoWork_FunctionParams
		{
			// Token: 0x040172CB RID: 94923
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003371 RID: 13169
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __UpdateXboxMultiplayerActivityRecentPlayersAsync_FunctionParams
		{
			// Token: 0x040172CC RID: 94924
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x040172CD RID: 94925
			[FieldOffset(8)]
			public byte Updates;

			// Token: 0x040172CE RID: 94926
			[FieldOffset(24)]
			public byte Callback;
		}

		// Token: 0x02003372 RID: 13170
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __UpdateXboxAchievementAsync_FunctionParams
		{
			// Token: 0x040172CF RID: 94927
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x040172D0 RID: 94928
			[FieldOffset(8)]
			public long Xuid;

			// Token: 0x040172D1 RID: 94929
			[FieldOffset(16)]
			public FString AchievementId;

			// Token: 0x040172D2 RID: 94930
			[FieldOffset(32)]
			public int PercentComplete;
		}

		// Token: 0x02003373 RID: 13171
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __ShowXboxPlayerProfileCard_FunctionParams
		{
			// Token: 0x040172D3 RID: 94931
			[FieldOffset(0)]
			public long LocalUserHandle;

			// Token: 0x040172D4 RID: 94932
			[FieldOffset(8)]
			public long TargetXuid;

			// Token: 0x040172D5 RID: 94933
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02003374 RID: 13172
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ShowXboxMultiplayerActivityGameInvite_FunctionParams
		{
			// Token: 0x040172D6 RID: 94934
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x040172D7 RID: 94935
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x02003375 RID: 13173
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __ShowKeyBoard_FunctionParams
		{
			// Token: 0x040172D8 RID: 94936
			[FieldOffset(0)]
			public bool State;

			// Token: 0x040172D9 RID: 94937
			[FieldOffset(1)]
			public bool __Result;
		}

		// Token: 0x02003376 RID: 13174
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 104)]
		protected ref struct __SetXboxMultiplayerActivityAsync_FunctionParams
		{
			// Token: 0x040172DA RID: 94938
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x040172DB RID: 94939
			[FieldOffset(8)]
			public long xuid;

			// Token: 0x040172DC RID: 94940
			[FieldOffset(16)]
			public FString ConnectionString;

			// Token: 0x040172DD RID: 94941
			[FieldOffset(32)]
			public int MaxPlayers;

			// Token: 0x040172DE RID: 94942
			[FieldOffset(36)]
			public int CurrentPlayers;

			// Token: 0x040172DF RID: 94943
			[FieldOffset(40)]
			public FString GroupId;

			// Token: 0x040172E0 RID: 94944
			[FieldOffset(56)]
			public EXboxMultiplayerActivityJoinRestriction JoinRestriction;

			// Token: 0x040172E1 RID: 94945
			[FieldOffset(57)]
			public bool bAllowCrossPlatformJoin;

			// Token: 0x040172E2 RID: 94946
			[FieldOffset(64)]
			public byte Callback;
		}

		// Token: 0x02003377 RID: 13175
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __SendXboxMultiplayerActivityInvites_FunctionParams
		{
			// Token: 0x040172E3 RID: 94947
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x040172E4 RID: 94948
			[FieldOffset(8)]
			public byte TargetXuids;

			// Token: 0x040172E5 RID: 94949
			[FieldOffset(24)]
			public bool bCrossNetwork;

			// Token: 0x040172E6 RID: 94950
			[FieldOffset(32)]
			public FString ConnectionString;

			// Token: 0x040172E7 RID: 94951
			[FieldOffset(48)]
			public bool __Result;
		}

		// Token: 0x02003378 RID: 13176
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ResolveXboxPrivilegeWithUi_FunctionParams
		{
			// Token: 0x040172E8 RID: 94952
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x040172E9 RID: 94953
			[FieldOffset(8)]
			public EXboxUserPrivilege Privilege;

			// Token: 0x040172EA RID: 94954
			[FieldOffset(9)]
			public EXboxUserPrivilegeOptions Options;

			// Token: 0x040172EB RID: 94955
			[FieldOffset(10)]
			public bool __Result;
		}

		// Token: 0x02003379 RID: 13177
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ResolveXboxMultiplayerPrivilegeWithUi_FunctionParams
		{
			// Token: 0x040172EC RID: 94956
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x040172ED RID: 94957
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x0200337A RID: 13178
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __RegisterXboxAchievementUpdatedCallback_FunctionParams
		{
			// Token: 0x040172EE RID: 94958
			[FieldOffset(0)]
			public byte Callback;
		}

		// Token: 0x0200337B RID: 13179
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __RegisterXboxAchievementsCallback_FunctionParams
		{
			// Token: 0x040172EF RID: 94959
			[FieldOffset(0)]
			public byte Callback;
		}

		// Token: 0x0200337C RID: 13180
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __RegisterForXboxGameInviteEventWithCallback_FunctionParams
		{
			// Token: 0x040172F0 RID: 94960
			[FieldOffset(0)]
			public byte Callback;

			// Token: 0x040172F1 RID: 94961
			[FieldOffset(40)]
			public bool __Result;
		}

		// Token: 0x0200337D RID: 13181
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __RegisterForXboxGameInviteEvent_FunctionParams
		{
			// Token: 0x040172F2 RID: 94962
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200337E RID: 13182
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __InitXboxMultiplayerManager_FunctionParams
		{
			// Token: 0x040172F3 RID: 94963
			[FieldOffset(0)]
			public FString LobbySessionTemplateName;

			// Token: 0x040172F4 RID: 94964
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x0200337F RID: 13183
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetXboxUserPurchaseIdAsync_FunctionParams
		{
			// Token: 0x040172F5 RID: 94965
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x040172F6 RID: 94966
			[FieldOffset(8)]
			public FString ServiceTicket;

			// Token: 0x040172F7 RID: 94967
			[FieldOffset(24)]
			public FString PublisherUserId;

			// Token: 0x040172F8 RID: 94968
			[FieldOffset(40)]
			public byte Callback;
		}

		// Token: 0x02003380 RID: 13184
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetXboxUserId_FunctionParams
		{
			// Token: 0x040172F9 RID: 94969
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x040172FA RID: 94970
			[FieldOffset(8)]
			public byte __Result;
		}

		// Token: 0x02003381 RID: 13185
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetXboxUserCollectionsIdAsync_FunctionParams
		{
			// Token: 0x040172FB RID: 94971
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x040172FC RID: 94972
			[FieldOffset(8)]
			public FString ServiceTicket;

			// Token: 0x040172FD RID: 94973
			[FieldOffset(24)]
			public FString PublisherUserId;

			// Token: 0x040172FE RID: 94974
			[FieldOffset(40)]
			public byte Callback;
		}

		// Token: 0x02003382 RID: 13186
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetXboxUniqueModernGamertag_FunctionParams
		{
			// Token: 0x040172FF RID: 94975
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x04017300 RID: 94976
			[FieldOffset(8)]
			public FString OutUniqueModernGamertag;

			// Token: 0x04017301 RID: 94977
			[FieldOffset(24)]
			public bool __Result;
		}

		// Token: 0x02003383 RID: 13187
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __GetXboxTokenAndSignatureAsync_FunctionParams
		{
			// Token: 0x04017302 RID: 94978
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x04017303 RID: 94979
			[FieldOffset(8)]
			public FString Url;

			// Token: 0x04017304 RID: 94980
			[FieldOffset(24)]
			public byte Callback;
		}

		// Token: 0x02003384 RID: 13188
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __GetXboxMultiplayerActivity_FunctionParams
		{
			// Token: 0x04017305 RID: 94981
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x04017306 RID: 94982
			[FieldOffset(8)]
			public long TargetXuid;

			// Token: 0x04017307 RID: 94983
			[FieldOffset(16)]
			public FString OutConnectionString;

			// Token: 0x04017308 RID: 94984
			[FieldOffset(32)]
			public int OutMaxPlayers;

			// Token: 0x04017309 RID: 94985
			[FieldOffset(36)]
			public int OutCurrentPlayers;

			// Token: 0x0401730A RID: 94986
			[FieldOffset(40)]
			public FString OutGroupId;

			// Token: 0x0401730B RID: 94987
			[FieldOffset(56)]
			public bool __Result;
		}

		// Token: 0x02003385 RID: 13189
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetXboxModernGamertagSuffix_FunctionParams
		{
			// Token: 0x0401730C RID: 94988
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x0401730D RID: 94989
			[FieldOffset(8)]
			public FString OutSuffix;

			// Token: 0x0401730E RID: 94990
			[FieldOffset(24)]
			public bool __Result;
		}

		// Token: 0x02003386 RID: 13190
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetXboxModernGamertag_FunctionParams
		{
			// Token: 0x0401730F RID: 94991
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x04017310 RID: 94992
			[FieldOffset(8)]
			public FString OutGamertag;

			// Token: 0x04017311 RID: 94993
			[FieldOffset(24)]
			public bool __Result;
		}

		// Token: 0x02003387 RID: 13191
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __GetXboxGamertagForDisplay_FunctionParams
		{
			// Token: 0x04017312 RID: 94994
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x04017313 RID: 94995
			[FieldOffset(8)]
			public EXboxGamertagComponent Component;

			// Token: 0x04017314 RID: 94996
			[FieldOffset(16)]
			public byte __Result;
		}

		// Token: 0x02003388 RID: 13192
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __GetXboxGamertagByType_FunctionParams
		{
			// Token: 0x04017315 RID: 94997
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x04017316 RID: 94998
			[FieldOffset(8)]
			public EXboxGamertagComponent Component;

			// Token: 0x04017317 RID: 94999
			[FieldOffset(16)]
			public FString OutGamertag;

			// Token: 0x04017318 RID: 95000
			[FieldOffset(32)]
			public bool __Result;
		}

		// Token: 0x02003389 RID: 13193
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetXboxGamertagAllComponents_FunctionParams
		{
			// Token: 0x04017319 RID: 95001
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x0401731A RID: 95002
			[FieldOffset(8)]
			public FString OutModernGamertag;

			// Token: 0x0401731B RID: 95003
			[FieldOffset(24)]
			public FString OutSuffix;

			// Token: 0x0401731C RID: 95004
			[FieldOffset(40)]
			public FString OutUniqueModernGamertag;

			// Token: 0x0401731D RID: 95005
			[FieldOffset(56)]
			public FString OutClassicGamertag;

			// Token: 0x0401731E RID: 95006
			[FieldOffset(72)]
			public bool __Result;
		}

		// Token: 0x0200338A RID: 13194
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetXboxDefaultUserHandleStruct_FunctionParams
		{
			// Token: 0x0401731F RID: 95007
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200338B RID: 13195
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetXboxDefaultUserHandle_FunctionParams
		{
			// Token: 0x04017320 RID: 95008
			[FieldOffset(0)]
			public long OutUserHandle;

			// Token: 0x04017321 RID: 95009
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x0200338C RID: 13196
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetXboxClassicGamertag_FunctionParams
		{
			// Token: 0x04017322 RID: 95010
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x04017323 RID: 95011
			[FieldOffset(8)]
			public FString OutGamertag;

			// Token: 0x04017324 RID: 95012
			[FieldOffset(24)]
			public bool __Result;
		}

		// Token: 0x0200338D RID: 13197
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __GetXboxAvoidListAsync_FunctionParams
		{
			// Token: 0x04017325 RID: 95013
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x04017326 RID: 95014
			[FieldOffset(8)]
			public byte Callback;
		}

		// Token: 0x0200338E RID: 13198
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetXboxAvoidList_FunctionParams
		{
			// Token: 0x04017327 RID: 95015
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x04017328 RID: 95016
			[FieldOffset(8)]
			public byte __Result;
		}

		// Token: 0x0200338F RID: 13199
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetXboxAchievementsAsync_FunctionParams
		{
			// Token: 0x04017329 RID: 95017
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x0401732A RID: 95018
			[FieldOffset(8)]
			public long Xuid;

			// Token: 0x0401732B RID: 95019
			[FieldOffset(16)]
			public EXboxAchievementType AchievementType;

			// Token: 0x0401732C RID: 95020
			[FieldOffset(17)]
			public bool bUnlockedOnly;

			// Token: 0x0401732D RID: 95021
			[FieldOffset(18)]
			public EXboxAchievementOrderBy OrderBy;

			// Token: 0x0401732E RID: 95022
			[FieldOffset(20)]
			public int SkipItems;

			// Token: 0x0401732F RID: 95023
			[FieldOffset(24)]
			public int MaxItems;
		}

		// Token: 0x02003390 RID: 13200
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __GetLastXboxInviteInfo_FunctionParams
		{
			// Token: 0x04017330 RID: 95024
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003391 RID: 13201
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FlushXboxMultiplayerActivityRecentPlayersAsync_FunctionParams
		{
			// Token: 0x04017331 RID: 95025
			[FieldOffset(0)]
			public long UserHandle;
		}

		// Token: 0x02003392 RID: 13202
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __DeleteXboxMultiplayerActivityAsync_FunctionParams
		{
			// Token: 0x04017332 RID: 95026
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x04017333 RID: 95027
			[FieldOffset(8)]
			public byte Callback;
		}

		// Token: 0x02003393 RID: 13203
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __CheckXboxPrivilege_FunctionParams
		{
			// Token: 0x04017334 RID: 95028
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x04017335 RID: 95029
			[FieldOffset(8)]
			public EXboxUserPrivilege Privilege;

			// Token: 0x04017336 RID: 95030
			[FieldOffset(9)]
			public EXboxUserPrivilegeOptions Options;

			// Token: 0x04017337 RID: 95031
			[FieldOffset(12)]
			public byte __Result;
		}

		// Token: 0x02003394 RID: 13204
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __CheckXboxPermissionAsync_FunctionParams
		{
			// Token: 0x04017338 RID: 95032
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x04017339 RID: 95033
			[FieldOffset(8)]
			public long TargetXuid;

			// Token: 0x0401733A RID: 95034
			[FieldOffset(16)]
			public EXboxPermission Permission;

			// Token: 0x0401733B RID: 95035
			[FieldOffset(24)]
			public byte Callback;
		}

		// Token: 0x02003395 RID: 13205
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __CheckXboxMultiplayerPrivilege_FunctionParams
		{
			// Token: 0x0401733C RID: 95036
			[FieldOffset(0)]
			public long UserHandle;

			// Token: 0x0401733D RID: 95037
			[FieldOffset(8)]
			public byte __Result;
		}
	}
}
