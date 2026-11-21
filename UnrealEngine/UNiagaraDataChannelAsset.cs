using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007A2 RID: 1954
	[UnrealObjectPath("/Script/Niagara.NiagaraDataChannelAsset")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UNiagaraDataChannelAsset : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A9E8 RID: 43496 RVA: 0x000FAB62 File Offset: 0x000F8D62
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataChannelAsset._ClassPtr;
		}

		// Token: 0x0600A9E9 RID: 43497 RVA: 0x000FAB70 File Offset: 0x000F8D70
		public UNiagaraDataChannelAsset() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataChannelAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A9EA RID: 43498 RVA: 0x000FAB98 File Offset: 0x000F8D98
		[NullableContext(1)]
		public UNiagaraDataChannelAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataChannelAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600A9EB RID: 43499 RVA: 0x000FABCB File Offset: 0x000F8DCB
		static UNiagaraDataChannelAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataChannelAsset");
		}

		// Token: 0x0600A9EC RID: 43500 RVA: 0x000FABD9 File Offset: 0x000F8DD9
		protected UNiagaraDataChannelAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040048D9 RID: 18649
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataChannelAsset";

		// Token: 0x040048DA RID: 18650
		private static IntPtr _ClassPtr;

		// Token: 0x040048DB RID: 18651
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
