using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001FBB RID: 8123
	[UnrealObjectPath("/Script/LevelSequence.LevelSequenceLegacyObjectReference")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FLevelSequenceLegacyObjectReference : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601ED42 RID: 126274 RVA: 0x002DD158 File Offset: 0x002DB358
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLevelSequenceLegacyObjectReference._ScriptStructPtr != 0) ? FLevelSequenceLegacyObjectReference._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LevelSequence.LevelSequenceLegacyObjectReference", ref FLevelSequenceLegacyObjectReference._ScriptStructPtr);
		}

		// Token: 0x0601ED43 RID: 126275 RVA: 0x002DD17C File Offset: 0x002DB37C
		public FLevelSequenceLegacyObjectReference()
		{
		}

		// Token: 0x0601ED44 RID: 126276 RVA: 0x002DD184 File Offset: 0x002DB384
		protected override IntPtr GetUStructPtr()
		{
			return FLevelSequenceLegacyObjectReference.StaticStruct();
		}

		// Token: 0x0601ED45 RID: 126277 RVA: 0x002DD190 File Offset: 0x002DB390
		[NullableContext(2)]
		public FLevelSequenceLegacyObjectReference(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601ED46 RID: 126278 RVA: 0x002DD19A File Offset: 0x002DB39A
		public FLevelSequenceLegacyObjectReference(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601ED47 RID: 126279 RVA: 0x002DD1A5 File Offset: 0x002DB3A5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLevelSequenceLegacyObjectReference(Pointer, false, true);
		}

		// Token: 0x0601ED48 RID: 126280 RVA: 0x002DD1AF File Offset: 0x002DB3AF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLevelSequenceLegacyObjectReference(Pointer, MemoryOwner);
		}

		// Token: 0x04010A93 RID: 68243
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LevelSequence.LevelSequenceLegacyObjectReference";

		// Token: 0x04010A94 RID: 68244
		private static IntPtr _ScriptStructPtr;
	}
}
