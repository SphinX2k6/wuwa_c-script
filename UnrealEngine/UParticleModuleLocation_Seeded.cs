using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F83 RID: 3971
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleLocation_Seeded")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class UParticleModuleLocation_Seeded : UParticleModuleLocation, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D61B RID: 54811 RVA: 0x0013B309 File Offset: 0x00139509
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleLocation_Seeded._ClassPtr;
		}

		// Token: 0x0600D61C RID: 54812 RVA: 0x0013B318 File Offset: 0x00139518
		public UParticleModuleLocation_Seeded() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleLocation_Seeded.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D61D RID: 54813 RVA: 0x0013B340 File Offset: 0x00139540
		public UParticleModuleLocation_Seeded(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleLocation_Seeded.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700324A RID: 12874
		// (get) Token: 0x0600D61E RID: 54814 RVA: 0x0013B374 File Offset: 0x00139574
		// (set) Token: 0x0600D61F RID: 54815 RVA: 0x0013B3AD File Offset: 0x001395AD
		public FParticleRandomSeedInfo RandomSeedInfo
		{
			get
			{
				base.FastCheckIsValid();
				FParticleRandomSeedInfo result;
				if ((result = this._RandomSeedInfo) == null)
				{
					result = (this._RandomSeedInfo = new FParticleRandomSeedInfo(base.NativePtr + (IntPtr)UParticleModuleLocation_Seeded.__PropertyOffset_RandomSeedInfo, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FParticleRandomSeedInfo.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleLocation_Seeded.__PropertyOffset_RandomSeedInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600D620 RID: 54816 RVA: 0x0013B3CE File Offset: 0x001395CE
		static UParticleModuleLocation_Seeded()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleLocation_Seeded");
		}

		// Token: 0x0600D621 RID: 54817 RVA: 0x0013B3DC File Offset: 0x001395DC
		protected UParticleModuleLocation_Seeded(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007394 RID: 29588
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleLocation_Seeded";

		// Token: 0x04007395 RID: 29589
		private static IntPtr _ClassPtr;

		// Token: 0x04007396 RID: 29590
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007397 RID: 29591
		internal static int __PropertyOffset_RandomSeedInfo;

		// Token: 0x04007398 RID: 29592
		[Nullable(2)]
		private FParticleRandomSeedInfo _RandomSeedInfo;
	}
}
