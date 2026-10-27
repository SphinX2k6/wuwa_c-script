using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200243E RID: 9278
	[UnrealObjectPath("/Script/MovieScene.MovieSceneSpawnablesSystem")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UMovieSceneSpawnablesSystem : UMovieSceneEntitySystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022CA8 RID: 142504 RVA: 0x003370F4 File Offset: 0x003352F4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneSpawnablesSystem._ClassPtr;
		}

		// Token: 0x06022CA9 RID: 142505 RVA: 0x00337100 File Offset: 0x00335300
		public UMovieSceneSpawnablesSystem() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSpawnablesSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022CAA RID: 142506 RVA: 0x00337128 File Offset: 0x00335328
		[NullableContext(1)]
		public UMovieSceneSpawnablesSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSpawnablesSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022CAB RID: 142507 RVA: 0x0033715B File Offset: 0x0033535B
		static UMovieSceneSpawnablesSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneSpawnablesSystem");
		}

		// Token: 0x06022CAC RID: 142508 RVA: 0x00337169 File Offset: 0x00335369
		protected UMovieSceneSpawnablesSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012935 RID: 76085
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneSpawnablesSystem";

		// Token: 0x04012936 RID: 76086
		private static IntPtr _ClassPtr;

		// Token: 0x04012937 RID: 76087
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
