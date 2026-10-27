using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001F1E RID: 7966
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.XboxUserStoreIdResult")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FXboxUserStoreIdResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E39A RID: 123802 RVA: 0x002CECC8 File Offset: 0x002CCEC8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FXboxUserStoreIdResult._ScriptStructPtr != 0) ? FXboxUserStoreIdResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroUtility.XboxUserStoreIdResult", ref FXboxUserStoreIdResult._ScriptStructPtr);
		}

		// Token: 0x17007808 RID: 30728
		// (get) Token: 0x0601E39B RID: 123803 RVA: 0x002CECEC File Offset: 0x002CCEEC
		// (set) Token: 0x0601E39C RID: 123804 RVA: 0x002CECFC File Offset: 0x002CCEFC
		public unsafe bool bSuccess
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXboxUserStoreIdResult.__PropertyOffset_bSuccess) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXboxUserStoreIdResult.__PropertyOffset_bSuccess) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007809 RID: 30729
		// (get) Token: 0x0601E39D RID: 123805 RVA: 0x002CED0D File Offset: 0x002CCF0D
		// (set) Token: 0x0601E39E RID: 123806 RVA: 0x002CED21 File Offset: 0x002CCF21
		public unsafe string UserStoreId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FXboxUserStoreIdResult.__PropertyOffset_UserStoreId)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FXboxUserStoreIdResult.__PropertyOffset_UserStoreId)), value);
			}
		}

		// Token: 0x0601E39F RID: 123807 RVA: 0x002CED36 File Offset: 0x002CCF36
		public FXboxUserStoreIdResult()
		{
		}

		// Token: 0x0601E3A0 RID: 123808 RVA: 0x002CED3E File Offset: 0x002CCF3E
		public FXboxUserStoreIdResult(bool bSuccess, string UserStoreId)
		{
			this.bSuccess = bSuccess;
			this.UserStoreId = UserStoreId;
		}

		// Token: 0x0601E3A1 RID: 123809 RVA: 0x002CED54 File Offset: 0x002CCF54
		protected override IntPtr GetUStructPtr()
		{
			return FXboxUserStoreIdResult.StaticStruct();
		}

		// Token: 0x0601E3A2 RID: 123810 RVA: 0x002CED60 File Offset: 0x002CCF60
		[NullableContext(2)]
		public FXboxUserStoreIdResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E3A3 RID: 123811 RVA: 0x002CED6A File Offset: 0x002CCF6A
		public FXboxUserStoreIdResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E3A4 RID: 123812 RVA: 0x002CED75 File Offset: 0x002CCF75
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FXboxUserStoreIdResult(Pointer, false, true);
		}

		// Token: 0x0601E3A5 RID: 123813 RVA: 0x002CED7F File Offset: 0x002CCF7F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FXboxUserStoreIdResult(Pointer, MemoryOwner);
		}

		// Token: 0x040104F5 RID: 66805
		public const string __ObjectPath = "/Script/KuroUtility.XboxUserStoreIdResult";

		// Token: 0x040104F6 RID: 66806
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040104F7 RID: 66807
		internal static int __PropertyOffset_bSuccess;

		// Token: 0x040104F8 RID: 66808
		internal static int __PropertyOffset_UserStoreId;
	}
}
