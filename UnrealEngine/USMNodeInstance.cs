using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000833 RID: 2099
	[UnrealObjectPath("/Script/SMSystem.SMNodeInstance")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public abstract class USMNodeInstance : UObject, IUnrealUObject, IUnrealObject, ISMInstanceInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0600B701 RID: 46849 RVA: 0x00124660 File Offset: 0x00122860
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USMNodeInstance._ClassPtr;
		}

		// Token: 0x0600B702 RID: 46850 RVA: 0x0012466C File Offset: 0x0012286C
		int ISMInstanceInterface.InterfaceOffset()
		{
			return USMNodeInstance.__InterfaceOffset_ISMInstanceInterface;
		}

		// Token: 0x17002230 RID: 8752
		// (get) Token: 0x0600B703 RID: 46851 RVA: 0x00124673 File Offset: 0x00122873
		// (set) Token: 0x0600B704 RID: 46852 RVA: 0x00124687 File Offset: 0x00122887
		public unsafe FGuid TemplateGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USMNodeInstance.__PropertyOffset_TemplateGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USMNodeInstance.__PropertyOffset_TemplateGuid) = value;
			}
		}

		// Token: 0x0600B705 RID: 46853 RVA: 0x0012469C File Offset: 0x0012289C
		[SkipLocalsInit]
		public unsafe bool IsInEndState()
		{
			USMNodeInstance.__IsInEndState_FunctionParams* ptr = stackalloc USMNodeInstance.__IsInEndState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMNodeInstance.__IsInEndState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMNodeInstance.__IsInEndState_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMNodeInstance.__IsInEndState_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B706 RID: 46854 RVA: 0x001246E4 File Offset: 0x001228E4
		[SkipLocalsInit]
		public unsafe bool IsActive()
		{
			USMNodeInstance.__IsActive_FunctionParams* ptr = stackalloc USMNodeInstance.__IsActive_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMNodeInstance.__IsActive_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMNodeInstance.__IsActive_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMNodeInstance.__IsActive_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B707 RID: 46855 RVA: 0x0012472C File Offset: 0x0012292C
		[SkipLocalsInit]
		public unsafe bool HasUpdated()
		{
			USMNodeInstance.__HasUpdated_FunctionParams* ptr = stackalloc USMNodeInstance.__HasUpdated_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(USMNodeInstance.__HasUpdated_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMNodeInstance.__HasUpdated_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMNodeInstance.__HasUpdated_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B708 RID: 46856 RVA: 0x00124774 File Offset: 0x00122974
		[SkipLocalsInit]
		public unsafe float GetTimeInState()
		{
			USMNodeInstance.__GetTimeInState_FunctionParams* ptr = stackalloc USMNodeInstance.__GetTimeInState_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USMNodeInstance.__GetTimeInState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMNodeInstance.__GetTimeInState_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMNodeInstance.__GetTimeInState_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B709 RID: 46857 RVA: 0x001247BC File Offset: 0x001229BC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe USMInstance GetStateMachineInstance(bool bTopMostInstance = false)
		{
			USMNodeInstance.__GetStateMachineInstance_FunctionParams* ptr = stackalloc USMNodeInstance.__GetStateMachineInstance_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMNodeInstance.__GetStateMachineInstance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMNodeInstance.__GetStateMachineInstance_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bTopMostInstance = bTopMostInstance;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMNodeInstance.__GetStateMachineInstance_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMInstance>(ptr->__Result);
		}

		// Token: 0x0600B70A RID: 46858 RVA: 0x00124810 File Offset: 0x00122A10
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe USMStateMachineInstance GetOwningStateMachineNodeInstance()
		{
			USMNodeInstance.__GetOwningStateMachineNodeInstance_FunctionParams* ptr = stackalloc USMNodeInstance.__GetOwningStateMachineNodeInstance_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMNodeInstance.__GetOwningStateMachineNodeInstance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMNodeInstance.__GetOwningStateMachineNodeInstance_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMNodeInstance.__GetOwningStateMachineNodeInstance_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMStateMachineInstance>(ptr->__Result);
		}

		// Token: 0x0600B70B RID: 46859 RVA: 0x0012485C File Offset: 0x00122A5C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe string GetNodeName()
		{
			USMNodeInstance.__GetNodeName_FunctionParams* ptr = stackalloc USMNodeInstance.__GetNodeName_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMNodeInstance.__GetNodeName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMNodeInstance.__GetNodeName_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMNodeInstance.__GetNodeName_NativeFunctionPtr, (void*)ptr);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(USMNodeInstance.__GetNodeName_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B70C RID: 46860 RVA: 0x001248B8 File Offset: 0x00122AB8
		[SkipLocalsInit]
		public unsafe FGuid GetGuid()
		{
			USMNodeInstance.__GetGuid_FunctionParams* ptr = stackalloc USMNodeInstance.__GetGuid_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USMNodeInstance.__GetGuid_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMNodeInstance.__GetGuid_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMNodeInstance.__GetGuid_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B70D RID: 46861 RVA: 0x00124900 File Offset: 0x00122B00
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe UObject GetContext()
		{
			USMNodeInstance.__GetContext_FunctionParams* ptr = stackalloc USMNodeInstance.__GetContext_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(USMNodeInstance.__GetContext_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMNodeInstance.__GetContext_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USMNodeInstance.__GetContext_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(ptr->__Result);
		}

		// Token: 0x0600B70E RID: 46862 RVA: 0x0012494A File Offset: 0x00122B4A
		static USMNodeInstance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SMSystem.SMNodeInstance");
		}

		// Token: 0x0600B70F RID: 46863 RVA: 0x00124958 File Offset: 0x00122B58
		protected USMNodeInstance() : this(BuiltinUtils.AllocNativeUObject(USMNodeInstance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B710 RID: 46864 RVA: 0x00124980 File Offset: 0x00122B80
		protected USMNodeInstance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040052FB RID: 21243
		internal static int __InterfaceOffset_ISMInstanceInterface;

		// Token: 0x040052FC RID: 21244
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SMSystem.SMNodeInstance";

		// Token: 0x040052FD RID: 21245
		private static IntPtr _ClassPtr;

		// Token: 0x040052FE RID: 21246
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040052FF RID: 21247
		internal static int __PropertyOffset_TemplateGuid;

		// Token: 0x04005300 RID: 21248
		private static IntPtr __IsInEndState_NativeFunctionPtr;

		// Token: 0x04005301 RID: 21249
		private static IntPtr __IsActive_NativeFunctionPtr;

		// Token: 0x04005302 RID: 21250
		private static IntPtr __HasUpdated_NativeFunctionPtr;

		// Token: 0x04005303 RID: 21251
		private static IntPtr __GetTimeInState_NativeFunctionPtr;

		// Token: 0x04005304 RID: 21252
		private static IntPtr __GetStateMachineInstance_NativeFunctionPtr;

		// Token: 0x04005305 RID: 21253
		private static IntPtr __GetOwningStateMachineNodeInstance_NativeFunctionPtr;

		// Token: 0x04005306 RID: 21254
		private static IntPtr __GetNodeName_NativeFunctionPtr;

		// Token: 0x04005307 RID: 21255
		private static IntPtr __GetGuid_NativeFunctionPtr;

		// Token: 0x04005308 RID: 21256
		private static IntPtr __GetContext_NativeFunctionPtr;

		// Token: 0x0200138C RID: 5004
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsInEndState_FunctionParams
		{
			// Token: 0x040067E1 RID: 26593
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200138D RID: 5005
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsActive_FunctionParams
		{
			// Token: 0x040067E2 RID: 26594
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200138E RID: 5006
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __HasUpdated_FunctionParams
		{
			// Token: 0x040067E3 RID: 26595
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200138F RID: 5007
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetTimeInState_FunctionParams
		{
			// Token: 0x040067E4 RID: 26596
			[FieldOffset(0)]
			public float __Result;
		}

		// Token: 0x02001390 RID: 5008
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetStateMachineInstance_FunctionParams
		{
			// Token: 0x040067E5 RID: 26597
			[FieldOffset(0)]
			public bool bTopMostInstance;

			// Token: 0x040067E6 RID: 26598
			[FieldOffset(8)]
			public IntPtr __Result;
		}

		// Token: 0x02001391 RID: 5009
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetOwningStateMachineNodeInstance_FunctionParams
		{
			// Token: 0x040067E7 RID: 26599
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x02001392 RID: 5010
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetNodeName_FunctionParams
		{
			// Token: 0x040067E8 RID: 26600
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02001393 RID: 5011
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetGuid_FunctionParams
		{
			// Token: 0x040067E9 RID: 26601
			[FieldOffset(0)]
			public FGuid __Result;
		}

		// Token: 0x02001394 RID: 5012
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetContext_FunctionParams
		{
			// Token: 0x040067EA RID: 26602
			[FieldOffset(0)]
			public IntPtr __Result;
		}
	}
}
