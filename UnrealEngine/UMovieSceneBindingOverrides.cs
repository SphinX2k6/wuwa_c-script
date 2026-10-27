using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023D6 RID: 9174
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneBindingOverrides")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UMovieSceneBindingOverrides : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602276B RID: 141163 RVA: 0x0032F822 File Offset: 0x0032DA22
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneBindingOverrides._ClassPtr;
		}

		// Token: 0x0602276C RID: 141164 RVA: 0x0032F830 File Offset: 0x0032DA30
		public UMovieSceneBindingOverrides() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneBindingOverrides.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602276D RID: 141165 RVA: 0x0032F858 File Offset: 0x0032DA58
		public UMovieSceneBindingOverrides(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneBindingOverrides.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170084C1 RID: 33985
		// (get) Token: 0x0602276E RID: 141166 RVA: 0x0032F88C File Offset: 0x0032DA8C
		// (set) Token: 0x0602276F RID: 141167 RVA: 0x0032F8C5 File Offset: 0x0032DAC5
		public TArray<FMovieSceneBindingOverrideData> BindingData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMovieSceneBindingOverrideData> result;
				if ((result = this._BindingData) == null)
				{
					result = (this._BindingData = new TArray<FMovieSceneBindingOverrideData>(base.NativePtr + (IntPtr)UMovieSceneBindingOverrides.__PropertyOffset_BindingData, this));
				}
				return result;
			}
			set
			{
				this.BindingData.CopyAssign(value);
			}
		}

		// Token: 0x06022770 RID: 141168 RVA: 0x0032F8D3 File Offset: 0x0032DAD3
		static UMovieSceneBindingOverrides()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneBindingOverrides");
		}

		// Token: 0x06022771 RID: 141169 RVA: 0x0032F8E1 File Offset: 0x0032DAE1
		protected UMovieSceneBindingOverrides(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040126B8 RID: 75448
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneBindingOverrides";

		// Token: 0x040126B9 RID: 75449
		private static IntPtr _ClassPtr;

		// Token: 0x040126BA RID: 75450
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040126BB RID: 75451
		internal static int __PropertyOffset_BindingData;

		// Token: 0x040126BC RID: 75452
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneBindingOverrideData> _BindingData;
	}
}
