using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002456 RID: 9302
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneTrackInstanceEntry")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FMovieSceneTrackInstanceEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022DCC RID: 142796 RVA: 0x00338CFA File Offset: 0x00336EFA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneTrackInstanceEntry._ScriptStructPtr != 0) ? FMovieSceneTrackInstanceEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneTrackInstanceEntry", ref FMovieSceneTrackInstanceEntry._ScriptStructPtr);
		}

		// Token: 0x17008605 RID: 34309
		// (get) Token: 0x06022DCD RID: 142797 RVA: 0x00338D1E File Offset: 0x00336F1E
		// (set) Token: 0x06022DCE RID: 142798 RVA: 0x00338D32 File Offset: 0x00336F32
		public unsafe UObject BoundObject
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneTrackInstanceEntry.__PropertyOffset_BoundObject);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneTrackInstanceEntry.__PropertyOffset_BoundObject, value);
			}
		}

		// Token: 0x17008606 RID: 34310
		// (get) Token: 0x06022DCF RID: 142799 RVA: 0x00338D47 File Offset: 0x00336F47
		// (set) Token: 0x06022DD0 RID: 142800 RVA: 0x00338D5B File Offset: 0x00336F5B
		public unsafe UMovieSceneTrackInstance TrackInstance
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMovieSceneTrackInstance>(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneTrackInstanceEntry.__PropertyOffset_TrackInstance);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneTrackInstanceEntry.__PropertyOffset_TrackInstance, value);
			}
		}

		// Token: 0x06022DD1 RID: 142801 RVA: 0x00338D70 File Offset: 0x00336F70
		public FMovieSceneTrackInstanceEntry()
		{
		}

		// Token: 0x06022DD2 RID: 142802 RVA: 0x00338D78 File Offset: 0x00336F78
		[NullableContext(1)]
		public FMovieSceneTrackInstanceEntry(UObject BoundObject, UMovieSceneTrackInstance TrackInstance)
		{
			this.BoundObject = BoundObject;
			this.TrackInstance = TrackInstance;
		}

		// Token: 0x06022DD3 RID: 142803 RVA: 0x00338D8E File Offset: 0x00336F8E
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneTrackInstanceEntry.StaticStruct();
		}

		// Token: 0x06022DD4 RID: 142804 RVA: 0x00338D9A File Offset: 0x00336F9A
		public FMovieSceneTrackInstanceEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022DD5 RID: 142805 RVA: 0x00338DA4 File Offset: 0x00336FA4
		public FMovieSceneTrackInstanceEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022DD6 RID: 142806 RVA: 0x00338DAF File Offset: 0x00336FAF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneTrackInstanceEntry(Pointer, false, true);
		}

		// Token: 0x06022DD7 RID: 142807 RVA: 0x00338DB9 File Offset: 0x00336FB9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneTrackInstanceEntry(Pointer, MemoryOwner);
		}

		// Token: 0x040129D1 RID: 76241
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneTrackInstanceEntry";

		// Token: 0x040129D2 RID: 76242
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040129D3 RID: 76243
		internal static int __PropertyOffset_BoundObject;

		// Token: 0x040129D4 RID: 76244
		internal static int __PropertyOffset_TrackInstance;
	}
}
