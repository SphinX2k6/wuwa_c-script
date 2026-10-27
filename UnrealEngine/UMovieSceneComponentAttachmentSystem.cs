using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200235F RID: 9055
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneComponentAttachmentSystem")]
	[UnrealStructLayout(464, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class UMovieSceneComponentAttachmentSystem : UMovieSceneEntityInstantiatorSystem, IUnrealUObject, IUnrealObject, IMovieScenePreAnimatedStateSystemInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0602233F RID: 140095 RVA: 0x0032940A File Offset: 0x0032760A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneComponentAttachmentSystem._ClassPtr;
		}

		// Token: 0x06022340 RID: 140096 RVA: 0x00329416 File Offset: 0x00327616
		int IMovieScenePreAnimatedStateSystemInterface.InterfaceOffset()
		{
			return UMovieSceneComponentAttachmentSystem.__InterfaceOffset_IMovieScenePreAnimatedStateSystemInterface;
		}

		// Token: 0x06022341 RID: 140097 RVA: 0x00329420 File Offset: 0x00327620
		public UMovieSceneComponentAttachmentSystem() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneComponentAttachmentSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022342 RID: 140098 RVA: 0x00329448 File Offset: 0x00327648
		[NullableContext(1)]
		public UMovieSceneComponentAttachmentSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneComponentAttachmentSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022343 RID: 140099 RVA: 0x0032947B File Offset: 0x0032767B
		static UMovieSceneComponentAttachmentSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneComponentAttachmentSystem");
		}

		// Token: 0x06022344 RID: 140100 RVA: 0x00329489 File Offset: 0x00327689
		protected UMovieSceneComponentAttachmentSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401241E RID: 74782
		internal static int __InterfaceOffset_IMovieScenePreAnimatedStateSystemInterface;

		// Token: 0x0401241F RID: 74783
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneComponentAttachmentSystem";

		// Token: 0x04012420 RID: 74784
		private static IntPtr _ClassPtr;

		// Token: 0x04012421 RID: 74785
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
