using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000675 RID: 1653
	[UnrealObjectPath("/Script/LGUI.LGUIDelegateHandleWrapper")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FLGUIDelegateHandleWrapper : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600900D RID: 36877 RVA: 0x000D80BA File Offset: 0x000D62BA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUIDelegateHandleWrapper._ScriptStructPtr != 0) ? FLGUIDelegateHandleWrapper._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUIDelegateHandleWrapper", ref FLGUIDelegateHandleWrapper._ScriptStructPtr);
		}

		// Token: 0x0600900E RID: 36878 RVA: 0x000D80DE File Offset: 0x000D62DE
		public FLGUIDelegateHandleWrapper()
		{
		}

		// Token: 0x0600900F RID: 36879 RVA: 0x000D80E6 File Offset: 0x000D62E6
		protected override IntPtr GetUStructPtr()
		{
			return FLGUIDelegateHandleWrapper.StaticStruct();
		}

		// Token: 0x06009010 RID: 36880 RVA: 0x000D80F2 File Offset: 0x000D62F2
		[NullableContext(2)]
		public FLGUIDelegateHandleWrapper(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009011 RID: 36881 RVA: 0x000D80FC File Offset: 0x000D62FC
		public FLGUIDelegateHandleWrapper(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009012 RID: 36882 RVA: 0x000D8107 File Offset: 0x000D6307
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUIDelegateHandleWrapper(Pointer, false, true);
		}

		// Token: 0x06009013 RID: 36883 RVA: 0x000D8111 File Offset: 0x000D6311
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUIDelegateHandleWrapper(Pointer, MemoryOwner);
		}

		// Token: 0x04003EF9 RID: 16121
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDelegateHandleWrapper";

		// Token: 0x04003EFA RID: 16122
		private static IntPtr _ScriptStructPtr;
	}
}
