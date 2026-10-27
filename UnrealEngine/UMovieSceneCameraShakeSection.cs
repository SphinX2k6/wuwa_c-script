using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200234C RID: 9036
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneCameraShakeSection")]
	[UnrealStructLayout(368, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 368)]
	public class UMovieSceneCameraShakeSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022274 RID: 139892 RVA: 0x0032801E File Offset: 0x0032621E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneCameraShakeSection._ClassPtr;
		}

		// Token: 0x06022275 RID: 139893 RVA: 0x0032802C File Offset: 0x0032622C
		public UMovieSceneCameraShakeSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneCameraShakeSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022276 RID: 139894 RVA: 0x00328054 File Offset: 0x00326254
		public UMovieSceneCameraShakeSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneCameraShakeSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170083E9 RID: 33769
		// (get) Token: 0x06022277 RID: 139895 RVA: 0x00328088 File Offset: 0x00326288
		// (set) Token: 0x06022278 RID: 139896 RVA: 0x003280C1 File Offset: 0x003262C1
		public FMovieSceneCameraShakeSectionData ShakeData
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneCameraShakeSectionData result;
				if ((result = this._ShakeData) == null)
				{
					result = (this._ShakeData = new FMovieSceneCameraShakeSectionData(base.NativePtr + (IntPtr)UMovieSceneCameraShakeSection.__PropertyOffset_ShakeData, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneCameraShakeSectionData.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneCameraShakeSection.__PropertyOffset_ShakeData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170083EA RID: 33770
		// (get) Token: 0x06022279 RID: 139897 RVA: 0x003280E2 File Offset: 0x003262E2
		// (set) Token: 0x0602227A RID: 139898 RVA: 0x003280F6 File Offset: 0x003262F6
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UMatineeCameraShake> ShakeClass_DEPRECATED
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneCameraShakeSection.__PropertyOffset_ShakeClass_DEPRECATED);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneCameraShakeSection.__PropertyOffset_ShakeClass_DEPRECATED) = value;
			}
		}

		// Token: 0x170083EB RID: 33771
		// (get) Token: 0x0602227B RID: 139899 RVA: 0x0032810B File Offset: 0x0032630B
		// (set) Token: 0x0602227C RID: 139900 RVA: 0x0032811B File Offset: 0x0032631B
		public unsafe float PlayScale_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneCameraShakeSection.__PropertyOffset_PlayScale_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneCameraShakeSection.__PropertyOffset_PlayScale_DEPRECATED) = value;
			}
		}

		// Token: 0x170083EC RID: 33772
		// (get) Token: 0x0602227D RID: 139901 RVA: 0x0032812C File Offset: 0x0032632C
		// (set) Token: 0x0602227E RID: 139902 RVA: 0x0032813C File Offset: 0x0032633C
		public unsafe ECameraShakePlaySpace PlaySpace_DEPRECATED
		{
			get
			{
				return (ECameraShakePlaySpace)(*(base.NativePtr + (IntPtr)UMovieSceneCameraShakeSection.__PropertyOffset_PlaySpace_DEPRECATED));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneCameraShakeSection.__PropertyOffset_PlaySpace_DEPRECATED) = (byte)value;
			}
		}

		// Token: 0x170083ED RID: 33773
		// (get) Token: 0x0602227F RID: 139903 RVA: 0x0032814D File Offset: 0x0032634D
		// (set) Token: 0x06022280 RID: 139904 RVA: 0x00328161 File Offset: 0x00326361
		public unsafe FRotator UserDefinedPlaySpace_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneCameraShakeSection.__PropertyOffset_UserDefinedPlaySpace_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneCameraShakeSection.__PropertyOffset_UserDefinedPlaySpace_DEPRECATED) = value;
			}
		}

		// Token: 0x06022281 RID: 139905 RVA: 0x00328176 File Offset: 0x00326376
		static UMovieSceneCameraShakeSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneCameraShakeSection");
		}

		// Token: 0x06022282 RID: 139906 RVA: 0x00328184 File Offset: 0x00326384
		protected UMovieSceneCameraShakeSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040123AD RID: 74669
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneCameraShakeSection";

		// Token: 0x040123AE RID: 74670
		private static IntPtr _ClassPtr;

		// Token: 0x040123AF RID: 74671
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040123B0 RID: 74672
		internal static int __PropertyOffset_ShakeData;

		// Token: 0x040123B1 RID: 74673
		[Nullable(2)]
		private FMovieSceneCameraShakeSectionData _ShakeData;

		// Token: 0x040123B2 RID: 74674
		internal static int __PropertyOffset_ShakeClass_DEPRECATED;

		// Token: 0x040123B3 RID: 74675
		internal static int __PropertyOffset_PlayScale_DEPRECATED;

		// Token: 0x040123B4 RID: 74676
		internal static int __PropertyOffset_PlaySpace_DEPRECATED;

		// Token: 0x040123B5 RID: 74677
		internal static int __PropertyOffset_UserDefinedPlaySpace_DEPRECATED;
	}
}
