using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200073E RID: 1854
	[UnrealObjectPath("/Script/LGUI.UIWidget")]
	[UnrealStructLayout(84, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 84)]
	public class FUIWidget : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A1A3 RID: 41379 RVA: 0x000EED50 File Offset: 0x000ECF50
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FUIWidget._ScriptStructPtr != 0) ? FUIWidget._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.UIWidget", ref FUIWidget._ScriptStructPtr);
		}

		// Token: 0x17001E1D RID: 7709
		// (get) Token: 0x0600A1A4 RID: 41380 RVA: 0x000EED74 File Offset: 0x000ECF74
		// (set) Token: 0x0600A1A5 RID: 41381 RVA: 0x000EED84 File Offset: 0x000ECF84
		public unsafe int depth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FUIWidget.__PropertyOffset_depth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FUIWidget.__PropertyOffset_depth) = value;
			}
		}

		// Token: 0x17001E1E RID: 7710
		// (get) Token: 0x0600A1A6 RID: 41382 RVA: 0x000EED95 File Offset: 0x000ECF95
		// (set) Token: 0x0600A1A7 RID: 41383 RVA: 0x000EEDA9 File Offset: 0x000ECFA9
		public unsafe FColor color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FUIWidget.__PropertyOffset_color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FUIWidget.__PropertyOffset_color) = value;
			}
		}

		// Token: 0x17001E1F RID: 7711
		// (get) Token: 0x0600A1A8 RID: 41384 RVA: 0x000EEDBE File Offset: 0x000ECFBE
		// (set) Token: 0x0600A1A9 RID: 41385 RVA: 0x000EEDD2 File Offset: 0x000ECFD2
		public unsafe FVector2D pivot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FUIWidget.__PropertyOffset_pivot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FUIWidget.__PropertyOffset_pivot) = value;
			}
		}

		// Token: 0x17001E20 RID: 7712
		// (get) Token: 0x0600A1AA RID: 41386 RVA: 0x000EEDE7 File Offset: 0x000ECFE7
		// (set) Token: 0x0600A1AB RID: 41387 RVA: 0x000EEDF7 File Offset: 0x000ECFF7
		public unsafe UIAnchorHorizontalAlign anchorHAlign
		{
			get
			{
				return (UIAnchorHorizontalAlign)(*(base.NativePtr + (IntPtr)FUIWidget.__PropertyOffset_anchorHAlign));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FUIWidget.__PropertyOffset_anchorHAlign) = (byte)value;
			}
		}

		// Token: 0x17001E21 RID: 7713
		// (get) Token: 0x0600A1AC RID: 41388 RVA: 0x000EEE08 File Offset: 0x000ED008
		// (set) Token: 0x0600A1AD RID: 41389 RVA: 0x000EEE18 File Offset: 0x000ED018
		public unsafe UIAnchorVerticalAlign anchorVAlign
		{
			get
			{
				return (UIAnchorVerticalAlign)(*(base.NativePtr + (IntPtr)FUIWidget.__PropertyOffset_anchorVAlign));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FUIWidget.__PropertyOffset_anchorVAlign) = (byte)value;
			}
		}

		// Token: 0x17001E22 RID: 7714
		// (get) Token: 0x0600A1AE RID: 41390 RVA: 0x000EEE29 File Offset: 0x000ED029
		// (set) Token: 0x0600A1AF RID: 41391 RVA: 0x000EEE39 File Offset: 0x000ED039
		public unsafe float anchorOffsetX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FUIWidget.__PropertyOffset_anchorOffsetX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FUIWidget.__PropertyOffset_anchorOffsetX) = value;
			}
		}

		// Token: 0x17001E23 RID: 7715
		// (get) Token: 0x0600A1B0 RID: 41392 RVA: 0x000EEE4A File Offset: 0x000ED04A
		// (set) Token: 0x0600A1B1 RID: 41393 RVA: 0x000EEE5A File Offset: 0x000ED05A
		public unsafe float anchorOffsetY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FUIWidget.__PropertyOffset_anchorOffsetY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FUIWidget.__PropertyOffset_anchorOffsetY) = value;
			}
		}

		// Token: 0x17001E24 RID: 7716
		// (get) Token: 0x0600A1B2 RID: 41394 RVA: 0x000EEE6B File Offset: 0x000ED06B
		// (set) Token: 0x0600A1B3 RID: 41395 RVA: 0x000EEE7B File Offset: 0x000ED07B
		public unsafe float width
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FUIWidget.__PropertyOffset_width);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FUIWidget.__PropertyOffset_width) = value;
			}
		}

		// Token: 0x17001E25 RID: 7717
		// (get) Token: 0x0600A1B4 RID: 41396 RVA: 0x000EEE8C File Offset: 0x000ED08C
		// (set) Token: 0x0600A1B5 RID: 41397 RVA: 0x000EEE9C File Offset: 0x000ED09C
		public unsafe float height
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FUIWidget.__PropertyOffset_height);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FUIWidget.__PropertyOffset_height) = value;
			}
		}

		// Token: 0x17001E26 RID: 7718
		// (get) Token: 0x0600A1B6 RID: 41398 RVA: 0x000EEEAD File Offset: 0x000ED0AD
		// (set) Token: 0x0600A1B7 RID: 41399 RVA: 0x000EEEBD File Offset: 0x000ED0BD
		public unsafe float stretchLeft
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FUIWidget.__PropertyOffset_stretchLeft);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FUIWidget.__PropertyOffset_stretchLeft) = value;
			}
		}

		// Token: 0x17001E27 RID: 7719
		// (get) Token: 0x0600A1B8 RID: 41400 RVA: 0x000EEECE File Offset: 0x000ED0CE
		// (set) Token: 0x0600A1B9 RID: 41401 RVA: 0x000EEEDE File Offset: 0x000ED0DE
		public unsafe float stretchRight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FUIWidget.__PropertyOffset_stretchRight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FUIWidget.__PropertyOffset_stretchRight) = value;
			}
		}

		// Token: 0x17001E28 RID: 7720
		// (get) Token: 0x0600A1BA RID: 41402 RVA: 0x000EEEEF File Offset: 0x000ED0EF
		// (set) Token: 0x0600A1BB RID: 41403 RVA: 0x000EEEFF File Offset: 0x000ED0FF
		public unsafe float stretchTop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FUIWidget.__PropertyOffset_stretchTop);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FUIWidget.__PropertyOffset_stretchTop) = value;
			}
		}

		// Token: 0x17001E29 RID: 7721
		// (get) Token: 0x0600A1BC RID: 41404 RVA: 0x000EEF10 File Offset: 0x000ED110
		// (set) Token: 0x0600A1BD RID: 41405 RVA: 0x000EEF20 File Offset: 0x000ED120
		public unsafe float stretchBottom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FUIWidget.__PropertyOffset_stretchBottom);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FUIWidget.__PropertyOffset_stretchBottom) = value;
			}
		}

		// Token: 0x17001E2A RID: 7722
		// (get) Token: 0x0600A1BE RID: 41406 RVA: 0x000EEF31 File Offset: 0x000ED131
		// (set) Token: 0x0600A1BF RID: 41407 RVA: 0x000EEF45 File Offset: 0x000ED145
		public unsafe FVector2D MinAnchor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FUIWidget.__PropertyOffset_MinAnchor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FUIWidget.__PropertyOffset_MinAnchor) = value;
			}
		}

		// Token: 0x17001E2B RID: 7723
		// (get) Token: 0x0600A1C0 RID: 41408 RVA: 0x000EEF5A File Offset: 0x000ED15A
		// (set) Token: 0x0600A1C1 RID: 41409 RVA: 0x000EEF6E File Offset: 0x000ED16E
		public unsafe FVector2D MaxAnchor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FUIWidget.__PropertyOffset_MaxAnchor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FUIWidget.__PropertyOffset_MaxAnchor) = value;
			}
		}

		// Token: 0x17001E2C RID: 7724
		// (get) Token: 0x0600A1C2 RID: 41410 RVA: 0x000EEF83 File Offset: 0x000ED183
		// (set) Token: 0x0600A1C3 RID: 41411 RVA: 0x000EEF93 File Offset: 0x000ED193
		public unsafe bool bCustomMinMaxAnchor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FUIWidget.__PropertyOffset_bCustomMinMaxAnchor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FUIWidget.__PropertyOffset_bCustomMinMaxAnchor) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001E2D RID: 7725
		// (get) Token: 0x0600A1C4 RID: 41412 RVA: 0x000EEFA4 File Offset: 0x000ED1A4
		// (set) Token: 0x0600A1C5 RID: 41413 RVA: 0x000EEFB4 File Offset: 0x000ED1B4
		public unsafe float AnchorXPercent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FUIWidget.__PropertyOffset_AnchorXPercent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FUIWidget.__PropertyOffset_AnchorXPercent) = value;
			}
		}

		// Token: 0x17001E2E RID: 7726
		// (get) Token: 0x0600A1C6 RID: 41414 RVA: 0x000EEFC5 File Offset: 0x000ED1C5
		// (set) Token: 0x0600A1C7 RID: 41415 RVA: 0x000EEFD5 File Offset: 0x000ED1D5
		public unsafe float AnchorYPercent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FUIWidget.__PropertyOffset_AnchorYPercent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FUIWidget.__PropertyOffset_AnchorYPercent) = value;
			}
		}

		// Token: 0x17001E2F RID: 7727
		// (get) Token: 0x0600A1C8 RID: 41416 RVA: 0x000EEFE6 File Offset: 0x000ED1E6
		// (set) Token: 0x0600A1C9 RID: 41417 RVA: 0x000EEFF6 File Offset: 0x000ED1F6
		public unsafe bool ShowXPercent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FUIWidget.__PropertyOffset_ShowXPercent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FUIWidget.__PropertyOffset_ShowXPercent) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001E30 RID: 7728
		// (get) Token: 0x0600A1CA RID: 41418 RVA: 0x000EF007 File Offset: 0x000ED207
		// (set) Token: 0x0600A1CB RID: 41419 RVA: 0x000EF017 File Offset: 0x000ED217
		public unsafe bool ShowYPercent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FUIWidget.__PropertyOffset_ShowYPercent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FUIWidget.__PropertyOffset_ShowYPercent) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600A1CC RID: 41420 RVA: 0x000EF028 File Offset: 0x000ED228
		public FUIWidget()
		{
		}

		// Token: 0x0600A1CD RID: 41421 RVA: 0x000EF030 File Offset: 0x000ED230
		protected override IntPtr GetUStructPtr()
		{
			return FUIWidget.StaticStruct();
		}

		// Token: 0x0600A1CE RID: 41422 RVA: 0x000EF03C File Offset: 0x000ED23C
		[NullableContext(2)]
		public FUIWidget(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A1CF RID: 41423 RVA: 0x000EF046 File Offset: 0x000ED246
		public FUIWidget(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A1D0 RID: 41424 RVA: 0x000EF051 File Offset: 0x000ED251
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FUIWidget(Pointer, false, true);
		}

		// Token: 0x0600A1D1 RID: 41425 RVA: 0x000EF05B File Offset: 0x000ED25B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FUIWidget(Pointer, MemoryOwner);
		}

		// Token: 0x04004535 RID: 17717
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.UIWidget";

		// Token: 0x04004536 RID: 17718
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004537 RID: 17719
		internal static int __PropertyOffset_depth;

		// Token: 0x04004538 RID: 17720
		internal static int __PropertyOffset_color;

		// Token: 0x04004539 RID: 17721
		internal static int __PropertyOffset_pivot;

		// Token: 0x0400453A RID: 17722
		internal static int __PropertyOffset_anchorHAlign;

		// Token: 0x0400453B RID: 17723
		internal static int __PropertyOffset_anchorVAlign;

		// Token: 0x0400453C RID: 17724
		internal static int __PropertyOffset_anchorOffsetX;

		// Token: 0x0400453D RID: 17725
		internal static int __PropertyOffset_anchorOffsetY;

		// Token: 0x0400453E RID: 17726
		internal static int __PropertyOffset_width;

		// Token: 0x0400453F RID: 17727
		internal static int __PropertyOffset_height;

		// Token: 0x04004540 RID: 17728
		internal static int __PropertyOffset_stretchLeft;

		// Token: 0x04004541 RID: 17729
		internal static int __PropertyOffset_stretchRight;

		// Token: 0x04004542 RID: 17730
		internal static int __PropertyOffset_stretchTop;

		// Token: 0x04004543 RID: 17731
		internal static int __PropertyOffset_stretchBottom;

		// Token: 0x04004544 RID: 17732
		internal static int __PropertyOffset_MinAnchor;

		// Token: 0x04004545 RID: 17733
		internal static int __PropertyOffset_MaxAnchor;

		// Token: 0x04004546 RID: 17734
		internal static int __PropertyOffset_bCustomMinMaxAnchor;

		// Token: 0x04004547 RID: 17735
		internal static int __PropertyOffset_AnchorXPercent;

		// Token: 0x04004548 RID: 17736
		internal static int __PropertyOffset_AnchorYPercent;

		// Token: 0x04004549 RID: 17737
		internal static int __PropertyOffset_ShowXPercent;

		// Token: 0x0400454A RID: 17738
		internal static int __PropertyOffset_ShowYPercent;
	}
}
