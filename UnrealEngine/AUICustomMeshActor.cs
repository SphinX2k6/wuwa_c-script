using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002139 RID: 8505
	[UnrealObjectPath("/Script/LGUI.UICustomMeshActor")]
	[UnrealStructLayout(1672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1672)]
	public class AUICustomMeshActor : AUIBaseActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020056 RID: 131158 RVA: 0x002F9EBC File Offset: 0x002F80BC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AUICustomMeshActor._ClassPtr;
		}

		// Token: 0x06020057 RID: 131159 RVA: 0x002F9EC8 File Offset: 0x002F80C8
		public AUICustomMeshActor() : this(BuiltinUtils.AllocNativeUObject(AUICustomMeshActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020058 RID: 131160 RVA: 0x002F9EF0 File Offset: 0x002F80F0
		[NullableContext(1)]
		public AUICustomMeshActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AUICustomMeshActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007DCA RID: 32202
		// (get) Token: 0x06020059 RID: 131161 RVA: 0x002F9F23 File Offset: 0x002F8123
		// (set) Token: 0x0602005A RID: 131162 RVA: 0x002F9F37 File Offset: 0x002F8137
		[Nullable(2)]
		public unsafe UUICustomMesh customMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUICustomMesh>(base.NativePtr / (IntPtr)sizeof(void*) + AUICustomMeshActor.__PropertyOffset_customMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AUICustomMeshActor.__PropertyOffset_customMesh, value);
			}
		}

		// Token: 0x0602005B RID: 131163 RVA: 0x002F9F4C File Offset: 0x002F814C
		static AUICustomMeshActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UICustomMeshActor");
		}

		// Token: 0x0602005C RID: 131164 RVA: 0x002F9F5A File Offset: 0x002F815A
		protected AUICustomMeshActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040113D2 RID: 70610
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UICustomMeshActor";

		// Token: 0x040113D3 RID: 70611
		private static IntPtr _ClassPtr;

		// Token: 0x040113D4 RID: 70612
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040113D5 RID: 70613
		internal static int __PropertyOffset_customMesh;
	}
}
