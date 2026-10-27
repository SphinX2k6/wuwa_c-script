using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E8F RID: 7823
	public sealed class FBeginLoadMapDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DC27 RID: 121895 RVA: 0x002BF81D File Offset: 0x002BDA1D
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FBeginLoadMapDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601DC28 RID: 121896 RVA: 0x002BF829 File Offset: 0x002BDA29
		private static IntPtr StaticFunctionPtr()
		{
			if (FBeginLoadMapDelegate._FunctionPtr == IntPtr.Zero)
			{
				FBeginLoadMapDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.BeginLoadMapDelegate__DelegateSignature");
			}
			return FBeginLoadMapDelegate._FunctionPtr;
		}

		// Token: 0x0601DC29 RID: 121897 RVA: 0x002BF84C File Offset: 0x002BDA4C
		public FBeginLoadMapDelegate()
		{
		}

		// Token: 0x0601DC2A RID: 121898 RVA: 0x002BF854 File Offset: 0x002BDA54
		[NullableContext(2)]
		public FBeginLoadMapDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DC2B RID: 121899 RVA: 0x002BF85E File Offset: 0x002BDA5E
		public FBeginLoadMapDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DC2C RID: 121900 RVA: 0x002BF869 File Offset: 0x002BDA69
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DC2D RID: 121901 RVA: 0x002BF89B File Offset: 0x002BDA9B
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<string> Callback)
		{
			if (FBeginLoadMapDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FBeginLoadMapDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FBeginLoadMapDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FBeginLoadMapDelegate.OnScriptCallback));
				}
				FBeginLoadMapDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FBeginLoadMapDelegate.RegisterId);
		}

		// Token: 0x0601DC2E RID: 121902 RVA: 0x002BF8D8 File Offset: 0x002BDAD8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(string MapName)
		{
			FBeginLoadMapDelegate.__FBeginLoadMapDelegate_DelegateParams* ptr = stackalloc FBeginLoadMapDelegate.__FBeginLoadMapDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FBeginLoadMapDelegate.__FBeginLoadMapDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FBeginLoadMapDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->MapName), MapName);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FBeginLoadMapDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DC2F RID: 121903 RVA: 0x002BF92C File Offset: 0x002BDB2C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string> action = target as Action<string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string obj = FString.ToString((void*)(&((FBeginLoadMapDelegate.__FBeginLoadMapDelegate_DelegateParams*)__Parameters)->MapName));
			action(obj);
		}

		// Token: 0x040101CC RID: 65996
		internal static IntPtr _FunctionPtr;

		// Token: 0x040101CD RID: 65997
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.BeginLoadMapDelegate__DelegateSignature";

		// Token: 0x040101CE RID: 65998
		private static int RegisterId;

		// Token: 0x020032DA RID: 13018
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FBeginLoadMapDelegate_DelegateParams
		{
			// Token: 0x04017187 RID: 94599
			[FieldOffset(0)]
			public FString MapName;
		}

		// Token: 0x020032DB RID: 13019
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017188 RID: 94600
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
