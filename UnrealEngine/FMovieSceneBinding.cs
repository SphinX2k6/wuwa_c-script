using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020023D4 RID: 9172
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneBinding")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FMovieSceneBinding : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602274F RID: 141135 RVA: 0x0032F5B8 File Offset: 0x0032D7B8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneBinding._ScriptStructPtr != 0) ? FMovieSceneBinding._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneBinding", ref FMovieSceneBinding._ScriptStructPtr);
		}

		// Token: 0x170084BB RID: 33979
		// (get) Token: 0x06022750 RID: 141136 RVA: 0x0032F5DC File Offset: 0x0032D7DC
		// (set) Token: 0x06022751 RID: 141137 RVA: 0x0032F5F0 File Offset: 0x0032D7F0
		public unsafe FGuid ObjectGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneBinding.__PropertyOffset_ObjectGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneBinding.__PropertyOffset_ObjectGuid) = value;
			}
		}

		// Token: 0x170084BC RID: 33980
		// (get) Token: 0x06022752 RID: 141138 RVA: 0x0032F605 File Offset: 0x0032D805
		// (set) Token: 0x06022753 RID: 141139 RVA: 0x0032F619 File Offset: 0x0032D819
		public unsafe string BindingName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FMovieSceneBinding.__PropertyOffset_BindingName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FMovieSceneBinding.__PropertyOffset_BindingName)), value);
			}
		}

		// Token: 0x170084BD RID: 33981
		// (get) Token: 0x06022754 RID: 141140 RVA: 0x0032F630 File Offset: 0x0032D830
		// (set) Token: 0x06022755 RID: 141141 RVA: 0x0032F673 File Offset: 0x0032D873
		public TArray<UMovieSceneTrack> Tracks
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMovieSceneTrack> result;
				if ((result = this._Tracks) == null)
				{
					result = (this._Tracks = new TArray<UMovieSceneTrack>(base.NativePtr + (IntPtr)FMovieSceneBinding.__PropertyOffset_Tracks, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Tracks.CopyAssign(value);
			}
		}

		// Token: 0x06022756 RID: 141142 RVA: 0x0032F681 File Offset: 0x0032D881
		public FMovieSceneBinding()
		{
		}

		// Token: 0x06022757 RID: 141143 RVA: 0x0032F689 File Offset: 0x0032D889
		public FMovieSceneBinding(FGuid ObjectGuid, string BindingName, TArray<UMovieSceneTrack> Tracks, int SortingOrder)
		{
			this.ObjectGuid = ObjectGuid;
			this.BindingName = BindingName;
			this.Tracks = Tracks;
		}

		// Token: 0x06022758 RID: 141144 RVA: 0x0032F6A6 File Offset: 0x0032D8A6
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneBinding.StaticStruct();
		}

		// Token: 0x06022759 RID: 141145 RVA: 0x0032F6B2 File Offset: 0x0032D8B2
		[NullableContext(2)]
		public FMovieSceneBinding(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602275A RID: 141146 RVA: 0x0032F6BC File Offset: 0x0032D8BC
		public FMovieSceneBinding(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602275B RID: 141147 RVA: 0x0032F6C7 File Offset: 0x0032D8C7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneBinding(Pointer, false, true);
		}

		// Token: 0x0602275C RID: 141148 RVA: 0x0032F6D1 File Offset: 0x0032D8D1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneBinding(Pointer, MemoryOwner);
		}

		// Token: 0x040126AC RID: 75436
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneBinding";

		// Token: 0x040126AD RID: 75437
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040126AE RID: 75438
		internal static int __PropertyOffset_ObjectGuid;

		// Token: 0x040126AF RID: 75439
		internal static int __PropertyOffset_BindingName;

		// Token: 0x040126B0 RID: 75440
		internal static int __PropertyOffset_Tracks;

		// Token: 0x040126B1 RID: 75441
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneTrack> _Tracks;
	}
}
