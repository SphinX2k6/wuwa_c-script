using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002A06 RID: 10758
	[UnrealObjectPath("/Script/UMG.WidgetSwitcherSlot")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UWidgetSwitcherSlot : UPanelSlot, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028001 RID: 163841 RVA: 0x003CE565 File Offset: 0x003CC765
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWidgetSwitcherSlot._ClassPtr;
		}

		// Token: 0x06028002 RID: 163842 RVA: 0x003CE574 File Offset: 0x003CC774
		public UWidgetSwitcherSlot() : this(BuiltinUtils.AllocNativeUObject(UWidgetSwitcherSlot.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028003 RID: 163843 RVA: 0x003CE59C File Offset: 0x003CC79C
		[NullableContext(1)]
		public UWidgetSwitcherSlot(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWidgetSwitcherSlot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170098CC RID: 39116
		// (get) Token: 0x06028004 RID: 163844 RVA: 0x003CE5CF File Offset: 0x003CC7CF
		// (set) Token: 0x06028005 RID: 163845 RVA: 0x003CE5E3 File Offset: 0x003CC7E3
		public unsafe FMargin Padding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetSwitcherSlot.__PropertyOffset_Padding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetSwitcherSlot.__PropertyOffset_Padding) = value;
			}
		}

		// Token: 0x170098CD RID: 39117
		// (get) Token: 0x06028006 RID: 163846 RVA: 0x003CE5F8 File Offset: 0x003CC7F8
		// (set) Token: 0x06028007 RID: 163847 RVA: 0x003CE60C File Offset: 0x003CC80C
		public unsafe TEnumAsByte<EHorizontalAlignment> HorizontalAlignment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetSwitcherSlot.__PropertyOffset_HorizontalAlignment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetSwitcherSlot.__PropertyOffset_HorizontalAlignment) = value;
			}
		}

		// Token: 0x170098CE RID: 39118
		// (get) Token: 0x06028008 RID: 163848 RVA: 0x003CE621 File Offset: 0x003CC821
		// (set) Token: 0x06028009 RID: 163849 RVA: 0x003CE635 File Offset: 0x003CC835
		public unsafe TEnumAsByte<EVerticalAlignment> VerticalAlignment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetSwitcherSlot.__PropertyOffset_VerticalAlignment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetSwitcherSlot.__PropertyOffset_VerticalAlignment) = value;
			}
		}

		// Token: 0x0602800A RID: 163850 RVA: 0x003CE64A File Offset: 0x003CC84A
		public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
		{
			UWidgetSwitcherSlot.__SetVerticalAlignment_Internal(base.NativePtr, InVerticalAlignment);
		}

		// Token: 0x0602800B RID: 163851 RVA: 0x003CE65D File Offset: 0x003CC85D
		public void SetPadding(FMargin InPadding)
		{
			UWidgetSwitcherSlot.__SetPadding_Internal(base.NativePtr, InPadding);
		}

		// Token: 0x0602800C RID: 163852 RVA: 0x003CE66B File Offset: 0x003CC86B
		public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
		{
			UWidgetSwitcherSlot.__SetHorizontalAlignment_Internal(base.NativePtr, InHorizontalAlignment);
		}

		// Token: 0x0602800D RID: 163853
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVerticalAlignment_Internal(IntPtr @this, TEnumAsByte<EVerticalAlignment> InVerticalAlignment);

		// Token: 0x0602800E RID: 163854
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPadding_Internal(IntPtr @this, FMargin InPadding);

		// Token: 0x0602800F RID: 163855
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHorizontalAlignment_Internal(IntPtr @this, TEnumAsByte<EHorizontalAlignment> InHorizontalAlignment);

		// Token: 0x06028010 RID: 163856 RVA: 0x003CE67E File Offset: 0x003CC87E
		static UWidgetSwitcherSlot()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.WidgetSwitcherSlot");
		}

		// Token: 0x06028011 RID: 163857 RVA: 0x003CE68C File Offset: 0x003CC88C
		protected UWidgetSwitcherSlot(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015D48 RID: 89416
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.WidgetSwitcherSlot";

		// Token: 0x04015D49 RID: 89417
		private static IntPtr _ClassPtr;

		// Token: 0x04015D4A RID: 89418
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015D4B RID: 89419
		internal static int __PropertyOffset_Padding;

		// Token: 0x04015D4C RID: 89420
		internal static int __PropertyOffset_HorizontalAlignment;

		// Token: 0x04015D4D RID: 89421
		internal static int __PropertyOffset_VerticalAlignment;
	}
}
