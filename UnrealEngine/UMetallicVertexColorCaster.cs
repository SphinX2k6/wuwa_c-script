using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020027BE RID: 10174
	[UnrealObjectPath("/Script/SimplygonUObjects.MetallicVertexColorCaster")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UMetallicVertexColorCaster : UBaseColorVertexColorCaster, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025EF3 RID: 155379 RVA: 0x003983B6 File Offset: 0x003965B6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMetallicVertexColorCaster._ClassPtr;
		}

		// Token: 0x06025EF4 RID: 155380 RVA: 0x003983C4 File Offset: 0x003965C4
		public UMetallicVertexColorCaster() : this(BuiltinUtils.AllocNativeUObject(UMetallicVertexColorCaster.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025EF5 RID: 155381 RVA: 0x003983EC File Offset: 0x003965EC
		[NullableContext(1)]
		public UMetallicVertexColorCaster(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMetallicVertexColorCaster.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06025EF6 RID: 155382 RVA: 0x0039841F File Offset: 0x0039661F
		static UMetallicVertexColorCaster()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SimplygonUObjects.MetallicVertexColorCaster");
		}

		// Token: 0x06025EF7 RID: 155383 RVA: 0x0039842D File Offset: 0x0039662D
		protected UMetallicVertexColorCaster(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014B47 RID: 84807
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SimplygonUObjects.MetallicVertexColorCaster";

		// Token: 0x04014B48 RID: 84808
		private static IntPtr _ClassPtr;

		// Token: 0x04014B49 RID: 84809
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
