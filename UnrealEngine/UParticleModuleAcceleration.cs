using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F4B RID: 3915
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleAcceleration")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UParticleModuleAcceleration : UParticleModuleAccelerationBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D350 RID: 54096 RVA: 0x00135E15 File Offset: 0x00134015
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleAcceleration._ClassPtr;
		}

		// Token: 0x0600D351 RID: 54097 RVA: 0x00135E24 File Offset: 0x00134024
		public UParticleModuleAcceleration() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleAcceleration.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D352 RID: 54098 RVA: 0x00135E4C File Offset: 0x0013404C
		public UParticleModuleAcceleration(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleAcceleration.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700316A RID: 12650
		// (get) Token: 0x0600D353 RID: 54099 RVA: 0x00135E80 File Offset: 0x00134080
		// (set) Token: 0x0600D354 RID: 54100 RVA: 0x00135EB9 File Offset: 0x001340B9
		public FRawDistributionVector Acceleration
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._Acceleration) == null)
				{
					result = (this._Acceleration = new FRawDistributionVector(base.NativePtr + (IntPtr)UParticleModuleAcceleration.__PropertyOffset_Acceleration, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleAcceleration.__PropertyOffset_Acceleration, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700316B RID: 12651
		// (get) Token: 0x0600D355 RID: 54101 RVA: 0x00135EDA File Offset: 0x001340DA
		// (set) Token: 0x0600D356 RID: 54102 RVA: 0x00135EF3 File Offset: 0x001340F3
		public unsafe bool bApplyOwnerScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleAcceleration.__PropertyOffset_bApplyOwnerScale) & UParticleModuleAcceleration.__PropertyMask_bApplyOwnerScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleAcceleration.__PropertyOffset_bApplyOwnerScale) = ((*(base.NativePtr + (IntPtr)UParticleModuleAcceleration.__PropertyOffset_bApplyOwnerScale) & ~UParticleModuleAcceleration.__PropertyMask_bApplyOwnerScale) | (value ? UParticleModuleAcceleration.__PropertyMask_bApplyOwnerScale : 0));
			}
		}

		// Token: 0x0600D357 RID: 54103 RVA: 0x00135F23 File Offset: 0x00134123
		static UParticleModuleAcceleration()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleAcceleration");
		}

		// Token: 0x0600D358 RID: 54104 RVA: 0x00135F31 File Offset: 0x00134131
		protected UParticleModuleAcceleration(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007171 RID: 29041
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleAcceleration";

		// Token: 0x04007172 RID: 29042
		private static IntPtr _ClassPtr;

		// Token: 0x04007173 RID: 29043
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007174 RID: 29044
		internal static int __PropertyOffset_Acceleration;

		// Token: 0x04007175 RID: 29045
		[Nullable(2)]
		private FRawDistributionVector _Acceleration;

		// Token: 0x04007176 RID: 29046
		internal static int __PropertyOffset_bApplyOwnerScale;

		// Token: 0x04007177 RID: 29047
		internal static byte __PropertyMask_bApplyOwnerScale;
	}
}
