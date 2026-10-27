using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001F1C RID: 7964
	[UnrealObjectPath("/Script/KuroUtility.XboxUserHandleResult")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FXboxUserHandleResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E382 RID: 123778 RVA: 0x002CEB58 File Offset: 0x002CCD58
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FXboxUserHandleResult._ScriptStructPtr != 0) ? FXboxUserHandleResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroUtility.XboxUserHandleResult", ref FXboxUserHandleResult._ScriptStructPtr);
		}

		// Token: 0x17007804 RID: 30724
		// (get) Token: 0x0601E383 RID: 123779 RVA: 0x002CEB7C File Offset: 0x002CCD7C
		// (set) Token: 0x0601E384 RID: 123780 RVA: 0x002CEB8C File Offset: 0x002CCD8C
		public unsafe bool bSuccess
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXboxUserHandleResult.__PropertyOffset_bSuccess) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXboxUserHandleResult.__PropertyOffset_bSuccess) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007805 RID: 30725
		// (get) Token: 0x0601E385 RID: 123781 RVA: 0x002CEB9D File Offset: 0x002CCD9D
		// (set) Token: 0x0601E386 RID: 123782 RVA: 0x002CEBAD File Offset: 0x002CCDAD
		public unsafe long UserHandle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXboxUserHandleResult.__PropertyOffset_UserHandle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXboxUserHandleResult.__PropertyOffset_UserHandle) = value;
			}
		}

		// Token: 0x0601E387 RID: 123783 RVA: 0x002CEBBE File Offset: 0x002CCDBE
		public FXboxUserHandleResult()
		{
		}

		// Token: 0x0601E388 RID: 123784 RVA: 0x002CEBC6 File Offset: 0x002CCDC6
		public FXboxUserHandleResult(bool bSuccess, long UserHandle)
		{
			this.bSuccess = bSuccess;
			this.UserHandle = UserHandle;
		}

		// Token: 0x0601E389 RID: 123785 RVA: 0x002CEBDC File Offset: 0x002CCDDC
		protected override IntPtr GetUStructPtr()
		{
			return FXboxUserHandleResult.StaticStruct();
		}

		// Token: 0x0601E38A RID: 123786 RVA: 0x002CEBE8 File Offset: 0x002CCDE8
		[NullableContext(2)]
		public FXboxUserHandleResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E38B RID: 123787 RVA: 0x002CEBF2 File Offset: 0x002CCDF2
		public FXboxUserHandleResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E38C RID: 123788 RVA: 0x002CEBFD File Offset: 0x002CCDFD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FXboxUserHandleResult(Pointer, false, true);
		}

		// Token: 0x0601E38D RID: 123789 RVA: 0x002CEC07 File Offset: 0x002CCE07
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FXboxUserHandleResult(Pointer, MemoryOwner);
		}

		// Token: 0x040104ED RID: 66797
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.XboxUserHandleResult";

		// Token: 0x040104EE RID: 66798
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040104EF RID: 66799
		internal static int __PropertyOffset_bSuccess;

		// Token: 0x040104F0 RID: 66800
		internal static int __PropertyOffset_UserHandle;
	}
}
