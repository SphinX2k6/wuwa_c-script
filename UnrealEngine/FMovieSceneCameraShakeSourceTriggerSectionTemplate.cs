using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002355 RID: 9045
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneCameraShakeSourceTriggerSectionTemplate")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FMovieSceneCameraShakeSourceTriggerSectionTemplate : FMovieSceneEvalTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060222DF RID: 139999 RVA: 0x00328A69 File Offset: 0x00326C69
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneCameraShakeSourceTriggerSectionTemplate._ScriptStructPtr != 0) ? FMovieSceneCameraShakeSourceTriggerSectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneCameraShakeSourceTriggerSectionTemplate", ref FMovieSceneCameraShakeSourceTriggerSectionTemplate._ScriptStructPtr);
		}

		// Token: 0x17008400 RID: 33792
		// (get) Token: 0x060222E0 RID: 140000 RVA: 0x00328A90 File Offset: 0x00326C90
		// (set) Token: 0x060222E1 RID: 140001 RVA: 0x00328AD3 File Offset: 0x00326CD3
		public TArray<FFrameNumber> TriggerTimes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FFrameNumber> result;
				if ((result = this._TriggerTimes) == null)
				{
					result = (this._TriggerTimes = new TArray<FFrameNumber>(base.NativePtr + (IntPtr)FMovieSceneCameraShakeSourceTriggerSectionTemplate.__PropertyOffset_TriggerTimes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TriggerTimes.CopyAssign(value);
			}
		}

		// Token: 0x17008401 RID: 33793
		// (get) Token: 0x060222E2 RID: 140002 RVA: 0x00328AE4 File Offset: 0x00326CE4
		// (set) Token: 0x060222E3 RID: 140003 RVA: 0x00328B27 File Offset: 0x00326D27
		public TArray<FMovieSceneCameraShakeSourceTrigger> TriggerValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMovieSceneCameraShakeSourceTrigger> result;
				if ((result = this._TriggerValues) == null)
				{
					result = (this._TriggerValues = new TArray<FMovieSceneCameraShakeSourceTrigger>(base.NativePtr + (IntPtr)FMovieSceneCameraShakeSourceTriggerSectionTemplate.__PropertyOffset_TriggerValues, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TriggerValues.CopyAssign(value);
			}
		}

		// Token: 0x060222E4 RID: 140004 RVA: 0x00328B35 File Offset: 0x00326D35
		public FMovieSceneCameraShakeSourceTriggerSectionTemplate()
		{
		}

		// Token: 0x060222E5 RID: 140005 RVA: 0x00328B3D File Offset: 0x00326D3D
		public FMovieSceneCameraShakeSourceTriggerSectionTemplate(TArray<FFrameNumber> TriggerTimes, TArray<FMovieSceneCameraShakeSourceTrigger> TriggerValues, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.TriggerTimes = TriggerTimes;
			this.TriggerValues = TriggerValues;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x060222E6 RID: 140006 RVA: 0x00328B62 File Offset: 0x00326D62
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneCameraShakeSourceTriggerSectionTemplate.StaticStruct();
		}

		// Token: 0x060222E7 RID: 140007 RVA: 0x00328B6E File Offset: 0x00326D6E
		[NullableContext(2)]
		public FMovieSceneCameraShakeSourceTriggerSectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060222E8 RID: 140008 RVA: 0x00328B78 File Offset: 0x00326D78
		public FMovieSceneCameraShakeSourceTriggerSectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060222E9 RID: 140009 RVA: 0x00328B83 File Offset: 0x00326D83
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneCameraShakeSourceTriggerSectionTemplate(Pointer, false, true);
		}

		// Token: 0x060222EA RID: 140010 RVA: 0x00328B8D File Offset: 0x00326D8D
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneCameraShakeSourceTriggerSectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x040123E6 RID: 74726
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneCameraShakeSourceTriggerSectionTemplate";

		// Token: 0x040123E7 RID: 74727
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040123E8 RID: 74728
		internal static int __PropertyOffset_TriggerTimes;

		// Token: 0x040123E9 RID: 74729
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FFrameNumber> _TriggerTimes;

		// Token: 0x040123EA RID: 74730
		internal static int __PropertyOffset_TriggerValues;

		// Token: 0x040123EB RID: 74731
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneCameraShakeSourceTrigger> _TriggerValues;
	}
}
