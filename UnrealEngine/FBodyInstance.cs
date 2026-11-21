using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000193 RID: 403
	[UnrealObjectPath("/Script/Engine.BodyInstance")]
	[UnrealStructLayout(424, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 424)]
	public class FBodyInstance : FBodyInstanceCore, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001AC3 RID: 6851 RVA: 0x00027C4A File Offset: 0x00025E4A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBodyInstance._ScriptStructPtr != 0) ? FBodyInstance._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BodyInstance", ref FBodyInstance._ScriptStructPtr);
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06001AC4 RID: 6852 RVA: 0x00027C6E File Offset: 0x00025E6E
		// (set) Token: 0x06001AC5 RID: 6853 RVA: 0x00027C82 File Offset: 0x00025E82
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

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06001AC6 RID: 6854 RVA: 0x00027C97 File Offset: 0x00025E97
		// (set) Token: 0x06001AC7 RID: 6855 RVA: 0x00027CAB File Offset: 0x00025EAB
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

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06001AC8 RID: 6856 RVA: 0x00027CC0 File Offset: 0x00025EC0
		// (set) Token: 0x06001AC9 RID: 6857 RVA: 0x00027CD4 File Offset: 0x00025ED4
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

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06001ACA RID: 6858 RVA: 0x00027CE9 File Offset: 0x00025EE9
		// (set) Token: 0x06001ACB RID: 6859 RVA: 0x00027D02 File Offset: 0x00025F02
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

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06001ACC RID: 6860 RVA: 0x00027D32 File Offset: 0x00025F32
		// (set) Token: 0x06001ACD RID: 6861 RVA: 0x00027D4B File Offset: 0x00025F4B
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

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06001ACE RID: 6862 RVA: 0x00027D7B File Offset: 0x00025F7B
		// (set) Token: 0x06001ACF RID: 6863 RVA: 0x00027D94 File Offset: 0x00025F94
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

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06001AD0 RID: 6864 RVA: 0x00027DC4 File Offset: 0x00025FC4
		// (set) Token: 0x06001AD1 RID: 6865 RVA: 0x00027DDD File Offset: 0x00025FDD
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

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06001AD2 RID: 6866 RVA: 0x00027E0D File Offset: 0x0002600D
		// (set) Token: 0x06001AD3 RID: 6867 RVA: 0x00027E26 File Offset: 0x00026026
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

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06001AD4 RID: 6868 RVA: 0x00027E56 File Offset: 0x00026056
		// (set) Token: 0x06001AD5 RID: 6869 RVA: 0x00027E6F File Offset: 0x0002606F
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

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06001AD6 RID: 6870 RVA: 0x00027E9F File Offset: 0x0002609F
		// (set) Token: 0x06001AD7 RID: 6871 RVA: 0x00027EB8 File Offset: 0x000260B8
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

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06001AD8 RID: 6872 RVA: 0x00027EE8 File Offset: 0x000260E8
		// (set) Token: 0x06001AD9 RID: 6873 RVA: 0x00027F01 File Offset: 0x00026101
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

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06001ADA RID: 6874 RVA: 0x00027F31 File Offset: 0x00026131
		// (set) Token: 0x06001ADB RID: 6875 RVA: 0x00027F4A File Offset: 0x0002614A
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

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06001ADC RID: 6876 RVA: 0x00027F7A File Offset: 0x0002617A
		// (set) Token: 0x06001ADD RID: 6877 RVA: 0x00027F93 File Offset: 0x00026193
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

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06001ADE RID: 6878 RVA: 0x00027FC3 File Offset: 0x000261C3
		// (set) Token: 0x06001ADF RID: 6879 RVA: 0x00027FDC File Offset: 0x000261DC
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

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06001AE0 RID: 6880 RVA: 0x0002800C File Offset: 0x0002620C
		// (set) Token: 0x06001AE1 RID: 6881 RVA: 0x00028025 File Offset: 0x00026225
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

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06001AE2 RID: 6882 RVA: 0x00028055 File Offset: 0x00026255
		// (set) Token: 0x06001AE3 RID: 6883 RVA: 0x0002806E File Offset: 0x0002626E
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

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06001AE4 RID: 6884 RVA: 0x0002809E File Offset: 0x0002629E
		// (set) Token: 0x06001AE5 RID: 6885 RVA: 0x000280B7 File Offset: 0x000262B7
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

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06001AE6 RID: 6886 RVA: 0x000280E7 File Offset: 0x000262E7
		// (set) Token: 0x06001AE7 RID: 6887 RVA: 0x00028100 File Offset: 0x00026300
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

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06001AE8 RID: 6888 RVA: 0x00028130 File Offset: 0x00026330
		// (set) Token: 0x06001AE9 RID: 6889 RVA: 0x00028144 File Offset: 0x00026344
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

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06001AEA RID: 6890 RVA: 0x00028159 File Offset: 0x00026359
		// (set) Token: 0x06001AEB RID: 6891 RVA: 0x00028169 File Offset: 0x00026369
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

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06001AEC RID: 6892 RVA: 0x0002817A File Offset: 0x0002637A
		// (set) Token: 0x06001AED RID: 6893 RVA: 0x0002818A File Offset: 0x0002638A
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

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06001AEE RID: 6894 RVA: 0x0002819C File Offset: 0x0002639C
		// (set) Token: 0x06001AEF RID: 6895 RVA: 0x000281DF File Offset: 0x000263DF
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

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06001AF0 RID: 6896 RVA: 0x00028200 File Offset: 0x00026400
		// (set) Token: 0x06001AF1 RID: 6897 RVA: 0x00028210 File Offset: 0x00026410
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

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06001AF2 RID: 6898 RVA: 0x00028221 File Offset: 0x00026421
		// (set) Token: 0x06001AF3 RID: 6899 RVA: 0x00028231 File Offset: 0x00026431
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

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06001AF4 RID: 6900 RVA: 0x00028242 File Offset: 0x00026442
		// (set) Token: 0x06001AF5 RID: 6901 RVA: 0x00028252 File Offset: 0x00026452
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

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06001AF6 RID: 6902 RVA: 0x00028263 File Offset: 0x00026463
		// (set) Token: 0x06001AF7 RID: 6903 RVA: 0x00028273 File Offset: 0x00026473
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

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06001AF8 RID: 6904 RVA: 0x00028284 File Offset: 0x00026484
		// (set) Token: 0x06001AF9 RID: 6905 RVA: 0x00028298 File Offset: 0x00026498
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

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06001AFA RID: 6906 RVA: 0x000282AD File Offset: 0x000264AD
		// (set) Token: 0x06001AFB RID: 6907 RVA: 0x000282C1 File Offset: 0x000264C1
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

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06001AFC RID: 6908 RVA: 0x000282D6 File Offset: 0x000264D6
		// (set) Token: 0x06001AFD RID: 6909 RVA: 0x000282E6 File Offset: 0x000264E6
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

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06001AFE RID: 6910 RVA: 0x000282F7 File Offset: 0x000264F7
		// (set) Token: 0x06001AFF RID: 6911 RVA: 0x0002830B File Offset: 0x0002650B
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

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06001B00 RID: 6912 RVA: 0x00028320 File Offset: 0x00026520
		// (set) Token: 0x06001B01 RID: 6913 RVA: 0x00028334 File Offset: 0x00026534
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

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06001B02 RID: 6914 RVA: 0x0002834C File Offset: 0x0002654C
		// (set) Token: 0x06001B03 RID: 6915 RVA: 0x0002838F File Offset: 0x0002658F
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

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06001B04 RID: 6916 RVA: 0x0002839D File Offset: 0x0002659D
		// (set) Token: 0x06001B05 RID: 6917 RVA: 0x000283AD File Offset: 0x000265AD
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

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06001B06 RID: 6918 RVA: 0x000283BE File Offset: 0x000265BE
		// (set) Token: 0x06001B07 RID: 6919 RVA: 0x000283CE File Offset: 0x000265CE
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

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06001B08 RID: 6920 RVA: 0x000283DF File Offset: 0x000265DF
		// (set) Token: 0x06001B09 RID: 6921 RVA: 0x000283EF File Offset: 0x000265EF
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

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06001B0A RID: 6922 RVA: 0x00028400 File Offset: 0x00026600
		// (set) Token: 0x06001B0B RID: 6923 RVA: 0x00028410 File Offset: 0x00026610
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

		// Token: 0x06001B0C RID: 6924 RVA: 0x00028421 File Offset: 0x00026621
		public FBodyInstance()
		{
		}

		// Token: 0x06001B0D RID: 6925 RVA: 0x00028429 File Offset: 0x00026629
		protected override IntPtr GetUStructPtr()
		{
			return FBodyInstance.StaticStruct();
		}

		// Token: 0x06001B0E RID: 6926 RVA: 0x00028435 File Offset: 0x00026635
		[NullableContext(2)]
		public FBodyInstance(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001B0F RID: 6927 RVA: 0x0002843F File Offset: 0x0002663F
		public FBodyInstance(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001B10 RID: 6928 RVA: 0x0002844A File Offset: 0x0002664A
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBodyInstance(Pointer, false, true);
		}

		// Token: 0x06001B11 RID: 6929 RVA: 0x00028454 File Offset: 0x00026654
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBodyInstance(Pointer, MemoryOwner);
		}

		// Token: 0x04000872 RID: 2162
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.BodyInstance";

		// Token: 0x04000873 RID: 2163
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000874 RID: 2164
		internal static int __PropertyOffset_ObjectType;

		// Token: 0x04000875 RID: 2165
		internal static int __PropertyOffset_CollisionEnabled;

		// Token: 0x04000876 RID: 2166
		internal static int __PropertyOffset_DOFMode;

		// Token: 0x04000877 RID: 2167
		internal static int __PropertyOffset_bUseCCD;

		// Token: 0x04000878 RID: 2168
		internal static byte __PropertyMask_bUseCCD;

		// Token: 0x04000879 RID: 2169
		internal static int __PropertyOffset_bIgnoreAnalyticCollisions;

		// Token: 0x0400087A RID: 2170
		internal static byte __PropertyMask_bIgnoreAnalyticCollisions;

		// Token: 0x0400087B RID: 2171
		internal static int __PropertyOffset_bNotifyRigidBodyCollision;

		// Token: 0x0400087C RID: 2172
		internal static byte __PropertyMask_bNotifyRigidBodyCollision;

		// Token: 0x0400087D RID: 2173
		internal static int __PropertyOffset_bLockTranslation;

		// Token: 0x0400087E RID: 2174
		internal static byte __PropertyMask_bLockTranslation;

		// Token: 0x0400087F RID: 2175
		internal static int __PropertyOffset_bLockRotation;

		// Token: 0x04000880 RID: 2176
		internal static byte __PropertyMask_bLockRotation;

		// Token: 0x04000881 RID: 2177
		internal static int __PropertyOffset_bLockXTranslation;

		// Token: 0x04000882 RID: 2178
		internal static byte __PropertyMask_bLockXTranslation;

		// Token: 0x04000883 RID: 2179
		internal static int __PropertyOffset_bLockYTranslation;

		// Token: 0x04000884 RID: 2180
		internal static byte __PropertyMask_bLockYTranslation;

		// Token: 0x04000885 RID: 2181
		internal static int __PropertyOffset_bLockZTranslation;

		// Token: 0x04000886 RID: 2182
		internal static byte __PropertyMask_bLockZTranslation;

		// Token: 0x04000887 RID: 2183
		internal static int __PropertyOffset_bLockXRotation;

		// Token: 0x04000888 RID: 2184
		internal static byte __PropertyMask_bLockXRotation;

		// Token: 0x04000889 RID: 2185
		internal static int __PropertyOffset_bLockYRotation;

		// Token: 0x0400088A RID: 2186
		internal static byte __PropertyMask_bLockYRotation;

		// Token: 0x0400088B RID: 2187
		internal static int __PropertyOffset_bLockZRotation;

		// Token: 0x0400088C RID: 2188
		internal static byte __PropertyMask_bLockZRotation;

		// Token: 0x0400088D RID: 2189
		internal static int __PropertyOffset_bOverrideMaxAngularVelocity;

		// Token: 0x0400088E RID: 2190
		internal static byte __PropertyMask_bOverrideMaxAngularVelocity;

		// Token: 0x0400088F RID: 2191
		internal static int __PropertyOffset_bOverrideMaxDepenetrationVelocity;

		// Token: 0x04000890 RID: 2192
		internal static byte __PropertyMask_bOverrideMaxDepenetrationVelocity;

		// Token: 0x04000891 RID: 2193
		internal static int __PropertyOffset_bOverrideWalkableSlopeOnInstance;

		// Token: 0x04000892 RID: 2194
		internal static byte __PropertyMask_bOverrideWalkableSlopeOnInstance;

		// Token: 0x04000893 RID: 2195
		internal static int __PropertyOffset_bInterpolateWhenSubStepping;

		// Token: 0x04000894 RID: 2196
		internal static byte __PropertyMask_bInterpolateWhenSubStepping;

		// Token: 0x04000895 RID: 2197
		internal static int __PropertyOffset_CollisionProfileName;

		// Token: 0x04000896 RID: 2198
		internal static int __PropertyOffset_PositionSolverIterationCount;

		// Token: 0x04000897 RID: 2199
		internal static int __PropertyOffset_VelocitySolverIterationCount;

		// Token: 0x04000898 RID: 2200
		internal static int __PropertyOffset_CollisionResponses;

		// Token: 0x04000899 RID: 2201
		[Nullable(2)]
		private FCollisionResponse _CollisionResponses;

		// Token: 0x0400089A RID: 2202
		internal static int __PropertyOffset_MaxDepenetrationVelocity;

		// Token: 0x0400089B RID: 2203
		internal static int __PropertyOffset_MassInKgOverride;

		// Token: 0x0400089C RID: 2204
		internal static int __PropertyOffset_LinearDamping;

		// Token: 0x0400089D RID: 2205
		internal static int __PropertyOffset_AngularDamping;

		// Token: 0x0400089E RID: 2206
		internal static int __PropertyOffset_CustomDOFPlaneNormal;

		// Token: 0x0400089F RID: 2207
		internal static int __PropertyOffset_COMNudge;

		// Token: 0x040008A0 RID: 2208
		internal static int __PropertyOffset_MassScale;

		// Token: 0x040008A1 RID: 2209
		internal static int __PropertyOffset_InertiaTensorScale;

		// Token: 0x040008A2 RID: 2210
		internal static int __PropertyOffset_PhysMaterialOverride;

		// Token: 0x040008A3 RID: 2211
		internal static int __PropertyOffset_ComplexPhysMaterialOverride;

		// Token: 0x040008A4 RID: 2212
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UPhysicalMaterial> _ComplexPhysMaterialOverride;

		// Token: 0x040008A5 RID: 2213
		internal static int __PropertyOffset_MaxAngularVelocity;

		// Token: 0x040008A6 RID: 2214
		internal static int __PropertyOffset_CustomSleepThresholdMultiplier;

		// Token: 0x040008A7 RID: 2215
		internal static int __PropertyOffset_StabilizationThresholdMultiplier;

		// Token: 0x040008A8 RID: 2216
		internal static int __PropertyOffset_PhysicsBlendWeight;
	}
}
