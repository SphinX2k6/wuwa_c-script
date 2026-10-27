using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000281 RID: 641
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.MovieSceneAkAudioEventSection")]
	[UnrealStructLayout(536, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 536)]
	public class UMovieSceneAkAudioEventSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600240B RID: 9227 RVA: 0x00035796 File Offset: 0x00033996
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneAkAudioEventSection._ClassPtr;
		}

		// Token: 0x0600240C RID: 9228 RVA: 0x000357A4 File Offset: 0x000339A4
		public UMovieSceneAkAudioEventSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneAkAudioEventSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600240D RID: 9229 RVA: 0x000357CC File Offset: 0x000339CC
		public UMovieSceneAkAudioEventSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneAkAudioEventSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x0600240E RID: 9230 RVA: 0x000357FF File Offset: 0x000339FF
		// (set) Token: 0x0600240F RID: 9231 RVA: 0x00035813 File Offset: 0x00033A13
		[Nullable(2)]
		public unsafe UAkAudioEvent Event
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneAkAudioEventSection.__PropertyOffset_Event);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneAkAudioEventSection.__PropertyOffset_Event, value);
			}
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06002410 RID: 9232 RVA: 0x00035828 File Offset: 0x00033A28
		// (set) Token: 0x06002411 RID: 9233 RVA: 0x00035838 File Offset: 0x00033A38
		public unsafe bool RetriggerEvent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneAkAudioEventSection.__PropertyOffset_RetriggerEvent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneAkAudioEventSection.__PropertyOffset_RetriggerEvent) = (value ? 1 : 0);
			}
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06002412 RID: 9234 RVA: 0x00035849 File Offset: 0x00033A49
		// (set) Token: 0x06002413 RID: 9235 RVA: 0x00035859 File Offset: 0x00033A59
		public unsafe int ScrubTailLengthMs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneAkAudioEventSection.__PropertyOffset_ScrubTailLengthMs);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneAkAudioEventSection.__PropertyOffset_ScrubTailLengthMs) = value;
			}
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06002414 RID: 9236 RVA: 0x0003586A File Offset: 0x00033A6A
		// (set) Token: 0x06002415 RID: 9237 RVA: 0x0003587A File Offset: 0x00033A7A
		public unsafe bool StopAtSectionEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneAkAudioEventSection.__PropertyOffset_StopAtSectionEnd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneAkAudioEventSection.__PropertyOffset_StopAtSectionEnd) = (value ? 1 : 0);
			}
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06002416 RID: 9238 RVA: 0x0003588B File Offset: 0x00033A8B
		// (set) Token: 0x06002417 RID: 9239 RVA: 0x0003589F File Offset: 0x00033A9F
		public unsafe string EventName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UMovieSceneAkAudioEventSection.__PropertyOffset_EventName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UMovieSceneAkAudioEventSection.__PropertyOffset_EventName)), value);
			}
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06002418 RID: 9240 RVA: 0x000358B4 File Offset: 0x00033AB4
		// (set) Token: 0x06002419 RID: 9241 RVA: 0x000358C4 File Offset: 0x00033AC4
		public unsafe float MaxSourceDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneAkAudioEventSection.__PropertyOffset_MaxSourceDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneAkAudioEventSection.__PropertyOffset_MaxSourceDuration) = value;
			}
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x0600241A RID: 9242 RVA: 0x000358D5 File Offset: 0x00033AD5
		// (set) Token: 0x0600241B RID: 9243 RVA: 0x000358E9 File Offset: 0x00033AE9
		public unsafe string MaxDurationSourceID
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UMovieSceneAkAudioEventSection.__PropertyOffset_MaxDurationSourceID)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UMovieSceneAkAudioEventSection.__PropertyOffset_MaxDurationSourceID)), value);
			}
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x0600241C RID: 9244 RVA: 0x00035900 File Offset: 0x00033B00
		// (set) Token: 0x0600241D RID: 9245 RVA: 0x00035939 File Offset: 0x00033B39
		public TArray<FAkExternalSourceInfo> ExternalSources
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAkExternalSourceInfo> result;
				if ((result = this._ExternalSources) == null)
				{
					result = (this._ExternalSources = new TArray<FAkExternalSourceInfo>(base.NativePtr + (IntPtr)UMovieSceneAkAudioEventSection.__PropertyOffset_ExternalSources, this));
				}
				return result;
			}
			set
			{
				this.ExternalSources.CopyAssign(value);
			}
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x0600241E RID: 9246 RVA: 0x00035947 File Offset: 0x00033B47
		// (set) Token: 0x0600241F RID: 9247 RVA: 0x00035957 File Offset: 0x00033B57
		public unsafe int FadeOutMs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneAkAudioEventSection.__PropertyOffset_FadeOutMs);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneAkAudioEventSection.__PropertyOffset_FadeOutMs) = value;
			}
		}

		// Token: 0x06002420 RID: 9248 RVA: 0x00035968 File Offset: 0x00033B68
		static UMovieSceneAkAudioEventSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.MovieSceneAkAudioEventSection");
		}

		// Token: 0x06002421 RID: 9249 RVA: 0x00035976 File Offset: 0x00033B76
		protected UMovieSceneAkAudioEventSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000DA7 RID: 3495
		public new const string __ObjectPath = "/Script/AkAudio.MovieSceneAkAudioEventSection";

		// Token: 0x04000DA8 RID: 3496
		private static IntPtr _ClassPtr;

		// Token: 0x04000DA9 RID: 3497
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000DAA RID: 3498
		internal static int __PropertyOffset_Event;

		// Token: 0x04000DAB RID: 3499
		internal static int __PropertyOffset_RetriggerEvent;

		// Token: 0x04000DAC RID: 3500
		internal static int __PropertyOffset_ScrubTailLengthMs;

		// Token: 0x04000DAD RID: 3501
		internal static int __PropertyOffset_StopAtSectionEnd;

		// Token: 0x04000DAE RID: 3502
		internal static int __PropertyOffset_EventName;

		// Token: 0x04000DAF RID: 3503
		internal static int __PropertyOffset_MaxSourceDuration;

		// Token: 0x04000DB0 RID: 3504
		internal static int __PropertyOffset_MaxDurationSourceID;

		// Token: 0x04000DB1 RID: 3505
		internal static int __PropertyOffset_ExternalSources;

		// Token: 0x04000DB2 RID: 3506
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAkExternalSourceInfo> _ExternalSources;

		// Token: 0x04000DB3 RID: 3507
		internal static int __PropertyOffset_FadeOutMs;
	}
}
