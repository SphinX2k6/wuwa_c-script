using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200277C RID: 10108
	[UnrealObjectPath("/Script/SimplygonUObjects.BaseColorVertexColorCaster")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UBaseColorVertexColorCaster : USimplygonVertexColorCaster, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025C94 RID: 154772 RVA: 0x00394849 File Offset: 0x00392A49
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBaseColorVertexColorCaster._ClassPtr;
		}

		// Token: 0x06025C95 RID: 154773 RVA: 0x00394858 File Offset: 0x00392A58
		public UBaseColorVertexColorCaster() : this(BuiltinUtils.AllocNativeUObject(UBaseColorVertexColorCaster.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025C96 RID: 154774 RVA: 0x00394880 File Offset: 0x00392A80
		[NullableContext(1)]
		public UBaseColorVertexColorCaster(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBaseColorVertexColorCaster.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06025C97 RID: 154775 RVA: 0x003948B3 File Offset: 0x00392AB3
		static UBaseColorVertexColorCaster()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SimplygonUObjects.BaseColorVertexColorCaster");
		}

		// Token: 0x06025C98 RID: 154776 RVA: 0x003948C1 File Offset: 0x00392AC1
		protected UBaseColorVertexColorCaster(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014921 RID: 84257
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SimplygonUObjects.BaseColorVertexColorCaster";

		// Token: 0x04014922 RID: 84258
		private static IntPtr _ClassPtr;

		// Token: 0x04014923 RID: 84259
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
