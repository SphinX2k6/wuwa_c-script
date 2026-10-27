using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008CE RID: 2254
	[UnrealObjectPath("/Script/Engine.BodyInstance")]
	[UnrealStructLayout(424, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 424)]
	public class FBodyInstance : FBodyInstanceCore, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007BB3 RID: 31667 RVA: 0x000B1403 File Offset: 0x000AF603
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBodyInstance._ScriptStructPtr != 0) ? FBodyInstance._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BodyInstance", ref FBodyInstance._ScriptStructPtr);
		}

		// Token: 0x17001D04 RID: 7428
		// (get) Token: 0x06007BB4 RID: 31668 RVA: 0x000B1427 File Offset: 0x000AF627
		// (set) Token: 0x06007BB5 RID: 31669 RVA: 0x000B143B File Offset: 0x000AF63B
		public unsafe TEnumAsByte<ECollisionChannel> ObjectType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_ObjectType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_ObjectType) = value;
			}
		}

		// Token: 0x17001D05 RID: 7429
		// (get) Token: 0x06007BB6 RID: 31670 RVA: 0x000B1450 File Offset: 0x000AF650
		// (set) Token: 0x06007BB7 RID: 31671 RVA: 0x000B1464 File Offset: 0x000AF664
		public unsafe TEnumAsByte<ECollisionEnabled> CollisionEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_CollisionEnabled);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_CollisionEnabled) = value;
			}
		}

		// Token: 0x17001D06 RID: 7430
		// (get) Token: 0x06007BB8 RID: 31672 RVA: 0x000B1479 File Offset: 0x000AF679
		// (set) Token: 0x06007BB9 RID: 31673 RVA: 0x000B1489 File Offset: 0x000AF689
		public unsafe ESleepFamily SleepFamily
		{
			get
			{
				return (ESleepFamily)(*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_SleepFamily));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_SleepFamily) = (byte)value;
			}
		}

		// Token: 0x17001D07 RID: 7431
		// (get) Token: 0x06007BBA RID: 31674 RVA: 0x000B149A File Offset: 0x000AF69A
		// (set) Token: 0x06007BBB RID: 31675 RVA: 0x000B14AE File Offset: 0x000AF6AE
		public unsafe TEnumAsByte<EDOFMode> DOFMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_DOFMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_DOFMode) = value;
			}
		}

		// Token: 0x17001D08 RID: 7432
		// (get) Token: 0x06007BBC RID: 31676 RVA: 0x000B14C3 File Offset: 0x000AF6C3
		// (set) Token: 0x06007BBD RID: 31677 RVA: 0x000B14DC File Offset: 0x000AF6DC
		public unsafe bool bUseCCD
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bUseCCD) & FBodyInstance.__PropertyMask_bUseCCD) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bUseCCD) = ((*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bUseCCD) & ~FBodyInstance.__PropertyMask_bUseCCD) | (value ? FBodyInstance.__PropertyMask_bUseCCD : 0));
			}
		}

		// Token: 0x17001D09 RID: 7433
		// (get) Token: 0x06007BBE RID: 31678 RVA: 0x000B150C File Offset: 0x000AF70C
		// (set) Token: 0x06007BBF RID: 31679 RVA: 0x000B1525 File Offset: 0x000AF725
		public unsafe bool bIgnoreAnalyticCollisions
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bIgnoreAnalyticCollisions) & FBodyInstance.__PropertyMask_bIgnoreAnalyticCollisions) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bIgnoreAnalyticCollisions) = ((*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bIgnoreAnalyticCollisions) & ~FBodyInstance.__PropertyMask_bIgnoreAnalyticCollisions) | (value ? FBodyInstance.__PropertyMask_bIgnoreAnalyticCollisions : 0));
			}
		}

		// Token: 0x17001D0A RID: 7434
		// (get) Token: 0x06007BC0 RID: 31680 RVA: 0x000B1555 File Offset: 0x000AF755
		// (set) Token: 0x06007BC1 RID: 31681 RVA: 0x000B156E File Offset: 0x000AF76E
		public unsafe bool bNotifyRigidBodyCollision
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bNotifyRigidBodyCollision) & FBodyInstance.__PropertyMask_bNotifyRigidBodyCollision) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bNotifyRigidBodyCollision) = ((*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bNotifyRigidBodyCollision) & ~FBodyInstance.__PropertyMask_bNotifyRigidBodyCollision) | (value ? FBodyInstance.__PropertyMask_bNotifyRigidBodyCollision : 0));
			}
		}

		// Token: 0x17001D0B RID: 7435
		// (get) Token: 0x06007BC2 RID: 31682 RVA: 0x000B159E File Offset: 0x000AF79E
		// (set) Token: 0x06007BC3 RID: 31683 RVA: 0x000B15B7 File Offset: 0x000AF7B7
		public unsafe bool bLockTranslation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bLockTranslation) & FBodyInstance.__PropertyMask_bLockTranslation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bLockTranslation) = ((*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bLockTranslation) & ~FBodyInstance.__PropertyMask_bLockTranslation) | (value ? FBodyInstance.__PropertyMask_bLockTranslation : 0));
			}
		}

		// Token: 0x17001D0C RID: 7436
		// (get) Token: 0x06007BC4 RID: 31684 RVA: 0x000B15E7 File Offset: 0x000AF7E7
		// (set) Token: 0x06007BC5 RID: 31685 RVA: 0x000B1600 File Offset: 0x000AF800
		public unsafe bool bLockRotation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bLockRotation) & FBodyInstance.__PropertyMask_bLockRotation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bLockRotation) = ((*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bLockRotation) & ~FBodyInstance.__PropertyMask_bLockRotation) | (value ? FBodyInstance.__PropertyMask_bLockRotation : 0));
			}
		}

		// Token: 0x17001D0D RID: 7437
		// (get) Token: 0x06007BC6 RID: 31686 RVA: 0x000B1630 File Offset: 0x000AF830
		// (set) Token: 0x06007BC7 RID: 31687 RVA: 0x000B1649 File Offset: 0x000AF849
		public unsafe bool bLockXTranslation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bLockXTranslation) & FBodyInstance.__PropertyMask_bLockXTranslation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bLockXTranslation) = ((*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bLockXTranslation) & ~FBodyInstance.__PropertyMask_bLockXTranslation) | (value ? FBodyInstance.__PropertyMask_bLockXTranslation : 0));
			}
		}

		// Token: 0x17001D0E RID: 7438
		// (get) Token: 0x06007BC8 RID: 31688 RVA: 0x000B1679 File Offset: 0x000AF879
		// (set) Token: 0x06007BC9 RID: 31689 RVA: 0x000B1692 File Offset: 0x000AF892
		public unsafe bool bLockYTranslation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bLockYTranslation) & FBodyInstance.__PropertyMask_bLockYTranslation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bLockYTranslation) = ((*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bLockYTranslation) & ~FBodyInstance.__PropertyMask_bLockYTranslation) | (value ? FBodyInstance.__PropertyMask_bLockYTranslation : 0));
			}
		}

		// Token: 0x17001D0F RID: 7439
		// (get) Token: 0x06007BCA RID: 31690 RVA: 0x000B16C2 File Offset: 0x000AF8C2
		// (set) Token: 0x06007BCB RID: 31691 RVA: 0x000B16DB File Offset: 0x000AF8DB
		public unsafe bool bLockZTranslation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bLockZTranslation) & FBodyInstance.__PropertyMask_bLockZTranslation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bLockZTranslation) = ((*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bLockZTranslation) & ~FBodyInstance.__PropertyMask_bLockZTranslation) | (value ? FBodyInstance.__PropertyMask_bLockZTranslation : 0));
			}
		}

		// Token: 0x17001D10 RID: 7440
		// (get) Token: 0x06007BCC RID: 31692 RVA: 0x000B170B File Offset: 0x000AF90B
		// (set) Token: 0x06007BCD RID: 31693 RVA: 0x000B1724 File Offset: 0x000AF924
		public unsafe bool bLockXRotation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bLockXRotation) & FBodyInstance.__PropertyMask_bLockXRotation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bLockXRotation) = ((*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bLockXRotation) & ~FBodyInstance.__PropertyMask_bLockXRotation) | (value ? FBodyInstance.__PropertyMask_bLockXRotation : 0));
			}
		}

		// Token: 0x17001D11 RID: 7441
		// (get) Token: 0x06007BCE RID: 31694 RVA: 0x000B1754 File Offset: 0x000AF954
		// (set) Token: 0x06007BCF RID: 31695 RVA: 0x000B176D File Offset: 0x000AF96D
		public unsafe bool bLockYRotation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bLockYRotation) & FBodyInstance.__PropertyMask_bLockYRotation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bLockYRotation) = ((*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bLockYRotation) & ~FBodyInstance.__PropertyMask_bLockYRotation) | (value ? FBodyInstance.__PropertyMask_bLockYRotation : 0));
			}
		}

		// Token: 0x17001D12 RID: 7442
		// (get) Token: 0x06007BD0 RID: 31696 RVA: 0x000B179D File Offset: 0x000AF99D
		// (set) Token: 0x06007BD1 RID: 31697 RVA: 0x000B17B6 File Offset: 0x000AF9B6
		public unsafe bool bLockZRotation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bLockZRotation) & FBodyInstance.__PropertyMask_bLockZRotation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bLockZRotation) = ((*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bLockZRotation) & ~FBodyInstance.__PropertyMask_bLockZRotation) | (value ? FBodyInstance.__PropertyMask_bLockZRotation : 0));
			}
		}

		// Token: 0x17001D13 RID: 7443
		// (get) Token: 0x06007BD2 RID: 31698 RVA: 0x000B17E6 File Offset: 0x000AF9E6
		// (set) Token: 0x06007BD3 RID: 31699 RVA: 0x000B17FF File Offset: 0x000AF9FF
		public unsafe bool bOverrideMaxAngularVelocity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bOverrideMaxAngularVelocity) & FBodyInstance.__PropertyMask_bOverrideMaxAngularVelocity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bOverrideMaxAngularVelocity) = ((*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bOverrideMaxAngularVelocity) & ~FBodyInstance.__PropertyMask_bOverrideMaxAngularVelocity) | (value ? FBodyInstance.__PropertyMask_bOverrideMaxAngularVelocity : 0));
			}
		}

		// Token: 0x17001D14 RID: 7444
		// (get) Token: 0x06007BD4 RID: 31700 RVA: 0x000B182F File Offset: 0x000AFA2F
		// (set) Token: 0x06007BD5 RID: 31701 RVA: 0x000B1848 File Offset: 0x000AFA48
		public unsafe bool bOverrideMaxDepenetrationVelocity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bOverrideMaxDepenetrationVelocity) & FBodyInstance.__PropertyMask_bOverrideMaxDepenetrationVelocity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bOverrideMaxDepenetrationVelocity) = ((*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bOverrideMaxDepenetrationVelocity) & ~FBodyInstance.__PropertyMask_bOverrideMaxDepenetrationVelocity) | (value ? FBodyInstance.__PropertyMask_bOverrideMaxDepenetrationVelocity : 0));
			}
		}

		// Token: 0x17001D15 RID: 7445
		// (get) Token: 0x06007BD6 RID: 31702 RVA: 0x000B1878 File Offset: 0x000AFA78
		// (set) Token: 0x06007BD7 RID: 31703 RVA: 0x000B1891 File Offset: 0x000AFA91
		public unsafe bool bOverrideWalkableSlopeOnInstance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bOverrideWalkableSlopeOnInstance) & FBodyInstance.__PropertyMask_bOverrideWalkableSlopeOnInstance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bOverrideWalkableSlopeOnInstance) = ((*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bOverrideWalkableSlopeOnInstance) & ~FBodyInstance.__PropertyMask_bOverrideWalkableSlopeOnInstance) | (value ? FBodyInstance.__PropertyMask_bOverrideWalkableSlopeOnInstance : 0));
			}
		}

		// Token: 0x17001D16 RID: 7446
		// (get) Token: 0x06007BD8 RID: 31704 RVA: 0x000B18C1 File Offset: 0x000AFAC1
		// (set) Token: 0x06007BD9 RID: 31705 RVA: 0x000B18DA File Offset: 0x000AFADA
		public unsafe bool bInterpolateWhenSubStepping
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bInterpolateWhenSubStepping) & FBodyInstance.__PropertyMask_bInterpolateWhenSubStepping) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bInterpolateWhenSubStepping) = ((*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_bInterpolateWhenSubStepping) & ~FBodyInstance.__PropertyMask_bInterpolateWhenSubStepping) | (value ? FBodyInstance.__PropertyMask_bInterpolateWhenSubStepping : 0));
			}
		}

		// Token: 0x17001D17 RID: 7447
		// (get) Token: 0x06007BDA RID: 31706 RVA: 0x000B190A File Offset: 0x000AFB0A
		// (set) Token: 0x06007BDB RID: 31707 RVA: 0x000B191E File Offset: 0x000AFB1E
		public unsafe FName CollisionProfileName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_CollisionProfileName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_CollisionProfileName) = value;
			}
		}

		// Token: 0x17001D18 RID: 7448
		// (get) Token: 0x06007BDC RID: 31708 RVA: 0x000B1933 File Offset: 0x000AFB33
		// (set) Token: 0x06007BDD RID: 31709 RVA: 0x000B1943 File Offset: 0x000AFB43
		public unsafe byte PositionSolverIterationCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_PositionSolverIterationCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_PositionSolverIterationCount) = value;
			}
		}

		// Token: 0x17001D19 RID: 7449
		// (get) Token: 0x06007BDE RID: 31710 RVA: 0x000B1954 File Offset: 0x000AFB54
		// (set) Token: 0x06007BDF RID: 31711 RVA: 0x000B1964 File Offset: 0x000AFB64
		public unsafe byte VelocitySolverIterationCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_VelocitySolverIterationCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_VelocitySolverIterationCount) = value;
			}
		}

		// Token: 0x17001D1A RID: 7450
		// (get) Token: 0x06007BE0 RID: 31712 RVA: 0x000B1978 File Offset: 0x000AFB78
		// (set) Token: 0x06007BE1 RID: 31713 RVA: 0x000B19BB File Offset: 0x000AFBBB
		[Nullable(1)]
		public FCollisionResponse CollisionResponses
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FCollisionResponse result;
				if ((result = this._CollisionResponses) == null)
				{
					result = (this._CollisionResponses = new FCollisionResponse(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_CollisionResponses, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCollisionResponse.StaticStruct(), base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_CollisionResponses, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001D1B RID: 7451
		// (get) Token: 0x06007BE2 RID: 31714 RVA: 0x000B19DC File Offset: 0x000AFBDC
		// (set) Token: 0x06007BE3 RID: 31715 RVA: 0x000B19EC File Offset: 0x000AFBEC
		public unsafe float MaxDepenetrationVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_MaxDepenetrationVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_MaxDepenetrationVelocity) = value;
			}
		}

		// Token: 0x17001D1C RID: 7452
		// (get) Token: 0x06007BE4 RID: 31716 RVA: 0x000B19FD File Offset: 0x000AFBFD
		// (set) Token: 0x06007BE5 RID: 31717 RVA: 0x000B1A0D File Offset: 0x000AFC0D
		public unsafe float MassInKgOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_MassInKgOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_MassInKgOverride) = value;
			}
		}

		// Token: 0x17001D1D RID: 7453
		// (get) Token: 0x06007BE6 RID: 31718 RVA: 0x000B1A1E File Offset: 0x000AFC1E
		// (set) Token: 0x06007BE7 RID: 31719 RVA: 0x000B1A2E File Offset: 0x000AFC2E
		public unsafe float LinearDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_LinearDamping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_LinearDamping) = value;
			}
		}

		// Token: 0x17001D1E RID: 7454
		// (get) Token: 0x06007BE8 RID: 31720 RVA: 0x000B1A3F File Offset: 0x000AFC3F
		// (set) Token: 0x06007BE9 RID: 31721 RVA: 0x000B1A4F File Offset: 0x000AFC4F
		public unsafe float AngularDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_AngularDamping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_AngularDamping) = value;
			}
		}

		// Token: 0x17001D1F RID: 7455
		// (get) Token: 0x06007BEA RID: 31722 RVA: 0x000B1A60 File Offset: 0x000AFC60
		// (set) Token: 0x06007BEB RID: 31723 RVA: 0x000B1A74 File Offset: 0x000AFC74
		public unsafe FVector CustomDOFPlaneNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_CustomDOFPlaneNormal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_CustomDOFPlaneNormal) = value;
			}
		}

		// Token: 0x17001D20 RID: 7456
		// (get) Token: 0x06007BEC RID: 31724 RVA: 0x000B1A89 File Offset: 0x000AFC89
		// (set) Token: 0x06007BED RID: 31725 RVA: 0x000B1A9D File Offset: 0x000AFC9D
		public unsafe FVector COMNudge
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_COMNudge);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_COMNudge) = value;
			}
		}

		// Token: 0x17001D21 RID: 7457
		// (get) Token: 0x06007BEE RID: 31726 RVA: 0x000B1AB2 File Offset: 0x000AFCB2
		// (set) Token: 0x06007BEF RID: 31727 RVA: 0x000B1AC2 File Offset: 0x000AFCC2
		public unsafe float MassScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_MassScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_MassScale) = value;
			}
		}

		// Token: 0x17001D22 RID: 7458
		// (get) Token: 0x06007BF0 RID: 31728 RVA: 0x000B1AD3 File Offset: 0x000AFCD3
		// (set) Token: 0x06007BF1 RID: 31729 RVA: 0x000B1AE7 File Offset: 0x000AFCE7
		public unsafe FVector InertiaTensorScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_InertiaTensorScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_InertiaTensorScale) = value;
			}
		}

		// Token: 0x17001D23 RID: 7459
		// (get) Token: 0x06007BF2 RID: 31730 RVA: 0x000B1AFC File Offset: 0x000AFCFC
		// (set) Token: 0x06007BF3 RID: 31731 RVA: 0x000B1B3F File Offset: 0x000AFD3F
		[Nullable(1)]
		public FWalkableSlopeOverride WalkableSlopeOverride
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FWalkableSlopeOverride result;
				if ((result = this._WalkableSlopeOverride) == null)
				{
					result = (this._WalkableSlopeOverride = new FWalkableSlopeOverride(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_WalkableSlopeOverride, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FWalkableSlopeOverride.StaticStruct(), base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_WalkableSlopeOverride, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001D24 RID: 7460
		// (get) Token: 0x06007BF4 RID: 31732 RVA: 0x000B1B60 File Offset: 0x000AFD60
		// (set) Token: 0x06007BF5 RID: 31733 RVA: 0x000B1B74 File Offset: 0x000AFD74
		[Nullable(2)]
		public unsafe UPhysicalMaterial PhysMaterialOverride
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicalMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + FBodyInstance.__PropertyOffset_PhysMaterialOverride);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FBodyInstance.__PropertyOffset_PhysMaterialOverride, value);
			}
		}

		// Token: 0x17001D25 RID: 7461
		// (get) Token: 0x06007BF6 RID: 31734 RVA: 0x000B1B8C File Offset: 0x000AFD8C
		// (set) Token: 0x06007BF7 RID: 31735 RVA: 0x000B1BCF File Offset: 0x000AFDCF
		[Nullable(1)]
		public TArray<UPhysicalMaterial> ComplexPhysMaterialOverride
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UPhysicalMaterial> result;
				if ((result = this._ComplexPhysMaterialOverride) == null)
				{
					result = (this._ComplexPhysMaterialOverride = new TArray<UPhysicalMaterial>(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_ComplexPhysMaterialOverride, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ComplexPhysMaterialOverride.CopyAssign(value);
			}
		}

		// Token: 0x17001D26 RID: 7462
		// (get) Token: 0x06007BF8 RID: 31736 RVA: 0x000B1BDD File Offset: 0x000AFDDD
		// (set) Token: 0x06007BF9 RID: 31737 RVA: 0x000B1BED File Offset: 0x000AFDED
		public unsafe float MaxAngularVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_MaxAngularVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_MaxAngularVelocity) = value;
			}
		}

		// Token: 0x17001D27 RID: 7463
		// (get) Token: 0x06007BFA RID: 31738 RVA: 0x000B1BFE File Offset: 0x000AFDFE
		// (set) Token: 0x06007BFB RID: 31739 RVA: 0x000B1C0E File Offset: 0x000AFE0E
		public unsafe float CustomSleepThresholdMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_CustomSleepThresholdMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_CustomSleepThresholdMultiplier) = value;
			}
		}

		// Token: 0x17001D28 RID: 7464
		// (get) Token: 0x06007BFC RID: 31740 RVA: 0x000B1C1F File Offset: 0x000AFE1F
		// (set) Token: 0x06007BFD RID: 31741 RVA: 0x000B1C2F File Offset: 0x000AFE2F
		public unsafe float StabilizationThresholdMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_StabilizationThresholdMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_StabilizationThresholdMultiplier) = value;
			}
		}

		// Token: 0x17001D29 RID: 7465
		// (get) Token: 0x06007BFE RID: 31742 RVA: 0x000B1C40 File Offset: 0x000AFE40
		// (set) Token: 0x06007BFF RID: 31743 RVA: 0x000B1C50 File Offset: 0x000AFE50
		public unsafe float PhysicsBlendWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_PhysicsBlendWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBodyInstance.__PropertyOffset_PhysicsBlendWeight) = value;
			}
		}

		// Token: 0x06007C00 RID: 31744 RVA: 0x000B1C61 File Offset: 0x000AFE61
		public FBodyInstance()
		{
		}

		// Token: 0x06007C01 RID: 31745 RVA: 0x000B1C6C File Offset: 0x000AFE6C
		[NullableContext(1)]
		public FBodyInstance([Nullable(0)] TEnumAsByte<ECollisionChannel> ObjectType, [Nullable(0)] TEnumAsByte<ECollisionEnabled> CollisionEnabled, ESleepFamily SleepFamily, [Nullable(0)] TEnumAsByte<EDOFMode> DOFMode, bool bUseCCD, bool bIgnoreAnalyticCollisions, bool bNotifyRigidBodyCollision, bool bLockTranslation, bool bLockRotation, bool bLockXTranslation, bool bLockYTranslation, bool bLockZTranslation, bool bLockXRotation, bool bLockYRotation, bool bLockZRotation, bool bOverrideMaxAngularVelocity, bool bOverrideMaxDepenetrationVelocity, bool bOverrideWalkableSlopeOnInstance, bool bInterpolateWhenSubStepping, FCollisionResponseContainer ResponseToChannels_DEPRECATED, FName CollisionProfileName, byte PositionSolverIterationCount, byte VelocitySolverIterationCount, FCollisionResponse CollisionResponses, float MaxDepenetrationVelocity, float MassInKgOverride, float LinearDamping, float AngularDamping, FVector CustomDOFPlaneNormal, FVector COMNudge, float MassScale, FVector InertiaTensorScale, FWalkableSlopeOverride WalkableSlopeOverride, UPhysicalMaterial PhysMaterialOverride, TArray<UPhysicalMaterial> ComplexPhysMaterialOverride, float MaxAngularVelocity, float CustomSleepThresholdMultiplier, float StabilizationThresholdMultiplier, float PhysicsBlendWeight, bool bSimulatePhysics, bool bOverrideMass, bool bEnableGravity, bool bAutoWeld, bool bStartAwake, bool bGenerateWakeEvents, bool bUpdateMassWhenScaleChanges)
		{
			this.ObjectType = ObjectType;
			this.CollisionEnabled = CollisionEnabled;
			this.SleepFamily = SleepFamily;
			this.DOFMode = DOFMode;
			this.bUseCCD = bUseCCD;
			this.bIgnoreAnalyticCollisions = bIgnoreAnalyticCollisions;
			this.bNotifyRigidBodyCollision = bNotifyRigidBodyCollision;
			this.bLockTranslation = bLockTranslation;
			this.bLockRotation = bLockRotation;
			this.bLockXTranslation = bLockXTranslation;
			this.bLockYTranslation = bLockYTranslation;
			this.bLockZTranslation = bLockZTranslation;
			this.bLockXRotation = bLockXRotation;
			this.bLockYRotation = bLockYRotation;
			this.bLockZRotation = bLockZRotation;
			this.bOverrideMaxAngularVelocity = bOverrideMaxAngularVelocity;
			this.bOverrideMaxDepenetrationVelocity = bOverrideMaxDepenetrationVelocity;
			this.bOverrideWalkableSlopeOnInstance = bOverrideWalkableSlopeOnInstance;
			this.bInterpolateWhenSubStepping = bInterpolateWhenSubStepping;
			this.CollisionProfileName = CollisionProfileName;
			this.PositionSolverIterationCount = PositionSolverIterationCount;
			this.VelocitySolverIterationCount = VelocitySolverIterationCount;
			this.CollisionResponses = CollisionResponses;
			this.MaxDepenetrationVelocity = MaxDepenetrationVelocity;
			this.MassInKgOverride = MassInKgOverride;
			this.LinearDamping = LinearDamping;
			this.AngularDamping = AngularDamping;
			this.CustomDOFPlaneNormal = CustomDOFPlaneNormal;
			this.COMNudge = COMNudge;
			this.MassScale = MassScale;
			this.InertiaTensorScale = InertiaTensorScale;
			this.WalkableSlopeOverride = WalkableSlopeOverride;
			this.PhysMaterialOverride = PhysMaterialOverride;
			this.ComplexPhysMaterialOverride = ComplexPhysMaterialOverride;
			this.MaxAngularVelocity = MaxAngularVelocity;
			this.CustomSleepThresholdMultiplier = CustomSleepThresholdMultiplier;
			this.StabilizationThresholdMultiplier = StabilizationThresholdMultiplier;
			this.PhysicsBlendWeight = PhysicsBlendWeight;
			base.bSimulatePhysics = bSimulatePhysics;
			base.bOverrideMass = bOverrideMass;
			base.bEnableGravity = bEnableGravity;
			base.bAutoWeld = bAutoWeld;
			base.bStartAwake = bStartAwake;
			base.bGenerateWakeEvents = bGenerateWakeEvents;
			base.bUpdateMassWhenScaleChanges = bUpdateMassWhenScaleChanges;
		}

		// Token: 0x06007C02 RID: 31746 RVA: 0x000B1DE4 File Offset: 0x000AFFE4
		protected override IntPtr GetUStructPtr()
		{
			return FBodyInstance.StaticStruct();
		}

		// Token: 0x06007C03 RID: 31747 RVA: 0x000B1DF0 File Offset: 0x000AFFF0
		[NullableContext(2)]
		public FBodyInstance(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007C04 RID: 31748 RVA: 0x000B1DFA File Offset: 0x000AFFFA
		public FBodyInstance(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007C05 RID: 31749 RVA: 0x000B1E05 File Offset: 0x000B0005
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBodyInstance(Pointer, false, true);
		}

		// Token: 0x06007C06 RID: 31750 RVA: 0x000B1E0F File Offset: 0x000B000F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBodyInstance(Pointer, MemoryOwner);
		}

		// Token: 0x04003B33 RID: 15155
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.BodyInstance";

		// Token: 0x04003B34 RID: 15156
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003B35 RID: 15157
		internal static int __PropertyOffset_ObjectType;

		// Token: 0x04003B36 RID: 15158
		internal static int __PropertyOffset_CollisionEnabled;

		// Token: 0x04003B37 RID: 15159
		internal static int __PropertyOffset_SleepFamily;

		// Token: 0x04003B38 RID: 15160
		internal static int __PropertyOffset_DOFMode;

		// Token: 0x04003B39 RID: 15161
		internal static int __PropertyOffset_bUseCCD;

		// Token: 0x04003B3A RID: 15162
		internal static byte __PropertyMask_bUseCCD;

		// Token: 0x04003B3B RID: 15163
		internal static int __PropertyOffset_bIgnoreAnalyticCollisions;

		// Token: 0x04003B3C RID: 15164
		internal static byte __PropertyMask_bIgnoreAnalyticCollisions;

		// Token: 0x04003B3D RID: 15165
		internal static int __PropertyOffset_bNotifyRigidBodyCollision;

		// Token: 0x04003B3E RID: 15166
		internal static byte __PropertyMask_bNotifyRigidBodyCollision;

		// Token: 0x04003B3F RID: 15167
		internal static int __PropertyOffset_bLockTranslation;

		// Token: 0x04003B40 RID: 15168
		internal static byte __PropertyMask_bLockTranslation;

		// Token: 0x04003B41 RID: 15169
		internal static int __PropertyOffset_bLockRotation;

		// Token: 0x04003B42 RID: 15170
		internal static byte __PropertyMask_bLockRotation;

		// Token: 0x04003B43 RID: 15171
		internal static int __PropertyOffset_bLockXTranslation;

		// Token: 0x04003B44 RID: 15172
		internal static byte __PropertyMask_bLockXTranslation;

		// Token: 0x04003B45 RID: 15173
		internal static int __PropertyOffset_bLockYTranslation;

		// Token: 0x04003B46 RID: 15174
		internal static byte __PropertyMask_bLockYTranslation;

		// Token: 0x04003B47 RID: 15175
		internal static int __PropertyOffset_bLockZTranslation;

		// Token: 0x04003B48 RID: 15176
		internal static byte __PropertyMask_bLockZTranslation;

		// Token: 0x04003B49 RID: 15177
		internal static int __PropertyOffset_bLockXRotation;

		// Token: 0x04003B4A RID: 15178
		internal static byte __PropertyMask_bLockXRotation;

		// Token: 0x04003B4B RID: 15179
		internal static int __PropertyOffset_bLockYRotation;

		// Token: 0x04003B4C RID: 15180
		internal static byte __PropertyMask_bLockYRotation;

		// Token: 0x04003B4D RID: 15181
		internal static int __PropertyOffset_bLockZRotation;

		// Token: 0x04003B4E RID: 15182
		internal static byte __PropertyMask_bLockZRotation;

		// Token: 0x04003B4F RID: 15183
		internal static int __PropertyOffset_bOverrideMaxAngularVelocity;

		// Token: 0x04003B50 RID: 15184
		internal static byte __PropertyMask_bOverrideMaxAngularVelocity;

		// Token: 0x04003B51 RID: 15185
		internal static int __PropertyOffset_bOverrideMaxDepenetrationVelocity;

		// Token: 0x04003B52 RID: 15186
		internal static byte __PropertyMask_bOverrideMaxDepenetrationVelocity;

		// Token: 0x04003B53 RID: 15187
		internal static int __PropertyOffset_bOverrideWalkableSlopeOnInstance;

		// Token: 0x04003B54 RID: 15188
		internal static byte __PropertyMask_bOverrideWalkableSlopeOnInstance;

		// Token: 0x04003B55 RID: 15189
		internal static int __PropertyOffset_bInterpolateWhenSubStepping;

		// Token: 0x04003B56 RID: 15190
		internal static byte __PropertyMask_bInterpolateWhenSubStepping;

		// Token: 0x04003B57 RID: 15191
		internal static int __PropertyOffset_CollisionProfileName;

		// Token: 0x04003B58 RID: 15192
		internal static int __PropertyOffset_PositionSolverIterationCount;

		// Token: 0x04003B59 RID: 15193
		internal static int __PropertyOffset_VelocitySolverIterationCount;

		// Token: 0x04003B5A RID: 15194
		internal static int __PropertyOffset_CollisionResponses;

		// Token: 0x04003B5B RID: 15195
		[Nullable(2)]
		private FCollisionResponse _CollisionResponses;

		// Token: 0x04003B5C RID: 15196
		internal static int __PropertyOffset_MaxDepenetrationVelocity;

		// Token: 0x04003B5D RID: 15197
		internal static int __PropertyOffset_MassInKgOverride;

		// Token: 0x04003B5E RID: 15198
		internal static int __PropertyOffset_LinearDamping;

		// Token: 0x04003B5F RID: 15199
		internal static int __PropertyOffset_AngularDamping;

		// Token: 0x04003B60 RID: 15200
		internal static int __PropertyOffset_CustomDOFPlaneNormal;

		// Token: 0x04003B61 RID: 15201
		internal static int __PropertyOffset_COMNudge;

		// Token: 0x04003B62 RID: 15202
		internal static int __PropertyOffset_MassScale;

		// Token: 0x04003B63 RID: 15203
		internal static int __PropertyOffset_InertiaTensorScale;

		// Token: 0x04003B64 RID: 15204
		internal static int __PropertyOffset_WalkableSlopeOverride;

		// Token: 0x04003B65 RID: 15205
		[Nullable(2)]
		private FWalkableSlopeOverride _WalkableSlopeOverride;

		// Token: 0x04003B66 RID: 15206
		internal static int __PropertyOffset_PhysMaterialOverride;

		// Token: 0x04003B67 RID: 15207
		internal static int __PropertyOffset_ComplexPhysMaterialOverride;

		// Token: 0x04003B68 RID: 15208
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UPhysicalMaterial> _ComplexPhysMaterialOverride;

		// Token: 0x04003B69 RID: 15209
		internal static int __PropertyOffset_MaxAngularVelocity;

		// Token: 0x04003B6A RID: 15210
		internal static int __PropertyOffset_CustomSleepThresholdMultiplier;

		// Token: 0x04003B6B RID: 15211
		internal static int __PropertyOffset_StabilizationThresholdMultiplier;

		// Token: 0x04003B6C RID: 15212
		internal static int __PropertyOffset_PhysicsBlendWeight;
	}
}
