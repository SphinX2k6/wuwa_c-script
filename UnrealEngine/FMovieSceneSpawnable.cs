using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200078E RID: 1934
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneSpawnable")]
	[UnrealStructLayout(160, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FMovieSceneSpawnable : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A734 RID: 42804 RVA: 0x000F6CBB File Offset: 0x000F4EBB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneSpawnable._ScriptStructPtr != 0) ? FMovieSceneSpawnable._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneSpawnable", ref FMovieSceneSpawnable._ScriptStructPtr);
		}

		// Token: 0x17001F0E RID: 7950
		// (get) Token: 0x0600A735 RID: 42805 RVA: 0x000F6CDF File Offset: 0x000F4EDF
		// (set) Token: 0x0600A736 RID: 42806 RVA: 0x000F6CF3 File Offset: 0x000F4EF3
		public unsafe FTransform SpawnTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSpawnable.__PropertyOffset_SpawnTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSpawnable.__PropertyOffset_SpawnTransform) = value;
			}
		}

		// Token: 0x17001F0F RID: 7951
		// (get) Token: 0x0600A737 RID: 42807 RVA: 0x000F6D08 File Offset: 0x000F4F08
		// (set) Token: 0x0600A738 RID: 42808 RVA: 0x000F6D4B File Offset: 0x000F4F4B
		public TArray<FName> Tags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._Tags) == null)
				{
					result = (this._Tags = new TArray<FName>(base.NativePtr + (IntPtr)FMovieSceneSpawnable.__PropertyOffset_Tags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Tags.CopyAssign(value);
			}
		}

		// Token: 0x17001F10 RID: 7952
		// (get) Token: 0x0600A739 RID: 42809 RVA: 0x000F6D59 File Offset: 0x000F4F59
		// (set) Token: 0x0600A73A RID: 42810 RVA: 0x000F6D69 File Offset: 0x000F4F69
		public unsafe bool bContinuouslyRespawn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSpawnable.__PropertyOffset_bContinuouslyRespawn) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSpawnable.__PropertyOffset_bContinuouslyRespawn) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001F11 RID: 7953
		// (get) Token: 0x0600A73B RID: 42811 RVA: 0x000F6D7A File Offset: 0x000F4F7A
		// (set) Token: 0x0600A73C RID: 42812 RVA: 0x000F6D8A File Offset: 0x000F4F8A
		public unsafe bool bEvaluateTracksWhenNotSpawned
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSpawnable.__PropertyOffset_bEvaluateTracksWhenNotSpawned) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSpawnable.__PropertyOffset_bEvaluateTracksWhenNotSpawned) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001F12 RID: 7954
		// (get) Token: 0x0600A73D RID: 42813 RVA: 0x000F6D9B File Offset: 0x000F4F9B
		// (set) Token: 0x0600A73E RID: 42814 RVA: 0x000F6DAF File Offset: 0x000F4FAF
		public unsafe FGuid Guid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSpawnable.__PropertyOffset_Guid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSpawnable.__PropertyOffset_Guid) = value;
			}
		}

		// Token: 0x17001F13 RID: 7955
		// (get) Token: 0x0600A73F RID: 42815 RVA: 0x000F6DC4 File Offset: 0x000F4FC4
		// (set) Token: 0x0600A740 RID: 42816 RVA: 0x000F6DD8 File Offset: 0x000F4FD8
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FMovieSceneSpawnable.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FMovieSceneSpawnable.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x17001F14 RID: 7956
		// (get) Token: 0x0600A741 RID: 42817 RVA: 0x000F6DED File Offset: 0x000F4FED
		// (set) Token: 0x0600A742 RID: 42818 RVA: 0x000F6E01 File Offset: 0x000F5001
		[Nullable(2)]
		public unsafe UObject ObjectTemplate
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneSpawnable.__PropertyOffset_ObjectTemplate);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneSpawnable.__PropertyOffset_ObjectTemplate, value);
			}
		}

		// Token: 0x17001F15 RID: 7957
		// (get) Token: 0x0600A743 RID: 42819 RVA: 0x000F6E18 File Offset: 0x000F5018
		// (set) Token: 0x0600A744 RID: 42820 RVA: 0x000F6E5B File Offset: 0x000F505B
		public TArray<FGuid> ChildPossessables
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGuid> result;
				if ((result = this._ChildPossessables) == null)
				{
					result = (this._ChildPossessables = new TArray<FGuid>(base.NativePtr + (IntPtr)FMovieSceneSpawnable.__PropertyOffset_ChildPossessables, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ChildPossessables.CopyAssign(value);
			}
		}

		// Token: 0x17001F16 RID: 7958
		// (get) Token: 0x0600A745 RID: 42821 RVA: 0x000F6E69 File Offset: 0x000F5069
		// (set) Token: 0x0600A746 RID: 42822 RVA: 0x000F6E7D File Offset: 0x000F507D
		public unsafe FName LevelName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSpawnable.__PropertyOffset_LevelName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSpawnable.__PropertyOffset_LevelName) = value;
			}
		}

		// Token: 0x0600A747 RID: 42823 RVA: 0x000F6E92 File Offset: 0x000F5092
		public FMovieSceneSpawnable()
		{
		}

		// Token: 0x0600A748 RID: 42824 RVA: 0x000F6E9A File Offset: 0x000F509A
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneSpawnable.StaticStruct();
		}

		// Token: 0x0600A749 RID: 42825 RVA: 0x000F6EA6 File Offset: 0x000F50A6
		[NullableContext(2)]
		public FMovieSceneSpawnable(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A74A RID: 42826 RVA: 0x000F6EB0 File Offset: 0x000F50B0
		public FMovieSceneSpawnable(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A74B RID: 42827 RVA: 0x000F6EBB File Offset: 0x000F50BB
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneSpawnable(Pointer, false, true);
		}

		// Token: 0x0600A74C RID: 42828 RVA: 0x000F6EC5 File Offset: 0x000F50C5
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneSpawnable(Pointer, MemoryOwner);
		}

		// Token: 0x04004797 RID: 18327
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneSpawnable";

		// Token: 0x04004798 RID: 18328
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004799 RID: 18329
		internal static int __PropertyOffset_SpawnTransform;

		// Token: 0x0400479A RID: 18330
		internal static int __PropertyOffset_Tags;

		// Token: 0x0400479B RID: 18331
		[Nullable(2)]
		private TArray<FName> _Tags;

		// Token: 0x0400479C RID: 18332
		internal static int __PropertyOffset_bContinuouslyRespawn;

		// Token: 0x0400479D RID: 18333
		internal static int __PropertyOffset_bEvaluateTracksWhenNotSpawned;

		// Token: 0x0400479E RID: 18334
		internal static int __PropertyOffset_Guid;

		// Token: 0x0400479F RID: 18335
		internal static int __PropertyOffset_Name;

		// Token: 0x040047A0 RID: 18336
		internal static int __PropertyOffset_ObjectTemplate;

		// Token: 0x040047A1 RID: 18337
		internal static int __PropertyOffset_ChildPossessables;

		// Token: 0x040047A2 RID: 18338
		[Nullable(2)]
		private TArray<FGuid> _ChildPossessables;

		// Token: 0x040047A3 RID: 18339
		internal static int __PropertyOffset_LevelName;
	}
}
