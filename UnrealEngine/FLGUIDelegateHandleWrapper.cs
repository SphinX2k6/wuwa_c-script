using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002035 RID: 8245
	[UnrealObjectPath("/Script/LGUI.LGUIDelegateHandleWrapper")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FLGUIDelegateHandleWrapper : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F311 RID: 127761 RVA: 0x002E4ECA File Offset: 0x002E30CA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUIDelegateHandleWrapper._ScriptStructPtr != 0) ? FLGUIDelegateHandleWrapper._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUIDelegateHandleWrapper", ref FLGUIDelegateHandleWrapper._ScriptStructPtr);
		}

		// Token: 0x0601F312 RID: 127762 RVA: 0x002E4EEE File Offset: 0x002E30EE
		public FLGUIDelegateHandleWrapper()
		{
		}

		// Token: 0x0601F313 RID: 127763 RVA: 0x002E4EF6 File Offset: 0x002E30F6
		protected override IntPtr GetUStructPtr()
		{
			return FLGUIDelegateHandleWrapper.StaticStruct();
		}

		// Token: 0x0601F314 RID: 127764 RVA: 0x002E4F02 File Offset: 0x002E3102
		[NullableContext(2)]
		public FLGUIDelegateHandleWrapper(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F315 RID: 127765 RVA: 0x002E4F0C File Offset: 0x002E310C
		public FLGUIDelegateHandleWrapper(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F316 RID: 127766 RVA: 0x002E4F17 File Offset: 0x002E3117
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUIDelegateHandleWrapper(Pointer, false, true);
		}

		// Token: 0x0601F317 RID: 127767 RVA: 0x002E4F21 File Offset: 0x002E3121
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUIDelegateHandleWrapper(Pointer, MemoryOwner);
		}

		// Token: 0x04010E21 RID: 69153
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDelegateHandleWrapper";

		// Token: 0x04010E22 RID: 69154
		private static IntPtr _ScriptStructPtr;
	}
}
