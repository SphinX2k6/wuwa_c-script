using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001097 RID: 4247
	[UnrealObjectPath("/Script/Engine.RigidBodyErrorCorrection")]
	[UnrealStructLayout(52, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 52)]
	public class FRigidBodyErrorCorrection : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F2A6 RID: 62118 RVA: 0x00168017 File Offset: 0x00166217
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigidBodyErrorCorrection._ScriptStructPtr != 0) ? FRigidBodyErrorCorrection._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RigidBodyErrorCorrection", ref FRigidBodyErrorCorrection._ScriptStructPtr);
		}

		// Token: 0x17003B13 RID: 15123
		// (get) Token: 0x0600F2A7 RID: 62119 RVA: 0x0016803B File Offset: 0x0016623B
		// (set) Token: 0x0600F2A8 RID: 62120 RVA: 0x0016804B File Offset: 0x0016624B
		public unsafe float PingExtrapolation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigidBodyErrorCorrection.__PropertyOffset_PingExtrapolation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigidBodyErrorCorrection.__PropertyOffset_PingExtrapolation) = value;
			}
		}

		// Token: 0x17003B14 RID: 15124
		// (get) Token: 0x0600F2A9 RID: 62121 RVA: 0x0016805C File Offset: 0x0016625C
		// (set) Token: 0x0600F2AA RID: 62122 RVA: 0x0016806C File Offset: 0x0016626C
		public unsafe float PingLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigidBodyErrorCorrection.__PropertyOffset_PingLimit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigidBodyErrorCorrection.__PropertyOffset_PingLimit) = value;
			}
		}

		// Token: 0x17003B15 RID: 15125
		// (get) Token: 0x0600F2AB RID: 62123 RVA: 0x0016807D File Offset: 0x0016627D
		// (set) Token: 0x0600F2AC RID: 62124 RVA: 0x0016808D File Offset: 0x0016628D
		public unsafe float ErrorPerLinearDifference
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigidBodyErrorCorrection.__PropertyOffset_ErrorPerLinearDifference);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigidBodyErrorCorrection.__PropertyOffset_ErrorPerLinearDifference) = value;
			}
		}

		// Token: 0x17003B16 RID: 15126
		// (get) Token: 0x0600F2AD RID: 62125 RVA: 0x0016809E File Offset: 0x0016629E
		// (set) Token: 0x0600F2AE RID: 62126 RVA: 0x001680AE File Offset: 0x001662AE
		public unsafe float ErrorPerAngularDifference
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigidBodyErrorCorrection.__PropertyOffset_ErrorPerAngularDifference);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigidBodyErrorCorrection.__PropertyOffset_ErrorPerAngularDifference) = value;
			}
		}

		// Token: 0x17003B17 RID: 15127
		// (get) Token: 0x0600F2AF RID: 62127 RVA: 0x001680BF File Offset: 0x001662BF
		// (set) Token: 0x0600F2B0 RID: 62128 RVA: 0x001680CF File Offset: 0x001662CF
		public unsafe float MaxRestoredStateError
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigidBodyErrorCorrection.__PropertyOffset_MaxRestoredStateError);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigidBodyErrorCorrection.__PropertyOffset_MaxRestoredStateError) = value;
			}
		}

		// Token: 0x17003B18 RID: 15128
		// (get) Token: 0x0600F2B1 RID: 62129 RVA: 0x001680E0 File Offset: 0x001662E0
		// (set) Token: 0x0600F2B2 RID: 62130 RVA: 0x001680F0 File Offset: 0x001662F0
		public unsafe float MaxLinearHardSnapDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigidBodyErrorCorrection.__PropertyOffset_MaxLinearHardSnapDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigidBodyErrorCorrection.__PropertyOffset_MaxLinearHardSnapDistance) = value;
			}
		}

		// Token: 0x17003B19 RID: 15129
		// (get) Token: 0x0600F2B3 RID: 62131 RVA: 0x00168101 File Offset: 0x00166301
		// (set) Token: 0x0600F2B4 RID: 62132 RVA: 0x00168111 File Offset: 0x00166311
		public unsafe float PositionLerp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigidBodyErrorCorrection.__PropertyOffset_PositionLerp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigidBodyErrorCorrection.__PropertyOffset_PositionLerp) = value;
			}
		}

		// Token: 0x17003B1A RID: 15130
		// (get) Token: 0x0600F2B5 RID: 62133 RVA: 0x00168122 File Offset: 0x00166322
		// (set) Token: 0x0600F2B6 RID: 62134 RVA: 0x00168132 File Offset: 0x00166332
		public unsafe float AngleLerp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigidBodyErrorCorrection.__PropertyOffset_AngleLerp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigidBodyErrorCorrection.__PropertyOffset_AngleLerp) = value;
			}
		}

		// Token: 0x17003B1B RID: 15131
		// (get) Token: 0x0600F2B7 RID: 62135 RVA: 0x00168143 File Offset: 0x00166343
		// (set) Token: 0x0600F2B8 RID: 62136 RVA: 0x00168153 File Offset: 0x00166353
		public unsafe float LinearVelocityCoefficient
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigidBodyErrorCorrection.__PropertyOffset_LinearVelocityCoefficient);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigidBodyErrorCorrection.__PropertyOffset_LinearVelocityCoefficient) = value;
			}
		}

		// Token: 0x17003B1C RID: 15132
		// (get) Token: 0x0600F2B9 RID: 62137 RVA: 0x00168164 File Offset: 0x00166364
		// (set) Token: 0x0600F2BA RID: 62138 RVA: 0x00168174 File Offset: 0x00166374
		public unsafe float AngularVelocityCoefficient
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigidBodyErrorCorrection.__PropertyOffset_AngularVelocityCoefficient);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigidBodyErrorCorrection.__PropertyOffset_AngularVelocityCoefficient) = value;
			}
		}

		// Token: 0x17003B1D RID: 15133
		// (get) Token: 0x0600F2BB RID: 62139 RVA: 0x00168185 File Offset: 0x00166385
		// (set) Token: 0x0600F2BC RID: 62140 RVA: 0x00168195 File Offset: 0x00166395
		public unsafe float ErrorAccumulationSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigidBodyErrorCorrection.__PropertyOffset_ErrorAccumulationSeconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigidBodyErrorCorrection.__PropertyOffset_ErrorAccumulationSeconds) = value;
			}
		}

		// Token: 0x17003B1E RID: 15134
		// (get) Token: 0x0600F2BD RID: 62141 RVA: 0x001681A6 File Offset: 0x001663A6
		// (set) Token: 0x0600F2BE RID: 62142 RVA: 0x001681B6 File Offset: 0x001663B6
		public unsafe float ErrorAccumulationDistanceSq
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigidBodyErrorCorrection.__PropertyOffset_ErrorAccumulationDistanceSq);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigidBodyErrorCorrection.__PropertyOffset_ErrorAccumulationDistanceSq) = value;
			}
		}

		// Token: 0x17003B1F RID: 15135
		// (get) Token: 0x0600F2BF RID: 62143 RVA: 0x001681C7 File Offset: 0x001663C7
		// (set) Token: 0x0600F2C0 RID: 62144 RVA: 0x001681D7 File Offset: 0x001663D7
		public unsafe float ErrorAccumulationSimilarity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigidBodyErrorCorrection.__PropertyOffset_ErrorAccumulationSimilarity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigidBodyErrorCorrection.__PropertyOffset_ErrorAccumulationSimilarity) = value;
			}
		}

		// Token: 0x0600F2C1 RID: 62145 RVA: 0x001681E8 File Offset: 0x001663E8
		public FRigidBodyErrorCorrection()
		{
		}

		// Token: 0x0600F2C2 RID: 62146 RVA: 0x001681F0 File Offset: 0x001663F0
		public FRigidBodyErrorCorrection(float PingExtrapolation, float PingLimit, float ErrorPerLinearDifference, float ErrorPerAngularDifference, float MaxRestoredStateError, float MaxLinearHardSnapDistance, float PositionLerp, float AngleLerp, float LinearVelocityCoefficient, float AngularVelocityCoefficient, float ErrorAccumulationSeconds, float ErrorAccumulationDistanceSq, float ErrorAccumulationSimilarity)
		{
			this.PingExtrapolation = PingExtrapolation;
			this.PingLimit = PingLimit;
			this.ErrorPerLinearDifference = ErrorPerLinearDifference;
			this.ErrorPerAngularDifference = ErrorPerAngularDifference;
			this.MaxRestoredStateError = MaxRestoredStateError;
			this.MaxLinearHardSnapDistance = MaxLinearHardSnapDistance;
			this.PositionLerp = PositionLerp;
			this.AngleLerp = AngleLerp;
			this.LinearVelocityCoefficient = LinearVelocityCoefficient;
			this.AngularVelocityCoefficient = AngularVelocityCoefficient;
			this.ErrorAccumulationSeconds = ErrorAccumulationSeconds;
			this.ErrorAccumulationDistanceSq = ErrorAccumulationDistanceSq;
			this.ErrorAccumulationSimilarity = ErrorAccumulationSimilarity;
		}

		// Token: 0x0600F2C3 RID: 62147 RVA: 0x00168268 File Offset: 0x00166468
		protected override IntPtr GetUStructPtr()
		{
			return FRigidBodyErrorCorrection.StaticStruct();
		}

		// Token: 0x0600F2C4 RID: 62148 RVA: 0x00168274 File Offset: 0x00166474
		[NullableContext(2)]
		public FRigidBodyErrorCorrection(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F2C5 RID: 62149 RVA: 0x0016827E File Offset: 0x0016647E
		public FRigidBodyErrorCorrection(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F2C6 RID: 62150 RVA: 0x00168289 File Offset: 0x00166489
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigidBodyErrorCorrection(Pointer, false, true);
		}

		// Token: 0x0600F2C7 RID: 62151 RVA: 0x00168293 File Offset: 0x00166493
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigidBodyErrorCorrection(Pointer, MemoryOwner);
		}

		// Token: 0x040083A6 RID: 33702
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.RigidBodyErrorCorrection";

		// Token: 0x040083A7 RID: 33703
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040083A8 RID: 33704
		internal static int __PropertyOffset_PingExtrapolation;

		// Token: 0x040083A9 RID: 33705
		internal static int __PropertyOffset_PingLimit;

		// Token: 0x040083AA RID: 33706
		internal static int __PropertyOffset_ErrorPerLinearDifference;

		// Token: 0x040083AB RID: 33707
		internal static int __PropertyOffset_ErrorPerAngularDifference;

		// Token: 0x040083AC RID: 33708
		internal static int __PropertyOffset_MaxRestoredStateError;

		// Token: 0x040083AD RID: 33709
		internal static int __PropertyOffset_MaxLinearHardSnapDistance;

		// Token: 0x040083AE RID: 33710
		internal static int __PropertyOffset_PositionLerp;

		// Token: 0x040083AF RID: 33711
		internal static int __PropertyOffset_AngleLerp;

		// Token: 0x040083B0 RID: 33712
		internal static int __PropertyOffset_LinearVelocityCoefficient;

		// Token: 0x040083B1 RID: 33713
		internal static int __PropertyOffset_AngularVelocityCoefficient;

		// Token: 0x040083B2 RID: 33714
		internal static int __PropertyOffset_ErrorAccumulationSeconds;

		// Token: 0x040083B3 RID: 33715
		internal static int __PropertyOffset_ErrorAccumulationDistanceSq;

		// Token: 0x040083B4 RID: 33716
		internal static int __PropertyOffset_ErrorAccumulationSimilarity;
	}
}
