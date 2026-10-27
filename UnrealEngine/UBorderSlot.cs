using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200293D RID: 10557
	[UnrealObjectPath("/Script/UMG.BorderSlot")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UBorderSlot : UPanelSlot, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060270EF RID: 159983 RVA: 0x003B922D File Offset: 0x003B742D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBorderSlot._ClassPtr;
		}

		// Token: 0x060270F0 RID: 159984 RVA: 0x003B923C File Offset: 0x003B743C
		public UBorderSlot() : this(BuiltinUtils.AllocNativeUObject(UBorderSlot.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060270F1 RID: 159985 RVA: 0x003B9264 File Offset: 0x003B7464
		[NullableContext(1)]
		public UBorderSlot(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBorderSlot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700964A RID: 38474
		// (get) Token: 0x060270F2 RID: 159986 RVA: 0x003B9297 File Offset: 0x003B7497
		// (set) Token: 0x060270F3 RID: 159987 RVA: 0x003B92AB File Offset: 0x003B74AB
		public unsafe FMargin Padding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBorderSlot.__PropertyOffset_Padding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBorderSlot.__PropertyOffset_Padding) = value;
			}
		}

		// Token: 0x1700964B RID: 38475
		// (get) Token: 0x060270F4 RID: 159988 RVA: 0x003B92C0 File Offset: 0x003B74C0
		// (set) Token: 0x060270F5 RID: 159989 RVA: 0x003B92D4 File Offset: 0x003B74D4
		public unsafe TEnumAsByte<EHorizontalAlignment> HorizontalAlignment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBorderSlot.__PropertyOffset_HorizontalAlignment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBorderSlot.__PropertyOffset_HorizontalAlignment) = value;
			}
		}

		// Token: 0x1700964C RID: 38476
		// (get) Token: 0x060270F6 RID: 159990 RVA: 0x003B92E9 File Offset: 0x003B74E9
		// (set) Token: 0x060270F7 RID: 159991 RVA: 0x003B92FD File Offset: 0x003B74FD
		public unsafe TEnumAsByte<EVerticalAlignment> VerticalAlignment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBorderSlot.__PropertyOffset_VerticalAlignment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBorderSlot.__PropertyOffset_VerticalAlignment) = value;
			}
		}

		// Token: 0x060270F8 RID: 159992 RVA: 0x003B9312 File Offset: 0x003B7512
		public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
		{
			UBorderSlot.__SetVerticalAlignment_Internal(base.NativePtr, InVerticalAlignment);
		}

		// Token: 0x060270F9 RID: 159993 RVA: 0x003B9325 File Offset: 0x003B7525
		public void SetPadding(FMargin InPadding)
		{
			UBorderSlot.__SetPadding_Internal(base.NativePtr, InPadding);
		}

		// Token: 0x060270FA RID: 159994 RVA: 0x003B9333 File Offset: 0x003B7533
		public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
		{
			UBorderSlot.__SetHorizontalAlignment_Internal(base.NativePtr, InHorizontalAlignment);
		}

		// Token: 0x060270FB RID: 159995
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVerticalAlignment_Internal(IntPtr @this, TEnumAsByte<EVerticalAlignment> InVerticalAlignment);

		// Token: 0x060270FC RID: 159996
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPadding_Internal(IntPtr @this, FMargin InPadding);

		// Token: 0x060270FD RID: 159997
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHorizontalAlignment_Internal(IntPtr @this, TEnumAsByte<EHorizontalAlignment> InHorizontalAlignment);

		// Token: 0x060270FE RID: 159998 RVA: 0x003B9346 File Offset: 0x003B7546
		static UBorderSlot()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.BorderSlot");
		}

		// Token: 0x060270FF RID: 159999 RVA: 0x003B9354 File Offset: 0x003B7554
		protected UBorderSlot(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401575F RID: 87903
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.BorderSlot";

		// Token: 0x04015760 RID: 87904
		private static IntPtr _ClassPtr;

		// Token: 0x04015761 RID: 87905
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015762 RID: 87906
		internal static int __PropertyOffset_Padding;

		// Token: 0x04015763 RID: 87907
		internal static int __PropertyOffset_HorizontalAlignment;

		// Token: 0x04015764 RID: 87908
		internal static int __PropertyOffset_VerticalAlignment;
	}
}
