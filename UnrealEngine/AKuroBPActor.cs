using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004B3 RID: 1203
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroBPActor")]
	[UnrealStructLayout(1432, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1432)]
	public class AKuroBPActor : AKuroGameBudgetBlueprintActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006F21 RID: 28449 RVA: 0x000A4748 File Offset: 0x000A2948
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroBPActor._ClassPtr;
		}

		// Token: 0x06006F22 RID: 28450 RVA: 0x000A4754 File Offset: 0x000A2954
		public AKuroBPActor() : this(BuiltinUtils.AllocNativeUObject(AKuroBPActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006F23 RID: 28451 RVA: 0x000A477C File Offset: 0x000A297C
		[NullableContext(1)]
		public AKuroBPActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroBPActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006F24 RID: 28452 RVA: 0x000A47AF File Offset: 0x000A29AF
		static AKuroBPActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroBPActor");
		}

		// Token: 0x06006F25 RID: 28453 RVA: 0x000A47BD File Offset: 0x000A29BD
		protected AKuroBPActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400300E RID: 12302
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroBPActor";

		// Token: 0x0400300F RID: 12303
		private static IntPtr _ClassPtr;

		// Token: 0x04003010 RID: 12304
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
