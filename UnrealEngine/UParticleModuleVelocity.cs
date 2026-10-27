using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FB9 RID: 4025
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleVelocity")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class UParticleModuleVelocity : UParticleModuleVelocityBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D8B9 RID: 55481 RVA: 0x0013FCD5 File Offset: 0x0013DED5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleVelocity._ClassPtr;
		}

		// Token: 0x0600D8BA RID: 55482 RVA: 0x0013FCE4 File Offset: 0x0013DEE4
		public UParticleModuleVelocity() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleVelocity.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D8BB RID: 55483 RVA: 0x0013FD0C File Offset: 0x0013DF0C
		public UParticleModuleVelocity(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleVelocity.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003318 RID: 13080
		// (get) Token: 0x0600D8BC RID: 55484 RVA: 0x0013FD40 File Offset: 0x0013DF40
		// (set) Token: 0x0600D8BD RID: 55485 RVA: 0x0013FD79 File Offset: 0x0013DF79
		public FRawDistributionVector StartVelocity
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._StartVelocity) == null)
				{
					result = (this._StartVelocity = new FRawDistributionVector(base.NativePtr + (IntPtr)UParticleModuleVelocity.__PropertyOffset_StartVelocity, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleVelocity.__PropertyOffset_StartVelocity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003319 RID: 13081
		// (get) Token: 0x0600D8BE RID: 55486 RVA: 0x0013FD9C File Offset: 0x0013DF9C
		// (set) Token: 0x0600D8BF RID: 55487 RVA: 0x0013FDD5 File Offset: 0x0013DFD5
		public FRawDistributionFloat StartVelocityRadial
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._StartVelocityRadial) == null)
				{
					result = (this._StartVelocityRadial = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleVelocity.__PropertyOffset_StartVelocityRadial, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleVelocity.__PropertyOffset_StartVelocityRadial, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600D8C0 RID: 55488 RVA: 0x0013FDF6 File Offset: 0x0013DFF6
		static UParticleModuleVelocity()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleVelocity");
		}

		// Token: 0x0600D8C1 RID: 55489 RVA: 0x0013FE04 File Offset: 0x0013E004
		protected UParticleModuleVelocity(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400757A RID: 30074
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleVelocity";

		// Token: 0x0400757B RID: 30075
		private static IntPtr _ClassPtr;

		// Token: 0x0400757C RID: 30076
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400757D RID: 30077
		internal static int __PropertyOffset_StartVelocity;

		// Token: 0x0400757E RID: 30078
		[Nullable(2)]
		private FRawDistributionVector _StartVelocity;

		// Token: 0x0400757F RID: 30079
		internal static int __PropertyOffset_StartVelocityRadial;

		// Token: 0x04007580 RID: 30080
		[Nullable(2)]
		private FRawDistributionFloat _StartVelocityRadial;
	}
}
