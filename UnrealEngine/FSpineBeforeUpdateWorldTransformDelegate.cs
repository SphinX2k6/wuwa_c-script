using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028AC RID: 10412
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSpineBeforeUpdateWorldTransformDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060269A7 RID: 158119 RVA: 0x003AE908 File Offset: 0x003ACB08
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSpineBeforeUpdateWorldTransformDelegate.StaticFunctionPtr();
		}

		// Token: 0x060269A8 RID: 158120 RVA: 0x003AE914 File Offset: 0x003ACB14
		private static IntPtr StaticFunctionPtr()
		{
			if (FSpineBeforeUpdateWorldTransformDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSpineBeforeUpdateWorldTransformDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SpinePlugin.SpineBeforeUpdateWorldTransformDelegate__DelegateSignature");
			}
			return FSpineBeforeUpdateWorldTransformDelegate._FunctionPtr;
		}

		// Token: 0x060269A9 RID: 158121 RVA: 0x003AE937 File Offset: 0x003ACB37
		public FSpineBeforeUpdateWorldTransformDelegate()
		{
		}

		// Token: 0x060269AA RID: 158122 RVA: 0x003AE93F File Offset: 0x003ACB3F
		[NullableContext(2)]
		public FSpineBeforeUpdateWorldTransformDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060269AB RID: 158123 RVA: 0x003AE949 File Offset: 0x003ACB49
		public FSpineBeforeUpdateWorldTransformDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060269AC RID: 158124 RVA: 0x003AE954 File Offset: 0x003ACB54
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<USpineSkeletonComponent>) ?? ((Action<USpineSkeletonComponent>)Delegate.CreateDelegate(typeof(Action<USpineSkeletonComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060269AD RID: 158125 RVA: 0x003AE986 File Offset: 0x003ACB86
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<USpineSkeletonComponent> Callback)
		{
			if (FSpineBeforeUpdateWorldTransformDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSpineBeforeUpdateWorldTransformDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSpineBeforeUpdateWorldTransformDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSpineBeforeUpdateWorldTransformDelegate.OnScriptCallback));
				}
				FSpineBeforeUpdateWorldTransformDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSpineBeforeUpdateWorldTransformDelegate.RegisterId);
		}

		// Token: 0x060269AE RID: 158126 RVA: 0x003AE9C0 File Offset: 0x003ACBC0
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<USpineSkeletonComponent> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060269AF RID: 158127 RVA: 0x003AE9CC File Offset: 0x003ACBCC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(USpineSkeletonComponent skeleton)
		{
			FSpineBeforeUpdateWorldTransformDelegate.__FSpineBeforeUpdateWorldTransformDelegate_DelegateParams* ptr = stackalloc FSpineBeforeUpdateWorldTransformDelegate.__FSpineBeforeUpdateWorldTransformDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FSpineBeforeUpdateWorldTransformDelegate.__FSpineBeforeUpdateWorldTransformDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSpineBeforeUpdateWorldTransformDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->skeleton = ((skeleton != null) ? skeleton.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060269B0 RID: 158128 RVA: 0x003AEA18 File Offset: 0x003ACC18
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
			USpineSkeletonComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USpineSkeletonComponent>(((FSpineBeforeUpdateWorldTransformDelegate.__FSpineBeforeUpdateWorldTransformDelegate_DelegateParams*)__Parameters)->skeleton);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0401533F RID: 86847
		internal static IntPtr _FunctionPtr;

		// Token: 0x04015340 RID: 86848
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SpinePlugin.SpineBeforeUpdateWorldTransformDelegate__DelegateSignature";

		// Token: 0x04015341 RID: 86849
		private static int RegisterId;

		// Token: 0x02003B46 RID: 15174
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FSpineBeforeUpdateWorldTransformDelegate_DelegateParams
		{
			// Token: 0x04017CEB RID: 97515
			[FieldOffset(0)]
			public IntPtr skeleton;
		}

		// Token: 0x02003B47 RID: 15175
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017CEC RID: 97516
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
