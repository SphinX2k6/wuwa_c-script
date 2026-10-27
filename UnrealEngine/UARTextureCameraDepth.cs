using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003CC RID: 972
	[UnrealObjectPath("/Script/AugmentedReality.ARTextureCameraDepth")]
	[UnrealStructLayout(3952, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3952)]
	public abstract class UARTextureCameraDepth : UARTexture, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600366C RID: 13932 RVA: 0x0005294D File Offset: 0x00050B4D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UARTextureCameraDepth._ClassPtr;
		}

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x0600366D RID: 13933 RVA: 0x00052959 File Offset: 0x00050B59
		// (set) Token: 0x0600366E RID: 13934 RVA: 0x00052969 File Offset: 0x00050B69
		public unsafe EARDepthQuality DepthQuality
		{
			get
			{
				return (EARDepthQuality)(*(base.NativePtr + (IntPtr)UARTextureCameraDepth.__PropertyOffset_DepthQuality));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARTextureCameraDepth.__PropertyOffset_DepthQuality) = (byte)value;
			}
		}

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x0600366F RID: 13935 RVA: 0x0005297A File Offset: 0x00050B7A
		// (set) Token: 0x06003670 RID: 13936 RVA: 0x0005298A File Offset: 0x00050B8A
		public unsafe EARDepthAccuracy DepthAccuracy
		{
			get
			{
				return (EARDepthAccuracy)(*(base.NativePtr + (IntPtr)UARTextureCameraDepth.__PropertyOffset_DepthAccuracy));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARTextureCameraDepth.__PropertyOffset_DepthAccuracy) = (byte)value;
			}
		}

		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x06003671 RID: 13937 RVA: 0x0005299B File Offset: 0x00050B9B
		// (set) Token: 0x06003672 RID: 13938 RVA: 0x000529AB File Offset: 0x00050BAB
		public unsafe bool bIsTemporallySmoothed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARTextureCameraDepth.__PropertyOffset_bIsTemporallySmoothed) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARTextureCameraDepth.__PropertyOffset_bIsTemporallySmoothed) = (value ? 1 : 0);
			}
		}

		// Token: 0x06003673 RID: 13939 RVA: 0x000529BC File Offset: 0x00050BBC
		static UARTextureCameraDepth()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARTextureCameraDepth");
		}

		// Token: 0x06003674 RID: 13940 RVA: 0x000529CC File Offset: 0x00050BCC
		protected UARTextureCameraDepth() : this(BuiltinUtils.AllocNativeUObject(UARTextureCameraDepth.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003675 RID: 13941 RVA: 0x000529F4 File Offset: 0x00050BF4
		protected UARTextureCameraDepth(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001788 RID: 6024
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AugmentedReality.ARTextureCameraDepth";

		// Token: 0x04001789 RID: 6025
		private static IntPtr _ClassPtr;

		// Token: 0x0400178A RID: 6026
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400178B RID: 6027
		internal static int __PropertyOffset_DepthQuality;

		// Token: 0x0400178C RID: 6028
		internal static int __PropertyOffset_DepthAccuracy;

		// Token: 0x0400178D RID: 6029
		internal static int __PropertyOffset_bIsTemporallySmoothed;
	}
}
