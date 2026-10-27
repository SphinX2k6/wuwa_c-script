using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020023F5 RID: 9205
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneEvaluationField")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FMovieSceneEvaluationField : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022896 RID: 141462 RVA: 0x00331562 File Offset: 0x0032F762
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneEvaluationField._ScriptStructPtr != 0) ? FMovieSceneEvaluationField._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneEvaluationField", ref FMovieSceneEvaluationField._ScriptStructPtr);
		}

		// Token: 0x170084FD RID: 34045
		// (get) Token: 0x06022897 RID: 141463 RVA: 0x00331588 File Offset: 0x0032F788
		// (set) Token: 0x06022898 RID: 141464 RVA: 0x003315CB File Offset: 0x0032F7CB
		public TArray<FMovieSceneFrameRange> Ranges
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMovieSceneFrameRange> result;
				if ((result = this._Ranges) == null)
				{
					result = (this._Ranges = new TArray<FMovieSceneFrameRange>(base.NativePtr + (IntPtr)FMovieSceneEvaluationField.__PropertyOffset_Ranges, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Ranges.CopyAssign(value);
			}
		}

		// Token: 0x170084FE RID: 34046
		// (get) Token: 0x06022899 RID: 141465 RVA: 0x003315DC File Offset: 0x0032F7DC
		// (set) Token: 0x0602289A RID: 141466 RVA: 0x0033161F File Offset: 0x0032F81F
		public TArray<FMovieSceneEvaluationGroup> Groups
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMovieSceneEvaluationGroup> result;
				if ((result = this._Groups) == null)
				{
					result = (this._Groups = new TArray<FMovieSceneEvaluationGroup>(base.NativePtr + (IntPtr)FMovieSceneEvaluationField.__PropertyOffset_Groups, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Groups.CopyAssign(value);
			}
		}

		// Token: 0x170084FF RID: 34047
		// (get) Token: 0x0602289B RID: 141467 RVA: 0x00331630 File Offset: 0x0032F830
		// (set) Token: 0x0602289C RID: 141468 RVA: 0x00331673 File Offset: 0x0032F873
		public TArray<FMovieSceneEvaluationMetaData> MetaData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMovieSceneEvaluationMetaData> result;
				if ((result = this._MetaData) == null)
				{
					result = (this._MetaData = new TArray<FMovieSceneEvaluationMetaData>(base.NativePtr + (IntPtr)FMovieSceneEvaluationField.__PropertyOffset_MetaData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MetaData.CopyAssign(value);
			}
		}

		// Token: 0x0602289D RID: 141469 RVA: 0x00331681 File Offset: 0x0032F881
		public FMovieSceneEvaluationField()
		{
		}

		// Token: 0x0602289E RID: 141470 RVA: 0x00331689 File Offset: 0x0032F889
		public FMovieSceneEvaluationField(FGuid Signature, TArray<FMovieSceneFrameRange> Ranges, TArray<FMovieSceneEvaluationGroup> Groups, TArray<FMovieSceneEvaluationMetaData> MetaData)
		{
			this.Ranges = Ranges;
			this.Groups = Groups;
			this.MetaData = MetaData;
		}

		// Token: 0x0602289F RID: 141471 RVA: 0x003316A7 File Offset: 0x0032F8A7
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneEvaluationField.StaticStruct();
		}

		// Token: 0x060228A0 RID: 141472 RVA: 0x003316B3 File Offset: 0x0032F8B3
		[NullableContext(2)]
		public FMovieSceneEvaluationField(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060228A1 RID: 141473 RVA: 0x003316BD File Offset: 0x0032F8BD
		public FMovieSceneEvaluationField(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060228A2 RID: 141474 RVA: 0x003316C8 File Offset: 0x0032F8C8
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneEvaluationField(Pointer, false, true);
		}

		// Token: 0x060228A3 RID: 141475 RVA: 0x003316D2 File Offset: 0x0032F8D2
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneEvaluationField(Pointer, MemoryOwner);
		}

		// Token: 0x0401275A RID: 75610
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneEvaluationField";

		// Token: 0x0401275B RID: 75611
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401275C RID: 75612
		internal static int __PropertyOffset_Ranges;

		// Token: 0x0401275D RID: 75613
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneFrameRange> _Ranges;

		// Token: 0x0401275E RID: 75614
		internal static int __PropertyOffset_Groups;

		// Token: 0x0401275F RID: 75615
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneEvaluationGroup> _Groups;

		// Token: 0x04012760 RID: 75616
		internal static int __PropertyOffset_MetaData;

		// Token: 0x04012761 RID: 75617
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneEvaluationMetaData> _MetaData;
	}
}
