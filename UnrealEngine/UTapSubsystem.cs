using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028E8 RID: 10472
	[UnrealObjectPath("/Script/TapCommon.TapSubsystem")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UTapSubsystem : ULocalPlayerSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026D79 RID: 159097 RVA: 0x003B3C14 File Offset: 0x003B1E14
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTapSubsystem._ClassPtr;
		}

		// Token: 0x06026D7A RID: 159098 RVA: 0x003B3C20 File Offset: 0x003B1E20
		public UTapSubsystem() : this(BuiltinUtils.AllocNativeUObject(UTapSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026D7B RID: 159099 RVA: 0x003B3C48 File Offset: 0x003B1E48
		[NullableContext(1)]
		public UTapSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTapSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700959E RID: 38302
		// (get) Token: 0x06026D7C RID: 159100 RVA: 0x003B3C7B File Offset: 0x003B1E7B
		// (set) Token: 0x06026D7D RID: 159101 RVA: 0x003B3C8F File Offset: 0x003B1E8F
		[Nullable(2)]
		public unsafe UUserInterfaceSettings UISetting
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUserInterfaceSettings>(base.NativePtr / (IntPtr)sizeof(void*) + UTapSubsystem.__PropertyOffset_UISetting);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTapSubsystem.__PropertyOffset_UISetting, value);
			}
		}

		// Token: 0x1700959F RID: 38303
		// (get) Token: 0x06026D7E RID: 159102 RVA: 0x003B3CA4 File Offset: 0x003B1EA4
		// (set) Token: 0x06026D7F RID: 159103 RVA: 0x003B3CB4 File Offset: 0x003B1EB4
		public unsafe int TapWidgetZOrder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTapSubsystem.__PropertyOffset_TapWidgetZOrder);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTapSubsystem.__PropertyOffset_TapWidgetZOrder) = value;
			}
		}

		// Token: 0x06026D80 RID: 159104 RVA: 0x003B3CC5 File Offset: 0x003B1EC5
		static UTapSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/TapCommon.TapSubsystem");
		}

		// Token: 0x06026D81 RID: 159105 RVA: 0x003B3CD3 File Offset: 0x003B1ED3
		protected UTapSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015528 RID: 87336
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/TapCommon.TapSubsystem";

		// Token: 0x04015529 RID: 87337
		private static IntPtr _ClassPtr;

		// Token: 0x0401552A RID: 87338
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401552B RID: 87339
		internal static int __PropertyOffset_UISetting;

		// Token: 0x0401552C RID: 87340
		internal static int __PropertyOffset_TapWidgetZOrder;
	}
}
