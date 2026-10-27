using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F7E RID: 3966
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleLocationPrimitiveSphere_Seeded")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 264)]
	public class UParticleModuleLocationPrimitiveSphere_Seeded : UParticleModuleLocationPrimitiveSphere, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D5D6 RID: 54742 RVA: 0x0013AAF1 File Offset: 0x00138CF1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleLocationPrimitiveSphere_Seeded._ClassPtr;
		}

		// Token: 0x0600D5D7 RID: 54743 RVA: 0x0013AB00 File Offset: 0x00138D00
		public UParticleModuleLocationPrimitiveSphere_Seeded() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleLocationPrimitiveSphere_Seeded.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D5D8 RID: 54744 RVA: 0x0013AB28 File Offset: 0x00138D28
		public UParticleModuleLocationPrimitiveSphere_Seeded(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleLocationPrimitiveSphere_Seeded.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003234 RID: 12852
		// (get) Token: 0x0600D5D9 RID: 54745 RVA: 0x0013AB5C File Offset: 0x00138D5C
		// (set) Token: 0x0600D5DA RID: 54746 RVA: 0x0013AB95 File Offset: 0x00138D95
		public FParticleRandomSeedInfo RandomSeedInfo
		{
			get
			{
				base.FastCheckIsValid();
				FParticleRandomSeedInfo result;
				if ((result = this._RandomSeedInfo) == null)
				{
					result = (this._RandomSeedInfo = new FParticleRandomSeedInfo(base.NativePtr + (IntPtr)UParticleModuleLocationPrimitiveSphere_Seeded.__PropertyOffset_RandomSeedInfo, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FParticleRandomSeedInfo.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleLocationPrimitiveSphere_Seeded.__PropertyOffset_RandomSeedInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600D5DB RID: 54747 RVA: 0x0013ABB6 File Offset: 0x00138DB6
		static UParticleModuleLocationPrimitiveSphere_Seeded()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleLocationPrimitiveSphere_Seeded");
		}

		// Token: 0x0600D5DC RID: 54748 RVA: 0x0013ABC4 File Offset: 0x00138DC4
		protected UParticleModuleLocationPrimitiveSphere_Seeded(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007361 RID: 29537
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleLocationPrimitiveSphere_Seeded";

		// Token: 0x04007362 RID: 29538
		private static IntPtr _ClassPtr;

		// Token: 0x04007363 RID: 29539
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007364 RID: 29540
		internal static int __PropertyOffset_RandomSeedInfo;

		// Token: 0x04007365 RID: 29541
		[Nullable(2)]
		private FParticleRandomSeedInfo _RandomSeedInfo;
	}
}
