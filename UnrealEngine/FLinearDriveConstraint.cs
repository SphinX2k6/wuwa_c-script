using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D5C RID: 3420
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.LinearDriveConstraint")]
	[UnrealStructLayout(76, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 76)]
	public class FLinearDriveConstraint : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B8B6 RID: 47286 RVA: 0x00106E5C File Offset: 0x0010505C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLinearDriveConstraint._ScriptStructPtr != 0) ? FLinearDriveConstraint._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.LinearDriveConstraint", ref FLinearDriveConstraint._ScriptStructPtr);
		}

		// Token: 0x17002A4F RID: 10831
		// (get) Token: 0x0600B8B7 RID: 47287 RVA: 0x00106E80 File Offset: 0x00105080
		// (set) Token: 0x0600B8B8 RID: 47288 RVA: 0x00106E94 File Offset: 0x00105094
		public unsafe FVector PositionTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLinearDriveConstraint.__PropertyOffset_PositionTarget);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLinearDriveConstraint.__PropertyOffset_PositionTarget) = value;
			}
		}

		// Token: 0x17002A50 RID: 10832
		// (get) Token: 0x0600B8B9 RID: 47289 RVA: 0x00106EA9 File Offset: 0x001050A9
		// (set) Token: 0x0600B8BA RID: 47290 RVA: 0x00106EBD File Offset: 0x001050BD
		public unsafe FVector VelocityTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLinearDriveConstraint.__PropertyOffset_VelocityTarget);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLinearDriveConstraint.__PropertyOffset_VelocityTarget) = value;
			}
		}

		// Token: 0x17002A51 RID: 10833
		// (get) Token: 0x0600B8BB RID: 47291 RVA: 0x00106ED4 File Offset: 0x001050D4
		// (set) Token: 0x0600B8BC RID: 47292 RVA: 0x00106F17 File Offset: 0x00105117
		public FConstraintDrive XDrive
		{
			get
			{
				base.FastCheckIsValid();
				FConstraintDrive result;
				if ((result = this._XDrive) == null)
				{
					result = (this._XDrive = new FConstraintDrive(base.NativePtr + (IntPtr)FLinearDriveConstraint.__PropertyOffset_XDrive, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FConstraintDrive.StaticStruct(), base.NativePtr + (IntPtr)FLinearDriveConstraint.__PropertyOffset_XDrive, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002A52 RID: 10834
		// (get) Token: 0x0600B8BD RID: 47293 RVA: 0x00106F38 File Offset: 0x00105138
		// (set) Token: 0x0600B8BE RID: 47294 RVA: 0x00106F7B File Offset: 0x0010517B
		public FConstraintDrive YDrive
		{
			get
			{
				base.FastCheckIsValid();
				FConstraintDrive result;
				if ((result = this._YDrive) == null)
				{
					result = (this._YDrive = new FConstraintDrive(base.NativePtr + (IntPtr)FLinearDriveConstraint.__PropertyOffset_YDrive, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FConstraintDrive.StaticStruct(), base.NativePtr + (IntPtr)FLinearDriveConstraint.__PropertyOffset_YDrive, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002A53 RID: 10835
		// (get) Token: 0x0600B8BF RID: 47295 RVA: 0x00106F9C File Offset: 0x0010519C
		// (set) Token: 0x0600B8C0 RID: 47296 RVA: 0x00106FDF File Offset: 0x001051DF
		public FConstraintDrive ZDrive
		{
			get
			{
				base.FastCheckIsValid();
				FConstraintDrive result;
				if ((result = this._ZDrive) == null)
				{
					result = (this._ZDrive = new FConstraintDrive(base.NativePtr + (IntPtr)FLinearDriveConstraint.__PropertyOffset_ZDrive, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FConstraintDrive.StaticStruct(), base.NativePtr + (IntPtr)FLinearDriveConstraint.__PropertyOffset_ZDrive, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002A54 RID: 10836
		// (get) Token: 0x0600B8C1 RID: 47297 RVA: 0x00107000 File Offset: 0x00105200
		// (set) Token: 0x0600B8C2 RID: 47298 RVA: 0x00107019 File Offset: 0x00105219
		public unsafe bool bEnablePositionDrive
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLinearDriveConstraint.__PropertyOffset_bEnablePositionDrive) & FLinearDriveConstraint.__PropertyMask_bEnablePositionDrive) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLinearDriveConstraint.__PropertyOffset_bEnablePositionDrive) = ((*(base.NativePtr + (IntPtr)FLinearDriveConstraint.__PropertyOffset_bEnablePositionDrive) & ~FLinearDriveConstraint.__PropertyMask_bEnablePositionDrive) | (value ? FLinearDriveConstraint.__PropertyMask_bEnablePositionDrive : 0));
			}
		}

		// Token: 0x0600B8C3 RID: 47299 RVA: 0x00107049 File Offset: 0x00105249
		public FLinearDriveConstraint()
		{
		}

		// Token: 0x0600B8C4 RID: 47300 RVA: 0x00107051 File Offset: 0x00105251
		public FLinearDriveConstraint(FVector PositionTarget, FVector VelocityTarget, FConstraintDrive XDrive, FConstraintDrive YDrive, FConstraintDrive ZDrive, bool bEnablePositionDrive)
		{
			this.PositionTarget = PositionTarget;
			this.VelocityTarget = VelocityTarget;
			this.XDrive = XDrive;
			this.YDrive = YDrive;
			this.ZDrive = ZDrive;
			this.bEnablePositionDrive = bEnablePositionDrive;
		}

		// Token: 0x0600B8C5 RID: 47301 RVA: 0x00107086 File Offset: 0x00105286
		protected override IntPtr GetUStructPtr()
		{
			return FLinearDriveConstraint.StaticStruct();
		}

		// Token: 0x0600B8C6 RID: 47302 RVA: 0x00107092 File Offset: 0x00105292
		[NullableContext(2)]
		public FLinearDriveConstraint(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B8C7 RID: 47303 RVA: 0x0010709C File Offset: 0x0010529C
		public FLinearDriveConstraint(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B8C8 RID: 47304 RVA: 0x001070A7 File Offset: 0x001052A7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLinearDriveConstraint(Pointer, false, true);
		}

		// Token: 0x0600B8C9 RID: 47305 RVA: 0x001070B1 File Offset: 0x001052B1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLinearDriveConstraint(Pointer, MemoryOwner);
		}

		// Token: 0x040060CC RID: 24780
		public const string __ObjectPath = "/Script/Engine.LinearDriveConstraint";

		// Token: 0x040060CD RID: 24781
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040060CE RID: 24782
		internal static int __PropertyOffset_PositionTarget;

		// Token: 0x040060CF RID: 24783
		internal static int __PropertyOffset_VelocityTarget;

		// Token: 0x040060D0 RID: 24784
		internal static int __PropertyOffset_XDrive;

		// Token: 0x040060D1 RID: 24785
		[Nullable(2)]
		private FConstraintDrive _XDrive;

		// Token: 0x040060D2 RID: 24786
		internal static int __PropertyOffset_YDrive;

		// Token: 0x040060D3 RID: 24787
		[Nullable(2)]
		private FConstraintDrive _YDrive;

		// Token: 0x040060D4 RID: 24788
		internal static int __PropertyOffset_ZDrive;

		// Token: 0x040060D5 RID: 24789
		[Nullable(2)]
		private FConstraintDrive _ZDrive;

		// Token: 0x040060D6 RID: 24790
		internal static int __PropertyOffset_bEnablePositionDrive;

		// Token: 0x040060D7 RID: 24791
		internal static byte __PropertyMask_bEnablePositionDrive;
	}
}
