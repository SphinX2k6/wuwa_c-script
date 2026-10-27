using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001F16 RID: 7958
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.XboxInviteInfo")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FXboxInviteInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E31E RID: 123678 RVA: 0x002CE49F File Offset: 0x002CC69F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FXboxInviteInfo._ScriptStructPtr != 0) ? FXboxInviteInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroUtility.XboxInviteInfo", ref FXboxInviteInfo._ScriptStructPtr);
		}

		// Token: 0x170077EA RID: 30698
		// (get) Token: 0x0601E31F RID: 123679 RVA: 0x002CE4C3 File Offset: 0x002CC6C3
		// (set) Token: 0x0601E320 RID: 123680 RVA: 0x002CE4D3 File Offset: 0x002CC6D3
		public unsafe bool bHasInvite
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXboxInviteInfo.__PropertyOffset_bHasInvite) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXboxInviteInfo.__PropertyOffset_bHasInvite) = (value ? 1 : 0);
			}
		}

		// Token: 0x170077EB RID: 30699
		// (get) Token: 0x0601E321 RID: 123681 RVA: 0x002CE4E4 File Offset: 0x002CC6E4
		// (set) Token: 0x0601E322 RID: 123682 RVA: 0x002CE4F8 File Offset: 0x002CC6F8
		public unsafe string HandleId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FXboxInviteInfo.__PropertyOffset_HandleId)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FXboxInviteInfo.__PropertyOffset_HandleId)), value);
			}
		}

		// Token: 0x170077EC RID: 30700
		// (get) Token: 0x0601E323 RID: 123683 RVA: 0x002CE50D File Offset: 0x002CC70D
		// (set) Token: 0x0601E324 RID: 123684 RVA: 0x002CE51D File Offset: 0x002CC71D
		public unsafe long InvitedXuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXboxInviteInfo.__PropertyOffset_InvitedXuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXboxInviteInfo.__PropertyOffset_InvitedXuid) = value;
			}
		}

		// Token: 0x170077ED RID: 30701
		// (get) Token: 0x0601E325 RID: 123685 RVA: 0x002CE52E File Offset: 0x002CC72E
		// (set) Token: 0x0601E326 RID: 123686 RVA: 0x002CE53E File Offset: 0x002CC73E
		public unsafe long SenderXuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXboxInviteInfo.__PropertyOffset_SenderXuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXboxInviteInfo.__PropertyOffset_SenderXuid) = value;
			}
		}

		// Token: 0x170077EE RID: 30702
		// (get) Token: 0x0601E327 RID: 123687 RVA: 0x002CE54F File Offset: 0x002CC74F
		// (set) Token: 0x0601E328 RID: 123688 RVA: 0x002CE563 File Offset: 0x002CC763
		public unsafe string Context
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FXboxInviteInfo.__PropertyOffset_Context)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FXboxInviteInfo.__PropertyOffset_Context)), value);
			}
		}

		// Token: 0x170077EF RID: 30703
		// (get) Token: 0x0601E329 RID: 123689 RVA: 0x002CE578 File Offset: 0x002CC778
		// (set) Token: 0x0601E32A RID: 123690 RVA: 0x002CE58C File Offset: 0x002CC78C
		public unsafe string ConnectionString
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FXboxInviteInfo.__PropertyOffset_ConnectionString)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FXboxInviteInfo.__PropertyOffset_ConnectionString)), value);
			}
		}

		// Token: 0x170077F0 RID: 30704
		// (get) Token: 0x0601E32B RID: 123691 RVA: 0x002CE5A1 File Offset: 0x002CC7A1
		// (set) Token: 0x0601E32C RID: 123692 RVA: 0x002CE5B5 File Offset: 0x002CC7B5
		public unsafe string RawInviteUri
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FXboxInviteInfo.__PropertyOffset_RawInviteUri)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FXboxInviteInfo.__PropertyOffset_RawInviteUri)), value);
			}
		}

		// Token: 0x0601E32D RID: 123693 RVA: 0x002CE5CA File Offset: 0x002CC7CA
		public FXboxInviteInfo()
		{
		}

		// Token: 0x0601E32E RID: 123694 RVA: 0x002CE5D2 File Offset: 0x002CC7D2
		public FXboxInviteInfo(bool bHasInvite, string HandleId, long InvitedXuid, long SenderXuid, string Context, string ConnectionString, string RawInviteUri)
		{
			this.bHasInvite = bHasInvite;
			this.HandleId = HandleId;
			this.InvitedXuid = InvitedXuid;
			this.SenderXuid = SenderXuid;
			this.Context = Context;
			this.ConnectionString = ConnectionString;
			this.RawInviteUri = RawInviteUri;
		}

		// Token: 0x0601E32F RID: 123695 RVA: 0x002CE60F File Offset: 0x002CC80F
		protected override IntPtr GetUStructPtr()
		{
			return FXboxInviteInfo.StaticStruct();
		}

		// Token: 0x0601E330 RID: 123696 RVA: 0x002CE61B File Offset: 0x002CC81B
		[NullableContext(2)]
		public FXboxInviteInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E331 RID: 123697 RVA: 0x002CE625 File Offset: 0x002CC825
		public FXboxInviteInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E332 RID: 123698 RVA: 0x002CE630 File Offset: 0x002CC830
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FXboxInviteInfo(Pointer, false, true);
		}

		// Token: 0x0601E333 RID: 123699 RVA: 0x002CE63A File Offset: 0x002CC83A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FXboxInviteInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040104C7 RID: 66759
		public const string __ObjectPath = "/Script/KuroUtility.XboxInviteInfo";

		// Token: 0x040104C8 RID: 66760
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040104C9 RID: 66761
		internal static int __PropertyOffset_bHasInvite;

		// Token: 0x040104CA RID: 66762
		internal static int __PropertyOffset_HandleId;

		// Token: 0x040104CB RID: 66763
		internal static int __PropertyOffset_InvitedXuid;

		// Token: 0x040104CC RID: 66764
		internal static int __PropertyOffset_SenderXuid;

		// Token: 0x040104CD RID: 66765
		internal static int __PropertyOffset_Context;

		// Token: 0x040104CE RID: 66766
		internal static int __PropertyOffset_ConnectionString;

		// Token: 0x040104CF RID: 66767
		internal static int __PropertyOffset_RawInviteUri;
	}
}
