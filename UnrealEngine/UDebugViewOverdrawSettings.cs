using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002685 RID: 9861
	[UnrealObjectPath("/Script/Renderer.DebugViewOverdrawSettings")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UDebugViewOverdrawSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060249EA RID: 149994 RVA: 0x0036371B File Offset: 0x0036191B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDebugViewOverdrawSettings._ClassPtr;
		}

		// Token: 0x060249EB RID: 149995 RVA: 0x00363728 File Offset: 0x00361928
		public UDebugViewOverdrawSettings() : this(BuiltinUtils.AllocNativeUObject(UDebugViewOverdrawSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060249EC RID: 149996 RVA: 0x00363750 File Offset: 0x00361950
		[NullableContext(1)]
		public UDebugViewOverdrawSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDebugViewOverdrawSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008D33 RID: 36147
		// (get) Token: 0x060249ED RID: 149997 RVA: 0x00363783 File Offset: 0x00361983
		// (set) Token: 0x060249EE RID: 149998 RVA: 0x00363797 File Offset: 0x00361997
		public unsafe FLinearColor OverdrawColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDebugViewOverdrawSettings.__PropertyOffset_OverdrawColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDebugViewOverdrawSettings.__PropertyOffset_OverdrawColor) = value;
			}
		}

		// Token: 0x060249EF RID: 149999 RVA: 0x003637AC File Offset: 0x003619AC
		static UDebugViewOverdrawSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Renderer.DebugViewOverdrawSettings");
		}

		// Token: 0x060249F0 RID: 150000 RVA: 0x003637BA File Offset: 0x003619BA
		protected UDebugViewOverdrawSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013AEB RID: 80619
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Renderer.DebugViewOverdrawSettings";

		// Token: 0x04013AEC RID: 80620
		private static IntPtr _ClassPtr;

		// Token: 0x04013AED RID: 80621
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013AEE RID: 80622
		internal static int __PropertyOffset_OverdrawColor;
	}
}
