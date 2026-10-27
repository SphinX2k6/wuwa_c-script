using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BC3 RID: 7107
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroSplineMaskActor")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class AKuroSplineMaskActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B460 RID: 111712 RVA: 0x0028302F File Offset: 0x0028122F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroSplineMaskActor._ClassPtr;
		}

		// Token: 0x0601B461 RID: 111713 RVA: 0x0028303C File Offset: 0x0028123C
		public AKuroSplineMaskActor() : this(BuiltinUtils.AllocNativeUObject(AKuroSplineMaskActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B462 RID: 111714 RVA: 0x00283064 File Offset: 0x00281264
		[NullableContext(1)]
		public AKuroSplineMaskActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroSplineMaskActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006D8E RID: 28046
		// (get) Token: 0x0601B463 RID: 111715 RVA: 0x00283097 File Offset: 0x00281297
		// (set) Token: 0x0601B464 RID: 111716 RVA: 0x002830AB File Offset: 0x002812AB
		public unsafe ACameraActor CameraActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ACameraActor>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroSplineMaskActor.__PropertyOffset_CameraActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroSplineMaskActor.__PropertyOffset_CameraActor, value);
			}
		}

		// Token: 0x17006D8F RID: 28047
		// (get) Token: 0x0601B465 RID: 111717 RVA: 0x002830C0 File Offset: 0x002812C0
		// (set) Token: 0x0601B466 RID: 111718 RVA: 0x002830D4 File Offset: 0x002812D4
		public unsafe UTextureRenderTarget2D DataRT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroSplineMaskActor.__PropertyOffset_DataRT);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroSplineMaskActor.__PropertyOffset_DataRT, value);
			}
		}

		// Token: 0x17006D90 RID: 28048
		// (get) Token: 0x0601B467 RID: 111719 RVA: 0x002830E9 File Offset: 0x002812E9
		// (set) Token: 0x0601B468 RID: 111720 RVA: 0x002830F9 File Offset: 0x002812F9
		public unsafe int SampleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSplineMaskActor.__PropertyOffset_SampleCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSplineMaskActor.__PropertyOffset_SampleCount) = value;
			}
		}

		// Token: 0x17006D91 RID: 28049
		// (get) Token: 0x0601B469 RID: 111721 RVA: 0x0028310A File Offset: 0x0028130A
		// (set) Token: 0x0601B46A RID: 111722 RVA: 0x0028311A File Offset: 0x0028131A
		public unsafe float AspectRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSplineMaskActor.__PropertyOffset_AspectRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSplineMaskActor.__PropertyOffset_AspectRatio) = value;
			}
		}

		// Token: 0x17006D92 RID: 28050
		// (get) Token: 0x0601B46B RID: 111723 RVA: 0x0028312B File Offset: 0x0028132B
		// (set) Token: 0x0601B46C RID: 111724 RVA: 0x0028313F File Offset: 0x0028133F
		public unsafe USplineComponent Spline
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroSplineMaskActor.__PropertyOffset_Spline);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroSplineMaskActor.__PropertyOffset_Spline, value);
			}
		}

		// Token: 0x0601B46D RID: 111725 RVA: 0x00283154 File Offset: 0x00281354
		static AKuroSplineMaskActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroSplineMaskActor");
		}

		// Token: 0x0601B46E RID: 111726 RVA: 0x00283162 File Offset: 0x00281362
		protected AKuroSplineMaskActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EB01 RID: 60161
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroSplineMaskActor";

		// Token: 0x0400EB02 RID: 60162
		private static IntPtr _ClassPtr;

		// Token: 0x0400EB03 RID: 60163
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EB04 RID: 60164
		internal static int __PropertyOffset_CameraActor;

		// Token: 0x0400EB05 RID: 60165
		internal static int __PropertyOffset_DataRT;

		// Token: 0x0400EB06 RID: 60166
		internal static int __PropertyOffset_SampleCount;

		// Token: 0x0400EB07 RID: 60167
		internal static int __PropertyOffset_AspectRatio;

		// Token: 0x0400EB08 RID: 60168
		internal static int __PropertyOffset_Spline;
	}
}
