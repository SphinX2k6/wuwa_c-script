using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002557 RID: 9559
	[UnrealObjectPath("/Script/Niagara.NiagaraDataChannel_Global")]
	[UnrealStructLayout(336, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 336)]
	public class UNiagaraDataChannel_Global : UNiagaraDataChannel, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023847 RID: 145479 RVA: 0x00347F93 File Offset: 0x00346193
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataChannel_Global._ClassPtr;
		}

		// Token: 0x06023848 RID: 145480 RVA: 0x00347FA0 File Offset: 0x003461A0
		public UNiagaraDataChannel_Global() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataChannel_Global.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023849 RID: 145481 RVA: 0x00347FC8 File Offset: 0x003461C8
		[NullableContext(1)]
		public UNiagaraDataChannel_Global(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataChannel_Global.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602384A RID: 145482 RVA: 0x00347FFB File Offset: 0x003461FB
		static UNiagaraDataChannel_Global()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataChannel_Global");
		}

		// Token: 0x0602384B RID: 145483 RVA: 0x00348009 File Offset: 0x00346209
		protected UNiagaraDataChannel_Global(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013096 RID: 77974
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataChannel_Global";

		// Token: 0x04013097 RID: 77975
		private static IntPtr _ClassPtr;

		// Token: 0x04013098 RID: 77976
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
