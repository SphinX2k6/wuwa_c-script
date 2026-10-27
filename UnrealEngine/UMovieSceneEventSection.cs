using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002371 RID: 9073
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneEventSection")]
	[UnrealStructLayout(576, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 576)]
	public class UMovieSceneEventSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060223D2 RID: 140242 RVA: 0x0032A0F5 File Offset: 0x003282F5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneEventSection._ClassPtr;
		}

		// Token: 0x060223D3 RID: 140243 RVA: 0x0032A104 File Offset: 0x00328304
		public UMovieSceneEventSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneEventSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060223D4 RID: 140244 RVA: 0x0032A12C File Offset: 0x0032832C
		public UMovieSceneEventSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneEventSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700841D RID: 33821
		// (get) Token: 0x060223D5 RID: 140245 RVA: 0x0032A160 File Offset: 0x00328360
		// (set) Token: 0x060223D6 RID: 140246 RVA: 0x0032A199 File Offset: 0x00328399
		public FNameCurve Events_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				FNameCurve result;
				if ((result = this._Events_DEPRECATED) == null)
				{
					result = (this._Events_DEPRECATED = new FNameCurve(base.NativePtr + (IntPtr)UMovieSceneEventSection.__PropertyOffset_Events_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNameCurve.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneEventSection.__PropertyOffset_Events_DEPRECATED, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700841E RID: 33822
		// (get) Token: 0x060223D7 RID: 140247 RVA: 0x0032A1BC File Offset: 0x003283BC
		// (set) Token: 0x060223D8 RID: 140248 RVA: 0x0032A1F5 File Offset: 0x003283F5
		public FMovieSceneEventSectionData EventData
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneEventSectionData result;
				if ((result = this._EventData) == null)
				{
					result = (this._EventData = new FMovieSceneEventSectionData(base.NativePtr + (IntPtr)UMovieSceneEventSection.__PropertyOffset_EventData, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneEventSectionData.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneEventSection.__PropertyOffset_EventData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060223D9 RID: 140249 RVA: 0x0032A216 File Offset: 0x00328416
		static UMovieSceneEventSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneEventSection");
		}

		// Token: 0x060223DA RID: 140250 RVA: 0x0032A224 File Offset: 0x00328424
		protected UMovieSceneEventSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012468 RID: 74856
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneEventSection";

		// Token: 0x04012469 RID: 74857
		private static IntPtr _ClassPtr;

		// Token: 0x0401246A RID: 74858
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401246B RID: 74859
		internal static int __PropertyOffset_Events_DEPRECATED;

		// Token: 0x0401246C RID: 74860
		[Nullable(2)]
		private FNameCurve _Events_DEPRECATED;

		// Token: 0x0401246D RID: 74861
		internal static int __PropertyOffset_EventData;

		// Token: 0x0401246E RID: 74862
		[Nullable(2)]
		private FMovieSceneEventSectionData _EventData;
	}
}
