using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002834 RID: 10292
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SlateCore.SpinBoxStyle")]
	[UnrealStructLayout(864, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 864)]
	public class FSpinBoxStyle : FSlateWidgetStyle, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060263CF RID: 156623 RVA: 0x003A09FE File Offset: 0x0039EBFE
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSpinBoxStyle._ScriptStructPtr != 0) ? FSpinBoxStyle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.SpinBoxStyle", ref FSpinBoxStyle._ScriptStructPtr);
		}

		// Token: 0x17009398 RID: 37784
		// (get) Token: 0x060263D0 RID: 156624 RVA: 0x003A0A24 File Offset: 0x0039EC24
		// (set) Token: 0x060263D1 RID: 156625 RVA: 0x003A0A67 File Offset: 0x0039EC67
		public FSlateBrush BackgroundBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._BackgroundBrush) == null)
				{
					result = (this._BackgroundBrush = new FSlateBrush(base.NativePtr + (IntPtr)FSpinBoxStyle.__PropertyOffset_BackgroundBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FSpinBoxStyle.__PropertyOffset_BackgroundBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009399 RID: 37785
		// (get) Token: 0x060263D2 RID: 156626 RVA: 0x003A0A88 File Offset: 0x0039EC88
		// (set) Token: 0x060263D3 RID: 156627 RVA: 0x003A0ACB File Offset: 0x0039ECCB
		public FSlateBrush HoveredBackgroundBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._HoveredBackgroundBrush) == null)
				{
					result = (this._HoveredBackgroundBrush = new FSlateBrush(base.NativePtr + (IntPtr)FSpinBoxStyle.__PropertyOffset_HoveredBackgroundBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FSpinBoxStyle.__PropertyOffset_HoveredBackgroundBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700939A RID: 37786
		// (get) Token: 0x060263D4 RID: 156628 RVA: 0x003A0AEC File Offset: 0x0039ECEC
		// (set) Token: 0x060263D5 RID: 156629 RVA: 0x003A0B2F File Offset: 0x0039ED2F
		public FSlateBrush ActiveFillBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._ActiveFillBrush) == null)
				{
					result = (this._ActiveFillBrush = new FSlateBrush(base.NativePtr + (IntPtr)FSpinBoxStyle.__PropertyOffset_ActiveFillBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FSpinBoxStyle.__PropertyOffset_ActiveFillBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700939B RID: 37787
		// (get) Token: 0x060263D6 RID: 156630 RVA: 0x003A0B50 File Offset: 0x0039ED50
		// (set) Token: 0x060263D7 RID: 156631 RVA: 0x003A0B93 File Offset: 0x0039ED93
		public FSlateBrush InactiveFillBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._InactiveFillBrush) == null)
				{
					result = (this._InactiveFillBrush = new FSlateBrush(base.NativePtr + (IntPtr)FSpinBoxStyle.__PropertyOffset_InactiveFillBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FSpinBoxStyle.__PropertyOffset_InactiveFillBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700939C RID: 37788
		// (get) Token: 0x060263D8 RID: 156632 RVA: 0x003A0BB4 File Offset: 0x0039EDB4
		// (set) Token: 0x060263D9 RID: 156633 RVA: 0x003A0BF7 File Offset: 0x0039EDF7
		public FSlateBrush ArrowsImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._ArrowsImage) == null)
				{
					result = (this._ArrowsImage = new FSlateBrush(base.NativePtr + (IntPtr)FSpinBoxStyle.__PropertyOffset_ArrowsImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FSpinBoxStyle.__PropertyOffset_ArrowsImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700939D RID: 37789
		// (get) Token: 0x060263DA RID: 156634 RVA: 0x003A0C18 File Offset: 0x0039EE18
		// (set) Token: 0x060263DB RID: 156635 RVA: 0x003A0C5B File Offset: 0x0039EE5B
		public FSlateColor ForegroundColor
		{
			get
			{
				base.FastCheckIsValid();
				FSlateColor result;
				if ((result = this._ForegroundColor) == null)
				{
					result = (this._ForegroundColor = new FSlateColor(base.NativePtr + (IntPtr)FSpinBoxStyle.__PropertyOffset_ForegroundColor, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateColor.StaticStruct(), base.NativePtr + (IntPtr)FSpinBoxStyle.__PropertyOffset_ForegroundColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700939E RID: 37790
		// (get) Token: 0x060263DC RID: 156636 RVA: 0x003A0C7C File Offset: 0x0039EE7C
		// (set) Token: 0x060263DD RID: 156637 RVA: 0x003A0C90 File Offset: 0x0039EE90
		public unsafe FMargin TextPadding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpinBoxStyle.__PropertyOffset_TextPadding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpinBoxStyle.__PropertyOffset_TextPadding) = value;
			}
		}

		// Token: 0x060263DE RID: 156638 RVA: 0x003A0CA5 File Offset: 0x0039EEA5
		public FSpinBoxStyle()
		{
		}

		// Token: 0x060263DF RID: 156639 RVA: 0x003A0CAD File Offset: 0x0039EEAD
		public FSpinBoxStyle(FSlateBrush BackgroundBrush, FSlateBrush HoveredBackgroundBrush, FSlateBrush ActiveFillBrush, FSlateBrush InactiveFillBrush, FSlateBrush ArrowsImage, FSlateColor ForegroundColor, FMargin TextPadding)
		{
			this.BackgroundBrush = BackgroundBrush;
			this.HoveredBackgroundBrush = HoveredBackgroundBrush;
			this.ActiveFillBrush = ActiveFillBrush;
			this.InactiveFillBrush = InactiveFillBrush;
			this.ArrowsImage = ArrowsImage;
			this.ForegroundColor = ForegroundColor;
			this.TextPadding = TextPadding;
		}

		// Token: 0x060263E0 RID: 156640 RVA: 0x003A0CEA File Offset: 0x0039EEEA
		protected override IntPtr GetUStructPtr()
		{
			return FSpinBoxStyle.StaticStruct();
		}

		// Token: 0x060263E1 RID: 156641 RVA: 0x003A0CF6 File Offset: 0x0039EEF6
		[NullableContext(2)]
		public FSpinBoxStyle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060263E2 RID: 156642 RVA: 0x003A0D00 File Offset: 0x0039EF00
		public FSpinBoxStyle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060263E3 RID: 156643 RVA: 0x003A0D0B File Offset: 0x0039EF0B
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSpinBoxStyle(Pointer, false, true);
		}

		// Token: 0x060263E4 RID: 156644 RVA: 0x003A0D15 File Offset: 0x0039EF15
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSpinBoxStyle(Pointer, MemoryOwner);
		}

		// Token: 0x04014EDE RID: 85726
		public new const string __ObjectPath = "/Script/SlateCore.SpinBoxStyle";

		// Token: 0x04014EDF RID: 85727
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014EE0 RID: 85728
		internal static int __PropertyOffset_BackgroundBrush;

		// Token: 0x04014EE1 RID: 85729
		[Nullable(2)]
		private FSlateBrush _BackgroundBrush;

		// Token: 0x04014EE2 RID: 85730
		internal static int __PropertyOffset_HoveredBackgroundBrush;

		// Token: 0x04014EE3 RID: 85731
		[Nullable(2)]
		private FSlateBrush _HoveredBackgroundBrush;

		// Token: 0x04014EE4 RID: 85732
		internal static int __PropertyOffset_ActiveFillBrush;

		// Token: 0x04014EE5 RID: 85733
		[Nullable(2)]
		private FSlateBrush _ActiveFillBrush;

		// Token: 0x04014EE6 RID: 85734
		internal static int __PropertyOffset_InactiveFillBrush;

		// Token: 0x04014EE7 RID: 85735
		[Nullable(2)]
		private FSlateBrush _InactiveFillBrush;

		// Token: 0x04014EE8 RID: 85736
		internal static int __PropertyOffset_ArrowsImage;

		// Token: 0x04014EE9 RID: 85737
		[Nullable(2)]
		private FSlateBrush _ArrowsImage;

		// Token: 0x04014EEA RID: 85738
		internal static int __PropertyOffset_ForegroundColor;

		// Token: 0x04014EEB RID: 85739
		[Nullable(2)]
		private FSlateColor _ForegroundColor;

		// Token: 0x04014EEC RID: 85740
		internal static int __PropertyOffset_TextPadding;
	}
}
