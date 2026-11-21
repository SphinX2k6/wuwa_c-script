using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003DA RID: 986
	[UnrealObjectPath("/Script/KuroGameplay.KuroAIController")]
	[UnrealStructLayout(1312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1312)]
	public class AKuroAIController : AAIController, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006112 RID: 24850 RVA: 0x0008AB32 File Offset: 0x00088D32
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroAIController._ClassPtr;
		}

		// Token: 0x06006113 RID: 24851 RVA: 0x0008AB40 File Offset: 0x00088D40
		public AKuroAIController() : this(BuiltinUtils.AllocNativeUObject(AKuroAIController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006114 RID: 24852 RVA: 0x0008AB68 File Offset: 0x00088D68
		[NullableContext(1)]
		public AKuroAIController(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroAIController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006115 RID: 24853 RVA: 0x0008AB9B File Offset: 0x00088D9B
		static AKuroAIController()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroAIController");
		}

		// Token: 0x06006116 RID: 24854 RVA: 0x0008ABA9 File Offset: 0x00088DA9
		protected AKuroAIController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400295D RID: 10589
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroAIController";

		// Token: 0x0400295E RID: 10590
		private static IntPtr _ClassPtr;

		// Token: 0x0400295F RID: 10591
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
