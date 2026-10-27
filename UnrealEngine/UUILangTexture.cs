using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002180 RID: 8576
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UILangTexture")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UUILangTexture : ULGUIBehaviour, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602077A RID: 132986 RVA: 0x00301EA0 File Offset: 0x003000A0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUILangTexture._ClassPtr;
		}

		// Token: 0x0602077B RID: 132987 RVA: 0x00301EAC File Offset: 0x003000AC
		public UUILangTexture() : this(BuiltinUtils.AllocNativeUObject(UUILangTexture.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602077C RID: 132988 RVA: 0x00301ED4 File Offset: 0x003000D4
		[NullableContext(1)]
		public UUILangTexture(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUILangTexture.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007F0E RID: 32526
		// (get) Token: 0x0602077D RID: 132989 RVA: 0x00301F07 File Offset: 0x00300107
		// (set) Token: 0x0602077E RID: 132990 RVA: 0x00301F1B File Offset: 0x0030011B
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

		// Token: 0x17007F0F RID: 32527
		// (get) Token: 0x0602077F RID: 132991 RVA: 0x00301F30 File Offset: 0x00300130
		// (set) Token: 0x06020780 RID: 132992 RVA: 0x00301F40 File Offset: 0x00300140
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

		// Token: 0x17007F10 RID: 32528
		// (get) Token: 0x06020781 RID: 132993 RVA: 0x00301F51 File Offset: 0x00300151
		// (set) Token: 0x06020782 RID: 132994 RVA: 0x00301F65 File Offset: 0x00300165
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

		// Token: 0x06020783 RID: 132995 RVA: 0x00301F7A File Offset: 0x0030017A
		public void SetLangTextureData(ULGUILangTextureData NewData)
		{
			UUILangTexture.__SetLangTextureData_Internal(base.NativePtr, (NewData != null) ? NewData.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06020784 RID: 132996
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void NotifyLanguageChange(EUILanguageType NewLang);

		// Token: 0x06020785 RID: 132997 RVA: 0x00301F97 File Offset: 0x00300197
		public ULGUILangTextureData GetLangTextureData()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUILangTextureData>(UUILangTexture.__GetLangTextureData_Internal(base.NativePtr));
		}

		// Token: 0x06020786 RID: 132998
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLangTextureData_Internal(IntPtr @this, IntPtr NewData);

		// Token: 0x06020787 RID: 132999
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLangTextureData_Internal(IntPtr @this);

		// Token: 0x06020788 RID: 133000 RVA: 0x00301FA9 File Offset: 0x003001A9
		static UUILangTexture()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UILangTexture");
		}

		// Token: 0x06020789 RID: 133001 RVA: 0x00301FB7 File Offset: 0x003001B7
		protected UUILangTexture(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011668 RID: 71272
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UILangTexture";

		// Token: 0x04011669 RID: 71273
		private static IntPtr _ClassPtr;

		// Token: 0x0401166A RID: 71274
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401166B RID: 71275
		internal static int __PropertyOffset_LangTextureData;

		// Token: 0x0401166C RID: 71276
		internal static int __PropertyOffset_bSetSizeFromTexture;

		// Token: 0x0401166D RID: 71277
		internal static int __PropertyOffset_TextureComp;
	}
}
