using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CB3 RID: 3251
	[UnrealObjectPath("/Script/Engine.InterpTrackSlomo")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public class UInterpTrackSlomo : UInterpTrackFloatBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A468 RID: 42088 RVA: 0x000E9D6A File Offset: 0x000E7F6A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackSlomo._ClassPtr;
		}

		// Token: 0x0600A469 RID: 42089 RVA: 0x000E9D78 File Offset: 0x000E7F78
		public UInterpTrackSlomo() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackSlomo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A46A RID: 42090 RVA: 0x000E9DA0 File Offset: 0x000E7FA0
		[NullableContext(1)]
		public UInterpTrackSlomo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackSlomo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600A46B RID: 42091 RVA: 0x000E9DD3 File Offset: 0x000E7FD3
		static UInterpTrackSlomo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackSlomo");
		}

		// Token: 0x0600A46C RID: 42092 RVA: 0x000E9DE1 File Offset: 0x000E7FE1
		protected UInterpTrackSlomo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005A6E RID: 23150
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.InterpTrackSlomo";

		// Token: 0x04005A6F RID: 23151
		private static IntPtr _ClassPtr;

		// Token: 0x04005A70 RID: 23152
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
