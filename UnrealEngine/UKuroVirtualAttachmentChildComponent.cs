using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BDD RID: 7133
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroVirtualAttachmentChildComponent")]
	[UnrealStructLayout(672, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 672)]
	public class UKuroVirtualAttachmentChildComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B638 RID: 112184 RVA: 0x00285BCD File Offset: 0x00283DCD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroVirtualAttachmentChildComponent._ClassPtr;
		}

		// Token: 0x0601B639 RID: 112185 RVA: 0x00285BDC File Offset: 0x00283DDC
		public UKuroVirtualAttachmentChildComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroVirtualAttachmentChildComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B63A RID: 112186 RVA: 0x00285C04 File Offset: 0x00283E04
		[NullableContext(1)]
		public UKuroVirtualAttachmentChildComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroVirtualAttachmentChildComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006E0E RID: 28174
		// (get) Token: 0x0601B63B RID: 112187 RVA: 0x00285C37 File Offset: 0x00283E37
		// (set) Token: 0x0601B63C RID: 112188 RVA: 0x00285C4B File Offset: 0x00283E4B
		public unsafe FGuid ParentGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVirtualAttachmentChildComponent.__PropertyOffset_ParentGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVirtualAttachmentChildComponent.__PropertyOffset_ParentGuid) = value;
			}
		}

		// Token: 0x17006E0F RID: 28175
		// (get) Token: 0x0601B63D RID: 112189 RVA: 0x00285C60 File Offset: 0x00283E60
		// (set) Token: 0x0601B63E RID: 112190 RVA: 0x00285C74 File Offset: 0x00283E74
		public unsafe FTransform RelativeTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVirtualAttachmentChildComponent.__PropertyOffset_RelativeTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVirtualAttachmentChildComponent.__PropertyOffset_RelativeTransform) = value;
			}
		}

		// Token: 0x0601B63F RID: 112191 RVA: 0x00285C89 File Offset: 0x00283E89
		static UKuroVirtualAttachmentChildComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroVirtualAttachmentChildComponent");
		}

		// Token: 0x0601B640 RID: 112192 RVA: 0x00285C97 File Offset: 0x00283E97
		protected UKuroVirtualAttachmentChildComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EBE6 RID: 60390
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroVirtualAttachmentChildComponent";

		// Token: 0x0400EBE7 RID: 60391
		private static IntPtr _ClassPtr;

		// Token: 0x0400EBE8 RID: 60392
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EBE9 RID: 60393
		internal static int __PropertyOffset_ParentGuid;

		// Token: 0x0400EBEA RID: 60394
		internal static int __PropertyOffset_RelativeTransform;
	}
}
