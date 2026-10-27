using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021A2 RID: 8610
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UISceneViewActor")]
	[UnrealStructLayout(1672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1672)]
	public class AUISceneViewActor : AUIBaseActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020A83 RID: 133763 RVA: 0x00305390 File Offset: 0x00303590
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AUISceneViewActor._ClassPtr;
		}

		// Token: 0x06020A84 RID: 133764 RVA: 0x0030539C File Offset: 0x0030359C
		public AUISceneViewActor() : this(BuiltinUtils.AllocNativeUObject(AUISceneViewActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020A85 RID: 133765 RVA: 0x003053C4 File Offset: 0x003035C4
		[NullableContext(1)]
		public AUISceneViewActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AUISceneViewActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007FA6 RID: 32678
		// (get) Token: 0x06020A86 RID: 133766 RVA: 0x003053F7 File Offset: 0x003035F7
		// (set) Token: 0x06020A87 RID: 133767 RVA: 0x0030540B File Offset: 0x0030360B
		public unsafe UUISceneView UISceneView
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUISceneView>(base.NativePtr / (IntPtr)sizeof(void*) + AUISceneViewActor.__PropertyOffset_UISceneView);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AUISceneViewActor.__PropertyOffset_UISceneView, value);
			}
		}

		// Token: 0x06020A88 RID: 133768 RVA: 0x00305420 File Offset: 0x00303620
		public UUISceneView GetUISceneView()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUISceneView>(AUISceneViewActor.__GetUISceneView_Internal(base.NativePtr));
		}

		// Token: 0x06020A89 RID: 133769
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetUISceneView_Internal(IntPtr @this);

		// Token: 0x06020A8A RID: 133770 RVA: 0x00305432 File Offset: 0x00303632
		static AUISceneViewActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UISceneViewActor");
		}

		// Token: 0x06020A8B RID: 133771 RVA: 0x00305440 File Offset: 0x00303640
		protected AUISceneViewActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011794 RID: 71572
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UISceneViewActor";

		// Token: 0x04011795 RID: 71573
		private static IntPtr _ClassPtr;

		// Token: 0x04011796 RID: 71574
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011797 RID: 71575
		internal static int __PropertyOffset_UISceneView;
	}
}
