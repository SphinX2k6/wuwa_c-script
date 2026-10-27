using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020CF RID: 8399
	public sealed class FLGUITextClickDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601FA4C RID: 129612 RVA: 0x002F0CB6 File Offset: 0x002EEEB6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUITextClickDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601FA4D RID: 129613 RVA: 0x002F0CC2 File Offset: 0x002EEEC2
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUITextClickDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUITextClickDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUITextClickDelegate__DelegateSignature");
			}
			return FLGUITextClickDelegate._FunctionPtr;
		}

		// Token: 0x0601FA4E RID: 129614 RVA: 0x002F0CE5 File Offset: 0x002EEEE5
		public FLGUITextClickDelegate()
		{
		}

		// Token: 0x0601FA4F RID: 129615 RVA: 0x002F0CED File Offset: 0x002EEEED
		[NullableContext(2)]
		public FLGUITextClickDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FA50 RID: 129616 RVA: 0x002F0CF7 File Offset: 0x002EEEF7
		public FLGUITextClickDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FA51 RID: 129617 RVA: 0x002F0D02 File Offset: 0x002EEF02
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<string, bool>) ?? ((Func<string, bool>)Delegate.CreateDelegate(typeof(Func<string, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601FA52 RID: 129618 RVA: 0x002F0D34 File Offset: 0x002EEF34
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Func<string, bool> Callback)
		{
			if (FLGUITextClickDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUITextClickDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUITextClickDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUITextClickDelegate.OnScriptCallback));
				}
				FLGUITextClickDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUITextClickDelegate.RegisterId);
		}

		// Token: 0x0601FA53 RID: 129619 RVA: 0x002F0D70 File Offset: 0x002EEF70
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool Execute(string HyperLink)
		{
			FLGUITextClickDelegate.__FLGUITextClickDelegate_DelegateParams* ptr = stackalloc FLGUITextClickDelegate.__FLGUITextClickDelegate_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FLGUITextClickDelegate.__FLGUITextClickDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUITextClickDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->HyperLink), HyperLink);
			base.ExecuteInternal((void*)ptr);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(FLGUITextClickDelegate._FunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601FA54 RID: 129620 RVA: 0x002F0DCC File Offset: 0x002EEFCC
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
			string arg = FString.ToString((void*)(&((FLGUITextClickDelegate.__FLGUITextClickDelegate_DelegateParams*)__Parameters)->HyperLink));
			bool _Result = func(arg);
			((FLGUITextClickDelegate.__FLGUITextClickDelegate_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x04011138 RID: 69944
		internal static IntPtr _FunctionPtr;

		// Token: 0x04011139 RID: 69945
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUITextClickDelegate__DelegateSignature";

		// Token: 0x0401113A RID: 69946
		private static int RegisterId;

		// Token: 0x020034C2 RID: 13506
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FLGUITextClickDelegate_DelegateParams
		{
			// Token: 0x040174CB RID: 95435
			[FieldOffset(0)]
			public FString HyperLink;

			// Token: 0x040174CC RID: 95436
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x020034C3 RID: 13507
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040174CD RID: 95437
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
