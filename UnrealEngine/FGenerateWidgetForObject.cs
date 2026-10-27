using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002969 RID: 10601
	public sealed class FGenerateWidgetForObject : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06027381 RID: 160641 RVA: 0x003BCA6F File Offset: 0x003BAC6F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FGenerateWidgetForObject.StaticFunctionPtr();
		}

		// Token: 0x06027382 RID: 160642 RVA: 0x003BCA7B File Offset: 0x003BAC7B
		private static IntPtr StaticFunctionPtr()
		{
			if (UWidget.__GenerateWidgetForObject__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UWidget.__GenerateWidgetForObject__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.Widget:GenerateWidgetForObject__DelegateSignature");
			}
			return UWidget.__GenerateWidgetForObject__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06027383 RID: 160643 RVA: 0x003BCA9E File Offset: 0x003BAC9E
		public FGenerateWidgetForObject()
		{
		}

		// Token: 0x06027384 RID: 160644 RVA: 0x003BCAA6 File Offset: 0x003BACA6
		[NullableContext(2)]
		public FGenerateWidgetForObject(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027385 RID: 160645 RVA: 0x003BCAB0 File Offset: 0x003BACB0
		public FGenerateWidgetForObject(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027386 RID: 160646 RVA: 0x003BCABB File Offset: 0x003BACBB
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<UObject, UWidget>) ?? ((Func<UObject, UWidget>)Delegate.CreateDelegate(typeof(Func<UObject, UWidget>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06027387 RID: 160647 RVA: 0x003BCAED File Offset: 0x003BACED
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Func<UObject, UWidget> Callback)
		{
			if (FGenerateWidgetForObject.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FGenerateWidgetForObject.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FGenerateWidgetForObject.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FGenerateWidgetForObject.OnScriptCallback));
				}
				FGenerateWidgetForObject.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FGenerateWidgetForObject.RegisterId);
		}

		// Token: 0x06027388 RID: 160648 RVA: 0x003BCB28 File Offset: 0x003BAD28
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe UWidget Execute(UObject Item)
		{
			FGenerateWidgetForObject.__FGenerateWidgetForObject_DelegateParams* ptr = stackalloc FGenerateWidgetForObject.__FGenerateWidgetForObject_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FGenerateWidgetForObject.__FGenerateWidgetForObject_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FGenerateWidgetForObject.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Item = ((Item != null) ? Item.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UWidget>(ptr->__Result);
		}

		// Token: 0x06027389 RID: 160649 RVA: 0x003BCB80 File Offset: 0x003BAD80
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<UObject, UWidget> func = target as Func<UObject, UWidget>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(((FGenerateWidgetForObject.__FGenerateWidgetForObject_DelegateParams*)__Parameters)->Item);
			UWidget uwidget = func(orCreateUObjectByNativePointer);
			((FGenerateWidgetForObject.__FGenerateWidgetForObject_DelegateParams*)__Parameters)->__Result = ((uwidget != null) ? uwidget.NativePtr : IntPtr.Zero);
		}

		// Token: 0x040158ED RID: 88301
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.Widget:GenerateWidgetForObject__DelegateSignature";

		// Token: 0x040158EE RID: 88302
		private static int RegisterId;

		// Token: 0x02003B6D RID: 15213
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FGenerateWidgetForObject_DelegateParams
		{
			// Token: 0x04017D45 RID: 97605
			[FieldOffset(0)]
			public IntPtr Item;

			// Token: 0x04017D46 RID: 97606
			[FieldOffset(8)]
			public IntPtr __Result;
		}

		// Token: 0x02003B6E RID: 15214
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D47 RID: 97607
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
