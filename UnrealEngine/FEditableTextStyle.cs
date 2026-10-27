using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020027FC RID: 10236
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SlateCore.EditableTextStyle")]
	[UnrealStructLayout(632, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 632)]
	public class FEditableTextStyle : FSlateWidgetStyle, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602623C RID: 156220 RVA: 0x0039E0E8 File Offset: 0x0039C2E8
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEditableTextStyle._ScriptStructPtr != 0) ? FEditableTextStyle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.EditableTextStyle", ref FEditableTextStyle._ScriptStructPtr);
		}

		// Token: 0x17009342 RID: 37698
		// (get) Token: 0x0602623D RID: 156221 RVA: 0x0039E10C File Offset: 0x0039C30C
		// (set) Token: 0x0602623E RID: 156222 RVA: 0x0039E14F File Offset: 0x0039C34F
		public FSlateFontInfo Font
		{
			get
			{
				base.FastCheckIsValid();
				FSlateFontInfo result;
				if ((result = this._Font) == null)
				{
					result = (this._Font = new FSlateFontInfo(base.NativePtr + (IntPtr)FEditableTextStyle.__PropertyOffset_Font, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateFontInfo.StaticStruct(), base.NativePtr + (IntPtr)FEditableTextStyle.__PropertyOffset_Font, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009343 RID: 37699
		// (get) Token: 0x0602623F RID: 156223 RVA: 0x0039E170 File Offset: 0x0039C370
		// (set) Token: 0x06026240 RID: 156224 RVA: 0x0039E1B3 File Offset: 0x0039C3B3
		public FSlateColor ColorAndOpacity
		{
			get
			{
				base.FastCheckIsValid();
				FSlateColor result;
				if ((result = this._ColorAndOpacity) == null)
				{
					result = (this._ColorAndOpacity = new FSlateColor(base.NativePtr + (IntPtr)FEditableTextStyle.__PropertyOffset_ColorAndOpacity, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateColor.StaticStruct(), base.NativePtr + (IntPtr)FEditableTextStyle.__PropertyOffset_ColorAndOpacity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009344 RID: 37700
		// (get) Token: 0x06026241 RID: 156225 RVA: 0x0039E1D4 File Offset: 0x0039C3D4
		// (set) Token: 0x06026242 RID: 156226 RVA: 0x0039E217 File Offset: 0x0039C417
		public FSlateBrush BackgroundImageSelected
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._BackgroundImageSelected) == null)
				{
					result = (this._BackgroundImageSelected = new FSlateBrush(base.NativePtr + (IntPtr)FEditableTextStyle.__PropertyOffset_BackgroundImageSelected, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FEditableTextStyle.__PropertyOffset_BackgroundImageSelected, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009345 RID: 37701
		// (get) Token: 0x06026243 RID: 156227 RVA: 0x0039E238 File Offset: 0x0039C438
		// (set) Token: 0x06026244 RID: 156228 RVA: 0x0039E27B File Offset: 0x0039C47B
		public FSlateBrush BackgroundImageComposing
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._BackgroundImageComposing) == null)
				{
					result = (this._BackgroundImageComposing = new FSlateBrush(base.NativePtr + (IntPtr)FEditableTextStyle.__PropertyOffset_BackgroundImageComposing, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FEditableTextStyle.__PropertyOffset_BackgroundImageComposing, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009346 RID: 37702
		// (get) Token: 0x06026245 RID: 156229 RVA: 0x0039E29C File Offset: 0x0039C49C
		// (set) Token: 0x06026246 RID: 156230 RVA: 0x0039E2DF File Offset: 0x0039C4DF
		public FSlateBrush CaretImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._CaretImage) == null)
				{
					result = (this._CaretImage = new FSlateBrush(base.NativePtr + (IntPtr)FEditableTextStyle.__PropertyOffset_CaretImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FEditableTextStyle.__PropertyOffset_CaretImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06026247 RID: 156231 RVA: 0x0039E300 File Offset: 0x0039C500
		public FEditableTextStyle()
		{
		}

		// Token: 0x06026248 RID: 156232 RVA: 0x0039E308 File Offset: 0x0039C508
		public FEditableTextStyle(FSlateFontInfo Font, FSlateColor ColorAndOpacity, FSlateBrush BackgroundImageSelected, FSlateBrush BackgroundImageComposing, FSlateBrush CaretImage)
		{
			this.Font = Font;
			this.ColorAndOpacity = ColorAndOpacity;
			this.BackgroundImageSelected = BackgroundImageSelected;
			this.BackgroundImageComposing = BackgroundImageComposing;
			this.CaretImage = CaretImage;
		}

		// Token: 0x06026249 RID: 156233 RVA: 0x0039E335 File Offset: 0x0039C535
		protected override IntPtr GetUStructPtr()
		{
			return FEditableTextStyle.StaticStruct();
		}

		// Token: 0x0602624A RID: 156234 RVA: 0x0039E341 File Offset: 0x0039C541
		[NullableContext(2)]
		public FEditableTextStyle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602624B RID: 156235 RVA: 0x0039E34B File Offset: 0x0039C54B
		public FEditableTextStyle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602624C RID: 156236 RVA: 0x0039E356 File Offset: 0x0039C556
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEditableTextStyle(Pointer, false, true);
		}

		// Token: 0x0602624D RID: 156237 RVA: 0x0039E360 File Offset: 0x0039C560
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEditableTextStyle(Pointer, MemoryOwner);
		}

		// Token: 0x04014D7E RID: 85374
		public new const string __ObjectPath = "/Script/SlateCore.EditableTextStyle";

		// Token: 0x04014D7F RID: 85375
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014D80 RID: 85376
		internal static int __PropertyOffset_Font;

		// Token: 0x04014D81 RID: 85377
		[Nullable(2)]
		private FSlateFontInfo _Font;

		// Token: 0x04014D82 RID: 85378
		internal static int __PropertyOffset_ColorAndOpacity;

		// Token: 0x04014D83 RID: 85379
		[Nullable(2)]
		private FSlateColor _ColorAndOpacity;

		// Token: 0x04014D84 RID: 85380
		internal static int __PropertyOffset_BackgroundImageSelected;

		// Token: 0x04014D85 RID: 85381
		[Nullable(2)]
		private FSlateBrush _BackgroundImageSelected;

		// Token: 0x04014D86 RID: 85382
		internal static int __PropertyOffset_BackgroundImageComposing;

		// Token: 0x04014D87 RID: 85383
		[Nullable(2)]
		private FSlateBrush _BackgroundImageComposing;

		// Token: 0x04014D88 RID: 85384
		internal static int __PropertyOffset_CaretImage;

		// Token: 0x04014D89 RID: 85385
		[Nullable(2)]
		private FSlateBrush _CaretImage;
	}
}
