using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002A59 RID: 10841
	[UnrealObjectPath("/Script/VolumeGIRender.GIVolumeComponent")]
	[UnrealStructLayout(912, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 912)]
	public class UGIVolumeComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028080 RID: 163968 RVA: 0x003CEF89 File Offset: 0x003CD189
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGIVolumeComponent._ClassPtr;
		}

		// Token: 0x06028081 RID: 163969 RVA: 0x003CEF98 File Offset: 0x003CD198
		public UGIVolumeComponent() : this(BuiltinUtils.AllocNativeUObject(UGIVolumeComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028082 RID: 163970 RVA: 0x003CEFC0 File Offset: 0x003CD1C0
		[NullableContext(1)]
		public UGIVolumeComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGIVolumeComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170098E4 RID: 39140
		// (get) Token: 0x06028083 RID: 163971 RVA: 0x003CEFF3 File Offset: 0x003CD1F3
		// (set) Token: 0x06028084 RID: 163972 RVA: 0x003CF007 File Offset: 0x003CD207
		public unsafe FVector VolumeSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGIVolumeComponent.__PropertyOffset_VolumeSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGIVolumeComponent.__PropertyOffset_VolumeSize) = value;
			}
		}

		// Token: 0x170098E5 RID: 39141
		// (get) Token: 0x06028085 RID: 163973 RVA: 0x003CF01C File Offset: 0x003CD21C
		// (set) Token: 0x06028086 RID: 163974 RVA: 0x003CF030 File Offset: 0x003CD230
		public unsafe FIntVector VolumeDim
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGIVolumeComponent.__PropertyOffset_VolumeDim);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGIVolumeComponent.__PropertyOffset_VolumeDim) = value;
			}
		}

		// Token: 0x170098E6 RID: 39142
		// (get) Token: 0x06028087 RID: 163975 RVA: 0x003CF045 File Offset: 0x003CD245
		// (set) Token: 0x06028088 RID: 163976 RVA: 0x003CF055 File Offset: 0x003CD255
		public unsafe uint NumProbes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGIVolumeComponent.__PropertyOffset_NumProbes);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGIVolumeComponent.__PropertyOffset_NumProbes) = (int)value;
			}
		}

		// Token: 0x170098E7 RID: 39143
		// (get) Token: 0x06028089 RID: 163977 RVA: 0x003CF066 File Offset: 0x003CD266
		// (set) Token: 0x0602808A RID: 163978 RVA: 0x003CF076 File Offset: 0x003CD276
		public unsafe int Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGIVolumeComponent.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGIVolumeComponent.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x170098E8 RID: 39144
		// (get) Token: 0x0602808B RID: 163979 RVA: 0x003CF087 File Offset: 0x003CD287
		// (set) Token: 0x0602808C RID: 163980 RVA: 0x003CF097 File Offset: 0x003CD297
		public unsafe float SkyIndirectScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGIVolumeComponent.__PropertyOffset_SkyIndirectScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGIVolumeComponent.__PropertyOffset_SkyIndirectScale) = value;
			}
		}

		// Token: 0x170098E9 RID: 39145
		// (get) Token: 0x0602808D RID: 163981 RVA: 0x003CF0A8 File Offset: 0x003CD2A8
		// (set) Token: 0x0602808E RID: 163982 RVA: 0x003CF0B8 File Offset: 0x003CD2B8
		public unsafe float SunIndirectScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGIVolumeComponent.__PropertyOffset_SunIndirectScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGIVolumeComponent.__PropertyOffset_SunIndirectScale) = value;
			}
		}

		// Token: 0x170098EA RID: 39146
		// (get) Token: 0x0602808F RID: 163983 RVA: 0x003CF0C9 File Offset: 0x003CD2C9
		// (set) Token: 0x06028090 RID: 163984 RVA: 0x003CF0D9 File Offset: 0x003CD2D9
		public unsafe float StaticIrraidianceScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGIVolumeComponent.__PropertyOffset_StaticIrraidianceScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGIVolumeComponent.__PropertyOffset_StaticIrraidianceScale) = value;
			}
		}

		// Token: 0x170098EB RID: 39147
		// (get) Token: 0x06028091 RID: 163985 RVA: 0x003CF0EA File Offset: 0x003CD2EA
		// (set) Token: 0x06028092 RID: 163986 RVA: 0x003CF0FE File Offset: 0x003CD2FE
		public unsafe FLinearColor TintColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGIVolumeComponent.__PropertyOffset_TintColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGIVolumeComponent.__PropertyOffset_TintColor) = value;
			}
		}

		// Token: 0x06028093 RID: 163987 RVA: 0x003CF113 File Offset: 0x003CD313
		static UGIVolumeComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/VolumeGIRender.GIVolumeComponent");
		}

		// Token: 0x06028094 RID: 163988 RVA: 0x003CF121 File Offset: 0x003CD321
		protected UGIVolumeComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015F4C RID: 89932
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/VolumeGIRender.GIVolumeComponent";

		// Token: 0x04015F4D RID: 89933
		private static IntPtr _ClassPtr;

		// Token: 0x04015F4E RID: 89934
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015F4F RID: 89935
		internal static int __PropertyOffset_VolumeSize;

		// Token: 0x04015F50 RID: 89936
		internal static int __PropertyOffset_VolumeDim;

		// Token: 0x04015F51 RID: 89937
		internal static int __PropertyOffset_NumProbes;

		// Token: 0x04015F52 RID: 89938
		internal static int __PropertyOffset_Priority;

		// Token: 0x04015F53 RID: 89939
		internal static int __PropertyOffset_SkyIndirectScale;

		// Token: 0x04015F54 RID: 89940
		internal static int __PropertyOffset_SunIndirectScale;

		// Token: 0x04015F55 RID: 89941
		internal static int __PropertyOffset_StaticIrraidianceScale;

		// Token: 0x04015F56 RID: 89942
		internal static int __PropertyOffset_TintColor;
	}
}
