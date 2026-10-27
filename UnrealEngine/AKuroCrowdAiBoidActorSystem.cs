using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017EA RID: 6122
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroCrowdAi.KuroCrowdAiBoidActorSystem")]
	[UnrealStructLayout(2608, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2608)]
	public class AKuroCrowdAiBoidActorSystem : ABakedBoneMeshActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016994 RID: 92564 RVA: 0x0020FA3A File Offset: 0x0020DC3A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroCrowdAiBoidActorSystem._ClassPtr;
		}

		// Token: 0x06016995 RID: 92565 RVA: 0x0020FA48 File Offset: 0x0020DC48
		public AKuroCrowdAiBoidActorSystem() : this(BuiltinUtils.AllocNativeUObject(AKuroCrowdAiBoidActorSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016996 RID: 92566 RVA: 0x0020FA70 File Offset: 0x0020DC70
		public AKuroCrowdAiBoidActorSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroCrowdAiBoidActorSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005B52 RID: 23378
		// (get) Token: 0x06016997 RID: 92567 RVA: 0x0020FAA3 File Offset: 0x0020DCA3
		// (set) Token: 0x06016998 RID: 92568 RVA: 0x0020FAB7 File Offset: 0x0020DCB7
		[Nullable(2)]
		public unsafe UBakedBoneMeshComponent BakedBoneMeshComp
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBakedBoneMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCrowdAiBoidActorSystem.__PropertyOffset_BakedBoneMeshComp);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCrowdAiBoidActorSystem.__PropertyOffset_BakedBoneMeshComp, value);
			}
		}

		// Token: 0x17005B53 RID: 23379
		// (get) Token: 0x06016999 RID: 92569 RVA: 0x0020FACC File Offset: 0x0020DCCC
		// (set) Token: 0x0601699A RID: 92570 RVA: 0x0020FAE0 File Offset: 0x0020DCE0
		[Nullable(2)]
		public unsafe UKuroMaterialControllerComponent MaterialControllerComp
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMaterialControllerComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCrowdAiBoidActorSystem.__PropertyOffset_MaterialControllerComp);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCrowdAiBoidActorSystem.__PropertyOffset_MaterialControllerComp, value);
			}
		}

		// Token: 0x17005B54 RID: 23380
		// (get) Token: 0x0601699B RID: 92571 RVA: 0x0020FAF5 File Offset: 0x0020DCF5
		// (set) Token: 0x0601699C RID: 92572 RVA: 0x0020FB05 File Offset: 0x0020DD05
		public unsafe int MaxBoidCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCrowdAiBoidActorSystem.__PropertyOffset_MaxBoidCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCrowdAiBoidActorSystem.__PropertyOffset_MaxBoidCount) = value;
			}
		}

		// Token: 0x17005B55 RID: 23381
		// (get) Token: 0x0601699D RID: 92573 RVA: 0x0020FB16 File Offset: 0x0020DD16
		// (set) Token: 0x0601699E RID: 92574 RVA: 0x0020FB26 File Offset: 0x0020DD26
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCrowdAiBoidActorSystem.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCrowdAiBoidActorSystem.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x17005B56 RID: 23382
		// (get) Token: 0x0601699F RID: 92575 RVA: 0x0020FB37 File Offset: 0x0020DD37
		// (set) Token: 0x060169A0 RID: 92576 RVA: 0x0020FB47 File Offset: 0x0020DD47
		public unsafe float HalfHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCrowdAiBoidActorSystem.__PropertyOffset_HalfHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCrowdAiBoidActorSystem.__PropertyOffset_HalfHeight) = value;
			}
		}

		// Token: 0x17005B57 RID: 23383
		// (get) Token: 0x060169A1 RID: 92577 RVA: 0x0020FB58 File Offset: 0x0020DD58
		// (set) Token: 0x060169A2 RID: 92578 RVA: 0x0020FB6C File Offset: 0x0020DD6C
		public unsafe FTransform RelativeTrans
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCrowdAiBoidActorSystem.__PropertyOffset_RelativeTrans);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCrowdAiBoidActorSystem.__PropertyOffset_RelativeTrans) = value;
			}
		}

		// Token: 0x17005B58 RID: 23384
		// (get) Token: 0x060169A3 RID: 92579 RVA: 0x0020FB81 File Offset: 0x0020DD81
		// (set) Token: 0x060169A4 RID: 92580 RVA: 0x0020FB91 File Offset: 0x0020DD91
		public unsafe float MaxSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCrowdAiBoidActorSystem.__PropertyOffset_MaxSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCrowdAiBoidActorSystem.__PropertyOffset_MaxSpeed) = value;
			}
		}

		// Token: 0x17005B59 RID: 23385
		// (get) Token: 0x060169A5 RID: 92581 RVA: 0x0020FBA2 File Offset: 0x0020DDA2
		// (set) Token: 0x060169A6 RID: 92582 RVA: 0x0020FBB2 File Offset: 0x0020DDB2
		public unsafe float MaxAccel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCrowdAiBoidActorSystem.__PropertyOffset_MaxAccel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCrowdAiBoidActorSystem.__PropertyOffset_MaxAccel) = value;
			}
		}

		// Token: 0x17005B5A RID: 23386
		// (get) Token: 0x060169A7 RID: 92583 RVA: 0x0020FBC3 File Offset: 0x0020DDC3
		// (set) Token: 0x060169A8 RID: 92584 RVA: 0x0020FBD3 File Offset: 0x0020DDD3
		public unsafe float GroundFriction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCrowdAiBoidActorSystem.__PropertyOffset_GroundFriction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCrowdAiBoidActorSystem.__PropertyOffset_GroundFriction) = value;
			}
		}

		// Token: 0x17005B5B RID: 23387
		// (get) Token: 0x060169A9 RID: 92585 RVA: 0x0020FBE4 File Offset: 0x0020DDE4
		// (set) Token: 0x060169AA RID: 92586 RVA: 0x0020FBF4 File Offset: 0x0020DDF4
		public unsafe float MovingRadiusFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCrowdAiBoidActorSystem.__PropertyOffset_MovingRadiusFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCrowdAiBoidActorSystem.__PropertyOffset_MovingRadiusFactor) = value;
			}
		}

		// Token: 0x17005B5C RID: 23388
		// (get) Token: 0x060169AB RID: 92587 RVA: 0x0020FC05 File Offset: 0x0020DE05
		// (set) Token: 0x060169AC RID: 92588 RVA: 0x0020FC15 File Offset: 0x0020DE15
		public unsafe float WalkMinSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCrowdAiBoidActorSystem.__PropertyOffset_WalkMinSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCrowdAiBoidActorSystem.__PropertyOffset_WalkMinSpeed) = value;
			}
		}

		// Token: 0x17005B5D RID: 23389
		// (get) Token: 0x060169AD RID: 92589 RVA: 0x0020FC26 File Offset: 0x0020DE26
		// (set) Token: 0x060169AE RID: 92590 RVA: 0x0020FC36 File Offset: 0x0020DE36
		public unsafe float IdleMaxSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCrowdAiBoidActorSystem.__PropertyOffset_IdleMaxSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCrowdAiBoidActorSystem.__PropertyOffset_IdleMaxSpeed) = value;
			}
		}

		// Token: 0x17005B5E RID: 23390
		// (get) Token: 0x060169AF RID: 92591 RVA: 0x0020FC47 File Offset: 0x0020DE47
		// (set) Token: 0x060169B0 RID: 92592 RVA: 0x0020FC57 File Offset: 0x0020DE57
		public unsafe float TurnInterpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCrowdAiBoidActorSystem.__PropertyOffset_TurnInterpSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCrowdAiBoidActorSystem.__PropertyOffset_TurnInterpSpeed) = value;
			}
		}

		// Token: 0x17005B5F RID: 23391
		// (get) Token: 0x060169B1 RID: 92593 RVA: 0x0020FC68 File Offset: 0x0020DE68
		// (set) Token: 0x060169B2 RID: 92594 RVA: 0x0020FC78 File Offset: 0x0020DE78
		public unsafe float FleeRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCrowdAiBoidActorSystem.__PropertyOffset_FleeRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCrowdAiBoidActorSystem.__PropertyOffset_FleeRadius) = value;
			}
		}

		// Token: 0x17005B60 RID: 23392
		// (get) Token: 0x060169B3 RID: 92595 RVA: 0x0020FC89 File Offset: 0x0020DE89
		// (set) Token: 0x060169B4 RID: 92596 RVA: 0x0020FC99 File Offset: 0x0020DE99
		public unsafe float MovingFleeRadiusFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCrowdAiBoidActorSystem.__PropertyOffset_MovingFleeRadiusFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCrowdAiBoidActorSystem.__PropertyOffset_MovingFleeRadiusFactor) = value;
			}
		}

		// Token: 0x17005B61 RID: 23393
		// (get) Token: 0x060169B5 RID: 92597 RVA: 0x0020FCAA File Offset: 0x0020DEAA
		// (set) Token: 0x060169B6 RID: 92598 RVA: 0x0020FCBA File Offset: 0x0020DEBA
		public unsafe float ArrivalRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCrowdAiBoidActorSystem.__PropertyOffset_ArrivalRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCrowdAiBoidActorSystem.__PropertyOffset_ArrivalRadius) = value;
			}
		}

		// Token: 0x17005B62 RID: 23394
		// (get) Token: 0x060169B7 RID: 92599 RVA: 0x0020FCCB File Offset: 0x0020DECB
		// (set) Token: 0x060169B8 RID: 92600 RVA: 0x0020FCDB File Offset: 0x0020DEDB
		public unsafe float MinDistToNavEdge
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCrowdAiBoidActorSystem.__PropertyOffset_MinDistToNavEdge);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCrowdAiBoidActorSystem.__PropertyOffset_MinDistToNavEdge) = value;
			}
		}

		// Token: 0x17005B63 RID: 23395
		// (get) Token: 0x060169B9 RID: 92601 RVA: 0x0020FCEC File Offset: 0x0020DEEC
		// (set) Token: 0x060169BA RID: 92602 RVA: 0x0020FCFC File Offset: 0x0020DEFC
		public unsafe float ExtraQueryOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCrowdAiBoidActorSystem.__PropertyOffset_ExtraQueryOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCrowdAiBoidActorSystem.__PropertyOffset_ExtraQueryOffset) = value;
			}
		}

		// Token: 0x17005B64 RID: 23396
		// (get) Token: 0x060169BB RID: 92603 RVA: 0x0020FD0D File Offset: 0x0020DF0D
		// (set) Token: 0x060169BC RID: 92604 RVA: 0x0020FD1D File Offset: 0x0020DF1D
		public unsafe float IdlePerformMinCD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCrowdAiBoidActorSystem.__PropertyOffset_IdlePerformMinCD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCrowdAiBoidActorSystem.__PropertyOffset_IdlePerformMinCD) = value;
			}
		}

		// Token: 0x17005B65 RID: 23397
		// (get) Token: 0x060169BD RID: 92605 RVA: 0x0020FD2E File Offset: 0x0020DF2E
		// (set) Token: 0x060169BE RID: 92606 RVA: 0x0020FD3E File Offset: 0x0020DF3E
		public unsafe float IdlePerformMaxCD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCrowdAiBoidActorSystem.__PropertyOffset_IdlePerformMaxCD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCrowdAiBoidActorSystem.__PropertyOffset_IdlePerformMaxCD) = value;
			}
		}

		// Token: 0x17005B66 RID: 23398
		// (get) Token: 0x060169BF RID: 92607 RVA: 0x0020FD4F File Offset: 0x0020DF4F
		// (set) Token: 0x060169C0 RID: 92608 RVA: 0x0020FD5F File Offset: 0x0020DF5F
		public unsafe float IdlePerformMaxPortion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCrowdAiBoidActorSystem.__PropertyOffset_IdlePerformMaxPortion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCrowdAiBoidActorSystem.__PropertyOffset_IdlePerformMaxPortion) = value;
			}
		}

		// Token: 0x17005B67 RID: 23399
		// (get) Token: 0x060169C1 RID: 92609 RVA: 0x0020FD70 File Offset: 0x0020DF70
		// (set) Token: 0x060169C2 RID: 92610 RVA: 0x0020FDA9 File Offset: 0x0020DFA9
		public TMap<int, int> BoidIdToInstanceIdMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, int> result;
				if ((result = this._BoidIdToInstanceIdMap) == null)
				{
					result = (this._BoidIdToInstanceIdMap = new TMap<int, int>(base.NativePtr + (IntPtr)AKuroCrowdAiBoidActorSystem.__PropertyOffset_BoidIdToInstanceIdMap, this));
				}
				return result;
			}
			set
			{
				this.BoidIdToInstanceIdMap.CopyAssign(value);
			}
		}

		// Token: 0x17005B68 RID: 23400
		// (get) Token: 0x060169C3 RID: 92611 RVA: 0x0020FDB8 File Offset: 0x0020DFB8
		// (set) Token: 0x060169C4 RID: 92612 RVA: 0x0020FDF1 File Offset: 0x0020DFF1
		public TSet<UKuroCrowdAiBoidAnimUpdater> AllocatedAnimUpdater
		{
			get
			{
				base.FastCheckIsValid();
				TSet<UKuroCrowdAiBoidAnimUpdater> result;
				if ((result = this._AllocatedAnimUpdater) == null)
				{
					result = (this._AllocatedAnimUpdater = new TSet<UKuroCrowdAiBoidAnimUpdater>(base.NativePtr + (IntPtr)AKuroCrowdAiBoidActorSystem.__PropertyOffset_AllocatedAnimUpdater, this));
				}
				return result;
			}
			set
			{
				this.AllocatedAnimUpdater.CopyAssign(value);
			}
		}

		// Token: 0x17005B69 RID: 23401
		// (get) Token: 0x060169C5 RID: 92613 RVA: 0x0020FE00 File Offset: 0x0020E000
		// (set) Token: 0x060169C6 RID: 92614 RVA: 0x0020FE39 File Offset: 0x0020E039
		public TMap<int, EKuroCrowdAiBoidAnimState> AnimStateConfig
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, EKuroCrowdAiBoidAnimState> result;
				if ((result = this._AnimStateConfig) == null)
				{
					result = (this._AnimStateConfig = new TMap<int, EKuroCrowdAiBoidAnimState>(base.NativePtr + (IntPtr)AKuroCrowdAiBoidActorSystem.__PropertyOffset_AnimStateConfig, this));
				}
				return result;
			}
			set
			{
				this.AnimStateConfig.CopyAssign(value);
			}
		}

		// Token: 0x17005B6A RID: 23402
		// (get) Token: 0x060169C7 RID: 92615 RVA: 0x0020FE48 File Offset: 0x0020E048
		// (set) Token: 0x060169C8 RID: 92616 RVA: 0x0020FE81 File Offset: 0x0020E081
		public TArray<FKuroCrowdAiAnimSequenceConfig> AnimSequenceConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCrowdAiAnimSequenceConfig> result;
				if ((result = this._AnimSequenceConfig) == null)
				{
					result = (this._AnimSequenceConfig = new TArray<FKuroCrowdAiAnimSequenceConfig>(base.NativePtr + (IntPtr)AKuroCrowdAiBoidActorSystem.__PropertyOffset_AnimSequenceConfig, this));
				}
				return result;
			}
			set
			{
				this.AnimSequenceConfig.CopyAssign(value);
			}
		}

		// Token: 0x17005B6B RID: 23403
		// (get) Token: 0x060169C9 RID: 92617 RVA: 0x0020FE90 File Offset: 0x0020E090
		// (set) Token: 0x060169CA RID: 92618 RVA: 0x0020FEC9 File Offset: 0x0020E0C9
		public TMap<UKuroMaterialControllerDataAsset, int> MaterialEffectWithTextureConfig
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UKuroMaterialControllerDataAsset, int> result;
				if ((result = this._MaterialEffectWithTextureConfig) == null)
				{
					result = (this._MaterialEffectWithTextureConfig = new TMap<UKuroMaterialControllerDataAsset, int>(base.NativePtr + (IntPtr)AKuroCrowdAiBoidActorSystem.__PropertyOffset_MaterialEffectWithTextureConfig, this));
				}
				return result;
			}
			set
			{
				this.MaterialEffectWithTextureConfig.CopyAssign(value);
			}
		}

		// Token: 0x060169CB RID: 92619 RVA: 0x0020FED7 File Offset: 0x0020E0D7
		public void SwitchBoidToPerformState(int BoidId)
		{
			AKuroCrowdAiBoidActorSystem.__SwitchBoidToPerformState_Internal(base.NativePtr, BoidId);
		}

		// Token: 0x060169CC RID: 92620 RVA: 0x0020FEE8 File Offset: 0x0020E0E8
		public unsafe int SpawnBoidActor(in FTransform InTransform, bool bForce = true)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = InTransform;
			return AKuroCrowdAiBoidActorSystem.__SpawnBoidActor_Internal(base.NativePtr, ptr, bForce);
		}

		// Token: 0x060169CD RID: 92621 RVA: 0x0020FF1E File Offset: 0x0020E11E
		public virtual bool InitGpuNpc()
		{
			return AKuroCrowdAiBoidActorSystem.__InitGpuNpc_Internal(base.NativePtr);
		}

		// Token: 0x060169CE RID: 92622 RVA: 0x0020FF2B File Offset: 0x0020E12B
		protected virtual bool InitGpuNpc_Implementation()
		{
			return AKuroCrowdAiBoidActorSystem.__InitGpuNpc_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x060169CF RID: 92623
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SwitchBoidToPerformState_Internal(IntPtr @this, int BoidId);

		// Token: 0x060169D0 RID: 92624
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __SpawnBoidActor_Internal(IntPtr @this, in FTransform InTransform, bool bForce);

		// Token: 0x060169D1 RID: 92625
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __InitGpuNpc_Internal(IntPtr @this);

		// Token: 0x060169D2 RID: 92626
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __InitGpuNpc_Implementation_Internal(IntPtr @this);

		// Token: 0x060169D3 RID: 92627 RVA: 0x0020FF38 File Offset: 0x0020E138
		static AKuroCrowdAiBoidActorSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroCrowdAi.KuroCrowdAiBoidActorSystem");
		}

		// Token: 0x060169D4 RID: 92628 RVA: 0x0020FF46 File Offset: 0x0020E146
		protected AKuroCrowdAiBoidActorSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C464 RID: 50276
		public new const string __ObjectPath = "/Script/KuroCrowdAi.KuroCrowdAiBoidActorSystem";

		// Token: 0x0400C465 RID: 50277
		private static IntPtr _ClassPtr;

		// Token: 0x0400C466 RID: 50278
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C467 RID: 50279
		internal static int __PropertyOffset_BakedBoneMeshComp;

		// Token: 0x0400C468 RID: 50280
		internal static int __PropertyOffset_MaterialControllerComp;

		// Token: 0x0400C469 RID: 50281
		internal static int __PropertyOffset_MaxBoidCount;

		// Token: 0x0400C46A RID: 50282
		internal static int __PropertyOffset_Radius;

		// Token: 0x0400C46B RID: 50283
		internal static int __PropertyOffset_HalfHeight;

		// Token: 0x0400C46C RID: 50284
		internal static int __PropertyOffset_RelativeTrans;

		// Token: 0x0400C46D RID: 50285
		internal static int __PropertyOffset_MaxSpeed;

		// Token: 0x0400C46E RID: 50286
		internal static int __PropertyOffset_MaxAccel;

		// Token: 0x0400C46F RID: 50287
		internal static int __PropertyOffset_GroundFriction;

		// Token: 0x0400C470 RID: 50288
		internal static int __PropertyOffset_MovingRadiusFactor;

		// Token: 0x0400C471 RID: 50289
		internal static int __PropertyOffset_WalkMinSpeed;

		// Token: 0x0400C472 RID: 50290
		internal static int __PropertyOffset_IdleMaxSpeed;

		// Token: 0x0400C473 RID: 50291
		internal static int __PropertyOffset_TurnInterpSpeed;

		// Token: 0x0400C474 RID: 50292
		internal static int __PropertyOffset_FleeRadius;

		// Token: 0x0400C475 RID: 50293
		internal static int __PropertyOffset_MovingFleeRadiusFactor;

		// Token: 0x0400C476 RID: 50294
		internal static int __PropertyOffset_ArrivalRadius;

		// Token: 0x0400C477 RID: 50295
		internal static int __PropertyOffset_MinDistToNavEdge;

		// Token: 0x0400C478 RID: 50296
		internal static int __PropertyOffset_ExtraQueryOffset;

		// Token: 0x0400C479 RID: 50297
		internal static int __PropertyOffset_IdlePerformMinCD;

		// Token: 0x0400C47A RID: 50298
		internal static int __PropertyOffset_IdlePerformMaxCD;

		// Token: 0x0400C47B RID: 50299
		internal static int __PropertyOffset_IdlePerformMaxPortion;

		// Token: 0x0400C47C RID: 50300
		internal static int __PropertyOffset_BoidIdToInstanceIdMap;

		// Token: 0x0400C47D RID: 50301
		[Nullable(2)]
		private TMap<int, int> _BoidIdToInstanceIdMap;

		// Token: 0x0400C47E RID: 50302
		internal static int __PropertyOffset_AllocatedAnimUpdater;

		// Token: 0x0400C47F RID: 50303
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UKuroCrowdAiBoidAnimUpdater> _AllocatedAnimUpdater;

		// Token: 0x0400C480 RID: 50304
		internal static int __PropertyOffset_AnimStateConfig;

		// Token: 0x0400C481 RID: 50305
		[Nullable(2)]
		private TMap<int, EKuroCrowdAiBoidAnimState> _AnimStateConfig;

		// Token: 0x0400C482 RID: 50306
		internal static int __PropertyOffset_AnimSequenceConfig;

		// Token: 0x0400C483 RID: 50307
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCrowdAiAnimSequenceConfig> _AnimSequenceConfig;

		// Token: 0x0400C484 RID: 50308
		internal static int __PropertyOffset_MaterialEffectWithTextureConfig;

		// Token: 0x0400C485 RID: 50309
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<UKuroMaterialControllerDataAsset, int> _MaterialEffectWithTextureConfig;

		// Token: 0x02002F33 RID: 12083
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __InitGpuNpc_FunctionParams
		{
			// Token: 0x04016AB0 RID: 92848
			[FieldOffset(0)]
			public bool __Result;
		}
	}
}
