using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010A3 RID: 4259
	[UnrealObjectPath("/Script/Engine.RootMotionSource_ConstantForce")]
	[UnrealStructLayout(176, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 176)]
	public class FRootMotionSource_ConstantForce : FRootMotionSource, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F370 RID: 62320 RVA: 0x0016902E File Offset: 0x0016722E
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRootMotionSource_ConstantForce._ScriptStructPtr != 0) ? FRootMotionSource_ConstantForce._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RootMotionSource_ConstantForce", ref FRootMotionSource_ConstantForce._ScriptStructPtr);
		}

		// Token: 0x17003B4A RID: 15178
		// (get) Token: 0x0600F371 RID: 62321 RVA: 0x00169052 File Offset: 0x00167252
		// (set) Token: 0x0600F372 RID: 62322 RVA: 0x00169066 File Offset: 0x00167266
		public unsafe FVector Force
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRootMotionSource_ConstantForce.__PropertyOffset_Force);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionSource_ConstantForce.__PropertyOffset_Force) = value;
			}
		}

		// Token: 0x17003B4B RID: 15179
		// (get) Token: 0x0600F373 RID: 62323 RVA: 0x0016907B File Offset: 0x0016727B
		// (set) Token: 0x0600F374 RID: 62324 RVA: 0x0016908F File Offset: 0x0016728F
		[Nullable(2)]
		public unsafe UCurveFloat StrengthOverTime
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FRootMotionSource_ConstantForce.__PropertyOffset_StrengthOverTime);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FRootMotionSource_ConstantForce.__PropertyOffset_StrengthOverTime, value);
			}
		}

		// Token: 0x0600F375 RID: 62325 RVA: 0x001690A4 File Offset: 0x001672A4
		public FRootMotionSource_ConstantForce()
		{
		}

		// Token: 0x0600F376 RID: 62326 RVA: 0x001690AC File Offset: 0x001672AC
		[NullableContext(1)]
		public FRootMotionSource_ConstantForce(FVector Force, UCurveFloat StrengthOverTime, ushort Priority, ushort LocalID, ERootMotionAccumulateMode AccumulateMode, FName InstanceName, float StartTime, float CurrentTime, float PreviousTime, float Duration, FRootMotionSourceStatus Status, FRootMotionSourceSettings Settings, bool bInLocalSpace, FRootMotionMovementParams RootMotionParams, FRootMotionFinishVelocitySettings FinishVelocityParams)
		{
			this.Force = Force;
			this.StrengthOverTime = StrengthOverTime;
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

		// Token: 0x0600F377 RID: 62327 RVA: 0x00169134 File Offset: 0x00167334
		protected override IntPtr GetUStructPtr()
		{
			return FRootMotionSource_ConstantForce.StaticStruct();
		}

		// Token: 0x0600F378 RID: 62328 RVA: 0x00169140 File Offset: 0x00167340
		[NullableContext(2)]
		public FRootMotionSource_ConstantForce(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F379 RID: 62329 RVA: 0x0016914A File Offset: 0x0016734A
		public FRootMotionSource_ConstantForce(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F37A RID: 62330 RVA: 0x00169155 File Offset: 0x00167355
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRootMotionSource_ConstantForce(Pointer, false, true);
		}

		// Token: 0x0600F37B RID: 62331 RVA: 0x0016915F File Offset: 0x0016735F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRootMotionSource_ConstantForce(Pointer, MemoryOwner);
		}

		// Token: 0x04008400 RID: 33792
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.RootMotionSource_ConstantForce";

		// Token: 0x04008401 RID: 33793
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008402 RID: 33794
		internal static int __PropertyOffset_Force;

		// Token: 0x04008403 RID: 33795
		internal static int __PropertyOffset_StrengthOverTime;
	}
}
