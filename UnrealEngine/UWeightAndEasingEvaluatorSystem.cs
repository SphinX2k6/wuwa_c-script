using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023C2 RID: 9154
	[UnrealObjectPath("/Script/MovieSceneTracks.WeightAndEasingEvaluatorSystem")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UWeightAndEasingEvaluatorSystem : UMovieSceneEntitySystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022712 RID: 141074 RVA: 0x0032EFD1 File Offset: 0x0032D1D1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWeightAndEasingEvaluatorSystem._ClassPtr;
		}

		// Token: 0x06022713 RID: 141075 RVA: 0x0032EFE0 File Offset: 0x0032D1E0
		public UWeightAndEasingEvaluatorSystem() : this(BuiltinUtils.AllocNativeUObject(UWeightAndEasingEvaluatorSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022714 RID: 141076 RVA: 0x0032F008 File Offset: 0x0032D208
		[NullableContext(1)]
		public UWeightAndEasingEvaluatorSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWeightAndEasingEvaluatorSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022715 RID: 141077 RVA: 0x0032F03B File Offset: 0x0032D23B
		static UWeightAndEasingEvaluatorSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.WeightAndEasingEvaluatorSystem");
		}

		// Token: 0x06022716 RID: 141078 RVA: 0x0032F049 File Offset: 0x0032D249
		protected UWeightAndEasingEvaluatorSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012626 RID: 75302
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.WeightAndEasingEvaluatorSystem";

		// Token: 0x04012627 RID: 75303
		private static IntPtr _ClassPtr;

		// Token: 0x04012628 RID: 75304
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
