using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020027F4 RID: 10228
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SlateCore.DockTabStyle")]
	[UnrealStructLayout(2120, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2120)]
	public class FDockTabStyle : FSlateWidgetStyle, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060261FC RID: 156156 RVA: 0x0039D710 File Offset: 0x0039B910
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDockTabStyle._ScriptStructPtr != 0) ? FDockTabStyle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.DockTabStyle", ref FDockTabStyle._ScriptStructPtr);
		}

		// Token: 0x1700932A RID: 37674
		// (get) Token: 0x060261FD RID: 156157 RVA: 0x0039D734 File Offset: 0x0039B934
		// (set) Token: 0x060261FE RID: 156158 RVA: 0x0039D777 File Offset: 0x0039B977
		public FButtonStyle CloseButtonStyle
		{
			get
			{
				base.FastCheckIsValid();
				FButtonStyle result;
				if ((result = this._CloseButtonStyle) == null)
				{
					result = (this._CloseButtonStyle = new FButtonStyle(base.NativePtr + (IntPtr)FDockTabStyle.__PropertyOffset_CloseButtonStyle, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FButtonStyle.StaticStruct(), base.NativePtr + (IntPtr)FDockTabStyle.__PropertyOffset_CloseButtonStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700932B RID: 37675
		// (get) Token: 0x060261FF RID: 156159 RVA: 0x0039D798 File Offset: 0x0039B998
		// (set) Token: 0x06026200 RID: 156160 RVA: 0x0039D7DB File Offset: 0x0039B9DB
		public FSlateBrush NormalBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._NormalBrush) == null)
				{
					result = (this._NormalBrush = new FSlateBrush(base.NativePtr + (IntPtr)FDockTabStyle.__PropertyOffset_NormalBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FDockTabStyle.__PropertyOffset_NormalBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700932C RID: 37676
		// (get) Token: 0x06026201 RID: 156161 RVA: 0x0039D7FC File Offset: 0x0039B9FC
		// (set) Token: 0x06026202 RID: 156162 RVA: 0x0039D83F File Offset: 0x0039BA3F
		public FSlateBrush ActiveBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._ActiveBrush) == null)
				{
					result = (this._ActiveBrush = new FSlateBrush(base.NativePtr + (IntPtr)FDockTabStyle.__PropertyOffset_ActiveBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FDockTabStyle.__PropertyOffset_ActiveBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700932D RID: 37677
		// (get) Token: 0x06026203 RID: 156163 RVA: 0x0039D860 File Offset: 0x0039BA60
		// (set) Token: 0x06026204 RID: 156164 RVA: 0x0039D8A3 File Offset: 0x0039BAA3
		public FSlateBrush ColorOverlayTabBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._ColorOverlayTabBrush) == null)
				{
					result = (this._ColorOverlayTabBrush = new FSlateBrush(base.NativePtr + (IntPtr)FDockTabStyle.__PropertyOffset_ColorOverlayTabBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FDockTabStyle.__PropertyOffset_ColorOverlayTabBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700932E RID: 37678
		// (get) Token: 0x06026205 RID: 156165 RVA: 0x0039D8C4 File Offset: 0x0039BAC4
		// (set) Token: 0x06026206 RID: 156166 RVA: 0x0039D907 File Offset: 0x0039BB07
		public FSlateBrush ColorOverlayIconBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._ColorOverlayIconBrush) == null)
				{
					result = (this._ColorOverlayIconBrush = new FSlateBrush(base.NativePtr + (IntPtr)FDockTabStyle.__PropertyOffset_ColorOverlayIconBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FDockTabStyle.__PropertyOffset_ColorOverlayIconBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700932F RID: 37679
		// (get) Token: 0x06026207 RID: 156167 RVA: 0x0039D928 File Offset: 0x0039BB28
		// (set) Token: 0x06026208 RID: 156168 RVA: 0x0039D96B File Offset: 0x0039BB6B
		public FSlateBrush ForegroundBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._ForegroundBrush) == null)
				{
					result = (this._ForegroundBrush = new FSlateBrush(base.NativePtr + (IntPtr)FDockTabStyle.__PropertyOffset_ForegroundBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FDockTabStyle.__PropertyOffset_ForegroundBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009330 RID: 37680
		// (get) Token: 0x06026209 RID: 156169 RVA: 0x0039D98C File Offset: 0x0039BB8C
		// (set) Token: 0x0602620A RID: 156170 RVA: 0x0039D9CF File Offset: 0x0039BBCF
		public FSlateBrush HoveredBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._HoveredBrush) == null)
				{
					result = (this._HoveredBrush = new FSlateBrush(base.NativePtr + (IntPtr)FDockTabStyle.__PropertyOffset_HoveredBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FDockTabStyle.__PropertyOffset_HoveredBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009331 RID: 37681
		// (get) Token: 0x0602620B RID: 156171 RVA: 0x0039D9F0 File Offset: 0x0039BBF0
		// (set) Token: 0x0602620C RID: 156172 RVA: 0x0039DA33 File Offset: 0x0039BC33
		public FSlateBrush ContentAreaBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._ContentAreaBrush) == null)
				{
					result = (this._ContentAreaBrush = new FSlateBrush(base.NativePtr + (IntPtr)FDockTabStyle.__PropertyOffset_ContentAreaBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FDockTabStyle.__PropertyOffset_ContentAreaBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009332 RID: 37682
		// (get) Token: 0x0602620D RID: 156173 RVA: 0x0039DA54 File Offset: 0x0039BC54
		// (set) Token: 0x0602620E RID: 156174 RVA: 0x0039DA97 File Offset: 0x0039BC97
		public FSlateBrush TabWellBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._TabWellBrush) == null)
				{
					result = (this._TabWellBrush = new FSlateBrush(base.NativePtr + (IntPtr)FDockTabStyle.__PropertyOffset_TabWellBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FDockTabStyle.__PropertyOffset_TabWellBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009333 RID: 37683
		// (get) Token: 0x0602620F RID: 156175 RVA: 0x0039DAB8 File Offset: 0x0039BCB8
		// (set) Token: 0x06026210 RID: 156176 RVA: 0x0039DACC File Offset: 0x0039BCCC
		public unsafe FMargin TabPadding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDockTabStyle.__PropertyOffset_TabPadding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDockTabStyle.__PropertyOffset_TabPadding) = value;
			}
		}

		// Token: 0x17009334 RID: 37684
		// (get) Token: 0x06026211 RID: 156177 RVA: 0x0039DAE1 File Offset: 0x0039BCE1
		// (set) Token: 0x06026212 RID: 156178 RVA: 0x0039DAF1 File Offset: 0x0039BCF1
		public unsafe float OverlapWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDockTabStyle.__PropertyOffset_OverlapWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDockTabStyle.__PropertyOffset_OverlapWidth) = value;
			}
		}

		// Token: 0x17009335 RID: 37685
		// (get) Token: 0x06026213 RID: 156179 RVA: 0x0039DB04 File Offset: 0x0039BD04
		// (set) Token: 0x06026214 RID: 156180 RVA: 0x0039DB47 File Offset: 0x0039BD47
		public FSlateColor FlashColor
		{
			get
			{
				base.FastCheckIsValid();
				FSlateColor result;
				if ((result = this._FlashColor) == null)
				{
					result = (this._FlashColor = new FSlateColor(base.NativePtr + (IntPtr)FDockTabStyle.__PropertyOffset_FlashColor, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateColor.StaticStruct(), base.NativePtr + (IntPtr)FDockTabStyle.__PropertyOffset_FlashColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06026215 RID: 156181 RVA: 0x0039DB68 File Offset: 0x0039BD68
		public FDockTabStyle()
		{
		}

		// Token: 0x06026216 RID: 156182 RVA: 0x0039DB70 File Offset: 0x0039BD70
		public FDockTabStyle(FButtonStyle CloseButtonStyle, FSlateBrush NormalBrush, FSlateBrush ActiveBrush, FSlateBrush ColorOverlayTabBrush, FSlateBrush ColorOverlayIconBrush, FSlateBrush ForegroundBrush, FSlateBrush HoveredBrush, FSlateBrush ContentAreaBrush, FSlateBrush TabWellBrush, FMargin TabPadding, float OverlapWidth, FSlateColor FlashColor)
		{
			this.CloseButtonStyle = CloseButtonStyle;
			this.NormalBrush = NormalBrush;
			this.ActiveBrush = ActiveBrush;
			this.ColorOverlayTabBrush = ColorOverlayTabBrush;
			this.ColorOverlayIconBrush = ColorOverlayIconBrush;
			this.ForegroundBrush = ForegroundBrush;
			this.HoveredBrush = HoveredBrush;
			this.ContentAreaBrush = ContentAreaBrush;
			this.TabWellBrush = TabWellBrush;
			this.TabPadding = TabPadding;
			this.OverlapWidth = OverlapWidth;
			this.FlashColor = FlashColor;
		}

		// Token: 0x06026217 RID: 156183 RVA: 0x0039DBE0 File Offset: 0x0039BDE0
		protected override IntPtr GetUStructPtr()
		{
			return FDockTabStyle.StaticStruct();
		}

		// Token: 0x06026218 RID: 156184 RVA: 0x0039DBEC File Offset: 0x0039BDEC
		[NullableContext(2)]
		public FDockTabStyle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026219 RID: 156185 RVA: 0x0039DBF6 File Offset: 0x0039BDF6
		public FDockTabStyle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602621A RID: 156186 RVA: 0x0039DC01 File Offset: 0x0039BE01
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDockTabStyle(Pointer, false, true);
		}

		// Token: 0x0602621B RID: 156187 RVA: 0x0039DC0B File Offset: 0x0039BE0B
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDockTabStyle(Pointer, MemoryOwner);
		}

		// Token: 0x04014D2F RID: 85295
		public new const string __ObjectPath = "/Script/SlateCore.DockTabStyle";

		// Token: 0x04014D30 RID: 85296
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014D31 RID: 85297
		internal static int __PropertyOffset_CloseButtonStyle;

		// Token: 0x04014D32 RID: 85298
		[Nullable(2)]
		private FButtonStyle _CloseButtonStyle;

		// Token: 0x04014D33 RID: 85299
		internal static int __PropertyOffset_NormalBrush;

		// Token: 0x04014D34 RID: 85300
		[Nullable(2)]
		private FSlateBrush _NormalBrush;

		// Token: 0x04014D35 RID: 85301
		internal static int __PropertyOffset_ActiveBrush;

		// Token: 0x04014D36 RID: 85302
		[Nullable(2)]
		private FSlateBrush _ActiveBrush;

		// Token: 0x04014D37 RID: 85303
		internal static int __PropertyOffset_ColorOverlayTabBrush;

		// Token: 0x04014D38 RID: 85304
		[Nullable(2)]
		private FSlateBrush _ColorOverlayTabBrush;

		// Token: 0x04014D39 RID: 85305
		internal static int __PropertyOffset_ColorOverlayIconBrush;

		// Token: 0x04014D3A RID: 85306
		[Nullable(2)]
		private FSlateBrush _ColorOverlayIconBrush;

		// Token: 0x04014D3B RID: 85307
		internal static int __PropertyOffset_ForegroundBrush;

		// Token: 0x04014D3C RID: 85308
		[Nullable(2)]
		private FSlateBrush _ForegroundBrush;

		// Token: 0x04014D3D RID: 85309
		internal static int __PropertyOffset_HoveredBrush;

		// Token: 0x04014D3E RID: 85310
		[Nullable(2)]
		private FSlateBrush _HoveredBrush;

		// Token: 0x04014D3F RID: 85311
		internal static int __PropertyOffset_ContentAreaBrush;

		// Token: 0x04014D40 RID: 85312
		[Nullable(2)]
		private FSlateBrush _ContentAreaBrush;

		// Token: 0x04014D41 RID: 85313
		internal static int __PropertyOffset_TabWellBrush;

		// Token: 0x04014D42 RID: 85314
		[Nullable(2)]
		private FSlateBrush _TabWellBrush;

		// Token: 0x04014D43 RID: 85315
		internal static int __PropertyOffset_TabPadding;

		// Token: 0x04014D44 RID: 85316
		internal static int __PropertyOffset_OverlapWidth;

		// Token: 0x04014D45 RID: 85317
		internal static int __PropertyOffset_FlashColor;

		// Token: 0x04014D46 RID: 85318
		[Nullable(2)]
		private FSlateColor _FlashColor;
	}
}
