using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F88 RID: 3976
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleMeshRotationRateMultiplyLife")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UParticleModuleMeshRotationRateMultiplyLife : UParticleModuleRotationRateBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D63D RID: 54845 RVA: 0x0013B6F9 File Offset: 0x001398F9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleMeshRotationRateMultiplyLife._ClassPtr;
		}

		// Token: 0x0600D63E RID: 54846 RVA: 0x0013B708 File Offset: 0x00139908
		public UParticleModuleMeshRotationRateMultiplyLife() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleMeshRotationRateMultiplyLife.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D63F RID: 54847 RVA: 0x0013B730 File Offset: 0x00139930
		public UParticleModuleMeshRotationRateMultiplyLife(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleMeshRotationRateMultiplyLife.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700324F RID: 12879
		// (get) Token: 0x0600D640 RID: 54848 RVA: 0x0013B764 File Offset: 0x00139964
		// (set) Token: 0x0600D641 RID: 54849 RVA: 0x0013B79D File Offset: 0x0013999D
		public FRawDistributionVector LifeMultiplier
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._LifeMultiplier) == null)
				{
					result = (this._LifeMultiplier = new FRawDistributionVector(base.NativePtr + (IntPtr)UParticleModuleMeshRotationRateMultiplyLife.__PropertyOffset_LifeMultiplier, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleMeshRotationRateMultiplyLife.__PropertyOffset_LifeMultiplier, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600D642 RID: 54850 RVA: 0x0013B7BE File Offset: 0x001399BE
		static UParticleModuleMeshRotationRateMultiplyLife()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleMeshRotationRateMultiplyLife");
		}

		// Token: 0x0600D643 RID: 54851 RVA: 0x0013B7CC File Offset: 0x001399CC
		protected UParticleModuleMeshRotationRateMultiplyLife(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040073AD RID: 29613
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleMeshRotationRateMultiplyLife";

		// Token: 0x040073AE RID: 29614
		private static IntPtr _ClassPtr;

		// Token: 0x040073AF RID: 29615
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040073B0 RID: 29616
		internal static int __PropertyOffset_LifeMultiplier;

		// Token: 0x040073B1 RID: 29617
		[Nullable(2)]
		private FRawDistributionVector _LifeMultiplier;
	}
}
