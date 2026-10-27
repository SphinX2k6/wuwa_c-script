using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019CE RID: 6606
	[UnrealObjectPath("/Script/KuroMechanismSequenceRuntime.MovieSceneMechanismEventSystem")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UMovieSceneMechanismEventSystem : UMovieSceneEntitySystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060188A6 RID: 100518 RVA: 0x002423E4 File Offset: 0x002405E4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneMechanismEventSystem._ClassPtr;
		}

		// Token: 0x060188A7 RID: 100519 RVA: 0x002423F0 File Offset: 0x002405F0
		public UMovieSceneMechanismEventSystem() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneMechanismEventSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060188A8 RID: 100520 RVA: 0x00242418 File Offset: 0x00240618
		[NullableContext(1)]
		public UMovieSceneMechanismEventSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneMechanismEventSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060188A9 RID: 100521 RVA: 0x0024244B File Offset: 0x0024064B
		static UMovieSceneMechanismEventSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroMechanismSequenceRuntime.MovieSceneMechanismEventSystem");
		}

		// Token: 0x060188AA RID: 100522 RVA: 0x00242459 File Offset: 0x00240659
		protected UMovieSceneMechanismEventSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D426 RID: 54310
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroMechanismSequenceRuntime.MovieSceneMechanismEventSystem";

		// Token: 0x0400D427 RID: 54311
		private static IntPtr _ClassPtr;

		// Token: 0x0400D428 RID: 54312
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
