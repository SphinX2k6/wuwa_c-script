using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002457 RID: 9303
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneTrackInstanceInput")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FMovieSceneTrackInstanceInput : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022DD8 RID: 142808 RVA: 0x00338DC2 File Offset: 0x00336FC2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneTrackInstanceInput._ScriptStructPtr != 0) ? FMovieSceneTrackInstanceInput._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneTrackInstanceInput", ref FMovieSceneTrackInstanceInput._ScriptStructPtr);
		}

		// Token: 0x17008607 RID: 34311
		// (get) Token: 0x06022DD9 RID: 142809 RVA: 0x00338DE6 File Offset: 0x00336FE6
		// (set) Token: 0x06022DDA RID: 142810 RVA: 0x00338DFA File Offset: 0x00336FFA
		[Nullable(2)]
		public unsafe UMovieSceneSection Section
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMovieSceneSection>(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneTrackInstanceInput.__PropertyOffset_Section);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneTrackInstanceInput.__PropertyOffset_Section, value);
			}
		}

		// Token: 0x06022DDB RID: 142811 RVA: 0x00338E0F File Offset: 0x0033700F
		public FMovieSceneTrackInstanceInput()
		{
		}

		// Token: 0x06022DDC RID: 142812 RVA: 0x00338E17 File Offset: 0x00337017
		[NullableContext(1)]
		public FMovieSceneTrackInstanceInput(UMovieSceneSection Section)
		{
			this.Section = Section;
		}

		// Token: 0x06022DDD RID: 142813 RVA: 0x00338E26 File Offset: 0x00337026
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneTrackInstanceInput.StaticStruct();
		}

		// Token: 0x06022DDE RID: 142814 RVA: 0x00338E32 File Offset: 0x00337032
		[NullableContext(2)]
		public FMovieSceneTrackInstanceInput(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022DDF RID: 142815 RVA: 0x00338E3C File Offset: 0x0033703C
		public FMovieSceneTrackInstanceInput(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022DE0 RID: 142816 RVA: 0x00338E47 File Offset: 0x00337047
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneTrackInstanceInput(Pointer, false, true);
		}

		// Token: 0x06022DE1 RID: 142817 RVA: 0x00338E51 File Offset: 0x00337051
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneTrackInstanceInput(Pointer, MemoryOwner);
		}

		// Token: 0x040129D5 RID: 76245
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneTrackInstanceInput";

		// Token: 0x040129D6 RID: 76246
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040129D7 RID: 76247
		internal static int __PropertyOffset_Section;
	}
}
