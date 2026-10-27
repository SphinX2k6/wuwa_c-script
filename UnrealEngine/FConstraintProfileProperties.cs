using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000973 RID: 2419
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ConstraintProfileProperties")]
	[UnrealStructLayout(268, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 268)]
	public class FConstraintProfileProperties : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008896 RID: 34966 RVA: 0x000C3AE8 File Offset: 0x000C1CE8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FConstraintProfileProperties._ScriptStructPtr != 0) ? FConstraintProfileProperties._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ConstraintProfileProperties", ref FConstraintProfileProperties._ScriptStructPtr);
		}

		// Token: 0x1700203E RID: 8254
		// (get) Token: 0x06008897 RID: 34967 RVA: 0x000C3B0C File Offset: 0x000C1D0C
		// (set) Token: 0x06008898 RID: 34968 RVA: 0x000C3B1C File Offset: 0x000C1D1C
		public unsafe float ProjectionLinearTolerance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConstraintProfileProperties.__PropertyOffset_ProjectionLinearTolerance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstraintProfileProperties.__PropertyOffset_ProjectionLinearTolerance) = value;
			}
		}

		// Token: 0x1700203F RID: 8255
		// (get) Token: 0x06008899 RID: 34969 RVA: 0x000C3B2D File Offset: 0x000C1D2D
		// (set) Token: 0x0600889A RID: 34970 RVA: 0x000C3B3D File Offset: 0x000C1D3D
		public unsafe float ProjectionAngularTolerance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConstraintProfileProperties.__PropertyOffset_ProjectionAngularTolerance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstraintProfileProperties.__PropertyOffset_ProjectionAngularTolerance) = value;
			}
		}

		// Token: 0x17002040 RID: 8256
		// (get) Token: 0x0600889B RID: 34971 RVA: 0x000C3B4E File Offset: 0x000C1D4E
		// (set) Token: 0x0600889C RID: 34972 RVA: 0x000C3B5E File Offset: 0x000C1D5E
		public unsafe float ProjectionLinearAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConstraintProfileProperties.__PropertyOffset_ProjectionLinearAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstraintProfileProperties.__PropertyOffset_ProjectionLinearAlpha) = value;
			}
		}

		// Token: 0x17002041 RID: 8257
		// (get) Token: 0x0600889D RID: 34973 RVA: 0x000C3B6F File Offset: 0x000C1D6F
		// (set) Token: 0x0600889E RID: 34974 RVA: 0x000C3B7F File Offset: 0x000C1D7F
		public unsafe float ProjectionAngularAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConstraintProfileProperties.__PropertyOffset_ProjectionAngularAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstraintProfileProperties.__PropertyOffset_ProjectionAngularAlpha) = value;
			}
		}

		// Token: 0x17002042 RID: 8258
		// (get) Token: 0x0600889F RID: 34975 RVA: 0x000C3B90 File Offset: 0x000C1D90
		// (set) Token: 0x060088A0 RID: 34976 RVA: 0x000C3BA0 File Offset: 0x000C1DA0
		public unsafe float LinearBreakThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConstraintProfileProperties.__PropertyOffset_LinearBreakThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstraintProfileProperties.__PropertyOffset_LinearBreakThreshold) = value;
			}
		}

		// Token: 0x17002043 RID: 8259
		// (get) Token: 0x060088A1 RID: 34977 RVA: 0x000C3BB1 File Offset: 0x000C1DB1
		// (set) Token: 0x060088A2 RID: 34978 RVA: 0x000C3BC1 File Offset: 0x000C1DC1
		public unsafe float AngularBreakThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConstraintProfileProperties.__PropertyOffset_AngularBreakThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstraintProfileProperties.__PropertyOffset_AngularBreakThreshold) = value;
			}
		}

		// Token: 0x17002044 RID: 8260
		// (get) Token: 0x060088A3 RID: 34979 RVA: 0x000C3BD4 File Offset: 0x000C1DD4
		// (set) Token: 0x060088A4 RID: 34980 RVA: 0x000C3C17 File Offset: 0x000C1E17
		public FLinearConstraint LinearLimit
		{
			get
			{
				base.FastCheckIsValid();
				FLinearConstraint result;
				if ((result = this._LinearLimit) == null)
				{
					result = (this._LinearLimit = new FLinearConstraint(base.NativePtr + (IntPtr)FConstraintProfileProperties.__PropertyOffset_LinearLimit, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLinearConstraint.StaticStruct(), base.NativePtr + (IntPtr)FConstraintProfileProperties.__PropertyOffset_LinearLimit, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002045 RID: 8261
		// (get) Token: 0x060088A5 RID: 34981 RVA: 0x000C3C38 File Offset: 0x000C1E38
		// (set) Token: 0x060088A6 RID: 34982 RVA: 0x000C3C7B File Offset: 0x000C1E7B
		public FConeConstraint ConeLimit
		{
			get
			{
				base.FastCheckIsValid();
				FConeConstraint result;
				if ((result = this._ConeLimit) == null)
				{
					result = (this._ConeLimit = new FConeConstraint(base.NativePtr + (IntPtr)FConstraintProfileProperties.__PropertyOffset_ConeLimit, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FConeConstraint.StaticStruct(), base.NativePtr + (IntPtr)FConstraintProfileProperties.__PropertyOffset_ConeLimit, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002046 RID: 8262
		// (get) Token: 0x060088A7 RID: 34983 RVA: 0x000C3C9C File Offset: 0x000C1E9C
		// (set) Token: 0x060088A8 RID: 34984 RVA: 0x000C3CDF File Offset: 0x000C1EDF
		public FTwistConstraint TwistLimit
		{
			get
			{
				base.FastCheckIsValid();
				FTwistConstraint result;
				if ((result = this._TwistLimit) == null)
				{
					result = (this._TwistLimit = new FTwistConstraint(base.NativePtr + (IntPtr)FConstraintProfileProperties.__PropertyOffset_TwistLimit, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTwistConstraint.StaticStruct(), base.NativePtr + (IntPtr)FConstraintProfileProperties.__PropertyOffset_TwistLimit, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002047 RID: 8263
		// (get) Token: 0x060088A9 RID: 34985 RVA: 0x000C3D00 File Offset: 0x000C1F00
		// (set) Token: 0x060088AA RID: 34986 RVA: 0x000C3D43 File Offset: 0x000C1F43
		public FLinearDriveConstraint LinearDrive
		{
			get
			{
				base.FastCheckIsValid();
				FLinearDriveConstraint result;
				if ((result = this._LinearDrive) == null)
				{
					result = (this._LinearDrive = new FLinearDriveConstraint(base.NativePtr + (IntPtr)FConstraintProfileProperties.__PropertyOffset_LinearDrive, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLinearDriveConstraint.StaticStruct(), base.NativePtr + (IntPtr)FConstraintProfileProperties.__PropertyOffset_LinearDrive, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002048 RID: 8264
		// (get) Token: 0x060088AB RID: 34987 RVA: 0x000C3D64 File Offset: 0x000C1F64
		// (set) Token: 0x060088AC RID: 34988 RVA: 0x000C3DA7 File Offset: 0x000C1FA7
		public FAngularDriveConstraint AngularDrive
		{
			get
			{
				base.FastCheckIsValid();
				FAngularDriveConstraint result;
				if ((result = this._AngularDrive) == null)
				{
					result = (this._AngularDrive = new FAngularDriveConstraint(base.NativePtr + (IntPtr)FConstraintProfileProperties.__PropertyOffset_AngularDrive, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAngularDriveConstraint.StaticStruct(), base.NativePtr + (IntPtr)FConstraintProfileProperties.__PropertyOffset_AngularDrive, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002049 RID: 8265
		// (get) Token: 0x060088AD RID: 34989 RVA: 0x000C3DC8 File Offset: 0x000C1FC8
		// (set) Token: 0x060088AE RID: 34990 RVA: 0x000C3DE1 File Offset: 0x000C1FE1
		public unsafe bool bDisableCollision
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FConstraintProfileProperties.__PropertyOffset_bDisableCollision) & FConstraintProfileProperties.__PropertyMask_bDisableCollision) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FConstraintProfileProperties.__PropertyOffset_bDisableCollision) = ((*(base.NativePtr + (IntPtr)FConstraintProfileProperties.__PropertyOffset_bDisableCollision) & ~FConstraintProfileProperties.__PropertyMask_bDisableCollision) | (value ? FConstraintProfileProperties.__PropertyMask_bDisableCollision : 0));
			}
		}

		// Token: 0x1700204A RID: 8266
		// (get) Token: 0x060088AF RID: 34991 RVA: 0x000C3E11 File Offset: 0x000C2011
		// (set) Token: 0x060088B0 RID: 34992 RVA: 0x000C3E2A File Offset: 0x000C202A
		public unsafe bool bParentDominates
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FConstraintProfileProperties.__PropertyOffset_bParentDominates) & FConstraintProfileProperties.__PropertyMask_bParentDominates) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FConstraintProfileProperties.__PropertyOffset_bParentDominates) = ((*(base.NativePtr + (IntPtr)FConstraintProfileProperties.__PropertyOffset_bParentDominates) & ~FConstraintProfileProperties.__PropertyMask_bParentDominates) | (value ? FConstraintProfileProperties.__PropertyMask_bParentDominates : 0));
			}
		}

		// Token: 0x1700204B RID: 8267
		// (get) Token: 0x060088B1 RID: 34993 RVA: 0x000C3E5A File Offset: 0x000C205A
		// (set) Token: 0x060088B2 RID: 34994 RVA: 0x000C3E73 File Offset: 0x000C2073
		public unsafe bool bEnableProjection
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FConstraintProfileProperties.__PropertyOffset_bEnableProjection) & FConstraintProfileProperties.__PropertyMask_bEnableProjection) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FConstraintProfileProperties.__PropertyOffset_bEnableProjection) = ((*(base.NativePtr + (IntPtr)FConstraintProfileProperties.__PropertyOffset_bEnableProjection) & ~FConstraintProfileProperties.__PropertyMask_bEnableProjection) | (value ? FConstraintProfileProperties.__PropertyMask_bEnableProjection : 0));
			}
		}

		// Token: 0x1700204C RID: 8268
		// (get) Token: 0x060088B3 RID: 34995 RVA: 0x000C3EA3 File Offset: 0x000C20A3
		// (set) Token: 0x060088B4 RID: 34996 RVA: 0x000C3EBC File Offset: 0x000C20BC
		public unsafe bool bEnableSoftProjection
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FConstraintProfileProperties.__PropertyOffset_bEnableSoftProjection) & FConstraintProfileProperties.__PropertyMask_bEnableSoftProjection) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FConstraintProfileProperties.__PropertyOffset_bEnableSoftProjection) = ((*(base.NativePtr + (IntPtr)FConstraintProfileProperties.__PropertyOffset_bEnableSoftProjection) & ~FConstraintProfileProperties.__PropertyMask_bEnableSoftProjection) | (value ? FConstraintProfileProperties.__PropertyMask_bEnableSoftProjection : 0));
			}
		}

		// Token: 0x1700204D RID: 8269
		// (get) Token: 0x060088B5 RID: 34997 RVA: 0x000C3EEC File Offset: 0x000C20EC
		// (set) Token: 0x060088B6 RID: 34998 RVA: 0x000C3F05 File Offset: 0x000C2105
		public unsafe bool bAngularBreakable
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FConstraintProfileProperties.__PropertyOffset_bAngularBreakable) & FConstraintProfileProperties.__PropertyMask_bAngularBreakable) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FConstraintProfileProperties.__PropertyOffset_bAngularBreakable) = ((*(base.NativePtr + (IntPtr)FConstraintProfileProperties.__PropertyOffset_bAngularBreakable) & ~FConstraintProfileProperties.__PropertyMask_bAngularBreakable) | (value ? FConstraintProfileProperties.__PropertyMask_bAngularBreakable : 0));
			}
		}

		// Token: 0x1700204E RID: 8270
		// (get) Token: 0x060088B7 RID: 34999 RVA: 0x000C3F35 File Offset: 0x000C2135
		// (set) Token: 0x060088B8 RID: 35000 RVA: 0x000C3F4E File Offset: 0x000C214E
		public unsafe bool bLinearBreakable
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FConstraintProfileProperties.__PropertyOffset_bLinearBreakable) & FConstraintProfileProperties.__PropertyMask_bLinearBreakable) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FConstraintProfileProperties.__PropertyOffset_bLinearBreakable) = ((*(base.NativePtr + (IntPtr)FConstraintProfileProperties.__PropertyOffset_bLinearBreakable) & ~FConstraintProfileProperties.__PropertyMask_bLinearBreakable) | (value ? FConstraintProfileProperties.__PropertyMask_bLinearBreakable : 0));
			}
		}

		// Token: 0x060088B9 RID: 35001 RVA: 0x000C3F7E File Offset: 0x000C217E
		public FConstraintProfileProperties()
		{
		}

		// Token: 0x060088BA RID: 35002 RVA: 0x000C3F88 File Offset: 0x000C2188
		public FConstraintProfileProperties(float ProjectionLinearTolerance, float ProjectionAngularTolerance, float ProjectionLinearAlpha, float ProjectionAngularAlpha, float LinearBreakThreshold, float AngularBreakThreshold, FLinearConstraint LinearLimit, FConeConstraint ConeLimit, FTwistConstraint TwistLimit, FLinearDriveConstraint LinearDrive, FAngularDriveConstraint AngularDrive, bool bDisableCollision, bool bParentDominates, bool bEnableProjection, bool bEnableSoftProjection, bool bAngularBreakable, bool bLinearBreakable)
		{
			this.ProjectionLinearTolerance = ProjectionLinearTolerance;
			this.ProjectionAngularTolerance = ProjectionAngularTolerance;
			this.ProjectionLinearAlpha = ProjectionLinearAlpha;
			this.ProjectionAngularAlpha = ProjectionAngularAlpha;
			this.LinearBreakThreshold = LinearBreakThreshold;
			this.AngularBreakThreshold = AngularBreakThreshold;
			this.LinearLimit = LinearLimit;
			this.ConeLimit = ConeLimit;
			this.TwistLimit = TwistLimit;
			this.LinearDrive = LinearDrive;
			this.AngularDrive = AngularDrive;
			this.bDisableCollision = bDisableCollision;
			this.bParentDominates = bParentDominates;
			this.bEnableProjection = bEnableProjection;
			this.bEnableSoftProjection = bEnableSoftProjection;
			this.bAngularBreakable = bAngularBreakable;
			this.bLinearBreakable = bLinearBreakable;
		}

		// Token: 0x060088BB RID: 35003 RVA: 0x000C4020 File Offset: 0x000C2220
		protected override IntPtr GetUStructPtr()
		{
			return FConstraintProfileProperties.StaticStruct();
		}

		// Token: 0x060088BC RID: 35004 RVA: 0x000C402C File Offset: 0x000C222C
		[NullableContext(2)]
		public FConstraintProfileProperties(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060088BD RID: 35005 RVA: 0x000C4036 File Offset: 0x000C2236
		public FConstraintProfileProperties(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060088BE RID: 35006 RVA: 0x000C4041 File Offset: 0x000C2241
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FConstraintProfileProperties(Pointer, false, true);
		}

		// Token: 0x060088BF RID: 35007 RVA: 0x000C404B File Offset: 0x000C224B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FConstraintProfileProperties(Pointer, MemoryOwner);
		}

		// Token: 0x040040EC RID: 16620
		public const string __ObjectPath = "/Script/Engine.ConstraintProfileProperties";

		// Token: 0x040040ED RID: 16621
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040040EE RID: 16622
		internal static int __PropertyOffset_ProjectionLinearTolerance;

		// Token: 0x040040EF RID: 16623
		internal static int __PropertyOffset_ProjectionAngularTolerance;

		// Token: 0x040040F0 RID: 16624
		internal static int __PropertyOffset_ProjectionLinearAlpha;

		// Token: 0x040040F1 RID: 16625
		internal static int __PropertyOffset_ProjectionAngularAlpha;

		// Token: 0x040040F2 RID: 16626
		internal static int __PropertyOffset_LinearBreakThreshold;

		// Token: 0x040040F3 RID: 16627
		internal static int __PropertyOffset_AngularBreakThreshold;

		// Token: 0x040040F4 RID: 16628
		internal static int __PropertyOffset_LinearLimit;

		// Token: 0x040040F5 RID: 16629
		[Nullable(2)]
		private FLinearConstraint _LinearLimit;

		// Token: 0x040040F6 RID: 16630
		internal static int __PropertyOffset_ConeLimit;

		// Token: 0x040040F7 RID: 16631
		[Nullable(2)]
		private FConeConstraint _ConeLimit;

		// Token: 0x040040F8 RID: 16632
		internal static int __PropertyOffset_TwistLimit;

		// Token: 0x040040F9 RID: 16633
		[Nullable(2)]
		private FTwistConstraint _TwistLimit;

		// Token: 0x040040FA RID: 16634
		internal static int __PropertyOffset_LinearDrive;

		// Token: 0x040040FB RID: 16635
		[Nullable(2)]
		private FLinearDriveConstraint _LinearDrive;

		// Token: 0x040040FC RID: 16636
		internal static int __PropertyOffset_AngularDrive;

		// Token: 0x040040FD RID: 16637
		[Nullable(2)]
		private FAngularDriveConstraint _AngularDrive;

		// Token: 0x040040FE RID: 16638
		internal static int __PropertyOffset_bDisableCollision;

		// Token: 0x040040FF RID: 16639
		internal static byte __PropertyMask_bDisableCollision;

		// Token: 0x04004100 RID: 16640
		internal static int __PropertyOffset_bParentDominates;

		// Token: 0x04004101 RID: 16641
		internal static byte __PropertyMask_bParentDominates;

		// Token: 0x04004102 RID: 16642
		internal static int __PropertyOffset_bEnableProjection;

		// Token: 0x04004103 RID: 16643
		internal static byte __PropertyMask_bEnableProjection;

		// Token: 0x04004104 RID: 16644
		internal static int __PropertyOffset_bEnableSoftProjection;

		// Token: 0x04004105 RID: 16645
		internal static byte __PropertyMask_bEnableSoftProjection;

		// Token: 0x04004106 RID: 16646
		internal static int __PropertyOffset_bAngularBreakable;

		// Token: 0x04004107 RID: 16647
		internal static byte __PropertyMask_bAngularBreakable;

		// Token: 0x04004108 RID: 16648
		internal static int __PropertyOffset_bLinearBreakable;

		// Token: 0x04004109 RID: 16649
		internal static byte __PropertyMask_bLinearBreakable;
	}
}
