using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F86 RID: 3974
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleMeshRotation")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UParticleModuleMeshRotation : UParticleModuleRotationBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D62D RID: 54829 RVA: 0x0013B4FA File Offset: 0x001396FA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleMeshRotation._ClassPtr;
		}

		// Token: 0x0600D62E RID: 54830 RVA: 0x0013B508 File Offset: 0x00139708
		public UParticleModuleMeshRotation() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleMeshRotation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D62F RID: 54831 RVA: 0x0013B530 File Offset: 0x00139730
		public UParticleModuleMeshRotation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleMeshRotation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700324C RID: 12876
		// (get) Token: 0x0600D630 RID: 54832 RVA: 0x0013B564 File Offset: 0x00139764
		// (set) Token: 0x0600D631 RID: 54833 RVA: 0x0013B59D File Offset: 0x0013979D
		public FRawDistributionVector StartRotation
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._StartRotation) == null)
				{
					result = (this._StartRotation = new FRawDistributionVector(base.NativePtr + (IntPtr)UParticleModuleMeshRotation.__PropertyOffset_StartRotation, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleMeshRotation.__PropertyOffset_StartRotation, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700324D RID: 12877
		// (get) Token: 0x0600D632 RID: 54834 RVA: 0x0013B5BE File Offset: 0x001397BE
		// (set) Token: 0x0600D633 RID: 54835 RVA: 0x0013B5D7 File Offset: 0x001397D7
		public unsafe bool bInheritParent
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleMeshRotation.__PropertyOffset_bInheritParent) & UParticleModuleMeshRotation.__PropertyMask_bInheritParent) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleMeshRotation.__PropertyOffset_bInheritParent) = ((*(base.NativePtr + (IntPtr)UParticleModuleMeshRotation.__PropertyOffset_bInheritParent) & ~UParticleModuleMeshRotation.__PropertyMask_bInheritParent) | (value ? UParticleModuleMeshRotation.__PropertyMask_bInheritParent : 0));
			}
		}

		// Token: 0x0600D634 RID: 54836 RVA: 0x0013B607 File Offset: 0x00139807
		static UParticleModuleMeshRotation()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleMeshRotation");
		}

		// Token: 0x0600D635 RID: 54837 RVA: 0x0013B615 File Offset: 0x00139815
		protected UParticleModuleMeshRotation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040073A1 RID: 29601
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleMeshRotation";

		// Token: 0x040073A2 RID: 29602
		private static IntPtr _ClassPtr;

		// Token: 0x040073A3 RID: 29603
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040073A4 RID: 29604
		internal static int __PropertyOffset_StartRotation;

		// Token: 0x040073A5 RID: 29605
		[Nullable(2)]
		private FRawDistributionVector _StartRotation;

		// Token: 0x040073A6 RID: 29606
		internal static int __PropertyOffset_bInheritParent;

		// Token: 0x040073A7 RID: 29607
		internal static byte __PropertyMask_bInheritParent;
	}
}
