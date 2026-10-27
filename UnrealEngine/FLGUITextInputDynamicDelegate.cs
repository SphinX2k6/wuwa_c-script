using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020D2 RID: 8402
	public sealed class FLGUITextInputDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601FA67 RID: 129639 RVA: 0x002F10EF File Offset: 0x002EF2EF
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUITextInputDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601FA68 RID: 129640 RVA: 0x002F10FB File Offset: 0x002EF2FB
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUITextInputDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUITextInputDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUITextInputDynamicDelegate__DelegateSignature");
			}
			return FLGUITextInputDynamicDelegate._FunctionPtr;
		}

		// Token: 0x0601FA69 RID: 129641 RVA: 0x002F111E File Offset: 0x002EF31E
		public FLGUITextInputDynamicDelegate()
		{
		}

		// Token: 0x0601FA6A RID: 129642 RVA: 0x002F1126 File Offset: 0x002EF326
		[NullableContext(2)]
		public FLGUITextInputDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FA6B RID: 129643 RVA: 0x002F1130 File Offset: 0x002EF330
		public FLGUITextInputDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FA6C RID: 129644 RVA: 0x002F113B File Offset: 0x002EF33B
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601FA6D RID: 129645 RVA: 0x002F116D File Offset: 0x002EF36D
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<string> Callback)
		{
			if (FLGUITextInputDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUITextInputDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUITextInputDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUITextInputDynamicDelegate.OnScriptCallback));
				}
				FLGUITextInputDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUITextInputDynamicDelegate.RegisterId);
		}

		// Token: 0x0601FA6E RID: 129646 RVA: 0x002F11A8 File Offset: 0x002EF3A8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(string InString)
		{
			FLGUITextInputDynamicDelegate.__FLGUITextInputDynamicDelegate_DelegateParams* ptr = stackalloc FLGUITextInputDynamicDelegate.__FLGUITextInputDynamicDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLGUITextInputDynamicDelegate.__FLGUITextInputDynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUITextInputDynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->InString), InString);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FLGUITextInputDynamicDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601FA6F RID: 129647 RVA: 0x002F11FC File Offset: 0x002EF3FC
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
			string obj = FString.ToString((void*)(&((FLGUITextInputDynamicDelegate.__FLGUITextInputDynamicDelegate_DelegateParams*)__Parameters)->InString));
			action(obj);
		}

		// Token: 0x04011141 RID: 69953
		internal static IntPtr _FunctionPtr;

		// Token: 0x04011142 RID: 69954
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUITextInputDynamicDelegate__DelegateSignature";

		// Token: 0x04011143 RID: 69955
		private static int RegisterId;

		// Token: 0x020034C8 RID: 13512
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FLGUITextInputDynamicDelegate_DelegateParams
		{
			// Token: 0x040174D3 RID: 95443
			[FieldOffset(0)]
			public FString InString;
		}

		// Token: 0x020034C9 RID: 13513
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040174D4 RID: 95444
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
