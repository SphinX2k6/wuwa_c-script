using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011CA RID: 4554
	[UnrealObjectPath("/Script/Engine.TextRenderComponent")]
	[UnrealStructLayout(1648, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1648)]
	public class UTextRenderComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010C5C RID: 68700 RVA: 0x0018A2DF File Offset: 0x001884DF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTextRenderComponent._ClassPtr;
		}

		// Token: 0x06010C5D RID: 68701 RVA: 0x0018A2EC File Offset: 0x001884EC
		public UTextRenderComponent() : this(BuiltinUtils.AllocNativeUObject(UTextRenderComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010C5E RID: 68702 RVA: 0x0018A314 File Offset: 0x00188514
		[NullableContext(1)]
		public UTextRenderComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTextRenderComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004177 RID: 16759
		// (get) Token: 0x06010C5F RID: 68703 RVA: 0x0018A348 File Offset: 0x00188548
		// (set) Token: 0x06010C60 RID: 68704 RVA: 0x0018A381 File Offset: 0x00188581
		[Nullable(1)]
		public unsafe FText Text
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._Text) == null)
				{
					result = (this._Text = new FText(base.NativePtr + (IntPtr)UTextRenderComponent.__PropertyOffset_Text, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)UTextRenderComponent.__PropertyOffset_Text)), value.NativePtr, 1);
			}
		}

		// Token: 0x17004178 RID: 16760
		// (get) Token: 0x06010C61 RID: 68705 RVA: 0x0018A39C File Offset: 0x0018859C
		// (set) Token: 0x06010C62 RID: 68706 RVA: 0x0018A3B0 File Offset: 0x001885B0
		[Nullable(2)]
		public unsafe UMaterialInterface TextMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UTextRenderComponent.__PropertyOffset_TextMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTextRenderComponent.__PropertyOffset_TextMaterial, value);
			}
		}

		// Token: 0x17004179 RID: 16761
		// (get) Token: 0x06010C63 RID: 68707 RVA: 0x0018A3C5 File Offset: 0x001885C5
		// (set) Token: 0x06010C64 RID: 68708 RVA: 0x0018A3D9 File Offset: 0x001885D9
		[Nullable(2)]
		public unsafe UFont Font
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UFont>(base.NativePtr / (IntPtr)sizeof(void*) + UTextRenderComponent.__PropertyOffset_Font);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTextRenderComponent.__PropertyOffset_Font, value);
			}
		}

		// Token: 0x1700417A RID: 16762
		// (get) Token: 0x06010C65 RID: 68709 RVA: 0x0018A3EE File Offset: 0x001885EE
		// (set) Token: 0x06010C66 RID: 68710 RVA: 0x0018A402 File Offset: 0x00188602
		public unsafe TEnumAsByte<EHorizTextAligment> HorizontalAlignment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextRenderComponent.__PropertyOffset_HorizontalAlignment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextRenderComponent.__PropertyOffset_HorizontalAlignment) = value;
			}
		}

		// Token: 0x1700417B RID: 16763
		// (get) Token: 0x06010C67 RID: 68711 RVA: 0x0018A417 File Offset: 0x00188617
		// (set) Token: 0x06010C68 RID: 68712 RVA: 0x0018A42B File Offset: 0x0018862B
		public unsafe TEnumAsByte<EVerticalTextAligment> VerticalAlignment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextRenderComponent.__PropertyOffset_VerticalAlignment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextRenderComponent.__PropertyOffset_VerticalAlignment) = value;
			}
		}

		// Token: 0x1700417C RID: 16764
		// (get) Token: 0x06010C69 RID: 68713 RVA: 0x0018A440 File Offset: 0x00188640
		// (set) Token: 0x06010C6A RID: 68714 RVA: 0x0018A454 File Offset: 0x00188654
		public unsafe FColor TextRenderColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextRenderComponent.__PropertyOffset_TextRenderColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextRenderComponent.__PropertyOffset_TextRenderColor) = value;
			}
		}

		// Token: 0x1700417D RID: 16765
		// (get) Token: 0x06010C6B RID: 68715 RVA: 0x0018A469 File Offset: 0x00188669
		// (set) Token: 0x06010C6C RID: 68716 RVA: 0x0018A479 File Offset: 0x00188679
		public unsafe float XScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextRenderComponent.__PropertyOffset_XScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextRenderComponent.__PropertyOffset_XScale) = value;
			}
		}

		// Token: 0x1700417E RID: 16766
		// (get) Token: 0x06010C6D RID: 68717 RVA: 0x0018A48A File Offset: 0x0018868A
		// (set) Token: 0x06010C6E RID: 68718 RVA: 0x0018A49A File Offset: 0x0018869A
		public unsafe float YScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextRenderComponent.__PropertyOffset_YScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextRenderComponent.__PropertyOffset_YScale) = value;
			}
		}

		// Token: 0x1700417F RID: 16767
		// (get) Token: 0x06010C6F RID: 68719 RVA: 0x0018A4AB File Offset: 0x001886AB
		// (set) Token: 0x06010C70 RID: 68720 RVA: 0x0018A4BB File Offset: 0x001886BB
		public unsafe float WorldSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextRenderComponent.__PropertyOffset_WorldSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextRenderComponent.__PropertyOffset_WorldSize) = value;
			}
		}

		// Token: 0x17004180 RID: 16768
		// (get) Token: 0x06010C71 RID: 68721 RVA: 0x0018A4CC File Offset: 0x001886CC
		// (set) Token: 0x06010C72 RID: 68722 RVA: 0x0018A4DC File Offset: 0x001886DC
		public unsafe float InvDefaultSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextRenderComponent.__PropertyOffset_InvDefaultSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextRenderComponent.__PropertyOffset_InvDefaultSize) = value;
			}
		}

		// Token: 0x17004181 RID: 16769
		// (get) Token: 0x06010C73 RID: 68723 RVA: 0x0018A4ED File Offset: 0x001886ED
		// (set) Token: 0x06010C74 RID: 68724 RVA: 0x0018A4FD File Offset: 0x001886FD
		public unsafe float HorizSpacingAdjust
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextRenderComponent.__PropertyOffset_HorizSpacingAdjust);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextRenderComponent.__PropertyOffset_HorizSpacingAdjust) = value;
			}
		}

		// Token: 0x17004182 RID: 16770
		// (get) Token: 0x06010C75 RID: 68725 RVA: 0x0018A50E File Offset: 0x0018870E
		// (set) Token: 0x06010C76 RID: 68726 RVA: 0x0018A51E File Offset: 0x0018871E
		public unsafe float VertSpacingAdjust
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextRenderComponent.__PropertyOffset_VertSpacingAdjust);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextRenderComponent.__PropertyOffset_VertSpacingAdjust) = value;
			}
		}

		// Token: 0x17004183 RID: 16771
		// (get) Token: 0x06010C77 RID: 68727 RVA: 0x0018A52F File Offset: 0x0018872F
		// (set) Token: 0x06010C78 RID: 68728 RVA: 0x0018A548 File Offset: 0x00188748
		public unsafe bool bAlwaysRenderAsText
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UTextRenderComponent.__PropertyOffset_bAlwaysRenderAsText) & UTextRenderComponent.__PropertyMask_bAlwaysRenderAsText) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UTextRenderComponent.__PropertyOffset_bAlwaysRenderAsText) = ((*(base.NativePtr + (IntPtr)UTextRenderComponent.__PropertyOffset_bAlwaysRenderAsText) & ~UTextRenderComponent.__PropertyMask_bAlwaysRenderAsText) | (value ? UTextRenderComponent.__PropertyMask_bAlwaysRenderAsText : 0));
			}
		}

		// Token: 0x06010C79 RID: 68729 RVA: 0x0018A578 File Offset: 0x00188778
		public void SetYScale(float Value)
		{
			UTextRenderComponent.__SetYScale_Internal(base.NativePtr, Value);
		}

		// Token: 0x06010C7A RID: 68730 RVA: 0x0018A586 File Offset: 0x00188786
		public void SetXScale(float Value)
		{
			UTextRenderComponent.__SetXScale_Internal(base.NativePtr, Value);
		}

		// Token: 0x06010C7B RID: 68731 RVA: 0x0018A594 File Offset: 0x00188794
		public void SetWorldSize(float Value)
		{
			UTextRenderComponent.__SetWorldSize_Internal(base.NativePtr, Value);
		}

		// Token: 0x06010C7C RID: 68732 RVA: 0x0018A5A2 File Offset: 0x001887A2
		public void SetVertSpacingAdjust(float Value)
		{
			UTextRenderComponent.__SetVertSpacingAdjust_Internal(base.NativePtr, Value);
		}

		// Token: 0x06010C7D RID: 68733 RVA: 0x0018A5B0 File Offset: 0x001887B0
		public void SetVerticalAlignment(EVerticalTextAligment Value)
		{
			UTextRenderComponent.__SetVerticalAlignment_Internal(base.NativePtr, Value);
		}

		// Token: 0x06010C7E RID: 68734 RVA: 0x0018A5C3 File Offset: 0x001887C3
		public void SetTextRenderColor(FColor Value)
		{
			UTextRenderComponent.__SetTextRenderColor_Internal(base.NativePtr, Value);
		}

		// Token: 0x06010C7F RID: 68735 RVA: 0x0018A5D1 File Offset: 0x001887D1
		[NullableContext(2)]
		public void SetTextMaterial(UMaterialInterface Material)
		{
			UTextRenderComponent.__SetTextMaterial_Internal(base.NativePtr, (Material != null) ? Material.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06010C80 RID: 68736 RVA: 0x0018A5F0 File Offset: 0x001887F0
		[NullableContext(1)]
		public unsafe void SetText(string Value)
		{
			FString fstring = FString.AllocTemp(Value);
			UTextRenderComponent.__SetText_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06010C81 RID: 68737 RVA: 0x0018A61A File Offset: 0x0018881A
		public void SetHorizSpacingAdjust(float Value)
		{
			UTextRenderComponent.__SetHorizSpacingAdjust_Internal(base.NativePtr, Value);
		}

		// Token: 0x06010C82 RID: 68738 RVA: 0x0018A628 File Offset: 0x00188828
		public void SetHorizontalAlignment(EHorizTextAligment Value)
		{
			UTextRenderComponent.__SetHorizontalAlignment_Internal(base.NativePtr, Value);
		}

		// Token: 0x06010C83 RID: 68739 RVA: 0x0018A63B File Offset: 0x0018883B
		[NullableContext(2)]
		public void SetFont(UFont Value)
		{
			UTextRenderComponent.__SetFont_Internal(base.NativePtr, (Value != null) ? Value.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06010C84 RID: 68740 RVA: 0x0018A658 File Offset: 0x00188858
		[NullableContext(1)]
		public void K2_SetText(in FText Value)
		{
			IntPtr nativePtr = base.NativePtr;
			FText ftext = Value;
			UTextRenderComponent.__K2_SetText_Internal(nativePtr, (ftext != null) ? ftext.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06010C85 RID: 68741 RVA: 0x0018A677 File Offset: 0x00188877
		public FVector GetTextWorldSize()
		{
			return UTextRenderComponent.__GetTextWorldSize_Internal(base.NativePtr);
		}

		// Token: 0x06010C86 RID: 68742 RVA: 0x0018A684 File Offset: 0x00188884
		public FVector GetTextLocalSize()
		{
			return UTextRenderComponent.__GetTextLocalSize_Internal(base.NativePtr);
		}

		// Token: 0x06010C87 RID: 68743
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetYScale_Internal(IntPtr @this, float Value);

		// Token: 0x06010C88 RID: 68744
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetXScale_Internal(IntPtr @this, float Value);

		// Token: 0x06010C89 RID: 68745
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWorldSize_Internal(IntPtr @this, float Value);

		// Token: 0x06010C8A RID: 68746
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVertSpacingAdjust_Internal(IntPtr @this, float Value);

		// Token: 0x06010C8B RID: 68747
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVerticalAlignment_Internal(IntPtr @this, TEnumAsByte<EVerticalTextAligment> Value);

		// Token: 0x06010C8C RID: 68748
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTextRenderColor_Internal(IntPtr @this, FColor Value);

		// Token: 0x06010C8D RID: 68749
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTextMaterial_Internal(IntPtr @this, IntPtr Material);

		// Token: 0x06010C8E RID: 68750
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetText_Internal(IntPtr @this, in FString Value);

		// Token: 0x06010C8F RID: 68751
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHorizSpacingAdjust_Internal(IntPtr @this, float Value);

		// Token: 0x06010C90 RID: 68752
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHorizontalAlignment_Internal(IntPtr @this, TEnumAsByte<EHorizTextAligment> Value);

		// Token: 0x06010C91 RID: 68753
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFont_Internal(IntPtr @this, IntPtr Value);

		// Token: 0x06010C92 RID: 68754
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_SetText_Internal(IntPtr @this, IntPtr Value);

		// Token: 0x06010C93 RID: 68755
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetTextWorldSize_Internal(IntPtr @this);

		// Token: 0x06010C94 RID: 68756
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetTextLocalSize_Internal(IntPtr @this);

		// Token: 0x06010C95 RID: 68757 RVA: 0x0018A691 File Offset: 0x00188891
		static UTextRenderComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.TextRenderComponent");
		}

		// Token: 0x06010C96 RID: 68758 RVA: 0x0018A69F File Offset: 0x0018889F
		protected UTextRenderComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008F6D RID: 36717
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.TextRenderComponent";

		// Token: 0x04008F6E RID: 36718
		private static IntPtr _ClassPtr;

		// Token: 0x04008F6F RID: 36719
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008F70 RID: 36720
		internal static int __PropertyOffset_Text;

		// Token: 0x04008F71 RID: 36721
		[Nullable(2)]
		private FText _Text;

		// Token: 0x04008F72 RID: 36722
		internal static int __PropertyOffset_TextMaterial;

		// Token: 0x04008F73 RID: 36723
		internal static int __PropertyOffset_Font;

		// Token: 0x04008F74 RID: 36724
		internal static int __PropertyOffset_HorizontalAlignment;

		// Token: 0x04008F75 RID: 36725
		internal static int __PropertyOffset_VerticalAlignment;

		// Token: 0x04008F76 RID: 36726
		internal static int __PropertyOffset_TextRenderColor;

		// Token: 0x04008F77 RID: 36727
		internal static int __PropertyOffset_XScale;

		// Token: 0x04008F78 RID: 36728
		internal static int __PropertyOffset_YScale;

		// Token: 0x04008F79 RID: 36729
		internal static int __PropertyOffset_WorldSize;

		// Token: 0x04008F7A RID: 36730
		internal static int __PropertyOffset_InvDefaultSize;

		// Token: 0x04008F7B RID: 36731
		internal static int __PropertyOffset_HorizSpacingAdjust;

		// Token: 0x04008F7C RID: 36732
		internal static int __PropertyOffset_VertSpacingAdjust;

		// Token: 0x04008F7D RID: 36733
		internal static int __PropertyOffset_bAlwaysRenderAsText;

		// Token: 0x04008F7E RID: 36734
		internal static byte __PropertyMask_bAlwaysRenderAsText;
	}
}
