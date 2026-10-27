using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002315 RID: 8981
	[UnrealObjectPath("/Script/MovieSceneCapture.MovieSceneImageCaptureProtocolBase")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public abstract class UMovieSceneImageCaptureProtocolBase : UMovieSceneCaptureProtocolBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022016 RID: 139286 RVA: 0x00324794 File Offset: 0x00322994
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneImageCaptureProtocolBase._ClassPtr;
		}

		// Token: 0x06022017 RID: 139287 RVA: 0x003247A0 File Offset: 0x003229A0
		static UMovieSceneImageCaptureProtocolBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneCapture.MovieSceneImageCaptureProtocolBase");
		}

		// Token: 0x06022018 RID: 139288 RVA: 0x003247B0 File Offset: 0x003229B0
		protected UMovieSceneImageCaptureProtocolBase() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneImageCaptureProtocolBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022019 RID: 139289 RVA: 0x003247D8 File Offset: 0x003229D8
		protected UMovieSceneImageCaptureProtocolBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401223A RID: 74298
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneCapture.MovieSceneImageCaptureProtocolBase";

		// Token: 0x0401223B RID: 74299
		private static IntPtr _ClassPtr;

		// Token: 0x0401223C RID: 74300
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
