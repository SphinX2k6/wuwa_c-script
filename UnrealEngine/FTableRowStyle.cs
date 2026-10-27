using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002837 RID: 10295
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SlateCore.TableRowStyle")]
	[UnrealStructLayout(2328, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2328)]
	public class FTableRowStyle : FSlateWidgetStyle, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602640B RID: 156683 RVA: 0x003A129C File Offset: 0x0039F49C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTableRowStyle._ScriptStructPtr != 0) ? FTableRowStyle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.TableRowStyle", ref FTableRowStyle._ScriptStructPtr);
		}

		// Token: 0x170093AA RID: 37802
		// (get) Token: 0x0602640C RID: 156684 RVA: 0x003A12C0 File Offset: 0x0039F4C0
		// (set) Token: 0x0602640D RID: 156685 RVA: 0x003A1303 File Offset: 0x0039F503
		public FSlateBrush SelectorFocusedBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._SelectorFocusedBrush) == null)
				{
					result = (this._SelectorFocusedBrush = new FSlateBrush(base.NativePtr + (IntPtr)FTableRowStyle.__PropertyOffset_SelectorFocusedBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FTableRowStyle.__PropertyOffset_SelectorFocusedBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093AB RID: 37803
		// (get) Token: 0x0602640E RID: 156686 RVA: 0x003A1324 File Offset: 0x0039F524
		// (set) Token: 0x0602640F RID: 156687 RVA: 0x003A1367 File Offset: 0x0039F567
		public FSlateBrush ActiveHoveredBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._ActiveHoveredBrush) == null)
				{
					result = (this._ActiveHoveredBrush = new FSlateBrush(base.NativePtr + (IntPtr)FTableRowStyle.__PropertyOffset_ActiveHoveredBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FTableRowStyle.__PropertyOffset_ActiveHoveredBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093AC RID: 37804
		// (get) Token: 0x06026410 RID: 156688 RVA: 0x003A1388 File Offset: 0x0039F588
		// (set) Token: 0x06026411 RID: 156689 RVA: 0x003A13CB File Offset: 0x0039F5CB
		public FSlateBrush ActiveBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._ActiveBrush) == null)
				{
					result = (this._ActiveBrush = new FSlateBrush(base.NativePtr + (IntPtr)FTableRowStyle.__PropertyOffset_ActiveBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FTableRowStyle.__PropertyOffset_ActiveBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093AD RID: 37805
		// (get) Token: 0x06026412 RID: 156690 RVA: 0x003A13EC File Offset: 0x0039F5EC
		// (set) Token: 0x06026413 RID: 156691 RVA: 0x003A142F File Offset: 0x0039F62F
		public FSlateBrush InactiveHoveredBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._InactiveHoveredBrush) == null)
				{
					result = (this._InactiveHoveredBrush = new FSlateBrush(base.NativePtr + (IntPtr)FTableRowStyle.__PropertyOffset_InactiveHoveredBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FTableRowStyle.__PropertyOffset_InactiveHoveredBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093AE RID: 37806
		// (get) Token: 0x06026414 RID: 156692 RVA: 0x003A1450 File Offset: 0x0039F650
		// (set) Token: 0x06026415 RID: 156693 RVA: 0x003A1493 File Offset: 0x0039F693
		public FSlateBrush InactiveBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._InactiveBrush) == null)
				{
					result = (this._InactiveBrush = new FSlateBrush(base.NativePtr + (IntPtr)FTableRowStyle.__PropertyOffset_InactiveBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FTableRowStyle.__PropertyOffset_InactiveBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093AF RID: 37807
		// (get) Token: 0x06026416 RID: 156694 RVA: 0x003A14B4 File Offset: 0x0039F6B4
		// (set) Token: 0x06026417 RID: 156695 RVA: 0x003A14F7 File Offset: 0x0039F6F7
		public FSlateBrush EvenRowBackgroundHoveredBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._EvenRowBackgroundHoveredBrush) == null)
				{
					result = (this._EvenRowBackgroundHoveredBrush = new FSlateBrush(base.NativePtr + (IntPtr)FTableRowStyle.__PropertyOffset_EvenRowBackgroundHoveredBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FTableRowStyle.__PropertyOffset_EvenRowBackgroundHoveredBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093B0 RID: 37808
		// (get) Token: 0x06026418 RID: 156696 RVA: 0x003A1518 File Offset: 0x0039F718
		// (set) Token: 0x06026419 RID: 156697 RVA: 0x003A155B File Offset: 0x0039F75B
		public FSlateBrush EvenRowBackgroundBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._EvenRowBackgroundBrush) == null)
				{
					result = (this._EvenRowBackgroundBrush = new FSlateBrush(base.NativePtr + (IntPtr)FTableRowStyle.__PropertyOffset_EvenRowBackgroundBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FTableRowStyle.__PropertyOffset_EvenRowBackgroundBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093B1 RID: 37809
		// (get) Token: 0x0602641A RID: 156698 RVA: 0x003A157C File Offset: 0x0039F77C
		// (set) Token: 0x0602641B RID: 156699 RVA: 0x003A15BF File Offset: 0x0039F7BF
		public FSlateBrush OddRowBackgroundHoveredBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._OddRowBackgroundHoveredBrush) == null)
				{
					result = (this._OddRowBackgroundHoveredBrush = new FSlateBrush(base.NativePtr + (IntPtr)FTableRowStyle.__PropertyOffset_OddRowBackgroundHoveredBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FTableRowStyle.__PropertyOffset_OddRowBackgroundHoveredBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093B2 RID: 37810
		// (get) Token: 0x0602641C RID: 156700 RVA: 0x003A15E0 File Offset: 0x0039F7E0
		// (set) Token: 0x0602641D RID: 156701 RVA: 0x003A1623 File Offset: 0x0039F823
		public FSlateBrush OddRowBackgroundBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._OddRowBackgroundBrush) == null)
				{
					result = (this._OddRowBackgroundBrush = new FSlateBrush(base.NativePtr + (IntPtr)FTableRowStyle.__PropertyOffset_OddRowBackgroundBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FTableRowStyle.__PropertyOffset_OddRowBackgroundBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093B3 RID: 37811
		// (get) Token: 0x0602641E RID: 156702 RVA: 0x003A1644 File Offset: 0x0039F844
		// (set) Token: 0x0602641F RID: 156703 RVA: 0x003A1687 File Offset: 0x0039F887
		public FSlateColor TextColor
		{
			get
			{
				base.FastCheckIsValid();
				FSlateColor result;
				if ((result = this._TextColor) == null)
				{
					result = (this._TextColor = new FSlateColor(base.NativePtr + (IntPtr)FTableRowStyle.__PropertyOffset_TextColor, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateColor.StaticStruct(), base.NativePtr + (IntPtr)FTableRowStyle.__PropertyOffset_TextColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093B4 RID: 37812
		// (get) Token: 0x06026420 RID: 156704 RVA: 0x003A16A8 File Offset: 0x0039F8A8
		// (set) Token: 0x06026421 RID: 156705 RVA: 0x003A16EB File Offset: 0x0039F8EB
		public FSlateColor SelectedTextColor
		{
			get
			{
				base.FastCheckIsValid();
				FSlateColor result;
				if ((result = this._SelectedTextColor) == null)
				{
					result = (this._SelectedTextColor = new FSlateColor(base.NativePtr + (IntPtr)FTableRowStyle.__PropertyOffset_SelectedTextColor, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateColor.StaticStruct(), base.NativePtr + (IntPtr)FTableRowStyle.__PropertyOffset_SelectedTextColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093B5 RID: 37813
		// (get) Token: 0x06026422 RID: 156706 RVA: 0x003A170C File Offset: 0x0039F90C
		// (set) Token: 0x06026423 RID: 156707 RVA: 0x003A174F File Offset: 0x0039F94F
		public FSlateBrush DropIndicator_Above
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._DropIndicator_Above) == null)
				{
					result = (this._DropIndicator_Above = new FSlateBrush(base.NativePtr + (IntPtr)FTableRowStyle.__PropertyOffset_DropIndicator_Above, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FTableRowStyle.__PropertyOffset_DropIndicator_Above, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093B6 RID: 37814
		// (get) Token: 0x06026424 RID: 156708 RVA: 0x003A1770 File Offset: 0x0039F970
		// (set) Token: 0x06026425 RID: 156709 RVA: 0x003A17B3 File Offset: 0x0039F9B3
		public FSlateBrush DropIndicator_Onto
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._DropIndicator_Onto) == null)
				{
					result = (this._DropIndicator_Onto = new FSlateBrush(base.NativePtr + (IntPtr)FTableRowStyle.__PropertyOffset_DropIndicator_Onto, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FTableRowStyle.__PropertyOffset_DropIndicator_Onto, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093B7 RID: 37815
		// (get) Token: 0x06026426 RID: 156710 RVA: 0x003A17D4 File Offset: 0x0039F9D4
		// (set) Token: 0x06026427 RID: 156711 RVA: 0x003A1817 File Offset: 0x0039FA17
		public FSlateBrush DropIndicator_Below
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._DropIndicator_Below) == null)
				{
					result = (this._DropIndicator_Below = new FSlateBrush(base.NativePtr + (IntPtr)FTableRowStyle.__PropertyOffset_DropIndicator_Below, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FTableRowStyle.__PropertyOffset_DropIndicator_Below, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093B8 RID: 37816
		// (get) Token: 0x06026428 RID: 156712 RVA: 0x003A1838 File Offset: 0x0039FA38
		// (set) Token: 0x06026429 RID: 156713 RVA: 0x003A187B File Offset: 0x0039FA7B
		public FSlateBrush ActiveHighlightedBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._ActiveHighlightedBrush) == null)
				{
					result = (this._ActiveHighlightedBrush = new FSlateBrush(base.NativePtr + (IntPtr)FTableRowStyle.__PropertyOffset_ActiveHighlightedBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FTableRowStyle.__PropertyOffset_ActiveHighlightedBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093B9 RID: 37817
		// (get) Token: 0x0602642A RID: 156714 RVA: 0x003A189C File Offset: 0x0039FA9C
		// (set) Token: 0x0602642B RID: 156715 RVA: 0x003A18DF File Offset: 0x0039FADF
		public FSlateBrush InactiveHighlightedBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._InactiveHighlightedBrush) == null)
				{
					result = (this._InactiveHighlightedBrush = new FSlateBrush(base.NativePtr + (IntPtr)FTableRowStyle.__PropertyOffset_InactiveHighlightedBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FTableRowStyle.__PropertyOffset_InactiveHighlightedBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602642C RID: 156716 RVA: 0x003A1900 File Offset: 0x0039FB00
		public FTableRowStyle()
		{
		}

		// Token: 0x0602642D RID: 156717 RVA: 0x003A1908 File Offset: 0x0039FB08
		public FTableRowStyle(FSlateBrush SelectorFocusedBrush, FSlateBrush ActiveHoveredBrush, FSlateBrush ActiveBrush, FSlateBrush InactiveHoveredBrush, FSlateBrush InactiveBrush, FSlateBrush EvenRowBackgroundHoveredBrush, FSlateBrush EvenRowBackgroundBrush, FSlateBrush OddRowBackgroundHoveredBrush, FSlateBrush OddRowBackgroundBrush, FSlateColor TextColor, FSlateColor SelectedTextColor, FSlateBrush DropIndicator_Above, FSlateBrush DropIndicator_Onto, FSlateBrush DropIndicator_Below, FSlateBrush ActiveHighlightedBrush, FSlateBrush InactiveHighlightedBrush)
		{
			this.SelectorFocusedBrush = SelectorFocusedBrush;
			this.ActiveHoveredBrush = ActiveHoveredBrush;
			this.ActiveBrush = ActiveBrush;
			this.InactiveHoveredBrush = InactiveHoveredBrush;
			this.InactiveBrush = InactiveBrush;
			this.EvenRowBackgroundHoveredBrush = EvenRowBackgroundHoveredBrush;
			this.EvenRowBackgroundBrush = EvenRowBackgroundBrush;
			this.OddRowBackgroundHoveredBrush = OddRowBackgroundHoveredBrush;
			this.OddRowBackgroundBrush = OddRowBackgroundBrush;
			this.TextColor = TextColor;
			this.SelectedTextColor = SelectedTextColor;
			this.DropIndicator_Above = DropIndicator_Above;
			this.DropIndicator_Onto = DropIndicator_Onto;
			this.DropIndicator_Below = DropIndicator_Below;
			this.ActiveHighlightedBrush = ActiveHighlightedBrush;
			this.InactiveHighlightedBrush = InactiveHighlightedBrush;
		}

		// Token: 0x0602642E RID: 156718 RVA: 0x003A1998 File Offset: 0x0039FB98
		protected override IntPtr GetUStructPtr()
		{
			return FTableRowStyle.StaticStruct();
		}

		// Token: 0x0602642F RID: 156719 RVA: 0x003A19A4 File Offset: 0x0039FBA4
		[NullableContext(2)]
		public FTableRowStyle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026430 RID: 156720 RVA: 0x003A19AE File Offset: 0x0039FBAE
		public FTableRowStyle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026431 RID: 156721 RVA: 0x003A19B9 File Offset: 0x0039FBB9
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTableRowStyle(Pointer, false, true);
		}

		// Token: 0x06026432 RID: 156722 RVA: 0x003A19C3 File Offset: 0x0039FBC3
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTableRowStyle(Pointer, MemoryOwner);
		}

		// Token: 0x04014F07 RID: 85767
		public new const string __ObjectPath = "/Script/SlateCore.TableRowStyle";

		// Token: 0x04014F08 RID: 85768
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014F09 RID: 85769
		internal static int __PropertyOffset_SelectorFocusedBrush;

		// Token: 0x04014F0A RID: 85770
		[Nullable(2)]
		private FSlateBrush _SelectorFocusedBrush;

		// Token: 0x04014F0B RID: 85771
		internal static int __PropertyOffset_ActiveHoveredBrush;

		// Token: 0x04014F0C RID: 85772
		[Nullable(2)]
		private FSlateBrush _ActiveHoveredBrush;

		// Token: 0x04014F0D RID: 85773
		internal static int __PropertyOffset_ActiveBrush;

		// Token: 0x04014F0E RID: 85774
		[Nullable(2)]
		private FSlateBrush _ActiveBrush;

		// Token: 0x04014F0F RID: 85775
		internal static int __PropertyOffset_InactiveHoveredBrush;

		// Token: 0x04014F10 RID: 85776
		[Nullable(2)]
		private FSlateBrush _InactiveHoveredBrush;

		// Token: 0x04014F11 RID: 85777
		internal static int __PropertyOffset_InactiveBrush;

		// Token: 0x04014F12 RID: 85778
		[Nullable(2)]
		private FSlateBrush _InactiveBrush;

		// Token: 0x04014F13 RID: 85779
		internal static int __PropertyOffset_EvenRowBackgroundHoveredBrush;

		// Token: 0x04014F14 RID: 85780
		[Nullable(2)]
		private FSlateBrush _EvenRowBackgroundHoveredBrush;

		// Token: 0x04014F15 RID: 85781
		internal static int __PropertyOffset_EvenRowBackgroundBrush;

		// Token: 0x04014F16 RID: 85782
		[Nullable(2)]
		private FSlateBrush _EvenRowBackgroundBrush;

		// Token: 0x04014F17 RID: 85783
		internal static int __PropertyOffset_OddRowBackgroundHoveredBrush;

		// Token: 0x04014F18 RID: 85784
		[Nullable(2)]
		private FSlateBrush _OddRowBackgroundHoveredBrush;

		// Token: 0x04014F19 RID: 85785
		internal static int __PropertyOffset_OddRowBackgroundBrush;

		// Token: 0x04014F1A RID: 85786
		[Nullable(2)]
		private FSlateBrush _OddRowBackgroundBrush;

		// Token: 0x04014F1B RID: 85787
		internal static int __PropertyOffset_TextColor;

		// Token: 0x04014F1C RID: 85788
		[Nullable(2)]
		private FSlateColor _TextColor;

		// Token: 0x04014F1D RID: 85789
		internal static int __PropertyOffset_SelectedTextColor;

		// Token: 0x04014F1E RID: 85790
		[Nullable(2)]
		private FSlateColor _SelectedTextColor;

		// Token: 0x04014F1F RID: 85791
		internal static int __PropertyOffset_DropIndicator_Above;

		// Token: 0x04014F20 RID: 85792
		[Nullable(2)]
		private FSlateBrush _DropIndicator_Above;

		// Token: 0x04014F21 RID: 85793
		internal static int __PropertyOffset_DropIndicator_Onto;

		// Token: 0x04014F22 RID: 85794
		[Nullable(2)]
		private FSlateBrush _DropIndicator_Onto;

		// Token: 0x04014F23 RID: 85795
		internal static int __PropertyOffset_DropIndicator_Below;

		// Token: 0x04014F24 RID: 85796
		[Nullable(2)]
		private FSlateBrush _DropIndicator_Below;

		// Token: 0x04014F25 RID: 85797
		internal static int __PropertyOffset_ActiveHighlightedBrush;

		// Token: 0x04014F26 RID: 85798
		[Nullable(2)]
		private FSlateBrush _ActiveHighlightedBrush;

		// Token: 0x04014F27 RID: 85799
		internal static int __PropertyOffset_InactiveHighlightedBrush;

		// Token: 0x04014F28 RID: 85800
		[Nullable(2)]
		private FSlateBrush _InactiveHighlightedBrush;
	}
}
