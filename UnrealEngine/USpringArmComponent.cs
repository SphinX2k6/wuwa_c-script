using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001182 RID: 4482
	[UnrealObjectPath("/Script/Engine.SpringArmComponent")]
	[UnrealStructLayout(720, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 720)]
	public class USpringArmComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601078A RID: 67466 RVA: 0x00183040 File Offset: 0x00181240
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USpringArmComponent._ClassPtr;
		}

		// Token: 0x0601078B RID: 67467 RVA: 0x0018304C File Offset: 0x0018124C
		public USpringArmComponent() : this(BuiltinUtils.AllocNativeUObject(USpringArmComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601078C RID: 67468 RVA: 0x00183074 File Offset: 0x00181274
		[NullableContext(1)]
		public USpringArmComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USpringArmComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004039 RID: 16441
		// (get) Token: 0x0601078D RID: 67469 RVA: 0x001830A7 File Offset: 0x001812A7
		// (set) Token: 0x0601078E RID: 67470 RVA: 0x001830B7 File Offset: 0x001812B7
		public unsafe float TargetArmLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_TargetArmLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_TargetArmLength) = value;
			}
		}

		// Token: 0x1700403A RID: 16442
		// (get) Token: 0x0601078F RID: 67471 RVA: 0x001830C8 File Offset: 0x001812C8
		// (set) Token: 0x06010790 RID: 67472 RVA: 0x001830DC File Offset: 0x001812DC
		public unsafe FVector SocketOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_SocketOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_SocketOffset) = value;
			}
		}

		// Token: 0x1700403B RID: 16443
		// (get) Token: 0x06010791 RID: 67473 RVA: 0x001830F1 File Offset: 0x001812F1
		// (set) Token: 0x06010792 RID: 67474 RVA: 0x00183105 File Offset: 0x00181305
		public unsafe FVector TargetOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_TargetOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_TargetOffset) = value;
			}
		}

		// Token: 0x1700403C RID: 16444
		// (get) Token: 0x06010793 RID: 67475 RVA: 0x0018311A File Offset: 0x0018131A
		// (set) Token: 0x06010794 RID: 67476 RVA: 0x0018312A File Offset: 0x0018132A
		public unsafe float ProbeSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_ProbeSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_ProbeSize) = value;
			}
		}

		// Token: 0x1700403D RID: 16445
		// (get) Token: 0x06010795 RID: 67477 RVA: 0x0018313B File Offset: 0x0018133B
		// (set) Token: 0x06010796 RID: 67478 RVA: 0x0018314F File Offset: 0x0018134F
		public unsafe TEnumAsByte<ECollisionChannel> ProbeChannel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_ProbeChannel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_ProbeChannel) = value;
			}
		}

		// Token: 0x1700403E RID: 16446
		// (get) Token: 0x06010797 RID: 67479 RVA: 0x00183164 File Offset: 0x00181364
		// (set) Token: 0x06010798 RID: 67480 RVA: 0x0018317D File Offset: 0x0018137D
		public unsafe bool bDoCollisionTest
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bDoCollisionTest) & USpringArmComponent.__PropertyMask_bDoCollisionTest) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bDoCollisionTest) = ((*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bDoCollisionTest) & ~USpringArmComponent.__PropertyMask_bDoCollisionTest) | (value ? USpringArmComponent.__PropertyMask_bDoCollisionTest : 0));
			}
		}

		// Token: 0x1700403F RID: 16447
		// (get) Token: 0x06010799 RID: 67481 RVA: 0x001831AD File Offset: 0x001813AD
		// (set) Token: 0x0601079A RID: 67482 RVA: 0x001831C6 File Offset: 0x001813C6
		public unsafe bool bUsePawnControlRotation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bUsePawnControlRotation) & USpringArmComponent.__PropertyMask_bUsePawnControlRotation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bUsePawnControlRotation) = ((*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bUsePawnControlRotation) & ~USpringArmComponent.__PropertyMask_bUsePawnControlRotation) | (value ? USpringArmComponent.__PropertyMask_bUsePawnControlRotation : 0));
			}
		}

		// Token: 0x17004040 RID: 16448
		// (get) Token: 0x0601079B RID: 67483 RVA: 0x001831F6 File Offset: 0x001813F6
		// (set) Token: 0x0601079C RID: 67484 RVA: 0x0018320F File Offset: 0x0018140F
		public unsafe bool bInheritPitch
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bInheritPitch) & USpringArmComponent.__PropertyMask_bInheritPitch) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bInheritPitch) = ((*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bInheritPitch) & ~USpringArmComponent.__PropertyMask_bInheritPitch) | (value ? USpringArmComponent.__PropertyMask_bInheritPitch : 0));
			}
		}

		// Token: 0x17004041 RID: 16449
		// (get) Token: 0x0601079D RID: 67485 RVA: 0x0018323F File Offset: 0x0018143F
		// (set) Token: 0x0601079E RID: 67486 RVA: 0x00183258 File Offset: 0x00181458
		public unsafe bool bInheritYaw
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bInheritYaw) & USpringArmComponent.__PropertyMask_bInheritYaw) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bInheritYaw) = ((*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bInheritYaw) & ~USpringArmComponent.__PropertyMask_bInheritYaw) | (value ? USpringArmComponent.__PropertyMask_bInheritYaw : 0));
			}
		}

		// Token: 0x17004042 RID: 16450
		// (get) Token: 0x0601079F RID: 67487 RVA: 0x00183288 File Offset: 0x00181488
		// (set) Token: 0x060107A0 RID: 67488 RVA: 0x001832A1 File Offset: 0x001814A1
		public unsafe bool bInheritRoll
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bInheritRoll) & USpringArmComponent.__PropertyMask_bInheritRoll) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bInheritRoll) = ((*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bInheritRoll) & ~USpringArmComponent.__PropertyMask_bInheritRoll) | (value ? USpringArmComponent.__PropertyMask_bInheritRoll : 0));
			}
		}

		// Token: 0x17004043 RID: 16451
		// (get) Token: 0x060107A1 RID: 67489 RVA: 0x001832D1 File Offset: 0x001814D1
		// (set) Token: 0x060107A2 RID: 67490 RVA: 0x001832EA File Offset: 0x001814EA
		public unsafe bool bEnableCameraLag
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bEnableCameraLag) & USpringArmComponent.__PropertyMask_bEnableCameraLag) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bEnableCameraLag) = ((*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bEnableCameraLag) & ~USpringArmComponent.__PropertyMask_bEnableCameraLag) | (value ? USpringArmComponent.__PropertyMask_bEnableCameraLag : 0));
			}
		}

		// Token: 0x17004044 RID: 16452
		// (get) Token: 0x060107A3 RID: 67491 RVA: 0x0018331A File Offset: 0x0018151A
		// (set) Token: 0x060107A4 RID: 67492 RVA: 0x00183333 File Offset: 0x00181533
		public unsafe bool bEnableCameraRotationLag
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bEnableCameraRotationLag) & USpringArmComponent.__PropertyMask_bEnableCameraRotationLag) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bEnableCameraRotationLag) = ((*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bEnableCameraRotationLag) & ~USpringArmComponent.__PropertyMask_bEnableCameraRotationLag) | (value ? USpringArmComponent.__PropertyMask_bEnableCameraRotationLag : 0));
			}
		}

		// Token: 0x17004045 RID: 16453
		// (get) Token: 0x060107A5 RID: 67493 RVA: 0x00183363 File Offset: 0x00181563
		// (set) Token: 0x060107A6 RID: 67494 RVA: 0x0018337C File Offset: 0x0018157C
		public unsafe bool bUseCameraLagSubstepping
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bUseCameraLagSubstepping) & USpringArmComponent.__PropertyMask_bUseCameraLagSubstepping) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bUseCameraLagSubstepping) = ((*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bUseCameraLagSubstepping) & ~USpringArmComponent.__PropertyMask_bUseCameraLagSubstepping) | (value ? USpringArmComponent.__PropertyMask_bUseCameraLagSubstepping : 0));
			}
		}

		// Token: 0x17004046 RID: 16454
		// (get) Token: 0x060107A7 RID: 67495 RVA: 0x001833AC File Offset: 0x001815AC
		// (set) Token: 0x060107A8 RID: 67496 RVA: 0x001833C5 File Offset: 0x001815C5
		public unsafe bool bDrawDebugLagMarkers
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bDrawDebugLagMarkers) & USpringArmComponent.__PropertyMask_bDrawDebugLagMarkers) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bDrawDebugLagMarkers) = ((*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_bDrawDebugLagMarkers) & ~USpringArmComponent.__PropertyMask_bDrawDebugLagMarkers) | (value ? USpringArmComponent.__PropertyMask_bDrawDebugLagMarkers : 0));
			}
		}

		// Token: 0x17004047 RID: 16455
		// (get) Token: 0x060107A9 RID: 67497 RVA: 0x001833F5 File Offset: 0x001815F5
		// (set) Token: 0x060107AA RID: 67498 RVA: 0x00183405 File Offset: 0x00181605
		public unsafe float CameraLagSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_CameraLagSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_CameraLagSpeed) = value;
			}
		}

		// Token: 0x17004048 RID: 16456
		// (get) Token: 0x060107AB RID: 67499 RVA: 0x00183416 File Offset: 0x00181616
		// (set) Token: 0x060107AC RID: 67500 RVA: 0x00183426 File Offset: 0x00181626
		public unsafe float CameraRotationLagSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_CameraRotationLagSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_CameraRotationLagSpeed) = value;
			}
		}

		// Token: 0x17004049 RID: 16457
		// (get) Token: 0x060107AD RID: 67501 RVA: 0x00183437 File Offset: 0x00181637
		// (set) Token: 0x060107AE RID: 67502 RVA: 0x00183447 File Offset: 0x00181647
		public unsafe float CameraRotationLagSpeedPercent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_CameraRotationLagSpeedPercent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_CameraRotationLagSpeedPercent) = value;
			}
		}

		// Token: 0x1700404A RID: 16458
		// (get) Token: 0x060107AF RID: 67503 RVA: 0x00183458 File Offset: 0x00181658
		// (set) Token: 0x060107B0 RID: 67504 RVA: 0x00183468 File Offset: 0x00181668
		public unsafe float CameraLagMaxTimeStep
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_CameraLagMaxTimeStep);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_CameraLagMaxTimeStep) = value;
			}
		}

		// Token: 0x1700404B RID: 16459
		// (get) Token: 0x060107B1 RID: 67505 RVA: 0x00183479 File Offset: 0x00181679
		// (set) Token: 0x060107B2 RID: 67506 RVA: 0x00183489 File Offset: 0x00181689
		public unsafe float CameraLagMaxDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_CameraLagMaxDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpringArmComponent.__PropertyOffset_CameraLagMaxDistance) = value;
			}
		}

		// Token: 0x060107B3 RID: 67507 RVA: 0x0018349A File Offset: 0x0018169A
		public bool IsCollisionFixApplied()
		{
			return USpringArmComponent.__IsCollisionFixApplied_Internal(base.NativePtr);
		}

		// Token: 0x060107B4 RID: 67508 RVA: 0x001834A7 File Offset: 0x001816A7
		public FVector GetUnfixedCameraPosition()
		{
			return USpringArmComponent.__GetUnfixedCameraPosition_Internal(base.NativePtr);
		}

		// Token: 0x060107B5 RID: 67509 RVA: 0x001834B4 File Offset: 0x001816B4
		public FRotator GetTargetRotation()
		{
			return USpringArmComponent.__GetTargetRotation_Internal(base.NativePtr);
		}

		// Token: 0x060107B6 RID: 67510
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsCollisionFixApplied_Internal(IntPtr @this);

		// Token: 0x060107B7 RID: 67511
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetUnfixedCameraPosition_Internal(IntPtr @this);

		// Token: 0x060107B8 RID: 67512
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __GetTargetRotation_Internal(IntPtr @this);

		// Token: 0x060107B9 RID: 67513 RVA: 0x001834C1 File Offset: 0x001816C1
		static USpringArmComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SpringArmComponent");
		}

		// Token: 0x060107BA RID: 67514 RVA: 0x001834CF File Offset: 0x001816CF
		protected USpringArmComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008CF7 RID: 36087
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SpringArmComponent";

		// Token: 0x04008CF8 RID: 36088
		private static IntPtr _ClassPtr;

		// Token: 0x04008CF9 RID: 36089
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008CFA RID: 36090
		internal static int __PropertyOffset_TargetArmLength;

		// Token: 0x04008CFB RID: 36091
		internal static int __PropertyOffset_SocketOffset;

		// Token: 0x04008CFC RID: 36092
		internal static int __PropertyOffset_TargetOffset;

		// Token: 0x04008CFD RID: 36093
		internal static int __PropertyOffset_ProbeSize;

		// Token: 0x04008CFE RID: 36094
		internal static int __PropertyOffset_ProbeChannel;

		// Token: 0x04008CFF RID: 36095
		internal static int __PropertyOffset_bDoCollisionTest;

		// Token: 0x04008D00 RID: 36096
		internal static byte __PropertyMask_bDoCollisionTest;

		// Token: 0x04008D01 RID: 36097
		internal static int __PropertyOffset_bUsePawnControlRotation;

		// Token: 0x04008D02 RID: 36098
		internal static byte __PropertyMask_bUsePawnControlRotation;

		// Token: 0x04008D03 RID: 36099
		internal static int __PropertyOffset_bInheritPitch;

		// Token: 0x04008D04 RID: 36100
		internal static byte __PropertyMask_bInheritPitch;

		// Token: 0x04008D05 RID: 36101
		internal static int __PropertyOffset_bInheritYaw;

		// Token: 0x04008D06 RID: 36102
		internal static byte __PropertyMask_bInheritYaw;

		// Token: 0x04008D07 RID: 36103
		internal static int __PropertyOffset_bInheritRoll;

		// Token: 0x04008D08 RID: 36104
		internal static byte __PropertyMask_bInheritRoll;

		// Token: 0x04008D09 RID: 36105
		internal static int __PropertyOffset_bEnableCameraLag;

		// Token: 0x04008D0A RID: 36106
		internal static byte __PropertyMask_bEnableCameraLag;

		// Token: 0x04008D0B RID: 36107
		internal static int __PropertyOffset_bEnableCameraRotationLag;

		// Token: 0x04008D0C RID: 36108
		internal static byte __PropertyMask_bEnableCameraRotationLag;

		// Token: 0x04008D0D RID: 36109
		internal static int __PropertyOffset_bUseCameraLagSubstepping;

		// Token: 0x04008D0E RID: 36110
		internal static byte __PropertyMask_bUseCameraLagSubstepping;

		// Token: 0x04008D0F RID: 36111
		internal static int __PropertyOffset_bDrawDebugLagMarkers;

		// Token: 0x04008D10 RID: 36112
		internal static byte __PropertyMask_bDrawDebugLagMarkers;

		// Token: 0x04008D11 RID: 36113
		internal static int __PropertyOffset_CameraLagSpeed;

		// Token: 0x04008D12 RID: 36114
		internal static int __PropertyOffset_CameraRotationLagSpeed;

		// Token: 0x04008D13 RID: 36115
		internal static int __PropertyOffset_CameraRotationLagSpeedPercent;

		// Token: 0x04008D14 RID: 36116
		internal static int __PropertyOffset_CameraLagMaxTimeStep;

		// Token: 0x04008D15 RID: 36117
		internal static int __PropertyOffset_CameraLagMaxDistance;
	}
}
