using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002560 RID: 9568
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceArrayFloat")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class UNiagaraDataInterfaceArrayFloat : UNiagaraDataInterfaceArray, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602389C RID: 145564 RVA: 0x0034884A File Offset: 0x00346A4A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceArrayFloat._ClassPtr;
		}

		// Token: 0x0602389D RID: 145565 RVA: 0x00348858 File Offset: 0x00346A58
		public UNiagaraDataInterfaceArrayFloat() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceArrayFloat.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602389E RID: 145566 RVA: 0x00348880 File Offset: 0x00346A80
		public UNiagaraDataInterfaceArrayFloat(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceArrayFloat.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008866 RID: 34918
		// (get) Token: 0x0602389F RID: 145567 RVA: 0x003488B4 File Offset: 0x00346AB4
		// (set) Token: 0x060238A0 RID: 145568 RVA: 0x003488ED File Offset: 0x00346AED
		public TArray<float> FloatData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._FloatData) == null)
				{
					result = (this._FloatData = new TArray<float>(base.NativePtr + (IntPtr)UNiagaraDataInterfaceArrayFloat.__PropertyOffset_FloatData, this));
				}
				return result;
			}
			set
			{
				this.FloatData.CopyAssign(value);
			}
		}

		// Token: 0x060238A1 RID: 145569 RVA: 0x003488FB File Offset: 0x00346AFB
		static UNiagaraDataInterfaceArrayFloat()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceArrayFloat");
		}

		// Token: 0x060238A2 RID: 145570 RVA: 0x00348909 File Offset: 0x00346B09
		protected UNiagaraDataInterfaceArrayFloat(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040130CF RID: 78031
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceArrayFloat";

		// Token: 0x040130D0 RID: 78032
		private static IntPtr _ClassPtr;

		// Token: 0x040130D1 RID: 78033
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040130D2 RID: 78034
		internal static int __PropertyOffset_FloatData;

		// Token: 0x040130D3 RID: 78035
		[Nullable(2)]
		private TArray<float> _FloatData;
	}
}
