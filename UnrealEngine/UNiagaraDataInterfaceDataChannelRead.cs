using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002571 RID: 9585
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceDataChannelRead")]
	[UnrealStructLayout(328, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 328)]
	public class UNiagaraDataInterfaceDataChannelRead : UNiagaraDataInterfaceRWBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602395D RID: 145757 RVA: 0x00349AC6 File Offset: 0x00347CC6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceDataChannelRead._ClassPtr;
		}

		// Token: 0x0602395E RID: 145758 RVA: 0x00349AD4 File Offset: 0x00347CD4
		public UNiagaraDataInterfaceDataChannelRead() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceDataChannelRead.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602395F RID: 145759 RVA: 0x00349AFC File Offset: 0x00347CFC
		public UNiagaraDataInterfaceDataChannelRead(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceDataChannelRead.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700888C RID: 34956
		// (get) Token: 0x06023960 RID: 145760 RVA: 0x00349B2F File Offset: 0x00347D2F
		// (set) Token: 0x06023961 RID: 145761 RVA: 0x00349B43 File Offset: 0x00347D43
		[Nullable(2)]
		public unsafe UNiagaraDataChannelAsset Channel
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraDataChannelAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceDataChannelRead.__PropertyOffset_Channel);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceDataChannelRead.__PropertyOffset_Channel, value);
			}
		}

		// Token: 0x1700888D RID: 34957
		// (get) Token: 0x06023962 RID: 145762 RVA: 0x00349B58 File Offset: 0x00347D58
		// (set) Token: 0x06023963 RID: 145763 RVA: 0x00349B68 File Offset: 0x00347D68
		public unsafe bool bReadCurrentFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceDataChannelRead.__PropertyOffset_bReadCurrentFrame) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceDataChannelRead.__PropertyOffset_bReadCurrentFrame) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700888E RID: 34958
		// (get) Token: 0x06023964 RID: 145764 RVA: 0x00349B79 File Offset: 0x00347D79
		// (set) Token: 0x06023965 RID: 145765 RVA: 0x00349B89 File Offset: 0x00347D89
		public unsafe bool bUpdateSourceDataEveryTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceDataChannelRead.__PropertyOffset_bUpdateSourceDataEveryTick) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceDataChannelRead.__PropertyOffset_bUpdateSourceDataEveryTick) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700888F RID: 34959
		// (get) Token: 0x06023966 RID: 145766 RVA: 0x00349B9A File Offset: 0x00347D9A
		// (set) Token: 0x06023967 RID: 145767 RVA: 0x00349BAA File Offset: 0x00347DAA
		public unsafe bool bOverrideSpawnGroupToDataChannelIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceDataChannelRead.__PropertyOffset_bOverrideSpawnGroupToDataChannelIndex) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceDataChannelRead.__PropertyOffset_bOverrideSpawnGroupToDataChannelIndex) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008890 RID: 34960
		// (get) Token: 0x06023968 RID: 145768 RVA: 0x00349BBC File Offset: 0x00347DBC
		// (set) Token: 0x06023969 RID: 145769 RVA: 0x00349BF5 File Offset: 0x00347DF5
		public FNDIDataChannelCompiledData CompiledData
		{
			get
			{
				base.FastCheckIsValid();
				FNDIDataChannelCompiledData result;
				if ((result = this._CompiledData) == null)
				{
					result = (this._CompiledData = new FNDIDataChannelCompiledData(base.NativePtr + (IntPtr)UNiagaraDataInterfaceDataChannelRead.__PropertyOffset_CompiledData, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNDIDataChannelCompiledData.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraDataInterfaceDataChannelRead.__PropertyOffset_CompiledData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602396A RID: 145770 RVA: 0x00349C16 File Offset: 0x00347E16
		static UNiagaraDataInterfaceDataChannelRead()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceDataChannelRead");
		}

		// Token: 0x0602396B RID: 145771 RVA: 0x00349C24 File Offset: 0x00347E24
		protected UNiagaraDataInterfaceDataChannelRead(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013137 RID: 78135
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceDataChannelRead";

		// Token: 0x04013138 RID: 78136
		private static IntPtr _ClassPtr;

		// Token: 0x04013139 RID: 78137
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401313A RID: 78138
		internal static int __PropertyOffset_Channel;

		// Token: 0x0401313B RID: 78139
		internal static int __PropertyOffset_bReadCurrentFrame;

		// Token: 0x0401313C RID: 78140
		internal static int __PropertyOffset_bUpdateSourceDataEveryTick;

		// Token: 0x0401313D RID: 78141
		internal static int __PropertyOffset_bOverrideSpawnGroupToDataChannelIndex;

		// Token: 0x0401313E RID: 78142
		internal static int __PropertyOffset_CompiledData;

		// Token: 0x0401313F RID: 78143
		[Nullable(2)]
		private FNDIDataChannelCompiledData _CompiledData;
	}
}
