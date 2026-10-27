using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001273 RID: 4723
	[UnrealObjectPath("/Script/Engine.WorldPartitionRuntimeCellObjectMapping")]
	[UnrealStructLayout(272, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 272)]
	public class FWorldPartitionRuntimeCellObjectMapping : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06011521 RID: 70945 RVA: 0x00196CD2 File Offset: 0x00194ED2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWorldPartitionRuntimeCellObjectMapping._ScriptStructPtr != 0) ? FWorldPartitionRuntimeCellObjectMapping._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.WorldPartitionRuntimeCellObjectMapping", ref FWorldPartitionRuntimeCellObjectMapping._ScriptStructPtr);
		}

		// Token: 0x06011522 RID: 70946 RVA: 0x00196CF6 File Offset: 0x00194EF6
		public FWorldPartitionRuntimeCellObjectMapping()
		{
		}

		// Token: 0x06011523 RID: 70947 RVA: 0x00196CFE File Offset: 0x00194EFE
		[NullableContext(1)]
		public FWorldPartitionRuntimeCellObjectMapping(FName Package, FName Path, FTopLevelAssetPath BaseClass, FTopLevelAssetPath NativeClass, FActorContainerID ContainerID, FTransform ContainerTransform, FTransform EditorOnlyParentTransform, FName ContainerPackage, FName WorldPackage, FGuid ActorInstanceGuid, FName LoadedPath, bool bIsEditorOnly)
		{
		}

		// Token: 0x06011524 RID: 70948 RVA: 0x00196D06 File Offset: 0x00194F06
		protected override IntPtr GetUStructPtr()
		{
			return FWorldPartitionRuntimeCellObjectMapping.StaticStruct();
		}

		// Token: 0x06011525 RID: 70949 RVA: 0x00196D12 File Offset: 0x00194F12
		[NullableContext(2)]
		public FWorldPartitionRuntimeCellObjectMapping(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06011526 RID: 70950 RVA: 0x00196D1C File Offset: 0x00194F1C
		public FWorldPartitionRuntimeCellObjectMapping(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06011527 RID: 70951 RVA: 0x00196D27 File Offset: 0x00194F27
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWorldPartitionRuntimeCellObjectMapping(Pointer, false, true);
		}

		// Token: 0x06011528 RID: 70952 RVA: 0x00196D31 File Offset: 0x00194F31
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWorldPartitionRuntimeCellObjectMapping(Pointer, MemoryOwner);
		}

		// Token: 0x0400944C RID: 37964
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.WorldPartitionRuntimeCellObjectMapping";

		// Token: 0x0400944D RID: 37965
		private static IntPtr _ScriptStructPtr;
	}
}
