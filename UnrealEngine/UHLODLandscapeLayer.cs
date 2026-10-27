using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C35 RID: 3125
	[UnrealObjectPath("/Script/Engine.HLODLandscapeLayer")]
	[UnrealStructLayout(504, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 504)]
	public class UHLODLandscapeLayer : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009E67 RID: 40551 RVA: 0x000E120A File Offset: 0x000DF40A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHLODLandscapeLayer._ClassPtr;
		}

		// Token: 0x06009E68 RID: 40552 RVA: 0x000E1218 File Offset: 0x000DF418
		public UHLODLandscapeLayer() : this(BuiltinUtils.AllocNativeUObject(UHLODLandscapeLayer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009E69 RID: 40553 RVA: 0x000E1240 File Offset: 0x000DF440
		[NullableContext(1)]
		public UHLODLandscapeLayer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHLODLandscapeLayer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06009E6A RID: 40554 RVA: 0x000E1273 File Offset: 0x000DF473
		static UHLODLandscapeLayer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.HLODLandscapeLayer");
		}

		// Token: 0x06009E6B RID: 40555 RVA: 0x000E1281 File Offset: 0x000DF481
		protected UHLODLandscapeLayer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005750 RID: 22352
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.HLODLandscapeLayer";

		// Token: 0x04005751 RID: 22353
		private static IntPtr _ClassPtr;

		// Token: 0x04005752 RID: 22354
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
