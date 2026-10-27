using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002466 RID: 9318
	[UnrealObjectPath("/Script/MovieScene.TestMovieSceneTrack")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UTestMovieSceneTrack : UMovieSceneTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06022E48 RID: 142920 RVA: 0x003396D2 File Offset: 0x003378D2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTestMovieSceneTrack._ClassPtr;
		}

		// Token: 0x06022E49 RID: 142921 RVA: 0x003396DE File Offset: 0x003378DE
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UTestMovieSceneTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x06022E4A RID: 142922 RVA: 0x003396E8 File Offset: 0x003378E8
		public UTestMovieSceneTrack() : this(BuiltinUtils.AllocNativeUObject(UTestMovieSceneTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022E4B RID: 142923 RVA: 0x00339710 File Offset: 0x00337910
		[NullableContext(1)]
		public UTestMovieSceneTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTestMovieSceneTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008612 RID: 34322
		// (get) Token: 0x06022E4C RID: 142924 RVA: 0x00339743 File Offset: 0x00337943
		// (set) Token: 0x06022E4D RID: 142925 RVA: 0x00339753 File Offset: 0x00337953
		public unsafe bool bHighPassFilter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTestMovieSceneTrack.__PropertyOffset_bHighPassFilter) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTestMovieSceneTrack.__PropertyOffset_bHighPassFilter) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008613 RID: 34323
		// (get) Token: 0x06022E4E RID: 142926 RVA: 0x00339764 File Offset: 0x00337964
		// (set) Token: 0x06022E4F RID: 142927 RVA: 0x0033979D File Offset: 0x0033799D
		[Nullable(1)]
		public TArray<UMovieSceneSection> SectionArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMovieSceneSection> result;
				if ((result = this._SectionArray) == null)
				{
					result = (this._SectionArray = new TArray<UMovieSceneSection>(base.NativePtr + (IntPtr)UTestMovieSceneTrack.__PropertyOffset_SectionArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SectionArray.CopyAssign(value);
			}
		}

		// Token: 0x06022E50 RID: 142928 RVA: 0x003397AB File Offset: 0x003379AB
		static UTestMovieSceneTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.TestMovieSceneTrack");
		}

		// Token: 0x06022E51 RID: 142929 RVA: 0x003397B9 File Offset: 0x003379B9
		protected UTestMovieSceneTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012A07 RID: 76295
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x04012A08 RID: 76296
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieScene.TestMovieSceneTrack";

		// Token: 0x04012A09 RID: 76297
		private static IntPtr _ClassPtr;

		// Token: 0x04012A0A RID: 76298
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012A0B RID: 76299
		internal static int __PropertyOffset_bHighPassFilter;

		// Token: 0x04012A0C RID: 76300
		internal static int __PropertyOffset_SectionArray;

		// Token: 0x04012A0D RID: 76301
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _SectionArray;
	}
}
