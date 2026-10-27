using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009A7 RID: 2471
	[UnrealObjectPath("/Script/Engine.DebugDrawService")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UDebugDrawService : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008B84 RID: 35716 RVA: 0x000C7E09 File Offset: 0x000C6009
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDebugDrawService._ClassPtr;
		}

		// Token: 0x06008B85 RID: 35717 RVA: 0x000C7E18 File Offset: 0x000C6018
		public UDebugDrawService() : this(BuiltinUtils.AllocNativeUObject(UDebugDrawService.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008B86 RID: 35718 RVA: 0x000C7E40 File Offset: 0x000C6040
		[NullableContext(1)]
		public UDebugDrawService(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDebugDrawService.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06008B87 RID: 35719 RVA: 0x000C7E73 File Offset: 0x000C6073
		static UDebugDrawService()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DebugDrawService");
		}

		// Token: 0x06008B88 RID: 35720 RVA: 0x000C7E81 File Offset: 0x000C6081
		protected UDebugDrawService(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004246 RID: 16966
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DebugDrawService";

		// Token: 0x04004247 RID: 16967
		private static IntPtr _ClassPtr;

		// Token: 0x04004248 RID: 16968
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
