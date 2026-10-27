using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021C7 RID: 8647
	[UnrealObjectPath("/Script/LGUI.UIStaticMeshActor")]
	[UnrealStructLayout(1672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1672)]
	public class AUIStaticMeshActor : AUIBaseActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020E51 RID: 134737 RVA: 0x00309500 File Offset: 0x00307700
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AUIStaticMeshActor._ClassPtr;
		}

		// Token: 0x06020E52 RID: 134738 RVA: 0x0030950C File Offset: 0x0030770C
		public AUIStaticMeshActor() : this(BuiltinUtils.AllocNativeUObject(AUIStaticMeshActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020E53 RID: 134739 RVA: 0x00309534 File Offset: 0x00307734
		[NullableContext(1)]
		public AUIStaticMeshActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AUIStaticMeshActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008074 RID: 32884
		// (get) Token: 0x06020E54 RID: 134740 RVA: 0x00309567 File Offset: 0x00307767
		// (set) Token: 0x06020E55 RID: 134741 RVA: 0x0030957B File Offset: 0x0030777B
		[Nullable(2)]
		public unsafe UUIStaticMesh UIStaticMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUIStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + AUIStaticMeshActor.__PropertyOffset_UIStaticMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AUIStaticMeshActor.__PropertyOffset_UIStaticMesh, value);
			}
		}

		// Token: 0x06020E56 RID: 134742 RVA: 0x00309590 File Offset: 0x00307790
		static AUIStaticMeshActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIStaticMeshActor");
		}

		// Token: 0x06020E57 RID: 134743 RVA: 0x0030959E File Offset: 0x0030779E
		protected AUIStaticMeshActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011924 RID: 71972
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIStaticMeshActor";

		// Token: 0x04011925 RID: 71973
		private static IntPtr _ClassPtr;

		// Token: 0x04011926 RID: 71974
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011927 RID: 71975
		internal static int __PropertyOffset_UIStaticMesh;
	}
}
