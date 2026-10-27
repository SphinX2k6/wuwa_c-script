using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002354 RID: 9044
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneCameraShakeSourceTriggerSection")]
	[UnrealStructLayout(440, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 440)]
	public class UMovieSceneCameraShakeSourceTriggerSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060222D8 RID: 139992 RVA: 0x0032898F File Offset: 0x00326B8F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneCameraShakeSourceTriggerSection._ClassPtr;
		}

		// Token: 0x060222D9 RID: 139993 RVA: 0x0032899C File Offset: 0x00326B9C
		public UMovieSceneCameraShakeSourceTriggerSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneCameraShakeSourceTriggerSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060222DA RID: 139994 RVA: 0x003289C4 File Offset: 0x00326BC4
		public UMovieSceneCameraShakeSourceTriggerSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneCameraShakeSourceTriggerSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170083FF RID: 33791
		// (get) Token: 0x060222DB RID: 139995 RVA: 0x003289F8 File Offset: 0x00326BF8
		// (set) Token: 0x060222DC RID: 139996 RVA: 0x00328A31 File Offset: 0x00326C31
		public FMovieSceneCameraShakeSourceTriggerChannel Channel
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneCameraShakeSourceTriggerChannel result;
				if ((result = this._Channel) == null)
				{
					result = (this._Channel = new FMovieSceneCameraShakeSourceTriggerChannel(base.NativePtr + (IntPtr)UMovieSceneCameraShakeSourceTriggerSection.__PropertyOffset_Channel, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneCameraShakeSourceTriggerChannel.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneCameraShakeSourceTriggerSection.__PropertyOffset_Channel, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060222DD RID: 139997 RVA: 0x00328A52 File Offset: 0x00326C52
		static UMovieSceneCameraShakeSourceTriggerSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneCameraShakeSourceTriggerSection");
		}

		// Token: 0x060222DE RID: 139998 RVA: 0x00328A60 File Offset: 0x00326C60
		protected UMovieSceneCameraShakeSourceTriggerSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040123E1 RID: 74721
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneCameraShakeSourceTriggerSection";

		// Token: 0x040123E2 RID: 74722
		private static IntPtr _ClassPtr;

		// Token: 0x040123E3 RID: 74723
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040123E4 RID: 74724
		internal static int __PropertyOffset_Channel;

		// Token: 0x040123E5 RID: 74725
		[Nullable(2)]
		private FMovieSceneCameraShakeSourceTriggerChannel _Channel;
	}
}
