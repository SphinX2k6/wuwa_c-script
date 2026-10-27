using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020D1 RID: 8401
	public sealed class FLGUITextInputCustomInputTypeDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601FA5E RID: 129630 RVA: 0x002F0F7D File Offset: 0x002EF17D
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUITextInputCustomInputTypeDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601FA5F RID: 129631 RVA: 0x002F0F89 File Offset: 0x002EF189
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUITextInputCustomInputTypeDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUITextInputCustomInputTypeDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUITextInputCustomInputTypeDynamicDelegate__DelegateSignature");
			}
			return FLGUITextInputCustomInputTypeDynamicDelegate._FunctionPtr;
		}

		// Token: 0x0601FA60 RID: 129632 RVA: 0x002F0FAC File Offset: 0x002EF1AC
		public FLGUITextInputCustomInputTypeDynamicDelegate()
		{
		}

		// Token: 0x0601FA61 RID: 129633 RVA: 0x002F0FB4 File Offset: 0x002EF1B4
		[NullableContext(2)]
		public FLGUITextInputCustomInputTypeDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FA62 RID: 129634 RVA: 0x002F0FBE File Offset: 0x002EF1BE
		public FLGUITextInputCustomInputTypeDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FA63 RID: 129635 RVA: 0x002F0FC9 File Offset: 0x002EF1C9
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<string, bool>) ?? ((Func<string, bool>)Delegate.CreateDelegate(typeof(Func<string, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601FA64 RID: 129636 RVA: 0x002F0FFB File Offset: 0x002EF1FB
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Func<string, bool> Callback)
		{
			if (FLGUITextInputCustomInputTypeDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUITextInputCustomInputTypeDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUITextInputCustomInputTypeDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUITextInputCustomInputTypeDynamicDelegate.OnScriptCallback));
				}
				FLGUITextInputCustomInputTypeDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUITextInputCustomInputTypeDynamicDelegate.RegisterId);
		}

		// Token: 0x0601FA65 RID: 129637 RVA: 0x002F1038 File Offset: 0x002EF238
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool Execute(string InString)
		{
			FLGUITextInputCustomInputTypeDynamicDelegate.__FLGUITextInputCustomInputTypeDynamicDelegate_DelegateParams* ptr = stackalloc FLGUITextInputCustomInputTypeDynamicDelegate.__FLGUITextInputCustomInputTypeDynamicDelegate_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FLGUITextInputCustomInputTypeDynamicDelegate.__FLGUITextInputCustomInputTypeDynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUITextInputCustomInputTypeDynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->InString), InString);
			base.ExecuteInternal((void*)ptr);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(FLGUITextInputCustomInputTypeDynamicDelegate._FunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601FA66 RID: 129638 RVA: 0x002F1094 File Offset: 0x002EF294
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<string, bool> func = target as Func<string, bool>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FLGUITextInputCustomInputTypeDynamicDelegate.__FLGUITextInputCustomInputTypeDynamicDelegate_DelegateParams*)__Parameters)->InString));
			bool _Result = func(arg);
			((FLGUITextInputCustomInputTypeDynamicDelegate.__FLGUITextInputCustomInputTypeDynamicDelegate_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x0401113E RID: 69950
		internal static IntPtr _FunctionPtr;

		// Token: 0x0401113F RID: 69951
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUITextInputCustomInputTypeDynamicDelegate__DelegateSignature";

		// Token: 0x04011140 RID: 69952
		private static int RegisterId;

		// Token: 0x020034C6 RID: 13510
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FLGUITextInputCustomInputTypeDynamicDelegate_DelegateParams
		{
			// Token: 0x040174D0 RID: 95440
			[FieldOffset(0)]
			public FString InString;

			// Token: 0x040174D1 RID: 95441
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x020034C7 RID: 13511
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040174D2 RID: 95442
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
