using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029D0 RID: 10704
	[UnrealObjectPath("/Script/UMG.ScrollBar")]
	[UnrealStructLayout(2160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2160)]
	public class UScrollBar : UWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027927 RID: 162087 RVA: 0x003C5EB1 File Offset: 0x003C40B1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UScrollBar._ClassPtr;
		}

		// Token: 0x06027928 RID: 162088 RVA: 0x003C5EC0 File Offset: 0x003C40C0
		public UScrollBar() : this(BuiltinUtils.AllocNativeUObject(UScrollBar.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027929 RID: 162089 RVA: 0x003C5EE8 File Offset: 0x003C40E8
		[NullableContext(1)]
		public UScrollBar(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UScrollBar.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170097A1 RID: 38817
		// (get) Token: 0x0602792A RID: 162090 RVA: 0x003C5F1C File Offset: 0x003C411C
		// (set) Token: 0x0602792B RID: 162091 RVA: 0x003C5F55 File Offset: 0x003C4155
		[Nullable(1)]
		public FScrollBarStyle WidgetStyle
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FScrollBarStyle result;
				if ((result = this._WidgetStyle) == null)
				{
					result = (this._WidgetStyle = new FScrollBarStyle(base.NativePtr + (IntPtr)UScrollBar.__PropertyOffset_WidgetStyle, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FScrollBarStyle.StaticStruct(), base.NativePtr + (IntPtr)UScrollBar.__PropertyOffset_WidgetStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170097A2 RID: 38818
		// (get) Token: 0x0602792C RID: 162092 RVA: 0x003C5F76 File Offset: 0x003C4176
		// (set) Token: 0x0602792D RID: 162093 RVA: 0x003C5F8A File Offset: 0x003C418A
		[Nullable(2)]
		public unsafe USlateWidgetStyleAsset Style_DEPRECATED
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USlateWidgetStyleAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UScrollBar.__PropertyOffset_Style_DEPRECATED);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UScrollBar.__PropertyOffset_Style_DEPRECATED, value);
			}
		}

		// Token: 0x170097A3 RID: 38819
		// (get) Token: 0x0602792E RID: 162094 RVA: 0x003C5F9F File Offset: 0x003C419F
		// (set) Token: 0x0602792F RID: 162095 RVA: 0x003C5FAF File Offset: 0x003C41AF
		public unsafe bool bAlwaysShowScrollbar
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UScrollBar.__PropertyOffset_bAlwaysShowScrollbar) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UScrollBar.__PropertyOffset_bAlwaysShowScrollbar) = (value ? 1 : 0);
			}
		}

		// Token: 0x170097A4 RID: 38820
		// (get) Token: 0x06027930 RID: 162096 RVA: 0x003C5FC0 File Offset: 0x003C41C0
		// (set) Token: 0x06027931 RID: 162097 RVA: 0x003C5FD0 File Offset: 0x003C41D0
		public unsafe bool bAlwaysShowScrollbarTrack
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UScrollBar.__PropertyOffset_bAlwaysShowScrollbarTrack) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UScrollBar.__PropertyOffset_bAlwaysShowScrollbarTrack) = (value ? 1 : 0);
			}
		}

		// Token: 0x170097A5 RID: 38821
		// (get) Token: 0x06027932 RID: 162098 RVA: 0x003C5FE1 File Offset: 0x003C41E1
		// (set) Token: 0x06027933 RID: 162099 RVA: 0x003C5FF5 File Offset: 0x003C41F5
		public unsafe TEnumAsByte<EOrientation> Orientation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UScrollBar.__PropertyOffset_Orientation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UScrollBar.__PropertyOffset_Orientation) = value;
			}
		}

		// Token: 0x170097A6 RID: 38822
		// (get) Token: 0x06027934 RID: 162100 RVA: 0x003C600A File Offset: 0x003C420A
		// (set) Token: 0x06027935 RID: 162101 RVA: 0x003C601E File Offset: 0x003C421E
		public unsafe FVector2D Thickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UScrollBar.__PropertyOffset_Thickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UScrollBar.__PropertyOffset_Thickness) = value;
			}
		}

		// Token: 0x170097A7 RID: 38823
		// (get) Token: 0x06027936 RID: 162102 RVA: 0x003C6033 File Offset: 0x003C4233
		// (set) Token: 0x06027937 RID: 162103 RVA: 0x003C6047 File Offset: 0x003C4247
		public unsafe FMargin Padding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UScrollBar.__PropertyOffset_Padding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UScrollBar.__PropertyOffset_Padding) = value;
			}
		}

		// Token: 0x06027938 RID: 162104 RVA: 0x003C605C File Offset: 0x003C425C
		public void SetState(float InOffsetFraction, float InThumbSizeFraction)
		{
			UScrollBar.__SetState_Internal(base.NativePtr, InOffsetFraction, InThumbSizeFraction);
		}

		// Token: 0x06027939 RID: 162105
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetState_Internal(IntPtr @this, float InOffsetFraction, float InThumbSizeFraction);

		// Token: 0x0602793A RID: 162106 RVA: 0x003C606B File Offset: 0x003C426B
		static UScrollBar()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.ScrollBar");
		}

		// Token: 0x0602793B RID: 162107 RVA: 0x003C6079 File Offset: 0x003C4279
		protected UScrollBar(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015B07 RID: 88839
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.ScrollBar";

		// Token: 0x04015B08 RID: 88840
		private static IntPtr _ClassPtr;

		// Token: 0x04015B09 RID: 88841
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015B0A RID: 88842
		internal static int __PropertyOffset_WidgetStyle;

		// Token: 0x04015B0B RID: 88843
		[Nullable(2)]
		private FScrollBarStyle _WidgetStyle;

		// Token: 0x04015B0C RID: 88844
		internal static int __PropertyOffset_Style_DEPRECATED;

		// Token: 0x04015B0D RID: 88845
		internal static int __PropertyOffset_bAlwaysShowScrollbar;

		// Token: 0x04015B0E RID: 88846
		internal static int __PropertyOffset_bAlwaysShowScrollbarTrack;

		// Token: 0x04015B0F RID: 88847
		internal static int __PropertyOffset_Orientation;

		// Token: 0x04015B10 RID: 88848
		internal static int __PropertyOffset_Thickness;

		// Token: 0x04015B11 RID: 88849
		internal static int __PropertyOffset_Padding;
	}
}
