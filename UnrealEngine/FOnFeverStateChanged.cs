using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000509 RID: 1289
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnFeverStateChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007904 RID: 30980 RVA: 0x000B163C File Offset: 0x000AF83C
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnFeverStateChanged.StaticFunctionPtr();
		}

		// Token: 0x06007905 RID: 30981 RVA: 0x000B1648 File Offset: 0x000AF848
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnFeverStateChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnFeverStateChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRhythmGame.OnFeverStateChanged__DelegateSignature");
			}
			return FOnFeverStateChanged._FunctionPtr;
		}

		// Token: 0x06007906 RID: 30982 RVA: 0x000B166B File Offset: 0x000AF86B
		public FOnFeverStateChanged()
		{
		}

		// Token: 0x06007907 RID: 30983 RVA: 0x000B1673 File Offset: 0x000AF873
		[NullableContext(2)]
		public FOnFeverStateChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007908 RID: 30984 RVA: 0x000B167D File Offset: 0x000AF87D
		public FOnFeverStateChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007909 RID: 30985 RVA: 0x000B1688 File Offset: 0x000AF888
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600790A RID: 30986 RVA: 0x000B16BA File Offset: 0x000AF8BA
		[NullableContext(1)]
		public void Add(Action<bool> Callback)
		{
			if (FOnFeverStateChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnFeverStateChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnFeverStateChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnFeverStateChanged.OnScriptCallback));
				}
				FOnFeverStateChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnFeverStateChanged.RegisterId);
		}

		// Token: 0x0600790B RID: 30987 RVA: 0x000B16F4 File Offset: 0x000AF8F4
		[NullableContext(1)]
		public void Remove(Action<bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600790C RID: 30988 RVA: 0x000B1700 File Offset: 0x000AF900
		[SkipLocalsInit]
		public unsafe void Broadcast(bool bFeverActive)
		{
			FOnFeverStateChanged.__FOnFeverStateChanged_DelegateParams* ptr = stackalloc FOnFeverStateChanged.__FOnFeverStateChanged_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FOnFeverStateChanged.__FOnFeverStateChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnFeverStateChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bFeverActive = bFeverActive;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600790D RID: 30989 RVA: 0x000B173C File Offset: 0x000AF93C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnFeverStateChanged.__FOnFeverStateChanged_DelegateParams*)__Parameters)->bFeverActive);
		}

		// Token: 0x04003378 RID: 13176
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003379 RID: 13177
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRhythmGame.OnFeverStateChanged__DelegateSignature";

		// Token: 0x0400337A RID: 13178
		private static int RegisterId;

		// Token: 0x02000C6B RID: 3179
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		private ref struct __FOnFeverStateChanged_DelegateParams
		{
			// Token: 0x04005EC5 RID: 24261
			[FieldOffset(0)]
			public bool bFeverActive;
		}

		// Token: 0x02000C6C RID: 3180
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005EC6 RID: 24262
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
