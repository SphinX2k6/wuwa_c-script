using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025E7 RID: 9703
	[UnrealObjectPath("/Script/Niagara.NiagaraSignificanceHandler")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UNiagaraSignificanceHandler : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024117 RID: 147735 RVA: 0x00355D96 File Offset: 0x00353F96
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraSignificanceHandler._ClassPtr;
		}

		// Token: 0x06024118 RID: 147736 RVA: 0x00355DA2 File Offset: 0x00353FA2
		static UNiagaraSignificanceHandler()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraSignificanceHandler");
		}

		// Token: 0x06024119 RID: 147737 RVA: 0x00355DB0 File Offset: 0x00353FB0
		protected UNiagaraSignificanceHandler() : this(BuiltinUtils.AllocNativeUObject(UNiagaraSignificanceHandler.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602411A RID: 147738 RVA: 0x00355DD8 File Offset: 0x00353FD8
		protected UNiagaraSignificanceHandler(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013580 RID: 79232
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraSignificanceHandler";

		// Token: 0x04013581 RID: 79233
		private static IntPtr _ClassPtr;

		// Token: 0x04013582 RID: 79234
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
