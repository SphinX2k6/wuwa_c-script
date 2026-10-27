using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200257A RID: 9594
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceLandscape")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UNiagaraDataInterfaceLandscape : UNiagaraDataInterface, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060239E2 RID: 145890 RVA: 0x0034A755 File Offset: 0x00348955
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceLandscape._ClassPtr;
		}

		// Token: 0x060239E3 RID: 145891 RVA: 0x0034A764 File Offset: 0x00348964
		public UNiagaraDataInterfaceLandscape() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceLandscape.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060239E4 RID: 145892 RVA: 0x0034A78C File Offset: 0x0034898C
		[NullableContext(1)]
		public UNiagaraDataInterfaceLandscape(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceLandscape.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170088B1 RID: 34993
		// (get) Token: 0x060239E5 RID: 145893 RVA: 0x0034A7BF File Offset: 0x003489BF
		// (set) Token: 0x060239E6 RID: 145894 RVA: 0x0034A7D3 File Offset: 0x003489D3
		[Nullable(2)]
		public unsafe AActor SourceLandscape
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceLandscape.__PropertyOffset_SourceLandscape);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceLandscape.__PropertyOffset_SourceLandscape, value);
			}
		}

		// Token: 0x060239E7 RID: 145895 RVA: 0x0034A7E8 File Offset: 0x003489E8
		static UNiagaraDataInterfaceLandscape()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceLandscape");
		}

		// Token: 0x060239E8 RID: 145896 RVA: 0x0034A7F6 File Offset: 0x003489F6
		protected UNiagaraDataInterfaceLandscape(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401317E RID: 78206
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceLandscape";

		// Token: 0x0401317F RID: 78207
		private static IntPtr _ClassPtr;

		// Token: 0x04013180 RID: 78208
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013181 RID: 78209
		internal static int __PropertyOffset_SourceLandscape;
	}
}
