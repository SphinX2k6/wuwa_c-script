using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017F6 RID: 6134
	public sealed class FAsyncTraceDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06016AEE RID: 92910 RVA: 0x00211A57 File Offset: 0x0020FC57
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FAsyncTraceDelegate.StaticFunctionPtr();
		}

		// Token: 0x06016AEF RID: 92911 RVA: 0x00211A63 File Offset: 0x0020FC63
		private static IntPtr StaticFunctionPtr()
		{
			if (FAsyncTraceDelegate._FunctionPtr == IntPtr.Zero)
			{
				FAsyncTraceDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroData.AsyncTraceDelegate__DelegateSignature");
			}
			return FAsyncTraceDelegate._FunctionPtr;
		}

		// Token: 0x06016AF0 RID: 92912 RVA: 0x00211A86 File Offset: 0x0020FC86
		public FAsyncTraceDelegate()
		{
		}

		// Token: 0x06016AF1 RID: 92913 RVA: 0x00211A8E File Offset: 0x0020FC8E
		[NullableContext(2)]
		public FAsyncTraceDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016AF2 RID: 92914 RVA: 0x00211A98 File Offset: 0x0020FC98
		public FAsyncTraceDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016AF3 RID: 92915 RVA: 0x00211AA3 File Offset: 0x0020FCA3
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool, UTraceBaseElement, double, double>) ?? ((Action<bool, UTraceBaseElement, double, double>)Delegate.CreateDelegate(typeof(Action<bool, UTraceBaseElement, double, double>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06016AF4 RID: 92916 RVA: 0x00211AD5 File Offset: 0x0020FCD5
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<bool, UTraceBaseElement, double, double> Callback)
		{
			if (FAsyncTraceDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FAsyncTraceDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FAsyncTraceDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FAsyncTraceDelegate.OnScriptCallback));
				}
				FAsyncTraceDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FAsyncTraceDelegate.RegisterId);
		}

		// Token: 0x06016AF5 RID: 92917 RVA: 0x00211B10 File Offset: 0x0020FD10
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(bool Result, UTraceBaseElement Element, double Frame, double Index)
		{
			FAsyncTraceDelegate.__FAsyncTraceDelegate_DelegateParams* ptr = stackalloc FAsyncTraceDelegate.__FAsyncTraceDelegate_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FAsyncTraceDelegate.__FAsyncTraceDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FAsyncTraceDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Result = Result;
			ptr->Element = ((Element != null) ? Element.NativePtr : IntPtr.Zero);
			ptr->Frame = Frame;
			ptr->Index = Index;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06016AF6 RID: 92918 RVA: 0x00211B74 File Offset: 0x0020FD74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool, UTraceBaseElement, double, double> action = target as Action<bool, UTraceBaseElement, double, double>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UTraceBaseElement orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UTraceBaseElement>(((FAsyncTraceDelegate.__FAsyncTraceDelegate_DelegateParams*)__Parameters)->Element);
			action(((FAsyncTraceDelegate.__FAsyncTraceDelegate_DelegateParams*)__Parameters)->Result, orCreateUObjectByNativePointer, ((FAsyncTraceDelegate.__FAsyncTraceDelegate_DelegateParams*)__Parameters)->Frame, ((FAsyncTraceDelegate.__FAsyncTraceDelegate_DelegateParams*)__Parameters)->Index);
		}

		// Token: 0x0400C50C RID: 50444
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400C50D RID: 50445
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroData.AsyncTraceDelegate__DelegateSignature";

		// Token: 0x0400C50E RID: 50446
		private static int RegisterId;

		// Token: 0x02002F4B RID: 12107
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FAsyncTraceDelegate_DelegateParams
		{
			// Token: 0x04016AEB RID: 92907
			[FieldOffset(0)]
			public bool Result;

			// Token: 0x04016AEC RID: 92908
			[FieldOffset(8)]
			public IntPtr Element;

			// Token: 0x04016AED RID: 92909
			[FieldOffset(16)]
			public double Frame;

			// Token: 0x04016AEE RID: 92910
			[FieldOffset(24)]
			public double Index;
		}

		// Token: 0x02002F4C RID: 12108
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016AEF RID: 92911
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
