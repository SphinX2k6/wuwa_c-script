using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007B3 RID: 1971
	[UnrealObjectPath("/Script/Engine.ActorComponentDuplicatedObjectData")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FActorComponentDuplicatedObjectData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006985 RID: 27013 RVA: 0x00097835 File Offset: 0x00095A35
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FActorComponentDuplicatedObjectData._ScriptStructPtr != 0) ? FActorComponentDuplicatedObjectData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ActorComponentDuplicatedObjectData", ref FActorComponentDuplicatedObjectData._ScriptStructPtr);
		}

		// Token: 0x06006986 RID: 27014 RVA: 0x00097859 File Offset: 0x00095A59
		public FActorComponentDuplicatedObjectData()
		{
		}

		// Token: 0x06006987 RID: 27015 RVA: 0x00097861 File Offset: 0x00095A61
		protected override IntPtr GetUStructPtr()
		{
			return FActorComponentDuplicatedObjectData.StaticStruct();
		}

		// Token: 0x06006988 RID: 27016 RVA: 0x0009786D File Offset: 0x00095A6D
		[NullableContext(2)]
		public FActorComponentDuplicatedObjectData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006989 RID: 27017 RVA: 0x00097877 File Offset: 0x00095A77
		public FActorComponentDuplicatedObjectData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600698A RID: 27018 RVA: 0x00097882 File Offset: 0x00095A82
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FActorComponentDuplicatedObjectData(Pointer, false, true);
		}

		// Token: 0x0600698B RID: 27019 RVA: 0x0009788C File Offset: 0x00095A8C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FActorComponentDuplicatedObjectData(Pointer, MemoryOwner);
		}

		// Token: 0x040032DE RID: 13022
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ActorComponentDuplicatedObjectData";

		// Token: 0x040032DF RID: 13023
		private static IntPtr _ScriptStructPtr;
	}
}
