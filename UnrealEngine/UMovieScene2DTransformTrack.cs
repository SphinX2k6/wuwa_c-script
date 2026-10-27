using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002987 RID: 10631
	[UnrealObjectPath("/Script/UMG.MovieScene2DTransformTrack")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UMovieScene2DTransformTrack : UMovieScenePropertyTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027594 RID: 161172 RVA: 0x003BFC17 File Offset: 0x003BDE17
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieScene2DTransformTrack._ClassPtr;
		}

		// Token: 0x06027595 RID: 161173 RVA: 0x003BFC24 File Offset: 0x003BDE24
		public UMovieScene2DTransformTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieScene2DTransformTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027596 RID: 161174 RVA: 0x003BFC4C File Offset: 0x003BDE4C
		[NullableContext(1)]
		public UMovieScene2DTransformTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieScene2DTransformTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06027597 RID: 161175 RVA: 0x003BFC7F File Offset: 0x003BDE7F
		static UMovieScene2DTransformTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.MovieScene2DTransformTrack");
		}

		// Token: 0x06027598 RID: 161176 RVA: 0x003BFC8D File Offset: 0x003BDE8D
		protected UMovieScene2DTransformTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040159B1 RID: 88497
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.MovieScene2DTransformTrack";

		// Token: 0x040159B2 RID: 88498
		private static IntPtr _ClassPtr;

		// Token: 0x040159B3 RID: 88499
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
