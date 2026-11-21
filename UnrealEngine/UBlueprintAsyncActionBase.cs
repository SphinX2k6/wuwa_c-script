using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200018E RID: 398
	[UnrealObjectPath("/Script/Engine.BlueprintAsyncActionBase")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UBlueprintAsyncActionBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060019F4 RID: 6644 RVA: 0x00026F82 File Offset: 0x00025182
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBlueprintAsyncActionBase._ClassPtr;
		}

		// Token: 0x060019F5 RID: 6645 RVA: 0x00026F90 File Offset: 0x00025190
		public UBlueprintAsyncActionBase() : this(BuiltinUtils.AllocNativeUObject(UBlueprintAsyncActionBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060019F6 RID: 6646 RVA: 0x00026FB8 File Offset: 0x000251B8
		[NullableContext(1)]
		public UBlueprintAsyncActionBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBlueprintAsyncActionBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060019F7 RID: 6647 RVA: 0x00026FEB File Offset: 0x000251EB
		public void Activate()
		{
			UBlueprintAsyncActionBase.__Activate_Internal(base.NativePtr);
		}

		// Token: 0x060019F8 RID: 6648
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Activate_Internal(IntPtr @this);

		// Token: 0x060019F9 RID: 6649 RVA: 0x00026FF8 File Offset: 0x000251F8
		static UBlueprintAsyncActionBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BlueprintAsyncActionBase");
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x00027006 File Offset: 0x00025206
		protected UBlueprintAsyncActionBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000856 RID: 2134
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.BlueprintAsyncActionBase";

		// Token: 0x04000857 RID: 2135
		private static IntPtr _ClassPtr;

		// Token: 0x04000858 RID: 2136
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
