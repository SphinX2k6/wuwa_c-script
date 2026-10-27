using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002209 RID: 8713
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkLightFrameData")]
	[UnrealStructLayout(256, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 256)]
	public class FLiveLinkLightFrameData : FLiveLinkTransformFrameData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021309 RID: 135945 RVA: 0x0030EEBE File Offset: 0x0030D0BE
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkLightFrameData._ScriptStructPtr != 0) ? FLiveLinkLightFrameData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkLightFrameData", ref FLiveLinkLightFrameData._ScriptStructPtr);
		}

		// Token: 0x1700818A RID: 33162
		// (get) Token: 0x0602130A RID: 135946 RVA: 0x0030EEE2 File Offset: 0x0030D0E2
		// (set) Token: 0x0602130B RID: 135947 RVA: 0x0030EEF2 File Offset: 0x0030D0F2
		public unsafe float Temperature
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkLightFrameData.__PropertyOffset_Temperature);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkLightFrameData.__PropertyOffset_Temperature) = value;
			}
		}

		// Token: 0x1700818B RID: 33163
		// (get) Token: 0x0602130C RID: 135948 RVA: 0x0030EF03 File Offset: 0x0030D103
		// (set) Token: 0x0602130D RID: 135949 RVA: 0x0030EF13 File Offset: 0x0030D113
		public unsafe float Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkLightFrameData.__PropertyOffset_Intensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkLightFrameData.__PropertyOffset_Intensity) = value;
			}
		}

		// Token: 0x1700818C RID: 33164
		// (get) Token: 0x0602130E RID: 135950 RVA: 0x0030EF24 File Offset: 0x0030D124
		// (set) Token: 0x0602130F RID: 135951 RVA: 0x0030EF38 File Offset: 0x0030D138
		public unsafe FColor LightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkLightFrameData.__PropertyOffset_LightColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkLightFrameData.__PropertyOffset_LightColor) = value;
			}
		}

		// Token: 0x1700818D RID: 33165
		// (get) Token: 0x06021310 RID: 135952 RVA: 0x0030EF4D File Offset: 0x0030D14D
		// (set) Token: 0x06021311 RID: 135953 RVA: 0x0030EF5D File Offset: 0x0030D15D
		public unsafe float InnerConeAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkLightFrameData.__PropertyOffset_InnerConeAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkLightFrameData.__PropertyOffset_InnerConeAngle) = value;
			}
		}

		// Token: 0x1700818E RID: 33166
		// (get) Token: 0x06021312 RID: 135954 RVA: 0x0030EF6E File Offset: 0x0030D16E
		// (set) Token: 0x06021313 RID: 135955 RVA: 0x0030EF7E File Offset: 0x0030D17E
		public unsafe float OuterConeAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkLightFrameData.__PropertyOffset_OuterConeAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkLightFrameData.__PropertyOffset_OuterConeAngle) = value;
			}
		}

		// Token: 0x1700818F RID: 33167
		// (get) Token: 0x06021314 RID: 135956 RVA: 0x0030EF8F File Offset: 0x0030D18F
		// (set) Token: 0x06021315 RID: 135957 RVA: 0x0030EF9F File Offset: 0x0030D19F
		public unsafe float AttenuationRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkLightFrameData.__PropertyOffset_AttenuationRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkLightFrameData.__PropertyOffset_AttenuationRadius) = value;
			}
		}

		// Token: 0x17008190 RID: 33168
		// (get) Token: 0x06021316 RID: 135958 RVA: 0x0030EFB0 File Offset: 0x0030D1B0
		// (set) Token: 0x06021317 RID: 135959 RVA: 0x0030EFC0 File Offset: 0x0030D1C0
		public unsafe float SourceRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkLightFrameData.__PropertyOffset_SourceRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkLightFrameData.__PropertyOffset_SourceRadius) = value;
			}
		}

		// Token: 0x17008191 RID: 33169
		// (get) Token: 0x06021318 RID: 135960 RVA: 0x0030EFD1 File Offset: 0x0030D1D1
		// (set) Token: 0x06021319 RID: 135961 RVA: 0x0030EFE1 File Offset: 0x0030D1E1
		public unsafe float SoftSourceRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkLightFrameData.__PropertyOffset_SoftSourceRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkLightFrameData.__PropertyOffset_SoftSourceRadius) = value;
			}
		}

		// Token: 0x17008192 RID: 33170
		// (get) Token: 0x0602131A RID: 135962 RVA: 0x0030EFF2 File Offset: 0x0030D1F2
		// (set) Token: 0x0602131B RID: 135963 RVA: 0x0030F002 File Offset: 0x0030D202
		public unsafe float SourceLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkLightFrameData.__PropertyOffset_SourceLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkLightFrameData.__PropertyOffset_SourceLength) = value;
			}
		}

		// Token: 0x0602131C RID: 135964 RVA: 0x0030F013 File Offset: 0x0030D213
		public FLiveLinkLightFrameData()
		{
		}

		// Token: 0x0602131D RID: 135965 RVA: 0x0030F01C File Offset: 0x0030D21C
		[NullableContext(1)]
		public FLiveLinkLightFrameData(float Temperature, float Intensity, FColor LightColor, float InnerConeAngle, float OuterConeAngle, float AttenuationRadius, float SourceRadius, float SoftSourceRadius, float SourceLength, FTransform Transform, FLiveLinkWorldTime WorldTime, FLiveLinkMetaData MetaData, TArray<float> PropertyValues)
		{
			this.Temperature = Temperature;
			this.Intensity = Intensity;
			this.LightColor = LightColor;
			this.InnerConeAngle = InnerConeAngle;
			this.OuterConeAngle = OuterConeAngle;
			this.AttenuationRadius = AttenuationRadius;
			this.SourceRadius = SourceRadius;
			this.SoftSourceRadius = SoftSourceRadius;
			this.SourceLength = SourceLength;
			base.Transform = Transform;
			base.WorldTime = WorldTime;
			base.MetaData = MetaData;
			base.PropertyValues = PropertyValues;
		}

		// Token: 0x0602131E RID: 135966 RVA: 0x0030F094 File Offset: 0x0030D294
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkLightFrameData.StaticStruct();
		}

		// Token: 0x0602131F RID: 135967 RVA: 0x0030F0A0 File Offset: 0x0030D2A0
		[NullableContext(2)]
		public FLiveLinkLightFrameData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021320 RID: 135968 RVA: 0x0030F0AA File Offset: 0x0030D2AA
		public FLiveLinkLightFrameData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021321 RID: 135969 RVA: 0x0030F0B5 File Offset: 0x0030D2B5
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkLightFrameData(Pointer, false, true);
		}

		// Token: 0x06021322 RID: 135970 RVA: 0x0030F0BF File Offset: 0x0030D2BF
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkLightFrameData(Pointer, MemoryOwner);
		}

		// Token: 0x04011B4F RID: 72527
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkLightFrameData";

		// Token: 0x04011B50 RID: 72528
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011B51 RID: 72529
		internal static int __PropertyOffset_Temperature;

		// Token: 0x04011B52 RID: 72530
		internal static int __PropertyOffset_Intensity;

		// Token: 0x04011B53 RID: 72531
		internal static int __PropertyOffset_LightColor;

		// Token: 0x04011B54 RID: 72532
		internal static int __PropertyOffset_InnerConeAngle;

		// Token: 0x04011B55 RID: 72533
		internal static int __PropertyOffset_OuterConeAngle;

		// Token: 0x04011B56 RID: 72534
		internal static int __PropertyOffset_AttenuationRadius;

		// Token: 0x04011B57 RID: 72535
		internal static int __PropertyOffset_SourceRadius;

		// Token: 0x04011B58 RID: 72536
		internal static int __PropertyOffset_SoftSourceRadius;

		// Token: 0x04011B59 RID: 72537
		internal static int __PropertyOffset_SourceLength;
	}
}
