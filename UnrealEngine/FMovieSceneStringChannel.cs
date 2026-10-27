using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020023AD RID: 9133
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneStringChannel")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FMovieSceneStringChannel : FMovieSceneChannel, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022647 RID: 140871 RVA: 0x0032DDD2 File Offset: 0x0032BFD2
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneStringChannel._ScriptStructPtr != 0) ? FMovieSceneStringChannel._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneStringChannel", ref FMovieSceneStringChannel._ScriptStructPtr);
		}

		// Token: 0x1700848D RID: 33933
		// (get) Token: 0x06022648 RID: 140872 RVA: 0x0032DDF8 File Offset: 0x0032BFF8
		// (set) Token: 0x06022649 RID: 140873 RVA: 0x0032DE3B File Offset: 0x0032C03B
		public TArray<FFrameNumber> Times
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FFrameNumber> result;
				if ((result = this._Times) == null)
				{
					result = (this._Times = new TArray<FFrameNumber>(base.NativePtr + (IntPtr)FMovieSceneStringChannel.__PropertyOffset_Times, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Times.CopyAssign(value);
			}
		}

		// Token: 0x1700848E RID: 33934
		// (get) Token: 0x0602264A RID: 140874 RVA: 0x0032DE4C File Offset: 0x0032C04C
		// (set) Token: 0x0602264B RID: 140875 RVA: 0x0032DE8F File Offset: 0x0032C08F
		public TArray<string> Values
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Values) == null)
				{
					result = (this._Values = new TArray<string>(base.NativePtr + (IntPtr)FMovieSceneStringChannel.__PropertyOffset_Values, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Values.CopyAssign(value);
			}
		}

		// Token: 0x1700848F RID: 33935
		// (get) Token: 0x0602264C RID: 140876 RVA: 0x0032DE9D File Offset: 0x0032C09D
		// (set) Token: 0x0602264D RID: 140877 RVA: 0x0032DEB1 File Offset: 0x0032C0B1
		public unsafe string DefaultValue
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FMovieSceneStringChannel.__PropertyOffset_DefaultValue)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FMovieSceneStringChannel.__PropertyOffset_DefaultValue)), value);
			}
		}

		// Token: 0x17008490 RID: 33936
		// (get) Token: 0x0602264E RID: 140878 RVA: 0x0032DEC6 File Offset: 0x0032C0C6
		// (set) Token: 0x0602264F RID: 140879 RVA: 0x0032DED6 File Offset: 0x0032C0D6
		public unsafe bool bHasDefaultValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneStringChannel.__PropertyOffset_bHasDefaultValue) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneStringChannel.__PropertyOffset_bHasDefaultValue) = (value ? 1 : 0);
			}
		}

		// Token: 0x06022650 RID: 140880 RVA: 0x0032DEE7 File Offset: 0x0032C0E7
		public FMovieSceneStringChannel()
		{
		}

		// Token: 0x06022651 RID: 140881 RVA: 0x0032DEEF File Offset: 0x0032C0EF
		public FMovieSceneStringChannel(TArray<FFrameNumber> Times, TArray<string> Values, string DefaultValue, bool bHasDefaultValue)
		{
			this.Times = Times;
			this.Values = Values;
			this.DefaultValue = DefaultValue;
			this.bHasDefaultValue = bHasDefaultValue;
		}

		// Token: 0x06022652 RID: 140882 RVA: 0x0032DF14 File Offset: 0x0032C114
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneStringChannel.StaticStruct();
		}

		// Token: 0x06022653 RID: 140883 RVA: 0x0032DF20 File Offset: 0x0032C120
		[NullableContext(2)]
		public FMovieSceneStringChannel(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022654 RID: 140884 RVA: 0x0032DF2A File Offset: 0x0032C12A
		public FMovieSceneStringChannel(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022655 RID: 140885 RVA: 0x0032DF35 File Offset: 0x0032C135
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneStringChannel(Pointer, false, true);
		}

		// Token: 0x06022656 RID: 140886 RVA: 0x0032DF3F File Offset: 0x0032C13F
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneStringChannel(Pointer, MemoryOwner);
		}

		// Token: 0x040125C6 RID: 75206
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneStringChannel";

		// Token: 0x040125C7 RID: 75207
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040125C8 RID: 75208
		internal static int __PropertyOffset_Times;

		// Token: 0x040125C9 RID: 75209
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FFrameNumber> _Times;

		// Token: 0x040125CA RID: 75210
		internal static int __PropertyOffset_Values;

		// Token: 0x040125CB RID: 75211
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Values;

		// Token: 0x040125CC RID: 75212
		internal static int __PropertyOffset_DefaultValue;

		// Token: 0x040125CD RID: 75213
		internal static int __PropertyOffset_bHasDefaultValue;
	}
}
