using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002464 RID: 9316
	[UnrealObjectPath("/Script/MovieScene.TestMovieSceneSubSection")]
	[UnrealStructLayout(448, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 448)]
	public class UTestMovieSceneSubSection : UMovieSceneSubSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022E3C RID: 142908 RVA: 0x0033958B File Offset: 0x0033778B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTestMovieSceneSubSection._ClassPtr;
		}

		// Token: 0x06022E3D RID: 142909 RVA: 0x00339598 File Offset: 0x00337798
		public UTestMovieSceneSubSection() : this(BuiltinUtils.AllocNativeUObject(UTestMovieSceneSubSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022E3E RID: 142910 RVA: 0x003395C0 File Offset: 0x003377C0
		[NullableContext(1)]
		public UTestMovieSceneSubSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTestMovieSceneSubSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022E3F RID: 142911 RVA: 0x003395F3 File Offset: 0x003377F3
		static UTestMovieSceneSubSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.TestMovieSceneSubSection");
		}

		// Token: 0x06022E40 RID: 142912 RVA: 0x00339601 File Offset: 0x00337801
		protected UTestMovieSceneSubSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040129FF RID: 76287
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieScene.TestMovieSceneSubSection";

		// Token: 0x04012A00 RID: 76288
		private static IntPtr _ClassPtr;

		// Token: 0x04012A01 RID: 76289
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
