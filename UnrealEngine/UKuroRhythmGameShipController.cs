using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C57 RID: 7255
	[UnrealObjectPath("/Script/KuroRhythmGame.KuroRhythmGameShipController")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UKuroRhythmGameShipController : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C25A RID: 115290 RVA: 0x002978DF File Offset: 0x00295ADF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRhythmGameShipController._ClassPtr;
		}

		// Token: 0x0601C25B RID: 115291 RVA: 0x002978EC File Offset: 0x00295AEC
		public UKuroRhythmGameShipController() : this(BuiltinUtils.AllocNativeUObject(UKuroRhythmGameShipController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C25C RID: 115292 RVA: 0x00297914 File Offset: 0x00295B14
		[NullableContext(1)]
		public UKuroRhythmGameShipController(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRhythmGameShipController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170071DE RID: 29150
		// (get) Token: 0x0601C25D RID: 115293 RVA: 0x00297947 File Offset: 0x00295B47
		// (set) Token: 0x0601C25E RID: 115294 RVA: 0x0029795B File Offset: 0x00295B5B
		[Nullable(2)]
		public unsafe AActor ShipActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroRhythmGameShipController.__PropertyOffset_ShipActor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroRhythmGameShipController.__PropertyOffset_ShipActor, value);
			}
		}

		// Token: 0x170071DF RID: 29151
		// (get) Token: 0x0601C25F RID: 115295 RVA: 0x00297970 File Offset: 0x00295B70
		// (set) Token: 0x0601C260 RID: 115296 RVA: 0x00297984 File Offset: 0x00295B84
		[Nullable(2)]
		public unsafe USplineComponent Spline
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroRhythmGameShipController.__PropertyOffset_Spline);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroRhythmGameShipController.__PropertyOffset_Spline, value);
			}
		}

		// Token: 0x170071E0 RID: 29152
		// (get) Token: 0x0601C261 RID: 115297 RVA: 0x00297999 File Offset: 0x00295B99
		// (set) Token: 0x0601C262 RID: 115298 RVA: 0x002979AD File Offset: 0x00295BAD
		[Nullable(2)]
		public unsafe UKuroRhythmGameManager GameManager
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroRhythmGameManager>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroRhythmGameShipController.__PropertyOffset_GameManager);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroRhythmGameShipController.__PropertyOffset_GameManager, value);
			}
		}

		// Token: 0x170071E1 RID: 29153
		// (get) Token: 0x0601C263 RID: 115299 RVA: 0x002979C2 File Offset: 0x00295BC2
		// (set) Token: 0x0601C264 RID: 115300 RVA: 0x002979D2 File Offset: 0x00295BD2
		public unsafe float MovementSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRhythmGameShipController.__PropertyOffset_MovementSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRhythmGameShipController.__PropertyOffset_MovementSpeed) = value;
			}
		}

		// Token: 0x170071E2 RID: 29154
		// (get) Token: 0x0601C265 RID: 115301 RVA: 0x002979E3 File Offset: 0x00295BE3
		// (set) Token: 0x0601C266 RID: 115302 RVA: 0x002979F3 File Offset: 0x00295BF3
		public unsafe float TargetMovementSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRhythmGameShipController.__PropertyOffset_TargetMovementSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRhythmGameShipController.__PropertyOffset_TargetMovementSpeed) = value;
			}
		}

		// Token: 0x170071E3 RID: 29155
		// (get) Token: 0x0601C267 RID: 115303 RVA: 0x00297A04 File Offset: 0x00295C04
		// (set) Token: 0x0601C268 RID: 115304 RVA: 0x00297A14 File Offset: 0x00295C14
		public unsafe float SpeedAcceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRhythmGameShipController.__PropertyOffset_SpeedAcceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRhythmGameShipController.__PropertyOffset_SpeedAcceleration) = value;
			}
		}

		// Token: 0x170071E4 RID: 29156
		// (get) Token: 0x0601C269 RID: 115305 RVA: 0x00297A25 File Offset: 0x00295C25
		// (set) Token: 0x0601C26A RID: 115306 RVA: 0x00297A35 File Offset: 0x00295C35
		public unsafe float CurrentSplineDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRhythmGameShipController.__PropertyOffset_CurrentSplineDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRhythmGameShipController.__PropertyOffset_CurrentSplineDistance) = value;
			}
		}

		// Token: 0x170071E5 RID: 29157
		// (get) Token: 0x0601C26B RID: 115307 RVA: 0x00297A46 File Offset: 0x00295C46
		// (set) Token: 0x0601C26C RID: 115308 RVA: 0x00297A56 File Offset: 0x00295C56
		public unsafe bool bIsMoving
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRhythmGameShipController.__PropertyOffset_bIsMoving) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRhythmGameShipController.__PropertyOffset_bIsMoving) = (value ? 1 : 0);
			}
		}

		// Token: 0x170071E6 RID: 29158
		// (get) Token: 0x0601C26D RID: 115309 RVA: 0x00297A67 File Offset: 0x00295C67
		// (set) Token: 0x0601C26E RID: 115310 RVA: 0x00297A77 File Offset: 0x00295C77
		public unsafe float LastGameplayTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRhythmGameShipController.__PropertyOffset_LastGameplayTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRhythmGameShipController.__PropertyOffset_LastGameplayTime) = value;
			}
		}

		// Token: 0x170071E7 RID: 29159
		// (get) Token: 0x0601C26F RID: 115311 RVA: 0x00297A88 File Offset: 0x00295C88
		// (set) Token: 0x0601C270 RID: 115312 RVA: 0x00297A98 File Offset: 0x00295C98
		public unsafe bool bMovingTowardsEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRhythmGameShipController.__PropertyOffset_bMovingTowardsEnd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRhythmGameShipController.__PropertyOffset_bMovingTowardsEnd) = (value ? 1 : 0);
			}
		}

		// Token: 0x170071E8 RID: 29160
		// (get) Token: 0x0601C271 RID: 115313 RVA: 0x00297AA9 File Offset: 0x00295CA9
		// (set) Token: 0x0601C272 RID: 115314 RVA: 0x00297AB9 File Offset: 0x00295CB9
		public unsafe float SplineLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRhythmGameShipController.__PropertyOffset_SplineLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRhythmGameShipController.__PropertyOffset_SplineLength) = value;
			}
		}

		// Token: 0x170071E9 RID: 29161
		// (get) Token: 0x0601C273 RID: 115315 RVA: 0x00297ACA File Offset: 0x00295CCA
		// (set) Token: 0x0601C274 RID: 115316 RVA: 0x00297ADA File Offset: 0x00295CDA
		public unsafe bool bIsSwitchingTrack
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRhythmGameShipController.__PropertyOffset_bIsSwitchingTrack) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRhythmGameShipController.__PropertyOffset_bIsSwitchingTrack) = (value ? 1 : 0);
			}
		}

		// Token: 0x170071EA RID: 29162
		// (get) Token: 0x0601C275 RID: 115317 RVA: 0x00297AEB File Offset: 0x00295CEB
		// (set) Token: 0x0601C276 RID: 115318 RVA: 0x00297AFB File Offset: 0x00295CFB
		public unsafe float TrackSwitchTargetOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRhythmGameShipController.__PropertyOffset_TrackSwitchTargetOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRhythmGameShipController.__PropertyOffset_TrackSwitchTargetOffset) = value;
			}
		}

		// Token: 0x170071EB RID: 29163
		// (get) Token: 0x0601C277 RID: 115319 RVA: 0x00297B0C File Offset: 0x00295D0C
		// (set) Token: 0x0601C278 RID: 115320 RVA: 0x00297B1C File Offset: 0x00295D1C
		public unsafe float TrackSwitchDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRhythmGameShipController.__PropertyOffset_TrackSwitchDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRhythmGameShipController.__PropertyOffset_TrackSwitchDuration) = value;
			}
		}

		// Token: 0x170071EC RID: 29164
		// (get) Token: 0x0601C279 RID: 115321 RVA: 0x00297B2D File Offset: 0x00295D2D
		// (set) Token: 0x0601C27A RID: 115322 RVA: 0x00297B3D File Offset: 0x00295D3D
		public unsafe float TrackSwitchElapsedTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRhythmGameShipController.__PropertyOffset_TrackSwitchElapsedTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRhythmGameShipController.__PropertyOffset_TrackSwitchElapsedTime) = value;
			}
		}

		// Token: 0x170071ED RID: 29165
		// (get) Token: 0x0601C27B RID: 115323 RVA: 0x00297B4E File Offset: 0x00295D4E
		// (set) Token: 0x0601C27C RID: 115324 RVA: 0x00297B5E File Offset: 0x00295D5E
		public unsafe float TrackSwitchStartOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRhythmGameShipController.__PropertyOffset_TrackSwitchStartOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRhythmGameShipController.__PropertyOffset_TrackSwitchStartOffset) = value;
			}
		}

		// Token: 0x170071EE RID: 29166
		// (get) Token: 0x0601C27D RID: 115325 RVA: 0x00297B6F File Offset: 0x00295D6F
		// (set) Token: 0x0601C27E RID: 115326 RVA: 0x00297B7F File Offset: 0x00295D7F
		public unsafe float CurrentLateralOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRhythmGameShipController.__PropertyOffset_CurrentLateralOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRhythmGameShipController.__PropertyOffset_CurrentLateralOffset) = value;
			}
		}

		// Token: 0x0601C27F RID: 115327 RVA: 0x00297B90 File Offset: 0x00295D90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void StopMovement()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameShipController.__StopMovement_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C280 RID: 115328 RVA: 0x00297BA8 File Offset: 0x00295DA8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void StartTrackSwitch(float TargetLateralOffset, float SwitchDuration = 0.3f, bool bInterrupt = false)
		{
			UKuroRhythmGameShipController.__StartTrackSwitch_FunctionParams* ptr = stackalloc UKuroRhythmGameShipController.__StartTrackSwitch_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroRhythmGameShipController.__StartTrackSwitch_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameShipController.__StartTrackSwitch_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TargetLateralOffset = TargetLateralOffset;
			ptr->SwitchDuration = SwitchDuration;
			ptr->bInterrupt = bInterrupt;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameShipController.__StartTrackSwitch_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601C281 RID: 115329 RVA: 0x00297BFD File Offset: 0x00295DFD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void StartMovement()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameShipController.__StartMovement_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C282 RID: 115330 RVA: 0x00297C14 File Offset: 0x00295E14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void StartJump(float JumpDurationMs)
		{
			UKuroRhythmGameShipController.__StartJump_FunctionParams* ptr = stackalloc UKuroRhythmGameShipController.__StartJump_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroRhythmGameShipController.__StartJump_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameShipController.__StartJump_NativeFunctionPtr, (void*)ptr, 1);
			ptr->JumpDurationMs = JumpDurationMs;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameShipController.__StartJump_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601C283 RID: 115331 RVA: 0x00297C5B File Offset: 0x00295E5B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void ResumeMovement()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameShipController.__ResumeMovement_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C284 RID: 115332 RVA: 0x00297C70 File Offset: 0x00295E70
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void ResetToStart()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameShipController.__ResetToStart_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C285 RID: 115333 RVA: 0x00297C85 File Offset: 0x00295E85
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void PauseMovement()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameShipController.__PauseMovement_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C286 RID: 115334 RVA: 0x00297C9C File Offset: 0x00295E9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsTrackSwitching()
		{
			UKuroRhythmGameShipController.__IsTrackSwitching_FunctionParams* ptr = stackalloc UKuroRhythmGameShipController.__IsTrackSwitching_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroRhythmGameShipController.__IsTrackSwitching_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameShipController.__IsTrackSwitching_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameShipController.__IsTrackSwitching_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C287 RID: 115335 RVA: 0x00297CE4 File Offset: 0x00295EE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsMoving()
		{
			UKuroRhythmGameShipController.__IsMoving_FunctionParams* ptr = stackalloc UKuroRhythmGameShipController.__IsMoving_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroRhythmGameShipController.__IsMoving_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameShipController.__IsMoving_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameShipController.__IsMoving_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C288 RID: 115336 RVA: 0x00297D2C File Offset: 0x00295F2C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Initialize(AActor InShipActor, USplineComponent InSpline, UKuroRhythmGameManager InGameManager)
		{
			UKuroRhythmGameShipController.__Initialize_FunctionParams* ptr = stackalloc UKuroRhythmGameShipController.__Initialize_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroRhythmGameShipController.__Initialize_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameShipController.__Initialize_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InShipActor = ((InShipActor != null) ? InShipActor.NativePtr : IntPtr.Zero);
			ptr->InSpline = ((InSpline != null) ? InSpline.NativePtr : IntPtr.Zero);
			ptr->InGameManager = ((InGameManager != null) ? InGameManager.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameShipController.__Initialize_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601C289 RID: 115337 RVA: 0x00297DB0 File Offset: 0x00295FB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe float GetSplineLength()
		{
			UKuroRhythmGameShipController.__GetSplineLength_FunctionParams* ptr = stackalloc UKuroRhythmGameShipController.__GetSplineLength_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroRhythmGameShipController.__GetSplineLength_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameShipController.__GetSplineLength_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameShipController.__GetSplineLength_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C28A RID: 115338 RVA: 0x00297DF8 File Offset: 0x00295FF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FVector GetShipUpVector()
		{
			UKuroRhythmGameShipController.__GetShipUpVector_FunctionParams* ptr = stackalloc UKuroRhythmGameShipController.__GetShipUpVector_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroRhythmGameShipController.__GetShipUpVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameShipController.__GetShipUpVector_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameShipController.__GetShipUpVector_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C28B RID: 115339 RVA: 0x00297E40 File Offset: 0x00296040
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FRotator GetShipRotation()
		{
			UKuroRhythmGameShipController.__GetShipRotation_FunctionParams* ptr = stackalloc UKuroRhythmGameShipController.__GetShipRotation_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroRhythmGameShipController.__GetShipRotation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameShipController.__GetShipRotation_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameShipController.__GetShipRotation_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C28C RID: 115340 RVA: 0x00297E88 File Offset: 0x00296088
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FVector GetShipRightVector()
		{
			UKuroRhythmGameShipController.__GetShipRightVector_FunctionParams* ptr = stackalloc UKuroRhythmGameShipController.__GetShipRightVector_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroRhythmGameShipController.__GetShipRightVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameShipController.__GetShipRightVector_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameShipController.__GetShipRightVector_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C28D RID: 115341 RVA: 0x00297ED0 File Offset: 0x002960D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FVector GetShipPosition()
		{
			UKuroRhythmGameShipController.__GetShipPosition_FunctionParams* ptr = stackalloc UKuroRhythmGameShipController.__GetShipPosition_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroRhythmGameShipController.__GetShipPosition_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameShipController.__GetShipPosition_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameShipController.__GetShipPosition_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C28E RID: 115342 RVA: 0x00297F18 File Offset: 0x00296118
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FVector GetShipForwardVector()
		{
			UKuroRhythmGameShipController.__GetShipForwardVector_FunctionParams* ptr = stackalloc UKuroRhythmGameShipController.__GetShipForwardVector_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroRhythmGameShipController.__GetShipForwardVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameShipController.__GetShipForwardVector_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameShipController.__GetShipForwardVector_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C28F RID: 115343 RVA: 0x00297F60 File Offset: 0x00296160
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe float GetMovementSpeed()
		{
			UKuroRhythmGameShipController.__GetMovementSpeed_FunctionParams* ptr = stackalloc UKuroRhythmGameShipController.__GetMovementSpeed_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroRhythmGameShipController.__GetMovementSpeed_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameShipController.__GetMovementSpeed_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameShipController.__GetMovementSpeed_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C290 RID: 115344 RVA: 0x00297FA8 File Offset: 0x002961A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe float GetCurrentSplineDistance()
		{
			UKuroRhythmGameShipController.__GetCurrentSplineDistance_FunctionParams* ptr = stackalloc UKuroRhythmGameShipController.__GetCurrentSplineDistance_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroRhythmGameShipController.__GetCurrentSplineDistance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameShipController.__GetCurrentSplineDistance_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameShipController.__GetCurrentSplineDistance_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C291 RID: 115345 RVA: 0x00297FF0 File Offset: 0x002961F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe float GetCurrentHorizontalRotation()
		{
			UKuroRhythmGameShipController.__GetCurrentHorizontalRotation_FunctionParams* ptr = stackalloc UKuroRhythmGameShipController.__GetCurrentHorizontalRotation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroRhythmGameShipController.__GetCurrentHorizontalRotation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameShipController.__GetCurrentHorizontalRotation_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameShipController.__GetCurrentHorizontalRotation_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C292 RID: 115346 RVA: 0x00298036 File Offset: 0x00296236
		static UKuroRhythmGameShipController()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRhythmGame.KuroRhythmGameShipController");
		}

		// Token: 0x0601C293 RID: 115347 RVA: 0x00298044 File Offset: 0x00296244
		protected UKuroRhythmGameShipController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F251 RID: 62033
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRhythmGame.KuroRhythmGameShipController";

		// Token: 0x0400F252 RID: 62034
		private static IntPtr _ClassPtr;

		// Token: 0x0400F253 RID: 62035
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F254 RID: 62036
		internal static int __PropertyOffset_ShipActor;

		// Token: 0x0400F255 RID: 62037
		internal static int __PropertyOffset_Spline;

		// Token: 0x0400F256 RID: 62038
		internal static int __PropertyOffset_GameManager;

		// Token: 0x0400F257 RID: 62039
		internal static int __PropertyOffset_MovementSpeed;

		// Token: 0x0400F258 RID: 62040
		internal static int __PropertyOffset_TargetMovementSpeed;

		// Token: 0x0400F259 RID: 62041
		internal static int __PropertyOffset_SpeedAcceleration;

		// Token: 0x0400F25A RID: 62042
		internal static int __PropertyOffset_CurrentSplineDistance;

		// Token: 0x0400F25B RID: 62043
		internal static int __PropertyOffset_bIsMoving;

		// Token: 0x0400F25C RID: 62044
		internal static int __PropertyOffset_LastGameplayTime;

		// Token: 0x0400F25D RID: 62045
		internal static int __PropertyOffset_bMovingTowardsEnd;

		// Token: 0x0400F25E RID: 62046
		internal static int __PropertyOffset_SplineLength;

		// Token: 0x0400F25F RID: 62047
		internal static int __PropertyOffset_bIsSwitchingTrack;

		// Token: 0x0400F260 RID: 62048
		internal static int __PropertyOffset_TrackSwitchTargetOffset;

		// Token: 0x0400F261 RID: 62049
		internal static int __PropertyOffset_TrackSwitchDuration;

		// Token: 0x0400F262 RID: 62050
		internal static int __PropertyOffset_TrackSwitchElapsedTime;

		// Token: 0x0400F263 RID: 62051
		internal static int __PropertyOffset_TrackSwitchStartOffset;

		// Token: 0x0400F264 RID: 62052
		internal static int __PropertyOffset_CurrentLateralOffset;

		// Token: 0x0400F265 RID: 62053
		private static IntPtr __StopMovement_NativeFunctionPtr;

		// Token: 0x0400F266 RID: 62054
		private static IntPtr __StartTrackSwitch_NativeFunctionPtr;

		// Token: 0x0400F267 RID: 62055
		private static IntPtr __StartMovement_NativeFunctionPtr;

		// Token: 0x0400F268 RID: 62056
		private static IntPtr __StartJump_NativeFunctionPtr;

		// Token: 0x0400F269 RID: 62057
		private static IntPtr __ResumeMovement_NativeFunctionPtr;

		// Token: 0x0400F26A RID: 62058
		private static IntPtr __ResetToStart_NativeFunctionPtr;

		// Token: 0x0400F26B RID: 62059
		private static IntPtr __PauseMovement_NativeFunctionPtr;

		// Token: 0x0400F26C RID: 62060
		private static IntPtr __IsTrackSwitching_NativeFunctionPtr;

		// Token: 0x0400F26D RID: 62061
		private static IntPtr __IsMoving_NativeFunctionPtr;

		// Token: 0x0400F26E RID: 62062
		private static IntPtr __Initialize_NativeFunctionPtr;

		// Token: 0x0400F26F RID: 62063
		private static IntPtr __GetSplineLength_NativeFunctionPtr;

		// Token: 0x0400F270 RID: 62064
		private static IntPtr __GetShipUpVector_NativeFunctionPtr;

		// Token: 0x0400F271 RID: 62065
		private static IntPtr __GetShipRotation_NativeFunctionPtr;

		// Token: 0x0400F272 RID: 62066
		private static IntPtr __GetShipRightVector_NativeFunctionPtr;

		// Token: 0x0400F273 RID: 62067
		private static IntPtr __GetShipPosition_NativeFunctionPtr;

		// Token: 0x0400F274 RID: 62068
		private static IntPtr __GetShipForwardVector_NativeFunctionPtr;

		// Token: 0x0400F275 RID: 62069
		private static IntPtr __GetMovementSpeed_NativeFunctionPtr;

		// Token: 0x0400F276 RID: 62070
		private static IntPtr __GetCurrentSplineDistance_NativeFunctionPtr;

		// Token: 0x0400F277 RID: 62071
		private static IntPtr __GetCurrentHorizontalRotation_NativeFunctionPtr;

		// Token: 0x020031E1 RID: 12769
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __StartTrackSwitch_FunctionParams
		{
			// Token: 0x04017034 RID: 94260
			[FieldOffset(0)]
			public float TargetLateralOffset;

			// Token: 0x04017035 RID: 94261
			[FieldOffset(4)]
			public float SwitchDuration;

			// Token: 0x04017036 RID: 94262
			[FieldOffset(8)]
			public bool bInterrupt;
		}

		// Token: 0x020031E2 RID: 12770
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __StartJump_FunctionParams
		{
			// Token: 0x04017037 RID: 94263
			[FieldOffset(0)]
			public float JumpDurationMs;
		}

		// Token: 0x020031E3 RID: 12771
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsTrackSwitching_FunctionParams
		{
			// Token: 0x04017038 RID: 94264
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x020031E4 RID: 12772
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsMoving_FunctionParams
		{
			// Token: 0x04017039 RID: 94265
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x020031E5 RID: 12773
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Initialize_FunctionParams
		{
			// Token: 0x0401703A RID: 94266
			[FieldOffset(0)]
			public IntPtr InShipActor;

			// Token: 0x0401703B RID: 94267
			[FieldOffset(8)]
			public IntPtr InSpline;

			// Token: 0x0401703C RID: 94268
			[FieldOffset(16)]
			public IntPtr InGameManager;
		}

		// Token: 0x020031E6 RID: 12774
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetSplineLength_FunctionParams
		{
			// Token: 0x0401703D RID: 94269
			[FieldOffset(0)]
			public float __Result;
		}

		// Token: 0x020031E7 RID: 12775
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetShipUpVector_FunctionParams
		{
			// Token: 0x0401703E RID: 94270
			[FieldOffset(0)]
			public FVector __Result;
		}

		// Token: 0x020031E8 RID: 12776
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetShipRotation_FunctionParams
		{
			// Token: 0x0401703F RID: 94271
			[FieldOffset(0)]
			public FRotator __Result;
		}

		// Token: 0x020031E9 RID: 12777
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetShipRightVector_FunctionParams
		{
			// Token: 0x04017040 RID: 94272
			[FieldOffset(0)]
			public FVector __Result;
		}

		// Token: 0x020031EA RID: 12778
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetShipPosition_FunctionParams
		{
			// Token: 0x04017041 RID: 94273
			[FieldOffset(0)]
			public FVector __Result;
		}

		// Token: 0x020031EB RID: 12779
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetShipForwardVector_FunctionParams
		{
			// Token: 0x04017042 RID: 94274
			[FieldOffset(0)]
			public FVector __Result;
		}

		// Token: 0x020031EC RID: 12780
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetMovementSpeed_FunctionParams
		{
			// Token: 0x04017043 RID: 94275
			[FieldOffset(0)]
			public float __Result;
		}

		// Token: 0x020031ED RID: 12781
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetCurrentSplineDistance_FunctionParams
		{
			// Token: 0x04017044 RID: 94276
			[FieldOffset(0)]
			public float __Result;
		}

		// Token: 0x020031EE RID: 12782
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetCurrentHorizontalRotation_FunctionParams
		{
			// Token: 0x04017045 RID: 94277
			[FieldOffset(0)]
			public float __Result;
		}
	}
}
