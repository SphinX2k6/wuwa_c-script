using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028EC RID: 10476
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/TapCommon.TapToastThrobberStyle")]
	[UnrealStructLayout(2440, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2440)]
	public class FTapToastThrobberStyle : FSlateWidgetStyle, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026DB5 RID: 159157 RVA: 0x003B43F2 File Offset: 0x003B25F2
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTapToastThrobberStyle._ScriptStructPtr != 0) ? FTapToastThrobberStyle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/TapCommon.TapToastThrobberStyle", ref FTapToastThrobberStyle._ScriptStructPtr);
		}

		// Token: 0x170095AF RID: 38319
		// (get) Token: 0x06026DB6 RID: 159158 RVA: 0x003B4418 File Offset: 0x003B2618
		// (set) Token: 0x06026DB7 RID: 159159 RVA: 0x003B445B File Offset: 0x003B265B
		public FSlateBrush BackGroundBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._BackGroundBrush) == null)
				{
					result = (this._BackGroundBrush = new FSlateBrush(base.NativePtr + (IntPtr)FTapToastThrobberStyle.__PropertyOffset_BackGroundBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FTapToastThrobberStyle.__PropertyOffset_BackGroundBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170095B0 RID: 38320
		// (get) Token: 0x06026DB8 RID: 159160 RVA: 0x003B447C File Offset: 0x003B267C
		// (set) Token: 0x06026DB9 RID: 159161 RVA: 0x003B44BF File Offset: 0x003B26BF
		public FSlateBrush BackGroundBrush_PC
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._BackGroundBrush_PC) == null)
				{
					result = (this._BackGroundBrush_PC = new FSlateBrush(base.NativePtr + (IntPtr)FTapToastThrobberStyle.__PropertyOffset_BackGroundBrush_PC, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FTapToastThrobberStyle.__PropertyOffset_BackGroundBrush_PC, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170095B1 RID: 38321
		// (get) Token: 0x06026DBA RID: 159162 RVA: 0x003B44E0 File Offset: 0x003B26E0
		// (set) Token: 0x06026DBB RID: 159163 RVA: 0x003B4523 File Offset: 0x003B2723
		public FSlateBrush BackGroundBrush_PC_Text
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._BackGroundBrush_PC_Text) == null)
				{
					result = (this._BackGroundBrush_PC_Text = new FSlateBrush(base.NativePtr + (IntPtr)FTapToastThrobberStyle.__PropertyOffset_BackGroundBrush_PC_Text, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FTapToastThrobberStyle.__PropertyOffset_BackGroundBrush_PC_Text, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170095B2 RID: 38322
		// (get) Token: 0x06026DBC RID: 159164 RVA: 0x003B4544 File Offset: 0x003B2744
		// (set) Token: 0x06026DBD RID: 159165 RVA: 0x003B4587 File Offset: 0x003B2787
		public FSlateBrush ShadowBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._ShadowBrush) == null)
				{
					result = (this._ShadowBrush = new FSlateBrush(base.NativePtr + (IntPtr)FTapToastThrobberStyle.__PropertyOffset_ShadowBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FTapToastThrobberStyle.__PropertyOffset_ShadowBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170095B3 RID: 38323
		// (get) Token: 0x06026DBE RID: 159166 RVA: 0x003B45A8 File Offset: 0x003B27A8
		// (set) Token: 0x06026DBF RID: 159167 RVA: 0x003B45EB File Offset: 0x003B27EB
		public FSlateBrush PieceImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._PieceImage) == null)
				{
					result = (this._PieceImage = new FSlateBrush(base.NativePtr + (IntPtr)FTapToastThrobberStyle.__PropertyOffset_PieceImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FTapToastThrobberStyle.__PropertyOffset_PieceImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170095B4 RID: 38324
		// (get) Token: 0x06026DC0 RID: 159168 RVA: 0x003B460C File Offset: 0x003B280C
		// (set) Token: 0x06026DC1 RID: 159169 RVA: 0x003B464F File Offset: 0x003B284F
		public FSlateBrush PieceImage_PC
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._PieceImage_PC) == null)
				{
					result = (this._PieceImage_PC = new FSlateBrush(base.NativePtr + (IntPtr)FTapToastThrobberStyle.__PropertyOffset_PieceImage_PC, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FTapToastThrobberStyle.__PropertyOffset_PieceImage_PC, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170095B5 RID: 38325
		// (get) Token: 0x06026DC2 RID: 159170 RVA: 0x003B4670 File Offset: 0x003B2870
		// (set) Token: 0x06026DC3 RID: 159171 RVA: 0x003B46B3 File Offset: 0x003B28B3
		public FSlateColor ColorAndOpacity
		{
			get
			{
				base.FastCheckIsValid();
				FSlateColor result;
				if ((result = this._ColorAndOpacity) == null)
				{
					result = (this._ColorAndOpacity = new FSlateColor(base.NativePtr + (IntPtr)FTapToastThrobberStyle.__PropertyOffset_ColorAndOpacity, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateColor.StaticStruct(), base.NativePtr + (IntPtr)FTapToastThrobberStyle.__PropertyOffset_ColorAndOpacity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170095B6 RID: 38326
		// (get) Token: 0x06026DC4 RID: 159172 RVA: 0x003B46D4 File Offset: 0x003B28D4
		// (set) Token: 0x06026DC5 RID: 159173 RVA: 0x003B4717 File Offset: 0x003B2917
		public FTextBlockStyle ContentStyle
		{
			get
			{
				base.FastCheckIsValid();
				FTextBlockStyle result;
				if ((result = this._ContentStyle) == null)
				{
					result = (this._ContentStyle = new FTextBlockStyle(base.NativePtr + (IntPtr)FTapToastThrobberStyle.__PropertyOffset_ContentStyle, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextBlockStyle.StaticStruct(), base.NativePtr + (IntPtr)FTapToastThrobberStyle.__PropertyOffset_ContentStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170095B7 RID: 38327
		// (get) Token: 0x06026DC6 RID: 159174 RVA: 0x003B4738 File Offset: 0x003B2938
		// (set) Token: 0x06026DC7 RID: 159175 RVA: 0x003B477B File Offset: 0x003B297B
		public FTextBlockStyle ContentStyle_PC
		{
			get
			{
				base.FastCheckIsValid();
				FTextBlockStyle result;
				if ((result = this._ContentStyle_PC) == null)
				{
					result = (this._ContentStyle_PC = new FTextBlockStyle(base.NativePtr + (IntPtr)FTapToastThrobberStyle.__PropertyOffset_ContentStyle_PC, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextBlockStyle.StaticStruct(), base.NativePtr + (IntPtr)FTapToastThrobberStyle.__PropertyOffset_ContentStyle_PC, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170095B8 RID: 38328
		// (get) Token: 0x06026DC8 RID: 159176 RVA: 0x003B479C File Offset: 0x003B299C
		// (set) Token: 0x06026DC9 RID: 159177 RVA: 0x003B47AC File Offset: 0x003B29AC
		public unsafe float RotationRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTapToastThrobberStyle.__PropertyOffset_RotationRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTapToastThrobberStyle.__PropertyOffset_RotationRate) = value;
			}
		}

		// Token: 0x06026DCA RID: 159178 RVA: 0x003B47BD File Offset: 0x003B29BD
		public FTapToastThrobberStyle()
		{
		}

		// Token: 0x06026DCB RID: 159179 RVA: 0x003B47C8 File Offset: 0x003B29C8
		public FTapToastThrobberStyle(FSlateBrush BackGroundBrush, FSlateBrush BackGroundBrush_PC, FSlateBrush BackGroundBrush_PC_Text, FSlateBrush ShadowBrush, FSlateBrush PieceImage, FSlateBrush PieceImage_PC, FSlateColor ColorAndOpacity, FTextBlockStyle ContentStyle, FTextBlockStyle ContentStyle_PC, float RotationRate)
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

		// Token: 0x06026DCC RID: 159180 RVA: 0x003B4828 File Offset: 0x003B2A28
		protected override IntPtr GetUStructPtr()
		{
			return FTapToastThrobberStyle.StaticStruct();
		}

		// Token: 0x06026DCD RID: 159181 RVA: 0x003B4834 File Offset: 0x003B2A34
		[NullableContext(2)]
		public FTapToastThrobberStyle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026DCE RID: 159182 RVA: 0x003B483E File Offset: 0x003B2A3E
		public FTapToastThrobberStyle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026DCF RID: 159183 RVA: 0x003B4849 File Offset: 0x003B2A49
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTapToastThrobberStyle(Pointer, false, true);
		}

		// Token: 0x06026DD0 RID: 159184 RVA: 0x003B4853 File Offset: 0x003B2A53
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTapToastThrobberStyle(Pointer, MemoryOwner);
		}

		// Token: 0x04015550 RID: 87376
		public new const string __ObjectPath = "/Script/TapCommon.TapToastThrobberStyle";

		// Token: 0x04015551 RID: 87377
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015552 RID: 87378
		internal static int __PropertyOffset_BackGroundBrush;

		// Token: 0x04015553 RID: 87379
		[Nullable(2)]
		private FSlateBrush _BackGroundBrush;

		// Token: 0x04015554 RID: 87380
		internal static int __PropertyOffset_BackGroundBrush_PC;

		// Token: 0x04015555 RID: 87381
		[Nullable(2)]
		private FSlateBrush _BackGroundBrush_PC;

		// Token: 0x04015556 RID: 87382
		internal static int __PropertyOffset_BackGroundBrush_PC_Text;

		// Token: 0x04015557 RID: 87383
		[Nullable(2)]
		private FSlateBrush _BackGroundBrush_PC_Text;

		// Token: 0x04015558 RID: 87384
		internal static int __PropertyOffset_ShadowBrush;

		// Token: 0x04015559 RID: 87385
		[Nullable(2)]
		private FSlateBrush _ShadowBrush;

		// Token: 0x0401555A RID: 87386
		internal static int __PropertyOffset_PieceImage;

		// Token: 0x0401555B RID: 87387
		[Nullable(2)]
		private FSlateBrush _PieceImage;

		// Token: 0x0401555C RID: 87388
		internal static int __PropertyOffset_PieceImage_PC;

		// Token: 0x0401555D RID: 87389
		[Nullable(2)]
		private FSlateBrush _PieceImage_PC;

		// Token: 0x0401555E RID: 87390
		internal static int __PropertyOffset_ColorAndOpacity;

		// Token: 0x0401555F RID: 87391
		[Nullable(2)]
		private FSlateColor _ColorAndOpacity;

		// Token: 0x04015560 RID: 87392
		internal static int __PropertyOffset_ContentStyle;

		// Token: 0x04015561 RID: 87393
		[Nullable(2)]
		private FTextBlockStyle _ContentStyle;

		// Token: 0x04015562 RID: 87394
		internal static int __PropertyOffset_ContentStyle_PC;

		// Token: 0x04015563 RID: 87395
		[Nullable(2)]
		private FTextBlockStyle _ContentStyle_PC;

		// Token: 0x04015564 RID: 87396
		internal static int __PropertyOffset_RotationRate;
	}
}
