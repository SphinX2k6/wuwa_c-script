using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200028F RID: 655
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnItemBoolPropertySelectionChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060024B5 RID: 9397 RVA: 0x000368BA File Offset: 0x00034ABA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnItemBoolPropertySelectionChanged.StaticFunctionPtr();
		}

		// Token: 0x060024B6 RID: 9398 RVA: 0x000368C6 File Offset: 0x00034AC6
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnItemBoolPropertySelectionChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnItemBoolPropertySelectionChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AkAudio.OnItemBoolPropertySelectionChanged__DelegateSignature");
			}
			return FOnItemBoolPropertySelectionChanged._FunctionPtr;
		}

		// Token: 0x060024B7 RID: 9399 RVA: 0x000368E9 File Offset: 0x00034AE9
		public FOnItemBoolPropertySelectionChanged()
		{
		}

		// Token: 0x060024B8 RID: 9400 RVA: 0x000368F1 File Offset: 0x00034AF1
		[NullableContext(2)]
		public FOnItemBoolPropertySelectionChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060024B9 RID: 9401 RVA: 0x000368FB File Offset: 0x00034AFB
		public FOnItemBoolPropertySelectionChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060024BA RID: 9402 RVA: 0x00036906 File Offset: 0x00034B06
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060024BB RID: 9403 RVA: 0x00036938 File Offset: 0x00034B38
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<string> Callback)
		{
			if (FOnItemBoolPropertySelectionChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnItemBoolPropertySelectionChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnItemBoolPropertySelectionChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnItemBoolPropertySelectionChanged.OnScriptCallback));
				}
				FOnItemBoolPropertySelectionChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnItemBoolPropertySelectionChanged.RegisterId);
		}

		// Token: 0x060024BC RID: 9404 RVA: 0x00036972 File Offset: 0x00034B72
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060024BD RID: 9405 RVA: 0x0003697C File Offset: 0x00034B7C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(string PropertySelected)
		{
			FOnItemBoolPropertySelectionChanged.__FOnItemBoolPropertySelectionChanged_DelegateParams* ptr = stackalloc FOnItemBoolPropertySelectionChanged.__FOnItemBoolPropertySelectionChanged_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnItemBoolPropertySelectionChanged.__FOnItemBoolPropertySelectionChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnItemBoolPropertySelectionChanged.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->PropertySelected), PropertySelected);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FOnItemBoolPropertySelectionChanged._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060024BE RID: 9406 RVA: 0x000369D0 File Offset: 0x00034BD0
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
			string obj = FString.ToString((void*)(&((FOnItemBoolPropertySelectionChanged.__FOnItemBoolPropertySelectionChanged_DelegateParams*)__Parameters)->PropertySelected));
			action(obj);
		}

		// Token: 0x04000DF7 RID: 3575
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000DF8 RID: 3576
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AkAudio.OnItemBoolPropertySelectionChanged__DelegateSignature";

		// Token: 0x04000DF9 RID: 3577
		private static int RegisterId;

		// Token: 0x02002B93 RID: 11155
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnItemBoolPropertySelectionChanged_DelegateParams
		{
			// Token: 0x04016428 RID: 91176
			[FieldOffset(0)]
			public FString PropertySelected;
		}

		// Token: 0x02002B94 RID: 11156
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016429 RID: 91177
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
