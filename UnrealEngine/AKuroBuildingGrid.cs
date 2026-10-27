using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016B1 RID: 5809
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBuildingGridSystem.KuroBuildingGrid")]
	[UnrealStructLayout(1456, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1456)]
	public class AKuroBuildingGrid : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015112 RID: 86290 RVA: 0x001EF5F7 File Offset: 0x001ED7F7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroBuildingGrid._ClassPtr;
		}

		// Token: 0x06015113 RID: 86291 RVA: 0x001EF604 File Offset: 0x001ED804
		public AKuroBuildingGrid() : this(BuiltinUtils.AllocNativeUObject(AKuroBuildingGrid.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015114 RID: 86292 RVA: 0x001EF62C File Offset: 0x001ED82C
		public AKuroBuildingGrid(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroBuildingGrid.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005360 RID: 21344
		// (get) Token: 0x06015115 RID: 86293 RVA: 0x001EF65F File Offset: 0x001ED85F
		// (set) Token: 0x06015116 RID: 86294 RVA: 0x001EF673 File Offset: 0x001ED873
		[Nullable(2)]
		public unsafe UPrimitiveComponent RenderingComp
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroBuildingGrid.__PropertyOffset_RenderingComp);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroBuildingGrid.__PropertyOffset_RenderingComp, value);
			}
		}

		// Token: 0x17005361 RID: 21345
		// (get) Token: 0x06015117 RID: 86295 RVA: 0x001EF688 File Offset: 0x001ED888
		// (set) Token: 0x06015118 RID: 86296 RVA: 0x001EF69C File Offset: 0x001ED89C
		public unsafe FKuroBuildingGridCellVector GridSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBuildingGrid.__PropertyOffset_GridSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBuildingGrid.__PropertyOffset_GridSize) = value;
			}
		}

		// Token: 0x17005362 RID: 21346
		// (get) Token: 0x06015119 RID: 86297 RVA: 0x001EF6B4 File Offset: 0x001ED8B4
		// (set) Token: 0x0601511A RID: 86298 RVA: 0x001EF6ED File Offset: 0x001ED8ED
		public TArray<FKuroBuildingGridCellVector> BlockCoords
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroBuildingGridCellVector> result;
				if ((result = this._BlockCoords) == null)
				{
					result = (this._BlockCoords = new TArray<FKuroBuildingGridCellVector>(base.NativePtr + (IntPtr)AKuroBuildingGrid.__PropertyOffset_BlockCoords, this));
				}
				return result;
			}
			set
			{
				this.BlockCoords.CopyAssign(value);
			}
		}

		// Token: 0x17005363 RID: 21347
		// (get) Token: 0x0601511B RID: 86299 RVA: 0x001EF6FB File Offset: 0x001ED8FB
		// (set) Token: 0x0601511C RID: 86300 RVA: 0x001EF70F File Offset: 0x001ED90F
		public unsafe FGuid BuildingGridSpawnGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroBuildingGrid.__PropertyOffset_BuildingGridSpawnGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroBuildingGrid.__PropertyOffset_BuildingGridSpawnGuid) = value;
			}
		}

		// Token: 0x0601511D RID: 86301 RVA: 0x001EF724 File Offset: 0x001ED924
		[NullableContext(2)]
		public bool UnoccupyTarget(UObject InTarget)
		{
			return AKuroBuildingGrid.__UnoccupyTarget_Internal(base.NativePtr, (InTarget != null) ? InTarget.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601511E RID: 86302 RVA: 0x001EF744 File Offset: 0x001ED944
		[NullableContext(2)]
		public unsafe bool OccupyTarget(in FKuroBuildingGridCellVector InCoords, UObject InTarget, in float DegreeAlongNormal)
		{
			fixed (float* ptr = &DegreeAlongNormal)
			{
				void* ptr2 = (void*)ptr;
				return AKuroBuildingGrid.__OccupyTarget_Internal(base.NativePtr, InCoords, (InTarget != null) ? InTarget.NativePtr : IntPtr.Zero, DegreeAlongNormal);
			}
		}

		// Token: 0x0601511F RID: 86303 RVA: 0x001EF773 File Offset: 0x001ED973
		public FVectorDouble GetPosition(in FKuroBuildingGridCellVector InSize, in FKuroBuildingGridCellVector InCoords)
		{
			return AKuroBuildingGrid.__GetPosition_Internal(base.NativePtr, InSize, InCoords);
		}

		// Token: 0x06015120 RID: 86304 RVA: 0x001EF784 File Offset: 0x001ED984
		public unsafe bool GetCellIndex(in FKuroBuildingGridCellVector InCoords, ref int OutIndex)
		{
			fixed (int* ptr = &OutIndex)
			{
				void* ptr2 = (void*)ptr;
				return AKuroBuildingGrid.__GetCellIndex_Internal(base.NativePtr, InCoords, ref OutIndex);
			}
		}

		// Token: 0x06015121 RID: 86305 RVA: 0x001EF7A3 File Offset: 0x001ED9A3
		public string GetBuildingGridGuidString()
		{
			return FString.ToStringAndDeleteNativePtr(AKuroBuildingGrid.__GetBuildingGridGuidString_Internal(base.NativePtr));
		}

		// Token: 0x06015122 RID: 86306
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __UnoccupyTarget_Internal(IntPtr @this, IntPtr InTarget);

		// Token: 0x06015123 RID: 86307
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __OccupyTarget_Internal(IntPtr @this, in FKuroBuildingGridCellVector InCoords, IntPtr InTarget, in float DegreeAlongNormal);

		// Token: 0x06015124 RID: 86308
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __GetPosition_Internal(IntPtr @this, in FKuroBuildingGridCellVector InSize, in FKuroBuildingGridCellVector InCoords);

		// Token: 0x06015125 RID: 86309
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetCellIndex_Internal(IntPtr @this, in FKuroBuildingGridCellVector InCoords, ref int OutIndex);

		// Token: 0x06015126 RID: 86310
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetBuildingGridGuidString_Internal(IntPtr @this);

		// Token: 0x06015127 RID: 86311 RVA: 0x001EF7B5 File Offset: 0x001ED9B5
		static AKuroBuildingGrid()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBuildingGridSystem.KuroBuildingGrid");
		}

		// Token: 0x06015128 RID: 86312 RVA: 0x001EF7C3 File Offset: 0x001ED9C3
		protected AKuroBuildingGrid(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B777 RID: 46967
		public new const string __ObjectPath = "/Script/KuroBuildingGridSystem.KuroBuildingGrid";

		// Token: 0x0400B778 RID: 46968
		private static IntPtr _ClassPtr;

		// Token: 0x0400B779 RID: 46969
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B77A RID: 46970
		internal static int __PropertyOffset_RenderingComp;

		// Token: 0x0400B77B RID: 46971
		internal static int __PropertyOffset_GridSize;

		// Token: 0x0400B77C RID: 46972
		internal static int __PropertyOffset_BlockCoords;

		// Token: 0x0400B77D RID: 46973
		[Nullable(2)]
		private TArray<FKuroBuildingGridCellVector> _BlockCoords;

		// Token: 0x0400B77E RID: 46974
		internal static int __PropertyOffset_BuildingGridSpawnGuid;
	}
}
