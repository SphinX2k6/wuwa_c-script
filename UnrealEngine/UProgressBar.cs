using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029C3 RID: 10691
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.ProgressBar")]
	[UnrealStructLayout(1504, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1504)]
	public class UProgressBar : UWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027837 RID: 161847 RVA: 0x003C4C95 File Offset: 0x003C2E95
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UProgressBar._ClassPtr;
		}

		// Token: 0x06027838 RID: 161848 RVA: 0x003C4CA4 File Offset: 0x003C2EA4
		public UProgressBar() : this(BuiltinUtils.AllocNativeUObject(UProgressBar.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027839 RID: 161849 RVA: 0x003C4CCC File Offset: 0x003C2ECC
		[NullableContext(1)]
		public UProgressBar(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UProgressBar.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700976C RID: 38764
		// (get) Token: 0x0602783A RID: 161850 RVA: 0x003C4D00 File Offset: 0x003C2F00
		// (set) Token: 0x0602783B RID: 161851 RVA: 0x003C4D39 File Offset: 0x003C2F39
		[Nullable(1)]
		public FProgressBarStyle WidgetStyle
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FProgressBarStyle result;
				if ((result = this._WidgetStyle) == null)
				{
					result = (this._WidgetStyle = new FProgressBarStyle(base.NativePtr + (IntPtr)UProgressBar.__PropertyOffset_WidgetStyle, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FProgressBarStyle.StaticStruct(), base.NativePtr + (IntPtr)UProgressBar.__PropertyOffset_WidgetStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700976D RID: 38765
		// (get) Token: 0x0602783C RID: 161852 RVA: 0x003C4D5A File Offset: 0x003C2F5A
		// (set) Token: 0x0602783D RID: 161853 RVA: 0x003C4D6E File Offset: 0x003C2F6E
		public unsafe USlateWidgetStyleAsset Style_DEPRECATED
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USlateWidgetStyleAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UProgressBar.__PropertyOffset_Style_DEPRECATED);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UProgressBar.__PropertyOffset_Style_DEPRECATED, value);
			}
		}

		// Token: 0x1700976E RID: 38766
		// (get) Token: 0x0602783E RID: 161854 RVA: 0x003C4D83 File Offset: 0x003C2F83
		// (set) Token: 0x0602783F RID: 161855 RVA: 0x003C4D97 File Offset: 0x003C2F97
		public unsafe USlateBrushAsset BackgroundImage_DEPRECATED
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USlateBrushAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UProgressBar.__PropertyOffset_BackgroundImage_DEPRECATED);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UProgressBar.__PropertyOffset_BackgroundImage_DEPRECATED, value);
			}
		}

		// Token: 0x1700976F RID: 38767
		// (get) Token: 0x06027840 RID: 161856 RVA: 0x003C4DAC File Offset: 0x003C2FAC
		// (set) Token: 0x06027841 RID: 161857 RVA: 0x003C4DC0 File Offset: 0x003C2FC0
		public unsafe USlateBrushAsset FillImage_DEPRECATED
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USlateBrushAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UProgressBar.__PropertyOffset_FillImage_DEPRECATED);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UProgressBar.__PropertyOffset_FillImage_DEPRECATED, value);
			}
		}

		// Token: 0x17009770 RID: 38768
		// (get) Token: 0x06027842 RID: 161858 RVA: 0x003C4DD5 File Offset: 0x003C2FD5
		// (set) Token: 0x06027843 RID: 161859 RVA: 0x003C4DE9 File Offset: 0x003C2FE9
		public unsafe USlateBrushAsset MarqueeImage_DEPRECATED
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USlateBrushAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UProgressBar.__PropertyOffset_MarqueeImage_DEPRECATED);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UProgressBar.__PropertyOffset_MarqueeImage_DEPRECATED, value);
			}
		}

		// Token: 0x17009771 RID: 38769
		// (get) Token: 0x06027844 RID: 161860 RVA: 0x003C4DFE File Offset: 0x003C2FFE
		// (set) Token: 0x06027845 RID: 161861 RVA: 0x003C4E0E File Offset: 0x003C300E
		public unsafe float Percent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UProgressBar.__PropertyOffset_Percent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UProgressBar.__PropertyOffset_Percent) = value;
			}
		}

		// Token: 0x17009772 RID: 38770
		// (get) Token: 0x06027846 RID: 161862 RVA: 0x003C4E1F File Offset: 0x003C301F
		// (set) Token: 0x06027847 RID: 161863 RVA: 0x003C4E33 File Offset: 0x003C3033
		[Nullable(0)]
		public unsafe TEnumAsByte<EProgressBarFillType> BarFillType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UProgressBar.__PropertyOffset_BarFillType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UProgressBar.__PropertyOffset_BarFillType) = value;
			}
		}

		// Token: 0x17009773 RID: 38771
		// (get) Token: 0x06027848 RID: 161864 RVA: 0x003C4E48 File Offset: 0x003C3048
		// (set) Token: 0x06027849 RID: 161865 RVA: 0x003C4E58 File Offset: 0x003C3058
		public unsafe bool bIsMarquee
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UProgressBar.__PropertyOffset_bIsMarquee) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UProgressBar.__PropertyOffset_bIsMarquee) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009774 RID: 38772
		// (get) Token: 0x0602784A RID: 161866 RVA: 0x003C4E69 File Offset: 0x003C3069
		// (set) Token: 0x0602784B RID: 161867 RVA: 0x003C4E7D File Offset: 0x003C307D
		public unsafe FVector2D BorderPadding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UProgressBar.__PropertyOffset_BorderPadding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UProgressBar.__PropertyOffset_BorderPadding) = value;
			}
		}

		// Token: 0x17009775 RID: 38773
		// (get) Token: 0x0602784C RID: 161868 RVA: 0x003C4E94 File Offset: 0x003C3094
		// (set) Token: 0x0602784D RID: 161869 RVA: 0x003C4ECD File Offset: 0x003C30CD
		[Nullable(1)]
		public FGetFloat PercentDelegate
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FGetFloat result;
				if ((result = this._PercentDelegate) == null)
				{
					result = (this._PercentDelegate = new FGetFloat(base.NativePtr + (IntPtr)UProgressBar.__PropertyOffset_PercentDelegate, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UProgressBar.__PropertyOffset_PercentDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17009776 RID: 38774
		// (get) Token: 0x0602784E RID: 161870 RVA: 0x003C4EEE File Offset: 0x003C30EE
		// (set) Token: 0x0602784F RID: 161871 RVA: 0x003C4F02 File Offset: 0x003C3102
		public unsafe FLinearColor FillColorAndOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UProgressBar.__PropertyOffset_FillColorAndOpacity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UProgressBar.__PropertyOffset_FillColorAndOpacity) = value;
			}
		}

		// Token: 0x17009777 RID: 38775
		// (get) Token: 0x06027850 RID: 161872 RVA: 0x003C4F18 File Offset: 0x003C3118
		// (set) Token: 0x06027851 RID: 161873 RVA: 0x003C4F51 File Offset: 0x003C3151
		[Nullable(1)]
		public FGetLinearColor FillColorAndOpacityDelegate
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FGetLinearColor result;
				if ((result = this._FillColorAndOpacityDelegate) == null)
				{
					result = (this._FillColorAndOpacityDelegate = new FGetLinearColor(base.NativePtr + (IntPtr)UProgressBar.__PropertyOffset_FillColorAndOpacityDelegate, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UProgressBar.__PropertyOffset_FillColorAndOpacityDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06027852 RID: 161874 RVA: 0x003C4F72 File Offset: 0x003C3172
		public void SetPercent(float InPercent)
		{
			UProgressBar.__SetPercent_Internal(base.NativePtr, InPercent);
		}

		// Token: 0x06027853 RID: 161875 RVA: 0x003C4F80 File Offset: 0x003C3180
		public void SetIsMarquee(bool InbIsMarquee)
		{
			UProgressBar.__SetIsMarquee_Internal(base.NativePtr, InbIsMarquee);
		}

		// Token: 0x06027854 RID: 161876 RVA: 0x003C4F8E File Offset: 0x003C318E
		public void SetFillColorAndOpacity(FLinearColor InColor)
		{
			UProgressBar.__SetFillColorAndOpacity_Internal(base.NativePtr, InColor);
		}

		// Token: 0x06027855 RID: 161877
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPercent_Internal(IntPtr @this, float InPercent);

		// Token: 0x06027856 RID: 161878
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsMarquee_Internal(IntPtr @this, bool InbIsMarquee);

		// Token: 0x06027857 RID: 161879
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFillColorAndOpacity_Internal(IntPtr @this, FLinearColor InColor);

		// Token: 0x06027858 RID: 161880 RVA: 0x003C4F9C File Offset: 0x003C319C
		static UProgressBar()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.ProgressBar");
		}

		// Token: 0x06027859 RID: 161881 RVA: 0x003C4FAA File Offset: 0x003C31AA
		protected UProgressBar(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015AA3 RID: 88739
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.ProgressBar";

		// Token: 0x04015AA4 RID: 88740
		private static IntPtr _ClassPtr;

		// Token: 0x04015AA5 RID: 88741
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015AA6 RID: 88742
		internal static int __PropertyOffset_WidgetStyle;

		// Token: 0x04015AA7 RID: 88743
		private FProgressBarStyle _WidgetStyle;

		// Token: 0x04015AA8 RID: 88744
		internal static int __PropertyOffset_Style_DEPRECATED;

		// Token: 0x04015AA9 RID: 88745
		internal static int __PropertyOffset_BackgroundImage_DEPRECATED;

		// Token: 0x04015AAA RID: 88746
		internal static int __PropertyOffset_FillImage_DEPRECATED;

		// Token: 0x04015AAB RID: 88747
		internal static int __PropertyOffset_MarqueeImage_DEPRECATED;

		// Token: 0x04015AAC RID: 88748
		internal static int __PropertyOffset_Percent;

		// Token: 0x04015AAD RID: 88749
		internal static int __PropertyOffset_BarFillType;

		// Token: 0x04015AAE RID: 88750
		internal static int __PropertyOffset_bIsMarquee;

		// Token: 0x04015AAF RID: 88751
		internal static int __PropertyOffset_BorderPadding;

		// Token: 0x04015AB0 RID: 88752
		internal static int __PropertyOffset_PercentDelegate;

		// Token: 0x04015AB1 RID: 88753
		private FGetFloat _PercentDelegate;

		// Token: 0x04015AB2 RID: 88754
		internal static int __PropertyOffset_FillColorAndOpacity;

		// Token: 0x04015AB3 RID: 88755
		internal static int __PropertyOffset_FillColorAndOpacityDelegate;

		// Token: 0x04015AB4 RID: 88756
		private FGetLinearColor _FillColorAndOpacityDelegate;
	}
}
