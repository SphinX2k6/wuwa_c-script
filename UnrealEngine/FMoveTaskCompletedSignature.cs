using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001CD RID: 461
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FMoveTaskCompletedSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06001B37 RID: 6967 RVA: 0x000289A1 File Offset: 0x00026BA1
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FMoveTaskCompletedSignature.StaticFunctionPtr();
		}

		// Token: 0x06001B38 RID: 6968 RVA: 0x000289AD File Offset: 0x00026BAD
		private static IntPtr StaticFunctionPtr()
		{
			if (FMoveTaskCompletedSignature._FunctionPtr == IntPtr.Zero)
			{
				FMoveTaskCompletedSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AIModule.MoveTaskCompletedSignature__DelegateSignature");
			}
			return FMoveTaskCompletedSignature._FunctionPtr;
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x000289D0 File Offset: 0x00026BD0
		public FMoveTaskCompletedSignature()
		{
		}

		// Token: 0x06001B3A RID: 6970 RVA: 0x000289D8 File Offset: 0x00026BD8
		[NullableContext(2)]
		public FMoveTaskCompletedSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001B3B RID: 6971 RVA: 0x000289E2 File Offset: 0x00026BE2
		public FMoveTaskCompletedSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001B3C RID: 6972 RVA: 0x000289ED File Offset: 0x00026BED
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TEnumAsByte<EPathFollowingResult>, AAIController>) ?? ((Action<TEnumAsByte<EPathFollowingResult>, AAIController>)Delegate.CreateDelegate(typeof(Action<TEnumAsByte<EPathFollowingResult>, AAIController>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x00028A1F File Offset: 0x00026C1F
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			0,
			2
		})] Action<TEnumAsByte<EPathFollowingResult>, AAIController> Callback)
		{
			if (FMoveTaskCompletedSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FMoveTaskCompletedSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FMoveTaskCompletedSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FMoveTaskCompletedSignature.OnScriptCallback));
				}
				FMoveTaskCompletedSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FMoveTaskCompletedSignature.RegisterId);
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x00028A59 File Offset: 0x00026C59
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			0,
			2
		})] Action<TEnumAsByte<EPathFollowingResult>, AAIController> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x00028A64 File Offset: 0x00026C64
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(EPathFollowingResult Result, AAIController AIController)
		{
			FMoveTaskCompletedSignature.__FMoveTaskCompletedSignature_DelegateParams* ptr = stackalloc FMoveTaskCompletedSignature.__FMoveTaskCompletedSignature_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FMoveTaskCompletedSignature.__FMoveTaskCompletedSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FMoveTaskCompletedSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Result = Result;
			ptr->AIController = ((AIController != null) ? AIController.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06001B40 RID: 6976 RVA: 0x00028ABC File Offset: 0x00026CBC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<TEnumAsByte<EPathFollowingResult>, AAIController> action = target as Action<TEnumAsByte<EPathFollowingResult>, AAIController>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(((FMoveTaskCompletedSignature.__FMoveTaskCompletedSignature_DelegateParams*)__Parameters)->AIController);
			action(((FMoveTaskCompletedSignature.__FMoveTaskCompletedSignature_DelegateParams*)__Parameters)->Result, orCreateUObjectByNativePointer);
		}

		// Token: 0x040008B5 RID: 2229
		internal static IntPtr _FunctionPtr;

		// Token: 0x040008B6 RID: 2230
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AIModule.MoveTaskCompletedSignature__DelegateSignature";

		// Token: 0x040008B7 RID: 2231
		private static int RegisterId;

		// Token: 0x02002B6C RID: 11116
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FMoveTaskCompletedSignature_DelegateParams
		{
			// Token: 0x040163F3 RID: 91123
			[FieldOffset(0)]
			public TEnumAsByte<EPathFollowingResult> Result;

			// Token: 0x040163F4 RID: 91124
			[FieldOffset(8)]
			public IntPtr AIController;
		}

		// Token: 0x02002B6D RID: 11117
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040163F5 RID: 91125
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
