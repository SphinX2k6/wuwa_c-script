using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FF0 RID: 4080
	[UnrealObjectPath("/Script/Engine.PlaneReflectionCapture")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public abstract class APlaneReflectionCapture : AReflectionCapture, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600DD1A RID: 56602 RVA: 0x001458AD File Offset: 0x00143AAD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return APlaneReflectionCapture._ClassPtr;
		}

		// Token: 0x0600DD1B RID: 56603 RVA: 0x001458B9 File Offset: 0x00143AB9
		static APlaneReflectionCapture()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PlaneReflectionCapture");
		}

		// Token: 0x0600DD1C RID: 56604 RVA: 0x001458C8 File Offset: 0x00143AC8
		protected APlaneReflectionCapture() : this(BuiltinUtils.AllocNativeUObject(APlaneReflectionCapture.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600DD1D RID: 56605 RVA: 0x001458F0 File Offset: 0x00143AF0
		protected APlaneReflectionCapture(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007782 RID: 30594
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PlaneReflectionCapture";

		// Token: 0x04007783 RID: 30595
		private static IntPtr _ClassPtr;

		// Token: 0x04007784 RID: 30596
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
