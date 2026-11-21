using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001BD RID: 445
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.Controller")]
	[UnrealStructLayout(1168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1168)]
	public abstract class AController : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002089 RID: 8329 RVA: 0x0002FFBA File Offset: 0x0002E1BA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AController._ClassPtr;
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x0600208A RID: 8330 RVA: 0x0002FFC6 File Offset: 0x0002E1C6
		// (set) Token: 0x0600208B RID: 8331 RVA: 0x0002FFDA File Offset: 0x0002E1DA
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

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x0600208C RID: 8332 RVA: 0x0002FFEF File Offset: 0x0002E1EF
		// (set) Token: 0x0600208D RID: 8333 RVA: 0x00030003 File Offset: 0x0002E203
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

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x0600208E RID: 8334 RVA: 0x00030018 File Offset: 0x0002E218
		// (set) Token: 0x0600208F RID: 8335 RVA: 0x0003002C File Offset: 0x0002E22C
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

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06002090 RID: 8336 RVA: 0x00030041 File Offset: 0x0002E241
		// (set) Token: 0x06002091 RID: 8337 RVA: 0x00030055 File Offset: 0x0002E255
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

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06002092 RID: 8338 RVA: 0x0003006A File Offset: 0x0002E26A
		// (set) Token: 0x06002093 RID: 8339 RVA: 0x0003007E File Offset: 0x0002E27E
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

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06002094 RID: 8340 RVA: 0x00030093 File Offset: 0x0002E293
		// (set) Token: 0x06002095 RID: 8341 RVA: 0x000300AC File Offset: 0x0002E2AC
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

		// Token: 0x06002096 RID: 8342 RVA: 0x000300DC File Offset: 0x0002E2DC
		public void UnPossess()
		{
			AController.__UnPossess_Internal(base.NativePtr);
		}

		// Token: 0x06002097 RID: 8343 RVA: 0x000300E9 File Offset: 0x0002E2E9
		public void StopMovement()
		{
			AController.__StopMovement_Internal(base.NativePtr);
		}

		// Token: 0x06002098 RID: 8344 RVA: 0x000300F6 File Offset: 0x0002E2F6
		public void SetInitialLocationAndRotation(in FVector NewLocation, in FRotator NewRotation)
		{
			AController.__SetInitialLocationAndRotation_Internal(base.NativePtr, NewLocation, NewRotation);
		}

		// Token: 0x06002099 RID: 8345 RVA: 0x00030105 File Offset: 0x0002E305
		public void SetIgnoreMoveInput(bool bNewMoveInput)
		{
			AController.__SetIgnoreMoveInput_Internal(base.NativePtr, bNewMoveInput);
		}

		// Token: 0x0600209A RID: 8346 RVA: 0x00030113 File Offset: 0x0002E313
		public void SetIgnoreLookInput(bool bNewLookInput)
		{
			AController.__SetIgnoreLookInput_Internal(base.NativePtr, bNewLookInput);
		}

		// Token: 0x0600209B RID: 8347 RVA: 0x00030121 File Offset: 0x0002E321
		public void SetControlRotation(in FRotator NewRotation)
		{
			AController.__SetControlRotation_Internal(base.NativePtr, NewRotation);
		}

		// Token: 0x0600209C RID: 8348 RVA: 0x0003012F File Offset: 0x0002E32F
		public void ResetIgnoreMoveInput()
		{
			AController.__ResetIgnoreMoveInput_Internal(base.NativePtr);
		}

		// Token: 0x0600209D RID: 8349 RVA: 0x0003013C File Offset: 0x0002E33C
		public void ResetIgnoreLookInput()
		{
			AController.__ResetIgnoreLookInput_Internal(base.NativePtr);
		}

		// Token: 0x0600209E RID: 8350 RVA: 0x00030149 File Offset: 0x0002E349
		public void ResetIgnoreInputFlags()
		{
			AController.__ResetIgnoreInputFlags_Internal(base.NativePtr);
		}

		// Token: 0x0600209F RID: 8351 RVA: 0x00030156 File Offset: 0x0002E356
		public virtual void ReceiveUnPossess(APawn UnpossessedPawn)
		{
			AController.__ReceiveUnPossess_Internal(base.NativePtr, (UnpossessedPawn != null) ? UnpossessedPawn.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060020A0 RID: 8352 RVA: 0x00030173 File Offset: 0x0002E373
		public virtual void ReceivePossess(APawn PossessedPawn)
		{
			AController.__ReceivePossess_Internal(base.NativePtr, (PossessedPawn != null) ? PossessedPawn.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060020A1 RID: 8353 RVA: 0x00030190 File Offset: 0x0002E390
		public void Possess(APawn InPawn)
		{
			AController.__Possess_Internal(base.NativePtr, (InPawn != null) ? InPawn.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060020A2 RID: 8354 RVA: 0x000301AD File Offset: 0x0002E3AD
		public void OnRep_PlayerState()
		{
			AController.__OnRep_PlayerState_Internal(base.NativePtr);
		}

		// Token: 0x060020A3 RID: 8355 RVA: 0x000301BA File Offset: 0x0002E3BA
		public void OnRep_Pawn()
		{
			AController.__OnRep_Pawn_Internal(base.NativePtr);
		}

		// Token: 0x060020A4 RID: 8356 RVA: 0x000301C7 File Offset: 0x0002E3C7
		public bool LineOfSightTo(AActor Other, FVector ViewPoint = default(FVector), bool bAlternateChecks = false)
		{
			return AController.__LineOfSightTo_Internal(base.NativePtr, (Other != null) ? Other.NativePtr : IntPtr.Zero, ViewPoint, bAlternateChecks);
		}

		// Token: 0x060020A5 RID: 8357 RVA: 0x000301E6 File Offset: 0x0002E3E6
		public APawn K2_GetPawn()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(AController.__K2_GetPawn_Internal(base.NativePtr));
		}

		// Token: 0x060020A6 RID: 8358 RVA: 0x000301F8 File Offset: 0x0002E3F8
		public bool IsPlayerController()
		{
			return AController.__IsPlayerController_Internal(base.NativePtr);
		}

		// Token: 0x060020A7 RID: 8359 RVA: 0x00030205 File Offset: 0x0002E405
		public bool IsMoveInputIgnored()
		{
			return AController.__IsMoveInputIgnored_Internal(base.NativePtr);
		}

		// Token: 0x060020A8 RID: 8360 RVA: 0x00030212 File Offset: 0x0002E412
		public bool IsLookInputIgnored()
		{
			return AController.__IsLookInputIgnored_Internal(base.NativePtr);
		}

		// Token: 0x060020A9 RID: 8361 RVA: 0x0003021F File Offset: 0x0002E41F
		public bool IsLocalPlayerController()
		{
			return AController.__IsLocalPlayerController_Internal(base.NativePtr);
		}

		// Token: 0x060020AA RID: 8362 RVA: 0x0003022C File Offset: 0x0002E42C
		public bool IsLocalController()
		{
			return AController.__IsLocalController_Internal(base.NativePtr);
		}

		// Token: 0x060020AB RID: 8363 RVA: 0x00030239 File Offset: 0x0002E439
		public AActor GetViewTarget()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(AController.__GetViewTarget_Internal(base.NativePtr));
		}

		// Token: 0x060020AC RID: 8364 RVA: 0x0003024B File Offset: 0x0002E44B
		public FRotator GetDesiredRotation()
		{
			return AController.__GetDesiredRotation_Internal(base.NativePtr);
		}

		// Token: 0x060020AD RID: 8365 RVA: 0x00030258 File Offset: 0x0002E458
		public FRotator GetControlRotation()
		{
			return AController.__GetControlRotation_Internal(base.NativePtr);
		}

		// Token: 0x060020AE RID: 8366 RVA: 0x00030265 File Offset: 0x0002E465
		public void ClientSetRotation(FRotator NewRotation, bool bResetCamera)
		{
			AController.__ClientSetRotation_Internal(base.NativePtr, NewRotation, bResetCamera);
		}

		// Token: 0x060020AF RID: 8367 RVA: 0x00030274 File Offset: 0x0002E474
		public void ClientSetLocation(FVector NewLocation, FRotator NewRotation)
		{
			AController.__ClientSetLocation_Internal(base.NativePtr, NewLocation, NewRotation);
		}

		// Token: 0x060020B0 RID: 8368 RVA: 0x00030283 File Offset: 0x0002E483
		public APlayerController CastToPlayerController()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APlayerController>(AController.__CastToPlayerController_Internal(base.NativePtr));
		}

		// Token: 0x060020B1 RID: 8369
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnPossess_Internal(IntPtr @this);

		// Token: 0x060020B2 RID: 8370
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopMovement_Internal(IntPtr @this);

		// Token: 0x060020B3 RID: 8371
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInitialLocationAndRotation_Internal(IntPtr @this, in FVector NewLocation, in FRotator NewRotation);

		// Token: 0x060020B4 RID: 8372
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIgnoreMoveInput_Internal(IntPtr @this, bool bNewMoveInput);

		// Token: 0x060020B5 RID: 8373
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIgnoreLookInput_Internal(IntPtr @this, bool bNewLookInput);

		// Token: 0x060020B6 RID: 8374
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetControlRotation_Internal(IntPtr @this, in FRotator NewRotation);

		// Token: 0x060020B7 RID: 8375
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetIgnoreMoveInput_Internal(IntPtr @this);

		// Token: 0x060020B8 RID: 8376
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetIgnoreLookInput_Internal(IntPtr @this);

		// Token: 0x060020B9 RID: 8377
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetIgnoreInputFlags_Internal(IntPtr @this);

		// Token: 0x060020BA RID: 8378
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveUnPossess_Internal(IntPtr @this, IntPtr UnpossessedPawn);

		// Token: 0x060020BB RID: 8379
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceivePossess_Internal(IntPtr @this, IntPtr PossessedPawn);

		// Token: 0x060020BC RID: 8380
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Possess_Internal(IntPtr @this, IntPtr InPawn);

		// Token: 0x060020BD RID: 8381
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_PlayerState_Internal(IntPtr @this);

		// Token: 0x060020BE RID: 8382
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_Pawn_Internal(IntPtr @this);

		// Token: 0x060020BF RID: 8383
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __LineOfSightTo_Internal(IntPtr @this, IntPtr Other, FVector ViewPoint, bool bAlternateChecks);

		// Token: 0x060020C0 RID: 8384
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __K2_GetPawn_Internal(IntPtr @this);

		// Token: 0x060020C1 RID: 8385
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPlayerController_Internal(IntPtr @this);

		// Token: 0x060020C2 RID: 8386
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsMoveInputIgnored_Internal(IntPtr @this);

		// Token: 0x060020C3 RID: 8387
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsLookInputIgnored_Internal(IntPtr @this);

		// Token: 0x060020C4 RID: 8388
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsLocalPlayerController_Internal(IntPtr @this);

		// Token: 0x060020C5 RID: 8389
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsLocalController_Internal(IntPtr @this);

		// Token: 0x060020C6 RID: 8390
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetViewTarget_Internal(IntPtr @this);

		// Token: 0x060020C7 RID: 8391
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __GetDesiredRotation_Internal(IntPtr @this);

		// Token: 0x060020C8 RID: 8392
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __GetControlRotation_Internal(IntPtr @this);

		// Token: 0x060020C9 RID: 8393
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientSetRotation_Internal(IntPtr @this, FRotator NewRotation, bool bResetCamera);

		// Token: 0x060020CA RID: 8394
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientSetLocation_Internal(IntPtr @this, FVector NewLocation, FRotator NewRotation);

		// Token: 0x060020CB RID: 8395
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CastToPlayerController_Internal(IntPtr @this);

		// Token: 0x060020CC RID: 8396 RVA: 0x00030295 File Offset: 0x0002E495
		static AController()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Controller");
		}

		// Token: 0x060020CD RID: 8397 RVA: 0x000302A4 File Offset: 0x0002E4A4
		protected AController() : this(BuiltinUtils.AllocNativeUObject(AController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060020CE RID: 8398 RVA: 0x000302CC File Offset: 0x0002E4CC
		protected AController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000AD6 RID: 2774
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.Controller";

		// Token: 0x04000AD7 RID: 2775
		private static IntPtr _ClassPtr;

		// Token: 0x04000AD8 RID: 2776
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000AD9 RID: 2777
		internal static int __PropertyOffset_StateName;

		// Token: 0x04000ADA RID: 2778
		internal static int __PropertyOffset_Pawn;

		// Token: 0x04000ADB RID: 2779
		internal static int __PropertyOffset_Character;

		// Token: 0x04000ADC RID: 2780
		internal static int __PropertyOffset_TransformComponent;

		// Token: 0x04000ADD RID: 2781
		internal static int __PropertyOffset_ControlRotation;

		// Token: 0x04000ADE RID: 2782
		internal static int __PropertyOffset_bAttachToPawn;

		// Token: 0x04000ADF RID: 2783
		internal static byte __PropertyMask_bAttachToPawn;

		// Token: 0x0200099D RID: 2461
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ReceiveUnPossess_FunctionParams
		{
			// Token: 0x04005904 RID: 22788
			[FieldOffset(0)]
			public IntPtr UnpossessedPawn;
		}

		// Token: 0x0200099E RID: 2462
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ReceivePossess_FunctionParams
		{
			// Token: 0x04005905 RID: 22789
			[FieldOffset(0)]
			public IntPtr PossessedPawn;
		}
	}
}
