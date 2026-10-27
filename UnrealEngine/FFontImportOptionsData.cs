using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000BE7 RID: 3047
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.FontImportOptionsData")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 176)]
	public class FFontImportOptionsData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009601 RID: 38401 RVA: 0x000D5DE1 File Offset: 0x000D3FE1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFontImportOptionsData._ScriptStructPtr != 0) ? FFontImportOptionsData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.FontImportOptionsData", ref FFontImportOptionsData._ScriptStructPtr);
		}

		// Token: 0x170023EF RID: 9199
		// (get) Token: 0x06009602 RID: 38402 RVA: 0x000D5E05 File Offset: 0x000D4005
		// (set) Token: 0x06009603 RID: 38403 RVA: 0x000D5E19 File Offset: 0x000D4019
		public unsafe string FontName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FFontImportOptionsData.__PropertyOffset_FontName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FFontImportOptionsData.__PropertyOffset_FontName)), value);
			}
		}

		// Token: 0x170023F0 RID: 9200
		// (get) Token: 0x06009604 RID: 38404 RVA: 0x000D5E2E File Offset: 0x000D402E
		// (set) Token: 0x06009605 RID: 38405 RVA: 0x000D5E3E File Offset: 0x000D403E
		public unsafe float Height
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_Height);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_Height) = value;
			}
		}

		// Token: 0x170023F1 RID: 9201
		// (get) Token: 0x06009606 RID: 38406 RVA: 0x000D5E4F File Offset: 0x000D404F
		// (set) Token: 0x06009607 RID: 38407 RVA: 0x000D5E68 File Offset: 0x000D4068
		public unsafe bool bEnableAntialiasing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_bEnableAntialiasing) & FFontImportOptionsData.__PropertyMask_bEnableAntialiasing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_bEnableAntialiasing) = ((*(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_bEnableAntialiasing) & ~FFontImportOptionsData.__PropertyMask_bEnableAntialiasing) | (value ? FFontImportOptionsData.__PropertyMask_bEnableAntialiasing : 0));
			}
		}

		// Token: 0x170023F2 RID: 9202
		// (get) Token: 0x06009608 RID: 38408 RVA: 0x000D5E98 File Offset: 0x000D4098
		// (set) Token: 0x06009609 RID: 38409 RVA: 0x000D5EB1 File Offset: 0x000D40B1
		public unsafe bool bEnableBold
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_bEnableBold) & FFontImportOptionsData.__PropertyMask_bEnableBold) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_bEnableBold) = ((*(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_bEnableBold) & ~FFontImportOptionsData.__PropertyMask_bEnableBold) | (value ? FFontImportOptionsData.__PropertyMask_bEnableBold : 0));
			}
		}

		// Token: 0x170023F3 RID: 9203
		// (get) Token: 0x0600960A RID: 38410 RVA: 0x000D5EE1 File Offset: 0x000D40E1
		// (set) Token: 0x0600960B RID: 38411 RVA: 0x000D5EFA File Offset: 0x000D40FA
		public unsafe bool bEnableItalic
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_bEnableItalic) & FFontImportOptionsData.__PropertyMask_bEnableItalic) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_bEnableItalic) = ((*(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_bEnableItalic) & ~FFontImportOptionsData.__PropertyMask_bEnableItalic) | (value ? FFontImportOptionsData.__PropertyMask_bEnableItalic : 0));
			}
		}

		// Token: 0x170023F4 RID: 9204
		// (get) Token: 0x0600960C RID: 38412 RVA: 0x000D5F2A File Offset: 0x000D412A
		// (set) Token: 0x0600960D RID: 38413 RVA: 0x000D5F43 File Offset: 0x000D4143
		public unsafe bool bEnableUnderline
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_bEnableUnderline) & FFontImportOptionsData.__PropertyMask_bEnableUnderline) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_bEnableUnderline) = ((*(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_bEnableUnderline) & ~FFontImportOptionsData.__PropertyMask_bEnableUnderline) | (value ? FFontImportOptionsData.__PropertyMask_bEnableUnderline : 0));
			}
		}

		// Token: 0x170023F5 RID: 9205
		// (get) Token: 0x0600960E RID: 38414 RVA: 0x000D5F73 File Offset: 0x000D4173
		// (set) Token: 0x0600960F RID: 38415 RVA: 0x000D5F8C File Offset: 0x000D418C
		public unsafe bool bAlphaOnly
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_bAlphaOnly) & FFontImportOptionsData.__PropertyMask_bAlphaOnly) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_bAlphaOnly) = ((*(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_bAlphaOnly) & ~FFontImportOptionsData.__PropertyMask_bAlphaOnly) | (value ? FFontImportOptionsData.__PropertyMask_bAlphaOnly : 0));
			}
		}

		// Token: 0x170023F6 RID: 9206
		// (get) Token: 0x06009610 RID: 38416 RVA: 0x000D5FBC File Offset: 0x000D41BC
		// (set) Token: 0x06009611 RID: 38417 RVA: 0x000D5FD0 File Offset: 0x000D41D0
		[Nullable(0)]
		public unsafe TEnumAsByte<EFontImportCharacterSet> CharacterSet
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_CharacterSet);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_CharacterSet) = value;
			}
		}

		// Token: 0x170023F7 RID: 9207
		// (get) Token: 0x06009612 RID: 38418 RVA: 0x000D5FE5 File Offset: 0x000D41E5
		// (set) Token: 0x06009613 RID: 38419 RVA: 0x000D5FF9 File Offset: 0x000D41F9
		public unsafe string Chars
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FFontImportOptionsData.__PropertyOffset_Chars)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FFontImportOptionsData.__PropertyOffset_Chars)), value);
			}
		}

		// Token: 0x170023F8 RID: 9208
		// (get) Token: 0x06009614 RID: 38420 RVA: 0x000D600E File Offset: 0x000D420E
		// (set) Token: 0x06009615 RID: 38421 RVA: 0x000D6022 File Offset: 0x000D4222
		public unsafe string UnicodeRange
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FFontImportOptionsData.__PropertyOffset_UnicodeRange)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FFontImportOptionsData.__PropertyOffset_UnicodeRange)), value);
			}
		}

		// Token: 0x170023F9 RID: 9209
		// (get) Token: 0x06009616 RID: 38422 RVA: 0x000D6037 File Offset: 0x000D4237
		// (set) Token: 0x06009617 RID: 38423 RVA: 0x000D604B File Offset: 0x000D424B
		public unsafe string CharsFilePath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FFontImportOptionsData.__PropertyOffset_CharsFilePath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FFontImportOptionsData.__PropertyOffset_CharsFilePath)), value);
			}
		}

		// Token: 0x170023FA RID: 9210
		// (get) Token: 0x06009618 RID: 38424 RVA: 0x000D6060 File Offset: 0x000D4260
		// (set) Token: 0x06009619 RID: 38425 RVA: 0x000D6074 File Offset: 0x000D4274
		public unsafe string CharsFileWildcard
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FFontImportOptionsData.__PropertyOffset_CharsFileWildcard)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FFontImportOptionsData.__PropertyOffset_CharsFileWildcard)), value);
			}
		}

		// Token: 0x170023FB RID: 9211
		// (get) Token: 0x0600961A RID: 38426 RVA: 0x000D6089 File Offset: 0x000D4289
		// (set) Token: 0x0600961B RID: 38427 RVA: 0x000D60A2 File Offset: 0x000D42A2
		public unsafe bool bCreatePrintableOnly
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_bCreatePrintableOnly) & FFontImportOptionsData.__PropertyMask_bCreatePrintableOnly) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_bCreatePrintableOnly) = ((*(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_bCreatePrintableOnly) & ~FFontImportOptionsData.__PropertyMask_bCreatePrintableOnly) | (value ? FFontImportOptionsData.__PropertyMask_bCreatePrintableOnly : 0));
			}
		}

		// Token: 0x170023FC RID: 9212
		// (get) Token: 0x0600961C RID: 38428 RVA: 0x000D60D2 File Offset: 0x000D42D2
		// (set) Token: 0x0600961D RID: 38429 RVA: 0x000D60EB File Offset: 0x000D42EB
		public unsafe bool bIncludeASCIIRange
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_bIncludeASCIIRange) & FFontImportOptionsData.__PropertyMask_bIncludeASCIIRange) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_bIncludeASCIIRange) = ((*(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_bIncludeASCIIRange) & ~FFontImportOptionsData.__PropertyMask_bIncludeASCIIRange) | (value ? FFontImportOptionsData.__PropertyMask_bIncludeASCIIRange : 0));
			}
		}

		// Token: 0x170023FD RID: 9213
		// (get) Token: 0x0600961E RID: 38430 RVA: 0x000D611B File Offset: 0x000D431B
		// (set) Token: 0x0600961F RID: 38431 RVA: 0x000D612F File Offset: 0x000D432F
		public unsafe FLinearColor ForegroundColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_ForegroundColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_ForegroundColor) = value;
			}
		}

		// Token: 0x170023FE RID: 9214
		// (get) Token: 0x06009620 RID: 38432 RVA: 0x000D6144 File Offset: 0x000D4344
		// (set) Token: 0x06009621 RID: 38433 RVA: 0x000D615D File Offset: 0x000D435D
		public unsafe bool bEnableDropShadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_bEnableDropShadow) & FFontImportOptionsData.__PropertyMask_bEnableDropShadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_bEnableDropShadow) = ((*(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_bEnableDropShadow) & ~FFontImportOptionsData.__PropertyMask_bEnableDropShadow) | (value ? FFontImportOptionsData.__PropertyMask_bEnableDropShadow : 0));
			}
		}

		// Token: 0x170023FF RID: 9215
		// (get) Token: 0x06009622 RID: 38434 RVA: 0x000D618D File Offset: 0x000D438D
		// (set) Token: 0x06009623 RID: 38435 RVA: 0x000D619D File Offset: 0x000D439D
		public unsafe int TexturePageWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_TexturePageWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_TexturePageWidth) = value;
			}
		}

		// Token: 0x17002400 RID: 9216
		// (get) Token: 0x06009624 RID: 38436 RVA: 0x000D61AE File Offset: 0x000D43AE
		// (set) Token: 0x06009625 RID: 38437 RVA: 0x000D61BE File Offset: 0x000D43BE
		public unsafe int TexturePageMaxHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_TexturePageMaxHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_TexturePageMaxHeight) = value;
			}
		}

		// Token: 0x17002401 RID: 9217
		// (get) Token: 0x06009626 RID: 38438 RVA: 0x000D61CF File Offset: 0x000D43CF
		// (set) Token: 0x06009627 RID: 38439 RVA: 0x000D61DF File Offset: 0x000D43DF
		public unsafe int XPadding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_XPadding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_XPadding) = value;
			}
		}

		// Token: 0x17002402 RID: 9218
		// (get) Token: 0x06009628 RID: 38440 RVA: 0x000D61F0 File Offset: 0x000D43F0
		// (set) Token: 0x06009629 RID: 38441 RVA: 0x000D6200 File Offset: 0x000D4400
		public unsafe int YPadding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_YPadding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_YPadding) = value;
			}
		}

		// Token: 0x17002403 RID: 9219
		// (get) Token: 0x0600962A RID: 38442 RVA: 0x000D6211 File Offset: 0x000D4411
		// (set) Token: 0x0600962B RID: 38443 RVA: 0x000D6221 File Offset: 0x000D4421
		public unsafe int ExtendBoxTop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_ExtendBoxTop);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_ExtendBoxTop) = value;
			}
		}

		// Token: 0x17002404 RID: 9220
		// (get) Token: 0x0600962C RID: 38444 RVA: 0x000D6232 File Offset: 0x000D4432
		// (set) Token: 0x0600962D RID: 38445 RVA: 0x000D6242 File Offset: 0x000D4442
		public unsafe int ExtendBoxBottom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_ExtendBoxBottom);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_ExtendBoxBottom) = value;
			}
		}

		// Token: 0x17002405 RID: 9221
		// (get) Token: 0x0600962E RID: 38446 RVA: 0x000D6253 File Offset: 0x000D4453
		// (set) Token: 0x0600962F RID: 38447 RVA: 0x000D6263 File Offset: 0x000D4463
		public unsafe int ExtendBoxRight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_ExtendBoxRight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_ExtendBoxRight) = value;
			}
		}

		// Token: 0x17002406 RID: 9222
		// (get) Token: 0x06009630 RID: 38448 RVA: 0x000D6274 File Offset: 0x000D4474
		// (set) Token: 0x06009631 RID: 38449 RVA: 0x000D6284 File Offset: 0x000D4484
		public unsafe int ExtendBoxLeft
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_ExtendBoxLeft);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_ExtendBoxLeft) = value;
			}
		}

		// Token: 0x17002407 RID: 9223
		// (get) Token: 0x06009632 RID: 38450 RVA: 0x000D6295 File Offset: 0x000D4495
		// (set) Token: 0x06009633 RID: 38451 RVA: 0x000D62AE File Offset: 0x000D44AE
		public unsafe bool bEnableLegacyMode
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_bEnableLegacyMode) & FFontImportOptionsData.__PropertyMask_bEnableLegacyMode) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_bEnableLegacyMode) = ((*(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_bEnableLegacyMode) & ~FFontImportOptionsData.__PropertyMask_bEnableLegacyMode) | (value ? FFontImportOptionsData.__PropertyMask_bEnableLegacyMode : 0));
			}
		}

		// Token: 0x17002408 RID: 9224
		// (get) Token: 0x06009634 RID: 38452 RVA: 0x000D62DE File Offset: 0x000D44DE
		// (set) Token: 0x06009635 RID: 38453 RVA: 0x000D62EE File Offset: 0x000D44EE
		public unsafe int Kerning
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_Kerning);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_Kerning) = value;
			}
		}

		// Token: 0x17002409 RID: 9225
		// (get) Token: 0x06009636 RID: 38454 RVA: 0x000D62FF File Offset: 0x000D44FF
		// (set) Token: 0x06009637 RID: 38455 RVA: 0x000D6318 File Offset: 0x000D4518
		public unsafe bool bUseDistanceFieldAlpha
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_bUseDistanceFieldAlpha) & FFontImportOptionsData.__PropertyMask_bUseDistanceFieldAlpha) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_bUseDistanceFieldAlpha) = ((*(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_bUseDistanceFieldAlpha) & ~FFontImportOptionsData.__PropertyMask_bUseDistanceFieldAlpha) | (value ? FFontImportOptionsData.__PropertyMask_bUseDistanceFieldAlpha : 0));
			}
		}

		// Token: 0x1700240A RID: 9226
		// (get) Token: 0x06009638 RID: 38456 RVA: 0x000D6348 File Offset: 0x000D4548
		// (set) Token: 0x06009639 RID: 38457 RVA: 0x000D6358 File Offset: 0x000D4558
		public unsafe int DistanceFieldScaleFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_DistanceFieldScaleFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_DistanceFieldScaleFactor) = value;
			}
		}

		// Token: 0x1700240B RID: 9227
		// (get) Token: 0x0600963A RID: 38458 RVA: 0x000D6369 File Offset: 0x000D4569
		// (set) Token: 0x0600963B RID: 38459 RVA: 0x000D6379 File Offset: 0x000D4579
		public unsafe float DistanceFieldScanRadiusScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_DistanceFieldScanRadiusScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFontImportOptionsData.__PropertyOffset_DistanceFieldScanRadiusScale) = value;
			}
		}

		// Token: 0x0600963C RID: 38460 RVA: 0x000D638A File Offset: 0x000D458A
		public FFontImportOptionsData()
		{
		}

		// Token: 0x0600963D RID: 38461 RVA: 0x000D6394 File Offset: 0x000D4594
		public FFontImportOptionsData(string FontName, float Height, bool bEnableAntialiasing, bool bEnableBold, bool bEnableItalic, bool bEnableUnderline, bool bAlphaOnly, [Nullable(0)] TEnumAsByte<EFontImportCharacterSet> CharacterSet, string Chars, string UnicodeRange, string CharsFilePath, string CharsFileWildcard, bool bCreatePrintableOnly, bool bIncludeASCIIRange, FLinearColor ForegroundColor, bool bEnableDropShadow, int TexturePageWidth, int TexturePageMaxHeight, int XPadding, int YPadding, int ExtendBoxTop, int ExtendBoxBottom, int ExtendBoxRight, int ExtendBoxLeft, bool bEnableLegacyMode, int Kerning, bool bUseDistanceFieldAlpha, int DistanceFieldScaleFactor, float DistanceFieldScanRadiusScale)
		{
			this.FontName = FontName;
			this.Height = Height;
			this.bEnableAntialiasing = bEnableAntialiasing;
			this.bEnableBold = bEnableBold;
			this.bEnableItalic = bEnableItalic;
			this.bEnableUnderline = bEnableUnderline;
			this.bAlphaOnly = bAlphaOnly;
			this.CharacterSet = CharacterSet;
			this.Chars = Chars;
			this.UnicodeRange = UnicodeRange;
			this.CharsFilePath = CharsFilePath;
			this.CharsFileWildcard = CharsFileWildcard;
			this.bCreatePrintableOnly = bCreatePrintableOnly;
			this.bIncludeASCIIRange = bIncludeASCIIRange;
			this.ForegroundColor = ForegroundColor;
			this.bEnableDropShadow = bEnableDropShadow;
			this.TexturePageWidth = TexturePageWidth;
			this.TexturePageMaxHeight = TexturePageMaxHeight;
			this.XPadding = XPadding;
			this.YPadding = YPadding;
			this.ExtendBoxTop = ExtendBoxTop;
			this.ExtendBoxBottom = ExtendBoxBottom;
			this.ExtendBoxRight = ExtendBoxRight;
			this.ExtendBoxLeft = ExtendBoxLeft;
			this.bEnableLegacyMode = bEnableLegacyMode;
			this.Kerning = Kerning;
			this.bUseDistanceFieldAlpha = bUseDistanceFieldAlpha;
			this.DistanceFieldScaleFactor = DistanceFieldScaleFactor;
			this.DistanceFieldScanRadiusScale = DistanceFieldScanRadiusScale;
		}

		// Token: 0x0600963E RID: 38462 RVA: 0x000D648C File Offset: 0x000D468C
		protected override IntPtr GetUStructPtr()
		{
			return FFontImportOptionsData.StaticStruct();
		}

		// Token: 0x0600963F RID: 38463 RVA: 0x000D6498 File Offset: 0x000D4698
		[NullableContext(2)]
		public FFontImportOptionsData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009640 RID: 38464 RVA: 0x000D64A2 File Offset: 0x000D46A2
		public FFontImportOptionsData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009641 RID: 38465 RVA: 0x000D64AD File Offset: 0x000D46AD
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFontImportOptionsData(Pointer, false, true);
		}

		// Token: 0x06009642 RID: 38466 RVA: 0x000D64B7 File Offset: 0x000D46B7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFontImportOptionsData(Pointer, MemoryOwner);
		}

		// Token: 0x04005426 RID: 21542
		public const string __ObjectPath = "/Script/Engine.FontImportOptionsData";

		// Token: 0x04005427 RID: 21543
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005428 RID: 21544
		internal static int __PropertyOffset_FontName;

		// Token: 0x04005429 RID: 21545
		internal static int __PropertyOffset_Height;

		// Token: 0x0400542A RID: 21546
		internal static int __PropertyOffset_bEnableAntialiasing;

		// Token: 0x0400542B RID: 21547
		internal static byte __PropertyMask_bEnableAntialiasing;

		// Token: 0x0400542C RID: 21548
		internal static int __PropertyOffset_bEnableBold;

		// Token: 0x0400542D RID: 21549
		internal static byte __PropertyMask_bEnableBold;

		// Token: 0x0400542E RID: 21550
		internal static int __PropertyOffset_bEnableItalic;

		// Token: 0x0400542F RID: 21551
		internal static byte __PropertyMask_bEnableItalic;

		// Token: 0x04005430 RID: 21552
		internal static int __PropertyOffset_bEnableUnderline;

		// Token: 0x04005431 RID: 21553
		internal static byte __PropertyMask_bEnableUnderline;

		// Token: 0x04005432 RID: 21554
		internal static int __PropertyOffset_bAlphaOnly;

		// Token: 0x04005433 RID: 21555
		internal static byte __PropertyMask_bAlphaOnly;

		// Token: 0x04005434 RID: 21556
		internal static int __PropertyOffset_CharacterSet;

		// Token: 0x04005435 RID: 21557
		internal static int __PropertyOffset_Chars;

		// Token: 0x04005436 RID: 21558
		internal static int __PropertyOffset_UnicodeRange;

		// Token: 0x04005437 RID: 21559
		internal static int __PropertyOffset_CharsFilePath;

		// Token: 0x04005438 RID: 21560
		internal static int __PropertyOffset_CharsFileWildcard;

		// Token: 0x04005439 RID: 21561
		internal static int __PropertyOffset_bCreatePrintableOnly;

		// Token: 0x0400543A RID: 21562
		internal static byte __PropertyMask_bCreatePrintableOnly;

		// Token: 0x0400543B RID: 21563
		internal static int __PropertyOffset_bIncludeASCIIRange;

		// Token: 0x0400543C RID: 21564
		internal static byte __PropertyMask_bIncludeASCIIRange;

		// Token: 0x0400543D RID: 21565
		internal static int __PropertyOffset_ForegroundColor;

		// Token: 0x0400543E RID: 21566
		internal static int __PropertyOffset_bEnableDropShadow;

		// Token: 0x0400543F RID: 21567
		internal static byte __PropertyMask_bEnableDropShadow;

		// Token: 0x04005440 RID: 21568
		internal static int __PropertyOffset_TexturePageWidth;

		// Token: 0x04005441 RID: 21569
		internal static int __PropertyOffset_TexturePageMaxHeight;

		// Token: 0x04005442 RID: 21570
		internal static int __PropertyOffset_XPadding;

		// Token: 0x04005443 RID: 21571
		internal static int __PropertyOffset_YPadding;

		// Token: 0x04005444 RID: 21572
		internal static int __PropertyOffset_ExtendBoxTop;

		// Token: 0x04005445 RID: 21573
		internal static int __PropertyOffset_ExtendBoxBottom;

		// Token: 0x04005446 RID: 21574
		internal static int __PropertyOffset_ExtendBoxRight;

		// Token: 0x04005447 RID: 21575
		internal static int __PropertyOffset_ExtendBoxLeft;

		// Token: 0x04005448 RID: 21576
		internal static int __PropertyOffset_bEnableLegacyMode;

		// Token: 0x04005449 RID: 21577
		internal static byte __PropertyMask_bEnableLegacyMode;

		// Token: 0x0400544A RID: 21578
		internal static int __PropertyOffset_Kerning;

		// Token: 0x0400544B RID: 21579
		internal static int __PropertyOffset_bUseDistanceFieldAlpha;

		// Token: 0x0400544C RID: 21580
		internal static byte __PropertyMask_bUseDistanceFieldAlpha;

		// Token: 0x0400544D RID: 21581
		internal static int __PropertyOffset_DistanceFieldScaleFactor;

		// Token: 0x0400544E RID: 21582
		internal static int __PropertyOffset_DistanceFieldScanRadiusScale;
	}
}
