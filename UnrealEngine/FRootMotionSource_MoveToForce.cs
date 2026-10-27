using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010A6 RID: 4262
	[UnrealObjectPath("/Script/Engine.RootMotionSource_MoveToForce")]
	[UnrealStructLayout(192, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 192)]
	public class FRootMotionSource_MoveToForce : FRootMotionSource, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F3A4 RID: 62372 RVA: 0x00169548 File Offset: 0x00167748
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRootMotionSource_MoveToForce._ScriptStructPtr != 0) ? FRootMotionSource_MoveToForce._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RootMotionSource_MoveToForce", ref FRootMotionSource_MoveToForce._ScriptStructPtr);
		}

		// Token: 0x17003B58 RID: 15192
		// (get) Token: 0x0600F3A5 RID: 62373 RVA: 0x0016956C File Offset: 0x0016776C
		// (set) Token: 0x0600F3A6 RID: 62374 RVA: 0x00169580 File Offset: 0x00167780
		public unsafe FVector StartLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRootMotionSource_MoveToForce.__PropertyOffset_StartLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionSource_MoveToForce.__PropertyOffset_StartLocation) = value;
			}
		}

		// Token: 0x17003B59 RID: 15193
		// (get) Token: 0x0600F3A7 RID: 62375 RVA: 0x00169595 File Offset: 0x00167795
		// (set) Token: 0x0600F3A8 RID: 62376 RVA: 0x001695A9 File Offset: 0x001677A9
		public unsafe FVector TargetLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRootMotionSource_MoveToForce.__PropertyOffset_TargetLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionSource_MoveToForce.__PropertyOffset_TargetLocation) = value;
			}
		}

		// Token: 0x17003B5A RID: 15194
		// (get) Token: 0x0600F3A9 RID: 62377 RVA: 0x001695BE File Offset: 0x001677BE
		// (set) Token: 0x0600F3AA RID: 62378 RVA: 0x001695CE File Offset: 0x001677CE
		public unsafe bool bRestrictSpeedToExpected
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRootMotionSource_MoveToForce.__PropertyOffset_bRestrictSpeedToExpected) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionSource_MoveToForce.__PropertyOffset_bRestrictSpeedToExpected) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003B5B RID: 15195
		// (get) Token: 0x0600F3AB RID: 62379 RVA: 0x001695DF File Offset: 0x001677DF
		// (set) Token: 0x0600F3AC RID: 62380 RVA: 0x001695F3 File Offset: 0x001677F3
		[Nullable(2)]
		public unsafe UCurveVector PathOffsetCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveVector>(base.NativePtr / (IntPtr)sizeof(void*) + FRootMotionSource_MoveToForce.__PropertyOffset_PathOffsetCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FRootMotionSource_MoveToForce.__PropertyOffset_PathOffsetCurve, value);
			}
		}

		// Token: 0x0600F3AD RID: 62381 RVA: 0x00169608 File Offset: 0x00167808
		public FRootMotionSource_MoveToForce()
		{
		}

		// Token: 0x0600F3AE RID: 62382 RVA: 0x00169610 File Offset: 0x00167810
		[NullableContext(1)]
		public FRootMotionSource_MoveToForce(FVector StartLocation, FVector TargetLocation, bool bRestrictSpeedToExpected, UCurveVector PathOffsetCurve, ushort Priority, ushort LocalID, ERootMotionAccumulateMode AccumulateMode, FName InstanceName, float StartTime, float CurrentTime, float PreviousTime, float Duration, FRootMotionSourceStatus Status, FRootMotionSourceSettings Settings, bool bInLocalSpace, FRootMotionMovementParams RootMotionParams, FRootMotionFinishVelocitySettings FinishVelocityParams)
		{
			this.StartLocation = StartLocation;
			this.TargetLocation = TargetLocation;
			this.bRestrictSpeedToExpected = bRestrictSpeedToExpected;
			this.PathOffsetCurve = PathOffsetCurve;
			base.Priority = Priority;
			base.LocalID = LocalID;
			base.AccumulateMode = AccumulateMode;
			base.InstanceName = InstanceName;
			base.StartTime = StartTime;
			base.CurrentTime = CurrentTime;
			base.PreviousTime = PreviousTime;
			base.Duration = Duration;
			base.Status = Status;
			base.Settings = Settings;
			base.bInLocalSpace = bInLocalSpace;
			base.RootMotionParams = RootMotionParams;
			base.FinishVelocityParams = FinishVelocityParams;
		}

		// Token: 0x0600F3AF RID: 62383 RVA: 0x001696A8 File Offset: 0x001678A8
		protected override IntPtr GetUStructPtr()
		{
			return FRootMotionSource_MoveToForce.StaticStruct();
		}

		// Token: 0x0600F3B0 RID: 62384 RVA: 0x001696B4 File Offset: 0x001678B4
		[NullableContext(2)]
		public FRootMotionSource_MoveToForce(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F3B1 RID: 62385 RVA: 0x001696BE File Offset: 0x001678BE
		public FRootMotionSource_MoveToForce(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F3B2 RID: 62386 RVA: 0x001696C9 File Offset: 0x001678C9
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRootMotionSource_MoveToForce(Pointer, false, true);
		}

		// Token: 0x0600F3B3 RID: 62387 RVA: 0x001696D3 File Offset: 0x001678D3
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRootMotionSource_MoveToForce(Pointer, MemoryOwner);
		}

		// Token: 0x04008414 RID: 33812
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.RootMotionSource_MoveToForce";

		// Token: 0x04008415 RID: 33813
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008416 RID: 33814
		internal static int __PropertyOffset_StartLocation;

		// Token: 0x04008417 RID: 33815
		internal static int __PropertyOffset_TargetLocation;

		// Token: 0x04008418 RID: 33816
		internal static int __PropertyOffset_bRestrictSpeedToExpected;

		// Token: 0x04008419 RID: 33817
		internal static int __PropertyOffset_PathOffsetCurve;
	}
}
