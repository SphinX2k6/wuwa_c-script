using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B14 RID: 6932
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroGPUParticleActor")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class AKuroGPUParticleActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601A138 RID: 106808 RVA: 0x00267D5C File Offset: 0x00265F5C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroGPUParticleActor._ClassPtr;
		}

		// Token: 0x0601A139 RID: 106809 RVA: 0x00267D68 File Offset: 0x00265F68
		public AKuroGPUParticleActor() : this(BuiltinUtils.AllocNativeUObject(AKuroGPUParticleActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601A13A RID: 106810 RVA: 0x00267D90 File Offset: 0x00265F90
		[NullableContext(1)]
		public AKuroGPUParticleActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroGPUParticleActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170068AB RID: 26795
		// (get) Token: 0x0601A13B RID: 106811 RVA: 0x00267DC3 File Offset: 0x00265FC3
		// (set) Token: 0x0601A13C RID: 106812 RVA: 0x00267DD3 File Offset: 0x00265FD3
		public unsafe int KuroIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGPUParticleActor.__PropertyOffset_KuroIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGPUParticleActor.__PropertyOffset_KuroIndex) = value;
			}
		}

		// Token: 0x170068AC RID: 26796
		// (get) Token: 0x0601A13D RID: 106813 RVA: 0x00267DE4 File Offset: 0x00265FE4
		// (set) Token: 0x0601A13E RID: 106814 RVA: 0x00267DF8 File Offset: 0x00265FF8
		[Nullable(2)]
		public unsafe UKuroGPUParticleComponent GPUParticleComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroGPUParticleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGPUParticleActor.__PropertyOffset_GPUParticleComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGPUParticleActor.__PropertyOffset_GPUParticleComponent, value);
			}
		}

		// Token: 0x0601A13F RID: 106815 RVA: 0x00267E0D File Offset: 0x0026600D
		static AKuroGPUParticleActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroGPUParticleActor");
		}

		// Token: 0x0601A140 RID: 106816 RVA: 0x00267E1B File Offset: 0x0026601B
		protected AKuroGPUParticleActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E290 RID: 58000
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroGPUParticleActor";

		// Token: 0x0400E291 RID: 58001
		private static IntPtr _ClassPtr;

		// Token: 0x0400E292 RID: 58002
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E293 RID: 58003
		internal static int __PropertyOffset_KuroIndex;

		// Token: 0x0400E294 RID: 58004
		internal static int __PropertyOffset_GPUParticleComponent;
	}
}
