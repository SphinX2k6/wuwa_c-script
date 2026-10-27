using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010A7 RID: 4263
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.RootMotionSource_RadialForce")]
	[UnrealStructLayout(224, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 224)]
	public class FRootMotionSource_RadialForce : FRootMotionSource, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F3B4 RID: 62388 RVA: 0x001696DC File Offset: 0x001678DC
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRootMotionSource_RadialForce._ScriptStructPtr != 0) ? FRootMotionSource_RadialForce._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RootMotionSource_RadialForce", ref FRootMotionSource_RadialForce._ScriptStructPtr);
		}

		// Token: 0x17003B5C RID: 15196
		// (get) Token: 0x0600F3B5 RID: 62389 RVA: 0x00169700 File Offset: 0x00167900
		// (set) Token: 0x0600F3B6 RID: 62390 RVA: 0x00169714 File Offset: 0x00167914
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRootMotionSource_RadialForce.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionSource_RadialForce.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x17003B5D RID: 15197
		// (get) Token: 0x0600F3B7 RID: 62391 RVA: 0x00169729 File Offset: 0x00167929
		// (set) Token: 0x0600F3B8 RID: 62392 RVA: 0x0016973D File Offset: 0x0016793D
		public unsafe AActor LocationActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FRootMotionSource_RadialForce.__PropertyOffset_LocationActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FRootMotionSource_RadialForce.__PropertyOffset_LocationActor, value);
			}
		}

		// Token: 0x17003B5E RID: 15198
		// (get) Token: 0x0600F3B9 RID: 62393 RVA: 0x00169752 File Offset: 0x00167952
		// (set) Token: 0x0600F3BA RID: 62394 RVA: 0x00169762 File Offset: 0x00167962
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRootMotionSource_RadialForce.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionSource_RadialForce.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x17003B5F RID: 15199
		// (get) Token: 0x0600F3BB RID: 62395 RVA: 0x00169773 File Offset: 0x00167973
		// (set) Token: 0x0600F3BC RID: 62396 RVA: 0x00169783 File Offset: 0x00167983
		public unsafe float Strength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRootMotionSource_RadialForce.__PropertyOffset_Strength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionSource_RadialForce.__PropertyOffset_Strength) = value;
			}
		}

		// Token: 0x17003B60 RID: 15200
		// (get) Token: 0x0600F3BD RID: 62397 RVA: 0x00169794 File Offset: 0x00167994
		// (set) Token: 0x0600F3BE RID: 62398 RVA: 0x001697A4 File Offset: 0x001679A4
		public unsafe bool bIsPush
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRootMotionSource_RadialForce.__PropertyOffset_bIsPush) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionSource_RadialForce.__PropertyOffset_bIsPush) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003B61 RID: 15201
		// (get) Token: 0x0600F3BF RID: 62399 RVA: 0x001697B5 File Offset: 0x001679B5
		// (set) Token: 0x0600F3C0 RID: 62400 RVA: 0x001697C5 File Offset: 0x001679C5
		public unsafe bool bNoZForce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRootMotionSource_RadialForce.__PropertyOffset_bNoZForce) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionSource_RadialForce.__PropertyOffset_bNoZForce) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003B62 RID: 15202
		// (get) Token: 0x0600F3C1 RID: 62401 RVA: 0x001697D6 File Offset: 0x001679D6
		// (set) Token: 0x0600F3C2 RID: 62402 RVA: 0x001697EA File Offset: 0x001679EA
		public unsafe UCurveFloat StrengthDistanceFalloff
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FRootMotionSource_RadialForce.__PropertyOffset_StrengthDistanceFalloff);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FRootMotionSource_RadialForce.__PropertyOffset_StrengthDistanceFalloff, value);
			}
		}

		// Token: 0x17003B63 RID: 15203
		// (get) Token: 0x0600F3C3 RID: 62403 RVA: 0x001697FF File Offset: 0x001679FF
		// (set) Token: 0x0600F3C4 RID: 62404 RVA: 0x00169813 File Offset: 0x00167A13
		public unsafe UCurveFloat StrengthOverTime
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FRootMotionSource_RadialForce.__PropertyOffset_StrengthOverTime);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FRootMotionSource_RadialForce.__PropertyOffset_StrengthOverTime, value);
			}
		}

		// Token: 0x17003B64 RID: 15204
		// (get) Token: 0x0600F3C5 RID: 62405 RVA: 0x00169828 File Offset: 0x00167A28
		// (set) Token: 0x0600F3C6 RID: 62406 RVA: 0x00169838 File Offset: 0x00167A38
		public unsafe bool bUseFixedWorldDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRootMotionSource_RadialForce.__PropertyOffset_bUseFixedWorldDirection) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionSource_RadialForce.__PropertyOffset_bUseFixedWorldDirection) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003B65 RID: 15205
		// (get) Token: 0x0600F3C7 RID: 62407 RVA: 0x00169849 File Offset: 0x00167A49
		// (set) Token: 0x0600F3C8 RID: 62408 RVA: 0x0016985D File Offset: 0x00167A5D
		public unsafe FRotator FixedWorldDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRootMotionSource_RadialForce.__PropertyOffset_FixedWorldDirection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionSource_RadialForce.__PropertyOffset_FixedWorldDirection) = value;
			}
		}

		// Token: 0x0600F3C9 RID: 62409 RVA: 0x00169872 File Offset: 0x00167A72
		public FRootMotionSource_RadialForce()
		{
		}

		// Token: 0x0600F3CA RID: 62410 RVA: 0x0016987C File Offset: 0x00167A7C
		[NullableContext(1)]
		public FRootMotionSource_RadialForce(FVector Location, AActor LocationActor, float Radius, float Strength, bool bIsPush, bool bNoZForce, UCurveFloat StrengthDistanceFalloff, UCurveFloat StrengthOverTime, bool bUseFixedWorldDirection, FRotator FixedWorldDirection, ushort Priority, ushort LocalID, ERootMotionAccumulateMode AccumulateMode, FName InstanceName, float StartTime, float CurrentTime, float PreviousTime, float Duration, FRootMotionSourceStatus Status, FRootMotionSourceSettings Settings, bool bInLocalSpace, FRootMotionMovementParams RootMotionParams, FRootMotionFinishVelocitySettings FinishVelocityParams)
		{
			this.Location = Location;
			this.LocationActor = LocationActor;
			this.Radius = Radius;
			this.Strength = Strength;
			this.bIsPush = bIsPush;
			this.bNoZForce = bNoZForce;
			this.StrengthDistanceFalloff = StrengthDistanceFalloff;
			this.StrengthOverTime = StrengthOverTime;
			this.bUseFixedWorldDirection = bUseFixedWorldDirection;
			this.FixedWorldDirection = FixedWorldDirection;
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

		// Token: 0x0600F3CB RID: 62411 RVA: 0x00169944 File Offset: 0x00167B44
		protected override IntPtr GetUStructPtr()
		{
			return FRootMotionSource_RadialForce.StaticStruct();
		}

		// Token: 0x0600F3CC RID: 62412 RVA: 0x00169950 File Offset: 0x00167B50
		public FRootMotionSource_RadialForce(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F3CD RID: 62413 RVA: 0x0016995A File Offset: 0x00167B5A
		public FRootMotionSource_RadialForce(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F3CE RID: 62414 RVA: 0x00169965 File Offset: 0x00167B65
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRootMotionSource_RadialForce(Pointer, false, true);
		}

		// Token: 0x0600F3CF RID: 62415 RVA: 0x0016996F File Offset: 0x00167B6F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRootMotionSource_RadialForce(Pointer, MemoryOwner);
		}

		// Token: 0x0400841A RID: 33818
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.RootMotionSource_RadialForce";

		// Token: 0x0400841B RID: 33819
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400841C RID: 33820
		internal static int __PropertyOffset_Location;

		// Token: 0x0400841D RID: 33821
		internal static int __PropertyOffset_LocationActor;

		// Token: 0x0400841E RID: 33822
		internal static int __PropertyOffset_Radius;

		// Token: 0x0400841F RID: 33823
		internal static int __PropertyOffset_Strength;

		// Token: 0x04008420 RID: 33824
		internal static int __PropertyOffset_bIsPush;

		// Token: 0x04008421 RID: 33825
		internal static int __PropertyOffset_bNoZForce;

		// Token: 0x04008422 RID: 33826
		internal static int __PropertyOffset_StrengthDistanceFalloff;

		// Token: 0x04008423 RID: 33827
		internal static int __PropertyOffset_StrengthOverTime;

		// Token: 0x04008424 RID: 33828
		internal static int __PropertyOffset_bUseFixedWorldDirection;

		// Token: 0x04008425 RID: 33829
		internal static int __PropertyOffset_FixedWorldDirection;
	}
}
