using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200029F RID: 671
	[UnrealObjectPath("/Script/Engine.TextureRenderTarget")]
	[UnrealStructLayout(4128, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4128)]
	public abstract class UTextureRenderTarget : UTexture, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600498E RID: 18830 RVA: 0x0006721A File Offset: 0x0006541A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTextureRenderTarget._ClassPtr;
		}

		// Token: 0x17000DCC RID: 3532
		// (get) Token: 0x0600498F RID: 18831 RVA: 0x00067226 File Offset: 0x00065426
		// (set) Token: 0x06004990 RID: 18832 RVA: 0x00067236 File Offset: 0x00065436
		public unsafe float TargetGamma
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextureRenderTarget.__PropertyOffset_TargetGamma);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextureRenderTarget.__PropertyOffset_TargetGamma) = value;
			}
		}

		// Token: 0x06004991 RID: 18833 RVA: 0x00067247 File Offset: 0x00065447
		static UTextureRenderTarget()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.TextureRenderTarget");
		}

		// Token: 0x06004992 RID: 18834 RVA: 0x00067258 File Offset: 0x00065458
		protected UTextureRenderTarget() : this(BuiltinUtils.AllocNativeUObject(UTextureRenderTarget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004993 RID: 18835 RVA: 0x00067280 File Offset: 0x00065480
		protected UTextureRenderTarget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001CF0 RID: 7408
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.TextureRenderTarget";

		// Token: 0x04001CF1 RID: 7409
		private static IntPtr _ClassPtr;

		// Token: 0x04001CF2 RID: 7410
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001CF3 RID: 7411
		internal static int __PropertyOffset_TargetGamma;
	}
}
