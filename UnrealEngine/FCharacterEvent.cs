using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020027ED RID: 10221
	[UnrealObjectPath("/Script/SlateCore.CharacterEvent")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FCharacterEvent : FInputEvent, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026185 RID: 156037 RVA: 0x0039C870 File Offset: 0x0039AA70
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCharacterEvent._ScriptStructPtr != 0) ? FCharacterEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.CharacterEvent", ref FCharacterEvent._ScriptStructPtr);
		}

		// Token: 0x06026186 RID: 156038 RVA: 0x0039C894 File Offset: 0x0039AA94
		public FCharacterEvent()
		{
		}

		// Token: 0x06026187 RID: 156039 RVA: 0x0039C89C File Offset: 0x0039AA9C
		protected override IntPtr GetUStructPtr()
		{
			return FCharacterEvent.StaticStruct();
		}

		// Token: 0x06026188 RID: 156040 RVA: 0x0039C8A8 File Offset: 0x0039AAA8
		[NullableContext(2)]
		public FCharacterEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026189 RID: 156041 RVA: 0x0039C8B2 File Offset: 0x0039AAB2
		public FCharacterEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602618A RID: 156042 RVA: 0x0039C8BD File Offset: 0x0039AABD
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCharacterEvent(Pointer, false, true);
		}

		// Token: 0x0602618B RID: 156043 RVA: 0x0039C8C7 File Offset: 0x0039AAC7
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCharacterEvent(Pointer, MemoryOwner);
		}

		// Token: 0x04014CE8 RID: 85224
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SlateCore.CharacterEvent";

		// Token: 0x04014CE9 RID: 85225
		private static IntPtr _ScriptStructPtr;
	}
}
