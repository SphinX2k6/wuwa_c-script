using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F9A RID: 3994
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleRotationRateMultiplyLife")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UParticleModuleRotationRateMultiplyLife : UParticleModuleRotationRateBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D71A RID: 55066 RVA: 0x0013CED1 File Offset: 0x0013B0D1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleRotationRateMultiplyLife._ClassPtr;
		}

		// Token: 0x0600D71B RID: 55067 RVA: 0x0013CEE0 File Offset: 0x0013B0E0
		public UParticleModuleRotationRateMultiplyLife() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleRotationRateMultiplyLife.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D71C RID: 55068 RVA: 0x0013CF08 File Offset: 0x0013B108
		public UParticleModuleRotationRateMultiplyLife(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleRotationRateMultiplyLife.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003293 RID: 12947
		// (get) Token: 0x0600D71D RID: 55069 RVA: 0x0013CF3C File Offset: 0x0013B13C
		// (set) Token: 0x0600D71E RID: 55070 RVA: 0x0013CF75 File Offset: 0x0013B175
		public FRawDistributionFloat LifeMultiplier
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._LifeMultiplier) == null)
				{
					result = (this._LifeMultiplier = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleRotationRateMultiplyLife.__PropertyOffset_LifeMultiplier, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleRotationRateMultiplyLife.__PropertyOffset_LifeMultiplier, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600D71F RID: 55071 RVA: 0x0013CF96 File Offset: 0x0013B196
		static UParticleModuleRotationRateMultiplyLife()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleRotationRateMultiplyLife");
		}

		// Token: 0x0600D720 RID: 55072 RVA: 0x0013CFA4 File Offset: 0x0013B1A4
		protected UParticleModuleRotationRateMultiplyLife(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400744A RID: 29770
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleRotationRateMultiplyLife";

		// Token: 0x0400744B RID: 29771
		private static IntPtr _ClassPtr;

		// Token: 0x0400744C RID: 29772
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400744D RID: 29773
		internal static int __PropertyOffset_LifeMultiplier;

		// Token: 0x0400744E RID: 29774
		[Nullable(2)]
		private FRawDistributionFloat _LifeMultiplier;
	}
}
