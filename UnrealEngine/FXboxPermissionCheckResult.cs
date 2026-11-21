using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000623 RID: 1571
	[UnrealObjectPath("/Script/KuroUtility.XboxPermissionCheckResult")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FXboxPermissionCheckResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008963 RID: 35171 RVA: 0x000CF2F5 File Offset: 0x000CD4F5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FXboxPermissionCheckResult._ScriptStructPtr != 0) ? FXboxPermissionCheckResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroUtility.XboxPermissionCheckResult", ref FXboxPermissionCheckResult._ScriptStructPtr);
		}

		// Token: 0x170019A4 RID: 6564
		// (get) Token: 0x06008964 RID: 35172 RVA: 0x000CF319 File Offset: 0x000CD519
		// (set) Token: 0x06008965 RID: 35173 RVA: 0x000CF329 File Offset: 0x000CD529
		public unsafe bool bSuccess
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXboxPermissionCheckResult.__PropertyOffset_bSuccess) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXboxPermissionCheckResult.__PropertyOffset_bSuccess) = (value ? 1 : 0);
			}
		}

		// Token: 0x170019A5 RID: 6565
		// (get) Token: 0x06008966 RID: 35174 RVA: 0x000CF33A File Offset: 0x000CD53A
		// (set) Token: 0x06008967 RID: 35175 RVA: 0x000CF34A File Offset: 0x000CD54A
		public unsafe bool bIsAllowed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXboxPermissionCheckResult.__PropertyOffset_bIsAllowed) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXboxPermissionCheckResult.__PropertyOffset_bIsAllowed) = (value ? 1 : 0);
			}
		}

		// Token: 0x170019A6 RID: 6566
		// (get) Token: 0x06008968 RID: 35176 RVA: 0x000CF35B File Offset: 0x000CD55B
		// (set) Token: 0x06008969 RID: 35177 RVA: 0x000CF36B File Offset: 0x000CD56B
		public unsafe long TargetXuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXboxPermissionCheckResult.__PropertyOffset_TargetXuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXboxPermissionCheckResult.__PropertyOffset_TargetXuid) = value;
			}
		}

		// Token: 0x170019A7 RID: 6567
		// (get) Token: 0x0600896A RID: 35178 RVA: 0x000CF37C File Offset: 0x000CD57C
		// (set) Token: 0x0600896B RID: 35179 RVA: 0x000CF38C File Offset: 0x000CD58C
		public unsafe EXboxPermission Permission
		{
			get
			{
				return (EXboxPermission)(*(base.NativePtr + (IntPtr)FXboxPermissionCheckResult.__PropertyOffset_Permission));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXboxPermissionCheckResult.__PropertyOffset_Permission) = (byte)value;
			}
		}

		// Token: 0x170019A8 RID: 6568
		// (get) Token: 0x0600896C RID: 35180 RVA: 0x000CF39D File Offset: 0x000CD59D
		// (set) Token: 0x0600896D RID: 35181 RVA: 0x000CF3AD File Offset: 0x000CD5AD
		public unsafe int DeniedPermission
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXboxPermissionCheckResult.__PropertyOffset_DeniedPermission);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXboxPermissionCheckResult.__PropertyOffset_DeniedPermission) = value;
			}
		}

		// Token: 0x170019A9 RID: 6569
		// (get) Token: 0x0600896E RID: 35182 RVA: 0x000CF3BE File Offset: 0x000CD5BE
		// (set) Token: 0x0600896F RID: 35183 RVA: 0x000CF3CE File Offset: 0x000CD5CE
		public unsafe int DenyReason
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXboxPermissionCheckResult.__PropertyOffset_DenyReason);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXboxPermissionCheckResult.__PropertyOffset_DenyReason) = value;
			}
		}

		// Token: 0x06008970 RID: 35184 RVA: 0x000CF3DF File Offset: 0x000CD5DF
		public FXboxPermissionCheckResult()
		{
		}

		// Token: 0x06008971 RID: 35185 RVA: 0x000CF3E7 File Offset: 0x000CD5E7
		protected override IntPtr GetUStructPtr()
		{
			return FXboxPermissionCheckResult.StaticStruct();
		}

		// Token: 0x06008972 RID: 35186 RVA: 0x000CF3F3 File Offset: 0x000CD5F3
		[NullableContext(2)]
		public FXboxPermissionCheckResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008973 RID: 35187 RVA: 0x000CF3FD File Offset: 0x000CD5FD
		public FXboxPermissionCheckResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008974 RID: 35188 RVA: 0x000CF408 File Offset: 0x000CD608
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FXboxPermissionCheckResult(Pointer, false, true);
		}

		// Token: 0x06008975 RID: 35189 RVA: 0x000CF412 File Offset: 0x000CD612
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FXboxPermissionCheckResult(Pointer, MemoryOwner);
		}

		// Token: 0x04003BA0 RID: 15264
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.XboxPermissionCheckResult";

		// Token: 0x04003BA1 RID: 15265
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003BA2 RID: 15266
		internal static int __PropertyOffset_bSuccess;

		// Token: 0x04003BA3 RID: 15267
		internal static int __PropertyOffset_bIsAllowed;

		// Token: 0x04003BA4 RID: 15268
		internal static int __PropertyOffset_TargetXuid;

		// Token: 0x04003BA5 RID: 15269
		internal static int __PropertyOffset_Permission;

		// Token: 0x04003BA6 RID: 15270
		internal static int __PropertyOffset_DeniedPermission;

		// Token: 0x04003BA7 RID: 15271
		internal static int __PropertyOffset_DenyReason;
	}
}
