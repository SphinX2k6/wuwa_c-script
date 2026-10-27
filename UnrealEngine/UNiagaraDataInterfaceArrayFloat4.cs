using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002563 RID: 9571
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceArrayFloat4")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class UNiagaraDataInterfaceArrayFloat4 : UNiagaraDataInterfaceArray, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060238B1 RID: 145585 RVA: 0x00348AA2 File Offset: 0x00346CA2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceArrayFloat4._ClassPtr;
		}

		// Token: 0x060238B2 RID: 145586 RVA: 0x00348AB0 File Offset: 0x00346CB0
		public UNiagaraDataInterfaceArrayFloat4() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceArrayFloat4.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060238B3 RID: 145587 RVA: 0x00348AD8 File Offset: 0x00346CD8
		public UNiagaraDataInterfaceArrayFloat4(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceArrayFloat4.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008869 RID: 34921
		// (get) Token: 0x060238B4 RID: 145588 RVA: 0x00348B0C File Offset: 0x00346D0C
		// (set) Token: 0x060238B5 RID: 145589 RVA: 0x00348B45 File Offset: 0x00346D45
		public TArray<FVector4> FloatData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector4> result;
				if ((result = this._FloatData) == null)
				{
					result = (this._FloatData = new TArray<FVector4>(base.NativePtr + (IntPtr)UNiagaraDataInterfaceArrayFloat4.__PropertyOffset_FloatData, this));
				}
				return result;
			}
			set
			{
				this.FloatData.CopyAssign(value);
			}
		}

		// Token: 0x060238B6 RID: 145590 RVA: 0x00348B53 File Offset: 0x00346D53
		static UNiagaraDataInterfaceArrayFloat4()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceArrayFloat4");
		}

		// Token: 0x060238B7 RID: 145591 RVA: 0x00348B61 File Offset: 0x00346D61
		protected UNiagaraDataInterfaceArrayFloat4(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040130DE RID: 78046
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceArrayFloat4";

		// Token: 0x040130DF RID: 78047
		private static IntPtr _ClassPtr;

		// Token: 0x040130E0 RID: 78048
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040130E1 RID: 78049
		internal static int __PropertyOffset_FloatData;

		// Token: 0x040130E2 RID: 78050
		[Nullable(2)]
		private TArray<FVector4> _FloatData;
	}
}
