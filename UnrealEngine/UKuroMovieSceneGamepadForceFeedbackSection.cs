using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200186D RID: 6253
	[UnrealObjectPath("/Script/KuroGamepadFeedbackSequenceRuntime.KuroMovieSceneGamepadForceFeedbackSection")]
	[UnrealStructLayout(384, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 384)]
	public class UKuroMovieSceneGamepadForceFeedbackSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601708F RID: 94351 RVA: 0x0021922A File Offset: 0x0021742A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroMovieSceneGamepadForceFeedbackSection._ClassPtr;
		}

		// Token: 0x06017090 RID: 94352 RVA: 0x00219238 File Offset: 0x00217438
		public UKuroMovieSceneGamepadForceFeedbackSection() : this(BuiltinUtils.AllocNativeUObject(UKuroMovieSceneGamepadForceFeedbackSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017091 RID: 94353 RVA: 0x00219260 File Offset: 0x00217460
		[NullableContext(1)]
		public UKuroMovieSceneGamepadForceFeedbackSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroMovieSceneGamepadForceFeedbackSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005CA5 RID: 23717
		// (get) Token: 0x06017092 RID: 94354 RVA: 0x00219293 File Offset: 0x00217493
		// (set) Token: 0x06017093 RID: 94355 RVA: 0x002192A7 File Offset: 0x002174A7
		[Nullable(2)]
		public unsafe UKuroForceFeedbackEffect GamepadForceFeedbackEffect
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroForceFeedbackEffect>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroMovieSceneGamepadForceFeedbackSection.__PropertyOffset_GamepadForceFeedbackEffect);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroMovieSceneGamepadForceFeedbackSection.__PropertyOffset_GamepadForceFeedbackEffect, value);
			}
		}

		// Token: 0x17005CA6 RID: 23718
		// (get) Token: 0x06017094 RID: 94356 RVA: 0x002192BC File Offset: 0x002174BC
		// (set) Token: 0x06017095 RID: 94357 RVA: 0x002192CC File Offset: 0x002174CC
		public unsafe float FadeInTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMovieSceneGamepadForceFeedbackSection.__PropertyOffset_FadeInTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMovieSceneGamepadForceFeedbackSection.__PropertyOffset_FadeInTime) = value;
			}
		}

		// Token: 0x17005CA7 RID: 23719
		// (get) Token: 0x06017096 RID: 94358 RVA: 0x002192DD File Offset: 0x002174DD
		// (set) Token: 0x06017097 RID: 94359 RVA: 0x002192ED File Offset: 0x002174ED
		public unsafe EEasingType FadeInEasingType
		{
			get
			{
				return (EEasingType)(*(base.NativePtr + (IntPtr)UKuroMovieSceneGamepadForceFeedbackSection.__PropertyOffset_FadeInEasingType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMovieSceneGamepadForceFeedbackSection.__PropertyOffset_FadeInEasingType) = (byte)value;
			}
		}

		// Token: 0x17005CA8 RID: 23720
		// (get) Token: 0x06017098 RID: 94360 RVA: 0x002192FE File Offset: 0x002174FE
		// (set) Token: 0x06017099 RID: 94361 RVA: 0x0021930E File Offset: 0x0021750E
		public unsafe float FadeOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMovieSceneGamepadForceFeedbackSection.__PropertyOffset_FadeOutTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMovieSceneGamepadForceFeedbackSection.__PropertyOffset_FadeOutTime) = value;
			}
		}

		// Token: 0x17005CA9 RID: 23721
		// (get) Token: 0x0601709A RID: 94362 RVA: 0x0021931F File Offset: 0x0021751F
		// (set) Token: 0x0601709B RID: 94363 RVA: 0x0021932F File Offset: 0x0021752F
		public unsafe EEasingType FadeOutEasingType
		{
			get
			{
				return (EEasingType)(*(base.NativePtr + (IntPtr)UKuroMovieSceneGamepadForceFeedbackSection.__PropertyOffset_FadeOutEasingType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMovieSceneGamepadForceFeedbackSection.__PropertyOffset_FadeOutEasingType) = (byte)value;
			}
		}

		// Token: 0x17005CAA RID: 23722
		// (get) Token: 0x0601709C RID: 94364 RVA: 0x00219340 File Offset: 0x00217540
		// (set) Token: 0x0601709D RID: 94365 RVA: 0x00219350 File Offset: 0x00217550
		public unsafe float Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMovieSceneGamepadForceFeedbackSection.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMovieSceneGamepadForceFeedbackSection.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x0601709E RID: 94366 RVA: 0x00219361 File Offset: 0x00217561
		static UKuroMovieSceneGamepadForceFeedbackSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGamepadFeedbackSequenceRuntime.KuroMovieSceneGamepadForceFeedbackSection");
		}

		// Token: 0x0601709F RID: 94367 RVA: 0x0021936F File Offset: 0x0021756F
		protected UKuroMovieSceneGamepadForceFeedbackSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C801 RID: 51201
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGamepadFeedbackSequenceRuntime.KuroMovieSceneGamepadForceFeedbackSection";

		// Token: 0x0400C802 RID: 51202
		private static IntPtr _ClassPtr;

		// Token: 0x0400C803 RID: 51203
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C804 RID: 51204
		internal static int __PropertyOffset_GamepadForceFeedbackEffect;

		// Token: 0x0400C805 RID: 51205
		internal static int __PropertyOffset_FadeInTime;

		// Token: 0x0400C806 RID: 51206
		internal static int __PropertyOffset_FadeInEasingType;

		// Token: 0x0400C807 RID: 51207
		internal static int __PropertyOffset_FadeOutTime;

		// Token: 0x0400C808 RID: 51208
		internal static int __PropertyOffset_FadeOutEasingType;

		// Token: 0x0400C809 RID: 51209
		internal static int __PropertyOffset_Scale;
	}
}
