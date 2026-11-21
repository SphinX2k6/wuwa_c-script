using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200070E RID: 1806
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UILangTexture")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UUILangTexture : ULGUIBehaviour, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009B17 RID: 39703 RVA: 0x000E81DC File Offset: 0x000E63DC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUILangTexture._ClassPtr;
		}

		// Token: 0x06009B18 RID: 39704 RVA: 0x000E81E8 File Offset: 0x000E63E8
		public UUILangTexture() : this(BuiltinUtils.AllocNativeUObject(UUILangTexture.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009B19 RID: 39705 RVA: 0x000E8210 File Offset: 0x000E6410
		[NullableContext(1)]
		public UUILangTexture(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUILangTexture.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001CBD RID: 7357
		// (get) Token: 0x06009B1A RID: 39706 RVA: 0x000E8243 File Offset: 0x000E6443
		// (set) Token: 0x06009B1B RID: 39707 RVA: 0x000E8257 File Offset: 0x000E6457
		public unsafe ULGUILangTextureData LangTextureData
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUILangTextureData>(base.NativePtr / (IntPtr)sizeof(void*) + UUILangTexture.__PropertyOffset_LangTextureData);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUILangTexture.__PropertyOffset_LangTextureData, value);
			}
		}

		// Token: 0x17001CBE RID: 7358
		// (get) Token: 0x06009B1C RID: 39708 RVA: 0x000E826C File Offset: 0x000E646C
		// (set) Token: 0x06009B1D RID: 39709 RVA: 0x000E827C File Offset: 0x000E647C
		public unsafe bool bSetSizeFromTexture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUILangTexture.__PropertyOffset_bSetSizeFromTexture) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUILangTexture.__PropertyOffset_bSetSizeFromTexture) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001CBF RID: 7359
		// (get) Token: 0x06009B1E RID: 39710 RVA: 0x000E828D File Offset: 0x000E648D
		// (set) Token: 0x06009B1F RID: 39711 RVA: 0x000E82A1 File Offset: 0x000E64A1
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UUITexture> TextureComp
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUILangTexture.__PropertyOffset_TextureComp);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUILangTexture.__PropertyOffset_TextureComp) = value;
			}
		}

		// Token: 0x06009B20 RID: 39712 RVA: 0x000E82B6 File Offset: 0x000E64B6
		public void SetLangTextureData(ULGUILangTextureData NewData)
		{
			UUILangTexture.__SetLangTextureData_Internal(base.NativePtr, (NewData != null) ? NewData.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009B21 RID: 39713
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void NotifyLanguageChange(EUILanguageType NewLang);

		// Token: 0x06009B22 RID: 39714 RVA: 0x000E82D3 File Offset: 0x000E64D3
		public ULGUILangTextureData GetLangTextureData()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUILangTextureData>(UUILangTexture.__GetLangTextureData_Internal(base.NativePtr));
		}

		// Token: 0x06009B23 RID: 39715
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLangTextureData_Internal(IntPtr @this, IntPtr NewData);

		// Token: 0x06009B24 RID: 39716
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLangTextureData_Internal(IntPtr @this);

		// Token: 0x06009B25 RID: 39717 RVA: 0x000E82E5 File Offset: 0x000E64E5
		static UUILangTexture()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UILangTexture");
		}

		// Token: 0x06009B26 RID: 39718 RVA: 0x000E82F3 File Offset: 0x000E64F3
		protected UUILangTexture(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040042F5 RID: 17141
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UILangTexture";

		// Token: 0x040042F6 RID: 17142
		private static IntPtr _ClassPtr;

		// Token: 0x040042F7 RID: 17143
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040042F8 RID: 17144
		internal static int __PropertyOffset_LangTextureData;

		// Token: 0x040042F9 RID: 17145
		internal static int __PropertyOffset_bSetSizeFromTexture;

		// Token: 0x040042FA RID: 17146
		internal static int __PropertyOffset_TextureComp;
	}
}
