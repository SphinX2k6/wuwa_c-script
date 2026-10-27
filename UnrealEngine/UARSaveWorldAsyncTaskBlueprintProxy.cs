using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003C0 RID: 960
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AugmentedReality.ARSaveWorldAsyncTaskBlueprintProxy")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UARSaveWorldAsyncTaskBlueprintProxy : UARBaseAsyncTaskBlueprintProxy, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600353D RID: 13629 RVA: 0x0005137C File Offset: 0x0004F57C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UARSaveWorldAsyncTaskBlueprintProxy._ClassPtr;
		}

		// Token: 0x0600353E RID: 13630 RVA: 0x00051388 File Offset: 0x0004F588
		public UARSaveWorldAsyncTaskBlueprintProxy() : this(BuiltinUtils.AllocNativeUObject(UARSaveWorldAsyncTaskBlueprintProxy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600353F RID: 13631 RVA: 0x000513B0 File Offset: 0x0004F5B0
		public UARSaveWorldAsyncTaskBlueprintProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UARSaveWorldAsyncTaskBlueprintProxy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000CAC RID: 3244
		// (get) Token: 0x06003540 RID: 13632 RVA: 0x000513E4 File Offset: 0x0004F5E4
		// (set) Token: 0x06003541 RID: 13633 RVA: 0x0005141D File Offset: 0x0004F61D
		public FARSaveWorldPin OnSuccess
		{
			get
			{
				base.FastCheckIsValid();
				FARSaveWorldPin result;
				if ((result = this._OnSuccess) == null)
				{
					result = (this._OnSuccess = new FARSaveWorldPin(base.NativePtr + (IntPtr)UARSaveWorldAsyncTaskBlueprintProxy.__PropertyOffset_OnSuccess, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UARSaveWorldAsyncTaskBlueprintProxy.__PropertyOffset_OnSuccess, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x06003542 RID: 13634 RVA: 0x00051440 File Offset: 0x0004F640
		// (set) Token: 0x06003543 RID: 13635 RVA: 0x00051479 File Offset: 0x0004F679
		public FARSaveWorldPin OnFailed
		{
			get
			{
				base.FastCheckIsValid();
				FARSaveWorldPin result;
				if ((result = this._OnFailed) == null)
				{
					result = (this._OnFailed = new FARSaveWorldPin(base.NativePtr + (IntPtr)UARSaveWorldAsyncTaskBlueprintProxy.__PropertyOffset_OnFailed, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UARSaveWorldAsyncTaskBlueprintProxy.__PropertyOffset_OnFailed, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06003544 RID: 13636 RVA: 0x0005149C File Offset: 0x0004F69C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UARSaveWorldAsyncTaskBlueprintProxy ARSaveWorld(UObject WorldContextObject)
		{
			UARSaveWorldAsyncTaskBlueprintProxy.__ARSaveWorld_FunctionParams* ptr = stackalloc UARSaveWorldAsyncTaskBlueprintProxy.__ARSaveWorld_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UARSaveWorldAsyncTaskBlueprintProxy.__ARSaveWorld_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UARSaveWorldAsyncTaskBlueprintProxy.__ARSaveWorld_NativeFunctionPtr, (void*)ptr, 1);
			ptr->WorldContextObject = ((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UARSaveWorldAsyncTaskBlueprintProxy._ClassDefaultObjectPtr, UARSaveWorldAsyncTaskBlueprintProxy.__ARSaveWorld_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UARSaveWorldAsyncTaskBlueprintProxy>(ptr->__Result);
		}

		// Token: 0x06003545 RID: 13637 RVA: 0x000514FC File Offset: 0x0004F6FC
		static UARSaveWorldAsyncTaskBlueprintProxy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARSaveWorldAsyncTaskBlueprintProxy");
		}

		// Token: 0x06003546 RID: 13638 RVA: 0x0005150A File Offset: 0x0004F70A
		protected UARSaveWorldAsyncTaskBlueprintProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001715 RID: 5909
		public new const string __ObjectPath = "/Script/AugmentedReality.ARSaveWorldAsyncTaskBlueprintProxy";

		// Token: 0x04001716 RID: 5910
		private static IntPtr _ClassPtr;

		// Token: 0x04001717 RID: 5911
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001718 RID: 5912
		internal static int __PropertyOffset_OnSuccess;

		// Token: 0x04001719 RID: 5913
		[Nullable(2)]
		private FARSaveWorldPin _OnSuccess;

		// Token: 0x0400171A RID: 5914
		internal static int __PropertyOffset_OnFailed;

		// Token: 0x0400171B RID: 5915
		[Nullable(2)]
		private FARSaveWorldPin _OnFailed;

		// Token: 0x0400171C RID: 5916
		private static IntPtr __ARSaveWorld_NativeFunctionPtr;

		// Token: 0x02002C1A RID: 11290
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ARSaveWorld_FunctionParams
		{
			// Token: 0x0401651E RID: 91422
			[FieldOffset(0)]
			public IntPtr WorldContextObject;

			// Token: 0x0401651F RID: 91423
			[FieldOffset(8)]
			public IntPtr __Result;
		}
	}
}
