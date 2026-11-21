using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000136 RID: 310
	[UnrealObjectPath("/Script/CoreUObject.Object")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UObject : UnrealUObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001261 RID: 4705 RVA: 0x0001D161 File Offset: 0x0001B361
		public static UClassStackOnlyPtr StaticClass()
		{
			return UObject._ClassPtr;
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x0001D170 File Offset: 0x0001B370
		[SkipLocalsInit]
		public unsafe virtual void ExecuteUbergraph(int EntryPoint)
		{
			UObject.__ExecuteUbergraph_FunctionParams* ptr = stackalloc UObject.__ExecuteUbergraph_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UObject.__ExecuteUbergraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UObject.__ExecuteUbergraph_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntryPoint = EntryPoint;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, UObject.__ExecuteUbergraph_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x0001D1B6 File Offset: 0x0001B3B6
		static UObject()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.Object");
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x0001D1C4 File Offset: 0x0001B3C4
		protected UObject() : this(BuiltinUtils.AllocNativeUObject(UObject.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x0001D1EC File Offset: 0x0001B3EC
		protected UObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400059D RID: 1437
		[Nullable(1)]
		public const string __ObjectPath = "/Script/CoreUObject.Object";

		// Token: 0x0400059E RID: 1438
		private static IntPtr _ClassPtr;

		// Token: 0x0400059F RID: 1439
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040005A0 RID: 1440
		private static IntPtr __ExecuteUbergraph_NativeFunctionPtr;

		// Token: 0x0200092F RID: 2351
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ExecuteUbergraph_FunctionParams
		{
			// Token: 0x0400583C RID: 22588
			[FieldOffset(0)]
			public int EntryPoint;
		}
	}
}
