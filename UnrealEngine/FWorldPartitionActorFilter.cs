using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200124E RID: 4686
	[UnrealObjectPath("/Script/Engine.WorldPartitionActorFilter")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 184)]
	public class FWorldPartitionActorFilter : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060113EA RID: 70634 RVA: 0x00194DFC File Offset: 0x00192FFC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWorldPartitionActorFilter._ScriptStructPtr != 0) ? FWorldPartitionActorFilter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.WorldPartitionActorFilter", ref FWorldPartitionActorFilter._ScriptStructPtr);
		}

		// Token: 0x060113EB RID: 70635 RVA: 0x00194E20 File Offset: 0x00193020
		public FWorldPartitionActorFilter()
		{
		}

		// Token: 0x060113EC RID: 70636 RVA: 0x00194E28 File Offset: 0x00193028
		protected override IntPtr GetUStructPtr()
		{
			return FWorldPartitionActorFilter.StaticStruct();
		}

		// Token: 0x060113ED RID: 70637 RVA: 0x00194E34 File Offset: 0x00193034
		[NullableContext(2)]
		public FWorldPartitionActorFilter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060113EE RID: 70638 RVA: 0x00194E3E File Offset: 0x0019303E
		public FWorldPartitionActorFilter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060113EF RID: 70639 RVA: 0x00194E49 File Offset: 0x00193049
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWorldPartitionActorFilter(Pointer, false, true);
		}

		// Token: 0x060113F0 RID: 70640 RVA: 0x00194E53 File Offset: 0x00193053
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWorldPartitionActorFilter(Pointer, MemoryOwner);
		}

		// Token: 0x04009397 RID: 37783
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.WorldPartitionActorFilter";

		// Token: 0x04009398 RID: 37784
		private static IntPtr _ScriptStructPtr;
	}
}
