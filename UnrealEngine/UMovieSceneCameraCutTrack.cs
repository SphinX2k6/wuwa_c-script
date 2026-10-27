using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200234A RID: 9034
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneCameraCutTrack")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UMovieSceneCameraCutTrack : UMovieSceneNameableTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022266 RID: 139878 RVA: 0x00327EB5 File Offset: 0x003260B5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneCameraCutTrack._ClassPtr;
		}

		// Token: 0x06022267 RID: 139879 RVA: 0x00327EC4 File Offset: 0x003260C4
		public UMovieSceneCameraCutTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneCameraCutTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022268 RID: 139880 RVA: 0x00327EEC File Offset: 0x003260EC
		public UMovieSceneCameraCutTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneCameraCutTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170083E7 RID: 33767
		// (get) Token: 0x06022269 RID: 139881 RVA: 0x00327F1F File Offset: 0x0032611F
		// (set) Token: 0x0602226A RID: 139882 RVA: 0x00327F2F File Offset: 0x0032612F
		public unsafe bool bCanBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneCameraCutTrack.__PropertyOffset_bCanBlend) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneCameraCutTrack.__PropertyOffset_bCanBlend) = (value ? 1 : 0);
			}
		}

		// Token: 0x170083E8 RID: 33768
		// (get) Token: 0x0602226B RID: 139883 RVA: 0x00327F40 File Offset: 0x00326140
		// (set) Token: 0x0602226C RID: 139884 RVA: 0x00327F79 File Offset: 0x00326179
		public TArray<UMovieSceneSection> Sections
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMovieSceneSection> result;
				if ((result = this._Sections) == null)
				{
					result = (this._Sections = new TArray<UMovieSceneSection>(base.NativePtr + (IntPtr)UMovieSceneCameraCutTrack.__PropertyOffset_Sections, this));
				}
				return result;
			}
			set
			{
				this.Sections.CopyAssign(value);
			}
		}

		// Token: 0x0602226D RID: 139885 RVA: 0x00327F87 File Offset: 0x00326187
		static UMovieSceneCameraCutTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneCameraCutTrack");
		}

		// Token: 0x0602226E RID: 139886 RVA: 0x00327F95 File Offset: 0x00326195
		protected UMovieSceneCameraCutTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040123A4 RID: 74660
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneCameraCutTrack";

		// Token: 0x040123A5 RID: 74661
		private static IntPtr _ClassPtr;

		// Token: 0x040123A6 RID: 74662
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040123A7 RID: 74663
		internal static int __PropertyOffset_bCanBlend;

		// Token: 0x040123A8 RID: 74664
		internal static int __PropertyOffset_Sections;

		// Token: 0x040123A9 RID: 74665
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _Sections;
	}
}
