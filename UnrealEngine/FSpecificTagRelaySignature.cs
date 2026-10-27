using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200193F RID: 6463
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSpecificTagRelaySignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06017F52 RID: 98130 RVA: 0x00231EE3 File Offset: 0x002300E3
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSpecificTagRelaySignature.StaticFunctionPtr();
		}

		// Token: 0x06017F53 RID: 98131 RVA: 0x00231EEF File Offset: 0x002300EF
		private static IntPtr StaticFunctionPtr()
		{
			if (FSpecificTagRelaySignature._FunctionPtr == IntPtr.Zero)
			{
				FSpecificTagRelaySignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.SpecificTagRelaySignature__DelegateSignature");
			}
			return FSpecificTagRelaySignature._FunctionPtr;
		}

		// Token: 0x06017F54 RID: 98132 RVA: 0x00231F12 File Offset: 0x00230112
		public FSpecificTagRelaySignature()
		{
		}

		// Token: 0x06017F55 RID: 98133 RVA: 0x00231F1A File Offset: 0x0023011A
		[NullableContext(2)]
		public FSpecificTagRelaySignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017F56 RID: 98134 RVA: 0x00231F24 File Offset: 0x00230124
		public FSpecificTagRelaySignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017F57 RID: 98135 RVA: 0x00231F2F File Offset: 0x0023012F
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FGameplayTagContainer>) ?? ((Action<FGameplayTagContainer>)Delegate.CreateDelegate(typeof(Action<FGameplayTagContainer>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06017F58 RID: 98136 RVA: 0x00231F61 File Offset: 0x00230161
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FGameplayTagContainer> Callback)
		{
			if (FSpecificTagRelaySignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSpecificTagRelaySignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSpecificTagRelaySignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSpecificTagRelaySignature.OnScriptCallback));
				}
				FSpecificTagRelaySignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSpecificTagRelaySignature.RegisterId);
		}

		// Token: 0x06017F59 RID: 98137 RVA: 0x00231F9B File Offset: 0x0023019B
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FGameplayTagContainer> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06017F5A RID: 98138 RVA: 0x00231FA4 File Offset: 0x002301A4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(in FGameplayTagContainer GameplayTags)
		{
			FSpecificTagRelaySignature.__FSpecificTagRelaySignature_DelegateParams* ptr = stackalloc FSpecificTagRelaySignature.__FSpecificTagRelaySignature_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FSpecificTagRelaySignature.__FSpecificTagRelaySignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSpecificTagRelaySignature.StaticFunctionPtr(), (void*)ptr, 1);
			if (GameplayTags != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), &ptr->GameplayTags, GameplayTags.NativePtr, 1, false);
			}
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSpecificTagRelaySignature._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06017F5B RID: 98139 RVA: 0x00232010 File Offset: 0x00230210
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FGameplayTagContainer> action = target as Action<FGameplayTagContainer>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FGameplayTagContainer obj = new FGameplayTagContainer(&((FSpecificTagRelaySignature.__FSpecificTagRelaySignature_DelegateParams*)__Parameters)->GameplayTags, true, true);
			action(obj);
		}

		// Token: 0x0400CF66 RID: 53094
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400CF67 RID: 53095
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.SpecificTagRelaySignature__DelegateSignature";

		// Token: 0x0400CF68 RID: 53096
		private static int RegisterId;

		// Token: 0x02003007 RID: 12295
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FSpecificTagRelaySignature_DelegateParams
		{
			// Token: 0x04016C24 RID: 93220
			[FieldOffset(0)]
			public byte GameplayTags;
		}

		// Token: 0x02003008 RID: 12296
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016C25 RID: 93221
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
