using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001764 RID: 5988
	[UnrealObjectPath("/Script/KuroComponent.KuroSceneItemMoveComponent")]
	[UnrealStructLayout(832, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 832)]
	public class UKuroSceneItemMoveComponent : UMovementComponent, IUnrealUObject, IUnrealObject, IRVOAvoidanceInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06015865 RID: 88165 RVA: 0x001FA12A File Offset: 0x001F832A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSceneItemMoveComponent._ClassPtr;
		}

		// Token: 0x06015866 RID: 88166 RVA: 0x001FA136 File Offset: 0x001F8336
		int IRVOAvoidanceInterface.InterfaceOffset()
		{
			return UKuroSceneItemMoveComponent.__InterfaceOffset_IRVOAvoidanceInterface;
		}

		// Token: 0x06015867 RID: 88167 RVA: 0x001FA140 File Offset: 0x001F8340
		public UKuroSceneItemMoveComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroSceneItemMoveComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015868 RID: 88168 RVA: 0x001FA168 File Offset: 0x001F8368
		[NullableContext(1)]
		public UKuroSceneItemMoveComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSceneItemMoveComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170054FA RID: 21754
		// (get) Token: 0x06015869 RID: 88169 RVA: 0x001FA19B File Offset: 0x001F839B
		// (set) Token: 0x0601586A RID: 88170 RVA: 0x001FA1AB File Offset: 0x001F83AB
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

		// Token: 0x170054FB RID: 21755
		// (get) Token: 0x0601586B RID: 88171 RVA: 0x001FA1BC File Offset: 0x001F83BC
		// (set) Token: 0x0601586C RID: 88172 RVA: 0x001FA1D5 File Offset: 0x001F83D5
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

		// Token: 0x170054FC RID: 21756
		// (get) Token: 0x0601586D RID: 88173 RVA: 0x001FA205 File Offset: 0x001F8405
		// (set) Token: 0x0601586E RID: 88174 RVA: 0x001FA215 File Offset: 0x001F8415
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

		// Token: 0x170054FD RID: 21757
		// (get) Token: 0x0601586F RID: 88175 RVA: 0x001FA228 File Offset: 0x001F8428
		// (set) Token: 0x06015870 RID: 88176 RVA: 0x001FA261 File Offset: 0x001F8461
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

		// Token: 0x170054FE RID: 21758
		// (get) Token: 0x06015871 RID: 88177 RVA: 0x001FA284 File Offset: 0x001F8484
		// (set) Token: 0x06015872 RID: 88178 RVA: 0x001FA2BD File Offset: 0x001F84BD
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

		// Token: 0x170054FF RID: 21759
		// (get) Token: 0x06015873 RID: 88179 RVA: 0x001FA2E0 File Offset: 0x001F84E0
		// (set) Token: 0x06015874 RID: 88180 RVA: 0x001FA319 File Offset: 0x001F8519
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

		// Token: 0x17005500 RID: 21760
		// (get) Token: 0x06015875 RID: 88181 RVA: 0x001FA33A File Offset: 0x001F853A
		// (set) Token: 0x06015876 RID: 88182 RVA: 0x001FA34A File Offset: 0x001F854A
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

		// Token: 0x17005501 RID: 21761
		// (get) Token: 0x06015877 RID: 88183 RVA: 0x001FA35B File Offset: 0x001F855B
		// (set) Token: 0x06015878 RID: 88184 RVA: 0x001FA36B File Offset: 0x001F856B
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

		// Token: 0x17005502 RID: 21762
		// (get) Token: 0x06015879 RID: 88185 RVA: 0x001FA37C File Offset: 0x001F857C
		// (set) Token: 0x0601587A RID: 88186 RVA: 0x001FA38C File Offset: 0x001F858C
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

		// Token: 0x17005503 RID: 21763
		// (get) Token: 0x0601587B RID: 88187 RVA: 0x001FA39D File Offset: 0x001F859D
		// (set) Token: 0x0601587C RID: 88188 RVA: 0x001FA3AD File Offset: 0x001F85AD
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

		// Token: 0x17005504 RID: 21764
		// (get) Token: 0x0601587D RID: 88189 RVA: 0x001FA3BE File Offset: 0x001F85BE
		// (set) Token: 0x0601587E RID: 88190 RVA: 0x001FA3D7 File Offset: 0x001F85D7
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

		// Token: 0x17005505 RID: 21765
		// (get) Token: 0x0601587F RID: 88191 RVA: 0x001FA408 File Offset: 0x001F8608
		// (set) Token: 0x06015880 RID: 88192 RVA: 0x001FA441 File Offset: 0x001F8641
		[Nullable(1)]
		public FSimpleMoveData SimpleMoveData
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FSimpleMoveData result;
				if ((result = this._SimpleMoveData) == null)
				{
					result = (this._SimpleMoveData = new FSimpleMoveData(base.NativePtr + (IntPtr)UKuroSceneItemMoveComponent.__PropertyOffset_SimpleMoveData, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSimpleMoveData.StaticStruct(), base.NativePtr + (IntPtr)UKuroSceneItemMoveComponent.__PropertyOffset_SimpleMoveData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005506 RID: 21766
		// (get) Token: 0x06015881 RID: 88193 RVA: 0x001FA464 File Offset: 0x001F8664
		// (set) Token: 0x06015882 RID: 88194 RVA: 0x001FA49D File Offset: 0x001F869D
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

		// Token: 0x17005507 RID: 21767
		// (get) Token: 0x06015883 RID: 88195 RVA: 0x001FA4C0 File Offset: 0x001F86C0
		// (set) Token: 0x06015884 RID: 88196 RVA: 0x001FA4F9 File Offset: 0x001F86F9
		[Nullable(1)]
		public FTrackMoveData TrackMoveData
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FTrackMoveData result;
				if ((result = this._TrackMoveData) == null)
				{
					result = (this._TrackMoveData = new FTrackMoveData(base.NativePtr + (IntPtr)UKuroSceneItemMoveComponent.__PropertyOffset_TrackMoveData, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTrackMoveData.StaticStruct(), base.NativePtr + (IntPtr)UKuroSceneItemMoveComponent.__PropertyOffset_TrackMoveData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005508 RID: 21768
		// (get) Token: 0x06015885 RID: 88197 RVA: 0x001FA51C File Offset: 0x001F871C
		// (set) Token: 0x06015886 RID: 88198 RVA: 0x001FA555 File Offset: 0x001F8755
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

		// Token: 0x17005509 RID: 21769
		// (get) Token: 0x06015887 RID: 88199 RVA: 0x001FA578 File Offset: 0x001F8778
		// (set) Token: 0x06015888 RID: 88200 RVA: 0x001FA5B1 File Offset: 0x001F87B1
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

		// Token: 0x1700550A RID: 21770
		// (get) Token: 0x06015889 RID: 88201 RVA: 0x001FA5D4 File Offset: 0x001F87D4
		// (set) Token: 0x0601588A RID: 88202 RVA: 0x001FA60D File Offset: 0x001F880D
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

		// Token: 0x1700550B RID: 21771
		// (get) Token: 0x0601588B RID: 88203 RVA: 0x001FA630 File Offset: 0x001F8830
		// (set) Token: 0x0601588C RID: 88204 RVA: 0x001FA669 File Offset: 0x001F8869
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

		// Token: 0x1700550C RID: 21772
		// (get) Token: 0x0601588D RID: 88205 RVA: 0x001FA68C File Offset: 0x001F888C
		// (set) Token: 0x0601588E RID: 88206 RVA: 0x001FA6C5 File Offset: 0x001F88C5
		[Nullable(1)]
		public FTargetRotationData TargetRotationData
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FTargetRotationData result;
				if ((result = this._TargetRotationData) == null)
				{
					result = (this._TargetRotationData = new FTargetRotationData(base.NativePtr + (IntPtr)UKuroSceneItemMoveComponent.__PropertyOffset_TargetRotationData, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTargetRotationData.StaticStruct(), base.NativePtr + (IntPtr)UKuroSceneItemMoveComponent.__PropertyOffset_TargetRotationData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601588F RID: 88207 RVA: 0x001FA6E8 File Offset: 0x001F88E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool UpdateSplineMoveDistanceByPosition(FVectorDouble NewPosition)
		{
			UKuroSceneItemMoveComponent.__UpdateSplineMoveDistanceByPosition_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__UpdateSplineMoveDistanceByPosition_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__UpdateSplineMoveDistanceByPosition_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__UpdateSplineMoveDistanceByPosition_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewPosition = NewPosition;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__UpdateSplineMoveDistanceByPosition_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06015890 RID: 88208 RVA: 0x001FA738 File Offset: 0x001F8938
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool UpdateSplineMoveDistance(float NewDistanceAloneSpline)
		{
			UKuroSceneItemMoveComponent.__UpdateSplineMoveDistance_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__UpdateSplineMoveDistance_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__UpdateSplineMoveDistance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__UpdateSplineMoveDistance_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewDistanceAloneSpline = NewDistanceAloneSpline;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__UpdateSplineMoveDistance_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06015891 RID: 88209 RVA: 0x001FA788 File Offset: 0x001F8988
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool UpdateDynamicSpeedSplineMoveParams(float CurrentSpeed, float Acceleration, float TargetSpeed)
		{
			UKuroSceneItemMoveComponent.__UpdateDynamicSpeedSplineMoveParams_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__UpdateDynamicSpeedSplineMoveParams_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__UpdateDynamicSpeedSplineMoveParams_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__UpdateDynamicSpeedSplineMoveParams_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CurrentSpeed = CurrentSpeed;
			ptr->Acceleration = Acceleration;
			ptr->TargetSpeed = TargetSpeed;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__UpdateDynamicSpeedSplineMoveParams_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06015892 RID: 88210 RVA: 0x001FA7E4 File Offset: 0x001F89E4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool SwitchTrackTarget(AActor NewTargetActor)
		{
			UKuroSceneItemMoveComponent.__SwitchTrackTarget_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__SwitchTrackTarget_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__SwitchTrackTarget_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__SwitchTrackTarget_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewTargetActor = ((NewTargetActor != null) ? NewTargetActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__SwitchTrackTarget_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06015893 RID: 88211 RVA: 0x001FA840 File Offset: 0x001F8A40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool StopRotate(EKuroSceneItemStopRotateMethod StopMethod, bool bBroadcastRotateStopCallback = false)
		{
			UKuroSceneItemMoveComponent.__StopRotate_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__StopRotate_FunctionParams[(UIntPtr)18] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__StopRotate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__StopRotate_NativeFunctionPtr, (void*)ptr, 1);
			ptr->StopMethod = StopMethod;
			ptr->bBroadcastRotateStopCallback = bBroadcastRotateStopCallback;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__StopRotate_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06015894 RID: 88212 RVA: 0x001FA894 File Offset: 0x001F8A94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void StopAllMove(bool bBroadcastStopCallback = false, bool bBroadcastIndexCallback = false)
		{
			UKuroSceneItemMoveComponent.__StopAllMove_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__StopAllMove_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__StopAllMove_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__StopAllMove_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bBroadcastStopCallback = bBroadcastStopCallback;
			ptr->bBroadcastIndexCallback = bBroadcastIndexCallback;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__StopAllMove_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06015895 RID: 88213 RVA: 0x001FA8E4 File Offset: 0x001F8AE4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool StartTrackMove(AActor TargetActor, float MoveSpeed, FRotator InitRotatorOffset, float angleSpeed)
		{
			UKuroSceneItemMoveComponent.__StartTrackMove_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__StartTrackMove_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__StartTrackMove_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__StartTrackMove_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TargetActor = ((TargetActor != null) ? TargetActor.NativePtr : IntPtr.Zero);
			ptr->MoveSpeed = MoveSpeed;
			ptr->InitRotatorOffset = InitRotatorOffset;
			ptr->angleSpeed = angleSpeed;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__StartTrackMove_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06015896 RID: 88214 RVA: 0x001FA958 File Offset: 0x001F8B58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool StartRotate()
		{
			UKuroSceneItemMoveComponent.__StartRotate_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__StartRotate_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__StartRotate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__StartRotate_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__StartRotate_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06015897 RID: 88215 RVA: 0x001FA9A0 File Offset: 0x001F8BA0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__StartMoveWithSplineAtDynamicSpeed_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06015898 RID: 88216 RVA: 0x001FAA3C File Offset: 0x001F8C3C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__StartMoveWithSplineAtConstantTime_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06015899 RID: 88217 RVA: 0x001FAAE8 File Offset: 0x001F8CE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetTickingRotateEnable(bool bEnabled)
		{
			UKuroSceneItemMoveComponent.__SetTickingRotateEnable_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__SetTickingRotateEnable_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__SetTickingRotateEnable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__SetTickingRotateEnable_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnabled = bEnabled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__SetTickingRotateEnable_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601589A RID: 88218 RVA: 0x001FAB30 File Offset: 0x001F8D30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetTickingMoveEnable(bool bEnabled)
		{
			UKuroSceneItemMoveComponent.__SetTickingMoveEnable_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__SetTickingMoveEnable_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__SetTickingMoveEnable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__SetTickingMoveEnable_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnabled = bEnabled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__SetTickingMoveEnable_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601589B RID: 88219 RVA: 0x001FAB78 File Offset: 0x001F8D78
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetMaxDeltaDegreePerSecondForUpdatingLookAt(float MaxDegreePerSecond)
		{
			UKuroSceneItemMoveComponent.__SetMaxDeltaDegreePerSecondForUpdatingLookAt_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__SetMaxDeltaDegreePerSecondForUpdatingLookAt_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__SetMaxDeltaDegreePerSecondForUpdatingLookAt_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__SetMaxDeltaDegreePerSecondForUpdatingLookAt_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MaxDegreePerSecond = MaxDegreePerSecond;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__SetMaxDeltaDegreePerSecondForUpdatingLookAt_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601589C RID: 88220 RVA: 0x001FABC0 File Offset: 0x001F8DC0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetGroupsToIgnoreMask(in FNavAvoidanceMask GroupMask)
		{
			UKuroSceneItemMoveComponent.__SetGroupsToIgnoreMask_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__SetGroupsToIgnoreMask_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__SetGroupsToIgnoreMask_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__SetGroupsToIgnoreMask_NativeFunctionPtr, (void*)ptr, 1);
			if (GroupMask != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FNavAvoidanceMask.StaticStruct(), &ptr->GroupMask, GroupMask.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__SetGroupsToIgnoreMask_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601589D RID: 88221 RVA: 0x001FAC24 File Offset: 0x001F8E24
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetGroupsToAvoidMask(in FNavAvoidanceMask GroupMask)
		{
			UKuroSceneItemMoveComponent.__SetGroupsToAvoidMask_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__SetGroupsToAvoidMask_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__SetGroupsToAvoidMask_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__SetGroupsToAvoidMask_NativeFunctionPtr, (void*)ptr, 1);
			if (GroupMask != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FNavAvoidanceMask.StaticStruct(), &ptr->GroupMask, GroupMask.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__SetGroupsToAvoidMask_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601589E RID: 88222 RVA: 0x001FAC88 File Offset: 0x001F8E88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetEnableDebugForMove(bool Enable)
		{
			UKuroSceneItemMoveComponent.__SetEnableDebugForMove_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__SetEnableDebugForMove_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__SetEnableDebugForMove_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__SetEnableDebugForMove_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Enable = Enable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__SetEnableDebugForMove_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601589F RID: 88223 RVA: 0x001FACD0 File Offset: 0x001F8ED0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetAvoidanceGroupMask(in FNavAvoidanceMask GroupMask)
		{
			UKuroSceneItemMoveComponent.__SetAvoidanceGroupMask_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__SetAvoidanceGroupMask_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__SetAvoidanceGroupMask_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__SetAvoidanceGroupMask_NativeFunctionPtr, (void*)ptr, 1);
			if (GroupMask != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FNavAvoidanceMask.StaticStruct(), &ptr->GroupMask, GroupMask.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__SetAvoidanceGroupMask_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060158A0 RID: 88224 RVA: 0x001FAD34 File Offset: 0x001F8F34
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetAvoidanceEnabled(bool bEnable)
		{
			UKuroSceneItemMoveComponent.__SetAvoidanceEnabled_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__SetAvoidanceEnabled_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__SetAvoidanceEnabled_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__SetAvoidanceEnabled_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__SetAvoidanceEnabled_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060158A1 RID: 88225 RVA: 0x001FAD7C File Offset: 0x001F8F7C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Kuro_SetGravityDirect(FVector InGravityDirect)
		{
			UKuroSceneItemMoveComponent.__Kuro_SetGravityDirect_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__Kuro_SetGravityDirect_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__Kuro_SetGravityDirect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__Kuro_SetGravityDirect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InGravityDirect = InGravityDirect;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__Kuro_SetGravityDirect_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060158A2 RID: 88226 RVA: 0x001FADC4 File Offset: 0x001F8FC4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FVector Kuro_GetGravityDirect()
		{
			UKuroSceneItemMoveComponent.__Kuro_GetGravityDirect_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__Kuro_GetGravityDirect_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__Kuro_GetGravityDirect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__Kuro_GetGravityDirect_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__Kuro_GetGravityDirect_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060158A3 RID: 88227 RVA: 0x001FAE0C File Offset: 0x001F900C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRotating()
		{
			UKuroSceneItemMoveComponent.__IsRotating_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__IsRotating_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__IsRotating_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__IsRotating_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__IsRotating_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060158A4 RID: 88228 RVA: 0x001FAE54 File Offset: 0x001F9054
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsMoving(bool ConsiderSimpleWaitAsMoving = false)
		{
			UKuroSceneItemMoveComponent.__IsMoving_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__IsMoving_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__IsMoving_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__IsMoving_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ConsiderSimpleWaitAsMoving = ConsiderSimpleWaitAsMoving;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__IsMoving_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060158A5 RID: 88229 RVA: 0x001FAEA4 File Offset: 0x001F90A4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool InitRotationData(AActor TargetActor, bool IsLoop)
		{
			UKuroSceneItemMoveComponent.__InitRotationData_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__InitRotationData_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__InitRotationData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__InitRotationData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TargetActor = ((TargetActor != null) ? TargetActor.NativePtr : IntPtr.Zero);
			ptr->IsLoop = IsLoop;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__InitRotationData_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060158A6 RID: 88230 RVA: 0x001FAF08 File Offset: 0x001F9108
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe ESplineRunState GetSplineRunState()
		{
			UKuroSceneItemMoveComponent.__GetSplineRunState_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__GetSplineRunState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__GetSplineRunState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__GetSplineRunState_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__GetSplineRunState_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060158A7 RID: 88231 RVA: 0x001FAF50 File Offset: 0x001F9150
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe ESimpleRunState GetSimpleRunState()
		{
			UKuroSceneItemMoveComponent.__GetSimpleRunState_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__GetSimpleRunState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__GetSimpleRunState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__GetSimpleRunState_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__GetSimpleRunState_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060158A8 RID: 88232 RVA: 0x001FAF98 File Offset: 0x001F9198
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool GetNextMoveTarget(ref FVectorDouble NextTarget, ref FVectorDouble CurrentVelocity)
		{
			UKuroSceneItemMoveComponent.__GetNextMoveTarget_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__GetNextMoveTarget_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__GetNextMoveTarget_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__GetNextMoveTarget_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NextTarget = NextTarget;
			ptr->CurrentVelocity = CurrentVelocity;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__GetNextMoveTarget_NativeFunctionPtr, (void*)ptr, 0);
			NextTarget = ptr->NextTarget;
			CurrentVelocity = ptr->CurrentVelocity;
			return ptr->__Result;
		}

		// Token: 0x060158A9 RID: 88233 RVA: 0x001FB010 File Offset: 0x001F9210
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe float GetDistanceAlongSpline()
		{
			UKuroSceneItemMoveComponent.__GetDistanceAlongSpline_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__GetDistanceAlongSpline_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__GetDistanceAlongSpline_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__GetDistanceAlongSpline_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__GetDistanceAlongSpline_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060158AA RID: 88234 RVA: 0x001FB058 File Offset: 0x001F9258
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool FindTimeByValueIn01Curve(UCurveFloat Curve, float TargetValue, ref float ResultTime, int MaxSearchDepth = 100, float Tolerance = 1E-06f)
		{
			UKuroSceneItemMoveComponent.__FindTimeByValueIn01Curve_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__FindTimeByValueIn01Curve_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__FindTimeByValueIn01Curve_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__FindTimeByValueIn01Curve_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Curve = ((Curve != null) ? Curve.NativePtr : IntPtr.Zero);
			ptr->TargetValue = TargetValue;
			ptr->ResultTime = ResultTime;
			ptr->MaxSearchDepth = MaxSearchDepth;
			ptr->Tolerance = Tolerance;
			UnrealReflectionUtils.CallUFunction(UKuroSceneItemMoveComponent._ClassDefaultObjectPtr, UKuroSceneItemMoveComponent.__FindTimeByValueIn01Curve_NativeFunctionPtr, (void*)ptr, 0);
			ResultTime = ptr->ResultTime;
			return ptr->__Result;
		}

		// Token: 0x060158AB RID: 88235 RVA: 0x001FB0DC File Offset: 0x001F92DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void CalcVelocity(float DeltaTime)
		{
			UKuroSceneItemMoveComponent.__CalcVelocity_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__CalcVelocity_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__CalcVelocity_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__CalcVelocity_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__CalcVelocity_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060158AC RID: 88236 RVA: 0x001FB124 File Offset: 0x001F9324
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool AddRotationStep(in FRotator BeginRotation, in FRotator EndRotation, float TimeSec, float CdSec, UCurveFloat RotateCurve = null)
		{
			UKuroSceneItemMoveComponent.__AddRotationStep_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__AddRotationStep_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__AddRotationStep_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__AddRotationStep_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BeginRotation = BeginRotation;
			ptr->EndRotation = EndRotation;
			ptr->TimeSec = TimeSec;
			ptr->CdSec = CdSec;
			ptr->RotateCurve = ((RotateCurve != null) ? RotateCurve.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__AddRotationStep_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060158AD RID: 88237 RVA: 0x001FB1AC File Offset: 0x001F93AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void AddMoveTarget(FVectorDouble Loc, float MoveTime, float WaitTime, float MaxSpeed = -1f, float Acceleration = -1f)
		{
			UKuroSceneItemMoveComponent.__AddMoveTarget_FunctionParams* ptr = stackalloc UKuroSceneItemMoveComponent.__AddMoveTarget_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroSceneItemMoveComponent.__AddMoveTarget_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneItemMoveComponent.__AddMoveTarget_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Loc = Loc;
			ptr->MoveTime = MoveTime;
			ptr->WaitTime = WaitTime;
			ptr->MaxSpeed = MaxSpeed;
			ptr->Acceleration = Acceleration;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneItemMoveComponent.__AddMoveTarget_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060158AE RID: 88238 RVA: 0x001FB211 File Offset: 0x001F9411
		static UKuroSceneItemMoveComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComponent.KuroSceneItemMoveComponent");
		}

		// Token: 0x060158AF RID: 88239 RVA: 0x001FB21F File Offset: 0x001F941F
		protected UKuroSceneItemMoveComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BBDD RID: 48093
		internal static int __InterfaceOffset_IRVOAvoidanceInterface;

		// Token: 0x0400BBDE RID: 48094
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroComponent.KuroSceneItemMoveComponent";

		// Token: 0x0400BBDF RID: 48095
		private static IntPtr _ClassPtr;

		// Token: 0x0400BBE0 RID: 48096
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BBE1 RID: 48097
		internal static int __PropertyOffset_CustomTimeDilation;

		// Token: 0x0400BBE2 RID: 48098
		internal static int __PropertyOffset_bUseRVOAvoidance;

		// Token: 0x0400BBE3 RID: 48099
		internal static byte __PropertyMask_bUseRVOAvoidance;

		// Token: 0x0400BBE4 RID: 48100
		internal static int __PropertyOffset_AvoidanceUID;

		// Token: 0x0400BBE5 RID: 48101
		internal static int __PropertyOffset_AvoidanceGroup;

		// Token: 0x0400BBE6 RID: 48102
		[Nullable(2)]
		private FNavAvoidanceMask _AvoidanceGroup;

		// Token: 0x0400BBE7 RID: 48103
		internal static int __PropertyOffset_GroupsToAvoid;

		// Token: 0x0400BBE8 RID: 48104
		[Nullable(2)]
		private FNavAvoidanceMask _GroupsToAvoid;

		// Token: 0x0400BBE9 RID: 48105
		internal static int __PropertyOffset_GroupsToIgnore;

		// Token: 0x0400BBEA RID: 48106
		[Nullable(2)]
		private FNavAvoidanceMask _GroupsToIgnore;

		// Token: 0x0400BBEB RID: 48107
		internal static int __PropertyOffset_AvoidanceWeight;

		// Token: 0x0400BBEC RID: 48108
		internal static int __PropertyOffset_AvoidanceHeight;

		// Token: 0x0400BBED RID: 48109
		internal static int __PropertyOffset_AvoidanceRadius;

		// Token: 0x0400BBEE RID: 48110
		internal static int __PropertyOffset_AvoidanceConsiderationRadius;

		// Token: 0x0400BBEF RID: 48111
		internal static int __PropertyOffset_bWasAvoidanceUpdated;

		// Token: 0x0400BBF0 RID: 48112
		internal static byte __PropertyMask_bWasAvoidanceUpdated;

		// Token: 0x0400BBF1 RID: 48113
		internal static int __PropertyOffset_SimpleMoveData;

		// Token: 0x0400BBF2 RID: 48114
		[Nullable(2)]
		private FSimpleMoveData _SimpleMoveData;

		// Token: 0x0400BBF3 RID: 48115
		internal static int __PropertyOffset_SplineMoveData;

		// Token: 0x0400BBF4 RID: 48116
		[Nullable(2)]
		private FSplineMoveData _SplineMoveData;

		// Token: 0x0400BBF5 RID: 48117
		internal static int __PropertyOffset_TrackMoveData;

		// Token: 0x0400BBF6 RID: 48118
		[Nullable(2)]
		private FTrackMoveData _TrackMoveData;

		// Token: 0x0400BBF7 RID: 48119
		internal static int __PropertyOffset_OnStopCallback;

		// Token: 0x0400BBF8 RID: 48120
		[Nullable(2)]
		private FOnStopEvent _OnStopCallback;

		// Token: 0x0400BBF9 RID: 48121
		internal static int __PropertyOffset_OnMoveStopCallback;

		// Token: 0x0400BBFA RID: 48122
		[Nullable(2)]
		private FOnStopEvent _OnMoveStopCallback;

		// Token: 0x0400BBFB RID: 48123
		internal static int __PropertyOffset_OnArrivePointCallback;

		// Token: 0x0400BBFC RID: 48124
		[Nullable(2)]
		private FOnArrivePoint _OnArrivePointCallback;

		// Token: 0x0400BBFD RID: 48125
		internal static int __PropertyOffset_OnRotateStopCallback;

		// Token: 0x0400BBFE RID: 48126
		[Nullable(2)]
		private FOnStopEvent _OnRotateStopCallback;

		// Token: 0x0400BBFF RID: 48127
		internal static int __PropertyOffset_TargetRotationData;

		// Token: 0x0400BC00 RID: 48128
		[Nullable(2)]
		private FTargetRotationData _TargetRotationData;

		// Token: 0x0400BC01 RID: 48129
		private static IntPtr __UpdateSplineMoveDistanceByPosition_NativeFunctionPtr;

		// Token: 0x0400BC02 RID: 48130
		private static IntPtr __UpdateSplineMoveDistance_NativeFunctionPtr;

		// Token: 0x0400BC03 RID: 48131
		private static IntPtr __UpdateDynamicSpeedSplineMoveParams_NativeFunctionPtr;

		// Token: 0x0400BC04 RID: 48132
		private static IntPtr __SwitchTrackTarget_NativeFunctionPtr;

		// Token: 0x0400BC05 RID: 48133
		private static IntPtr __StopRotate_NativeFunctionPtr;

		// Token: 0x0400BC06 RID: 48134
		private static IntPtr __StopAllMove_NativeFunctionPtr;

		// Token: 0x0400BC07 RID: 48135
		private static IntPtr __StartTrackMove_NativeFunctionPtr;

		// Token: 0x0400BC08 RID: 48136
		private static IntPtr __StartRotate_NativeFunctionPtr;

		// Token: 0x0400BC09 RID: 48137
		private static IntPtr __StartMoveWithSplineAtDynamicSpeed_NativeFunctionPtr;

		// Token: 0x0400BC0A RID: 48138
		private static IntPtr __StartMoveWithSplineAtConstantTime_NativeFunctionPtr;

		// Token: 0x0400BC0B RID: 48139
		private static IntPtr __SetTickingRotateEnable_NativeFunctionPtr;

		// Token: 0x0400BC0C RID: 48140
		private static IntPtr __SetTickingMoveEnable_NativeFunctionPtr;

		// Token: 0x0400BC0D RID: 48141
		private static IntPtr __SetMaxDeltaDegreePerSecondForUpdatingLookAt_NativeFunctionPtr;

		// Token: 0x0400BC0E RID: 48142
		private static IntPtr __SetGroupsToIgnoreMask_NativeFunctionPtr;

		// Token: 0x0400BC0F RID: 48143
		private static IntPtr __SetGroupsToAvoidMask_NativeFunctionPtr;

		// Token: 0x0400BC10 RID: 48144
		private static IntPtr __SetEnableDebugForMove_NativeFunctionPtr;

		// Token: 0x0400BC11 RID: 48145
		private static IntPtr __SetAvoidanceGroupMask_NativeFunctionPtr;

		// Token: 0x0400BC12 RID: 48146
		private static IntPtr __SetAvoidanceEnabled_NativeFunctionPtr;

		// Token: 0x0400BC13 RID: 48147
		private static IntPtr __Kuro_SetGravityDirect_NativeFunctionPtr;

		// Token: 0x0400BC14 RID: 48148
		private static IntPtr __Kuro_GetGravityDirect_NativeFunctionPtr;

		// Token: 0x0400BC15 RID: 48149
		private static IntPtr __IsRotating_NativeFunctionPtr;

		// Token: 0x0400BC16 RID: 48150
		private static IntPtr __IsMoving_NativeFunctionPtr;

		// Token: 0x0400BC17 RID: 48151
		private static IntPtr __InitRotationData_NativeFunctionPtr;

		// Token: 0x0400BC18 RID: 48152
		private static IntPtr __GetSplineRunState_NativeFunctionPtr;

		// Token: 0x0400BC19 RID: 48153
		private static IntPtr __GetSimpleRunState_NativeFunctionPtr;

		// Token: 0x0400BC1A RID: 48154
		private static IntPtr __GetNextMoveTarget_NativeFunctionPtr;

		// Token: 0x0400BC1B RID: 48155
		private static IntPtr __GetDistanceAlongSpline_NativeFunctionPtr;

		// Token: 0x0400BC1C RID: 48156
		private static IntPtr __FindTimeByValueIn01Curve_NativeFunctionPtr;

		// Token: 0x0400BC1D RID: 48157
		private static IntPtr __CalcVelocity_NativeFunctionPtr;

		// Token: 0x0400BC1E RID: 48158
		private static IntPtr __AddRotationStep_NativeFunctionPtr;

		// Token: 0x0400BC1F RID: 48159
		private static IntPtr __AddMoveTarget_NativeFunctionPtr;

		// Token: 0x02002F0B RID: 12043
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __UpdateSplineMoveDistanceByPosition_FunctionParams
		{
			// Token: 0x04016A54 RID: 92756
			[FieldOffset(0)]
			public FVectorDouble NewPosition;

			// Token: 0x04016A55 RID: 92757
			[FieldOffset(24)]
			public bool __Result;
		}

		// Token: 0x02002F0C RID: 12044
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __UpdateSplineMoveDistance_FunctionParams
		{
			// Token: 0x04016A56 RID: 92758
			[FieldOffset(0)]
			public float NewDistanceAloneSpline;

			// Token: 0x04016A57 RID: 92759
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x02002F0D RID: 12045
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __UpdateDynamicSpeedSplineMoveParams_FunctionParams
		{
			// Token: 0x04016A58 RID: 92760
			[FieldOffset(0)]
			public float CurrentSpeed;

			// Token: 0x04016A59 RID: 92761
			[FieldOffset(4)]
			public float Acceleration;

			// Token: 0x04016A5A RID: 92762
			[FieldOffset(8)]
			public float TargetSpeed;

			// Token: 0x04016A5B RID: 92763
			[FieldOffset(12)]
			public bool __Result;
		}

		// Token: 0x02002F0E RID: 12046
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SwitchTrackTarget_FunctionParams
		{
			// Token: 0x04016A5C RID: 92764
			[FieldOffset(0)]
			public IntPtr NewTargetActor;

			// Token: 0x04016A5D RID: 92765
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x02002F0F RID: 12047
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 3)]
		protected ref struct __StopRotate_FunctionParams
		{
			// Token: 0x04016A5E RID: 92766
			[FieldOffset(0)]
			public EKuroSceneItemStopRotateMethod StopMethod;

			// Token: 0x04016A5F RID: 92767
			[FieldOffset(1)]
			public bool bBroadcastRotateStopCallback;

			// Token: 0x04016A60 RID: 92768
			[FieldOffset(2)]
			public bool __Result;
		}

		// Token: 0x02002F10 RID: 12048
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __StopAllMove_FunctionParams
		{
			// Token: 0x04016A61 RID: 92769
			[FieldOffset(0)]
			public bool bBroadcastStopCallback;

			// Token: 0x04016A62 RID: 92770
			[FieldOffset(1)]
			public bool bBroadcastIndexCallback;
		}

		// Token: 0x02002F11 RID: 12049
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __StartTrackMove_FunctionParams
		{
			// Token: 0x04016A63 RID: 92771
			[FieldOffset(0)]
			public IntPtr TargetActor;

			// Token: 0x04016A64 RID: 92772
			[FieldOffset(8)]
			public float MoveSpeed;

			// Token: 0x04016A65 RID: 92773
			[FieldOffset(12)]
			public FRotator InitRotatorOffset;

			// Token: 0x04016A66 RID: 92774
			[FieldOffset(24)]
			public float angleSpeed;

			// Token: 0x04016A67 RID: 92775
			[FieldOffset(28)]
			public bool __Result;
		}

		// Token: 0x02002F12 RID: 12050
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __StartRotate_FunctionParams
		{
			// Token: 0x04016A68 RID: 92776
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02002F13 RID: 12051
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __StartMoveWithSplineAtDynamicSpeed_FunctionParams
		{
			// Token: 0x04016A69 RID: 92777
			[FieldOffset(0)]
			public IntPtr SplineComponent;

			// Token: 0x04016A6A RID: 92778
			[FieldOffset(8)]
			public int MaxMoveTimes;

			// Token: 0x04016A6B RID: 92779
			[FieldOffset(12)]
			public bool Cycle;

			// Token: 0x04016A6C RID: 92780
			[FieldOffset(13)]
			public bool KeepLookAt;

			// Token: 0x04016A6D RID: 92781
			[FieldOffset(16)]
			public float InitSpeed;

			// Token: 0x04016A6E RID: 92782
			[FieldOffset(20)]
			public float Acceleration;

			// Token: 0x04016A6F RID: 92783
			[FieldOffset(24)]
			public float TargetSpeed;

			// Token: 0x04016A70 RID: 92784
			[FieldOffset(28)]
			public float StartDis;

			// Token: 0x04016A71 RID: 92785
			[FieldOffset(32)]
			public float EndDis;

			// Token: 0x04016A72 RID: 92786
			[FieldOffset(36)]
			public bool __Result;
		}

		// Token: 0x02002F14 RID: 12052
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __StartMoveWithSplineAtConstantTime_FunctionParams
		{
			// Token: 0x04016A73 RID: 92787
			[FieldOffset(0)]
			public IntPtr SplineComponent;

			// Token: 0x04016A74 RID: 92788
			[FieldOffset(8)]
			public bool Repeat;

			// Token: 0x04016A75 RID: 92789
			[FieldOffset(9)]
			public bool Cycle;

			// Token: 0x04016A76 RID: 92790
			[FieldOffset(10)]
			public bool KeepLookAt;

			// Token: 0x04016A77 RID: 92791
			[FieldOffset(12)]
			public float TimeSec;

			// Token: 0x04016A78 RID: 92792
			[FieldOffset(16)]
			public IntPtr TimeDisCurve;

			// Token: 0x04016A79 RID: 92793
			[FieldOffset(24)]
			public float StartTimeOffset;

			// Token: 0x04016A7A RID: 92794
			[FieldOffset(28)]
			public float StartDis;

			// Token: 0x04016A7B RID: 92795
			[FieldOffset(32)]
			public float EndDis;

			// Token: 0x04016A7C RID: 92796
			[FieldOffset(36)]
			public bool __Result;
		}

		// Token: 0x02002F15 RID: 12053
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetTickingRotateEnable_FunctionParams
		{
			// Token: 0x04016A7D RID: 92797
			[FieldOffset(0)]
			public bool bEnabled;
		}

		// Token: 0x02002F16 RID: 12054
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetTickingMoveEnable_FunctionParams
		{
			// Token: 0x04016A7E RID: 92798
			[FieldOffset(0)]
			public bool bEnabled;
		}

		// Token: 0x02002F17 RID: 12055
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetMaxDeltaDegreePerSecondForUpdatingLookAt_FunctionParams
		{
			// Token: 0x04016A7F RID: 92799
			[FieldOffset(0)]
			public float MaxDegreePerSecond;
		}

		// Token: 0x02002F18 RID: 12056
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetGroupsToIgnoreMask_FunctionParams
		{
			// Token: 0x04016A80 RID: 92800
			[FieldOffset(0)]
			public byte GroupMask;
		}

		// Token: 0x02002F19 RID: 12057
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetGroupsToAvoidMask_FunctionParams
		{
			// Token: 0x04016A81 RID: 92801
			[FieldOffset(0)]
			public byte GroupMask;
		}

		// Token: 0x02002F1A RID: 12058
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetEnableDebugForMove_FunctionParams
		{
			// Token: 0x04016A82 RID: 92802
			[FieldOffset(0)]
			public bool Enable;
		}

		// Token: 0x02002F1B RID: 12059
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetAvoidanceGroupMask_FunctionParams
		{
			// Token: 0x04016A83 RID: 92803
			[FieldOffset(0)]
			public byte GroupMask;
		}

		// Token: 0x02002F1C RID: 12060
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetAvoidanceEnabled_FunctionParams
		{
			// Token: 0x04016A84 RID: 92804
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x02002F1D RID: 12061
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Kuro_SetGravityDirect_FunctionParams
		{
			// Token: 0x04016A85 RID: 92805
			[FieldOffset(0)]
			public FVector InGravityDirect;
		}

		// Token: 0x02002F1E RID: 12062
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Kuro_GetGravityDirect_FunctionParams
		{
			// Token: 0x04016A86 RID: 92806
			[FieldOffset(0)]
			public FVector __Result;
		}

		// Token: 0x02002F1F RID: 12063
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRotating_FunctionParams
		{
			// Token: 0x04016A87 RID: 92807
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02002F20 RID: 12064
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __IsMoving_FunctionParams
		{
			// Token: 0x04016A88 RID: 92808
			[FieldOffset(0)]
			public bool ConsiderSimpleWaitAsMoving;

			// Token: 0x04016A89 RID: 92809
			[FieldOffset(1)]
			public bool __Result;
		}

		// Token: 0x02002F21 RID: 12065
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InitRotationData_FunctionParams
		{
			// Token: 0x04016A8A RID: 92810
			[FieldOffset(0)]
			public IntPtr TargetActor;

			// Token: 0x04016A8B RID: 92811
			[FieldOffset(8)]
			public bool IsLoop;

			// Token: 0x04016A8C RID: 92812
			[FieldOffset(9)]
			public bool __Result;
		}

		// Token: 0x02002F22 RID: 12066
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetSplineRunState_FunctionParams
		{
			// Token: 0x04016A8D RID: 92813
			[FieldOffset(0)]
			public ESplineRunState __Result;
		}

		// Token: 0x02002F23 RID: 12067
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetSimpleRunState_FunctionParams
		{
			// Token: 0x04016A8E RID: 92814
			[FieldOffset(0)]
			public ESimpleRunState __Result;
		}

		// Token: 0x02002F24 RID: 12068
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __GetNextMoveTarget_FunctionParams
		{
			// Token: 0x04016A8F RID: 92815
			[FieldOffset(0)]
			public FVectorDouble NextTarget;

			// Token: 0x04016A90 RID: 92816
			[FieldOffset(24)]
			public FVectorDouble CurrentVelocity;

			// Token: 0x04016A91 RID: 92817
			[FieldOffset(48)]
			public bool __Result;
		}

		// Token: 0x02002F25 RID: 12069
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetDistanceAlongSpline_FunctionParams
		{
			// Token: 0x04016A92 RID: 92818
			[FieldOffset(0)]
			public float __Result;
		}

		// Token: 0x02002F26 RID: 12070
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FindTimeByValueIn01Curve_FunctionParams
		{
			// Token: 0x04016A93 RID: 92819
			[FieldOffset(0)]
			public IntPtr Curve;

			// Token: 0x04016A94 RID: 92820
			[FieldOffset(8)]
			public float TargetValue;

			// Token: 0x04016A95 RID: 92821
			[FieldOffset(12)]
			public float ResultTime;

			// Token: 0x04016A96 RID: 92822
			[FieldOffset(16)]
			public int MaxSearchDepth;

			// Token: 0x04016A97 RID: 92823
			[FieldOffset(20)]
			public float Tolerance;

			// Token: 0x04016A98 RID: 92824
			[FieldOffset(24)]
			public bool __Result;
		}

		// Token: 0x02002F27 RID: 12071
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __CalcVelocity_FunctionParams
		{
			// Token: 0x04016A99 RID: 92825
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x02002F28 RID: 12072
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __AddRotationStep_FunctionParams
		{
			// Token: 0x04016A9A RID: 92826
			[FieldOffset(0)]
			public FRotator BeginRotation;

			// Token: 0x04016A9B RID: 92827
			[FieldOffset(12)]
			public FRotator EndRotation;

			// Token: 0x04016A9C RID: 92828
			[FieldOffset(24)]
			public float TimeSec;

			// Token: 0x04016A9D RID: 92829
			[FieldOffset(28)]
			public float CdSec;

			// Token: 0x04016A9E RID: 92830
			[FieldOffset(32)]
			public IntPtr RotateCurve;

			// Token: 0x04016A9F RID: 92831
			[FieldOffset(40)]
			public bool __Result;
		}

		// Token: 0x02002F29 RID: 12073
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __AddMoveTarget_FunctionParams
		{
			// Token: 0x04016AA0 RID: 92832
			[FieldOffset(0)]
			public FVectorDouble Loc;

			// Token: 0x04016AA1 RID: 92833
			[FieldOffset(24)]
			public float MoveTime;

			// Token: 0x04016AA2 RID: 92834
			[FieldOffset(28)]
			public float WaitTime;

			// Token: 0x04016AA3 RID: 92835
			[FieldOffset(32)]
			public float MaxSpeed;

			// Token: 0x04016AA4 RID: 92836
			[FieldOffset(36)]
			public float Acceleration;
		}
	}
}
