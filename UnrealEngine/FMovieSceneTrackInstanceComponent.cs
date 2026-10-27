using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002455 RID: 9301
	[UnrealObjectPath("/Script/MovieScene.MovieSceneTrackInstanceComponent")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FMovieSceneTrackInstanceComponent : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022DC0 RID: 142784 RVA: 0x00338C32 File Offset: 0x00336E32
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneTrackInstanceComponent._ScriptStructPtr != 0) ? FMovieSceneTrackInstanceComponent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneTrackInstanceComponent", ref FMovieSceneTrackInstanceComponent._ScriptStructPtr);
		}

		// Token: 0x17008603 RID: 34307
		// (get) Token: 0x06022DC1 RID: 142785 RVA: 0x00338C56 File Offset: 0x00336E56
		// (set) Token: 0x06022DC2 RID: 142786 RVA: 0x00338C6A File Offset: 0x00336E6A
		[Nullable(2)]
		public unsafe UMovieSceneSection Owner
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMovieSceneSection>(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneTrackInstanceComponent.__PropertyOffset_Owner);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneTrackInstanceComponent.__PropertyOffset_Owner, value);
			}
		}

		// Token: 0x17008604 RID: 34308
		// (get) Token: 0x06022DC3 RID: 142787 RVA: 0x00338C7F File Offset: 0x00336E7F
		// (set) Token: 0x06022DC4 RID: 142788 RVA: 0x00338C93 File Offset: 0x00336E93
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UMovieSceneTrackInstance> TrackInstanceClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneTrackInstanceComponent.__PropertyOffset_TrackInstanceClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneTrackInstanceComponent.__PropertyOffset_TrackInstanceClass) = value;
			}
		}

		// Token: 0x06022DC5 RID: 142789 RVA: 0x00338CA8 File Offset: 0x00336EA8
		public FMovieSceneTrackInstanceComponent()
		{
		}

		// Token: 0x06022DC6 RID: 142790 RVA: 0x00338CB0 File Offset: 0x00336EB0
		[NullableContext(1)]
		public FMovieSceneTrackInstanceComponent(UMovieSceneSection Owner, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UMovieSceneTrackInstance> TrackInstanceClass)
		{
			this.Owner = Owner;
			this.TrackInstanceClass = TrackInstanceClass;
		}

		// Token: 0x06022DC7 RID: 142791 RVA: 0x00338CC6 File Offset: 0x00336EC6
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneTrackInstanceComponent.StaticStruct();
		}

		// Token: 0x06022DC8 RID: 142792 RVA: 0x00338CD2 File Offset: 0x00336ED2
		[NullableContext(2)]
		public FMovieSceneTrackInstanceComponent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022DC9 RID: 142793 RVA: 0x00338CDC File Offset: 0x00336EDC
		public FMovieSceneTrackInstanceComponent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022DCA RID: 142794 RVA: 0x00338CE7 File Offset: 0x00336EE7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneTrackInstanceComponent(Pointer, false, true);
		}

		// Token: 0x06022DCB RID: 142795 RVA: 0x00338CF1 File Offset: 0x00336EF1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneTrackInstanceComponent(Pointer, MemoryOwner);
		}

		// Token: 0x040129CD RID: 76237
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneTrackInstanceComponent";

		// Token: 0x040129CE RID: 76238
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040129CF RID: 76239
		internal static int __PropertyOffset_Owner;

		// Token: 0x040129D0 RID: 76240
		internal static int __PropertyOffset_TrackInstanceClass;
	}
}
