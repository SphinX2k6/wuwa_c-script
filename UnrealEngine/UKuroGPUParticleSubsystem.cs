using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B18 RID: 6936
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroGPUParticleSubsystem")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UKuroGPUParticleSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601A191 RID: 106897 RVA: 0x00268400 File Offset: 0x00266600
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroGPUParticleSubsystem._ClassPtr;
		}

		// Token: 0x0601A192 RID: 106898 RVA: 0x0026840C File Offset: 0x0026660C
		public UKuroGPUParticleSubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroGPUParticleSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601A193 RID: 106899 RVA: 0x00268434 File Offset: 0x00266634
		[NullableContext(1)]
		public UKuroGPUParticleSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroGPUParticleSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601A194 RID: 106900 RVA: 0x00268467 File Offset: 0x00266667
		[NullableContext(2)]
		public static UKuroGPUParticleSubsystem GetKuroGPUParticleSystem(UWorld InWorld)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroGPUParticleSubsystem>(UKuroGPUParticleSubsystem.__GetKuroGPUParticleSystem_Internal((InWorld != null) ? InWorld.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0601A195 RID: 106901
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetKuroGPUParticleSystem_Internal(IntPtr InWorld);

		// Token: 0x0601A196 RID: 106902 RVA: 0x00268483 File Offset: 0x00266683
		static UKuroGPUParticleSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroGPUParticleSubsystem");
		}

		// Token: 0x0601A197 RID: 106903 RVA: 0x00268491 File Offset: 0x00266691
		protected UKuroGPUParticleSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E2BA RID: 58042
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroGPUParticleSubsystem";

		// Token: 0x0400E2BB RID: 58043
		private static IntPtr _ClassPtr;

		// Token: 0x0400E2BC RID: 58044
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
