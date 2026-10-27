using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002565 RID: 9573
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceArrayInt32")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class UNiagaraDataInterfaceArrayInt32 : UNiagaraDataInterfaceArray, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060238DD RID: 145629 RVA: 0x00348E1A File Offset: 0x0034701A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceArrayInt32._ClassPtr;
		}

		// Token: 0x060238DE RID: 145630 RVA: 0x00348E28 File Offset: 0x00347028
		public UNiagaraDataInterfaceArrayInt32() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceArrayInt32.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060238DF RID: 145631 RVA: 0x00348E50 File Offset: 0x00347050
		public UNiagaraDataInterfaceArrayInt32(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceArrayInt32.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700886A RID: 34922
		// (get) Token: 0x060238E0 RID: 145632 RVA: 0x00348E84 File Offset: 0x00347084
		// (set) Token: 0x060238E1 RID: 145633 RVA: 0x00348EBD File Offset: 0x003470BD
		public TArray<int> IntData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._IntData) == null)
				{
					result = (this._IntData = new TArray<int>(base.NativePtr + (IntPtr)UNiagaraDataInterfaceArrayInt32.__PropertyOffset_IntData, this));
				}
				return result;
			}
			set
			{
				this.IntData.CopyAssign(value);
			}
		}

		// Token: 0x060238E2 RID: 145634 RVA: 0x00348ECB File Offset: 0x003470CB
		static UNiagaraDataInterfaceArrayInt32()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceArrayInt32");
		}

		// Token: 0x060238E3 RID: 145635 RVA: 0x00348ED9 File Offset: 0x003470D9
		protected UNiagaraDataInterfaceArrayInt32(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040130E6 RID: 78054
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceArrayInt32";

		// Token: 0x040130E7 RID: 78055
		private static IntPtr _ClassPtr;

		// Token: 0x040130E8 RID: 78056
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040130E9 RID: 78057
		internal static int __PropertyOffset_IntData;

		// Token: 0x040130EA RID: 78058
		[Nullable(2)]
		private TArray<int> _IntData;
	}
}
