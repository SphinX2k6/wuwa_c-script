using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001FAA RID: 8106
	[UnrealObjectPath("/Script/LevelSequence.BoundActorProxy")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FBoundActorProxy : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EC15 RID: 125973 RVA: 0x002DB8E5 File Offset: 0x002D9AE5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBoundActorProxy._ScriptStructPtr != 0) ? FBoundActorProxy._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LevelSequence.BoundActorProxy", ref FBoundActorProxy._ScriptStructPtr);
		}

		// Token: 0x0601EC16 RID: 125974 RVA: 0x002DB909 File Offset: 0x002D9B09
		public FBoundActorProxy()
		{
		}

		// Token: 0x0601EC17 RID: 125975 RVA: 0x002DB911 File Offset: 0x002D9B11
		[NullableContext(1)]
		public FBoundActorProxy(AActor BoundActor)
		{
		}

		// Token: 0x0601EC18 RID: 125976 RVA: 0x002DB919 File Offset: 0x002D9B19
		protected override IntPtr GetUStructPtr()
		{
			return FBoundActorProxy.StaticStruct();
		}

		// Token: 0x0601EC19 RID: 125977 RVA: 0x002DB925 File Offset: 0x002D9B25
		[NullableContext(2)]
		public FBoundActorProxy(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EC1A RID: 125978 RVA: 0x002DB92F File Offset: 0x002D9B2F
		public FBoundActorProxy(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EC1B RID: 125979 RVA: 0x002DB93A File Offset: 0x002D9B3A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBoundActorProxy(Pointer, false, true);
		}

		// Token: 0x0601EC1C RID: 125980 RVA: 0x002DB944 File Offset: 0x002D9B44
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBoundActorProxy(Pointer, MemoryOwner);
		}

		// Token: 0x04010A0E RID: 68110
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LevelSequence.BoundActorProxy";

		// Token: 0x04010A0F RID: 68111
		private static IntPtr _ScriptStructPtr;
	}
}
