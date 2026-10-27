using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023AE RID: 9134
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneStringPropertySectionTemplate")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 224)]
	public class FMovieSceneStringPropertySectionTemplate : FMovieScenePropertySectionTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022657 RID: 140887 RVA: 0x0032DF48 File Offset: 0x0032C148
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneStringPropertySectionTemplate._ScriptStructPtr != 0) ? FMovieSceneStringPropertySectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneStringPropertySectionTemplate", ref FMovieSceneStringPropertySectionTemplate._ScriptStructPtr);
		}

		// Token: 0x17008491 RID: 33937
		// (get) Token: 0x06022658 RID: 140888 RVA: 0x0032DF6C File Offset: 0x0032C16C
		// (set) Token: 0x06022659 RID: 140889 RVA: 0x0032DFAF File Offset: 0x0032C1AF
		public FMovieSceneStringChannel StringCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneStringChannel result;
				if ((result = this._StringCurve) == null)
				{
					result = (this._StringCurve = new FMovieSceneStringChannel(base.NativePtr + (IntPtr)FMovieSceneStringPropertySectionTemplate.__PropertyOffset_StringCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneStringChannel.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneStringPropertySectionTemplate.__PropertyOffset_StringCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602265A RID: 140890 RVA: 0x0032DFD0 File Offset: 0x0032C1D0
		public FMovieSceneStringPropertySectionTemplate()
		{
		}

		// Token: 0x0602265B RID: 140891 RVA: 0x0032DFD8 File Offset: 0x0032C1D8
		public FMovieSceneStringPropertySectionTemplate(FMovieSceneStringChannel StringCurve, FMovieScenePropertySectionData PropertyData, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.StringCurve = StringCurve;
			base.PropertyData = PropertyData;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x0602265C RID: 140892 RVA: 0x0032DFFD File Offset: 0x0032C1FD
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneStringPropertySectionTemplate.StaticStruct();
		}

		// Token: 0x0602265D RID: 140893 RVA: 0x0032E009 File Offset: 0x0032C209
		[NullableContext(2)]
		public FMovieSceneStringPropertySectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602265E RID: 140894 RVA: 0x0032E013 File Offset: 0x0032C213
		public FMovieSceneStringPropertySectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602265F RID: 140895 RVA: 0x0032E01E File Offset: 0x0032C21E
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneStringPropertySectionTemplate(Pointer, false, true);
		}

		// Token: 0x06022660 RID: 140896 RVA: 0x0032E028 File Offset: 0x0032C228
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneStringPropertySectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x040125CE RID: 75214
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneStringPropertySectionTemplate";

		// Token: 0x040125CF RID: 75215
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040125D0 RID: 75216
		internal static int __PropertyOffset_StringCurve;

		// Token: 0x040125D1 RID: 75217
		[Nullable(2)]
		private FMovieSceneStringChannel _StringCurve;
	}
}
