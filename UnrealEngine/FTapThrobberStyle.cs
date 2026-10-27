using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028E9 RID: 10473
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/TapCommon.TapThrobberStyle")]
	[UnrealStructLayout(2440, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2440)]
	public class FTapThrobberStyle : FSlateWidgetStyle, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026D82 RID: 159106 RVA: 0x003B3CDC File Offset: 0x003B1EDC
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTapThrobberStyle._ScriptStructPtr != 0) ? FTapThrobberStyle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/TapCommon.TapThrobberStyle", ref FTapThrobberStyle._ScriptStructPtr);
		}

		// Token: 0x170095A0 RID: 38304
		// (get) Token: 0x06026D83 RID: 159107 RVA: 0x003B3D00 File Offset: 0x003B1F00
		// (set) Token: 0x06026D84 RID: 159108 RVA: 0x003B3D43 File Offset: 0x003B1F43
		public FSlateBrush BackGroundBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._BackGroundBrush) == null)
				{
					result = (this._BackGroundBrush = new FSlateBrush(base.NativePtr + (IntPtr)FTapThrobberStyle.__PropertyOffset_BackGroundBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FTapThrobberStyle.__PropertyOffset_BackGroundBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170095A1 RID: 38305
		// (get) Token: 0x06026D85 RID: 159109 RVA: 0x003B3D64 File Offset: 0x003B1F64
		// (set) Token: 0x06026D86 RID: 159110 RVA: 0x003B3DA7 File Offset: 0x003B1FA7
		public FSlateBrush BackGroundBrush_PC
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._BackGroundBrush_PC) == null)
				{
					result = (this._BackGroundBrush_PC = new FSlateBrush(base.NativePtr + (IntPtr)FTapThrobberStyle.__PropertyOffset_BackGroundBrush_PC, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FTapThrobberStyle.__PropertyOffset_BackGroundBrush_PC, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170095A2 RID: 38306
		// (get) Token: 0x06026D87 RID: 159111 RVA: 0x003B3DC8 File Offset: 0x003B1FC8
		// (set) Token: 0x06026D88 RID: 159112 RVA: 0x003B3E0B File Offset: 0x003B200B
		public FSlateBrush BackGroundBrush_PC_Text
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._BackGroundBrush_PC_Text) == null)
				{
					result = (this._BackGroundBrush_PC_Text = new FSlateBrush(base.NativePtr + (IntPtr)FTapThrobberStyle.__PropertyOffset_BackGroundBrush_PC_Text, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FTapThrobberStyle.__PropertyOffset_BackGroundBrush_PC_Text, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170095A3 RID: 38307
		// (get) Token: 0x06026D89 RID: 159113 RVA: 0x003B3E2C File Offset: 0x003B202C
		// (set) Token: 0x06026D8A RID: 159114 RVA: 0x003B3E6F File Offset: 0x003B206F
		public FSlateBrush ShadowBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._ShadowBrush) == null)
				{
					result = (this._ShadowBrush = new FSlateBrush(base.NativePtr + (IntPtr)FTapThrobberStyle.__PropertyOffset_ShadowBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FTapThrobberStyle.__PropertyOffset_ShadowBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170095A4 RID: 38308
		// (get) Token: 0x06026D8B RID: 159115 RVA: 0x003B3E90 File Offset: 0x003B2090
		// (set) Token: 0x06026D8C RID: 159116 RVA: 0x003B3ED3 File Offset: 0x003B20D3
		public FSlateBrush PieceImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._PieceImage) == null)
				{
					result = (this._PieceImage = new FSlateBrush(base.NativePtr + (IntPtr)FTapThrobberStyle.__PropertyOffset_PieceImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FTapThrobberStyle.__PropertyOffset_PieceImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170095A5 RID: 38309
		// (get) Token: 0x06026D8D RID: 159117 RVA: 0x003B3EF4 File Offset: 0x003B20F4
		// (set) Token: 0x06026D8E RID: 159118 RVA: 0x003B3F37 File Offset: 0x003B2137
		public FSlateBrush PieceImage_PC
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._PieceImage_PC) == null)
				{
					result = (this._PieceImage_PC = new FSlateBrush(base.NativePtr + (IntPtr)FTapThrobberStyle.__PropertyOffset_PieceImage_PC, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FTapThrobberStyle.__PropertyOffset_PieceImage_PC, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170095A6 RID: 38310
		// (get) Token: 0x06026D8F RID: 159119 RVA: 0x003B3F58 File Offset: 0x003B2158
		// (set) Token: 0x06026D90 RID: 159120 RVA: 0x003B3F9B File Offset: 0x003B219B
		public FSlateColor ColorAndOpacity
		{
			get
			{
				base.FastCheckIsValid();
				FSlateColor result;
				if ((result = this._ColorAndOpacity) == null)
				{
					result = (this._ColorAndOpacity = new FSlateColor(base.NativePtr + (IntPtr)FTapThrobberStyle.__PropertyOffset_ColorAndOpacity, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateColor.StaticStruct(), base.NativePtr + (IntPtr)FTapThrobberStyle.__PropertyOffset_ColorAndOpacity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170095A7 RID: 38311
		// (get) Token: 0x06026D91 RID: 159121 RVA: 0x003B3FBC File Offset: 0x003B21BC
		// (set) Token: 0x06026D92 RID: 159122 RVA: 0x003B3FFF File Offset: 0x003B21FF
		public FTextBlockStyle ContentStyle
		{
			get
			{
				base.FastCheckIsValid();
				FTextBlockStyle result;
				if ((result = this._ContentStyle) == null)
				{
					result = (this._ContentStyle = new FTextBlockStyle(base.NativePtr + (IntPtr)FTapThrobberStyle.__PropertyOffset_ContentStyle, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextBlockStyle.StaticStruct(), base.NativePtr + (IntPtr)FTapThrobberStyle.__PropertyOffset_ContentStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170095A8 RID: 38312
		// (get) Token: 0x06026D93 RID: 159123 RVA: 0x003B4020 File Offset: 0x003B2220
		// (set) Token: 0x06026D94 RID: 159124 RVA: 0x003B4063 File Offset: 0x003B2263
		public FTextBlockStyle ContentStyle_PC
		{
			get
			{
				base.FastCheckIsValid();
				FTextBlockStyle result;
				if ((result = this._ContentStyle_PC) == null)
				{
					result = (this._ContentStyle_PC = new FTextBlockStyle(base.NativePtr + (IntPtr)FTapThrobberStyle.__PropertyOffset_ContentStyle_PC, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextBlockStyle.StaticStruct(), base.NativePtr + (IntPtr)FTapThrobberStyle.__PropertyOffset_ContentStyle_PC, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170095A9 RID: 38313
		// (get) Token: 0x06026D95 RID: 159125 RVA: 0x003B4084 File Offset: 0x003B2284
		// (set) Token: 0x06026D96 RID: 159126 RVA: 0x003B4094 File Offset: 0x003B2294
		public unsafe float RotationRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTapThrobberStyle.__PropertyOffset_RotationRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTapThrobberStyle.__PropertyOffset_RotationRate) = value;
			}
		}

		// Token: 0x06026D97 RID: 159127 RVA: 0x003B40A5 File Offset: 0x003B22A5
		public FTapThrobberStyle()
		{
		}

		// Token: 0x06026D98 RID: 159128 RVA: 0x003B40B0 File Offset: 0x003B22B0
		public FTapThrobberStyle(FSlateBrush BackGroundBrush, FSlateBrush BackGroundBrush_PC, FSlateBrush BackGroundBrush_PC_Text, FSlateBrush ShadowBrush, FSlateBrush PieceImage, FSlateBrush PieceImage_PC, FSlateColor ColorAndOpacity, FTextBlockStyle ContentStyle, FTextBlockStyle ContentStyle_PC, float RotationRate)
		{
			this.BackGroundBrush = BackGroundBrush;
			this.BackGroundBrush_PC = BackGroundBrush_PC;
			this.BackGroundBrush_PC_Text = BackGroundBrush_PC_Text;
			this.ShadowBrush = ShadowBrush;
			this.PieceImage = PieceImage;
			this.PieceImage_PC = PieceImage_PC;
			this.ColorAndOpacity = ColorAndOpacity;
			this.ContentStyle = ContentStyle;
			this.ContentStyle_PC = ContentStyle_PC;
			this.RotationRate = RotationRate;
		}

		// Token: 0x06026D99 RID: 159129 RVA: 0x003B4110 File Offset: 0x003B2310
		protected override IntPtr GetUStructPtr()
		{
			return FTapThrobberStyle.StaticStruct();
		}

		// Token: 0x06026D9A RID: 159130 RVA: 0x003B411C File Offset: 0x003B231C
		[NullableContext(2)]
		public FTapThrobberStyle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026D9B RID: 159131 RVA: 0x003B4126 File Offset: 0x003B2326
		public FTapThrobberStyle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026D9C RID: 159132 RVA: 0x003B4131 File Offset: 0x003B2331
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTapThrobberStyle(Pointer, false, true);
		}

		// Token: 0x06026D9D RID: 159133 RVA: 0x003B413B File Offset: 0x003B233B
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTapThrobberStyle(Pointer, MemoryOwner);
		}

		// Token: 0x0401552D RID: 87341
		public new const string __ObjectPath = "/Script/TapCommon.TapThrobberStyle";

		// Token: 0x0401552E RID: 87342
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401552F RID: 87343
		internal static int __PropertyOffset_BackGroundBrush;

		// Token: 0x04015530 RID: 87344
		[Nullable(2)]
		private FSlateBrush _BackGroundBrush;

		// Token: 0x04015531 RID: 87345
		internal static int __PropertyOffset_BackGroundBrush_PC;

		// Token: 0x04015532 RID: 87346
		[Nullable(2)]
		private FSlateBrush _BackGroundBrush_PC;

		// Token: 0x04015533 RID: 87347
		internal static int __PropertyOffset_BackGroundBrush_PC_Text;

		// Token: 0x04015534 RID: 87348
		[Nullable(2)]
		private FSlateBrush _BackGroundBrush_PC_Text;

		// Token: 0x04015535 RID: 87349
		internal static int __PropertyOffset_ShadowBrush;

		// Token: 0x04015536 RID: 87350
		[Nullable(2)]
		private FSlateBrush _ShadowBrush;

		// Token: 0x04015537 RID: 87351
		internal static int __PropertyOffset_PieceImage;

		// Token: 0x04015538 RID: 87352
		[Nullable(2)]
		private FSlateBrush _PieceImage;

		// Token: 0x04015539 RID: 87353
		internal static int __PropertyOffset_PieceImage_PC;

		// Token: 0x0401553A RID: 87354
		[Nullable(2)]
		private FSlateBrush _PieceImage_PC;

		// Token: 0x0401553B RID: 87355
		internal static int __PropertyOffset_ColorAndOpacity;

		// Token: 0x0401553C RID: 87356
		[Nullable(2)]
		private FSlateColor _ColorAndOpacity;

		// Token: 0x0401553D RID: 87357
		internal static int __PropertyOffset_ContentStyle;

		// Token: 0x0401553E RID: 87358
		[Nullable(2)]
		private FTextBlockStyle _ContentStyle;

		// Token: 0x0401553F RID: 87359
		internal static int __PropertyOffset_ContentStyle_PC;

		// Token: 0x04015540 RID: 87360
		[Nullable(2)]
		private FTextBlockStyle _ContentStyle_PC;

		// Token: 0x04015541 RID: 87361
		internal static int __PropertyOffset_RotationRate;
	}
}
