using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002551 RID: 9553
	[UnrealObjectPath("/Script/Niagara.NiagaraDataChannelHandler_Single")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UNiagaraDataChannelHandler_Single : UNiagaraDataChannelHandler, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060237D5 RID: 145365 RVA: 0x003476FE File Offset: 0x003458FE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataChannelHandler_Single._ClassPtr;
		}

		// Token: 0x060237D6 RID: 145366 RVA: 0x0034770C File Offset: 0x0034590C
		public UNiagaraDataChannelHandler_Single() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataChannelHandler_Single.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060237D7 RID: 145367 RVA: 0x00347734 File Offset: 0x00345934
		[NullableContext(1)]
		public UNiagaraDataChannelHandler_Single(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataChannelHandler_Single.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060237D8 RID: 145368 RVA: 0x00347767 File Offset: 0x00345967
		static UNiagaraDataChannelHandler_Single()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataChannelHandler_Single");
		}

		// Token: 0x060237D9 RID: 145369 RVA: 0x00347775 File Offset: 0x00345975
		protected UNiagaraDataChannelHandler_Single(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013080 RID: 77952
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataChannelHandler_Single";

		// Token: 0x04013081 RID: 77953
		private static IntPtr _ClassPtr;

		// Token: 0x04013082 RID: 77954
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
