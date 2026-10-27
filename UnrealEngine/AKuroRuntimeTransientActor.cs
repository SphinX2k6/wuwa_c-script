using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BA3 RID: 7075
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroRuntimeTransientActor")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class AKuroRuntimeTransientActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B0F5 RID: 110837 RVA: 0x0027DE85 File Offset: 0x0027C085
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroRuntimeTransientActor._ClassPtr;
		}

		// Token: 0x0601B0F6 RID: 110838 RVA: 0x0027DE94 File Offset: 0x0027C094
		public AKuroRuntimeTransientActor() : this(BuiltinUtils.AllocNativeUObject(AKuroRuntimeTransientActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B0F7 RID: 110839 RVA: 0x0027DEBC File Offset: 0x0027C0BC
		[NullableContext(1)]
		public AKuroRuntimeTransientActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroRuntimeTransientActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601B0F8 RID: 110840 RVA: 0x0027DEEF File Offset: 0x0027C0EF
		static AKuroRuntimeTransientActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroRuntimeTransientActor");
		}

		// Token: 0x0601B0F9 RID: 110841 RVA: 0x0027DEFD File Offset: 0x0027C0FD
		protected AKuroRuntimeTransientActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E91A RID: 59674
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroRuntimeTransientActor";

		// Token: 0x0400E91B RID: 59675
		private static IntPtr _ClassPtr;

		// Token: 0x0400E91C RID: 59676
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
