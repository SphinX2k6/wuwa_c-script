using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001694 RID: 5780
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAudio.KuroAmbientSoundComponent")]
	[UnrealStructLayout(656, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 656)]
	public class UKuroAmbientSoundComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06014F5E RID: 85854 RVA: 0x001ED017 File Offset: 0x001EB217
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAmbientSoundComponent._ClassPtr;
		}

		// Token: 0x06014F5F RID: 85855 RVA: 0x001ED024 File Offset: 0x001EB224
		public UKuroAmbientSoundComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroAmbientSoundComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014F60 RID: 85856 RVA: 0x001ED04C File Offset: 0x001EB24C
		public UKuroAmbientSoundComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAmbientSoundComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005308 RID: 21256
		// (get) Token: 0x06014F61 RID: 85857 RVA: 0x001ED07F File Offset: 0x001EB27F
		// (set) Token: 0x06014F62 RID: 85858 RVA: 0x001ED093 File Offset: 0x001EB293
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

		// Token: 0x17005309 RID: 21257
		// (get) Token: 0x06014F63 RID: 85859 RVA: 0x001ED0A8 File Offset: 0x001EB2A8
		// (set) Token: 0x06014F64 RID: 85860 RVA: 0x001ED0B8 File Offset: 0x001EB2B8
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

		// Token: 0x1700530A RID: 21258
		// (get) Token: 0x06014F65 RID: 85861 RVA: 0x001ED0C9 File Offset: 0x001EB2C9
		// (set) Token: 0x06014F66 RID: 85862 RVA: 0x001ED0D9 File Offset: 0x001EB2D9
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

		// Token: 0x1700530B RID: 21259
		// (get) Token: 0x06014F67 RID: 85863 RVA: 0x001ED0EC File Offset: 0x001EB2EC
		// (set) Token: 0x06014F68 RID: 85864 RVA: 0x001ED125 File Offset: 0x001EB325
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

		// Token: 0x06014F69 RID: 85865 RVA: 0x001ED133 File Offset: 0x001EB333
		public void StopSound()
		{
			UKuroAmbientSoundComponent.__StopSound_Internal(base.NativePtr);
		}

		// Token: 0x06014F6A RID: 85866 RVA: 0x001ED140 File Offset: 0x001EB340
		public void PlaySound()
		{
			UKuroAmbientSoundComponent.__PlaySound_Internal(base.NativePtr);
		}

		// Token: 0x06014F6B RID: 85867 RVA: 0x001ED14D File Offset: 0x001EB34D
		public bool IsPlaying()
		{
			return UKuroAmbientSoundComponent.__IsPlaying_Internal(base.NativePtr);
		}

		// Token: 0x06014F6C RID: 85868
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopSound_Internal(IntPtr @this);

		// Token: 0x06014F6D RID: 85869
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlaySound_Internal(IntPtr @this);

		// Token: 0x06014F6E RID: 85870
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPlaying_Internal(IntPtr @this);

		// Token: 0x06014F6F RID: 85871 RVA: 0x001ED15A File Offset: 0x001EB35A
		static UKuroAmbientSoundComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAudio.KuroAmbientSoundComponent");
		}

		// Token: 0x06014F70 RID: 85872 RVA: 0x001ED168 File Offset: 0x001EB368
		protected UKuroAmbientSoundComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B6BE RID: 46782
		public new const string __ObjectPath = "/Script/KuroAudio.KuroAmbientSoundComponent";

		// Token: 0x0400B6BF RID: 46783
		private static IntPtr _ClassPtr;

		// Token: 0x0400B6C0 RID: 46784
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B6C1 RID: 46785
		internal static int __PropertyOffset_AudioEvent;

		// Token: 0x0400B6C2 RID: 46786
		internal static int __PropertyOffset_bAutoPlay;

		// Token: 0x0400B6C3 RID: 46787
		internal static int __PropertyOffset_AttenuationScalingFactor;

		// Token: 0x0400B6C4 RID: 46788
		internal static int __PropertyOffset_SoundPositions;

		// Token: 0x0400B6C5 RID: 46789
		[Nullable(2)]
		private TArray<FTransform> _SoundPositions;
	}
}
