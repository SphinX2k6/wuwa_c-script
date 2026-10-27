using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F97 RID: 3991
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleRotationOverLifetime")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UParticleModuleRotationOverLifetime : UParticleModuleRotationBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D706 RID: 55046 RVA: 0x0013CC85 File Offset: 0x0013AE85
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleRotationOverLifetime._ClassPtr;
		}

		// Token: 0x0600D707 RID: 55047 RVA: 0x0013CC94 File Offset: 0x0013AE94
		public UParticleModuleRotationOverLifetime() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleRotationOverLifetime.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D708 RID: 55048 RVA: 0x0013CCBC File Offset: 0x0013AEBC
		public UParticleModuleRotationOverLifetime(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleRotationOverLifetime.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003290 RID: 12944
		// (get) Token: 0x0600D709 RID: 55049 RVA: 0x0013CCF0 File Offset: 0x0013AEF0
		// (set) Token: 0x0600D70A RID: 55050 RVA: 0x0013CD29 File Offset: 0x0013AF29
		public FRawDistributionFloat RotationOverLife
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._RotationOverLife) == null)
				{
					result = (this._RotationOverLife = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleRotationOverLifetime.__PropertyOffset_RotationOverLife, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleRotationOverLifetime.__PropertyOffset_RotationOverLife, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003291 RID: 12945
		// (get) Token: 0x0600D70B RID: 55051 RVA: 0x0013CD4A File Offset: 0x0013AF4A
		// (set) Token: 0x0600D70C RID: 55052 RVA: 0x0013CD63 File Offset: 0x0013AF63
		public unsafe bool Scale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleRotationOverLifetime.__PropertyOffset_Scale) & UParticleModuleRotationOverLifetime.__PropertyMask_Scale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleRotationOverLifetime.__PropertyOffset_Scale) = ((*(base.NativePtr + (IntPtr)UParticleModuleRotationOverLifetime.__PropertyOffset_Scale) & ~UParticleModuleRotationOverLifetime.__PropertyMask_Scale) | (value ? UParticleModuleRotationOverLifetime.__PropertyMask_Scale : 0));
			}
		}

		// Token: 0x0600D70D RID: 55053 RVA: 0x0013CD93 File Offset: 0x0013AF93
		static UParticleModuleRotationOverLifetime()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleRotationOverLifetime");
		}

		// Token: 0x0600D70E RID: 55054 RVA: 0x0013CDA1 File Offset: 0x0013AFA1
		protected UParticleModuleRotationOverLifetime(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400743B RID: 29755
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleRotationOverLifetime";

		// Token: 0x0400743C RID: 29756
		private static IntPtr _ClassPtr;

		// Token: 0x0400743D RID: 29757
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400743E RID: 29758
		internal static int __PropertyOffset_RotationOverLife;

		// Token: 0x0400743F RID: 29759
		[Nullable(2)]
		private FRawDistributionFloat _RotationOverLife;

		// Token: 0x04007440 RID: 29760
		internal static int __PropertyOffset_Scale;

		// Token: 0x04007441 RID: 29761
		internal static byte __PropertyMask_Scale;
	}
}
