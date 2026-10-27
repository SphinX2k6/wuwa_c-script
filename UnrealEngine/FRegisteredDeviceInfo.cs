using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002681 RID: 9857
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/RawInput.RegisteredDeviceInfo")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FRegisteredDeviceInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060249BC RID: 149948 RVA: 0x003631F7 File Offset: 0x003613F7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRegisteredDeviceInfo._ScriptStructPtr != 0) ? FRegisteredDeviceInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/RawInput.RegisteredDeviceInfo", ref FRegisteredDeviceInfo._ScriptStructPtr);
		}

		// Token: 0x17008D2C RID: 36140
		// (get) Token: 0x060249BD RID: 149949 RVA: 0x0036321B File Offset: 0x0036141B
		// (set) Token: 0x060249BE RID: 149950 RVA: 0x0036322B File Offset: 0x0036142B
		public unsafe int Handle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRegisteredDeviceInfo.__PropertyOffset_Handle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRegisteredDeviceInfo.__PropertyOffset_Handle) = value;
			}
		}

		// Token: 0x17008D2D RID: 36141
		// (get) Token: 0x060249BF RID: 149951 RVA: 0x0036323C File Offset: 0x0036143C
		// (set) Token: 0x060249C0 RID: 149952 RVA: 0x0036324C File Offset: 0x0036144C
		public unsafe int VendorID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRegisteredDeviceInfo.__PropertyOffset_VendorID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRegisteredDeviceInfo.__PropertyOffset_VendorID) = value;
			}
		}

		// Token: 0x17008D2E RID: 36142
		// (get) Token: 0x060249C1 RID: 149953 RVA: 0x0036325D File Offset: 0x0036145D
		// (set) Token: 0x060249C2 RID: 149954 RVA: 0x0036326D File Offset: 0x0036146D
		public unsafe int ProductID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRegisteredDeviceInfo.__PropertyOffset_ProductID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRegisteredDeviceInfo.__PropertyOffset_ProductID) = value;
			}
		}

		// Token: 0x17008D2F RID: 36143
		// (get) Token: 0x060249C3 RID: 149955 RVA: 0x0036327E File Offset: 0x0036147E
		// (set) Token: 0x060249C4 RID: 149956 RVA: 0x00363292 File Offset: 0x00361492
		public unsafe string DeviceName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FRegisteredDeviceInfo.__PropertyOffset_DeviceName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FRegisteredDeviceInfo.__PropertyOffset_DeviceName)), value);
			}
		}

		// Token: 0x060249C5 RID: 149957 RVA: 0x003632A7 File Offset: 0x003614A7
		public FRegisteredDeviceInfo()
		{
		}

		// Token: 0x060249C6 RID: 149958 RVA: 0x003632AF File Offset: 0x003614AF
		public FRegisteredDeviceInfo(int Handle, int VendorID, int ProductID, string DeviceName)
		{
			this.Handle = Handle;
			this.VendorID = VendorID;
			this.ProductID = ProductID;
			this.DeviceName = DeviceName;
		}

		// Token: 0x060249C7 RID: 149959 RVA: 0x003632D4 File Offset: 0x003614D4
		protected override IntPtr GetUStructPtr()
		{
			return FRegisteredDeviceInfo.StaticStruct();
		}

		// Token: 0x060249C8 RID: 149960 RVA: 0x003632E0 File Offset: 0x003614E0
		[NullableContext(2)]
		public FRegisteredDeviceInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060249C9 RID: 149961 RVA: 0x003632EA File Offset: 0x003614EA
		public FRegisteredDeviceInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060249CA RID: 149962 RVA: 0x003632F5 File Offset: 0x003614F5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRegisteredDeviceInfo(Pointer, false, true);
		}

		// Token: 0x060249CB RID: 149963 RVA: 0x003632FF File Offset: 0x003614FF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRegisteredDeviceInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04013AD4 RID: 80596
		public const string __ObjectPath = "/Script/RawInput.RegisteredDeviceInfo";

		// Token: 0x04013AD5 RID: 80597
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013AD6 RID: 80598
		internal static int __PropertyOffset_Handle;

		// Token: 0x04013AD7 RID: 80599
		internal static int __PropertyOffset_VendorID;

		// Token: 0x04013AD8 RID: 80600
		internal static int __PropertyOffset_ProductID;

		// Token: 0x04013AD9 RID: 80601
		internal static int __PropertyOffset_DeviceName;
	}
}
