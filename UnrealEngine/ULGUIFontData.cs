using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200207A RID: 8314
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUIFontData")]
	[UnrealStructLayout(1296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1296)]
	public class ULGUIFontData : ULGUIFontData_BaseObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F5C0 RID: 128448 RVA: 0x002E94AA File Offset: 0x002E76AA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIFontData._ClassPtr;
		}

		// Token: 0x0601F5C1 RID: 128449 RVA: 0x002E94B8 File Offset: 0x002E76B8
		public ULGUIFontData() : this(BuiltinUtils.AllocNativeUObject(ULGUIFontData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F5C2 RID: 128450 RVA: 0x002E94E0 File Offset: 0x002E76E0
		[NullableContext(1)]
		public ULGUIFontData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIFontData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007BCE RID: 31694
		// (get) Token: 0x0601F5C3 RID: 128451 RVA: 0x002E9513 File Offset: 0x002E7713
		// (set) Token: 0x0601F5C4 RID: 128452 RVA: 0x002E9523 File Offset: 0x002E7723
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

		// Token: 0x17007BCF RID: 31695
		// (get) Token: 0x0601F5C5 RID: 128453 RVA: 0x002E9534 File Offset: 0x002E7734
		// (set) Token: 0x0601F5C6 RID: 128454 RVA: 0x002E9544 File Offset: 0x002E7744
		public unsafe ELGUIDynamicFontDataType fontType
		{
			get
			{
				return (ELGUIDynamicFontDataType)(*(base.NativePtr + (IntPtr)ULGUIFontData.__PropertyOffset_fontType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIFontData.__PropertyOffset_fontType) = (byte)value;
			}
		}

		// Token: 0x17007BD0 RID: 31696
		// (get) Token: 0x0601F5C7 RID: 128455 RVA: 0x002E9555 File Offset: 0x002E7755
		// (set) Token: 0x0601F5C8 RID: 128456 RVA: 0x002E9569 File Offset: 0x002E7769
		[Nullable(1)]
		public unsafe string fontFilePath
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)ULGUIFontData.__PropertyOffset_fontFilePath)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)ULGUIFontData.__PropertyOffset_fontFilePath)), value);
			}
		}

		// Token: 0x17007BD1 RID: 31697
		// (get) Token: 0x0601F5C9 RID: 128457 RVA: 0x002E957E File Offset: 0x002E777E
		// (set) Token: 0x0601F5CA RID: 128458 RVA: 0x002E958E File Offset: 0x002E778E
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

		// Token: 0x17007BD2 RID: 31698
		// (get) Token: 0x0601F5CB RID: 128459 RVA: 0x002E959F File Offset: 0x002E779F
		// (set) Token: 0x0601F5CC RID: 128460 RVA: 0x002E95AF File Offset: 0x002E77AF
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

		// Token: 0x17007BD3 RID: 31699
		// (get) Token: 0x0601F5CD RID: 128461 RVA: 0x002E95C0 File Offset: 0x002E77C0
		// (set) Token: 0x0601F5CE RID: 128462 RVA: 0x002E95D4 File Offset: 0x002E77D4
		public unsafe UFontFace unrealFont
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UFontFace>(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIFontData.__PropertyOffset_unrealFont);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIFontData.__PropertyOffset_unrealFont, value);
			}
		}

		// Token: 0x17007BD4 RID: 31700
		// (get) Token: 0x0601F5CF RID: 128463 RVA: 0x002E95E9 File Offset: 0x002E77E9
		// (set) Token: 0x0601F5D0 RID: 128464 RVA: 0x002E95F9 File Offset: 0x002E77F9
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

		// Token: 0x17007BD5 RID: 31701
		// (get) Token: 0x0601F5D1 RID: 128465 RVA: 0x002E960A File Offset: 0x002E780A
		// (set) Token: 0x0601F5D2 RID: 128466 RVA: 0x002E961A File Offset: 0x002E781A
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

		// Token: 0x17007BD6 RID: 31702
		// (get) Token: 0x0601F5D3 RID: 128467 RVA: 0x002E962B File Offset: 0x002E782B
		// (set) Token: 0x0601F5D4 RID: 128468 RVA: 0x002E963B File Offset: 0x002E783B
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

		// Token: 0x17007BD7 RID: 31703
		// (get) Token: 0x0601F5D5 RID: 128469 RVA: 0x002E964C File Offset: 0x002E784C
		// (set) Token: 0x0601F5D6 RID: 128470 RVA: 0x002E965C File Offset: 0x002E785C
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

		// Token: 0x17007BD8 RID: 31704
		// (get) Token: 0x0601F5D7 RID: 128471 RVA: 0x002E966D File Offset: 0x002E786D
		// (set) Token: 0x0601F5D8 RID: 128472 RVA: 0x002E967D File Offset: 0x002E787D
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

		// Token: 0x17007BD9 RID: 31705
		// (get) Token: 0x0601F5D9 RID: 128473 RVA: 0x002E968E File Offset: 0x002E788E
		// (set) Token: 0x0601F5DA RID: 128474 RVA: 0x002E96A2 File Offset: 0x002E78A2
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

		// Token: 0x17007BDA RID: 31706
		// (get) Token: 0x0601F5DB RID: 128475 RVA: 0x002E96B7 File Offset: 0x002E78B7
		// (set) Token: 0x0601F5DC RID: 128476 RVA: 0x002E96CB File Offset: 0x002E78CB
		public unsafe UTexture2D texture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIFontData.__PropertyOffset_texture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIFontData.__PropertyOffset_texture, value);
			}
		}

		// Token: 0x17007BDB RID: 31707
		// (get) Token: 0x0601F5DD RID: 128477 RVA: 0x002E96E0 File Offset: 0x002E78E0
		// (set) Token: 0x0601F5DE RID: 128478 RVA: 0x002E96F0 File Offset: 0x002E78F0
		public unsafe ELGUIAtlasTextureSizeType initialSize
		{
			get
			{
				return (ELGUIAtlasTextureSizeType)(*(base.NativePtr + (IntPtr)ULGUIFontData.__PropertyOffset_initialSize));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIFontData.__PropertyOffset_initialSize) = (byte)value;
			}
		}

		// Token: 0x17007BDC RID: 31708
		// (get) Token: 0x0601F5DF RID: 128479 RVA: 0x002E9704 File Offset: 0x002E7904
		// (set) Token: 0x0601F5E0 RID: 128480 RVA: 0x002E973D File Offset: 0x002E793D
		[Nullable(1)]
		public TArray<FLGUISubFontData> SubFonts
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FLGUISubFontData> result;
				if ((result = this._SubFonts) == null)
				{
					result = (this._SubFonts = new TArray<FLGUISubFontData>(base.NativePtr + (IntPtr)ULGUIFontData.__PropertyOffset_SubFonts, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SubFonts.CopyAssign(value);
			}
		}

		// Token: 0x17007BDD RID: 31709
		// (get) Token: 0x0601F5E1 RID: 128481 RVA: 0x002E974B File Offset: 0x002E794B
		// (set) Token: 0x0601F5E2 RID: 128482 RVA: 0x002E975F File Offset: 0x002E795F
		public unsafe UDataAsset ThConfig
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIFontData.__PropertyOffset_ThConfig);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIFontData.__PropertyOffset_ThConfig, value);
			}
		}

		// Token: 0x17007BDE RID: 31710
		// (get) Token: 0x0601F5E3 RID: 128483 RVA: 0x002E9774 File Offset: 0x002E7974
		// (set) Token: 0x0601F5E4 RID: 128484 RVA: 0x002E9788 File Offset: 0x002E7988
		public unsafe UDataTable ThDict
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIFontData.__PropertyOffset_ThDict);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIFontData.__PropertyOffset_ThDict, value);
			}
		}

		// Token: 0x17007BDF RID: 31711
		// (get) Token: 0x0601F5E5 RID: 128485 RVA: 0x002E979D File Offset: 0x002E799D
		// (set) Token: 0x0601F5E6 RID: 128486 RVA: 0x002E97B1 File Offset: 0x002E79B1
		public unsafe UDataTable CachedThDict
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIFontData.__PropertyOffset_CachedThDict);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIFontData.__PropertyOffset_CachedThDict, value);
			}
		}

		// Token: 0x17007BE0 RID: 31712
		// (get) Token: 0x0601F5E7 RID: 128487 RVA: 0x002E97C6 File Offset: 0x002E79C6
		// (set) Token: 0x0601F5E8 RID: 128488 RVA: 0x002E97DA File Offset: 0x002E79DA
		public unsafe ULGUIMobileFontAtlasTextureSizeWhiteList MobileFontAtlasTextureSizeWhiteList
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUIMobileFontAtlasTextureSizeWhiteList>(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIFontData.__PropertyOffset_MobileFontAtlasTextureSizeWhiteList);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIFontData.__PropertyOffset_MobileFontAtlasTextureSizeWhiteList, value);
			}
		}

		// Token: 0x17007BE1 RID: 31713
		// (get) Token: 0x0601F5E9 RID: 128489 RVA: 0x002E97F0 File Offset: 0x002E79F0
		// (set) Token: 0x0601F5EA RID: 128490 RVA: 0x002E9829 File Offset: 0x002E7A29
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

		// Token: 0x17007BE2 RID: 31714
		// (get) Token: 0x0601F5EB RID: 128491 RVA: 0x002E9838 File Offset: 0x002E7A38
		// (set) Token: 0x0601F5EC RID: 128492 RVA: 0x002E9871 File Offset: 0x002E7A71
		[Nullable(1)]
		public TArray<byte> fontBinaryArray
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				this.fontBinaryArray.CopyAssign(value);
			}
		}

		// Token: 0x17007BE3 RID: 31715
		// (get) Token: 0x0601F5ED RID: 128493 RVA: 0x002E9880 File Offset: 0x002E7A80
		// (set) Token: 0x0601F5EE RID: 128494 RVA: 0x002E98B9 File Offset: 0x002E7AB9
		[Nullable(1)]
		public TArray<byte> tempFontBinaryArray
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				this.tempFontBinaryArray.CopyAssign(value);
			}
		}

		// Token: 0x0601F5EF RID: 128495
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetAllFontCurrentCulture(Culture newCulture);

		// Token: 0x0601F5F0 RID: 128496
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RebuildAllFontText();

		// Token: 0x0601F5F1 RID: 128497 RVA: 0x002E98C7 File Offset: 0x002E7AC7
		public int GetUsedRectNum()
		{
			return ULGUIFontData.__GetUsedRectNum_Internal(base.NativePtr);
		}

		// Token: 0x0601F5F2 RID: 128498 RVA: 0x002E98D4 File Offset: 0x002E7AD4
		public int GetTobeClearNum()
		{
			return ULGUIFontData.__GetTobeClearNum_Internal(base.NativePtr);
		}

		// Token: 0x0601F5F3 RID: 128499 RVA: 0x002E98E1 File Offset: 0x002E7AE1
		public int GetFreeRectNum()
		{
			return ULGUIFontData.__GetFreeRectNum_Internal(base.NativePtr);
		}

		// Token: 0x0601F5F4 RID: 128500 RVA: 0x002E98EE File Offset: 0x002E7AEE
		public UTexture2D GetFontTexture()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture2D>(ULGUIFontData.__GetFontTexture_Internal(base.NativePtr));
		}

		// Token: 0x0601F5F5 RID: 128501 RVA: 0x002E9900 File Offset: 0x002E7B00
		[NullableContext(1)]
		public static TArray<ULGUIFontData> GetFonts()
		{
			return new TArray<ULGUIFontData>(ULGUIFontData.__GetFonts_Internal(), null);
		}

		// Token: 0x0601F5F6 RID: 128502 RVA: 0x002E990D File Offset: 0x002E7B0D
		[NullableContext(1)]
		public string GetFontPath()
		{
			return FString.ToStringAndDeleteNativePtr(ULGUIFontData.__GetFontPath_Internal(base.NativePtr));
		}

		// Token: 0x0601F5F7 RID: 128503 RVA: 0x002E991F File Offset: 0x002E7B1F
		public static ULGUIFontData GetDefaultFont()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIFontData>(ULGUIFontData.__GetDefaultFont_Internal());
		}

		// Token: 0x0601F5F8 RID: 128504
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern EUILanguageType GetCurrentLanguageType();

		// Token: 0x0601F5F9 RID: 128505 RVA: 0x002E992B File Offset: 0x002E7B2B
		public int GetCharMapSize()
		{
			return ULGUIFontData.__GetCharMapSize_Internal(base.NativePtr);
		}

		// Token: 0x0601F5FA RID: 128506
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetUsedRectNum_Internal(IntPtr @this);

		// Token: 0x0601F5FB RID: 128507
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetTobeClearNum_Internal(IntPtr @this);

		// Token: 0x0601F5FC RID: 128508
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetFreeRectNum_Internal(IntPtr @this);

		// Token: 0x0601F5FD RID: 128509
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetFontTexture_Internal(IntPtr @this);

		// Token: 0x0601F5FE RID: 128510
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetFonts_Internal();

		// Token: 0x0601F5FF RID: 128511
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetFontPath_Internal(IntPtr @this);

		// Token: 0x0601F600 RID: 128512
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDefaultFont_Internal();

		// Token: 0x0601F601 RID: 128513
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetCharMapSize_Internal(IntPtr @this);

		// Token: 0x0601F602 RID: 128514 RVA: 0x002E9938 File Offset: 0x002E7B38
		static ULGUIFontData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIFontData");
		}

		// Token: 0x0601F603 RID: 128515 RVA: 0x002E9946 File Offset: 0x002E7B46
		protected ULGUIFontData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010F17 RID: 69399
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIFontData";

		// Token: 0x04010F18 RID: 69400
		private static IntPtr _ClassPtr;

		// Token: 0x04010F19 RID: 69401
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010F1A RID: 69402
		internal static int __PropertyOffset_CurrentMainCulture;

		// Token: 0x04010F1B RID: 69403
		internal static int __PropertyOffset_fontType;

		// Token: 0x04010F1C RID: 69404
		internal static int __PropertyOffset_fontFilePath;

		// Token: 0x04010F1D RID: 69405
		internal static int __PropertyOffset_useRelativeFilePath;

		// Token: 0x04010F1E RID: 69406
		internal static int __PropertyOffset_useExternalFileOrEmbedInToUAsset;

		// Token: 0x04010F1F RID: 69407
		internal static int __PropertyOffset_unrealFont;

		// Token: 0x04010F20 RID: 69408
		internal static int __PropertyOffset_fontFace;

		// Token: 0x04010F21 RID: 69409
		internal static int __PropertyOffset_fixedVerticalOffset;

		// Token: 0x04010F22 RID: 69410
		internal static int __PropertyOffset_italicAngle;

		// Token: 0x04010F23 RID: 69411
		internal static int __PropertyOffset_boldRatio;

		// Token: 0x04010F24 RID: 69412
		internal static int __PropertyOffset_boldDrawNum;

		// Token: 0x04010F25 RID: 69413
		internal static int __PropertyOffset_packingTag;

		// Token: 0x04010F26 RID: 69414
		internal static int __PropertyOffset_texture;

		// Token: 0x04010F27 RID: 69415
		internal static int __PropertyOffset_initialSize;

		// Token: 0x04010F28 RID: 69416
		internal static int __PropertyOffset_SubFonts;

		// Token: 0x04010F29 RID: 69417
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FLGUISubFontData> _SubFonts;

		// Token: 0x04010F2A RID: 69418
		internal static int __PropertyOffset_ThConfig;

		// Token: 0x04010F2B RID: 69419
		internal static int __PropertyOffset_ThDict;

		// Token: 0x04010F2C RID: 69420
		internal static int __PropertyOffset_CachedThDict;

		// Token: 0x04010F2D RID: 69421
		internal static int __PropertyOffset_MobileFontAtlasTextureSizeWhiteList;

		// Token: 0x04010F2E RID: 69422
		internal static int __PropertyOffset_renderTextArray;

		// Token: 0x04010F2F RID: 69423
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<UUIText>> _renderTextArray;

		// Token: 0x04010F30 RID: 69424
		internal static int __PropertyOffset_fontBinaryArray;

		// Token: 0x04010F31 RID: 69425
		private TArray<byte> _fontBinaryArray;

		// Token: 0x04010F32 RID: 69426
		internal static int __PropertyOffset_tempFontBinaryArray;

		// Token: 0x04010F33 RID: 69427
		private TArray<byte> _tempFontBinaryArray;
	}
}
