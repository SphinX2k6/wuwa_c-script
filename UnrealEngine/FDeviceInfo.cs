using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020012E5 RID: 4837
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameMatrix.DeviceInfo")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 136)]
	public class FDeviceInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06011BAC RID: 72620 RVA: 0x001A064E File Offset: 0x0019E84E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDeviceInfo._ScriptStructPtr != 0) ? FDeviceInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameMatrix.DeviceInfo", ref FDeviceInfo._ScriptStructPtr);
		}

		// Token: 0x1700456D RID: 17773
		// (get) Token: 0x06011BAD RID: 72621 RVA: 0x001A0672 File Offset: 0x0019E872
		// (set) Token: 0x06011BAE RID: 72622 RVA: 0x001A0686 File Offset: 0x0019E886
		public unsafe string Type
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FDeviceInfo.__PropertyOffset_Type)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FDeviceInfo.__PropertyOffset_Type)), value);
			}
		}

		// Token: 0x1700456E RID: 17774
		// (get) Token: 0x06011BAF RID: 72623 RVA: 0x001A069B File Offset: 0x0019E89B
		// (set) Token: 0x06011BB0 RID: 72624 RVA: 0x001A06AB File Offset: 0x0019E8AB
		public unsafe EGameMatrixDeviceType DeviceType
		{
			get
			{
				return (EGameMatrixDeviceType)(*(base.NativePtr + (IntPtr)FDeviceInfo.__PropertyOffset_DeviceType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDeviceInfo.__PropertyOffset_DeviceType) = (byte)value;
			}
		}

		// Token: 0x1700456F RID: 17775
		// (get) Token: 0x06011BB1 RID: 72625 RVA: 0x001A06BC File Offset: 0x0019E8BC
		// (set) Token: 0x06011BB2 RID: 72626 RVA: 0x001A06CC File Offset: 0x0019E8CC
		public unsafe int Width
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDeviceInfo.__PropertyOffset_Width);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDeviceInfo.__PropertyOffset_Width) = value;
			}
		}

		// Token: 0x17004570 RID: 17776
		// (get) Token: 0x06011BB3 RID: 72627 RVA: 0x001A06DD File Offset: 0x0019E8DD
		// (set) Token: 0x06011BB4 RID: 72628 RVA: 0x001A06ED File Offset: 0x0019E8ED
		public unsafe int Height
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDeviceInfo.__PropertyOffset_Height);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDeviceInfo.__PropertyOffset_Height) = value;
			}
		}

		// Token: 0x17004571 RID: 17777
		// (get) Token: 0x06011BB5 RID: 72629 RVA: 0x001A06FE File Offset: 0x0019E8FE
		// (set) Token: 0x06011BB6 RID: 72630 RVA: 0x001A0712 File Offset: 0x0019E912
		public unsafe string IpAddr
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FDeviceInfo.__PropertyOffset_IpAddr)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FDeviceInfo.__PropertyOffset_IpAddr)), value);
			}
		}

		// Token: 0x17004572 RID: 17778
		// (get) Token: 0x06011BB7 RID: 72631 RVA: 0x001A0727 File Offset: 0x0019E927
		// (set) Token: 0x06011BB8 RID: 72632 RVA: 0x001A0737 File Offset: 0x0019E937
		public unsafe int UEvent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDeviceInfo.__PropertyOffset_UEvent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDeviceInfo.__PropertyOffset_UEvent) = value;
			}
		}

		// Token: 0x17004573 RID: 17779
		// (get) Token: 0x06011BB9 RID: 72633 RVA: 0x001A0748 File Offset: 0x0019E948
		// (set) Token: 0x06011BBA RID: 72634 RVA: 0x001A075C File Offset: 0x0019E95C
		public unsafe string OS
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FDeviceInfo.__PropertyOffset_OS)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FDeviceInfo.__PropertyOffset_OS)), value);
			}
		}

		// Token: 0x17004574 RID: 17780
		// (get) Token: 0x06011BBB RID: 72635 RVA: 0x001A0771 File Offset: 0x0019E971
		// (set) Token: 0x06011BBC RID: 72636 RVA: 0x001A0785 File Offset: 0x0019E985
		public unsafe string IMEI
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FDeviceInfo.__PropertyOffset_IMEI)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FDeviceInfo.__PropertyOffset_IMEI)), value);
			}
		}

		// Token: 0x17004575 RID: 17781
		// (get) Token: 0x06011BBD RID: 72637 RVA: 0x001A079A File Offset: 0x0019E99A
		// (set) Token: 0x06011BBE RID: 72638 RVA: 0x001A07AE File Offset: 0x0019E9AE
		public unsafe string QIMEI
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FDeviceInfo.__PropertyOffset_QIMEI)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FDeviceInfo.__PropertyOffset_QIMEI)), value);
			}
		}

		// Token: 0x17004576 RID: 17782
		// (get) Token: 0x06011BBF RID: 72639 RVA: 0x001A07C3 File Offset: 0x0019E9C3
		// (set) Token: 0x06011BC0 RID: 72640 RVA: 0x001A07D7 File Offset: 0x0019E9D7
		public unsafe string XId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FDeviceInfo.__PropertyOffset_XId)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FDeviceInfo.__PropertyOffset_XId)), value);
			}
		}

		// Token: 0x17004577 RID: 17783
		// (get) Token: 0x06011BC1 RID: 72641 RVA: 0x001A07EC File Offset: 0x0019E9EC
		// (set) Token: 0x06011BC2 RID: 72642 RVA: 0x001A0800 File Offset: 0x0019EA00
		public unsafe string Extra
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FDeviceInfo.__PropertyOffset_Extra)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FDeviceInfo.__PropertyOffset_Extra)), value);
			}
		}

		// Token: 0x06011BC3 RID: 72643 RVA: 0x001A0815 File Offset: 0x0019EA15
		public FDeviceInfo()
		{
		}

		// Token: 0x06011BC4 RID: 72644 RVA: 0x001A0820 File Offset: 0x0019EA20
		public FDeviceInfo(string Type, EGameMatrixDeviceType DeviceType, int Width, int Height, string IpAddr, int UEvent, string OS, string IMEI, string QIMEI, string XId, string Extra)
		{
			this.Type = Type;
			this.DeviceType = DeviceType;
			this.Width = Width;
			this.Height = Height;
			this.IpAddr = IpAddr;
			this.UEvent = UEvent;
			this.OS = OS;
			this.IMEI = IMEI;
			this.QIMEI = QIMEI;
			this.XId = XId;
			this.Extra = Extra;
		}

		// Token: 0x06011BC5 RID: 72645 RVA: 0x001A0888 File Offset: 0x0019EA88
		protected override IntPtr GetUStructPtr()
		{
			return FDeviceInfo.StaticStruct();
		}

		// Token: 0x06011BC6 RID: 72646 RVA: 0x001A0894 File Offset: 0x0019EA94
		[NullableContext(2)]
		public FDeviceInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06011BC7 RID: 72647 RVA: 0x001A089E File Offset: 0x0019EA9E
		public FDeviceInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06011BC8 RID: 72648 RVA: 0x001A08A9 File Offset: 0x0019EAA9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDeviceInfo(Pointer, false, true);
		}

		// Token: 0x06011BC9 RID: 72649 RVA: 0x001A08B3 File Offset: 0x0019EAB3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDeviceInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400983B RID: 38971
		public const string __ObjectPath = "/Script/GameMatrix.DeviceInfo";

		// Token: 0x0400983C RID: 38972
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400983D RID: 38973
		internal static int __PropertyOffset_Type;

		// Token: 0x0400983E RID: 38974
		internal static int __PropertyOffset_DeviceType;

		// Token: 0x0400983F RID: 38975
		internal static int __PropertyOffset_Width;

		// Token: 0x04009840 RID: 38976
		internal static int __PropertyOffset_Height;

		// Token: 0x04009841 RID: 38977
		internal static int __PropertyOffset_IpAddr;

		// Token: 0x04009842 RID: 38978
		internal static int __PropertyOffset_UEvent;

		// Token: 0x04009843 RID: 38979
		internal static int __PropertyOffset_OS;

		// Token: 0x04009844 RID: 38980
		internal static int __PropertyOffset_IMEI;

		// Token: 0x04009845 RID: 38981
		internal static int __PropertyOffset_QIMEI;

		// Token: 0x04009846 RID: 38982
		internal static int __PropertyOffset_XId;

		// Token: 0x04009847 RID: 38983
		internal static int __PropertyOffset_Extra;
	}
}
