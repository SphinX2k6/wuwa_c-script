using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028A3 RID: 10403
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSpineAfterUpdateWorldTransformDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06026948 RID: 158024 RVA: 0x003ADD1A File Offset: 0x003ABF1A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSpineAfterUpdateWorldTransformDelegate.StaticFunctionPtr();
		}

		// Token: 0x06026949 RID: 158025 RVA: 0x003ADD26 File Offset: 0x003ABF26
		private static IntPtr StaticFunctionPtr()
		{
			if (FSpineAfterUpdateWorldTransformDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSpineAfterUpdateWorldTransformDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SpinePlugin.SpineAfterUpdateWorldTransformDelegate__DelegateSignature");
			}
			return FSpineAfterUpdateWorldTransformDelegate._FunctionPtr;
		}

		// Token: 0x0602694A RID: 158026 RVA: 0x003ADD49 File Offset: 0x003ABF49
		public FSpineAfterUpdateWorldTransformDelegate()
		{
		}

		// Token: 0x0602694B RID: 158027 RVA: 0x003ADD51 File Offset: 0x003ABF51
		[NullableContext(2)]
		public FSpineAfterUpdateWorldTransformDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602694C RID: 158028 RVA: 0x003ADD5B File Offset: 0x003ABF5B
		public FSpineAfterUpdateWorldTransformDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602694D RID: 158029 RVA: 0x003ADD66 File Offset: 0x003ABF66
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<USpineSkeletonComponent>) ?? ((Action<USpineSkeletonComponent>)Delegate.CreateDelegate(typeof(Action<USpineSkeletonComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0602694E RID: 158030 RVA: 0x003ADD98 File Offset: 0x003ABF98
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<USpineSkeletonComponent> Callback)
		{
			if (FSpineAfterUpdateWorldTransformDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSpineAfterUpdateWorldTransformDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSpineAfterUpdateWorldTransformDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSpineAfterUpdateWorldTransformDelegate.OnScriptCallback));
				}
				FSpineAfterUpdateWorldTransformDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSpineAfterUpdateWorldTransformDelegate.RegisterId);
		}

		// Token: 0x0602694F RID: 158031 RVA: 0x003ADDD2 File Offset: 0x003ABFD2
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<USpineSkeletonComponent> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06026950 RID: 158032 RVA: 0x003ADDDC File Offset: 0x003ABFDC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(USpineSkeletonComponent skeleton)
		{
			FSpineAfterUpdateWorldTransformDelegate.__FSpineAfterUpdateWorldTransformDelegate_DelegateParams* ptr = stackalloc FSpineAfterUpdateWorldTransformDelegate.__FSpineAfterUpdateWorldTransformDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FSpineAfterUpdateWorldTransformDelegate.__FSpineAfterUpdateWorldTransformDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSpineAfterUpdateWorldTransformDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->skeleton = ((skeleton != null) ? skeleton.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06026951 RID: 158033 RVA: 0x003ADE28 File Offset: 0x003AC028
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<USpineSkeletonComponent> action = target as Action<USpineSkeletonComponent>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			USpineSkeletonComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USpineSkeletonComponent>(((FSpineAfterUpdateWorldTransformDelegate.__FSpineAfterUpdateWorldTransformDelegate_DelegateParams*)__Parameters)->skeleton);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0401531E RID: 86814
		internal static IntPtr _FunctionPtr;

		// Token: 0x0401531F RID: 86815
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SpinePlugin.SpineAfterUpdateWorldTransformDelegate__DelegateSignature";

		// Token: 0x04015320 RID: 86816
		private static int RegisterId;

		// Token: 0x02003B38 RID: 15160
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FSpineAfterUpdateWorldTransformDelegate_DelegateParams
		{
			// Token: 0x04017CDC RID: 97500
			[FieldOffset(0)]
			public IntPtr skeleton;
		}

		// Token: 0x02003B39 RID: 15161
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017CDD RID: 97501
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
