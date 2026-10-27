using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021E8 RID: 8680
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI_BMFGenImporter.LGUIBitmapFontGeneratorData")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class ULGUIBitmapFontGeneratorData : ULGUIFontData_BaseObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021195 RID: 135573 RVA: 0x0030CEEC File Offset: 0x0030B0EC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIBitmapFontGeneratorData._ClassPtr;
		}

		// Token: 0x06021196 RID: 135574 RVA: 0x0030CEF8 File Offset: 0x0030B0F8
		public ULGUIBitmapFontGeneratorData() : this(BuiltinUtils.AllocNativeUObject(ULGUIBitmapFontGeneratorData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021197 RID: 135575 RVA: 0x0030CF20 File Offset: 0x0030B120
		public ULGUIBitmapFontGeneratorData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIBitmapFontGeneratorData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008133 RID: 33075
		// (get) Token: 0x06021198 RID: 135576 RVA: 0x0030CF53 File Offset: 0x0030B153
		// (set) Token: 0x06021199 RID: 135577 RVA: 0x0030CF67 File Offset: 0x0030B167
		public unsafe string fntFileSourcePath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)ULGUIBitmapFontGeneratorData.__PropertyOffset_fntFileSourcePath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)ULGUIBitmapFontGeneratorData.__PropertyOffset_fntFileSourcePath)), value);
			}
		}

		// Token: 0x17008134 RID: 33076
		// (get) Token: 0x0602119A RID: 135578 RVA: 0x0030CF7C File Offset: 0x0030B17C
		// (set) Token: 0x0602119B RID: 135579 RVA: 0x0030CF8C File Offset: 0x0030B18C
		public unsafe ELGUIBitmapFontGeneratorTextureType convertTextureType
		{
			get
			{
				return (ELGUIBitmapFontGeneratorTextureType)(*(base.NativePtr + (IntPtr)ULGUIBitmapFontGeneratorData.__PropertyOffset_convertTextureType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIBitmapFontGeneratorData.__PropertyOffset_convertTextureType) = (byte)value;
			}
		}

		// Token: 0x17008135 RID: 33077
		// (get) Token: 0x0602119C RID: 135580 RVA: 0x0030CF9D File Offset: 0x0030B19D
		// (set) Token: 0x0602119D RID: 135581 RVA: 0x0030CFB1 File Offset: 0x0030B1B1
		public unsafe string name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)ULGUIBitmapFontGeneratorData.__PropertyOffset_name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)ULGUIBitmapFontGeneratorData.__PropertyOffset_name)), value);
			}
		}

		// Token: 0x17008136 RID: 33078
		// (get) Token: 0x0602119E RID: 135582 RVA: 0x0030CFC6 File Offset: 0x0030B1C6
		// (set) Token: 0x0602119F RID: 135583 RVA: 0x0030CFD6 File Offset: 0x0030B1D6
		public unsafe ushort size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIBitmapFontGeneratorData.__PropertyOffset_size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIBitmapFontGeneratorData.__PropertyOffset_size) = (short)value;
			}
		}

		// Token: 0x17008137 RID: 33079
		// (get) Token: 0x060211A0 RID: 135584 RVA: 0x0030CFE7 File Offset: 0x0030B1E7
		// (set) Token: 0x060211A1 RID: 135585 RVA: 0x0030CFF7 File Offset: 0x0030B1F7
		public unsafe ushort lineHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIBitmapFontGeneratorData.__PropertyOffset_lineHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIBitmapFontGeneratorData.__PropertyOffset_lineHeight) = (short)value;
			}
		}

		// Token: 0x17008138 RID: 33080
		// (get) Token: 0x060211A2 RID: 135586 RVA: 0x0030D008 File Offset: 0x0030B208
		// (set) Token: 0x060211A3 RID: 135587 RVA: 0x0030D018 File Offset: 0x0030B218
		public unsafe ushort _base
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIBitmapFontGeneratorData.__PropertyOffset_base);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIBitmapFontGeneratorData.__PropertyOffset_base) = (short)value;
			}
		}

		// Token: 0x17008139 RID: 33081
		// (get) Token: 0x060211A4 RID: 135588 RVA: 0x0030D029 File Offset: 0x0030B229
		// (set) Token: 0x060211A5 RID: 135589 RVA: 0x0030D039 File Offset: 0x0030B239
		public unsafe ushort scaleW
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIBitmapFontGeneratorData.__PropertyOffset_scaleW);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIBitmapFontGeneratorData.__PropertyOffset_scaleW) = (short)value;
			}
		}

		// Token: 0x1700813A RID: 33082
		// (get) Token: 0x060211A6 RID: 135590 RVA: 0x0030D04A File Offset: 0x0030B24A
		// (set) Token: 0x060211A7 RID: 135591 RVA: 0x0030D05A File Offset: 0x0030B25A
		public unsafe ushort scaleH
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIBitmapFontGeneratorData.__PropertyOffset_scaleH);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIBitmapFontGeneratorData.__PropertyOffset_scaleH) = (short)value;
			}
		}

		// Token: 0x1700813B RID: 33083
		// (get) Token: 0x060211A8 RID: 135592 RVA: 0x0030D06B File Offset: 0x0030B26B
		// (set) Token: 0x060211A9 RID: 135593 RVA: 0x0030D07B File Offset: 0x0030B27B
		public unsafe ushort charCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIBitmapFontGeneratorData.__PropertyOffset_charCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIBitmapFontGeneratorData.__PropertyOffset_charCount) = (short)value;
			}
		}

		// Token: 0x1700813C RID: 33084
		// (get) Token: 0x060211AA RID: 135594 RVA: 0x0030D08C File Offset: 0x0030B28C
		// (set) Token: 0x060211AB RID: 135595 RVA: 0x0030D0A0 File Offset: 0x0030B2A0
		[Nullable(2)]
		public unsafe UTexture2D texture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIBitmapFontGeneratorData.__PropertyOffset_texture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIBitmapFontGeneratorData.__PropertyOffset_texture, value);
			}
		}

		// Token: 0x1700813D RID: 33085
		// (get) Token: 0x060211AC RID: 135596 RVA: 0x0030D0B8 File Offset: 0x0030B2B8
		// (set) Token: 0x060211AD RID: 135597 RVA: 0x0030D0F1 File Offset: 0x0030B2F1
		public TMap<ushort, FLGUICharData> charDataMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<ushort, FLGUICharData> result;
				if ((result = this._charDataMap) == null)
				{
					result = (this._charDataMap = new TMap<ushort, FLGUICharData>(base.NativePtr + (IntPtr)ULGUIBitmapFontGeneratorData.__PropertyOffset_charDataMap, this));
				}
				return result;
			}
			set
			{
				this.charDataMap.CopyAssign(value);
			}
		}

		// Token: 0x1700813E RID: 33086
		// (get) Token: 0x060211AE RID: 135598 RVA: 0x0030D0FF File Offset: 0x0030B2FF
		// (set) Token: 0x060211AF RID: 135599 RVA: 0x0030D10F File Offset: 0x0030B30F
		public unsafe float fixedVerticalOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIBitmapFontGeneratorData.__PropertyOffset_fixedVerticalOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIBitmapFontGeneratorData.__PropertyOffset_fixedVerticalOffset) = value;
			}
		}

		// Token: 0x1700813F RID: 33087
		// (get) Token: 0x060211B0 RID: 135600 RVA: 0x0030D120 File Offset: 0x0030B320
		// (set) Token: 0x060211B1 RID: 135601 RVA: 0x0030D130 File Offset: 0x0030B330
		public unsafe float italicAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIBitmapFontGeneratorData.__PropertyOffset_italicAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIBitmapFontGeneratorData.__PropertyOffset_italicAngle) = value;
			}
		}

		// Token: 0x17008140 RID: 33088
		// (get) Token: 0x060211B2 RID: 135602 RVA: 0x0030D141 File Offset: 0x0030B341
		// (set) Token: 0x060211B3 RID: 135603 RVA: 0x0030D151 File Offset: 0x0030B351
		public unsafe float boldRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIBitmapFontGeneratorData.__PropertyOffset_boldRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIBitmapFontGeneratorData.__PropertyOffset_boldRatio) = value;
			}
		}

		// Token: 0x17008141 RID: 33089
		// (get) Token: 0x060211B4 RID: 135604 RVA: 0x0030D164 File Offset: 0x0030B364
		// (set) Token: 0x060211B5 RID: 135605 RVA: 0x0030D19D File Offset: 0x0030B39D
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
					result = (this._renderTextArray = new TArray<TWeakObjectPtr<UUIText>>(base.NativePtr + (IntPtr)ULGUIBitmapFontGeneratorData.__PropertyOffset_renderTextArray, this));
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

		// Token: 0x060211B6 RID: 135606 RVA: 0x0030D1AB File Offset: 0x0030B3AB
		static ULGUIBitmapFontGeneratorData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI_BMFGenImporter.LGUIBitmapFontGeneratorData");
		}

		// Token: 0x060211B7 RID: 135607 RVA: 0x0030D1B9 File Offset: 0x0030B3B9
		protected ULGUIBitmapFontGeneratorData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011A82 RID: 72322
		public new const string __ObjectPath = "/Script/LGUI_BMFGenImporter.LGUIBitmapFontGeneratorData";

		// Token: 0x04011A83 RID: 72323
		private static IntPtr _ClassPtr;

		// Token: 0x04011A84 RID: 72324
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011A85 RID: 72325
		internal static int __PropertyOffset_fntFileSourcePath;

		// Token: 0x04011A86 RID: 72326
		internal static int __PropertyOffset_convertTextureType;

		// Token: 0x04011A87 RID: 72327
		internal static int __PropertyOffset_name;

		// Token: 0x04011A88 RID: 72328
		internal static int __PropertyOffset_size;

		// Token: 0x04011A89 RID: 72329
		internal static int __PropertyOffset_lineHeight;

		// Token: 0x04011A8A RID: 72330
		internal static int __PropertyOffset_base;

		// Token: 0x04011A8B RID: 72331
		internal static int __PropertyOffset_scaleW;

		// Token: 0x04011A8C RID: 72332
		internal static int __PropertyOffset_scaleH;

		// Token: 0x04011A8D RID: 72333
		internal static int __PropertyOffset_charCount;

		// Token: 0x04011A8E RID: 72334
		internal static int __PropertyOffset_texture;

		// Token: 0x04011A8F RID: 72335
		internal static int __PropertyOffset_charDataMap;

		// Token: 0x04011A90 RID: 72336
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<ushort, FLGUICharData> _charDataMap;

		// Token: 0x04011A91 RID: 72337
		internal static int __PropertyOffset_fixedVerticalOffset;

		// Token: 0x04011A92 RID: 72338
		internal static int __PropertyOffset_italicAngle;

		// Token: 0x04011A93 RID: 72339
		internal static int __PropertyOffset_boldRatio;

		// Token: 0x04011A94 RID: 72340
		internal static int __PropertyOffset_renderTextArray;

		// Token: 0x04011A95 RID: 72341
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<UUIText>> _renderTextArray;
	}
}
