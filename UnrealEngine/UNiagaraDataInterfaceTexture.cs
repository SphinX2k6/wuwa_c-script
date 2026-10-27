using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200258A RID: 9610
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceTexture")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UNiagaraDataInterfaceTexture : UNiagaraDataInterface, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023AAE RID: 146094 RVA: 0x0034BBC6 File Offset: 0x00349DC6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceTexture._ClassPtr;
		}

		// Token: 0x06023AAF RID: 146095 RVA: 0x0034BBD4 File Offset: 0x00349DD4
		public UNiagaraDataInterfaceTexture() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceTexture.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023AB0 RID: 146096 RVA: 0x0034BBFC File Offset: 0x00349DFC
		[NullableContext(1)]
		public UNiagaraDataInterfaceTexture(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceTexture.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170088EE RID: 35054
		// (get) Token: 0x06023AB1 RID: 146097 RVA: 0x0034BC2F File Offset: 0x00349E2F
		// (set) Token: 0x06023AB2 RID: 146098 RVA: 0x0034BC43 File Offset: 0x00349E43
		[Nullable(2)]
		public unsafe UTexture Texture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceTexture.__PropertyOffset_Texture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceTexture.__PropertyOffset_Texture, value);
			}
		}

		// Token: 0x06023AB3 RID: 146099 RVA: 0x0034BC58 File Offset: 0x00349E58
		static UNiagaraDataInterfaceTexture()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceTexture");
		}

		// Token: 0x06023AB4 RID: 146100 RVA: 0x0034BC66 File Offset: 0x00349E66
		protected UNiagaraDataInterfaceTexture(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013201 RID: 78337
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceTexture";

		// Token: 0x04013202 RID: 78338
		private static IntPtr _ClassPtr;

		// Token: 0x04013203 RID: 78339
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013204 RID: 78340
		internal static int __PropertyOffset_Texture;
	}
}
