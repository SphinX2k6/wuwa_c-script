using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002903 RID: 10499
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/TemplateSequence.SequenceCameraShake")]
	[UnrealStructLayout(224, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class USequenceCameraShake : UCameraShakeBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026F19 RID: 159513 RVA: 0x003B65D2 File Offset: 0x003B47D2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USequenceCameraShake._ClassPtr;
		}

		// Token: 0x06026F1A RID: 159514 RVA: 0x003B65E0 File Offset: 0x003B47E0
		public USequenceCameraShake() : this(BuiltinUtils.AllocNativeUObject(USequenceCameraShake.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026F1B RID: 159515 RVA: 0x003B6608 File Offset: 0x003B4808
		[NullableContext(1)]
		public USequenceCameraShake(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USequenceCameraShake.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170095F7 RID: 38391
		// (get) Token: 0x06026F1C RID: 159516 RVA: 0x003B663B File Offset: 0x003B483B
		// (set) Token: 0x06026F1D RID: 159517 RVA: 0x003B664F File Offset: 0x003B484F
		public unsafe UCameraAnimationSequence Sequence
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCameraAnimationSequence>(base.NativePtr / (IntPtr)sizeof(void*) + USequenceCameraShake.__PropertyOffset_Sequence);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USequenceCameraShake.__PropertyOffset_Sequence, value);
			}
		}

		// Token: 0x170095F8 RID: 38392
		// (get) Token: 0x06026F1E RID: 159518 RVA: 0x003B6664 File Offset: 0x003B4864
		// (set) Token: 0x06026F1F RID: 159519 RVA: 0x003B6674 File Offset: 0x003B4874
		public unsafe float PlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USequenceCameraShake.__PropertyOffset_PlayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USequenceCameraShake.__PropertyOffset_PlayRate) = value;
			}
		}

		// Token: 0x170095F9 RID: 38393
		// (get) Token: 0x06026F20 RID: 159520 RVA: 0x003B6685 File Offset: 0x003B4885
		// (set) Token: 0x06026F21 RID: 159521 RVA: 0x003B6695 File Offset: 0x003B4895
		public unsafe float Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USequenceCameraShake.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USequenceCameraShake.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x170095FA RID: 38394
		// (get) Token: 0x06026F22 RID: 159522 RVA: 0x003B66A6 File Offset: 0x003B48A6
		// (set) Token: 0x06026F23 RID: 159523 RVA: 0x003B66B6 File Offset: 0x003B48B6
		public unsafe float BlendInTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USequenceCameraShake.__PropertyOffset_BlendInTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USequenceCameraShake.__PropertyOffset_BlendInTime) = value;
			}
		}

		// Token: 0x170095FB RID: 38395
		// (get) Token: 0x06026F24 RID: 159524 RVA: 0x003B66C7 File Offset: 0x003B48C7
		// (set) Token: 0x06026F25 RID: 159525 RVA: 0x003B66D7 File Offset: 0x003B48D7
		public unsafe float BlendOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USequenceCameraShake.__PropertyOffset_BlendOutTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USequenceCameraShake.__PropertyOffset_BlendOutTime) = value;
			}
		}

		// Token: 0x170095FC RID: 38396
		// (get) Token: 0x06026F26 RID: 159526 RVA: 0x003B66E8 File Offset: 0x003B48E8
		// (set) Token: 0x06026F27 RID: 159527 RVA: 0x003B66F8 File Offset: 0x003B48F8
		public unsafe float RandomSegmentDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USequenceCameraShake.__PropertyOffset_RandomSegmentDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USequenceCameraShake.__PropertyOffset_RandomSegmentDuration) = value;
			}
		}

		// Token: 0x170095FD RID: 38397
		// (get) Token: 0x06026F28 RID: 159528 RVA: 0x003B6709 File Offset: 0x003B4909
		// (set) Token: 0x06026F29 RID: 159529 RVA: 0x003B6719 File Offset: 0x003B4919
		public unsafe bool bRandomSegment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USequenceCameraShake.__PropertyOffset_bRandomSegment) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USequenceCameraShake.__PropertyOffset_bRandomSegment) = (value ? 1 : 0);
			}
		}

		// Token: 0x170095FE RID: 38398
		// (get) Token: 0x06026F2A RID: 159530 RVA: 0x003B672A File Offset: 0x003B492A
		// (set) Token: 0x06026F2B RID: 159531 RVA: 0x003B673E File Offset: 0x003B493E
		public unsafe USequenceCameraShakeSequencePlayer Player
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USequenceCameraShakeSequencePlayer>(base.NativePtr / (IntPtr)sizeof(void*) + USequenceCameraShake.__PropertyOffset_Player);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USequenceCameraShake.__PropertyOffset_Player, value);
			}
		}

		// Token: 0x170095FF RID: 38399
		// (get) Token: 0x06026F2C RID: 159532 RVA: 0x003B6753 File Offset: 0x003B4953
		// (set) Token: 0x06026F2D RID: 159533 RVA: 0x003B6767 File Offset: 0x003B4967
		public unsafe USequenceCameraShakeCameraStandIn CameraStandIn
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USequenceCameraShakeCameraStandIn>(base.NativePtr / (IntPtr)sizeof(void*) + USequenceCameraShake.__PropertyOffset_CameraStandIn);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USequenceCameraShake.__PropertyOffset_CameraStandIn, value);
			}
		}

		// Token: 0x06026F2E RID: 159534 RVA: 0x003B677C File Offset: 0x003B497C
		static USequenceCameraShake()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/TemplateSequence.SequenceCameraShake");
		}

		// Token: 0x06026F2F RID: 159535 RVA: 0x003B678A File Offset: 0x003B498A
		protected USequenceCameraShake(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040155F8 RID: 87544
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/TemplateSequence.SequenceCameraShake";

		// Token: 0x040155F9 RID: 87545
		private static IntPtr _ClassPtr;

		// Token: 0x040155FA RID: 87546
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040155FB RID: 87547
		internal static int __PropertyOffset_Sequence;

		// Token: 0x040155FC RID: 87548
		internal static int __PropertyOffset_PlayRate;

		// Token: 0x040155FD RID: 87549
		internal static int __PropertyOffset_Scale;

		// Token: 0x040155FE RID: 87550
		internal static int __PropertyOffset_BlendInTime;

		// Token: 0x040155FF RID: 87551
		internal static int __PropertyOffset_BlendOutTime;

		// Token: 0x04015600 RID: 87552
		internal static int __PropertyOffset_RandomSegmentDuration;

		// Token: 0x04015601 RID: 87553
		internal static int __PropertyOffset_bRandomSegment;

		// Token: 0x04015602 RID: 87554
		internal static int __PropertyOffset_Player;

		// Token: 0x04015603 RID: 87555
		internal static int __PropertyOffset_CameraStandIn;
	}
}
