using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020026FB RID: 9979
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneQteTriggerTemplate")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 168)]
	public class FMovieSceneQteTriggerTemplate : FMovieSceneEvalTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025026 RID: 151590 RVA: 0x0036C0A9 File Offset: 0x0036A2A9
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneQteTriggerTemplate._ScriptStructPtr != 0) ? FMovieSceneQteTriggerTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SequenceDialogue.MovieSceneQteTriggerTemplate", ref FMovieSceneQteTriggerTemplate._ScriptStructPtr);
		}

		// Token: 0x17008EE7 RID: 36583
		// (get) Token: 0x06025027 RID: 151591 RVA: 0x0036C0D0 File Offset: 0x0036A2D0
		// (set) Token: 0x06025028 RID: 151592 RVA: 0x0036C113 File Offset: 0x0036A313
		public FMovieSceneQteTriggerChannel EventData
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneQteTriggerChannel result;
				if ((result = this._EventData) == null)
				{
					result = (this._EventData = new FMovieSceneQteTriggerChannel(base.NativePtr + (IntPtr)FMovieSceneQteTriggerTemplate.__PropertyOffset_EventData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneQteTriggerChannel.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneQteTriggerTemplate.__PropertyOffset_EventData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06025029 RID: 151593 RVA: 0x0036C134 File Offset: 0x0036A334
		public FMovieSceneQteTriggerTemplate()
		{
		}

		// Token: 0x0602502A RID: 151594 RVA: 0x0036C13C File Offset: 0x0036A33C
		public FMovieSceneQteTriggerTemplate(FMovieSceneQteTriggerChannel EventData, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.EventData = EventData;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x0602502B RID: 151595 RVA: 0x0036C159 File Offset: 0x0036A359
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneQteTriggerTemplate.StaticStruct();
		}

		// Token: 0x0602502C RID: 151596 RVA: 0x0036C165 File Offset: 0x0036A365
		[NullableContext(2)]
		public FMovieSceneQteTriggerTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602502D RID: 151597 RVA: 0x0036C16F File Offset: 0x0036A36F
		public FMovieSceneQteTriggerTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602502E RID: 151598 RVA: 0x0036C17A File Offset: 0x0036A37A
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneQteTriggerTemplate(Pointer, false, true);
		}

		// Token: 0x0602502F RID: 151599 RVA: 0x0036C184 File Offset: 0x0036A384
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneQteTriggerTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x04013F1C RID: 81692
		public new const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneQteTriggerTemplate";

		// Token: 0x04013F1D RID: 81693
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013F1E RID: 81694
		internal static int __PropertyOffset_EventData;

		// Token: 0x04013F1F RID: 81695
		[Nullable(2)]
		private FMovieSceneQteTriggerChannel _EventData;
	}
}
