using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F74 RID: 3956
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleLocation")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UParticleModuleLocation : UParticleModuleLocationBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D555 RID: 54613 RVA: 0x00139BDD File Offset: 0x00137DDD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleLocation._ClassPtr;
		}

		// Token: 0x0600D556 RID: 54614 RVA: 0x00139BEC File Offset: 0x00137DEC
		public UParticleModuleLocation() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleLocation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D557 RID: 54615 RVA: 0x00139C14 File Offset: 0x00137E14
		public UParticleModuleLocation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleLocation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700320C RID: 12812
		// (get) Token: 0x0600D558 RID: 54616 RVA: 0x00139C48 File Offset: 0x00137E48
		// (set) Token: 0x0600D559 RID: 54617 RVA: 0x00139C81 File Offset: 0x00137E81
		public FRawDistributionVector StartLocation
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._StartLocation) == null)
				{
					result = (this._StartLocation = new FRawDistributionVector(base.NativePtr + (IntPtr)UParticleModuleLocation.__PropertyOffset_StartLocation, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleLocation.__PropertyOffset_StartLocation, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700320D RID: 12813
		// (get) Token: 0x0600D55A RID: 54618 RVA: 0x00139CA2 File Offset: 0x00137EA2
		// (set) Token: 0x0600D55B RID: 54619 RVA: 0x00139CB2 File Offset: 0x00137EB2
		public unsafe float DistributeOverNPoints
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleLocation.__PropertyOffset_DistributeOverNPoints);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleLocation.__PropertyOffset_DistributeOverNPoints) = value;
			}
		}

		// Token: 0x1700320E RID: 12814
		// (get) Token: 0x0600D55C RID: 54620 RVA: 0x00139CC3 File Offset: 0x00137EC3
		// (set) Token: 0x0600D55D RID: 54621 RVA: 0x00139CD3 File Offset: 0x00137ED3
		public unsafe float DistributeThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleLocation.__PropertyOffset_DistributeThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleLocation.__PropertyOffset_DistributeThreshold) = value;
			}
		}

		// Token: 0x0600D55E RID: 54622 RVA: 0x00139CE4 File Offset: 0x00137EE4
		static UParticleModuleLocation()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleLocation");
		}

		// Token: 0x0600D55F RID: 54623 RVA: 0x00139CF2 File Offset: 0x00137EF2
		protected UParticleModuleLocation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007301 RID: 29441
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleLocation";

		// Token: 0x04007302 RID: 29442
		private static IntPtr _ClassPtr;

		// Token: 0x04007303 RID: 29443
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007304 RID: 29444
		internal static int __PropertyOffset_StartLocation;

		// Token: 0x04007305 RID: 29445
		[Nullable(2)]
		private FRawDistributionVector _StartLocation;

		// Token: 0x04007306 RID: 29446
		internal static int __PropertyOffset_DistributeOverNPoints;

		// Token: 0x04007307 RID: 29447
		internal static int __PropertyOffset_DistributeThreshold;
	}
}
