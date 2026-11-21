using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000780 RID: 1920
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneFolder")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UMovieSceneFolder : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A5CD RID: 42445 RVA: 0x000F4D98 File Offset: 0x000F2F98
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneFolder._ClassPtr;
		}

		// Token: 0x0600A5CE RID: 42446 RVA: 0x000F4DA4 File Offset: 0x000F2FA4
		public UMovieSceneFolder() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneFolder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A5CF RID: 42447 RVA: 0x000F4DCC File Offset: 0x000F2FCC
		public UMovieSceneFolder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneFolder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001EC6 RID: 7878
		// (get) Token: 0x0600A5D0 RID: 42448 RVA: 0x000F4DFF File Offset: 0x000F2FFF
		// (set) Token: 0x0600A5D1 RID: 42449 RVA: 0x000F4E13 File Offset: 0x000F3013
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

		// Token: 0x17001EC7 RID: 7879
		// (get) Token: 0x0600A5D2 RID: 42450 RVA: 0x000F4E28 File Offset: 0x000F3028
		// (set) Token: 0x0600A5D3 RID: 42451 RVA: 0x000F4E61 File Offset: 0x000F3061
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

		// Token: 0x17001EC8 RID: 7880
		// (get) Token: 0x0600A5D4 RID: 42452 RVA: 0x000F4E70 File Offset: 0x000F3070
		// (set) Token: 0x0600A5D5 RID: 42453 RVA: 0x000F4EA9 File Offset: 0x000F30A9
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

		// Token: 0x17001EC9 RID: 7881
		// (get) Token: 0x0600A5D6 RID: 42454 RVA: 0x000F4EB8 File Offset: 0x000F30B8
		// (set) Token: 0x0600A5D7 RID: 42455 RVA: 0x000F4EF1 File Offset: 0x000F30F1
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

		// Token: 0x0600A5D8 RID: 42456 RVA: 0x000F4EFF File Offset: 0x000F30FF
		static UMovieSceneFolder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneFolder");
		}

		// Token: 0x0600A5D9 RID: 42457 RVA: 0x000F4F0D File Offset: 0x000F310D
		protected UMovieSceneFolder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040046FA RID: 18170
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneFolder";

		// Token: 0x040046FB RID: 18171
		private static IntPtr _ClassPtr;

		// Token: 0x040046FC RID: 18172
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040046FD RID: 18173
		internal static int __PropertyOffset_FolderName;

		// Token: 0x040046FE RID: 18174
		internal static int __PropertyOffset_ChildFolders;

		// Token: 0x040046FF RID: 18175
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneFolder> _ChildFolders;

		// Token: 0x04004700 RID: 18176
		internal static int __PropertyOffset_ChildMasterTracks;

		// Token: 0x04004701 RID: 18177
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneTrack> _ChildMasterTracks;

		// Token: 0x04004702 RID: 18178
		internal static int __PropertyOffset_ChildObjectBindingStrings;

		// Token: 0x04004703 RID: 18179
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ChildObjectBindingStrings;
	}
}
