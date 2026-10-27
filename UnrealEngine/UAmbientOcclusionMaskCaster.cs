using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002778 RID: 10104
	[UnrealObjectPath("/Script/SimplygonUObjects.AmbientOcclusionMaskCaster")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UAmbientOcclusionMaskCaster : UBaseColorCaster, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025C67 RID: 154727 RVA: 0x00394418 File Offset: 0x00392618
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAmbientOcclusionMaskCaster._ClassPtr;
		}

		// Token: 0x06025C68 RID: 154728 RVA: 0x00394424 File Offset: 0x00392624
		public UAmbientOcclusionMaskCaster() : this(BuiltinUtils.AllocNativeUObject(UAmbientOcclusionMaskCaster.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025C69 RID: 154729 RVA: 0x0039444C File Offset: 0x0039264C
		[NullableContext(1)]
		public UAmbientOcclusionMaskCaster(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAmbientOcclusionMaskCaster.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06025C6A RID: 154730 RVA: 0x0039447F File Offset: 0x0039267F
		static UAmbientOcclusionMaskCaster()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SimplygonUObjects.AmbientOcclusionMaskCaster");
		}

		// Token: 0x06025C6B RID: 154731 RVA: 0x0039448D File Offset: 0x0039268D
		protected UAmbientOcclusionMaskCaster(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014908 RID: 84232
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SimplygonUObjects.AmbientOcclusionMaskCaster";

		// Token: 0x04014909 RID: 84233
		private static IntPtr _ClassPtr;

		// Token: 0x0401490A RID: 84234
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
