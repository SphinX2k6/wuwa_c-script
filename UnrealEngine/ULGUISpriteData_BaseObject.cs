using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006C0 RID: 1728
	[UnrealObjectPath("/Script/LGUI.LGUISpriteData_BaseObject")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class ULGUISpriteData_BaseObject : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060093E6 RID: 37862 RVA: 0x000DEEDD File Offset: 0x000DD0DD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUISpriteData_BaseObject._ClassPtr;
		}

		// Token: 0x060093E7 RID: 37863 RVA: 0x000DEEE9 File Offset: 0x000DD0E9
		public bool IsIndividual()
		{
			return ULGUISpriteData_BaseObject.__IsIndividual_Internal(base.NativePtr);
		}

		// Token: 0x060093E8 RID: 37864 RVA: 0x000DEEF6 File Offset: 0x000DD0F6
		[NullableContext(2)]
		public UTexture2D GetAtlasTexture()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture2D>(ULGUISpriteData_BaseObject.__GetAtlasTexture_Internal(base.NativePtr));
		}

		// Token: 0x060093E9 RID: 37865
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsIndividual_Internal(IntPtr @this);

		// Token: 0x060093EA RID: 37866
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAtlasTexture_Internal(IntPtr @this);

		// Token: 0x060093EB RID: 37867 RVA: 0x000DEF08 File Offset: 0x000DD108
		static ULGUISpriteData_BaseObject()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUISpriteData_BaseObject");
		}

		// Token: 0x060093EC RID: 37868 RVA: 0x000DEF18 File Offset: 0x000DD118
		protected ULGUISpriteData_BaseObject() : this(BuiltinUtils.AllocNativeUObject(ULGUISpriteData_BaseObject.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060093ED RID: 37869 RVA: 0x000DEF40 File Offset: 0x000DD140
		protected ULGUISpriteData_BaseObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004075 RID: 16501
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUISpriteData_BaseObject";

		// Token: 0x04004076 RID: 16502
		private static IntPtr _ClassPtr;

		// Token: 0x04004077 RID: 16503
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
