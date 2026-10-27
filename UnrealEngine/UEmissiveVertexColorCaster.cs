using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002792 RID: 10130
	[UnrealObjectPath("/Script/SimplygonUObjects.EmissiveVertexColorCaster")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UEmissiveVertexColorCaster : UBaseColorVertexColorCaster, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025D99 RID: 155033 RVA: 0x0039623A File Offset: 0x0039443A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEmissiveVertexColorCaster._ClassPtr;
		}

		// Token: 0x06025D9A RID: 155034 RVA: 0x00396248 File Offset: 0x00394448
		public UEmissiveVertexColorCaster() : this(BuiltinUtils.AllocNativeUObject(UEmissiveVertexColorCaster.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025D9B RID: 155035 RVA: 0x00396270 File Offset: 0x00394470
		[NullableContext(1)]
		public UEmissiveVertexColorCaster(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEmissiveVertexColorCaster.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06025D9C RID: 155036 RVA: 0x003962A3 File Offset: 0x003944A3
		static UEmissiveVertexColorCaster()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SimplygonUObjects.EmissiveVertexColorCaster");
		}

		// Token: 0x06025D9D RID: 155037 RVA: 0x003962B1 File Offset: 0x003944B1
		protected UEmissiveVertexColorCaster(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040149FF RID: 84479
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SimplygonUObjects.EmissiveVertexColorCaster";

		// Token: 0x04014A00 RID: 84480
		private static IntPtr _ClassPtr;

		// Token: 0x04014A01 RID: 84481
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
