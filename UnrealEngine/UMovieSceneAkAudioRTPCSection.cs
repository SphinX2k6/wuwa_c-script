using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000284 RID: 644
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.MovieSceneAkAudioRTPCSection")]
	[UnrealStructLayout(680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 680)]
	public class UMovieSceneAkAudioRTPCSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002432 RID: 9266 RVA: 0x00035AAA File Offset: 0x00033CAA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneAkAudioRTPCSection._ClassPtr;
		}

		// Token: 0x06002433 RID: 9267 RVA: 0x00035AB8 File Offset: 0x00033CB8
		public UMovieSceneAkAudioRTPCSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneAkAudioRTPCSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002434 RID: 9268 RVA: 0x00035AE0 File Offset: 0x00033CE0
		public UMovieSceneAkAudioRTPCSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneAkAudioRTPCSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x06002435 RID: 9269 RVA: 0x00035B13 File Offset: 0x00033D13
		// (set) Token: 0x06002436 RID: 9270 RVA: 0x00035B27 File Offset: 0x00033D27
		[Nullable(2)]
		public unsafe UAkRtpc RTPC
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkRtpc>(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneAkAudioRTPCSection.__PropertyOffset_RTPC);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneAkAudioRTPCSection.__PropertyOffset_RTPC, value);
			}
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x06002437 RID: 9271 RVA: 0x00035B3C File Offset: 0x00033D3C
		// (set) Token: 0x06002438 RID: 9272 RVA: 0x00035B50 File Offset: 0x00033D50
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UMovieSceneAkAudioRTPCSection.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UMovieSceneAkAudioRTPCSection.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x06002439 RID: 9273 RVA: 0x00035B68 File Offset: 0x00033D68
		// (set) Token: 0x0600243A RID: 9274 RVA: 0x00035BA1 File Offset: 0x00033DA1
		public FRichCurve FloatCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRichCurve result;
				if ((result = this._FloatCurve) == null)
				{
					result = (this._FloatCurve = new FRichCurve(base.NativePtr + (IntPtr)UMovieSceneAkAudioRTPCSection.__PropertyOffset_FloatCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRichCurve.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneAkAudioRTPCSection.__PropertyOffset_FloatCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x0600243B RID: 9275 RVA: 0x00035BC4 File Offset: 0x00033DC4
		// (set) Token: 0x0600243C RID: 9276 RVA: 0x00035BFD File Offset: 0x00033DFD
		public FMovieSceneFloatChannelSerializationHelper FloatChannelSerializationHelper
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannelSerializationHelper result;
				if ((result = this._FloatChannelSerializationHelper) == null)
				{
					result = (this._FloatChannelSerializationHelper = new FMovieSceneFloatChannelSerializationHelper(base.NativePtr + (IntPtr)UMovieSceneAkAudioRTPCSection.__PropertyOffset_FloatChannelSerializationHelper, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannelSerializationHelper.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneAkAudioRTPCSection.__PropertyOffset_FloatChannelSerializationHelper, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x0600243D RID: 9277 RVA: 0x00035C20 File Offset: 0x00033E20
		// (set) Token: 0x0600243E RID: 9278 RVA: 0x00035C59 File Offset: 0x00033E59
		public FMovieSceneFloatChannel RTPCChannel
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._RTPCChannel) == null)
				{
					result = (this._RTPCChannel = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)UMovieSceneAkAudioRTPCSection.__PropertyOffset_RTPCChannel, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneAkAudioRTPCSection.__PropertyOffset_RTPCChannel, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600243F RID: 9279 RVA: 0x00035C7A File Offset: 0x00033E7A
		static UMovieSceneAkAudioRTPCSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.MovieSceneAkAudioRTPCSection");
		}

		// Token: 0x06002440 RID: 9280 RVA: 0x00035C88 File Offset: 0x00033E88
		protected UMovieSceneAkAudioRTPCSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000DBB RID: 3515
		public new const string __ObjectPath = "/Script/AkAudio.MovieSceneAkAudioRTPCSection";

		// Token: 0x04000DBC RID: 3516
		private static IntPtr _ClassPtr;

		// Token: 0x04000DBD RID: 3517
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000DBE RID: 3518
		internal static int __PropertyOffset_RTPC;

		// Token: 0x04000DBF RID: 3519
		internal static int __PropertyOffset_Name;

		// Token: 0x04000DC0 RID: 3520
		internal static int __PropertyOffset_FloatCurve;

		// Token: 0x04000DC1 RID: 3521
		[Nullable(2)]
		private FRichCurve _FloatCurve;

		// Token: 0x04000DC2 RID: 3522
		internal static int __PropertyOffset_FloatChannelSerializationHelper;

		// Token: 0x04000DC3 RID: 3523
		[Nullable(2)]
		private FMovieSceneFloatChannelSerializationHelper _FloatChannelSerializationHelper;

		// Token: 0x04000DC4 RID: 3524
		internal static int __PropertyOffset_RTPCChannel;

		// Token: 0x04000DC5 RID: 3525
		[Nullable(2)]
		private FMovieSceneFloatChannel _RTPCChannel;
	}
}
