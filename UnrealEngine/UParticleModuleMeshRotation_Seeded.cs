using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F8B RID: 3979
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleMeshRotation_Seeded")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class UParticleModuleMeshRotation_Seeded : UParticleModuleMeshRotation, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D654 RID: 54868 RVA: 0x0013B9D5 File Offset: 0x00139BD5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleMeshRotation_Seeded._ClassPtr;
		}

		// Token: 0x0600D655 RID: 54869 RVA: 0x0013B9E4 File Offset: 0x00139BE4
		public UParticleModuleMeshRotation_Seeded() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleMeshRotation_Seeded.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D656 RID: 54870 RVA: 0x0013BA0C File Offset: 0x00139C0C
		public UParticleModuleMeshRotation_Seeded(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleMeshRotation_Seeded.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003253 RID: 12883
		// (get) Token: 0x0600D657 RID: 54871 RVA: 0x0013BA40 File Offset: 0x00139C40
		// (set) Token: 0x0600D658 RID: 54872 RVA: 0x0013BA79 File Offset: 0x00139C79
		public FParticleRandomSeedInfo RandomSeedInfo
		{
			get
			{
				base.FastCheckIsValid();
				FParticleRandomSeedInfo result;
				if ((result = this._RandomSeedInfo) == null)
				{
					result = (this._RandomSeedInfo = new FParticleRandomSeedInfo(base.NativePtr + (IntPtr)UParticleModuleMeshRotation_Seeded.__PropertyOffset_RandomSeedInfo, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FParticleRandomSeedInfo.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleMeshRotation_Seeded.__PropertyOffset_RandomSeedInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600D659 RID: 54873 RVA: 0x0013BA9A File Offset: 0x00139C9A
		static UParticleModuleMeshRotation_Seeded()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleMeshRotation_Seeded");
		}

		// Token: 0x0600D65A RID: 54874 RVA: 0x0013BAA8 File Offset: 0x00139CA8
		protected UParticleModuleMeshRotation_Seeded(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040073BE RID: 29630
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleMeshRotation_Seeded";

		// Token: 0x040073BF RID: 29631
		private static IntPtr _ClassPtr;

		// Token: 0x040073C0 RID: 29632
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040073C1 RID: 29633
		internal static int __PropertyOffset_RandomSeedInfo;

		// Token: 0x040073C2 RID: 29634
		[Nullable(2)]
		private FParticleRandomSeedInfo _RandomSeedInfo;
	}
}
