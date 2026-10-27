using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029C8 RID: 10696
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.RichTextBlock")]
	[UnrealStructLayout(2224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2224)]
	public class URichTextBlock : UTextLayoutWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602789C RID: 161948 RVA: 0x003C546F File Offset: 0x003C366F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URichTextBlock._ClassPtr;
		}

		// Token: 0x0602789D RID: 161949 RVA: 0x003C547C File Offset: 0x003C367C
		public URichTextBlock() : this(BuiltinUtils.AllocNativeUObject(URichTextBlock.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602789E RID: 161950 RVA: 0x003C54A4 File Offset: 0x003C36A4
		public URichTextBlock(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URichTextBlock.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009786 RID: 38790
		// (get) Token: 0x0602789F RID: 161951 RVA: 0x003C54D8 File Offset: 0x003C36D8
		// (set) Token: 0x060278A0 RID: 161952 RVA: 0x003C5511 File Offset: 0x003C3711
		public unsafe FText Text
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._Text) == null)
				{
					result = (this._Text = new FText(base.NativePtr + (IntPtr)URichTextBlock.__PropertyOffset_Text, this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)URichTextBlock.__PropertyOffset_Text)), value.NativePtr, 1);
			}
		}

		// Token: 0x17009787 RID: 38791
		// (get) Token: 0x060278A1 RID: 161953 RVA: 0x003C552C File Offset: 0x003C372C
		// (set) Token: 0x060278A2 RID: 161954 RVA: 0x003C5540 File Offset: 0x003C3740
		[Nullable(2)]
		public unsafe UDataTable TextStyleSet
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + URichTextBlock.__PropertyOffset_TextStyleSet);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + URichTextBlock.__PropertyOffset_TextStyleSet, value);
			}
		}

		// Token: 0x17009788 RID: 38792
		// (get) Token: 0x060278A3 RID: 161955 RVA: 0x003C5558 File Offset: 0x003C3758
		// (set) Token: 0x060278A4 RID: 161956 RVA: 0x003C5591 File Offset: 0x003C3791
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TSubclassOf<URichTextBlockDecorator>> DecoratorClasses
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TSubclassOf<URichTextBlockDecorator>> result;
				if ((result = this._DecoratorClasses) == null)
				{
					result = (this._DecoratorClasses = new TArray<TSubclassOf<URichTextBlockDecorator>>(base.NativePtr + (IntPtr)URichTextBlock.__PropertyOffset_DecoratorClasses, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.DecoratorClasses.CopyAssign(value);
			}
		}

		// Token: 0x17009789 RID: 38793
		// (get) Token: 0x060278A5 RID: 161957 RVA: 0x003C559F File Offset: 0x003C379F
		// (set) Token: 0x060278A6 RID: 161958 RVA: 0x003C55AF File Offset: 0x003C37AF
		public unsafe bool bOverrideDefaultStyle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URichTextBlock.__PropertyOffset_bOverrideDefaultStyle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URichTextBlock.__PropertyOffset_bOverrideDefaultStyle) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700978A RID: 38794
		// (get) Token: 0x060278A7 RID: 161959 RVA: 0x003C55C0 File Offset: 0x003C37C0
		// (set) Token: 0x060278A8 RID: 161960 RVA: 0x003C55F9 File Offset: 0x003C37F9
		public FTextBlockStyle DefaultTextStyleOverride
		{
			get
			{
				base.FastCheckIsValid();
				FTextBlockStyle result;
				if ((result = this._DefaultTextStyleOverride) == null)
				{
					result = (this._DefaultTextStyleOverride = new FTextBlockStyle(base.NativePtr + (IntPtr)URichTextBlock.__PropertyOffset_DefaultTextStyleOverride, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextBlockStyle.StaticStruct(), base.NativePtr + (IntPtr)URichTextBlock.__PropertyOffset_DefaultTextStyleOverride, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700978B RID: 38795
		// (get) Token: 0x060278A9 RID: 161961 RVA: 0x003C561A File Offset: 0x003C381A
		// (set) Token: 0x060278AA RID: 161962 RVA: 0x003C562A File Offset: 0x003C382A
		public unsafe float MinDesiredWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URichTextBlock.__PropertyOffset_MinDesiredWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URichTextBlock.__PropertyOffset_MinDesiredWidth) = value;
			}
		}

		// Token: 0x1700978C RID: 38796
		// (get) Token: 0x060278AB RID: 161963 RVA: 0x003C563B File Offset: 0x003C383B
		// (set) Token: 0x060278AC RID: 161964 RVA: 0x003C564B File Offset: 0x003C384B
		public unsafe ETextTransformPolicy TextTransformPolicy
		{
			get
			{
				return (ETextTransformPolicy)(*(base.NativePtr + (IntPtr)URichTextBlock.__PropertyOffset_TextTransformPolicy));
			}
			set
			{
				*(base.NativePtr + (IntPtr)URichTextBlock.__PropertyOffset_TextTransformPolicy) = (byte)value;
			}
		}

		// Token: 0x1700978D RID: 38797
		// (get) Token: 0x060278AD RID: 161965 RVA: 0x003C565C File Offset: 0x003C385C
		// (set) Token: 0x060278AE RID: 161966 RVA: 0x003C5695 File Offset: 0x003C3895
		public FTextBlockStyle DefaultTextStyle
		{
			get
			{
				base.FastCheckIsValid();
				FTextBlockStyle result;
				if ((result = this._DefaultTextStyle) == null)
				{
					result = (this._DefaultTextStyle = new FTextBlockStyle(base.NativePtr + (IntPtr)URichTextBlock.__PropertyOffset_DefaultTextStyle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextBlockStyle.StaticStruct(), base.NativePtr + (IntPtr)URichTextBlock.__PropertyOffset_DefaultTextStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700978E RID: 38798
		// (get) Token: 0x060278AF RID: 161967 RVA: 0x003C56B8 File Offset: 0x003C38B8
		// (set) Token: 0x060278B0 RID: 161968 RVA: 0x003C56F1 File Offset: 0x003C38F1
		public TArray<URichTextBlockDecorator> InstanceDecorators
		{
			get
			{
				base.FastCheckIsValid();
				TArray<URichTextBlockDecorator> result;
				if ((result = this._InstanceDecorators) == null)
				{
					result = (this._InstanceDecorators = new TArray<URichTextBlockDecorator>(base.NativePtr + (IntPtr)URichTextBlock.__PropertyOffset_InstanceDecorators, this));
				}
				return result;
			}
			set
			{
				this.InstanceDecorators.CopyAssign(value);
			}
		}

		// Token: 0x060278B1 RID: 161969 RVA: 0x003C56FF File Offset: 0x003C38FF
		public void SetTextTransformPolicy(ETextTransformPolicy InTransformPolicy)
		{
			URichTextBlock.__SetTextTransformPolicy_Internal(base.NativePtr, InTransformPolicy);
		}

		// Token: 0x060278B2 RID: 161970 RVA: 0x003C570D File Offset: 0x003C390D
		[NullableContext(2)]
		public void SetTextStyleSet(UDataTable NewTextStyleSet)
		{
			URichTextBlock.__SetTextStyleSet_Internal(base.NativePtr, (NewTextStyleSet != null) ? NewTextStyleSet.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060278B3 RID: 161971 RVA: 0x003C572A File Offset: 0x003C392A
		public void SetText(in FText InText)
		{
			IntPtr nativePtr = base.NativePtr;
			FText ftext = InText;
			URichTextBlock.__SetText_Internal(nativePtr, (ftext != null) ? ftext.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060278B4 RID: 161972 RVA: 0x003C5749 File Offset: 0x003C3949
		public void SetMinDesiredWidth(float InMinDesiredWidth)
		{
			URichTextBlock.__SetMinDesiredWidth_Internal(base.NativePtr, InMinDesiredWidth);
		}

		// Token: 0x060278B5 RID: 161973 RVA: 0x003C5757 File Offset: 0x003C3957
		[NullableContext(2)]
		public void SetDefaultTextStyle(in FTextBlockStyle InDefaultTextStyle)
		{
			URichTextBlock.__SetDefaultTextStyle_Internal(base.NativePtr, (InDefaultTextStyle ?? new FTextBlockStyle()).NativePtr);
		}

		// Token: 0x060278B6 RID: 161974 RVA: 0x003C5774 File Offset: 0x003C3974
		[NullableContext(2)]
		public void SetDefaultStrikeBrush(ref FSlateBrush InStrikeBrush)
		{
			URichTextBlock.__SetDefaultStrikeBrush_Internal(base.NativePtr, (InStrikeBrush ?? new FSlateBrush()).NativePtr);
		}

		// Token: 0x060278B7 RID: 161975 RVA: 0x003C5791 File Offset: 0x003C3991
		public void SetDefaultShadowOffset(FVector2D InShadowOffset)
		{
			URichTextBlock.__SetDefaultShadowOffset_Internal(base.NativePtr, InShadowOffset);
		}

		// Token: 0x060278B8 RID: 161976 RVA: 0x003C579F File Offset: 0x003C399F
		public void SetDefaultShadowColorAndOpacity(FLinearColor InShadowColorAndOpacity)
		{
			URichTextBlock.__SetDefaultShadowColorAndOpacity_Internal(base.NativePtr, InShadowColorAndOpacity);
		}

		// Token: 0x060278B9 RID: 161977 RVA: 0x003C57AD File Offset: 0x003C39AD
		[NullableContext(2)]
		public void SetDefaultFont(FSlateFontInfo InFontInfo)
		{
			URichTextBlock.__SetDefaultFont_Internal(base.NativePtr, (InFontInfo ?? new FSlateFontInfo()).NativePtr);
		}

		// Token: 0x060278BA RID: 161978 RVA: 0x003C57C9 File Offset: 0x003C39C9
		[NullableContext(2)]
		public void SetDefaultColorAndOpacity(FSlateColor InColorAndOpacity)
		{
			URichTextBlock.__SetDefaultColorAndOpacity_Internal(base.NativePtr, (InColorAndOpacity ?? new FSlateColor()).NativePtr);
		}

		// Token: 0x060278BB RID: 161979 RVA: 0x003C57E5 File Offset: 0x003C39E5
		public void SetAutoWrapText(bool InAutoTextWrap)
		{
			URichTextBlock.__SetAutoWrapText_Internal(base.NativePtr, InAutoTextWrap);
		}

		// Token: 0x060278BC RID: 161980 RVA: 0x003C57F3 File Offset: 0x003C39F3
		public FText GetText()
		{
			return new FText(URichTextBlock.__GetText_Internal(base.NativePtr), null);
		}

		// Token: 0x060278BD RID: 161981 RVA: 0x003C5806 File Offset: 0x003C3A06
		[NullableContext(2)]
		public URichTextBlockDecorator GetDecoratorByClass([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<URichTextBlockDecorator> DecoratorClass)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<URichTextBlockDecorator>(URichTextBlock.__GetDecoratorByClass_Internal(base.NativePtr, DecoratorClass._NativePtr));
		}

		// Token: 0x060278BE RID: 161982 RVA: 0x003C581E File Offset: 0x003C3A1E
		public void ClearAllDefaultStyleOverrides()
		{
			URichTextBlock.__ClearAllDefaultStyleOverrides_Internal(base.NativePtr);
		}

		// Token: 0x060278BF RID: 161983
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTextTransformPolicy_Internal(IntPtr @this, ETextTransformPolicy InTransformPolicy);

		// Token: 0x060278C0 RID: 161984
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTextStyleSet_Internal(IntPtr @this, IntPtr NewTextStyleSet);

		// Token: 0x060278C1 RID: 161985
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetText_Internal(IntPtr @this, IntPtr InText);

		// Token: 0x060278C2 RID: 161986
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMinDesiredWidth_Internal(IntPtr @this, float InMinDesiredWidth);

		// Token: 0x060278C3 RID: 161987
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDefaultTextStyle_Internal(IntPtr @this, IntPtr InDefaultTextStyle);

		// Token: 0x060278C4 RID: 161988
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDefaultStrikeBrush_Internal(IntPtr @this, IntPtr InStrikeBrush);

		// Token: 0x060278C5 RID: 161989
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDefaultShadowOffset_Internal(IntPtr @this, FVector2D InShadowOffset);

		// Token: 0x060278C6 RID: 161990
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDefaultShadowColorAndOpacity_Internal(IntPtr @this, FLinearColor InShadowColorAndOpacity);

		// Token: 0x060278C7 RID: 161991
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDefaultFont_Internal(IntPtr @this, IntPtr InFontInfo);

		// Token: 0x060278C8 RID: 161992
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDefaultColorAndOpacity_Internal(IntPtr @this, IntPtr InColorAndOpacity);

		// Token: 0x060278C9 RID: 161993
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAutoWrapText_Internal(IntPtr @this, bool InAutoTextWrap);

		// Token: 0x060278CA RID: 161994
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetText_Internal(IntPtr @this);

		// Token: 0x060278CB RID: 161995
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDecoratorByClass_Internal(IntPtr @this, IntPtr DecoratorClass);

		// Token: 0x060278CC RID: 161996
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearAllDefaultStyleOverrides_Internal(IntPtr @this);

		// Token: 0x060278CD RID: 161997 RVA: 0x003C582B File Offset: 0x003C3A2B
		static URichTextBlock()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.RichTextBlock");
		}

		// Token: 0x060278CE RID: 161998 RVA: 0x003C5839 File Offset: 0x003C3A39
		protected URichTextBlock(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015ACF RID: 88783
		public new const string __ObjectPath = "/Script/UMG.RichTextBlock";

		// Token: 0x04015AD0 RID: 88784
		private static IntPtr _ClassPtr;

		// Token: 0x04015AD1 RID: 88785
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015AD2 RID: 88786
		internal static int __PropertyOffset_Text;

		// Token: 0x04015AD3 RID: 88787
		[Nullable(2)]
		private FText _Text;

		// Token: 0x04015AD4 RID: 88788
		internal static int __PropertyOffset_TextStyleSet;

		// Token: 0x04015AD5 RID: 88789
		internal static int __PropertyOffset_DecoratorClasses;

		// Token: 0x04015AD6 RID: 88790
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TSubclassOf<URichTextBlockDecorator>> _DecoratorClasses;

		// Token: 0x04015AD7 RID: 88791
		internal static int __PropertyOffset_bOverrideDefaultStyle;

		// Token: 0x04015AD8 RID: 88792
		internal static int __PropertyOffset_DefaultTextStyleOverride;

		// Token: 0x04015AD9 RID: 88793
		[Nullable(2)]
		private FTextBlockStyle _DefaultTextStyleOverride;

		// Token: 0x04015ADA RID: 88794
		internal static int __PropertyOffset_MinDesiredWidth;

		// Token: 0x04015ADB RID: 88795
		internal static int __PropertyOffset_TextTransformPolicy;

		// Token: 0x04015ADC RID: 88796
		internal static int __PropertyOffset_DefaultTextStyle;

		// Token: 0x04015ADD RID: 88797
		[Nullable(2)]
		private FTextBlockStyle _DefaultTextStyle;

		// Token: 0x04015ADE RID: 88798
		internal static int __PropertyOffset_InstanceDecorators;

		// Token: 0x04015ADF RID: 88799
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<URichTextBlockDecorator> _InstanceDecorators;
	}
}
