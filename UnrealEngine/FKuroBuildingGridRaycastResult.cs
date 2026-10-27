using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020016B7 RID: 5815
	[UnrealObjectPath("/Script/KuroBuildingGridSystem.KuroBuildingGridRaycastResult")]
	[UnrealStructLayout(96, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FKuroBuildingGridRaycastResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601514D RID: 86349 RVA: 0x001EFC92 File Offset: 0x001EDE92
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroBuildingGridRaycastResult._ScriptStructPtr != 0) ? FKuroBuildingGridRaycastResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroBuildingGridSystem.KuroBuildingGridRaycastResult", ref FKuroBuildingGridRaycastResult._ScriptStructPtr);
		}

		// Token: 0x17005365 RID: 21349
		// (get) Token: 0x0601514E RID: 86350 RVA: 0x001EFCB6 File Offset: 0x001EDEB6
		// (set) Token: 0x0601514F RID: 86351 RVA: 0x001EFCCA File Offset: 0x001EDECA
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AKuroBuildingGrid> Grid
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBuildingGridRaycastResult.__PropertyOffset_Grid);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBuildingGridRaycastResult.__PropertyOffset_Grid) = value;
			}
		}

		// Token: 0x17005366 RID: 21350
		// (get) Token: 0x06015150 RID: 86352 RVA: 0x001EFCDF File Offset: 0x001EDEDF
		// (set) Token: 0x06015151 RID: 86353 RVA: 0x001EFCF3 File Offset: 0x001EDEF3
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UObject> Target
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBuildingGridRaycastResult.__PropertyOffset_Target);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBuildingGridRaycastResult.__PropertyOffset_Target) = value;
			}
		}

		// Token: 0x17005367 RID: 21351
		// (get) Token: 0x06015152 RID: 86354 RVA: 0x001EFD08 File Offset: 0x001EDF08
		// (set) Token: 0x06015153 RID: 86355 RVA: 0x001EFD1C File Offset: 0x001EDF1C
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UObject> RaycastTarget
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBuildingGridRaycastResult.__PropertyOffset_RaycastTarget);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBuildingGridRaycastResult.__PropertyOffset_RaycastTarget) = value;
			}
		}

		// Token: 0x17005368 RID: 21352
		// (get) Token: 0x06015154 RID: 86356 RVA: 0x001EFD31 File Offset: 0x001EDF31
		// (set) Token: 0x06015155 RID: 86357 RVA: 0x001EFD41 File Offset: 0x001EDF41
		public unsafe float DegreeAlongNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBuildingGridRaycastResult.__PropertyOffset_DegreeAlongNormal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBuildingGridRaycastResult.__PropertyOffset_DegreeAlongNormal) = value;
			}
		}

		// Token: 0x17005369 RID: 21353
		// (get) Token: 0x06015156 RID: 86358 RVA: 0x001EFD52 File Offset: 0x001EDF52
		// (set) Token: 0x06015157 RID: 86359 RVA: 0x001EFD66 File Offset: 0x001EDF66
		public unsafe FKuroBuildingGridCellVector Coords
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBuildingGridRaycastResult.__PropertyOffset_Coords);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBuildingGridRaycastResult.__PropertyOffset_Coords) = value;
			}
		}

		// Token: 0x1700536A RID: 21354
		// (get) Token: 0x06015158 RID: 86360 RVA: 0x001EFD7B File Offset: 0x001EDF7B
		// (set) Token: 0x06015159 RID: 86361 RVA: 0x001EFD8F File Offset: 0x001EDF8F
		public unsafe FVectorDouble Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBuildingGridRaycastResult.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBuildingGridRaycastResult.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x1700536B RID: 21355
		// (get) Token: 0x0601515A RID: 86362 RVA: 0x001EFDA4 File Offset: 0x001EDFA4
		// (set) Token: 0x0601515B RID: 86363 RVA: 0x001EFDB8 File Offset: 0x001EDFB8
		public unsafe FVector Normal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBuildingGridRaycastResult.__PropertyOffset_Normal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBuildingGridRaycastResult.__PropertyOffset_Normal) = value;
			}
		}

		// Token: 0x1700536C RID: 21356
		// (get) Token: 0x0601515C RID: 86364 RVA: 0x001EFDCD File Offset: 0x001EDFCD
		// (set) Token: 0x0601515D RID: 86365 RVA: 0x001EFDE1 File Offset: 0x001EDFE1
		public unsafe FQuat Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBuildingGridRaycastResult.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBuildingGridRaycastResult.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x0601515E RID: 86366 RVA: 0x001EFDF6 File Offset: 0x001EDFF6
		public FKuroBuildingGridRaycastResult()
		{
		}

		// Token: 0x0601515F RID: 86367 RVA: 0x001EFE00 File Offset: 0x001EE000
		public FKuroBuildingGridRaycastResult([Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<AKuroBuildingGrid> Grid, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UObject> Target, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UObject> RaycastTarget, float DegreeAlongNormal, FKuroBuildingGridCellVector Coords, FVectorDouble Location, FVector Normal, FQuat Rotation)
		{
			this.Grid = Grid;
			this.Target = Target;
			this.RaycastTarget = RaycastTarget;
			this.DegreeAlongNormal = DegreeAlongNormal;
			this.Coords = Coords;
			this.Location = Location;
			this.Normal = Normal;
			this.Rotation = Rotation;
		}

		// Token: 0x06015160 RID: 86368 RVA: 0x001EFE50 File Offset: 0x001EE050
		protected override IntPtr GetUStructPtr()
		{
			return FKuroBuildingGridRaycastResult.StaticStruct();
		}

		// Token: 0x06015161 RID: 86369 RVA: 0x001EFE5C File Offset: 0x001EE05C
		[NullableContext(2)]
		public FKuroBuildingGridRaycastResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015162 RID: 86370 RVA: 0x001EFE66 File Offset: 0x001EE066
		public FKuroBuildingGridRaycastResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015163 RID: 86371 RVA: 0x001EFE71 File Offset: 0x001EE071
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroBuildingGridRaycastResult(Pointer, false, true);
		}

		// Token: 0x06015164 RID: 86372 RVA: 0x001EFE7B File Offset: 0x001EE07B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroBuildingGridRaycastResult(Pointer, MemoryOwner);
		}

		// Token: 0x0400B790 RID: 46992
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroBuildingGridSystem.KuroBuildingGridRaycastResult";

		// Token: 0x0400B791 RID: 46993
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B792 RID: 46994
		internal static int __PropertyOffset_Grid;

		// Token: 0x0400B793 RID: 46995
		internal static int __PropertyOffset_Target;

		// Token: 0x0400B794 RID: 46996
		internal static int __PropertyOffset_RaycastTarget;

		// Token: 0x0400B795 RID: 46997
		internal static int __PropertyOffset_DegreeAlongNormal;

		// Token: 0x0400B796 RID: 46998
		internal static int __PropertyOffset_Coords;

		// Token: 0x0400B797 RID: 46999
		internal static int __PropertyOffset_Location;

		// Token: 0x0400B798 RID: 47000
		internal static int __PropertyOffset_Normal;

		// Token: 0x0400B799 RID: 47001
		internal static int __PropertyOffset_Rotation;
	}
}
