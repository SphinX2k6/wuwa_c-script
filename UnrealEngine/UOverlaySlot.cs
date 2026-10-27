using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029BF RID: 10687
	[UnrealObjectPath("/Script/UMG.OverlaySlot")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UOverlaySlot : UPanelSlot, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060277FC RID: 161788 RVA: 0x003C48CC File Offset: 0x003C2ACC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UOverlaySlot._ClassPtr;
		}

		// Token: 0x060277FD RID: 161789 RVA: 0x003C48D8 File Offset: 0x003C2AD8
		public UOverlaySlot() : this(BuiltinUtils.AllocNativeUObject(UOverlaySlot.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060277FE RID: 161790 RVA: 0x003C4900 File Offset: 0x003C2B00
		[NullableContext(1)]
		public UOverlaySlot(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UOverlaySlot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009766 RID: 38758
		// (get) Token: 0x060277FF RID: 161791 RVA: 0x003C4933 File Offset: 0x003C2B33
		// (set) Token: 0x06027800 RID: 161792 RVA: 0x003C4947 File Offset: 0x003C2B47
		public unsafe FMargin Padding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOverlaySlot.__PropertyOffset_Padding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOverlaySlot.__PropertyOffset_Padding) = value;
			}
		}

		// Token: 0x17009767 RID: 38759
		// (get) Token: 0x06027801 RID: 161793 RVA: 0x003C495C File Offset: 0x003C2B5C
		// (set) Token: 0x06027802 RID: 161794 RVA: 0x003C4970 File Offset: 0x003C2B70
		public unsafe TEnumAsByte<EHorizontalAlignment> HorizontalAlignment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOverlaySlot.__PropertyOffset_HorizontalAlignment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOverlaySlot.__PropertyOffset_HorizontalAlignment) = value;
			}
		}

		// Token: 0x17009768 RID: 38760
		// (get) Token: 0x06027803 RID: 161795 RVA: 0x003C4985 File Offset: 0x003C2B85
		// (set) Token: 0x06027804 RID: 161796 RVA: 0x003C4999 File Offset: 0x003C2B99
		public unsafe TEnumAsByte<EVerticalAlignment> VerticalAlignment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOverlaySlot.__PropertyOffset_VerticalAlignment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOverlaySlot.__PropertyOffset_VerticalAlignment) = value;
			}
		}

		// Token: 0x06027805 RID: 161797 RVA: 0x003C49AE File Offset: 0x003C2BAE
		public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
		{
			UOverlaySlot.__SetVerticalAlignment_Internal(base.NativePtr, InVerticalAlignment);
		}

		// Token: 0x06027806 RID: 161798 RVA: 0x003C49C1 File Offset: 0x003C2BC1
		public void SetPadding(FMargin InPadding)
		{
			UOverlaySlot.__SetPadding_Internal(base.NativePtr, InPadding);
		}

		// Token: 0x06027807 RID: 161799 RVA: 0x003C49CF File Offset: 0x003C2BCF
		public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
		{
			UOverlaySlot.__SetHorizontalAlignment_Internal(base.NativePtr, InHorizontalAlignment);
		}

		// Token: 0x06027808 RID: 161800
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVerticalAlignment_Internal(IntPtr @this, TEnumAsByte<EVerticalAlignment> InVerticalAlignment);

		// Token: 0x06027809 RID: 161801
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPadding_Internal(IntPtr @this, FMargin InPadding);

		// Token: 0x0602780A RID: 161802
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHorizontalAlignment_Internal(IntPtr @this, TEnumAsByte<EHorizontalAlignment> InHorizontalAlignment);

		// Token: 0x0602780B RID: 161803 RVA: 0x003C49E2 File Offset: 0x003C2BE2
		static UOverlaySlot()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.OverlaySlot");
		}

		// Token: 0x0602780C RID: 161804 RVA: 0x003C49F0 File Offset: 0x003C2BF0
		protected UOverlaySlot(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015A91 RID: 88721
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.OverlaySlot";

		// Token: 0x04015A92 RID: 88722
		private static IntPtr _ClassPtr;

		// Token: 0x04015A93 RID: 88723
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015A94 RID: 88724
		internal static int __PropertyOffset_Padding;

		// Token: 0x04015A95 RID: 88725
		internal static int __PropertyOffset_HorizontalAlignment;

		// Token: 0x04015A96 RID: 88726
		internal static int __PropertyOffset_VerticalAlignment;
	}
}
