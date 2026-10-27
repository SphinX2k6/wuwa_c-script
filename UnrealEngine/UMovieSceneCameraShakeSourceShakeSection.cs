using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200234F RID: 9039
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneCameraShakeSourceShakeSection")]
	[UnrealStructLayout(336, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 336)]
	public class UMovieSceneCameraShakeSourceShakeSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602229F RID: 139935 RVA: 0x003283F5 File Offset: 0x003265F5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneCameraShakeSourceShakeSection._ClassPtr;
		}

		// Token: 0x060222A0 RID: 139936 RVA: 0x00328404 File Offset: 0x00326604
		public UMovieSceneCameraShakeSourceShakeSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneCameraShakeSourceShakeSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060222A1 RID: 139937 RVA: 0x0032842C File Offset: 0x0032662C
		public UMovieSceneCameraShakeSourceShakeSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneCameraShakeSourceShakeSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170083F4 RID: 33780
		// (get) Token: 0x060222A2 RID: 139938 RVA: 0x00328460 File Offset: 0x00326660
		// (set) Token: 0x060222A3 RID: 139939 RVA: 0x00328499 File Offset: 0x00326699
		public FMovieSceneCameraShakeSectionData ShakeData
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneCameraShakeSectionData result;
				if ((result = this._ShakeData) == null)
				{
					result = (this._ShakeData = new FMovieSceneCameraShakeSectionData(base.NativePtr + (IntPtr)UMovieSceneCameraShakeSourceShakeSection.__PropertyOffset_ShakeData, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneCameraShakeSectionData.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneCameraShakeSourceShakeSection.__PropertyOffset_ShakeData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060222A4 RID: 139940 RVA: 0x003284BA File Offset: 0x003266BA
		static UMovieSceneCameraShakeSourceShakeSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneCameraShakeSourceShakeSection");
		}

		// Token: 0x060222A5 RID: 139941 RVA: 0x003284C8 File Offset: 0x003266C8
		protected UMovieSceneCameraShakeSourceShakeSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040123C2 RID: 74690
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneCameraShakeSourceShakeSection";

		// Token: 0x040123C3 RID: 74691
		private static IntPtr _ClassPtr;

		// Token: 0x040123C4 RID: 74692
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040123C5 RID: 74693
		internal static int __PropertyOffset_ShakeData;

		// Token: 0x040123C6 RID: 74694
		[Nullable(2)]
		private FMovieSceneCameraShakeSectionData _ShakeData;
	}
}
