using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002A0A RID: 10762
	[UnrealObjectPath("/Script/UMG.WindowTitleBarAreaSlot")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UWindowTitleBarAreaSlot : UPanelSlot, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028038 RID: 163896 RVA: 0x003CE954 File Offset: 0x003CCB54
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWindowTitleBarAreaSlot._ClassPtr;
		}

		// Token: 0x06028039 RID: 163897 RVA: 0x003CE960 File Offset: 0x003CCB60
		public UWindowTitleBarAreaSlot() : this(BuiltinUtils.AllocNativeUObject(UWindowTitleBarAreaSlot.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602803A RID: 163898 RVA: 0x003CE988 File Offset: 0x003CCB88
		[NullableContext(1)]
		public UWindowTitleBarAreaSlot(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWindowTitleBarAreaSlot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170098D6 RID: 39126
		// (get) Token: 0x0602803B RID: 163899 RVA: 0x003CE9BB File Offset: 0x003CCBBB
		// (set) Token: 0x0602803C RID: 163900 RVA: 0x003CE9CF File Offset: 0x003CCBCF
		public unsafe FMargin Padding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWindowTitleBarAreaSlot.__PropertyOffset_Padding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWindowTitleBarAreaSlot.__PropertyOffset_Padding) = value;
			}
		}

		// Token: 0x170098D7 RID: 39127
		// (get) Token: 0x0602803D RID: 163901 RVA: 0x003CE9E4 File Offset: 0x003CCBE4
		// (set) Token: 0x0602803E RID: 163902 RVA: 0x003CE9F8 File Offset: 0x003CCBF8
		public unsafe TEnumAsByte<EHorizontalAlignment> HorizontalAlignment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWindowTitleBarAreaSlot.__PropertyOffset_HorizontalAlignment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWindowTitleBarAreaSlot.__PropertyOffset_HorizontalAlignment) = value;
			}
		}

		// Token: 0x170098D8 RID: 39128
		// (get) Token: 0x0602803F RID: 163903 RVA: 0x003CEA0D File Offset: 0x003CCC0D
		// (set) Token: 0x06028040 RID: 163904 RVA: 0x003CEA21 File Offset: 0x003CCC21
		public unsafe TEnumAsByte<EVerticalAlignment> VerticalAlignment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWindowTitleBarAreaSlot.__PropertyOffset_VerticalAlignment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWindowTitleBarAreaSlot.__PropertyOffset_VerticalAlignment) = value;
			}
		}

		// Token: 0x06028041 RID: 163905 RVA: 0x003CEA36 File Offset: 0x003CCC36
		public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
		{
			UWindowTitleBarAreaSlot.__SetVerticalAlignment_Internal(base.NativePtr, InVerticalAlignment);
		}

		// Token: 0x06028042 RID: 163906 RVA: 0x003CEA49 File Offset: 0x003CCC49
		public void SetPadding(FMargin InPadding)
		{
			UWindowTitleBarAreaSlot.__SetPadding_Internal(base.NativePtr, InPadding);
		}

		// Token: 0x06028043 RID: 163907 RVA: 0x003CEA57 File Offset: 0x003CCC57
		public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
		{
			UWindowTitleBarAreaSlot.__SetHorizontalAlignment_Internal(base.NativePtr, InHorizontalAlignment);
		}

		// Token: 0x06028044 RID: 163908
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVerticalAlignment_Internal(IntPtr @this, TEnumAsByte<EVerticalAlignment> InVerticalAlignment);

		// Token: 0x06028045 RID: 163909
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPadding_Internal(IntPtr @this, FMargin InPadding);

		// Token: 0x06028046 RID: 163910
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHorizontalAlignment_Internal(IntPtr @this, TEnumAsByte<EHorizontalAlignment> InHorizontalAlignment);

		// Token: 0x06028047 RID: 163911 RVA: 0x003CEA6A File Offset: 0x003CCC6A
		static UWindowTitleBarAreaSlot()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.WindowTitleBarAreaSlot");
		}

		// Token: 0x06028048 RID: 163912 RVA: 0x003CEA78 File Offset: 0x003CCC78
		protected UWindowTitleBarAreaSlot(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015D5D RID: 89437
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.WindowTitleBarAreaSlot";

		// Token: 0x04015D5E RID: 89438
		private static IntPtr _ClassPtr;

		// Token: 0x04015D5F RID: 89439
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015D60 RID: 89440
		internal static int __PropertyOffset_Padding;

		// Token: 0x04015D61 RID: 89441
		internal static int __PropertyOffset_HorizontalAlignment;

		// Token: 0x04015D62 RID: 89442
		internal static int __PropertyOffset_VerticalAlignment;
	}
}
