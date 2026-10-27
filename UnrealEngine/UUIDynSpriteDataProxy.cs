using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002148 RID: 8520
	[UnrealObjectPath("/Script/LGUI.UIDynSpriteDataProxy")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UUIDynSpriteDataProxy : ULGUISpriteData_BaseObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060201E9 RID: 131561 RVA: 0x002FC02B File Offset: 0x002FA22B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIDynSpriteDataProxy._ClassPtr;
		}

		// Token: 0x060201EA RID: 131562 RVA: 0x002FC038 File Offset: 0x002FA238
		public UUIDynSpriteDataProxy() : this(BuiltinUtils.AllocNativeUObject(UUIDynSpriteDataProxy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060201EB RID: 131563 RVA: 0x002FC060 File Offset: 0x002FA260
		[NullableContext(1)]
		public UUIDynSpriteDataProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIDynSpriteDataProxy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007E1C RID: 32284
		// (get) Token: 0x060201EC RID: 131564 RVA: 0x002FC093 File Offset: 0x002FA293
		// (set) Token: 0x060201ED RID: 131565 RVA: 0x002FC0A7 File Offset: 0x002FA2A7
		[Nullable(2)]
		public unsafe UUIDynSpriteData InternalSpriteData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUIDynSpriteData>(base.NativePtr / (IntPtr)sizeof(void*) + UUIDynSpriteDataProxy.__PropertyOffset_InternalSpriteData);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIDynSpriteDataProxy.__PropertyOffset_InternalSpriteData, value);
			}
		}

		// Token: 0x060201EE RID: 131566 RVA: 0x002FC0BC File Offset: 0x002FA2BC
		public bool IsDynamicSpriteDataValid()
		{
			return UUIDynSpriteDataProxy.__IsDynamicSpriteDataValid_Internal(base.NativePtr);
		}

		// Token: 0x060201EF RID: 131567
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsDynamicSpriteDataValid_Internal(IntPtr @this);

		// Token: 0x060201F0 RID: 131568 RVA: 0x002FC0C9 File Offset: 0x002FA2C9
		static UUIDynSpriteDataProxy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIDynSpriteDataProxy");
		}

		// Token: 0x060201F1 RID: 131569 RVA: 0x002FC0D7 File Offset: 0x002FA2D7
		protected UUIDynSpriteDataProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011481 RID: 70785
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIDynSpriteDataProxy";

		// Token: 0x04011482 RID: 70786
		private static IntPtr _ClassPtr;

		// Token: 0x04011483 RID: 70787
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011484 RID: 70788
		internal static int __PropertyOffset_InternalSpriteData;
	}
}
