using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B16 RID: 6934
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroGPUParticleDA")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UKuroGPUParticleDA : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601A16A RID: 106858 RVA: 0x002680F7 File Offset: 0x002662F7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroGPUParticleDA._ClassPtr;
		}

		// Token: 0x0601A16B RID: 106859 RVA: 0x00268104 File Offset: 0x00266304
		public UKuroGPUParticleDA() : this(BuiltinUtils.AllocNativeUObject(UKuroGPUParticleDA.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601A16C RID: 106860 RVA: 0x0026812C File Offset: 0x0026632C
		public UKuroGPUParticleDA(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroGPUParticleDA.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170068BB RID: 26811
		// (get) Token: 0x0601A16D RID: 106861 RVA: 0x0026815F File Offset: 0x0026635F
		// (set) Token: 0x0601A16E RID: 106862 RVA: 0x00268173 File Offset: 0x00266373
		public unsafe string JsonDataPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKuroGPUParticleDA.__PropertyOffset_JsonDataPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKuroGPUParticleDA.__PropertyOffset_JsonDataPath)), value);
			}
		}

		// Token: 0x170068BC RID: 26812
		// (get) Token: 0x0601A16F RID: 106863 RVA: 0x00268188 File Offset: 0x00266388
		// (set) Token: 0x0601A170 RID: 106864 RVA: 0x0026819C File Offset: 0x0026639C
		[Nullable(2)]
		public unsafe UMaterialInstance GPUParticleMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroGPUParticleDA.__PropertyOffset_GPUParticleMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroGPUParticleDA.__PropertyOffset_GPUParticleMaterial, value);
			}
		}

		// Token: 0x170068BD RID: 26813
		// (get) Token: 0x0601A171 RID: 106865 RVA: 0x002681B1 File Offset: 0x002663B1
		// (set) Token: 0x0601A172 RID: 106866 RVA: 0x002681C1 File Offset: 0x002663C1
		public unsafe int StartFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGPUParticleDA.__PropertyOffset_StartFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGPUParticleDA.__PropertyOffset_StartFrame) = value;
			}
		}

		// Token: 0x170068BE RID: 26814
		// (get) Token: 0x0601A173 RID: 106867 RVA: 0x002681D2 File Offset: 0x002663D2
		// (set) Token: 0x0601A174 RID: 106868 RVA: 0x002681E2 File Offset: 0x002663E2
		public unsafe int EndFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGPUParticleDA.__PropertyOffset_EndFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGPUParticleDA.__PropertyOffset_EndFrame) = value;
			}
		}

		// Token: 0x170068BF RID: 26815
		// (get) Token: 0x0601A175 RID: 106869 RVA: 0x002681F3 File Offset: 0x002663F3
		// (set) Token: 0x0601A176 RID: 106870 RVA: 0x00268203 File Offset: 0x00266403
		public unsafe float ColorIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGPUParticleDA.__PropertyOffset_ColorIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGPUParticleDA.__PropertyOffset_ColorIntensity) = value;
			}
		}

		// Token: 0x170068C0 RID: 26816
		// (get) Token: 0x0601A177 RID: 106871 RVA: 0x00268214 File Offset: 0x00266414
		// (set) Token: 0x0601A178 RID: 106872 RVA: 0x00268224 File Offset: 0x00266424
		public unsafe float VelocityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGPUParticleDA.__PropertyOffset_VelocityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGPUParticleDA.__PropertyOffset_VelocityScale) = value;
			}
		}

		// Token: 0x170068C1 RID: 26817
		// (get) Token: 0x0601A179 RID: 106873 RVA: 0x00268235 File Offset: 0x00266435
		// (set) Token: 0x0601A17A RID: 106874 RVA: 0x00268245 File Offset: 0x00266445
		public unsafe float AspectRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGPUParticleDA.__PropertyOffset_AspectRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGPUParticleDA.__PropertyOffset_AspectRatio) = value;
			}
		}

		// Token: 0x170068C2 RID: 26818
		// (get) Token: 0x0601A17B RID: 106875 RVA: 0x00268258 File Offset: 0x00266458
		// (set) Token: 0x0601A17C RID: 106876 RVA: 0x00268291 File Offset: 0x00266491
		public TArray<FKuroGPUParticleMeshInfo> AllParticleInfos
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroGPUParticleMeshInfo> result;
				if ((result = this._AllParticleInfos) == null)
				{
					result = (this._AllParticleInfos = new TArray<FKuroGPUParticleMeshInfo>(base.NativePtr + (IntPtr)UKuroGPUParticleDA.__PropertyOffset_AllParticleInfos, this));
				}
				return result;
			}
			set
			{
				this.AllParticleInfos.CopyAssign(value);
			}
		}

		// Token: 0x0601A17D RID: 106877 RVA: 0x0026829F File Offset: 0x0026649F
		static UKuroGPUParticleDA()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroGPUParticleDA");
		}

		// Token: 0x0601A17E RID: 106878 RVA: 0x002682AD File Offset: 0x002664AD
		protected UKuroGPUParticleDA(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E2A7 RID: 58023
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroGPUParticleDA";

		// Token: 0x0400E2A8 RID: 58024
		private static IntPtr _ClassPtr;

		// Token: 0x0400E2A9 RID: 58025
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E2AA RID: 58026
		internal static int __PropertyOffset_JsonDataPath;

		// Token: 0x0400E2AB RID: 58027
		internal static int __PropertyOffset_GPUParticleMaterial;

		// Token: 0x0400E2AC RID: 58028
		internal static int __PropertyOffset_StartFrame;

		// Token: 0x0400E2AD RID: 58029
		internal static int __PropertyOffset_EndFrame;

		// Token: 0x0400E2AE RID: 58030
		internal static int __PropertyOffset_ColorIntensity;

		// Token: 0x0400E2AF RID: 58031
		internal static int __PropertyOffset_VelocityScale;

		// Token: 0x0400E2B0 RID: 58032
		internal static int __PropertyOffset_AspectRatio;

		// Token: 0x0400E2B1 RID: 58033
		internal static int __PropertyOffset_AllParticleInfos;

		// Token: 0x0400E2B2 RID: 58034
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroGPUParticleMeshInfo> _AllParticleInfos;
	}
}
