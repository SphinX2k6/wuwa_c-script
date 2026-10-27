using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200235B RID: 9051
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneColorSection")]
	[UnrealStructLayout(944, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 944)]
	public class UMovieSceneColorSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022319 RID: 140057 RVA: 0x00328FF2 File Offset: 0x003271F2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneColorSection._ClassPtr;
		}

		// Token: 0x0602231A RID: 140058 RVA: 0x00329000 File Offset: 0x00327200
		public UMovieSceneColorSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneColorSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602231B RID: 140059 RVA: 0x00329028 File Offset: 0x00327228
		public UMovieSceneColorSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneColorSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008408 RID: 33800
		// (get) Token: 0x0602231C RID: 140060 RVA: 0x0032905C File Offset: 0x0032725C
		// (set) Token: 0x0602231D RID: 140061 RVA: 0x00329095 File Offset: 0x00327295
		public FMovieSceneFloatChannel RedCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._RedCurve) == null)
				{
					result = (this._RedCurve = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)UMovieSceneColorSection.__PropertyOffset_RedCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneColorSection.__PropertyOffset_RedCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008409 RID: 33801
		// (get) Token: 0x0602231E RID: 140062 RVA: 0x003290B8 File Offset: 0x003272B8
		// (set) Token: 0x0602231F RID: 140063 RVA: 0x003290F1 File Offset: 0x003272F1
		public FMovieSceneFloatChannel GreenCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._GreenCurve) == null)
				{
					result = (this._GreenCurve = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)UMovieSceneColorSection.__PropertyOffset_GreenCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneColorSection.__PropertyOffset_GreenCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700840A RID: 33802
		// (get) Token: 0x06022320 RID: 140064 RVA: 0x00329114 File Offset: 0x00327314
		// (set) Token: 0x06022321 RID: 140065 RVA: 0x0032914D File Offset: 0x0032734D
		public FMovieSceneFloatChannel BlueCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._BlueCurve) == null)
				{
					result = (this._BlueCurve = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)UMovieSceneColorSection.__PropertyOffset_BlueCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneColorSection.__PropertyOffset_BlueCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700840B RID: 33803
		// (get) Token: 0x06022322 RID: 140066 RVA: 0x00329170 File Offset: 0x00327370
		// (set) Token: 0x06022323 RID: 140067 RVA: 0x003291A9 File Offset: 0x003273A9
		public FMovieSceneFloatChannel AlphaCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._AlphaCurve) == null)
				{
					result = (this._AlphaCurve = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)UMovieSceneColorSection.__PropertyOffset_AlphaCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneColorSection.__PropertyOffset_AlphaCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06022324 RID: 140068 RVA: 0x003291CA File Offset: 0x003273CA
		static UMovieSceneColorSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneColorSection");
		}

		// Token: 0x06022325 RID: 140069 RVA: 0x003291D8 File Offset: 0x003273D8
		protected UMovieSceneColorSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012406 RID: 74758
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneColorSection";

		// Token: 0x04012407 RID: 74759
		private static IntPtr _ClassPtr;

		// Token: 0x04012408 RID: 74760
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012409 RID: 74761
		internal static int __PropertyOffset_RedCurve;

		// Token: 0x0401240A RID: 74762
		[Nullable(2)]
		private FMovieSceneFloatChannel _RedCurve;

		// Token: 0x0401240B RID: 74763
		internal static int __PropertyOffset_GreenCurve;

		// Token: 0x0401240C RID: 74764
		[Nullable(2)]
		private FMovieSceneFloatChannel _GreenCurve;

		// Token: 0x0401240D RID: 74765
		internal static int __PropertyOffset_BlueCurve;

		// Token: 0x0401240E RID: 74766
		[Nullable(2)]
		private FMovieSceneFloatChannel _BlueCurve;

		// Token: 0x0401240F RID: 74767
		internal static int __PropertyOffset_AlphaCurve;

		// Token: 0x04012410 RID: 74768
		[Nullable(2)]
		private FMovieSceneFloatChannel _AlphaCurve;
	}
}
