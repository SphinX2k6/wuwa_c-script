using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200239E RID: 9118
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieScenePrimitiveMaterialTemplate")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 240)]
	public class FMovieScenePrimitiveMaterialTemplate : FMovieSceneEvalTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022579 RID: 140665 RVA: 0x0032CA05 File Offset: 0x0032AC05
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieScenePrimitiveMaterialTemplate._ScriptStructPtr != 0) ? FMovieScenePrimitiveMaterialTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieScenePrimitiveMaterialTemplate", ref FMovieScenePrimitiveMaterialTemplate._ScriptStructPtr);
		}

		// Token: 0x17008455 RID: 33877
		// (get) Token: 0x0602257A RID: 140666 RVA: 0x0032CA29 File Offset: 0x0032AC29
		// (set) Token: 0x0602257B RID: 140667 RVA: 0x0032CA39 File Offset: 0x0032AC39
		public unsafe int MaterialIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieScenePrimitiveMaterialTemplate.__PropertyOffset_MaterialIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieScenePrimitiveMaterialTemplate.__PropertyOffset_MaterialIndex) = value;
			}
		}

		// Token: 0x17008456 RID: 33878
		// (get) Token: 0x0602257C RID: 140668 RVA: 0x0032CA4C File Offset: 0x0032AC4C
		// (set) Token: 0x0602257D RID: 140669 RVA: 0x0032CA8F File Offset: 0x0032AC8F
		public FMovieSceneObjectPathChannel MaterialChannel
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneObjectPathChannel result;
				if ((result = this._MaterialChannel) == null)
				{
					result = (this._MaterialChannel = new FMovieSceneObjectPathChannel(base.NativePtr + (IntPtr)FMovieScenePrimitiveMaterialTemplate.__PropertyOffset_MaterialChannel, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneObjectPathChannel.StaticStruct(), base.NativePtr + (IntPtr)FMovieScenePrimitiveMaterialTemplate.__PropertyOffset_MaterialChannel, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602257E RID: 140670 RVA: 0x0032CAB0 File Offset: 0x0032ACB0
		public FMovieScenePrimitiveMaterialTemplate()
		{
		}

		// Token: 0x0602257F RID: 140671 RVA: 0x0032CAB8 File Offset: 0x0032ACB8
		public FMovieScenePrimitiveMaterialTemplate(int MaterialIndex, FMovieSceneObjectPathChannel MaterialChannel, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.MaterialIndex = MaterialIndex;
			this.MaterialChannel = MaterialChannel;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x06022580 RID: 140672 RVA: 0x0032CADD File Offset: 0x0032ACDD
		protected override IntPtr GetUStructPtr()
		{
			return FMovieScenePrimitiveMaterialTemplate.StaticStruct();
		}

		// Token: 0x06022581 RID: 140673 RVA: 0x0032CAE9 File Offset: 0x0032ACE9
		[NullableContext(2)]
		public FMovieScenePrimitiveMaterialTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022582 RID: 140674 RVA: 0x0032CAF3 File Offset: 0x0032ACF3
		public FMovieScenePrimitiveMaterialTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022583 RID: 140675 RVA: 0x0032CAFE File Offset: 0x0032ACFE
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieScenePrimitiveMaterialTemplate(Pointer, false, true);
		}

		// Token: 0x06022584 RID: 140676 RVA: 0x0032CB08 File Offset: 0x0032AD08
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieScenePrimitiveMaterialTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x04012552 RID: 75090
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieScenePrimitiveMaterialTemplate";

		// Token: 0x04012553 RID: 75091
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012554 RID: 75092
		internal static int __PropertyOffset_MaterialIndex;

		// Token: 0x04012555 RID: 75093
		internal static int __PropertyOffset_MaterialChannel;

		// Token: 0x04012556 RID: 75094
		[Nullable(2)]
		private FMovieSceneObjectPathChannel _MaterialChannel;
	}
}
