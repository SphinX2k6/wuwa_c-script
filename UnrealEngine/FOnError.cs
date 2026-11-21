using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000485 RID: 1157
	public sealed class FOnError : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006D34 RID: 27956 RVA: 0x0009F8F6 File Offset: 0x0009DAF6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnError.StaticFunctionPtr();
		}

		// Token: 0x06006D35 RID: 27957 RVA: 0x0009F902 File Offset: 0x0009DB02
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnError._FunctionPtr == IntPtr.Zero)
			{
				FOnError._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroNetwork.OnError__DelegateSignature");
			}
			return FOnError._FunctionPtr;
		}

		// Token: 0x06006D36 RID: 27958 RVA: 0x0009F925 File Offset: 0x0009DB25
		public FOnError()
		{
		}

		// Token: 0x06006D37 RID: 27959 RVA: 0x0009F92D File Offset: 0x0009DB2D
		[NullableContext(2)]
		public FOnError(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006D38 RID: 27960 RVA: 0x0009F937 File Offset: 0x0009DB37
		public FOnError(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006D39 RID: 27961 RVA: 0x0009F942 File Offset: 0x0009DB42
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, int, int, int, int>) ?? ((Action<int, int, int, int, int>)Delegate.CreateDelegate(typeof(Action<int, int, int, int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006D3A RID: 27962 RVA: 0x0009F974 File Offset: 0x0009DB74
		[NullableContext(1)]
		public void Bind(Action<int, int, int, int, int> Callback)
		{
			if (FOnError.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnError.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnError.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnError.OnScriptCallback));
				}
				FOnError.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnError.RegisterId);
		}

		// Token: 0x06006D3B RID: 27963 RVA: 0x0009F9B0 File Offset: 0x0009DBB0
		[SkipLocalsInit]
		public unsafe void Execute(int Code1, int Code2, int Code3, int Code4, int Code5)
		{
			FOnError.__FOnError_DelegateParams* ptr = stackalloc FOnError.__FOnError_DelegateParams[(UIntPtr)35] + 15L / (long)sizeof(FOnError.__FOnError_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnError.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Code1 = Code1;
			ptr->Code2 = Code2;
			ptr->Code3 = Code3;
			ptr->Code4 = Code4;
			ptr->Code5 = Code5;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06006D3C RID: 27964 RVA: 0x0009FA0C File Offset: 0x0009DC0C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, int, int, int, int> action = target as Action<int, int, int, int, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnError.__FOnError_DelegateParams*)__Parameters)->Code1, ((FOnError.__FOnError_DelegateParams*)__Parameters)->Code2, ((FOnError.__FOnError_DelegateParams*)__Parameters)->Code3, ((FOnError.__FOnError_DelegateParams*)__Parameters)->Code4, ((FOnError.__FOnError_DelegateParams*)__Parameters)->Code5);
		}

		// Token: 0x04002EA0 RID: 11936
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002EA1 RID: 11937
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroNetwork.OnError__DelegateSignature";

		// Token: 0x04002EA2 RID: 11938
		private static int RegisterId;

		// Token: 0x02000B8F RID: 2959
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		private ref struct __FOnError_DelegateParams
		{
			// Token: 0x04005D04 RID: 23812
			[FieldOffset(0)]
			public int Code1;

			// Token: 0x04005D05 RID: 23813
			[FieldOffset(4)]
			public int Code2;

			// Token: 0x04005D06 RID: 23814
			[FieldOffset(8)]
			public int Code3;

			// Token: 0x04005D07 RID: 23815
			[FieldOffset(12)]
			public int Code4;

			// Token: 0x04005D08 RID: 23816
			[FieldOffset(16)]
			public int Code5;
		}

		// Token: 0x02000B90 RID: 2960
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005D09 RID: 23817
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
