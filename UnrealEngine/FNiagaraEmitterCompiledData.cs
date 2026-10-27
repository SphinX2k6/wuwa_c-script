using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200259B RID: 9627
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraEmitterCompiledData")]
	[UnrealStructLayout(608, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 608)]
	public class FNiagaraEmitterCompiledData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023C1B RID: 146459 RVA: 0x0034E01E File Offset: 0x0034C21E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraEmitterCompiledData._ScriptStructPtr != 0) ? FNiagaraEmitterCompiledData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraEmitterCompiledData", ref FNiagaraEmitterCompiledData._ScriptStructPtr);
		}

		// Token: 0x1700896E RID: 35182
		// (get) Token: 0x06023C1C RID: 146460 RVA: 0x0034E044 File Offset: 0x0034C244
		// (set) Token: 0x06023C1D RID: 146461 RVA: 0x0034E087 File Offset: 0x0034C287
		public TArray<FName> SpawnAttributes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._SpawnAttributes) == null)
				{
					result = (this._SpawnAttributes = new TArray<FName>(base.NativePtr + (IntPtr)FNiagaraEmitterCompiledData.__PropertyOffset_SpawnAttributes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SpawnAttributes.CopyAssign(value);
			}
		}

		// Token: 0x1700896F RID: 35183
		// (get) Token: 0x06023C1E RID: 146462 RVA: 0x0034E098 File Offset: 0x0034C298
		// (set) Token: 0x06023C1F RID: 146463 RVA: 0x0034E0DB File Offset: 0x0034C2DB
		public FNiagaraVariable EmitterSpawnIntervalVar
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariable result;
				if ((result = this._EmitterSpawnIntervalVar) == null)
				{
					result = (this._EmitterSpawnIntervalVar = new FNiagaraVariable(base.NativePtr + (IntPtr)FNiagaraEmitterCompiledData.__PropertyOffset_EmitterSpawnIntervalVar, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariable.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraEmitterCompiledData.__PropertyOffset_EmitterSpawnIntervalVar, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008970 RID: 35184
		// (get) Token: 0x06023C20 RID: 146464 RVA: 0x0034E0FC File Offset: 0x0034C2FC
		// (set) Token: 0x06023C21 RID: 146465 RVA: 0x0034E13F File Offset: 0x0034C33F
		public FNiagaraVariable EmitterInterpSpawnStartDTVar
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariable result;
				if ((result = this._EmitterInterpSpawnStartDTVar) == null)
				{
					result = (this._EmitterInterpSpawnStartDTVar = new FNiagaraVariable(base.NativePtr + (IntPtr)FNiagaraEmitterCompiledData.__PropertyOffset_EmitterInterpSpawnStartDTVar, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariable.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraEmitterCompiledData.__PropertyOffset_EmitterInterpSpawnStartDTVar, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008971 RID: 35185
		// (get) Token: 0x06023C22 RID: 146466 RVA: 0x0034E160 File Offset: 0x0034C360
		// (set) Token: 0x06023C23 RID: 146467 RVA: 0x0034E1A3 File Offset: 0x0034C3A3
		public FNiagaraVariable EmitterSpawnGroupVar
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariable result;
				if ((result = this._EmitterSpawnGroupVar) == null)
				{
					result = (this._EmitterSpawnGroupVar = new FNiagaraVariable(base.NativePtr + (IntPtr)FNiagaraEmitterCompiledData.__PropertyOffset_EmitterSpawnGroupVar, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariable.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraEmitterCompiledData.__PropertyOffset_EmitterSpawnGroupVar, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008972 RID: 35186
		// (get) Token: 0x06023C24 RID: 146468 RVA: 0x0034E1C4 File Offset: 0x0034C3C4
		// (set) Token: 0x06023C25 RID: 146469 RVA: 0x0034E207 File Offset: 0x0034C407
		public FNiagaraVariable EmitterAgeVar
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariable result;
				if ((result = this._EmitterAgeVar) == null)
				{
					result = (this._EmitterAgeVar = new FNiagaraVariable(base.NativePtr + (IntPtr)FNiagaraEmitterCompiledData.__PropertyOffset_EmitterAgeVar, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariable.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraEmitterCompiledData.__PropertyOffset_EmitterAgeVar, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008973 RID: 35187
		// (get) Token: 0x06023C26 RID: 146470 RVA: 0x0034E228 File Offset: 0x0034C428
		// (set) Token: 0x06023C27 RID: 146471 RVA: 0x0034E26B File Offset: 0x0034C46B
		public FNiagaraVariable EmitterRandomSeedVar
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariable result;
				if ((result = this._EmitterRandomSeedVar) == null)
				{
					result = (this._EmitterRandomSeedVar = new FNiagaraVariable(base.NativePtr + (IntPtr)FNiagaraEmitterCompiledData.__PropertyOffset_EmitterRandomSeedVar, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariable.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraEmitterCompiledData.__PropertyOffset_EmitterRandomSeedVar, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008974 RID: 35188
		// (get) Token: 0x06023C28 RID: 146472 RVA: 0x0034E28C File Offset: 0x0034C48C
		// (set) Token: 0x06023C29 RID: 146473 RVA: 0x0034E2CF File Offset: 0x0034C4CF
		public FNiagaraVariable EmitterInstanceSeedVar
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariable result;
				if ((result = this._EmitterInstanceSeedVar) == null)
				{
					result = (this._EmitterInstanceSeedVar = new FNiagaraVariable(base.NativePtr + (IntPtr)FNiagaraEmitterCompiledData.__PropertyOffset_EmitterInstanceSeedVar, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariable.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraEmitterCompiledData.__PropertyOffset_EmitterInstanceSeedVar, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008975 RID: 35189
		// (get) Token: 0x06023C2A RID: 146474 RVA: 0x0034E2F0 File Offset: 0x0034C4F0
		// (set) Token: 0x06023C2B RID: 146475 RVA: 0x0034E333 File Offset: 0x0034C533
		public FNiagaraVariable EmitterTotalSpawnedParticlesVar
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariable result;
				if ((result = this._EmitterTotalSpawnedParticlesVar) == null)
				{
					result = (this._EmitterTotalSpawnedParticlesVar = new FNiagaraVariable(base.NativePtr + (IntPtr)FNiagaraEmitterCompiledData.__PropertyOffset_EmitterTotalSpawnedParticlesVar, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariable.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraEmitterCompiledData.__PropertyOffset_EmitterTotalSpawnedParticlesVar, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008976 RID: 35190
		// (get) Token: 0x06023C2C RID: 146476 RVA: 0x0034E354 File Offset: 0x0034C554
		// (set) Token: 0x06023C2D RID: 146477 RVA: 0x0034E397 File Offset: 0x0034C597
		public FNiagaraDataSetCompiledData DataSetCompiledData
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraDataSetCompiledData result;
				if ((result = this._DataSetCompiledData) == null)
				{
					result = (this._DataSetCompiledData = new FNiagaraDataSetCompiledData(base.NativePtr + (IntPtr)FNiagaraEmitterCompiledData.__PropertyOffset_DataSetCompiledData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraDataSetCompiledData.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraEmitterCompiledData.__PropertyOffset_DataSetCompiledData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06023C2E RID: 146478 RVA: 0x0034E3B8 File Offset: 0x0034C5B8
		public FNiagaraEmitterCompiledData()
		{
		}

		// Token: 0x06023C2F RID: 146479 RVA: 0x0034E3C0 File Offset: 0x0034C5C0
		public FNiagaraEmitterCompiledData(TArray<FName> SpawnAttributes, FNiagaraVariable EmitterSpawnIntervalVar, FNiagaraVariable EmitterInterpSpawnStartDTVar, FNiagaraVariable EmitterSpawnGroupVar, FNiagaraVariable EmitterAgeVar, FNiagaraVariable EmitterRandomSeedVar, FNiagaraVariable EmitterInstanceSeedVar, FNiagaraVariable EmitterTotalSpawnedParticlesVar, FNiagaraDataSetCompiledData DataSetCompiledData, FNiagaraDataSetCompiledData GPUCaptureDataSetCompiledData)
		{
			this.SpawnAttributes = SpawnAttributes;
			this.EmitterSpawnIntervalVar = EmitterSpawnIntervalVar;
			this.EmitterInterpSpawnStartDTVar = EmitterInterpSpawnStartDTVar;
			this.EmitterSpawnGroupVar = EmitterSpawnGroupVar;
			this.EmitterAgeVar = EmitterAgeVar;
			this.EmitterRandomSeedVar = EmitterRandomSeedVar;
			this.EmitterInstanceSeedVar = EmitterInstanceSeedVar;
			this.EmitterTotalSpawnedParticlesVar = EmitterTotalSpawnedParticlesVar;
			this.DataSetCompiledData = DataSetCompiledData;
		}

		// Token: 0x06023C30 RID: 146480 RVA: 0x0034E418 File Offset: 0x0034C618
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraEmitterCompiledData.StaticStruct();
		}

		// Token: 0x06023C31 RID: 146481 RVA: 0x0034E424 File Offset: 0x0034C624
		[NullableContext(2)]
		public FNiagaraEmitterCompiledData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023C32 RID: 146482 RVA: 0x0034E42E File Offset: 0x0034C62E
		public FNiagaraEmitterCompiledData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023C33 RID: 146483 RVA: 0x0034E439 File Offset: 0x0034C639
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraEmitterCompiledData(Pointer, false, true);
		}

		// Token: 0x06023C34 RID: 146484 RVA: 0x0034E443 File Offset: 0x0034C643
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraEmitterCompiledData(Pointer, MemoryOwner);
		}

		// Token: 0x040132DB RID: 78555
		public const string __ObjectPath = "/Script/Niagara.NiagaraEmitterCompiledData";

		// Token: 0x040132DC RID: 78556
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040132DD RID: 78557
		internal static int __PropertyOffset_SpawnAttributes;

		// Token: 0x040132DE RID: 78558
		[Nullable(2)]
		private TArray<FName> _SpawnAttributes;

		// Token: 0x040132DF RID: 78559
		internal static int __PropertyOffset_EmitterSpawnIntervalVar;

		// Token: 0x040132E0 RID: 78560
		[Nullable(2)]
		private FNiagaraVariable _EmitterSpawnIntervalVar;

		// Token: 0x040132E1 RID: 78561
		internal static int __PropertyOffset_EmitterInterpSpawnStartDTVar;

		// Token: 0x040132E2 RID: 78562
		[Nullable(2)]
		private FNiagaraVariable _EmitterInterpSpawnStartDTVar;

		// Token: 0x040132E3 RID: 78563
		internal static int __PropertyOffset_EmitterSpawnGroupVar;

		// Token: 0x040132E4 RID: 78564
		[Nullable(2)]
		private FNiagaraVariable _EmitterSpawnGroupVar;

		// Token: 0x040132E5 RID: 78565
		internal static int __PropertyOffset_EmitterAgeVar;

		// Token: 0x040132E6 RID: 78566
		[Nullable(2)]
		private FNiagaraVariable _EmitterAgeVar;

		// Token: 0x040132E7 RID: 78567
		internal static int __PropertyOffset_EmitterRandomSeedVar;

		// Token: 0x040132E8 RID: 78568
		[Nullable(2)]
		private FNiagaraVariable _EmitterRandomSeedVar;

		// Token: 0x040132E9 RID: 78569
		internal static int __PropertyOffset_EmitterInstanceSeedVar;

		// Token: 0x040132EA RID: 78570
		[Nullable(2)]
		private FNiagaraVariable _EmitterInstanceSeedVar;

		// Token: 0x040132EB RID: 78571
		internal static int __PropertyOffset_EmitterTotalSpawnedParticlesVar;

		// Token: 0x040132EC RID: 78572
		[Nullable(2)]
		private FNiagaraVariable _EmitterTotalSpawnedParticlesVar;

		// Token: 0x040132ED RID: 78573
		internal static int __PropertyOffset_DataSetCompiledData;

		// Token: 0x040132EE RID: 78574
		[Nullable(2)]
		private FNiagaraDataSetCompiledData _DataSetCompiledData;
	}
}
