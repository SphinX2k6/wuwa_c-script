using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F56 RID: 8022
	[UnrealObjectPath("/Script/Landscape.ControlPointMeshComponent")]
	[UnrealStructLayout(2032, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2032)]
	public class UControlPointMeshComponent : UStaticMeshComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E78E RID: 124814 RVA: 0x002D4C3F File Offset: 0x002D2E3F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UControlPointMeshComponent._ClassPtr;
		}

		// Token: 0x0601E78F RID: 124815 RVA: 0x002D4C4C File Offset: 0x002D2E4C
		public UControlPointMeshComponent() : this(BuiltinUtils.AllocNativeUObject(UControlPointMeshComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E790 RID: 124816 RVA: 0x002D4C74 File Offset: 0x002D2E74
		[NullableContext(1)]
		public UControlPointMeshComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UControlPointMeshComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700792E RID: 31022
		// (get) Token: 0x0601E791 RID: 124817 RVA: 0x002D4CA7 File Offset: 0x002D2EA7
		// (set) Token: 0x0601E792 RID: 124818 RVA: 0x002D4CB7 File Offset: 0x002D2EB7
		public unsafe float VirtualTextureMainPassMaxDrawDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UControlPointMeshComponent.__PropertyOffset_VirtualTextureMainPassMaxDrawDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UControlPointMeshComponent.__PropertyOffset_VirtualTextureMainPassMaxDrawDistance) = value;
			}
		}

		// Token: 0x0601E793 RID: 124819 RVA: 0x002D4CC8 File Offset: 0x002D2EC8
		static UControlPointMeshComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Landscape.ControlPointMeshComponent");
		}

		// Token: 0x0601E794 RID: 124820 RVA: 0x002D4CD6 File Offset: 0x002D2ED6
		protected UControlPointMeshComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010747 RID: 67399
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Landscape.ControlPointMeshComponent";

		// Token: 0x04010748 RID: 67400
		private static IntPtr _ClassPtr;

		// Token: 0x04010749 RID: 67401
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401074A RID: 67402
		internal static int __PropertyOffset_VirtualTextureMainPassMaxDrawDistance;
	}
}
