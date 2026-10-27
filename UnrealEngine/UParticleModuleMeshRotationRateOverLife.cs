using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F89 RID: 3977
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleMeshRotationRateOverLife")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UParticleModuleMeshRotationRateOverLife : UParticleModuleRotationRateBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D644 RID: 54852 RVA: 0x0013B7D5 File Offset: 0x001399D5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleMeshRotationRateOverLife._ClassPtr;
		}

		// Token: 0x0600D645 RID: 54853 RVA: 0x0013B7E4 File Offset: 0x001399E4
		public UParticleModuleMeshRotationRateOverLife() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleMeshRotationRateOverLife.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D646 RID: 54854 RVA: 0x0013B80C File Offset: 0x00139A0C
		public UParticleModuleMeshRotationRateOverLife(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleMeshRotationRateOverLife.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003250 RID: 12880
		// (get) Token: 0x0600D647 RID: 54855 RVA: 0x0013B840 File Offset: 0x00139A40
		// (set) Token: 0x0600D648 RID: 54856 RVA: 0x0013B879 File Offset: 0x00139A79
		public FRawDistributionVector RotRate
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._RotRate) == null)
				{
					result = (this._RotRate = new FRawDistributionVector(base.NativePtr + (IntPtr)UParticleModuleMeshRotationRateOverLife.__PropertyOffset_RotRate, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleMeshRotationRateOverLife.__PropertyOffset_RotRate, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003251 RID: 12881
		// (get) Token: 0x0600D649 RID: 54857 RVA: 0x0013B89A File Offset: 0x00139A9A
		// (set) Token: 0x0600D64A RID: 54858 RVA: 0x0013B8B3 File Offset: 0x00139AB3
		public unsafe bool bScaleRotRate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleMeshRotationRateOverLife.__PropertyOffset_bScaleRotRate) & UParticleModuleMeshRotationRateOverLife.__PropertyMask_bScaleRotRate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleMeshRotationRateOverLife.__PropertyOffset_bScaleRotRate) = ((*(base.NativePtr + (IntPtr)UParticleModuleMeshRotationRateOverLife.__PropertyOffset_bScaleRotRate) & ~UParticleModuleMeshRotationRateOverLife.__PropertyMask_bScaleRotRate) | (value ? UParticleModuleMeshRotationRateOverLife.__PropertyMask_bScaleRotRate : 0));
			}
		}

		// Token: 0x0600D64B RID: 54859 RVA: 0x0013B8E3 File Offset: 0x00139AE3
		static UParticleModuleMeshRotationRateOverLife()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleMeshRotationRateOverLife");
		}

		// Token: 0x0600D64C RID: 54860 RVA: 0x0013B8F1 File Offset: 0x00139AF1
		protected UParticleModuleMeshRotationRateOverLife(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040073B2 RID: 29618
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleMeshRotationRateOverLife";

		// Token: 0x040073B3 RID: 29619
		private static IntPtr _ClassPtr;

		// Token: 0x040073B4 RID: 29620
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040073B5 RID: 29621
		internal static int __PropertyOffset_RotRate;

		// Token: 0x040073B6 RID: 29622
		[Nullable(2)]
		private FRawDistributionVector _RotRate;

		// Token: 0x040073B7 RID: 29623
		internal static int __PropertyOffset_bScaleRotRate;

		// Token: 0x040073B8 RID: 29624
		internal static byte __PropertyMask_bScaleRotRate;
	}
}
