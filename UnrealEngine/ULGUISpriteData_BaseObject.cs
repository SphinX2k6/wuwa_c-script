using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020C9 RID: 8393
	[UnrealObjectPath("/Script/LGUI.LGUISpriteData_BaseObject")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class ULGUISpriteData_BaseObject : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F9D0 RID: 129488 RVA: 0x002F01D6 File Offset: 0x002EE3D6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUISpriteData_BaseObject._ClassPtr;
		}

		// Token: 0x0601F9D1 RID: 129489 RVA: 0x002F01E2 File Offset: 0x002EE3E2
		public bool IsIndividual()
		{
			return ULGUISpriteData_BaseObject.__IsIndividual_Internal(base.NativePtr);
		}

		// Token: 0x0601F9D2 RID: 129490 RVA: 0x002F01EF File Offset: 0x002EE3EF
		[NullableContext(1)]
		public FLGUISpriteInfo GetSpriteInfo()
		{
			return new FLGUISpriteInfo(ULGUISpriteData_BaseObject.__GetSpriteInfo_Internal(base.NativePtr), null);
		}

		// Token: 0x0601F9D3 RID: 129491 RVA: 0x002F0202 File Offset: 0x002EE402
		[NullableContext(2)]
		public UTexture2D GetAtlasTexture()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture2D>(ULGUISpriteData_BaseObject.__GetAtlasTexture_Internal(base.NativePtr));
		}

		// Token: 0x0601F9D4 RID: 129492
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsIndividual_Internal(IntPtr @this);

		// Token: 0x0601F9D5 RID: 129493
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSpriteInfo_Internal(IntPtr @this);

		// Token: 0x0601F9D6 RID: 129494
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAtlasTexture_Internal(IntPtr @this);

		// Token: 0x0601F9D7 RID: 129495 RVA: 0x002F0214 File Offset: 0x002EE414
		static ULGUISpriteData_BaseObject()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUISpriteData_BaseObject");
		}

		// Token: 0x0601F9D8 RID: 129496 RVA: 0x002F0224 File Offset: 0x002EE424
		protected ULGUISpriteData_BaseObject() : this(BuiltinUtils.AllocNativeUObject(ULGUISpriteData_BaseObject.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F9D9 RID: 129497 RVA: 0x002F024C File Offset: 0x002EE44C
		protected ULGUISpriteData_BaseObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040110FB RID: 69883
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUISpriteData_BaseObject";

		// Token: 0x040110FC RID: 69884
		private static IntPtr _ClassPtr;

		// Token: 0x040110FD RID: 69885
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
