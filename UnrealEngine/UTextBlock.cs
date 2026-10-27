using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029E1 RID: 10721
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.TextBlock")]
	[UnrealStructLayout(1264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1264)]
	public class UTextBlock : UTextLayoutWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027B3D RID: 162621 RVA: 0x003C880F File Offset: 0x003C6A0F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTextBlock._ClassPtr;
		}

		// Token: 0x06027B3E RID: 162622 RVA: 0x003C881C File Offset: 0x003C6A1C
		public UTextBlock() : this(BuiltinUtils.AllocNativeUObject(UTextBlock.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027B3F RID: 162623 RVA: 0x003C8844 File Offset: 0x003C6A44
		public UTextBlock(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTextBlock.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700981B RID: 38939
		// (get) Token: 0x06027B40 RID: 162624 RVA: 0x003C8878 File Offset: 0x003C6A78
		// (set) Token: 0x06027B41 RID: 162625 RVA: 0x003C88B1 File Offset: 0x003C6AB1
		public unsafe FText Text
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._Text) == null)
				{
					result = (this._Text = new FText(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_Text, this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)UTextBlock.__PropertyOffset_Text)), value.NativePtr, 1);
			}
		}

		// Token: 0x1700981C RID: 38940
		// (get) Token: 0x06027B42 RID: 162626 RVA: 0x003C88CC File Offset: 0x003C6ACC
		// (set) Token: 0x06027B43 RID: 162627 RVA: 0x003C8905 File Offset: 0x003C6B05
		public FGetText TextDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FGetText result;
				if ((result = this._TextDelegate) == null)
				{
					result = (this._TextDelegate = new FGetText(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_TextDelegate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_TextDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700981D RID: 38941
		// (get) Token: 0x06027B44 RID: 162628 RVA: 0x003C8928 File Offset: 0x003C6B28
		// (set) Token: 0x06027B45 RID: 162629 RVA: 0x003C8961 File Offset: 0x003C6B61
		public FSlateColor ColorAndOpacity
		{
			get
			{
				base.FastCheckIsValid();
				FSlateColor result;
				if ((result = this._ColorAndOpacity) == null)
				{
					result = (this._ColorAndOpacity = new FSlateColor(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_ColorAndOpacity, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateColor.StaticStruct(), base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_ColorAndOpacity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700981E RID: 38942
		// (get) Token: 0x06027B46 RID: 162630 RVA: 0x003C8984 File Offset: 0x003C6B84
		// (set) Token: 0x06027B47 RID: 162631 RVA: 0x003C89BD File Offset: 0x003C6BBD
		public FGetSlateColor ColorAndOpacityDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FGetSlateColor result;
				if ((result = this._ColorAndOpacityDelegate) == null)
				{
					result = (this._ColorAndOpacityDelegate = new FGetSlateColor(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_ColorAndOpacityDelegate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_ColorAndOpacityDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700981F RID: 38943
		// (get) Token: 0x06027B48 RID: 162632 RVA: 0x003C89E0 File Offset: 0x003C6BE0
		// (set) Token: 0x06027B49 RID: 162633 RVA: 0x003C8A19 File Offset: 0x003C6C19
		public FSlateFontInfo Font
		{
			get
			{
				base.FastCheckIsValid();
				FSlateFontInfo result;
				if ((result = this._Font) == null)
				{
					result = (this._Font = new FSlateFontInfo(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_Font, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateFontInfo.StaticStruct(), base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_Font, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009820 RID: 38944
		// (get) Token: 0x06027B4A RID: 162634 RVA: 0x003C8A3C File Offset: 0x003C6C3C
		// (set) Token: 0x06027B4B RID: 162635 RVA: 0x003C8A75 File Offset: 0x003C6C75
		public FSlateBrush StrikeBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._StrikeBrush) == null)
				{
					result = (this._StrikeBrush = new FSlateBrush(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_StrikeBrush, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_StrikeBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009821 RID: 38945
		// (get) Token: 0x06027B4C RID: 162636 RVA: 0x003C8A96 File Offset: 0x003C6C96
		// (set) Token: 0x06027B4D RID: 162637 RVA: 0x003C8AAA File Offset: 0x003C6CAA
		public unsafe FVector2D ShadowOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_ShadowOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_ShadowOffset) = value;
			}
		}

		// Token: 0x17009822 RID: 38946
		// (get) Token: 0x06027B4E RID: 162638 RVA: 0x003C8ABF File Offset: 0x003C6CBF
		// (set) Token: 0x06027B4F RID: 162639 RVA: 0x003C8AD3 File Offset: 0x003C6CD3
		public unsafe FLinearColor ShadowColorAndOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_ShadowColorAndOpacity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_ShadowColorAndOpacity) = value;
			}
		}

		// Token: 0x17009823 RID: 38947
		// (get) Token: 0x06027B50 RID: 162640 RVA: 0x003C8AE8 File Offset: 0x003C6CE8
		// (set) Token: 0x06027B51 RID: 162641 RVA: 0x003C8B21 File Offset: 0x003C6D21
		public FGetLinearColor ShadowColorAndOpacityDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FGetLinearColor result;
				if ((result = this._ShadowColorAndOpacityDelegate) == null)
				{
					result = (this._ShadowColorAndOpacityDelegate = new FGetLinearColor(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_ShadowColorAndOpacityDelegate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_ShadowColorAndOpacityDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17009824 RID: 38948
		// (get) Token: 0x06027B52 RID: 162642 RVA: 0x003C8B42 File Offset: 0x003C6D42
		// (set) Token: 0x06027B53 RID: 162643 RVA: 0x003C8B52 File Offset: 0x003C6D52
		public unsafe float MinDesiredWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_MinDesiredWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_MinDesiredWidth) = value;
			}
		}

		// Token: 0x17009825 RID: 38949
		// (get) Token: 0x06027B54 RID: 162644 RVA: 0x003C8B63 File Offset: 0x003C6D63
		// (set) Token: 0x06027B55 RID: 162645 RVA: 0x003C8B73 File Offset: 0x003C6D73
		public unsafe bool bWrapWithInvalidationPanel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_bWrapWithInvalidationPanel) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_bWrapWithInvalidationPanel) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009826 RID: 38950
		// (get) Token: 0x06027B56 RID: 162646 RVA: 0x003C8B84 File Offset: 0x003C6D84
		// (set) Token: 0x06027B57 RID: 162647 RVA: 0x003C8B94 File Offset: 0x003C6D94
		public unsafe bool bAutoWrapText_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_bAutoWrapText_DEPRECATED) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_bAutoWrapText_DEPRECATED) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009827 RID: 38951
		// (get) Token: 0x06027B58 RID: 162648 RVA: 0x003C8BA5 File Offset: 0x003C6DA5
		// (set) Token: 0x06027B59 RID: 162649 RVA: 0x003C8BB5 File Offset: 0x003C6DB5
		public unsafe ETextTransformPolicy TextTransformPolicy
		{
			get
			{
				return (ETextTransformPolicy)(*(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_TextTransformPolicy));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_TextTransformPolicy) = (byte)value;
			}
		}

		// Token: 0x17009828 RID: 38952
		// (get) Token: 0x06027B5A RID: 162650 RVA: 0x003C8BC6 File Offset: 0x003C6DC6
		// (set) Token: 0x06027B5B RID: 162651 RVA: 0x003C8BD6 File Offset: 0x003C6DD6
		public unsafe bool bSimpleTextMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_bSimpleTextMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextBlock.__PropertyOffset_bSimpleTextMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x06027B5C RID: 162652 RVA: 0x003C8BE7 File Offset: 0x003C6DE7
		public void SetTextTransformPolicy(ETextTransformPolicy InTransformPolicy)
		{
			UTextBlock.__SetTextTransformPolicy_Internal(base.NativePtr, InTransformPolicy);
		}

		// Token: 0x06027B5D RID: 162653 RVA: 0x003C8BF5 File Offset: 0x003C6DF5
		public void SetText(FText InText)
		{
			UTextBlock.__SetText_Internal(base.NativePtr, (InText != null) ? InText.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027B5E RID: 162654 RVA: 0x003C8C12 File Offset: 0x003C6E12
		[NullableContext(2)]
		public void SetStrikeBrush(FSlateBrush InStrikeBrush)
		{
			UTextBlock.__SetStrikeBrush_Internal(base.NativePtr, (InStrikeBrush ?? new FSlateBrush()).NativePtr);
		}

		// Token: 0x06027B5F RID: 162655 RVA: 0x003C8C2E File Offset: 0x003C6E2E
		public void SetShadowOffset(FVector2D InShadowOffset)
		{
			UTextBlock.__SetShadowOffset_Internal(base.NativePtr, InShadowOffset);
		}

		// Token: 0x06027B60 RID: 162656 RVA: 0x003C8C3C File Offset: 0x003C6E3C
		public void SetShadowColorAndOpacity(FLinearColor InShadowColorAndOpacity)
		{
			UTextBlock.__SetShadowColorAndOpacity_Internal(base.NativePtr, InShadowColorAndOpacity);
		}

		// Token: 0x06027B61 RID: 162657 RVA: 0x003C8C4A File Offset: 0x003C6E4A
		public void SetOpacity(float InOpacity)
		{
			UTextBlock.__SetOpacity_Internal(base.NativePtr, InOpacity);
		}

		// Token: 0x06027B62 RID: 162658 RVA: 0x003C8C58 File Offset: 0x003C6E58
		public void SetMinDesiredWidth(float InMinDesiredWidth)
		{
			UTextBlock.__SetMinDesiredWidth_Internal(base.NativePtr, InMinDesiredWidth);
		}

		// Token: 0x06027B63 RID: 162659 RVA: 0x003C8C66 File Offset: 0x003C6E66
		[NullableContext(2)]
		public void SetFont(FSlateFontInfo InFontInfo)
		{
			UTextBlock.__SetFont_Internal(base.NativePtr, (InFontInfo ?? new FSlateFontInfo()).NativePtr);
		}

		// Token: 0x06027B64 RID: 162660 RVA: 0x003C8C82 File Offset: 0x003C6E82
		[NullableContext(2)]
		public void SetColorAndOpacity(FSlateColor InColorAndOpacity)
		{
			UTextBlock.__SetColorAndOpacity_Internal(base.NativePtr, (InColorAndOpacity ?? new FSlateColor()).NativePtr);
		}

		// Token: 0x06027B65 RID: 162661 RVA: 0x003C8C9E File Offset: 0x003C6E9E
		public void SetAutoWrapText(bool InAutoTextWrap)
		{
			UTextBlock.__SetAutoWrapText_Internal(base.NativePtr, InAutoTextWrap);
		}

		// Token: 0x06027B66 RID: 162662 RVA: 0x003C8CAC File Offset: 0x003C6EAC
		public FText GetText()
		{
			return new FText(UTextBlock.__GetText_Internal(base.NativePtr), null);
		}

		// Token: 0x06027B67 RID: 162663 RVA: 0x003C8CBF File Offset: 0x003C6EBF
		[NullableContext(2)]
		public UMaterialInstanceDynamic GetDynamicOutlineMaterial()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(UTextBlock.__GetDynamicOutlineMaterial_Internal(base.NativePtr));
		}

		// Token: 0x06027B68 RID: 162664 RVA: 0x003C8CD1 File Offset: 0x003C6ED1
		[NullableContext(2)]
		public UMaterialInstanceDynamic GetDynamicFontMaterial()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(UTextBlock.__GetDynamicFontMaterial_Internal(base.NativePtr));
		}

		// Token: 0x06027B69 RID: 162665
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTextTransformPolicy_Internal(IntPtr @this, ETextTransformPolicy InTransformPolicy);

		// Token: 0x06027B6A RID: 162666
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetText_Internal(IntPtr @this, IntPtr InText);

		// Token: 0x06027B6B RID: 162667
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStrikeBrush_Internal(IntPtr @this, IntPtr InStrikeBrush);

		// Token: 0x06027B6C RID: 162668
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShadowOffset_Internal(IntPtr @this, FVector2D InShadowOffset);

		// Token: 0x06027B6D RID: 162669
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShadowColorAndOpacity_Internal(IntPtr @this, FLinearColor InShadowColorAndOpacity);

		// Token: 0x06027B6E RID: 162670
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOpacity_Internal(IntPtr @this, float InOpacity);

		// Token: 0x06027B6F RID: 162671
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMinDesiredWidth_Internal(IntPtr @this, float InMinDesiredWidth);

		// Token: 0x06027B70 RID: 162672
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFont_Internal(IntPtr @this, IntPtr InFontInfo);

		// Token: 0x06027B71 RID: 162673
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetColorAndOpacity_Internal(IntPtr @this, IntPtr InColorAndOpacity);

		// Token: 0x06027B72 RID: 162674
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAutoWrapText_Internal(IntPtr @this, bool InAutoTextWrap);

		// Token: 0x06027B73 RID: 162675
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetText_Internal(IntPtr @this);

		// Token: 0x06027B74 RID: 162676
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDynamicOutlineMaterial_Internal(IntPtr @this);

		// Token: 0x06027B75 RID: 162677
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDynamicFontMaterial_Internal(IntPtr @this);

		// Token: 0x06027B76 RID: 162678 RVA: 0x003C8CE3 File Offset: 0x003C6EE3
		static UTextBlock()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.TextBlock");
		}

		// Token: 0x06027B77 RID: 162679 RVA: 0x003C8CF1 File Offset: 0x003C6EF1
		protected UTextBlock(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015BDC RID: 89052
		public new const string __ObjectPath = "/Script/UMG.TextBlock";

		// Token: 0x04015BDD RID: 89053
		private static IntPtr _ClassPtr;

		// Token: 0x04015BDE RID: 89054
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015BDF RID: 89055
		internal static int __PropertyOffset_Text;

		// Token: 0x04015BE0 RID: 89056
		[Nullable(2)]
		private FText _Text;

		// Token: 0x04015BE1 RID: 89057
		internal static int __PropertyOffset_TextDelegate;

		// Token: 0x04015BE2 RID: 89058
		[Nullable(2)]
		private FGetText _TextDelegate;

		// Token: 0x04015BE3 RID: 89059
		internal static int __PropertyOffset_ColorAndOpacity;

		// Token: 0x04015BE4 RID: 89060
		[Nullable(2)]
		private FSlateColor _ColorAndOpacity;

		// Token: 0x04015BE5 RID: 89061
		internal static int __PropertyOffset_ColorAndOpacityDelegate;

		// Token: 0x04015BE6 RID: 89062
		[Nullable(2)]
		private FGetSlateColor _ColorAndOpacityDelegate;

		// Token: 0x04015BE7 RID: 89063
		internal static int __PropertyOffset_Font;

		// Token: 0x04015BE8 RID: 89064
		[Nullable(2)]
		private FSlateFontInfo _Font;

		// Token: 0x04015BE9 RID: 89065
		internal static int __PropertyOffset_StrikeBrush;

		// Token: 0x04015BEA RID: 89066
		[Nullable(2)]
		private FSlateBrush _StrikeBrush;

		// Token: 0x04015BEB RID: 89067
		internal static int __PropertyOffset_ShadowOffset;

		// Token: 0x04015BEC RID: 89068
		internal static int __PropertyOffset_ShadowColorAndOpacity;

		// Token: 0x04015BED RID: 89069
		internal static int __PropertyOffset_ShadowColorAndOpacityDelegate;

		// Token: 0x04015BEE RID: 89070
		[Nullable(2)]
		private FGetLinearColor _ShadowColorAndOpacityDelegate;

		// Token: 0x04015BEF RID: 89071
		internal static int __PropertyOffset_MinDesiredWidth;

		// Token: 0x04015BF0 RID: 89072
		internal static int __PropertyOffset_bWrapWithInvalidationPanel;

		// Token: 0x04015BF1 RID: 89073
		internal static int __PropertyOffset_bAutoWrapText_DEPRECATED;

		// Token: 0x04015BF2 RID: 89074
		internal static int __PropertyOffset_TextTransformPolicy;

		// Token: 0x04015BF3 RID: 89075
		internal static int __PropertyOffset_bSimpleTextMode;
	}
}
