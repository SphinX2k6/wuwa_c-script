using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002403 RID: 9219
	[UnrealObjectPath("/Script/MovieScene.MovieSceneEvaluationTemplateSerialNumber")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FMovieSceneEvaluationTemplateSerialNumber : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022943 RID: 141635 RVA: 0x003324D1 File Offset: 0x003306D1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneEvaluationTemplateSerialNumber._ScriptStructPtr != 0) ? FMovieSceneEvaluationTemplateSerialNumber._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneEvaluationTemplateSerialNumber", ref FMovieSceneEvaluationTemplateSerialNumber._ScriptStructPtr);
		}

		// Token: 0x1700851C RID: 34076
		// (get) Token: 0x06022944 RID: 141636 RVA: 0x003324F5 File Offset: 0x003306F5
		// (set) Token: 0x06022945 RID: 141637 RVA: 0x00332505 File Offset: 0x00330705
		public unsafe uint Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneEvaluationTemplateSerialNumber.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneEvaluationTemplateSerialNumber.__PropertyOffset_Value) = (int)value;
			}
		}

		// Token: 0x06022946 RID: 141638 RVA: 0x00332516 File Offset: 0x00330716
		public FMovieSceneEvaluationTemplateSerialNumber()
		{
		}

		// Token: 0x06022947 RID: 141639 RVA: 0x0033251E File Offset: 0x0033071E
		public FMovieSceneEvaluationTemplateSerialNumber(uint Value)
		{
			this.Value = Value;
		}

		// Token: 0x06022948 RID: 141640 RVA: 0x0033252D File Offset: 0x0033072D
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneEvaluationTemplateSerialNumber.StaticStruct();
		}

		// Token: 0x06022949 RID: 141641 RVA: 0x00332539 File Offset: 0x00330739
		[NullableContext(2)]
		public FMovieSceneEvaluationTemplateSerialNumber(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602294A RID: 141642 RVA: 0x00332543 File Offset: 0x00330743
		public FMovieSceneEvaluationTemplateSerialNumber(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602294B RID: 141643 RVA: 0x0033254E File Offset: 0x0033074E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneEvaluationTemplateSerialNumber(Pointer, false, true);
		}

		// Token: 0x0602294C RID: 141644 RVA: 0x00332558 File Offset: 0x00330758
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneEvaluationTemplateSerialNumber(Pointer, MemoryOwner);
		}

		// Token: 0x040127AA RID: 75690
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneEvaluationTemplateSerialNumber";

		// Token: 0x040127AB RID: 75691
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040127AC RID: 75692
		internal static int __PropertyOffset_Value;
	}
}
