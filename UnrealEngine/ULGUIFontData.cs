using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200069B RID: 1691
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUIFontData")]
	[UnrealStructLayout(1304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1304)]
	public class ULGUIFontData : ULGUIFontData_BaseObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060091AD RID: 37293 RVA: 0x000DB4B6 File Offset: 0x000D96B6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIFontData._ClassPtr;
		}

		// Token: 0x060091AE RID: 37294 RVA: 0x000DB4C4 File Offset: 0x000D96C4
		public ULGUIFontData() : this(BuiltinUtils.AllocNativeUObject(ULGUIFontData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060091AF RID: 37295 RVA: 0x000DB4EC File Offset: 0x000D96EC
		public ULGUIFontData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIFontData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001B2B RID: 6955
		// (get) Token: 0x060091B0 RID: 37296 RVA: 0x000DB51F File Offset: 0x000D971F
		// (set) Token: 0x060091B1 RID: 37297 RVA: 0x000DB52F File Offset: 0x000D972F
		public unsafe Culture CurrentMainCulture
		{
			get
			{
				return (Culture)(*(base.NativePtr + (IntPtr)ULGUIFontData.__PropertyOffset_CurrentMainCulture));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIFontData.__PropertyOffset_CurrentMainCulture) = (byte)value;
			}
		}

		// Token: 0x17001B2C RID: 6956
		// (get) Token: 0x060091B2 RID: 37298 RVA: 0x000DB540 File Offset: 0x000D9740
		// (set) Token: 0x060091B3 RID: 37299 RVA: 0x000DB554 File Offset: 0x000D9754
		public unsafe string fontFilePath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)ULGUIFontData.__PropertyOffset_fontFilePath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)ULGUIFontData.__PropertyOffset_fontFilePath)), value);
			}
		}

		// Token: 0x17001B2D RID: 6957
		// (get) Token: 0x060091B4 RID: 37300 RVA: 0x000DB569 File Offset: 0x000D9769
		// (set) Token: 0x060091B5 RID: 37301 RVA: 0x000DB579 File Offset: 0x000D9779
		public unsafe bool useRelativeFilePath
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIFontData.__PropertyOffset_useRelativeFilePath) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIFontData.__PropertyOffset_useRelativeFilePath) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001B2E RID: 6958
		// (get) Token: 0x060091B6 RID: 37302 RVA: 0x000DB58A File Offset: 0x000D978A
		// (set) Token: 0x060091B7 RID: 37303 RVA: 0x000DB59A File Offset: 0x000D979A
		public unsafe bool useExternalFileOrEmbedInToUAsset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIFontData.__PropertyOffset_useExternalFileOrEmbedInToUAsset) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIFontData.__PropertyOffset_useExternalFileOrEmbedInToUAsset) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001B2F RID: 6959
		// (get) Token: 0x060091B8 RID: 37304 RVA: 0x000DB5AB File Offset: 0x000D97AB
		// (set) Token: 0x060091B9 RID: 37305 RVA: 0x000DB5BB File Offset: 0x000D97BB
		public unsafe int fontFace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIFontData.__PropertyOffset_fontFace);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIFontData.__PropertyOffset_fontFace) = value;
			}
		}

		// Token: 0x17001B30 RID: 6960
		// (get) Token: 0x060091BA RID: 37306 RVA: 0x000DB5CC File Offset: 0x000D97CC
		// (set) Token: 0x060091BB RID: 37307 RVA: 0x000DB5DC File Offset: 0x000D97DC
		public unsafe float fixedVerticalOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIFontData.__PropertyOffset_fixedVerticalOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIFontData.__PropertyOffset_fixedVerticalOffset) = value;
			}
		}

		// Token: 0x17001B31 RID: 6961
		// (get) Token: 0x060091BC RID: 37308 RVA: 0x000DB5ED File Offset: 0x000D97ED
		// (set) Token: 0x060091BD RID: 37309 RVA: 0x000DB5FD File Offset: 0x000D97FD
		public unsafe float italicAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIFontData.__PropertyOffset_italicAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIFontData.__PropertyOffset_italicAngle) = value;
			}
		}

		// Token: 0x17001B32 RID: 6962
		// (get) Token: 0x060091BE RID: 37310 RVA: 0x000DB60E File Offset: 0x000D980E
		// (set) Token: 0x060091BF RID: 37311 RVA: 0x000DB61E File Offset: 0x000D981E
		public unsafe float boldRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIFontData.__PropertyOffset_boldRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIFontData.__PropertyOffset_boldRatio) = value;
			}
		}

		// Token: 0x17001B33 RID: 6963
		// (get) Token: 0x060091C0 RID: 37312 RVA: 0x000DB62F File Offset: 0x000D982F
		// (set) Token: 0x060091C1 RID: 37313 RVA: 0x000DB63F File Offset: 0x000D983F
		public unsafe int boldDrawNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIFontData.__PropertyOffset_boldDrawNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIFontData.__PropertyOffset_boldDrawNum) = value;
			}
		}

		// Token: 0x17001B34 RID: 6964
		// (get) Token: 0x060091C2 RID: 37314 RVA: 0x000DB650 File Offset: 0x000D9850
		// (set) Token: 0x060091C3 RID: 37315 RVA: 0x000DB664 File Offset: 0x000D9864
		public unsafe FName packingTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIFontData.__PropertyOffset_packingTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIFontData.__PropertyOffset_packingTag) = value;
			}
		}

		// Token: 0x17001B35 RID: 6965
		// (get) Token: 0x060091C4 RID: 37316 RVA: 0x000DB679 File Offset: 0x000D9879
		// (set) Token: 0x060091C5 RID: 37317 RVA: 0x000DB68D File Offset: 0x000D988D
		[Nullable(2)]
		public unsafe UTexture2D texture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIFontData.__PropertyOffset_texture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIFontData.__PropertyOffset_texture, value);
			}
		}

		// Token: 0x17001B36 RID: 6966
		// (get) Token: 0x060091C6 RID: 37318 RVA: 0x000DB6A2 File Offset: 0x000D98A2
		// (set) Token: 0x060091C7 RID: 37319 RVA: 0x000DB6B6 File Offset: 0x000D98B6
		[Nullable(2)]
		public unsafe UDataTable ThDict
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIFontData.__PropertyOffset_ThDict);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIFontData.__PropertyOffset_ThDict, value);
			}
		}

		// Token: 0x17001B37 RID: 6967
		// (get) Token: 0x060091C8 RID: 37320 RVA: 0x000DB6CB File Offset: 0x000D98CB
		// (set) Token: 0x060091C9 RID: 37321 RVA: 0x000DB6DF File Offset: 0x000D98DF
		[Nullable(2)]
		public unsafe UDataTable CachedThDict
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIFontData.__PropertyOffset_CachedThDict);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIFontData.__PropertyOffset_CachedThDict, value);
			}
		}

		// Token: 0x17001B38 RID: 6968
		// (get) Token: 0x060091CA RID: 37322 RVA: 0x000DB6F4 File Offset: 0x000D98F4
		// (set) Token: 0x060091CB RID: 37323 RVA: 0x000DB704 File Offset: 0x000D9904
		public unsafe bool bMMapMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIFontData.__PropertyOffset_bMMapMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIFontData.__PropertyOffset_bMMapMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001B39 RID: 6969
		// (get) Token: 0x060091CC RID: 37324 RVA: 0x000DB718 File Offset: 0x000D9918
		// (set) Token: 0x060091CD RID: 37325 RVA: 0x000DB751 File Offset: 0x000D9951
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TWeakObjectPtr<UUIText>> renderTextArray
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TWeakObjectPtr<UUIText>> result;
				if ((result = this._renderTextArray) == null)
				{
					result = (this._renderTextArray = new TArray<TWeakObjectPtr<UUIText>>(base.NativePtr + (IntPtr)ULGUIFontData.__PropertyOffset_renderTextArray, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.renderTextArray.CopyAssign(value);
			}
		}

		// Token: 0x17001B3A RID: 6970
		// (get) Token: 0x060091CE RID: 37326 RVA: 0x000DB760 File Offset: 0x000D9960
		// (set) Token: 0x060091CF RID: 37327 RVA: 0x000DB799 File Offset: 0x000D9999
		public TArray<byte> fontBinaryArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._fontBinaryArray) == null)
				{
					result = (this._fontBinaryArray = new TArray<byte>(base.NativePtr + (IntPtr)ULGUIFontData.__PropertyOffset_fontBinaryArray, this));
				}
				return result;
			}
			set
			{
				this.fontBinaryArray.CopyAssign(value);
			}
		}

		// Token: 0x17001B3B RID: 6971
		// (get) Token: 0x060091D0 RID: 37328 RVA: 0x000DB7A8 File Offset: 0x000D99A8
		// (set) Token: 0x060091D1 RID: 37329 RVA: 0x000DB7E1 File Offset: 0x000D99E1
		public TArray<byte> tempFontBinaryArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._tempFontBinaryArray) == null)
				{
					result = (this._tempFontBinaryArray = new TArray<byte>(base.NativePtr + (IntPtr)ULGUIFontData.__PropertyOffset_tempFontBinaryArray, this));
				}
				return result;
			}
			set
			{
				this.tempFontBinaryArray.CopyAssign(value);
			}
		}

		// Token: 0x060091D2 RID: 37330
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetAllFontCurrentCulture(Culture newCulture);

		// Token: 0x060091D3 RID: 37331
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RebuildAllFontText();

		// Token: 0x060091D4 RID: 37332 RVA: 0x000DB7EF File Offset: 0x000D99EF
		public int GetUsedRectNum()
		{
			return ULGUIFontData.__GetUsedRectNum_Internal(base.NativePtr);
		}

		// Token: 0x060091D5 RID: 37333 RVA: 0x000DB7FC File Offset: 0x000D99FC
		public int GetTobeClearNum()
		{
			return ULGUIFontData.__GetTobeClearNum_Internal(base.NativePtr);
		}

		// Token: 0x060091D6 RID: 37334 RVA: 0x000DB809 File Offset: 0x000D9A09
		public int GetFreeRectNum()
		{
			return ULGUIFontData.__GetFreeRectNum_Internal(base.NativePtr);
		}

		// Token: 0x060091D7 RID: 37335 RVA: 0x000DB816 File Offset: 0x000D9A16
		[NullableContext(2)]
		public UTexture2D GetFontTexture()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture2D>(ULGUIFontData.__GetFontTexture_Internal(base.NativePtr));
		}

		// Token: 0x060091D8 RID: 37336 RVA: 0x000DB828 File Offset: 0x000D9A28
		public static TArray<ULGUIFontData> GetFonts()
		{
			return new TArray<ULGUIFontData>(ULGUIFontData.__GetFonts_Internal(), null);
		}

		// Token: 0x060091D9 RID: 37337 RVA: 0x000DB835 File Offset: 0x000D9A35
		public string GetFontPath()
		{
			return FString.ToStringAndDeleteNativePtr(ULGUIFontData.__GetFontPath_Internal(base.NativePtr));
		}

		// Token: 0x060091DA RID: 37338 RVA: 0x000DB847 File Offset: 0x000D9A47
		[NullableContext(2)]
		public static ULGUIFontData GetDefaultFont()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIFontData>(ULGUIFontData.__GetDefaultFont_Internal());
		}

		// Token: 0x060091DB RID: 37339
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern EUILanguageType GetCurrentLanguageType();

		// Token: 0x060091DC RID: 37340 RVA: 0x000DB853 File Offset: 0x000D9A53
		public int GetCharMapSize()
		{
			return ULGUIFontData.__GetCharMapSize_Internal(base.NativePtr);
		}

		// Token: 0x060091DD RID: 37341
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetUsedRectNum_Internal(IntPtr @this);

		// Token: 0x060091DE RID: 37342
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetTobeClearNum_Internal(IntPtr @this);

		// Token: 0x060091DF RID: 37343
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetFreeRectNum_Internal(IntPtr @this);

		// Token: 0x060091E0 RID: 37344
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetFontTexture_Internal(IntPtr @this);

		// Token: 0x060091E1 RID: 37345
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetFonts_Internal();

		// Token: 0x060091E2 RID: 37346
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetFontPath_Internal(IntPtr @this);

		// Token: 0x060091E3 RID: 37347
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDefaultFont_Internal();

		// Token: 0x060091E4 RID: 37348
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetCharMapSize_Internal(IntPtr @this);

		// Token: 0x060091E5 RID: 37349 RVA: 0x000DB860 File Offset: 0x000D9A60
		static ULGUIFontData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIFontData");
		}

		// Token: 0x060091E6 RID: 37350 RVA: 0x000DB86E File Offset: 0x000D9A6E
		protected ULGUIFontData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003F7E RID: 16254
		public new const string __ObjectPath = "/Script/LGUI.LGUIFontData";

		// Token: 0x04003F7F RID: 16255
		private static IntPtr _ClassPtr;

		// Token: 0x04003F80 RID: 16256
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003F81 RID: 16257
		internal static int __PropertyOffset_CurrentMainCulture;

		// Token: 0x04003F82 RID: 16258
		internal static int __PropertyOffset_fontFilePath;

		// Token: 0x04003F83 RID: 16259
		internal static int __PropertyOffset_useRelativeFilePath;

		// Token: 0x04003F84 RID: 16260
		internal static int __PropertyOffset_useExternalFileOrEmbedInToUAsset;

		// Token: 0x04003F85 RID: 16261
		internal static int __PropertyOffset_fontFace;

		// Token: 0x04003F86 RID: 16262
		internal static int __PropertyOffset_fixedVerticalOffset;

		// Token: 0x04003F87 RID: 16263
		internal static int __PropertyOffset_italicAngle;

		// Token: 0x04003F88 RID: 16264
		internal static int __PropertyOffset_boldRatio;

		// Token: 0x04003F89 RID: 16265
		internal static int __PropertyOffset_boldDrawNum;

		// Token: 0x04003F8A RID: 16266
		internal static int __PropertyOffset_packingTag;

		// Token: 0x04003F8B RID: 16267
		internal static int __PropertyOffset_texture;

		// Token: 0x04003F8C RID: 16268
		internal static int __PropertyOffset_ThDict;

		// Token: 0x04003F8D RID: 16269
		internal static int __PropertyOffset_CachedThDict;

		// Token: 0x04003F8E RID: 16270
		internal static int __PropertyOffset_bMMapMode;

		// Token: 0x04003F8F RID: 16271
		internal static int __PropertyOffset_renderTextArray;

		// Token: 0x04003F90 RID: 16272
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<UUIText>> _renderTextArray;

		// Token: 0x04003F91 RID: 16273
		internal static int __PropertyOffset_fontBinaryArray;

		// Token: 0x04003F92 RID: 16274
		[Nullable(2)]
		private TArray<byte> _fontBinaryArray;

		// Token: 0x04003F93 RID: 16275
		internal static int __PropertyOffset_tempFontBinaryArray;

		// Token: 0x04003F94 RID: 16276
		[Nullable(2)]
		private TArray<byte> _tempFontBinaryArray;
	}
}
