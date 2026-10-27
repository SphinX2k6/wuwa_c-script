using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002032 RID: 8242
	[UnrealObjectPath("/Script/LGUI.LGUICreateGeometryHelper")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class ULGUICreateGeometryHelper : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F2F0 RID: 127728 RVA: 0x002E4B83 File Offset: 0x002E2D83
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUICreateGeometryHelper._ClassPtr;
		}

		// Token: 0x0601F2F1 RID: 127729 RVA: 0x002E4B90 File Offset: 0x002E2D90
		public ULGUICreateGeometryHelper() : this(BuiltinUtils.AllocNativeUObject(ULGUICreateGeometryHelper.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F2F2 RID: 127730 RVA: 0x002E4BB8 File Offset: 0x002E2DB8
		[NullableContext(1)]
		public ULGUICreateGeometryHelper(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUICreateGeometryHelper.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601F2F3 RID: 127731 RVA: 0x002E4BEB File Offset: 0x002E2DEB
		[NullableContext(2)]
		public void AddVertexStruct(FLGUIGeometryVertex vertex)
		{
			ULGUICreateGeometryHelper.__AddVertexStruct_Internal(base.NativePtr, (vertex ?? new FLGUIGeometryVertex()).NativePtr);
		}

		// Token: 0x0601F2F4 RID: 127732 RVA: 0x002E4C07 File Offset: 0x002E2E07
		public void AddVertexSimple(FVector position, FColor color, FVector2D uv0)
		{
			ULGUICreateGeometryHelper.__AddVertexSimple_Internal(base.NativePtr, position, color, uv0);
		}

		// Token: 0x0601F2F5 RID: 127733 RVA: 0x002E4C18 File Offset: 0x002E2E18
		public void AddVertexFull(FVector position, FColor color, FVector2D uv0, FVector2D uv1, FVector2D uv2, FVector2D uv3, FVector normal, FVector tangent)
		{
			ULGUICreateGeometryHelper.__AddVertexFull_Internal(base.NativePtr, position, color, uv0, uv1, uv2, uv3, normal, tangent);
		}

		// Token: 0x0601F2F6 RID: 127734 RVA: 0x002E4C3D File Offset: 0x002E2E3D
		public void AddTriangle(int index0, int index1, int index2)
		{
			ULGUICreateGeometryHelper.__AddTriangle_Internal(base.NativePtr, index0, index1, index2);
		}

		// Token: 0x0601F2F7 RID: 127735
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddVertexStruct_Internal(IntPtr @this, IntPtr vertex);

		// Token: 0x0601F2F8 RID: 127736
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddVertexSimple_Internal(IntPtr @this, FVector position, FColor color, FVector2D uv0);

		// Token: 0x0601F2F9 RID: 127737
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddVertexFull_Internal(IntPtr @this, FVector position, FColor color, FVector2D uv0, FVector2D uv1, FVector2D uv2, FVector2D uv3, FVector normal, FVector tangent);

		// Token: 0x0601F2FA RID: 127738
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddTriangle_Internal(IntPtr @this, int index0, int index1, int index2);

		// Token: 0x0601F2FB RID: 127739 RVA: 0x002E4C4D File Offset: 0x002E2E4D
		static ULGUICreateGeometryHelper()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUICreateGeometryHelper");
		}

		// Token: 0x0601F2FC RID: 127740 RVA: 0x002E4C5B File Offset: 0x002E2E5B
		protected ULGUICreateGeometryHelper(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010E14 RID: 69140
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUICreateGeometryHelper";

		// Token: 0x04010E15 RID: 69141
		private static IntPtr _ClassPtr;

		// Token: 0x04010E16 RID: 69142
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
