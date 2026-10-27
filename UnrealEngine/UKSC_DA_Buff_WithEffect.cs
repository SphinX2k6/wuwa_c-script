using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D87 RID: 7559
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_WithEffect")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class UKSC_DA_Buff_WithEffect : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CF10 RID: 118544 RVA: 0x002AC789 File Offset: 0x002AA989
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_WithEffect._ClassPtr;
		}

		// Token: 0x0601CF11 RID: 118545 RVA: 0x002AC798 File Offset: 0x002AA998
		public UKSC_DA_Buff_WithEffect() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_WithEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CF12 RID: 118546 RVA: 0x002AC7C0 File Offset: 0x002AA9C0
		public UKSC_DA_Buff_WithEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_WithEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170074BB RID: 29883
		// (get) Token: 0x0601CF13 RID: 118547 RVA: 0x002AC7F3 File Offset: 0x002AA9F3
		// (set) Token: 0x0601CF14 RID: 118548 RVA: 0x002AC803 File Offset: 0x002AAA03
		public unsafe float Period
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_WithEffect.__PropertyOffset_Period);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_WithEffect.__PropertyOffset_Period) = value;
			}
		}

		// Token: 0x170074BC RID: 29884
		// (get) Token: 0x0601CF15 RID: 118549 RVA: 0x002AC814 File Offset: 0x002AAA14
		// (set) Token: 0x0601CF16 RID: 118550 RVA: 0x002AC824 File Offset: 0x002AAA24
		public unsafe bool PeriodImmediately
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_WithEffect.__PropertyOffset_PeriodImmediately) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_WithEffect.__PropertyOffset_PeriodImmediately) = (value ? 1 : 0);
			}
		}

		// Token: 0x170074BD RID: 29885
		// (get) Token: 0x0601CF17 RID: 118551 RVA: 0x002AC835 File Offset: 0x002AAA35
		// (set) Token: 0x0601CF18 RID: 118552 RVA: 0x002AC845 File Offset: 0x002AAA45
		public unsafe int MaxStack
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_WithEffect.__PropertyOffset_MaxStack);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_WithEffect.__PropertyOffset_MaxStack) = value;
			}
		}

		// Token: 0x170074BE RID: 29886
		// (get) Token: 0x0601CF19 RID: 118553 RVA: 0x002AC856 File Offset: 0x002AAA56
		// (set) Token: 0x0601CF1A RID: 118554 RVA: 0x002AC866 File Offset: 0x002AAA66
		public unsafe int DefaultStack
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_WithEffect.__PropertyOffset_DefaultStack);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_WithEffect.__PropertyOffset_DefaultStack) = value;
			}
		}

		// Token: 0x170074BF RID: 29887
		// (get) Token: 0x0601CF1B RID: 118555 RVA: 0x002AC878 File Offset: 0x002AAA78
		// (set) Token: 0x0601CF1C RID: 118556 RVA: 0x002AC8B1 File Offset: 0x002AAAB1
		public TArray<UKSC_DA_BuffEffectBase> AdditionalEffects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKSC_DA_BuffEffectBase> result;
				if ((result = this._AdditionalEffects) == null)
				{
					result = (this._AdditionalEffects = new TArray<UKSC_DA_BuffEffectBase>(base.NativePtr + (IntPtr)UKSC_DA_Buff_WithEffect.__PropertyOffset_AdditionalEffects, this));
				}
				return result;
			}
			set
			{
				this.AdditionalEffects.CopyAssign(value);
			}
		}

		// Token: 0x170074C0 RID: 29888
		// (get) Token: 0x0601CF1D RID: 118557 RVA: 0x002AC8BF File Offset: 0x002AAABF
		// (set) Token: 0x0601CF1E RID: 118558 RVA: 0x002AC8CF File Offset: 0x002AAACF
		public unsafe bool ImmuneEntityTimeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_WithEffect.__PropertyOffset_ImmuneEntityTimeScale) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_WithEffect.__PropertyOffset_ImmuneEntityTimeScale) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601CF1F RID: 118559 RVA: 0x002AC8E0 File Offset: 0x002AAAE0
		static UKSC_DA_Buff_WithEffect()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_WithEffect");
		}

		// Token: 0x0601CF20 RID: 118560 RVA: 0x002AC8EE File Offset: 0x002AAAEE
		protected UKSC_DA_Buff_WithEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FB4E RID: 64334
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_WithEffect";

		// Token: 0x0400FB4F RID: 64335
		private static IntPtr _ClassPtr;

		// Token: 0x0400FB50 RID: 64336
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FB51 RID: 64337
		internal static int __PropertyOffset_Period;

		// Token: 0x0400FB52 RID: 64338
		internal static int __PropertyOffset_PeriodImmediately;

		// Token: 0x0400FB53 RID: 64339
		internal static int __PropertyOffset_MaxStack;

		// Token: 0x0400FB54 RID: 64340
		internal static int __PropertyOffset_DefaultStack;

		// Token: 0x0400FB55 RID: 64341
		internal static int __PropertyOffset_AdditionalEffects;

		// Token: 0x0400FB56 RID: 64342
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKSC_DA_BuffEffectBase> _AdditionalEffects;

		// Token: 0x0400FB57 RID: 64343
		internal static int __PropertyOffset_ImmuneEntityTimeScale;
	}
}
