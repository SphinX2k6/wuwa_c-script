using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000666 RID: 1638
	[UnrealObjectPath("/Script/LGUI.LGUIBaseEventData")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class ULGUIBaseEventData : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008DDE RID: 36318 RVA: 0x000D5A86 File Offset: 0x000D3C86
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIBaseEventData._ClassPtr;
		}

		// Token: 0x06008DDF RID: 36319 RVA: 0x000D5A94 File Offset: 0x000D3C94
		public ULGUIBaseEventData() : this(BuiltinUtils.AllocNativeUObject(ULGUIBaseEventData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008DE0 RID: 36320 RVA: 0x000D5ABC File Offset: 0x000D3CBC
		[NullableContext(1)]
		public ULGUIBaseEventData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIBaseEventData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001ADF RID: 6879
		// (get) Token: 0x06008DE1 RID: 36321 RVA: 0x000D5AEF File Offset: 0x000D3CEF
		// (set) Token: 0x06008DE2 RID: 36322 RVA: 0x000D5B03 File Offset: 0x000D3D03
		[Nullable(2)]
		public unsafe USceneComponent selectedComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIBaseEventData.__PropertyOffset_selectedComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIBaseEventData.__PropertyOffset_selectedComponent, value);
			}
		}

		// Token: 0x17001AE0 RID: 6880
		// (get) Token: 0x06008DE3 RID: 36323 RVA: 0x000D5B18 File Offset: 0x000D3D18
		// (set) Token: 0x06008DE4 RID: 36324 RVA: 0x000D5B28 File Offset: 0x000D3D28
		public unsafe EPointerEventType eventType
		{
			get
			{
				return (EPointerEventType)(*(base.NativePtr + (IntPtr)ULGUIBaseEventData.__PropertyOffset_eventType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIBaseEventData.__PropertyOffset_eventType) = (byte)value;
			}
		}

		// Token: 0x06008DE5 RID: 36325 RVA: 0x000D5B39 File Offset: 0x000D3D39
		[NullableContext(1)]
		public new string ToString()
		{
			return FString.ToStringAndDeleteNativePtr(ULGUIBaseEventData.__ToString_Internal(base.NativePtr));
		}

		// Token: 0x06008DE6 RID: 36326
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ToString_Internal(IntPtr @this);

		// Token: 0x06008DE7 RID: 36327 RVA: 0x000D5B4B File Offset: 0x000D3D4B
		static ULGUIBaseEventData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIBaseEventData");
		}

		// Token: 0x06008DE8 RID: 36328 RVA: 0x000D5B59 File Offset: 0x000D3D59
		protected ULGUIBaseEventData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003E86 RID: 16006
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIBaseEventData";

		// Token: 0x04003E87 RID: 16007
		private static IntPtr _ClassPtr;

		// Token: 0x04003E88 RID: 16008
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003E89 RID: 16009
		internal static int __PropertyOffset_selectedComponent;

		// Token: 0x04003E8A RID: 16010
		internal static int __PropertyOffset_eventType;
	}
}
