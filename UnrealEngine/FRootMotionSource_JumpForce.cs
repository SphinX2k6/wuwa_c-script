using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010A4 RID: 4260
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.RootMotionSource_JumpForce")]
	[UnrealStructLayout(208, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 208)]
	public class FRootMotionSource_JumpForce : FRootMotionSource, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F37C RID: 62332 RVA: 0x00169168 File Offset: 0x00167368
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRootMotionSource_JumpForce._ScriptStructPtr != 0) ? FRootMotionSource_JumpForce._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RootMotionSource_JumpForce", ref FRootMotionSource_JumpForce._ScriptStructPtr);
		}

		// Token: 0x17003B4C RID: 15180
		// (get) Token: 0x0600F37D RID: 62333 RVA: 0x0016918C File Offset: 0x0016738C
		// (set) Token: 0x0600F37E RID: 62334 RVA: 0x001691A0 File Offset: 0x001673A0
		public unsafe FRotator Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRootMotionSource_JumpForce.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionSource_JumpForce.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x17003B4D RID: 15181
		// (get) Token: 0x0600F37F RID: 62335 RVA: 0x001691B5 File Offset: 0x001673B5
		// (set) Token: 0x0600F380 RID: 62336 RVA: 0x001691C5 File Offset: 0x001673C5
		public unsafe float Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRootMotionSource_JumpForce.__PropertyOffset_Distance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionSource_JumpForce.__PropertyOffset_Distance) = value;
			}
		}

		// Token: 0x17003B4E RID: 15182
		// (get) Token: 0x0600F381 RID: 62337 RVA: 0x001691D6 File Offset: 0x001673D6
		// (set) Token: 0x0600F382 RID: 62338 RVA: 0x001691E6 File Offset: 0x001673E6
		public unsafe float Height
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRootMotionSource_JumpForce.__PropertyOffset_Height);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionSource_JumpForce.__PropertyOffset_Height) = value;
			}
		}

		// Token: 0x17003B4F RID: 15183
		// (get) Token: 0x0600F383 RID: 62339 RVA: 0x001691F7 File Offset: 0x001673F7
		// (set) Token: 0x0600F384 RID: 62340 RVA: 0x00169207 File Offset: 0x00167407
		public unsafe bool bDisableTimeout
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRootMotionSource_JumpForce.__PropertyOffset_bDisableTimeout) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionSource_JumpForce.__PropertyOffset_bDisableTimeout) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003B50 RID: 15184
		// (get) Token: 0x0600F385 RID: 62341 RVA: 0x00169218 File Offset: 0x00167418
		// (set) Token: 0x0600F386 RID: 62342 RVA: 0x0016922C File Offset: 0x0016742C
		public unsafe UCurveVector PathOffsetCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveVector>(base.NativePtr / (IntPtr)sizeof(void*) + FRootMotionSource_JumpForce.__PropertyOffset_PathOffsetCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FRootMotionSource_JumpForce.__PropertyOffset_PathOffsetCurve, value);
			}
		}

		// Token: 0x17003B51 RID: 15185
		// (get) Token: 0x0600F387 RID: 62343 RVA: 0x00169241 File Offset: 0x00167441
		// (set) Token: 0x0600F388 RID: 62344 RVA: 0x00169255 File Offset: 0x00167455
		public unsafe UCurveFloat TimeMappingCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FRootMotionSource_JumpForce.__PropertyOffset_TimeMappingCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FRootMotionSource_JumpForce.__PropertyOffset_TimeMappingCurve, value);
			}
		}

		// Token: 0x0600F389 RID: 62345 RVA: 0x0016926A File Offset: 0x0016746A
		public FRootMotionSource_JumpForce()
		{
		}

		// Token: 0x0600F38A RID: 62346 RVA: 0x00169274 File Offset: 0x00167474
		[NullableContext(1)]
		public FRootMotionSource_JumpForce(FRotator Rotation, float Distance, float Height, bool bDisableTimeout, UCurveVector PathOffsetCurve, UCurveFloat TimeMappingCurve, ushort Priority, ushort LocalID, ERootMotionAccumulateMode AccumulateMode, FName InstanceName, float StartTime, float CurrentTime, float PreviousTime, float Duration, FRootMotionSourceStatus Status, FRootMotionSourceSettings Settings, bool bInLocalSpace, FRootMotionMovementParams RootMotionParams, FRootMotionFinishVelocitySettings FinishVelocityParams)
		{
			this.Rotation = Rotation;
			this.Distance = Distance;
			this.Height = Height;
			this.bDisableTimeout = bDisableTimeout;
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

		// Token: 0x0600F38B RID: 62347 RVA: 0x0016931C File Offset: 0x0016751C
		protected override IntPtr GetUStructPtr()
		{
			return FRootMotionSource_JumpForce.StaticStruct();
		}

		// Token: 0x0600F38C RID: 62348 RVA: 0x00169328 File Offset: 0x00167528
		public FRootMotionSource_JumpForce(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F38D RID: 62349 RVA: 0x00169332 File Offset: 0x00167532
		public FRootMotionSource_JumpForce(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F38E RID: 62350 RVA: 0x0016933D File Offset: 0x0016753D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRootMotionSource_JumpForce(Pointer, false, true);
		}

		// Token: 0x0600F38F RID: 62351 RVA: 0x00169347 File Offset: 0x00167547
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRootMotionSource_JumpForce(Pointer, MemoryOwner);
		}

		// Token: 0x04008404 RID: 33796
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.RootMotionSource_JumpForce";

		// Token: 0x04008405 RID: 33797
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008406 RID: 33798
		internal static int __PropertyOffset_Rotation;

		// Token: 0x04008407 RID: 33799
		internal static int __PropertyOffset_Distance;

		// Token: 0x04008408 RID: 33800
		internal static int __PropertyOffset_Height;

		// Token: 0x04008409 RID: 33801
		internal static int __PropertyOffset_bDisableTimeout;

		// Token: 0x0400840A RID: 33802
		internal static int __PropertyOffset_PathOffsetCurve;

		// Token: 0x0400840B RID: 33803
		internal static int __PropertyOffset_TimeMappingCurve;
	}
}
