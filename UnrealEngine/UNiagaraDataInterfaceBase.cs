using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020024C7 RID: 9415
	[UnrealObjectPath("/Script/NiagaraCore.NiagaraDataInterfaceBase")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public abstract class UNiagaraDataInterfaceBase : UNiagaraMergeable, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060233AD RID: 144301 RVA: 0x00341C14 File Offset: 0x0033FE14
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceBase._ClassPtr;
		}

		// Token: 0x060233AE RID: 144302 RVA: 0x00341C20 File Offset: 0x0033FE20
		static UNiagaraDataInterfaceBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NiagaraCore.NiagaraDataInterfaceBase");
		}

		// Token: 0x060233AF RID: 144303 RVA: 0x00341C30 File Offset: 0x0033FE30
		protected UNiagaraDataInterfaceBase() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060233B0 RID: 144304 RVA: 0x00341C58 File Offset: 0x0033FE58
		protected UNiagaraDataInterfaceBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012D0F RID: 77071
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NiagaraCore.NiagaraDataInterfaceBase";

		// Token: 0x04012D10 RID: 77072
		private static IntPtr _ClassPtr;

		// Token: 0x04012D11 RID: 77073
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
