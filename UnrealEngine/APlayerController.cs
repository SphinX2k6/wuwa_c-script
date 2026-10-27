using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200100C RID: 4108
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PlayerController")]
	[UnrealStructLayout(2032, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2032)]
	public class APlayerController : AController, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600DEF5 RID: 57077 RVA: 0x001489AB File Offset: 0x00146BAB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return APlayerController._ClassPtr;
		}

		// Token: 0x0600DEF6 RID: 57078 RVA: 0x001489B8 File Offset: 0x00146BB8
		public APlayerController() : this(BuiltinUtils.AllocNativeUObject(APlayerController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600DEF7 RID: 57079 RVA: 0x001489E0 File Offset: 0x00146BE0
		[NullableContext(1)]
		public APlayerController(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(APlayerController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003487 RID: 13447
		// (get) Token: 0x0600DEF8 RID: 57080 RVA: 0x00148A13 File Offset: 0x00146C13
		// (set) Token: 0x0600DEF9 RID: 57081 RVA: 0x00148A27 File Offset: 0x00146C27
		public unsafe UPlayer Player
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPlayer>(base.NativePtr / (IntPtr)sizeof(void*) + APlayerController.__PropertyOffset_Player);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + APlayerController.__PropertyOffset_Player, value);
			}
		}

		// Token: 0x17003488 RID: 13448
		// (get) Token: 0x0600DEFA RID: 57082 RVA: 0x00148A3C File Offset: 0x00146C3C
		// (set) Token: 0x0600DEFB RID: 57083 RVA: 0x00148A50 File Offset: 0x00146C50
		public unsafe APawn AcknowledgedPawn
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<APawn>(base.NativePtr / (IntPtr)sizeof(void*) + APlayerController.__PropertyOffset_AcknowledgedPawn);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + APlayerController.__PropertyOffset_AcknowledgedPawn, value);
			}
		}

		// Token: 0x17003489 RID: 13449
		// (get) Token: 0x0600DEFC RID: 57084 RVA: 0x00148A65 File Offset: 0x00146C65
		// (set) Token: 0x0600DEFD RID: 57085 RVA: 0x00148A79 File Offset: 0x00146C79
		public unsafe UInterpTrackInstDirector ControllingDirTrackInst
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInterpTrackInstDirector>(base.NativePtr / (IntPtr)sizeof(void*) + APlayerController.__PropertyOffset_ControllingDirTrackInst);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + APlayerController.__PropertyOffset_ControllingDirTrackInst, value);
			}
		}

		// Token: 0x1700348A RID: 13450
		// (get) Token: 0x0600DEFE RID: 57086 RVA: 0x00148A8E File Offset: 0x00146C8E
		// (set) Token: 0x0600DEFF RID: 57087 RVA: 0x00148AA2 File Offset: 0x00146CA2
		public unsafe AHUD MyHUD
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AHUD>(base.NativePtr / (IntPtr)sizeof(void*) + APlayerController.__PropertyOffset_MyHUD);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + APlayerController.__PropertyOffset_MyHUD, value);
			}
		}

		// Token: 0x1700348B RID: 13451
		// (get) Token: 0x0600DF00 RID: 57088 RVA: 0x00148AB7 File Offset: 0x00146CB7
		// (set) Token: 0x0600DF01 RID: 57089 RVA: 0x00148AD0 File Offset: 0x00146CD0
		public unsafe bool ChangeRotationOnPossess
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_ChangeRotationOnPossess) & APlayerController.__PropertyMask_ChangeRotationOnPossess) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APlayerController.__PropertyOffset_ChangeRotationOnPossess) = ((*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_ChangeRotationOnPossess) & ~APlayerController.__PropertyMask_ChangeRotationOnPossess) | (value ? APlayerController.__PropertyMask_ChangeRotationOnPossess : 0));
			}
		}

		// Token: 0x1700348C RID: 13452
		// (get) Token: 0x0600DF02 RID: 57090 RVA: 0x00148B00 File Offset: 0x00146D00
		// (set) Token: 0x0600DF03 RID: 57091 RVA: 0x00148B14 File Offset: 0x00146D14
		public unsafe APlayerCameraManager PlayerCameraManager
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<APlayerCameraManager>(base.NativePtr / (IntPtr)sizeof(void*) + APlayerController.__PropertyOffset_PlayerCameraManager);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + APlayerController.__PropertyOffset_PlayerCameraManager, value);
			}
		}

		// Token: 0x1700348D RID: 13453
		// (get) Token: 0x0600DF04 RID: 57092 RVA: 0x00148B2C File Offset: 0x00146D2C
		// (set) Token: 0x0600DF05 RID: 57093 RVA: 0x00148B65 File Offset: 0x00146D65
		[Nullable(1)]
		public TArray<APlayerCameraManager> AdditionalPlayerCameraManagers
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<APlayerCameraManager> result;
				if ((result = this._AdditionalPlayerCameraManagers) == null)
				{
					result = (this._AdditionalPlayerCameraManagers = new TArray<APlayerCameraManager>(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_AdditionalPlayerCameraManagers, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.AdditionalPlayerCameraManagers.CopyAssign(value);
			}
		}

		// Token: 0x1700348E RID: 13454
		// (get) Token: 0x0600DF06 RID: 57094 RVA: 0x00148B73 File Offset: 0x00146D73
		// (set) Token: 0x0600DF07 RID: 57095 RVA: 0x00148B87 File Offset: 0x00146D87
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<APlayerCameraManager> PlayerCameraManagerClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_PlayerCameraManagerClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_PlayerCameraManagerClass) = value;
			}
		}

		// Token: 0x1700348F RID: 13455
		// (get) Token: 0x0600DF08 RID: 57096 RVA: 0x00148B9C File Offset: 0x00146D9C
		// (set) Token: 0x0600DF09 RID: 57097 RVA: 0x00148BAC File Offset: 0x00146DAC
		public unsafe bool bAutoManageActiveCameraTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bAutoManageActiveCameraTarget) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bAutoManageActiveCameraTarget) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003490 RID: 13456
		// (get) Token: 0x0600DF0A RID: 57098 RVA: 0x00148BBD File Offset: 0x00146DBD
		// (set) Token: 0x0600DF0B RID: 57099 RVA: 0x00148BD1 File Offset: 0x00146DD1
		public unsafe FRotator TargetViewRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_TargetViewRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_TargetViewRotation) = value;
			}
		}

		// Token: 0x17003491 RID: 13457
		// (get) Token: 0x0600DF0C RID: 57100 RVA: 0x00148BE6 File Offset: 0x00146DE6
		// (set) Token: 0x0600DF0D RID: 57101 RVA: 0x00148BF6 File Offset: 0x00146DF6
		public unsafe float SmoothTargetViewRotationSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_SmoothTargetViewRotationSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_SmoothTargetViewRotationSpeed) = value;
			}
		}

		// Token: 0x17003492 RID: 13458
		// (get) Token: 0x0600DF0E RID: 57102 RVA: 0x00148C08 File Offset: 0x00146E08
		// (set) Token: 0x0600DF0F RID: 57103 RVA: 0x00148C41 File Offset: 0x00146E41
		[Nullable(1)]
		public TArray<AActor> HiddenActors
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._HiddenActors) == null)
				{
					result = (this._HiddenActors = new TArray<AActor>(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_HiddenActors, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.HiddenActors.CopyAssign(value);
			}
		}

		// Token: 0x17003493 RID: 13459
		// (get) Token: 0x0600DF10 RID: 57104 RVA: 0x00148C50 File Offset: 0x00146E50
		// (set) Token: 0x0600DF11 RID: 57105 RVA: 0x00148C89 File Offset: 0x00146E89
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TWeakObjectPtr<UPrimitiveComponent>> HiddenPrimitiveComponents
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TWeakObjectPtr<UPrimitiveComponent>> result;
				if ((result = this._HiddenPrimitiveComponents) == null)
				{
					result = (this._HiddenPrimitiveComponents = new TArray<TWeakObjectPtr<UPrimitiveComponent>>(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_HiddenPrimitiveComponents, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.HiddenPrimitiveComponents.CopyAssign(value);
			}
		}

		// Token: 0x17003494 RID: 13460
		// (get) Token: 0x0600DF12 RID: 57106 RVA: 0x00148C97 File Offset: 0x00146E97
		// (set) Token: 0x0600DF13 RID: 57107 RVA: 0x00148CA7 File Offset: 0x00146EA7
		public unsafe float LastSpectatorStateSynchTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_LastSpectatorStateSynchTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_LastSpectatorStateSynchTime) = value;
			}
		}

		// Token: 0x17003495 RID: 13461
		// (get) Token: 0x0600DF14 RID: 57108 RVA: 0x00148CB8 File Offset: 0x00146EB8
		// (set) Token: 0x0600DF15 RID: 57109 RVA: 0x00148CCC File Offset: 0x00146ECC
		public unsafe FVector LastSpectatorSyncLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_LastSpectatorSyncLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_LastSpectatorSyncLocation) = value;
			}
		}

		// Token: 0x17003496 RID: 13462
		// (get) Token: 0x0600DF16 RID: 57110 RVA: 0x00148CE1 File Offset: 0x00146EE1
		// (set) Token: 0x0600DF17 RID: 57111 RVA: 0x00148CF5 File Offset: 0x00146EF5
		public unsafe FRotator LastSpectatorSyncRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_LastSpectatorSyncRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_LastSpectatorSyncRotation) = value;
			}
		}

		// Token: 0x17003497 RID: 13463
		// (get) Token: 0x0600DF18 RID: 57112 RVA: 0x00148D0A File Offset: 0x00146F0A
		// (set) Token: 0x0600DF19 RID: 57113 RVA: 0x00148D1A File Offset: 0x00146F1A
		public unsafe int ClientCap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_ClientCap);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_ClientCap) = value;
			}
		}

		// Token: 0x17003498 RID: 13464
		// (get) Token: 0x0600DF1A RID: 57114 RVA: 0x00148D2B File Offset: 0x00146F2B
		// (set) Token: 0x0600DF1B RID: 57115 RVA: 0x00148D3F File Offset: 0x00146F3F
		public unsafe UCheatManager CheatManager
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCheatManager>(base.NativePtr / (IntPtr)sizeof(void*) + APlayerController.__PropertyOffset_CheatManager);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + APlayerController.__PropertyOffset_CheatManager, value);
			}
		}

		// Token: 0x17003499 RID: 13465
		// (get) Token: 0x0600DF1C RID: 57116 RVA: 0x00148D54 File Offset: 0x00146F54
		// (set) Token: 0x0600DF1D RID: 57117 RVA: 0x00148D68 File Offset: 0x00146F68
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UCheatManager> CheatClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_CheatClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_CheatClass) = value;
			}
		}

		// Token: 0x1700349A RID: 13466
		// (get) Token: 0x0600DF1E RID: 57118 RVA: 0x00148D7D File Offset: 0x00146F7D
		// (set) Token: 0x0600DF1F RID: 57119 RVA: 0x00148D91 File Offset: 0x00146F91
		public unsafe UPlayerInput PlayerInput
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPlayerInput>(base.NativePtr / (IntPtr)sizeof(void*) + APlayerController.__PropertyOffset_PlayerInput);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + APlayerController.__PropertyOffset_PlayerInput, value);
			}
		}

		// Token: 0x1700349B RID: 13467
		// (get) Token: 0x0600DF20 RID: 57120 RVA: 0x00148DA8 File Offset: 0x00146FA8
		// (set) Token: 0x0600DF21 RID: 57121 RVA: 0x00148DE1 File Offset: 0x00146FE1
		[Nullable(1)]
		public TArray<FActiveForceFeedbackEffect> ActiveForceFeedbackEffects
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FActiveForceFeedbackEffect> result;
				if ((result = this._ActiveForceFeedbackEffects) == null)
				{
					result = (this._ActiveForceFeedbackEffects = new TArray<FActiveForceFeedbackEffect>(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_ActiveForceFeedbackEffects, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ActiveForceFeedbackEffects.CopyAssign(value);
			}
		}

		// Token: 0x1700349C RID: 13468
		// (get) Token: 0x0600DF22 RID: 57122 RVA: 0x00148DEF File Offset: 0x00146FEF
		// (set) Token: 0x0600DF23 RID: 57123 RVA: 0x00148E08 File Offset: 0x00147008
		public unsafe bool bPlayerIsWaiting
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bPlayerIsWaiting) & APlayerController.__PropertyMask_bPlayerIsWaiting) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APlayerController.__PropertyOffset_bPlayerIsWaiting) = ((*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bPlayerIsWaiting) & ~APlayerController.__PropertyMask_bPlayerIsWaiting) | (value ? APlayerController.__PropertyMask_bPlayerIsWaiting : 0));
			}
		}

		// Token: 0x1700349D RID: 13469
		// (get) Token: 0x0600DF24 RID: 57124 RVA: 0x00148E38 File Offset: 0x00147038
		// (set) Token: 0x0600DF25 RID: 57125 RVA: 0x00148E48 File Offset: 0x00147048
		public unsafe byte NetPlayerIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_NetPlayerIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_NetPlayerIndex) = value;
			}
		}

		// Token: 0x1700349E RID: 13470
		// (get) Token: 0x0600DF26 RID: 57126 RVA: 0x00148E59 File Offset: 0x00147059
		// (set) Token: 0x0600DF27 RID: 57127 RVA: 0x00148E6D File Offset: 0x0014706D
		public unsafe UNetConnection PendingSwapConnection
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNetConnection>(base.NativePtr / (IntPtr)sizeof(void*) + APlayerController.__PropertyOffset_PendingSwapConnection);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + APlayerController.__PropertyOffset_PendingSwapConnection, value);
			}
		}

		// Token: 0x1700349F RID: 13471
		// (get) Token: 0x0600DF28 RID: 57128 RVA: 0x00148E82 File Offset: 0x00147082
		// (set) Token: 0x0600DF29 RID: 57129 RVA: 0x00148E96 File Offset: 0x00147096
		public unsafe UNetConnection NetConnection
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNetConnection>(base.NativePtr / (IntPtr)sizeof(void*) + APlayerController.__PropertyOffset_NetConnection);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + APlayerController.__PropertyOffset_NetConnection, value);
			}
		}

		// Token: 0x170034A0 RID: 13472
		// (get) Token: 0x0600DF2A RID: 57130 RVA: 0x00148EAB File Offset: 0x001470AB
		// (set) Token: 0x0600DF2B RID: 57131 RVA: 0x00148EBB File Offset: 0x001470BB
		public unsafe float InputYawScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_InputYawScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_InputYawScale) = value;
			}
		}

		// Token: 0x170034A1 RID: 13473
		// (get) Token: 0x0600DF2C RID: 57132 RVA: 0x00148ECC File Offset: 0x001470CC
		// (set) Token: 0x0600DF2D RID: 57133 RVA: 0x00148EDC File Offset: 0x001470DC
		public unsafe float InputPitchScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_InputPitchScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_InputPitchScale) = value;
			}
		}

		// Token: 0x170034A2 RID: 13474
		// (get) Token: 0x0600DF2E RID: 57134 RVA: 0x00148EED File Offset: 0x001470ED
		// (set) Token: 0x0600DF2F RID: 57135 RVA: 0x00148EFD File Offset: 0x001470FD
		public unsafe float InputRollScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_InputRollScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_InputRollScale) = value;
			}
		}

		// Token: 0x170034A3 RID: 13475
		// (get) Token: 0x0600DF30 RID: 57136 RVA: 0x00148F0E File Offset: 0x0014710E
		// (set) Token: 0x0600DF31 RID: 57137 RVA: 0x00148F27 File Offset: 0x00147127
		public unsafe bool bShowMouseCursor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bShowMouseCursor) & APlayerController.__PropertyMask_bShowMouseCursor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APlayerController.__PropertyOffset_bShowMouseCursor) = ((*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bShowMouseCursor) & ~APlayerController.__PropertyMask_bShowMouseCursor) | (value ? APlayerController.__PropertyMask_bShowMouseCursor : 0));
			}
		}

		// Token: 0x170034A4 RID: 13476
		// (get) Token: 0x0600DF32 RID: 57138 RVA: 0x00148F57 File Offset: 0x00147157
		// (set) Token: 0x0600DF33 RID: 57139 RVA: 0x00148F70 File Offset: 0x00147170
		public unsafe bool bEnableClickEvents
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bEnableClickEvents) & APlayerController.__PropertyMask_bEnableClickEvents) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APlayerController.__PropertyOffset_bEnableClickEvents) = ((*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bEnableClickEvents) & ~APlayerController.__PropertyMask_bEnableClickEvents) | (value ? APlayerController.__PropertyMask_bEnableClickEvents : 0));
			}
		}

		// Token: 0x170034A5 RID: 13477
		// (get) Token: 0x0600DF34 RID: 57140 RVA: 0x00148FA0 File Offset: 0x001471A0
		// (set) Token: 0x0600DF35 RID: 57141 RVA: 0x00148FB9 File Offset: 0x001471B9
		public unsafe bool bEnableTouchEvents
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bEnableTouchEvents) & APlayerController.__PropertyMask_bEnableTouchEvents) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APlayerController.__PropertyOffset_bEnableTouchEvents) = ((*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bEnableTouchEvents) & ~APlayerController.__PropertyMask_bEnableTouchEvents) | (value ? APlayerController.__PropertyMask_bEnableTouchEvents : 0));
			}
		}

		// Token: 0x170034A6 RID: 13478
		// (get) Token: 0x0600DF36 RID: 57142 RVA: 0x00148FE9 File Offset: 0x001471E9
		// (set) Token: 0x0600DF37 RID: 57143 RVA: 0x00149002 File Offset: 0x00147202
		public unsafe bool bEnableMouseOverEvents
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bEnableMouseOverEvents) & APlayerController.__PropertyMask_bEnableMouseOverEvents) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APlayerController.__PropertyOffset_bEnableMouseOverEvents) = ((*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bEnableMouseOverEvents) & ~APlayerController.__PropertyMask_bEnableMouseOverEvents) | (value ? APlayerController.__PropertyMask_bEnableMouseOverEvents : 0));
			}
		}

		// Token: 0x170034A7 RID: 13479
		// (get) Token: 0x0600DF38 RID: 57144 RVA: 0x00149032 File Offset: 0x00147232
		// (set) Token: 0x0600DF39 RID: 57145 RVA: 0x0014904B File Offset: 0x0014724B
		public unsafe bool bEnableTouchOverEvents
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bEnableTouchOverEvents) & APlayerController.__PropertyMask_bEnableTouchOverEvents) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APlayerController.__PropertyOffset_bEnableTouchOverEvents) = ((*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bEnableTouchOverEvents) & ~APlayerController.__PropertyMask_bEnableTouchOverEvents) | (value ? APlayerController.__PropertyMask_bEnableTouchOverEvents : 0));
			}
		}

		// Token: 0x170034A8 RID: 13480
		// (get) Token: 0x0600DF3A RID: 57146 RVA: 0x0014907B File Offset: 0x0014727B
		// (set) Token: 0x0600DF3B RID: 57147 RVA: 0x00149094 File Offset: 0x00147294
		public unsafe bool bForceFeedbackEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bForceFeedbackEnabled) & APlayerController.__PropertyMask_bForceFeedbackEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APlayerController.__PropertyOffset_bForceFeedbackEnabled) = ((*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bForceFeedbackEnabled) & ~APlayerController.__PropertyMask_bForceFeedbackEnabled) | (value ? APlayerController.__PropertyMask_bForceFeedbackEnabled : 0));
			}
		}

		// Token: 0x170034A9 RID: 13481
		// (get) Token: 0x0600DF3C RID: 57148 RVA: 0x001490C4 File Offset: 0x001472C4
		// (set) Token: 0x0600DF3D RID: 57149 RVA: 0x001490DD File Offset: 0x001472DD
		public unsafe bool bEnableStreamingSource
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bEnableStreamingSource) & APlayerController.__PropertyMask_bEnableStreamingSource) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APlayerController.__PropertyOffset_bEnableStreamingSource) = ((*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bEnableStreamingSource) & ~APlayerController.__PropertyMask_bEnableStreamingSource) | (value ? APlayerController.__PropertyMask_bEnableStreamingSource : 0));
			}
		}

		// Token: 0x170034AA RID: 13482
		// (get) Token: 0x0600DF3E RID: 57150 RVA: 0x0014910D File Offset: 0x0014730D
		// (set) Token: 0x0600DF3F RID: 57151 RVA: 0x00149126 File Offset: 0x00147326
		public unsafe bool bStreamingSourceShouldActivate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bStreamingSourceShouldActivate) & APlayerController.__PropertyMask_bStreamingSourceShouldActivate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APlayerController.__PropertyOffset_bStreamingSourceShouldActivate) = ((*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bStreamingSourceShouldActivate) & ~APlayerController.__PropertyMask_bStreamingSourceShouldActivate) | (value ? APlayerController.__PropertyMask_bStreamingSourceShouldActivate : 0));
			}
		}

		// Token: 0x170034AB RID: 13483
		// (get) Token: 0x0600DF40 RID: 57152 RVA: 0x00149156 File Offset: 0x00147356
		// (set) Token: 0x0600DF41 RID: 57153 RVA: 0x00149166 File Offset: 0x00147366
		public unsafe EStreamingSourceTargetBehavior TargetBehavior
		{
			get
			{
				return (EStreamingSourceTargetBehavior)(*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_TargetBehavior));
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_TargetBehavior) = (byte)value;
			}
		}

		// Token: 0x170034AC RID: 13484
		// (get) Token: 0x0600DF42 RID: 57154 RVA: 0x00149178 File Offset: 0x00147378
		// (set) Token: 0x0600DF43 RID: 57155 RVA: 0x001491B1 File Offset: 0x001473B1
		[Nullable(1)]
		public TArray<FName> TargetGrids
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TargetGrids) == null)
				{
					result = (this._TargetGrids = new TArray<FName>(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_TargetGrids, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.TargetGrids.CopyAssign(value);
			}
		}

		// Token: 0x170034AD RID: 13485
		// (get) Token: 0x0600DF44 RID: 57156 RVA: 0x001491BF File Offset: 0x001473BF
		// (set) Token: 0x0600DF45 RID: 57157 RVA: 0x001491D8 File Offset: 0x001473D8
		public unsafe bool bStreamingSourceShouldBlockOnSlowStreaming
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bStreamingSourceShouldBlockOnSlowStreaming) & APlayerController.__PropertyMask_bStreamingSourceShouldBlockOnSlowStreaming) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APlayerController.__PropertyOffset_bStreamingSourceShouldBlockOnSlowStreaming) = ((*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bStreamingSourceShouldBlockOnSlowStreaming) & ~APlayerController.__PropertyMask_bStreamingSourceShouldBlockOnSlowStreaming) | (value ? APlayerController.__PropertyMask_bStreamingSourceShouldBlockOnSlowStreaming : 0));
			}
		}

		// Token: 0x170034AE RID: 13486
		// (get) Token: 0x0600DF46 RID: 57158 RVA: 0x00149208 File Offset: 0x00147408
		// (set) Token: 0x0600DF47 RID: 57159 RVA: 0x00149218 File Offset: 0x00147418
		public unsafe EStreamingSourcePriority StreamingSourcePriority
		{
			get
			{
				return (EStreamingSourcePriority)(*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_StreamingSourcePriority));
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_StreamingSourcePriority) = (byte)value;
			}
		}

		// Token: 0x170034AF RID: 13487
		// (get) Token: 0x0600DF48 RID: 57160 RVA: 0x00149229 File Offset: 0x00147429
		// (set) Token: 0x0600DF49 RID: 57161 RVA: 0x0014923D File Offset: 0x0014743D
		public unsafe FColor StreamingSourceDebugColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_StreamingSourceDebugColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_StreamingSourceDebugColor) = value;
			}
		}

		// Token: 0x170034B0 RID: 13488
		// (get) Token: 0x0600DF4A RID: 57162 RVA: 0x00149254 File Offset: 0x00147454
		// (set) Token: 0x0600DF4B RID: 57163 RVA: 0x0014928D File Offset: 0x0014748D
		[Nullable(1)]
		public TArray<FStreamingSourceShape> StreamingSourceShapes
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FStreamingSourceShape> result;
				if ((result = this._StreamingSourceShapes) == null)
				{
					result = (this._StreamingSourceShapes = new TArray<FStreamingSourceShape>(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_StreamingSourceShapes, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.StreamingSourceShapes.CopyAssign(value);
			}
		}

		// Token: 0x170034B1 RID: 13489
		// (get) Token: 0x0600DF4C RID: 57164 RVA: 0x0014929B File Offset: 0x0014749B
		// (set) Token: 0x0600DF4D RID: 57165 RVA: 0x001492AB File Offset: 0x001474AB
		public unsafe float ForceFeedbackScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_ForceFeedbackScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_ForceFeedbackScale) = value;
			}
		}

		// Token: 0x170034B2 RID: 13490
		// (get) Token: 0x0600DF4E RID: 57166 RVA: 0x001492BC File Offset: 0x001474BC
		// (set) Token: 0x0600DF4F RID: 57167 RVA: 0x001492F5 File Offset: 0x001474F5
		[Nullable(1)]
		public TArray<FKey> ClickEventKeys
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FKey> result;
				if ((result = this._ClickEventKeys) == null)
				{
					result = (this._ClickEventKeys = new TArray<FKey>(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_ClickEventKeys, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ClickEventKeys.CopyAssign(value);
			}
		}

		// Token: 0x170034B3 RID: 13491
		// (get) Token: 0x0600DF50 RID: 57168 RVA: 0x00149303 File Offset: 0x00147503
		// (set) Token: 0x0600DF51 RID: 57169 RVA: 0x00149317 File Offset: 0x00147517
		[Nullable(0)]
		public unsafe TEnumAsByte<EMouseCursor> DefaultMouseCursor
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_DefaultMouseCursor);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_DefaultMouseCursor) = value;
			}
		}

		// Token: 0x170034B4 RID: 13492
		// (get) Token: 0x0600DF52 RID: 57170 RVA: 0x0014932C File Offset: 0x0014752C
		// (set) Token: 0x0600DF53 RID: 57171 RVA: 0x00149340 File Offset: 0x00147540
		[Nullable(0)]
		public unsafe TEnumAsByte<EMouseCursor> CurrentMouseCursor
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_CurrentMouseCursor);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_CurrentMouseCursor) = value;
			}
		}

		// Token: 0x170034B5 RID: 13493
		// (get) Token: 0x0600DF54 RID: 57172 RVA: 0x00149355 File Offset: 0x00147555
		// (set) Token: 0x0600DF55 RID: 57173 RVA: 0x00149369 File Offset: 0x00147569
		[Nullable(0)]
		public unsafe TEnumAsByte<ECollisionChannel> DefaultClickTraceChannel
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_DefaultClickTraceChannel);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_DefaultClickTraceChannel) = value;
			}
		}

		// Token: 0x170034B6 RID: 13494
		// (get) Token: 0x0600DF56 RID: 57174 RVA: 0x0014937E File Offset: 0x0014757E
		// (set) Token: 0x0600DF57 RID: 57175 RVA: 0x00149392 File Offset: 0x00147592
		[Nullable(0)]
		public unsafe TEnumAsByte<ECollisionChannel> CurrentClickTraceChannel
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_CurrentClickTraceChannel);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_CurrentClickTraceChannel) = value;
			}
		}

		// Token: 0x170034B7 RID: 13495
		// (get) Token: 0x0600DF58 RID: 57176 RVA: 0x001493A7 File Offset: 0x001475A7
		// (set) Token: 0x0600DF59 RID: 57177 RVA: 0x001493B7 File Offset: 0x001475B7
		public unsafe float HitResultTraceDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_HitResultTraceDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_HitResultTraceDistance) = value;
			}
		}

		// Token: 0x170034B8 RID: 13496
		// (get) Token: 0x0600DF5A RID: 57178 RVA: 0x001493C8 File Offset: 0x001475C8
		// (set) Token: 0x0600DF5B RID: 57179 RVA: 0x001493D8 File Offset: 0x001475D8
		public unsafe ushort SeamlessTravelCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_SeamlessTravelCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_SeamlessTravelCount) = (short)value;
			}
		}

		// Token: 0x170034B9 RID: 13497
		// (get) Token: 0x0600DF5C RID: 57180 RVA: 0x001493E9 File Offset: 0x001475E9
		// (set) Token: 0x0600DF5D RID: 57181 RVA: 0x001493F9 File Offset: 0x001475F9
		public unsafe ushort LastCompletedSeamlessTravelCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_LastCompletedSeamlessTravelCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_LastCompletedSeamlessTravelCount) = (short)value;
			}
		}

		// Token: 0x170034BA RID: 13498
		// (get) Token: 0x0600DF5E RID: 57182 RVA: 0x0014940A File Offset: 0x0014760A
		// (set) Token: 0x0600DF5F RID: 57183 RVA: 0x0014941E File Offset: 0x0014761E
		public unsafe AActor SeamlessCameraActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + APlayerController.__PropertyOffset_SeamlessCameraActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + APlayerController.__PropertyOffset_SeamlessCameraActor, value);
			}
		}

		// Token: 0x170034BB RID: 13499
		// (get) Token: 0x0600DF60 RID: 57184 RVA: 0x00149433 File Offset: 0x00147633
		// (set) Token: 0x0600DF61 RID: 57185 RVA: 0x0014944C File Offset: 0x0014764C
		public unsafe bool bUseSeamlessCameraActor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bUseSeamlessCameraActor) & APlayerController.__PropertyMask_bUseSeamlessCameraActor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APlayerController.__PropertyOffset_bUseSeamlessCameraActor) = ((*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bUseSeamlessCameraActor) & ~APlayerController.__PropertyMask_bUseSeamlessCameraActor) | (value ? APlayerController.__PropertyMask_bUseSeamlessCameraActor : 0));
			}
		}

		// Token: 0x170034BC RID: 13500
		// (get) Token: 0x0600DF62 RID: 57186 RVA: 0x0014947C File Offset: 0x0014767C
		// (set) Token: 0x0600DF63 RID: 57187 RVA: 0x00149490 File Offset: 0x00147690
		public unsafe UInputComponent InactiveStateInputComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInputComponent>(base.NativePtr / (IntPtr)sizeof(void*) + APlayerController.__PropertyOffset_InactiveStateInputComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + APlayerController.__PropertyOffset_InactiveStateInputComponent, value);
			}
		}

		// Token: 0x170034BD RID: 13501
		// (get) Token: 0x0600DF64 RID: 57188 RVA: 0x001494A5 File Offset: 0x001476A5
		// (set) Token: 0x0600DF65 RID: 57189 RVA: 0x001494BE File Offset: 0x001476BE
		public unsafe bool bShouldPerformFullTickWhenPaused
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bShouldPerformFullTickWhenPaused) & APlayerController.__PropertyMask_bShouldPerformFullTickWhenPaused) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APlayerController.__PropertyOffset_bShouldPerformFullTickWhenPaused) = ((*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bShouldPerformFullTickWhenPaused) & ~APlayerController.__PropertyMask_bShouldPerformFullTickWhenPaused) | (value ? APlayerController.__PropertyMask_bShouldPerformFullTickWhenPaused : 0));
			}
		}

		// Token: 0x170034BE RID: 13502
		// (get) Token: 0x0600DF66 RID: 57190 RVA: 0x001494EE File Offset: 0x001476EE
		// (set) Token: 0x0600DF67 RID: 57191 RVA: 0x00149502 File Offset: 0x00147702
		public unsafe UTouchInterface CurrentTouchInterface
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTouchInterface>(base.NativePtr / (IntPtr)sizeof(void*) + APlayerController.__PropertyOffset_CurrentTouchInterface);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + APlayerController.__PropertyOffset_CurrentTouchInterface, value);
			}
		}

		// Token: 0x170034BF RID: 13503
		// (get) Token: 0x0600DF68 RID: 57192 RVA: 0x00149517 File Offset: 0x00147717
		// (set) Token: 0x0600DF69 RID: 57193 RVA: 0x0014952B File Offset: 0x0014772B
		public unsafe ASpectatorPawn SpectatorPawn
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ASpectatorPawn>(base.NativePtr / (IntPtr)sizeof(void*) + APlayerController.__PropertyOffset_SpectatorPawn);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + APlayerController.__PropertyOffset_SpectatorPawn, value);
			}
		}

		// Token: 0x170034C0 RID: 13504
		// (get) Token: 0x0600DF6A RID: 57194 RVA: 0x00149540 File Offset: 0x00147740
		// (set) Token: 0x0600DF6B RID: 57195 RVA: 0x00149550 File Offset: 0x00147750
		public unsafe bool bIsLocalPlayerController
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bIsLocalPlayerController) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bIsLocalPlayerController) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034C1 RID: 13505
		// (get) Token: 0x0600DF6C RID: 57196 RVA: 0x00149561 File Offset: 0x00147761
		// (set) Token: 0x0600DF6D RID: 57197 RVA: 0x00149575 File Offset: 0x00147775
		public unsafe FVector SpawnLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_SpawnLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_SpawnLocation) = value;
			}
		}

		// Token: 0x0600DF6E RID: 57198 RVA: 0x0014958A File Offset: 0x0014778A
		public bool WasInputKeyJustReleased(FKey Key)
		{
			return APlayerController.__WasInputKeyJustReleased_Internal(base.NativePtr, (Key ?? new FKey()).NativePtr);
		}

		// Token: 0x0600DF6F RID: 57199 RVA: 0x001495A6 File Offset: 0x001477A6
		public bool WasInputKeyJustPressed(FKey Key)
		{
			return APlayerController.__WasInputKeyJustPressed_Internal(base.NativePtr, (Key ?? new FKey()).NativePtr);
		}

		// Token: 0x0600DF70 RID: 57200 RVA: 0x001495C2 File Offset: 0x001477C2
		public void ToggleSpeaking(bool bInSpeaking)
		{
			APlayerController.__ToggleSpeaking_Internal(base.NativePtr, bInSpeaking);
		}

		// Token: 0x0600DF71 RID: 57201 RVA: 0x001495D0 File Offset: 0x001477D0
		public void TestServerLevelVisibilityChange(FName PackageName, FName FileName)
		{
			APlayerController.__TestServerLevelVisibilityChange_Internal(base.NativePtr, PackageName, FileName);
		}

		// Token: 0x0600DF72 RID: 57202 RVA: 0x001495E0 File Offset: 0x001477E0
		[NullableContext(1)]
		public unsafe void SwitchLevel(string URL)
		{
			FString fstring = FString.AllocTemp(URL);
			APlayerController.__SwitchLevel_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600DF73 RID: 57203 RVA: 0x0014960A File Offset: 0x0014780A
		public bool StreamingSourceShouldBlockOnSlowStreaming()
		{
			return APlayerController.__StreamingSourceShouldBlockOnSlowStreaming_Internal(base.NativePtr);
		}

		// Token: 0x0600DF74 RID: 57204 RVA: 0x00149617 File Offset: 0x00147817
		public bool StreamingSourceShouldActivate()
		{
			return APlayerController.__StreamingSourceShouldActivate_Internal(base.NativePtr);
		}

		// Token: 0x0600DF75 RID: 57205 RVA: 0x00149624 File Offset: 0x00147824
		public void StopHapticEffect(EControllerHand Hand)
		{
			APlayerController.__StopHapticEffect_Internal(base.NativePtr, Hand);
		}

		// Token: 0x0600DF76 RID: 57206 RVA: 0x00149632 File Offset: 0x00147832
		public void StartFire(byte FireModeNum = 0)
		{
			APlayerController.__StartFire_Internal(base.NativePtr, FireModeNum);
		}

		// Token: 0x0600DF77 RID: 57207 RVA: 0x00149640 File Offset: 0x00147840
		public APlayerCameraManager SpawnPlayerCameraManager()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APlayerCameraManager>(APlayerController.__SpawnPlayerCameraManager_Internal(base.NativePtr));
		}

		// Token: 0x0600DF78 RID: 57208 RVA: 0x00149652 File Offset: 0x00147852
		public void SetVirtualJoystickVisibility(bool bVisible)
		{
			APlayerController.__SetVirtualJoystickVisibility_Internal(base.NativePtr, bVisible);
		}

		// Token: 0x0600DF79 RID: 57209 RVA: 0x00149660 File Offset: 0x00147860
		public void SetViewTargetWithBlendCurve(AActor NewViewTarget, float BlendTime = 0f, EViewTargetBlendFunction BlendFunc = EViewTargetBlendFunction.VTBlend_Linear, float BlendExp = 0f, bool bLockOutgoing = false, bool bKuroEnableBlend = false, UCurveFloat BlendCurve = null)
		{
			APlayerController.__SetViewTargetWithBlendCurve_Internal(base.NativePtr, (NewViewTarget != null) ? NewViewTarget.NativePtr : IntPtr.Zero, BlendTime, BlendFunc, BlendExp, bLockOutgoing, bKuroEnableBlend, (BlendCurve != null) ? BlendCurve.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600DF7A RID: 57210 RVA: 0x0014969C File Offset: 0x0014789C
		public void SetViewTargetWithBlend(AActor NewViewTarget, float BlendTime = 0f, EViewTargetBlendFunction BlendFunc = EViewTargetBlendFunction.VTBlend_Linear, float BlendExp = 0f, bool bLockOutgoing = false, bool bKuroEnableBlend = false)
		{
			APlayerController.__SetViewTargetWithBlend_Internal(base.NativePtr, (NewViewTarget != null) ? NewViewTarget.NativePtr : IntPtr.Zero, BlendTime, BlendFunc, BlendExp, bLockOutgoing, bKuroEnableBlend);
		}

		// Token: 0x0600DF7B RID: 57211 RVA: 0x001496C8 File Offset: 0x001478C8
		[NullableContext(1)]
		public unsafe void SetName(string S)
		{
			FString fstring = FString.AllocTemp(S);
			APlayerController.__SetName_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600DF7C RID: 57212 RVA: 0x001496F2 File Offset: 0x001478F2
		public void SetMouseLocation(int X, int Y)
		{
			APlayerController.__SetMouseLocation_Internal(base.NativePtr, X, Y);
		}

		// Token: 0x0600DF7D RID: 57213 RVA: 0x00149701 File Offset: 0x00147901
		public void SetMouseCursorWidget(EMouseCursor Cursor, UUserWidget CursorWidget)
		{
			APlayerController.__SetMouseCursorWidget_Internal(base.NativePtr, Cursor, (CursorWidget != null) ? CursorWidget.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600DF7E RID: 57214 RVA: 0x00149724 File Offset: 0x00147924
		public void SetHapticsByValue(float Frequency, float Amplitude, EControllerHand Hand)
		{
			APlayerController.__SetHapticsByValue_Internal(base.NativePtr, Frequency, Amplitude, Hand);
		}

		// Token: 0x0600DF7F RID: 57215 RVA: 0x00149734 File Offset: 0x00147934
		public void SetDisableHaptics(bool bNewDisabled)
		{
			APlayerController.__SetDisableHaptics_Internal(base.NativePtr, bNewDisabled);
		}

		// Token: 0x0600DF80 RID: 57216 RVA: 0x00149742 File Offset: 0x00147942
		public void SetControllerLightColor(FColor Color)
		{
			APlayerController.__SetControllerLightColor_Internal(base.NativePtr, Color);
		}

		// Token: 0x0600DF81 RID: 57217 RVA: 0x00149750 File Offset: 0x00147950
		public void SetCinematicMode(bool bInCinematicMode, bool bHidePlayer, bool bAffectsHUD, bool bAffectsMovement, bool bAffectsTurning)
		{
			APlayerController.__SetCinematicMode_Internal(base.NativePtr, bInCinematicMode, bHidePlayer, bAffectsHUD, bAffectsMovement, bAffectsTurning);
		}

		// Token: 0x0600DF82 RID: 57218 RVA: 0x00149764 File Offset: 0x00147964
		public void SetAudioListenerOverride(USceneComponent AttachToComponent, FVector Location, FRotator Rotation)
		{
			APlayerController.__SetAudioListenerOverride_Internal(base.NativePtr, (AttachToComponent != null) ? AttachToComponent.NativePtr : IntPtr.Zero, Location, Rotation);
		}

		// Token: 0x0600DF83 RID: 57219 RVA: 0x00149783 File Offset: 0x00147983
		public void SetAudioListenerAttenuationOverride(USceneComponent AttachToComponent, FVector AttenuationLocationOVerride)
		{
			APlayerController.__SetAudioListenerAttenuationOverride_Internal(base.NativePtr, (AttachToComponent != null) ? AttachToComponent.NativePtr : IntPtr.Zero, AttenuationLocationOVerride);
		}

		// Token: 0x0600DF84 RID: 57220 RVA: 0x001497A1 File Offset: 0x001479A1
		public void ServerViewSelf(FViewTargetTransitionParams TransitionParams)
		{
			APlayerController.__ServerViewSelf_Internal(base.NativePtr, (TransitionParams ?? new FViewTargetTransitionParams()).NativePtr);
		}

		// Token: 0x0600DF85 RID: 57221 RVA: 0x001497BD File Offset: 0x001479BD
		public void ServerViewPrevPlayer()
		{
			APlayerController.__ServerViewPrevPlayer_Internal(base.NativePtr);
		}

		// Token: 0x0600DF86 RID: 57222 RVA: 0x001497CA File Offset: 0x001479CA
		public void ServerViewNextPlayer()
		{
			APlayerController.__ServerViewNextPlayer_Internal(base.NativePtr);
		}

		// Token: 0x0600DF87 RID: 57223 RVA: 0x001497D7 File Offset: 0x001479D7
		public void ServerVerifyViewTarget()
		{
			APlayerController.__ServerVerifyViewTarget_Internal(base.NativePtr);
		}

		// Token: 0x0600DF88 RID: 57224 RVA: 0x001497E4 File Offset: 0x001479E4
		public void ServerUpdateMultipleLevelsVisibility([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FUpdateLevelVisibilityLevelInfo> LevelVisibilities)
		{
			APlayerController.__ServerUpdateMultipleLevelsVisibility_Internal(base.NativePtr, (LevelVisibilities ?? new TArray<FUpdateLevelVisibilityLevelInfo>()).NativePtr);
		}

		// Token: 0x0600DF89 RID: 57225 RVA: 0x00149801 File Offset: 0x00147A01
		public void ServerUpdateLevelVisibility(in FUpdateLevelVisibilityLevelInfo LevelVisibility)
		{
			APlayerController.__ServerUpdateLevelVisibility_Internal(base.NativePtr, (LevelVisibility ?? new FUpdateLevelVisibilityLevelInfo()).NativePtr);
		}

		// Token: 0x0600DF8A RID: 57226 RVA: 0x0014981E File Offset: 0x00147A1E
		public void ServerUpdateCamera(FVector_NetQuantize CamLoc, int CamPitchAndYaw)
		{
			APlayerController.__ServerUpdateCamera_Internal(base.NativePtr, CamLoc, CamPitchAndYaw);
		}

		// Token: 0x0600DF8B RID: 57227 RVA: 0x0014982D File Offset: 0x00147A2D
		public void ServerUnmutePlayer(FUniqueNetIdRepl PlayerId)
		{
			APlayerController.__ServerUnmutePlayer_Internal(base.NativePtr, (PlayerId ?? new FUniqueNetIdRepl()).NativePtr);
		}

		// Token: 0x0600DF8C RID: 57228 RVA: 0x00149849 File Offset: 0x00147A49
		public void ServerToggleAILogging()
		{
			APlayerController.__ServerToggleAILogging_Internal(base.NativePtr);
		}

		// Token: 0x0600DF8D RID: 57229 RVA: 0x00149856 File Offset: 0x00147A56
		public void ServerShortTimeout()
		{
			APlayerController.__ServerShortTimeout_Internal(base.NativePtr);
		}

		// Token: 0x0600DF8E RID: 57230 RVA: 0x00149863 File Offset: 0x00147A63
		public void ServerSetSpectatorWaiting(bool bWaiting)
		{
			APlayerController.__ServerSetSpectatorWaiting_Internal(base.NativePtr, bWaiting);
		}

		// Token: 0x0600DF8F RID: 57231 RVA: 0x00149871 File Offset: 0x00147A71
		public void ServerSetSpectatorLocation(FVector NewLoc, FRotator NewRot)
		{
			APlayerController.__ServerSetSpectatorLocation_Internal(base.NativePtr, NewLoc, NewRot);
		}

		// Token: 0x0600DF90 RID: 57232 RVA: 0x00149880 File Offset: 0x00147A80
		public void ServerRestartPlayer()
		{
			APlayerController.__ServerRestartPlayer_Internal(base.NativePtr);
		}

		// Token: 0x0600DF91 RID: 57233 RVA: 0x0014988D File Offset: 0x00147A8D
		public void ServerPause()
		{
			APlayerController.__ServerPause_Internal(base.NativePtr);
		}

		// Token: 0x0600DF92 RID: 57234 RVA: 0x0014989A File Offset: 0x00147A9A
		public void ServerNotifyLoadedWorld(FName WorldPackageName)
		{
			APlayerController.__ServerNotifyLoadedWorld_Internal(base.NativePtr, WorldPackageName);
		}

		// Token: 0x0600DF93 RID: 57235 RVA: 0x001498A8 File Offset: 0x00147AA8
		public void ServerMutePlayer(FUniqueNetIdRepl PlayerId)
		{
			APlayerController.__ServerMutePlayer_Internal(base.NativePtr, (PlayerId ?? new FUniqueNetIdRepl()).NativePtr);
		}

		// Token: 0x0600DF94 RID: 57236 RVA: 0x001498C4 File Offset: 0x00147AC4
		[NullableContext(1)]
		public unsafe void ServerExecRPC(string Msg)
		{
			FString fstring = FString.AllocTemp(Msg);
			APlayerController.__ServerExecRPC_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600DF95 RID: 57237 RVA: 0x001498F0 File Offset: 0x00147AF0
		[NullableContext(1)]
		public unsafe void ServerExec(string Msg)
		{
			FString fstring = FString.AllocTemp(Msg);
			APlayerController.__ServerExec_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600DF96 RID: 57238 RVA: 0x0014991A File Offset: 0x00147B1A
		public void ServerCheckClientPossessionReliable()
		{
			APlayerController.__ServerCheckClientPossessionReliable_Internal(base.NativePtr);
		}

		// Token: 0x0600DF97 RID: 57239 RVA: 0x00149927 File Offset: 0x00147B27
		public void ServerCheckClientPossession()
		{
			APlayerController.__ServerCheckClientPossession_Internal(base.NativePtr);
		}

		// Token: 0x0600DF98 RID: 57240 RVA: 0x00149934 File Offset: 0x00147B34
		[NullableContext(1)]
		public unsafe void ServerChangeName(string S)
		{
			FString fstring = FString.AllocTemp(S);
			APlayerController.__ServerChangeName_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600DF99 RID: 57241 RVA: 0x0014995E File Offset: 0x00147B5E
		public void ServerCamera(FName NewMode)
		{
			APlayerController.__ServerCamera_Internal(base.NativePtr, NewMode);
		}

		// Token: 0x0600DF9A RID: 57242 RVA: 0x0014996C File Offset: 0x00147B6C
		public void ServerAcknowledgePossession(APawn P)
		{
			APlayerController.__ServerAcknowledgePossession_Internal(base.NativePtr, (P != null) ? P.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600DF9B RID: 57243 RVA: 0x0014998C File Offset: 0x00147B8C
		[NullableContext(1)]
		public unsafe void SendToConsole(string Command)
		{
			FString fstring = FString.AllocTemp(Command);
			APlayerController.__SendToConsole_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600DF9C RID: 57244 RVA: 0x001499B6 File Offset: 0x00147BB6
		public void RestartLevel()
		{
			APlayerController.__RestartLevel_Internal(base.NativePtr);
		}

		// Token: 0x0600DF9D RID: 57245 RVA: 0x001499C3 File Offset: 0x00147BC3
		public void ResetControllerLightColor()
		{
			APlayerController.__ResetControllerLightColor_Internal(base.NativePtr);
		}

		// Token: 0x0600DF9E RID: 57246 RVA: 0x001499D0 File Offset: 0x00147BD0
		public void RemoveAdditionalPlayerCameraManagers()
		{
			APlayerController.__RemoveAdditionalPlayerCameraManagers_Internal(base.NativePtr);
		}

		// Token: 0x0600DF9F RID: 57247 RVA: 0x001499E0 File Offset: 0x00147BE0
		public unsafe bool ProjectWorldLocationToScreen(FVector WorldLocation, ref FVector2D ScreenLocation, bool bPlayerViewportRelative = false)
		{
			fixed (FVector2D* ptr = &ScreenLocation)
			{
				void* ptr2 = (void*)ptr;
				return APlayerController.__ProjectWorldLocationToScreen_Internal(base.NativePtr, WorldLocation, ref ScreenLocation, bPlayerViewportRelative);
			}
		}

		// Token: 0x0600DFA0 RID: 57248 RVA: 0x00149A00 File Offset: 0x00147C00
		public void PlayHapticEffect(UHapticFeedbackEffect_Base HapticEffect, EControllerHand Hand, float Scale = 1f, bool bLoop = false)
		{
			APlayerController.__PlayHapticEffect_Internal(base.NativePtr, (HapticEffect != null) ? HapticEffect.NativePtr : IntPtr.Zero, Hand, Scale, bLoop);
		}

		// Token: 0x0600DFA1 RID: 57249 RVA: 0x00149A24 File Offset: 0x00147C24
		public void PlayDynamicForceFeedback(float Intensity, float Duration, bool bAffectsLeftLarge, bool bAffectsLeftSmall, bool bAffectsRightLarge, bool bAffectsRightSmall, EDynamicForceFeedbackAction Action, FLatentActionInfo LatentInfo)
		{
			APlayerController.__PlayDynamicForceFeedback_Internal(base.NativePtr, Intensity, Duration, bAffectsLeftLarge, bAffectsLeftSmall, bAffectsRightLarge, bAffectsRightSmall, Action, (LatentInfo ?? new FLatentActionInfo()).NativePtr);
		}

		// Token: 0x0600DFA2 RID: 57250 RVA: 0x00149A5C File Offset: 0x00147C5C
		public void Pause()
		{
			APlayerController.__Pause_Internal(base.NativePtr);
		}

		// Token: 0x0600DFA3 RID: 57251 RVA: 0x00149A69 File Offset: 0x00147C69
		public void OnServerStartedVisualLogger(bool bIsLogging)
		{
			APlayerController.__OnServerStartedVisualLogger_Internal(base.NativePtr, bIsLogging);
		}

		// Token: 0x0600DFA4 RID: 57252 RVA: 0x00149A78 File Offset: 0x00147C78
		[NullableContext(1)]
		public unsafe void LocalTravel(string URL)
		{
			FString fstring = FString.AllocTemp(URL);
			APlayerController.__LocalTravel_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600DFA5 RID: 57253 RVA: 0x00149AA4 File Offset: 0x00147CA4
		[NullableContext(1)]
		public unsafe void K2_ClientTravel(string URL, ETravelType TravelType, bool bSeamless = false)
		{
			FString fstring = FString.AllocTemp(URL);
			APlayerController.__K2_ClientTravel_Internal(base.NativePtr, fstring, TravelType, bSeamless);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600DFA6 RID: 57254 RVA: 0x00149AD5 File Offset: 0x00147CD5
		public void K2_ClientPlayForceFeedback(UForceFeedbackEffect ForceFeedbackEffect, FName Tag, bool bLooping, bool bIgnoreTimeDilation, bool bPlayWhilePaused)
		{
			APlayerController.__K2_ClientPlayForceFeedback_Internal(base.NativePtr, (ForceFeedbackEffect != null) ? ForceFeedbackEffect.NativePtr : IntPtr.Zero, Tag, bLooping, bIgnoreTimeDilation, bPlayWhilePaused);
		}

		// Token: 0x0600DFA7 RID: 57255 RVA: 0x00149AF8 File Offset: 0x00147CF8
		public bool IsStreamingSourceEnabled()
		{
			return APlayerController.__IsStreamingSourceEnabled_Internal(base.NativePtr);
		}

		// Token: 0x0600DFA8 RID: 57256 RVA: 0x00149B05 File Offset: 0x00147D05
		public bool IsInputKeyDown(FKey Key)
		{
			return APlayerController.__IsInputKeyDown_Internal(base.NativePtr, (Key ?? new FKey()).NativePtr);
		}

		// Token: 0x0600DFA9 RID: 57257 RVA: 0x00149B24 File Offset: 0x00147D24
		public unsafe void GetViewportSize(ref int SizeX, ref int SizeY)
		{
			fixed (int* ptr = &SizeX)
			{
				void* ptr2 = (void*)ptr;
				fixed (int* ptr3 = &SizeY)
				{
					void* ptr4 = (void*)ptr3;
					APlayerController.__GetViewportSize_Internal(base.NativePtr, ref SizeX, ref SizeY);
					ptr = null;
				}
			}
		}

		// Token: 0x0600DFAA RID: 57258 RVA: 0x00149B4E File Offset: 0x00147D4E
		public void GetStreamingSourceShapes([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FStreamingSourceShape> OutShapes)
		{
			APlayerController.__GetStreamingSourceShapes_Internal(base.NativePtr, (OutShapes ?? new TArray<FStreamingSourceShape>()).NativePtr);
		}

		// Token: 0x0600DFAB RID: 57259 RVA: 0x00149B6B File Offset: 0x00147D6B
		public EStreamingSourcePriority GetStreamingSourcePriority()
		{
			return APlayerController.__GetStreamingSourcePriority_Internal(base.NativePtr);
		}

		// Token: 0x0600DFAC RID: 57260 RVA: 0x00149B78 File Offset: 0x00147D78
		public unsafe void GetStreamingSourceLocationAndRotation(ref FVector OutLocation, ref FRotator OutRotation)
		{
			fixed (FVector* ptr = &OutLocation)
			{
				void* ptr2 = (void*)ptr;
				fixed (FRotator* ptr3 = &OutRotation)
				{
					void* ptr4 = (void*)ptr3;
					APlayerController.__GetStreamingSourceLocationAndRotation_Internal(base.NativePtr, ref OutLocation, ref OutRotation);
					ptr = null;
				}
			}
		}

		// Token: 0x0600DFAD RID: 57261 RVA: 0x00149BA2 File Offset: 0x00147DA2
		public ASpectatorPawn GetSpectatorPawn()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ASpectatorPawn>(APlayerController.__GetSpectatorPawn_Internal(base.NativePtr));
		}

		// Token: 0x0600DFAE RID: 57262 RVA: 0x00149BB4 File Offset: 0x00147DB4
		public int GetPlayerCameraManagerCount()
		{
			return APlayerController.__GetPlayerCameraManagerCount_Internal(base.NativePtr);
		}

		// Token: 0x0600DFAF RID: 57263 RVA: 0x00149BC1 File Offset: 0x00147DC1
		public APlayerCameraManager GetPlayerCameraManager(int CameraIndex = 0)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APlayerCameraManager>(APlayerController.__GetPlayerCameraManager_Internal(base.NativePtr, CameraIndex));
		}

		// Token: 0x0600DFB0 RID: 57264 RVA: 0x00149BD4 File Offset: 0x00147DD4
		public unsafe bool GetMousePosition(ref float LocationX, ref float LocationY)
		{
			fixed (float* ptr = &LocationX)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &LocationY)
				{
					void* ptr4 = (void*)ptr3;
					return APlayerController.__GetMousePosition_Internal(base.NativePtr, ref LocationX, ref LocationY);
				}
			}
		}

		// Token: 0x0600DFB1 RID: 57265 RVA: 0x00149BF8 File Offset: 0x00147DF8
		public FVector GetInputVectorKeyState(FKey Key)
		{
			return APlayerController.__GetInputVectorKeyState_Internal(base.NativePtr, (Key ?? new FKey()).NativePtr);
		}

		// Token: 0x0600DFB2 RID: 57266 RVA: 0x00149C14 File Offset: 0x00147E14
		public unsafe void GetInputTouchState(ETouchIndex FingerIndex, ref float LocationX, ref float LocationY, ref bool bIsCurrentlyPressed)
		{
			fixed (float* ptr = &LocationX)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &LocationY)
				{
					void* ptr4 = (void*)ptr3;
					fixed (bool* ptr5 = &bIsCurrentlyPressed)
					{
						void* ptr6 = (void*)ptr5;
						APlayerController.__GetInputTouchState_Internal(base.NativePtr, FingerIndex, ref LocationX, ref LocationY, ref bIsCurrentlyPressed);
						ptr = null;
						ptr3 = null;
					}
				}
			}
		}

		// Token: 0x0600DFB3 RID: 57267 RVA: 0x00149C58 File Offset: 0x00147E58
		public unsafe void GetInputMouseDelta(ref float DeltaX, ref float DeltaY)
		{
			fixed (float* ptr = &DeltaX)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &DeltaY)
				{
					void* ptr4 = (void*)ptr3;
					APlayerController.__GetInputMouseDelta_Internal(base.NativePtr, ref DeltaX, ref DeltaY);
					ptr = null;
				}
			}
		}

		// Token: 0x0600DFB4 RID: 57268 RVA: 0x00149C84 File Offset: 0x00147E84
		public unsafe void GetInputMotionState(ref FVector Tilt, ref FVector RotationRate, ref FVector Gravity, ref FVector Acceleration)
		{
			fixed (FVector* ptr = &Tilt)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &RotationRate)
				{
					void* ptr4 = (void*)ptr3;
					fixed (FVector* ptr5 = &Gravity)
					{
						void* ptr6 = (void*)ptr5;
						fixed (FVector* ptr7 = &Acceleration)
						{
							void* ptr8 = (void*)ptr7;
							APlayerController.__GetInputMotionState_Internal(base.NativePtr, ref Tilt, ref RotationRate, ref Gravity, ref Acceleration);
							ptr = null;
							ptr3 = null;
							ptr5 = null;
						}
					}
				}
			}
		}

		// Token: 0x0600DFB5 RID: 57269 RVA: 0x00149CCE File Offset: 0x00147ECE
		public float GetInputKeyTimeDown(FKey Key)
		{
			return APlayerController.__GetInputKeyTimeDown_Internal(base.NativePtr, (Key ?? new FKey()).NativePtr);
		}

		// Token: 0x0600DFB6 RID: 57270 RVA: 0x00149CEC File Offset: 0x00147EEC
		public unsafe void GetInputAnalogStickState(EControllerAnalogStick WhichStick, ref float StickX, ref float StickY)
		{
			fixed (float* ptr = &StickX)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &StickY)
				{
					void* ptr4 = (void*)ptr3;
					APlayerController.__GetInputAnalogStickState_Internal(base.NativePtr, WhichStick, ref StickX, ref StickY);
					ptr = null;
				}
			}
		}

		// Token: 0x0600DFB7 RID: 57271 RVA: 0x00149D1C File Offset: 0x00147F1C
		public float GetInputAnalogKeyState(FKey Key)
		{
			return APlayerController.__GetInputAnalogKeyState_Internal(base.NativePtr, (Key ?? new FKey()).NativePtr);
		}

		// Token: 0x0600DFB8 RID: 57272 RVA: 0x00149D38 File Offset: 0x00147F38
		public AHUD GetHUD()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AHUD>(APlayerController.__GetHUD_Internal(base.NativePtr));
		}

		// Token: 0x0600DFB9 RID: 57273 RVA: 0x00149D4A File Offset: 0x00147F4A
		public bool GetHitResultUnderFingerForObjects(ETouchIndex FingerIndex, [Nullable(new byte[]
		{
			2,
			0
		})] in TArray<TEnumAsByte<EObjectTypeQuery>> ObjectTypes, bool bTraceComplex, ref FHitResult HitResult)
		{
			return APlayerController.__GetHitResultUnderFingerForObjects_Internal(base.NativePtr, FingerIndex, (ObjectTypes ?? new TArray<TEnumAsByte<EObjectTypeQuery>>()).NativePtr, bTraceComplex, (HitResult ?? new FHitResult()).NativePtr);
		}

		// Token: 0x0600DFBA RID: 57274 RVA: 0x00149D7F File Offset: 0x00147F7F
		public bool GetHitResultUnderFingerByChannel(ETouchIndex FingerIndex, ETraceTypeQuery TraceChannel, bool bTraceComplex, ref FHitResult HitResult)
		{
			return APlayerController.__GetHitResultUnderFingerByChannel_Internal(base.NativePtr, FingerIndex, TraceChannel, bTraceComplex, (HitResult ?? new FHitResult()).NativePtr);
		}

		// Token: 0x0600DFBB RID: 57275 RVA: 0x00149DAA File Offset: 0x00147FAA
		public bool GetHitResultUnderFinger(ETouchIndex FingerIndex, ECollisionChannel TraceChannel, bool bTraceComplex, ref FHitResult HitResult)
		{
			return APlayerController.__GetHitResultUnderFinger_Internal(base.NativePtr, FingerIndex, TraceChannel, bTraceComplex, (HitResult ?? new FHitResult()).NativePtr);
		}

		// Token: 0x0600DFBC RID: 57276 RVA: 0x00149DD5 File Offset: 0x00147FD5
		public bool GetHitResultUnderCursorForObjects([Nullable(new byte[]
		{
			2,
			0
		})] in TArray<TEnumAsByte<EObjectTypeQuery>> ObjectTypes, bool bTraceComplex, ref FHitResult HitResult)
		{
			return APlayerController.__GetHitResultUnderCursorForObjects_Internal(base.NativePtr, (ObjectTypes ?? new TArray<TEnumAsByte<EObjectTypeQuery>>()).NativePtr, bTraceComplex, (HitResult ?? new FHitResult()).NativePtr);
		}

		// Token: 0x0600DFBD RID: 57277 RVA: 0x00149E03 File Offset: 0x00148003
		public bool GetHitResultUnderCursorByChannel(ETraceTypeQuery TraceChannel, bool bTraceComplex, ref FHitResult HitResult)
		{
			return APlayerController.__GetHitResultUnderCursorByChannel_Internal(base.NativePtr, TraceChannel, bTraceComplex, (HitResult ?? new FHitResult()).NativePtr);
		}

		// Token: 0x0600DFBE RID: 57278 RVA: 0x00149E27 File Offset: 0x00148027
		public bool GetHitResultUnderCursor(ECollisionChannel TraceChannel, bool bTraceComplex, ref FHitResult HitResult)
		{
			return APlayerController.__GetHitResultUnderCursor_Internal(base.NativePtr, TraceChannel, bTraceComplex, (HitResult ?? new FHitResult()).NativePtr);
		}

		// Token: 0x0600DFBF RID: 57279 RVA: 0x00149E4B File Offset: 0x0014804B
		public FVector GetFocalLocation()
		{
			return APlayerController.__GetFocalLocation_Internal(base.NativePtr);
		}

		// Token: 0x0600DFC0 RID: 57280 RVA: 0x00149E58 File Offset: 0x00148058
		public void FOV(float NewFOV)
		{
			APlayerController.__FOV_Internal(base.NativePtr, NewFOV);
		}

		// Token: 0x0600DFC1 RID: 57281 RVA: 0x00149E66 File Offset: 0x00148066
		public void EnableCheats()
		{
			APlayerController.__EnableCheats_Internal(base.NativePtr);
		}

		// Token: 0x0600DFC2 RID: 57282 RVA: 0x00149E74 File Offset: 0x00148074
		public unsafe bool DeprojectScreenPositionToWorld(float ScreenX, float ScreenY, ref FVector WorldLocation, ref FVector WorldDirection)
		{
			fixed (FVector* ptr = &WorldLocation)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &WorldDirection)
				{
					void* ptr4 = (void*)ptr3;
					return APlayerController.__DeprojectScreenPositionToWorld_Internal(base.NativePtr, ScreenX, ScreenY, ref WorldLocation, ref WorldDirection);
				}
			}
		}

		// Token: 0x0600DFC3 RID: 57283 RVA: 0x00149E9C File Offset: 0x0014809C
		public unsafe bool DeprojectMousePositionToWorld(ref FVector WorldLocation, ref FVector WorldDirection)
		{
			fixed (FVector* ptr = &WorldLocation)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &WorldDirection)
				{
					void* ptr4 = (void*)ptr3;
					return APlayerController.__DeprojectMousePositionToWorld_Internal(base.NativePtr, ref WorldLocation, ref WorldDirection);
				}
			}
		}

		// Token: 0x0600DFC4 RID: 57284 RVA: 0x00149EC0 File Offset: 0x001480C0
		public void ConsoleKey(FKey Key)
		{
			APlayerController.__ConsoleKey_Internal(base.NativePtr, (Key ?? new FKey()).NativePtr);
		}

		// Token: 0x0600DFC5 RID: 57285 RVA: 0x00149EDC File Offset: 0x001480DC
		[NullableContext(1)]
		public void ClientWasKicked(in FText KickReason)
		{
			IntPtr nativePtr = base.NativePtr;
			FText ftext = KickReason;
			APlayerController.__ClientWasKicked_Internal(nativePtr, (ftext != null) ? ftext.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600DFC6 RID: 57286 RVA: 0x00149EFB File Offset: 0x001480FB
		public void ClientVoiceHandshakeComplete()
		{
			APlayerController.__ClientVoiceHandshakeComplete_Internal(base.NativePtr);
		}

		// Token: 0x0600DFC7 RID: 57287 RVA: 0x00149F08 File Offset: 0x00148108
		public void ClientUpdateMultipleLevelsStreamingStatus([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FUpdateLevelStreamingLevelStatus> LevelStatuses)
		{
			APlayerController.__ClientUpdateMultipleLevelsStreamingStatus_Internal(base.NativePtr, (LevelStatuses ?? new TArray<FUpdateLevelStreamingLevelStatus>()).NativePtr);
		}

		// Token: 0x0600DFC8 RID: 57288 RVA: 0x00149F25 File Offset: 0x00148125
		public void ClientUpdateLevelStreamingStatus(FName PackageName, bool bNewShouldBeLoaded, bool bNewShouldBeVisible, bool bNewShouldBlockOnLoad, int LODIndex)
		{
			APlayerController.__ClientUpdateLevelStreamingStatus_Internal(base.NativePtr, PackageName, bNewShouldBeLoaded, bNewShouldBeVisible, bNewShouldBlockOnLoad, LODIndex);
		}

		// Token: 0x0600DFC9 RID: 57289 RVA: 0x00149F39 File Offset: 0x00148139
		public void ClientUnmutePlayer(FUniqueNetIdRepl PlayerId)
		{
			APlayerController.__ClientUnmutePlayer_Internal(base.NativePtr, (PlayerId ?? new FUniqueNetIdRepl()).NativePtr);
		}

		// Token: 0x0600DFCA RID: 57290 RVA: 0x00149F58 File Offset: 0x00148158
		[NullableContext(1)]
		public unsafe void ClientTravelInternal(string URL, ETravelType TravelType, bool bSeamless, FGuid MapPackageGuid)
		{
			FString fstring = FString.AllocTemp(URL);
			APlayerController.__ClientTravelInternal_Internal(base.NativePtr, fstring, TravelType, bSeamless, MapPackageGuid);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600DFCB RID: 57291 RVA: 0x00149F8C File Offset: 0x0014818C
		[NullableContext(1)]
		public unsafe void ClientTravel(string URL, ETravelType TravelType, bool bSeamless, FGuid MapPackageGuid)
		{
			FString fstring = FString.AllocTemp(URL);
			APlayerController.__ClientTravel_Internal(base.NativePtr, fstring, TravelType, bSeamless, MapPackageGuid);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600DFCC RID: 57292 RVA: 0x00149FC0 File Offset: 0x001481C0
		[NullableContext(1)]
		public unsafe void ClientTeamMessage([Nullable(2)] APlayerState SenderPlayerState, string S, FName Type, float MsgLifeTime)
		{
			FString fstring = FString.AllocTemp(S);
			APlayerController.__ClientTeamMessage_Internal(base.NativePtr, (SenderPlayerState != null) ? SenderPlayerState.NativePtr : IntPtr.Zero, fstring, Type, MsgLifeTime);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600DFCD RID: 57293 RVA: 0x00149FFD File Offset: 0x001481FD
		public void ClientStopForceFeedback(UForceFeedbackEffect ForceFeedbackEffect, FName Tag)
		{
			APlayerController.__ClientStopForceFeedback_Internal(base.NativePtr, (ForceFeedbackEffect != null) ? ForceFeedbackEffect.NativePtr : IntPtr.Zero, Tag);
		}

		// Token: 0x0600DFCE RID: 57294 RVA: 0x0014A01B File Offset: 0x0014821B
		public void ClientStopCameraShakesFromSource(UCameraShakeSourceComponent SourceComponent, bool bImmediately = true)
		{
			APlayerController.__ClientStopCameraShakesFromSource_Internal(base.NativePtr, (SourceComponent != null) ? SourceComponent.NativePtr : IntPtr.Zero, bImmediately);
		}

		// Token: 0x0600DFCF RID: 57295 RVA: 0x0014A039 File Offset: 0x00148239
		public void ClientStopCameraShake([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase> Shake, bool bImmediately = true)
		{
			APlayerController.__ClientStopCameraShake_Internal(base.NativePtr, Shake._NativePtr, bImmediately);
		}

		// Token: 0x0600DFD0 RID: 57296 RVA: 0x0014A04D File Offset: 0x0014824D
		public void ClientStopCameraAnim(UCameraAnim AnimToStop)
		{
			APlayerController.__ClientStopCameraAnim_Internal(base.NativePtr, (AnimToStop != null) ? AnimToStop.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600DFD1 RID: 57297 RVA: 0x0014A06A File Offset: 0x0014826A
		public void ClientStartOnlineSession()
		{
			APlayerController.__ClientStartOnlineSession_Internal(base.NativePtr);
		}

		// Token: 0x0600DFD2 RID: 57298 RVA: 0x0014A077 File Offset: 0x00148277
		public void ClientStartCameraShakeFromSource([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase> Shake, UCameraShakeSourceComponent SourceComponent)
		{
			APlayerController.__ClientStartCameraShakeFromSource_Internal(base.NativePtr, Shake._NativePtr, (SourceComponent != null) ? SourceComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600DFD3 RID: 57299 RVA: 0x0014A09A File Offset: 0x0014829A
		public void ClientStartCameraShake([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase> Shake, float Scale = 1f, ECameraShakePlaySpace PlaySpace = ECameraShakePlaySpace.CameraLocal, FRotator UserPlaySpaceRot = default(FRotator), float TimeDilation = 1f)
		{
			APlayerController.__ClientStartCameraShake_Internal(base.NativePtr, Shake._NativePtr, Scale, PlaySpace, UserPlaySpaceRot, TimeDilation);
		}

		// Token: 0x0600DFD4 RID: 57300 RVA: 0x0014A0B3 File Offset: 0x001482B3
		public void ClientSpawnCameraLensEffect([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AEmitterCameraLensEffectBase> LensEffectEmitterClass)
		{
			APlayerController.__ClientSpawnCameraLensEffect_Internal(base.NativePtr, LensEffectEmitterClass._NativePtr);
		}

		// Token: 0x0600DFD5 RID: 57301 RVA: 0x0014A0C6 File Offset: 0x001482C6
		public void ClientSetViewTarget(AActor A, FViewTargetTransitionParams TransitionParams)
		{
			APlayerController.__ClientSetViewTarget_Internal(base.NativePtr, (A != null) ? A.NativePtr : IntPtr.Zero, (TransitionParams ?? new FViewTargetTransitionParams()).NativePtr);
		}

		// Token: 0x0600DFD6 RID: 57302 RVA: 0x0014A0F2 File Offset: 0x001482F2
		public void ClientSetSpectatorWaiting(bool bWaiting)
		{
			APlayerController.__ClientSetSpectatorWaiting_Internal(base.NativePtr, bWaiting);
		}

		// Token: 0x0600DFD7 RID: 57303 RVA: 0x0014A100 File Offset: 0x00148300
		public void ClientSetHUD([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AHUD> NewHUDClass)
		{
			APlayerController.__ClientSetHUD_Internal(base.NativePtr, NewHUDClass._NativePtr);
		}

		// Token: 0x0600DFD8 RID: 57304 RVA: 0x0014A113 File Offset: 0x00148313
		public void ClientSetForceMipLevelsToBeResident(UMaterialInterface Material, float ForceDuration, int CinematicTextureGroups)
		{
			APlayerController.__ClientSetForceMipLevelsToBeResident_Internal(base.NativePtr, (Material != null) ? Material.NativePtr : IntPtr.Zero, ForceDuration, CinematicTextureGroups);
		}

		// Token: 0x0600DFD9 RID: 57305 RVA: 0x0014A132 File Offset: 0x00148332
		public void ClientSetCinematicMode(bool bInCinematicMode, bool bAffectsMovement, bool bAffectsTurning, bool bAffectsHUD)
		{
			APlayerController.__ClientSetCinematicMode_Internal(base.NativePtr, bInCinematicMode, bAffectsMovement, bAffectsTurning, bAffectsHUD);
		}

		// Token: 0x0600DFDA RID: 57306 RVA: 0x0014A144 File Offset: 0x00148344
		public void ClientSetCameraMode(FName NewCamMode)
		{
			APlayerController.__ClientSetCameraMode_Internal(base.NativePtr, NewCamMode);
		}

		// Token: 0x0600DFDB RID: 57307 RVA: 0x0014A152 File Offset: 0x00148352
		public void ClientSetCameraFade(bool bEnableFading, FColor FadeColor, FVector2D FadeAlpha, float FadeTime, bool bFadeAudio, bool bHoldWhenFinished)
		{
			APlayerController.__ClientSetCameraFade_Internal(base.NativePtr, bEnableFading, FadeColor, FadeAlpha, FadeTime, bFadeAudio, bHoldWhenFinished);
		}

		// Token: 0x0600DFDC RID: 57308 RVA: 0x0014A168 File Offset: 0x00148368
		public void ClientSetBlockOnAsyncLoading()
		{
			APlayerController.__ClientSetBlockOnAsyncLoading_Internal(base.NativePtr);
		}

		// Token: 0x0600DFDD RID: 57309 RVA: 0x0014A175 File Offset: 0x00148375
		[NullableContext(1)]
		public void ClientReturnToMainMenuWithTextReason(in FText ReturnReason)
		{
			IntPtr nativePtr = base.NativePtr;
			FText ftext = ReturnReason;
			APlayerController.__ClientReturnToMainMenuWithTextReason_Internal(nativePtr, (ftext != null) ? ftext.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600DFDE RID: 57310 RVA: 0x0014A194 File Offset: 0x00148394
		[NullableContext(1)]
		public unsafe void ClientReturnToMainMenu(string ReturnReason)
		{
			FString fstring = FString.AllocTemp(ReturnReason);
			APlayerController.__ClientReturnToMainMenu_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600DFDF RID: 57311 RVA: 0x0014A1BE File Offset: 0x001483BE
		public void ClientRetryClientRestart(APawn NewPawn)
		{
			APlayerController.__ClientRetryClientRestart_Internal(base.NativePtr, (NewPawn != null) ? NewPawn.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600DFE0 RID: 57312 RVA: 0x0014A1DB File Offset: 0x001483DB
		public void ClientRestart(APawn NewPawn)
		{
			APlayerController.__ClientRestart_Internal(base.NativePtr, (NewPawn != null) ? NewPawn.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600DFE1 RID: 57313 RVA: 0x0014A1F8 File Offset: 0x001483F8
		public void ClientReset()
		{
			APlayerController.__ClientReset_Internal(base.NativePtr);
		}

		// Token: 0x0600DFE2 RID: 57314 RVA: 0x0014A205 File Offset: 0x00148405
		public void ClientRepObjRef(UObject Object)
		{
			APlayerController.__ClientRepObjRef_Internal(base.NativePtr, (Object != null) ? Object.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600DFE3 RID: 57315 RVA: 0x0014A224 File Offset: 0x00148424
		public void ClientReceiveLocalizedMessage([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<ULocalMessage> Message, int Switch, APlayerState RelatedPlayerState_1, APlayerState RelatedPlayerState_2, UObject OptionalObject)
		{
			APlayerController.__ClientReceiveLocalizedMessage_Internal(base.NativePtr, Message._NativePtr, Switch, (RelatedPlayerState_1 != null) ? RelatedPlayerState_1.NativePtr : IntPtr.Zero, (RelatedPlayerState_2 != null) ? RelatedPlayerState_2.NativePtr : IntPtr.Zero, (OptionalObject != null) ? OptionalObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600DFE4 RID: 57316 RVA: 0x0014A277 File Offset: 0x00148477
		public void ClientPrestreamTextures(AActor ForcedActor, float ForceDuration, bool bEnableStreaming, int CinematicTextureGroups)
		{
			APlayerController.__ClientPrestreamTextures_Internal(base.NativePtr, (ForcedActor != null) ? ForcedActor.NativePtr : IntPtr.Zero, ForceDuration, bEnableStreaming, CinematicTextureGroups);
		}

		// Token: 0x0600DFE5 RID: 57317 RVA: 0x0014A298 File Offset: 0x00148498
		public void ClientPrepareMapChange(FName LevelName, bool bFirst, bool bLast)
		{
			APlayerController.__ClientPrepareMapChange_Internal(base.NativePtr, LevelName, bFirst, bLast);
		}

		// Token: 0x0600DFE6 RID: 57318 RVA: 0x0014A2A8 File Offset: 0x001484A8
		public void ClientPlaySoundAtLocation(USoundBase Sound, FVector Location, float VolumeMultiplier, float PitchMultiplier)
		{
			APlayerController.__ClientPlaySoundAtLocation_Internal(base.NativePtr, (Sound != null) ? Sound.NativePtr : IntPtr.Zero, Location, VolumeMultiplier, PitchMultiplier);
		}

		// Token: 0x0600DFE7 RID: 57319 RVA: 0x0014A2C9 File Offset: 0x001484C9
		public void ClientPlaySound(USoundBase Sound, float VolumeMultiplier, float PitchMultiplier)
		{
			APlayerController.__ClientPlaySound_Internal(base.NativePtr, (Sound != null) ? Sound.NativePtr : IntPtr.Zero, VolumeMultiplier, PitchMultiplier);
		}

		// Token: 0x0600DFE8 RID: 57320 RVA: 0x0014A2E8 File Offset: 0x001484E8
		public void ClientPlayForceFeedback_Internal(UForceFeedbackEffect ForceFeedbackEffect, FForceFeedbackParameters Params)
		{
			APlayerController.__ClientPlayForceFeedback_Internal_Internal(base.NativePtr, (ForceFeedbackEffect != null) ? ForceFeedbackEffect.NativePtr : IntPtr.Zero, (Params ?? new FForceFeedbackParameters()).NativePtr);
		}

		// Token: 0x0600DFE9 RID: 57321 RVA: 0x0014A314 File Offset: 0x00148514
		public void ClientPlayCameraAnim(UCameraAnim AnimToPlay, float Scale = 1f, float Rate = 1f, float BlendInTime = 0f, float BlendOutTime = 0f, bool bLoop = false, bool bRandomStartTime = false, ECameraShakePlaySpace Space = ECameraShakePlaySpace.CameraLocal, FRotator CustomPlaySpace = default(FRotator))
		{
			APlayerController.__ClientPlayCameraAnim_Internal(base.NativePtr, (AnimToPlay != null) ? AnimToPlay.NativePtr : IntPtr.Zero, Scale, Rate, BlendInTime, BlendOutTime, bLoop, bRandomStartTime, Space, CustomPlaySpace);
		}

		// Token: 0x0600DFEA RID: 57322 RVA: 0x0014A34A File Offset: 0x0014854A
		public void ClientMutePlayer(FUniqueNetIdRepl PlayerId)
		{
			APlayerController.__ClientMutePlayer_Internal(base.NativePtr, (PlayerId ?? new FUniqueNetIdRepl()).NativePtr);
		}

		// Token: 0x0600DFEB RID: 57323 RVA: 0x0014A368 File Offset: 0x00148568
		[NullableContext(1)]
		public unsafe void ClientMessage(string S, FName Type, float MsgLifeTime)
		{
			FString fstring = FString.AllocTemp(S);
			APlayerController.__ClientMessage_Internal(base.NativePtr, fstring, Type, MsgLifeTime);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600DFEC RID: 57324 RVA: 0x0014A394 File Offset: 0x00148594
		public void ClientIgnoreMoveInput(bool bIgnore)
		{
			APlayerController.__ClientIgnoreMoveInput_Internal(base.NativePtr, bIgnore);
		}

		// Token: 0x0600DFED RID: 57325 RVA: 0x0014A3A2 File Offset: 0x001485A2
		public void ClientIgnoreLookInput(bool bIgnore)
		{
			APlayerController.__ClientIgnoreLookInput_Internal(base.NativePtr, bIgnore);
		}

		// Token: 0x0600DFEE RID: 57326 RVA: 0x0014A3B0 File Offset: 0x001485B0
		public void ClientGotoState(FName NewState)
		{
			APlayerController.__ClientGotoState_Internal(base.NativePtr, NewState);
		}

		// Token: 0x0600DFEF RID: 57327 RVA: 0x0014A3BE File Offset: 0x001485BE
		public void ClientGameEnded(AActor EndGameFocus, bool bIsWinner)
		{
			APlayerController.__ClientGameEnded_Internal(base.NativePtr, (EndGameFocus != null) ? EndGameFocus.NativePtr : IntPtr.Zero, bIsWinner);
		}

		// Token: 0x0600DFF0 RID: 57328 RVA: 0x0014A3DC File Offset: 0x001485DC
		public void ClientForceGarbageCollection()
		{
			APlayerController.__ClientForceGarbageCollection_Internal(base.NativePtr);
		}

		// Token: 0x0600DFF1 RID: 57329 RVA: 0x0014A3E9 File Offset: 0x001485E9
		public void ClientFlushLevelStreaming()
		{
			APlayerController.__ClientFlushLevelStreaming_Internal(base.NativePtr);
		}

		// Token: 0x0600DFF2 RID: 57330 RVA: 0x0014A3F6 File Offset: 0x001485F6
		public void ClientEndOnlineSession()
		{
			APlayerController.__ClientEndOnlineSession_Internal(base.NativePtr);
		}

		// Token: 0x0600DFF3 RID: 57331 RVA: 0x0014A403 File Offset: 0x00148603
		public void ClientEnableNetworkVoice(bool bEnable)
		{
			APlayerController.__ClientEnableNetworkVoice_Internal(base.NativePtr, bEnable);
		}

		// Token: 0x0600DFF4 RID: 57332 RVA: 0x0014A411 File Offset: 0x00148611
		public void ClientCommitMapChange()
		{
			APlayerController.__ClientCommitMapChange_Internal(base.NativePtr);
		}

		// Token: 0x0600DFF5 RID: 57333 RVA: 0x0014A41E File Offset: 0x0014861E
		public void ClientClearCameraLensEffects()
		{
			APlayerController.__ClientClearCameraLensEffects_Internal(base.NativePtr);
		}

		// Token: 0x0600DFF6 RID: 57334 RVA: 0x0014A42B File Offset: 0x0014862B
		public void ClientCapBandwidth(int Cap)
		{
			APlayerController.__ClientCapBandwidth_Internal(base.NativePtr, Cap);
		}

		// Token: 0x0600DFF7 RID: 57335 RVA: 0x0014A439 File Offset: 0x00148639
		public void ClientCancelPendingMapChange()
		{
			APlayerController.__ClientCancelPendingMapChange_Internal(base.NativePtr);
		}

		// Token: 0x0600DFF8 RID: 57336 RVA: 0x0014A446 File Offset: 0x00148646
		public void ClientAddTextureStreamingLoc(FVector InLoc, float Duration, bool bOverrideLocation)
		{
			APlayerController.__ClientAddTextureStreamingLoc_Internal(base.NativePtr, InLoc, Duration, bOverrideLocation);
		}

		// Token: 0x0600DFF9 RID: 57337 RVA: 0x0014A456 File Offset: 0x00148656
		public void ClearAudioListenerOverride()
		{
			APlayerController.__ClearAudioListenerOverride_Internal(base.NativePtr);
		}

		// Token: 0x0600DFFA RID: 57338 RVA: 0x0014A463 File Offset: 0x00148663
		public void ClearAudioListenerAttenuationOverride()
		{
			APlayerController.__ClearAudioListenerAttenuationOverride_Internal(base.NativePtr);
		}

		// Token: 0x0600DFFB RID: 57339 RVA: 0x0014A470 File Offset: 0x00148670
		public bool CanRestartPlayer()
		{
			return APlayerController.__CanRestartPlayer_Internal(base.NativePtr);
		}

		// Token: 0x0600DFFC RID: 57340 RVA: 0x0014A47D File Offset: 0x0014867D
		public void Camera(FName NewMode)
		{
			APlayerController.__Camera_Internal(base.NativePtr, NewMode);
		}

		// Token: 0x0600DFFD RID: 57341 RVA: 0x0014A48B File Offset: 0x0014868B
		public void AddYawInput(float Val)
		{
			APlayerController.__AddYawInput_Internal(base.NativePtr, Val);
		}

		// Token: 0x0600DFFE RID: 57342 RVA: 0x0014A499 File Offset: 0x00148699
		public void AddRollInput(float Val)
		{
			APlayerController.__AddRollInput_Internal(base.NativePtr, Val);
		}

		// Token: 0x0600DFFF RID: 57343 RVA: 0x0014A4A7 File Offset: 0x001486A7
		public void AddPitchInput(float Val)
		{
			APlayerController.__AddPitchInput_Internal(base.NativePtr, Val);
		}

		// Token: 0x0600E000 RID: 57344 RVA: 0x0014A4B5 File Offset: 0x001486B5
		public void ActivateTouchInterface(UTouchInterface NewTouchInterface)
		{
			APlayerController.__ActivateTouchInterface_Internal(base.NativePtr, (NewTouchInterface != null) ? NewTouchInterface.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600E001 RID: 57345
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __WasInputKeyJustReleased_Internal(IntPtr @this, IntPtr Key);

		// Token: 0x0600E002 RID: 57346
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __WasInputKeyJustPressed_Internal(IntPtr @this, IntPtr Key);

		// Token: 0x0600E003 RID: 57347
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ToggleSpeaking_Internal(IntPtr @this, bool bInSpeaking);

		// Token: 0x0600E004 RID: 57348
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TestServerLevelVisibilityChange_Internal(IntPtr @this, FName PackageName, FName FileName);

		// Token: 0x0600E005 RID: 57349
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SwitchLevel_Internal(IntPtr @this, in FString URL);

		// Token: 0x0600E006 RID: 57350
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __StreamingSourceShouldBlockOnSlowStreaming_Internal(IntPtr @this);

		// Token: 0x0600E007 RID: 57351
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __StreamingSourceShouldActivate_Internal(IntPtr @this);

		// Token: 0x0600E008 RID: 57352
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopHapticEffect_Internal(IntPtr @this, EControllerHand Hand);

		// Token: 0x0600E009 RID: 57353
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartFire_Internal(IntPtr @this, byte FireModeNum);

		// Token: 0x0600E00A RID: 57354
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnPlayerCameraManager_Internal(IntPtr @this);

		// Token: 0x0600E00B RID: 57355
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVirtualJoystickVisibility_Internal(IntPtr @this, bool bVisible);

		// Token: 0x0600E00C RID: 57356
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetViewTargetWithBlendCurve_Internal(IntPtr @this, IntPtr NewViewTarget, float BlendTime, TEnumAsByte<EViewTargetBlendFunction> BlendFunc, float BlendExp, bool bLockOutgoing, bool bKuroEnableBlend, IntPtr BlendCurve);

		// Token: 0x0600E00D RID: 57357
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetViewTargetWithBlend_Internal(IntPtr @this, IntPtr NewViewTarget, float BlendTime, TEnumAsByte<EViewTargetBlendFunction> BlendFunc, float BlendExp, bool bLockOutgoing, bool bKuroEnableBlend);

		// Token: 0x0600E00E RID: 57358
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetName_Internal(IntPtr @this, in FString S);

		// Token: 0x0600E00F RID: 57359
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMouseLocation_Internal(IntPtr @this, int X, int Y);

		// Token: 0x0600E010 RID: 57360
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMouseCursorWidget_Internal(IntPtr @this, TEnumAsByte<EMouseCursor> Cursor, IntPtr CursorWidget);

		// Token: 0x0600E011 RID: 57361
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHapticsByValue_Internal(IntPtr @this, float Frequency, float Amplitude, EControllerHand Hand);

		// Token: 0x0600E012 RID: 57362
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDisableHaptics_Internal(IntPtr @this, bool bNewDisabled);

		// Token: 0x0600E013 RID: 57363
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetControllerLightColor_Internal(IntPtr @this, FColor Color);

		// Token: 0x0600E014 RID: 57364
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCinematicMode_Internal(IntPtr @this, bool bInCinematicMode, bool bHidePlayer, bool bAffectsHUD, bool bAffectsMovement, bool bAffectsTurning);

		// Token: 0x0600E015 RID: 57365
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAudioListenerOverride_Internal(IntPtr @this, IntPtr AttachToComponent, FVector Location, FRotator Rotation);

		// Token: 0x0600E016 RID: 57366
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAudioListenerAttenuationOverride_Internal(IntPtr @this, IntPtr AttachToComponent, FVector AttenuationLocationOVerride);

		// Token: 0x0600E017 RID: 57367
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerViewSelf_Internal(IntPtr @this, IntPtr TransitionParams);

		// Token: 0x0600E018 RID: 57368
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerViewPrevPlayer_Internal(IntPtr @this);

		// Token: 0x0600E019 RID: 57369
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerViewNextPlayer_Internal(IntPtr @this);

		// Token: 0x0600E01A RID: 57370
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerVerifyViewTarget_Internal(IntPtr @this);

		// Token: 0x0600E01B RID: 57371
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerUpdateMultipleLevelsVisibility_Internal(IntPtr @this, IntPtr LevelVisibilities);

		// Token: 0x0600E01C RID: 57372
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerUpdateLevelVisibility_Internal(IntPtr @this, IntPtr LevelVisibility);

		// Token: 0x0600E01D RID: 57373
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerUpdateCamera_Internal(IntPtr @this, FVector_NetQuantize CamLoc, int CamPitchAndYaw);

		// Token: 0x0600E01E RID: 57374
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerUnmutePlayer_Internal(IntPtr @this, IntPtr PlayerId);

		// Token: 0x0600E01F RID: 57375
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerToggleAILogging_Internal(IntPtr @this);

		// Token: 0x0600E020 RID: 57376
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerShortTimeout_Internal(IntPtr @this);

		// Token: 0x0600E021 RID: 57377
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerSetSpectatorWaiting_Internal(IntPtr @this, bool bWaiting);

		// Token: 0x0600E022 RID: 57378
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerSetSpectatorLocation_Internal(IntPtr @this, FVector NewLoc, FRotator NewRot);

		// Token: 0x0600E023 RID: 57379
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerRestartPlayer_Internal(IntPtr @this);

		// Token: 0x0600E024 RID: 57380
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerPause_Internal(IntPtr @this);

		// Token: 0x0600E025 RID: 57381
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerNotifyLoadedWorld_Internal(IntPtr @this, FName WorldPackageName);

		// Token: 0x0600E026 RID: 57382
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerMutePlayer_Internal(IntPtr @this, IntPtr PlayerId);

		// Token: 0x0600E027 RID: 57383
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerExecRPC_Internal(IntPtr @this, in FString Msg);

		// Token: 0x0600E028 RID: 57384
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerExec_Internal(IntPtr @this, in FString Msg);

		// Token: 0x0600E029 RID: 57385
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerCheckClientPossessionReliable_Internal(IntPtr @this);

		// Token: 0x0600E02A RID: 57386
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerCheckClientPossession_Internal(IntPtr @this);

		// Token: 0x0600E02B RID: 57387
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerChangeName_Internal(IntPtr @this, in FString S);

		// Token: 0x0600E02C RID: 57388
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerCamera_Internal(IntPtr @this, FName NewMode);

		// Token: 0x0600E02D RID: 57389
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerAcknowledgePossession_Internal(IntPtr @this, IntPtr P);

		// Token: 0x0600E02E RID: 57390
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SendToConsole_Internal(IntPtr @this, in FString Command);

		// Token: 0x0600E02F RID: 57391
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RestartLevel_Internal(IntPtr @this);

		// Token: 0x0600E030 RID: 57392
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetControllerLightColor_Internal(IntPtr @this);

		// Token: 0x0600E031 RID: 57393
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveAdditionalPlayerCameraManagers_Internal(IntPtr @this);

		// Token: 0x0600E032 RID: 57394
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ProjectWorldLocationToScreen_Internal(IntPtr @this, FVector WorldLocation, ref FVector2D ScreenLocation, bool bPlayerViewportRelative);

		// Token: 0x0600E033 RID: 57395
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayHapticEffect_Internal(IntPtr @this, IntPtr HapticEffect, EControllerHand Hand, float Scale, bool bLoop);

		// Token: 0x0600E034 RID: 57396
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayDynamicForceFeedback_Internal(IntPtr @this, float Intensity, float Duration, bool bAffectsLeftLarge, bool bAffectsLeftSmall, bool bAffectsRightLarge, bool bAffectsRightSmall, TEnumAsByte<EDynamicForceFeedbackAction> Action, IntPtr LatentInfo);

		// Token: 0x0600E035 RID: 57397
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Pause_Internal(IntPtr @this);

		// Token: 0x0600E036 RID: 57398
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnServerStartedVisualLogger_Internal(IntPtr @this, bool bIsLogging);

		// Token: 0x0600E037 RID: 57399
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LocalTravel_Internal(IntPtr @this, in FString URL);

		// Token: 0x0600E038 RID: 57400
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_ClientTravel_Internal(IntPtr @this, in FString URL, TEnumAsByte<ETravelType> TravelType, bool bSeamless);

		// Token: 0x0600E039 RID: 57401
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_ClientPlayForceFeedback_Internal(IntPtr @this, IntPtr ForceFeedbackEffect, FName Tag, bool bLooping, bool bIgnoreTimeDilation, bool bPlayWhilePaused);

		// Token: 0x0600E03A RID: 57402
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsStreamingSourceEnabled_Internal(IntPtr @this);

		// Token: 0x0600E03B RID: 57403
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsInputKeyDown_Internal(IntPtr @this, IntPtr Key);

		// Token: 0x0600E03C RID: 57404
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetViewportSize_Internal(IntPtr @this, ref int SizeX, ref int SizeY);

		// Token: 0x0600E03D RID: 57405
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetStreamingSourceShapes_Internal(IntPtr @this, IntPtr OutShapes);

		// Token: 0x0600E03E RID: 57406
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EStreamingSourcePriority __GetStreamingSourcePriority_Internal(IntPtr @this);

		// Token: 0x0600E03F RID: 57407
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetStreamingSourceLocationAndRotation_Internal(IntPtr @this, ref FVector OutLocation, ref FRotator OutRotation);

		// Token: 0x0600E040 RID: 57408
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSpectatorPawn_Internal(IntPtr @this);

		// Token: 0x0600E041 RID: 57409
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetPlayerCameraManagerCount_Internal(IntPtr @this);

		// Token: 0x0600E042 RID: 57410
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPlayerCameraManager_Internal(IntPtr @this, int CameraIndex);

		// Token: 0x0600E043 RID: 57411
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetMousePosition_Internal(IntPtr @this, ref float LocationX, ref float LocationY);

		// Token: 0x0600E044 RID: 57412
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetInputVectorKeyState_Internal(IntPtr @this, IntPtr Key);

		// Token: 0x0600E045 RID: 57413
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetInputTouchState_Internal(IntPtr @this, TEnumAsByte<ETouchIndex> FingerIndex, ref float LocationX, ref float LocationY, ref bool bIsCurrentlyPressed);

		// Token: 0x0600E046 RID: 57414
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetInputMouseDelta_Internal(IntPtr @this, ref float DeltaX, ref float DeltaY);

		// Token: 0x0600E047 RID: 57415
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetInputMotionState_Internal(IntPtr @this, ref FVector Tilt, ref FVector RotationRate, ref FVector Gravity, ref FVector Acceleration);

		// Token: 0x0600E048 RID: 57416
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetInputKeyTimeDown_Internal(IntPtr @this, IntPtr Key);

		// Token: 0x0600E049 RID: 57417
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetInputAnalogStickState_Internal(IntPtr @this, TEnumAsByte<EControllerAnalogStick> WhichStick, ref float StickX, ref float StickY);

		// Token: 0x0600E04A RID: 57418
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetInputAnalogKeyState_Internal(IntPtr @this, IntPtr Key);

		// Token: 0x0600E04B RID: 57419
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetHUD_Internal(IntPtr @this);

		// Token: 0x0600E04C RID: 57420
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetHitResultUnderFingerForObjects_Internal(IntPtr @this, TEnumAsByte<ETouchIndex> FingerIndex, IntPtr ObjectTypes, bool bTraceComplex, IntPtr HitResult);

		// Token: 0x0600E04D RID: 57421
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetHitResultUnderFingerByChannel_Internal(IntPtr @this, TEnumAsByte<ETouchIndex> FingerIndex, TEnumAsByte<ETraceTypeQuery> TraceChannel, bool bTraceComplex, IntPtr HitResult);

		// Token: 0x0600E04E RID: 57422
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetHitResultUnderFinger_Internal(IntPtr @this, TEnumAsByte<ETouchIndex> FingerIndex, TEnumAsByte<ECollisionChannel> TraceChannel, bool bTraceComplex, IntPtr HitResult);

		// Token: 0x0600E04F RID: 57423
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetHitResultUnderCursorForObjects_Internal(IntPtr @this, IntPtr ObjectTypes, bool bTraceComplex, IntPtr HitResult);

		// Token: 0x0600E050 RID: 57424
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetHitResultUnderCursorByChannel_Internal(IntPtr @this, TEnumAsByte<ETraceTypeQuery> TraceChannel, bool bTraceComplex, IntPtr HitResult);

		// Token: 0x0600E051 RID: 57425
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetHitResultUnderCursor_Internal(IntPtr @this, TEnumAsByte<ECollisionChannel> TraceChannel, bool bTraceComplex, IntPtr HitResult);

		// Token: 0x0600E052 RID: 57426
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetFocalLocation_Internal(IntPtr @this);

		// Token: 0x0600E053 RID: 57427
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FOV_Internal(IntPtr @this, float NewFOV);

		// Token: 0x0600E054 RID: 57428
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EnableCheats_Internal(IntPtr @this);

		// Token: 0x0600E055 RID: 57429
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DeprojectScreenPositionToWorld_Internal(IntPtr @this, float ScreenX, float ScreenY, ref FVector WorldLocation, ref FVector WorldDirection);

		// Token: 0x0600E056 RID: 57430
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DeprojectMousePositionToWorld_Internal(IntPtr @this, ref FVector WorldLocation, ref FVector WorldDirection);

		// Token: 0x0600E057 RID: 57431
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ConsoleKey_Internal(IntPtr @this, IntPtr Key);

		// Token: 0x0600E058 RID: 57432
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientWasKicked_Internal(IntPtr @this, IntPtr KickReason);

		// Token: 0x0600E059 RID: 57433
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientVoiceHandshakeComplete_Internal(IntPtr @this);

		// Token: 0x0600E05A RID: 57434
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientUpdateMultipleLevelsStreamingStatus_Internal(IntPtr @this, IntPtr LevelStatuses);

		// Token: 0x0600E05B RID: 57435
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientUpdateLevelStreamingStatus_Internal(IntPtr @this, FName PackageName, bool bNewShouldBeLoaded, bool bNewShouldBeVisible, bool bNewShouldBlockOnLoad, int LODIndex);

		// Token: 0x0600E05C RID: 57436
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientUnmutePlayer_Internal(IntPtr @this, IntPtr PlayerId);

		// Token: 0x0600E05D RID: 57437
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientTravelInternal_Internal(IntPtr @this, in FString URL, TEnumAsByte<ETravelType> TravelType, bool bSeamless, FGuid MapPackageGuid);

		// Token: 0x0600E05E RID: 57438
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientTravel_Internal(IntPtr @this, in FString URL, TEnumAsByte<ETravelType> TravelType, bool bSeamless, FGuid MapPackageGuid);

		// Token: 0x0600E05F RID: 57439
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientTeamMessage_Internal(IntPtr @this, IntPtr SenderPlayerState, in FString S, FName Type, float MsgLifeTime);

		// Token: 0x0600E060 RID: 57440
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientStopForceFeedback_Internal(IntPtr @this, IntPtr ForceFeedbackEffect, FName Tag);

		// Token: 0x0600E061 RID: 57441
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientStopCameraShakesFromSource_Internal(IntPtr @this, IntPtr SourceComponent, bool bImmediately);

		// Token: 0x0600E062 RID: 57442
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientStopCameraShake_Internal(IntPtr @this, IntPtr Shake, bool bImmediately);

		// Token: 0x0600E063 RID: 57443
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientStopCameraAnim_Internal(IntPtr @this, IntPtr AnimToStop);

		// Token: 0x0600E064 RID: 57444
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientStartOnlineSession_Internal(IntPtr @this);

		// Token: 0x0600E065 RID: 57445
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientStartCameraShakeFromSource_Internal(IntPtr @this, IntPtr Shake, IntPtr SourceComponent);

		// Token: 0x0600E066 RID: 57446
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientStartCameraShake_Internal(IntPtr @this, IntPtr Shake, float Scale, ECameraShakePlaySpace PlaySpace, FRotator UserPlaySpaceRot, float TimeDilation);

		// Token: 0x0600E067 RID: 57447
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientSpawnCameraLensEffect_Internal(IntPtr @this, IntPtr LensEffectEmitterClass);

		// Token: 0x0600E068 RID: 57448
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientSetViewTarget_Internal(IntPtr @this, IntPtr A, IntPtr TransitionParams);

		// Token: 0x0600E069 RID: 57449
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientSetSpectatorWaiting_Internal(IntPtr @this, bool bWaiting);

		// Token: 0x0600E06A RID: 57450
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientSetHUD_Internal(IntPtr @this, IntPtr NewHUDClass);

		// Token: 0x0600E06B RID: 57451
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientSetForceMipLevelsToBeResident_Internal(IntPtr @this, IntPtr Material, float ForceDuration, int CinematicTextureGroups);

		// Token: 0x0600E06C RID: 57452
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientSetCinematicMode_Internal(IntPtr @this, bool bInCinematicMode, bool bAffectsMovement, bool bAffectsTurning, bool bAffectsHUD);

		// Token: 0x0600E06D RID: 57453
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientSetCameraMode_Internal(IntPtr @this, FName NewCamMode);

		// Token: 0x0600E06E RID: 57454
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientSetCameraFade_Internal(IntPtr @this, bool bEnableFading, FColor FadeColor, FVector2D FadeAlpha, float FadeTime, bool bFadeAudio, bool bHoldWhenFinished);

		// Token: 0x0600E06F RID: 57455
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientSetBlockOnAsyncLoading_Internal(IntPtr @this);

		// Token: 0x0600E070 RID: 57456
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientReturnToMainMenuWithTextReason_Internal(IntPtr @this, IntPtr ReturnReason);

		// Token: 0x0600E071 RID: 57457
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientReturnToMainMenu_Internal(IntPtr @this, in FString ReturnReason);

		// Token: 0x0600E072 RID: 57458
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientRetryClientRestart_Internal(IntPtr @this, IntPtr NewPawn);

		// Token: 0x0600E073 RID: 57459
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientRestart_Internal(IntPtr @this, IntPtr NewPawn);

		// Token: 0x0600E074 RID: 57460
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientReset_Internal(IntPtr @this);

		// Token: 0x0600E075 RID: 57461
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientRepObjRef_Internal(IntPtr @this, IntPtr Object);

		// Token: 0x0600E076 RID: 57462
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientReceiveLocalizedMessage_Internal(IntPtr @this, IntPtr Message, int Switch, IntPtr RelatedPlayerState_1, IntPtr RelatedPlayerState_2, IntPtr OptionalObject);

		// Token: 0x0600E077 RID: 57463
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientPrestreamTextures_Internal(IntPtr @this, IntPtr ForcedActor, float ForceDuration, bool bEnableStreaming, int CinematicTextureGroups);

		// Token: 0x0600E078 RID: 57464
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientPrepareMapChange_Internal(IntPtr @this, FName LevelName, bool bFirst, bool bLast);

		// Token: 0x0600E079 RID: 57465
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientPlaySoundAtLocation_Internal(IntPtr @this, IntPtr Sound, FVector Location, float VolumeMultiplier, float PitchMultiplier);

		// Token: 0x0600E07A RID: 57466
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientPlaySound_Internal(IntPtr @this, IntPtr Sound, float VolumeMultiplier, float PitchMultiplier);

		// Token: 0x0600E07B RID: 57467
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientPlayForceFeedback_Internal_Internal(IntPtr @this, IntPtr ForceFeedbackEffect, IntPtr Params);

		// Token: 0x0600E07C RID: 57468
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientPlayCameraAnim_Internal(IntPtr @this, IntPtr AnimToPlay, float Scale, float Rate, float BlendInTime, float BlendOutTime, bool bLoop, bool bRandomStartTime, ECameraShakePlaySpace Space, FRotator CustomPlaySpace);

		// Token: 0x0600E07D RID: 57469
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientMutePlayer_Internal(IntPtr @this, IntPtr PlayerId);

		// Token: 0x0600E07E RID: 57470
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientMessage_Internal(IntPtr @this, in FString S, FName Type, float MsgLifeTime);

		// Token: 0x0600E07F RID: 57471
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientIgnoreMoveInput_Internal(IntPtr @this, bool bIgnore);

		// Token: 0x0600E080 RID: 57472
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientIgnoreLookInput_Internal(IntPtr @this, bool bIgnore);

		// Token: 0x0600E081 RID: 57473
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientGotoState_Internal(IntPtr @this, FName NewState);

		// Token: 0x0600E082 RID: 57474
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientGameEnded_Internal(IntPtr @this, IntPtr EndGameFocus, bool bIsWinner);

		// Token: 0x0600E083 RID: 57475
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientForceGarbageCollection_Internal(IntPtr @this);

		// Token: 0x0600E084 RID: 57476
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientFlushLevelStreaming_Internal(IntPtr @this);

		// Token: 0x0600E085 RID: 57477
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientEndOnlineSession_Internal(IntPtr @this);

		// Token: 0x0600E086 RID: 57478
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientEnableNetworkVoice_Internal(IntPtr @this, bool bEnable);

		// Token: 0x0600E087 RID: 57479
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientCommitMapChange_Internal(IntPtr @this);

		// Token: 0x0600E088 RID: 57480
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientClearCameraLensEffects_Internal(IntPtr @this);

		// Token: 0x0600E089 RID: 57481
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientCapBandwidth_Internal(IntPtr @this, int Cap);

		// Token: 0x0600E08A RID: 57482
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientCancelPendingMapChange_Internal(IntPtr @this);

		// Token: 0x0600E08B RID: 57483
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientAddTextureStreamingLoc_Internal(IntPtr @this, FVector InLoc, float Duration, bool bOverrideLocation);

		// Token: 0x0600E08C RID: 57484
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearAudioListenerOverride_Internal(IntPtr @this);

		// Token: 0x0600E08D RID: 57485
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearAudioListenerAttenuationOverride_Internal(IntPtr @this);

		// Token: 0x0600E08E RID: 57486
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CanRestartPlayer_Internal(IntPtr @this);

		// Token: 0x0600E08F RID: 57487
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Camera_Internal(IntPtr @this, FName NewMode);

		// Token: 0x0600E090 RID: 57488
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddYawInput_Internal(IntPtr @this, float Val);

		// Token: 0x0600E091 RID: 57489
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddRollInput_Internal(IntPtr @this, float Val);

		// Token: 0x0600E092 RID: 57490
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddPitchInput_Internal(IntPtr @this, float Val);

		// Token: 0x0600E093 RID: 57491
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ActivateTouchInterface_Internal(IntPtr @this, IntPtr NewTouchInterface);

		// Token: 0x0600E094 RID: 57492 RVA: 0x0014A4D2 File Offset: 0x001486D2
		static APlayerController()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PlayerController");
		}

		// Token: 0x0600E095 RID: 57493 RVA: 0x0014A4E0 File Offset: 0x001486E0
		protected APlayerController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400785A RID: 30810
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PlayerController";

		// Token: 0x0400785B RID: 30811
		private static IntPtr _ClassPtr;

		// Token: 0x0400785C RID: 30812
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400785D RID: 30813
		internal static int __PropertyOffset_Player;

		// Token: 0x0400785E RID: 30814
		internal static int __PropertyOffset_AcknowledgedPawn;

		// Token: 0x0400785F RID: 30815
		internal static int __PropertyOffset_ControllingDirTrackInst;

		// Token: 0x04007860 RID: 30816
		internal static int __PropertyOffset_MyHUD;

		// Token: 0x04007861 RID: 30817
		internal static int __PropertyOffset_ChangeRotationOnPossess;

		// Token: 0x04007862 RID: 30818
		internal static byte __PropertyMask_ChangeRotationOnPossess;

		// Token: 0x04007863 RID: 30819
		internal static int __PropertyOffset_PlayerCameraManager;

		// Token: 0x04007864 RID: 30820
		internal static int __PropertyOffset_AdditionalPlayerCameraManagers;

		// Token: 0x04007865 RID: 30821
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<APlayerCameraManager> _AdditionalPlayerCameraManagers;

		// Token: 0x04007866 RID: 30822
		internal static int __PropertyOffset_PlayerCameraManagerClass;

		// Token: 0x04007867 RID: 30823
		internal static int __PropertyOffset_bAutoManageActiveCameraTarget;

		// Token: 0x04007868 RID: 30824
		internal static int __PropertyOffset_TargetViewRotation;

		// Token: 0x04007869 RID: 30825
		internal static int __PropertyOffset_SmoothTargetViewRotationSpeed;

		// Token: 0x0400786A RID: 30826
		internal static int __PropertyOffset_HiddenActors;

		// Token: 0x0400786B RID: 30827
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _HiddenActors;

		// Token: 0x0400786C RID: 30828
		internal static int __PropertyOffset_HiddenPrimitiveComponents;

		// Token: 0x0400786D RID: 30829
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<UPrimitiveComponent>> _HiddenPrimitiveComponents;

		// Token: 0x0400786E RID: 30830
		internal static int __PropertyOffset_LastSpectatorStateSynchTime;

		// Token: 0x0400786F RID: 30831
		internal static int __PropertyOffset_LastSpectatorSyncLocation;

		// Token: 0x04007870 RID: 30832
		internal static int __PropertyOffset_LastSpectatorSyncRotation;

		// Token: 0x04007871 RID: 30833
		internal static int __PropertyOffset_ClientCap;

		// Token: 0x04007872 RID: 30834
		internal static int __PropertyOffset_CheatManager;

		// Token: 0x04007873 RID: 30835
		internal static int __PropertyOffset_CheatClass;

		// Token: 0x04007874 RID: 30836
		internal static int __PropertyOffset_PlayerInput;

		// Token: 0x04007875 RID: 30837
		internal static int __PropertyOffset_ActiveForceFeedbackEffects;

		// Token: 0x04007876 RID: 30838
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FActiveForceFeedbackEffect> _ActiveForceFeedbackEffects;

		// Token: 0x04007877 RID: 30839
		internal static int __PropertyOffset_bPlayerIsWaiting;

		// Token: 0x04007878 RID: 30840
		internal static byte __PropertyMask_bPlayerIsWaiting;

		// Token: 0x04007879 RID: 30841
		internal static int __PropertyOffset_NetPlayerIndex;

		// Token: 0x0400787A RID: 30842
		internal static int __PropertyOffset_PendingSwapConnection;

		// Token: 0x0400787B RID: 30843
		internal static int __PropertyOffset_NetConnection;

		// Token: 0x0400787C RID: 30844
		internal static int __PropertyOffset_InputYawScale;

		// Token: 0x0400787D RID: 30845
		internal static int __PropertyOffset_InputPitchScale;

		// Token: 0x0400787E RID: 30846
		internal static int __PropertyOffset_InputRollScale;

		// Token: 0x0400787F RID: 30847
		internal static int __PropertyOffset_bShowMouseCursor;

		// Token: 0x04007880 RID: 30848
		internal static byte __PropertyMask_bShowMouseCursor;

		// Token: 0x04007881 RID: 30849
		internal static int __PropertyOffset_bEnableClickEvents;

		// Token: 0x04007882 RID: 30850
		internal static byte __PropertyMask_bEnableClickEvents;

		// Token: 0x04007883 RID: 30851
		internal static int __PropertyOffset_bEnableTouchEvents;

		// Token: 0x04007884 RID: 30852
		internal static byte __PropertyMask_bEnableTouchEvents;

		// Token: 0x04007885 RID: 30853
		internal static int __PropertyOffset_bEnableMouseOverEvents;

		// Token: 0x04007886 RID: 30854
		internal static byte __PropertyMask_bEnableMouseOverEvents;

		// Token: 0x04007887 RID: 30855
		internal static int __PropertyOffset_bEnableTouchOverEvents;

		// Token: 0x04007888 RID: 30856
		internal static byte __PropertyMask_bEnableTouchOverEvents;

		// Token: 0x04007889 RID: 30857
		internal static int __PropertyOffset_bForceFeedbackEnabled;

		// Token: 0x0400788A RID: 30858
		internal static byte __PropertyMask_bForceFeedbackEnabled;

		// Token: 0x0400788B RID: 30859
		internal static int __PropertyOffset_bEnableStreamingSource;

		// Token: 0x0400788C RID: 30860
		internal static byte __PropertyMask_bEnableStreamingSource;

		// Token: 0x0400788D RID: 30861
		internal static int __PropertyOffset_bStreamingSourceShouldActivate;

		// Token: 0x0400788E RID: 30862
		internal static byte __PropertyMask_bStreamingSourceShouldActivate;

		// Token: 0x0400788F RID: 30863
		internal static int __PropertyOffset_TargetBehavior;

		// Token: 0x04007890 RID: 30864
		internal static int __PropertyOffset_TargetGrids;

		// Token: 0x04007891 RID: 30865
		private TArray<FName> _TargetGrids;

		// Token: 0x04007892 RID: 30866
		internal static int __PropertyOffset_bStreamingSourceShouldBlockOnSlowStreaming;

		// Token: 0x04007893 RID: 30867
		internal static byte __PropertyMask_bStreamingSourceShouldBlockOnSlowStreaming;

		// Token: 0x04007894 RID: 30868
		internal static int __PropertyOffset_StreamingSourcePriority;

		// Token: 0x04007895 RID: 30869
		internal static int __PropertyOffset_StreamingSourceDebugColor;

		// Token: 0x04007896 RID: 30870
		internal static int __PropertyOffset_StreamingSourceShapes;

		// Token: 0x04007897 RID: 30871
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FStreamingSourceShape> _StreamingSourceShapes;

		// Token: 0x04007898 RID: 30872
		internal static int __PropertyOffset_ForceFeedbackScale;

		// Token: 0x04007899 RID: 30873
		internal static int __PropertyOffset_ClickEventKeys;

		// Token: 0x0400789A RID: 30874
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKey> _ClickEventKeys;

		// Token: 0x0400789B RID: 30875
		internal static int __PropertyOffset_DefaultMouseCursor;

		// Token: 0x0400789C RID: 30876
		internal static int __PropertyOffset_CurrentMouseCursor;

		// Token: 0x0400789D RID: 30877
		internal static int __PropertyOffset_DefaultClickTraceChannel;

		// Token: 0x0400789E RID: 30878
		internal static int __PropertyOffset_CurrentClickTraceChannel;

		// Token: 0x0400789F RID: 30879
		internal static int __PropertyOffset_HitResultTraceDistance;

		// Token: 0x040078A0 RID: 30880
		internal static int __PropertyOffset_SeamlessTravelCount;

		// Token: 0x040078A1 RID: 30881
		internal static int __PropertyOffset_LastCompletedSeamlessTravelCount;

		// Token: 0x040078A2 RID: 30882
		internal static int __PropertyOffset_SeamlessCameraActor;

		// Token: 0x040078A3 RID: 30883
		internal static int __PropertyOffset_bUseSeamlessCameraActor;

		// Token: 0x040078A4 RID: 30884
		internal static byte __PropertyMask_bUseSeamlessCameraActor;

		// Token: 0x040078A5 RID: 30885
		internal static int __PropertyOffset_InactiveStateInputComponent;

		// Token: 0x040078A6 RID: 30886
		internal static int __PropertyOffset_bShouldPerformFullTickWhenPaused;

		// Token: 0x040078A7 RID: 30887
		internal static byte __PropertyMask_bShouldPerformFullTickWhenPaused;

		// Token: 0x040078A8 RID: 30888
		internal static int __PropertyOffset_CurrentTouchInterface;

		// Token: 0x040078A9 RID: 30889
		internal static int __PropertyOffset_SpectatorPawn;

		// Token: 0x040078AA RID: 30890
		internal static int __PropertyOffset_bIsLocalPlayerController;

		// Token: 0x040078AB RID: 30891
		internal static int __PropertyOffset_SpawnLocation;
	}
}
