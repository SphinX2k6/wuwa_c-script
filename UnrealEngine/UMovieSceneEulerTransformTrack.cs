using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200236A RID: 9066
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneEulerTransformTrack")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UMovieSceneEulerTransformTrack : UMovieScenePropertyTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022392 RID: 140178 RVA: 0x00329BEA File Offset: 0x00327DEA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneEulerTransformTrack._ClassPtr;
		}

		// Token: 0x06022393 RID: 140179 RVA: 0x00329BF8 File Offset: 0x00327DF8
		public UMovieSceneEulerTransformTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneEulerTransformTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022394 RID: 140180 RVA: 0x00329C20 File Offset: 0x00327E20
		[NullableContext(1)]
		public UMovieSceneEulerTransformTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneEulerTransformTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022395 RID: 140181 RVA: 0x00329C53 File Offset: 0x00327E53
		static UMovieSceneEulerTransformTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneEulerTransformTrack");
		}

		// Token: 0x06022396 RID: 140182 RVA: 0x00329C61 File Offset: 0x00327E61
		protected UMovieSceneEulerTransformTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401244C RID: 74828
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneEulerTransformTrack";

		// Token: 0x0401244D RID: 74829
		private static IntPtr _ClassPtr;

		// Token: 0x0401244E RID: 74830
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
