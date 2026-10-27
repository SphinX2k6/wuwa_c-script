using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001890 RID: 6288
	public sealed class FAudioSystemPostEventTransformRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060172A1 RID: 94881 RVA: 0x0021C476 File Offset: 0x0021A676
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FAudioSystemPostEventTransformRetVal.StaticFunctionPtr();
		}

		// Token: 0x060172A2 RID: 94882 RVA: 0x0021C482 File Offset: 0x0021A682
		private static IntPtr StaticFunctionPtr()
		{
			if (FAudioSystemPostEventTransformRetVal._FunctionPtr == IntPtr.Zero)
			{
				FAudioSystemPostEventTransformRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.AudioSystemPostEventTransformRetVal__DelegateSignature");
			}
			return FAudioSystemPostEventTransformRetVal._FunctionPtr;
		}

		// Token: 0x060172A3 RID: 94883 RVA: 0x0021C4A5 File Offset: 0x0021A6A5
		public FAudioSystemPostEventTransformRetVal()
		{
		}

		// Token: 0x060172A4 RID: 94884 RVA: 0x0021C4AD File Offset: 0x0021A6AD
		[NullableContext(2)]
		public FAudioSystemPostEventTransformRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060172A5 RID: 94885 RVA: 0x0021C4B7 File Offset: 0x0021A6B7
		public FAudioSystemPostEventTransformRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060172A6 RID: 94886 RVA: 0x0021C4C2 File Offset: 0x0021A6C2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<string, FTransformDouble, int>) ?? ((Func<string, FTransformDouble, int>)Delegate.CreateDelegate(typeof(Func<string, FTransformDouble, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060172A7 RID: 94887 RVA: 0x0021C4F4 File Offset: 0x0021A6F4
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Func<string, FTransformDouble, int> Callback)
		{
			if (FAudioSystemPostEventTransformRetVal.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FAudioSystemPostEventTransformRetVal.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FAudioSystemPostEventTransformRetVal.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FAudioSystemPostEventTransformRetVal.OnScriptCallback));
				}
				FAudioSystemPostEventTransformRetVal.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FAudioSystemPostEventTransformRetVal.RegisterId);
		}

		// Token: 0x060172A8 RID: 94888 RVA: 0x0021C530 File Offset: 0x0021A730
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int Execute(string EventName, in FTransformDouble Transform)
		{
			FAudioSystemPostEventTransformRetVal.__FAudioSystemPostEventTransformRetVal_DelegateParams* ptr = stackalloc FAudioSystemPostEventTransformRetVal.__FAudioSystemPostEventTransformRetVal_DelegateParams[(UIntPtr)111] + 15L / (long)sizeof(FAudioSystemPostEventTransformRetVal.__FAudioSystemPostEventTransformRetVal_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FAudioSystemPostEventTransformRetVal.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->EventName), EventName);
			ptr->Transform = Transform;
			base.ExecuteInternal((void*)ptr);
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(FAudioSystemPostEventTransformRetVal._FunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x060172A9 RID: 94889 RVA: 0x0021C598 File Offset: 0x0021A798
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<string, FTransformDouble, int> func = target as Func<string, FTransformDouble, int>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FAudioSystemPostEventTransformRetVal.__FAudioSystemPostEventTransformRetVal_DelegateParams*)__Parameters)->EventName));
			int _Result = func(arg, ((FAudioSystemPostEventTransformRetVal.__FAudioSystemPostEventTransformRetVal_DelegateParams*)__Parameters)->Transform);
			((FAudioSystemPostEventTransformRetVal.__FAudioSystemPostEventTransformRetVal_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x0400C8F8 RID: 51448
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400C8F9 RID: 51449
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.AudioSystemPostEventTransformRetVal__DelegateSignature";

		// Token: 0x0400C8FA RID: 51450
		private static int RegisterId;

		// Token: 0x02002F90 RID: 12176
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __FAudioSystemPostEventTransformRetVal_DelegateParams
		{
			// Token: 0x04016B58 RID: 93016
			[FieldOffset(0)]
			public FString EventName;

			// Token: 0x04016B59 RID: 93017
			[FieldOffset(16)]
			public FTransformDouble Transform;

			// Token: 0x04016B5A RID: 93018
			[FieldOffset(80)]
			public int __Result;
		}

		// Token: 0x02002F91 RID: 12177
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016B5B RID: 93019
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
