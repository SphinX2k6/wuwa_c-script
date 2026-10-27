using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020022FD RID: 8957
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MoviePlayer.MoviePlayerSettings")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UMoviePlayerSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021F1E RID: 139038 RVA: 0x00323385 File Offset: 0x00321585
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMoviePlayerSettings._ClassPtr;
		}

		// Token: 0x06021F1F RID: 139039 RVA: 0x00323394 File Offset: 0x00321594
		public UMoviePlayerSettings() : this(BuiltinUtils.AllocNativeUObject(UMoviePlayerSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021F20 RID: 139040 RVA: 0x003233BC File Offset: 0x003215BC
		public UMoviePlayerSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMoviePlayerSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008337 RID: 33591
		// (get) Token: 0x06021F21 RID: 139041 RVA: 0x003233EF File Offset: 0x003215EF
		// (set) Token: 0x06021F22 RID: 139042 RVA: 0x003233FF File Offset: 0x003215FF
		public unsafe bool bWaitForMoviesToComplete
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMoviePlayerSettings.__PropertyOffset_bWaitForMoviesToComplete) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMoviePlayerSettings.__PropertyOffset_bWaitForMoviesToComplete) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008338 RID: 33592
		// (get) Token: 0x06021F23 RID: 139043 RVA: 0x00323410 File Offset: 0x00321610
		// (set) Token: 0x06021F24 RID: 139044 RVA: 0x00323420 File Offset: 0x00321620
		public unsafe bool bMoviesAreSkippable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMoviePlayerSettings.__PropertyOffset_bMoviesAreSkippable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMoviePlayerSettings.__PropertyOffset_bMoviesAreSkippable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008339 RID: 33593
		// (get) Token: 0x06021F25 RID: 139045 RVA: 0x00323434 File Offset: 0x00321634
		// (set) Token: 0x06021F26 RID: 139046 RVA: 0x0032346D File Offset: 0x0032166D
		public TArray<string> StartupMovies
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._StartupMovies) == null)
				{
					result = (this._StartupMovies = new TArray<string>(base.NativePtr + (IntPtr)UMoviePlayerSettings.__PropertyOffset_StartupMovies, this));
				}
				return result;
			}
			set
			{
				this.StartupMovies.CopyAssign(value);
			}
		}

		// Token: 0x06021F27 RID: 139047 RVA: 0x0032347B File Offset: 0x0032167B
		static UMoviePlayerSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MoviePlayer.MoviePlayerSettings");
		}

		// Token: 0x06021F28 RID: 139048 RVA: 0x00323489 File Offset: 0x00321689
		protected UMoviePlayerSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040121B0 RID: 74160
		public new const string __ObjectPath = "/Script/MoviePlayer.MoviePlayerSettings";

		// Token: 0x040121B1 RID: 74161
		private static IntPtr _ClassPtr;

		// Token: 0x040121B2 RID: 74162
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040121B3 RID: 74163
		internal static int __PropertyOffset_bWaitForMoviesToComplete;

		// Token: 0x040121B4 RID: 74164
		internal static int __PropertyOffset_bMoviesAreSkippable;

		// Token: 0x040121B5 RID: 74165
		internal static int __PropertyOffset_StartupMovies;

		// Token: 0x040121B6 RID: 74166
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _StartupMovies;
	}
}
