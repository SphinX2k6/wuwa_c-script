using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000767 RID: 1895
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneEventSectionBase")]
	[UnrealStructLayout(328, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 328)]
	public class UMovieSceneEventSectionBase : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A49F RID: 42143 RVA: 0x000F31EA File Offset: 0x000F13EA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneEventSectionBase._ClassPtr;
		}

		// Token: 0x0600A4A0 RID: 42144 RVA: 0x000F31F8 File Offset: 0x000F13F8
		public UMovieSceneEventSectionBase() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneEventSectionBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A4A1 RID: 42145 RVA: 0x000F3220 File Offset: 0x000F1420
		[NullableContext(1)]
		public UMovieSceneEventSectionBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneEventSectionBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600A4A2 RID: 42146 RVA: 0x000F3253 File Offset: 0x000F1453
		static UMovieSceneEventSectionBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneEventSectionBase");
		}

		// Token: 0x0600A4A3 RID: 42147 RVA: 0x000F3261 File Offset: 0x000F1461
		protected UMovieSceneEventSectionBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004636 RID: 17974
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneEventSectionBase";

		// Token: 0x04004637 RID: 17975
		private static IntPtr _ClassPtr;

		// Token: 0x04004638 RID: 17976
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
