using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002572 RID: 9586
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceDataChannelWrite")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UNiagaraDataInterfaceDataChannelWrite : UNiagaraDataInterface, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602396C RID: 145772 RVA: 0x00349C2D File Offset: 0x00347E2D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceDataChannelWrite._ClassPtr;
		}

		// Token: 0x0602396D RID: 145773 RVA: 0x00349C3C File Offset: 0x00347E3C
		public UNiagaraDataInterfaceDataChannelWrite() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceDataChannelWrite.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602396E RID: 145774 RVA: 0x00349C64 File Offset: 0x00347E64
		public UNiagaraDataInterfaceDataChannelWrite(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceDataChannelWrite.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008891 RID: 34961
		// (get) Token: 0x0602396F RID: 145775 RVA: 0x00349C97 File Offset: 0x00347E97
		// (set) Token: 0x06023970 RID: 145776 RVA: 0x00349CA7 File Offset: 0x00347EA7
		public unsafe ENiagaraDataChannelAllocationMode AllocationMode
		{
			get
			{
				return (ENiagaraDataChannelAllocationMode)(*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceDataChannelWrite.__PropertyOffset_AllocationMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceDataChannelWrite.__PropertyOffset_AllocationMode) = (byte)value;
			}
		}

		// Token: 0x17008892 RID: 34962
		// (get) Token: 0x06023971 RID: 145777 RVA: 0x00349CB8 File Offset: 0x00347EB8
		// (set) Token: 0x06023972 RID: 145778 RVA: 0x00349CC8 File Offset: 0x00347EC8
		public unsafe uint AllocationCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceDataChannelWrite.__PropertyOffset_AllocationCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceDataChannelWrite.__PropertyOffset_AllocationCount) = (int)value;
			}
		}

		// Token: 0x17008893 RID: 34963
		// (get) Token: 0x06023973 RID: 145779 RVA: 0x00349CD9 File Offset: 0x00347ED9
		// (set) Token: 0x06023974 RID: 145780 RVA: 0x00349CE9 File Offset: 0x00347EE9
		public unsafe bool bPublishToGame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceDataChannelWrite.__PropertyOffset_bPublishToGame) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceDataChannelWrite.__PropertyOffset_bPublishToGame) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008894 RID: 34964
		// (get) Token: 0x06023975 RID: 145781 RVA: 0x00349CFA File Offset: 0x00347EFA
		// (set) Token: 0x06023976 RID: 145782 RVA: 0x00349D0A File Offset: 0x00347F0A
		public unsafe bool bPublishToCPU
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceDataChannelWrite.__PropertyOffset_bPublishToCPU) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceDataChannelWrite.__PropertyOffset_bPublishToCPU) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008895 RID: 34965
		// (get) Token: 0x06023977 RID: 145783 RVA: 0x00349D1B File Offset: 0x00347F1B
		// (set) Token: 0x06023978 RID: 145784 RVA: 0x00349D2B File Offset: 0x00347F2B
		public unsafe bool bPublishToGPU
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceDataChannelWrite.__PropertyOffset_bPublishToGPU) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceDataChannelWrite.__PropertyOffset_bPublishToGPU) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008896 RID: 34966
		// (get) Token: 0x06023979 RID: 145785 RVA: 0x00349D3C File Offset: 0x00347F3C
		// (set) Token: 0x0602397A RID: 145786 RVA: 0x00349D4C File Offset: 0x00347F4C
		public unsafe bool bUpdateDestinationDataEveryTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceDataChannelWrite.__PropertyOffset_bUpdateDestinationDataEveryTick) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceDataChannelWrite.__PropertyOffset_bUpdateDestinationDataEveryTick) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008897 RID: 34967
		// (get) Token: 0x0602397B RID: 145787 RVA: 0x00349D5D File Offset: 0x00347F5D
		// (set) Token: 0x0602397C RID: 145788 RVA: 0x00349D71 File Offset: 0x00347F71
		[Nullable(2)]
		public unsafe UNiagaraDataChannelAsset Channel
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraDataChannelAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceDataChannelWrite.__PropertyOffset_Channel);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceDataChannelWrite.__PropertyOffset_Channel, value);
			}
		}

		// Token: 0x17008898 RID: 34968
		// (get) Token: 0x0602397D RID: 145789 RVA: 0x00349D88 File Offset: 0x00347F88
		// (set) Token: 0x0602397E RID: 145790 RVA: 0x00349DC1 File Offset: 0x00347FC1
		public FNDIDataChannelWriteCompiledData CompiledData
		{
			get
			{
				base.FastCheckIsValid();
				FNDIDataChannelWriteCompiledData result;
				if ((result = this._CompiledData) == null)
				{
					result = (this._CompiledData = new FNDIDataChannelWriteCompiledData(base.NativePtr + (IntPtr)UNiagaraDataInterfaceDataChannelWrite.__PropertyOffset_CompiledData, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNDIDataChannelWriteCompiledData.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraDataInterfaceDataChannelWrite.__PropertyOffset_CompiledData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602397F RID: 145791 RVA: 0x00349DE2 File Offset: 0x00347FE2
		static UNiagaraDataInterfaceDataChannelWrite()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceDataChannelWrite");
		}

		// Token: 0x06023980 RID: 145792 RVA: 0x00349DF0 File Offset: 0x00347FF0
		protected UNiagaraDataInterfaceDataChannelWrite(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013140 RID: 78144
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceDataChannelWrite";

		// Token: 0x04013141 RID: 78145
		private static IntPtr _ClassPtr;

		// Token: 0x04013142 RID: 78146
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013143 RID: 78147
		internal static int __PropertyOffset_AllocationMode;

		// Token: 0x04013144 RID: 78148
		internal static int __PropertyOffset_AllocationCount;

		// Token: 0x04013145 RID: 78149
		internal static int __PropertyOffset_bPublishToGame;

		// Token: 0x04013146 RID: 78150
		internal static int __PropertyOffset_bPublishToCPU;

		// Token: 0x04013147 RID: 78151
		internal static int __PropertyOffset_bPublishToGPU;

		// Token: 0x04013148 RID: 78152
		internal static int __PropertyOffset_bUpdateDestinationDataEveryTick;

		// Token: 0x04013149 RID: 78153
		internal static int __PropertyOffset_Channel;

		// Token: 0x0401314A RID: 78154
		internal static int __PropertyOffset_CompiledData;

		// Token: 0x0401314B RID: 78155
		[Nullable(2)]
		private FNDIDataChannelWriteCompiledData _CompiledData;
	}
}
