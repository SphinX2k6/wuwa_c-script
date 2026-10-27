using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200239C RID: 9116
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieScenePreSpawnEventSystem")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UMovieScenePreSpawnEventSystem : UMovieSceneEventSystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602256D RID: 140653 RVA: 0x0032C8AA File Offset: 0x0032AAAA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieScenePreSpawnEventSystem._ClassPtr;
		}

		// Token: 0x0602256E RID: 140654 RVA: 0x0032C8B8 File Offset: 0x0032AAB8
		public UMovieScenePreSpawnEventSystem() : this(BuiltinUtils.AllocNativeUObject(UMovieScenePreSpawnEventSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602256F RID: 140655 RVA: 0x0032C8E0 File Offset: 0x0032AAE0
		[NullableContext(1)]
		public UMovieScenePreSpawnEventSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieScenePreSpawnEventSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022570 RID: 140656 RVA: 0x0032C913 File Offset: 0x0032AB13
		static UMovieScenePreSpawnEventSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieScenePreSpawnEventSystem");
		}

		// Token: 0x06022571 RID: 140657 RVA: 0x0032C921 File Offset: 0x0032AB21
		protected UMovieScenePreSpawnEventSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401254A RID: 75082
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieScenePreSpawnEventSystem";

		// Token: 0x0401254B RID: 75083
		private static IntPtr _ClassPtr;

		// Token: 0x0401254C RID: 75084
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
