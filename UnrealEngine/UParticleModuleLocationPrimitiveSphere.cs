using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F7D RID: 3965
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleLocationPrimitiveSphere")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public class UParticleModuleLocationPrimitiveSphere : UParticleModuleLocationPrimitiveBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D5CF RID: 54735 RVA: 0x0013AA15 File Offset: 0x00138C15
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleLocationPrimitiveSphere._ClassPtr;
		}

		// Token: 0x0600D5D0 RID: 54736 RVA: 0x0013AA24 File Offset: 0x00138C24
		public UParticleModuleLocationPrimitiveSphere() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleLocationPrimitiveSphere.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D5D1 RID: 54737 RVA: 0x0013AA4C File Offset: 0x00138C4C
		public UParticleModuleLocationPrimitiveSphere(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleLocationPrimitiveSphere.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003233 RID: 12851
		// (get) Token: 0x0600D5D2 RID: 54738 RVA: 0x0013AA80 File Offset: 0x00138C80
		// (set) Token: 0x0600D5D3 RID: 54739 RVA: 0x0013AAB9 File Offset: 0x00138CB9
		public FRawDistributionFloat StartRadius
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._StartRadius) == null)
				{
					result = (this._StartRadius = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleLocationPrimitiveSphere.__PropertyOffset_StartRadius, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleLocationPrimitiveSphere.__PropertyOffset_StartRadius, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600D5D4 RID: 54740 RVA: 0x0013AADA File Offset: 0x00138CDA
		static UParticleModuleLocationPrimitiveSphere()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleLocationPrimitiveSphere");
		}

		// Token: 0x0600D5D5 RID: 54741 RVA: 0x0013AAE8 File Offset: 0x00138CE8
		protected UParticleModuleLocationPrimitiveSphere(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400735C RID: 29532
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleLocationPrimitiveSphere";

		// Token: 0x0400735D RID: 29533
		private static IntPtr _ClassPtr;

		// Token: 0x0400735E RID: 29534
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400735F RID: 29535
		internal static int __PropertyOffset_StartRadius;

		// Token: 0x04007360 RID: 29536
		[Nullable(2)]
		private FRawDistributionFloat _StartRadius;
	}
}
