using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200154A RID: 5450
	[UnrealObjectPath("/Script/InteractiveToolsFramework.GizmoBaseComponent")]
	[UnrealStructLayout(1600, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1600)]
	public class UGizmoBaseComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013C63 RID: 80995 RVA: 0x001D0AA4 File Offset: 0x001CECA4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGizmoBaseComponent._ClassPtr;
		}

		// Token: 0x06013C64 RID: 80996 RVA: 0x001D0AB0 File Offset: 0x001CECB0
		public UGizmoBaseComponent() : this(BuiltinUtils.AllocNativeUObject(UGizmoBaseComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013C65 RID: 80997 RVA: 0x001D0AD8 File Offset: 0x001CECD8
		[NullableContext(1)]
		public UGizmoBaseComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGizmoBaseComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004D79 RID: 19833
		// (get) Token: 0x06013C66 RID: 80998 RVA: 0x001D0B0B File Offset: 0x001CED0B
		// (set) Token: 0x06013C67 RID: 80999 RVA: 0x001D0B1F File Offset: 0x001CED1F
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoBaseComponent.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoBaseComponent.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x17004D7A RID: 19834
		// (get) Token: 0x06013C68 RID: 81000 RVA: 0x001D0B34 File Offset: 0x001CED34
		// (set) Token: 0x06013C69 RID: 81001 RVA: 0x001D0B44 File Offset: 0x001CED44
		public unsafe float HoverSizeMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoBaseComponent.__PropertyOffset_HoverSizeMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoBaseComponent.__PropertyOffset_HoverSizeMultiplier) = value;
			}
		}

		// Token: 0x17004D7B RID: 19835
		// (get) Token: 0x06013C6A RID: 81002 RVA: 0x001D0B55 File Offset: 0x001CED55
		// (set) Token: 0x06013C6B RID: 81003 RVA: 0x001D0B65 File Offset: 0x001CED65
		public unsafe float PixelHitDistanceThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoBaseComponent.__PropertyOffset_PixelHitDistanceThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoBaseComponent.__PropertyOffset_PixelHitDistanceThreshold) = value;
			}
		}

		// Token: 0x06013C6C RID: 81004 RVA: 0x001D0B76 File Offset: 0x001CED76
		public void UpdateWorldLocalState(bool bWorldIn)
		{
			UGizmoBaseComponent.__UpdateWorldLocalState_Internal(base.NativePtr, bWorldIn);
		}

		// Token: 0x06013C6D RID: 81005 RVA: 0x001D0B84 File Offset: 0x001CED84
		public void UpdateHoverState(bool bHoveringIn)
		{
			UGizmoBaseComponent.__UpdateHoverState_Internal(base.NativePtr, bHoveringIn);
		}

		// Token: 0x06013C6E RID: 81006
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateWorldLocalState_Internal(IntPtr @this, bool bWorldIn);

		// Token: 0x06013C6F RID: 81007
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateHoverState_Internal(IntPtr @this, bool bHoveringIn);

		// Token: 0x06013C70 RID: 81008 RVA: 0x001D0B92 File Offset: 0x001CED92
		static UGizmoBaseComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.GizmoBaseComponent");
		}

		// Token: 0x06013C71 RID: 81009 RVA: 0x001D0BA0 File Offset: 0x001CEDA0
		protected UGizmoBaseComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AB28 RID: 43816
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.GizmoBaseComponent";

		// Token: 0x0400AB29 RID: 43817
		private static IntPtr _ClassPtr;

		// Token: 0x0400AB2A RID: 43818
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AB2B RID: 43819
		internal static int __PropertyOffset_Color;

		// Token: 0x0400AB2C RID: 43820
		internal static int __PropertyOffset_HoverSizeMultiplier;

		// Token: 0x0400AB2D RID: 43821
		internal static int __PropertyOffset_PixelHitDistanceThreshold;
	}
}
