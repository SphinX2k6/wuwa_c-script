using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F98 RID: 3992
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleRotationRate")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UParticleModuleRotationRate : UParticleModuleRotationRateBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D70F RID: 55055 RVA: 0x0013CDAA File Offset: 0x0013AFAA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleRotationRate._ClassPtr;
		}

		// Token: 0x0600D710 RID: 55056 RVA: 0x0013CDB8 File Offset: 0x0013AFB8
		public UParticleModuleRotationRate() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleRotationRate.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D711 RID: 55057 RVA: 0x0013CDE0 File Offset: 0x0013AFE0
		public UParticleModuleRotationRate(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleRotationRate.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003292 RID: 12946
		// (get) Token: 0x0600D712 RID: 55058 RVA: 0x0013CE14 File Offset: 0x0013B014
		// (set) Token: 0x0600D713 RID: 55059 RVA: 0x0013CE4D File Offset: 0x0013B04D
		public FRawDistributionFloat StartRotationRate
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._StartRotationRate) == null)
				{
					result = (this._StartRotationRate = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleRotationRate.__PropertyOffset_StartRotationRate, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleRotationRate.__PropertyOffset_StartRotationRate, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600D714 RID: 55060 RVA: 0x0013CE6E File Offset: 0x0013B06E
		static UParticleModuleRotationRate()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleRotationRate");
		}

		// Token: 0x0600D715 RID: 55061 RVA: 0x0013CE7C File Offset: 0x0013B07C
		protected UParticleModuleRotationRate(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007442 RID: 29762
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleRotationRate";

		// Token: 0x04007443 RID: 29763
		private static IntPtr _ClassPtr;

		// Token: 0x04007444 RID: 29764
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007445 RID: 29765
		internal static int __PropertyOffset_StartRotationRate;

		// Token: 0x04007446 RID: 29766
		[Nullable(2)]
		private FRawDistributionFloat _StartRotationRate;
	}
}
