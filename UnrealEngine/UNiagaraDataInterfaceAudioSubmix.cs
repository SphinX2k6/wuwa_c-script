using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200256A RID: 9578
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceAudioSubmix")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UNiagaraDataInterfaceAudioSubmix : UNiagaraDataInterface, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023916 RID: 145686 RVA: 0x00349342 File Offset: 0x00347542
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceAudioSubmix._ClassPtr;
		}

		// Token: 0x06023917 RID: 145687 RVA: 0x00349350 File Offset: 0x00347550
		public UNiagaraDataInterfaceAudioSubmix() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceAudioSubmix.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023918 RID: 145688 RVA: 0x00349378 File Offset: 0x00347578
		[NullableContext(1)]
		public UNiagaraDataInterfaceAudioSubmix(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceAudioSubmix.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700887A RID: 34938
		// (get) Token: 0x06023919 RID: 145689 RVA: 0x003493AB File Offset: 0x003475AB
		// (set) Token: 0x0602391A RID: 145690 RVA: 0x003493BF File Offset: 0x003475BF
		[Nullable(2)]
		public unsafe USoundSubmix Submix
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundSubmix>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceAudioSubmix.__PropertyOffset_Submix);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceAudioSubmix.__PropertyOffset_Submix, value);
			}
		}

		// Token: 0x0602391B RID: 145691 RVA: 0x003493D4 File Offset: 0x003475D4
		static UNiagaraDataInterfaceAudioSubmix()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceAudioSubmix");
		}

		// Token: 0x0602391C RID: 145692 RVA: 0x003493E2 File Offset: 0x003475E2
		protected UNiagaraDataInterfaceAudioSubmix(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013108 RID: 78088
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceAudioSubmix";

		// Token: 0x04013109 RID: 78089
		private static IntPtr _ClassPtr;

		// Token: 0x0401310A RID: 78090
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401310B RID: 78091
		internal static int __PropertyOffset_Submix;
	}
}
