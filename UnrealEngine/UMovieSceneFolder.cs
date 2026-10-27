using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200240B RID: 9227
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneFolder")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UMovieSceneFolder : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060229B8 RID: 141752 RVA: 0x00332EEE File Offset: 0x003310EE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneFolder._ClassPtr;
		}

		// Token: 0x060229B9 RID: 141753 RVA: 0x00332EFC File Offset: 0x003310FC
		public UMovieSceneFolder() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneFolder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060229BA RID: 141754 RVA: 0x00332F24 File Offset: 0x00331124
		public UMovieSceneFolder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneFolder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700853A RID: 34106
		// (get) Token: 0x060229BB RID: 141755 RVA: 0x00332F57 File Offset: 0x00331157
		// (set) Token: 0x060229BC RID: 141756 RVA: 0x00332F6B File Offset: 0x0033116B
		public unsafe FName FolderName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneFolder.__PropertyOffset_FolderName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneFolder.__PropertyOffset_FolderName) = value;
			}
		}

		// Token: 0x1700853B RID: 34107
		// (get) Token: 0x060229BD RID: 141757 RVA: 0x00332F80 File Offset: 0x00331180
		// (set) Token: 0x060229BE RID: 141758 RVA: 0x00332FB9 File Offset: 0x003311B9
		public TArray<UMovieSceneFolder> ChildFolders
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMovieSceneFolder> result;
				if ((result = this._ChildFolders) == null)
				{
					result = (this._ChildFolders = new TArray<UMovieSceneFolder>(base.NativePtr + (IntPtr)UMovieSceneFolder.__PropertyOffset_ChildFolders, this));
				}
				return result;
			}
			set
			{
				this.ChildFolders.CopyAssign(value);
			}
		}

		// Token: 0x1700853C RID: 34108
		// (get) Token: 0x060229BF RID: 141759 RVA: 0x00332FC8 File Offset: 0x003311C8
		// (set) Token: 0x060229C0 RID: 141760 RVA: 0x00333001 File Offset: 0x00331201
		public TArray<UMovieSceneTrack> ChildMasterTracks
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMovieSceneTrack> result;
				if ((result = this._ChildMasterTracks) == null)
				{
					result = (this._ChildMasterTracks = new TArray<UMovieSceneTrack>(base.NativePtr + (IntPtr)UMovieSceneFolder.__PropertyOffset_ChildMasterTracks, this));
				}
				return result;
			}
			set
			{
				this.ChildMasterTracks.CopyAssign(value);
			}
		}

		// Token: 0x1700853D RID: 34109
		// (get) Token: 0x060229C1 RID: 141761 RVA: 0x00333010 File Offset: 0x00331210
		// (set) Token: 0x060229C2 RID: 141762 RVA: 0x00333049 File Offset: 0x00331249
		public TArray<string> ChildObjectBindingStrings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._ChildObjectBindingStrings) == null)
				{
					result = (this._ChildObjectBindingStrings = new TArray<string>(base.NativePtr + (IntPtr)UMovieSceneFolder.__PropertyOffset_ChildObjectBindingStrings, this));
				}
				return result;
			}
			set
			{
				this.ChildObjectBindingStrings.CopyAssign(value);
			}
		}

		// Token: 0x060229C3 RID: 141763 RVA: 0x00333057 File Offset: 0x00331257
		static UMovieSceneFolder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneFolder");
		}

		// Token: 0x060229C4 RID: 141764 RVA: 0x00333065 File Offset: 0x00331265
		protected UMovieSceneFolder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040127E1 RID: 75745
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneFolder";

		// Token: 0x040127E2 RID: 75746
		private static IntPtr _ClassPtr;

		// Token: 0x040127E3 RID: 75747
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040127E4 RID: 75748
		internal static int __PropertyOffset_FolderName;

		// Token: 0x040127E5 RID: 75749
		internal static int __PropertyOffset_ChildFolders;

		// Token: 0x040127E6 RID: 75750
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneFolder> _ChildFolders;

		// Token: 0x040127E7 RID: 75751
		internal static int __PropertyOffset_ChildMasterTracks;

		// Token: 0x040127E8 RID: 75752
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneTrack> _ChildMasterTracks;

		// Token: 0x040127E9 RID: 75753
		internal static int __PropertyOffset_ChildObjectBindingStrings;

		// Token: 0x040127EA RID: 75754
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ChildObjectBindingStrings;
	}
}
