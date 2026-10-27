using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002814 RID: 10260
	[UnrealObjectPath("/Script/SlateCore.FocusEvent")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FFocusEvent : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602625C RID: 156252 RVA: 0x0039E4D2 File Offset: 0x0039C6D2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFocusEvent._ScriptStructPtr != 0) ? FFocusEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.FocusEvent", ref FFocusEvent._ScriptStructPtr);
		}

		// Token: 0x0602625D RID: 156253 RVA: 0x0039E4F6 File Offset: 0x0039C6F6
		public FFocusEvent()
		{
		}

		// Token: 0x0602625E RID: 156254 RVA: 0x0039E4FE File Offset: 0x0039C6FE
		protected override IntPtr GetUStructPtr()
		{
			return FFocusEvent.StaticStruct();
		}

		// Token: 0x0602625F RID: 156255 RVA: 0x0039E50A File Offset: 0x0039C70A
		[NullableContext(2)]
		public FFocusEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026260 RID: 156256 RVA: 0x0039E514 File Offset: 0x0039C714
		public FFocusEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026261 RID: 156257 RVA: 0x0039E51F File Offset: 0x0039C71F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFocusEvent(Pointer, false, true);
		}

		// Token: 0x06026262 RID: 156258 RVA: 0x0039E529 File Offset: 0x0039C729
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFocusEvent(Pointer, MemoryOwner);
		}

		// Token: 0x04014E1D RID: 85533
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SlateCore.FocusEvent";

		// Token: 0x04014E1E RID: 85534
		private static IntPtr _ScriptStructPtr;
	}
}
