using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020027D2 RID: 10194
	[UnrealObjectPath("/Script/SimplygonUObjects.RoughnessCaster")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class URoughnessCaster : UBaseColorCaster, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026090 RID: 155792 RVA: 0x0039AFF8 File Offset: 0x003991F8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URoughnessCaster._ClassPtr;
		}

		// Token: 0x06026091 RID: 155793 RVA: 0x0039B004 File Offset: 0x00399204
		public URoughnessCaster() : this(BuiltinUtils.AllocNativeUObject(URoughnessCaster.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026092 RID: 155794 RVA: 0x0039B02C File Offset: 0x0039922C
		[NullableContext(1)]
		public URoughnessCaster(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URoughnessCaster.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06026093 RID: 155795 RVA: 0x0039B05F File Offset: 0x0039925F
		static URoughnessCaster()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SimplygonUObjects.RoughnessCaster");
		}

		// Token: 0x06026094 RID: 155796 RVA: 0x0039B06D File Offset: 0x0039926D
		protected URoughnessCaster(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014C48 RID: 85064
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SimplygonUObjects.RoughnessCaster";

		// Token: 0x04014C49 RID: 85065
		private static IntPtr _ClassPtr;

		// Token: 0x04014C4A RID: 85066
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
