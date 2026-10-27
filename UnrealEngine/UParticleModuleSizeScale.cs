using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FA0 RID: 4000
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleSizeScale")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UParticleModuleSizeScale : UParticleModuleSizeBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D747 RID: 55111 RVA: 0x0013D444 File Offset: 0x0013B644
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleSizeScale._ClassPtr;
		}

		// Token: 0x0600D748 RID: 55112 RVA: 0x0013D450 File Offset: 0x0013B650
		public UParticleModuleSizeScale() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleSizeScale.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D749 RID: 55113 RVA: 0x0013D478 File Offset: 0x0013B678
		public UParticleModuleSizeScale(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleSizeScale.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700329B RID: 12955
		// (get) Token: 0x0600D74A RID: 55114 RVA: 0x0013D4AC File Offset: 0x0013B6AC
		// (set) Token: 0x0600D74B RID: 55115 RVA: 0x0013D4E5 File Offset: 0x0013B6E5
		public FRawDistributionVector SizeScale
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._SizeScale) == null)
				{
					result = (this._SizeScale = new FRawDistributionVector(base.NativePtr + (IntPtr)UParticleModuleSizeScale.__PropertyOffset_SizeScale, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleSizeScale.__PropertyOffset_SizeScale, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700329C RID: 12956
		// (get) Token: 0x0600D74C RID: 55116 RVA: 0x0013D506 File Offset: 0x0013B706
		// (set) Token: 0x0600D74D RID: 55117 RVA: 0x0013D51F File Offset: 0x0013B71F
		public unsafe bool EnableX
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleSizeScale.__PropertyOffset_EnableX) & UParticleModuleSizeScale.__PropertyMask_EnableX) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleSizeScale.__PropertyOffset_EnableX) = ((*(base.NativePtr + (IntPtr)UParticleModuleSizeScale.__PropertyOffset_EnableX) & ~UParticleModuleSizeScale.__PropertyMask_EnableX) | (value ? UParticleModuleSizeScale.__PropertyMask_EnableX : 0));
			}
		}

		// Token: 0x1700329D RID: 12957
		// (get) Token: 0x0600D74E RID: 55118 RVA: 0x0013D54F File Offset: 0x0013B74F
		// (set) Token: 0x0600D74F RID: 55119 RVA: 0x0013D568 File Offset: 0x0013B768
		public unsafe bool EnableY
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleSizeScale.__PropertyOffset_EnableY) & UParticleModuleSizeScale.__PropertyMask_EnableY) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleSizeScale.__PropertyOffset_EnableY) = ((*(base.NativePtr + (IntPtr)UParticleModuleSizeScale.__PropertyOffset_EnableY) & ~UParticleModuleSizeScale.__PropertyMask_EnableY) | (value ? UParticleModuleSizeScale.__PropertyMask_EnableY : 0));
			}
		}

		// Token: 0x1700329E RID: 12958
		// (get) Token: 0x0600D750 RID: 55120 RVA: 0x0013D598 File Offset: 0x0013B798
		// (set) Token: 0x0600D751 RID: 55121 RVA: 0x0013D5B1 File Offset: 0x0013B7B1
		public unsafe bool EnableZ
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleSizeScale.__PropertyOffset_EnableZ) & UParticleModuleSizeScale.__PropertyMask_EnableZ) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleSizeScale.__PropertyOffset_EnableZ) = ((*(base.NativePtr + (IntPtr)UParticleModuleSizeScale.__PropertyOffset_EnableZ) & ~UParticleModuleSizeScale.__PropertyMask_EnableZ) | (value ? UParticleModuleSizeScale.__PropertyMask_EnableZ : 0));
			}
		}

		// Token: 0x0600D752 RID: 55122 RVA: 0x0013D5E1 File Offset: 0x0013B7E1
		static UParticleModuleSizeScale()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleSizeScale");
		}

		// Token: 0x0600D753 RID: 55123 RVA: 0x0013D5EF File Offset: 0x0013B7EF
		protected UParticleModuleSizeScale(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400746C RID: 29804
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleSizeScale";

		// Token: 0x0400746D RID: 29805
		private static IntPtr _ClassPtr;

		// Token: 0x0400746E RID: 29806
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400746F RID: 29807
		internal static int __PropertyOffset_SizeScale;

		// Token: 0x04007470 RID: 29808
		[Nullable(2)]
		private FRawDistributionVector _SizeScale;

		// Token: 0x04007471 RID: 29809
		internal static int __PropertyOffset_EnableX;

		// Token: 0x04007472 RID: 29810
		internal static byte __PropertyMask_EnableX;

		// Token: 0x04007473 RID: 29811
		internal static int __PropertyOffset_EnableY;

		// Token: 0x04007474 RID: 29812
		internal static byte __PropertyMask_EnableY;

		// Token: 0x04007475 RID: 29813
		internal static int __PropertyOffset_EnableZ;

		// Token: 0x04007476 RID: 29814
		internal static byte __PropertyMask_EnableZ;
	}
}
