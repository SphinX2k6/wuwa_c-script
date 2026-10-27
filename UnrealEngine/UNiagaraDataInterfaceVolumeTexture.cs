using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200258F RID: 9615
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceVolumeTexture")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UNiagaraDataInterfaceVolumeTexture : UNiagaraDataInterface, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023AE5 RID: 146149 RVA: 0x0034C25F File Offset: 0x0034A45F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceVolumeTexture._ClassPtr;
		}

		// Token: 0x06023AE6 RID: 146150 RVA: 0x0034C26C File Offset: 0x0034A46C
		public UNiagaraDataInterfaceVolumeTexture() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceVolumeTexture.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023AE7 RID: 146151 RVA: 0x0034C294 File Offset: 0x0034A494
		[NullableContext(1)]
		public UNiagaraDataInterfaceVolumeTexture(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceVolumeTexture.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170088FD RID: 35069
		// (get) Token: 0x06023AE8 RID: 146152 RVA: 0x0034C2C7 File Offset: 0x0034A4C7
		// (set) Token: 0x06023AE9 RID: 146153 RVA: 0x0034C2DB File Offset: 0x0034A4DB
		[Nullable(2)]
		public unsafe UVolumeTexture Texture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UVolumeTexture>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceVolumeTexture.__PropertyOffset_Texture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceVolumeTexture.__PropertyOffset_Texture, value);
			}
		}

		// Token: 0x06023AEA RID: 146154 RVA: 0x0034C2F0 File Offset: 0x0034A4F0
		static UNiagaraDataInterfaceVolumeTexture()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceVolumeTexture");
		}

		// Token: 0x06023AEB RID: 146155 RVA: 0x0034C2FE File Offset: 0x0034A4FE
		protected UNiagaraDataInterfaceVolumeTexture(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013228 RID: 78376
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceVolumeTexture";

		// Token: 0x04013229 RID: 78377
		private static IntPtr _ClassPtr;

		// Token: 0x0401322A RID: 78378
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401322B RID: 78379
		internal static int __PropertyOffset_Texture;
	}
}
