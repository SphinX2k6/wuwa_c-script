using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F59 RID: 3929
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleBeamSource")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class UParticleModuleBeamSource : UParticleModuleBeamBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D419 RID: 54297 RVA: 0x0013769D File Offset: 0x0013589D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleBeamSource._ClassPtr;
		}

		// Token: 0x0600D41A RID: 54298 RVA: 0x001376AC File Offset: 0x001358AC
		public UParticleModuleBeamSource() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleBeamSource.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D41B RID: 54299 RVA: 0x001376D4 File Offset: 0x001358D4
		public UParticleModuleBeamSource(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleBeamSource.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170031AD RID: 12717
		// (get) Token: 0x0600D41C RID: 54300 RVA: 0x00137707 File Offset: 0x00135907
		// (set) Token: 0x0600D41D RID: 54301 RVA: 0x0013771B File Offset: 0x0013591B
		[Nullable(0)]
		public unsafe TEnumAsByte<Beam2SourceTargetMethod> SourceMethod
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleBeamSource.__PropertyOffset_SourceMethod);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleBeamSource.__PropertyOffset_SourceMethod) = value;
			}
		}

		// Token: 0x170031AE RID: 12718
		// (get) Token: 0x0600D41E RID: 54302 RVA: 0x00137730 File Offset: 0x00135930
		// (set) Token: 0x0600D41F RID: 54303 RVA: 0x00137744 File Offset: 0x00135944
		public unsafe FName SourceName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleBeamSource.__PropertyOffset_SourceName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleBeamSource.__PropertyOffset_SourceName) = value;
			}
		}

		// Token: 0x170031AF RID: 12719
		// (get) Token: 0x0600D420 RID: 54304 RVA: 0x00137759 File Offset: 0x00135959
		// (set) Token: 0x0600D421 RID: 54305 RVA: 0x00137772 File Offset: 0x00135972
		public unsafe bool bSourceAbsolute
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleBeamSource.__PropertyOffset_bSourceAbsolute) & UParticleModuleBeamSource.__PropertyMask_bSourceAbsolute) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleBeamSource.__PropertyOffset_bSourceAbsolute) = ((*(base.NativePtr + (IntPtr)UParticleModuleBeamSource.__PropertyOffset_bSourceAbsolute) & ~UParticleModuleBeamSource.__PropertyMask_bSourceAbsolute) | (value ? UParticleModuleBeamSource.__PropertyMask_bSourceAbsolute : 0));
			}
		}

		// Token: 0x170031B0 RID: 12720
		// (get) Token: 0x0600D422 RID: 54306 RVA: 0x001377A4 File Offset: 0x001359A4
		// (set) Token: 0x0600D423 RID: 54307 RVA: 0x001377DD File Offset: 0x001359DD
		public FRawDistributionVector Source
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._Source) == null)
				{
					result = (this._Source = new FRawDistributionVector(base.NativePtr + (IntPtr)UParticleModuleBeamSource.__PropertyOffset_Source, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleBeamSource.__PropertyOffset_Source, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170031B1 RID: 12721
		// (get) Token: 0x0600D424 RID: 54308 RVA: 0x001377FE File Offset: 0x001359FE
		// (set) Token: 0x0600D425 RID: 54309 RVA: 0x00137817 File Offset: 0x00135A17
		public unsafe bool bLockSource
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleBeamSource.__PropertyOffset_bLockSource) & UParticleModuleBeamSource.__PropertyMask_bLockSource) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleBeamSource.__PropertyOffset_bLockSource) = ((*(base.NativePtr + (IntPtr)UParticleModuleBeamSource.__PropertyOffset_bLockSource) & ~UParticleModuleBeamSource.__PropertyMask_bLockSource) | (value ? UParticleModuleBeamSource.__PropertyMask_bLockSource : 0));
			}
		}

		// Token: 0x170031B2 RID: 12722
		// (get) Token: 0x0600D426 RID: 54310 RVA: 0x00137847 File Offset: 0x00135A47
		// (set) Token: 0x0600D427 RID: 54311 RVA: 0x0013785B File Offset: 0x00135A5B
		[Nullable(0)]
		public unsafe TEnumAsByte<Beam2SourceTargetTangentMethod> SourceTangentMethod
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleBeamSource.__PropertyOffset_SourceTangentMethod);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleBeamSource.__PropertyOffset_SourceTangentMethod) = value;
			}
		}

		// Token: 0x170031B3 RID: 12723
		// (get) Token: 0x0600D428 RID: 54312 RVA: 0x00137870 File Offset: 0x00135A70
		// (set) Token: 0x0600D429 RID: 54313 RVA: 0x001378A9 File Offset: 0x00135AA9
		public FRawDistributionVector SourceTangent
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._SourceTangent) == null)
				{
					result = (this._SourceTangent = new FRawDistributionVector(base.NativePtr + (IntPtr)UParticleModuleBeamSource.__PropertyOffset_SourceTangent, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleBeamSource.__PropertyOffset_SourceTangent, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170031B4 RID: 12724
		// (get) Token: 0x0600D42A RID: 54314 RVA: 0x001378CA File Offset: 0x00135ACA
		// (set) Token: 0x0600D42B RID: 54315 RVA: 0x001378E3 File Offset: 0x00135AE3
		public unsafe bool bLockSourceTangent
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleBeamSource.__PropertyOffset_bLockSourceTangent) & UParticleModuleBeamSource.__PropertyMask_bLockSourceTangent) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleBeamSource.__PropertyOffset_bLockSourceTangent) = ((*(base.NativePtr + (IntPtr)UParticleModuleBeamSource.__PropertyOffset_bLockSourceTangent) & ~UParticleModuleBeamSource.__PropertyMask_bLockSourceTangent) | (value ? UParticleModuleBeamSource.__PropertyMask_bLockSourceTangent : 0));
			}
		}

		// Token: 0x170031B5 RID: 12725
		// (get) Token: 0x0600D42C RID: 54316 RVA: 0x00137914 File Offset: 0x00135B14
		// (set) Token: 0x0600D42D RID: 54317 RVA: 0x0013794D File Offset: 0x00135B4D
		public FRawDistributionFloat SourceStrength
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._SourceStrength) == null)
				{
					result = (this._SourceStrength = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleBeamSource.__PropertyOffset_SourceStrength, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleBeamSource.__PropertyOffset_SourceStrength, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170031B6 RID: 12726
		// (get) Token: 0x0600D42E RID: 54318 RVA: 0x0013796E File Offset: 0x00135B6E
		// (set) Token: 0x0600D42F RID: 54319 RVA: 0x00137987 File Offset: 0x00135B87
		public unsafe bool bLockSourceStength
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleBeamSource.__PropertyOffset_bLockSourceStength) & UParticleModuleBeamSource.__PropertyMask_bLockSourceStength) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleBeamSource.__PropertyOffset_bLockSourceStength) = ((*(base.NativePtr + (IntPtr)UParticleModuleBeamSource.__PropertyOffset_bLockSourceStength) & ~UParticleModuleBeamSource.__PropertyMask_bLockSourceStength) | (value ? UParticleModuleBeamSource.__PropertyMask_bLockSourceStength : 0));
			}
		}

		// Token: 0x0600D430 RID: 54320 RVA: 0x001379B7 File Offset: 0x00135BB7
		static UParticleModuleBeamSource()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleBeamSource");
		}

		// Token: 0x0600D431 RID: 54321 RVA: 0x001379C5 File Offset: 0x00135BC5
		protected UParticleModuleBeamSource(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400720E RID: 29198
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleBeamSource";

		// Token: 0x0400720F RID: 29199
		private static IntPtr _ClassPtr;

		// Token: 0x04007210 RID: 29200
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007211 RID: 29201
		internal static int __PropertyOffset_SourceMethod;

		// Token: 0x04007212 RID: 29202
		internal static int __PropertyOffset_SourceName;

		// Token: 0x04007213 RID: 29203
		internal static int __PropertyOffset_bSourceAbsolute;

		// Token: 0x04007214 RID: 29204
		internal static byte __PropertyMask_bSourceAbsolute;

		// Token: 0x04007215 RID: 29205
		internal static int __PropertyOffset_Source;

		// Token: 0x04007216 RID: 29206
		[Nullable(2)]
		private FRawDistributionVector _Source;

		// Token: 0x04007217 RID: 29207
		internal static int __PropertyOffset_bLockSource;

		// Token: 0x04007218 RID: 29208
		internal static byte __PropertyMask_bLockSource;

		// Token: 0x04007219 RID: 29209
		internal static int __PropertyOffset_SourceTangentMethod;

		// Token: 0x0400721A RID: 29210
		internal static int __PropertyOffset_SourceTangent;

		// Token: 0x0400721B RID: 29211
		[Nullable(2)]
		private FRawDistributionVector _SourceTangent;

		// Token: 0x0400721C RID: 29212
		internal static int __PropertyOffset_bLockSourceTangent;

		// Token: 0x0400721D RID: 29213
		internal static byte __PropertyMask_bLockSourceTangent;

		// Token: 0x0400721E RID: 29214
		internal static int __PropertyOffset_SourceStrength;

		// Token: 0x0400721F RID: 29215
		[Nullable(2)]
		private FRawDistributionFloat _SourceStrength;

		// Token: 0x04007220 RID: 29216
		internal static int __PropertyOffset_bLockSourceStength;

		// Token: 0x04007221 RID: 29217
		internal static byte __PropertyMask_bLockSourceStength;
	}
}
