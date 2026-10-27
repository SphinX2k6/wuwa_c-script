using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F7C RID: 3964
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleLocationPrimitiveCylinder_Seeded")]
	[UnrealStructLayout(328, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 328)]
	public class UParticleModuleLocationPrimitiveCylinder_Seeded : UParticleModuleLocationPrimitiveCylinder, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D5C8 RID: 54728 RVA: 0x0013A93A File Offset: 0x00138B3A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleLocationPrimitiveCylinder_Seeded._ClassPtr;
		}

		// Token: 0x0600D5C9 RID: 54729 RVA: 0x0013A948 File Offset: 0x00138B48
		public UParticleModuleLocationPrimitiveCylinder_Seeded() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleLocationPrimitiveCylinder_Seeded.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D5CA RID: 54730 RVA: 0x0013A970 File Offset: 0x00138B70
		public UParticleModuleLocationPrimitiveCylinder_Seeded(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleLocationPrimitiveCylinder_Seeded.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003232 RID: 12850
		// (get) Token: 0x0600D5CB RID: 54731 RVA: 0x0013A9A4 File Offset: 0x00138BA4
		// (set) Token: 0x0600D5CC RID: 54732 RVA: 0x0013A9DD File Offset: 0x00138BDD
		public FParticleRandomSeedInfo RandomSeedInfo
		{
			get
			{
				base.FastCheckIsValid();
				FParticleRandomSeedInfo result;
				if ((result = this._RandomSeedInfo) == null)
				{
					result = (this._RandomSeedInfo = new FParticleRandomSeedInfo(base.NativePtr + (IntPtr)UParticleModuleLocationPrimitiveCylinder_Seeded.__PropertyOffset_RandomSeedInfo, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FParticleRandomSeedInfo.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleLocationPrimitiveCylinder_Seeded.__PropertyOffset_RandomSeedInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600D5CD RID: 54733 RVA: 0x0013A9FE File Offset: 0x00138BFE
		static UParticleModuleLocationPrimitiveCylinder_Seeded()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleLocationPrimitiveCylinder_Seeded");
		}

		// Token: 0x0600D5CE RID: 54734 RVA: 0x0013AA0C File Offset: 0x00138C0C
		protected UParticleModuleLocationPrimitiveCylinder_Seeded(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007357 RID: 29527
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleLocationPrimitiveCylinder_Seeded";

		// Token: 0x04007358 RID: 29528
		private static IntPtr _ClassPtr;

		// Token: 0x04007359 RID: 29529
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400735A RID: 29530
		internal static int __PropertyOffset_RandomSeedInfo;

		// Token: 0x0400735B RID: 29531
		[Nullable(2)]
		private FParticleRandomSeedInfo _RandomSeedInfo;
	}
}
