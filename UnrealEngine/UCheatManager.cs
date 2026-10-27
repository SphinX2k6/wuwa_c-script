using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200092D RID: 2349
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CheatManager")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UCheatManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600845F RID: 33887 RVA: 0x000BD2EA File Offset: 0x000BB4EA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCheatManager._ClassPtr;
		}

		// Token: 0x06008460 RID: 33888 RVA: 0x000BD2F8 File Offset: 0x000BB4F8
		public UCheatManager() : this(BuiltinUtils.AllocNativeUObject(UCheatManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008461 RID: 33889 RVA: 0x000BD320 File Offset: 0x000BB520
		public UCheatManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCheatManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001F56 RID: 8022
		// (get) Token: 0x06008462 RID: 33890 RVA: 0x000BD353 File Offset: 0x000BB553
		// (set) Token: 0x06008463 RID: 33891 RVA: 0x000BD367 File Offset: 0x000BB567
		[Nullable(2)]
		public unsafe ADebugCameraController DebugCameraControllerRef
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ADebugCameraController>(base.NativePtr / (IntPtr)sizeof(void*) + UCheatManager.__PropertyOffset_DebugCameraControllerRef);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UCheatManager.__PropertyOffset_DebugCameraControllerRef, value);
			}
		}

		// Token: 0x17001F57 RID: 8023
		// (get) Token: 0x06008464 RID: 33892 RVA: 0x000BD37C File Offset: 0x000BB57C
		// (set) Token: 0x06008465 RID: 33893 RVA: 0x000BD390 File Offset: 0x000BB590
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<ADebugCameraController> DebugCameraControllerClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UCheatManager.__PropertyOffset_DebugCameraControllerClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UCheatManager.__PropertyOffset_DebugCameraControllerClass) = value;
			}
		}

		// Token: 0x06008466 RID: 33894 RVA: 0x000BD3A5 File Offset: 0x000BB5A5
		public void Walk()
		{
			UCheatManager.__Walk_Internal(base.NativePtr);
		}

		// Token: 0x06008467 RID: 33895 RVA: 0x000BD3B2 File Offset: 0x000BB5B2
		public void ViewSelf()
		{
			UCheatManager.__ViewSelf_Internal(base.NativePtr);
		}

		// Token: 0x06008468 RID: 33896 RVA: 0x000BD3C0 File Offset: 0x000BB5C0
		public unsafe void ViewPlayer(string S)
		{
			FString fstring = FString.AllocTemp(S);
			UCheatManager.__ViewPlayer_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06008469 RID: 33897 RVA: 0x000BD3EA File Offset: 0x000BB5EA
		public void ViewClass([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> DesiredClass)
		{
			UCheatManager.__ViewClass_Internal(base.NativePtr, DesiredClass._NativePtr);
		}

		// Token: 0x0600846A RID: 33898 RVA: 0x000BD3FD File Offset: 0x000BB5FD
		public void ViewActor(FName ActorName)
		{
			UCheatManager.__ViewActor_Internal(base.NativePtr, ActorName);
		}

		// Token: 0x0600846B RID: 33899 RVA: 0x000BD40B File Offset: 0x000BB60B
		public void UpdateSafeArea()
		{
			UCheatManager.__UpdateSafeArea_Internal(base.NativePtr);
		}

		// Token: 0x0600846C RID: 33900 RVA: 0x000BD418 File Offset: 0x000BB618
		public void ToggleServerStatReplicatorUpdateStatNet()
		{
			UCheatManager.__ToggleServerStatReplicatorUpdateStatNet_Internal(base.NativePtr);
		}

		// Token: 0x0600846D RID: 33901 RVA: 0x000BD425 File Offset: 0x000BB625
		public void ToggleServerStatReplicatorClientOverwrite()
		{
			UCheatManager.__ToggleServerStatReplicatorClientOverwrite_Internal(base.NativePtr);
		}

		// Token: 0x0600846E RID: 33902 RVA: 0x000BD432 File Offset: 0x000BB632
		public void ToggleDebugCamera()
		{
			UCheatManager.__ToggleDebugCamera_Internal(base.NativePtr);
		}

		// Token: 0x0600846F RID: 33903 RVA: 0x000BD43F File Offset: 0x000BB63F
		public void ToggleAILogging()
		{
			UCheatManager.__ToggleAILogging_Internal(base.NativePtr);
		}

		// Token: 0x06008470 RID: 33904 RVA: 0x000BD44C File Offset: 0x000BB64C
		public void TestCollisionDistance()
		{
			UCheatManager.__TestCollisionDistance_Internal(base.NativePtr);
		}

		// Token: 0x06008471 RID: 33905 RVA: 0x000BD459 File Offset: 0x000BB659
		public void Teleport()
		{
			UCheatManager.__Teleport_Internal(base.NativePtr);
		}

		// Token: 0x06008472 RID: 33906 RVA: 0x000BD468 File Offset: 0x000BB668
		public unsafe void Summon(string ClassName)
		{
			FString fstring = FString.AllocTemp(ClassName);
			UCheatManager.__Summon_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06008473 RID: 33907 RVA: 0x000BD492 File Offset: 0x000BB692
		public void StreamLevelOut(FName PackageName)
		{
			UCheatManager.__StreamLevelOut_Internal(base.NativePtr, PackageName);
		}

		// Token: 0x06008474 RID: 33908 RVA: 0x000BD4A0 File Offset: 0x000BB6A0
		public void StreamLevelIn(FName PackageName)
		{
			UCheatManager.__StreamLevelIn_Internal(base.NativePtr, PackageName);
		}

		// Token: 0x06008475 RID: 33909 RVA: 0x000BD4AE File Offset: 0x000BB6AE
		public void SpawnServerStatReplicator()
		{
			UCheatManager.__SpawnServerStatReplicator_Internal(base.NativePtr);
		}

		// Token: 0x06008476 RID: 33910 RVA: 0x000BD4BB File Offset: 0x000BB6BB
		public void Slomo(float NewTimeDilation)
		{
			UCheatManager.__Slomo_Internal(base.NativePtr, NewTimeDilation);
		}

		// Token: 0x06008477 RID: 33911 RVA: 0x000BD4C9 File Offset: 0x000BB6C9
		public void SetWorldOrigin()
		{
			UCheatManager.__SetWorldOrigin_Internal(base.NativePtr);
		}

		// Token: 0x06008478 RID: 33912 RVA: 0x000BD4D6 File Offset: 0x000BB6D6
		public void SetMouseSensitivityToDefault()
		{
			UCheatManager.__SetMouseSensitivityToDefault_Internal(base.NativePtr);
		}

		// Token: 0x06008479 RID: 33913 RVA: 0x000BD4E3 File Offset: 0x000BB6E3
		public void ServerToggleAILogging()
		{
			UCheatManager.__ServerToggleAILogging_Internal(base.NativePtr);
		}

		// Token: 0x0600847A RID: 33914 RVA: 0x000BD4F0 File Offset: 0x000BB6F0
		public void ReSetWorldOrigin()
		{
			UCheatManager.__ReSetWorldOrigin_Internal(base.NativePtr);
		}

		// Token: 0x0600847B RID: 33915 RVA: 0x000BD4FD File Offset: 0x000BB6FD
		public virtual void ReceiveInitCheatManager()
		{
			UCheatManager.__ReceiveInitCheatManager_Internal(base.NativePtr);
		}

		// Token: 0x0600847C RID: 33916 RVA: 0x000BD50A File Offset: 0x000BB70A
		public virtual void ReceiveEndPlay()
		{
			UCheatManager.__ReceiveEndPlay_Internal(base.NativePtr);
		}

		// Token: 0x0600847D RID: 33917 RVA: 0x000BD517 File Offset: 0x000BB717
		public void PlayersOnly()
		{
			UCheatManager.__PlayersOnly_Internal(base.NativePtr);
		}

		// Token: 0x0600847E RID: 33918 RVA: 0x000BD524 File Offset: 0x000BB724
		public void OnlyLoadLevel(FName PackageName)
		{
			UCheatManager.__OnlyLoadLevel_Internal(base.NativePtr, PackageName);
		}

		// Token: 0x0600847F RID: 33919 RVA: 0x000BD532 File Offset: 0x000BB732
		public void LogLoc()
		{
			UCheatManager.__LogLoc_Internal(base.NativePtr);
		}

		// Token: 0x06008480 RID: 33920 RVA: 0x000BD53F File Offset: 0x000BB73F
		public void InvertMouse()
		{
			UCheatManager.__InvertMouse_Internal(base.NativePtr);
		}

		// Token: 0x06008481 RID: 33921 RVA: 0x000BD54C File Offset: 0x000BB74C
		public void God()
		{
			UCheatManager.__God_Internal(base.NativePtr);
		}

		// Token: 0x06008482 RID: 33922 RVA: 0x000BD559 File Offset: 0x000BB759
		public void Ghost()
		{
			UCheatManager.__Ghost_Internal(base.NativePtr);
		}

		// Token: 0x06008483 RID: 33923 RVA: 0x000BD566 File Offset: 0x000BB766
		public void FreezeFrame(float Delay)
		{
			UCheatManager.__FreezeFrame_Internal(base.NativePtr, Delay);
		}

		// Token: 0x06008484 RID: 33924 RVA: 0x000BD574 File Offset: 0x000BB774
		public void Fly()
		{
			UCheatManager.__Fly_Internal(base.NativePtr);
		}

		// Token: 0x06008485 RID: 33925 RVA: 0x000BD581 File Offset: 0x000BB781
		public void FlushLog()
		{
			UCheatManager.__FlushLog_Internal(base.NativePtr);
		}

		// Token: 0x06008486 RID: 33926 RVA: 0x000BD58E File Offset: 0x000BB78E
		public void EnableDebugCamera()
		{
			UCheatManager.__EnableDebugCamera_Internal(base.NativePtr);
		}

		// Token: 0x06008487 RID: 33927 RVA: 0x000BD59B File Offset: 0x000BB79B
		public void DumpVoiceMutingState()
		{
			UCheatManager.__DumpVoiceMutingState_Internal(base.NativePtr);
		}

		// Token: 0x06008488 RID: 33928 RVA: 0x000BD5A8 File Offset: 0x000BB7A8
		public void DumpPartyState()
		{
			UCheatManager.__DumpPartyState_Internal(base.NativePtr);
		}

		// Token: 0x06008489 RID: 33929 RVA: 0x000BD5B5 File Offset: 0x000BB7B5
		public void DumpOnlineSessionState()
		{
			UCheatManager.__DumpOnlineSessionState_Internal(base.NativePtr);
		}

		// Token: 0x0600848A RID: 33930 RVA: 0x000BD5C2 File Offset: 0x000BB7C2
		public void DumpChatState()
		{
			UCheatManager.__DumpChatState_Internal(base.NativePtr);
		}

		// Token: 0x0600848B RID: 33931 RVA: 0x000BD5CF File Offset: 0x000BB7CF
		public void DoPatchTest()
		{
			UCheatManager.__DoPatchTest_Internal(base.NativePtr);
		}

		// Token: 0x0600848C RID: 33932 RVA: 0x000BD5DC File Offset: 0x000BB7DC
		public void DisableDebugCamera()
		{
			UCheatManager.__DisableDebugCamera_Internal(base.NativePtr);
		}

		// Token: 0x0600848D RID: 33933 RVA: 0x000BD5E9 File Offset: 0x000BB7E9
		public void DestroyTarget()
		{
			UCheatManager.__DestroyTarget_Internal(base.NativePtr);
		}

		// Token: 0x0600848E RID: 33934 RVA: 0x000BD5F6 File Offset: 0x000BB7F6
		public void DestroyServerStatReplicator()
		{
			UCheatManager.__DestroyServerStatReplicator_Internal(base.NativePtr);
		}

		// Token: 0x0600848F RID: 33935 RVA: 0x000BD603 File Offset: 0x000BB803
		public void DestroyPawns([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<APawn> aClass)
		{
			UCheatManager.__DestroyPawns_Internal(base.NativePtr, aClass._NativePtr);
		}

		// Token: 0x06008490 RID: 33936 RVA: 0x000BD616 File Offset: 0x000BB816
		public void DestroyAllPawnsExceptTarget()
		{
			UCheatManager.__DestroyAllPawnsExceptTarget_Internal(base.NativePtr);
		}

		// Token: 0x06008491 RID: 33937 RVA: 0x000BD623 File Offset: 0x000BB823
		public void DestroyAll([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> aClass)
		{
			UCheatManager.__DestroyAll_Internal(base.NativePtr, aClass._NativePtr);
		}

		// Token: 0x06008492 RID: 33938 RVA: 0x000BD636 File Offset: 0x000BB836
		public void DebugCapsuleSweepSize(float HalfHeight, float Radius)
		{
			UCheatManager.__DebugCapsuleSweepSize_Internal(base.NativePtr, HalfHeight, Radius);
		}

		// Token: 0x06008493 RID: 33939 RVA: 0x000BD645 File Offset: 0x000BB845
		public void DebugCapsuleSweepPawn()
		{
			UCheatManager.__DebugCapsuleSweepPawn_Internal(base.NativePtr);
		}

		// Token: 0x06008494 RID: 33940 RVA: 0x000BD652 File Offset: 0x000BB852
		public void DebugCapsuleSweepComplex(bool bTraceComplex)
		{
			UCheatManager.__DebugCapsuleSweepComplex_Internal(base.NativePtr, bTraceComplex);
		}

		// Token: 0x06008495 RID: 33941 RVA: 0x000BD660 File Offset: 0x000BB860
		public void DebugCapsuleSweepClear()
		{
			UCheatManager.__DebugCapsuleSweepClear_Internal(base.NativePtr);
		}

		// Token: 0x06008496 RID: 33942 RVA: 0x000BD66D File Offset: 0x000BB86D
		public void DebugCapsuleSweepChannel(ECollisionChannel Channel)
		{
			UCheatManager.__DebugCapsuleSweepChannel_Internal(base.NativePtr, Channel);
		}

		// Token: 0x06008497 RID: 33943 RVA: 0x000BD680 File Offset: 0x000BB880
		public void DebugCapsuleSweepCapture()
		{
			UCheatManager.__DebugCapsuleSweepCapture_Internal(base.NativePtr);
		}

		// Token: 0x06008498 RID: 33944 RVA: 0x000BD68D File Offset: 0x000BB88D
		public void DebugCapsuleSweep()
		{
			UCheatManager.__DebugCapsuleSweep_Internal(base.NativePtr);
		}

		// Token: 0x06008499 RID: 33945 RVA: 0x000BD69A File Offset: 0x000BB89A
		public void DamageTarget(float DamageAmount)
		{
			UCheatManager.__DamageTarget_Internal(base.NativePtr, DamageAmount);
		}

		// Token: 0x0600849A RID: 33946 RVA: 0x000BD6A8 File Offset: 0x000BB8A8
		public unsafe void CheatScript(string ScriptName)
		{
			FString fstring = FString.AllocTemp(ScriptName);
			UCheatManager.__CheatScript_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600849B RID: 33947 RVA: 0x000BD6D2 File Offset: 0x000BB8D2
		public void ChangeSize(float F)
		{
			UCheatManager.__ChangeSize_Internal(base.NativePtr, F);
		}

		// Token: 0x0600849C RID: 33948 RVA: 0x000BD6E0 File Offset: 0x000BB8E0
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

		// Token: 0x0600849D RID: 33949 RVA: 0x000BD734 File Offset: 0x000BB934
		public void BugItGo(float X, float Y, float Z, float Pitch, float Yaw, float Roll)
		{
			UCheatManager.__BugItGo_Internal(base.NativePtr, X, Y, Z, Pitch, Yaw, Roll);
		}

		// Token: 0x0600849E RID: 33950 RVA: 0x000BD74C File Offset: 0x000BB94C
		public unsafe void BugIt(string ScreenShotDescription = "")
		{
			FString fstring = FString.AllocTemp(ScreenShotDescription);
			UCheatManager.__BugIt_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600849F RID: 33951
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Walk_Internal(IntPtr @this);

		// Token: 0x060084A0 RID: 33952
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ViewSelf_Internal(IntPtr @this);

		// Token: 0x060084A1 RID: 33953
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ViewPlayer_Internal(IntPtr @this, in FString S);

		// Token: 0x060084A2 RID: 33954
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ViewClass_Internal(IntPtr @this, IntPtr DesiredClass);

		// Token: 0x060084A3 RID: 33955
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ViewActor_Internal(IntPtr @this, FName ActorName);

		// Token: 0x060084A4 RID: 33956
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateSafeArea_Internal(IntPtr @this);

		// Token: 0x060084A5 RID: 33957
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ToggleServerStatReplicatorUpdateStatNet_Internal(IntPtr @this);

		// Token: 0x060084A6 RID: 33958
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ToggleServerStatReplicatorClientOverwrite_Internal(IntPtr @this);

		// Token: 0x060084A7 RID: 33959
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ToggleDebugCamera_Internal(IntPtr @this);

		// Token: 0x060084A8 RID: 33960
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ToggleAILogging_Internal(IntPtr @this);

		// Token: 0x060084A9 RID: 33961
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TestCollisionDistance_Internal(IntPtr @this);

		// Token: 0x060084AA RID: 33962
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Teleport_Internal(IntPtr @this);

		// Token: 0x060084AB RID: 33963
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Summon_Internal(IntPtr @this, in FString ClassName);

		// Token: 0x060084AC RID: 33964
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StreamLevelOut_Internal(IntPtr @this, FName PackageName);

		// Token: 0x060084AD RID: 33965
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StreamLevelIn_Internal(IntPtr @this, FName PackageName);

		// Token: 0x060084AE RID: 33966
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SpawnServerStatReplicator_Internal(IntPtr @this);

		// Token: 0x060084AF RID: 33967
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Slomo_Internal(IntPtr @this, float NewTimeDilation);

		// Token: 0x060084B0 RID: 33968
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWorldOrigin_Internal(IntPtr @this);

		// Token: 0x060084B1 RID: 33969
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMouseSensitivityToDefault_Internal(IntPtr @this);

		// Token: 0x060084B2 RID: 33970
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerToggleAILogging_Internal(IntPtr @this);

		// Token: 0x060084B3 RID: 33971
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReSetWorldOrigin_Internal(IntPtr @this);

		// Token: 0x060084B4 RID: 33972
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveInitCheatManager_Internal(IntPtr @this);

		// Token: 0x060084B5 RID: 33973
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveEndPlay_Internal(IntPtr @this);

		// Token: 0x060084B6 RID: 33974
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayersOnly_Internal(IntPtr @this);

		// Token: 0x060084B7 RID: 33975
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnlyLoadLevel_Internal(IntPtr @this, FName PackageName);

		// Token: 0x060084B8 RID: 33976
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LogLoc_Internal(IntPtr @this);

		// Token: 0x060084B9 RID: 33977
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InvertMouse_Internal(IntPtr @this);

		// Token: 0x060084BA RID: 33978
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __God_Internal(IntPtr @this);

		// Token: 0x060084BB RID: 33979
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Ghost_Internal(IntPtr @this);

		// Token: 0x060084BC RID: 33980
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FreezeFrame_Internal(IntPtr @this, float Delay);

		// Token: 0x060084BD RID: 33981
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Fly_Internal(IntPtr @this);

		// Token: 0x060084BE RID: 33982
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FlushLog_Internal(IntPtr @this);

		// Token: 0x060084BF RID: 33983
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EnableDebugCamera_Internal(IntPtr @this);

		// Token: 0x060084C0 RID: 33984
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DumpVoiceMutingState_Internal(IntPtr @this);

		// Token: 0x060084C1 RID: 33985
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DumpPartyState_Internal(IntPtr @this);

		// Token: 0x060084C2 RID: 33986
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DumpOnlineSessionState_Internal(IntPtr @this);

		// Token: 0x060084C3 RID: 33987
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DumpChatState_Internal(IntPtr @this);

		// Token: 0x060084C4 RID: 33988
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DoPatchTest_Internal(IntPtr @this);

		// Token: 0x060084C5 RID: 33989
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DisableDebugCamera_Internal(IntPtr @this);

		// Token: 0x060084C6 RID: 33990
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DestroyTarget_Internal(IntPtr @this);

		// Token: 0x060084C7 RID: 33991
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DestroyServerStatReplicator_Internal(IntPtr @this);

		// Token: 0x060084C8 RID: 33992
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DestroyPawns_Internal(IntPtr @this, IntPtr aClass);

		// Token: 0x060084C9 RID: 33993
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DestroyAllPawnsExceptTarget_Internal(IntPtr @this);

		// Token: 0x060084CA RID: 33994
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DestroyAll_Internal(IntPtr @this, IntPtr aClass);

		// Token: 0x060084CB RID: 33995
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DebugCapsuleSweepSize_Internal(IntPtr @this, float HalfHeight, float Radius);

		// Token: 0x060084CC RID: 33996
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DebugCapsuleSweepPawn_Internal(IntPtr @this);

		// Token: 0x060084CD RID: 33997
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DebugCapsuleSweepComplex_Internal(IntPtr @this, bool bTraceComplex);

		// Token: 0x060084CE RID: 33998
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DebugCapsuleSweepClear_Internal(IntPtr @this);

		// Token: 0x060084CF RID: 33999
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DebugCapsuleSweepChannel_Internal(IntPtr @this, TEnumAsByte<ECollisionChannel> Channel);

		// Token: 0x060084D0 RID: 34000
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DebugCapsuleSweepCapture_Internal(IntPtr @this);

		// Token: 0x060084D1 RID: 34001
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DebugCapsuleSweep_Internal(IntPtr @this);

		// Token: 0x060084D2 RID: 34002
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DamageTarget_Internal(IntPtr @this, float DamageAmount);

		// Token: 0x060084D3 RID: 34003
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CheatScript_Internal(IntPtr @this, in FString ScriptName);

		// Token: 0x060084D4 RID: 34004
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ChangeSize_Internal(IntPtr @this, float F);

		// Token: 0x060084D5 RID: 34005
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BugItStringCreator_Internal(IntPtr @this, FVector ViewLocation, FRotator ViewRotation, ref FString GoString, ref FString LocString);

		// Token: 0x060084D6 RID: 34006
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BugItGo_Internal(IntPtr @this, float X, float Y, float Z, float Pitch, float Yaw, float Roll);

		// Token: 0x060084D7 RID: 34007
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BugIt_Internal(IntPtr @this, in FString ScreenShotDescription);

		// Token: 0x060084D8 RID: 34008 RVA: 0x000BD776 File Offset: 0x000BB976
		static UCheatManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CheatManager");
		}

		// Token: 0x060084D9 RID: 34009 RVA: 0x000BD784 File Offset: 0x000BB984
		protected UCheatManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003F34 RID: 16180
		public new const string __ObjectPath = "/Script/Engine.CheatManager";

		// Token: 0x04003F35 RID: 16181
		private static IntPtr _ClassPtr;

		// Token: 0x04003F36 RID: 16182
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003F37 RID: 16183
		internal static int __PropertyOffset_DebugCameraControllerRef;

		// Token: 0x04003F38 RID: 16184
		internal static int __PropertyOffset_DebugCameraControllerClass;
	}
}
