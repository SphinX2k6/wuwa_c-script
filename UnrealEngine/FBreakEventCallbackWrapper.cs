using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000448 RID: 1096
	[UnrealObjectPath("/Script/ChaosSolverEngine.BreakEventCallbackWrapper")]
	[UnrealStructLayout(80, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FBreakEventCallbackWrapper : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003B35 RID: 15157 RVA: 0x0005952B File Offset: 0x0005772B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBreakEventCallbackWrapper._ScriptStructPtr != 0) ? FBreakEventCallbackWrapper._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ChaosSolverEngine.BreakEventCallbackWrapper", ref FBreakEventCallbackWrapper._ScriptStructPtr);
		}

		// Token: 0x06003B36 RID: 15158 RVA: 0x0005954F File Offset: 0x0005774F
		public FBreakEventCallbackWrapper()
		{
		}

		// Token: 0x06003B37 RID: 15159 RVA: 0x00059557 File Offset: 0x00057757
		protected override IntPtr GetUStructPtr()
		{
			return FBreakEventCallbackWrapper.StaticStruct();
		}

		// Token: 0x06003B38 RID: 15160 RVA: 0x00059563 File Offset: 0x00057763
		[NullableContext(2)]
		public FBreakEventCallbackWrapper(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003B39 RID: 15161 RVA: 0x0005956D File Offset: 0x0005776D
		public FBreakEventCallbackWrapper(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003B3A RID: 15162 RVA: 0x00059578 File Offset: 0x00057778
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBreakEventCallbackWrapper(Pointer, false, true);
		}

		// Token: 0x06003B3B RID: 15163 RVA: 0x00059582 File Offset: 0x00057782
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBreakEventCallbackWrapper(Pointer, MemoryOwner);
		}

		// Token: 0x04001B41 RID: 6977
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ChaosSolverEngine.BreakEventCallbackWrapper";

		// Token: 0x04001B42 RID: 6978
		private static IntPtr _ScriptStructPtr;
	}
}
