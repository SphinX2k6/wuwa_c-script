using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012FE RID: 4862
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AbilityTask_Repeat")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UAbilityTask_Repeat : UAbilityTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011EEF RID: 73455 RVA: 0x001A4EBE File Offset: 0x001A30BE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilityTask_Repeat._ClassPtr;
		}

		// Token: 0x06011EF0 RID: 73456 RVA: 0x001A4ECC File Offset: 0x001A30CC
		public UAbilityTask_Repeat() : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_Repeat.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011EF1 RID: 73457 RVA: 0x001A4EF4 File Offset: 0x001A30F4
		public UAbilityTask_Repeat(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_Repeat.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700461D RID: 17949
		// (get) Token: 0x06011EF2 RID: 73458 RVA: 0x001A4F28 File Offset: 0x001A3128
		// (set) Token: 0x06011EF3 RID: 73459 RVA: 0x001A4F61 File Offset: 0x001A3161
		public FRepeatedActionDelegate OnPerformAction
		{
			get
			{
				base.FastCheckIsValid();
				FRepeatedActionDelegate result;
				if ((result = this._OnPerformAction) == null)
				{
					result = (this._OnPerformAction = new FRepeatedActionDelegate(base.NativePtr + (IntPtr)UAbilityTask_Repeat.__PropertyOffset_OnPerformAction, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_Repeat.__PropertyOffset_OnPerformAction, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700461E RID: 17950
		// (get) Token: 0x06011EF4 RID: 73460 RVA: 0x001A4F84 File Offset: 0x001A3184
		// (set) Token: 0x06011EF5 RID: 73461 RVA: 0x001A4FBD File Offset: 0x001A31BD
		public FRepeatedActionDelegate OnFinished
		{
			get
			{
				base.FastCheckIsValid();
				FRepeatedActionDelegate result;
				if ((result = this._OnFinished) == null)
				{
					result = (this._OnFinished = new FRepeatedActionDelegate(base.NativePtr + (IntPtr)UAbilityTask_Repeat.__PropertyOffset_OnFinished, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_Repeat.__PropertyOffset_OnFinished, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06011EF6 RID: 73462 RVA: 0x001A4FDE File Offset: 0x001A31DE
		[NullableContext(2)]
		public static UAbilityTask_Repeat RepeatAction(UGameplayAbility OwningAbility, float TimeBetweenActions, int TotalActionCount)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_Repeat>(UAbilityTask_Repeat.__RepeatAction_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, TimeBetweenActions, TotalActionCount));
		}

		// Token: 0x06011EF7 RID: 73463
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RepeatAction_Internal(IntPtr OwningAbility, float TimeBetweenActions, int TotalActionCount);

		// Token: 0x06011EF8 RID: 73464 RVA: 0x001A4FFC File Offset: 0x001A31FC
		static UAbilityTask_Repeat()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilityTask_Repeat");
		}

		// Token: 0x06011EF9 RID: 73465 RVA: 0x001A500A File Offset: 0x001A320A
		protected UAbilityTask_Repeat(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009965 RID: 39269
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilityTask_Repeat";

		// Token: 0x04009966 RID: 39270
		private static IntPtr _ClassPtr;

		// Token: 0x04009967 RID: 39271
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009968 RID: 39272
		internal static int __PropertyOffset_OnPerformAction;

		// Token: 0x04009969 RID: 39273
		[Nullable(2)]
		private FRepeatedActionDelegate _OnPerformAction;

		// Token: 0x0400996A RID: 39274
		internal static int __PropertyOffset_OnFinished;

		// Token: 0x0400996B RID: 39275
		[Nullable(2)]
		private FRepeatedActionDelegate _OnFinished;
	}
}
