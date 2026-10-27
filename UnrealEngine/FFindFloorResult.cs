using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000BD5 RID: 3029
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.FindFloorResult")]
	[UnrealStructLayout(160, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FFindFloorResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060094EE RID: 38126 RVA: 0x000D47DE File Offset: 0x000D29DE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFindFloorResult._ScriptStructPtr != 0) ? FFindFloorResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.FindFloorResult", ref FFindFloorResult._ScriptStructPtr);
		}

		// Token: 0x170023A5 RID: 9125
		// (get) Token: 0x060094EF RID: 38127 RVA: 0x000D4802 File Offset: 0x000D2A02
		// (set) Token: 0x060094F0 RID: 38128 RVA: 0x000D481B File Offset: 0x000D2A1B
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

		// Token: 0x170023A6 RID: 9126
		// (get) Token: 0x060094F1 RID: 38129 RVA: 0x000D484B File Offset: 0x000D2A4B
		// (set) Token: 0x060094F2 RID: 38130 RVA: 0x000D4864 File Offset: 0x000D2A64
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

		// Token: 0x170023A7 RID: 9127
		// (get) Token: 0x060094F3 RID: 38131 RVA: 0x000D4894 File Offset: 0x000D2A94
		// (set) Token: 0x060094F4 RID: 38132 RVA: 0x000D48AD File Offset: 0x000D2AAD
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

		// Token: 0x170023A8 RID: 9128
		// (get) Token: 0x060094F5 RID: 38133 RVA: 0x000D48DD File Offset: 0x000D2ADD
		// (set) Token: 0x060094F6 RID: 38134 RVA: 0x000D48ED File Offset: 0x000D2AED
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

		// Token: 0x170023A9 RID: 9129
		// (get) Token: 0x060094F7 RID: 38135 RVA: 0x000D48FE File Offset: 0x000D2AFE
		// (set) Token: 0x060094F8 RID: 38136 RVA: 0x000D490E File Offset: 0x000D2B0E
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

		// Token: 0x170023AA RID: 9130
		// (get) Token: 0x060094F9 RID: 38137 RVA: 0x000D4920 File Offset: 0x000D2B20
		// (set) Token: 0x060094FA RID: 38138 RVA: 0x000D4963 File Offset: 0x000D2B63
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

		// Token: 0x060094FB RID: 38139 RVA: 0x000D4984 File Offset: 0x000D2B84
		public FFindFloorResult()
		{
		}

		// Token: 0x060094FC RID: 38140 RVA: 0x000D498C File Offset: 0x000D2B8C
		public FFindFloorResult(bool bBlockingHit, bool bWalkableFloor, bool bLineTrace, float FloorDist, float LineDist, FHitResult HitResult)
		{
			this.bBlockingHit = bBlockingHit;
			this.bWalkableFloor = bWalkableFloor;
			this.bLineTrace = bLineTrace;
			this.FloorDist = FloorDist;
			this.LineDist = LineDist;
			this.HitResult = HitResult;
		}

		// Token: 0x060094FD RID: 38141 RVA: 0x000D49C1 File Offset: 0x000D2BC1
		protected override IntPtr GetUStructPtr()
		{
			return FFindFloorResult.StaticStruct();
		}

		// Token: 0x060094FE RID: 38142 RVA: 0x000D49CD File Offset: 0x000D2BCD
		[NullableContext(2)]
		public FFindFloorResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060094FF RID: 38143 RVA: 0x000D49D7 File Offset: 0x000D2BD7
		public FFindFloorResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009500 RID: 38144 RVA: 0x000D49E2 File Offset: 0x000D2BE2
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFindFloorResult(Pointer, false, true);
		}

		// Token: 0x06009501 RID: 38145 RVA: 0x000D49EC File Offset: 0x000D2BEC
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFindFloorResult(Pointer, MemoryOwner);
		}

		// Token: 0x0400539B RID: 21403
		public const string __ObjectPath = "/Script/Engine.FindFloorResult";

		// Token: 0x0400539C RID: 21404
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400539D RID: 21405
		internal static int __PropertyOffset_bBlockingHit;

		// Token: 0x0400539E RID: 21406
		internal static byte __PropertyMask_bBlockingHit;

		// Token: 0x0400539F RID: 21407
		internal static int __PropertyOffset_bWalkableFloor;

		// Token: 0x040053A0 RID: 21408
		internal static byte __PropertyMask_bWalkableFloor;

		// Token: 0x040053A1 RID: 21409
		internal static int __PropertyOffset_bLineTrace;

		// Token: 0x040053A2 RID: 21410
		internal static byte __PropertyMask_bLineTrace;

		// Token: 0x040053A3 RID: 21411
		internal static int __PropertyOffset_FloorDist;

		// Token: 0x040053A4 RID: 21412
		internal static int __PropertyOffset_LineDist;

		// Token: 0x040053A5 RID: 21413
		internal static int __PropertyOffset_HitResult;

		// Token: 0x040053A6 RID: 21414
		[Nullable(2)]
		private FHitResult _HitResult;
	}
}
