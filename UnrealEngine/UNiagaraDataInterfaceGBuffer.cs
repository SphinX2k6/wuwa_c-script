using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002574 RID: 9588
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceGBuffer")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UNiagaraDataInterfaceGBuffer : UNiagaraDataInterface, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602398E RID: 145806 RVA: 0x00349F38 File Offset: 0x00348138
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceGBuffer._ClassPtr;
		}

		// Token: 0x0602398F RID: 145807 RVA: 0x00349F44 File Offset: 0x00348144
		public UNiagaraDataInterfaceGBuffer() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceGBuffer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023990 RID: 145808 RVA: 0x00349F6C File Offset: 0x0034816C
		[NullableContext(1)]
		public UNiagaraDataInterfaceGBuffer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceGBuffer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06023991 RID: 145809 RVA: 0x00349F9F File Offset: 0x0034819F
		static UNiagaraDataInterfaceGBuffer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceGBuffer");
		}

		// Token: 0x06023992 RID: 145810 RVA: 0x00349FAD File Offset: 0x003481AD
		protected UNiagaraDataInterfaceGBuffer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013154 RID: 78164
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceGBuffer";

		// Token: 0x04013155 RID: 78165
		private static IntPtr _ClassPtr;

		// Token: 0x04013156 RID: 78166
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
