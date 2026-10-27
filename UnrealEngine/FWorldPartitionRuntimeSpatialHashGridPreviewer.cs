using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001280 RID: 4736
	[UnrealObjectPath("/Script/Engine.WorldPartitionRuntimeSpatialHashGridPreviewer")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 168)]
	public class FWorldPartitionRuntimeSpatialHashGridPreviewer : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601159B RID: 71067 RVA: 0x001977A7 File Offset: 0x001959A7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWorldPartitionRuntimeSpatialHashGridPreviewer._ScriptStructPtr != 0) ? FWorldPartitionRuntimeSpatialHashGridPreviewer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.WorldPartitionRuntimeSpatialHashGridPreviewer", ref FWorldPartitionRuntimeSpatialHashGridPreviewer._ScriptStructPtr);
		}

		// Token: 0x0601159C RID: 71068 RVA: 0x001977CB File Offset: 0x001959CB
		public FWorldPartitionRuntimeSpatialHashGridPreviewer()
		{
		}

		// Token: 0x0601159D RID: 71069 RVA: 0x001977D3 File Offset: 0x001959D3
		[NullableContext(1)]
		public FWorldPartitionRuntimeSpatialHashGridPreviewer(UMaterial Material, UMaterialInstanceDynamic MID, APostProcessVolume Volume)
		{
		}

		// Token: 0x0601159E RID: 71070 RVA: 0x001977DB File Offset: 0x001959DB
		protected override IntPtr GetUStructPtr()
		{
			return FWorldPartitionRuntimeSpatialHashGridPreviewer.StaticStruct();
		}

		// Token: 0x0601159F RID: 71071 RVA: 0x001977E7 File Offset: 0x001959E7
		[NullableContext(2)]
		public FWorldPartitionRuntimeSpatialHashGridPreviewer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060115A0 RID: 71072 RVA: 0x001977F1 File Offset: 0x001959F1
		public FWorldPartitionRuntimeSpatialHashGridPreviewer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060115A1 RID: 71073 RVA: 0x001977FC File Offset: 0x001959FC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWorldPartitionRuntimeSpatialHashGridPreviewer(Pointer, false, true);
		}

		// Token: 0x060115A2 RID: 71074 RVA: 0x00197806 File Offset: 0x00195A06
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWorldPartitionRuntimeSpatialHashGridPreviewer(Pointer, MemoryOwner);
		}

		// Token: 0x0400948D RID: 38029
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.WorldPartitionRuntimeSpatialHashGridPreviewer";

		// Token: 0x0400948E RID: 38030
		private static IntPtr _ScriptStructPtr;
	}
}
