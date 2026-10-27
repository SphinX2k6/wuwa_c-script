using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017EC RID: 6124
	[UnrealObjectPath("/Script/KuroCrowdAi.KuroCrowdAiBoidComponent")]
	[UnrealStructLayout(592, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 592)]
	public class UKuroCrowdAiBoidComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060169E6 RID: 92646 RVA: 0x00210032 File Offset: 0x0020E232
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCrowdAiBoidComponent._ClassPtr;
		}

		// Token: 0x060169E7 RID: 92647 RVA: 0x00210040 File Offset: 0x0020E240
		public UKuroCrowdAiBoidComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroCrowdAiBoidComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060169E8 RID: 92648 RVA: 0x00210068 File Offset: 0x0020E268
		[NullableContext(1)]
		public UKuroCrowdAiBoidComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCrowdAiBoidComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005B6C RID: 23404
		// (get) Token: 0x060169E9 RID: 92649 RVA: 0x0021009B File Offset: 0x0020E29B
		// (set) Token: 0x060169EA RID: 92650 RVA: 0x002100AF File Offset: 0x0020E2AF
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

		// Token: 0x17005B6D RID: 23405
		// (get) Token: 0x060169EB RID: 92651 RVA: 0x002100C4 File Offset: 0x0020E2C4
		// (set) Token: 0x060169EC RID: 92652 RVA: 0x002100D4 File Offset: 0x0020E2D4
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

		// Token: 0x17005B6E RID: 23406
		// (get) Token: 0x060169ED RID: 92653 RVA: 0x002100E5 File Offset: 0x0020E2E5
		// (set) Token: 0x060169EE RID: 92654 RVA: 0x002100F5 File Offset: 0x0020E2F5
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

		// Token: 0x17005B6F RID: 23407
		// (get) Token: 0x060169EF RID: 92655 RVA: 0x00210106 File Offset: 0x0020E306
		// (set) Token: 0x060169F0 RID: 92656 RVA: 0x00210116 File Offset: 0x0020E316
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

		// Token: 0x17005B70 RID: 23408
		// (get) Token: 0x060169F1 RID: 92657 RVA: 0x00210127 File Offset: 0x0020E327
		// (set) Token: 0x060169F2 RID: 92658 RVA: 0x0021013B File Offset: 0x0020E33B
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

		// Token: 0x17005B71 RID: 23409
		// (get) Token: 0x060169F3 RID: 92659 RVA: 0x00210150 File Offset: 0x0020E350
		// (set) Token: 0x060169F4 RID: 92660 RVA: 0x00210164 File Offset: 0x0020E364
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

		// Token: 0x17005B72 RID: 23410
		// (get) Token: 0x060169F5 RID: 92661 RVA: 0x00210179 File Offset: 0x0020E379
		// (set) Token: 0x060169F6 RID: 92662 RVA: 0x0021018D File Offset: 0x0020E38D
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

		// Token: 0x17005B73 RID: 23411
		// (get) Token: 0x060169F7 RID: 92663 RVA: 0x002101A2 File Offset: 0x0020E3A2
		// (set) Token: 0x060169F8 RID: 92664 RVA: 0x002101B6 File Offset: 0x0020E3B6
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

		// Token: 0x17005B74 RID: 23412
		// (get) Token: 0x060169F9 RID: 92665 RVA: 0x002101CB File Offset: 0x0020E3CB
		// (set) Token: 0x060169FA RID: 92666 RVA: 0x002101DF File Offset: 0x0020E3DF
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

		// Token: 0x17005B75 RID: 23413
		// (get) Token: 0x060169FB RID: 92667 RVA: 0x002101F4 File Offset: 0x0020E3F4
		// (set) Token: 0x060169FC RID: 92668 RVA: 0x00210208 File Offset: 0x0020E408
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

		// Token: 0x17005B76 RID: 23414
		// (get) Token: 0x060169FD RID: 92669 RVA: 0x0021021D File Offset: 0x0020E41D
		// (set) Token: 0x060169FE RID: 92670 RVA: 0x00210231 File Offset: 0x0020E431
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

		// Token: 0x17005B77 RID: 23415
		// (get) Token: 0x060169FF RID: 92671 RVA: 0x00210246 File Offset: 0x0020E446
		// (set) Token: 0x06016A00 RID: 92672 RVA: 0x00210256 File Offset: 0x0020E456
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

		// Token: 0x17005B78 RID: 23416
		// (get) Token: 0x06016A01 RID: 92673 RVA: 0x00210267 File Offset: 0x0020E467
		// (set) Token: 0x06016A02 RID: 92674 RVA: 0x00210277 File Offset: 0x0020E477
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

		// Token: 0x17005B79 RID: 23417
		// (get) Token: 0x06016A03 RID: 92675 RVA: 0x00210288 File Offset: 0x0020E488
		// (set) Token: 0x06016A04 RID: 92676 RVA: 0x00210298 File Offset: 0x0020E498
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

		// Token: 0x17005B7A RID: 23418
		// (get) Token: 0x06016A05 RID: 92677 RVA: 0x002102A9 File Offset: 0x0020E4A9
		// (set) Token: 0x06016A06 RID: 92678 RVA: 0x002102B9 File Offset: 0x0020E4B9
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

		// Token: 0x17005B7B RID: 23419
		// (get) Token: 0x06016A07 RID: 92679 RVA: 0x002102CA File Offset: 0x0020E4CA
		// (set) Token: 0x06016A08 RID: 92680 RVA: 0x002102DA File Offset: 0x0020E4DA
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

		// Token: 0x17005B7C RID: 23420
		// (get) Token: 0x06016A09 RID: 92681 RVA: 0x002102EB File Offset: 0x0020E4EB
		// (set) Token: 0x06016A0A RID: 92682 RVA: 0x002102FB File Offset: 0x0020E4FB
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

		// Token: 0x17005B7D RID: 23421
		// (get) Token: 0x06016A0B RID: 92683 RVA: 0x0021030C File Offset: 0x0020E50C
		// (set) Token: 0x06016A0C RID: 92684 RVA: 0x00210320 File Offset: 0x0020E520
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

		// Token: 0x17005B7E RID: 23422
		// (get) Token: 0x06016A0D RID: 92685 RVA: 0x00210335 File Offset: 0x0020E535
		// (set) Token: 0x06016A0E RID: 92686 RVA: 0x00210349 File Offset: 0x0020E549
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

		// Token: 0x17005B7F RID: 23423
		// (get) Token: 0x06016A0F RID: 92687 RVA: 0x0021035E File Offset: 0x0020E55E
		// (set) Token: 0x06016A10 RID: 92688 RVA: 0x0021036E File Offset: 0x0020E56E
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

		// Token: 0x17005B80 RID: 23424
		// (get) Token: 0x06016A11 RID: 92689 RVA: 0x0021037F File Offset: 0x0020E57F
		// (set) Token: 0x06016A12 RID: 92690 RVA: 0x0021038F File Offset: 0x0020E58F
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

		// Token: 0x17005B81 RID: 23425
		// (get) Token: 0x06016A13 RID: 92691 RVA: 0x002103A0 File Offset: 0x0020E5A0
		// (set) Token: 0x06016A14 RID: 92692 RVA: 0x002103B0 File Offset: 0x0020E5B0
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

		// Token: 0x17005B82 RID: 23426
		// (get) Token: 0x06016A15 RID: 92693 RVA: 0x002103C1 File Offset: 0x0020E5C1
		// (set) Token: 0x06016A16 RID: 92694 RVA: 0x002103D1 File Offset: 0x0020E5D1
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

		// Token: 0x17005B83 RID: 23427
		// (get) Token: 0x06016A17 RID: 92695 RVA: 0x002103E2 File Offset: 0x0020E5E2
		// (set) Token: 0x06016A18 RID: 92696 RVA: 0x002103F2 File Offset: 0x0020E5F2
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

		// Token: 0x17005B84 RID: 23428
		// (get) Token: 0x06016A19 RID: 92697 RVA: 0x00210403 File Offset: 0x0020E603
		// (set) Token: 0x06016A1A RID: 92698 RVA: 0x00210413 File Offset: 0x0020E613
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

		// Token: 0x17005B85 RID: 23429
		// (get) Token: 0x06016A1B RID: 92699 RVA: 0x00210424 File Offset: 0x0020E624
		// (set) Token: 0x06016A1C RID: 92700 RVA: 0x00210434 File Offset: 0x0020E634
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

		// Token: 0x17005B86 RID: 23430
		// (get) Token: 0x06016A1D RID: 92701 RVA: 0x00210445 File Offset: 0x0020E645
		// (set) Token: 0x06016A1E RID: 92702 RVA: 0x00210455 File Offset: 0x0020E655
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

		// Token: 0x17005B87 RID: 23431
		// (get) Token: 0x06016A1F RID: 92703 RVA: 0x00210466 File Offset: 0x0020E666
		// (set) Token: 0x06016A20 RID: 92704 RVA: 0x0021047A File Offset: 0x0020E67A
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

		// Token: 0x06016A21 RID: 92705 RVA: 0x0021048F File Offset: 0x0020E68F
		public void InitializeShapeBoids()
		{
			UKuroCrowdAiBoidComponent.__InitializeShapeBoids_Internal(base.NativePtr);
		}

		// Token: 0x06016A22 RID: 92706 RVA: 0x0021049C File Offset: 0x0020E69C
		public void EnableBoidCollision(bool bEnable)
		{
			UKuroCrowdAiBoidComponent.__EnableBoidCollision_Internal(base.NativePtr, bEnable);
		}

		// Token: 0x06016A23 RID: 92707
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitializeShapeBoids_Internal(IntPtr @this);

		// Token: 0x06016A24 RID: 92708
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EnableBoidCollision_Internal(IntPtr @this, bool bEnable);

		// Token: 0x06016A25 RID: 92709 RVA: 0x002104AA File Offset: 0x0020E6AA
		static UKuroCrowdAiBoidComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroCrowdAi.KuroCrowdAiBoidComponent");
		}

		// Token: 0x06016A26 RID: 92710 RVA: 0x002104B8 File Offset: 0x0020E6B8
		protected UKuroCrowdAiBoidComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C489 RID: 50313
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroCrowdAi.KuroCrowdAiBoidComponent";

		// Token: 0x0400C48A RID: 50314
		private static IntPtr _ClassPtr;

		// Token: 0x0400C48B RID: 50315
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C48C RID: 50316
		internal static int __PropertyOffset_UpdatedComponent;

		// Token: 0x0400C48D RID: 50317
		internal static int __PropertyOffset_BoidId;

		// Token: 0x0400C48E RID: 50318
		internal static int __PropertyOffset_GroupId;

		// Token: 0x0400C48F RID: 50319
		internal static int __PropertyOffset_WatchingBoidId;

		// Token: 0x0400C490 RID: 50320
		internal static int __PropertyOffset_Transform;

		// Token: 0x0400C491 RID: 50321
		internal static int __PropertyOffset_Velocity;

		// Token: 0x0400C492 RID: 50322
		internal static int __PropertyOffset_Steering;

		// Token: 0x0400C493 RID: 50323
		internal static int __PropertyOffset_Gravity;

		// Token: 0x0400C494 RID: 50324
		internal static int __PropertyOffset_LastTransform;

		// Token: 0x0400C495 RID: 50325
		internal static int __PropertyOffset_LastVelocity;

		// Token: 0x0400C496 RID: 50326
		internal static int __PropertyOffset_LastSteering;

		// Token: 0x0400C497 RID: 50327
		internal static int __PropertyOffset_IsCrowdAiControlled;

		// Token: 0x0400C498 RID: 50328
		internal static int __PropertyOffset_Radius;

		// Token: 0x0400C499 RID: 50329
		internal static int __PropertyOffset_HalfHeight;

		// Token: 0x0400C49A RID: 50330
		internal static int __PropertyOffset_MaxSpeed;

		// Token: 0x0400C49B RID: 50331
		internal static int __PropertyOffset_MaxAccel;

		// Token: 0x0400C49C RID: 50332
		internal static int __PropertyOffset_GroundFriction;

		// Token: 0x0400C49D RID: 50333
		internal static int __PropertyOffset_LocationOffset;

		// Token: 0x0400C49E RID: 50334
		internal static int __PropertyOffset_RotationOffset;

		// Token: 0x0400C49F RID: 50335
		internal static int __PropertyOffset_FleeRadius;

		// Token: 0x0400C4A0 RID: 50336
		internal static int __PropertyOffset_ArrivalRadius;

		// Token: 0x0400C4A1 RID: 50337
		internal static int __PropertyOffset_MinDistToNavEdge;

		// Token: 0x0400C4A2 RID: 50338
		internal static int __PropertyOffset_ExtraQueryOffset;

		// Token: 0x0400C4A3 RID: 50339
		internal static int __PropertyOffset_bStickToGround;

		// Token: 0x0400C4A4 RID: 50340
		internal static int __PropertyOffset_TurnThresholdSpeed;

		// Token: 0x0400C4A5 RID: 50341
		internal static int __PropertyOffset_TurnInterpSpeed;

		// Token: 0x0400C4A6 RID: 50342
		internal static int __PropertyOffset_ExtrusionRadius;

		// Token: 0x0400C4A7 RID: 50343
		internal static int __PropertyOffset_ShapeCollisionTagName;
	}
}
