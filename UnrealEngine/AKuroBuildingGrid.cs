using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200031D RID: 797
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBuildingGridSystem.KuroBuildingGrid")]
	[UnrealStructLayout(1456, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1456)]
	public class AKuroBuildingGrid : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600540A RID: 21514 RVA: 0x00075906 File Offset: 0x00073B06
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroBuildingGrid._ClassPtr;
		}

		// Token: 0x0600540B RID: 21515 RVA: 0x00075914 File Offset: 0x00073B14
		public AKuroBuildingGrid() : this(BuiltinUtils.AllocNativeUObject(AKuroBuildingGrid.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600540C RID: 21516 RVA: 0x0007593C File Offset: 0x00073B3C
		public AKuroBuildingGrid(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroBuildingGrid.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700109A RID: 4250
		// (get) Token: 0x0600540D RID: 21517 RVA: 0x0007596F File Offset: 0x00073B6F
		// (set) Token: 0x0600540E RID: 21518 RVA: 0x00075983 File Offset: 0x00073B83
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

		// Token: 0x1700109B RID: 4251
		// (get) Token: 0x0600540F RID: 21519 RVA: 0x00075998 File Offset: 0x00073B98
		// (set) Token: 0x06005410 RID: 21520 RVA: 0x000759AC File Offset: 0x00073BAC
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

		// Token: 0x1700109C RID: 4252
		// (get) Token: 0x06005411 RID: 21521 RVA: 0x000759C4 File Offset: 0x00073BC4
		// (set) Token: 0x06005412 RID: 21522 RVA: 0x000759FD File Offset: 0x00073BFD
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

		// Token: 0x1700109D RID: 4253
		// (get) Token: 0x06005413 RID: 21523 RVA: 0x00075A0B File Offset: 0x00073C0B
		// (set) Token: 0x06005414 RID: 21524 RVA: 0x00075A1F File Offset: 0x00073C1F
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

		// Token: 0x06005415 RID: 21525 RVA: 0x00075A34 File Offset: 0x00073C34
		[NullableContext(2)]
		public bool UnoccupyTarget(UObject InTarget)
		{
			return AKuroBuildingGrid.__UnoccupyTarget_Internal(base.NativePtr, (InTarget != null) ? InTarget.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06005416 RID: 21526 RVA: 0x00075A54 File Offset: 0x00073C54
		[NullableContext(2)]
		public unsafe bool OccupyTarget(in FKuroBuildingGridCellVector InCoords, UObject InTarget, in float DegreeAlongNormal)
		{
			fixed (float* ptr = &DegreeAlongNormal)
			{
				void* ptr2 = (void*)ptr;
				return AKuroBuildingGrid.__OccupyTarget_Internal(base.NativePtr, InCoords, (InTarget != null) ? InTarget.NativePtr : IntPtr.Zero, DegreeAlongNormal);
			}
		}

		// Token: 0x06005417 RID: 21527 RVA: 0x00075A83 File Offset: 0x00073C83
		public FVectorDouble GetPosition(in FKuroBuildingGridCellVector InSize, in FKuroBuildingGridCellVector InCoords)
		{
			return AKuroBuildingGrid.__GetPosition_Internal(base.NativePtr, InSize, InCoords);
		}

		// Token: 0x06005418 RID: 21528 RVA: 0x00075A94 File Offset: 0x00073C94
		public unsafe bool GetCellIndex(in FKuroBuildingGridCellVector InCoords, ref int OutIndex)
		{
			fixed (int* ptr = &OutIndex)
			{
				void* ptr2 = (void*)ptr;
				return AKuroBuildingGrid.__GetCellIndex_Internal(base.NativePtr, InCoords, ref OutIndex);
			}
		}

		// Token: 0x06005419 RID: 21529 RVA: 0x00075AB3 File Offset: 0x00073CB3
		public string GetBuildingGridGuidString()
		{
			return FString.ToStringAndDeleteNativePtr(AKuroBuildingGrid.__GetBuildingGridGuidString_Internal(base.NativePtr));
		}

		// Token: 0x0600541A RID: 21530
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __UnoccupyTarget_Internal(IntPtr @this, IntPtr InTarget);

		// Token: 0x0600541B RID: 21531
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __OccupyTarget_Internal(IntPtr @this, in FKuroBuildingGridCellVector InCoords, IntPtr InTarget, in float DegreeAlongNormal);

		// Token: 0x0600541C RID: 21532
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __GetPosition_Internal(IntPtr @this, in FKuroBuildingGridCellVector InSize, in FKuroBuildingGridCellVector InCoords);

		// Token: 0x0600541D RID: 21533
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetCellIndex_Internal(IntPtr @this, in FKuroBuildingGridCellVector InCoords, ref int OutIndex);

		// Token: 0x0600541E RID: 21534
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetBuildingGridGuidString_Internal(IntPtr @this);

		// Token: 0x0600541F RID: 21535 RVA: 0x00075AC5 File Offset: 0x00073CC5
		static AKuroBuildingGrid()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBuildingGridSystem.KuroBuildingGrid");
		}

		// Token: 0x06005420 RID: 21536 RVA: 0x00075AD3 File Offset: 0x00073CD3
		protected AKuroBuildingGrid(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002253 RID: 8787
		public new const string __ObjectPath = "/Script/KuroBuildingGridSystem.KuroBuildingGrid";

		// Token: 0x04002254 RID: 8788
		private static IntPtr _ClassPtr;

		// Token: 0x04002255 RID: 8789
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002256 RID: 8790
		internal static int __PropertyOffset_RenderingComp;

		// Token: 0x04002257 RID: 8791
		internal static int __PropertyOffset_GridSize;

		// Token: 0x04002258 RID: 8792
		internal static int __PropertyOffset_BlockCoords;

		// Token: 0x04002259 RID: 8793
		[Nullable(2)]
		private TArray<FKuroBuildingGridCellVector> _BlockCoords;

		// Token: 0x0400225A RID: 8794
		internal static int __PropertyOffset_BuildingGridSpawnGuid;
	}
}
