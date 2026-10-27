using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020019AF RID: 6575
	[UnrealObjectPath("/Script/KuroLevelStateMachine.KuroLevelPlaySequenceBoundActorProxy")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKuroLevelPlaySequenceBoundActorProxy : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06018769 RID: 100201 RVA: 0x00240CA2 File Offset: 0x0023EEA2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroLevelPlaySequenceBoundActorProxy._ScriptStructPtr != 0) ? FKuroLevelPlaySequenceBoundActorProxy._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroLevelStateMachine.KuroLevelPlaySequenceBoundActorProxy", ref FKuroLevelPlaySequenceBoundActorProxy._ScriptStructPtr);
		}

		// Token: 0x0601876A RID: 100202 RVA: 0x00240CC6 File Offset: 0x0023EEC6
		public FKuroLevelPlaySequenceBoundActorProxy()
		{
		}

		// Token: 0x0601876B RID: 100203 RVA: 0x00240CCE File Offset: 0x0023EECE
		[NullableContext(1)]
		public FKuroLevelPlaySequenceBoundActorProxy(AActor BoundActor)
		{
		}

		// Token: 0x0601876C RID: 100204 RVA: 0x00240CD6 File Offset: 0x0023EED6
		protected override IntPtr GetUStructPtr()
		{
			return FKuroLevelPlaySequenceBoundActorProxy.StaticStruct();
		}

		// Token: 0x0601876D RID: 100205 RVA: 0x00240CE2 File Offset: 0x0023EEE2
		[NullableContext(2)]
		public FKuroLevelPlaySequenceBoundActorProxy(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601876E RID: 100206 RVA: 0x00240CEC File Offset: 0x0023EEEC
		public FKuroLevelPlaySequenceBoundActorProxy(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601876F RID: 100207 RVA: 0x00240CF7 File Offset: 0x0023EEF7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroLevelPlaySequenceBoundActorProxy(Pointer, false, true);
		}

		// Token: 0x06018770 RID: 100208 RVA: 0x00240D01 File Offset: 0x0023EF01
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroLevelPlaySequenceBoundActorProxy(Pointer, MemoryOwner);
		}

		// Token: 0x0400D375 RID: 54133
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroLevelStateMachine.KuroLevelPlaySequenceBoundActorProxy";

		// Token: 0x0400D376 RID: 54134
		private static IntPtr _ScriptStructPtr;
	}
}
