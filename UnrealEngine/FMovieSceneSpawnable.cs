using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200243D RID: 9277
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneSpawnable")]
	[UnrealStructLayout(160, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FMovieSceneSpawnable : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022C8C RID: 142476 RVA: 0x00336E5F File Offset: 0x0033505F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneSpawnable._ScriptStructPtr != 0) ? FMovieSceneSpawnable._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneSpawnable", ref FMovieSceneSpawnable._ScriptStructPtr);
		}

		// Token: 0x170085BE RID: 34238
		// (get) Token: 0x06022C8D RID: 142477 RVA: 0x00336E83 File Offset: 0x00335083
		// (set) Token: 0x06022C8E RID: 142478 RVA: 0x00336E97 File Offset: 0x00335097
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

		// Token: 0x170085BF RID: 34239
		// (get) Token: 0x06022C8F RID: 142479 RVA: 0x00336EAC File Offset: 0x003350AC
		// (set) Token: 0x06022C90 RID: 142480 RVA: 0x00336EEF File Offset: 0x003350EF
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

		// Token: 0x170085C0 RID: 34240
		// (get) Token: 0x06022C91 RID: 142481 RVA: 0x00336EFD File Offset: 0x003350FD
		// (set) Token: 0x06022C92 RID: 142482 RVA: 0x00336F0D File Offset: 0x0033510D
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

		// Token: 0x170085C1 RID: 34241
		// (get) Token: 0x06022C93 RID: 142483 RVA: 0x00336F1E File Offset: 0x0033511E
		// (set) Token: 0x06022C94 RID: 142484 RVA: 0x00336F2E File Offset: 0x0033512E
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

		// Token: 0x170085C2 RID: 34242
		// (get) Token: 0x06022C95 RID: 142485 RVA: 0x00336F3F File Offset: 0x0033513F
		// (set) Token: 0x06022C96 RID: 142486 RVA: 0x00336F53 File Offset: 0x00335153
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

		// Token: 0x170085C3 RID: 34243
		// (get) Token: 0x06022C97 RID: 142487 RVA: 0x00336F68 File Offset: 0x00335168
		// (set) Token: 0x06022C98 RID: 142488 RVA: 0x00336F7C File Offset: 0x0033517C
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

		// Token: 0x170085C4 RID: 34244
		// (get) Token: 0x06022C99 RID: 142489 RVA: 0x00336F91 File Offset: 0x00335191
		// (set) Token: 0x06022C9A RID: 142490 RVA: 0x00336FA5 File Offset: 0x003351A5
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

		// Token: 0x170085C5 RID: 34245
		// (get) Token: 0x06022C9B RID: 142491 RVA: 0x00336FBC File Offset: 0x003351BC
		// (set) Token: 0x06022C9C RID: 142492 RVA: 0x00336FFF File Offset: 0x003351FF
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

		// Token: 0x170085C6 RID: 34246
		// (get) Token: 0x06022C9D RID: 142493 RVA: 0x0033700D File Offset: 0x0033520D
		// (set) Token: 0x06022C9E RID: 142494 RVA: 0x0033701D File Offset: 0x0033521D
		public unsafe ESpawnOwnership Ownership
		{
			get
			{
				return (ESpawnOwnership)(*(base.NativePtr + (IntPtr)FMovieSceneSpawnable.__PropertyOffset_Ownership));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSpawnable.__PropertyOffset_Ownership) = (byte)value;
			}
		}

		// Token: 0x170085C7 RID: 34247
		// (get) Token: 0x06022C9F RID: 142495 RVA: 0x0033702E File Offset: 0x0033522E
		// (set) Token: 0x06022CA0 RID: 142496 RVA: 0x00337042 File Offset: 0x00335242
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

		// Token: 0x06022CA1 RID: 142497 RVA: 0x00337057 File Offset: 0x00335257
		public FMovieSceneSpawnable()
		{
		}

		// Token: 0x06022CA2 RID: 142498 RVA: 0x00337060 File Offset: 0x00335260
		public FMovieSceneSpawnable(FTransform SpawnTransform, TArray<FName> Tags, bool bContinuouslyRespawn, bool bEvaluateTracksWhenNotSpawned, FGuid Guid, string Name, UObject ObjectTemplate, TArray<FGuid> ChildPossessables, ESpawnOwnership Ownership, UClassStackOnlyPtr GeneratedClass_DEPRECATED, FName LevelName)
		{
			this.SpawnTransform = SpawnTransform;
			this.Tags = Tags;
			this.bContinuouslyRespawn = bContinuouslyRespawn;
			this.bEvaluateTracksWhenNotSpawned = bEvaluateTracksWhenNotSpawned;
			this.Guid = Guid;
			this.Name = Name;
			this.ObjectTemplate = ObjectTemplate;
			this.ChildPossessables = ChildPossessables;
			this.Ownership = Ownership;
			this.LevelName = LevelName;
		}

		// Token: 0x06022CA3 RID: 142499 RVA: 0x003370C0 File Offset: 0x003352C0
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneSpawnable.StaticStruct();
		}

		// Token: 0x06022CA4 RID: 142500 RVA: 0x003370CC File Offset: 0x003352CC
		[NullableContext(2)]
		public FMovieSceneSpawnable(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022CA5 RID: 142501 RVA: 0x003370D6 File Offset: 0x003352D6
		public FMovieSceneSpawnable(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022CA6 RID: 142502 RVA: 0x003370E1 File Offset: 0x003352E1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneSpawnable(Pointer, false, true);
		}

		// Token: 0x06022CA7 RID: 142503 RVA: 0x003370EB File Offset: 0x003352EB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneSpawnable(Pointer, MemoryOwner);
		}

		// Token: 0x04012927 RID: 76071
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneSpawnable";

		// Token: 0x04012928 RID: 76072
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012929 RID: 76073
		internal static int __PropertyOffset_SpawnTransform;

		// Token: 0x0401292A RID: 76074
		internal static int __PropertyOffset_Tags;

		// Token: 0x0401292B RID: 76075
		[Nullable(2)]
		private TArray<FName> _Tags;

		// Token: 0x0401292C RID: 76076
		internal static int __PropertyOffset_bContinuouslyRespawn;

		// Token: 0x0401292D RID: 76077
		internal static int __PropertyOffset_bEvaluateTracksWhenNotSpawned;

		// Token: 0x0401292E RID: 76078
		internal static int __PropertyOffset_Guid;

		// Token: 0x0401292F RID: 76079
		internal static int __PropertyOffset_Name;

		// Token: 0x04012930 RID: 76080
		internal static int __PropertyOffset_ObjectTemplate;

		// Token: 0x04012931 RID: 76081
		internal static int __PropertyOffset_ChildPossessables;

		// Token: 0x04012932 RID: 76082
		[Nullable(2)]
		private TArray<FGuid> _ChildPossessables;

		// Token: 0x04012933 RID: 76083
		internal static int __PropertyOffset_Ownership;

		// Token: 0x04012934 RID: 76084
		internal static int __PropertyOffset_LevelName;
	}
}
