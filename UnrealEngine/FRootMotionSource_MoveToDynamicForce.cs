using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010A5 RID: 4261
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.RootMotionSource_MoveToDynamicForce")]
	[UnrealStructLayout(208, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 208)]
	public class FRootMotionSource_MoveToDynamicForce : FRootMotionSource, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F390 RID: 62352 RVA: 0x00169350 File Offset: 0x00167550
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRootMotionSource_MoveToDynamicForce._ScriptStructPtr != 0) ? FRootMotionSource_MoveToDynamicForce._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RootMotionSource_MoveToDynamicForce", ref FRootMotionSource_MoveToDynamicForce._ScriptStructPtr);
		}

		// Token: 0x17003B52 RID: 15186
		// (get) Token: 0x0600F391 RID: 62353 RVA: 0x00169374 File Offset: 0x00167574
		// (set) Token: 0x0600F392 RID: 62354 RVA: 0x00169388 File Offset: 0x00167588
		public unsafe FVector StartLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRootMotionSource_MoveToDynamicForce.__PropertyOffset_StartLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionSource_MoveToDynamicForce.__PropertyOffset_StartLocation) = value;
			}
		}

		// Token: 0x17003B53 RID: 15187
		// (get) Token: 0x0600F393 RID: 62355 RVA: 0x0016939D File Offset: 0x0016759D
		// (set) Token: 0x0600F394 RID: 62356 RVA: 0x001693B1 File Offset: 0x001675B1
		public unsafe FVector InitialTargetLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRootMotionSource_MoveToDynamicForce.__PropertyOffset_InitialTargetLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionSource_MoveToDynamicForce.__PropertyOffset_InitialTargetLocation) = value;
			}
		}

		// Token: 0x17003B54 RID: 15188
		// (get) Token: 0x0600F395 RID: 62357 RVA: 0x001693C6 File Offset: 0x001675C6
		// (set) Token: 0x0600F396 RID: 62358 RVA: 0x001693DA File Offset: 0x001675DA
		public unsafe FVector TargetLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRootMotionSource_MoveToDynamicForce.__PropertyOffset_TargetLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionSource_MoveToDynamicForce.__PropertyOffset_TargetLocation) = value;
			}
		}

		// Token: 0x17003B55 RID: 15189
		// (get) Token: 0x0600F397 RID: 62359 RVA: 0x001693EF File Offset: 0x001675EF
		// (set) Token: 0x0600F398 RID: 62360 RVA: 0x001693FF File Offset: 0x001675FF
		public unsafe bool bRestrictSpeedToExpected
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRootMotionSource_MoveToDynamicForce.__PropertyOffset_bRestrictSpeedToExpected) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionSource_MoveToDynamicForce.__PropertyOffset_bRestrictSpeedToExpected) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003B56 RID: 15190
		// (get) Token: 0x0600F399 RID: 62361 RVA: 0x00169410 File Offset: 0x00167610
		// (set) Token: 0x0600F39A RID: 62362 RVA: 0x00169424 File Offset: 0x00167624
		public unsafe UCurveVector PathOffsetCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveVector>(base.NativePtr / (IntPtr)sizeof(void*) + FRootMotionSource_MoveToDynamicForce.__PropertyOffset_PathOffsetCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FRootMotionSource_MoveToDynamicForce.__PropertyOffset_PathOffsetCurve, value);
			}
		}

		// Token: 0x17003B57 RID: 15191
		// (get) Token: 0x0600F39B RID: 62363 RVA: 0x00169439 File Offset: 0x00167639
		// (set) Token: 0x0600F39C RID: 62364 RVA: 0x0016944D File Offset: 0x0016764D
		public unsafe UCurveFloat TimeMappingCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FRootMotionSource_MoveToDynamicForce.__PropertyOffset_TimeMappingCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FRootMotionSource_MoveToDynamicForce.__PropertyOffset_TimeMappingCurve, value);
			}
		}

		// Token: 0x0600F39D RID: 62365 RVA: 0x00169462 File Offset: 0x00167662
		public FRootMotionSource_MoveToDynamicForce()
		{
		}

		// Token: 0x0600F39E RID: 62366 RVA: 0x0016946C File Offset: 0x0016766C
		[NullableContext(1)]
		public FRootMotionSource_MoveToDynamicForce(FVector StartLocation, FVector InitialTargetLocation, FVector TargetLocation, bool bRestrictSpeedToExpected, UCurveVector PathOffsetCurve, UCurveFloat TimeMappingCurve, ushort Priority, ushort LocalID, ERootMotionAccumulateMode AccumulateMode, FName InstanceName, float StartTime, float CurrentTime, float PreviousTime, float Duration, FRootMotionSourceStatus Status, FRootMotionSourceSettings Settings, bool bInLocalSpace, FRootMotionMovementParams RootMotionParams, FRootMotionFinishVelocitySettings FinishVelocityParams)
		{
			this.StartLocation = StartLocation;
			this.InitialTargetLocation = InitialTargetLocation;
			this.TargetLocation = TargetLocation;
			this.bRestrictSpeedToExpected = bRestrictSpeedToExpected;
			this.PathOffsetCurve = PathOffsetCurve;
			this.TimeMappingCurve = TimeMappingCurve;
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

		// Token: 0x0600F39F RID: 62367 RVA: 0x00169514 File Offset: 0x00167714
		protected override IntPtr GetUStructPtr()
		{
			return FRootMotionSource_MoveToDynamicForce.StaticStruct();
		}

		// Token: 0x0600F3A0 RID: 62368 RVA: 0x00169520 File Offset: 0x00167720
		public FRootMotionSource_MoveToDynamicForce(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F3A1 RID: 62369 RVA: 0x0016952A File Offset: 0x0016772A
		public FRootMotionSource_MoveToDynamicForce(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F3A2 RID: 62370 RVA: 0x00169535 File Offset: 0x00167735
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRootMotionSource_MoveToDynamicForce(Pointer, false, true);
		}

		// Token: 0x0600F3A3 RID: 62371 RVA: 0x0016953F File Offset: 0x0016773F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRootMotionSource_MoveToDynamicForce(Pointer, MemoryOwner);
		}

		// Token: 0x0400840C RID: 33804
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.RootMotionSource_MoveToDynamicForce";

		// Token: 0x0400840D RID: 33805
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400840E RID: 33806
		internal static int __PropertyOffset_StartLocation;

		// Token: 0x0400840F RID: 33807
		internal static int __PropertyOffset_InitialTargetLocation;

		// Token: 0x04008410 RID: 33808
		internal static int __PropertyOffset_TargetLocation;

		// Token: 0x04008411 RID: 33809
		internal static int __PropertyOffset_bRestrictSpeedToExpected;

		// Token: 0x04008412 RID: 33810
		internal static int __PropertyOffset_PathOffsetCurve;

		// Token: 0x04008413 RID: 33811
		internal static int __PropertyOffset_TimeMappingCurve;
	}
}
