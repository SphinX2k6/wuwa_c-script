using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200238E RID: 9102
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneObjectPropertyTemplate")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 264)]
	public class FMovieSceneObjectPropertyTemplate : FMovieScenePropertySectionTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060224D5 RID: 140501 RVA: 0x0032BA41 File Offset: 0x00329C41
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneObjectPropertyTemplate._ScriptStructPtr != 0) ? FMovieSceneObjectPropertyTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneObjectPropertyTemplate", ref FMovieSceneObjectPropertyTemplate._ScriptStructPtr);
		}

		// Token: 0x17008442 RID: 33858
		// (get) Token: 0x060224D6 RID: 140502 RVA: 0x0032BA68 File Offset: 0x00329C68
		// (set) Token: 0x060224D7 RID: 140503 RVA: 0x0032BAAB File Offset: 0x00329CAB
		public FMovieSceneObjectPathChannel ObjectChannel
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneObjectPathChannel result;
				if ((result = this._ObjectChannel) == null)
				{
					result = (this._ObjectChannel = new FMovieSceneObjectPathChannel(base.NativePtr + (IntPtr)FMovieSceneObjectPropertyTemplate.__PropertyOffset_ObjectChannel, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneObjectPathChannel.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneObjectPropertyTemplate.__PropertyOffset_ObjectChannel, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060224D8 RID: 140504 RVA: 0x0032BACC File Offset: 0x00329CCC
		public FMovieSceneObjectPropertyTemplate()
		{
		}

		// Token: 0x060224D9 RID: 140505 RVA: 0x0032BAD4 File Offset: 0x00329CD4
		public FMovieSceneObjectPropertyTemplate(FMovieSceneObjectPathChannel ObjectChannel, FMovieScenePropertySectionData PropertyData, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.ObjectChannel = ObjectChannel;
			base.PropertyData = PropertyData;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x060224DA RID: 140506 RVA: 0x0032BAF9 File Offset: 0x00329CF9
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneObjectPropertyTemplate.StaticStruct();
		}

		// Token: 0x060224DB RID: 140507 RVA: 0x0032BB05 File Offset: 0x00329D05
		[NullableContext(2)]
		public FMovieSceneObjectPropertyTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060224DC RID: 140508 RVA: 0x0032BB0F File Offset: 0x00329D0F
		public FMovieSceneObjectPropertyTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060224DD RID: 140509 RVA: 0x0032BB1A File Offset: 0x00329D1A
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneObjectPropertyTemplate(Pointer, false, true);
		}

		// Token: 0x060224DE RID: 140510 RVA: 0x0032BB24 File Offset: 0x00329D24
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneObjectPropertyTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x040124FD RID: 75005
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneObjectPropertyTemplate";

		// Token: 0x040124FE RID: 75006
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040124FF RID: 75007
		internal static int __PropertyOffset_ObjectChannel;

		// Token: 0x04012500 RID: 75008
		[Nullable(2)]
		private FMovieSceneObjectPathChannel _ObjectChannel;
	}
}
