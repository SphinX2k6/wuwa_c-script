using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007D9 RID: 2009
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AngularDriveConstraint")]
	[UnrealStructLayout(76, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 76)]
	public class FAngularDriveConstraint : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006B08 RID: 27400 RVA: 0x0009A25B File Offset: 0x0009845B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAngularDriveConstraint._ScriptStructPtr != 0) ? FAngularDriveConstraint._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AngularDriveConstraint", ref FAngularDriveConstraint._ScriptStructPtr);
		}

		// Token: 0x17001932 RID: 6450
		// (get) Token: 0x06006B09 RID: 27401 RVA: 0x0009A280 File Offset: 0x00098480
		// (set) Token: 0x06006B0A RID: 27402 RVA: 0x0009A2C3 File Offset: 0x000984C3
		public FConstraintDrive TwistDrive
		{
			get
			{
				base.FastCheckIsValid();
				FConstraintDrive result;
				if ((result = this._TwistDrive) == null)
				{
					result = (this._TwistDrive = new FConstraintDrive(base.NativePtr + (IntPtr)FAngularDriveConstraint.__PropertyOffset_TwistDrive, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FConstraintDrive.StaticStruct(), base.NativePtr + (IntPtr)FAngularDriveConstraint.__PropertyOffset_TwistDrive, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001933 RID: 6451
		// (get) Token: 0x06006B0B RID: 27403 RVA: 0x0009A2E4 File Offset: 0x000984E4
		// (set) Token: 0x06006B0C RID: 27404 RVA: 0x0009A327 File Offset: 0x00098527
		public FConstraintDrive SwingDrive
		{
			get
			{
				base.FastCheckIsValid();
				FConstraintDrive result;
				if ((result = this._SwingDrive) == null)
				{
					result = (this._SwingDrive = new FConstraintDrive(base.NativePtr + (IntPtr)FAngularDriveConstraint.__PropertyOffset_SwingDrive, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FConstraintDrive.StaticStruct(), base.NativePtr + (IntPtr)FAngularDriveConstraint.__PropertyOffset_SwingDrive, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001934 RID: 6452
		// (get) Token: 0x06006B0D RID: 27405 RVA: 0x0009A348 File Offset: 0x00098548
		// (set) Token: 0x06006B0E RID: 27406 RVA: 0x0009A38B File Offset: 0x0009858B
		public FConstraintDrive SlerpDrive
		{
			get
			{
				base.FastCheckIsValid();
				FConstraintDrive result;
				if ((result = this._SlerpDrive) == null)
				{
					result = (this._SlerpDrive = new FConstraintDrive(base.NativePtr + (IntPtr)FAngularDriveConstraint.__PropertyOffset_SlerpDrive, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FConstraintDrive.StaticStruct(), base.NativePtr + (IntPtr)FAngularDriveConstraint.__PropertyOffset_SlerpDrive, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001935 RID: 6453
		// (get) Token: 0x06006B0F RID: 27407 RVA: 0x0009A3AC File Offset: 0x000985AC
		// (set) Token: 0x06006B10 RID: 27408 RVA: 0x0009A3C0 File Offset: 0x000985C0
		public unsafe FRotator OrientationTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAngularDriveConstraint.__PropertyOffset_OrientationTarget);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAngularDriveConstraint.__PropertyOffset_OrientationTarget) = value;
			}
		}

		// Token: 0x17001936 RID: 6454
		// (get) Token: 0x06006B11 RID: 27409 RVA: 0x0009A3D5 File Offset: 0x000985D5
		// (set) Token: 0x06006B12 RID: 27410 RVA: 0x0009A3E9 File Offset: 0x000985E9
		public unsafe FVector AngularVelocityTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAngularDriveConstraint.__PropertyOffset_AngularVelocityTarget);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAngularDriveConstraint.__PropertyOffset_AngularVelocityTarget) = value;
			}
		}

		// Token: 0x17001937 RID: 6455
		// (get) Token: 0x06006B13 RID: 27411 RVA: 0x0009A3FE File Offset: 0x000985FE
		// (set) Token: 0x06006B14 RID: 27412 RVA: 0x0009A412 File Offset: 0x00098612
		[Nullable(0)]
		public unsafe TEnumAsByte<EAngularDriveMode> AngularDriveMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FAngularDriveConstraint.__PropertyOffset_AngularDriveMode);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FAngularDriveConstraint.__PropertyOffset_AngularDriveMode) = value;
			}
		}

		// Token: 0x06006B15 RID: 27413 RVA: 0x0009A427 File Offset: 0x00098627
		public FAngularDriveConstraint()
		{
		}

		// Token: 0x06006B16 RID: 27414 RVA: 0x0009A42F File Offset: 0x0009862F
		public FAngularDriveConstraint(FConstraintDrive TwistDrive, FConstraintDrive SwingDrive, FConstraintDrive SlerpDrive, FRotator OrientationTarget, FVector AngularVelocityTarget, [Nullable(0)] TEnumAsByte<EAngularDriveMode> AngularDriveMode)
		{
			this.TwistDrive = TwistDrive;
			this.SwingDrive = SwingDrive;
			this.SlerpDrive = SlerpDrive;
			this.OrientationTarget = OrientationTarget;
			this.AngularVelocityTarget = AngularVelocityTarget;
			this.AngularDriveMode = AngularDriveMode;
		}

		// Token: 0x06006B17 RID: 27415 RVA: 0x0009A464 File Offset: 0x00098664
		protected override IntPtr GetUStructPtr()
		{
			return FAngularDriveConstraint.StaticStruct();
		}

		// Token: 0x06006B18 RID: 27416 RVA: 0x0009A470 File Offset: 0x00098670
		[NullableContext(2)]
		public FAngularDriveConstraint(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006B19 RID: 27417 RVA: 0x0009A47A File Offset: 0x0009867A
		public FAngularDriveConstraint(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006B1A RID: 27418 RVA: 0x0009A485 File Offset: 0x00098685
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAngularDriveConstraint(Pointer, false, true);
		}

		// Token: 0x06006B1B RID: 27419 RVA: 0x0009A48F File Offset: 0x0009868F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAngularDriveConstraint(Pointer, MemoryOwner);
		}

		// Token: 0x0400337F RID: 13183
		public const string __ObjectPath = "/Script/Engine.AngularDriveConstraint";

		// Token: 0x04003380 RID: 13184
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003381 RID: 13185
		internal static int __PropertyOffset_TwistDrive;

		// Token: 0x04003382 RID: 13186
		[Nullable(2)]
		private FConstraintDrive _TwistDrive;

		// Token: 0x04003383 RID: 13187
		internal static int __PropertyOffset_SwingDrive;

		// Token: 0x04003384 RID: 13188
		[Nullable(2)]
		private FConstraintDrive _SwingDrive;

		// Token: 0x04003385 RID: 13189
		internal static int __PropertyOffset_SlerpDrive;

		// Token: 0x04003386 RID: 13190
		[Nullable(2)]
		private FConstraintDrive _SlerpDrive;

		// Token: 0x04003387 RID: 13191
		internal static int __PropertyOffset_OrientationTarget;

		// Token: 0x04003388 RID: 13192
		internal static int __PropertyOffset_AngularVelocityTarget;

		// Token: 0x04003389 RID: 13193
		internal static int __PropertyOffset_AngularDriveMode;
	}
}
