using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020024D3 RID: 9427
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/NiagaraShader.SimulationStageMetaData")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FSimulationStageMetaData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060233E1 RID: 144353 RVA: 0x00342029 File Offset: 0x00340229
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSimulationStageMetaData._ScriptStructPtr != 0) ? FSimulationStageMetaData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/NiagaraShader.SimulationStageMetaData", ref FSimulationStageMetaData._ScriptStructPtr);
		}

		// Token: 0x1700877C RID: 34684
		// (get) Token: 0x060233E2 RID: 144354 RVA: 0x0034204D File Offset: 0x0034024D
		// (set) Token: 0x060233E3 RID: 144355 RVA: 0x00342061 File Offset: 0x00340261
		public unsafe FName SimulationStageName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSimulationStageMetaData.__PropertyOffset_SimulationStageName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSimulationStageMetaData.__PropertyOffset_SimulationStageName) = value;
			}
		}

		// Token: 0x1700877D RID: 34685
		// (get) Token: 0x060233E4 RID: 144356 RVA: 0x00342076 File Offset: 0x00340276
		// (set) Token: 0x060233E5 RID: 144357 RVA: 0x0034208A File Offset: 0x0034028A
		public unsafe FName IterationSource
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSimulationStageMetaData.__PropertyOffset_IterationSource);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSimulationStageMetaData.__PropertyOffset_IterationSource) = value;
			}
		}

		// Token: 0x1700877E RID: 34686
		// (get) Token: 0x060233E6 RID: 144358 RVA: 0x0034209F File Offset: 0x0034029F
		// (set) Token: 0x060233E7 RID: 144359 RVA: 0x003420B8 File Offset: 0x003402B8
		public unsafe bool bSpawnOnly
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSimulationStageMetaData.__PropertyOffset_bSpawnOnly) & FSimulationStageMetaData.__PropertyMask_bSpawnOnly) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSimulationStageMetaData.__PropertyOffset_bSpawnOnly) = ((*(base.NativePtr + (IntPtr)FSimulationStageMetaData.__PropertyOffset_bSpawnOnly) & ~FSimulationStageMetaData.__PropertyMask_bSpawnOnly) | (value ? FSimulationStageMetaData.__PropertyMask_bSpawnOnly : 0));
			}
		}

		// Token: 0x1700877F RID: 34687
		// (get) Token: 0x060233E8 RID: 144360 RVA: 0x003420E8 File Offset: 0x003402E8
		// (set) Token: 0x060233E9 RID: 144361 RVA: 0x00342101 File Offset: 0x00340301
		public unsafe bool bWritesParticles
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSimulationStageMetaData.__PropertyOffset_bWritesParticles) & FSimulationStageMetaData.__PropertyMask_bWritesParticles) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSimulationStageMetaData.__PropertyOffset_bWritesParticles) = ((*(base.NativePtr + (IntPtr)FSimulationStageMetaData.__PropertyOffset_bWritesParticles) & ~FSimulationStageMetaData.__PropertyMask_bWritesParticles) | (value ? FSimulationStageMetaData.__PropertyMask_bWritesParticles : 0));
			}
		}

		// Token: 0x17008780 RID: 34688
		// (get) Token: 0x060233EA RID: 144362 RVA: 0x00342131 File Offset: 0x00340331
		// (set) Token: 0x060233EB RID: 144363 RVA: 0x0034214A File Offset: 0x0034034A
		public unsafe bool bPartialParticleUpdate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSimulationStageMetaData.__PropertyOffset_bPartialParticleUpdate) & FSimulationStageMetaData.__PropertyMask_bPartialParticleUpdate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSimulationStageMetaData.__PropertyOffset_bPartialParticleUpdate) = ((*(base.NativePtr + (IntPtr)FSimulationStageMetaData.__PropertyOffset_bPartialParticleUpdate) & ~FSimulationStageMetaData.__PropertyMask_bPartialParticleUpdate) | (value ? FSimulationStageMetaData.__PropertyMask_bPartialParticleUpdate : 0));
			}
		}

		// Token: 0x17008781 RID: 34689
		// (get) Token: 0x060233EC RID: 144364 RVA: 0x0034217C File Offset: 0x0034037C
		// (set) Token: 0x060233ED RID: 144365 RVA: 0x003421BF File Offset: 0x003403BF
		public TArray<FName> OutputDestinations
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._OutputDestinations) == null)
				{
					result = (this._OutputDestinations = new TArray<FName>(base.NativePtr + (IntPtr)FSimulationStageMetaData.__PropertyOffset_OutputDestinations, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.OutputDestinations.CopyAssign(value);
			}
		}

		// Token: 0x17008782 RID: 34690
		// (get) Token: 0x060233EE RID: 144366 RVA: 0x003421CD File Offset: 0x003403CD
		// (set) Token: 0x060233EF RID: 144367 RVA: 0x003421DD File Offset: 0x003403DD
		public unsafe int MinStage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSimulationStageMetaData.__PropertyOffset_MinStage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSimulationStageMetaData.__PropertyOffset_MinStage) = value;
			}
		}

		// Token: 0x17008783 RID: 34691
		// (get) Token: 0x060233F0 RID: 144368 RVA: 0x003421EE File Offset: 0x003403EE
		// (set) Token: 0x060233F1 RID: 144369 RVA: 0x003421FE File Offset: 0x003403FE
		public unsafe int MaxStage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSimulationStageMetaData.__PropertyOffset_MaxStage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSimulationStageMetaData.__PropertyOffset_MaxStage) = value;
			}
		}

		// Token: 0x060233F2 RID: 144370 RVA: 0x0034220F File Offset: 0x0034040F
		public FSimulationStageMetaData()
		{
		}

		// Token: 0x060233F3 RID: 144371 RVA: 0x00342218 File Offset: 0x00340418
		public FSimulationStageMetaData(FName SimulationStageName, FName IterationSource, bool bSpawnOnly, bool bWritesParticles, bool bPartialParticleUpdate, TArray<FName> OutputDestinations, int MinStage, int MaxStage)
		{
			this.SimulationStageName = SimulationStageName;
			this.IterationSource = IterationSource;
			this.bSpawnOnly = bSpawnOnly;
			this.bWritesParticles = bWritesParticles;
			this.bPartialParticleUpdate = bPartialParticleUpdate;
			this.OutputDestinations = OutputDestinations;
			this.MinStage = MinStage;
			this.MaxStage = MaxStage;
		}

		// Token: 0x060233F4 RID: 144372 RVA: 0x00342268 File Offset: 0x00340468
		protected override IntPtr GetUStructPtr()
		{
			return FSimulationStageMetaData.StaticStruct();
		}

		// Token: 0x060233F5 RID: 144373 RVA: 0x00342274 File Offset: 0x00340474
		[NullableContext(2)]
		public FSimulationStageMetaData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060233F6 RID: 144374 RVA: 0x0034227E File Offset: 0x0034047E
		public FSimulationStageMetaData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060233F7 RID: 144375 RVA: 0x00342289 File Offset: 0x00340489
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSimulationStageMetaData(Pointer, false, true);
		}

		// Token: 0x060233F8 RID: 144376 RVA: 0x00342293 File Offset: 0x00340493
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSimulationStageMetaData(Pointer, MemoryOwner);
		}

		// Token: 0x04012D4E RID: 77134
		public const string __ObjectPath = "/Script/NiagaraShader.SimulationStageMetaData";

		// Token: 0x04012D4F RID: 77135
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012D50 RID: 77136
		internal static int __PropertyOffset_SimulationStageName;

		// Token: 0x04012D51 RID: 77137
		internal static int __PropertyOffset_IterationSource;

		// Token: 0x04012D52 RID: 77138
		internal static int __PropertyOffset_bSpawnOnly;

		// Token: 0x04012D53 RID: 77139
		internal static byte __PropertyMask_bSpawnOnly;

		// Token: 0x04012D54 RID: 77140
		internal static int __PropertyOffset_bWritesParticles;

		// Token: 0x04012D55 RID: 77141
		internal static byte __PropertyMask_bWritesParticles;

		// Token: 0x04012D56 RID: 77142
		internal static int __PropertyOffset_bPartialParticleUpdate;

		// Token: 0x04012D57 RID: 77143
		internal static byte __PropertyMask_bPartialParticleUpdate;

		// Token: 0x04012D58 RID: 77144
		internal static int __PropertyOffset_OutputDestinations;

		// Token: 0x04012D59 RID: 77145
		[Nullable(2)]
		private TArray<FName> _OutputDestinations;

		// Token: 0x04012D5A RID: 77146
		internal static int __PropertyOffset_MinStage;

		// Token: 0x04012D5B RID: 77147
		internal static int __PropertyOffset_MaxStage;
	}
}
