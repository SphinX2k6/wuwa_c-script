using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000BFD RID: 3069
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.GameModeBase")]
	[UnrealStructLayout(1208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1208)]
	public class AGameModeBase : AInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060097A6 RID: 38822 RVA: 0x000D80DC File Offset: 0x000D62DC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AGameModeBase._ClassPtr;
		}

		// Token: 0x060097A7 RID: 38823 RVA: 0x000D80E8 File Offset: 0x000D62E8
		public AGameModeBase() : this(BuiltinUtils.AllocNativeUObject(AGameModeBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060097A8 RID: 38824 RVA: 0x000D8110 File Offset: 0x000D6310
		[NullableContext(1)]
		public AGameModeBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AGameModeBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002455 RID: 9301
		// (get) Token: 0x060097A9 RID: 38825 RVA: 0x000D8143 File Offset: 0x000D6343
		// (set) Token: 0x060097AA RID: 38826 RVA: 0x000D8157 File Offset: 0x000D6357
		[Nullable(1)]
		public unsafe string OptionsString
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)AGameModeBase.__PropertyOffset_OptionsString)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)AGameModeBase.__PropertyOffset_OptionsString)), value);
			}
		}

		// Token: 0x17002456 RID: 9302
		// (get) Token: 0x060097AB RID: 38827 RVA: 0x000D816C File Offset: 0x000D636C
		// (set) Token: 0x060097AC RID: 38828 RVA: 0x000D8180 File Offset: 0x000D6380
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<AGameSession> GameSessionClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)AGameModeBase.__PropertyOffset_GameSessionClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)AGameModeBase.__PropertyOffset_GameSessionClass) = value;
			}
		}

		// Token: 0x17002457 RID: 9303
		// (get) Token: 0x060097AD RID: 38829 RVA: 0x000D8195 File Offset: 0x000D6395
		// (set) Token: 0x060097AE RID: 38830 RVA: 0x000D81A9 File Offset: 0x000D63A9
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<AGameStateBase> GameStateClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)AGameModeBase.__PropertyOffset_GameStateClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)AGameModeBase.__PropertyOffset_GameStateClass) = value;
			}
		}

		// Token: 0x17002458 RID: 9304
		// (get) Token: 0x060097AF RID: 38831 RVA: 0x000D81BE File Offset: 0x000D63BE
		// (set) Token: 0x060097B0 RID: 38832 RVA: 0x000D81D2 File Offset: 0x000D63D2
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<APlayerController> PlayerControllerClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)AGameModeBase.__PropertyOffset_PlayerControllerClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)AGameModeBase.__PropertyOffset_PlayerControllerClass) = value;
			}
		}

		// Token: 0x17002459 RID: 9305
		// (get) Token: 0x060097B1 RID: 38833 RVA: 0x000D81E7 File Offset: 0x000D63E7
		// (set) Token: 0x060097B2 RID: 38834 RVA: 0x000D81FB File Offset: 0x000D63FB
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<APlayerState> PlayerStateClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)AGameModeBase.__PropertyOffset_PlayerStateClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)AGameModeBase.__PropertyOffset_PlayerStateClass) = value;
			}
		}

		// Token: 0x1700245A RID: 9306
		// (get) Token: 0x060097B3 RID: 38835 RVA: 0x000D8210 File Offset: 0x000D6410
		// (set) Token: 0x060097B4 RID: 38836 RVA: 0x000D8224 File Offset: 0x000D6424
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<AHUD> HUDClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)AGameModeBase.__PropertyOffset_HUDClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)AGameModeBase.__PropertyOffset_HUDClass) = value;
			}
		}

		// Token: 0x1700245B RID: 9307
		// (get) Token: 0x060097B5 RID: 38837 RVA: 0x000D8239 File Offset: 0x000D6439
		// (set) Token: 0x060097B6 RID: 38838 RVA: 0x000D824D File Offset: 0x000D644D
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<APawn> DefaultPawnClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)AGameModeBase.__PropertyOffset_DefaultPawnClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)AGameModeBase.__PropertyOffset_DefaultPawnClass) = value;
			}
		}

		// Token: 0x1700245C RID: 9308
		// (get) Token: 0x060097B7 RID: 38839 RVA: 0x000D8262 File Offset: 0x000D6462
		// (set) Token: 0x060097B8 RID: 38840 RVA: 0x000D8276 File Offset: 0x000D6476
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<ASpectatorPawn> SpectatorClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)AGameModeBase.__PropertyOffset_SpectatorClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)AGameModeBase.__PropertyOffset_SpectatorClass) = value;
			}
		}

		// Token: 0x1700245D RID: 9309
		// (get) Token: 0x060097B9 RID: 38841 RVA: 0x000D828B File Offset: 0x000D648B
		// (set) Token: 0x060097BA RID: 38842 RVA: 0x000D829F File Offset: 0x000D649F
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<APlayerController> ReplaySpectatorPlayerControllerClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)AGameModeBase.__PropertyOffset_ReplaySpectatorPlayerControllerClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)AGameModeBase.__PropertyOffset_ReplaySpectatorPlayerControllerClass) = value;
			}
		}

		// Token: 0x1700245E RID: 9310
		// (get) Token: 0x060097BB RID: 38843 RVA: 0x000D82B4 File Offset: 0x000D64B4
		// (set) Token: 0x060097BC RID: 38844 RVA: 0x000D82C8 File Offset: 0x000D64C8
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<AServerStatReplicator> ServerStatReplicatorClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)AGameModeBase.__PropertyOffset_ServerStatReplicatorClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)AGameModeBase.__PropertyOffset_ServerStatReplicatorClass) = value;
			}
		}

		// Token: 0x1700245F RID: 9311
		// (get) Token: 0x060097BD RID: 38845 RVA: 0x000D82DD File Offset: 0x000D64DD
		// (set) Token: 0x060097BE RID: 38846 RVA: 0x000D82F1 File Offset: 0x000D64F1
		public unsafe AGameSession GameSession
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AGameSession>(base.NativePtr / (IntPtr)sizeof(void*) + AGameModeBase.__PropertyOffset_GameSession);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AGameModeBase.__PropertyOffset_GameSession, value);
			}
		}

		// Token: 0x17002460 RID: 9312
		// (get) Token: 0x060097BF RID: 38847 RVA: 0x000D8306 File Offset: 0x000D6506
		// (set) Token: 0x060097C0 RID: 38848 RVA: 0x000D831A File Offset: 0x000D651A
		public unsafe AGameStateBase GameState
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AGameStateBase>(base.NativePtr / (IntPtr)sizeof(void*) + AGameModeBase.__PropertyOffset_GameState);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AGameModeBase.__PropertyOffset_GameState, value);
			}
		}

		// Token: 0x17002461 RID: 9313
		// (get) Token: 0x060097C1 RID: 38849 RVA: 0x000D832F File Offset: 0x000D652F
		// (set) Token: 0x060097C2 RID: 38850 RVA: 0x000D8343 File Offset: 0x000D6543
		public unsafe AServerStatReplicator ServerStatReplicator
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AServerStatReplicator>(base.NativePtr / (IntPtr)sizeof(void*) + AGameModeBase.__PropertyOffset_ServerStatReplicator);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AGameModeBase.__PropertyOffset_ServerStatReplicator, value);
			}
		}

		// Token: 0x17002462 RID: 9314
		// (get) Token: 0x060097C3 RID: 38851 RVA: 0x000D8358 File Offset: 0x000D6558
		// (set) Token: 0x060097C4 RID: 38852 RVA: 0x000D8391 File Offset: 0x000D6591
		[Nullable(1)]
		public unsafe FText DefaultPlayerName
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._DefaultPlayerName) == null)
				{
					result = (this._DefaultPlayerName = new FText(base.NativePtr + (IntPtr)AGameModeBase.__PropertyOffset_DefaultPlayerName, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)AGameModeBase.__PropertyOffset_DefaultPlayerName)), value.NativePtr, 1);
			}
		}

		// Token: 0x17002463 RID: 9315
		// (get) Token: 0x060097C5 RID: 38853 RVA: 0x000D83AC File Offset: 0x000D65AC
		// (set) Token: 0x060097C6 RID: 38854 RVA: 0x000D83C5 File Offset: 0x000D65C5
		public unsafe bool bUseSeamlessTravel
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AGameModeBase.__PropertyOffset_bUseSeamlessTravel) & AGameModeBase.__PropertyMask_bUseSeamlessTravel) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AGameModeBase.__PropertyOffset_bUseSeamlessTravel) = ((*(base.NativePtr + (IntPtr)AGameModeBase.__PropertyOffset_bUseSeamlessTravel) & ~AGameModeBase.__PropertyMask_bUseSeamlessTravel) | (value ? AGameModeBase.__PropertyMask_bUseSeamlessTravel : 0));
			}
		}

		// Token: 0x17002464 RID: 9316
		// (get) Token: 0x060097C7 RID: 38855 RVA: 0x000D83F5 File Offset: 0x000D65F5
		// (set) Token: 0x060097C8 RID: 38856 RVA: 0x000D840E File Offset: 0x000D660E
		public unsafe bool bStartPlayersAsSpectators
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AGameModeBase.__PropertyOffset_bStartPlayersAsSpectators) & AGameModeBase.__PropertyMask_bStartPlayersAsSpectators) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AGameModeBase.__PropertyOffset_bStartPlayersAsSpectators) = ((*(base.NativePtr + (IntPtr)AGameModeBase.__PropertyOffset_bStartPlayersAsSpectators) & ~AGameModeBase.__PropertyMask_bStartPlayersAsSpectators) | (value ? AGameModeBase.__PropertyMask_bStartPlayersAsSpectators : 0));
			}
		}

		// Token: 0x17002465 RID: 9317
		// (get) Token: 0x060097C9 RID: 38857 RVA: 0x000D843E File Offset: 0x000D663E
		// (set) Token: 0x060097CA RID: 38858 RVA: 0x000D8457 File Offset: 0x000D6657
		public unsafe bool bPauseable
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AGameModeBase.__PropertyOffset_bPauseable) & AGameModeBase.__PropertyMask_bPauseable) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AGameModeBase.__PropertyOffset_bPauseable) = ((*(base.NativePtr + (IntPtr)AGameModeBase.__PropertyOffset_bPauseable) & ~AGameModeBase.__PropertyMask_bPauseable) | (value ? AGameModeBase.__PropertyMask_bPauseable : 0));
			}
		}

		// Token: 0x060097CB RID: 38859 RVA: 0x000D8487 File Offset: 0x000D6687
		public void StartPlay()
		{
			AGameModeBase.__StartPlay_Internal(base.NativePtr);
		}

		// Token: 0x060097CC RID: 38860 RVA: 0x000D8494 File Offset: 0x000D6694
		public virtual APawn SpawnDefaultPawnFor(AController NewPlayer, AActor StartSpot)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(AGameModeBase.__SpawnDefaultPawnFor_Internal(base.NativePtr, (NewPlayer != null) ? NewPlayer.NativePtr : IntPtr.Zero, (StartSpot != null) ? StartSpot.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060097CD RID: 38861 RVA: 0x000D84C6 File Offset: 0x000D66C6
		protected virtual APawn SpawnDefaultPawnFor_Implementation(AController NewPlayer, AActor StartSpot)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(AGameModeBase.__SpawnDefaultPawnFor_Implementation_Internal(base.NativePtr, (NewPlayer != null) ? NewPlayer.NativePtr : IntPtr.Zero, (StartSpot != null) ? StartSpot.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060097CE RID: 38862 RVA: 0x000D84F8 File Offset: 0x000D66F8
		public unsafe virtual APawn SpawnDefaultPawnAtTransform(AController NewPlayer, in FTransform SpawnTransform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = SpawnTransform;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(AGameModeBase.__SpawnDefaultPawnAtTransform_Internal(base.NativePtr, (NewPlayer != null) ? NewPlayer.NativePtr : IntPtr.Zero, ptr));
		}

		// Token: 0x060097CF RID: 38863 RVA: 0x000D8544 File Offset: 0x000D6744
		protected unsafe virtual APawn SpawnDefaultPawnAtTransform_Implementation(AController NewPlayer, in FTransform SpawnTransform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = SpawnTransform;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(AGameModeBase.__SpawnDefaultPawnAtTransform_Implementation_Internal(base.NativePtr, (NewPlayer != null) ? NewPlayer.NativePtr : IntPtr.Zero, ptr));
		}

		// Token: 0x060097D0 RID: 38864 RVA: 0x000D858E File Offset: 0x000D678E
		public virtual bool ShouldReset(AActor ActorToReset)
		{
			return AGameModeBase.__ShouldReset_Internal(base.NativePtr, (ActorToReset != null) ? ActorToReset.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060097D1 RID: 38865 RVA: 0x000D85AB File Offset: 0x000D67AB
		protected virtual bool ShouldReset_Implementation(AActor ActorToReset)
		{
			return AGameModeBase.__ShouldReset_Implementation_Internal(base.NativePtr, (ActorToReset != null) ? ActorToReset.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060097D2 RID: 38866 RVA: 0x000D85C8 File Offset: 0x000D67C8
		public void ReturnToMainMenuHost()
		{
			AGameModeBase.__ReturnToMainMenuHost_Internal(base.NativePtr);
		}

		// Token: 0x060097D3 RID: 38867 RVA: 0x000D85D8 File Offset: 0x000D67D8
		public unsafe void RestartPlayerAtTransform(AController NewPlayer, in FTransform SpawnTransform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = SpawnTransform;
			AGameModeBase.__RestartPlayerAtTransform_Internal(base.NativePtr, (NewPlayer != null) ? NewPlayer.NativePtr : IntPtr.Zero, ptr);
		}

		// Token: 0x060097D4 RID: 38868 RVA: 0x000D861D File Offset: 0x000D681D
		public void RestartPlayerAtPlayerStart(AController NewPlayer, AActor StartSpot)
		{
			AGameModeBase.__RestartPlayerAtPlayerStart_Internal(base.NativePtr, (NewPlayer != null) ? NewPlayer.NativePtr : IntPtr.Zero, (StartSpot != null) ? StartSpot.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060097D5 RID: 38869 RVA: 0x000D864A File Offset: 0x000D684A
		public void RestartPlayer(AController NewPlayer)
		{
			AGameModeBase.__RestartPlayer_Internal(base.NativePtr, (NewPlayer != null) ? NewPlayer.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060097D6 RID: 38870 RVA: 0x000D8667 File Offset: 0x000D6867
		public void ResetLevel()
		{
			AGameModeBase.__ResetLevel_Internal(base.NativePtr);
		}

		// Token: 0x060097D7 RID: 38871 RVA: 0x000D8674 File Offset: 0x000D6874
		public virtual bool PlayerCanRestart(APlayerController Player)
		{
			return AGameModeBase.__PlayerCanRestart_Internal(base.NativePtr, (Player != null) ? Player.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060097D8 RID: 38872 RVA: 0x000D8691 File Offset: 0x000D6891
		protected virtual bool PlayerCanRestart_Implementation(APlayerController Player)
		{
			return AGameModeBase.__PlayerCanRestart_Implementation_Internal(base.NativePtr, (Player != null) ? Player.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060097D9 RID: 38873 RVA: 0x000D86AE File Offset: 0x000D68AE
		public virtual bool MustSpectate(APlayerController NewPlayerController)
		{
			return AGameModeBase.__MustSpectate_Internal(base.NativePtr, (NewPlayerController != null) ? NewPlayerController.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060097DA RID: 38874 RVA: 0x000D86CB File Offset: 0x000D68CB
		protected virtual bool MustSpectate_Implementation(APlayerController NewPlayerController)
		{
			return AGameModeBase.__MustSpectate_Implementation_Internal(base.NativePtr, (NewPlayerController != null) ? NewPlayerController.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060097DB RID: 38875 RVA: 0x000D86E8 File Offset: 0x000D68E8
		public virtual void K2_PostLogin(APlayerController NewPlayer)
		{
			AGameModeBase.__K2_PostLogin_Internal(base.NativePtr, (NewPlayer != null) ? NewPlayer.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060097DC RID: 38876 RVA: 0x000D8705 File Offset: 0x000D6905
		public virtual void K2_OnSwapPlayerControllers(APlayerController OldPC, APlayerController NewPC)
		{
			AGameModeBase.__K2_OnSwapPlayerControllers_Internal(base.NativePtr, (OldPC != null) ? OldPC.NativePtr : IntPtr.Zero, (NewPC != null) ? NewPC.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060097DD RID: 38877 RVA: 0x000D8732 File Offset: 0x000D6932
		public virtual void K2_OnRestartPlayer(AController NewPlayer)
		{
			AGameModeBase.__K2_OnRestartPlayer_Internal(base.NativePtr, (NewPlayer != null) ? NewPlayer.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060097DE RID: 38878 RVA: 0x000D874F File Offset: 0x000D694F
		public virtual void K2_OnLogout(AController ExitingController)
		{
			AGameModeBase.__K2_OnLogout_Internal(base.NativePtr, (ExitingController != null) ? ExitingController.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060097DF RID: 38879 RVA: 0x000D876C File Offset: 0x000D696C
		[NullableContext(1)]
		public unsafe virtual void K2_OnChangeName([Nullable(2)] AController Other, string NewName, bool bNameChange)
		{
			FString fstring = FString.AllocTemp(NewName);
			AGameModeBase.__K2_OnChangeName_Internal(base.NativePtr, (Other != null) ? Other.NativePtr : IntPtr.Zero, fstring, bNameChange);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060097E0 RID: 38880 RVA: 0x000D87A8 File Offset: 0x000D69A8
		public unsafe AActor K2_FindPlayerStart(AController Player, [Nullable(1)] string IncomingName = "")
		{
			FString fstring = FString.AllocTemp(IncomingName);
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(AGameModeBase.__K2_FindPlayerStart_Internal(base.NativePtr, (Player != null) ? Player.NativePtr : IntPtr.Zero, fstring));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x060097E1 RID: 38881 RVA: 0x000D87E7 File Offset: 0x000D69E7
		public virtual void InitStartSpot(AActor StartSpot, AController NewPlayer)
		{
			AGameModeBase.__InitStartSpot_Internal(base.NativePtr, (StartSpot != null) ? StartSpot.NativePtr : IntPtr.Zero, (NewPlayer != null) ? NewPlayer.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060097E2 RID: 38882 RVA: 0x000D8814 File Offset: 0x000D6A14
		protected virtual void InitStartSpot_Implementation(AActor StartSpot, AController NewPlayer)
		{
			AGameModeBase.__InitStartSpot_Implementation_Internal(base.NativePtr, (StartSpot != null) ? StartSpot.NativePtr : IntPtr.Zero, (NewPlayer != null) ? NewPlayer.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060097E3 RID: 38883 RVA: 0x000D8841 File Offset: 0x000D6A41
		public virtual void InitializeHUDForPlayer(APlayerController NewPlayer)
		{
			AGameModeBase.__InitializeHUDForPlayer_Internal(base.NativePtr, (NewPlayer != null) ? NewPlayer.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060097E4 RID: 38884 RVA: 0x000D885E File Offset: 0x000D6A5E
		protected virtual void InitializeHUDForPlayer_Implementation(APlayerController NewPlayer)
		{
			AGameModeBase.__InitializeHUDForPlayer_Implementation_Internal(base.NativePtr, (NewPlayer != null) ? NewPlayer.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060097E5 RID: 38885 RVA: 0x000D887B File Offset: 0x000D6A7B
		public bool HasMatchStarted()
		{
			return AGameModeBase.__HasMatchStarted_Internal(base.NativePtr);
		}

		// Token: 0x060097E6 RID: 38886 RVA: 0x000D8888 File Offset: 0x000D6A88
		public bool HasMatchEnded()
		{
			return AGameModeBase.__HasMatchEnded_Internal(base.NativePtr);
		}

		// Token: 0x060097E7 RID: 38887 RVA: 0x000D8895 File Offset: 0x000D6A95
		public virtual void HandleStartingNewPlayer(APlayerController NewPlayer)
		{
			AGameModeBase.__HandleStartingNewPlayer_Internal(base.NativePtr, (NewPlayer != null) ? NewPlayer.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060097E8 RID: 38888 RVA: 0x000D88B2 File Offset: 0x000D6AB2
		protected virtual void HandleStartingNewPlayer_Implementation(APlayerController NewPlayer)
		{
			AGameModeBase.__HandleStartingNewPlayer_Implementation_Internal(base.NativePtr, (NewPlayer != null) ? NewPlayer.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060097E9 RID: 38889 RVA: 0x000D88CF File Offset: 0x000D6ACF
		public int GetNumSpectators()
		{
			return AGameModeBase.__GetNumSpectators_Internal(base.NativePtr);
		}

		// Token: 0x060097EA RID: 38890 RVA: 0x000D88DC File Offset: 0x000D6ADC
		public int GetNumPlayers()
		{
			return AGameModeBase.__GetNumPlayers_Internal(base.NativePtr);
		}

		// Token: 0x060097EB RID: 38891 RVA: 0x000D88E9 File Offset: 0x000D6AE9
		public virtual UClassStackOnlyPtr GetDefaultPawnClassForController(AController InController)
		{
			return AGameModeBase.__GetDefaultPawnClassForController_Internal(base.NativePtr, (InController != null) ? InController.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060097EC RID: 38892 RVA: 0x000D890B File Offset: 0x000D6B0B
		protected virtual UClassStackOnlyPtr GetDefaultPawnClassForController_Implementation(AController InController)
		{
			return AGameModeBase.__GetDefaultPawnClassForController_Implementation_Internal(base.NativePtr, (InController != null) ? InController.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060097ED RID: 38893 RVA: 0x000D8930 File Offset: 0x000D6B30
		public unsafe virtual AActor FindPlayerStart(AController Player, [Nullable(1)] string IncomingName)
		{
			FString fstring = FString.AllocTemp(IncomingName);
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(AGameModeBase.__FindPlayerStart_Internal(base.NativePtr, (Player != null) ? Player.NativePtr : IntPtr.Zero, fstring));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x060097EE RID: 38894 RVA: 0x000D8970 File Offset: 0x000D6B70
		protected unsafe virtual AActor FindPlayerStart_Implementation(AController Player, [Nullable(1)] string IncomingName)
		{
			FString fstring = FString.AllocTemp(IncomingName);
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(AGameModeBase.__FindPlayerStart_Implementation_Internal(base.NativePtr, (Player != null) ? Player.NativePtr : IntPtr.Zero, fstring));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x060097EF RID: 38895 RVA: 0x000D89AF File Offset: 0x000D6BAF
		public virtual AActor ChoosePlayerStart(AController Player)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(AGameModeBase.__ChoosePlayerStart_Internal(base.NativePtr, (Player != null) ? Player.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060097F0 RID: 38896 RVA: 0x000D89D1 File Offset: 0x000D6BD1
		protected virtual AActor ChoosePlayerStart_Implementation(AController Player)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(AGameModeBase.__ChoosePlayerStart_Implementation_Internal(base.NativePtr, (Player != null) ? Player.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060097F1 RID: 38897 RVA: 0x000D89F3 File Offset: 0x000D6BF3
		public void ChangePlayerController([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<APlayerController> NewPlayerControllerClass)
		{
			AGameModeBase.__ChangePlayerController_Internal(base.NativePtr, NewPlayerControllerClass._NativePtr);
		}

		// Token: 0x060097F2 RID: 38898 RVA: 0x000D8A08 File Offset: 0x000D6C08
		[NullableContext(1)]
		public unsafe void ChangeName([Nullable(2)] AController Controller, string NewName, bool bNameChange)
		{
			FString fstring = FString.AllocTemp(NewName);
			AGameModeBase.__ChangeName_Internal(base.NativePtr, (Controller != null) ? Controller.NativePtr : IntPtr.Zero, fstring, bNameChange);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060097F3 RID: 38899 RVA: 0x000D8A43 File Offset: 0x000D6C43
		public virtual bool CanSpectate(APlayerController Viewer, APlayerState ViewTarget)
		{
			return AGameModeBase.__CanSpectate_Internal(base.NativePtr, (Viewer != null) ? Viewer.NativePtr : IntPtr.Zero, (ViewTarget != null) ? ViewTarget.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060097F4 RID: 38900 RVA: 0x000D8A70 File Offset: 0x000D6C70
		protected virtual bool CanSpectate_Implementation(APlayerController Viewer, APlayerState ViewTarget)
		{
			return AGameModeBase.__CanSpectate_Implementation_Internal(base.NativePtr, (Viewer != null) ? Viewer.NativePtr : IntPtr.Zero, (ViewTarget != null) ? ViewTarget.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060097F5 RID: 38901
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartPlay_Internal(IntPtr @this);

		// Token: 0x060097F6 RID: 38902
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnDefaultPawnFor_Internal(IntPtr @this, IntPtr NewPlayer, IntPtr StartSpot);

		// Token: 0x060097F7 RID: 38903
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnDefaultPawnFor_Implementation_Internal(IntPtr @this, IntPtr NewPlayer, IntPtr StartSpot);

		// Token: 0x060097F8 RID: 38904
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnDefaultPawnAtTransform_Internal(IntPtr @this, IntPtr NewPlayer, in FTransform SpawnTransform);

		// Token: 0x060097F9 RID: 38905
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnDefaultPawnAtTransform_Implementation_Internal(IntPtr @this, IntPtr NewPlayer, in FTransform SpawnTransform);

		// Token: 0x060097FA RID: 38906
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ShouldReset_Internal(IntPtr @this, IntPtr ActorToReset);

		// Token: 0x060097FB RID: 38907
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ShouldReset_Implementation_Internal(IntPtr @this, IntPtr ActorToReset);

		// Token: 0x060097FC RID: 38908
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReturnToMainMenuHost_Internal(IntPtr @this);

		// Token: 0x060097FD RID: 38909
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RestartPlayerAtTransform_Internal(IntPtr @this, IntPtr NewPlayer, in FTransform SpawnTransform);

		// Token: 0x060097FE RID: 38910
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RestartPlayerAtPlayerStart_Internal(IntPtr @this, IntPtr NewPlayer, IntPtr StartSpot);

		// Token: 0x060097FF RID: 38911
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RestartPlayer_Internal(IntPtr @this, IntPtr NewPlayer);

		// Token: 0x06009800 RID: 38912
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetLevel_Internal(IntPtr @this);

		// Token: 0x06009801 RID: 38913
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __PlayerCanRestart_Internal(IntPtr @this, IntPtr Player);

		// Token: 0x06009802 RID: 38914
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __PlayerCanRestart_Implementation_Internal(IntPtr @this, IntPtr Player);

		// Token: 0x06009803 RID: 38915
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __MustSpectate_Internal(IntPtr @this, IntPtr NewPlayerController);

		// Token: 0x06009804 RID: 38916
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __MustSpectate_Implementation_Internal(IntPtr @this, IntPtr NewPlayerController);

		// Token: 0x06009805 RID: 38917
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_PostLogin_Internal(IntPtr @this, IntPtr NewPlayer);

		// Token: 0x06009806 RID: 38918
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_OnSwapPlayerControllers_Internal(IntPtr @this, IntPtr OldPC, IntPtr NewPC);

		// Token: 0x06009807 RID: 38919
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_OnRestartPlayer_Internal(IntPtr @this, IntPtr NewPlayer);

		// Token: 0x06009808 RID: 38920
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_OnLogout_Internal(IntPtr @this, IntPtr ExitingController);

		// Token: 0x06009809 RID: 38921
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_OnChangeName_Internal(IntPtr @this, IntPtr Other, in FString NewName, bool bNameChange);

		// Token: 0x0600980A RID: 38922
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __K2_FindPlayerStart_Internal(IntPtr @this, IntPtr Player, in FString IncomingName);

		// Token: 0x0600980B RID: 38923
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitStartSpot_Internal(IntPtr @this, IntPtr StartSpot, IntPtr NewPlayer);

		// Token: 0x0600980C RID: 38924
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitStartSpot_Implementation_Internal(IntPtr @this, IntPtr StartSpot, IntPtr NewPlayer);

		// Token: 0x0600980D RID: 38925
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitializeHUDForPlayer_Internal(IntPtr @this, IntPtr NewPlayer);

		// Token: 0x0600980E RID: 38926
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitializeHUDForPlayer_Implementation_Internal(IntPtr @this, IntPtr NewPlayer);

		// Token: 0x0600980F RID: 38927
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasMatchStarted_Internal(IntPtr @this);

		// Token: 0x06009810 RID: 38928
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasMatchEnded_Internal(IntPtr @this);

		// Token: 0x06009811 RID: 38929
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HandleStartingNewPlayer_Internal(IntPtr @this, IntPtr NewPlayer);

		// Token: 0x06009812 RID: 38930
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HandleStartingNewPlayer_Implementation_Internal(IntPtr @this, IntPtr NewPlayer);

		// Token: 0x06009813 RID: 38931
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumSpectators_Internal(IntPtr @this);

		// Token: 0x06009814 RID: 38932
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumPlayers_Internal(IntPtr @this);

		// Token: 0x06009815 RID: 38933
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDefaultPawnClassForController_Internal(IntPtr @this, IntPtr InController);

		// Token: 0x06009816 RID: 38934
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDefaultPawnClassForController_Implementation_Internal(IntPtr @this, IntPtr InController);

		// Token: 0x06009817 RID: 38935
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindPlayerStart_Internal(IntPtr @this, IntPtr Player, in FString IncomingName);

		// Token: 0x06009818 RID: 38936
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindPlayerStart_Implementation_Internal(IntPtr @this, IntPtr Player, in FString IncomingName);

		// Token: 0x06009819 RID: 38937
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __ChoosePlayerStart_Internal(IntPtr @this, IntPtr Player);

		// Token: 0x0600981A RID: 38938
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __ChoosePlayerStart_Implementation_Internal(IntPtr @this, IntPtr Player);

		// Token: 0x0600981B RID: 38939
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ChangePlayerController_Internal(IntPtr @this, IntPtr NewPlayerControllerClass);

		// Token: 0x0600981C RID: 38940
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ChangeName_Internal(IntPtr @this, IntPtr Controller, in FString NewName, bool bNameChange);

		// Token: 0x0600981D RID: 38941
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CanSpectate_Internal(IntPtr @this, IntPtr Viewer, IntPtr ViewTarget);

		// Token: 0x0600981E RID: 38942
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CanSpectate_Implementation_Internal(IntPtr @this, IntPtr Viewer, IntPtr ViewTarget);

		// Token: 0x0600981F RID: 38943 RVA: 0x000D8A9D File Offset: 0x000D6C9D
		static AGameModeBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.GameModeBase");
		}

		// Token: 0x06009820 RID: 38944 RVA: 0x000D8AAB File Offset: 0x000D6CAB
		protected AGameModeBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040054E8 RID: 21736
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.GameModeBase";

		// Token: 0x040054E9 RID: 21737
		private static IntPtr _ClassPtr;

		// Token: 0x040054EA RID: 21738
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040054EB RID: 21739
		internal static int __PropertyOffset_OptionsString;

		// Token: 0x040054EC RID: 21740
		internal static int __PropertyOffset_GameSessionClass;

		// Token: 0x040054ED RID: 21741
		internal static int __PropertyOffset_GameStateClass;

		// Token: 0x040054EE RID: 21742
		internal static int __PropertyOffset_PlayerControllerClass;

		// Token: 0x040054EF RID: 21743
		internal static int __PropertyOffset_PlayerStateClass;

		// Token: 0x040054F0 RID: 21744
		internal static int __PropertyOffset_HUDClass;

		// Token: 0x040054F1 RID: 21745
		internal static int __PropertyOffset_DefaultPawnClass;

		// Token: 0x040054F2 RID: 21746
		internal static int __PropertyOffset_SpectatorClass;

		// Token: 0x040054F3 RID: 21747
		internal static int __PropertyOffset_ReplaySpectatorPlayerControllerClass;

		// Token: 0x040054F4 RID: 21748
		internal static int __PropertyOffset_ServerStatReplicatorClass;

		// Token: 0x040054F5 RID: 21749
		internal static int __PropertyOffset_GameSession;

		// Token: 0x040054F6 RID: 21750
		internal static int __PropertyOffset_GameState;

		// Token: 0x040054F7 RID: 21751
		internal static int __PropertyOffset_ServerStatReplicator;

		// Token: 0x040054F8 RID: 21752
		internal static int __PropertyOffset_DefaultPlayerName;

		// Token: 0x040054F9 RID: 21753
		private FText _DefaultPlayerName;

		// Token: 0x040054FA RID: 21754
		internal static int __PropertyOffset_bUseSeamlessTravel;

		// Token: 0x040054FB RID: 21755
		internal static byte __PropertyMask_bUseSeamlessTravel;

		// Token: 0x040054FC RID: 21756
		internal static int __PropertyOffset_bStartPlayersAsSpectators;

		// Token: 0x040054FD RID: 21757
		internal static byte __PropertyMask_bStartPlayersAsSpectators;

		// Token: 0x040054FE RID: 21758
		internal static int __PropertyOffset_bPauseable;

		// Token: 0x040054FF RID: 21759
		internal static byte __PropertyMask_bPauseable;

		// Token: 0x02002D01 RID: 11521
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SpawnDefaultPawnFor_FunctionParams
		{
			// Token: 0x040166BB RID: 91835
			[FieldOffset(0)]
			public IntPtr NewPlayer;

			// Token: 0x040166BC RID: 91836
			[FieldOffset(8)]
			public IntPtr StartSpot;

			// Token: 0x040166BD RID: 91837
			[FieldOffset(16)]
			public IntPtr __Result;
		}

		// Token: 0x02002D02 RID: 11522
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SpawnDefaultPawnAtTransform_FunctionParams
		{
			// Token: 0x040166BE RID: 91838
			[FieldOffset(0)]
			public IntPtr NewPlayer;

			// Token: 0x040166BF RID: 91839
			[FieldOffset(16)]
			public FTransform SpawnTransform;

			// Token: 0x040166C0 RID: 91840
			[FieldOffset(64)]
			public IntPtr __Result;
		}

		// Token: 0x02002D03 RID: 11523
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ShouldReset_FunctionParams
		{
			// Token: 0x040166C1 RID: 91841
			[FieldOffset(0)]
			public IntPtr ActorToReset;

			// Token: 0x040166C2 RID: 91842
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x02002D04 RID: 11524
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __PlayerCanRestart_FunctionParams
		{
			// Token: 0x040166C3 RID: 91843
			[FieldOffset(0)]
			public IntPtr Player;

			// Token: 0x040166C4 RID: 91844
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x02002D05 RID: 11525
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __MustSpectate_FunctionParams
		{
			// Token: 0x040166C5 RID: 91845
			[FieldOffset(0)]
			public IntPtr NewPlayerController;

			// Token: 0x040166C6 RID: 91846
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x02002D06 RID: 11526
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __K2_PostLogin_FunctionParams
		{
			// Token: 0x040166C7 RID: 91847
			[FieldOffset(0)]
			public IntPtr NewPlayer;
		}

		// Token: 0x02002D07 RID: 11527
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __K2_OnSwapPlayerControllers_FunctionParams
		{
			// Token: 0x040166C8 RID: 91848
			[FieldOffset(0)]
			public IntPtr OldPC;

			// Token: 0x040166C9 RID: 91849
			[FieldOffset(8)]
			public IntPtr NewPC;
		}

		// Token: 0x02002D08 RID: 11528
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __K2_OnRestartPlayer_FunctionParams
		{
			// Token: 0x040166CA RID: 91850
			[FieldOffset(0)]
			public IntPtr NewPlayer;
		}

		// Token: 0x02002D09 RID: 11529
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __K2_OnLogout_FunctionParams
		{
			// Token: 0x040166CB RID: 91851
			[FieldOffset(0)]
			public IntPtr ExitingController;
		}

		// Token: 0x02002D0A RID: 11530
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __K2_OnChangeName_FunctionParams
		{
			// Token: 0x040166CC RID: 91852
			[FieldOffset(0)]
			public IntPtr Other;

			// Token: 0x040166CD RID: 91853
			[FieldOffset(8)]
			public FString NewName;

			// Token: 0x040166CE RID: 91854
			[FieldOffset(24)]
			public bool bNameChange;
		}

		// Token: 0x02002D0B RID: 11531
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InitStartSpot_FunctionParams
		{
			// Token: 0x040166CF RID: 91855
			[FieldOffset(0)]
			public IntPtr StartSpot;

			// Token: 0x040166D0 RID: 91856
			[FieldOffset(8)]
			public IntPtr NewPlayer;
		}

		// Token: 0x02002D0C RID: 11532
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __InitializeHUDForPlayer_FunctionParams
		{
			// Token: 0x040166D1 RID: 91857
			[FieldOffset(0)]
			public IntPtr NewPlayer;
		}

		// Token: 0x02002D0D RID: 11533
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __HandleStartingNewPlayer_FunctionParams
		{
			// Token: 0x040166D2 RID: 91858
			[FieldOffset(0)]
			public IntPtr NewPlayer;
		}

		// Token: 0x02002D0E RID: 11534
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetDefaultPawnClassForController_FunctionParams
		{
			// Token: 0x040166D3 RID: 91859
			[FieldOffset(0)]
			public IntPtr InController;

			// Token: 0x040166D4 RID: 91860
			[FieldOffset(8)]
			public UClassStackOnlyPtr __Result;
		}

		// Token: 0x02002D0F RID: 11535
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FindPlayerStart_FunctionParams
		{
			// Token: 0x040166D5 RID: 91861
			[FieldOffset(0)]
			public IntPtr Player;

			// Token: 0x040166D6 RID: 91862
			[FieldOffset(8)]
			public FString IncomingName;

			// Token: 0x040166D7 RID: 91863
			[FieldOffset(24)]
			public IntPtr __Result;
		}

		// Token: 0x02002D10 RID: 11536
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ChoosePlayerStart_FunctionParams
		{
			// Token: 0x040166D8 RID: 91864
			[FieldOffset(0)]
			public IntPtr Player;

			// Token: 0x040166D9 RID: 91865
			[FieldOffset(8)]
			public IntPtr __Result;
		}

		// Token: 0x02002D11 RID: 11537
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __CanSpectate_FunctionParams
		{
			// Token: 0x040166DA RID: 91866
			[FieldOffset(0)]
			public IntPtr Viewer;

			// Token: 0x040166DB RID: 91867
			[FieldOffset(8)]
			public IntPtr ViewTarget;

			// Token: 0x040166DC RID: 91868
			[FieldOffset(16)]
			public bool __Result;
		}
	}
}
