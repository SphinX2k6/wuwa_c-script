using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200025A RID: 602
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.Pawn")]
	[UnrealStructLayout(1136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1136)]
	public class APawn : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600333B RID: 13115 RVA: 0x000497D7 File Offset: 0x000479D7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return APawn._ClassPtr;
		}

		// Token: 0x0600333C RID: 13116 RVA: 0x000497E4 File Offset: 0x000479E4
		public APawn() : this(BuiltinUtils.AllocNativeUObject(APawn.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600333D RID: 13117 RVA: 0x0004980C File Offset: 0x00047A0C
		[NullableContext(1)]
		public APawn(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(APawn.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x0600333E RID: 13118 RVA: 0x0004983F File Offset: 0x00047A3F
		// (set) Token: 0x0600333F RID: 13119 RVA: 0x00049858 File Offset: 0x00047A58
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

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x06003340 RID: 13120 RVA: 0x00049888 File Offset: 0x00047A88
		// (set) Token: 0x06003341 RID: 13121 RVA: 0x000498A1 File Offset: 0x00047AA1
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

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x06003342 RID: 13122 RVA: 0x000498D1 File Offset: 0x00047AD1
		// (set) Token: 0x06003343 RID: 13123 RVA: 0x000498EA File Offset: 0x00047AEA
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

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x06003344 RID: 13124 RVA: 0x0004991A File Offset: 0x00047B1A
		// (set) Token: 0x06003345 RID: 13125 RVA: 0x00049933 File Offset: 0x00047B33
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

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x06003346 RID: 13126 RVA: 0x00049963 File Offset: 0x00047B63
		// (set) Token: 0x06003347 RID: 13127 RVA: 0x00049973 File Offset: 0x00047B73
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

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x06003348 RID: 13128 RVA: 0x00049984 File Offset: 0x00047B84
		// (set) Token: 0x06003349 RID: 13129 RVA: 0x00049994 File Offset: 0x00047B94
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

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x0600334A RID: 13130 RVA: 0x000499A5 File Offset: 0x00047BA5
		// (set) Token: 0x0600334B RID: 13131 RVA: 0x000499B5 File Offset: 0x00047BB5
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

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x0600334C RID: 13132 RVA: 0x000499C6 File Offset: 0x00047BC6
		// (set) Token: 0x0600334D RID: 13133 RVA: 0x000499DA File Offset: 0x00047BDA
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

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x0600334E RID: 13134 RVA: 0x000499EF File Offset: 0x00047BEF
		// (set) Token: 0x0600334F RID: 13135 RVA: 0x00049A03 File Offset: 0x00047C03
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

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x06003350 RID: 13136 RVA: 0x00049A18 File Offset: 0x00047C18
		// (set) Token: 0x06003351 RID: 13137 RVA: 0x00049A2C File Offset: 0x00047C2C
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

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x06003352 RID: 13138 RVA: 0x00049A41 File Offset: 0x00047C41
		// (set) Token: 0x06003353 RID: 13139 RVA: 0x00049A55 File Offset: 0x00047C55
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

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06003354 RID: 13140 RVA: 0x00049A6A File Offset: 0x00047C6A
		// (set) Token: 0x06003355 RID: 13141 RVA: 0x00049A7E File Offset: 0x00047C7E
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

		// Token: 0x06003356 RID: 13142 RVA: 0x00049A93 File Offset: 0x00047C93
		public void SpawnDefaultController()
		{
			APawn.__SpawnDefaultController_Internal(base.NativePtr);
		}

		// Token: 0x06003357 RID: 13143 RVA: 0x00049AA0 File Offset: 0x00047CA0
		public void SetCanAffectNavigationGeneration(bool bNewValue, bool bForceUpdate = false)
		{
			APawn.__SetCanAffectNavigationGeneration_Internal(base.NativePtr, bNewValue, bForceUpdate);
		}

		// Token: 0x06003358 RID: 13144 RVA: 0x00049AAF File Offset: 0x00047CAF
		public virtual void ReceiveUnpossessed(AController OldController)
		{
			APawn.__ReceiveUnpossessed_Internal(base.NativePtr, (OldController != null) ? OldController.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06003359 RID: 13145 RVA: 0x00049ACC File Offset: 0x00047CCC
		public virtual void ReceivePossessed(AController NewController)
		{
			APawn.__ReceivePossessed_Internal(base.NativePtr, (NewController != null) ? NewController.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600335A RID: 13146 RVA: 0x00049AE9 File Offset: 0x00047CE9
		public void PawnMakeNoise(float Loudness, FVector NoiseLocation, bool bUseNoiseMakerLocation = true, AActor NoiseMaker = null)
		{
			APawn.__PawnMakeNoise_Internal(base.NativePtr, Loudness, NoiseLocation, bUseNoiseMakerLocation, (NoiseMaker != null) ? NoiseMaker.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600335B RID: 13147 RVA: 0x00049B0B File Offset: 0x00047D0B
		public void OnRep_PlayerState()
		{
			APawn.__OnRep_PlayerState_Internal(base.NativePtr);
		}

		// Token: 0x0600335C RID: 13148 RVA: 0x00049B18 File Offset: 0x00047D18
		public void OnRep_Controller()
		{
			APawn.__OnRep_Controller_Internal(base.NativePtr);
		}

		// Token: 0x0600335D RID: 13149 RVA: 0x00049B25 File Offset: 0x00047D25
		public void LaunchPawn(FVector LaunchVelocity, bool bXYOverride, bool bZOverride)
		{
			APawn.__LaunchPawn_Internal(base.NativePtr, LaunchVelocity, bXYOverride, bZOverride);
		}

		// Token: 0x0600335E RID: 13150 RVA: 0x00049B35 File Offset: 0x00047D35
		public FVector K2_GetMovementInputVector()
		{
			return APawn.__K2_GetMovementInputVector_Internal(base.NativePtr);
		}

		// Token: 0x0600335F RID: 13151 RVA: 0x00049B42 File Offset: 0x00047D42
		public bool IsPlayerControlled()
		{
			return APawn.__IsPlayerControlled_Internal(base.NativePtr);
		}

		// Token: 0x06003360 RID: 13152 RVA: 0x00049B4F File Offset: 0x00047D4F
		public bool IsPawnControlled()
		{
			return APawn.__IsPawnControlled_Internal(base.NativePtr);
		}

		// Token: 0x06003361 RID: 13153 RVA: 0x00049B5C File Offset: 0x00047D5C
		public bool IsMoveInputIgnored()
		{
			return APawn.__IsMoveInputIgnored_Internal(base.NativePtr);
		}

		// Token: 0x06003362 RID: 13154 RVA: 0x00049B69 File Offset: 0x00047D69
		public bool IsLocallyControlled()
		{
			return APawn.__IsLocallyControlled_Internal(base.NativePtr);
		}

		// Token: 0x06003363 RID: 13155 RVA: 0x00049B76 File Offset: 0x00047D76
		public bool IsControlled()
		{
			return APawn.__IsControlled_Internal(base.NativePtr);
		}

		// Token: 0x06003364 RID: 13156 RVA: 0x00049B83 File Offset: 0x00047D83
		public bool IsBotControlled()
		{
			return APawn.__IsBotControlled_Internal(base.NativePtr);
		}

		// Token: 0x06003365 RID: 13157 RVA: 0x00049B90 File Offset: 0x00047D90
		public FVector GetPendingMovementInputVector()
		{
			return APawn.__GetPendingMovementInputVector_Internal(base.NativePtr);
		}

		// Token: 0x06003366 RID: 13158 RVA: 0x00049B9D File Offset: 0x00047D9D
		public FVector GetNavAgentLocation()
		{
			return APawn.__GetNavAgentLocation_Internal(base.NativePtr);
		}

		// Token: 0x06003367 RID: 13159 RVA: 0x00049BAA File Offset: 0x00047DAA
		public UPawnMovementComponent GetMovementComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UPawnMovementComponent>(APawn.__GetMovementComponent_Internal(base.NativePtr));
		}

		// Token: 0x06003368 RID: 13160 RVA: 0x00049BBC File Offset: 0x00047DBC
		public static AActor GetMovementBaseActor(APawn Pawn)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(APawn.__GetMovementBaseActor_Internal((Pawn != null) ? Pawn.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06003369 RID: 13161 RVA: 0x00049BD8 File Offset: 0x00047DD8
		public FVector GetLastMovementInputVector()
		{
			return APawn.__GetLastMovementInputVector_Internal(base.NativePtr);
		}

		// Token: 0x0600336A RID: 13162 RVA: 0x00049BE5 File Offset: 0x00047DE5
		public FRotator GetControlRotation()
		{
			return APawn.__GetControlRotation_Internal(base.NativePtr);
		}

		// Token: 0x0600336B RID: 13163 RVA: 0x00049BF2 File Offset: 0x00047DF2
		public AController GetController()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AController>(APawn.__GetController_Internal(base.NativePtr));
		}

		// Token: 0x0600336C RID: 13164 RVA: 0x00049C04 File Offset: 0x00047E04
		public FRotator GetBaseAimRotation()
		{
			return APawn.__GetBaseAimRotation_Internal(base.NativePtr);
		}

		// Token: 0x0600336D RID: 13165 RVA: 0x00049C11 File Offset: 0x00047E11
		public void DetachFromControllerPendingDestroy()
		{
			APawn.__DetachFromControllerPendingDestroy_Internal(base.NativePtr);
		}

		// Token: 0x0600336E RID: 13166 RVA: 0x00049C1E File Offset: 0x00047E1E
		public void D_AddMovementInput(FVectorDouble WorldDirection, float ScaleValue = 1f, bool bForce = false)
		{
			APawn.__D_AddMovementInput_Internal(base.NativePtr, WorldDirection, ScaleValue, bForce);
		}

		// Token: 0x0600336F RID: 13167 RVA: 0x00049C2E File Offset: 0x00047E2E
		public FVector ConsumeMovementInputVector()
		{
			return APawn.__ConsumeMovementInputVector_Internal(base.NativePtr);
		}

		// Token: 0x06003370 RID: 13168 RVA: 0x00049C3B File Offset: 0x00047E3B
		public void AddMovementInput(FVector WorldDirection, float ScaleValue = 1f, bool bForce = false)
		{
			APawn.__AddMovementInput_Internal(base.NativePtr, WorldDirection, ScaleValue, bForce);
		}

		// Token: 0x06003371 RID: 13169 RVA: 0x00049C4B File Offset: 0x00047E4B
		public void AddControllerYawInput(float Val)
		{
			APawn.__AddControllerYawInput_Internal(base.NativePtr, Val);
		}

		// Token: 0x06003372 RID: 13170 RVA: 0x00049C59 File Offset: 0x00047E59
		public void AddControllerRollInput(float Val)
		{
			APawn.__AddControllerRollInput_Internal(base.NativePtr, Val);
		}

		// Token: 0x06003373 RID: 13171 RVA: 0x00049C67 File Offset: 0x00047E67
		public void AddControllerPitchInput(float Val)
		{
			APawn.__AddControllerPitchInput_Internal(base.NativePtr, Val);
		}

		// Token: 0x06003374 RID: 13172
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SpawnDefaultController_Internal(IntPtr @this);

		// Token: 0x06003375 RID: 13173
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCanAffectNavigationGeneration_Internal(IntPtr @this, bool bNewValue, bool bForceUpdate);

		// Token: 0x06003376 RID: 13174
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveUnpossessed_Internal(IntPtr @this, IntPtr OldController);

		// Token: 0x06003377 RID: 13175
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceivePossessed_Internal(IntPtr @this, IntPtr NewController);

		// Token: 0x06003378 RID: 13176
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PawnMakeNoise_Internal(IntPtr @this, float Loudness, FVector NoiseLocation, bool bUseNoiseMakerLocation, IntPtr NoiseMaker);

		// Token: 0x06003379 RID: 13177
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_PlayerState_Internal(IntPtr @this);

		// Token: 0x0600337A RID: 13178
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_Controller_Internal(IntPtr @this);

		// Token: 0x0600337B RID: 13179
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LaunchPawn_Internal(IntPtr @this, FVector LaunchVelocity, bool bXYOverride, bool bZOverride);

		// Token: 0x0600337C RID: 13180
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __K2_GetMovementInputVector_Internal(IntPtr @this);

		// Token: 0x0600337D RID: 13181
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPlayerControlled_Internal(IntPtr @this);

		// Token: 0x0600337E RID: 13182
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPawnControlled_Internal(IntPtr @this);

		// Token: 0x0600337F RID: 13183
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsMoveInputIgnored_Internal(IntPtr @this);

		// Token: 0x06003380 RID: 13184
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsLocallyControlled_Internal(IntPtr @this);

		// Token: 0x06003381 RID: 13185
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsControlled_Internal(IntPtr @this);

		// Token: 0x06003382 RID: 13186
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsBotControlled_Internal(IntPtr @this);

		// Token: 0x06003383 RID: 13187
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetPendingMovementInputVector_Internal(IntPtr @this);

		// Token: 0x06003384 RID: 13188
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetNavAgentLocation_Internal(IntPtr @this);

		// Token: 0x06003385 RID: 13189
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMovementComponent_Internal(IntPtr @this);

		// Token: 0x06003386 RID: 13190
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMovementBaseActor_Internal(IntPtr Pawn);

		// Token: 0x06003387 RID: 13191
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetLastMovementInputVector_Internal(IntPtr @this);

		// Token: 0x06003388 RID: 13192
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __GetControlRotation_Internal(IntPtr @this);

		// Token: 0x06003389 RID: 13193
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetController_Internal(IntPtr @this);

		// Token: 0x0600338A RID: 13194
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __GetBaseAimRotation_Internal(IntPtr @this);

		// Token: 0x0600338B RID: 13195
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DetachFromControllerPendingDestroy_Internal(IntPtr @this);

		// Token: 0x0600338C RID: 13196
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_AddMovementInput_Internal(IntPtr @this, FVectorDouble WorldDirection, float ScaleValue, bool bForce);

		// Token: 0x0600338D RID: 13197
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __ConsumeMovementInputVector_Internal(IntPtr @this);

		// Token: 0x0600338E RID: 13198
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddMovementInput_Internal(IntPtr @this, FVector WorldDirection, float ScaleValue, bool bForce);

		// Token: 0x0600338F RID: 13199
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddControllerYawInput_Internal(IntPtr @this, float Val);

		// Token: 0x06003390 RID: 13200
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddControllerRollInput_Internal(IntPtr @this, float Val);

		// Token: 0x06003391 RID: 13201
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddControllerPitchInput_Internal(IntPtr @this, float Val);

		// Token: 0x06003392 RID: 13202 RVA: 0x00049C75 File Offset: 0x00047E75
		static APawn()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Pawn");
		}

		// Token: 0x06003393 RID: 13203 RVA: 0x00049C83 File Offset: 0x00047E83
		protected APawn(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040011DA RID: 4570
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.Pawn";

		// Token: 0x040011DB RID: 4571
		private static IntPtr _ClassPtr;

		// Token: 0x040011DC RID: 4572
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040011DD RID: 4573
		internal static int __PropertyOffset_bUseControllerRotationPitch;

		// Token: 0x040011DE RID: 4574
		internal static byte __PropertyMask_bUseControllerRotationPitch;

		// Token: 0x040011DF RID: 4575
		internal static int __PropertyOffset_bUseControllerRotationYaw;

		// Token: 0x040011E0 RID: 4576
		internal static byte __PropertyMask_bUseControllerRotationYaw;

		// Token: 0x040011E1 RID: 4577
		internal static int __PropertyOffset_bUseControllerRotationRoll;

		// Token: 0x040011E2 RID: 4578
		internal static byte __PropertyMask_bUseControllerRotationRoll;

		// Token: 0x040011E3 RID: 4579
		internal static int __PropertyOffset_bCanAffectNavigationGeneration;

		// Token: 0x040011E4 RID: 4580
		internal static byte __PropertyMask_bCanAffectNavigationGeneration;

		// Token: 0x040011E5 RID: 4581
		internal static int __PropertyOffset_BaseEyeHeight;

		// Token: 0x040011E6 RID: 4582
		internal static int __PropertyOffset_AutoPossessAI;

		// Token: 0x040011E7 RID: 4583
		internal static int __PropertyOffset_RemoteViewPitch;

		// Token: 0x040011E8 RID: 4584
		internal static int __PropertyOffset_AIControllerClass;

		// Token: 0x040011E9 RID: 4585
		internal static int __PropertyOffset_LastHitBy;

		// Token: 0x040011EA RID: 4586
		internal static int __PropertyOffset_Controller;

		// Token: 0x040011EB RID: 4587
		internal static int __PropertyOffset_ControlInputVector;

		// Token: 0x040011EC RID: 4588
		internal static int __PropertyOffset_LastControlInputVector;

		// Token: 0x020009DF RID: 2527
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ReceiveUnpossessed_FunctionParams
		{
			// Token: 0x04005971 RID: 22897
			[FieldOffset(0)]
			public IntPtr OldController;
		}

		// Token: 0x020009E0 RID: 2528
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ReceivePossessed_FunctionParams
		{
			// Token: 0x04005972 RID: 22898
			[FieldOffset(0)]
			public IntPtr NewController;
		}
	}
}
