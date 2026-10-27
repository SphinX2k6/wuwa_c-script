using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018FB RID: 6395
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroMultilBgProgressBar")]
	[UnrealStructLayout(1560, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1560)]
	public class UKuroMultilBgProgressBar : UWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017B9F RID: 97183 RVA: 0x0022C3CE File Offset: 0x0022A5CE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroMultilBgProgressBar._ClassPtr;
		}

		// Token: 0x06017BA0 RID: 97184 RVA: 0x0022C3DC File Offset: 0x0022A5DC
		public UKuroMultilBgProgressBar() : this(BuiltinUtils.AllocNativeUObject(UKuroMultilBgProgressBar.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017BA1 RID: 97185 RVA: 0x0022C404 File Offset: 0x0022A604
		[NullableContext(1)]
		public UKuroMultilBgProgressBar(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroMultilBgProgressBar.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005F8B RID: 24459
		// (get) Token: 0x06017BA2 RID: 97186 RVA: 0x0022C438 File Offset: 0x0022A638
		// (set) Token: 0x06017BA3 RID: 97187 RVA: 0x0022C471 File Offset: 0x0022A671
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
					result = (this._WidgetStyle = new FProgressBarStyle(base.NativePtr + (IntPtr)UKuroMultilBgProgressBar.__PropertyOffset_WidgetStyle, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FProgressBarStyle.StaticStruct(), base.NativePtr + (IntPtr)UKuroMultilBgProgressBar.__PropertyOffset_WidgetStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005F8C RID: 24460
		// (get) Token: 0x06017BA4 RID: 97188 RVA: 0x0022C492 File Offset: 0x0022A692
		// (set) Token: 0x06017BA5 RID: 97189 RVA: 0x0022C4A6 File Offset: 0x0022A6A6
		public unsafe USlateWidgetStyleAsset Style_DEPRECATED
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USlateWidgetStyleAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroMultilBgProgressBar.__PropertyOffset_Style_DEPRECATED);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroMultilBgProgressBar.__PropertyOffset_Style_DEPRECATED, value);
			}
		}

		// Token: 0x17005F8D RID: 24461
		// (get) Token: 0x06017BA6 RID: 97190 RVA: 0x0022C4BB File Offset: 0x0022A6BB
		// (set) Token: 0x06017BA7 RID: 97191 RVA: 0x0022C4CF File Offset: 0x0022A6CF
		public unsafe USlateBrushAsset BackgroundImage_DEPRECATED
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USlateBrushAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroMultilBgProgressBar.__PropertyOffset_BackgroundImage_DEPRECATED);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroMultilBgProgressBar.__PropertyOffset_BackgroundImage_DEPRECATED, value);
			}
		}

		// Token: 0x17005F8E RID: 24462
		// (get) Token: 0x06017BA8 RID: 97192 RVA: 0x0022C4E4 File Offset: 0x0022A6E4
		// (set) Token: 0x06017BA9 RID: 97193 RVA: 0x0022C4F8 File Offset: 0x0022A6F8
		public unsafe USlateBrushAsset FillImageMiddle_DEPRECATED
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USlateBrushAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroMultilBgProgressBar.__PropertyOffset_FillImageMiddle_DEPRECATED);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroMultilBgProgressBar.__PropertyOffset_FillImageMiddle_DEPRECATED, value);
			}
		}

		// Token: 0x17005F8F RID: 24463
		// (get) Token: 0x06017BAA RID: 97194 RVA: 0x0022C50D File Offset: 0x0022A70D
		// (set) Token: 0x06017BAB RID: 97195 RVA: 0x0022C521 File Offset: 0x0022A721
		public unsafe USlateBrushAsset FillImage_DEPRECATED
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USlateBrushAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroMultilBgProgressBar.__PropertyOffset_FillImage_DEPRECATED);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroMultilBgProgressBar.__PropertyOffset_FillImage_DEPRECATED, value);
			}
		}

		// Token: 0x17005F90 RID: 24464
		// (get) Token: 0x06017BAC RID: 97196 RVA: 0x0022C536 File Offset: 0x0022A736
		// (set) Token: 0x06017BAD RID: 97197 RVA: 0x0022C54A File Offset: 0x0022A74A
		public unsafe USlateBrushAsset MarqueeImage_DEPRECATED
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USlateBrushAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroMultilBgProgressBar.__PropertyOffset_MarqueeImage_DEPRECATED);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroMultilBgProgressBar.__PropertyOffset_MarqueeImage_DEPRECATED, value);
			}
		}

		// Token: 0x17005F91 RID: 24465
		// (get) Token: 0x06017BAE RID: 97198 RVA: 0x0022C55F File Offset: 0x0022A75F
		// (set) Token: 0x06017BAF RID: 97199 RVA: 0x0022C56F File Offset: 0x0022A76F
		public unsafe float MiddlePercent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMultilBgProgressBar.__PropertyOffset_MiddlePercent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMultilBgProgressBar.__PropertyOffset_MiddlePercent) = value;
			}
		}

		// Token: 0x17005F92 RID: 24466
		// (get) Token: 0x06017BB0 RID: 97200 RVA: 0x0022C580 File Offset: 0x0022A780
		// (set) Token: 0x06017BB1 RID: 97201 RVA: 0x0022C590 File Offset: 0x0022A790
		public unsafe float Percent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMultilBgProgressBar.__PropertyOffset_Percent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMultilBgProgressBar.__PropertyOffset_Percent) = value;
			}
		}

		// Token: 0x17005F93 RID: 24467
		// (get) Token: 0x06017BB2 RID: 97202 RVA: 0x0022C5A1 File Offset: 0x0022A7A1
		// (set) Token: 0x06017BB3 RID: 97203 RVA: 0x0022C5B5 File Offset: 0x0022A7B5
		[Nullable(0)]
		public unsafe TEnumAsByte<EProgressBarFillType> BarFillType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMultilBgProgressBar.__PropertyOffset_BarFillType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMultilBgProgressBar.__PropertyOffset_BarFillType) = value;
			}
		}

		// Token: 0x17005F94 RID: 24468
		// (get) Token: 0x06017BB4 RID: 97204 RVA: 0x0022C5CA File Offset: 0x0022A7CA
		// (set) Token: 0x06017BB5 RID: 97205 RVA: 0x0022C5DA File Offset: 0x0022A7DA
		public unsafe bool bIsMarquee
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMultilBgProgressBar.__PropertyOffset_bIsMarquee) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMultilBgProgressBar.__PropertyOffset_bIsMarquee) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F95 RID: 24469
		// (get) Token: 0x06017BB6 RID: 97206 RVA: 0x0022C5EB File Offset: 0x0022A7EB
		// (set) Token: 0x06017BB7 RID: 97207 RVA: 0x0022C5FF File Offset: 0x0022A7FF
		public unsafe FVector2D BorderPadding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMultilBgProgressBar.__PropertyOffset_BorderPadding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMultilBgProgressBar.__PropertyOffset_BorderPadding) = value;
			}
		}

		// Token: 0x17005F96 RID: 24470
		// (get) Token: 0x06017BB8 RID: 97208 RVA: 0x0022C614 File Offset: 0x0022A814
		// (set) Token: 0x06017BB9 RID: 97209 RVA: 0x0022C64D File Offset: 0x0022A84D
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
					result = (this._PercentDelegate = new FGetFloat(base.NativePtr + (IntPtr)UKuroMultilBgProgressBar.__PropertyOffset_PercentDelegate, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroMultilBgProgressBar.__PropertyOffset_PercentDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17005F97 RID: 24471
		// (get) Token: 0x06017BBA RID: 97210 RVA: 0x0022C670 File Offset: 0x0022A870
		// (set) Token: 0x06017BBB RID: 97211 RVA: 0x0022C6A9 File Offset: 0x0022A8A9
		[Nullable(1)]
		public FGetFloat MiddlePercentDelegate
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FGetFloat result;
				if ((result = this._MiddlePercentDelegate) == null)
				{
					result = (this._MiddlePercentDelegate = new FGetFloat(base.NativePtr + (IntPtr)UKuroMultilBgProgressBar.__PropertyOffset_MiddlePercentDelegate, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroMultilBgProgressBar.__PropertyOffset_MiddlePercentDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17005F98 RID: 24472
		// (get) Token: 0x06017BBC RID: 97212 RVA: 0x0022C6CA File Offset: 0x0022A8CA
		// (set) Token: 0x06017BBD RID: 97213 RVA: 0x0022C6DE File Offset: 0x0022A8DE
		public unsafe FLinearColor FillColorAndOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMultilBgProgressBar.__PropertyOffset_FillColorAndOpacity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMultilBgProgressBar.__PropertyOffset_FillColorAndOpacity) = value;
			}
		}

		// Token: 0x17005F99 RID: 24473
		// (get) Token: 0x06017BBE RID: 97214 RVA: 0x0022C6F4 File Offset: 0x0022A8F4
		// (set) Token: 0x06017BBF RID: 97215 RVA: 0x0022C72D File Offset: 0x0022A92D
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
					result = (this._FillColorAndOpacityDelegate = new FGetLinearColor(base.NativePtr + (IntPtr)UKuroMultilBgProgressBar.__PropertyOffset_FillColorAndOpacityDelegate, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroMultilBgProgressBar.__PropertyOffset_FillColorAndOpacityDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06017BC0 RID: 97216 RVA: 0x0022C74E File Offset: 0x0022A94E
		public void SetPercent(float InPercent)
		{
			UKuroMultilBgProgressBar.__SetPercent_Internal(base.NativePtr, InPercent);
		}

		// Token: 0x06017BC1 RID: 97217 RVA: 0x0022C75C File Offset: 0x0022A95C
		public void SetMiddlePercent(float InPercent)
		{
			UKuroMultilBgProgressBar.__SetMiddlePercent_Internal(base.NativePtr, InPercent);
		}

		// Token: 0x06017BC2 RID: 97218 RVA: 0x0022C76A File Offset: 0x0022A96A
		public void SetIsMarquee(bool InbIsMarquee)
		{
			UKuroMultilBgProgressBar.__SetIsMarquee_Internal(base.NativePtr, InbIsMarquee);
		}

		// Token: 0x06017BC3 RID: 97219 RVA: 0x0022C778 File Offset: 0x0022A978
		public void SetFillColorAndOpacity(FLinearColor InColor)
		{
			UKuroMultilBgProgressBar.__SetFillColorAndOpacity_Internal(base.NativePtr, InColor);
		}

		// Token: 0x06017BC4 RID: 97220
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPercent_Internal(IntPtr @this, float InPercent);

		// Token: 0x06017BC5 RID: 97221
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMiddlePercent_Internal(IntPtr @this, float InPercent);

		// Token: 0x06017BC6 RID: 97222
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsMarquee_Internal(IntPtr @this, bool InbIsMarquee);

		// Token: 0x06017BC7 RID: 97223
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFillColorAndOpacity_Internal(IntPtr @this, FLinearColor InColor);

		// Token: 0x06017BC8 RID: 97224 RVA: 0x0022C786 File Offset: 0x0022A986
		static UKuroMultilBgProgressBar()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroMultilBgProgressBar");
		}

		// Token: 0x06017BC9 RID: 97225 RVA: 0x0022C794 File Offset: 0x0022A994
		protected UKuroMultilBgProgressBar(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CE06 RID: 52742
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroMultilBgProgressBar";

		// Token: 0x0400CE07 RID: 52743
		private static IntPtr _ClassPtr;

		// Token: 0x0400CE08 RID: 52744
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CE09 RID: 52745
		internal static int __PropertyOffset_WidgetStyle;

		// Token: 0x0400CE0A RID: 52746
		private FProgressBarStyle _WidgetStyle;

		// Token: 0x0400CE0B RID: 52747
		internal static int __PropertyOffset_Style_DEPRECATED;

		// Token: 0x0400CE0C RID: 52748
		internal static int __PropertyOffset_BackgroundImage_DEPRECATED;

		// Token: 0x0400CE0D RID: 52749
		internal static int __PropertyOffset_FillImageMiddle_DEPRECATED;

		// Token: 0x0400CE0E RID: 52750
		internal static int __PropertyOffset_FillImage_DEPRECATED;

		// Token: 0x0400CE0F RID: 52751
		internal static int __PropertyOffset_MarqueeImage_DEPRECATED;

		// Token: 0x0400CE10 RID: 52752
		internal static int __PropertyOffset_MiddlePercent;

		// Token: 0x0400CE11 RID: 52753
		internal static int __PropertyOffset_Percent;

		// Token: 0x0400CE12 RID: 52754
		internal static int __PropertyOffset_BarFillType;

		// Token: 0x0400CE13 RID: 52755
		internal static int __PropertyOffset_bIsMarquee;

		// Token: 0x0400CE14 RID: 52756
		internal static int __PropertyOffset_BorderPadding;

		// Token: 0x0400CE15 RID: 52757
		internal static int __PropertyOffset_PercentDelegate;

		// Token: 0x0400CE16 RID: 52758
		private FGetFloat _PercentDelegate;

		// Token: 0x0400CE17 RID: 52759
		internal static int __PropertyOffset_MiddlePercentDelegate;

		// Token: 0x0400CE18 RID: 52760
		private FGetFloat _MiddlePercentDelegate;

		// Token: 0x0400CE19 RID: 52761
		internal static int __PropertyOffset_FillColorAndOpacity;

		// Token: 0x0400CE1A RID: 52762
		internal static int __PropertyOffset_FillColorAndOpacityDelegate;

		// Token: 0x0400CE1B RID: 52763
		private FGetLinearColor _FillColorAndOpacityDelegate;
	}
}
