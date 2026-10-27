using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D5D RID: 3421
	[UnrealObjectPath("/Script/Engine.LineBatchComponent")]
	[UnrealStructLayout(1632, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1632)]
	public class ULineBatchComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B8CA RID: 47306 RVA: 0x001070BA File Offset: 0x001052BA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULineBatchComponent._ClassPtr;
		}

		// Token: 0x0600B8CB RID: 47307 RVA: 0x001070C8 File Offset: 0x001052C8
		public ULineBatchComponent() : this(BuiltinUtils.AllocNativeUObject(ULineBatchComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B8CC RID: 47308 RVA: 0x001070F0 File Offset: 0x001052F0
		[NullableContext(1)]
		public ULineBatchComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULineBatchComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600B8CD RID: 47309 RVA: 0x00107123 File Offset: 0x00105323
		static ULineBatchComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LineBatchComponent");
		}

		// Token: 0x0600B8CE RID: 47310 RVA: 0x00107131 File Offset: 0x00105331
		protected ULineBatchComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040060D8 RID: 24792
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.LineBatchComponent";

		// Token: 0x040060D9 RID: 24793
		private static IntPtr _ClassPtr;

		// Token: 0x040060DA RID: 24794
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
