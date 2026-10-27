using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000975 RID: 2421
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.Controller")]
	[UnrealStructLayout(1168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1168)]
	public abstract class AController : AActor, IUnrealUObject, IUnrealObject, INavAgentInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060088C5 RID: 35013 RVA: 0x000C40D2 File Offset: 0x000C22D2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AController._ClassPtr;
		}

		// Token: 0x060088C6 RID: 35014 RVA: 0x000C40DE File Offset: 0x000C22DE
		int INavAgentInterface.InterfaceOffset()
		{
			return AController.__InterfaceOffset_INavAgentInterface;
		}

		// Token: 0x1700204F RID: 8271
		// (get) Token: 0x060088C7 RID: 35015 RVA: 0x000C40E5 File Offset: 0x000C22E5
		// (set) Token: 0x060088C8 RID: 35016 RVA: 0x000C40F9 File Offset: 0x000C22F9
		public unsafe APlayerState PlayerState
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<APlayerState>(base.NativePtr / (IntPtr)sizeof(void*) + AController.__PropertyOffset_PlayerState);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AController.__PropertyOffset_PlayerState, value);
			}
		}

		// Token: 0x17002050 RID: 8272
		// (get) Token: 0x060088C9 RID: 35017 RVA: 0x000C4110 File Offset: 0x000C2310
		// (set) Token: 0x060088CA RID: 35018 RVA: 0x000C4149 File Offset: 0x000C2349
		[Nullable(1)]
		public FInstigatedAnyDamageSignature OnInstigatedAnyDamage
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FInstigatedAnyDamageSignature result;
				if ((result = this._OnInstigatedAnyDamage) == null)
				{
					result = (this._OnInstigatedAnyDamage = new FInstigatedAnyDamageSignature(base.NativePtr + (IntPtr)AController.__PropertyOffset_OnInstigatedAnyDamage, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AController.__PropertyOffset_OnInstigatedAnyDamage, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002051 RID: 8273
		// (get) Token: 0x060088CB RID: 35019 RVA: 0x000C416A File Offset: 0x000C236A
		// (set) Token: 0x060088CC RID: 35020 RVA: 0x000C417E File Offset: 0x000C237E
		public unsafe FName StateName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AController.__PropertyOffset_StateName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AController.__PropertyOffset_StateName) = value;
			}
		}

		// Token: 0x17002052 RID: 8274
		// (get) Token: 0x060088CD RID: 35021 RVA: 0x000C4193 File Offset: 0x000C2393
		// (set) Token: 0x060088CE RID: 35022 RVA: 0x000C41A7 File Offset: 0x000C23A7
		public unsafe APawn Pawn
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<APawn>(base.NativePtr / (IntPtr)sizeof(void*) + AController.__PropertyOffset_Pawn);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AController.__PropertyOffset_Pawn, value);
			}
		}

		// Token: 0x17002053 RID: 8275
		// (get) Token: 0x060088CF RID: 35023 RVA: 0x000C41BC File Offset: 0x000C23BC
		// (set) Token: 0x060088D0 RID: 35024 RVA: 0x000C41D0 File Offset: 0x000C23D0
		public unsafe ACharacter Character
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ACharacter>(base.NativePtr / (IntPtr)sizeof(void*) + AController.__PropertyOffset_Character);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AController.__PropertyOffset_Character, value);
			}
		}

		// Token: 0x17002054 RID: 8276
		// (get) Token: 0x060088D1 RID: 35025 RVA: 0x000C41E5 File Offset: 0x000C23E5
		// (set) Token: 0x060088D2 RID: 35026 RVA: 0x000C41F9 File Offset: 0x000C23F9
		public unsafe USceneComponent TransformComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AController.__PropertyOffset_TransformComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AController.__PropertyOffset_TransformComponent, value);
			}
		}

		// Token: 0x17002055 RID: 8277
		// (get) Token: 0x060088D3 RID: 35027 RVA: 0x000C420E File Offset: 0x000C240E
		// (set) Token: 0x060088D4 RID: 35028 RVA: 0x000C4222 File Offset: 0x000C2422
		public unsafe FRotator ControlRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AController.__PropertyOffset_ControlRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AController.__PropertyOffset_ControlRotation) = value;
			}
		}

		// Token: 0x17002056 RID: 8278
		// (get) Token: 0x060088D5 RID: 35029 RVA: 0x000C4237 File Offset: 0x000C2437
		// (set) Token: 0x060088D6 RID: 35030 RVA: 0x000C4250 File Offset: 0x000C2450
		public unsafe bool bAttachToPawn
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AController.__PropertyOffset_bAttachToPawn) & AController.__PropertyMask_bAttachToPawn) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AController.__PropertyOffset_bAttachToPawn) = ((*(base.NativePtr + (IntPtr)AController.__PropertyOffset_bAttachToPawn) & ~AController.__PropertyMask_bAttachToPawn) | (value ? AController.__PropertyMask_bAttachToPawn : 0));
			}
		}

		// Token: 0x060088D7 RID: 35031 RVA: 0x000C4280 File Offset: 0x000C2480
		public void UnPossess()
		{
			AController.__UnPossess_Internal(base.NativePtr);
		}

		// Token: 0x060088D8 RID: 35032 RVA: 0x000C428D File Offset: 0x000C248D
		public void StopMovement()
		{
			AController.__StopMovement_Internal(base.NativePtr);
		}

		// Token: 0x060088D9 RID: 35033 RVA: 0x000C429A File Offset: 0x000C249A
		public void SetInitialLocationAndRotation(in FVector NewLocation, in FRotator NewRotation)
		{
			AController.__SetInitialLocationAndRotation_Internal(base.NativePtr, NewLocation, NewRotation);
		}

		// Token: 0x060088DA RID: 35034 RVA: 0x000C42A9 File Offset: 0x000C24A9
		public void SetIgnoreMoveInput(bool bNewMoveInput)
		{
			AController.__SetIgnoreMoveInput_Internal(base.NativePtr, bNewMoveInput);
		}

		// Token: 0x060088DB RID: 35035 RVA: 0x000C42B7 File Offset: 0x000C24B7
		public void SetIgnoreLookInput(bool bNewLookInput)
		{
			AController.__SetIgnoreLookInput_Internal(base.NativePtr, bNewLookInput);
		}

		// Token: 0x060088DC RID: 35036 RVA: 0x000C42C5 File Offset: 0x000C24C5
		public void SetControlRotation(in FRotator NewRotation)
		{
			AController.__SetControlRotation_Internal(base.NativePtr, NewRotation);
		}

		// Token: 0x060088DD RID: 35037 RVA: 0x000C42D3 File Offset: 0x000C24D3
		public void ResetIgnoreMoveInput()
		{
			AController.__ResetIgnoreMoveInput_Internal(base.NativePtr);
		}

		// Token: 0x060088DE RID: 35038 RVA: 0x000C42E0 File Offset: 0x000C24E0
		public void ResetIgnoreLookInput()
		{
			AController.__ResetIgnoreLookInput_Internal(base.NativePtr);
		}

		// Token: 0x060088DF RID: 35039 RVA: 0x000C42ED File Offset: 0x000C24ED
		public void ResetIgnoreInputFlags()
		{
			AController.__ResetIgnoreInputFlags_Internal(base.NativePtr);
		}

		// Token: 0x060088E0 RID: 35040 RVA: 0x000C42FA File Offset: 0x000C24FA
		public virtual void ReceiveUnPossess(APawn UnpossessedPawn)
		{
			AController.__ReceiveUnPossess_Internal(base.NativePtr, (UnpossessedPawn != null) ? UnpossessedPawn.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060088E1 RID: 35041 RVA: 0x000C4317 File Offset: 0x000C2517
		public virtual void ReceivePossess(APawn PossessedPawn)
		{
			AController.__ReceivePossess_Internal(base.NativePtr, (PossessedPawn != null) ? PossessedPawn.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060088E2 RID: 35042 RVA: 0x000C4334 File Offset: 0x000C2534
		public virtual void ReceiveInstigatedAnyDamage(float Damage, UDamageType DamageType, AActor DamagedActor, AActor DamageCauser)
		{
			AController.__ReceiveInstigatedAnyDamage_Internal(base.NativePtr, Damage, (DamageType != null) ? DamageType.NativePtr : IntPtr.Zero, (DamagedActor != null) ? DamagedActor.NativePtr : IntPtr.Zero, (DamageCauser != null) ? DamageCauser.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060088E3 RID: 35043 RVA: 0x000C4374 File Offset: 0x000C2574
		public void Possess(APawn InPawn)
		{
			AController.__Possess_Internal(base.NativePtr, (InPawn != null) ? InPawn.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060088E4 RID: 35044 RVA: 0x000C4391 File Offset: 0x000C2591
		public void OnRep_PlayerState()
		{
			AController.__OnRep_PlayerState_Internal(base.NativePtr);
		}

		// Token: 0x060088E5 RID: 35045 RVA: 0x000C439E File Offset: 0x000C259E
		public void OnRep_Pawn()
		{
			AController.__OnRep_Pawn_Internal(base.NativePtr);
		}

		// Token: 0x060088E6 RID: 35046 RVA: 0x000C43AB File Offset: 0x000C25AB
		public bool LineOfSightTo(AActor Other, FVector ViewPoint = default(FVector), bool bAlternateChecks = false)
		{
			return AController.__LineOfSightTo_Internal(base.NativePtr, (Other != null) ? Other.NativePtr : IntPtr.Zero, ViewPoint, bAlternateChecks);
		}

		// Token: 0x060088E7 RID: 35047 RVA: 0x000C43CA File Offset: 0x000C25CA
		public APawn K2_GetPawn()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(AController.__K2_GetPawn_Internal(base.NativePtr));
		}

		// Token: 0x060088E8 RID: 35048 RVA: 0x000C43DC File Offset: 0x000C25DC
		public bool IsPlayerController()
		{
			return AController.__IsPlayerController_Internal(base.NativePtr);
		}

		// Token: 0x060088E9 RID: 35049 RVA: 0x000C43E9 File Offset: 0x000C25E9
		public bool IsMoveInputIgnored()
		{
			return AController.__IsMoveInputIgnored_Internal(base.NativePtr);
		}

		// Token: 0x060088EA RID: 35050 RVA: 0x000C43F6 File Offset: 0x000C25F6
		public bool IsLookInputIgnored()
		{
			return AController.__IsLookInputIgnored_Internal(base.NativePtr);
		}

		// Token: 0x060088EB RID: 35051 RVA: 0x000C4403 File Offset: 0x000C2603
		public bool IsLocalPlayerController()
		{
			return AController.__IsLocalPlayerController_Internal(base.NativePtr);
		}

		// Token: 0x060088EC RID: 35052 RVA: 0x000C4410 File Offset: 0x000C2610
		public bool IsLocalController()
		{
			return AController.__IsLocalController_Internal(base.NativePtr);
		}

		// Token: 0x060088ED RID: 35053 RVA: 0x000C441D File Offset: 0x000C261D
		public AActor GetViewTarget()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(AController.__GetViewTarget_Internal(base.NativePtr));
		}

		// Token: 0x060088EE RID: 35054 RVA: 0x000C442F File Offset: 0x000C262F
		public FRotator GetDesiredRotation()
		{
			return AController.__GetDesiredRotation_Internal(base.NativePtr);
		}

		// Token: 0x060088EF RID: 35055 RVA: 0x000C443C File Offset: 0x000C263C
		public FRotator GetControlRotation()
		{
			return AController.__GetControlRotation_Internal(base.NativePtr);
		}

		// Token: 0x060088F0 RID: 35056 RVA: 0x000C4449 File Offset: 0x000C2649
		public void ClientSetRotation(FRotator NewRotation, bool bResetCamera)
		{
			AController.__ClientSetRotation_Internal(base.NativePtr, NewRotation, bResetCamera);
		}

		// Token: 0x060088F1 RID: 35057 RVA: 0x000C4458 File Offset: 0x000C2658
		public void ClientSetLocation(FVector NewLocation, FRotator NewRotation)
		{
			AController.__ClientSetLocation_Internal(base.NativePtr, NewLocation, NewRotation);
		}

		// Token: 0x060088F2 RID: 35058 RVA: 0x000C4467 File Offset: 0x000C2667
		public APlayerController CastToPlayerController()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APlayerController>(AController.__CastToPlayerController_Internal(base.NativePtr));
		}

		// Token: 0x060088F3 RID: 35059
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnPossess_Internal(IntPtr @this);

		// Token: 0x060088F4 RID: 35060
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopMovement_Internal(IntPtr @this);

		// Token: 0x060088F5 RID: 35061
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInitialLocationAndRotation_Internal(IntPtr @this, in FVector NewLocation, in FRotator NewRotation);

		// Token: 0x060088F6 RID: 35062
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIgnoreMoveInput_Internal(IntPtr @this, bool bNewMoveInput);

		// Token: 0x060088F7 RID: 35063
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIgnoreLookInput_Internal(IntPtr @this, bool bNewLookInput);

		// Token: 0x060088F8 RID: 35064
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetControlRotation_Internal(IntPtr @this, in FRotator NewRotation);

		// Token: 0x060088F9 RID: 35065
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetIgnoreMoveInput_Internal(IntPtr @this);

		// Token: 0x060088FA RID: 35066
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetIgnoreLookInput_Internal(IntPtr @this);

		// Token: 0x060088FB RID: 35067
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetIgnoreInputFlags_Internal(IntPtr @this);

		// Token: 0x060088FC RID: 35068
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveUnPossess_Internal(IntPtr @this, IntPtr UnpossessedPawn);

		// Token: 0x060088FD RID: 35069
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceivePossess_Internal(IntPtr @this, IntPtr PossessedPawn);

		// Token: 0x060088FE RID: 35070
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveInstigatedAnyDamage_Internal(IntPtr @this, float Damage, IntPtr DamageType, IntPtr DamagedActor, IntPtr DamageCauser);

		// Token: 0x060088FF RID: 35071
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Possess_Internal(IntPtr @this, IntPtr InPawn);

		// Token: 0x06008900 RID: 35072
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_PlayerState_Internal(IntPtr @this);

		// Token: 0x06008901 RID: 35073
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_Pawn_Internal(IntPtr @this);

		// Token: 0x06008902 RID: 35074
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __LineOfSightTo_Internal(IntPtr @this, IntPtr Other, FVector ViewPoint, bool bAlternateChecks);

		// Token: 0x06008903 RID: 35075
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __K2_GetPawn_Internal(IntPtr @this);

		// Token: 0x06008904 RID: 35076
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPlayerController_Internal(IntPtr @this);

		// Token: 0x06008905 RID: 35077
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsMoveInputIgnored_Internal(IntPtr @this);

		// Token: 0x06008906 RID: 35078
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsLookInputIgnored_Internal(IntPtr @this);

		// Token: 0x06008907 RID: 35079
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsLocalPlayerController_Internal(IntPtr @this);

		// Token: 0x06008908 RID: 35080
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsLocalController_Internal(IntPtr @this);

		// Token: 0x06008909 RID: 35081
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetViewTarget_Internal(IntPtr @this);

		// Token: 0x0600890A RID: 35082
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __GetDesiredRotation_Internal(IntPtr @this);

		// Token: 0x0600890B RID: 35083
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __GetControlRotation_Internal(IntPtr @this);

		// Token: 0x0600890C RID: 35084
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientSetRotation_Internal(IntPtr @this, FRotator NewRotation, bool bResetCamera);

		// Token: 0x0600890D RID: 35085
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientSetLocation_Internal(IntPtr @this, FVector NewLocation, FRotator NewRotation);

		// Token: 0x0600890E RID: 35086
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CastToPlayerController_Internal(IntPtr @this);

		// Token: 0x0600890F RID: 35087 RVA: 0x000C4479 File Offset: 0x000C2679
		static AController()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Controller");
		}

		// Token: 0x06008910 RID: 35088 RVA: 0x000C4488 File Offset: 0x000C2688
		protected AController() : this(BuiltinUtils.AllocNativeUObject(AController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008911 RID: 35089 RVA: 0x000C44B0 File Offset: 0x000C26B0
		protected AController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400410D RID: 16653
		internal static int __InterfaceOffset_INavAgentInterface;

		// Token: 0x0400410E RID: 16654
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.Controller";

		// Token: 0x0400410F RID: 16655
		private static IntPtr _ClassPtr;

		// Token: 0x04004110 RID: 16656
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004111 RID: 16657
		internal static int __PropertyOffset_PlayerState;

		// Token: 0x04004112 RID: 16658
		internal static int __PropertyOffset_OnInstigatedAnyDamage;

		// Token: 0x04004113 RID: 16659
		private FInstigatedAnyDamageSignature _OnInstigatedAnyDamage;

		// Token: 0x04004114 RID: 16660
		internal static int __PropertyOffset_StateName;

		// Token: 0x04004115 RID: 16661
		internal static int __PropertyOffset_Pawn;

		// Token: 0x04004116 RID: 16662
		internal static int __PropertyOffset_Character;

		// Token: 0x04004117 RID: 16663
		internal static int __PropertyOffset_TransformComponent;

		// Token: 0x04004118 RID: 16664
		internal static int __PropertyOffset_ControlRotation;

		// Token: 0x04004119 RID: 16665
		internal static int __PropertyOffset_bAttachToPawn;

		// Token: 0x0400411A RID: 16666
		internal static byte __PropertyMask_bAttachToPawn;

		// Token: 0x02002CE1 RID: 11489
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ReceiveUnPossess_FunctionParams
		{
			// Token: 0x0401668F RID: 91791
			[FieldOffset(0)]
			public IntPtr UnpossessedPawn;
		}

		// Token: 0x02002CE2 RID: 11490
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ReceivePossess_FunctionParams
		{
			// Token: 0x04016690 RID: 91792
			[FieldOffset(0)]
			public IntPtr PossessedPawn;
		}

		// Token: 0x02002CE3 RID: 11491
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __ReceiveInstigatedAnyDamage_FunctionParams
		{
			// Token: 0x04016691 RID: 91793
			[FieldOffset(0)]
			public float Damage;

			// Token: 0x04016692 RID: 91794
			[FieldOffset(8)]
			public IntPtr DamageType;

			// Token: 0x04016693 RID: 91795
			[FieldOffset(16)]
			public IntPtr DamagedActor;

			// Token: 0x04016694 RID: 91796
			[FieldOffset(24)]
			public IntPtr DamageCauser;
		}
	}
}
