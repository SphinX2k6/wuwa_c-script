using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C8E RID: 3214
	[UnrealObjectPath("/Script/Engine.InterpTrackColorScale")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public class UInterpTrackColorScale : UInterpTrackVectorBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A325 RID: 41765 RVA: 0x000E7C8B File Offset: 0x000E5E8B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackColorScale._ClassPtr;
		}

		// Token: 0x0600A326 RID: 41766 RVA: 0x000E7C98 File Offset: 0x000E5E98
		public UInterpTrackColorScale() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackColorScale.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A327 RID: 41767 RVA: 0x000E7CC0 File Offset: 0x000E5EC0
		[NullableContext(1)]
		public UInterpTrackColorScale(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackColorScale.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600A328 RID: 41768 RVA: 0x000E7CF3 File Offset: 0x000E5EF3
		static UInterpTrackColorScale()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackColorScale");
		}

		// Token: 0x0600A329 RID: 41769 RVA: 0x000E7D01 File Offset: 0x000E5F01
		protected UInterpTrackColorScale(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400599B RID: 22939
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.InterpTrackColorScale";

		// Token: 0x0400599C RID: 22940
		private static IntPtr _ClassPtr;

		// Token: 0x0400599D RID: 22941
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
