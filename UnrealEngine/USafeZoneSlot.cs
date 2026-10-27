using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029CD RID: 10701
	[UnrealObjectPath("/Script/UMG.SafeZoneSlot")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class USafeZoneSlot : UPanelSlot, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060278F2 RID: 162034 RVA: 0x003C5AEC File Offset: 0x003C3CEC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USafeZoneSlot._ClassPtr;
		}

		// Token: 0x060278F3 RID: 162035 RVA: 0x003C5AF8 File Offset: 0x003C3CF8
		public USafeZoneSlot() : this(BuiltinUtils.AllocNativeUObject(USafeZoneSlot.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060278F4 RID: 162036 RVA: 0x003C5B20 File Offset: 0x003C3D20
		[NullableContext(1)]
		public USafeZoneSlot(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USafeZoneSlot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009795 RID: 38805
		// (get) Token: 0x060278F5 RID: 162037 RVA: 0x003C5B53 File Offset: 0x003C3D53
		// (set) Token: 0x060278F6 RID: 162038 RVA: 0x003C5B63 File Offset: 0x003C3D63
		public unsafe bool bIsTitleSafe
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USafeZoneSlot.__PropertyOffset_bIsTitleSafe) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USafeZoneSlot.__PropertyOffset_bIsTitleSafe) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009796 RID: 38806
		// (get) Token: 0x060278F7 RID: 162039 RVA: 0x003C5B74 File Offset: 0x003C3D74
		// (set) Token: 0x060278F8 RID: 162040 RVA: 0x003C5B88 File Offset: 0x003C3D88
		public unsafe FMargin SafeAreaScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USafeZoneSlot.__PropertyOffset_SafeAreaScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USafeZoneSlot.__PropertyOffset_SafeAreaScale) = value;
			}
		}

		// Token: 0x17009797 RID: 38807
		// (get) Token: 0x060278F9 RID: 162041 RVA: 0x003C5B9D File Offset: 0x003C3D9D
		// (set) Token: 0x060278FA RID: 162042 RVA: 0x003C5BB1 File Offset: 0x003C3DB1
		public unsafe TEnumAsByte<EHorizontalAlignment> HAlign
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USafeZoneSlot.__PropertyOffset_HAlign);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USafeZoneSlot.__PropertyOffset_HAlign) = value;
			}
		}

		// Token: 0x17009798 RID: 38808
		// (get) Token: 0x060278FB RID: 162043 RVA: 0x003C5BC6 File Offset: 0x003C3DC6
		// (set) Token: 0x060278FC RID: 162044 RVA: 0x003C5BDA File Offset: 0x003C3DDA
		public unsafe TEnumAsByte<EVerticalAlignment> VAlign
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USafeZoneSlot.__PropertyOffset_VAlign);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USafeZoneSlot.__PropertyOffset_VAlign) = value;
			}
		}

		// Token: 0x17009799 RID: 38809
		// (get) Token: 0x060278FD RID: 162045 RVA: 0x003C5BEF File Offset: 0x003C3DEF
		// (set) Token: 0x060278FE RID: 162046 RVA: 0x003C5C03 File Offset: 0x003C3E03
		public unsafe FMargin Padding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USafeZoneSlot.__PropertyOffset_Padding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USafeZoneSlot.__PropertyOffset_Padding) = value;
			}
		}

		// Token: 0x060278FF RID: 162047 RVA: 0x003C5C18 File Offset: 0x003C3E18
		static USafeZoneSlot()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.SafeZoneSlot");
		}

		// Token: 0x06027900 RID: 162048 RVA: 0x003C5C26 File Offset: 0x003C3E26
		protected USafeZoneSlot(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015AF2 RID: 88818
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.SafeZoneSlot";

		// Token: 0x04015AF3 RID: 88819
		private static IntPtr _ClassPtr;

		// Token: 0x04015AF4 RID: 88820
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015AF5 RID: 88821
		internal static int __PropertyOffset_bIsTitleSafe;

		// Token: 0x04015AF6 RID: 88822
		internal static int __PropertyOffset_SafeAreaScale;

		// Token: 0x04015AF7 RID: 88823
		internal static int __PropertyOffset_HAlign;

		// Token: 0x04015AF8 RID: 88824
		internal static int __PropertyOffset_VAlign;

		// Token: 0x04015AF9 RID: 88825
		internal static int __PropertyOffset_Padding;
	}
}
