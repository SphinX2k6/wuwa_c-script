using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002608 RID: 9736
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraVMExecutableData")]
	[UnrealStructLayout(488, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 488)]
	public class FNiagaraVMExecutableData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602436A RID: 148330 RVA: 0x00359AC3 File Offset: 0x00357CC3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraVMExecutableData._ScriptStructPtr != 0) ? FNiagaraVMExecutableData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraVMExecutableData", ref FNiagaraVMExecutableData._ScriptStructPtr);
		}

		// Token: 0x17008B78 RID: 35704
		// (get) Token: 0x0602436B RID: 148331 RVA: 0x00359AE8 File Offset: 0x00357CE8
		// (set) Token: 0x0602436C RID: 148332 RVA: 0x00359B2B File Offset: 0x00357D2B
		public TArray<byte> ByteCode
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._ByteCode) == null)
				{
					result = (this._ByteCode = new TArray<byte>(base.NativePtr + (IntPtr)FNiagaraVMExecutableData.__PropertyOffset_ByteCode, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ByteCode.CopyAssign(value);
			}
		}

		// Token: 0x17008B79 RID: 35705
		// (get) Token: 0x0602436D RID: 148333 RVA: 0x00359B3C File Offset: 0x00357D3C
		// (set) Token: 0x0602436E RID: 148334 RVA: 0x00359B7F File Offset: 0x00357D7F
		public TArray<byte> OptimizedByteCode
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._OptimizedByteCode) == null)
				{
					result = (this._OptimizedByteCode = new TArray<byte>(base.NativePtr + (IntPtr)FNiagaraVMExecutableData.__PropertyOffset_OptimizedByteCode, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.OptimizedByteCode.CopyAssign(value);
			}
		}

		// Token: 0x17008B7A RID: 35706
		// (get) Token: 0x0602436F RID: 148335 RVA: 0x00359B8D File Offset: 0x00357D8D
		// (set) Token: 0x06024370 RID: 148336 RVA: 0x00359B9D File Offset: 0x00357D9D
		public unsafe int NumTempRegisters
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraVMExecutableData.__PropertyOffset_NumTempRegisters);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraVMExecutableData.__PropertyOffset_NumTempRegisters) = value;
			}
		}

		// Token: 0x17008B7B RID: 35707
		// (get) Token: 0x06024371 RID: 148337 RVA: 0x00359BAE File Offset: 0x00357DAE
		// (set) Token: 0x06024372 RID: 148338 RVA: 0x00359BBE File Offset: 0x00357DBE
		public unsafe int NumUserPtrs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraVMExecutableData.__PropertyOffset_NumUserPtrs);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraVMExecutableData.__PropertyOffset_NumUserPtrs) = value;
			}
		}

		// Token: 0x17008B7C RID: 35708
		// (get) Token: 0x06024373 RID: 148339 RVA: 0x00359BD0 File Offset: 0x00357DD0
		// (set) Token: 0x06024374 RID: 148340 RVA: 0x00359C13 File Offset: 0x00357E13
		public TArray<byte> ScriptLiterals
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._ScriptLiterals) == null)
				{
					result = (this._ScriptLiterals = new TArray<byte>(base.NativePtr + (IntPtr)FNiagaraVMExecutableData.__PropertyOffset_ScriptLiterals, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ScriptLiterals.CopyAssign(value);
			}
		}

		// Token: 0x17008B7D RID: 35709
		// (get) Token: 0x06024375 RID: 148341 RVA: 0x00359C24 File Offset: 0x00357E24
		// (set) Token: 0x06024376 RID: 148342 RVA: 0x00359C67 File Offset: 0x00357E67
		public TArray<FNiagaraVariable> Attributes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraVariable> result;
				if ((result = this._Attributes) == null)
				{
					result = (this._Attributes = new TArray<FNiagaraVariable>(base.NativePtr + (IntPtr)FNiagaraVMExecutableData.__PropertyOffset_Attributes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Attributes.CopyAssign(value);
			}
		}

		// Token: 0x17008B7E RID: 35710
		// (get) Token: 0x06024377 RID: 148343 RVA: 0x00359C78 File Offset: 0x00357E78
		// (set) Token: 0x06024378 RID: 148344 RVA: 0x00359CBB File Offset: 0x00357EBB
		public FNiagaraScriptDataUsageInfo DataUsage
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraScriptDataUsageInfo result;
				if ((result = this._DataUsage) == null)
				{
					result = (this._DataUsage = new FNiagaraScriptDataUsageInfo(base.NativePtr + (IntPtr)FNiagaraVMExecutableData.__PropertyOffset_DataUsage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraScriptDataUsageInfo.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraVMExecutableData.__PropertyOffset_DataUsage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008B7F RID: 35711
		// (get) Token: 0x06024379 RID: 148345 RVA: 0x00359CDC File Offset: 0x00357EDC
		// (set) Token: 0x0602437A RID: 148346 RVA: 0x00359D1F File Offset: 0x00357F1F
		public TArray<FNiagaraScriptDataInterfaceCompileInfo> DataInterfaceInfo
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraScriptDataInterfaceCompileInfo> result;
				if ((result = this._DataInterfaceInfo) == null)
				{
					result = (this._DataInterfaceInfo = new TArray<FNiagaraScriptDataInterfaceCompileInfo>(base.NativePtr + (IntPtr)FNiagaraVMExecutableData.__PropertyOffset_DataInterfaceInfo, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DataInterfaceInfo.CopyAssign(value);
			}
		}

		// Token: 0x17008B80 RID: 35712
		// (get) Token: 0x0602437B RID: 148347 RVA: 0x00359D30 File Offset: 0x00357F30
		// (set) Token: 0x0602437C RID: 148348 RVA: 0x00359D73 File Offset: 0x00357F73
		public TArray<FVMExternalFunctionBindingInfo> CalledVMExternalFunctions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVMExternalFunctionBindingInfo> result;
				if ((result = this._CalledVMExternalFunctions) == null)
				{
					result = (this._CalledVMExternalFunctions = new TArray<FVMExternalFunctionBindingInfo>(base.NativePtr + (IntPtr)FNiagaraVMExecutableData.__PropertyOffset_CalledVMExternalFunctions, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CalledVMExternalFunctions.CopyAssign(value);
			}
		}

		// Token: 0x17008B81 RID: 35713
		// (get) Token: 0x0602437D RID: 148349 RVA: 0x00359D84 File Offset: 0x00357F84
		// (set) Token: 0x0602437E RID: 148350 RVA: 0x00359DC7 File Offset: 0x00357FC7
		public TArray<FNiagaraDataSetID> ReadDataSets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraDataSetID> result;
				if ((result = this._ReadDataSets) == null)
				{
					result = (this._ReadDataSets = new TArray<FNiagaraDataSetID>(base.NativePtr + (IntPtr)FNiagaraVMExecutableData.__PropertyOffset_ReadDataSets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ReadDataSets.CopyAssign(value);
			}
		}

		// Token: 0x17008B82 RID: 35714
		// (get) Token: 0x0602437F RID: 148351 RVA: 0x00359DD8 File Offset: 0x00357FD8
		// (set) Token: 0x06024380 RID: 148352 RVA: 0x00359E1B File Offset: 0x0035801B
		public TArray<FNiagaraDataSetProperties> WriteDataSets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraDataSetProperties> result;
				if ((result = this._WriteDataSets) == null)
				{
					result = (this._WriteDataSets = new TArray<FNiagaraDataSetProperties>(base.NativePtr + (IntPtr)FNiagaraVMExecutableData.__PropertyOffset_WriteDataSets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.WriteDataSets.CopyAssign(value);
			}
		}

		// Token: 0x17008B83 RID: 35715
		// (get) Token: 0x06024381 RID: 148353 RVA: 0x00359E2C File Offset: 0x0035802C
		// (set) Token: 0x06024382 RID: 148354 RVA: 0x00359E6F File Offset: 0x0035806F
		public TArray<FNiagaraStatScope> StatScopes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraStatScope> result;
				if ((result = this._StatScopes) == null)
				{
					result = (this._StatScopes = new TArray<FNiagaraStatScope>(base.NativePtr + (IntPtr)FNiagaraVMExecutableData.__PropertyOffset_StatScopes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StatScopes.CopyAssign(value);
			}
		}

		// Token: 0x17008B84 RID: 35716
		// (get) Token: 0x06024383 RID: 148355 RVA: 0x00359E80 File Offset: 0x00358080
		// (set) Token: 0x06024384 RID: 148356 RVA: 0x00359EC3 File Offset: 0x003580C3
		public TArray<FNiagaraDataInterfaceGPUParamInfo> DIParamInfo
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraDataInterfaceGPUParamInfo> result;
				if ((result = this._DIParamInfo) == null)
				{
					result = (this._DIParamInfo = new TArray<FNiagaraDataInterfaceGPUParamInfo>(base.NativePtr + (IntPtr)FNiagaraVMExecutableData.__PropertyOffset_DIParamInfo, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DIParamInfo.CopyAssign(value);
			}
		}

		// Token: 0x17008B85 RID: 35717
		// (get) Token: 0x06024385 RID: 148357 RVA: 0x00359ED1 File Offset: 0x003580D1
		// (set) Token: 0x06024386 RID: 148358 RVA: 0x00359EE1 File Offset: 0x003580E1
		public unsafe ENiagaraScriptCompileStatus LastCompileStatus
		{
			get
			{
				return (ENiagaraScriptCompileStatus)(*(base.NativePtr + (IntPtr)FNiagaraVMExecutableData.__PropertyOffset_LastCompileStatus));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraVMExecutableData.__PropertyOffset_LastCompileStatus) = (byte)value;
			}
		}

		// Token: 0x17008B86 RID: 35718
		// (get) Token: 0x06024387 RID: 148359 RVA: 0x00359EF4 File Offset: 0x003580F4
		// (set) Token: 0x06024388 RID: 148360 RVA: 0x00359F37 File Offset: 0x00358137
		public TArray<FSimulationStageMetaData> SimulationStageMetaData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSimulationStageMetaData> result;
				if ((result = this._SimulationStageMetaData) == null)
				{
					result = (this._SimulationStageMetaData = new TArray<FSimulationStageMetaData>(base.NativePtr + (IntPtr)FNiagaraVMExecutableData.__PropertyOffset_SimulationStageMetaData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SimulationStageMetaData.CopyAssign(value);
			}
		}

		// Token: 0x17008B87 RID: 35719
		// (get) Token: 0x06024389 RID: 148361 RVA: 0x00359F48 File Offset: 0x00358148
		// (set) Token: 0x0602438A RID: 148362 RVA: 0x00359F8B File Offset: 0x0035818B
		public TArray<byte> ExperimentalContextData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._ExperimentalContextData) == null)
				{
					result = (this._ExperimentalContextData = new TArray<byte>(base.NativePtr + (IntPtr)FNiagaraVMExecutableData.__PropertyOffset_ExperimentalContextData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ExperimentalContextData.CopyAssign(value);
			}
		}

		// Token: 0x17008B88 RID: 35720
		// (get) Token: 0x0602438B RID: 148363 RVA: 0x00359F99 File Offset: 0x00358199
		// (set) Token: 0x0602438C RID: 148364 RVA: 0x00359FB2 File Offset: 0x003581B2
		public unsafe bool bReadsSignificanceIndex
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNiagaraVMExecutableData.__PropertyOffset_bReadsSignificanceIndex) & FNiagaraVMExecutableData.__PropertyMask_bReadsSignificanceIndex) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNiagaraVMExecutableData.__PropertyOffset_bReadsSignificanceIndex) = ((*(base.NativePtr + (IntPtr)FNiagaraVMExecutableData.__PropertyOffset_bReadsSignificanceIndex) & ~FNiagaraVMExecutableData.__PropertyMask_bReadsSignificanceIndex) | (value ? FNiagaraVMExecutableData.__PropertyMask_bReadsSignificanceIndex : 0));
			}
		}

		// Token: 0x0602438D RID: 148365 RVA: 0x00359FE2 File Offset: 0x003581E2
		public FNiagaraVMExecutableData()
		{
		}

		// Token: 0x0602438E RID: 148366 RVA: 0x00359FEC File Offset: 0x003581EC
		public FNiagaraVMExecutableData(TArray<byte> ByteCode, TArray<byte> OptimizedByteCode, int NumTempRegisters, int NumUserPtrs, FNiagaraParameters Parameters, FNiagaraParameters InternalParameters, TArray<byte> ScriptLiterals, TArray<FNiagaraVariable> Attributes, FNiagaraScriptDataUsageInfo DataUsage, TMap<FName, FNiagaraParameters> DataSetToParameters, TArray<FNiagaraFunctionSignature> AdditionalExternalFunctions, TArray<FNiagaraScriptDataInterfaceCompileInfo> DataInterfaceInfo, TArray<FVMExternalFunctionBindingInfo> CalledVMExternalFunctions, TArray<FNiagaraDataSetID> ReadDataSets, TArray<FNiagaraDataSetProperties> WriteDataSets, TArray<FNiagaraStatScope> StatScopes, string LastHlslTranslation, string LastHlslTranslationGPU, string LastAssemblyTranslation, uint LastOpCount, TArray<FNiagaraDataInterfaceGPUParamInfo> DIParamInfo, TArray<string> ParameterCollectionPaths, ENiagaraScriptCompileStatus LastCompileStatus, TArray<FSimulationStageMetaData> SimulationStageMetaData, bool bReadsAttributeData, string ErrorMsg, float CompileTime, TArray<FNiagaraCompileEvent> LastCompileEvents, TArray<byte> ExperimentalContextData, bool bReadsSignificanceIndex)
		{
			this.ByteCode = ByteCode;
			this.OptimizedByteCode = OptimizedByteCode;
			this.NumTempRegisters = NumTempRegisters;
			this.NumUserPtrs = NumUserPtrs;
			this.ScriptLiterals = ScriptLiterals;
			this.Attributes = Attributes;
			this.DataUsage = DataUsage;
			this.DataInterfaceInfo = DataInterfaceInfo;
			this.CalledVMExternalFunctions = CalledVMExternalFunctions;
			this.ReadDataSets = ReadDataSets;
			this.WriteDataSets = WriteDataSets;
			this.StatScopes = StatScopes;
			this.DIParamInfo = DIParamInfo;
			this.LastCompileStatus = LastCompileStatus;
			this.SimulationStageMetaData = SimulationStageMetaData;
			this.ExperimentalContextData = ExperimentalContextData;
			this.bReadsSignificanceIndex = bReadsSignificanceIndex;
		}

		// Token: 0x0602438F RID: 148367 RVA: 0x0035A084 File Offset: 0x00358284
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraVMExecutableData.StaticStruct();
		}

		// Token: 0x06024390 RID: 148368 RVA: 0x0035A090 File Offset: 0x00358290
		[NullableContext(2)]
		public FNiagaraVMExecutableData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024391 RID: 148369 RVA: 0x0035A09A File Offset: 0x0035829A
		public FNiagaraVMExecutableData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024392 RID: 148370 RVA: 0x0035A0A5 File Offset: 0x003582A5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraVMExecutableData(Pointer, false, true);
		}

		// Token: 0x06024393 RID: 148371 RVA: 0x0035A0AF File Offset: 0x003582AF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraVMExecutableData(Pointer, MemoryOwner);
		}

		// Token: 0x040136DC RID: 79580
		public const string __ObjectPath = "/Script/Niagara.NiagaraVMExecutableData";

		// Token: 0x040136DD RID: 79581
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040136DE RID: 79582
		internal static int __PropertyOffset_ByteCode;

		// Token: 0x040136DF RID: 79583
		[Nullable(2)]
		private TArray<byte> _ByteCode;

		// Token: 0x040136E0 RID: 79584
		internal static int __PropertyOffset_OptimizedByteCode;

		// Token: 0x040136E1 RID: 79585
		[Nullable(2)]
		private TArray<byte> _OptimizedByteCode;

		// Token: 0x040136E2 RID: 79586
		internal static int __PropertyOffset_NumTempRegisters;

		// Token: 0x040136E3 RID: 79587
		internal static int __PropertyOffset_NumUserPtrs;

		// Token: 0x040136E4 RID: 79588
		internal static int __PropertyOffset_ScriptLiterals;

		// Token: 0x040136E5 RID: 79589
		[Nullable(2)]
		private TArray<byte> _ScriptLiterals;

		// Token: 0x040136E6 RID: 79590
		internal static int __PropertyOffset_Attributes;

		// Token: 0x040136E7 RID: 79591
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraVariable> _Attributes;

		// Token: 0x040136E8 RID: 79592
		internal static int __PropertyOffset_DataUsage;

		// Token: 0x040136E9 RID: 79593
		[Nullable(2)]
		private FNiagaraScriptDataUsageInfo _DataUsage;

		// Token: 0x040136EA RID: 79594
		internal static int __PropertyOffset_DataInterfaceInfo;

		// Token: 0x040136EB RID: 79595
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraScriptDataInterfaceCompileInfo> _DataInterfaceInfo;

		// Token: 0x040136EC RID: 79596
		internal static int __PropertyOffset_CalledVMExternalFunctions;

		// Token: 0x040136ED RID: 79597
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FVMExternalFunctionBindingInfo> _CalledVMExternalFunctions;

		// Token: 0x040136EE RID: 79598
		internal static int __PropertyOffset_ReadDataSets;

		// Token: 0x040136EF RID: 79599
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraDataSetID> _ReadDataSets;

		// Token: 0x040136F0 RID: 79600
		internal static int __PropertyOffset_WriteDataSets;

		// Token: 0x040136F1 RID: 79601
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraDataSetProperties> _WriteDataSets;

		// Token: 0x040136F2 RID: 79602
		internal static int __PropertyOffset_StatScopes;

		// Token: 0x040136F3 RID: 79603
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraStatScope> _StatScopes;

		// Token: 0x040136F4 RID: 79604
		internal static int __PropertyOffset_DIParamInfo;

		// Token: 0x040136F5 RID: 79605
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraDataInterfaceGPUParamInfo> _DIParamInfo;

		// Token: 0x040136F6 RID: 79606
		internal static int __PropertyOffset_LastCompileStatus;

		// Token: 0x040136F7 RID: 79607
		internal static int __PropertyOffset_SimulationStageMetaData;

		// Token: 0x040136F8 RID: 79608
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSimulationStageMetaData> _SimulationStageMetaData;

		// Token: 0x040136F9 RID: 79609
		internal static int __PropertyOffset_ExperimentalContextData;

		// Token: 0x040136FA RID: 79610
		[Nullable(2)]
		private TArray<byte> _ExperimentalContextData;

		// Token: 0x040136FB RID: 79611
		internal static int __PropertyOffset_bReadsSignificanceIndex;

		// Token: 0x040136FC RID: 79612
		internal static byte __PropertyMask_bReadsSignificanceIndex;
	}
}
