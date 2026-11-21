using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000421 RID: 1057
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSpecificTagRelaySignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006606 RID: 26118 RVA: 0x00092673 File Offset: 0x00090873
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSpecificTagRelaySignature.StaticFunctionPtr();
		}

		// Token: 0x06006607 RID: 26119 RVA: 0x0009267F File Offset: 0x0009087F
		private static IntPtr StaticFunctionPtr()
		{
			if (FSpecificTagRelaySignature._FunctionPtr == IntPtr.Zero)
			{
				FSpecificTagRelaySignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.SpecificTagRelaySignature__DelegateSignature");
			}
			return FSpecificTagRelaySignature._FunctionPtr;
		}

		// Token: 0x06006608 RID: 26120 RVA: 0x000926A2 File Offset: 0x000908A2
		public FSpecificTagRelaySignature()
		{
		}

		// Token: 0x06006609 RID: 26121 RVA: 0x000926AA File Offset: 0x000908AA
		[NullableContext(2)]
		public FSpecificTagRelaySignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600660A RID: 26122 RVA: 0x000926B4 File Offset: 0x000908B4
		public FSpecificTagRelaySignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600660B RID: 26123 RVA: 0x000926BF File Offset: 0x000908BF
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FGameplayTagContainer>) ?? ((Action<FGameplayTagContainer>)Delegate.CreateDelegate(typeof(Action<FGameplayTagContainer>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600660C RID: 26124 RVA: 0x000926F1 File Offset: 0x000908F1
		[NullableContext(1)]
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

		// Token: 0x0600660D RID: 26125 RVA: 0x0009272B File Offset: 0x0009092B
		[NullableContext(1)]
		public void Remove(Action<FGameplayTagContainer> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600660E RID: 26126 RVA: 0x00092734 File Offset: 0x00090934
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x0600660F RID: 26127 RVA: 0x000927A0 File Offset: 0x000909A0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04002AE7 RID: 10983
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002AE8 RID: 10984
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.SpecificTagRelaySignature__DelegateSignature";

		// Token: 0x04002AE9 RID: 10985
		private static int RegisterId;

		// Token: 0x02000B1B RID: 2843
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		private ref struct __FSpecificTagRelaySignature_DelegateParams
		{
			// Token: 0x04005BCD RID: 23501
			[FieldOffset(0)]
			public byte GameplayTags;
		}

		// Token: 0x02000B1C RID: 2844
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005BCE RID: 23502
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
