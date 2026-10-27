using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000106 RID: 262
	[UnrealObjectPath("/Script/AIModule.AISenseEvent")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UAISenseEvent : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060013C2 RID: 5058 RVA: 0x0001D242 File Offset: 0x0001B442
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAISenseEvent._ClassPtr;
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x0001D24E File Offset: 0x0001B44E
		static UAISenseEvent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.AISenseEvent");
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x0001D25C File Offset: 0x0001B45C
		protected UAISenseEvent() : this(BuiltinUtils.AllocNativeUObject(UAISenseEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060013C5 RID: 5061 RVA: 0x0001D284 File Offset: 0x0001B484
		protected UAISenseEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040003BF RID: 959
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.AISenseEvent";

		// Token: 0x040003C0 RID: 960
		private static IntPtr _ClassPtr;

		// Token: 0x040003C1 RID: 961
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
