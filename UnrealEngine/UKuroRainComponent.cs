using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B97 RID: 7063
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroRainComponent")]
	[UnrealStructLayout(592, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 592)]
	public class UKuroRainComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601ADFF RID: 110079 RVA: 0x0027A221 File Offset: 0x00278421
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRainComponent._ClassPtr;
		}

		// Token: 0x0601AE00 RID: 110080 RVA: 0x0027A230 File Offset: 0x00278430
		public UKuroRainComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroRainComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601AE01 RID: 110081 RVA: 0x0027A258 File Offset: 0x00278458
		[NullableContext(1)]
		public UKuroRainComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRainComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006C52 RID: 27730
		// (get) Token: 0x0601AE02 RID: 110082 RVA: 0x0027A28B File Offset: 0x0027848B
		// (set) Token: 0x0601AE03 RID: 110083 RVA: 0x0027A29B File Offset: 0x0027849B
		public unsafe bool bAutoPlay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRainComponent.__PropertyOffset_bAutoPlay) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRainComponent.__PropertyOffset_bAutoPlay) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601AE04 RID: 110084 RVA: 0x0027A2AC File Offset: 0x002784AC
		public void Stop()
		{
			UKuroRainComponent.__Stop_Internal(base.NativePtr);
		}

		// Token: 0x0601AE05 RID: 110085 RVA: 0x0027A2B9 File Offset: 0x002784B9
		public void Start()
		{
			UKuroRainComponent.__Start_Internal(base.NativePtr);
		}

		// Token: 0x0601AE06 RID: 110086 RVA: 0x0027A2C6 File Offset: 0x002784C6
		public void SetWindProcessor(int ProcessorID, in FVector WindVelocity)
		{
			UKuroRainComponent.__SetWindProcessor_Internal(base.NativePtr, ProcessorID, WindVelocity);
		}

		// Token: 0x0601AE07 RID: 110087 RVA: 0x0027A2D5 File Offset: 0x002784D5
		public void SetVectorFieldForceProcessor_VectorField(int ProcessorID, UVectorFieldStatic InVectorField)
		{
			UKuroRainComponent.__SetVectorFieldForceProcessor_VectorField_Internal(base.NativePtr, ProcessorID, (InVectorField != null) ? InVectorField.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601AE08 RID: 110088 RVA: 0x0027A2F3 File Offset: 0x002784F3
		public void SetVectorFieldForceProcessor_Others(int ProcessorID, FVector InPosScale, FVector InMoveSpeed, float InForceSize)
		{
			UKuroRainComponent.__SetVectorFieldForceProcessor_Others_Internal(base.NativePtr, ProcessorID, InPosScale, InMoveSpeed, InForceSize);
		}

		// Token: 0x0601AE09 RID: 110089 RVA: 0x0027A305 File Offset: 0x00278505
		public virtual void SetupRainEmitters()
		{
			UKuroRainComponent.__SetupRainEmitters_Internal(base.NativePtr);
		}

		// Token: 0x0601AE0A RID: 110090 RVA: 0x0027A312 File Offset: 0x00278512
		public void Setup([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<UStaticMesh> Meshes, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<UMaterialInterface> Materials)
		{
			UKuroRainComponent.__Setup_Internal(base.NativePtr, (Meshes ?? new TArray<UStaticMesh>()).NativePtr, (Materials ?? new TArray<UMaterialInterface>()).NativePtr);
		}

		// Token: 0x0601AE0B RID: 110091 RVA: 0x0027A33F File Offset: 0x0027853F
		public void SetTimeDilation(float Dilation)
		{
			UKuroRainComponent.__SetTimeDilation_Internal(base.NativePtr, Dilation);
		}

		// Token: 0x0601AE0C RID: 110092 RVA: 0x0027A34D File Offset: 0x0027854D
		public void SetRandomSpawnerRuntime(int SpawnerID, FVector SpawnCenter, float SpawnRate, FVector VelocityMin, FVector VelocityMax)
		{
			UKuroRainComponent.__SetRandomSpawnerRuntime_Internal(base.NativePtr, SpawnerID, SpawnCenter, SpawnRate, VelocityMin, VelocityMax);
		}

		// Token: 0x0601AE0D RID: 110093 RVA: 0x0027A364 File Offset: 0x00278564
		public void SetRandomSpawnerBasic(int SpawnerID, float SpawnInnerRadius, float SpawnOuterRadius, float LifeTimeMin, float LifeTimeMax, float ScaleMin, float ScaleMax, float BaseMassMin, float BaseMassMax)
		{
			UKuroRainComponent.__SetRandomSpawnerBasic_Internal(base.NativePtr, SpawnerID, SpawnInnerRadius, SpawnOuterRadius, LifeTimeMin, LifeTimeMax, ScaleMin, ScaleMax, BaseMassMin, BaseMassMax);
		}

		// Token: 0x0601AE0E RID: 110094 RVA: 0x0027A38B File Offset: 0x0027858B
		public void SetLinearForceProcessor(int ProcessorID, in FVector Force)
		{
			UKuroRainComponent.__SetLinearForceProcessor_Internal(base.NativePtr, ProcessorID, Force);
		}

		// Token: 0x0601AE0F RID: 110095 RVA: 0x0027A39A File Offset: 0x0027859A
		public void SetLifeTimeDilation(float Dilation)
		{
			UKuroRainComponent.__SetLifeTimeDilation_Internal(base.NativePtr, Dilation);
		}

		// Token: 0x0601AE10 RID: 110096 RVA: 0x0027A3A8 File Offset: 0x002785A8
		public void SetDragProcessor(int ProcessorID, float DragSize)
		{
			UKuroRainComponent.__SetDragProcessor_Internal(base.NativePtr, ProcessorID, DragSize);
		}

		// Token: 0x0601AE11 RID: 110097 RVA: 0x0027A3B7 File Offset: 0x002785B7
		public void SetCycleBoxProcessor(int ProcessorID, FVector Min, FVector Max)
		{
			UKuroRainComponent.__SetCycleBoxProcessor_Internal(base.NativePtr, ProcessorID, Min, Max);
		}

		// Token: 0x0601AE12 RID: 110098 RVA: 0x0027A3C7 File Offset: 0x002785C7
		public void SetCustomRandomSetProcessor(int ProcessorID, float Value, int Index)
		{
			UKuroRainComponent.__SetCustomRandomSetProcessor_Internal(base.NativePtr, ProcessorID, Value, Index);
		}

		// Token: 0x0601AE13 RID: 110099 RVA: 0x0027A3D7 File Offset: 0x002785D7
		public void SetCustomRandomByVelocityProcessor(int ProcessorID, in FKuroCurveFloat Curve, int Index)
		{
			UKuroRainComponent.__SetCustomRandomByVelocityProcessor_Internal(base.NativePtr, ProcessorID, (Curve ?? new FKuroCurveFloat()).NativePtr, Index);
		}

		// Token: 0x0601AE14 RID: 110100 RVA: 0x0027A3F6 File Offset: 0x002785F6
		public void SetCustomRandomByNormalizedAgeProcessor(int ProcessorID, in FKuroCurveFloat Curve, int Index)
		{
			UKuroRainComponent.__SetCustomRandomByNormalizedAgeProcessor_Internal(base.NativePtr, ProcessorID, (Curve ?? new FKuroCurveFloat()).NativePtr, Index);
		}

		// Token: 0x0601AE15 RID: 110101 RVA: 0x0027A415 File Offset: 0x00278615
		public void SetArraySpawnerRuntime(int SpawnerID, FVector SpawnCenter, float SpawnRate, FVector VelocityMin, FVector VelocityMax)
		{
			UKuroRainComponent.__SetArraySpawnerRuntime_Internal(base.NativePtr, SpawnerID, SpawnCenter, SpawnRate, VelocityMin, VelocityMax);
		}

		// Token: 0x0601AE16 RID: 110102 RVA: 0x0027A42C File Offset: 0x0027862C
		public void SetArraySpawnerBasic(int SpawnerID, int ArraySize, float ArrayLength, float SpawnTimeWiggle, float SpawnPositionWiggle, float LifeTimeMin, float LifeTimeMax, float ScaleMin, float ScaleMax, float BaseMassMin, float BaseMassMax)
		{
			UKuroRainComponent.__SetArraySpawnerBasic_Internal(base.NativePtr, SpawnerID, ArraySize, ArrayLength, SpawnTimeWiggle, SpawnPositionWiggle, LifeTimeMin, LifeTimeMax, ScaleMin, ScaleMax, BaseMassMin, BaseMassMax);
		}

		// Token: 0x0601AE17 RID: 110103 RVA: 0x0027A457 File Offset: 0x00278657
		public virtual void PreSolveRainParticles(float DeltaSeconds)
		{
			UKuroRainComponent.__PreSolveRainParticles_Internal(base.NativePtr, DeltaSeconds);
		}

		// Token: 0x0601AE18 RID: 110104 RVA: 0x0027A465 File Offset: 0x00278665
		public void Init()
		{
			UKuroRainComponent.__Init_Internal(base.NativePtr);
		}

		// Token: 0x0601AE19 RID: 110105 RVA: 0x0027A472 File Offset: 0x00278672
		public FVector GetWindProcessor_WindVelocity(int ProcessorID)
		{
			return UKuroRainComponent.__GetWindProcessor_WindVelocity_Internal(base.NativePtr, ProcessorID);
		}

		// Token: 0x0601AE1A RID: 110106 RVA: 0x0027A480 File Offset: 0x00278680
		public FVector GetLinearForceProcessor_Force(int ProcessorID)
		{
			return UKuroRainComponent.__GetLinearForceProcessor_Force_Internal(base.NativePtr, ProcessorID);
		}

		// Token: 0x0601AE1B RID: 110107 RVA: 0x0027A48E File Offset: 0x0027868E
		public bool GetIsPlaying()
		{
			return UKuroRainComponent.__GetIsPlaying_Internal(base.NativePtr);
		}

		// Token: 0x0601AE1C RID: 110108 RVA: 0x0027A49B File Offset: 0x0027869B
		public int GetEmitterDataNum()
		{
			return UKuroRainComponent.__GetEmitterDataNum_Internal(base.NativePtr);
		}

		// Token: 0x0601AE1D RID: 110109 RVA: 0x0027A4A8 File Offset: 0x002786A8
		public float GetDragProcessor_DragSize(int ProcessorID)
		{
			return UKuroRainComponent.__GetDragProcessor_DragSize_Internal(base.NativePtr, ProcessorID);
		}

		// Token: 0x0601AE1E RID: 110110 RVA: 0x0027A4B6 File Offset: 0x002786B6
		public FVector GetCycleBoxProcessor_Min(int ProcessorID)
		{
			return UKuroRainComponent.__GetCycleBoxProcessor_Min_Internal(base.NativePtr, ProcessorID);
		}

		// Token: 0x0601AE1F RID: 110111 RVA: 0x0027A4C4 File Offset: 0x002786C4
		public FVector GetCycleBoxProcessor_Max(int ProcessorID)
		{
			return UKuroRainComponent.__GetCycleBoxProcessor_Max_Internal(base.NativePtr, ProcessorID);
		}

		// Token: 0x0601AE20 RID: 110112 RVA: 0x0027A4D2 File Offset: 0x002786D2
		public void D_SetRandomSpawnerRuntime(int SpawnerID, FVectorDouble SpawnCenter, float SpawnRate, FVector VelocityMin, FVector VelocityMax)
		{
			UKuroRainComponent.__D_SetRandomSpawnerRuntime_Internal(base.NativePtr, SpawnerID, SpawnCenter, SpawnRate, VelocityMin, VelocityMax);
		}

		// Token: 0x0601AE21 RID: 110113 RVA: 0x0027A4E6 File Offset: 0x002786E6
		public void D_SetCycleBoxProcessor(int ProcessorID, FVectorDouble Min, FVectorDouble Max)
		{
			UKuroRainComponent.__D_SetCycleBoxProcessor_Internal(base.NativePtr, ProcessorID, Min, Max);
		}

		// Token: 0x0601AE22 RID: 110114 RVA: 0x0027A4F6 File Offset: 0x002786F6
		public void D_SetArraySpawnerRuntime(int SpawnerID, FVectorDouble SpawnCenter, float SpawnRate, FVector VelocityMin, FVector VelocityMax)
		{
			UKuroRainComponent.__D_SetArraySpawnerRuntime_Internal(base.NativePtr, SpawnerID, SpawnCenter, SpawnRate, VelocityMin, VelocityMax);
		}

		// Token: 0x0601AE23 RID: 110115 RVA: 0x0027A50A File Offset: 0x0027870A
		public int AddWindProcessor(in FVector WindVelocity)
		{
			return UKuroRainComponent.__AddWindProcessor_Internal(base.NativePtr, WindVelocity);
		}

		// Token: 0x0601AE24 RID: 110116 RVA: 0x0027A518 File Offset: 0x00278718
		public int AddVectorFieldForceProcessor(UVectorFieldStatic InVectorField, FVector InPosScale, FVector InMoveSpeed, float InForceSize)
		{
			return UKuroRainComponent.__AddVectorFieldForceProcessor_Internal(base.NativePtr, (InVectorField != null) ? InVectorField.NativePtr : IntPtr.Zero, InPosScale, InMoveSpeed, InForceSize);
		}

		// Token: 0x0601AE25 RID: 110117 RVA: 0x0027A539 File Offset: 0x00278739
		public int AddRandomSpawner(int RenderIndex)
		{
			return UKuroRainComponent.__AddRandomSpawner_Internal(base.NativePtr, RenderIndex);
		}

		// Token: 0x0601AE26 RID: 110118 RVA: 0x0027A547 File Offset: 0x00278747
		public int AddLinearForceProcessor(in FVector Force)
		{
			return UKuroRainComponent.__AddLinearForceProcessor_Internal(base.NativePtr, Force);
		}

		// Token: 0x0601AE27 RID: 110119 RVA: 0x0027A555 File Offset: 0x00278755
		public int AddDragProcessor(float DragSize)
		{
			return UKuroRainComponent.__AddDragProcessor_Internal(base.NativePtr, DragSize);
		}

		// Token: 0x0601AE28 RID: 110120 RVA: 0x0027A563 File Offset: 0x00278763
		public int AddCycleBoxProcessor(FVector Min, FVector Max, bool bKillOnZ)
		{
			return UKuroRainComponent.__AddCycleBoxProcessor_Internal(base.NativePtr, Min, Max, bKillOnZ);
		}

		// Token: 0x0601AE29 RID: 110121 RVA: 0x0027A573 File Offset: 0x00278773
		public int AddCustomRandomSetProcessor(float Value, int Index)
		{
			return UKuroRainComponent.__AddCustomRandomSetProcessor_Internal(base.NativePtr, Value, Index);
		}

		// Token: 0x0601AE2A RID: 110122 RVA: 0x0027A582 File Offset: 0x00278782
		public int AddCustomRandomByVelocityProcessor(in FKuroCurveFloat Curve, int Index)
		{
			return UKuroRainComponent.__AddCustomRandomByVelocityProcessor_Internal(base.NativePtr, (Curve ?? new FKuroCurveFloat()).NativePtr, Index);
		}

		// Token: 0x0601AE2B RID: 110123 RVA: 0x0027A5A0 File Offset: 0x002787A0
		public int AddCustomRandomByNormalizedAgeProcessor(in FKuroCurveFloat Curve, int Index)
		{
			return UKuroRainComponent.__AddCustomRandomByNormalizedAgeProcessor_Internal(base.NativePtr, (Curve ?? new FKuroCurveFloat()).NativePtr, Index);
		}

		// Token: 0x0601AE2C RID: 110124 RVA: 0x0027A5BE File Offset: 0x002787BE
		public int AddArraySpawner(int RenderIndex)
		{
			return UKuroRainComponent.__AddArraySpawner_Internal(base.NativePtr, RenderIndex);
		}

		// Token: 0x0601AE2D RID: 110125
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Stop_Internal(IntPtr @this);

		// Token: 0x0601AE2E RID: 110126
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Start_Internal(IntPtr @this);

		// Token: 0x0601AE2F RID: 110127
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWindProcessor_Internal(IntPtr @this, int ProcessorID, in FVector WindVelocity);

		// Token: 0x0601AE30 RID: 110128
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVectorFieldForceProcessor_VectorField_Internal(IntPtr @this, int ProcessorID, IntPtr InVectorField);

		// Token: 0x0601AE31 RID: 110129
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVectorFieldForceProcessor_Others_Internal(IntPtr @this, int ProcessorID, FVector InPosScale, FVector InMoveSpeed, float InForceSize);

		// Token: 0x0601AE32 RID: 110130
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetupRainEmitters_Internal(IntPtr @this);

		// Token: 0x0601AE33 RID: 110131
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Setup_Internal(IntPtr @this, IntPtr Meshes, IntPtr Materials);

		// Token: 0x0601AE34 RID: 110132
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTimeDilation_Internal(IntPtr @this, float Dilation);

		// Token: 0x0601AE35 RID: 110133
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRandomSpawnerRuntime_Internal(IntPtr @this, int SpawnerID, FVector SpawnCenter, float SpawnRate, FVector VelocityMin, FVector VelocityMax);

		// Token: 0x0601AE36 RID: 110134
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRandomSpawnerBasic_Internal(IntPtr @this, int SpawnerID, float SpawnInnerRadius, float SpawnOuterRadius, float LifeTimeMin, float LifeTimeMax, float ScaleMin, float ScaleMax, float BaseMassMin, float BaseMassMax);

		// Token: 0x0601AE37 RID: 110135
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLinearForceProcessor_Internal(IntPtr @this, int ProcessorID, in FVector Force);

		// Token: 0x0601AE38 RID: 110136
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLifeTimeDilation_Internal(IntPtr @this, float Dilation);

		// Token: 0x0601AE39 RID: 110137
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDragProcessor_Internal(IntPtr @this, int ProcessorID, float DragSize);

		// Token: 0x0601AE3A RID: 110138
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCycleBoxProcessor_Internal(IntPtr @this, int ProcessorID, FVector Min, FVector Max);

		// Token: 0x0601AE3B RID: 110139
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCustomRandomSetProcessor_Internal(IntPtr @this, int ProcessorID, float Value, int Index);

		// Token: 0x0601AE3C RID: 110140
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCustomRandomByVelocityProcessor_Internal(IntPtr @this, int ProcessorID, IntPtr Curve, int Index);

		// Token: 0x0601AE3D RID: 110141
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCustomRandomByNormalizedAgeProcessor_Internal(IntPtr @this, int ProcessorID, IntPtr Curve, int Index);

		// Token: 0x0601AE3E RID: 110142
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetArraySpawnerRuntime_Internal(IntPtr @this, int SpawnerID, FVector SpawnCenter, float SpawnRate, FVector VelocityMin, FVector VelocityMax);

		// Token: 0x0601AE3F RID: 110143
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetArraySpawnerBasic_Internal(IntPtr @this, int SpawnerID, int ArraySize, float ArrayLength, float SpawnTimeWiggle, float SpawnPositionWiggle, float LifeTimeMin, float LifeTimeMax, float ScaleMin, float ScaleMax, float BaseMassMin, float BaseMassMax);

		// Token: 0x0601AE40 RID: 110144
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PreSolveRainParticles_Internal(IntPtr @this, float DeltaSeconds);

		// Token: 0x0601AE41 RID: 110145
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Init_Internal(IntPtr @this);

		// Token: 0x0601AE42 RID: 110146
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetWindProcessor_WindVelocity_Internal(IntPtr @this, int ProcessorID);

		// Token: 0x0601AE43 RID: 110147
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetLinearForceProcessor_Force_Internal(IntPtr @this, int ProcessorID);

		// Token: 0x0601AE44 RID: 110148
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetIsPlaying_Internal(IntPtr @this);

		// Token: 0x0601AE45 RID: 110149
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetEmitterDataNum_Internal(IntPtr @this);

		// Token: 0x0601AE46 RID: 110150
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetDragProcessor_DragSize_Internal(IntPtr @this, int ProcessorID);

		// Token: 0x0601AE47 RID: 110151
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetCycleBoxProcessor_Min_Internal(IntPtr @this, int ProcessorID);

		// Token: 0x0601AE48 RID: 110152
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetCycleBoxProcessor_Max_Internal(IntPtr @this, int ProcessorID);

		// Token: 0x0601AE49 RID: 110153
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_SetRandomSpawnerRuntime_Internal(IntPtr @this, int SpawnerID, FVectorDouble SpawnCenter, float SpawnRate, FVector VelocityMin, FVector VelocityMax);

		// Token: 0x0601AE4A RID: 110154
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_SetCycleBoxProcessor_Internal(IntPtr @this, int ProcessorID, FVectorDouble Min, FVectorDouble Max);

		// Token: 0x0601AE4B RID: 110155
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_SetArraySpawnerRuntime_Internal(IntPtr @this, int SpawnerID, FVectorDouble SpawnCenter, float SpawnRate, FVector VelocityMin, FVector VelocityMax);

		// Token: 0x0601AE4C RID: 110156
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __AddWindProcessor_Internal(IntPtr @this, in FVector WindVelocity);

		// Token: 0x0601AE4D RID: 110157
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __AddVectorFieldForceProcessor_Internal(IntPtr @this, IntPtr InVectorField, FVector InPosScale, FVector InMoveSpeed, float InForceSize);

		// Token: 0x0601AE4E RID: 110158
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __AddRandomSpawner_Internal(IntPtr @this, int RenderIndex);

		// Token: 0x0601AE4F RID: 110159
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __AddLinearForceProcessor_Internal(IntPtr @this, in FVector Force);

		// Token: 0x0601AE50 RID: 110160
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __AddDragProcessor_Internal(IntPtr @this, float DragSize);

		// Token: 0x0601AE51 RID: 110161
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __AddCycleBoxProcessor_Internal(IntPtr @this, FVector Min, FVector Max, bool bKillOnZ);

		// Token: 0x0601AE52 RID: 110162
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __AddCustomRandomSetProcessor_Internal(IntPtr @this, float Value, int Index);

		// Token: 0x0601AE53 RID: 110163
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __AddCustomRandomByVelocityProcessor_Internal(IntPtr @this, IntPtr Curve, int Index);

		// Token: 0x0601AE54 RID: 110164
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __AddCustomRandomByNormalizedAgeProcessor_Internal(IntPtr @this, IntPtr Curve, int Index);

		// Token: 0x0601AE55 RID: 110165
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __AddArraySpawner_Internal(IntPtr @this, int RenderIndex);

		// Token: 0x0601AE56 RID: 110166 RVA: 0x0027A5CC File Offset: 0x002787CC
		static UKuroRainComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroRainComponent");
		}

		// Token: 0x0601AE57 RID: 110167 RVA: 0x0027A5DA File Offset: 0x002787DA
		protected UKuroRainComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E8C6 RID: 59590
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroRainComponent";

		// Token: 0x0400E8C7 RID: 59591
		private static IntPtr _ClassPtr;

		// Token: 0x0400E8C8 RID: 59592
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E8C9 RID: 59593
		internal static int __PropertyOffset_bAutoPlay;

		// Token: 0x02003169 RID: 12649
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __PreSolveRainParticles_FunctionParams
		{
			// Token: 0x04016F92 RID: 94098
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
