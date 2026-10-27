using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200257D RID: 9597
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceOcclusion")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UNiagaraDataInterfaceOcclusion : UNiagaraDataInterface, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060239FF RID: 145919 RVA: 0x0034A9F3 File Offset: 0x00348BF3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceOcclusion._ClassPtr;
		}

		// Token: 0x06023A00 RID: 145920 RVA: 0x0034AA00 File Offset: 0x00348C00
		public UNiagaraDataInterfaceOcclusion() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceOcclusion.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023A01 RID: 145921 RVA: 0x0034AA28 File Offset: 0x00348C28
		[NullableContext(1)]
		public UNiagaraDataInterfaceOcclusion(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceOcclusion.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06023A02 RID: 145922 RVA: 0x0034AA5B File Offset: 0x00348C5B
		static UNiagaraDataInterfaceOcclusion()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceOcclusion");
		}

		// Token: 0x06023A03 RID: 145923 RVA: 0x0034AA69 File Offset: 0x00348C69
		protected UNiagaraDataInterfaceOcclusion(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401318F RID: 78223
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceOcclusion";

		// Token: 0x04013190 RID: 78224
		private static IntPtr _ClassPtr;

		// Token: 0x04013191 RID: 78225
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
