using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200186E RID: 6254
	[UnrealObjectPath("/Script/KuroGamepadFeedbackSequenceRuntime.KuroMovieSceneGamepadForceFeedbackTemplate")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FKuroMovieSceneGamepadForceFeedbackTemplate : FMovieSceneEvalTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060170A0 RID: 94368 RVA: 0x00219378 File Offset: 0x00217578
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMovieSceneGamepadForceFeedbackTemplate._ScriptStructPtr != 0) ? FKuroMovieSceneGamepadForceFeedbackTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGamepadFeedbackSequenceRuntime.KuroMovieSceneGamepadForceFeedbackTemplate", ref FKuroMovieSceneGamepadForceFeedbackTemplate._ScriptStructPtr);
		}

		// Token: 0x17005CAB RID: 23723
		// (get) Token: 0x060170A1 RID: 94369 RVA: 0x0021939C File Offset: 0x0021759C
		// (set) Token: 0x060170A2 RID: 94370 RVA: 0x002193B0 File Offset: 0x002175B0
		[Nullable(2)]
		public unsafe UKuroMovieSceneGamepadForceFeedbackSection Section
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMovieSceneGamepadForceFeedbackSection>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMovieSceneGamepadForceFeedbackTemplate.__PropertyOffset_Section);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMovieSceneGamepadForceFeedbackTemplate.__PropertyOffset_Section, value);
			}
		}

		// Token: 0x060170A3 RID: 94371 RVA: 0x002193C5 File Offset: 0x002175C5
		public FKuroMovieSceneGamepadForceFeedbackTemplate()
		{
		}

		// Token: 0x060170A4 RID: 94372 RVA: 0x002193CD File Offset: 0x002175CD
		[NullableContext(1)]
		public FKuroMovieSceneGamepadForceFeedbackTemplate(UKuroMovieSceneGamepadForceFeedbackSection Section, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.Section = Section;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x060170A5 RID: 94373 RVA: 0x002193EA File Offset: 0x002175EA
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMovieSceneGamepadForceFeedbackTemplate.StaticStruct();
		}

		// Token: 0x060170A6 RID: 94374 RVA: 0x002193F6 File Offset: 0x002175F6
		[NullableContext(2)]
		public FKuroMovieSceneGamepadForceFeedbackTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060170A7 RID: 94375 RVA: 0x00219400 File Offset: 0x00217600
		public FKuroMovieSceneGamepadForceFeedbackTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060170A8 RID: 94376 RVA: 0x0021940B File Offset: 0x0021760B
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMovieSceneGamepadForceFeedbackTemplate(Pointer, false, true);
		}

		// Token: 0x060170A9 RID: 94377 RVA: 0x00219415 File Offset: 0x00217615
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMovieSceneGamepadForceFeedbackTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x0400C80A RID: 51210
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGamepadFeedbackSequenceRuntime.KuroMovieSceneGamepadForceFeedbackTemplate";

		// Token: 0x0400C80B RID: 51211
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C80C RID: 51212
		internal static int __PropertyOffset_Section;
	}
}
