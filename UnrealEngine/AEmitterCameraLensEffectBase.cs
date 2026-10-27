using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000AD1 RID: 2769
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.EmitterCameraLensEffectBase")]
	[UnrealStructLayout(1248, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1248)]
	public abstract class AEmitterCameraLensEffectBase : AEmitter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009016 RID: 36886 RVA: 0x000CE345 File Offset: 0x000CC545
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AEmitterCameraLensEffectBase._ClassPtr;
		}

		// Token: 0x17002200 RID: 8704
		// (get) Token: 0x06009017 RID: 36887 RVA: 0x000CE351 File Offset: 0x000CC551
		// (set) Token: 0x06009018 RID: 36888 RVA: 0x000CE365 File Offset: 0x000CC565
		public unsafe UParticleSystem PS_CameraEffect
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UParticleSystem>(base.NativePtr / (IntPtr)sizeof(void*) + AEmitterCameraLensEffectBase.__PropertyOffset_PS_CameraEffect);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AEmitterCameraLensEffectBase.__PropertyOffset_PS_CameraEffect, value);
			}
		}

		// Token: 0x17002201 RID: 8705
		// (get) Token: 0x06009019 RID: 36889 RVA: 0x000CE37A File Offset: 0x000CC57A
		// (set) Token: 0x0600901A RID: 36890 RVA: 0x000CE38E File Offset: 0x000CC58E
		public unsafe UParticleSystem PS_CameraEffectNonExtremeContent_DEPRECATED
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UParticleSystem>(base.NativePtr / (IntPtr)sizeof(void*) + AEmitterCameraLensEffectBase.__PropertyOffset_PS_CameraEffectNonExtremeContent_DEPRECATED);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AEmitterCameraLensEffectBase.__PropertyOffset_PS_CameraEffectNonExtremeContent_DEPRECATED, value);
			}
		}

		// Token: 0x17002202 RID: 8706
		// (get) Token: 0x0600901B RID: 36891 RVA: 0x000CE3A3 File Offset: 0x000CC5A3
		// (set) Token: 0x0600901C RID: 36892 RVA: 0x000CE3B7 File Offset: 0x000CC5B7
		public unsafe APlayerCameraManager BaseCamera
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<APlayerCameraManager>(base.NativePtr / (IntPtr)sizeof(void*) + AEmitterCameraLensEffectBase.__PropertyOffset_BaseCamera);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AEmitterCameraLensEffectBase.__PropertyOffset_BaseCamera, value);
			}
		}

		// Token: 0x17002203 RID: 8707
		// (get) Token: 0x0600901D RID: 36893 RVA: 0x000CE3CC File Offset: 0x000CC5CC
		// (set) Token: 0x0600901E RID: 36894 RVA: 0x000CE3E0 File Offset: 0x000CC5E0
		public unsafe FTransform RelativeTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AEmitterCameraLensEffectBase.__PropertyOffset_RelativeTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AEmitterCameraLensEffectBase.__PropertyOffset_RelativeTransform) = value;
			}
		}

		// Token: 0x17002204 RID: 8708
		// (get) Token: 0x0600901F RID: 36895 RVA: 0x000CE3F5 File Offset: 0x000CC5F5
		// (set) Token: 0x06009020 RID: 36896 RVA: 0x000CE405 File Offset: 0x000CC605
		public unsafe float BaseFOV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AEmitterCameraLensEffectBase.__PropertyOffset_BaseFOV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AEmitterCameraLensEffectBase.__PropertyOffset_BaseFOV) = value;
			}
		}

		// Token: 0x17002205 RID: 8709
		// (get) Token: 0x06009021 RID: 36897 RVA: 0x000CE416 File Offset: 0x000CC616
		// (set) Token: 0x06009022 RID: 36898 RVA: 0x000CE42F File Offset: 0x000CC62F
		public unsafe bool bAllowMultipleInstances
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AEmitterCameraLensEffectBase.__PropertyOffset_bAllowMultipleInstances) & AEmitterCameraLensEffectBase.__PropertyMask_bAllowMultipleInstances) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AEmitterCameraLensEffectBase.__PropertyOffset_bAllowMultipleInstances) = ((*(base.NativePtr + (IntPtr)AEmitterCameraLensEffectBase.__PropertyOffset_bAllowMultipleInstances) & ~AEmitterCameraLensEffectBase.__PropertyMask_bAllowMultipleInstances) | (value ? AEmitterCameraLensEffectBase.__PropertyMask_bAllowMultipleInstances : 0));
			}
		}

		// Token: 0x17002206 RID: 8710
		// (get) Token: 0x06009023 RID: 36899 RVA: 0x000CE45F File Offset: 0x000CC65F
		// (set) Token: 0x06009024 RID: 36900 RVA: 0x000CE478 File Offset: 0x000CC678
		public unsafe bool bResetWhenRetriggered
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AEmitterCameraLensEffectBase.__PropertyOffset_bResetWhenRetriggered) & AEmitterCameraLensEffectBase.__PropertyMask_bResetWhenRetriggered) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AEmitterCameraLensEffectBase.__PropertyOffset_bResetWhenRetriggered) = ((*(base.NativePtr + (IntPtr)AEmitterCameraLensEffectBase.__PropertyOffset_bResetWhenRetriggered) & ~AEmitterCameraLensEffectBase.__PropertyMask_bResetWhenRetriggered) | (value ? AEmitterCameraLensEffectBase.__PropertyMask_bResetWhenRetriggered : 0));
			}
		}

		// Token: 0x17002207 RID: 8711
		// (get) Token: 0x06009025 RID: 36901 RVA: 0x000CE4A8 File Offset: 0x000CC6A8
		// (set) Token: 0x06009026 RID: 36902 RVA: 0x000CE4E1 File Offset: 0x000CC6E1
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TSubclassOf<AEmitterCameraLensEffectBase>> EmittersToTreatAsSame
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TSubclassOf<AEmitterCameraLensEffectBase>> result;
				if ((result = this._EmittersToTreatAsSame) == null)
				{
					result = (this._EmittersToTreatAsSame = new TArray<TSubclassOf<AEmitterCameraLensEffectBase>>(base.NativePtr + (IntPtr)AEmitterCameraLensEffectBase.__PropertyOffset_EmittersToTreatAsSame, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.EmittersToTreatAsSame.CopyAssign(value);
			}
		}

		// Token: 0x17002208 RID: 8712
		// (get) Token: 0x06009027 RID: 36903 RVA: 0x000CE4EF File Offset: 0x000CC6EF
		// (set) Token: 0x06009028 RID: 36904 RVA: 0x000CE4FF File Offset: 0x000CC6FF
		public unsafe float DistFromCamera_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AEmitterCameraLensEffectBase.__PropertyOffset_DistFromCamera_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AEmitterCameraLensEffectBase.__PropertyOffset_DistFromCamera_DEPRECATED) = value;
			}
		}

		// Token: 0x06009029 RID: 36905 RVA: 0x000CE510 File Offset: 0x000CC710
		static AEmitterCameraLensEffectBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.EmitterCameraLensEffectBase");
		}

		// Token: 0x0600902A RID: 36906 RVA: 0x000CE520 File Offset: 0x000CC720
		protected AEmitterCameraLensEffectBase() : this(BuiltinUtils.AllocNativeUObject(AEmitterCameraLensEffectBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600902B RID: 36907 RVA: 0x000CE548 File Offset: 0x000CC748
		protected AEmitterCameraLensEffectBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004AB9 RID: 19129
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.EmitterCameraLensEffectBase";

		// Token: 0x04004ABA RID: 19130
		private static IntPtr _ClassPtr;

		// Token: 0x04004ABB RID: 19131
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004ABC RID: 19132
		internal static int __PropertyOffset_PS_CameraEffect;

		// Token: 0x04004ABD RID: 19133
		internal static int __PropertyOffset_PS_CameraEffectNonExtremeContent_DEPRECATED;

		// Token: 0x04004ABE RID: 19134
		internal static int __PropertyOffset_BaseCamera;

		// Token: 0x04004ABF RID: 19135
		internal static int __PropertyOffset_RelativeTransform;

		// Token: 0x04004AC0 RID: 19136
		internal static int __PropertyOffset_BaseFOV;

		// Token: 0x04004AC1 RID: 19137
		internal static int __PropertyOffset_bAllowMultipleInstances;

		// Token: 0x04004AC2 RID: 19138
		internal static byte __PropertyMask_bAllowMultipleInstances;

		// Token: 0x04004AC3 RID: 19139
		internal static int __PropertyOffset_bResetWhenRetriggered;

		// Token: 0x04004AC4 RID: 19140
		internal static byte __PropertyMask_bResetWhenRetriggered;

		// Token: 0x04004AC5 RID: 19141
		internal static int __PropertyOffset_EmittersToTreatAsSame;

		// Token: 0x04004AC6 RID: 19142
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TSubclassOf<AEmitterCameraLensEffectBase>> _EmittersToTreatAsSame;

		// Token: 0x04004AC7 RID: 19143
		internal static int __PropertyOffset_DistFromCamera_DEPRECATED;
	}
}
