using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002020 RID: 8224
	[UnrealObjectPath("/Script/LGUI.LGUIBaseEventData")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class ULGUIBaseEventData : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EFBE RID: 126910 RVA: 0x002E132F File Offset: 0x002DF52F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIBaseEventData._ClassPtr;
		}

		// Token: 0x0601EFBF RID: 126911 RVA: 0x002E133C File Offset: 0x002DF53C
		public ULGUIBaseEventData() : this(BuiltinUtils.AllocNativeUObject(ULGUIBaseEventData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EFC0 RID: 126912 RVA: 0x002E1364 File Offset: 0x002DF564
		[NullableContext(1)]
		public ULGUIBaseEventData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIBaseEventData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007B52 RID: 31570
		// (get) Token: 0x0601EFC1 RID: 126913 RVA: 0x002E1397 File Offset: 0x002DF597
		// (set) Token: 0x0601EFC2 RID: 126914 RVA: 0x002E13AB File Offset: 0x002DF5AB
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

		// Token: 0x17007B53 RID: 31571
		// (get) Token: 0x0601EFC3 RID: 126915 RVA: 0x002E13C0 File Offset: 0x002DF5C0
		// (set) Token: 0x0601EFC4 RID: 126916 RVA: 0x002E13D0 File Offset: 0x002DF5D0
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

		// Token: 0x0601EFC5 RID: 126917 RVA: 0x002E13E1 File Offset: 0x002DF5E1
		[NullableContext(1)]
		public new string ToString()
		{
			return FString.ToStringAndDeleteNativePtr(ULGUIBaseEventData.__ToString_Internal(base.NativePtr));
		}

		// Token: 0x0601EFC6 RID: 126918
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ToString_Internal(IntPtr @this);

		// Token: 0x0601EFC7 RID: 126919 RVA: 0x002E13F3 File Offset: 0x002DF5F3
		static ULGUIBaseEventData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIBaseEventData");
		}

		// Token: 0x0601EFC8 RID: 126920 RVA: 0x002E1401 File Offset: 0x002DF601
		protected ULGUIBaseEventData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010D7E RID: 68990
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIBaseEventData";

		// Token: 0x04010D7F RID: 68991
		private static IntPtr _ClassPtr;

		// Token: 0x04010D80 RID: 68992
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010D81 RID: 68993
		internal static int __PropertyOffset_selectedComponent;

		// Token: 0x04010D82 RID: 68994
		internal static int __PropertyOffset_eventType;
	}
}
