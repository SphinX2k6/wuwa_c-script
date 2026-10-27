using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F95 RID: 3989
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleRotation")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UParticleModuleRotation : UParticleModuleRotationBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D6FB RID: 55035 RVA: 0x0013CB5E File Offset: 0x0013AD5E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleRotation._ClassPtr;
		}

		// Token: 0x0600D6FC RID: 55036 RVA: 0x0013CB6C File Offset: 0x0013AD6C
		public UParticleModuleRotation() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleRotation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D6FD RID: 55037 RVA: 0x0013CB94 File Offset: 0x0013AD94
		public UParticleModuleRotation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleRotation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700328F RID: 12943
		// (get) Token: 0x0600D6FE RID: 55038 RVA: 0x0013CBC8 File Offset: 0x0013ADC8
		// (set) Token: 0x0600D6FF RID: 55039 RVA: 0x0013CC01 File Offset: 0x0013AE01
		public FRawDistributionFloat StartRotation
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._StartRotation) == null)
				{
					result = (this._StartRotation = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleRotation.__PropertyOffset_StartRotation, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleRotation.__PropertyOffset_StartRotation, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600D700 RID: 55040 RVA: 0x0013CC22 File Offset: 0x0013AE22
		static UParticleModuleRotation()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleRotation");
		}

		// Token: 0x0600D701 RID: 55041 RVA: 0x0013CC30 File Offset: 0x0013AE30
		protected UParticleModuleRotation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007433 RID: 29747
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleRotation";

		// Token: 0x04007434 RID: 29748
		private static IntPtr _ClassPtr;

		// Token: 0x04007435 RID: 29749
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007436 RID: 29750
		internal static int __PropertyOffset_StartRotation;

		// Token: 0x04007437 RID: 29751
		[Nullable(2)]
		private FRawDistributionFloat _StartRotation;
	}
}
