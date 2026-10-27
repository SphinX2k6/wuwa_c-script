using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002370 RID: 9072
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneEventRepeaterSection")]
	[UnrealStructLayout(528, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 528)]
	public class UMovieSceneEventRepeaterSection : UMovieSceneEventSectionBase, IUnrealUObject, IUnrealObject, IMovieSceneEntityProvider, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060223CA RID: 140234 RVA: 0x0032A013 File Offset: 0x00328213
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneEventRepeaterSection._ClassPtr;
		}

		// Token: 0x060223CB RID: 140235 RVA: 0x0032A01F File Offset: 0x0032821F
		int IMovieSceneEntityProvider.InterfaceOffset()
		{
			return UMovieSceneEventRepeaterSection.__InterfaceOffset_IMovieSceneEntityProvider;
		}

		// Token: 0x060223CC RID: 140236 RVA: 0x0032A028 File Offset: 0x00328228
		public UMovieSceneEventRepeaterSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneEventRepeaterSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060223CD RID: 140237 RVA: 0x0032A050 File Offset: 0x00328250
		[NullableContext(1)]
		public UMovieSceneEventRepeaterSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneEventRepeaterSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700841C RID: 33820
		// (get) Token: 0x060223CE RID: 140238 RVA: 0x0032A084 File Offset: 0x00328284
		// (set) Token: 0x060223CF RID: 140239 RVA: 0x0032A0BD File Offset: 0x003282BD
		[Nullable(1)]
		public FMovieSceneEvent Event
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FMovieSceneEvent result;
				if ((result = this._Event) == null)
				{
					result = (this._Event = new FMovieSceneEvent(base.NativePtr + (IntPtr)UMovieSceneEventRepeaterSection.__PropertyOffset_Event, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneEvent.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneEventRepeaterSection.__PropertyOffset_Event, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060223D0 RID: 140240 RVA: 0x0032A0DE File Offset: 0x003282DE
		static UMovieSceneEventRepeaterSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneEventRepeaterSection");
		}

		// Token: 0x060223D1 RID: 140241 RVA: 0x0032A0EC File Offset: 0x003282EC
		protected UMovieSceneEventRepeaterSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012462 RID: 74850
		internal static int __InterfaceOffset_IMovieSceneEntityProvider;

		// Token: 0x04012463 RID: 74851
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneEventRepeaterSection";

		// Token: 0x04012464 RID: 74852
		private static IntPtr _ClassPtr;

		// Token: 0x04012465 RID: 74853
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012466 RID: 74854
		internal static int __PropertyOffset_Event;

		// Token: 0x04012467 RID: 74855
		[Nullable(2)]
		private FMovieSceneEvent _Event;
	}
}
