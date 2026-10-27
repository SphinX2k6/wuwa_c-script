using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028B5 RID: 10421
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSpineWidgetAfterUpdateWorldTransformDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06026B0A RID: 158474 RVA: 0x003B0882 File Offset: 0x003AEA82
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSpineWidgetAfterUpdateWorldTransformDelegate.StaticFunctionPtr();
		}

		// Token: 0x06026B0B RID: 158475 RVA: 0x003B088E File Offset: 0x003AEA8E
		private static IntPtr StaticFunctionPtr()
		{
			if (FSpineWidgetAfterUpdateWorldTransformDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSpineWidgetAfterUpdateWorldTransformDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SpinePlugin.SpineWidgetAfterUpdateWorldTransformDelegate__DelegateSignature");
			}
			return FSpineWidgetAfterUpdateWorldTransformDelegate._FunctionPtr;
		}

		// Token: 0x06026B0C RID: 158476 RVA: 0x003B08B1 File Offset: 0x003AEAB1
		public FSpineWidgetAfterUpdateWorldTransformDelegate()
		{
		}

		// Token: 0x06026B0D RID: 158477 RVA: 0x003B08B9 File Offset: 0x003AEAB9
		[NullableContext(2)]
		public FSpineWidgetAfterUpdateWorldTransformDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026B0E RID: 158478 RVA: 0x003B08C3 File Offset: 0x003AEAC3
		public FSpineWidgetAfterUpdateWorldTransformDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026B0F RID: 158479 RVA: 0x003B08CE File Offset: 0x003AEACE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<USpineWidget>) ?? ((Action<USpineWidget>)Delegate.CreateDelegate(typeof(Action<USpineWidget>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06026B10 RID: 158480 RVA: 0x003B0900 File Offset: 0x003AEB00
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<USpineWidget> Callback)
		{
			if (FSpineWidgetAfterUpdateWorldTransformDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSpineWidgetAfterUpdateWorldTransformDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSpineWidgetAfterUpdateWorldTransformDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSpineWidgetAfterUpdateWorldTransformDelegate.OnScriptCallback));
				}
				FSpineWidgetAfterUpdateWorldTransformDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSpineWidgetAfterUpdateWorldTransformDelegate.RegisterId);
		}

		// Token: 0x06026B11 RID: 158481 RVA: 0x003B093A File Offset: 0x003AEB3A
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<USpineWidget> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06026B12 RID: 158482 RVA: 0x003B0944 File Offset: 0x003AEB44
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(USpineWidget skeleton)
		{
			FSpineWidgetAfterUpdateWorldTransformDelegate.__FSpineWidgetAfterUpdateWorldTransformDelegate_DelegateParams* ptr = stackalloc FSpineWidgetAfterUpdateWorldTransformDelegate.__FSpineWidgetAfterUpdateWorldTransformDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FSpineWidgetAfterUpdateWorldTransformDelegate.__FSpineWidgetAfterUpdateWorldTransformDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSpineWidgetAfterUpdateWorldTransformDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->skeleton = ((skeleton != null) ? skeleton.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06026B13 RID: 158483 RVA: 0x003B0990 File Offset: 0x003AEB90
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
			USpineWidget orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USpineWidget>(((FSpineWidgetAfterUpdateWorldTransformDelegate.__FSpineWidgetAfterUpdateWorldTransformDelegate_DelegateParams*)__Parameters)->skeleton);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x040153D3 RID: 86995
		internal static IntPtr _FunctionPtr;

		// Token: 0x040153D4 RID: 86996
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SpinePlugin.SpineWidgetAfterUpdateWorldTransformDelegate__DelegateSignature";

		// Token: 0x040153D5 RID: 86997
		private static int RegisterId;

		// Token: 0x02003B48 RID: 15176
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FSpineWidgetAfterUpdateWorldTransformDelegate_DelegateParams
		{
			// Token: 0x04017CED RID: 97517
			[FieldOffset(0)]
			public IntPtr skeleton;
		}

		// Token: 0x02003B49 RID: 15177
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017CEE RID: 97518
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
