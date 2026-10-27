using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020027C2 RID: 10178
	[UnrealObjectPath("/Script/SimplygonUObjects.NormalVertexColorCaster")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UNormalVertexColorCaster : UBaseColorVertexColorCaster, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025F3F RID: 155455 RVA: 0x00398BE4 File Offset: 0x00396DE4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNormalVertexColorCaster._ClassPtr;
		}

		// Token: 0x06025F40 RID: 155456 RVA: 0x00398BF0 File Offset: 0x00396DF0
		public UNormalVertexColorCaster() : this(BuiltinUtils.AllocNativeUObject(UNormalVertexColorCaster.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025F41 RID: 155457 RVA: 0x00398C18 File Offset: 0x00396E18
		[NullableContext(1)]
		public UNormalVertexColorCaster(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNormalVertexColorCaster.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06025F42 RID: 155458 RVA: 0x00398C4B File Offset: 0x00396E4B
		static UNormalVertexColorCaster()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SimplygonUObjects.NormalVertexColorCaster");
		}

		// Token: 0x06025F43 RID: 155459 RVA: 0x00398C59 File Offset: 0x00396E59
		protected UNormalVertexColorCaster(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014B78 RID: 84856
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SimplygonUObjects.NormalVertexColorCaster";

		// Token: 0x04014B79 RID: 84857
		private static IntPtr _ClassPtr;

		// Token: 0x04014B7A RID: 84858
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
