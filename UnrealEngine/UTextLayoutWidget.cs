using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029E2 RID: 10722
	[UnrealObjectPath("/Script/UMG.TextLayoutWidget")]
	[UnrealStructLayout(688, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 688)]
	public abstract class UTextLayoutWidget : UWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027B78 RID: 162680 RVA: 0x003C8CFA File Offset: 0x003C6EFA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTextLayoutWidget._ClassPtr;
		}

		// Token: 0x17009829 RID: 38953
		// (get) Token: 0x06027B79 RID: 162681 RVA: 0x003C8D08 File Offset: 0x003C6F08
		// (set) Token: 0x06027B7A RID: 162682 RVA: 0x003C8D41 File Offset: 0x003C6F41
		[Nullable(1)]
		public FShapedTextOptions ShapedTextOptions
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FShapedTextOptions result;
				if ((result = this._ShapedTextOptions) == null)
				{
					result = (this._ShapedTextOptions = new FShapedTextOptions(base.NativePtr + (IntPtr)UTextLayoutWidget.__PropertyOffset_ShapedTextOptions, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FShapedTextOptions.StaticStruct(), base.NativePtr + (IntPtr)UTextLayoutWidget.__PropertyOffset_ShapedTextOptions, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700982A RID: 38954
		// (get) Token: 0x06027B7B RID: 162683 RVA: 0x003C8D62 File Offset: 0x003C6F62
		// (set) Token: 0x06027B7C RID: 162684 RVA: 0x003C8D76 File Offset: 0x003C6F76
		public unsafe TEnumAsByte<ETextJustify> Justification
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextLayoutWidget.__PropertyOffset_Justification);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextLayoutWidget.__PropertyOffset_Justification) = value;
			}
		}

		// Token: 0x1700982B RID: 38955
		// (get) Token: 0x06027B7D RID: 162685 RVA: 0x003C8D8B File Offset: 0x003C6F8B
		// (set) Token: 0x06027B7E RID: 162686 RVA: 0x003C8D9B File Offset: 0x003C6F9B
		public unsafe ETextWrappingPolicy WrappingPolicy
		{
			get
			{
				return (ETextWrappingPolicy)(*(base.NativePtr + (IntPtr)UTextLayoutWidget.__PropertyOffset_WrappingPolicy));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextLayoutWidget.__PropertyOffset_WrappingPolicy) = (byte)value;
			}
		}

		// Token: 0x1700982C RID: 38956
		// (get) Token: 0x06027B7F RID: 162687 RVA: 0x003C8DAC File Offset: 0x003C6FAC
		// (set) Token: 0x06027B80 RID: 162688 RVA: 0x003C8DC5 File Offset: 0x003C6FC5
		public unsafe bool AutoWrapText
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UTextLayoutWidget.__PropertyOffset_AutoWrapText) & UTextLayoutWidget.__PropertyMask_AutoWrapText) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UTextLayoutWidget.__PropertyOffset_AutoWrapText) = ((*(base.NativePtr + (IntPtr)UTextLayoutWidget.__PropertyOffset_AutoWrapText) & ~UTextLayoutWidget.__PropertyMask_AutoWrapText) | (value ? UTextLayoutWidget.__PropertyMask_AutoWrapText : 0));
			}
		}

		// Token: 0x1700982D RID: 38957
		// (get) Token: 0x06027B81 RID: 162689 RVA: 0x003C8DF5 File Offset: 0x003C6FF5
		// (set) Token: 0x06027B82 RID: 162690 RVA: 0x003C8E05 File Offset: 0x003C7005
		public unsafe float WrapTextAt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextLayoutWidget.__PropertyOffset_WrapTextAt);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextLayoutWidget.__PropertyOffset_WrapTextAt) = value;
			}
		}

		// Token: 0x1700982E RID: 38958
		// (get) Token: 0x06027B83 RID: 162691 RVA: 0x003C8E16 File Offset: 0x003C7016
		// (set) Token: 0x06027B84 RID: 162692 RVA: 0x003C8E2A File Offset: 0x003C702A
		public unsafe FMargin Margin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextLayoutWidget.__PropertyOffset_Margin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextLayoutWidget.__PropertyOffset_Margin) = value;
			}
		}

		// Token: 0x1700982F RID: 38959
		// (get) Token: 0x06027B85 RID: 162693 RVA: 0x003C8E3F File Offset: 0x003C703F
		// (set) Token: 0x06027B86 RID: 162694 RVA: 0x003C8E4F File Offset: 0x003C704F
		public unsafe float LineHeightPercentage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextLayoutWidget.__PropertyOffset_LineHeightPercentage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextLayoutWidget.__PropertyOffset_LineHeightPercentage) = value;
			}
		}

		// Token: 0x06027B87 RID: 162695 RVA: 0x003C8E60 File Offset: 0x003C7060
		public void SetJustification(ETextJustify InJustification)
		{
			UTextLayoutWidget.__SetJustification_Internal(base.NativePtr, InJustification);
		}

		// Token: 0x06027B88 RID: 162696
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetJustification_Internal(IntPtr @this, TEnumAsByte<ETextJustify> InJustification);

		// Token: 0x06027B89 RID: 162697 RVA: 0x003C8E73 File Offset: 0x003C7073
		static UTextLayoutWidget()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.TextLayoutWidget");
		}

		// Token: 0x06027B8A RID: 162698 RVA: 0x003C8E84 File Offset: 0x003C7084
		protected UTextLayoutWidget() : this(BuiltinUtils.AllocNativeUObject(UTextLayoutWidget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027B8B RID: 162699 RVA: 0x003C8EAC File Offset: 0x003C70AC
		protected UTextLayoutWidget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015BF4 RID: 89076
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.TextLayoutWidget";

		// Token: 0x04015BF5 RID: 89077
		private static IntPtr _ClassPtr;

		// Token: 0x04015BF6 RID: 89078
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015BF7 RID: 89079
		internal static int __PropertyOffset_ShapedTextOptions;

		// Token: 0x04015BF8 RID: 89080
		[Nullable(2)]
		private FShapedTextOptions _ShapedTextOptions;

		// Token: 0x04015BF9 RID: 89081
		internal static int __PropertyOffset_Justification;

		// Token: 0x04015BFA RID: 89082
		internal static int __PropertyOffset_WrappingPolicy;

		// Token: 0x04015BFB RID: 89083
		internal static int __PropertyOffset_AutoWrapText;

		// Token: 0x04015BFC RID: 89084
		internal static byte __PropertyMask_AutoWrapText;

		// Token: 0x04015BFD RID: 89085
		internal static int __PropertyOffset_WrapTextAt;

		// Token: 0x04015BFE RID: 89086
		internal static int __PropertyOffset_Margin;

		// Token: 0x04015BFF RID: 89087
		internal static int __PropertyOffset_LineHeightPercentage;
	}
}
