using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F87 RID: 3975
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleMeshRotationRate")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UParticleModuleMeshRotationRate : UParticleModuleRotationRateBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D636 RID: 54838 RVA: 0x0013B61E File Offset: 0x0013981E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleMeshRotationRate._ClassPtr;
		}

		// Token: 0x0600D637 RID: 54839 RVA: 0x0013B62C File Offset: 0x0013982C
		public UParticleModuleMeshRotationRate() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleMeshRotationRate.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D638 RID: 54840 RVA: 0x0013B654 File Offset: 0x00139854
		public UParticleModuleMeshRotationRate(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleMeshRotationRate.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700324E RID: 12878
		// (get) Token: 0x0600D639 RID: 54841 RVA: 0x0013B688 File Offset: 0x00139888
		// (set) Token: 0x0600D63A RID: 54842 RVA: 0x0013B6C1 File Offset: 0x001398C1
		public FRawDistributionVector StartRotationRate
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._StartRotationRate) == null)
				{
					result = (this._StartRotationRate = new FRawDistributionVector(base.NativePtr + (IntPtr)UParticleModuleMeshRotationRate.__PropertyOffset_StartRotationRate, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleMeshRotationRate.__PropertyOffset_StartRotationRate, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600D63B RID: 54843 RVA: 0x0013B6E2 File Offset: 0x001398E2
		static UParticleModuleMeshRotationRate()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleMeshRotationRate");
		}

		// Token: 0x0600D63C RID: 54844 RVA: 0x0013B6F0 File Offset: 0x001398F0
		protected UParticleModuleMeshRotationRate(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040073A8 RID: 29608
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleMeshRotationRate";

		// Token: 0x040073A9 RID: 29609
		private static IntPtr _ClassPtr;

		// Token: 0x040073AA RID: 29610
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040073AB RID: 29611
		internal static int __PropertyOffset_StartRotationRate;

		// Token: 0x040073AC RID: 29612
		[Nullable(2)]
		private FRawDistributionVector _StartRotationRate;
	}
}
