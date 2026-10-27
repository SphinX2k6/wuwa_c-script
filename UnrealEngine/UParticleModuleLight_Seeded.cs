using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F73 RID: 3955
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleLight_Seeded")]
	[UnrealStructLayout(328, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 328)]
	public class UParticleModuleLight_Seeded : UParticleModuleLight, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D54E RID: 54606 RVA: 0x00139B01 File Offset: 0x00137D01
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleLight_Seeded._ClassPtr;
		}

		// Token: 0x0600D54F RID: 54607 RVA: 0x00139B10 File Offset: 0x00137D10
		public UParticleModuleLight_Seeded() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleLight_Seeded.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D550 RID: 54608 RVA: 0x00139B38 File Offset: 0x00137D38
		public UParticleModuleLight_Seeded(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleLight_Seeded.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700320B RID: 12811
		// (get) Token: 0x0600D551 RID: 54609 RVA: 0x00139B6C File Offset: 0x00137D6C
		// (set) Token: 0x0600D552 RID: 54610 RVA: 0x00139BA5 File Offset: 0x00137DA5
		public FParticleRandomSeedInfo RandomSeedInfo
		{
			get
			{
				base.FastCheckIsValid();
				FParticleRandomSeedInfo result;
				if ((result = this._RandomSeedInfo) == null)
				{
					result = (this._RandomSeedInfo = new FParticleRandomSeedInfo(base.NativePtr + (IntPtr)UParticleModuleLight_Seeded.__PropertyOffset_RandomSeedInfo, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FParticleRandomSeedInfo.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleLight_Seeded.__PropertyOffset_RandomSeedInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600D553 RID: 54611 RVA: 0x00139BC6 File Offset: 0x00137DC6
		static UParticleModuleLight_Seeded()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleLight_Seeded");
		}

		// Token: 0x0600D554 RID: 54612 RVA: 0x00139BD4 File Offset: 0x00137DD4
		protected UParticleModuleLight_Seeded(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040072FC RID: 29436
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleLight_Seeded";

		// Token: 0x040072FD RID: 29437
		private static IntPtr _ClassPtr;

		// Token: 0x040072FE RID: 29438
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040072FF RID: 29439
		internal static int __PropertyOffset_RandomSeedInfo;

		// Token: 0x04007300 RID: 29440
		[Nullable(2)]
		private FParticleRandomSeedInfo _RandomSeedInfo;
	}
}
