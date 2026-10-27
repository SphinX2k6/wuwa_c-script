using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200245A RID: 9306
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneTrackLabels")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FMovieSceneTrackLabels : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022DEE RID: 142830 RVA: 0x00338F83 File Offset: 0x00337183
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneTrackLabels._ScriptStructPtr != 0) ? FMovieSceneTrackLabels._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneTrackLabels", ref FMovieSceneTrackLabels._ScriptStructPtr);
		}

		// Token: 0x17008609 RID: 34313
		// (get) Token: 0x06022DEF RID: 142831 RVA: 0x00338FA8 File Offset: 0x003371A8
		// (set) Token: 0x06022DF0 RID: 142832 RVA: 0x00338FEB File Offset: 0x003371EB
		public TArray<string> Strings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Strings) == null)
				{
					result = (this._Strings = new TArray<string>(base.NativePtr + (IntPtr)FMovieSceneTrackLabels.__PropertyOffset_Strings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Strings.CopyAssign(value);
			}
		}

		// Token: 0x06022DF1 RID: 142833 RVA: 0x00338FF9 File Offset: 0x003371F9
		public FMovieSceneTrackLabels()
		{
		}

		// Token: 0x06022DF2 RID: 142834 RVA: 0x00339001 File Offset: 0x00337201
		public FMovieSceneTrackLabels(TArray<string> Strings)
		{
			this.Strings = Strings;
		}

		// Token: 0x06022DF3 RID: 142835 RVA: 0x00339010 File Offset: 0x00337210
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneTrackLabels.StaticStruct();
		}

		// Token: 0x06022DF4 RID: 142836 RVA: 0x0033901C File Offset: 0x0033721C
		[NullableContext(2)]
		public FMovieSceneTrackLabels(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022DF5 RID: 142837 RVA: 0x00339026 File Offset: 0x00337226
		public FMovieSceneTrackLabels(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022DF6 RID: 142838 RVA: 0x00339031 File Offset: 0x00337231
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneTrackLabels(Pointer, false, true);
		}

		// Token: 0x06022DF7 RID: 142839 RVA: 0x0033903B File Offset: 0x0033723B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneTrackLabels(Pointer, MemoryOwner);
		}

		// Token: 0x040129DF RID: 76255
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneTrackLabels";

		// Token: 0x040129E0 RID: 76256
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040129E1 RID: 76257
		internal static int __PropertyOffset_Strings;

		// Token: 0x040129E2 RID: 76258
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Strings;
	}
}
