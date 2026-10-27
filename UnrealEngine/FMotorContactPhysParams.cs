using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001F30 RID: 7984
	[UnrealObjectPath("/Script/KuroVehicle.MotorContactPhysParams")]
	[UnrealStructLayout(48, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FMotorContactPhysParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E5EC RID: 124396 RVA: 0x002D2272 File Offset: 0x002D0472
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMotorContactPhysParams._ScriptStructPtr != 0) ? FMotorContactPhysParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroVehicle.MotorContactPhysParams", ref FMotorContactPhysParams._ScriptStructPtr);
		}

		// Token: 0x170078BD RID: 30909
		// (get) Token: 0x0601E5ED RID: 124397 RVA: 0x002D2296 File Offset: 0x002D0496
		// (set) Token: 0x0601E5EE RID: 124398 RVA: 0x002D22AA File Offset: 0x002D04AA
		public unsafe FVector MotorHitReboundReduce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorContactPhysParams.__PropertyOffset_MotorHitReboundReduce);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorContactPhysParams.__PropertyOffset_MotorHitReboundReduce) = value;
			}
		}

		// Token: 0x170078BE RID: 30910
		// (get) Token: 0x0601E5EF RID: 124399 RVA: 0x002D22BF File Offset: 0x002D04BF
		// (set) Token: 0x0601E5F0 RID: 124400 RVA: 0x002D22D3 File Offset: 0x002D04D3
		public unsafe FVector MotorHitReboundCoeff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorContactPhysParams.__PropertyOffset_MotorHitReboundCoeff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorContactPhysParams.__PropertyOffset_MotorHitReboundCoeff) = value;
			}
		}

		// Token: 0x170078BF RID: 30911
		// (get) Token: 0x0601E5F1 RID: 124401 RVA: 0x002D22E8 File Offset: 0x002D04E8
		// (set) Token: 0x0601E5F2 RID: 124402 RVA: 0x002D22F8 File Offset: 0x002D04F8
		public unsafe float MotorHitDragCoeff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorContactPhysParams.__PropertyOffset_MotorHitDragCoeff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorContactPhysParams.__PropertyOffset_MotorHitDragCoeff) = value;
			}
		}

		// Token: 0x170078C0 RID: 30912
		// (get) Token: 0x0601E5F3 RID: 124403 RVA: 0x002D2309 File Offset: 0x002D0509
		// (set) Token: 0x0601E5F4 RID: 124404 RVA: 0x002D2319 File Offset: 0x002D0519
		public unsafe float MotorHitDragWheelRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorContactPhysParams.__PropertyOffset_MotorHitDragWheelRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorContactPhysParams.__PropertyOffset_MotorHitDragWheelRate) = value;
			}
		}

		// Token: 0x170078C1 RID: 30913
		// (get) Token: 0x0601E5F5 RID: 124405 RVA: 0x002D232A File Offset: 0x002D052A
		// (set) Token: 0x0601E5F6 RID: 124406 RVA: 0x002D233A File Offset: 0x002D053A
		public unsafe float ChasisHitThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorContactPhysParams.__PropertyOffset_ChasisHitThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorContactPhysParams.__PropertyOffset_ChasisHitThreshold) = value;
			}
		}

		// Token: 0x170078C2 RID: 30914
		// (get) Token: 0x0601E5F7 RID: 124407 RVA: 0x002D234B File Offset: 0x002D054B
		// (set) Token: 0x0601E5F8 RID: 124408 RVA: 0x002D235B File Offset: 0x002D055B
		public unsafe float ChasisHitSpeedThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorContactPhysParams.__PropertyOffset_ChasisHitSpeedThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorContactPhysParams.__PropertyOffset_ChasisHitSpeedThreshold) = value;
			}
		}

		// Token: 0x170078C3 RID: 30915
		// (get) Token: 0x0601E5F9 RID: 124409 RVA: 0x002D236C File Offset: 0x002D056C
		// (set) Token: 0x0601E5FA RID: 124410 RVA: 0x002D237C File Offset: 0x002D057C
		public unsafe float ChasisHitSpeedAdd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorContactPhysParams.__PropertyOffset_ChasisHitSpeedAdd);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorContactPhysParams.__PropertyOffset_ChasisHitSpeedAdd) = value;
			}
		}

		// Token: 0x170078C4 RID: 30916
		// (get) Token: 0x0601E5FB RID: 124411 RVA: 0x002D238D File Offset: 0x002D058D
		// (set) Token: 0x0601E5FC RID: 124412 RVA: 0x002D239D File Offset: 0x002D059D
		public unsafe float ChasisKeepTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorContactPhysParams.__PropertyOffset_ChasisKeepTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorContactPhysParams.__PropertyOffset_ChasisKeepTime) = value;
			}
		}

		// Token: 0x0601E5FD RID: 124413 RVA: 0x002D23AE File Offset: 0x002D05AE
		public FMotorContactPhysParams()
		{
		}

		// Token: 0x0601E5FE RID: 124414 RVA: 0x002D23B8 File Offset: 0x002D05B8
		public FMotorContactPhysParams(FVector MotorHitReboundReduce, FVector MotorHitReboundCoeff, float MotorHitDragCoeff, float MotorHitDragWheelRate, float ChasisHitThreshold, float ChasisHitSpeedThreshold, float ChasisHitSpeedAdd, float ChasisKeepTime)
		{
			this.MotorHitReboundReduce = MotorHitReboundReduce;
			this.MotorHitReboundCoeff = MotorHitReboundCoeff;
			this.MotorHitDragCoeff = MotorHitDragCoeff;
			this.MotorHitDragWheelRate = MotorHitDragWheelRate;
			this.ChasisHitThreshold = ChasisHitThreshold;
			this.ChasisHitSpeedThreshold = ChasisHitSpeedThreshold;
			this.ChasisHitSpeedAdd = ChasisHitSpeedAdd;
			this.ChasisKeepTime = ChasisKeepTime;
		}

		// Token: 0x0601E5FF RID: 124415 RVA: 0x002D2408 File Offset: 0x002D0608
		protected override IntPtr GetUStructPtr()
		{
			return FMotorContactPhysParams.StaticStruct();
		}

		// Token: 0x0601E600 RID: 124416 RVA: 0x002D2414 File Offset: 0x002D0614
		[NullableContext(2)]
		public FMotorContactPhysParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E601 RID: 124417 RVA: 0x002D241E File Offset: 0x002D061E
		public FMotorContactPhysParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E602 RID: 124418 RVA: 0x002D2429 File Offset: 0x002D0629
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMotorContactPhysParams(Pointer, false, true);
		}

		// Token: 0x0601E603 RID: 124419 RVA: 0x002D2433 File Offset: 0x002D0633
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMotorContactPhysParams(Pointer, MemoryOwner);
		}

		// Token: 0x04010617 RID: 67095
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroVehicle.MotorContactPhysParams";

		// Token: 0x04010618 RID: 67096
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010619 RID: 67097
		internal static int __PropertyOffset_MotorHitReboundReduce;

		// Token: 0x0401061A RID: 67098
		internal static int __PropertyOffset_MotorHitReboundCoeff;

		// Token: 0x0401061B RID: 67099
		internal static int __PropertyOffset_MotorHitDragCoeff;

		// Token: 0x0401061C RID: 67100
		internal static int __PropertyOffset_MotorHitDragWheelRate;

		// Token: 0x0401061D RID: 67101
		internal static int __PropertyOffset_ChasisHitThreshold;

		// Token: 0x0401061E RID: 67102
		internal static int __PropertyOffset_ChasisHitSpeedThreshold;

		// Token: 0x0401061F RID: 67103
		internal static int __PropertyOffset_ChasisHitSpeedAdd;

		// Token: 0x04010620 RID: 67104
		internal static int __PropertyOffset_ChasisKeepTime;
	}
}
