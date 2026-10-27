using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F62 RID: 3938
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleColorOverLife")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class UParticleModuleColorOverLife : UParticleModuleColorBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D4AD RID: 54445 RVA: 0x00138821 File Offset: 0x00136A21
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleColorOverLife._ClassPtr;
		}

		// Token: 0x0600D4AE RID: 54446 RVA: 0x00138830 File Offset: 0x00136A30
		public UParticleModuleColorOverLife() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleColorOverLife.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D4AF RID: 54447 RVA: 0x00138858 File Offset: 0x00136A58
		public UParticleModuleColorOverLife(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleColorOverLife.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170031E2 RID: 12770
		// (get) Token: 0x0600D4B0 RID: 54448 RVA: 0x0013888C File Offset: 0x00136A8C
		// (set) Token: 0x0600D4B1 RID: 54449 RVA: 0x001388C5 File Offset: 0x00136AC5
		public FRawDistributionVector ColorOverLife
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._ColorOverLife) == null)
				{
					result = (this._ColorOverLife = new FRawDistributionVector(base.NativePtr + (IntPtr)UParticleModuleColorOverLife.__PropertyOffset_ColorOverLife, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleColorOverLife.__PropertyOffset_ColorOverLife, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170031E3 RID: 12771
		// (get) Token: 0x0600D4B2 RID: 54450 RVA: 0x001388E8 File Offset: 0x00136AE8
		// (set) Token: 0x0600D4B3 RID: 54451 RVA: 0x00138921 File Offset: 0x00136B21
		public FRawDistributionFloat AlphaOverLife
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._AlphaOverLife) == null)
				{
					result = (this._AlphaOverLife = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleColorOverLife.__PropertyOffset_AlphaOverLife, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleColorOverLife.__PropertyOffset_AlphaOverLife, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170031E4 RID: 12772
		// (get) Token: 0x0600D4B4 RID: 54452 RVA: 0x00138942 File Offset: 0x00136B42
		// (set) Token: 0x0600D4B5 RID: 54453 RVA: 0x0013895B File Offset: 0x00136B5B
		public unsafe bool bClampAlpha
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleColorOverLife.__PropertyOffset_bClampAlpha) & UParticleModuleColorOverLife.__PropertyMask_bClampAlpha) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleColorOverLife.__PropertyOffset_bClampAlpha) = ((*(base.NativePtr + (IntPtr)UParticleModuleColorOverLife.__PropertyOffset_bClampAlpha) & ~UParticleModuleColorOverLife.__PropertyMask_bClampAlpha) | (value ? UParticleModuleColorOverLife.__PropertyMask_bClampAlpha : 0));
			}
		}

		// Token: 0x0600D4B6 RID: 54454 RVA: 0x0013898B File Offset: 0x00136B8B
		static UParticleModuleColorOverLife()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleColorOverLife");
		}

		// Token: 0x0600D4B7 RID: 54455 RVA: 0x00138999 File Offset: 0x00136B99
		protected UParticleModuleColorOverLife(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007280 RID: 29312
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleColorOverLife";

		// Token: 0x04007281 RID: 29313
		private static IntPtr _ClassPtr;

		// Token: 0x04007282 RID: 29314
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007283 RID: 29315
		internal static int __PropertyOffset_ColorOverLife;

		// Token: 0x04007284 RID: 29316
		[Nullable(2)]
		private FRawDistributionVector _ColorOverLife;

		// Token: 0x04007285 RID: 29317
		internal static int __PropertyOffset_AlphaOverLife;

		// Token: 0x04007286 RID: 29318
		[Nullable(2)]
		private FRawDistributionFloat _AlphaOverLife;

		// Token: 0x04007287 RID: 29319
		internal static int __PropertyOffset_bClampAlpha;

		// Token: 0x04007288 RID: 29320
		internal static byte __PropertyMask_bClampAlpha;
	}
}
