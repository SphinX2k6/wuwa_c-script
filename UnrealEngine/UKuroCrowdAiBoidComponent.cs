using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000359 RID: 857
	[UnrealObjectPath("/Script/KuroCrowdAi.KuroCrowdAiBoidComponent")]
	[UnrealStructLayout(592, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 592)]
	public class UKuroCrowdAiBoidComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600578E RID: 22414 RVA: 0x0007B433 File Offset: 0x00079633
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCrowdAiBoidComponent._ClassPtr;
		}

		// Token: 0x0600578F RID: 22415 RVA: 0x0007B440 File Offset: 0x00079640
		public UKuroCrowdAiBoidComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroCrowdAiBoidComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005790 RID: 22416 RVA: 0x0007B468 File Offset: 0x00079668
		[NullableContext(1)]
		public UKuroCrowdAiBoidComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCrowdAiBoidComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001144 RID: 4420
		// (get) Token: 0x06005791 RID: 22417 RVA: 0x0007B49B File Offset: 0x0007969B
		// (set) Token: 0x06005792 RID: 22418 RVA: 0x0007B4AF File Offset: 0x000796AF
		[Nullable(2)]
		public unsafe USceneComponent UpdatedComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCrowdAiBoidComponent.__PropertyOffset_UpdatedComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCrowdAiBoidComponent.__PropertyOffset_UpdatedComponent, value);
			}
		}

		// Token: 0x17001145 RID: 4421
		// (get) Token: 0x06005793 RID: 22419 RVA: 0x0007B4C4 File Offset: 0x000796C4
		// (set) Token: 0x06005794 RID: 22420 RVA: 0x0007B4D4 File Offset: 0x000796D4
		public unsafe int BoidId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_BoidId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_BoidId) = value;
			}
		}

		// Token: 0x17001146 RID: 4422
		// (get) Token: 0x06005795 RID: 22421 RVA: 0x0007B4E5 File Offset: 0x000796E5
		// (set) Token: 0x06005796 RID: 22422 RVA: 0x0007B4F5 File Offset: 0x000796F5
		public unsafe int GroupId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_GroupId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_GroupId) = value;
			}
		}

		// Token: 0x17001147 RID: 4423
		// (get) Token: 0x06005797 RID: 22423 RVA: 0x0007B506 File Offset: 0x00079706
		// (set) Token: 0x06005798 RID: 22424 RVA: 0x0007B516 File Offset: 0x00079716
		public unsafe int WatchingBoidId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_WatchingBoidId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_WatchingBoidId) = value;
			}
		}

		// Token: 0x17001148 RID: 4424
		// (get) Token: 0x06005799 RID: 22425 RVA: 0x0007B527 File Offset: 0x00079727
		// (set) Token: 0x0600579A RID: 22426 RVA: 0x0007B53B File Offset: 0x0007973B
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x17001149 RID: 4425
		// (get) Token: 0x0600579B RID: 22427 RVA: 0x0007B550 File Offset: 0x00079750
		// (set) Token: 0x0600579C RID: 22428 RVA: 0x0007B564 File Offset: 0x00079764
		public unsafe FVector Velocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_Velocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_Velocity) = value;
			}
		}

		// Token: 0x1700114A RID: 4426
		// (get) Token: 0x0600579D RID: 22429 RVA: 0x0007B579 File Offset: 0x00079779
		// (set) Token: 0x0600579E RID: 22430 RVA: 0x0007B58D File Offset: 0x0007978D
		public unsafe FVector Steering
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_Steering);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_Steering) = value;
			}
		}

		// Token: 0x1700114B RID: 4427
		// (get) Token: 0x0600579F RID: 22431 RVA: 0x0007B5A2 File Offset: 0x000797A2
		// (set) Token: 0x060057A0 RID: 22432 RVA: 0x0007B5B6 File Offset: 0x000797B6
		public unsafe FVector Gravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_Gravity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_Gravity) = value;
			}
		}

		// Token: 0x1700114C RID: 4428
		// (get) Token: 0x060057A1 RID: 22433 RVA: 0x0007B5CB File Offset: 0x000797CB
		// (set) Token: 0x060057A2 RID: 22434 RVA: 0x0007B5DF File Offset: 0x000797DF
		public unsafe FTransform LastTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_LastTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_LastTransform) = value;
			}
		}

		// Token: 0x1700114D RID: 4429
		// (get) Token: 0x060057A3 RID: 22435 RVA: 0x0007B5F4 File Offset: 0x000797F4
		// (set) Token: 0x060057A4 RID: 22436 RVA: 0x0007B608 File Offset: 0x00079808
		public unsafe FVector LastVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_LastVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_LastVelocity) = value;
			}
		}

		// Token: 0x1700114E RID: 4430
		// (get) Token: 0x060057A5 RID: 22437 RVA: 0x0007B61D File Offset: 0x0007981D
		// (set) Token: 0x060057A6 RID: 22438 RVA: 0x0007B631 File Offset: 0x00079831
		public unsafe FVector LastSteering
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_LastSteering);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_LastSteering) = value;
			}
		}

		// Token: 0x1700114F RID: 4431
		// (get) Token: 0x060057A7 RID: 22439 RVA: 0x0007B646 File Offset: 0x00079846
		// (set) Token: 0x060057A8 RID: 22440 RVA: 0x0007B656 File Offset: 0x00079856
		public unsafe bool IsCrowdAiControlled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_IsCrowdAiControlled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_IsCrowdAiControlled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001150 RID: 4432
		// (get) Token: 0x060057A9 RID: 22441 RVA: 0x0007B667 File Offset: 0x00079867
		// (set) Token: 0x060057AA RID: 22442 RVA: 0x0007B677 File Offset: 0x00079877
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x17001151 RID: 4433
		// (get) Token: 0x060057AB RID: 22443 RVA: 0x0007B688 File Offset: 0x00079888
		// (set) Token: 0x060057AC RID: 22444 RVA: 0x0007B698 File Offset: 0x00079898
		public unsafe float HalfHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_HalfHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_HalfHeight) = value;
			}
		}

		// Token: 0x17001152 RID: 4434
		// (get) Token: 0x060057AD RID: 22445 RVA: 0x0007B6A9 File Offset: 0x000798A9
		// (set) Token: 0x060057AE RID: 22446 RVA: 0x0007B6B9 File Offset: 0x000798B9
		public unsafe float MaxSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_MaxSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_MaxSpeed) = value;
			}
		}

		// Token: 0x17001153 RID: 4435
		// (get) Token: 0x060057AF RID: 22447 RVA: 0x0007B6CA File Offset: 0x000798CA
		// (set) Token: 0x060057B0 RID: 22448 RVA: 0x0007B6DA File Offset: 0x000798DA
		public unsafe float MaxAccel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_MaxAccel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_MaxAccel) = value;
			}
		}

		// Token: 0x17001154 RID: 4436
		// (get) Token: 0x060057B1 RID: 22449 RVA: 0x0007B6EB File Offset: 0x000798EB
		// (set) Token: 0x060057B2 RID: 22450 RVA: 0x0007B6FB File Offset: 0x000798FB
		public unsafe float GroundFriction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_GroundFriction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_GroundFriction) = value;
			}
		}

		// Token: 0x17001155 RID: 4437
		// (get) Token: 0x060057B3 RID: 22451 RVA: 0x0007B70C File Offset: 0x0007990C
		// (set) Token: 0x060057B4 RID: 22452 RVA: 0x0007B720 File Offset: 0x00079920
		public unsafe FVector LocationOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_LocationOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_LocationOffset) = value;
			}
		}

		// Token: 0x17001156 RID: 4438
		// (get) Token: 0x060057B5 RID: 22453 RVA: 0x0007B735 File Offset: 0x00079935
		// (set) Token: 0x060057B6 RID: 22454 RVA: 0x0007B749 File Offset: 0x00079949
		public unsafe FRotator RotationOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_RotationOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_RotationOffset) = value;
			}
		}

		// Token: 0x17001157 RID: 4439
		// (get) Token: 0x060057B7 RID: 22455 RVA: 0x0007B75E File Offset: 0x0007995E
		// (set) Token: 0x060057B8 RID: 22456 RVA: 0x0007B76E File Offset: 0x0007996E
		public unsafe float FleeRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_FleeRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_FleeRadius) = value;
			}
		}

		// Token: 0x17001158 RID: 4440
		// (get) Token: 0x060057B9 RID: 22457 RVA: 0x0007B77F File Offset: 0x0007997F
		// (set) Token: 0x060057BA RID: 22458 RVA: 0x0007B78F File Offset: 0x0007998F
		public unsafe float ArrivalRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_ArrivalRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_ArrivalRadius) = value;
			}
		}

		// Token: 0x17001159 RID: 4441
		// (get) Token: 0x060057BB RID: 22459 RVA: 0x0007B7A0 File Offset: 0x000799A0
		// (set) Token: 0x060057BC RID: 22460 RVA: 0x0007B7B0 File Offset: 0x000799B0
		public unsafe float MinDistToNavEdge
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_MinDistToNavEdge);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_MinDistToNavEdge) = value;
			}
		}

		// Token: 0x1700115A RID: 4442
		// (get) Token: 0x060057BD RID: 22461 RVA: 0x0007B7C1 File Offset: 0x000799C1
		// (set) Token: 0x060057BE RID: 22462 RVA: 0x0007B7D1 File Offset: 0x000799D1
		public unsafe float ExtraQueryOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_ExtraQueryOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_ExtraQueryOffset) = value;
			}
		}

		// Token: 0x1700115B RID: 4443
		// (get) Token: 0x060057BF RID: 22463 RVA: 0x0007B7E2 File Offset: 0x000799E2
		// (set) Token: 0x060057C0 RID: 22464 RVA: 0x0007B7F2 File Offset: 0x000799F2
		public unsafe bool bStickToGround
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_bStickToGround) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_bStickToGround) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700115C RID: 4444
		// (get) Token: 0x060057C1 RID: 22465 RVA: 0x0007B803 File Offset: 0x00079A03
		// (set) Token: 0x060057C2 RID: 22466 RVA: 0x0007B813 File Offset: 0x00079A13
		public unsafe float TurnThresholdSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_TurnThresholdSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_TurnThresholdSpeed) = value;
			}
		}

		// Token: 0x1700115D RID: 4445
		// (get) Token: 0x060057C3 RID: 22467 RVA: 0x0007B824 File Offset: 0x00079A24
		// (set) Token: 0x060057C4 RID: 22468 RVA: 0x0007B834 File Offset: 0x00079A34
		public unsafe float TurnInterpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_TurnInterpSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_TurnInterpSpeed) = value;
			}
		}

		// Token: 0x1700115E RID: 4446
		// (get) Token: 0x060057C5 RID: 22469 RVA: 0x0007B845 File Offset: 0x00079A45
		// (set) Token: 0x060057C6 RID: 22470 RVA: 0x0007B855 File Offset: 0x00079A55
		public unsafe float ExtrusionRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_ExtrusionRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_ExtrusionRadius) = value;
			}
		}

		// Token: 0x1700115F RID: 4447
		// (get) Token: 0x060057C7 RID: 22471 RVA: 0x0007B866 File Offset: 0x00079A66
		// (set) Token: 0x060057C8 RID: 22472 RVA: 0x0007B87A File Offset: 0x00079A7A
		public unsafe FName ShapeCollisionTagName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_ShapeCollisionTagName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiBoidComponent.__PropertyOffset_ShapeCollisionTagName) = value;
			}
		}

		// Token: 0x060057C9 RID: 22473 RVA: 0x0007B88F File Offset: 0x00079A8F
		public void InitializeShapeBoids()
		{
			UKuroCrowdAiBoidComponent.__InitializeShapeBoids_Internal(base.NativePtr);
		}

		// Token: 0x060057CA RID: 22474 RVA: 0x0007B89C File Offset: 0x00079A9C
		public void EnableBoidCollision(bool bEnable)
		{
			UKuroCrowdAiBoidComponent.__EnableBoidCollision_Internal(base.NativePtr, bEnable);
		}

		// Token: 0x060057CB RID: 22475
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitializeShapeBoids_Internal(IntPtr @this);

		// Token: 0x060057CC RID: 22476
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EnableBoidCollision_Internal(IntPtr @this, bool bEnable);

		// Token: 0x060057CD RID: 22477 RVA: 0x0007B8AA File Offset: 0x00079AAA
		static UKuroCrowdAiBoidComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroCrowdAi.KuroCrowdAiBoidComponent");
		}

		// Token: 0x060057CE RID: 22478 RVA: 0x0007B8B8 File Offset: 0x00079AB8
		protected UKuroCrowdAiBoidComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002416 RID: 9238
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroCrowdAi.KuroCrowdAiBoidComponent";

		// Token: 0x04002417 RID: 9239
		private static IntPtr _ClassPtr;

		// Token: 0x04002418 RID: 9240
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002419 RID: 9241
		internal static int __PropertyOffset_UpdatedComponent;

		// Token: 0x0400241A RID: 9242
		internal static int __PropertyOffset_BoidId;

		// Token: 0x0400241B RID: 9243
		internal static int __PropertyOffset_GroupId;

		// Token: 0x0400241C RID: 9244
		internal static int __PropertyOffset_WatchingBoidId;

		// Token: 0x0400241D RID: 9245
		internal static int __PropertyOffset_Transform;

		// Token: 0x0400241E RID: 9246
		internal static int __PropertyOffset_Velocity;

		// Token: 0x0400241F RID: 9247
		internal static int __PropertyOffset_Steering;

		// Token: 0x04002420 RID: 9248
		internal static int __PropertyOffset_Gravity;

		// Token: 0x04002421 RID: 9249
		internal static int __PropertyOffset_LastTransform;

		// Token: 0x04002422 RID: 9250
		internal static int __PropertyOffset_LastVelocity;

		// Token: 0x04002423 RID: 9251
		internal static int __PropertyOffset_LastSteering;

		// Token: 0x04002424 RID: 9252
		internal static int __PropertyOffset_IsCrowdAiControlled;

		// Token: 0x04002425 RID: 9253
		internal static int __PropertyOffset_Radius;

		// Token: 0x04002426 RID: 9254
		internal static int __PropertyOffset_HalfHeight;

		// Token: 0x04002427 RID: 9255
		internal static int __PropertyOffset_MaxSpeed;

		// Token: 0x04002428 RID: 9256
		internal static int __PropertyOffset_MaxAccel;

		// Token: 0x04002429 RID: 9257
		internal static int __PropertyOffset_GroundFriction;

		// Token: 0x0400242A RID: 9258
		internal static int __PropertyOffset_LocationOffset;

		// Token: 0x0400242B RID: 9259
		internal static int __PropertyOffset_RotationOffset;

		// Token: 0x0400242C RID: 9260
		internal static int __PropertyOffset_FleeRadius;

		// Token: 0x0400242D RID: 9261
		internal static int __PropertyOffset_ArrivalRadius;

		// Token: 0x0400242E RID: 9262
		internal static int __PropertyOffset_MinDistToNavEdge;

		// Token: 0x0400242F RID: 9263
		internal static int __PropertyOffset_ExtraQueryOffset;

		// Token: 0x04002430 RID: 9264
		internal static int __PropertyOffset_bStickToGround;

		// Token: 0x04002431 RID: 9265
		internal static int __PropertyOffset_TurnThresholdSpeed;

		// Token: 0x04002432 RID: 9266
		internal static int __PropertyOffset_TurnInterpSpeed;

		// Token: 0x04002433 RID: 9267
		internal static int __PropertyOffset_ExtrusionRadius;

		// Token: 0x04002434 RID: 9268
		internal static int __PropertyOffset_ShapeCollisionTagName;
	}
}
