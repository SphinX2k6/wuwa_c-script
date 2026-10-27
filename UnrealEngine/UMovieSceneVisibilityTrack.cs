using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023BD RID: 9149
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneVisibilityTrack")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UMovieSceneVisibilityTrack : UMovieSceneBoolTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060226D3 RID: 141011 RVA: 0x0032E95C File Offset: 0x0032CB5C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneVisibilityTrack._ClassPtr;
		}

		// Token: 0x060226D4 RID: 141012 RVA: 0x0032E968 File Offset: 0x0032CB68
		public UMovieSceneVisibilityTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneVisibilityTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060226D5 RID: 141013 RVA: 0x0032E990 File Offset: 0x0032CB90
		[NullableContext(1)]
		public UMovieSceneVisibilityTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneVisibilityTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060226D6 RID: 141014 RVA: 0x0032E9C3 File Offset: 0x0032CBC3
		static UMovieSceneVisibilityTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneVisibilityTrack");
		}

		// Token: 0x060226D7 RID: 141015 RVA: 0x0032E9D1 File Offset: 0x0032CBD1
		protected UMovieSceneVisibilityTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012605 RID: 75269
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneVisibilityTrack";

		// Token: 0x04012606 RID: 75270
		private static IntPtr _ClassPtr;

		// Token: 0x04012607 RID: 75271
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
