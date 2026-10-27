using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200254E RID: 9550
	[UnrealObjectPath("/Script/Niagara.NiagaraDataChannelHandler_Global")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UNiagaraDataChannelHandler_Global : UNiagaraDataChannelHandler, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060237BE RID: 145342 RVA: 0x0034745D File Offset: 0x0034565D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataChannelHandler_Global._ClassPtr;
		}

		// Token: 0x060237BF RID: 145343 RVA: 0x0034746C File Offset: 0x0034566C
		public UNiagaraDataChannelHandler_Global() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataChannelHandler_Global.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060237C0 RID: 145344 RVA: 0x00347494 File Offset: 0x00345694
		[NullableContext(1)]
		public UNiagaraDataChannelHandler_Global(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataChannelHandler_Global.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060237C1 RID: 145345 RVA: 0x003474C7 File Offset: 0x003456C7
		static UNiagaraDataChannelHandler_Global()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataChannelHandler_Global");
		}

		// Token: 0x060237C2 RID: 145346 RVA: 0x003474D5 File Offset: 0x003456D5
		protected UNiagaraDataChannelHandler_Global(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401306F RID: 77935
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataChannelHandler_Global";

		// Token: 0x04013070 RID: 77936
		private static IntPtr _ClassPtr;

		// Token: 0x04013071 RID: 77937
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
