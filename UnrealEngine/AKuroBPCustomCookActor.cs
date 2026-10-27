using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AB9 RID: 6841
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroBPCustomCookActor")]
	[UnrealStructLayout(1432, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1432)]
	public class AKuroBPCustomCookActor : AUKuroCustomCookActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019612 RID: 103954 RVA: 0x00258082 File Offset: 0x00256282
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroBPCustomCookActor._ClassPtr;
		}

		// Token: 0x06019613 RID: 103955 RVA: 0x00258090 File Offset: 0x00256290
		public AKuroBPCustomCookActor() : this(BuiltinUtils.AllocNativeUObject(AKuroBPCustomCookActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019614 RID: 103956 RVA: 0x002580B8 File Offset: 0x002562B8
		[NullableContext(1)]
		public AKuroBPCustomCookActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroBPCustomCookActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06019615 RID: 103957 RVA: 0x002580EB File Offset: 0x002562EB
		static AKuroBPCustomCookActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroBPCustomCookActor");
		}

		// Token: 0x06019616 RID: 103958 RVA: 0x002580F9 File Offset: 0x002562F9
		protected AKuroBPCustomCookActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DD47 RID: 56647
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroBPCustomCookActor";

		// Token: 0x0400DD48 RID: 56648
		private static IntPtr _ClassPtr;

		// Token: 0x0400DD49 RID: 56649
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
