using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001135 RID: 4405
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SoundMix")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class USoundMix : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060101D7 RID: 66007 RVA: 0x0017BE0D File Offset: 0x0017A00D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundMix._ClassPtr;
		}

		// Token: 0x060101D8 RID: 66008 RVA: 0x0017BE1C File Offset: 0x0017A01C
		public USoundMix() : this(BuiltinUtils.AllocNativeUObject(USoundMix.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060101D9 RID: 66009 RVA: 0x0017BE44 File Offset: 0x0017A044
		public USoundMix(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USoundMix.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003F17 RID: 16151
		// (get) Token: 0x060101DA RID: 66010 RVA: 0x0017BE77 File Offset: 0x0017A077
		// (set) Token: 0x060101DB RID: 66011 RVA: 0x0017BE90 File Offset: 0x0017A090
		public unsafe bool bApplyEQ
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USoundMix.__PropertyOffset_bApplyEQ) & USoundMix.__PropertyMask_bApplyEQ) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USoundMix.__PropertyOffset_bApplyEQ) = ((*(base.NativePtr + (IntPtr)USoundMix.__PropertyOffset_bApplyEQ) & ~USoundMix.__PropertyMask_bApplyEQ) | (value ? USoundMix.__PropertyMask_bApplyEQ : 0));
			}
		}

		// Token: 0x17003F18 RID: 16152
		// (get) Token: 0x060101DC RID: 66012 RVA: 0x0017BEC0 File Offset: 0x0017A0C0
		// (set) Token: 0x060101DD RID: 66013 RVA: 0x0017BED0 File Offset: 0x0017A0D0
		public unsafe float EQPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundMix.__PropertyOffset_EQPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundMix.__PropertyOffset_EQPriority) = value;
			}
		}

		// Token: 0x17003F19 RID: 16153
		// (get) Token: 0x060101DE RID: 66014 RVA: 0x0017BEE4 File Offset: 0x0017A0E4
		// (set) Token: 0x060101DF RID: 66015 RVA: 0x0017BF1D File Offset: 0x0017A11D
		public FAudioEQEffect EQSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAudioEQEffect result;
				if ((result = this._EQSettings) == null)
				{
					result = (this._EQSettings = new FAudioEQEffect(base.NativePtr + (IntPtr)USoundMix.__PropertyOffset_EQSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAudioEQEffect.StaticStruct(), base.NativePtr + (IntPtr)USoundMix.__PropertyOffset_EQSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003F1A RID: 16154
		// (get) Token: 0x060101E0 RID: 66016 RVA: 0x0017BF40 File Offset: 0x0017A140
		// (set) Token: 0x060101E1 RID: 66017 RVA: 0x0017BF79 File Offset: 0x0017A179
		public TArray<FSoundClassAdjuster> SoundClassEffects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSoundClassAdjuster> result;
				if ((result = this._SoundClassEffects) == null)
				{
					result = (this._SoundClassEffects = new TArray<FSoundClassAdjuster>(base.NativePtr + (IntPtr)USoundMix.__PropertyOffset_SoundClassEffects, this));
				}
				return result;
			}
			set
			{
				this.SoundClassEffects.CopyAssign(value);
			}
		}

		// Token: 0x17003F1B RID: 16155
		// (get) Token: 0x060101E2 RID: 66018 RVA: 0x0017BF87 File Offset: 0x0017A187
		// (set) Token: 0x060101E3 RID: 66019 RVA: 0x0017BF97 File Offset: 0x0017A197
		public unsafe float InitialDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundMix.__PropertyOffset_InitialDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundMix.__PropertyOffset_InitialDelay) = value;
			}
		}

		// Token: 0x17003F1C RID: 16156
		// (get) Token: 0x060101E4 RID: 66020 RVA: 0x0017BFA8 File Offset: 0x0017A1A8
		// (set) Token: 0x060101E5 RID: 66021 RVA: 0x0017BFB8 File Offset: 0x0017A1B8
		public unsafe float FadeInTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundMix.__PropertyOffset_FadeInTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundMix.__PropertyOffset_FadeInTime) = value;
			}
		}

		// Token: 0x17003F1D RID: 16157
		// (get) Token: 0x060101E6 RID: 66022 RVA: 0x0017BFC9 File Offset: 0x0017A1C9
		// (set) Token: 0x060101E7 RID: 66023 RVA: 0x0017BFD9 File Offset: 0x0017A1D9
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundMix.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundMix.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x17003F1E RID: 16158
		// (get) Token: 0x060101E8 RID: 66024 RVA: 0x0017BFEA File Offset: 0x0017A1EA
		// (set) Token: 0x060101E9 RID: 66025 RVA: 0x0017BFFA File Offset: 0x0017A1FA
		public unsafe float FadeOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundMix.__PropertyOffset_FadeOutTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundMix.__PropertyOffset_FadeOutTime) = value;
			}
		}

		// Token: 0x060101EA RID: 66026 RVA: 0x0017C00B File Offset: 0x0017A20B
		static USoundMix()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SoundMix");
		}

		// Token: 0x060101EB RID: 66027 RVA: 0x0017C019 File Offset: 0x0017A219
		protected USoundMix(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008AAA RID: 35498
		public new const string __ObjectPath = "/Script/Engine.SoundMix";

		// Token: 0x04008AAB RID: 35499
		private static IntPtr _ClassPtr;

		// Token: 0x04008AAC RID: 35500
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008AAD RID: 35501
		internal static int __PropertyOffset_bApplyEQ;

		// Token: 0x04008AAE RID: 35502
		internal static byte __PropertyMask_bApplyEQ;

		// Token: 0x04008AAF RID: 35503
		internal static int __PropertyOffset_EQPriority;

		// Token: 0x04008AB0 RID: 35504
		internal static int __PropertyOffset_EQSettings;

		// Token: 0x04008AB1 RID: 35505
		[Nullable(2)]
		private FAudioEQEffect _EQSettings;

		// Token: 0x04008AB2 RID: 35506
		internal static int __PropertyOffset_SoundClassEffects;

		// Token: 0x04008AB3 RID: 35507
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoundClassAdjuster> _SoundClassEffects;

		// Token: 0x04008AB4 RID: 35508
		internal static int __PropertyOffset_InitialDelay;

		// Token: 0x04008AB5 RID: 35509
		internal static int __PropertyOffset_FadeInTime;

		// Token: 0x04008AB6 RID: 35510
		internal static int __PropertyOffset_Duration;

		// Token: 0x04008AB7 RID: 35511
		internal static int __PropertyOffset_FadeOutTime;
	}
}
