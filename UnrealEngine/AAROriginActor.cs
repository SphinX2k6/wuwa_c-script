using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003B3 RID: 947
	[UnrealObjectPath("/Script/AugmentedReality.AROriginActor")]
	[UnrealStructLayout(1040, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1040)]
	public class AAROriginActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003470 RID: 13424 RVA: 0x00050244 File Offset: 0x0004E444
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AAROriginActor._ClassPtr;
		}

		// Token: 0x06003471 RID: 13425 RVA: 0x00050250 File Offset: 0x0004E450
		public AAROriginActor() : this(BuiltinUtils.AllocNativeUObject(AAROriginActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003472 RID: 13426 RVA: 0x00050278 File Offset: 0x0004E478
		[NullableContext(1)]
		public AAROriginActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AAROriginActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06003473 RID: 13427 RVA: 0x000502AB File Offset: 0x0004E4AB
		static AAROriginActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.AROriginActor");
		}

		// Token: 0x06003474 RID: 13428 RVA: 0x000502B9 File Offset: 0x0004E4B9
		protected AAROriginActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040016C1 RID: 5825
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AugmentedReality.AROriginActor";

		// Token: 0x040016C2 RID: 5826
		private static IntPtr _ClassPtr;

		// Token: 0x040016C3 RID: 5827
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
