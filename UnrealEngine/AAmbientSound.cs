using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007D8 RID: 2008
	[UnrealObjectPath("/Script/Engine.AmbientSound")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class AAmbientSound : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006AF7 RID: 27383 RVA: 0x0009A16B File Offset: 0x0009836B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AAmbientSound._ClassPtr;
		}

		// Token: 0x06006AF8 RID: 27384 RVA: 0x0009A178 File Offset: 0x00098378
		public AAmbientSound() : this(BuiltinUtils.AllocNativeUObject(AAmbientSound.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006AF9 RID: 27385 RVA: 0x0009A1A0 File Offset: 0x000983A0
		[NullableContext(1)]
		public AAmbientSound(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AAmbientSound.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001931 RID: 6449
		// (get) Token: 0x06006AFA RID: 27386 RVA: 0x0009A1D3 File Offset: 0x000983D3
		// (set) Token: 0x06006AFB RID: 27387 RVA: 0x0009A1E7 File Offset: 0x000983E7
		[Nullable(2)]
		public unsafe UAudioComponent AudioComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAudioComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AAmbientSound.__PropertyOffset_AudioComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AAmbientSound.__PropertyOffset_AudioComponent, value);
			}
		}

		// Token: 0x06006AFC RID: 27388 RVA: 0x0009A1FC File Offset: 0x000983FC
		public void Stop()
		{
			AAmbientSound.__Stop_Internal(base.NativePtr);
		}

		// Token: 0x06006AFD RID: 27389 RVA: 0x0009A209 File Offset: 0x00098409
		public void Play(float StartTime = 0f)
		{
			AAmbientSound.__Play_Internal(base.NativePtr, StartTime);
		}

		// Token: 0x06006AFE RID: 27390 RVA: 0x0009A217 File Offset: 0x00098417
		public void FadeOut(float FadeOutDuration, float FadeVolumeLevel)
		{
			AAmbientSound.__FadeOut_Internal(base.NativePtr, FadeOutDuration, FadeVolumeLevel);
		}

		// Token: 0x06006AFF RID: 27391 RVA: 0x0009A226 File Offset: 0x00098426
		public void FadeIn(float FadeInDuration, float FadeVolumeLevel = 1f)
		{
			AAmbientSound.__FadeIn_Internal(base.NativePtr, FadeInDuration, FadeVolumeLevel);
		}

		// Token: 0x06006B00 RID: 27392 RVA: 0x0009A235 File Offset: 0x00098435
		public void AdjustVolume(float AdjustVolumeDuration, float AdjustVolumeLevel)
		{
			AAmbientSound.__AdjustVolume_Internal(base.NativePtr, AdjustVolumeDuration, AdjustVolumeLevel);
		}

		// Token: 0x06006B01 RID: 27393
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Stop_Internal(IntPtr @this);

		// Token: 0x06006B02 RID: 27394
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Play_Internal(IntPtr @this, float StartTime);

		// Token: 0x06006B03 RID: 27395
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FadeOut_Internal(IntPtr @this, float FadeOutDuration, float FadeVolumeLevel);

		// Token: 0x06006B04 RID: 27396
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FadeIn_Internal(IntPtr @this, float FadeInDuration, float FadeVolumeLevel);

		// Token: 0x06006B05 RID: 27397
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AdjustVolume_Internal(IntPtr @this, float AdjustVolumeDuration, float AdjustVolumeLevel);

		// Token: 0x06006B06 RID: 27398 RVA: 0x0009A244 File Offset: 0x00098444
		static AAmbientSound()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AmbientSound");
		}

		// Token: 0x06006B07 RID: 27399 RVA: 0x0009A252 File Offset: 0x00098452
		protected AAmbientSound(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400337B RID: 13179
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AmbientSound";

		// Token: 0x0400337C RID: 13180
		private static IntPtr _ClassPtr;

		// Token: 0x0400337D RID: 13181
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400337E RID: 13182
		internal static int __PropertyOffset_AudioComponent;
	}
}
