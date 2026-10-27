using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017A1 RID: 6049
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FKuroCSAxisInstanceLayoutRebuiltSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06015CF4 RID: 89332 RVA: 0x00200787 File Offset: 0x001FE987
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroCSAxisInstanceLayoutRebuiltSignature.StaticFunctionPtr();
		}

		// Token: 0x06015CF5 RID: 89333 RVA: 0x00200793 File Offset: 0x001FE993
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroCSAxisInstanceLayoutRebuiltSignature._FunctionPtr == IntPtr.Zero)
			{
				FKuroCSAxisInstanceLayoutRebuiltSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroComputeShader.KuroCSAxisInstanceLayoutRebuiltSignature__DelegateSignature");
			}
			return FKuroCSAxisInstanceLayoutRebuiltSignature._FunctionPtr;
		}

		// Token: 0x06015CF6 RID: 89334 RVA: 0x002007B6 File Offset: 0x001FE9B6
		public FKuroCSAxisInstanceLayoutRebuiltSignature()
		{
		}

		// Token: 0x06015CF7 RID: 89335 RVA: 0x002007BE File Offset: 0x001FE9BE
		[NullableContext(2)]
		public FKuroCSAxisInstanceLayoutRebuiltSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015CF8 RID: 89336 RVA: 0x002007C8 File Offset: 0x001FE9C8
		public FKuroCSAxisInstanceLayoutRebuiltSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015CF9 RID: 89337 RVA: 0x002007D3 File Offset: 0x001FE9D3
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06015CFA RID: 89338 RVA: 0x00200805 File Offset: 0x001FEA05
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int> Callback)
		{
			if (FKuroCSAxisInstanceLayoutRebuiltSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroCSAxisInstanceLayoutRebuiltSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroCSAxisInstanceLayoutRebuiltSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroCSAxisInstanceLayoutRebuiltSignature.OnScriptCallback));
				}
				FKuroCSAxisInstanceLayoutRebuiltSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FKuroCSAxisInstanceLayoutRebuiltSignature.RegisterId);
		}

		// Token: 0x06015CFB RID: 89339 RVA: 0x0020083F File Offset: 0x001FEA3F
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06015CFC RID: 89340 RVA: 0x00200848 File Offset: 0x001FEA48
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int InstanceCount)
		{
			FKuroCSAxisInstanceLayoutRebuiltSignature.__FKuroCSAxisInstanceLayoutRebuiltSignature_DelegateParams* ptr = stackalloc FKuroCSAxisInstanceLayoutRebuiltSignature.__FKuroCSAxisInstanceLayoutRebuiltSignature_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FKuroCSAxisInstanceLayoutRebuiltSignature.__FKuroCSAxisInstanceLayoutRebuiltSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroCSAxisInstanceLayoutRebuiltSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->InstanceCount = InstanceCount;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06015CFD RID: 89341 RVA: 0x00200884 File Offset: 0x001FEA84
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FKuroCSAxisInstanceLayoutRebuiltSignature.__FKuroCSAxisInstanceLayoutRebuiltSignature_DelegateParams*)__Parameters)->InstanceCount);
		}

		// Token: 0x0400BE5C RID: 48732
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400BE5D RID: 48733
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroCSAxisInstanceLayoutRebuiltSignature__DelegateSignature";

		// Token: 0x0400BE5E RID: 48734
		private static int RegisterId;

		// Token: 0x02002F2F RID: 12079
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FKuroCSAxisInstanceLayoutRebuiltSignature_DelegateParams
		{
			// Token: 0x04016AAB RID: 92843
			[FieldOffset(0)]
			public int InstanceCount;
		}

		// Token: 0x02002F30 RID: 12080
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016AAC RID: 92844
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
