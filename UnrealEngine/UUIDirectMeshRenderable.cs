using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200213A RID: 8506
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIDirectMeshRenderable")]
	[UnrealStructLayout(1712, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1712)]
	public abstract class UUIDirectMeshRenderable : UUIBaseRenderable, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602005D RID: 131165 RVA: 0x002F9F63 File Offset: 0x002F8163
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIDirectMeshRenderable._ClassPtr;
		}

		// Token: 0x17007DCB RID: 32203
		// (get) Token: 0x0602005E RID: 131166 RVA: 0x002F9F6F File Offset: 0x002F816F
		// (set) Token: 0x0602005F RID: 131167 RVA: 0x002F9F83 File Offset: 0x002F8183
		public unsafe UUIDrawcallMesh UIMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUIDrawcallMesh>(base.NativePtr / (IntPtr)sizeof(void*) + UUIDirectMeshRenderable.__PropertyOffset_UIMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIDirectMeshRenderable.__PropertyOffset_UIMesh, value);
			}
		}

		// Token: 0x17007DCC RID: 32204
		// (get) Token: 0x06020060 RID: 131168 RVA: 0x002F9F98 File Offset: 0x002F8198
		// (set) Token: 0x06020061 RID: 131169 RVA: 0x002F9FAC File Offset: 0x002F81AC
		public unsafe UMaterialInterface CustomUIMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UUIDirectMeshRenderable.__PropertyOffset_CustomUIMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIDirectMeshRenderable.__PropertyOffset_CustomUIMaterial, value);
			}
		}

		// Token: 0x17007DCD RID: 32205
		// (get) Token: 0x06020062 RID: 131170 RVA: 0x002F9FC1 File Offset: 0x002F81C1
		// (set) Token: 0x06020063 RID: 131171 RVA: 0x002F9FD5 File Offset: 0x002F81D5
		public unsafe UMaterialInstanceDynamic MaterialInstanceDynamic
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + UUIDirectMeshRenderable.__PropertyOffset_MaterialInstanceDynamic);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIDirectMeshRenderable.__PropertyOffset_MaterialInstanceDynamic, value);
			}
		}

		// Token: 0x06020064 RID: 131172 RVA: 0x002F9FEA File Offset: 0x002F81EA
		public void SetCustormUIMaterial(UMaterialInterface NewMaterial)
		{
			UUIDirectMeshRenderable.__SetCustormUIMaterial_Internal(base.NativePtr, (NewMaterial != null) ? NewMaterial.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06020065 RID: 131173
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCustormUIMaterial_Internal(IntPtr @this, IntPtr NewMaterial);

		// Token: 0x06020066 RID: 131174 RVA: 0x002FA007 File Offset: 0x002F8207
		static UUIDirectMeshRenderable()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIDirectMeshRenderable");
		}

		// Token: 0x06020067 RID: 131175 RVA: 0x002FA018 File Offset: 0x002F8218
		protected UUIDirectMeshRenderable() : this(BuiltinUtils.AllocNativeUObject(UUIDirectMeshRenderable.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020068 RID: 131176 RVA: 0x002FA040 File Offset: 0x002F8240
		protected UUIDirectMeshRenderable(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040113D6 RID: 70614
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIDirectMeshRenderable";

		// Token: 0x040113D7 RID: 70615
		private static IntPtr _ClassPtr;

		// Token: 0x040113D8 RID: 70616
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040113D9 RID: 70617
		internal static int __PropertyOffset_UIMesh;

		// Token: 0x040113DA RID: 70618
		internal static int __PropertyOffset_CustomUIMaterial;

		// Token: 0x040113DB RID: 70619
		internal static int __PropertyOffset_MaterialInstanceDynamic;
	}
}
