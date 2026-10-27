using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200085E RID: 2142
	[UnrealObjectPath("/Script/Engine.AsyncActionLoadPrimaryAssetBase")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public abstract class UAsyncActionLoadPrimaryAssetBase : UBlueprintAsyncActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007389 RID: 29577 RVA: 0x000A5B4A File Offset: 0x000A3D4A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAsyncActionLoadPrimaryAssetBase._ClassPtr;
		}

		// Token: 0x0600738A RID: 29578 RVA: 0x000A5B56 File Offset: 0x000A3D56
		static UAsyncActionLoadPrimaryAssetBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AsyncActionLoadPrimaryAssetBase");
		}

		// Token: 0x0600738B RID: 29579 RVA: 0x000A5B64 File Offset: 0x000A3D64
		protected UAsyncActionLoadPrimaryAssetBase() : this(BuiltinUtils.AllocNativeUObject(UAsyncActionLoadPrimaryAssetBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600738C RID: 29580 RVA: 0x000A5B8C File Offset: 0x000A3D8C
		protected UAsyncActionLoadPrimaryAssetBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003797 RID: 14231
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AsyncActionLoadPrimaryAssetBase";

		// Token: 0x04003798 RID: 14232
		private static IntPtr _ClassPtr;

		// Token: 0x04003799 RID: 14233
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
