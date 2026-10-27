using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001269 RID: 4713
	[UnrealObjectPath("/Script/Engine.WorldPartitionPerWorldSettings")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 176)]
	public class FWorldPartitionPerWorldSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060114A9 RID: 70825 RVA: 0x00196358 File Offset: 0x00194558
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWorldPartitionPerWorldSettings._ScriptStructPtr != 0) ? FWorldPartitionPerWorldSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.WorldPartitionPerWorldSettings", ref FWorldPartitionPerWorldSettings._ScriptStructPtr);
		}

		// Token: 0x060114AA RID: 70826 RVA: 0x0019637C File Offset: 0x0019457C
		public FWorldPartitionPerWorldSettings()
		{
		}

		// Token: 0x060114AB RID: 70827 RVA: 0x00196384 File Offset: 0x00194584
		[NullableContext(1)]
		public FWorldPartitionPerWorldSettings(TArray<FName> LoadedEditorGridCells, TArray<FBox> PinLoadedRegions, TArray<ushort> PinLoadedRegionActorTypes, TArray<ushort> PinLoadedRegionFolderTypes, TArray<int> PinLoadedRegionMaxAxisLengthExceeding, TArray<FName> LoadedEditorLandscapeCells, TArray<FName> CookHLODEditorLandscapeCells, TArray<FName> NotLoadedDataLayers, TArray<FName> LoadedDataLayers, TArray<TSoftObjectPtr<UDataLayerAsset>> NotLoadedDataLayerAssets, TArray<TSoftObjectPtr<UDataLayerAsset>> LoadedDataLayerAssets)
		{
		}

		// Token: 0x060114AC RID: 70828 RVA: 0x0019638C File Offset: 0x0019458C
		protected override IntPtr GetUStructPtr()
		{
			return FWorldPartitionPerWorldSettings.StaticStruct();
		}

		// Token: 0x060114AD RID: 70829 RVA: 0x00196398 File Offset: 0x00194598
		[NullableContext(2)]
		public FWorldPartitionPerWorldSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060114AE RID: 70830 RVA: 0x001963A2 File Offset: 0x001945A2
		public FWorldPartitionPerWorldSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060114AF RID: 70831 RVA: 0x001963AD File Offset: 0x001945AD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWorldPartitionPerWorldSettings(Pointer, false, true);
		}

		// Token: 0x060114B0 RID: 70832 RVA: 0x001963B7 File Offset: 0x001945B7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWorldPartitionPerWorldSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04009413 RID: 37907
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.WorldPartitionPerWorldSettings";

		// Token: 0x04009414 RID: 37908
		private static IntPtr _ScriptStructPtr;
	}
}
