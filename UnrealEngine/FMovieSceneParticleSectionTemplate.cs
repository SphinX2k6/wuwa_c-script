using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002396 RID: 9110
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneParticleSectionTemplate")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 184)]
	public class FMovieSceneParticleSectionTemplate : FMovieSceneEvalTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022545 RID: 140613 RVA: 0x0032C4E9 File Offset: 0x0032A6E9
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneParticleSectionTemplate._ScriptStructPtr != 0) ? FMovieSceneParticleSectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneParticleSectionTemplate", ref FMovieSceneParticleSectionTemplate._ScriptStructPtr);
		}

		// Token: 0x17008452 RID: 33874
		// (get) Token: 0x06022546 RID: 140614 RVA: 0x0032C510 File Offset: 0x0032A710
		// (set) Token: 0x06022547 RID: 140615 RVA: 0x0032C553 File Offset: 0x0032A753
		public FMovieSceneParticleChannel ParticleKeys
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneParticleChannel result;
				if ((result = this._ParticleKeys) == null)
				{
					result = (this._ParticleKeys = new FMovieSceneParticleChannel(base.NativePtr + (IntPtr)FMovieSceneParticleSectionTemplate.__PropertyOffset_ParticleKeys, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneParticleChannel.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneParticleSectionTemplate.__PropertyOffset_ParticleKeys, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06022548 RID: 140616 RVA: 0x0032C574 File Offset: 0x0032A774
		public FMovieSceneParticleSectionTemplate()
		{
		}

		// Token: 0x06022549 RID: 140617 RVA: 0x0032C57C File Offset: 0x0032A77C
		public FMovieSceneParticleSectionTemplate(FMovieSceneParticleChannel ParticleKeys, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.ParticleKeys = ParticleKeys;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x0602254A RID: 140618 RVA: 0x0032C599 File Offset: 0x0032A799
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneParticleSectionTemplate.StaticStruct();
		}

		// Token: 0x0602254B RID: 140619 RVA: 0x0032C5A5 File Offset: 0x0032A7A5
		[NullableContext(2)]
		public FMovieSceneParticleSectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602254C RID: 140620 RVA: 0x0032C5AF File Offset: 0x0032A7AF
		public FMovieSceneParticleSectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602254D RID: 140621 RVA: 0x0032C5BA File Offset: 0x0032A7BA
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneParticleSectionTemplate(Pointer, false, true);
		}

		// Token: 0x0602254E RID: 140622 RVA: 0x0032C5C4 File Offset: 0x0032A7C4
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneParticleSectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x04012532 RID: 75058
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneParticleSectionTemplate";

		// Token: 0x04012533 RID: 75059
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012534 RID: 75060
		internal static int __PropertyOffset_ParticleKeys;

		// Token: 0x04012535 RID: 75061
		[Nullable(2)]
		private FMovieSceneParticleChannel _ParticleKeys;
	}
}
