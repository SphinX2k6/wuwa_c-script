using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C88 RID: 3208
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InterpToMovementComponent")]
	[UnrealStructLayout(424, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 424)]
	public class UInterpToMovementComponent : UMovementComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A2C0 RID: 41664 RVA: 0x000E71A0 File Offset: 0x000E53A0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpToMovementComponent._ClassPtr;
		}

		// Token: 0x0600A2C1 RID: 41665 RVA: 0x000E71AC File Offset: 0x000E53AC
		public UInterpToMovementComponent() : this(BuiltinUtils.AllocNativeUObject(UInterpToMovementComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A2C2 RID: 41666 RVA: 0x000E71D4 File Offset: 0x000E53D4
		public UInterpToMovementComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpToMovementComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170026B6 RID: 9910
		// (get) Token: 0x0600A2C3 RID: 41667 RVA: 0x000E7207 File Offset: 0x000E5407
		// (set) Token: 0x0600A2C4 RID: 41668 RVA: 0x000E7217 File Offset: 0x000E5417
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpToMovementComponent.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpToMovementComponent.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x170026B7 RID: 9911
		// (get) Token: 0x0600A2C5 RID: 41669 RVA: 0x000E7228 File Offset: 0x000E5428
		// (set) Token: 0x0600A2C6 RID: 41670 RVA: 0x000E7241 File Offset: 0x000E5441
		public unsafe bool bPauseOnImpact
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpToMovementComponent.__PropertyOffset_bPauseOnImpact) & UInterpToMovementComponent.__PropertyMask_bPauseOnImpact) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpToMovementComponent.__PropertyOffset_bPauseOnImpact) = ((*(base.NativePtr + (IntPtr)UInterpToMovementComponent.__PropertyOffset_bPauseOnImpact) & ~UInterpToMovementComponent.__PropertyMask_bPauseOnImpact) | (value ? UInterpToMovementComponent.__PropertyMask_bPauseOnImpact : 0));
			}
		}

		// Token: 0x170026B8 RID: 9912
		// (get) Token: 0x0600A2C7 RID: 41671 RVA: 0x000E7271 File Offset: 0x000E5471
		// (set) Token: 0x0600A2C8 RID: 41672 RVA: 0x000E7281 File Offset: 0x000E5481
		public unsafe bool bSweep
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpToMovementComponent.__PropertyOffset_bSweep) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpToMovementComponent.__PropertyOffset_bSweep) = (value ? 1 : 0);
			}
		}

		// Token: 0x170026B9 RID: 9913
		// (get) Token: 0x0600A2C9 RID: 41673 RVA: 0x000E7292 File Offset: 0x000E5492
		// (set) Token: 0x0600A2CA RID: 41674 RVA: 0x000E72A2 File Offset: 0x000E54A2
		public unsafe ETeleportType TeleportType
		{
			get
			{
				return (ETeleportType)(*(base.NativePtr + (IntPtr)UInterpToMovementComponent.__PropertyOffset_TeleportType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpToMovementComponent.__PropertyOffset_TeleportType) = (byte)value;
			}
		}

		// Token: 0x170026BA RID: 9914
		// (get) Token: 0x0600A2CB RID: 41675 RVA: 0x000E72B3 File Offset: 0x000E54B3
		// (set) Token: 0x0600A2CC RID: 41676 RVA: 0x000E72C3 File Offset: 0x000E54C3
		public unsafe EInterpToBehaviourType BehaviourType
		{
			get
			{
				return (EInterpToBehaviourType)(*(base.NativePtr + (IntPtr)UInterpToMovementComponent.__PropertyOffset_BehaviourType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpToMovementComponent.__PropertyOffset_BehaviourType) = (byte)value;
			}
		}

		// Token: 0x170026BB RID: 9915
		// (get) Token: 0x0600A2CD RID: 41677 RVA: 0x000E72D4 File Offset: 0x000E54D4
		// (set) Token: 0x0600A2CE RID: 41678 RVA: 0x000E72E4 File Offset: 0x000E54E4
		public unsafe bool bCheckIfStillInWorld
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpToMovementComponent.__PropertyOffset_bCheckIfStillInWorld) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpToMovementComponent.__PropertyOffset_bCheckIfStillInWorld) = (value ? 1 : 0);
			}
		}

		// Token: 0x170026BC RID: 9916
		// (get) Token: 0x0600A2CF RID: 41679 RVA: 0x000E72F5 File Offset: 0x000E54F5
		// (set) Token: 0x0600A2D0 RID: 41680 RVA: 0x000E730E File Offset: 0x000E550E
		public unsafe bool bForceSubStepping
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpToMovementComponent.__PropertyOffset_bForceSubStepping) & UInterpToMovementComponent.__PropertyMask_bForceSubStepping) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpToMovementComponent.__PropertyOffset_bForceSubStepping) = ((*(base.NativePtr + (IntPtr)UInterpToMovementComponent.__PropertyOffset_bForceSubStepping) & ~UInterpToMovementComponent.__PropertyMask_bForceSubStepping) | (value ? UInterpToMovementComponent.__PropertyMask_bForceSubStepping : 0));
			}
		}

		// Token: 0x170026BD RID: 9917
		// (get) Token: 0x0600A2D1 RID: 41681 RVA: 0x000E7340 File Offset: 0x000E5540
		// (set) Token: 0x0600A2D2 RID: 41682 RVA: 0x000E7379 File Offset: 0x000E5579
		public FOnInterpToReverseDelegate OnInterpToReverse
		{
			get
			{
				base.FastCheckIsValid();
				FOnInterpToReverseDelegate result;
				if ((result = this._OnInterpToReverse) == null)
				{
					result = (this._OnInterpToReverse = new FOnInterpToReverseDelegate(base.NativePtr + (IntPtr)UInterpToMovementComponent.__PropertyOffset_OnInterpToReverse, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UInterpToMovementComponent.__PropertyOffset_OnInterpToReverse, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170026BE RID: 9918
		// (get) Token: 0x0600A2D3 RID: 41683 RVA: 0x000E739C File Offset: 0x000E559C
		// (set) Token: 0x0600A2D4 RID: 41684 RVA: 0x000E73D5 File Offset: 0x000E55D5
		public FOnInterpToStopDelegate OnInterpToStop
		{
			get
			{
				base.FastCheckIsValid();
				FOnInterpToStopDelegate result;
				if ((result = this._OnInterpToStop) == null)
				{
					result = (this._OnInterpToStop = new FOnInterpToStopDelegate(base.NativePtr + (IntPtr)UInterpToMovementComponent.__PropertyOffset_OnInterpToStop, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UInterpToMovementComponent.__PropertyOffset_OnInterpToStop, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170026BF RID: 9919
		// (get) Token: 0x0600A2D5 RID: 41685 RVA: 0x000E73F8 File Offset: 0x000E55F8
		// (set) Token: 0x0600A2D6 RID: 41686 RVA: 0x000E7431 File Offset: 0x000E5631
		public FOnInterpToWaitBeginDelegate OnWaitBeginDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FOnInterpToWaitBeginDelegate result;
				if ((result = this._OnWaitBeginDelegate) == null)
				{
					result = (this._OnWaitBeginDelegate = new FOnInterpToWaitBeginDelegate(base.NativePtr + (IntPtr)UInterpToMovementComponent.__PropertyOffset_OnWaitBeginDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UInterpToMovementComponent.__PropertyOffset_OnWaitBeginDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170026C0 RID: 9920
		// (get) Token: 0x0600A2D7 RID: 41687 RVA: 0x000E7454 File Offset: 0x000E5654
		// (set) Token: 0x0600A2D8 RID: 41688 RVA: 0x000E748D File Offset: 0x000E568D
		public FOnInterpToWaitEndDelegate OnWaitEndDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FOnInterpToWaitEndDelegate result;
				if ((result = this._OnWaitEndDelegate) == null)
				{
					result = (this._OnWaitEndDelegate = new FOnInterpToWaitEndDelegate(base.NativePtr + (IntPtr)UInterpToMovementComponent.__PropertyOffset_OnWaitEndDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UInterpToMovementComponent.__PropertyOffset_OnWaitEndDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170026C1 RID: 9921
		// (get) Token: 0x0600A2D9 RID: 41689 RVA: 0x000E74B0 File Offset: 0x000E56B0
		// (set) Token: 0x0600A2DA RID: 41690 RVA: 0x000E74E9 File Offset: 0x000E56E9
		public FOnInterpToResetDelegate OnResetDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FOnInterpToResetDelegate result;
				if ((result = this._OnResetDelegate) == null)
				{
					result = (this._OnResetDelegate = new FOnInterpToResetDelegate(base.NativePtr + (IntPtr)UInterpToMovementComponent.__PropertyOffset_OnResetDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UInterpToMovementComponent.__PropertyOffset_OnResetDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170026C2 RID: 9922
		// (get) Token: 0x0600A2DB RID: 41691 RVA: 0x000E750A File Offset: 0x000E570A
		// (set) Token: 0x0600A2DC RID: 41692 RVA: 0x000E751A File Offset: 0x000E571A
		public unsafe float MaxSimulationTimeStep
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpToMovementComponent.__PropertyOffset_MaxSimulationTimeStep);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpToMovementComponent.__PropertyOffset_MaxSimulationTimeStep) = value;
			}
		}

		// Token: 0x170026C3 RID: 9923
		// (get) Token: 0x0600A2DD RID: 41693 RVA: 0x000E752B File Offset: 0x000E572B
		// (set) Token: 0x0600A2DE RID: 41694 RVA: 0x000E753B File Offset: 0x000E573B
		public unsafe int MaxSimulationIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpToMovementComponent.__PropertyOffset_MaxSimulationIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpToMovementComponent.__PropertyOffset_MaxSimulationIterations) = value;
			}
		}

		// Token: 0x170026C4 RID: 9924
		// (get) Token: 0x0600A2DF RID: 41695 RVA: 0x000E754C File Offset: 0x000E574C
		// (set) Token: 0x0600A2E0 RID: 41696 RVA: 0x000E7585 File Offset: 0x000E5785
		public TArray<FInterpControlPoint> ControlPoints
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FInterpControlPoint> result;
				if ((result = this._ControlPoints) == null)
				{
					result = (this._ControlPoints = new TArray<FInterpControlPoint>(base.NativePtr + (IntPtr)UInterpToMovementComponent.__PropertyOffset_ControlPoints, this));
				}
				return result;
			}
			set
			{
				this.ControlPoints.CopyAssign(value);
			}
		}

		// Token: 0x0600A2E1 RID: 41697 RVA: 0x000E7593 File Offset: 0x000E5793
		[NullableContext(2)]
		public void StopSimulating(in FHitResult HitResult)
		{
			UInterpToMovementComponent.__StopSimulating_Internal(base.NativePtr, (HitResult ?? new FHitResult()).NativePtr);
		}

		// Token: 0x0600A2E2 RID: 41698 RVA: 0x000E75B0 File Offset: 0x000E57B0
		public void RestartMovement(float InitialDirection = 1f)
		{
			UInterpToMovementComponent.__RestartMovement_Internal(base.NativePtr, InitialDirection);
		}

		// Token: 0x0600A2E3 RID: 41699 RVA: 0x000E75BE File Offset: 0x000E57BE
		public void FinaliseControlPoints()
		{
			UInterpToMovementComponent.__FinaliseControlPoints_Internal(base.NativePtr);
		}

		// Token: 0x0600A2E4 RID: 41700
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopSimulating_Internal(IntPtr @this, IntPtr HitResult);

		// Token: 0x0600A2E5 RID: 41701
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RestartMovement_Internal(IntPtr @this, float InitialDirection);

		// Token: 0x0600A2E6 RID: 41702
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FinaliseControlPoints_Internal(IntPtr @this);

		// Token: 0x0600A2E7 RID: 41703 RVA: 0x000E75CB File Offset: 0x000E57CB
		static UInterpToMovementComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpToMovementComponent");
		}

		// Token: 0x0600A2E8 RID: 41704 RVA: 0x000E75D9 File Offset: 0x000E57D9
		protected UInterpToMovementComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400594F RID: 22863
		public new const string __ObjectPath = "/Script/Engine.InterpToMovementComponent";

		// Token: 0x04005950 RID: 22864
		private static IntPtr _ClassPtr;

		// Token: 0x04005951 RID: 22865
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005952 RID: 22866
		public static IntPtr __OnInterpToWaitEndDelegate__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04005953 RID: 22867
		public static IntPtr __OnInterpToWaitBeginDelegate__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04005954 RID: 22868
		public static IntPtr __OnInterpToStopDelegate__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04005955 RID: 22869
		public static IntPtr __OnInterpToReverseDelegate__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04005956 RID: 22870
		public static IntPtr __OnInterpToResetDelegate__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04005957 RID: 22871
		internal static int __PropertyOffset_Duration;

		// Token: 0x04005958 RID: 22872
		internal static int __PropertyOffset_bPauseOnImpact;

		// Token: 0x04005959 RID: 22873
		internal static byte __PropertyMask_bPauseOnImpact;

		// Token: 0x0400595A RID: 22874
		internal static int __PropertyOffset_bSweep;

		// Token: 0x0400595B RID: 22875
		internal static int __PropertyOffset_TeleportType;

		// Token: 0x0400595C RID: 22876
		internal static int __PropertyOffset_BehaviourType;

		// Token: 0x0400595D RID: 22877
		internal static int __PropertyOffset_bCheckIfStillInWorld;

		// Token: 0x0400595E RID: 22878
		internal static int __PropertyOffset_bForceSubStepping;

		// Token: 0x0400595F RID: 22879
		internal static byte __PropertyMask_bForceSubStepping;

		// Token: 0x04005960 RID: 22880
		internal static int __PropertyOffset_OnInterpToReverse;

		// Token: 0x04005961 RID: 22881
		[Nullable(2)]
		private FOnInterpToReverseDelegate _OnInterpToReverse;

		// Token: 0x04005962 RID: 22882
		internal static int __PropertyOffset_OnInterpToStop;

		// Token: 0x04005963 RID: 22883
		[Nullable(2)]
		private FOnInterpToStopDelegate _OnInterpToStop;

		// Token: 0x04005964 RID: 22884
		internal static int __PropertyOffset_OnWaitBeginDelegate;

		// Token: 0x04005965 RID: 22885
		[Nullable(2)]
		private FOnInterpToWaitBeginDelegate _OnWaitBeginDelegate;

		// Token: 0x04005966 RID: 22886
		internal static int __PropertyOffset_OnWaitEndDelegate;

		// Token: 0x04005967 RID: 22887
		[Nullable(2)]
		private FOnInterpToWaitEndDelegate _OnWaitEndDelegate;

		// Token: 0x04005968 RID: 22888
		internal static int __PropertyOffset_OnResetDelegate;

		// Token: 0x04005969 RID: 22889
		[Nullable(2)]
		private FOnInterpToResetDelegate _OnResetDelegate;

		// Token: 0x0400596A RID: 22890
		internal static int __PropertyOffset_MaxSimulationTimeStep;

		// Token: 0x0400596B RID: 22891
		internal static int __PropertyOffset_MaxSimulationIterations;

		// Token: 0x0400596C RID: 22892
		internal static int __PropertyOffset_ControlPoints;

		// Token: 0x0400596D RID: 22893
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FInterpControlPoint> _ControlPoints;
	}
}
