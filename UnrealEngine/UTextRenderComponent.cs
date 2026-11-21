using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000297 RID: 663
	[UnrealObjectPath("/Script/Engine.TextRenderComponent")]
	[UnrealStructLayout(1648, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1648)]
	public class UTextRenderComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004913 RID: 18707 RVA: 0x000667DC File Offset: 0x000649DC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTextRenderComponent._ClassPtr;
		}

		// Token: 0x06004914 RID: 18708 RVA: 0x000667E8 File Offset: 0x000649E8
		public UTextRenderComponent() : this(BuiltinUtils.AllocNativeUObject(UTextRenderComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004915 RID: 18709 RVA: 0x00066810 File Offset: 0x00064A10
		[NullableContext(1)]
		public UTextRenderComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTextRenderComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000DAB RID: 3499
		// (get) Token: 0x06004916 RID: 18710 RVA: 0x00066844 File Offset: 0x00064A44
		// (set) Token: 0x06004917 RID: 18711 RVA: 0x0006687D File Offset: 0x00064A7D
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

		// Token: 0x17000DAC RID: 3500
		// (get) Token: 0x06004918 RID: 18712 RVA: 0x00066898 File Offset: 0x00064A98
		// (set) Token: 0x06004919 RID: 18713 RVA: 0x000668AC File Offset: 0x00064AAC
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

		// Token: 0x17000DAD RID: 3501
		// (get) Token: 0x0600491A RID: 18714 RVA: 0x000668C1 File Offset: 0x00064AC1
		// (set) Token: 0x0600491B RID: 18715 RVA: 0x000668D5 File Offset: 0x00064AD5
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

		// Token: 0x17000DAE RID: 3502
		// (get) Token: 0x0600491C RID: 18716 RVA: 0x000668EA File Offset: 0x00064AEA
		// (set) Token: 0x0600491D RID: 18717 RVA: 0x000668FE File Offset: 0x00064AFE
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

		// Token: 0x17000DAF RID: 3503
		// (get) Token: 0x0600491E RID: 18718 RVA: 0x00066913 File Offset: 0x00064B13
		// (set) Token: 0x0600491F RID: 18719 RVA: 0x00066923 File Offset: 0x00064B23
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

		// Token: 0x17000DB0 RID: 3504
		// (get) Token: 0x06004920 RID: 18720 RVA: 0x00066934 File Offset: 0x00064B34
		// (set) Token: 0x06004921 RID: 18721 RVA: 0x00066944 File Offset: 0x00064B44
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

		// Token: 0x17000DB1 RID: 3505
		// (get) Token: 0x06004922 RID: 18722 RVA: 0x00066955 File Offset: 0x00064B55
		// (set) Token: 0x06004923 RID: 18723 RVA: 0x00066965 File Offset: 0x00064B65
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

		// Token: 0x17000DB2 RID: 3506
		// (get) Token: 0x06004924 RID: 18724 RVA: 0x00066976 File Offset: 0x00064B76
		// (set) Token: 0x06004925 RID: 18725 RVA: 0x00066986 File Offset: 0x00064B86
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

		// Token: 0x17000DB3 RID: 3507
		// (get) Token: 0x06004926 RID: 18726 RVA: 0x00066997 File Offset: 0x00064B97
		// (set) Token: 0x06004927 RID: 18727 RVA: 0x000669A7 File Offset: 0x00064BA7
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

		// Token: 0x17000DB4 RID: 3508
		// (get) Token: 0x06004928 RID: 18728 RVA: 0x000669B8 File Offset: 0x00064BB8
		// (set) Token: 0x06004929 RID: 18729 RVA: 0x000669C8 File Offset: 0x00064BC8
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

		// Token: 0x17000DB5 RID: 3509
		// (get) Token: 0x0600492A RID: 18730 RVA: 0x000669D9 File Offset: 0x00064BD9
		// (set) Token: 0x0600492B RID: 18731 RVA: 0x000669F2 File Offset: 0x00064BF2
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

		// Token: 0x0600492C RID: 18732 RVA: 0x00066A22 File Offset: 0x00064C22
		public void SetYScale(float Value)
		{
			UTextRenderComponent.__SetYScale_Internal(base.NativePtr, Value);
		}

		// Token: 0x0600492D RID: 18733 RVA: 0x00066A30 File Offset: 0x00064C30
		public void SetXScale(float Value)
		{
			UTextRenderComponent.__SetXScale_Internal(base.NativePtr, Value);
		}

		// Token: 0x0600492E RID: 18734 RVA: 0x00066A3E File Offset: 0x00064C3E
		public void SetWorldSize(float Value)
		{
			UTextRenderComponent.__SetWorldSize_Internal(base.NativePtr, Value);
		}

		// Token: 0x0600492F RID: 18735 RVA: 0x00066A4C File Offset: 0x00064C4C
		public void SetVertSpacingAdjust(float Value)
		{
			UTextRenderComponent.__SetVertSpacingAdjust_Internal(base.NativePtr, Value);
		}

		// Token: 0x06004930 RID: 18736 RVA: 0x00066A5A File Offset: 0x00064C5A
		public void SetTextRenderColor(FColor Value)
		{
			UTextRenderComponent.__SetTextRenderColor_Internal(base.NativePtr, Value);
		}

		// Token: 0x06004931 RID: 18737 RVA: 0x00066A68 File Offset: 0x00064C68
		[NullableContext(2)]
		public void SetTextMaterial(UMaterialInterface Material)
		{
			UTextRenderComponent.__SetTextMaterial_Internal(base.NativePtr, (Material != null) ? Material.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06004932 RID: 18738 RVA: 0x00066A88 File Offset: 0x00064C88
		[NullableContext(1)]
		public unsafe void SetText(string Value)
		{
			FString fstring = FString.AllocTemp(Value);
			UTextRenderComponent.__SetText_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06004933 RID: 18739 RVA: 0x00066AB2 File Offset: 0x00064CB2
		public void SetHorizSpacingAdjust(float Value)
		{
			UTextRenderComponent.__SetHorizSpacingAdjust_Internal(base.NativePtr, Value);
		}

		// Token: 0x06004934 RID: 18740 RVA: 0x00066AC0 File Offset: 0x00064CC0
		public void SetHorizontalAlignment(EHorizTextAligment Value)
		{
			UTextRenderComponent.__SetHorizontalAlignment_Internal(base.NativePtr, Value);
		}

		// Token: 0x06004935 RID: 18741 RVA: 0x00066AD3 File Offset: 0x00064CD3
		[NullableContext(1)]
		public void K2_SetText(in FText Value)
		{
			IntPtr nativePtr = base.NativePtr;
			FText ftext = Value;
			UTextRenderComponent.__K2_SetText_Internal(nativePtr, (ftext != null) ? ftext.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06004936 RID: 18742 RVA: 0x00066AF2 File Offset: 0x00064CF2
		public FVector GetTextWorldSize()
		{
			return UTextRenderComponent.__GetTextWorldSize_Internal(base.NativePtr);
		}

		// Token: 0x06004937 RID: 18743 RVA: 0x00066AFF File Offset: 0x00064CFF
		public FVector GetTextLocalSize()
		{
			return UTextRenderComponent.__GetTextLocalSize_Internal(base.NativePtr);
		}

		// Token: 0x06004938 RID: 18744
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetYScale_Internal(IntPtr @this, float Value);

		// Token: 0x06004939 RID: 18745
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetXScale_Internal(IntPtr @this, float Value);

		// Token: 0x0600493A RID: 18746
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWorldSize_Internal(IntPtr @this, float Value);

		// Token: 0x0600493B RID: 18747
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVertSpacingAdjust_Internal(IntPtr @this, float Value);

		// Token: 0x0600493C RID: 18748
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTextRenderColor_Internal(IntPtr @this, FColor Value);

		// Token: 0x0600493D RID: 18749
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTextMaterial_Internal(IntPtr @this, IntPtr Material);

		// Token: 0x0600493E RID: 18750
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetText_Internal(IntPtr @this, in FString Value);

		// Token: 0x0600493F RID: 18751
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHorizSpacingAdjust_Internal(IntPtr @this, float Value);

		// Token: 0x06004940 RID: 18752
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHorizontalAlignment_Internal(IntPtr @this, TEnumAsByte<EHorizTextAligment> Value);

		// Token: 0x06004941 RID: 18753
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_SetText_Internal(IntPtr @this, IntPtr Value);

		// Token: 0x06004942 RID: 18754
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetTextWorldSize_Internal(IntPtr @this);

		// Token: 0x06004943 RID: 18755
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetTextLocalSize_Internal(IntPtr @this);

		// Token: 0x06004944 RID: 18756 RVA: 0x00066B0C File Offset: 0x00064D0C
		static UTextRenderComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.TextRenderComponent");
		}

		// Token: 0x06004945 RID: 18757 RVA: 0x00066B1A File Offset: 0x00064D1A
		protected UTextRenderComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001C67 RID: 7271
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.TextRenderComponent";

		// Token: 0x04001C68 RID: 7272
		private static IntPtr _ClassPtr;

		// Token: 0x04001C69 RID: 7273
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001C6A RID: 7274
		internal static int __PropertyOffset_Text;

		// Token: 0x04001C6B RID: 7275
		[Nullable(2)]
		private FText _Text;

		// Token: 0x04001C6C RID: 7276
		internal static int __PropertyOffset_TextMaterial;

		// Token: 0x04001C6D RID: 7277
		internal static int __PropertyOffset_HorizontalAlignment;

		// Token: 0x04001C6E RID: 7278
		internal static int __PropertyOffset_TextRenderColor;

		// Token: 0x04001C6F RID: 7279
		internal static int __PropertyOffset_XScale;

		// Token: 0x04001C70 RID: 7280
		internal static int __PropertyOffset_YScale;

		// Token: 0x04001C71 RID: 7281
		internal static int __PropertyOffset_WorldSize;

		// Token: 0x04001C72 RID: 7282
		internal static int __PropertyOffset_InvDefaultSize;

		// Token: 0x04001C73 RID: 7283
		internal static int __PropertyOffset_HorizSpacingAdjust;

		// Token: 0x04001C74 RID: 7284
		internal static int __PropertyOffset_VertSpacingAdjust;

		// Token: 0x04001C75 RID: 7285
		internal static int __PropertyOffset_bAlwaysRenderAsText;

		// Token: 0x04001C76 RID: 7286
		internal static byte __PropertyMask_bAlwaysRenderAsText;
	}
}
