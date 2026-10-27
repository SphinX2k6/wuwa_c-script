using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020023E8 RID: 9192
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 1)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneEmptyStruct")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
	public struct FMovieSceneEmptyStruct : IEqualityOperators<FMovieSceneEmptyStruct, FMovieSceneEmptyStruct, bool>, IEquatable<FMovieSceneEmptyStruct>, IUnrealScriptStruct
	{
		// Token: 0x06022832 RID: 141362 RVA: 0x00330CE4 File Offset: 0x0032EEE4
		public unsafe static bool operator ==(FMovieSceneEmptyStruct left, FMovieSceneEmptyStruct right)
		{
			Span<byte> span = new Span<byte>((void*)(&left), 1);
			Span<byte> span2 = new Span<byte>((void*)(&right), 1);
			return span.SequenceEqual(span2);
		}

		// Token: 0x06022833 RID: 141363 RVA: 0x00330D10 File Offset: 0x0032EF10
		public static bool operator !=(FMovieSceneEmptyStruct left, FMovieSceneEmptyStruct right)
		{
			return !(left == right);
		}

		// Token: 0x06022834 RID: 141364 RVA: 0x00330D1C File Offset: 0x0032EF1C
		public bool Equals(FMovieSceneEmptyStruct other)
		{
			return this == other;
		}

		// Token: 0x06022835 RID: 141365 RVA: 0x00330D2C File Offset: 0x0032EF2C
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FMovieSceneEmptyStruct)
			{
				FMovieSceneEmptyStruct other = (FMovieSceneEmptyStruct)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06022836 RID: 141366 RVA: 0x00330D51 File Offset: 0x0032EF51
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneEmptyStruct._ScriptStructPtr != 0) ? FMovieSceneEmptyStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneEmptyStruct", ref FMovieSceneEmptyStruct._ScriptStructPtr);
		}

		// Token: 0x0401272B RID: 75563
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneEmptyStruct";

		// Token: 0x0401272C RID: 75564
		private static IntPtr _ScriptStructPtr;
	}
}
