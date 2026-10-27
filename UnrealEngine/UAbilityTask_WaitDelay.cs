using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200130A RID: 4874
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AbilityTask_WaitDelay")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UAbilityTask_WaitDelay : UAbilityTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011F8D RID: 73613 RVA: 0x001A5FD1 File Offset: 0x001A41D1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilityTask_WaitDelay._ClassPtr;
		}

		// Token: 0x06011F8E RID: 73614 RVA: 0x001A5FE0 File Offset: 0x001A41E0
		public UAbilityTask_WaitDelay() : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitDelay.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011F8F RID: 73615 RVA: 0x001A6008 File Offset: 0x001A4208
		public UAbilityTask_WaitDelay(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitDelay.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004630 RID: 17968
		// (get) Token: 0x06011F90 RID: 73616 RVA: 0x001A603C File Offset: 0x001A423C
		// (set) Token: 0x06011F91 RID: 73617 RVA: 0x001A6075 File Offset: 0x001A4275
		public FWaitDelayDelegate OnFinish
		{
			get
			{
				base.FastCheckIsValid();
				FWaitDelayDelegate result;
				if ((result = this._OnFinish) == null)
				{
					result = (this._OnFinish = new FWaitDelayDelegate(base.NativePtr + (IntPtr)UAbilityTask_WaitDelay.__PropertyOffset_OnFinish, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_WaitDelay.__PropertyOffset_OnFinish, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06011F92 RID: 73618 RVA: 0x001A6096 File Offset: 0x001A4296
		[NullableContext(2)]
		public static UAbilityTask_WaitDelay WaitDelay(UGameplayAbility OwningAbility, float Time)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_WaitDelay>(UAbilityTask_WaitDelay.__WaitDelay_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, Time));
		}

		// Token: 0x06011F93 RID: 73619
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WaitDelay_Internal(IntPtr OwningAbility, float Time);

		// Token: 0x06011F94 RID: 73620 RVA: 0x001A60B3 File Offset: 0x001A42B3
		static UAbilityTask_WaitDelay()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilityTask_WaitDelay");
		}

		// Token: 0x06011F95 RID: 73621 RVA: 0x001A60C1 File Offset: 0x001A42C1
		protected UAbilityTask_WaitDelay(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040099AC RID: 39340
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilityTask_WaitDelay";

		// Token: 0x040099AD RID: 39341
		private static IntPtr _ClassPtr;

		// Token: 0x040099AE RID: 39342
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040099AF RID: 39343
		internal static int __PropertyOffset_OnFinish;

		// Token: 0x040099B0 RID: 39344
		[Nullable(2)]
		private FWaitDelayDelegate _OnFinish;
	}
}
