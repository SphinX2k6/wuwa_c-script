using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020027C6 RID: 10182
	[UnrealObjectPath("/Script/SimplygonUObjects.OpacityMaskVertexColorCaster")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UOpacityMaskVertexColorCaster : UBaseColorVertexColorCaster, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025F74 RID: 155508 RVA: 0x00399125 File Offset: 0x00397325
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UOpacityMaskVertexColorCaster._ClassPtr;
		}

		// Token: 0x06025F75 RID: 155509 RVA: 0x00399134 File Offset: 0x00397334
		public UOpacityMaskVertexColorCaster() : this(BuiltinUtils.AllocNativeUObject(UOpacityMaskVertexColorCaster.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025F76 RID: 155510 RVA: 0x0039915C File Offset: 0x0039735C
		[NullableContext(1)]
		public UOpacityMaskVertexColorCaster(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UOpacityMaskVertexColorCaster.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06025F77 RID: 155511 RVA: 0x0039918F File Offset: 0x0039738F
		static UOpacityMaskVertexColorCaster()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SimplygonUObjects.OpacityMaskVertexColorCaster");
		}

		// Token: 0x06025F78 RID: 155512 RVA: 0x0039919D File Offset: 0x0039739D
		protected UOpacityMaskVertexColorCaster(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014B97 RID: 84887
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SimplygonUObjects.OpacityMaskVertexColorCaster";

		// Token: 0x04014B98 RID: 84888
		private static IntPtr _ClassPtr;

		// Token: 0x04014B99 RID: 84889
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
