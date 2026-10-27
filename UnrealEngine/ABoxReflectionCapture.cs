using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008E8 RID: 2280
	[UnrealObjectPath("/Script/Engine.BoxReflectionCapture")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public class ABoxReflectionCapture : AReflectionCapture, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007D1B RID: 32027 RVA: 0x000B3554 File Offset: 0x000B1754
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ABoxReflectionCapture._ClassPtr;
		}

		// Token: 0x06007D1C RID: 32028 RVA: 0x000B3560 File Offset: 0x000B1760
		public ABoxReflectionCapture() : this(BuiltinUtils.AllocNativeUObject(ABoxReflectionCapture.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007D1D RID: 32029 RVA: 0x000B3588 File Offset: 0x000B1788
		[NullableContext(1)]
		public ABoxReflectionCapture(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABoxReflectionCapture.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06007D1E RID: 32030 RVA: 0x000B35BB File Offset: 0x000B17BB
		static ABoxReflectionCapture()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BoxReflectionCapture");
		}

		// Token: 0x06007D1F RID: 32031 RVA: 0x000B35C9 File Offset: 0x000B17C9
		protected ABoxReflectionCapture(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003BF4 RID: 15348
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.BoxReflectionCapture";

		// Token: 0x04003BF5 RID: 15349
		private static IntPtr _ClassPtr;

		// Token: 0x04003BF6 RID: 15350
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
