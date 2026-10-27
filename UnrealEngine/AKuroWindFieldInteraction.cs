using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BE6 RID: 7142
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroWindFieldInteraction")]
	[UnrealStructLayout(1712, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1712)]
	public class AKuroWindFieldInteraction : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B761 RID: 112481 RVA: 0x002870E1 File Offset: 0x002852E1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroWindFieldInteraction._ClassPtr;
		}

		// Token: 0x0601B762 RID: 112482 RVA: 0x002870F0 File Offset: 0x002852F0
		public AKuroWindFieldInteraction() : this(BuiltinUtils.AllocNativeUObject(AKuroWindFieldInteraction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B763 RID: 112483 RVA: 0x00287118 File Offset: 0x00285318
		public AKuroWindFieldInteraction(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroWindFieldInteraction.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006E77 RID: 28279
		// (get) Token: 0x0601B764 RID: 112484 RVA: 0x0028714B File Offset: 0x0028534B
		// (set) Token: 0x0601B765 RID: 112485 RVA: 0x0028715F File Offset: 0x0028535F
		public unsafe FVector WeaponPosition0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_WeaponPosition0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_WeaponPosition0) = value;
			}
		}

		// Token: 0x17006E78 RID: 28280
		// (get) Token: 0x0601B766 RID: 112486 RVA: 0x00287174 File Offset: 0x00285374
		// (set) Token: 0x0601B767 RID: 112487 RVA: 0x00287188 File Offset: 0x00285388
		public unsafe FVector LastWeaponPosition0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_LastWeaponPosition0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_LastWeaponPosition0) = value;
			}
		}

		// Token: 0x17006E79 RID: 28281
		// (get) Token: 0x0601B768 RID: 112488 RVA: 0x0028719D File Offset: 0x0028539D
		// (set) Token: 0x0601B769 RID: 112489 RVA: 0x002871B1 File Offset: 0x002853B1
		public unsafe FVector WeaponVelocity0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_WeaponVelocity0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_WeaponVelocity0) = value;
			}
		}

		// Token: 0x17006E7A RID: 28282
		// (get) Token: 0x0601B76A RID: 112490 RVA: 0x002871C6 File Offset: 0x002853C6
		// (set) Token: 0x0601B76B RID: 112491 RVA: 0x002871D6 File Offset: 0x002853D6
		public unsafe float WeaponSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_WeaponSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_WeaponSpeed) = value;
			}
		}

		// Token: 0x17006E7B RID: 28283
		// (get) Token: 0x0601B76C RID: 112492 RVA: 0x002871E7 File Offset: 0x002853E7
		// (set) Token: 0x0601B76D RID: 112493 RVA: 0x002871F7 File Offset: 0x002853F7
		public unsafe float WeaponRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_WeaponRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_WeaponRadius) = value;
			}
		}

		// Token: 0x17006E7C RID: 28284
		// (get) Token: 0x0601B76E RID: 112494 RVA: 0x00287208 File Offset: 0x00285408
		// (set) Token: 0x0601B76F RID: 112495 RVA: 0x0028721C File Offset: 0x0028541C
		public unsafe FVector WeaponOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_WeaponOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_WeaponOffset) = value;
			}
		}

		// Token: 0x17006E7D RID: 28285
		// (get) Token: 0x0601B770 RID: 112496 RVA: 0x00287231 File Offset: 0x00285431
		// (set) Token: 0x0601B771 RID: 112497 RVA: 0x00287245 File Offset: 0x00285445
		public unsafe FVector WeaponPosition1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_WeaponPosition1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_WeaponPosition1) = value;
			}
		}

		// Token: 0x17006E7E RID: 28286
		// (get) Token: 0x0601B772 RID: 112498 RVA: 0x0028725A File Offset: 0x0028545A
		// (set) Token: 0x0601B773 RID: 112499 RVA: 0x0028726E File Offset: 0x0028546E
		public unsafe FVector LastWeaponPosition1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_LastWeaponPosition1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_LastWeaponPosition1) = value;
			}
		}

		// Token: 0x17006E7F RID: 28287
		// (get) Token: 0x0601B774 RID: 112500 RVA: 0x00287283 File Offset: 0x00285483
		// (set) Token: 0x0601B775 RID: 112501 RVA: 0x00287297 File Offset: 0x00285497
		public unsafe FVector WeaponVelocity1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_WeaponVelocity1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_WeaponVelocity1) = value;
			}
		}

		// Token: 0x17006E80 RID: 28288
		// (get) Token: 0x0601B776 RID: 112502 RVA: 0x002872AC File Offset: 0x002854AC
		// (set) Token: 0x0601B777 RID: 112503 RVA: 0x002872C0 File Offset: 0x002854C0
		public unsafe FVector WeaponPosition2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_WeaponPosition2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_WeaponPosition2) = value;
			}
		}

		// Token: 0x17006E81 RID: 28289
		// (get) Token: 0x0601B778 RID: 112504 RVA: 0x002872D5 File Offset: 0x002854D5
		// (set) Token: 0x0601B779 RID: 112505 RVA: 0x002872E9 File Offset: 0x002854E9
		public unsafe FVector LastWeaponPosition2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_LastWeaponPosition2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_LastWeaponPosition2) = value;
			}
		}

		// Token: 0x17006E82 RID: 28290
		// (get) Token: 0x0601B77A RID: 112506 RVA: 0x002872FE File Offset: 0x002854FE
		// (set) Token: 0x0601B77B RID: 112507 RVA: 0x00287312 File Offset: 0x00285512
		public unsafe FVector WeaponVelocity2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_WeaponVelocity2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_WeaponVelocity2) = value;
			}
		}

		// Token: 0x17006E83 RID: 28291
		// (get) Token: 0x0601B77C RID: 112508 RVA: 0x00287327 File Offset: 0x00285527
		// (set) Token: 0x0601B77D RID: 112509 RVA: 0x0028733B File Offset: 0x0028553B
		public unsafe FVector WeaponPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_WeaponPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_WeaponPosition) = value;
			}
		}

		// Token: 0x17006E84 RID: 28292
		// (get) Token: 0x0601B77E RID: 112510 RVA: 0x00287350 File Offset: 0x00285550
		// (set) Token: 0x0601B77F RID: 112511 RVA: 0x00287364 File Offset: 0x00285564
		public unsafe FVector FieldPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_FieldPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_FieldPosition) = value;
			}
		}

		// Token: 0x17006E85 RID: 28293
		// (get) Token: 0x0601B780 RID: 112512 RVA: 0x00287379 File Offset: 0x00285579
		// (set) Token: 0x0601B781 RID: 112513 RVA: 0x0028738D File Offset: 0x0028558D
		public unsafe FVector FieldLastPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_FieldLastPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_FieldLastPosition) = value;
			}
		}

		// Token: 0x17006E86 RID: 28294
		// (get) Token: 0x0601B782 RID: 112514 RVA: 0x002873A2 File Offset: 0x002855A2
		// (set) Token: 0x0601B783 RID: 112515 RVA: 0x002873B2 File Offset: 0x002855B2
		public unsafe float ForceFieldRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_ForceFieldRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_ForceFieldRadius) = value;
			}
		}

		// Token: 0x17006E87 RID: 28295
		// (get) Token: 0x0601B784 RID: 112516 RVA: 0x002873C3 File Offset: 0x002855C3
		// (set) Token: 0x0601B785 RID: 112517 RVA: 0x002873D3 File Offset: 0x002855D3
		public unsafe float RotationalForceField
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_RotationalForceField);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_RotationalForceField) = value;
			}
		}

		// Token: 0x17006E88 RID: 28296
		// (get) Token: 0x0601B786 RID: 112518 RVA: 0x002873E4 File Offset: 0x002855E4
		// (set) Token: 0x0601B787 RID: 112519 RVA: 0x002873F4 File Offset: 0x002855F4
		public unsafe float CentripetalForceField
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_CentripetalForceField);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_CentripetalForceField) = value;
			}
		}

		// Token: 0x17006E89 RID: 28297
		// (get) Token: 0x0601B788 RID: 112520 RVA: 0x00287405 File Offset: 0x00285605
		// (set) Token: 0x0601B789 RID: 112521 RVA: 0x00287419 File Offset: 0x00285619
		public unsafe FVector DirectionalForceField
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_DirectionalForceField);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_DirectionalForceField) = value;
			}
		}

		// Token: 0x17006E8A RID: 28298
		// (get) Token: 0x0601B78A RID: 112522 RVA: 0x0028742E File Offset: 0x0028562E
		// (set) Token: 0x0601B78B RID: 112523 RVA: 0x00287442 File Offset: 0x00285642
		public unsafe FVector FieldVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_FieldVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_FieldVelocity) = value;
			}
		}

		// Token: 0x17006E8B RID: 28299
		// (get) Token: 0x0601B78C RID: 112524 RVA: 0x00287457 File Offset: 0x00285657
		// (set) Token: 0x0601B78D RID: 112525 RVA: 0x00287467 File Offset: 0x00285667
		public unsafe float FieldSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_FieldSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_FieldSpeed) = value;
			}
		}

		// Token: 0x17006E8C RID: 28300
		// (get) Token: 0x0601B78E RID: 112526 RVA: 0x00287478 File Offset: 0x00285678
		// (set) Token: 0x0601B78F RID: 112527 RVA: 0x0028748C File Offset: 0x0028568C
		public unsafe string GrassFadingSpeedName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)AKuroWindFieldInteraction.__PropertyOffset_GrassFadingSpeedName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)AKuroWindFieldInteraction.__PropertyOffset_GrassFadingSpeedName)), value);
			}
		}

		// Token: 0x17006E8D RID: 28301
		// (get) Token: 0x0601B790 RID: 112528 RVA: 0x002874A1 File Offset: 0x002856A1
		// (set) Token: 0x0601B791 RID: 112529 RVA: 0x002874B1 File Offset: 0x002856B1
		public unsafe float PlayerGrassFadingSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_PlayerGrassFadingSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_PlayerGrassFadingSpeed) = value;
			}
		}

		// Token: 0x17006E8E RID: 28302
		// (get) Token: 0x0601B792 RID: 112530 RVA: 0x002874C2 File Offset: 0x002856C2
		// (set) Token: 0x0601B793 RID: 112531 RVA: 0x002874D2 File Offset: 0x002856D2
		public unsafe float MotoGrassFadingSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_MotoGrassFadingSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_MotoGrassFadingSpeed) = value;
			}
		}

		// Token: 0x17006E8F RID: 28303
		// (get) Token: 0x0601B794 RID: 112532 RVA: 0x002874E3 File Offset: 0x002856E3
		// (set) Token: 0x0601B795 RID: 112533 RVA: 0x002874F7 File Offset: 0x002856F7
		public unsafe FVector FieldSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_FieldSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_FieldSize) = value;
			}
		}

		// Token: 0x17006E90 RID: 28304
		// (get) Token: 0x0601B796 RID: 112534 RVA: 0x0028750C File Offset: 0x0028570C
		// (set) Token: 0x0601B797 RID: 112535 RVA: 0x0028751C File Offset: 0x0028571C
		public unsafe int Resolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_Resolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_Resolution) = value;
			}
		}

		// Token: 0x17006E91 RID: 28305
		// (get) Token: 0x0601B798 RID: 112536 RVA: 0x0028752D File Offset: 0x0028572D
		// (set) Token: 0x0601B799 RID: 112537 RVA: 0x00287541 File Offset: 0x00285741
		public unsafe FVector Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_Offset) = value;
			}
		}

		// Token: 0x17006E92 RID: 28306
		// (get) Token: 0x0601B79A RID: 112538 RVA: 0x00287556 File Offset: 0x00285756
		// (set) Token: 0x0601B79B RID: 112539 RVA: 0x00287566 File Offset: 0x00285766
		public unsafe bool isClear
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_isClear) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_isClear) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006E93 RID: 28307
		// (get) Token: 0x0601B79C RID: 112540 RVA: 0x00287577 File Offset: 0x00285777
		// (set) Token: 0x0601B79D RID: 112541 RVA: 0x00287587 File Offset: 0x00285787
		public unsafe float PlayerSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_PlayerSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_PlayerSpeed) = value;
			}
		}

		// Token: 0x17006E94 RID: 28308
		// (get) Token: 0x0601B79E RID: 112542 RVA: 0x00287598 File Offset: 0x00285798
		// (set) Token: 0x0601B79F RID: 112543 RVA: 0x002875A8 File Offset: 0x002857A8
		public unsafe float NoiseForceField
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_NoiseForceField);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_NoiseForceField) = value;
			}
		}

		// Token: 0x17006E95 RID: 28309
		// (get) Token: 0x0601B7A0 RID: 112544 RVA: 0x002875B9 File Offset: 0x002857B9
		// (set) Token: 0x0601B7A1 RID: 112545 RVA: 0x002875C9 File Offset: 0x002857C9
		public unsafe float SampleIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_SampleIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_SampleIntensity) = value;
			}
		}

		// Token: 0x17006E96 RID: 28310
		// (get) Token: 0x0601B7A2 RID: 112546 RVA: 0x002875DA File Offset: 0x002857DA
		// (set) Token: 0x0601B7A3 RID: 112547 RVA: 0x002875EA File Offset: 0x002857EA
		public unsafe float dt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_dt);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWindFieldInteraction.__PropertyOffset_dt) = value;
			}
		}

		// Token: 0x0601B7A4 RID: 112548 RVA: 0x002875FB File Offset: 0x002857FB
		public void UpdateWeaponParameters()
		{
			AKuroWindFieldInteraction.__UpdateWeaponParameters_Internal(base.NativePtr);
		}

		// Token: 0x0601B7A5 RID: 112549 RVA: 0x00287608 File Offset: 0x00285808
		[NullableContext(2)]
		public void UpdateParameters(float DeltaTime, UNiagaraComponent NS_WindField, UNiagaraParameterCollection NPC_LeavesInteraction, FGameplayTag GlideState, FGameplayTag MotorcycleState, UMaterialParameterCollection MPC_SceneInteraction)
		{
			AKuroWindFieldInteraction.__UpdateParameters_Internal(base.NativePtr, DeltaTime, (NS_WindField != null) ? NS_WindField.NativePtr : IntPtr.Zero, (NPC_LeavesInteraction != null) ? NPC_LeavesInteraction.NativePtr : IntPtr.Zero, GlideState, MotorcycleState, (MPC_SceneInteraction != null) ? MPC_SceneInteraction.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601B7A6 RID: 112550
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateWeaponParameters_Internal(IntPtr @this);

		// Token: 0x0601B7A7 RID: 112551
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateParameters_Internal(IntPtr @this, float DeltaTime, IntPtr NS_WindField, IntPtr NPC_LeavesInteraction, FGameplayTag GlideState, FGameplayTag MotorcycleState, IntPtr MPC_SceneInteraction);

		// Token: 0x0601B7A8 RID: 112552 RVA: 0x00287657 File Offset: 0x00285857
		static AKuroWindFieldInteraction()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroWindFieldInteraction");
		}

		// Token: 0x0601B7A9 RID: 112553 RVA: 0x00287665 File Offset: 0x00285865
		protected AKuroWindFieldInteraction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EC6C RID: 60524
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroWindFieldInteraction";

		// Token: 0x0400EC6D RID: 60525
		private static IntPtr _ClassPtr;

		// Token: 0x0400EC6E RID: 60526
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EC6F RID: 60527
		internal static int __PropertyOffset_WeaponPosition0;

		// Token: 0x0400EC70 RID: 60528
		internal static int __PropertyOffset_LastWeaponPosition0;

		// Token: 0x0400EC71 RID: 60529
		internal static int __PropertyOffset_WeaponVelocity0;

		// Token: 0x0400EC72 RID: 60530
		internal static int __PropertyOffset_WeaponSpeed;

		// Token: 0x0400EC73 RID: 60531
		internal static int __PropertyOffset_WeaponRadius;

		// Token: 0x0400EC74 RID: 60532
		internal static int __PropertyOffset_WeaponOffset;

		// Token: 0x0400EC75 RID: 60533
		internal static int __PropertyOffset_WeaponPosition1;

		// Token: 0x0400EC76 RID: 60534
		internal static int __PropertyOffset_LastWeaponPosition1;

		// Token: 0x0400EC77 RID: 60535
		internal static int __PropertyOffset_WeaponVelocity1;

		// Token: 0x0400EC78 RID: 60536
		internal static int __PropertyOffset_WeaponPosition2;

		// Token: 0x0400EC79 RID: 60537
		internal static int __PropertyOffset_LastWeaponPosition2;

		// Token: 0x0400EC7A RID: 60538
		internal static int __PropertyOffset_WeaponVelocity2;

		// Token: 0x0400EC7B RID: 60539
		internal static int __PropertyOffset_WeaponPosition;

		// Token: 0x0400EC7C RID: 60540
		internal static int __PropertyOffset_FieldPosition;

		// Token: 0x0400EC7D RID: 60541
		internal static int __PropertyOffset_FieldLastPosition;

		// Token: 0x0400EC7E RID: 60542
		internal static int __PropertyOffset_ForceFieldRadius;

		// Token: 0x0400EC7F RID: 60543
		internal static int __PropertyOffset_RotationalForceField;

		// Token: 0x0400EC80 RID: 60544
		internal static int __PropertyOffset_CentripetalForceField;

		// Token: 0x0400EC81 RID: 60545
		internal static int __PropertyOffset_DirectionalForceField;

		// Token: 0x0400EC82 RID: 60546
		internal static int __PropertyOffset_FieldVelocity;

		// Token: 0x0400EC83 RID: 60547
		internal static int __PropertyOffset_FieldSpeed;

		// Token: 0x0400EC84 RID: 60548
		internal static int __PropertyOffset_GrassFadingSpeedName;

		// Token: 0x0400EC85 RID: 60549
		internal static int __PropertyOffset_PlayerGrassFadingSpeed;

		// Token: 0x0400EC86 RID: 60550
		internal static int __PropertyOffset_MotoGrassFadingSpeed;

		// Token: 0x0400EC87 RID: 60551
		internal static int __PropertyOffset_FieldSize;

		// Token: 0x0400EC88 RID: 60552
		internal static int __PropertyOffset_Resolution;

		// Token: 0x0400EC89 RID: 60553
		internal static int __PropertyOffset_Offset;

		// Token: 0x0400EC8A RID: 60554
		internal static int __PropertyOffset_isClear;

		// Token: 0x0400EC8B RID: 60555
		internal static int __PropertyOffset_PlayerSpeed;

		// Token: 0x0400EC8C RID: 60556
		internal static int __PropertyOffset_NoiseForceField;

		// Token: 0x0400EC8D RID: 60557
		internal static int __PropertyOffset_SampleIntensity;

		// Token: 0x0400EC8E RID: 60558
		internal static int __PropertyOffset_dt;
	}
}
