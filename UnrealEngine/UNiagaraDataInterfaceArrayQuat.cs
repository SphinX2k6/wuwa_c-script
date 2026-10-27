using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002566 RID: 9574
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceArrayQuat")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class UNiagaraDataInterfaceArrayQuat : UNiagaraDataInterfaceArray, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060238E4 RID: 145636 RVA: 0x00348EE2 File Offset: 0x003470E2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceArrayQuat._ClassPtr;
		}

		// Token: 0x060238E5 RID: 145637 RVA: 0x00348EF0 File Offset: 0x003470F0
		public UNiagaraDataInterfaceArrayQuat() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceArrayQuat.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060238E6 RID: 145638 RVA: 0x00348F18 File Offset: 0x00347118
		public UNiagaraDataInterfaceArrayQuat(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceArrayQuat.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700886B RID: 34923
		// (get) Token: 0x060238E7 RID: 145639 RVA: 0x00348F4C File Offset: 0x0034714C
		// (set) Token: 0x060238E8 RID: 145640 RVA: 0x00348F85 File Offset: 0x00347185
		public TArray<FQuat> QuatData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FQuat> result;
				if ((result = this._QuatData) == null)
				{
					result = (this._QuatData = new TArray<FQuat>(base.NativePtr + (IntPtr)UNiagaraDataInterfaceArrayQuat.__PropertyOffset_QuatData, this));
				}
				return result;
			}
			set
			{
				this.QuatData.CopyAssign(value);
			}
		}

		// Token: 0x060238E9 RID: 145641 RVA: 0x00348F93 File Offset: 0x00347193
		static UNiagaraDataInterfaceArrayQuat()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceArrayQuat");
		}

		// Token: 0x060238EA RID: 145642 RVA: 0x00348FA1 File Offset: 0x003471A1
		protected UNiagaraDataInterfaceArrayQuat(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040130EB RID: 78059
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceArrayQuat";

		// Token: 0x040130EC RID: 78060
		private static IntPtr _ClassPtr;

		// Token: 0x040130ED RID: 78061
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040130EE RID: 78062
		internal static int __PropertyOffset_QuatData;

		// Token: 0x040130EF RID: 78063
		[Nullable(2)]
		private TArray<FQuat> _QuatData;
	}
}
