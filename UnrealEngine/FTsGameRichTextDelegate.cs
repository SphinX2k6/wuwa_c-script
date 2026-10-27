using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002118 RID: 8472
	public sealed class FTsGameRichTextDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601FE0F RID: 130575 RVA: 0x002F6D6E File Offset: 0x002F4F6E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FTsGameRichTextDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601FE10 RID: 130576 RVA: 0x002F6D7A File Offset: 0x002F4F7A
		private static IntPtr StaticFunctionPtr()
		{
			if (FTsGameRichTextDelegate._FunctionPtr == IntPtr.Zero)
			{
				FTsGameRichTextDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.TsGameRichTextDelegate__DelegateSignature");
			}
			return FTsGameRichTextDelegate._FunctionPtr;
		}

		// Token: 0x0601FE11 RID: 130577 RVA: 0x002F6D9D File Offset: 0x002F4F9D
		public FTsGameRichTextDelegate()
		{
		}

		// Token: 0x0601FE12 RID: 130578 RVA: 0x002F6DA5 File Offset: 0x002F4FA5
		[NullableContext(2)]
		public FTsGameRichTextDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FE13 RID: 130579 RVA: 0x002F6DAF File Offset: 0x002F4FAF
		public FTsGameRichTextDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FE14 RID: 130580 RVA: 0x002F6DBA File Offset: 0x002F4FBA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<string, TArray<string>, string>) ?? ((Func<string, TArray<string>, string>)Delegate.CreateDelegate(typeof(Func<string, TArray<string>, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601FE15 RID: 130581 RVA: 0x002F6DEC File Offset: 0x002F4FEC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Func<string, TArray<string>, string> Callback)
		{
			if (FTsGameRichTextDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FTsGameRichTextDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FTsGameRichTextDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FTsGameRichTextDelegate.OnScriptCallback));
				}
				FTsGameRichTextDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FTsGameRichTextDelegate.RegisterId);
		}

		// Token: 0x0601FE16 RID: 130582 RVA: 0x002F6E28 File Offset: 0x002F5028
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe string Execute(string RichTextType, [Nullable(new byte[]
		{
			2,
			1
		})] TArray<string> Params)
		{
			FTsGameRichTextDelegate.__FTsGameRichTextDelegate_DelegateParams* ptr = stackalloc FTsGameRichTextDelegate.__FTsGameRichTextDelegate_DelegateParams[(UIntPtr)63] + 15L / (long)sizeof(FTsGameRichTextDelegate.__FTsGameRichTextDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FTsGameRichTextDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->RichTextType), RichTextType);
			if (Params != null)
			{
				Params.CopyTo(&ptr->Params, default(UScriptStructStackOnlyPtr));
			}
			base.ExecuteInternal((void*)ptr);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(FTsGameRichTextDelegate._FunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601FE17 RID: 130583 RVA: 0x002F6EA4 File Offset: 0x002F50A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<string, TArray<string>, string> func = target as Func<string, TArray<string>, string>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FTsGameRichTextDelegate.__FTsGameRichTextDelegate_DelegateParams*)__Parameters)->RichTextType));
			TArray<string> arg2 = new TArray<string>(&((FTsGameRichTextDelegate.__FTsGameRichTextDelegate_DelegateParams*)__Parameters)->Params, true, true);
			string src = func(arg, arg2);
			FString.CopyFrom((void*)(&((FTsGameRichTextDelegate.__FTsGameRichTextDelegate_DelegateParams*)__Parameters)->__Result), src);
		}

		// Token: 0x040112D5 RID: 70357
		internal static IntPtr _FunctionPtr;

		// Token: 0x040112D6 RID: 70358
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.TsGameRichTextDelegate__DelegateSignature";

		// Token: 0x040112D7 RID: 70359
		private static int RegisterId;

		// Token: 0x020034EB RID: 13547
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __FTsGameRichTextDelegate_DelegateParams
		{
			// Token: 0x04017509 RID: 95497
			[FieldOffset(0)]
			public FString RichTextType;

			// Token: 0x0401750A RID: 95498
			[FieldOffset(16)]
			public byte Params;

			// Token: 0x0401750B RID: 95499
			[FieldOffset(32)]
			public FString __Result;
		}

		// Token: 0x020034EC RID: 13548
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401750C RID: 95500
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
