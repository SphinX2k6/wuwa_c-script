using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011DE RID: 4574
	[UnrealObjectPath("/Script/Engine.TextureRenderTarget")]
	[UnrealStructLayout(3920, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3920)]
	public abstract class UTextureRenderTarget : UTexture, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010D79 RID: 68985 RVA: 0x0018BB44 File Offset: 0x00189D44
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTextureRenderTarget._ClassPtr;
		}

		// Token: 0x170041CB RID: 16843
		// (get) Token: 0x06010D7A RID: 68986 RVA: 0x0018BB50 File Offset: 0x00189D50
		// (set) Token: 0x06010D7B RID: 68987 RVA: 0x0018BB60 File Offset: 0x00189D60
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

		// Token: 0x06010D7C RID: 68988 RVA: 0x0018BB71 File Offset: 0x00189D71
		static UTextureRenderTarget()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.TextureRenderTarget");
		}

		// Token: 0x06010D7D RID: 68989 RVA: 0x0018BB80 File Offset: 0x00189D80
		protected UTextureRenderTarget() : this(BuiltinUtils.AllocNativeUObject(UTextureRenderTarget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010D7E RID: 68990 RVA: 0x0018BBA8 File Offset: 0x00189DA8
		protected UTextureRenderTarget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009067 RID: 36967
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.TextureRenderTarget";

		// Token: 0x04009068 RID: 36968
		private static IntPtr _ClassPtr;

		// Token: 0x04009069 RID: 36969
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400906A RID: 36970
		internal static int __PropertyOffset_TargetGamma;
	}
}
