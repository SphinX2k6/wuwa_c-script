using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200297D RID: 10621
	[UnrealObjectPath("/Script/UMG.KuroSafeZoneSlot")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UKuroSafeZoneSlot : UPanelSlot, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060274B3 RID: 160947 RVA: 0x003BEA8C File Offset: 0x003BCC8C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSafeZoneSlot._ClassPtr;
		}

		// Token: 0x060274B4 RID: 160948 RVA: 0x003BEA98 File Offset: 0x003BCC98
		public UKuroSafeZoneSlot() : this(BuiltinUtils.AllocNativeUObject(UKuroSafeZoneSlot.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060274B5 RID: 160949 RVA: 0x003BEAC0 File Offset: 0x003BCCC0
		[NullableContext(1)]
		public UKuroSafeZoneSlot(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSafeZoneSlot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700970C RID: 38668
		// (get) Token: 0x060274B6 RID: 160950 RVA: 0x003BEAF3 File Offset: 0x003BCCF3
		// (set) Token: 0x060274B7 RID: 160951 RVA: 0x003BEB03 File Offset: 0x003BCD03
		public unsafe bool bIsTitleSafe
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSafeZoneSlot.__PropertyOffset_bIsTitleSafe) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSafeZoneSlot.__PropertyOffset_bIsTitleSafe) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700970D RID: 38669
		// (get) Token: 0x060274B8 RID: 160952 RVA: 0x003BEB14 File Offset: 0x003BCD14
		// (set) Token: 0x060274B9 RID: 160953 RVA: 0x003BEB28 File Offset: 0x003BCD28
		public unsafe FMargin SafeAreaScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSafeZoneSlot.__PropertyOffset_SafeAreaScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSafeZoneSlot.__PropertyOffset_SafeAreaScale) = value;
			}
		}

		// Token: 0x1700970E RID: 38670
		// (get) Token: 0x060274BA RID: 160954 RVA: 0x003BEB3D File Offset: 0x003BCD3D
		// (set) Token: 0x060274BB RID: 160955 RVA: 0x003BEB51 File Offset: 0x003BCD51
		public unsafe TEnumAsByte<EHorizontalAlignment> HAlign
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSafeZoneSlot.__PropertyOffset_HAlign);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSafeZoneSlot.__PropertyOffset_HAlign) = value;
			}
		}

		// Token: 0x1700970F RID: 38671
		// (get) Token: 0x060274BC RID: 160956 RVA: 0x003BEB66 File Offset: 0x003BCD66
		// (set) Token: 0x060274BD RID: 160957 RVA: 0x003BEB7A File Offset: 0x003BCD7A
		public unsafe TEnumAsByte<EVerticalAlignment> VAlign
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSafeZoneSlot.__PropertyOffset_VAlign);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSafeZoneSlot.__PropertyOffset_VAlign) = value;
			}
		}

		// Token: 0x17009710 RID: 38672
		// (get) Token: 0x060274BE RID: 160958 RVA: 0x003BEB8F File Offset: 0x003BCD8F
		// (set) Token: 0x060274BF RID: 160959 RVA: 0x003BEBA3 File Offset: 0x003BCDA3
		public unsafe FMargin Padding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSafeZoneSlot.__PropertyOffset_Padding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSafeZoneSlot.__PropertyOffset_Padding) = value;
			}
		}

		// Token: 0x060274C0 RID: 160960 RVA: 0x003BEBB8 File Offset: 0x003BCDB8
		static UKuroSafeZoneSlot()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.KuroSafeZoneSlot");
		}

		// Token: 0x060274C1 RID: 160961 RVA: 0x003BEBC6 File Offset: 0x003BCDC6
		protected UKuroSafeZoneSlot(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015953 RID: 88403
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.KuroSafeZoneSlot";

		// Token: 0x04015954 RID: 88404
		private static IntPtr _ClassPtr;

		// Token: 0x04015955 RID: 88405
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015956 RID: 88406
		internal static int __PropertyOffset_bIsTitleSafe;

		// Token: 0x04015957 RID: 88407
		internal static int __PropertyOffset_SafeAreaScale;

		// Token: 0x04015958 RID: 88408
		internal static int __PropertyOffset_HAlign;

		// Token: 0x04015959 RID: 88409
		internal static int __PropertyOffset_VAlign;

		// Token: 0x0401595A RID: 88410
		internal static int __PropertyOffset_Padding;
	}
}
