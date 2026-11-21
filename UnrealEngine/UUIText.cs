using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200072D RID: 1837
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIText")]
	[UnrealStructLayout(3136, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3136)]
	public class UUIText : UUIBatchGeometryRenderable, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009F64 RID: 40804 RVA: 0x000EC92D File Offset: 0x000EAB2D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIText._ClassPtr;
		}

		// Token: 0x06009F65 RID: 40805 RVA: 0x000EC93C File Offset: 0x000EAB3C
		public UUIText() : this(BuiltinUtils.AllocNativeUObject(UUIText.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009F66 RID: 40806 RVA: 0x000EC964 File Offset: 0x000EAB64
		public UUIText(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIText.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001D9D RID: 7581
		// (get) Token: 0x06009F67 RID: 40807 RVA: 0x000EC997 File Offset: 0x000EAB97
		// (set) Token: 0x06009F68 RID: 40808 RVA: 0x000EC9AB File Offset: 0x000EABAB
		[Nullable(2)]
		public unsafe ULGUIFontData_BaseObject font
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUIFontData_BaseObject>(base.NativePtr / (IntPtr)sizeof(void*) + UUIText.__PropertyOffset_font);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIText.__PropertyOffset_font, value);
			}
		}

		// Token: 0x17001D9E RID: 7582
		// (get) Token: 0x06009F69 RID: 40809 RVA: 0x000EC9C0 File Offset: 0x000EABC0
		// (set) Token: 0x06009F6A RID: 40810 RVA: 0x000EC9D4 File Offset: 0x000EABD4
		public unsafe string text
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UUIText.__PropertyOffset_text)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UUIText.__PropertyOffset_text)), value);
			}
		}

		// Token: 0x17001D9F RID: 7583
		// (get) Token: 0x06009F6B RID: 40811 RVA: 0x000EC9E9 File Offset: 0x000EABE9
		// (set) Token: 0x06009F6C RID: 40812 RVA: 0x000EC9F9 File Offset: 0x000EABF9
		public unsafe float size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_size) = value;
			}
		}

		// Token: 0x17001DA0 RID: 7584
		// (get) Token: 0x06009F6D RID: 40813 RVA: 0x000ECA0A File Offset: 0x000EAC0A
		// (set) Token: 0x06009F6E RID: 40814 RVA: 0x000ECA1E File Offset: 0x000EAC1E
		public unsafe FVector2D spacePercentage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_spacePercentage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_spacePercentage) = value;
			}
		}

		// Token: 0x17001DA1 RID: 7585
		// (get) Token: 0x06009F6F RID: 40815 RVA: 0x000ECA33 File Offset: 0x000EAC33
		// (set) Token: 0x06009F70 RID: 40816 RVA: 0x000ECA47 File Offset: 0x000EAC47
		public unsafe FVector2D space
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_space);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_space) = value;
			}
		}

		// Token: 0x17001DA2 RID: 7586
		// (get) Token: 0x06009F71 RID: 40817 RVA: 0x000ECA5C File Offset: 0x000EAC5C
		// (set) Token: 0x06009F72 RID: 40818 RVA: 0x000ECA6C File Offset: 0x000EAC6C
		public unsafe int outlineSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_outlineSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_outlineSize) = value;
			}
		}

		// Token: 0x17001DA3 RID: 7587
		// (get) Token: 0x06009F73 RID: 40819 RVA: 0x000ECA7D File Offset: 0x000EAC7D
		// (set) Token: 0x06009F74 RID: 40820 RVA: 0x000ECA91 File Offset: 0x000EAC91
		public unsafe FColor outlineColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_outlineColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_outlineColor) = value;
			}
		}

		// Token: 0x17001DA4 RID: 7588
		// (get) Token: 0x06009F75 RID: 40821 RVA: 0x000ECAA6 File Offset: 0x000EACA6
		// (set) Token: 0x06009F76 RID: 40822 RVA: 0x000ECAB6 File Offset: 0x000EACB6
		public unsafe short glowSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_glowSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_glowSize) = value;
			}
		}

		// Token: 0x17001DA5 RID: 7589
		// (get) Token: 0x06009F77 RID: 40823 RVA: 0x000ECAC7 File Offset: 0x000EACC7
		// (set) Token: 0x06009F78 RID: 40824 RVA: 0x000ECADB File Offset: 0x000EACDB
		public unsafe FColor glowColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_glowColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_glowColor) = value;
			}
		}

		// Token: 0x17001DA6 RID: 7590
		// (get) Token: 0x06009F79 RID: 40825 RVA: 0x000ECAF0 File Offset: 0x000EACF0
		// (set) Token: 0x06009F7A RID: 40826 RVA: 0x000ECB00 File Offset: 0x000EAD00
		public unsafe UITextParagraphHorizontalAlign hAlign
		{
			get
			{
				return (UITextParagraphHorizontalAlign)(*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_hAlign));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_hAlign) = (byte)value;
			}
		}

		// Token: 0x17001DA7 RID: 7591
		// (get) Token: 0x06009F7B RID: 40827 RVA: 0x000ECB11 File Offset: 0x000EAD11
		// (set) Token: 0x06009F7C RID: 40828 RVA: 0x000ECB21 File Offset: 0x000EAD21
		public unsafe UITextOverflowType overflowType
		{
			get
			{
				return (UITextOverflowType)(*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_overflowType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_overflowType) = (byte)value;
			}
		}

		// Token: 0x17001DA8 RID: 7592
		// (get) Token: 0x06009F7D RID: 40829 RVA: 0x000ECB32 File Offset: 0x000EAD32
		// (set) Token: 0x06009F7E RID: 40830 RVA: 0x000ECB42 File Offset: 0x000EAD42
		public unsafe bool verticalOverflowBestFitSwitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_verticalOverflowBestFitSwitch) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_verticalOverflowBestFitSwitch) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001DA9 RID: 7593
		// (get) Token: 0x06009F7F RID: 40831 RVA: 0x000ECB53 File Offset: 0x000EAD53
		// (set) Token: 0x06009F80 RID: 40832 RVA: 0x000ECB63 File Offset: 0x000EAD63
		public unsafe int maxWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_maxWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_maxWidth) = value;
			}
		}

		// Token: 0x17001DAA RID: 7594
		// (get) Token: 0x06009F81 RID: 40833 RVA: 0x000ECB74 File Offset: 0x000EAD74
		// (set) Token: 0x06009F82 RID: 40834 RVA: 0x000ECB84 File Offset: 0x000EAD84
		public unsafe int maxHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_maxHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_maxHeight) = value;
			}
		}

		// Token: 0x17001DAB RID: 7595
		// (get) Token: 0x06009F83 RID: 40835 RVA: 0x000ECB95 File Offset: 0x000EAD95
		// (set) Token: 0x06009F84 RID: 40836 RVA: 0x000ECBA5 File Offset: 0x000EADA5
		public unsafe bool bMaxWidthLimited
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_bMaxWidthLimited) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_bMaxWidthLimited) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001DAC RID: 7596
		// (get) Token: 0x06009F85 RID: 40837 RVA: 0x000ECBB6 File Offset: 0x000EADB6
		// (set) Token: 0x06009F86 RID: 40838 RVA: 0x000ECBC6 File Offset: 0x000EADC6
		public unsafe bool bMaxHeightLimited
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_bMaxHeightLimited) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_bMaxHeightLimited) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001DAD RID: 7597
		// (get) Token: 0x06009F87 RID: 40839 RVA: 0x000ECBD7 File Offset: 0x000EADD7
		// (set) Token: 0x06009F88 RID: 40840 RVA: 0x000ECBE7 File Offset: 0x000EADE7
		public unsafe bool adjustWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_adjustWidth) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_adjustWidth) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001DAE RID: 7598
		// (get) Token: 0x06009F89 RID: 40841 RVA: 0x000ECBF8 File Offset: 0x000EADF8
		// (set) Token: 0x06009F8A RID: 40842 RVA: 0x000ECC08 File Offset: 0x000EAE08
		public unsafe bool adjustHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_adjustHeight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_adjustHeight) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001DAF RID: 7599
		// (get) Token: 0x06009F8B RID: 40843 RVA: 0x000ECC19 File Offset: 0x000EAE19
		// (set) Token: 0x06009F8C RID: 40844 RVA: 0x000ECC29 File Offset: 0x000EAE29
		public unsafe bool NeedCustomerLimitWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_NeedCustomerLimitWidth) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_NeedCustomerLimitWidth) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001DB0 RID: 7600
		// (get) Token: 0x06009F8D RID: 40845 RVA: 0x000ECC3A File Offset: 0x000EAE3A
		// (set) Token: 0x06009F8E RID: 40846 RVA: 0x000ECC4A File Offset: 0x000EAE4A
		public unsafe float CustomerLimitWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_CustomerLimitWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_CustomerLimitWidth) = value;
			}
		}

		// Token: 0x17001DB1 RID: 7601
		// (get) Token: 0x06009F8F RID: 40847 RVA: 0x000ECC5B File Offset: 0x000EAE5B
		// (set) Token: 0x06009F90 RID: 40848 RVA: 0x000ECC6B File Offset: 0x000EAE6B
		public unsafe bool richText
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_richText) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_richText) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001DB2 RID: 7602
		// (get) Token: 0x06009F91 RID: 40849 RVA: 0x000ECC7C File Offset: 0x000EAE7C
		// (set) Token: 0x06009F92 RID: 40850 RVA: 0x000ECC8C File Offset: 0x000EAE8C
		public unsafe bool bApplyAlphaOnRichText
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_bApplyAlphaOnRichText) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_bApplyAlphaOnRichText) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001DB3 RID: 7603
		// (get) Token: 0x06009F93 RID: 40851 RVA: 0x000ECC9D File Offset: 0x000EAE9D
		// (set) Token: 0x06009F94 RID: 40852 RVA: 0x000ECCAD File Offset: 0x000EAEAD
		public unsafe bool bFilterAnoRichTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_bFilterAnoRichTag) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_bFilterAnoRichTag) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001DB4 RID: 7604
		// (get) Token: 0x06009F95 RID: 40853 RVA: 0x000ECCBE File Offset: 0x000EAEBE
		// (set) Token: 0x06009F96 RID: 40854 RVA: 0x000ECCCE File Offset: 0x000EAECE
		public unsafe bool bBestFit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_bBestFit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_bBestFit) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001DB5 RID: 7605
		// (get) Token: 0x06009F97 RID: 40855 RVA: 0x000ECCDF File Offset: 0x000EAEDF
		// (set) Token: 0x06009F98 RID: 40856 RVA: 0x000ECCEF File Offset: 0x000EAEEF
		public unsafe bool bRichTextTextureBestFit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_bRichTextTextureBestFit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_bRichTextTextureBestFit) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001DB6 RID: 7606
		// (get) Token: 0x06009F99 RID: 40857 RVA: 0x000ECD00 File Offset: 0x000EAF00
		// (set) Token: 0x06009F9A RID: 40858 RVA: 0x000ECD10 File Offset: 0x000EAF10
		public unsafe bool bAlignCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_bAlignCenter) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_bAlignCenter) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001DB7 RID: 7607
		// (get) Token: 0x06009F9B RID: 40859 RVA: 0x000ECD21 File Offset: 0x000EAF21
		// (set) Token: 0x06009F9C RID: 40860 RVA: 0x000ECD31 File Offset: 0x000EAF31
		public unsafe bool bIgnoreWordRules
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_bIgnoreWordRules) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_bIgnoreWordRules) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001DB8 RID: 7608
		// (get) Token: 0x06009F9D RID: 40861 RVA: 0x000ECD42 File Offset: 0x000EAF42
		// (set) Token: 0x06009F9E RID: 40862 RVA: 0x000ECD52 File Offset: 0x000EAF52
		public unsafe bool bAutoEllipsis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_bAutoEllipsis) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_bAutoEllipsis) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001DB9 RID: 7609
		// (get) Token: 0x06009F9F RID: 40863 RVA: 0x000ECD63 File Offset: 0x000EAF63
		// (set) Token: 0x06009FA0 RID: 40864 RVA: 0x000ECD73 File Offset: 0x000EAF73
		public unsafe bool bAutoEllipsisSplitWord
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_bAutoEllipsisSplitWord) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_bAutoEllipsisSplitWord) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001DBA RID: 7610
		// (get) Token: 0x06009FA1 RID: 40865 RVA: 0x000ECD84 File Offset: 0x000EAF84
		// (set) Token: 0x06009FA2 RID: 40866 RVA: 0x000ECD94 File Offset: 0x000EAF94
		public unsafe int BestFitMinSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_BestFitMinSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_BestFitMinSize) = value;
			}
		}

		// Token: 0x17001DBB RID: 7611
		// (get) Token: 0x06009FA3 RID: 40867 RVA: 0x000ECDA5 File Offset: 0x000EAFA5
		// (set) Token: 0x06009FA4 RID: 40868 RVA: 0x000ECDB5 File Offset: 0x000EAFB5
		public unsafe bool bCalculateOutlineSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_bCalculateOutlineSize) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_bCalculateOutlineSize) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001DBC RID: 7612
		// (get) Token: 0x06009FA5 RID: 40869 RVA: 0x000ECDC8 File Offset: 0x000EAFC8
		// (set) Token: 0x06009FA6 RID: 40870 RVA: 0x000ECE01 File Offset: 0x000EB001
		public TArray<string> hyperlinks
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._hyperlinks) == null)
				{
					result = (this._hyperlinks = new TArray<string>(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_hyperlinks, this));
				}
				return result;
			}
			set
			{
				this.hyperlinks.CopyAssign(value);
			}
		}

		// Token: 0x17001DBD RID: 7613
		// (get) Token: 0x06009FA7 RID: 40871 RVA: 0x000ECE0F File Offset: 0x000EB00F
		// (set) Token: 0x06009FA8 RID: 40872 RVA: 0x000ECE1F File Offset: 0x000EB01F
		public unsafe bool bFilterHyperLinks
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_bFilterHyperLinks) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_bFilterHyperLinks) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001DBE RID: 7614
		// (get) Token: 0x06009FA9 RID: 40873 RVA: 0x000ECE30 File Offset: 0x000EB030
		// (set) Token: 0x06009FAA RID: 40874 RVA: 0x000ECE40 File Offset: 0x000EB040
		public unsafe float hyperLinksClickAreaRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_hyperLinksClickAreaRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_hyperLinksClickAreaRatio) = value;
			}
		}

		// Token: 0x17001DBF RID: 7615
		// (get) Token: 0x06009FAB RID: 40875 RVA: 0x000ECE51 File Offset: 0x000EB051
		// (set) Token: 0x06009FAC RID: 40876 RVA: 0x000ECE61 File Offset: 0x000EB061
		public unsafe bool bEnableHyperLinksHighlight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_bEnableHyperLinksHighlight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_bEnableHyperLinksHighlight) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001DC0 RID: 7616
		// (get) Token: 0x06009FAD RID: 40877 RVA: 0x000ECE72 File Offset: 0x000EB072
		// (set) Token: 0x06009FAE RID: 40878 RVA: 0x000ECE86 File Offset: 0x000EB086
		public unsafe FColor HyperLinksHoverColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_HyperLinksHoverColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_HyperLinksHoverColor) = value;
			}
		}

		// Token: 0x17001DC1 RID: 7617
		// (get) Token: 0x06009FAF RID: 40879 RVA: 0x000ECE9B File Offset: 0x000EB09B
		// (set) Token: 0x06009FB0 RID: 40880 RVA: 0x000ECEAB File Offset: 0x000EB0AB
		public unsafe bool bUseGradientUV2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_bUseGradientUV2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_bUseGradientUV2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001DC2 RID: 7618
		// (get) Token: 0x06009FB1 RID: 40881 RVA: 0x000ECEBC File Offset: 0x000EB0BC
		// (set) Token: 0x06009FB2 RID: 40882 RVA: 0x000ECECC File Offset: 0x000EB0CC
		public unsafe bool bOutlineAlphaIndependent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_bOutlineAlphaIndependent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_bOutlineAlphaIndependent) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001DC3 RID: 7619
		// (get) Token: 0x06009FB3 RID: 40883 RVA: 0x000ECEDD File Offset: 0x000EB0DD
		// (set) Token: 0x06009FB4 RID: 40884 RVA: 0x000ECEED File Offset: 0x000EB0ED
		public unsafe bool bOutlineUV3SetOriginTextUV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_bOutlineUV3SetOriginTextUV) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_bOutlineUV3SetOriginTextUV) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001DC4 RID: 7620
		// (get) Token: 0x06009FB5 RID: 40885 RVA: 0x000ECEFE File Offset: 0x000EB0FE
		// (set) Token: 0x06009FB6 RID: 40886 RVA: 0x000ECF0E File Offset: 0x000EB10E
		public unsafe bool bUseUV1AsGlyphType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_bUseUV1AsGlyphType) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_bUseUV1AsGlyphType) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001DC5 RID: 7621
		// (get) Token: 0x06009FB7 RID: 40887 RVA: 0x000ECF1F File Offset: 0x000EB11F
		// (set) Token: 0x06009FB8 RID: 40888 RVA: 0x000ECF2F File Offset: 0x000EB12F
		public unsafe bool bGlowAlphaInherit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_bGlowAlphaInherit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_bGlowAlphaInherit) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001DC6 RID: 7622
		// (get) Token: 0x06009FB9 RID: 40889 RVA: 0x000ECF40 File Offset: 0x000EB140
		// (set) Token: 0x06009FBA RID: 40890 RVA: 0x000ECF50 File Offset: 0x000EB150
		public unsafe bool bGlowAlphaIndependent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_bGlowAlphaIndependent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_bGlowAlphaIndependent) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001DC7 RID: 7623
		// (get) Token: 0x06009FBB RID: 40891 RVA: 0x000ECF64 File Offset: 0x000EB164
		// (set) Token: 0x06009FBC RID: 40892 RVA: 0x000ECF9D File Offset: 0x000EB19D
		public FLGUITextClickDelegate OnHyperLinkClickCallBack
		{
			get
			{
				base.FastCheckIsValid();
				FLGUITextClickDelegate result;
				if ((result = this._OnHyperLinkClickCallBack) == null)
				{
					result = (this._OnHyperLinkClickCallBack = new FLGUITextClickDelegate(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_OnHyperLinkClickCallBack, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_OnHyperLinkClickCallBack, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001DC8 RID: 7624
		// (get) Token: 0x06009FBD RID: 40893 RVA: 0x000ECFBE File Offset: 0x000EB1BE
		// (set) Token: 0x06009FBE RID: 40894 RVA: 0x000ECFCE File Offset: 0x000EB1CE
		public unsafe bool bEnableTextRenderSystemV2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_bEnableTextRenderSystemV2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_bEnableTextRenderSystemV2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001DC9 RID: 7625
		// (get) Token: 0x06009FBF RID: 40895 RVA: 0x000ECFE0 File Offset: 0x000EB1E0
		// (set) Token: 0x06009FC0 RID: 40896 RVA: 0x000ED019 File Offset: 0x000EB219
		public FSelfLanguageChange OnSelfLanguageChange
		{
			get
			{
				base.FastCheckIsValid();
				FSelfLanguageChange result;
				if ((result = this._OnSelfLanguageChange) == null)
				{
					result = (this._OnSelfLanguageChange = new FSelfLanguageChange(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_OnSelfLanguageChange, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_OnSelfLanguageChange, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001DCA RID: 7626
		// (get) Token: 0x06009FC1 RID: 40897 RVA: 0x000ED03C File Offset: 0x000EB23C
		// (set) Token: 0x06009FC2 RID: 40898 RVA: 0x000ED075 File Offset: 0x000EB275
		public FLGUITextAsyncLoadFinishedDelegate OnTextureAsyncLoaded
		{
			get
			{
				base.FastCheckIsValid();
				FLGUITextAsyncLoadFinishedDelegate result;
				if ((result = this._OnTextureAsyncLoaded) == null)
				{
					result = (this._OnTextureAsyncLoaded = new FLGUITextAsyncLoadFinishedDelegate(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_OnTextureAsyncLoaded, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_OnTextureAsyncLoaded, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001DCB RID: 7627
		// (get) Token: 0x06009FC3 RID: 40899 RVA: 0x000ED096 File Offset: 0x000EB296
		// (set) Token: 0x06009FC4 RID: 40900 RVA: 0x000ED0A6 File Offset: 0x000EB2A6
		public unsafe uint TranslateId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_TranslateId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_TranslateId) = (int)value;
			}
		}

		// Token: 0x17001DCC RID: 7628
		// (get) Token: 0x06009FC5 RID: 40901 RVA: 0x000ED0B7 File Offset: 0x000EB2B7
		// (set) Token: 0x06009FC6 RID: 40902 RVA: 0x000ED0C7 File Offset: 0x000EB2C7
		public unsafe bool bGameRichText
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_bGameRichText) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_bGameRichText) = (value ? 1 : 0);
			}
		}

		// Token: 0x06009FC7 RID: 40903 RVA: 0x000ED0D8 File Offset: 0x000EB2D8
		public unsafe void ShowTextNew(string Key)
		{
			FString fstring = FString.AllocTemp(Key);
			UUIText.__ShowTextNew_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06009FC8 RID: 40904 RVA: 0x000ED104 File Offset: 0x000EB304
		public unsafe void ShowText(string ConfigTableName, int Key)
		{
			FString fstring = FString.AllocTemp(ConfigTableName);
			UUIText.__ShowText_Internal(base.NativePtr, fstring, Key);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06009FC9 RID: 40905 RVA: 0x000ED12F File Offset: 0x000EB32F
		[NullableContext(2)]
		public static void SetTsGameRichTextDelegate(in FTsGameRichTextDelegate Delegate)
		{
			FTsGameRichTextDelegate ftsGameRichTextDelegate = Delegate;
			UUIText.__SetTsGameRichTextDelegate_Internal((ftsGameRichTextDelegate != null) ? ftsGameRichTextDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06009FCA RID: 40906 RVA: 0x000ED145 File Offset: 0x000EB345
		[NullableContext(2)]
		public static void SetTextTranslateDelegate(in FLGUITextTranslateDelegate Delegate)
		{
			FLGUITextTranslateDelegate flguitextTranslateDelegate = Delegate;
			UUIText.__SetTextTranslateDelegate_Internal((flguitextTranslateDelegate != null) ? flguitextTranslateDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06009FCB RID: 40907 RVA: 0x000ED15C File Offset: 0x000EB35C
		public unsafe void SetText(string newText, bool DisableTranslate = true)
		{
			FString fstring = FString.AllocTemp(newText);
			UUIText.__SetText_Internal(base.NativePtr, fstring, DisableTranslate);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06009FCC RID: 40908 RVA: 0x000ED187 File Offset: 0x000EB387
		public void SetRichText(bool newRichText)
		{
			UUIText.__SetRichText_Internal(base.NativePtr, newRichText);
		}

		// Token: 0x06009FCD RID: 40909 RVA: 0x000ED195 File Offset: 0x000EB395
		public void SetParagraphHorizontalAlignment(UITextParagraphHorizontalAlign newHAlign)
		{
			UUIText.__SetParagraphHorizontalAlignment_Internal(base.NativePtr, newHAlign);
		}

		// Token: 0x06009FCE RID: 40910 RVA: 0x000ED1A3 File Offset: 0x000EB3A3
		public void SetOverflowType(UITextOverflowType newOverflowType)
		{
			UUIText.__SetOverflowType_Internal(base.NativePtr, newOverflowType);
		}

		// Token: 0x06009FCF RID: 40911 RVA: 0x000ED1B1 File Offset: 0x000EB3B1
		public void SetMaxWidth(int NewMaxWidth)
		{
			UUIText.__SetMaxWidth_Internal(base.NativePtr, NewMaxWidth);
		}

		// Token: 0x06009FD0 RID: 40912 RVA: 0x000ED1BF File Offset: 0x000EB3BF
		public void SetMaxHeight(int NewMaxHeight)
		{
			UUIText.__SetMaxHeight_Internal(base.NativePtr, NewMaxHeight);
		}

		// Token: 0x06009FD1 RID: 40913 RVA: 0x000ED1CD File Offset: 0x000EB3CD
		[NullableContext(2)]
		public static void SetLocalTextNewDelegate(in FLocalTextNewDelegate Delegate)
		{
			FLocalTextNewDelegate flocalTextNewDelegate = Delegate;
			UUIText.__SetLocalTextNewDelegate_Internal((flocalTextNewDelegate != null) ? flocalTextNewDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06009FD2 RID: 40914 RVA: 0x000ED1E3 File Offset: 0x000EB3E3
		[NullableContext(2)]
		public static void SetLocalTextDelegate(in FLocalTextDelegate Delegate)
		{
			FLocalTextDelegate flocalTextDelegate = Delegate;
			UUIText.__SetLocalTextDelegate_Internal((flocalTextDelegate != null) ? flocalTextDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06009FD3 RID: 40915 RVA: 0x000ED1F9 File Offset: 0x000EB3F9
		public void SetHyperLinksHoverSpiteActive(bool bActive)
		{
			UUIText.__SetHyperLinksHoverSpiteActive_Internal(base.NativePtr, bActive);
		}

		// Token: 0x06009FD4 RID: 40916 RVA: 0x000ED207 File Offset: 0x000EB407
		[NullableContext(2)]
		public static void SetGmReplaceFontDelegate(in FLGUITextGmReplaceFontDelegate Delegate)
		{
			FLGUITextGmReplaceFontDelegate flguitextGmReplaceFontDelegate = Delegate;
			UUIText.__SetGmReplaceFontDelegate_Internal((flguitextGmReplaceFontDelegate != null) ? flguitextGmReplaceFontDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06009FD5 RID: 40917 RVA: 0x000ED21D File Offset: 0x000EB41D
		public void SetGameRichText(bool value)
		{
			UUIText.__SetGameRichText_Internal(base.NativePtr, value);
		}

		// Token: 0x06009FD6 RID: 40918 RVA: 0x000ED22B File Offset: 0x000EB42B
		public void SetFontSpacePercentage(FVector2D newSpace)
		{
			UUIText.__SetFontSpacePercentage_Internal(base.NativePtr, newSpace);
		}

		// Token: 0x06009FD7 RID: 40919 RVA: 0x000ED239 File Offset: 0x000EB439
		public void SetFontSpace(FVector2D newSpace)
		{
			UUIText.__SetFontSpace_Internal(base.NativePtr, newSpace);
		}

		// Token: 0x06009FD8 RID: 40920 RVA: 0x000ED247 File Offset: 0x000EB447
		public void SetFontSize(float newSize)
		{
			UUIText.__SetFontSize_Internal(base.NativePtr, newSize);
		}

		// Token: 0x06009FD9 RID: 40921 RVA: 0x000ED255 File Offset: 0x000EB455
		public void SetFontOutlineColor(FColor NewOutlineColor)
		{
			UUIText.__SetFontOutlineColor_Internal(base.NativePtr, NewOutlineColor);
		}

		// Token: 0x06009FDA RID: 40922 RVA: 0x000ED263 File Offset: 0x000EB463
		[NullableContext(2)]
		public void SetFont(ULGUIFontData_BaseObject newFont)
		{
			UUIText.__SetFont_Internal(base.NativePtr, (newFont != null) ? newFont.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009FDB RID: 40923 RVA: 0x000ED280 File Offset: 0x000EB480
		public void SetFilterHyperLinks(bool bNewFilterHyperLinks)
		{
			UUIText.__SetFilterHyperLinks_Internal(base.NativePtr, bNewFilterHyperLinks);
		}

		// Token: 0x06009FDC RID: 40924 RVA: 0x000ED28E File Offset: 0x000EB48E
		public void SetFilterAnoRichTag(bool bFilter)
		{
			UUIText.__SetFilterAnoRichTag_Internal(base.NativePtr, bFilter);
		}

		// Token: 0x06009FDD RID: 40925 RVA: 0x000ED29C File Offset: 0x000EB49C
		public void SetEnableHyperLinksHighlight(bool bEnabled)
		{
			UUIText.__SetEnableHyperLinksHighlight_Internal(base.NativePtr, bEnabled);
		}

		// Token: 0x06009FDE RID: 40926 RVA: 0x000ED2AA File Offset: 0x000EB4AA
		public void SetAdjustWidth(bool newAdjustWidth)
		{
			UUIText.__SetAdjustWidth_Internal(base.NativePtr, newAdjustWidth);
		}

		// Token: 0x06009FDF RID: 40927 RVA: 0x000ED2B8 File Offset: 0x000EB4B8
		public void SetAdjustHeight(bool newAdjustHeight)
		{
			UUIText.__SetAdjustHeight_Internal(base.NativePtr, newAdjustHeight);
		}

		// Token: 0x06009FE0 RID: 40928
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void OnTsLanguageChange();

		// Token: 0x06009FE1 RID: 40929 RVA: 0x000ED2C6 File Offset: 0x000EB4C6
		public bool IsFilterHyperLinks()
		{
			return UUIText.__IsFilterHyperLinks_Internal(base.NativePtr);
		}

		// Token: 0x06009FE2 RID: 40930 RVA: 0x000ED2D3 File Offset: 0x000EB4D3
		public bool IsFilterAnoRichTag()
		{
			return UUIText.__IsFilterAnoRichTag_Internal(base.NativePtr);
		}

		// Token: 0x06009FE3 RID: 40931 RVA: 0x000ED2E0 File Offset: 0x000EB4E0
		public bool IsEnableHyperLinksHighlight()
		{
			return UUIText.__IsEnableHyperLinksHighlight_Internal(base.NativePtr);
		}

		// Token: 0x06009FE4 RID: 40932 RVA: 0x000ED2ED File Offset: 0x000EB4ED
		public FVector2D GetTextRenderSize()
		{
			return UUIText.__GetTextRenderSize_Internal(base.NativePtr);
		}

		// Token: 0x06009FE5 RID: 40933 RVA: 0x000ED2FA File Offset: 0x000EB4FA
		[NullableContext(2)]
		public void GetTextLineNumArray(ref TArray<int> OutArray)
		{
			UUIText.__GetTextLineNumArray_Internal(base.NativePtr, (OutArray ?? new TArray<int>()).NativePtr);
		}

		// Token: 0x06009FE6 RID: 40934 RVA: 0x000ED317 File Offset: 0x000EB517
		public string GetText()
		{
			return FString.ToStringAndDeleteNativePtr(UUIText.__GetText_Internal(base.NativePtr));
		}

		// Token: 0x06009FE7 RID: 40935 RVA: 0x000ED329 File Offset: 0x000EB529
		public float GetSize()
		{
			return UUIText.__GetSize_Internal(base.NativePtr);
		}

		// Token: 0x06009FE8 RID: 40936 RVA: 0x000ED336 File Offset: 0x000EB536
		public bool GetRichText()
		{
			return UUIText.__GetRichText_Internal(base.NativePtr);
		}

		// Token: 0x06009FE9 RID: 40937 RVA: 0x000ED343 File Offset: 0x000EB543
		public int GetRenderLineNum()
		{
			return UUIText.__GetRenderLineNum_Internal(base.NativePtr);
		}

		// Token: 0x06009FEA RID: 40938 RVA: 0x000ED350 File Offset: 0x000EB550
		public float GetRenderLineHeight(int LineIndex)
		{
			return UUIText.__GetRenderLineHeight_Internal(base.NativePtr, LineIndex);
		}

		// Token: 0x06009FEB RID: 40939 RVA: 0x000ED35E File Offset: 0x000EB55E
		public int GetRenderLineCharNum(int index)
		{
			return UUIText.__GetRenderLineCharNum_Internal(base.NativePtr, index);
		}

		// Token: 0x06009FEC RID: 40940 RVA: 0x000ED36C File Offset: 0x000EB56C
		public FVector2D GetRealSize()
		{
			return UUIText.__GetRealSize_Internal(base.NativePtr);
		}

		// Token: 0x06009FED RID: 40941 RVA: 0x000ED379 File Offset: 0x000EB579
		public int GetRealFontSize()
		{
			return UUIText.__GetRealFontSize_Internal(base.NativePtr);
		}

		// Token: 0x06009FEE RID: 40942 RVA: 0x000ED386 File Offset: 0x000EB586
		public UITextOverflowType GetOverflowType()
		{
			return UUIText.__GetOverflowType_Internal(base.NativePtr);
		}

		// Token: 0x06009FEF RID: 40943 RVA: 0x000ED393 File Offset: 0x000EB593
		public int GetMaxWidth()
		{
			return UUIText.__GetMaxWidth_Internal(base.NativePtr);
		}

		// Token: 0x06009FF0 RID: 40944 RVA: 0x000ED3A0 File Offset: 0x000EB5A0
		public int GetMaxHeight()
		{
			return UUIText.__GetMaxHeight_Internal(base.NativePtr);
		}

		// Token: 0x06009FF1 RID: 40945 RVA: 0x000ED3AD File Offset: 0x000EB5AD
		public TArray<string> GetHyperlinks()
		{
			return new TArray<string>(UUIText.__GetHyperlinks_Internal(base.NativePtr), null);
		}

		// Token: 0x06009FF2 RID: 40946 RVA: 0x000ED3C0 File Offset: 0x000EB5C0
		public FVector2D GetFontSpacePercentage()
		{
			return UUIText.__GetFontSpacePercentage_Internal(base.NativePtr);
		}

		// Token: 0x06009FF3 RID: 40947 RVA: 0x000ED3CD File Offset: 0x000EB5CD
		public FVector2D GetFontSpaceFinal()
		{
			return UUIText.__GetFontSpaceFinal_Internal(base.NativePtr);
		}

		// Token: 0x06009FF4 RID: 40948 RVA: 0x000ED3DA File Offset: 0x000EB5DA
		public FVector2D GetFontSpace()
		{
			return UUIText.__GetFontSpace_Internal(base.NativePtr);
		}

		// Token: 0x06009FF5 RID: 40949 RVA: 0x000ED3E7 File Offset: 0x000EB5E7
		public int GetFontOutlineSize()
		{
			return UUIText.__GetFontOutlineSize_Internal(base.NativePtr);
		}

		// Token: 0x06009FF6 RID: 40950 RVA: 0x000ED3F4 File Offset: 0x000EB5F4
		public FColor GetFontOutlineColor()
		{
			return UUIText.__GetFontOutlineColor_Internal(base.NativePtr);
		}

		// Token: 0x06009FF7 RID: 40951 RVA: 0x000ED401 File Offset: 0x000EB601
		public int GetFontGlowSize()
		{
			return UUIText.__GetFontGlowSize_Internal(base.NativePtr);
		}

		// Token: 0x06009FF8 RID: 40952 RVA: 0x000ED40E File Offset: 0x000EB60E
		public FColor GetFontGlowColor()
		{
			return UUIText.__GetFontGlowColor_Internal(base.NativePtr);
		}

		// Token: 0x06009FF9 RID: 40953 RVA: 0x000ED41B File Offset: 0x000EB61B
		[NullableContext(2)]
		public ULGUIFontData_BaseObject GetFont()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIFontData_BaseObject>(UUIText.__GetFont_Internal(base.NativePtr));
		}

		// Token: 0x06009FFA RID: 40954 RVA: 0x000ED42D File Offset: 0x000EB62D
		public int GetDisplayCharLength()
		{
			return UUIText.__GetDisplayCharLength_Internal(base.NativePtr);
		}

		// Token: 0x06009FFB RID: 40955 RVA: 0x000ED43A File Offset: 0x000EB63A
		public bool GetAutoEllipsisSplitWord()
		{
			return UUIText.__GetAutoEllipsisSplitWord_Internal(base.NativePtr);
		}

		// Token: 0x06009FFC RID: 40956 RVA: 0x000ED447 File Offset: 0x000EB647
		public bool GetAutoEllipsis()
		{
			return UUIText.__GetAutoEllipsis_Internal(base.NativePtr);
		}

		// Token: 0x06009FFD RID: 40957 RVA: 0x000ED454 File Offset: 0x000EB654
		public bool GetAlignCenter()
		{
			return UUIText.__GetAlignCenter_Internal(base.NativePtr);
		}

		// Token: 0x06009FFE RID: 40958 RVA: 0x000ED461 File Offset: 0x000EB661
		public bool GetAdjustWidth()
		{
			return UUIText.__GetAdjustWidth_Internal(base.NativePtr);
		}

		// Token: 0x06009FFF RID: 40959 RVA: 0x000ED46E File Offset: 0x000EB66E
		public bool GetAdjustHeight()
		{
			return UUIText.__GetAdjustHeight_Internal(base.NativePtr);
		}

		// Token: 0x0600A000 RID: 40960 RVA: 0x000ED47B File Offset: 0x000EB67B
		public void Clear()
		{
			UUIText.__Clear_Internal(base.NativePtr);
		}

		// Token: 0x0600A001 RID: 40961 RVA: 0x000ED488 File Offset: 0x000EB688
		public unsafe void AddStringArgs(string Value)
		{
			FString fstring = FString.AllocTemp(Value);
			UUIText.__AddStringArgs_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600A002 RID: 40962 RVA: 0x000ED4B2 File Offset: 0x000EB6B2
		public void AddIntArgs(int Value)
		{
			UUIText.__AddIntArgs_Internal(base.NativePtr, Value);
		}

		// Token: 0x0600A003 RID: 40963 RVA: 0x000ED4C0 File Offset: 0x000EB6C0
		public void AddInt64Args(long Value)
		{
			UUIText.__AddInt64Args_Internal(base.NativePtr, Value);
		}

		// Token: 0x0600A004 RID: 40964 RVA: 0x000ED4D0 File Offset: 0x000EB6D0
		public unsafe void AddFormatTableInfoNew(string Key)
		{
			FString fstring = FString.AllocTemp(Key);
			UUIText.__AddFormatTableInfoNew_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600A005 RID: 40965 RVA: 0x000ED4FC File Offset: 0x000EB6FC
		public unsafe void AddFormatTableInfo(string ConfigTableName, int Key)
		{
			FString fstring = FString.AllocTemp(ConfigTableName);
			UUIText.__AddFormatTableInfo_Internal(base.NativePtr, fstring, Key);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600A006 RID: 40966 RVA: 0x000ED527 File Offset: 0x000EB727
		public void AddFloatArgs(float Value)
		{
			UUIText.__AddFloatArgs_Internal(base.NativePtr, Value);
		}

		// Token: 0x0600A007 RID: 40967
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ShowTextNew_Internal(IntPtr @this, in FString Key);

		// Token: 0x0600A008 RID: 40968
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ShowText_Internal(IntPtr @this, in FString ConfigTableName, int Key);

		// Token: 0x0600A009 RID: 40969
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTsGameRichTextDelegate_Internal(IntPtr Delegate);

		// Token: 0x0600A00A RID: 40970
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTextTranslateDelegate_Internal(IntPtr Delegate);

		// Token: 0x0600A00B RID: 40971
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetText_Internal(IntPtr @this, in FString newText, bool DisableTranslate);

		// Token: 0x0600A00C RID: 40972
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRichText_Internal(IntPtr @this, bool newRichText);

		// Token: 0x0600A00D RID: 40973
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetParagraphHorizontalAlignment_Internal(IntPtr @this, UITextParagraphHorizontalAlign newHAlign);

		// Token: 0x0600A00E RID: 40974
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOverflowType_Internal(IntPtr @this, UITextOverflowType newOverflowType);

		// Token: 0x0600A00F RID: 40975
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaxWidth_Internal(IntPtr @this, int NewMaxWidth);

		// Token: 0x0600A010 RID: 40976
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaxHeight_Internal(IntPtr @this, int NewMaxHeight);

		// Token: 0x0600A011 RID: 40977
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLocalTextNewDelegate_Internal(IntPtr Delegate);

		// Token: 0x0600A012 RID: 40978
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLocalTextDelegate_Internal(IntPtr Delegate);

		// Token: 0x0600A013 RID: 40979
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHyperLinksHoverSpiteActive_Internal(IntPtr @this, bool bActive);

		// Token: 0x0600A014 RID: 40980
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGmReplaceFontDelegate_Internal(IntPtr Delegate);

		// Token: 0x0600A015 RID: 40981
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGameRichText_Internal(IntPtr @this, bool value);

		// Token: 0x0600A016 RID: 40982
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFontSpacePercentage_Internal(IntPtr @this, FVector2D newSpace);

		// Token: 0x0600A017 RID: 40983
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFontSpace_Internal(IntPtr @this, FVector2D newSpace);

		// Token: 0x0600A018 RID: 40984
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFontSize_Internal(IntPtr @this, float newSize);

		// Token: 0x0600A019 RID: 40985
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFontOutlineColor_Internal(IntPtr @this, FColor NewOutlineColor);

		// Token: 0x0600A01A RID: 40986
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFont_Internal(IntPtr @this, IntPtr newFont);

		// Token: 0x0600A01B RID: 40987
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFilterHyperLinks_Internal(IntPtr @this, bool bNewFilterHyperLinks);

		// Token: 0x0600A01C RID: 40988
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFilterAnoRichTag_Internal(IntPtr @this, bool bFilter);

		// Token: 0x0600A01D RID: 40989
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnableHyperLinksHighlight_Internal(IntPtr @this, bool bEnabled);

		// Token: 0x0600A01E RID: 40990
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAdjustWidth_Internal(IntPtr @this, bool newAdjustWidth);

		// Token: 0x0600A01F RID: 40991
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAdjustHeight_Internal(IntPtr @this, bool newAdjustHeight);

		// Token: 0x0600A020 RID: 40992
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsFilterHyperLinks_Internal(IntPtr @this);

		// Token: 0x0600A021 RID: 40993
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsFilterAnoRichTag_Internal(IntPtr @this);

		// Token: 0x0600A022 RID: 40994
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsEnableHyperLinksHighlight_Internal(IntPtr @this);

		// Token: 0x0600A023 RID: 40995
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetTextRenderSize_Internal(IntPtr @this);

		// Token: 0x0600A024 RID: 40996
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetTextLineNumArray_Internal(IntPtr @this, IntPtr OutArray);

		// Token: 0x0600A025 RID: 40997
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetText_Internal(IntPtr @this);

		// Token: 0x0600A026 RID: 40998
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetSize_Internal(IntPtr @this);

		// Token: 0x0600A027 RID: 40999
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetRichText_Internal(IntPtr @this);

		// Token: 0x0600A028 RID: 41000
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetRenderLineNum_Internal(IntPtr @this);

		// Token: 0x0600A029 RID: 41001
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRenderLineHeight_Internal(IntPtr @this, int LineIndex);

		// Token: 0x0600A02A RID: 41002
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetRenderLineCharNum_Internal(IntPtr @this, int index);

		// Token: 0x0600A02B RID: 41003
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetRealSize_Internal(IntPtr @this);

		// Token: 0x0600A02C RID: 41004
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetRealFontSize_Internal(IntPtr @this);

		// Token: 0x0600A02D RID: 41005
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern UITextOverflowType __GetOverflowType_Internal(IntPtr @this);

		// Token: 0x0600A02E RID: 41006
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMaxWidth_Internal(IntPtr @this);

		// Token: 0x0600A02F RID: 41007
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMaxHeight_Internal(IntPtr @this);

		// Token: 0x0600A030 RID: 41008
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetHyperlinks_Internal(IntPtr @this);

		// Token: 0x0600A031 RID: 41009
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetFontSpacePercentage_Internal(IntPtr @this);

		// Token: 0x0600A032 RID: 41010
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetFontSpaceFinal_Internal(IntPtr @this);

		// Token: 0x0600A033 RID: 41011
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetFontSpace_Internal(IntPtr @this);

		// Token: 0x0600A034 RID: 41012
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetFontOutlineSize_Internal(IntPtr @this);

		// Token: 0x0600A035 RID: 41013
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FColor __GetFontOutlineColor_Internal(IntPtr @this);

		// Token: 0x0600A036 RID: 41014
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetFontGlowSize_Internal(IntPtr @this);

		// Token: 0x0600A037 RID: 41015
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FColor __GetFontGlowColor_Internal(IntPtr @this);

		// Token: 0x0600A038 RID: 41016
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetFont_Internal(IntPtr @this);

		// Token: 0x0600A039 RID: 41017
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetDisplayCharLength_Internal(IntPtr @this);

		// Token: 0x0600A03A RID: 41018
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetAutoEllipsisSplitWord_Internal(IntPtr @this);

		// Token: 0x0600A03B RID: 41019
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetAutoEllipsis_Internal(IntPtr @this);

		// Token: 0x0600A03C RID: 41020
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetAlignCenter_Internal(IntPtr @this);

		// Token: 0x0600A03D RID: 41021
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetAdjustWidth_Internal(IntPtr @this);

		// Token: 0x0600A03E RID: 41022
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetAdjustHeight_Internal(IntPtr @this);

		// Token: 0x0600A03F RID: 41023
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Clear_Internal(IntPtr @this);

		// Token: 0x0600A040 RID: 41024
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddStringArgs_Internal(IntPtr @this, in FString Value);

		// Token: 0x0600A041 RID: 41025
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddIntArgs_Internal(IntPtr @this, int Value);

		// Token: 0x0600A042 RID: 41026
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddInt64Args_Internal(IntPtr @this, long Value);

		// Token: 0x0600A043 RID: 41027
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddFormatTableInfoNew_Internal(IntPtr @this, in FString Key);

		// Token: 0x0600A044 RID: 41028
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddFormatTableInfo_Internal(IntPtr @this, in FString ConfigTableName, int Key);

		// Token: 0x0600A045 RID: 41029
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddFloatArgs_Internal(IntPtr @this, float Value);

		// Token: 0x0600A046 RID: 41030 RVA: 0x000ED535 File Offset: 0x000EB735
		static UUIText()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIText");
		}

		// Token: 0x0600A047 RID: 41031 RVA: 0x000ED543 File Offset: 0x000EB743
		protected UUIText(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004468 RID: 17512
		public new const string __ObjectPath = "/Script/LGUI.UIText";

		// Token: 0x04004469 RID: 17513
		private static IntPtr _ClassPtr;

		// Token: 0x0400446A RID: 17514
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400446B RID: 17515
		internal static int __PropertyOffset_font;

		// Token: 0x0400446C RID: 17516
		internal static int __PropertyOffset_text;

		// Token: 0x0400446D RID: 17517
		internal static int __PropertyOffset_size;

		// Token: 0x0400446E RID: 17518
		internal static int __PropertyOffset_spacePercentage;

		// Token: 0x0400446F RID: 17519
		internal static int __PropertyOffset_space;

		// Token: 0x04004470 RID: 17520
		internal static int __PropertyOffset_outlineSize;

		// Token: 0x04004471 RID: 17521
		internal static int __PropertyOffset_outlineColor;

		// Token: 0x04004472 RID: 17522
		internal static int __PropertyOffset_glowSize;

		// Token: 0x04004473 RID: 17523
		internal static int __PropertyOffset_glowColor;

		// Token: 0x04004474 RID: 17524
		internal static int __PropertyOffset_hAlign;

		// Token: 0x04004475 RID: 17525
		internal static int __PropertyOffset_overflowType;

		// Token: 0x04004476 RID: 17526
		internal static int __PropertyOffset_verticalOverflowBestFitSwitch;

		// Token: 0x04004477 RID: 17527
		internal static int __PropertyOffset_maxWidth;

		// Token: 0x04004478 RID: 17528
		internal static int __PropertyOffset_maxHeight;

		// Token: 0x04004479 RID: 17529
		internal static int __PropertyOffset_bMaxWidthLimited;

		// Token: 0x0400447A RID: 17530
		internal static int __PropertyOffset_bMaxHeightLimited;

		// Token: 0x0400447B RID: 17531
		internal static int __PropertyOffset_adjustWidth;

		// Token: 0x0400447C RID: 17532
		internal static int __PropertyOffset_adjustHeight;

		// Token: 0x0400447D RID: 17533
		internal static int __PropertyOffset_NeedCustomerLimitWidth;

		// Token: 0x0400447E RID: 17534
		internal static int __PropertyOffset_CustomerLimitWidth;

		// Token: 0x0400447F RID: 17535
		internal static int __PropertyOffset_richText;

		// Token: 0x04004480 RID: 17536
		internal static int __PropertyOffset_bApplyAlphaOnRichText;

		// Token: 0x04004481 RID: 17537
		internal static int __PropertyOffset_bFilterAnoRichTag;

		// Token: 0x04004482 RID: 17538
		internal static int __PropertyOffset_bBestFit;

		// Token: 0x04004483 RID: 17539
		internal static int __PropertyOffset_bRichTextTextureBestFit;

		// Token: 0x04004484 RID: 17540
		internal static int __PropertyOffset_bAlignCenter;

		// Token: 0x04004485 RID: 17541
		internal static int __PropertyOffset_bIgnoreWordRules;

		// Token: 0x04004486 RID: 17542
		internal static int __PropertyOffset_bAutoEllipsis;

		// Token: 0x04004487 RID: 17543
		internal static int __PropertyOffset_bAutoEllipsisSplitWord;

		// Token: 0x04004488 RID: 17544
		internal static int __PropertyOffset_BestFitMinSize;

		// Token: 0x04004489 RID: 17545
		internal static int __PropertyOffset_bCalculateOutlineSize;

		// Token: 0x0400448A RID: 17546
		internal static int __PropertyOffset_hyperlinks;

		// Token: 0x0400448B RID: 17547
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _hyperlinks;

		// Token: 0x0400448C RID: 17548
		internal static int __PropertyOffset_bFilterHyperLinks;

		// Token: 0x0400448D RID: 17549
		internal static int __PropertyOffset_hyperLinksClickAreaRatio;

		// Token: 0x0400448E RID: 17550
		internal static int __PropertyOffset_bEnableHyperLinksHighlight;

		// Token: 0x0400448F RID: 17551
		internal static int __PropertyOffset_HyperLinksHoverColor;

		// Token: 0x04004490 RID: 17552
		internal static int __PropertyOffset_bUseGradientUV2;

		// Token: 0x04004491 RID: 17553
		internal static int __PropertyOffset_bOutlineAlphaIndependent;

		// Token: 0x04004492 RID: 17554
		internal static int __PropertyOffset_bOutlineUV3SetOriginTextUV;

		// Token: 0x04004493 RID: 17555
		internal static int __PropertyOffset_bUseUV1AsGlyphType;

		// Token: 0x04004494 RID: 17556
		internal static int __PropertyOffset_bGlowAlphaInherit;

		// Token: 0x04004495 RID: 17557
		internal static int __PropertyOffset_bGlowAlphaIndependent;

		// Token: 0x04004496 RID: 17558
		internal static int __PropertyOffset_OnHyperLinkClickCallBack;

		// Token: 0x04004497 RID: 17559
		[Nullable(2)]
		private FLGUITextClickDelegate _OnHyperLinkClickCallBack;

		// Token: 0x04004498 RID: 17560
		internal static int __PropertyOffset_bEnableTextRenderSystemV2;

		// Token: 0x04004499 RID: 17561
		internal static int __PropertyOffset_OnSelfLanguageChange;

		// Token: 0x0400449A RID: 17562
		[Nullable(2)]
		private FSelfLanguageChange _OnSelfLanguageChange;

		// Token: 0x0400449B RID: 17563
		internal static int __PropertyOffset_OnTextureAsyncLoaded;

		// Token: 0x0400449C RID: 17564
		[Nullable(2)]
		private FLGUITextAsyncLoadFinishedDelegate _OnTextureAsyncLoaded;

		// Token: 0x0400449D RID: 17565
		internal static int __PropertyOffset_TranslateId;

		// Token: 0x0400449E RID: 17566
		internal static int __PropertyOffset_bGameRichText;
	}
}
