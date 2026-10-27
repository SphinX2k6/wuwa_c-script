using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002A63 RID: 10851
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/WidgetCarousel.WidgetCarouselNavigationBarStyle")]
	[UnrealStructLayout(2472, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2472)]
	public class FWidgetCarouselNavigationBarStyle : FSlateWidgetStyle, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060280C2 RID: 164034 RVA: 0x003CF634 File Offset: 0x003CD834
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWidgetCarouselNavigationBarStyle._ScriptStructPtr != 0) ? FWidgetCarouselNavigationBarStyle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/WidgetCarousel.WidgetCarouselNavigationBarStyle", ref FWidgetCarouselNavigationBarStyle._ScriptStructPtr);
		}

		// Token: 0x170098ED RID: 39149
		// (get) Token: 0x060280C3 RID: 164035 RVA: 0x003CF658 File Offset: 0x003CD858
		// (set) Token: 0x060280C4 RID: 164036 RVA: 0x003CF69B File Offset: 0x003CD89B
		public FSlateBrush HighlightBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._HighlightBrush) == null)
				{
					result = (this._HighlightBrush = new FSlateBrush(base.NativePtr + (IntPtr)FWidgetCarouselNavigationBarStyle.__PropertyOffset_HighlightBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FWidgetCarouselNavigationBarStyle.__PropertyOffset_HighlightBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170098EE RID: 39150
		// (get) Token: 0x060280C5 RID: 164037 RVA: 0x003CF6BC File Offset: 0x003CD8BC
		// (set) Token: 0x060280C6 RID: 164038 RVA: 0x003CF6FF File Offset: 0x003CD8FF
		public FButtonStyle LeftButtonStyle
		{
			get
			{
				base.FastCheckIsValid();
				FButtonStyle result;
				if ((result = this._LeftButtonStyle) == null)
				{
					result = (this._LeftButtonStyle = new FButtonStyle(base.NativePtr + (IntPtr)FWidgetCarouselNavigationBarStyle.__PropertyOffset_LeftButtonStyle, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FButtonStyle.StaticStruct(), base.NativePtr + (IntPtr)FWidgetCarouselNavigationBarStyle.__PropertyOffset_LeftButtonStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170098EF RID: 39151
		// (get) Token: 0x060280C7 RID: 164039 RVA: 0x003CF720 File Offset: 0x003CD920
		// (set) Token: 0x060280C8 RID: 164040 RVA: 0x003CF763 File Offset: 0x003CD963
		public FButtonStyle CenterButtonStyle
		{
			get
			{
				base.FastCheckIsValid();
				FButtonStyle result;
				if ((result = this._CenterButtonStyle) == null)
				{
					result = (this._CenterButtonStyle = new FButtonStyle(base.NativePtr + (IntPtr)FWidgetCarouselNavigationBarStyle.__PropertyOffset_CenterButtonStyle, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FButtonStyle.StaticStruct(), base.NativePtr + (IntPtr)FWidgetCarouselNavigationBarStyle.__PropertyOffset_CenterButtonStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170098F0 RID: 39152
		// (get) Token: 0x060280C9 RID: 164041 RVA: 0x003CF784 File Offset: 0x003CD984
		// (set) Token: 0x060280CA RID: 164042 RVA: 0x003CF7C7 File Offset: 0x003CD9C7
		public FButtonStyle RightButtonStyle
		{
			get
			{
				base.FastCheckIsValid();
				FButtonStyle result;
				if ((result = this._RightButtonStyle) == null)
				{
					result = (this._RightButtonStyle = new FButtonStyle(base.NativePtr + (IntPtr)FWidgetCarouselNavigationBarStyle.__PropertyOffset_RightButtonStyle, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FButtonStyle.StaticStruct(), base.NativePtr + (IntPtr)FWidgetCarouselNavigationBarStyle.__PropertyOffset_RightButtonStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060280CB RID: 164043 RVA: 0x003CF7E8 File Offset: 0x003CD9E8
		public FWidgetCarouselNavigationBarStyle()
		{
		}

		// Token: 0x060280CC RID: 164044 RVA: 0x003CF7F0 File Offset: 0x003CD9F0
		public FWidgetCarouselNavigationBarStyle(FSlateBrush HighlightBrush, FButtonStyle LeftButtonStyle, FButtonStyle CenterButtonStyle, FButtonStyle RightButtonStyle)
		{
			this.HighlightBrush = HighlightBrush;
			this.LeftButtonStyle = LeftButtonStyle;
			this.CenterButtonStyle = CenterButtonStyle;
			this.RightButtonStyle = RightButtonStyle;
		}

		// Token: 0x060280CD RID: 164045 RVA: 0x003CF815 File Offset: 0x003CDA15
		protected override IntPtr GetUStructPtr()
		{
			return FWidgetCarouselNavigationBarStyle.StaticStruct();
		}

		// Token: 0x060280CE RID: 164046 RVA: 0x003CF821 File Offset: 0x003CDA21
		[NullableContext(2)]
		public FWidgetCarouselNavigationBarStyle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060280CF RID: 164047 RVA: 0x003CF82B File Offset: 0x003CDA2B
		public FWidgetCarouselNavigationBarStyle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060280D0 RID: 164048 RVA: 0x003CF836 File Offset: 0x003CDA36
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWidgetCarouselNavigationBarStyle(Pointer, false, true);
		}

		// Token: 0x060280D1 RID: 164049 RVA: 0x003CF840 File Offset: 0x003CDA40
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWidgetCarouselNavigationBarStyle(Pointer, MemoryOwner);
		}

		// Token: 0x04015F7D RID: 89981
		public new const string __ObjectPath = "/Script/WidgetCarousel.WidgetCarouselNavigationBarStyle";

		// Token: 0x04015F7E RID: 89982
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015F7F RID: 89983
		internal static int __PropertyOffset_HighlightBrush;

		// Token: 0x04015F80 RID: 89984
		[Nullable(2)]
		private FSlateBrush _HighlightBrush;

		// Token: 0x04015F81 RID: 89985
		internal static int __PropertyOffset_LeftButtonStyle;

		// Token: 0x04015F82 RID: 89986
		[Nullable(2)]
		private FButtonStyle _LeftButtonStyle;

		// Token: 0x04015F83 RID: 89987
		internal static int __PropertyOffset_CenterButtonStyle;

		// Token: 0x04015F84 RID: 89988
		[Nullable(2)]
		private FButtonStyle _CenterButtonStyle;

		// Token: 0x04015F85 RID: 89989
		internal static int __PropertyOffset_RightButtonStyle;

		// Token: 0x04015F86 RID: 89990
		[Nullable(2)]
		private FButtonStyle _RightButtonStyle;
	}
}
