using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200186F RID: 6255
	[UnrealObjectPath("/Script/KuroGamepadFeedbackSequenceRuntime.KuroMovieSceneGamepadForceFeedbackTrack")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UKuroMovieSceneGamepadForceFeedbackTrack : UMovieSceneTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060170AA RID: 94378 RVA: 0x0021941E File Offset: 0x0021761E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroMovieSceneGamepadForceFeedbackTrack._ClassPtr;
		}

		// Token: 0x060170AB RID: 94379 RVA: 0x0021942A File Offset: 0x0021762A
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UKuroMovieSceneGamepadForceFeedbackTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x060170AC RID: 94380 RVA: 0x00219434 File Offset: 0x00217634
		public UKuroMovieSceneGamepadForceFeedbackTrack() : this(BuiltinUtils.AllocNativeUObject(UKuroMovieSceneGamepadForceFeedbackTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060170AD RID: 94381 RVA: 0x0021945C File Offset: 0x0021765C
		[NullableContext(1)]
		public UKuroMovieSceneGamepadForceFeedbackTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroMovieSceneGamepadForceFeedbackTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005CAC RID: 23724
		// (get) Token: 0x060170AE RID: 94382 RVA: 0x00219490 File Offset: 0x00217690
		// (set) Token: 0x060170AF RID: 94383 RVA: 0x002194C9 File Offset: 0x002176C9
		[Nullable(1)]
		public TArray<UMovieSceneSection> Sections
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMovieSceneSection> result;
				if ((result = this._Sections) == null)
				{
					result = (this._Sections = new TArray<UMovieSceneSection>(base.NativePtr + (IntPtr)UKuroMovieSceneGamepadForceFeedbackTrack.__PropertyOffset_Sections, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Sections.CopyAssign(value);
			}
		}

		// Token: 0x17005CAD RID: 23725
		// (get) Token: 0x060170B0 RID: 94384 RVA: 0x002194D7 File Offset: 0x002176D7
		// (set) Token: 0x060170B1 RID: 94385 RVA: 0x002194E7 File Offset: 0x002176E7
		public unsafe bool bIsAMasterTrack
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMovieSceneGamepadForceFeedbackTrack.__PropertyOffset_bIsAMasterTrack) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMovieSceneGamepadForceFeedbackTrack.__PropertyOffset_bIsAMasterTrack) = (value ? 1 : 0);
			}
		}

		// Token: 0x060170B2 RID: 94386 RVA: 0x002194F8 File Offset: 0x002176F8
		static UKuroMovieSceneGamepadForceFeedbackTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGamepadFeedbackSequenceRuntime.KuroMovieSceneGamepadForceFeedbackTrack");
		}

		// Token: 0x060170B3 RID: 94387 RVA: 0x00219506 File Offset: 0x00217706
		protected UKuroMovieSceneGamepadForceFeedbackTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C80D RID: 51213
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x0400C80E RID: 51214
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGamepadFeedbackSequenceRuntime.KuroMovieSceneGamepadForceFeedbackTrack";

		// Token: 0x0400C80F RID: 51215
		private static IntPtr _ClassPtr;

		// Token: 0x0400C810 RID: 51216
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C811 RID: 51217
		internal static int __PropertyOffset_Sections;

		// Token: 0x0400C812 RID: 51218
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _Sections;

		// Token: 0x0400C813 RID: 51219
		internal static int __PropertyOffset_bIsAMasterTrack;
	}
}
