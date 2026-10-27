using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002458 RID: 9304
	[UnrealObjectPath("/Script/MovieScene.MovieSceneTrackInstanceInstantiator")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UMovieSceneTrackInstanceInstantiator : UMovieSceneEntityInstantiatorSystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022DE2 RID: 142818 RVA: 0x00338E5A File Offset: 0x0033705A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneTrackInstanceInstantiator._ClassPtr;
		}

		// Token: 0x06022DE3 RID: 142819 RVA: 0x00338E68 File Offset: 0x00337068
		public UMovieSceneTrackInstanceInstantiator() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneTrackInstanceInstantiator.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022DE4 RID: 142820 RVA: 0x00338E90 File Offset: 0x00337090
		[NullableContext(1)]
		public UMovieSceneTrackInstanceInstantiator(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneTrackInstanceInstantiator.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022DE5 RID: 142821 RVA: 0x00338EC3 File Offset: 0x003370C3
		static UMovieSceneTrackInstanceInstantiator()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneTrackInstanceInstantiator");
		}

		// Token: 0x06022DE6 RID: 142822 RVA: 0x00338ED1 File Offset: 0x003370D1
		protected UMovieSceneTrackInstanceInstantiator(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040129D8 RID: 76248
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneTrackInstanceInstantiator";

		// Token: 0x040129D9 RID: 76249
		private static IntPtr _ClassPtr;

		// Token: 0x040129DA RID: 76250
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
