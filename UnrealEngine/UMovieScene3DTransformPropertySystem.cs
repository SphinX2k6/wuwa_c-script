using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002332 RID: 9010
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieScene3DTransformPropertySystem")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UMovieScene3DTransformPropertySystem : UMovieScenePropertySystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602213B RID: 139579 RVA: 0x003260F9 File Offset: 0x003242F9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieScene3DTransformPropertySystem._ClassPtr;
		}

		// Token: 0x0602213C RID: 139580 RVA: 0x00326108 File Offset: 0x00324308
		public UMovieScene3DTransformPropertySystem() : this(BuiltinUtils.AllocNativeUObject(UMovieScene3DTransformPropertySystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602213D RID: 139581 RVA: 0x00326130 File Offset: 0x00324330
		[NullableContext(1)]
		public UMovieScene3DTransformPropertySystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieScene3DTransformPropertySystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602213E RID: 139582 RVA: 0x00326163 File Offset: 0x00324363
		static UMovieScene3DTransformPropertySystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieScene3DTransformPropertySystem");
		}

		// Token: 0x0602213F RID: 139583 RVA: 0x00326171 File Offset: 0x00324371
		protected UMovieScene3DTransformPropertySystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040122F9 RID: 74489
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieScene3DTransformPropertySystem";

		// Token: 0x040122FA RID: 74490
		private static IntPtr _ClassPtr;

		// Token: 0x040122FB RID: 74491
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
