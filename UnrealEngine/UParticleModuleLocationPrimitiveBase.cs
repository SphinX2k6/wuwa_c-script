using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F7A RID: 3962
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleLocationPrimitiveBase")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class UParticleModuleLocationPrimitiveBase : UParticleModuleLocationBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D5A2 RID: 54690 RVA: 0x0013A413 File Offset: 0x00138613
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleLocationPrimitiveBase._ClassPtr;
		}

		// Token: 0x0600D5A3 RID: 54691 RVA: 0x0013A420 File Offset: 0x00138620
		public UParticleModuleLocationPrimitiveBase() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleLocationPrimitiveBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D5A4 RID: 54692 RVA: 0x0013A448 File Offset: 0x00138648
		public UParticleModuleLocationPrimitiveBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleLocationPrimitiveBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003224 RID: 12836
		// (get) Token: 0x0600D5A5 RID: 54693 RVA: 0x0013A47B File Offset: 0x0013867B
		// (set) Token: 0x0600D5A6 RID: 54694 RVA: 0x0013A494 File Offset: 0x00138694
		public unsafe bool Positive_X
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleLocationPrimitiveBase.__PropertyOffset_Positive_X) & UParticleModuleLocationPrimitiveBase.__PropertyMask_Positive_X) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleLocationPrimitiveBase.__PropertyOffset_Positive_X) = ((*(base.NativePtr + (IntPtr)UParticleModuleLocationPrimitiveBase.__PropertyOffset_Positive_X) & ~UParticleModuleLocationPrimitiveBase.__PropertyMask_Positive_X) | (value ? UParticleModuleLocationPrimitiveBase.__PropertyMask_Positive_X : 0));
			}
		}

		// Token: 0x17003225 RID: 12837
		// (get) Token: 0x0600D5A7 RID: 54695 RVA: 0x0013A4C4 File Offset: 0x001386C4
		// (set) Token: 0x0600D5A8 RID: 54696 RVA: 0x0013A4DD File Offset: 0x001386DD
		public unsafe bool Positive_Y
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleLocationPrimitiveBase.__PropertyOffset_Positive_Y) & UParticleModuleLocationPrimitiveBase.__PropertyMask_Positive_Y) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleLocationPrimitiveBase.__PropertyOffset_Positive_Y) = ((*(base.NativePtr + (IntPtr)UParticleModuleLocationPrimitiveBase.__PropertyOffset_Positive_Y) & ~UParticleModuleLocationPrimitiveBase.__PropertyMask_Positive_Y) | (value ? UParticleModuleLocationPrimitiveBase.__PropertyMask_Positive_Y : 0));
			}
		}

		// Token: 0x17003226 RID: 12838
		// (get) Token: 0x0600D5A9 RID: 54697 RVA: 0x0013A50D File Offset: 0x0013870D
		// (set) Token: 0x0600D5AA RID: 54698 RVA: 0x0013A526 File Offset: 0x00138726
		public unsafe bool Positive_Z
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleLocationPrimitiveBase.__PropertyOffset_Positive_Z) & UParticleModuleLocationPrimitiveBase.__PropertyMask_Positive_Z) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleLocationPrimitiveBase.__PropertyOffset_Positive_Z) = ((*(base.NativePtr + (IntPtr)UParticleModuleLocationPrimitiveBase.__PropertyOffset_Positive_Z) & ~UParticleModuleLocationPrimitiveBase.__PropertyMask_Positive_Z) | (value ? UParticleModuleLocationPrimitiveBase.__PropertyMask_Positive_Z : 0));
			}
		}

		// Token: 0x17003227 RID: 12839
		// (get) Token: 0x0600D5AB RID: 54699 RVA: 0x0013A556 File Offset: 0x00138756
		// (set) Token: 0x0600D5AC RID: 54700 RVA: 0x0013A56F File Offset: 0x0013876F
		public unsafe bool Negative_X
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleLocationPrimitiveBase.__PropertyOffset_Negative_X) & UParticleModuleLocationPrimitiveBase.__PropertyMask_Negative_X) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleLocationPrimitiveBase.__PropertyOffset_Negative_X) = ((*(base.NativePtr + (IntPtr)UParticleModuleLocationPrimitiveBase.__PropertyOffset_Negative_X) & ~UParticleModuleLocationPrimitiveBase.__PropertyMask_Negative_X) | (value ? UParticleModuleLocationPrimitiveBase.__PropertyMask_Negative_X : 0));
			}
		}

		// Token: 0x17003228 RID: 12840
		// (get) Token: 0x0600D5AD RID: 54701 RVA: 0x0013A59F File Offset: 0x0013879F
		// (set) Token: 0x0600D5AE RID: 54702 RVA: 0x0013A5B8 File Offset: 0x001387B8
		public unsafe bool Negative_Y
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleLocationPrimitiveBase.__PropertyOffset_Negative_Y) & UParticleModuleLocationPrimitiveBase.__PropertyMask_Negative_Y) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleLocationPrimitiveBase.__PropertyOffset_Negative_Y) = ((*(base.NativePtr + (IntPtr)UParticleModuleLocationPrimitiveBase.__PropertyOffset_Negative_Y) & ~UParticleModuleLocationPrimitiveBase.__PropertyMask_Negative_Y) | (value ? UParticleModuleLocationPrimitiveBase.__PropertyMask_Negative_Y : 0));
			}
		}

		// Token: 0x17003229 RID: 12841
		// (get) Token: 0x0600D5AF RID: 54703 RVA: 0x0013A5E8 File Offset: 0x001387E8
		// (set) Token: 0x0600D5B0 RID: 54704 RVA: 0x0013A601 File Offset: 0x00138801
		public unsafe bool Negative_Z
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleLocationPrimitiveBase.__PropertyOffset_Negative_Z) & UParticleModuleLocationPrimitiveBase.__PropertyMask_Negative_Z) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleLocationPrimitiveBase.__PropertyOffset_Negative_Z) = ((*(base.NativePtr + (IntPtr)UParticleModuleLocationPrimitiveBase.__PropertyOffset_Negative_Z) & ~UParticleModuleLocationPrimitiveBase.__PropertyMask_Negative_Z) | (value ? UParticleModuleLocationPrimitiveBase.__PropertyMask_Negative_Z : 0));
			}
		}

		// Token: 0x1700322A RID: 12842
		// (get) Token: 0x0600D5B1 RID: 54705 RVA: 0x0013A631 File Offset: 0x00138831
		// (set) Token: 0x0600D5B2 RID: 54706 RVA: 0x0013A64A File Offset: 0x0013884A
		public unsafe bool SurfaceOnly
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleLocationPrimitiveBase.__PropertyOffset_SurfaceOnly) & UParticleModuleLocationPrimitiveBase.__PropertyMask_SurfaceOnly) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleLocationPrimitiveBase.__PropertyOffset_SurfaceOnly) = ((*(base.NativePtr + (IntPtr)UParticleModuleLocationPrimitiveBase.__PropertyOffset_SurfaceOnly) & ~UParticleModuleLocationPrimitiveBase.__PropertyMask_SurfaceOnly) | (value ? UParticleModuleLocationPrimitiveBase.__PropertyMask_SurfaceOnly : 0));
			}
		}

		// Token: 0x1700322B RID: 12843
		// (get) Token: 0x0600D5B3 RID: 54707 RVA: 0x0013A67A File Offset: 0x0013887A
		// (set) Token: 0x0600D5B4 RID: 54708 RVA: 0x0013A693 File Offset: 0x00138893
		public unsafe bool Velocity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleLocationPrimitiveBase.__PropertyOffset_Velocity) & UParticleModuleLocationPrimitiveBase.__PropertyMask_Velocity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleLocationPrimitiveBase.__PropertyOffset_Velocity) = ((*(base.NativePtr + (IntPtr)UParticleModuleLocationPrimitiveBase.__PropertyOffset_Velocity) & ~UParticleModuleLocationPrimitiveBase.__PropertyMask_Velocity) | (value ? UParticleModuleLocationPrimitiveBase.__PropertyMask_Velocity : 0));
			}
		}

		// Token: 0x1700322C RID: 12844
		// (get) Token: 0x0600D5B5 RID: 54709 RVA: 0x0013A6C4 File Offset: 0x001388C4
		// (set) Token: 0x0600D5B6 RID: 54710 RVA: 0x0013A6FD File Offset: 0x001388FD
		public FRawDistributionFloat VelocityScale
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._VelocityScale) == null)
				{
					result = (this._VelocityScale = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleLocationPrimitiveBase.__PropertyOffset_VelocityScale, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleLocationPrimitiveBase.__PropertyOffset_VelocityScale, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700322D RID: 12845
		// (get) Token: 0x0600D5B7 RID: 54711 RVA: 0x0013A720 File Offset: 0x00138920
		// (set) Token: 0x0600D5B8 RID: 54712 RVA: 0x0013A759 File Offset: 0x00138959
		public FRawDistributionVector StartLocation
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._StartLocation) == null)
				{
					result = (this._StartLocation = new FRawDistributionVector(base.NativePtr + (IntPtr)UParticleModuleLocationPrimitiveBase.__PropertyOffset_StartLocation, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleLocationPrimitiveBase.__PropertyOffset_StartLocation, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600D5B9 RID: 54713 RVA: 0x0013A77A File Offset: 0x0013897A
		static UParticleModuleLocationPrimitiveBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleLocationPrimitiveBase");
		}

		// Token: 0x0600D5BA RID: 54714 RVA: 0x0013A788 File Offset: 0x00138988
		protected UParticleModuleLocationPrimitiveBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007336 RID: 29494
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleLocationPrimitiveBase";

		// Token: 0x04007337 RID: 29495
		private static IntPtr _ClassPtr;

		// Token: 0x04007338 RID: 29496
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007339 RID: 29497
		internal static int __PropertyOffset_Positive_X;

		// Token: 0x0400733A RID: 29498
		internal static byte __PropertyMask_Positive_X;

		// Token: 0x0400733B RID: 29499
		internal static int __PropertyOffset_Positive_Y;

		// Token: 0x0400733C RID: 29500
		internal static byte __PropertyMask_Positive_Y;

		// Token: 0x0400733D RID: 29501
		internal static int __PropertyOffset_Positive_Z;

		// Token: 0x0400733E RID: 29502
		internal static byte __PropertyMask_Positive_Z;

		// Token: 0x0400733F RID: 29503
		internal static int __PropertyOffset_Negative_X;

		// Token: 0x04007340 RID: 29504
		internal static byte __PropertyMask_Negative_X;

		// Token: 0x04007341 RID: 29505
		internal static int __PropertyOffset_Negative_Y;

		// Token: 0x04007342 RID: 29506
		internal static byte __PropertyMask_Negative_Y;

		// Token: 0x04007343 RID: 29507
		internal static int __PropertyOffset_Negative_Z;

		// Token: 0x04007344 RID: 29508
		internal static byte __PropertyMask_Negative_Z;

		// Token: 0x04007345 RID: 29509
		internal static int __PropertyOffset_SurfaceOnly;

		// Token: 0x04007346 RID: 29510
		internal static byte __PropertyMask_SurfaceOnly;

		// Token: 0x04007347 RID: 29511
		internal static int __PropertyOffset_Velocity;

		// Token: 0x04007348 RID: 29512
		internal static byte __PropertyMask_Velocity;

		// Token: 0x04007349 RID: 29513
		internal static int __PropertyOffset_VelocityScale;

		// Token: 0x0400734A RID: 29514
		[Nullable(2)]
		private FRawDistributionFloat _VelocityScale;

		// Token: 0x0400734B RID: 29515
		internal static int __PropertyOffset_StartLocation;

		// Token: 0x0400734C RID: 29516
		[Nullable(2)]
		private FRawDistributionVector _StartLocation;
	}
}
