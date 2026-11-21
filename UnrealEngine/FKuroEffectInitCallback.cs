using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003E4 RID: 996
	public sealed class FKuroEffectInitCallback : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006195 RID: 24981 RVA: 0x0008B8C2 File Offset: 0x00089AC2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroEffectInitCallback.StaticFunctionPtr();
		}

		// Token: 0x06006196 RID: 24982 RVA: 0x0008B8CE File Offset: 0x00089ACE
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroEffectInitCallback._FunctionPtr == IntPtr.Zero)
			{
				FKuroEffectInitCallback._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.KuroEffectInitCallback__DelegateSignature");
			}
			return FKuroEffectInitCallback._FunctionPtr;
		}

		// Token: 0x06006197 RID: 24983 RVA: 0x0008B8F1 File Offset: 0x00089AF1
		public FKuroEffectInitCallback()
		{
		}

		// Token: 0x06006198 RID: 24984 RVA: 0x0008B8F9 File Offset: 0x00089AF9
		[NullableContext(2)]
		public FKuroEffectInitCallback(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006199 RID: 24985 RVA: 0x0008B903 File Offset: 0x00089B03
		public FKuroEffectInitCallback(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600619A RID: 24986 RVA: 0x0008B90E File Offset: 0x00089B0E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<byte, int>) ?? ((Action<byte, int>)Delegate.CreateDelegate(typeof(Action<byte, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600619B RID: 24987 RVA: 0x0008B940 File Offset: 0x00089B40
		[NullableContext(1)]
		public void Bind(Action<byte, int> Callback)
		{
			if (FKuroEffectInitCallback.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroEffectInitCallback.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroEffectInitCallback.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroEffectInitCallback.OnScriptCallback));
				}
				FKuroEffectInitCallback.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FKuroEffectInitCallback.RegisterId);
		}

		// Token: 0x0600619C RID: 24988 RVA: 0x0008B97C File Offset: 0x00089B7C
		[SkipLocalsInit]
		public unsafe void Execute(byte Result, int Handle)
		{
			FKuroEffectInitCallback.__FKuroEffectInitCallback_DelegateParams* ptr = stackalloc FKuroEffectInitCallback.__FKuroEffectInitCallback_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FKuroEffectInitCallback.__FKuroEffectInitCallback_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroEffectInitCallback.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Result = Result;
			ptr->Handle = Handle;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600619D RID: 24989 RVA: 0x0008B9C0 File Offset: 0x00089BC0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<byte, int> action = target as Action<byte, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FKuroEffectInitCallback.__FKuroEffectInitCallback_DelegateParams*)__Parameters)->Result, ((FKuroEffectInitCallback.__FKuroEffectInitCallback_DelegateParams*)__Parameters)->Handle);
		}

		// Token: 0x0400299C RID: 10652
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400299D RID: 10653
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.KuroEffectInitCallback__DelegateSignature";

		// Token: 0x0400299E RID: 10654
		private static int RegisterId;

		// Token: 0x02000AD9 RID: 2777
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FKuroEffectInitCallback_DelegateParams
		{
			// Token: 0x04005B56 RID: 23382
			[FieldOffset(0)]
			public byte Result;

			// Token: 0x04005B57 RID: 23383
			[FieldOffset(4)]
			public int Handle;
		}

		// Token: 0x02000ADA RID: 2778
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005B58 RID: 23384
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
