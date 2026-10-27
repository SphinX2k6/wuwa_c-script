using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002978 RID: 10616
	[UnrealObjectPath("/Script/UMG.HorizontalBoxSlot")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UHorizontalBoxSlot : UPanelSlot, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602742C RID: 160812 RVA: 0x003BDEF8 File Offset: 0x003BC0F8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHorizontalBoxSlot._ClassPtr;
		}

		// Token: 0x0602742D RID: 160813 RVA: 0x003BDF04 File Offset: 0x003BC104
		public UHorizontalBoxSlot() : this(BuiltinUtils.AllocNativeUObject(UHorizontalBoxSlot.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602742E RID: 160814 RVA: 0x003BDF2C File Offset: 0x003BC12C
		[NullableContext(1)]
		public UHorizontalBoxSlot(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHorizontalBoxSlot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170096F3 RID: 38643
		// (get) Token: 0x0602742F RID: 160815 RVA: 0x003BDF5F File Offset: 0x003BC15F
		// (set) Token: 0x06027430 RID: 160816 RVA: 0x003BDF73 File Offset: 0x003BC173
		public unsafe FMargin Padding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHorizontalBoxSlot.__PropertyOffset_Padding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHorizontalBoxSlot.__PropertyOffset_Padding) = value;
			}
		}

		// Token: 0x170096F4 RID: 38644
		// (get) Token: 0x06027431 RID: 160817 RVA: 0x003BDF88 File Offset: 0x003BC188
		// (set) Token: 0x06027432 RID: 160818 RVA: 0x003BDFC1 File Offset: 0x003BC1C1
		[Nullable(1)]
		public FSlateChildSize Size
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FSlateChildSize result;
				if ((result = this._Size) == null)
				{
					result = (this._Size = new FSlateChildSize(base.NativePtr + (IntPtr)UHorizontalBoxSlot.__PropertyOffset_Size, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateChildSize.StaticStruct(), base.NativePtr + (IntPtr)UHorizontalBoxSlot.__PropertyOffset_Size, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170096F5 RID: 38645
		// (get) Token: 0x06027433 RID: 160819 RVA: 0x003BDFE2 File Offset: 0x003BC1E2
		// (set) Token: 0x06027434 RID: 160820 RVA: 0x003BDFF6 File Offset: 0x003BC1F6
		public unsafe TEnumAsByte<EHorizontalAlignment> HorizontalAlignment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHorizontalBoxSlot.__PropertyOffset_HorizontalAlignment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHorizontalBoxSlot.__PropertyOffset_HorizontalAlignment) = value;
			}
		}

		// Token: 0x170096F6 RID: 38646
		// (get) Token: 0x06027435 RID: 160821 RVA: 0x003BE00B File Offset: 0x003BC20B
		// (set) Token: 0x06027436 RID: 160822 RVA: 0x003BE01F File Offset: 0x003BC21F
		public unsafe TEnumAsByte<EVerticalAlignment> VerticalAlignment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHorizontalBoxSlot.__PropertyOffset_VerticalAlignment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHorizontalBoxSlot.__PropertyOffset_VerticalAlignment) = value;
			}
		}

		// Token: 0x06027437 RID: 160823 RVA: 0x003BE034 File Offset: 0x003BC234
		public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
		{
			UHorizontalBoxSlot.__SetVerticalAlignment_Internal(base.NativePtr, InVerticalAlignment);
		}

		// Token: 0x06027438 RID: 160824 RVA: 0x003BE047 File Offset: 0x003BC247
		[NullableContext(2)]
		public void SetSize(FSlateChildSize InSize)
		{
			UHorizontalBoxSlot.__SetSize_Internal(base.NativePtr, (InSize ?? new FSlateChildSize()).NativePtr);
		}

		// Token: 0x06027439 RID: 160825 RVA: 0x003BE063 File Offset: 0x003BC263
		public void SetPadding(FMargin InPadding)
		{
			UHorizontalBoxSlot.__SetPadding_Internal(base.NativePtr, InPadding);
		}

		// Token: 0x0602743A RID: 160826 RVA: 0x003BE071 File Offset: 0x003BC271
		public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
		{
			UHorizontalBoxSlot.__SetHorizontalAlignment_Internal(base.NativePtr, InHorizontalAlignment);
		}

		// Token: 0x0602743B RID: 160827
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVerticalAlignment_Internal(IntPtr @this, TEnumAsByte<EVerticalAlignment> InVerticalAlignment);

		// Token: 0x0602743C RID: 160828
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSize_Internal(IntPtr @this, IntPtr InSize);

		// Token: 0x0602743D RID: 160829
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPadding_Internal(IntPtr @this, FMargin InPadding);

		// Token: 0x0602743E RID: 160830
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHorizontalAlignment_Internal(IntPtr @this, TEnumAsByte<EHorizontalAlignment> InHorizontalAlignment);

		// Token: 0x0602743F RID: 160831 RVA: 0x003BE084 File Offset: 0x003BC284
		static UHorizontalBoxSlot()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.HorizontalBoxSlot");
		}

		// Token: 0x06027440 RID: 160832 RVA: 0x003BE092 File Offset: 0x003BC292
		protected UHorizontalBoxSlot(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401591B RID: 88347
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.HorizontalBoxSlot";

		// Token: 0x0401591C RID: 88348
		private static IntPtr _ClassPtr;

		// Token: 0x0401591D RID: 88349
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401591E RID: 88350
		internal static int __PropertyOffset_Padding;

		// Token: 0x0401591F RID: 88351
		internal static int __PropertyOffset_Size;

		// Token: 0x04015920 RID: 88352
		[Nullable(2)]
		private FSlateChildSize _Size;

		// Token: 0x04015921 RID: 88353
		internal static int __PropertyOffset_HorizontalAlignment;

		// Token: 0x04015922 RID: 88354
		internal static int __PropertyOffset_VerticalAlignment;
	}
}
