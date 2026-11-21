using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200034D RID: 845
	[UnrealObjectPath("/Script/KuroComponent.KuroSceneItemMoveComponent")]
	[UnrealStructLayout(832, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 832)]
	public class UKuroSceneItemMoveComponent : UMovementComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600567B RID: 22139 RVA: 0x000793BA File Offset: 0x000775BA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSceneItemMoveComponent._ClassPtr;
		}

		// Token: 0x0600567C RID: 22140 RVA: 0x000793C8 File Offset: 0x000775C8
		public UKuroSceneItemMoveComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroSceneItemMoveComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600567D RID: 22141 RVA: 0x000793F0 File Offset: 0x000775F0
		[NullableContext(1)]
		public UKuroSceneItemMoveComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSceneItemMoveComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170010FB RID: 4347
		// (get) Token: 0x0600567E RID: 22142 RVA: 0x00079423 File Offset: 0x00077623
		// (set) Token: 0x0600567F RID: 22143 RVA: 0x00079433 File Offset: 0x00077633
		public unsafe float CustomTimeDilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSceneItemMoveComponent.__PropertyOffset_CustomTimeDilation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSceneItemMoveComponent.__PropertyOffset_CustomTimeDilation) = value;
			}
		}

		// Token: 0x170010FC RID: 4348
		// (get) Token: 0x06005680 RID: 22144 RVA: 0x00079444 File Offset: 0x00077644
		// (set) Token: 0x06005681 RID: 22145 RVA: 0x0007945D File Offset: 0x0007765D
		public unsafe bool bUseRVOAvoidance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UKuroSceneItemMoveComponent.__PropertyOffset_bUseRVOAvoidance) & UKuroSceneItemMoveComponent.__PropertyMask_bUseRVOAvoidance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UKuroSceneItemMoveComponent.__PropertyOffset_bUseRVOAvoidance) = ((*(base.NativePtr + (IntPtr)UKuroSceneItemMoveComponent.__PropertyOffset_bUseRVOAvoidance) & ~UKuroSceneItemMoveComponent.__PropertyMask_bUseRVOAvoidance) | (value ? UKuroSceneItemMoveComponent.__PropertyMask_bUseRVOAvoidance : 0));
			}
		}

		// Token: 0x170010FD RID: 4349
		// (get) Token: 0x06005682 RID: 22146 RVA: 0x0007948D File Offset: 0x0007768D
		// (set) Token: 0x06005683 RID: 22147 RVA: 0x0007949D File Offset: 0x0007769D
		public unsafe int AvoidanceUID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSceneItemMoveComponent.__PropertyOffset_AvoidanceUID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSceneItemMoveComponent.__PropertyOffset_AvoidanceUID) = value;
			}
		}

		// Token: 0x170010FE RID: 4350
		// (get) Token: 0x06005684 RID: 22148 RVA: 0x000794B0 File Offset: 0x000776B0
		// (set) Token: 0x06005685 RID: 22149 RVA: 0x000794E9 File Offset: 0x000776E9
		[Nullable(1)]
		public FNavAvoidanceMask AvoidanceGroup
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FNavAvoidanceMask result;
				if ((result = this._AvoidanceGroup) == null)
				{
					result = (this._AvoidanceGroup = new FNavAvoidanceMask(base.NativePtr + (IntPtr)UKuroSceneItemMoveComponent.__PropertyOffset_AvoidanceGroup, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNavAvoidanceMask.StaticStruct(), base.NativePtr + (IntPtr)UKuroSceneItemMoveComponent.__PropertyOffset_AvoidanceGroup, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170010FF RID: 4351
		// (get) Token: 0x06005686 RID: 22150 RVA: 0x0007950C File Offset: 0x0007770C
		// (set) Token: 0x06005687 RID: 22151 RVA: 0x00079545 File Offset: 0x00077745
		[Nullable(1)]
		public FNavAvoidanceMask GroupsToAvoid
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FNavAvoidanceMask result;
				if ((result = this._GroupsToAvoid) == null)
				{
					result = (this._GroupsToAvoid = new FNavAvoidanceMask(base.NativePtr + (IntPtr)UKuroSceneItemMoveComponent.__PropertyOffset_GroupsToAvoid, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNavAvoidanceMask.StaticStruct(), base.NativePtr + (IntPtr)UKuroSceneItemMoveComponent.__PropertyOffset_GroupsToAvoid, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001100 RID: 4352
		// (get) Token: 0x06005688 RID: 22152 RVA: 0x00079568 File Offset: 0x00077768
		// (set) Token: 0x06005689 RID: 22153 RVA: 0x000795A1 File Offset: 0x000777A1
		[Nullable(1)]
		public FNavAvoidanceMask GroupsToIgnore
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FNavAvoidanceMask result;
				if ((result = this._GroupsToIgnore) == null)
				{
					result = (this._GroupsToIgnore = new FNavAvoidanceMask(base.NativePtr + (IntPtr)UKuroSceneItemMoveComponent.__PropertyOffset_GroupsToIgnore, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNavAvoidanceMask.StaticStruct(), base.NativePtr + (IntPtr)UKuroSceneItemMoveComponent.__PropertyOffset_GroupsToIgnore, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001101 RID: 4353
		// (get) Token: 0x0600568A RID: 22154 RVA: 0x000795C2 File Offset: 0x000777C2
		// (set) Token: 0x0600568B RID: 22155 RVA: 0x000795D2 File Offset: 0x000777D2
		public unsafe float AvoidanceWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSceneItemMoveComponent.__PropertyOffset_AvoidanceWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSceneItemMoveComponent.__PropertyOffset_AvoidanceWeight) = value;
			}
		}

		// Token: 0x17001102 RID: 4354
		// (get) Token: 0x0600568C RID: 22156 RVA: 0x000795E3 File Offset: 0x000777E3
		// (set) Token: 0x0600568D RID: 22157 RVA: 0x000795F3 File Offset: 0x000777F3
		public unsafe float AvoidanceHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSceneItemMoveComponent.__PropertyOffset_AvoidanceHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSceneItemMoveComponent.__PropertyOffset_AvoidanceHeight) = value;
			}
		}

		// Token: 0x17001103 RID: 4355
		// (get) Token: 0x0600568E RID: 22158 RVA: 0x00079604 File Offset: 0x00077804
		// (set) Token: 0x0600568F RID: 22159 RVA: 0x00079614 File Offset: 0x00077814
		public unsafe float AvoidanceRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSceneItemMoveComponent.__PropertyOffset_AvoidanceRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSceneItemMoveComponent.__PropertyOffset_AvoidanceRadius) = value;
			}
		}

		// Token: 0x17001104 RID: 4356
		// (get) Token: 0x06005690 RID: 22160 RVA: 0x00079625 File Offset: 0x00077825
		// (set) Token: 0x06005691 RID: 22161 RVA: 0x00079635 File Offset: 0x00077835
		public unsafe float AvoidanceConsiderationRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSceneItemMoveComponent.__PropertyOffset_AvoidanceConsiderationRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSceneItemMoveComponent.__PropertyOffset_AvoidanceConsiderationRadius) = value;
			}
		}

		// Token: 0x17001105 RID: 4357
		// (get) Token: 0x06005692 RID: 22162 RVA: 0x00079646 File Offset: 0x00077846
		// (set) Token: 0x06005693 RID: 22163 RVA: 0x0007965F File Offset: 0x0007785F
		public unsafe bool bWasAvoidanceUpdated
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UKuroSceneItemMoveComponent.__PropertyOffset_bWasAvoidanceUpdated) & UKuroSceneItemMoveComponent.__PropertyMask_bWasAvoidanceUpdated) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UKuroSceneItemMoveComponent.__PropertyOffset_bWasAvoidanceUpdated) = ((*(base.NativePtr + (IntPtr)UKuroSceneItemMoveComponent.__PropertyOffset_bWasAvoidanceUpdated) & ~UKuroSceneItemMoveComponent.__PropertyMask_bWasAvoidanceUpdated) | (value ? UKuroSceneItemMoveComponent.__PropertyMask_bWasAvoidanceUpdated : 0));
			}
		}

		// Token: 0x17001106 RID: 4358
		// (get) Token: 0x06005694 RID: 22164 RVA: 0x00079690 File Offset: 0x00077890
		// (set) Token: 0x06005695 RID: 22165 RVA: 0x000796C9 File Offset: 0x000778C9
		[Nullable(1)]
		public FSplineMoveData SplineMoveData
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FSplineMoveData result;
				if ((result = this._SplineMoveData) == null)
				{
					result = (this._SplineMoveData = new FSplineMoveData(base.NativePtr + (IntPtr)UKuroSceneItemMoveComponent.__PropertyOffset_SplineMoveData, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSplineMoveData.StaticStruct(), base.NativePtr + (IntPtr)UKuroSceneItemMoveComponent.__PropertyOffset_SplineMoveData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001107 RID: 4359
		// (get) Token: 0x06005696 RID: 22166 RVA: 0x000796EC File Offset: 0x000778EC
		// (set) Token: 0x06005697 RID: 22167 RVA: 0x00079725 File Offset: 0x00077925
		[Nullable(1)]
		public FOnStopEvent OnStopCallback
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnStopEvent result;
				if ((result = this._OnStopCallback) == null)
				{
					result = (this._OnStopCallback = new FOnStopEvent(base.NativePtr + (IntPtr)UKuroSceneItemMoveComponent.__PropertyOffset_OnStopCallback, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroSceneItemMoveComponent.__PropertyOffset_OnStopCallback, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001108 RID: 4360
		// (get) Token: 0x06005698 RID: 22168 RVA: 0x00079748 File Offset: 0x00077948
		// (set) Token: 0x06005699 RID: 22169 RVA: 0x00079781 File Offset: 0x00077981
		[Nullable(1)]
		public FOnStopEvent OnMoveStopCallback
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnStopEvent result;
				if ((result = this._OnMoveStopCallback) == null)
				{
					result = (this._OnMoveStopCallback = new FOnStopEvent(base.NativePtr + (IntPtr)UKuroSceneItemMoveComponent.__PropertyOffset_OnMoveStopCallback, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroSceneItemMoveComponent.__PropertyOffset_OnMoveStopCallback, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001109 RID: 4361
		// (get) Token: 0x0600569A RID: 22170 RVA: 0x000797A4 File Offset: 0x000779A4
		// (set) Token: 0x0600569B RID: 22171 RVA: 0x000797DD File Offset: 0x000779DD
		[Nullable(1)]
		public FOnArrivePoint OnArrivePointCallback
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnArrivePoint result;
				if ((result = this._OnArrivePointCallback) == null)
				{
					result = (this._OnArrivePointCallback = new FOnArrivePoint(base.NativePtr + (IntPtr)UKuroSceneItemMoveComponent.__PropertyOffset_OnArrivePointCallback, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroSceneItemMoveComponent.__PropertyOffset_OnArrivePointCallback, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700110A RID: 4362
		// (get) Token: 0x0600569C RID: 22172 RVA: 0x00079800 File Offset: 0x00077A00
		// (set) Token: 0x0600569D RID: 22173 RVA: 0x00079839 File Offset: 0x00077A39
		[Nullable(1)]
		public FOnStopEvent OnRotateStopCallback
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnStopEvent result;
				if ((result = this._OnRotateStopCallback) == null)
				{
					result = (this._OnRotateStopCallback = new FOnStopEvent(base.NativePtr + (IntPtr)UKuroSceneItemMoveComponent.__PropertyOffset_OnRotateStopCallback, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroSceneItemMoveComponent.__PropertyOffset_OnRotateStopCallback, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0600569E RID: 22174 RVA: 0x0007985C File Offset: 0x00077A5C
		[SkipLocalsInit]
		public unsafe bool UpdateSplineMoveDistanceByPosition(FVectorDouble NewPosition)
		{
			UKuroSceneItemMoveComponent.__UpdateSplineMoveDistanceByPosition_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__UpdateSplineMoveDistanceByPosition_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__UpdateSplineMoveDistanceByPosition_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__UpdateSplineMoveDistanceByPosition_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewPosition = NewPosition;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__UpdateSplineMoveDistanceByPosition_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600569F RID: 22175 RVA: 0x000798A8 File Offset: 0x00077AA8
		[SkipLocalsInit]
		public unsafe bool UpdateSplineMoveDistance(float NewDistanceAloneSpline)
		{
			UKuroSceneItemMoveComponent.__UpdateSplineMoveDistance_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__UpdateSplineMoveDistance_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__UpdateSplineMoveDistance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__UpdateSplineMoveDistance_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewDistanceAloneSpline = NewDistanceAloneSpline;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__UpdateSplineMoveDistance_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060056A0 RID: 22176 RVA: 0x000798F4 File Offset: 0x00077AF4
		[SkipLocalsInit]
		public unsafe bool UpdateDynamicSpeedSplineMoveParams(float CurrentSpeed, float Acceleration, float TargetSpeed)
		{
			UKuroSceneItemMoveComponent.__UpdateDynamicSpeedSplineMoveParams_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__UpdateDynamicSpeedSplineMoveParams_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__UpdateDynamicSpeedSplineMoveParams_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__UpdateDynamicSpeedSplineMoveParams_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CurrentSpeed = CurrentSpeed;
			ptr->Acceleration = Acceleration;
			ptr->TargetSpeed = TargetSpeed;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__UpdateDynamicSpeedSplineMoveParams_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060056A1 RID: 22177 RVA: 0x00079950 File Offset: 0x00077B50
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe bool SwitchTrackTarget(AActor NewTargetActor)
		{
			UKuroSceneItemMoveComponent.__SwitchTrackTarget_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__SwitchTrackTarget_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__SwitchTrackTarget_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__SwitchTrackTarget_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewTargetActor = ((NewTargetActor != null) ? NewTargetActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__SwitchTrackTarget_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060056A2 RID: 22178 RVA: 0x000799AC File Offset: 0x00077BAC
		[SkipLocalsInit]
		public unsafe bool StopRotate(EKuroSceneItemStopRotateMethod StopMethod, bool bBroadcastRotateStopCallback = false)
		{
			UKuroSceneItemMoveComponent.__StopRotate_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__StopRotate_FunctionParams[(UIntPtr)18] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__StopRotate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__StopRotate_NativeFunctionPtr, (void*)ptr, 1);
			ptr->StopMethod = StopMethod;
			ptr->bBroadcastRotateStopCallback = bBroadcastRotateStopCallback;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__StopRotate_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060056A3 RID: 22179 RVA: 0x00079A00 File Offset: 0x00077C00
		[SkipLocalsInit]
		public unsafe void StopAllMove(bool bBroadcastStopCallback = false, bool bBroadcastIndexCallback = false)
		{
			UKuroSceneItemMoveComponent.__StopAllMove_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__StopAllMove_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__StopAllMove_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__StopAllMove_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bBroadcastStopCallback = bBroadcastStopCallback;
			ptr->bBroadcastIndexCallback = bBroadcastIndexCallback;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__StopAllMove_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060056A4 RID: 22180 RVA: 0x00079A50 File Offset: 0x00077C50
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe bool StartTrackMove(AActor TargetActor, float MoveSpeed, FRotator InitRotatorOffset, float angleSpeed)
		{
			UKuroSceneItemMoveComponent.__StartTrackMove_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__StartTrackMove_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__StartTrackMove_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__StartTrackMove_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TargetActor = ((TargetActor != null) ? TargetActor.NativePtr : IntPtr.Zero);
			ptr->MoveSpeed = MoveSpeed;
			ptr->InitRotatorOffset = InitRotatorOffset;
			ptr->angleSpeed = angleSpeed;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__StartTrackMove_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060056A5 RID: 22181 RVA: 0x00079AC4 File Offset: 0x00077CC4
		[SkipLocalsInit]
		public unsafe bool StartRotate()
		{
			UKuroSceneItemMoveComponent.__StartRotate_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__StartRotate_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__StartRotate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__StartRotate_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__StartRotate_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060056A6 RID: 22182 RVA: 0x00079B0C File Offset: 0x00077D0C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe bool StartMoveWithSplineAtDynamicSpeed(USplineComponent SplineComponent, int MaxMoveTimes, bool Cycle, bool KeepLookAt, float InitSpeed, float Acceleration, float TargetSpeed, float StartDis = -1f, float EndDis = -1f)
		{
			UKuroSceneItemMoveComponent.__StartMoveWithSplineAtDynamicSpeed_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__StartMoveWithSplineAtDynamicSpeed_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__StartMoveWithSplineAtDynamicSpeed_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__StartMoveWithSplineAtDynamicSpeed_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SplineComponent = ((SplineComponent != null) ? SplineComponent.NativePtr : IntPtr.Zero);
			ptr->MaxMoveTimes = MaxMoveTimes;
			ptr->Cycle = Cycle;
			ptr->KeepLookAt = KeepLookAt;
			ptr->InitSpeed = InitSpeed;
			ptr->Acceleration = Acceleration;
			ptr->TargetSpeed = TargetSpeed;
			ptr->StartDis = StartDis;
			ptr->EndDis = EndDis;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__StartMoveWithSplineAtDynamicSpeed_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060056A7 RID: 22183 RVA: 0x00079BA8 File Offset: 0x00077DA8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe bool StartMoveWithSplineAtConstantTime(USplineComponent SplineComponent, bool Repeat, bool Cycle, bool KeepLookAt, float TimeSec, UCurveFloat TimeDisCurve, float StartTimeOffset, float StartDis = -1f, float EndDis = -1f)
		{
			UKuroSceneItemMoveComponent.__StartMoveWithSplineAtConstantTime_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__StartMoveWithSplineAtConstantTime_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__StartMoveWithSplineAtConstantTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__StartMoveWithSplineAtConstantTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SplineComponent = ((SplineComponent != null) ? SplineComponent.NativePtr : IntPtr.Zero);
			ptr->Repeat = Repeat;
			ptr->Cycle = Cycle;
			ptr->KeepLookAt = KeepLookAt;
			ptr->TimeSec = TimeSec;
			ptr->TimeDisCurve = ((TimeDisCurve != null) ? TimeDisCurve.NativePtr : IntPtr.Zero);
			ptr->StartTimeOffset = StartTimeOffset;
			ptr->StartDis = StartDis;
			ptr->EndDis = EndDis;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__StartMoveWithSplineAtConstantTime_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060056A8 RID: 22184 RVA: 0x00079C54 File Offset: 0x00077E54
		[SkipLocalsInit]
		public unsafe void SetTickingRotateEnable(bool bEnabled)
		{
			UKuroSceneItemMoveComponent.__SetTickingRotateEnable_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__SetTickingRotateEnable_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__SetTickingRotateEnable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__SetTickingRotateEnable_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnabled = bEnabled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__SetTickingRotateEnable_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060056A9 RID: 22185 RVA: 0x00079C9C File Offset: 0x00077E9C
		[SkipLocalsInit]
		public unsafe void SetTickingMoveEnable(bool bEnabled)
		{
			UKuroSceneItemMoveComponent.__SetTickingMoveEnable_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__SetTickingMoveEnable_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__SetTickingMoveEnable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__SetTickingMoveEnable_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnabled = bEnabled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__SetTickingMoveEnable_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060056AA RID: 22186 RVA: 0x00079CE4 File Offset: 0x00077EE4
		[SkipLocalsInit]
		public unsafe void SetMaxDeltaDegreePerSecondForUpdatingLookAt(float MaxDegreePerSecond)
		{
			UKuroSceneItemMoveComponent.__SetMaxDeltaDegreePerSecondForUpdatingLookAt_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__SetMaxDeltaDegreePerSecondForUpdatingLookAt_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__SetMaxDeltaDegreePerSecondForUpdatingLookAt_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__SetMaxDeltaDegreePerSecondForUpdatingLookAt_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MaxDegreePerSecond = MaxDegreePerSecond;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__SetMaxDeltaDegreePerSecondForUpdatingLookAt_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060056AB RID: 22187 RVA: 0x00079D2C File Offset: 0x00077F2C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetGroupsToIgnoreMask(in FNavAvoidanceMask GroupMask)
		{
			UKuroSceneItemMoveComponent.__SetGroupsToIgnoreMask_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__SetGroupsToIgnoreMask_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__SetGroupsToIgnoreMask_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__SetGroupsToIgnoreMask_NativeFunctionPtr, (void*)ptr, 1);
			if (GroupMask != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FNavAvoidanceMask.StaticStruct(), &ptr->GroupMask, GroupMask.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__SetGroupsToIgnoreMask_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060056AC RID: 22188 RVA: 0x00079D90 File Offset: 0x00077F90
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetGroupsToAvoidMask(in FNavAvoidanceMask GroupMask)
		{
			UKuroSceneItemMoveComponent.__SetGroupsToAvoidMask_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__SetGroupsToAvoidMask_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__SetGroupsToAvoidMask_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__SetGroupsToAvoidMask_NativeFunctionPtr, (void*)ptr, 1);
			if (GroupMask != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FNavAvoidanceMask.StaticStruct(), &ptr->GroupMask, GroupMask.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__SetGroupsToAvoidMask_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060056AD RID: 22189 RVA: 0x00079DF4 File Offset: 0x00077FF4
		[SkipLocalsInit]
		public unsafe void SetEnableDebugForMove(bool Enable)
		{
			UKuroSceneItemMoveComponent.__SetEnableDebugForMove_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__SetEnableDebugForMove_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__SetEnableDebugForMove_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__SetEnableDebugForMove_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Enable = Enable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__SetEnableDebugForMove_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060056AE RID: 22190 RVA: 0x00079E3C File Offset: 0x0007803C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetAvoidanceGroupMask(in FNavAvoidanceMask GroupMask)
		{
			UKuroSceneItemMoveComponent.__SetAvoidanceGroupMask_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__SetAvoidanceGroupMask_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__SetAvoidanceGroupMask_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__SetAvoidanceGroupMask_NativeFunctionPtr, (void*)ptr, 1);
			if (GroupMask != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FNavAvoidanceMask.StaticStruct(), &ptr->GroupMask, GroupMask.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__SetAvoidanceGroupMask_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060056AF RID: 22191 RVA: 0x00079EA0 File Offset: 0x000780A0
		[SkipLocalsInit]
		public unsafe void SetAvoidanceEnabled(bool bEnable)
		{
			UKuroSceneItemMoveComponent.__SetAvoidanceEnabled_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__SetAvoidanceEnabled_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__SetAvoidanceEnabled_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__SetAvoidanceEnabled_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__SetAvoidanceEnabled_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060056B0 RID: 22192 RVA: 0x00079EE8 File Offset: 0x000780E8
		[SkipLocalsInit]
		public unsafe void Kuro_SetGravityDirect(FVector InGravityDirect)
		{
			UKuroSceneItemMoveComponent.__Kuro_SetGravityDirect_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__Kuro_SetGravityDirect_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__Kuro_SetGravityDirect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__Kuro_SetGravityDirect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InGravityDirect = InGravityDirect;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__Kuro_SetGravityDirect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060056B1 RID: 22193 RVA: 0x00079F30 File Offset: 0x00078130
		[SkipLocalsInit]
		public unsafe FVector Kuro_GetGravityDirect()
		{
			UKuroSceneItemMoveComponent.__Kuro_GetGravityDirect_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__Kuro_GetGravityDirect_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__Kuro_GetGravityDirect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__Kuro_GetGravityDirect_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__Kuro_GetGravityDirect_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060056B2 RID: 22194 RVA: 0x00079F78 File Offset: 0x00078178
		[SkipLocalsInit]
		public unsafe bool IsRotating()
		{
			UKuroSceneItemMoveComponent.__IsRotating_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__IsRotating_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__IsRotating_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__IsRotating_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__IsRotating_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060056B3 RID: 22195 RVA: 0x00079FC0 File Offset: 0x000781C0
		[SkipLocalsInit]
		public unsafe bool IsMoving(bool ConsiderSimpleWaitAsMoving = false)
		{
			UKuroSceneItemMoveComponent.__IsMoving_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__IsMoving_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__IsMoving_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__IsMoving_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ConsiderSimpleWaitAsMoving = ConsiderSimpleWaitAsMoving;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__IsMoving_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060056B4 RID: 22196 RVA: 0x0007A00C File Offset: 0x0007820C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe bool InitRotationData(AActor TargetActor, bool IsLoop)
		{
			UKuroSceneItemMoveComponent.__InitRotationData_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__InitRotationData_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__InitRotationData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__InitRotationData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TargetActor = ((TargetActor != null) ? TargetActor.NativePtr : IntPtr.Zero);
			ptr->IsLoop = IsLoop;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__InitRotationData_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060056B5 RID: 22197 RVA: 0x0007A070 File Offset: 0x00078270
		[SkipLocalsInit]
		public unsafe ESplineRunState GetSplineRunState()
		{
			UKuroSceneItemMoveComponent.__GetSplineRunState_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__GetSplineRunState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__GetSplineRunState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__GetSplineRunState_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__GetSplineRunState_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060056B6 RID: 22198 RVA: 0x0007A0B8 File Offset: 0x000782B8
		[SkipLocalsInit]
		public unsafe ESimpleRunState GetSimpleRunState()
		{
			UKuroSceneItemMoveComponent.__GetSimpleRunState_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__GetSimpleRunState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__GetSimpleRunState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__GetSimpleRunState_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__GetSimpleRunState_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060056B7 RID: 22199 RVA: 0x0007A100 File Offset: 0x00078300
		[SkipLocalsInit]
		public unsafe bool GetNextMoveTarget(ref FVectorDouble NextTarget, ref FVectorDouble CurrentVelocity)
		{
			UKuroSceneItemMoveComponent.__GetNextMoveTarget_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__GetNextMoveTarget_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__GetNextMoveTarget_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__GetNextMoveTarget_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NextTarget = NextTarget;
			ptr->CurrentVelocity = CurrentVelocity;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__GetNextMoveTarget_NativeFunctionPtr, (void*)ptr);
			NextTarget = ptr->NextTarget;
			CurrentVelocity = ptr->CurrentVelocity;
			return ptr->__Result;
		}

		// Token: 0x060056B8 RID: 22200 RVA: 0x0007A178 File Offset: 0x00078378
		[SkipLocalsInit]
		public unsafe float GetDistanceAlongSpline()
		{
			UKuroSceneItemMoveComponent.__GetDistanceAlongSpline_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__GetDistanceAlongSpline_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__GetDistanceAlongSpline_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__GetDistanceAlongSpline_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__GetDistanceAlongSpline_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060056B9 RID: 22201 RVA: 0x0007A1C0 File Offset: 0x000783C0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static bool FindTimeByValueIn01Curve(UCurveFloat Curve, float TargetValue, ref float ResultTime, int MaxSearchDepth = 100, float Tolerance = 1E-06f)
		{
			UKuroSceneItemMoveComponent.__FindTimeByValueIn01Curve_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__FindTimeByValueIn01Curve_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__FindTimeByValueIn01Curve_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__FindTimeByValueIn01Curve_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Curve = ((Curve != null) ? Curve.NativePtr : IntPtr.Zero);
			ptr->TargetValue = TargetValue;
			ptr->ResultTime = ResultTime;
			ptr->MaxSearchDepth = MaxSearchDepth;
			ptr->Tolerance = Tolerance;
			UnrealReflectionUtils.CallUFunction(UKuroSceneItemMoveComponent._ClassDefaultObjectPtr, UKuroSceneItemMoveComponent.__FindTimeByValueIn01Curve_NativeFunctionPtr, (void*)ptr);
			ResultTime = ptr->ResultTime;
			return ptr->__Result;
		}

		// Token: 0x060056BA RID: 22202 RVA: 0x0007A240 File Offset: 0x00078440
		[SkipLocalsInit]
		public unsafe void CalcVelocity(float DeltaTime)
		{
			UKuroSceneItemMoveComponent.__CalcVelocity_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__CalcVelocity_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__CalcVelocity_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__CalcVelocity_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__CalcVelocity_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060056BB RID: 22203 RVA: 0x0007A288 File Offset: 0x00078488
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe bool AddRotationStep(in FRotator BeginRotation, in FRotator EndRotation, float TimeSec, float CdSec, UCurveFloat RotateCurve = null)
		{
			UKuroSceneItemMoveComponent.__AddRotationStep_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__AddRotationStep_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__AddRotationStep_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__AddRotationStep_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BeginRotation = BeginRotation;
			ptr->EndRotation = EndRotation;
			ptr->TimeSec = TimeSec;
			ptr->CdSec = CdSec;
			ptr->RotateCurve = ((RotateCurve != null) ? RotateCurve.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__AddRotationStep_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060056BC RID: 22204 RVA: 0x0007A30C File Offset: 0x0007850C
		[SkipLocalsInit]
		public unsafe void AddMoveTarget(FVectorDouble Loc, float MoveTime, float WaitTime, float MaxSpeed = -1f, float Acceleration = -1f)
		{
			UKuroSceneItemMoveComponent.__AddMoveTarget_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__AddMoveTarget_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__AddMoveTarget_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__AddMoveTarget_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Loc = Loc;
			ptr->MoveTime = MoveTime;
			ptr->WaitTime = WaitTime;
			ptr->MaxSpeed = MaxSpeed;
			ptr->Acceleration = Acceleration;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__AddMoveTarget_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060056BD RID: 22205 RVA: 0x0007A370 File Offset: 0x00078570
		static UKuroSceneItemMoveComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComponent.KuroSceneItemMoveComponent");
		}

		// Token: 0x060056BE RID: 22206 RVA: 0x0007A37E File Offset: 0x0007857E
		protected UKuroSceneItemMoveComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002377 RID: 9079
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroComponent.KuroSceneItemMoveComponent";

		// Token: 0x04002378 RID: 9080
		private static IntPtr _ClassPtr;

		// Token: 0x04002379 RID: 9081
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400237A RID: 9082
		internal static int __PropertyOffset_CustomTimeDilation;

		// Token: 0x0400237B RID: 9083
		internal static int __PropertyOffset_bUseRVOAvoidance;

		// Token: 0x0400237C RID: 9084
		internal static byte __PropertyMask_bUseRVOAvoidance;

		// Token: 0x0400237D RID: 9085
		internal static int __PropertyOffset_AvoidanceUID;

		// Token: 0x0400237E RID: 9086
		internal static int __PropertyOffset_AvoidanceGroup;

		// Token: 0x0400237F RID: 9087
		[Nullable(2)]
		private FNavAvoidanceMask _AvoidanceGroup;

		// Token: 0x04002380 RID: 9088
		internal static int __PropertyOffset_GroupsToAvoid;

		// Token: 0x04002381 RID: 9089
		[Nullable(2)]
		private FNavAvoidanceMask _GroupsToAvoid;

		// Token: 0x04002382 RID: 9090
		internal static int __PropertyOffset_GroupsToIgnore;

		// Token: 0x04002383 RID: 9091
		[Nullable(2)]
		private FNavAvoidanceMask _GroupsToIgnore;

		// Token: 0x04002384 RID: 9092
		internal static int __PropertyOffset_AvoidanceWeight;

		// Token: 0x04002385 RID: 9093
		internal static int __PropertyOffset_AvoidanceHeight;

		// Token: 0x04002386 RID: 9094
		internal static int __PropertyOffset_AvoidanceRadius;

		// Token: 0x04002387 RID: 9095
		internal static int __PropertyOffset_AvoidanceConsiderationRadius;

		// Token: 0x04002388 RID: 9096
		internal static int __PropertyOffset_bWasAvoidanceUpdated;

		// Token: 0x04002389 RID: 9097
		internal static byte __PropertyMask_bWasAvoidanceUpdated;

		// Token: 0x0400238A RID: 9098
		internal static int __PropertyOffset_SplineMoveData;

		// Token: 0x0400238B RID: 9099
		[Nullable(2)]
		private FSplineMoveData _SplineMoveData;

		// Token: 0x0400238C RID: 9100
		internal static int __PropertyOffset_OnStopCallback;

		// Token: 0x0400238D RID: 9101
		[Nullable(2)]
		private FOnStopEvent _OnStopCallback;

		// Token: 0x0400238E RID: 9102
		internal static int __PropertyOffset_OnMoveStopCallback;

		// Token: 0x0400238F RID: 9103
		[Nullable(2)]
		private FOnStopEvent _OnMoveStopCallback;

		// Token: 0x04002390 RID: 9104
		internal static int __PropertyOffset_OnArrivePointCallback;

		// Token: 0x04002391 RID: 9105
		[Nullable(2)]
		private FOnArrivePoint _OnArrivePointCallback;

		// Token: 0x04002392 RID: 9106
		internal static int __PropertyOffset_OnRotateStopCallback;

		// Token: 0x04002393 RID: 9107
		[Nullable(2)]
		private FOnStopEvent _OnRotateStopCallback;

		// Token: 0x04002394 RID: 9108
		private static IntPtr __UpdateSplineMoveDistanceByPosition_NativeFunctionPtr;

		// Token: 0x04002395 RID: 9109
		private static IntPtr __UpdateSplineMoveDistance_NativeFunctionPtr;

		// Token: 0x04002396 RID: 9110
		private static IntPtr __UpdateDynamicSpeedSplineMoveParams_NativeFunctionPtr;

		// Token: 0x04002397 RID: 9111
		private static IntPtr __SwitchTrackTarget_NativeFunctionPtr;

		// Token: 0x04002398 RID: 9112
		private static IntPtr __StopRotate_NativeFunctionPtr;

		// Token: 0x04002399 RID: 9113
		private static IntPtr __StopAllMove_NativeFunctionPtr;

		// Token: 0x0400239A RID: 9114
		private static IntPtr __StartTrackMove_NativeFunctionPtr;

		// Token: 0x0400239B RID: 9115
		private static IntPtr __StartRotate_NativeFunctionPtr;

		// Token: 0x0400239C RID: 9116
		private static IntPtr __StartMoveWithSplineAtDynamicSpeed_NativeFunctionPtr;

		// Token: 0x0400239D RID: 9117
		private static IntPtr __StartMoveWithSplineAtConstantTime_NativeFunctionPtr;

		// Token: 0x0400239E RID: 9118
		private static IntPtr __SetTickingRotateEnable_NativeFunctionPtr;

		// Token: 0x0400239F RID: 9119
		private static IntPtr __SetTickingMoveEnable_NativeFunctionPtr;

		// Token: 0x040023A0 RID: 9120
		private static IntPtr __SetMaxDeltaDegreePerSecondForUpdatingLookAt_NativeFunctionPtr;

		// Token: 0x040023A1 RID: 9121
		private static IntPtr __SetGroupsToIgnoreMask_NativeFunctionPtr;

		// Token: 0x040023A2 RID: 9122
		private static IntPtr __SetGroupsToAvoidMask_NativeFunctionPtr;

		// Token: 0x040023A3 RID: 9123
		private static IntPtr __SetEnableDebugForMove_NativeFunctionPtr;

		// Token: 0x040023A4 RID: 9124
		private static IntPtr __SetAvoidanceGroupMask_NativeFunctionPtr;

		// Token: 0x040023A5 RID: 9125
		private static IntPtr __SetAvoidanceEnabled_NativeFunctionPtr;

		// Token: 0x040023A6 RID: 9126
		private static IntPtr __Kuro_SetGravityDirect_NativeFunctionPtr;

		// Token: 0x040023A7 RID: 9127
		private static IntPtr __Kuro_GetGravityDirect_NativeFunctionPtr;

		// Token: 0x040023A8 RID: 9128
		private static IntPtr __IsRotating_NativeFunctionPtr;

		// Token: 0x040023A9 RID: 9129
		private static IntPtr __IsMoving_NativeFunctionPtr;

		// Token: 0x040023AA RID: 9130
		private static IntPtr __InitRotationData_NativeFunctionPtr;

		// Token: 0x040023AB RID: 9131
		private static IntPtr __GetSplineRunState_NativeFunctionPtr;

		// Token: 0x040023AC RID: 9132
		private static IntPtr __GetSimpleRunState_NativeFunctionPtr;

		// Token: 0x040023AD RID: 9133
		private static IntPtr __GetNextMoveTarget_NativeFunctionPtr;

		// Token: 0x040023AE RID: 9134
		private static IntPtr __GetDistanceAlongSpline_NativeFunctionPtr;

		// Token: 0x040023AF RID: 9135
		private static IntPtr __FindTimeByValueIn01Curve_NativeFunctionPtr;

		// Token: 0x040023B0 RID: 9136
		private static IntPtr __CalcVelocity_NativeFunctionPtr;

		// Token: 0x040023B1 RID: 9137
		private static IntPtr __AddRotationStep_NativeFunctionPtr;

		// Token: 0x040023B2 RID: 9138
		private static IntPtr __AddMoveTarget_NativeFunctionPtr;

		// Token: 0x02000A40 RID: 2624
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __UpdateSplineMoveDistanceByPosition_FunctionParams
		{
			// Token: 0x04005A28 RID: 23080
			[FieldOffset(0)]
			public FVectorDouble NewPosition;

			// Token: 0x04005A29 RID: 23081
			[FieldOffset(24)]
			public bool __Result;
		}

		// Token: 0x02000A41 RID: 2625
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __UpdateSplineMoveDistance_FunctionParams
		{
			// Token: 0x04005A2A RID: 23082
			[FieldOffset(0)]
			public float NewDistanceAloneSpline;

			// Token: 0x04005A2B RID: 23083
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x02000A42 RID: 2626
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __UpdateDynamicSpeedSplineMoveParams_FunctionParams
		{
			// Token: 0x04005A2C RID: 23084
			[FieldOffset(0)]
			public float CurrentSpeed;

			// Token: 0x04005A2D RID: 23085
			[FieldOffset(4)]
			public float Acceleration;

			// Token: 0x04005A2E RID: 23086
			[FieldOffset(8)]
			public float TargetSpeed;

			// Token: 0x04005A2F RID: 23087
			[FieldOffset(12)]
			public bool __Result;
		}

		// Token: 0x02000A43 RID: 2627
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SwitchTrackTarget_FunctionParams
		{
			// Token: 0x04005A30 RID: 23088
			[FieldOffset(0)]
			public IntPtr NewTargetActor;

			// Token: 0x04005A31 RID: 23089
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x02000A44 RID: 2628
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 3)]
		protected ref struct __StopRotate_FunctionParams
		{
			// Token: 0x04005A32 RID: 23090
			[FieldOffset(0)]
			public EKuroSceneItemStopRotateMethod StopMethod;

			// Token: 0x04005A33 RID: 23091
			[FieldOffset(1)]
			public bool bBroadcastRotateStopCallback;

			// Token: 0x04005A34 RID: 23092
			[FieldOffset(2)]
			public bool __Result;
		}

		// Token: 0x02000A45 RID: 2629
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __StopAllMove_FunctionParams
		{
			// Token: 0x04005A35 RID: 23093
			[FieldOffset(0)]
			public bool bBroadcastStopCallback;

			// Token: 0x04005A36 RID: 23094
			[FieldOffset(1)]
			public bool bBroadcastIndexCallback;
		}

		// Token: 0x02000A46 RID: 2630
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __StartTrackMove_FunctionParams
		{
			// Token: 0x04005A37 RID: 23095
			[FieldOffset(0)]
			public IntPtr TargetActor;

			// Token: 0x04005A38 RID: 23096
			[FieldOffset(8)]
			public float MoveSpeed;

			// Token: 0x04005A39 RID: 23097
			[FieldOffset(12)]
			public FRotator InitRotatorOffset;

			// Token: 0x04005A3A RID: 23098
			[FieldOffset(24)]
			public float angleSpeed;

			// Token: 0x04005A3B RID: 23099
			[FieldOffset(28)]
			public bool __Result;
		}

		// Token: 0x02000A47 RID: 2631
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __StartRotate_FunctionParams
		{
			// Token: 0x04005A3C RID: 23100
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000A48 RID: 2632
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __StartMoveWithSplineAtDynamicSpeed_FunctionParams
		{
			// Token: 0x04005A3D RID: 23101
			[FieldOffset(0)]
			public IntPtr SplineComponent;

			// Token: 0x04005A3E RID: 23102
			[FieldOffset(8)]
			public int MaxMoveTimes;

			// Token: 0x04005A3F RID: 23103
			[FieldOffset(12)]
			public bool Cycle;

			// Token: 0x04005A40 RID: 23104
			[FieldOffset(13)]
			public bool KeepLookAt;

			// Token: 0x04005A41 RID: 23105
			[FieldOffset(16)]
			public float InitSpeed;

			// Token: 0x04005A42 RID: 23106
			[FieldOffset(20)]
			public float Acceleration;

			// Token: 0x04005A43 RID: 23107
			[FieldOffset(24)]
			public float TargetSpeed;

			// Token: 0x04005A44 RID: 23108
			[FieldOffset(28)]
			public float StartDis;

			// Token: 0x04005A45 RID: 23109
			[FieldOffset(32)]
			public float EndDis;

			// Token: 0x04005A46 RID: 23110
			[FieldOffset(36)]
			public bool __Result;
		}

		// Token: 0x02000A49 RID: 2633
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __StartMoveWithSplineAtConstantTime_FunctionParams
		{
			// Token: 0x04005A47 RID: 23111
			[FieldOffset(0)]
			public IntPtr SplineComponent;

			// Token: 0x04005A48 RID: 23112
			[FieldOffset(8)]
			public bool Repeat;

			// Token: 0x04005A49 RID: 23113
			[FieldOffset(9)]
			public bool Cycle;

			// Token: 0x04005A4A RID: 23114
			[FieldOffset(10)]
			public bool KeepLookAt;

			// Token: 0x04005A4B RID: 23115
			[FieldOffset(12)]
			public float TimeSec;

			// Token: 0x04005A4C RID: 23116
			[FieldOffset(16)]
			public IntPtr TimeDisCurve;

			// Token: 0x04005A4D RID: 23117
			[FieldOffset(24)]
			public float StartTimeOffset;

			// Token: 0x04005A4E RID: 23118
			[FieldOffset(28)]
			public float StartDis;

			// Token: 0x04005A4F RID: 23119
			[FieldOffset(32)]
			public float EndDis;

			// Token: 0x04005A50 RID: 23120
			[FieldOffset(36)]
			public bool __Result;
		}

		// Token: 0x02000A4A RID: 2634
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetTickingRotateEnable_FunctionParams
		{
			// Token: 0x04005A51 RID: 23121
			[FieldOffset(0)]
			public bool bEnabled;
		}

		// Token: 0x02000A4B RID: 2635
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetTickingMoveEnable_FunctionParams
		{
			// Token: 0x04005A52 RID: 23122
			[FieldOffset(0)]
			public bool bEnabled;
		}

		// Token: 0x02000A4C RID: 2636
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetMaxDeltaDegreePerSecondForUpdatingLookAt_FunctionParams
		{
			// Token: 0x04005A53 RID: 23123
			[FieldOffset(0)]
			public float MaxDegreePerSecond;
		}

		// Token: 0x02000A4D RID: 2637
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetGroupsToIgnoreMask_FunctionParams
		{
			// Token: 0x04005A54 RID: 23124
			[FieldOffset(0)]
			public byte GroupMask;
		}

		// Token: 0x02000A4E RID: 2638
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetGroupsToAvoidMask_FunctionParams
		{
			// Token: 0x04005A55 RID: 23125
			[FieldOffset(0)]
			public byte GroupMask;
		}

		// Token: 0x02000A4F RID: 2639
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetEnableDebugForMove_FunctionParams
		{
			// Token: 0x04005A56 RID: 23126
			[FieldOffset(0)]
			public bool Enable;
		}

		// Token: 0x02000A50 RID: 2640
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetAvoidanceGroupMask_FunctionParams
		{
			// Token: 0x04005A57 RID: 23127
			[FieldOffset(0)]
			public byte GroupMask;
		}

		// Token: 0x02000A51 RID: 2641
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetAvoidanceEnabled_FunctionParams
		{
			// Token: 0x04005A58 RID: 23128
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x02000A52 RID: 2642
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Kuro_SetGravityDirect_FunctionParams
		{
			// Token: 0x04005A59 RID: 23129
			[FieldOffset(0)]
			public FVector InGravityDirect;
		}

		// Token: 0x02000A53 RID: 2643
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Kuro_GetGravityDirect_FunctionParams
		{
			// Token: 0x04005A5A RID: 23130
			[FieldOffset(0)]
			public FVector __Result;
		}

		// Token: 0x02000A54 RID: 2644
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRotating_FunctionParams
		{
			// Token: 0x04005A5B RID: 23131
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000A55 RID: 2645
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __IsMoving_FunctionParams
		{
			// Token: 0x04005A5C RID: 23132
			[FieldOffset(0)]
			public bool ConsiderSimpleWaitAsMoving;

			// Token: 0x04005A5D RID: 23133
			[FieldOffset(1)]
			public bool __Result;
		}

		// Token: 0x02000A56 RID: 2646
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InitRotationData_FunctionParams
		{
			// Token: 0x04005A5E RID: 23134
			[FieldOffset(0)]
			public IntPtr TargetActor;

			// Token: 0x04005A5F RID: 23135
			[FieldOffset(8)]
			public bool IsLoop;

			// Token: 0x04005A60 RID: 23136
			[FieldOffset(9)]
			public bool __Result;
		}

		// Token: 0x02000A57 RID: 2647
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetSplineRunState_FunctionParams
		{
			// Token: 0x04005A61 RID: 23137
			[FieldOffset(0)]
			public ESplineRunState __Result;
		}

		// Token: 0x02000A58 RID: 2648
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetSimpleRunState_FunctionParams
		{
			// Token: 0x04005A62 RID: 23138
			[FieldOffset(0)]
			public ESimpleRunState __Result;
		}

		// Token: 0x02000A59 RID: 2649
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __GetNextMoveTarget_FunctionParams
		{
			// Token: 0x04005A63 RID: 23139
			[FieldOffset(0)]
			public FVectorDouble NextTarget;

			// Token: 0x04005A64 RID: 23140
			[FieldOffset(24)]
			public FVectorDouble CurrentVelocity;

			// Token: 0x04005A65 RID: 23141
			[FieldOffset(48)]
			public bool __Result;
		}

		// Token: 0x02000A5A RID: 2650
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetDistanceAlongSpline_FunctionParams
		{
			// Token: 0x04005A66 RID: 23142
			[FieldOffset(0)]
			public float __Result;
		}

		// Token: 0x02000A5B RID: 2651
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FindTimeByValueIn01Curve_FunctionParams
		{
			// Token: 0x04005A67 RID: 23143
			[FieldOffset(0)]
			public IntPtr Curve;

			// Token: 0x04005A68 RID: 23144
			[FieldOffset(8)]
			public float TargetValue;

			// Token: 0x04005A69 RID: 23145
			[FieldOffset(12)]
			public float ResultTime;

			// Token: 0x04005A6A RID: 23146
			[FieldOffset(16)]
			public int MaxSearchDepth;

			// Token: 0x04005A6B RID: 23147
			[FieldOffset(20)]
			public float Tolerance;

			// Token: 0x04005A6C RID: 23148
			[FieldOffset(24)]
			public bool __Result;
		}

		// Token: 0x02000A5C RID: 2652
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __CalcVelocity_FunctionParams
		{
			// Token: 0x04005A6D RID: 23149
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x02000A5D RID: 2653
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __AddRotationStep_FunctionParams
		{
			// Token: 0x04005A6E RID: 23150
			[FieldOffset(0)]
			public FRotator BeginRotation;

			// Token: 0x04005A6F RID: 23151
			[FieldOffset(12)]
			public FRotator EndRotation;

			// Token: 0x04005A70 RID: 23152
			[FieldOffset(24)]
			public float TimeSec;

			// Token: 0x04005A71 RID: 23153
			[FieldOffset(28)]
			public float CdSec;

			// Token: 0x04005A72 RID: 23154
			[FieldOffset(32)]
			public IntPtr RotateCurve;

			// Token: 0x04005A73 RID: 23155
			[FieldOffset(40)]
			public bool __Result;
		}

		// Token: 0x02000A5E RID: 2654
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __AddMoveTarget_FunctionParams
		{
			// Token: 0x04005A74 RID: 23156
			[FieldOffset(0)]
			public FVectorDouble Loc;

			// Token: 0x04005A75 RID: 23157
			[FieldOffset(24)]
			public float MoveTime;

			// Token: 0x04005A76 RID: 23158
			[FieldOffset(28)]
			public float WaitTime;

			// Token: 0x04005A77 RID: 23159
			[FieldOffset(32)]
			public float MaxSpeed;

			// Token: 0x04005A78 RID: 23160
			[FieldOffset(36)]
			public float Acceleration;
		}
	}
}
