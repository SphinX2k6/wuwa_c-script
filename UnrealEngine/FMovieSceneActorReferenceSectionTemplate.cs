using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002339 RID: 9017
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneActorReferenceSectionTemplate")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 248)]
	public class FMovieSceneActorReferenceSectionTemplate : FMovieSceneEvalTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022192 RID: 139666 RVA: 0x00326AAA File Offset: 0x00324CAA
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneActorReferenceSectionTemplate._ScriptStructPtr != 0) ? FMovieSceneActorReferenceSectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneActorReferenceSectionTemplate", ref FMovieSceneActorReferenceSectionTemplate._ScriptStructPtr);
		}

		// Token: 0x170083BA RID: 33722
		// (get) Token: 0x06022193 RID: 139667 RVA: 0x00326AD0 File Offset: 0x00324CD0
		// (set) Token: 0x06022194 RID: 139668 RVA: 0x00326B13 File Offset: 0x00324D13
		public FMovieScenePropertySectionData PropertyData
		{
			get
			{
				base.FastCheckIsValid();
				FMovieScenePropertySectionData result;
				if ((result = this._PropertyData) == null)
				{
					result = (this._PropertyData = new FMovieScenePropertySectionData(base.NativePtr + (IntPtr)FMovieSceneActorReferenceSectionTemplate.__PropertyOffset_PropertyData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieScenePropertySectionData.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneActorReferenceSectionTemplate.__PropertyOffset_PropertyData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170083BB RID: 33723
		// (get) Token: 0x06022195 RID: 139669 RVA: 0x00326B34 File Offset: 0x00324D34
		// (set) Token: 0x06022196 RID: 139670 RVA: 0x00326B77 File Offset: 0x00324D77
		public FMovieSceneActorReferenceData ActorReferenceData
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneActorReferenceData result;
				if ((result = this._ActorReferenceData) == null)
				{
					result = (this._ActorReferenceData = new FMovieSceneActorReferenceData(base.NativePtr + (IntPtr)FMovieSceneActorReferenceSectionTemplate.__PropertyOffset_ActorReferenceData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneActorReferenceData.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneActorReferenceSectionTemplate.__PropertyOffset_ActorReferenceData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06022197 RID: 139671 RVA: 0x00326B98 File Offset: 0x00324D98
		public FMovieSceneActorReferenceSectionTemplate()
		{
		}

		// Token: 0x06022198 RID: 139672 RVA: 0x00326BA0 File Offset: 0x00324DA0
		public FMovieSceneActorReferenceSectionTemplate(FMovieScenePropertySectionData PropertyData, FMovieSceneActorReferenceData ActorReferenceData, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.PropertyData = PropertyData;
			this.ActorReferenceData = ActorReferenceData;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x06022199 RID: 139673 RVA: 0x00326BC5 File Offset: 0x00324DC5
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneActorReferenceSectionTemplate.StaticStruct();
		}

		// Token: 0x0602219A RID: 139674 RVA: 0x00326BD1 File Offset: 0x00324DD1
		[NullableContext(2)]
		public FMovieSceneActorReferenceSectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602219B RID: 139675 RVA: 0x00326BDB File Offset: 0x00324DDB
		public FMovieSceneActorReferenceSectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602219C RID: 139676 RVA: 0x00326BE6 File Offset: 0x00324DE6
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneActorReferenceSectionTemplate(Pointer, false, true);
		}

		// Token: 0x0602219D RID: 139677 RVA: 0x00326BF0 File Offset: 0x00324DF0
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneActorReferenceSectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x04012331 RID: 74545
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneActorReferenceSectionTemplate";

		// Token: 0x04012332 RID: 74546
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012333 RID: 74547
		internal static int __PropertyOffset_PropertyData;

		// Token: 0x04012334 RID: 74548
		[Nullable(2)]
		private FMovieScenePropertySectionData _PropertyData;

		// Token: 0x04012335 RID: 74549
		internal static int __PropertyOffset_ActorReferenceData;

		// Token: 0x04012336 RID: 74550
		[Nullable(2)]
		private FMovieSceneActorReferenceData _ActorReferenceData;
	}
}
