using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200016B RID: 363
	[UnrealObjectPath("/Script/AIModule.DetourCrowdAIController")]
	[UnrealStructLayout(1312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1312)]
	public class ADetourCrowdAIController : AAIController, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600188E RID: 6286 RVA: 0x00024243 File Offset: 0x00022443
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ADetourCrowdAIController._ClassPtr;
		}

		// Token: 0x0600188F RID: 6287 RVA: 0x00024250 File Offset: 0x00022450
		public ADetourCrowdAIController() : this(BuiltinUtils.AllocNativeUObject(ADetourCrowdAIController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001890 RID: 6288 RVA: 0x00024278 File Offset: 0x00022478
		[NullableContext(1)]
		public ADetourCrowdAIController(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ADetourCrowdAIController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001891 RID: 6289 RVA: 0x000242AB File Offset: 0x000224AB
		static ADetourCrowdAIController()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.DetourCrowdAIController");
		}

		// Token: 0x06001892 RID: 6290 RVA: 0x000242B9 File Offset: 0x000224B9
		protected ADetourCrowdAIController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000638 RID: 1592
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.DetourCrowdAIController";

		// Token: 0x04000639 RID: 1593
		private static IntPtr _ClassPtr;

		// Token: 0x0400063A RID: 1594
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
