using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001316 RID: 4886
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AbilityTask_WaitInputRelease")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class UAbilityTask_WaitInputRelease : UAbilityTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601200B RID: 73739 RVA: 0x001A6E73 File Offset: 0x001A5073
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilityTask_WaitInputRelease._ClassPtr;
		}

		// Token: 0x0601200C RID: 73740 RVA: 0x001A6E80 File Offset: 0x001A5080
		public UAbilityTask_WaitInputRelease() : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitInputRelease.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601200D RID: 73741 RVA: 0x001A6EA8 File Offset: 0x001A50A8
		public UAbilityTask_WaitInputRelease(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitInputRelease.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004640 RID: 17984
		// (get) Token: 0x0601200E RID: 73742 RVA: 0x001A6EDC File Offset: 0x001A50DC
		// (set) Token: 0x0601200F RID: 73743 RVA: 0x001A6F15 File Offset: 0x001A5115
		public FInputReleaseDelegate OnRelease
		{
			get
			{
				base.FastCheckIsValid();
				FInputReleaseDelegate result;
				if ((result = this._OnRelease) == null)
				{
					result = (this._OnRelease = new FInputReleaseDelegate(base.NativePtr + (IntPtr)UAbilityTask_WaitInputRelease.__PropertyOffset_OnRelease, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_WaitInputRelease.__PropertyOffset_OnRelease, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06012010 RID: 73744 RVA: 0x001A6F36 File Offset: 0x001A5136
		[NullableContext(2)]
		public static UAbilityTask_WaitInputRelease WaitInputRelease(UGameplayAbility OwningAbility, bool bTestAlreadyReleased = false)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_WaitInputRelease>(UAbilityTask_WaitInputRelease.__WaitInputRelease_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, bTestAlreadyReleased));
		}

		// Token: 0x06012011 RID: 73745 RVA: 0x001A6F53 File Offset: 0x001A5153
		public void OnReleaseCallback()
		{
			UAbilityTask_WaitInputRelease.__OnReleaseCallback_Internal(base.NativePtr);
		}

		// Token: 0x06012012 RID: 73746
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WaitInputRelease_Internal(IntPtr OwningAbility, bool bTestAlreadyReleased);

		// Token: 0x06012013 RID: 73747
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnReleaseCallback_Internal(IntPtr @this);

		// Token: 0x06012014 RID: 73748 RVA: 0x001A6F60 File Offset: 0x001A5160
		static UAbilityTask_WaitInputRelease()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilityTask_WaitInputRelease");
		}

		// Token: 0x06012015 RID: 73749 RVA: 0x001A6F6E File Offset: 0x001A516E
		protected UAbilityTask_WaitInputRelease(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040099EC RID: 39404
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilityTask_WaitInputRelease";

		// Token: 0x040099ED RID: 39405
		private static IntPtr _ClassPtr;

		// Token: 0x040099EE RID: 39406
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040099EF RID: 39407
		internal static int __PropertyOffset_OnRelease;

		// Token: 0x040099F0 RID: 39408
		[Nullable(2)]
		private FInputReleaseDelegate _OnRelease;
	}
}
