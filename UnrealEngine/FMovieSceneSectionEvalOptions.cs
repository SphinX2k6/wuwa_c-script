using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002429 RID: 9257
	[UnrealObjectPath("/Script/MovieScene.MovieSceneSectionEvalOptions")]
	[UnrealStructLayout(2, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2)]
	public class FMovieSceneSectionEvalOptions : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022AF4 RID: 142068 RVA: 0x00334D75 File Offset: 0x00332F75
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneSectionEvalOptions._ScriptStructPtr != 0) ? FMovieSceneSectionEvalOptions._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneSectionEvalOptions", ref FMovieSceneSectionEvalOptions._ScriptStructPtr);
		}

		// Token: 0x17008573 RID: 34163
		// (get) Token: 0x06022AF5 RID: 142069 RVA: 0x00334D99 File Offset: 0x00332F99
		// (set) Token: 0x06022AF6 RID: 142070 RVA: 0x00334DA9 File Offset: 0x00332FA9
		public unsafe bool bCanEditCompletionMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSectionEvalOptions.__PropertyOffset_bCanEditCompletionMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSectionEvalOptions.__PropertyOffset_bCanEditCompletionMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008574 RID: 34164
		// (get) Token: 0x06022AF7 RID: 142071 RVA: 0x00334DBA File Offset: 0x00332FBA
		// (set) Token: 0x06022AF8 RID: 142072 RVA: 0x00334DCA File Offset: 0x00332FCA
		public unsafe EMovieSceneCompletionMode CompletionMode
		{
			get
			{
				return (EMovieSceneCompletionMode)(*(base.NativePtr + (IntPtr)FMovieSceneSectionEvalOptions.__PropertyOffset_CompletionMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSectionEvalOptions.__PropertyOffset_CompletionMode) = (byte)value;
			}
		}

		// Token: 0x06022AF9 RID: 142073 RVA: 0x00334DDB File Offset: 0x00332FDB
		public FMovieSceneSectionEvalOptions()
		{
		}

		// Token: 0x06022AFA RID: 142074 RVA: 0x00334DE3 File Offset: 0x00332FE3
		public FMovieSceneSectionEvalOptions(bool bCanEditCompletionMode, EMovieSceneCompletionMode CompletionMode)
		{
			this.bCanEditCompletionMode = bCanEditCompletionMode;
			this.CompletionMode = CompletionMode;
		}

		// Token: 0x06022AFB RID: 142075 RVA: 0x00334DF9 File Offset: 0x00332FF9
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneSectionEvalOptions.StaticStruct();
		}

		// Token: 0x06022AFC RID: 142076 RVA: 0x00334E05 File Offset: 0x00333005
		[NullableContext(2)]
		public FMovieSceneSectionEvalOptions(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022AFD RID: 142077 RVA: 0x00334E0F File Offset: 0x0033300F
		public FMovieSceneSectionEvalOptions(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022AFE RID: 142078 RVA: 0x00334E1A File Offset: 0x0033301A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneSectionEvalOptions(Pointer, false, true);
		}

		// Token: 0x06022AFF RID: 142079 RVA: 0x00334E24 File Offset: 0x00333024
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneSectionEvalOptions(Pointer, MemoryOwner);
		}

		// Token: 0x04012886 RID: 75910
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneSectionEvalOptions";

		// Token: 0x04012887 RID: 75911
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012888 RID: 75912
		internal static int __PropertyOffset_bCanEditCompletionMode;

		// Token: 0x04012889 RID: 75913
		internal static int __PropertyOffset_CompletionMode;
	}
}
