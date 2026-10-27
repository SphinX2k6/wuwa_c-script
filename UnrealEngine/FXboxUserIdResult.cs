using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001F1D RID: 7965
	[UnrealObjectPath("/Script/KuroUtility.XboxUserIdResult")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FXboxUserIdResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E38E RID: 123790 RVA: 0x002CEC10 File Offset: 0x002CCE10
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FXboxUserIdResult._ScriptStructPtr != 0) ? FXboxUserIdResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroUtility.XboxUserIdResult", ref FXboxUserIdResult._ScriptStructPtr);
		}

		// Token: 0x17007806 RID: 30726
		// (get) Token: 0x0601E38F RID: 123791 RVA: 0x002CEC34 File Offset: 0x002CCE34
		// (set) Token: 0x0601E390 RID: 123792 RVA: 0x002CEC44 File Offset: 0x002CCE44
		public unsafe bool bSuccess
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXboxUserIdResult.__PropertyOffset_bSuccess) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXboxUserIdResult.__PropertyOffset_bSuccess) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007807 RID: 30727
		// (get) Token: 0x0601E391 RID: 123793 RVA: 0x002CEC55 File Offset: 0x002CCE55
		// (set) Token: 0x0601E392 RID: 123794 RVA: 0x002CEC65 File Offset: 0x002CCE65
		public unsafe long UserId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXboxUserIdResult.__PropertyOffset_UserId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXboxUserIdResult.__PropertyOffset_UserId) = value;
			}
		}

		// Token: 0x0601E393 RID: 123795 RVA: 0x002CEC76 File Offset: 0x002CCE76
		public FXboxUserIdResult()
		{
		}

		// Token: 0x0601E394 RID: 123796 RVA: 0x002CEC7E File Offset: 0x002CCE7E
		public FXboxUserIdResult(bool bSuccess, long UserId)
		{
			this.bSuccess = bSuccess;
			this.UserId = UserId;
		}

		// Token: 0x0601E395 RID: 123797 RVA: 0x002CEC94 File Offset: 0x002CCE94
		protected override IntPtr GetUStructPtr()
		{
			return FXboxUserIdResult.StaticStruct();
		}

		// Token: 0x0601E396 RID: 123798 RVA: 0x002CECA0 File Offset: 0x002CCEA0
		[NullableContext(2)]
		public FXboxUserIdResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E397 RID: 123799 RVA: 0x002CECAA File Offset: 0x002CCEAA
		public FXboxUserIdResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E398 RID: 123800 RVA: 0x002CECB5 File Offset: 0x002CCEB5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FXboxUserIdResult(Pointer, false, true);
		}

		// Token: 0x0601E399 RID: 123801 RVA: 0x002CECBF File Offset: 0x002CCEBF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FXboxUserIdResult(Pointer, MemoryOwner);
		}

		// Token: 0x040104F1 RID: 66801
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.XboxUserIdResult";

		// Token: 0x040104F2 RID: 66802
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040104F3 RID: 66803
		internal static int __PropertyOffset_bSuccess;

		// Token: 0x040104F4 RID: 66804
		internal static int __PropertyOffset_UserId;
	}
}
