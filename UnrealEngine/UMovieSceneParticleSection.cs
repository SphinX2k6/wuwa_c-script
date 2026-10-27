using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002395 RID: 9109
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneParticleSection")]
	[UnrealStructLayout(456, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 456)]
	public class UMovieSceneParticleSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602253E RID: 140606 RVA: 0x0032C40E File Offset: 0x0032A60E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneParticleSection._ClassPtr;
		}

		// Token: 0x0602253F RID: 140607 RVA: 0x0032C41C File Offset: 0x0032A61C
		public UMovieSceneParticleSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneParticleSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022540 RID: 140608 RVA: 0x0032C444 File Offset: 0x0032A644
		public UMovieSceneParticleSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneParticleSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008451 RID: 33873
		// (get) Token: 0x06022541 RID: 140609 RVA: 0x0032C478 File Offset: 0x0032A678
		// (set) Token: 0x06022542 RID: 140610 RVA: 0x0032C4B1 File Offset: 0x0032A6B1
		public FMovieSceneParticleChannel ParticleKeys
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneParticleChannel result;
				if ((result = this._ParticleKeys) == null)
				{
					result = (this._ParticleKeys = new FMovieSceneParticleChannel(base.NativePtr + (IntPtr)UMovieSceneParticleSection.__PropertyOffset_ParticleKeys, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneParticleChannel.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneParticleSection.__PropertyOffset_ParticleKeys, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06022543 RID: 140611 RVA: 0x0032C4D2 File Offset: 0x0032A6D2
		static UMovieSceneParticleSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneParticleSection");
		}

		// Token: 0x06022544 RID: 140612 RVA: 0x0032C4E0 File Offset: 0x0032A6E0
		protected UMovieSceneParticleSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401252D RID: 75053
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneParticleSection";

		// Token: 0x0401252E RID: 75054
		private static IntPtr _ClassPtr;

		// Token: 0x0401252F RID: 75055
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012530 RID: 75056
		internal static int __PropertyOffset_ParticleKeys;

		// Token: 0x04012531 RID: 75057
		[Nullable(2)]
		private FMovieSceneParticleChannel _ParticleKeys;
	}
}
