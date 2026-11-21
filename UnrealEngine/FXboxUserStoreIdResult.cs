using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000627 RID: 1575
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.XboxUserStoreIdResult")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FXboxUserStoreIdResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008997 RID: 35223 RVA: 0x000CF611 File Offset: 0x000CD811
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FXboxUserStoreIdResult._ScriptStructPtr != 0) ? FXboxUserStoreIdResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroUtility.XboxUserStoreIdResult", ref FXboxUserStoreIdResult._ScriptStructPtr);
		}

		// Token: 0x170019B0 RID: 6576
		// (get) Token: 0x06008998 RID: 35224 RVA: 0x000CF635 File Offset: 0x000CD835
		// (set) Token: 0x06008999 RID: 35225 RVA: 0x000CF645 File Offset: 0x000CD845
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

		// Token: 0x170019B1 RID: 6577
		// (get) Token: 0x0600899A RID: 35226 RVA: 0x000CF656 File Offset: 0x000CD856
		// (set) Token: 0x0600899B RID: 35227 RVA: 0x000CF66A File Offset: 0x000CD86A
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

		// Token: 0x0600899C RID: 35228 RVA: 0x000CF67F File Offset: 0x000CD87F
		public FXboxUserStoreIdResult()
		{
		}

		// Token: 0x0600899D RID: 35229 RVA: 0x000CF687 File Offset: 0x000CD887
		protected override IntPtr GetUStructPtr()
		{
			return FXboxUserStoreIdResult.StaticStruct();
		}

		// Token: 0x0600899E RID: 35230 RVA: 0x000CF693 File Offset: 0x000CD893
		[NullableContext(2)]
		public FXboxUserStoreIdResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600899F RID: 35231 RVA: 0x000CF69D File Offset: 0x000CD89D
		public FXboxUserStoreIdResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060089A0 RID: 35232 RVA: 0x000CF6A8 File Offset: 0x000CD8A8
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FXboxUserStoreIdResult(Pointer, false, true);
		}

		// Token: 0x060089A1 RID: 35233 RVA: 0x000CF6B2 File Offset: 0x000CD8B2
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FXboxUserStoreIdResult(Pointer, MemoryOwner);
		}

		// Token: 0x04003BB4 RID: 15284
		public const string __ObjectPath = "/Script/KuroUtility.XboxUserStoreIdResult";

		// Token: 0x04003BB5 RID: 15285
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003BB6 RID: 15286
		internal static int __PropertyOffset_bSuccess;

		// Token: 0x04003BB7 RID: 15287
		internal static int __PropertyOffset_UserStoreId;
	}
}
