using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200230F RID: 8975
	[UnrealObjectPath("/Script/MovieSceneCapture.MovieSceneAudioCaptureProtocolBase")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public abstract class UMovieSceneAudioCaptureProtocolBase : UMovieSceneCaptureProtocolBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021FA9 RID: 139177 RVA: 0x00323EDF File Offset: 0x003220DF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneAudioCaptureProtocolBase._ClassPtr;
		}

		// Token: 0x06021FAA RID: 139178 RVA: 0x00323EEB File Offset: 0x003220EB
		static UMovieSceneAudioCaptureProtocolBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneCapture.MovieSceneAudioCaptureProtocolBase");
		}

		// Token: 0x06021FAB RID: 139179 RVA: 0x00323EFC File Offset: 0x003220FC
		protected UMovieSceneAudioCaptureProtocolBase() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneAudioCaptureProtocolBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021FAC RID: 139180 RVA: 0x00323F24 File Offset: 0x00322124
		protected UMovieSceneAudioCaptureProtocolBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012206 RID: 74246
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneCapture.MovieSceneAudioCaptureProtocolBase";

		// Token: 0x04012207 RID: 74247
		private static IntPtr _ClassPtr;

		// Token: 0x04012208 RID: 74248
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
