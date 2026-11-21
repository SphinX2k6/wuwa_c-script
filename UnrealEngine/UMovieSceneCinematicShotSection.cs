using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000762 RID: 1890
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneCinematicShotSection")]
	[UnrealStructLayout(512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 512)]
	public class UMovieSceneCinematicShotSection : UMovieSceneSubSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A472 RID: 42098 RVA: 0x000F2E42 File Offset: 0x000F1042
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneCinematicShotSection._ClassPtr;
		}

		// Token: 0x0600A473 RID: 42099 RVA: 0x000F2E50 File Offset: 0x000F1050
		public UMovieSceneCinematicShotSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneCinematicShotSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A474 RID: 42100 RVA: 0x000F2E78 File Offset: 0x000F1078
		public UMovieSceneCinematicShotSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneCinematicShotSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001E68 RID: 7784
		// (get) Token: 0x0600A475 RID: 42101 RVA: 0x000F2EAB File Offset: 0x000F10AB
		// (set) Token: 0x0600A476 RID: 42102 RVA: 0x000F2EBF File Offset: 0x000F10BF
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

		// Token: 0x17001E69 RID: 7785
		// (get) Token: 0x0600A477 RID: 42103 RVA: 0x000F2ED4 File Offset: 0x000F10D4
		// (set) Token: 0x0600A478 RID: 42104 RVA: 0x000F2F0D File Offset: 0x000F110D
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

		// Token: 0x0600A479 RID: 42105 RVA: 0x000F2F28 File Offset: 0x000F1128
		public unsafe void SetShotDisplayName(string InShotDisplayName)
		{
			FString fstring = FString.AllocTemp(InShotDisplayName);
			UMovieSceneCinematicShotSection.__SetShotDisplayName_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600A47A RID: 42106 RVA: 0x000F2F52 File Offset: 0x000F1152
		public string GetShotDisplayName()
		{
			return FString.ToStringAndDeleteNativePtr(UMovieSceneCinematicShotSection.__GetShotDisplayName_Internal(base.NativePtr));
		}

		// Token: 0x0600A47B RID: 42107
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShotDisplayName_Internal(IntPtr @this, in FString InShotDisplayName);

		// Token: 0x0600A47C RID: 42108
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetShotDisplayName_Internal(IntPtr @this);

		// Token: 0x0600A47D RID: 42109 RVA: 0x000F2F64 File Offset: 0x000F1164
		static UMovieSceneCinematicShotSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneCinematicShotSection");
		}

		// Token: 0x0600A47E RID: 42110 RVA: 0x000F2F72 File Offset: 0x000F1172
		protected UMovieSceneCinematicShotSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004622 RID: 17954
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneCinematicShotSection";

		// Token: 0x04004623 RID: 17955
		private static IntPtr _ClassPtr;

		// Token: 0x04004624 RID: 17956
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004625 RID: 17957
		internal static int __PropertyOffset_ShotDisplayName;

		// Token: 0x04004626 RID: 17958
		internal static int __PropertyOffset_DisplayName_DEPRECATED;

		// Token: 0x04004627 RID: 17959
		[Nullable(2)]
		private FText _DisplayName_DEPRECATED;
	}
}
