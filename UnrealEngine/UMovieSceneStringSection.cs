using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023AF RID: 9135
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneStringSection")]
	[UnrealStructLayout(464, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class UMovieSceneStringSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022661 RID: 140897 RVA: 0x0032E031 File Offset: 0x0032C231
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneStringSection._ClassPtr;
		}

		// Token: 0x06022662 RID: 140898 RVA: 0x0032E040 File Offset: 0x0032C240
		public UMovieSceneStringSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneStringSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022663 RID: 140899 RVA: 0x0032E068 File Offset: 0x0032C268
		public UMovieSceneStringSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneStringSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008492 RID: 33938
		// (get) Token: 0x06022664 RID: 140900 RVA: 0x0032E09C File Offset: 0x0032C29C
		// (set) Token: 0x06022665 RID: 140901 RVA: 0x0032E0D5 File Offset: 0x0032C2D5
		public FMovieSceneStringChannel StringCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneStringChannel result;
				if ((result = this._StringCurve) == null)
				{
					result = (this._StringCurve = new FMovieSceneStringChannel(base.NativePtr + (IntPtr)UMovieSceneStringSection.__PropertyOffset_StringCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneStringChannel.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneStringSection.__PropertyOffset_StringCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06022666 RID: 140902 RVA: 0x0032E0F6 File Offset: 0x0032C2F6
		static UMovieSceneStringSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneStringSection");
		}

		// Token: 0x06022667 RID: 140903 RVA: 0x0032E104 File Offset: 0x0032C304
		protected UMovieSceneStringSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040125D2 RID: 75218
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneStringSection";

		// Token: 0x040125D3 RID: 75219
		private static IntPtr _ClassPtr;

		// Token: 0x040125D4 RID: 75220
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040125D5 RID: 75221
		internal static int __PropertyOffset_StringCurve;

		// Token: 0x040125D6 RID: 75222
		[Nullable(2)]
		private FMovieSceneStringChannel _StringCurve;
	}
}
