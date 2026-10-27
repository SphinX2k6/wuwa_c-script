using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002364 RID: 9060
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneComponentMultipleMaterialsTrack")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UMovieSceneComponentMultipleMaterialsTrack : UMovieSceneMaterialTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06022367 RID: 140135 RVA: 0x003297A8 File Offset: 0x003279A8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneComponentMultipleMaterialsTrack._ClassPtr;
		}

		// Token: 0x06022368 RID: 140136 RVA: 0x003297B4 File Offset: 0x003279B4
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneComponentMultipleMaterialsTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x06022369 RID: 140137 RVA: 0x003297BC File Offset: 0x003279BC
		public UMovieSceneComponentMultipleMaterialsTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneComponentMultipleMaterialsTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602236A RID: 140138 RVA: 0x003297E4 File Offset: 0x003279E4
		[NullableContext(1)]
		public UMovieSceneComponentMultipleMaterialsTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneComponentMultipleMaterialsTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008412 RID: 33810
		// (get) Token: 0x0602236B RID: 140139 RVA: 0x00329818 File Offset: 0x00327A18
		// (set) Token: 0x0602236C RID: 140140 RVA: 0x00329851 File Offset: 0x00327A51
		[Nullable(1)]
		public TArray<int> MaterialIndices
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._MaterialIndices) == null)
				{
					result = (this._MaterialIndices = new TArray<int>(base.NativePtr + (IntPtr)UMovieSceneComponentMultipleMaterialsTrack.__PropertyOffset_MaterialIndices, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MaterialIndices.CopyAssign(value);
			}
		}

		// Token: 0x0602236D RID: 140141 RVA: 0x0032985F File Offset: 0x00327A5F
		static UMovieSceneComponentMultipleMaterialsTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneComponentMultipleMaterialsTrack");
		}

		// Token: 0x0602236E RID: 140142 RVA: 0x0032986D File Offset: 0x00327A6D
		protected UMovieSceneComponentMultipleMaterialsTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012432 RID: 74802
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x04012433 RID: 74803
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneComponentMultipleMaterialsTrack";

		// Token: 0x04012434 RID: 74804
		private static IntPtr _ClassPtr;

		// Token: 0x04012435 RID: 74805
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012436 RID: 74806
		internal static int __PropertyOffset_MaterialIndices;

		// Token: 0x04012437 RID: 74807
		[Nullable(2)]
		private TArray<int> _MaterialIndices;
	}
}
