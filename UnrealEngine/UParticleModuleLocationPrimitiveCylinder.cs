using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F7B RID: 3963
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleLocationPrimitiveCylinder")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class UParticleModuleLocationPrimitiveCylinder : UParticleModuleLocationPrimitiveBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D5BB RID: 54715 RVA: 0x0013A791 File Offset: 0x00138991
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleLocationPrimitiveCylinder._ClassPtr;
		}

		// Token: 0x0600D5BC RID: 54716 RVA: 0x0013A7A0 File Offset: 0x001389A0
		public UParticleModuleLocationPrimitiveCylinder() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleLocationPrimitiveCylinder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D5BD RID: 54717 RVA: 0x0013A7C8 File Offset: 0x001389C8
		public UParticleModuleLocationPrimitiveCylinder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleLocationPrimitiveCylinder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700322E RID: 12846
		// (get) Token: 0x0600D5BE RID: 54718 RVA: 0x0013A7FB File Offset: 0x001389FB
		// (set) Token: 0x0600D5BF RID: 54719 RVA: 0x0013A814 File Offset: 0x00138A14
		public unsafe bool RadialVelocity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleLocationPrimitiveCylinder.__PropertyOffset_RadialVelocity) & UParticleModuleLocationPrimitiveCylinder.__PropertyMask_RadialVelocity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleLocationPrimitiveCylinder.__PropertyOffset_RadialVelocity) = ((*(base.NativePtr + (IntPtr)UParticleModuleLocationPrimitiveCylinder.__PropertyOffset_RadialVelocity) & ~UParticleModuleLocationPrimitiveCylinder.__PropertyMask_RadialVelocity) | (value ? UParticleModuleLocationPrimitiveCylinder.__PropertyMask_RadialVelocity : 0));
			}
		}

		// Token: 0x1700322F RID: 12847
		// (get) Token: 0x0600D5C0 RID: 54720 RVA: 0x0013A844 File Offset: 0x00138A44
		// (set) Token: 0x0600D5C1 RID: 54721 RVA: 0x0013A87D File Offset: 0x00138A7D
		public FRawDistributionFloat StartRadius
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._StartRadius) == null)
				{
					result = (this._StartRadius = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleLocationPrimitiveCylinder.__PropertyOffset_StartRadius, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleLocationPrimitiveCylinder.__PropertyOffset_StartRadius, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003230 RID: 12848
		// (get) Token: 0x0600D5C2 RID: 54722 RVA: 0x0013A8A0 File Offset: 0x00138AA0
		// (set) Token: 0x0600D5C3 RID: 54723 RVA: 0x0013A8D9 File Offset: 0x00138AD9
		public FRawDistributionFloat StartHeight
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._StartHeight) == null)
				{
					result = (this._StartHeight = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleLocationPrimitiveCylinder.__PropertyOffset_StartHeight, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleLocationPrimitiveCylinder.__PropertyOffset_StartHeight, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003231 RID: 12849
		// (get) Token: 0x0600D5C4 RID: 54724 RVA: 0x0013A8FA File Offset: 0x00138AFA
		// (set) Token: 0x0600D5C5 RID: 54725 RVA: 0x0013A90E File Offset: 0x00138B0E
		[Nullable(0)]
		public unsafe TEnumAsByte<CylinderHeightAxis> HeightAxis
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleLocationPrimitiveCylinder.__PropertyOffset_HeightAxis);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleLocationPrimitiveCylinder.__PropertyOffset_HeightAxis) = value;
			}
		}

		// Token: 0x0600D5C6 RID: 54726 RVA: 0x0013A923 File Offset: 0x00138B23
		static UParticleModuleLocationPrimitiveCylinder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleLocationPrimitiveCylinder");
		}

		// Token: 0x0600D5C7 RID: 54727 RVA: 0x0013A931 File Offset: 0x00138B31
		protected UParticleModuleLocationPrimitiveCylinder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400734D RID: 29517
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleLocationPrimitiveCylinder";

		// Token: 0x0400734E RID: 29518
		private static IntPtr _ClassPtr;

		// Token: 0x0400734F RID: 29519
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007350 RID: 29520
		internal static int __PropertyOffset_RadialVelocity;

		// Token: 0x04007351 RID: 29521
		internal static byte __PropertyMask_RadialVelocity;

		// Token: 0x04007352 RID: 29522
		internal static int __PropertyOffset_StartRadius;

		// Token: 0x04007353 RID: 29523
		[Nullable(2)]
		private FRawDistributionFloat _StartRadius;

		// Token: 0x04007354 RID: 29524
		internal static int __PropertyOffset_StartHeight;

		// Token: 0x04007355 RID: 29525
		[Nullable(2)]
		private FRawDistributionFloat _StartHeight;

		// Token: 0x04007356 RID: 29526
		internal static int __PropertyOffset_HeightAxis;
	}
}
