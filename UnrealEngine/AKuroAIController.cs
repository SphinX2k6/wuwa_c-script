using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018BC RID: 6332
	[UnrealObjectPath("/Script/KuroGameplay.KuroAIController")]
	[UnrealStructLayout(1312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1312)]
	public class AKuroAIController : AAIController, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601767F RID: 95871 RVA: 0x00223952 File Offset: 0x00221B52
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroAIController._ClassPtr;
		}

		// Token: 0x06017680 RID: 95872 RVA: 0x00223960 File Offset: 0x00221B60
		public AKuroAIController() : this(BuiltinUtils.AllocNativeUObject(AKuroAIController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017681 RID: 95873 RVA: 0x00223988 File Offset: 0x00221B88
		[NullableContext(1)]
		public AKuroAIController(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroAIController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06017682 RID: 95874 RVA: 0x002239BB File Offset: 0x00221BBB
		static AKuroAIController()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroAIController");
		}

		// Token: 0x06017683 RID: 95875 RVA: 0x002239C9 File Offset: 0x00221BC9
		protected AKuroAIController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CBB1 RID: 52145
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroAIController";

		// Token: 0x0400CBB2 RID: 52146
		private static IntPtr _ClassPtr;

		// Token: 0x0400CBB3 RID: 52147
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
