using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002345 RID: 9029
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneCameraAnimSection")]
	[UnrealStructLayout(368, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 368)]
	public class UMovieSceneCameraAnimSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022219 RID: 139801 RVA: 0x00327763 File Offset: 0x00325963
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneCameraAnimSection._ClassPtr;
		}

		// Token: 0x0602221A RID: 139802 RVA: 0x00327770 File Offset: 0x00325970
		public UMovieSceneCameraAnimSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneCameraAnimSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602221B RID: 139803 RVA: 0x00327798 File Offset: 0x00325998
		public UMovieSceneCameraAnimSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneCameraAnimSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170083D2 RID: 33746
		// (get) Token: 0x0602221C RID: 139804 RVA: 0x003277CC File Offset: 0x003259CC
		// (set) Token: 0x0602221D RID: 139805 RVA: 0x00327805 File Offset: 0x00325A05
		public FMovieSceneCameraAnimSectionData AnimData
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneCameraAnimSectionData result;
				if ((result = this._AnimData) == null)
				{
					result = (this._AnimData = new FMovieSceneCameraAnimSectionData(base.NativePtr + (IntPtr)UMovieSceneCameraAnimSection.__PropertyOffset_AnimData, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneCameraAnimSectionData.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneCameraAnimSection.__PropertyOffset_AnimData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170083D3 RID: 33747
		// (get) Token: 0x0602221E RID: 139806 RVA: 0x00327826 File Offset: 0x00325A26
		// (set) Token: 0x0602221F RID: 139807 RVA: 0x0032783A File Offset: 0x00325A3A
		[Nullable(2)]
		public unsafe UCameraAnim CameraAnim_DEPRECATED
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCameraAnim>(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneCameraAnimSection.__PropertyOffset_CameraAnim_DEPRECATED);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneCameraAnimSection.__PropertyOffset_CameraAnim_DEPRECATED, value);
			}
		}

		// Token: 0x170083D4 RID: 33748
		// (get) Token: 0x06022220 RID: 139808 RVA: 0x0032784F File Offset: 0x00325A4F
		// (set) Token: 0x06022221 RID: 139809 RVA: 0x0032785F File Offset: 0x00325A5F
		public unsafe float PlayRate_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneCameraAnimSection.__PropertyOffset_PlayRate_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneCameraAnimSection.__PropertyOffset_PlayRate_DEPRECATED) = value;
			}
		}

		// Token: 0x170083D5 RID: 33749
		// (get) Token: 0x06022222 RID: 139810 RVA: 0x00327870 File Offset: 0x00325A70
		// (set) Token: 0x06022223 RID: 139811 RVA: 0x00327880 File Offset: 0x00325A80
		public unsafe float PlayScale_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneCameraAnimSection.__PropertyOffset_PlayScale_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneCameraAnimSection.__PropertyOffset_PlayScale_DEPRECATED) = value;
			}
		}

		// Token: 0x170083D6 RID: 33750
		// (get) Token: 0x06022224 RID: 139812 RVA: 0x00327891 File Offset: 0x00325A91
		// (set) Token: 0x06022225 RID: 139813 RVA: 0x003278A1 File Offset: 0x00325AA1
		public unsafe float BlendInTime_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneCameraAnimSection.__PropertyOffset_BlendInTime_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneCameraAnimSection.__PropertyOffset_BlendInTime_DEPRECATED) = value;
			}
		}

		// Token: 0x170083D7 RID: 33751
		// (get) Token: 0x06022226 RID: 139814 RVA: 0x003278B2 File Offset: 0x00325AB2
		// (set) Token: 0x06022227 RID: 139815 RVA: 0x003278C2 File Offset: 0x00325AC2
		public unsafe float BlendOutTime_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneCameraAnimSection.__PropertyOffset_BlendOutTime_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneCameraAnimSection.__PropertyOffset_BlendOutTime_DEPRECATED) = value;
			}
		}

		// Token: 0x170083D8 RID: 33752
		// (get) Token: 0x06022228 RID: 139816 RVA: 0x003278D3 File Offset: 0x00325AD3
		// (set) Token: 0x06022229 RID: 139817 RVA: 0x003278E3 File Offset: 0x00325AE3
		public unsafe bool bLooping_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneCameraAnimSection.__PropertyOffset_bLooping_DEPRECATED) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneCameraAnimSection.__PropertyOffset_bLooping_DEPRECATED) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602222A RID: 139818 RVA: 0x003278F4 File Offset: 0x00325AF4
		static UMovieSceneCameraAnimSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneCameraAnimSection");
		}

		// Token: 0x0602222B RID: 139819 RVA: 0x00327902 File Offset: 0x00325B02
		protected UMovieSceneCameraAnimSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012379 RID: 74617
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneCameraAnimSection";

		// Token: 0x0401237A RID: 74618
		private static IntPtr _ClassPtr;

		// Token: 0x0401237B RID: 74619
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401237C RID: 74620
		internal static int __PropertyOffset_AnimData;

		// Token: 0x0401237D RID: 74621
		[Nullable(2)]
		private FMovieSceneCameraAnimSectionData _AnimData;

		// Token: 0x0401237E RID: 74622
		internal static int __PropertyOffset_CameraAnim_DEPRECATED;

		// Token: 0x0401237F RID: 74623
		internal static int __PropertyOffset_PlayRate_DEPRECATED;

		// Token: 0x04012380 RID: 74624
		internal static int __PropertyOffset_PlayScale_DEPRECATED;

		// Token: 0x04012381 RID: 74625
		internal static int __PropertyOffset_BlendInTime_DEPRECATED;

		// Token: 0x04012382 RID: 74626
		internal static int __PropertyOffset_BlendOutTime_DEPRECATED;

		// Token: 0x04012383 RID: 74627
		internal static int __PropertyOffset_bLooping_DEPRECATED;
	}
}
