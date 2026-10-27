using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200255B RID: 9563
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterface")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public abstract class UNiagaraDataInterface : UNiagaraDataInterfaceBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602387D RID: 145533 RVA: 0x00348556 File Offset: 0x00346756
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterface._ClassPtr;
		}

		// Token: 0x0602387E RID: 145534 RVA: 0x00348562 File Offset: 0x00346762
		static UNiagaraDataInterface()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterface");
		}

		// Token: 0x0602387F RID: 145535 RVA: 0x00348570 File Offset: 0x00346770
		protected UNiagaraDataInterface() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterface.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023880 RID: 145536 RVA: 0x00348598 File Offset: 0x00346798
		protected UNiagaraDataInterface(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040130BA RID: 78010
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterface";

		// Token: 0x040130BB RID: 78011
		private static IntPtr _ClassPtr;

		// Token: 0x040130BC RID: 78012
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
