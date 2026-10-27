using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F50 RID: 3920
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleAccelerationOverLifetime")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UParticleModuleAccelerationOverLifetime : UParticleModuleAccelerationBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D378 RID: 54136 RVA: 0x00136281 File Offset: 0x00134481
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleAccelerationOverLifetime._ClassPtr;
		}

		// Token: 0x0600D379 RID: 54137 RVA: 0x00136290 File Offset: 0x00134490
		public UParticleModuleAccelerationOverLifetime() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleAccelerationOverLifetime.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D37A RID: 54138 RVA: 0x001362B8 File Offset: 0x001344B8
		public UParticleModuleAccelerationOverLifetime(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleAccelerationOverLifetime.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003172 RID: 12658
		// (get) Token: 0x0600D37B RID: 54139 RVA: 0x001362EC File Offset: 0x001344EC
		// (set) Token: 0x0600D37C RID: 54140 RVA: 0x00136325 File Offset: 0x00134525
		public FRawDistributionVector AccelOverLife
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._AccelOverLife) == null)
				{
					result = (this._AccelOverLife = new FRawDistributionVector(base.NativePtr + (IntPtr)UParticleModuleAccelerationOverLifetime.__PropertyOffset_AccelOverLife, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleAccelerationOverLifetime.__PropertyOffset_AccelOverLife, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600D37D RID: 54141 RVA: 0x00136346 File Offset: 0x00134546
		static UParticleModuleAccelerationOverLifetime()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleAccelerationOverLifetime");
		}

		// Token: 0x0600D37E RID: 54142 RVA: 0x00136354 File Offset: 0x00134554
		protected UParticleModuleAccelerationOverLifetime(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400718D RID: 29069
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleAccelerationOverLifetime";

		// Token: 0x0400718E RID: 29070
		private static IntPtr _ClassPtr;

		// Token: 0x0400718F RID: 29071
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007190 RID: 29072
		internal static int __PropertyOffset_AccelOverLife;

		// Token: 0x04007191 RID: 29073
		[Nullable(2)]
		private FRawDistributionVector _AccelOverLife;
	}
}
