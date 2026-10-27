using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016B9 RID: 5817
	[UnrealObjectPath("/Script/KuroBuildingGridSystem.KuroBuildingGridSettings")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UKuroBuildingGridSettings : UDeveloperSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601516A RID: 86378 RVA: 0x001EFF02 File Offset: 0x001EE102
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroBuildingGridSettings._ClassPtr;
		}

		// Token: 0x0601516B RID: 86379 RVA: 0x001EFF10 File Offset: 0x001EE110
		public UKuroBuildingGridSettings() : this(BuiltinUtils.AllocNativeUObject(UKuroBuildingGridSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601516C RID: 86380 RVA: 0x001EFF38 File Offset: 0x001EE138
		[NullableContext(1)]
		public UKuroBuildingGridSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroBuildingGridSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700536D RID: 21357
		// (get) Token: 0x0601516D RID: 86381 RVA: 0x001EFF6B File Offset: 0x001EE16B
		// (set) Token: 0x0601516E RID: 86382 RVA: 0x001EFF7B File Offset: 0x001EE17B
		public unsafe float CellSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroBuildingGridSettings.__PropertyOffset_CellSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroBuildingGridSettings.__PropertyOffset_CellSize) = value;
			}
		}

		// Token: 0x1700536E RID: 21358
		// (get) Token: 0x0601516F RID: 86383 RVA: 0x001EFF8C File Offset: 0x001EE18C
		// (set) Token: 0x06015170 RID: 86384 RVA: 0x001EFF9C File Offset: 0x001EE19C
		public unsafe float Threshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroBuildingGridSettings.__PropertyOffset_Threshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroBuildingGridSettings.__PropertyOffset_Threshold) = value;
			}
		}

		// Token: 0x06015171 RID: 86385 RVA: 0x001EFFAD File Offset: 0x001EE1AD
		static UKuroBuildingGridSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBuildingGridSystem.KuroBuildingGridSettings");
		}

		// Token: 0x06015172 RID: 86386 RVA: 0x001EFFBB File Offset: 0x001EE1BB
		protected UKuroBuildingGridSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B79D RID: 47005
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBuildingGridSystem.KuroBuildingGridSettings";

		// Token: 0x0400B79E RID: 47006
		private static IntPtr _ClassPtr;

		// Token: 0x0400B79F RID: 47007
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B7A0 RID: 47008
		internal static int __PropertyOffset_CellSize;

		// Token: 0x0400B7A1 RID: 47009
		internal static int __PropertyOffset_Threshold;
	}
}
