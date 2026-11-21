using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003E3 RID: 995
	public sealed class FKuroEffectFinishCallback : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600618C RID: 24972 RVA: 0x0008B780 File Offset: 0x00089980
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroEffectFinishCallback.StaticFunctionPtr();
		}

		// Token: 0x0600618D RID: 24973 RVA: 0x0008B78C File Offset: 0x0008998C
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroEffectFinishCallback._FunctionPtr == IntPtr.Zero)
			{
				FKuroEffectFinishCallback._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.KuroEffectFinishCallback__DelegateSignature");
			}
			return FKuroEffectFinishCallback._FunctionPtr;
		}

		// Token: 0x0600618E RID: 24974 RVA: 0x0008B7AF File Offset: 0x000899AF
		public FKuroEffectFinishCallback()
		{
		}

		// Token: 0x0600618F RID: 24975 RVA: 0x0008B7B7 File Offset: 0x000899B7
		[NullableContext(2)]
		public FKuroEffectFinishCallback(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006190 RID: 24976 RVA: 0x0008B7C1 File Offset: 0x000899C1
		public FKuroEffectFinishCallback(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006191 RID: 24977 RVA: 0x0008B7CC File Offset: 0x000899CC
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006192 RID: 24978 RVA: 0x0008B7FE File Offset: 0x000899FE
		[NullableContext(1)]
		public void Bind(Action<int> Callback)
		{
			if (FKuroEffectFinishCallback.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroEffectFinishCallback.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroEffectFinishCallback.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroEffectFinishCallback.OnScriptCallback));
				}
				FKuroEffectFinishCallback.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FKuroEffectFinishCallback.RegisterId);
		}

		// Token: 0x06006193 RID: 24979 RVA: 0x0008B838 File Offset: 0x00089A38
		[SkipLocalsInit]
		public unsafe void Execute(int Handle)
		{
			FKuroEffectFinishCallback.__FKuroEffectFinishCallback_DelegateParams* ptr = stackalloc FKuroEffectFinishCallback.__FKuroEffectFinishCallback_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FKuroEffectFinishCallback.__FKuroEffectFinishCallback_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroEffectFinishCallback.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Handle = Handle;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06006194 RID: 24980 RVA: 0x0008B878 File Offset: 0x00089A78
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FKuroEffectFinishCallback.__FKuroEffectFinishCallback_DelegateParams*)__Parameters)->Handle);
		}

		// Token: 0x04002999 RID: 10649
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400299A RID: 10650
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.KuroEffectFinishCallback__DelegateSignature";

		// Token: 0x0400299B RID: 10651
		private static int RegisterId;

		// Token: 0x02000AD7 RID: 2775
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FKuroEffectFinishCallback_DelegateParams
		{
			// Token: 0x04005B54 RID: 23380
			[FieldOffset(0)]
			public int Handle;
		}

		// Token: 0x02000AD8 RID: 2776
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005B55 RID: 23381
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
