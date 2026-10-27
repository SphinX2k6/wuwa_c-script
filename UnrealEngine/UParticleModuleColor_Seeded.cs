using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F64 RID: 3940
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleColor_Seeded")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UParticleModuleColor_Seeded : UParticleModuleColor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D4C3 RID: 54467 RVA: 0x00138B22 File Offset: 0x00136D22
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleColor_Seeded._ClassPtr;
		}

		// Token: 0x0600D4C4 RID: 54468 RVA: 0x00138B30 File Offset: 0x00136D30
		public UParticleModuleColor_Seeded() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleColor_Seeded.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D4C5 RID: 54469 RVA: 0x00138B58 File Offset: 0x00136D58
		public UParticleModuleColor_Seeded(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleColor_Seeded.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170031E8 RID: 12776
		// (get) Token: 0x0600D4C6 RID: 54470 RVA: 0x00138B8C File Offset: 0x00136D8C
		// (set) Token: 0x0600D4C7 RID: 54471 RVA: 0x00138BC5 File Offset: 0x00136DC5
		public FParticleRandomSeedInfo RandomSeedInfo
		{
			get
			{
				base.FastCheckIsValid();
				FParticleRandomSeedInfo result;
				if ((result = this._RandomSeedInfo) == null)
				{
					result = (this._RandomSeedInfo = new FParticleRandomSeedInfo(base.NativePtr + (IntPtr)UParticleModuleColor_Seeded.__PropertyOffset_RandomSeedInfo, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FParticleRandomSeedInfo.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleColor_Seeded.__PropertyOffset_RandomSeedInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600D4C8 RID: 54472 RVA: 0x00138BE6 File Offset: 0x00136DE6
		static UParticleModuleColor_Seeded()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleColor_Seeded");
		}

		// Token: 0x0600D4C9 RID: 54473 RVA: 0x00138BF4 File Offset: 0x00136DF4
		protected UParticleModuleColor_Seeded(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007292 RID: 29330
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleColor_Seeded";

		// Token: 0x04007293 RID: 29331
		private static IntPtr _ClassPtr;

		// Token: 0x04007294 RID: 29332
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007295 RID: 29333
		internal static int __PropertyOffset_RandomSeedInfo;

		// Token: 0x04007296 RID: 29334
		[Nullable(2)]
		private FParticleRandomSeedInfo _RandomSeedInfo;
	}
}
