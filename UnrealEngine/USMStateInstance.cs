using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002894 RID: 10388
	[UnrealObjectPath("/Script/SMSystem.SMStateInstance")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class USMStateInstance : USMStateInstance_Base, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060267B0 RID: 157616 RVA: 0x003A96E4 File Offset: 0x003A78E4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USMStateInstance._ClassPtr;
		}

		// Token: 0x060267B1 RID: 157617 RVA: 0x003A96F0 File Offset: 0x003A78F0
		public USMStateInstance() : this(BuiltinUtils.AllocNativeUObject(USMStateInstance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060267B2 RID: 157618 RVA: 0x003A9718 File Offset: 0x003A7918
		[NullableContext(1)]
		public USMStateInstance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USMStateInstance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060267B3 RID: 157619 RVA: 0x003A974B File Offset: 0x003A794B
		static USMStateInstance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SMSystem.SMStateInstance");
		}

		// Token: 0x060267B4 RID: 157620 RVA: 0x003A9759 File Offset: 0x003A7959
		protected USMStateInstance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040151E0 RID: 86496
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SMSystem.SMStateInstance";

		// Token: 0x040151E1 RID: 86497
		private static IntPtr _ClassPtr;

		// Token: 0x040151E2 RID: 86498
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
