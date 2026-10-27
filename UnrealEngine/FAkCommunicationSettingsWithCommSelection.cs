using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020001FC RID: 508
	[UnrealObjectPath("/Script/AkAudio.AkCommunicationSettingsWithCommSelection")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FAkCommunicationSettingsWithCommSelection : FAkCommunicationSettings, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001DF0 RID: 7664 RVA: 0x0002C7A5 File Offset: 0x0002A9A5
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkCommunicationSettingsWithCommSelection._ScriptStructPtr != 0) ? FAkCommunicationSettingsWithCommSelection._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkCommunicationSettingsWithCommSelection", ref FAkCommunicationSettingsWithCommSelection._ScriptStructPtr);
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x06001DF1 RID: 7665 RVA: 0x0002C7C9 File Offset: 0x0002A9C9
		// (set) Token: 0x06001DF2 RID: 7666 RVA: 0x0002C7D9 File Offset: 0x0002A9D9
		public unsafe EAkCommSystem CommunicationSystem
		{
			get
			{
				return (EAkCommSystem)(*(base.NativePtr + (IntPtr)FAkCommunicationSettingsWithCommSelection.__PropertyOffset_CommunicationSystem));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkCommunicationSettingsWithCommSelection.__PropertyOffset_CommunicationSystem) = (int)value;
			}
		}

		// Token: 0x06001DF3 RID: 7667 RVA: 0x0002C7EA File Offset: 0x0002A9EA
		public FAkCommunicationSettingsWithCommSelection()
		{
		}

		// Token: 0x06001DF4 RID: 7668 RVA: 0x0002C7F2 File Offset: 0x0002A9F2
		[NullableContext(1)]
		public FAkCommunicationSettingsWithCommSelection(EAkCommSystem CommunicationSystem, uint PoolSize, ushort DiscoveryBroadcastPort, ushort CommandPort, string NetworkName)
		{
			this.CommunicationSystem = CommunicationSystem;
			base.PoolSize = PoolSize;
			base.DiscoveryBroadcastPort = DiscoveryBroadcastPort;
			base.CommandPort = CommandPort;
			base.NetworkName = NetworkName;
		}

		// Token: 0x06001DF5 RID: 7669 RVA: 0x0002C81F File Offset: 0x0002AA1F
		protected override IntPtr GetUStructPtr()
		{
			return FAkCommunicationSettingsWithCommSelection.StaticStruct();
		}

		// Token: 0x06001DF6 RID: 7670 RVA: 0x0002C82B File Offset: 0x0002AA2B
		[NullableContext(2)]
		public FAkCommunicationSettingsWithCommSelection(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001DF7 RID: 7671 RVA: 0x0002C835 File Offset: 0x0002AA35
		public FAkCommunicationSettingsWithCommSelection(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001DF8 RID: 7672 RVA: 0x0002C840 File Offset: 0x0002AA40
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkCommunicationSettingsWithCommSelection(Pointer, false, true);
		}

		// Token: 0x06001DF9 RID: 7673 RVA: 0x0002C84A File Offset: 0x0002AA4A
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkCommunicationSettingsWithCommSelection(Pointer, MemoryOwner);
		}

		// Token: 0x040009EC RID: 2540
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkCommunicationSettingsWithCommSelection";

		// Token: 0x040009ED RID: 2541
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040009EE RID: 2542
		internal static int __PropertyOffset_CommunicationSystem;
	}
}
