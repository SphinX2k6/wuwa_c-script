using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200223D RID: 8765
	[UnrealObjectPath("/Script/LTween.LTweenDelegateHandleWrapper")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FLTweenDelegateHandleWrapper : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060215E3 RID: 136675 RVA: 0x00312CB2 File Offset: 0x00310EB2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLTweenDelegateHandleWrapper._ScriptStructPtr != 0) ? FLTweenDelegateHandleWrapper._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LTween.LTweenDelegateHandleWrapper", ref FLTweenDelegateHandleWrapper._ScriptStructPtr);
		}

		// Token: 0x060215E4 RID: 136676 RVA: 0x00312CD6 File Offset: 0x00310ED6
		public FLTweenDelegateHandleWrapper()
		{
		}

		// Token: 0x060215E5 RID: 136677 RVA: 0x00312CDE File Offset: 0x00310EDE
		protected override IntPtr GetUStructPtr()
		{
			return FLTweenDelegateHandleWrapper.StaticStruct();
		}

		// Token: 0x060215E6 RID: 136678 RVA: 0x00312CEA File Offset: 0x00310EEA
		[NullableContext(2)]
		public FLTweenDelegateHandleWrapper(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060215E7 RID: 136679 RVA: 0x00312CF4 File Offset: 0x00310EF4
		public FLTweenDelegateHandleWrapper(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060215E8 RID: 136680 RVA: 0x00312CFF File Offset: 0x00310EFF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLTweenDelegateHandleWrapper(Pointer, false, true);
		}

		// Token: 0x060215E9 RID: 136681 RVA: 0x00312D09 File Offset: 0x00310F09
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLTweenDelegateHandleWrapper(Pointer, MemoryOwner);
		}

		// Token: 0x04011C7B RID: 72827
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LTween.LTweenDelegateHandleWrapper";

		// Token: 0x04011C7C RID: 72828
		private static IntPtr _ScriptStructPtr;
	}
}
