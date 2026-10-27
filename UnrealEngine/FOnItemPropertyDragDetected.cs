using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000292 RID: 658
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnItemPropertyDragDetected : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060024D3 RID: 9427 RVA: 0x00036CE2 File Offset: 0x00034EE2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnItemPropertyDragDetected.StaticFunctionPtr();
		}

		// Token: 0x060024D4 RID: 9428 RVA: 0x00036CEE File Offset: 0x00034EEE
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnItemPropertyDragDetected._FunctionPtr == IntPtr.Zero)
			{
				FOnItemPropertyDragDetected._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AkAudio.OnItemPropertyDragDetected__DelegateSignature");
			}
			return FOnItemPropertyDragDetected._FunctionPtr;
		}

		// Token: 0x060024D5 RID: 9429 RVA: 0x00036D11 File Offset: 0x00034F11
		public FOnItemPropertyDragDetected()
		{
		}

		// Token: 0x060024D6 RID: 9430 RVA: 0x00036D19 File Offset: 0x00034F19
		[NullableContext(2)]
		public FOnItemPropertyDragDetected(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060024D7 RID: 9431 RVA: 0x00036D23 File Offset: 0x00034F23
		public FOnItemPropertyDragDetected(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060024D8 RID: 9432 RVA: 0x00036D2E File Offset: 0x00034F2E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060024D9 RID: 9433 RVA: 0x00036D60 File Offset: 0x00034F60
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<string> Callback)
		{
			if (FOnItemPropertyDragDetected.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnItemPropertyDragDetected.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnItemPropertyDragDetected.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnItemPropertyDragDetected.OnScriptCallback));
				}
				FOnItemPropertyDragDetected.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnItemPropertyDragDetected.RegisterId);
		}

		// Token: 0x060024DA RID: 9434 RVA: 0x00036D9A File Offset: 0x00034F9A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060024DB RID: 9435 RVA: 0x00036DA4 File Offset: 0x00034FA4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(string PropertyDragged)
		{
			FOnItemPropertyDragDetected.__FOnItemPropertyDragDetected_DelegateParams* ptr = stackalloc FOnItemPropertyDragDetected.__FOnItemPropertyDragDetected_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnItemPropertyDragDetected.__FOnItemPropertyDragDetected_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnItemPropertyDragDetected.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->PropertyDragged), PropertyDragged);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FOnItemPropertyDragDetected._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060024DC RID: 9436 RVA: 0x00036DF8 File Offset: 0x00034FF8
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
			string obj = FString.ToString((void*)(&((FOnItemPropertyDragDetected.__FOnItemPropertyDragDetected_DelegateParams*)__Parameters)->PropertyDragged));
			action(obj);
		}

		// Token: 0x04000E00 RID: 3584
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000E01 RID: 3585
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AkAudio.OnItemPropertyDragDetected__DelegateSignature";

		// Token: 0x04000E02 RID: 3586
		private static int RegisterId;

		// Token: 0x02002B99 RID: 11161
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnItemPropertyDragDetected_DelegateParams
		{
			// Token: 0x0401642F RID: 91183
			[FieldOffset(0)]
			public FString PropertyDragged;
		}

		// Token: 0x02002B9A RID: 11162
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016430 RID: 91184
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
