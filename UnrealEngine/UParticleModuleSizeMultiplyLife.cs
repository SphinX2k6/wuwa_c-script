using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F9F RID: 3999
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleSizeMultiplyLife")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UParticleModuleSizeMultiplyLife : UParticleModuleSizeBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D73A RID: 55098 RVA: 0x0013D28D File Offset: 0x0013B48D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleSizeMultiplyLife._ClassPtr;
		}

		// Token: 0x0600D73B RID: 55099 RVA: 0x0013D29C File Offset: 0x0013B49C
		public UParticleModuleSizeMultiplyLife() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleSizeMultiplyLife.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D73C RID: 55100 RVA: 0x0013D2C4 File Offset: 0x0013B4C4
		public UParticleModuleSizeMultiplyLife(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleSizeMultiplyLife.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003297 RID: 12951
		// (get) Token: 0x0600D73D RID: 55101 RVA: 0x0013D2F8 File Offset: 0x0013B4F8
		// (set) Token: 0x0600D73E RID: 55102 RVA: 0x0013D331 File Offset: 0x0013B531
		public FRawDistributionVector LifeMultiplier
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._LifeMultiplier) == null)
				{
					result = (this._LifeMultiplier = new FRawDistributionVector(base.NativePtr + (IntPtr)UParticleModuleSizeMultiplyLife.__PropertyOffset_LifeMultiplier, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleSizeMultiplyLife.__PropertyOffset_LifeMultiplier, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003298 RID: 12952
		// (get) Token: 0x0600D73F RID: 55103 RVA: 0x0013D352 File Offset: 0x0013B552
		// (set) Token: 0x0600D740 RID: 55104 RVA: 0x0013D36B File Offset: 0x0013B56B
		public unsafe bool MultiplyX
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleSizeMultiplyLife.__PropertyOffset_MultiplyX) & UParticleModuleSizeMultiplyLife.__PropertyMask_MultiplyX) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleSizeMultiplyLife.__PropertyOffset_MultiplyX) = ((*(base.NativePtr + (IntPtr)UParticleModuleSizeMultiplyLife.__PropertyOffset_MultiplyX) & ~UParticleModuleSizeMultiplyLife.__PropertyMask_MultiplyX) | (value ? UParticleModuleSizeMultiplyLife.__PropertyMask_MultiplyX : 0));
			}
		}

		// Token: 0x17003299 RID: 12953
		// (get) Token: 0x0600D741 RID: 55105 RVA: 0x0013D39B File Offset: 0x0013B59B
		// (set) Token: 0x0600D742 RID: 55106 RVA: 0x0013D3B4 File Offset: 0x0013B5B4
		public unsafe bool MultiplyY
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleSizeMultiplyLife.__PropertyOffset_MultiplyY) & UParticleModuleSizeMultiplyLife.__PropertyMask_MultiplyY) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleSizeMultiplyLife.__PropertyOffset_MultiplyY) = ((*(base.NativePtr + (IntPtr)UParticleModuleSizeMultiplyLife.__PropertyOffset_MultiplyY) & ~UParticleModuleSizeMultiplyLife.__PropertyMask_MultiplyY) | (value ? UParticleModuleSizeMultiplyLife.__PropertyMask_MultiplyY : 0));
			}
		}

		// Token: 0x1700329A RID: 12954
		// (get) Token: 0x0600D743 RID: 55107 RVA: 0x0013D3E4 File Offset: 0x0013B5E4
		// (set) Token: 0x0600D744 RID: 55108 RVA: 0x0013D3FD File Offset: 0x0013B5FD
		public unsafe bool MultiplyZ
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleSizeMultiplyLife.__PropertyOffset_MultiplyZ) & UParticleModuleSizeMultiplyLife.__PropertyMask_MultiplyZ) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleSizeMultiplyLife.__PropertyOffset_MultiplyZ) = ((*(base.NativePtr + (IntPtr)UParticleModuleSizeMultiplyLife.__PropertyOffset_MultiplyZ) & ~UParticleModuleSizeMultiplyLife.__PropertyMask_MultiplyZ) | (value ? UParticleModuleSizeMultiplyLife.__PropertyMask_MultiplyZ : 0));
			}
		}

		// Token: 0x0600D745 RID: 55109 RVA: 0x0013D42D File Offset: 0x0013B62D
		static UParticleModuleSizeMultiplyLife()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleSizeMultiplyLife");
		}

		// Token: 0x0600D746 RID: 55110 RVA: 0x0013D43B File Offset: 0x0013B63B
		protected UParticleModuleSizeMultiplyLife(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007461 RID: 29793
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleSizeMultiplyLife";

		// Token: 0x04007462 RID: 29794
		private static IntPtr _ClassPtr;

		// Token: 0x04007463 RID: 29795
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007464 RID: 29796
		internal static int __PropertyOffset_LifeMultiplier;

		// Token: 0x04007465 RID: 29797
		[Nullable(2)]
		private FRawDistributionVector _LifeMultiplier;

		// Token: 0x04007466 RID: 29798
		internal static int __PropertyOffset_MultiplyX;

		// Token: 0x04007467 RID: 29799
		internal static byte __PropertyMask_MultiplyX;

		// Token: 0x04007468 RID: 29800
		internal static int __PropertyOffset_MultiplyY;

		// Token: 0x04007469 RID: 29801
		internal static byte __PropertyMask_MultiplyY;

		// Token: 0x0400746A RID: 29802
		internal static int __PropertyOffset_MultiplyZ;

		// Token: 0x0400746B RID: 29803
		internal static byte __PropertyMask_MultiplyZ;
	}
}
