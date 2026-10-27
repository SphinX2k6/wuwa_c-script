using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001202 RID: 4610
	[UnrealObjectPath("/Script/Engine.TransvoxelMeshComponent")]
	[UnrealStructLayout(1696, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1696)]
	public class UTransvoxelMeshComponent : UMeshComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010FE3 RID: 69603 RVA: 0x0018F07B File Offset: 0x0018D27B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTransvoxelMeshComponent._ClassPtr;
		}

		// Token: 0x06010FE4 RID: 69604 RVA: 0x0018F088 File Offset: 0x0018D288
		public UTransvoxelMeshComponent() : this(BuiltinUtils.AllocNativeUObject(UTransvoxelMeshComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010FE5 RID: 69605 RVA: 0x0018F0B0 File Offset: 0x0018D2B0
		[NullableContext(1)]
		public UTransvoxelMeshComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTransvoxelMeshComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004264 RID: 16996
		// (get) Token: 0x06010FE6 RID: 69606 RVA: 0x0018F0E3 File Offset: 0x0018D2E3
		// (set) Token: 0x06010FE7 RID: 69607 RVA: 0x0018F0F3 File Offset: 0x0018D2F3
		public unsafe bool bRenderingEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransvoxelMeshComponent.__PropertyOffset_bRenderingEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransvoxelMeshComponent.__PropertyOffset_bRenderingEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004265 RID: 16997
		// (get) Token: 0x06010FE8 RID: 69608 RVA: 0x0018F104 File Offset: 0x0018D304
		// (set) Token: 0x06010FE9 RID: 69609 RVA: 0x0018F114 File Offset: 0x0018D314
		public unsafe bool bShowColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransvoxelMeshComponent.__PropertyOffset_bShowColor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransvoxelMeshComponent.__PropertyOffset_bShowColor) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004266 RID: 16998
		// (get) Token: 0x06010FEA RID: 69610 RVA: 0x0018F125 File Offset: 0x0018D325
		// (set) Token: 0x06010FEB RID: 69611 RVA: 0x0018F135 File Offset: 0x0018D335
		public unsafe bool bEnableTessellation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransvoxelMeshComponent.__PropertyOffset_bEnableTessellation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransvoxelMeshComponent.__PropertyOffset_bEnableTessellation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004267 RID: 16999
		// (get) Token: 0x06010FEC RID: 69612 RVA: 0x0018F146 File Offset: 0x0018D346
		// (set) Token: 0x06010FED RID: 69613 RVA: 0x0018F156 File Offset: 0x0018D356
		public unsafe bool bShowExactTessWireframe
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransvoxelMeshComponent.__PropertyOffset_bShowExactTessWireframe) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransvoxelMeshComponent.__PropertyOffset_bShowExactTessWireframe) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004268 RID: 17000
		// (get) Token: 0x06010FEE RID: 69614 RVA: 0x0018F167 File Offset: 0x0018D367
		// (set) Token: 0x06010FEF RID: 69615 RVA: 0x0018F177 File Offset: 0x0018D377
		public unsafe bool bEnableShaderWireframeOverlay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransvoxelMeshComponent.__PropertyOffset_bEnableShaderWireframeOverlay) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransvoxelMeshComponent.__PropertyOffset_bEnableShaderWireframeOverlay) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004269 RID: 17001
		// (get) Token: 0x06010FF0 RID: 69616 RVA: 0x0018F188 File Offset: 0x0018D388
		// (set) Token: 0x06010FF1 RID: 69617 RVA: 0x0018F198 File Offset: 0x0018D398
		public unsafe float TessNearDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransvoxelMeshComponent.__PropertyOffset_TessNearDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransvoxelMeshComponent.__PropertyOffset_TessNearDistance) = value;
			}
		}

		// Token: 0x1700426A RID: 17002
		// (get) Token: 0x06010FF2 RID: 69618 RVA: 0x0018F1A9 File Offset: 0x0018D3A9
		// (set) Token: 0x06010FF3 RID: 69619 RVA: 0x0018F1B9 File Offset: 0x0018D3B9
		public unsafe float TessFarDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransvoxelMeshComponent.__PropertyOffset_TessFarDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransvoxelMeshComponent.__PropertyOffset_TessFarDistance) = value;
			}
		}

		// Token: 0x1700426B RID: 17003
		// (get) Token: 0x06010FF4 RID: 69620 RVA: 0x0018F1CA File Offset: 0x0018D3CA
		// (set) Token: 0x06010FF5 RID: 69621 RVA: 0x0018F1DA File Offset: 0x0018D3DA
		public unsafe float TessMinFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransvoxelMeshComponent.__PropertyOffset_TessMinFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransvoxelMeshComponent.__PropertyOffset_TessMinFactor) = value;
			}
		}

		// Token: 0x1700426C RID: 17004
		// (get) Token: 0x06010FF6 RID: 69622 RVA: 0x0018F1EB File Offset: 0x0018D3EB
		// (set) Token: 0x06010FF7 RID: 69623 RVA: 0x0018F1FB File Offset: 0x0018D3FB
		public unsafe float TessMaxFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransvoxelMeshComponent.__PropertyOffset_TessMaxFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransvoxelMeshComponent.__PropertyOffset_TessMaxFactor) = value;
			}
		}

		// Token: 0x1700426D RID: 17005
		// (get) Token: 0x06010FF8 RID: 69624 RVA: 0x0018F20C File Offset: 0x0018D40C
		// (set) Token: 0x06010FF9 RID: 69625 RVA: 0x0018F21C File Offset: 0x0018D41C
		public unsafe float TessBulgeStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransvoxelMeshComponent.__PropertyOffset_TessBulgeStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransvoxelMeshComponent.__PropertyOffset_TessBulgeStrength) = value;
			}
		}

		// Token: 0x06010FFA RID: 69626 RVA: 0x0018F22D File Offset: 0x0018D42D
		static UTransvoxelMeshComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.TransvoxelMeshComponent");
		}

		// Token: 0x06010FFB RID: 69627 RVA: 0x0018F23B File Offset: 0x0018D43B
		protected UTransvoxelMeshComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009196 RID: 37270
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.TransvoxelMeshComponent";

		// Token: 0x04009197 RID: 37271
		private static IntPtr _ClassPtr;

		// Token: 0x04009198 RID: 37272
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009199 RID: 37273
		internal static int __PropertyOffset_bRenderingEnabled;

		// Token: 0x0400919A RID: 37274
		internal static int __PropertyOffset_bShowColor;

		// Token: 0x0400919B RID: 37275
		internal static int __PropertyOffset_bEnableTessellation;

		// Token: 0x0400919C RID: 37276
		internal static int __PropertyOffset_bShowExactTessWireframe;

		// Token: 0x0400919D RID: 37277
		internal static int __PropertyOffset_bEnableShaderWireframeOverlay;

		// Token: 0x0400919E RID: 37278
		internal static int __PropertyOffset_TessNearDistance;

		// Token: 0x0400919F RID: 37279
		internal static int __PropertyOffset_TessFarDistance;

		// Token: 0x040091A0 RID: 37280
		internal static int __PropertyOffset_TessMinFactor;

		// Token: 0x040091A1 RID: 37281
		internal static int __PropertyOffset_TessMaxFactor;

		// Token: 0x040091A2 RID: 37282
		internal static int __PropertyOffset_TessBulgeStrength;
	}
}
