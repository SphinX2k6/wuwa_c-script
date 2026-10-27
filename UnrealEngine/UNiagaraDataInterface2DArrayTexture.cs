using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200255C RID: 9564
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterface2DArrayTexture")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UNiagaraDataInterface2DArrayTexture : UNiagaraDataInterface, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023881 RID: 145537 RVA: 0x003485A1 File Offset: 0x003467A1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterface2DArrayTexture._ClassPtr;
		}

		// Token: 0x06023882 RID: 145538 RVA: 0x003485B0 File Offset: 0x003467B0
		public UNiagaraDataInterface2DArrayTexture() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterface2DArrayTexture.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023883 RID: 145539 RVA: 0x003485D8 File Offset: 0x003467D8
		[NullableContext(1)]
		public UNiagaraDataInterface2DArrayTexture(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterface2DArrayTexture.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008862 RID: 34914
		// (get) Token: 0x06023884 RID: 145540 RVA: 0x0034860B File Offset: 0x0034680B
		// (set) Token: 0x06023885 RID: 145541 RVA: 0x0034861F File Offset: 0x0034681F
		[Nullable(2)]
		public unsafe UTexture2DArray Texture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2DArray>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterface2DArrayTexture.__PropertyOffset_Texture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterface2DArrayTexture.__PropertyOffset_Texture, value);
			}
		}

		// Token: 0x06023886 RID: 145542 RVA: 0x00348634 File Offset: 0x00346834
		static UNiagaraDataInterface2DArrayTexture()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterface2DArrayTexture");
		}

		// Token: 0x06023887 RID: 145543 RVA: 0x00348642 File Offset: 0x00346842
		protected UNiagaraDataInterface2DArrayTexture(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040130BD RID: 78013
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterface2DArrayTexture";

		// Token: 0x040130BE RID: 78014
		private static IntPtr _ClassPtr;

		// Token: 0x040130BF RID: 78015
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040130C0 RID: 78016
		internal static int __PropertyOffset_Texture;
	}
}
