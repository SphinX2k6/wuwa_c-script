using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002573 RID: 9587
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceExport")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UNiagaraDataInterfaceExport : UNiagaraDataInterface, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023981 RID: 145793 RVA: 0x00349DF9 File Offset: 0x00347FF9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceExport._ClassPtr;
		}

		// Token: 0x06023982 RID: 145794 RVA: 0x00349E08 File Offset: 0x00348008
		public UNiagaraDataInterfaceExport() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceExport.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023983 RID: 145795 RVA: 0x00349E30 File Offset: 0x00348030
		public UNiagaraDataInterfaceExport(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceExport.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008899 RID: 34969
		// (get) Token: 0x06023984 RID: 145796 RVA: 0x00349E64 File Offset: 0x00348064
		// (set) Token: 0x06023985 RID: 145797 RVA: 0x00349E9D File Offset: 0x0034809D
		public FNiagaraUserParameterBinding CallbackHandlerParameter
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraUserParameterBinding result;
				if ((result = this._CallbackHandlerParameter) == null)
				{
					result = (this._CallbackHandlerParameter = new FNiagaraUserParameterBinding(base.NativePtr + (IntPtr)UNiagaraDataInterfaceExport.__PropertyOffset_CallbackHandlerParameter, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraUserParameterBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraDataInterfaceExport.__PropertyOffset_CallbackHandlerParameter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700889A RID: 34970
		// (get) Token: 0x06023986 RID: 145798 RVA: 0x00349EBE File Offset: 0x003480BE
		// (set) Token: 0x06023987 RID: 145799 RVA: 0x00349ECE File Offset: 0x003480CE
		public unsafe ENDIExport_GPUAllocationMode GPUAllocationMode
		{
			get
			{
				return (ENDIExport_GPUAllocationMode)(*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceExport.__PropertyOffset_GPUAllocationMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceExport.__PropertyOffset_GPUAllocationMode) = (byte)value;
			}
		}

		// Token: 0x1700889B RID: 34971
		// (get) Token: 0x06023988 RID: 145800 RVA: 0x00349EDF File Offset: 0x003480DF
		// (set) Token: 0x06023989 RID: 145801 RVA: 0x00349EEF File Offset: 0x003480EF
		public unsafe int GPUAllocationFixedSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceExport.__PropertyOffset_GPUAllocationFixedSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceExport.__PropertyOffset_GPUAllocationFixedSize) = value;
			}
		}

		// Token: 0x1700889C RID: 34972
		// (get) Token: 0x0602398A RID: 145802 RVA: 0x00349F00 File Offset: 0x00348100
		// (set) Token: 0x0602398B RID: 145803 RVA: 0x00349F10 File Offset: 0x00348110
		public unsafe float GPUAllocationPerParticleSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceExport.__PropertyOffset_GPUAllocationPerParticleSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceExport.__PropertyOffset_GPUAllocationPerParticleSize) = value;
			}
		}

		// Token: 0x0602398C RID: 145804 RVA: 0x00349F21 File Offset: 0x00348121
		static UNiagaraDataInterfaceExport()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceExport");
		}

		// Token: 0x0602398D RID: 145805 RVA: 0x00349F2F File Offset: 0x0034812F
		protected UNiagaraDataInterfaceExport(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401314C RID: 78156
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceExport";

		// Token: 0x0401314D RID: 78157
		private static IntPtr _ClassPtr;

		// Token: 0x0401314E RID: 78158
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401314F RID: 78159
		internal static int __PropertyOffset_CallbackHandlerParameter;

		// Token: 0x04013150 RID: 78160
		[Nullable(2)]
		private FNiagaraUserParameterBinding _CallbackHandlerParameter;

		// Token: 0x04013151 RID: 78161
		internal static int __PropertyOffset_GPUAllocationMode;

		// Token: 0x04013152 RID: 78162
		internal static int __PropertyOffset_GPUAllocationFixedSize;

		// Token: 0x04013153 RID: 78163
		internal static int __PropertyOffset_GPUAllocationPerParticleSize;
	}
}
