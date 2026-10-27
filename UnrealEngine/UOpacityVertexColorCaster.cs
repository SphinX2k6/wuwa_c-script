using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020027C7 RID: 10183
	[UnrealObjectPath("/Script/SimplygonUObjects.OpacityVertexColorCaster")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UOpacityVertexColorCaster : UBaseColorVertexColorCaster, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025F79 RID: 155513 RVA: 0x003991A6 File Offset: 0x003973A6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UOpacityVertexColorCaster._ClassPtr;
		}

		// Token: 0x06025F7A RID: 155514 RVA: 0x003991B4 File Offset: 0x003973B4
		public UOpacityVertexColorCaster() : this(BuiltinUtils.AllocNativeUObject(UOpacityVertexColorCaster.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025F7B RID: 155515 RVA: 0x003991DC File Offset: 0x003973DC
		[NullableContext(1)]
		public UOpacityVertexColorCaster(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UOpacityVertexColorCaster.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06025F7C RID: 155516 RVA: 0x0039920F File Offset: 0x0039740F
		static UOpacityVertexColorCaster()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SimplygonUObjects.OpacityVertexColorCaster");
		}

		// Token: 0x06025F7D RID: 155517 RVA: 0x0039921D File Offset: 0x0039741D
		protected UOpacityVertexColorCaster(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014B9A RID: 84890
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SimplygonUObjects.OpacityVertexColorCaster";

		// Token: 0x04014B9B RID: 84891
		private static IntPtr _ClassPtr;

		// Token: 0x04014B9C RID: 84892
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
