using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002A64 RID: 10852
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/WidgetCarousel.WidgetCarouselNavigationButtonStyle")]
	[UnrealStructLayout(1096, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1096)]
	public class FWidgetCarouselNavigationButtonStyle : FSlateWidgetStyle, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060280D2 RID: 164050 RVA: 0x003CF849 File Offset: 0x003CDA49
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWidgetCarouselNavigationButtonStyle._ScriptStructPtr != 0) ? FWidgetCarouselNavigationButtonStyle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/WidgetCarousel.WidgetCarouselNavigationButtonStyle", ref FWidgetCarouselNavigationButtonStyle._ScriptStructPtr);
		}

		// Token: 0x170098F1 RID: 39153
		// (get) Token: 0x060280D3 RID: 164051 RVA: 0x003CF870 File Offset: 0x003CDA70
		// (set) Token: 0x060280D4 RID: 164052 RVA: 0x003CF8B3 File Offset: 0x003CDAB3
		public FButtonStyle InnerButtonStyle
		{
			get
			{
				base.FastCheckIsValid();
				FButtonStyle result;
				if ((result = this._InnerButtonStyle) == null)
				{
					result = (this._InnerButtonStyle = new FButtonStyle(base.NativePtr + (IntPtr)FWidgetCarouselNavigationButtonStyle.__PropertyOffset_InnerButtonStyle, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FButtonStyle.StaticStruct(), base.NativePtr + (IntPtr)FWidgetCarouselNavigationButtonStyle.__PropertyOffset_InnerButtonStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170098F2 RID: 39154
		// (get) Token: 0x060280D5 RID: 164053 RVA: 0x003CF8D4 File Offset: 0x003CDAD4
		// (set) Token: 0x060280D6 RID: 164054 RVA: 0x003CF917 File Offset: 0x003CDB17
		public FSlateBrush NavigationButtonLeftImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._NavigationButtonLeftImage) == null)
				{
					result = (this._NavigationButtonLeftImage = new FSlateBrush(base.NativePtr + (IntPtr)FWidgetCarouselNavigationButtonStyle.__PropertyOffset_NavigationButtonLeftImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FWidgetCarouselNavigationButtonStyle.__PropertyOffset_NavigationButtonLeftImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170098F3 RID: 39155
		// (get) Token: 0x060280D7 RID: 164055 RVA: 0x003CF938 File Offset: 0x003CDB38
		// (set) Token: 0x060280D8 RID: 164056 RVA: 0x003CF97B File Offset: 0x003CDB7B
		public FSlateBrush NavigationButtonRightImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._NavigationButtonRightImage) == null)
				{
					result = (this._NavigationButtonRightImage = new FSlateBrush(base.NativePtr + (IntPtr)FWidgetCarouselNavigationButtonStyle.__PropertyOffset_NavigationButtonRightImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FWidgetCarouselNavigationButtonStyle.__PropertyOffset_NavigationButtonRightImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060280D9 RID: 164057 RVA: 0x003CF99C File Offset: 0x003CDB9C
		public FWidgetCarouselNavigationButtonStyle()
		{
		}

		// Token: 0x060280DA RID: 164058 RVA: 0x003CF9A4 File Offset: 0x003CDBA4
		public FWidgetCarouselNavigationButtonStyle(FButtonStyle InnerButtonStyle, FSlateBrush NavigationButtonLeftImage, FSlateBrush NavigationButtonRightImage)
		{
			this.InnerButtonStyle = InnerButtonStyle;
			this.NavigationButtonLeftImage = NavigationButtonLeftImage;
			this.NavigationButtonRightImage = NavigationButtonRightImage;
		}

		// Token: 0x060280DB RID: 164059 RVA: 0x003CF9C1 File Offset: 0x003CDBC1
		protected override IntPtr GetUStructPtr()
		{
			return FWidgetCarouselNavigationButtonStyle.StaticStruct();
		}

		// Token: 0x060280DC RID: 164060 RVA: 0x003CF9CD File Offset: 0x003CDBCD
		[NullableContext(2)]
		public FWidgetCarouselNavigationButtonStyle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060280DD RID: 164061 RVA: 0x003CF9D7 File Offset: 0x003CDBD7
		public FWidgetCarouselNavigationButtonStyle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060280DE RID: 164062 RVA: 0x003CF9E2 File Offset: 0x003CDBE2
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWidgetCarouselNavigationButtonStyle(Pointer, false, true);
		}

		// Token: 0x060280DF RID: 164063 RVA: 0x003CF9EC File Offset: 0x003CDBEC
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWidgetCarouselNavigationButtonStyle(Pointer, MemoryOwner);
		}

		// Token: 0x04015F87 RID: 89991
		public new const string __ObjectPath = "/Script/WidgetCarousel.WidgetCarouselNavigationButtonStyle";

		// Token: 0x04015F88 RID: 89992
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015F89 RID: 89993
		internal static int __PropertyOffset_InnerButtonStyle;

		// Token: 0x04015F8A RID: 89994
		[Nullable(2)]
		private FButtonStyle _InnerButtonStyle;

		// Token: 0x04015F8B RID: 89995
		internal static int __PropertyOffset_NavigationButtonLeftImage;

		// Token: 0x04015F8C RID: 89996
		[Nullable(2)]
		private FSlateBrush _NavigationButtonLeftImage;

		// Token: 0x04015F8D RID: 89997
		internal static int __PropertyOffset_NavigationButtonRightImage;

		// Token: 0x04015F8E RID: 89998
		[Nullable(2)]
		private FSlateBrush _NavigationButtonRightImage;
	}
}
