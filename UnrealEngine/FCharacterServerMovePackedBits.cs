using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200092C RID: 2348
	[UnrealObjectPath("/Script/Engine.CharacterServerMovePackedBits")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 152)]
	public class FCharacterServerMovePackedBits : FCharacterNetworkSerializationPackedBits, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008458 RID: 33880 RVA: 0x000BD28A File Offset: 0x000BB48A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCharacterServerMovePackedBits._ScriptStructPtr != 0) ? FCharacterServerMovePackedBits._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CharacterServerMovePackedBits", ref FCharacterServerMovePackedBits._ScriptStructPtr);
		}

		// Token: 0x06008459 RID: 33881 RVA: 0x000BD2AE File Offset: 0x000BB4AE
		public FCharacterServerMovePackedBits()
		{
		}

		// Token: 0x0600845A RID: 33882 RVA: 0x000BD2B6 File Offset: 0x000BB4B6
		protected override IntPtr GetUStructPtr()
		{
			return FCharacterServerMovePackedBits.StaticStruct();
		}

		// Token: 0x0600845B RID: 33883 RVA: 0x000BD2C2 File Offset: 0x000BB4C2
		[NullableContext(2)]
		public FCharacterServerMovePackedBits(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600845C RID: 33884 RVA: 0x000BD2CC File Offset: 0x000BB4CC
		public FCharacterServerMovePackedBits(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600845D RID: 33885 RVA: 0x000BD2D7 File Offset: 0x000BB4D7
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCharacterServerMovePackedBits(Pointer, false, true);
		}

		// Token: 0x0600845E RID: 33886 RVA: 0x000BD2E1 File Offset: 0x000BB4E1
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCharacterServerMovePackedBits(Pointer, MemoryOwner);
		}

		// Token: 0x04003F32 RID: 16178
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.CharacterServerMovePackedBits";

		// Token: 0x04003F33 RID: 16179
		private static IntPtr _ScriptStructPtr;
	}
}
