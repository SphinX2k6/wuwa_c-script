using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000215 RID: 533
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.GameModeBase")]
	[UnrealStructLayout(1208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1208)]
	public class AGameModeBase : AInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002227 RID: 8743 RVA: 0x00031F59 File Offset: 0x00030159
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AGameModeBase._ClassPtr;
		}

		// Token: 0x06002228 RID: 8744 RVA: 0x00031F68 File Offset: 0x00030168
		public AGameModeBase() : this(BuiltinUtils.AllocNativeUObject(AGameModeBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002229 RID: 8745 RVA: 0x00031F90 File Offset: 0x00030190
		[NullableContext(1)]
		public AGameModeBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AGameModeBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x0600222A RID: 8746 RVA: 0x00031FC3 File Offset: 0x000301C3
		// (set) Token: 0x0600222B RID: 8747 RVA: 0x00031FD7 File Offset: 0x000301D7
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

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x0600222C RID: 8748 RVA: 0x00031FEC File Offset: 0x000301EC
		// (set) Token: 0x0600222D RID: 8749 RVA: 0x00032000 File Offset: 0x00030200
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

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x0600222E RID: 8750 RVA: 0x00032015 File Offset: 0x00030215
		// (set) Token: 0x0600222F RID: 8751 RVA: 0x00032029 File Offset: 0x00030229
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

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06002230 RID: 8752 RVA: 0x0003203E File Offset: 0x0003023E
		// (set) Token: 0x06002231 RID: 8753 RVA: 0x00032052 File Offset: 0x00030252
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

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06002232 RID: 8754 RVA: 0x00032068 File Offset: 0x00030268
		// (set) Token: 0x06002233 RID: 8755 RVA: 0x000320A1 File Offset: 0x000302A1
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

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06002234 RID: 8756 RVA: 0x000320BC File Offset: 0x000302BC
		// (set) Token: 0x06002235 RID: 8757 RVA: 0x000320D5 File Offset: 0x000302D5
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

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06002236 RID: 8758 RVA: 0x00032105 File Offset: 0x00030305
		// (set) Token: 0x06002237 RID: 8759 RVA: 0x0003211E File Offset: 0x0003031E
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

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06002238 RID: 8760 RVA: 0x0003214E File Offset: 0x0003034E
		// (set) Token: 0x06002239 RID: 8761 RVA: 0x00032167 File Offset: 0x00030367
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

		// Token: 0x0600223A RID: 8762 RVA: 0x00032197 File Offset: 0x00030397
		public void StartPlay()
		{
			AGameModeBase.__StartPlay_Internal(base.NativePtr);
		}

		// Token: 0x0600223B RID: 8763 RVA: 0x000321A4 File Offset: 0x000303A4
		public virtual APawn SpawnDefaultPawnFor(AController NewPlayer, AActor StartSpot)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(AGameModeBase.__SpawnDefaultPawnFor_Internal(base.NativePtr, (NewPlayer != null) ? NewPlayer.NativePtr : IntPtr.Zero, (StartSpot != null) ? StartSpot.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0600223C RID: 8764 RVA: 0x000321D6 File Offset: 0x000303D6
		protected virtual APawn SpawnDefaultPawnFor_Implementation(AController NewPlayer, AActor StartSpot)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(AGameModeBase.__SpawnDefaultPawnFor_Implementation_Internal(base.NativePtr, (NewPlayer != null) ? NewPlayer.NativePtr : IntPtr.Zero, (StartSpot != null) ? StartSpot.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0600223D RID: 8765 RVA: 0x00032208 File Offset: 0x00030408
		public unsafe virtual APawn SpawnDefaultPawnAtTransform(AController NewPlayer, in FTransform SpawnTransform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = SpawnTransform;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(AGameModeBase.__SpawnDefaultPawnAtTransform_Internal(base.NativePtr, (NewPlayer != null) ? NewPlayer.NativePtr : IntPtr.Zero, ptr));
		}

		// Token: 0x0600223E RID: 8766 RVA: 0x00032254 File Offset: 0x00030454
		protected unsafe virtual APawn SpawnDefaultPawnAtTransform_Implementation(AController NewPlayer, in FTransform SpawnTransform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = SpawnTransform;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(AGameModeBase.__SpawnDefaultPawnAtTransform_Implementation_Internal(base.NativePtr, (NewPlayer != null) ? NewPlayer.NativePtr : IntPtr.Zero, ptr));
		}

		// Token: 0x0600223F RID: 8767 RVA: 0x0003229E File Offset: 0x0003049E
		public virtual bool ShouldReset(AActor ActorToReset)
		{
			return AGameModeBase.__ShouldReset_Internal(base.NativePtr, (ActorToReset != null) ? ActorToReset.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06002240 RID: 8768 RVA: 0x000322BB File Offset: 0x000304BB
		protected virtual bool ShouldReset_Implementation(AActor ActorToReset)
		{
			return AGameModeBase.__ShouldReset_Implementation_Internal(base.NativePtr, (ActorToReset != null) ? ActorToReset.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06002241 RID: 8769 RVA: 0x000322D8 File Offset: 0x000304D8
		public void ReturnToMainMenuHost()
		{
			AGameModeBase.__ReturnToMainMenuHost_Internal(base.NativePtr);
		}

		// Token: 0x06002242 RID: 8770 RVA: 0x000322E8 File Offset: 0x000304E8
		public unsafe void RestartPlayerAtTransform(AController NewPlayer, in FTransform SpawnTransform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = SpawnTransform;
			AGameModeBase.__RestartPlayerAtTransform_Internal(base.NativePtr, (NewPlayer != null) ? NewPlayer.NativePtr : IntPtr.Zero, ptr);
		}

		// Token: 0x06002243 RID: 8771 RVA: 0x0003232D File Offset: 0x0003052D
		public void RestartPlayerAtPlayerStart(AController NewPlayer, AActor StartSpot)
		{
			AGameModeBase.__RestartPlayerAtPlayerStart_Internal(base.NativePtr, (NewPlayer != null) ? NewPlayer.NativePtr : IntPtr.Zero, (StartSpot != null) ? StartSpot.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06002244 RID: 8772 RVA: 0x0003235A File Offset: 0x0003055A
		public void RestartPlayer(AController NewPlayer)
		{
			AGameModeBase.__RestartPlayer_Internal(base.NativePtr, (NewPlayer != null) ? NewPlayer.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06002245 RID: 8773 RVA: 0x00032377 File Offset: 0x00030577
		public void ResetLevel()
		{
			AGameModeBase.__ResetLevel_Internal(base.NativePtr);
		}

		// Token: 0x06002246 RID: 8774 RVA: 0x00032384 File Offset: 0x00030584
		public virtual bool PlayerCanRestart(APlayerController Player)
		{
			return AGameModeBase.__PlayerCanRestart_Internal(base.NativePtr, (Player != null) ? Player.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06002247 RID: 8775 RVA: 0x000323A1 File Offset: 0x000305A1
		protected virtual bool PlayerCanRestart_Implementation(APlayerController Player)
		{
			return AGameModeBase.__PlayerCanRestart_Implementation_Internal(base.NativePtr, (Player != null) ? Player.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06002248 RID: 8776 RVA: 0x000323BE File Offset: 0x000305BE
		public virtual bool MustSpectate(APlayerController NewPlayerController)
		{
			return AGameModeBase.__MustSpectate_Internal(base.NativePtr, (NewPlayerController != null) ? NewPlayerController.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06002249 RID: 8777 RVA: 0x000323DB File Offset: 0x000305DB
		protected virtual bool MustSpectate_Implementation(APlayerController NewPlayerController)
		{
			return AGameModeBase.__MustSpectate_Implementation_Internal(base.NativePtr, (NewPlayerController != null) ? NewPlayerController.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600224A RID: 8778 RVA: 0x000323F8 File Offset: 0x000305F8
		public virtual void K2_PostLogin(APlayerController NewPlayer)
		{
			AGameModeBase.__K2_PostLogin_Internal(base.NativePtr, (NewPlayer != null) ? NewPlayer.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600224B RID: 8779 RVA: 0x00032415 File Offset: 0x00030615
		public virtual void K2_OnSwapPlayerControllers(APlayerController OldPC, APlayerController NewPC)
		{
			AGameModeBase.__K2_OnSwapPlayerControllers_Internal(base.NativePtr, (OldPC != null) ? OldPC.NativePtr : IntPtr.Zero, (NewPC != null) ? NewPC.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600224C RID: 8780 RVA: 0x00032442 File Offset: 0x00030642
		public virtual void K2_OnRestartPlayer(AController NewPlayer)
		{
			AGameModeBase.__K2_OnRestartPlayer_Internal(base.NativePtr, (NewPlayer != null) ? NewPlayer.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600224D RID: 8781 RVA: 0x0003245F File Offset: 0x0003065F
		public virtual void K2_OnLogout(AController ExitingController)
		{
			AGameModeBase.__K2_OnLogout_Internal(base.NativePtr, (ExitingController != null) ? ExitingController.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600224E RID: 8782 RVA: 0x0003247C File Offset: 0x0003067C
		[NullableContext(1)]
		public unsafe virtual void K2_OnChangeName([Nullable(2)] AController Other, string NewName, bool bNameChange)
		{
			FString fstring = FString.AllocTemp(NewName);
			AGameModeBase.__K2_OnChangeName_Internal(base.NativePtr, (Other != null) ? Other.NativePtr : IntPtr.Zero, fstring, bNameChange);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600224F RID: 8783 RVA: 0x000324B8 File Offset: 0x000306B8
		public unsafe AActor K2_FindPlayerStart(AController Player, [Nullable(1)] string IncomingName = "")
		{
			FString fstring = FString.AllocTemp(IncomingName);
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(AGameModeBase.__K2_FindPlayerStart_Internal(base.NativePtr, (Player != null) ? Player.NativePtr : IntPtr.Zero, fstring));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x06002250 RID: 8784 RVA: 0x000324F7 File Offset: 0x000306F7
		public virtual void InitStartSpot(AActor StartSpot, AController NewPlayer)
		{
			AGameModeBase.__InitStartSpot_Internal(base.NativePtr, (StartSpot != null) ? StartSpot.NativePtr : IntPtr.Zero, (NewPlayer != null) ? NewPlayer.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06002251 RID: 8785 RVA: 0x00032524 File Offset: 0x00030724
		protected virtual void InitStartSpot_Implementation(AActor StartSpot, AController NewPlayer)
		{
			AGameModeBase.__InitStartSpot_Implementation_Internal(base.NativePtr, (StartSpot != null) ? StartSpot.NativePtr : IntPtr.Zero, (NewPlayer != null) ? NewPlayer.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06002252 RID: 8786 RVA: 0x00032551 File Offset: 0x00030751
		public virtual void InitializeHUDForPlayer(APlayerController NewPlayer)
		{
			AGameModeBase.__InitializeHUDForPlayer_Internal(base.NativePtr, (NewPlayer != null) ? NewPlayer.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06002253 RID: 8787 RVA: 0x0003256E File Offset: 0x0003076E
		protected virtual void InitializeHUDForPlayer_Implementation(APlayerController NewPlayer)
		{
			AGameModeBase.__InitializeHUDForPlayer_Implementation_Internal(base.NativePtr, (NewPlayer != null) ? NewPlayer.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06002254 RID: 8788 RVA: 0x0003258B File Offset: 0x0003078B
		public bool HasMatchStarted()
		{
			return AGameModeBase.__HasMatchStarted_Internal(base.NativePtr);
		}

		// Token: 0x06002255 RID: 8789 RVA: 0x00032598 File Offset: 0x00030798
		public bool HasMatchEnded()
		{
			return AGameModeBase.__HasMatchEnded_Internal(base.NativePtr);
		}

		// Token: 0x06002256 RID: 8790 RVA: 0x000325A5 File Offset: 0x000307A5
		public virtual void HandleStartingNewPlayer(APlayerController NewPlayer)
		{
			AGameModeBase.__HandleStartingNewPlayer_Internal(base.NativePtr, (NewPlayer != null) ? NewPlayer.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06002257 RID: 8791 RVA: 0x000325C2 File Offset: 0x000307C2
		protected virtual void HandleStartingNewPlayer_Implementation(APlayerController NewPlayer)
		{
			AGameModeBase.__HandleStartingNewPlayer_Implementation_Internal(base.NativePtr, (NewPlayer != null) ? NewPlayer.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06002258 RID: 8792 RVA: 0x000325DF File Offset: 0x000307DF
		public int GetNumSpectators()
		{
			return AGameModeBase.__GetNumSpectators_Internal(base.NativePtr);
		}

		// Token: 0x06002259 RID: 8793 RVA: 0x000325EC File Offset: 0x000307EC
		public int GetNumPlayers()
		{
			return AGameModeBase.__GetNumPlayers_Internal(base.NativePtr);
		}

		// Token: 0x0600225A RID: 8794 RVA: 0x000325F9 File Offset: 0x000307F9
		public virtual UClassStackOnlyPtr GetDefaultPawnClassForController(AController InController)
		{
			return AGameModeBase.__GetDefaultPawnClassForController_Internal(base.NativePtr, (InController != null) ? InController.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600225B RID: 8795 RVA: 0x0003261B File Offset: 0x0003081B
		protected virtual UClassStackOnlyPtr GetDefaultPawnClassForController_Implementation(AController InController)
		{
			return AGameModeBase.__GetDefaultPawnClassForController_Implementation_Internal(base.NativePtr, (InController != null) ? InController.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600225C RID: 8796 RVA: 0x00032640 File Offset: 0x00030840
		public unsafe virtual AActor FindPlayerStart(AController Player, [Nullable(1)] string IncomingName)
		{
			FString fstring = FString.AllocTemp(IncomingName);
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(AGameModeBase.__FindPlayerStart_Internal(base.NativePtr, (Player != null) ? Player.NativePtr : IntPtr.Zero, fstring));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x0600225D RID: 8797 RVA: 0x00032680 File Offset: 0x00030880
		protected unsafe virtual AActor FindPlayerStart_Implementation(AController Player, [Nullable(1)] string IncomingName)
		{
			FString fstring = FString.AllocTemp(IncomingName);
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(AGameModeBase.__FindPlayerStart_Implementation_Internal(base.NativePtr, (Player != null) ? Player.NativePtr : IntPtr.Zero, fstring));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x0600225E RID: 8798 RVA: 0x000326BF File Offset: 0x000308BF
		public virtual AActor ChoosePlayerStart(AController Player)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(AGameModeBase.__ChoosePlayerStart_Internal(base.NativePtr, (Player != null) ? Player.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0600225F RID: 8799 RVA: 0x000326E1 File Offset: 0x000308E1
		protected virtual AActor ChoosePlayerStart_Implementation(AController Player)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(AGameModeBase.__ChoosePlayerStart_Implementation_Internal(base.NativePtr, (Player != null) ? Player.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06002260 RID: 8800 RVA: 0x00032703 File Offset: 0x00030903
		public void ChangePlayerController([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<APlayerController> NewPlayerControllerClass)
		{
			AGameModeBase.__ChangePlayerController_Internal(base.NativePtr, NewPlayerControllerClass._NativePtr);
		}

		// Token: 0x06002261 RID: 8801 RVA: 0x00032718 File Offset: 0x00030918
		[NullableContext(1)]
		public unsafe void ChangeName([Nullable(2)] AController Controller, string NewName, bool bNameChange)
		{
			FString fstring = FString.AllocTemp(NewName);
			AGameModeBase.__ChangeName_Internal(base.NativePtr, (Controller != null) ? Controller.NativePtr : IntPtr.Zero, fstring, bNameChange);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06002262 RID: 8802
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartPlay_Internal(IntPtr @this);

		// Token: 0x06002263 RID: 8803
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnDefaultPawnFor_Internal(IntPtr @this, IntPtr NewPlayer, IntPtr StartSpot);

		// Token: 0x06002264 RID: 8804
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnDefaultPawnFor_Implementation_Internal(IntPtr @this, IntPtr NewPlayer, IntPtr StartSpot);

		// Token: 0x06002265 RID: 8805
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnDefaultPawnAtTransform_Internal(IntPtr @this, IntPtr NewPlayer, in FTransform SpawnTransform);

		// Token: 0x06002266 RID: 8806
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnDefaultPawnAtTransform_Implementation_Internal(IntPtr @this, IntPtr NewPlayer, in FTransform SpawnTransform);

		// Token: 0x06002267 RID: 8807
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ShouldReset_Internal(IntPtr @this, IntPtr ActorToReset);

		// Token: 0x06002268 RID: 8808
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ShouldReset_Implementation_Internal(IntPtr @this, IntPtr ActorToReset);

		// Token: 0x06002269 RID: 8809
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReturnToMainMenuHost_Internal(IntPtr @this);

		// Token: 0x0600226A RID: 8810
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RestartPlayerAtTransform_Internal(IntPtr @this, IntPtr NewPlayer, in FTransform SpawnTransform);

		// Token: 0x0600226B RID: 8811
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RestartPlayerAtPlayerStart_Internal(IntPtr @this, IntPtr NewPlayer, IntPtr StartSpot);

		// Token: 0x0600226C RID: 8812
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RestartPlayer_Internal(IntPtr @this, IntPtr NewPlayer);

		// Token: 0x0600226D RID: 8813
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetLevel_Internal(IntPtr @this);

		// Token: 0x0600226E RID: 8814
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __PlayerCanRestart_Internal(IntPtr @this, IntPtr Player);

		// Token: 0x0600226F RID: 8815
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __PlayerCanRestart_Implementation_Internal(IntPtr @this, IntPtr Player);

		// Token: 0x06002270 RID: 8816
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __MustSpectate_Internal(IntPtr @this, IntPtr NewPlayerController);

		// Token: 0x06002271 RID: 8817
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __MustSpectate_Implementation_Internal(IntPtr @this, IntPtr NewPlayerController);

		// Token: 0x06002272 RID: 8818
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_PostLogin_Internal(IntPtr @this, IntPtr NewPlayer);

		// Token: 0x06002273 RID: 8819
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_OnSwapPlayerControllers_Internal(IntPtr @this, IntPtr OldPC, IntPtr NewPC);

		// Token: 0x06002274 RID: 8820
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_OnRestartPlayer_Internal(IntPtr @this, IntPtr NewPlayer);

		// Token: 0x06002275 RID: 8821
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_OnLogout_Internal(IntPtr @this, IntPtr ExitingController);

		// Token: 0x06002276 RID: 8822
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_OnChangeName_Internal(IntPtr @this, IntPtr Other, in FString NewName, bool bNameChange);

		// Token: 0x06002277 RID: 8823
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __K2_FindPlayerStart_Internal(IntPtr @this, IntPtr Player, in FString IncomingName);

		// Token: 0x06002278 RID: 8824
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitStartSpot_Internal(IntPtr @this, IntPtr StartSpot, IntPtr NewPlayer);

		// Token: 0x06002279 RID: 8825
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitStartSpot_Implementation_Internal(IntPtr @this, IntPtr StartSpot, IntPtr NewPlayer);

		// Token: 0x0600227A RID: 8826
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitializeHUDForPlayer_Internal(IntPtr @this, IntPtr NewPlayer);

		// Token: 0x0600227B RID: 8827
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitializeHUDForPlayer_Implementation_Internal(IntPtr @this, IntPtr NewPlayer);

		// Token: 0x0600227C RID: 8828
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasMatchStarted_Internal(IntPtr @this);

		// Token: 0x0600227D RID: 8829
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasMatchEnded_Internal(IntPtr @this);

		// Token: 0x0600227E RID: 8830
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HandleStartingNewPlayer_Internal(IntPtr @this, IntPtr NewPlayer);

		// Token: 0x0600227F RID: 8831
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HandleStartingNewPlayer_Implementation_Internal(IntPtr @this, IntPtr NewPlayer);

		// Token: 0x06002280 RID: 8832
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumSpectators_Internal(IntPtr @this);

		// Token: 0x06002281 RID: 8833
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumPlayers_Internal(IntPtr @this);

		// Token: 0x06002282 RID: 8834
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDefaultPawnClassForController_Internal(IntPtr @this, IntPtr InController);

		// Token: 0x06002283 RID: 8835
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDefaultPawnClassForController_Implementation_Internal(IntPtr @this, IntPtr InController);

		// Token: 0x06002284 RID: 8836
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindPlayerStart_Internal(IntPtr @this, IntPtr Player, in FString IncomingName);

		// Token: 0x06002285 RID: 8837
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindPlayerStart_Implementation_Internal(IntPtr @this, IntPtr Player, in FString IncomingName);

		// Token: 0x06002286 RID: 8838
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __ChoosePlayerStart_Internal(IntPtr @this, IntPtr Player);

		// Token: 0x06002287 RID: 8839
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __ChoosePlayerStart_Implementation_Internal(IntPtr @this, IntPtr Player);

		// Token: 0x06002288 RID: 8840
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ChangePlayerController_Internal(IntPtr @this, IntPtr NewPlayerControllerClass);

		// Token: 0x06002289 RID: 8841
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ChangeName_Internal(IntPtr @this, IntPtr Controller, in FString NewName, bool bNameChange);

		// Token: 0x0600228A RID: 8842 RVA: 0x00032753 File Offset: 0x00030953
		static AGameModeBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.GameModeBase");
		}

		// Token: 0x0600228B RID: 8843 RVA: 0x00032761 File Offset: 0x00030961
		protected AGameModeBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000D5E RID: 3422
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.GameModeBase";

		// Token: 0x04000D5F RID: 3423
		private static IntPtr _ClassPtr;

		// Token: 0x04000D60 RID: 3424
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000D61 RID: 3425
		internal static int __PropertyOffset_OptionsString;

		// Token: 0x04000D62 RID: 3426
		internal static int __PropertyOffset_PlayerControllerClass;

		// Token: 0x04000D63 RID: 3427
		internal static int __PropertyOffset_DefaultPawnClass;

		// Token: 0x04000D64 RID: 3428
		internal static int __PropertyOffset_ReplaySpectatorPlayerControllerClass;

		// Token: 0x04000D65 RID: 3429
		internal static int __PropertyOffset_DefaultPlayerName;

		// Token: 0x04000D66 RID: 3430
		private FText _DefaultPlayerName;

		// Token: 0x04000D67 RID: 3431
		internal static int __PropertyOffset_bUseSeamlessTravel;

		// Token: 0x04000D68 RID: 3432
		internal static byte __PropertyMask_bUseSeamlessTravel;

		// Token: 0x04000D69 RID: 3433
		internal static int __PropertyOffset_bStartPlayersAsSpectators;

		// Token: 0x04000D6A RID: 3434
		internal static byte __PropertyMask_bStartPlayersAsSpectators;

		// Token: 0x04000D6B RID: 3435
		internal static int __PropertyOffset_bPauseable;

		// Token: 0x04000D6C RID: 3436
		internal static byte __PropertyMask_bPauseable;

		// Token: 0x020009A0 RID: 2464
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SpawnDefaultPawnFor_FunctionParams
		{
			// Token: 0x0400590A RID: 22794
			[FieldOffset(0)]
			public IntPtr NewPlayer;

			// Token: 0x0400590B RID: 22795
			[FieldOffset(8)]
			public IntPtr StartSpot;

			// Token: 0x0400590C RID: 22796
			[FieldOffset(16)]
			public IntPtr __Result;
		}

		// Token: 0x020009A1 RID: 2465
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SpawnDefaultPawnAtTransform_FunctionParams
		{
			// Token: 0x0400590D RID: 22797
			[FieldOffset(0)]
			public IntPtr NewPlayer;

			// Token: 0x0400590E RID: 22798
			[FieldOffset(16)]
			public FTransform SpawnTransform;

			// Token: 0x0400590F RID: 22799
			[FieldOffset(64)]
			public IntPtr __Result;
		}

		// Token: 0x020009A2 RID: 2466
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ShouldReset_FunctionParams
		{
			// Token: 0x04005910 RID: 22800
			[FieldOffset(0)]
			public IntPtr ActorToReset;

			// Token: 0x04005911 RID: 22801
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x020009A3 RID: 2467
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __PlayerCanRestart_FunctionParams
		{
			// Token: 0x04005912 RID: 22802
			[FieldOffset(0)]
			public IntPtr Player;

			// Token: 0x04005913 RID: 22803
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x020009A4 RID: 2468
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __MustSpectate_FunctionParams
		{
			// Token: 0x04005914 RID: 22804
			[FieldOffset(0)]
			public IntPtr NewPlayerController;

			// Token: 0x04005915 RID: 22805
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x020009A5 RID: 2469
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __K2_PostLogin_FunctionParams
		{
			// Token: 0x04005916 RID: 22806
			[FieldOffset(0)]
			public IntPtr NewPlayer;
		}

		// Token: 0x020009A6 RID: 2470
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __K2_OnSwapPlayerControllers_FunctionParams
		{
			// Token: 0x04005917 RID: 22807
			[FieldOffset(0)]
			public IntPtr OldPC;

			// Token: 0x04005918 RID: 22808
			[FieldOffset(8)]
			public IntPtr NewPC;
		}

		// Token: 0x020009A7 RID: 2471
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __K2_OnRestartPlayer_FunctionParams
		{
			// Token: 0x04005919 RID: 22809
			[FieldOffset(0)]
			public IntPtr NewPlayer;
		}

		// Token: 0x020009A8 RID: 2472
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __K2_OnLogout_FunctionParams
		{
			// Token: 0x0400591A RID: 22810
			[FieldOffset(0)]
			public IntPtr ExitingController;
		}

		// Token: 0x020009A9 RID: 2473
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __K2_OnChangeName_FunctionParams
		{
			// Token: 0x0400591B RID: 22811
			[FieldOffset(0)]
			public IntPtr Other;

			// Token: 0x0400591C RID: 22812
			[FieldOffset(8)]
			public FString NewName;

			// Token: 0x0400591D RID: 22813
			[FieldOffset(24)]
			public bool bNameChange;
		}

		// Token: 0x020009AA RID: 2474
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InitStartSpot_FunctionParams
		{
			// Token: 0x0400591E RID: 22814
			[FieldOffset(0)]
			public IntPtr StartSpot;

			// Token: 0x0400591F RID: 22815
			[FieldOffset(8)]
			public IntPtr NewPlayer;
		}

		// Token: 0x020009AB RID: 2475
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __InitializeHUDForPlayer_FunctionParams
		{
			// Token: 0x04005920 RID: 22816
			[FieldOffset(0)]
			public IntPtr NewPlayer;
		}

		// Token: 0x020009AC RID: 2476
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __HandleStartingNewPlayer_FunctionParams
		{
			// Token: 0x04005921 RID: 22817
			[FieldOffset(0)]
			public IntPtr NewPlayer;
		}

		// Token: 0x020009AD RID: 2477
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetDefaultPawnClassForController_FunctionParams
		{
			// Token: 0x04005922 RID: 22818
			[FieldOffset(0)]
			public IntPtr InController;

			// Token: 0x04005923 RID: 22819
			[FieldOffset(8)]
			public UClassStackOnlyPtr __Result;
		}

		// Token: 0x020009AE RID: 2478
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FindPlayerStart_FunctionParams
		{
			// Token: 0x04005924 RID: 22820
			[FieldOffset(0)]
			public IntPtr Player;

			// Token: 0x04005925 RID: 22821
			[FieldOffset(8)]
			public FString IncomingName;

			// Token: 0x04005926 RID: 22822
			[FieldOffset(24)]
			public IntPtr __Result;
		}

		// Token: 0x020009AF RID: 2479
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ChoosePlayerStart_FunctionParams
		{
			// Token: 0x04005927 RID: 22823
			[FieldOffset(0)]
			public IntPtr Player;

			// Token: 0x04005928 RID: 22824
			[FieldOffset(8)]
			public IntPtr __Result;
		}
	}
}
