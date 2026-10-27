using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002585 RID: 9605
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceSimpleCounter")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UNiagaraDataInterfaceSimpleCounter : UNiagaraDataInterface, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023A58 RID: 146008 RVA: 0x0034B361 File Offset: 0x00349561
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceSimpleCounter._ClassPtr;
		}

		// Token: 0x06023A59 RID: 146009 RVA: 0x0034B370 File Offset: 0x00349570
		public UNiagaraDataInterfaceSimpleCounter() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceSimpleCounter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023A5A RID: 146010 RVA: 0x0034B398 File Offset: 0x00349598
		[NullableContext(1)]
		public UNiagaraDataInterfaceSimpleCounter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceSimpleCounter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06023A5B RID: 146011 RVA: 0x0034B3CB File Offset: 0x003495CB
		static UNiagaraDataInterfaceSimpleCounter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceSimpleCounter");
		}

		// Token: 0x06023A5C RID: 146012 RVA: 0x0034B3D9 File Offset: 0x003495D9
		protected UNiagaraDataInterfaceSimpleCounter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040131CC RID: 78284
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceSimpleCounter";

		// Token: 0x040131CD RID: 78285
		private static IntPtr _ClassPtr;

		// Token: 0x040131CE RID: 78286
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
