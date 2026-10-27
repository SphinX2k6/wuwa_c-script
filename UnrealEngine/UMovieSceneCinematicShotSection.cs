using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002358 RID: 9048
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneCinematicShotSection")]
	[UnrealStructLayout(496, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 496)]
	public class UMovieSceneCinematicShotSection : UMovieSceneSubSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060222FB RID: 140027 RVA: 0x00328D36 File Offset: 0x00326F36
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneCinematicShotSection._ClassPtr;
		}

		// Token: 0x060222FC RID: 140028 RVA: 0x00328D44 File Offset: 0x00326F44
		public UMovieSceneCinematicShotSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneCinematicShotSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060222FD RID: 140029 RVA: 0x00328D6C File Offset: 0x00326F6C
		public UMovieSceneCinematicShotSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneCinematicShotSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008404 RID: 33796
		// (get) Token: 0x060222FE RID: 140030 RVA: 0x00328D9F File Offset: 0x00326F9F
		// (set) Token: 0x060222FF RID: 140031 RVA: 0x00328DB3 File Offset: 0x00326FB3
		public unsafe string ShotDisplayName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UMovieSceneCinematicShotSection.__PropertyOffset_ShotDisplayName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UMovieSceneCinematicShotSection.__PropertyOffset_ShotDisplayName)), value);
			}
		}

		// Token: 0x17008405 RID: 33797
		// (get) Token: 0x06022300 RID: 140032 RVA: 0x00328DC8 File Offset: 0x00326FC8
		// (set) Token: 0x06022301 RID: 140033 RVA: 0x00328E01 File Offset: 0x00327001
		public unsafe FText DisplayName_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._DisplayName_DEPRECATED) == null)
				{
					result = (this._DisplayName_DEPRECATED = new FText(base.NativePtr + (IntPtr)UMovieSceneCinematicShotSection.__PropertyOffset_DisplayName_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)UMovieSceneCinematicShotSection.__PropertyOffset_DisplayName_DEPRECATED)), value.NativePtr, 1);
			}
		}

		// Token: 0x06022302 RID: 140034 RVA: 0x00328E1C File Offset: 0x0032701C
		public unsafe void SetShotDisplayName(string InShotDisplayName)
		{
			FString fstring = FString.AllocTemp(InShotDisplayName);
			UMovieSceneCinematicShotSection.__SetShotDisplayName_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06022303 RID: 140035 RVA: 0x00328E46 File Offset: 0x00327046
		public string GetShotDisplayName()
		{
			return FString.ToStringAndDeleteNativePtr(UMovieSceneCinematicShotSection.__GetShotDisplayName_Internal(base.NativePtr));
		}

		// Token: 0x06022304 RID: 140036
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShotDisplayName_Internal(IntPtr @this, in FString InShotDisplayName);

		// Token: 0x06022305 RID: 140037
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetShotDisplayName_Internal(IntPtr @this);

		// Token: 0x06022306 RID: 140038 RVA: 0x00328E58 File Offset: 0x00327058
		static UMovieSceneCinematicShotSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneCinematicShotSection");
		}

		// Token: 0x06022307 RID: 140039 RVA: 0x00328E66 File Offset: 0x00327066
		protected UMovieSceneCinematicShotSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040123F8 RID: 74744
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneCinematicShotSection";

		// Token: 0x040123F9 RID: 74745
		private static IntPtr _ClassPtr;

		// Token: 0x040123FA RID: 74746
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040123FB RID: 74747
		internal static int __PropertyOffset_ShotDisplayName;

		// Token: 0x040123FC RID: 74748
		internal static int __PropertyOffset_DisplayName_DEPRECATED;

		// Token: 0x040123FD RID: 74749
		[Nullable(2)]
		private FText _DisplayName_DEPRECATED;
	}
}
