using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200281B RID: 10267
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SlateCore.HeaderRowStyle")]
	[UnrealStructLayout(3432, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 3432)]
	public class FHeaderRowStyle : FSlateWidgetStyle, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026295 RID: 156309 RVA: 0x0039E896 File Offset: 0x0039CA96
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHeaderRowStyle._ScriptStructPtr != 0) ? FHeaderRowStyle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.HeaderRowStyle", ref FHeaderRowStyle._ScriptStructPtr);
		}

		// Token: 0x17009354 RID: 37716
		// (get) Token: 0x06026296 RID: 156310 RVA: 0x0039E8BC File Offset: 0x0039CABC
		// (set) Token: 0x06026297 RID: 156311 RVA: 0x0039E8FF File Offset: 0x0039CAFF
		public FTableColumnHeaderStyle ColumnStyle
		{
			get
			{
				base.FastCheckIsValid();
				FTableColumnHeaderStyle result;
				if ((result = this._ColumnStyle) == null)
				{
					result = (this._ColumnStyle = new FTableColumnHeaderStyle(base.NativePtr + (IntPtr)FHeaderRowStyle.__PropertyOffset_ColumnStyle, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTableColumnHeaderStyle.StaticStruct(), base.NativePtr + (IntPtr)FHeaderRowStyle.__PropertyOffset_ColumnStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009355 RID: 37717
		// (get) Token: 0x06026298 RID: 156312 RVA: 0x0039E920 File Offset: 0x0039CB20
		// (set) Token: 0x06026299 RID: 156313 RVA: 0x0039E963 File Offset: 0x0039CB63
		public FTableColumnHeaderStyle LastColumnStyle
		{
			get
			{
				base.FastCheckIsValid();
				FTableColumnHeaderStyle result;
				if ((result = this._LastColumnStyle) == null)
				{
					result = (this._LastColumnStyle = new FTableColumnHeaderStyle(base.NativePtr + (IntPtr)FHeaderRowStyle.__PropertyOffset_LastColumnStyle, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTableColumnHeaderStyle.StaticStruct(), base.NativePtr + (IntPtr)FHeaderRowStyle.__PropertyOffset_LastColumnStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009356 RID: 37718
		// (get) Token: 0x0602629A RID: 156314 RVA: 0x0039E984 File Offset: 0x0039CB84
		// (set) Token: 0x0602629B RID: 156315 RVA: 0x0039E9C7 File Offset: 0x0039CBC7
		public FSplitterStyle ColumnSplitterStyle
		{
			get
			{
				base.FastCheckIsValid();
				FSplitterStyle result;
				if ((result = this._ColumnSplitterStyle) == null)
				{
					result = (this._ColumnSplitterStyle = new FSplitterStyle(base.NativePtr + (IntPtr)FHeaderRowStyle.__PropertyOffset_ColumnSplitterStyle, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSplitterStyle.StaticStruct(), base.NativePtr + (IntPtr)FHeaderRowStyle.__PropertyOffset_ColumnSplitterStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009357 RID: 37719
		// (get) Token: 0x0602629C RID: 156316 RVA: 0x0039E9E8 File Offset: 0x0039CBE8
		// (set) Token: 0x0602629D RID: 156317 RVA: 0x0039EA2B File Offset: 0x0039CC2B
		public FSlateBrush BackgroundBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._BackgroundBrush) == null)
				{
					result = (this._BackgroundBrush = new FSlateBrush(base.NativePtr + (IntPtr)FHeaderRowStyle.__PropertyOffset_BackgroundBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FHeaderRowStyle.__PropertyOffset_BackgroundBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009358 RID: 37720
		// (get) Token: 0x0602629E RID: 156318 RVA: 0x0039EA4C File Offset: 0x0039CC4C
		// (set) Token: 0x0602629F RID: 156319 RVA: 0x0039EA8F File Offset: 0x0039CC8F
		public FSlateColor ForegroundColor
		{
			get
			{
				base.FastCheckIsValid();
				FSlateColor result;
				if ((result = this._ForegroundColor) == null)
				{
					result = (this._ForegroundColor = new FSlateColor(base.NativePtr + (IntPtr)FHeaderRowStyle.__PropertyOffset_ForegroundColor, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateColor.StaticStruct(), base.NativePtr + (IntPtr)FHeaderRowStyle.__PropertyOffset_ForegroundColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060262A0 RID: 156320 RVA: 0x0039EAB0 File Offset: 0x0039CCB0
		public FHeaderRowStyle()
		{
		}

		// Token: 0x060262A1 RID: 156321 RVA: 0x0039EAB8 File Offset: 0x0039CCB8
		public FHeaderRowStyle(FTableColumnHeaderStyle ColumnStyle, FTableColumnHeaderStyle LastColumnStyle, FSplitterStyle ColumnSplitterStyle, FSlateBrush BackgroundBrush, FSlateColor ForegroundColor)
		{
			this.ColumnStyle = ColumnStyle;
			this.LastColumnStyle = LastColumnStyle;
			this.ColumnSplitterStyle = ColumnSplitterStyle;
			this.BackgroundBrush = BackgroundBrush;
			this.ForegroundColor = ForegroundColor;
		}

		// Token: 0x060262A2 RID: 156322 RVA: 0x0039EAE5 File Offset: 0x0039CCE5
		protected override IntPtr GetUStructPtr()
		{
			return FHeaderRowStyle.StaticStruct();
		}

		// Token: 0x060262A3 RID: 156323 RVA: 0x0039EAF1 File Offset: 0x0039CCF1
		[NullableContext(2)]
		public FHeaderRowStyle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060262A4 RID: 156324 RVA: 0x0039EAFB File Offset: 0x0039CCFB
		public FHeaderRowStyle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060262A5 RID: 156325 RVA: 0x0039EB06 File Offset: 0x0039CD06
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHeaderRowStyle(Pointer, false, true);
		}

		// Token: 0x060262A6 RID: 156326 RVA: 0x0039EB10 File Offset: 0x0039CD10
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHeaderRowStyle(Pointer, MemoryOwner);
		}

		// Token: 0x04014E34 RID: 85556
		public new const string __ObjectPath = "/Script/SlateCore.HeaderRowStyle";

		// Token: 0x04014E35 RID: 85557
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014E36 RID: 85558
		internal static int __PropertyOffset_ColumnStyle;

		// Token: 0x04014E37 RID: 85559
		[Nullable(2)]
		private FTableColumnHeaderStyle _ColumnStyle;

		// Token: 0x04014E38 RID: 85560
		internal static int __PropertyOffset_LastColumnStyle;

		// Token: 0x04014E39 RID: 85561
		[Nullable(2)]
		private FTableColumnHeaderStyle _LastColumnStyle;

		// Token: 0x04014E3A RID: 85562
		internal static int __PropertyOffset_ColumnSplitterStyle;

		// Token: 0x04014E3B RID: 85563
		[Nullable(2)]
		private FSplitterStyle _ColumnSplitterStyle;

		// Token: 0x04014E3C RID: 85564
		internal static int __PropertyOffset_BackgroundBrush;

		// Token: 0x04014E3D RID: 85565
		[Nullable(2)]
		private FSlateBrush _BackgroundBrush;

		// Token: 0x04014E3E RID: 85566
		internal static int __PropertyOffset_ForegroundColor;

		// Token: 0x04014E3F RID: 85567
		[Nullable(2)]
		private FSlateColor _ForegroundColor;
	}
}
