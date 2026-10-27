using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002561 RID: 9569
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceArrayFloat2")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class UNiagaraDataInterfaceArrayFloat2 : UNiagaraDataInterfaceArray, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060238A3 RID: 145571 RVA: 0x00348912 File Offset: 0x00346B12
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceArrayFloat2._ClassPtr;
		}

		// Token: 0x060238A4 RID: 145572 RVA: 0x00348920 File Offset: 0x00346B20
		public UNiagaraDataInterfaceArrayFloat2() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceArrayFloat2.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060238A5 RID: 145573 RVA: 0x00348948 File Offset: 0x00346B48
		public UNiagaraDataInterfaceArrayFloat2(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceArrayFloat2.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008867 RID: 34919
		// (get) Token: 0x060238A6 RID: 145574 RVA: 0x0034897C File Offset: 0x00346B7C
		// (set) Token: 0x060238A7 RID: 145575 RVA: 0x003489B5 File Offset: 0x00346BB5
		public TArray<FVector2D> FloatData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector2D> result;
				if ((result = this._FloatData) == null)
				{
					result = (this._FloatData = new TArray<FVector2D>(base.NativePtr + (IntPtr)UNiagaraDataInterfaceArrayFloat2.__PropertyOffset_FloatData, this));
				}
				return result;
			}
			set
			{
				this.FloatData.CopyAssign(value);
			}
		}

		// Token: 0x060238A8 RID: 145576 RVA: 0x003489C3 File Offset: 0x00346BC3
		static UNiagaraDataInterfaceArrayFloat2()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceArrayFloat2");
		}

		// Token: 0x060238A9 RID: 145577 RVA: 0x003489D1 File Offset: 0x00346BD1
		protected UNiagaraDataInterfaceArrayFloat2(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040130D4 RID: 78036
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceArrayFloat2";

		// Token: 0x040130D5 RID: 78037
		private static IntPtr _ClassPtr;

		// Token: 0x040130D6 RID: 78038
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040130D7 RID: 78039
		internal static int __PropertyOffset_FloatData;

		// Token: 0x040130D8 RID: 78040
		[Nullable(2)]
		private TArray<FVector2D> _FloatData;
	}
}
