using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200100E RID: 4110
	[UnrealObjectPath("/Script/Engine.PlayerMuteList")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FPlayerMuteList : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600E0A9 RID: 57513 RVA: 0x0014A66D File Offset: 0x0014886D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPlayerMuteList._ScriptStructPtr != 0) ? FPlayerMuteList._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PlayerMuteList", ref FPlayerMuteList._ScriptStructPtr);
		}

		// Token: 0x170034C4 RID: 13508
		// (get) Token: 0x0600E0AA RID: 57514 RVA: 0x0014A691 File Offset: 0x00148891
		// (set) Token: 0x0600E0AB RID: 57515 RVA: 0x0014A6A1 File Offset: 0x001488A1
		public unsafe bool bHasVoiceHandshakeCompleted
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPlayerMuteList.__PropertyOffset_bHasVoiceHandshakeCompleted) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPlayerMuteList.__PropertyOffset_bHasVoiceHandshakeCompleted) = (value ? 1 : 0);
			}
		}

		// Token: 0x170034C5 RID: 13509
		// (get) Token: 0x0600E0AC RID: 57516 RVA: 0x0014A6B2 File Offset: 0x001488B2
		// (set) Token: 0x0600E0AD RID: 57517 RVA: 0x0014A6C2 File Offset: 0x001488C2
		public unsafe int VoiceChannelIdx
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPlayerMuteList.__PropertyOffset_VoiceChannelIdx);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPlayerMuteList.__PropertyOffset_VoiceChannelIdx) = value;
			}
		}

		// Token: 0x0600E0AE RID: 57518 RVA: 0x0014A6D3 File Offset: 0x001488D3
		public FPlayerMuteList()
		{
		}

		// Token: 0x0600E0AF RID: 57519 RVA: 0x0014A6DB File Offset: 0x001488DB
		public FPlayerMuteList(bool bHasVoiceHandshakeCompleted, int VoiceChannelIdx)
		{
			this.bHasVoiceHandshakeCompleted = bHasVoiceHandshakeCompleted;
			this.VoiceChannelIdx = VoiceChannelIdx;
		}

		// Token: 0x0600E0B0 RID: 57520 RVA: 0x0014A6F1 File Offset: 0x001488F1
		protected override IntPtr GetUStructPtr()
		{
			return FPlayerMuteList.StaticStruct();
		}

		// Token: 0x0600E0B1 RID: 57521 RVA: 0x0014A6FD File Offset: 0x001488FD
		[NullableContext(2)]
		public FPlayerMuteList(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600E0B2 RID: 57522 RVA: 0x0014A707 File Offset: 0x00148907
		public FPlayerMuteList(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600E0B3 RID: 57523 RVA: 0x0014A712 File Offset: 0x00148912
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPlayerMuteList(Pointer, false, true);
		}

		// Token: 0x0600E0B4 RID: 57524 RVA: 0x0014A71C File Offset: 0x0014891C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPlayerMuteList(Pointer, MemoryOwner);
		}

		// Token: 0x040078B3 RID: 30899
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.PlayerMuteList";

		// Token: 0x040078B4 RID: 30900
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040078B5 RID: 30901
		internal static int __PropertyOffset_bHasVoiceHandshakeCompleted;

		// Token: 0x040078B6 RID: 30902
		internal static int __PropertyOffset_VoiceChannelIdx;
	}
}
