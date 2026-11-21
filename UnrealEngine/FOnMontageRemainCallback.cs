using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000437 RID: 1079
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnMontageRemainCallback : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060068BB RID: 26811 RVA: 0x00098D42 File Offset: 0x00096F42
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnMontageRemainCallback.StaticFunctionPtr();
		}

		// Token: 0x060068BC RID: 26812 RVA: 0x00098D4E File Offset: 0x00096F4E
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnMontageRemainCallback._FunctionPtr == IntPtr.Zero)
			{
				FOnMontageRemainCallback._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGAS.OnMontageRemainCallback__DelegateSignature");
			}
			return FOnMontageRemainCallback._FunctionPtr;
		}

		// Token: 0x060068BD RID: 26813 RVA: 0x00098D71 File Offset: 0x00096F71
		public FOnMontageRemainCallback()
		{
		}

		// Token: 0x060068BE RID: 26814 RVA: 0x00098D79 File Offset: 0x00096F79
		[NullableContext(2)]
		public FOnMontageRemainCallback(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060068BF RID: 26815 RVA: 0x00098D83 File Offset: 0x00096F83
		public FOnMontageRemainCallback(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060068C0 RID: 26816 RVA: 0x00098D8E File Offset: 0x00096F8E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<float>) ?? ((Action<float>)Delegate.CreateDelegate(typeof(Action<float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060068C1 RID: 26817 RVA: 0x00098DC0 File Offset: 0x00096FC0
		[NullableContext(1)]
		public void Add(Action<float> Callback)
		{
			if (FOnMontageRemainCallback.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnMontageRemainCallback.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnMontageRemainCallback.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnMontageRemainCallback.OnScriptCallback));
				}
				FOnMontageRemainCallback.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnMontageRemainCallback.RegisterId);
		}

		// Token: 0x060068C2 RID: 26818 RVA: 0x00098DFA File Offset: 0x00096FFA
		[NullableContext(1)]
		public void Remove(Action<float> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060068C3 RID: 26819 RVA: 0x00098E04 File Offset: 0x00097004
		[SkipLocalsInit]
		public unsafe void Broadcast(float RemainTime)
		{
			FOnMontageRemainCallback.__FOnMontageRemainCallback_DelegateParams* ptr = stackalloc FOnMontageRemainCallback.__FOnMontageRemainCallback_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FOnMontageRemainCallback.__FOnMontageRemainCallback_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnMontageRemainCallback.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->RemainTime = RemainTime;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060068C4 RID: 26820 RVA: 0x00098E40 File Offset: 0x00097040
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<float> action = target as Action<float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnMontageRemainCallback.__FOnMontageRemainCallback_DelegateParams*)__Parameters)->RemainTime);
		}

		// Token: 0x04002CA4 RID: 11428
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002CA5 RID: 11429
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGAS.OnMontageRemainCallback__DelegateSignature";

		// Token: 0x04002CA6 RID: 11430
		private static int RegisterId;

		// Token: 0x02000B56 RID: 2902
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FOnMontageRemainCallback_DelegateParams
		{
			// Token: 0x04005C69 RID: 23657
			[FieldOffset(0)]
			public float RemainTime;
		}

		// Token: 0x02000B57 RID: 2903
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005C6A RID: 23658
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
