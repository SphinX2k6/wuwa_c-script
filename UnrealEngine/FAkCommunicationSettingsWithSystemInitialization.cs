using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020001FD RID: 509
	[UnrealObjectPath("/Script/AkAudio.AkCommunicationSettingsWithSystemInitialization")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FAkCommunicationSettingsWithSystemInitialization : FAkCommunicationSettings, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001DFA RID: 7674 RVA: 0x0002C853 File Offset: 0x0002AA53
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkCommunicationSettingsWithSystemInitialization._ScriptStructPtr != 0) ? FAkCommunicationSettingsWithSystemInitialization._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkCommunicationSettingsWithSystemInitialization", ref FAkCommunicationSettingsWithSystemInitialization._ScriptStructPtr);
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06001DFB RID: 7675 RVA: 0x0002C877 File Offset: 0x0002AA77
		// (set) Token: 0x06001DFC RID: 7676 RVA: 0x0002C887 File Offset: 0x0002AA87
		public unsafe bool InitializeSystemComms
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkCommunicationSettingsWithSystemInitialization.__PropertyOffset_InitializeSystemComms) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkCommunicationSettingsWithSystemInitialization.__PropertyOffset_InitializeSystemComms) = (value ? 1 : 0);
			}
		}

		// Token: 0x06001DFD RID: 7677 RVA: 0x0002C898 File Offset: 0x0002AA98
		public FAkCommunicationSettingsWithSystemInitialization()
		{
		}

		// Token: 0x06001DFE RID: 7678 RVA: 0x0002C8A0 File Offset: 0x0002AAA0
		[NullableContext(1)]
		public FAkCommunicationSettingsWithSystemInitialization(bool InitializeSystemComms, uint PoolSize, ushort DiscoveryBroadcastPort, ushort CommandPort, string NetworkName)
		{
			this.InitializeSystemComms = InitializeSystemComms;
			base.PoolSize = PoolSize;
			base.DiscoveryBroadcastPort = DiscoveryBroadcastPort;
			base.CommandPort = CommandPort;
			base.NetworkName = NetworkName;
		}

		// Token: 0x06001DFF RID: 7679 RVA: 0x0002C8CD File Offset: 0x0002AACD
		protected override IntPtr GetUStructPtr()
		{
			return FAkCommunicationSettingsWithSystemInitialization.StaticStruct();
		}

		// Token: 0x06001E00 RID: 7680 RVA: 0x0002C8D9 File Offset: 0x0002AAD9
		[NullableContext(2)]
		public FAkCommunicationSettingsWithSystemInitialization(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001E01 RID: 7681 RVA: 0x0002C8E3 File Offset: 0x0002AAE3
		public FAkCommunicationSettingsWithSystemInitialization(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001E02 RID: 7682 RVA: 0x0002C8EE File Offset: 0x0002AAEE
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkCommunicationSettingsWithSystemInitialization(Pointer, false, true);
		}

		// Token: 0x06001E03 RID: 7683 RVA: 0x0002C8F8 File Offset: 0x0002AAF8
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkCommunicationSettingsWithSystemInitialization(Pointer, MemoryOwner);
		}

		// Token: 0x040009EF RID: 2543
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkCommunicationSettingsWithSystemInitialization";

		// Token: 0x040009F0 RID: 2544
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040009F1 RID: 2545
		internal static int __PropertyOffset_InitializeSystemComms;
	}
}
