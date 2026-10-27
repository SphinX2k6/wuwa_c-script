using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F5A RID: 3930
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleBeamTarget")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class UParticleModuleBeamTarget : UParticleModuleBeamBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D432 RID: 54322 RVA: 0x001379CE File Offset: 0x00135BCE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleBeamTarget._ClassPtr;
		}

		// Token: 0x0600D433 RID: 54323 RVA: 0x001379DC File Offset: 0x00135BDC
		public UParticleModuleBeamTarget() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleBeamTarget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D434 RID: 54324 RVA: 0x00137A04 File Offset: 0x00135C04
		public UParticleModuleBeamTarget(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleBeamTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170031B7 RID: 12727
		// (get) Token: 0x0600D435 RID: 54325 RVA: 0x00137A37 File Offset: 0x00135C37
		// (set) Token: 0x0600D436 RID: 54326 RVA: 0x00137A4B File Offset: 0x00135C4B
		[Nullable(0)]
		public unsafe TEnumAsByte<Beam2SourceTargetMethod> TargetMethod
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleBeamTarget.__PropertyOffset_TargetMethod);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleBeamTarget.__PropertyOffset_TargetMethod) = value;
			}
		}

		// Token: 0x170031B8 RID: 12728
		// (get) Token: 0x0600D437 RID: 54327 RVA: 0x00137A60 File Offset: 0x00135C60
		// (set) Token: 0x0600D438 RID: 54328 RVA: 0x00137A74 File Offset: 0x00135C74
		public unsafe FName TargetName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleBeamTarget.__PropertyOffset_TargetName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleBeamTarget.__PropertyOffset_TargetName) = value;
			}
		}

		// Token: 0x170031B9 RID: 12729
		// (get) Token: 0x0600D439 RID: 54329 RVA: 0x00137A8C File Offset: 0x00135C8C
		// (set) Token: 0x0600D43A RID: 54330 RVA: 0x00137AC5 File Offset: 0x00135CC5
		public FRawDistributionVector Target
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._Target) == null)
				{
					result = (this._Target = new FRawDistributionVector(base.NativePtr + (IntPtr)UParticleModuleBeamTarget.__PropertyOffset_Target, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleBeamTarget.__PropertyOffset_Target, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170031BA RID: 12730
		// (get) Token: 0x0600D43B RID: 54331 RVA: 0x00137AE6 File Offset: 0x00135CE6
		// (set) Token: 0x0600D43C RID: 54332 RVA: 0x00137AFF File Offset: 0x00135CFF
		public unsafe bool bTargetAbsolute
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleBeamTarget.__PropertyOffset_bTargetAbsolute) & UParticleModuleBeamTarget.__PropertyMask_bTargetAbsolute) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleBeamTarget.__PropertyOffset_bTargetAbsolute) = ((*(base.NativePtr + (IntPtr)UParticleModuleBeamTarget.__PropertyOffset_bTargetAbsolute) & ~UParticleModuleBeamTarget.__PropertyMask_bTargetAbsolute) | (value ? UParticleModuleBeamTarget.__PropertyMask_bTargetAbsolute : 0));
			}
		}

		// Token: 0x170031BB RID: 12731
		// (get) Token: 0x0600D43D RID: 54333 RVA: 0x00137B2F File Offset: 0x00135D2F
		// (set) Token: 0x0600D43E RID: 54334 RVA: 0x00137B48 File Offset: 0x00135D48
		public unsafe bool bLockTarget
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleBeamTarget.__PropertyOffset_bLockTarget) & UParticleModuleBeamTarget.__PropertyMask_bLockTarget) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleBeamTarget.__PropertyOffset_bLockTarget) = ((*(base.NativePtr + (IntPtr)UParticleModuleBeamTarget.__PropertyOffset_bLockTarget) & ~UParticleModuleBeamTarget.__PropertyMask_bLockTarget) | (value ? UParticleModuleBeamTarget.__PropertyMask_bLockTarget : 0));
			}
		}

		// Token: 0x170031BC RID: 12732
		// (get) Token: 0x0600D43F RID: 54335 RVA: 0x00137B78 File Offset: 0x00135D78
		// (set) Token: 0x0600D440 RID: 54336 RVA: 0x00137B8C File Offset: 0x00135D8C
		[Nullable(0)]
		public unsafe TEnumAsByte<Beam2SourceTargetTangentMethod> TargetTangentMethod
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleBeamTarget.__PropertyOffset_TargetTangentMethod);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleBeamTarget.__PropertyOffset_TargetTangentMethod) = value;
			}
		}

		// Token: 0x170031BD RID: 12733
		// (get) Token: 0x0600D441 RID: 54337 RVA: 0x00137BA4 File Offset: 0x00135DA4
		// (set) Token: 0x0600D442 RID: 54338 RVA: 0x00137BDD File Offset: 0x00135DDD
		public FRawDistributionVector TargetTangent
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._TargetTangent) == null)
				{
					result = (this._TargetTangent = new FRawDistributionVector(base.NativePtr + (IntPtr)UParticleModuleBeamTarget.__PropertyOffset_TargetTangent, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleBeamTarget.__PropertyOffset_TargetTangent, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170031BE RID: 12734
		// (get) Token: 0x0600D443 RID: 54339 RVA: 0x00137BFE File Offset: 0x00135DFE
		// (set) Token: 0x0600D444 RID: 54340 RVA: 0x00137C17 File Offset: 0x00135E17
		public unsafe bool bLockTargetTangent
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleBeamTarget.__PropertyOffset_bLockTargetTangent) & UParticleModuleBeamTarget.__PropertyMask_bLockTargetTangent) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleBeamTarget.__PropertyOffset_bLockTargetTangent) = ((*(base.NativePtr + (IntPtr)UParticleModuleBeamTarget.__PropertyOffset_bLockTargetTangent) & ~UParticleModuleBeamTarget.__PropertyMask_bLockTargetTangent) | (value ? UParticleModuleBeamTarget.__PropertyMask_bLockTargetTangent : 0));
			}
		}

		// Token: 0x170031BF RID: 12735
		// (get) Token: 0x0600D445 RID: 54341 RVA: 0x00137C48 File Offset: 0x00135E48
		// (set) Token: 0x0600D446 RID: 54342 RVA: 0x00137C81 File Offset: 0x00135E81
		public FRawDistributionFloat TargetStrength
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._TargetStrength) == null)
				{
					result = (this._TargetStrength = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleBeamTarget.__PropertyOffset_TargetStrength, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleBeamTarget.__PropertyOffset_TargetStrength, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170031C0 RID: 12736
		// (get) Token: 0x0600D447 RID: 54343 RVA: 0x00137CA2 File Offset: 0x00135EA2
		// (set) Token: 0x0600D448 RID: 54344 RVA: 0x00137CBB File Offset: 0x00135EBB
		public unsafe bool bLockTargetStength
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleBeamTarget.__PropertyOffset_bLockTargetStength) & UParticleModuleBeamTarget.__PropertyMask_bLockTargetStength) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleBeamTarget.__PropertyOffset_bLockTargetStength) = ((*(base.NativePtr + (IntPtr)UParticleModuleBeamTarget.__PropertyOffset_bLockTargetStength) & ~UParticleModuleBeamTarget.__PropertyMask_bLockTargetStength) | (value ? UParticleModuleBeamTarget.__PropertyMask_bLockTargetStength : 0));
			}
		}

		// Token: 0x170031C1 RID: 12737
		// (get) Token: 0x0600D449 RID: 54345 RVA: 0x00137CEB File Offset: 0x00135EEB
		// (set) Token: 0x0600D44A RID: 54346 RVA: 0x00137CFB File Offset: 0x00135EFB
		public unsafe float LockRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleBeamTarget.__PropertyOffset_LockRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleBeamTarget.__PropertyOffset_LockRadius) = value;
			}
		}

		// Token: 0x0600D44B RID: 54347 RVA: 0x00137D0C File Offset: 0x00135F0C
		static UParticleModuleBeamTarget()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleBeamTarget");
		}

		// Token: 0x0600D44C RID: 54348 RVA: 0x00137D1A File Offset: 0x00135F1A
		protected UParticleModuleBeamTarget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007222 RID: 29218
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleBeamTarget";

		// Token: 0x04007223 RID: 29219
		private static IntPtr _ClassPtr;

		// Token: 0x04007224 RID: 29220
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007225 RID: 29221
		internal static int __PropertyOffset_TargetMethod;

		// Token: 0x04007226 RID: 29222
		internal static int __PropertyOffset_TargetName;

		// Token: 0x04007227 RID: 29223
		internal static int __PropertyOffset_Target;

		// Token: 0x04007228 RID: 29224
		[Nullable(2)]
		private FRawDistributionVector _Target;

		// Token: 0x04007229 RID: 29225
		internal static int __PropertyOffset_bTargetAbsolute;

		// Token: 0x0400722A RID: 29226
		internal static byte __PropertyMask_bTargetAbsolute;

		// Token: 0x0400722B RID: 29227
		internal static int __PropertyOffset_bLockTarget;

		// Token: 0x0400722C RID: 29228
		internal static byte __PropertyMask_bLockTarget;

		// Token: 0x0400722D RID: 29229
		internal static int __PropertyOffset_TargetTangentMethod;

		// Token: 0x0400722E RID: 29230
		internal static int __PropertyOffset_TargetTangent;

		// Token: 0x0400722F RID: 29231
		[Nullable(2)]
		private FRawDistributionVector _TargetTangent;

		// Token: 0x04007230 RID: 29232
		internal static int __PropertyOffset_bLockTargetTangent;

		// Token: 0x04007231 RID: 29233
		internal static byte __PropertyMask_bLockTargetTangent;

		// Token: 0x04007232 RID: 29234
		internal static int __PropertyOffset_TargetStrength;

		// Token: 0x04007233 RID: 29235
		[Nullable(2)]
		private FRawDistributionFloat _TargetStrength;

		// Token: 0x04007234 RID: 29236
		internal static int __PropertyOffset_bLockTargetStength;

		// Token: 0x04007235 RID: 29237
		internal static byte __PropertyMask_bLockTargetStength;

		// Token: 0x04007236 RID: 29238
		internal static int __PropertyOffset_LockRadius;
	}
}
