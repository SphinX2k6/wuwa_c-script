using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000929 RID: 2345
	[UnrealObjectPath("/Script/Engine.CharacterMoveResponsePackedBits")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 152)]
	public class FCharacterMoveResponsePackedBits : FCharacterNetworkSerializationPackedBits, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008440 RID: 33856 RVA: 0x000BD0BA File Offset: 0x000BB2BA
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCharacterMoveResponsePackedBits._ScriptStructPtr != 0) ? FCharacterMoveResponsePackedBits._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CharacterMoveResponsePackedBits", ref FCharacterMoveResponsePackedBits._ScriptStructPtr);
		}

		// Token: 0x06008441 RID: 33857 RVA: 0x000BD0DE File Offset: 0x000BB2DE
		public FCharacterMoveResponsePackedBits()
		{
		}

		// Token: 0x06008442 RID: 33858 RVA: 0x000BD0E6 File Offset: 0x000BB2E6
		protected override IntPtr GetUStructPtr()
		{
			return FCharacterMoveResponsePackedBits.StaticStruct();
		}

		// Token: 0x06008443 RID: 33859 RVA: 0x000BD0F2 File Offset: 0x000BB2F2
		[NullableContext(2)]
		public FCharacterMoveResponsePackedBits(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008444 RID: 33860 RVA: 0x000BD0FC File Offset: 0x000BB2FC
		public FCharacterMoveResponsePackedBits(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008445 RID: 33861 RVA: 0x000BD107 File Offset: 0x000BB307
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCharacterMoveResponsePackedBits(Pointer, false, true);
		}

		// Token: 0x06008446 RID: 33862 RVA: 0x000BD111 File Offset: 0x000BB311
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCharacterMoveResponsePackedBits(Pointer, MemoryOwner);
		}

		// Token: 0x04003F2B RID: 16171
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.CharacterMoveResponsePackedBits";

		// Token: 0x04003F2C RID: 16172
		private static IntPtr _ScriptStructPtr;
	}
}
