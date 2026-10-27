using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002415 RID: 9237
	[UnrealObjectPath("/Script/MovieScene.MovieSceneMasterTracks")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FMovieSceneMasterTracks : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022A0B RID: 141835 RVA: 0x003335D2 File Offset: 0x003317D2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneMasterTracks._ScriptStructPtr != 0) ? FMovieSceneMasterTracks._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneMasterTracks", ref FMovieSceneMasterTracks._ScriptStructPtr);
		}

		// Token: 0x17008545 RID: 34117
		// (get) Token: 0x06022A0C RID: 141836 RVA: 0x003335F8 File Offset: 0x003317F8
		// (set) Token: 0x06022A0D RID: 141837 RVA: 0x0033363B File Offset: 0x0033183B
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TWeakObjectPtr<UMovieSceneTrack>> MasterTracks
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TWeakObjectPtr<UMovieSceneTrack>> result;
				if ((result = this._MasterTracks) == null)
				{
					result = (this._MasterTracks = new TArray<TWeakObjectPtr<UMovieSceneTrack>>(base.NativePtr + (IntPtr)FMovieSceneMasterTracks.__PropertyOffset_MasterTracks, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.MasterTracks.CopyAssign(value);
			}
		}

		// Token: 0x06022A0E RID: 141838 RVA: 0x00333649 File Offset: 0x00331849
		public FMovieSceneMasterTracks()
		{
		}

		// Token: 0x06022A0F RID: 141839 RVA: 0x00333651 File Offset: 0x00331851
		public FMovieSceneMasterTracks([Nullable(new byte[]
		{
			1,
			0,
			1
		})] TArray<TWeakObjectPtr<UMovieSceneTrack>> MasterTracks)
		{
			this.MasterTracks = MasterTracks;
		}

		// Token: 0x06022A10 RID: 141840 RVA: 0x00333660 File Offset: 0x00331860
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneMasterTracks.StaticStruct();
		}

		// Token: 0x06022A11 RID: 141841 RVA: 0x0033366C File Offset: 0x0033186C
		[NullableContext(2)]
		public FMovieSceneMasterTracks(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022A12 RID: 141842 RVA: 0x00333676 File Offset: 0x00331876
		public FMovieSceneMasterTracks(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022A13 RID: 141843 RVA: 0x00333681 File Offset: 0x00331881
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneMasterTracks(Pointer, false, true);
		}

		// Token: 0x06022A14 RID: 141844 RVA: 0x0033368B File Offset: 0x0033188B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneMasterTracks(Pointer, MemoryOwner);
		}

		// Token: 0x04012809 RID: 75785
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneMasterTracks";

		// Token: 0x0401280A RID: 75786
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401280B RID: 75787
		internal static int __PropertyOffset_MasterTracks;

		// Token: 0x0401280C RID: 75788
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<UMovieSceneTrack>> _MasterTracks;
	}
}
