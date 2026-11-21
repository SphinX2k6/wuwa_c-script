using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000660 RID: 1632
	[UnrealObjectPath("/Script/LGUI.GeometryHandle")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UGeometryHandle : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008DA5 RID: 36261 RVA: 0x000D5540 File Offset: 0x000D3740
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGeometryHandle._ClassPtr;
		}

		// Token: 0x06008DA6 RID: 36262 RVA: 0x000D554C File Offset: 0x000D374C
		public UGeometryHandle() : this(BuiltinUtils.AllocNativeUObject(UGeometryHandle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008DA7 RID: 36263 RVA: 0x000D5574 File Offset: 0x000D3774
		[NullableContext(1)]
		public UGeometryHandle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGeometryHandle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06008DA8 RID: 36264 RVA: 0x000D55A7 File Offset: 0x000D37A7
		public void SetAdditionalUV(int AdditionalUVChannel, in FVector2D UV)
		{
			UGeometryHandle.__SetAdditionalUV_Internal(base.NativePtr, AdditionalUVChannel, UV);
		}

		// Token: 0x06008DA9 RID: 36265 RVA: 0x000D55B6 File Offset: 0x000D37B6
		public bool IsGeometryValid()
		{
			return UGeometryHandle.__IsGeometryValid_Internal(base.NativePtr);
		}

		// Token: 0x06008DAA RID: 36266
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAdditionalUV_Internal(IntPtr @this, int AdditionalUVChannel, in FVector2D UV);

		// Token: 0x06008DAB RID: 36267
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsGeometryValid_Internal(IntPtr @this);

		// Token: 0x06008DAC RID: 36268 RVA: 0x000D55C3 File Offset: 0x000D37C3
		static UGeometryHandle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.GeometryHandle");
		}

		// Token: 0x06008DAD RID: 36269 RVA: 0x000D55D1 File Offset: 0x000D37D1
		protected UGeometryHandle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003E6C RID: 15980
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.GeometryHandle";

		// Token: 0x04003E6D RID: 15981
		private static IntPtr _ClassPtr;

		// Token: 0x04003E6E RID: 15982
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
