using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200283C RID: 10300
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SlateCore.WindowStyle")]
	[UnrealStructLayout(4992, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4992)]
	public class FWindowStyle : FSlateWidgetStyle, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026477 RID: 156791 RVA: 0x003A2211 File Offset: 0x003A0411
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWindowStyle._ScriptStructPtr != 0) ? FWindowStyle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.WindowStyle", ref FWindowStyle._ScriptStructPtr);
		}

		// Token: 0x170093CC RID: 37836
		// (get) Token: 0x06026478 RID: 156792 RVA: 0x003A2238 File Offset: 0x003A0438
		// (set) Token: 0x06026479 RID: 156793 RVA: 0x003A227B File Offset: 0x003A047B
		public FButtonStyle MinimizeButtonStyle
		{
			get
			{
				base.FastCheckIsValid();
				FButtonStyle result;
				if ((result = this._MinimizeButtonStyle) == null)
				{
					result = (this._MinimizeButtonStyle = new FButtonStyle(base.NativePtr + (IntPtr)FWindowStyle.__PropertyOffset_MinimizeButtonStyle, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FButtonStyle.StaticStruct(), base.NativePtr + (IntPtr)FWindowStyle.__PropertyOffset_MinimizeButtonStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093CD RID: 37837
		// (get) Token: 0x0602647A RID: 156794 RVA: 0x003A229C File Offset: 0x003A049C
		// (set) Token: 0x0602647B RID: 156795 RVA: 0x003A22DF File Offset: 0x003A04DF
		public FButtonStyle MaximizeButtonStyle
		{
			get
			{
				base.FastCheckIsValid();
				FButtonStyle result;
				if ((result = this._MaximizeButtonStyle) == null)
				{
					result = (this._MaximizeButtonStyle = new FButtonStyle(base.NativePtr + (IntPtr)FWindowStyle.__PropertyOffset_MaximizeButtonStyle, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FButtonStyle.StaticStruct(), base.NativePtr + (IntPtr)FWindowStyle.__PropertyOffset_MaximizeButtonStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093CE RID: 37838
		// (get) Token: 0x0602647C RID: 156796 RVA: 0x003A2300 File Offset: 0x003A0500
		// (set) Token: 0x0602647D RID: 156797 RVA: 0x003A2343 File Offset: 0x003A0543
		public FButtonStyle RestoreButtonStyle
		{
			get
			{
				base.FastCheckIsValid();
				FButtonStyle result;
				if ((result = this._RestoreButtonStyle) == null)
				{
					result = (this._RestoreButtonStyle = new FButtonStyle(base.NativePtr + (IntPtr)FWindowStyle.__PropertyOffset_RestoreButtonStyle, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FButtonStyle.StaticStruct(), base.NativePtr + (IntPtr)FWindowStyle.__PropertyOffset_RestoreButtonStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093CF RID: 37839
		// (get) Token: 0x0602647E RID: 156798 RVA: 0x003A2364 File Offset: 0x003A0564
		// (set) Token: 0x0602647F RID: 156799 RVA: 0x003A23A7 File Offset: 0x003A05A7
		public FButtonStyle CloseButtonStyle
		{
			get
			{
				base.FastCheckIsValid();
				FButtonStyle result;
				if ((result = this._CloseButtonStyle) == null)
				{
					result = (this._CloseButtonStyle = new FButtonStyle(base.NativePtr + (IntPtr)FWindowStyle.__PropertyOffset_CloseButtonStyle, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FButtonStyle.StaticStruct(), base.NativePtr + (IntPtr)FWindowStyle.__PropertyOffset_CloseButtonStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093D0 RID: 37840
		// (get) Token: 0x06026480 RID: 156800 RVA: 0x003A23C8 File Offset: 0x003A05C8
		// (set) Token: 0x06026481 RID: 156801 RVA: 0x003A240B File Offset: 0x003A060B
		public FTextBlockStyle TitleTextStyle
		{
			get
			{
				base.FastCheckIsValid();
				FTextBlockStyle result;
				if ((result = this._TitleTextStyle) == null)
				{
					result = (this._TitleTextStyle = new FTextBlockStyle(base.NativePtr + (IntPtr)FWindowStyle.__PropertyOffset_TitleTextStyle, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextBlockStyle.StaticStruct(), base.NativePtr + (IntPtr)FWindowStyle.__PropertyOffset_TitleTextStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093D1 RID: 37841
		// (get) Token: 0x06026482 RID: 156802 RVA: 0x003A242C File Offset: 0x003A062C
		// (set) Token: 0x06026483 RID: 156803 RVA: 0x003A246F File Offset: 0x003A066F
		public FSlateBrush ActiveTitleBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._ActiveTitleBrush) == null)
				{
					result = (this._ActiveTitleBrush = new FSlateBrush(base.NativePtr + (IntPtr)FWindowStyle.__PropertyOffset_ActiveTitleBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FWindowStyle.__PropertyOffset_ActiveTitleBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093D2 RID: 37842
		// (get) Token: 0x06026484 RID: 156804 RVA: 0x003A2490 File Offset: 0x003A0690
		// (set) Token: 0x06026485 RID: 156805 RVA: 0x003A24D3 File Offset: 0x003A06D3
		public FSlateBrush InactiveTitleBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._InactiveTitleBrush) == null)
				{
					result = (this._InactiveTitleBrush = new FSlateBrush(base.NativePtr + (IntPtr)FWindowStyle.__PropertyOffset_InactiveTitleBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FWindowStyle.__PropertyOffset_InactiveTitleBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093D3 RID: 37843
		// (get) Token: 0x06026486 RID: 156806 RVA: 0x003A24F4 File Offset: 0x003A06F4
		// (set) Token: 0x06026487 RID: 156807 RVA: 0x003A2537 File Offset: 0x003A0737
		public FSlateBrush FlashTitleBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._FlashTitleBrush) == null)
				{
					result = (this._FlashTitleBrush = new FSlateBrush(base.NativePtr + (IntPtr)FWindowStyle.__PropertyOffset_FlashTitleBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FWindowStyle.__PropertyOffset_FlashTitleBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093D4 RID: 37844
		// (get) Token: 0x06026488 RID: 156808 RVA: 0x003A2558 File Offset: 0x003A0758
		// (set) Token: 0x06026489 RID: 156809 RVA: 0x003A259B File Offset: 0x003A079B
		public FSlateColor BackgroundColor
		{
			get
			{
				base.FastCheckIsValid();
				FSlateColor result;
				if ((result = this._BackgroundColor) == null)
				{
					result = (this._BackgroundColor = new FSlateColor(base.NativePtr + (IntPtr)FWindowStyle.__PropertyOffset_BackgroundColor, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateColor.StaticStruct(), base.NativePtr + (IntPtr)FWindowStyle.__PropertyOffset_BackgroundColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093D5 RID: 37845
		// (get) Token: 0x0602648A RID: 156810 RVA: 0x003A25BC File Offset: 0x003A07BC
		// (set) Token: 0x0602648B RID: 156811 RVA: 0x003A25FF File Offset: 0x003A07FF
		public FSlateBrush OutlineBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._OutlineBrush) == null)
				{
					result = (this._OutlineBrush = new FSlateBrush(base.NativePtr + (IntPtr)FWindowStyle.__PropertyOffset_OutlineBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FWindowStyle.__PropertyOffset_OutlineBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093D6 RID: 37846
		// (get) Token: 0x0602648C RID: 156812 RVA: 0x003A2620 File Offset: 0x003A0820
		// (set) Token: 0x0602648D RID: 156813 RVA: 0x003A2663 File Offset: 0x003A0863
		public FSlateColor OutlineColor
		{
			get
			{
				base.FastCheckIsValid();
				FSlateColor result;
				if ((result = this._OutlineColor) == null)
				{
					result = (this._OutlineColor = new FSlateColor(base.NativePtr + (IntPtr)FWindowStyle.__PropertyOffset_OutlineColor, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateColor.StaticStruct(), base.NativePtr + (IntPtr)FWindowStyle.__PropertyOffset_OutlineColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093D7 RID: 37847
		// (get) Token: 0x0602648E RID: 156814 RVA: 0x003A2684 File Offset: 0x003A0884
		// (set) Token: 0x0602648F RID: 156815 RVA: 0x003A26C7 File Offset: 0x003A08C7
		public FSlateBrush BorderBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._BorderBrush) == null)
				{
					result = (this._BorderBrush = new FSlateBrush(base.NativePtr + (IntPtr)FWindowStyle.__PropertyOffset_BorderBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FWindowStyle.__PropertyOffset_BorderBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093D8 RID: 37848
		// (get) Token: 0x06026490 RID: 156816 RVA: 0x003A26E8 File Offset: 0x003A08E8
		// (set) Token: 0x06026491 RID: 156817 RVA: 0x003A272B File Offset: 0x003A092B
		public FSlateBrush BackgroundBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._BackgroundBrush) == null)
				{
					result = (this._BackgroundBrush = new FSlateBrush(base.NativePtr + (IntPtr)FWindowStyle.__PropertyOffset_BackgroundBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FWindowStyle.__PropertyOffset_BackgroundBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093D9 RID: 37849
		// (get) Token: 0x06026492 RID: 156818 RVA: 0x003A274C File Offset: 0x003A094C
		// (set) Token: 0x06026493 RID: 156819 RVA: 0x003A278F File Offset: 0x003A098F
		public FSlateBrush ChildBackgroundBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._ChildBackgroundBrush) == null)
				{
					result = (this._ChildBackgroundBrush = new FSlateBrush(base.NativePtr + (IntPtr)FWindowStyle.__PropertyOffset_ChildBackgroundBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FWindowStyle.__PropertyOffset_ChildBackgroundBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06026494 RID: 156820 RVA: 0x003A27B0 File Offset: 0x003A09B0
		public FWindowStyle()
		{
		}

		// Token: 0x06026495 RID: 156821 RVA: 0x003A27B8 File Offset: 0x003A09B8
		public FWindowStyle(FButtonStyle MinimizeButtonStyle, FButtonStyle MaximizeButtonStyle, FButtonStyle RestoreButtonStyle, FButtonStyle CloseButtonStyle, FTextBlockStyle TitleTextStyle, FSlateBrush ActiveTitleBrush, FSlateBrush InactiveTitleBrush, FSlateBrush FlashTitleBrush, FSlateColor BackgroundColor, FSlateBrush OutlineBrush, FSlateColor OutlineColor, FSlateBrush BorderBrush, FSlateBrush BackgroundBrush, FSlateBrush ChildBackgroundBrush)
		{
			this.MinimizeButtonStyle = MinimizeButtonStyle;
			this.MaximizeButtonStyle = MaximizeButtonStyle;
			this.RestoreButtonStyle = RestoreButtonStyle;
			this.CloseButtonStyle = CloseButtonStyle;
			this.TitleTextStyle = TitleTextStyle;
			this.ActiveTitleBrush = ActiveTitleBrush;
			this.InactiveTitleBrush = InactiveTitleBrush;
			this.FlashTitleBrush = FlashTitleBrush;
			this.BackgroundColor = BackgroundColor;
			this.OutlineBrush = OutlineBrush;
			this.OutlineColor = OutlineColor;
			this.BorderBrush = BorderBrush;
			this.BackgroundBrush = BackgroundBrush;
			this.ChildBackgroundBrush = ChildBackgroundBrush;
		}

		// Token: 0x06026496 RID: 156822 RVA: 0x003A2838 File Offset: 0x003A0A38
		protected override IntPtr GetUStructPtr()
		{
			return FWindowStyle.StaticStruct();
		}

		// Token: 0x06026497 RID: 156823 RVA: 0x003A2844 File Offset: 0x003A0A44
		[NullableContext(2)]
		public FWindowStyle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026498 RID: 156824 RVA: 0x003A284E File Offset: 0x003A0A4E
		public FWindowStyle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026499 RID: 156825 RVA: 0x003A2859 File Offset: 0x003A0A59
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWindowStyle(Pointer, false, true);
		}

		// Token: 0x0602649A RID: 156826 RVA: 0x003A2863 File Offset: 0x003A0A63
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWindowStyle(Pointer, MemoryOwner);
		}

		// Token: 0x04014F51 RID: 85841
		public new const string __ObjectPath = "/Script/SlateCore.WindowStyle";

		// Token: 0x04014F52 RID: 85842
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014F53 RID: 85843
		internal static int __PropertyOffset_MinimizeButtonStyle;

		// Token: 0x04014F54 RID: 85844
		[Nullable(2)]
		private FButtonStyle _MinimizeButtonStyle;

		// Token: 0x04014F55 RID: 85845
		internal static int __PropertyOffset_MaximizeButtonStyle;

		// Token: 0x04014F56 RID: 85846
		[Nullable(2)]
		private FButtonStyle _MaximizeButtonStyle;

		// Token: 0x04014F57 RID: 85847
		internal static int __PropertyOffset_RestoreButtonStyle;

		// Token: 0x04014F58 RID: 85848
		[Nullable(2)]
		private FButtonStyle _RestoreButtonStyle;

		// Token: 0x04014F59 RID: 85849
		internal static int __PropertyOffset_CloseButtonStyle;

		// Token: 0x04014F5A RID: 85850
		[Nullable(2)]
		private FButtonStyle _CloseButtonStyle;

		// Token: 0x04014F5B RID: 85851
		internal static int __PropertyOffset_TitleTextStyle;

		// Token: 0x04014F5C RID: 85852
		[Nullable(2)]
		private FTextBlockStyle _TitleTextStyle;

		// Token: 0x04014F5D RID: 85853
		internal static int __PropertyOffset_ActiveTitleBrush;

		// Token: 0x04014F5E RID: 85854
		[Nullable(2)]
		private FSlateBrush _ActiveTitleBrush;

		// Token: 0x04014F5F RID: 85855
		internal static int __PropertyOffset_InactiveTitleBrush;

		// Token: 0x04014F60 RID: 85856
		[Nullable(2)]
		private FSlateBrush _InactiveTitleBrush;

		// Token: 0x04014F61 RID: 85857
		internal static int __PropertyOffset_FlashTitleBrush;

		// Token: 0x04014F62 RID: 85858
		[Nullable(2)]
		private FSlateBrush _FlashTitleBrush;

		// Token: 0x04014F63 RID: 85859
		internal static int __PropertyOffset_BackgroundColor;

		// Token: 0x04014F64 RID: 85860
		[Nullable(2)]
		private FSlateColor _BackgroundColor;

		// Token: 0x04014F65 RID: 85861
		internal static int __PropertyOffset_OutlineBrush;

		// Token: 0x04014F66 RID: 85862
		[Nullable(2)]
		private FSlateBrush _OutlineBrush;

		// Token: 0x04014F67 RID: 85863
		internal static int __PropertyOffset_OutlineColor;

		// Token: 0x04014F68 RID: 85864
		[Nullable(2)]
		private FSlateColor _OutlineColor;

		// Token: 0x04014F69 RID: 85865
		internal static int __PropertyOffset_BorderBrush;

		// Token: 0x04014F6A RID: 85866
		[Nullable(2)]
		private FSlateBrush _BorderBrush;

		// Token: 0x04014F6B RID: 85867
		internal static int __PropertyOffset_BackgroundBrush;

		// Token: 0x04014F6C RID: 85868
		[Nullable(2)]
		private FSlateBrush _BackgroundBrush;

		// Token: 0x04014F6D RID: 85869
		internal static int __PropertyOffset_ChildBackgroundBrush;

		// Token: 0x04014F6E RID: 85870
		[Nullable(2)]
		private FSlateBrush _ChildBackgroundBrush;
	}
}
