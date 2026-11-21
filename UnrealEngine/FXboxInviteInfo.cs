using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000621 RID: 1569
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.XboxInviteInfo")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FXboxInviteInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008941 RID: 35137 RVA: 0x000CF0CB File Offset: 0x000CD2CB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FXboxInviteInfo._ScriptStructPtr != 0) ? FXboxInviteInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroUtility.XboxInviteInfo", ref FXboxInviteInfo._ScriptStructPtr);
		}

		// Token: 0x1700199A RID: 6554
		// (get) Token: 0x06008942 RID: 35138 RVA: 0x000CF0EF File Offset: 0x000CD2EF
		// (set) Token: 0x06008943 RID: 35139 RVA: 0x000CF0FF File Offset: 0x000CD2FF
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

		// Token: 0x1700199B RID: 6555
		// (get) Token: 0x06008944 RID: 35140 RVA: 0x000CF110 File Offset: 0x000CD310
		// (set) Token: 0x06008945 RID: 35141 RVA: 0x000CF124 File Offset: 0x000CD324
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

		// Token: 0x1700199C RID: 6556
		// (get) Token: 0x06008946 RID: 35142 RVA: 0x000CF139 File Offset: 0x000CD339
		// (set) Token: 0x06008947 RID: 35143 RVA: 0x000CF149 File Offset: 0x000CD349
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

		// Token: 0x1700199D RID: 6557
		// (get) Token: 0x06008948 RID: 35144 RVA: 0x000CF15A File Offset: 0x000CD35A
		// (set) Token: 0x06008949 RID: 35145 RVA: 0x000CF16A File Offset: 0x000CD36A
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

		// Token: 0x1700199E RID: 6558
		// (get) Token: 0x0600894A RID: 35146 RVA: 0x000CF17B File Offset: 0x000CD37B
		// (set) Token: 0x0600894B RID: 35147 RVA: 0x000CF18F File Offset: 0x000CD38F
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

		// Token: 0x1700199F RID: 6559
		// (get) Token: 0x0600894C RID: 35148 RVA: 0x000CF1A4 File Offset: 0x000CD3A4
		// (set) Token: 0x0600894D RID: 35149 RVA: 0x000CF1B8 File Offset: 0x000CD3B8
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

		// Token: 0x170019A0 RID: 6560
		// (get) Token: 0x0600894E RID: 35150 RVA: 0x000CF1CD File Offset: 0x000CD3CD
		// (set) Token: 0x0600894F RID: 35151 RVA: 0x000CF1E1 File Offset: 0x000CD3E1
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

		// Token: 0x06008950 RID: 35152 RVA: 0x000CF1F6 File Offset: 0x000CD3F6
		public FXboxInviteInfo()
		{
		}

		// Token: 0x06008951 RID: 35153 RVA: 0x000CF1FE File Offset: 0x000CD3FE
		protected override IntPtr GetUStructPtr()
		{
			return FXboxInviteInfo.StaticStruct();
		}

		// Token: 0x06008952 RID: 35154 RVA: 0x000CF20A File Offset: 0x000CD40A
		[NullableContext(2)]
		public FXboxInviteInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008953 RID: 35155 RVA: 0x000CF214 File Offset: 0x000CD414
		public FXboxInviteInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008954 RID: 35156 RVA: 0x000CF21F File Offset: 0x000CD41F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FXboxInviteInfo(Pointer, false, true);
		}

		// Token: 0x06008955 RID: 35157 RVA: 0x000CF229 File Offset: 0x000CD429
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FXboxInviteInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04003B92 RID: 15250
		public const string __ObjectPath = "/Script/KuroUtility.XboxInviteInfo";

		// Token: 0x04003B93 RID: 15251
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003B94 RID: 15252
		internal static int __PropertyOffset_bHasInvite;

		// Token: 0x04003B95 RID: 15253
		internal static int __PropertyOffset_HandleId;

		// Token: 0x04003B96 RID: 15254
		internal static int __PropertyOffset_InvitedXuid;

		// Token: 0x04003B97 RID: 15255
		internal static int __PropertyOffset_SenderXuid;

		// Token: 0x04003B98 RID: 15256
		internal static int __PropertyOffset_Context;

		// Token: 0x04003B99 RID: 15257
		internal static int __PropertyOffset_ConnectionString;

		// Token: 0x04003B9A RID: 15258
		internal static int __PropertyOffset_RawInviteUri;
	}
}
