using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020027F0 RID: 10224
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SlateCore.ComboButtonStyle")]
	[UnrealStructLayout(1136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1136)]
	public class FComboButtonStyle : FSlateWidgetStyle, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060261C2 RID: 156098 RVA: 0x0039D139 File Offset: 0x0039B339
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FComboButtonStyle._ScriptStructPtr != 0) ? FComboButtonStyle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.ComboButtonStyle", ref FComboButtonStyle._ScriptStructPtr);
		}

		// Token: 0x1700931D RID: 37661
		// (get) Token: 0x060261C3 RID: 156099 RVA: 0x0039D160 File Offset: 0x0039B360
		// (set) Token: 0x060261C4 RID: 156100 RVA: 0x0039D1A3 File Offset: 0x0039B3A3
		public FButtonStyle ButtonStyle
		{
			get
			{
				base.FastCheckIsValid();
				FButtonStyle result;
				if ((result = this._ButtonStyle) == null)
				{
					result = (this._ButtonStyle = new FButtonStyle(base.NativePtr + (IntPtr)FComboButtonStyle.__PropertyOffset_ButtonStyle, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FButtonStyle.StaticStruct(), base.NativePtr + (IntPtr)FComboButtonStyle.__PropertyOffset_ButtonStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700931E RID: 37662
		// (get) Token: 0x060261C5 RID: 156101 RVA: 0x0039D1C4 File Offset: 0x0039B3C4
		// (set) Token: 0x060261C6 RID: 156102 RVA: 0x0039D207 File Offset: 0x0039B407
		public FSlateBrush DownArrowImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._DownArrowImage) == null)
				{
					result = (this._DownArrowImage = new FSlateBrush(base.NativePtr + (IntPtr)FComboButtonStyle.__PropertyOffset_DownArrowImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FComboButtonStyle.__PropertyOffset_DownArrowImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700931F RID: 37663
		// (get) Token: 0x060261C7 RID: 156103 RVA: 0x0039D228 File Offset: 0x0039B428
		// (set) Token: 0x060261C8 RID: 156104 RVA: 0x0039D23C File Offset: 0x0039B43C
		public unsafe FVector2D ShadowOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FComboButtonStyle.__PropertyOffset_ShadowOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FComboButtonStyle.__PropertyOffset_ShadowOffset) = value;
			}
		}

		// Token: 0x17009320 RID: 37664
		// (get) Token: 0x060261C9 RID: 156105 RVA: 0x0039D251 File Offset: 0x0039B451
		// (set) Token: 0x060261CA RID: 156106 RVA: 0x0039D265 File Offset: 0x0039B465
		public unsafe FLinearColor ShadowColorAndOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FComboButtonStyle.__PropertyOffset_ShadowColorAndOpacity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FComboButtonStyle.__PropertyOffset_ShadowColorAndOpacity) = value;
			}
		}

		// Token: 0x17009321 RID: 37665
		// (get) Token: 0x060261CB RID: 156107 RVA: 0x0039D27C File Offset: 0x0039B47C
		// (set) Token: 0x060261CC RID: 156108 RVA: 0x0039D2BF File Offset: 0x0039B4BF
		public FSlateBrush MenuBorderBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._MenuBorderBrush) == null)
				{
					result = (this._MenuBorderBrush = new FSlateBrush(base.NativePtr + (IntPtr)FComboButtonStyle.__PropertyOffset_MenuBorderBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FComboButtonStyle.__PropertyOffset_MenuBorderBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009322 RID: 37666
		// (get) Token: 0x060261CD RID: 156109 RVA: 0x0039D2E0 File Offset: 0x0039B4E0
		// (set) Token: 0x060261CE RID: 156110 RVA: 0x0039D2F4 File Offset: 0x0039B4F4
		public unsafe FMargin MenuBorderPadding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FComboButtonStyle.__PropertyOffset_MenuBorderPadding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FComboButtonStyle.__PropertyOffset_MenuBorderPadding) = value;
			}
		}

		// Token: 0x060261CF RID: 156111 RVA: 0x0039D309 File Offset: 0x0039B509
		public FComboButtonStyle()
		{
		}

		// Token: 0x060261D0 RID: 156112 RVA: 0x0039D311 File Offset: 0x0039B511
		public FComboButtonStyle(FButtonStyle ButtonStyle, FSlateBrush DownArrowImage, FVector2D ShadowOffset, FLinearColor ShadowColorAndOpacity, FSlateBrush MenuBorderBrush, FMargin MenuBorderPadding)
		{
			this.ButtonStyle = ButtonStyle;
			this.DownArrowImage = DownArrowImage;
			this.ShadowOffset = ShadowOffset;
			this.ShadowColorAndOpacity = ShadowColorAndOpacity;
			this.MenuBorderBrush = MenuBorderBrush;
			this.MenuBorderPadding = MenuBorderPadding;
		}

		// Token: 0x060261D1 RID: 156113 RVA: 0x0039D346 File Offset: 0x0039B546
		protected override IntPtr GetUStructPtr()
		{
			return FComboButtonStyle.StaticStruct();
		}

		// Token: 0x060261D2 RID: 156114 RVA: 0x0039D352 File Offset: 0x0039B552
		[NullableContext(2)]
		public FComboButtonStyle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060261D3 RID: 156115 RVA: 0x0039D35C File Offset: 0x0039B55C
		public FComboButtonStyle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060261D4 RID: 156116 RVA: 0x0039D367 File Offset: 0x0039B567
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FComboButtonStyle(Pointer, false, true);
		}

		// Token: 0x060261D5 RID: 156117 RVA: 0x0039D371 File Offset: 0x0039B571
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FComboButtonStyle(Pointer, MemoryOwner);
		}

		// Token: 0x04014D12 RID: 85266
		public new const string __ObjectPath = "/Script/SlateCore.ComboButtonStyle";

		// Token: 0x04014D13 RID: 85267
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014D14 RID: 85268
		internal static int __PropertyOffset_ButtonStyle;

		// Token: 0x04014D15 RID: 85269
		[Nullable(2)]
		private FButtonStyle _ButtonStyle;

		// Token: 0x04014D16 RID: 85270
		internal static int __PropertyOffset_DownArrowImage;

		// Token: 0x04014D17 RID: 85271
		[Nullable(2)]
		private FSlateBrush _DownArrowImage;

		// Token: 0x04014D18 RID: 85272
		internal static int __PropertyOffset_ShadowOffset;

		// Token: 0x04014D19 RID: 85273
		internal static int __PropertyOffset_ShadowColorAndOpacity;

		// Token: 0x04014D1A RID: 85274
		internal static int __PropertyOffset_MenuBorderBrush;

		// Token: 0x04014D1B RID: 85275
		[Nullable(2)]
		private FSlateBrush _MenuBorderBrush;

		// Token: 0x04014D1C RID: 85276
		internal static int __PropertyOffset_MenuBorderPadding;
	}
}
