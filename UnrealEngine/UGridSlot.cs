using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002976 RID: 10614
	[UnrealObjectPath("/Script/UMG.GridSlot")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UGridSlot : UPanelSlot, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060273FC RID: 160764 RVA: 0x003BDC08 File Offset: 0x003BBE08
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGridSlot._ClassPtr;
		}

		// Token: 0x060273FD RID: 160765 RVA: 0x003BDC14 File Offset: 0x003BBE14
		public UGridSlot() : this(BuiltinUtils.AllocNativeUObject(UGridSlot.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060273FE RID: 160766 RVA: 0x003BDC3C File Offset: 0x003BBE3C
		[NullableContext(1)]
		public UGridSlot(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGridSlot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170096EA RID: 38634
		// (get) Token: 0x060273FF RID: 160767 RVA: 0x003BDC6F File Offset: 0x003BBE6F
		// (set) Token: 0x06027400 RID: 160768 RVA: 0x003BDC83 File Offset: 0x003BBE83
		public unsafe FMargin Padding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGridSlot.__PropertyOffset_Padding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGridSlot.__PropertyOffset_Padding) = value;
			}
		}

		// Token: 0x170096EB RID: 38635
		// (get) Token: 0x06027401 RID: 160769 RVA: 0x003BDC98 File Offset: 0x003BBE98
		// (set) Token: 0x06027402 RID: 160770 RVA: 0x003BDCAC File Offset: 0x003BBEAC
		public unsafe TEnumAsByte<EHorizontalAlignment> HorizontalAlignment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGridSlot.__PropertyOffset_HorizontalAlignment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGridSlot.__PropertyOffset_HorizontalAlignment) = value;
			}
		}

		// Token: 0x170096EC RID: 38636
		// (get) Token: 0x06027403 RID: 160771 RVA: 0x003BDCC1 File Offset: 0x003BBEC1
		// (set) Token: 0x06027404 RID: 160772 RVA: 0x003BDCD5 File Offset: 0x003BBED5
		public unsafe TEnumAsByte<EVerticalAlignment> VerticalAlignment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGridSlot.__PropertyOffset_VerticalAlignment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGridSlot.__PropertyOffset_VerticalAlignment) = value;
			}
		}

		// Token: 0x170096ED RID: 38637
		// (get) Token: 0x06027405 RID: 160773 RVA: 0x003BDCEA File Offset: 0x003BBEEA
		// (set) Token: 0x06027406 RID: 160774 RVA: 0x003BDCFA File Offset: 0x003BBEFA
		public unsafe int Row
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGridSlot.__PropertyOffset_Row);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGridSlot.__PropertyOffset_Row) = value;
			}
		}

		// Token: 0x170096EE RID: 38638
		// (get) Token: 0x06027407 RID: 160775 RVA: 0x003BDD0B File Offset: 0x003BBF0B
		// (set) Token: 0x06027408 RID: 160776 RVA: 0x003BDD1B File Offset: 0x003BBF1B
		public unsafe int RowSpan
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGridSlot.__PropertyOffset_RowSpan);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGridSlot.__PropertyOffset_RowSpan) = value;
			}
		}

		// Token: 0x170096EF RID: 38639
		// (get) Token: 0x06027409 RID: 160777 RVA: 0x003BDD2C File Offset: 0x003BBF2C
		// (set) Token: 0x0602740A RID: 160778 RVA: 0x003BDD3C File Offset: 0x003BBF3C
		public unsafe int Column
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGridSlot.__PropertyOffset_Column);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGridSlot.__PropertyOffset_Column) = value;
			}
		}

		// Token: 0x170096F0 RID: 38640
		// (get) Token: 0x0602740B RID: 160779 RVA: 0x003BDD4D File Offset: 0x003BBF4D
		// (set) Token: 0x0602740C RID: 160780 RVA: 0x003BDD5D File Offset: 0x003BBF5D
		public unsafe int ColumnSpan
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGridSlot.__PropertyOffset_ColumnSpan);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGridSlot.__PropertyOffset_ColumnSpan) = value;
			}
		}

		// Token: 0x170096F1 RID: 38641
		// (get) Token: 0x0602740D RID: 160781 RVA: 0x003BDD6E File Offset: 0x003BBF6E
		// (set) Token: 0x0602740E RID: 160782 RVA: 0x003BDD7E File Offset: 0x003BBF7E
		public unsafe int Layer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGridSlot.__PropertyOffset_Layer);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGridSlot.__PropertyOffset_Layer) = value;
			}
		}

		// Token: 0x170096F2 RID: 38642
		// (get) Token: 0x0602740F RID: 160783 RVA: 0x003BDD8F File Offset: 0x003BBF8F
		// (set) Token: 0x06027410 RID: 160784 RVA: 0x003BDDA3 File Offset: 0x003BBFA3
		public unsafe FVector2D Nudge
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGridSlot.__PropertyOffset_Nudge);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGridSlot.__PropertyOffset_Nudge) = value;
			}
		}

		// Token: 0x06027411 RID: 160785 RVA: 0x003BDDB8 File Offset: 0x003BBFB8
		public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
		{
			UGridSlot.__SetVerticalAlignment_Internal(base.NativePtr, InVerticalAlignment);
		}

		// Token: 0x06027412 RID: 160786 RVA: 0x003BDDCB File Offset: 0x003BBFCB
		public void SetRowSpan(int InRowSpan)
		{
			UGridSlot.__SetRowSpan_Internal(base.NativePtr, InRowSpan);
		}

		// Token: 0x06027413 RID: 160787 RVA: 0x003BDDD9 File Offset: 0x003BBFD9
		public void SetRow(int InRow)
		{
			UGridSlot.__SetRow_Internal(base.NativePtr, InRow);
		}

		// Token: 0x06027414 RID: 160788 RVA: 0x003BDDE7 File Offset: 0x003BBFE7
		public void SetPadding(FMargin InPadding)
		{
			UGridSlot.__SetPadding_Internal(base.NativePtr, InPadding);
		}

		// Token: 0x06027415 RID: 160789 RVA: 0x003BDDF5 File Offset: 0x003BBFF5
		public void SetNudge(FVector2D InNudge)
		{
			UGridSlot.__SetNudge_Internal(base.NativePtr, InNudge);
		}

		// Token: 0x06027416 RID: 160790 RVA: 0x003BDE03 File Offset: 0x003BC003
		public void SetLayer(int InLayer)
		{
			UGridSlot.__SetLayer_Internal(base.NativePtr, InLayer);
		}

		// Token: 0x06027417 RID: 160791 RVA: 0x003BDE11 File Offset: 0x003BC011
		public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
		{
			UGridSlot.__SetHorizontalAlignment_Internal(base.NativePtr, InHorizontalAlignment);
		}

		// Token: 0x06027418 RID: 160792 RVA: 0x003BDE24 File Offset: 0x003BC024
		public void SetColumnSpan(int InColumnSpan)
		{
			UGridSlot.__SetColumnSpan_Internal(base.NativePtr, InColumnSpan);
		}

		// Token: 0x06027419 RID: 160793 RVA: 0x003BDE32 File Offset: 0x003BC032
		public void SetColumn(int InColumn)
		{
			UGridSlot.__SetColumn_Internal(base.NativePtr, InColumn);
		}

		// Token: 0x0602741A RID: 160794
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVerticalAlignment_Internal(IntPtr @this, TEnumAsByte<EVerticalAlignment> InVerticalAlignment);

		// Token: 0x0602741B RID: 160795
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRowSpan_Internal(IntPtr @this, int InRowSpan);

		// Token: 0x0602741C RID: 160796
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRow_Internal(IntPtr @this, int InRow);

		// Token: 0x0602741D RID: 160797
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPadding_Internal(IntPtr @this, FMargin InPadding);

		// Token: 0x0602741E RID: 160798
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNudge_Internal(IntPtr @this, FVector2D InNudge);

		// Token: 0x0602741F RID: 160799
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLayer_Internal(IntPtr @this, int InLayer);

		// Token: 0x06027420 RID: 160800
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHorizontalAlignment_Internal(IntPtr @this, TEnumAsByte<EHorizontalAlignment> InHorizontalAlignment);

		// Token: 0x06027421 RID: 160801
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetColumnSpan_Internal(IntPtr @this, int InColumnSpan);

		// Token: 0x06027422 RID: 160802
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetColumn_Internal(IntPtr @this, int InColumn);

		// Token: 0x06027423 RID: 160803 RVA: 0x003BDE40 File Offset: 0x003BC040
		static UGridSlot()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.GridSlot");
		}

		// Token: 0x06027424 RID: 160804 RVA: 0x003BDE4E File Offset: 0x003BC04E
		protected UGridSlot(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401590C RID: 88332
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.GridSlot";

		// Token: 0x0401590D RID: 88333
		private static IntPtr _ClassPtr;

		// Token: 0x0401590E RID: 88334
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401590F RID: 88335
		internal static int __PropertyOffset_Padding;

		// Token: 0x04015910 RID: 88336
		internal static int __PropertyOffset_HorizontalAlignment;

		// Token: 0x04015911 RID: 88337
		internal static int __PropertyOffset_VerticalAlignment;

		// Token: 0x04015912 RID: 88338
		internal static int __PropertyOffset_Row;

		// Token: 0x04015913 RID: 88339
		internal static int __PropertyOffset_RowSpan;

		// Token: 0x04015914 RID: 88340
		internal static int __PropertyOffset_Column;

		// Token: 0x04015915 RID: 88341
		internal static int __PropertyOffset_ColumnSpan;

		// Token: 0x04015916 RID: 88342
		internal static int __PropertyOffset_Layer;

		// Token: 0x04015917 RID: 88343
		internal static int __PropertyOffset_Nudge;
	}
}
