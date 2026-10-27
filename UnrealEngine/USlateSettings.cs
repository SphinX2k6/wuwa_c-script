using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200285D RID: 10333
	[UnrealObjectPath("/Script/Slate.SlateSettings")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class USlateSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026528 RID: 156968 RVA: 0x003A36E9 File Offset: 0x003A18E9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USlateSettings._ClassPtr;
		}

		// Token: 0x06026529 RID: 156969 RVA: 0x003A36F8 File Offset: 0x003A18F8
		public USlateSettings() : this(BuiltinUtils.AllocNativeUObject(USlateSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602652A RID: 156970 RVA: 0x003A3720 File Offset: 0x003A1920
		[NullableContext(1)]
		public USlateSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USlateSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170093F2 RID: 37874
		// (get) Token: 0x0602652B RID: 156971 RVA: 0x003A3753 File Offset: 0x003A1953
		// (set) Token: 0x0602652C RID: 156972 RVA: 0x003A3763 File Offset: 0x003A1963
		public unsafe bool bExplicitCanvasChildZOrder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USlateSettings.__PropertyOffset_bExplicitCanvasChildZOrder) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USlateSettings.__PropertyOffset_bExplicitCanvasChildZOrder) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602652D RID: 156973 RVA: 0x003A3774 File Offset: 0x003A1974
		static USlateSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Slate.SlateSettings");
		}

		// Token: 0x0602652E RID: 156974 RVA: 0x003A3782 File Offset: 0x003A1982
		protected USlateSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401502C RID: 86060
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Slate.SlateSettings";

		// Token: 0x0401502D RID: 86061
		private static IntPtr _ClassPtr;

		// Token: 0x0401502E RID: 86062
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401502F RID: 86063
		internal static int __PropertyOffset_bExplicitCanvasChildZOrder;
	}
}
