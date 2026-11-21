using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000626 RID: 1574
	[UnrealObjectPath("/Script/KuroUtility.XboxUserIdResult")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FXboxUserIdResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600898C RID: 35212 RVA: 0x000CF56F File Offset: 0x000CD76F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FXboxUserIdResult._ScriptStructPtr != 0) ? FXboxUserIdResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroUtility.XboxUserIdResult", ref FXboxUserIdResult._ScriptStructPtr);
		}

		// Token: 0x170019AE RID: 6574
		// (get) Token: 0x0600898D RID: 35213 RVA: 0x000CF593 File Offset: 0x000CD793
		// (set) Token: 0x0600898E RID: 35214 RVA: 0x000CF5A3 File Offset: 0x000CD7A3
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

		// Token: 0x170019AF RID: 6575
		// (get) Token: 0x0600898F RID: 35215 RVA: 0x000CF5B4 File Offset: 0x000CD7B4
		// (set) Token: 0x06008990 RID: 35216 RVA: 0x000CF5C4 File Offset: 0x000CD7C4
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

		// Token: 0x06008991 RID: 35217 RVA: 0x000CF5D5 File Offset: 0x000CD7D5
		public FXboxUserIdResult()
		{
		}

		// Token: 0x06008992 RID: 35218 RVA: 0x000CF5DD File Offset: 0x000CD7DD
		protected override IntPtr GetUStructPtr()
		{
			return FXboxUserIdResult.StaticStruct();
		}

		// Token: 0x06008993 RID: 35219 RVA: 0x000CF5E9 File Offset: 0x000CD7E9
		[NullableContext(2)]
		public FXboxUserIdResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008994 RID: 35220 RVA: 0x000CF5F3 File Offset: 0x000CD7F3
		public FXboxUserIdResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008995 RID: 35221 RVA: 0x000CF5FE File Offset: 0x000CD7FE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FXboxUserIdResult(Pointer, false, true);
		}

		// Token: 0x06008996 RID: 35222 RVA: 0x000CF608 File Offset: 0x000CD808
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FXboxUserIdResult(Pointer, MemoryOwner);
		}

		// Token: 0x04003BB0 RID: 15280
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.XboxUserIdResult";

		// Token: 0x04003BB1 RID: 15281
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003BB2 RID: 15282
		internal static int __PropertyOffset_bSuccess;

		// Token: 0x04003BB3 RID: 15283
		internal static int __PropertyOffset_UserId;
	}
}
