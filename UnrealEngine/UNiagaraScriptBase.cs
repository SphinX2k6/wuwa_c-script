using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020024D2 RID: 9426
	[UnrealObjectPath("/Script/NiagaraShader.NiagaraScriptBase")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UNiagaraScriptBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060233DD RID: 144349 RVA: 0x00341FDE File Offset: 0x003401DE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraScriptBase._ClassPtr;
		}

		// Token: 0x060233DE RID: 144350 RVA: 0x00341FEA File Offset: 0x003401EA
		static UNiagaraScriptBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NiagaraShader.NiagaraScriptBase");
		}

		// Token: 0x060233DF RID: 144351 RVA: 0x00341FF8 File Offset: 0x003401F8
		protected UNiagaraScriptBase() : this(BuiltinUtils.AllocNativeUObject(UNiagaraScriptBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060233E0 RID: 144352 RVA: 0x00342020 File Offset: 0x00340220
		protected UNiagaraScriptBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012D4B RID: 77131
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NiagaraShader.NiagaraScriptBase";

		// Token: 0x04012D4C RID: 77132
		private static IntPtr _ClassPtr;

		// Token: 0x04012D4D RID: 77133
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
