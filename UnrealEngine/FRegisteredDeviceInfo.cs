using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007BD RID: 1981
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/RawInput.RegisteredDeviceInfo")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FRegisteredDeviceInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600ABB0 RID: 43952 RVA: 0x000FD300 File Offset: 0x000FB500
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRegisteredDeviceInfo._ScriptStructPtr != 0) ? FRegisteredDeviceInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/RawInput.RegisteredDeviceInfo", ref FRegisteredDeviceInfo._ScriptStructPtr);
		}

		// Token: 0x17001FF9 RID: 8185
		// (get) Token: 0x0600ABB1 RID: 43953 RVA: 0x000FD324 File Offset: 0x000FB524
		// (set) Token: 0x0600ABB2 RID: 43954 RVA: 0x000FD334 File Offset: 0x000FB534
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

		// Token: 0x17001FFA RID: 8186
		// (get) Token: 0x0600ABB3 RID: 43955 RVA: 0x000FD345 File Offset: 0x000FB545
		// (set) Token: 0x0600ABB4 RID: 43956 RVA: 0x000FD355 File Offset: 0x000FB555
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

		// Token: 0x17001FFB RID: 8187
		// (get) Token: 0x0600ABB5 RID: 43957 RVA: 0x000FD366 File Offset: 0x000FB566
		// (set) Token: 0x0600ABB6 RID: 43958 RVA: 0x000FD376 File Offset: 0x000FB576
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

		// Token: 0x17001FFC RID: 8188
		// (get) Token: 0x0600ABB7 RID: 43959 RVA: 0x000FD387 File Offset: 0x000FB587
		// (set) Token: 0x0600ABB8 RID: 43960 RVA: 0x000FD39B File Offset: 0x000FB59B
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

		// Token: 0x0600ABB9 RID: 43961 RVA: 0x000FD3B0 File Offset: 0x000FB5B0
		public FRegisteredDeviceInfo()
		{
		}

		// Token: 0x0600ABBA RID: 43962 RVA: 0x000FD3B8 File Offset: 0x000FB5B8
		protected override IntPtr GetUStructPtr()
		{
			return FRegisteredDeviceInfo.StaticStruct();
		}

		// Token: 0x0600ABBB RID: 43963 RVA: 0x000FD3C4 File Offset: 0x000FB5C4
		[NullableContext(2)]
		public FRegisteredDeviceInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600ABBC RID: 43964 RVA: 0x000FD3CE File Offset: 0x000FB5CE
		public FRegisteredDeviceInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600ABBD RID: 43965 RVA: 0x000FD3D9 File Offset: 0x000FB5D9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRegisteredDeviceInfo(Pointer, false, true);
		}

		// Token: 0x0600ABBE RID: 43966 RVA: 0x000FD3E3 File Offset: 0x000FB5E3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRegisteredDeviceInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040049CB RID: 18891
		public const string __ObjectPath = "/Script/RawInput.RegisteredDeviceInfo";

		// Token: 0x040049CC RID: 18892
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040049CD RID: 18893
		internal static int __PropertyOffset_Handle;

		// Token: 0x040049CE RID: 18894
		internal static int __PropertyOffset_VendorID;

		// Token: 0x040049CF RID: 18895
		internal static int __PropertyOffset_ProductID;

		// Token: 0x040049D0 RID: 18896
		internal static int __PropertyOffset_DeviceName;
	}
}
