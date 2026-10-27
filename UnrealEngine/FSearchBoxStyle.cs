using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002829 RID: 10281
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SlateCore.SearchBoxStyle")]
	[UnrealStructLayout(3144, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 3144)]
	public class FSearchBoxStyle : FSlateWidgetStyle, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602633D RID: 156477 RVA: 0x0039FB2D File Offset: 0x0039DD2D
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSearchBoxStyle._ScriptStructPtr != 0) ? FSearchBoxStyle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.SearchBoxStyle", ref FSearchBoxStyle._ScriptStructPtr);
		}

		// Token: 0x17009373 RID: 37747
		// (get) Token: 0x0602633E RID: 156478 RVA: 0x0039FB54 File Offset: 0x0039DD54
		// (set) Token: 0x0602633F RID: 156479 RVA: 0x0039FB97 File Offset: 0x0039DD97
		public FEditableTextBoxStyle TextBoxStyle
		{
			get
			{
				base.FastCheckIsValid();
				FEditableTextBoxStyle result;
				if ((result = this._TextBoxStyle) == null)
				{
					result = (this._TextBoxStyle = new FEditableTextBoxStyle(base.NativePtr + (IntPtr)FSearchBoxStyle.__PropertyOffset_TextBoxStyle, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEditableTextBoxStyle.StaticStruct(), base.NativePtr + (IntPtr)FSearchBoxStyle.__PropertyOffset_TextBoxStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009374 RID: 37748
		// (get) Token: 0x06026340 RID: 156480 RVA: 0x0039FBB8 File Offset: 0x0039DDB8
		// (set) Token: 0x06026341 RID: 156481 RVA: 0x0039FBFB File Offset: 0x0039DDFB
		public FSlateFontInfo ActiveFontInfo
		{
			get
			{
				base.FastCheckIsValid();
				FSlateFontInfo result;
				if ((result = this._ActiveFontInfo) == null)
				{
					result = (this._ActiveFontInfo = new FSlateFontInfo(base.NativePtr + (IntPtr)FSearchBoxStyle.__PropertyOffset_ActiveFontInfo, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateFontInfo.StaticStruct(), base.NativePtr + (IntPtr)FSearchBoxStyle.__PropertyOffset_ActiveFontInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009375 RID: 37749
		// (get) Token: 0x06026342 RID: 156482 RVA: 0x0039FC1C File Offset: 0x0039DE1C
		// (set) Token: 0x06026343 RID: 156483 RVA: 0x0039FC5F File Offset: 0x0039DE5F
		public FSlateBrush UpArrowImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._UpArrowImage) == null)
				{
					result = (this._UpArrowImage = new FSlateBrush(base.NativePtr + (IntPtr)FSearchBoxStyle.__PropertyOffset_UpArrowImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FSearchBoxStyle.__PropertyOffset_UpArrowImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009376 RID: 37750
		// (get) Token: 0x06026344 RID: 156484 RVA: 0x0039FC80 File Offset: 0x0039DE80
		// (set) Token: 0x06026345 RID: 156485 RVA: 0x0039FCC3 File Offset: 0x0039DEC3
		public FSlateBrush DownArrowImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._DownArrowImage) == null)
				{
					result = (this._DownArrowImage = new FSlateBrush(base.NativePtr + (IntPtr)FSearchBoxStyle.__PropertyOffset_DownArrowImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FSearchBoxStyle.__PropertyOffset_DownArrowImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009377 RID: 37751
		// (get) Token: 0x06026346 RID: 156486 RVA: 0x0039FCE4 File Offset: 0x0039DEE4
		// (set) Token: 0x06026347 RID: 156487 RVA: 0x0039FD27 File Offset: 0x0039DF27
		public FSlateBrush GlassImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._GlassImage) == null)
				{
					result = (this._GlassImage = new FSlateBrush(base.NativePtr + (IntPtr)FSearchBoxStyle.__PropertyOffset_GlassImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FSearchBoxStyle.__PropertyOffset_GlassImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009378 RID: 37752
		// (get) Token: 0x06026348 RID: 156488 RVA: 0x0039FD48 File Offset: 0x0039DF48
		// (set) Token: 0x06026349 RID: 156489 RVA: 0x0039FD8B File Offset: 0x0039DF8B
		public FSlateBrush ClearImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._ClearImage) == null)
				{
					result = (this._ClearImage = new FSlateBrush(base.NativePtr + (IntPtr)FSearchBoxStyle.__PropertyOffset_ClearImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FSearchBoxStyle.__PropertyOffset_ClearImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009379 RID: 37753
		// (get) Token: 0x0602634A RID: 156490 RVA: 0x0039FDAC File Offset: 0x0039DFAC
		// (set) Token: 0x0602634B RID: 156491 RVA: 0x0039FDC0 File Offset: 0x0039DFC0
		public unsafe FMargin ImagePadding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSearchBoxStyle.__PropertyOffset_ImagePadding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSearchBoxStyle.__PropertyOffset_ImagePadding) = value;
			}
		}

		// Token: 0x1700937A RID: 37754
		// (get) Token: 0x0602634C RID: 156492 RVA: 0x0039FDD5 File Offset: 0x0039DFD5
		// (set) Token: 0x0602634D RID: 156493 RVA: 0x0039FDE5 File Offset: 0x0039DFE5
		public unsafe bool bLeftAlignButtons
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSearchBoxStyle.__PropertyOffset_bLeftAlignButtons) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSearchBoxStyle.__PropertyOffset_bLeftAlignButtons) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602634E RID: 156494 RVA: 0x0039FDF6 File Offset: 0x0039DFF6
		public FSearchBoxStyle()
		{
		}

		// Token: 0x0602634F RID: 156495 RVA: 0x0039FE00 File Offset: 0x0039E000
		public FSearchBoxStyle(FEditableTextBoxStyle TextBoxStyle, FSlateFontInfo ActiveFontInfo, FSlateBrush UpArrowImage, FSlateBrush DownArrowImage, FSlateBrush GlassImage, FSlateBrush ClearImage, FMargin ImagePadding, bool bLeftAlignButtons)
		{
			this.TextBoxStyle = TextBoxStyle;
			this.ActiveFontInfo = ActiveFontInfo;
			this.UpArrowImage = UpArrowImage;
			this.DownArrowImage = DownArrowImage;
			this.GlassImage = GlassImage;
			this.ClearImage = ClearImage;
			this.ImagePadding = ImagePadding;
			this.bLeftAlignButtons = bLeftAlignButtons;
		}

		// Token: 0x06026350 RID: 156496 RVA: 0x0039FE50 File Offset: 0x0039E050
		protected override IntPtr GetUStructPtr()
		{
			return FSearchBoxStyle.StaticStruct();
		}

		// Token: 0x06026351 RID: 156497 RVA: 0x0039FE5C File Offset: 0x0039E05C
		[NullableContext(2)]
		public FSearchBoxStyle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026352 RID: 156498 RVA: 0x0039FE66 File Offset: 0x0039E066
		public FSearchBoxStyle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026353 RID: 156499 RVA: 0x0039FE71 File Offset: 0x0039E071
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSearchBoxStyle(Pointer, false, true);
		}

		// Token: 0x06026354 RID: 156500 RVA: 0x0039FE7B File Offset: 0x0039E07B
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSearchBoxStyle(Pointer, MemoryOwner);
		}

		// Token: 0x04014E90 RID: 85648
		public new const string __ObjectPath = "/Script/SlateCore.SearchBoxStyle";

		// Token: 0x04014E91 RID: 85649
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014E92 RID: 85650
		internal static int __PropertyOffset_TextBoxStyle;

		// Token: 0x04014E93 RID: 85651
		[Nullable(2)]
		private FEditableTextBoxStyle _TextBoxStyle;

		// Token: 0x04014E94 RID: 85652
		internal static int __PropertyOffset_ActiveFontInfo;

		// Token: 0x04014E95 RID: 85653
		[Nullable(2)]
		private FSlateFontInfo _ActiveFontInfo;

		// Token: 0x04014E96 RID: 85654
		internal static int __PropertyOffset_UpArrowImage;

		// Token: 0x04014E97 RID: 85655
		[Nullable(2)]
		private FSlateBrush _UpArrowImage;

		// Token: 0x04014E98 RID: 85656
		internal static int __PropertyOffset_DownArrowImage;

		// Token: 0x04014E99 RID: 85657
		[Nullable(2)]
		private FSlateBrush _DownArrowImage;

		// Token: 0x04014E9A RID: 85658
		internal static int __PropertyOffset_GlassImage;

		// Token: 0x04014E9B RID: 85659
		[Nullable(2)]
		private FSlateBrush _GlassImage;

		// Token: 0x04014E9C RID: 85660
		internal static int __PropertyOffset_ClearImage;

		// Token: 0x04014E9D RID: 85661
		[Nullable(2)]
		private FSlateBrush _ClearImage;

		// Token: 0x04014E9E RID: 85662
		internal static int __PropertyOffset_ImagePadding;

		// Token: 0x04014E9F RID: 85663
		internal static int __PropertyOffset_bLeftAlignButtons;
	}
}
