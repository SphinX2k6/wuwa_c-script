using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200233F RID: 9023
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneBaseValueEvaluatorSystem")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UMovieSceneBaseValueEvaluatorSystem : UMovieSceneEntitySystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060221EB RID: 139755 RVA: 0x003272FE File Offset: 0x003254FE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneBaseValueEvaluatorSystem._ClassPtr;
		}

		// Token: 0x060221EC RID: 139756 RVA: 0x0032730C File Offset: 0x0032550C
		public UMovieSceneBaseValueEvaluatorSystem() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneBaseValueEvaluatorSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060221ED RID: 139757 RVA: 0x00327334 File Offset: 0x00325534
		[NullableContext(1)]
		public UMovieSceneBaseValueEvaluatorSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneBaseValueEvaluatorSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060221EE RID: 139758 RVA: 0x00327367 File Offset: 0x00325567
		static UMovieSceneBaseValueEvaluatorSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneBaseValueEvaluatorSystem");
		}

		// Token: 0x060221EF RID: 139759 RVA: 0x00327375 File Offset: 0x00325575
		protected UMovieSceneBaseValueEvaluatorSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012360 RID: 74592
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneBaseValueEvaluatorSystem";

		// Token: 0x04012361 RID: 74593
		private static IntPtr _ClassPtr;

		// Token: 0x04012362 RID: 74594
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
