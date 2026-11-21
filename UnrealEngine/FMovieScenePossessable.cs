using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000785 RID: 1925
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieScenePossessable")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FMovieScenePossessable : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A5FD RID: 42493 RVA: 0x000F51AD File Offset: 0x000F33AD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieScenePossessable._ScriptStructPtr != 0) ? FMovieScenePossessable._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieScenePossessable", ref FMovieScenePossessable._ScriptStructPtr);
		}

		// Token: 0x17001ECF RID: 7887
		// (get) Token: 0x0600A5FE RID: 42494 RVA: 0x000F51D4 File Offset: 0x000F33D4
		// (set) Token: 0x0600A5FF RID: 42495 RVA: 0x000F5217 File Offset: 0x000F3417
		public TArray<FName> Tags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._Tags) == null)
				{
					result = (this._Tags = new TArray<FName>(base.NativePtr + (IntPtr)FMovieScenePossessable.__PropertyOffset_Tags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Tags.CopyAssign(value);
			}
		}

		// Token: 0x17001ED0 RID: 7888
		// (get) Token: 0x0600A600 RID: 42496 RVA: 0x000F5225 File Offset: 0x000F3425
		// (set) Token: 0x0600A601 RID: 42497 RVA: 0x000F5239 File Offset: 0x000F3439
		public unsafe FGuid Guid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieScenePossessable.__PropertyOffset_Guid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieScenePossessable.__PropertyOffset_Guid) = value;
			}
		}

		// Token: 0x17001ED1 RID: 7889
		// (get) Token: 0x0600A602 RID: 42498 RVA: 0x000F524E File Offset: 0x000F344E
		// (set) Token: 0x0600A603 RID: 42499 RVA: 0x000F5262 File Offset: 0x000F3462
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FMovieScenePossessable.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FMovieScenePossessable.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x17001ED2 RID: 7890
		// (get) Token: 0x0600A604 RID: 42500 RVA: 0x000F5277 File Offset: 0x000F3477
		// (set) Token: 0x0600A605 RID: 42501 RVA: 0x000F528B File Offset: 0x000F348B
		public unsafe FGuid ParentGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieScenePossessable.__PropertyOffset_ParentGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieScenePossessable.__PropertyOffset_ParentGuid) = value;
			}
		}

		// Token: 0x0600A606 RID: 42502 RVA: 0x000F52A0 File Offset: 0x000F34A0
		public FMovieScenePossessable()
		{
		}

		// Token: 0x0600A607 RID: 42503 RVA: 0x000F52A8 File Offset: 0x000F34A8
		protected override IntPtr GetUStructPtr()
		{
			return FMovieScenePossessable.StaticStruct();
		}

		// Token: 0x0600A608 RID: 42504 RVA: 0x000F52B4 File Offset: 0x000F34B4
		[NullableContext(2)]
		public FMovieScenePossessable(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A609 RID: 42505 RVA: 0x000F52BE File Offset: 0x000F34BE
		public FMovieScenePossessable(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A60A RID: 42506 RVA: 0x000F52C9 File Offset: 0x000F34C9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieScenePossessable(Pointer, false, true);
		}

		// Token: 0x0600A60B RID: 42507 RVA: 0x000F52D3 File Offset: 0x000F34D3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieScenePossessable(Pointer, MemoryOwner);
		}

		// Token: 0x04004714 RID: 18196
		public const string __ObjectPath = "/Script/MovieScene.MovieScenePossessable";

		// Token: 0x04004715 RID: 18197
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004716 RID: 18198
		internal static int __PropertyOffset_Tags;

		// Token: 0x04004717 RID: 18199
		[Nullable(2)]
		private TArray<FName> _Tags;

		// Token: 0x04004718 RID: 18200
		internal static int __PropertyOffset_Guid;

		// Token: 0x04004719 RID: 18201
		internal static int __PropertyOffset_Name;

		// Token: 0x0400471A RID: 18202
		internal static int __PropertyOffset_ParentGuid;
	}
}
