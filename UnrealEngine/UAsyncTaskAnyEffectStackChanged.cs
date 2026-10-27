using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200194F RID: 6479
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGAS.AsyncTaskAnyEffectStackChanged")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UAsyncTaskAnyEffectStackChanged : UBlueprintAsyncActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018023 RID: 98339 RVA: 0x00233A8C File Offset: 0x00231C8C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAsyncTaskAnyEffectStackChanged._ClassPtr;
		}

		// Token: 0x06018024 RID: 98340 RVA: 0x00233A98 File Offset: 0x00231C98
		public UAsyncTaskAnyEffectStackChanged() : this(BuiltinUtils.AllocNativeUObject(UAsyncTaskAnyEffectStackChanged.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018025 RID: 98341 RVA: 0x00233AC0 File Offset: 0x00231CC0
		public UAsyncTaskAnyEffectStackChanged(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAsyncTaskAnyEffectStackChanged.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006023 RID: 24611
		// (get) Token: 0x06018026 RID: 98342 RVA: 0x00233AF4 File Offset: 0x00231CF4
		// (set) Token: 0x06018027 RID: 98343 RVA: 0x00233B2D File Offset: 0x00231D2D
		public FOnGameplayEffectStackChanged OnStackChanged
		{
			get
			{
				base.FastCheckIsValid();
				FOnGameplayEffectStackChanged result;
				if ((result = this._OnStackChanged) == null)
				{
					result = (this._OnStackChanged = new FOnGameplayEffectStackChanged(base.NativePtr + (IntPtr)UAsyncTaskAnyEffectStackChanged.__PropertyOffset_OnStackChanged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAsyncTaskAnyEffectStackChanged.__PropertyOffset_OnStackChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17006024 RID: 24612
		// (get) Token: 0x06018028 RID: 98344 RVA: 0x00233B4E File Offset: 0x00231D4E
		// (set) Token: 0x06018029 RID: 98345 RVA: 0x00233B62 File Offset: 0x00231D62
		[Nullable(2)]
		public unsafe UAbilitySystemComponent AbilityComp
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAbilitySystemComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UAsyncTaskAnyEffectStackChanged.__PropertyOffset_AbilityComp);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAsyncTaskAnyEffectStackChanged.__PropertyOffset_AbilityComp, value);
			}
		}

		// Token: 0x0601802A RID: 98346 RVA: 0x00233B77 File Offset: 0x00231D77
		[NullableContext(2)]
		public static UAsyncTaskAnyEffectStackChanged ListenForAnyEffectStackChanged(UAbilitySystemComponent AbilityComp)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAsyncTaskAnyEffectStackChanged>(UAsyncTaskAnyEffectStackChanged.__ListenForAnyEffectStackChanged_Internal((AbilityComp != null) ? AbilityComp.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0601802B RID: 98347 RVA: 0x00233B93 File Offset: 0x00231D93
		public void EndTask()
		{
			UAsyncTaskAnyEffectStackChanged.__EndTask_Internal(base.NativePtr);
		}

		// Token: 0x0601802C RID: 98348
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __ListenForAnyEffectStackChanged_Internal(IntPtr AbilityComp);

		// Token: 0x0601802D RID: 98349
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EndTask_Internal(IntPtr @this);

		// Token: 0x0601802E RID: 98350 RVA: 0x00233BA0 File Offset: 0x00231DA0
		static UAsyncTaskAnyEffectStackChanged()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGAS.AsyncTaskAnyEffectStackChanged");
		}

		// Token: 0x0601802F RID: 98351 RVA: 0x00233BAE File Offset: 0x00231DAE
		protected UAsyncTaskAnyEffectStackChanged(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CFC7 RID: 53191
		public new const string __ObjectPath = "/Script/KuroGAS.AsyncTaskAnyEffectStackChanged";

		// Token: 0x0400CFC8 RID: 53192
		private static IntPtr _ClassPtr;

		// Token: 0x0400CFC9 RID: 53193
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CFCA RID: 53194
		internal static int __PropertyOffset_OnStackChanged;

		// Token: 0x0400CFCB RID: 53195
		[Nullable(2)]
		private FOnGameplayEffectStackChanged _OnStackChanged;

		// Token: 0x0400CFCC RID: 53196
		internal static int __PropertyOffset_AbilityComp;
	}
}
