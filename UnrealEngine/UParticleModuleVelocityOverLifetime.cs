using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FBD RID: 4029
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleVelocityOverLifetime")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UParticleModuleVelocityOverLifetime : UParticleModuleVelocityBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D8DC RID: 55516 RVA: 0x00140129 File Offset: 0x0013E329
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleVelocityOverLifetime._ClassPtr;
		}

		// Token: 0x0600D8DD RID: 55517 RVA: 0x00140138 File Offset: 0x0013E338
		public UParticleModuleVelocityOverLifetime() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleVelocityOverLifetime.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D8DE RID: 55518 RVA: 0x00140160 File Offset: 0x0013E360
		public UParticleModuleVelocityOverLifetime(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleVelocityOverLifetime.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003320 RID: 13088
		// (get) Token: 0x0600D8DF RID: 55519 RVA: 0x00140194 File Offset: 0x0013E394
		// (set) Token: 0x0600D8E0 RID: 55520 RVA: 0x001401CD File Offset: 0x0013E3CD
		public FRawDistributionVector VelOverLife
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._VelOverLife) == null)
				{
					result = (this._VelOverLife = new FRawDistributionVector(base.NativePtr + (IntPtr)UParticleModuleVelocityOverLifetime.__PropertyOffset_VelOverLife, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleVelocityOverLifetime.__PropertyOffset_VelOverLife, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003321 RID: 13089
		// (get) Token: 0x0600D8E1 RID: 55521 RVA: 0x001401EE File Offset: 0x0013E3EE
		// (set) Token: 0x0600D8E2 RID: 55522 RVA: 0x00140207 File Offset: 0x0013E407
		public unsafe bool Absolute
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleVelocityOverLifetime.__PropertyOffset_Absolute) & UParticleModuleVelocityOverLifetime.__PropertyMask_Absolute) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleVelocityOverLifetime.__PropertyOffset_Absolute) = ((*(base.NativePtr + (IntPtr)UParticleModuleVelocityOverLifetime.__PropertyOffset_Absolute) & ~UParticleModuleVelocityOverLifetime.__PropertyMask_Absolute) | (value ? UParticleModuleVelocityOverLifetime.__PropertyMask_Absolute : 0));
			}
		}

		// Token: 0x0600D8E3 RID: 55523 RVA: 0x00140237 File Offset: 0x0013E437
		static UParticleModuleVelocityOverLifetime()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleVelocityOverLifetime");
		}

		// Token: 0x0600D8E4 RID: 55524 RVA: 0x00140245 File Offset: 0x0013E445
		protected UParticleModuleVelocityOverLifetime(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007595 RID: 30101
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleVelocityOverLifetime";

		// Token: 0x04007596 RID: 30102
		private static IntPtr _ClassPtr;

		// Token: 0x04007597 RID: 30103
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007598 RID: 30104
		internal static int __PropertyOffset_VelOverLife;

		// Token: 0x04007599 RID: 30105
		[Nullable(2)]
		private FRawDistributionVector _VelOverLife;

		// Token: 0x0400759A RID: 30106
		internal static int __PropertyOffset_Absolute;

		// Token: 0x0400759B RID: 30107
		internal static byte __PropertyMask_Absolute;
	}
}
