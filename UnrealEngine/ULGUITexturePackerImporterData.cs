using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021E9 RID: 8681
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI_TexturePackerImporter.LGUITexturePackerImporterData")]
	[UnrealStructLayout(488, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 488)]
	public class ULGUITexturePackerImporterData : ULGUISpriteData_BaseImporter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060211B8 RID: 135608 RVA: 0x0030D1C2 File Offset: 0x0030B3C2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUITexturePackerImporterData._ClassPtr;
		}

		// Token: 0x060211B9 RID: 135609 RVA: 0x0030D1D0 File Offset: 0x0030B3D0
		public ULGUITexturePackerImporterData() : this(BuiltinUtils.AllocNativeUObject(ULGUITexturePackerImporterData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060211BA RID: 135610 RVA: 0x0030D1F8 File Offset: 0x0030B3F8
		public ULGUITexturePackerImporterData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUITexturePackerImporterData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008142 RID: 33090
		// (get) Token: 0x060211BB RID: 135611 RVA: 0x0030D22B File Offset: 0x0030B42B
		// (set) Token: 0x060211BC RID: 135612 RVA: 0x0030D23F File Offset: 0x0030B43F
		public unsafe string Version
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)ULGUITexturePackerImporterData.__PropertyOffset_Version)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)ULGUITexturePackerImporterData.__PropertyOffset_Version)), value);
			}
		}

		// Token: 0x17008143 RID: 33091
		// (get) Token: 0x060211BD RID: 135613 RVA: 0x0030D254 File Offset: 0x0030B454
		// (set) Token: 0x060211BE RID: 135614 RVA: 0x0030D28D File Offset: 0x0030B48D
		public TArray<FName> Sprites
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._Sprites) == null)
				{
					result = (this._Sprites = new TArray<FName>(base.NativePtr + (IntPtr)ULGUITexturePackerImporterData.__PropertyOffset_Sprites, this));
				}
				return result;
			}
			set
			{
				this.Sprites.CopyAssign(value);
			}
		}

		// Token: 0x17008144 RID: 33092
		// (get) Token: 0x060211BF RID: 135615 RVA: 0x0030D29C File Offset: 0x0030B49C
		// (set) Token: 0x060211C0 RID: 135616 RVA: 0x0030D2D5 File Offset: 0x0030B4D5
		public TArray<UTexture2D> AtlasTextures
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UTexture2D> result;
				if ((result = this._AtlasTextures) == null)
				{
					result = (this._AtlasTextures = new TArray<UTexture2D>(base.NativePtr + (IntPtr)ULGUITexturePackerImporterData.__PropertyOffset_AtlasTextures, this));
				}
				return result;
			}
			set
			{
				this.AtlasTextures.CopyAssign(value);
			}
		}

		// Token: 0x17008145 RID: 33093
		// (get) Token: 0x060211C1 RID: 135617 RVA: 0x0030D2E4 File Offset: 0x0030B4E4
		// (set) Token: 0x060211C2 RID: 135618 RVA: 0x0030D31D File Offset: 0x0030B51D
		public TArray<FSoftObjectPath> SoftAtlasTextures
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSoftObjectPath> result;
				if ((result = this._SoftAtlasTextures) == null)
				{
					result = (this._SoftAtlasTextures = new TArray<FSoftObjectPath>(base.NativePtr + (IntPtr)ULGUITexturePackerImporterData.__PropertyOffset_SoftAtlasTextures, this));
				}
				return result;
			}
			set
			{
				this.SoftAtlasTextures.CopyAssign(value);
			}
		}

		// Token: 0x17008146 RID: 33094
		// (get) Token: 0x060211C3 RID: 135619 RVA: 0x0030D32C File Offset: 0x0030B52C
		// (set) Token: 0x060211C4 RID: 135620 RVA: 0x0030D365 File Offset: 0x0030B565
		public TMap<ushort, byte> SpriteAtlasTextureMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<ushort, byte> result;
				if ((result = this._SpriteAtlasTextureMap) == null)
				{
					result = (this._SpriteAtlasTextureMap = new TMap<ushort, byte>(base.NativePtr + (IntPtr)ULGUITexturePackerImporterData.__PropertyOffset_SpriteAtlasTextureMap, this));
				}
				return result;
			}
			set
			{
				this.SpriteAtlasTextureMap.CopyAssign(value);
			}
		}

		// Token: 0x17008147 RID: 33095
		// (get) Token: 0x060211C5 RID: 135621 RVA: 0x0030D374 File Offset: 0x0030B574
		// (set) Token: 0x060211C6 RID: 135622 RVA: 0x0030D3AD File Offset: 0x0030B5AD
		public TMap<ushort, FLGUISpriteInfo> SpriteInfoMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<ushort, FLGUISpriteInfo> result;
				if ((result = this._SpriteInfoMap) == null)
				{
					result = (this._SpriteInfoMap = new TMap<ushort, FLGUISpriteInfo>(base.NativePtr + (IntPtr)ULGUITexturePackerImporterData.__PropertyOffset_SpriteInfoMap, this));
				}
				return result;
			}
			set
			{
				this.SpriteInfoMap.CopyAssign(value);
			}
		}

		// Token: 0x17008148 RID: 33096
		// (get) Token: 0x060211C7 RID: 135623 RVA: 0x0030D3BC File Offset: 0x0030B5BC
		// (set) Token: 0x060211C8 RID: 135624 RVA: 0x0030D3F5 File Offset: 0x0030B5F5
		public TMap<string, FIntPoint> SpriteFrameInfoMapNew
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FIntPoint> result;
				if ((result = this._SpriteFrameInfoMapNew) == null)
				{
					result = (this._SpriteFrameInfoMapNew = new TMap<string, FIntPoint>(base.NativePtr + (IntPtr)ULGUITexturePackerImporterData.__PropertyOffset_SpriteFrameInfoMapNew, this));
				}
				return result;
			}
			set
			{
				this.SpriteFrameInfoMapNew.CopyAssign(value);
			}
		}

		// Token: 0x17008149 RID: 33097
		// (get) Token: 0x060211C9 RID: 135625 RVA: 0x0030D404 File Offset: 0x0030B604
		// (set) Token: 0x060211CA RID: 135626 RVA: 0x0030D43D File Offset: 0x0030B63D
		public TArray<ULGUISpriteData_BaseObject> SpriteDatas
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ULGUISpriteData_BaseObject> result;
				if ((result = this._SpriteDatas) == null)
				{
					result = (this._SpriteDatas = new TArray<ULGUISpriteData_BaseObject>(base.NativePtr + (IntPtr)ULGUITexturePackerImporterData.__PropertyOffset_SpriteDatas, this));
				}
				return result;
			}
			set
			{
				this.SpriteDatas.CopyAssign(value);
			}
		}

		// Token: 0x1700814A RID: 33098
		// (get) Token: 0x060211CB RID: 135627 RVA: 0x0030D44B File Offset: 0x0030B64B
		// (set) Token: 0x060211CC RID: 135628 RVA: 0x0030D45B File Offset: 0x0030B65B
		public unsafe int MaxTextureSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUITexturePackerImporterData.__PropertyOffset_MaxTextureSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUITexturePackerImporterData.__PropertyOffset_MaxTextureSize) = value;
			}
		}

		// Token: 0x1700814B RID: 33099
		// (get) Token: 0x060211CD RID: 135629 RVA: 0x0030D46C File Offset: 0x0030B66C
		// (set) Token: 0x060211CE RID: 135630 RVA: 0x0030D47C File Offset: 0x0030B67C
		public unsafe bool bCanAddToDynamicAtlas
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUITexturePackerImporterData.__PropertyOffset_bCanAddToDynamicAtlas) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUITexturePackerImporterData.__PropertyOffset_bCanAddToDynamicAtlas) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700814C RID: 33100
		// (get) Token: 0x060211CF RID: 135631 RVA: 0x0030D48D File Offset: 0x0030B68D
		// (set) Token: 0x060211D0 RID: 135632 RVA: 0x0030D4A1 File Offset: 0x0030B6A1
		public unsafe string CustomDynamicAtlasTag
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)ULGUITexturePackerImporterData.__PropertyOffset_CustomDynamicAtlasTag)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)ULGUITexturePackerImporterData.__PropertyOffset_CustomDynamicAtlasTag)), value);
			}
		}

		// Token: 0x1700814D RID: 33101
		// (get) Token: 0x060211D1 RID: 135633 RVA: 0x0030D4B6 File Offset: 0x0030B6B6
		// (set) Token: 0x060211D2 RID: 135634 RVA: 0x0030D4C6 File Offset: 0x0030B6C6
		public unsafe bool bPackDiscreteSprites
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUITexturePackerImporterData.__PropertyOffset_bPackDiscreteSprites) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUITexturePackerImporterData.__PropertyOffset_bPackDiscreteSprites) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700814E RID: 33102
		// (get) Token: 0x060211D3 RID: 135635 RVA: 0x0030D4D8 File Offset: 0x0030B6D8
		// (set) Token: 0x060211D4 RID: 135636 RVA: 0x0030D511 File Offset: 0x0030B711
		public TMap<string, string> DiscreteSpritesMD5MapNew
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, string> result;
				if ((result = this._DiscreteSpritesMD5MapNew) == null)
				{
					result = (this._DiscreteSpritesMD5MapNew = new TMap<string, string>(base.NativePtr + (IntPtr)ULGUITexturePackerImporterData.__PropertyOffset_DiscreteSpritesMD5MapNew, this));
				}
				return result;
			}
			set
			{
				this.DiscreteSpritesMD5MapNew.CopyAssign(value);
			}
		}

		// Token: 0x060211D5 RID: 135637 RVA: 0x0030D51F File Offset: 0x0030B71F
		static ULGUITexturePackerImporterData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI_TexturePackerImporter.LGUITexturePackerImporterData");
		}

		// Token: 0x060211D6 RID: 135638 RVA: 0x0030D52D File Offset: 0x0030B72D
		protected ULGUITexturePackerImporterData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011A96 RID: 72342
		public new const string __ObjectPath = "/Script/LGUI_TexturePackerImporter.LGUITexturePackerImporterData";

		// Token: 0x04011A97 RID: 72343
		private static IntPtr _ClassPtr;

		// Token: 0x04011A98 RID: 72344
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011A99 RID: 72345
		internal static int __PropertyOffset_Version;

		// Token: 0x04011A9A RID: 72346
		internal static int __PropertyOffset_Sprites;

		// Token: 0x04011A9B RID: 72347
		[Nullable(2)]
		private TArray<FName> _Sprites;

		// Token: 0x04011A9C RID: 72348
		internal static int __PropertyOffset_AtlasTextures;

		// Token: 0x04011A9D RID: 72349
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UTexture2D> _AtlasTextures;

		// Token: 0x04011A9E RID: 72350
		internal static int __PropertyOffset_SoftAtlasTextures;

		// Token: 0x04011A9F RID: 72351
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoftObjectPath> _SoftAtlasTextures;

		// Token: 0x04011AA0 RID: 72352
		internal static int __PropertyOffset_SpriteAtlasTextureMap;

		// Token: 0x04011AA1 RID: 72353
		[Nullable(2)]
		private TMap<ushort, byte> _SpriteAtlasTextureMap;

		// Token: 0x04011AA2 RID: 72354
		internal static int __PropertyOffset_SpriteInfoMap;

		// Token: 0x04011AA3 RID: 72355
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<ushort, FLGUISpriteInfo> _SpriteInfoMap;

		// Token: 0x04011AA4 RID: 72356
		internal static int __PropertyOffset_SpriteFrameInfoMapNew;

		// Token: 0x04011AA5 RID: 72357
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, FIntPoint> _SpriteFrameInfoMapNew;

		// Token: 0x04011AA6 RID: 72358
		internal static int __PropertyOffset_SpriteDatas;

		// Token: 0x04011AA7 RID: 72359
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULGUISpriteData_BaseObject> _SpriteDatas;

		// Token: 0x04011AA8 RID: 72360
		internal static int __PropertyOffset_MaxTextureSize;

		// Token: 0x04011AA9 RID: 72361
		internal static int __PropertyOffset_bCanAddToDynamicAtlas;

		// Token: 0x04011AAA RID: 72362
		internal static int __PropertyOffset_CustomDynamicAtlasTag;

		// Token: 0x04011AAB RID: 72363
		internal static int __PropertyOffset_bPackDiscreteSprites;

		// Token: 0x04011AAC RID: 72364
		internal static int __PropertyOffset_DiscreteSpritesMD5MapNew;

		// Token: 0x04011AAD RID: 72365
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, string> _DiscreteSpritesMD5MapNew;
	}
}
