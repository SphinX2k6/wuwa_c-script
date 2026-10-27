using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BB6 RID: 7094
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroSeasonsManager")]
	[UnrealStructLayout(1800, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1800)]
	public class AKuroSeasonsManager : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B245 RID: 111173 RVA: 0x0027FE8C File Offset: 0x0027E08C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroSeasonsManager._ClassPtr;
		}

		// Token: 0x0601B246 RID: 111174 RVA: 0x0027FE98 File Offset: 0x0027E098
		public AKuroSeasonsManager() : this(BuiltinUtils.AllocNativeUObject(AKuroSeasonsManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B247 RID: 111175 RVA: 0x0027FEC0 File Offset: 0x0027E0C0
		public AKuroSeasonsManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroSeasonsManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006CDA RID: 27866
		// (get) Token: 0x0601B248 RID: 111176 RVA: 0x0027FEF3 File Offset: 0x0027E0F3
		// (set) Token: 0x0601B249 RID: 111177 RVA: 0x0027FF07 File Offset: 0x0027E107
		[Nullable(2)]
		public unsafe UBoxComponent Box
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroSeasonsManager.__PropertyOffset_Box);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroSeasonsManager.__PropertyOffset_Box, value);
			}
		}

		// Token: 0x17006CDB RID: 27867
		// (get) Token: 0x0601B24A RID: 111178 RVA: 0x0027FF1C File Offset: 0x0027E11C
		// (set) Token: 0x0601B24B RID: 111179 RVA: 0x0027FF2C File Offset: 0x0027E12C
		public unsafe float CellSizeOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSeasonsManager.__PropertyOffset_CellSizeOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSeasonsManager.__PropertyOffset_CellSizeOverride) = value;
			}
		}

		// Token: 0x17006CDC RID: 27868
		// (get) Token: 0x0601B24C RID: 111180 RVA: 0x0027FF3D File Offset: 0x0027E13D
		// (set) Token: 0x0601B24D RID: 111181 RVA: 0x0027FF51 File Offset: 0x0027E151
		[Nullable(2)]
		public unsafe UNiagaraSystem SharedNiagaraSystem
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroSeasonsManager.__PropertyOffset_SharedNiagaraSystem);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroSeasonsManager.__PropertyOffset_SharedNiagaraSystem, value);
			}
		}

		// Token: 0x17006CDD RID: 27869
		// (get) Token: 0x0601B24E RID: 111182 RVA: 0x0027FF66 File Offset: 0x0027E166
		// (set) Token: 0x0601B24F RID: 111183 RVA: 0x0027FF7A File Offset: 0x0027E17A
		[Nullable(2)]
		public unsafe UKuroSeasonsTreeNiagaraParamsAsset ParamsAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroSeasonsTreeNiagaraParamsAsset>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroSeasonsManager.__PropertyOffset_ParamsAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroSeasonsManager.__PropertyOffset_ParamsAsset, value);
			}
		}

		// Token: 0x17006CDE RID: 27870
		// (get) Token: 0x0601B250 RID: 111184 RVA: 0x0027FF8F File Offset: 0x0027E18F
		// (set) Token: 0x0601B251 RID: 111185 RVA: 0x0027FF9F File Offset: 0x0027E19F
		public unsafe float SpawnInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSeasonsManager.__PropertyOffset_SpawnInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSeasonsManager.__PropertyOffset_SpawnInterval) = value;
			}
		}

		// Token: 0x17006CDF RID: 27871
		// (get) Token: 0x0601B252 RID: 111186 RVA: 0x0027FFB0 File Offset: 0x0027E1B0
		// (set) Token: 0x0601B253 RID: 111187 RVA: 0x0027FFC0 File Offset: 0x0027E1C0
		public unsafe int SpawnsPerFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSeasonsManager.__PropertyOffset_SpawnsPerFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSeasonsManager.__PropertyOffset_SpawnsPerFrame) = value;
			}
		}

		// Token: 0x17006CE0 RID: 27872
		// (get) Token: 0x0601B254 RID: 111188 RVA: 0x0027FFD4 File Offset: 0x0027E1D4
		// (set) Token: 0x0601B255 RID: 111189 RVA: 0x0028000D File Offset: 0x0027E20D
		public TArray<FVectorDouble> BakedPoints
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVectorDouble> result;
				if ((result = this._BakedPoints) == null)
				{
					result = (this._BakedPoints = new TArray<FVectorDouble>(base.NativePtr + (IntPtr)AKuroSeasonsManager.__PropertyOffset_BakedPoints, this));
				}
				return result;
			}
			set
			{
				this.BakedPoints.CopyAssign(value);
			}
		}

		// Token: 0x17006CE1 RID: 27873
		// (get) Token: 0x0601B256 RID: 111190 RVA: 0x0028001C File Offset: 0x0027E21C
		// (set) Token: 0x0601B257 RID: 111191 RVA: 0x00280055 File Offset: 0x0027E255
		public TArray<UStaticMesh> BakedMeshes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMesh> result;
				if ((result = this._BakedMeshes) == null)
				{
					result = (this._BakedMeshes = new TArray<UStaticMesh>(base.NativePtr + (IntPtr)AKuroSeasonsManager.__PropertyOffset_BakedMeshes, this));
				}
				return result;
			}
			set
			{
				this.BakedMeshes.CopyAssign(value);
			}
		}

		// Token: 0x17006CE2 RID: 27874
		// (get) Token: 0x0601B258 RID: 111192 RVA: 0x00280064 File Offset: 0x0027E264
		// (set) Token: 0x0601B259 RID: 111193 RVA: 0x0028009D File Offset: 0x0027E29D
		public TArray<FRotator> BakedRotations
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRotator> result;
				if ((result = this._BakedRotations) == null)
				{
					result = (this._BakedRotations = new TArray<FRotator>(base.NativePtr + (IntPtr)AKuroSeasonsManager.__PropertyOffset_BakedRotations, this));
				}
				return result;
			}
			set
			{
				this.BakedRotations.CopyAssign(value);
			}
		}

		// Token: 0x17006CE3 RID: 27875
		// (get) Token: 0x0601B25A RID: 111194 RVA: 0x002800AC File Offset: 0x0027E2AC
		// (set) Token: 0x0601B25B RID: 111195 RVA: 0x002800E5 File Offset: 0x0027E2E5
		public TArray<FVector> BakedScales
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._BakedScales) == null)
				{
					result = (this._BakedScales = new TArray<FVector>(base.NativePtr + (IntPtr)AKuroSeasonsManager.__PropertyOffset_BakedScales, this));
				}
				return result;
			}
			set
			{
				this.BakedScales.CopyAssign(value);
			}
		}

		// Token: 0x17006CE4 RID: 27876
		// (get) Token: 0x0601B25C RID: 111196 RVA: 0x002800F4 File Offset: 0x0027E2F4
		// (set) Token: 0x0601B25D RID: 111197 RVA: 0x0028012D File Offset: 0x0027E32D
		public TArray<int> AllIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._AllIndices) == null)
				{
					result = (this._AllIndices = new TArray<int>(base.NativePtr + (IntPtr)AKuroSeasonsManager.__PropertyOffset_AllIndices, this));
				}
				return result;
			}
			set
			{
				this.AllIndices.CopyAssign(value);
			}
		}

		// Token: 0x17006CE5 RID: 27877
		// (get) Token: 0x0601B25E RID: 111198 RVA: 0x0028013C File Offset: 0x0027E33C
		// (set) Token: 0x0601B25F RID: 111199 RVA: 0x00280175 File Offset: 0x0027E375
		public TMap<FIntVector, FKuroSeasonsCellRange> Cells
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FIntVector, FKuroSeasonsCellRange> result;
				if ((result = this._Cells) == null)
				{
					result = (this._Cells = new TMap<FIntVector, FKuroSeasonsCellRange>(base.NativePtr + (IntPtr)AKuroSeasonsManager.__PropertyOffset_Cells, this));
				}
				return result;
			}
			set
			{
				this.Cells.CopyAssign(value);
			}
		}

		// Token: 0x17006CE6 RID: 27878
		// (get) Token: 0x0601B260 RID: 111200 RVA: 0x00280183 File Offset: 0x0027E383
		// (set) Token: 0x0601B261 RID: 111201 RVA: 0x00280193 File Offset: 0x0027E393
		public unsafe float CellSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSeasonsManager.__PropertyOffset_CellSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSeasonsManager.__PropertyOffset_CellSize) = value;
			}
		}

		// Token: 0x17006CE7 RID: 27879
		// (get) Token: 0x0601B262 RID: 111202 RVA: 0x002801A4 File Offset: 0x0027E3A4
		// (set) Token: 0x0601B263 RID: 111203 RVA: 0x002801B8 File Offset: 0x0027E3B8
		public unsafe FBox Bounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSeasonsManager.__PropertyOffset_Bounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSeasonsManager.__PropertyOffset_Bounds) = value;
			}
		}

		// Token: 0x17006CE8 RID: 27880
		// (get) Token: 0x0601B264 RID: 111204 RVA: 0x002801CD File Offset: 0x0027E3CD
		// (set) Token: 0x0601B265 RID: 111205 RVA: 0x002801E1 File Offset: 0x0027E3E1
		public unsafe string BakedFromLevel
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)AKuroSeasonsManager.__PropertyOffset_BakedFromLevel)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)AKuroSeasonsManager.__PropertyOffset_BakedFromLevel)), value);
			}
		}

		// Token: 0x17006CE9 RID: 27881
		// (get) Token: 0x0601B266 RID: 111206 RVA: 0x002801F8 File Offset: 0x0027E3F8
		// (set) Token: 0x0601B267 RID: 111207 RVA: 0x00280231 File Offset: 0x0027E431
		public FDateTime BakedAt
		{
			get
			{
				base.FastCheckIsValid();
				FDateTime result;
				if ((result = this._BakedAt) == null)
				{
					result = (this._BakedAt = new FDateTime(base.NativePtr + (IntPtr)AKuroSeasonsManager.__PropertyOffset_BakedAt, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDateTime.StaticStruct(), base.NativePtr + (IntPtr)AKuroSeasonsManager.__PropertyOffset_BakedAt, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601B268 RID: 111208 RVA: 0x00280252 File Offset: 0x0027E452
		public void SpawnNearestKAtPlayer()
		{
			AKuroSeasonsManager.__SpawnNearestKAtPlayer_Internal(base.NativePtr);
		}

		// Token: 0x0601B269 RID: 111209 RVA: 0x0028025F File Offset: 0x0027E45F
		public void ResetSpawnCooldown()
		{
			AKuroSeasonsManager.__ResetSpawnCooldown_Internal(base.NativePtr);
		}

		// Token: 0x0601B26A RID: 111210 RVA: 0x0028026C File Offset: 0x0027E46C
		public int GetBakedPointCount()
		{
			return AKuroSeasonsManager.__GetBakedPointCount_Internal(base.NativePtr);
		}

		// Token: 0x0601B26B RID: 111211 RVA: 0x00280279 File Offset: 0x0027E479
		public void Bake()
		{
			AKuroSeasonsManager.__Bake_Internal(base.NativePtr);
		}

		// Token: 0x0601B26C RID: 111212
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SpawnNearestKAtPlayer_Internal(IntPtr @this);

		// Token: 0x0601B26D RID: 111213
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetSpawnCooldown_Internal(IntPtr @this);

		// Token: 0x0601B26E RID: 111214
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetBakedPointCount_Internal(IntPtr @this);

		// Token: 0x0601B26F RID: 111215
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Bake_Internal(IntPtr @this);

		// Token: 0x0601B270 RID: 111216 RVA: 0x00280286 File Offset: 0x0027E486
		static AKuroSeasonsManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroSeasonsManager");
		}

		// Token: 0x0601B271 RID: 111217 RVA: 0x00280294 File Offset: 0x0027E494
		protected AKuroSeasonsManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E9DC RID: 59868
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroSeasonsManager";

		// Token: 0x0400E9DD RID: 59869
		private static IntPtr _ClassPtr;

		// Token: 0x0400E9DE RID: 59870
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E9DF RID: 59871
		internal static int __PropertyOffset_Box;

		// Token: 0x0400E9E0 RID: 59872
		internal static int __PropertyOffset_CellSizeOverride;

		// Token: 0x0400E9E1 RID: 59873
		internal static int __PropertyOffset_SharedNiagaraSystem;

		// Token: 0x0400E9E2 RID: 59874
		internal static int __PropertyOffset_ParamsAsset;

		// Token: 0x0400E9E3 RID: 59875
		internal static int __PropertyOffset_SpawnInterval;

		// Token: 0x0400E9E4 RID: 59876
		internal static int __PropertyOffset_SpawnsPerFrame;

		// Token: 0x0400E9E5 RID: 59877
		internal static int __PropertyOffset_BakedPoints;

		// Token: 0x0400E9E6 RID: 59878
		[Nullable(2)]
		private TArray<FVectorDouble> _BakedPoints;

		// Token: 0x0400E9E7 RID: 59879
		internal static int __PropertyOffset_BakedMeshes;

		// Token: 0x0400E9E8 RID: 59880
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMesh> _BakedMeshes;

		// Token: 0x0400E9E9 RID: 59881
		internal static int __PropertyOffset_BakedRotations;

		// Token: 0x0400E9EA RID: 59882
		[Nullable(2)]
		private TArray<FRotator> _BakedRotations;

		// Token: 0x0400E9EB RID: 59883
		internal static int __PropertyOffset_BakedScales;

		// Token: 0x0400E9EC RID: 59884
		[Nullable(2)]
		private TArray<FVector> _BakedScales;

		// Token: 0x0400E9ED RID: 59885
		internal static int __PropertyOffset_AllIndices;

		// Token: 0x0400E9EE RID: 59886
		[Nullable(2)]
		private TArray<int> _AllIndices;

		// Token: 0x0400E9EF RID: 59887
		internal static int __PropertyOffset_Cells;

		// Token: 0x0400E9F0 RID: 59888
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FIntVector, FKuroSeasonsCellRange> _Cells;

		// Token: 0x0400E9F1 RID: 59889
		internal static int __PropertyOffset_CellSize;

		// Token: 0x0400E9F2 RID: 59890
		internal static int __PropertyOffset_Bounds;

		// Token: 0x0400E9F3 RID: 59891
		internal static int __PropertyOffset_BakedFromLevel;

		// Token: 0x0400E9F4 RID: 59892
		internal static int __PropertyOffset_BakedAt;

		// Token: 0x0400E9F5 RID: 59893
		[Nullable(2)]
		private FDateTime _BakedAt;
	}
}
