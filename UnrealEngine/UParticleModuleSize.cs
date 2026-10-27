using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F9D RID: 3997
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleSize")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UParticleModuleSize : UParticleModuleSizeBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D72F RID: 55087 RVA: 0x0013D165 File Offset: 0x0013B365
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleSize._ClassPtr;
		}

		// Token: 0x0600D730 RID: 55088 RVA: 0x0013D174 File Offset: 0x0013B374
		public UParticleModuleSize() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleSize.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D731 RID: 55089 RVA: 0x0013D19C File Offset: 0x0013B39C
		public UParticleModuleSize(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleSize.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003296 RID: 12950
		// (get) Token: 0x0600D732 RID: 55090 RVA: 0x0013D1D0 File Offset: 0x0013B3D0
		// (set) Token: 0x0600D733 RID: 55091 RVA: 0x0013D209 File Offset: 0x0013B409
		public FRawDistributionVector StartSize
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._StartSize) == null)
				{
					result = (this._StartSize = new FRawDistributionVector(base.NativePtr + (IntPtr)UParticleModuleSize.__PropertyOffset_StartSize, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleSize.__PropertyOffset_StartSize, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600D734 RID: 55092 RVA: 0x0013D22A File Offset: 0x0013B42A
		static UParticleModuleSize()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleSize");
		}

		// Token: 0x0600D735 RID: 55093 RVA: 0x0013D238 File Offset: 0x0013B438
		protected UParticleModuleSize(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007459 RID: 29785
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleSize";

		// Token: 0x0400745A RID: 29786
		private static IntPtr _ClassPtr;

		// Token: 0x0400745B RID: 29787
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400745C RID: 29788
		internal static int __PropertyOffset_StartSize;

		// Token: 0x0400745D RID: 29789
		[Nullable(2)]
		private FRawDistributionVector _StartSize;
	}
}
