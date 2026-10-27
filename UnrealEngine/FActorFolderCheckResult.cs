using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007C4 RID: 1988
	[UnrealObjectPath("/Script/Engine.ActorFolderCheckResult")]
	[UnrealStructLayout(280, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 280)]
	public class FActorFolderCheckResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006A32 RID: 27186 RVA: 0x00098BE7 File Offset: 0x00096DE7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FActorFolderCheckResult._ScriptStructPtr != 0) ? FActorFolderCheckResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ActorFolderCheckResult", ref FActorFolderCheckResult._ScriptStructPtr);
		}

		// Token: 0x06006A33 RID: 27187 RVA: 0x00098C0B File Offset: 0x00096E0B
		public FActorFolderCheckResult()
		{
		}

		// Token: 0x06006A34 RID: 27188 RVA: 0x00098C13 File Offset: 0x00096E13
		protected override IntPtr GetUStructPtr()
		{
			return FActorFolderCheckResult.StaticStruct();
		}

		// Token: 0x06006A35 RID: 27189 RVA: 0x00098C1F File Offset: 0x00096E1F
		[NullableContext(2)]
		public FActorFolderCheckResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006A36 RID: 27190 RVA: 0x00098C29 File Offset: 0x00096E29
		public FActorFolderCheckResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006A37 RID: 27191 RVA: 0x00098C34 File Offset: 0x00096E34
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FActorFolderCheckResult(Pointer, false, true);
		}

		// Token: 0x06006A38 RID: 27192 RVA: 0x00098C3E File Offset: 0x00096E3E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FActorFolderCheckResult(Pointer, MemoryOwner);
		}

		// Token: 0x0400332B RID: 13099
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ActorFolderCheckResult";

		// Token: 0x0400332C RID: 13100
		private static IntPtr _ScriptStructPtr;
	}
}
