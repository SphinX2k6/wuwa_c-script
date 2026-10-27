using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FB8 RID: 4024
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleVectorFieldScaleOverLife")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UParticleModuleVectorFieldScaleOverLife : UParticleModuleVectorFieldBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D8B0 RID: 55472 RVA: 0x0013FBD1 File Offset: 0x0013DDD1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleVectorFieldScaleOverLife._ClassPtr;
		}

		// Token: 0x0600D8B1 RID: 55473 RVA: 0x0013FBE0 File Offset: 0x0013DDE0
		public UParticleModuleVectorFieldScaleOverLife() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleVectorFieldScaleOverLife.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D8B2 RID: 55474 RVA: 0x0013FC08 File Offset: 0x0013DE08
		public UParticleModuleVectorFieldScaleOverLife(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleVectorFieldScaleOverLife.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003316 RID: 13078
		// (get) Token: 0x0600D8B3 RID: 55475 RVA: 0x0013FC3B File Offset: 0x0013DE3B
		// (set) Token: 0x0600D8B4 RID: 55476 RVA: 0x0013FC4F File Offset: 0x0013DE4F
		[Nullable(2)]
		public unsafe UDistributionFloat VectorFieldScaleOverLife_DEPRECATED
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDistributionFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UParticleModuleVectorFieldScaleOverLife.__PropertyOffset_VectorFieldScaleOverLife_DEPRECATED);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UParticleModuleVectorFieldScaleOverLife.__PropertyOffset_VectorFieldScaleOverLife_DEPRECATED, value);
			}
		}

		// Token: 0x17003317 RID: 13079
		// (get) Token: 0x0600D8B5 RID: 55477 RVA: 0x0013FC64 File Offset: 0x0013DE64
		// (set) Token: 0x0600D8B6 RID: 55478 RVA: 0x0013FC9D File Offset: 0x0013DE9D
		public FRawDistributionFloat VectorFieldScaleOverLifeRaw
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._VectorFieldScaleOverLifeRaw) == null)
				{
					result = (this._VectorFieldScaleOverLifeRaw = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleVectorFieldScaleOverLife.__PropertyOffset_VectorFieldScaleOverLifeRaw, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleVectorFieldScaleOverLife.__PropertyOffset_VectorFieldScaleOverLifeRaw, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600D8B7 RID: 55479 RVA: 0x0013FCBE File Offset: 0x0013DEBE
		static UParticleModuleVectorFieldScaleOverLife()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleVectorFieldScaleOverLife");
		}

		// Token: 0x0600D8B8 RID: 55480 RVA: 0x0013FCCC File Offset: 0x0013DECC
		protected UParticleModuleVectorFieldScaleOverLife(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007574 RID: 30068
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleVectorFieldScaleOverLife";

		// Token: 0x04007575 RID: 30069
		private static IntPtr _ClassPtr;

		// Token: 0x04007576 RID: 30070
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007577 RID: 30071
		internal static int __PropertyOffset_VectorFieldScaleOverLife_DEPRECATED;

		// Token: 0x04007578 RID: 30072
		internal static int __PropertyOffset_VectorFieldScaleOverLifeRaw;

		// Token: 0x04007579 RID: 30073
		[Nullable(2)]
		private FRawDistributionFloat _VectorFieldScaleOverLifeRaw;
	}
}
