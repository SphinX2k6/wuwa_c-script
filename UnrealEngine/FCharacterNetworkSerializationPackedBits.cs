using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200092A RID: 2346
	[UnrealObjectPath("/Script/Engine.CharacterNetworkSerializationPackedBits")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 152)]
	public class FCharacterNetworkSerializationPackedBits : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008447 RID: 33863 RVA: 0x000BD11A File Offset: 0x000BB31A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCharacterNetworkSerializationPackedBits._ScriptStructPtr != 0) ? FCharacterNetworkSerializationPackedBits._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CharacterNetworkSerializationPackedBits", ref FCharacterNetworkSerializationPackedBits._ScriptStructPtr);
		}

		// Token: 0x06008448 RID: 33864 RVA: 0x000BD13E File Offset: 0x000BB33E
		public FCharacterNetworkSerializationPackedBits()
		{
		}

		// Token: 0x06008449 RID: 33865 RVA: 0x000BD146 File Offset: 0x000BB346
		protected override IntPtr GetUStructPtr()
		{
			return FCharacterNetworkSerializationPackedBits.StaticStruct();
		}

		// Token: 0x0600844A RID: 33866 RVA: 0x000BD152 File Offset: 0x000BB352
		[NullableContext(2)]
		public FCharacterNetworkSerializationPackedBits(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600844B RID: 33867 RVA: 0x000BD15C File Offset: 0x000BB35C
		public FCharacterNetworkSerializationPackedBits(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600844C RID: 33868 RVA: 0x000BD167 File Offset: 0x000BB367
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCharacterNetworkSerializationPackedBits(Pointer, false, true);
		}

		// Token: 0x0600844D RID: 33869 RVA: 0x000BD171 File Offset: 0x000BB371
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCharacterNetworkSerializationPackedBits(Pointer, MemoryOwner);
		}

		// Token: 0x04003F2D RID: 16173
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.CharacterNetworkSerializationPackedBits";

		// Token: 0x04003F2E RID: 16174
		private static IntPtr _ScriptStructPtr;
	}
}
