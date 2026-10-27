using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023F6 RID: 9206
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneEvaluationFieldEntity")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FMovieSceneEvaluationFieldEntity : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060228A4 RID: 141476 RVA: 0x003316DB File Offset: 0x0032F8DB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneEvaluationFieldEntity._ScriptStructPtr != 0) ? FMovieSceneEvaluationFieldEntity._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneEvaluationFieldEntity", ref FMovieSceneEvaluationFieldEntity._ScriptStructPtr);
		}

		// Token: 0x17008500 RID: 34048
		// (get) Token: 0x060228A5 RID: 141477 RVA: 0x00331700 File Offset: 0x0032F900
		// (set) Token: 0x060228A6 RID: 141478 RVA: 0x00331743 File Offset: 0x0032F943
		public FMovieSceneEvaluationFieldEntityKey Key
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneEvaluationFieldEntityKey result;
				if ((result = this._Key) == null)
				{
					result = (this._Key = new FMovieSceneEvaluationFieldEntityKey(base.NativePtr + (IntPtr)FMovieSceneEvaluationFieldEntity.__PropertyOffset_Key, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneEvaluationFieldEntityKey.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneEvaluationFieldEntity.__PropertyOffset_Key, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008501 RID: 34049
		// (get) Token: 0x060228A7 RID: 141479 RVA: 0x00331764 File Offset: 0x0032F964
		// (set) Token: 0x060228A8 RID: 141480 RVA: 0x00331774 File Offset: 0x0032F974
		public unsafe int SharedMetaDataIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneEvaluationFieldEntity.__PropertyOffset_SharedMetaDataIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneEvaluationFieldEntity.__PropertyOffset_SharedMetaDataIndex) = value;
			}
		}

		// Token: 0x060228A9 RID: 141481 RVA: 0x00331785 File Offset: 0x0032F985
		public FMovieSceneEvaluationFieldEntity()
		{
		}

		// Token: 0x060228AA RID: 141482 RVA: 0x0033178D File Offset: 0x0032F98D
		public FMovieSceneEvaluationFieldEntity(FMovieSceneEvaluationFieldEntityKey Key, int SharedMetaDataIndex)
		{
			this.Key = Key;
			this.SharedMetaDataIndex = SharedMetaDataIndex;
		}

		// Token: 0x060228AB RID: 141483 RVA: 0x003317A3 File Offset: 0x0032F9A3
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneEvaluationFieldEntity.StaticStruct();
		}

		// Token: 0x060228AC RID: 141484 RVA: 0x003317AF File Offset: 0x0032F9AF
		[NullableContext(2)]
		public FMovieSceneEvaluationFieldEntity(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060228AD RID: 141485 RVA: 0x003317B9 File Offset: 0x0032F9B9
		public FMovieSceneEvaluationFieldEntity(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060228AE RID: 141486 RVA: 0x003317C4 File Offset: 0x0032F9C4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneEvaluationFieldEntity(Pointer, false, true);
		}

		// Token: 0x060228AF RID: 141487 RVA: 0x003317CE File Offset: 0x0032F9CE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneEvaluationFieldEntity(Pointer, MemoryOwner);
		}

		// Token: 0x04012762 RID: 75618
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneEvaluationFieldEntity";

		// Token: 0x04012763 RID: 75619
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012764 RID: 75620
		internal static int __PropertyOffset_Key;

		// Token: 0x04012765 RID: 75621
		[Nullable(2)]
		private FMovieSceneEvaluationFieldEntityKey _Key;

		// Token: 0x04012766 RID: 75622
		internal static int __PropertyOffset_SharedMetaDataIndex;
	}
}
