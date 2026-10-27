using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200173A RID: 5946
	public sealed class FCloudGameOnChangeResolutionDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06015663 RID: 87651 RVA: 0x001F7051 File Offset: 0x001F5251
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FCloudGameOnChangeResolutionDelegate.StaticFunctionPtr();
		}

		// Token: 0x06015664 RID: 87652 RVA: 0x001F705D File Offset: 0x001F525D
		private static IntPtr StaticFunctionPtr()
		{
			if (FCloudGameOnChangeResolutionDelegate._FunctionPtr == IntPtr.Zero)
			{
				FCloudGameOnChangeResolutionDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroCloudGame.CloudGameOnChangeResolutionDelegate__DelegateSignature");
			}
			return FCloudGameOnChangeResolutionDelegate._FunctionPtr;
		}

		// Token: 0x06015665 RID: 87653 RVA: 0x001F7080 File Offset: 0x001F5280
		public FCloudGameOnChangeResolutionDelegate()
		{
		}

		// Token: 0x06015666 RID: 87654 RVA: 0x001F7088 File Offset: 0x001F5288
		[NullableContext(2)]
		public FCloudGameOnChangeResolutionDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015667 RID: 87655 RVA: 0x001F7092 File Offset: 0x001F5292
		public FCloudGameOnChangeResolutionDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015668 RID: 87656 RVA: 0x001F709D File Offset: 0x001F529D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, int>) ?? ((Action<int, int>)Delegate.CreateDelegate(typeof(Action<int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06015669 RID: 87657 RVA: 0x001F70CF File Offset: 0x001F52CF
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<int, int> Callback)
		{
			if (FCloudGameOnChangeResolutionDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FCloudGameOnChangeResolutionDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FCloudGameOnChangeResolutionDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FCloudGameOnChangeResolutionDelegate.OnScriptCallback));
				}
				FCloudGameOnChangeResolutionDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FCloudGameOnChangeResolutionDelegate.RegisterId);
		}

		// Token: 0x0601566A RID: 87658 RVA: 0x001F710C File Offset: 0x001F530C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int Width, int Height)
		{
			FCloudGameOnChangeResolutionDelegate.__FCloudGameOnChangeResolutionDelegate_DelegateParams* ptr = stackalloc FCloudGameOnChangeResolutionDelegate.__FCloudGameOnChangeResolutionDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FCloudGameOnChangeResolutionDelegate.__FCloudGameOnChangeResolutionDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FCloudGameOnChangeResolutionDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Width = Width;
			ptr->Height = Height;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601566B RID: 87659 RVA: 0x001F7150 File Offset: 0x001F5350
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, int> action = target as Action<int, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FCloudGameOnChangeResolutionDelegate.__FCloudGameOnChangeResolutionDelegate_DelegateParams*)__Parameters)->Width, ((FCloudGameOnChangeResolutionDelegate.__FCloudGameOnChangeResolutionDelegate_DelegateParams*)__Parameters)->Height);
		}

		// Token: 0x0400BAB2 RID: 47794
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400BAB3 RID: 47795
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroCloudGame.CloudGameOnChangeResolutionDelegate__DelegateSignature";

		// Token: 0x0400BAB4 RID: 47796
		private static int RegisterId;

		// Token: 0x02002EFA RID: 12026
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FCloudGameOnChangeResolutionDelegate_DelegateParams
		{
			// Token: 0x04016A36 RID: 92726
			[FieldOffset(0)]
			public int Width;

			// Token: 0x04016A37 RID: 92727
			[FieldOffset(4)]
			public int Height;
		}

		// Token: 0x02002EFB RID: 12027
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016A38 RID: 92728
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
