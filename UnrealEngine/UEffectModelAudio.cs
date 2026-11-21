using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003BE RID: 958
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.EffectModelAudio")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class UEffectModelAudio : UEffectModelBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005DA8 RID: 23976 RVA: 0x00084722 File Offset: 0x00082922
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEffectModelAudio._ClassPtr;
		}

		// Token: 0x06005DA9 RID: 23977 RVA: 0x00084730 File Offset: 0x00082930
		public UEffectModelAudio() : this(BuiltinUtils.AllocNativeUObject(UEffectModelAudio.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005DAA RID: 23978 RVA: 0x00084758 File Offset: 0x00082958
		[NullableContext(1)]
		public UEffectModelAudio(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEffectModelAudio.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700126E RID: 4718
		// (get) Token: 0x06005DAB RID: 23979 RVA: 0x0008478B File Offset: 0x0008298B
		// (set) Token: 0x06005DAC RID: 23980 RVA: 0x0008479F File Offset: 0x0008299F
		public unsafe UAkAudioEvent AudioEvent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelAudio.__PropertyOffset_AudioEvent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelAudio.__PropertyOffset_AudioEvent, value);
			}
		}

		// Token: 0x1700126F RID: 4719
		// (get) Token: 0x06005DAD RID: 23981 RVA: 0x000847B4 File Offset: 0x000829B4
		// (set) Token: 0x06005DAE RID: 23982 RVA: 0x000847ED File Offset: 0x000829ED
		[Nullable(1)]
		public TArray<FVector> LocationOffsets
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._LocationOffsets) == null)
				{
					result = (this._LocationOffsets = new TArray<FVector>(base.NativePtr + (IntPtr)UEffectModelAudio.__PropertyOffset_LocationOffsets, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LocationOffsets.CopyAssign(value);
			}
		}

		// Token: 0x17001270 RID: 4720
		// (get) Token: 0x06005DAF RID: 23983 RVA: 0x000847FB File Offset: 0x000829FB
		// (set) Token: 0x06005DB0 RID: 23984 RVA: 0x0008480B File Offset: 0x00082A0B
		public unsafe int FadeOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelAudio.__PropertyOffset_FadeOutTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelAudio.__PropertyOffset_FadeOutTime) = value;
			}
		}

		// Token: 0x17001271 RID: 4721
		// (get) Token: 0x06005DB1 RID: 23985 RVA: 0x0008481C File Offset: 0x00082A1C
		// (set) Token: 0x06005DB2 RID: 23986 RVA: 0x0008482C File Offset: 0x00082A2C
		public unsafe EAudioFadeCurve FadeOutCurve
		{
			get
			{
				return (EAudioFadeCurve)(*(base.NativePtr + (IntPtr)UEffectModelAudio.__PropertyOffset_FadeOutCurve));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelAudio.__PropertyOffset_FadeOutCurve) = (byte)value;
			}
		}

		// Token: 0x17001272 RID: 4722
		// (get) Token: 0x06005DB3 RID: 23987 RVA: 0x0008483D File Offset: 0x00082A3D
		// (set) Token: 0x06005DB4 RID: 23988 RVA: 0x0008484D File Offset: 0x00082A4D
		public unsafe bool KeepAlive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelAudio.__PropertyOffset_KeepAlive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelAudio.__PropertyOffset_KeepAlive) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001273 RID: 4723
		// (get) Token: 0x06005DB5 RID: 23989 RVA: 0x0008485E File Offset: 0x00082A5E
		// (set) Token: 0x06005DB6 RID: 23990 RVA: 0x0008486E File Offset: 0x00082A6E
		public unsafe bool EnableOcclusion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelAudio.__PropertyOffset_EnableOcclusion) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelAudio.__PropertyOffset_EnableOcclusion) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001274 RID: 4724
		// (get) Token: 0x06005DB7 RID: 23991 RVA: 0x0008487F File Offset: 0x00082A7F
		// (set) Token: 0x06005DB8 RID: 23992 RVA: 0x00084893 File Offset: 0x00082A93
		public unsafe UAkAudioEvent TrailingAudioEvent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelAudio.__PropertyOffset_TrailingAudioEvent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelAudio.__PropertyOffset_TrailingAudioEvent, value);
			}
		}

		// Token: 0x06005DB9 RID: 23993 RVA: 0x000848A8 File Offset: 0x00082AA8
		static UEffectModelAudio()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.EffectModelAudio");
		}

		// Token: 0x06005DBA RID: 23994 RVA: 0x000848B6 File Offset: 0x00082AB6
		protected UEffectModelAudio(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002706 RID: 9990
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.EffectModelAudio";

		// Token: 0x04002707 RID: 9991
		private static IntPtr _ClassPtr;

		// Token: 0x04002708 RID: 9992
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002709 RID: 9993
		internal static int __PropertyOffset_AudioEvent;

		// Token: 0x0400270A RID: 9994
		internal static int __PropertyOffset_LocationOffsets;

		// Token: 0x0400270B RID: 9995
		private TArray<FVector> _LocationOffsets;

		// Token: 0x0400270C RID: 9996
		internal static int __PropertyOffset_FadeOutTime;

		// Token: 0x0400270D RID: 9997
		internal static int __PropertyOffset_FadeOutCurve;

		// Token: 0x0400270E RID: 9998
		internal static int __PropertyOffset_KeepAlive;

		// Token: 0x0400270F RID: 9999
		internal static int __PropertyOffset_EnableOcclusion;

		// Token: 0x04002710 RID: 10000
		internal static int __PropertyOffset_TrailingAudioEvent;
	}
}
