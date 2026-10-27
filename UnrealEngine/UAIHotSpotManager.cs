using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000EE RID: 238
	[UnrealObjectPath("/Script/AIModule.AIHotSpotManager")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UAIHotSpotManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060012C5 RID: 4805 RVA: 0x0001BCBD File Offset: 0x00019EBD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAIHotSpotManager._ClassPtr;
		}

		// Token: 0x060012C6 RID: 4806 RVA: 0x0001BCCC File Offset: 0x00019ECC
		public UAIHotSpotManager() : this(BuiltinUtils.AllocNativeUObject(UAIHotSpotManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060012C7 RID: 4807 RVA: 0x0001BCF4 File Offset: 0x00019EF4
		[NullableContext(1)]
		public UAIHotSpotManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAIHotSpotManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x0001BD27 File Offset: 0x00019F27
		static UAIHotSpotManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.AIHotSpotManager");
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x0001BD35 File Offset: 0x00019F35
		protected UAIHotSpotManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400034A RID: 842
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.AIHotSpotManager";

		// Token: 0x0400034B RID: 843
		private static IntPtr _ClassPtr;

		// Token: 0x0400034C RID: 844
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
