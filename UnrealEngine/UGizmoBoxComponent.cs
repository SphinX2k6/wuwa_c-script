using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200154F RID: 5455
	[UnrealObjectPath("/Script/InteractiveToolsFramework.GizmoBoxComponent")]
	[UnrealStructLayout(1664, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1664)]
	public class UGizmoBoxComponent : UGizmoBaseComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013C85 RID: 81029 RVA: 0x001D0D3E File Offset: 0x001CEF3E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGizmoBoxComponent._ClassPtr;
		}

		// Token: 0x06013C86 RID: 81030 RVA: 0x001D0D4C File Offset: 0x001CEF4C
		public UGizmoBoxComponent() : this(BuiltinUtils.AllocNativeUObject(UGizmoBoxComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013C87 RID: 81031 RVA: 0x001D0D74 File Offset: 0x001CEF74
		[NullableContext(1)]
		public UGizmoBoxComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGizmoBoxComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004D7C RID: 19836
		// (get) Token: 0x06013C88 RID: 81032 RVA: 0x001D0DA7 File Offset: 0x001CEFA7
		// (set) Token: 0x06013C89 RID: 81033 RVA: 0x001D0DBB File Offset: 0x001CEFBB
		public unsafe FVector Origin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoBoxComponent.__PropertyOffset_Origin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoBoxComponent.__PropertyOffset_Origin) = value;
			}
		}

		// Token: 0x17004D7D RID: 19837
		// (get) Token: 0x06013C8A RID: 81034 RVA: 0x001D0DD0 File Offset: 0x001CEFD0
		// (set) Token: 0x06013C8B RID: 81035 RVA: 0x001D0DE4 File Offset: 0x001CEFE4
		public unsafe FQuat Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoBoxComponent.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoBoxComponent.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x17004D7E RID: 19838
		// (get) Token: 0x06013C8C RID: 81036 RVA: 0x001D0DF9 File Offset: 0x001CEFF9
		// (set) Token: 0x06013C8D RID: 81037 RVA: 0x001D0E0D File Offset: 0x001CF00D
		public unsafe FVector Dimensions
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoBoxComponent.__PropertyOffset_Dimensions);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoBoxComponent.__PropertyOffset_Dimensions) = value;
			}
		}

		// Token: 0x17004D7F RID: 19839
		// (get) Token: 0x06013C8E RID: 81038 RVA: 0x001D0E22 File Offset: 0x001CF022
		// (set) Token: 0x06013C8F RID: 81039 RVA: 0x001D0E32 File Offset: 0x001CF032
		public unsafe float LineThickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoBoxComponent.__PropertyOffset_LineThickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoBoxComponent.__PropertyOffset_LineThickness) = value;
			}
		}

		// Token: 0x17004D80 RID: 19840
		// (get) Token: 0x06013C90 RID: 81040 RVA: 0x001D0E43 File Offset: 0x001CF043
		// (set) Token: 0x06013C91 RID: 81041 RVA: 0x001D0E53 File Offset: 0x001CF053
		public unsafe bool bRemoveHiddenLines
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoBoxComponent.__PropertyOffset_bRemoveHiddenLines) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoBoxComponent.__PropertyOffset_bRemoveHiddenLines) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004D81 RID: 19841
		// (get) Token: 0x06013C92 RID: 81042 RVA: 0x001D0E64 File Offset: 0x001CF064
		// (set) Token: 0x06013C93 RID: 81043 RVA: 0x001D0E74 File Offset: 0x001CF074
		public unsafe bool bEnableAxisFlip
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoBoxComponent.__PropertyOffset_bEnableAxisFlip) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoBoxComponent.__PropertyOffset_bEnableAxisFlip) = (value ? 1 : 0);
			}
		}

		// Token: 0x06013C94 RID: 81044 RVA: 0x001D0E85 File Offset: 0x001CF085
		static UGizmoBoxComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.GizmoBoxComponent");
		}

		// Token: 0x06013C95 RID: 81045 RVA: 0x001D0E93 File Offset: 0x001CF093
		protected UGizmoBoxComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AB3B RID: 43835
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.GizmoBoxComponent";

		// Token: 0x0400AB3C RID: 43836
		private static IntPtr _ClassPtr;

		// Token: 0x0400AB3D RID: 43837
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AB3E RID: 43838
		internal static int __PropertyOffset_Origin;

		// Token: 0x0400AB3F RID: 43839
		internal static int __PropertyOffset_Rotation;

		// Token: 0x0400AB40 RID: 43840
		internal static int __PropertyOffset_Dimensions;

		// Token: 0x0400AB41 RID: 43841
		internal static int __PropertyOffset_LineThickness;

		// Token: 0x0400AB42 RID: 43842
		internal static int __PropertyOffset_bRemoveHiddenLines;

		// Token: 0x0400AB43 RID: 43843
		internal static int __PropertyOffset_bEnableAxisFlip;
	}
}
