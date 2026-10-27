using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020027FB RID: 10235
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SlateCore.EditableTextBoxStyle")]
	[UnrealStructLayout(2368, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2368)]
	public class FEditableTextBoxStyle : FSlateWidgetStyle, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602621C RID: 156188 RVA: 0x0039DC14 File Offset: 0x0039BE14
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEditableTextBoxStyle._ScriptStructPtr != 0) ? FEditableTextBoxStyle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.EditableTextBoxStyle", ref FEditableTextBoxStyle._ScriptStructPtr);
		}

		// Token: 0x17009336 RID: 37686
		// (get) Token: 0x0602621D RID: 156189 RVA: 0x0039DC38 File Offset: 0x0039BE38
		// (set) Token: 0x0602621E RID: 156190 RVA: 0x0039DC7B File Offset: 0x0039BE7B
		public FSlateBrush BackgroundImageNormal
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._BackgroundImageNormal) == null)
				{
					result = (this._BackgroundImageNormal = new FSlateBrush(base.NativePtr + (IntPtr)FEditableTextBoxStyle.__PropertyOffset_BackgroundImageNormal, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FEditableTextBoxStyle.__PropertyOffset_BackgroundImageNormal, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009337 RID: 37687
		// (get) Token: 0x0602621F RID: 156191 RVA: 0x0039DC9C File Offset: 0x0039BE9C
		// (set) Token: 0x06026220 RID: 156192 RVA: 0x0039DCDF File Offset: 0x0039BEDF
		public FSlateBrush BackgroundImageHovered
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._BackgroundImageHovered) == null)
				{
					result = (this._BackgroundImageHovered = new FSlateBrush(base.NativePtr + (IntPtr)FEditableTextBoxStyle.__PropertyOffset_BackgroundImageHovered, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FEditableTextBoxStyle.__PropertyOffset_BackgroundImageHovered, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009338 RID: 37688
		// (get) Token: 0x06026221 RID: 156193 RVA: 0x0039DD00 File Offset: 0x0039BF00
		// (set) Token: 0x06026222 RID: 156194 RVA: 0x0039DD43 File Offset: 0x0039BF43
		public FSlateBrush BackgroundImageFocused
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._BackgroundImageFocused) == null)
				{
					result = (this._BackgroundImageFocused = new FSlateBrush(base.NativePtr + (IntPtr)FEditableTextBoxStyle.__PropertyOffset_BackgroundImageFocused, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FEditableTextBoxStyle.__PropertyOffset_BackgroundImageFocused, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009339 RID: 37689
		// (get) Token: 0x06026223 RID: 156195 RVA: 0x0039DD64 File Offset: 0x0039BF64
		// (set) Token: 0x06026224 RID: 156196 RVA: 0x0039DDA7 File Offset: 0x0039BFA7
		public FSlateBrush BackgroundImageReadOnly
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._BackgroundImageReadOnly) == null)
				{
					result = (this._BackgroundImageReadOnly = new FSlateBrush(base.NativePtr + (IntPtr)FEditableTextBoxStyle.__PropertyOffset_BackgroundImageReadOnly, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FEditableTextBoxStyle.__PropertyOffset_BackgroundImageReadOnly, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700933A RID: 37690
		// (get) Token: 0x06026225 RID: 156197 RVA: 0x0039DDC8 File Offset: 0x0039BFC8
		// (set) Token: 0x06026226 RID: 156198 RVA: 0x0039DDDC File Offset: 0x0039BFDC
		public unsafe FMargin Padding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEditableTextBoxStyle.__PropertyOffset_Padding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEditableTextBoxStyle.__PropertyOffset_Padding) = value;
			}
		}

		// Token: 0x1700933B RID: 37691
		// (get) Token: 0x06026227 RID: 156199 RVA: 0x0039DDF4 File Offset: 0x0039BFF4
		// (set) Token: 0x06026228 RID: 156200 RVA: 0x0039DE37 File Offset: 0x0039C037
		public FSlateFontInfo Font
		{
			get
			{
				base.FastCheckIsValid();
				FSlateFontInfo result;
				if ((result = this._Font) == null)
				{
					result = (this._Font = new FSlateFontInfo(base.NativePtr + (IntPtr)FEditableTextBoxStyle.__PropertyOffset_Font, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateFontInfo.StaticStruct(), base.NativePtr + (IntPtr)FEditableTextBoxStyle.__PropertyOffset_Font, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700933C RID: 37692
		// (get) Token: 0x06026229 RID: 156201 RVA: 0x0039DE58 File Offset: 0x0039C058
		// (set) Token: 0x0602622A RID: 156202 RVA: 0x0039DE9B File Offset: 0x0039C09B
		public FSlateColor ForegroundColor
		{
			get
			{
				base.FastCheckIsValid();
				FSlateColor result;
				if ((result = this._ForegroundColor) == null)
				{
					result = (this._ForegroundColor = new FSlateColor(base.NativePtr + (IntPtr)FEditableTextBoxStyle.__PropertyOffset_ForegroundColor, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateColor.StaticStruct(), base.NativePtr + (IntPtr)FEditableTextBoxStyle.__PropertyOffset_ForegroundColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700933D RID: 37693
		// (get) Token: 0x0602622B RID: 156203 RVA: 0x0039DEBC File Offset: 0x0039C0BC
		// (set) Token: 0x0602622C RID: 156204 RVA: 0x0039DEFF File Offset: 0x0039C0FF
		public FSlateColor BackgroundColor
		{
			get
			{
				base.FastCheckIsValid();
				FSlateColor result;
				if ((result = this._BackgroundColor) == null)
				{
					result = (this._BackgroundColor = new FSlateColor(base.NativePtr + (IntPtr)FEditableTextBoxStyle.__PropertyOffset_BackgroundColor, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateColor.StaticStruct(), base.NativePtr + (IntPtr)FEditableTextBoxStyle.__PropertyOffset_BackgroundColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700933E RID: 37694
		// (get) Token: 0x0602622D RID: 156205 RVA: 0x0039DF20 File Offset: 0x0039C120
		// (set) Token: 0x0602622E RID: 156206 RVA: 0x0039DF63 File Offset: 0x0039C163
		public FSlateColor ReadOnlyForegroundColor
		{
			get
			{
				base.FastCheckIsValid();
				FSlateColor result;
				if ((result = this._ReadOnlyForegroundColor) == null)
				{
					result = (this._ReadOnlyForegroundColor = new FSlateColor(base.NativePtr + (IntPtr)FEditableTextBoxStyle.__PropertyOffset_ReadOnlyForegroundColor, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateColor.StaticStruct(), base.NativePtr + (IntPtr)FEditableTextBoxStyle.__PropertyOffset_ReadOnlyForegroundColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700933F RID: 37695
		// (get) Token: 0x0602622F RID: 156207 RVA: 0x0039DF84 File Offset: 0x0039C184
		// (set) Token: 0x06026230 RID: 156208 RVA: 0x0039DF98 File Offset: 0x0039C198
		public unsafe FMargin HScrollBarPadding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEditableTextBoxStyle.__PropertyOffset_HScrollBarPadding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEditableTextBoxStyle.__PropertyOffset_HScrollBarPadding) = value;
			}
		}

		// Token: 0x17009340 RID: 37696
		// (get) Token: 0x06026231 RID: 156209 RVA: 0x0039DFAD File Offset: 0x0039C1AD
		// (set) Token: 0x06026232 RID: 156210 RVA: 0x0039DFC1 File Offset: 0x0039C1C1
		public unsafe FMargin VScrollBarPadding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEditableTextBoxStyle.__PropertyOffset_VScrollBarPadding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEditableTextBoxStyle.__PropertyOffset_VScrollBarPadding) = value;
			}
		}

		// Token: 0x17009341 RID: 37697
		// (get) Token: 0x06026233 RID: 156211 RVA: 0x0039DFD8 File Offset: 0x0039C1D8
		// (set) Token: 0x06026234 RID: 156212 RVA: 0x0039E01B File Offset: 0x0039C21B
		public FScrollBarStyle ScrollBarStyle
		{
			get
			{
				base.FastCheckIsValid();
				FScrollBarStyle result;
				if ((result = this._ScrollBarStyle) == null)
				{
					result = (this._ScrollBarStyle = new FScrollBarStyle(base.NativePtr + (IntPtr)FEditableTextBoxStyle.__PropertyOffset_ScrollBarStyle, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FScrollBarStyle.StaticStruct(), base.NativePtr + (IntPtr)FEditableTextBoxStyle.__PropertyOffset_ScrollBarStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06026235 RID: 156213 RVA: 0x0039E03C File Offset: 0x0039C23C
		public FEditableTextBoxStyle()
		{
		}

		// Token: 0x06026236 RID: 156214 RVA: 0x0039E044 File Offset: 0x0039C244
		public FEditableTextBoxStyle(FSlateBrush BackgroundImageNormal, FSlateBrush BackgroundImageHovered, FSlateBrush BackgroundImageFocused, FSlateBrush BackgroundImageReadOnly, FMargin Padding, FSlateFontInfo Font, FSlateColor ForegroundColor, FSlateColor BackgroundColor, FSlateColor ReadOnlyForegroundColor, FMargin HScrollBarPadding, FMargin VScrollBarPadding, FScrollBarStyle ScrollBarStyle)
		{
			this.BackgroundImageNormal = BackgroundImageNormal;
			this.BackgroundImageHovered = BackgroundImageHovered;
			this.BackgroundImageFocused = BackgroundImageFocused;
			this.BackgroundImageReadOnly = BackgroundImageReadOnly;
			this.Padding = Padding;
			this.Font = Font;
			this.ForegroundColor = ForegroundColor;
			this.BackgroundColor = BackgroundColor;
			this.ReadOnlyForegroundColor = ReadOnlyForegroundColor;
			this.HScrollBarPadding = HScrollBarPadding;
			this.VScrollBarPadding = VScrollBarPadding;
			this.ScrollBarStyle = ScrollBarStyle;
		}

		// Token: 0x06026237 RID: 156215 RVA: 0x0039E0B4 File Offset: 0x0039C2B4
		protected override IntPtr GetUStructPtr()
		{
			return FEditableTextBoxStyle.StaticStruct();
		}

		// Token: 0x06026238 RID: 156216 RVA: 0x0039E0C0 File Offset: 0x0039C2C0
		[NullableContext(2)]
		public FEditableTextBoxStyle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026239 RID: 156217 RVA: 0x0039E0CA File Offset: 0x0039C2CA
		public FEditableTextBoxStyle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602623A RID: 156218 RVA: 0x0039E0D5 File Offset: 0x0039C2D5
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEditableTextBoxStyle(Pointer, false, true);
		}

		// Token: 0x0602623B RID: 156219 RVA: 0x0039E0DF File Offset: 0x0039C2DF
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEditableTextBoxStyle(Pointer, MemoryOwner);
		}

		// Token: 0x04014D67 RID: 85351
		public new const string __ObjectPath = "/Script/SlateCore.EditableTextBoxStyle";

		// Token: 0x04014D68 RID: 85352
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014D69 RID: 85353
		internal static int __PropertyOffset_BackgroundImageNormal;

		// Token: 0x04014D6A RID: 85354
		[Nullable(2)]
		private FSlateBrush _BackgroundImageNormal;

		// Token: 0x04014D6B RID: 85355
		internal static int __PropertyOffset_BackgroundImageHovered;

		// Token: 0x04014D6C RID: 85356
		[Nullable(2)]
		private FSlateBrush _BackgroundImageHovered;

		// Token: 0x04014D6D RID: 85357
		internal static int __PropertyOffset_BackgroundImageFocused;

		// Token: 0x04014D6E RID: 85358
		[Nullable(2)]
		private FSlateBrush _BackgroundImageFocused;

		// Token: 0x04014D6F RID: 85359
		internal static int __PropertyOffset_BackgroundImageReadOnly;

		// Token: 0x04014D70 RID: 85360
		[Nullable(2)]
		private FSlateBrush _BackgroundImageReadOnly;

		// Token: 0x04014D71 RID: 85361
		internal static int __PropertyOffset_Padding;

		// Token: 0x04014D72 RID: 85362
		internal static int __PropertyOffset_Font;

		// Token: 0x04014D73 RID: 85363
		[Nullable(2)]
		private FSlateFontInfo _Font;

		// Token: 0x04014D74 RID: 85364
		internal static int __PropertyOffset_ForegroundColor;

		// Token: 0x04014D75 RID: 85365
		[Nullable(2)]
		private FSlateColor _ForegroundColor;

		// Token: 0x04014D76 RID: 85366
		internal static int __PropertyOffset_BackgroundColor;

		// Token: 0x04014D77 RID: 85367
		[Nullable(2)]
		private FSlateColor _BackgroundColor;

		// Token: 0x04014D78 RID: 85368
		internal static int __PropertyOffset_ReadOnlyForegroundColor;

		// Token: 0x04014D79 RID: 85369
		[Nullable(2)]
		private FSlateColor _ReadOnlyForegroundColor;

		// Token: 0x04014D7A RID: 85370
		internal static int __PropertyOffset_HScrollBarPadding;

		// Token: 0x04014D7B RID: 85371
		internal static int __PropertyOffset_VScrollBarPadding;

		// Token: 0x04014D7C RID: 85372
		internal static int __PropertyOffset_ScrollBarStyle;

		// Token: 0x04014D7D RID: 85373
		[Nullable(2)]
		private FScrollBarStyle _ScrollBarStyle;
	}
}
