using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002376 RID: 9078
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneEventTrack")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMovieSceneEventTrack : UMovieSceneNameableTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060223FF RID: 140287 RVA: 0x0032A5CE File Offset: 0x003287CE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneEventTrack._ClassPtr;
		}

		// Token: 0x06022400 RID: 140288 RVA: 0x0032A5DA File Offset: 0x003287DA
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneEventTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x06022401 RID: 140289 RVA: 0x0032A5E4 File Offset: 0x003287E4
		public UMovieSceneEventTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneEventTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022402 RID: 140290 RVA: 0x0032A60C File Offset: 0x0032880C
		[NullableContext(1)]
		public UMovieSceneEventTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneEventTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008424 RID: 33828
		// (get) Token: 0x06022403 RID: 140291 RVA: 0x0032A63F File Offset: 0x0032883F
		// (set) Token: 0x06022404 RID: 140292 RVA: 0x0032A658 File Offset: 0x00328858
		public unsafe bool bFireEventsWhenForwards
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMovieSceneEventTrack.__PropertyOffset_bFireEventsWhenForwards) & UMovieSceneEventTrack.__PropertyMask_bFireEventsWhenForwards) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMovieSceneEventTrack.__PropertyOffset_bFireEventsWhenForwards) = ((*(base.NativePtr + (IntPtr)UMovieSceneEventTrack.__PropertyOffset_bFireEventsWhenForwards) & ~UMovieSceneEventTrack.__PropertyMask_bFireEventsWhenForwards) | (value ? UMovieSceneEventTrack.__PropertyMask_bFireEventsWhenForwards : 0));
			}
		}

		// Token: 0x17008425 RID: 33829
		// (get) Token: 0x06022405 RID: 140293 RVA: 0x0032A688 File Offset: 0x00328888
		// (set) Token: 0x06022406 RID: 140294 RVA: 0x0032A6A1 File Offset: 0x003288A1
		public unsafe bool bFireEventsWhenBackwards
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMovieSceneEventTrack.__PropertyOffset_bFireEventsWhenBackwards) & UMovieSceneEventTrack.__PropertyMask_bFireEventsWhenBackwards) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMovieSceneEventTrack.__PropertyOffset_bFireEventsWhenBackwards) = ((*(base.NativePtr + (IntPtr)UMovieSceneEventTrack.__PropertyOffset_bFireEventsWhenBackwards) & ~UMovieSceneEventTrack.__PropertyMask_bFireEventsWhenBackwards) | (value ? UMovieSceneEventTrack.__PropertyMask_bFireEventsWhenBackwards : 0));
			}
		}

		// Token: 0x17008426 RID: 33830
		// (get) Token: 0x06022407 RID: 140295 RVA: 0x0032A6D1 File Offset: 0x003288D1
		// (set) Token: 0x06022408 RID: 140296 RVA: 0x0032A6E1 File Offset: 0x003288E1
		public unsafe EFireEventsAtPosition EventPosition
		{
			get
			{
				return (EFireEventsAtPosition)(*(base.NativePtr + (IntPtr)UMovieSceneEventTrack.__PropertyOffset_EventPosition));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneEventTrack.__PropertyOffset_EventPosition) = (byte)value;
			}
		}

		// Token: 0x17008427 RID: 33831
		// (get) Token: 0x06022409 RID: 140297 RVA: 0x0032A6F4 File Offset: 0x003288F4
		// (set) Token: 0x0602240A RID: 140298 RVA: 0x0032A72D File Offset: 0x0032892D
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
					result = (this._Sections = new TArray<UMovieSceneSection>(base.NativePtr + (IntPtr)UMovieSceneEventTrack.__PropertyOffset_Sections, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Sections.CopyAssign(value);
			}
		}

		// Token: 0x0602240B RID: 140299 RVA: 0x0032A73B File Offset: 0x0032893B
		static UMovieSceneEventTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneEventTrack");
		}

		// Token: 0x0602240C RID: 140300 RVA: 0x0032A749 File Offset: 0x00328949
		protected UMovieSceneEventTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012483 RID: 74883
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x04012484 RID: 74884
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneEventTrack";

		// Token: 0x04012485 RID: 74885
		private static IntPtr _ClassPtr;

		// Token: 0x04012486 RID: 74886
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012487 RID: 74887
		internal static int __PropertyOffset_bFireEventsWhenForwards;

		// Token: 0x04012488 RID: 74888
		internal static byte __PropertyMask_bFireEventsWhenForwards;

		// Token: 0x04012489 RID: 74889
		internal static int __PropertyOffset_bFireEventsWhenBackwards;

		// Token: 0x0401248A RID: 74890
		internal static byte __PropertyMask_bFireEventsWhenBackwards;

		// Token: 0x0401248B RID: 74891
		internal static int __PropertyOffset_EventPosition;

		// Token: 0x0401248C RID: 74892
		internal static int __PropertyOffset_Sections;

		// Token: 0x0401248D RID: 74893
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _Sections;
	}
}
