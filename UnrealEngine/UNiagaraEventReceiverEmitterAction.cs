using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025A5 RID: 9637
	[UnrealObjectPath("/Script/Niagara.NiagaraEventReceiverEmitterAction")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UNiagaraEventReceiverEmitterAction : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023CB7 RID: 146615 RVA: 0x0034EFA1 File Offset: 0x0034D1A1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraEventReceiverEmitterAction._ClassPtr;
		}

		// Token: 0x06023CB8 RID: 146616 RVA: 0x0034EFAD File Offset: 0x0034D1AD
		static UNiagaraEventReceiverEmitterAction()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraEventReceiverEmitterAction");
		}

		// Token: 0x06023CB9 RID: 146617 RVA: 0x0034EFBC File Offset: 0x0034D1BC
		protected UNiagaraEventReceiverEmitterAction() : this(BuiltinUtils.AllocNativeUObject(UNiagaraEventReceiverEmitterAction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023CBA RID: 146618 RVA: 0x0034EFE4 File Offset: 0x0034D1E4
		protected UNiagaraEventReceiverEmitterAction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401332B RID: 78635
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraEventReceiverEmitterAction";

		// Token: 0x0401332C RID: 78636
		private static IntPtr _ClassPtr;

		// Token: 0x0401332D RID: 78637
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
