using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020027E1 RID: 10209
	[UnrealObjectPath("/Script/SimplygonUObjects.SpecularVertexColorCaster")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class USpecularVertexColorCaster : UBaseColorVertexColorCaster, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060260EF RID: 155887 RVA: 0x0039BA0E File Offset: 0x00399C0E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USpecularVertexColorCaster._ClassPtr;
		}

		// Token: 0x060260F0 RID: 155888 RVA: 0x0039BA1C File Offset: 0x00399C1C
		public USpecularVertexColorCaster() : this(BuiltinUtils.AllocNativeUObject(USpecularVertexColorCaster.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060260F1 RID: 155889 RVA: 0x0039BA44 File Offset: 0x00399C44
		[NullableContext(1)]
		public USpecularVertexColorCaster(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USpecularVertexColorCaster.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060260F2 RID: 155890 RVA: 0x0039BA77 File Offset: 0x00399C77
		static USpecularVertexColorCaster()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SimplygonUObjects.SpecularVertexColorCaster");
		}

		// Token: 0x060260F3 RID: 155891 RVA: 0x0039BA85 File Offset: 0x00399C85
		protected USpecularVertexColorCaster(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014C86 RID: 85126
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SimplygonUObjects.SpecularVertexColorCaster";

		// Token: 0x04014C87 RID: 85127
		private static IntPtr _ClassPtr;

		// Token: 0x04014C88 RID: 85128
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
