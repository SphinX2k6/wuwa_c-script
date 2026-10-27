using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020026F0 RID: 9968
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneQteAnimExtraParams")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FMovieSceneQteAnimExtraParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024F7F RID: 151423 RVA: 0x0036AFCB File Offset: 0x003691CB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneQteAnimExtraParams._ScriptStructPtr != 0) ? FMovieSceneQteAnimExtraParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SequenceDialogue.MovieSceneQteAnimExtraParams", ref FMovieSceneQteAnimExtraParams._ScriptStructPtr);
		}

		// Token: 0x17008EBE RID: 36542
		// (get) Token: 0x06024F80 RID: 151424 RVA: 0x0036AFEF File Offset: 0x003691EF
		// (set) Token: 0x06024F81 RID: 151425 RVA: 0x0036AFFF File Offset: 0x003691FF
		public unsafe bool bReverseProgressAnimWhenRegress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneQteAnimExtraParams.__PropertyOffset_bReverseProgressAnimWhenRegress) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneQteAnimExtraParams.__PropertyOffset_bReverseProgressAnimWhenRegress) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008EBF RID: 36543
		// (get) Token: 0x06024F82 RID: 151426 RVA: 0x0036B010 File Offset: 0x00369210
		// (set) Token: 0x06024F83 RID: 151427 RVA: 0x0036B024 File Offset: 0x00369224
		public unsafe UAnimSequence ProgressAnim
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimSequence>(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneQteAnimExtraParams.__PropertyOffset_ProgressAnim);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneQteAnimExtraParams.__PropertyOffset_ProgressAnim, value);
			}
		}

		// Token: 0x17008EC0 RID: 36544
		// (get) Token: 0x06024F84 RID: 151428 RVA: 0x0036B039 File Offset: 0x00369239
		// (set) Token: 0x06024F85 RID: 151429 RVA: 0x0036B04D File Offset: 0x0036924D
		public unsafe UAnimSequence RegressAnim
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimSequence>(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneQteAnimExtraParams.__PropertyOffset_RegressAnim);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneQteAnimExtraParams.__PropertyOffset_RegressAnim, value);
			}
		}

		// Token: 0x17008EC1 RID: 36545
		// (get) Token: 0x06024F86 RID: 151430 RVA: 0x0036B062 File Offset: 0x00369262
		// (set) Token: 0x06024F87 RID: 151431 RVA: 0x0036B076 File Offset: 0x00369276
		public unsafe UCurveFloat ProgressMapCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneQteAnimExtraParams.__PropertyOffset_ProgressMapCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneQteAnimExtraParams.__PropertyOffset_ProgressMapCurve, value);
			}
		}

		// Token: 0x17008EC2 RID: 36546
		// (get) Token: 0x06024F88 RID: 151432 RVA: 0x0036B08B File Offset: 0x0036928B
		// (set) Token: 0x06024F89 RID: 151433 RVA: 0x0036B09B File Offset: 0x0036929B
		public unsafe float BlendTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneQteAnimExtraParams.__PropertyOffset_BlendTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneQteAnimExtraParams.__PropertyOffset_BlendTime) = value;
			}
		}

		// Token: 0x06024F8A RID: 151434 RVA: 0x0036B0AC File Offset: 0x003692AC
		public FMovieSceneQteAnimExtraParams()
		{
		}

		// Token: 0x06024F8B RID: 151435 RVA: 0x0036B0B4 File Offset: 0x003692B4
		[NullableContext(1)]
		public FMovieSceneQteAnimExtraParams(bool bReverseProgressAnimWhenRegress, UAnimSequence ProgressAnim, UAnimSequence RegressAnim, UCurveFloat ProgressMapCurve, float BlendTime)
		{
			this.bReverseProgressAnimWhenRegress = bReverseProgressAnimWhenRegress;
			this.ProgressAnim = ProgressAnim;
			this.RegressAnim = RegressAnim;
			this.ProgressMapCurve = ProgressMapCurve;
			this.BlendTime = BlendTime;
		}

		// Token: 0x06024F8C RID: 151436 RVA: 0x0036B0E1 File Offset: 0x003692E1
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneQteAnimExtraParams.StaticStruct();
		}

		// Token: 0x06024F8D RID: 151437 RVA: 0x0036B0ED File Offset: 0x003692ED
		public FMovieSceneQteAnimExtraParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024F8E RID: 151438 RVA: 0x0036B0F7 File Offset: 0x003692F7
		public FMovieSceneQteAnimExtraParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024F8F RID: 151439 RVA: 0x0036B102 File Offset: 0x00369302
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneQteAnimExtraParams(Pointer, false, true);
		}

		// Token: 0x06024F90 RID: 151440 RVA: 0x0036B10C File Offset: 0x0036930C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneQteAnimExtraParams(Pointer, MemoryOwner);
		}

		// Token: 0x04013EC3 RID: 81603
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneQteAnimExtraParams";

		// Token: 0x04013EC4 RID: 81604
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013EC5 RID: 81605
		internal static int __PropertyOffset_bReverseProgressAnimWhenRegress;

		// Token: 0x04013EC6 RID: 81606
		internal static int __PropertyOffset_ProgressAnim;

		// Token: 0x04013EC7 RID: 81607
		internal static int __PropertyOffset_RegressAnim;

		// Token: 0x04013EC8 RID: 81608
		internal static int __PropertyOffset_ProgressMapCurve;

		// Token: 0x04013EC9 RID: 81609
		internal static int __PropertyOffset_BlendTime;
	}
}
