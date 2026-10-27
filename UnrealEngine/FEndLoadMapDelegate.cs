using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E98 RID: 7832
	public sealed class FEndLoadMapDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DC6D RID: 121965 RVA: 0x002C0116 File Offset: 0x002BE316
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FEndLoadMapDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601DC6E RID: 121966 RVA: 0x002C0122 File Offset: 0x002BE322
		private static IntPtr StaticFunctionPtr()
		{
			if (FEndLoadMapDelegate._FunctionPtr == IntPtr.Zero)
			{
				FEndLoadMapDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.EndLoadMapDelegate__DelegateSignature");
			}
			return FEndLoadMapDelegate._FunctionPtr;
		}

		// Token: 0x0601DC6F RID: 121967 RVA: 0x002C0145 File Offset: 0x002BE345
		public FEndLoadMapDelegate()
		{
		}

		// Token: 0x0601DC70 RID: 121968 RVA: 0x002C014D File Offset: 0x002BE34D
		[NullableContext(2)]
		public FEndLoadMapDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DC71 RID: 121969 RVA: 0x002C0157 File Offset: 0x002BE357
		public FEndLoadMapDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DC72 RID: 121970 RVA: 0x002C0162 File Offset: 0x002BE362
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DC73 RID: 121971 RVA: 0x002C0194 File Offset: 0x002BE394
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<string> Callback)
		{
			if (FEndLoadMapDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FEndLoadMapDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FEndLoadMapDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FEndLoadMapDelegate.OnScriptCallback));
				}
				FEndLoadMapDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FEndLoadMapDelegate.RegisterId);
		}

		// Token: 0x0601DC74 RID: 121972 RVA: 0x002C01D0 File Offset: 0x002BE3D0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(string MapName)
		{
			FEndLoadMapDelegate.__FEndLoadMapDelegate_DelegateParams* ptr = stackalloc FEndLoadMapDelegate.__FEndLoadMapDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FEndLoadMapDelegate.__FEndLoadMapDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FEndLoadMapDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->MapName), MapName);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FEndLoadMapDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DC75 RID: 121973 RVA: 0x002C0224 File Offset: 0x002BE424
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
			string obj = FString.ToString((void*)(&((FEndLoadMapDelegate.__FEndLoadMapDelegate_DelegateParams*)__Parameters)->MapName));
			action(obj);
		}

		// Token: 0x040101ED RID: 66029
		internal static IntPtr _FunctionPtr;

		// Token: 0x040101EE RID: 66030
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.EndLoadMapDelegate__DelegateSignature";

		// Token: 0x040101EF RID: 66031
		private static int RegisterId;

		// Token: 0x020032E6 RID: 13030
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FEndLoadMapDelegate_DelegateParams
		{
			// Token: 0x04017196 RID: 94614
			[FieldOffset(0)]
			public FString MapName;
		}

		// Token: 0x020032E7 RID: 13031
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017197 RID: 94615
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
