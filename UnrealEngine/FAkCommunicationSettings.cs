using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020001FB RID: 507
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkCommunicationSettings")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FAkCommunicationSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001DE0 RID: 7648 RVA: 0x0002C694 File Offset: 0x0002A894
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkCommunicationSettings._ScriptStructPtr != 0) ? FAkCommunicationSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkCommunicationSettings", ref FAkCommunicationSettings._ScriptStructPtr);
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x06001DE1 RID: 7649 RVA: 0x0002C6B8 File Offset: 0x0002A8B8
		// (set) Token: 0x06001DE2 RID: 7650 RVA: 0x0002C6C8 File Offset: 0x0002A8C8
		public unsafe uint PoolSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkCommunicationSettings.__PropertyOffset_PoolSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkCommunicationSettings.__PropertyOffset_PoolSize) = (int)value;
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x06001DE3 RID: 7651 RVA: 0x0002C6D9 File Offset: 0x0002A8D9
		// (set) Token: 0x06001DE4 RID: 7652 RVA: 0x0002C6E9 File Offset: 0x0002A8E9
		public unsafe ushort DiscoveryBroadcastPort
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkCommunicationSettings.__PropertyOffset_DiscoveryBroadcastPort);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkCommunicationSettings.__PropertyOffset_DiscoveryBroadcastPort) = (short)value;
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x06001DE5 RID: 7653 RVA: 0x0002C6FA File Offset: 0x0002A8FA
		// (set) Token: 0x06001DE6 RID: 7654 RVA: 0x0002C70A File Offset: 0x0002A90A
		public unsafe ushort CommandPort
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkCommunicationSettings.__PropertyOffset_CommandPort);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkCommunicationSettings.__PropertyOffset_CommandPort) = (short)value;
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06001DE7 RID: 7655 RVA: 0x0002C71B File Offset: 0x0002A91B
		// (set) Token: 0x06001DE8 RID: 7656 RVA: 0x0002C72F File Offset: 0x0002A92F
		public unsafe string NetworkName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAkCommunicationSettings.__PropertyOffset_NetworkName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAkCommunicationSettings.__PropertyOffset_NetworkName)), value);
			}
		}

		// Token: 0x06001DE9 RID: 7657 RVA: 0x0002C744 File Offset: 0x0002A944
		public FAkCommunicationSettings()
		{
		}

		// Token: 0x06001DEA RID: 7658 RVA: 0x0002C74C File Offset: 0x0002A94C
		public FAkCommunicationSettings(uint PoolSize, ushort DiscoveryBroadcastPort, ushort CommandPort, string NetworkName)
		{
			this.PoolSize = PoolSize;
			this.DiscoveryBroadcastPort = DiscoveryBroadcastPort;
			this.CommandPort = CommandPort;
			this.NetworkName = NetworkName;
		}

		// Token: 0x06001DEB RID: 7659 RVA: 0x0002C771 File Offset: 0x0002A971
		protected override IntPtr GetUStructPtr()
		{
			return FAkCommunicationSettings.StaticStruct();
		}

		// Token: 0x06001DEC RID: 7660 RVA: 0x0002C77D File Offset: 0x0002A97D
		[NullableContext(2)]
		public FAkCommunicationSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001DED RID: 7661 RVA: 0x0002C787 File Offset: 0x0002A987
		public FAkCommunicationSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001DEE RID: 7662 RVA: 0x0002C792 File Offset: 0x0002A992
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkCommunicationSettings(Pointer, false, true);
		}

		// Token: 0x06001DEF RID: 7663 RVA: 0x0002C79C File Offset: 0x0002A99C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkCommunicationSettings(Pointer, MemoryOwner);
		}

		// Token: 0x040009E6 RID: 2534
		public const string __ObjectPath = "/Script/AkAudio.AkCommunicationSettings";

		// Token: 0x040009E7 RID: 2535
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040009E8 RID: 2536
		internal static int __PropertyOffset_PoolSize;

		// Token: 0x040009E9 RID: 2537
		internal static int __PropertyOffset_DiscoveryBroadcastPort;

		// Token: 0x040009EA RID: 2538
		internal static int __PropertyOffset_CommandPort;

		// Token: 0x040009EB RID: 2539
		internal static int __PropertyOffset_NetworkName;
	}
}
