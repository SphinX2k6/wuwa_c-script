using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002838 RID: 10296
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SlateCore.TextBlockStyle")]
	[UnrealStructLayout(712, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 712)]
	public class FTextBlockStyle : FSlateWidgetStyle, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026433 RID: 156723 RVA: 0x003A19CC File Offset: 0x0039FBCC
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTextBlockStyle._ScriptStructPtr != 0) ? FTextBlockStyle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.TextBlockStyle", ref FTextBlockStyle._ScriptStructPtr);
		}

		// Token: 0x170093BA RID: 37818
		// (get) Token: 0x06026434 RID: 156724 RVA: 0x003A19F0 File Offset: 0x0039FBF0
		// (set) Token: 0x06026435 RID: 156725 RVA: 0x003A1A33 File Offset: 0x0039FC33
		public FSlateFontInfo Font
		{
			get
			{
				base.FastCheckIsValid();
				FSlateFontInfo result;
				if ((result = this._Font) == null)
				{
					result = (this._Font = new FSlateFontInfo(base.NativePtr + (IntPtr)FTextBlockStyle.__PropertyOffset_Font, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateFontInfo.StaticStruct(), base.NativePtr + (IntPtr)FTextBlockStyle.__PropertyOffset_Font, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093BB RID: 37819
		// (get) Token: 0x06026436 RID: 156726 RVA: 0x003A1A54 File Offset: 0x0039FC54
		// (set) Token: 0x06026437 RID: 156727 RVA: 0x003A1A97 File Offset: 0x0039FC97
		public FSlateColor ColorAndOpacity
		{
			get
			{
				base.FastCheckIsValid();
				FSlateColor result;
				if ((result = this._ColorAndOpacity) == null)
				{
					result = (this._ColorAndOpacity = new FSlateColor(base.NativePtr + (IntPtr)FTextBlockStyle.__PropertyOffset_ColorAndOpacity, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateColor.StaticStruct(), base.NativePtr + (IntPtr)FTextBlockStyle.__PropertyOffset_ColorAndOpacity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093BC RID: 37820
		// (get) Token: 0x06026438 RID: 156728 RVA: 0x003A1AB8 File Offset: 0x0039FCB8
		// (set) Token: 0x06026439 RID: 156729 RVA: 0x003A1ACC File Offset: 0x0039FCCC
		public unsafe FVector2D ShadowOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextBlockStyle.__PropertyOffset_ShadowOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextBlockStyle.__PropertyOffset_ShadowOffset) = value;
			}
		}

		// Token: 0x170093BD RID: 37821
		// (get) Token: 0x0602643A RID: 156730 RVA: 0x003A1AE1 File Offset: 0x0039FCE1
		// (set) Token: 0x0602643B RID: 156731 RVA: 0x003A1AF5 File Offset: 0x0039FCF5
		public unsafe FLinearColor ShadowColorAndOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextBlockStyle.__PropertyOffset_ShadowColorAndOpacity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextBlockStyle.__PropertyOffset_ShadowColorAndOpacity) = value;
			}
		}

		// Token: 0x170093BE RID: 37822
		// (get) Token: 0x0602643C RID: 156732 RVA: 0x003A1B0C File Offset: 0x0039FD0C
		// (set) Token: 0x0602643D RID: 156733 RVA: 0x003A1B4F File Offset: 0x0039FD4F
		public FSlateColor SelectedBackgroundColor
		{
			get
			{
				base.FastCheckIsValid();
				FSlateColor result;
				if ((result = this._SelectedBackgroundColor) == null)
				{
					result = (this._SelectedBackgroundColor = new FSlateColor(base.NativePtr + (IntPtr)FTextBlockStyle.__PropertyOffset_SelectedBackgroundColor, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateColor.StaticStruct(), base.NativePtr + (IntPtr)FTextBlockStyle.__PropertyOffset_SelectedBackgroundColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093BF RID: 37823
		// (get) Token: 0x0602643E RID: 156734 RVA: 0x003A1B70 File Offset: 0x0039FD70
		// (set) Token: 0x0602643F RID: 156735 RVA: 0x003A1B84 File Offset: 0x0039FD84
		public unsafe FLinearColor HighlightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextBlockStyle.__PropertyOffset_HighlightColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextBlockStyle.__PropertyOffset_HighlightColor) = value;
			}
		}

		// Token: 0x170093C0 RID: 37824
		// (get) Token: 0x06026440 RID: 156736 RVA: 0x003A1B9C File Offset: 0x0039FD9C
		// (set) Token: 0x06026441 RID: 156737 RVA: 0x003A1BDF File Offset: 0x0039FDDF
		public FSlateBrush HighlightShape
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._HighlightShape) == null)
				{
					result = (this._HighlightShape = new FSlateBrush(base.NativePtr + (IntPtr)FTextBlockStyle.__PropertyOffset_HighlightShape, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FTextBlockStyle.__PropertyOffset_HighlightShape, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093C1 RID: 37825
		// (get) Token: 0x06026442 RID: 156738 RVA: 0x003A1C00 File Offset: 0x0039FE00
		// (set) Token: 0x06026443 RID: 156739 RVA: 0x003A1C43 File Offset: 0x0039FE43
		public FSlateBrush StrikeBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._StrikeBrush) == null)
				{
					result = (this._StrikeBrush = new FSlateBrush(base.NativePtr + (IntPtr)FTextBlockStyle.__PropertyOffset_StrikeBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FTextBlockStyle.__PropertyOffset_StrikeBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093C2 RID: 37826
		// (get) Token: 0x06026444 RID: 156740 RVA: 0x003A1C64 File Offset: 0x0039FE64
		// (set) Token: 0x06026445 RID: 156741 RVA: 0x003A1CA7 File Offset: 0x0039FEA7
		public FSlateBrush UnderlineBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._UnderlineBrush) == null)
				{
					result = (this._UnderlineBrush = new FSlateBrush(base.NativePtr + (IntPtr)FTextBlockStyle.__PropertyOffset_UnderlineBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FTextBlockStyle.__PropertyOffset_UnderlineBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06026446 RID: 156742 RVA: 0x003A1CC8 File Offset: 0x0039FEC8
		public FTextBlockStyle()
		{
		}

		// Token: 0x06026447 RID: 156743 RVA: 0x003A1CD0 File Offset: 0x0039FED0
		public FTextBlockStyle(FSlateFontInfo Font, FSlateColor ColorAndOpacity, FVector2D ShadowOffset, FLinearColor ShadowColorAndOpacity, FSlateColor SelectedBackgroundColor, FLinearColor HighlightColor, FSlateBrush HighlightShape, FSlateBrush StrikeBrush, FSlateBrush UnderlineBrush)
		{
			this.Font = Font;
			this.ColorAndOpacity = ColorAndOpacity;
			this.ShadowOffset = ShadowOffset;
			this.ShadowColorAndOpacity = ShadowColorAndOpacity;
			this.SelectedBackgroundColor = SelectedBackgroundColor;
			this.HighlightColor = HighlightColor;
			this.HighlightShape = HighlightShape;
			this.StrikeBrush = StrikeBrush;
			this.UnderlineBrush = UnderlineBrush;
		}

		// Token: 0x06026448 RID: 156744 RVA: 0x003A1D28 File Offset: 0x0039FF28
		protected override IntPtr GetUStructPtr()
		{
			return FTextBlockStyle.StaticStruct();
		}

		// Token: 0x06026449 RID: 156745 RVA: 0x003A1D34 File Offset: 0x0039FF34
		[NullableContext(2)]
		public FTextBlockStyle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602644A RID: 156746 RVA: 0x003A1D3E File Offset: 0x0039FF3E
		public FTextBlockStyle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602644B RID: 156747 RVA: 0x003A1D49 File Offset: 0x0039FF49
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTextBlockStyle(Pointer, false, true);
		}

		// Token: 0x0602644C RID: 156748 RVA: 0x003A1D53 File Offset: 0x0039FF53
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTextBlockStyle(Pointer, MemoryOwner);
		}

		// Token: 0x04014F29 RID: 85801
		public new const string __ObjectPath = "/Script/SlateCore.TextBlockStyle";

		// Token: 0x04014F2A RID: 85802
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014F2B RID: 85803
		internal static int __PropertyOffset_Font;

		// Token: 0x04014F2C RID: 85804
		[Nullable(2)]
		private FSlateFontInfo _Font;

		// Token: 0x04014F2D RID: 85805
		internal static int __PropertyOffset_ColorAndOpacity;

		// Token: 0x04014F2E RID: 85806
		[Nullable(2)]
		private FSlateColor _ColorAndOpacity;

		// Token: 0x04014F2F RID: 85807
		internal static int __PropertyOffset_ShadowOffset;

		// Token: 0x04014F30 RID: 85808
		internal static int __PropertyOffset_ShadowColorAndOpacity;

		// Token: 0x04014F31 RID: 85809
		internal static int __PropertyOffset_SelectedBackgroundColor;

		// Token: 0x04014F32 RID: 85810
		[Nullable(2)]
		private FSlateColor _SelectedBackgroundColor;

		// Token: 0x04014F33 RID: 85811
		internal static int __PropertyOffset_HighlightColor;

		// Token: 0x04014F34 RID: 85812
		internal static int __PropertyOffset_HighlightShape;

		// Token: 0x04014F35 RID: 85813
		[Nullable(2)]
		private FSlateBrush _HighlightShape;

		// Token: 0x04014F36 RID: 85814
		internal static int __PropertyOffset_StrikeBrush;

		// Token: 0x04014F37 RID: 85815
		[Nullable(2)]
		private FSlateBrush _StrikeBrush;

		// Token: 0x04014F38 RID: 85816
		internal static int __PropertyOffset_UnderlineBrush;

		// Token: 0x04014F39 RID: 85817
		[Nullable(2)]
		private FSlateBrush _UnderlineBrush;
	}
}
