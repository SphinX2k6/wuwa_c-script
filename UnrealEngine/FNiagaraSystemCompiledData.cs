using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025F0 RID: 9712
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraSystemCompiledData")]
	[UnrealStructLayout(680, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 680)]
	public class FNiagaraSystemCompiledData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060241FF RID: 147967 RVA: 0x0035762A File Offset: 0x0035582A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraSystemCompiledData._ScriptStructPtr != 0) ? FNiagaraSystemCompiledData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraSystemCompiledData", ref FNiagaraSystemCompiledData._ScriptStructPtr);
		}

		// Token: 0x17008B22 RID: 35618
		// (get) Token: 0x06024200 RID: 147968 RVA: 0x00357650 File Offset: 0x00355850
		// (set) Token: 0x06024201 RID: 147969 RVA: 0x00357693 File Offset: 0x00355893
		public FNiagaraParameterStore InstanceParamStore
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraParameterStore result;
				if ((result = this._InstanceParamStore) == null)
				{
					result = (this._InstanceParamStore = new FNiagaraParameterStore(base.NativePtr + (IntPtr)FNiagaraSystemCompiledData.__PropertyOffset_InstanceParamStore, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraParameterStore.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraSystemCompiledData.__PropertyOffset_InstanceParamStore, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008B23 RID: 35619
		// (get) Token: 0x06024202 RID: 147970 RVA: 0x003576B4 File Offset: 0x003558B4
		// (set) Token: 0x06024203 RID: 147971 RVA: 0x003576F7 File Offset: 0x003558F7
		public FNiagaraDataSetCompiledData DataSetCompiledData
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraDataSetCompiledData result;
				if ((result = this._DataSetCompiledData) == null)
				{
					result = (this._DataSetCompiledData = new FNiagaraDataSetCompiledData(base.NativePtr + (IntPtr)FNiagaraSystemCompiledData.__PropertyOffset_DataSetCompiledData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraDataSetCompiledData.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraSystemCompiledData.__PropertyOffset_DataSetCompiledData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008B24 RID: 35620
		// (get) Token: 0x06024204 RID: 147972 RVA: 0x00357718 File Offset: 0x00355918
		// (set) Token: 0x06024205 RID: 147973 RVA: 0x0035775B File Offset: 0x0035595B
		public FNiagaraDataSetCompiledData SpawnInstanceParamsDataSetCompiledData
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraDataSetCompiledData result;
				if ((result = this._SpawnInstanceParamsDataSetCompiledData) == null)
				{
					result = (this._SpawnInstanceParamsDataSetCompiledData = new FNiagaraDataSetCompiledData(base.NativePtr + (IntPtr)FNiagaraSystemCompiledData.__PropertyOffset_SpawnInstanceParamsDataSetCompiledData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraDataSetCompiledData.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraSystemCompiledData.__PropertyOffset_SpawnInstanceParamsDataSetCompiledData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008B25 RID: 35621
		// (get) Token: 0x06024206 RID: 147974 RVA: 0x0035777C File Offset: 0x0035597C
		// (set) Token: 0x06024207 RID: 147975 RVA: 0x003577BF File Offset: 0x003559BF
		public FNiagaraDataSetCompiledData UpdateInstanceParamsDataSetCompiledData
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraDataSetCompiledData result;
				if ((result = this._UpdateInstanceParamsDataSetCompiledData) == null)
				{
					result = (this._UpdateInstanceParamsDataSetCompiledData = new FNiagaraDataSetCompiledData(base.NativePtr + (IntPtr)FNiagaraSystemCompiledData.__PropertyOffset_UpdateInstanceParamsDataSetCompiledData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraDataSetCompiledData.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraSystemCompiledData.__PropertyOffset_UpdateInstanceParamsDataSetCompiledData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008B26 RID: 35622
		// (get) Token: 0x06024208 RID: 147976 RVA: 0x003577E0 File Offset: 0x003559E0
		// (set) Token: 0x06024209 RID: 147977 RVA: 0x00357823 File Offset: 0x00355A23
		public FNiagaraParameterDataSetBindingCollection SpawnInstanceGlobalBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraParameterDataSetBindingCollection result;
				if ((result = this._SpawnInstanceGlobalBinding) == null)
				{
					result = (this._SpawnInstanceGlobalBinding = new FNiagaraParameterDataSetBindingCollection(base.NativePtr + (IntPtr)FNiagaraSystemCompiledData.__PropertyOffset_SpawnInstanceGlobalBinding, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraParameterDataSetBindingCollection.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraSystemCompiledData.__PropertyOffset_SpawnInstanceGlobalBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008B27 RID: 35623
		// (get) Token: 0x0602420A RID: 147978 RVA: 0x00357844 File Offset: 0x00355A44
		// (set) Token: 0x0602420B RID: 147979 RVA: 0x00357887 File Offset: 0x00355A87
		public FNiagaraParameterDataSetBindingCollection SpawnInstanceSystemBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraParameterDataSetBindingCollection result;
				if ((result = this._SpawnInstanceSystemBinding) == null)
				{
					result = (this._SpawnInstanceSystemBinding = new FNiagaraParameterDataSetBindingCollection(base.NativePtr + (IntPtr)FNiagaraSystemCompiledData.__PropertyOffset_SpawnInstanceSystemBinding, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraParameterDataSetBindingCollection.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraSystemCompiledData.__PropertyOffset_SpawnInstanceSystemBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008B28 RID: 35624
		// (get) Token: 0x0602420C RID: 147980 RVA: 0x003578A8 File Offset: 0x00355AA8
		// (set) Token: 0x0602420D RID: 147981 RVA: 0x003578EB File Offset: 0x00355AEB
		public FNiagaraParameterDataSetBindingCollection SpawnInstanceOwnerBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraParameterDataSetBindingCollection result;
				if ((result = this._SpawnInstanceOwnerBinding) == null)
				{
					result = (this._SpawnInstanceOwnerBinding = new FNiagaraParameterDataSetBindingCollection(base.NativePtr + (IntPtr)FNiagaraSystemCompiledData.__PropertyOffset_SpawnInstanceOwnerBinding, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraParameterDataSetBindingCollection.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraSystemCompiledData.__PropertyOffset_SpawnInstanceOwnerBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008B29 RID: 35625
		// (get) Token: 0x0602420E RID: 147982 RVA: 0x0035790C File Offset: 0x00355B0C
		// (set) Token: 0x0602420F RID: 147983 RVA: 0x0035794F File Offset: 0x00355B4F
		public TArray<FNiagaraParameterDataSetBindingCollection> SpawnInstanceEmitterBindings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraParameterDataSetBindingCollection> result;
				if ((result = this._SpawnInstanceEmitterBindings) == null)
				{
					result = (this._SpawnInstanceEmitterBindings = new TArray<FNiagaraParameterDataSetBindingCollection>(base.NativePtr + (IntPtr)FNiagaraSystemCompiledData.__PropertyOffset_SpawnInstanceEmitterBindings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SpawnInstanceEmitterBindings.CopyAssign(value);
			}
		}

		// Token: 0x17008B2A RID: 35626
		// (get) Token: 0x06024210 RID: 147984 RVA: 0x00357960 File Offset: 0x00355B60
		// (set) Token: 0x06024211 RID: 147985 RVA: 0x003579A3 File Offset: 0x00355BA3
		public FNiagaraParameterDataSetBindingCollection UpdateInstanceGlobalBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraParameterDataSetBindingCollection result;
				if ((result = this._UpdateInstanceGlobalBinding) == null)
				{
					result = (this._UpdateInstanceGlobalBinding = new FNiagaraParameterDataSetBindingCollection(base.NativePtr + (IntPtr)FNiagaraSystemCompiledData.__PropertyOffset_UpdateInstanceGlobalBinding, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraParameterDataSetBindingCollection.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraSystemCompiledData.__PropertyOffset_UpdateInstanceGlobalBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008B2B RID: 35627
		// (get) Token: 0x06024212 RID: 147986 RVA: 0x003579C4 File Offset: 0x00355BC4
		// (set) Token: 0x06024213 RID: 147987 RVA: 0x00357A07 File Offset: 0x00355C07
		public FNiagaraParameterDataSetBindingCollection UpdateInstanceSystemBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraParameterDataSetBindingCollection result;
				if ((result = this._UpdateInstanceSystemBinding) == null)
				{
					result = (this._UpdateInstanceSystemBinding = new FNiagaraParameterDataSetBindingCollection(base.NativePtr + (IntPtr)FNiagaraSystemCompiledData.__PropertyOffset_UpdateInstanceSystemBinding, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraParameterDataSetBindingCollection.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraSystemCompiledData.__PropertyOffset_UpdateInstanceSystemBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008B2C RID: 35628
		// (get) Token: 0x06024214 RID: 147988 RVA: 0x00357A28 File Offset: 0x00355C28
		// (set) Token: 0x06024215 RID: 147989 RVA: 0x00357A6B File Offset: 0x00355C6B
		public FNiagaraParameterDataSetBindingCollection UpdateInstanceOwnerBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraParameterDataSetBindingCollection result;
				if ((result = this._UpdateInstanceOwnerBinding) == null)
				{
					result = (this._UpdateInstanceOwnerBinding = new FNiagaraParameterDataSetBindingCollection(base.NativePtr + (IntPtr)FNiagaraSystemCompiledData.__PropertyOffset_UpdateInstanceOwnerBinding, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraParameterDataSetBindingCollection.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraSystemCompiledData.__PropertyOffset_UpdateInstanceOwnerBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008B2D RID: 35629
		// (get) Token: 0x06024216 RID: 147990 RVA: 0x00357A8C File Offset: 0x00355C8C
		// (set) Token: 0x06024217 RID: 147991 RVA: 0x00357ACF File Offset: 0x00355CCF
		public TArray<FNiagaraParameterDataSetBindingCollection> UpdateInstanceEmitterBindings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraParameterDataSetBindingCollection> result;
				if ((result = this._UpdateInstanceEmitterBindings) == null)
				{
					result = (this._UpdateInstanceEmitterBindings = new TArray<FNiagaraParameterDataSetBindingCollection>(base.NativePtr + (IntPtr)FNiagaraSystemCompiledData.__PropertyOffset_UpdateInstanceEmitterBindings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.UpdateInstanceEmitterBindings.CopyAssign(value);
			}
		}

		// Token: 0x06024218 RID: 147992 RVA: 0x00357ADD File Offset: 0x00355CDD
		public FNiagaraSystemCompiledData()
		{
		}

		// Token: 0x06024219 RID: 147993 RVA: 0x00357AE8 File Offset: 0x00355CE8
		public FNiagaraSystemCompiledData(FNiagaraParameterStore InstanceParamStore, FNiagaraDataSetCompiledData DataSetCompiledData, FNiagaraDataSetCompiledData SpawnInstanceParamsDataSetCompiledData, FNiagaraDataSetCompiledData UpdateInstanceParamsDataSetCompiledData, FNiagaraParameterDataSetBindingCollection SpawnInstanceGlobalBinding, FNiagaraParameterDataSetBindingCollection SpawnInstanceSystemBinding, FNiagaraParameterDataSetBindingCollection SpawnInstanceOwnerBinding, TArray<FNiagaraParameterDataSetBindingCollection> SpawnInstanceEmitterBindings, FNiagaraParameterDataSetBindingCollection UpdateInstanceGlobalBinding, FNiagaraParameterDataSetBindingCollection UpdateInstanceSystemBinding, FNiagaraParameterDataSetBindingCollection UpdateInstanceOwnerBinding, TArray<FNiagaraParameterDataSetBindingCollection> UpdateInstanceEmitterBindings)
		{
			this.InstanceParamStore = InstanceParamStore;
			this.DataSetCompiledData = DataSetCompiledData;
			this.SpawnInstanceParamsDataSetCompiledData = SpawnInstanceParamsDataSetCompiledData;
			this.UpdateInstanceParamsDataSetCompiledData = UpdateInstanceParamsDataSetCompiledData;
			this.SpawnInstanceGlobalBinding = SpawnInstanceGlobalBinding;
			this.SpawnInstanceSystemBinding = SpawnInstanceSystemBinding;
			this.SpawnInstanceOwnerBinding = SpawnInstanceOwnerBinding;
			this.SpawnInstanceEmitterBindings = SpawnInstanceEmitterBindings;
			this.UpdateInstanceGlobalBinding = UpdateInstanceGlobalBinding;
			this.UpdateInstanceSystemBinding = UpdateInstanceSystemBinding;
			this.UpdateInstanceOwnerBinding = UpdateInstanceOwnerBinding;
			this.UpdateInstanceEmitterBindings = UpdateInstanceEmitterBindings;
		}

		// Token: 0x0602421A RID: 147994 RVA: 0x00357B58 File Offset: 0x00355D58
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraSystemCompiledData.StaticStruct();
		}

		// Token: 0x0602421B RID: 147995 RVA: 0x00357B64 File Offset: 0x00355D64
		[NullableContext(2)]
		public FNiagaraSystemCompiledData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602421C RID: 147996 RVA: 0x00357B6E File Offset: 0x00355D6E
		public FNiagaraSystemCompiledData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602421D RID: 147997 RVA: 0x00357B79 File Offset: 0x00355D79
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraSystemCompiledData(Pointer, false, true);
		}

		// Token: 0x0602421E RID: 147998 RVA: 0x00357B83 File Offset: 0x00355D83
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraSystemCompiledData(Pointer, MemoryOwner);
		}

		// Token: 0x0401361D RID: 79389
		public const string __ObjectPath = "/Script/Niagara.NiagaraSystemCompiledData";

		// Token: 0x0401361E RID: 79390
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401361F RID: 79391
		internal static int __PropertyOffset_InstanceParamStore;

		// Token: 0x04013620 RID: 79392
		[Nullable(2)]
		private FNiagaraParameterStore _InstanceParamStore;

		// Token: 0x04013621 RID: 79393
		internal static int __PropertyOffset_DataSetCompiledData;

		// Token: 0x04013622 RID: 79394
		[Nullable(2)]
		private FNiagaraDataSetCompiledData _DataSetCompiledData;

		// Token: 0x04013623 RID: 79395
		internal static int __PropertyOffset_SpawnInstanceParamsDataSetCompiledData;

		// Token: 0x04013624 RID: 79396
		[Nullable(2)]
		private FNiagaraDataSetCompiledData _SpawnInstanceParamsDataSetCompiledData;

		// Token: 0x04013625 RID: 79397
		internal static int __PropertyOffset_UpdateInstanceParamsDataSetCompiledData;

		// Token: 0x04013626 RID: 79398
		[Nullable(2)]
		private FNiagaraDataSetCompiledData _UpdateInstanceParamsDataSetCompiledData;

		// Token: 0x04013627 RID: 79399
		internal static int __PropertyOffset_SpawnInstanceGlobalBinding;

		// Token: 0x04013628 RID: 79400
		[Nullable(2)]
		private FNiagaraParameterDataSetBindingCollection _SpawnInstanceGlobalBinding;

		// Token: 0x04013629 RID: 79401
		internal static int __PropertyOffset_SpawnInstanceSystemBinding;

		// Token: 0x0401362A RID: 79402
		[Nullable(2)]
		private FNiagaraParameterDataSetBindingCollection _SpawnInstanceSystemBinding;

		// Token: 0x0401362B RID: 79403
		internal static int __PropertyOffset_SpawnInstanceOwnerBinding;

		// Token: 0x0401362C RID: 79404
		[Nullable(2)]
		private FNiagaraParameterDataSetBindingCollection _SpawnInstanceOwnerBinding;

		// Token: 0x0401362D RID: 79405
		internal static int __PropertyOffset_SpawnInstanceEmitterBindings;

		// Token: 0x0401362E RID: 79406
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraParameterDataSetBindingCollection> _SpawnInstanceEmitterBindings;

		// Token: 0x0401362F RID: 79407
		internal static int __PropertyOffset_UpdateInstanceGlobalBinding;

		// Token: 0x04013630 RID: 79408
		[Nullable(2)]
		private FNiagaraParameterDataSetBindingCollection _UpdateInstanceGlobalBinding;

		// Token: 0x04013631 RID: 79409
		internal static int __PropertyOffset_UpdateInstanceSystemBinding;

		// Token: 0x04013632 RID: 79410
		[Nullable(2)]
		private FNiagaraParameterDataSetBindingCollection _UpdateInstanceSystemBinding;

		// Token: 0x04013633 RID: 79411
		internal static int __PropertyOffset_UpdateInstanceOwnerBinding;

		// Token: 0x04013634 RID: 79412
		[Nullable(2)]
		private FNiagaraParameterDataSetBindingCollection _UpdateInstanceOwnerBinding;

		// Token: 0x04013635 RID: 79413
		internal static int __PropertyOffset_UpdateInstanceEmitterBindings;

		// Token: 0x04013636 RID: 79414
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraParameterDataSetBindingCollection> _UpdateInstanceEmitterBindings;
	}
}
