using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020026E0 RID: 9952
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 1)]
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneAutoTransformExecutionHelper")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
	public struct FMovieSceneAutoTransformExecutionHelper : IEqualityOperators<FMovieSceneAutoTransformExecutionHelper, FMovieSceneAutoTransformExecutionHelper, bool>, IEquatable<FMovieSceneAutoTransformExecutionHelper>, IUnrealScriptStruct
	{
		// Token: 0x06024EB2 RID: 151218 RVA: 0x00369AA0 File Offset: 0x00367CA0
		public unsafe static bool operator ==(FMovieSceneAutoTransformExecutionHelper left, FMovieSceneAutoTransformExecutionHelper right)
		{
			Span<byte> span = new Span<byte>((void*)(&left), 1);
			Span<byte> span2 = new Span<byte>((void*)(&right), 1);
			return span.SequenceEqual(span2);
		}

		// Token: 0x06024EB3 RID: 151219 RVA: 0x00369ACC File Offset: 0x00367CCC
		public static bool operator !=(FMovieSceneAutoTransformExecutionHelper left, FMovieSceneAutoTransformExecutionHelper right)
		{
			return !(left == right);
		}

		// Token: 0x06024EB4 RID: 151220 RVA: 0x00369AD8 File Offset: 0x00367CD8
		public bool Equals(FMovieSceneAutoTransformExecutionHelper other)
		{
			return this == other;
		}

		// Token: 0x06024EB5 RID: 151221 RVA: 0x00369AE8 File Offset: 0x00367CE8
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FMovieSceneAutoTransformExecutionHelper)
			{
				FMovieSceneAutoTransformExecutionHelper other = (FMovieSceneAutoTransformExecutionHelper)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06024EB6 RID: 151222 RVA: 0x00369B0D File Offset: 0x00367D0D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneAutoTransformExecutionHelper._ScriptStructPtr != 0) ? FMovieSceneAutoTransformExecutionHelper._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SequenceDialogue.MovieSceneAutoTransformExecutionHelper", ref FMovieSceneAutoTransformExecutionHelper._ScriptStructPtr);
		}

		// Token: 0x04013E4C RID: 81484
		public const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneAutoTransformExecutionHelper";

		// Token: 0x04013E4D RID: 81485
		private static IntPtr _ScriptStructPtr;
	}
}
