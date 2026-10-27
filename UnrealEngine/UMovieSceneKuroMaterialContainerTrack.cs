using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C01 RID: 7169
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.MovieSceneKuroMaterialContainerTrack")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UMovieSceneKuroMaterialContainerTrack : UMovieSceneNameableTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0601BAB4 RID: 113332 RVA: 0x0028B882 File Offset: 0x00289A82
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneKuroMaterialContainerTrack._ClassPtr;
		}

		// Token: 0x0601BAB5 RID: 113333 RVA: 0x0028B88E File Offset: 0x00289A8E
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneKuroMaterialContainerTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x0601BAB6 RID: 113334 RVA: 0x0028B898 File Offset: 0x00289A98
		public UMovieSceneKuroMaterialContainerTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneKuroMaterialContainerTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601BAB7 RID: 113335 RVA: 0x0028B8C0 File Offset: 0x00289AC0
		[NullableContext(1)]
		public UMovieSceneKuroMaterialContainerTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneKuroMaterialContainerTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006F9B RID: 28571
		// (get) Token: 0x0601BAB8 RID: 113336 RVA: 0x0028B8F4 File Offset: 0x00289AF4
		// (set) Token: 0x0601BAB9 RID: 113337 RVA: 0x0028B92D File Offset: 0x00289B2D
		[Nullable(1)]
		public TArray<UMovieSceneSection> Sections
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMovieSceneSection> result;
				if ((result = this._Sections) == null)
				{
					result = (this._Sections = new TArray<UMovieSceneSection>(base.NativePtr + (IntPtr)UMovieSceneKuroMaterialContainerTrack.__PropertyOffset_Sections, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Sections.CopyAssign(value);
			}
		}

		// Token: 0x0601BABA RID: 113338 RVA: 0x0028B93B File Offset: 0x00289B3B
		static UMovieSceneKuroMaterialContainerTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.MovieSceneKuroMaterialContainerTrack");
		}

		// Token: 0x0601BABB RID: 113339 RVA: 0x0028B949 File Offset: 0x00289B49
		protected UMovieSceneKuroMaterialContainerTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EE15 RID: 60949
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x0400EE16 RID: 60950
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.MovieSceneKuroMaterialContainerTrack";

		// Token: 0x0400EE17 RID: 60951
		private static IntPtr _ClassPtr;

		// Token: 0x0400EE18 RID: 60952
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EE19 RID: 60953
		internal static int __PropertyOffset_Sections;

		// Token: 0x0400EE1A RID: 60954
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _Sections;
	}
}
