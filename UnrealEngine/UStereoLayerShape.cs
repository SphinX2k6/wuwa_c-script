using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011A1 RID: 4513
	[UnrealObjectPath("/Script/Engine.StereoLayerShape")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UStereoLayerShape : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010A1F RID: 68127 RVA: 0x00186BF0 File Offset: 0x00184DF0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UStereoLayerShape._ClassPtr;
		}

		// Token: 0x06010A20 RID: 68128 RVA: 0x00186BFC File Offset: 0x00184DFC
		static UStereoLayerShape()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.StereoLayerShape");
		}

		// Token: 0x06010A21 RID: 68129 RVA: 0x00186C0C File Offset: 0x00184E0C
		protected UStereoLayerShape() : this(BuiltinUtils.AllocNativeUObject(UStereoLayerShape.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010A22 RID: 68130 RVA: 0x00186C34 File Offset: 0x00184E34
		protected UStereoLayerShape(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008E4B RID: 36427
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.StereoLayerShape";

		// Token: 0x04008E4C RID: 36428
		private static IntPtr _ClassPtr;

		// Token: 0x04008E4D RID: 36429
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
