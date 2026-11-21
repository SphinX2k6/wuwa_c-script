using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000320 RID: 800
	[UnrealObjectPath("/Script/KuroBuildingGridSystem.KuroBuildingGridRaycastResult")]
	[UnrealStructLayout(96, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FKuroBuildingGridRaycastResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005431 RID: 21553 RVA: 0x00075D02 File Offset: 0x00073F02
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroBuildingGridRaycastResult._ScriptStructPtr != 0) ? FKuroBuildingGridRaycastResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroBuildingGridSystem.KuroBuildingGridRaycastResult", ref FKuroBuildingGridRaycastResult._ScriptStructPtr);
		}

		// Token: 0x1700109E RID: 4254
		// (get) Token: 0x06005432 RID: 21554 RVA: 0x00075D26 File Offset: 0x00073F26
		// (set) Token: 0x06005433 RID: 21555 RVA: 0x00075D3A File Offset: 0x00073F3A
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

		// Token: 0x1700109F RID: 4255
		// (get) Token: 0x06005434 RID: 21556 RVA: 0x00075D4F File Offset: 0x00073F4F
		// (set) Token: 0x06005435 RID: 21557 RVA: 0x00075D63 File Offset: 0x00073F63
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

		// Token: 0x170010A0 RID: 4256
		// (get) Token: 0x06005436 RID: 21558 RVA: 0x00075D78 File Offset: 0x00073F78
		// (set) Token: 0x06005437 RID: 21559 RVA: 0x00075D8C File Offset: 0x00073F8C
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

		// Token: 0x170010A1 RID: 4257
		// (get) Token: 0x06005438 RID: 21560 RVA: 0x00075DA1 File Offset: 0x00073FA1
		// (set) Token: 0x06005439 RID: 21561 RVA: 0x00075DB1 File Offset: 0x00073FB1
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

		// Token: 0x170010A2 RID: 4258
		// (get) Token: 0x0600543A RID: 21562 RVA: 0x00075DC2 File Offset: 0x00073FC2
		// (set) Token: 0x0600543B RID: 21563 RVA: 0x00075DD6 File Offset: 0x00073FD6
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

		// Token: 0x170010A3 RID: 4259
		// (get) Token: 0x0600543C RID: 21564 RVA: 0x00075DEB File Offset: 0x00073FEB
		// (set) Token: 0x0600543D RID: 21565 RVA: 0x00075DFF File Offset: 0x00073FFF
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

		// Token: 0x170010A4 RID: 4260
		// (get) Token: 0x0600543E RID: 21566 RVA: 0x00075E14 File Offset: 0x00074014
		// (set) Token: 0x0600543F RID: 21567 RVA: 0x00075E28 File Offset: 0x00074028
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

		// Token: 0x170010A5 RID: 4261
		// (get) Token: 0x06005440 RID: 21568 RVA: 0x00075E3D File Offset: 0x0007403D
		// (set) Token: 0x06005441 RID: 21569 RVA: 0x00075E51 File Offset: 0x00074051
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

		// Token: 0x06005442 RID: 21570 RVA: 0x00075E66 File Offset: 0x00074066
		public FKuroBuildingGridRaycastResult()
		{
		}

		// Token: 0x06005443 RID: 21571 RVA: 0x00075E6E File Offset: 0x0007406E
		protected override IntPtr GetUStructPtr()
		{
			return FKuroBuildingGridRaycastResult.StaticStruct();
		}

		// Token: 0x06005444 RID: 21572 RVA: 0x00075E7A File Offset: 0x0007407A
		[NullableContext(2)]
		public FKuroBuildingGridRaycastResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005445 RID: 21573 RVA: 0x00075E84 File Offset: 0x00074084
		public FKuroBuildingGridRaycastResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005446 RID: 21574 RVA: 0x00075E8F File Offset: 0x0007408F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroBuildingGridRaycastResult(Pointer, false, true);
		}

		// Token: 0x06005447 RID: 21575 RVA: 0x00075E99 File Offset: 0x00074099
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroBuildingGridRaycastResult(Pointer, MemoryOwner);
		}

		// Token: 0x04002262 RID: 8802
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroBuildingGridSystem.KuroBuildingGridRaycastResult";

		// Token: 0x04002263 RID: 8803
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002264 RID: 8804
		internal static int __PropertyOffset_Grid;

		// Token: 0x04002265 RID: 8805
		internal static int __PropertyOffset_Target;

		// Token: 0x04002266 RID: 8806
		internal static int __PropertyOffset_RaycastTarget;

		// Token: 0x04002267 RID: 8807
		internal static int __PropertyOffset_DegreeAlongNormal;

		// Token: 0x04002268 RID: 8808
		internal static int __PropertyOffset_Coords;

		// Token: 0x04002269 RID: 8809
		internal static int __PropertyOffset_Location;

		// Token: 0x0400226A RID: 8810
		internal static int __PropertyOffset_Normal;

		// Token: 0x0400226B RID: 8811
		internal static int __PropertyOffset_Rotation;
	}
}
