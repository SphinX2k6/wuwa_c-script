using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028B6 RID: 10422
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSpineWidgetBeforeUpdateWorldTransformDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06026B14 RID: 158484 RVA: 0x003B09E1 File Offset: 0x003AEBE1
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSpineWidgetBeforeUpdateWorldTransformDelegate.StaticFunctionPtr();
		}

		// Token: 0x06026B15 RID: 158485 RVA: 0x003B09ED File Offset: 0x003AEBED
		private static IntPtr StaticFunctionPtr()
		{
			if (FSpineWidgetBeforeUpdateWorldTransformDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSpineWidgetBeforeUpdateWorldTransformDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SpinePlugin.SpineWidgetBeforeUpdateWorldTransformDelegate__DelegateSignature");
			}
			return FSpineWidgetBeforeUpdateWorldTransformDelegate._FunctionPtr;
		}

		// Token: 0x06026B16 RID: 158486 RVA: 0x003B0A10 File Offset: 0x003AEC10
		public FSpineWidgetBeforeUpdateWorldTransformDelegate()
		{
		}

		// Token: 0x06026B17 RID: 158487 RVA: 0x003B0A18 File Offset: 0x003AEC18
		[NullableContext(2)]
		public FSpineWidgetBeforeUpdateWorldTransformDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026B18 RID: 158488 RVA: 0x003B0A22 File Offset: 0x003AEC22
		public FSpineWidgetBeforeUpdateWorldTransformDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026B19 RID: 158489 RVA: 0x003B0A2D File Offset: 0x003AEC2D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<USpineWidget>) ?? ((Action<USpineWidget>)Delegate.CreateDelegate(typeof(Action<USpineWidget>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06026B1A RID: 158490 RVA: 0x003B0A5F File Offset: 0x003AEC5F
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<USpineWidget> Callback)
		{
			if (FSpineWidgetBeforeUpdateWorldTransformDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSpineWidgetBeforeUpdateWorldTransformDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSpineWidgetBeforeUpdateWorldTransformDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSpineWidgetBeforeUpdateWorldTransformDelegate.OnScriptCallback));
				}
				FSpineWidgetBeforeUpdateWorldTransformDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSpineWidgetBeforeUpdateWorldTransformDelegate.RegisterId);
		}

		// Token: 0x06026B1B RID: 158491 RVA: 0x003B0A99 File Offset: 0x003AEC99
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<USpineWidget> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06026B1C RID: 158492 RVA: 0x003B0AA4 File Offset: 0x003AECA4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(USpineWidget skeleton)
		{
			FSpineWidgetBeforeUpdateWorldTransformDelegate.__FSpineWidgetBeforeUpdateWorldTransformDelegate_DelegateParams* ptr = stackalloc FSpineWidgetBeforeUpdateWorldTransformDelegate.__FSpineWidgetBeforeUpdateWorldTransformDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FSpineWidgetBeforeUpdateWorldTransformDelegate.__FSpineWidgetBeforeUpdateWorldTransformDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSpineWidgetBeforeUpdateWorldTransformDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->skeleton = ((skeleton != null) ? skeleton.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06026B1D RID: 158493 RVA: 0x003B0AF0 File Offset: 0x003AECF0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<USpineWidget> action = target as Action<USpineWidget>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			USpineWidget orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USpineWidget>(((FSpineWidgetBeforeUpdateWorldTransformDelegate.__FSpineWidgetBeforeUpdateWorldTransformDelegate_DelegateParams*)__Parameters)->skeleton);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x040153D6 RID: 86998
		internal static IntPtr _FunctionPtr;

		// Token: 0x040153D7 RID: 86999
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SpinePlugin.SpineWidgetBeforeUpdateWorldTransformDelegate__DelegateSignature";

		// Token: 0x040153D8 RID: 87000
		private static int RegisterId;

		// Token: 0x02003B4A RID: 15178
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FSpineWidgetBeforeUpdateWorldTransformDelegate_DelegateParams
		{
			// Token: 0x04017CEF RID: 97519
			[FieldOffset(0)]
			public IntPtr skeleton;
		}

		// Token: 0x02003B4B RID: 15179
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017CF0 RID: 97520
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
