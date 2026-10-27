using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FA3 RID: 4003
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleSourceMovement")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UParticleModuleSourceMovement : UParticleModuleLocationBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D764 RID: 55140 RVA: 0x0013D7A1 File Offset: 0x0013B9A1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleSourceMovement._ClassPtr;
		}

		// Token: 0x0600D765 RID: 55141 RVA: 0x0013D7B0 File Offset: 0x0013B9B0
		public UParticleModuleSourceMovement() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleSourceMovement.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D766 RID: 55142 RVA: 0x0013D7D8 File Offset: 0x0013B9D8
		public UParticleModuleSourceMovement(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleSourceMovement.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170032A2 RID: 12962
		// (get) Token: 0x0600D767 RID: 55143 RVA: 0x0013D80C File Offset: 0x0013BA0C
		// (set) Token: 0x0600D768 RID: 55144 RVA: 0x0013D845 File Offset: 0x0013BA45
		public FRawDistributionVector SourceMovementScale
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._SourceMovementScale) == null)
				{
					result = (this._SourceMovementScale = new FRawDistributionVector(base.NativePtr + (IntPtr)UParticleModuleSourceMovement.__PropertyOffset_SourceMovementScale, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleSourceMovement.__PropertyOffset_SourceMovementScale, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600D769 RID: 55145 RVA: 0x0013D866 File Offset: 0x0013BA66
		static UParticleModuleSourceMovement()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleSourceMovement");
		}

		// Token: 0x0600D76A RID: 55146 RVA: 0x0013D874 File Offset: 0x0013BA74
		protected UParticleModuleSourceMovement(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007481 RID: 29825
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleSourceMovement";

		// Token: 0x04007482 RID: 29826
		private static IntPtr _ClassPtr;

		// Token: 0x04007483 RID: 29827
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007484 RID: 29828
		internal static int __PropertyOffset_SourceMovementScale;

		// Token: 0x04007485 RID: 29829
		[Nullable(2)]
		private FRawDistributionVector _SourceMovementScale;
	}
}
