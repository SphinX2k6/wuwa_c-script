using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002590 RID: 9616
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataSetCompiledData")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FNiagaraDataSetCompiledData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023AEC RID: 146156 RVA: 0x0034C307 File Offset: 0x0034A507
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraDataSetCompiledData._ScriptStructPtr != 0) ? FNiagaraDataSetCompiledData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraDataSetCompiledData", ref FNiagaraDataSetCompiledData._ScriptStructPtr);
		}

		// Token: 0x170088FE RID: 35070
		// (get) Token: 0x06023AED RID: 146157 RVA: 0x0034C32C File Offset: 0x0034A52C
		// (set) Token: 0x06023AEE RID: 146158 RVA: 0x0034C36F File Offset: 0x0034A56F
		public TArray<FNiagaraVariable> Variables
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraVariable> result;
				if ((result = this._Variables) == null)
				{
					result = (this._Variables = new TArray<FNiagaraVariable>(base.NativePtr + (IntPtr)FNiagaraDataSetCompiledData.__PropertyOffset_Variables, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Variables.CopyAssign(value);
			}
		}

		// Token: 0x170088FF RID: 35071
		// (get) Token: 0x06023AEF RID: 146159 RVA: 0x0034C380 File Offset: 0x0034A580
		// (set) Token: 0x06023AF0 RID: 146160 RVA: 0x0034C3C3 File Offset: 0x0034A5C3
		public TArray<FNiagaraVariableLayoutInfo> VariableLayouts
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraVariableLayoutInfo> result;
				if ((result = this._VariableLayouts) == null)
				{
					result = (this._VariableLayouts = new TArray<FNiagaraVariableLayoutInfo>(base.NativePtr + (IntPtr)FNiagaraDataSetCompiledData.__PropertyOffset_VariableLayouts, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.VariableLayouts.CopyAssign(value);
			}
		}

		// Token: 0x17008900 RID: 35072
		// (get) Token: 0x06023AF1 RID: 146161 RVA: 0x0034C3D4 File Offset: 0x0034A5D4
		// (set) Token: 0x06023AF2 RID: 146162 RVA: 0x0034C417 File Offset: 0x0034A617
		public FNiagaraDataSetID ID
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraDataSetID result;
				if ((result = this._ID) == null)
				{
					result = (this._ID = new FNiagaraDataSetID(base.NativePtr + (IntPtr)FNiagaraDataSetCompiledData.__PropertyOffset_ID, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraDataSetID.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraDataSetCompiledData.__PropertyOffset_ID, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008901 RID: 35073
		// (get) Token: 0x06023AF3 RID: 146163 RVA: 0x0034C438 File Offset: 0x0034A638
		// (set) Token: 0x06023AF4 RID: 146164 RVA: 0x0034C448 File Offset: 0x0034A648
		public unsafe uint TotalFloatComponents
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDataSetCompiledData.__PropertyOffset_TotalFloatComponents);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDataSetCompiledData.__PropertyOffset_TotalFloatComponents) = (int)value;
			}
		}

		// Token: 0x17008902 RID: 35074
		// (get) Token: 0x06023AF5 RID: 146165 RVA: 0x0034C459 File Offset: 0x0034A659
		// (set) Token: 0x06023AF6 RID: 146166 RVA: 0x0034C469 File Offset: 0x0034A669
		public unsafe uint TotalInt32Components
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDataSetCompiledData.__PropertyOffset_TotalInt32Components);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDataSetCompiledData.__PropertyOffset_TotalInt32Components) = (int)value;
			}
		}

		// Token: 0x17008903 RID: 35075
		// (get) Token: 0x06023AF7 RID: 146167 RVA: 0x0034C47A File Offset: 0x0034A67A
		// (set) Token: 0x06023AF8 RID: 146168 RVA: 0x0034C48A File Offset: 0x0034A68A
		public unsafe uint TotalHalfComponents
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDataSetCompiledData.__PropertyOffset_TotalHalfComponents);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDataSetCompiledData.__PropertyOffset_TotalHalfComponents) = (int)value;
			}
		}

		// Token: 0x17008904 RID: 35076
		// (get) Token: 0x06023AF9 RID: 146169 RVA: 0x0034C49B File Offset: 0x0034A69B
		// (set) Token: 0x06023AFA RID: 146170 RVA: 0x0034C4B4 File Offset: 0x0034A6B4
		public unsafe bool bRequiresPersistentIDs
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNiagaraDataSetCompiledData.__PropertyOffset_bRequiresPersistentIDs) & FNiagaraDataSetCompiledData.__PropertyMask_bRequiresPersistentIDs) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNiagaraDataSetCompiledData.__PropertyOffset_bRequiresPersistentIDs) = ((*(base.NativePtr + (IntPtr)FNiagaraDataSetCompiledData.__PropertyOffset_bRequiresPersistentIDs) & ~FNiagaraDataSetCompiledData.__PropertyMask_bRequiresPersistentIDs) | (value ? FNiagaraDataSetCompiledData.__PropertyMask_bRequiresPersistentIDs : 0));
			}
		}

		// Token: 0x17008905 RID: 35077
		// (get) Token: 0x06023AFB RID: 146171 RVA: 0x0034C4E4 File Offset: 0x0034A6E4
		// (set) Token: 0x06023AFC RID: 146172 RVA: 0x0034C4F4 File Offset: 0x0034A6F4
		public unsafe ENiagaraSimTarget SimTarget
		{
			get
			{
				return (ENiagaraSimTarget)(*(base.NativePtr + (IntPtr)FNiagaraDataSetCompiledData.__PropertyOffset_SimTarget));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDataSetCompiledData.__PropertyOffset_SimTarget) = (byte)value;
			}
		}

		// Token: 0x06023AFD RID: 146173 RVA: 0x0034C505 File Offset: 0x0034A705
		public FNiagaraDataSetCompiledData()
		{
		}

		// Token: 0x06023AFE RID: 146174 RVA: 0x0034C510 File Offset: 0x0034A710
		public FNiagaraDataSetCompiledData(TArray<FNiagaraVariable> Variables, TArray<FNiagaraVariableLayoutInfo> VariableLayouts, FNiagaraDataSetID ID, uint TotalFloatComponents, uint TotalInt32Components, uint TotalHalfComponents, bool bRequiresPersistentIDs, ENiagaraSimTarget SimTarget)
		{
			this.Variables = Variables;
			this.VariableLayouts = VariableLayouts;
			this.ID = ID;
			this.TotalFloatComponents = TotalFloatComponents;
			this.TotalInt32Components = TotalInt32Components;
			this.TotalHalfComponents = TotalHalfComponents;
			this.bRequiresPersistentIDs = bRequiresPersistentIDs;
			this.SimTarget = SimTarget;
		}

		// Token: 0x06023AFF RID: 146175 RVA: 0x0034C560 File Offset: 0x0034A760
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraDataSetCompiledData.StaticStruct();
		}

		// Token: 0x06023B00 RID: 146176 RVA: 0x0034C56C File Offset: 0x0034A76C
		[NullableContext(2)]
		public FNiagaraDataSetCompiledData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023B01 RID: 146177 RVA: 0x0034C576 File Offset: 0x0034A776
		public FNiagaraDataSetCompiledData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023B02 RID: 146178 RVA: 0x0034C581 File Offset: 0x0034A781
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraDataSetCompiledData(Pointer, false, true);
		}

		// Token: 0x06023B03 RID: 146179 RVA: 0x0034C58B File Offset: 0x0034A78B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraDataSetCompiledData(Pointer, MemoryOwner);
		}

		// Token: 0x0401322C RID: 78380
		public const string __ObjectPath = "/Script/Niagara.NiagaraDataSetCompiledData";

		// Token: 0x0401322D RID: 78381
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401322E RID: 78382
		internal static int __PropertyOffset_Variables;

		// Token: 0x0401322F RID: 78383
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraVariable> _Variables;

		// Token: 0x04013230 RID: 78384
		internal static int __PropertyOffset_VariableLayouts;

		// Token: 0x04013231 RID: 78385
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraVariableLayoutInfo> _VariableLayouts;

		// Token: 0x04013232 RID: 78386
		internal static int __PropertyOffset_ID;

		// Token: 0x04013233 RID: 78387
		[Nullable(2)]
		private FNiagaraDataSetID _ID;

		// Token: 0x04013234 RID: 78388
		internal static int __PropertyOffset_TotalFloatComponents;

		// Token: 0x04013235 RID: 78389
		internal static int __PropertyOffset_TotalInt32Components;

		// Token: 0x04013236 RID: 78390
		internal static int __PropertyOffset_TotalHalfComponents;

		// Token: 0x04013237 RID: 78391
		internal static int __PropertyOffset_bRequiresPersistentIDs;

		// Token: 0x04013238 RID: 78392
		internal static byte __PropertyMask_bRequiresPersistentIDs;

		// Token: 0x04013239 RID: 78393
		internal static int __PropertyOffset_SimTarget;
	}
}
