using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003A8 RID: 936
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AugmentedReality.ARGetCandidateObjectAsyncTaskBlueprintProxy")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UARGetCandidateObjectAsyncTaskBlueprintProxy : UARBaseAsyncTaskBlueprintProxy, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060033F3 RID: 13299 RVA: 0x0004F5F1 File Offset: 0x0004D7F1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UARGetCandidateObjectAsyncTaskBlueprintProxy._ClassPtr;
		}

		// Token: 0x060033F4 RID: 13300 RVA: 0x0004F600 File Offset: 0x0004D800
		public UARGetCandidateObjectAsyncTaskBlueprintProxy() : this(BuiltinUtils.AllocNativeUObject(UARGetCandidateObjectAsyncTaskBlueprintProxy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060033F5 RID: 13301 RVA: 0x0004F628 File Offset: 0x0004D828
		public UARGetCandidateObjectAsyncTaskBlueprintProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UARGetCandidateObjectAsyncTaskBlueprintProxy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x060033F6 RID: 13302 RVA: 0x0004F65C File Offset: 0x0004D85C
		// (set) Token: 0x060033F7 RID: 13303 RVA: 0x0004F695 File Offset: 0x0004D895
		public FARGetCandidateObjectPin OnSuccess
		{
			get
			{
				base.FastCheckIsValid();
				FARGetCandidateObjectPin result;
				if ((result = this._OnSuccess) == null)
				{
					result = (this._OnSuccess = new FARGetCandidateObjectPin(base.NativePtr + (IntPtr)UARGetCandidateObjectAsyncTaskBlueprintProxy.__PropertyOffset_OnSuccess, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UARGetCandidateObjectAsyncTaskBlueprintProxy.__PropertyOffset_OnSuccess, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x060033F8 RID: 13304 RVA: 0x0004F6B8 File Offset: 0x0004D8B8
		// (set) Token: 0x060033F9 RID: 13305 RVA: 0x0004F6F1 File Offset: 0x0004D8F1
		public FARGetCandidateObjectPin OnFailed
		{
			get
			{
				base.FastCheckIsValid();
				FARGetCandidateObjectPin result;
				if ((result = this._OnFailed) == null)
				{
					result = (this._OnFailed = new FARGetCandidateObjectPin(base.NativePtr + (IntPtr)UARGetCandidateObjectAsyncTaskBlueprintProxy.__PropertyOffset_OnFailed, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UARGetCandidateObjectAsyncTaskBlueprintProxy.__PropertyOffset_OnFailed, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x060033FA RID: 13306 RVA: 0x0004F714 File Offset: 0x0004D914
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UARGetCandidateObjectAsyncTaskBlueprintProxy ARGetCandidateObject(UObject WorldContextObject, FVector Location, FVector Extent)
		{
			UARGetCandidateObjectAsyncTaskBlueprintProxy.__ARGetCandidateObject_FunctionParams* ptr = stackalloc UARGetCandidateObjectAsyncTaskBlueprintProxy.__ARGetCandidateObject_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UARGetCandidateObjectAsyncTaskBlueprintProxy.__ARGetCandidateObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UARGetCandidateObjectAsyncTaskBlueprintProxy.__ARGetCandidateObject_NativeFunctionPtr, (void*)ptr, 1);
			ptr->WorldContextObject = ((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
			ptr->Location = Location;
			ptr->Extent = Extent;
			UnrealReflectionUtils.CallUFunction(UARGetCandidateObjectAsyncTaskBlueprintProxy._ClassDefaultObjectPtr, UARGetCandidateObjectAsyncTaskBlueprintProxy.__ARGetCandidateObject_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UARGetCandidateObjectAsyncTaskBlueprintProxy>(ptr->__Result);
		}

		// Token: 0x060033FB RID: 13307 RVA: 0x0004F782 File Offset: 0x0004D982
		static UARGetCandidateObjectAsyncTaskBlueprintProxy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARGetCandidateObjectAsyncTaskBlueprintProxy");
		}

		// Token: 0x060033FC RID: 13308 RVA: 0x0004F790 File Offset: 0x0004D990
		protected UARGetCandidateObjectAsyncTaskBlueprintProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001688 RID: 5768
		public new const string __ObjectPath = "/Script/AugmentedReality.ARGetCandidateObjectAsyncTaskBlueprintProxy";

		// Token: 0x04001689 RID: 5769
		private static IntPtr _ClassPtr;

		// Token: 0x0400168A RID: 5770
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400168B RID: 5771
		internal static int __PropertyOffset_OnSuccess;

		// Token: 0x0400168C RID: 5772
		[Nullable(2)]
		private FARGetCandidateObjectPin _OnSuccess;

		// Token: 0x0400168D RID: 5773
		internal static int __PropertyOffset_OnFailed;

		// Token: 0x0400168E RID: 5774
		[Nullable(2)]
		private FARGetCandidateObjectPin _OnFailed;

		// Token: 0x0400168F RID: 5775
		private static IntPtr __ARGetCandidateObject_NativeFunctionPtr;

		// Token: 0x02002C09 RID: 11273
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __ARGetCandidateObject_FunctionParams
		{
			// Token: 0x0401650A RID: 91402
			[FieldOffset(0)]
			public IntPtr WorldContextObject;

			// Token: 0x0401650B RID: 91403
			[FieldOffset(8)]
			public FVector Location;

			// Token: 0x0401650C RID: 91404
			[FieldOffset(20)]
			public FVector Extent;

			// Token: 0x0401650D RID: 91405
			[FieldOffset(32)]
			public IntPtr __Result;
		}
	}
}
