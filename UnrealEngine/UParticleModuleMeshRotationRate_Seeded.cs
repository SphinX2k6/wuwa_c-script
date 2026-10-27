using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F8A RID: 3978
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleMeshRotationRate_Seeded")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UParticleModuleMeshRotationRate_Seeded : UParticleModuleMeshRotationRate, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D64D RID: 54861 RVA: 0x0013B8FA File Offset: 0x00139AFA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleMeshRotationRate_Seeded._ClassPtr;
		}

		// Token: 0x0600D64E RID: 54862 RVA: 0x0013B908 File Offset: 0x00139B08
		public UParticleModuleMeshRotationRate_Seeded() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleMeshRotationRate_Seeded.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D64F RID: 54863 RVA: 0x0013B930 File Offset: 0x00139B30
		public UParticleModuleMeshRotationRate_Seeded(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleMeshRotationRate_Seeded.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003252 RID: 12882
		// (get) Token: 0x0600D650 RID: 54864 RVA: 0x0013B964 File Offset: 0x00139B64
		// (set) Token: 0x0600D651 RID: 54865 RVA: 0x0013B99D File Offset: 0x00139B9D
		public FParticleRandomSeedInfo RandomSeedInfo
		{
			get
			{
				base.FastCheckIsValid();
				FParticleRandomSeedInfo result;
				if ((result = this._RandomSeedInfo) == null)
				{
					result = (this._RandomSeedInfo = new FParticleRandomSeedInfo(base.NativePtr + (IntPtr)UParticleModuleMeshRotationRate_Seeded.__PropertyOffset_RandomSeedInfo, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FParticleRandomSeedInfo.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleMeshRotationRate_Seeded.__PropertyOffset_RandomSeedInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600D652 RID: 54866 RVA: 0x0013B9BE File Offset: 0x00139BBE
		static UParticleModuleMeshRotationRate_Seeded()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleMeshRotationRate_Seeded");
		}

		// Token: 0x0600D653 RID: 54867 RVA: 0x0013B9CC File Offset: 0x00139BCC
		protected UParticleModuleMeshRotationRate_Seeded(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040073B9 RID: 29625
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleMeshRotationRate_Seeded";

		// Token: 0x040073BA RID: 29626
		private static IntPtr _ClassPtr;

		// Token: 0x040073BB RID: 29627
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040073BC RID: 29628
		internal static int __PropertyOffset_RandomSeedInfo;

		// Token: 0x040073BD RID: 29629
		[Nullable(2)]
		private FParticleRandomSeedInfo _RandomSeedInfo;
	}
}
