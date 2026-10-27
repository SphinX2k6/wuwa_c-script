using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011A5 RID: 4517
	[UnrealObjectPath("/Script/Engine.StereoLayerShapeQuad")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UStereoLayerShapeQuad : UStereoLayerShape, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010A4C RID: 68172 RVA: 0x00186F5C File Offset: 0x0018515C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UStereoLayerShapeQuad._ClassPtr;
		}

		// Token: 0x06010A4D RID: 68173 RVA: 0x00186F68 File Offset: 0x00185168
		public UStereoLayerShapeQuad() : this(BuiltinUtils.AllocNativeUObject(UStereoLayerShapeQuad.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010A4E RID: 68174 RVA: 0x00186F90 File Offset: 0x00185190
		[NullableContext(1)]
		public UStereoLayerShapeQuad(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UStereoLayerShapeQuad.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06010A4F RID: 68175 RVA: 0x00186FC3 File Offset: 0x001851C3
		static UStereoLayerShapeQuad()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.StereoLayerShapeQuad");
		}

		// Token: 0x06010A50 RID: 68176 RVA: 0x00186FD1 File Offset: 0x001851D1
		protected UStereoLayerShapeQuad(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008E60 RID: 36448
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.StereoLayerShapeQuad";

		// Token: 0x04008E61 RID: 36449
		private static IntPtr _ClassPtr;

		// Token: 0x04008E62 RID: 36450
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
