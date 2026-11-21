using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000647 RID: 1607
	public sealed class FCheckTextInputDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008D51 RID: 36177 RVA: 0x000D4A38 File Offset: 0x000D2C38
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FCheckTextInputDelegate.StaticFunctionPtr();
		}

		// Token: 0x06008D52 RID: 36178 RVA: 0x000D4A44 File Offset: 0x000D2C44
		private static IntPtr StaticFunctionPtr()
		{
			if (FCheckTextInputDelegate._FunctionPtr == IntPtr.Zero)
			{
				FCheckTextInputDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.CheckTextInputDelegate__DelegateSignature");
			}
			return FCheckTextInputDelegate._FunctionPtr;
		}

		// Token: 0x06008D53 RID: 36179 RVA: 0x000D4A67 File Offset: 0x000D2C67
		public FCheckTextInputDelegate()
		{
		}

		// Token: 0x06008D54 RID: 36180 RVA: 0x000D4A6F File Offset: 0x000D2C6F
		[NullableContext(2)]
		public FCheckTextInputDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008D55 RID: 36181 RVA: 0x000D4A79 File Offset: 0x000D2C79
		public FCheckTextInputDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008D56 RID: 36182 RVA: 0x000D4A84 File Offset: 0x000D2C84
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<string, bool>) ?? ((Func<string, bool>)Delegate.CreateDelegate(typeof(Func<string, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008D57 RID: 36183 RVA: 0x000D4AB6 File Offset: 0x000D2CB6
		[NullableContext(1)]
		public void Bind(Func<string, bool> Callback)
		{
			if (FCheckTextInputDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FCheckTextInputDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FCheckTextInputDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FCheckTextInputDelegate.OnScriptCallback));
				}
				FCheckTextInputDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FCheckTextInputDelegate.RegisterId);
		}

		// Token: 0x06008D58 RID: 36184 RVA: 0x000D4AF0 File Offset: 0x000D2CF0
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe bool Execute(string InString)
		{
			FCheckTextInputDelegate.__FCheckTextInputDelegate_DelegateParams* ptr = stackalloc FCheckTextInputDelegate.__FCheckTextInputDelegate_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FCheckTextInputDelegate.__FCheckTextInputDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FCheckTextInputDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->InString), InString);
			base.ExecuteInternal((void*)ptr);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(FCheckTextInputDelegate._FunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06008D59 RID: 36185 RVA: 0x000D4B4C File Offset: 0x000D2D4C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<string, bool> func = target as Func<string, bool>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FCheckTextInputDelegate.__FCheckTextInputDelegate_DelegateParams*)__Parameters)->InString));
			bool _Result = func(arg);
			((FCheckTextInputDelegate.__FCheckTextInputDelegate_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x04003D80 RID: 15744
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003D81 RID: 15745
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.CheckTextInputDelegate__DelegateSignature";

		// Token: 0x04003D82 RID: 15746
		private static int RegisterId;

		// Token: 0x02000E68 RID: 3688
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FCheckTextInputDelegate_DelegateParams
		{
			// Token: 0x0400620F RID: 25103
			[FieldOffset(0)]
			public FString InString;

			// Token: 0x04006210 RID: 25104
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02000E69 RID: 3689
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006211 RID: 25105
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
