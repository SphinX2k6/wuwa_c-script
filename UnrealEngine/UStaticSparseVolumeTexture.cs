using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200119C RID: 4508
	[UnrealObjectPath("/Script/Engine.StaticSparseVolumeTexture")]
	[UnrealStructLayout(176, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UStaticSparseVolumeTexture : UStreamableSparseVolumeTexture, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060109BD RID: 68029 RVA: 0x0018647E File Offset: 0x0018467E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UStaticSparseVolumeTexture._ClassPtr;
		}

		// Token: 0x060109BE RID: 68030 RVA: 0x0018648C File Offset: 0x0018468C
		public UStaticSparseVolumeTexture() : this(BuiltinUtils.AllocNativeUObject(UStaticSparseVolumeTexture.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060109BF RID: 68031 RVA: 0x001864B4 File Offset: 0x001846B4
		[NullableContext(1)]
		public UStaticSparseVolumeTexture(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UStaticSparseVolumeTexture.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060109C0 RID: 68032 RVA: 0x001864E7 File Offset: 0x001846E7
		static UStaticSparseVolumeTexture()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.StaticSparseVolumeTexture");
		}

		// Token: 0x060109C1 RID: 68033 RVA: 0x001864F5 File Offset: 0x001846F5
		protected UStaticSparseVolumeTexture(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008E26 RID: 36390
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.StaticSparseVolumeTexture";

		// Token: 0x04008E27 RID: 36391
		private static IntPtr _ClassPtr;

		// Token: 0x04008E28 RID: 36392
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
