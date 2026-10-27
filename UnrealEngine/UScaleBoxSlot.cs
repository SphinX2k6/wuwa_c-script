using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029CF RID: 10703
	[UnrealObjectPath("/Script/UMG.ScaleBoxSlot")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UScaleBoxSlot : UPanelSlot, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027916 RID: 162070 RVA: 0x003C5D84 File Offset: 0x003C3F84
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UScaleBoxSlot._ClassPtr;
		}

		// Token: 0x06027917 RID: 162071 RVA: 0x003C5D90 File Offset: 0x003C3F90
		public UScaleBoxSlot() : this(BuiltinUtils.AllocNativeUObject(UScaleBoxSlot.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027918 RID: 162072 RVA: 0x003C5DB8 File Offset: 0x003C3FB8
		[NullableContext(1)]
		public UScaleBoxSlot(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UScaleBoxSlot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700979E RID: 38814
		// (get) Token: 0x06027919 RID: 162073 RVA: 0x003C5DEB File Offset: 0x003C3FEB
		// (set) Token: 0x0602791A RID: 162074 RVA: 0x003C5DFF File Offset: 0x003C3FFF
		public unsafe FMargin Padding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UScaleBoxSlot.__PropertyOffset_Padding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UScaleBoxSlot.__PropertyOffset_Padding) = value;
			}
		}

		// Token: 0x1700979F RID: 38815
		// (get) Token: 0x0602791B RID: 162075 RVA: 0x003C5E14 File Offset: 0x003C4014
		// (set) Token: 0x0602791C RID: 162076 RVA: 0x003C5E28 File Offset: 0x003C4028
		public unsafe TEnumAsByte<EHorizontalAlignment> HorizontalAlignment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UScaleBoxSlot.__PropertyOffset_HorizontalAlignment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UScaleBoxSlot.__PropertyOffset_HorizontalAlignment) = value;
			}
		}

		// Token: 0x170097A0 RID: 38816
		// (get) Token: 0x0602791D RID: 162077 RVA: 0x003C5E3D File Offset: 0x003C403D
		// (set) Token: 0x0602791E RID: 162078 RVA: 0x003C5E51 File Offset: 0x003C4051
		public unsafe TEnumAsByte<EVerticalAlignment> VerticalAlignment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UScaleBoxSlot.__PropertyOffset_VerticalAlignment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UScaleBoxSlot.__PropertyOffset_VerticalAlignment) = value;
			}
		}

		// Token: 0x0602791F RID: 162079 RVA: 0x003C5E66 File Offset: 0x003C4066
		public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
		{
			UScaleBoxSlot.__SetVerticalAlignment_Internal(base.NativePtr, InVerticalAlignment);
		}

		// Token: 0x06027920 RID: 162080 RVA: 0x003C5E79 File Offset: 0x003C4079
		public void SetPadding(FMargin InPadding)
		{
			UScaleBoxSlot.__SetPadding_Internal(base.NativePtr, InPadding);
		}

		// Token: 0x06027921 RID: 162081 RVA: 0x003C5E87 File Offset: 0x003C4087
		public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
		{
			UScaleBoxSlot.__SetHorizontalAlignment_Internal(base.NativePtr, InHorizontalAlignment);
		}

		// Token: 0x06027922 RID: 162082
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVerticalAlignment_Internal(IntPtr @this, TEnumAsByte<EVerticalAlignment> InVerticalAlignment);

		// Token: 0x06027923 RID: 162083
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPadding_Internal(IntPtr @this, FMargin InPadding);

		// Token: 0x06027924 RID: 162084
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHorizontalAlignment_Internal(IntPtr @this, TEnumAsByte<EHorizontalAlignment> InHorizontalAlignment);

		// Token: 0x06027925 RID: 162085 RVA: 0x003C5E9A File Offset: 0x003C409A
		static UScaleBoxSlot()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.ScaleBoxSlot");
		}

		// Token: 0x06027926 RID: 162086 RVA: 0x003C5EA8 File Offset: 0x003C40A8
		protected UScaleBoxSlot(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015B01 RID: 88833
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.ScaleBoxSlot";

		// Token: 0x04015B02 RID: 88834
		private static IntPtr _ClassPtr;

		// Token: 0x04015B03 RID: 88835
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015B04 RID: 88836
		internal static int __PropertyOffset_Padding;

		// Token: 0x04015B05 RID: 88837
		internal static int __PropertyOffset_HorizontalAlignment;

		// Token: 0x04015B06 RID: 88838
		internal static int __PropertyOffset_VerticalAlignment;
	}
}
