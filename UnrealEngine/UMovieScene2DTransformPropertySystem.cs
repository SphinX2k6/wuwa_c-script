using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002985 RID: 10629
	[UnrealObjectPath("/Script/UMG.MovieScene2DTransformPropertySystem")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UMovieScene2DTransformPropertySystem : UMovieScenePropertySystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602757F RID: 161151 RVA: 0x003BF97F File Offset: 0x003BDB7F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieScene2DTransformPropertySystem._ClassPtr;
		}

		// Token: 0x06027580 RID: 161152 RVA: 0x003BF98C File Offset: 0x003BDB8C
		public UMovieScene2DTransformPropertySystem() : this(BuiltinUtils.AllocNativeUObject(UMovieScene2DTransformPropertySystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027581 RID: 161153 RVA: 0x003BF9B4 File Offset: 0x003BDBB4
		[NullableContext(1)]
		public UMovieScene2DTransformPropertySystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieScene2DTransformPropertySystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06027582 RID: 161154 RVA: 0x003BF9E7 File Offset: 0x003BDBE7
		static UMovieScene2DTransformPropertySystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.MovieScene2DTransformPropertySystem");
		}

		// Token: 0x06027583 RID: 161155 RVA: 0x003BF9F5 File Offset: 0x003BDBF5
		protected UMovieScene2DTransformPropertySystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040159A0 RID: 88480
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.MovieScene2DTransformPropertySystem";

		// Token: 0x040159A1 RID: 88481
		private static IntPtr _ClassPtr;

		// Token: 0x040159A2 RID: 88482
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
