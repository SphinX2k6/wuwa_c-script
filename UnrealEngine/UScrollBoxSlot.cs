using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029D2 RID: 10706
	[UnrealObjectPath("/Script/UMG.ScrollBoxSlot")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UScrollBoxSlot : UPanelSlot, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602798D RID: 162189 RVA: 0x003C657A File Offset: 0x003C477A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UScrollBoxSlot._ClassPtr;
		}

		// Token: 0x0602798E RID: 162190 RVA: 0x003C6588 File Offset: 0x003C4788
		public UScrollBoxSlot() : this(BuiltinUtils.AllocNativeUObject(UScrollBoxSlot.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602798F RID: 162191 RVA: 0x003C65B0 File Offset: 0x003C47B0
		[NullableContext(1)]
		public UScrollBoxSlot(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UScrollBoxSlot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170097BC RID: 38844
		// (get) Token: 0x06027990 RID: 162192 RVA: 0x003C65E3 File Offset: 0x003C47E3
		// (set) Token: 0x06027991 RID: 162193 RVA: 0x003C65F7 File Offset: 0x003C47F7
		public unsafe FMargin Padding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UScrollBoxSlot.__PropertyOffset_Padding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UScrollBoxSlot.__PropertyOffset_Padding) = value;
			}
		}

		// Token: 0x170097BD RID: 38845
		// (get) Token: 0x06027992 RID: 162194 RVA: 0x003C660C File Offset: 0x003C480C
		// (set) Token: 0x06027993 RID: 162195 RVA: 0x003C6620 File Offset: 0x003C4820
		public unsafe TEnumAsByte<EHorizontalAlignment> HorizontalAlignment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UScrollBoxSlot.__PropertyOffset_HorizontalAlignment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UScrollBoxSlot.__PropertyOffset_HorizontalAlignment) = value;
			}
		}

		// Token: 0x170097BE RID: 38846
		// (get) Token: 0x06027994 RID: 162196 RVA: 0x003C6635 File Offset: 0x003C4835
		// (set) Token: 0x06027995 RID: 162197 RVA: 0x003C6649 File Offset: 0x003C4849
		public unsafe TEnumAsByte<EVerticalAlignment> VerticalAlignment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UScrollBoxSlot.__PropertyOffset_VerticalAlignment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UScrollBoxSlot.__PropertyOffset_VerticalAlignment) = value;
			}
		}

		// Token: 0x06027996 RID: 162198 RVA: 0x003C665E File Offset: 0x003C485E
		public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
		{
			UScrollBoxSlot.__SetVerticalAlignment_Internal(base.NativePtr, InVerticalAlignment);
		}

		// Token: 0x06027997 RID: 162199 RVA: 0x003C6671 File Offset: 0x003C4871
		public void SetPadding(FMargin InPadding)
		{
			UScrollBoxSlot.__SetPadding_Internal(base.NativePtr, InPadding);
		}

		// Token: 0x06027998 RID: 162200 RVA: 0x003C667F File Offset: 0x003C487F
		public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
		{
			UScrollBoxSlot.__SetHorizontalAlignment_Internal(base.NativePtr, InHorizontalAlignment);
		}

		// Token: 0x06027999 RID: 162201
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVerticalAlignment_Internal(IntPtr @this, TEnumAsByte<EVerticalAlignment> InVerticalAlignment);

		// Token: 0x0602799A RID: 162202
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPadding_Internal(IntPtr @this, FMargin InPadding);

		// Token: 0x0602799B RID: 162203
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHorizontalAlignment_Internal(IntPtr @this, TEnumAsByte<EHorizontalAlignment> InHorizontalAlignment);

		// Token: 0x0602799C RID: 162204 RVA: 0x003C6692 File Offset: 0x003C4892
		static UScrollBoxSlot()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.ScrollBoxSlot");
		}

		// Token: 0x0602799D RID: 162205 RVA: 0x003C66A0 File Offset: 0x003C48A0
		protected UScrollBoxSlot(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015B2C RID: 88876
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.ScrollBoxSlot";

		// Token: 0x04015B2D RID: 88877
		private static IntPtr _ClassPtr;

		// Token: 0x04015B2E RID: 88878
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015B2F RID: 88879
		internal static int __PropertyOffset_Padding;

		// Token: 0x04015B30 RID: 88880
		internal static int __PropertyOffset_HorizontalAlignment;

		// Token: 0x04015B31 RID: 88881
		internal static int __PropertyOffset_VerticalAlignment;
	}
}
