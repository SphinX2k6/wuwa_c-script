using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002938 RID: 10552
	[UnrealObjectPath("/Script/UMG.BackgroundBlur")]
	[UnrealStructLayout(888, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 888)]
	public class UBackgroundBlur : UContentWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027069 RID: 159849 RVA: 0x003B8760 File Offset: 0x003B6960
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBackgroundBlur._ClassPtr;
		}

		// Token: 0x0602706A RID: 159850 RVA: 0x003B876C File Offset: 0x003B696C
		public UBackgroundBlur() : this(BuiltinUtils.AllocNativeUObject(UBackgroundBlur.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602706B RID: 159851 RVA: 0x003B8794 File Offset: 0x003B6994
		[NullableContext(1)]
		public UBackgroundBlur(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBackgroundBlur.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700962B RID: 38443
		// (get) Token: 0x0602706C RID: 159852 RVA: 0x003B87C7 File Offset: 0x003B69C7
		// (set) Token: 0x0602706D RID: 159853 RVA: 0x003B87DB File Offset: 0x003B69DB
		public unsafe FMargin Padding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBackgroundBlur.__PropertyOffset_Padding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBackgroundBlur.__PropertyOffset_Padding) = value;
			}
		}

		// Token: 0x1700962C RID: 38444
		// (get) Token: 0x0602706E RID: 159854 RVA: 0x003B87F0 File Offset: 0x003B69F0
		// (set) Token: 0x0602706F RID: 159855 RVA: 0x003B8804 File Offset: 0x003B6A04
		public unsafe TEnumAsByte<EHorizontalAlignment> HorizontalAlignment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBackgroundBlur.__PropertyOffset_HorizontalAlignment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBackgroundBlur.__PropertyOffset_HorizontalAlignment) = value;
			}
		}

		// Token: 0x1700962D RID: 38445
		// (get) Token: 0x06027070 RID: 159856 RVA: 0x003B8819 File Offset: 0x003B6A19
		// (set) Token: 0x06027071 RID: 159857 RVA: 0x003B882D File Offset: 0x003B6A2D
		public unsafe TEnumAsByte<EVerticalAlignment> VerticalAlignment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBackgroundBlur.__PropertyOffset_VerticalAlignment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBackgroundBlur.__PropertyOffset_VerticalAlignment) = value;
			}
		}

		// Token: 0x1700962E RID: 38446
		// (get) Token: 0x06027072 RID: 159858 RVA: 0x003B8842 File Offset: 0x003B6A42
		// (set) Token: 0x06027073 RID: 159859 RVA: 0x003B8852 File Offset: 0x003B6A52
		public unsafe bool bApplyAlphaToBlur
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBackgroundBlur.__PropertyOffset_bApplyAlphaToBlur) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBackgroundBlur.__PropertyOffset_bApplyAlphaToBlur) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700962F RID: 38447
		// (get) Token: 0x06027074 RID: 159860 RVA: 0x003B8863 File Offset: 0x003B6A63
		// (set) Token: 0x06027075 RID: 159861 RVA: 0x003B8873 File Offset: 0x003B6A73
		public unsafe float BlurStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBackgroundBlur.__PropertyOffset_BlurStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBackgroundBlur.__PropertyOffset_BlurStrength) = value;
			}
		}

		// Token: 0x17009630 RID: 38448
		// (get) Token: 0x06027076 RID: 159862 RVA: 0x003B8884 File Offset: 0x003B6A84
		// (set) Token: 0x06027077 RID: 159863 RVA: 0x003B8894 File Offset: 0x003B6A94
		public unsafe bool bOverrideAutoRadiusCalculation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBackgroundBlur.__PropertyOffset_bOverrideAutoRadiusCalculation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBackgroundBlur.__PropertyOffset_bOverrideAutoRadiusCalculation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009631 RID: 38449
		// (get) Token: 0x06027078 RID: 159864 RVA: 0x003B88A5 File Offset: 0x003B6AA5
		// (set) Token: 0x06027079 RID: 159865 RVA: 0x003B88B5 File Offset: 0x003B6AB5
		public unsafe int BlurRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBackgroundBlur.__PropertyOffset_BlurRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBackgroundBlur.__PropertyOffset_BlurRadius) = value;
			}
		}

		// Token: 0x17009632 RID: 38450
		// (get) Token: 0x0602707A RID: 159866 RVA: 0x003B88C8 File Offset: 0x003B6AC8
		// (set) Token: 0x0602707B RID: 159867 RVA: 0x003B8901 File Offset: 0x003B6B01
		[Nullable(1)]
		public FSlateBrush LowQualityFallbackBrush
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._LowQualityFallbackBrush) == null)
				{
					result = (this._LowQualityFallbackBrush = new FSlateBrush(base.NativePtr + (IntPtr)UBackgroundBlur.__PropertyOffset_LowQualityFallbackBrush, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)UBackgroundBlur.__PropertyOffset_LowQualityFallbackBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602707C RID: 159868 RVA: 0x003B8922 File Offset: 0x003B6B22
		public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
		{
			UBackgroundBlur.__SetVerticalAlignment_Internal(base.NativePtr, InVerticalAlignment);
		}

		// Token: 0x0602707D RID: 159869 RVA: 0x003B8935 File Offset: 0x003B6B35
		public void SetPadding(FMargin InPadding)
		{
			UBackgroundBlur.__SetPadding_Internal(base.NativePtr, InPadding);
		}

		// Token: 0x0602707E RID: 159870 RVA: 0x003B8943 File Offset: 0x003B6B43
		[NullableContext(2)]
		public void SetLowQualityFallbackBrush(in FSlateBrush InBrush)
		{
			UBackgroundBlur.__SetLowQualityFallbackBrush_Internal(base.NativePtr, (InBrush ?? new FSlateBrush()).NativePtr);
		}

		// Token: 0x0602707F RID: 159871 RVA: 0x003B8960 File Offset: 0x003B6B60
		public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
		{
			UBackgroundBlur.__SetHorizontalAlignment_Internal(base.NativePtr, InHorizontalAlignment);
		}

		// Token: 0x06027080 RID: 159872 RVA: 0x003B8973 File Offset: 0x003B6B73
		public void SetBlurStrength(float InStrength)
		{
			UBackgroundBlur.__SetBlurStrength_Internal(base.NativePtr, InStrength);
		}

		// Token: 0x06027081 RID: 159873 RVA: 0x003B8981 File Offset: 0x003B6B81
		public void SetBlurRadius(int InBlurRadius)
		{
			UBackgroundBlur.__SetBlurRadius_Internal(base.NativePtr, InBlurRadius);
		}

		// Token: 0x06027082 RID: 159874 RVA: 0x003B898F File Offset: 0x003B6B8F
		public void SetApplyAlphaToBlur(bool bInApplyAlphaToBlur)
		{
			UBackgroundBlur.__SetApplyAlphaToBlur_Internal(base.NativePtr, bInApplyAlphaToBlur);
		}

		// Token: 0x06027083 RID: 159875
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVerticalAlignment_Internal(IntPtr @this, TEnumAsByte<EVerticalAlignment> InVerticalAlignment);

		// Token: 0x06027084 RID: 159876
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPadding_Internal(IntPtr @this, FMargin InPadding);

		// Token: 0x06027085 RID: 159877
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLowQualityFallbackBrush_Internal(IntPtr @this, IntPtr InBrush);

		// Token: 0x06027086 RID: 159878
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHorizontalAlignment_Internal(IntPtr @this, TEnumAsByte<EHorizontalAlignment> InHorizontalAlignment);

		// Token: 0x06027087 RID: 159879
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBlurStrength_Internal(IntPtr @this, float InStrength);

		// Token: 0x06027088 RID: 159880
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBlurRadius_Internal(IntPtr @this, int InBlurRadius);

		// Token: 0x06027089 RID: 159881
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetApplyAlphaToBlur_Internal(IntPtr @this, bool bInApplyAlphaToBlur);

		// Token: 0x0602708A RID: 159882 RVA: 0x003B899D File Offset: 0x003B6B9D
		static UBackgroundBlur()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.BackgroundBlur");
		}

		// Token: 0x0602708B RID: 159883 RVA: 0x003B89AB File Offset: 0x003B6BAB
		protected UBackgroundBlur(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015728 RID: 87848
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.BackgroundBlur";

		// Token: 0x04015729 RID: 87849
		private static IntPtr _ClassPtr;

		// Token: 0x0401572A RID: 87850
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401572B RID: 87851
		internal static int __PropertyOffset_Padding;

		// Token: 0x0401572C RID: 87852
		internal static int __PropertyOffset_HorizontalAlignment;

		// Token: 0x0401572D RID: 87853
		internal static int __PropertyOffset_VerticalAlignment;

		// Token: 0x0401572E RID: 87854
		internal static int __PropertyOffset_bApplyAlphaToBlur;

		// Token: 0x0401572F RID: 87855
		internal static int __PropertyOffset_BlurStrength;

		// Token: 0x04015730 RID: 87856
		internal static int __PropertyOffset_bOverrideAutoRadiusCalculation;

		// Token: 0x04015731 RID: 87857
		internal static int __PropertyOffset_BlurRadius;

		// Token: 0x04015732 RID: 87858
		internal static int __PropertyOffset_LowQualityFallbackBrush;

		// Token: 0x04015733 RID: 87859
		[Nullable(2)]
		private FSlateBrush _LowQualityFallbackBrush;
	}
}
