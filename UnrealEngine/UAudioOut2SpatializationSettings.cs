using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002673 RID: 9843
	[UnrealObjectPath("/Script/PS5AudioFeatures.AudioOut2SpatializationSettings")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UAudioOut2SpatializationSettings : USoundfieldEncodingSettingsBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060248EF RID: 149743 RVA: 0x00361EA7 File Offset: 0x003600A7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAudioOut2SpatializationSettings._ClassPtr;
		}

		// Token: 0x060248F0 RID: 149744 RVA: 0x00361EB4 File Offset: 0x003600B4
		public UAudioOut2SpatializationSettings() : this(BuiltinUtils.AllocNativeUObject(UAudioOut2SpatializationSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060248F1 RID: 149745 RVA: 0x00361EDC File Offset: 0x003600DC
		[NullableContext(1)]
		public UAudioOut2SpatializationSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAudioOut2SpatializationSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008CE8 RID: 36072
		// (get) Token: 0x060248F2 RID: 149746 RVA: 0x00361F0F File Offset: 0x0036010F
		// (set) Token: 0x060248F3 RID: 149747 RVA: 0x00361F1F File Offset: 0x0036011F
		public unsafe float Spread
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAudioOut2SpatializationSettings.__PropertyOffset_Spread);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAudioOut2SpatializationSettings.__PropertyOffset_Spread) = value;
			}
		}

		// Token: 0x17008CE9 RID: 36073
		// (get) Token: 0x060248F4 RID: 149748 RVA: 0x00361F30 File Offset: 0x00360130
		// (set) Token: 0x060248F5 RID: 149749 RVA: 0x00361F40 File Offset: 0x00360140
		public unsafe int Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAudioOut2SpatializationSettings.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAudioOut2SpatializationSettings.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x17008CEA RID: 36074
		// (get) Token: 0x060248F6 RID: 149750 RVA: 0x00361F51 File Offset: 0x00360151
		// (set) Token: 0x060248F7 RID: 149751 RVA: 0x00361F61 File Offset: 0x00360161
		public unsafe bool Passthrough
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAudioOut2SpatializationSettings.__PropertyOffset_Passthrough) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAudioOut2SpatializationSettings.__PropertyOffset_Passthrough) = (value ? 1 : 0);
			}
		}

		// Token: 0x060248F8 RID: 149752 RVA: 0x00361F72 File Offset: 0x00360172
		static UAudioOut2SpatializationSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/PS5AudioFeatures.AudioOut2SpatializationSettings");
		}

		// Token: 0x060248F9 RID: 149753 RVA: 0x00361F80 File Offset: 0x00360180
		protected UAudioOut2SpatializationSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013A4C RID: 80460
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/PS5AudioFeatures.AudioOut2SpatializationSettings";

		// Token: 0x04013A4D RID: 80461
		private static IntPtr _ClassPtr;

		// Token: 0x04013A4E RID: 80462
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013A4F RID: 80463
		internal static int __PropertyOffset_Spread;

		// Token: 0x04013A50 RID: 80464
		internal static int __PropertyOffset_Priority;

		// Token: 0x04013A51 RID: 80465
		internal static int __PropertyOffset_Passthrough;
	}
}
