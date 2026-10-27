using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001573 RID: 5491
	[UnrealObjectPath("/Script/InteractiveToolsFramework.InteractiveGizmo")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UInteractiveGizmo : UObject, IUnrealUObject, IUnrealObject, IInputBehaviorSource, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06013DE8 RID: 81384 RVA: 0x001D2D1E File Offset: 0x001D0F1E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInteractiveGizmo._ClassPtr;
		}

		// Token: 0x06013DE9 RID: 81385 RVA: 0x001D2D2A File Offset: 0x001D0F2A
		int IInputBehaviorSource.InterfaceOffset()
		{
			return UInteractiveGizmo.__InterfaceOffset_IInputBehaviorSource;
		}

		// Token: 0x06013DEA RID: 81386 RVA: 0x001D2D34 File Offset: 0x001D0F34
		public UInteractiveGizmo() : this(BuiltinUtils.AllocNativeUObject(UInteractiveGizmo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013DEB RID: 81387 RVA: 0x001D2D5C File Offset: 0x001D0F5C
		[NullableContext(1)]
		public UInteractiveGizmo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInteractiveGizmo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004DD0 RID: 19920
		// (get) Token: 0x06013DEC RID: 81388 RVA: 0x001D2D8F File Offset: 0x001D0F8F
		// (set) Token: 0x06013DED RID: 81389 RVA: 0x001D2DA3 File Offset: 0x001D0FA3
		[Nullable(2)]
		public unsafe UInputBehaviorSet InputBehaviors
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInputBehaviorSet>(base.NativePtr / (IntPtr)sizeof(void*) + UInteractiveGizmo.__PropertyOffset_InputBehaviors);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UInteractiveGizmo.__PropertyOffset_InputBehaviors, value);
			}
		}

		// Token: 0x06013DEE RID: 81390 RVA: 0x001D2DB8 File Offset: 0x001D0FB8
		static UInteractiveGizmo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.InteractiveGizmo");
		}

		// Token: 0x06013DEF RID: 81391 RVA: 0x001D2DC6 File Offset: 0x001D0FC6
		protected UInteractiveGizmo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400ABFC RID: 44028
		internal static int __InterfaceOffset_IInputBehaviorSource;

		// Token: 0x0400ABFD RID: 44029
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.InteractiveGizmo";

		// Token: 0x0400ABFE RID: 44030
		private static IntPtr _ClassPtr;

		// Token: 0x0400ABFF RID: 44031
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AC00 RID: 44032
		internal static int __PropertyOffset_InputBehaviors;
	}
}
