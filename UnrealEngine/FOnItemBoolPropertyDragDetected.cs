using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200028E RID: 654
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnItemBoolPropertyDragDetected : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060024AB RID: 9387 RVA: 0x00036751 File Offset: 0x00034951
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnItemBoolPropertyDragDetected.StaticFunctionPtr();
		}

		// Token: 0x060024AC RID: 9388 RVA: 0x0003675D File Offset: 0x0003495D
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnItemBoolPropertyDragDetected._FunctionPtr == IntPtr.Zero)
			{
				FOnItemBoolPropertyDragDetected._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AkAudio.OnItemBoolPropertyDragDetected__DelegateSignature");
			}
			return FOnItemBoolPropertyDragDetected._FunctionPtr;
		}

		// Token: 0x060024AD RID: 9389 RVA: 0x00036780 File Offset: 0x00034980
		public FOnItemBoolPropertyDragDetected()
		{
		}

		// Token: 0x060024AE RID: 9390 RVA: 0x00036788 File Offset: 0x00034988
		[NullableContext(2)]
		public FOnItemBoolPropertyDragDetected(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060024AF RID: 9391 RVA: 0x00036792 File Offset: 0x00034992
		public FOnItemBoolPropertyDragDetected(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060024B0 RID: 9392 RVA: 0x0003679D File Offset: 0x0003499D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060024B1 RID: 9393 RVA: 0x000367CF File Offset: 0x000349CF
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<string> Callback)
		{
			if (FOnItemBoolPropertyDragDetected.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnItemBoolPropertyDragDetected.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnItemBoolPropertyDragDetected.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnItemBoolPropertyDragDetected.OnScriptCallback));
				}
				FOnItemBoolPropertyDragDetected.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnItemBoolPropertyDragDetected.RegisterId);
		}

		// Token: 0x060024B2 RID: 9394 RVA: 0x00036809 File Offset: 0x00034A09
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060024B3 RID: 9395 RVA: 0x00036814 File Offset: 0x00034A14
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(string PropertyDragged)
		{
			FOnItemBoolPropertyDragDetected.__FOnItemBoolPropertyDragDetected_DelegateParams* ptr = stackalloc FOnItemBoolPropertyDragDetected.__FOnItemBoolPropertyDragDetected_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnItemBoolPropertyDragDetected.__FOnItemBoolPropertyDragDetected_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnItemBoolPropertyDragDetected.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->PropertyDragged), PropertyDragged);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FOnItemBoolPropertyDragDetected._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060024B4 RID: 9396 RVA: 0x00036868 File Offset: 0x00034A68
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
			string obj = FString.ToString((void*)(&((FOnItemBoolPropertyDragDetected.__FOnItemBoolPropertyDragDetected_DelegateParams*)__Parameters)->PropertyDragged));
			action(obj);
		}

		// Token: 0x04000DF4 RID: 3572
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000DF5 RID: 3573
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AkAudio.OnItemBoolPropertyDragDetected__DelegateSignature";

		// Token: 0x04000DF6 RID: 3574
		private static int RegisterId;

		// Token: 0x02002B91 RID: 11153
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnItemBoolPropertyDragDetected_DelegateParams
		{
			// Token: 0x04016426 RID: 91174
			[FieldOffset(0)]
			public FString PropertyDragged;
		}

		// Token: 0x02002B92 RID: 11154
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016427 RID: 91175
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
