using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002372 RID: 9074
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneEventSectionBase")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UMovieSceneEventSectionBase : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060223DB RID: 140251 RVA: 0x0032A22D File Offset: 0x0032842D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneEventSectionBase._ClassPtr;
		}

		// Token: 0x060223DC RID: 140252 RVA: 0x0032A23C File Offset: 0x0032843C
		public UMovieSceneEventSectionBase() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneEventSectionBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060223DD RID: 140253 RVA: 0x0032A264 File Offset: 0x00328464
		[NullableContext(1)]
		public UMovieSceneEventSectionBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneEventSectionBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060223DE RID: 140254 RVA: 0x0032A297 File Offset: 0x00328497
		static UMovieSceneEventSectionBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneEventSectionBase");
		}

		// Token: 0x060223DF RID: 140255 RVA: 0x0032A2A5 File Offset: 0x003284A5
		protected UMovieSceneEventSectionBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401246F RID: 74863
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneEventSectionBase";

		// Token: 0x04012470 RID: 74864
		private static IntPtr _ClassPtr;

		// Token: 0x04012471 RID: 74865
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
