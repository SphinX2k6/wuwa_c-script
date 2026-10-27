using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002137 RID: 8503
	[UnrealObjectPath("/Script/LGUI.UICustomDepthStencilMaskActor")]
	[UnrealStructLayout(1672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1672)]
	public class AUICustomDepthStencilMaskActor : AUIPostProcessBaseActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020038 RID: 131128 RVA: 0x002F9AE2 File Offset: 0x002F7CE2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AUICustomDepthStencilMaskActor._ClassPtr;
		}

		// Token: 0x06020039 RID: 131129 RVA: 0x002F9AF0 File Offset: 0x002F7CF0
		public AUICustomDepthStencilMaskActor() : this(BuiltinUtils.AllocNativeUObject(AUICustomDepthStencilMaskActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602003A RID: 131130 RVA: 0x002F9B18 File Offset: 0x002F7D18
		[NullableContext(1)]
		public AUICustomDepthStencilMaskActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AUICustomDepthStencilMaskActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007DC3 RID: 32195
		// (get) Token: 0x0602003B RID: 131131 RVA: 0x002F9B4B File Offset: 0x002F7D4B
		// (set) Token: 0x0602003C RID: 131132 RVA: 0x002F9B5F File Offset: 0x002F7D5F
		[Nullable(2)]
		public unsafe UUICustomDepthStencilMask UICustomDepthStencilMask
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUICustomDepthStencilMask>(base.NativePtr / (IntPtr)sizeof(void*) + AUICustomDepthStencilMaskActor.__PropertyOffset_UICustomDepthStencilMask);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AUICustomDepthStencilMaskActor.__PropertyOffset_UICustomDepthStencilMask, value);
			}
		}

		// Token: 0x0602003D RID: 131133 RVA: 0x002F9B74 File Offset: 0x002F7D74
		static AUICustomDepthStencilMaskActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UICustomDepthStencilMaskActor");
		}

		// Token: 0x0602003E RID: 131134 RVA: 0x002F9B82 File Offset: 0x002F7D82
		protected AUICustomDepthStencilMaskActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040113C0 RID: 70592
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UICustomDepthStencilMaskActor";

		// Token: 0x040113C1 RID: 70593
		private static IntPtr _ClassPtr;

		// Token: 0x040113C2 RID: 70594
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040113C3 RID: 70595
		internal static int __PropertyOffset_UICustomDepthStencilMask;
	}
}
