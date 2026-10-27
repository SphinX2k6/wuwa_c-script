using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001315 RID: 4885
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AbilityTask_WaitInputPress")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class UAbilityTask_WaitInputPress : UAbilityTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012000 RID: 73728 RVA: 0x001A6D6F File Offset: 0x001A4F6F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilityTask_WaitInputPress._ClassPtr;
		}

		// Token: 0x06012001 RID: 73729 RVA: 0x001A6D7C File Offset: 0x001A4F7C
		public UAbilityTask_WaitInputPress() : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitInputPress.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012002 RID: 73730 RVA: 0x001A6DA4 File Offset: 0x001A4FA4
		public UAbilityTask_WaitInputPress(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitInputPress.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700463F RID: 17983
		// (get) Token: 0x06012003 RID: 73731 RVA: 0x001A6DD8 File Offset: 0x001A4FD8
		// (set) Token: 0x06012004 RID: 73732 RVA: 0x001A6E11 File Offset: 0x001A5011
		public FInputPressDelegate OnPress
		{
			get
			{
				base.FastCheckIsValid();
				FInputPressDelegate result;
				if ((result = this._OnPress) == null)
				{
					result = (this._OnPress = new FInputPressDelegate(base.NativePtr + (IntPtr)UAbilityTask_WaitInputPress.__PropertyOffset_OnPress, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_WaitInputPress.__PropertyOffset_OnPress, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06012005 RID: 73733 RVA: 0x001A6E32 File Offset: 0x001A5032
		[NullableContext(2)]
		public static UAbilityTask_WaitInputPress WaitInputPress(UGameplayAbility OwningAbility, bool bTestAlreadyPressed = false)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_WaitInputPress>(UAbilityTask_WaitInputPress.__WaitInputPress_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, bTestAlreadyPressed));
		}

		// Token: 0x06012006 RID: 73734 RVA: 0x001A6E4F File Offset: 0x001A504F
		public void OnPressCallback()
		{
			UAbilityTask_WaitInputPress.__OnPressCallback_Internal(base.NativePtr);
		}

		// Token: 0x06012007 RID: 73735
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WaitInputPress_Internal(IntPtr OwningAbility, bool bTestAlreadyPressed);

		// Token: 0x06012008 RID: 73736
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPressCallback_Internal(IntPtr @this);

		// Token: 0x06012009 RID: 73737 RVA: 0x001A6E5C File Offset: 0x001A505C
		static UAbilityTask_WaitInputPress()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilityTask_WaitInputPress");
		}

		// Token: 0x0601200A RID: 73738 RVA: 0x001A6E6A File Offset: 0x001A506A
		protected UAbilityTask_WaitInputPress(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040099E7 RID: 39399
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilityTask_WaitInputPress";

		// Token: 0x040099E8 RID: 39400
		private static IntPtr _ClassPtr;

		// Token: 0x040099E9 RID: 39401
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040099EA RID: 39402
		internal static int __PropertyOffset_OnPress;

		// Token: 0x040099EB RID: 39403
		[Nullable(2)]
		private FInputPressDelegate _OnPress;
	}
}
