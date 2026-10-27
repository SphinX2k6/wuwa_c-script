using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012D7 RID: 4823
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Foliage.ProceduralFoliageSpawner")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UProceduralFoliageSpawner : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011B0C RID: 72460 RVA: 0x0019F97D File Offset: 0x0019DB7D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UProceduralFoliageSpawner._ClassPtr;
		}

		// Token: 0x06011B0D RID: 72461 RVA: 0x0019F98C File Offset: 0x0019DB8C
		public UProceduralFoliageSpawner() : this(BuiltinUtils.AllocNativeUObject(UProceduralFoliageSpawner.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011B0E RID: 72462 RVA: 0x0019F9B4 File Offset: 0x0019DBB4
		public UProceduralFoliageSpawner(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UProceduralFoliageSpawner.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700453D RID: 17725
		// (get) Token: 0x06011B0F RID: 72463 RVA: 0x0019F9E7 File Offset: 0x0019DBE7
		// (set) Token: 0x06011B10 RID: 72464 RVA: 0x0019F9F7 File Offset: 0x0019DBF7
		public unsafe int RandomSeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UProceduralFoliageSpawner.__PropertyOffset_RandomSeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UProceduralFoliageSpawner.__PropertyOffset_RandomSeed) = value;
			}
		}

		// Token: 0x1700453E RID: 17726
		// (get) Token: 0x06011B11 RID: 72465 RVA: 0x0019FA08 File Offset: 0x0019DC08
		// (set) Token: 0x06011B12 RID: 72466 RVA: 0x0019FA18 File Offset: 0x0019DC18
		public unsafe float TileSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UProceduralFoliageSpawner.__PropertyOffset_TileSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UProceduralFoliageSpawner.__PropertyOffset_TileSize) = value;
			}
		}

		// Token: 0x1700453F RID: 17727
		// (get) Token: 0x06011B13 RID: 72467 RVA: 0x0019FA29 File Offset: 0x0019DC29
		// (set) Token: 0x06011B14 RID: 72468 RVA: 0x0019FA39 File Offset: 0x0019DC39
		public unsafe int NumUniqueTiles
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UProceduralFoliageSpawner.__PropertyOffset_NumUniqueTiles);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UProceduralFoliageSpawner.__PropertyOffset_NumUniqueTiles) = value;
			}
		}

		// Token: 0x17004540 RID: 17728
		// (get) Token: 0x06011B15 RID: 72469 RVA: 0x0019FA4A File Offset: 0x0019DC4A
		// (set) Token: 0x06011B16 RID: 72470 RVA: 0x0019FA5A File Offset: 0x0019DC5A
		public unsafe float MinimumQuadTreeSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UProceduralFoliageSpawner.__PropertyOffset_MinimumQuadTreeSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UProceduralFoliageSpawner.__PropertyOffset_MinimumQuadTreeSize) = value;
			}
		}

		// Token: 0x17004541 RID: 17729
		// (get) Token: 0x06011B17 RID: 72471 RVA: 0x0019FA6C File Offset: 0x0019DC6C
		// (set) Token: 0x06011B18 RID: 72472 RVA: 0x0019FAA5 File Offset: 0x0019DCA5
		public TArray<FFoliageTypeObject> FoliageTypes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FFoliageTypeObject> result;
				if ((result = this._FoliageTypes) == null)
				{
					result = (this._FoliageTypes = new TArray<FFoliageTypeObject>(base.NativePtr + (IntPtr)UProceduralFoliageSpawner.__PropertyOffset_FoliageTypes, this));
				}
				return result;
			}
			set
			{
				this.FoliageTypes.CopyAssign(value);
			}
		}

		// Token: 0x06011B19 RID: 72473 RVA: 0x0019FAB3 File Offset: 0x0019DCB3
		public void Simulate(int NumSteps = -1)
		{
			UProceduralFoliageSpawner.__Simulate_Internal(base.NativePtr, NumSteps);
		}

		// Token: 0x06011B1A RID: 72474
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Simulate_Internal(IntPtr @this, int NumSteps);

		// Token: 0x06011B1B RID: 72475 RVA: 0x0019FAC1 File Offset: 0x0019DCC1
		static UProceduralFoliageSpawner()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Foliage.ProceduralFoliageSpawner");
		}

		// Token: 0x06011B1C RID: 72476 RVA: 0x0019FACF File Offset: 0x0019DCCF
		protected UProceduralFoliageSpawner(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040097D3 RID: 38867
		public new const string __ObjectPath = "/Script/Foliage.ProceduralFoliageSpawner";

		// Token: 0x040097D4 RID: 38868
		private static IntPtr _ClassPtr;

		// Token: 0x040097D5 RID: 38869
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040097D6 RID: 38870
		internal static int __PropertyOffset_RandomSeed;

		// Token: 0x040097D7 RID: 38871
		internal static int __PropertyOffset_TileSize;

		// Token: 0x040097D8 RID: 38872
		internal static int __PropertyOffset_NumUniqueTiles;

		// Token: 0x040097D9 RID: 38873
		internal static int __PropertyOffset_MinimumQuadTreeSize;

		// Token: 0x040097DA RID: 38874
		internal static int __PropertyOffset_FoliageTypes;

		// Token: 0x040097DB RID: 38875
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FFoliageTypeObject> _FoliageTypes;
	}
}
