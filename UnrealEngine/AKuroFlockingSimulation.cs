using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B02 RID: 6914
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroFlockingSimulation")]
	[UnrealStructLayout(2528, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2528)]
	public class AKuroFlockingSimulation : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019DC9 RID: 105929 RVA: 0x00262F00 File Offset: 0x00261100
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroFlockingSimulation._ClassPtr;
		}

		// Token: 0x06019DCA RID: 105930 RVA: 0x00262F0C File Offset: 0x0026110C
		public AKuroFlockingSimulation() : this(BuiltinUtils.AllocNativeUObject(AKuroFlockingSimulation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019DCB RID: 105931 RVA: 0x00262F34 File Offset: 0x00261134
		public AKuroFlockingSimulation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroFlockingSimulation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006799 RID: 26521
		// (get) Token: 0x06019DCC RID: 105932 RVA: 0x00262F67 File Offset: 0x00261167
		// (set) Token: 0x06019DCD RID: 105933 RVA: 0x00262F7B File Offset: 0x0026117B
		[Nullable(2)]
		public unsafe UStaticMesh FishMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFlockingSimulation.__PropertyOffset_FishMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFlockingSimulation.__PropertyOffset_FishMesh, value);
			}
		}

		// Token: 0x1700679A RID: 26522
		// (get) Token: 0x06019DCE RID: 105934 RVA: 0x00262F90 File Offset: 0x00261190
		// (set) Token: 0x06019DCF RID: 105935 RVA: 0x00262FA4 File Offset: 0x002611A4
		public unsafe FVector FishMeshScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_FishMeshScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_FishMeshScale) = value;
			}
		}

		// Token: 0x1700679B RID: 26523
		// (get) Token: 0x06019DD0 RID: 105936 RVA: 0x00262FBC File Offset: 0x002611BC
		// (set) Token: 0x06019DD1 RID: 105937 RVA: 0x00262FF5 File Offset: 0x002611F5
		public FKuroFishAnimSettings FishAnimSettings
		{
			get
			{
				base.FastCheckIsValid();
				FKuroFishAnimSettings result;
				if ((result = this._FishAnimSettings) == null)
				{
					result = (this._FishAnimSettings = new FKuroFishAnimSettings(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_FishAnimSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroFishAnimSettings.StaticStruct(), base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_FishAnimSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700679C RID: 26524
		// (get) Token: 0x06019DD2 RID: 105938 RVA: 0x00263016 File Offset: 0x00261216
		// (set) Token: 0x06019DD3 RID: 105939 RVA: 0x00263026 File Offset: 0x00261226
		public unsafe float FishAnimIntendedSpeedOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_FishAnimIntendedSpeedOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_FishAnimIntendedSpeedOverride) = value;
			}
		}

		// Token: 0x1700679D RID: 26525
		// (get) Token: 0x06019DD4 RID: 105940 RVA: 0x00263037 File Offset: 0x00261237
		// (set) Token: 0x06019DD5 RID: 105941 RVA: 0x00263047 File Offset: 0x00261247
		public unsafe float FishRotationSmoothSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_FishRotationSmoothSeconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_FishRotationSmoothSeconds) = value;
			}
		}

		// Token: 0x1700679E RID: 26526
		// (get) Token: 0x06019DD6 RID: 105942 RVA: 0x00263058 File Offset: 0x00261258
		// (set) Token: 0x06019DD7 RID: 105943 RVA: 0x00263068 File Offset: 0x00261268
		public unsafe float GpuSimulationRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_GpuSimulationRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_GpuSimulationRate) = value;
			}
		}

		// Token: 0x1700679F RID: 26527
		// (get) Token: 0x06019DD8 RID: 105944 RVA: 0x00263079 File Offset: 0x00261279
		// (set) Token: 0x06019DD9 RID: 105945 RVA: 0x00263089 File Offset: 0x00261289
		public unsafe bool bUseGpuDirectDraw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_bUseGpuDirectDraw) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_bUseGpuDirectDraw) = (value ? 1 : 0);
			}
		}

		// Token: 0x170067A0 RID: 26528
		// (get) Token: 0x06019DDA RID: 105946 RVA: 0x0026309A File Offset: 0x0026129A
		// (set) Token: 0x06019DDB RID: 105947 RVA: 0x002630AA File Offset: 0x002612AA
		public unsafe float DistanceFieldSafeDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_DistanceFieldSafeDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_DistanceFieldSafeDistance) = value;
			}
		}

		// Token: 0x170067A1 RID: 26529
		// (get) Token: 0x06019DDC RID: 105948 RVA: 0x002630BB File Offset: 0x002612BB
		// (set) Token: 0x06019DDD RID: 105949 RVA: 0x002630CB File Offset: 0x002612CB
		public unsafe float DistanceFieldAvoidWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_DistanceFieldAvoidWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_DistanceFieldAvoidWeight) = value;
			}
		}

		// Token: 0x170067A2 RID: 26530
		// (get) Token: 0x06019DDE RID: 105950 RVA: 0x002630DC File Offset: 0x002612DC
		// (set) Token: 0x06019DDF RID: 105951 RVA: 0x002630EC File Offset: 0x002612EC
		public unsafe float DistanceFieldStep
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_DistanceFieldStep);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_DistanceFieldStep) = value;
			}
		}

		// Token: 0x170067A3 RID: 26531
		// (get) Token: 0x06019DE0 RID: 105952 RVA: 0x002630FD File Offset: 0x002612FD
		// (set) Token: 0x06019DE1 RID: 105953 RVA: 0x0026310D File Offset: 0x0026130D
		public unsafe float DistanceFieldSampleRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_DistanceFieldSampleRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_DistanceFieldSampleRadius) = value;
			}
		}

		// Token: 0x170067A4 RID: 26532
		// (get) Token: 0x06019DE2 RID: 105954 RVA: 0x0026311E File Offset: 0x0026131E
		// (set) Token: 0x06019DE3 RID: 105955 RVA: 0x00263132 File Offset: 0x00261332
		public unsafe FVector DistanceFieldFallbackCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_DistanceFieldFallbackCenter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_DistanceFieldFallbackCenter) = value;
			}
		}

		// Token: 0x170067A5 RID: 26533
		// (get) Token: 0x06019DE4 RID: 105956 RVA: 0x00263147 File Offset: 0x00261347
		// (set) Token: 0x06019DE5 RID: 105957 RVA: 0x00263157 File Offset: 0x00261357
		public unsafe float DistanceFieldFallbackRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_DistanceFieldFallbackRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_DistanceFieldFallbackRadius) = value;
			}
		}

		// Token: 0x170067A6 RID: 26534
		// (get) Token: 0x06019DE6 RID: 105958 RVA: 0x00263168 File Offset: 0x00261368
		// (set) Token: 0x06019DE7 RID: 105959 RVA: 0x00263178 File Offset: 0x00261378
		public unsafe int FishForcedLodModel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_FishForcedLodModel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_FishForcedLodModel) = value;
			}
		}

		// Token: 0x170067A7 RID: 26535
		// (get) Token: 0x06019DE8 RID: 105960 RVA: 0x00263189 File Offset: 0x00261389
		// (set) Token: 0x06019DE9 RID: 105961 RVA: 0x0026319D File Offset: 0x0026139D
		[Nullable(2)]
		public unsafe UInstancedStaticMeshComponent FishInstancedMeshComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInstancedStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFlockingSimulation.__PropertyOffset_FishInstancedMeshComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFlockingSimulation.__PropertyOffset_FishInstancedMeshComponent, value);
			}
		}

		// Token: 0x170067A8 RID: 26536
		// (get) Token: 0x06019DEA RID: 105962 RVA: 0x002631B2 File Offset: 0x002613B2
		// (set) Token: 0x06019DEB RID: 105963 RVA: 0x002631C6 File Offset: 0x002613C6
		[Nullable(2)]
		public unsafe UKuroFlockingFishDrawComponent FishGpuDrawComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroFlockingFishDrawComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFlockingSimulation.__PropertyOffset_FishGpuDrawComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFlockingSimulation.__PropertyOffset_FishGpuDrawComponent, value);
			}
		}

		// Token: 0x170067A9 RID: 26537
		// (get) Token: 0x06019DEC RID: 105964 RVA: 0x002631DB File Offset: 0x002613DB
		// (set) Token: 0x06019DED RID: 105965 RVA: 0x002631EB File Offset: 0x002613EB
		public unsafe bool bFishMeshDrawPositionsInActorSpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_bFishMeshDrawPositionsInActorSpace) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_bFishMeshDrawPositionsInActorSpace) = (value ? 1 : 0);
			}
		}

		// Token: 0x170067AA RID: 26538
		// (get) Token: 0x06019DEE RID: 105966 RVA: 0x002631FC File Offset: 0x002613FC
		// (set) Token: 0x06019DEF RID: 105967 RVA: 0x0026320C File Offset: 0x0026140C
		public unsafe bool bGpuDirectDrawUsesActorLocalSpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_bGpuDirectDrawUsesActorLocalSpace) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_bGpuDirectDrawUsesActorLocalSpace) = (value ? 1 : 0);
			}
		}

		// Token: 0x170067AB RID: 26539
		// (get) Token: 0x06019DF0 RID: 105968 RVA: 0x0026321D File Offset: 0x0026141D
		// (set) Token: 0x06019DF1 RID: 105969 RVA: 0x0026322D File Offset: 0x0026142D
		public unsafe bool bAutoDetectActorSpaceGpuInitialSnapshot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_bAutoDetectActorSpaceGpuInitialSnapshot) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_bAutoDetectActorSpaceGpuInitialSnapshot) = (value ? 1 : 0);
			}
		}

		// Token: 0x170067AC RID: 26540
		// (get) Token: 0x06019DF2 RID: 105970 RVA: 0x0026323E File Offset: 0x0026143E
		// (set) Token: 0x06019DF3 RID: 105971 RVA: 0x0026324E File Offset: 0x0026144E
		public unsafe bool bUseAsyncFlockingRaycast
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_bUseAsyncFlockingRaycast) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_bUseAsyncFlockingRaycast) = (value ? 1 : 0);
			}
		}

		// Token: 0x170067AD RID: 26541
		// (get) Token: 0x06019DF4 RID: 105972 RVA: 0x0026325F File Offset: 0x0026145F
		// (set) Token: 0x06019DF5 RID: 105973 RVA: 0x0026326F File Offset: 0x0026146F
		public unsafe float CpuSimulationRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_CpuSimulationRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_CpuSimulationRate) = value;
			}
		}

		// Token: 0x170067AE RID: 26542
		// (get) Token: 0x06019DF6 RID: 105974 RVA: 0x00263280 File Offset: 0x00261480
		// (set) Token: 0x06019DF7 RID: 105975 RVA: 0x00263290 File Offset: 0x00261490
		public unsafe float CpuISMUpdateRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_CpuISMUpdateRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_CpuISMUpdateRate) = value;
			}
		}

		// Token: 0x170067AF RID: 26543
		// (get) Token: 0x06019DF8 RID: 105976 RVA: 0x002632A1 File Offset: 0x002614A1
		// (set) Token: 0x06019DF9 RID: 105977 RVA: 0x002632B1 File Offset: 0x002614B1
		public unsafe float FishAsyncRayAvoidSmoothRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_FishAsyncRayAvoidSmoothRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_FishAsyncRayAvoidSmoothRate) = value;
			}
		}

		// Token: 0x170067B0 RID: 26544
		// (get) Token: 0x06019DFA RID: 105978 RVA: 0x002632C2 File Offset: 0x002614C2
		// (set) Token: 0x06019DFB RID: 105979 RVA: 0x002632D2 File Offset: 0x002614D2
		public unsafe int FishAsyncRayObstacleHoldFrameCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_FishAsyncRayObstacleHoldFrameCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_FishAsyncRayObstacleHoldFrameCount) = value;
			}
		}

		// Token: 0x170067B1 RID: 26545
		// (get) Token: 0x06019DFC RID: 105980 RVA: 0x002632E4 File Offset: 0x002614E4
		// (set) Token: 0x06019DFD RID: 105981 RVA: 0x0026331D File Offset: 0x0026151D
		public TArray<float> FishInstanceStableRandom01
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._FishInstanceStableRandom01) == null)
				{
					result = (this._FishInstanceStableRandom01 = new TArray<float>(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_FishInstanceStableRandom01, this));
				}
				return result;
			}
			set
			{
				this.FishInstanceStableRandom01.CopyAssign(value);
			}
		}

		// Token: 0x170067B2 RID: 26546
		// (get) Token: 0x06019DFE RID: 105982 RVA: 0x0026332C File Offset: 0x0026152C
		// (set) Token: 0x06019DFF RID: 105983 RVA: 0x00263365 File Offset: 0x00261565
		public TArray<FVector> FishPrevVelocityForISM
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._FishPrevVelocityForISM) == null)
				{
					result = (this._FishPrevVelocityForISM = new TArray<FVector>(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_FishPrevVelocityForISM, this));
				}
				return result;
			}
			set
			{
				this.FishPrevVelocityForISM.CopyAssign(value);
			}
		}

		// Token: 0x170067B3 RID: 26547
		// (get) Token: 0x06019E00 RID: 105984 RVA: 0x00263374 File Offset: 0x00261574
		// (set) Token: 0x06019E01 RID: 105985 RVA: 0x002633AD File Offset: 0x002615AD
		public TArray<FQuat> FishPrevRotationForISM
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FQuat> result;
				if ((result = this._FishPrevRotationForISM) == null)
				{
					result = (this._FishPrevRotationForISM = new TArray<FQuat>(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_FishPrevRotationForISM, this));
				}
				return result;
			}
			set
			{
				this.FishPrevRotationForISM.CopyAssign(value);
			}
		}

		// Token: 0x170067B4 RID: 26548
		// (get) Token: 0x06019E02 RID: 105986 RVA: 0x002633BC File Offset: 0x002615BC
		// (set) Token: 0x06019E03 RID: 105987 RVA: 0x002633F5 File Offset: 0x002615F5
		public TArray<int> FishScatterCompletedCycleIndex
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._FishScatterCompletedCycleIndex) == null)
				{
					result = (this._FishScatterCompletedCycleIndex = new TArray<int>(base.NativePtr + (IntPtr)AKuroFlockingSimulation.__PropertyOffset_FishScatterCompletedCycleIndex, this));
				}
				return result;
			}
			set
			{
				this.FishScatterCompletedCycleIndex.CopyAssign(value);
			}
		}

		// Token: 0x06019E04 RID: 105988 RVA: 0x00263403 File Offset: 0x00261603
		public void SetFishForcedLodModel(int InForcedLodModel)
		{
			AKuroFlockingSimulation.__SetFishForcedLodModel_Internal(base.NativePtr, InForcedLodModel);
		}

		// Token: 0x06019E05 RID: 105989 RVA: 0x00263414 File Offset: 0x00261614
		[NullableContext(2)]
		public void FlockingSimulationGPU(AActor Actor, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FKuroFlockingData> FlockingArray, FKuroFlockingSettings FlockingSettings, FVector Target, float DeltaTime, int FrameID)
		{
			AKuroFlockingSimulation.__FlockingSimulationGPU_Internal(base.NativePtr, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, (FlockingArray ?? new TArray<FKuroFlockingData>()).NativePtr, (FlockingSettings ?? new FKuroFlockingSettings()).NativePtr, Target, DeltaTime, FrameID);
		}

		// Token: 0x06019E06 RID: 105990 RVA: 0x00263464 File Offset: 0x00261664
		[NullableContext(2)]
		public void FlockingSimulationByPlatform(AActor Actor, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FKuroFlockingData> FlockingArray, FKuroFlockingSettings FlockingSettings, FVector Target, float DeltaTime, int FrameID)
		{
			AKuroFlockingSimulation.__FlockingSimulationByPlatform_Internal(base.NativePtr, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, (FlockingArray ?? new TArray<FKuroFlockingData>()).NativePtr, (FlockingSettings ?? new FKuroFlockingSettings()).NativePtr, Target, DeltaTime, FrameID);
		}

		// Token: 0x06019E07 RID: 105991 RVA: 0x002634B4 File Offset: 0x002616B4
		[NullableContext(2)]
		public void FlockingSimulation(AActor Actor, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FKuroFlockingData> FlockingArray, FKuroFlockingSettings FlockingSettings, FVector Target, float DeltaTime, int FrameID)
		{
			AKuroFlockingSimulation.__FlockingSimulation_Internal(base.NativePtr, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, (FlockingArray ?? new TArray<FKuroFlockingData>()).NativePtr, (FlockingSettings ?? new FKuroFlockingSettings()).NativePtr, Target, DeltaTime, FrameID);
		}

		// Token: 0x06019E08 RID: 105992 RVA: 0x00263501 File Offset: 0x00261701
		public static void ApplyFlockingWorldOffsetToDataArray([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FKuroFlockingData> FlockingArray, FVector WorldOffset, bool bPositionsInActorSpace = false)
		{
			AKuroFlockingSimulation.__ApplyFlockingWorldOffsetToDataArray_Internal((FlockingArray ?? new TArray<FKuroFlockingData>()).NativePtr, WorldOffset, bPositionsInActorSpace);
		}

		// Token: 0x06019E09 RID: 105993 RVA: 0x0026351A File Offset: 0x0026171A
		public void ApplyFishMeshForcedLodSettings()
		{
			AKuroFlockingSimulation.__ApplyFishMeshForcedLodSettings_Internal(base.NativePtr);
		}

		// Token: 0x06019E0A RID: 105994
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFishForcedLodModel_Internal(IntPtr @this, int InForcedLodModel);

		// Token: 0x06019E0B RID: 105995
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FlockingSimulationGPU_Internal(IntPtr @this, IntPtr Actor, IntPtr FlockingArray, IntPtr FlockingSettings, FVector Target, float DeltaTime, int FrameID);

		// Token: 0x06019E0C RID: 105996
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FlockingSimulationByPlatform_Internal(IntPtr @this, IntPtr Actor, IntPtr FlockingArray, IntPtr FlockingSettings, FVector Target, float DeltaTime, int FrameID);

		// Token: 0x06019E0D RID: 105997
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FlockingSimulation_Internal(IntPtr @this, IntPtr Actor, IntPtr FlockingArray, IntPtr FlockingSettings, FVector Target, float DeltaTime, int FrameID);

		// Token: 0x06019E0E RID: 105998
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyFlockingWorldOffsetToDataArray_Internal(IntPtr FlockingArray, FVector WorldOffset, bool bPositionsInActorSpace);

		// Token: 0x06019E0F RID: 105999
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyFishMeshForcedLodSettings_Internal(IntPtr @this);

		// Token: 0x06019E10 RID: 106000 RVA: 0x00263527 File Offset: 0x00261727
		static AKuroFlockingSimulation()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroFlockingSimulation");
		}

		// Token: 0x06019E11 RID: 106001 RVA: 0x00263535 File Offset: 0x00261735
		protected AKuroFlockingSimulation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E0FB RID: 57595
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroFlockingSimulation";

		// Token: 0x0400E0FC RID: 57596
		private static IntPtr _ClassPtr;

		// Token: 0x0400E0FD RID: 57597
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E0FE RID: 57598
		internal static int __PropertyOffset_FishMesh;

		// Token: 0x0400E0FF RID: 57599
		internal static int __PropertyOffset_FishMeshScale;

		// Token: 0x0400E100 RID: 57600
		internal static int __PropertyOffset_FishAnimSettings;

		// Token: 0x0400E101 RID: 57601
		[Nullable(2)]
		private FKuroFishAnimSettings _FishAnimSettings;

		// Token: 0x0400E102 RID: 57602
		internal static int __PropertyOffset_FishAnimIntendedSpeedOverride;

		// Token: 0x0400E103 RID: 57603
		internal static int __PropertyOffset_FishRotationSmoothSeconds;

		// Token: 0x0400E104 RID: 57604
		internal static int __PropertyOffset_GpuSimulationRate;

		// Token: 0x0400E105 RID: 57605
		internal static int __PropertyOffset_bUseGpuDirectDraw;

		// Token: 0x0400E106 RID: 57606
		internal static int __PropertyOffset_DistanceFieldSafeDistance;

		// Token: 0x0400E107 RID: 57607
		internal static int __PropertyOffset_DistanceFieldAvoidWeight;

		// Token: 0x0400E108 RID: 57608
		internal static int __PropertyOffset_DistanceFieldStep;

		// Token: 0x0400E109 RID: 57609
		internal static int __PropertyOffset_DistanceFieldSampleRadius;

		// Token: 0x0400E10A RID: 57610
		internal static int __PropertyOffset_DistanceFieldFallbackCenter;

		// Token: 0x0400E10B RID: 57611
		internal static int __PropertyOffset_DistanceFieldFallbackRadius;

		// Token: 0x0400E10C RID: 57612
		internal static int __PropertyOffset_FishForcedLodModel;

		// Token: 0x0400E10D RID: 57613
		internal static int __PropertyOffset_FishInstancedMeshComponent;

		// Token: 0x0400E10E RID: 57614
		internal static int __PropertyOffset_FishGpuDrawComponent;

		// Token: 0x0400E10F RID: 57615
		internal static int __PropertyOffset_bFishMeshDrawPositionsInActorSpace;

		// Token: 0x0400E110 RID: 57616
		internal static int __PropertyOffset_bGpuDirectDrawUsesActorLocalSpace;

		// Token: 0x0400E111 RID: 57617
		internal static int __PropertyOffset_bAutoDetectActorSpaceGpuInitialSnapshot;

		// Token: 0x0400E112 RID: 57618
		internal static int __PropertyOffset_bUseAsyncFlockingRaycast;

		// Token: 0x0400E113 RID: 57619
		internal static int __PropertyOffset_CpuSimulationRate;

		// Token: 0x0400E114 RID: 57620
		internal static int __PropertyOffset_CpuISMUpdateRate;

		// Token: 0x0400E115 RID: 57621
		internal static int __PropertyOffset_FishAsyncRayAvoidSmoothRate;

		// Token: 0x0400E116 RID: 57622
		internal static int __PropertyOffset_FishAsyncRayObstacleHoldFrameCount;

		// Token: 0x0400E117 RID: 57623
		internal static int __PropertyOffset_FishInstanceStableRandom01;

		// Token: 0x0400E118 RID: 57624
		[Nullable(2)]
		private TArray<float> _FishInstanceStableRandom01;

		// Token: 0x0400E119 RID: 57625
		internal static int __PropertyOffset_FishPrevVelocityForISM;

		// Token: 0x0400E11A RID: 57626
		[Nullable(2)]
		private TArray<FVector> _FishPrevVelocityForISM;

		// Token: 0x0400E11B RID: 57627
		internal static int __PropertyOffset_FishPrevRotationForISM;

		// Token: 0x0400E11C RID: 57628
		[Nullable(2)]
		private TArray<FQuat> _FishPrevRotationForISM;

		// Token: 0x0400E11D RID: 57629
		internal static int __PropertyOffset_FishScatterCompletedCycleIndex;

		// Token: 0x0400E11E RID: 57630
		[Nullable(2)]
		private TArray<int> _FishScatterCompletedCycleIndex;
	}
}
