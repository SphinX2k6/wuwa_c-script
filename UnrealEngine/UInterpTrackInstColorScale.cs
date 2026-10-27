using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C9C RID: 3228
	[UnrealObjectPath("/Script/Engine.InterpTrackInstColorScale")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UInterpTrackInstColorScale : UInterpTrackInst, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A396 RID: 41878 RVA: 0x000E8833 File Offset: 0x000E6A33
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackInstColorScale._ClassPtr;
		}

		// Token: 0x0600A397 RID: 41879 RVA: 0x000E8840 File Offset: 0x000E6A40
		public UInterpTrackInstColorScale() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstColorScale.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A398 RID: 41880 RVA: 0x000E8868 File Offset: 0x000E6A68
		[NullableContext(1)]
		public UInterpTrackInstColorScale(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstColorScale.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600A399 RID: 41881 RVA: 0x000E889B File Offset: 0x000E6A9B
		static UInterpTrackInstColorScale()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackInstColorScale");
		}

		// Token: 0x0600A39A RID: 41882 RVA: 0x000E88A9 File Offset: 0x000E6AA9
		protected UInterpTrackInstColorScale(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040059E6 RID: 23014
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.InterpTrackInstColorScale";

		// Token: 0x040059E7 RID: 23015
		private static IntPtr _ClassPtr;

		// Token: 0x040059E8 RID: 23016
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
