using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000613 RID: 1555
	public sealed class FProcessCustomCommandDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600888A RID: 34954 RVA: 0x000CDF31 File Offset: 0x000CC131
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FProcessCustomCommandDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600888B RID: 34955 RVA: 0x000CDF3D File Offset: 0x000CC13D
		private static IntPtr StaticFunctionPtr()
		{
			if (FProcessCustomCommandDelegate._FunctionPtr == IntPtr.Zero)
			{
				FProcessCustomCommandDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.ProcessCustomCommandDelegate__DelegateSignature");
			}
			return FProcessCustomCommandDelegate._FunctionPtr;
		}

		// Token: 0x0600888C RID: 34956 RVA: 0x000CDF60 File Offset: 0x000CC160
		public FProcessCustomCommandDelegate()
		{
		}

		// Token: 0x0600888D RID: 34957 RVA: 0x000CDF68 File Offset: 0x000CC168
		[NullableContext(2)]
		public FProcessCustomCommandDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600888E RID: 34958 RVA: 0x000CDF72 File Offset: 0x000CC172
		public FProcessCustomCommandDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600888F RID: 34959 RVA: 0x000CDF7D File Offset: 0x000CC17D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008890 RID: 34960 RVA: 0x000CDFAF File Offset: 0x000CC1AF
		[NullableContext(1)]
		public void Bind(Action<string> Callback)
		{
			if (FProcessCustomCommandDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FProcessCustomCommandDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FProcessCustomCommandDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FProcessCustomCommandDelegate.OnScriptCallback));
				}
				FProcessCustomCommandDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FProcessCustomCommandDelegate.RegisterId);
		}

		// Token: 0x06008891 RID: 34961 RVA: 0x000CDFEC File Offset: 0x000CC1EC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Execute(string Command)
		{
			FProcessCustomCommandDelegate.__FProcessCustomCommandDelegate_DelegateParams* ptr = stackalloc FProcessCustomCommandDelegate.__FProcessCustomCommandDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FProcessCustomCommandDelegate.__FProcessCustomCommandDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FProcessCustomCommandDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Command), Command);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FProcessCustomCommandDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06008892 RID: 34962 RVA: 0x000CE040 File Offset: 0x000CC240
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string> action = target as Action<string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string obj = FString.ToString((void*)(&((FProcessCustomCommandDelegate.__FProcessCustomCommandDelegate_DelegateParams*)__Parameters)->Command));
			action(obj);
		}

		// Token: 0x04003B45 RID: 15173
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003B46 RID: 15174
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.ProcessCustomCommandDelegate__DelegateSignature";

		// Token: 0x04003B47 RID: 15175
		private static int RegisterId;

		// Token: 0x02000E44 RID: 3652
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FProcessCustomCommandDelegate_DelegateParams
		{
			// Token: 0x040061DE RID: 25054
			[FieldOffset(0)]
			public FString Command;
		}

		// Token: 0x02000E45 RID: 3653
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040061DF RID: 25055
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
