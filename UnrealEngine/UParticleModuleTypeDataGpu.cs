using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FAF RID: 4015
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleTypeDataGpu")]
	[UnrealStructLayout(1072, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class UParticleModuleTypeDataGpu : UParticleModuleTypeDataBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D80C RID: 55308 RVA: 0x0013EA15 File Offset: 0x0013CC15
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleTypeDataGpu._ClassPtr;
		}

		// Token: 0x0600D80D RID: 55309 RVA: 0x0013EA24 File Offset: 0x0013CC24
		public UParticleModuleTypeDataGpu() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleTypeDataGpu.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D80E RID: 55310 RVA: 0x0013EA4C File Offset: 0x0013CC4C
		public UParticleModuleTypeDataGpu(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleTypeDataGpu.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170032DA RID: 13018
		// (get) Token: 0x0600D80F RID: 55311 RVA: 0x0013EA80 File Offset: 0x0013CC80
		// (set) Token: 0x0600D810 RID: 55312 RVA: 0x0013EAB9 File Offset: 0x0013CCB9
		public FGPUSpriteEmitterInfo EmitterInfo
		{
			get
			{
				base.FastCheckIsValid();
				FGPUSpriteEmitterInfo result;
				if ((result = this._EmitterInfo) == null)
				{
					result = (this._EmitterInfo = new FGPUSpriteEmitterInfo(base.NativePtr + (IntPtr)UParticleModuleTypeDataGpu.__PropertyOffset_EmitterInfo, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGPUSpriteEmitterInfo.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleTypeDataGpu.__PropertyOffset_EmitterInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170032DB RID: 13019
		// (get) Token: 0x0600D811 RID: 55313 RVA: 0x0013EADC File Offset: 0x0013CCDC
		// (set) Token: 0x0600D812 RID: 55314 RVA: 0x0013EB15 File Offset: 0x0013CD15
		public FGPUSpriteResourceData ResourceData
		{
			get
			{
				base.FastCheckIsValid();
				FGPUSpriteResourceData result;
				if ((result = this._ResourceData) == null)
				{
					result = (this._ResourceData = new FGPUSpriteResourceData(base.NativePtr + (IntPtr)UParticleModuleTypeDataGpu.__PropertyOffset_ResourceData, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGPUSpriteResourceData.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleTypeDataGpu.__PropertyOffset_ResourceData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170032DC RID: 13020
		// (get) Token: 0x0600D813 RID: 55315 RVA: 0x0013EB36 File Offset: 0x0013CD36
		// (set) Token: 0x0600D814 RID: 55316 RVA: 0x0013EB46 File Offset: 0x0013CD46
		public unsafe float CameraMotionBlurAmount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleTypeDataGpu.__PropertyOffset_CameraMotionBlurAmount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleTypeDataGpu.__PropertyOffset_CameraMotionBlurAmount) = value;
			}
		}

		// Token: 0x170032DD RID: 13021
		// (get) Token: 0x0600D815 RID: 55317 RVA: 0x0013EB57 File Offset: 0x0013CD57
		// (set) Token: 0x0600D816 RID: 55318 RVA: 0x0013EB70 File Offset: 0x0013CD70
		public unsafe bool bClearExistingParticlesOnInit
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleTypeDataGpu.__PropertyOffset_bClearExistingParticlesOnInit) & UParticleModuleTypeDataGpu.__PropertyMask_bClearExistingParticlesOnInit) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleTypeDataGpu.__PropertyOffset_bClearExistingParticlesOnInit) = ((*(base.NativePtr + (IntPtr)UParticleModuleTypeDataGpu.__PropertyOffset_bClearExistingParticlesOnInit) & ~UParticleModuleTypeDataGpu.__PropertyMask_bClearExistingParticlesOnInit) | (value ? UParticleModuleTypeDataGpu.__PropertyMask_bClearExistingParticlesOnInit : 0));
			}
		}

		// Token: 0x0600D817 RID: 55319 RVA: 0x0013EBA0 File Offset: 0x0013CDA0
		static UParticleModuleTypeDataGpu()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleTypeDataGpu");
		}

		// Token: 0x0600D818 RID: 55320 RVA: 0x0013EBAE File Offset: 0x0013CDAE
		protected UParticleModuleTypeDataGpu(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040074FD RID: 29949
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleTypeDataGpu";

		// Token: 0x040074FE RID: 29950
		private static IntPtr _ClassPtr;

		// Token: 0x040074FF RID: 29951
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007500 RID: 29952
		internal static int __PropertyOffset_EmitterInfo;

		// Token: 0x04007501 RID: 29953
		[Nullable(2)]
		private FGPUSpriteEmitterInfo _EmitterInfo;

		// Token: 0x04007502 RID: 29954
		internal static int __PropertyOffset_ResourceData;

		// Token: 0x04007503 RID: 29955
		[Nullable(2)]
		private FGPUSpriteResourceData _ResourceData;

		// Token: 0x04007504 RID: 29956
		internal static int __PropertyOffset_CameraMotionBlurAmount;

		// Token: 0x04007505 RID: 29957
		internal static int __PropertyOffset_bClearExistingParticlesOnInit;

		// Token: 0x04007506 RID: 29958
		internal static byte __PropertyMask_bClearExistingParticlesOnInit;
	}
}
