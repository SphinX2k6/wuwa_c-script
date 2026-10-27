using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000446 RID: 1094
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ChaosNiagara.NiagaraDataInterfaceChaosDestruction")]
	[UnrealStructLayout(640, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 640)]
	public class UNiagaraDataInterfaceChaosDestruction : UNiagaraDataInterface, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003AC3 RID: 15043 RVA: 0x00058C6C File Offset: 0x00056E6C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceChaosDestruction._ClassPtr;
		}

		// Token: 0x06003AC4 RID: 15044 RVA: 0x00058C78 File Offset: 0x00056E78
		public UNiagaraDataInterfaceChaosDestruction() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceChaosDestruction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003AC5 RID: 15045 RVA: 0x00058CA0 File Offset: 0x00056EA0
		public UNiagaraDataInterfaceChaosDestruction(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceChaosDestruction.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000E16 RID: 3606
		// (get) Token: 0x06003AC6 RID: 15046 RVA: 0x00058CD4 File Offset: 0x00056ED4
		// (set) Token: 0x06003AC7 RID: 15047 RVA: 0x00058D0D File Offset: 0x00056F0D
		public TSet<AChaosSolverActor> ChaosSolverActorSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<AChaosSolverActor> result;
				if ((result = this._ChaosSolverActorSet) == null)
				{
					result = (this._ChaosSolverActorSet = new TSet<AChaosSolverActor>(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_ChaosSolverActorSet, this));
				}
				return result;
			}
			set
			{
				this.ChaosSolverActorSet.CopyAssign(value);
			}
		}

		// Token: 0x17000E17 RID: 3607
		// (get) Token: 0x06003AC8 RID: 15048 RVA: 0x00058D1B File Offset: 0x00056F1B
		// (set) Token: 0x06003AC9 RID: 15049 RVA: 0x00058D2B File Offset: 0x00056F2B
		public unsafe EDataSourceTypeEnum DataSourceType
		{
			get
			{
				return (EDataSourceTypeEnum)(*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_DataSourceType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_DataSourceType) = (byte)value;
			}
		}

		// Token: 0x17000E18 RID: 3608
		// (get) Token: 0x06003ACA RID: 15050 RVA: 0x00058D3C File Offset: 0x00056F3C
		// (set) Token: 0x06003ACB RID: 15051 RVA: 0x00058D4C File Offset: 0x00056F4C
		public unsafe int DataProcessFrequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_DataProcessFrequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_DataProcessFrequency) = value;
			}
		}

		// Token: 0x17000E19 RID: 3609
		// (get) Token: 0x06003ACC RID: 15052 RVA: 0x00058D5D File Offset: 0x00056F5D
		// (set) Token: 0x06003ACD RID: 15053 RVA: 0x00058D6D File Offset: 0x00056F6D
		public unsafe int MaxNumberOfDataEntriesToSpawn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_MaxNumberOfDataEntriesToSpawn);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_MaxNumberOfDataEntriesToSpawn) = value;
			}
		}

		// Token: 0x17000E1A RID: 3610
		// (get) Token: 0x06003ACE RID: 15054 RVA: 0x00058D7E File Offset: 0x00056F7E
		// (set) Token: 0x06003ACF RID: 15055 RVA: 0x00058D8E File Offset: 0x00056F8E
		public unsafe bool DoSpawn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_DoSpawn) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_DoSpawn) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000E1B RID: 3611
		// (get) Token: 0x06003AD0 RID: 15056 RVA: 0x00058D9F File Offset: 0x00056F9F
		// (set) Token: 0x06003AD1 RID: 15057 RVA: 0x00058DB3 File Offset: 0x00056FB3
		public unsafe FVector2D SpawnMultiplierMinMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_SpawnMultiplierMinMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_SpawnMultiplierMinMax) = value;
			}
		}

		// Token: 0x17000E1C RID: 3612
		// (get) Token: 0x06003AD2 RID: 15058 RVA: 0x00058DC8 File Offset: 0x00056FC8
		// (set) Token: 0x06003AD3 RID: 15059 RVA: 0x00058DD8 File Offset: 0x00056FD8
		public unsafe float SpawnChance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_SpawnChance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_SpawnChance) = value;
			}
		}

		// Token: 0x17000E1D RID: 3613
		// (get) Token: 0x06003AD4 RID: 15060 RVA: 0x00058DE9 File Offset: 0x00056FE9
		// (set) Token: 0x06003AD5 RID: 15061 RVA: 0x00058DFD File Offset: 0x00056FFD
		public unsafe FVector2D ImpulseToSpawnMinMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_ImpulseToSpawnMinMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_ImpulseToSpawnMinMax) = value;
			}
		}

		// Token: 0x17000E1E RID: 3614
		// (get) Token: 0x06003AD6 RID: 15062 RVA: 0x00058E12 File Offset: 0x00057012
		// (set) Token: 0x06003AD7 RID: 15063 RVA: 0x00058E26 File Offset: 0x00057026
		public unsafe FVector2D SpeedToSpawnMinMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_SpeedToSpawnMinMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_SpeedToSpawnMinMax) = value;
			}
		}

		// Token: 0x17000E1F RID: 3615
		// (get) Token: 0x06003AD8 RID: 15064 RVA: 0x00058E3B File Offset: 0x0005703B
		// (set) Token: 0x06003AD9 RID: 15065 RVA: 0x00058E4F File Offset: 0x0005704F
		public unsafe FVector2D MassToSpawnMinMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_MassToSpawnMinMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_MassToSpawnMinMax) = value;
			}
		}

		// Token: 0x17000E20 RID: 3616
		// (get) Token: 0x06003ADA RID: 15066 RVA: 0x00058E64 File Offset: 0x00057064
		// (set) Token: 0x06003ADB RID: 15067 RVA: 0x00058E78 File Offset: 0x00057078
		public unsafe FVector2D ExtentMinToSpawnMinMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_ExtentMinToSpawnMinMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_ExtentMinToSpawnMinMax) = value;
			}
		}

		// Token: 0x17000E21 RID: 3617
		// (get) Token: 0x06003ADC RID: 15068 RVA: 0x00058E8D File Offset: 0x0005708D
		// (set) Token: 0x06003ADD RID: 15069 RVA: 0x00058EA1 File Offset: 0x000570A1
		public unsafe FVector2D ExtentMaxToSpawnMinMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_ExtentMaxToSpawnMinMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_ExtentMaxToSpawnMinMax) = value;
			}
		}

		// Token: 0x17000E22 RID: 3618
		// (get) Token: 0x06003ADE RID: 15070 RVA: 0x00058EB6 File Offset: 0x000570B6
		// (set) Token: 0x06003ADF RID: 15071 RVA: 0x00058ECA File Offset: 0x000570CA
		public unsafe FVector2D VolumeToSpawnMinMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_VolumeToSpawnMinMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_VolumeToSpawnMinMax) = value;
			}
		}

		// Token: 0x17000E23 RID: 3619
		// (get) Token: 0x06003AE0 RID: 15072 RVA: 0x00058EDF File Offset: 0x000570DF
		// (set) Token: 0x06003AE1 RID: 15073 RVA: 0x00058EF3 File Offset: 0x000570F3
		public unsafe FVector2D SolverTimeToSpawnMinMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_SolverTimeToSpawnMinMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_SolverTimeToSpawnMinMax) = value;
			}
		}

		// Token: 0x17000E24 RID: 3620
		// (get) Token: 0x06003AE2 RID: 15074 RVA: 0x00058F08 File Offset: 0x00057108
		// (set) Token: 0x06003AE3 RID: 15075 RVA: 0x00058F18 File Offset: 0x00057118
		public unsafe int SurfaceTypeToSpawn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_SurfaceTypeToSpawn);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_SurfaceTypeToSpawn) = value;
			}
		}

		// Token: 0x17000E25 RID: 3621
		// (get) Token: 0x06003AE4 RID: 15076 RVA: 0x00058F29 File Offset: 0x00057129
		// (set) Token: 0x06003AE5 RID: 15077 RVA: 0x00058F39 File Offset: 0x00057139
		public unsafe ELocationFilteringModeEnum LocationFilteringMode
		{
			get
			{
				return (ELocationFilteringModeEnum)(*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_LocationFilteringMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_LocationFilteringMode) = (byte)value;
			}
		}

		// Token: 0x17000E26 RID: 3622
		// (get) Token: 0x06003AE6 RID: 15078 RVA: 0x00058F4A File Offset: 0x0005714A
		// (set) Token: 0x06003AE7 RID: 15079 RVA: 0x00058F5A File Offset: 0x0005715A
		public unsafe ELocationXToSpawnEnum LocationXToSpawn
		{
			get
			{
				return (ELocationXToSpawnEnum)(*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_LocationXToSpawn));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_LocationXToSpawn) = (byte)value;
			}
		}

		// Token: 0x17000E27 RID: 3623
		// (get) Token: 0x06003AE8 RID: 15080 RVA: 0x00058F6B File Offset: 0x0005716B
		// (set) Token: 0x06003AE9 RID: 15081 RVA: 0x00058F7F File Offset: 0x0005717F
		public unsafe FVector2D LocationXToSpawnMinMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_LocationXToSpawnMinMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_LocationXToSpawnMinMax) = value;
			}
		}

		// Token: 0x17000E28 RID: 3624
		// (get) Token: 0x06003AEA RID: 15082 RVA: 0x00058F94 File Offset: 0x00057194
		// (set) Token: 0x06003AEB RID: 15083 RVA: 0x00058FA4 File Offset: 0x000571A4
		public unsafe ELocationYToSpawnEnum LocationYToSpawn
		{
			get
			{
				return (ELocationYToSpawnEnum)(*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_LocationYToSpawn));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_LocationYToSpawn) = (byte)value;
			}
		}

		// Token: 0x17000E29 RID: 3625
		// (get) Token: 0x06003AEC RID: 15084 RVA: 0x00058FB5 File Offset: 0x000571B5
		// (set) Token: 0x06003AED RID: 15085 RVA: 0x00058FC9 File Offset: 0x000571C9
		public unsafe FVector2D LocationYToSpawnMinMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_LocationYToSpawnMinMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_LocationYToSpawnMinMax) = value;
			}
		}

		// Token: 0x17000E2A RID: 3626
		// (get) Token: 0x06003AEE RID: 15086 RVA: 0x00058FDE File Offset: 0x000571DE
		// (set) Token: 0x06003AEF RID: 15087 RVA: 0x00058FEE File Offset: 0x000571EE
		public unsafe ELocationZToSpawnEnum LocationZToSpawn
		{
			get
			{
				return (ELocationZToSpawnEnum)(*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_LocationZToSpawn));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_LocationZToSpawn) = (byte)value;
			}
		}

		// Token: 0x17000E2B RID: 3627
		// (get) Token: 0x06003AF0 RID: 15088 RVA: 0x00058FFF File Offset: 0x000571FF
		// (set) Token: 0x06003AF1 RID: 15089 RVA: 0x00059013 File Offset: 0x00057213
		public unsafe FVector2D LocationZToSpawnMinMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_LocationZToSpawnMinMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_LocationZToSpawnMinMax) = value;
			}
		}

		// Token: 0x17000E2C RID: 3628
		// (get) Token: 0x06003AF2 RID: 15090 RVA: 0x00059028 File Offset: 0x00057228
		// (set) Token: 0x06003AF3 RID: 15091 RVA: 0x00059038 File Offset: 0x00057238
		public unsafe EDataSortTypeEnum DataSortingType
		{
			get
			{
				return (EDataSortTypeEnum)(*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_DataSortingType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_DataSortingType) = (byte)value;
			}
		}

		// Token: 0x17000E2D RID: 3629
		// (get) Token: 0x06003AF4 RID: 15092 RVA: 0x00059049 File Offset: 0x00057249
		// (set) Token: 0x06003AF5 RID: 15093 RVA: 0x00059059 File Offset: 0x00057259
		public unsafe bool bGetExternalCollisionData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_bGetExternalCollisionData) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_bGetExternalCollisionData) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000E2E RID: 3630
		// (get) Token: 0x06003AF6 RID: 15094 RVA: 0x0005906A File Offset: 0x0005726A
		// (set) Token: 0x06003AF7 RID: 15095 RVA: 0x0005907A File Offset: 0x0005727A
		public unsafe bool DoSpatialHash
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_DoSpatialHash) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_DoSpatialHash) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000E2F RID: 3631
		// (get) Token: 0x06003AF8 RID: 15096 RVA: 0x0005908B File Offset: 0x0005728B
		// (set) Token: 0x06003AF9 RID: 15097 RVA: 0x0005909F File Offset: 0x0005729F
		public unsafe FVector SpatialHashVolumeMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_SpatialHashVolumeMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_SpatialHashVolumeMin) = value;
			}
		}

		// Token: 0x17000E30 RID: 3632
		// (get) Token: 0x06003AFA RID: 15098 RVA: 0x000590B4 File Offset: 0x000572B4
		// (set) Token: 0x06003AFB RID: 15099 RVA: 0x000590C8 File Offset: 0x000572C8
		public unsafe FVector SpatialHashVolumeMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_SpatialHashVolumeMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_SpatialHashVolumeMax) = value;
			}
		}

		// Token: 0x17000E31 RID: 3633
		// (get) Token: 0x06003AFC RID: 15100 RVA: 0x000590DD File Offset: 0x000572DD
		// (set) Token: 0x06003AFD RID: 15101 RVA: 0x000590F1 File Offset: 0x000572F1
		public unsafe FVector SpatialHashVolumeCellSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_SpatialHashVolumeCellSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_SpatialHashVolumeCellSize) = value;
			}
		}

		// Token: 0x17000E32 RID: 3634
		// (get) Token: 0x06003AFE RID: 15102 RVA: 0x00059106 File Offset: 0x00057306
		// (set) Token: 0x06003AFF RID: 15103 RVA: 0x00059116 File Offset: 0x00057316
		public unsafe int MaxDataPerCell
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_MaxDataPerCell);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_MaxDataPerCell) = value;
			}
		}

		// Token: 0x17000E33 RID: 3635
		// (get) Token: 0x06003B00 RID: 15104 RVA: 0x00059127 File Offset: 0x00057327
		// (set) Token: 0x06003B01 RID: 15105 RVA: 0x00059137 File Offset: 0x00057337
		public unsafe bool bApplyMaterialsFilter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_bApplyMaterialsFilter) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_bApplyMaterialsFilter) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000E34 RID: 3636
		// (get) Token: 0x06003B02 RID: 15106 RVA: 0x00059148 File Offset: 0x00057348
		// (set) Token: 0x06003B03 RID: 15107 RVA: 0x00059181 File Offset: 0x00057381
		public TSet<UPhysicalMaterial> ChaosBreakingMaterialSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<UPhysicalMaterial> result;
				if ((result = this._ChaosBreakingMaterialSet) == null)
				{
					result = (this._ChaosBreakingMaterialSet = new TSet<UPhysicalMaterial>(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_ChaosBreakingMaterialSet, this));
				}
				return result;
			}
			set
			{
				this.ChaosBreakingMaterialSet.CopyAssign(value);
			}
		}

		// Token: 0x17000E35 RID: 3637
		// (get) Token: 0x06003B04 RID: 15108 RVA: 0x0005918F File Offset: 0x0005738F
		// (set) Token: 0x06003B05 RID: 15109 RVA: 0x0005919F File Offset: 0x0005739F
		public unsafe bool bGetExternalBreakingData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_bGetExternalBreakingData) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_bGetExternalBreakingData) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000E36 RID: 3638
		// (get) Token: 0x06003B06 RID: 15110 RVA: 0x000591B0 File Offset: 0x000573B0
		// (set) Token: 0x06003B07 RID: 15111 RVA: 0x000591C0 File Offset: 0x000573C0
		public unsafe bool bGetExternalTrailingData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_bGetExternalTrailingData) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_bGetExternalTrailingData) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000E37 RID: 3639
		// (get) Token: 0x06003B08 RID: 15112 RVA: 0x000591D1 File Offset: 0x000573D1
		// (set) Token: 0x06003B09 RID: 15113 RVA: 0x000591E5 File Offset: 0x000573E5
		public unsafe FVector2D RandomPositionMagnitudeMinMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_RandomPositionMagnitudeMinMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_RandomPositionMagnitudeMinMax) = value;
			}
		}

		// Token: 0x17000E38 RID: 3640
		// (get) Token: 0x06003B0A RID: 15114 RVA: 0x000591FA File Offset: 0x000573FA
		// (set) Token: 0x06003B0B RID: 15115 RVA: 0x0005920A File Offset: 0x0005740A
		public unsafe float InheritedVelocityMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_InheritedVelocityMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_InheritedVelocityMultiplier) = value;
			}
		}

		// Token: 0x17000E39 RID: 3641
		// (get) Token: 0x06003B0C RID: 15116 RVA: 0x0005921B File Offset: 0x0005741B
		// (set) Token: 0x06003B0D RID: 15117 RVA: 0x0005922B File Offset: 0x0005742B
		public unsafe ERandomVelocityGenerationTypeEnum RandomVelocityGenerationType
		{
			get
			{
				return (ERandomVelocityGenerationTypeEnum)(*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_RandomVelocityGenerationType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_RandomVelocityGenerationType) = (byte)value;
			}
		}

		// Token: 0x17000E3A RID: 3642
		// (get) Token: 0x06003B0E RID: 15118 RVA: 0x0005923C File Offset: 0x0005743C
		// (set) Token: 0x06003B0F RID: 15119 RVA: 0x00059250 File Offset: 0x00057450
		public unsafe FVector2D RandomVelocityMagnitudeMinMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_RandomVelocityMagnitudeMinMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_RandomVelocityMagnitudeMinMax) = value;
			}
		}

		// Token: 0x17000E3B RID: 3643
		// (get) Token: 0x06003B10 RID: 15120 RVA: 0x00059265 File Offset: 0x00057465
		// (set) Token: 0x06003B11 RID: 15121 RVA: 0x00059275 File Offset: 0x00057475
		public unsafe float SpreadAngleMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_SpreadAngleMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_SpreadAngleMax) = value;
			}
		}

		// Token: 0x17000E3C RID: 3644
		// (get) Token: 0x06003B12 RID: 15122 RVA: 0x00059286 File Offset: 0x00057486
		// (set) Token: 0x06003B13 RID: 15123 RVA: 0x0005929A File Offset: 0x0005749A
		public unsafe FVector VelocityOffsetMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_VelocityOffsetMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_VelocityOffsetMin) = value;
			}
		}

		// Token: 0x17000E3D RID: 3645
		// (get) Token: 0x06003B14 RID: 15124 RVA: 0x000592AF File Offset: 0x000574AF
		// (set) Token: 0x06003B15 RID: 15125 RVA: 0x000592C3 File Offset: 0x000574C3
		public unsafe FVector VelocityOffsetMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_VelocityOffsetMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_VelocityOffsetMax) = value;
			}
		}

		// Token: 0x17000E3E RID: 3646
		// (get) Token: 0x06003B16 RID: 15126 RVA: 0x000592D8 File Offset: 0x000574D8
		// (set) Token: 0x06003B17 RID: 15127 RVA: 0x000592EC File Offset: 0x000574EC
		public unsafe FVector2D FinalVelocityMagnitudeMinMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_FinalVelocityMagnitudeMinMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_FinalVelocityMagnitudeMinMax) = value;
			}
		}

		// Token: 0x17000E3F RID: 3647
		// (get) Token: 0x06003B18 RID: 15128 RVA: 0x00059301 File Offset: 0x00057501
		// (set) Token: 0x06003B19 RID: 15129 RVA: 0x00059311 File Offset: 0x00057511
		public unsafe float MaxLatency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_MaxLatency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_MaxLatency) = value;
			}
		}

		// Token: 0x17000E40 RID: 3648
		// (get) Token: 0x06003B1A RID: 15130 RVA: 0x00059322 File Offset: 0x00057522
		// (set) Token: 0x06003B1B RID: 15131 RVA: 0x00059332 File Offset: 0x00057532
		public unsafe EDebugTypeEnum DebugType
		{
			get
			{
				return (EDebugTypeEnum)(*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_DebugType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_DebugType) = (byte)value;
			}
		}

		// Token: 0x17000E41 RID: 3649
		// (get) Token: 0x06003B1C RID: 15132 RVA: 0x00059343 File Offset: 0x00057543
		// (set) Token: 0x06003B1D RID: 15133 RVA: 0x00059353 File Offset: 0x00057553
		public unsafe int LastSpawnedPointID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_LastSpawnedPointID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_LastSpawnedPointID) = value;
			}
		}

		// Token: 0x17000E42 RID: 3650
		// (get) Token: 0x06003B1E RID: 15134 RVA: 0x00059364 File Offset: 0x00057564
		// (set) Token: 0x06003B1F RID: 15135 RVA: 0x00059374 File Offset: 0x00057574
		public unsafe float LastSpawnTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_LastSpawnTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_LastSpawnTime) = value;
			}
		}

		// Token: 0x17000E43 RID: 3651
		// (get) Token: 0x06003B20 RID: 15136 RVA: 0x00059385 File Offset: 0x00057585
		// (set) Token: 0x06003B21 RID: 15137 RVA: 0x00059395 File Offset: 0x00057595
		public unsafe float SolverTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_SolverTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_SolverTime) = value;
			}
		}

		// Token: 0x17000E44 RID: 3652
		// (get) Token: 0x06003B22 RID: 15138 RVA: 0x000593A6 File Offset: 0x000575A6
		// (set) Token: 0x06003B23 RID: 15139 RVA: 0x000593B6 File Offset: 0x000575B6
		public unsafe float TimeStampOfLastProcessedData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_TimeStampOfLastProcessedData);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceChaosDestruction.__PropertyOffset_TimeStampOfLastProcessedData) = value;
			}
		}

		// Token: 0x06003B24 RID: 15140 RVA: 0x000593C7 File Offset: 0x000575C7
		static UNiagaraDataInterfaceChaosDestruction()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ChaosNiagara.NiagaraDataInterfaceChaosDestruction");
		}

		// Token: 0x06003B25 RID: 15141 RVA: 0x000593D5 File Offset: 0x000575D5
		protected UNiagaraDataInterfaceChaosDestruction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001B05 RID: 6917
		public new const string __ObjectPath = "/Script/ChaosNiagara.NiagaraDataInterfaceChaosDestruction";

		// Token: 0x04001B06 RID: 6918
		private static IntPtr _ClassPtr;

		// Token: 0x04001B07 RID: 6919
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001B08 RID: 6920
		internal static int __PropertyOffset_ChaosSolverActorSet;

		// Token: 0x04001B09 RID: 6921
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<AChaosSolverActor> _ChaosSolverActorSet;

		// Token: 0x04001B0A RID: 6922
		internal static int __PropertyOffset_DataSourceType;

		// Token: 0x04001B0B RID: 6923
		internal static int __PropertyOffset_DataProcessFrequency;

		// Token: 0x04001B0C RID: 6924
		internal static int __PropertyOffset_MaxNumberOfDataEntriesToSpawn;

		// Token: 0x04001B0D RID: 6925
		internal static int __PropertyOffset_DoSpawn;

		// Token: 0x04001B0E RID: 6926
		internal static int __PropertyOffset_SpawnMultiplierMinMax;

		// Token: 0x04001B0F RID: 6927
		internal static int __PropertyOffset_SpawnChance;

		// Token: 0x04001B10 RID: 6928
		internal static int __PropertyOffset_ImpulseToSpawnMinMax;

		// Token: 0x04001B11 RID: 6929
		internal static int __PropertyOffset_SpeedToSpawnMinMax;

		// Token: 0x04001B12 RID: 6930
		internal static int __PropertyOffset_MassToSpawnMinMax;

		// Token: 0x04001B13 RID: 6931
		internal static int __PropertyOffset_ExtentMinToSpawnMinMax;

		// Token: 0x04001B14 RID: 6932
		internal static int __PropertyOffset_ExtentMaxToSpawnMinMax;

		// Token: 0x04001B15 RID: 6933
		internal static int __PropertyOffset_VolumeToSpawnMinMax;

		// Token: 0x04001B16 RID: 6934
		internal static int __PropertyOffset_SolverTimeToSpawnMinMax;

		// Token: 0x04001B17 RID: 6935
		internal static int __PropertyOffset_SurfaceTypeToSpawn;

		// Token: 0x04001B18 RID: 6936
		internal static int __PropertyOffset_LocationFilteringMode;

		// Token: 0x04001B19 RID: 6937
		internal static int __PropertyOffset_LocationXToSpawn;

		// Token: 0x04001B1A RID: 6938
		internal static int __PropertyOffset_LocationXToSpawnMinMax;

		// Token: 0x04001B1B RID: 6939
		internal static int __PropertyOffset_LocationYToSpawn;

		// Token: 0x04001B1C RID: 6940
		internal static int __PropertyOffset_LocationYToSpawnMinMax;

		// Token: 0x04001B1D RID: 6941
		internal static int __PropertyOffset_LocationZToSpawn;

		// Token: 0x04001B1E RID: 6942
		internal static int __PropertyOffset_LocationZToSpawnMinMax;

		// Token: 0x04001B1F RID: 6943
		internal static int __PropertyOffset_DataSortingType;

		// Token: 0x04001B20 RID: 6944
		internal static int __PropertyOffset_bGetExternalCollisionData;

		// Token: 0x04001B21 RID: 6945
		internal static int __PropertyOffset_DoSpatialHash;

		// Token: 0x04001B22 RID: 6946
		internal static int __PropertyOffset_SpatialHashVolumeMin;

		// Token: 0x04001B23 RID: 6947
		internal static int __PropertyOffset_SpatialHashVolumeMax;

		// Token: 0x04001B24 RID: 6948
		internal static int __PropertyOffset_SpatialHashVolumeCellSize;

		// Token: 0x04001B25 RID: 6949
		internal static int __PropertyOffset_MaxDataPerCell;

		// Token: 0x04001B26 RID: 6950
		internal static int __PropertyOffset_bApplyMaterialsFilter;

		// Token: 0x04001B27 RID: 6951
		internal static int __PropertyOffset_ChaosBreakingMaterialSet;

		// Token: 0x04001B28 RID: 6952
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UPhysicalMaterial> _ChaosBreakingMaterialSet;

		// Token: 0x04001B29 RID: 6953
		internal static int __PropertyOffset_bGetExternalBreakingData;

		// Token: 0x04001B2A RID: 6954
		internal static int __PropertyOffset_bGetExternalTrailingData;

		// Token: 0x04001B2B RID: 6955
		internal static int __PropertyOffset_RandomPositionMagnitudeMinMax;

		// Token: 0x04001B2C RID: 6956
		internal static int __PropertyOffset_InheritedVelocityMultiplier;

		// Token: 0x04001B2D RID: 6957
		internal static int __PropertyOffset_RandomVelocityGenerationType;

		// Token: 0x04001B2E RID: 6958
		internal static int __PropertyOffset_RandomVelocityMagnitudeMinMax;

		// Token: 0x04001B2F RID: 6959
		internal static int __PropertyOffset_SpreadAngleMax;

		// Token: 0x04001B30 RID: 6960
		internal static int __PropertyOffset_VelocityOffsetMin;

		// Token: 0x04001B31 RID: 6961
		internal static int __PropertyOffset_VelocityOffsetMax;

		// Token: 0x04001B32 RID: 6962
		internal static int __PropertyOffset_FinalVelocityMagnitudeMinMax;

		// Token: 0x04001B33 RID: 6963
		internal static int __PropertyOffset_MaxLatency;

		// Token: 0x04001B34 RID: 6964
		internal static int __PropertyOffset_DebugType;

		// Token: 0x04001B35 RID: 6965
		internal static int __PropertyOffset_LastSpawnedPointID;

		// Token: 0x04001B36 RID: 6966
		internal static int __PropertyOffset_LastSpawnTime;

		// Token: 0x04001B37 RID: 6967
		internal static int __PropertyOffset_SolverTime;

		// Token: 0x04001B38 RID: 6968
		internal static int __PropertyOffset_TimeStampOfLastProcessedData;
	}
}
