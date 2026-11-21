using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006A5 RID: 1701
	public sealed class FLGUIMultiTemplateScrollViewItemCreateDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06009262 RID: 37474 RVA: 0x000DC7BF File Offset: 0x000DA9BF
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIMultiTemplateScrollViewItemCreateDelegate.StaticFunctionPtr();
		}

		// Token: 0x06009263 RID: 37475 RVA: 0x000DC7CB File Offset: 0x000DA9CB
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIMultiTemplateScrollViewItemCreateDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIMultiTemplateScrollViewItemCreateDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIMultiTemplateScrollViewItemCreateDelegate__DelegateSignature");
			}
			return FLGUIMultiTemplateScrollViewItemCreateDelegate._FunctionPtr;
		}

		// Token: 0x06009264 RID: 37476 RVA: 0x000DC7EE File Offset: 0x000DA9EE
		public FLGUIMultiTemplateScrollViewItemCreateDelegate()
		{
		}

		// Token: 0x06009265 RID: 37477 RVA: 0x000DC7F6 File Offset: 0x000DA9F6
		[NullableContext(2)]
		public FLGUIMultiTemplateScrollViewItemCreateDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009266 RID: 37478 RVA: 0x000DC800 File Offset: 0x000DAA00
		public FLGUIMultiTemplateScrollViewItemCreateDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009267 RID: 37479 RVA: 0x000DC80B File Offset: 0x000DAA0B
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, AUIBaseActor>) ?? ((Action<int, AUIBaseActor>)Delegate.CreateDelegate(typeof(Action<int, AUIBaseActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06009268 RID: 37480 RVA: 0x000DC83D File Offset: 0x000DAA3D
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<int, AUIBaseActor> Callback)
		{
			if (FLGUIMultiTemplateScrollViewItemCreateDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIMultiTemplateScrollViewItemCreateDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIMultiTemplateScrollViewItemCreateDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIMultiTemplateScrollViewItemCreateDelegate.OnScriptCallback));
				}
				FLGUIMultiTemplateScrollViewItemCreateDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIMultiTemplateScrollViewItemCreateDelegate.RegisterId);
		}

		// Token: 0x06009269 RID: 37481 RVA: 0x000DC878 File Offset: 0x000DAA78
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute(int GridIndex, AUIBaseActor Actor)
		{
			FLGUIMultiTemplateScrollViewItemCreateDelegate.__FLGUIMultiTemplateScrollViewItemCreateDelegate_DelegateParams* ptr = stackalloc FLGUIMultiTemplateScrollViewItemCreateDelegate.__FLGUIMultiTemplateScrollViewItemCreateDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLGUIMultiTemplateScrollViewItemCreateDelegate.__FLGUIMultiTemplateScrollViewItemCreateDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIMultiTemplateScrollViewItemCreateDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->GridIndex = GridIndex;
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600926A RID: 37482 RVA: 0x000DC8CC File Offset: 0x000DAACC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, AUIBaseActor> action = target as Action<int, AUIBaseActor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AUIBaseActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AUIBaseActor>(((FLGUIMultiTemplateScrollViewItemCreateDelegate.__FLGUIMultiTemplateScrollViewItemCreateDelegate_DelegateParams*)__Parameters)->Actor);
			action(((FLGUIMultiTemplateScrollViewItemCreateDelegate.__FLGUIMultiTemplateScrollViewItemCreateDelegate_DelegateParams*)__Parameters)->GridIndex, orCreateUObjectByNativePointer);
		}

		// Token: 0x04003FD6 RID: 16342
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003FD7 RID: 16343
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIMultiTemplateScrollViewItemCreateDelegate__DelegateSignature";

		// Token: 0x04003FD8 RID: 16344
		private static int RegisterId;

		// Token: 0x02000ECF RID: 3791
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FLGUIMultiTemplateScrollViewItemCreateDelegate_DelegateParams
		{
			// Token: 0x0400628C RID: 25228
			[FieldOffset(0)]
			public int GridIndex;

			// Token: 0x0400628D RID: 25229
			[FieldOffset(8)]
			public IntPtr Actor;
		}

		// Token: 0x02000ED0 RID: 3792
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400628E RID: 25230
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
