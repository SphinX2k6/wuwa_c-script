using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021C9 RID: 8649
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIText")]
	[UnrealStructLayout(3136, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3136)]
	public class UUIText : UUIBatchGeometryRenderable, IUnrealUObject, IUnrealObject, ILGUITextAnimationTarget, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06020E58 RID: 134744 RVA: 0x003095A7 File Offset: 0x003077A7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIText._ClassPtr;
		}

		// Token: 0x06020E59 RID: 134745 RVA: 0x003095B3 File Offset: 0x003077B3
		int ILGUITextAnimationTarget.InterfaceOffset()
		{
			return UUIText.__InterfaceOffset_ILGUITextAnimationTarget;
		}

		// Token: 0x06020E5A RID: 134746 RVA: 0x003095BC File Offset: 0x003077BC
		public UUIText() : this(BuiltinUtils.AllocNativeUObject(UUIText.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020E5B RID: 134747 RVA: 0x003095E4 File Offset: 0x003077E4
		public UUIText(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIText.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008075 RID: 32885
		// (get) Token: 0x06020E5C RID: 134748 RVA: 0x00309617 File Offset: 0x00307817
		// (set) Token: 0x06020E5D RID: 134749 RVA: 0x0030962B File Offset: 0x0030782B
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

		// Token: 0x17008076 RID: 32886
		// (get) Token: 0x06020E5E RID: 134750 RVA: 0x00309640 File Offset: 0x00307840
		// (set) Token: 0x06020E5F RID: 134751 RVA: 0x00309654 File Offset: 0x00307854
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

		// Token: 0x17008077 RID: 32887
		// (get) Token: 0x06020E60 RID: 134752 RVA: 0x00309669 File Offset: 0x00307869
		// (set) Token: 0x06020E61 RID: 134753 RVA: 0x00309679 File Offset: 0x00307879
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

		// Token: 0x17008078 RID: 32888
		// (get) Token: 0x06020E62 RID: 134754 RVA: 0x0030968A File Offset: 0x0030788A
		// (set) Token: 0x06020E63 RID: 134755 RVA: 0x0030969E File Offset: 0x0030789E
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

		// Token: 0x17008079 RID: 32889
		// (get) Token: 0x06020E64 RID: 134756 RVA: 0x003096B3 File Offset: 0x003078B3
		// (set) Token: 0x06020E65 RID: 134757 RVA: 0x003096C7 File Offset: 0x003078C7
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

		// Token: 0x1700807A RID: 32890
		// (get) Token: 0x06020E66 RID: 134758 RVA: 0x003096DC File Offset: 0x003078DC
		// (set) Token: 0x06020E67 RID: 134759 RVA: 0x003096EC File Offset: 0x003078EC
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

		// Token: 0x1700807B RID: 32891
		// (get) Token: 0x06020E68 RID: 134760 RVA: 0x003096FD File Offset: 0x003078FD
		// (set) Token: 0x06020E69 RID: 134761 RVA: 0x00309711 File Offset: 0x00307911
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

		// Token: 0x1700807C RID: 32892
		// (get) Token: 0x06020E6A RID: 134762 RVA: 0x00309726 File Offset: 0x00307926
		// (set) Token: 0x06020E6B RID: 134763 RVA: 0x00309736 File Offset: 0x00307936
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

		// Token: 0x1700807D RID: 32893
		// (get) Token: 0x06020E6C RID: 134764 RVA: 0x00309747 File Offset: 0x00307947
		// (set) Token: 0x06020E6D RID: 134765 RVA: 0x0030975B File Offset: 0x0030795B
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

		// Token: 0x1700807E RID: 32894
		// (get) Token: 0x06020E6E RID: 134766 RVA: 0x00309770 File Offset: 0x00307970
		// (set) Token: 0x06020E6F RID: 134767 RVA: 0x00309780 File Offset: 0x00307980
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

		// Token: 0x1700807F RID: 32895
		// (get) Token: 0x06020E70 RID: 134768 RVA: 0x00309791 File Offset: 0x00307991
		// (set) Token: 0x06020E71 RID: 134769 RVA: 0x003097A1 File Offset: 0x003079A1
		public unsafe UITextParagraphVerticalAlign vAlign
		{
			get
			{
				return (UITextParagraphVerticalAlign)(*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_vAlign));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_vAlign) = (byte)value;
			}
		}

		// Token: 0x17008080 RID: 32896
		// (get) Token: 0x06020E72 RID: 134770 RVA: 0x003097B2 File Offset: 0x003079B2
		// (set) Token: 0x06020E73 RID: 134771 RVA: 0x003097C2 File Offset: 0x003079C2
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

		// Token: 0x17008081 RID: 32897
		// (get) Token: 0x06020E74 RID: 134772 RVA: 0x003097D3 File Offset: 0x003079D3
		// (set) Token: 0x06020E75 RID: 134773 RVA: 0x003097E3 File Offset: 0x003079E3
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

		// Token: 0x17008082 RID: 32898
		// (get) Token: 0x06020E76 RID: 134774 RVA: 0x003097F4 File Offset: 0x003079F4
		// (set) Token: 0x06020E77 RID: 134775 RVA: 0x00309804 File Offset: 0x00307A04
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

		// Token: 0x17008083 RID: 32899
		// (get) Token: 0x06020E78 RID: 134776 RVA: 0x00309815 File Offset: 0x00307A15
		// (set) Token: 0x06020E79 RID: 134777 RVA: 0x00309825 File Offset: 0x00307A25
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

		// Token: 0x17008084 RID: 32900
		// (get) Token: 0x06020E7A RID: 134778 RVA: 0x00309836 File Offset: 0x00307A36
		// (set) Token: 0x06020E7B RID: 134779 RVA: 0x00309846 File Offset: 0x00307A46
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

		// Token: 0x17008085 RID: 32901
		// (get) Token: 0x06020E7C RID: 134780 RVA: 0x00309857 File Offset: 0x00307A57
		// (set) Token: 0x06020E7D RID: 134781 RVA: 0x00309867 File Offset: 0x00307A67
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

		// Token: 0x17008086 RID: 32902
		// (get) Token: 0x06020E7E RID: 134782 RVA: 0x00309878 File Offset: 0x00307A78
		// (set) Token: 0x06020E7F RID: 134783 RVA: 0x00309888 File Offset: 0x00307A88
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

		// Token: 0x17008087 RID: 32903
		// (get) Token: 0x06020E80 RID: 134784 RVA: 0x00309899 File Offset: 0x00307A99
		// (set) Token: 0x06020E81 RID: 134785 RVA: 0x003098A9 File Offset: 0x00307AA9
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

		// Token: 0x17008088 RID: 32904
		// (get) Token: 0x06020E82 RID: 134786 RVA: 0x003098BA File Offset: 0x00307ABA
		// (set) Token: 0x06020E83 RID: 134787 RVA: 0x003098CA File Offset: 0x00307ACA
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

		// Token: 0x17008089 RID: 32905
		// (get) Token: 0x06020E84 RID: 134788 RVA: 0x003098DB File Offset: 0x00307ADB
		// (set) Token: 0x06020E85 RID: 134789 RVA: 0x003098EB File Offset: 0x00307AEB
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

		// Token: 0x1700808A RID: 32906
		// (get) Token: 0x06020E86 RID: 134790 RVA: 0x003098FC File Offset: 0x00307AFC
		// (set) Token: 0x06020E87 RID: 134791 RVA: 0x0030990C File Offset: 0x00307B0C
		public unsafe UITextFontStyle fontStyle
		{
			get
			{
				return (UITextFontStyle)(*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_fontStyle));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIText.__PropertyOffset_fontStyle) = (byte)value;
			}
		}

		// Token: 0x1700808B RID: 32907
		// (get) Token: 0x06020E88 RID: 134792 RVA: 0x0030991D File Offset: 0x00307B1D
		// (set) Token: 0x06020E89 RID: 134793 RVA: 0x0030992D File Offset: 0x00307B2D
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

		// Token: 0x1700808C RID: 32908
		// (get) Token: 0x06020E8A RID: 134794 RVA: 0x0030993E File Offset: 0x00307B3E
		// (set) Token: 0x06020E8B RID: 134795 RVA: 0x0030994E File Offset: 0x00307B4E
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

		// Token: 0x1700808D RID: 32909
		// (get) Token: 0x06020E8C RID: 134796 RVA: 0x0030995F File Offset: 0x00307B5F
		// (set) Token: 0x06020E8D RID: 134797 RVA: 0x0030996F File Offset: 0x00307B6F
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

		// Token: 0x1700808E RID: 32910
		// (get) Token: 0x06020E8E RID: 134798 RVA: 0x00309980 File Offset: 0x00307B80
		// (set) Token: 0x06020E8F RID: 134799 RVA: 0x00309990 File Offset: 0x00307B90
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

		// Token: 0x1700808F RID: 32911
		// (get) Token: 0x06020E90 RID: 134800 RVA: 0x003099A1 File Offset: 0x00307BA1
		// (set) Token: 0x06020E91 RID: 134801 RVA: 0x003099B1 File Offset: 0x00307BB1
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

		// Token: 0x17008090 RID: 32912
		// (get) Token: 0x06020E92 RID: 134802 RVA: 0x003099C2 File Offset: 0x00307BC2
		// (set) Token: 0x06020E93 RID: 134803 RVA: 0x003099D2 File Offset: 0x00307BD2
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

		// Token: 0x17008091 RID: 32913
		// (get) Token: 0x06020E94 RID: 134804 RVA: 0x003099E3 File Offset: 0x00307BE3
		// (set) Token: 0x06020E95 RID: 134805 RVA: 0x003099F3 File Offset: 0x00307BF3
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

		// Token: 0x17008092 RID: 32914
		// (get) Token: 0x06020E96 RID: 134806 RVA: 0x00309A04 File Offset: 0x00307C04
		// (set) Token: 0x06020E97 RID: 134807 RVA: 0x00309A14 File Offset: 0x00307C14
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

		// Token: 0x17008093 RID: 32915
		// (get) Token: 0x06020E98 RID: 134808 RVA: 0x00309A25 File Offset: 0x00307C25
		// (set) Token: 0x06020E99 RID: 134809 RVA: 0x00309A35 File Offset: 0x00307C35
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

		// Token: 0x17008094 RID: 32916
		// (get) Token: 0x06020E9A RID: 134810 RVA: 0x00309A46 File Offset: 0x00307C46
		// (set) Token: 0x06020E9B RID: 134811 RVA: 0x00309A56 File Offset: 0x00307C56
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

		// Token: 0x17008095 RID: 32917
		// (get) Token: 0x06020E9C RID: 134812 RVA: 0x00309A67 File Offset: 0x00307C67
		// (set) Token: 0x06020E9D RID: 134813 RVA: 0x00309A77 File Offset: 0x00307C77
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

		// Token: 0x17008096 RID: 32918
		// (get) Token: 0x06020E9E RID: 134814 RVA: 0x00309A88 File Offset: 0x00307C88
		// (set) Token: 0x06020E9F RID: 134815 RVA: 0x00309AC1 File Offset: 0x00307CC1
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

		// Token: 0x17008097 RID: 32919
		// (get) Token: 0x06020EA0 RID: 134816 RVA: 0x00309ACF File Offset: 0x00307CCF
		// (set) Token: 0x06020EA1 RID: 134817 RVA: 0x00309ADF File Offset: 0x00307CDF
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

		// Token: 0x17008098 RID: 32920
		// (get) Token: 0x06020EA2 RID: 134818 RVA: 0x00309AF0 File Offset: 0x00307CF0
		// (set) Token: 0x06020EA3 RID: 134819 RVA: 0x00309B00 File Offset: 0x00307D00
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

		// Token: 0x17008099 RID: 32921
		// (get) Token: 0x06020EA4 RID: 134820 RVA: 0x00309B11 File Offset: 0x00307D11
		// (set) Token: 0x06020EA5 RID: 134821 RVA: 0x00309B21 File Offset: 0x00307D21
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

		// Token: 0x1700809A RID: 32922
		// (get) Token: 0x06020EA6 RID: 134822 RVA: 0x00309B32 File Offset: 0x00307D32
		// (set) Token: 0x06020EA7 RID: 134823 RVA: 0x00309B46 File Offset: 0x00307D46
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

		// Token: 0x1700809B RID: 32923
		// (get) Token: 0x06020EA8 RID: 134824 RVA: 0x00309B5B File Offset: 0x00307D5B
		// (set) Token: 0x06020EA9 RID: 134825 RVA: 0x00309B6B File Offset: 0x00307D6B
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

		// Token: 0x1700809C RID: 32924
		// (get) Token: 0x06020EAA RID: 134826 RVA: 0x00309B7C File Offset: 0x00307D7C
		// (set) Token: 0x06020EAB RID: 134827 RVA: 0x00309B8C File Offset: 0x00307D8C
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

		// Token: 0x1700809D RID: 32925
		// (get) Token: 0x06020EAC RID: 134828 RVA: 0x00309B9D File Offset: 0x00307D9D
		// (set) Token: 0x06020EAD RID: 134829 RVA: 0x00309BAD File Offset: 0x00307DAD
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

		// Token: 0x1700809E RID: 32926
		// (get) Token: 0x06020EAE RID: 134830 RVA: 0x00309BBE File Offset: 0x00307DBE
		// (set) Token: 0x06020EAF RID: 134831 RVA: 0x00309BCE File Offset: 0x00307DCE
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

		// Token: 0x1700809F RID: 32927
		// (get) Token: 0x06020EB0 RID: 134832 RVA: 0x00309BDF File Offset: 0x00307DDF
		// (set) Token: 0x06020EB1 RID: 134833 RVA: 0x00309BEF File Offset: 0x00307DEF
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

		// Token: 0x170080A0 RID: 32928
		// (get) Token: 0x06020EB2 RID: 134834 RVA: 0x00309C00 File Offset: 0x00307E00
		// (set) Token: 0x06020EB3 RID: 134835 RVA: 0x00309C10 File Offset: 0x00307E10
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

		// Token: 0x170080A1 RID: 32929
		// (get) Token: 0x06020EB4 RID: 134836 RVA: 0x00309C24 File Offset: 0x00307E24
		// (set) Token: 0x06020EB5 RID: 134837 RVA: 0x00309C5D File Offset: 0x00307E5D
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

		// Token: 0x170080A2 RID: 32930
		// (get) Token: 0x06020EB6 RID: 134838 RVA: 0x00309C7E File Offset: 0x00307E7E
		// (set) Token: 0x06020EB7 RID: 134839 RVA: 0x00309C8E File Offset: 0x00307E8E
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

		// Token: 0x170080A3 RID: 32931
		// (get) Token: 0x06020EB8 RID: 134840 RVA: 0x00309C9F File Offset: 0x00307E9F
		// (set) Token: 0x06020EB9 RID: 134841 RVA: 0x00309CB3 File Offset: 0x00307EB3
		[Nullable(2)]
		public unsafe UUITextClickComponent ClickComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUITextClickComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UUIText.__PropertyOffset_ClickComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIText.__PropertyOffset_ClickComponent, value);
			}
		}

		// Token: 0x170080A4 RID: 32932
		// (get) Token: 0x06020EBA RID: 134842 RVA: 0x00309CC8 File Offset: 0x00307EC8
		// (set) Token: 0x06020EBB RID: 134843 RVA: 0x00309D01 File Offset: 0x00307F01
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

		// Token: 0x170080A5 RID: 32933
		// (get) Token: 0x06020EBC RID: 134844 RVA: 0x00309D24 File Offset: 0x00307F24
		// (set) Token: 0x06020EBD RID: 134845 RVA: 0x00309D5D File Offset: 0x00307F5D
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

		// Token: 0x170080A6 RID: 32934
		// (get) Token: 0x06020EBE RID: 134846 RVA: 0x00309D7E File Offset: 0x00307F7E
		// (set) Token: 0x06020EBF RID: 134847 RVA: 0x00309D8E File Offset: 0x00307F8E
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

		// Token: 0x170080A7 RID: 32935
		// (get) Token: 0x06020EC0 RID: 134848 RVA: 0x00309D9F File Offset: 0x00307F9F
		// (set) Token: 0x06020EC1 RID: 134849 RVA: 0x00309DAF File Offset: 0x00307FAF
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

		// Token: 0x06020EC2 RID: 134850 RVA: 0x00309DC0 File Offset: 0x00307FC0
		public unsafe void ShowTextNew(string Key)
		{
			FString fstring = FString.AllocTemp(Key);
			UUIText.__ShowTextNew_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06020EC3 RID: 134851 RVA: 0x00309DEC File Offset: 0x00307FEC
		public unsafe void ShowText(string ConfigTableName, int Key)
		{
			FString fstring = FString.AllocTemp(ConfigTableName);
			UUIText.__ShowText_Internal(base.NativePtr, fstring, Key);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06020EC4 RID: 134852 RVA: 0x00309E17 File Offset: 0x00308017
		[NullableContext(2)]
		public static void SetTsGameRichTextDelegate(in FTsGameRichTextDelegate Delegate)
		{
			FTsGameRichTextDelegate ftsGameRichTextDelegate = Delegate;
			UUIText.__SetTsGameRichTextDelegate_Internal((ftsGameRichTextDelegate != null) ? ftsGameRichTextDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06020EC5 RID: 134853 RVA: 0x00309E2D File Offset: 0x0030802D
		[NullableContext(2)]
		public static void SetTextTranslateDelegate(in FLGUITextTranslateDelegate Delegate)
		{
			FLGUITextTranslateDelegate flguitextTranslateDelegate = Delegate;
			UUIText.__SetTextTranslateDelegate_Internal((flguitextTranslateDelegate != null) ? flguitextTranslateDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06020EC6 RID: 134854 RVA: 0x00309E44 File Offset: 0x00308044
		public unsafe void SetText(string newText, bool DisableTranslate = true)
		{
			FString fstring = FString.AllocTemp(newText);
			UUIText.__SetText_Internal(base.NativePtr, fstring, DisableTranslate);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06020EC7 RID: 134855 RVA: 0x00309E6F File Offset: 0x0030806F
		public void SetRichText(bool newRichText)
		{
			UUIText.__SetRichText_Internal(base.NativePtr, newRichText);
		}

		// Token: 0x06020EC8 RID: 134856 RVA: 0x00309E7D File Offset: 0x0030807D
		public void SetParagraphVerticalAlignment(UITextParagraphVerticalAlign newVAlign)
		{
			UUIText.__SetParagraphVerticalAlignment_Internal(base.NativePtr, newVAlign);
		}

		// Token: 0x06020EC9 RID: 134857 RVA: 0x00309E8B File Offset: 0x0030808B
		public void SetParagraphHorizontalAlignment(UITextParagraphHorizontalAlign newHAlign)
		{
			UUIText.__SetParagraphHorizontalAlignment_Internal(base.NativePtr, newHAlign);
		}

		// Token: 0x06020ECA RID: 134858 RVA: 0x00309E99 File Offset: 0x00308099
		public void SetOverflowType(UITextOverflowType newOverflowType)
		{
			UUIText.__SetOverflowType_Internal(base.NativePtr, newOverflowType);
		}

		// Token: 0x06020ECB RID: 134859 RVA: 0x00309EA7 File Offset: 0x003080A7
		public void SetMaxWidth(int NewMaxWidth)
		{
			UUIText.__SetMaxWidth_Internal(base.NativePtr, NewMaxWidth);
		}

		// Token: 0x06020ECC RID: 134860 RVA: 0x00309EB5 File Offset: 0x003080B5
		public void SetMaxHeight(int NewMaxHeight)
		{
			UUIText.__SetMaxHeight_Internal(base.NativePtr, NewMaxHeight);
		}

		// Token: 0x06020ECD RID: 134861 RVA: 0x00309EC3 File Offset: 0x003080C3
		[NullableContext(2)]
		public static void SetLocalTextNewDelegate(in FLocalTextNewDelegate Delegate)
		{
			FLocalTextNewDelegate flocalTextNewDelegate = Delegate;
			UUIText.__SetLocalTextNewDelegate_Internal((flocalTextNewDelegate != null) ? flocalTextNewDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06020ECE RID: 134862 RVA: 0x00309ED9 File Offset: 0x003080D9
		[NullableContext(2)]
		public static void SetLocalTextDelegate(in FLocalTextDelegate Delegate)
		{
			FLocalTextDelegate flocalTextDelegate = Delegate;
			UUIText.__SetLocalTextDelegate_Internal((flocalTextDelegate != null) ? flocalTextDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06020ECF RID: 134863 RVA: 0x00309EEF File Offset: 0x003080EF
		public void SetHyperLinksHoverSpiteActive(bool bActive)
		{
			UUIText.__SetHyperLinksHoverSpiteActive_Internal(base.NativePtr, bActive);
		}

		// Token: 0x06020ED0 RID: 134864 RVA: 0x00309EFD File Offset: 0x003080FD
		[NullableContext(2)]
		public static void SetGmReplaceFontDelegate(in FLGUITextGmReplaceFontDelegate Delegate)
		{
			FLGUITextGmReplaceFontDelegate flguitextGmReplaceFontDelegate = Delegate;
			UUIText.__SetGmReplaceFontDelegate_Internal((flguitextGmReplaceFontDelegate != null) ? flguitextGmReplaceFontDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06020ED1 RID: 134865 RVA: 0x00309F13 File Offset: 0x00308113
		public void SetGameRichText(bool value)
		{
			UUIText.__SetGameRichText_Internal(base.NativePtr, value);
		}

		// Token: 0x06020ED2 RID: 134866 RVA: 0x00309F21 File Offset: 0x00308121
		public void SetFontStyle(UITextFontStyle newFontStyle)
		{
			UUIText.__SetFontStyle_Internal(base.NativePtr, newFontStyle);
		}

		// Token: 0x06020ED3 RID: 134867 RVA: 0x00309F2F File Offset: 0x0030812F
		public void SetFontSpacePercentage(FVector2D newSpace)
		{
			UUIText.__SetFontSpacePercentage_Internal(base.NativePtr, newSpace);
		}

		// Token: 0x06020ED4 RID: 134868 RVA: 0x00309F3D File Offset: 0x0030813D
		public void SetFontSpace(FVector2D newSpace)
		{
			UUIText.__SetFontSpace_Internal(base.NativePtr, newSpace);
		}

		// Token: 0x06020ED5 RID: 134869 RVA: 0x00309F4B File Offset: 0x0030814B
		public void SetFontSize(float newSize)
		{
			UUIText.__SetFontSize_Internal(base.NativePtr, newSize);
		}

		// Token: 0x06020ED6 RID: 134870 RVA: 0x00309F59 File Offset: 0x00308159
		public void SetFontOutlineColor(FColor NewOutlineColor)
		{
			UUIText.__SetFontOutlineColor_Internal(base.NativePtr, NewOutlineColor);
		}

		// Token: 0x06020ED7 RID: 134871 RVA: 0x00309F67 File Offset: 0x00308167
		[NullableContext(2)]
		public void SetFont(ULGUIFontData_BaseObject newFont)
		{
			UUIText.__SetFont_Internal(base.NativePtr, (newFont != null) ? newFont.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06020ED8 RID: 134872 RVA: 0x00309F84 File Offset: 0x00308184
		public void SetFilterHyperLinks(bool bNewFilterHyperLinks)
		{
			UUIText.__SetFilterHyperLinks_Internal(base.NativePtr, bNewFilterHyperLinks);
		}

		// Token: 0x06020ED9 RID: 134873 RVA: 0x00309F92 File Offset: 0x00308192
		public void SetFilterAnoRichTag(bool bFilter)
		{
			UUIText.__SetFilterAnoRichTag_Internal(base.NativePtr, bFilter);
		}

		// Token: 0x06020EDA RID: 134874 RVA: 0x00309FA0 File Offset: 0x003081A0
		public void SetEnableHyperLinksHighlight(bool bEnabled)
		{
			UUIText.__SetEnableHyperLinksHighlight_Internal(base.NativePtr, bEnabled);
		}

		// Token: 0x06020EDB RID: 134875 RVA: 0x00309FAE File Offset: 0x003081AE
		public void SetAdjustWidth(bool newAdjustWidth)
		{
			UUIText.__SetAdjustWidth_Internal(base.NativePtr, newAdjustWidth);
		}

		// Token: 0x06020EDC RID: 134876 RVA: 0x00309FBC File Offset: 0x003081BC
		public void SetAdjustHeight(bool newAdjustHeight)
		{
			UUIText.__SetAdjustHeight_Internal(base.NativePtr, newAdjustHeight);
		}

		// Token: 0x06020EDD RID: 134877
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void OnTsLanguageChange();

		// Token: 0x06020EDE RID: 134878 RVA: 0x00309FCA File Offset: 0x003081CA
		public void OnTextTextureLoaded([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FDynamicAtlasSlotManagedHandle> ManagedHandle)
		{
			UUIText.__OnTextTextureLoaded_Internal(base.NativePtr, (ManagedHandle ?? new TArray<FDynamicAtlasSlotManagedHandle>()).NativePtr);
		}

		// Token: 0x06020EDF RID: 134879 RVA: 0x00309FE7 File Offset: 0x003081E7
		public bool IsFilterHyperLinks()
		{
			return UUIText.__IsFilterHyperLinks_Internal(base.NativePtr);
		}

		// Token: 0x06020EE0 RID: 134880 RVA: 0x00309FF4 File Offset: 0x003081F4
		public bool IsFilterAnoRichTag()
		{
			return UUIText.__IsFilterAnoRichTag_Internal(base.NativePtr);
		}

		// Token: 0x06020EE1 RID: 134881 RVA: 0x0030A001 File Offset: 0x00308201
		public bool IsEnableHyperLinksHighlight()
		{
			return UUIText.__IsEnableHyperLinksHighlight_Internal(base.NativePtr);
		}

		// Token: 0x06020EE2 RID: 134882 RVA: 0x0030A00E File Offset: 0x0030820E
		public FVector2D GetTextRenderSize()
		{
			return UUIText.__GetTextRenderSize_Internal(base.NativePtr);
		}

		// Token: 0x06020EE3 RID: 134883 RVA: 0x0030A01B File Offset: 0x0030821B
		[NullableContext(2)]
		public void GetTextLineNumArray(ref TArray<int> OutArray)
		{
			UUIText.__GetTextLineNumArray_Internal(base.NativePtr, (OutArray ?? new TArray<int>()).NativePtr);
		}

		// Token: 0x06020EE4 RID: 134884 RVA: 0x0030A038 File Offset: 0x00308238
		public string GetText()
		{
			return FString.ToStringAndDeleteNativePtr(UUIText.__GetText_Internal(base.NativePtr));
		}

		// Token: 0x06020EE5 RID: 134885 RVA: 0x0030A04A File Offset: 0x0030824A
		public float GetSize()
		{
			return UUIText.__GetSize_Internal(base.NativePtr);
		}

		// Token: 0x06020EE6 RID: 134886 RVA: 0x0030A057 File Offset: 0x00308257
		public bool GetRichText()
		{
			return UUIText.__GetRichText_Internal(base.NativePtr);
		}

		// Token: 0x06020EE7 RID: 134887 RVA: 0x0030A064 File Offset: 0x00308264
		public int GetRenderLineNum()
		{
			return UUIText.__GetRenderLineNum_Internal(base.NativePtr);
		}

		// Token: 0x06020EE8 RID: 134888 RVA: 0x0030A071 File Offset: 0x00308271
		public float GetRenderLineHeight(int LineIndex)
		{
			return UUIText.__GetRenderLineHeight_Internal(base.NativePtr, LineIndex);
		}

		// Token: 0x06020EE9 RID: 134889 RVA: 0x0030A07F File Offset: 0x0030827F
		public int GetRenderLineCharNum(int index)
		{
			return UUIText.__GetRenderLineCharNum_Internal(base.NativePtr, index);
		}

		// Token: 0x06020EEA RID: 134890 RVA: 0x0030A08D File Offset: 0x0030828D
		public FVector2D GetRealSize()
		{
			return UUIText.__GetRealSize_Internal(base.NativePtr);
		}

		// Token: 0x06020EEB RID: 134891 RVA: 0x0030A09A File Offset: 0x0030829A
		public int GetRealFontSize()
		{
			return UUIText.__GetRealFontSize_Internal(base.NativePtr);
		}

		// Token: 0x06020EEC RID: 134892 RVA: 0x0030A0A7 File Offset: 0x003082A7
		public UITextOverflowType GetOverflowType()
		{
			return UUIText.__GetOverflowType_Internal(base.NativePtr);
		}

		// Token: 0x06020EED RID: 134893 RVA: 0x0030A0B4 File Offset: 0x003082B4
		public int GetMaxWidth()
		{
			return UUIText.__GetMaxWidth_Internal(base.NativePtr);
		}

		// Token: 0x06020EEE RID: 134894 RVA: 0x0030A0C1 File Offset: 0x003082C1
		public int GetMaxHeight()
		{
			return UUIText.__GetMaxHeight_Internal(base.NativePtr);
		}

		// Token: 0x06020EEF RID: 134895 RVA: 0x0030A0CE File Offset: 0x003082CE
		public TArray<string> GetHyperlinks()
		{
			return new TArray<string>(UUIText.__GetHyperlinks_Internal(base.NativePtr), null);
		}

		// Token: 0x06020EF0 RID: 134896 RVA: 0x0030A0E1 File Offset: 0x003082E1
		public UITextFontStyle GetFontStyle()
		{
			return UUIText.__GetFontStyle_Internal(base.NativePtr);
		}

		// Token: 0x06020EF1 RID: 134897 RVA: 0x0030A0EE File Offset: 0x003082EE
		public FVector2D GetFontSpacePercentage()
		{
			return UUIText.__GetFontSpacePercentage_Internal(base.NativePtr);
		}

		// Token: 0x06020EF2 RID: 134898 RVA: 0x0030A0FB File Offset: 0x003082FB
		public FVector2D GetFontSpaceFinal()
		{
			return UUIText.__GetFontSpaceFinal_Internal(base.NativePtr);
		}

		// Token: 0x06020EF3 RID: 134899 RVA: 0x0030A108 File Offset: 0x00308308
		public FVector2D GetFontSpace()
		{
			return UUIText.__GetFontSpace_Internal(base.NativePtr);
		}

		// Token: 0x06020EF4 RID: 134900 RVA: 0x0030A115 File Offset: 0x00308315
		public int GetFontOutlineSize()
		{
			return UUIText.__GetFontOutlineSize_Internal(base.NativePtr);
		}

		// Token: 0x06020EF5 RID: 134901 RVA: 0x0030A122 File Offset: 0x00308322
		public FColor GetFontOutlineColor()
		{
			return UUIText.__GetFontOutlineColor_Internal(base.NativePtr);
		}

		// Token: 0x06020EF6 RID: 134902 RVA: 0x0030A12F File Offset: 0x0030832F
		public int GetFontGlowSize()
		{
			return UUIText.__GetFontGlowSize_Internal(base.NativePtr);
		}

		// Token: 0x06020EF7 RID: 134903 RVA: 0x0030A13C File Offset: 0x0030833C
		public FColor GetFontGlowColor()
		{
			return UUIText.__GetFontGlowColor_Internal(base.NativePtr);
		}

		// Token: 0x06020EF8 RID: 134904 RVA: 0x0030A149 File Offset: 0x00308349
		[NullableContext(2)]
		public ULGUIFontData_BaseObject GetFont()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIFontData_BaseObject>(UUIText.__GetFont_Internal(base.NativePtr));
		}

		// Token: 0x06020EF9 RID: 134905 RVA: 0x0030A15B File Offset: 0x0030835B
		public int GetDisplayCharLength()
		{
			return UUIText.__GetDisplayCharLength_Internal(base.NativePtr);
		}

		// Token: 0x06020EFA RID: 134906 RVA: 0x0030A168 File Offset: 0x00308368
		public bool GetAutoEllipsisSplitWord()
		{
			return UUIText.__GetAutoEllipsisSplitWord_Internal(base.NativePtr);
		}

		// Token: 0x06020EFB RID: 134907 RVA: 0x0030A175 File Offset: 0x00308375
		public bool GetAutoEllipsis()
		{
			return UUIText.__GetAutoEllipsis_Internal(base.NativePtr);
		}

		// Token: 0x06020EFC RID: 134908 RVA: 0x0030A182 File Offset: 0x00308382
		public bool GetAlignCenter()
		{
			return UUIText.__GetAlignCenter_Internal(base.NativePtr);
		}

		// Token: 0x06020EFD RID: 134909 RVA: 0x0030A18F File Offset: 0x0030838F
		public bool GetAdjustWidth()
		{
			return UUIText.__GetAdjustWidth_Internal(base.NativePtr);
		}

		// Token: 0x06020EFE RID: 134910 RVA: 0x0030A19C File Offset: 0x0030839C
		public bool GetAdjustHeight()
		{
			return UUIText.__GetAdjustHeight_Internal(base.NativePtr);
		}

		// Token: 0x06020EFF RID: 134911 RVA: 0x0030A1A9 File Offset: 0x003083A9
		public void Clear()
		{
			UUIText.__Clear_Internal(base.NativePtr);
		}

		// Token: 0x06020F00 RID: 134912 RVA: 0x0030A1B8 File Offset: 0x003083B8
		public unsafe void AddStringArgs(string Value)
		{
			FString fstring = FString.AllocTemp(Value);
			UUIText.__AddStringArgs_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06020F01 RID: 134913 RVA: 0x0030A1E2 File Offset: 0x003083E2
		public void AddIntArgs(int Value)
		{
			UUIText.__AddIntArgs_Internal(base.NativePtr, Value);
		}

		// Token: 0x06020F02 RID: 134914 RVA: 0x0030A1F0 File Offset: 0x003083F0
		public void AddInt64Args(long Value)
		{
			UUIText.__AddInt64Args_Internal(base.NativePtr, Value);
		}

		// Token: 0x06020F03 RID: 134915 RVA: 0x0030A200 File Offset: 0x00308400
		public unsafe void AddFormatTableInfoNew(string Key)
		{
			FString fstring = FString.AllocTemp(Key);
			UUIText.__AddFormatTableInfoNew_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06020F04 RID: 134916 RVA: 0x0030A22C File Offset: 0x0030842C
		public unsafe void AddFormatTableInfo(string ConfigTableName, int Key)
		{
			FString fstring = FString.AllocTemp(ConfigTableName);
			UUIText.__AddFormatTableInfo_Internal(base.NativePtr, fstring, Key);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06020F05 RID: 134917 RVA: 0x0030A257 File Offset: 0x00308457
		public void AddFloatArgs(float Value)
		{
			UUIText.__AddFloatArgs_Internal(base.NativePtr, Value);
		}

		// Token: 0x06020F06 RID: 134918
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ShowTextNew_Internal(IntPtr @this, in FString Key);

		// Token: 0x06020F07 RID: 134919
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ShowText_Internal(IntPtr @this, in FString ConfigTableName, int Key);

		// Token: 0x06020F08 RID: 134920
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTsGameRichTextDelegate_Internal(IntPtr Delegate);

		// Token: 0x06020F09 RID: 134921
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTextTranslateDelegate_Internal(IntPtr Delegate);

		// Token: 0x06020F0A RID: 134922
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetText_Internal(IntPtr @this, in FString newText, bool DisableTranslate);

		// Token: 0x06020F0B RID: 134923
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRichText_Internal(IntPtr @this, bool newRichText);

		// Token: 0x06020F0C RID: 134924
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetParagraphVerticalAlignment_Internal(IntPtr @this, UITextParagraphVerticalAlign newVAlign);

		// Token: 0x06020F0D RID: 134925
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetParagraphHorizontalAlignment_Internal(IntPtr @this, UITextParagraphHorizontalAlign newHAlign);

		// Token: 0x06020F0E RID: 134926
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOverflowType_Internal(IntPtr @this, UITextOverflowType newOverflowType);

		// Token: 0x06020F0F RID: 134927
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaxWidth_Internal(IntPtr @this, int NewMaxWidth);

		// Token: 0x06020F10 RID: 134928
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaxHeight_Internal(IntPtr @this, int NewMaxHeight);

		// Token: 0x06020F11 RID: 134929
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLocalTextNewDelegate_Internal(IntPtr Delegate);

		// Token: 0x06020F12 RID: 134930
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLocalTextDelegate_Internal(IntPtr Delegate);

		// Token: 0x06020F13 RID: 134931
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHyperLinksHoverSpiteActive_Internal(IntPtr @this, bool bActive);

		// Token: 0x06020F14 RID: 134932
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGmReplaceFontDelegate_Internal(IntPtr Delegate);

		// Token: 0x06020F15 RID: 134933
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGameRichText_Internal(IntPtr @this, bool value);

		// Token: 0x06020F16 RID: 134934
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFontStyle_Internal(IntPtr @this, UITextFontStyle newFontStyle);

		// Token: 0x06020F17 RID: 134935
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFontSpacePercentage_Internal(IntPtr @this, FVector2D newSpace);

		// Token: 0x06020F18 RID: 134936
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFontSpace_Internal(IntPtr @this, FVector2D newSpace);

		// Token: 0x06020F19 RID: 134937
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFontSize_Internal(IntPtr @this, float newSize);

		// Token: 0x06020F1A RID: 134938
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFontOutlineColor_Internal(IntPtr @this, FColor NewOutlineColor);

		// Token: 0x06020F1B RID: 134939
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFont_Internal(IntPtr @this, IntPtr newFont);

		// Token: 0x06020F1C RID: 134940
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFilterHyperLinks_Internal(IntPtr @this, bool bNewFilterHyperLinks);

		// Token: 0x06020F1D RID: 134941
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFilterAnoRichTag_Internal(IntPtr @this, bool bFilter);

		// Token: 0x06020F1E RID: 134942
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnableHyperLinksHighlight_Internal(IntPtr @this, bool bEnabled);

		// Token: 0x06020F1F RID: 134943
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAdjustWidth_Internal(IntPtr @this, bool newAdjustWidth);

		// Token: 0x06020F20 RID: 134944
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAdjustHeight_Internal(IntPtr @this, bool newAdjustHeight);

		// Token: 0x06020F21 RID: 134945
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnTextTextureLoaded_Internal(IntPtr @this, IntPtr ManagedHandle);

		// Token: 0x06020F22 RID: 134946
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsFilterHyperLinks_Internal(IntPtr @this);

		// Token: 0x06020F23 RID: 134947
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsFilterAnoRichTag_Internal(IntPtr @this);

		// Token: 0x06020F24 RID: 134948
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsEnableHyperLinksHighlight_Internal(IntPtr @this);

		// Token: 0x06020F25 RID: 134949
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetTextRenderSize_Internal(IntPtr @this);

		// Token: 0x06020F26 RID: 134950
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetTextLineNumArray_Internal(IntPtr @this, IntPtr OutArray);

		// Token: 0x06020F27 RID: 134951
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetText_Internal(IntPtr @this);

		// Token: 0x06020F28 RID: 134952
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetSize_Internal(IntPtr @this);

		// Token: 0x06020F29 RID: 134953
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetRichText_Internal(IntPtr @this);

		// Token: 0x06020F2A RID: 134954
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetRenderLineNum_Internal(IntPtr @this);

		// Token: 0x06020F2B RID: 134955
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRenderLineHeight_Internal(IntPtr @this, int LineIndex);

		// Token: 0x06020F2C RID: 134956
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetRenderLineCharNum_Internal(IntPtr @this, int index);

		// Token: 0x06020F2D RID: 134957
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetRealSize_Internal(IntPtr @this);

		// Token: 0x06020F2E RID: 134958
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetRealFontSize_Internal(IntPtr @this);

		// Token: 0x06020F2F RID: 134959
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern UITextOverflowType __GetOverflowType_Internal(IntPtr @this);

		// Token: 0x06020F30 RID: 134960
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMaxWidth_Internal(IntPtr @this);

		// Token: 0x06020F31 RID: 134961
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMaxHeight_Internal(IntPtr @this);

		// Token: 0x06020F32 RID: 134962
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetHyperlinks_Internal(IntPtr @this);

		// Token: 0x06020F33 RID: 134963
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern UITextFontStyle __GetFontStyle_Internal(IntPtr @this);

		// Token: 0x06020F34 RID: 134964
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetFontSpacePercentage_Internal(IntPtr @this);

		// Token: 0x06020F35 RID: 134965
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetFontSpaceFinal_Internal(IntPtr @this);

		// Token: 0x06020F36 RID: 134966
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetFontSpace_Internal(IntPtr @this);

		// Token: 0x06020F37 RID: 134967
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetFontOutlineSize_Internal(IntPtr @this);

		// Token: 0x06020F38 RID: 134968
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FColor __GetFontOutlineColor_Internal(IntPtr @this);

		// Token: 0x06020F39 RID: 134969
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetFontGlowSize_Internal(IntPtr @this);

		// Token: 0x06020F3A RID: 134970
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FColor __GetFontGlowColor_Internal(IntPtr @this);

		// Token: 0x06020F3B RID: 134971
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetFont_Internal(IntPtr @this);

		// Token: 0x06020F3C RID: 134972
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetDisplayCharLength_Internal(IntPtr @this);

		// Token: 0x06020F3D RID: 134973
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetAutoEllipsisSplitWord_Internal(IntPtr @this);

		// Token: 0x06020F3E RID: 134974
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetAutoEllipsis_Internal(IntPtr @this);

		// Token: 0x06020F3F RID: 134975
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetAlignCenter_Internal(IntPtr @this);

		// Token: 0x06020F40 RID: 134976
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetAdjustWidth_Internal(IntPtr @this);

		// Token: 0x06020F41 RID: 134977
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetAdjustHeight_Internal(IntPtr @this);

		// Token: 0x06020F42 RID: 134978
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Clear_Internal(IntPtr @this);

		// Token: 0x06020F43 RID: 134979
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddStringArgs_Internal(IntPtr @this, in FString Value);

		// Token: 0x06020F44 RID: 134980
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddIntArgs_Internal(IntPtr @this, int Value);

		// Token: 0x06020F45 RID: 134981
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddInt64Args_Internal(IntPtr @this, long Value);

		// Token: 0x06020F46 RID: 134982
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddFormatTableInfoNew_Internal(IntPtr @this, in FString Key);

		// Token: 0x06020F47 RID: 134983
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddFormatTableInfo_Internal(IntPtr @this, in FString ConfigTableName, int Key);

		// Token: 0x06020F48 RID: 134984
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddFloatArgs_Internal(IntPtr @this, float Value);

		// Token: 0x06020F49 RID: 134985 RVA: 0x0030A265 File Offset: 0x00308465
		static UUIText()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIText");
		}

		// Token: 0x06020F4A RID: 134986 RVA: 0x0030A273 File Offset: 0x00308473
		protected UUIText(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401192D RID: 71981
		internal static int __InterfaceOffset_ILGUITextAnimationTarget;

		// Token: 0x0401192E RID: 71982
		public new const string __ObjectPath = "/Script/LGUI.UIText";

		// Token: 0x0401192F RID: 71983
		private static IntPtr _ClassPtr;

		// Token: 0x04011930 RID: 71984
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011931 RID: 71985
		internal static int __PropertyOffset_font;

		// Token: 0x04011932 RID: 71986
		internal static int __PropertyOffset_text;

		// Token: 0x04011933 RID: 71987
		internal static int __PropertyOffset_size;

		// Token: 0x04011934 RID: 71988
		internal static int __PropertyOffset_spacePercentage;

		// Token: 0x04011935 RID: 71989
		internal static int __PropertyOffset_space;

		// Token: 0x04011936 RID: 71990
		internal static int __PropertyOffset_outlineSize;

		// Token: 0x04011937 RID: 71991
		internal static int __PropertyOffset_outlineColor;

		// Token: 0x04011938 RID: 71992
		internal static int __PropertyOffset_glowSize;

		// Token: 0x04011939 RID: 71993
		internal static int __PropertyOffset_glowColor;

		// Token: 0x0401193A RID: 71994
		internal static int __PropertyOffset_hAlign;

		// Token: 0x0401193B RID: 71995
		internal static int __PropertyOffset_vAlign;

		// Token: 0x0401193C RID: 71996
		internal static int __PropertyOffset_overflowType;

		// Token: 0x0401193D RID: 71997
		internal static int __PropertyOffset_verticalOverflowBestFitSwitch;

		// Token: 0x0401193E RID: 71998
		internal static int __PropertyOffset_maxWidth;

		// Token: 0x0401193F RID: 71999
		internal static int __PropertyOffset_maxHeight;

		// Token: 0x04011940 RID: 72000
		internal static int __PropertyOffset_bMaxWidthLimited;

		// Token: 0x04011941 RID: 72001
		internal static int __PropertyOffset_bMaxHeightLimited;

		// Token: 0x04011942 RID: 72002
		internal static int __PropertyOffset_adjustWidth;

		// Token: 0x04011943 RID: 72003
		internal static int __PropertyOffset_adjustHeight;

		// Token: 0x04011944 RID: 72004
		internal static int __PropertyOffset_NeedCustomerLimitWidth;

		// Token: 0x04011945 RID: 72005
		internal static int __PropertyOffset_CustomerLimitWidth;

		// Token: 0x04011946 RID: 72006
		internal static int __PropertyOffset_fontStyle;

		// Token: 0x04011947 RID: 72007
		internal static int __PropertyOffset_richText;

		// Token: 0x04011948 RID: 72008
		internal static int __PropertyOffset_bApplyAlphaOnRichText;

		// Token: 0x04011949 RID: 72009
		internal static int __PropertyOffset_bFilterAnoRichTag;

		// Token: 0x0401194A RID: 72010
		internal static int __PropertyOffset_bBestFit;

		// Token: 0x0401194B RID: 72011
		internal static int __PropertyOffset_bRichTextTextureBestFit;

		// Token: 0x0401194C RID: 72012
		internal static int __PropertyOffset_bAlignCenter;

		// Token: 0x0401194D RID: 72013
		internal static int __PropertyOffset_bIgnoreWordRules;

		// Token: 0x0401194E RID: 72014
		internal static int __PropertyOffset_bAutoEllipsis;

		// Token: 0x0401194F RID: 72015
		internal static int __PropertyOffset_bAutoEllipsisSplitWord;

		// Token: 0x04011950 RID: 72016
		internal static int __PropertyOffset_BestFitMinSize;

		// Token: 0x04011951 RID: 72017
		internal static int __PropertyOffset_bCalculateOutlineSize;

		// Token: 0x04011952 RID: 72018
		internal static int __PropertyOffset_hyperlinks;

		// Token: 0x04011953 RID: 72019
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _hyperlinks;

		// Token: 0x04011954 RID: 72020
		internal static int __PropertyOffset_bFilterHyperLinks;

		// Token: 0x04011955 RID: 72021
		internal static int __PropertyOffset_hyperLinksClickAreaRatio;

		// Token: 0x04011956 RID: 72022
		internal static int __PropertyOffset_bEnableHyperLinksHighlight;

		// Token: 0x04011957 RID: 72023
		internal static int __PropertyOffset_HyperLinksHoverColor;

		// Token: 0x04011958 RID: 72024
		internal static int __PropertyOffset_bUseGradientUV2;

		// Token: 0x04011959 RID: 72025
		internal static int __PropertyOffset_bOutlineAlphaIndependent;

		// Token: 0x0401195A RID: 72026
		internal static int __PropertyOffset_bOutlineUV3SetOriginTextUV;

		// Token: 0x0401195B RID: 72027
		internal static int __PropertyOffset_bUseUV1AsGlyphType;

		// Token: 0x0401195C RID: 72028
		internal static int __PropertyOffset_bGlowAlphaInherit;

		// Token: 0x0401195D RID: 72029
		internal static int __PropertyOffset_bGlowAlphaIndependent;

		// Token: 0x0401195E RID: 72030
		internal static int __PropertyOffset_OnHyperLinkClickCallBack;

		// Token: 0x0401195F RID: 72031
		[Nullable(2)]
		private FLGUITextClickDelegate _OnHyperLinkClickCallBack;

		// Token: 0x04011960 RID: 72032
		internal static int __PropertyOffset_bEnableTextRenderSystemV2;

		// Token: 0x04011961 RID: 72033
		internal static int __PropertyOffset_ClickComponent;

		// Token: 0x04011962 RID: 72034
		internal static int __PropertyOffset_OnSelfLanguageChange;

		// Token: 0x04011963 RID: 72035
		[Nullable(2)]
		private FSelfLanguageChange _OnSelfLanguageChange;

		// Token: 0x04011964 RID: 72036
		internal static int __PropertyOffset_OnTextureAsyncLoaded;

		// Token: 0x04011965 RID: 72037
		[Nullable(2)]
		private FLGUITextAsyncLoadFinishedDelegate _OnTextureAsyncLoaded;

		// Token: 0x04011966 RID: 72038
		internal static int __PropertyOffset_TranslateId;

		// Token: 0x04011967 RID: 72039
		internal static int __PropertyOffset_bGameRichText;
	}
}
