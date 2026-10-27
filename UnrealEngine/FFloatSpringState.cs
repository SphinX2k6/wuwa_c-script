using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000BDB RID: 3035
	[UnrealObjectPath("/Script/Engine.FloatSpringState")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FFloatSpringState : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009536 RID: 38198 RVA: 0x000D4E3C File Offset: 0x000D303C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFloatSpringState._ScriptStructPtr != 0) ? FFloatSpringState._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.FloatSpringState", ref FFloatSpringState._ScriptStructPtr);
		}

		// Token: 0x06009537 RID: 38199 RVA: 0x000D4E60 File Offset: 0x000D3060
		public FFloatSpringState()
		{
		}

		// Token: 0x06009538 RID: 38200 RVA: 0x000D4E68 File Offset: 0x000D3068
		protected override IntPtr GetUStructPtr()
		{
			return FFloatSpringState.StaticStruct();
		}

		// Token: 0x06009539 RID: 38201 RVA: 0x000D4E74 File Offset: 0x000D3074
		[NullableContext(2)]
		public FFloatSpringState(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600953A RID: 38202 RVA: 0x000D4E7E File Offset: 0x000D307E
		public FFloatSpringState(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600953B RID: 38203 RVA: 0x000D4E89 File Offset: 0x000D3089
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFloatSpringState(Pointer, false, true);
		}

		// Token: 0x0600953C RID: 38204 RVA: 0x000D4E93 File Offset: 0x000D3093
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFloatSpringState(Pointer, MemoryOwner);
		}

		// Token: 0x040053BF RID: 21439
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.FloatSpringState";

		// Token: 0x040053C0 RID: 21440
		private static IntPtr _ScriptStructPtr;
	}
}
