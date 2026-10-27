using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F5C RID: 3932
	[UnrealObjectPath("/Script/Engine.ParticleModuleCameraOffset")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UParticleModuleCameraOffset : UParticleModuleCameraBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D451 RID: 54353 RVA: 0x00137D71 File Offset: 0x00135F71
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleCameraOffset._ClassPtr;
		}

		// Token: 0x0600D452 RID: 54354 RVA: 0x00137D80 File Offset: 0x00135F80
		public UParticleModuleCameraOffset() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleCameraOffset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D453 RID: 54355 RVA: 0x00137DA8 File Offset: 0x00135FA8
		[NullableContext(1)]
		public UParticleModuleCameraOffset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleCameraOffset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170031C2 RID: 12738
		// (get) Token: 0x0600D454 RID: 54356 RVA: 0x00137DDC File Offset: 0x00135FDC
		// (set) Token: 0x0600D455 RID: 54357 RVA: 0x00137E15 File Offset: 0x00136015
		[Nullable(1)]
		public FRawDistributionFloat CameraOffset
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._CameraOffset) == null)
				{
					result = (this._CameraOffset = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleCameraOffset.__PropertyOffset_CameraOffset, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleCameraOffset.__PropertyOffset_CameraOffset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170031C3 RID: 12739
		// (get) Token: 0x0600D456 RID: 54358 RVA: 0x00137E36 File Offset: 0x00136036
		// (set) Token: 0x0600D457 RID: 54359 RVA: 0x00137E4F File Offset: 0x0013604F
		public unsafe bool bSpawnTimeOnly
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleCameraOffset.__PropertyOffset_bSpawnTimeOnly) & UParticleModuleCameraOffset.__PropertyMask_bSpawnTimeOnly) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleCameraOffset.__PropertyOffset_bSpawnTimeOnly) = ((*(base.NativePtr + (IntPtr)UParticleModuleCameraOffset.__PropertyOffset_bSpawnTimeOnly) & ~UParticleModuleCameraOffset.__PropertyMask_bSpawnTimeOnly) | (value ? UParticleModuleCameraOffset.__PropertyMask_bSpawnTimeOnly : 0));
			}
		}

		// Token: 0x170031C4 RID: 12740
		// (get) Token: 0x0600D458 RID: 54360 RVA: 0x00137E7F File Offset: 0x0013607F
		// (set) Token: 0x0600D459 RID: 54361 RVA: 0x00137E93 File Offset: 0x00136093
		public unsafe TEnumAsByte<EParticleCameraOffsetUpdateMethod> UpdateMethod
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleCameraOffset.__PropertyOffset_UpdateMethod);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleCameraOffset.__PropertyOffset_UpdateMethod) = value;
			}
		}

		// Token: 0x0600D45A RID: 54362 RVA: 0x00137EA8 File Offset: 0x001360A8
		static UParticleModuleCameraOffset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleCameraOffset");
		}

		// Token: 0x0600D45B RID: 54363 RVA: 0x00137EB6 File Offset: 0x001360B6
		protected UParticleModuleCameraOffset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400723A RID: 29242
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleCameraOffset";

		// Token: 0x0400723B RID: 29243
		private static IntPtr _ClassPtr;

		// Token: 0x0400723C RID: 29244
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400723D RID: 29245
		internal static int __PropertyOffset_CameraOffset;

		// Token: 0x0400723E RID: 29246
		[Nullable(2)]
		private FRawDistributionFloat _CameraOffset;

		// Token: 0x0400723F RID: 29247
		internal static int __PropertyOffset_bSpawnTimeOnly;

		// Token: 0x04007240 RID: 29248
		internal static byte __PropertyMask_bSpawnTimeOnly;

		// Token: 0x04007241 RID: 29249
		internal static int __PropertyOffset_UpdateMethod;
	}
}
