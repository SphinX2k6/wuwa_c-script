using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200256E RID: 9582
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceCurlNoise")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UNiagaraDataInterfaceCurlNoise : UNiagaraDataInterface, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023938 RID: 145720 RVA: 0x00349719 File Offset: 0x00347919
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceCurlNoise._ClassPtr;
		}

		// Token: 0x06023939 RID: 145721 RVA: 0x00349728 File Offset: 0x00347928
		public UNiagaraDataInterfaceCurlNoise() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceCurlNoise.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602393A RID: 145722 RVA: 0x00349750 File Offset: 0x00347950
		[NullableContext(1)]
		public UNiagaraDataInterfaceCurlNoise(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceCurlNoise.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008881 RID: 34945
		// (get) Token: 0x0602393B RID: 145723 RVA: 0x00349783 File Offset: 0x00347983
		// (set) Token: 0x0602393C RID: 145724 RVA: 0x00349793 File Offset: 0x00347993
		public unsafe uint Seed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceCurlNoise.__PropertyOffset_Seed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceCurlNoise.__PropertyOffset_Seed) = (int)value;
			}
		}

		// Token: 0x0602393D RID: 145725 RVA: 0x003497A4 File Offset: 0x003479A4
		static UNiagaraDataInterfaceCurlNoise()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceCurlNoise");
		}

		// Token: 0x0602393E RID: 145726 RVA: 0x003497B2 File Offset: 0x003479B2
		protected UNiagaraDataInterfaceCurlNoise(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401311F RID: 78111
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceCurlNoise";

		// Token: 0x04013120 RID: 78112
		private static IntPtr _ClassPtr;

		// Token: 0x04013121 RID: 78113
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013122 RID: 78114
		internal static int __PropertyOffset_Seed;
	}
}
