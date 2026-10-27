using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002340 RID: 9024
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneBoolPropertySectionTemplate")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 208)]
	public class FMovieSceneBoolPropertySectionTemplate : FMovieScenePropertySectionTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060221F0 RID: 139760 RVA: 0x0032737E File Offset: 0x0032557E
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneBoolPropertySectionTemplate._ScriptStructPtr != 0) ? FMovieSceneBoolPropertySectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneBoolPropertySectionTemplate", ref FMovieSceneBoolPropertySectionTemplate._ScriptStructPtr);
		}

		// Token: 0x170083CE RID: 33742
		// (get) Token: 0x060221F1 RID: 139761 RVA: 0x003273A4 File Offset: 0x003255A4
		// (set) Token: 0x060221F2 RID: 139762 RVA: 0x003273E7 File Offset: 0x003255E7
		public FMovieSceneBoolChannel BoolCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneBoolChannel result;
				if ((result = this._BoolCurve) == null)
				{
					result = (this._BoolCurve = new FMovieSceneBoolChannel(base.NativePtr + (IntPtr)FMovieSceneBoolPropertySectionTemplate.__PropertyOffset_BoolCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneBoolChannel.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneBoolPropertySectionTemplate.__PropertyOffset_BoolCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060221F3 RID: 139763 RVA: 0x00327408 File Offset: 0x00325608
		public FMovieSceneBoolPropertySectionTemplate()
		{
		}

		// Token: 0x060221F4 RID: 139764 RVA: 0x00327410 File Offset: 0x00325610
		public FMovieSceneBoolPropertySectionTemplate(FMovieSceneBoolChannel BoolCurve, FMovieScenePropertySectionData PropertyData, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.BoolCurve = BoolCurve;
			base.PropertyData = PropertyData;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x060221F5 RID: 139765 RVA: 0x00327435 File Offset: 0x00325635
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneBoolPropertySectionTemplate.StaticStruct();
		}

		// Token: 0x060221F6 RID: 139766 RVA: 0x00327441 File Offset: 0x00325641
		[NullableContext(2)]
		public FMovieSceneBoolPropertySectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060221F7 RID: 139767 RVA: 0x0032744B File Offset: 0x0032564B
		public FMovieSceneBoolPropertySectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060221F8 RID: 139768 RVA: 0x00327456 File Offset: 0x00325656
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneBoolPropertySectionTemplate(Pointer, false, true);
		}

		// Token: 0x060221F9 RID: 139769 RVA: 0x00327460 File Offset: 0x00325660
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneBoolPropertySectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x04012363 RID: 74595
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneBoolPropertySectionTemplate";

		// Token: 0x04012364 RID: 74596
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012365 RID: 74597
		internal static int __PropertyOffset_BoolCurve;

		// Token: 0x04012366 RID: 74598
		[Nullable(2)]
		private FMovieSceneBoolChannel _BoolCurve;
	}
}
