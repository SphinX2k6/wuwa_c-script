using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004B5 RID: 1205
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroBPCustomCookActor")]
	[UnrealStructLayout(1432, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1432)]
	public class AKuroBPCustomCookActor : AUKuroCustomCookActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006F2B RID: 28459 RVA: 0x000A4846 File Offset: 0x000A2A46
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroBPCustomCookActor._ClassPtr;
		}

		// Token: 0x06006F2C RID: 28460 RVA: 0x000A4854 File Offset: 0x000A2A54
		public AKuroBPCustomCookActor() : this(BuiltinUtils.AllocNativeUObject(AKuroBPCustomCookActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006F2D RID: 28461 RVA: 0x000A487C File Offset: 0x000A2A7C
		[NullableContext(1)]
		public AKuroBPCustomCookActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroBPCustomCookActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006F2E RID: 28462 RVA: 0x000A48AF File Offset: 0x000A2AAF
		static AKuroBPCustomCookActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroBPCustomCookActor");
		}

		// Token: 0x06006F2F RID: 28463 RVA: 0x000A48BD File Offset: 0x000A2ABD
		protected AKuroBPCustomCookActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003014 RID: 12308
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroBPCustomCookActor";

		// Token: 0x04003015 RID: 12309
		private static IntPtr _ClassPtr;

		// Token: 0x04003016 RID: 12310
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
