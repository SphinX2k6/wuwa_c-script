using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200194D RID: 6477
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGAS.AsyncTaskAnyEffectInhibitionChanged")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UAsyncTaskAnyEffectInhibitionChanged : UBlueprintAsyncActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601800B RID: 98315 RVA: 0x002337E8 File Offset: 0x002319E8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAsyncTaskAnyEffectInhibitionChanged._ClassPtr;
		}

		// Token: 0x0601800C RID: 98316 RVA: 0x002337F4 File Offset: 0x002319F4
		public UAsyncTaskAnyEffectInhibitionChanged() : this(BuiltinUtils.AllocNativeUObject(UAsyncTaskAnyEffectInhibitionChanged.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601800D RID: 98317 RVA: 0x0023381C File Offset: 0x00231A1C
		public UAsyncTaskAnyEffectInhibitionChanged(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAsyncTaskAnyEffectInhibitionChanged.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700601F RID: 24607
		// (get) Token: 0x0601800E RID: 98318 RVA: 0x00233850 File Offset: 0x00231A50
		// (set) Token: 0x0601800F RID: 98319 RVA: 0x00233889 File Offset: 0x00231A89
		public FOnGameplayEffectInhibitionChanged OnEffectInhibitionChanged
		{
			get
			{
				base.FastCheckIsValid();
				FOnGameplayEffectInhibitionChanged result;
				if ((result = this._OnEffectInhibitionChanged) == null)
				{
					result = (this._OnEffectInhibitionChanged = new FOnGameplayEffectInhibitionChanged(base.NativePtr + (IntPtr)UAsyncTaskAnyEffectInhibitionChanged.__PropertyOffset_OnEffectInhibitionChanged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAsyncTaskAnyEffectInhibitionChanged.__PropertyOffset_OnEffectInhibitionChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17006020 RID: 24608
		// (get) Token: 0x06018010 RID: 98320 RVA: 0x002338AA File Offset: 0x00231AAA
		// (set) Token: 0x06018011 RID: 98321 RVA: 0x002338BE File Offset: 0x00231ABE
		[Nullable(2)]
		public unsafe UAbilitySystemComponent AbilityComp
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAbilitySystemComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UAsyncTaskAnyEffectInhibitionChanged.__PropertyOffset_AbilityComp);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAsyncTaskAnyEffectInhibitionChanged.__PropertyOffset_AbilityComp, value);
			}
		}

		// Token: 0x06018012 RID: 98322 RVA: 0x002338D3 File Offset: 0x00231AD3
		[NullableContext(2)]
		public static UAsyncTaskAnyEffectInhibitionChanged ListenForAnyEffectInhibitionChanged(UAbilitySystemComponent AbilityComp)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAsyncTaskAnyEffectInhibitionChanged>(UAsyncTaskAnyEffectInhibitionChanged.__ListenForAnyEffectInhibitionChanged_Internal((AbilityComp != null) ? AbilityComp.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06018013 RID: 98323 RVA: 0x002338EF File Offset: 0x00231AEF
		public void EndTask()
		{
			UAsyncTaskAnyEffectInhibitionChanged.__EndTask_Internal(base.NativePtr);
		}

		// Token: 0x06018014 RID: 98324
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __ListenForAnyEffectInhibitionChanged_Internal(IntPtr AbilityComp);

		// Token: 0x06018015 RID: 98325
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EndTask_Internal(IntPtr @this);

		// Token: 0x06018016 RID: 98326 RVA: 0x002338FC File Offset: 0x00231AFC
		static UAsyncTaskAnyEffectInhibitionChanged()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGAS.AsyncTaskAnyEffectInhibitionChanged");
		}

		// Token: 0x06018017 RID: 98327 RVA: 0x0023390A File Offset: 0x00231B0A
		protected UAsyncTaskAnyEffectInhibitionChanged(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CFB9 RID: 53177
		public new const string __ObjectPath = "/Script/KuroGAS.AsyncTaskAnyEffectInhibitionChanged";

		// Token: 0x0400CFBA RID: 53178
		private static IntPtr _ClassPtr;

		// Token: 0x0400CFBB RID: 53179
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CFBC RID: 53180
		internal static int __PropertyOffset_OnEffectInhibitionChanged;

		// Token: 0x0400CFBD RID: 53181
		[Nullable(2)]
		private FOnGameplayEffectInhibitionChanged _OnEffectInhibitionChanged;

		// Token: 0x0400CFBE RID: 53182
		internal static int __PropertyOffset_AbilityComp;
	}
}
