using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200030F RID: 783
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAudio.KuroAmbientSoundComponent")]
	[UnrealStructLayout(656, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 656)]
	public class UKuroAmbientSoundComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005347 RID: 21319 RVA: 0x000747E7 File Offset: 0x000729E7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAmbientSoundComponent._ClassPtr;
		}

		// Token: 0x06005348 RID: 21320 RVA: 0x000747F4 File Offset: 0x000729F4
		public UKuroAmbientSoundComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroAmbientSoundComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005349 RID: 21321 RVA: 0x0007481C File Offset: 0x00072A1C
		public UKuroAmbientSoundComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAmbientSoundComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700108B RID: 4235
		// (get) Token: 0x0600534A RID: 21322 RVA: 0x0007484F File Offset: 0x00072A4F
		// (set) Token: 0x0600534B RID: 21323 RVA: 0x00074863 File Offset: 0x00072A63
		[Nullable(2)]
		public unsafe UAkAudioEvent AudioEvent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAmbientSoundComponent.__PropertyOffset_AudioEvent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAmbientSoundComponent.__PropertyOffset_AudioEvent, value);
			}
		}

		// Token: 0x1700108C RID: 4236
		// (get) Token: 0x0600534C RID: 21324 RVA: 0x00074878 File Offset: 0x00072A78
		// (set) Token: 0x0600534D RID: 21325 RVA: 0x00074888 File Offset: 0x00072A88
		public unsafe bool bAutoPlay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAmbientSoundComponent.__PropertyOffset_bAutoPlay) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAmbientSoundComponent.__PropertyOffset_bAutoPlay) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700108D RID: 4237
		// (get) Token: 0x0600534E RID: 21326 RVA: 0x00074899 File Offset: 0x00072A99
		// (set) Token: 0x0600534F RID: 21327 RVA: 0x000748A9 File Offset: 0x00072AA9
		public unsafe float AttenuationScalingFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAmbientSoundComponent.__PropertyOffset_AttenuationScalingFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAmbientSoundComponent.__PropertyOffset_AttenuationScalingFactor) = value;
			}
		}

		// Token: 0x1700108E RID: 4238
		// (get) Token: 0x06005350 RID: 21328 RVA: 0x000748BC File Offset: 0x00072ABC
		// (set) Token: 0x06005351 RID: 21329 RVA: 0x000748F5 File Offset: 0x00072AF5
		public TArray<FTransform> SoundPositions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._SoundPositions) == null)
				{
					result = (this._SoundPositions = new TArray<FTransform>(base.NativePtr + (IntPtr)UKuroAmbientSoundComponent.__PropertyOffset_SoundPositions, this));
				}
				return result;
			}
			set
			{
				this.SoundPositions.CopyAssign(value);
			}
		}

		// Token: 0x06005352 RID: 21330 RVA: 0x00074903 File Offset: 0x00072B03
		public void StopSound()
		{
			UKuroAmbientSoundComponent.__StopSound_Internal(base.NativePtr);
		}

		// Token: 0x06005353 RID: 21331 RVA: 0x00074910 File Offset: 0x00072B10
		public void PlaySound()
		{
			UKuroAmbientSoundComponent.__PlaySound_Internal(base.NativePtr);
		}

		// Token: 0x06005354 RID: 21332 RVA: 0x0007491D File Offset: 0x00072B1D
		public bool IsPlaying()
		{
			return UKuroAmbientSoundComponent.__IsPlaying_Internal(base.NativePtr);
		}

		// Token: 0x06005355 RID: 21333
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopSound_Internal(IntPtr @this);

		// Token: 0x06005356 RID: 21334
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlaySound_Internal(IntPtr @this);

		// Token: 0x06005357 RID: 21335
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPlaying_Internal(IntPtr @this);

		// Token: 0x06005358 RID: 21336 RVA: 0x0007492A File Offset: 0x00072B2A
		static UKuroAmbientSoundComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAudio.KuroAmbientSoundComponent");
		}

		// Token: 0x06005359 RID: 21337 RVA: 0x00074938 File Offset: 0x00072B38
		protected UKuroAmbientSoundComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002214 RID: 8724
		public new const string __ObjectPath = "/Script/KuroAudio.KuroAmbientSoundComponent";

		// Token: 0x04002215 RID: 8725
		private static IntPtr _ClassPtr;

		// Token: 0x04002216 RID: 8726
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002217 RID: 8727
		internal static int __PropertyOffset_AudioEvent;

		// Token: 0x04002218 RID: 8728
		internal static int __PropertyOffset_bAutoPlay;

		// Token: 0x04002219 RID: 8729
		internal static int __PropertyOffset_AttenuationScalingFactor;

		// Token: 0x0400221A RID: 8730
		internal static int __PropertyOffset_SoundPositions;

		// Token: 0x0400221B RID: 8731
		[Nullable(2)]
		private TArray<FTransform> _SoundPositions;
	}
}
