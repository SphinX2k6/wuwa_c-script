using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028DB RID: 10459
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/TapCommon.TapBoxWrapperStyle")]
	[UnrealStructLayout(944, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 944)]
	public class FTapBoxWrapperStyle : FSlateWidgetStyle, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026CD1 RID: 158929 RVA: 0x003B2BF8 File Offset: 0x003B0DF8
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTapBoxWrapperStyle._ScriptStructPtr != 0) ? FTapBoxWrapperStyle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/TapCommon.TapBoxWrapperStyle", ref FTapBoxWrapperStyle._ScriptStructPtr);
		}

		// Token: 0x1700957A RID: 38266
		// (get) Token: 0x06026CD2 RID: 158930 RVA: 0x003B2C1C File Offset: 0x003B0E1C
		// (set) Token: 0x06026CD3 RID: 158931 RVA: 0x003B2C5F File Offset: 0x003B0E5F
		public FSlateBrush BackgroundBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._BackgroundBrush) == null)
				{
					result = (this._BackgroundBrush = new FSlateBrush(base.NativePtr + (IntPtr)FTapBoxWrapperStyle.__PropertyOffset_BackgroundBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FTapBoxWrapperStyle.__PropertyOffset_BackgroundBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700957B RID: 38267
		// (get) Token: 0x06026CD4 RID: 158932 RVA: 0x003B2C80 File Offset: 0x003B0E80
		// (set) Token: 0x06026CD5 RID: 158933 RVA: 0x003B2CC3 File Offset: 0x003B0EC3
		public FTextBlockStyle TitleStyle
		{
			get
			{
				base.FastCheckIsValid();
				FTextBlockStyle result;
				if ((result = this._TitleStyle) == null)
				{
					result = (this._TitleStyle = new FTextBlockStyle(base.NativePtr + (IntPtr)FTapBoxWrapperStyle.__PropertyOffset_TitleStyle, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextBlockStyle.StaticStruct(), base.NativePtr + (IntPtr)FTapBoxWrapperStyle.__PropertyOffset_TitleStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700957C RID: 38268
		// (get) Token: 0x06026CD6 RID: 158934 RVA: 0x003B2CE4 File Offset: 0x003B0EE4
		// (set) Token: 0x06026CD7 RID: 158935 RVA: 0x003B2CF8 File Offset: 0x003B0EF8
		public unsafe FMargin TitlePadding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTapBoxWrapperStyle.__PropertyOffset_TitlePadding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTapBoxWrapperStyle.__PropertyOffset_TitlePadding) = value;
			}
		}

		// Token: 0x1700957D RID: 38269
		// (get) Token: 0x06026CD8 RID: 158936 RVA: 0x003B2D0D File Offset: 0x003B0F0D
		// (set) Token: 0x06026CD9 RID: 158937 RVA: 0x003B2D21 File Offset: 0x003B0F21
		public unsafe FMargin ButtonBoxPadding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTapBoxWrapperStyle.__PropertyOffset_ButtonBoxPadding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTapBoxWrapperStyle.__PropertyOffset_ButtonBoxPadding) = value;
			}
		}

		// Token: 0x1700957E RID: 38270
		// (get) Token: 0x06026CDA RID: 158938 RVA: 0x003B2D36 File Offset: 0x003B0F36
		// (set) Token: 0x06026CDB RID: 158939 RVA: 0x003B2D4A File Offset: 0x003B0F4A
		public unsafe FVector2D ButtonSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTapBoxWrapperStyle.__PropertyOffset_ButtonSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTapBoxWrapperStyle.__PropertyOffset_ButtonSize) = value;
			}
		}

		// Token: 0x1700957F RID: 38271
		// (get) Token: 0x06026CDC RID: 158940 RVA: 0x003B2D5F File Offset: 0x003B0F5F
		// (set) Token: 0x06026CDD RID: 158941 RVA: 0x003B2D6F File Offset: 0x003B0F6F
		public unsafe float ButtonGap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTapBoxWrapperStyle.__PropertyOffset_ButtonGap);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTapBoxWrapperStyle.__PropertyOffset_ButtonGap) = value;
			}
		}

		// Token: 0x17009580 RID: 38272
		// (get) Token: 0x06026CDE RID: 158942 RVA: 0x003B2D80 File Offset: 0x003B0F80
		// (set) Token: 0x06026CDF RID: 158943 RVA: 0x003B2D94 File Offset: 0x003B0F94
		public unsafe FMargin CloseButtonPadding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTapBoxWrapperStyle.__PropertyOffset_CloseButtonPadding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTapBoxWrapperStyle.__PropertyOffset_CloseButtonPadding) = value;
			}
		}

		// Token: 0x06026CE0 RID: 158944 RVA: 0x003B2DA9 File Offset: 0x003B0FA9
		public FTapBoxWrapperStyle()
		{
		}

		// Token: 0x06026CE1 RID: 158945 RVA: 0x003B2DB1 File Offset: 0x003B0FB1
		public FTapBoxWrapperStyle(FSlateBrush BackgroundBrush, FTextBlockStyle TitleStyle, FMargin TitlePadding, FMargin ButtonBoxPadding, FVector2D ButtonSize, float ButtonGap, FMargin CloseButtonPadding)
		{
			this.BackgroundBrush = BackgroundBrush;
			this.TitleStyle = TitleStyle;
			this.TitlePadding = TitlePadding;
			this.ButtonBoxPadding = ButtonBoxPadding;
			this.ButtonSize = ButtonSize;
			this.ButtonGap = ButtonGap;
			this.CloseButtonPadding = CloseButtonPadding;
		}

		// Token: 0x06026CE2 RID: 158946 RVA: 0x003B2DEE File Offset: 0x003B0FEE
		protected override IntPtr GetUStructPtr()
		{
			return FTapBoxWrapperStyle.StaticStruct();
		}

		// Token: 0x06026CE3 RID: 158947 RVA: 0x003B2DFA File Offset: 0x003B0FFA
		[NullableContext(2)]
		public FTapBoxWrapperStyle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026CE4 RID: 158948 RVA: 0x003B2E04 File Offset: 0x003B1004
		public FTapBoxWrapperStyle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026CE5 RID: 158949 RVA: 0x003B2E0F File Offset: 0x003B100F
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTapBoxWrapperStyle(Pointer, false, true);
		}

		// Token: 0x06026CE6 RID: 158950 RVA: 0x003B2E19 File Offset: 0x003B1019
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTapBoxWrapperStyle(Pointer, MemoryOwner);
		}

		// Token: 0x040154D7 RID: 87255
		public new const string __ObjectPath = "/Script/TapCommon.TapBoxWrapperStyle";

		// Token: 0x040154D8 RID: 87256
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040154D9 RID: 87257
		internal static int __PropertyOffset_BackgroundBrush;

		// Token: 0x040154DA RID: 87258
		[Nullable(2)]
		private FSlateBrush _BackgroundBrush;

		// Token: 0x040154DB RID: 87259
		internal static int __PropertyOffset_TitleStyle;

		// Token: 0x040154DC RID: 87260
		[Nullable(2)]
		private FTextBlockStyle _TitleStyle;

		// Token: 0x040154DD RID: 87261
		internal static int __PropertyOffset_TitlePadding;

		// Token: 0x040154DE RID: 87262
		internal static int __PropertyOffset_ButtonBoxPadding;

		// Token: 0x040154DF RID: 87263
		internal static int __PropertyOffset_ButtonSize;

		// Token: 0x040154E0 RID: 87264
		internal static int __PropertyOffset_ButtonGap;

		// Token: 0x040154E1 RID: 87265
		internal static int __PropertyOffset_CloseButtonPadding;
	}
}
