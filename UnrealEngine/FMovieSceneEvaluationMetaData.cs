using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002400 RID: 9216
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneEvaluationMetaData")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FMovieSceneEvaluationMetaData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602291B RID: 141595 RVA: 0x003320E6 File Offset: 0x003302E6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneEvaluationMetaData._ScriptStructPtr != 0) ? FMovieSceneEvaluationMetaData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneEvaluationMetaData", ref FMovieSceneEvaluationMetaData._ScriptStructPtr);
		}

		// Token: 0x17008514 RID: 34068
		// (get) Token: 0x0602291C RID: 141596 RVA: 0x0033210C File Offset: 0x0033030C
		// (set) Token: 0x0602291D RID: 141597 RVA: 0x0033214F File Offset: 0x0033034F
		public TArray<FMovieSceneSequenceID> ActiveSequences
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMovieSceneSequenceID> result;
				if ((result = this._ActiveSequences) == null)
				{
					result = (this._ActiveSequences = new TArray<FMovieSceneSequenceID>(base.NativePtr + (IntPtr)FMovieSceneEvaluationMetaData.__PropertyOffset_ActiveSequences, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ActiveSequences.CopyAssign(value);
			}
		}

		// Token: 0x17008515 RID: 34069
		// (get) Token: 0x0602291E RID: 141598 RVA: 0x00332160 File Offset: 0x00330360
		// (set) Token: 0x0602291F RID: 141599 RVA: 0x003321A3 File Offset: 0x003303A3
		public TArray<FMovieSceneOrderedEvaluationKey> ActiveEntities
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMovieSceneOrderedEvaluationKey> result;
				if ((result = this._ActiveEntities) == null)
				{
					result = (this._ActiveEntities = new TArray<FMovieSceneOrderedEvaluationKey>(base.NativePtr + (IntPtr)FMovieSceneEvaluationMetaData.__PropertyOffset_ActiveEntities, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ActiveEntities.CopyAssign(value);
			}
		}

		// Token: 0x06022920 RID: 141600 RVA: 0x003321B1 File Offset: 0x003303B1
		public FMovieSceneEvaluationMetaData()
		{
		}

		// Token: 0x06022921 RID: 141601 RVA: 0x003321B9 File Offset: 0x003303B9
		public FMovieSceneEvaluationMetaData(TArray<FMovieSceneSequenceID> ActiveSequences, TArray<FMovieSceneOrderedEvaluationKey> ActiveEntities)
		{
			this.ActiveSequences = ActiveSequences;
			this.ActiveEntities = ActiveEntities;
		}

		// Token: 0x06022922 RID: 141602 RVA: 0x003321CF File Offset: 0x003303CF
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneEvaluationMetaData.StaticStruct();
		}

		// Token: 0x06022923 RID: 141603 RVA: 0x003321DB File Offset: 0x003303DB
		[NullableContext(2)]
		public FMovieSceneEvaluationMetaData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022924 RID: 141604 RVA: 0x003321E5 File Offset: 0x003303E5
		public FMovieSceneEvaluationMetaData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022925 RID: 141605 RVA: 0x003321F0 File Offset: 0x003303F0
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneEvaluationMetaData(Pointer, false, true);
		}

		// Token: 0x06022926 RID: 141606 RVA: 0x003321FA File Offset: 0x003303FA
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneEvaluationMetaData(Pointer, MemoryOwner);
		}

		// Token: 0x04012796 RID: 75670
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneEvaluationMetaData";

		// Token: 0x04012797 RID: 75671
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012798 RID: 75672
		internal static int __PropertyOffset_ActiveSequences;

		// Token: 0x04012799 RID: 75673
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneSequenceID> _ActiveSequences;

		// Token: 0x0401279A RID: 75674
		internal static int __PropertyOffset_ActiveEntities;

		// Token: 0x0401279B RID: 75675
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneOrderedEvaluationKey> _ActiveEntities;
	}
}
