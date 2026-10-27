using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200239D RID: 9117
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieScenePrimitiveMaterialSection")]
	[UnrealStructLayout(504, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 504)]
	public class UMovieScenePrimitiveMaterialSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022572 RID: 140658 RVA: 0x0032C92A File Offset: 0x0032AB2A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieScenePrimitiveMaterialSection._ClassPtr;
		}

		// Token: 0x06022573 RID: 140659 RVA: 0x0032C938 File Offset: 0x0032AB38
		public UMovieScenePrimitiveMaterialSection() : this(BuiltinUtils.AllocNativeUObject(UMovieScenePrimitiveMaterialSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022574 RID: 140660 RVA: 0x0032C960 File Offset: 0x0032AB60
		public UMovieScenePrimitiveMaterialSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieScenePrimitiveMaterialSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008454 RID: 33876
		// (get) Token: 0x06022575 RID: 140661 RVA: 0x0032C994 File Offset: 0x0032AB94
		// (set) Token: 0x06022576 RID: 140662 RVA: 0x0032C9CD File Offset: 0x0032ABCD
		public FMovieSceneObjectPathChannel MaterialChannel
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneObjectPathChannel result;
				if ((result = this._MaterialChannel) == null)
				{
					result = (this._MaterialChannel = new FMovieSceneObjectPathChannel(base.NativePtr + (IntPtr)UMovieScenePrimitiveMaterialSection.__PropertyOffset_MaterialChannel, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneObjectPathChannel.StaticStruct(), base.NativePtr + (IntPtr)UMovieScenePrimitiveMaterialSection.__PropertyOffset_MaterialChannel, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06022577 RID: 140663 RVA: 0x0032C9EE File Offset: 0x0032ABEE
		static UMovieScenePrimitiveMaterialSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieScenePrimitiveMaterialSection");
		}

		// Token: 0x06022578 RID: 140664 RVA: 0x0032C9FC File Offset: 0x0032ABFC
		protected UMovieScenePrimitiveMaterialSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401254D RID: 75085
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieScenePrimitiveMaterialSection";

		// Token: 0x0401254E RID: 75086
		private static IntPtr _ClassPtr;

		// Token: 0x0401254F RID: 75087
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012550 RID: 75088
		internal static int __PropertyOffset_MaterialChannel;

		// Token: 0x04012551 RID: 75089
		[Nullable(2)]
		private FMovieSceneObjectPathChannel _MaterialChannel;
	}
}
