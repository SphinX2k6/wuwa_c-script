using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200123E RID: 4670
	[UnrealObjectPath("/Script/Engine.Volume")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1104)]
	public abstract class AVolume : ABrush, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601128A RID: 70282 RVA: 0x00192FFF File Offset: 0x001911FF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AVolume._ClassPtr;
		}

		// Token: 0x0601128B RID: 70283 RVA: 0x0019300B File Offset: 0x0019120B
		static AVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Volume");
		}

		// Token: 0x0601128C RID: 70284 RVA: 0x0019301C File Offset: 0x0019121C
		protected AVolume() : this(BuiltinUtils.AllocNativeUObject(AVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601128D RID: 70285 RVA: 0x00193044 File Offset: 0x00191244
		protected AVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040092E5 RID: 37605
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.Volume";

		// Token: 0x040092E6 RID: 37606
		private static IntPtr _ClassPtr;

		// Token: 0x040092E7 RID: 37607
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
