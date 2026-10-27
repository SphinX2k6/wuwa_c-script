using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F63 RID: 3939
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleColorScaleOverLife")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class UParticleModuleColorScaleOverLife : UParticleModuleColorBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D4B8 RID: 54456 RVA: 0x001389A2 File Offset: 0x00136BA2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleColorScaleOverLife._ClassPtr;
		}

		// Token: 0x0600D4B9 RID: 54457 RVA: 0x001389B0 File Offset: 0x00136BB0
		public UParticleModuleColorScaleOverLife() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleColorScaleOverLife.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D4BA RID: 54458 RVA: 0x001389D8 File Offset: 0x00136BD8
		public UParticleModuleColorScaleOverLife(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleColorScaleOverLife.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170031E5 RID: 12773
		// (get) Token: 0x0600D4BB RID: 54459 RVA: 0x00138A0C File Offset: 0x00136C0C
		// (set) Token: 0x0600D4BC RID: 54460 RVA: 0x00138A45 File Offset: 0x00136C45
		public FRawDistributionVector ColorScaleOverLife
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._ColorScaleOverLife) == null)
				{
					result = (this._ColorScaleOverLife = new FRawDistributionVector(base.NativePtr + (IntPtr)UParticleModuleColorScaleOverLife.__PropertyOffset_ColorScaleOverLife, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleColorScaleOverLife.__PropertyOffset_ColorScaleOverLife, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170031E6 RID: 12774
		// (get) Token: 0x0600D4BD RID: 54461 RVA: 0x00138A68 File Offset: 0x00136C68
		// (set) Token: 0x0600D4BE RID: 54462 RVA: 0x00138AA1 File Offset: 0x00136CA1
		public FRawDistributionFloat AlphaScaleOverLife
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._AlphaScaleOverLife) == null)
				{
					result = (this._AlphaScaleOverLife = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleColorScaleOverLife.__PropertyOffset_AlphaScaleOverLife, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleColorScaleOverLife.__PropertyOffset_AlphaScaleOverLife, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170031E7 RID: 12775
		// (get) Token: 0x0600D4BF RID: 54463 RVA: 0x00138AC2 File Offset: 0x00136CC2
		// (set) Token: 0x0600D4C0 RID: 54464 RVA: 0x00138ADB File Offset: 0x00136CDB
		public unsafe bool bEmitterTime
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleColorScaleOverLife.__PropertyOffset_bEmitterTime) & UParticleModuleColorScaleOverLife.__PropertyMask_bEmitterTime) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleColorScaleOverLife.__PropertyOffset_bEmitterTime) = ((*(base.NativePtr + (IntPtr)UParticleModuleColorScaleOverLife.__PropertyOffset_bEmitterTime) & ~UParticleModuleColorScaleOverLife.__PropertyMask_bEmitterTime) | (value ? UParticleModuleColorScaleOverLife.__PropertyMask_bEmitterTime : 0));
			}
		}

		// Token: 0x0600D4C1 RID: 54465 RVA: 0x00138B0B File Offset: 0x00136D0B
		static UParticleModuleColorScaleOverLife()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleColorScaleOverLife");
		}

		// Token: 0x0600D4C2 RID: 54466 RVA: 0x00138B19 File Offset: 0x00136D19
		protected UParticleModuleColorScaleOverLife(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007289 RID: 29321
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleColorScaleOverLife";

		// Token: 0x0400728A RID: 29322
		private static IntPtr _ClassPtr;

		// Token: 0x0400728B RID: 29323
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400728C RID: 29324
		internal static int __PropertyOffset_ColorScaleOverLife;

		// Token: 0x0400728D RID: 29325
		[Nullable(2)]
		private FRawDistributionVector _ColorScaleOverLife;

		// Token: 0x0400728E RID: 29326
		internal static int __PropertyOffset_AlphaScaleOverLife;

		// Token: 0x0400728F RID: 29327
		[Nullable(2)]
		private FRawDistributionFloat _AlphaScaleOverLife;

		// Token: 0x04007290 RID: 29328
		internal static int __PropertyOffset_bEmitterTime;

		// Token: 0x04007291 RID: 29329
		internal static byte __PropertyMask_bEmitterTime;
	}
}
