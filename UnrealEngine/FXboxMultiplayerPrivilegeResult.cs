using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001F18 RID: 7960
	[UnrealObjectPath("/Script/KuroUtility.XboxMultiplayerPrivilegeResult")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FXboxMultiplayerPrivilegeResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E346 RID: 123718 RVA: 0x002CE775 File Offset: 0x002CC975
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FXboxMultiplayerPrivilegeResult._ScriptStructPtr != 0) ? FXboxMultiplayerPrivilegeResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroUtility.XboxMultiplayerPrivilegeResult", ref FXboxMultiplayerPrivilegeResult._ScriptStructPtr);
		}

		// Token: 0x170077F6 RID: 30710
		// (get) Token: 0x0601E347 RID: 123719 RVA: 0x002CE799 File Offset: 0x002CC999
		// (set) Token: 0x0601E348 RID: 123720 RVA: 0x002CE7A9 File Offset: 0x002CC9A9
		public unsafe bool bHasPrivilege
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXboxMultiplayerPrivilegeResult.__PropertyOffset_bHasPrivilege) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXboxMultiplayerPrivilegeResult.__PropertyOffset_bHasPrivilege) = (value ? 1 : 0);
			}
		}

		// Token: 0x170077F7 RID: 30711
		// (get) Token: 0x0601E349 RID: 123721 RVA: 0x002CE7BA File Offset: 0x002CC9BA
		// (set) Token: 0x0601E34A RID: 123722 RVA: 0x002CE7CA File Offset: 0x002CC9CA
		public unsafe int HResult
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXboxMultiplayerPrivilegeResult.__PropertyOffset_HResult);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXboxMultiplayerPrivilegeResult.__PropertyOffset_HResult) = value;
			}
		}

		// Token: 0x170077F8 RID: 30712
		// (get) Token: 0x0601E34B RID: 123723 RVA: 0x002CE7DB File Offset: 0x002CC9DB
		// (set) Token: 0x0601E34C RID: 123724 RVA: 0x002CE7EB File Offset: 0x002CC9EB
		public unsafe int DenyReason
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXboxMultiplayerPrivilegeResult.__PropertyOffset_DenyReason);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXboxMultiplayerPrivilegeResult.__PropertyOffset_DenyReason) = value;
			}
		}

		// Token: 0x0601E34D RID: 123725 RVA: 0x002CE7FC File Offset: 0x002CC9FC
		public FXboxMultiplayerPrivilegeResult()
		{
		}

		// Token: 0x0601E34E RID: 123726 RVA: 0x002CE804 File Offset: 0x002CCA04
		public FXboxMultiplayerPrivilegeResult(bool bHasPrivilege, int HResult, int DenyReason)
		{
			this.bHasPrivilege = bHasPrivilege;
			this.HResult = HResult;
			this.DenyReason = DenyReason;
		}

		// Token: 0x0601E34F RID: 123727 RVA: 0x002CE821 File Offset: 0x002CCA21
		protected override IntPtr GetUStructPtr()
		{
			return FXboxMultiplayerPrivilegeResult.StaticStruct();
		}

		// Token: 0x0601E350 RID: 123728 RVA: 0x002CE82D File Offset: 0x002CCA2D
		[NullableContext(2)]
		public FXboxMultiplayerPrivilegeResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E351 RID: 123729 RVA: 0x002CE837 File Offset: 0x002CCA37
		public FXboxMultiplayerPrivilegeResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E352 RID: 123730 RVA: 0x002CE842 File Offset: 0x002CCA42
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FXboxMultiplayerPrivilegeResult(Pointer, false, true);
		}

		// Token: 0x0601E353 RID: 123731 RVA: 0x002CE84C File Offset: 0x002CCA4C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FXboxMultiplayerPrivilegeResult(Pointer, MemoryOwner);
		}

		// Token: 0x040104D7 RID: 66775
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.XboxMultiplayerPrivilegeResult";

		// Token: 0x040104D8 RID: 66776
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040104D9 RID: 66777
		internal static int __PropertyOffset_bHasPrivilege;

		// Token: 0x040104DA RID: 66778
		internal static int __PropertyOffset_HResult;

		// Token: 0x040104DB RID: 66779
		internal static int __PropertyOffset_DenyReason;
	}
}
