using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002462 RID: 9314
	[UnrealObjectPath("/Script/MovieScene.TestMovieSceneSection")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UTestMovieSceneSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022E30 RID: 142896 RVA: 0x00339464 File Offset: 0x00337664
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTestMovieSceneSection._ClassPtr;
		}

		// Token: 0x06022E31 RID: 142897 RVA: 0x00339470 File Offset: 0x00337670
		public UTestMovieSceneSection() : this(BuiltinUtils.AllocNativeUObject(UTestMovieSceneSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022E32 RID: 142898 RVA: 0x00339498 File Offset: 0x00337698
		[NullableContext(1)]
		public UTestMovieSceneSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTestMovieSceneSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022E33 RID: 142899 RVA: 0x003394CB File Offset: 0x003376CB
		static UTestMovieSceneSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.TestMovieSceneSection");
		}

		// Token: 0x06022E34 RID: 142900 RVA: 0x003394D9 File Offset: 0x003376D9
		protected UTestMovieSceneSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040129F8 RID: 76280
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieScene.TestMovieSceneSection";

		// Token: 0x040129F9 RID: 76281
		private static IntPtr _ClassPtr;

		// Token: 0x040129FA RID: 76282
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
