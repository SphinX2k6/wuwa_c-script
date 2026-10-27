using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002562 RID: 9570
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceArrayFloat3")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class UNiagaraDataInterfaceArrayFloat3 : UNiagaraDataInterfaceArray, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060238AA RID: 145578 RVA: 0x003489DA File Offset: 0x00346BDA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceArrayFloat3._ClassPtr;
		}

		// Token: 0x060238AB RID: 145579 RVA: 0x003489E8 File Offset: 0x00346BE8
		public UNiagaraDataInterfaceArrayFloat3() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceArrayFloat3.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060238AC RID: 145580 RVA: 0x00348A10 File Offset: 0x00346C10
		public UNiagaraDataInterfaceArrayFloat3(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceArrayFloat3.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008868 RID: 34920
		// (get) Token: 0x060238AD RID: 145581 RVA: 0x00348A44 File Offset: 0x00346C44
		// (set) Token: 0x060238AE RID: 145582 RVA: 0x00348A7D File Offset: 0x00346C7D
		public TArray<FVector> FloatData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._FloatData) == null)
				{
					result = (this._FloatData = new TArray<FVector>(base.NativePtr + (IntPtr)UNiagaraDataInterfaceArrayFloat3.__PropertyOffset_FloatData, this));
				}
				return result;
			}
			set
			{
				this.FloatData.CopyAssign(value);
			}
		}

		// Token: 0x060238AF RID: 145583 RVA: 0x00348A8B File Offset: 0x00346C8B
		static UNiagaraDataInterfaceArrayFloat3()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceArrayFloat3");
		}

		// Token: 0x060238B0 RID: 145584 RVA: 0x00348A99 File Offset: 0x00346C99
		protected UNiagaraDataInterfaceArrayFloat3(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040130D9 RID: 78041
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceArrayFloat3";

		// Token: 0x040130DA RID: 78042
		private static IntPtr _ClassPtr;

		// Token: 0x040130DB RID: 78043
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040130DC RID: 78044
		internal static int __PropertyOffset_FloatData;

		// Token: 0x040130DD RID: 78045
		[Nullable(2)]
		private TArray<FVector> _FloatData;
	}
}
