using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001A4 RID: 420
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CheatManager")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UCheatManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001EF3 RID: 7923 RVA: 0x0002D2E6 File Offset: 0x0002B4E6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCheatManager._ClassPtr;
		}

		// Token: 0x06001EF4 RID: 7924 RVA: 0x0002D2F4 File Offset: 0x0002B4F4
		public UCheatManager() : this(BuiltinUtils.AllocNativeUObject(UCheatManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001EF5 RID: 7925 RVA: 0x0002D31C File Offset: 0x0002B51C
		public UCheatManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCheatManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001EF6 RID: 7926 RVA: 0x0002D34F File Offset: 0x0002B54F
		public void Walk()
		{
			UCheatManager.__Walk_Internal(base.NativePtr);
		}

		// Token: 0x06001EF7 RID: 7927 RVA: 0x0002D35C File Offset: 0x0002B55C
		public void ViewSelf()
		{
			UCheatManager.__ViewSelf_Internal(base.NativePtr);
		}

		// Token: 0x06001EF8 RID: 7928 RVA: 0x0002D36C File Offset: 0x0002B56C
		public unsafe void ViewPlayer(string S)
		{
			FString fstring = FString.AllocTemp(S);
			UCheatManager.__ViewPlayer_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x0002D396 File Offset: 0x0002B596
		public void ViewClass([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> DesiredClass)
		{
			UCheatManager.__ViewClass_Internal(base.NativePtr, DesiredClass._NativePtr);
		}

		// Token: 0x06001EFA RID: 7930 RVA: 0x0002D3A9 File Offset: 0x0002B5A9
		public void ViewActor(FName ActorName)
		{
			UCheatManager.__ViewActor_Internal(base.NativePtr, ActorName);
		}

		// Token: 0x06001EFB RID: 7931 RVA: 0x0002D3B7 File Offset: 0x0002B5B7
		public void UpdateSafeArea()
		{
			UCheatManager.__UpdateSafeArea_Internal(base.NativePtr);
		}

		// Token: 0x06001EFC RID: 7932 RVA: 0x0002D3C4 File Offset: 0x0002B5C4
		public void ToggleServerStatReplicatorUpdateStatNet()
		{
			UCheatManager.__ToggleServerStatReplicatorUpdateStatNet_Internal(base.NativePtr);
		}

		// Token: 0x06001EFD RID: 7933 RVA: 0x0002D3D1 File Offset: 0x0002B5D1
		public void ToggleServerStatReplicatorClientOverwrite()
		{
			UCheatManager.__ToggleServerStatReplicatorClientOverwrite_Internal(base.NativePtr);
		}

		// Token: 0x06001EFE RID: 7934 RVA: 0x0002D3DE File Offset: 0x0002B5DE
		public void ToggleDebugCamera()
		{
			UCheatManager.__ToggleDebugCamera_Internal(base.NativePtr);
		}

		// Token: 0x06001EFF RID: 7935 RVA: 0x0002D3EB File Offset: 0x0002B5EB
		public void ToggleAILogging()
		{
			UCheatManager.__ToggleAILogging_Internal(base.NativePtr);
		}

		// Token: 0x06001F00 RID: 7936 RVA: 0x0002D3F8 File Offset: 0x0002B5F8
		public void TestCollisionDistance()
		{
			UCheatManager.__TestCollisionDistance_Internal(base.NativePtr);
		}

		// Token: 0x06001F01 RID: 7937 RVA: 0x0002D405 File Offset: 0x0002B605
		public void Teleport()
		{
			UCheatManager.__Teleport_Internal(base.NativePtr);
		}

		// Token: 0x06001F02 RID: 7938 RVA: 0x0002D414 File Offset: 0x0002B614
		public unsafe void Summon(string ClassName)
		{
			FString fstring = FString.AllocTemp(ClassName);
			UCheatManager.__Summon_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06001F03 RID: 7939 RVA: 0x0002D43E File Offset: 0x0002B63E
		public void StreamLevelOut(FName PackageName)
		{
			UCheatManager.__StreamLevelOut_Internal(base.NativePtr, PackageName);
		}

		// Token: 0x06001F04 RID: 7940 RVA: 0x0002D44C File Offset: 0x0002B64C
		public void StreamLevelIn(FName PackageName)
		{
			UCheatManager.__StreamLevelIn_Internal(base.NativePtr, PackageName);
		}

		// Token: 0x06001F05 RID: 7941 RVA: 0x0002D45A File Offset: 0x0002B65A
		public void SpawnServerStatReplicator()
		{
			UCheatManager.__SpawnServerStatReplicator_Internal(base.NativePtr);
		}

		// Token: 0x06001F06 RID: 7942 RVA: 0x0002D467 File Offset: 0x0002B667
		public void Slomo(float NewTimeDilation)
		{
			UCheatManager.__Slomo_Internal(base.NativePtr, NewTimeDilation);
		}

		// Token: 0x06001F07 RID: 7943 RVA: 0x0002D475 File Offset: 0x0002B675
		public void SetWorldOrigin()
		{
			UCheatManager.__SetWorldOrigin_Internal(base.NativePtr);
		}

		// Token: 0x06001F08 RID: 7944 RVA: 0x0002D482 File Offset: 0x0002B682
		public void SetMouseSensitivityToDefault()
		{
			UCheatManager.__SetMouseSensitivityToDefault_Internal(base.NativePtr);
		}

		// Token: 0x06001F09 RID: 7945 RVA: 0x0002D48F File Offset: 0x0002B68F
		public void ServerToggleAILogging()
		{
			UCheatManager.__ServerToggleAILogging_Internal(base.NativePtr);
		}

		// Token: 0x06001F0A RID: 7946 RVA: 0x0002D49C File Offset: 0x0002B69C
		public void ReSetWorldOrigin()
		{
			UCheatManager.__ReSetWorldOrigin_Internal(base.NativePtr);
		}

		// Token: 0x06001F0B RID: 7947 RVA: 0x0002D4A9 File Offset: 0x0002B6A9
		public virtual void ReceiveInitCheatManager()
		{
			UCheatManager.__ReceiveInitCheatManager_Internal(base.NativePtr);
		}

		// Token: 0x06001F0C RID: 7948 RVA: 0x0002D4B6 File Offset: 0x0002B6B6
		public virtual void ReceiveEndPlay()
		{
			UCheatManager.__ReceiveEndPlay_Internal(base.NativePtr);
		}

		// Token: 0x06001F0D RID: 7949 RVA: 0x0002D4C3 File Offset: 0x0002B6C3
		public void PlayersOnly()
		{
			UCheatManager.__PlayersOnly_Internal(base.NativePtr);
		}

		// Token: 0x06001F0E RID: 7950 RVA: 0x0002D4D0 File Offset: 0x0002B6D0
		public void OnlyLoadLevel(FName PackageName)
		{
			UCheatManager.__OnlyLoadLevel_Internal(base.NativePtr, PackageName);
		}

		// Token: 0x06001F0F RID: 7951 RVA: 0x0002D4DE File Offset: 0x0002B6DE
		public void LogLoc()
		{
			UCheatManager.__LogLoc_Internal(base.NativePtr);
		}

		// Token: 0x06001F10 RID: 7952 RVA: 0x0002D4EB File Offset: 0x0002B6EB
		public void InvertMouse()
		{
			UCheatManager.__InvertMouse_Internal(base.NativePtr);
		}

		// Token: 0x06001F11 RID: 7953 RVA: 0x0002D4F8 File Offset: 0x0002B6F8
		public void God()
		{
			UCheatManager.__God_Internal(base.NativePtr);
		}

		// Token: 0x06001F12 RID: 7954 RVA: 0x0002D505 File Offset: 0x0002B705
		public void Ghost()
		{
			UCheatManager.__Ghost_Internal(base.NativePtr);
		}

		// Token: 0x06001F13 RID: 7955 RVA: 0x0002D512 File Offset: 0x0002B712
		public void FreezeFrame(float Delay)
		{
			UCheatManager.__FreezeFrame_Internal(base.NativePtr, Delay);
		}

		// Token: 0x06001F14 RID: 7956 RVA: 0x0002D520 File Offset: 0x0002B720
		public void Fly()
		{
			UCheatManager.__Fly_Internal(base.NativePtr);
		}

		// Token: 0x06001F15 RID: 7957 RVA: 0x0002D52D File Offset: 0x0002B72D
		public void FlushLog()
		{
			UCheatManager.__FlushLog_Internal(base.NativePtr);
		}

		// Token: 0x06001F16 RID: 7958 RVA: 0x0002D53A File Offset: 0x0002B73A
		public void EnableDebugCamera()
		{
			UCheatManager.__EnableDebugCamera_Internal(base.NativePtr);
		}

		// Token: 0x06001F17 RID: 7959 RVA: 0x0002D547 File Offset: 0x0002B747
		public void DumpVoiceMutingState()
		{
			UCheatManager.__DumpVoiceMutingState_Internal(base.NativePtr);
		}

		// Token: 0x06001F18 RID: 7960 RVA: 0x0002D554 File Offset: 0x0002B754
		public void DumpPartyState()
		{
			UCheatManager.__DumpPartyState_Internal(base.NativePtr);
		}

		// Token: 0x06001F19 RID: 7961 RVA: 0x0002D561 File Offset: 0x0002B761
		public void DumpOnlineSessionState()
		{
			UCheatManager.__DumpOnlineSessionState_Internal(base.NativePtr);
		}

		// Token: 0x06001F1A RID: 7962 RVA: 0x0002D56E File Offset: 0x0002B76E
		public void DumpChatState()
		{
			UCheatManager.__DumpChatState_Internal(base.NativePtr);
		}

		// Token: 0x06001F1B RID: 7963 RVA: 0x0002D57B File Offset: 0x0002B77B
		public void DoPatchTest()
		{
			UCheatManager.__DoPatchTest_Internal(base.NativePtr);
		}

		// Token: 0x06001F1C RID: 7964 RVA: 0x0002D588 File Offset: 0x0002B788
		public void DisableDebugCamera()
		{
			UCheatManager.__DisableDebugCamera_Internal(base.NativePtr);
		}

		// Token: 0x06001F1D RID: 7965 RVA: 0x0002D595 File Offset: 0x0002B795
		public void DestroyTarget()
		{
			UCheatManager.__DestroyTarget_Internal(base.NativePtr);
		}

		// Token: 0x06001F1E RID: 7966 RVA: 0x0002D5A2 File Offset: 0x0002B7A2
		public void DestroyServerStatReplicator()
		{
			UCheatManager.__DestroyServerStatReplicator_Internal(base.NativePtr);
		}

		// Token: 0x06001F1F RID: 7967 RVA: 0x0002D5AF File Offset: 0x0002B7AF
		public void DestroyPawns([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<APawn> aClass)
		{
			UCheatManager.__DestroyPawns_Internal(base.NativePtr, aClass._NativePtr);
		}

		// Token: 0x06001F20 RID: 7968 RVA: 0x0002D5C2 File Offset: 0x0002B7C2
		public void DestroyAllPawnsExceptTarget()
		{
			UCheatManager.__DestroyAllPawnsExceptTarget_Internal(base.NativePtr);
		}

		// Token: 0x06001F21 RID: 7969 RVA: 0x0002D5CF File Offset: 0x0002B7CF
		public void DestroyAll([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> aClass)
		{
			UCheatManager.__DestroyAll_Internal(base.NativePtr, aClass._NativePtr);
		}

		// Token: 0x06001F22 RID: 7970 RVA: 0x0002D5E2 File Offset: 0x0002B7E2
		public void DebugCapsuleSweepSize(float HalfHeight, float Radius)
		{
			UCheatManager.__DebugCapsuleSweepSize_Internal(base.NativePtr, HalfHeight, Radius);
		}

		// Token: 0x06001F23 RID: 7971 RVA: 0x0002D5F1 File Offset: 0x0002B7F1
		public void DebugCapsuleSweepPawn()
		{
			UCheatManager.__DebugCapsuleSweepPawn_Internal(base.NativePtr);
		}

		// Token: 0x06001F24 RID: 7972 RVA: 0x0002D5FE File Offset: 0x0002B7FE
		public void DebugCapsuleSweepComplex(bool bTraceComplex)
		{
			UCheatManager.__DebugCapsuleSweepComplex_Internal(base.NativePtr, bTraceComplex);
		}

		// Token: 0x06001F25 RID: 7973 RVA: 0x0002D60C File Offset: 0x0002B80C
		public void DebugCapsuleSweepClear()
		{
			UCheatManager.__DebugCapsuleSweepClear_Internal(base.NativePtr);
		}

		// Token: 0x06001F26 RID: 7974 RVA: 0x0002D619 File Offset: 0x0002B819
		public void DebugCapsuleSweepChannel(ECollisionChannel Channel)
		{
			UCheatManager.__DebugCapsuleSweepChannel_Internal(base.NativePtr, Channel);
		}

		// Token: 0x06001F27 RID: 7975 RVA: 0x0002D62C File Offset: 0x0002B82C
		public void DebugCapsuleSweepCapture()
		{
			UCheatManager.__DebugCapsuleSweepCapture_Internal(base.NativePtr);
		}

		// Token: 0x06001F28 RID: 7976 RVA: 0x0002D639 File Offset: 0x0002B839
		public void DebugCapsuleSweep()
		{
			UCheatManager.__DebugCapsuleSweep_Internal(base.NativePtr);
		}

		// Token: 0x06001F29 RID: 7977 RVA: 0x0002D646 File Offset: 0x0002B846
		public void DamageTarget(float DamageAmount)
		{
			UCheatManager.__DamageTarget_Internal(base.NativePtr, DamageAmount);
		}

		// Token: 0x06001F2A RID: 7978 RVA: 0x0002D654 File Offset: 0x0002B854
		public unsafe void CheatScript(string ScriptName)
		{
			FString fstring = FString.AllocTemp(ScriptName);
			UCheatManager.__CheatScript_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06001F2B RID: 7979 RVA: 0x0002D67E File Offset: 0x0002B87E
		public void ChangeSize(float F)
		{
			UCheatManager.__ChangeSize_Internal(base.NativePtr, F);
		}

		// Token: 0x06001F2C RID: 7980 RVA: 0x0002D68C File Offset: 0x0002B88C
		public unsafe void BugItStringCreator(FVector ViewLocation, FRotator ViewRotation, ref string GoString, ref string LocString)
		{
			FString fstring = FString.AllocTemp(GoString);
			FString fstring2 = FString.AllocTemp(LocString);
			UCheatManager.__BugItStringCreator_Internal(base.NativePtr, ViewLocation, ViewRotation, ref fstring, ref fstring2);
			GoString = FString.ToString(fstring);
			FString.NativeDestruct(&fstring, 1);
			LocString = FString.ToString(fstring2);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06001F2D RID: 7981 RVA: 0x0002D6E0 File Offset: 0x0002B8E0
		public void BugItGo(float X, float Y, float Z, float Pitch, float Yaw, float Roll)
		{
			UCheatManager.__BugItGo_Internal(base.NativePtr, X, Y, Z, Pitch, Yaw, Roll);
		}

		// Token: 0x06001F2E RID: 7982 RVA: 0x0002D6F8 File Offset: 0x0002B8F8
		public unsafe void BugIt(string ScreenShotDescription = "")
		{
			FString fstring = FString.AllocTemp(ScreenShotDescription);
			UCheatManager.__BugIt_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06001F2F RID: 7983
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Walk_Internal(IntPtr @this);

		// Token: 0x06001F30 RID: 7984
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ViewSelf_Internal(IntPtr @this);

		// Token: 0x06001F31 RID: 7985
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ViewPlayer_Internal(IntPtr @this, in FString S);

		// Token: 0x06001F32 RID: 7986
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ViewClass_Internal(IntPtr @this, IntPtr DesiredClass);

		// Token: 0x06001F33 RID: 7987
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ViewActor_Internal(IntPtr @this, FName ActorName);

		// Token: 0x06001F34 RID: 7988
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateSafeArea_Internal(IntPtr @this);

		// Token: 0x06001F35 RID: 7989
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ToggleServerStatReplicatorUpdateStatNet_Internal(IntPtr @this);

		// Token: 0x06001F36 RID: 7990
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ToggleServerStatReplicatorClientOverwrite_Internal(IntPtr @this);

		// Token: 0x06001F37 RID: 7991
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ToggleDebugCamera_Internal(IntPtr @this);

		// Token: 0x06001F38 RID: 7992
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ToggleAILogging_Internal(IntPtr @this);

		// Token: 0x06001F39 RID: 7993
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TestCollisionDistance_Internal(IntPtr @this);

		// Token: 0x06001F3A RID: 7994
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Teleport_Internal(IntPtr @this);

		// Token: 0x06001F3B RID: 7995
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Summon_Internal(IntPtr @this, in FString ClassName);

		// Token: 0x06001F3C RID: 7996
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StreamLevelOut_Internal(IntPtr @this, FName PackageName);

		// Token: 0x06001F3D RID: 7997
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StreamLevelIn_Internal(IntPtr @this, FName PackageName);

		// Token: 0x06001F3E RID: 7998
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SpawnServerStatReplicator_Internal(IntPtr @this);

		// Token: 0x06001F3F RID: 7999
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Slomo_Internal(IntPtr @this, float NewTimeDilation);

		// Token: 0x06001F40 RID: 8000
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWorldOrigin_Internal(IntPtr @this);

		// Token: 0x06001F41 RID: 8001
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMouseSensitivityToDefault_Internal(IntPtr @this);

		// Token: 0x06001F42 RID: 8002
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerToggleAILogging_Internal(IntPtr @this);

		// Token: 0x06001F43 RID: 8003
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReSetWorldOrigin_Internal(IntPtr @this);

		// Token: 0x06001F44 RID: 8004
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveInitCheatManager_Internal(IntPtr @this);

		// Token: 0x06001F45 RID: 8005
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveEndPlay_Internal(IntPtr @this);

		// Token: 0x06001F46 RID: 8006
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayersOnly_Internal(IntPtr @this);

		// Token: 0x06001F47 RID: 8007
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnlyLoadLevel_Internal(IntPtr @this, FName PackageName);

		// Token: 0x06001F48 RID: 8008
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LogLoc_Internal(IntPtr @this);

		// Token: 0x06001F49 RID: 8009
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InvertMouse_Internal(IntPtr @this);

		// Token: 0x06001F4A RID: 8010
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __God_Internal(IntPtr @this);

		// Token: 0x06001F4B RID: 8011
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Ghost_Internal(IntPtr @this);

		// Token: 0x06001F4C RID: 8012
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FreezeFrame_Internal(IntPtr @this, float Delay);

		// Token: 0x06001F4D RID: 8013
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Fly_Internal(IntPtr @this);

		// Token: 0x06001F4E RID: 8014
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FlushLog_Internal(IntPtr @this);

		// Token: 0x06001F4F RID: 8015
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EnableDebugCamera_Internal(IntPtr @this);

		// Token: 0x06001F50 RID: 8016
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DumpVoiceMutingState_Internal(IntPtr @this);

		// Token: 0x06001F51 RID: 8017
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DumpPartyState_Internal(IntPtr @this);

		// Token: 0x06001F52 RID: 8018
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DumpOnlineSessionState_Internal(IntPtr @this);

		// Token: 0x06001F53 RID: 8019
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DumpChatState_Internal(IntPtr @this);

		// Token: 0x06001F54 RID: 8020
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DoPatchTest_Internal(IntPtr @this);

		// Token: 0x06001F55 RID: 8021
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DisableDebugCamera_Internal(IntPtr @this);

		// Token: 0x06001F56 RID: 8022
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DestroyTarget_Internal(IntPtr @this);

		// Token: 0x06001F57 RID: 8023
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DestroyServerStatReplicator_Internal(IntPtr @this);

		// Token: 0x06001F58 RID: 8024
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DestroyPawns_Internal(IntPtr @this, IntPtr aClass);

		// Token: 0x06001F59 RID: 8025
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DestroyAllPawnsExceptTarget_Internal(IntPtr @this);

		// Token: 0x06001F5A RID: 8026
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DestroyAll_Internal(IntPtr @this, IntPtr aClass);

		// Token: 0x06001F5B RID: 8027
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DebugCapsuleSweepSize_Internal(IntPtr @this, float HalfHeight, float Radius);

		// Token: 0x06001F5C RID: 8028
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DebugCapsuleSweepPawn_Internal(IntPtr @this);

		// Token: 0x06001F5D RID: 8029
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DebugCapsuleSweepComplex_Internal(IntPtr @this, bool bTraceComplex);

		// Token: 0x06001F5E RID: 8030
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DebugCapsuleSweepClear_Internal(IntPtr @this);

		// Token: 0x06001F5F RID: 8031
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DebugCapsuleSweepChannel_Internal(IntPtr @this, TEnumAsByte<ECollisionChannel> Channel);

		// Token: 0x06001F60 RID: 8032
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DebugCapsuleSweepCapture_Internal(IntPtr @this);

		// Token: 0x06001F61 RID: 8033
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DebugCapsuleSweep_Internal(IntPtr @this);

		// Token: 0x06001F62 RID: 8034
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DamageTarget_Internal(IntPtr @this, float DamageAmount);

		// Token: 0x06001F63 RID: 8035
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CheatScript_Internal(IntPtr @this, in FString ScriptName);

		// Token: 0x06001F64 RID: 8036
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ChangeSize_Internal(IntPtr @this, float F);

		// Token: 0x06001F65 RID: 8037
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BugItStringCreator_Internal(IntPtr @this, FVector ViewLocation, FRotator ViewRotation, ref FString GoString, ref FString LocString);

		// Token: 0x06001F66 RID: 8038
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BugItGo_Internal(IntPtr @this, float X, float Y, float Z, float Pitch, float Yaw, float Roll);

		// Token: 0x06001F67 RID: 8039
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BugIt_Internal(IntPtr @this, in FString ScreenShotDescription);

		// Token: 0x06001F68 RID: 8040 RVA: 0x0002D722 File Offset: 0x0002B922
		static UCheatManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CheatManager");
		}

		// Token: 0x06001F69 RID: 8041 RVA: 0x0002D730 File Offset: 0x0002B930
		protected UCheatManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000A60 RID: 2656
		public new const string __ObjectPath = "/Script/Engine.CheatManager";

		// Token: 0x04000A61 RID: 2657
		private static IntPtr _ClassPtr;

		// Token: 0x04000A62 RID: 2658
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
