using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002C6 RID: 710
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FTagUpdated : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06004DB3 RID: 19891 RVA: 0x0006C895 File Offset: 0x0006AA95
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FTagUpdated.StaticFunctionPtr();
		}

		// Token: 0x06004DB4 RID: 19892 RVA: 0x0006C8A1 File Offset: 0x0006AAA1
		private static IntPtr StaticFunctionPtr()
		{
			if (FTagUpdated._FunctionPtr == IntPtr.Zero)
			{
				FTagUpdated._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/GameplayAbilities.TagUpdated__DelegateSignature");
			}
			return FTagUpdated._FunctionPtr;
		}

		// Token: 0x06004DB5 RID: 19893 RVA: 0x0006C8C4 File Offset: 0x0006AAC4
		public FTagUpdated()
		{
		}

		// Token: 0x06004DB6 RID: 19894 RVA: 0x0006C8CC File Offset: 0x0006AACC
		[NullableContext(2)]
		public FTagUpdated(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004DB7 RID: 19895 RVA: 0x0006C8D6 File Offset: 0x0006AAD6
		public FTagUpdated(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004DB8 RID: 19896 RVA: 0x0006C8E1 File Offset: 0x0006AAE1
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FGameplayTag, bool, int>) ?? ((Action<FGameplayTag, bool, int>)Delegate.CreateDelegate(typeof(Action<FGameplayTag, bool, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06004DB9 RID: 19897 RVA: 0x0006C913 File Offset: 0x0006AB13
		[NullableContext(1)]
		public void Add(Action<FGameplayTag, bool, int> Callback)
		{
			if (FTagUpdated.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FTagUpdated.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FTagUpdated.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FTagUpdated.OnScriptCallback));
				}
				FTagUpdated.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FTagUpdated.RegisterId);
		}

		// Token: 0x06004DBA RID: 19898 RVA: 0x0006C94D File Offset: 0x0006AB4D
		[NullableContext(1)]
		public void Remove(Action<FGameplayTag, bool, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06004DBB RID: 19899 RVA: 0x0006C958 File Offset: 0x0006AB58
		[SkipLocalsInit]
		public unsafe void Broadcast(in FGameplayTag Tag, bool TagExists, int CountDelta)
		{
			FTagUpdated.__FTagUpdated_DelegateParams* ptr = stackalloc FTagUpdated.__FTagUpdated_DelegateParams[(UIntPtr)35] + 15L / (long)sizeof(FTagUpdated.__FTagUpdated_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FTagUpdated.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Tag = Tag;
			ptr->TagExists = TagExists;
			ptr->CountDelta = CountDelta;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06004DBC RID: 19900 RVA: 0x0006C9A8 File Offset: 0x0006ABA8
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FGameplayTag, bool, int> action = target as Action<FGameplayTag, bool, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FTagUpdated.__FTagUpdated_DelegateParams*)__Parameters)->Tag, ((FTagUpdated.__FTagUpdated_DelegateParams*)__Parameters)->TagExists, ((FTagUpdated.__FTagUpdated_DelegateParams*)__Parameters)->CountDelta);
		}

		// Token: 0x04001F01 RID: 7937
		internal static IntPtr _FunctionPtr;

		// Token: 0x04001F02 RID: 7938
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.TagUpdated__DelegateSignature";

		// Token: 0x04001F03 RID: 7939
		private static int RegisterId;

		// Token: 0x020009FC RID: 2556
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		private ref struct __FTagUpdated_DelegateParams
		{
			// Token: 0x040059A1 RID: 22945
			[FieldOffset(0)]
			public FGameplayTag Tag;

			// Token: 0x040059A2 RID: 22946
			[FieldOffset(12)]
			public bool TagExists;

			// Token: 0x040059A3 RID: 22947
			[FieldOffset(16)]
			public int CountDelta;
		}

		// Token: 0x020009FD RID: 2557
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040059A4 RID: 22948
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
