using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001F19 RID: 7961
	[UnrealObjectPath("/Script/KuroUtility.XboxPermissionCheckResult")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FXboxPermissionCheckResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E354 RID: 123732 RVA: 0x002CE855 File Offset: 0x002CCA55
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FXboxPermissionCheckResult._ScriptStructPtr != 0) ? FXboxPermissionCheckResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroUtility.XboxPermissionCheckResult", ref FXboxPermissionCheckResult._ScriptStructPtr);
		}

		// Token: 0x170077F9 RID: 30713
		// (get) Token: 0x0601E355 RID: 123733 RVA: 0x002CE879 File Offset: 0x002CCA79
		// (set) Token: 0x0601E356 RID: 123734 RVA: 0x002CE889 File Offset: 0x002CCA89
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

		// Token: 0x170077FA RID: 30714
		// (get) Token: 0x0601E357 RID: 123735 RVA: 0x002CE89A File Offset: 0x002CCA9A
		// (set) Token: 0x0601E358 RID: 123736 RVA: 0x002CE8AA File Offset: 0x002CCAAA
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

		// Token: 0x170077FB RID: 30715
		// (get) Token: 0x0601E359 RID: 123737 RVA: 0x002CE8BB File Offset: 0x002CCABB
		// (set) Token: 0x0601E35A RID: 123738 RVA: 0x002CE8CB File Offset: 0x002CCACB
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

		// Token: 0x170077FC RID: 30716
		// (get) Token: 0x0601E35B RID: 123739 RVA: 0x002CE8DC File Offset: 0x002CCADC
		// (set) Token: 0x0601E35C RID: 123740 RVA: 0x002CE8EC File Offset: 0x002CCAEC
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

		// Token: 0x170077FD RID: 30717
		// (get) Token: 0x0601E35D RID: 123741 RVA: 0x002CE8FD File Offset: 0x002CCAFD
		// (set) Token: 0x0601E35E RID: 123742 RVA: 0x002CE90D File Offset: 0x002CCB0D
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

		// Token: 0x170077FE RID: 30718
		// (get) Token: 0x0601E35F RID: 123743 RVA: 0x002CE91E File Offset: 0x002CCB1E
		// (set) Token: 0x0601E360 RID: 123744 RVA: 0x002CE92E File Offset: 0x002CCB2E
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

		// Token: 0x0601E361 RID: 123745 RVA: 0x002CE93F File Offset: 0x002CCB3F
		public FXboxPermissionCheckResult()
		{
		}

		// Token: 0x0601E362 RID: 123746 RVA: 0x002CE947 File Offset: 0x002CCB47
		public FXboxPermissionCheckResult(bool bSuccess, bool bIsAllowed, long TargetXuid, EXboxPermission Permission, int DeniedPermission, int DenyReason)
		{
			this.bSuccess = bSuccess;
			this.bIsAllowed = bIsAllowed;
			this.TargetXuid = TargetXuid;
			this.Permission = Permission;
			this.DeniedPermission = DeniedPermission;
			this.DenyReason = DenyReason;
		}

		// Token: 0x0601E363 RID: 123747 RVA: 0x002CE97C File Offset: 0x002CCB7C
		protected override IntPtr GetUStructPtr()
		{
			return FXboxPermissionCheckResult.StaticStruct();
		}

		// Token: 0x0601E364 RID: 123748 RVA: 0x002CE988 File Offset: 0x002CCB88
		[NullableContext(2)]
		public FXboxPermissionCheckResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E365 RID: 123749 RVA: 0x002CE992 File Offset: 0x002CCB92
		public FXboxPermissionCheckResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E366 RID: 123750 RVA: 0x002CE99D File Offset: 0x002CCB9D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FXboxPermissionCheckResult(Pointer, false, true);
		}

		// Token: 0x0601E367 RID: 123751 RVA: 0x002CE9A7 File Offset: 0x002CCBA7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FXboxPermissionCheckResult(Pointer, MemoryOwner);
		}

		// Token: 0x040104DC RID: 66780
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.XboxPermissionCheckResult";

		// Token: 0x040104DD RID: 66781
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040104DE RID: 66782
		internal static int __PropertyOffset_bSuccess;

		// Token: 0x040104DF RID: 66783
		internal static int __PropertyOffset_bIsAllowed;

		// Token: 0x040104E0 RID: 66784
		internal static int __PropertyOffset_TargetXuid;

		// Token: 0x040104E1 RID: 66785
		internal static int __PropertyOffset_Permission;

		// Token: 0x040104E2 RID: 66786
		internal static int __PropertyOffset_DeniedPermission;

		// Token: 0x040104E3 RID: 66787
		internal static int __PropertyOffset_DenyReason;
	}
}
