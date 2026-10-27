using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029D7 RID: 10711
	[UnrealObjectPath("/Script/UMG.SizeBoxSlot")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class USizeBoxSlot : UPanelSlot, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027A07 RID: 162311 RVA: 0x003C6F62 File Offset: 0x003C5162
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USizeBoxSlot._ClassPtr;
		}

		// Token: 0x06027A08 RID: 162312 RVA: 0x003C6F70 File Offset: 0x003C5170
		public USizeBoxSlot() : this(BuiltinUtils.AllocNativeUObject(USizeBoxSlot.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027A09 RID: 162313 RVA: 0x003C6F98 File Offset: 0x003C5198
		[NullableContext(1)]
		public USizeBoxSlot(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USizeBoxSlot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170097D3 RID: 38867
		// (get) Token: 0x06027A0A RID: 162314 RVA: 0x003C6FCB File Offset: 0x003C51CB
		// (set) Token: 0x06027A0B RID: 162315 RVA: 0x003C6FDF File Offset: 0x003C51DF
		public unsafe FMargin Padding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USizeBoxSlot.__PropertyOffset_Padding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USizeBoxSlot.__PropertyOffset_Padding) = value;
			}
		}

		// Token: 0x170097D4 RID: 38868
		// (get) Token: 0x06027A0C RID: 162316 RVA: 0x003C6FF4 File Offset: 0x003C51F4
		// (set) Token: 0x06027A0D RID: 162317 RVA: 0x003C7008 File Offset: 0x003C5208
		public unsafe TEnumAsByte<EHorizontalAlignment> HorizontalAlignment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USizeBoxSlot.__PropertyOffset_HorizontalAlignment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USizeBoxSlot.__PropertyOffset_HorizontalAlignment) = value;
			}
		}

		// Token: 0x170097D5 RID: 38869
		// (get) Token: 0x06027A0E RID: 162318 RVA: 0x003C701D File Offset: 0x003C521D
		// (set) Token: 0x06027A0F RID: 162319 RVA: 0x003C7031 File Offset: 0x003C5231
		public unsafe TEnumAsByte<EVerticalAlignment> VerticalAlignment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USizeBoxSlot.__PropertyOffset_VerticalAlignment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USizeBoxSlot.__PropertyOffset_VerticalAlignment) = value;
			}
		}

		// Token: 0x06027A10 RID: 162320 RVA: 0x003C7046 File Offset: 0x003C5246
		public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
		{
			USizeBoxSlot.__SetVerticalAlignment_Internal(base.NativePtr, InVerticalAlignment);
		}

		// Token: 0x06027A11 RID: 162321 RVA: 0x003C7059 File Offset: 0x003C5259
		public void SetPadding(FMargin InPadding)
		{
			USizeBoxSlot.__SetPadding_Internal(base.NativePtr, InPadding);
		}

		// Token: 0x06027A12 RID: 162322 RVA: 0x003C7067 File Offset: 0x003C5267
		public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
		{
			USizeBoxSlot.__SetHorizontalAlignment_Internal(base.NativePtr, InHorizontalAlignment);
		}

		// Token: 0x06027A13 RID: 162323
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVerticalAlignment_Internal(IntPtr @this, TEnumAsByte<EVerticalAlignment> InVerticalAlignment);

		// Token: 0x06027A14 RID: 162324
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPadding_Internal(IntPtr @this, FMargin InPadding);

		// Token: 0x06027A15 RID: 162325
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHorizontalAlignment_Internal(IntPtr @this, TEnumAsByte<EHorizontalAlignment> InHorizontalAlignment);

		// Token: 0x06027A16 RID: 162326 RVA: 0x003C707A File Offset: 0x003C527A
		static USizeBoxSlot()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.SizeBoxSlot");
		}

		// Token: 0x06027A17 RID: 162327 RVA: 0x003C7088 File Offset: 0x003C5288
		protected USizeBoxSlot(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015B5B RID: 88923
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.SizeBoxSlot";

		// Token: 0x04015B5C RID: 88924
		private static IntPtr _ClassPtr;

		// Token: 0x04015B5D RID: 88925
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015B5E RID: 88926
		internal static int __PropertyOffset_Padding;

		// Token: 0x04015B5F RID: 88927
		internal static int __PropertyOffset_HorizontalAlignment;

		// Token: 0x04015B60 RID: 88928
		internal static int __PropertyOffset_VerticalAlignment;
	}
}
