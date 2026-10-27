using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020027BD RID: 10173
	[UnrealObjectPath("/Script/SimplygonUObjects.MetallicCaster")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UMetallicCaster : UBaseColorCaster, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025EEE RID: 155374 RVA: 0x00398337 File Offset: 0x00396537
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMetallicCaster._ClassPtr;
		}

		// Token: 0x06025EEF RID: 155375 RVA: 0x00398344 File Offset: 0x00396544
		public UMetallicCaster() : this(BuiltinUtils.AllocNativeUObject(UMetallicCaster.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025EF0 RID: 155376 RVA: 0x0039836C File Offset: 0x0039656C
		[NullableContext(1)]
		public UMetallicCaster(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMetallicCaster.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06025EF1 RID: 155377 RVA: 0x0039839F File Offset: 0x0039659F
		static UMetallicCaster()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SimplygonUObjects.MetallicCaster");
		}

		// Token: 0x06025EF2 RID: 155378 RVA: 0x003983AD File Offset: 0x003965AD
		protected UMetallicCaster(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014B44 RID: 84804
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SimplygonUObjects.MetallicCaster";

		// Token: 0x04014B45 RID: 84805
		private static IntPtr _ClassPtr;

		// Token: 0x04014B46 RID: 84806
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
