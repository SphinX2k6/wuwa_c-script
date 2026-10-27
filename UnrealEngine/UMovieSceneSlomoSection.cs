using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023AA RID: 9130
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneSlomoSection")]
	[UnrealStructLayout(464, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class UMovieSceneSlomoSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022630 RID: 140848 RVA: 0x0032DB8E File Offset: 0x0032BD8E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneSlomoSection._ClassPtr;
		}

		// Token: 0x06022631 RID: 140849 RVA: 0x0032DB9C File Offset: 0x0032BD9C
		public UMovieSceneSlomoSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSlomoSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022632 RID: 140850 RVA: 0x0032DBC4 File Offset: 0x0032BDC4
		public UMovieSceneSlomoSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSlomoSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700848B RID: 33931
		// (get) Token: 0x06022633 RID: 140851 RVA: 0x0032DBF8 File Offset: 0x0032BDF8
		// (set) Token: 0x06022634 RID: 140852 RVA: 0x0032DC31 File Offset: 0x0032BE31
		public FMovieSceneFloatChannel FloatCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._FloatCurve) == null)
				{
					result = (this._FloatCurve = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)UMovieSceneSlomoSection.__PropertyOffset_FloatCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneSlomoSection.__PropertyOffset_FloatCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06022635 RID: 140853 RVA: 0x0032DC52 File Offset: 0x0032BE52
		static UMovieSceneSlomoSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneSlomoSection");
		}

		// Token: 0x06022636 RID: 140854 RVA: 0x0032DC60 File Offset: 0x0032BE60
		protected UMovieSceneSlomoSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040125B9 RID: 75193
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneSlomoSection";

		// Token: 0x040125BA RID: 75194
		private static IntPtr _ClassPtr;

		// Token: 0x040125BB RID: 75195
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040125BC RID: 75196
		internal static int __PropertyOffset_FloatCurve;

		// Token: 0x040125BD RID: 75197
		[Nullable(2)]
		private FMovieSceneFloatChannel _FloatCurve;
	}
}
