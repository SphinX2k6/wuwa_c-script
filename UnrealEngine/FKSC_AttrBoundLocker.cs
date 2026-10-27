using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001CFA RID: 7418
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_AttrBoundLocker")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FKSC_AttrBoundLocker : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601C8A6 RID: 116902 RVA: 0x002A3243 File Offset: 0x002A1443
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_AttrBoundLocker._ScriptStructPtr != 0) ? FKSC_AttrBoundLocker._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSC_AttrBoundLocker", ref FKSC_AttrBoundLocker._ScriptStructPtr);
		}

		// Token: 0x0601C8A7 RID: 116903 RVA: 0x002A3267 File Offset: 0x002A1467
		public FKSC_AttrBoundLocker()
		{
		}

		// Token: 0x0601C8A8 RID: 116904 RVA: 0x002A326F File Offset: 0x002A146F
		protected override IntPtr GetUStructPtr()
		{
			return FKSC_AttrBoundLocker.StaticStruct();
		}

		// Token: 0x0601C8A9 RID: 116905 RVA: 0x002A327B File Offset: 0x002A147B
		[NullableContext(2)]
		public FKSC_AttrBoundLocker(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C8AA RID: 116906 RVA: 0x002A3285 File Offset: 0x002A1485
		public FKSC_AttrBoundLocker(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C8AB RID: 116907 RVA: 0x002A3290 File Offset: 0x002A1490
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSC_AttrBoundLocker(Pointer, false, true);
		}

		// Token: 0x0601C8AC RID: 116908 RVA: 0x002A329A File Offset: 0x002A149A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSC_AttrBoundLocker(Pointer, MemoryOwner);
		}

		// Token: 0x0400F790 RID: 63376
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_AttrBoundLocker";

		// Token: 0x0400F791 RID: 63377
		private static IntPtr _ScriptStructPtr;
	}
}
