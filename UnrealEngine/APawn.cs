using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FCF RID: 4047
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.Pawn")]
	[UnrealStructLayout(1136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1136)]
	public class APawn : AActor, IUnrealUObject, IUnrealObject, INavAgentInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0600DA4C RID: 55884 RVA: 0x00142219 File Offset: 0x00140419
		public new static UClassStackOnlyPtr StaticClass()
		{
			return APawn._ClassPtr;
		}

		// Token: 0x0600DA4D RID: 55885 RVA: 0x00142225 File Offset: 0x00140425
		int INavAgentInterface.InterfaceOffset()
		{
			return APawn.__InterfaceOffset_INavAgentInterface;
		}

		// Token: 0x0600DA4E RID: 55886 RVA: 0x0014222C File Offset: 0x0014042C
		public APawn() : this(BuiltinUtils.AllocNativeUObject(APawn.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600DA4F RID: 55887 RVA: 0x00142254 File Offset: 0x00140454
		[NullableContext(1)]
		public APawn(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(APawn.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700338A RID: 13194
		// (get) Token: 0x0600DA50 RID: 55888 RVA: 0x00142287 File Offset: 0x00140487
		// (set) Token: 0x0600DA51 RID: 55889 RVA: 0x001422A0 File Offset: 0x001404A0
		public unsafe bool bUseControllerRotationPitch
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APawn.__PropertyOffset_bUseControllerRotationPitch) & APawn.__PropertyMask_bUseControllerRotationPitch) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APawn.__PropertyOffset_bUseControllerRotationPitch) = ((*(base.NativePtr + (IntPtr)APawn.__PropertyOffset_bUseControllerRotationPitch) & ~APawn.__PropertyMask_bUseControllerRotationPitch) | (value ? APawn.__PropertyMask_bUseControllerRotationPitch : 0));
			}
		}

		// Token: 0x1700338B RID: 13195
		// (get) Token: 0x0600DA52 RID: 55890 RVA: 0x001422D0 File Offset: 0x001404D0
		// (set) Token: 0x0600DA53 RID: 55891 RVA: 0x001422E9 File Offset: 0x001404E9
		public unsafe bool bUseControllerRotationYaw
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APawn.__PropertyOffset_bUseControllerRotationYaw) & APawn.__PropertyMask_bUseControllerRotationYaw) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APawn.__PropertyOffset_bUseControllerRotationYaw) = ((*(base.NativePtr + (IntPtr)APawn.__PropertyOffset_bUseControllerRotationYaw) & ~APawn.__PropertyMask_bUseControllerRotationYaw) | (value ? APawn.__PropertyMask_bUseControllerRotationYaw : 0));
			}
		}

		// Token: 0x1700338C RID: 13196
		// (get) Token: 0x0600DA54 RID: 55892 RVA: 0x00142319 File Offset: 0x00140519
		// (set) Token: 0x0600DA55 RID: 55893 RVA: 0x00142332 File Offset: 0x00140532
		public unsafe bool bUseControllerRotationRoll
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APawn.__PropertyOffset_bUseControllerRotationRoll) & APawn.__PropertyMask_bUseControllerRotationRoll) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APawn.__PropertyOffset_bUseControllerRotationRoll) = ((*(base.NativePtr + (IntPtr)APawn.__PropertyOffset_bUseControllerRotationRoll) & ~APawn.__PropertyMask_bUseControllerRotationRoll) | (value ? APawn.__PropertyMask_bUseControllerRotationRoll : 0));
			}
		}

		// Token: 0x1700338D RID: 13197
		// (get) Token: 0x0600DA56 RID: 55894 RVA: 0x00142362 File Offset: 0x00140562
		// (set) Token: 0x0600DA57 RID: 55895 RVA: 0x0014237B File Offset: 0x0014057B
		public unsafe bool bCanAffectNavigationGeneration
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APawn.__PropertyOffset_bCanAffectNavigationGeneration) & APawn.__PropertyMask_bCanAffectNavigationGeneration) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APawn.__PropertyOffset_bCanAffectNavigationGeneration) = ((*(base.NativePtr + (IntPtr)APawn.__PropertyOffset_bCanAffectNavigationGeneration) & ~APawn.__PropertyMask_bCanAffectNavigationGeneration) | (value ? APawn.__PropertyMask_bCanAffectNavigationGeneration : 0));
			}
		}

		// Token: 0x1700338E RID: 13198
		// (get) Token: 0x0600DA58 RID: 55896 RVA: 0x001423AB File Offset: 0x001405AB
		// (set) Token: 0x0600DA59 RID: 55897 RVA: 0x001423BB File Offset: 0x001405BB
		public unsafe float BaseEyeHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APawn.__PropertyOffset_BaseEyeHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APawn.__PropertyOffset_BaseEyeHeight) = value;
			}
		}

		// Token: 0x1700338F RID: 13199
		// (get) Token: 0x0600DA5A RID: 55898 RVA: 0x001423CC File Offset: 0x001405CC
		// (set) Token: 0x0600DA5B RID: 55899 RVA: 0x001423E0 File Offset: 0x001405E0
		[Nullable(0)]
		public unsafe TEnumAsByte<EAutoReceiveInput> AutoPossessPlayer
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)APawn.__PropertyOffset_AutoPossessPlayer);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)APawn.__PropertyOffset_AutoPossessPlayer) = value;
			}
		}

		// Token: 0x17003390 RID: 13200
		// (get) Token: 0x0600DA5C RID: 55900 RVA: 0x001423F5 File Offset: 0x001405F5
		// (set) Token: 0x0600DA5D RID: 55901 RVA: 0x00142405 File Offset: 0x00140605
		public unsafe EAutoPossessAI AutoPossessAI
		{
			get
			{
				return (EAutoPossessAI)(*(base.NativePtr + (IntPtr)APawn.__PropertyOffset_AutoPossessAI));
			}
			set
			{
				*(base.NativePtr + (IntPtr)APawn.__PropertyOffset_AutoPossessAI) = (byte)value;
			}
		}

		// Token: 0x17003391 RID: 13201
		// (get) Token: 0x0600DA5E RID: 55902 RVA: 0x00142416 File Offset: 0x00140616
		// (set) Token: 0x0600DA5F RID: 55903 RVA: 0x00142426 File Offset: 0x00140626
		public unsafe byte RemoteViewPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APawn.__PropertyOffset_RemoteViewPitch);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APawn.__PropertyOffset_RemoteViewPitch) = value;
			}
		}

		// Token: 0x17003392 RID: 13202
		// (get) Token: 0x0600DA60 RID: 55904 RVA: 0x00142437 File Offset: 0x00140637
		// (set) Token: 0x0600DA61 RID: 55905 RVA: 0x0014244B File Offset: 0x0014064B
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<AController> AIControllerClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)APawn.__PropertyOffset_AIControllerClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)APawn.__PropertyOffset_AIControllerClass) = value;
			}
		}

		// Token: 0x17003393 RID: 13203
		// (get) Token: 0x0600DA62 RID: 55906 RVA: 0x00142460 File Offset: 0x00140660
		// (set) Token: 0x0600DA63 RID: 55907 RVA: 0x00142474 File Offset: 0x00140674
		public unsafe APlayerState PlayerState
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<APlayerState>(base.NativePtr / (IntPtr)sizeof(void*) + APawn.__PropertyOffset_PlayerState);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + APawn.__PropertyOffset_PlayerState, value);
			}
		}

		// Token: 0x17003394 RID: 13204
		// (get) Token: 0x0600DA64 RID: 55908 RVA: 0x00142489 File Offset: 0x00140689
		// (set) Token: 0x0600DA65 RID: 55909 RVA: 0x0014249D File Offset: 0x0014069D
		public unsafe AController LastHitBy
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AController>(base.NativePtr / (IntPtr)sizeof(void*) + APawn.__PropertyOffset_LastHitBy);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + APawn.__PropertyOffset_LastHitBy, value);
			}
		}

		// Token: 0x17003395 RID: 13205
		// (get) Token: 0x0600DA66 RID: 55910 RVA: 0x001424B2 File Offset: 0x001406B2
		// (set) Token: 0x0600DA67 RID: 55911 RVA: 0x001424C6 File Offset: 0x001406C6
		public unsafe AController Controller
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AController>(base.NativePtr / (IntPtr)sizeof(void*) + APawn.__PropertyOffset_Controller);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + APawn.__PropertyOffset_Controller, value);
			}
		}

		// Token: 0x17003396 RID: 13206
		// (get) Token: 0x0600DA68 RID: 55912 RVA: 0x001424DB File Offset: 0x001406DB
		// (set) Token: 0x0600DA69 RID: 55913 RVA: 0x001424EF File Offset: 0x001406EF
		public unsafe FVector ControlInputVector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APawn.__PropertyOffset_ControlInputVector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APawn.__PropertyOffset_ControlInputVector) = value;
			}
		}

		// Token: 0x17003397 RID: 13207
		// (get) Token: 0x0600DA6A RID: 55914 RVA: 0x00142504 File Offset: 0x00140704
		// (set) Token: 0x0600DA6B RID: 55915 RVA: 0x00142518 File Offset: 0x00140718
		public unsafe FVector LastControlInputVector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APawn.__PropertyOffset_LastControlInputVector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APawn.__PropertyOffset_LastControlInputVector) = value;
			}
		}

		// Token: 0x0600DA6C RID: 55916 RVA: 0x0014252D File Offset: 0x0014072D
		public void SpawnDefaultController()
		{
			APawn.__SpawnDefaultController_Internal(base.NativePtr);
		}

		// Token: 0x0600DA6D RID: 55917 RVA: 0x0014253A File Offset: 0x0014073A
		public void SetCanAffectNavigationGeneration(bool bNewValue, bool bForceUpdate = false)
		{
			APawn.__SetCanAffectNavigationGeneration_Internal(base.NativePtr, bNewValue, bForceUpdate);
		}

		// Token: 0x0600DA6E RID: 55918 RVA: 0x00142549 File Offset: 0x00140749
		public virtual void ReceiveUnpossessed(AController OldController)
		{
			APawn.__ReceiveUnpossessed_Internal(base.NativePtr, (OldController != null) ? OldController.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600DA6F RID: 55919 RVA: 0x00142566 File Offset: 0x00140766
		public virtual void ReceivePossessed(AController NewController)
		{
			APawn.__ReceivePossessed_Internal(base.NativePtr, (NewController != null) ? NewController.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600DA70 RID: 55920 RVA: 0x00142583 File Offset: 0x00140783
		public void PawnMakeNoise(float Loudness, FVector NoiseLocation, bool bUseNoiseMakerLocation = true, AActor NoiseMaker = null)
		{
			APawn.__PawnMakeNoise_Internal(base.NativePtr, Loudness, NoiseLocation, bUseNoiseMakerLocation, (NoiseMaker != null) ? NoiseMaker.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600DA71 RID: 55921 RVA: 0x001425A5 File Offset: 0x001407A5
		public void OnRep_PlayerState()
		{
			APawn.__OnRep_PlayerState_Internal(base.NativePtr);
		}

		// Token: 0x0600DA72 RID: 55922 RVA: 0x001425B2 File Offset: 0x001407B2
		public void OnRep_Controller()
		{
			APawn.__OnRep_Controller_Internal(base.NativePtr);
		}

		// Token: 0x0600DA73 RID: 55923 RVA: 0x001425BF File Offset: 0x001407BF
		public void LaunchPawn(FVector LaunchVelocity, bool bXYOverride, bool bZOverride)
		{
			APawn.__LaunchPawn_Internal(base.NativePtr, LaunchVelocity, bXYOverride, bZOverride);
		}

		// Token: 0x0600DA74 RID: 55924 RVA: 0x001425CF File Offset: 0x001407CF
		public FVector K2_GetMovementInputVector()
		{
			return APawn.__K2_GetMovementInputVector_Internal(base.NativePtr);
		}

		// Token: 0x0600DA75 RID: 55925 RVA: 0x001425DC File Offset: 0x001407DC
		public bool IsPlayerControlled()
		{
			return APawn.__IsPlayerControlled_Internal(base.NativePtr);
		}

		// Token: 0x0600DA76 RID: 55926 RVA: 0x001425E9 File Offset: 0x001407E9
		public bool IsPawnControlled()
		{
			return APawn.__IsPawnControlled_Internal(base.NativePtr);
		}

		// Token: 0x0600DA77 RID: 55927 RVA: 0x001425F6 File Offset: 0x001407F6
		public bool IsMoveInputIgnored()
		{
			return APawn.__IsMoveInputIgnored_Internal(base.NativePtr);
		}

		// Token: 0x0600DA78 RID: 55928 RVA: 0x00142603 File Offset: 0x00140803
		public bool IsLocallyControlled()
		{
			return APawn.__IsLocallyControlled_Internal(base.NativePtr);
		}

		// Token: 0x0600DA79 RID: 55929 RVA: 0x00142610 File Offset: 0x00140810
		public bool IsControlled()
		{
			return APawn.__IsControlled_Internal(base.NativePtr);
		}

		// Token: 0x0600DA7A RID: 55930 RVA: 0x0014261D File Offset: 0x0014081D
		public bool IsBotControlled()
		{
			return APawn.__IsBotControlled_Internal(base.NativePtr);
		}

		// Token: 0x0600DA7B RID: 55931 RVA: 0x0014262A File Offset: 0x0014082A
		public FVector GetPendingMovementInputVector()
		{
			return APawn.__GetPendingMovementInputVector_Internal(base.NativePtr);
		}

		// Token: 0x0600DA7C RID: 55932 RVA: 0x00142637 File Offset: 0x00140837
		public FVector GetNavAgentLocation()
		{
			return APawn.__GetNavAgentLocation_Internal(base.NativePtr);
		}

		// Token: 0x0600DA7D RID: 55933 RVA: 0x00142644 File Offset: 0x00140844
		public UPawnMovementComponent GetMovementComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UPawnMovementComponent>(APawn.__GetMovementComponent_Internal(base.NativePtr));
		}

		// Token: 0x0600DA7E RID: 55934 RVA: 0x00142656 File Offset: 0x00140856
		public static AActor GetMovementBaseActor(APawn Pawn)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(APawn.__GetMovementBaseActor_Internal((Pawn != null) ? Pawn.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0600DA7F RID: 55935 RVA: 0x00142672 File Offset: 0x00140872
		public FVector GetLastMovementInputVector()
		{
			return APawn.__GetLastMovementInputVector_Internal(base.NativePtr);
		}

		// Token: 0x0600DA80 RID: 55936 RVA: 0x0014267F File Offset: 0x0014087F
		public FRotator GetControlRotation()
		{
			return APawn.__GetControlRotation_Internal(base.NativePtr);
		}

		// Token: 0x0600DA81 RID: 55937 RVA: 0x0014268C File Offset: 0x0014088C
		public AController GetController()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AController>(APawn.__GetController_Internal(base.NativePtr));
		}

		// Token: 0x0600DA82 RID: 55938 RVA: 0x0014269E File Offset: 0x0014089E
		public FRotator GetBaseAimRotation()
		{
			return APawn.__GetBaseAimRotation_Internal(base.NativePtr);
		}

		// Token: 0x0600DA83 RID: 55939 RVA: 0x001426AB File Offset: 0x001408AB
		public void DetachFromControllerPendingDestroy()
		{
			APawn.__DetachFromControllerPendingDestroy_Internal(base.NativePtr);
		}

		// Token: 0x0600DA84 RID: 55940 RVA: 0x001426B8 File Offset: 0x001408B8
		public void D_AddMovementInput(FVectorDouble WorldDirection, float ScaleValue = 1f, bool bForce = false)
		{
			APawn.__D_AddMovementInput_Internal(base.NativePtr, WorldDirection, ScaleValue, bForce);
		}

		// Token: 0x0600DA85 RID: 55941 RVA: 0x001426C8 File Offset: 0x001408C8
		public FVector ConsumeMovementInputVector()
		{
			return APawn.__ConsumeMovementInputVector_Internal(base.NativePtr);
		}

		// Token: 0x0600DA86 RID: 55942 RVA: 0x001426D5 File Offset: 0x001408D5
		public void AddMovementInput(FVector WorldDirection, float ScaleValue = 1f, bool bForce = false)
		{
			APawn.__AddMovementInput_Internal(base.NativePtr, WorldDirection, ScaleValue, bForce);
		}

		// Token: 0x0600DA87 RID: 55943 RVA: 0x001426E5 File Offset: 0x001408E5
		public void AddControllerYawInput(float Val)
		{
			APawn.__AddControllerYawInput_Internal(base.NativePtr, Val);
		}

		// Token: 0x0600DA88 RID: 55944 RVA: 0x001426F3 File Offset: 0x001408F3
		public void AddControllerRollInput(float Val)
		{
			APawn.__AddControllerRollInput_Internal(base.NativePtr, Val);
		}

		// Token: 0x0600DA89 RID: 55945 RVA: 0x00142701 File Offset: 0x00140901
		public void AddControllerPitchInput(float Val)
		{
			APawn.__AddControllerPitchInput_Internal(base.NativePtr, Val);
		}

		// Token: 0x0600DA8A RID: 55946
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SpawnDefaultController_Internal(IntPtr @this);

		// Token: 0x0600DA8B RID: 55947
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCanAffectNavigationGeneration_Internal(IntPtr @this, bool bNewValue, bool bForceUpdate);

		// Token: 0x0600DA8C RID: 55948
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveUnpossessed_Internal(IntPtr @this, IntPtr OldController);

		// Token: 0x0600DA8D RID: 55949
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceivePossessed_Internal(IntPtr @this, IntPtr NewController);

		// Token: 0x0600DA8E RID: 55950
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PawnMakeNoise_Internal(IntPtr @this, float Loudness, FVector NoiseLocation, bool bUseNoiseMakerLocation, IntPtr NoiseMaker);

		// Token: 0x0600DA8F RID: 55951
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_PlayerState_Internal(IntPtr @this);

		// Token: 0x0600DA90 RID: 55952
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_Controller_Internal(IntPtr @this);

		// Token: 0x0600DA91 RID: 55953
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LaunchPawn_Internal(IntPtr @this, FVector LaunchVelocity, bool bXYOverride, bool bZOverride);

		// Token: 0x0600DA92 RID: 55954
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __K2_GetMovementInputVector_Internal(IntPtr @this);

		// Token: 0x0600DA93 RID: 55955
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPlayerControlled_Internal(IntPtr @this);

		// Token: 0x0600DA94 RID: 55956
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPawnControlled_Internal(IntPtr @this);

		// Token: 0x0600DA95 RID: 55957
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsMoveInputIgnored_Internal(IntPtr @this);

		// Token: 0x0600DA96 RID: 55958
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsLocallyControlled_Internal(IntPtr @this);

		// Token: 0x0600DA97 RID: 55959
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsControlled_Internal(IntPtr @this);

		// Token: 0x0600DA98 RID: 55960
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsBotControlled_Internal(IntPtr @this);

		// Token: 0x0600DA99 RID: 55961
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetPendingMovementInputVector_Internal(IntPtr @this);

		// Token: 0x0600DA9A RID: 55962
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetNavAgentLocation_Internal(IntPtr @this);

		// Token: 0x0600DA9B RID: 55963
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMovementComponent_Internal(IntPtr @this);

		// Token: 0x0600DA9C RID: 55964
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMovementBaseActor_Internal(IntPtr Pawn);

		// Token: 0x0600DA9D RID: 55965
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetLastMovementInputVector_Internal(IntPtr @this);

		// Token: 0x0600DA9E RID: 55966
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __GetControlRotation_Internal(IntPtr @this);

		// Token: 0x0600DA9F RID: 55967
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetController_Internal(IntPtr @this);

		// Token: 0x0600DAA0 RID: 55968
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __GetBaseAimRotation_Internal(IntPtr @this);

		// Token: 0x0600DAA1 RID: 55969
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DetachFromControllerPendingDestroy_Internal(IntPtr @this);

		// Token: 0x0600DAA2 RID: 55970
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_AddMovementInput_Internal(IntPtr @this, FVectorDouble WorldDirection, float ScaleValue, bool bForce);

		// Token: 0x0600DAA3 RID: 55971
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __ConsumeMovementInputVector_Internal(IntPtr @this);

		// Token: 0x0600DAA4 RID: 55972
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddMovementInput_Internal(IntPtr @this, FVector WorldDirection, float ScaleValue, bool bForce);

		// Token: 0x0600DAA5 RID: 55973
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddControllerYawInput_Internal(IntPtr @this, float Val);

		// Token: 0x0600DAA6 RID: 55974
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddControllerRollInput_Internal(IntPtr @this, float Val);

		// Token: 0x0600DAA7 RID: 55975
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddControllerPitchInput_Internal(IntPtr @this, float Val);

		// Token: 0x0600DAA8 RID: 55976 RVA: 0x0014270F File Offset: 0x0014090F
		static APawn()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Pawn");
		}

		// Token: 0x0600DAA9 RID: 55977 RVA: 0x0014271D File Offset: 0x0014091D
		protected APawn(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007656 RID: 30294
		internal static int __InterfaceOffset_INavAgentInterface;

		// Token: 0x04007657 RID: 30295
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.Pawn";

		// Token: 0x04007658 RID: 30296
		private static IntPtr _ClassPtr;

		// Token: 0x04007659 RID: 30297
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400765A RID: 30298
		internal static int __PropertyOffset_bUseControllerRotationPitch;

		// Token: 0x0400765B RID: 30299
		internal static byte __PropertyMask_bUseControllerRotationPitch;

		// Token: 0x0400765C RID: 30300
		internal static int __PropertyOffset_bUseControllerRotationYaw;

		// Token: 0x0400765D RID: 30301
		internal static byte __PropertyMask_bUseControllerRotationYaw;

		// Token: 0x0400765E RID: 30302
		internal static int __PropertyOffset_bUseControllerRotationRoll;

		// Token: 0x0400765F RID: 30303
		internal static byte __PropertyMask_bUseControllerRotationRoll;

		// Token: 0x04007660 RID: 30304
		internal static int __PropertyOffset_bCanAffectNavigationGeneration;

		// Token: 0x04007661 RID: 30305
		internal static byte __PropertyMask_bCanAffectNavigationGeneration;

		// Token: 0x04007662 RID: 30306
		internal static int __PropertyOffset_BaseEyeHeight;

		// Token: 0x04007663 RID: 30307
		internal static int __PropertyOffset_AutoPossessPlayer;

		// Token: 0x04007664 RID: 30308
		internal static int __PropertyOffset_AutoPossessAI;

		// Token: 0x04007665 RID: 30309
		internal static int __PropertyOffset_RemoteViewPitch;

		// Token: 0x04007666 RID: 30310
		internal static int __PropertyOffset_AIControllerClass;

		// Token: 0x04007667 RID: 30311
		internal static int __PropertyOffset_PlayerState;

		// Token: 0x04007668 RID: 30312
		internal static int __PropertyOffset_LastHitBy;

		// Token: 0x04007669 RID: 30313
		internal static int __PropertyOffset_Controller;

		// Token: 0x0400766A RID: 30314
		internal static int __PropertyOffset_ControlInputVector;

		// Token: 0x0400766B RID: 30315
		internal static int __PropertyOffset_LastControlInputVector;

		// Token: 0x02002DBD RID: 11709
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ReceiveUnpossessed_FunctionParams
		{
			// Token: 0x040167F5 RID: 92149
			[FieldOffset(0)]
			public IntPtr OldController;
		}

		// Token: 0x02002DBE RID: 11710
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ReceivePossessed_FunctionParams
		{
			// Token: 0x040167F6 RID: 92150
			[FieldOffset(0)]
			public IntPtr NewController;
		}
	}
}
