using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001C9 RID: 457
	[UnrealObjectPath("/Script/AIModule.GridPathAIController")]
	[UnrealStructLayout(1312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1312)]
	public class AGridPathAIController : AAIController, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001B17 RID: 6935 RVA: 0x00028669 File Offset: 0x00026869
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AGridPathAIController._ClassPtr;
		}

		// Token: 0x06001B18 RID: 6936 RVA: 0x00028678 File Offset: 0x00026878
		public AGridPathAIController() : this(BuiltinUtils.AllocNativeUObject(AGridPathAIController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001B19 RID: 6937 RVA: 0x000286A0 File Offset: 0x000268A0
		[NullableContext(1)]
		public AGridPathAIController(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AGridPathAIController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001B1A RID: 6938 RVA: 0x000286D3 File Offset: 0x000268D3
		static AGridPathAIController()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.GridPathAIController");
		}

		// Token: 0x06001B1B RID: 6939 RVA: 0x000286E1 File Offset: 0x000268E1
		protected AGridPathAIController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040008A9 RID: 2217
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.GridPathAIController";

		// Token: 0x040008AA RID: 2218
		private static IntPtr _ClassPtr;

		// Token: 0x040008AB RID: 2219
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
