using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020008E4 RID: 2276
	[UnrealObjectPath("/Script/Engine.BookmarkJumpToSettings")]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1)]
	public class FBookmarkJumpToSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007CE2 RID: 31970 RVA: 0x000B3169 File Offset: 0x000B1369
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBookmarkJumpToSettings._ScriptStructPtr != 0) ? FBookmarkJumpToSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BookmarkJumpToSettings", ref FBookmarkJumpToSettings._ScriptStructPtr);
		}

		// Token: 0x06007CE3 RID: 31971 RVA: 0x000B318D File Offset: 0x000B138D
		public FBookmarkJumpToSettings()
		{
		}

		// Token: 0x06007CE4 RID: 31972 RVA: 0x000B3195 File Offset: 0x000B1395
		protected override IntPtr GetUStructPtr()
		{
			return FBookmarkJumpToSettings.StaticStruct();
		}

		// Token: 0x06007CE5 RID: 31973 RVA: 0x000B31A1 File Offset: 0x000B13A1
		[NullableContext(2)]
		public FBookmarkJumpToSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007CE6 RID: 31974 RVA: 0x000B31AB File Offset: 0x000B13AB
		public FBookmarkJumpToSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007CE7 RID: 31975 RVA: 0x000B31B6 File Offset: 0x000B13B6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBookmarkJumpToSettings(Pointer, false, true);
		}

		// Token: 0x06007CE8 RID: 31976 RVA: 0x000B31C0 File Offset: 0x000B13C0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBookmarkJumpToSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04003BDD RID: 15325
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.BookmarkJumpToSettings";

		// Token: 0x04003BDE RID: 15326
		private static IntPtr _ScriptStructPtr;
	}
}
