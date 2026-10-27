using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200298A RID: 10634
	[UnrealObjectPath("/Script/UMG.MovieSceneMarginTrack")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UMovieSceneMarginTrack : UMovieScenePropertyTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060275B8 RID: 161208 RVA: 0x003C00EC File Offset: 0x003BE2EC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneMarginTrack._ClassPtr;
		}

		// Token: 0x060275B9 RID: 161209 RVA: 0x003C00F8 File Offset: 0x003BE2F8
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneMarginTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x060275BA RID: 161210 RVA: 0x003C0100 File Offset: 0x003BE300
		public UMovieSceneMarginTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneMarginTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060275BB RID: 161211 RVA: 0x003C0128 File Offset: 0x003BE328
		[NullableContext(1)]
		public UMovieSceneMarginTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneMarginTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060275BC RID: 161212 RVA: 0x003C015B File Offset: 0x003BE35B
		static UMovieSceneMarginTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.MovieSceneMarginTrack");
		}

		// Token: 0x060275BD RID: 161213 RVA: 0x003C0169 File Offset: 0x003BE369
		protected UMovieSceneMarginTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040159CA RID: 88522
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x040159CB RID: 88523
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.MovieSceneMarginTrack";

		// Token: 0x040159CC RID: 88524
		private static IntPtr _ClassPtr;

		// Token: 0x040159CD RID: 88525
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
