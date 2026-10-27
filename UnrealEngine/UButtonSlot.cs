using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002940 RID: 10560
	[UnrealObjectPath("/Script/UMG.ButtonSlot")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UButtonSlot : UPanelSlot, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027134 RID: 160052 RVA: 0x003B982C File Offset: 0x003B7A2C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UButtonSlot._ClassPtr;
		}

		// Token: 0x06027135 RID: 160053 RVA: 0x003B9838 File Offset: 0x003B7A38
		public UButtonSlot() : this(BuiltinUtils.AllocNativeUObject(UButtonSlot.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027136 RID: 160054 RVA: 0x003B9860 File Offset: 0x003B7A60
		[NullableContext(1)]
		public UButtonSlot(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UButtonSlot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700965A RID: 38490
		// (get) Token: 0x06027137 RID: 160055 RVA: 0x003B9893 File Offset: 0x003B7A93
		// (set) Token: 0x06027138 RID: 160056 RVA: 0x003B98A7 File Offset: 0x003B7AA7
		public unsafe FMargin Padding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UButtonSlot.__PropertyOffset_Padding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UButtonSlot.__PropertyOffset_Padding) = value;
			}
		}

		// Token: 0x1700965B RID: 38491
		// (get) Token: 0x06027139 RID: 160057 RVA: 0x003B98BC File Offset: 0x003B7ABC
		// (set) Token: 0x0602713A RID: 160058 RVA: 0x003B98D0 File Offset: 0x003B7AD0
		public unsafe TEnumAsByte<EHorizontalAlignment> HorizontalAlignment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UButtonSlot.__PropertyOffset_HorizontalAlignment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UButtonSlot.__PropertyOffset_HorizontalAlignment) = value;
			}
		}

		// Token: 0x1700965C RID: 38492
		// (get) Token: 0x0602713B RID: 160059 RVA: 0x003B98E5 File Offset: 0x003B7AE5
		// (set) Token: 0x0602713C RID: 160060 RVA: 0x003B98F9 File Offset: 0x003B7AF9
		public unsafe TEnumAsByte<EVerticalAlignment> VerticalAlignment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UButtonSlot.__PropertyOffset_VerticalAlignment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UButtonSlot.__PropertyOffset_VerticalAlignment) = value;
			}
		}

		// Token: 0x0602713D RID: 160061 RVA: 0x003B990E File Offset: 0x003B7B0E
		public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
		{
			UButtonSlot.__SetVerticalAlignment_Internal(base.NativePtr, InVerticalAlignment);
		}

		// Token: 0x0602713E RID: 160062 RVA: 0x003B9921 File Offset: 0x003B7B21
		public void SetPadding(FMargin InPadding)
		{
			UButtonSlot.__SetPadding_Internal(base.NativePtr, InPadding);
		}

		// Token: 0x0602713F RID: 160063 RVA: 0x003B992F File Offset: 0x003B7B2F
		public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
		{
			UButtonSlot.__SetHorizontalAlignment_Internal(base.NativePtr, InHorizontalAlignment);
		}

		// Token: 0x06027140 RID: 160064
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVerticalAlignment_Internal(IntPtr @this, TEnumAsByte<EVerticalAlignment> InVerticalAlignment);

		// Token: 0x06027141 RID: 160065
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPadding_Internal(IntPtr @this, FMargin InPadding);

		// Token: 0x06027142 RID: 160066
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHorizontalAlignment_Internal(IntPtr @this, TEnumAsByte<EHorizontalAlignment> InHorizontalAlignment);

		// Token: 0x06027143 RID: 160067 RVA: 0x003B9942 File Offset: 0x003B7B42
		static UButtonSlot()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.ButtonSlot");
		}

		// Token: 0x06027144 RID: 160068 RVA: 0x003B9950 File Offset: 0x003B7B50
		protected UButtonSlot(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401577E RID: 87934
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.ButtonSlot";

		// Token: 0x0401577F RID: 87935
		private static IntPtr _ClassPtr;

		// Token: 0x04015780 RID: 87936
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015781 RID: 87937
		internal static int __PropertyOffset_Padding;

		// Token: 0x04015782 RID: 87938
		internal static int __PropertyOffset_HorizontalAlignment;

		// Token: 0x04015783 RID: 87939
		internal static int __PropertyOffset_VerticalAlignment;
	}
}
