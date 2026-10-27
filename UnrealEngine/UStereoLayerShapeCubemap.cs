using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011A2 RID: 4514
	[UnrealObjectPath("/Script/Engine.StereoLayerShapeCubemap")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UStereoLayerShapeCubemap : UStereoLayerShape, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010A23 RID: 68131 RVA: 0x00186C3D File Offset: 0x00184E3D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UStereoLayerShapeCubemap._ClassPtr;
		}

		// Token: 0x06010A24 RID: 68132 RVA: 0x00186C4C File Offset: 0x00184E4C
		public UStereoLayerShapeCubemap() : this(BuiltinUtils.AllocNativeUObject(UStereoLayerShapeCubemap.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010A25 RID: 68133 RVA: 0x00186C74 File Offset: 0x00184E74
		[NullableContext(1)]
		public UStereoLayerShapeCubemap(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UStereoLayerShapeCubemap.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06010A26 RID: 68134 RVA: 0x00186CA7 File Offset: 0x00184EA7
		static UStereoLayerShapeCubemap()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.StereoLayerShapeCubemap");
		}

		// Token: 0x06010A27 RID: 68135 RVA: 0x00186CB5 File Offset: 0x00184EB5
		protected UStereoLayerShapeCubemap(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008E4E RID: 36430
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.StereoLayerShapeCubemap";

		// Token: 0x04008E4F RID: 36431
		private static IntPtr _ClassPtr;

		// Token: 0x04008E50 RID: 36432
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
