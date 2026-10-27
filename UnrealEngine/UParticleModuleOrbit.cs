using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F8C RID: 3980
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleOrbit")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UParticleModuleOrbit : UParticleModuleOrbitBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D65B RID: 54875 RVA: 0x0013BAB1 File Offset: 0x00139CB1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleOrbit._ClassPtr;
		}

		// Token: 0x0600D65C RID: 54876 RVA: 0x0013BAC0 File Offset: 0x00139CC0
		public UParticleModuleOrbit() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleOrbit.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D65D RID: 54877 RVA: 0x0013BAE8 File Offset: 0x00139CE8
		public UParticleModuleOrbit(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleOrbit.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003254 RID: 12884
		// (get) Token: 0x0600D65E RID: 54878 RVA: 0x0013BB1B File Offset: 0x00139D1B
		// (set) Token: 0x0600D65F RID: 54879 RVA: 0x0013BB2F File Offset: 0x00139D2F
		[Nullable(0)]
		public unsafe TEnumAsByte<EOrbitChainMode> ChainMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleOrbit.__PropertyOffset_ChainMode);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleOrbit.__PropertyOffset_ChainMode) = value;
			}
		}

		// Token: 0x17003255 RID: 12885
		// (get) Token: 0x0600D660 RID: 54880 RVA: 0x0013BB44 File Offset: 0x00139D44
		// (set) Token: 0x0600D661 RID: 54881 RVA: 0x0013BB7D File Offset: 0x00139D7D
		public FRawDistributionVector OffsetAmount
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._OffsetAmount) == null)
				{
					result = (this._OffsetAmount = new FRawDistributionVector(base.NativePtr + (IntPtr)UParticleModuleOrbit.__PropertyOffset_OffsetAmount, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleOrbit.__PropertyOffset_OffsetAmount, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003256 RID: 12886
		// (get) Token: 0x0600D662 RID: 54882 RVA: 0x0013BBA0 File Offset: 0x00139DA0
		// (set) Token: 0x0600D663 RID: 54883 RVA: 0x0013BBD9 File Offset: 0x00139DD9
		public FOrbitOptions OffsetOptions
		{
			get
			{
				base.FastCheckIsValid();
				FOrbitOptions result;
				if ((result = this._OffsetOptions) == null)
				{
					result = (this._OffsetOptions = new FOrbitOptions(base.NativePtr + (IntPtr)UParticleModuleOrbit.__PropertyOffset_OffsetOptions, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FOrbitOptions.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleOrbit.__PropertyOffset_OffsetOptions, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003257 RID: 12887
		// (get) Token: 0x0600D664 RID: 54884 RVA: 0x0013BBFC File Offset: 0x00139DFC
		// (set) Token: 0x0600D665 RID: 54885 RVA: 0x0013BC35 File Offset: 0x00139E35
		public FRawDistributionVector RotationAmount
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._RotationAmount) == null)
				{
					result = (this._RotationAmount = new FRawDistributionVector(base.NativePtr + (IntPtr)UParticleModuleOrbit.__PropertyOffset_RotationAmount, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleOrbit.__PropertyOffset_RotationAmount, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003258 RID: 12888
		// (get) Token: 0x0600D666 RID: 54886 RVA: 0x0013BC58 File Offset: 0x00139E58
		// (set) Token: 0x0600D667 RID: 54887 RVA: 0x0013BC91 File Offset: 0x00139E91
		public FOrbitOptions RotationOptions
		{
			get
			{
				base.FastCheckIsValid();
				FOrbitOptions result;
				if ((result = this._RotationOptions) == null)
				{
					result = (this._RotationOptions = new FOrbitOptions(base.NativePtr + (IntPtr)UParticleModuleOrbit.__PropertyOffset_RotationOptions, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FOrbitOptions.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleOrbit.__PropertyOffset_RotationOptions, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003259 RID: 12889
		// (get) Token: 0x0600D668 RID: 54888 RVA: 0x0013BCB4 File Offset: 0x00139EB4
		// (set) Token: 0x0600D669 RID: 54889 RVA: 0x0013BCED File Offset: 0x00139EED
		public FRawDistributionVector RotationRateAmount
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._RotationRateAmount) == null)
				{
					result = (this._RotationRateAmount = new FRawDistributionVector(base.NativePtr + (IntPtr)UParticleModuleOrbit.__PropertyOffset_RotationRateAmount, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleOrbit.__PropertyOffset_RotationRateAmount, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700325A RID: 12890
		// (get) Token: 0x0600D66A RID: 54890 RVA: 0x0013BD10 File Offset: 0x00139F10
		// (set) Token: 0x0600D66B RID: 54891 RVA: 0x0013BD49 File Offset: 0x00139F49
		public FOrbitOptions RotationRateOptions
		{
			get
			{
				base.FastCheckIsValid();
				FOrbitOptions result;
				if ((result = this._RotationRateOptions) == null)
				{
					result = (this._RotationRateOptions = new FOrbitOptions(base.NativePtr + (IntPtr)UParticleModuleOrbit.__PropertyOffset_RotationRateOptions, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FOrbitOptions.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleOrbit.__PropertyOffset_RotationRateOptions, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600D66C RID: 54892 RVA: 0x0013BD6A File Offset: 0x00139F6A
		static UParticleModuleOrbit()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleOrbit");
		}

		// Token: 0x0600D66D RID: 54893 RVA: 0x0013BD78 File Offset: 0x00139F78
		protected UParticleModuleOrbit(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040073C3 RID: 29635
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleOrbit";

		// Token: 0x040073C4 RID: 29636
		private static IntPtr _ClassPtr;

		// Token: 0x040073C5 RID: 29637
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040073C6 RID: 29638
		internal static int __PropertyOffset_ChainMode;

		// Token: 0x040073C7 RID: 29639
		internal static int __PropertyOffset_OffsetAmount;

		// Token: 0x040073C8 RID: 29640
		[Nullable(2)]
		private FRawDistributionVector _OffsetAmount;

		// Token: 0x040073C9 RID: 29641
		internal static int __PropertyOffset_OffsetOptions;

		// Token: 0x040073CA RID: 29642
		[Nullable(2)]
		private FOrbitOptions _OffsetOptions;

		// Token: 0x040073CB RID: 29643
		internal static int __PropertyOffset_RotationAmount;

		// Token: 0x040073CC RID: 29644
		[Nullable(2)]
		private FRawDistributionVector _RotationAmount;

		// Token: 0x040073CD RID: 29645
		internal static int __PropertyOffset_RotationOptions;

		// Token: 0x040073CE RID: 29646
		[Nullable(2)]
		private FOrbitOptions _RotationOptions;

		// Token: 0x040073CF RID: 29647
		internal static int __PropertyOffset_RotationRateAmount;

		// Token: 0x040073D0 RID: 29648
		[Nullable(2)]
		private FRawDistributionVector _RotationRateAmount;

		// Token: 0x040073D1 RID: 29649
		internal static int __PropertyOffset_RotationRateOptions;

		// Token: 0x040073D2 RID: 29650
		[Nullable(2)]
		private FOrbitOptions _RotationRateOptions;
	}
}
