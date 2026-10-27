using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025DC RID: 9692
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraScript")]
	[UnrealStructLayout(2800, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2800)]
	public class UNiagaraScript : UNiagaraScriptBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024067 RID: 147559 RVA: 0x00354D07 File Offset: 0x00352F07
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraScript._ClassPtr;
		}

		// Token: 0x06024068 RID: 147560 RVA: 0x00354D14 File Offset: 0x00352F14
		public UNiagaraScript() : this(BuiltinUtils.AllocNativeUObject(UNiagaraScript.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024069 RID: 147561 RVA: 0x00354D3C File Offset: 0x00352F3C
		public UNiagaraScript(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraScript.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008A97 RID: 35479
		// (get) Token: 0x0602406A RID: 147562 RVA: 0x00354D6F File Offset: 0x00352F6F
		// (set) Token: 0x0602406B RID: 147563 RVA: 0x00354D7F File Offset: 0x00352F7F
		public unsafe ENiagaraScriptUsage Usage
		{
			get
			{
				return (ENiagaraScriptUsage)(*(base.NativePtr + (IntPtr)UNiagaraScript.__PropertyOffset_Usage));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraScript.__PropertyOffset_Usage) = (byte)value;
			}
		}

		// Token: 0x17008A98 RID: 35480
		// (get) Token: 0x0602406C RID: 147564 RVA: 0x00354D90 File Offset: 0x00352F90
		// (set) Token: 0x0602406D RID: 147565 RVA: 0x00354DA0 File Offset: 0x00352FA0
		public unsafe int UsageIndex_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraScript.__PropertyOffset_UsageIndex_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraScript.__PropertyOffset_UsageIndex_DEPRECATED) = value;
			}
		}

		// Token: 0x17008A99 RID: 35481
		// (get) Token: 0x0602406E RID: 147566 RVA: 0x00354DB1 File Offset: 0x00352FB1
		// (set) Token: 0x0602406F RID: 147567 RVA: 0x00354DC5 File Offset: 0x00352FC5
		public unsafe FGuid UsageId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraScript.__PropertyOffset_UsageId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraScript.__PropertyOffset_UsageId) = value;
			}
		}

		// Token: 0x17008A9A RID: 35482
		// (get) Token: 0x06024070 RID: 147568 RVA: 0x00354DDC File Offset: 0x00352FDC
		// (set) Token: 0x06024071 RID: 147569 RVA: 0x00354E15 File Offset: 0x00353015
		public FNiagaraParameterStore RapidIterationParameters
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraParameterStore result;
				if ((result = this._RapidIterationParameters) == null)
				{
					result = (this._RapidIterationParameters = new FNiagaraParameterStore(base.NativePtr + (IntPtr)UNiagaraScript.__PropertyOffset_RapidIterationParameters, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraParameterStore.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraScript.__PropertyOffset_RapidIterationParameters, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008A9B RID: 35483
		// (get) Token: 0x06024072 RID: 147570 RVA: 0x00354E38 File Offset: 0x00353038
		// (set) Token: 0x06024073 RID: 147571 RVA: 0x00354E71 File Offset: 0x00353071
		public FNiagaraScriptExecutionParameterStore ScriptExecutionParamStore
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraScriptExecutionParameterStore result;
				if ((result = this._ScriptExecutionParamStore) == null)
				{
					result = (this._ScriptExecutionParamStore = new FNiagaraScriptExecutionParameterStore(base.NativePtr + (IntPtr)UNiagaraScript.__PropertyOffset_ScriptExecutionParamStore, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraScriptExecutionParameterStore.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraScript.__PropertyOffset_ScriptExecutionParamStore, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008A9C RID: 35484
		// (get) Token: 0x06024074 RID: 147572 RVA: 0x00354E94 File Offset: 0x00353094
		// (set) Token: 0x06024075 RID: 147573 RVA: 0x00354ECD File Offset: 0x003530CD
		public TArray<FNiagaraBoundParameter> ScriptExecutionBoundParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraBoundParameter> result;
				if ((result = this._ScriptExecutionBoundParameters) == null)
				{
					result = (this._ScriptExecutionBoundParameters = new TArray<FNiagaraBoundParameter>(base.NativePtr + (IntPtr)UNiagaraScript.__PropertyOffset_ScriptExecutionBoundParameters, this));
				}
				return result;
			}
			set
			{
				this.ScriptExecutionBoundParameters.CopyAssign(value);
			}
		}

		// Token: 0x17008A9D RID: 35485
		// (get) Token: 0x06024076 RID: 147574 RVA: 0x00354EDC File Offset: 0x003530DC
		// (set) Token: 0x06024077 RID: 147575 RVA: 0x00354F15 File Offset: 0x00353115
		public FNiagaraVMExecutableDataId CachedScriptVMId
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVMExecutableDataId result;
				if ((result = this._CachedScriptVMId) == null)
				{
					result = (this._CachedScriptVMId = new FNiagaraVMExecutableDataId(base.NativePtr + (IntPtr)UNiagaraScript.__PropertyOffset_CachedScriptVMId, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVMExecutableDataId.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraScript.__PropertyOffset_CachedScriptVMId, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008A9E RID: 35486
		// (get) Token: 0x06024078 RID: 147576 RVA: 0x00354F38 File Offset: 0x00353138
		// (set) Token: 0x06024079 RID: 147577 RVA: 0x00354F71 File Offset: 0x00353171
		public FNiagaraVMExecutableData CachedScriptVM
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVMExecutableData result;
				if ((result = this._CachedScriptVM) == null)
				{
					result = (this._CachedScriptVM = new FNiagaraVMExecutableData(base.NativePtr + (IntPtr)UNiagaraScript.__PropertyOffset_CachedScriptVM, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVMExecutableData.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraScript.__PropertyOffset_CachedScriptVM, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008A9F RID: 35487
		// (get) Token: 0x0602407A RID: 147578 RVA: 0x00354F94 File Offset: 0x00353194
		// (set) Token: 0x0602407B RID: 147579 RVA: 0x00354FCD File Offset: 0x003531CD
		public TArray<UNiagaraParameterCollection> CachedParameterCollectionReferences
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UNiagaraParameterCollection> result;
				if ((result = this._CachedParameterCollectionReferences) == null)
				{
					result = (this._CachedParameterCollectionReferences = new TArray<UNiagaraParameterCollection>(base.NativePtr + (IntPtr)UNiagaraScript.__PropertyOffset_CachedParameterCollectionReferences, this));
				}
				return result;
			}
			set
			{
				this.CachedParameterCollectionReferences.CopyAssign(value);
			}
		}

		// Token: 0x17008AA0 RID: 35488
		// (get) Token: 0x0602407C RID: 147580 RVA: 0x00354FDC File Offset: 0x003531DC
		// (set) Token: 0x0602407D RID: 147581 RVA: 0x00355015 File Offset: 0x00353215
		public TArray<FNiagaraScriptDataInterfaceInfo> CachedDefaultDataInterfaces
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraScriptDataInterfaceInfo> result;
				if ((result = this._CachedDefaultDataInterfaces) == null)
				{
					result = (this._CachedDefaultDataInterfaces = new TArray<FNiagaraScriptDataInterfaceInfo>(base.NativePtr + (IntPtr)UNiagaraScript.__PropertyOffset_CachedDefaultDataInterfaces, this));
				}
				return result;
			}
			set
			{
				this.CachedDefaultDataInterfaces.CopyAssign(value);
			}
		}

		// Token: 0x0602407E RID: 147582 RVA: 0x00355023 File Offset: 0x00353223
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void RaiseOnGPUCompilationComplete()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UNiagaraScript.__RaiseOnGPUCompilationComplete_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602407F RID: 147583 RVA: 0x00355038 File Offset: 0x00353238
		static UNiagaraScript()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraScript");
		}

		// Token: 0x06024080 RID: 147584 RVA: 0x00355046 File Offset: 0x00353246
		protected UNiagaraScript(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013520 RID: 79136
		public new const string __ObjectPath = "/Script/Niagara.NiagaraScript";

		// Token: 0x04013521 RID: 79137
		private static IntPtr _ClassPtr;

		// Token: 0x04013522 RID: 79138
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013523 RID: 79139
		internal static int __PropertyOffset_Usage;

		// Token: 0x04013524 RID: 79140
		internal static int __PropertyOffset_UsageIndex_DEPRECATED;

		// Token: 0x04013525 RID: 79141
		internal static int __PropertyOffset_UsageId;

		// Token: 0x04013526 RID: 79142
		internal static int __PropertyOffset_RapidIterationParameters;

		// Token: 0x04013527 RID: 79143
		[Nullable(2)]
		private FNiagaraParameterStore _RapidIterationParameters;

		// Token: 0x04013528 RID: 79144
		internal static int __PropertyOffset_ScriptExecutionParamStore;

		// Token: 0x04013529 RID: 79145
		[Nullable(2)]
		private FNiagaraScriptExecutionParameterStore _ScriptExecutionParamStore;

		// Token: 0x0401352A RID: 79146
		internal static int __PropertyOffset_ScriptExecutionBoundParameters;

		// Token: 0x0401352B RID: 79147
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraBoundParameter> _ScriptExecutionBoundParameters;

		// Token: 0x0401352C RID: 79148
		internal static int __PropertyOffset_CachedScriptVMId;

		// Token: 0x0401352D RID: 79149
		[Nullable(2)]
		private FNiagaraVMExecutableDataId _CachedScriptVMId;

		// Token: 0x0401352E RID: 79150
		internal static int __PropertyOffset_CachedScriptVM;

		// Token: 0x0401352F RID: 79151
		[Nullable(2)]
		private FNiagaraVMExecutableData _CachedScriptVM;

		// Token: 0x04013530 RID: 79152
		internal static int __PropertyOffset_CachedParameterCollectionReferences;

		// Token: 0x04013531 RID: 79153
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UNiagaraParameterCollection> _CachedParameterCollectionReferences;

		// Token: 0x04013532 RID: 79154
		internal static int __PropertyOffset_CachedDefaultDataInterfaces;

		// Token: 0x04013533 RID: 79155
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraScriptDataInterfaceInfo> _CachedDefaultDataInterfaces;

		// Token: 0x04013534 RID: 79156
		private static IntPtr __RaiseOnGPUCompilationComplete_NativeFunctionPtr;
	}
}
