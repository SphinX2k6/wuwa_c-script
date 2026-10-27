using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A64 RID: 6756
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.CoralWindActor")]
	[UnrealStructLayout(1976, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1976)]
	public class ACoralWindActor : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601902B RID: 102443 RVA: 0x0024F672 File Offset: 0x0024D872
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ACoralWindActor._ClassPtr;
		}

		// Token: 0x0601902C RID: 102444 RVA: 0x0024F680 File Offset: 0x0024D880
		public ACoralWindActor() : this(BuiltinUtils.AllocNativeUObject(ACoralWindActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601902D RID: 102445 RVA: 0x0024F6A8 File Offset: 0x0024D8A8
		[NullableContext(1)]
		public ACoralWindActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ACoralWindActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006325 RID: 25381
		// (get) Token: 0x0601902E RID: 102446 RVA: 0x0024F6DB File Offset: 0x0024D8DB
		// (set) Token: 0x0601902F RID: 102447 RVA: 0x0024F6EF File Offset: 0x0024D8EF
		public unsafe UTexture2D RestSpineTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + ACoralWindActor.__PropertyOffset_RestSpineTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ACoralWindActor.__PropertyOffset_RestSpineTexture, value);
			}
		}

		// Token: 0x17006326 RID: 25382
		// (get) Token: 0x06019030 RID: 102448 RVA: 0x0024F704 File Offset: 0x0024D904
		// (set) Token: 0x06019031 RID: 102449 RVA: 0x0024F718 File Offset: 0x0024D918
		public unsafe UTextureRenderTarget2D RenderTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + ACoralWindActor.__PropertyOffset_RenderTarget);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ACoralWindActor.__PropertyOffset_RenderTarget, value);
			}
		}

		// Token: 0x17006327 RID: 25383
		// (get) Token: 0x06019032 RID: 102450 RVA: 0x0024F72D File Offset: 0x0024D92D
		// (set) Token: 0x06019033 RID: 102451 RVA: 0x0024F73D File Offset: 0x0024D93D
		public unsafe int NodeCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_NodeCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_NodeCount) = value;
			}
		}

		// Token: 0x17006328 RID: 25384
		// (get) Token: 0x06019034 RID: 102452 RVA: 0x0024F74E File Offset: 0x0024D94E
		// (set) Token: 0x06019035 RID: 102453 RVA: 0x0024F75E File Offset: 0x0024D95E
		public unsafe float WindAmplitude
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_WindAmplitude);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_WindAmplitude) = value;
			}
		}

		// Token: 0x17006329 RID: 25385
		// (get) Token: 0x06019036 RID: 102454 RVA: 0x0024F76F File Offset: 0x0024D96F
		// (set) Token: 0x06019037 RID: 102455 RVA: 0x0024F77F File Offset: 0x0024D97F
		public unsafe float WindBaseStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_WindBaseStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_WindBaseStrength) = value;
			}
		}

		// Token: 0x1700632A RID: 25386
		// (get) Token: 0x06019038 RID: 102456 RVA: 0x0024F790 File Offset: 0x0024D990
		// (set) Token: 0x06019039 RID: 102457 RVA: 0x0024F7A0 File Offset: 0x0024D9A0
		public unsafe float WindFreq
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_WindFreq);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_WindFreq) = value;
			}
		}

		// Token: 0x1700632B RID: 25387
		// (get) Token: 0x0601903A RID: 102458 RVA: 0x0024F7B1 File Offset: 0x0024D9B1
		// (set) Token: 0x0601903B RID: 102459 RVA: 0x0024F7C1 File Offset: 0x0024D9C1
		public unsafe float ClusterDesync
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_ClusterDesync);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_ClusterDesync) = value;
			}
		}

		// Token: 0x1700632C RID: 25388
		// (get) Token: 0x0601903C RID: 102460 RVA: 0x0024F7D2 File Offset: 0x0024D9D2
		// (set) Token: 0x0601903D RID: 102461 RVA: 0x0024F7E2 File Offset: 0x0024D9E2
		public unsafe float GustSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_GustSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_GustSpeed) = value;
			}
		}

		// Token: 0x1700632D RID: 25389
		// (get) Token: 0x0601903E RID: 102462 RVA: 0x0024F7F3 File Offset: 0x0024D9F3
		// (set) Token: 0x0601903F RID: 102463 RVA: 0x0024F803 File Offset: 0x0024DA03
		public unsafe float GustRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_GustRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_GustRange) = value;
			}
		}

		// Token: 0x1700632E RID: 25390
		// (get) Token: 0x06019040 RID: 102464 RVA: 0x0024F814 File Offset: 0x0024DA14
		// (set) Token: 0x06019041 RID: 102465 RVA: 0x0024F824 File Offset: 0x0024DA24
		public unsafe float GustDwell
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_GustDwell);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_GustDwell) = value;
			}
		}

		// Token: 0x1700632F RID: 25391
		// (get) Token: 0x06019042 RID: 102466 RVA: 0x0024F835 File Offset: 0x0024DA35
		// (set) Token: 0x06019043 RID: 102467 RVA: 0x0024F845 File Offset: 0x0024DA45
		public unsafe float GustWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_GustWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_GustWidth) = value;
			}
		}

		// Token: 0x17006330 RID: 25392
		// (get) Token: 0x06019044 RID: 102468 RVA: 0x0024F856 File Offset: 0x0024DA56
		// (set) Token: 0x06019045 RID: 102469 RVA: 0x0024F866 File Offset: 0x0024DA66
		public unsafe float GustFront
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_GustFront);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_GustFront) = value;
			}
		}

		// Token: 0x17006331 RID: 25393
		// (get) Token: 0x06019046 RID: 102470 RVA: 0x0024F877 File Offset: 0x0024DA77
		// (set) Token: 0x06019047 RID: 102471 RVA: 0x0024F887 File Offset: 0x0024DA87
		public unsafe float BendExponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_BendExponent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_BendExponent) = value;
			}
		}

		// Token: 0x17006332 RID: 25394
		// (get) Token: 0x06019048 RID: 102472 RVA: 0x0024F898 File Offset: 0x0024DA98
		// (set) Token: 0x06019049 RID: 102473 RVA: 0x0024F8A8 File Offset: 0x0024DAA8
		public unsafe float RestoreTaper
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_RestoreTaper);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_RestoreTaper) = value;
			}
		}

		// Token: 0x17006333 RID: 25395
		// (get) Token: 0x0601904A RID: 102474 RVA: 0x0024F8B9 File Offset: 0x0024DAB9
		// (set) Token: 0x0601904B RID: 102475 RVA: 0x0024F8C9 File Offset: 0x0024DAC9
		public unsafe float Swirl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_Swirl);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_Swirl) = value;
			}
		}

		// Token: 0x17006334 RID: 25396
		// (get) Token: 0x0601904C RID: 102476 RVA: 0x0024F8DA File Offset: 0x0024DADA
		// (set) Token: 0x0601904D RID: 102477 RVA: 0x0024F8EA File Offset: 0x0024DAEA
		public unsafe float Stiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_Stiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_Stiffness) = value;
			}
		}

		// Token: 0x17006335 RID: 25397
		// (get) Token: 0x0601904E RID: 102478 RVA: 0x0024F8FB File Offset: 0x0024DAFB
		// (set) Token: 0x0601904F RID: 102479 RVA: 0x0024F90B File Offset: 0x0024DB0B
		public unsafe float Damping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_Damping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_Damping) = value;
			}
		}

		// Token: 0x17006336 RID: 25398
		// (get) Token: 0x06019050 RID: 102480 RVA: 0x0024F91C File Offset: 0x0024DB1C
		// (set) Token: 0x06019051 RID: 102481 RVA: 0x0024F92C File Offset: 0x0024DB2C
		public unsafe float WaterDrag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_WaterDrag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_WaterDrag) = value;
			}
		}

		// Token: 0x17006337 RID: 25399
		// (get) Token: 0x06019052 RID: 102482 RVA: 0x0024F93D File Offset: 0x0024DB3D
		// (set) Token: 0x06019053 RID: 102483 RVA: 0x0024F94D File Offset: 0x0024DB4D
		public unsafe int ConstraintIters
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_ConstraintIters);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_ConstraintIters) = value;
			}
		}

		// Token: 0x17006338 RID: 25400
		// (get) Token: 0x06019054 RID: 102484 RVA: 0x0024F95E File Offset: 0x0024DB5E
		// (set) Token: 0x06019055 RID: 102485 RVA: 0x0024F96E File Offset: 0x0024DB6E
		public unsafe bool bHookFoliage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_bHookFoliage) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_bHookFoliage) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006339 RID: 25401
		// (get) Token: 0x06019056 RID: 102486 RVA: 0x0024F97F File Offset: 0x0024DB7F
		// (set) Token: 0x06019057 RID: 102487 RVA: 0x0024F993 File Offset: 0x0024DB93
		public unsafe UCoralRegistry CoralRegistry
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCoralRegistry>(base.NativePtr / (IntPtr)sizeof(void*) + ACoralWindActor.__PropertyOffset_CoralRegistry);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ACoralWindActor.__PropertyOffset_CoralRegistry, value);
			}
		}

		// Token: 0x1700633A RID: 25402
		// (get) Token: 0x06019058 RID: 102488 RVA: 0x0024F9A8 File Offset: 0x0024DBA8
		// (set) Token: 0x06019059 RID: 102489 RVA: 0x0024F9B8 File Offset: 0x0024DBB8
		public unsafe int GlobalRTWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_GlobalRTWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_GlobalRTWidth) = value;
			}
		}

		// Token: 0x1700633B RID: 25403
		// (get) Token: 0x0601905A RID: 102490 RVA: 0x0024F9C9 File Offset: 0x0024DBC9
		// (set) Token: 0x0601905B RID: 102491 RVA: 0x0024F9D9 File Offset: 0x0024DBD9
		public unsafe float PlayerRadiusMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_PlayerRadiusMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_PlayerRadiusMultiplier) = value;
			}
		}

		// Token: 0x1700633C RID: 25404
		// (get) Token: 0x0601905C RID: 102492 RVA: 0x0024F9EA File Offset: 0x0024DBEA
		// (set) Token: 0x0601905D RID: 102493 RVA: 0x0024F9FA File Offset: 0x0024DBFA
		public unsafe float PlayerPushStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_PlayerPushStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_PlayerPushStrength) = value;
			}
		}

		// Token: 0x1700633D RID: 25405
		// (get) Token: 0x0601905E RID: 102494 RVA: 0x0024FA0B File Offset: 0x0024DC0B
		// (set) Token: 0x0601905F RID: 102495 RVA: 0x0024FA1F File Offset: 0x0024DC1F
		public unsafe UMaterialParameterCollection RuntimeMPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + ACoralWindActor.__PropertyOffset_RuntimeMPC);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ACoralWindActor.__PropertyOffset_RuntimeMPC, value);
			}
		}

		// Token: 0x1700633E RID: 25406
		// (get) Token: 0x06019060 RID: 102496 RVA: 0x0024FA34 File Offset: 0x0024DC34
		// (set) Token: 0x06019061 RID: 102497 RVA: 0x0024FA44 File Offset: 0x0024DC44
		public unsafe float SimRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_SimRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_SimRadius) = value;
			}
		}

		// Token: 0x1700633F RID: 25407
		// (get) Token: 0x06019062 RID: 102498 RVA: 0x0024FA55 File Offset: 0x0024DC55
		// (set) Token: 0x06019063 RID: 102499 RVA: 0x0024FA65 File Offset: 0x0024DC65
		public unsafe float FreeRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_FreeRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_FreeRadius) = value;
			}
		}

		// Token: 0x17006340 RID: 25408
		// (get) Token: 0x06019064 RID: 102500 RVA: 0x0024FA76 File Offset: 0x0024DC76
		// (set) Token: 0x06019065 RID: 102501 RVA: 0x0024FA86 File Offset: 0x0024DC86
		public unsafe float BubbleMoveThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_BubbleMoveThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_BubbleMoveThreshold) = value;
			}
		}

		// Token: 0x17006341 RID: 25409
		// (get) Token: 0x06019066 RID: 102502 RVA: 0x0024FA97 File Offset: 0x0024DC97
		// (set) Token: 0x06019067 RID: 102503 RVA: 0x0024FAA7 File Offset: 0x0024DCA7
		public unsafe float BubbleUpdatePeriod
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_BubbleUpdatePeriod);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_BubbleUpdatePeriod) = value;
			}
		}

		// Token: 0x17006342 RID: 25410
		// (get) Token: 0x06019068 RID: 102504 RVA: 0x0024FAB8 File Offset: 0x0024DCB8
		// (set) Token: 0x06019069 RID: 102505 RVA: 0x0024FAC8 File Offset: 0x0024DCC8
		public unsafe float ProcAmpScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_ProcAmpScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_ProcAmpScale) = value;
			}
		}

		// Token: 0x17006343 RID: 25411
		// (get) Token: 0x0601906A RID: 102506 RVA: 0x0024FAD9 File Offset: 0x0024DCD9
		// (set) Token: 0x0601906B RID: 102507 RVA: 0x0024FAE9 File Offset: 0x0024DCE9
		public unsafe float ProcSwaySpeedScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_ProcSwaySpeedScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_ProcSwaySpeedScale) = value;
			}
		}

		// Token: 0x17006344 RID: 25412
		// (get) Token: 0x0601906C RID: 102508 RVA: 0x0024FAFA File Offset: 0x0024DCFA
		// (set) Token: 0x0601906D RID: 102509 RVA: 0x0024FB0A File Offset: 0x0024DD0A
		public unsafe float ProcStrandDesync
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_ProcStrandDesync);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACoralWindActor.__PropertyOffset_ProcStrandDesync) = value;
			}
		}

		// Token: 0x17006345 RID: 25413
		// (get) Token: 0x0601906E RID: 102510 RVA: 0x0024FB1B File Offset: 0x0024DD1B
		// (set) Token: 0x0601906F RID: 102511 RVA: 0x0024FB2F File Offset: 0x0024DD2F
		public unsafe USceneComponent Root
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ACoralWindActor.__PropertyOffset_Root);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ACoralWindActor.__PropertyOffset_Root, value);
			}
		}

		// Token: 0x06019070 RID: 102512 RVA: 0x0024FB44 File Offset: 0x0024DD44
		public void SetSphereInteractors([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FCoralSphere> InSpheres)
		{
			ACoralWindActor.__SetSphereInteractors_Internal(base.NativePtr, (InSpheres ?? new TArray<FCoralSphere>()).NativePtr);
		}

		// Token: 0x06019071 RID: 102513 RVA: 0x0024FB61 File Offset: 0x0024DD61
		public void SetPlayerInteractor(UCapsuleComponent Capsule)
		{
			ACoralWindActor.__SetPlayerInteractor_Internal(base.NativePtr, (Capsule != null) ? Capsule.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06019072 RID: 102514 RVA: 0x0024FB7E File Offset: 0x0024DD7E
		public void SetPlayerActors([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> Actors)
		{
			ACoralWindActor.__SetPlayerActors_Internal(base.NativePtr, (Actors ?? new TArray<AActor>()).NativePtr);
		}

		// Token: 0x06019073 RID: 102515 RVA: 0x0024FB9B File Offset: 0x0024DD9B
		public void ClearPlayerInteractor()
		{
			ACoralWindActor.__ClearPlayerInteractor_Internal(base.NativePtr);
		}

		// Token: 0x06019074 RID: 102516
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSphereInteractors_Internal(IntPtr @this, IntPtr InSpheres);

		// Token: 0x06019075 RID: 102517
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPlayerInteractor_Internal(IntPtr @this, IntPtr Capsule);

		// Token: 0x06019076 RID: 102518
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPlayerActors_Internal(IntPtr @this, IntPtr Actors);

		// Token: 0x06019077 RID: 102519
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearPlayerInteractor_Internal(IntPtr @this);

		// Token: 0x06019078 RID: 102520 RVA: 0x0024FBA8 File Offset: 0x0024DDA8
		static ACoralWindActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.CoralWindActor");
		}

		// Token: 0x06019079 RID: 102521 RVA: 0x0024FBB6 File Offset: 0x0024DDB6
		protected ACoralWindActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D878 RID: 55416
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.CoralWindActor";

		// Token: 0x0400D879 RID: 55417
		private static IntPtr _ClassPtr;

		// Token: 0x0400D87A RID: 55418
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D87B RID: 55419
		internal static int __PropertyOffset_RestSpineTexture;

		// Token: 0x0400D87C RID: 55420
		internal static int __PropertyOffset_RenderTarget;

		// Token: 0x0400D87D RID: 55421
		internal static int __PropertyOffset_NodeCount;

		// Token: 0x0400D87E RID: 55422
		internal static int __PropertyOffset_WindAmplitude;

		// Token: 0x0400D87F RID: 55423
		internal static int __PropertyOffset_WindBaseStrength;

		// Token: 0x0400D880 RID: 55424
		internal static int __PropertyOffset_WindFreq;

		// Token: 0x0400D881 RID: 55425
		internal static int __PropertyOffset_ClusterDesync;

		// Token: 0x0400D882 RID: 55426
		internal static int __PropertyOffset_GustSpeed;

		// Token: 0x0400D883 RID: 55427
		internal static int __PropertyOffset_GustRange;

		// Token: 0x0400D884 RID: 55428
		internal static int __PropertyOffset_GustDwell;

		// Token: 0x0400D885 RID: 55429
		internal static int __PropertyOffset_GustWidth;

		// Token: 0x0400D886 RID: 55430
		internal static int __PropertyOffset_GustFront;

		// Token: 0x0400D887 RID: 55431
		internal static int __PropertyOffset_BendExponent;

		// Token: 0x0400D888 RID: 55432
		internal static int __PropertyOffset_RestoreTaper;

		// Token: 0x0400D889 RID: 55433
		internal static int __PropertyOffset_Swirl;

		// Token: 0x0400D88A RID: 55434
		internal static int __PropertyOffset_Stiffness;

		// Token: 0x0400D88B RID: 55435
		internal static int __PropertyOffset_Damping;

		// Token: 0x0400D88C RID: 55436
		internal static int __PropertyOffset_WaterDrag;

		// Token: 0x0400D88D RID: 55437
		internal static int __PropertyOffset_ConstraintIters;

		// Token: 0x0400D88E RID: 55438
		internal static int __PropertyOffset_bHookFoliage;

		// Token: 0x0400D88F RID: 55439
		internal static int __PropertyOffset_CoralRegistry;

		// Token: 0x0400D890 RID: 55440
		internal static int __PropertyOffset_GlobalRTWidth;

		// Token: 0x0400D891 RID: 55441
		internal static int __PropertyOffset_PlayerRadiusMultiplier;

		// Token: 0x0400D892 RID: 55442
		internal static int __PropertyOffset_PlayerPushStrength;

		// Token: 0x0400D893 RID: 55443
		internal static int __PropertyOffset_RuntimeMPC;

		// Token: 0x0400D894 RID: 55444
		internal static int __PropertyOffset_SimRadius;

		// Token: 0x0400D895 RID: 55445
		internal static int __PropertyOffset_FreeRadius;

		// Token: 0x0400D896 RID: 55446
		internal static int __PropertyOffset_BubbleMoveThreshold;

		// Token: 0x0400D897 RID: 55447
		internal static int __PropertyOffset_BubbleUpdatePeriod;

		// Token: 0x0400D898 RID: 55448
		internal static int __PropertyOffset_ProcAmpScale;

		// Token: 0x0400D899 RID: 55449
		internal static int __PropertyOffset_ProcSwaySpeedScale;

		// Token: 0x0400D89A RID: 55450
		internal static int __PropertyOffset_ProcStrandDesync;

		// Token: 0x0400D89B RID: 55451
		internal static int __PropertyOffset_Root;
	}
}
