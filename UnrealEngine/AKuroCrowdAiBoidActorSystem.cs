using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000358 RID: 856
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroCrowdAi.KuroCrowdAiBoidActorSystem")]
	[UnrealStructLayout(2608, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2608)]
	public class AKuroCrowdAiBoidActorSystem : ABakedBoneMeshActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600574F RID: 22351 RVA: 0x0007AF65 File Offset: 0x00079165
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroCrowdAiBoidActorSystem._ClassPtr;
		}

		// Token: 0x06005750 RID: 22352 RVA: 0x0007AF74 File Offset: 0x00079174
		public AKuroCrowdAiBoidActorSystem() : this(BuiltinUtils.AllocNativeUObject(AKuroCrowdAiBoidActorSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005751 RID: 22353 RVA: 0x0007AF9C File Offset: 0x0007919C
		public AKuroCrowdAiBoidActorSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroCrowdAiBoidActorSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700112B RID: 4395
		// (get) Token: 0x06005752 RID: 22354 RVA: 0x0007AFCF File Offset: 0x000791CF
		// (set) Token: 0x06005753 RID: 22355 RVA: 0x0007AFE3 File Offset: 0x000791E3
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

		// Token: 0x1700112C RID: 4396
		// (get) Token: 0x06005754 RID: 22356 RVA: 0x0007AFF8 File Offset: 0x000791F8
		// (set) Token: 0x06005755 RID: 22357 RVA: 0x0007B00C File Offset: 0x0007920C
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

		// Token: 0x1700112D RID: 4397
		// (get) Token: 0x06005756 RID: 22358 RVA: 0x0007B021 File Offset: 0x00079221
		// (set) Token: 0x06005757 RID: 22359 RVA: 0x0007B031 File Offset: 0x00079231
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

		// Token: 0x1700112E RID: 4398
		// (get) Token: 0x06005758 RID: 22360 RVA: 0x0007B042 File Offset: 0x00079242
		// (set) Token: 0x06005759 RID: 22361 RVA: 0x0007B052 File Offset: 0x00079252
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

		// Token: 0x1700112F RID: 4399
		// (get) Token: 0x0600575A RID: 22362 RVA: 0x0007B063 File Offset: 0x00079263
		// (set) Token: 0x0600575B RID: 22363 RVA: 0x0007B073 File Offset: 0x00079273
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

		// Token: 0x17001130 RID: 4400
		// (get) Token: 0x0600575C RID: 22364 RVA: 0x0007B084 File Offset: 0x00079284
		// (set) Token: 0x0600575D RID: 22365 RVA: 0x0007B098 File Offset: 0x00079298
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

		// Token: 0x17001131 RID: 4401
		// (get) Token: 0x0600575E RID: 22366 RVA: 0x0007B0AD File Offset: 0x000792AD
		// (set) Token: 0x0600575F RID: 22367 RVA: 0x0007B0BD File Offset: 0x000792BD
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

		// Token: 0x17001132 RID: 4402
		// (get) Token: 0x06005760 RID: 22368 RVA: 0x0007B0CE File Offset: 0x000792CE
		// (set) Token: 0x06005761 RID: 22369 RVA: 0x0007B0DE File Offset: 0x000792DE
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

		// Token: 0x17001133 RID: 4403
		// (get) Token: 0x06005762 RID: 22370 RVA: 0x0007B0EF File Offset: 0x000792EF
		// (set) Token: 0x06005763 RID: 22371 RVA: 0x0007B0FF File Offset: 0x000792FF
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

		// Token: 0x17001134 RID: 4404
		// (get) Token: 0x06005764 RID: 22372 RVA: 0x0007B110 File Offset: 0x00079310
		// (set) Token: 0x06005765 RID: 22373 RVA: 0x0007B120 File Offset: 0x00079320
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

		// Token: 0x17001135 RID: 4405
		// (get) Token: 0x06005766 RID: 22374 RVA: 0x0007B131 File Offset: 0x00079331
		// (set) Token: 0x06005767 RID: 22375 RVA: 0x0007B141 File Offset: 0x00079341
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

		// Token: 0x17001136 RID: 4406
		// (get) Token: 0x06005768 RID: 22376 RVA: 0x0007B152 File Offset: 0x00079352
		// (set) Token: 0x06005769 RID: 22377 RVA: 0x0007B162 File Offset: 0x00079362
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

		// Token: 0x17001137 RID: 4407
		// (get) Token: 0x0600576A RID: 22378 RVA: 0x0007B173 File Offset: 0x00079373
		// (set) Token: 0x0600576B RID: 22379 RVA: 0x0007B183 File Offset: 0x00079383
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

		// Token: 0x17001138 RID: 4408
		// (get) Token: 0x0600576C RID: 22380 RVA: 0x0007B194 File Offset: 0x00079394
		// (set) Token: 0x0600576D RID: 22381 RVA: 0x0007B1A4 File Offset: 0x000793A4
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

		// Token: 0x17001139 RID: 4409
		// (get) Token: 0x0600576E RID: 22382 RVA: 0x0007B1B5 File Offset: 0x000793B5
		// (set) Token: 0x0600576F RID: 22383 RVA: 0x0007B1C5 File Offset: 0x000793C5
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

		// Token: 0x1700113A RID: 4410
		// (get) Token: 0x06005770 RID: 22384 RVA: 0x0007B1D6 File Offset: 0x000793D6
		// (set) Token: 0x06005771 RID: 22385 RVA: 0x0007B1E6 File Offset: 0x000793E6
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

		// Token: 0x1700113B RID: 4411
		// (get) Token: 0x06005772 RID: 22386 RVA: 0x0007B1F7 File Offset: 0x000793F7
		// (set) Token: 0x06005773 RID: 22387 RVA: 0x0007B207 File Offset: 0x00079407
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

		// Token: 0x1700113C RID: 4412
		// (get) Token: 0x06005774 RID: 22388 RVA: 0x0007B218 File Offset: 0x00079418
		// (set) Token: 0x06005775 RID: 22389 RVA: 0x0007B228 File Offset: 0x00079428
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

		// Token: 0x1700113D RID: 4413
		// (get) Token: 0x06005776 RID: 22390 RVA: 0x0007B239 File Offset: 0x00079439
		// (set) Token: 0x06005777 RID: 22391 RVA: 0x0007B249 File Offset: 0x00079449
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

		// Token: 0x1700113E RID: 4414
		// (get) Token: 0x06005778 RID: 22392 RVA: 0x0007B25A File Offset: 0x0007945A
		// (set) Token: 0x06005779 RID: 22393 RVA: 0x0007B26A File Offset: 0x0007946A
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

		// Token: 0x1700113F RID: 4415
		// (get) Token: 0x0600577A RID: 22394 RVA: 0x0007B27B File Offset: 0x0007947B
		// (set) Token: 0x0600577B RID: 22395 RVA: 0x0007B28B File Offset: 0x0007948B
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

		// Token: 0x17001140 RID: 4416
		// (get) Token: 0x0600577C RID: 22396 RVA: 0x0007B29C File Offset: 0x0007949C
		// (set) Token: 0x0600577D RID: 22397 RVA: 0x0007B2D5 File Offset: 0x000794D5
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

		// Token: 0x17001141 RID: 4417
		// (get) Token: 0x0600577E RID: 22398 RVA: 0x0007B2E4 File Offset: 0x000794E4
		// (set) Token: 0x0600577F RID: 22399 RVA: 0x0007B31D File Offset: 0x0007951D
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

		// Token: 0x17001142 RID: 4418
		// (get) Token: 0x06005780 RID: 22400 RVA: 0x0007B32C File Offset: 0x0007952C
		// (set) Token: 0x06005781 RID: 22401 RVA: 0x0007B365 File Offset: 0x00079565
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

		// Token: 0x17001143 RID: 4419
		// (get) Token: 0x06005782 RID: 22402 RVA: 0x0007B374 File Offset: 0x00079574
		// (set) Token: 0x06005783 RID: 22403 RVA: 0x0007B3AD File Offset: 0x000795AD
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

		// Token: 0x06005784 RID: 22404 RVA: 0x0007B3BB File Offset: 0x000795BB
		public void SwitchBoidToPerformState(int BoidId)
		{
			AKuroCrowdAiBoidActorSystem.__SwitchBoidToPerformState_Internal(base.NativePtr, BoidId);
		}

		// Token: 0x06005785 RID: 22405 RVA: 0x0007B3CC File Offset: 0x000795CC
		public unsafe int SpawnBoidActor(in FTransform InTransform, bool bForce = true)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = InTransform;
			return AKuroCrowdAiBoidActorSystem.__SpawnBoidActor_Internal(base.NativePtr, ptr, bForce);
		}

		// Token: 0x06005786 RID: 22406 RVA: 0x0007B402 File Offset: 0x00079602
		public virtual bool InitGpuNpc()
		{
			return AKuroCrowdAiBoidActorSystem.__InitGpuNpc_Internal(base.NativePtr);
		}

		// Token: 0x06005787 RID: 22407 RVA: 0x0007B40F File Offset: 0x0007960F
		protected virtual bool InitGpuNpc_Implementation()
		{
			return AKuroCrowdAiBoidActorSystem.__InitGpuNpc_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x06005788 RID: 22408
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SwitchBoidToPerformState_Internal(IntPtr @this, int BoidId);

		// Token: 0x06005789 RID: 22409
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __SpawnBoidActor_Internal(IntPtr @this, in FTransform InTransform, bool bForce);

		// Token: 0x0600578A RID: 22410
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __InitGpuNpc_Internal(IntPtr @this);

		// Token: 0x0600578B RID: 22411
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __InitGpuNpc_Implementation_Internal(IntPtr @this);

		// Token: 0x0600578C RID: 22412 RVA: 0x0007B41C File Offset: 0x0007961C
		static AKuroCrowdAiBoidActorSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroCrowdAi.KuroCrowdAiBoidActorSystem");
		}

		// Token: 0x0600578D RID: 22413 RVA: 0x0007B42A File Offset: 0x0007962A
		protected AKuroCrowdAiBoidActorSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040023F6 RID: 9206
		public new const string __ObjectPath = "/Script/KuroCrowdAi.KuroCrowdAiBoidActorSystem";

		// Token: 0x040023F7 RID: 9207
		private static IntPtr _ClassPtr;

		// Token: 0x040023F8 RID: 9208
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040023F9 RID: 9209
		internal static int __PropertyOffset_BakedBoneMeshComp;

		// Token: 0x040023FA RID: 9210
		internal static int __PropertyOffset_MaterialControllerComp;

		// Token: 0x040023FB RID: 9211
		internal static int __PropertyOffset_MaxBoidCount;

		// Token: 0x040023FC RID: 9212
		internal static int __PropertyOffset_Radius;

		// Token: 0x040023FD RID: 9213
		internal static int __PropertyOffset_HalfHeight;

		// Token: 0x040023FE RID: 9214
		internal static int __PropertyOffset_RelativeTrans;

		// Token: 0x040023FF RID: 9215
		internal static int __PropertyOffset_MaxSpeed;

		// Token: 0x04002400 RID: 9216
		internal static int __PropertyOffset_MaxAccel;

		// Token: 0x04002401 RID: 9217
		internal static int __PropertyOffset_GroundFriction;

		// Token: 0x04002402 RID: 9218
		internal static int __PropertyOffset_MovingRadiusFactor;

		// Token: 0x04002403 RID: 9219
		internal static int __PropertyOffset_WalkMinSpeed;

		// Token: 0x04002404 RID: 9220
		internal static int __PropertyOffset_IdleMaxSpeed;

		// Token: 0x04002405 RID: 9221
		internal static int __PropertyOffset_TurnInterpSpeed;

		// Token: 0x04002406 RID: 9222
		internal static int __PropertyOffset_FleeRadius;

		// Token: 0x04002407 RID: 9223
		internal static int __PropertyOffset_MovingFleeRadiusFactor;

		// Token: 0x04002408 RID: 9224
		internal static int __PropertyOffset_ArrivalRadius;

		// Token: 0x04002409 RID: 9225
		internal static int __PropertyOffset_MinDistToNavEdge;

		// Token: 0x0400240A RID: 9226
		internal static int __PropertyOffset_ExtraQueryOffset;

		// Token: 0x0400240B RID: 9227
		internal static int __PropertyOffset_IdlePerformMinCD;

		// Token: 0x0400240C RID: 9228
		internal static int __PropertyOffset_IdlePerformMaxCD;

		// Token: 0x0400240D RID: 9229
		internal static int __PropertyOffset_IdlePerformMaxPortion;

		// Token: 0x0400240E RID: 9230
		internal static int __PropertyOffset_BoidIdToInstanceIdMap;

		// Token: 0x0400240F RID: 9231
		[Nullable(2)]
		private TMap<int, int> _BoidIdToInstanceIdMap;

		// Token: 0x04002410 RID: 9232
		internal static int __PropertyOffset_AnimStateConfig;

		// Token: 0x04002411 RID: 9233
		[Nullable(2)]
		private TMap<int, EKuroCrowdAiBoidAnimState> _AnimStateConfig;

		// Token: 0x04002412 RID: 9234
		internal static int __PropertyOffset_AnimSequenceConfig;

		// Token: 0x04002413 RID: 9235
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCrowdAiAnimSequenceConfig> _AnimSequenceConfig;

		// Token: 0x04002414 RID: 9236
		internal static int __PropertyOffset_MaterialEffectWithTextureConfig;

		// Token: 0x04002415 RID: 9237
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<UKuroMaterialControllerDataAsset, int> _MaterialEffectWithTextureConfig;

		// Token: 0x02000A64 RID: 2660
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __InitGpuNpc_FunctionParams
		{
			// Token: 0x04005A7F RID: 23167
			[FieldOffset(0)]
			public bool __Result;
		}
	}
}
