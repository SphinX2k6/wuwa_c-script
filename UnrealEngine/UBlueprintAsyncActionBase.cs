using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008B9 RID: 2233
	[UnrealObjectPath("/Script/Engine.BlueprintAsyncActionBase")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UBlueprintAsyncActionBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007A0C RID: 31244 RVA: 0x000AE9A7 File Offset: 0x000ACBA7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBlueprintAsyncActionBase._ClassPtr;
		}

		// Token: 0x06007A0D RID: 31245 RVA: 0x000AE9B4 File Offset: 0x000ACBB4
		public UBlueprintAsyncActionBase() : this(BuiltinUtils.AllocNativeUObject(UBlueprintAsyncActionBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007A0E RID: 31246 RVA: 0x000AE9DC File Offset: 0x000ACBDC
		[NullableContext(1)]
		public UBlueprintAsyncActionBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBlueprintAsyncActionBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06007A0F RID: 31247 RVA: 0x000AEA0F File Offset: 0x000ACC0F
		public void Activate()
		{
			UBlueprintAsyncActionBase.__Activate_Internal(base.NativePtr);
		}

		// Token: 0x06007A10 RID: 31248
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Activate_Internal(IntPtr @this);

		// Token: 0x06007A11 RID: 31249 RVA: 0x000AEA1C File Offset: 0x000ACC1C
		static UBlueprintAsyncActionBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BlueprintAsyncActionBase");
		}

		// Token: 0x06007A12 RID: 31250 RVA: 0x000AEA2A File Offset: 0x000ACC2A
		protected UBlueprintAsyncActionBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003AB1 RID: 15025
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.BlueprintAsyncActionBase";

		// Token: 0x04003AB2 RID: 15026
		private static IntPtr _ClassPtr;

		// Token: 0x04003AB3 RID: 15027
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
