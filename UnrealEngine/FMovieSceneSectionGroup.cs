using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200242A RID: 9258
	[UnrealObjectPath("/Script/MovieScene.MovieSceneSectionGroup")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FMovieSceneSectionGroup : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022B00 RID: 142080 RVA: 0x00334E2D File Offset: 0x0033302D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneSectionGroup._ScriptStructPtr != 0) ? FMovieSceneSectionGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneSectionGroup", ref FMovieSceneSectionGroup._ScriptStructPtr);
		}

		// Token: 0x17008575 RID: 34165
		// (get) Token: 0x06022B01 RID: 142081 RVA: 0x00334E54 File Offset: 0x00333054
		// (set) Token: 0x06022B02 RID: 142082 RVA: 0x00334E97 File Offset: 0x00333097
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TWeakObjectPtr<UMovieSceneSection>> Sections
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TWeakObjectPtr<UMovieSceneSection>> result;
				if ((result = this._Sections) == null)
				{
					result = (this._Sections = new TArray<TWeakObjectPtr<UMovieSceneSection>>(base.NativePtr + (IntPtr)FMovieSceneSectionGroup.__PropertyOffset_Sections, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.Sections.CopyAssign(value);
			}
		}

		// Token: 0x06022B03 RID: 142083 RVA: 0x00334EA5 File Offset: 0x003330A5
		public FMovieSceneSectionGroup()
		{
		}

		// Token: 0x06022B04 RID: 142084 RVA: 0x00334EAD File Offset: 0x003330AD
		public FMovieSceneSectionGroup([Nullable(new byte[]
		{
			1,
			0,
			1
		})] TArray<TWeakObjectPtr<UMovieSceneSection>> Sections)
		{
			this.Sections = Sections;
		}

		// Token: 0x06022B05 RID: 142085 RVA: 0x00334EBC File Offset: 0x003330BC
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneSectionGroup.StaticStruct();
		}

		// Token: 0x06022B06 RID: 142086 RVA: 0x00334EC8 File Offset: 0x003330C8
		[NullableContext(2)]
		public FMovieSceneSectionGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022B07 RID: 142087 RVA: 0x00334ED2 File Offset: 0x003330D2
		public FMovieSceneSectionGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022B08 RID: 142088 RVA: 0x00334EDD File Offset: 0x003330DD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneSectionGroup(Pointer, false, true);
		}

		// Token: 0x06022B09 RID: 142089 RVA: 0x00334EE7 File Offset: 0x003330E7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneSectionGroup(Pointer, MemoryOwner);
		}

		// Token: 0x0401288A RID: 75914
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneSectionGroup";

		// Token: 0x0401288B RID: 75915
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401288C RID: 75916
		internal static int __PropertyOffset_Sections;

		// Token: 0x0401288D RID: 75917
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<UMovieSceneSection>> _Sections;
	}
}
