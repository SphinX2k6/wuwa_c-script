using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002549 RID: 9545
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataChannel")]
	[UnrealStructLayout(336, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 336)]
	public abstract class UNiagaraDataChannel : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023784 RID: 145284 RVA: 0x00346ECD File Offset: 0x003450CD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataChannel._ClassPtr;
		}

		// Token: 0x17008839 RID: 34873
		// (get) Token: 0x06023785 RID: 145285 RVA: 0x00346EDC File Offset: 0x003450DC
		// (set) Token: 0x06023786 RID: 145286 RVA: 0x00346F15 File Offset: 0x00345115
		public TArray<FNiagaraDataChannelVariable> ChannelVariables
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraDataChannelVariable> result;
				if ((result = this._ChannelVariables) == null)
				{
					result = (this._ChannelVariables = new TArray<FNiagaraDataChannelVariable>(base.NativePtr + (IntPtr)UNiagaraDataChannel.__PropertyOffset_ChannelVariables, this));
				}
				return result;
			}
			set
			{
				this.ChannelVariables.CopyAssign(value);
			}
		}

		// Token: 0x1700883A RID: 34874
		// (get) Token: 0x06023787 RID: 145287 RVA: 0x00346F23 File Offset: 0x00345123
		// (set) Token: 0x06023788 RID: 145288 RVA: 0x00346F33 File Offset: 0x00345133
		public unsafe bool bKeepPreviousFrameData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataChannel.__PropertyOffset_bKeepPreviousFrameData) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataChannel.__PropertyOffset_bKeepPreviousFrameData) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700883B RID: 34875
		// (get) Token: 0x06023789 RID: 145289 RVA: 0x00346F44 File Offset: 0x00345144
		// (set) Token: 0x0602378A RID: 145290 RVA: 0x00346F54 File Offset: 0x00345154
		public unsafe bool bEnforceTickGroupReadWriteOrder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataChannel.__PropertyOffset_bEnforceTickGroupReadWriteOrder) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataChannel.__PropertyOffset_bEnforceTickGroupReadWriteOrder) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700883C RID: 34876
		// (get) Token: 0x0602378B RID: 145291 RVA: 0x00346F65 File Offset: 0x00345165
		// (set) Token: 0x0602378C RID: 145292 RVA: 0x00346F79 File Offset: 0x00345179
		[Nullable(0)]
		public unsafe TEnumAsByte<ETickingGroup> FinalWriteTickGroup
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataChannel.__PropertyOffset_FinalWriteTickGroup);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataChannel.__PropertyOffset_FinalWriteTickGroup) = value;
			}
		}

		// Token: 0x1700883D RID: 34877
		// (get) Token: 0x0602378D RID: 145293 RVA: 0x00346F90 File Offset: 0x00345190
		// (set) Token: 0x0602378E RID: 145294 RVA: 0x00346FC9 File Offset: 0x003451C9
		public FNiagaraDataSetCompiledData CompiledData
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraDataSetCompiledData result;
				if ((result = this._CompiledData) == null)
				{
					result = (this._CompiledData = new FNiagaraDataSetCompiledData(base.NativePtr + (IntPtr)UNiagaraDataChannel.__PropertyOffset_CompiledData, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraDataSetCompiledData.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraDataChannel.__PropertyOffset_CompiledData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700883E RID: 34878
		// (get) Token: 0x0602378F RID: 145295 RVA: 0x00346FEC File Offset: 0x003451EC
		// (set) Token: 0x06023790 RID: 145296 RVA: 0x00347025 File Offset: 0x00345225
		public FNiagaraDataSetCompiledData CompiledDataGPU
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraDataSetCompiledData result;
				if ((result = this._CompiledDataGPU) == null)
				{
					result = (this._CompiledDataGPU = new FNiagaraDataSetCompiledData(base.NativePtr + (IntPtr)UNiagaraDataChannel.__PropertyOffset_CompiledDataGPU, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraDataSetCompiledData.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraDataChannel.__PropertyOffset_CompiledDataGPU, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06023791 RID: 145297 RVA: 0x00347046 File Offset: 0x00345246
		static UNiagaraDataChannel()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataChannel");
		}

		// Token: 0x06023792 RID: 145298 RVA: 0x00347054 File Offset: 0x00345254
		protected UNiagaraDataChannel() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataChannel.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023793 RID: 145299 RVA: 0x0034707C File Offset: 0x0034527C
		protected UNiagaraDataChannel(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401304C RID: 77900
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataChannel";

		// Token: 0x0401304D RID: 77901
		private static IntPtr _ClassPtr;

		// Token: 0x0401304E RID: 77902
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401304F RID: 77903
		internal static int __PropertyOffset_ChannelVariables;

		// Token: 0x04013050 RID: 77904
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraDataChannelVariable> _ChannelVariables;

		// Token: 0x04013051 RID: 77905
		internal static int __PropertyOffset_bKeepPreviousFrameData;

		// Token: 0x04013052 RID: 77906
		internal static int __PropertyOffset_bEnforceTickGroupReadWriteOrder;

		// Token: 0x04013053 RID: 77907
		internal static int __PropertyOffset_FinalWriteTickGroup;

		// Token: 0x04013054 RID: 77908
		internal static int __PropertyOffset_CompiledData;

		// Token: 0x04013055 RID: 77909
		[Nullable(2)]
		private FNiagaraDataSetCompiledData _CompiledData;

		// Token: 0x04013056 RID: 77910
		internal static int __PropertyOffset_CompiledDataGPU;

		// Token: 0x04013057 RID: 77911
		[Nullable(2)]
		private FNiagaraDataSetCompiledData _CompiledDataGPU;
	}
}
