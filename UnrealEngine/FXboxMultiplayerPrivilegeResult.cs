using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000622 RID: 1570
	[UnrealObjectPath("/Script/KuroUtility.XboxMultiplayerPrivilegeResult")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FXboxMultiplayerPrivilegeResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008956 RID: 35158 RVA: 0x000CF232 File Offset: 0x000CD432
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FXboxMultiplayerPrivilegeResult._ScriptStructPtr != 0) ? FXboxMultiplayerPrivilegeResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroUtility.XboxMultiplayerPrivilegeResult", ref FXboxMultiplayerPrivilegeResult._ScriptStructPtr);
		}

		// Token: 0x170019A1 RID: 6561
		// (get) Token: 0x06008957 RID: 35159 RVA: 0x000CF256 File Offset: 0x000CD456
		// (set) Token: 0x06008958 RID: 35160 RVA: 0x000CF266 File Offset: 0x000CD466
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

		// Token: 0x170019A2 RID: 6562
		// (get) Token: 0x06008959 RID: 35161 RVA: 0x000CF277 File Offset: 0x000CD477
		// (set) Token: 0x0600895A RID: 35162 RVA: 0x000CF287 File Offset: 0x000CD487
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

		// Token: 0x170019A3 RID: 6563
		// (get) Token: 0x0600895B RID: 35163 RVA: 0x000CF298 File Offset: 0x000CD498
		// (set) Token: 0x0600895C RID: 35164 RVA: 0x000CF2A8 File Offset: 0x000CD4A8
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

		// Token: 0x0600895D RID: 35165 RVA: 0x000CF2B9 File Offset: 0x000CD4B9
		public FXboxMultiplayerPrivilegeResult()
		{
		}

		// Token: 0x0600895E RID: 35166 RVA: 0x000CF2C1 File Offset: 0x000CD4C1
		protected override IntPtr GetUStructPtr()
		{
			return FXboxMultiplayerPrivilegeResult.StaticStruct();
		}

		// Token: 0x0600895F RID: 35167 RVA: 0x000CF2CD File Offset: 0x000CD4CD
		[NullableContext(2)]
		public FXboxMultiplayerPrivilegeResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008960 RID: 35168 RVA: 0x000CF2D7 File Offset: 0x000CD4D7
		public FXboxMultiplayerPrivilegeResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008961 RID: 35169 RVA: 0x000CF2E2 File Offset: 0x000CD4E2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FXboxMultiplayerPrivilegeResult(Pointer, false, true);
		}

		// Token: 0x06008962 RID: 35170 RVA: 0x000CF2EC File Offset: 0x000CD4EC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FXboxMultiplayerPrivilegeResult(Pointer, MemoryOwner);
		}

		// Token: 0x04003B9B RID: 15259
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.XboxMultiplayerPrivilegeResult";

		// Token: 0x04003B9C RID: 15260
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003B9D RID: 15261
		internal static int __PropertyOffset_bHasPrivilege;

		// Token: 0x04003B9E RID: 15262
		internal static int __PropertyOffset_HResult;

		// Token: 0x04003B9F RID: 15263
		internal static int __PropertyOffset_DenyReason;
	}
}
