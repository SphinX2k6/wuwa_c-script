using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200234B RID: 9035
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneCameraCutTrackInstance")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMovieSceneCameraCutTrackInstance : UMovieSceneTrackInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602226F RID: 139887 RVA: 0x00327F9E File Offset: 0x0032619E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneCameraCutTrackInstance._ClassPtr;
		}

		// Token: 0x06022270 RID: 139888 RVA: 0x00327FAC File Offset: 0x003261AC
		public UMovieSceneCameraCutTrackInstance() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneCameraCutTrackInstance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022271 RID: 139889 RVA: 0x00327FD4 File Offset: 0x003261D4
		[NullableContext(1)]
		public UMovieSceneCameraCutTrackInstance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneCameraCutTrackInstance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022272 RID: 139890 RVA: 0x00328007 File Offset: 0x00326207
		static UMovieSceneCameraCutTrackInstance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneCameraCutTrackInstance");
		}

		// Token: 0x06022273 RID: 139891 RVA: 0x00328015 File Offset: 0x00326215
		protected UMovieSceneCameraCutTrackInstance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040123AA RID: 74666
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneCameraCutTrackInstance";

		// Token: 0x040123AB RID: 74667
		private static IntPtr _ClassPtr;

		// Token: 0x040123AC RID: 74668
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
