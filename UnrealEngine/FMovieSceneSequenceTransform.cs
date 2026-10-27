using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200243B RID: 9275
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneSequenceTransform")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FMovieSceneSequenceTransform : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022C79 RID: 142457 RVA: 0x00336C8A File Offset: 0x00334E8A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneSequenceTransform._ScriptStructPtr != 0) ? FMovieSceneSequenceTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneSequenceTransform", ref FMovieSceneSequenceTransform._ScriptStructPtr);
		}

		// Token: 0x170085BB RID: 34235
		// (get) Token: 0x06022C7A RID: 142458 RVA: 0x00336CB0 File Offset: 0x00334EB0
		// (set) Token: 0x06022C7B RID: 142459 RVA: 0x00336CF3 File Offset: 0x00334EF3
		public FMovieSceneTimeTransform LinearTransform
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneTimeTransform result;
				if ((result = this._LinearTransform) == null)
				{
					result = (this._LinearTransform = new FMovieSceneTimeTransform(base.NativePtr + (IntPtr)FMovieSceneSequenceTransform.__PropertyOffset_LinearTransform, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneTimeTransform.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneSequenceTransform.__PropertyOffset_LinearTransform, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170085BC RID: 34236
		// (get) Token: 0x06022C7C RID: 142460 RVA: 0x00336D14 File Offset: 0x00334F14
		// (set) Token: 0x06022C7D RID: 142461 RVA: 0x00336D57 File Offset: 0x00334F57
		public TArray<FMovieSceneNestedSequenceTransform> NestedTransforms
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMovieSceneNestedSequenceTransform> result;
				if ((result = this._NestedTransforms) == null)
				{
					result = (this._NestedTransforms = new TArray<FMovieSceneNestedSequenceTransform>(base.NativePtr + (IntPtr)FMovieSceneSequenceTransform.__PropertyOffset_NestedTransforms, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.NestedTransforms.CopyAssign(value);
			}
		}

		// Token: 0x06022C7E RID: 142462 RVA: 0x00336D65 File Offset: 0x00334F65
		public FMovieSceneSequenceTransform()
		{
		}

		// Token: 0x06022C7F RID: 142463 RVA: 0x00336D6D File Offset: 0x00334F6D
		public FMovieSceneSequenceTransform(FMovieSceneTimeTransform LinearTransform, TArray<FMovieSceneNestedSequenceTransform> NestedTransforms)
		{
			this.LinearTransform = LinearTransform;
			this.NestedTransforms = NestedTransforms;
		}

		// Token: 0x06022C80 RID: 142464 RVA: 0x00336D83 File Offset: 0x00334F83
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneSequenceTransform.StaticStruct();
		}

		// Token: 0x06022C81 RID: 142465 RVA: 0x00336D8F File Offset: 0x00334F8F
		[NullableContext(2)]
		public FMovieSceneSequenceTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022C82 RID: 142466 RVA: 0x00336D99 File Offset: 0x00334F99
		public FMovieSceneSequenceTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022C83 RID: 142467 RVA: 0x00336DA4 File Offset: 0x00334FA4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneSequenceTransform(Pointer, false, true);
		}

		// Token: 0x06022C84 RID: 142468 RVA: 0x00336DAE File Offset: 0x00334FAE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneSequenceTransform(Pointer, MemoryOwner);
		}

		// Token: 0x0401291D RID: 76061
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneSequenceTransform";

		// Token: 0x0401291E RID: 76062
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401291F RID: 76063
		internal static int __PropertyOffset_LinearTransform;

		// Token: 0x04012920 RID: 76064
		[Nullable(2)]
		private FMovieSceneTimeTransform _LinearTransform;

		// Token: 0x04012921 RID: 76065
		internal static int __PropertyOffset_NestedTransforms;

		// Token: 0x04012922 RID: 76066
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneNestedSequenceTransform> _NestedTransforms;
	}
}
