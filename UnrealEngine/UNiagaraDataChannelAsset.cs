using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200254A RID: 9546
	[UnrealObjectPath("/Script/Niagara.NiagaraDataChannelAsset")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UNiagaraDataChannelAsset : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023794 RID: 145300 RVA: 0x00347085 File Offset: 0x00345285
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataChannelAsset._ClassPtr;
		}

		// Token: 0x06023795 RID: 145301 RVA: 0x00347094 File Offset: 0x00345294
		public UNiagaraDataChannelAsset() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataChannelAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023796 RID: 145302 RVA: 0x003470BC File Offset: 0x003452BC
		[NullableContext(1)]
		public UNiagaraDataChannelAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataChannelAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700883F RID: 34879
		// (get) Token: 0x06023797 RID: 145303 RVA: 0x003470EF File Offset: 0x003452EF
		// (set) Token: 0x06023798 RID: 145304 RVA: 0x00347103 File Offset: 0x00345303
		[Nullable(2)]
		public unsafe UNiagaraDataChannel DataChannel
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraDataChannel>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataChannelAsset.__PropertyOffset_DataChannel);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataChannelAsset.__PropertyOffset_DataChannel, value);
			}
		}

		// Token: 0x06023799 RID: 145305 RVA: 0x00347118 File Offset: 0x00345318
		static UNiagaraDataChannelAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataChannelAsset");
		}

		// Token: 0x0602379A RID: 145306 RVA: 0x00347126 File Offset: 0x00345326
		protected UNiagaraDataChannelAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013058 RID: 77912
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataChannelAsset";

		// Token: 0x04013059 RID: 77913
		private static IntPtr _ClassPtr;

		// Token: 0x0401305A RID: 77914
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401305B RID: 77915
		internal static int __PropertyOffset_DataChannel;
	}
}
