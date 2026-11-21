using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000503 RID: 1283
	[UnrealObjectPath("/Script/KuroRhythmGame.KuroRhythmGameShipController")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UKuroRhythmGameShipController : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007884 RID: 30852 RVA: 0x000B0891 File Offset: 0x000AEA91
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRhythmGameShipController._ClassPtr;
		}

		// Token: 0x06007885 RID: 30853 RVA: 0x000B08A0 File Offset: 0x000AEAA0
		public UKuroRhythmGameShipController() : this(BuiltinUtils.AllocNativeUObject(UKuroRhythmGameShipController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007886 RID: 30854 RVA: 0x000B08C8 File Offset: 0x000AEAC8
		[NullableContext(1)]
		public UKuroRhythmGameShipController(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRhythmGameShipController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001764 RID: 5988
		// (get) Token: 0x06007887 RID: 30855 RVA: 0x000B08FB File Offset: 0x000AEAFB
		// (set) Token: 0x06007888 RID: 30856 RVA: 0x000B090F File Offset: 0x000AEB0F
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

		// Token: 0x17001765 RID: 5989
		// (get) Token: 0x06007889 RID: 30857 RVA: 0x000B0924 File Offset: 0x000AEB24
		// (set) Token: 0x0600788A RID: 30858 RVA: 0x000B0938 File Offset: 0x000AEB38
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

		// Token: 0x17001766 RID: 5990
		// (get) Token: 0x0600788B RID: 30859 RVA: 0x000B094D File Offset: 0x000AEB4D
		// (set) Token: 0x0600788C RID: 30860 RVA: 0x000B0961 File Offset: 0x000AEB61
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

		// Token: 0x17001767 RID: 5991
		// (get) Token: 0x0600788D RID: 30861 RVA: 0x000B0976 File Offset: 0x000AEB76
		// (set) Token: 0x0600788E RID: 30862 RVA: 0x000B0986 File Offset: 0x000AEB86
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

		// Token: 0x17001768 RID: 5992
		// (get) Token: 0x0600788F RID: 30863 RVA: 0x000B0997 File Offset: 0x000AEB97
		// (set) Token: 0x06007890 RID: 30864 RVA: 0x000B09A7 File Offset: 0x000AEBA7
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

		// Token: 0x17001769 RID: 5993
		// (get) Token: 0x06007891 RID: 30865 RVA: 0x000B09B8 File Offset: 0x000AEBB8
		// (set) Token: 0x06007892 RID: 30866 RVA: 0x000B09C8 File Offset: 0x000AEBC8
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

		// Token: 0x1700176A RID: 5994
		// (get) Token: 0x06007893 RID: 30867 RVA: 0x000B09D9 File Offset: 0x000AEBD9
		// (set) Token: 0x06007894 RID: 30868 RVA: 0x000B09E9 File Offset: 0x000AEBE9
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

		// Token: 0x1700176B RID: 5995
		// (get) Token: 0x06007895 RID: 30869 RVA: 0x000B09FA File Offset: 0x000AEBFA
		// (set) Token: 0x06007896 RID: 30870 RVA: 0x000B0A0A File Offset: 0x000AEC0A
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

		// Token: 0x1700176C RID: 5996
		// (get) Token: 0x06007897 RID: 30871 RVA: 0x000B0A1B File Offset: 0x000AEC1B
		// (set) Token: 0x06007898 RID: 30872 RVA: 0x000B0A2B File Offset: 0x000AEC2B
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

		// Token: 0x1700176D RID: 5997
		// (get) Token: 0x06007899 RID: 30873 RVA: 0x000B0A3C File Offset: 0x000AEC3C
		// (set) Token: 0x0600789A RID: 30874 RVA: 0x000B0A4C File Offset: 0x000AEC4C
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

		// Token: 0x1700176E RID: 5998
		// (get) Token: 0x0600789B RID: 30875 RVA: 0x000B0A5D File Offset: 0x000AEC5D
		// (set) Token: 0x0600789C RID: 30876 RVA: 0x000B0A6D File Offset: 0x000AEC6D
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

		// Token: 0x1700176F RID: 5999
		// (get) Token: 0x0600789D RID: 30877 RVA: 0x000B0A7E File Offset: 0x000AEC7E
		// (set) Token: 0x0600789E RID: 30878 RVA: 0x000B0A8E File Offset: 0x000AEC8E
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

		// Token: 0x17001770 RID: 6000
		// (get) Token: 0x0600789F RID: 30879 RVA: 0x000B0A9F File Offset: 0x000AEC9F
		// (set) Token: 0x060078A0 RID: 30880 RVA: 0x000B0AAF File Offset: 0x000AECAF
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

		// Token: 0x17001771 RID: 6001
		// (get) Token: 0x060078A1 RID: 30881 RVA: 0x000B0AC0 File Offset: 0x000AECC0
		// (set) Token: 0x060078A2 RID: 30882 RVA: 0x000B0AD0 File Offset: 0x000AECD0
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

		// Token: 0x17001772 RID: 6002
		// (get) Token: 0x060078A3 RID: 30883 RVA: 0x000B0AE1 File Offset: 0x000AECE1
		// (set) Token: 0x060078A4 RID: 30884 RVA: 0x000B0AF1 File Offset: 0x000AECF1
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

		// Token: 0x17001773 RID: 6003
		// (get) Token: 0x060078A5 RID: 30885 RVA: 0x000B0B02 File Offset: 0x000AED02
		// (set) Token: 0x060078A6 RID: 30886 RVA: 0x000B0B12 File Offset: 0x000AED12
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

		// Token: 0x17001774 RID: 6004
		// (get) Token: 0x060078A7 RID: 30887 RVA: 0x000B0B23 File Offset: 0x000AED23
		// (set) Token: 0x060078A8 RID: 30888 RVA: 0x000B0B33 File Offset: 0x000AED33
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

		// Token: 0x060078A9 RID: 30889 RVA: 0x000B0B44 File Offset: 0x000AED44
		[SkipLocalsInit]
		public void StopMovement()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameShipController.__StopMovement_NativeFunctionPtr, null);
		}

		// Token: 0x060078AA RID: 30890 RVA: 0x000B0B58 File Offset: 0x000AED58
		[SkipLocalsInit]
		public unsafe void StartTrackSwitch(float TargetLateralOffset, float SwitchDuration = 0.3f, bool bInterrupt = false)
		{
			UKuroRhythmGameShipController.__StartTrackSwitch_FunctionParams* ptr = stackalloc UKuroRhythmGameShipController.__StartTrackSwitch_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroRhythmGameShipController.__StartTrackSwitch_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameShipController.__StartTrackSwitch_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TargetLateralOffset = TargetLateralOffset;
			ptr->SwitchDuration = SwitchDuration;
			ptr->bInterrupt = bInterrupt;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameShipController.__StartTrackSwitch_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060078AB RID: 30891 RVA: 0x000B0BAC File Offset: 0x000AEDAC
		[SkipLocalsInit]
		public void StartMovement()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameShipController.__StartMovement_NativeFunctionPtr, null);
		}

		// Token: 0x060078AC RID: 30892 RVA: 0x000B0BC0 File Offset: 0x000AEDC0
		[SkipLocalsInit]
		public unsafe void StartJump(float JumpDurationMs)
		{
			UKuroRhythmGameShipController.__StartJump_FunctionParams* ptr = stackalloc UKuroRhythmGameShipController.__StartJump_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroRhythmGameShipController.__StartJump_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameShipController.__StartJump_NativeFunctionPtr, (void*)ptr, 1);
			ptr->JumpDurationMs = JumpDurationMs;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameShipController.__StartJump_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060078AD RID: 30893 RVA: 0x000B0C06 File Offset: 0x000AEE06
		[SkipLocalsInit]
		public void ResumeMovement()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameShipController.__ResumeMovement_NativeFunctionPtr, null);
		}

		// Token: 0x060078AE RID: 30894 RVA: 0x000B0C1A File Offset: 0x000AEE1A
		[SkipLocalsInit]
		public void ResetToStart()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameShipController.__ResetToStart_NativeFunctionPtr, null);
		}

		// Token: 0x060078AF RID: 30895 RVA: 0x000B0C2E File Offset: 0x000AEE2E
		[SkipLocalsInit]
		public void PauseMovement()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameShipController.__PauseMovement_NativeFunctionPtr, null);
		}

		// Token: 0x060078B0 RID: 30896 RVA: 0x000B0C44 File Offset: 0x000AEE44
		[SkipLocalsInit]
		public unsafe bool IsTrackSwitching()
		{
			UKuroRhythmGameShipController.__IsTrackSwitching_FunctionParams* ptr = stackalloc UKuroRhythmGameShipController.__IsTrackSwitching_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroRhythmGameShipController.__IsTrackSwitching_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameShipController.__IsTrackSwitching_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameShipController.__IsTrackSwitching_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060078B1 RID: 30897 RVA: 0x000B0C8C File Offset: 0x000AEE8C
		[SkipLocalsInit]
		public unsafe bool IsMoving()
		{
			UKuroRhythmGameShipController.__IsMoving_FunctionParams* ptr = stackalloc UKuroRhythmGameShipController.__IsMoving_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroRhythmGameShipController.__IsMoving_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameShipController.__IsMoving_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameShipController.__IsMoving_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060078B2 RID: 30898 RVA: 0x000B0CD4 File Offset: 0x000AEED4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Initialize(AActor InShipActor, USplineComponent InSpline, UKuroRhythmGameManager InGameManager)
		{
			UKuroRhythmGameShipController.__Initialize_FunctionParams* ptr = stackalloc UKuroRhythmGameShipController.__Initialize_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroRhythmGameShipController.__Initialize_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameShipController.__Initialize_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InShipActor = ((InShipActor != null) ? InShipActor.NativePtr : IntPtr.Zero);
			ptr->InSpline = ((InSpline != null) ? InSpline.NativePtr : IntPtr.Zero);
			ptr->InGameManager = ((InGameManager != null) ? InGameManager.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameShipController.__Initialize_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060078B3 RID: 30899 RVA: 0x000B0D58 File Offset: 0x000AEF58
		[SkipLocalsInit]
		public unsafe float GetSplineLength()
		{
			UKuroRhythmGameShipController.__GetSplineLength_FunctionParams* ptr = stackalloc UKuroRhythmGameShipController.__GetSplineLength_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroRhythmGameShipController.__GetSplineLength_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameShipController.__GetSplineLength_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameShipController.__GetSplineLength_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060078B4 RID: 30900 RVA: 0x000B0DA0 File Offset: 0x000AEFA0
		[SkipLocalsInit]
		public unsafe FVector GetShipUpVector()
		{
			UKuroRhythmGameShipController.__GetShipUpVector_FunctionParams* ptr = stackalloc UKuroRhythmGameShipController.__GetShipUpVector_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroRhythmGameShipController.__GetShipUpVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameShipController.__GetShipUpVector_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameShipController.__GetShipUpVector_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060078B5 RID: 30901 RVA: 0x000B0DE8 File Offset: 0x000AEFE8
		[SkipLocalsInit]
		public unsafe FRotator GetShipRotation()
		{
			UKuroRhythmGameShipController.__GetShipRotation_FunctionParams* ptr = stackalloc UKuroRhythmGameShipController.__GetShipRotation_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroRhythmGameShipController.__GetShipRotation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameShipController.__GetShipRotation_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameShipController.__GetShipRotation_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060078B6 RID: 30902 RVA: 0x000B0E30 File Offset: 0x000AF030
		[SkipLocalsInit]
		public unsafe FVector GetShipRightVector()
		{
			UKuroRhythmGameShipController.__GetShipRightVector_FunctionParams* ptr = stackalloc UKuroRhythmGameShipController.__GetShipRightVector_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroRhythmGameShipController.__GetShipRightVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameShipController.__GetShipRightVector_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameShipController.__GetShipRightVector_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060078B7 RID: 30903 RVA: 0x000B0E78 File Offset: 0x000AF078
		[SkipLocalsInit]
		public unsafe FVector GetShipPosition()
		{
			UKuroRhythmGameShipController.__GetShipPosition_FunctionParams* ptr = stackalloc UKuroRhythmGameShipController.__GetShipPosition_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroRhythmGameShipController.__GetShipPosition_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameShipController.__GetShipPosition_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameShipController.__GetShipPosition_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060078B8 RID: 30904 RVA: 0x000B0EC0 File Offset: 0x000AF0C0
		[SkipLocalsInit]
		public unsafe FVector GetShipForwardVector()
		{
			UKuroRhythmGameShipController.__GetShipForwardVector_FunctionParams* ptr = stackalloc UKuroRhythmGameShipController.__GetShipForwardVector_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroRhythmGameShipController.__GetShipForwardVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameShipController.__GetShipForwardVector_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameShipController.__GetShipForwardVector_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060078B9 RID: 30905 RVA: 0x000B0F08 File Offset: 0x000AF108
		[SkipLocalsInit]
		public unsafe float GetMovementSpeed()
		{
			UKuroRhythmGameShipController.__GetMovementSpeed_FunctionParams* ptr = stackalloc UKuroRhythmGameShipController.__GetMovementSpeed_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroRhythmGameShipController.__GetMovementSpeed_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameShipController.__GetMovementSpeed_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameShipController.__GetMovementSpeed_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060078BA RID: 30906 RVA: 0x000B0F50 File Offset: 0x000AF150
		[SkipLocalsInit]
		public unsafe float GetCurrentSplineDistance()
		{
			UKuroRhythmGameShipController.__GetCurrentSplineDistance_FunctionParams* ptr = stackalloc UKuroRhythmGameShipController.__GetCurrentSplineDistance_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroRhythmGameShipController.__GetCurrentSplineDistance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameShipController.__GetCurrentSplineDistance_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameShipController.__GetCurrentSplineDistance_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060078BB RID: 30907 RVA: 0x000B0F98 File Offset: 0x000AF198
		[SkipLocalsInit]
		public unsafe float GetCurrentHorizontalRotation()
		{
			UKuroRhythmGameShipController.__GetCurrentHorizontalRotation_FunctionParams* ptr = stackalloc UKuroRhythmGameShipController.__GetCurrentHorizontalRotation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroRhythmGameShipController.__GetCurrentHorizontalRotation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameShipController.__GetCurrentHorizontalRotation_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameShipController.__GetCurrentHorizontalRotation_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060078BC RID: 30908 RVA: 0x000B0FDD File Offset: 0x000AF1DD
		static UKuroRhythmGameShipController()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRhythmGame.KuroRhythmGameShipController");
		}

		// Token: 0x060078BD RID: 30909 RVA: 0x000B0FEB File Offset: 0x000AF1EB
		protected UKuroRhythmGameShipController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003336 RID: 13110
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRhythmGame.KuroRhythmGameShipController";

		// Token: 0x04003337 RID: 13111
		private static IntPtr _ClassPtr;

		// Token: 0x04003338 RID: 13112
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003339 RID: 13113
		internal static int __PropertyOffset_ShipActor;

		// Token: 0x0400333A RID: 13114
		internal static int __PropertyOffset_Spline;

		// Token: 0x0400333B RID: 13115
		internal static int __PropertyOffset_GameManager;

		// Token: 0x0400333C RID: 13116
		internal static int __PropertyOffset_MovementSpeed;

		// Token: 0x0400333D RID: 13117
		internal static int __PropertyOffset_TargetMovementSpeed;

		// Token: 0x0400333E RID: 13118
		internal static int __PropertyOffset_SpeedAcceleration;

		// Token: 0x0400333F RID: 13119
		internal static int __PropertyOffset_CurrentSplineDistance;

		// Token: 0x04003340 RID: 13120
		internal static int __PropertyOffset_bIsMoving;

		// Token: 0x04003341 RID: 13121
		internal static int __PropertyOffset_LastGameplayTime;

		// Token: 0x04003342 RID: 13122
		internal static int __PropertyOffset_bMovingTowardsEnd;

		// Token: 0x04003343 RID: 13123
		internal static int __PropertyOffset_SplineLength;

		// Token: 0x04003344 RID: 13124
		internal static int __PropertyOffset_bIsSwitchingTrack;

		// Token: 0x04003345 RID: 13125
		internal static int __PropertyOffset_TrackSwitchTargetOffset;

		// Token: 0x04003346 RID: 13126
		internal static int __PropertyOffset_TrackSwitchDuration;

		// Token: 0x04003347 RID: 13127
		internal static int __PropertyOffset_TrackSwitchElapsedTime;

		// Token: 0x04003348 RID: 13128
		internal static int __PropertyOffset_TrackSwitchStartOffset;

		// Token: 0x04003349 RID: 13129
		internal static int __PropertyOffset_CurrentLateralOffset;

		// Token: 0x0400334A RID: 13130
		private static IntPtr __StopMovement_NativeFunctionPtr;

		// Token: 0x0400334B RID: 13131
		private static IntPtr __StartTrackSwitch_NativeFunctionPtr;

		// Token: 0x0400334C RID: 13132
		private static IntPtr __StartMovement_NativeFunctionPtr;

		// Token: 0x0400334D RID: 13133
		private static IntPtr __StartJump_NativeFunctionPtr;

		// Token: 0x0400334E RID: 13134
		private static IntPtr __ResumeMovement_NativeFunctionPtr;

		// Token: 0x0400334F RID: 13135
		private static IntPtr __ResetToStart_NativeFunctionPtr;

		// Token: 0x04003350 RID: 13136
		private static IntPtr __PauseMovement_NativeFunctionPtr;

		// Token: 0x04003351 RID: 13137
		private static IntPtr __IsTrackSwitching_NativeFunctionPtr;

		// Token: 0x04003352 RID: 13138
		private static IntPtr __IsMoving_NativeFunctionPtr;

		// Token: 0x04003353 RID: 13139
		private static IntPtr __Initialize_NativeFunctionPtr;

		// Token: 0x04003354 RID: 13140
		private static IntPtr __GetSplineLength_NativeFunctionPtr;

		// Token: 0x04003355 RID: 13141
		private static IntPtr __GetShipUpVector_NativeFunctionPtr;

		// Token: 0x04003356 RID: 13142
		private static IntPtr __GetShipRotation_NativeFunctionPtr;

		// Token: 0x04003357 RID: 13143
		private static IntPtr __GetShipRightVector_NativeFunctionPtr;

		// Token: 0x04003358 RID: 13144
		private static IntPtr __GetShipPosition_NativeFunctionPtr;

		// Token: 0x04003359 RID: 13145
		private static IntPtr __GetShipForwardVector_NativeFunctionPtr;

		// Token: 0x0400335A RID: 13146
		private static IntPtr __GetMovementSpeed_NativeFunctionPtr;

		// Token: 0x0400335B RID: 13147
		private static IntPtr __GetCurrentSplineDistance_NativeFunctionPtr;

		// Token: 0x0400335C RID: 13148
		private static IntPtr __GetCurrentHorizontalRotation_NativeFunctionPtr;

		// Token: 0x02000C58 RID: 3160
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __StartTrackSwitch_FunctionParams
		{
			// Token: 0x04005EAD RID: 24237
			[FieldOffset(0)]
			public float TargetLateralOffset;

			// Token: 0x04005EAE RID: 24238
			[FieldOffset(4)]
			public float SwitchDuration;

			// Token: 0x04005EAF RID: 24239
			[FieldOffset(8)]
			public bool bInterrupt;
		}

		// Token: 0x02000C59 RID: 3161
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __StartJump_FunctionParams
		{
			// Token: 0x04005EB0 RID: 24240
			[FieldOffset(0)]
			public float JumpDurationMs;
		}

		// Token: 0x02000C5A RID: 3162
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsTrackSwitching_FunctionParams
		{
			// Token: 0x04005EB1 RID: 24241
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000C5B RID: 3163
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsMoving_FunctionParams
		{
			// Token: 0x04005EB2 RID: 24242
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000C5C RID: 3164
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Initialize_FunctionParams
		{
			// Token: 0x04005EB3 RID: 24243
			[FieldOffset(0)]
			public IntPtr InShipActor;

			// Token: 0x04005EB4 RID: 24244
			[FieldOffset(8)]
			public IntPtr InSpline;

			// Token: 0x04005EB5 RID: 24245
			[FieldOffset(16)]
			public IntPtr InGameManager;
		}

		// Token: 0x02000C5D RID: 3165
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetSplineLength_FunctionParams
		{
			// Token: 0x04005EB6 RID: 24246
			[FieldOffset(0)]
			public float __Result;
		}

		// Token: 0x02000C5E RID: 3166
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetShipUpVector_FunctionParams
		{
			// Token: 0x04005EB7 RID: 24247
			[FieldOffset(0)]
			public FVector __Result;
		}

		// Token: 0x02000C5F RID: 3167
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetShipRotation_FunctionParams
		{
			// Token: 0x04005EB8 RID: 24248
			[FieldOffset(0)]
			public FRotator __Result;
		}

		// Token: 0x02000C60 RID: 3168
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetShipRightVector_FunctionParams
		{
			// Token: 0x04005EB9 RID: 24249
			[FieldOffset(0)]
			public FVector __Result;
		}

		// Token: 0x02000C61 RID: 3169
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetShipPosition_FunctionParams
		{
			// Token: 0x04005EBA RID: 24250
			[FieldOffset(0)]
			public FVector __Result;
		}

		// Token: 0x02000C62 RID: 3170
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetShipForwardVector_FunctionParams
		{
			// Token: 0x04005EBB RID: 24251
			[FieldOffset(0)]
			public FVector __Result;
		}

		// Token: 0x02000C63 RID: 3171
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetMovementSpeed_FunctionParams
		{
			// Token: 0x04005EBC RID: 24252
			[FieldOffset(0)]
			public float __Result;
		}

		// Token: 0x02000C64 RID: 3172
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetCurrentSplineDistance_FunctionParams
		{
			// Token: 0x04005EBD RID: 24253
			[FieldOffset(0)]
			public float __Result;
		}

		// Token: 0x02000C65 RID: 3173
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetCurrentHorizontalRotation_FunctionParams
		{
			// Token: 0x04005EBE RID: 24254
			[FieldOffset(0)]
			public float __Result;
		}
	}
}
