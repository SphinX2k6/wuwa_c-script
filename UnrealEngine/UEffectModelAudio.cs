using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200189B RID: 6299
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.EffectModelAudio")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class UEffectModelAudio : UEffectModelBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060172FD RID: 94973 RVA: 0x0021D286 File Offset: 0x0021B486
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEffectModelAudio._ClassPtr;
		}

		// Token: 0x060172FE RID: 94974 RVA: 0x0021D294 File Offset: 0x0021B494
		public UEffectModelAudio() : this(BuiltinUtils.AllocNativeUObject(UEffectModelAudio.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060172FF RID: 94975 RVA: 0x0021D2BC File Offset: 0x0021B4BC
		[NullableContext(1)]
		public UEffectModelAudio(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEffectModelAudio.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005D2B RID: 23851
		// (get) Token: 0x06017300 RID: 94976 RVA: 0x0021D2EF File Offset: 0x0021B4EF
		// (set) Token: 0x06017301 RID: 94977 RVA: 0x0021D303 File Offset: 0x0021B503
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

		// Token: 0x17005D2C RID: 23852
		// (get) Token: 0x06017302 RID: 94978 RVA: 0x0021D318 File Offset: 0x0021B518
		// (set) Token: 0x06017303 RID: 94979 RVA: 0x0021D351 File Offset: 0x0021B551
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

		// Token: 0x17005D2D RID: 23853
		// (get) Token: 0x06017304 RID: 94980 RVA: 0x0021D35F File Offset: 0x0021B55F
		// (set) Token: 0x06017305 RID: 94981 RVA: 0x0021D36F File Offset: 0x0021B56F
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

		// Token: 0x17005D2E RID: 23854
		// (get) Token: 0x06017306 RID: 94982 RVA: 0x0021D380 File Offset: 0x0021B580
		// (set) Token: 0x06017307 RID: 94983 RVA: 0x0021D390 File Offset: 0x0021B590
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

		// Token: 0x17005D2F RID: 23855
		// (get) Token: 0x06017308 RID: 94984 RVA: 0x0021D3A1 File Offset: 0x0021B5A1
		// (set) Token: 0x06017309 RID: 94985 RVA: 0x0021D3B1 File Offset: 0x0021B5B1
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

		// Token: 0x17005D30 RID: 23856
		// (get) Token: 0x0601730A RID: 94986 RVA: 0x0021D3C2 File Offset: 0x0021B5C2
		// (set) Token: 0x0601730B RID: 94987 RVA: 0x0021D3D2 File Offset: 0x0021B5D2
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

		// Token: 0x17005D31 RID: 23857
		// (get) Token: 0x0601730C RID: 94988 RVA: 0x0021D3E3 File Offset: 0x0021B5E3
		// (set) Token: 0x0601730D RID: 94989 RVA: 0x0021D3F7 File Offset: 0x0021B5F7
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

		// Token: 0x0601730E RID: 94990 RVA: 0x0021D40C File Offset: 0x0021B60C
		static UEffectModelAudio()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.EffectModelAudio");
		}

		// Token: 0x0601730F RID: 94991 RVA: 0x0021D41A File Offset: 0x0021B61A
		protected UEffectModelAudio(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C937 RID: 51511
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.EffectModelAudio";

		// Token: 0x0400C938 RID: 51512
		private static IntPtr _ClassPtr;

		// Token: 0x0400C939 RID: 51513
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C93A RID: 51514
		internal static int __PropertyOffset_AudioEvent;

		// Token: 0x0400C93B RID: 51515
		internal static int __PropertyOffset_LocationOffsets;

		// Token: 0x0400C93C RID: 51516
		private TArray<FVector> _LocationOffsets;

		// Token: 0x0400C93D RID: 51517
		internal static int __PropertyOffset_FadeOutTime;

		// Token: 0x0400C93E RID: 51518
		internal static int __PropertyOffset_FadeOutCurve;

		// Token: 0x0400C93F RID: 51519
		internal static int __PropertyOffset_KeepAlive;

		// Token: 0x0400C940 RID: 51520
		internal static int __PropertyOffset_EnableOcclusion;

		// Token: 0x0400C941 RID: 51521
		internal static int __PropertyOffset_TrailingAudioEvent;
	}
}
