using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200194B RID: 6475
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGAS.AbilityTask_WaitDelayForNextTick")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UAbilityTask_WaitDelayForNextTick : UAbilityTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017FF7 RID: 98295 RVA: 0x00233578 File Offset: 0x00231778
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilityTask_WaitDelayForNextTick._ClassPtr;
		}

		// Token: 0x06017FF8 RID: 98296 RVA: 0x00233584 File Offset: 0x00231784
		public UAbilityTask_WaitDelayForNextTick() : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitDelayForNextTick.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017FF9 RID: 98297 RVA: 0x002335AC File Offset: 0x002317AC
		public UAbilityTask_WaitDelayForNextTick(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitDelayForNextTick.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700601C RID: 24604
		// (get) Token: 0x06017FFA RID: 98298 RVA: 0x002335E0 File Offset: 0x002317E0
		// (set) Token: 0x06017FFB RID: 98299 RVA: 0x00233619 File Offset: 0x00231819
		public FKuroWaitDelayDelegate OnFinish
		{
			get
			{
				base.FastCheckIsValid();
				FKuroWaitDelayDelegate result;
				if ((result = this._OnFinish) == null)
				{
					result = (this._OnFinish = new FKuroWaitDelayDelegate(base.NativePtr + (IntPtr)UAbilityTask_WaitDelayForNextTick.__PropertyOffset_OnFinish, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_WaitDelayForNextTick.__PropertyOffset_OnFinish, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06017FFC RID: 98300 RVA: 0x0023363A File Offset: 0x0023183A
		[NullableContext(2)]
		public static UAbilityTask_WaitDelayForNextTick WaitDelayForNextTick(UGameplayAbility OwningAbility)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_WaitDelayForNextTick>(UAbilityTask_WaitDelayForNextTick.__WaitDelayForNextTick_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06017FFD RID: 98301
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WaitDelayForNextTick_Internal(IntPtr OwningAbility);

		// Token: 0x06017FFE RID: 98302 RVA: 0x00233656 File Offset: 0x00231856
		static UAbilityTask_WaitDelayForNextTick()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGAS.AbilityTask_WaitDelayForNextTick");
		}

		// Token: 0x06017FFF RID: 98303 RVA: 0x00233664 File Offset: 0x00231864
		protected UAbilityTask_WaitDelayForNextTick(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CFAC RID: 53164
		public new const string __ObjectPath = "/Script/KuroGAS.AbilityTask_WaitDelayForNextTick";

		// Token: 0x0400CFAD RID: 53165
		private static IntPtr _ClassPtr;

		// Token: 0x0400CFAE RID: 53166
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CFAF RID: 53167
		internal static int __PropertyOffset_OnFinish;

		// Token: 0x0400CFB0 RID: 53168
		[Nullable(2)]
		private FKuroWaitDelayDelegate _OnFinish;
	}
}
