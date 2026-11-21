using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200020D RID: 525
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.FindFloorResult")]
	[UnrealStructLayout(160, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FFindFloorResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060021B2 RID: 8626 RVA: 0x0003160D File Offset: 0x0002F80D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFindFloorResult._ScriptStructPtr != 0) ? FFindFloorResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.FindFloorResult", ref FFindFloorResult._ScriptStructPtr);
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x060021B3 RID: 8627 RVA: 0x00031631 File Offset: 0x0002F831
		// (set) Token: 0x060021B4 RID: 8628 RVA: 0x0003164A File Offset: 0x0002F84A
		public unsafe bool bBlockingHit
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FFindFloorResult.__PropertyOffset_bBlockingHit) & FFindFloorResult.__PropertyMask_bBlockingHit) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FFindFloorResult.__PropertyOffset_bBlockingHit) = ((*(base.NativePtr + (IntPtr)FFindFloorResult.__PropertyOffset_bBlockingHit) & ~FFindFloorResult.__PropertyMask_bBlockingHit) | (value ? FFindFloorResult.__PropertyMask_bBlockingHit : 0));
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x060021B5 RID: 8629 RVA: 0x0003167A File Offset: 0x0002F87A
		// (set) Token: 0x060021B6 RID: 8630 RVA: 0x00031693 File Offset: 0x0002F893
		public unsafe bool bWalkableFloor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FFindFloorResult.__PropertyOffset_bWalkableFloor) & FFindFloorResult.__PropertyMask_bWalkableFloor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FFindFloorResult.__PropertyOffset_bWalkableFloor) = ((*(base.NativePtr + (IntPtr)FFindFloorResult.__PropertyOffset_bWalkableFloor) & ~FFindFloorResult.__PropertyMask_bWalkableFloor) | (value ? FFindFloorResult.__PropertyMask_bWalkableFloor : 0));
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x060021B7 RID: 8631 RVA: 0x000316C3 File Offset: 0x0002F8C3
		// (set) Token: 0x060021B8 RID: 8632 RVA: 0x000316DC File Offset: 0x0002F8DC
		public unsafe bool bLineTrace
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FFindFloorResult.__PropertyOffset_bLineTrace) & FFindFloorResult.__PropertyMask_bLineTrace) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FFindFloorResult.__PropertyOffset_bLineTrace) = ((*(base.NativePtr + (IntPtr)FFindFloorResult.__PropertyOffset_bLineTrace) & ~FFindFloorResult.__PropertyMask_bLineTrace) | (value ? FFindFloorResult.__PropertyMask_bLineTrace : 0));
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x060021B9 RID: 8633 RVA: 0x0003170C File Offset: 0x0002F90C
		// (set) Token: 0x060021BA RID: 8634 RVA: 0x0003171C File Offset: 0x0002F91C
		public unsafe float FloorDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFindFloorResult.__PropertyOffset_FloorDist);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFindFloorResult.__PropertyOffset_FloorDist) = value;
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x060021BB RID: 8635 RVA: 0x0003172D File Offset: 0x0002F92D
		// (set) Token: 0x060021BC RID: 8636 RVA: 0x0003173D File Offset: 0x0002F93D
		public unsafe float LineDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFindFloorResult.__PropertyOffset_LineDist);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFindFloorResult.__PropertyOffset_LineDist) = value;
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x060021BD RID: 8637 RVA: 0x00031750 File Offset: 0x0002F950
		// (set) Token: 0x060021BE RID: 8638 RVA: 0x00031793 File Offset: 0x0002F993
		public FHitResult HitResult
		{
			get
			{
				base.FastCheckIsValid();
				FHitResult result;
				if ((result = this._HitResult) == null)
				{
					result = (this._HitResult = new FHitResult(base.NativePtr + (IntPtr)FFindFloorResult.__PropertyOffset_HitResult, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), base.NativePtr + (IntPtr)FFindFloorResult.__PropertyOffset_HitResult, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060021BF RID: 8639 RVA: 0x000317B4 File Offset: 0x0002F9B4
		public FFindFloorResult()
		{
		}

		// Token: 0x060021C0 RID: 8640 RVA: 0x000317BC File Offset: 0x0002F9BC
		protected override IntPtr GetUStructPtr()
		{
			return FFindFloorResult.StaticStruct();
		}

		// Token: 0x060021C1 RID: 8641 RVA: 0x000317C8 File Offset: 0x0002F9C8
		[NullableContext(2)]
		public FFindFloorResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060021C2 RID: 8642 RVA: 0x000317D2 File Offset: 0x0002F9D2
		public FFindFloorResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060021C3 RID: 8643 RVA: 0x000317DD File Offset: 0x0002F9DD
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFindFloorResult(Pointer, false, true);
		}

		// Token: 0x060021C4 RID: 8644 RVA: 0x000317E7 File Offset: 0x0002F9E7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFindFloorResult(Pointer, MemoryOwner);
		}

		// Token: 0x04000D27 RID: 3367
		public const string __ObjectPath = "/Script/Engine.FindFloorResult";

		// Token: 0x04000D28 RID: 3368
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000D29 RID: 3369
		internal static int __PropertyOffset_bBlockingHit;

		// Token: 0x04000D2A RID: 3370
		internal static byte __PropertyMask_bBlockingHit;

		// Token: 0x04000D2B RID: 3371
		internal static int __PropertyOffset_bWalkableFloor;

		// Token: 0x04000D2C RID: 3372
		internal static byte __PropertyMask_bWalkableFloor;

		// Token: 0x04000D2D RID: 3373
		internal static int __PropertyOffset_bLineTrace;

		// Token: 0x04000D2E RID: 3374
		internal static byte __PropertyMask_bLineTrace;

		// Token: 0x04000D2F RID: 3375
		internal static int __PropertyOffset_FloorDist;

		// Token: 0x04000D30 RID: 3376
		internal static int __PropertyOffset_LineDist;

		// Token: 0x04000D31 RID: 3377
		internal static int __PropertyOffset_HitResult;

		// Token: 0x04000D32 RID: 3378
		[Nullable(2)]
		private FHitResult _HitResult;
	}
}
