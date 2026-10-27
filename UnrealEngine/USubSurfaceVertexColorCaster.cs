using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020027E2 RID: 10210
	[UnrealObjectPath("/Script/SimplygonUObjects.SubSurfaceVertexColorCaster")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class USubSurfaceVertexColorCaster : UBaseColorVertexColorCaster, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060260F4 RID: 155892 RVA: 0x0039BA8E File Offset: 0x00399C8E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USubSurfaceVertexColorCaster._ClassPtr;
		}

		// Token: 0x060260F5 RID: 155893 RVA: 0x0039BA9C File Offset: 0x00399C9C
		public USubSurfaceVertexColorCaster() : this(BuiltinUtils.AllocNativeUObject(USubSurfaceVertexColorCaster.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060260F6 RID: 155894 RVA: 0x0039BAC4 File Offset: 0x00399CC4
		[NullableContext(1)]
		public USubSurfaceVertexColorCaster(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USubSurfaceVertexColorCaster.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060260F7 RID: 155895 RVA: 0x0039BAF7 File Offset: 0x00399CF7
		static USubSurfaceVertexColorCaster()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SimplygonUObjects.SubSurfaceVertexColorCaster");
		}

		// Token: 0x060260F8 RID: 155896 RVA: 0x0039BB05 File Offset: 0x00399D05
		protected USubSurfaceVertexColorCaster(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014C89 RID: 85129
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SimplygonUObjects.SubSurfaceVertexColorCaster";

		// Token: 0x04014C8A RID: 85130
		private static IntPtr _ClassPtr;

		// Token: 0x04014C8B RID: 85131
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
