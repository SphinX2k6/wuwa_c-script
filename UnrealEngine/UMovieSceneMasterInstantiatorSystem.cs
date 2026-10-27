using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002414 RID: 9236
	[UnrealObjectPath("/Script/MovieScene.MovieSceneMasterInstantiatorSystem")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UMovieSceneMasterInstantiatorSystem : UMovieSceneEntityInstantiatorSystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022A06 RID: 141830 RVA: 0x00333553 File Offset: 0x00331753
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneMasterInstantiatorSystem._ClassPtr;
		}

		// Token: 0x06022A07 RID: 141831 RVA: 0x00333560 File Offset: 0x00331760
		public UMovieSceneMasterInstantiatorSystem() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneMasterInstantiatorSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022A08 RID: 141832 RVA: 0x00333588 File Offset: 0x00331788
		[NullableContext(1)]
		public UMovieSceneMasterInstantiatorSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneMasterInstantiatorSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022A09 RID: 141833 RVA: 0x003335BB File Offset: 0x003317BB
		static UMovieSceneMasterInstantiatorSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneMasterInstantiatorSystem");
		}

		// Token: 0x06022A0A RID: 141834 RVA: 0x003335C9 File Offset: 0x003317C9
		protected UMovieSceneMasterInstantiatorSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012806 RID: 75782
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneMasterInstantiatorSystem";

		// Token: 0x04012807 RID: 75783
		private static IntPtr _ClassPtr;

		// Token: 0x04012808 RID: 75784
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
