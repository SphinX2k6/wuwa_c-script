using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002323 RID: 8995
	[UnrealObjectPath("/Script/MovieSceneTracks.FloatChannelEvaluatorSystem")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UFloatChannelEvaluatorSystem : UMovieSceneEntitySystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602208C RID: 139404 RVA: 0x00325086 File Offset: 0x00323286
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFloatChannelEvaluatorSystem._ClassPtr;
		}

		// Token: 0x0602208D RID: 139405 RVA: 0x00325094 File Offset: 0x00323294
		public UFloatChannelEvaluatorSystem() : this(BuiltinUtils.AllocNativeUObject(UFloatChannelEvaluatorSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602208E RID: 139406 RVA: 0x003250BC File Offset: 0x003232BC
		[NullableContext(1)]
		public UFloatChannelEvaluatorSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UFloatChannelEvaluatorSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602208F RID: 139407 RVA: 0x003250EF File Offset: 0x003232EF
		static UFloatChannelEvaluatorSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.FloatChannelEvaluatorSystem");
		}

		// Token: 0x06022090 RID: 139408 RVA: 0x003250FD File Offset: 0x003232FD
		protected UFloatChannelEvaluatorSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012293 RID: 74387
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.FloatChannelEvaluatorSystem";

		// Token: 0x04012294 RID: 74388
		private static IntPtr _ClassPtr;

		// Token: 0x04012295 RID: 74389
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
