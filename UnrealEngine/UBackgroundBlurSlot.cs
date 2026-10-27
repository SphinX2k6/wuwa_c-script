using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002939 RID: 10553
	[UnrealObjectPath("/Script/UMG.BackgroundBlurSlot")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UBackgroundBlurSlot : UPanelSlot, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602708C RID: 159884 RVA: 0x003B89B4 File Offset: 0x003B6BB4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBackgroundBlurSlot._ClassPtr;
		}

		// Token: 0x0602708D RID: 159885 RVA: 0x003B89C0 File Offset: 0x003B6BC0
		public UBackgroundBlurSlot() : this(BuiltinUtils.AllocNativeUObject(UBackgroundBlurSlot.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602708E RID: 159886 RVA: 0x003B89E8 File Offset: 0x003B6BE8
		[NullableContext(1)]
		public UBackgroundBlurSlot(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBackgroundBlurSlot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009633 RID: 38451
		// (get) Token: 0x0602708F RID: 159887 RVA: 0x003B8A1B File Offset: 0x003B6C1B
		// (set) Token: 0x06027090 RID: 159888 RVA: 0x003B8A2F File Offset: 0x003B6C2F
		public unsafe FMargin Padding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBackgroundBlurSlot.__PropertyOffset_Padding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBackgroundBlurSlot.__PropertyOffset_Padding) = value;
			}
		}

		// Token: 0x17009634 RID: 38452
		// (get) Token: 0x06027091 RID: 159889 RVA: 0x003B8A44 File Offset: 0x003B6C44
		// (set) Token: 0x06027092 RID: 159890 RVA: 0x003B8A58 File Offset: 0x003B6C58
		public unsafe TEnumAsByte<EHorizontalAlignment> HorizontalAlignment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBackgroundBlurSlot.__PropertyOffset_HorizontalAlignment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBackgroundBlurSlot.__PropertyOffset_HorizontalAlignment) = value;
			}
		}

		// Token: 0x17009635 RID: 38453
		// (get) Token: 0x06027093 RID: 159891 RVA: 0x003B8A6D File Offset: 0x003B6C6D
		// (set) Token: 0x06027094 RID: 159892 RVA: 0x003B8A81 File Offset: 0x003B6C81
		public unsafe TEnumAsByte<EVerticalAlignment> VerticalAlignment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBackgroundBlurSlot.__PropertyOffset_VerticalAlignment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBackgroundBlurSlot.__PropertyOffset_VerticalAlignment) = value;
			}
		}

		// Token: 0x06027095 RID: 159893 RVA: 0x003B8A96 File Offset: 0x003B6C96
		public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
		{
			UBackgroundBlurSlot.__SetVerticalAlignment_Internal(base.NativePtr, InVerticalAlignment);
		}

		// Token: 0x06027096 RID: 159894 RVA: 0x003B8AA9 File Offset: 0x003B6CA9
		public void SetPadding(FMargin InPadding)
		{
			UBackgroundBlurSlot.__SetPadding_Internal(base.NativePtr, InPadding);
		}

		// Token: 0x06027097 RID: 159895 RVA: 0x003B8AB7 File Offset: 0x003B6CB7
		public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
		{
			UBackgroundBlurSlot.__SetHorizontalAlignment_Internal(base.NativePtr, InHorizontalAlignment);
		}

		// Token: 0x06027098 RID: 159896
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVerticalAlignment_Internal(IntPtr @this, TEnumAsByte<EVerticalAlignment> InVerticalAlignment);

		// Token: 0x06027099 RID: 159897
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPadding_Internal(IntPtr @this, FMargin InPadding);

		// Token: 0x0602709A RID: 159898
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHorizontalAlignment_Internal(IntPtr @this, TEnumAsByte<EHorizontalAlignment> InHorizontalAlignment);

		// Token: 0x0602709B RID: 159899 RVA: 0x003B8ACA File Offset: 0x003B6CCA
		static UBackgroundBlurSlot()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.BackgroundBlurSlot");
		}

		// Token: 0x0602709C RID: 159900 RVA: 0x003B8AD8 File Offset: 0x003B6CD8
		protected UBackgroundBlurSlot(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015734 RID: 87860
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.BackgroundBlurSlot";

		// Token: 0x04015735 RID: 87861
		private static IntPtr _ClassPtr;

		// Token: 0x04015736 RID: 87862
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015737 RID: 87863
		internal static int __PropertyOffset_Padding;

		// Token: 0x04015738 RID: 87864
		internal static int __PropertyOffset_HorizontalAlignment;

		// Token: 0x04015739 RID: 87865
		internal static int __PropertyOffset_VerticalAlignment;
	}
}
