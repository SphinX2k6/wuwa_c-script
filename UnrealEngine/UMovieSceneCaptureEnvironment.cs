using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002311 RID: 8977
	[UnrealObjectPath("/Script/MovieSceneCapture.MovieSceneCaptureEnvironment")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UMovieSceneCaptureEnvironment : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021FCD RID: 139213 RVA: 0x003241F3 File Offset: 0x003223F3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneCaptureEnvironment._ClassPtr;
		}

		// Token: 0x06021FCE RID: 139214 RVA: 0x00324200 File Offset: 0x00322400
		public UMovieSceneCaptureEnvironment() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneCaptureEnvironment.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021FCF RID: 139215 RVA: 0x00324228 File Offset: 0x00322428
		[NullableContext(1)]
		public UMovieSceneCaptureEnvironment(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneCaptureEnvironment.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021FD0 RID: 139216
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsCaptureInProgress();

		// Token: 0x06021FD1 RID: 139217
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetCaptureFrameNumber();

		// Token: 0x06021FD2 RID: 139218
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetCaptureElapsedTime();

		// Token: 0x06021FD3 RID: 139219 RVA: 0x0032425B File Offset: 0x0032245B
		[NullableContext(2)]
		public static UMovieSceneImageCaptureProtocolBase FindImageCaptureProtocol()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMovieSceneImageCaptureProtocolBase>(UMovieSceneCaptureEnvironment.__FindImageCaptureProtocol_Internal());
		}

		// Token: 0x06021FD4 RID: 139220 RVA: 0x00324267 File Offset: 0x00322467
		[NullableContext(2)]
		public static UMovieSceneAudioCaptureProtocolBase FindAudioCaptureProtocol()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMovieSceneAudioCaptureProtocolBase>(UMovieSceneCaptureEnvironment.__FindAudioCaptureProtocol_Internal());
		}

		// Token: 0x06021FD5 RID: 139221
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindImageCaptureProtocol_Internal();

		// Token: 0x06021FD6 RID: 139222
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindAudioCaptureProtocol_Internal();

		// Token: 0x06021FD7 RID: 139223 RVA: 0x00324273 File Offset: 0x00322473
		static UMovieSceneCaptureEnvironment()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneCapture.MovieSceneCaptureEnvironment");
		}

		// Token: 0x06021FD8 RID: 139224 RVA: 0x00324281 File Offset: 0x00322481
		protected UMovieSceneCaptureEnvironment(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012219 RID: 74265
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneCapture.MovieSceneCaptureEnvironment";

		// Token: 0x0401221A RID: 74266
		private static IntPtr _ClassPtr;

		// Token: 0x0401221B RID: 74267
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
