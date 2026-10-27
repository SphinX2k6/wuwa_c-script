using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200257E RID: 9598
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceParticleRead")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UNiagaraDataInterfaceParticleRead : UNiagaraDataInterfaceRWBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023A04 RID: 145924 RVA: 0x0034AA72 File Offset: 0x00348C72
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceParticleRead._ClassPtr;
		}

		// Token: 0x06023A05 RID: 145925 RVA: 0x0034AA80 File Offset: 0x00348C80
		public UNiagaraDataInterfaceParticleRead() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceParticleRead.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023A06 RID: 145926 RVA: 0x0034AAA8 File Offset: 0x00348CA8
		public UNiagaraDataInterfaceParticleRead(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceParticleRead.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170088B8 RID: 35000
		// (get) Token: 0x06023A07 RID: 145927 RVA: 0x0034AADB File Offset: 0x00348CDB
		// (set) Token: 0x06023A08 RID: 145928 RVA: 0x0034AAEF File Offset: 0x00348CEF
		public unsafe string EmitterName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UNiagaraDataInterfaceParticleRead.__PropertyOffset_EmitterName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UNiagaraDataInterfaceParticleRead.__PropertyOffset_EmitterName)), value);
			}
		}

		// Token: 0x06023A09 RID: 145929 RVA: 0x0034AB04 File Offset: 0x00348D04
		static UNiagaraDataInterfaceParticleRead()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceParticleRead");
		}

		// Token: 0x06023A0A RID: 145930 RVA: 0x0034AB12 File Offset: 0x00348D12
		protected UNiagaraDataInterfaceParticleRead(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013192 RID: 78226
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceParticleRead";

		// Token: 0x04013193 RID: 78227
		private static IntPtr _ClassPtr;

		// Token: 0x04013194 RID: 78228
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013195 RID: 78229
		internal static int __PropertyOffset_EmitterName;
	}
}
