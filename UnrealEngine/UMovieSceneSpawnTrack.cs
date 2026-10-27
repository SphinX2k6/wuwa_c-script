using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002440 RID: 9280
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneSpawnTrack")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UMovieSceneSpawnTrack : UMovieSceneTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022CB3 RID: 142515 RVA: 0x003371FA File Offset: 0x003353FA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneSpawnTrack._ClassPtr;
		}

		// Token: 0x06022CB4 RID: 142516 RVA: 0x00337208 File Offset: 0x00335408
		public UMovieSceneSpawnTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSpawnTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022CB5 RID: 142517 RVA: 0x00337230 File Offset: 0x00335430
		public UMovieSceneSpawnTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSpawnTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170085C8 RID: 34248
		// (get) Token: 0x06022CB6 RID: 142518 RVA: 0x00337264 File Offset: 0x00335464
		// (set) Token: 0x06022CB7 RID: 142519 RVA: 0x0033729D File Offset: 0x0033549D
		public TArray<UMovieSceneSection> Sections
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMovieSceneSection> result;
				if ((result = this._Sections) == null)
				{
					result = (this._Sections = new TArray<UMovieSceneSection>(base.NativePtr + (IntPtr)UMovieSceneSpawnTrack.__PropertyOffset_Sections, this));
				}
				return result;
			}
			set
			{
				this.Sections.CopyAssign(value);
			}
		}

		// Token: 0x170085C9 RID: 34249
		// (get) Token: 0x06022CB8 RID: 142520 RVA: 0x003372AB File Offset: 0x003354AB
		// (set) Token: 0x06022CB9 RID: 142521 RVA: 0x003372BF File Offset: 0x003354BF
		public unsafe FGuid ObjectGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneSpawnTrack.__PropertyOffset_ObjectGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneSpawnTrack.__PropertyOffset_ObjectGuid) = value;
			}
		}

		// Token: 0x06022CBA RID: 142522 RVA: 0x003372D4 File Offset: 0x003354D4
		static UMovieSceneSpawnTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneSpawnTrack");
		}

		// Token: 0x06022CBB RID: 142523 RVA: 0x003372E2 File Offset: 0x003354E2
		protected UMovieSceneSpawnTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401293C RID: 76092
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneSpawnTrack";

		// Token: 0x0401293D RID: 76093
		private static IntPtr _ClassPtr;

		// Token: 0x0401293E RID: 76094
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401293F RID: 76095
		internal static int __PropertyOffset_Sections;

		// Token: 0x04012940 RID: 76096
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _Sections;

		// Token: 0x04012941 RID: 76097
		internal static int __PropertyOffset_ObjectGuid;
	}
}
