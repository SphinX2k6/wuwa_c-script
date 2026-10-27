using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F17 RID: 3863
	[UnrealObjectPath("/Script/Engine.OnlineBlueprintCallProxyBase")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UOnlineBlueprintCallProxyBase : UBlueprintAsyncActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D0D6 RID: 53462 RVA: 0x001314C1 File Offset: 0x0012F6C1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UOnlineBlueprintCallProxyBase._ClassPtr;
		}

		// Token: 0x0600D0D7 RID: 53463 RVA: 0x001314D0 File Offset: 0x0012F6D0
		public UOnlineBlueprintCallProxyBase() : this(BuiltinUtils.AllocNativeUObject(UOnlineBlueprintCallProxyBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D0D8 RID: 53464 RVA: 0x001314F8 File Offset: 0x0012F6F8
		[NullableContext(1)]
		public UOnlineBlueprintCallProxyBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UOnlineBlueprintCallProxyBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600D0D9 RID: 53465 RVA: 0x0013152B File Offset: 0x0012F72B
		static UOnlineBlueprintCallProxyBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.OnlineBlueprintCallProxyBase");
		}

		// Token: 0x0600D0DA RID: 53466 RVA: 0x00131539 File Offset: 0x0012F739
		protected UOnlineBlueprintCallProxyBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007054 RID: 28756
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.OnlineBlueprintCallProxyBase";

		// Token: 0x04007055 RID: 28757
		private static IntPtr _ClassPtr;

		// Token: 0x04007056 RID: 28758
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
