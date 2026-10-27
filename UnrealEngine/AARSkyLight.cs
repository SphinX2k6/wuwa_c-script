using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003CA RID: 970
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AugmentedReality.ARSkyLight")]
	[UnrealStructLayout(1080, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1080)]
	public class AARSkyLight : ASkyLight, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003657 RID: 13911 RVA: 0x000527A6 File Offset: 0x000509A6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AARSkyLight._ClassPtr;
		}

		// Token: 0x06003658 RID: 13912 RVA: 0x000527B4 File Offset: 0x000509B4
		public AARSkyLight() : this(BuiltinUtils.AllocNativeUObject(AARSkyLight.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003659 RID: 13913 RVA: 0x000527DC File Offset: 0x000509DC
		[NullableContext(1)]
		public AARSkyLight(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AARSkyLight.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x0600365A RID: 13914 RVA: 0x0005280F File Offset: 0x00050A0F
		// (set) Token: 0x0600365B RID: 13915 RVA: 0x00052823 File Offset: 0x00050A23
		public unsafe UAREnvironmentCaptureProbe CaptureProbe
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAREnvironmentCaptureProbe>(base.NativePtr / (IntPtr)sizeof(void*) + AARSkyLight.__PropertyOffset_CaptureProbe);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AARSkyLight.__PropertyOffset_CaptureProbe, value);
			}
		}

		// Token: 0x0600365C RID: 13916 RVA: 0x00052838 File Offset: 0x00050A38
		public void SetEnvironmentCaptureProbe(UAREnvironmentCaptureProbe InCaptureProbe)
		{
			AARSkyLight.__SetEnvironmentCaptureProbe_Internal(base.NativePtr, (InCaptureProbe != null) ? InCaptureProbe.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600365D RID: 13917
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnvironmentCaptureProbe_Internal(IntPtr @this, IntPtr InCaptureProbe);

		// Token: 0x0600365E RID: 13918 RVA: 0x00052855 File Offset: 0x00050A55
		static AARSkyLight()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARSkyLight");
		}

		// Token: 0x0600365F RID: 13919 RVA: 0x00052863 File Offset: 0x00050A63
		protected AARSkyLight(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400177D RID: 6013
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AugmentedReality.ARSkyLight";

		// Token: 0x0400177E RID: 6014
		private static IntPtr _ClassPtr;

		// Token: 0x0400177F RID: 6015
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001780 RID: 6016
		internal static int __PropertyOffset_CaptureProbe;
	}
}
