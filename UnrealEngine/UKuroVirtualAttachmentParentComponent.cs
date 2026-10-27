using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BDE RID: 7134
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroVirtualAttachmentParentComponent")]
	[UnrealStructLayout(752, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 752)]
	public class UKuroVirtualAttachmentParentComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B641 RID: 112193 RVA: 0x00285CA0 File Offset: 0x00283EA0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroVirtualAttachmentParentComponent._ClassPtr;
		}

		// Token: 0x0601B642 RID: 112194 RVA: 0x00285CAC File Offset: 0x00283EAC
		public UKuroVirtualAttachmentParentComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroVirtualAttachmentParentComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B643 RID: 112195 RVA: 0x00285CD4 File Offset: 0x00283ED4
		[NullableContext(1)]
		public UKuroVirtualAttachmentParentComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroVirtualAttachmentParentComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006E10 RID: 28176
		// (get) Token: 0x0601B644 RID: 112196 RVA: 0x00285D07 File Offset: 0x00283F07
		// (set) Token: 0x0601B645 RID: 112197 RVA: 0x00285D1B File Offset: 0x00283F1B
		public unsafe FGuid Guid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVirtualAttachmentParentComponent.__PropertyOffset_Guid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVirtualAttachmentParentComponent.__PropertyOffset_Guid) = value;
			}
		}

		// Token: 0x17006E11 RID: 28177
		// (get) Token: 0x0601B646 RID: 112198 RVA: 0x00285D30 File Offset: 0x00283F30
		// (set) Token: 0x0601B647 RID: 112199 RVA: 0x00285D44 File Offset: 0x00283F44
		public unsafe FGuid CombinedGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVirtualAttachmentParentComponent.__PropertyOffset_CombinedGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVirtualAttachmentParentComponent.__PropertyOffset_CombinedGuid) = value;
			}
		}

		// Token: 0x0601B648 RID: 112200 RVA: 0x00285D59 File Offset: 0x00283F59
		static UKuroVirtualAttachmentParentComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroVirtualAttachmentParentComponent");
		}

		// Token: 0x0601B649 RID: 112201 RVA: 0x00285D67 File Offset: 0x00283F67
		protected UKuroVirtualAttachmentParentComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EBEB RID: 60395
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroVirtualAttachmentParentComponent";

		// Token: 0x0400EBEC RID: 60396
		private static IntPtr _ClassPtr;

		// Token: 0x0400EBED RID: 60397
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EBEE RID: 60398
		internal static int __PropertyOffset_Guid;

		// Token: 0x0400EBEF RID: 60399
		internal static int __PropertyOffset_CombinedGuid;
	}
}
