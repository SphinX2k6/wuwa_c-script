using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200237E RID: 9086
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneFloatTrack")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UMovieSceneFloatTrack : UMovieScenePropertyTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602244D RID: 140365 RVA: 0x0032ADD5 File Offset: 0x00328FD5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneFloatTrack._ClassPtr;
		}

		// Token: 0x0602244E RID: 140366 RVA: 0x0032ADE4 File Offset: 0x00328FE4
		public UMovieSceneFloatTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneFloatTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602244F RID: 140367 RVA: 0x0032AE0C File Offset: 0x0032900C
		[NullableContext(1)]
		public UMovieSceneFloatTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneFloatTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022450 RID: 140368 RVA: 0x0032AE3F File Offset: 0x0032903F
		static UMovieSceneFloatTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneFloatTrack");
		}

		// Token: 0x06022451 RID: 140369 RVA: 0x0032AE4D File Offset: 0x0032904D
		protected UMovieSceneFloatTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040124B5 RID: 74933
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneFloatTrack";

		// Token: 0x040124B6 RID: 74934
		private static IntPtr _ClassPtr;

		// Token: 0x040124B7 RID: 74935
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
