using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001166 RID: 4454
	[UnrealObjectPath("/Script/Engine.SpatialHashRuntimeGrid")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FSpatialHashRuntimeGrid : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601045F RID: 66655 RVA: 0x0017F99F File Offset: 0x0017DB9F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSpatialHashRuntimeGrid._ScriptStructPtr != 0) ? FSpatialHashRuntimeGrid._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SpatialHashRuntimeGrid", ref FSpatialHashRuntimeGrid._ScriptStructPtr);
		}

		// Token: 0x06010460 RID: 66656 RVA: 0x0017F9C3 File Offset: 0x0017DBC3
		public FSpatialHashRuntimeGrid()
		{
		}

		// Token: 0x06010461 RID: 66657 RVA: 0x0017F9CB File Offset: 0x0017DBCB
		[NullableContext(1)]
		public FSpatialHashRuntimeGrid(FName GridName, int CellSize, float LoadingRange, bool bBlockOnSlowStreaming, FVector2D Origin, int Priority, UHLODLayer HLODLayer, FLinearColor DebugColor, bool bClientOnlyVisible, float PcLoadingRangeScalar, float MobileLoadingRangeScalar, float PCLoadingRange, float UnLoadingRangeAdditional, bool bIncludeHLODVolume, bool bCustomHLOD, bool bIsHLODGrid, FSpatialHashSettings GridSettings, bool bIsLandscpe, bool bIsHLODGridVolume, bool bIsHLODStreamingGrid, bool bEnCloseSpaceAlreayOverride, bool bRangeStreaming, float StreamingOutStart, bool bUseZAxis, float ZLoadingRangeCofficient, bool bRegionLoadRangeAdjust, bool bSkipQualityLevel, bool bUseExtralSteamingDistance, FVector ExtraStreamingDistances, bool bInCludeBounds)
		{
		}

		// Token: 0x06010462 RID: 66658 RVA: 0x0017F9D3 File Offset: 0x0017DBD3
		protected override IntPtr GetUStructPtr()
		{
			return FSpatialHashRuntimeGrid.StaticStruct();
		}

		// Token: 0x06010463 RID: 66659 RVA: 0x0017F9DF File Offset: 0x0017DBDF
		[NullableContext(2)]
		public FSpatialHashRuntimeGrid(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010464 RID: 66660 RVA: 0x0017F9E9 File Offset: 0x0017DBE9
		public FSpatialHashRuntimeGrid(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010465 RID: 66661 RVA: 0x0017F9F4 File Offset: 0x0017DBF4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSpatialHashRuntimeGrid(Pointer, false, true);
		}

		// Token: 0x06010466 RID: 66662 RVA: 0x0017F9FE File Offset: 0x0017DBFE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSpatialHashRuntimeGrid(Pointer, MemoryOwner);
		}

		// Token: 0x04008C11 RID: 35857
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.SpatialHashRuntimeGrid";

		// Token: 0x04008C12 RID: 35858
		private static IntPtr _ScriptStructPtr;
	}
}
