using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020021E2 RID: 8674
	[UnrealObjectPath("/Script/LGUI.UIWidget")]
	[UnrealStructLayout(84, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 84)]
	public class FUIWidget : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602112C RID: 135468 RVA: 0x0030C534 File Offset: 0x0030A734
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FUIWidget._ScriptStructPtr != 0) ? FUIWidget._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.UIWidget", ref FUIWidget._ScriptStructPtr);
		}

		// Token: 0x17008113 RID: 33043
		// (get) Token: 0x0602112D RID: 135469 RVA: 0x0030C558 File Offset: 0x0030A758
		// (set) Token: 0x0602112E RID: 135470 RVA: 0x0030C568 File Offset: 0x0030A768
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

		// Token: 0x17008114 RID: 33044
		// (get) Token: 0x0602112F RID: 135471 RVA: 0x0030C579 File Offset: 0x0030A779
		// (set) Token: 0x06021130 RID: 135472 RVA: 0x0030C58D File Offset: 0x0030A78D
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

		// Token: 0x17008115 RID: 33045
		// (get) Token: 0x06021131 RID: 135473 RVA: 0x0030C5A2 File Offset: 0x0030A7A2
		// (set) Token: 0x06021132 RID: 135474 RVA: 0x0030C5B6 File Offset: 0x0030A7B6
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

		// Token: 0x17008116 RID: 33046
		// (get) Token: 0x06021133 RID: 135475 RVA: 0x0030C5CB File Offset: 0x0030A7CB
		// (set) Token: 0x06021134 RID: 135476 RVA: 0x0030C5DB File Offset: 0x0030A7DB
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

		// Token: 0x17008117 RID: 33047
		// (get) Token: 0x06021135 RID: 135477 RVA: 0x0030C5EC File Offset: 0x0030A7EC
		// (set) Token: 0x06021136 RID: 135478 RVA: 0x0030C5FC File Offset: 0x0030A7FC
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

		// Token: 0x17008118 RID: 33048
		// (get) Token: 0x06021137 RID: 135479 RVA: 0x0030C60D File Offset: 0x0030A80D
		// (set) Token: 0x06021138 RID: 135480 RVA: 0x0030C61D File Offset: 0x0030A81D
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

		// Token: 0x17008119 RID: 33049
		// (get) Token: 0x06021139 RID: 135481 RVA: 0x0030C62E File Offset: 0x0030A82E
		// (set) Token: 0x0602113A RID: 135482 RVA: 0x0030C63E File Offset: 0x0030A83E
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

		// Token: 0x1700811A RID: 33050
		// (get) Token: 0x0602113B RID: 135483 RVA: 0x0030C64F File Offset: 0x0030A84F
		// (set) Token: 0x0602113C RID: 135484 RVA: 0x0030C65F File Offset: 0x0030A85F
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

		// Token: 0x1700811B RID: 33051
		// (get) Token: 0x0602113D RID: 135485 RVA: 0x0030C670 File Offset: 0x0030A870
		// (set) Token: 0x0602113E RID: 135486 RVA: 0x0030C680 File Offset: 0x0030A880
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

		// Token: 0x1700811C RID: 33052
		// (get) Token: 0x0602113F RID: 135487 RVA: 0x0030C691 File Offset: 0x0030A891
		// (set) Token: 0x06021140 RID: 135488 RVA: 0x0030C6A1 File Offset: 0x0030A8A1
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

		// Token: 0x1700811D RID: 33053
		// (get) Token: 0x06021141 RID: 135489 RVA: 0x0030C6B2 File Offset: 0x0030A8B2
		// (set) Token: 0x06021142 RID: 135490 RVA: 0x0030C6C2 File Offset: 0x0030A8C2
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

		// Token: 0x1700811E RID: 33054
		// (get) Token: 0x06021143 RID: 135491 RVA: 0x0030C6D3 File Offset: 0x0030A8D3
		// (set) Token: 0x06021144 RID: 135492 RVA: 0x0030C6E3 File Offset: 0x0030A8E3
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

		// Token: 0x1700811F RID: 33055
		// (get) Token: 0x06021145 RID: 135493 RVA: 0x0030C6F4 File Offset: 0x0030A8F4
		// (set) Token: 0x06021146 RID: 135494 RVA: 0x0030C704 File Offset: 0x0030A904
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

		// Token: 0x17008120 RID: 33056
		// (get) Token: 0x06021147 RID: 135495 RVA: 0x0030C715 File Offset: 0x0030A915
		// (set) Token: 0x06021148 RID: 135496 RVA: 0x0030C729 File Offset: 0x0030A929
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

		// Token: 0x17008121 RID: 33057
		// (get) Token: 0x06021149 RID: 135497 RVA: 0x0030C73E File Offset: 0x0030A93E
		// (set) Token: 0x0602114A RID: 135498 RVA: 0x0030C752 File Offset: 0x0030A952
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

		// Token: 0x17008122 RID: 33058
		// (get) Token: 0x0602114B RID: 135499 RVA: 0x0030C767 File Offset: 0x0030A967
		// (set) Token: 0x0602114C RID: 135500 RVA: 0x0030C777 File Offset: 0x0030A977
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

		// Token: 0x17008123 RID: 33059
		// (get) Token: 0x0602114D RID: 135501 RVA: 0x0030C788 File Offset: 0x0030A988
		// (set) Token: 0x0602114E RID: 135502 RVA: 0x0030C798 File Offset: 0x0030A998
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

		// Token: 0x17008124 RID: 33060
		// (get) Token: 0x0602114F RID: 135503 RVA: 0x0030C7A9 File Offset: 0x0030A9A9
		// (set) Token: 0x06021150 RID: 135504 RVA: 0x0030C7B9 File Offset: 0x0030A9B9
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

		// Token: 0x17008125 RID: 33061
		// (get) Token: 0x06021151 RID: 135505 RVA: 0x0030C7CA File Offset: 0x0030A9CA
		// (set) Token: 0x06021152 RID: 135506 RVA: 0x0030C7DA File Offset: 0x0030A9DA
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

		// Token: 0x17008126 RID: 33062
		// (get) Token: 0x06021153 RID: 135507 RVA: 0x0030C7EB File Offset: 0x0030A9EB
		// (set) Token: 0x06021154 RID: 135508 RVA: 0x0030C7FB File Offset: 0x0030A9FB
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

		// Token: 0x06021155 RID: 135509 RVA: 0x0030C80C File Offset: 0x0030AA0C
		public FUIWidget()
		{
		}

		// Token: 0x06021156 RID: 135510 RVA: 0x0030C814 File Offset: 0x0030AA14
		public FUIWidget(int depth, FColor color, FVector2D pivot, UIAnchorHorizontalAlign anchorHAlign, UIAnchorVerticalAlign anchorVAlign, float anchorOffsetX, float anchorOffsetY, float width, float height, float stretchLeft, float stretchRight, float stretchTop, float stretchBottom, FVector2D MinAnchor, FVector2D MaxAnchor, bool bCustomMinMaxAnchor, float AnchorXPercent, float AnchorYPercent, bool ShowXPercent, bool ShowYPercent)
		{
			this.depth = depth;
			this.color = color;
			this.pivot = pivot;
			this.anchorHAlign = anchorHAlign;
			this.anchorVAlign = anchorVAlign;
			this.anchorOffsetX = anchorOffsetX;
			this.anchorOffsetY = anchorOffsetY;
			this.width = width;
			this.height = height;
			this.stretchLeft = stretchLeft;
			this.stretchRight = stretchRight;
			this.stretchTop = stretchTop;
			this.stretchBottom = stretchBottom;
			this.MinAnchor = MinAnchor;
			this.MaxAnchor = MaxAnchor;
			this.bCustomMinMaxAnchor = bCustomMinMaxAnchor;
			this.AnchorXPercent = AnchorXPercent;
			this.AnchorYPercent = AnchorYPercent;
			this.ShowXPercent = ShowXPercent;
			this.ShowYPercent = ShowYPercent;
		}

		// Token: 0x06021157 RID: 135511 RVA: 0x0030C8C4 File Offset: 0x0030AAC4
		protected override IntPtr GetUStructPtr()
		{
			return FUIWidget.StaticStruct();
		}

		// Token: 0x06021158 RID: 135512 RVA: 0x0030C8D0 File Offset: 0x0030AAD0
		[NullableContext(2)]
		public FUIWidget(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021159 RID: 135513 RVA: 0x0030C8DA File Offset: 0x0030AADA
		public FUIWidget(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602115A RID: 135514 RVA: 0x0030C8E5 File Offset: 0x0030AAE5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FUIWidget(Pointer, false, true);
		}

		// Token: 0x0602115B RID: 135515 RVA: 0x0030C8EF File Offset: 0x0030AAEF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FUIWidget(Pointer, MemoryOwner);
		}

		// Token: 0x04011A49 RID: 72265
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.UIWidget";

		// Token: 0x04011A4A RID: 72266
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011A4B RID: 72267
		internal static int __PropertyOffset_depth;

		// Token: 0x04011A4C RID: 72268
		internal static int __PropertyOffset_color;

		// Token: 0x04011A4D RID: 72269
		internal static int __PropertyOffset_pivot;

		// Token: 0x04011A4E RID: 72270
		internal static int __PropertyOffset_anchorHAlign;

		// Token: 0x04011A4F RID: 72271
		internal static int __PropertyOffset_anchorVAlign;

		// Token: 0x04011A50 RID: 72272
		internal static int __PropertyOffset_anchorOffsetX;

		// Token: 0x04011A51 RID: 72273
		internal static int __PropertyOffset_anchorOffsetY;

		// Token: 0x04011A52 RID: 72274
		internal static int __PropertyOffset_width;

		// Token: 0x04011A53 RID: 72275
		internal static int __PropertyOffset_height;

		// Token: 0x04011A54 RID: 72276
		internal static int __PropertyOffset_stretchLeft;

		// Token: 0x04011A55 RID: 72277
		internal static int __PropertyOffset_stretchRight;

		// Token: 0x04011A56 RID: 72278
		internal static int __PropertyOffset_stretchTop;

		// Token: 0x04011A57 RID: 72279
		internal static int __PropertyOffset_stretchBottom;

		// Token: 0x04011A58 RID: 72280
		internal static int __PropertyOffset_MinAnchor;

		// Token: 0x04011A59 RID: 72281
		internal static int __PropertyOffset_MaxAnchor;

		// Token: 0x04011A5A RID: 72282
		internal static int __PropertyOffset_bCustomMinMaxAnchor;

		// Token: 0x04011A5B RID: 72283
		internal static int __PropertyOffset_AnchorXPercent;

		// Token: 0x04011A5C RID: 72284
		internal static int __PropertyOffset_AnchorYPercent;

		// Token: 0x04011A5D RID: 72285
		internal static int __PropertyOffset_ShowXPercent;

		// Token: 0x04011A5E RID: 72286
		internal static int __PropertyOffset_ShowYPercent;
	}
}
