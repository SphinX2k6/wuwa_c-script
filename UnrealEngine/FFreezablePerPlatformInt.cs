using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000BF3 RID: 3059
	[UnrealObjectPath("/Script/Engine.FreezablePerPlatformInt")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FFreezablePerPlatformInt : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060096F2 RID: 38642 RVA: 0x000D7493 File Offset: 0x000D5693
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFreezablePerPlatformInt._ScriptStructPtr != 0) ? FFreezablePerPlatformInt._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.FreezablePerPlatformInt", ref FFreezablePerPlatformInt._ScriptStructPtr);
		}

		// Token: 0x060096F3 RID: 38643 RVA: 0x000D74B7 File Offset: 0x000D56B7
		public FFreezablePerPlatformInt()
		{
		}

		// Token: 0x060096F4 RID: 38644 RVA: 0x000D74BF File Offset: 0x000D56BF
		protected override IntPtr GetUStructPtr()
		{
			return FFreezablePerPlatformInt.StaticStruct();
		}

		// Token: 0x060096F5 RID: 38645 RVA: 0x000D74CB File Offset: 0x000D56CB
		[NullableContext(2)]
		public FFreezablePerPlatformInt(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060096F6 RID: 38646 RVA: 0x000D74D5 File Offset: 0x000D56D5
		public FFreezablePerPlatformInt(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060096F7 RID: 38647 RVA: 0x000D74E0 File Offset: 0x000D56E0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFreezablePerPlatformInt(Pointer, false, true);
		}

		// Token: 0x060096F8 RID: 38648 RVA: 0x000D74EA File Offset: 0x000D56EA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFreezablePerPlatformInt(Pointer, MemoryOwner);
		}

		// Token: 0x040054A6 RID: 21670
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.FreezablePerPlatformInt";

		// Token: 0x040054A7 RID: 21671
		private static IntPtr _ScriptStructPtr;
	}
}
