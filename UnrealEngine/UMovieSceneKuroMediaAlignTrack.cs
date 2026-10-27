using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C0A RID: 7178
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.MovieSceneKuroMediaAlignTrack")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UMovieSceneKuroMediaAlignTrack : UMovieSceneNameableTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0601BB24 RID: 113444 RVA: 0x0028C40D File Offset: 0x0028A60D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneKuroMediaAlignTrack._ClassPtr;
		}

		// Token: 0x0601BB25 RID: 113445 RVA: 0x0028C419 File Offset: 0x0028A619
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneKuroMediaAlignTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x0601BB26 RID: 113446 RVA: 0x0028C420 File Offset: 0x0028A620
		public UMovieSceneKuroMediaAlignTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneKuroMediaAlignTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601BB27 RID: 113447 RVA: 0x0028C448 File Offset: 0x0028A648
		[NullableContext(1)]
		public UMovieSceneKuroMediaAlignTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneKuroMediaAlignTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006FB5 RID: 28597
		// (get) Token: 0x0601BB28 RID: 113448 RVA: 0x0028C47C File Offset: 0x0028A67C
		// (set) Token: 0x0601BB29 RID: 113449 RVA: 0x0028C4B5 File Offset: 0x0028A6B5
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
					result = (this._Sections = new TArray<UMovieSceneSection>(base.NativePtr + (IntPtr)UMovieSceneKuroMediaAlignTrack.__PropertyOffset_Sections, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Sections.CopyAssign(value);
			}
		}

		// Token: 0x0601BB2A RID: 113450 RVA: 0x0028C4C3 File Offset: 0x0028A6C3
		static UMovieSceneKuroMediaAlignTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.MovieSceneKuroMediaAlignTrack");
		}

		// Token: 0x0601BB2B RID: 113451 RVA: 0x0028C4D1 File Offset: 0x0028A6D1
		protected UMovieSceneKuroMediaAlignTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EE55 RID: 61013
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x0400EE56 RID: 61014
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.MovieSceneKuroMediaAlignTrack";

		// Token: 0x0400EE57 RID: 61015
		private static IntPtr _ClassPtr;

		// Token: 0x0400EE58 RID: 61016
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EE59 RID: 61017
		internal static int __PropertyOffset_Sections;

		// Token: 0x0400EE5A RID: 61018
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _Sections;
	}
}
