using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001FBF RID: 8127
	[UnrealObjectPath("/Script/LevelSequence.LevelSequenceObjectReferenceMap")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FLevelSequenceObjectReferenceMap : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601ED6E RID: 126318 RVA: 0x002DD3F5 File Offset: 0x002DB5F5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLevelSequenceObjectReferenceMap._ScriptStructPtr != 0) ? FLevelSequenceObjectReferenceMap._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LevelSequence.LevelSequenceObjectReferenceMap", ref FLevelSequenceObjectReferenceMap._ScriptStructPtr);
		}

		// Token: 0x0601ED6F RID: 126319 RVA: 0x002DD419 File Offset: 0x002DB619
		public FLevelSequenceObjectReferenceMap()
		{
		}

		// Token: 0x0601ED70 RID: 126320 RVA: 0x002DD421 File Offset: 0x002DB621
		protected override IntPtr GetUStructPtr()
		{
			return FLevelSequenceObjectReferenceMap.StaticStruct();
		}

		// Token: 0x0601ED71 RID: 126321 RVA: 0x002DD42D File Offset: 0x002DB62D
		[NullableContext(2)]
		public FLevelSequenceObjectReferenceMap(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601ED72 RID: 126322 RVA: 0x002DD437 File Offset: 0x002DB637
		public FLevelSequenceObjectReferenceMap(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601ED73 RID: 126323 RVA: 0x002DD442 File Offset: 0x002DB642
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLevelSequenceObjectReferenceMap(Pointer, false, true);
		}

		// Token: 0x0601ED74 RID: 126324 RVA: 0x002DD44C File Offset: 0x002DB64C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLevelSequenceObjectReferenceMap(Pointer, MemoryOwner);
		}

		// Token: 0x04010AA2 RID: 68258
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LevelSequence.LevelSequenceObjectReferenceMap";

		// Token: 0x04010AA3 RID: 68259
		private static IntPtr _ScriptStructPtr;
	}
}
