using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200022D RID: 557
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FAkOnCheckBoxComponentStateChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060020AD RID: 8365 RVA: 0x00030887 File Offset: 0x0002EA87
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FAkOnCheckBoxComponentStateChanged.StaticFunctionPtr();
		}

		// Token: 0x060020AE RID: 8366 RVA: 0x00030893 File Offset: 0x0002EA93
		private static IntPtr StaticFunctionPtr()
		{
			if (FAkOnCheckBoxComponentStateChanged._FunctionPtr == IntPtr.Zero)
			{
				FAkOnCheckBoxComponentStateChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AkAudio.AkOnCheckBoxComponentStateChanged__DelegateSignature");
			}
			return FAkOnCheckBoxComponentStateChanged._FunctionPtr;
		}

		// Token: 0x060020AF RID: 8367 RVA: 0x000308B6 File Offset: 0x0002EAB6
		public FAkOnCheckBoxComponentStateChanged()
		{
		}

		// Token: 0x060020B0 RID: 8368 RVA: 0x000308BE File Offset: 0x0002EABE
		[NullableContext(2)]
		public FAkOnCheckBoxComponentStateChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060020B1 RID: 8369 RVA: 0x000308C8 File Offset: 0x0002EAC8
		public FAkOnCheckBoxComponentStateChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060020B2 RID: 8370 RVA: 0x000308D3 File Offset: 0x0002EAD3
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060020B3 RID: 8371 RVA: 0x00030905 File Offset: 0x0002EB05
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<bool> Callback)
		{
			if (FAkOnCheckBoxComponentStateChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FAkOnCheckBoxComponentStateChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FAkOnCheckBoxComponentStateChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FAkOnCheckBoxComponentStateChanged.OnScriptCallback));
				}
				FAkOnCheckBoxComponentStateChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FAkOnCheckBoxComponentStateChanged.RegisterId);
		}

		// Token: 0x060020B4 RID: 8372 RVA: 0x0003093F File Offset: 0x0002EB3F
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060020B5 RID: 8373 RVA: 0x00030948 File Offset: 0x0002EB48
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(bool bIsChecked)
		{
			FAkOnCheckBoxComponentStateChanged.__FAkOnCheckBoxComponentStateChanged_DelegateParams* ptr = stackalloc FAkOnCheckBoxComponentStateChanged.__FAkOnCheckBoxComponentStateChanged_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FAkOnCheckBoxComponentStateChanged.__FAkOnCheckBoxComponentStateChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FAkOnCheckBoxComponentStateChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bIsChecked = bIsChecked;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060020B6 RID: 8374 RVA: 0x00030984 File Offset: 0x0002EB84
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FAkOnCheckBoxComponentStateChanged.__FAkOnCheckBoxComponentStateChanged_DelegateParams*)__Parameters)->bIsChecked);
		}

		// Token: 0x04000AFE RID: 2814
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000AFF RID: 2815
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AkAudio.AkOnCheckBoxComponentStateChanged__DelegateSignature";

		// Token: 0x04000B00 RID: 2816
		private static int RegisterId;

		// Token: 0x02002B87 RID: 11143
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FAkOnCheckBoxComponentStateChanged_DelegateParams
		{
			// Token: 0x0401641A RID: 91162
			[FieldOffset(0)]
			public bool bIsChecked;
		}

		// Token: 0x02002B88 RID: 11144
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401641B RID: 91163
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
